namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.CorporateBodies.slash

open DoxAletheia

module fibo_be_le_cb =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/BenefitCorporation"></see>
    /// </summary>
    let BenefitCorporation = _prefix "BenefitCorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/NotForProfitCorporation"></see>
    /// </summary>
    let NotForProfitCorporation = _prefix "NotForProfitCorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/BoardAgreement"></see>
    /// </summary>
    let BoardAgreement = _prefix "BoardAgreement"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/CommonInterestDevelopmentCorporation"></see>
    /// </summary>
    let CommonInterestDevelopmentCorporation =
        _prefix "CommonInterestDevelopmentCorporation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/Corporation"></see>
    /// </summary>
    let Corporation = _prefix "Corporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/isConstitutedBy"></see>
    /// </summary>
    let isConstitutedBy = _prefix "isConstitutedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/InstrumentOfIncorporation"></see>
    /// </summary>
    let InstrumentOfIncorporation = _prefix "InstrumentOfIncorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/isIncorporatedIn"></see>
    /// </summary>
    let isIncorporatedIn = _prefix "isIncorporatedIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/ForProfitCorporation"></see>
    /// </summary>
    let ForProfitCorporation = _prefix "ForProfitCorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/IncorporationGuarantee"></see>
    /// </summary>
    let IncorporationGuarantee = _prefix "IncorporationGuarantee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/JointStockCompany"></see>
    /// </summary>
    let JointStockCompany = _prefix "JointStockCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/PrivatelyHeldCompany"></see>
    /// </summary>
    let PrivatelyHeldCompany = _prefix "PrivatelyHeldCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/StockCorporation"></see>
    /// </summary>
    let StockCorporation = _prefix "StockCorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/PubliclyHeldCompany"></see>
    /// </summary>
    let PubliclyHeldCompany = _prefix "PubliclyHeldCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/RegistrationIdentifier"></see>
    /// </summary>
    let RegistrationIdentifier = _prefix "RegistrationIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/RegistrationIdentifierScheme"></see>
    /// </summary>
    let RegistrationIdentifierScheme = _prefix "RegistrationIdentifierScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/ReligiousCorporation"></see>
    /// </summary>
    let ReligiousCorporation = _prefix "ReligiousCorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasDateOfRegistration"></see>
    /// </summary>
    let hasDateOfRegistration = _prefix "hasDateOfRegistration"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasIssuedCapital"></see>
    /// </summary>
    let hasIssuedCapital = _prefix "hasIssuedCapital"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasDateOfIncorporation"></see>
    /// </summary>
    let hasDateOfIncorporation = _prefix "hasDateOfIncorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/hasSharesAuthorized"></see>
    /// </summary>
    let hasSharesAuthorized = _prefix "hasSharesAuthorized"
