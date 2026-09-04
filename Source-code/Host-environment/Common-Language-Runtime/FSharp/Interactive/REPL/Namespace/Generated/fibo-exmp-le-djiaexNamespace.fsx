#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-exmp-le-djiaex`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/" "fibo-exmp-le-djiaex"

    let _namespaceIri = _prefixId.prefix ""
    let AppleIncAsControlledParty = _prefixId.prefix "AppleIncAsControlledParty"
    let AppleIncAsEmployer = _prefixId.prefix "AppleIncAsEmployer"

    let EmploymentOfKatherineAdamsAtAppleInc =
        _prefixId.prefix "EmploymentOfKatherineAdamsAtAppleInc"

    let EmploymentOfTimCookAtAppleInc = _prefixId.prefix "EmploymentOfTimCookAtAppleInc"
    let KatherineAdams = _prefixId.prefix "KatherineAdams"
    let KatherineAdamsAsEmployee = _prefixId.prefix "KatherineAdamsAsEmployee"

    let KatherineAdamsAsSeniorVicePresidentOfGovernmentAffairs =
        _prefixId.prefix "KatherineAdamsAsSeniorVicePresidentOfGovernmentAffairs"

    let KatherineAdamsDateOfBirth = _prefixId.prefix "KatherineAdamsDateOfBirth"
    let KatherineAdamsFullLegalName = _prefixId.prefix "KatherineAdamsFullLegalName"
    let TimCook = _prefixId.prefix "TimCook"

    let TimCookAsChiefExecutiveOfficer =
        _prefixId.prefix "TimCookAsChiefExecutiveOfficer"

    let TimCookAsEmployee = _prefixId.prefix "TimCookAsEmployee"
    let TimCookDateOfBirth = _prefixId.prefix "TimCookDateOfBirth"
    let TimCookFullLegalName = _prefixId.prefix "TimCookFullLegalName"
    let TimCookHireDate = _prefixId.prefix "TimCookHireDate"
    let TimCookPeriodOfEmployment = _prefixId.prefix "TimCookPeriodOfEmployment"
    let TimCookRetirementDate = _prefixId.prefix "TimCookRetirementDate"
