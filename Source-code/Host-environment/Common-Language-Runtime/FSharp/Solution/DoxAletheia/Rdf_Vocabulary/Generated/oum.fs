namespace http.www.ontology_of_units_of_measure.org.resource.om_2.slash

open DoxAletheia

module oum =
    let _namespace_name = "http://www.ontology-of-units-of-measure.org/resource/om-2/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
