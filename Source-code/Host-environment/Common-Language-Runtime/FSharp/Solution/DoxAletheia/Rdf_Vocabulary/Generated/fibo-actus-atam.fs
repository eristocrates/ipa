namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.ACTUSTermApplicabilityMapping.slash

open DoxAletheia

module fibo_actus_atam =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTermApplicabilityMapping/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
