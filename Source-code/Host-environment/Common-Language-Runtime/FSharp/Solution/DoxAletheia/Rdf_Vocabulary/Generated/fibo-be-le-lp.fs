namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.LegalPersons.slash

open DoxAletheia

module fibo_be_le_lp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessEntity"></see>
    /// </summary>
    let BusinessEntity = _prefix "BusinessEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessLicense"></see>
    /// </summary>
    let BusinessLicense = _prefix "BusinessLicense"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/CharteredLegalPerson"></see>
    /// </summary>
    let CharteredLegalPerson = _prefix "CharteredLegalPerson"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/LegallyCompetentNaturalPerson"></see>
    /// </summary>
    let LegallyCompetentNaturalPerson = _prefix "LegallyCompetentNaturalPerson"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/NotForProfitObjective"></see>
    /// </summary>
    let NotForProfitObjective = _prefix "NotForProfitObjective"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ProfitObjective"></see>
    /// </summary>
    let ProfitObjective = _prefix "ProfitObjective"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PowerOfAttorney"></see>
    /// </summary>
    let PowerOfAttorney = _prefix "PowerOfAttorney"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PublicPurpose"></see>
    /// </summary>
    let PublicPurpose = _prefix "PublicPurpose"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ReligiousObjective"></see>
    /// </summary>
    let ReligiousObjective = _prefix "ReligiousObjective"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/SpecialPurposeVehicle"></see>
    /// </summary>
    let SpecialPurposeVehicle = _prefix "SpecialPurposeVehicle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/hasIntendedLiquidationDate"></see>
    /// </summary>
    let hasIntendedLiquidationDate = _prefix "hasIntendedLiquidationDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/StatutoryBody"></see>
    /// </summary>
    let StatutoryBody = _prefix "StatutoryBody"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/VariableInterestEntity"></see>
    /// </summary>
    let VariableInterestEntity = _prefix "VariableInterestEntity"
