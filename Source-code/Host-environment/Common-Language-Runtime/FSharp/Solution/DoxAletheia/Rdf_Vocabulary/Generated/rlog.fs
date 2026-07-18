namespace http.persistence.uni_leipzig.org.nlp2rdf.ontologies.rlog.hash

open DoxAletheia.Rdf_Vocabulary

module rlog =
    let _namespace_name = "http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#"
    /// <summary>
    /// The ALL has the lowest possible rank and is intended to turn on all logging.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#ALL"></see></summary>
    let ALL = Namespaced_IRI.parse _namespace_name "ALL" |> NamespacedName
    /// <summary>
    /// Attention: the ids here can change, they are just used to define an order over the levels!
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#priority"></see></summary>
    let priority = Namespaced_IRI.parse _namespace_name "priority" |> NamespacedName
    /// <summary>
    /// look here: http://logging.apache.org/log4j/1.2/apidocs/org/apache/log4j/Level.html
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Level"></see></summary>
    let Level = Namespaced_IRI.parse _namespace_name "Level" |> NamespacedName
    /// <summary>
    /// The DEBUG Level designates fine-grained informational events that are most useful to debug an application.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#DEBUG"></see></summary>
    let DEBUG = Namespaced_IRI.parse _namespace_name "DEBUG" |> NamespacedName
    /// <summary>
    /// The ERROR level designates error events that might still allow the application to continue running.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#ERROR"></see></summary>
    let ERROR = Namespaced_IRI.parse _namespace_name "ERROR" |> NamespacedName
    /// <summary>
    /// An entry in a log.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#Entry"></see></summary>
    let Entry = Namespaced_IRI.parse _namespace_name "Entry" |> NamespacedName
    /// <summary>
    /// The FATAL level designates very severe error events that will presumably lead the application to abort.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#FATAL"></see></summary>
    let FATAL = Namespaced_IRI.parse _namespace_name "FATAL" |> NamespacedName
    /// <summary>
    /// The INFO level designates informational messages that highlight the progress of the application at coarse-grained level.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#INFO"></see></summary>
    let INFO = Namespaced_IRI.parse _namespace_name "INFO" |> NamespacedName
    /// <summary>
    /// The OFF has the highest possible rank and is intended to turn off logging.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#OFF"></see></summary>
    let OFF = Namespaced_IRI.parse _namespace_name "OFF" |> NamespacedName
    /// <summary>
    /// A status code which can occur in an application. Instances of this class must put the name of the status as rdfs:label and describe it with rdfs:comment.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#StatusCode"></see></summary>
    let StatusCode = Namespaced_IRI.parse _namespace_name "StatusCode" |> NamespacedName
    /// <summary>
    /// The TRACE Level designates finer-grained informational events than the DEBUG.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#TRACE"></see></summary>
    let TRACE = Namespaced_IRI.parse _namespace_name "TRACE" |> NamespacedName
    /// <summary>
    /// The WARN level designates potentially harmful situations.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#WARN"></see></summary>
    let WARN = Namespaced_IRI.parse _namespace_name "WARN" |> NamespacedName
    /// <summary>
    /// Outputs the fully qualified class name of the caller issuing the logging request.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#className"></see></summary>
    let className = Namespaced_IRI.parse _namespace_name "className" |> NamespacedName
    /// <summary>
    /// The numerical value of the code, e.g. 200, 404 or 42.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#codeId"></see></summary>
    let codeId = Namespaced_IRI.parse _namespace_name "codeId" |> NamespacedName
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// Links a log message to a status code.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#hasCode"></see></summary>
    let hasCode = Namespaced_IRI.parse _namespace_name "hasCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#level"></see>
    /// </summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#message"></see>
    /// </summary>
    let message = Namespaced_IRI.parse _namespace_name "message" |> NamespacedName
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#mylog1"></see>
    /// </summary>
    let mylog1 = Namespaced_IRI.parse _namespace_name "mylog1" |> NamespacedName
    /// <summary>
    /// If we mix normal and log output, this can be used to refer to the resource in the RDF the error is connected to.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#resource"></see></summary>
    let resource = Namespaced_IRI.parse _namespace_name "resource" |> NamespacedName
