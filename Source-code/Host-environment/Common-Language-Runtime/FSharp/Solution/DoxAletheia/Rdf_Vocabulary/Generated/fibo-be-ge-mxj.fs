namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.NorthAmericanJurisdiction.MXGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_ge_mxj =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/FederalGovernmentOfMexico"></see>
    /// </summary>
    let FederalGovernmentOfMexico =
        Namespaced_IRI.parse _namespace_name "FederalGovernmentOfMexico" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/MexicanJurisdiction"></see>
    /// </summary>
    let MexicanJurisdiction =
        Namespaced_IRI.parse _namespace_name "MexicanJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/MexicanEntity"></see>
    /// </summary>
    let MexicanEntity =
        Namespaced_IRI.parse _namespace_name "MexicanEntity" |> NamespacedName
