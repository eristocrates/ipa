namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.Publishers.slash

open DoxAletheia

module fibo_be_fct_pub =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/MarketDataProvider"></see>
    /// </summary>
    let MarketDataProvider = _prefix "MarketDataProvider"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publisher"></see>
    /// </summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publication"></see>
    /// </summary>
    let Publication = _prefix "Publication"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/hasPublisher"></see>
    /// </summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/publishes"></see>
    /// </summary>
    let publishes = _prefix "publishes"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/isPublishedBy"></see>
    /// </summary>
    let isPublishedBy = _prefix "isPublishedBy"
