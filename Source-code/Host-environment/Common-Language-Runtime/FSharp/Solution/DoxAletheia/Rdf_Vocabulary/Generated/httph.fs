namespace http.www.w3.org._2011.http_headers.hash

open DoxAletheia

module httph =
    let _namespace_name = "http://www.w3.org/2011/http-headers#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
