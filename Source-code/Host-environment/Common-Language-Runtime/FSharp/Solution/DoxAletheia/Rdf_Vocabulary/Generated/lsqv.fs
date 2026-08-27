namespace http.lsq.aksw.org.vocab.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lsqv =
    let _namespace_iri = Namespace_Iri lsqv |> NamespaceIRI
    /// <summary>
    ///   <para>lsqr:vocab#Avg</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Avg"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Avg">http://lsq.aksw.org/vocab#Avg</seealso>
    let Avg = Prefixed_Name(lsqv, "Avg") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Bind</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Bind"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Bind">http://lsq.aksw.org/vocab#Bind</seealso>
    let Bind = Prefixed_Name(lsqv, "Bind") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Count</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Count"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Count">http://lsq.aksw.org/vocab#Count</seealso>
    let Count = Prefixed_Name(lsqv, "Count") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Distinct</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Distinct"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Distinct">http://lsq.aksw.org/vocab#Distinct</seealso>
    let Distinct = Prefixed_Name(lsqv, "Distinct") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Execution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each instance is an execution of a particular query against a particular endpoint at a particular time by a particular agent"</para>
    /// labels<para>"Query Execution"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Execution">http://lsq.aksw.org/vocab#Execution</seealso>
    let Execution = Prefixed_Name(lsqv, "Execution") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Filter"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Filter">http://lsq.aksw.org/vocab#Filter</seealso>
    let Filter = Prefixed_Name(lsqv, "Filter") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#FromNamed</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"FromNamed"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#FromNamed">http://lsq.aksw.org/vocab#FromNamed</seealso>
    let FromNamed = Prefixed_Name(lsqv, "FromNamed") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#GroupBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"GroupBy"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#GroupBy">http://lsq.aksw.org/vocab#GroupBy</seealso>
    let GroupBy = Prefixed_Name(lsqv, "GroupBy") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Having</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Having"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Having">http://lsq.aksw.org/vocab#Having</seealso>
    let Having = Prefixed_Name(lsqv, "Having") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Hybrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each instance is a hybrid join vertex (position) in the query (at least one incoming edge, at least one outgoing edge, at least three edges)"</para>
    /// labels<para>"Hybrid Join Vertex"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Hybrid">http://lsq.aksw.org/vocab#Hybrid</seealso>
    let Hybrid = Prefixed_Name(lsqv, "Hybrid") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#JoinVertex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each instance is a join vertex (position) in the query"</para>
    /// labels<para>"Join Vertex"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#JoinVertex">http://lsq.aksw.org/vocab#JoinVertex</seealso>
    let JoinVertex = Prefixed_Name(lsqv, "JoinVertex") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Limit</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Limit"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Limit">http://lsq.aksw.org/vocab#Limit</seealso>
    let Limit = Prefixed_Name(lsqv, "Limit") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Max</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Max"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Max">http://lsq.aksw.org/vocab#Max</seealso>
    let Max = Prefixed_Name(lsqv, "Max") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Min</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Min"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Min">http://lsq.aksw.org/vocab#Min</seealso>
    let Min = Prefixed_Name(lsqv, "Min") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Minus</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Minus"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Minus">http://lsq.aksw.org/vocab#Minus</seealso>
    let Minus = Prefixed_Name(lsqv, "Minus") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#NamedGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"NamedGraph"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#NamedGraph">http://lsq.aksw.org/vocab#NamedGraph</seealso>
    let NamedGraph = Prefixed_Name(lsqv, "NamedGraph") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Offset</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Offset"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Offset">http://lsq.aksw.org/vocab#Offset</seealso>
    let Offset = Prefixed_Name(lsqv, "Offset") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Optional"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Optional">http://lsq.aksw.org/vocab#Optional</seealso>
    let Optional = Prefixed_Name(lsqv, "Optional") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#OrderBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"OrderBy"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#OrderBy">http://lsq.aksw.org/vocab#OrderBy</seealso>
    let OrderBy = Prefixed_Name(lsqv, "OrderBy") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each instance is a path-shaped join vertex (position) in the query (one incoming edge, one outgoing edge)"</para>
    /// labels<para>"Path Join Vertex"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Path">http://lsq.aksw.org/vocab#Path</seealso>
    let Path = Prefixed_Name(lsqv, "Path") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Regex</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Regex"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Regex">http://lsq.aksw.org/vocab#Regex</seealso>
    let Regex = Prefixed_Name(lsqv, "Regex") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Service">http://lsq.aksw.org/vocab#Service</seealso>
    let Service = Prefixed_Name(lsqv, "Service") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Sink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each instance is a sink join vertex (position) in the query (multiple incoming edges, zero outgoing edges)"</para>
    /// labels<para>"Sink Join Vertex"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Sink">http://lsq.aksw.org/vocab#Sink</seealso>
    let Sink = Prefixed_Name(lsqv, "Sink") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Star</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each instance is a star-shaped join vertex (position) in the query (zero incoming edges, multiple outgoing edges)"</para>
    /// labels<para>"Star Join Vertex"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Star">http://lsq.aksw.org/vocab#Star</seealso>
    let Star = Prefixed_Name(lsqv, "Star") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#SubQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"SubQuery"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#SubQuery">http://lsq.aksw.org/vocab#SubQuery</seealso>
    let SubQuery = Prefixed_Name(lsqv, "SubQuery") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Sum"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Sum">http://lsq.aksw.org/vocab#Sum</seealso>
    let Sum = Prefixed_Name(lsqv, "Sum") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Union"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Union">http://lsq.aksw.org/vocab#Union</seealso>
    let Union = Prefixed_Name(lsqv, "Union") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#Values</para>
    /// </summary>
    /// <remarks>
    ///   <para>sd:Feature</para>
    ///
    /// labels<para>"Values"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#Values">http://lsq.aksw.org/vocab#Values</seealso>
    let Values = Prefixed_Name(lsqv, "Values") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a query execution instance to the agent that initiated the execution"</para>
    /// labels<para>"run by agent"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#agent">http://lsq.aksw.org/vocab#agent</seealso>
    let agent = Prefixed_Name(lsqv, "agent") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#bgps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The number of Basic Graph Patterns in a query"</para>
    /// labels<para>"number of bgps"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#bgps">http://lsq.aksw.org/vocab#bgps</seealso>
    let bgps = Prefixed_Name(lsqv, "bgps") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Links a query execution instance to the endpoint against which it was run"</para>
    /// labels<para>"run at endpoint"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#endpoint">http://lsq.aksw.org/vocab#endpoint</seealso>
    let endpoint = Prefixed_Name(lsqv, "endpoint") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#execution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a query to an execution of it against a particular endpoint by a particular agent at a particular time"</para>
    /// labels<para>"has execution"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#execution">http://lsq.aksw.org/vocab#execution</seealso>
    let execution = Prefixed_Name(lsqv, "execution") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#executionError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The text of an error encountered during a query execution"</para>
    /// labels<para>"execution error"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#executionError">http://lsq.aksw.org/vocab#executionError</seealso>
    let executionError = Prefixed_Name(lsqv, "executionError") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#joinVertex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a query to a join vertex it contains"</para>
    /// labels<para>"has join vertex"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#joinVertex">http://lsq.aksw.org/vocab#joinVertex</seealso>
    let joinVertex = Prefixed_Name(lsqv, "joinVertex") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#joinVertexType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a join vertex to the type of vertex it is"</para>
    /// labels<para>"is of type"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#joinVertexType">http://lsq.aksw.org/vocab#joinVertexType</seealso>
    let joinVertexType = Prefixed_Name(lsqv, "joinVertexType") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#joinVertices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of join vertices in a query"</para>
    /// labels<para>"number of join vertices"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#joinVertices">http://lsq.aksw.org/vocab#joinVertices</seealso>
    let joinVertices = Prefixed_Name(lsqv, "joinVertices") |> PrefixedName

    /// <summary>
    ///   <para>lsqr:vocab#meanJoinVerticesDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The mean degree across all the join vertices"</para>
    /// labels<para>"mean join vertex degree"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#meanJoinVerticesDegree">http://lsq.aksw.org/vocab#meanJoinVerticesDegree</seealso>
    let meanJoinVerticesDegree =
        Prefixed_Name(lsqv, "meanJoinVerticesDegree") |> PrefixedName

    /// <summary>
    ///   <para>lsqr:vocab#meanTriplePatternSelectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The mean selectivity of all triple patterns"</para>
    /// labels<para>"mean selectivity of triple patterns"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#meanTriplePatternSelectivity">http://lsq.aksw.org/vocab#meanTriplePatternSelectivity</seealso>
    let meanTriplePatternSelectivity =
        Prefixed_Name(lsqv, "meanTriplePatternSelectivity") |> PrefixedName

    /// <summary>
    ///   <para>lsqr:vocab#mentionsObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a query to a term it mentions in the object of a triple pattern"</para>
    /// labels<para>"mentions object"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#mentionsObject">http://lsq.aksw.org/vocab#mentionsObject</seealso>
    let mentionsObject = Prefixed_Name(lsqv, "mentionsObject") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#mentionsPredicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a query to a term it mentions in the predicate of a triple pattern"</para>
    /// labels<para>"mentions predicate"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#mentionsPredicate">http://lsq.aksw.org/vocab#mentionsPredicate</seealso>
    let mentionsPredicate = Prefixed_Name(lsqv, "mentionsPredicate") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#mentionsSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links a query to a term it mentions in the subject of a triple pattern"</para>
    /// labels<para>"mentions subject"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#mentionsSubject">http://lsq.aksw.org/vocab#mentionsSubject</seealso>
    let mentionsSubject = Prefixed_Name(lsqv, "mentionsSubject") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#namedGraph</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#namedGraph">http://lsq.aksw.org/vocab#namedGraph</seealso>
    let namedGraph = Prefixed_Name(lsqv, "namedGraph") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#parseError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The text of an error encountered when parsing query"</para>
    /// labels<para>"parse error"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#parseError">http://lsq.aksw.org/vocab#parseError</seealso>
    let parseError = Prefixed_Name(lsqv, "parseError") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#resultSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of results returned when executed locally"</para>
    /// labels<para>"result size"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#resultSize">http://lsq.aksw.org/vocab#resultSize</seealso>
    let resultSize = Prefixed_Name(lsqv, "resultSize") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#runTimeMs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The run time of the query in milliseconds when executed locally"</para>
    /// labels<para>"run time in milliseconds"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#runTimeMs">http://lsq.aksw.org/vocab#runTimeMs</seealso>
    let runTimeMs = Prefixed_Name(lsqv, "runTimeMs") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#runtimeError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The text of an error encountered when running the query locally"</para>
    /// labels<para>"runtime error"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#runtimeError">http://lsq.aksw.org/vocab#runtimeError</seealso>
    let runtimeError = Prefixed_Name(lsqv, "runtimeError") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#spinError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The text of an error encountered when generating the SPIN description"</para>
    /// labels<para>"SPIN error"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#spinError">http://lsq.aksw.org/vocab#spinError</seealso>
    let spinError = Prefixed_Name(lsqv, "spinError") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#triplePatterns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The number of triple patterns in a query"</para>
    /// labels<para>"number of triple patterns"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#triplePatterns">http://lsq.aksw.org/vocab#triplePatterns</seealso>
    let triplePatterns = Prefixed_Name(lsqv, "triplePatterns") |> PrefixedName
    /// <summary>
    ///   <para>lsqr:vocab#usesFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A feature used by the query"</para>
    /// labels<para>"uses feature"</para></remarks>
    /// <seealso href="http://lsq.aksw.org/vocab#usesFeature">http://lsq.aksw.org/vocab#usesFeature</seealso>
    let usesFeature = Prefixed_Name(lsqv, "usesFeature") |> PrefixedName
