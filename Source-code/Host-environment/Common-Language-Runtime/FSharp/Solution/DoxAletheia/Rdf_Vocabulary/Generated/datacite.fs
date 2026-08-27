namespace http.purl.org.spar.datacite.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module datacite =
    let _namespace_iri = Namespace_Iri datacite |> NamespaceIRI
    /// <summary>
    ///   <para>datacite:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/datacite/">http://purl.org/spar/datacite/</seealso>
    let _prefix_iri = Prefixed_Name(datacite, "") |> PrefixedName
    /// <summary>
    ///   <para>datacite:2021-09-24</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/datacite/2021-09-24">http://purl.org/spar/datacite/2021-09-24</seealso>
    let _2021_09_24 = Prefixed_Name(datacite, "2021-09-24") |> PrefixedName
    /// <summary>
    ///   <para>datacite:2022-09-15</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/datacite/2022-09-15">http://purl.org/spar/datacite/2022-09-15</seealso>
    let _2022_09_15 = Prefixed_Name(datacite, "2022-09-15") |> PrefixedName
    /// <summary>
    ///   <para>datacite:AgentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier that uniquely identities an individual agent, belonging to a particular identifier scheme specified by an individual within the class datacite:AgentIdentifierScheme (or any of its subclasses)."</para>
    /// labels<para>"agent identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/AgentIdentifier">http://purl.org/spar/datacite/AgentIdentifier</seealso>
    let AgentIdentifier = Prefixed_Name(datacite, "AgentIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datacite:AgentIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The identifier scheme used to identify an agent. Individual schemes are defines as members of its sub-classes."</para>
    /// labels<para>"agent identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/AgentIdentifierScheme">http://purl.org/spar/datacite/AgentIdentifierScheme</seealso>
    let AgentIdentifierScheme =
        Prefixed_Name(datacite, "AgentIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:AlternateResourceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier other than a DOI that is used as an alternative identifier to uniquely identifies the primary resource that is the subject of the DataCite metadata record, belonging to a particular scheme such as ISBN specified by an individual that is a member of the class datacite:ResourceIdentifierScheme. "</para>
    /// labels<para>"alternate resource identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/AlternateResourceIdentifier">http://purl.org/spar/datacite/AlternateResourceIdentifier</seealso>
    let AlternateResourceIdentifier =
        Prefixed_Name(datacite, "AlternateResourceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datacite:DescriptionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class permits classification of the type of description given to a resource described by the DataCite Metadata schema.  Individual members of the class conform to the five values allowed in the DataCite controlled list, namely:
    ///
    /// * abstract;
    /// * methods;
    /// * series-information;
    /// * table-of-content;
    /// * other."</para>
    /// labels<para>"description type"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/DescriptionType">http://purl.org/spar/datacite/DescriptionType</seealso>
    let DescriptionType = Prefixed_Name(datacite, "DescriptionType") |> PrefixedName
    /// <summary>
    ///   <para>datacite:FunderIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier that uniquely identities a funding agency, belonging to a particular scheme such as FundRef specified by an individual within the class datacite:FunderIdentifierScheme."</para>
    /// labels<para>"funder identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/FunderIdentifier">http://purl.org/spar/datacite/FunderIdentifier</seealso>
    let FunderIdentifier = Prefixed_Name(datacite, "FunderIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datacite:FunderIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The identifier scheme used to identify a funding agency. Individual schemes are defines as members of this class. At present, the only individual of this class is datacite:fundref."</para>
    /// labels<para>"funder identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/FunderIdentifierScheme">http://purl.org/spar/datacite/FunderIdentifierScheme</seealso>
    let FunderIdentifierScheme =
        Prefixed_Name(datacite, "FunderIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un identificador que identifica de forma única a una entidad - tal como una agencia de financiación, una persona y un recurso - que pertenece a un esquema particular, como los especificados por individuos de la clase datacite:IdentifierScheme."</para>
    ///   <para>"An identifier that uniquely identities an entity – such as a funding agency, a person and a resource – belonging to a particular scheme such as those specified by individuals of the class datacite:IdentifierScheme."</para>
    /// labels<para>"identificador"</para><para>"identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/Identifier">http://purl.org/spar/datacite/Identifier</seealso>
    let Identifier = Prefixed_Name(datacite, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>datacite:IdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The identifier scheme used to identify an entity such as a funding agency, a person or a resource. Individual schemes are defines as members of this class."</para>
    /// labels<para>"identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/IdentifierScheme">http://purl.org/spar/datacite/IdentifierScheme</seealso>
    let IdentifierScheme = Prefixed_Name(datacite, "IdentifierScheme") |> PrefixedName
    /// <summary>
    ///   <para>datacite:MetadataScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class that describe metadata schemes used for creating a metadata document referring to a certain resource.
    ///
    /// Neither a class for metadata documents nor a property linking a resource to its metadata document are not explicitly defined in this ontology. However, we recommend to use the class fabio:MetadataDocument (from http://purl.org/spar/fabio) and cito:citesAsMetadataDocument (from http://purl.org/spar/cito) for providing such descriptions. An example of use of such entities is shown as follows:
    ///
    ///     :my-resource
    ///         cito:citesAsMetadataDocument :my-resource-metadata .
    ///     :my-resource-metadata a fabio:MetadataDocument ;
    ///         datacite:usesMetadataScheme datacite:spar .
    ///
    /// In addition, if needed, it is possible to use the dataproperty fabio:hasURL (not included in this ontology as well) for defining the actual URL of a certain metadata scheme."</para>
    /// labels<para>"metadata scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/MetadataScheme">http://purl.org/spar/datacite/MetadataScheme</seealso>
    let MetadataScheme = Prefixed_Name(datacite, "MetadataScheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:OrganizationIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier that uniquely identities an individual organization, belonging to a particular identifier scheme such as ISNI specified by an individual within the class datacite:OrganizationIdentifierScheme."</para>
    /// labels<para>"organization identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/OrganizationIdentifier">http://purl.org/spar/datacite/OrganizationIdentifier</seealso>
    let OrganizationIdentifier =
        Prefixed_Name(datacite, "OrganizationIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datacite:OrganizationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The identifier scheme used to identify an organization. Individual schemes are defines as members of this class."</para>
    /// labels<para>"organization identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/OrganizationIdentifierScheme">http://purl.org/spar/datacite/OrganizationIdentifierScheme</seealso>
    let OrganizationIdentifierScheme =
        Prefixed_Name(datacite, "OrganizationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:PersonalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier that uniquely identities an individual person, belonging to a particular identifier scheme such as ORCID specified by an individual within the class datacite:PersonalIdentifierScheme."</para>
    /// labels<para>"personal identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/PersonalIdentifier">http://purl.org/spar/datacite/PersonalIdentifier</seealso>
    let PersonalIdentifier =
        Prefixed_Name(datacite, "PersonalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The identifier scheme used to identify a person.  Individual schemes are defines as members of this class."</para>
    /// labels<para>"personal identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/PersonalIdentifierScheme">http://purl.org/spar/datacite/PersonalIdentifierScheme</seealso>
    let PersonalIdentifierScheme =
        Prefixed_Name(datacite, "PersonalIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:PrimaryResourceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier that is used as the primary identifier to uniquely identifies the primary resource that is the subject of the DataCite metadata record.  Within the DataCite metadata record, a Digital Object Identifier is the only permitted primary resource identifier scheme, specified by the individual datacite:doi, that is a member of the class datacite:ResourceIdentifierScheme."</para>
    /// labels<para>"primary resource identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/PrimaryResourceIdentifier">http://purl.org/spar/datacite/PrimaryResourceIdentifier</seealso>
    let PrimaryResourceIdentifier =
        Prefixed_Name(datacite, "PrimaryResourceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datacite:ResourceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier that is used to uniquely identifies a resource."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"resource identifier"</para><para>"ResourceIdentifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/ResourceIdentifier">http://purl.org/spar/datacite/ResourceIdentifier</seealso>
    let ResourceIdentifier =
        Prefixed_Name(datacite, "ResourceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The identifier scheme used to identify a resource.  Individual schemes are defines as members of this class.  For DataCite, the only permitted identifier scheme for the primary resource identifier is the Digital Object Identifier."</para>
    /// labels<para>"resource identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/ResourceIdentifierScheme">http://purl.org/spar/datacite/ResourceIdentifierScheme</seealso>
    let ResourceIdentifierScheme =
        Prefixed_Name(datacite, "ResourceIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:DescriptionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A brief summary of a textual work, appearing at the beginning of the work and designed to act as the point-of-entry that will help the reader quickly to obtain an overview of the work's contents."</para>
    /// labels<para>"abstract"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/abstract">http://purl.org/spar/datacite/abstract</seealso>
    let abstract_ = Prefixed_Name(datacite, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>datacite:acm</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"ACM Digital Library author ID, which is resolvable using the following URL: https://dl.acm.org/profile/&lt;identifier&gt;."</para>
    /// labels<para>"acm"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/acm">http://purl.org/spar/datacite/acm</seealso>
    let acm = Prefixed_Name(datacite, "acm") |> PrefixedName
    /// <summary>
    ///   <para>datacite:ark</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Archival Resource Key."</para>
    /// labels<para>"ark"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/ark">http://purl.org/spar/datacite/ark</seealso>
    let ark = Prefixed_Name(datacite, "ark") |> PrefixedName
    /// <summary>
    ///   <para>datacite:arxiv</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Identifier for ArXiv (http://arxiv.org/), a open access repository of preprints, having the format arXiv:1207.2147."</para>
    /// labels<para>"arxiv"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/arxiv">http://purl.org/spar/datacite/arxiv</seealso>
    let arxiv = Prefixed_Name(datacite, "arxiv") |> PrefixedName
    /// <summary>
    ///   <para>datacite:bibcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"It is the Astrophysics Data System bibliographic codes, a standardized 19 character identifier according to the syntax "yyyyjjjjjvvvvmppppa"."</para>
    /// labels<para>"bibcode"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/bibcode">http://purl.org/spar/datacite/bibcode</seealso>
    let bibcode = Prefixed_Name(datacite, "bibcode") |> PrefixedName
    /// <summary>
    ///   <para>datacite:crossref</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:OrganizationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Crossref member identifier, which is resolvable from the following URL: https://api.crossref.org/members/&lt;identifier&gt;."</para>
    /// labels<para>"crossref"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/crossref">http://purl.org/spar/datacite/crossref</seealso>
    let crossref = Prefixed_Name(datacite, "crossref") |> PrefixedName
    /// <summary>
    ///   <para>datacite:datacite.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/datacite/datacite.png">http://purl.org/spar/datacite/datacite.png</seealso>
    let ``datacite.png`` = Prefixed_Name(datacite, "datacite.png") |> PrefixedName
    /// <summary>
    ///   <para>datacite:dblp</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"DBLP author identifier, which is resolvable from the following URL: https://dblp.org/pid/&lt;identifier&gt;."</para>
    /// labels<para>"dblp"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/dblp">http://purl.org/spar/datacite/dblp</seealso>
    let dblp = Prefixed_Name(datacite, "dblp") |> PrefixedName
    /// <summary>
    ///   <para>datacite:dblp-record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"DBLP publication identifier, which is resolvable from the following URL: https://dblp.org/rec/&lt;identifier&gt;."</para>
    /// labels<para>"dblp record"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/dblp-record">http://purl.org/spar/datacite/dblp-record</seealso>
    let dblp_record = Prefixed_Name(datacite, "dblp-record") |> PrefixedName
    /// <summary>
    ///   <para>datacite:dia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"The Digital Author Identification system assigns a unique number to all authors in the Netherlands research system."</para>
    /// labels<para>"dia"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/dia">http://purl.org/spar/datacite/dia</seealso>
    let dia = Prefixed_Name(datacite, "dia") |> PrefixedName
    /// <summary>
    ///   <para>datacite:dnb</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"DNB catalogue number, which is resolvable from the following URL: https://d-nb.info/&lt;identifier&gt;."</para>
    /// labels<para>"dnb"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/dnb">http://purl.org/spar/datacite/dnb</seealso>
    let dnb = Prefixed_Name(datacite, "dnb") |> PrefixedName
    /// <summary>
    ///   <para>datacite:doi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"Digital Object Identier"</para>
    /// labels<para>"doi"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/doi">http://purl.org/spar/datacite/doi</seealso>
    let doi = Prefixed_Name(datacite, "doi") |> PrefixedName
    /// <summary>
    ///   <para>datacite:ean13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"International Article Number"</para>
    /// labels<para>"ean13"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/ean13">http://purl.org/spar/datacite/ean13</seealso>
    let ean13 = Prefixed_Name(datacite, "ean13") |> PrefixedName
    /// <summary>
    ///   <para>datacite:eissn</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Electronic International Standard Serial Number"</para>
    /// labels<para>"eissn"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/eissn">http://purl.org/spar/datacite/eissn</seealso>
    let eissn = Prefixed_Name(datacite, "eissn") |> PrefixedName
    /// <summary>
    ///   <para>datacite:fundref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:FunderIdentifierScheme</para>
    ///   <para>"FundRef is a collaborative pilot project of scholarly publishers and funding agencies, facilitated by CrossRef, to provide a standard way of identifying and reporting funding sources for published scholarly research. "</para>
    /// labels<para>"fundref"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/fundref">http://purl.org/spar/datacite/fundref</seealso>
    let fundref = Prefixed_Name(datacite, "fundref") |> PrefixedName
    /// <summary>
    ///   <para>datacite:gepris</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"GEPRIS person identifier, which is resolvable from the following URL: http://gepris.dfg.de/gepris/person/&lt;identifier&gt;."</para>
    /// labels<para>"gepris"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/gepris">http://purl.org/spar/datacite/gepris</seealso>
    let gepris = Prefixed_Name(datacite, "gepris") |> PrefixedName
    /// <summary>
    ///   <para>datacite:github</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:AgentIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"GitHub username, which is resolvable from the following URL: https://github.com/&lt;identifier&gt;."</para>
    /// labels<para>"github"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/github">http://purl.org/spar/datacite/github</seealso>
    let github = Prefixed_Name(datacite, "github") |> PrefixedName
    /// <summary>
    ///   <para>datacite:gitlab</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"The identifier for GitLab Users."</para>
    /// labels<para>"GitLab user account"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/gitlab">http://purl.org/spar/datacite/gitlab</seealso>
    let gitlab = Prefixed_Name(datacite, "gitlab") |> PrefixedName
    /// <summary>
    ///   <para>datacite:gnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:IdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Gemeinsame Normdatei identifier, which is resolvable from the following URL: https://d-nb.info/gnd/&lt;identifier&gt;."</para>
    /// labels<para>"gnd"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/gnd">http://purl.org/spar/datacite/gnd</seealso>
    let gnd = Prefixed_Name(datacite, "gnd") |> PrefixedName
    /// <summary>
    ///   <para>datacite:google-scholar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"Google Scholar author identifier, which resolvable from the following URL:	https://scholar.google.com/citations?user=&lt;identifier&gt;."</para>
    /// labels<para>"google scholar"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/google-scholar">http://purl.org/spar/datacite/google-scholar</seealso>
    let google_scholar = Prefixed_Name(datacite, "google-scholar") |> PrefixedName
    /// <summary>
    ///   <para>datacite:handle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"The Handle system"</para>
    /// labels<para>"handle"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/handle">http://purl.org/spar/datacite/handle</seealso>
    let handle = Prefixed_Name(datacite, "handle") |> PrefixedName
    /// <summary>
    ///   <para>datacite:hasCreatorList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property allows one to specify the list of the creators of a certain resource."</para>
    /// labels<para>"has creator list"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/hasCreatorList">http://purl.org/spar/datacite/hasCreatorList</seealso>
    let hasCreatorList = Prefixed_Name(datacite, "hasCreatorList") |> PrefixedName
    /// <summary>
    ///   <para>datacite:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property permitting specification of an entity used to describe a resource."</para>
    /// labels<para>"has description"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/hasDescription">http://purl.org/spar/datacite/hasDescription</seealso>
    let hasDescription = Prefixed_Name(datacite, "hasDescription") |> PrefixedName

    /// <summary>
    ///   <para>datacite:hasDescriptionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property permitting specification of the type of description used to describe a resource, defined as an individual of the class datacite:DescriptionType from the DataCite controlled list of Abstract, SeriesInformation, TableOfContent and Other."</para>
    /// labels<para>"has description type"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/hasDescriptionType">http://purl.org/spar/datacite/hasDescriptionType</seealso>
    let hasDescriptionType =
        Prefixed_Name(datacite, "hasDescriptionType") |> PrefixedName

    /// <summary>
    ///   <para>datacite:hasGeneralResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property permitting specification of the general type of a resource, defined from the DataCite controlled list, namely:
    ///
    /// * dcmitype:MovingImage;
    /// * dcmitype:Collection;
    /// * dcmitype:Dataset;
    /// * dcmitype:Event;
    /// * dcmitype:dcmitype:StillImage;
    /// * dcmitype:InteractiveResource;
    /// * fabio:Model;
    /// * dcmitype:PhysicalObject;
    /// * dcmitype:Service;
    /// * dcmitype:Software;
    /// * dcmitype:Sound;
    /// * dcmitype:Text;
    /// * fabio:Workflow;
    /// * frbr:Endeavour.
    ///
    /// All the prefixes used here refer to external ontologies, i.e., DC Metadata Terms (dcmitype: http://purl.org/dc/dcmitype/), FaBiO (fabio: http://purl.org/spar/fabio/), and FRBR (frbr: http://purl.org/vocab/frbr/core#)."</para>
    /// labels<para>"has general resource type"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/hasGeneralResourceType">http://purl.org/spar/datacite/hasGeneralResourceType</seealso>
    let hasGeneralResourceType =
        Prefixed_Name(datacite, "hasGeneralResourceType") |> PrefixedName

    /// <summary>
    ///   <para>datacite:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"An object property specifying a datacite:Identifier that provides a unique identifer for the entity (either a funder, a person or a resource)."</para>
    /// labels<para>"has identifier"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/hasIdentifier">http://purl.org/spar/datacite/hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(datacite, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>datacite:ieee</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"IEEE Xplore author ID, which is resolvable from the following URL: https://ieeexplore.ieee.org/author/&lt;identifier&gt;."</para>
    /// labels<para>"ieee"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/ieee">http://purl.org/spar/datacite/ieee</seealso>
    let ieee = Prefixed_Name(datacite, "ieee") |> PrefixedName
    /// <summary>
    ///   <para>datacite:infouri</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Info URI scheme"</para>
    /// labels<para>"infouri"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/infouri">http://purl.org/spar/datacite/infouri</seealso>
    let infouri = Prefixed_Name(datacite, "infouri") |> PrefixedName
    /// <summary>
    ///   <para>datacite:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"International Standard Book Number"</para>
    /// labels<para>"isbn"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/isbn">http://purl.org/spar/datacite/isbn</seealso>
    let isbn = Prefixed_Name(datacite, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>datacite:isni</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:OrganizationIdentifierScheme</para>
    ///   <para>"International Standard Name Identifier scheme."</para>
    /// labels<para>"isni"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/isni">http://purl.org/spar/datacite/isni</seealso>
    let isni = Prefixed_Name(datacite, "isni") |> PrefixedName
    /// <summary>
    ///   <para>datacite:issn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"International Standard Serial Number"</para>
    /// labels<para>"issn"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/issn">http://purl.org/spar/datacite/issn</seealso>
    let issn = Prefixed_Name(datacite, "issn") |> PrefixedName
    /// <summary>
    ///   <para>datacite:istc</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"International Standard Text Code"</para>
    /// labels<para>"istc"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/istc">http://purl.org/spar/datacite/istc</seealso>
    let istc = Prefixed_Name(datacite, "istc") |> PrefixedName
    /// <summary>
    ///   <para>datacite:jst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"Japanese Science and Technology Agency identifier scheme"</para>
    /// labels<para>"jst"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/jst">http://purl.org/spar/datacite/jst</seealso>
    let jst = Prefixed_Name(datacite, "jst") |> PrefixedName
    /// <summary>
    ///   <para>datacite:lattes</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:AgentIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Lattes Platform number, which is resolvable from the following URL: http://lattes.cnpq.br/&lt;identifier&gt;."</para>
    /// labels<para>"lattes"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/lattes">http://purl.org/spar/datacite/lattes</seealso>
    let lattes = Prefixed_Name(datacite, "lattes") |> PrefixedName
    /// <summary>
    ///   <para>datacite:linkedin</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:AgentIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LinkedIn personal profile identifier, which is resolvable from the following URL: https://www.linkedin.com/in/&lt;identifier&gt;."</para>
    /// labels<para>"linkedin"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/linkedin">http://purl.org/spar/datacite/linkedin</seealso>
    let linkedin = Prefixed_Name(datacite, "linkedin") |> PrefixedName
    /// <summary>
    ///   <para>datacite:lissn</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Linking International Standard Serial Number"</para>
    /// labels<para>"lissn"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/lissn">http://purl.org/spar/datacite/lissn</seealso>
    let lissn = Prefixed_Name(datacite, "lissn") |> PrefixedName
    /// <summary>
    ///   <para>datacite:loc</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:IdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Library of Congress authority identifier, which is resolvable from the following URL: https://id.loc.gov/authorities/&lt;identifier&gt;."</para>
    /// labels<para>"loc"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/loc">http://purl.org/spar/datacite/loc</seealso>
    let loc = Prefixed_Name(datacite, "loc") |> PrefixedName

    /// <summary>
    ///   <para>datacite:local-funder-identifier-scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:FunderIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A funder identifier scheme that provides local funder identifiers that are unique in their local environment and understood by the person submitting the metadata."</para>
    /// labels<para>"local funder identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/local-funder-identifier-scheme">http://purl.org/spar/datacite/local-funder-identifier-scheme</seealso>
    let local_funder_identifier_scheme =
        Prefixed_Name(datacite, "local-funder-identifier-scheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:local-organization-identifier-scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:OrganizationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An organization identifier scheme that provides local organization identifiers that are unique in their local environment and understood by the person submitting the metadata."</para>
    /// labels<para>"local organization identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/local-organization-identifier-scheme">http://purl.org/spar/datacite/local-organization-identifier-scheme</seealso>
    let local_organization_identifier_scheme =
        Prefixed_Name(datacite, "local-organization-identifier-scheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:local-personal-identifier-scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A personal identifier scheme that provides local personal identifiers that are unique in their local environment and understood by the person submitting the metadata."</para>
    /// labels<para>"local personal identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/local-personal-identifier-scheme">http://purl.org/spar/datacite/local-personal-identifier-scheme</seealso>
    let local_personal_identifier_scheme =
        Prefixed_Name(datacite, "local-personal-identifier-scheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:local-resource-identifier-scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A resource identifier scheme that provides local resource identifiers that are unique in their local environment and understood by the person submitting the metadata."</para>
    /// labels<para>"local resource identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/local-resource-identifier-scheme">http://purl.org/spar/datacite/local-resource-identifier-scheme</seealso>
    let local_resource_identifier_scheme =
        Prefixed_Name(datacite, "local-resource-identifier-scheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:lsid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"Life Science Identifier"</para>
    /// labels<para>"lsid"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/lsid">http://purl.org/spar/datacite/lsid</seealso>
    let lsid = Prefixed_Name(datacite, "lsid") |> PrefixedName
    /// <summary>
    ///   <para>datacite:math-genealogy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"Mathematics Genealogy Project identifier, which is resolvable from the following URL: https://mathgenealogy.org/id.php?id=&lt;identifier&gt;."</para>
    /// labels<para>"math genealogy"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/math-genealogy">http://purl.org/spar/datacite/math-genealogy</seealso>
    let math_genealogy = Prefixed_Name(datacite, "math-genealogy") |> PrefixedName
    /// <summary>
    ///   <para>datacite:methods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:DescriptionType</para>
    ///   <para>"A description in a research paper documenting the specialized methods used in the work described."</para>
    /// labels<para>"methods"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/methods">http://purl.org/spar/datacite/methods</seealso>
    let methods = Prefixed_Name(datacite, "methods") |> PrefixedName

    /// <summary>
    ///   <para>datacite:national-insurance-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"United Kingdom National Insurance Number scheme."</para>
    /// labels<para>"national insurance number"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/national-insurance-number">http://purl.org/spar/datacite/national-insurance-number</seealso>
    let national_insurance_number =
        Prefixed_Name(datacite, "national-insurance-number") |> PrefixedName

    /// <summary>
    ///   <para>datacite:nihmsid</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"NIH Manuscript Submission Identifier"</para>
    /// labels<para>"nihmsid"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/nihmsid">http://purl.org/spar/datacite/nihmsid</seealso>
    let nihmsid = Prefixed_Name(datacite, "nihmsid") |> PrefixedName
    /// <summary>
    ///   <para>datacite:nii</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"National Individual Identifier scheme."</para>
    /// labels<para>"nii"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/nii">http://purl.org/spar/datacite/nii</seealso>
    let nii = Prefixed_Name(datacite, "nii") |> PrefixedName
    /// <summary>
    ///   <para>datacite:oci</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"Open Citation Identifier."</para>
    /// labels<para>"oci"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/oci">http://purl.org/spar/datacite/oci</seealso>
    let oci = Prefixed_Name(datacite, "oci") |> PrefixedName
    /// <summary>
    ///   <para>datacite:oclc</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"OCLC control number, which is resolvable from the following URL: https://www.worldcat.org/oclc/&lt;identifier&gt;."</para>
    /// labels<para>"oclc"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/oclc">http://purl.org/spar/datacite/oclc</seealso>
    let oclc = Prefixed_Name(datacite, "oclc") |> PrefixedName
    /// <summary>
    ///   <para>datacite:openalex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:IdentifierScheme</para>
    ///   <para>"The primary key for all entities included in OpenAlex.
    ///
    /// The OpenAlex ID has two parts. The first part is the base, that is always https://openalex.org/. The second part is the key, i.e. the unique primary key that identifies a given resource in our database. The key starts with a letter that tells us the kind of entity: W(ork), A(uthor), V(enue), I(nstitution), or C(oncept). In addition, the IDs are not case-sensitive, so w2741809807 is just as valid as W2741809807."</para>
    /// labels<para>"OpenAlex ID"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/openalex">http://purl.org/spar/datacite/openalex</seealso>
    let openalex = Prefixed_Name(datacite, "openalex") |> PrefixedName
    /// <summary>
    ///   <para>datacite:openid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"OpenID is an open standard that describes how users can be authenticated in a decentralized manner, eliminating the need for centralized registration services. "</para>
    /// labels<para>"openid"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/openid">http://purl.org/spar/datacite/openid</seealso>
    let openid = Prefixed_Name(datacite, "openid") |> PrefixedName
    /// <summary>
    ///   <para>datacite:orcid</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:AgentIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Open Researcher and Contributor Identifier."</para>
    /// labels<para>"orcid"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/orcid">http://purl.org/spar/datacite/orcid</seealso>
    let orcid = Prefixed_Name(datacite, "orcid") |> PrefixedName
    /// <summary>
    ///   <para>datacite:other</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:DescriptionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A catch-all description type required by the DataCite Metadata Schema to characterize description types that are not abstracts, series information or tables of content."</para>
    /// labels<para>"other"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/other">http://purl.org/spar/datacite/other</seealso>
    let other = Prefixed_Name(datacite, "other") |> PrefixedName
    /// <summary>
    ///   <para>datacite:pii</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Pulisher Item Identifier scheme."</para>
    /// labels<para>"pii"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/pii">http://purl.org/spar/datacite/pii</seealso>
    let pii = Prefixed_Name(datacite, "pii") |> PrefixedName
    /// <summary>
    ///   <para>datacite:pmcid</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"PubMed Central Identifier"</para>
    /// labels<para>"pmcid"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/pmcid">http://purl.org/spar/datacite/pmcid</seealso>
    let pmcid = Prefixed_Name(datacite, "pmcid") |> PrefixedName
    /// <summary>
    ///   <para>datacite:pmid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"PubMed Identifier"</para>
    /// labels<para>"pmid"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/pmid">http://purl.org/spar/datacite/pmid</seealso>
    let pmid = Prefixed_Name(datacite, "pmid") |> PrefixedName
    /// <summary>
    ///   <para>datacite:purl</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Persistent Uniform Resource Locator"</para>
    /// labels<para>"purl"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/purl">http://purl.org/spar/datacite/purl</seealso>
    let purl = Prefixed_Name(datacite, "purl") |> PrefixedName
    /// <summary>
    ///   <para>datacite:repec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"RePEc Short identifier, which is resolvable from the following URL: https://authors.repec.org/pro/&lt;identifier&gt;."</para>
    /// labels<para>"repec"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/repec">http://purl.org/spar/datacite/repec</seealso>
    let repec = Prefixed_Name(datacite, "repec") |> PrefixedName
    /// <summary>
    ///   <para>datacite:research-gate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"ResearchGate profile identifier, which is resolvable from the following URL: https://www.researchgate.net/profile/&lt;identifier&gt;."</para>
    /// labels<para>"research gate"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/research-gate">http://purl.org/spar/datacite/research-gate</seealso>
    let research_gate = Prefixed_Name(datacite, "research-gate") |> PrefixedName
    /// <summary>
    ///   <para>datacite:researcherid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"ResearcherID is an identifying system for scientific authors created and owned by Thomson Reuters."</para>
    /// labels<para>"researcherid"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/researcherid">http://purl.org/spar/datacite/researcherid</seealso>
    let researcherid = Prefixed_Name(datacite, "researcherid") |> PrefixedName
    /// <summary>
    ///   <para>datacite:ror</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:OrganizationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Research Organization Registry Community identifier, which is resolvable from the following URL: https://ror.org/&lt;identifier&gt;."</para>
    /// labels<para>"ror"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/ror">http://purl.org/spar/datacite/ror</seealso>
    let ror = Prefixed_Name(datacite, "ror") |> PrefixedName
    /// <summary>
    ///   <para>datacite:scigraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:IdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The identifier used for referring to entities in the Springer Nature SciGraph dataset."</para>
    /// labels<para>"SciGraph ID"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/scigraph">http://purl.org/spar/datacite/scigraph</seealso>
    let scigraph = Prefixed_Name(datacite, "scigraph") |> PrefixedName

    /// <summary>
    ///   <para>datacite:series-information</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:DescriptionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Used to charactierize a description of a resource that is part of a series."</para>
    /// labels<para>"series information"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/series-information">http://purl.org/spar/datacite/series-information</seealso>
    let series_information =
        Prefixed_Name(datacite, "series-information") |> PrefixedName

    /// <summary>
    ///   <para>datacite:sici</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Serial Item and Contribution Identifier"</para>
    /// labels<para>"sici"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/sici">http://purl.org/spar/datacite/sici</seealso>
    let sici = Prefixed_Name(datacite, "sici") |> PrefixedName

    /// <summary>
    ///   <para>datacite:social-security-number</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"United States of America social security number scheme"</para>
    /// labels<para>"social security number"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/social-security-number">http://purl.org/spar/datacite/social-security-number</seealso>
    let social_security_number =
        Prefixed_Name(datacite, "social-security-number") |> PrefixedName

    /// <summary>
    ///   <para>datacite:spar</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:MetadataScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Semantic Publishing and Referencing Ontologies, a.k.a. SPAR Ontologies, form a suite of orthogonal and complementary OWL 2 DL ontology modules for the creation of comprehensive machine-readable RDF metadata for every aspect of semantic publishing and referencing: document description, bibliographic resource identifiers, types of citations and related contexts, bibliographic references, document parts and status, agents' roles and contributions, bibliometric data and workflow processes."</para>
    /// labels<para>"SPAR Ontologies"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/spar">http://purl.org/spar/datacite/spar</seealso>
    let spar = Prefixed_Name(datacite, "spar") |> PrefixedName
    /// <summary>
    ///   <para>datacite:table-of-content</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:DescriptionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A table of content giving information about the content of a resource, appearing before the body text.  Where the resource is a journal or magazine issue, the table of content lists the constituent items contained in that issue, typically by title, authors and first page number."</para>
    /// labels<para>"table of content"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/table-of-content">http://purl.org/spar/datacite/table-of-content</seealso>
    let table_of_content = Prefixed_Name(datacite, "table-of-content") |> PrefixedName
    /// <summary>
    ///   <para>datacite:twitter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:AgentIdentifierScheme</para>
    ///   <para>"Twitter handle, which is resolvable from the following URL: https://twitter.com/&lt;identifier&gt;."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/datacite/twitter">http://purl.org/spar/datacite/twitter</seealso>
    let twitter = Prefixed_Name(datacite, "twitter") |> PrefixedName
    /// <summary>
    ///   <para>datacite:upc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"Universal Product Code"</para>
    /// labels<para>"upc"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/upc">http://purl.org/spar/datacite/upc</seealso>
    let upc = Prefixed_Name(datacite, "upc") |> PrefixedName
    /// <summary>
    ///   <para>datacite:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Uniform Resource Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uri"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/uri">http://purl.org/spar/datacite/uri</seealso>
    let uri = Prefixed_Name(datacite, "uri") |> PrefixedName
    /// <summary>
    ///   <para>datacite:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Uniform Resource Locator."</para>
    /// labels<para>"url"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/url">http://purl.org/spar/datacite/url</seealso>
    let url = Prefixed_Name(datacite, "url") |> PrefixedName
    /// <summary>
    ///   <para>datacite:urn</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Uniform Resource Name."</para>
    /// labels<para>"urn"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/urn">http://purl.org/spar/datacite/urn</seealso>
    let urn = Prefixed_Name(datacite, "urn") |> PrefixedName

    /// <summary>
    ///   <para>datacite:usesIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property permitting specification of the identifier scheme used to provide the identifier for an entity – either a funder, a person or a resource – defined as an individual of the class datacite:IdentifierScheme."</para>
    /// labels<para>"uses identifier scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/usesIdentifierScheme">http://purl.org/spar/datacite/usesIdentifierScheme</seealso>
    let usesIdentifierScheme =
        Prefixed_Name(datacite, "usesIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:usesMetadataScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The link between a metadata document and the scheme followed for creating metadata."</para>
    /// labels<para>"uses metadata scheme"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/usesMetadataScheme">http://purl.org/spar/datacite/usesMetadataScheme</seealso>
    let usesMetadataScheme =
        Prefixed_Name(datacite, "usesMetadataScheme") |> PrefixedName

    /// <summary>
    ///   <para>datacite:viaf</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Virtual International Authority File is an international authority file created by amalagamating the national authority files of several national libraries and operated by the Online Computer Library Center (OCLC).  It contains information about many topics including personal names."</para>
    /// labels<para>"viaf"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/viaf">http://purl.org/spar/datacite/viaf</seealso>
    let viaf = Prefixed_Name(datacite, "viaf") |> PrefixedName
    /// <summary>
    ///   <para>datacite:wikidata</para>
    /// </summary>
    /// <remarks>
    ///   <para>datacite:IdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Wikidata QID, which is resolvable from the following URL: https://www.wikidata.org/wiki/&lt;identifier&gt;."</para>
    /// labels<para>"wikidata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/wikidata">http://purl.org/spar/datacite/wikidata</seealso>
    let wikidata = Prefixed_Name(datacite, "wikidata") |> PrefixedName
    /// <summary>
    ///   <para>datacite:wikipedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:ResourceIdentifierScheme</para>
    ///   <para>"Wikipedia page name, which is resolvable from the following URL: https://en.wikipedia.org/wiki/&lt;identifier&gt;."</para>
    /// labels<para>"wikipedia"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/wikipedia">http://purl.org/spar/datacite/wikipedia</seealso>
    let wikipedia = Prefixed_Name(datacite, "wikipedia") |> PrefixedName
    /// <summary>
    ///   <para>datacite:zbmath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>datacite:PersonalIdentifierScheme</para>
    ///   <para>"zbMATH author identifier, which is resolvable from the following URL: https://zbmath.org/authors/?q=ai:&lt;identifier&gt;."</para>
    /// labels<para>"zbmath"</para></remarks>
    /// <seealso href="http://purl.org/spar/datacite/zbmath">http://purl.org/spar/datacite/zbmath</seealso>
    let zbmath = Prefixed_Name(datacite, "zbmath") |> PrefixedName
