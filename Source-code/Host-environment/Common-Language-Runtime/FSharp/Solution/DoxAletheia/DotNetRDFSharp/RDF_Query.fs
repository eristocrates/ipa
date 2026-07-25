module DoxAletheia.RDF_Query

open System
open System.IO
open System.Xml
open System.Globalization
open System.Collections


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
open DotNetRDFSharp
open NamespaceRegistry
open PrettierNaming
open Graph_Data

type SparqlResultSet with
    member this.variable_column(rdf_variable: RDF_Variable) =
        this.Results
        |> Seq.map (fun result ->
            result.Item rdf_variable.identifier
            |> RDF_Term.from_vds_node)
        |> Seq.toArray

// ─────────────────────────────────────────────────────────────
// Existing dotNetRDF query-form adapters
// ─────────────────────────────────────────────────────────────

let SELECT_ALL () : ISelectBuilder = QueryBuilder.SelectAll()


let SELECT (variables: RDF_Variable seq) : ISelectBuilder =
    variables
    |> Seq.map (fun variable -> variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select


let CONSTRUCT (pattern_builder: TriplePatternBuilder) (formula: Formula) : IQueryBuilder =
    QueryBuilder.Construct(
        Action<IDescribeGraphPatternBuilder> (fun construct_template ->
            construct_template.Where(pattern_builder |> formula.as_graph_pattern)
            |> ignore)
    )


let ASK () : IQueryBuilder = QueryBuilder.Ask()


let DISCOVER (variables: RDF_Variable seq) : IDescribeBuilder =
    variables
    |> Seq.map (fun variable -> variable.question_form)
    |> Seq.toArray
    |> QueryBuilder.Describe


let DESCRIBE (iris: Iri seq) : SparqlQuery =
    iris
    |> Seq.map (fun iri -> iri.uri)
    |> Seq.toArray
    |> QueryBuilder.Describe
    |> fun builder -> builder.BuildQuery()


let repair_describe_variables (query: SparqlQuery) : SparqlQuery =
    if query.QueryType = SparqlQueryType.Describe then

        let query_variables = query.Variables :?> Generic.ICollection<SparqlVariable>

        query.DescribeVariables
        |> Seq.filter (fun token -> token.TokenType = Token.VARIABLE)
        |> Seq.iter (fun token ->

            let variable_name = token.Value.Substring(1)

            let already_registered =
                query_variables
                |> Seq.exists (fun variable -> variable.Name = variable_name)

            if not already_registered then
                query_variables.Add(SparqlVariable(variable_name, true)))

    query


let WHERE (pattern_builder: TriplePatternBuilder) (formula: Formula) (query_builder: IQueryBuilder) : SparqlQuery =
    query_builder
        .Where(pattern_builder |> formula.as_graph_pattern)
        .BuildQuery()
    |> repair_describe_variables


let private process_query (graph: IGraph) (query: SparqlQuery) : obj =
    let dataset = new InMemoryDataset(graph)

    let processor = new LeviathanQueryProcessor(dataset)

    processor.ProcessQuery(query)


type From_Where_Draft =
    { source_graph: IGraph option
      where_formula: Formula option }


let private empty_from_where_draft =
    { source_graph = None
      where_formula = None }


type From_Where_Builder<'Result>(execute: IGraph -> Formula -> 'Result) =

    member _.Yield(_: unit) : From_Where_Draft = empty_from_where_draft

    member _.Zero() : From_Where_Draft = empty_from_where_draft

    member _.For(_draft: From_Where_Draft, continuation: unit -> From_Where_Draft) : From_Where_Draft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: From_Where_Draft, graph: IGraph) : From_Where_Draft =
        match draft.source_graph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with source_graph = Some graph }


    [<CustomOperation("where")>]
    member _.Where(draft: From_Where_Draft, formula: Formula) : From_Where_Draft =
        match draft.where_formula with
        | Some _ -> invalidOp "The query already contains a where clause."

        | None -> { draft with where_formula = Some formula }


    member _.Run(draft: From_Where_Draft) : 'Result =
        let graph =
            match draft.source_graph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        let where_formula =
            match draft.where_formula with
            | Some formula -> formula

            | None -> invalidOp "The query requires a 'where' clause."


        execute graph where_formula

type From_Draft = { source_graph: IGraph option }


let private empty_from_draft = { source_graph = None }


type From_Builder<'Result>(execute: IGraph -> 'Result) =

    member _.Yield(_: unit) : From_Draft = empty_from_draft

    member _.Zero() : From_Draft = empty_from_draft

    member _.For(_draft: From_Draft, continuation: unit -> From_Draft) : From_Draft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: From_Draft, graph: IGraph) : From_Draft =
        match draft.source_graph with
        | Some _ -> invalidOp "The query already contains a source graph."

        | None -> { draft with source_graph = Some graph }


    member _.Run(draft: From_Draft) : 'Result =
        let graph =
            match draft.source_graph with
            | Some graph -> graph

            | None -> invalidOp "The query requires a graph supplied with 'from'."


        execute graph

module sparql =

    let select (variables: RDF_Variable seq) : From_Where_Builder<SparqlResultSet> =
        From_Where_Builder<SparqlResultSet> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = SELECT variables :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> SparqlResultSet)


    let select_all: From_Where_Builder<SparqlResultSet> =
        From_Where_Builder<SparqlResultSet> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = SELECT_ALL() :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> SparqlResultSet)


    let construct (construct_formula: Formula) : From_Where_Builder<IGraph> =
        From_Where_Builder<IGraph> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = CONSTRUCT pattern_builder construct_formula

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> IGraph)


    let ask: From_Where_Builder<bool> =
        From_Where_Builder<bool> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query = ASK() |> WHERE pattern_builder where_formula

            let result_set = process_query graph query :?> SparqlResultSet

            result_set.Result)


    let discover (variables: RDF_Variable seq) : From_Where_Builder<IGraph> =
        From_Where_Builder<IGraph> (fun graph where_formula ->

            let pattern_builder = TriplePatternBuilder(graph.NamespaceMap)

            let query_builder = DISCOVER variables :> IQueryBuilder

            let query =
                query_builder
                |> WHERE pattern_builder where_formula

            process_query graph query :?> IGraph)


    let describe (iris: Iri seq) : From_Builder<IGraph> =
        From_Builder<IGraph> (fun graph ->

            let query = DESCRIBE iris

            process_query graph query :?> IGraph)





