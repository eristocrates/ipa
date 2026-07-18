namespace https.w3id.org._function.vocabulary.implementation.hash

open DoxAletheia.Rdf_Vocabulary

module fnoi =
    let _namespace_name = "https://w3id.org/function/vocabulary/implementation#"
    /// <summary>
    /// A fno:Implementation, distributed as a JAVA class snippet file
    /// <see href="https://w3id.org/function/vocabulary/implementation#JavaClass"></see></summary>
    let JavaClass = Namespaced_IRI.parse _namespace_name "JavaClass" |> NamespacedName

    /// <summary>
    /// A fno:Implementation, coded in JAVA
    /// <see href="https://w3id.org/function/vocabulary/implementation#JavaImplementation"></see></summary>
    let JavaImplementation =
        Namespaced_IRI.parse _namespace_name "JavaImplementation" |> NamespacedName

    /// <summary>
    /// A fno:Implementation, distributed as a JavaScript snippet
    /// <see href="https://w3id.org/function/vocabulary/implementation#JavaScriptFunction"></see></summary>
    let JavaScriptFunction =
        Namespaced_IRI.parse _namespace_name "JavaScriptFunction" |> NamespacedName

    /// <summary>
    /// A fno:Implementation, coded in JavaScript
    /// <see href="https://w3id.org/function/vocabulary/implementation#JavaScriptImplementation"></see></summary>
    let JavaScriptImplementation =
        Namespaced_IRI.parse _namespace_name "JavaScriptImplementation" |> NamespacedName

    /// <summary>
    /// A fno:Implementation, distributed as a JSON (Hydra) API
    /// <see href="https://w3id.org/function/vocabulary/implementation#JsonApi"></see></summary>
    let JsonApi = Namespaced_IRI.parse _namespace_name "JsonApi" |> NamespacedName
    /// <summary>
    /// A fno:Implementation, distributed as a Web API
    /// <see href="https://w3id.org/function/vocabulary/implementation#WebApi"></see></summary>
    let WebApi = Namespaced_IRI.parse _namespace_name "WebApi" |> NamespacedName
    /// <summary>
    /// A fno:Implementation, distributed as an NPM package
    /// <see href="https://w3id.org/function/vocabulary/implementation#NpmPackage"></see></summary>
    let NpmPackage = Namespaced_IRI.parse _namespace_name "NpmPackage" |> NamespacedName

    /// <summary>
    /// A fno:Implementation, as used in OpenRefine
    /// <see href="https://w3id.org/function/vocabulary/implementation#OpenRefineImplementation"></see></summary>
    let OpenRefineImplementation =
        Namespaced_IRI.parse _namespace_name "OpenRefineImplementation" |> NamespacedName

    /// <summary>
    /// A fno:Implementation, as used in a SPARQL query
    /// <see href="https://w3id.org/function/vocabulary/implementation#SPARQLImplementation"></see></summary>
    let SPARQLImplementation =
        Namespaced_IRI.parse _namespace_name "SPARQLImplementation" |> NamespacedName

    /// <summary>
    /// A fno:Implementation, as used in a SQL query
    /// <see href="https://w3id.org/function/vocabulary/implementation#SQLImplementation"></see></summary>
    let SQLImplementation =
        Namespaced_IRI.parse _namespace_name "SQLImplementation" |> NamespacedName

    /// <summary>
    /// A fno:Implementation, as used in an XPath expression
    /// <see href="https://w3id.org/function/vocabulary/implementation#XPATHImplementation"></see></summary>
    let XPATHImplementation =
        Namespaced_IRI.parse _namespace_name "XPATHImplementation" |> NamespacedName

    /// <summary>
    /// Connects a class name to an implemenation description.
    /// <see href="https://w3id.org/function/vocabulary/implementation#class-name"></see></summary>
    let ``class-name`` =
        Namespaced_IRI.parse _namespace_name "class-name" |> NamespacedName
