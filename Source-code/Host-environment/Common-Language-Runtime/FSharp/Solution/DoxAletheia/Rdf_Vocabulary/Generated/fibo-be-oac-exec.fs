namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.Executives.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_oac_exec =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/nominates"></see>
    /// </summary>
    let nominates = Namespaced_IRI.parse _namespace_name "nominates" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMember"></see>
    /// </summary>
    let BoardMember =
        Namespaced_IRI.parse _namespace_name "BoardMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/elects"></see>
    /// </summary>
    let elects = Namespaced_IRI.parse _namespace_name "elects" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ControllingNominee"></see>
    /// </summary>
    let ControllingNominee =
        Namespaced_IRI.parse _namespace_name "ControllingNominee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ArticlesOfIncorporation"></see>
    /// </summary>
    let ArticlesOfIncorporation =
        Namespaced_IRI.parse _namespace_name "ArticlesOfIncorporation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Auditor"></see>
    /// </summary>
    let Auditor = Namespaced_IRI.parse _namespace_name "Auditor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Authorization"></see>
    /// </summary>
    let Authorization =
        Namespaced_IRI.parse _namespace_name "Authorization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedIndividual"></see>
    /// </summary>
    let AuthorizedIndividual =
        Namespaced_IRI.parse _namespace_name "AuthorizedIndividual" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedParty"></see>
    /// </summary>
    let AuthorizedParty =
        Namespaced_IRI.parse _namespace_name "AuthorizedParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizingParty"></see>
    /// </summary>
    let AuthorizingParty =
        Namespaced_IRI.parse _namespace_name "AuthorizingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCapacity"></see>
    /// </summary>
    let BoardCapacity =
        Namespaced_IRI.parse _namespace_name "BoardCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanyLaw"></see>
    /// </summary>
    let CompanyLaw = Namespaced_IRI.parse _namespace_name "CompanyLaw" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Bylaws"></see>
    /// </summary>
    let Bylaws = Namespaced_IRI.parse _namespace_name "Bylaws" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCompositionControl"></see>
    /// </summary>
    let BoardCompositionControl =
        Namespaced_IRI.parse _namespace_name "BoardCompositionControl" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardOfDirectors"></see>
    /// </summary>
    let BoardOfDirectors =
        Namespaced_IRI.parse _namespace_name "BoardOfDirectors" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMembership"></see>
    /// </summary>
    let BoardMembership =
        Namespaced_IRI.parse _namespace_name "BoardMembership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateOfficer"></see>
    /// </summary>
    let CorporateOfficer =
        Namespaced_IRI.parse _namespace_name "CorporateOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefExecutiveOfficer"></see>
    /// </summary>
    let ChiefExecutiveOfficer =
        Namespaced_IRI.parse _namespace_name "ChiefExecutiveOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExecutiveBoardMember"></see>
    /// </summary>
    let ExecutiveBoardMember =
        Namespaced_IRI.parse _namespace_name "ExecutiveBoardMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/PrincipalParty"></see>
    /// </summary>
    let PrincipalParty =
        Namespaced_IRI.parse _namespace_name "PrincipalParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefFinancialOfficer"></see>
    /// </summary>
    let ChiefFinancialOfficer =
        Namespaced_IRI.parse _namespace_name "ChiefFinancialOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanySecretary"></see>
    /// </summary>
    let CompanySecretary =
        Namespaced_IRI.parse _namespace_name "CompanySecretary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateBylaws"></see>
    /// </summary>
    let CorporateBylaws =
        Namespaced_IRI.parse _namespace_name "CorporateBylaws" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Executive"></see>
    /// </summary>
    let Executive = Namespaced_IRI.parse _namespace_name "Executive" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Signatory"></see>
    /// </summary>
    let Signatory = Namespaced_IRI.parse _namespace_name "Signatory" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExternalAuditor"></see>
    /// </summary>
    let ExternalAuditor =
        Namespaced_IRI.parse _namespace_name "ExternalAuditor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/InternalAuditor"></see>
    /// </summary>
    let InternalAuditor =
        Namespaced_IRI.parse _namespace_name "InternalAuditor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/LegallyDelegatedAuthority"></see>
    /// </summary>
    let LegallyDelegatedAuthority =
        Namespaced_IRI.parse _namespace_name "LegallyDelegatedAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/NonExecutiveBoardMember"></see>
    /// </summary>
    let NonExecutiveBoardMember =
        Namespaced_IRI.parse _namespace_name "NonExecutiveBoardMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizes"></see>
    /// </summary>
    let authorizes = Namespaced_IRI.parse _namespace_name "authorizes" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizesThrough"></see>
    /// </summary>
    let authorizesThrough =
        Namespaced_IRI.parse _namespace_name "authorizesThrough" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/delegatesControlTo"></see>
    /// </summary>
    let delegatesControlTo =
        Namespaced_IRI.parse _namespace_name "delegatesControlTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/designatesSignatory"></see>
    /// </summary>
    let designatesSignatory =
        Namespaced_IRI.parse _namespace_name "designatesSignatory" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizedParty"></see>
    /// </summary>
    let hasAuthorizedParty =
        Namespaced_IRI.parse _namespace_name "hasAuthorizedParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizingParty"></see>
    /// </summary>
    let hasAuthorizingParty =
        Namespaced_IRI.parse _namespace_name "hasAuthorizingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasCorporateOfficer"></see>
    /// </summary>
    let hasCorporateOfficer =
        Namespaced_IRI.parse _namespace_name "hasCorporateOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDelegatedControlOf"></see>
    /// </summary>
    let hasDelegatedControlOf =
        Namespaced_IRI.parse _namespace_name "hasDelegatedControlOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDirector"></see>
    /// </summary>
    let hasDirector =
        Namespaced_IRI.parse _namespace_name "hasDirector" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasPrincipalManagingParty"></see>
    /// </summary>
    let hasPrincipalManagingParty =
        Namespaced_IRI.parse _namespace_name "hasPrincipalManagingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isPrincipalPartyOf"></see>
    /// </summary>
    let isPrincipalPartyOf =
        Namespaced_IRI.parse _namespace_name "isPrincipalPartyOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibility"></see>
    /// </summary>
    let hasResponsibility =
        Namespaced_IRI.parse _namespace_name "hasResponsibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibleParty"></see>
    /// </summary>
    let hasResponsibleParty =
        Namespaced_IRI.parse _namespace_name "hasResponsibleParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasSigningAuthorityFor"></see>
    /// </summary>
    let hasSigningAuthorityFor =
        Namespaced_IRI.parse _namespace_name "hasSigningAuthorityFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasVestedInIt"></see>
    /// </summary>
    let hasVestedInIt =
        Namespaced_IRI.parse _namespace_name "hasVestedInIt" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedBy"></see>
    /// </summary>
    let isAuthorizedBy =
        Namespaced_IRI.parse _namespace_name "isAuthorizedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedThrough"></see>
    /// </summary>
    let isAuthorizedThrough =
        Namespaced_IRI.parse _namespace_name "isAuthorizedThrough" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isDirectorOf"></see>
    /// </summary>
    let isDirectorOf =
        Namespaced_IRI.parse _namespace_name "isDirectorOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isOfficerOf"></see>
    /// </summary>
    let isOfficerOf =
        Namespaced_IRI.parse _namespace_name "isOfficerOf" |> NamespacedName
