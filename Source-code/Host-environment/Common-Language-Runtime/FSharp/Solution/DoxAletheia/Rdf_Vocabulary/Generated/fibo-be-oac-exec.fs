namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.Executives.slash

open DoxAletheia

module fibo_be_oac_exec =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/nominates"></see>
    /// </summary>
    let nominates = _prefix "nominates"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMember"></see>
    /// </summary>
    let BoardMember = _prefix "BoardMember"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/elects"></see>
    /// </summary>
    let elects = _prefix "elects"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ControllingNominee"></see>
    /// </summary>
    let ControllingNominee = _prefix "ControllingNominee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ArticlesOfIncorporation"></see>
    /// </summary>
    let ArticlesOfIncorporation = _prefix "ArticlesOfIncorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Auditor"></see>
    /// </summary>
    let Auditor = _prefix "Auditor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Authorization"></see>
    /// </summary>
    let Authorization = _prefix "Authorization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedIndividual"></see>
    /// </summary>
    let AuthorizedIndividual = _prefix "AuthorizedIndividual"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedParty"></see>
    /// </summary>
    let AuthorizedParty = _prefix "AuthorizedParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizingParty"></see>
    /// </summary>
    let AuthorizingParty = _prefix "AuthorizingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCapacity"></see>
    /// </summary>
    let BoardCapacity = _prefix "BoardCapacity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanyLaw"></see>
    /// </summary>
    let CompanyLaw = _prefix "CompanyLaw"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Bylaws"></see>
    /// </summary>
    let Bylaws = _prefix "Bylaws"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCompositionControl"></see>
    /// </summary>
    let BoardCompositionControl = _prefix "BoardCompositionControl"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardOfDirectors"></see>
    /// </summary>
    let BoardOfDirectors = _prefix "BoardOfDirectors"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMembership"></see>
    /// </summary>
    let BoardMembership = _prefix "BoardMembership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateOfficer"></see>
    /// </summary>
    let CorporateOfficer = _prefix "CorporateOfficer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefExecutiveOfficer"></see>
    /// </summary>
    let ChiefExecutiveOfficer = _prefix "ChiefExecutiveOfficer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExecutiveBoardMember"></see>
    /// </summary>
    let ExecutiveBoardMember = _prefix "ExecutiveBoardMember"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/PrincipalParty"></see>
    /// </summary>
    let PrincipalParty = _prefix "PrincipalParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefFinancialOfficer"></see>
    /// </summary>
    let ChiefFinancialOfficer = _prefix "ChiefFinancialOfficer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanySecretary"></see>
    /// </summary>
    let CompanySecretary = _prefix "CompanySecretary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateBylaws"></see>
    /// </summary>
    let CorporateBylaws = _prefix "CorporateBylaws"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Executive"></see>
    /// </summary>
    let Executive = _prefix "Executive"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Signatory"></see>
    /// </summary>
    let Signatory = _prefix "Signatory"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExternalAuditor"></see>
    /// </summary>
    let ExternalAuditor = _prefix "ExternalAuditor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/InternalAuditor"></see>
    /// </summary>
    let InternalAuditor = _prefix "InternalAuditor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/LegallyDelegatedAuthority"></see>
    /// </summary>
    let LegallyDelegatedAuthority = _prefix "LegallyDelegatedAuthority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/NonExecutiveBoardMember"></see>
    /// </summary>
    let NonExecutiveBoardMember = _prefix "NonExecutiveBoardMember"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizes"></see>
    /// </summary>
    let authorizes = _prefix "authorizes"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizesThrough"></see>
    /// </summary>
    let authorizesThrough = _prefix "authorizesThrough"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/delegatesControlTo"></see>
    /// </summary>
    let delegatesControlTo = _prefix "delegatesControlTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/designatesSignatory"></see>
    /// </summary>
    let designatesSignatory = _prefix "designatesSignatory"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizedParty"></see>
    /// </summary>
    let hasAuthorizedParty = _prefix "hasAuthorizedParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizingParty"></see>
    /// </summary>
    let hasAuthorizingParty = _prefix "hasAuthorizingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasCorporateOfficer"></see>
    /// </summary>
    let hasCorporateOfficer = _prefix "hasCorporateOfficer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDelegatedControlOf"></see>
    /// </summary>
    let hasDelegatedControlOf = _prefix "hasDelegatedControlOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDirector"></see>
    /// </summary>
    let hasDirector = _prefix "hasDirector"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasPrincipalManagingParty"></see>
    /// </summary>
    let hasPrincipalManagingParty = _prefix "hasPrincipalManagingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isPrincipalPartyOf"></see>
    /// </summary>
    let isPrincipalPartyOf = _prefix "isPrincipalPartyOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibility"></see>
    /// </summary>
    let hasResponsibility = _prefix "hasResponsibility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibleParty"></see>
    /// </summary>
    let hasResponsibleParty = _prefix "hasResponsibleParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasSigningAuthorityFor"></see>
    /// </summary>
    let hasSigningAuthorityFor = _prefix "hasSigningAuthorityFor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasVestedInIt"></see>
    /// </summary>
    let hasVestedInIt = _prefix "hasVestedInIt"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedBy"></see>
    /// </summary>
    let isAuthorizedBy = _prefix "isAuthorizedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedThrough"></see>
    /// </summary>
    let isAuthorizedThrough = _prefix "isAuthorizedThrough"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isDirectorOf"></see>
    /// </summary>
    let isDirectorOf = _prefix "isDirectorOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isOfficerOf"></see>
    /// </summary>
    let isOfficerOf = _prefix "isOfficerOf"
