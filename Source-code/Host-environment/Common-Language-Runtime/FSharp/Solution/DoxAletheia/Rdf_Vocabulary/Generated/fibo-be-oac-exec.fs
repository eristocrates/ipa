namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.Executives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_oac_exec =
    let _namespace_iri = Namespace_Iri fibo_be_oac_exec |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-oac-exec:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Executives Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_oac_exec, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:ArticlesOfIncorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"articles of incorporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ArticlesOfIncorporation">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ArticlesOfIncorporation</seealso>
    let ArticlesOfIncorporation =
        Prefixed_Name(fibo_be_oac_exec, "ArticlesOfIncorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:Auditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"auditor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Auditor">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Auditor</seealso>
    let Auditor = Prefixed_Name(fibo_be_oac_exec, "Auditor") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-exec:Authorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Authorization">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Authorization</seealso>
    let Authorization = Prefixed_Name(fibo_be_oac_exec, "Authorization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:AuthorizedIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"authorized individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedIndividual">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedIndividual</seealso>
    let AuthorizedIndividual =
        Prefixed_Name(fibo_be_oac_exec, "AuthorizedIndividual") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:AuthorizedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedParty</seealso>
    let AuthorizedParty =
        Prefixed_Name(fibo_be_oac_exec, "AuthorizedParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:AuthorizingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizingParty</seealso>
    let AuthorizingParty =
        Prefixed_Name(fibo_be_oac_exec, "AuthorizingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:BoardCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"board capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCapacity">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCapacity</seealso>
    let BoardCapacity = Prefixed_Name(fibo_be_oac_exec, "BoardCapacity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:BoardCompositionControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"board composition control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCompositionControl">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCompositionControl</seealso>
    let BoardCompositionControl =
        Prefixed_Name(fibo_be_oac_exec, "BoardCompositionControl") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:BoardMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"board member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMember">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMember</seealso>
    let BoardMember = Prefixed_Name(fibo_be_oac_exec, "BoardMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:BoardMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"board membership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMembership">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMembership</seealso>
    let BoardMembership =
        Prefixed_Name(fibo_be_oac_exec, "BoardMembership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:BoardOfDirectors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"board of directors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardOfDirectors">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardOfDirectors</seealso>
    let BoardOfDirectors =
        Prefixed_Name(fibo_be_oac_exec, "BoardOfDirectors") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:Bylaws</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bylaws"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Bylaws">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Bylaws</seealso>
    let Bylaws = Prefixed_Name(fibo_be_oac_exec, "Bylaws") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:ChiefExecutiveOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chief executive officer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefExecutiveOfficer">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefExecutiveOfficer</seealso>
    let ChiefExecutiveOfficer =
        Prefixed_Name(fibo_be_oac_exec, "ChiefExecutiveOfficer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:ChiefFinancialOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chief financial officer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefFinancialOfficer">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefFinancialOfficer</seealso>
    let ChiefFinancialOfficer =
        Prefixed_Name(fibo_be_oac_exec, "ChiefFinancialOfficer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:CompanyLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"company law"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanyLaw">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanyLaw</seealso>
    let CompanyLaw = Prefixed_Name(fibo_be_oac_exec, "CompanyLaw") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:CompanySecretary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"company secretary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanySecretary">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanySecretary</seealso>
    let CompanySecretary =
        Prefixed_Name(fibo_be_oac_exec, "CompanySecretary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:ControllingNominee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlling nominee"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ControllingNominee">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ControllingNominee</seealso>
    let ControllingNominee =
        Prefixed_Name(fibo_be_oac_exec, "ControllingNominee") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:CorporateBylaws</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"corporate bylaws"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateBylaws">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateBylaws</seealso>
    let CorporateBylaws =
        Prefixed_Name(fibo_be_oac_exec, "CorporateBylaws") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:CorporateOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"corporate officer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateOfficer">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateOfficer</seealso>
    let CorporateOfficer =
        Prefixed_Name(fibo_be_oac_exec, "CorporateOfficer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:Executive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"executive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Executive">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Executive</seealso>
    let Executive = Prefixed_Name(fibo_be_oac_exec, "Executive") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:ExecutiveBoardMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"executive board member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExecutiveBoardMember">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExecutiveBoardMember</seealso>
    let ExecutiveBoardMember =
        Prefixed_Name(fibo_be_oac_exec, "ExecutiveBoardMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:ExternalAuditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"external auditor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExternalAuditor">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExternalAuditor</seealso>
    let ExternalAuditor =
        Prefixed_Name(fibo_be_oac_exec, "ExternalAuditor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:InternalAuditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"internal auditor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/InternalAuditor">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/InternalAuditor</seealso>
    let InternalAuditor =
        Prefixed_Name(fibo_be_oac_exec, "InternalAuditor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:LegallyDelegatedAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/LegallyDelegatedAuthority">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/LegallyDelegatedAuthority</seealso>
    let LegallyDelegatedAuthority =
        Prefixed_Name(fibo_be_oac_exec, "LegallyDelegatedAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:NonExecutiveBoardMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-executive board member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/NonExecutiveBoardMember">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/NonExecutiveBoardMember</seealso>
    let NonExecutiveBoardMember =
        Prefixed_Name(fibo_be_oac_exec, "NonExecutiveBoardMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:PrincipalParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"principal party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/PrincipalParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/PrincipalParty</seealso>
    let PrincipalParty =
        Prefixed_Name(fibo_be_oac_exec, "PrincipalParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:ResponsibleParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ResponsibleParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ResponsibleParty</seealso>
    let ResponsibleParty =
        Prefixed_Name(fibo_be_oac_exec, "ResponsibleParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:Signatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"signatory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Signatory">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Signatory</seealso>
    let Signatory = Prefixed_Name(fibo_be_oac_exec, "Signatory") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-exec:authorizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizes">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizes</seealso>
    let authorizes = Prefixed_Name(fibo_be_oac_exec, "authorizes") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:authorizesThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizesThrough">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizesThrough</seealso>
    let authorizesThrough =
        Prefixed_Name(fibo_be_oac_exec, "authorizesThrough") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:delegatesControlTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/delegatesControlTo">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/delegatesControlTo</seealso>
    let delegatesControlTo =
        Prefixed_Name(fibo_be_oac_exec, "delegatesControlTo") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:designatesSignatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"designates signatory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/designatesSignatory">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/designatesSignatory</seealso>
    let designatesSignatory =
        Prefixed_Name(fibo_be_oac_exec, "designatesSignatory") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:elects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"elects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/elects">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/elects</seealso>
    let elects = Prefixed_Name(fibo_be_oac_exec, "elects") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasAuthorizedParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizedParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizedParty</seealso>
    let hasAuthorizedParty =
        Prefixed_Name(fibo_be_oac_exec, "hasAuthorizedParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasAuthorizingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizingParty</seealso>
    let hasAuthorizingParty =
        Prefixed_Name(fibo_be_oac_exec, "hasAuthorizingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasCorporateOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has corporate officer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasCorporateOfficer">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasCorporateOfficer</seealso>
    let hasCorporateOfficer =
        Prefixed_Name(fibo_be_oac_exec, "hasCorporateOfficer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasDelegatedControlOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDelegatedControlOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDelegatedControlOf</seealso>
    let hasDelegatedControlOf =
        Prefixed_Name(fibo_be_oac_exec, "hasDelegatedControlOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has director"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDirector">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDirector</seealso>
    let hasDirector = Prefixed_Name(fibo_be_oac_exec, "hasDirector") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasPrincipalManagingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has principal managing party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasPrincipalManagingParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasPrincipalManagingParty</seealso>
    let hasPrincipalManagingParty =
        Prefixed_Name(fibo_be_oac_exec, "hasPrincipalManagingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has responsibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibility">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibility</seealso>
    let hasResponsibility =
        Prefixed_Name(fibo_be_oac_exec, "hasResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasResponsibleParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibleParty">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibleParty</seealso>
    let hasResponsibleParty =
        Prefixed_Name(fibo_be_oac_exec, "hasResponsibleParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasSigningAuthorityFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has signing authority for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasSigningAuthorityFor">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasSigningAuthorityFor</seealso>
    let hasSigningAuthorityFor =
        Prefixed_Name(fibo_be_oac_exec, "hasSigningAuthorityFor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:hasVestedInIt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has vested in it"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasVestedInIt">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasVestedInIt</seealso>
    let hasVestedInIt = Prefixed_Name(fibo_be_oac_exec, "hasVestedInIt") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:isAuthorizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedBy">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedBy</seealso>
    let isAuthorizedBy =
        Prefixed_Name(fibo_be_oac_exec, "isAuthorizedBy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:isAuthorizedThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedThrough">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedThrough</seealso>
    let isAuthorizedThrough =
        Prefixed_Name(fibo_be_oac_exec, "isAuthorizedThrough") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:isDirectorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is director of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isDirectorOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isDirectorOf</seealso>
    let isDirectorOf = Prefixed_Name(fibo_be_oac_exec, "isDirectorOf") |> PrefixedName
    /// <summary>
    ///   <para>fibo-be-oac-exec:isOfficerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is officer of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isOfficerOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isOfficerOf</seealso>
    let isOfficerOf = Prefixed_Name(fibo_be_oac_exec, "isOfficerOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:isPrincipalPartyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is principal party of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isPrincipalPartyOf">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isPrincipalPartyOf</seealso>
    let isPrincipalPartyOf =
        Prefixed_Name(fibo_be_oac_exec, "isPrincipalPartyOf") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-oac-exec:nominates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"nominates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/nominates">https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/nominates</seealso>
    let nominates = Prefixed_Name(fibo_be_oac_exec, "nominates") |> PrefixedName
