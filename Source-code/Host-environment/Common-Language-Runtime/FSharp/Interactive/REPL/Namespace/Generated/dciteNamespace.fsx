#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dcite =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/datacite/" "dcite"
    let _2021_09_24 = _prefixId.prefix "2021-09-24"
    let _2022_09_15 = _prefixId.prefix "2022-09-15"
    /// <summary>
    ///   <para>rdfs:comment : An identifier that uniquely identities an individual agent, belonging to a particular identifier scheme specified by an individual within the class datacite:AgentIdentifierScheme (or any of its subclasses).</para>
    ///   <para>rdfs:label : agent identifier</para>
    ///   <a href="http://purl.org/spar/datacite/AgentIdentifier">dcite:AgentIdentifier</a>
    /// </summary>
    let AgentIdentifier = _prefixId.prefix "AgentIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The identifier scheme used to identify an agent. Individual schemes are defines as members of its sub-classes.</para>
    ///   <para>rdfs:label : agent identifier scheme</para>
    ///   <a href="http://purl.org/spar/datacite/AgentIdentifierScheme">dcite:AgentIdentifierScheme</a>
    /// </summary>
    let AgentIdentifierScheme = _prefixId.prefix "AgentIdentifierScheme"
    /// <summary>
    ///   <para>rdfs:comment : An identifier other than a DOI that is used as an alternative identifier to uniquely identifies the primary resource that is the subject of the DataCite metadata record, belonging to a particular scheme such as ISBN specified by an individual that is a member of the class datacite:ResourceIdentifierScheme. </para>
    ///   <para>rdfs:label : alternate resource identifier</para>
    ///   <a href="http://purl.org/spar/datacite/AlternateResourceIdentifier">dcite:AlternateResourceIdentifier</a>
    /// </summary>
    let AlternateResourceIdentifier = _prefixId.prefix "AlternateResourceIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : This class permits classification of the type of description given to a resource described by the DataCite Metadata schema.  Individual members of the class conform to the five values allowed in the DataCite controlled list, namely:
    ///
    /// * abstract;
    /// * methods;
    /// * series-information;
    /// * table-of-content;
    /// * other.</para>
    ///   <para>rdfs:label : description type</para>
    ///   <a href="http://purl.org/spar/datacite/DescriptionType">dcite:DescriptionType</a>
    /// </summary>
    let DescriptionType = _prefixId.prefix "DescriptionType"
    /// <summary>
    ///   <para>rdfs:comment : An identifier that uniquely identities a funding agency, belonging to a particular scheme such as FundRef specified by an individual within the class datacite:FunderIdentifierScheme.</para>
    ///   <para>rdfs:label : funder identifier</para>
    ///   <a href="http://purl.org/spar/datacite/FunderIdentifier">dcite:FunderIdentifier</a>
    /// </summary>
    let FunderIdentifier = _prefixId.prefix "FunderIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The identifier scheme used to identify a funding agency. Individual schemes are defines as members of this class. At present, the only individual of this class is datacite:fundref.</para>
    ///   <para>rdfs:label : funder identifier scheme</para>
    ///   <a href="http://purl.org/spar/datacite/FunderIdentifierScheme">dcite:FunderIdentifierScheme</a>
    /// </summary>
    let FunderIdentifierScheme = _prefixId.prefix "FunderIdentifierScheme"
    /// <summary>
    ///   <para>rdfs:comment : An identifier that uniquely identities an entity – such as a funding agency, a person and a resource – belonging to a particular scheme such as those specified by individuals of the class datacite:IdentifierScheme.</para>
    ///   <para>rdfs:label : identifier</para>
    ///   <a href="http://purl.org/spar/datacite/Identifier">dcite:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>rdfs:comment : The identifier scheme used to identify an entity such as a funding agency, a person or a resource. Individual schemes are defines as members of this class.</para>
    ///   <para>rdfs:label : identifier scheme</para>
    ///   <a href="http://purl.org/spar/datacite/IdentifierScheme">dcite:IdentifierScheme</a>
    /// </summary>
    let IdentifierScheme = _prefixId.prefix "IdentifierScheme"
    /// <summary>
    ///   <para>rdfs:comment : The class that describe metadata schemes used for creating a metadata document referring to a certain resource.
    ///
    /// Neither a class for metadata documents nor a property linking a resource to its metadata document are not explicitly defined in this ontology. However, we recommend to use the class fabio:MetadataDocument (from http://purl.org/spar/fabio) and cito:citesAsMetadataDocument (from http://purl.org/spar/cito) for providing such descriptions. An example of use of such entities is shown as follows:
    ///
    ///     :my-resource
    ///         cito:citesAsMetadataDocument :my-resource-metadata .
    ///     :my-resource-metadata a fabio:MetadataDocument ;
    ///         datacite:usesMetadataScheme datacite:spar .
    ///
    /// In addition, if needed, it is possible to use the dataproperty fabio:hasURL (not included in this ontology as well) for defining the actual URL of a certain metadata scheme.</para>
    ///   <para>rdfs:label : metadata scheme</para>
    ///   <a href="http://purl.org/spar/datacite/MetadataScheme">dcite:MetadataScheme</a>
    /// </summary>
    let MetadataScheme = _prefixId.prefix "MetadataScheme"
    /// <summary>
    ///   <para>rdfs:comment : An identifier that uniquely identities an individual organization, belonging to a particular identifier scheme such as ISNI specified by an individual within the class datacite:OrganizationIdentifierScheme.</para>
    ///   <para>rdfs:label : organization identifier</para>
    ///   <a href="http://purl.org/spar/datacite/OrganizationIdentifier">dcite:OrganizationIdentifier</a>
    /// </summary>
    let OrganizationIdentifier = _prefixId.prefix "OrganizationIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The identifier scheme used to identify an organization. Individual schemes are defines as members of this class.</para>
    ///   <para>rdfs:label : organization identifier scheme</para>
    ///   <a href="http://purl.org/spar/datacite/OrganizationIdentifierScheme">dcite:OrganizationIdentifierScheme</a>
    /// </summary>
    let OrganizationIdentifierScheme = _prefixId.prefix "OrganizationIdentifierScheme"
    /// <summary>
    ///   <para>rdfs:comment : An identifier that uniquely identities an individual person, belonging to a particular identifier scheme such as ORCID specified by an individual within the class datacite:PersonalIdentifierScheme.</para>
    ///   <para>rdfs:label : personal identifier</para>
    ///   <a href="http://purl.org/spar/datacite/PersonalIdentifier">dcite:PersonalIdentifier</a>
    /// </summary>
    let PersonalIdentifier = _prefixId.prefix "PersonalIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The identifier scheme used to identify a person.  Individual schemes are defines as members of this class.</para>
    ///   <para>rdfs:label : personal identifier scheme</para>
    ///   <a href="http://purl.org/spar/datacite/PersonalIdentifierScheme">dcite:PersonalIdentifierScheme</a>
    /// </summary>
    let PersonalIdentifierScheme = _prefixId.prefix "PersonalIdentifierScheme"
    /// <summary>
    ///   <para>rdfs:comment : An identifier that is used as the primary identifier to uniquely identifies the primary resource that is the subject of the DataCite metadata record.  Within the DataCite metadata record, a Digital Object Identifier is the only permitted primary resource identifier scheme, specified by the individual datacite:doi, that is a member of the class datacite:ResourceIdentifierScheme.</para>
    ///   <para>rdfs:label : primary resource identifier</para>
    ///   <a href="http://purl.org/spar/datacite/PrimaryResourceIdentifier">dcite:PrimaryResourceIdentifier</a>
    /// </summary>
    let PrimaryResourceIdentifier = _prefixId.prefix "PrimaryResourceIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : An identifier that is used to uniquely identifies a resource.</para>
    ///   <para>rdfs:label : resource identifier</para>
    ///   <a href="http://purl.org/spar/datacite/ResourceIdentifier">dcite:ResourceIdentifier</a>
    /// </summary>
    let ResourceIdentifier = _prefixId.prefix "ResourceIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The identifier scheme used to identify a resource.  Individual schemes are defines as members of this class.  For DataCite, the only permitted identifier scheme for the primary resource identifier is the Digital Object Identifier.</para>
    ///   <para>rdfs:label : resource identifier scheme</para>
    ///   <a href="http://purl.org/spar/datacite/ResourceIdentifierScheme">dcite:ResourceIdentifierScheme</a>
    /// </summary>
    let ResourceIdentifierScheme = _prefixId.prefix "ResourceIdentifierScheme"
    let abstract_ = _prefixId.prefix "abstract"
    let acm = _prefixId.prefix "acm"
    let ark = _prefixId.prefix "ark"
    let arxiv = _prefixId.prefix "arxiv"
    let bibcode = _prefixId.prefix "bibcode"
    let crossref = _prefixId.prefix "crossref"
    let ``datacite.png`` = _prefixId.prefix "datacite.png"
    let dblp = _prefixId.prefix "dblp"
    let dblp_record = _prefixId.prefix "dblp-record"
    let dia = _prefixId.prefix "dia"
    let dnb = _prefixId.prefix "dnb"
    let doi = _prefixId.prefix "doi"
    let ean13 = _prefixId.prefix "ean13"
    let eissn = _prefixId.prefix "eissn"
    let fundref = _prefixId.prefix "fundref"
    let gepris = _prefixId.prefix "gepris"
    let github = _prefixId.prefix "github"
    let gitlab = _prefixId.prefix "gitlab"
    let gnd = _prefixId.prefix "gnd"
    let google_scholar = _prefixId.prefix "google-scholar"
    let handle = _prefixId.prefix "handle"
    /// <summary>
    ///   <para>rdfs:comment : This property allows one to specify the list of the creators of a certain resource.</para>
    ///   <para>rdfs:label : has creator list</para>
    ///   <a href="http://purl.org/spar/datacite/hasCreatorList">dcite:hasCreatorList</a>
    /// </summary>
    let hasCreatorList = _prefixId.prefix "hasCreatorList"
    /// <summary>
    ///   <para>rdfs:comment : An object property permitting specification of an entity used to describe a resource.</para>
    ///   <para>rdfs:label : has description</para>
    ///   <a href="http://purl.org/spar/datacite/hasDescription">dcite:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:comment : An object property permitting specification of the type of description used to describe a resource, defined as an individual of the class datacite:DescriptionType from the DataCite controlled list of Abstract, SeriesInformation, TableOfContent and Other.</para>
    ///   <para>rdfs:label : has description type</para>
    ///   <a href="http://purl.org/spar/datacite/hasDescriptionType">dcite:hasDescriptionType</a>
    /// </summary>
    let hasDescriptionType = _prefixId.prefix "hasDescriptionType"
    /// <summary>
    ///   <para>rdfs:comment : An object property permitting specification of the general type of a resource, defined from the DataCite controlled list, namely:
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
    /// All the prefixes used here refer to external ontologies, i.e., DC Metadata Terms (dcmitype: http://purl.org/dc/dcmitype/), FaBiO (fabio: http://purl.org/spar/fabio/), and FRBR (frbr: http://purl.org/vocab/frbr/core#).</para>
    ///   <para>rdfs:label : has general resource type</para>
    ///   <a href="http://purl.org/spar/datacite/hasGeneralResourceType">dcite:hasGeneralResourceType</a>
    /// </summary>
    let hasGeneralResourceType = _prefixId.prefix "hasGeneralResourceType"
    /// <summary>
    ///   <para>rdfs:comment : An object property specifying a datacite:Identifier that provides a unique identifer for the entity (either a funder, a person or a resource).</para>
    ///   <para>rdfs:label : has identifier</para>
    ///   <a href="http://purl.org/spar/datacite/hasIdentifier">dcite:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    let ieee = _prefixId.prefix "ieee"
    let infouri = _prefixId.prefix "infouri"
    let isbn = _prefixId.prefix "isbn"
    let isni = _prefixId.prefix "isni"
    let issn = _prefixId.prefix "issn"
    let istc = _prefixId.prefix "istc"
    let jst = _prefixId.prefix "jst"
    let lattes = _prefixId.prefix "lattes"
    let linkedin = _prefixId.prefix "linkedin"
    let lissn = _prefixId.prefix "lissn"
    let loc = _prefixId.prefix "loc"

    let local_funder_identifier_scheme =
        _prefixId.prefix "local-funder-identifier-scheme"

    let local_organization_identifier_scheme =
        _prefixId.prefix "local-organization-identifier-scheme"

    let local_personal_identifier_scheme =
        _prefixId.prefix "local-personal-identifier-scheme"

    let local_resource_identifier_scheme =
        _prefixId.prefix "local-resource-identifier-scheme"

    let lsid = _prefixId.prefix "lsid"
    let math_genealogy = _prefixId.prefix "math-genealogy"
    let methods = _prefixId.prefix "methods"
    let national_insurance_number = _prefixId.prefix "national-insurance-number"
    let nihmsid = _prefixId.prefix "nihmsid"
    let nii = _prefixId.prefix "nii"
    let oci = _prefixId.prefix "oci"
    let oclc = _prefixId.prefix "oclc"
    let openalex = _prefixId.prefix "openalex"
    let openid = _prefixId.prefix "openid"
    let orcid = _prefixId.prefix "orcid"
    let other = _prefixId.prefix "other"
    let pii = _prefixId.prefix "pii"
    let pmcid = _prefixId.prefix "pmcid"
    let pmid = _prefixId.prefix "pmid"
    let purl = _prefixId.prefix "purl"
    let repec = _prefixId.prefix "repec"
    let research_gate = _prefixId.prefix "research-gate"
    let researcherid = _prefixId.prefix "researcherid"
    let ror = _prefixId.prefix "ror"
    let scigraph = _prefixId.prefix "scigraph"
    let series_information = _prefixId.prefix "series-information"
    let sici = _prefixId.prefix "sici"
    let social_security_number = _prefixId.prefix "social-security-number"
    let spar = _prefixId.prefix "spar"
    let table_of_content = _prefixId.prefix "table-of-content"
    let twitter = _prefixId.prefix "twitter"
    let upc = _prefixId.prefix "upc"
    let uri = _prefixId.prefix "uri"
    let url = _prefixId.prefix "url"
    let urn = _prefixId.prefix "urn"
    /// <summary>
    ///   <para>rdfs:comment : An object property permitting specification of the identifier scheme used to provide the identifier for an entity – either a funder, a person or a resource – defined as an individual of the class datacite:IdentifierScheme.</para>
    ///   <para>rdfs:label : uses identifier scheme</para>
    ///   <a href="http://purl.org/spar/datacite/usesIdentifierScheme">dcite:usesIdentifierScheme</a>
    /// </summary>
    let usesIdentifierScheme = _prefixId.prefix "usesIdentifierScheme"
    /// <summary>
    ///   <para>rdfs:comment : The link between a metadata document and the scheme followed for creating metadata.</para>
    ///   <para>rdfs:label : uses metadata scheme</para>
    ///   <a href="http://purl.org/spar/datacite/usesMetadataScheme">dcite:usesMetadataScheme</a>
    /// </summary>
    let usesMetadataScheme = _prefixId.prefix "usesMetadataScheme"
    let viaf = _prefixId.prefix "viaf"
    let wikidata = _prefixId.prefix "wikidata"
    let wikipedia = _prefixId.prefix "wikipedia"
    let zbmath = _prefixId.prefix "zbmath"
