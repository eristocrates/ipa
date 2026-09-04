#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-id`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/" "fibo-sec-sec-id"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : financial instrument identification scheme^^xsd:string</para>
    ///   <para>skos:definition : formal definition of the structure and application of a particular set of financial instrument identifiers^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/FinancialInstrumentIdentificationScheme">fibo-sec-sec-id:FinancialInstrumentIdentificationScheme</a>
    /// </summary>
    let FinancialInstrumentIdentificationScheme =
        _prefixId.prefix "FinancialInstrumentIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : international securities identification number^^xsd:string</para>
    ///   <para>skos:definition : security identifier that is defined as specified in ISO 6166, Securities and related financial instruments -- International securities identification numbering system (ISIN)^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ISIN^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : ISINs consist of two alphabetic characters, which are the ISO 3166-1 alpha-2 code for the issuing country, nine alpha-numeric characters (the National Securities Identifying Number, or NSIN, which identifies the security, padded as necessary with leading zeros), and one numerical check digit. The ISIN is specified as a class of identifiers because although there is a scheme associated with the structure of an ISIN, there are many country-specific variations issued by national numbering agencies.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/InternationalSecuritiesIdentificationNumber">fibo-sec-sec-id:InternationalSecuritiesIdentificationNumber</a>
    /// </summary>
    let InternationalSecuritiesIdentificationNumber =
        _prefixId.prefix "InternationalSecuritiesIdentificationNumber"

    /// <summary>
    ///   <para>rdfs:label : international securities identification numbering scheme^^xsd:string</para>
    ///   <para>skos:definition : formal definition of the structure and application of a ISINs as defined in ISO 6166^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ISIN scheme^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/InternationalSecuritiesIdentificationNumberingScheme">fibo-sec-sec-id:InternationalSecuritiesIdentificationNumberingScheme</a>
    /// </summary>
    let InternationalSecuritiesIdentificationNumberingScheme =
        _prefixId.prefix "InternationalSecuritiesIdentificationNumberingScheme"

    /// <summary>
    ///   <para>rdfs:label : listed security identifier^^xsd:string</para>
    ///   <para>skos:definition : security identifier issued in the public domain and referred to in listings and other relevant publications^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ListedSecurityIdentifier">fibo-sec-sec-id:ListedSecurityIdentifier</a>
    /// </summary>
    let ListedSecurityIdentifier = _prefixId.prefix "ListedSecurityIdentifier"
    /// <summary>
    ///   <para>rdfs:label : national numbering agency^^xsd:string</para>
    ///   <para>skos:definition : registration authority responsible for issuing and managing National Securities Identifying Numbers for securities in accordance with the ISO 6166 standard in some jurisdiction (typically that of a country)^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : NNA^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalNumberingAgency">fibo-sec-sec-id:NationalNumberingAgency</a>
    /// </summary>
    let NationalNumberingAgency = _prefixId.prefix "NationalNumberingAgency"

    /// <summary>
    ///   <para>rdfs:label : National Securities Identifying Number^^xsd:string</para>
    ///   <para>skos:definition : generic, nine-digit alpha numeric code which identifies a fungible security, assigned by a national numbering agency under the ISO 6166 standard^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : NSIN^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumber">fibo-sec-sec-id:NationalSecuritiesIdentifyingNumber</a>
    /// </summary>
    let NationalSecuritiesIdentifyingNumber =
        _prefixId.prefix "NationalSecuritiesIdentifyingNumber"

    /// <summary>
    ///   <para>rdfs:label : National Securities Identifying Number registry^^xsd:string</para>
    ///   <para>skos:definition : registry used by a national numbering agency to manage the financial instrument identifiers and related information that it registers^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : NSIN registry^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumberRegistry">fibo-sec-sec-id:NationalSecuritiesIdentifyingNumberRegistry</a>
    /// </summary>
    let NationalSecuritiesIdentifyingNumberRegistry =
        _prefixId.prefix "NationalSecuritiesIdentifyingNumberRegistry"

    /// <summary>
    ///   <para>rdfs:label : national numbering agency registry entry^^xsd:string</para>
    ///   <para>skos:definition : entry in a National Securities Identifying Number registry^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumberRegistryEntry">fibo-sec-sec-id:NationalSecuritiesIdentifyingNumberRegistryEntry</a>
    /// </summary>
    let NationalSecuritiesIdentifyingNumberRegistryEntry =
        _prefixId.prefix "NationalSecuritiesIdentifyingNumberRegistryEntry"

    /// <summary>
    ///   <para>rdfs:label : national security identification scheme^^xsd:string</para>
    ///   <para>skos:definition : security identification scheme, defining the format and structure of a National Securities Identifying Number (NSIN), published nationally on behalf of a country^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : generally incorporated into the ISIN scheme as well^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecurityIdentificationScheme">fibo-sec-sec-id:NationalSecurityIdentificationScheme</a>
    /// </summary>
    let NationalSecurityIdentificationScheme =
        _prefixId.prefix "NationalSecurityIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : proprietary security identification scheme^^xsd:string</para>
    ///   <para>skos:definition : security identification scheme published by a commercial entity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Proprietary schemes may be unique to an exchange or data provider, for example.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ProprietarySecurityIdentificationScheme">fibo-sec-sec-id:ProprietarySecurityIdentificationScheme</a>
    /// </summary>
    let ProprietarySecurityIdentificationScheme =
        _prefixId.prefix "ProprietarySecurityIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : proprietary security identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier supplied by a commercial entity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ProprietarySecurityIdentifier">fibo-sec-sec-id:ProprietarySecurityIdentifier</a>
    /// </summary>
    let ProprietarySecurityIdentifier = _prefixId.prefix "ProprietarySecurityIdentifier"
    /// <summary>
    ///   <para>rdfs:label : security identification scheme^^xsd:string</para>
    ///   <para>skos:definition : formal definition of the structure and application of a particular set of securities identifiers^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityIdentificationScheme">fibo-sec-sec-id:SecurityIdentificationScheme</a>
    /// </summary>
    let SecurityIdentificationScheme = _prefixId.prefix "SecurityIdentificationScheme"
    /// <summary>
    ///   <para>rdfs:label : security identifier^^xsd:string</para>
    ///   <para>skos:definition : any publicly available identifier that is used to identify a security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityIdentifier">fibo-sec-sec-id:SecurityIdentifier</a>
    /// </summary>
    let SecurityIdentifier = _prefixId.prefix "SecurityIdentifier"
    /// <summary>
    ///   <para>rdfs:label : security registry^^xsd:string</para>
    ///   <para>skos:definition : registry used to manage security identifiers and related information^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Securities registries may be managed by an exchange, clearing house, custodian, bank, or other financial services provider.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityRegistry">fibo-sec-sec-id:SecurityRegistry</a>
    /// </summary>
    let SecurityRegistry = _prefixId.prefix "SecurityRegistry"
    /// <summary>
    ///   <para>rdfs:label : security registry entry^^xsd:string</para>
    ///   <para>skos:definition : record for a security in a securities registry^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityRegistryEntry">fibo-sec-sec-id:SecurityRegistryEntry</a>
    /// </summary>
    let SecurityRegistryEntry = _prefixId.prefix "SecurityRegistryEntry"
    /// <summary>
    ///   <para>rdfs:label : ticker symbol^^xsd:string</para>
    ///   <para>skos:definition : reassignable identifier of relatively short character string length that is unique within an exchange for a particular financial instrument or listing for that instrument^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Every listed security has at least one unique ticker symbol, facilitating the vast array of trade orders that flow through the financial markets every day. However, in some countries this relationship may be indirect, through the listing, rather than direct, as is the case in the United States. In the US, the relationship between a ticker symbol and the listed security is one-to-one. This is not, however, the case in Singapore, where there may be unique ticker symbols for the same security based on the lot size. Some well-known ticker symbols are commonly used by multiple exchanges for the same instrument, such as 'IBM', though exchanges attempt to coordinate to limit duplication.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Ticker symbols are reusable, assigned to a given instrument by an exchange for some period of time.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/TickerSymbol">fibo-sec-sec-id:TickerSymbol</a>
    /// </summary>
    let TickerSymbol = _prefixId.prefix "TickerSymbol"
