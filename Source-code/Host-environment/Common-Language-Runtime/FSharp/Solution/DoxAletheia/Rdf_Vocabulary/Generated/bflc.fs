namespace http.id.loc.gov.ontologies.bflc.slash

open DoxAletheia

module bflc =
    let _namespace_name = "http://id.loc.gov/ontologies/bflc/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
