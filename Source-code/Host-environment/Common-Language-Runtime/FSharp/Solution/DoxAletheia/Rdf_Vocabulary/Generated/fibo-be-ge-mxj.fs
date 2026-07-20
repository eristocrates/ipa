namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.NorthAmericanJurisdiction.MXGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia

module fibo_be_ge_mxj =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/FederalGovernmentOfMexico"></see>
    /// </summary>
    let FederalGovernmentOfMexico = _prefix "FederalGovernmentOfMexico"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/MexicanJurisdiction"></see>
    /// </summary>
    let MexicanJurisdiction = _prefix "MexicanJurisdiction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/MexicanEntity"></see>
    /// </summary>
    let MexicanEntity = _prefix "MexicanEntity"
