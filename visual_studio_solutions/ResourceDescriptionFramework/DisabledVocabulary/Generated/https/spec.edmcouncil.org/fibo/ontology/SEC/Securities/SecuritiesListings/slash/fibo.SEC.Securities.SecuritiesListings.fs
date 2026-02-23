namespace Fibo.SEC.Securities.SecuritiesListings.Namespace
module SecuritiesListings =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/SecuritiesListings.rdf") (Some @"fibo.SEC.Securities.SecuritiesListings") None
    let ListedSecurity = {_prefixID with _localName = "ListedSecurity"}
    let Listing = {_prefixID with _localName = "Listing"}
    let ListingService = {_prefixID with _localName = "ListingService"}
    let RegisteredSecurity = {_prefixID with _localName = "RegisteredSecurity"}
    let hasDelistingDate = {_prefixID with _localName = "hasDelistingDate"}
    let hasHomeExchange = {_prefixID with _localName = "hasHomeExchange"}
    let hasLastTradingDateTime = {_prefixID with _localName = "hasLastTradingDateTime"}
    let hasListingDate = {_prefixID with _localName = "hasListingDate"}
    let hasOriginalPlaceOfListing = {_prefixID with _localName = "hasOriginalPlaceOfListing"}
    let hasTickSize = {_prefixID with _localName = "hasTickSize"}
    let isListedVia = {_prefixID with _localName = "isListedVia"}
    let isSeasoned = {_prefixID with _localName = "isSeasoned"}
    let isTradedOn = {_prefixID with _localName = "isTradedOn"}
    let lists = {_prefixID with _localName = "lists"}