namespace http.www.loc.gov.premis.rdf.v1.hash

open DoxAletheia

module premisv1 =
    let _namespace_name = "http://www.loc.gov/premis/rdf/v1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
