namespace http.www.w3.org._2011.http_methods.hash

open DoxAletheia.Rdf_Vocabulary

module httpm =
    let _namespace_name = "http://www.w3.org/2011/http-methods#"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#CONNECT"></see>
    /// </summary>
    let CONNECT = Namespaced_IRI.parse _namespace_name "CONNECT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#DELETE"></see>
    /// </summary>
    let DELETE = Namespaced_IRI.parse _namespace_name "DELETE" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#GET"></see>
    /// </summary>
    let GET = Namespaced_IRI.parse _namespace_name "GET" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#HEAD"></see>
    /// </summary>
    let HEAD = Namespaced_IRI.parse _namespace_name "HEAD" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#OPTIONS"></see>
    /// </summary>
    let OPTIONS = Namespaced_IRI.parse _namespace_name "OPTIONS" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#PATCH"></see>
    /// </summary>
    let PATCH = Namespaced_IRI.parse _namespace_name "PATCH" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#POST"></see>
    /// </summary>
    let POST = Namespaced_IRI.parse _namespace_name "POST" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#PUT"></see>
    /// </summary>
    let PUT = Namespaced_IRI.parse _namespace_name "PUT" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#TRACE"></see>
    /// </summary>
    let TRACE = Namespaced_IRI.parse _namespace_name "TRACE" |> NamespacedName
