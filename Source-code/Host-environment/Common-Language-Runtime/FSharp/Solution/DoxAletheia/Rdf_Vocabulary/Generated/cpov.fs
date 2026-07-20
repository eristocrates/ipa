namespace http.data.europa.eu.m8g.slash

open DoxAletheia

module cpov =
    let _namespace_name = "http://data.europa.eu/m8g/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
