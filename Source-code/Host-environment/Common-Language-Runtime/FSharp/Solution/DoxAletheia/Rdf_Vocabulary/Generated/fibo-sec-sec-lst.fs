namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesListings.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_lst =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListingService"></see>
    /// </summary>
    let ListingService =
        Namespaced_IRI.parse _namespace_name "ListingService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListedSecurity"></see>
    /// </summary>
    let ListedSecurity =
        Namespaced_IRI.parse _namespace_name "ListedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/RegisteredSecurity"></see>
    /// </summary>
    let RegisteredSecurity =
        Namespaced_IRI.parse _namespace_name "RegisteredSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasHomeExchange"></see>
    /// </summary>
    let hasHomeExchange =
        Namespaced_IRI.parse _namespace_name "hasHomeExchange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasOriginalPlaceOfListing"></see>
    /// </summary>
    let hasOriginalPlaceOfListing =
        Namespaced_IRI.parse _namespace_name "hasOriginalPlaceOfListing" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isListedVia"></see>
    /// </summary>
    let isListedVia =
        Namespaced_IRI.parse _namespace_name "isListedVia" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/Listing"></see>
    /// </summary>
    let Listing = Namespaced_IRI.parse _namespace_name "Listing" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasTickSize"></see>
    /// </summary>
    let hasTickSize =
        Namespaced_IRI.parse _namespace_name "hasTickSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasLastTradingDateTime"></see>
    /// </summary>
    let hasLastTradingDateTime =
        Namespaced_IRI.parse _namespace_name "hasLastTradingDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasDelistingDate"></see>
    /// </summary>
    let hasDelistingDate =
        Namespaced_IRI.parse _namespace_name "hasDelistingDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/lists"></see>
    /// </summary>
    let lists = Namespaced_IRI.parse _namespace_name "lists" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasListingDate"></see>
    /// </summary>
    let hasListingDate =
        Namespaced_IRI.parse _namespace_name "hasListingDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isSeasoned"></see>
    /// </summary>
    let isSeasoned = Namespaced_IRI.parse _namespace_name "isSeasoned" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isTradedOn"></see>
    /// </summary>
    let isTradedOn = Namespaced_IRI.parse _namespace_name "isTradedOn" |> NamespacedName
