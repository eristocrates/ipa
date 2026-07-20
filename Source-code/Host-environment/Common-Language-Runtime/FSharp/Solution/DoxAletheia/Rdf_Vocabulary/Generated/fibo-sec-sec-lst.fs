namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesListings.slash

open DoxAletheia

module fibo_sec_sec_lst =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListingService"></see>
    /// </summary>
    let ListingService = _prefix "ListingService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListedSecurity"></see>
    /// </summary>
    let ListedSecurity = _prefix "ListedSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/RegisteredSecurity"></see>
    /// </summary>
    let RegisteredSecurity = _prefix "RegisteredSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasHomeExchange"></see>
    /// </summary>
    let hasHomeExchange = _prefix "hasHomeExchange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasOriginalPlaceOfListing"></see>
    /// </summary>
    let hasOriginalPlaceOfListing = _prefix "hasOriginalPlaceOfListing"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isListedVia"></see>
    /// </summary>
    let isListedVia = _prefix "isListedVia"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/Listing"></see>
    /// </summary>
    let Listing = _prefix "Listing"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasTickSize"></see>
    /// </summary>
    let hasTickSize = _prefix "hasTickSize"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasLastTradingDateTime"></see>
    /// </summary>
    let hasLastTradingDateTime = _prefix "hasLastTradingDateTime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasDelistingDate"></see>
    /// </summary>
    let hasDelistingDate = _prefix "hasDelistingDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/lists"></see>
    /// </summary>
    let lists = _prefix "lists"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasListingDate"></see>
    /// </summary>
    let hasListingDate = _prefix "hasListingDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isSeasoned"></see>
    /// </summary>
    let isSeasoned = _prefix "isSeasoned"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isTradedOn"></see>
    /// </summary>
    let isTradedOn = _prefix "isTradedOn"
