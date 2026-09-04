#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module poder =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://dev.poderopedia.com/vocab/" "poder"

    /// <summary>
    ///   <para>rdfs:comment : La relación entre una persona y una organización académica (colegio, universidad, etc)rdfs:comment : The connection between a person and an Educational Organization (university, school, etc)</para>
    ///   <para>rdfs:label : Conexión académicardfs:label : Academic Connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/AcademicConnection">poder:AcademicConnection</a>
    /// </summary>
    let AcademicConnection = _prefixId.prefix "AcademicConnection"
    /// <summary>
    ///   <para>rdfs:comment : Una organización educational, como una escuela o una universidadrdfs:comment : An educational organization, such a school or university</para>
    ///   <para>rdfs:label : Organización académicardfs:label : Academic Organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/AcademicOrganization">poder:AcademicOrganization</a>
    /// </summary>
    let AcademicOrganization = _prefixId.prefix "AcademicOrganization"
    let Acquaintance = _prefixId.prefix "Acquaintance"
    /// <summary>
    ///   <para>rdfs:label : Adquisición de empresardfs:label : Company acquisition</para>
    ///   <a href="http://dev.poderopedia.com/vocab/AcquisitionCompanyConnection">poder:AcquisitionCompanyConnection</a>
    /// </summary>
    let AcquisitionCompanyConnection = _prefixId.prefix "AcquisitionCompanyConnection"
    /// <summary>
    ///   <para>rdfs:label : Ex-alumnordfs:label : Alumni</para>
    ///   <a href="http://dev.poderopedia.com/vocab/AlumniEducationalConnection">poder:AlumniEducationalConnection</a>
    /// </summary>
    let AlumniEducationalConnection = _prefixId.prefix "AlumniEducationalConnection"
    /// <summary>
    ///   <para>rdfs:comment : La relación entre una entidad y una organización (Opus Dei, un Think Tank) sin necesariamente estar afiliadordfs:comment : The connection between an entity and a Organization (Opus Dei, a Think Tank) without been affiliated to it necessarily</para>
    ///   <para>rdfs:label : Conexión de asociaciónrdfs:label : Association Connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/AssociationConnection">poder:AssociationConnection</a>
    /// </summary>
    let AssociationConnection = _prefixId.prefix "AssociationConnection"
    /// <summary>
    ///   <para>rdfs:label : Biografía genéricardfs:label : Generic biography</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Biography">poder:Biography</a>
    /// </summary>
    let Biography = _prefixId.prefix "Biography"
    /// <summary>
    ///   <para>rdfs:label : Unión civilrdfs:label : Civil union</para>
    ///   <a href="http://dev.poderopedia.com/vocab/CivilUnion">poder:CivilUnion</a>
    /// </summary>
    let CivilUnion = _prefixId.prefix "CivilUnion"
    let Classmate = _prefixId.prefix "Classmate"
    /// <summary>
    ///   <para>rdfs:comment : A for profit organization^^xsd:stringrdfs:comment : Una organización con fines de lucro</para>
    ///   <para>rdfs:label : Empresardfs:label : Company</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Company">poder:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:comment : La relación entre dos compañíasrdfs:comment : The connection between two companies</para>
    ///   <para>rdfs:label : Conexión entre compañíasrdfs:label : Company Connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/CompanyConnection">poder:CompanyConnection</a>
    /// </summary>
    let CompanyConnection = _prefixId.prefix "CompanyConnection"
    /// <summary>
    ///   <para>rdfs:comment : Una conexión genérica entre dos o más entidades durante un cierto período de tiempordfs:comment : A generic connection between two or more entities during a certain period of time</para>
    ///   <para>rdfs:label : Conexión genéricardfs:label : Generic connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Connection">poder:Connection</a>
    /// </summary>
    let Connection = _prefixId.prefix "Connection"
    /// <summary>
    ///   <para>rdfs:comment : Área geográfica y una entidad políticamente independiente con su propio gobierno, administración, etc.rdfs:comment : A region legally defined as a distinct entity in political geography</para>
    ///   <para>rdfs:label : Paísrdfs:label : Country</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Country">poder:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : Noviazgordfs:label : Dating</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Dating">poder:Dating</a>
    /// </summary>
    let Dating = _prefixId.prefix "Dating"
    /// <summary>
    ///   <para>rdfs:comment : Clase que describe documentos relacionados con una persona u organización, incluyendo su fecha de publicaciónrdfs:comment : Class that describes documents related to a person or organization, including its release date</para>
    ///   <para>rdfs:label : Documentaciónrdfs:label : Documentation</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Documentation">poder:Documentation</a>
    /// </summary>
    let Documentation = _prefixId.prefix "Documentation"
    /// <summary>
    ///   <para>rdfs:label : Pareja de hechordfs:label : Domestic partnership</para>
    ///   <a href="http://dev.poderopedia.com/vocab/DomesticPartnership">poder:DomesticPartnership</a>
    /// </summary>
    let DomesticPartnership = _prefixId.prefix "DomesticPartnership"
    /// <summary>
    ///   <para>rdfs:comment : Esta relación indica que una persona estudió (al menos por un tiempo) en una institución académicardfs:comment : These connections reflects that a person studied (at least for some time) in an academic organization.</para>
    ///   <para>rdfs:label : Conexión educacional (estudios)rdfs:label : Educational connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/EducationalConnection">poder:EducationalConnection</a>
    /// </summary>
    let EducationalConnection = _prefixId.prefix "EducationalConnection"
    /// <summary>
    ///   <para>rdfs:comment : Cualquier información financiera relacionada con una organización (ej., utilidades anuales)rdfs:comment : Any financial information related to an organization (e.g., anual profit)</para>
    ///   <para>rdfs:label : Información financierardfs:label : Financial Report</para>
    ///   <a href="http://dev.poderopedia.com/vocab/FinancialInformation">poder:FinancialInformation</a>
    /// </summary>
    let FinancialInformation = _prefixId.prefix "FinancialInformation"

    let FinancierAssociationConnection =
        _prefixId.prefix "FinancierAssociationConnection"

    let Friendship = _prefixId.prefix "Friendship"
    /// <summary>
    ///   <para>rdfs:comment : Sexo de una personardfs:comment : Gender of a person</para>
    ///   <para>rdfs:label : Sexordfs:label : Gender</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Gender">poder:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"
    /// <summary>
    ///   <para>rdfs:label : Tituladordfs:label : Graduate</para>
    ///   <a href="http://dev.poderopedia.com/vocab/GraduateEducationalConnection">poder:GraduateEducationalConnection</a>
    /// </summary>
    let GraduateEducationalConnection = _prefixId.prefix "GraduateEducationalConnection"
    /// <summary>
    ///   <para>rdfs:comment : Una organización internacional, como NU, UNESCO, etc.rdfs:comment : An international organization, like UN, UNESCO, etc.</para>
    ///   <para>rdfs:label : Organización internacionalrdfs:label : International Organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/InternationalOrganization">poder:InternationalOrganization</a>
    /// </summary>
    let InternationalOrganization = _prefixId.prefix "InternationalOrganization"
    /// <summary>
    ///   <para>rdfs:comment : Descripción extendida de una persona, organización, etcrdfs:comment : Long description of a person, organization, etc</para>
    ///   <para>rdfs:label : Biografía largardfs:label : Long biography</para>
    ///   <a href="http://dev.poderopedia.com/vocab/LongBiography">poder:LongBiography</a>
    /// </summary>
    let LongBiography = _prefixId.prefix "LongBiography"
    /// <summary>
    ///   <para>rdfs:label : Matrimoniordfs:label : Marriage</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Marriage">poder:Marriage</a>
    /// </summary>
    let Marriage = _prefixId.prefix "Marriage"

    let MembershipAssociationConnection =
        _prefixId.prefix "MembershipAssociationConnection"

    /// <summary>
    ///   <para>rdfs:comment : La relación entre una persona y una organización académica (colegio, universidad, etc)rdfs:comment : The connection between an entity and an Educational Organization (university, school, etc)</para>
    ///   <para>rdfs:label : Conexión económicardfs:label : Economic Connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/MergeCompanyConnection">poder:MergeCompanyConnection</a>
    /// </summary>
    let MergeCompanyConnection = _prefixId.prefix "MergeCompanyConnection"
    /// <summary>
    ///   <para>rdfs:comment : Un evento de relevancia periodísticardfs:comment : An event relevant from the point of view of journalism</para>
    ///   <para>rdfs:label : Evento noticiosordfs:label : News event</para>
    ///   <a href="http://dev.poderopedia.com/vocab/NewsEvent">poder:NewsEvent</a>
    /// </summary>
    let NewsEvent = _prefixId.prefix "NewsEvent"
    /// <summary>
    ///   <para>rdfs:comment : Describe la relación de una persona con un evento noticioso durante un período de tiempordfs:comment : Describes the relation of a person with a news event during a specific period of time</para>
    ///   <para>rdfs:label : Conexión con evento noticiosordfs:label : News event connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/NewsEventConnection">poder:NewsEventConnection</a>
    /// </summary>
    let NewsEventConnection = _prefixId.prefix "NewsEventConnection"
    /// <summary>
    ///   <para>rdfs:comment : Una organización no gubernamental (ONG)rdfs:comment : An non-governmental organization (NGO)</para>
    ///   <para>rdfs:label : Organización no gubernamentalrdfs:label : Non Governmental Organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/NonGovernmentalOrganization">poder:NonGovernmentalOrganization</a>
    /// </summary>
    let NonGovernmentalOrganization = _prefixId.prefix "NonGovernmentalOrganization"
    /// <summary>
    ///   <para>rdfs:comment : Información numérica para una organización, para cierto añordfs:comment : Numeric datum for an organization for a certain year</para>
    ///   <para>rdfs:label : Dato numéricordfs:label : Numeric datum</para>
    ///   <a href="http://dev.poderopedia.com/vocab/NumericDatum">poder:NumericDatum</a>
    /// </summary>
    let NumericDatum = _prefixId.prefix "NumericDatum"
    let OtherAssociationConnection = _prefixId.prefix "OtherAssociationConnection"
    let PhilantropySector = _prefixId.prefix "PhilantropySector"
    /// <summary>
    ///   <para>rdfs:comment : Relación entre una organización política y otra entidadrdfs:comment : Connection between a political organization and other entities</para>
    ///   <para>rdfs:label : Conexión políticardfs:label : Political connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/PoliticalConnection">poder:PoliticalConnection</a>
    /// </summary>
    let PoliticalConnection = _prefixId.prefix "PoliticalConnection"
    /// <summary>
    ///   <para>rdfs:comment : Una organización política, como partidos políticos.rdfs:comment : An Political organization, like parties.</para>
    ///   <para>rdfs:label : Organización políticardfs:label : Political Organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/PoliticalOrganization">poder:PoliticalOrganization</a>
    /// </summary>
    let PoliticalOrganization = _prefixId.prefix "PoliticalOrganization"
    /// <summary>
    ///   <para>rdfs:comment : Una organización programática, como los think tanks, etc.rdfs:comment : An programmatic organization, like think tanks.</para>
    ///   <para>rdfs:label : Organización programáticardfs:label : Programmatic Organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/ProgrammaticOrganization">poder:ProgrammaticOrganization</a>
    /// </summary>
    let ProgrammaticOrganization = _prefixId.prefix "ProgrammaticOrganization"
    /// <summary>
    ///   <para>rdfs:comment : Clase que describe datos relacionados con una organización, incluyendo su fecha relevanterdfs:comment : Class that describes any type of data related to an organization including a relevant date</para>
    ///   <para>rdfs:label : Datos relacionadosrdfs:label : Related Data</para>
    ///   <a href="http://dev.poderopedia.com/vocab/RelatedData">poder:RelatedData</a>
    /// </summary>
    let RelatedData = _prefixId.prefix "RelatedData"
    /// <summary>
    ///   <para>rdfs:comment : Una organización religiosa, como Opus Dei, Iglesia católica, etc.rdfs:comment : An religious organization, like Opus Dei, Catholic church, etc.</para>
    ///   <para>rdfs:label : Organización religiosardfs:label : Religious Organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/ReligiousOrganization">poder:ReligiousOrganization</a>
    /// </summary>
    let ReligiousOrganization = _prefixId.prefix "ReligiousOrganization"
    /// <summary>
    ///   <para>rdfs:comment : Una organización de acceso restringod, como clubes sociales, de golf, etc.rdfs:comment : A restricted access organization, like social clubs, golf clubs, etc.</para>
    ///   <para>rdfs:label : Organización de acceso restringidordfs:label : Restricted access organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/RestrictedAccessOrganization">poder:RestrictedAccessOrganization</a>
    /// </summary>
    let RestrictedAccessOrganization = _prefixId.prefix "RestrictedAccessOrganization"
    /// <summary>
    ///   <para>rdfs:comment : Sector productivo relacionado con una personardfs:comment : Productive sector related to an agent</para>
    ///   <para>rdfs:label : Sectorrdfs:label : Sector</para>
    ///   <a href="http://dev.poderopedia.com/vocab/Sector">poder:Sector</a>
    /// </summary>
    let Sector = _prefixId.prefix "Sector"

    /// <summary>
    ///   <para>rdfs:comment : Clase de los estados civiles en los que puede estar una personardfs:comment : Class of possible marital status a person can be</para>
    ///   <para>rdfs:label : Estado civilrdfs:label : Marital Status</para>
    ///   <a href="http://dev.poderopedia.com/vocab/SentimentalRelationshipConnection">poder:SentimentalRelationshipConnection</a>
    /// </summary>
    let SentimentalRelationshipConnection =
        _prefixId.prefix "SentimentalRelationshipConnection"

    /// <summary>
    ///   <para>rdfs:comment : Descripción abreviada de una persona, organización, etcrdfs:comment : Short description of a person, organization, etc</para>
    ///   <para>rdfs:label : Biografía cortardfs:label : Short biography</para>
    ///   <a href="http://dev.poderopedia.com/vocab/ShortBiography">poder:ShortBiography</a>
    /// </summary>
    let ShortBiography = _prefixId.prefix "ShortBiography"
    /// <summary>
    ///   <para>rdfs:comment : Relación entre dos personas descritas con un contexto (amistad, conocidos, etc)rdfs:comment : Connection between a two people, like friendship, acquaintances, etc.</para>
    ///   <para>rdfs:label : Conexión socialrdfs:label : Social connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/SocialConnection">poder:SocialConnection</a>
    /// </summary>
    let SocialConnection = _prefixId.prefix "SocialConnection"
    /// <summary>
    ///   <para>rdfs:comment : Clase abstracta de caulquier entidad cuya información tenga una fuenterdfs:comment : Abstract class  of any entity that has a source where its information was taken from</para>
    ///   <para>rdfs:label : Entidad con fuenterdfs:label : Sourced Entity</para>
    ///   <a href="http://dev.poderopedia.com/vocab/SourcedEntity">poder:SourcedEntity</a>
    /// </summary>
    let SourcedEntity = _prefixId.prefix "SourcedEntity"
    /// <summary>
    ///   <para>rdfs:label : Estudianterdfs:label : Student</para>
    ///   <a href="http://dev.poderopedia.com/vocab/StudentEducationalConnection">poder:StudentEducationalConnection</a>
    /// </summary>
    let StudentEducationalConnection = _prefixId.prefix "StudentEducationalConnection"

    let SympathizerAssociationConnection =
        _prefixId.prefix "SympathizerAssociationConnection"

    /// <summary>
    ///   <para>rdfs:comment : La relación entre una persona y una organización académica (colegio, universidad, etc)rdfs:comment : The connection between an entity and an Educational Organization (university, school, etc)</para>
    ///   <para>rdfs:label : Conexión económicardfs:label : Economic Connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/WorkConnection">poder:WorkConnection</a>
    /// </summary>
    let WorkConnection = _prefixId.prefix "WorkConnection"
    /// <summary>
    ///   <para>rdfs:label : Puesto de trabajordfs:label : Work role</para>
    ///   <a href="http://dev.poderopedia.com/vocab/WorkRole">poder:WorkRole</a>
    /// </summary>
    let WorkRole = _prefixId.prefix "WorkRole"
    /// <summary>
    ///   <para>rdfs:comment : Una organización académica (escuela, universidad) que participa de esta conexiónrdfs:comment : An academic organization (school, university) who is part of this connection</para>
    ///   <para>rdfs:label : Organización académica participanterdfs:label : Academic organization participant</para>
    ///   <a href="http://dev.poderopedia.com/vocab/academicParticipant">poder:academicParticipant</a>
    /// </summary>
    let academicParticipant = _prefixId.prefix "academicParticipant"
    /// <summary>
    ///   <para>rdfs:label : Aliasrdfs:label : Alias</para>
    ///   <para>rdfs:comment : Un alias de una personardfs:comment : An alias for a person</para>
    ///   <a href="http://dev.poderopedia.com/vocab/alias">poder:alias</a>
    /// </summary>
    let alias = _prefixId.prefix "alias"
    /// <summary>
    ///   <para>rdfs:label : Compradorrdfs:label : Buyer</para>
    ///   <a href="http://dev.poderopedia.com/vocab/buyerCompany">poder:buyerCompany</a>
    /// </summary>
    let buyerCompany = _prefixId.prefix "buyerCompany"
    let ceo = _prefixId.prefix "ceo"
    /// <summary>
    ///   <para>rdfs:comment : Relación entre empresas donde la primera es la filial de la segundardfs:comment : Relation between companies where one is the subsidiary of the second</para>
    ///   <para>rdfs:label : Representatens comerciales derdfs:label : Commercial representatives of</para>
    ///   <a href="http://dev.poderopedia.com/vocab/commercialRepresentativesOf">poder:commercialRepresentativesOf</a>
    /// </summary>
    let commercialRepresentativesOf = _prefixId.prefix "commercialRepresentativesOf"
    /// <summary>
    ///   <para>rdfs:comment : Entidad por la cual 2 personas se conocen (colegio, universidad, iglesia, etc.)rdfs:comment : Entity from where two persons know each other (school, college, church, etc.)</para>
    ///   <para>rdfs:label : Conectados viardfs:label : Connected via</para>
    ///   <a href="http://dev.poderopedia.com/vocab/connectedVia">poder:connectedVia</a>
    /// </summary>
    let connectedVia = _prefixId.prefix "connectedVia"
    /// <summary>
    ///   <para>rdfs:comment : Fecha cuando temrinó la conexión entre entidadesrdfs:comment : Date when connection between entities ended</para>
    ///   <para>rdfs:label : Fecha de fin de connecciónrdfs:label : Connection end date</para>
    ///   <a href="http://dev.poderopedia.com/vocab/connectionEndDate">poder:connectionEndDate</a>
    /// </summary>
    let connectionEndDate = _prefixId.prefix "connectionEndDate"
    /// <summary>
    ///   <para>rdfs:comment : Fecha cuando comenzó la conexión entre entidadesrdfs:comment : Date when connection between entities started</para>
    ///   <para>rdfs:label : Fecha de inicio de connecciónrdfs:label : Connection start date</para>
    ///   <a href="http://dev.poderopedia.com/vocab/connectionStartDate">poder:connectionStartDate</a>
    /// </summary>
    let connectionStartDate = _prefixId.prefix "connectionStartDate"
    /// <summary>
    ///   <para>rdfs:comment : Ubicación de los headquartersrdfs:comment : Country where the organization's headquarters are located</para>
    ///   <para>rdfs:label : País de residenciardfs:label : Country of residence</para>
    ///   <a href="http://dev.poderopedia.com/vocab/countryOfResidence">poder:countryOfResidence</a>
    /// </summary>
    let countryOfResidence = _prefixId.prefix "countryOfResidence"
    let cto = _prefixId.prefix "cto"
    /// <summary>
    ///   <para>rdfs:label : Declaración de interesesrdfs:label : Declaration of interests</para>
    ///   <a href="http://dev.poderopedia.com/vocab/declarationOfInterests">poder:declarationOfInterests</a>
    /// </summary>
    let declarationOfInterests = _prefixId.prefix "declarationOfInterests"
    /// <summary>
    ///   <para>rdfs:label : Declaración de Patrimoniordfs:label : Declaration of Patrimony</para>
    ///   <a href="http://dev.poderopedia.com/vocab/declarationOfPatrimony">poder:declarationOfPatrimony</a>
    /// </summary>
    let declarationOfPatrimony = _prefixId.prefix "declarationOfPatrimony"
    /// <summary>
    ///   <para>rdfs:label : imagenrdfs:label : depiction</para>
    ///   <para>rdfs:comment : Una representación visual de una persona u organizaciónrdfs:comment : A depiction of some organization or person.</para>
    ///   <a href="http://dev.poderopedia.com/vocab/depiction">poder:depiction</a>
    /// </summary>
    let depiction = _prefixId.prefix "depiction"
    /// <summary>
    ///   <para>rdfs:label : Primer apellidordfs:label : First last name</para>
    ///   <a href="http://dev.poderopedia.com/vocab/firstLastName">poder:firstLastName</a>
    /// </summary>
    let firstLastName = _prefixId.prefix "firstLastName"
    /// <summary>
    ///   <para>rdfs:comment : Entidad por la cual 2 personas se conocen (colegio, universidad, iglesia, etc.)rdfs:comment : Entity from where two persons know each other (school, college, church, etc.)</para>
    ///   <para>rdfs:label : Organización académicardfs:label : Academic organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasAcademicOrganization">poder:hasAcademicOrganization</a>
    /// </summary>
    let hasAcademicOrganization = _prefixId.prefix "hasAcademicOrganization"
    /// <summary>
    ///   <para>rdfs:comment : Sector principal no listado en hasMainSectorrdfs:comment : Main sector not listed in hasMainSector</para>
    ///   <para>rdfs:label : Otro sector principalrdfs:label : Has other main sector</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasAlternativeMainSector">poder:hasAlternativeMainSector</a>
    /// </summary>
    let hasAlternativeMainSector = _prefixId.prefix "hasAlternativeMainSector"
    /// <summary>
    ///   <para>rdfs:comment : Otro sector no listado en hasOtherSectorrdfs:comment : Other sector not listed in hasOtherSector</para>
    ///   <para>rdfs:label : Otro sector secundariordfs:label : Has other main sector</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasAlternativeOtherSector">poder:hasAlternativeOtherSector</a>
    /// </summary>
    let hasAlternativeOtherSector = _prefixId.prefix "hasAlternativeOtherSector"
    /// <summary>
    ///   <para>rdfs:comment : Sectores relationados a ONGs no listadosrdfs:comment : Sectors related to NGOs not lister previously</para>
    ///   <para>rdfs:label : Tiene otro Sector Org No Gubernamentales]rdfs:label : Has another Non Government Organization Sector</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasAnotherPhilantropySector">poder:hasAnotherPhilantropySector</a>
    /// </summary>
    let hasAnotherPhilantropySector = _prefixId.prefix "hasAnotherPhilantropySector"
    /// <summary>
    ///   <para>rdfs:comment : Describe la relación donde una persona (objeto) es el/la hermano/a de uno de los padres de esta personardfs:comment : Describes relation where a person (object) is the sibling of one of the parents of this person</para>
    ///   <para>rdfs:label : Tío/ardfs:label : Has Aunt or Uncle</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasAuntOrUncle">poder:hasAuntOrUncle</a>
    /// </summary>
    let hasAuntOrUncle = _prefixId.prefix "hasAuntOrUncle"
    /// <summary>
    ///   <para>rdfs:comment : Describe la relación donde una persona (objeto) es el padre o madre de esta personardfs:comment : Describes relation where a person (object) is a parent of this person</para>
    ///   <para>rdfs:label : Padre/Madrerdfs:label : Has Parent</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasChild">poder:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:comment : Describe la relación donde una persona (objeto) es primo o prima de esta personardfs:comment : Describes relation where a person (object) is the cousin (their parents are siblings) of this person</para>
    ///   <para>rdfs:label : Primo/ardfs:label : Has cousin</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasCousin">poder:hasCousin</a>
    /// </summary>
    let hasCousin = _prefixId.prefix "hasCousin"
    /// <summary>
    ///   <para>rdfs:comment : URL donde se encuentra el documentordfs:comment : URL where the document is located</para>
    ///   <para>rdfs:label : URL de documentordfs:label : Document URL</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasDocumentURL">poder:hasDocumentURL</a>
    /// </summary>
    let hasDocumentURL = _prefixId.prefix "hasDocumentURL"
    /// <summary>
    ///   <para>rdfs:comment : Asocia un agente con documentación relacionadardfs:comment : Associates an agent with related documentation</para>
    ///   <para>rdfs:label : Tiene documentaciónrdfs:label : Has documentation</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasDocumentation">poder:hasDocumentation</a>
    /// </summary>
    let hasDocumentation = _prefixId.prefix "hasDocumentation"

    /// <summary>
    ///   <para>rdfs:comment : Organización o empresa relacionada con esta connexión económicardfs:comment : Organization or company associated with this economic connection</para>
    ///   <para>rdfs:label : Organización/empresa relacionadardfs:label : Organization/Company involved</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasEconomicOrganizationParticipant">poder:hasEconomicOrganizationParticipant</a>
    /// </summary>
    let hasEconomicOrganizationParticipant =
        _prefixId.prefix "hasEconomicOrganizationParticipant"

    /// <summary>
    ///   <para>rdfs:label : Fecha de la información financierardfs:label : Date of financial information</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasFinancialInformationYear">poder:hasFinancialInformationYear</a>
    /// </summary>
    let hasFinancialInformationYear = _prefixId.prefix "hasFinancialInformationYear"
    /// <summary>
    ///   <para>rdfs:comment : Sexo de esta personardfs:comment : Gender of this person</para>
    ///   <para>rdfs:label : Sexordfs:label : Gender</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasGender">poder:hasGender</a>
    /// </summary>
    let hasGender = _prefixId.prefix "hasGender"
    /// <summary>
    ///   <para>rdfs:comment : Describe la relación donde una persona (objeto) es hijo/a del hijo/a de la personardfs:comment : Describes relation where a person (object) is the child of the person's child</para>
    ///   <para>rdfs:label : Nieto/ardfs:label : Has grandchild</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasGrandChild">poder:hasGrandChild</a>
    /// </summary>
    let hasGrandChild = _prefixId.prefix "hasGrandChild"
    /// <summary>
    ///   <para>rdfs:comment : Describe la relación donde una persona (objeto) es padre o madre del padre o madre de la personardfs:comment : Describes relation where a person (object) is the parent of the person's parent</para>
    ///   <para>rdfs:label : Abuelo/ardfs:label : Has grandparent</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasGrandparent">poder:hasGrandparent</a>
    /// </summary>
    let hasGrandparent = _prefixId.prefix "hasGrandparent"
    /// <summary>
    ///   <para>rdfs:label : Constitución legalrdfs:label : Legal constitution</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasLegalConstitution">poder:hasLegalConstitution</a>
    /// </summary>
    let hasLegalConstitution = _prefixId.prefix "hasLegalConstitution"
    /// <summary>
    ///   <para>rdfs:comment : Logo de la organizaciónrdfs:comment : Logo of the organization</para>
    ///   <para>rdfs:label : Logordfs:label : Logo</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasLogo">poder:hasLogo</a>
    /// </summary>
    let hasLogo = _prefixId.prefix "hasLogo"
    /// <summary>
    ///   <para>rdfs:label : Biografía largardfs:label : Long biography</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasLongBiography">poder:hasLongBiography</a>
    /// </summary>
    let hasLongBiography = _prefixId.prefix "hasLongBiography"
    /// <summary>
    ///   <para>rdfs:comment : Sector principal relacionado con la organizaciónrdfs:comment : Main sector related to the organization</para>
    ///   <para>rdfs:label : Sector principalrdfs:label : Has main sector</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasMainSector">poder:hasMainSector</a>
    /// </summary>
    let hasMainSector = _prefixId.prefix "hasMainSector"
    /// <summary>
    ///   <para>rdfs:label : Mapardfs:label : Map</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasMap">poder:hasMap</a>
    /// </summary>
    let hasMap = _prefixId.prefix "hasMap"
    /// <summary>
    ///   <para>rdfs:comment : Describe la relación donde una persona (objeto) es el/la hijo/a de uno de los hermano/as de esta personardfs:comment : Describes relation where a person (object) is the child of one of the siblings of this person</para>
    ///   <para>rdfs:label : Sobrino/ardfs:label : Has niece or nephew</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasNieceOrNephew">poder:hasNieceOrNephew</a>
    /// </summary>
    let hasNieceOrNephew = _prefixId.prefix "hasNieceOrNephew"
    /// <summary>
    ///   <para>rdfs:label : Número de empleadosrdfs:label : Number of Employees</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasNumberEmployees">poder:hasNumberEmployees</a>
    /// </summary>
    let hasNumberEmployees = _prefixId.prefix "hasNumberEmployees"
    /// <summary>
    ///   <para>rdfs:label : Tiene dato numéricordfs:label : Has numerical datum</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasNumericDatum">poder:hasNumericDatum</a>
    /// </summary>
    let hasNumericDatum = _prefixId.prefix "hasNumericDatum"
    /// <summary>
    ///   <para>rdfs:comment : Documentos que describen el organigrama este agenterdfs:comment : Documents describing the organigram this agent</para>
    ///   <para>rdfs:label : Documentación de organigramardfs:label : Organigram Documentation</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasOrganigramDocumentation">poder:hasOrganigramDocumentation</a>
    /// </summary>
    let hasOrganigramDocumentation = _prefixId.prefix "hasOrganigramDocumentation"
    /// <summary>
    ///   <para>rdfs:comment : Documentos misceláneos relacionadas con este agenterdfs:comment : Miscelaneous document related to this agent</para>
    ///   <para>rdfs:label : Otra documentaciónrdfs:label : Other documentation</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasOtherDocumentation">poder:hasOtherDocumentation</a>
    /// </summary>
    let hasOtherDocumentation = _prefixId.prefix "hasOtherDocumentation"
    /// <summary>
    ///   <para>rdfs:comment : Otros sectores relacionados con la organizaciónrdfs:comment : Other sector related to the organization</para>
    ///   <para>rdfs:label : Sector secundariordfs:label : Secondary sector</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasOtherSector">poder:hasOtherSector</a>
    /// </summary>
    let hasOtherSector = _prefixId.prefix "hasOtherSector"
    /// <summary>
    ///   <para>rdfs:comment : Describe la relación donde una persona (objeto) es el padre o madre de esta personardfs:comment : Describes relation where a person (object) is a parent of this person</para>
    ///   <para>rdfs:label : Padre/Madrerdfs:label : Has Parent</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasParent">poder:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>rdfs:comment : Sectores relationados a ONGsrdfs:comment : Sectors related to NGOs</para>
    ///   <para>rdfs:label : Tiene área de filantropíardfs:label : Has Philantropy Sector</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasPhilantropySector">poder:hasPhilantropySector</a>
    /// </summary>
    let hasPhilantropySector = _prefixId.prefix "hasPhilantropySector"
    /// <summary>
    ///   <para>rdfs:comment : Fecha relevante a este dato (ej., fecha de publicación, última modificación, etc)rdfs:comment : Date related to this data (e.g., release date, last modification, etc.)</para>
    ///   <para>rdfs:label : Fecha relevanterdfs:label : Relevant date</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasRelevantDate">poder:hasRelevantDate</a>
    /// </summary>
    let hasRelevantDate = _prefixId.prefix "hasRelevantDate"
    /// <summary>
    ///   <para>rdfs:comment : Documentos que describen sanciones legales relacionadas con este agenterdfs:comment : Documents describing legal sanctions related to this agent</para>
    ///   <para>rdfs:label : Documentación acerca de sancionesrdfs:label : Documents about sanctions</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasSanctionDocumentation">poder:hasSanctionDocumentation</a>
    /// </summary>
    let hasSanctionDocumentation = _prefixId.prefix "hasSanctionDocumentation"
    /// <summary>
    ///   <para>rdfs:label : Biografía cortardfs:label : Short biography</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasShortBiography">poder:hasShortBiography</a>
    /// </summary>
    let hasShortBiography = _prefixId.prefix "hasShortBiography"
    /// <summary>
    ///   <para>rdfs:comment : Describes relation where a person (object) is the sibling (i.e., they have at least one parent in common) of this personrdfs:comment : Describe la relación donde una persona (objeto) es el hermano o hermana (i.e, tienen al menos un padre en común) de esta persona</para>
    ///   <para>rdfs:label : Hermano/ardfs:label : Has sibling</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasSibling">poder:hasSibling</a>
    /// </summary>
    let hasSibling = _prefixId.prefix "hasSibling"
    /// <summary>
    ///   <para>rdfs:comment : Un alias de una personardfs:comment : An alias for a person</para>
    ///   <para>rdfs:label : Razón socialrdfs:label : Name</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasSocialReason">poder:hasSocialReason</a>
    /// </summary>
    let hasSocialReason = _prefixId.prefix "hasSocialReason"
    /// <summary>
    ///   <para>rdfs:comment : Fuente de donde se obtuvo la información acerca de una conexiónrdfs:comment : Source where the information about a connection was obtained</para>
    ///   <para>rdfs:label : Fuenterdfs:label : Source</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasSource">poder:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:comment : Connexión entre dos personas que establece un matrimonio, convivencia, unión civil, relación sentimental, etc.rdfs:comment : Connection between two people that establishes a marriage, domestic partnership, civil union, sentimental relationship, etc.</para>
    ///   <para>rdfs:label : Cónyugerdfs:label : Spouse</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasSpouse">poder:hasSpouse</a>
    /// </summary>
    let hasSpouse = _prefixId.prefix "hasSpouse"
    /// <summary>
    ///   <para>rdfs:comment : Persona en una conexión educacionalrdfs:comment : Person involved in an Education Connection</para>
    ///   <para>rdfs:label : Estudianterdfs:label : Student</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasStudent">poder:hasStudent</a>
    /// </summary>
    let hasStudent = _prefixId.prefix "hasStudent"
    /// <summary>
    ///   <para>rdfs:comment : ID que identifica a una organización o persona para efecto de los impuestosrdfs:comment : ID that identifies an organization or person for tax purposes</para>
    ///   <para>rdfs:label : Rol Único Tributario (RUT)rdfs:label : Tax ID</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasTaxId">poder:hasTaxId</a>
    /// </summary>
    let hasTaxId = _prefixId.prefix "hasTaxId"
    /// <summary>
    ///   <para>rdfs:label : Ticket de bolsardfs:label : Ticker symbol</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasTickerSymbol">poder:hasTickerSymbol</a>
    /// </summary>
    let hasTickerSymbol = _prefixId.prefix "hasTickerSymbol"
    /// <summary>
    ///   <para>rdfs:comment : Cualquier URL relaciontada con esa organización o persona (incluyendo social media, sitios corporativos, etc)rdfs:comment : Any URL related to this organization or person (including social media, corporate sites, etc.)</para>
    ///   <para>rdfs:label : Página webrdfs:label : Has URL</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasUrl">poder:hasUrl</a>
    /// </summary>
    let hasUrl = _prefixId.prefix "hasUrl"
    /// <summary>
    ///   <para>rdfs:label : Valor en un reporte financierordfs:label : Value in a financial information</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasValue">poder:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:comment : Puesto o rol de la persona en esta connexión económicardfs:comment : Position or role of the person in this economic connection</para>
    ///   <para>rdfs:label : Relación laboralrdfs:label : Work role</para>
    ///   <a href="http://dev.poderopedia.com/vocab/hasWorkRole">poder:hasWorkRole</a>
    /// </summary>
    let hasWorkRole = _prefixId.prefix "hasWorkRole"
    /// <summary>
    ///   <para>rdfs:label : Compañía fusionadardfs:label : Merge company</para>
    ///   <a href="http://dev.poderopedia.com/vocab/mergeCompany">poder:mergeCompany</a>
    /// </summary>
    let mergeCompany = _prefixId.prefix "mergeCompany"
    /// <summary>
    ///   <para>rdfs:comment : Un evento noticioso que participa de esta conexiónrdfs:comment : A news event which is part of this connection</para>
    ///   <para>rdfs:label : Evento noticioso participanterdfs:label : A news event participant in this connection</para>
    ///   <a href="http://dev.poderopedia.com/vocab/newsEventParticipant">poder:newsEventParticipant</a>
    /// </summary>
    let newsEventParticipant = _prefixId.prefix "newsEventParticipant"
    /// <summary>
    ///   <para>rdfs:comment : Una organización académica (escuela, universidad) que participa de esta conexiónrdfs:comment : An academic organization (school, university) who is part of this connection</para>
    ///   <para>rdfs:label : Organización participanterdfs:label : Participant organization</para>
    ///   <a href="http://dev.poderopedia.com/vocab/organizationParticipant">poder:organizationParticipant</a>
    /// </summary>
    let organizationParticipant = _prefixId.prefix "organizationParticipant"
    /// <summary>
    ///   <para>rdfs:comment : Otro apellido, que no es el primerordfs:comment : Other last name, different from the first one</para>
    ///   <para>rdfs:label : Otro apellidordfs:label : Other last name</para>
    ///   <a href="http://dev.poderopedia.com/vocab/otherLastName">poder:otherLastName</a>
    /// </summary>
    let otherLastName = _prefixId.prefix "otherLastName"
    /// <summary>
    ///   <para>rdfs:comment : Un miembro de una organizaciónrdfs:comment : A a member of an organization</para>
    ///   <para>rdfs:label : Persona miembrordfs:label : Member person</para>
    ///   <a href="http://dev.poderopedia.com/vocab/personParticipant">poder:personParticipant</a>
    /// </summary>
    let personParticipant = _prefixId.prefix "personParticipant"
    /// <summary>
    ///   <para>rdfs:comment : Una organización política que participa de esta conexiónrdfs:comment : A political organization who is part of this connection</para>
    ///   <para>rdfs:label : Organización política participanterdfs:label : Political Organizacion participant</para>
    ///   <a href="http://dev.poderopedia.com/vocab/politicalParticipant">poder:politicalParticipant</a>
    /// </summary>
    let politicalParticipant = _prefixId.prefix "politicalParticipant"
    let schema = _prefixId.prefix "schema"
    /// <summary>
    ///   <para>rdfs:comment : Relación entre empresas donde la primera es la filial de la segundardfs:comment : Relation between companies where one is the subsidiary of the second</para>
    ///   <para>rdfs:label : Empresa filial derdfs:label : Subsidiary company of</para>
    ///   <a href="http://dev.poderopedia.com/vocab/subsidiaryCompanyOf">poder:subsidiaryCompanyOf</a>
    /// </summary>
    let subsidiaryCompanyOf = _prefixId.prefix "subsidiaryCompanyOf"
    /// <summary>
    ///   <para>rdfs:label : Compañía targetrdfs:label : Target company</para>
    ///   <a href="http://dev.poderopedia.com/vocab/targetCompany">poder:targetCompany</a>
    /// </summary>
    let targetCompany = _prefixId.prefix "targetCompany"
