namespace https.decision_ontology.googlecode.com.svn.trunk.decision.owl.hash

open DoxAletheia

module decision =
    let _namespace_name =
        "https://decision-ontology.googlecode.com/svn/trunk/decision.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
