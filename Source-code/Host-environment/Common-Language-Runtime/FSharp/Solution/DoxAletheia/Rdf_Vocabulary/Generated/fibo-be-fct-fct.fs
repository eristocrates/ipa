namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.FunctionalEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_fct_fct =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Association"></see>
    /// </summary>
    let Association =
        Namespaced_IRI.parse _namespace_name "Association" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/CooperativeSociety"></see>
    /// </summary>
    let CooperativeSociety =
        Namespaced_IRI.parse _namespace_name "CooperativeSociety" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalBusinessEntity"></see>
    /// </summary>
    let FunctionalBusinessEntity =
        Namespaced_IRI.parse _namespace_name "FunctionalBusinessEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FamilyOffice"></see>
    /// </summary>
    let FamilyOffice =
        Namespaced_IRI.parse _namespace_name "FamilyOffice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/FunctionalEntity"></see>
    /// </summary>
    let FunctionalEntity =
        Namespaced_IRI.parse _namespace_name "FunctionalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Merchant"></see>
    /// </summary>
    let Merchant = Namespaced_IRI.parse _namespace_name "Merchant" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCode"></see>
    /// </summary>
    let MerchantCategoryCode =
        Namespaced_IRI.parse _namespace_name "MerchantCategoryCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantIdentifier"></see>
    /// </summary>
    let MerchantIdentifier =
        Namespaced_IRI.parse _namespace_name "MerchantIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/MerchantCategoryCodeScheme"></see>
    /// </summary>
    let MerchantCategoryCodeScheme =
        Namespaced_IRI.parse _namespace_name "MerchantCategoryCodeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/hasMerchantCategoryDescription"></see>
    /// </summary>
    let hasMerchantCategoryDescription =
        Namespaced_IRI.parse _namespace_name "hasMerchantCategoryDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/Syndicate"></see>
    /// </summary>
    let Syndicate = Namespaced_IRI.parse _namespace_name "Syndicate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/SyndicateMember"></see>
    /// </summary>
    let SyndicateMember =
        Namespaced_IRI.parse _namespace_name "SyndicateMember" |> NamespacedName
