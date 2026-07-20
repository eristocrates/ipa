namespace https.www.commoncoreontologies.org.FamilialRelationsOntology.bare

open DoxAletheia

module famrel =
    let _namespace_name =
        "https://www.commoncoreontologies.org/FamilialRelationsOntology"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
