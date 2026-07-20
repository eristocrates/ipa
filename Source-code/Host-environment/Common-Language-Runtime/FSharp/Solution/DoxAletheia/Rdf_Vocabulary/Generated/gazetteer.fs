namespace http.data.ordnancesurvey.co.uk.ontology._50kGazetteer.slash

open DoxAletheia

module gazetteer =
    let _namespace_name = "http://data.ordnancesurvey.co.uk/ontology/50kGazetteer/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
