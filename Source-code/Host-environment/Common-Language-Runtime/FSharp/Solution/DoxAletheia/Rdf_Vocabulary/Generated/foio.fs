namespace https.w3id.org.seas.FeatureOfInterestOntology.slash

open DoxAletheia

module foio =
    let _namespace_name = "https://w3id.org/seas/FeatureOfInterestOntology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
