#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-cra`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/" "fibo-fbc-fct-cra"

    let _namespaceIri = _prefixId.prefix ""
    let BGCPartnersInc_US_DE = _prefixId.prefix "BGCPartnersInc-US-DE"

    let BGCPartnersIncBusinessEntityIdentifier =
        _prefixId.prefix "BGCPartnersIncBusinessEntityIdentifier"

    let BGCPartnersIncDateEstablished = _prefixId.prefix "BGCPartnersIncDateEstablished"

    let BGCPartnersIncHeadquartersAddress =
        _prefixId.prefix "BGCPartnersIncHeadquartersAddress"

    let BSDRBusinessEntityIdentifier = _prefixId.prefix "BSDRBusinessEntityIdentifier"
    let BSDRDateEstablished = _prefixId.prefix "BSDRDateEstablished"
    let BSDRHeadquartersAddress = _prefixId.prefix "BSDRHeadquartersAddress"
    let BSDRLLC_US_DE = _prefixId.prefix "BSDRLLC-US-DE"

    let BloombergBusinessEntityIdentifier =
        _prefixId.prefix "BloombergBusinessEntityIdentifier"

    let BloombergDateEstablished = _prefixId.prefix "BloombergDateEstablished"

    let BloombergFinanceBusinessEntityIdentifier =
        _prefixId.prefix "BloombergFinanceBusinessEntityIdentifier"

    let BloombergFinanceDateEstablished =
        _prefixId.prefix "BloombergFinanceDateEstablished"

    let BloombergFinanceLP = _prefixId.prefix "BloombergFinanceLP"
    let BloombergFinanceLP_US_DE = _prefixId.prefix "BloombergFinanceLP-US-DE"

    let BloombergFinanceLPAsLocalOperatingUnit =
        _prefixId.prefix "BloombergFinanceLPAsLocalOperatingUnit"

    let BloombergFinanceOwnership = _prefixId.prefix "BloombergFinanceOwnership"
    let BloombergHeadquartersAddress = _prefixId.prefix "BloombergHeadquartersAddress"
    let BloombergLP = _prefixId.prefix "BloombergLP"
    let BloombergLP_US_DE = _prefixId.prefix "BloombergLP-US-DE"
    let BusinessEntityData = _prefixId.prefix "BusinessEntityData"
    let BusinessEntityData_NL = _prefixId.prefix "BusinessEntityData-NL"

    let BusinessEntityDataHeadquartersAddress =
        _prefixId.prefix "BusinessEntityDataHeadquartersAddress"

    let BusinessEntityDataLegalAddress =
        _prefixId.prefix "BusinessEntityDataLegalAddress"

    let ChicagoMercantileExchangeBusinessEntityIdentifier =
        _prefixId.prefix "ChicagoMercantileExchangeBusinessEntityIdentifier"

    let ChicagoMercantileExchangeDateEstablished =
        _prefixId.prefix "ChicagoMercantileExchangeDateEstablished"

    let ChicagoMercantileExchangeHeadquartersAddress =
        _prefixId.prefix "ChicagoMercantileExchangeHeadquartersAddress"

    let ChicagoMercantileExchangeInc_US_DE =
        _prefixId.prefix "ChicagoMercantileExchangeInc-US-DE"

    let Clearstream = _prefixId.prefix "Clearstream"

    let ClearstreamBankingHeadquartersAddress =
        _prefixId.prefix "ClearstreamBankingHeadquartersAddress"

    let ClearstreamBankingLegalAddress =
        _prefixId.prefix "ClearstreamBankingLegalAddress"

    let ClearstreamBankingSA = _prefixId.prefix "ClearstreamBankingSA"
    let DTC_US_NY = _prefixId.prefix "DTC-US-NY"
    let DTCC_US_DE = _prefixId.prefix "DTCC-US-DE"

    let DTCCDataRepositoryBusinessEntityIdentifier =
        _prefixId.prefix "DTCCDataRepositoryBusinessEntityIdentifier"

    let DTCCDataRepositoryDateEstablished =
        _prefixId.prefix "DTCCDataRepositoryDateEstablished"

    let DTCCDataRepositoryHeadquartersAddress =
        _prefixId.prefix "DTCCDataRepositoryHeadquartersAddress"

    let DTCCDataRepositoryLLC_US_NY = _prefixId.prefix "DTCCDataRepositoryLLC-US-NY"
    let DTCCDataRepositoryOwnership = _prefixId.prefix "DTCCDataRepositoryOwnership"
    let DTCCHeadquartersAddress = _prefixId.prefix "DTCCHeadquartersAddress"
    let DTCCLegalAddress = _prefixId.prefix "DTCCLegalAddress"

    let DTCHeadquartersAndLegalAddress =
        _prefixId.prefix "DTCHeadquartersAndLegalAddress"

    let DepositoryTrustAndClearingCorporation =
        _prefixId.prefix "DepositoryTrustAndClearingCorporation"

    let DepositoryTrustCompany = _prefixId.prefix "DepositoryTrustCompany"

    let DepositoryTrustCompanyOwnership =
        _prefixId.prefix "DepositoryTrustCompanyOwnership"

    let Euroclear = _prefixId.prefix "Euroclear"
    let EuroclearHeadquartersAddress = _prefixId.prefix "EuroclearHeadquartersAddress"
    let EuroclearLegalAddress = _prefixId.prefix "EuroclearLegalAddress"
    let EuroclearSANV = _prefixId.prefix "EuroclearSANV"
    let GlobalLEIIndex = _prefixId.prefix "GlobalLEIIndex"

    let GlobalMarketsEntityIdentifierRegistry =
        _prefixId.prefix "GlobalMarketsEntityIdentifierRegistry"

    let HerausgebergemeinschaftWertpapier_MitteilungenKepplerLehmann =
        _prefixId.prefix "HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmann"

    let HerausgebergemeinschaftWertpapier_MitteilungenKepplerLehmannGmbHAndCoKG_DE =
        _prefixId.prefix "HerausgebergemeinschaftWertpapier-MitteilungenKepplerLehmannGmbHAndCoKG-DE"

    let ICEBenchmarkAdministration = _prefixId.prefix "ICEBenchmarkAdministration"
    let ICETradeVaultLLC_US_DE = _prefixId.prefix "ICETradeVaultLLC-US-DE"

    let ICETradeVaultLLCBusinessEntityIdentifier =
        _prefixId.prefix "ICETradeVaultLLCBusinessEntityIdentifier"

    let ICETradeVaultLLCDateEstablished =
        _prefixId.prefix "ICETradeVaultLLCDateEstablished"

    let ICETradeVaultLLCHeadquartersAddress =
        _prefixId.prefix "ICETradeVaultLLCHeadquartersAddress"

    let IntercontinentalExchange = _prefixId.prefix "IntercontinentalExchange"

    let IntercontinentalExchangeBusinessEntityIdentifier =
        _prefixId.prefix "IntercontinentalExchangeBusinessEntityIdentifier"

    let IntercontinentalExchangeDateEstablished =
        _prefixId.prefix "IntercontinentalExchangeDateEstablished"

    let IntercontinentalExchangeDateRegistered =
        _prefixId.prefix "IntercontinentalExchangeDateRegistered"

    let IntercontinentalExchangeHeadquartersAddress =
        _prefixId.prefix "IntercontinentalExchangeHeadquartersAddress"

    let IntercontinentalExchangeInc_US_DE =
        _prefixId.prefix "IntercontinentalExchangeInc-US-DE"

    let LondonStockExchange = _prefixId.prefix "LondonStockExchange"

    let LondonStockExchangeAsLocalOperatingUnit =
        _prefixId.prefix "LondonStockExchangeAsLocalOperatingUnit"

    let LondonStockExchangeHeadquartersAddress =
        _prefixId.prefix "LondonStockExchangeHeadquartersAddress"

    let LondonStockExchangeLegalAddress =
        _prefixId.prefix "LondonStockExchangeLegalAddress"

    let LondonStockExchangePlc = _prefixId.prefix "LondonStockExchangePlc"

    let LondonStockExchangeUnaVistaRegistry =
        _prefixId.prefix "LondonStockExchangeUnaVistaRegistry"

    let LuxCSD = _prefixId.prefix "LuxCSD"
    let LuxCSDAsLocalOperatingUnit = _prefixId.prefix "LuxCSDAsLocalOperatingUnit"
    let LuxCSDLEIRegistry = _prefixId.prefix "LuxCSDLEIRegistry"
    let LuxCSDSA = _prefixId.prefix "LuxCSDSA"
    let SIXFinancialInformation = _prefixId.prefix "SIXFinancialInformation"
    let SIXFinancialInformationAG = _prefixId.prefix "SIXFinancialInformationAG"

    let SIXFinancialInformationAsLocalOperatingUnit =
        _prefixId.prefix "SIXFinancialInformationAsLocalOperatingUnit"

    let SIXGroup = _prefixId.prefix "SIXGroup"
    let SIXGroupAG = _prefixId.prefix "SIXGroupAG"
    let SIXGroupAGHeadquartersAddress = _prefixId.prefix "SIXGroupAGHeadquartersAddress"
    let SPGlobal = _prefixId.prefix "SPGlobal"

    let SPGlobalBusinessEntityIdentifier =
        _prefixId.prefix "SPGlobalBusinessEntityIdentifier"

    let SPGlobalDateEstablished = _prefixId.prefix "SPGlobalDateEstablished"
    let SPGlobalHeadquartersAddress = _prefixId.prefix "SPGlobalHeadquartersAddress"
    let SPGlobalInc_US_NY = _prefixId.prefix "SPGlobalInc-US-NY"
    let ThomsonReuters = _prefixId.prefix "ThomsonReuters"
    let ThomsonReutersCorporation = _prefixId.prefix "ThomsonReutersCorporation"
    let ThomsonReutersDateEstablished = _prefixId.prefix "ThomsonReutersDateEstablished"

    let ThomsonReutersHeadquartersAddress_CA =
        _prefixId.prefix "ThomsonReutersHeadquartersAddress-CA"

    let ThomsonReutersHeadquartersAddress_US =
        _prefixId.prefix "ThomsonReutersHeadquartersAddress-US"

    let ThomsonReutersLegalAddress = _prefixId.prefix "ThomsonReutersLegalAddress"
    let UBIsecureOy_FI = _prefixId.prefix "UBIsecureOy-FI"
    let UBIsecureOyDateEstablished = _prefixId.prefix "UBIsecureOyDateEstablished"

    let UBIsecureOyHeadquartersAddress =
        _prefixId.prefix "UBIsecureOyHeadquartersAddress"

    let UbisecureAsLocalOperatingUnit = _prefixId.prefix "UbisecureAsLocalOperatingUnit"

    let WMDatenserviceEntityIdentifierRegistry =
        _prefixId.prefix "WMDatenserviceEntityIdentifierRegistry"

    let WMGruppeHeadquartersAndLegalAddress =
        _prefixId.prefix "WMGruppeHeadquartersAndLegalAddress"
