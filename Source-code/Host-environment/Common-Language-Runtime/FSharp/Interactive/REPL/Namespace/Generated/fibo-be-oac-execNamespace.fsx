#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-oac-exec`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/" "fibo-be-oac-exec"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : articles of incorporation^^xsd:string</para>
    ///   <para>skos:definition : contract that establishes a new corporation or, when amended, adjusts the legal basis for the corporation, and outlines basic information about the corporation, including the type of business, and a description of the business' operational characteristics^^xsd:string</para>
    ///   <para>cmns-av:synonym : articles of association^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ArticlesOfIncorporation">fibo-be-oac-exec:ArticlesOfIncorporation</a>
    /// </summary>
    let ArticlesOfIncorporation = _prefixId.prefix "ArticlesOfIncorporation"
    /// <summary>
    ///   <para>rdfs:label : auditor^^xsd:string</para>
    ///   <para>skos:definition : party qualified and authorized to review and verify the accuracy of financial records and ensure that companies comply with tax laws^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An auditor is authorized to audit one or more specific organizations, i.e., by the authorizing party indicated by the situation.^^xsd:stringcmns-av:explanatoryNote : An auditor may be an internal auditor - an individual whose primary job function is to audit his or her own company, or an external auditor - an individual from outside the company, who typically is employed by an auditing firm who handles many different clients.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Auditor">fibo-be-oac-exec:Auditor</a>
    /// </summary>
    let Auditor = _prefixId.prefix "Auditor"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Authorization">fibo-be-oac-exec:Authorization</a>
    /// </summary>
    let Authorization = _prefixId.prefix "Authorization"
    /// <summary>
    ///   <para>rdfs:label : authorized individual^^xsd:string</para>
    ///   <para>skos:definition : role of an individual that has been given the responsibility to act on behalf of another party under some set of guidelines^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedIndividual">fibo-be-oac-exec:AuthorizedIndividual</a>
    /// </summary>
    let AuthorizedIndividual = _prefixId.prefix "AuthorizedIndividual"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizedParty">fibo-be-oac-exec:AuthorizedParty</a>
    /// </summary>
    let AuthorizedParty = _prefixId.prefix "AuthorizedParty"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/AuthorizingParty">fibo-be-oac-exec:AuthorizingParty</a>
    /// </summary>
    let AuthorizingParty = _prefixId.prefix "AuthorizingParty"
    /// <summary>
    ///   <para>rdfs:label : board capacity^^xsd:string</para>
    ///   <para>skos:definition : authority to act in a fiduciary capacity with respect to the organization, including but not limited to determining and executing corporate policy^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCapacity">fibo-be-oac-exec:BoardCapacity</a>
    /// </summary>
    let BoardCapacity = _prefixId.prefix "BoardCapacity"
    /// <summary>
    ///   <para>rdfs:label : board composition control^^xsd:string</para>
    ///   <para>skos:definition : situation in which a voting shareholder, entity owner, or some other party in the case of a not-for-profit organization, appoints and/or nominates someone to the board of directors of an organization for some period of time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardCompositionControl">fibo-be-oac-exec:BoardCompositionControl</a>
    /// </summary>
    let BoardCompositionControl = _prefixId.prefix "BoardCompositionControl"
    /// <summary>
    ///   <para>rdfs:label : board member^^xsd:string</para>
    ///   <para>skos:definition : party that has fiduciary responsibility with respect to the organization, including but not limited to determining and executing corporate policy^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMember">fibo-be-oac-exec:BoardMember</a>
    /// </summary>
    let BoardMember = _prefixId.prefix "BoardMember"
    /// <summary>
    ///   <para>rdfs:label : board membership^^xsd:string</para>
    ///   <para>skos:definition : situation relating an individual member of the board of directors to the organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardMembership">fibo-be-oac-exec:BoardMembership</a>
    /// </summary>
    let BoardMembership = _prefixId.prefix "BoardMembership"
    /// <summary>
    ///   <para>rdfs:label : board of directors^^xsd:string</para>
    ///   <para>skos:definition : group of people comprising the governing body of an organization that has the authority to set organizational strategy and policies as well as to select and, to some degree manage, leadership^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For a public, for profit organization, its members (directors) are elected normally by the subscribers (stockholders) of the firm (generally at an annual general meeting) to govern the firm and look after the subscribers' interests. In the case of a not-for-profit organization, the board ensures the organization is acting in line with its mission. The board has the ultimate decision-making authority and, in general, is empowered to (1) set the company's policy, objectives, and overall direction, (2) adopt bylaws, (3) name members of the advisory, executive, finance, and other committees, (4) hire, monitor, evaluate, and fire the managing director and senior executives, (5) determine and pay the dividend, and (6) issue additional shares. Though all its members might not be engaged in the company's day-to-day operations, the entire board is held liable (under the doctrine of collective responsibility) for the consequences of the firm's policies, actions, and failures to act. Members of the board usually include senior-most executives (called inside directors or executive directors) as well as experts or respected persons chosen from the wider community (called outside directors or non-executive directors).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/BoardOfDirectors">fibo-be-oac-exec:BoardOfDirectors</a>
    /// </summary>
    let BoardOfDirectors = _prefixId.prefix "BoardOfDirectors"
    /// <summary>
    ///   <para>rdfs:label : bylaws^^xsd:string</para>
    ///   <para>skos:definition : written rules for conduct of a corporation, association, partnership or any organization^^xsd:string</para>
    ///   <para>cmns-av:synonym : byelaws^^xsd:stringcmns-av:synonym : membership agreement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Bylaws">fibo-be-oac-exec:Bylaws</a>
    /// </summary>
    let Bylaws = _prefixId.prefix "Bylaws"
    /// <summary>
    ///   <para>rdfs:label : chief executive officer^^xsd:string</para>
    ///   <para>skos:definition : top corporate officer responsible for an organization's overall operations and performance^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CEO^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : He or she is the leader of the firm, serves as the main link between the board of directors (the board) and the firm's various parts or levels, and is held solely responsible for the firm's success or failure. One of the major duties of a CEO is to maintain and implement corporate policy, as established by the board. Also called President or managing director, he or she may also be the chairman (or chairperson) of the board.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefExecutiveOfficer">fibo-be-oac-exec:ChiefExecutiveOfficer</a>
    /// </summary>
    let ChiefExecutiveOfficer = _prefixId.prefix "ChiefExecutiveOfficer"
    /// <summary>
    ///   <para>rdfs:label : chief financial officer^^xsd:string</para>
    ///   <para>skos:definition : senior-most corporate officer responsible for financial control and planning for an organization or project^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CFO^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : He or she is in charge of all accounting functions including (1) credit control, (2) preparing budgets and financial statements, (3) coordinating financing and fund raising, (4) monitoring expenditure and liquidity, (5) managing investment and taxation issues, (6) reporting financial performance to the board, and (7) providing timely financial data to the CEO. Also called chief finance officer, comptroller, controller, or finance controller.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ChiefFinancialOfficer">fibo-be-oac-exec:ChiefFinancialOfficer</a>
    /// </summary>
    let ChiefFinancialOfficer = _prefixId.prefix "ChiefFinancialOfficer"
    /// <summary>
    ///   <para>rdfs:label : company law^^xsd:string</para>
    ///   <para>skos:definition : legislation under which the formation, registration or incorporation, governance, and dissolution of a firm is administered and controlled^^xsd:string</para>
    ///   <para>cmns-av:synonym : corporate law^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanyLaw">fibo-be-oac-exec:CompanyLaw</a>
    /// </summary>
    let CompanyLaw = _prefixId.prefix "CompanyLaw"
    /// <summary>
    ///   <para>rdfs:label : company secretary^^xsd:string</para>
    ///   <para>skos:definition : corporate officer appointed by the directors of an organization, responsible for ensuring compliance with legal obligations related to corporate governance^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : His or her formal duties include (1) calling meetings, (2) recording minutes of the meetings, (3) keeping statutory record books, (4) proper payment of dividend and interest payments, and (5) proper drafting and execution of agreements, contracts, and resolutions.^^xsd:string</para>
    ///   <para>cmns-av:synonym : corporate secretary^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CompanySecretary">fibo-be-oac-exec:CompanySecretary</a>
    /// </summary>
    let CompanySecretary = _prefixId.prefix "CompanySecretary"
    /// <summary>
    ///   <para>rdfs:label : controlling nominee</para>
    ///   <para>skos:definition : party that holds legal title to an asset (e.g., stocks, bonds, or property) on behalf of the beneficial owner^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The nominee is typically the registered owner of an asset, named in official records.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ControllingNominee">fibo-be-oac-exec:ControllingNominee</a>
    /// </summary>
    let ControllingNominee = _prefixId.prefix "ControllingNominee"
    /// <summary>
    ///   <para>rdfs:label : corporate bylaws^^xsd:string</para>
    ///   <para>skos:definition : written rules for conduct of a corporation, adopted by the board of directors^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Corporate bylaws may contain any provision, not inconsistent with law or with the certificate of incorporation, relating to the business of the corporation, the conduct of its affairs, and its rights or powers or the rights or powers of its stockholders, directors, officers or employees. Changes to the bylaws of a corporation require a board-level resolution and may require a vote of the shareholders.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateBylaws">fibo-be-oac-exec:CorporateBylaws</a>
    /// </summary>
    let CorporateBylaws = _prefixId.prefix "CorporateBylaws"
    /// <summary>
    ///   <para>rdfs:label : corporate officer^^xsd:string</para>
    ///   <para>skos:definition : high-level management executive of a corporation or other organization, hired by the board of directors or the business owner(s), charged with certain operational responsibilities, and who has the authority to act on behalf of the organization, including the authority to enter into contracts on behalf of the organization^^xsd:string</para>
    ///   <para>skos:example : Corporate officers may include a Chief Executive Officer (CEO), Chief Financial Officer (CFO), president, vice president(s), and in some cases a Chief Operating Officer (COO), Chief Compliance Officer (CCO), or other executive responsible for a critical function in the organization.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In banking, corporate officers have the legal capacity to execute some documents and make certain decisions on behalf of the institution due to the nature of the business. The level of authority varies depending on the role the officer plays, however, and based on bank policy. In large institutions, corporate officers may include loan/lending officers, those in certain supervisory roles, and others with varying degrees of authority, and frequently they are given a 'vice president' title, particularly if they are customer facing. Hiring and other decisions related to such corporate officers may be delegated to more operational levels, rather than by the board directly, with respect to such personnel.^^xsd:stringcmns-av:explanatoryNote : Note that in most cases in the United States, corporate officers, especially those with signatory capacity and other fiduciary responsibilities must be employees, especially with respect to financial institutions and other highly regulated domains. There are cases, however, when an independent contractor or professional services provider may play the role of a corporate officer, such as a 'CFO for hire', which is a common practice in start-up organizations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/CorporateOfficer">fibo-be-oac-exec:CorporateOfficer</a>
    /// </summary>
    let CorporateOfficer = _prefixId.prefix "CorporateOfficer"
    /// <summary>
    ///   <para>rdfs:label : executive^^xsd:string</para>
    ///   <para>skos:definition : person appointed and given the responsibility to manage the affairs of an organization and the authority to make decisions within specified role-specific boundaries^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Executive">fibo-be-oac-exec:Executive</a>
    /// </summary>
    let Executive = _prefixId.prefix "Executive"
    /// <summary>
    ///   <para>rdfs:label : executive board member^^xsd:string</para>
    ///   <para>skos:definition : member of a board of directors that is also an employee of the organization^^xsd:string</para>
    ///   <para>cmns-av:synonym : inside director^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExecutiveBoardMember">fibo-be-oac-exec:ExecutiveBoardMember</a>
    /// </summary>
    let ExecutiveBoardMember = _prefixId.prefix "ExecutiveBoardMember"
    /// <summary>
    ///   <para>rdfs:label : external auditor^^xsd:string</para>
    ///   <para>skos:definition : independent party qualified and authorized to examine and report on the accuracy of financial records and ensure that companies comply with tax laws^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An external auditor is an individual or organization from outside the company, who typically is employed by an auditing firm that handles many different clients.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/ExternalAuditor">fibo-be-oac-exec:ExternalAuditor</a>
    /// </summary>
    let ExternalAuditor = _prefixId.prefix "ExternalAuditor"
    /// <summary>
    ///   <para>rdfs:label : internal auditor^^xsd:string</para>
    ///   <para>skos:definition : employee who is qualified and authorized to review and verify the accuracy of financial records and evaluate internal controls and compliance^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/InternalAuditor">fibo-be-oac-exec:InternalAuditor</a>
    /// </summary>
    let InternalAuditor = _prefixId.prefix "InternalAuditor"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/LegallyDelegatedAuthority">fibo-be-oac-exec:LegallyDelegatedAuthority</a>
    /// </summary>
    let LegallyDelegatedAuthority = _prefixId.prefix "LegallyDelegatedAuthority"
    /// <summary>
    ///   <para>rdfs:label : non-executive board member^^xsd:string</para>
    ///   <para>skos:definition : member of the board of directors of an organization that has no executive responsibilities towards the running of that organization^^xsd:string</para>
    ///   <para>cmns-av:synonym : outside director^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/NonExecutiveBoardMember">fibo-be-oac-exec:NonExecutiveBoardMember</a>
    /// </summary>
    let NonExecutiveBoardMember = _prefixId.prefix "NonExecutiveBoardMember"
    /// <summary>
    ///   <para>rdfs:label : principal party^^xsd:string</para>
    ///   <para>skos:definition : controlling party that is responsible for the management of daily business operations of an organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/PrincipalParty">fibo-be-oac-exec:PrincipalParty</a>
    /// </summary>
    let PrincipalParty = _prefixId.prefix "PrincipalParty"
    /// <summary>
    ///   <para>rdfs:label : signatory^^xsd:string</para>
    ///   <para>skos:definition : responsible party authorized to sign agreements on behalf of themselves, another person, or an organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/Signatory">fibo-be-oac-exec:Signatory</a>
    /// </summary>
    let Signatory = _prefixId.prefix "Signatory"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizes">fibo-be-oac-exec:authorizes</a>
    /// </summary>
    let authorizes = _prefixId.prefix "authorizes"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/authorizesThrough">fibo-be-oac-exec:authorizesThrough</a>
    /// </summary>
    let authorizesThrough = _prefixId.prefix "authorizesThrough"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/delegatesControlTo">fibo-be-oac-exec:delegatesControlTo</a>
    /// </summary>
    let delegatesControlTo = _prefixId.prefix "delegatesControlTo"
    /// <summary>
    ///   <para>rdfs:label : designates signatory^^xsd:string</para>
    ///   <para>skos:definition : authorizes to sign agreements, access accounts and/or perform other similar tasks^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/designatesSignatory">fibo-be-oac-exec:designatesSignatory</a>
    /// </summary>
    let designatesSignatory = _prefixId.prefix "designatesSignatory"
    /// <summary>
    ///   <para>rdfs:label : elects^^xsd:string</para>
    ///   <para>skos:definition : chooses someone, or a group of individuals, to hold office or some other position by voting^^xsd:string</para>
    ///   <para>skos:editorialNote : In the case of an election of the members of a board of directors, the bylaws state the manner in which that process is effected. The candidate members may be recommended by the board or other proxy and are then elected by the shareholders. A similar process may be conducted to elect outside auditors.^^xsd:string</para>
    ///   <para>skos:example : the election of officers of an association, the election of directors by the shareholders^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/elects">fibo-be-oac-exec:elects</a>
    /// </summary>
    let elects = _prefixId.prefix "elects"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizedParty">fibo-be-oac-exec:hasAuthorizedParty</a>
    /// </summary>
    let hasAuthorizedParty = _prefixId.prefix "hasAuthorizedParty"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasAuthorizingParty">fibo-be-oac-exec:hasAuthorizingParty</a>
    /// </summary>
    let hasAuthorizingParty = _prefixId.prefix "hasAuthorizingParty"
    /// <summary>
    ///   <para>rdfs:label : has corporate officer^^xsd:string</para>
    ///   <para>skos:definition : indicates an officer of the organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasCorporateOfficer">fibo-be-oac-exec:hasCorporateOfficer</a>
    /// </summary>
    let hasCorporateOfficer = _prefixId.prefix "hasCorporateOfficer"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDelegatedControlOf">fibo-be-oac-exec:hasDelegatedControlOf</a>
    /// </summary>
    let hasDelegatedControlOf = _prefixId.prefix "hasDelegatedControlOf"
    /// <summary>
    ///   <para>rdfs:label : has director^^xsd:string</para>
    ///   <para>skos:definition : indicates a member of the board of directors of the organization^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasDirector">fibo-be-oac-exec:hasDirector</a>
    /// </summary>
    let hasDirector = _prefixId.prefix "hasDirector"
    /// <summary>
    ///   <para>rdfs:label : has principal managing party^^xsd:string</para>
    ///   <para>skos:definition : indicates a controlling party that is responsible for the management of daily business operations^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasPrincipalManagingParty">fibo-be-oac-exec:hasPrincipalManagingParty</a>
    /// </summary>
    let hasPrincipalManagingParty = _prefixId.prefix "hasPrincipalManagingParty"
    /// <summary>
    ///   <para>rdfs:label : has responsibility^^xsd:string</para>
    ///   <para>skos:definition : specifies a commitment or obligation that an independent party has^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibility">fibo-be-oac-exec:hasResponsibility</a>
    /// </summary>
    let hasResponsibility = _prefixId.prefix "hasResponsibility"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasResponsibleParty">fibo-be-oac-exec:hasResponsibleParty</a>
    /// </summary>
    let hasResponsibleParty = _prefixId.prefix "hasResponsibleParty"
    /// <summary>
    ///   <para>rdfs:label : has signing authority for^^xsd:string</para>
    ///   <para>skos:definition : indicates the party for which a signatory has the ability to sign agreements, access accounts and perform related tasks^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasSigningAuthorityFor">fibo-be-oac-exec:hasSigningAuthorityFor</a>
    /// </summary>
    let hasSigningAuthorityFor = _prefixId.prefix "hasSigningAuthorityFor"
    /// <summary>
    ///   <para>rdfs:label : has vested in it^^xsd:string</para>
    ///   <para>skos:definition : indicates the delegated legal authority that is vested in the controlling party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/hasVestedInIt">fibo-be-oac-exec:hasVestedInIt</a>
    /// </summary>
    let hasVestedInIt = _prefixId.prefix "hasVestedInIt"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedBy">fibo-be-oac-exec:isAuthorizedBy</a>
    /// </summary>
    let isAuthorizedBy = _prefixId.prefix "isAuthorizedBy"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isAuthorizedThrough">fibo-be-oac-exec:isAuthorizedThrough</a>
    /// </summary>
    let isAuthorizedThrough = _prefixId.prefix "isAuthorizedThrough"
    /// <summary>
    ///   <para>rdfs:label : is director of^^xsd:string</para>
    ///   <para>skos:definition : indicates the organization that the board member oversees^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isDirectorOf">fibo-be-oac-exec:isDirectorOf</a>
    /// </summary>
    let isDirectorOf = _prefixId.prefix "isDirectorOf"
    /// <summary>
    ///   <para>rdfs:label : is officer of^^xsd:string</para>
    ///   <para>skos:definition : indicates the organization that the person has some authority over and managerial responsibility for^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isOfficerOf">fibo-be-oac-exec:isOfficerOf</a>
    /// </summary>
    let isOfficerOf = _prefixId.prefix "isOfficerOf"
    /// <summary>
    ///   <para>rdfs:label : is principal party of^^xsd:string</para>
    ///   <para>skos:definition : identifies a legal entity (controlled party) over which a principal has some measure of control^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/isPrincipalPartyOf">fibo-be-oac-exec:isPrincipalPartyOf</a>
    /// </summary>
    let isPrincipalPartyOf = _prefixId.prefix "isPrincipalPartyOf"
    /// <summary>
    ///   <para>rdfs:label : nominates^^xsd:string</para>
    ///   <para>skos:definition : appoints or proposes for appointment to an office or place^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that nominates is defined as a relation between two parties-in-role (the range of which could be a corporation or partnership in the case of an auditor), whereas appoints between independent parties.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/nominates">fibo-be-oac-exec:nominates</a>
    /// </summary>
    let nominates = _prefixId.prefix "nominates"
