namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.Publishers.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_fct_pub =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/MarketDataProvider"></see>
    /// </summary>
    let MarketDataProvider =
        Namespaced_IRI.parse _namespace_name "MarketDataProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publisher"></see>
    /// </summary>
    let Publisher = Namespaced_IRI.parse _namespace_name "Publisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publication"></see>
    /// </summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/hasPublisher"></see>
    /// </summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/publishes"></see>
    /// </summary>
    let publishes = Namespaced_IRI.parse _namespace_name "publishes" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/isPublishedBy"></see>
    /// </summary>
    let isPublishedBy =
        Namespaced_IRI.parse _namespace_name "isPublishedBy" |> NamespacedName
