namespace http.persistence.uni_leipzig.org.nlp2rdf.ontologies.rlog.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rlog =
    let _namespace_iri = Namespace_Iri rlog |> NamespaceIRI
    /// <summary>
    ///   <para>rlog:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Attention: the ids here can change, they are just used to define an order over the levels!</para>
    /// labels<para>logLevel</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#priority">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#priority</seealso>
    let priority = Prefixed_Name(rlog, "priority") |> PrefixedName
    /// <summary>
    ///   <para>rlog:Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>look here: http://logging.apache.org/log4j/1.2/apidocs/org/apache/log4j/Level.html </para>
    /// labels<para>Log Level</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Level">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Level</seealso>
    let Level = Prefixed_Name(rlog, "Level") |> PrefixedName
    /// <summary>
    ///   <para>rlog:ERROR</para>
    /// </summary>
    /// <remarks>
    ///   <para>rlog:Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The ERROR level designates error events that might still allow the application to continue running.</para>
    /// labels<para>ERROR</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#ERROR">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#ERROR</seealso>
    let ERROR = Prefixed_Name(rlog, "ERROR") |> PrefixedName
    /// <summary>
    ///   <para>rlog:INFO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rlog:Level</para>
    ///   <para>The INFO level designates informational messages that highlight the progress of the application at coarse-grained level.</para>
    /// labels<para>INFO</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#INFO">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#INFO</seealso>
    let INFO = Prefixed_Name(rlog, "INFO") |> PrefixedName
    /// <summary>
    ///   <para>rlog:WARN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rlog:Level</para>
    ///   <para>The WARN level designates potentially harmful situations.</para>
    /// labels<para>WARN</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#WARN">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#WARN</seealso>
    let WARN = Prefixed_Name(rlog, "WARN") |> PrefixedName
    /// <summary>
    ///   <para>rlog:Entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An entry in a log.</para>
    /// labels<para>Log Entry</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Entry">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Entry</seealso>
    let Entry = Prefixed_Name(rlog, "Entry") |> PrefixedName
    /// <summary>
    ///   <para>rlog:StatusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A status code which can occur in an application. Instances of this class must put the name of the status as rdfs:label and describe it with rdfs:comment.</para>
    /// labels<para>Status Code</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#StatusCode">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#StatusCode</seealso>
    let StatusCode = Prefixed_Name(rlog, "StatusCode") |> PrefixedName
    /// <summary>
    ///   <para>rlog:TRACE</para>
    /// </summary>
    /// <remarks>
    ///   <para>rlog:Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The TRACE Level designates finer-grained informational events than the DEBUG.</para>
    /// labels<para>TRACE</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#TRACE">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#TRACE</seealso>
    let TRACE = Prefixed_Name(rlog, "TRACE") |> PrefixedName
    /// <summary>
    ///   <para>rlog:className</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Outputs the fully qualified class name of the caller issuing the logging request.</para>
    /// labels<para>class name</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#className">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#className</seealso>
    let className = Prefixed_Name(rlog, "className") |> PrefixedName
    /// <summary>
    ///   <para>rlog:codeId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numerical value of the code, e.g. 200, 404 or 42.</para>
    /// labels<para>code id</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#codeId">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#codeId</seealso>
    let codeId = Prefixed_Name(rlog, "codeId") |> PrefixedName
    /// <summary>
    ///   <para>rlog:hasCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a log message to a status code.</para>
    /// labels<para>has code</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#hasCode">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#hasCode</seealso>
    let hasCode = Prefixed_Name(rlog, "hasCode") |> PrefixedName
    /// <summary>
    ///   <para>rlog:mylog1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rlog:Entry</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#mylog1">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#mylog1</seealso>
    let mylog1 = Prefixed_Name(rlog, "mylog1") |> PrefixedName
    /// <summary>
    ///   <para>rlog:FATAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rlog:Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The FATAL level designates very severe error events that will presumably lead the application to abort.</para>
    /// labels<para>FATAL</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#FATAL">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#FATAL</seealso>
    let FATAL = Prefixed_Name(rlog, "FATAL") |> PrefixedName
    /// <summary>
    ///   <para>rlog:OFF</para>
    /// </summary>
    /// <remarks>
    ///   <para>rlog:Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The OFF has the highest possible rank and is intended to turn off logging.</para>
    /// labels<para>OFF</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#OFF">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#OFF</seealso>
    let OFF = Prefixed_Name(rlog, "OFF") |> PrefixedName
    /// <summary>
    ///   <para>rlog:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Logging datetime (or just date)</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#date">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#date</seealso>
    let date = Prefixed_Name(rlog, "date") |> PrefixedName
    /// <summary>
    ///   <para>rlog:message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Logging message</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#message">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#message</seealso>
    let message = Prefixed_Name(rlog, "message") |> PrefixedName
    /// <summary>
    ///   <para>rlog:resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If we mix normal and log output, this can be used to refer to the resource in the RDF the error is connected to. </para>
    /// labels<para>an associated resource</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#resource">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#resource</seealso>
    let resource = Prefixed_Name(rlog, "resource") |> PrefixedName
    /// <summary>
    ///   <para>rlog:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>logLevel</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#level">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#level</seealso>
    let level = Prefixed_Name(rlog, "level") |> PrefixedName
    /// <summary>
    ///   <para>rlog:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This is a helper ontology for NIF 2.0 to be able to log errors and warning messages.</para>
    /// labels<para>RLOG - an RDF Logging Ontology</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#</seealso>
    let _prefix_iri = Prefixed_Name(rlog, "") |> PrefixedName
    /// <summary>
    ///   <para>rlog:ALL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rlog:Level</para>
    ///   <para>The ALL has the lowest possible rank and is intended to turn on all logging.</para>
    /// labels<para>ALL</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#ALL">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#ALL</seealso>
    let ALL = Prefixed_Name(rlog, "ALL") |> PrefixedName
    /// <summary>
    ///   <para>rlog:DEBUG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rlog:Level</para>
    ///   <para>The DEBUG Level designates fine-grained informational events that are most useful to debug an application.</para>
    /// labels<para>DEBUG</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#DEBUG">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#DEBUG</seealso>
    let DEBUG = Prefixed_Name(rlog, "DEBUG") |> PrefixedName
