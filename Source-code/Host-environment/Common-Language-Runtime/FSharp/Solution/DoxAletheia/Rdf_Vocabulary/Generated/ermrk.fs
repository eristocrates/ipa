namespace http.www.essepuntato.it._2008._12.earmark.hash

open DoxAletheia

module ermrk =
    let _namespace_name = "http://www.essepuntato.it/2008/12/earmark#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
