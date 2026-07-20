namespace http.opendata.aragon.es.def.ei2a.hash

open DoxAletheia

module ei2a =
    let _namespace_name = "http://opendata.aragon.es/def/ei2a#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
