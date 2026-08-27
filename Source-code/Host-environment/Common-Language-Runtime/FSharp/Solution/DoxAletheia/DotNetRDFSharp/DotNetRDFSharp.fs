module DoxAletheia.DotNetRDFSharp

open System
open System.IO
open System.Xml
open System.Globalization
open System.Collections
open System.Text


open VDS.RDF
open VDS.RDF.Nodes
open VDS.RDF.Query.Builder
open VDS.RDF.Query.Patterns
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Query
open VDS.RDF.Parsing.Tokens


open FSharp.Data
open FSharp.Data.Adaptive.Transaction
open FSharp.HashCollections
open FSharp.Collections.ParallelSeq


open Swensen.Unquote.Assertions


open DoxAletheia

open type Prefix_ID

open NamespaceRegistry
open PrettierNaming
open IOExtensions



let prefix_registry =
    JsonProvider<Document.PrefixRegistry.literal_path>.Load Document.PrefixRegistry.literal_path

let prefix_map =
    prefix_registry.PrefixIds
    |> Array.filter (fun prefix_id -> prefix_id.NamespaceName <> "http://www.w3.org/")
    |> Array.map (fun prefix_id ->
        match prefix_id.NamespaceName, prefix_id.NamespacePrefix with
        | "https://www.w3.org/ns/posix/stat#", namespace_prefix ->
            prefix_id.NamespaceName,
            { namespace_name = "https://www.w3.org/ns/posix/stat.rdf#"
              namespace_prefix = prefix_id.NamespacePrefix }
        | _, _ ->
            prefix_id.NamespaceName,
            { namespace_name = prefix_id.NamespaceName
              namespace_prefix = prefix_id.NamespacePrefix })
    |> Map.ofArray





module NTriples =

    let private appendUnicodeEscape (builder: StringBuilder) (codePoint: int) =
        if codePoint <= 0xFFFF then
            builder
                .Append("\\u")
                .Append(codePoint.ToString("X4", CultureInfo.InvariantCulture))
            |> ignore
        else
            builder
                .Append("\\U")
                .Append(codePoint.ToString("X8", CultureInfo.InvariantCulture))
            |> ignore

    /// Encodes an RDF lexical form as the contents of an
    /// N-Triples STRING_LITERAL_QUOTE.
    ///
    /// The returned value does not include the outer quotation marks.
    let escapeLexicalForm (value: string) : string =
        if isNull value then
            nullArg (nameof value)

        let builder = StringBuilder(value.Length + 16)
        let mutable index = 0

        while index < value.Length do
            let character = value[index]

            match character with
            | '"' -> builder.Append("\\\"") |> ignore

            | '\\' -> builder.Append("\\\\") |> ignore

            | '\t' -> builder.Append("\\t") |> ignore

            | '\b' -> builder.Append("\\b") |> ignore

            | '\n' -> builder.Append("\\n") |> ignore

            | '\r' -> builder.Append("\\r") |> ignore

            | '\f' -> builder.Append("\\f") |> ignore

            // Preserve valid non-BMP Unicode scalar values.
            | _ when Char.IsHighSurrogate character ->
                if
                    index + 1 >= value.Length
                    || not (Char.IsLowSurrogate value[index + 1])
                then
                    invalidArg (nameof value) $"Unpaired UTF-16 high surrogate at index {index}."

                builder.Append(character).Append(value[index + 1])
                |> ignore

                index <- index + 1

            // A low surrogate cannot occur independently.
            | _ when Char.IsLowSurrogate character ->
                invalidArg (nameof value) $"Unpaired UTF-16 low surrogate at index {index}."

            | _ ->
                let codePoint = int character

                // Escaping these is conservative and avoids embedding
                // invisible control characters in the output document.
                if codePoint <= 0x1F
                   || (codePoint >= 0x7F && codePoint <= 0x9F)
                   || codePoint = 0x2028
                   || codePoint = 0x2029 then
                    appendUnicodeEscape builder codePoint
                else
                    builder.Append(character) |> ignore

            index <- index + 1

        builder.ToString()

    let quotedLiteral (lexicalForm: string) : string =
        "\"" + escapeLexicalForm lexicalForm + "\""




    // Include appendUnicodeEscape and escapeLexicalForm from above.

    let escapeIriReference (value: string) : string =
        if isNull value then
            nullArg (nameof value)

        let builder = StringBuilder(value.Length + 16)
        let mutable index = 0

        while index < value.Length do
            let character = value[index]

            if Char.IsHighSurrogate character then
                if
                    index + 1 >= value.Length
                    || not (Char.IsLowSurrogate value[index + 1])
                then
                    invalidArg (nameof value) $"Unpaired UTF-16 high surrogate at index {index}."

                builder.Append(character).Append(value[index + 1])
                |> ignore

                index <- index + 1

            elif Char.IsLowSurrogate character then
                invalidArg (nameof value) $"Unpaired UTF-16 low surrogate at index {index}."

            else
                let codePoint = int character

                let mustEscape =
                    codePoint <= 0x20
                    || character = '<'
                    || character = '>'
                    || character = '"'
                    || character = '{'
                    || character = '}'
                    || character = '|'
                    || character = '^'
                    || character = '`'
                    || character = '\\'
                    || (codePoint >= 0x7F && codePoint <= 0x9F)

                if mustEscape then
                    appendUnicodeEscape builder codePoint
                else
                    builder.Append(character) |> ignore

            index <- index + 1

        builder.ToString()

    let iriReference (iri: string) : string = "<" + escapeIriReference iri + ">"

    let typedLiteral (lexicalForm: string) (datatypeIri: string) : string =
        quotedLiteral lexicalForm
        + "^^"
        + iriReference datatypeIri

















type Initial_Text_Direction =
    | Ltr
    | Rtl
    member this.as_string = this.ToString().ToLowerInvariant()




type Iri =
    | IRIREF of Iri_Reference
    | NamespaceIRI of Namespace_Iri
    | PrefixedName of Prefixed_Name
    | SkolemIRI of Skolem_Iri
    static member from_vds_node(vds_node: UriNode) =

        let maybe_prefix_id =
            prefix_map
            |> Map.toArray
            |> Array.tryPick (fun (namespace_name, prefix_id) ->
                let term_is_namespaced = vds_node.Uri.OriginalString.StartsWith(namespace_name)

                if term_is_namespaced then
                    Some prefix_id
                else
                    None)

        match maybe_prefix_id with
        | Some prefix_id ->
            let local_name = vds_node.Uri.OriginalString[prefix_id.namespace_name.Length ..]

            Prefixed_Name(prefix_id, local_name)
            |> PrefixedName
        | None ->
            Iri_Reference vds_node.Uri.OriginalString
            |> IRIREF

    member this.as_subject = IriSubject this
    member this.as_predicate = IriPredicate this
    member this.as_object = IriObject this

    member this.lexical_form =
        match this with
        | IRIREF iri_reference -> iri_reference.lexical_form
        | NamespaceIRI namespace_iri -> namespace_iri.lexical_form
        | PrefixedName prefixed_name -> prefixed_name.lexical_form
        | SkolemIRI skolem_iri -> skolem_iri.lexical_form

    member this.uri =
        match this with
        | IRIREF iri_reference -> iri_reference.uri
        | NamespaceIRI namespace_iri -> namespace_iri.uri
        | PrefixedName prefixed_name -> prefixed_name.uri
        | SkolemIRI skolem_iri -> skolem_iri.uri

    member this.vds_node =
        match this with
        | IRIREF iri_reference -> iri_reference.vds_node
        | NamespaceIRI namespace_iri -> namespace_iri.vds_node
        | PrefixedName prefixed_name -> prefixed_name.vds_node
        | SkolemIRI skolem_iri -> skolem_iri.vds_node

    member this.nt =
        match this with
        | IRIREF iri_reference -> iri_reference.nt
        | NamespaceIRI namespace_iri -> namespace_iri.nt
        | PrefixedName prefixed_name -> prefixed_name.nt
        | SkolemIRI skolem_iri -> skolem_iri.nt

    member this.curie =
        match this with
        | IRIREF iri_reference -> iri_reference.nt
        | NamespaceIRI namespace_iri -> namespace_iri.curie
        | PrefixedName prefixed_name -> prefixed_name.curie
        | SkolemIRI skolem_iri -> skolem_iri.nt

and Iri_Reference(lexical_form: string) =
    let _lexical_form = lexical_form
    let _uri = new Uri(lexical_form)
    let _vds_node = new UriNode(_uri)
    let _nt = NTriples.iriReference _lexical_form
    member this.lexical_form = _lexical_form
    member this.uri = _uri
    member this.vds_node = _vds_node
    member this.iri = IRIREF this
    member this.nt = _nt

and Namespace_Iri(prefix_id: Prefix_ID) =
    let _lexical_form = prefix_id.namespace_name
    let _prefix_label = prefix_id.namespace_prefix
    let _uri = new Uri(_lexical_form)
    let _vds_node = new UriNode(_uri)
    let _iriref = Iri_Reference prefix_id.namespace_name
    let _nt = NTriples.iriReference _lexical_form
    let _curie = sprintf "%s:" _prefix_label
    member this.lexical_form = _lexical_form
    member this.uri = _uri
    member this.vds_node = _vds_node
    member this.prefix_label = _prefix_label
    member this.iriref = _iriref
    member this.iri = NamespaceIRI this
    member this.nt = _nt
    member this.curie = _curie


and Prefixed_Name(prefix_id: Prefix_ID, local_name: string) =
    let _prefix_id = prefix_id
    let _namespace_name = prefix_id.namespace_name
    let _prefix_label = prefix_id.namespace_prefix

    let _namespace_uri = new Uri(_namespace_name)
    let _namespace_vds_node = new UriNode(_namespace_uri)
    let _namespace_iri = Namespace_Iri prefix_id
    let _local_name = local_name
    let _lexical_form = _namespace_name + _local_name
    let _uri = new Uri(_lexical_form)
    let _vds_node = new UriNode(_uri)
    let _iriref = Iri_Reference _uri.OriginalString
    let _nt = _iriref.nt
    let _curie = sprintf "%s:%s" _prefix_label _local_name

    member this.namespace_name = _namespace_name
    member this.prefix_id = _prefix_id
    member this.prefix_label = _prefix_label
    member this.namespace_uri = _namespace_uri
    member this.namespace_vds_node = _namespace_vds_node
    member this.namespace_iri = _namespace_iri
    member this.local_name = _local_name
    member this.lexical_form = _lexical_form
    member this.uri = _uri
    member this.vds_node = _vds_node
    member this.iriref = _iriref
    member this.iri = PrefixedName this
    member this.nt = _nt
    member this.curie = _curie



and Skolem_Iri(guid: Guid) =
    let _well_known_base = well_known_base
    let _guid = guid
    let _uuid = guid.ToString("N")
    let _well_known_uri = new Uri(well_known_base)
    let _well_known_vds_node = new UriNode(_well_known_uri)
    let _well_known_iri = Iri_Reference well_known_base
    let _lexical_form = _well_known_base + _uuid
    let _uri = new Uri(_lexical_form)
    let _vds_node = new UriNode(_uri)
    let _iriref = Iri_Reference _uri.OriginalString
    let _nt = NTriples.iriReference _lexical_form

    member this.well_known_base = _well_known_base
    member this.guid = _guid
    member this.uuid = _uuid
    member this.well_known_uri = _well_known_uri
    member this.well_known_vds_node = _well_known_vds_node
    member this.well_known_iri = _well_known_iri
    member this.lexical_form = _lexical_form
    member this.uri = _uri
    member this.vds_node = _vds_node
    member this.iriref = _iriref
    member this.iri = SkolemIRI this
    member this.nt = _nt

and Blank_Node(identifier: string) =

    let _identifier = identifier
    let _nt = sprintf "_:%s" identifier
    let _vds_node = new BlankNode(identifier)
    static member from_vds_node(vds_node: BlankNode) = Blank_Node vds_node.InternalID
    member this.identifier = _identifier
    member this.lexical_form = _identifier
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.as_subject = BlankNodeSubject this
    member this.as_object = BlankNodeObject this

and RDF_Term =
    | IriRDFTerm of Iri
    | BlankRDFTerm of Blank_Node
    | LiteralRDFTerm of RDF_Literal
    | TripleRDFTerm of Triple_Term
    | VariableRDFTerm of RDF_Variable
    | FormulaRDFTerm of Formula

    static member from_vds_node(vds_node: INode) =
        match vds_node.NodeType with
        | NodeType.Uri ->
            vds_node :?> UriNode
            |> Iri.from_vds_node
            |> IriRDFTerm
        | NodeType.Blank ->
            vds_node :?> BlankNode
            |> Blank_Node.from_vds_node
            |> BlankRDFTerm
        | NodeType.Literal ->
            vds_node :?> LiteralNode
            |> RDF_Literal.from_vds_node
            |> LiteralRDFTerm
        | NodeType.GraphLiteral ->
            vds_node :?> GraphLiteralNode
            |> Formula.from_vds_node
            |> FormulaRDFTerm
        | NodeType.Triple ->
            vds_node :?> TripleNode
            |> Triple_Term.from_vds_node
            |> TripleRDFTerm
        | NodeType.Variable ->
            vds_node :?> VariableNode
            |> RDF_Variable.from_vds_node
            |> VariableRDFTerm

and RDF_Variable(identifier: string) =
    let _guid = Guid.NewGuid()
    let _uuid = _guid.ToString("N")
    let _identifier = identifier
    let _binding_cell = Adaptive.cval (None: RDF_Term option)

    let _binding: Adaptive.aval<RDF_Term option> =
        _binding_cell :> Adaptive.aval<RDF_Term option>

    let _dollar_form = sprintf "$%s" identifier
    let _question_form = sprintf "?%s" identifier
    let _vds_node = new VariableNode(identifier)
    let _vds_sparql_variable = new SparqlVariable(identifier)
    let _skolem_iri = Skolem_Iri _guid |> SkolemIRI

    member this.identifier = _identifier
    member this.lexical_form = _identifier
    member this.guid = _guid
    member this.uuid = _uuid

    member this.vds_node = _vds_node
    member this.binding_cell = _binding_cell

    member this.vds_sparql_variable = _vds_sparql_variable
    member this.n3 = _question_form
    member this.dollar_form = _dollar_form
    member this.question_form = _question_form
    member this.skolem_iri = _skolem_iri
    member this.nt = _skolem_iri.nt
    member this.as_subject = VariableSubject this
    member this.as_predicate = VariablePredicate this
    member this.as_object = VariableObject this

    member this.as_pattern_item(pattern_builder: TriplePatternBuilder) =
        pattern_builder.PatternItemFactory.CreateVariablePattern(this.identifier)

    static member from_vds_node(vds_node: VariableNode) = RDF_Variable vds_node.VariableName

    /// Read-only adaptive view of the current binding.
    member this.binding = _binding

    member this.bind(rdf_term: RDF_Term) =
        transact (fun () -> _binding_cell.Value <- Some rdf_term)

    member this.unbind() =
        transact (fun () -> _binding_cell.Value <- None)

    member this.maybe_term = _binding |> Adaptive.AVal.force


    override this.Equals(other: obj) =
        match other with
        | :? RDF_Variable as other_variable -> _guid = other_variable.guid

        | _ -> false

    override this.GetHashCode() = _guid.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? RDF_Variable as other_variable -> compare _guid other_variable.guid

            | _ -> invalidArg (nameof other) "An RDF_Variable can only be compared with another RDF_Variable."


and RDF_Literal =
    | StringLiteral of String_Literal
    | TypedLiteral of Typed_Literal


    static member from_vds_node(vds_node: LiteralNode) =
        match vds_node.Value, vds_node.DataType, vds_node.Language.ToLowerInvariant() with
        | lexical_form, null, "en" -> RDF_Literal.en lexical_form
        | lexical_form, null, "en-us" -> RDF_Literal.US lexical_form
        // TODO find a way to create a Language literal from a string
        // | lexical_form, null, language -> RDF_Literal.language lexical_form
        | lexical_form, datatype_uri, "" ->
            RDF_Literal.datatyped lexical_form (new UriNode(datatype_uri) |> Iri.from_vds_node)
        | lexical_form, _, _ -> RDF_Literal.simple lexical_form

    member this.as_object = LiteralObject this

    member this.lexical_form =
        match this with
        | StringLiteral string_literal -> string_literal.lexical_form
        | TypedLiteral typed_literal -> typed_literal.lexical_form

    member this.curie =
        match this with
        | StringLiteral string_literal -> string_literal.nt
        | TypedLiteral typed_literal -> typed_literal.curie

    member this.vds_node =
        match this with
        | StringLiteral string_literal -> string_literal.vds_node
        | TypedLiteral typed_literal -> typed_literal.vds_node

    member this.nt =
        match this with
        | StringLiteral string_literal -> string_literal.nt
        | TypedLiteral typed_literal -> typed_literal.nt

    member this.datatype_iri =
        match this with
        | StringLiteral string_literal -> string_literal.datatype_iri
        | TypedLiteral typed_literal -> typed_literal.datatype_iri

    member this.maybe_language_tag =
        match this with
        | StringLiteral string_literal -> string_literal.maybe_language_tag
        | TypedLiteral typed_literal -> None

    member this.maybe_base_direction =
        match this with
        | StringLiteral string_literal -> string_literal.maybe_base_direction
        | TypedLiteral typed_literal -> None

    static member simple(lexical_form: string) : RDF_Literal =
        Simple_String(lexical_form)
        |> SimpleString
        |> StringLiteral

    static member language (lexical_form: string) (language_subtag: Language_Subtag) =
        Language_String(lexical_form, Language_Tag language_subtag)
        |> LanguageString
        |> StringLiteral

    static member region (lexical_form: string) (language_subtag: Language_Subtag) (region_subtag: Region_Subtag) =
        Language_String(lexical_form, Language_Tag(language_subtag, region_subtag))
        |> LanguageString
        |> StringLiteral

    static member en(lexical_form: string) =
        RDF_Literal.language lexical_form Language_Subtag.en

    static member US(lexical_form: string) =
        RDF_Literal.region lexical_form Language_Subtag.en Region_Subtag.US


    static member datatyped (lexical_form: string) (datatype_iri: Iri) =
        Datatyped_Literal(lexical_form, datatype_iri)
        |> DatatypedLiteral
        |> TypedLiteral

    static member inline autotyped<'ValueType>(value: 'ValueType) =

        let datatyped_literal =
            let invariant_string =
                if box value = null then
                    String.Empty
                else
                    Convert.ToString(value, CultureInfo.InvariantCulture)

            match box value with
            | :? Boolean as value ->
                Datatyped_Literal((if value then "true" else "false"), Prefixed_Name(xsd, "boolean").iri)
            | :? (Byte array) as value ->
                Datatyped_Literal(Convert.ToBase64String(value), Prefixed_Name(xsd, "base64Binary").iri)
            | :? Byte as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "unsignedByte").iri)
            | :? DateOnly as value ->
                Datatyped_Literal(
                    value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Prefixed_Name(xsd, "date").iri
                )
            | :? DateTime as value ->
                Datatyped_Literal(value.ToString("o", CultureInfo.InvariantCulture), Prefixed_Name(xsd, "dateTime").iri)
            | :? DateTimeOffset as value ->
                Datatyped_Literal(
                    value.ToString("o", CultureInfo.InvariantCulture),
                    Prefixed_Name(xsd, "dateTimeStamp").iri
                )
            | :? Decimal as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "decimal").iri)
            | :? Double as value ->
                Datatyped_Literal(value.ToString("R", CultureInfo.InvariantCulture), Prefixed_Name(xsd, "double").iri)
            | :? Int16 as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "short").iri)
            | :? Int32 as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "int").iri)
            | :? Int64 as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "long").iri)
            | :? SByte as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "byte").iri)
            | :? Single as value ->
                Datatyped_Literal(value.ToString("R", CultureInfo.InvariantCulture), Prefixed_Name(xsd, "float").iri)
            | :? TimeOnly as value ->
                Datatyped_Literal(
                    value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture),
                    Prefixed_Name(xsd, "time").iri
                )
            | :? TimeSpan as value ->
                Datatyped_Literal(Xml.XmlConvert.ToString(value), Prefixed_Name(xsd, "duration").iri)
            | :? UInt16 as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "unsignedShort").iri)
            | :? UInt32 as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "unsignedInt").iri)
            | :? UInt64 as value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "unsignedLong").iri)
            | :? Uri as value -> Datatyped_Literal(value.AbsoluteUri, Prefixed_Name(xsd, "anyURI").iri)
            | :? XmlQualifiedName as value -> Datatyped_Literal(value.ToString(), Prefixed_Name(xsd, "QName").iri)
            | :? Guid as value -> Datatyped_Literal(value.ToString(), Prefixed_Name(xsd, "ID").iri)
            | null -> Datatyped_Literal("true", Prefixed_Name(xsi, "nil").iri)
            | value when value.GetType() = typeof<Object> ->
                Datatyped_Literal(invariant_string, Prefixed_Name(xdt, "anyAtomicType").iri)
            | value -> Datatyped_Literal(invariant_string, Prefixed_Name(xsd, "string").iri)

        datatyped_literal
        |> DatatypedLiteral
        |> TypedLiteral

and String_Literal =
    | SimpleString of Simple_String
    | LanguageString of Language_String
    | DirectedLanguageString of Directed_Language_String
    member this.lexical_form =
        match this with
        | SimpleString simple_string -> simple_string.lexical_form
        | LanguageString language_string -> language_string.lexical_form
        | DirectedLanguageString directed_language_string -> directed_language_string.lexical_form

    member this.vds_node =
        match this with
        | SimpleString simple_string -> simple_string.vds_node
        | LanguageString language_string -> language_string.vds_node
        | DirectedLanguageString directed_language_string -> directed_language_string.vds_node

    member this.nt =
        match this with
        | SimpleString simple_string -> simple_string.nt
        | LanguageString language_string -> language_string.nt
        | DirectedLanguageString directed_language_string -> directed_language_string.nt

    member this.datatype_iri =
        match this with
        | SimpleString simple_string -> Prefixed_Name(xsd, "string").iri
        | LanguageString language_string -> Prefixed_Name(rdf, "langString").iri
        | DirectedLanguageString directed_language_string -> Prefixed_Name(rdf, "dirLangString").iri

    member this.maybe_language_tag =
        match this with
        | SimpleString simple_string -> None
        | LanguageString language_string -> Some language_string.language_tag
        | DirectedLanguageString directed_language_string -> Some directed_language_string.language_tag

    member this.maybe_base_direction =
        match this with
        | SimpleString simple_string -> None
        | LanguageString language_string -> None
        | DirectedLanguageString directed_language_string -> Some directed_language_string.base_direction

and Simple_String(lexical_form: string) =
    let _lexical_form = lexical_form
    let _vds_node = new LiteralNode(lexical_form)
    let _nt = NTriples.quotedLiteral _lexical_form
    member this.lexical_form = _lexical_form
    member this.vds_node = _vds_node
    member this.string_literal = SimpleString this
    member this.literal = StringLiteral this.string_literal
    member this.nt = _nt

and Language_String(lexical_form: string, language_tag: Language_Tag) =
    let _lexical_form = lexical_form
    let _language_tag = language_tag
    let _vds_node = new LiteralNode(lexical_form, language_tag.as_string)

    let _nt =
        sprintf "%s@%s" (NTriples.quotedLiteral lexical_form) language_tag.as_string

    member this.lexical_form = _lexical_form
    member this.language_tag = _language_tag
    member this.vds_node = _vds_node
    member this.nt = _nt

and Directed_Language_String(lexical_form: string, language_tag: Language_Tag, base_direction: Initial_Text_Direction) =
    let _lexical_form = lexical_form
    let _language_tag = language_tag
    let _base_direction = base_direction

    let _directed_language_datatype_iri =
        Iri_Reference(
            $"https://www.w3.org/ns/i18n#{language_tag.as_string}_{base_direction.as_string}"
        )
            .iri

    let _vds_node = new LiteralNode(lexical_form, _directed_language_datatype_iri.uri)

    let _nt =
        sprintf "%s@%s--%s" (NTriples.quotedLiteral lexical_form) language_tag.as_string base_direction.as_string

    member this.lexical_form = _lexical_form
    member this.language_tag = _language_tag
    member this.base_direction = _base_direction
    member this.directed_language_datatype_iri = _directed_language_datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt

and Typed_Literal =
    | DatatypedLiteral of Datatyped_Literal
    | BooleanLiteral of Boolean_Literal
    | DateLiteral of Date_Literal
    | DateTimeLiteral of DateTime_Literal
    | TimeSpanLiteral of TimeSpan_Literal
    | ByteLteral of Byte_Literal
    | SignedByteLteral of SignedByte_Literal
    | DecimalLteral of Decimal_Literal
    | DoubleLteral of Double_Literal
    | Float32Lteral of Float32_Literal
    | LongLteral of Long_Literal
    | UnsignedLongLteral of UnsignedLong_Literal
    member this.lexical_form =
        match this with
        | DatatypedLiteral datatyped_literal -> datatyped_literal.lexical_form
        | BooleanLiteral boolean_literal -> boolean_literal.lexical_form
        | DateLiteral date_literal -> date_literal.lexical_form
        | DateTimeLiteral datetime_literal -> datetime_literal.lexical_form
        | TimeSpanLiteral timespan_literal -> timespan_literal.lexical_form
        | ByteLteral byte_literal -> byte_literal.lexical_form
        | SignedByteLteral signedbyte_literal -> signedbyte_literal.lexical_form
        | DecimalLteral decimal_literal -> decimal_literal.lexical_form
        | DoubleLteral double_literal -> double_literal.lexical_form
        | Float32Lteral float32_literal -> float32_literal.lexical_form
        | LongLteral long_literal -> long_literal.lexical_form
        | UnsignedLongLteral unsignedlong_literal -> unsignedlong_literal.lexical_form

    member this.vds_node =
        match this with
        | DatatypedLiteral datatyped_literal -> datatyped_literal.vds_node
        | BooleanLiteral boolean_literal -> boolean_literal.vds_node
        | DateLiteral date_literal -> date_literal.vds_node
        | DateTimeLiteral datetime_literal -> datetime_literal.vds_node
        | TimeSpanLiteral timespan_literal -> timespan_literal.vds_node
        | ByteLteral byte_literal -> byte_literal.vds_node
        | SignedByteLteral signedbyte_literal -> signedbyte_literal.vds_node
        | DecimalLteral decimal_literal -> decimal_literal.vds_node
        | DoubleLteral double_literal -> double_literal.vds_node
        | Float32Lteral float32_literal -> float32_literal.vds_node
        | LongLteral long_literal -> long_literal.vds_node
        | UnsignedLongLteral unsignedlong_literal -> unsignedlong_literal.vds_node

    member this.nt =
        match this with
        | DatatypedLiteral datatyped_literal -> datatyped_literal.nt
        | BooleanLiteral boolean_literal -> boolean_literal.nt
        | DateLiteral date_literal -> date_literal.nt
        | DateTimeLiteral datetime_literal -> datetime_literal.nt
        | TimeSpanLiteral timespan_literal -> timespan_literal.nt
        | ByteLteral byte_literal -> byte_literal.nt
        | SignedByteLteral signedbyte_literal -> signedbyte_literal.nt
        | DecimalLteral decimal_literal -> decimal_literal.nt
        | DoubleLteral double_literal -> double_literal.nt
        | Float32Lteral float32_literal -> float32_literal.nt
        | LongLteral long_literal -> long_literal.nt
        | UnsignedLongLteral unsignedlong_literal -> unsignedlong_literal.nt

    member this.curie =
        match this with
        | DatatypedLiteral datatyped_literal -> datatyped_literal.curie
        | BooleanLiteral boolean_literal -> boolean_literal.curie
        | DateLiteral date_literal -> date_literal.curie
        | DateTimeLiteral datetime_literal -> datetime_literal.curie
        | TimeSpanLiteral timespan_literal -> timespan_literal.curie
        | ByteLteral byte_literal -> byte_literal.curie
        | SignedByteLteral signedbyte_literal -> signedbyte_literal.curie
        | DecimalLteral decimal_literal -> decimal_literal.curie
        | DoubleLteral double_literal -> double_literal.curie
        | Float32Lteral float32_literal -> float32_literal.curie
        | LongLteral long_literal -> long_literal.curie
        | UnsignedLongLteral unsignedlong_literal -> unsignedlong_literal.curie

    member this.datatype_iri =
        match this with
        | DatatypedLiteral datatyped_literal -> datatyped_literal.datatype_iri
        | BooleanLiteral boolean_literal -> boolean_literal.datatype_iri
        | DateLiteral date_literal -> date_literal.datatype_iri
        | DateTimeLiteral datetime_literal -> datetime_literal.datatype_iri
        | TimeSpanLiteral timespan_literal -> timespan_literal.datatype_iri
        | ByteLteral byte_literal -> byte_literal.datatype_iri
        | SignedByteLteral signedbyte_literal -> signedbyte_literal.datatype_iri
        | DecimalLteral decimal_literal -> decimal_literal.datatype_iri
        | DoubleLteral double_literal -> double_literal.datatype_iri
        | Float32Lteral float32_literal -> float32_literal.datatype_iri
        | LongLteral long_literal -> long_literal.datatype_iri
        | UnsignedLongLteral unsignedlong_literal -> unsignedlong_literal.datatype_iri

and Datatyped_Literal(lexical_form: string, datatype_iri: Iri) =

    let _lexical_form = lexical_form
    let _datatype_iri = datatype_iri
    let _vds_node = new LiteralNode(lexical_form, datatype_iri.uri)
    let _nt = NTriples.typedLiteral lexical_form datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" lexical_form datatype_iri.curie
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and Boolean_Literal(boolean_value: bool) =
    let _boolean_value = boolean_value
    let _lexical_form = string boolean_value
    let _datatype_iri = Prefixed_Name(xsd, "boolean").iri
    let _vds_node = new BooleanNode(boolean_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.boolean_value = _boolean_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and Date_Literal(date_value: DateOnly) =
    let _date_value = date_value
    let _date_time = date_value.ToDateTime(TimeOnly.MinValue)
    let _lexical_form = date_value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
    let _datatype_iri = Prefixed_Name(xsd, "dateTime").iri
    let _vds_node = new DateNode(_date_time, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.date_value = _date_value
    member this.date_time = _date_time
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and DateTime_Literal(date_time_value: DateTime) =
    let _date_time_value = date_time_value
    let _lexical_form = date_time_value.ToString("o", CultureInfo.InvariantCulture)
    let _datatype_iri = Prefixed_Name(xsd, "date").iri
    let _vds_node = new DateTimeNode(date_time_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.date_time_value = _date_time_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and TimeSpan_Literal(time_span_value: TimeSpan) =
    let _time_span_value = time_span_value
    let _lexical_form = Xml.XmlConvert.ToString(time_span_value)
    let _datatype_iri = Prefixed_Name(xsd, "duration").iri
    let _vds_node = new TimeSpanNode(time_span_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.time_span_value = _time_span_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and Byte_Literal(byte_value: Byte) =
    let _byte_value = byte_value
    let _lexical_form = Convert.ToBase64String([| byte_value |])
    let _datatype_iri = Prefixed_Name(xsd, "base64Binary").iri
    let _vds_node = new ByteNode(byte_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.byte_value = _byte_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and SignedByte_Literal(signed_byte_value: sbyte) =
    let _signed_byte_value = signed_byte_value

    let _lexical_form =
        Convert.ToString(signed_byte_value, CultureInfo.InvariantCulture)

    let _datatype_iri = Prefixed_Name(xsd, "byte").iri
    let _vds_node = new SignedByteNode(signed_byte_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.signed_byte_value = _signed_byte_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and Decimal_Literal(decimal: Decimal) =
    let _decimal = decimal
    let _lexical_form = Convert.ToString(decimal, CultureInfo.InvariantCulture)
    let _datatype_iri = Prefixed_Name(xsd, "decimal").iri
    let _vds_node = new DecimalNode(decimal, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.decimal = _decimal
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and Double_Literal(double_value: Double) =
    let _double_value = double_value
    let _lexical_form = double_value.ToString("R", CultureInfo.InvariantCulture)
    let _datatype_iri = Prefixed_Name(xsd, "double").iri
    let _vds_node = new DoubleNode(double_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.double_value = _double_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and Float32_Literal(float_value: float32) =
    let _float_value = float_value
    let _lexical_form = float_value.ToString("R", CultureInfo.InvariantCulture)
    let _datatype_iri = Prefixed_Name(xsd, "float").iri
    let _vds_node = new FloatNode(float_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.float_value = _float_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and Long_Literal(long_value: Int64) =
    let _long_value = long_value
    let _lexical_form = Convert.ToString(long_value, CultureInfo.InvariantCulture)
    let _datatype_iri = Prefixed_Name(xsd, "long").iri
    let _vds_node = new LongNode(long_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.long_value = _long_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and UnsignedLong_Literal(unsigned_long_value: UInt64) =
    let _unsigned_long_value = unsigned_long_value

    let _lexical_form =
        Convert.ToString(unsigned_long_value, CultureInfo.InvariantCulture)

    let _datatype_iri = Prefixed_Name(xsd, "unsignedLong").iri
    let _vds_node = new UnsignedLongNode(unsigned_long_value, _lexical_form)
    let _nt = NTriples.typedLiteral _lexical_form _datatype_iri.lexical_form
    let _curie = sprintf "\"%s\"^^%s" _lexical_form _datatype_iri.curie
    member this.unsigned_long_value = _unsigned_long_value
    member this.lexical_form = _lexical_form
    member this.datatype_iri = _datatype_iri
    member this.vds_node = _vds_node
    member this.nt = _nt
    member this.curie = _curie

and RDF_Subject =
    | IriSubject of Iri
    | BlankNodeSubject of Blank_Node
    | VariableSubject of RDF_Variable
    static member from_vds_node(vds_node: INode) =
        match vds_node.NodeType with
        | NodeType.Uri ->
            vds_node :?> UriNode
            |> Iri.from_vds_node
            |> IriSubject
        | NodeType.Blank ->
            vds_node :?> BlankNode
            |> Blank_Node.from_vds_node
            |> BlankNodeSubject
        | NodeType.Variable ->
            vds_node :?> VariableNode
            |> RDF_Variable.from_vds_node
            |> VariableSubject

    member this.nt =
        match this with
        | IriSubject iri -> iri.nt
        | BlankNodeSubject blank_node -> blank_node.nt
        | VariableSubject rdf_variable -> rdf_variable.nt

    member this.rdf_term =
        match this with
        | IriSubject iri -> IriRDFTerm iri
        | BlankNodeSubject blank_node -> BlankRDFTerm blank_node
        | VariableSubject rdf_variable -> VariableRDFTerm rdf_variable

    member this.lexical_form =
        match this with
        | IriSubject iri -> iri.lexical_form
        | BlankNodeSubject blank_node -> blank_node.lexical_form
        | VariableSubject rdf_variable -> rdf_variable.lexical_form

    member this.curie =
        match this with
        | IriSubject iri -> iri.curie
        | BlankNodeSubject blank_node -> blank_node.nt
        | VariableSubject rdf_variable -> rdf_variable.question_form

    member this.maybe_predicate =
        match this with
        | IriSubject iri -> Some iri.as_predicate
        | BlankNodeSubject blank_node -> None
        | VariableSubject rdf_variable -> Some rdf_variable.as_predicate

    member this.as_object =
        match this with
        | IriSubject iri -> iri.as_object
        | BlankNodeSubject blank_node -> blank_node.as_object
        | VariableSubject rdf_variable -> rdf_variable.as_object

    member this.vds_node =
        match this with
        | IriSubject iri -> iri.vds_node :> INode
        | BlankNodeSubject blank_node -> blank_node.vds_node :> INode
        | VariableSubject rdf_variable -> rdf_variable.vds_node :> INode


    member this.as_pattern_item(pattern_builder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariableSubject rdf_variable -> pattern_builder |> rdf_variable.as_pattern_item
        | _ -> pattern_builder.PatternItemFactory.CreateNodeMatchPattern(this.vds_node)


and RDF_Predicate =
    | IriPredicate of Iri
    | VariablePredicate of RDF_Variable

    static member from_vds_node(vds_node: INode) =
        match vds_node.NodeType with
        | NodeType.Uri ->
            vds_node :?> UriNode
            |> Iri.from_vds_node
            |> IriPredicate
        | NodeType.Variable ->
            vds_node :?> VariableNode
            |> RDF_Variable.from_vds_node
            |> VariablePredicate

    member this.rdf_term =
        match this with
        | IriPredicate iri -> IriRDFTerm iri
        | VariablePredicate rdf_variable -> VariableRDFTerm rdf_variable

    member this.nt =
        match this with
        | IriPredicate iri -> iri.nt
        | VariablePredicate rdf_variable -> rdf_variable.nt

    member this.lexical_form =
        match this with
        | IriPredicate iri -> iri.lexical_form
        | VariablePredicate rdf_variable -> rdf_variable.lexical_form

    member this.curie =
        match this with
        | IriPredicate iri -> iri.curie
        | VariablePredicate rdf_variable -> rdf_variable.question_form

    member this.as_subject =
        match this with
        | IriPredicate iri -> iri.as_subject
        | VariablePredicate rdf_variable -> rdf_variable.as_subject

    member this.as_object =
        match this with
        | IriPredicate iri -> iri.as_object
        | VariablePredicate rdf_variable -> rdf_variable.as_object

    member this.vds_node =
        match this with
        | IriPredicate iri -> iri.vds_node :> INode
        | VariablePredicate rdf_variable -> rdf_variable.vds_node :> INode


    member this.as_pattern_item(pattern_builder: TriplePatternBuilder) : PatternItem =
        match this with
        | VariablePredicate rdf_variable -> pattern_builder |> rdf_variable.as_pattern_item
        | _ -> pattern_builder.PatternItemFactory.CreateNodeMatchPattern(this.vds_node)


and RDF_Object =
    | IriObject of Iri
    | BlankNodeObject of Blank_Node
    | LiteralObject of RDF_Literal
    | TripleTermObject of Triple_Term
    | VariableObject of RDF_Variable
    static member from_vds_node(vds_node: INode) =
        match vds_node.NodeType with
        | NodeType.Uri ->
            vds_node :?> UriNode
            |> Iri.from_vds_node
            |> IriObject
        | NodeType.Blank ->
            vds_node :?> BlankNode
            |> Blank_Node.from_vds_node
            |> BlankNodeObject
        | NodeType.Literal ->
            vds_node :?> LiteralNode
            |> RDF_Literal.from_vds_node
            |> LiteralObject
        | NodeType.Triple ->
            vds_node :?> TripleNode
            |> Triple_Term.from_vds_node
            |> TripleTermObject
        | NodeType.Variable ->
            vds_node :?> VariableNode
            |> RDF_Variable.from_vds_node
            |> VariableObject

    member this.rdf_term =
        match this with
        | IriObject iri -> IriRDFTerm iri
        | BlankNodeObject blank_node -> BlankRDFTerm blank_node
        | LiteralObject literal -> LiteralRDFTerm literal
        | TripleTermObject triple_term -> TripleRDFTerm triple_term
        | VariableObject rdf_variable -> VariableRDFTerm rdf_variable

    member this.nt =
        match this with
        | IriObject iri -> iri.nt
        | BlankNodeObject blank_node -> blank_node.nt
        | LiteralObject rdf_literal -> rdf_literal.nt
        | TripleTermObject triple_term -> triple_term.nt
        | VariableObject rdf_variable -> rdf_variable.nt

    member this.lexical_form =
        match this with
        | IriObject iri -> iri.lexical_form
        | BlankNodeObject blank_node -> blank_node.lexical_form
        | LiteralObject rdf_literal -> rdf_literal.lexical_form
        | TripleTermObject triple_term -> triple_term.lexical_form
        | VariableObject rdf_variable -> rdf_variable.lexical_form

    member this.curie =
        match this with
        | IriObject iri -> iri.curie
        | BlankNodeObject blank_node -> blank_node.nt
        | LiteralObject rdf_literal -> rdf_literal.curie
        | TripleTermObject triple_term -> triple_term.curie
        | VariableObject rdf_variable -> rdf_variable.question_form

    member this.maybe_subject =
        match this with
        | IriObject iri -> Some iri.as_subject
        | BlankNodeObject blank_node -> Some blank_node.as_subject
        | LiteralObject rdf_literal -> None
        // TODO consider automatic reified triple subject
        | TripleTermObject triple_term -> None
        | VariableObject rdf_variable -> Some rdf_variable.as_subject

    member this.maybe_predicate =
        match this with
        | IriObject iri -> Some iri.as_predicate
        | BlankNodeObject blank_node -> None
        | LiteralObject rdf_literal -> None
        | TripleTermObject triple_term -> None
        | VariableObject rdf_variable -> Some rdf_variable.as_predicate

    member this.vds_node =
        match this with
        | IriObject iri -> iri.vds_node :> INode
        | BlankNodeObject blank_node -> blank_node.vds_node :> INode
        | LiteralObject rdf_literal -> rdf_literal.vds_node :> INode
        | TripleTermObject triple_term -> triple_term.vds_node :> INode
        | VariableObject rdf_variable -> rdf_variable.vds_node :> INode


    member this.as_pattern_item(pattern_builder: TriplePatternBuilder) =
        match this with
        | VariableObject rdf_variable -> pattern_builder |> rdf_variable.as_pattern_item
        | _ -> pattern_builder.PatternItemFactory.CreateNodeMatchPattern(this.vds_node)


and PredicateObjectList =
    {

      verb: RDF_Predicate
      objectLists: ObjectList array

     }

    static member inline from_terms (predicate: RDF_Predicate) (objects: RDF_Object array) =
        {

          verb = predicate
          objectLists =
            objects
            |> Array.map (fun rdf_object ->
                { rdf_object = rdf_object
                  annotations = [||]

                })

        }

and ObjectList =
    { rdf_object: RDF_Object
      annotations: Annotation array }

and Annotation =
    | AnnotationReifier of RDF_Subject
    | AnnotationBlock of PredicateObjectList

and Triple_Term(triple: RDF_Triple) =
    let _triple = triple
    let _ttSubject = _triple.curSubject
    let _ttPredicate = _triple.curPredicate
    let _ttObject = _triple.curObject
    let _vds_node = new TripleNode(triple.vds)

    let _lexical_form =
        sprintf "%s %s %s" _ttSubject.lexical_form _ttPredicate.lexical_form _ttObject.lexical_form

    let _nt = sprintf "<<( %s %s %s )>>" _ttSubject.nt _ttPredicate.nt _ttObject.nt

    let _curie =
        sprintf "<<( %s %s %s )>>" _ttSubject.curie _ttPredicate.curie _ttObject.curie

    static member from_vds_node(vds_node: TripleNode) =
        vds_node.Triple
        |> RDF_Triple.from_vds_triple
        |> Triple_Term

    member this.as_object = TripleTermObject this
    member this.triple = _triple

    member this.ttSubject: RDF_Subject = _ttSubject

    member this.ttPredicate: RDF_Predicate = _ttPredicate

    member this.ttObject: RDF_Object = _ttObject

    member this.vds_node = new TripleNode(_triple.vds)
    member this.lexical_form = _lexical_form
    member this.nt = _nt
    member this.curie = _curie

and RDF_Triple =
    { curSubject: RDF_Subject
      curPredicate: RDF_Predicate
      curObject: RDF_Object }
    member this.lexical_forms =
        this.curSubject.lexical_form, this.curPredicate.lexical_form, this.curObject.lexical_form

    member this.rdf_terms =
        [| this.curSubject.rdf_term
           this.curPredicate.rdf_term
           this.curObject.rdf_term |]

    member this.nt =
        sprintf "%s %s %s ." this.curSubject.nt this.curPredicate.nt this.curObject.nt

    member this.nq = this.nt

    member this.verticies =
        [| SubjectVertex this.curSubject
           ObjectVertex this.curObject |]


    static member from_vds_triple(vds_triple: Triple) =
        { curSubject = RDF_Subject.from_vds_node vds_triple.Subject
          curPredicate = RDF_Predicate.from_vds_node vds_triple.Predicate
          curObject = RDF_Object.from_vds_node vds_triple.Object }

    static member inline from_terms
        (rdf_subject: ^SubjectType when ^SubjectType: (member as_subject: RDF_Subject))
        (rdf_predicate: ^PredicateType when ^PredicateType: (member as_predicate: RDF_Predicate))
        (rdf_object: ^ObjectType when ^ObjectType: (member as_object: RDF_Object))
        =
        { curSubject = rdf_subject.as_subject
          curPredicate = rdf_predicate.as_predicate
          curObject = rdf_object.as_object }

    static member set_from_terms
        (rdf_subjects: RDF_Subject array)
        (rdf_predicates: RDF_Predicate array)
        (rdf_objects: RDF_Object array)
        =
        rdf_objects
        |> Array.Parallel.collect (fun rdf_object ->

            rdf_predicates
            |> Array.Parallel.collect (fun rdf_predicate ->

                rdf_subjects
                |> Array.Parallel.map (fun rdf_subject ->

                    {

                      curSubject = rdf_subject
                      curPredicate = rdf_predicate
                      curObject = rdf_object

                    }

                )))
        |> FSharp.HashCollections.HashSet.ofSeq

    member this.vds =
        new Triple(this.curSubject.vds_node, this.curPredicate.vds_node, this.curObject.vds_node)

    member this.as_object = Triple_Term(this).as_object

    member this.as_ITriplePattern(pattern_builder: TriplePatternBuilder) =
        TriplePattern(
            this.curSubject.as_pattern_item pattern_builder,
            this.curPredicate.as_pattern_item pattern_builder,
            this.curObject.as_pattern_item pattern_builder
        )
        :> ITriplePattern

    static member set_from_subjects_predicateObjectLists
        (rdf_subjects: RDF_Subject array)
        (predicateObjectLists: PredicateObjectList array)
        =
        rdf_subjects
        |> Array.Parallel.collect (fun rdf_subject ->
            predicateObjectLists
            |> Array.Parallel.collect (fun predicateObjectList ->
                predicateObjectList.objectLists
                |> Array.Parallel.map (fun objectList ->
                    // TODO deal with annotations


                    { curSubject = rdf_subject
                      curPredicate = predicateObjectList.verb
                      curObject = objectList.rdf_object }

                )

            )

        )
        |> FSharp.HashCollections.HashSet.ofSeq

and Formula =
    {

      subjects: RDF_Subject array
      predicates: RDF_Predicate array
      objects: RDF_Object array
      predicateObjectLists: PredicateObjectList array
      triples: HashSet<RDF_Triple>

     }
    static member Empty =

        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_vds_graph(vds_graph: IGraph) =
        { Formula.Empty with
            triples =
                vds_graph.Triples
                |> PSeq.map (fun vds_triple ->

                    RDF_Triple.from_vds_triple vds_triple

                )
                |> HashSet.ofSeq

         }

    static member from_vds_node(vds_node: GraphLiteralNode) =
        Formula.from_vds_graph vds_node.SubGraph


    member this.as_graph_pattern(pattern_builder: TriplePatternBuilder) : ITriplePattern array =
        this.triples
        |> Seq.toArray
        |> Array.map (fun rdf_triple -> pattern_builder |> rdf_triple.as_ITriplePattern)

    member this.as_rdf_graph: RDF_Graph = { triples = this.triples }


    static member from_subject subject_term =

        { subjects = [| subject_term |]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_subjects subjects =

        { subjects = subjects |> List.toArray
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_predicate predicate_term =

        { subjects = [||]
          predicates = [| predicate_term |]
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_predicates predicates =

        { subjects = [||]
          predicates = predicates
          objects = [||]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_object object_term =

        { subjects = [||]
          predicates = [||]
          objects = [| object_term |]
          predicateObjectLists = [||]
          triples = HashSet.empty

        }

    static member from_objects objects =

        { subjects = [||]
          predicates = [||]
          objects = objects
          predicateObjectLists = [||]
          triples = HashSet.empty

        }


    member this.materialize_triples =
        let triples_from_terms =
            RDF_Triple.set_from_terms this.subjects this.predicates this.objects

        let triples_from_subjects_predicateObjectLists =
            RDF_Triple.set_from_subjects_predicateObjectLists this.subjects this.predicateObjectLists

        { subjects = [||]
          predicates = [||]
          objects = [||]
          predicateObjectLists = [||]
          triples =
            Seq.concat [ this.triples
                         triples_from_terms
                         triples_from_subjects_predicateObjectLists ]
            |> HashSet.ofSeq


        }

    static member materialize_formula(formula: Formula) = formula.materialize_triples

    member this.add_formulas(formulas: Formula list) =
        let triples_from_formulas =
            formulas
            |> Seq.collect (fun formula -> formula.triples)
            |> HashSet.ofSeq


        { this with
            triples =
                Seq.concat [ this.triples
                             triples_from_formulas ]
                |> HashSet.ofSeq }



    member this.add_subjects subject_terms =
        { this with subjects = this.subjects |> Array.append subject_terms }

    member this.add_subject subject_term = this.add_subjects [| subject_term |]


    member this.add_predicates predicate_terms =

        { this with predicates = this.predicates |> Array.append predicate_terms }

    member this.add_predicateObjectLists predicateObjectLists =

        { this with
            predicateObjectLists =
                this.predicateObjectLists
                |> Array.append predicateObjectLists }

    member this.add_predicate predicate_term =
        this.add_predicates [| predicate_term |]

    member this.add_objects object_terms =
        { this with objects = this.objects |> Array.append object_terms }

    member this.add_object object_term = this.add_objects [| object_term |]

    member this.add_literal literal =
        RDF_Literal.autotyped literal
        |> RDF_Object.LiteralObject
        |> this.add_object

    member this.add_literals literals =
        literals
        |> List.toArray
        |> Array.Parallel.map (fun literal ->
            literal
            |> RDF_Literal.autotyped
            |> RDF_Object.LiteralObject)
        |> this.add_objects


and RDF_Graph =
    { triples: HashSet<RDF_Triple> }

    member this.verticies =
        this.triples
        |> Array.ofSeq
        |> Array.Parallel.collect (fun triple -> triple.verticies)
        |> Array.distinct

    member this.rdf_terms =
        this.triples
        |> PSeq.collect (fun triple -> triple.rdf_terms)
        |> PSeq.distinct
        |> Array.ofSeq
        |> Array.distinct

    member this.iris =
        this.rdf_terms
        |> Array.Parallel.choose (fun rdf_term ->
            match rdf_term with
            | IriRDFTerm iri -> Some iri
            | _ -> None)
        |> Array.distinct

    member this.prefixed_names =
        this.iris
        |> Array.Parallel.choose (fun iri ->
            match iri with
            | PrefixedName prefixed_name -> Some prefixed_name
            | _ -> None)
        |> Array.distinct

    member this.prefix_ids =
        this.prefixed_names
        |> Array.Parallel.map (fun prefixed_name -> prefixed_name.prefix_id)
        |> Array.distinct

    member this.nt =
        this.triples
        |> PSeq.map (fun triple -> triple.nt)
        |> String.concat "\n"

    static member from_vds_graph(vds_graph: IGraph) =
        { triples =
            vds_graph.Triples
            |> PSeq.map (fun vds_triple -> RDF_Triple.from_vds_triple vds_triple)
            |> HashSet.ofSeq }


and Vertex =
    | SubjectVertex of RDF_Subject
    | ObjectVertex of RDF_Object


    member this.as_rendered_string (prefix_delimiter: string) (prefix_map: Map<string, string>) =
        match this with
        | SubjectVertex rdf_subject -> rdf_subject.curie
        | ObjectVertex rdf_object -> rdf_object.curie

and Edge =
    | PredicateEdge of RDF_Predicate
    | TripleEdge of RDF_Triple

    member this.as_rendered_string (prefix_delimiter: string) (prefix_map: Map<string, string>) =
        match this with
        | PredicateEdge rdf_predicate -> rdf_predicate.curie
        | TripleEdge rdf_triple -> rdf_triple.curPredicate.curie








module RDF_Literal =



    let true_ = RDF_Literal.autotyped true
    let false_ = RDF_Literal.autotyped false

    module Binary =

        let base64 (bytes: Byte array) =
            let value_string = Convert.ToBase64String(bytes)

            Prefixed_Name(xsd, "base64Binary").iri
            |> RDF_Literal.datatyped value_string

        let hex (bytes: Byte array) =
            let value_string = Convert.ToHexString(bytes)

            Prefixed_Name(xsd, "hexBinary").iri
            |> RDF_Literal.datatyped value_string


    module Temporal =
        module duration =
            let timeDuration (timespan: TimeSpan) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                Prefixed_Name(xsd, "duration").iri
                |> RDF_Literal.datatyped value_string

            let dayTimeDuration (timespan: TimeSpan) =
                let value_string = Xml.XmlConvert.ToString(timespan)

                Prefixed_Name(xdt, "dayTimeDuration").iri
                |> RDF_Literal.datatyped value_string


            let yearMonthDuration (years: int) (months: int) =
                let total_months = years * 12 + months

                let value_string =
                    if total_months = 0 then
                        "P0M"
                    else
                        let absolute_months = abs total_months
                        let years_part = absolute_months / 12
                        let months_part = absolute_months % 12
                        let sign = if total_months < 0 then "-" else ""

                        let year_text =
                            if years_part = 0 then
                                ""
                            else
                                $"{years_part}Y"

                        let month_text =
                            if months_part = 0 then
                                ""
                            else
                                $"{months_part}M"

                        $"{sign}P{year_text}{month_text}"

                Prefixed_Name(xdt, "yearMonthDuration").iri
                |> RDF_Literal.datatyped value_string


        module date =

            let only (date: DateOnly) =
                let value_string = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                Prefixed_Name(xsd, "date").iri
                |> RDF_Literal.datatyped value_string

            let from_datetime (datetime: DateTime) =
                let value_string = datetime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

                Prefixed_Name(xsd, "date").iri
                |> RDF_Literal.datatyped value_string

            let time (datetime: DateTime) =
                let value_string = datetime.ToString("o", CultureInfo.InvariantCulture)

                Prefixed_Name(xsd, "dateTime").iri
                |> RDF_Literal.datatyped value_string

            let timeStamp (datetime_offset: DateTimeOffset) =
                let value_string = datetime_offset.ToString("o", CultureInfo.InvariantCulture)

                Prefixed_Name(xsd, "dateTimeStamp").iri
                |> RDF_Literal.datatyped value_string



        module time =

            let only (time: TimeOnly) =
                let value_string = time.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                Prefixed_Name(xsd, "time").iri
                |> RDF_Literal.datatyped value_string

            let from_datetime (datetime: DateTime) =
                let value_string =
                    datetime.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

                Prefixed_Name(xsd, "time").iri
                |> RDF_Literal.datatyped value_string

        module period =

            let day (datetime: DateTime) =
                let value_string =
                    $"""---{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                Prefixed_Name(xsd, "gDay").iri
                |> RDF_Literal.datatyped value_string


            let month (datetime: DateTime) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                Prefixed_Name(xsd, "gMonth").iri
                |> RDF_Literal.datatyped value_string


            let monthDay (datetime: DateTime) =
                let value_string =
                    $"""--{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}-{datetime.Day.ToString("00", CultureInfo.InvariantCulture)}"""

                Prefixed_Name(xsd, "gMonthDay").iri
                |> RDF_Literal.datatyped value_string


            let year (datetime: DateTime) =
                let value_string = datetime.Year.ToString("0000", CultureInfo.InvariantCulture)

                Prefixed_Name(xsd, "gYear").iri
                |> RDF_Literal.datatyped value_string


            let yearMonth (datetime: DateTime) =
                let value_string =
                    $"""{datetime.Year.ToString("0000", CultureInfo.InvariantCulture)}-{datetime.Month.ToString("00", CultureInfo.InvariantCulture)}"""

                Prefixed_Name(xsd, "gYearMonth").iri
                |> RDF_Literal.datatyped value_string

            let generalDay (day: int) =
                test <@ day >= 1 && day <= 99 @>
                let value_string = $"""---{day.ToString("00", CultureInfo.InvariantCulture)}"""

                Prefixed_Name(owl_time, "generalDay").iri
                |> RDF_Literal.datatyped value_string


            let generalMonth (month: int) =
                test <@ month >= 1 && month <= 20 @>
                let value_string = $"""--{month.ToString("00", CultureInfo.InvariantCulture)}"""

                Prefixed_Name(owl_time, "generalMonth").iri
                |> RDF_Literal.datatyped value_string


            let generalYear (year: int) =
                let value_string = year.ToString("0000", CultureInfo.InvariantCulture)

                Prefixed_Name(owl_time, "generalYear").iri
                |> RDF_Literal.datatyped value_string


    module Numeric =

        let private bigint_value_string (value: bigint) =
            value.ToString(CultureInfo.InvariantCulture)

        let integer (value: bigint) =
            Prefixed_Name(xsd, "integer").iri
            |> RDF_Literal.datatyped (bigint_value_string value)

        let negativeInteger (value: bigint) =
            test <@ value < 0I @>

            Prefixed_Name(xsd, "negativeInteger").iri
            |> RDF_Literal.datatyped (bigint_value_string value)

        let nonNegativeInteger (value: bigint) =
            test <@ value >= 0I @>

            Prefixed_Name(xsd, "nonNegativeInteger").iri
            |> RDF_Literal.datatyped (bigint_value_string value)

        let nonPositiveInteger (value: bigint) =
            test <@ value <= 0I @>

            Prefixed_Name(xsd, "nonPositiveInteger").iri
            |> RDF_Literal.datatyped (bigint_value_string value)

        let positiveInteger (value: bigint) =
            test <@ value > 0I @>

            Prefixed_Name(xsd, "positiveInteger").iri
            |> RDF_Literal.datatyped (bigint_value_string value)
