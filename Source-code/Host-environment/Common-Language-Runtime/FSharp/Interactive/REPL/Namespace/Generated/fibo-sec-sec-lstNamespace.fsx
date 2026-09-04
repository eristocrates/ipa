#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-lst`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/" "fibo-sec-sec-lst"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : listed security^^xsd:string</para>
    ///   <para>skos:definition : registered security listed on at least one exchange^^xsd:string</para>
    ///   <para>cmns-av:synonym : exchange-traded security^^xsd:string</para>
    ///   <para>cmns-av:usageNote : One can, as appropriate, multiply classify a share as being a common share and listed share, and, in the case whereby multiple securities are issued in different currencies (i.e., there are multiple listed shares corresponding to a given common share that have different identifiers, including more than one ISIN, CUSIP, share class FIGI), multiply classify the listed share individuals as individuals of the same common share.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListedSecurity">fibo-sec-sec-lst:ListedSecurity</a>
    /// </summary>
    let ListedSecurity = _prefixId.prefix "ListedSecurity"
    /// <summary>
    ///   <para>rdfs:label : listing</para>
    ///   <para>skos:definition : catalog entry for a securities offering managed by an exchange that provides the terms under which that security is made available on that exchange^^xsd:string</para>
    ///   <para>cmns-av:synonym : market listing</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/Listing">fibo-sec-sec-lst:Listing</a>
    /// </summary>
    let Listing = _prefixId.prefix "Listing"
    /// <summary>
    ///   <para>rdfs:label : listing service^^xsd:string</para>
    ///   <para>skos:definition : service provided by an exchange to facilitate securities trading^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/ListingService">fibo-sec-sec-lst:ListingService</a>
    /// </summary>
    let ListingService = _prefixId.prefix "ListingService"
    /// <summary>
    ///   <para>rdfs:label : registered security^^xsd:string</para>
    ///   <para>skos:definition : security that is registered with some registration authority^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/RegisteredSecurity">fibo-sec-sec-lst:RegisteredSecurity</a>
    /// </summary>
    let RegisteredSecurity = _prefixId.prefix "RegisteredSecurity"
    /// <summary>
    ///   <para>rdfs:label : has delisting date^^xsd:string</para>
    ///   <para>skos:definition : specifies the date set by the exchange for delisting a security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasDelistingDate">fibo-sec-sec-lst:hasDelistingDate</a>
    /// </summary>
    let hasDelistingDate = _prefixId.prefix "hasDelistingDate"
    /// <summary>
    ///   <para>rdfs:label : has home exchange^^xsd:string</para>
    ///   <para>skos:definition : indicates the exchange that is considered the primary market for a security; typically, but not always, in the country in which the security was originally issued^^xsd:string</para>
    ///   <para>skos:example : A security may have been originally listed on the Frankfurt exchange, but its current home is the London Stock Exchange, for example.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A primary market is one that issues new securities on an exchange for companies, governments, and other groups to obtain financing through debt-based or equity-based securities.^^xsd:string</para>
    ///   <para>cmns-av:synonym : has primary market^^xsd:stringcmns-av:synonym : has primary trading market^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasHomeExchange">fibo-sec-sec-lst:hasHomeExchange</a>
    /// </summary>
    let hasHomeExchange = _prefixId.prefix "hasHomeExchange"
    /// <summary>
    ///   <para>rdfs:label : has last trading date and time^^xsd:string</para>
    ///   <para>skos:definition : specifies the last date and time that the security was traded on the exchange^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasLastTradingDateTime">fibo-sec-sec-lst:hasLastTradingDateTime</a>
    /// </summary>
    let hasLastTradingDateTime = _prefixId.prefix "hasLastTradingDateTime"
    /// <summary>
    ///   <para>rdfs:label : has listing date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which a security is listed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasListingDate">fibo-sec-sec-lst:hasListingDate</a>
    /// </summary>
    let hasListingDate = _prefixId.prefix "hasListingDate"
    /// <summary>
    ///   <para>rdfs:label : has original place of listing^^xsd:string</para>
    ///   <para>skos:definition : indicates the original exchange that listed the security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasOriginalPlaceOfListing">fibo-sec-sec-lst:hasOriginalPlaceOfListing</a>
    /// </summary>
    let hasOriginalPlaceOfListing = _prefixId.prefix "hasOriginalPlaceOfListing"
    /// <summary>
    ///   <para>rdfs:label : has tick size</para>
    ///   <para>skos:definition : specifies a minimum price movement for the security with respect to an exchange</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/hasTickSize">fibo-sec-sec-lst:hasTickSize</a>
    /// </summary>
    let hasTickSize = _prefixId.prefix "hasTickSize"
    /// <summary>
    ///   <para>rdfs:label : is listed via^^xsd:string</para>
    ///   <para>skos:definition : identifies the service responsible for listing the security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isListedVia">fibo-sec-sec-lst:isListedVia</a>
    /// </summary>
    let isListedVia = _prefixId.prefix "isListedVia"
    /// <summary>
    ///   <para>rdfs:label : is seasoned^^xsd:string</para>
    ///   <para>skos:definition : indicates that the security has been publicly traded long enough to eliminate any short-term volume volatility from its initial public offering^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Short-term volatility may be with respect to price or trading volume.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isSeasoned">fibo-sec-sec-lst:isSeasoned</a>
    /// </summary>
    let isSeasoned = _prefixId.prefix "isSeasoned"
    /// <summary>
    ///   <para>rdfs:label : is traded on^^xsd:string</para>
    ///   <para>skos:definition : identifies the trading facility on which the security is traded^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/isTradedOn">fibo-sec-sec-lst:isTradedOn</a>
    /// </summary>
    let isTradedOn = _prefixId.prefix "isTradedOn"
    /// <summary>
    ///   <para>rdfs:label : lists^^xsd:string</para>
    ///   <para>skos:definition : relates a given exchange-specific security listing to its issue^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/lists">fibo-sec-sec-lst:lists</a>
    /// </summary>
    let lists = _prefixId.prefix "lists"
