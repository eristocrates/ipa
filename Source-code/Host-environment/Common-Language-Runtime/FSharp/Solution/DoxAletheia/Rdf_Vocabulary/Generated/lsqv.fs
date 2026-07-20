namespace http.lsq.aksw.org.vocab.hash

open DoxAletheia

module lsqv =
    let _namespace_name = "http://lsq.aksw.org/vocab#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Avg"></see>
    /// </summary>
    let Avg = _prefix "Avg"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Bind"></see>
    /// </summary>
    let Bind = _prefix "Bind"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Count"></see>
    /// </summary>
    let Count = _prefix "Count"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Distinct"></see>
    /// </summary>
    let Distinct = _prefix "Distinct"
    /// <summary>
    /// Each instance is an execution of a particular query against a particular endpoint at a particular time by a particular agent
    /// <see href="http://lsq.aksw.org/vocab#Execution"></see></summary>
    let Execution = _prefix "Execution"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Filter"></see>
    /// </summary>
    let Filter = _prefix "Filter"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#FromNamed"></see>
    /// </summary>
    let FromNamed = _prefix "FromNamed"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#GroupBy"></see>
    /// </summary>
    let GroupBy = _prefix "GroupBy"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Having"></see>
    /// </summary>
    let Having = _prefix "Having"
    /// <summary>
    /// Each instance is a hybrid join vertex (position) in the query (at least one incoming edge, at least one outgoing edge, at least three edges)
    /// <see href="http://lsq.aksw.org/vocab#Hybrid"></see></summary>
    let Hybrid = _prefix "Hybrid"
    /// <summary>
    /// Each instance is a join vertex (position) in the query
    /// <see href="http://lsq.aksw.org/vocab#JoinVertex"></see></summary>
    let JoinVertex = _prefix "JoinVertex"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Limit"></see>
    /// </summary>
    let Limit = _prefix "Limit"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Max"></see>
    /// </summary>
    let Max = _prefix "Max"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Min"></see>
    /// </summary>
    let Min = _prefix "Min"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Minus"></see>
    /// </summary>
    let Minus = _prefix "Minus"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#NamedGraph"></see>
    /// </summary>
    let NamedGraph = _prefix "NamedGraph"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#namedGraph"></see>
    /// </summary>
    let namedGraph = _prefix "namedGraph"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Offset"></see>
    /// </summary>
    let Offset = _prefix "Offset"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Optional"></see>
    /// </summary>
    let Optional = _prefix "Optional"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#OrderBy"></see>
    /// </summary>
    let OrderBy = _prefix "OrderBy"
    /// <summary>
    /// Each instance is a path-shaped join vertex (position) in the query (one incoming edge, one outgoing edge)
    /// <see href="http://lsq.aksw.org/vocab#Path"></see></summary>
    let Path = _prefix "Path"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Regex"></see>
    /// </summary>
    let Regex = _prefix "Regex"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Service"></see>
    /// </summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Each instance is a sink join vertex (position) in the query (multiple incoming edges, zero outgoing edges)
    /// <see href="http://lsq.aksw.org/vocab#Sink"></see></summary>
    let Sink = _prefix "Sink"
    /// <summary>
    /// Each instance is a star-shaped join vertex (position) in the query (zero incoming edges, multiple outgoing edges)
    /// <see href="http://lsq.aksw.org/vocab#Star"></see></summary>
    let Star = _prefix "Star"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#SubQuery"></see>
    /// </summary>
    let SubQuery = _prefix "SubQuery"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Sum"></see>
    /// </summary>
    let Sum = _prefix "Sum"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Union"></see>
    /// </summary>
    let Union = _prefix "Union"
    /// <summary>
    ///   <see href="http://lsq.aksw.org/vocab#Values"></see>
    /// </summary>
    let Values = _prefix "Values"
    /// <summary>
    /// Links a query execution instance to the agent that initiated the execution
    /// <see href="http://lsq.aksw.org/vocab#agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// The number of Basic Graph Patterns in a query
    /// <see href="http://lsq.aksw.org/vocab#bgps"></see></summary>
    let bgps = _prefix "bgps"
    /// <summary>
    /// Links a query execution instance to the endpoint against which it was run
    /// <see href="http://lsq.aksw.org/vocab#endpoint"></see></summary>
    let endpoint = _prefix "endpoint"
    /// <summary>
    /// Links a query to an execution of it against a particular endpoint by a particular agent at a particular time
    /// <see href="http://lsq.aksw.org/vocab#execution"></see></summary>
    let execution = _prefix "execution"
    /// <summary>
    /// The text of an error encountered during a query execution
    /// <see href="http://lsq.aksw.org/vocab#executionError"></see></summary>
    let executionError = _prefix "executionError"
    /// <summary>
    /// Links a query to a join vertex it contains
    /// <see href="http://lsq.aksw.org/vocab#joinVertex"></see></summary>
    let joinVertex = _prefix "joinVertex"
    /// <summary>
    /// Links a join vertex to the type of vertex it is
    /// <see href="http://lsq.aksw.org/vocab#joinVertexType"></see></summary>
    let joinVertexType = _prefix "joinVertexType"
    /// <summary>
    /// The number of join vertices in a query
    /// <see href="http://lsq.aksw.org/vocab#joinVertices"></see></summary>
    let joinVertices = _prefix "joinVertices"
    /// <summary>
    /// The mean degree across all the join vertices
    /// <see href="http://lsq.aksw.org/vocab#meanJoinVerticesDegree"></see></summary>
    let meanJoinVerticesDegree = _prefix "meanJoinVerticesDegree"
    /// <summary>
    /// The mean selectivity of all triple patterns
    /// <see href="http://lsq.aksw.org/vocab#meanTriplePatternSelectivity"></see></summary>
    let meanTriplePatternSelectivity = _prefix "meanTriplePatternSelectivity"
    /// <summary>
    /// Links a query to a term it mentions in the object of a triple pattern
    /// <see href="http://lsq.aksw.org/vocab#mentionsObject"></see></summary>
    let mentionsObject = _prefix "mentionsObject"
    /// <summary>
    /// Links a query to a term it mentions in the predicate of a triple pattern
    /// <see href="http://lsq.aksw.org/vocab#mentionsPredicate"></see></summary>
    let mentionsPredicate = _prefix "mentionsPredicate"
    /// <summary>
    /// Links a query to a term it mentions in the subject of a triple pattern
    /// <see href="http://lsq.aksw.org/vocab#mentionsSubject"></see></summary>
    let mentionsSubject = _prefix "mentionsSubject"
    /// <summary>
    /// The text of an error encountered when parsing query
    /// <see href="http://lsq.aksw.org/vocab#parseError"></see></summary>
    let parseError = _prefix "parseError"
    /// <summary>
    /// Number of results returned when executed locally
    /// <see href="http://lsq.aksw.org/vocab#resultSize"></see></summary>
    let resultSize = _prefix "resultSize"
    /// <summary>
    /// The run time of the query in milliseconds when executed locally
    /// <see href="http://lsq.aksw.org/vocab#runTimeMs"></see></summary>
    let runTimeMs = _prefix "runTimeMs"
    /// <summary>
    /// The text of an error encountered when running the query locally
    /// <see href="http://lsq.aksw.org/vocab#runtimeError"></see></summary>
    let runtimeError = _prefix "runtimeError"
    /// <summary>
    /// The text of an error encountered when generating the SPIN description
    /// <see href="http://lsq.aksw.org/vocab#spinError"></see></summary>
    let spinError = _prefix "spinError"
    /// <summary>
    /// The number of triple patterns in a query
    /// <see href="http://lsq.aksw.org/vocab#triplePatterns"></see></summary>
    let triplePatterns = _prefix "triplePatterns"
    /// <summary>
    /// A feature used by the query
    /// <see href="http://lsq.aksw.org/vocab#usesFeature"></see></summary>
    let usesFeature = _prefix "usesFeature"
