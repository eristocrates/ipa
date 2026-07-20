namespace http.persistence.uni_leipzig.org.nlp2rdf.ontologies.rlog.hash

open DoxAletheia

module rlog =
    let _namespace_name = "http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The ALL has the lowest possible rank and is intended to turn on all logging.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#ALL"></see></summary>
    let ALL = _prefix "ALL"
    /// <summary>
    /// Attention: the ids here can change, they are just used to define an order over the levels!
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#priority"></see></summary>
    let priority = _prefix "priority"
    /// <summary>
    /// look here: http://logging.apache.org/log4j/1.2/apidocs/org/apache/log4j/Level.html
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Level"></see></summary>
    let Level = _prefix "Level"
    /// <summary>
    /// The DEBUG Level designates fine-grained informational events that are most useful to debug an application.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#DEBUG"></see></summary>
    let DEBUG = _prefix "DEBUG"
    /// <summary>
    /// The ERROR level designates error events that might still allow the application to continue running.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#ERROR"></see></summary>
    let ERROR = _prefix "ERROR"
    /// <summary>
    /// An entry in a log.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Entry"></see></summary>
    let Entry = _prefix "Entry"
    /// <summary>
    /// The FATAL level designates very severe error events that will presumably lead the application to abort.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#FATAL"></see></summary>
    let FATAL = _prefix "FATAL"
    /// <summary>
    /// The INFO level designates informational messages that highlight the progress of the application at coarse-grained level.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#INFO"></see></summary>
    let INFO = _prefix "INFO"
    /// <summary>
    /// The OFF has the highest possible rank and is intended to turn off logging.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#OFF"></see></summary>
    let OFF = _prefix "OFF"
    /// <summary>
    /// A status code which can occur in an application. Instances of this class must put the name of the status as rdfs:label and describe it with rdfs:comment.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#StatusCode"></see></summary>
    let StatusCode = _prefix "StatusCode"
    /// <summary>
    /// The TRACE Level designates finer-grained informational events than the DEBUG.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#TRACE"></see></summary>
    let TRACE = _prefix "TRACE"
    /// <summary>
    /// The WARN level designates potentially harmful situations.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#WARN"></see></summary>
    let WARN = _prefix "WARN"
    /// <summary>
    /// Outputs the fully qualified class name of the caller issuing the logging request.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#className"></see></summary>
    let className = _prefix "className"
    /// <summary>
    /// The numerical value of the code, e.g. 200, 404 or 42.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#codeId"></see></summary>
    let codeId = _prefix "codeId"
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    /// Links a log message to a status code.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#hasCode"></see></summary>
    let hasCode = _prefix "hasCode"
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#level"></see>
    /// </summary>
    let level = _prefix "level"
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#message"></see>
    /// </summary>
    let message = _prefix "message"
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#mylog1"></see>
    /// </summary>
    let mylog1 = _prefix "mylog1"
    /// <summary>
    /// If we mix normal and log output, this can be used to refer to the resource in the RDF the error is connected to.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#resource"></see></summary>
    let resource = _prefix "resource"
