namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.FunctionalEntities.slash

open DoxAletheia

module fibo_be_fct_fct =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Association"></see>
    /// </summary>
    let Association = _prefix "Association"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/CooperativeSociety"></see>
    /// </summary>
    let CooperativeSociety = _prefix "CooperativeSociety"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalBusinessEntity"></see>
    /// </summary>
    let FunctionalBusinessEntity = _prefix "FunctionalBusinessEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FamilyOffice"></see>
    /// </summary>
    let FamilyOffice = _prefix "FamilyOffice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalEntity"></see>
    /// </summary>
    let FunctionalEntity = _prefix "FunctionalEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Merchant"></see>
    /// </summary>
    let Merchant = _prefix "Merchant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCode"></see>
    /// </summary>
    let MerchantCategoryCode = _prefix "MerchantCategoryCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantIdentifier"></see>
    /// </summary>
    let MerchantIdentifier = _prefix "MerchantIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCodeScheme"></see>
    /// </summary>
    let MerchantCategoryCodeScheme = _prefix "MerchantCategoryCodeScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/hasMerchantCategoryDescription"></see>
    /// </summary>
    let hasMerchantCategoryDescription = _prefix "hasMerchantCategoryDescription"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Syndicate"></see>
    /// </summary>
    let Syndicate = _prefix "Syndicate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/SyndicateMember"></see>
    /// </summary>
    let SyndicateMember = _prefix "SyndicateMember"
