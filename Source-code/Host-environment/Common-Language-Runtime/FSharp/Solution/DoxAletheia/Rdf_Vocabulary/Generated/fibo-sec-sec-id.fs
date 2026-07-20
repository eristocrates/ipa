namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesIdentification.slash

open DoxAletheia

module fibo_sec_sec_id =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/FinancialInstrumentIdentificationScheme"></see>
    /// </summary>
    let FinancialInstrumentIdentificationScheme =
        _prefix "FinancialInstrumentIdentificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/InternationalSecuritiesIdentificationNumber"></see>
    /// </summary>
    let InternationalSecuritiesIdentificationNumber =
        _prefix "InternationalSecuritiesIdentificationNumber"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityIdentifier"></see>
    /// </summary>
    let SecurityIdentifier = _prefix "SecurityIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumber"></see>
    /// </summary>
    let NationalSecuritiesIdentifyingNumber =
        _prefix "NationalSecuritiesIdentifyingNumber"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/InternationalSecuritiesIdentificationNumberingScheme"></see>
    /// </summary>
    let InternationalSecuritiesIdentificationNumberingScheme =
        _prefix "InternationalSecuritiesIdentificationNumberingScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityIdentificationScheme"></see>
    /// </summary>
    let SecurityIdentificationScheme = _prefix "SecurityIdentificationScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ListedSecurityIdentifier"></see>
    /// </summary>
    let ListedSecurityIdentifier = _prefix "ListedSecurityIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityRegistry"></see>
    /// </summary>
    let SecurityRegistry = _prefix "SecurityRegistry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalNumberingAgency"></see>
    /// </summary>
    let NationalNumberingAgency = _prefix "NationalNumberingAgency"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumberRegistry"></see>
    /// </summary>
    let NationalSecuritiesIdentifyingNumberRegistry =
        _prefix "NationalSecuritiesIdentifyingNumberRegistry"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecurityIdentificationScheme"></see>
    /// </summary>
    let NationalSecurityIdentificationScheme =
        _prefix "NationalSecurityIdentificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/NationalSecuritiesIdentifyingNumberRegistryEntry"></see>
    /// </summary>
    let NationalSecuritiesIdentifyingNumberRegistryEntry =
        _prefix "NationalSecuritiesIdentifyingNumberRegistryEntry"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/SecurityRegistryEntry"></see>
    /// </summary>
    let SecurityRegistryEntry = _prefix "SecurityRegistryEntry"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ProprietarySecurityIdentificationScheme"></see>
    /// </summary>
    let ProprietarySecurityIdentificationScheme =
        _prefix "ProprietarySecurityIdentificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/ProprietarySecurityIdentifier"></see>
    /// </summary>
    let ProprietarySecurityIdentifier = _prefix "ProprietarySecurityIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/TickerSymbol"></see>
    /// </summary>
    let TickerSymbol = _prefix "TickerSymbol"
