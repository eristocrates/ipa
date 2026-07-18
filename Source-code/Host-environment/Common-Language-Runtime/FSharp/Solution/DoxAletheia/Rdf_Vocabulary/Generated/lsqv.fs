namespace http.lsq.aksw.org.vocab.hash

open DoxAletheia.Rdf_Vocabulary

module lsqv =
    let _namespace_name = "http://lsq.aksw.org/vocab#"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Avg"></see>
    /// </summary>
    let Avg = Namespaced_IRI.parse _namespace_name "Avg" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Bind"></see>
    /// </summary>
    let Bind = Namespaced_IRI.parse _namespace_name "Bind" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Count"></see>
    /// </summary>
    let Count = Namespaced_IRI.parse _namespace_name "Count" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Distinct"></see>
    /// </summary>
    let Distinct = Namespaced_IRI.parse _namespace_name "Distinct" |> NamespacedName
    /// <summary>
    /// Each instance is an execution of a particular query against a particular endpoint at a particular time by a particular agent
    /// <see href="http://lsq.aksw.org/vocab#Execution"></see></summary>
    let Execution = Namespaced_IRI.parse _namespace_name "Execution" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Filter"></see>
    /// </summary>
    let Filter = Namespaced_IRI.parse _namespace_name "Filter" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#FromNamed"></see>
    /// </summary>
    let FromNamed = Namespaced_IRI.parse _namespace_name "FromNamed" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#GroupBy"></see>
    /// </summary>
    let GroupBy = Namespaced_IRI.parse _namespace_name "GroupBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Having"></see>
    /// </summary>
    let Having = Namespaced_IRI.parse _namespace_name "Having" |> NamespacedName
    /// <summary>
    /// Each instance is a hybrid join vertex (position) in the query (at least one incoming edge, at least one outgoing edge, at least three edges)
    /// <see href="http://lsq.aksw.org/vocab#Hybrid"></see></summary>
    let Hybrid = Namespaced_IRI.parse _namespace_name "Hybrid" |> NamespacedName
    /// <summary>
    /// Each instance is a join vertex (position) in the query
    /// <see href="http://lsq.aksw.org/vocab#JoinVertex"></see></summary>
    let JoinVertex = Namespaced_IRI.parse _namespace_name "JoinVertex" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Limit"></see>
    /// </summary>
    let Limit = Namespaced_IRI.parse _namespace_name "Limit" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Max"></see>
    /// </summary>
    let Max = Namespaced_IRI.parse _namespace_name "Max" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Min"></see>
    /// </summary>
    let Min = Namespaced_IRI.parse _namespace_name "Min" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Minus"></see>
    /// </summary>
    let Minus = Namespaced_IRI.parse _namespace_name "Minus" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#NamedGraph"></see>
    /// </summary>
    let NamedGraph = Namespaced_IRI.parse _namespace_name "NamedGraph" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#namedGraph"></see>
    /// </summary>
    let namedGraph = Namespaced_IRI.parse _namespace_name "namedGraph" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Offset"></see>
    /// </summary>
    let Offset = Namespaced_IRI.parse _namespace_name "Offset" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Optional"></see>
    /// </summary>
    let Optional = Namespaced_IRI.parse _namespace_name "Optional" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#OrderBy"></see>
    /// </summary>
    let OrderBy = Namespaced_IRI.parse _namespace_name "OrderBy" |> NamespacedName
    /// <summary>
    /// Each instance is a path-shaped join vertex (position) in the query (one incoming edge, one outgoing edge)
    /// <see href="http://lsq.aksw.org/vocab#Path"></see></summary>
    let Path = Namespaced_IRI.parse _namespace_name "Path" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Regex"></see>
    /// </summary>
    let Regex = Namespaced_IRI.parse _namespace_name "Regex" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// Each instance is a sink join vertex (position) in the query (multiple incoming edges, zero outgoing edges)
    /// <see href="http://lsq.aksw.org/vocab#Sink"></see></summary>
    let Sink = Namespaced_IRI.parse _namespace_name "Sink" |> NamespacedName
    /// <summary>
    /// Each instance is a star-shaped join vertex (position) in the query (zero incoming edges, multiple outgoing edges)
    /// <see href="http://lsq.aksw.org/vocab#Star"></see></summary>
    let Star = Namespaced_IRI.parse _namespace_name "Star" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#SubQuery"></see>
    /// </summary>
    let SubQuery = Namespaced_IRI.parse _namespace_name "SubQuery" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Sum"></see>
    /// </summary>
    let Sum = Namespaced_IRI.parse _namespace_name "Sum" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Union"></see>
    /// </summary>
    let Union = Namespaced_IRI.parse _namespace_name "Union" |> NamespacedName
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Values"></see>
    /// </summary>
    let Values = Namespaced_IRI.parse _namespace_name "Values" |> NamespacedName
    /// <summary>
    /// Links a query execution instance to the agent that initiated the execution
    /// <see href="http://lsq.aksw.org/vocab#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName
    /// <summary>
    /// The number of Basic Graph Patterns in a query
    /// <see href="http://lsq.aksw.org/vocab#bgps"></see></summary>
    let bgps = Namespaced_IRI.parse _namespace_name "bgps" |> NamespacedName
    /// <summary>
    /// Links a query execution instance to the endpoint against which it was run
    /// <see href="http://lsq.aksw.org/vocab#endpoint"></see></summary>
    let endpoint = Namespaced_IRI.parse _namespace_name "endpoint" |> NamespacedName
    /// <summary>
    /// Links a query to an execution of it against a particular endpoint by a particular agent at a particular time
    /// <see href="http://lsq.aksw.org/vocab#execution"></see></summary>
    let execution = Namespaced_IRI.parse _namespace_name "execution" |> NamespacedName

    /// <summary>
    /// The text of an error encountered during a query execution
    /// <see href="http://lsq.aksw.org/vocab#executionError"></see></summary>
    let executionError =
        Namespaced_IRI.parse _namespace_name "executionError" |> NamespacedName

    /// <summary>
    /// Links a query to a join vertex it contains
    /// <see href="http://lsq.aksw.org/vocab#joinVertex"></see></summary>
    let joinVertex = Namespaced_IRI.parse _namespace_name "joinVertex" |> NamespacedName

    /// <summary>
    /// Links a join vertex to the type of vertex it is
    /// <see href="http://lsq.aksw.org/vocab#joinVertexType"></see></summary>
    let joinVertexType =
        Namespaced_IRI.parse _namespace_name "joinVertexType" |> NamespacedName

    /// <summary>
    /// The number of join vertices in a query
    /// <see href="http://lsq.aksw.org/vocab#joinVertices"></see></summary>
    let joinVertices =
        Namespaced_IRI.parse _namespace_name "joinVertices" |> NamespacedName

    /// <summary>
    /// The mean degree across all the join vertices
    /// <see href="http://lsq.aksw.org/vocab#meanJoinVerticesDegree"></see></summary>
    let meanJoinVerticesDegree =
        Namespaced_IRI.parse _namespace_name "meanJoinVerticesDegree" |> NamespacedName

    /// <summary>
    /// The mean selectivity of all triple patterns
    /// <see href="http://lsq.aksw.org/vocab#meanTriplePatternSelectivity"></see></summary>
    let meanTriplePatternSelectivity =
        Namespaced_IRI.parse _namespace_name "meanTriplePatternSelectivity" |> NamespacedName

    /// <summary>
    /// Links a query to a term it mentions in the object of a triple pattern
    /// <see href="http://lsq.aksw.org/vocab#mentionsObject"></see></summary>
    let mentionsObject =
        Namespaced_IRI.parse _namespace_name "mentionsObject" |> NamespacedName

    /// <summary>
    /// Links a query to a term it mentions in the predicate of a triple pattern
    /// <see href="http://lsq.aksw.org/vocab#mentionsPredicate"></see></summary>
    let mentionsPredicate =
        Namespaced_IRI.parse _namespace_name "mentionsPredicate" |> NamespacedName

    /// <summary>
    /// Links a query to a term it mentions in the subject of a triple pattern
    /// <see href="http://lsq.aksw.org/vocab#mentionsSubject"></see></summary>
    let mentionsSubject =
        Namespaced_IRI.parse _namespace_name "mentionsSubject" |> NamespacedName

    /// <summary>
    /// The text of an error encountered when parsing query
    /// <see href="http://lsq.aksw.org/vocab#parseError"></see></summary>
    let parseError = Namespaced_IRI.parse _namespace_name "parseError" |> NamespacedName
    /// <summary>
    /// Number of results returned when executed locally
    /// <see href="http://lsq.aksw.org/vocab#resultSize"></see></summary>
    let resultSize = Namespaced_IRI.parse _namespace_name "resultSize" |> NamespacedName
    /// <summary>
    /// The run time of the query in milliseconds when executed locally
    /// <see href="http://lsq.aksw.org/vocab#runTimeMs"></see></summary>
    let runTimeMs = Namespaced_IRI.parse _namespace_name "runTimeMs" |> NamespacedName

    /// <summary>
    /// The text of an error encountered when running the query locally
    /// <see href="http://lsq.aksw.org/vocab#runtimeError"></see></summary>
    let runtimeError =
        Namespaced_IRI.parse _namespace_name "runtimeError" |> NamespacedName

    /// <summary>
    /// The text of an error encountered when generating the SPIN description
    /// <see href="http://lsq.aksw.org/vocab#spinError"></see></summary>
    let spinError = Namespaced_IRI.parse _namespace_name "spinError" |> NamespacedName

    /// <summary>
    /// The number of triple patterns in a query
    /// <see href="http://lsq.aksw.org/vocab#triplePatterns"></see></summary>
    let triplePatterns =
        Namespaced_IRI.parse _namespace_name "triplePatterns" |> NamespacedName

    /// <summary>
    /// A feature used by the query
    /// <see href="http://lsq.aksw.org/vocab#usesFeature"></see></summary>
    let usesFeature =
        Namespaced_IRI.parse _namespace_name "usesFeature" |> NamespacedName
