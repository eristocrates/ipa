namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.NorthAmericanEntities.CAFinancialServicesEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_cafse =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/CanadianCreditUnion"></see>
    /// </summary>
    let CanadianCreditUnion =
        Namespaced_IRI.parse _namespace_name "CanadianCreditUnion" |> NamespacedName
