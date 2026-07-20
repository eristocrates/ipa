namespace http.dev.poderopedia.com.vocab.slash

open DoxAletheia

module poder =
    let _namespace_name = "http://dev.poderopedia.com/vocab/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The connection between a person and an Educational Organization (university, school, etc)
    /// <see href="http://dev.poderopedia.com/vocab/AcademicConnection"></see></summary>
    let AcademicConnection = _prefix "AcademicConnection"
    /// <summary>
    /// A generic connection between two or more entities during a certain period of time
    /// <see href="http://dev.poderopedia.com/vocab/Connection"></see></summary>
    let Connection = _prefix "Connection"
    /// <summary>
    /// An educational organization, such a school or university
    /// <see href="http://dev.poderopedia.com/vocab/AcademicOrganization"></see></summary>
    let AcademicOrganization = _prefix "AcademicOrganization"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Acquaintance"></see>
    /// </summary>
    let Acquaintance = _prefix "Acquaintance"
    /// <summary>
    /// Connection between a two people, like friendship, acquaintances, etc.
    /// <see href="http://dev.poderopedia.com/vocab/SocialConnection"></see></summary>
    let SocialConnection = _prefix "SocialConnection"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/AcquisitionCompanyConnection"></see>
    /// </summary>
    let AcquisitionCompanyConnection = _prefix "AcquisitionCompanyConnection"
    /// <summary>
    /// The connection between two companies
    /// <see href="http://dev.poderopedia.com/vocab/CompanyConnection"></see></summary>
    let CompanyConnection = _prefix "CompanyConnection"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/AlumniEducationalConnection"></see>
    /// </summary>
    let AlumniEducationalConnection = _prefix "AlumniEducationalConnection"
    /// <summary>
    /// These connections reflects that a person studied (at least for some time) in an academic organization.
    /// <see href="http://dev.poderopedia.com/vocab/EducationalConnection"></see></summary>
    let EducationalConnection = _prefix "EducationalConnection"
    /// <summary>
    /// The connection between an entity and a Organization (Opus Dei, a Think Tank) without been affiliated to it necessarily
    /// <see href="http://dev.poderopedia.com/vocab/AssociationConnection"></see></summary>
    let AssociationConnection = _prefix "AssociationConnection"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Biography"></see>
    /// </summary>
    let Biography = _prefix "Biography"
    /// <summary>
    /// Abstract class  of any entity that has a source where its information was taken from
    /// <see href="http://dev.poderopedia.com/vocab/SourcedEntity"></see></summary>
    let SourcedEntity = _prefix "SourcedEntity"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/CivilUnion"></see>
    /// </summary>
    let CivilUnion = _prefix "CivilUnion"
    /// <summary>
    /// Class of possible marital status a person can be
    /// <see href="http://dev.poderopedia.com/vocab/SentimentalRelationshipConnection"></see></summary>
    let SentimentalRelationshipConnection = _prefix "SentimentalRelationshipConnection"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Classmate"></see>
    /// </summary>
    let Classmate = _prefix "Classmate"
    /// <summary>
    /// A for profit organization
    /// <see href="http://dev.poderopedia.com/vocab/Company"></see></summary>
    let Company = _prefix "Company"
    /// <summary>
    /// A region legally defined as a distinct entity in political geography
    /// <see href="http://dev.poderopedia.com/vocab/Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Dating"></see>
    /// </summary>
    let Dating = _prefix "Dating"
    /// <summary>
    /// Class that describes documents related to a person or organization, including its release date
    /// <see href="http://dev.poderopedia.com/vocab/Documentation"></see></summary>
    let Documentation = _prefix "Documentation"
    /// <summary>
    /// Class that describes any type of data related to an organization including a relevant date
    /// <see href="http://dev.poderopedia.com/vocab/RelatedData"></see></summary>
    let RelatedData = _prefix "RelatedData"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/DomesticPartnership"></see>
    /// </summary>
    let DomesticPartnership = _prefix "DomesticPartnership"
    /// <summary>
    /// Any financial information related to an organization (e.g., anual profit)
    /// <see href="http://dev.poderopedia.com/vocab/FinancialInformation"></see></summary>
    let FinancialInformation = _prefix "FinancialInformation"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/FinancierAssociationConnection"></see>
    /// </summary>
    let FinancierAssociationConnection = _prefix "FinancierAssociationConnection"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Friendship"></see>
    /// </summary>
    let Friendship = _prefix "Friendship"
    /// <summary>
    /// Gender of a person
    /// <see href="http://dev.poderopedia.com/vocab/Gender"></see></summary>
    let Gender = _prefix "Gender"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/GraduateEducationalConnection"></see>
    /// </summary>
    let GraduateEducationalConnection = _prefix "GraduateEducationalConnection"
    /// <summary>
    /// An international organization, like UN, UNESCO, etc.
    /// <see href="http://dev.poderopedia.com/vocab/InternationalOrganization"></see></summary>
    let InternationalOrganization = _prefix "InternationalOrganization"
    /// <summary>
    /// Long description of a person, organization, etc
    /// <see href="http://dev.poderopedia.com/vocab/LongBiography"></see></summary>
    let LongBiography = _prefix "LongBiography"
    /// <summary>
    /// Short description of a person, organization, etc
    /// <see href="http://dev.poderopedia.com/vocab/ShortBiography"></see></summary>
    let ShortBiography = _prefix "ShortBiography"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Marriage"></see>
    /// </summary>
    let Marriage = _prefix "Marriage"
    /// <summary>
    /// Official member of an organization (social club, religious group, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/MembershipAssociationConnection"></see></summary>
    let MembershipAssociationConnection = _prefix "MembershipAssociationConnection"
    /// <summary>
    /// The connection between an entity and an Educational Organization (university, school, etc)
    /// <see href="http://dev.poderopedia.com/vocab/MergeCompanyConnection"></see></summary>
    let MergeCompanyConnection = _prefix "MergeCompanyConnection"
    /// <summary>
    /// An event relevant from the point of view of journalism
    /// <see href="http://dev.poderopedia.com/vocab/NewsEvent"></see></summary>
    let NewsEvent = _prefix "NewsEvent"
    /// <summary>
    /// Describes the relation of a person with a news event during a specific period of time
    /// <see href="http://dev.poderopedia.com/vocab/NewsEventConnection"></see></summary>
    let NewsEventConnection = _prefix "NewsEventConnection"
    /// <summary>
    /// An non-governmental organization (NGO)
    /// <see href="http://dev.poderopedia.com/vocab/NonGovernmentalOrganization"></see></summary>
    let NonGovernmentalOrganization = _prefix "NonGovernmentalOrganization"
    /// <summary>
    /// Numeric datum for an organization for a certain year
    /// <see href="http://dev.poderopedia.com/vocab/NumericDatum"></see></summary>
    let NumericDatum = _prefix "NumericDatum"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/OtherAssociationConnection"></see>
    /// </summary>
    let OtherAssociationConnection = _prefix "OtherAssociationConnection"
    /// <summary>
    /// Connection between a political organization and other entities
    /// <see href="http://dev.poderopedia.com/vocab/PoliticalConnection"></see></summary>
    let PoliticalConnection = _prefix "PoliticalConnection"
    /// <summary>
    /// An Political organization, like parties.
    /// <see href="http://dev.poderopedia.com/vocab/PoliticalOrganization"></see></summary>
    let PoliticalOrganization = _prefix "PoliticalOrganization"
    /// <summary>
    /// An programmatic organization, like think tanks.
    /// <see href="http://dev.poderopedia.com/vocab/ProgrammaticOrganization"></see></summary>
    let ProgrammaticOrganization = _prefix "ProgrammaticOrganization"
    /// <summary>
    /// An religious organization, like Opus Dei, Catholic church, etc.
    /// <see href="http://dev.poderopedia.com/vocab/ReligiousOrganization"></see></summary>
    let ReligiousOrganization = _prefix "ReligiousOrganization"
    /// <summary>
    /// A restricted access organization, like social clubs, golf clubs, etc.
    /// <see href="http://dev.poderopedia.com/vocab/RestrictedAccessOrganization"></see></summary>
    let RestrictedAccessOrganization = _prefix "RestrictedAccessOrganization"
    /// <summary>
    /// Productive sector related to an agent
    /// <see href="http://dev.poderopedia.com/vocab/Sector"></see></summary>
    let Sector = _prefix "Sector"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/StudentEducationalConnection"></see>
    /// </summary>
    let StudentEducationalConnection = _prefix "StudentEducationalConnection"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/SympathizerAssociationConnection"></see>
    /// </summary>
    let SympathizerAssociationConnection = _prefix "SympathizerAssociationConnection"
    /// <summary>
    /// The connection between an entity and an Educational Organization (university, school, etc)
    /// <see href="http://dev.poderopedia.com/vocab/WorkConnection"></see></summary>
    let WorkConnection = _prefix "WorkConnection"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/WorkRole"></see>
    /// </summary>
    let WorkRole = _prefix "WorkRole"
    /// <summary>
    /// An academic organization (school, university) who is part of this connection
    /// <see href="http://dev.poderopedia.com/vocab/academicParticipant"></see></summary>
    let academicParticipant = _prefix "academicParticipant"
    /// <summary>
    /// An alias for a person
    /// <see href="http://dev.poderopedia.com/vocab/alias"></see></summary>
    let alias = _prefix "alias"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/buyerCompany"></see>
    /// </summary>
    let buyerCompany = _prefix "buyerCompany"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/ceo"></see>
    /// </summary>
    let ceo = _prefix "ceo"
    /// <summary>
    /// Relation between companies where one is the subsidiary of the second
    /// <see href="http://dev.poderopedia.com/vocab/commercialRepresentativesOf"></see></summary>
    let commercialRepresentativesOf = _prefix "commercialRepresentativesOf"
    /// <summary>
    /// Entity from where two persons know each other (school, college, church, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/connectedVia"></see></summary>
    let connectedVia = _prefix "connectedVia"
    /// <summary>
    /// Date when connection between entities ended
    /// <see href="http://dev.poderopedia.com/vocab/connectionEndDate"></see></summary>
    let connectionEndDate = _prefix "connectionEndDate"
    /// <summary>
    /// Date when connection between entities started
    /// <see href="http://dev.poderopedia.com/vocab/connectionStartDate"></see></summary>
    let connectionStartDate = _prefix "connectionStartDate"
    /// <summary>
    /// Country where the organization's headquarters are located
    /// <see href="http://dev.poderopedia.com/vocab/countryOfResidence"></see></summary>
    let countryOfResidence = _prefix "countryOfResidence"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/cto"></see>
    /// </summary>
    let cto = _prefix "cto"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/declarationOfInterests"></see>
    /// </summary>
    let declarationOfInterests = _prefix "declarationOfInterests"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/declarationOfPatrimony"></see>
    /// </summary>
    let declarationOfPatrimony = _prefix "declarationOfPatrimony"
    /// <summary>
    /// A depiction of some organization or person.
    /// <see href="http://dev.poderopedia.com/vocab/depiction"></see></summary>
    let depiction = _prefix "depiction"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/firstLastName"></see>
    /// </summary>
    let firstLastName = _prefix "firstLastName"
    /// <summary>
    /// Entity from where two persons know each other (school, college, church, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/hasAcademicOrganization"></see></summary>
    let hasAcademicOrganization = _prefix "hasAcademicOrganization"
    /// <summary>
    /// Main sector not listed in hasMainSector
    /// <see href="http://dev.poderopedia.com/vocab/hasAlternativeMainSector"></see></summary>
    let hasAlternativeMainSector = _prefix "hasAlternativeMainSector"
    /// <summary>
    /// Other sector not listed in hasOtherSector
    /// <see href="http://dev.poderopedia.com/vocab/hasAlternativeOtherSector"></see></summary>
    let hasAlternativeOtherSector = _prefix "hasAlternativeOtherSector"
    /// <summary>
    /// Sectors related to NGOs not lister previously
    /// <see href="http://dev.poderopedia.com/vocab/hasAnotherPhilantropySector"></see></summary>
    let hasAnotherPhilantropySector = _prefix "hasAnotherPhilantropySector"
    /// <summary>
    /// Describes relation where a person (object) is the sibling of one of the parents of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasAuntOrUncle"></see></summary>
    let hasAuntOrUncle = _prefix "hasAuntOrUncle"
    /// <summary>
    /// Describes relation where a person (object) is the child of one of the siblings of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasNieceOrNephew"></see></summary>
    let hasNieceOrNephew = _prefix "hasNieceOrNephew"
    /// <summary>
    /// Describes relation where a person (object) is a parent of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasChild"></see></summary>
    let hasChild = _prefix "hasChild"
    /// <summary>
    /// Describes relation where a person (object) is a parent of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasParent"></see></summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    /// Describes relation where a person (object) is the cousin (their parents are siblings) of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasCousin"></see></summary>
    let hasCousin = _prefix "hasCousin"
    /// <summary>
    /// URL where the document is located
    /// <see href="http://dev.poderopedia.com/vocab/hasDocumentURL"></see></summary>
    let hasDocumentURL = _prefix "hasDocumentURL"
    /// <summary>
    /// Associates an agent with related documentation
    /// <see href="http://dev.poderopedia.com/vocab/hasDocumentation"></see></summary>
    let hasDocumentation = _prefix "hasDocumentation"

    /// <summary>
    /// Organization or company associated with this economic connection
    /// <see href="http://dev.poderopedia.com/vocab/hasEconomicOrganizationParticipant"></see></summary>
    let hasEconomicOrganizationParticipant =
        _prefix "hasEconomicOrganizationParticipant"

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasFinancialInformationYear"></see>
    /// </summary>
    let hasFinancialInformationYear = _prefix "hasFinancialInformationYear"
    /// <summary>
    /// Gender of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasGender"></see></summary>
    let hasGender = _prefix "hasGender"
    /// <summary>
    /// Describes relation where a person (object) is the child of the person's child
    /// <see href="http://dev.poderopedia.com/vocab/hasGrandChild"></see></summary>
    let hasGrandChild = _prefix "hasGrandChild"
    /// <summary>
    /// Describes relation where a person (object) is the parent of the person's parent
    /// <see href="http://dev.poderopedia.com/vocab/hasGrandparent"></see></summary>
    let hasGrandparent = _prefix "hasGrandparent"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasLegalConstitution"></see>
    /// </summary>
    let hasLegalConstitution = _prefix "hasLegalConstitution"
    /// <summary>
    /// Logo of the organization
    /// <see href="http://dev.poderopedia.com/vocab/hasLogo"></see></summary>
    let hasLogo = _prefix "hasLogo"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasLongBiography"></see>
    /// </summary>
    let hasLongBiography = _prefix "hasLongBiography"
    /// <summary>
    /// Main sector related to the organization
    /// <see href="http://dev.poderopedia.com/vocab/hasMainSector"></see></summary>
    let hasMainSector = _prefix "hasMainSector"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasMap"></see>
    /// </summary>
    let hasMap = _prefix "hasMap"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasNumberEmployees"></see>
    /// </summary>
    let hasNumberEmployees = _prefix "hasNumberEmployees"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasNumericDatum"></see>
    /// </summary>
    let hasNumericDatum = _prefix "hasNumericDatum"
    /// <summary>
    /// Documents describing the organigram this agent
    /// <see href="http://dev.poderopedia.com/vocab/hasOrganigramDocumentation"></see></summary>
    let hasOrganigramDocumentation = _prefix "hasOrganigramDocumentation"
    /// <summary>
    /// Miscelaneous document related to this agent
    /// <see href="http://dev.poderopedia.com/vocab/hasOtherDocumentation"></see></summary>
    let hasOtherDocumentation = _prefix "hasOtherDocumentation"
    /// <summary>
    /// Other sector related to the organization
    /// <see href="http://dev.poderopedia.com/vocab/hasOtherSector"></see></summary>
    let hasOtherSector = _prefix "hasOtherSector"
    /// <summary>
    /// Sectors related to NGOs
    /// <see href="http://dev.poderopedia.com/vocab/hasPhilantropySector"></see></summary>
    let hasPhilantropySector = _prefix "hasPhilantropySector"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/PhilantropySector"></see>
    /// </summary>
    let PhilantropySector = _prefix "PhilantropySector"
    /// <summary>
    /// Date related to this data (e.g., release date, last modification, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/hasRelevantDate"></see></summary>
    let hasRelevantDate = _prefix "hasRelevantDate"
    /// <summary>
    /// Documents describing legal sanctions related to this agent
    /// <see href="http://dev.poderopedia.com/vocab/hasSanctionDocumentation"></see></summary>
    let hasSanctionDocumentation = _prefix "hasSanctionDocumentation"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasShortBiography"></see>
    /// </summary>
    let hasShortBiography = _prefix "hasShortBiography"
    /// <summary>
    /// Describes relation where a person (object) is the sibling (i.e., they have at least one parent in common) of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasSibling"></see></summary>
    let hasSibling = _prefix "hasSibling"
    /// <summary>
    /// An alias for a person
    /// <see href="http://dev.poderopedia.com/vocab/hasSocialReason"></see></summary>
    let hasSocialReason = _prefix "hasSocialReason"
    /// <summary>
    /// Source where the information about a connection was obtained
    /// <see href="http://dev.poderopedia.com/vocab/hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// Connection between two people that establishes a marriage, domestic partnership, civil union, sentimental relationship, etc.
    /// <see href="http://dev.poderopedia.com/vocab/hasSpouse"></see></summary>
    let hasSpouse = _prefix "hasSpouse"
    /// <summary>
    /// Person involved in an Education Connection
    /// <see href="http://dev.poderopedia.com/vocab/hasStudent"></see></summary>
    let hasStudent = _prefix "hasStudent"
    /// <summary>
    /// ID that identifies an organization or person for tax purposes
    /// <see href="http://dev.poderopedia.com/vocab/hasTaxId"></see></summary>
    let hasTaxId = _prefix "hasTaxId"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasTickerSymbol"></see>
    /// </summary>
    let hasTickerSymbol = _prefix "hasTickerSymbol"
    /// <summary>
    /// Any URL related to this organization or person (including social media, corporate sites, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/hasUrl"></see></summary>
    let hasUrl = _prefix "hasUrl"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// Position or role of the person in this economic connection
    /// <see href="http://dev.poderopedia.com/vocab/hasWorkRole"></see></summary>
    let hasWorkRole = _prefix "hasWorkRole"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/mergeCompany"></see>
    /// </summary>
    let mergeCompany = _prefix "mergeCompany"
    /// <summary>
    /// A news event which is part of this connection
    /// <see href="http://dev.poderopedia.com/vocab/newsEventParticipant"></see></summary>
    let newsEventParticipant = _prefix "newsEventParticipant"
    /// <summary>
    /// An academic organization (school, university) who is part of this connection
    /// <see href="http://dev.poderopedia.com/vocab/organizationParticipant"></see></summary>
    let organizationParticipant = _prefix "organizationParticipant"
    /// <summary>
    /// Other last name, different from the first one
    /// <see href="http://dev.poderopedia.com/vocab/otherLastName"></see></summary>
    let otherLastName = _prefix "otherLastName"
    /// <summary>
    /// A a member of an organization
    /// <see href="http://dev.poderopedia.com/vocab/personParticipant"></see></summary>
    let personParticipant = _prefix "personParticipant"
    /// <summary>
    /// A political organization who is part of this connection
    /// <see href="http://dev.poderopedia.com/vocab/politicalParticipant"></see></summary>
    let politicalParticipant = _prefix "politicalParticipant"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/schema"></see>
    /// </summary>
    let schema = _prefix "schema"
    /// <summary>
    /// Relation between companies where one is the subsidiary of the second
    /// <see href="http://dev.poderopedia.com/vocab/subsidiaryCompanyOf"></see></summary>
    let subsidiaryCompanyOf = _prefix "subsidiaryCompanyOf"
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/targetCompany"></see>
    /// </summary>
    let targetCompany = _prefix "targetCompany"
