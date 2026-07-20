namespace https.w3id.org._function.vocabulary.implementation.hash

open DoxAletheia

module fnoi =
    let _namespace_name = "https://w3id.org/function/vocabulary/implementation#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A fno:Implementation, distributed as a JAVA class snippet file
    /// <see href="https://w3id.org/function/vocabulary/implementation#JavaClass"></see></summary>
    let JavaClass = _prefix "JavaClass"
    /// <summary>
    /// A fno:Implementation, coded in JAVA
    /// <see href="https://w3id.org/function/vocabulary/implementation#JavaImplementation"></see></summary>
    let JavaImplementation = _prefix "JavaImplementation"
    /// <summary>
    /// A fno:Implementation, distributed as a JavaScript snippet
    /// <see href="https://w3id.org/function/vocabulary/implementation#JavaScriptFunction"></see></summary>
    let JavaScriptFunction = _prefix "JavaScriptFunction"
    /// <summary>
    /// A fno:Implementation, coded in JavaScript
    /// <see href="https://w3id.org/function/vocabulary/implementation#JavaScriptImplementation"></see></summary>
    let JavaScriptImplementation = _prefix "JavaScriptImplementation"
    /// <summary>
    /// A fno:Implementation, distributed as a JSON (Hydra) API
    /// <see href="https://w3id.org/function/vocabulary/implementation#JsonApi"></see></summary>
    let JsonApi = _prefix "JsonApi"
    /// <summary>
    /// A fno:Implementation, distributed as a Web API
    /// <see href="https://w3id.org/function/vocabulary/implementation#WebApi"></see></summary>
    let WebApi = _prefix "WebApi"
    /// <summary>
    /// A fno:Implementation, distributed as an NPM package
    /// <see href="https://w3id.org/function/vocabulary/implementation#NpmPackage"></see></summary>
    let NpmPackage = _prefix "NpmPackage"
    /// <summary>
    /// A fno:Implementation, as used in OpenRefine
    /// <see href="https://w3id.org/function/vocabulary/implementation#OpenRefineImplementation"></see></summary>
    let OpenRefineImplementation = _prefix "OpenRefineImplementation"
    /// <summary>
    /// A fno:Implementation, as used in a SPARQL query
    /// <see href="https://w3id.org/function/vocabulary/implementation#SPARQLImplementation"></see></summary>
    let SPARQLImplementation = _prefix "SPARQLImplementation"
    /// <summary>
    /// A fno:Implementation, as used in a SQL query
    /// <see href="https://w3id.org/function/vocabulary/implementation#SQLImplementation"></see></summary>
    let SQLImplementation = _prefix "SQLImplementation"
    /// <summary>
    /// A fno:Implementation, as used in an XPath expression
    /// <see href="https://w3id.org/function/vocabulary/implementation#XPATHImplementation"></see></summary>
    let XPATHImplementation = _prefix "XPATHImplementation"
    /// <summary>
    /// Connects a class name to an implemenation description.
    /// <see href="https://w3id.org/function/vocabulary/implementation#class-name"></see></summary>
    let ``class-name`` = _prefix "class-name"
