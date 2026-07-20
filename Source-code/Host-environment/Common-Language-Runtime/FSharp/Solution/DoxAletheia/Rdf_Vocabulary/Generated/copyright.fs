namespace http.rhizomik.net.ontologies.copyrightonto.owl.hash

open DoxAletheia

module copyright =
    let _namespace_name = "http://rhizomik.net/ontologies/copyrightonto.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
