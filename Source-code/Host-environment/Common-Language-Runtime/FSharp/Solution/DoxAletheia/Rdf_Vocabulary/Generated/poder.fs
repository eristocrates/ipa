namespace http.dev.poderopedia.com.vocab.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module poder =
    let _namespace_iri = Namespace_Iri poder |> NamespaceIRI
    /// <summary>
    ///   <para>poder:AcademicConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The connection between a person and an Educational Organization (university, school, etc)"</para>
    ///   <para>"La relación entre una persona y una organización académica (colegio, universidad, etc)"</para>
    /// labels<para>"Conexión académica"</para><para>"Academic Connection"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/AcademicConnection">http://dev.poderopedia.com/vocab/AcademicConnection</seealso>
    let AcademicConnection = Prefixed_Name(poder, "AcademicConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:AcademicOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una organización educational, como una escuela o una universidad"</para>
    ///   <para>"An educational organization, such a school or university"</para>
    /// labels<para>"Academic Organization"</para><para>"Organización académica"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/AcademicOrganization">http://dev.poderopedia.com/vocab/AcademicOrganization</seealso>
    let AcademicOrganization =
        Prefixed_Name(poder, "AcademicOrganization") |> PrefixedName

    /// <summary>
    ///   <para>poder:Acquaintance</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Acquaintance"</para><para>"Conocidos"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Acquaintance">http://dev.poderopedia.com/vocab/Acquaintance</seealso>
    let Acquaintance = Prefixed_Name(poder, "Acquaintance") |> PrefixedName

    /// <summary>
    ///   <para>poder:AcquisitionCompanyConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Company acquisition"</para><para>"Adquisición de empresa"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/AcquisitionCompanyConnection">http://dev.poderopedia.com/vocab/AcquisitionCompanyConnection</seealso>
    let AcquisitionCompanyConnection =
        Prefixed_Name(poder, "AcquisitionCompanyConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:AlumniEducationalConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ex-alumno"</para><para>"Alumni"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/AlumniEducationalConnection">http://dev.poderopedia.com/vocab/AlumniEducationalConnection</seealso>
    let AlumniEducationalConnection =
        Prefixed_Name(poder, "AlumniEducationalConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:AssociationConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The connection between an entity and a Organization (Opus Dei, a Think Tank) without been affiliated to it necessarily"</para>
    ///   <para>"La relación entre una entidad y una organización (Opus Dei, un Think Tank) sin necesariamente estar afiliado"</para>
    /// labels<para>"Association Connection"</para><para>"Conexión de asociación"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/AssociationConnection">http://dev.poderopedia.com/vocab/AssociationConnection</seealso>
    let AssociationConnection =
        Prefixed_Name(poder, "AssociationConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:Biography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Generic biography"</para><para>"Biografía genérica"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Biography">http://dev.poderopedia.com/vocab/Biography</seealso>
    let Biography = Prefixed_Name(poder, "Biography") |> PrefixedName
    /// <summary>
    ///   <para>poder:CivilUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unión civil"</para><para>"Civil union"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/CivilUnion">http://dev.poderopedia.com/vocab/CivilUnion</seealso>
    let CivilUnion = Prefixed_Name(poder, "CivilUnion") |> PrefixedName
    /// <summary>
    ///   <para>poder:Classmate</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Classmate"</para><para>"Compañero de curso o clases"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Classmate">http://dev.poderopedia.com/vocab/Classmate</seealso>
    let Classmate = Prefixed_Name(poder, "Classmate") |> PrefixedName
    /// <summary>
    ///   <para>poder:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una organización con fines de lucro"</para>
    ///   <para>"A for profit organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Company"</para><para>"Empresa"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Company">http://dev.poderopedia.com/vocab/Company</seealso>
    let Company = Prefixed_Name(poder, "Company") |> PrefixedName
    /// <summary>
    ///   <para>poder:CompanyConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The connection between two companies"</para>
    ///   <para>"La relación entre dos compañías"</para>
    /// labels<para>"Company Connection"</para><para>"Conexión entre compañías"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/CompanyConnection">http://dev.poderopedia.com/vocab/CompanyConnection</seealso>
    let CompanyConnection = Prefixed_Name(poder, "CompanyConnection") |> PrefixedName
    /// <summary>
    ///   <para>poder:Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una conexión genérica entre dos o más entidades durante un cierto período de tiempo"</para>
    ///   <para>"A generic connection between two or more entities during a certain period of time"</para>
    /// labels<para>"Generic connection"</para><para>"Conexión genérica"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Connection">http://dev.poderopedia.com/vocab/Connection</seealso>
    let Connection = Prefixed_Name(poder, "Connection") |> PrefixedName
    /// <summary>
    ///   <para>poder:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A region legally defined as a distinct entity in political geography"</para>
    ///   <para>"Área geográfica y una entidad políticamente independiente con su propio gobierno, administración, etc."</para>
    /// labels<para>"Country"</para><para>"País"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Country">http://dev.poderopedia.com/vocab/Country</seealso>
    let Country = Prefixed_Name(poder, "Country") |> PrefixedName
    /// <summary>
    ///   <para>poder:Dating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dating"</para><para>"Noviazgo"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Dating">http://dev.poderopedia.com/vocab/Dating</seealso>
    let Dating = Prefixed_Name(poder, "Dating") |> PrefixedName
    /// <summary>
    ///   <para>poder:Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that describes documents related to a person or organization, including its release date"</para>
    ///   <para>"Clase que describe documentos relacionados con una persona u organización, incluyendo su fecha de publicación"</para>
    /// labels<para>"Documentation"</para><para>"Documentación"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Documentation">http://dev.poderopedia.com/vocab/Documentation</seealso>
    let Documentation = Prefixed_Name(poder, "Documentation") |> PrefixedName

    /// <summary>
    ///   <para>poder:DomesticPartnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pareja de hecho"</para><para>"Domestic partnership"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/DomesticPartnership">http://dev.poderopedia.com/vocab/DomesticPartnership</seealso>
    let DomesticPartnership =
        Prefixed_Name(poder, "DomesticPartnership") |> PrefixedName

    /// <summary>
    ///   <para>poder:EducationalConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Esta relación indica que una persona estudió (al menos por un tiempo) en una institución académica"</para>
    ///   <para>"These connections reflects that a person studied (at least for some time) in an academic organization."</para>
    /// labels<para>"Conexión educacional (estudios)"</para><para>"Educational connection"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/EducationalConnection">http://dev.poderopedia.com/vocab/EducationalConnection</seealso>
    let EducationalConnection =
        Prefixed_Name(poder, "EducationalConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:FinancialInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any financial information related to an organization (e.g., anual profit)"</para>
    ///   <para>"Cualquier información financiera relacionada con una organización (ej., utilidades anuales)"</para>
    /// labels<para>"Información financiera"</para><para>"Financial Report"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/FinancialInformation">http://dev.poderopedia.com/vocab/FinancialInformation</seealso>
    let FinancialInformation =
        Prefixed_Name(poder, "FinancialInformation") |> PrefixedName

    /// <summary>
    ///   <para>poder:FinancierAssociationConnection</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Financista"</para><para>"Financier"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/FinancierAssociationConnection">http://dev.poderopedia.com/vocab/FinancierAssociationConnection</seealso>
    let FinancierAssociationConnection =
        Prefixed_Name(poder, "FinancierAssociationConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:Friendship</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Amistad"</para><para>"Friendship"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Friendship">http://dev.poderopedia.com/vocab/Friendship</seealso>
    let Friendship = Prefixed_Name(poder, "Friendship") |> PrefixedName
    /// <summary>
    ///   <para>poder:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sexo de una persona"</para>
    ///   <para>"Gender of a person"</para>
    /// labels<para>"Sexo"</para><para>"Gender"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Gender">http://dev.poderopedia.com/vocab/Gender</seealso>
    let Gender = Prefixed_Name(poder, "Gender") |> PrefixedName

    /// <summary>
    ///   <para>poder:GraduateEducationalConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Titulado"</para><para>"Graduate"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/GraduateEducationalConnection">http://dev.poderopedia.com/vocab/GraduateEducationalConnection</seealso>
    let GraduateEducationalConnection =
        Prefixed_Name(poder, "GraduateEducationalConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:InternationalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una organización internacional, como NU, UNESCO, etc."</para>
    ///   <para>"An international organization, like UN, UNESCO, etc."</para>
    /// labels<para>"Organización internacional"</para><para>"International Organization"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/InternationalOrganization">http://dev.poderopedia.com/vocab/InternationalOrganization</seealso>
    let InternationalOrganization =
        Prefixed_Name(poder, "InternationalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>poder:LongBiography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Long description of a person, organization, etc"</para>
    ///   <para>"Descripción extendida de una persona, organización, etc"</para>
    /// labels<para>"Long biography"</para><para>"Biografía larga"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/LongBiography">http://dev.poderopedia.com/vocab/LongBiography</seealso>
    let LongBiography = Prefixed_Name(poder, "LongBiography") |> PrefixedName
    /// <summary>
    ///   <para>poder:Marriage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Marriage"</para><para>"Matrimonio"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Marriage">http://dev.poderopedia.com/vocab/Marriage</seealso>
    let Marriage = Prefixed_Name(poder, "Marriage") |> PrefixedName

    /// <summary>
    ///   <para>poder:MembershipAssociationConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Miembro oficial de una organización (club social, grupo religioso, etc.)"</para>
    ///   <para>"Official member of an organization (social club, religious group, etc.)"</para>
    /// labels<para>"Member"</para><para>"Miembro"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/MembershipAssociationConnection">http://dev.poderopedia.com/vocab/MembershipAssociationConnection</seealso>
    let MembershipAssociationConnection =
        Prefixed_Name(poder, "MembershipAssociationConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:MergeCompanyConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La relación entre una persona y una organización académica (colegio, universidad, etc)"</para>
    ///   <para>"The connection between an entity and an Educational Organization (university, school, etc)"</para>
    /// labels<para>"Conexión económica"</para><para>"Economic Connection"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/MergeCompanyConnection">http://dev.poderopedia.com/vocab/MergeCompanyConnection</seealso>
    let MergeCompanyConnection =
        Prefixed_Name(poder, "MergeCompanyConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:NewsEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un evento de relevancia periodística"</para>
    ///   <para>"An event relevant from the point of view of journalism"</para>
    /// labels<para>"Evento noticioso"</para><para>"News event"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/NewsEvent">http://dev.poderopedia.com/vocab/NewsEvent</seealso>
    let NewsEvent = Prefixed_Name(poder, "NewsEvent") |> PrefixedName

    /// <summary>
    ///   <para>poder:NewsEventConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describe la relación de una persona con un evento noticioso durante un período de tiempo"</para>
    ///   <para>"Describes the relation of a person with a news event during a specific period of time"</para>
    /// labels<para>"Conexión con evento noticioso"</para><para>"News event connection"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/NewsEventConnection">http://dev.poderopedia.com/vocab/NewsEventConnection</seealso>
    let NewsEventConnection =
        Prefixed_Name(poder, "NewsEventConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:NonGovernmentalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una organización no gubernamental (ONG)"</para>
    ///   <para>"An non-governmental organization (NGO)"</para>
    /// labels<para>"Organización no gubernamental"</para><para>"Non Governmental Organization"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/NonGovernmentalOrganization">http://dev.poderopedia.com/vocab/NonGovernmentalOrganization</seealso>
    let NonGovernmentalOrganization =
        Prefixed_Name(poder, "NonGovernmentalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>poder:NumericDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Información numérica para una organización, para cierto año"</para>
    ///   <para>"Numeric datum for an organization for a certain year"</para>
    /// labels<para>"Dato numérico"</para><para>"Numeric datum"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/NumericDatum">http://dev.poderopedia.com/vocab/NumericDatum</seealso>
    let NumericDatum = Prefixed_Name(poder, "NumericDatum") |> PrefixedName

    /// <summary>
    ///   <para>poder:OtherAssociationConnection</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Other"</para><para>"Otro"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/OtherAssociationConnection">http://dev.poderopedia.com/vocab/OtherAssociationConnection</seealso>
    let OtherAssociationConnection =
        Prefixed_Name(poder, "OtherAssociationConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:PhilantropySector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/PhilantropySector">http://dev.poderopedia.com/vocab/PhilantropySector</seealso>
    let PhilantropySector = Prefixed_Name(poder, "PhilantropySector") |> PrefixedName

    /// <summary>
    ///   <para>poder:PoliticalConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connection between a political organization and other entities"</para>
    ///   <para>"Relación entre una organización política y otra entidad"</para>
    /// labels<para>"Conexión política"</para><para>"Political connection"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/PoliticalConnection">http://dev.poderopedia.com/vocab/PoliticalConnection</seealso>
    let PoliticalConnection =
        Prefixed_Name(poder, "PoliticalConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:PoliticalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una organización política, como partidos políticos."</para>
    ///   <para>"An Political organization, like parties."</para>
    /// labels<para>"Organización política"</para><para>"Political Organization"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/PoliticalOrganization">http://dev.poderopedia.com/vocab/PoliticalOrganization</seealso>
    let PoliticalOrganization =
        Prefixed_Name(poder, "PoliticalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>poder:ProgrammaticOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una organización programática, como los think tanks, etc."</para>
    ///   <para>"An programmatic organization, like think tanks."</para>
    /// labels<para>"Organización programática"</para><para>"Programmatic Organization"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/ProgrammaticOrganization">http://dev.poderopedia.com/vocab/ProgrammaticOrganization</seealso>
    let ProgrammaticOrganization =
        Prefixed_Name(poder, "ProgrammaticOrganization") |> PrefixedName

    /// <summary>
    ///   <para>poder:RelatedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that describes any type of data related to an organization including a relevant date"</para>
    ///   <para>"Clase que describe datos relacionados con una organización, incluyendo su fecha relevante"</para>
    /// labels<para>"Datos relacionados"</para><para>"Related Data"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/RelatedData">http://dev.poderopedia.com/vocab/RelatedData</seealso>
    let RelatedData = Prefixed_Name(poder, "RelatedData") |> PrefixedName

    /// <summary>
    ///   <para>poder:ReligiousOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An religious organization, like Opus Dei, Catholic church, etc."</para>
    ///   <para>"Una organización religiosa, como Opus Dei, Iglesia católica, etc."</para>
    /// labels<para>"Organización religiosa"</para><para>"Religious Organization"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/ReligiousOrganization">http://dev.poderopedia.com/vocab/ReligiousOrganization</seealso>
    let ReligiousOrganization =
        Prefixed_Name(poder, "ReligiousOrganization") |> PrefixedName

    /// <summary>
    ///   <para>poder:RestrictedAccessOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una organización de acceso restringod, como clubes sociales, de golf, etc."</para>
    ///   <para>"A restricted access organization, like social clubs, golf clubs, etc."</para>
    /// labels<para>"Restricted access organization"</para><para>"Organización de acceso restringido"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/RestrictedAccessOrganization">http://dev.poderopedia.com/vocab/RestrictedAccessOrganization</seealso>
    let RestrictedAccessOrganization =
        Prefixed_Name(poder, "RestrictedAccessOrganization") |> PrefixedName

    /// <summary>
    ///   <para>poder:Sector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Productive sector related to an agent"</para>
    ///   <para>"Sector productivo relacionado con una persona"</para>
    /// labels<para>"Sector"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/Sector">http://dev.poderopedia.com/vocab/Sector</seealso>
    let Sector = Prefixed_Name(poder, "Sector") |> PrefixedName

    /// <summary>
    ///   <para>poder:SentimentalRelationshipConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Clase de los estados civiles en los que puede estar una persona"</para>
    ///   <para>"Class of possible marital status a person can be"</para>
    /// labels<para>"Marital Status"</para><para>"Estado civil"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/SentimentalRelationshipConnection">http://dev.poderopedia.com/vocab/SentimentalRelationshipConnection</seealso>
    let SentimentalRelationshipConnection =
        Prefixed_Name(poder, "SentimentalRelationshipConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:ShortBiography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Descripción abreviada de una persona, organización, etc"</para>
    ///   <para>"Short description of a person, organization, etc"</para>
    /// labels<para>"Biografía corta"</para><para>"Short biography"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/ShortBiography">http://dev.poderopedia.com/vocab/ShortBiography</seealso>
    let ShortBiography = Prefixed_Name(poder, "ShortBiography") |> PrefixedName
    /// <summary>
    ///   <para>poder:SocialConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connection between a two people, like friendship, acquaintances, etc."</para>
    ///   <para>"Relación entre dos personas descritas con un contexto (amistad, conocidos, etc)"</para>
    /// labels<para>"Social connection"</para><para>"Conexión social"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/SocialConnection">http://dev.poderopedia.com/vocab/SocialConnection</seealso>
    let SocialConnection = Prefixed_Name(poder, "SocialConnection") |> PrefixedName
    /// <summary>
    ///   <para>poder:SourcedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Clase abstracta de caulquier entidad cuya información tenga una fuente"</para>
    ///   <para>"Abstract class  of any entity that has a source where its information was taken from"</para>
    /// labels<para>"Sourced Entity"</para><para>"Entidad con fuente"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/SourcedEntity">http://dev.poderopedia.com/vocab/SourcedEntity</seealso>
    let SourcedEntity = Prefixed_Name(poder, "SourcedEntity") |> PrefixedName

    /// <summary>
    ///   <para>poder:StudentEducationalConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Estudiante"</para><para>"Student"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/StudentEducationalConnection">http://dev.poderopedia.com/vocab/StudentEducationalConnection</seealso>
    let StudentEducationalConnection =
        Prefixed_Name(poder, "StudentEducationalConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:SympathizerAssociationConnection</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Sympathizer"</para><para>"Simpatizante"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/SympathizerAssociationConnection">http://dev.poderopedia.com/vocab/SympathizerAssociationConnection</seealso>
    let SympathizerAssociationConnection =
        Prefixed_Name(poder, "SympathizerAssociationConnection") |> PrefixedName

    /// <summary>
    ///   <para>poder:WorkConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The connection between an entity and an Educational Organization (university, school, etc)"</para>
    ///   <para>"La relación entre una persona y una organización académica (colegio, universidad, etc)"</para>
    /// labels<para>"Economic Connection"</para><para>"Conexión económica"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/WorkConnection">http://dev.poderopedia.com/vocab/WorkConnection</seealso>
    let WorkConnection = Prefixed_Name(poder, "WorkConnection") |> PrefixedName
    /// <summary>
    ///   <para>poder:WorkRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Puesto de trabajo"</para><para>"Work role"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/WorkRole">http://dev.poderopedia.com/vocab/WorkRole</seealso>
    let WorkRole = Prefixed_Name(poder, "WorkRole") |> PrefixedName

    /// <summary>
    ///   <para>poder:academicParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An academic organization (school, university) who is part of this connection"</para>
    ///   <para>"Una organización académica (escuela, universidad) que participa de esta conexión"</para>
    /// labels<para>"Academic organization participant"</para><para>"Organización académica participante"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/academicParticipant">http://dev.poderopedia.com/vocab/academicParticipant</seealso>
    let academicParticipant =
        Prefixed_Name(poder, "academicParticipant") |> PrefixedName

    /// <summary>
    ///   <para>poder:alias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Un alias de una persona"</para>
    ///   <para>"An alias for a person"</para>
    /// labels<para>"Alias"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/alias">http://dev.poderopedia.com/vocab/alias</seealso>
    let alias = Prefixed_Name(poder, "alias") |> PrefixedName
    /// <summary>
    ///   <para>poder:buyerCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Buyer"</para><para>"Comprador"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/buyerCompany">http://dev.poderopedia.com/vocab/buyerCompany</seealso>
    let buyerCompany = Prefixed_Name(poder, "buyerCompany") |> PrefixedName
    /// <summary>
    ///   <para>poder:ceo</para>
    /// </summary>
    /// <remarks>
    ///   <para>poder:WorkRole</para>
    ///
    /// labels<para>"Gerente General"</para><para>"CEO"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/ceo">http://dev.poderopedia.com/vocab/ceo</seealso>
    let ceo = Prefixed_Name(poder, "ceo") |> PrefixedName

    /// <summary>
    ///   <para>poder:commercialRepresentativesOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Relation between companies where one is the subsidiary of the second"</para>
    ///   <para>"Relación entre empresas donde la primera es la filial de la segunda"</para>
    /// labels<para>"Representatens comerciales de"</para><para>"Commercial representatives of"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/commercialRepresentativesOf">http://dev.poderopedia.com/vocab/commercialRepresentativesOf</seealso>
    let commercialRepresentativesOf =
        Prefixed_Name(poder, "commercialRepresentativesOf") |> PrefixedName

    /// <summary>
    ///   <para>poder:connectedVia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Entidad por la cual 2 personas se conocen (colegio, universidad, iglesia, etc.)"</para>
    ///   <para>"Entity from where two persons know each other (school, college, church, etc.)"</para>
    /// labels<para>"Conectados via"</para><para>"Connected via"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/connectedVia">http://dev.poderopedia.com/vocab/connectedVia</seealso>
    let connectedVia = Prefixed_Name(poder, "connectedVia") |> PrefixedName
    /// <summary>
    ///   <para>poder:connectionEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Date when connection between entities ended"</para>
    ///   <para>"Fecha cuando temrinó la conexión entre entidades"</para>
    /// labels<para>"Fecha de fin de connección"</para><para>"Connection end date"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/connectionEndDate">http://dev.poderopedia.com/vocab/connectionEndDate</seealso>
    let connectionEndDate = Prefixed_Name(poder, "connectionEndDate") |> PrefixedName

    /// <summary>
    ///   <para>poder:connectionStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Fecha cuando comenzó la conexión entre entidades"</para>
    ///   <para>"Date when connection between entities started"</para>
    /// labels<para>"Fecha de inicio de connección"</para><para>"Connection start date"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/connectionStartDate">http://dev.poderopedia.com/vocab/connectionStartDate</seealso>
    let connectionStartDate =
        Prefixed_Name(poder, "connectionStartDate") |> PrefixedName

    /// <summary>
    ///   <para>poder:countryOfResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Country where the organization's headquarters are located"</para>
    ///   <para>"Ubicación de los headquarters"</para>
    /// labels<para>"País de residencia"</para><para>"Country of residence"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/countryOfResidence">http://dev.poderopedia.com/vocab/countryOfResidence</seealso>
    let countryOfResidence = Prefixed_Name(poder, "countryOfResidence") |> PrefixedName
    /// <summary>
    ///   <para>poder:cto</para>
    /// </summary>
    /// <remarks>
    ///   <para>poder:WorkRole</para>
    ///
    /// labels<para>"CTO"</para><para>"Gerente de Tecnología"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/cto">http://dev.poderopedia.com/vocab/cto</seealso>
    let cto = Prefixed_Name(poder, "cto") |> PrefixedName

    /// <summary>
    ///   <para>poder:declarationOfInterests</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Declaración de intereses"</para><para>"Declaration of interests"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/declarationOfInterests">http://dev.poderopedia.com/vocab/declarationOfInterests</seealso>
    let declarationOfInterests =
        Prefixed_Name(poder, "declarationOfInterests") |> PrefixedName

    /// <summary>
    ///   <para>poder:declarationOfPatrimony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Declaración de Patrimonio"</para><para>"Declaration of Patrimony"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/declarationOfPatrimony">http://dev.poderopedia.com/vocab/declarationOfPatrimony</seealso>
    let declarationOfPatrimony =
        Prefixed_Name(poder, "declarationOfPatrimony") |> PrefixedName

    /// <summary>
    ///   <para>poder:depiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Una representación visual de una persona u organización"</para>
    ///   <para>"A depiction of some organization or person."</para>
    /// labels<para>"imagen"</para><para>"depiction"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/depiction">http://dev.poderopedia.com/vocab/depiction</seealso>
    let depiction = Prefixed_Name(poder, "depiction") |> PrefixedName
    /// <summary>
    ///   <para>poder:firstLastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Primer apellido"</para><para>"First last name"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/firstLastName">http://dev.poderopedia.com/vocab/firstLastName</seealso>
    let firstLastName = Prefixed_Name(poder, "firstLastName") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasAcademicOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Entity from where two persons know each other (school, college, church, etc.)"</para>
    ///   <para>"Entidad por la cual 2 personas se conocen (colegio, universidad, iglesia, etc.)"</para>
    /// labels<para>"Academic organization"</para><para>"Organización académica"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasAcademicOrganization">http://dev.poderopedia.com/vocab/hasAcademicOrganization</seealso>
    let hasAcademicOrganization =
        Prefixed_Name(poder, "hasAcademicOrganization") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasAlternativeMainSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Sector principal no listado en hasMainSector"</para>
    ///   <para>"Main sector not listed in hasMainSector"</para>
    /// labels<para>"Has other main sector"</para><para>"Otro sector principal"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasAlternativeMainSector">http://dev.poderopedia.com/vocab/hasAlternativeMainSector</seealso>
    let hasAlternativeMainSector =
        Prefixed_Name(poder, "hasAlternativeMainSector") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasAlternativeOtherSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Otro sector no listado en hasOtherSector"</para>
    ///   <para>"Other sector not listed in hasOtherSector"</para>
    /// labels<para>"Has other main sector"</para><para>"Otro sector secundario"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasAlternativeOtherSector">http://dev.poderopedia.com/vocab/hasAlternativeOtherSector</seealso>
    let hasAlternativeOtherSector =
        Prefixed_Name(poder, "hasAlternativeOtherSector") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasAnotherPhilantropySector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sectors related to NGOs not lister previously"</para>
    ///   <para>"Sectores relationados a ONGs no listados"</para>
    /// labels<para>"Has another Non Government Organization Sector"</para><para>"Tiene otro Sector Org No Gubernamentales]"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasAnotherPhilantropySector">http://dev.poderopedia.com/vocab/hasAnotherPhilantropySector</seealso>
    let hasAnotherPhilantropySector =
        Prefixed_Name(poder, "hasAnotherPhilantropySector") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasAuntOrUncle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes relation where a person (object) is the sibling of one of the parents of this person"</para>
    ///   <para>"Describe la relación donde una persona (objeto) es el/la hermano/a de uno de los padres de esta persona"</para>
    /// labels<para>"Has Aunt or Uncle"</para><para>"Tío/a"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasAuntOrUncle">http://dev.poderopedia.com/vocab/hasAuntOrUncle</seealso>
    let hasAuntOrUncle = Prefixed_Name(poder, "hasAuntOrUncle") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describe la relación donde una persona (objeto) es el padre o madre de esta persona"</para>
    ///   <para>"Describes relation where a person (object) is a parent of this person"</para>
    /// labels<para>"Has Parent"</para><para>"Padre/Madre"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasChild">http://dev.poderopedia.com/vocab/hasChild</seealso>
    let hasChild = Prefixed_Name(poder, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasCousin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Describe la relación donde una persona (objeto) es primo o prima de esta persona"</para>
    ///   <para>"Describes relation where a person (object) is the cousin (their parents are siblings) of this person"</para>
    /// labels<para>"Primo/a"</para><para>"Has cousin"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasCousin">http://dev.poderopedia.com/vocab/hasCousin</seealso>
    let hasCousin = Prefixed_Name(poder, "hasCousin") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasDocumentURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"URL donde se encuentra el documento"</para>
    ///   <para>"URL where the document is located"</para>
    /// labels<para>"URL de documento"</para><para>"Document URL"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasDocumentURL">http://dev.poderopedia.com/vocab/hasDocumentURL</seealso>
    let hasDocumentURL = Prefixed_Name(poder, "hasDocumentURL") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Asocia un agente con documentación relacionada"</para>
    ///   <para>"Associates an agent with related documentation"</para>
    /// labels<para>"Has documentation"</para><para>"Tiene documentación"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasDocumentation">http://dev.poderopedia.com/vocab/hasDocumentation</seealso>
    let hasDocumentation = Prefixed_Name(poder, "hasDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasEconomicOrganizationParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Organization or company associated with this economic connection"</para>
    ///   <para>"Organización o empresa relacionada con esta connexión económica"</para>
    /// labels<para>"Organization/Company involved"</para><para>"Organización/empresa relacionada"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasEconomicOrganizationParticipant">http://dev.poderopedia.com/vocab/hasEconomicOrganizationParticipant</seealso>
    let hasEconomicOrganizationParticipant =
        Prefixed_Name(poder, "hasEconomicOrganizationParticipant") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasFinancialInformationYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Fecha de la información financiera"</para><para>"Date of financial information"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasFinancialInformationYear">http://dev.poderopedia.com/vocab/hasFinancialInformationYear</seealso>
    let hasFinancialInformationYear =
        Prefixed_Name(poder, "hasFinancialInformationYear") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Gender of this person"</para>
    ///   <para>"Sexo de esta persona"</para>
    /// labels<para>"Gender"</para><para>"Sexo"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasGender">http://dev.poderopedia.com/vocab/hasGender</seealso>
    let hasGender = Prefixed_Name(poder, "hasGender") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasGrandChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Describe la relación donde una persona (objeto) es hijo/a del hijo/a de la persona"</para>
    ///   <para>"Describes relation where a person (object) is the child of the person's child"</para>
    /// labels<para>"Has grandchild"</para><para>"Nieto/a"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasGrandChild">http://dev.poderopedia.com/vocab/hasGrandChild</seealso>
    let hasGrandChild = Prefixed_Name(poder, "hasGrandChild") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasGrandparent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Describe la relación donde una persona (objeto) es padre o madre del padre o madre de la persona"</para>
    ///   <para>"Describes relation where a person (object) is the parent of the person's parent"</para>
    /// labels<para>"Abuelo/a"</para><para>"Has grandparent"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasGrandparent">http://dev.poderopedia.com/vocab/hasGrandparent</seealso>
    let hasGrandparent = Prefixed_Name(poder, "hasGrandparent") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasLegalConstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Constitución legal"</para><para>"Legal constitution"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasLegalConstitution">http://dev.poderopedia.com/vocab/hasLegalConstitution</seealso>
    let hasLegalConstitution =
        Prefixed_Name(poder, "hasLegalConstitution") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasLogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Logo of the organization"</para>
    ///   <para>"Logo de la organización"</para>
    /// labels<para>"Logo"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasLogo">http://dev.poderopedia.com/vocab/hasLogo</seealso>
    let hasLogo = Prefixed_Name(poder, "hasLogo") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasLongBiography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Predicate</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Long biography"</para><para>"Biografía larga"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasLongBiography">http://dev.poderopedia.com/vocab/hasLongBiography</seealso>
    let hasLongBiography = Prefixed_Name(poder, "hasLongBiography") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasMainSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Sector principal relacionado con la organización"</para>
    ///   <para>"Main sector related to the organization"</para>
    /// labels<para>"Has main sector"</para><para>"Sector principal"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasMainSector">http://dev.poderopedia.com/vocab/hasMainSector</seealso>
    let hasMainSector = Prefixed_Name(poder, "hasMainSector") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Map"</para><para>"Mapa"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasMap">http://dev.poderopedia.com/vocab/hasMap</seealso>
    let hasMap = Prefixed_Name(poder, "hasMap") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasNieceOrNephew</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Describe la relación donde una persona (objeto) es el/la hijo/a de uno de los hermano/as de esta persona"</para>
    ///   <para>"Describes relation where a person (object) is the child of one of the siblings of this person"</para>
    /// labels<para>"Sobrino/a"</para><para>"Has niece or nephew"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasNieceOrNephew">http://dev.poderopedia.com/vocab/hasNieceOrNephew</seealso>
    let hasNieceOrNephew = Prefixed_Name(poder, "hasNieceOrNephew") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasNumberEmployees</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Number of Employees"</para><para>"Número de empleados"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasNumberEmployees">http://dev.poderopedia.com/vocab/hasNumberEmployees</seealso>
    let hasNumberEmployees = Prefixed_Name(poder, "hasNumberEmployees") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasNumericDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Has numerical datum"</para><para>"Tiene dato numérico"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasNumericDatum">http://dev.poderopedia.com/vocab/hasNumericDatum</seealso>
    let hasNumericDatum = Prefixed_Name(poder, "hasNumericDatum") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasOrganigramDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Documents describing the organigram this agent"</para>
    ///   <para>"Documentos que describen el organigrama este agente"</para>
    /// labels<para>"Documentación de organigrama"</para><para>"Organigram Documentation"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasOrganigramDocumentation">http://dev.poderopedia.com/vocab/hasOrganigramDocumentation</seealso>
    let hasOrganigramDocumentation =
        Prefixed_Name(poder, "hasOrganigramDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasOtherDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Miscelaneous document related to this agent"</para>
    ///   <para>"Documentos misceláneos relacionadas con este agente"</para>
    /// labels<para>"Other documentation"</para><para>"Otra documentación"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasOtherDocumentation">http://dev.poderopedia.com/vocab/hasOtherDocumentation</seealso>
    let hasOtherDocumentation =
        Prefixed_Name(poder, "hasOtherDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasOtherSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Other sector related to the organization"</para>
    ///   <para>"Otros sectores relacionados con la organización"</para>
    /// labels<para>"Sector secundario"</para><para>"Secondary sector"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasOtherSector">http://dev.poderopedia.com/vocab/hasOtherSector</seealso>
    let hasOtherSector = Prefixed_Name(poder, "hasOtherSector") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes relation where a person (object) is a parent of this person"</para>
    ///   <para>"Describe la relación donde una persona (objeto) es el padre o madre de esta persona"</para>
    /// labels<para>"Has Parent"</para><para>"Padre/Madre"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasParent">http://dev.poderopedia.com/vocab/hasParent</seealso>
    let hasParent = Prefixed_Name(poder, "hasParent") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasPhilantropySector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Sectors related to NGOs"</para>
    ///   <para>"Sectores relationados a ONGs"</para>
    /// labels<para>"Tiene área de filantropía"</para><para>"Has Philantropy Sector"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasPhilantropySector">http://dev.poderopedia.com/vocab/hasPhilantropySector</seealso>
    let hasPhilantropySector =
        Prefixed_Name(poder, "hasPhilantropySector") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasRelevantDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Fecha relevante a este dato (ej., fecha de publicación, última modificación, etc)"</para>
    ///   <para>"Date related to this data (e.g., release date, last modification, etc.)"</para>
    /// labels<para>"Fecha relevante"</para><para>"Relevant date"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasRelevantDate">http://dev.poderopedia.com/vocab/hasRelevantDate</seealso>
    let hasRelevantDate = Prefixed_Name(poder, "hasRelevantDate") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasSanctionDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Documents describing legal sanctions related to this agent"</para>
    ///   <para>"Documentos que describen sanciones legales relacionadas con este agente"</para>
    /// labels<para>"Documentación acerca de sanciones"</para><para>"Documents about sanctions"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasSanctionDocumentation">http://dev.poderopedia.com/vocab/hasSanctionDocumentation</seealso>
    let hasSanctionDocumentation =
        Prefixed_Name(poder, "hasSanctionDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>poder:hasShortBiography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Predicate</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Biografía corta"</para><para>"Short biography"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasShortBiography">http://dev.poderopedia.com/vocab/hasShortBiography</seealso>
    let hasShortBiography = Prefixed_Name(poder, "hasShortBiography") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasSibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Describes relation where a person (object) is the sibling (i.e., they have at least one parent in common) of this person"</para>
    ///   <para>"Describe la relación donde una persona (objeto) es el hermano o hermana (i.e, tienen al menos un padre en común) de esta persona"</para>
    /// labels<para>"Has sibling"</para><para>"Hermano/a"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasSibling">http://dev.poderopedia.com/vocab/hasSibling</seealso>
    let hasSibling = Prefixed_Name(poder, "hasSibling") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasSocialReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Un alias de una persona"</para>
    ///   <para>"An alias for a person"</para>
    /// labels<para>"Razón social"</para><para>"Name"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasSocialReason">http://dev.poderopedia.com/vocab/hasSocialReason</seealso>
    let hasSocialReason = Prefixed_Name(poder, "hasSocialReason") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Source where the information about a connection was obtained"</para>
    ///   <para>"Fuente de donde se obtuvo la información acerca de una conexión"</para>
    /// labels<para>"Source"</para><para>"Fuente"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasSource">http://dev.poderopedia.com/vocab/hasSource</seealso>
    let hasSource = Prefixed_Name(poder, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasSpouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connexión entre dos personas que establece un matrimonio, convivencia, unión civil, relación sentimental, etc."</para>
    ///   <para>"Connection between two people that establishes a marriage, domestic partnership, civil union, sentimental relationship, etc."</para>
    /// labels<para>"Spouse"</para><para>"Cónyuge"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasSpouse">http://dev.poderopedia.com/vocab/hasSpouse</seealso>
    let hasSpouse = Prefixed_Name(poder, "hasSpouse") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Person involved in an Education Connection"</para>
    ///   <para>"Persona en una conexión educacional"</para>
    /// labels<para>"Estudiante"</para><para>"Student"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasStudent">http://dev.poderopedia.com/vocab/hasStudent</seealso>
    let hasStudent = Prefixed_Name(poder, "hasStudent") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasTaxId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"ID que identifica a una organización o persona para efecto de los impuestos"</para>
    ///   <para>"ID that identifies an organization or person for tax purposes"</para>
    /// labels<para>"Tax ID"</para><para>"Rol Único Tributario (RUT)"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasTaxId">http://dev.poderopedia.com/vocab/hasTaxId</seealso>
    let hasTaxId = Prefixed_Name(poder, "hasTaxId") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasTickerSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Ticker symbol"</para><para>"Ticket de bolsa"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasTickerSymbol">http://dev.poderopedia.com/vocab/hasTickerSymbol</seealso>
    let hasTickerSymbol = Prefixed_Name(poder, "hasTickerSymbol") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Cualquier URL relaciontada con esa organización o persona (incluyendo social media, sitios corporativos, etc)"</para>
    ///   <para>"Any URL related to this organization or person (including social media, corporate sites, etc.)"</para>
    /// labels<para>"Página web"</para><para>"Has URL"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasUrl">http://dev.poderopedia.com/vocab/hasUrl</seealso>
    let hasUrl = Prefixed_Name(poder, "hasUrl") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>rdfs:DatatypeProperty</para>
    ///
    /// labels<para>"Valor en un reporte financiero"</para><para>"Value in a financial information"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasValue">http://dev.poderopedia.com/vocab/hasValue</seealso>
    let hasValue = Prefixed_Name(poder, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>poder:hasWorkRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Position or role of the person in this economic connection"</para>
    ///   <para>"Puesto o rol de la persona en esta connexión económica"</para>
    /// labels<para>"Work role"</para><para>"Relación laboral"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/hasWorkRole">http://dev.poderopedia.com/vocab/hasWorkRole</seealso>
    let hasWorkRole = Prefixed_Name(poder, "hasWorkRole") |> PrefixedName
    /// <summary>
    ///   <para>poder:mergeCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Propertym</para>
    ///
    /// labels<para>"Compañía fusionada"</para><para>"Merge company"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/mergeCompany">http://dev.poderopedia.com/vocab/mergeCompany</seealso>
    let mergeCompany = Prefixed_Name(poder, "mergeCompany") |> PrefixedName

    /// <summary>
    ///   <para>poder:newsEventParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Un evento noticioso que participa de esta conexión"</para>
    ///   <para>"A news event which is part of this connection"</para>
    /// labels<para>"A news event participant in this connection"</para><para>"Evento noticioso participante"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/newsEventParticipant">http://dev.poderopedia.com/vocab/newsEventParticipant</seealso>
    let newsEventParticipant =
        Prefixed_Name(poder, "newsEventParticipant") |> PrefixedName

    /// <summary>
    ///   <para>poder:organizationParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Una organización académica (escuela, universidad) que participa de esta conexión"</para>
    ///   <para>"An academic organization (school, university) who is part of this connection"</para>
    /// labels<para>"Organización participante"</para><para>"Participant organization"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/organizationParticipant">http://dev.poderopedia.com/vocab/organizationParticipant</seealso>
    let organizationParticipant =
        Prefixed_Name(poder, "organizationParticipant") |> PrefixedName

    /// <summary>
    ///   <para>poder:otherLastName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Other last name, different from the first one"</para>
    ///   <para>"Otro apellido, que no es el primero"</para>
    /// labels<para>"Other last name"</para><para>"Otro apellido"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/otherLastName">http://dev.poderopedia.com/vocab/otherLastName</seealso>
    let otherLastName = Prefixed_Name(poder, "otherLastName") |> PrefixedName
    /// <summary>
    ///   <para>poder:personParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Un miembro de una organización"</para>
    ///   <para>"A a member of an organization"</para>
    /// labels<para>"Persona miembro"</para><para>"Member person"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/personParticipant">http://dev.poderopedia.com/vocab/personParticipant</seealso>
    let personParticipant = Prefixed_Name(poder, "personParticipant") |> PrefixedName

    /// <summary>
    ///   <para>poder:politicalParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A political organization who is part of this connection"</para>
    ///   <para>"Una organización política que participa de esta conexión"</para>
    /// labels<para>"Political Organizacion participant"</para><para>"Organización política participante"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/politicalParticipant">http://dev.poderopedia.com/vocab/politicalParticipant</seealso>
    let politicalParticipant =
        Prefixed_Name(poder, "politicalParticipant") |> PrefixedName

    /// <summary>
    ///   <para>poder:schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"PoderVocab: Un vocabulario para Poderopedia"</para><para>"PoderVocab: A vocabulary for Poderopedia"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/schema">http://dev.poderopedia.com/vocab/schema</seealso>
    let schema = Prefixed_Name(poder, "schema") |> PrefixedName

    /// <summary>
    ///   <para>poder:subsidiaryCompanyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between companies where one is the subsidiary of the second"</para>
    ///   <para>"Relación entre empresas donde la primera es la filial de la segunda"</para>
    /// labels<para>"Empresa filial de"</para><para>"Subsidiary company of"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/subsidiaryCompanyOf">http://dev.poderopedia.com/vocab/subsidiaryCompanyOf</seealso>
    let subsidiaryCompanyOf =
        Prefixed_Name(poder, "subsidiaryCompanyOf") |> PrefixedName

    /// <summary>
    ///   <para>poder:targetCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Target company"</para><para>"Compañía target"</para></remarks>
    /// <seealso href="http://dev.poderopedia.com/vocab/targetCompany">http://dev.poderopedia.com/vocab/targetCompany</seealso>
    let targetCompany = Prefixed_Name(poder, "targetCompany") |> PrefixedName
