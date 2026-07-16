module DoxAletheia.MyProviderImplementation

open System
open System.Collections.Generic
open System.IO
open System.Reflection
open FSharp.Quotations
open FSharp.Core.CompilerServices
open DoxAletheia
open ProviderImplementation
open ProviderImplementation.ProvidedTypes
open VDS.RDF
open VDS.RDF.Parsing
open FSharp.Data


// Put any utility helpers here
[<AutoOpen>]
module internal Helpers =
    let x = 1
// https://fsprojects.github.io/FSharp.TypeProviders.SDK/quick-start.html
// registers the class with the F# compiler.
/// Inherits TypeProviderForNamespaces, not ITypeProvider directly.
/// addDefaultProbingLocation = true adds the design-time DLL's directory to the probing path so bundled dependencies are found.
[<TypeProvider>]
type BasicErasingProvider(config: TypeProviderConfig) as this =
    inherit TypeProviderForNamespaces
        (
            config,
            assemblyReplacementMap = [ ("MyProvider.DesignTime", "MyProvider.Runtime") ],
            addDefaultProbingLocation = true
        )

    let ns = "ErasingProvider"
    let asm = Assembly.GetExecutingAssembly()

    // check we contain a copy of runtime files, and are not referencing the runtime DLL
    do assert (typeof<DataSource>.Assembly.GetName().Name = asm.GetName().Name)

    let createTypes () =
        /// Some typeof<obj> is the erased base type. All values of MyType are represented as plain obj at runtime — no IL is emitted for MyType itself.
        let myType = ProvidedTypeDefinition(asm, ns, "MyType", Some typeof<obj>)

        let greetingProp =
            ProvidedProperty(
                "Greeting",
                typeof<string>,
                isStatic = true,
                getterCode = fun _args -> <@@ "Hello from MyType!" @@>
            )

        greetingProp.AddXmlDoc "Returns a fixed greeting string."
        myType.AddMember greetingProp

        let ctor =
            ProvidedConstructor([], invokeCode = fun args -> <@@ "My internal state" :> obj @@>)

        myType.AddMember(ctor)

        let ctor2 =
            ProvidedConstructor(
                [ ProvidedParameter("InnerState", typeof<string>) ],
                invokeCode = fun args -> <@@ (%%(args.[0]): string) :> obj @@>
            )

        myType.AddMember(ctor2)

        let innerState =
            ProvidedProperty(
                "InnerState",
                typeof<string>,
                getterCode = fun args -> <@@ (%%(args.[0]) :> obj) :?> string @@>
            )

        myType.AddMember(innerState)

        let greetMethod =
            ProvidedMethod(
                "Greet",
                [ ProvidedParameter("name", typeof<string>) ],
                typeof<string>,
                invokeCode = fun args -> <@@ sprintf "Hello, %s!" (%%(args.[1]): string) @@>
            )

        greetMethod.AddXmlDoc "Returns a personalised greeting."
        myType.AddMember greetMethod

        let meth =
            ProvidedMethod(
                "StaticMethod",
                [],
                typeof<DataSource>,
                isStatic = true,
                invokeCode = (fun args -> Expr.Value(null, typeof<DataSource>))
            )

        myType.AddMember(meth)

        let nameOf =
            let param = ProvidedParameter("p", typeof<Expr<int>>)

            param.AddCustomAttribute
                { new CustomAttributeData() with
                    member __.Constructor = typeof<ReflectedDefinitionAttribute>.GetConstructor ([||])
                    member __.ConstructorArguments = [||] :> _
                    member __.NamedArguments = [||] :> _ }

            ProvidedMethod(
                "NameOf",
                [ param ],
                typeof<string>,
                isStatic = true,
                invokeCode =
                    fun args ->
                        <@@ match (%%args.[0]): Expr<int> with
                            | Microsoft.FSharp.Quotations.Patterns.ValueWithName (_, _, n) -> n
                            | e -> failwithf "Invalid quotation argument (expected ValueWithName): %A" e @@>
            )

        myType.AddMember(nameOf)

        [ myType ]

    do this.AddNamespace(ns, createTypes ())

[<TypeProvider>]
type BasicGenerativeProvider(config: TypeProviderConfig) as this =
    inherit TypeProviderForNamespaces
        (
            config,
            assemblyReplacementMap = [ ("MyProvider.DesignTime", "MyProvider.Runtime") ]
        )

    let ns = "GenerativeProvider"
    let asm = Assembly.GetExecutingAssembly()

    // check we contain a copy of runtime files, and are not referencing the runtime DLL
    do assert (typeof<DataSource>.Assembly.GetName().Name = asm.GetName().Name)

    let createType typeName (count: int) =
        let asm = ProvidedAssembly()

        let myType =
            ProvidedTypeDefinition(asm, ns, typeName, Some typeof<obj>, isErased = false)

        let ctor =
            ProvidedConstructor([], invokeCode = fun args -> <@@ "My internal state" :> obj @@>)

        myType.AddMember(ctor)

        let ctor2 =
            ProvidedConstructor(
                [ ProvidedParameter("InnerState", typeof<string>) ],
                invokeCode = fun args -> <@@ (%%(args.[1]): string) :> obj @@>
            )

        myType.AddMember(ctor2)

        for i in 1..count do
            let prop =
                ProvidedProperty("Property" + string i, typeof<int>, getterCode = fun args -> <@@ i @@>)

            myType.AddMember(prop)

        let meth =
            ProvidedMethod(
                "StaticMethod",
                [],
                typeof<DataSource>,
                isStatic = true,
                invokeCode = (fun args -> Expr.Value(null, typeof<DataSource>))
            )

        myType.AddMember(meth)
        asm.AddTypes [ myType ]

        myType

    let myParamType =
        let t =
            ProvidedTypeDefinition(asm, ns, "GenerativeProvider", Some typeof<obj>, isErased = false)

        t.DefineStaticParameters(
            [ ProvidedStaticParameter("Count", typeof<int>) ],
            fun typeName args -> createType typeName (unbox<int> args.[0])
        )

        t

    do this.AddNamespace(ns, [ myParamType ])

(*



type RDF_Node =
    // A Blank Node
    | Blank of BlankNode
    // A Graph Literal Node
    | GraphLiteral of GraphLiteralNode
    // A Literal Node
    | Literal of LiteralNode
    // A triple node (used in RDF-Star graphs)
    | Triple of TripleNode
    // A Uri Node
    | Iri of UriNode
    | NamespacedIri of namespace_uri: Uri * local_name: string
    // A Variable Node
    | Variable of VariableNode
    member this.string_value =
        match this with
        | Blank node -> node.InternalID
        | GraphLiteral node -> node.SubGraph.Name.ToString()
        | Literal node -> node.Value
        | Triple node ->
            let subject = node.Triple.Subject.ToString()
            let predicate = node.Triple.Predicate.ToString()
            let object = node.Triple.Object.ToString()
            sprintf "%s %s %s " subject predicate object
        | Iri node -> node.Uri.OriginalString
        | NamespacedIri (namespace_name, local_name) -> sprintf "%s%s" namespace_name.OriginalString local_name
        | Variable node -> node.VariableName

    static member from_inode(inode: INode) =
        match inode.NodeType with
        | NodeType.Blank -> Blank(inode :?> BlankNode)
        | NodeType.GraphLiteral -> GraphLiteral(inode :?> GraphLiteralNode)
        | NodeType.Literal -> Literal(inode :?> LiteralNode)
        | NodeType.Triple -> Triple(inode :?> TripleNode)
        | NodeType.Uri -> Iri(inode :?> UriNode)
        | NodeType.Variable -> Variable(inode :?> VariableNode)
        | _ -> failwithf "inode  %A cannot become an RDF_Node  is not a known dotNetRdf NodeType " inode

let prefix_set_by_namespace_name (graph: IGraph) =
    graph.NamespaceMap.Prefixes
    |> Seq.toArray
    |> Array.Parallel.map (fun prefix ->
        let namespace_uri = graph.NamespaceMap.GetNamespaceUri prefix
        namespace_uri.OriginalString, set [ prefix ])
    |> Map.ofArray

let try_namespaced_name (node: RDF_Node) (namespace_names: string array) =
    namespace_names
    |> Array.tryFind (fun namespace_name -> node.string_value.StartsWith(namespace_name))
*)

[<TypeProvider>]
type RdfGenerativeProvider(config: TypeProviderConfig) as this =
    inherit TypeProviderForNamespaces
        (
            config,
            assemblyReplacementMap = [ ("MyProvider.DesignTime", "MyProvider.Runtime") ],
            addDefaultProbingLocation = true
        )

    let ns = "Rdf_Provider"
    let asm = Assembly.GetExecutingAssembly()

    // check we contain a copy of runtime files, and are not referencing the runtime DLL
    do assert (typeof<DataSource>.Assembly.GetName().Name = asm.GetName().Name)

    let createType typeName (rdf_namespace_name: string) (rdf_sources: string)(label_override:bool) =
        let asm = ProvidedAssembly()

        let myType =
            ProvidedTypeDefinition(asm, ns, typeName, Some typeof<obj>, isErased = false)

        let ctor =
            ProvidedConstructor([], invokeCode = fun args -> <@@ "My internal state" :> obj @@>)

        myType.AddMember(ctor)

        let ctor2 =
            ProvidedConstructor(
                [ ProvidedParameter("InnerState", typeof<string>) ],
                invokeCode = fun args -> <@@ (%%(args.[1]): string) :> obj @@>
            )

        myType.AddMember(ctor2)
        let term_label_comments =
            let isEnglishOrUnspecified (literal: LiteralNode) =
                String.IsNullOrWhiteSpace literal.Language
                || literal.Language.StartsWith("en", StringComparison.OrdinalIgnoreCase)

            let literalValuesForPredicate predicateFilter (graph: ThreadSafeGraph) subject predicate =
                graph.GetTriplesWithSubjectPredicate(subject, predicate)
                |> Seq.choose (fun triple ->
                    match triple.Object with
                    | :? LiteralNode as literal when predicateFilter literal ->
                        Some literal.Value
                    | _ ->
                        None
                )
                |> Seq.distinct
                |> Seq.toArray

            rdf_sources.Split([| ';' |], StringSplitOptions.RemoveEmptyEntries)
            |> Array.map _.Trim()
            |> Array.filter (String.IsNullOrWhiteSpace >> not)
            |> Array.Parallel.collect (fun rdf_source ->

                let graph = new ThreadSafeGraph()
                FileLoader.Load(graph, rdf_source)

                let rdfs_label =
                    graph.CreateUriNode(UriFactory.Create("http://www.w3.org/2000/01/rdf-schema#label"))

                let rdfs_comment =
                    let comment = 
                        match rdf_namespace_name with 
                        | "https://w3id.org/linkml/" -> "https://w3id.org/linkml/comments"
                        | _ -> "http://www.w3.org/2000/01/rdf-schema#comment"
                    graph.CreateUriNode(UriFactory.Create(comment))

                let vocabulary_terms =
                    graph.AllNodes
                    |> Seq.choose (fun node ->
                        match node with
                        | :? UriNode as iri -> Some iri
                        | _ -> None
                    )
                    |> Seq.filter (fun iri ->
                        iri.Uri.OriginalString.StartsWith(rdf_namespace_name)
                        && iri.Uri.OriginalString <> rdf_namespace_name
                    )
                    |> Seq.distinctBy (fun iri -> iri.Uri.OriginalString)
                    |> Seq.toArray

                vocabulary_terms
                |> Array.Parallel.map (fun vocabulary_term ->
                    let labels =
                        literalValuesForPredicate
                            (fun (_: LiteralNode) -> true)
                            graph
                            vocabulary_term
                            rdfs_label

                    let comments =
                        literalValuesForPredicate
                            isEnglishOrUnspecified
                            graph
                            vocabulary_term
                            rdfs_comment

                    vocabulary_term.Uri.OriginalString, labels, comments
                )
            )
            |> Array.groupBy (fun (iri_string, _, _) -> iri_string)
            |> Array.map (fun (iri_string, rows) ->
                let labels =
                    rows
                    |> Array.collect (fun (_, labels, _) -> labels)
                    |> Array.distinct

                let comments =
                    rows
                    |> Array.collect (fun (_, _, comments) -> comments)
                    |> Array.distinct

                iri_string, labels, comments
            )
        myType.AddMembers(
            [
                        ProvidedProperty(
                            "_namespace_name",
                            typeof<string>,
                            isStatic = true,
                            getterCode = fun args -> <@@ rdf_namespace_name @@>
                        )
                        ProvidedProperty(
                            "_vocabulary",
                            typeof<IRIREF>,
                            isStatic = true,
                            getterCode = fun args -> <@@ Namespaced_IRI.parse rdf_namespace_name "" |> NamespacedName  @@>
                        )
                
            ]
        )
        myType.AddMembersDelayed(fun () ->

            [

                for iri_string, labels, comments in term_label_comments do
                    let local_part = iri_string[rdf_namespace_name.Length..]

                    let property_name =
                        match label_override, labels with
                        | true, labels when labels.Length > 0 -> labels.[0]
                        | _ -> local_part

                    let term_property =
                        ProvidedProperty(
                            property_name,
                            typeof<IRIREF>,
                            isStatic = true,
                            getterCode = fun args -> <@@ Namespaced_IRI.parse rdf_namespace_name local_part |> NamespacedName @@>
                        )

                    if comments.Length > 0 then
                        let commentText =
                            comments
                            |> String.concat "\n"

                        sprintf "%s\n\n%s" commentText iri_string
                        |> term_property.AddXmlDoc

                    term_property
            ]
        )

        asm.AddTypes [ myType ]

        myType

    let myParamType =
        let t =
            ProvidedTypeDefinition(asm, ns, "Rdf_Vocabulary", Some typeof<obj>, isErased = false)

        t.DefineStaticParameters(
            parameters =
                [ 
                    
                    ProvidedStaticParameter("Namespace_Name", typeof<string>)
                    ProvidedStaticParameter("File_Paths", typeof<string>) 
                    ProvidedStaticParameter("Label_Override", typeof<bool>, parameterDefaultValue = false) 
                    
                    ],
            instantiationFunction =
                fun typeName args ->
                    let Namespace_Name = unbox<string> args.[0]
                    let Sources = unbox<string> args.[1]
                    let Label_Override = unbox<bool> args.[2]

                    createType typeName Namespace_Name Sources Label_Override
        )

        t

    do this.AddNamespace(ns, [ myParamType ])

