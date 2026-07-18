namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.LegalPersons.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_le_lp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessEntity"></see>
    /// </summary>
    let BusinessEntity =
        Namespaced_IRI.parse _namespace_name "BusinessEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/BusinessLicense"></see>
    /// </summary>
    let BusinessLicense =
        Namespaced_IRI.parse _namespace_name "BusinessLicense" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/CharteredLegalPerson"></see>
    /// </summary>
    let CharteredLegalPerson =
        Namespaced_IRI.parse _namespace_name "CharteredLegalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/LegallyCompetentNaturalPerson"></see>
    /// </summary>
    let LegallyCompetentNaturalPerson =
        Namespaced_IRI.parse _namespace_name "LegallyCompetentNaturalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/NotForProfitObjective"></see>
    /// </summary>
    let NotForProfitObjective =
        Namespaced_IRI.parse _namespace_name "NotForProfitObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ProfitObjective"></see>
    /// </summary>
    let ProfitObjective =
        Namespaced_IRI.parse _namespace_name "ProfitObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PowerOfAttorney"></see>
    /// </summary>
    let PowerOfAttorney =
        Namespaced_IRI.parse _namespace_name "PowerOfAttorney" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/PublicPurpose"></see>
    /// </summary>
    let PublicPurpose =
        Namespaced_IRI.parse _namespace_name "PublicPurpose" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/ReligiousObjective"></see>
    /// </summary>
    let ReligiousObjective =
        Namespaced_IRI.parse _namespace_name "ReligiousObjective" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/SpecialPurposeVehicle"></see>
    /// </summary>
    let SpecialPurposeVehicle =
        Namespaced_IRI.parse _namespace_name "SpecialPurposeVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/hasIntendedLiquidationDate"></see>
    /// </summary>
    let hasIntendedLiquidationDate =
        Namespaced_IRI.parse _namespace_name "hasIntendedLiquidationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/StatutoryBody"></see>
    /// </summary>
    let StatutoryBody =
        Namespaced_IRI.parse _namespace_name "StatutoryBody" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/VariableInterestEntity"></see>
    /// </summary>
    let VariableInterestEntity =
        Namespaced_IRI.parse _namespace_name "VariableInterestEntity" |> NamespacedName
