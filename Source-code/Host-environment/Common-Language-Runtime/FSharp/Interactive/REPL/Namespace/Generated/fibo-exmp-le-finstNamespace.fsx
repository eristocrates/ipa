#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-exmp-le-finst`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/" "fibo-exmp-le-finst"

    let _namespaceIri = _prefixId.prefix ""
    let ABNAMROBank = _prefixId.prefix "ABNAMROBank"
    let ABNAMROBankNV = _prefixId.prefix "ABNAMROBankNV"

    let ABNAMROBankNVHeadquartersAddress =
        _prefixId.prefix "ABNAMROBankNVHeadquartersAddress"

    let ABNAMROBankNVLegalAddress = _prefixId.prefix "ABNAMROBankNVLegalAddress"

    let ABNAMROBankNVLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "ABNAMROBankNVLegalEntityIdentifierRegistryEntry"

    let ABNAMROSecurities = _prefixId.prefix "ABNAMROSecurities"

    let ABNAMROSecuritiesHeadquartersAddress =
        _prefixId.prefix "ABNAMROSecuritiesHeadquartersAddress"

    let ABNAMROSecuritiesLegalAddress = _prefixId.prefix "ABNAMROSecuritiesLegalAddress"

    let ABNAMROSecuritiesLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "ABNAMROSecuritiesLegalEntityIdentifierRegistryEntry"

    let ABNAMROSecuritiesUSALLC_US_DE = _prefixId.prefix "ABNAMROSecuritiesUSALLC-US-DE"
    let BNPParibasUSAINC_US_DE = _prefixId.prefix "BNPParibasUSAINC-US-DE"
    let BNYMellonNationalAssociation = _prefixId.prefix "BNYMellonNationalAssociation"

    let BNYMellonNationalAssociation_US_DE =
        _prefixId.prefix "BNYMellonNationalAssociation-US-DE"

    let BNYMellonNationalAssociationAddress =
        _prefixId.prefix "BNYMellonNationalAssociationAddress"

    let BNYMellonNationalAssociationBusinessEntityIdentifier_SD =
        _prefixId.prefix "BNYMellonNationalAssociationBusinessEntityIdentifier-SD"

    let BNYMellonNationalAssociationBusinessIdentifierCode =
        _prefixId.prefix "BNYMellonNationalAssociationBusinessIdentifierCode"

    let BNYMellonNationalAssociationBusinessPartyPrefix =
        _prefixId.prefix "BNYMellonNationalAssociationBusinessPartyPrefix"

    let BNYMellonNationalAssociationBusinessPartySuffix =
        _prefixId.prefix "BNYMellonNationalAssociationBusinessPartySuffix"

    let BNYMellonNationalAssociationDateEstablished =
        _prefixId.prefix "BNYMellonNationalAssociationDateEstablished"

    let BNYMellonNationalAssociationDateInsured =
        _prefixId.prefix "BNYMellonNationalAssociationDateInsured"

    let BNYMellonNationalAssociationFDICCertificateNumber =
        _prefixId.prefix "BNYMellonNationalAssociationFDICCertificateNumber"

    let BNYMellonNationalAssociationLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "BNYMellonNationalAssociationLegalEntityIdentifierRegistryEntry"

    let BNYMellonNationalAssociationRSSDIdentifier =
        _prefixId.prefix "BNYMellonNationalAssociationRSSDIdentifier"

    let BNYMellonNationalAssociationRTN =
        _prefixId.prefix "BNYMellonNationalAssociationRTN"

    let BankOfAmericaEurope = _prefixId.prefix "BankOfAmericaEurope"
    let BankOfAmericaEuropeEntity = _prefixId.prefix "BankOfAmericaEuropeEntity"

    let BankOfAmericaEuropeHeadquartersAddress =
        _prefixId.prefix "BankOfAmericaEuropeHeadquartersAddress"

    let BankOfAmericaEuropeLegalAddress =
        _prefixId.prefix "BankOfAmericaEuropeLegalAddress"

    let BankOfAmericaEuropeLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "BankOfAmericaEuropeLegalEntityIdentifierRegistryEntry"

    let BankOfAmericaNationalAssociation =
        _prefixId.prefix "BankOfAmericaNationalAssociation"

    let BankOfAmericaNationalAssociation_US =
        _prefixId.prefix "BankOfAmericaNationalAssociation-US"

    let BankOfAmericaNationalAssociationDateEstablished =
        _prefixId.prefix "BankOfAmericaNationalAssociationDateEstablished"

    let BankOfAmericaNationalAssociationDateInsured =
        _prefixId.prefix "BankOfAmericaNationalAssociationDateInsured"

    let BankOfAmericaNationalAssociationHeadquartersAddress =
        _prefixId.prefix "BankOfAmericaNationalAssociationHeadquartersAddress"

    let BankOfAmericaNationalAssociationLegalAddress =
        _prefixId.prefix "BankOfAmericaNationalAssociationLegalAddress"

    let BankOfAmericaNationalAssociationLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "BankOfAmericaNationalAssociationLegalEntityIdentifierRegistryEntry"

    let BankOfNewYorkMellonCorporation =
        _prefixId.prefix "BankOfNewYorkMellonCorporation"

    let BankOfNewYorkMellonCorporation_US_DE =
        _prefixId.prefix "BankOfNewYorkMellonCorporation-US-DE"

    let BankOfNewYorkMellonCorporationAddress =
        _prefixId.prefix "BankOfNewYorkMellonCorporationAddress"

    let BankOfNewYorkMellonCorporationBusinessEntityIdentifier =
        _prefixId.prefix "BankOfNewYorkMellonCorporationBusinessEntityIdentifier"

    let BankOfNewYorkMellonCorporationIncorporationDate =
        _prefixId.prefix "BankOfNewYorkMellonCorporationIncorporationDate"

    let BankOfNewYorkMellonCorporationLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "BankOfNewYorkMellonCorporationLegalEntityIdentifierRegistryEntry"

    let BankOfNewYorkMellonCorporationRSSDIdentifier =
        _prefixId.prefix "BankOfNewYorkMellonCorporationRSSDIdentifier"

    let BankOfNewYorkMellonDateEstablished =
        _prefixId.prefix "BankOfNewYorkMellonDateEstablished"

    let BarclaysBank = _prefixId.prefix "BarclaysBank"
    let BarclaysBankPlc = _prefixId.prefix "BarclaysBankPlc"

    let BarclaysBankPlcHeadquartersAddress =
        _prefixId.prefix "BarclaysBankPlcHeadquartersAddress"

    let BarclaysBankPlcLegalAddress = _prefixId.prefix "BarclaysBankPlcLegalAddress"

    let BarclaysBankPlcLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "BarclaysBankPlcLegalEntityIdentifierRegistryEntry"

    let CitiCardsSouthDakotaAcceptanceCorp =
        _prefixId.prefix "CitiCardsSouthDakotaAcceptanceCorp"

    let CitiCardsSouthDakotaAcceptanceCorp_US_DE =
        _prefixId.prefix "CitiCardsSouthDakotaAcceptanceCorp-US-DE"

    let CitiCardsSouthDakotaAcceptanceCorpBusinessEntityIdentifier =
        _prefixId.prefix "CitiCardsSouthDakotaAcceptanceCorpBusinessEntityIdentifier"

    let CitiCardsSouthDakotaAcceptanceCorpHeadquartersAddress =
        _prefixId.prefix "CitiCardsSouthDakotaAcceptanceCorpHeadquartersAddress"

    let CitiCardsSouthDakotaAcceptanceCorpIncorporationDate =
        _prefixId.prefix "CitiCardsSouthDakotaAcceptanceCorpIncorporationDate"

    let CitiCardsSouthDakotaAcceptanceCorpOwnership =
        _prefixId.prefix "CitiCardsSouthDakotaAcceptanceCorpOwnership"

    let CitiCardsSouthDakotaAcceptanceCorpRSSDIdentifier =
        _prefixId.prefix "CitiCardsSouthDakotaAcceptanceCorpRSSDIdentifier"

    let CitibankNA = _prefixId.prefix "CitibankNA"
    let CitibankNA_US_DE = _prefixId.prefix "CitibankNA-US-DE"

    let CitibankNABusinessEntityIdentifier =
        _prefixId.prefix "CitibankNABusinessEntityIdentifier"

    let CitibankNADateEstablished = _prefixId.prefix "CitibankNADateEstablished"
    let CitibankNADateInsured = _prefixId.prefix "CitibankNADateInsured"

    let CitibankNAFDICCertificateNumber =
        _prefixId.prefix "CitibankNAFDICCertificateNumber"

    let CitibankNAHeadquartersAddress = _prefixId.prefix "CitibankNAHeadquartersAddress"
    let CitibankNAIncorporationDate = _prefixId.prefix "CitibankNAIncorporationDate"
    let CitibankNALegalAddress = _prefixId.prefix "CitibankNALegalAddress"

    let CitibankNALegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "CitibankNALegalEntityIdentifierRegistryEntry"

    let CitibankNAOwnership = _prefixId.prefix "CitibankNAOwnership"
    let CitibankNARSSDIdentifier = _prefixId.prefix "CitibankNARSSDIdentifier"
    let CitibankNARTN = _prefixId.prefix "CitibankNARTN"
    let CiticorpLLC = _prefixId.prefix "CiticorpLLC"
    let CiticorpLLC_US_DE = _prefixId.prefix "CiticorpLLC-US-DE"

    let CiticorpLLCBusinessEntityIdentifier =
        _prefixId.prefix "CiticorpLLCBusinessEntityIdentifier"

    let CiticorpLLCLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "CiticorpLLCLegalEntityIdentifierRegistryEntry"

    let CiticorpLLCOwnership = _prefixId.prefix "CiticorpLLCOwnership"
    let CiticorpLLCRSSDIdentifier = _prefixId.prefix "CiticorpLLCRSSDIdentifier"
    let CiticorpLLCRegistrationDate = _prefixId.prefix "CiticorpLLCRegistrationDate"
    let CitigroupInc = _prefixId.prefix "CitigroupInc"
    let CitigroupInc_US_DE = _prefixId.prefix "CitigroupInc-US-DE"

    let CitigroupIncBusinessEntityIdentifier =
        _prefixId.prefix "CitigroupIncBusinessEntityIdentifier"

    let CitigroupIncHeadquartersAddress =
        _prefixId.prefix "CitigroupIncHeadquartersAddress"

    let CitigroupIncIncorporationDate = _prefixId.prefix "CitigroupIncIncorporationDate"

    let CitigroupIncLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "CitigroupIncLegalEntityIdentifierRegistryEntry"

    let CitigroupIncRSSDIdentifier = _prefixId.prefix "CitigroupIncRSSDIdentifier"
    let Commerzbank = _prefixId.prefix "Commerzbank"
    let CommerzbankAG = _prefixId.prefix "CommerzbankAG"

    let CommerzbankAGHeadquartersAddress =
        _prefixId.prefix "CommerzbankAGHeadquartersAddress"

    let CommerzbankAGLegalAddress = _prefixId.prefix "CommerzbankAGLegalAddress"

    let CommerzbankAGLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "CommerzbankAGLegalEntityIdentifierRegistryEntry"

    let DeutscheBankAktiengesellschaft_DE =
        _prefixId.prefix "DeutscheBankAktiengesellschaft-DE"

    let FMRLLC = _prefixId.prefix "FMRLLC"
    let FMRLLC_US_DE = _prefixId.prefix "FMRLLC-US-DE"

    let FMRLLCBusinessEntityIdentifier =
        _prefixId.prefix "FMRLLCBusinessEntityIdentifier"

    let FMRLLCDateEstablished = _prefixId.prefix "FMRLLCDateEstablished"
    let FMRLLCHeadquartersAddress = _prefixId.prefix "FMRLLCHeadquartersAddress"

    let FMRLLCLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "FMRLLCLegalEntityIdentifierRegistryEntry"

    let FMRLLCRSSDIdentifier = _prefixId.prefix "FMRLLCRSSDIdentifier"
    let GoldmanSachsAndCoLLC_US_NY = _prefixId.prefix "GoldmanSachsAndCoLLC-US-NY"
    let INGBank = _prefixId.prefix "INGBank"
    let INGBankNV = _prefixId.prefix "INGBankNV"
    let INGBankNVHeadquartersAddress = _prefixId.prefix "INGBankNVHeadquartersAddress"
    let INGBankNVLegalAddress = _prefixId.prefix "INGBankNVLegalAddress"

    let INGBankNVLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "INGBankNVLegalEntityIdentifierRegistryEntry"

    let JPMorganChaseAndCo = _prefixId.prefix "JPMorganChaseAndCo"
    let JPMorganChaseAndCo_US_DE = _prefixId.prefix "JPMorganChaseAndCo-US-DE"

    let JPMorganChaseAndCoBusinessEntityIdentifier =
        _prefixId.prefix "JPMorganChaseAndCoBusinessEntityIdentifier"

    let JPMorganChaseAndCoBusinessIdentifierCode =
        _prefixId.prefix "JPMorganChaseAndCoBusinessIdentifierCode"

    let JPMorganChaseAndCoBusinessPartyPrefix =
        _prefixId.prefix "JPMorganChaseAndCoBusinessPartyPrefix"

    let JPMorganChaseAndCoBusinessPartySuffix =
        _prefixId.prefix "JPMorganChaseAndCoBusinessPartySuffix"

    let JPMorganChaseAndCoHeadquartersAddress =
        _prefixId.prefix "JPMorganChaseAndCoHeadquartersAddress"

    let JPMorganChaseAndCoIncorporationDate =
        _prefixId.prefix "JPMorganChaseAndCoIncorporationDate"

    let JPMorganChaseAndCoLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "JPMorganChaseAndCoLegalEntityIdentifierRegistryEntry"

    let JPMorganChaseAndCoRSSDIdentifier =
        _prefixId.prefix "JPMorganChaseAndCoRSSDIdentifier"

    let JPMorganChaseBankNationalAssociation =
        _prefixId.prefix "JPMorganChaseBankNationalAssociation"

    let JPMorganChaseBankNationalAssociation_US =
        _prefixId.prefix "JPMorganChaseBankNationalAssociation-US"

    let JPMorganChaseBankNationalAssociationAddress =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationAddress"

    let JPMorganChaseBankNationalAssociationBusinessEntityIdentifier =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationBusinessEntityIdentifier"

    let JPMorganChaseBankNationalAssociationBusinessIdentifierCode =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationBusinessIdentifierCode"

    let JPMorganChaseBankNationalAssociationBusinessPartyPrefix =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationBusinessPartyPrefix"

    let JPMorganChaseBankNationalAssociationBusinessPartySuffix =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationBusinessPartySuffix"

    let JPMorganChaseBankNationalAssociationDateEstablished =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationDateEstablished"

    let JPMorganChaseBankNationalAssociationDateInsured =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationDateInsured"

    let JPMorganChaseBankNationalAssociationFDICCertificateNumber =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationFDICCertificateNumber"

    let JPMorganChaseBankNationalAssociationLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationLegalEntityIdentifierRegistryEntry"

    let JPMorganChaseBankNationalAssociationRSSDIdentifier =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationRSSDIdentifier"

    let JPMorganChaseBankNationalAssociationRTN =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationRTN"

    let JPMorganChaseBankNationalAssociationRegistrationDate =
        _prefixId.prefix "JPMorganChaseBankNationalAssociationRegistrationDate"

    let JPMorganSecurities = _prefixId.prefix "JPMorganSecurities"
    let JPMorganSecuritiesPlc = _prefixId.prefix "JPMorganSecuritiesPlc"

    let JPMorganSecuritiesPlcHeadquartersAddress =
        _prefixId.prefix "JPMorganSecuritiesPlcHeadquartersAddress"

    let JPMorganSecuritiesPlcLegalAddress =
        _prefixId.prefix "JPMorganSecuritiesPlcLegalAddress"

    let JPMorganSecuritiesPlcLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "JPMorganSecuritiesPlcLegalEntityIdentifierRegistryEntry"

    let MorganStanleyAndCoInternational =
        _prefixId.prefix "MorganStanleyAndCoInternational"

    let MorganStanleyAndCoInternationalPlc =
        _prefixId.prefix "MorganStanleyAndCoInternationalPlc"

    let MorganStanleyAndCoInternationalPlcHeadquartersAddress =
        _prefixId.prefix "MorganStanleyAndCoInternationalPlcHeadquartersAddress"

    let MorganStanleyAndCoInternationalPlcLegalAddress =
        _prefixId.prefix "MorganStanleyAndCoInternationalPlcLegalAddress"

    let MorganStanleyAndCoInternationalPlcLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "MorganStanleyAndCoInternationalPlcLegalEntityIdentifierRegistryEntry"

    let MorganStanleyAndCoLLC = _prefixId.prefix "MorganStanleyAndCoLLC"
    let MorganStanleyAndCoLLC_US_DE = _prefixId.prefix "MorganStanleyAndCoLLC-US-DE"

    let MorganStanleyAndCoLLCHeadquartersAddress =
        _prefixId.prefix "MorganStanleyAndCoLLCHeadquartersAddress"

    let MorganStanleyAndCoLLCLegalAddress =
        _prefixId.prefix "MorganStanleyAndCoLLCLegalAddress"

    let MorganStanleyAndCoLLCLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "MorganStanleyAndCoLLCLegalEntityIdentifierRegistryEntry"

    let NasdaqOMXGroup = _prefixId.prefix "NasdaqOMXGroup"
    let NatWestMarkets = _prefixId.prefix "NatWestMarkets"
    let NatWestMarketsPlc = _prefixId.prefix "NatWestMarketsPlc"

    let NatWestMarketsPlcHeadquartersAddress =
        _prefixId.prefix "NatWestMarketsPlcHeadquartersAddress"

    let NatWestMarketsPlcLegalAddress = _prefixId.prefix "NatWestMarketsPlcLegalAddress"

    let NatWestMarketsPlcLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "NatWestMarketsPlcLegalEntityIdentifierRegistryEntry"

    let PinnacleBank = _prefixId.prefix "PinnacleBank"
    let PinnacleBank_US_CA = _prefixId.prefix "PinnacleBank-US-CA"

    let PinnacleBankBusinessEntityIdentifier =
        _prefixId.prefix "PinnacleBankBusinessEntityIdentifier"

    let PinnacleBankCaliforniaCertificateOfAuthority =
        _prefixId.prefix "PinnacleBankCaliforniaCertificateOfAuthority"

    let PinnacleBankCaliforniaCertificateOfAuthorityIdentifier =
        _prefixId.prefix "PinnacleBankCaliforniaCertificateOfAuthorityIdentifier"

    let PinnacleBankDateOfRegistration =
        _prefixId.prefix "PinnacleBankDateOfRegistration"

    let PinnacleBankFDICCertificateNumber =
        _prefixId.prefix "PinnacleBankFDICCertificateNumber"

    let PinnacleBankHeadquartersAddress =
        _prefixId.prefix "PinnacleBankHeadquartersAddress"

    let PinnacleBankLegalAddress = _prefixId.prefix "PinnacleBankLegalAddress"
    let PinnacleBankRSSDIdentifier = _prefixId.prefix "PinnacleBankRSSDIdentifier"
    let PinnacleBankRTN = _prefixId.prefix "PinnacleBankRTN"
    let SocieteGenerale = _prefixId.prefix "SocieteGenerale"
    let SocieteGeneraleEntity = _prefixId.prefix "SocieteGeneraleEntity"

    let SocieteGeneraleHeadquartersAddress =
        _prefixId.prefix "SocieteGeneraleHeadquartersAddress"

    let SocieteGeneraleLegalAddress = _prefixId.prefix "SocieteGeneraleLegalAddress"

    let SocieteGeneraleLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "SocieteGeneraleLegalEntityIdentifierRegistryEntry"

    let StandardCharteredBank = _prefixId.prefix "StandardCharteredBank"
    let StandardCharteredBankEntity = _prefixId.prefix "StandardCharteredBankEntity"

    let StandardCharteredBankHeadquartersAddress =
        _prefixId.prefix "StandardCharteredBankHeadquartersAddress"

    let StandardCharteredBankLegalAddress =
        _prefixId.prefix "StandardCharteredBankLegalAddress"

    let StandardCharteredBankLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "StandardCharteredBankLegalEntityIdentifierRegistryEntry"

    let StandardCharteredSecuritiesNorthAmericaLLC_US_DE =
        _prefixId.prefix "StandardCharteredSecuritiesNorthAmericaLLC-US-DE"

    let StateStreetBankAndTrustCompany =
        _prefixId.prefix "StateStreetBankAndTrustCompany"

    let StateStreetBankAndTrustCompany_US_MA =
        _prefixId.prefix "StateStreetBankAndTrustCompany-US-MA"

    let StateStreetBankAndTrustCompanyBusinessEntityIdentifier =
        _prefixId.prefix "StateStreetBankAndTrustCompanyBusinessEntityIdentifier"

    let StateStreetBankAndTrustCompanyBusinessIdentifierCode =
        _prefixId.prefix "StateStreetBankAndTrustCompanyBusinessIdentifierCode"

    let StateStreetBankAndTrustCompanyBusinessPartyPrefix =
        _prefixId.prefix "StateStreetBankAndTrustCompanyBusinessPartyPrefix"

    let StateStreetBankAndTrustCompanyBusinessPartySuffix =
        _prefixId.prefix "StateStreetBankAndTrustCompanyBusinessPartySuffix"

    let StateStreetBankAndTrustCompanyDateEstablished =
        _prefixId.prefix "StateStreetBankAndTrustCompanyDateEstablished"

    let StateStreetBankAndTrustCompanyDateInsured =
        _prefixId.prefix "StateStreetBankAndTrustCompanyDateInsured"

    let StateStreetBankAndTrustCompanyFDICCertificateNumber =
        _prefixId.prefix "StateStreetBankAndTrustCompanyFDICCertificateNumber"

    let StateStreetBankAndTrustCompanyLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "StateStreetBankAndTrustCompanyLegalEntityIdentifierRegistryEntry"

    let StateStreetBankAndTrustCompanyRSSDIdentifier =
        _prefixId.prefix "StateStreetBankAndTrustCompanyRSSDIdentifier"

    let StateStreetBankAndTrustCompanyRTN =
        _prefixId.prefix "StateStreetBankAndTrustCompanyRTN"

    let StateStreetBankAndTrustCompanyRegistrationDate =
        _prefixId.prefix "StateStreetBankAndTrustCompanyRegistrationDate"

    let StateStreetCorporation = _prefixId.prefix "StateStreetCorporation"
    let StateStreetCorporation_US_MA = _prefixId.prefix "StateStreetCorporation-US-MA"

    let StateStreetCorporationBusinessEntityIdentifier =
        _prefixId.prefix "StateStreetCorporationBusinessEntityIdentifier"

    let StateStreetCorporationHeadquartersAddress =
        _prefixId.prefix "StateStreetCorporationHeadquartersAddress"

    let StateStreetCorporationIncorporationDate =
        _prefixId.prefix "StateStreetCorporationIncorporationDate"

    let StateStreetCorporationLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "StateStreetCorporationLegalEntityIdentifierRegistryEntry"

    let StateStreetCorporationRSSDIdentifier =
        _prefixId.prefix "StateStreetCorporationRSSDIdentifier"

    let WFCHoldingsLLC = _prefixId.prefix "WFCHoldingsLLC"
    let WFCHoldingsLLC_US_DE = _prefixId.prefix "WFCHoldingsLLC-US-DE"

    let WFCHoldingsLLCBusinessEntityIdentifier =
        _prefixId.prefix "WFCHoldingsLLCBusinessEntityIdentifier"

    let WFCHoldingsLLCHeadquartersAddress =
        _prefixId.prefix "WFCHoldingsLLCHeadquartersAddress"

    let WFCHoldingsLLCIncorporationDate =
        _prefixId.prefix "WFCHoldingsLLCIncorporationDate"

    let WFCHoldingsLLCLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "WFCHoldingsLLCLegalEntityIdentifierRegistryEntry"

    let WFCHoldingsLLCOwnership = _prefixId.prefix "WFCHoldingsLLCOwnership"
    let WellsFargoAndCompany = _prefixId.prefix "WellsFargoAndCompany"
    let WellsFargoAndCompany_US_DE = _prefixId.prefix "WellsFargoAndCompany-US-DE"

    let WellsFargoAndCompanyBusinessEntityIdentifier =
        _prefixId.prefix "WellsFargoAndCompanyBusinessEntityIdentifier"

    let WellsFargoAndCompanyHeadquartersAddress =
        _prefixId.prefix "WellsFargoAndCompanyHeadquartersAddress"

    let WellsFargoAndCompanyIncorporationDate =
        _prefixId.prefix "WellsFargoAndCompanyIncorporationDate"

    let WellsFargoAndCompanyLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "WellsFargoAndCompanyLegalEntityIdentifierRegistryEntry"

    let WellsFargoAndCompanyRSSDIdentifier =
        _prefixId.prefix "WellsFargoAndCompanyRSSDIdentifier"

    let WellsFargoBankNationalAssociation =
        _prefixId.prefix "WellsFargoBankNationalAssociation"

    let WellsFargoBankNationalAssociation_US =
        _prefixId.prefix "WellsFargoBankNationalAssociation-US"

    let WellsFargoBankNationalAssociationBusinessIdentifierCode =
        _prefixId.prefix "WellsFargoBankNationalAssociationBusinessIdentifierCode"

    let WellsFargoBankNationalAssociationBusinessPartyPrefix =
        _prefixId.prefix "WellsFargoBankNationalAssociationBusinessPartyPrefix"

    let WellsFargoBankNationalAssociationBusinessPartySuffix =
        _prefixId.prefix "WellsFargoBankNationalAssociationBusinessPartySuffix"

    let WellsFargoBankNationalAssociationDateEstablished =
        _prefixId.prefix "WellsFargoBankNationalAssociationDateEstablished"

    let WellsFargoBankNationalAssociationDateInsured =
        _prefixId.prefix "WellsFargoBankNationalAssociationDateInsured"

    let WellsFargoBankNationalAssociationFDICCertificateNumber =
        _prefixId.prefix "WellsFargoBankNationalAssociationFDICCertificateNumber"

    let WellsFargoBankNationalAssociationHeadquartersAddress =
        _prefixId.prefix "WellsFargoBankNationalAssociationHeadquartersAddress"

    let WellsFargoBankNationalAssociationLegalAddress =
        _prefixId.prefix "WellsFargoBankNationalAssociationLegalAddress"

    let WellsFargoBankNationalAssociationLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "WellsFargoBankNationalAssociationLegalEntityIdentifierRegistryEntry"

    let WellsFargoBankNationalAssociationOwnership =
        _prefixId.prefix "WellsFargoBankNationalAssociationOwnership"

    let WellsFargoBankNationalAssociationRSSDIdentifier =
        _prefixId.prefix "WellsFargoBankNationalAssociationRSSDIdentifier"

    let WellsFargoBankNationalAssociationRTN =
        _prefixId.prefix "WellsFargoBankNationalAssociationRTN"
