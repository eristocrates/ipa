namespace http.dev.poderopedia.com.vocab.slash

open DoxAletheia.Rdf_Vocabulary

module poder =
    let _namespace_name = "http://dev.poderopedia.com/vocab/"

    /// <summary>
    /// The connection between a person and an Educational Organization (university, school, etc)
    /// <see href="http://dev.poderopedia.com/vocab/AcademicConnection"></see></summary>
    let AcademicConnection =
        Namespaced_IRI.parse _namespace_name "AcademicConnection" |> NamespacedName

    /// <summary>
    /// A generic connection between two or more entities during a certain period of time
    /// <see href="http://dev.poderopedia.com/vocab/Connection"></see></summary>
    let Connection = Namespaced_IRI.parse _namespace_name "Connection" |> NamespacedName

    /// <summary>
    /// An educational organization, such a school or university
    /// <see href="http://dev.poderopedia.com/vocab/AcademicOrganization"></see></summary>
    let AcademicOrganization =
        Namespaced_IRI.parse _namespace_name "AcademicOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Acquaintance"></see>
    /// </summary>
    let Acquaintance =
        Namespaced_IRI.parse _namespace_name "Acquaintance" |> NamespacedName

    /// <summary>
    /// Connection between a two people, like friendship, acquaintances, etc.
    /// <see href="http://dev.poderopedia.com/vocab/SocialConnection"></see></summary>
    let SocialConnection =
        Namespaced_IRI.parse _namespace_name "SocialConnection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/AcquisitionCompanyConnection"></see>
    /// </summary>
    let AcquisitionCompanyConnection =
        Namespaced_IRI.parse _namespace_name "AcquisitionCompanyConnection" |> NamespacedName

    /// <summary>
    /// The connection between two companies
    /// <see href="http://dev.poderopedia.com/vocab/CompanyConnection"></see></summary>
    let CompanyConnection =
        Namespaced_IRI.parse _namespace_name "CompanyConnection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/AlumniEducationalConnection"></see>
    /// </summary>
    let AlumniEducationalConnection =
        Namespaced_IRI.parse _namespace_name "AlumniEducationalConnection" |> NamespacedName

    /// <summary>
    /// These connections reflects that a person studied (at least for some time) in an academic organization.
    /// <see href="http://dev.poderopedia.com/vocab/EducationalConnection"></see></summary>
    let EducationalConnection =
        Namespaced_IRI.parse _namespace_name "EducationalConnection" |> NamespacedName

    /// <summary>
    /// The connection between an entity and a Organization (Opus Dei, a Think Tank) without been affiliated to it necessarily
    /// <see href="http://dev.poderopedia.com/vocab/AssociationConnection"></see></summary>
    let AssociationConnection =
        Namespaced_IRI.parse _namespace_name "AssociationConnection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Biography"></see>
    /// </summary>
    let Biography = Namespaced_IRI.parse _namespace_name "Biography" |> NamespacedName

    /// <summary>
    /// Abstract class  of any entity that has a source where its information was taken from
    /// <see href="http://dev.poderopedia.com/vocab/SourcedEntity"></see></summary>
    let SourcedEntity =
        Namespaced_IRI.parse _namespace_name "SourcedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/CivilUnion"></see>
    /// </summary>
    let CivilUnion = Namespaced_IRI.parse _namespace_name "CivilUnion" |> NamespacedName

    /// <summary>
    /// Class of possible marital status a person can be
    /// <see href="http://dev.poderopedia.com/vocab/SentimentalRelationshipConnection"></see></summary>
    let SentimentalRelationshipConnection =
        Namespaced_IRI.parse _namespace_name "SentimentalRelationshipConnection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Classmate"></see>
    /// </summary>
    let Classmate = Namespaced_IRI.parse _namespace_name "Classmate" |> NamespacedName
    /// <summary>
    /// A for profit organization
    /// <see href="http://dev.poderopedia.com/vocab/Company"></see></summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName
    /// <summary>
    /// A region legally defined as a distinct entity in political geography
    /// <see href="http://dev.poderopedia.com/vocab/Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Dating"></see>
    /// </summary>
    let Dating = Namespaced_IRI.parse _namespace_name "Dating" |> NamespacedName

    /// <summary>
    /// Class that describes documents related to a person or organization, including its release date
    /// <see href="http://dev.poderopedia.com/vocab/Documentation"></see></summary>
    let Documentation =
        Namespaced_IRI.parse _namespace_name "Documentation" |> NamespacedName

    /// <summary>
    /// Class that describes any type of data related to an organization including a relevant date
    /// <see href="http://dev.poderopedia.com/vocab/RelatedData"></see></summary>
    let RelatedData =
        Namespaced_IRI.parse _namespace_name "RelatedData" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/DomesticPartnership"></see>
    /// </summary>
    let DomesticPartnership =
        Namespaced_IRI.parse _namespace_name "DomesticPartnership" |> NamespacedName

    /// <summary>
    /// Any financial information related to an organization (e.g., anual profit)
    /// <see href="http://dev.poderopedia.com/vocab/FinancialInformation"></see></summary>
    let FinancialInformation =
        Namespaced_IRI.parse _namespace_name "FinancialInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/FinancierAssociationConnection"></see>
    /// </summary>
    let FinancierAssociationConnection =
        Namespaced_IRI.parse _namespace_name "FinancierAssociationConnection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Friendship"></see>
    /// </summary>
    let Friendship = Namespaced_IRI.parse _namespace_name "Friendship" |> NamespacedName
    /// <summary>
    /// Gender of a person
    /// <see href="http://dev.poderopedia.com/vocab/Gender"></see></summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/GraduateEducationalConnection"></see>
    /// </summary>
    let GraduateEducationalConnection =
        Namespaced_IRI.parse _namespace_name "GraduateEducationalConnection" |> NamespacedName

    /// <summary>
    /// An international organization, like UN, UNESCO, etc.
    /// <see href="http://dev.poderopedia.com/vocab/InternationalOrganization"></see></summary>
    let InternationalOrganization =
        Namespaced_IRI.parse _namespace_name "InternationalOrganization" |> NamespacedName

    /// <summary>
    /// Long description of a person, organization, etc
    /// <see href="http://dev.poderopedia.com/vocab/LongBiography"></see></summary>
    let LongBiography =
        Namespaced_IRI.parse _namespace_name "LongBiography" |> NamespacedName

    /// <summary>
    /// Short description of a person, organization, etc
    /// <see href="http://dev.poderopedia.com/vocab/ShortBiography"></see></summary>
    let ShortBiography =
        Namespaced_IRI.parse _namespace_name "ShortBiography" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/Marriage"></see>
    /// </summary>
    let Marriage = Namespaced_IRI.parse _namespace_name "Marriage" |> NamespacedName

    /// <summary>
    /// Official member of an organization (social club, religious group, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/MembershipAssociationConnection"></see></summary>
    let MembershipAssociationConnection =
        Namespaced_IRI.parse _namespace_name "MembershipAssociationConnection" |> NamespacedName

    /// <summary>
    /// The connection between an entity and an Educational Organization (university, school, etc)
    /// <see href="http://dev.poderopedia.com/vocab/MergeCompanyConnection"></see></summary>
    let MergeCompanyConnection =
        Namespaced_IRI.parse _namespace_name "MergeCompanyConnection" |> NamespacedName

    /// <summary>
    /// An event relevant from the point of view of journalism
    /// <see href="http://dev.poderopedia.com/vocab/NewsEvent"></see></summary>
    let NewsEvent = Namespaced_IRI.parse _namespace_name "NewsEvent" |> NamespacedName

    /// <summary>
    /// Describes the relation of a person with a news event during a specific period of time
    /// <see href="http://dev.poderopedia.com/vocab/NewsEventConnection"></see></summary>
    let NewsEventConnection =
        Namespaced_IRI.parse _namespace_name "NewsEventConnection" |> NamespacedName

    /// <summary>
    /// An non-governmental organization (NGO)
    /// <see href="http://dev.poderopedia.com/vocab/NonGovernmentalOrganization"></see></summary>
    let NonGovernmentalOrganization =
        Namespaced_IRI.parse _namespace_name "NonGovernmentalOrganization" |> NamespacedName

    /// <summary>
    /// Numeric datum for an organization for a certain year
    /// <see href="http://dev.poderopedia.com/vocab/NumericDatum"></see></summary>
    let NumericDatum =
        Namespaced_IRI.parse _namespace_name "NumericDatum" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/OtherAssociationConnection"></see>
    /// </summary>
    let OtherAssociationConnection =
        Namespaced_IRI.parse _namespace_name "OtherAssociationConnection" |> NamespacedName

    /// <summary>
    /// Connection between a political organization and other entities
    /// <see href="http://dev.poderopedia.com/vocab/PoliticalConnection"></see></summary>
    let PoliticalConnection =
        Namespaced_IRI.parse _namespace_name "PoliticalConnection" |> NamespacedName

    /// <summary>
    /// An Political organization, like parties.
    /// <see href="http://dev.poderopedia.com/vocab/PoliticalOrganization"></see></summary>
    let PoliticalOrganization =
        Namespaced_IRI.parse _namespace_name "PoliticalOrganization" |> NamespacedName

    /// <summary>
    /// An programmatic organization, like think tanks.
    /// <see href="http://dev.poderopedia.com/vocab/ProgrammaticOrganization"></see></summary>
    let ProgrammaticOrganization =
        Namespaced_IRI.parse _namespace_name "ProgrammaticOrganization" |> NamespacedName

    /// <summary>
    /// An religious organization, like Opus Dei, Catholic church, etc.
    /// <see href="http://dev.poderopedia.com/vocab/ReligiousOrganization"></see></summary>
    let ReligiousOrganization =
        Namespaced_IRI.parse _namespace_name "ReligiousOrganization" |> NamespacedName

    /// <summary>
    /// A restricted access organization, like social clubs, golf clubs, etc.
    /// <see href="http://dev.poderopedia.com/vocab/RestrictedAccessOrganization"></see></summary>
    let RestrictedAccessOrganization =
        Namespaced_IRI.parse _namespace_name "RestrictedAccessOrganization" |> NamespacedName

    /// <summary>
    /// Productive sector related to an agent
    /// <see href="http://dev.poderopedia.com/vocab/Sector"></see></summary>
    let Sector = Namespaced_IRI.parse _namespace_name "Sector" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/StudentEducationalConnection"></see>
    /// </summary>
    let StudentEducationalConnection =
        Namespaced_IRI.parse _namespace_name "StudentEducationalConnection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/SympathizerAssociationConnection"></see>
    /// </summary>
    let SympathizerAssociationConnection =
        Namespaced_IRI.parse _namespace_name "SympathizerAssociationConnection" |> NamespacedName

    /// <summary>
    /// The connection between an entity and an Educational Organization (university, school, etc)
    /// <see href="http://dev.poderopedia.com/vocab/WorkConnection"></see></summary>
    let WorkConnection =
        Namespaced_IRI.parse _namespace_name "WorkConnection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/WorkRole"></see>
    /// </summary>
    let WorkRole = Namespaced_IRI.parse _namespace_name "WorkRole" |> NamespacedName

    /// <summary>
    /// An academic organization (school, university) who is part of this connection
    /// <see href="http://dev.poderopedia.com/vocab/academicParticipant"></see></summary>
    let academicParticipant =
        Namespaced_IRI.parse _namespace_name "academicParticipant" |> NamespacedName

    /// <summary>
    /// An alias for a person
    /// <see href="http://dev.poderopedia.com/vocab/alias"></see></summary>
    let alias = Namespaced_IRI.parse _namespace_name "alias" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/buyerCompany"></see>
    /// </summary>
    let buyerCompany =
        Namespaced_IRI.parse _namespace_name "buyerCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/ceo"></see>
    /// </summary>
    let ceo = Namespaced_IRI.parse _namespace_name "ceo" |> NamespacedName

    /// <summary>
    /// Relation between companies where one is the subsidiary of the second
    /// <see href="http://dev.poderopedia.com/vocab/commercialRepresentativesOf"></see></summary>
    let commercialRepresentativesOf =
        Namespaced_IRI.parse _namespace_name "commercialRepresentativesOf" |> NamespacedName

    /// <summary>
    /// Entity from where two persons know each other (school, college, church, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/connectedVia"></see></summary>
    let connectedVia =
        Namespaced_IRI.parse _namespace_name "connectedVia" |> NamespacedName

    /// <summary>
    /// Date when connection between entities ended
    /// <see href="http://dev.poderopedia.com/vocab/connectionEndDate"></see></summary>
    let connectionEndDate =
        Namespaced_IRI.parse _namespace_name "connectionEndDate" |> NamespacedName

    /// <summary>
    /// Date when connection between entities started
    /// <see href="http://dev.poderopedia.com/vocab/connectionStartDate"></see></summary>
    let connectionStartDate =
        Namespaced_IRI.parse _namespace_name "connectionStartDate" |> NamespacedName

    /// <summary>
    /// Country where the organization's headquarters are located
    /// <see href="http://dev.poderopedia.com/vocab/countryOfResidence"></see></summary>
    let countryOfResidence =
        Namespaced_IRI.parse _namespace_name "countryOfResidence" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/cto"></see>
    /// </summary>
    let cto = Namespaced_IRI.parse _namespace_name "cto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/declarationOfInterests"></see>
    /// </summary>
    let declarationOfInterests =
        Namespaced_IRI.parse _namespace_name "declarationOfInterests" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/declarationOfPatrimony"></see>
    /// </summary>
    let declarationOfPatrimony =
        Namespaced_IRI.parse _namespace_name "declarationOfPatrimony" |> NamespacedName

    /// <summary>
    /// A depiction of some organization or person.
    /// <see href="http://dev.poderopedia.com/vocab/depiction"></see></summary>
    let depiction = Namespaced_IRI.parse _namespace_name "depiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/firstLastName"></see>
    /// </summary>
    let firstLastName =
        Namespaced_IRI.parse _namespace_name "firstLastName" |> NamespacedName

    /// <summary>
    /// Entity from where two persons know each other (school, college, church, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/hasAcademicOrganization"></see></summary>
    let hasAcademicOrganization =
        Namespaced_IRI.parse _namespace_name "hasAcademicOrganization" |> NamespacedName

    /// <summary>
    /// Main sector not listed in hasMainSector
    /// <see href="http://dev.poderopedia.com/vocab/hasAlternativeMainSector"></see></summary>
    let hasAlternativeMainSector =
        Namespaced_IRI.parse _namespace_name "hasAlternativeMainSector" |> NamespacedName

    /// <summary>
    /// Other sector not listed in hasOtherSector
    /// <see href="http://dev.poderopedia.com/vocab/hasAlternativeOtherSector"></see></summary>
    let hasAlternativeOtherSector =
        Namespaced_IRI.parse _namespace_name "hasAlternativeOtherSector" |> NamespacedName

    /// <summary>
    /// Sectors related to NGOs not lister previously
    /// <see href="http://dev.poderopedia.com/vocab/hasAnotherPhilantropySector"></see></summary>
    let hasAnotherPhilantropySector =
        Namespaced_IRI.parse _namespace_name "hasAnotherPhilantropySector" |> NamespacedName

    /// <summary>
    /// Describes relation where a person (object) is the sibling of one of the parents of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasAuntOrUncle"></see></summary>
    let hasAuntOrUncle =
        Namespaced_IRI.parse _namespace_name "hasAuntOrUncle" |> NamespacedName

    /// <summary>
    /// Describes relation where a person (object) is the child of one of the siblings of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasNieceOrNephew"></see></summary>
    let hasNieceOrNephew =
        Namespaced_IRI.parse _namespace_name "hasNieceOrNephew" |> NamespacedName

    /// <summary>
    /// Describes relation where a person (object) is a parent of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasChild"></see></summary>
    let hasChild = Namespaced_IRI.parse _namespace_name "hasChild" |> NamespacedName
    /// <summary>
    /// Describes relation where a person (object) is a parent of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasParent"></see></summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName
    /// <summary>
    /// Describes relation where a person (object) is the cousin (their parents are siblings) of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasCousin"></see></summary>
    let hasCousin = Namespaced_IRI.parse _namespace_name "hasCousin" |> NamespacedName

    /// <summary>
    /// URL where the document is located
    /// <see href="http://dev.poderopedia.com/vocab/hasDocumentURL"></see></summary>
    let hasDocumentURL =
        Namespaced_IRI.parse _namespace_name "hasDocumentURL" |> NamespacedName

    /// <summary>
    /// Associates an agent with related documentation
    /// <see href="http://dev.poderopedia.com/vocab/hasDocumentation"></see></summary>
    let hasDocumentation =
        Namespaced_IRI.parse _namespace_name "hasDocumentation" |> NamespacedName

    /// <summary>
    /// Organization or company associated with this economic connection
    /// <see href="http://dev.poderopedia.com/vocab/hasEconomicOrganizationParticipant"></see></summary>
    let hasEconomicOrganizationParticipant =
        Namespaced_IRI.parse _namespace_name "hasEconomicOrganizationParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasFinancialInformationYear"></see>
    /// </summary>
    let hasFinancialInformationYear =
        Namespaced_IRI.parse _namespace_name "hasFinancialInformationYear" |> NamespacedName

    /// <summary>
    /// Gender of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasGender"></see></summary>
    let hasGender = Namespaced_IRI.parse _namespace_name "hasGender" |> NamespacedName

    /// <summary>
    /// Describes relation where a person (object) is the child of the person's child
    /// <see href="http://dev.poderopedia.com/vocab/hasGrandChild"></see></summary>
    let hasGrandChild =
        Namespaced_IRI.parse _namespace_name "hasGrandChild" |> NamespacedName

    /// <summary>
    /// Describes relation where a person (object) is the parent of the person's parent
    /// <see href="http://dev.poderopedia.com/vocab/hasGrandparent"></see></summary>
    let hasGrandparent =
        Namespaced_IRI.parse _namespace_name "hasGrandparent" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasLegalConstitution"></see>
    /// </summary>
    let hasLegalConstitution =
        Namespaced_IRI.parse _namespace_name "hasLegalConstitution" |> NamespacedName

    /// <summary>
    /// Logo of the organization
    /// <see href="http://dev.poderopedia.com/vocab/hasLogo"></see></summary>
    let hasLogo = Namespaced_IRI.parse _namespace_name "hasLogo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasLongBiography"></see>
    /// </summary>
    let hasLongBiography =
        Namespaced_IRI.parse _namespace_name "hasLongBiography" |> NamespacedName

    /// <summary>
    /// Main sector related to the organization
    /// <see href="http://dev.poderopedia.com/vocab/hasMainSector"></see></summary>
    let hasMainSector =
        Namespaced_IRI.parse _namespace_name "hasMainSector" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasMap"></see>
    /// </summary>
    let hasMap = Namespaced_IRI.parse _namespace_name "hasMap" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasNumberEmployees"></see>
    /// </summary>
    let hasNumberEmployees =
        Namespaced_IRI.parse _namespace_name "hasNumberEmployees" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasNumericDatum"></see>
    /// </summary>
    let hasNumericDatum =
        Namespaced_IRI.parse _namespace_name "hasNumericDatum" |> NamespacedName

    /// <summary>
    /// Documents describing the organigram this agent
    /// <see href="http://dev.poderopedia.com/vocab/hasOrganigramDocumentation"></see></summary>
    let hasOrganigramDocumentation =
        Namespaced_IRI.parse _namespace_name "hasOrganigramDocumentation" |> NamespacedName

    /// <summary>
    /// Miscelaneous document related to this agent
    /// <see href="http://dev.poderopedia.com/vocab/hasOtherDocumentation"></see></summary>
    let hasOtherDocumentation =
        Namespaced_IRI.parse _namespace_name "hasOtherDocumentation" |> NamespacedName

    /// <summary>
    /// Other sector related to the organization
    /// <see href="http://dev.poderopedia.com/vocab/hasOtherSector"></see></summary>
    let hasOtherSector =
        Namespaced_IRI.parse _namespace_name "hasOtherSector" |> NamespacedName

    /// <summary>
    /// Sectors related to NGOs
    /// <see href="http://dev.poderopedia.com/vocab/hasPhilantropySector"></see></summary>
    let hasPhilantropySector =
        Namespaced_IRI.parse _namespace_name "hasPhilantropySector" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/PhilantropySector"></see>
    /// </summary>
    let PhilantropySector =
        Namespaced_IRI.parse _namespace_name "PhilantropySector" |> NamespacedName

    /// <summary>
    /// Date related to this data (e.g., release date, last modification, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/hasRelevantDate"></see></summary>
    let hasRelevantDate =
        Namespaced_IRI.parse _namespace_name "hasRelevantDate" |> NamespacedName

    /// <summary>
    /// Documents describing legal sanctions related to this agent
    /// <see href="http://dev.poderopedia.com/vocab/hasSanctionDocumentation"></see></summary>
    let hasSanctionDocumentation =
        Namespaced_IRI.parse _namespace_name "hasSanctionDocumentation" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasShortBiography"></see>
    /// </summary>
    let hasShortBiography =
        Namespaced_IRI.parse _namespace_name "hasShortBiography" |> NamespacedName

    /// <summary>
    /// Describes relation where a person (object) is the sibling (i.e., they have at least one parent in common) of this person
    /// <see href="http://dev.poderopedia.com/vocab/hasSibling"></see></summary>
    let hasSibling = Namespaced_IRI.parse _namespace_name "hasSibling" |> NamespacedName

    /// <summary>
    /// An alias for a person
    /// <see href="http://dev.poderopedia.com/vocab/hasSocialReason"></see></summary>
    let hasSocialReason =
        Namespaced_IRI.parse _namespace_name "hasSocialReason" |> NamespacedName

    /// <summary>
    /// Source where the information about a connection was obtained
    /// <see href="http://dev.poderopedia.com/vocab/hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName
    /// <summary>
    /// Connection between two people that establishes a marriage, domestic partnership, civil union, sentimental relationship, etc.
    /// <see href="http://dev.poderopedia.com/vocab/hasSpouse"></see></summary>
    let hasSpouse = Namespaced_IRI.parse _namespace_name "hasSpouse" |> NamespacedName
    /// <summary>
    /// Person involved in an Education Connection
    /// <see href="http://dev.poderopedia.com/vocab/hasStudent"></see></summary>
    let hasStudent = Namespaced_IRI.parse _namespace_name "hasStudent" |> NamespacedName
    /// <summary>
    /// ID that identifies an organization or person for tax purposes
    /// <see href="http://dev.poderopedia.com/vocab/hasTaxId"></see></summary>
    let hasTaxId = Namespaced_IRI.parse _namespace_name "hasTaxId" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasTickerSymbol"></see>
    /// </summary>
    let hasTickerSymbol =
        Namespaced_IRI.parse _namespace_name "hasTickerSymbol" |> NamespacedName

    /// <summary>
    /// Any URL related to this organization or person (including social media, corporate sites, etc.)
    /// <see href="http://dev.poderopedia.com/vocab/hasUrl"></see></summary>
    let hasUrl = Namespaced_IRI.parse _namespace_name "hasUrl" |> NamespacedName
    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// Position or role of the person in this economic connection
    /// <see href="http://dev.poderopedia.com/vocab/hasWorkRole"></see></summary>
    let hasWorkRole =
        Namespaced_IRI.parse _namespace_name "hasWorkRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/mergeCompany"></see>
    /// </summary>
    let mergeCompany =
        Namespaced_IRI.parse _namespace_name "mergeCompany" |> NamespacedName

    /// <summary>
    /// A news event which is part of this connection
    /// <see href="http://dev.poderopedia.com/vocab/newsEventParticipant"></see></summary>
    let newsEventParticipant =
        Namespaced_IRI.parse _namespace_name "newsEventParticipant" |> NamespacedName

    /// <summary>
    /// An academic organization (school, university) who is part of this connection
    /// <see href="http://dev.poderopedia.com/vocab/organizationParticipant"></see></summary>
    let organizationParticipant =
        Namespaced_IRI.parse _namespace_name "organizationParticipant" |> NamespacedName

    /// <summary>
    /// Other last name, different from the first one
    /// <see href="http://dev.poderopedia.com/vocab/otherLastName"></see></summary>
    let otherLastName =
        Namespaced_IRI.parse _namespace_name "otherLastName" |> NamespacedName

    /// <summary>
    /// A a member of an organization
    /// <see href="http://dev.poderopedia.com/vocab/personParticipant"></see></summary>
    let personParticipant =
        Namespaced_IRI.parse _namespace_name "personParticipant" |> NamespacedName

    /// <summary>
    /// A political organization who is part of this connection
    /// <see href="http://dev.poderopedia.com/vocab/politicalParticipant"></see></summary>
    let politicalParticipant =
        Namespaced_IRI.parse _namespace_name "politicalParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/schema"></see>
    /// </summary>
    let schema = Namespaced_IRI.parse _namespace_name "schema" |> NamespacedName

    /// <summary>
    /// Relation between companies where one is the subsidiary of the second
    /// <see href="http://dev.poderopedia.com/vocab/subsidiaryCompanyOf"></see></summary>
    let subsidiaryCompanyOf =
        Namespaced_IRI.parse _namespace_name "subsidiaryCompanyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dev.poderopedia.com/vocab/targetCompany"></see>
    /// </summary>
    let targetCompany =
        Namespaced_IRI.parse _namespace_name "targetCompany" |> NamespacedName
