#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rlog =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#" "rlog"

    let _namespaceIri = _prefixId.prefix ""
    let ALL = _prefixId.prefix "ALL"
    let DEBUG = _prefixId.prefix "DEBUG"
    let ERROR = _prefixId.prefix "ERROR"
    /// <summary>
    ///   <para>rdfs:comment : An entry in a log.</para>
    ///   <para>rdfs:label : Log Entry</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Entry">rlog:Entry</a>
    /// </summary>
    let Entry = _prefixId.prefix "Entry"
    let FATAL = _prefixId.prefix "FATAL"
    let INFO = _prefixId.prefix "INFO"
    /// <summary>
    ///   <para>rdfs:comment : look here: http://logging.apache.org/log4j/1.2/apidocs/org/apache/log4j/Level.html </para>
    ///   <para>rdfs:label : Log Level</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Level">rlog:Level</a>
    /// </summary>
    let Level = _prefixId.prefix "Level"
    let OFF = _prefixId.prefix "OFF"
    /// <summary>
    ///   <para>rdfs:comment : A status code which can occur in an application. Instances of this class must put the name of the status as rdfs:label and describe it with rdfs:comment.</para>
    ///   <para>rdfs:label : Status Code</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#StatusCode">rlog:StatusCode</a>
    /// </summary>
    let StatusCode = _prefixId.prefix "StatusCode"
    let TRACE = _prefixId.prefix "TRACE"
    let WARN = _prefixId.prefix "WARN"
    /// <summary>
    ///   <para>rdfs:comment : Outputs the fully qualified class name of the caller issuing the logging request.</para>
    ///   <para>rdfs:label : class name</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#className">rlog:className</a>
    /// </summary>
    let className = _prefixId.prefix "className"
    /// <summary>
    ///   <para>rdfs:comment : The numerical value of the code, e.g. 200, 404 or 42.</para>
    ///   <para>rdfs:label : code id</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#codeId">rlog:codeId</a>
    /// </summary>
    let codeId = _prefixId.prefix "codeId"
    /// <summary>
    ///   <para>rdfs:label : Logging datetime (or just date)</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#date">rlog:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:comment : Links a log message to a status code.</para>
    ///   <para>rdfs:label : has code</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#hasCode">rlog:hasCode</a>
    /// </summary>
    let hasCode = _prefixId.prefix "hasCode"
    /// <summary>
    ///   <para>rdfs:label : logLevel</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#level">rlog:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>rdfs:label : Logging message</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#message">rlog:message</a>
    /// </summary>
    let message = _prefixId.prefix "message"
    let mylog1 = _prefixId.prefix "mylog1"
    /// <summary>
    ///   <para>rdfs:label : logLevel</para>
    ///   <para>rdfs:comment : Attention: the ids here can change, they are just used to define an order over the levels!</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#priority">rlog:priority</a>
    /// </summary>
    let priority = _prefixId.prefix "priority"
    /// <summary>
    ///   <para>rdfs:comment : If we mix normal and log output, this can be used to refer to the resource in the RDF the error is connected to. </para>
    ///   <para>rdfs:label : an associated resource</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#resource">rlog:resource</a>
    /// </summary>
    let resource = _prefixId.prefix "resource"
