namespace http.www.w3.org._2011.http_methods.hash

open DoxAletheia

module httpm =
    let _namespace_name = "http://www.w3.org/2011/http-methods#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#CONNECT"></see>
    /// </summary>
    let CONNECT = _prefix "CONNECT"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#DELETE"></see>
    /// </summary>
    let DELETE = _prefix "DELETE"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#GET"></see>
    /// </summary>
    let GET = _prefix "GET"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#HEAD"></see>
    /// </summary>
    let HEAD = _prefix "HEAD"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#OPTIONS"></see>
    /// </summary>
    let OPTIONS = _prefix "OPTIONS"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#PATCH"></see>
    /// </summary>
    let PATCH = _prefix "PATCH"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#POST"></see>
    /// </summary>
    let POST = _prefix "POST"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#PUT"></see>
    /// </summary>
    let PUT = _prefix "PUT"
    /// <summary>
    ///   <see href="http://www.w3.org/2011/http-methods#TRACE"></see>
    /// </summary>
    let TRACE = _prefix "TRACE"
