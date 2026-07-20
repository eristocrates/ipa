namespace https.spec.edmcouncil.org.fibo.ontology.AboutFIBOProd.slash

open DoxAletheia

module fibo_prod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/AboutFIBOProd/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
