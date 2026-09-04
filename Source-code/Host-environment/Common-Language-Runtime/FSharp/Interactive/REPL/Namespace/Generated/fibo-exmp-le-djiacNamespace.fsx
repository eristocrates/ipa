#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-exmp-le-djiac`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/" "fibo-exmp-le-djiac"

    let _namespaceIri = _prefixId.prefix ""
    let AlphabetInc_US_CA = _prefixId.prefix "AlphabetInc-US-CA"

    let AlphabetIncBusinessEntityIdentifier =
        _prefixId.prefix "AlphabetIncBusinessEntityIdentifier"

    let AlphabetIncCorporateAddress = _prefixId.prefix "AlphabetIncCorporateAddress"
    let AlphabetIncIncorporationDate = _prefixId.prefix "AlphabetIncIncorporationDate"
    let AppleInc_US_CA = _prefixId.prefix "AppleInc-US-CA"

    let AppleIncBusinessEntityIdentifier =
        _prefixId.prefix "AppleIncBusinessEntityIdentifier"

    let AppleIncCorporateAddress = _prefixId.prefix "AppleIncCorporateAddress"
    let AppleIncIncorporationDate = _prefixId.prefix "AppleIncIncorporationDate"

    let InternationalBusinessMachinesCorporation_US_NY =
        _prefixId.prefix "InternationalBusinessMachinesCorporation-US-NY"

    let InternationalBusinessMachinesCorporationAddress =
        _prefixId.prefix "InternationalBusinessMachinesCorporationAddress"

    let InternationalBusinessMachinesCorporationBusinessEntityIdentifier =
        _prefixId.prefix "InternationalBusinessMachinesCorporationBusinessEntityIdentifier"

    let InternationalBusinessMachinesCorporationBusinessIdentifierCode =
        _prefixId.prefix "InternationalBusinessMachinesCorporationBusinessIdentifierCode"

    let InternationalBusinessMachinesCorporationBusinessPartyPrefix =
        _prefixId.prefix "InternationalBusinessMachinesCorporationBusinessPartyPrefix"

    let InternationalBusinessMachinesCorporationBusinessPartySuffix =
        _prefixId.prefix "InternationalBusinessMachinesCorporationBusinessPartySuffix"

    let InternationalBusinessMachinesCorporationIncorporationDate =
        _prefixId.prefix "InternationalBusinessMachinesCorporationIncorporationDate"

    let TheCoca_ColaCompany_US_DE = _prefixId.prefix "TheCoca-ColaCompany-US-DE"

    let TheCoca_ColaCompanyBusinessEntityIdentifier =
        _prefixId.prefix "TheCoca-ColaCompanyBusinessEntityIdentifier"

    let TheCoca_ColaCompanyBusinessIdentifierCode =
        _prefixId.prefix "TheCoca-ColaCompanyBusinessIdentifierCode"

    let TheCoca_ColaCompanyBusinessPartyPrefix =
        _prefixId.prefix "TheCoca-ColaCompanyBusinessPartyPrefix"

    let TheCoca_ColaCompanyBusinessPartySuffix =
        _prefixId.prefix "TheCoca-ColaCompanyBusinessPartySuffix"

    let TheCoca_ColaCompanyCorporateAddress =
        _prefixId.prefix "TheCoca-ColaCompanyCorporateAddress"

    let TheCoca_ColaCompanyIncorporationDate =
        _prefixId.prefix "TheCoca-ColaCompanyIncorporationDate"

    let TheHomeDepotBusinessEntityIdentifier =
        _prefixId.prefix "TheHomeDepotBusinessEntityIdentifier"

    let TheHomeDepotInc_US_DE = _prefixId.prefix "TheHomeDepotInc-US-DE"

    let TheHomeDepotIncCorporateAddress =
        _prefixId.prefix "TheHomeDepotIncCorporateAddress"

    let TheHomeDepotIncorporationDate = _prefixId.prefix "TheHomeDepotIncorporationDate"

    let TheProctorAndGambleCompany_US_OH =
        _prefixId.prefix "TheProctorAndGambleCompany-US-OH"

    let TheProctorAndGambleCompanyBusinessEntityIdentifier =
        _prefixId.prefix "TheProctorAndGambleCompanyBusinessEntityIdentifier"

    let TheProctorAndGambleCompanyBusinessIdentifierCode =
        _prefixId.prefix "TheProctorAndGambleCompanyBusinessIdentifierCode"

    let TheProctorAndGambleCompanyBusinessPartyPrefix =
        _prefixId.prefix "TheProctorAndGambleCompanyBusinessPartyPrefix"

    let TheProctorAndGambleCompanyBusinessPartySuffix =
        _prefixId.prefix "TheProctorAndGambleCompanyBusinessPartySuffix"

    let TheProctorAndGambleCompanyCorporateAddress =
        _prefixId.prefix "TheProctorAndGambleCompanyCorporateAddress"

    let TheProctorAndGambleCompanyDateEstablished =
        _prefixId.prefix "TheProctorAndGambleCompanyDateEstablished"

    let TheProctorAndGambleCompanyIncorporationDate =
        _prefixId.prefix "TheProctorAndGambleCompanyIncorporationDate"
