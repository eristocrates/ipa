#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lsq =
    let _prefixId = PrefixId.fromNamespaceLabel "http://lsq.aksw.org/vocab#" "lsq"
    let Avg = _prefixId.prefix "Avg"
    let Bind = _prefixId.prefix "Bind"
    let Count = _prefixId.prefix "Count"
    let Distinct = _prefixId.prefix "Distinct"
    /// <summary>
    ///   <para>rdfs:label : Query Execution</para>
    ///   <para>rdfs:comment : Each instance is an execution of a particular query against a particular endpoint at a particular time by a particular agent</para>
    ///   <a href="http://lsq.aksw.org/vocab#Execution">lsq:Execution</a>
    /// </summary>
    let Execution = _prefixId.prefix "Execution"
    let Filter = _prefixId.prefix "Filter"
    let FromNamed = _prefixId.prefix "FromNamed"
    let GroupBy = _prefixId.prefix "GroupBy"
    let Having = _prefixId.prefix "Having"
    /// <summary>
    ///   <para>rdfs:label : Hybrid Join Vertex</para>
    ///   <para>rdfs:comment : Each instance is a hybrid join vertex (position) in the query (at least one incoming edge, at least one outgoing edge, at least three edges)</para>
    ///   <a href="http://lsq.aksw.org/vocab#Hybrid">lsq:Hybrid</a>
    /// </summary>
    let Hybrid = _prefixId.prefix "Hybrid"
    /// <summary>
    ///   <para>rdfs:label : Join Vertex</para>
    ///   <para>rdfs:comment : Each instance is a join vertex (position) in the query</para>
    ///   <a href="http://lsq.aksw.org/vocab#JoinVertex">lsq:JoinVertex</a>
    /// </summary>
    let JoinVertex = _prefixId.prefix "JoinVertex"
    let Limit = _prefixId.prefix "Limit"
    let Max = _prefixId.prefix "Max"
    let Min = _prefixId.prefix "Min"
    let Minus = _prefixId.prefix "Minus"
    let NamedGraph = _prefixId.prefix "NamedGraph"
    let Offset = _prefixId.prefix "Offset"
    let Optional = _prefixId.prefix "Optional"
    let OrderBy = _prefixId.prefix "OrderBy"
    /// <summary>
    ///   <para>rdfs:label : Path Join Vertex</para>
    ///   <para>rdfs:comment : Each instance is a path-shaped join vertex (position) in the query (one incoming edge, one outgoing edge)</para>
    ///   <a href="http://lsq.aksw.org/vocab#Path">lsq:Path</a>
    /// </summary>
    let Path = _prefixId.prefix "Path"
    let Regex = _prefixId.prefix "Regex"
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Sink Join Vertex</para>
    ///   <para>rdfs:comment : Each instance is a sink join vertex (position) in the query (multiple incoming edges, zero outgoing edges)</para>
    ///   <a href="http://lsq.aksw.org/vocab#Sink">lsq:Sink</a>
    /// </summary>
    let Sink = _prefixId.prefix "Sink"
    /// <summary>
    ///   <para>rdfs:label : Star Join Vertex</para>
    ///   <para>rdfs:comment : Each instance is a star-shaped join vertex (position) in the query (zero incoming edges, multiple outgoing edges)</para>
    ///   <a href="http://lsq.aksw.org/vocab#Star">lsq:Star</a>
    /// </summary>
    let Star = _prefixId.prefix "Star"
    let SubQuery = _prefixId.prefix "SubQuery"
    let Sum = _prefixId.prefix "Sum"
    let Union = _prefixId.prefix "Union"
    let Values = _prefixId.prefix "Values"
    /// <summary>
    ///   <para>rdfs:label : run by agent</para>
    ///   <para>rdfs:comment : Links a query execution instance to the agent that initiated the execution</para>
    ///   <a href="http://lsq.aksw.org/vocab#agent">lsq:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>rdfs:label : number of bgps</para>
    ///   <para>rdfs:comment : The number of Basic Graph Patterns in a query</para>
    ///   <a href="http://lsq.aksw.org/vocab#bgps">lsq:bgps</a>
    /// </summary>
    let bgps = _prefixId.prefix "bgps"
    /// <summary>
    ///   <para>rdfs:label : run at endpoint</para>
    ///   <para>rdfs:comment : Links a query execution instance to the endpoint against which it was run</para>
    ///   <a href="http://lsq.aksw.org/vocab#endpoint">lsq:endpoint</a>
    /// </summary>
    let endpoint = _prefixId.prefix "endpoint"
    /// <summary>
    ///   <para>rdfs:label : has execution</para>
    ///   <para>rdfs:comment : Links a query to an execution of it against a particular endpoint by a particular agent at a particular time</para>
    ///   <a href="http://lsq.aksw.org/vocab#execution">lsq:execution</a>
    /// </summary>
    let execution = _prefixId.prefix "execution"
    /// <summary>
    ///   <para>rdfs:label : execution error</para>
    ///   <para>rdfs:comment : The text of an error encountered during a query execution</para>
    ///   <a href="http://lsq.aksw.org/vocab#executionError">lsq:executionError</a>
    /// </summary>
    let executionError = _prefixId.prefix "executionError"
    /// <summary>
    ///   <para>rdfs:label : has join vertex</para>
    ///   <para>rdfs:comment : Links a query to a join vertex it contains</para>
    ///   <a href="http://lsq.aksw.org/vocab#joinVertex">lsq:joinVertex</a>
    /// </summary>
    let joinVertex = _prefixId.prefix "joinVertex"
    /// <summary>
    ///   <para>rdfs:label : is of type</para>
    ///   <para>rdfs:comment : Links a join vertex to the type of vertex it is</para>
    ///   <a href="http://lsq.aksw.org/vocab#joinVertexType">lsq:joinVertexType</a>
    /// </summary>
    let joinVertexType = _prefixId.prefix "joinVertexType"
    /// <summary>
    ///   <para>rdfs:label : number of join vertices</para>
    ///   <para>rdfs:comment : The number of join vertices in a query</para>
    ///   <a href="http://lsq.aksw.org/vocab#joinVertices">lsq:joinVertices</a>
    /// </summary>
    let joinVertices = _prefixId.prefix "joinVertices"
    /// <summary>
    ///   <para>rdfs:label : mean join vertex degree</para>
    ///   <para>rdfs:comment : The mean degree across all the join vertices</para>
    ///   <a href="http://lsq.aksw.org/vocab#meanJoinVerticesDegree">lsq:meanJoinVerticesDegree</a>
    /// </summary>
    let meanJoinVerticesDegree = _prefixId.prefix "meanJoinVerticesDegree"
    /// <summary>
    ///   <para>rdfs:label : mean selectivity of triple patterns</para>
    ///   <para>rdfs:comment : The mean selectivity of all triple patterns</para>
    ///   <a href="http://lsq.aksw.org/vocab#meanTriplePatternSelectivity">lsq:meanTriplePatternSelectivity</a>
    /// </summary>
    let meanTriplePatternSelectivity = _prefixId.prefix "meanTriplePatternSelectivity"
    /// <summary>
    ///   <para>rdfs:label : mentions object</para>
    ///   <para>rdfs:comment : Links a query to a term it mentions in the object of a triple pattern</para>
    ///   <a href="http://lsq.aksw.org/vocab#mentionsObject">lsq:mentionsObject</a>
    /// </summary>
    let mentionsObject = _prefixId.prefix "mentionsObject"
    /// <summary>
    ///   <para>rdfs:label : mentions predicate</para>
    ///   <para>rdfs:comment : Links a query to a term it mentions in the predicate of a triple pattern</para>
    ///   <a href="http://lsq.aksw.org/vocab#mentionsPredicate">lsq:mentionsPredicate</a>
    /// </summary>
    let mentionsPredicate = _prefixId.prefix "mentionsPredicate"
    /// <summary>
    ///   <para>rdfs:label : mentions subject</para>
    ///   <para>rdfs:comment : Links a query to a term it mentions in the subject of a triple pattern</para>
    ///   <a href="http://lsq.aksw.org/vocab#mentionsSubject">lsq:mentionsSubject</a>
    /// </summary>
    let mentionsSubject = _prefixId.prefix "mentionsSubject"
    let namedGraph = _prefixId.prefix "namedGraph"
    /// <summary>
    ///   <para>rdfs:label : parse error</para>
    ///   <para>rdfs:comment : The text of an error encountered when parsing query</para>
    ///   <a href="http://lsq.aksw.org/vocab#parseError">lsq:parseError</a>
    /// </summary>
    let parseError = _prefixId.prefix "parseError"
    /// <summary>
    ///   <para>rdfs:label : result size</para>
    ///   <para>rdfs:comment : Number of results returned when executed locally</para>
    ///   <a href="http://lsq.aksw.org/vocab#resultSize">lsq:resultSize</a>
    /// </summary>
    let resultSize = _prefixId.prefix "resultSize"
    /// <summary>
    ///   <para>rdfs:label : run time in milliseconds</para>
    ///   <para>rdfs:comment : The run time of the query in milliseconds when executed locally</para>
    ///   <a href="http://lsq.aksw.org/vocab#runTimeMs">lsq:runTimeMs</a>
    /// </summary>
    let runTimeMs = _prefixId.prefix "runTimeMs"
    /// <summary>
    ///   <para>rdfs:label : runtime error</para>
    ///   <para>rdfs:comment : The text of an error encountered when running the query locally</para>
    ///   <a href="http://lsq.aksw.org/vocab#runtimeError">lsq:runtimeError</a>
    /// </summary>
    let runtimeError = _prefixId.prefix "runtimeError"
    /// <summary>
    ///   <para>rdfs:label : SPIN error</para>
    ///   <para>rdfs:comment : The text of an error encountered when generating the SPIN description</para>
    ///   <a href="http://lsq.aksw.org/vocab#spinError">lsq:spinError</a>
    /// </summary>
    let spinError = _prefixId.prefix "spinError"
    /// <summary>
    ///   <para>rdfs:label : number of triple patterns</para>
    ///   <para>rdfs:comment : The number of triple patterns in a query</para>
    ///   <a href="http://lsq.aksw.org/vocab#triplePatterns">lsq:triplePatterns</a>
    /// </summary>
    let triplePatterns = _prefixId.prefix "triplePatterns"
    /// <summary>
    ///   <para>rdfs:label : uses feature</para>
    ///   <para>rdfs:comment : A feature used by the query</para>
    ///   <a href="http://lsq.aksw.org/vocab#usesFeature">lsq:usesFeature</a>
    /// </summary>
    let usesFeature = _prefixId.prefix "usesFeature"
