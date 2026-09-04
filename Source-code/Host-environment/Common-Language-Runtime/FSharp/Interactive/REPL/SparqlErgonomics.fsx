#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"


#r "RdfAsm.dll"

open RdfAsm
open Dubzer.WhatwgUrl
open VDS.RDF.Query
open VDS.RDF.Query.Expressions
open VDS.RDF.Query.Builder
open System
open VDS.RDF.Query.Patterns
open VDS.RDF
open System.Net.Http
open System.Threading
open System.Threading.Tasks
open VDS.RDF.Query.Datasets



// ============================================================================
// Result access
// ============================================================================
type SparqlResultSet with

    member this.columnByVariables(rdfVariable: RdfVariable) =
        this.Results
        |> Seq.map (fun result ->
            result.Item rdfVariable.identifier
            |> Point.fromINode)
        |> Seq.toArray

module SparqlResultSet =

    let variableIndex (rdfVariable: RdfVariable) (index: int) (resultSet: SparqlResultSet) =
        resultSet.Results
        |> Seq.map (fun result ->
            result.Item rdfVariable.identifier
            |> Point.fromINode)
        |> Seq.item index


// ============================================================================
// SPARQL graph-pattern model
//
// Formula remains useful: it represents the basic graph-pattern case already
// expressible by the RDF terms/triples in the surrounding code.
//
// SparqlGraphPattern represents the larger SPARQL graph-pattern language.
// ============================================================================

type SparqlGraphSelector =
    | GraphIri of Iri
    | GraphVariable of RdfVariable


type SparqlGraphPattern =
    | BasicGraphPattern of Formula
    | GroupGraphPattern of SparqlGraphPattern array
    | OptionalGraphPattern of SparqlGraphPattern
    | UnionGraphPattern of SparqlGraphPattern array
    | MinusGraphPattern of SparqlGraphPattern
    | NamedGraphPattern of SparqlGraphSelector * SparqlGraphPattern
    | ServiceGraphPattern of Iri * SparqlGraphPattern
    | FilterGraphPattern of ISparqlExpression
    | BindGraphPattern of RdfVariable * ISparqlExpression


module SparqlPattern =

    let basic (formula: Formula) = BasicGraphPattern formula


    let group (patterns: SparqlGraphPattern seq) =
        patterns |> Seq.toArray |> GroupGraphPattern


    let optional (pattern: SparqlGraphPattern) = OptionalGraphPattern pattern


    let union (patterns: SparqlGraphPattern seq) =

        let patterns = patterns |> Seq.toArray

        if patterns.Length < 2 then
            invalidArg (nameof patterns) "A SPARQL UNION requires at least two graph patterns."

        UnionGraphPattern patterns


    let minus (pattern: SparqlGraphPattern) = MinusGraphPattern pattern


    let graph (graphIri: Iri) (pattern: SparqlGraphPattern) =
        NamedGraphPattern(GraphIri graphIri, pattern)


    let graphVariable (graphVariable: RdfVariable) (pattern: SparqlGraphPattern) =
        NamedGraphPattern(GraphVariable graphVariable, pattern)


    let service (endpoint: Iri) (pattern: SparqlGraphPattern) = ServiceGraphPattern(endpoint, pattern)


    let filter (expression: ISparqlExpression) = FilterGraphPattern expression


    let bind (rdfVariable: RdfVariable) (expression: ISparqlExpression) =
        BindGraphPattern(rdfVariable, expression)


// ============================================================================
// SPARQL dataset clauses
//
// These are SPARQL query-language dataset declarations:
//
//     FROM <iri>
//     FROM NAMED <iri>
//
// They are NOT execution targets.
// ============================================================================

type SparqlDatasetClause =
    | From of Iri
    | FromNamed of Iri


// ============================================================================
// Strongly typed query values
//
// Building a query no longer executes it.
//
// The query form determines the result type without routing everything through
// obj.
// ============================================================================

type SelectQuery =
    { selectQuery: SparqlQuery }

    member this.asSparqlQuery = this.selectQuery

    member this.text = this.selectQuery.ToString()


type AskQuery =
    { askQuery: SparqlQuery }

    member this.asSparqlQuery = this.askQuery

    member this.text = this.askQuery.ToString()


type GraphQuery =
    { graphQuery: SparqlQuery }

    member this.asSparqlQuery = this.graphQuery

    member this.text = this.graphQuery.ToString()


// ============================================================================
// Low-level dotNetRDF query-form adapters
// ============================================================================

let private SELECTALL () : ISelectBuilder = QueryBuilder.SelectAll()


let private SELECT (variables: RdfVariable seq) : ISelectBuilder =

    variables
    |> Seq.map (fun variable -> variable.identifier)
    |> Seq.toArray
    |> QueryBuilder.Select


let private ASK () : IQueryBuilder = QueryBuilder.Ask()


let private DISCOVER (variables: RdfVariable seq) : IDescribeBuilder =

    variables
    |> Seq.map (fun variable -> variable.questionForm)
    |> Seq.toArray
    |> QueryBuilder.Describe


let private DESCRIBE (iris: Iri seq) : SparqlQuery =

    iris
    |> Seq.map (fun iri -> iri.asUri)
    |> Seq.toArray
    |> QueryBuilder.Describe
    |> fun builder -> builder.BuildQuery()


// ============================================================================
// DESCRIBE variable repair
//
// Retained from the previous implementation because the surrounding code
// already depended upon this behavior.
// ============================================================================

let private repairDescribeVariables (sparqlQuery: SparqlQuery) : SparqlQuery =

    if sparqlQuery.QueryType = SparqlQueryType.Describe then

        let queryVariables =
            sparqlQuery.Variables :?> System.Collections.Generic.ICollection<SparqlVariable>

        sparqlQuery.DescribeVariables
        |> Seq.filter (fun token -> token.TokenType = VDS.RDF.Parsing.Tokens.Token.VARIABLE)
        |> Seq.iter (fun token ->

            let variableName = token.Value.Substring(1)

            let alreadyRegistered =
                queryVariables
                |> Seq.exists (fun variable -> variable.Name = variableName)

            if not alreadyRegistered then
                queryVariables.Add(SparqlVariable(variableName, true)))

    sparqlQuery


// ============================================================================
// Prefix handling
//
// Query construction must not require an execution graph merely to obtain a
// NamespaceMap. The existing global namespaceMapper is therefore imported into
// each query builder.
// ============================================================================

let private importQueryPrefixes (queryBuilder: IQueryBuilder) : IQueryBuilder =

    queryBuilder.Prefixes.Import namespaceMapper

    queryBuilder


// ============================================================================
// Graph-pattern lowering
//
// Converts the F# SparqlGraphPattern representation into dotNetRDF's
// GraphPatternBuilder representation.
// ============================================================================

let rec private applyGraphPattern
    (patternBuilder: TriplePatternBuilder)
    (builder: IGraphPatternBuilder)
    (graphPattern: SparqlGraphPattern)
    : unit =

    let action (pattern: SparqlGraphPattern) =
        Action<IGraphPatternBuilder>(fun childBuilder -> applyGraphPattern patternBuilder childBuilder pattern)

    match graphPattern with

    | BasicGraphPattern formula ->

        builder.Where(patternBuilder |> formula.ITriplePatterns)
        |> ignore


    | GroupGraphPattern patterns ->

        builder.Group(
            Action<IGraphPatternBuilder> (fun groupBuilder ->

                patterns
                |> Array.iter (applyGraphPattern patternBuilder groupBuilder))
        )
        |> ignore


    | OptionalGraphPattern pattern ->

        builder.Optional(action pattern) |> ignore


    | UnionGraphPattern patterns ->

        if patterns.Length < 2 then
            invalidOp "A SPARQL UNION requires at least two graph patterns."

        let actions = patterns |> Array.map action

        builder.Union(actions[0], actions[1..]) |> ignore


    | MinusGraphPattern pattern ->

        builder.Minus(action pattern) |> ignore


    | NamedGraphPattern (GraphIri graphIri, pattern) ->

        builder.Graph(graphIri.asUri, action pattern)
        |> ignore


    | NamedGraphPattern (GraphVariable graphVariable, pattern) ->

        builder.Graph(graphVariable.questionForm, action pattern)
        |> ignore


    | ServiceGraphPattern (endpoint, pattern) ->

        builder.Service(endpoint.asUri, action pattern)
        |> ignore


    | FilterGraphPattern expression ->

        builder.Filter(expression) |> ignore


    | BindGraphPattern (rdfVariable, expression) ->

        builder.Where(BindPattern(rdfVariable.identifier, expression) :> ITriplePattern)
        |> ignore


let private applyWherePattern (queryBuilder: IQueryBuilder) (wherePattern: SparqlGraphPattern) : IQueryBuilder =

    let patternBuilder = TriplePatternBuilder(queryBuilder.Prefixes)

    applyGraphPattern patternBuilder queryBuilder.Root wherePattern

    queryBuilder


// ============================================================================
// Query-level RDF dataset lowering
//
// These become literal SPARQL FROM / FROM NAMED clauses on SparqlQuery.
// ============================================================================

let private applyDatasetClauses (datasetClauses: SparqlDatasetClause array) (sparqlQuery: SparqlQuery) : SparqlQuery =

    datasetClauses
    |> Array.iter (function

        | From graphIri ->

            sparqlQuery.AddDefaultGraph(graphIri.asUriNode :> IRefNode)


        | FromNamed graphIri ->

            sparqlQuery.AddNamedGraph(graphIri.asUriNode :> IRefNode))

    sparqlQuery


// ============================================================================
// Typed query compilers
// ============================================================================

let private buildSelectQuery
    (variables: RdfVariable array option)
    (datasetClauses: SparqlDatasetClause array)
    (wherePattern: SparqlGraphPattern)
    : SelectQuery =

    let queryBuilder: IQueryBuilder =

        match variables with

        | Some variables -> SELECT variables :> IQueryBuilder

        | None -> SELECTALL() :> IQueryBuilder


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    { selectQuery = query }


let private buildAskQuery (datasetClauses: SparqlDatasetClause array) (wherePattern: SparqlGraphPattern) : AskQuery =

    let query =

        ASK()
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    { askQuery = query }


let private buildConstructQuery
    (constructFormula: Formula)
    (datasetClauses: SparqlDatasetClause array)
    (wherePattern: SparqlGraphPattern)
    : GraphQuery =

    let queryBuilder =

        QueryBuilder.Construct(
            Action<IDescribeGraphPatternBuilder> (fun constructTemplate ->

                let templatePatternBuilder = TriplePatternBuilder(namespaceMapper)

                constructTemplate.Where(
                    templatePatternBuilder
                    |> constructFormula.ITriplePatterns
                )
                |> ignore)
        )


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> applyDatasetClauses datasetClauses


    { graphQuery = query }


let private buildDiscoverQuery
    (variables: RdfVariable array)
    (datasetClauses: SparqlDatasetClause array)
    (wherePattern: SparqlGraphPattern)
    : GraphQuery =

    let queryBuilder =

        DISCOVER variables :> IQueryBuilder


    let query =

        queryBuilder
        |> importQueryPrefixes
        |> fun builder -> applyWherePattern builder wherePattern
        |> fun builder -> builder.BuildQuery()
        |> repairDescribeVariables
        |> applyDatasetClauses datasetClauses


    { graphQuery = query }


let private buildDescribeQuery (iris: Iri array) : GraphQuery =

    let query =

        iris |> DESCRIBE

    query.NamespaceMap.Import namespaceMapper

    { graphQuery = query }


// ============================================================================
// Query computation-expression state
// ============================================================================

type SparqlQueryDraft =
    { datasetClauses: SparqlDatasetClause list

      wherePattern: SparqlGraphPattern option }


let private emptySparqlQueryDraft =
    { datasetClauses = []

      wherePattern = None }


// ============================================================================
// Query computation-expression builder
//
// Notice the changed semantics:
//
//     from iri
//
// now means actual SPARQL:
//
//     FROM <iri>
//
// It no longer means "execute against this IGraph".
// ============================================================================

type WhereQueryBuilder<'Query>(build: SparqlQueryDraft -> SparqlGraphPattern -> 'Query) =


    member _.Yield(_: unit) : SparqlQueryDraft = emptySparqlQueryDraft


    member _.Zero() : SparqlQueryDraft = emptySparqlQueryDraft


    member _.For(_draft: SparqlQueryDraft, continuation: unit -> SparqlQueryDraft) : SparqlQueryDraft = continuation ()


    [<CustomOperation("from")>]
    member _.From(draft: SparqlQueryDraft, graphIri: Iri) : SparqlQueryDraft =

        { draft with

            datasetClauses = From graphIri :: draft.datasetClauses }


    [<CustomOperation("fromNamed")>]
    member _.FromNamed(draft: SparqlQueryDraft, graphIri: Iri) : SparqlQueryDraft =

        { draft with

            datasetClauses = FromNamed graphIri :: draft.datasetClauses }


    // Compatibility/convenience form:
    //
    //     where formula
    //
    // A Formula becomes a basic graph pattern.

    [<CustomOperation("where")>]
    member _.Where(draft: SparqlQueryDraft, formula: Formula) : SparqlQueryDraft =

        match draft.wherePattern with

        | Some _ ->

            invalidOp "The query already contains a WHERE graph pattern."


        | None ->

            { draft with

                wherePattern = Some(BasicGraphPattern formula) }


    // Full graph-pattern form:
    //
    //     wherePattern pattern
    //
    // This is used for GRAPH, OPTIONAL, UNION, MINUS, SERVICE, FILTER, BIND,
    // nested groups, etc.

    [<CustomOperation("wherePattern")>]
    member _.WherePattern(draft: SparqlQueryDraft, graphPattern: SparqlGraphPattern) : SparqlQueryDraft =

        match draft.wherePattern with

        | Some _ ->

            invalidOp "The query already contains a WHERE graph pattern."


        | None ->

            { draft with

                wherePattern = Some graphPattern }


    member _.Run(draft: SparqlQueryDraft) : 'Query =

        let wherePattern =

            match draft.wherePattern with

            | Some wherePattern -> wherePattern

            | None -> invalidOp "The query requires a WHERE graph pattern."


        let normalizedDraft =

            { draft with

                datasetClauses = draft.datasetClauses |> List.rev }


        build normalizedDraft wherePattern


// ============================================================================
// Public SPARQL query-authoring surface
//
// These BUILD query values. They do not execute.
// ============================================================================

module sparql =


    let select (variables: RdfVariable seq) : WhereQueryBuilder<SelectQuery> =

        let variables = variables |> Seq.toArray

        WhereQueryBuilder<SelectQuery> (fun draft wherePattern ->

            buildSelectQuery (Some variables) (draft.datasetClauses |> List.toArray) wherePattern)


    let selectAll: WhereQueryBuilder<SelectQuery> =

        WhereQueryBuilder<SelectQuery> (fun draft wherePattern ->

            buildSelectQuery None (draft.datasetClauses |> List.toArray) wherePattern)


    let construct (constructFormula: Formula) : WhereQueryBuilder<GraphQuery> =

        WhereQueryBuilder<GraphQuery> (fun draft wherePattern ->

            buildConstructQuery constructFormula (draft.datasetClauses |> List.toArray) wherePattern)


    let ask: WhereQueryBuilder<AskQuery> =

        WhereQueryBuilder<AskQuery> (fun draft wherePattern ->

            buildAskQuery (draft.datasetClauses |> List.toArray) wherePattern)


    // "discover" remains your convenience name for:
    //
    //     DESCRIBE ?variable ...
    //     WHERE { ... }

    let discover (variables: RdfVariable seq) : WhereQueryBuilder<GraphQuery> =

        let variables = variables |> Seq.toArray

        WhereQueryBuilder<GraphQuery> (fun draft wherePattern ->

            buildDiscoverQuery variables (draft.datasetClauses |> List.toArray) wherePattern)


    // DESCRIBE of concrete IRIs does not require a WHERE clause and therefore
    // remains a direct function rather than a WhereQueryBuilder.

    let describe (iris: Iri seq) : GraphQuery =

        iris |> Seq.toArray |> buildDescribeQuery


// ============================================================================
// SPARQL Protocol dataset
//
// This is deliberately separate from SparqlDatasetClause.
//
// These values become HTTP protocol parameters on a remote endpoint:
//
//     default-graph-uri
//     named-graph-uri
//
// rather than FROM / FROM NAMED in the SPARQL text.
// ============================================================================

type SparqlProtocolDataset =
    { defaultGraphs: Iri array

      namedGraphs: Iri array }

    static member Empty =
        { defaultGraphs = [||]

          namedGraphs = [||] }


// ============================================================================
// Remote SPARQL endpoint
//
// This is the remote execution substrate.
// It is NOT part of the query AST.
// ============================================================================

type SparqlRemoteEndpoint =
    { httpClient: HttpClient

      endpointUri: Uri

      protocolDataset: SparqlProtocolDataset }


    static member fromUri(httpClient: HttpClient, endpointUri: Uri) =

        { httpClient = httpClient

          endpointUri = endpointUri

          protocolDataset = SparqlProtocolDataset.Empty }


    static member fromString(httpClient: HttpClient, endpointUri: string) =

        SparqlRemoteEndpoint.fromUri (httpClient, Uri endpointUri)


    static member fromIri(httpClient: HttpClient, endpointIri: Iri) =

        SparqlRemoteEndpoint.fromUri (httpClient, endpointIri.asUri)

    static member fromUrl(httpClient: HttpClient, endpointUrl: DomUrl) =

        SparqlRemoteEndpoint.fromUri (httpClient, Uri endpointUrl.Href)


    member this.withDefaultGraph(graphIri: Iri) =

        { this with

            protocolDataset =
                { this.protocolDataset with

                    defaultGraphs = Array.append this.protocolDataset.defaultGraphs [| graphIri |] } }


    member this.withNamedGraph(graphIri: Iri) =

        { this with

            protocolDataset =
                { this.protocolDataset with

                    namedGraphs = Array.append this.protocolDataset.namedGraphs [| graphIri |] } }


    member private this.createClient() =

        let client = SparqlQueryClient(this.httpClient, this.endpointUri)


        this.protocolDataset.defaultGraphs
        |> Array.iter (fun graphIri ->

            client.DefaultGraphs.Add(graphIri.lexicalForm))


        this.protocolDataset.namedGraphs
        |> Array.iter (fun graphIri ->

            client.NamedGraphs.Add(graphIri.lexicalForm))


        client


    member this.query(selectQuery: SelectQuery, ?cancellationToken: CancellationToken) : Task<SparqlResultSet> =

        let cancellationToken = defaultArg cancellationToken CancellationToken.None

        let client = this.createClient ()

        client.QueryWithResultSetAsync(selectQuery.text, cancellationToken)


    member this.query(askQuery: AskQuery, ?cancellationToken: CancellationToken) : Task<bool> =

        task {

            let cancellationToken = defaultArg cancellationToken CancellationToken.None

            let client = this.createClient ()

            let! resultSet = client.QueryWithResultSetAsync(askQuery.text, cancellationToken)

            return resultSet.Result
        }


    member this.query(graphQuery: GraphQuery, ?cancellationToken: CancellationToken) : Task<IGraph> =

        let cancellationToken = defaultArg cancellationToken CancellationToken.None

        let client = this.createClient ()

        client.QueryWithResultGraphAsync(graphQuery.text, cancellationToken)


// ============================================================================
// Local SPARQL dataset
//
// A local graph is only one special case of a local RDF dataset.
//
// A caller can now execute against:
//
//     IGraph
//     IInMemoryQueryableStore
//     ISparqlDataset
//
// without changing the query itself.
// ============================================================================

type SparqlLocalDataset =
    { dataset: ISparqlDataset }


    static member fromDataset(dataset: ISparqlDataset) =

        { dataset = dataset }


    static member fromGraph(graph: IGraph) =

        { dataset = new InMemoryDataset(graph) :> ISparqlDataset }


    static member fromStore(store: IInMemoryQueryableStore) =

        { dataset = new InMemoryDataset(store) :> ISparqlDataset }


    member private this.processQuery(query: SparqlQuery) =

        let processor = new LeviathanQueryProcessor(this.dataset)

        processor.ProcessQuery(query)


    member this.query(selectQuery: SelectQuery) : SparqlResultSet =

        this.processQuery (selectQuery.asSparqlQuery) :?> SparqlResultSet


    member this.query(askQuery: AskQuery) : bool =

        let resultSet =

            this.processQuery (askQuery.asSparqlQuery) :?> SparqlResultSet

        resultSet.Result


    member this.query(graphQuery: GraphQuery) : IGraph =

        this.processQuery (graphQuery.asSparqlQuery) :?> IGraph





type DomUrl with
    member this.asSparqlRemoteEndpoint =
        SparqlRemoteEndpoint.fromString (new HttpClient(), this.Href)
