namespace Ergonomics

open FSharp.Core
open System
open System.IO
open System.Text
open VDS.RDF
open VDS.RDF.Writing.Formatting
open VDS
open VDS.RDF.Query.Datasets
open VDS.RDF.Writing
open System.Globalization
open VDS.RDF.Parsing


module Shorthand =

    module LangTag = 
        let inhabitant (langTag:string) = CultureInfo.GetCultureInfo langTag
        let en = inhabitant "en"
        let us = inhabitant "en-us"


    // A "draft" statement: syntactic construction first, materialization later.
    // Important: rawObject is preserved so @@ and ^^ can reinterpret *the original token*.
    type StatementDraft =
        {
          graph: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type option
          subject: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type
          predicate: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type
          rawObject: obj
          culture: CultureInfo option
          datatype: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type option
        }

    // --------------------------
    // Literal typing policy
    // --------------------------
    //
    // This is the *only* place where "automatic typing" is decided.
    // Your surface syntax stays stable; you tune this policy as you like.

    let  invariantCulture = CultureInfo.InvariantCulture

    // Map CLR runtime types -> XSD datatype quiries (your xsd.fsx values).
    // Adjust this mapping as you refine your system.
    let xsdBoolean = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2001/XMLSchema#" None (Some "xsd") (Some "boolean")
    let xsdInt = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2001/XMLSchema#" None (Some "xsd") (Some "int")
    let xsdLong = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2001/XMLSchema#" None (Some "xsd") (Some "long")
    let xsdDecimal = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2001/XMLSchema#" None (Some "xsd") (Some "decimal")
    let xsdDouble = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2001/XMLSchema#" None (Some "xsd") (Some "double")
    let xsdDateTime = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2001/XMLSchema#" None (Some "xsd") (Some "datetime")
    let xsdDate = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2001/XMLSchema#" None (Some "xsd") (Some "date")

    let tryInferDatatypeQuirie (o: obj) : Communication.Internet.Standard.Resource.Identifier.Internationalized.Type option =
        match o with
        | :? bool -> Some xsdBoolean
        | :? int -> Some xsdInt
        | :? int64 -> Some xsdLong
        | :? decimal -> Some xsdDecimal
        | :? float -> Some xsdDouble
        | :? DateTime -> Some xsdDateTime
        | :? DateOnly -> Some xsdDate
        | _ -> None

    // Produce the lexical form for non-string primitives.
    // Must be deterministic and culture-stable.
    let lexicalForm (o: obj) : string =
        match o with
        | :? bool as b -> if b then "true" else "false"
        | :? IFormattable as f -> f.ToString(null, invariantCulture)
        | _ -> string o

    // --------------------------
    // RDF materialization
    // --------------------------
    //
    // You already have quiries -> ._nodeFromGraph(g), so we lean on that.
    // We materialize either:
    //   - Resource node (when rawObject is a Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)
    //   - Literal node (strings, numbers, bools, DateTime, etc.)
    // With optional @@ culture and ^^ datatype overrides (strings only).

    let  fail (message: string) = invalidArg "StatementDraft" message

    let  asQuirie (o: obj) : Communication.Internet.Standard.Resource.Identifier.Internationalized.Type option =
        match o with
        | :? Communication.Internet.Standard.Resource.Identifier.Internationalized.Type as q -> Some q
        | _ -> None

    let  asString (o: obj) : string option =
        match o with
        | :? string as s -> Some s
        | _ -> None

    /// Create a VDS.RDF.RDF.Triple from a draft, using the provided graph.
    /// Note: graph naming (dataset vs single graph) is not forced here; we just build a RDF.Triple in `g`.
    /// If you want "named graph storage", you’ll likely route this through a RDF.TripleStore / Dataset later.
    let toTriple (g: RDF.IGraph) (draft: StatementDraft) : RDF.Triple =
        let sNode = draft.subject._nodeFromGraph g
        let pNode = draft.predicate._nodeFromGraph g

        // If the object is a Communication.Internet.Standard.Resource.Identifier.Internationalized.Type, it is a resource IRI node.
        match asQuirie draft.rawObject with
        | Some objectQuirie ->
            let oNode = objectQuirie._nodeFromGraph g
            RDF.Triple(sNode, pNode, oNode)

        | None ->
            match draft.rawObject with
            | :? Uri as  uriObject -> RDF.Triple(sNode, pNode, g.CreateUriNode(uriObject))
            | _ ->
                // Otherwise we treat it as a literal-like token.

                // Culture typing and explicit datatype are only meaningful for lexical strings in your design.
                // For non-strings, we infer datatype from runtime type.
                match asString draft.rawObject with
                | Some lexicalString ->
                    match draft.culture, draft.datatype with
                    | Some cultureInfo, Some _ ->
                        fail "Both @@ culture and ^^ datatype were applied to the same string. Turtle disallows combining them; pick one."
                    | Some cultureInfo, None ->
                        let lit = g.CreateLiteralNode(lexicalString, cultureInfo.IetfLanguageTag)
                        RDF.Triple(sNode, pNode, lit)
                    | None, Some datatypeQuirie ->
                        let lit = g.CreateLiteralNode(lexicalString, datatypeQuirie._uri)
                        RDF.Triple(sNode, pNode, lit)
                    | None, None ->
                        // Plain string literal defaults to xsd:string in many systems, but Turtle treats it as a simple literal.
                        // Decide your preference; here we emit a plain literal with no datatype/lang.
                        let lit = g.CreateLiteralNode(lexicalString)
                        RDF.Triple(sNode, pNode, lit)

                | None ->
                    // Non-string primitive: infer datatype quiries if possible, else emit plain literal.
                    let lex = lexicalForm draft.rawObject
                    match tryInferDatatypeQuirie draft.rawObject with
                    | Some datatypeQuirie ->
                        let lit = g.CreateLiteralNode(lex, datatypeQuirie._uri)
                        RDF.Triple(sNode, pNode, lit)
                    | None ->
                        let lit = g.CreateLiteralNode(lex)
                        RDF.Triple(sNode, pNode, lit)

    


    let  ensureNamespaceForQuirie
        (g: RDF.IGraph)
        (q: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)
        : unit =

        match q._namespacePrefix with
        | None ->
            () // nothing to register
        | Some prefix ->
            let nsUri = q._namespaceUri

            // If the prefix does not exist, add it.
            if not (g.NamespaceMap.HasNamespace prefix) then
                g.NamespaceMap.AddNamespace(prefix, nsUri)
            else
                // If it exists, ensure it matches the same URI.
                let existing = g.NamespaceMap.GetNamespaceUri(prefix)
                if existing <> nsUri then
                    invalidArg
                        "q"
                        $"Namespace prefix collision: prefix '{prefix}' is already mapped to '{existing.OriginalString}', but attempted to map it to '{nsUri.OriginalString}'."

    let ensureNamespacesForDraft (g: RDF.IGraph) (draft: StatementDraft) : unit =
        ensureNamespaceForQuirie g draft.subject
        ensureNamespaceForQuirie g draft.predicate

        // If object is a Quirie, register it too.
        match draft.rawObject with
        | :? Communication.Internet.Standard.Resource.Identifier.Internationalized.Type as objectQuirie ->
            ensureNamespaceForQuirie g objectQuirie
        | _ -> ()

        // If a datatype was supplied (^^), register it too.
        match draft.datatype with
        | Some dt -> ensureNamespaceForQuirie g dt
        | None -> ()
                    

    module NamedGraph =
        type Type = {
                    iri:Communication.Internet.Standard.Resource.Identifier.Internationalized.Type
                    graph:IGraph
                    filePath: string
                    }
                    member this._isHashNamespace = this.iri._isHashNamespace
                    member this._isSlashNamespace = this.iri._isSlashNamespace
                    member this._uri: Communication.Internet.Standard.Resource.Identifier.Uniform.Type = this.iri._uri
                    member this._vocabularyUri: Communication.Internet.Standard.Resource.Identifier.Uniform.Type = this.iri._vocabularyUri
                    member this._nodeFromGraph(g: IGraph) = this.iri._nodeFromGraph g
                    member this._namespaceNode = this.iri._namespaceNode
                    member this._node = this.iri._node
                    member this._prefix(localName: string) = this.iri._prefix localName
        let inhabitant(iri:Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)(filePath : string) = 
            
            let dir = Path.GetDirectoryName(filePath)
            if
                not (String.IsNullOrWhiteSpace(dir))
                && not (Directory.Exists(dir))
            then
                Directory.CreateDirectory(dir) |> ignore
            {
                iri = iri 
                graph = new ThreadSafeGraph(iri._node)
                filePath = filePath
            }
        let fromIGraph(iri:Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)(filePath : string)(graph:IGraph) = 
            
            let dir = Path.GetDirectoryName(filePath)
            if
                not (String.IsNullOrWhiteSpace(dir))
                && not (Directory.Exists(dir))
            then
                Directory.CreateDirectory(dir) |> ignore
            {
                iri = iri 
                graph = graph
                filePath = filePath
            }
    
    let defaultGraphUriString = "urn:graph:default"
    let defaultGraphIri = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
                            defaultGraphUriString
                            None
                            None 
                            None
    let defaultGraphGraph : ThreadSafeGraph =
        let graph = new ThreadSafeGraph()
        graph.BaseUri <- defaultGraphIri._node.Uri
        graph

    module GraphRuntime =


        let store : ThreadSafeTripleStore = new ThreadSafeTripleStore()

        let inMemoryDataset = new InMemoryDataset(store, defaultGraphIri._node)
        inMemoryDataset.SetDefaultGraph defaultGraphIri._node

        let mergeOnCollision = true

        let ensureDefaultGraph () : IGraph =
            defaultGraphGraph :> IGraph

        // dotNetRDF now keys stores by IRefNode (graph name node), not Uri overloads.
        let private graphNameNode
            (graphIri: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)
            : IRefNode =
            // Graph name is the graph IRI itself.
            // UriNode(Uri) implements IUriNode -> IRefNode.
            UriNode(graphIri._uri) :> IRefNode

        let ensureNamedGraph
            (namedGraph: NamedGraph.Type)
            : IGraph =

            if inMemoryDataset.HasGraph namedGraph.graph.Name then
                let foundGraph = inMemoryDataset.Graphs |> Seq.filter (fun graph -> graph.Name = namedGraph.graph.Name) |> Seq.head
                foundGraph
            else
                inMemoryDataset.AddGraph(namedGraph.graph) |> ignore
                namedGraph.graph
            
        
        module Serialization =
        


            // later:
            // validationFunction = Func<string,bool>(isValidQNameRelaxed)



            /// Turtle-compatible escaping for PN_LOCAL when you want to keep prefixed names
            /// but avoid raw non-ASCII. This turns non-ASCII into \uXXXX or \UXXXXXXXX.
            /// (If you *want* raw glyphs, you can skip this and return the input.)
            let private escapeAsTurtleUChar (s: string) =
                let sb = StringBuilder(s.Length)
                for ch in s do
                    let code = int ch
                    if code <= 0x7F then
                        sb.Append(ch) |> ignore
                    elif code <= 0xFFFF then
                        sb.Append("\\u").Append(code.ToString("X4")) |> ignore
                    else
                        sb.Append("\\U").Append(code.ToString("X8")) |> ignore
                sb.ToString()
        
            /// Decide whether you want raw glyphs in PN_LOCAL.
            /// If you truly want raw "À" in the file, set this to `id`.
            /// If you want maximum Turtle portability, keep `escapeAsTurtleUChar`.
            let private normalizeLocalForTurtle = escapeAsTurtleUChar
        
            let private percentEncodeCharUtf8 (ch: char) =
                // Percent-encode the UTF-8 bytes for this single char.
                // (Note: this handles BMP chars; surrogate pairs require extra handling if you expect them.)
                let bytes = Encoding.UTF8.GetBytes([| ch |])
                bytes
                |> Seq.map (fun b -> "%" + b.ToString("X2"))
                |> String.concat ""

            let private isForbiddenInTurtleIriRef (ch: char) =
                // Turtle IRIREF exclusions + controls/space.
                // Controls: U+0000..U+0020 and U+007F.
                let code = int ch
                code <= 0x20
                || code = 0x7F
                || ch = '<' || ch = '>' || ch = '"' || ch = '{' || ch = '}' || ch = '|'
                || ch = '^' || ch = '`' || ch = '\\'

            let private escapeIriRefByPercentEncoding (iri: string) =
                let sb = StringBuilder(iri.Length)
                for ch in iri do
                    if isForbiddenInTurtleIriRef ch then
                        sb.Append(percentEncodeCharUtf8 ch) |> ignore
                    else
                        sb.Append(ch) |> ignore
                sb.ToString()

            let private formatIriRef (uri: Uri) =
                // Keep Unicode as-is wherever permissible.
                // Percent-encode only the forbidden characters above.
                "<" + escapeIriRefByPercentEncoding uri.OriginalString + ">"
            let isValidPrefixedName (s: string) =
                if s.Contains(".") then true
                else TurtleSpecsHelper.IsValidQName(s)
            
            type UnicodePrefixedNameTurtleW3CFormatter(g: IGraph) =
                inherit TurtleW3CFormatter(g)
            
                let prefixedNameMapper = new QNameOutputMapper(g.NamespaceMap)
            
                override _.IsValidQName(value: string) = isValidPrefixedName value
            
                                
                override _.FormatUriNode(u: IUriNode, segment: Nullable<TripleSegment>) =
                    let uri = u.Uri

                    if segment.HasValue
                       && segment.Value = TripleSegment.Predicate
                       && uri.AbsoluteUri.Equals(RdfSpecsHelper.RdfType, StringComparison.Ordinal) then
                        "a"
                    else
                        let source = uri.OriginalString
                        let mutable prefixedName = ""

                        let reduced =
                            prefixedNameMapper.ReduceToQName(
                                source,
                                &prefixedName,
                                validationFunction = Func<string, bool>(isValidPrefixedName)
                            )

                        if reduced then
                            prefixedName
                        else
                            // dotNetRDF’s normal behavior: fall back to IRIREF.
                            // Our tweak: use OriginalString + Turtle escapes instead of percent encoding.
                            formatIriRef uri
            let private writeAllPrefixes (tw: TextWriter) (g: IGraph) =
                g.NamespaceMap.Prefixes
                |> Seq.sort
                |> Seq.iter (fun p ->
                    let ns = g.NamespaceMap.GetNamespaceUri(p)
                    // Use OriginalString for stable spelling in the file.
                    tw.Write("@prefix ")
                    tw.Write(p)
                    tw.Write(": <")
                    tw.Write(ns.OriginalString)
                    tw.WriteLine("> .")
                )
                tw.WriteLine()
        
            module Turtle =
                
                let save (namedGraph: NamedGraph.Type) =
                    let g = ensureNamedGraph namedGraph
                    let filePath = namedGraph.filePath + ".ttl"
        
                    try
                        // Ensure the directory exists
                        let dir = Path.GetDirectoryName(filePath)
        
                        if not (String.IsNullOrWhiteSpace(dir)) && not (Directory.Exists(dir)) then
                            Directory.CreateDirectory(dir) |> ignore
        
                        // Use explicit UTF-8 (no BOM)
                        use fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Read)
                        use tw = new StreamWriter(fs, new UTF8Encoding(encoderShouldEmitUTF8Identifier = false))
        
                        // 1) Emit ONLY the prefixes dotNetRDF would “miss” (your existing workaround)
                        writeAllPrefixes tw g
        
                        // 2) Serialize triples with our formatter (prefixed names, Unicode locals)
                        let formatter = UnicodePrefixedNameTurtleW3CFormatter(g) :> ITripleFormatter
        
                        g.Triples.Asserted |> Seq.iter (fun triple -> 
                            let line = formatter.Format(triple)
                            tw.WriteLine(line)
                        )
        
                        tw.Flush()
                        printfn "File saved successfully: %s" filePath
        
                    with
                    | :? UnauthorizedAccessException ->
                        printfn "Error: Access denied to '%s'." filePath
                    | :? DirectoryNotFoundException ->
                        printfn "Error: Directory not found for '%s'." filePath
                    | :? IOException as ex ->
                        printfn "I/O Error: %s" ex.Message
                    | ex ->
                        printfn "Unexpected error: %s" ex.Message                
    /// Convenience: add the triple to a graph.
    let assertIntoGraph (g: RDF.IGraph) (draft: StatementDraft) : bool =
            ensureNamespacesForDraft g draft
            g.Assert(toTriple g draft)



    // ---------------------------------------
    // Graph routing (Default vs Named)
    // ---------------------------------------

    let isDefaultGraphToken
        (namedGraph: NamedGraph.Type)
        : bool =
        namedGraph.iri._namespaceUri.OriginalString = defaultGraphUriString
        && namedGraph.iri._localName = ""

    // ---------------------------------------
    // Asserting into graphs
    // ---------------------------------------

    let assertDefault (draft: StatementDraft) : bool =
        assertIntoGraph defaultGraphGraph draft

    let assertNamed
        (namedGraph: NamedGraph.Type)
        (draft: StatementDraft)
        : bool =
        assertIntoGraph (GraphRuntime.ensureNamedGraph namedGraph) draft

    let assertOne
        (namedGraph: NamedGraph.Type)
        (draft: StatementDraft)
        : bool =

        if isDefaultGraphToken namedGraph then
            assertDefault draft
        else
            assertNamed namedGraph draft

    // --------------------------
    // Shorthand operators
    // --------------------------
    //
    // These are intentionally top-level so that after #load "Shorthand.fsx"
    // you can write them without any open, matching your constraint.
    type PredicateObjectClause =
        { predicate: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type
          rawObjectList: obj list
          culture: CultureInfo option
          datatype: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type option }
      
    let (@@) (draftList: StatementDraft list) (cultureInfo: CultureInfo) : StatementDraft list =
        draftList |> List.map (fun draft -> { draft with culture = Some cultureInfo; datatype = None })

    let (^^) (draftList: StatementDraft list) (datatype: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) : StatementDraft list =
        draftList |> List.map (fun draft -> { draft with datatype = Some datatype; culture = None })

    let (@-@) (clause: PredicateObjectClause) (cultureInfo: CultureInfo) : PredicateObjectClause =
        { clause with culture = Some cultureInfo; datatype = None }

    let (^-^) (clause: PredicateObjectClause) (datatype: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) : PredicateObjectClause =
        { clause with datatype = Some datatype; culture = None }

    let (=-=) (subjectList: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type list) (predicateList: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type list)
        : (Communication.Internet.Standard.Resource.Identifier.Internationalized.Type * Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) list =
        [ for subject in subjectList do
            for predicate in predicateList do
              yield (subject, predicate) ]
    let (=->) (subjectPredicatePairs: (Communication.Internet.Standard.Resource.Identifier.Internationalized.Type * Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) list) (objectList: 'a list)
        : StatementDraft list =
        [ for (subject, predicate) in subjectPredicatePairs do
            for objValue in objectList do
              yield
                { graph = None
                  subject = subject
                  predicate = predicate
                  rawObject = box objValue
                  culture = None
                  datatype = None } ]
    let (>=:) (draftList: StatementDraft list) (namedGraphList: NamedGraph.Type list) =
        match namedGraphList with
        | [] -> invalidArg "graphNameList" "Graph list is empty."
        | _ ->
            namedGraphList
            |> List.iter (fun namedGraph ->
                draftList
                |> List.iter (fun draft -> assertOne namedGraph draft |> ignore))
    // subject --- predicate  ≡  [subject] =-= [predicate]
    let (---) (subject: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) (predicate: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) : (Communication.Internet.Standard.Resource.Identifier.Internationalized.Type * Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) list =
            [subject] =-= [predicate]

    // pairs --> obj  ≡  pairs =-> [obj]
    let (-->) (subjectPredicatePairs: (Communication.Internet.Standard.Resource.Identifier.Internationalized.Type * Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) list) (objValue: 'a) : StatementDraft list =
            subjectPredicatePairs =-> [objValue]

    // drafts >-: graph  ≡  drafts >=: [graph]
    let (>-:) (draftList: StatementDraft list) (namedGraph: NamedGraph.Type)  =
        draftList >=: [namedGraph]

    // [subjects] --~ predicate   (subject list, predicate scalar)
    let (-=-) (subjectList: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type list) (predicate: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) : (Communication.Internet.Standard.Resource.Identifier.Internationalized.Type * Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) list =
        subjectList =-= [predicate]

    // subject ~-- [predicates]   (subject scalar, predicate list)
    let (--=) (subject: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) (predicateList: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type list) : (Communication.Internet.Standard.Resource.Identifier.Internationalized.Type * Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) list =
        [subject] =-= predicateList



    // predicate ==>: [objects]   (explicitly paired; no cartesian with other predicates)
    let (-~=) (predicate: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) (objectList: 'a list) : PredicateObjectClause =
        { predicate = predicate
          rawObjectList = objectList |> List.map box
          culture = None
          datatype = None }
    // predicate ==>: [objects]   (explicitly paired; no cartesian with other predicates)
    let (-~-) (predicate: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) (curObject: 'a) : PredicateObjectClause =
        predicate -~= [curObject]

    let (=~-) (predicateList: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type list) (objectList: 'a list) : PredicateObjectClause list =
        predicateList |> List.map (fun p -> p -~= objectList)
    // let (-~=) (predicate: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type) (objectListList: 'a list list) : PredicateObjectClause list =
    //     objectListList |> List.map (fun objectList -> predicate -~= objectList)
    let (=~=) (predicateList: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type list) (objectList: 'a list) : PredicateObjectClause list =
        [ for p in predicateList do
            for o in objectList do
              yield p -~= [o] ]
    // subject ===: [clauses]  -> drafts
    let (--~) (subject: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type ) (clauseList: PredicateObjectClause list) : StatementDraft list =
        [ for clause in clauseList do
            for objValue in clause.rawObjectList do
              yield
                { graph = None
                  subject = subject
                  predicate = clause.predicate
                  rawObject = objValue
                  culture = clause.culture
                  datatype = clause.datatype } ]
    let (=-~) (subjectList: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type list) (clauseList: PredicateObjectClause list) : StatementDraft list =
        subjectList |> List.collect (fun s -> s --~ clauseList)
