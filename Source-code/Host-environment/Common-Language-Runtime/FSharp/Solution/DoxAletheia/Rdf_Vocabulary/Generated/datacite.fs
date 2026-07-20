namespace http.purl.org.spar.datacite.slash

open DoxAletheia

module datacite =
    let _namespace_name = "http://purl.org/spar/datacite/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An identifier that uniquely identities a funding agency, belonging to a particular scheme such as FundRef specified by an individual within the class datacite:FunderIdentifierScheme.
    /// <see href="http://purl.org/spar/datacite/FunderIdentifier"></see></summary>
    let FunderIdentifier = _prefix "FunderIdentifier"
    /// <summary>
    /// An identifier that uniquely identities an individual person, belonging to a particular identifier scheme such as ORCID specified by an individual within the class datacite:PersonalIdentifierScheme.
    /// <see href="http://purl.org/spar/datacite/PersonalIdentifier"></see></summary>
    let PersonalIdentifier = _prefix "PersonalIdentifier"
    /// <summary>
    /// An identifier that is used to uniquely identifies a resource.
    /// <see href="http://purl.org/spar/datacite/ResourceIdentifier"></see></summary>
    let ResourceIdentifier = _prefix "ResourceIdentifier"
    /// <summary>
    ///   <see href="http://purl.org/spar/datacite/datacite.png"></see>
    /// </summary>
    let ``datacite.png`` = _prefix "datacite.png"
    /// <summary>
    ///   <see href="http://purl.org/spar/datacite/2021-09-24"></see>
    /// </summary>
    let ``_2021-09-24`` = _prefix "2021-09-24"
    /// <summary>
    ///   <see href="http://purl.org/spar/datacite/2022-09-15"></see>
    /// </summary>
    let ``_2022-09-15`` = _prefix "2022-09-15"
    /// <summary>
    /// An identifier that uniquely identities an individual agent, belonging to a particular identifier scheme specified by an individual within the class datacite:AgentIdentifierScheme (or any of its subclasses).
    /// <see href="http://purl.org/spar/datacite/AgentIdentifier"></see></summary>
    let AgentIdentifier = _prefix "AgentIdentifier"
    /// <summary>
    /// An identifier that uniquely identities an entity – such as a funding agency, a person and a resource – belonging to a particular scheme such as those specified by individuals of the class datacite:IdentifierScheme.
    /// <see href="http://purl.org/spar/datacite/Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// An object property permitting specification of the identifier scheme used to provide the identifier for an entity – either a funder, a person or a resource – defined as an individual of the class datacite:IdentifierScheme.
    /// <see href="http://purl.org/spar/datacite/usesIdentifierScheme"></see></summary>
    let usesIdentifierScheme = _prefix "usesIdentifierScheme"
    /// <summary>
    /// The identifier scheme used to identify an agent. Individual schemes are defines as members of its sub-classes.
    /// <see href="http://purl.org/spar/datacite/AgentIdentifierScheme"></see></summary>
    let AgentIdentifierScheme = _prefix "AgentIdentifierScheme"
    /// <summary>
    /// The identifier scheme used to identify an entity such as a funding agency, a person or a resource. Individual schemes are defines as members of this class.
    /// <see href="http://purl.org/spar/datacite/IdentifierScheme"></see></summary>
    let IdentifierScheme = _prefix "IdentifierScheme"
    /// <summary>
    /// An identifier other than a DOI that is used as an alternative identifier to uniquely identifies the primary resource that is the subject of the DataCite metadata record, belonging to a particular scheme such as ISBN specified by an individual that is a member of the class datacite:ResourceIdentifierScheme.
    /// <see href="http://purl.org/spar/datacite/AlternateResourceIdentifier"></see></summary>
    let AlternateResourceIdentifier = _prefix "AlternateResourceIdentifier"
    /// <summary>
    /// An identifier that is used as the primary identifier to uniquely identifies the primary resource that is the subject of the DataCite metadata record.  Within the DataCite metadata record, a Digital Object Identifier is the only permitted primary resource identifier scheme, specified by the individual datacite:doi, that is a member of the class datacite:ResourceIdentifierScheme.
    /// <see href="http://purl.org/spar/datacite/PrimaryResourceIdentifier"></see></summary>
    let PrimaryResourceIdentifier = _prefix "PrimaryResourceIdentifier"
    /// <summary>
    /// This class permits classification of the type of description given to a resource described by the DataCite Metadata schema.  Individual members of the class conform to the five values allowed in the DataCite controlled list, namely:
    ///
    /// * abstract;
    /// * methods;
    /// * series-information;
    /// * table-of-content;
    /// * other.
    /// <see href="http://purl.org/spar/datacite/DescriptionType"></see></summary>
    let DescriptionType = _prefix "DescriptionType"
    /// <summary>
    /// The identifier scheme used to identify a funding agency. Individual schemes are defines as members of this class. At present, the only individual of this class is datacite:fundref.
    /// <see href="http://purl.org/spar/datacite/FunderIdentifierScheme"></see></summary>
    let FunderIdentifierScheme = _prefix "FunderIdentifierScheme"
    /// <summary>
    /// An object property specifying a datacite:Identifier that provides a unique identifer for the entity (either a funder, a person or a resource).
    /// <see href="http://purl.org/spar/datacite/hasIdentifier"></see></summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    /// The class that describe metadata schemes used for creating a metadata document referring to a certain resource.
    ///
    /// Neither a class for metadata documents nor a property linking a resource to its metadata document are not explicitly defined in this ontology. However, we recommend to use the class fabio:MetadataDocument (from http://purl.org/spar/fabio) and cito:citesAsMetadataDocument (from http://purl.org/spar/cito) for providing such descriptions. An example of use of such entities is shown as follows:
    ///
    ///     :my-resource
    ///         cito:citesAsMetadataDocument :my-resource-metadata .
    ///     :my-resource-metadata a fabio:MetadataDocument ;
    ///         datacite:usesMetadataScheme datacite:spar .
    ///
    /// In addition, if needed, it is possible to use the dataproperty fabio:hasURL (not included in this ontology as well) for defining the actual URL of a certain metadata scheme.
    /// <see href="http://purl.org/spar/datacite/MetadataScheme"></see></summary>
    let MetadataScheme = _prefix "MetadataScheme"
    /// <summary>
    /// An identifier that uniquely identities an individual organization, belonging to a particular identifier scheme such as ISNI specified by an individual within the class datacite:OrganizationIdentifierScheme.
    /// <see href="http://purl.org/spar/datacite/OrganizationIdentifier"></see></summary>
    let OrganizationIdentifier = _prefix "OrganizationIdentifier"
    /// <summary>
    /// The identifier scheme used to identify an organization. Individual schemes are defines as members of this class.
    /// <see href="http://purl.org/spar/datacite/OrganizationIdentifierScheme"></see></summary>
    let OrganizationIdentifierScheme = _prefix "OrganizationIdentifierScheme"
    /// <summary>
    /// The identifier scheme used to identify a person.  Individual schemes are defines as members of this class.
    /// <see href="http://purl.org/spar/datacite/PersonalIdentifierScheme"></see></summary>
    let PersonalIdentifierScheme = _prefix "PersonalIdentifierScheme"
    /// <summary>
    /// Digital Object Identier
    /// <see href="http://purl.org/spar/datacite/doi"></see></summary>
    let doi = _prefix "doi"
    /// <summary>
    /// The identifier scheme used to identify a resource.  Individual schemes are defines as members of this class.  For DataCite, the only permitted identifier scheme for the primary resource identifier is the Digital Object Identifier.
    /// <see href="http://purl.org/spar/datacite/ResourceIdentifierScheme"></see></summary>
    let ResourceIdentifierScheme = _prefix "ResourceIdentifierScheme"
    /// <summary>
    /// A brief summary of a textual work, appearing at the beginning of the work and designed to act as the point-of-entry that will help the reader quickly to obtain an overview of the work's contents.
    /// <see href="http://purl.org/spar/datacite/abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// ACM Digital Library author ID, which is resolvable using the following URL: https://dl.acm.org/profile/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/acm"></see></summary>
    let acm = _prefix "acm"
    /// <summary>
    /// Archival Resource Key.
    /// <see href="http://purl.org/spar/datacite/ark"></see></summary>
    let ark = _prefix "ark"
    /// <summary>
    /// Identifier for ArXiv (http://arxiv.org/), a open access repository of preprints, having the format arXiv:1207.2147.
    /// <see href="http://purl.org/spar/datacite/arxiv"></see></summary>
    let arxiv = _prefix "arxiv"
    /// <summary>
    /// It is the Astrophysics Data System bibliographic codes, a standardized 19 character identifier according to the syntax "yyyyjjjjjvvvvmppppa".
    /// <see href="http://purl.org/spar/datacite/bibcode"></see></summary>
    let bibcode = _prefix "bibcode"
    /// <summary>
    /// Crossref member identifier, which is resolvable from the following URL: https://api.crossref.org/members/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/crossref"></see></summary>
    let crossref = _prefix "crossref"
    /// <summary>
    /// DBLP author identifier, which is resolvable from the following URL: https://dblp.org/pid/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/dblp"></see></summary>
    let dblp = _prefix "dblp"
    /// <summary>
    /// DBLP publication identifier, which is resolvable from the following URL: https://dblp.org/rec/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/dblp-record"></see></summary>
    let ``dblp-record`` = _prefix "dblp-record"
    /// <summary>
    /// The Digital Author Identification system assigns a unique number to all authors in the Netherlands research system.
    /// <see href="http://purl.org/spar/datacite/dia"></see></summary>
    let dia = _prefix "dia"
    /// <summary>
    /// DNB catalogue number, which is resolvable from the following URL: https://d-nb.info/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/dnb"></see></summary>
    let dnb = _prefix "dnb"
    /// <summary>
    /// International Article Number
    /// <see href="http://purl.org/spar/datacite/ean13"></see></summary>
    let ean13 = _prefix "ean13"
    /// <summary>
    /// Electronic International Standard Serial Number
    /// <see href="http://purl.org/spar/datacite/eissn"></see></summary>
    let eissn = _prefix "eissn"
    /// <summary>
    /// FundRef is a collaborative pilot project of scholarly publishers and funding agencies, facilitated by CrossRef, to provide a standard way of identifying and reporting funding sources for published scholarly research.
    /// <see href="http://purl.org/spar/datacite/fundref"></see></summary>
    let fundref = _prefix "fundref"
    /// <summary>
    /// GEPRIS person identifier, which is resolvable from the following URL: http://gepris.dfg.de/gepris/person/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/gepris"></see></summary>
    let gepris = _prefix "gepris"
    /// <summary>
    /// GitHub username, which is resolvable from the following URL: https://github.com/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/github"></see></summary>
    let github = _prefix "github"
    /// <summary>
    /// The identifier for GitLab Users.
    /// <see href="http://purl.org/spar/datacite/gitlab"></see></summary>
    let gitlab = _prefix "gitlab"
    /// <summary>
    /// Gemeinsame Normdatei identifier, which is resolvable from the following URL: https://d-nb.info/gnd/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/gnd"></see></summary>
    let gnd = _prefix "gnd"
    /// <summary>
    /// Google Scholar author identifier, which resolvable from the following URL:	https://scholar.google.com/citations?user=&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/google-scholar"></see></summary>
    let ``google-scholar`` = _prefix "google-scholar"
    /// <summary>
    /// The Handle system
    /// <see href="http://purl.org/spar/datacite/handle"></see></summary>
    let handle = _prefix "handle"
    /// <summary>
    /// This property allows one to specify the list of the creators of a certain resource.
    /// <see href="http://purl.org/spar/datacite/hasCreatorList"></see></summary>
    let hasCreatorList = _prefix "hasCreatorList"
    /// <summary>
    /// An object property permitting specification of an entity used to describe a resource.
    /// <see href="http://purl.org/spar/datacite/hasDescription"></see></summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    /// An object property permitting specification of the type of description used to describe a resource, defined as an individual of the class datacite:DescriptionType from the DataCite controlled list of Abstract, SeriesInformation, TableOfContent and Other.
    /// <see href="http://purl.org/spar/datacite/hasDescriptionType"></see></summary>
    let hasDescriptionType = _prefix "hasDescriptionType"
    /// <summary>
    /// An object property permitting specification of the general type of a resource, defined from the DataCite controlled list, namely:
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
    /// All the prefixes used here refer to external ontologies, i.e., DC Metadata Terms (dcmitype: http://purl.org/dc/dcmitype/), FaBiO (fabio: http://purl.org/spar/fabio/), and FRBR (frbr: http://purl.org/vocab/frbr/core#).
    /// <see href="http://purl.org/spar/datacite/hasGeneralResourceType"></see></summary>
    let hasGeneralResourceType = _prefix "hasGeneralResourceType"
    /// <summary>
    /// IEEE Xplore author ID, which is resolvable from the following URL: https://ieeexplore.ieee.org/author/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/ieee"></see></summary>
    let ieee = _prefix "ieee"
    /// <summary>
    /// Info URI scheme
    /// <see href="http://purl.org/spar/datacite/infouri"></see></summary>
    let infouri = _prefix "infouri"
    /// <summary>
    /// International Standard Book Number
    /// <see href="http://purl.org/spar/datacite/isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    /// International Standard Name Identifier scheme.
    /// <see href="http://purl.org/spar/datacite/isni"></see></summary>
    let isni = _prefix "isni"
    /// <summary>
    /// International Standard Serial Number
    /// <see href="http://purl.org/spar/datacite/issn"></see></summary>
    let issn = _prefix "issn"
    /// <summary>
    /// International Standard Text Code
    /// <see href="http://purl.org/spar/datacite/istc"></see></summary>
    let istc = _prefix "istc"
    /// <summary>
    /// Japanese Science and Technology Agency identifier scheme
    /// <see href="http://purl.org/spar/datacite/jst"></see></summary>
    let jst = _prefix "jst"
    /// <summary>
    /// Lattes Platform number, which is resolvable from the following URL: http://lattes.cnpq.br/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/lattes"></see></summary>
    let lattes = _prefix "lattes"
    /// <summary>
    /// LinkedIn personal profile identifier, which is resolvable from the following URL: https://www.linkedin.com/in/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/linkedin"></see></summary>
    let linkedin = _prefix "linkedin"
    /// <summary>
    /// Linking International Standard Serial Number
    /// <see href="http://purl.org/spar/datacite/lissn"></see></summary>
    let lissn = _prefix "lissn"
    /// <summary>
    /// Library of Congress authority identifier, which is resolvable from the following URL: https://id.loc.gov/authorities/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/loc"></see></summary>
    let loc = _prefix "loc"
    /// <summary>
    /// A funder identifier scheme that provides local funder identifiers that are unique in their local environment and understood by the person submitting the metadata.
    /// <see href="http://purl.org/spar/datacite/local-funder-identifier-scheme"></see></summary>
    let ``local-funder-identifier-scheme`` = _prefix "local-funder-identifier-scheme"

    /// <summary>
    /// An organization identifier scheme that provides local organization identifiers that are unique in their local environment and understood by the person submitting the metadata.
    /// <see href="http://purl.org/spar/datacite/local-organization-identifier-scheme"></see></summary>
    let ``local-organization-identifier-scheme`` =
        _prefix "local-organization-identifier-scheme"

    /// <summary>
    /// A personal identifier scheme that provides local personal identifiers that are unique in their local environment and understood by the person submitting the metadata.
    /// <see href="http://purl.org/spar/datacite/local-personal-identifier-scheme"></see></summary>
    let ``local-personal-identifier-scheme`` =
        _prefix "local-personal-identifier-scheme"

    /// <summary>
    /// A resource identifier scheme that provides local resource identifiers that are unique in their local environment and understood by the person submitting the metadata.
    /// <see href="http://purl.org/spar/datacite/local-resource-identifier-scheme"></see></summary>
    let ``local-resource-identifier-scheme`` =
        _prefix "local-resource-identifier-scheme"

    /// <summary>
    /// Life Science Identifier
    /// <see href="http://purl.org/spar/datacite/lsid"></see></summary>
    let lsid = _prefix "lsid"
    /// <summary>
    /// Mathematics Genealogy Project identifier, which is resolvable from the following URL: https://mathgenealogy.org/id.php?id=&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/math-genealogy"></see></summary>
    let ``math-genealogy`` = _prefix "math-genealogy"
    /// <summary>
    /// A description in a research paper documenting the specialized methods used in the work described.
    /// <see href="http://purl.org/spar/datacite/methods"></see></summary>
    let methods = _prefix "methods"
    /// <summary>
    /// United Kingdom National Insurance Number scheme.
    /// <see href="http://purl.org/spar/datacite/national-insurance-number"></see></summary>
    let ``national-insurance-number`` = _prefix "national-insurance-number"
    /// <summary>
    /// NIH Manuscript Submission Identifier
    /// <see href="http://purl.org/spar/datacite/nihmsid"></see></summary>
    let nihmsid = _prefix "nihmsid"
    /// <summary>
    /// National Individual Identifier scheme.
    /// <see href="http://purl.org/spar/datacite/nii"></see></summary>
    let nii = _prefix "nii"
    /// <summary>
    /// Open Citation Identifier.
    /// <see href="http://purl.org/spar/datacite/oci"></see></summary>
    let oci = _prefix "oci"
    /// <summary>
    /// OCLC control number, which is resolvable from the following URL: https://www.worldcat.org/oclc/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/oclc"></see></summary>
    let oclc = _prefix "oclc"
    /// <summary>
    /// The primary key for all entities included in OpenAlex.
    ///
    /// The OpenAlex ID has two parts. The first part is the base, that is always https://openalex.org/. The second part is the key, i.e. the unique primary key that identifies a given resource in our database. The key starts with a letter that tells us the kind of entity: W(ork), A(uthor), V(enue), I(nstitution), or C(oncept). In addition, the IDs are not case-sensitive, so w2741809807 is just as valid as W2741809807.
    /// <see href="http://purl.org/spar/datacite/openalex"></see></summary>
    let openalex = _prefix "openalex"
    /// <summary>
    /// OpenID is an open standard that describes how users can be authenticated in a decentralized manner, eliminating the need for centralized registration services.
    /// <see href="http://purl.org/spar/datacite/openid"></see></summary>
    let openid = _prefix "openid"
    /// <summary>
    /// Open Researcher and Contributor Identifier.
    /// <see href="http://purl.org/spar/datacite/orcid"></see></summary>
    let orcid = _prefix "orcid"
    /// <summary>
    /// A catch-all description type required by the DataCite Metadata Schema to characterize description types that are not abstracts, series information or tables of content.
    /// <see href="http://purl.org/spar/datacite/other"></see></summary>
    let other = _prefix "other"
    /// <summary>
    /// Pulisher Item Identifier scheme.
    /// <see href="http://purl.org/spar/datacite/pii"></see></summary>
    let pii = _prefix "pii"
    /// <summary>
    /// PubMed Central Identifier
    /// <see href="http://purl.org/spar/datacite/pmcid"></see></summary>
    let pmcid = _prefix "pmcid"
    /// <summary>
    /// PubMed Identifier
    /// <see href="http://purl.org/spar/datacite/pmid"></see></summary>
    let pmid = _prefix "pmid"
    /// <summary>
    /// Persistent Uniform Resource Locator
    /// <see href="http://purl.org/spar/datacite/purl"></see></summary>
    let purl = _prefix "purl"
    /// <summary>
    /// RePEc Short identifier, which is resolvable from the following URL: https://authors.repec.org/pro/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/repec"></see></summary>
    let repec = _prefix "repec"
    /// <summary>
    /// ResearchGate profile identifier, which is resolvable from the following URL: https://www.researchgate.net/profile/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/research-gate"></see></summary>
    let ``research-gate`` = _prefix "research-gate"
    /// <summary>
    /// ResearcherID is an identifying system for scientific authors created and owned by Thomson Reuters.
    /// <see href="http://purl.org/spar/datacite/researcherid"></see></summary>
    let researcherid = _prefix "researcherid"
    /// <summary>
    /// The Research Organization Registry Community identifier, which is resolvable from the following URL: https://ror.org/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/ror"></see></summary>
    let ror = _prefix "ror"
    /// <summary>
    /// The identifier used for referring to entities in the Springer Nature SciGraph dataset.
    /// <see href="http://purl.org/spar/datacite/scigraph"></see></summary>
    let scigraph = _prefix "scigraph"
    /// <summary>
    /// Used to charactierize a description of a resource that is part of a series.
    /// <see href="http://purl.org/spar/datacite/series-information"></see></summary>
    let ``series-information`` = _prefix "series-information"
    /// <summary>
    /// Serial Item and Contribution Identifier
    /// <see href="http://purl.org/spar/datacite/sici"></see></summary>
    let sici = _prefix "sici"
    /// <summary>
    /// United States of America social security number scheme
    /// <see href="http://purl.org/spar/datacite/social-security-number"></see></summary>
    let ``social-security-number`` = _prefix "social-security-number"
    /// <summary>
    /// The Semantic Publishing and Referencing Ontologies, a.k.a. SPAR Ontologies, form a suite of orthogonal and complementary OWL 2 DL ontology modules for the creation of comprehensive machine-readable RDF metadata for every aspect of semantic publishing and referencing: document description, bibliographic resource identifiers, types of citations and related contexts, bibliographic references, document parts and status, agents' roles and contributions, bibliometric data and workflow processes.
    /// <see href="http://purl.org/spar/datacite/spar"></see></summary>
    let spar = _prefix "spar"
    /// <summary>
    /// A table of content giving information about the content of a resource, appearing before the body text.  Where the resource is a journal or magazine issue, the table of content lists the constituent items contained in that issue, typically by title, authors and first page number.
    /// <see href="http://purl.org/spar/datacite/table-of-content"></see></summary>
    let ``table-of-content`` = _prefix "table-of-content"
    /// <summary>
    /// Twitter handle, which is resolvable from the following URL: https://twitter.com/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/twitter"></see></summary>
    let twitter = _prefix "twitter"
    /// <summary>
    /// Universal Product Code
    /// <see href="http://purl.org/spar/datacite/upc"></see></summary>
    let upc = _prefix "upc"
    /// <summary>
    /// Uniform Resource Identifier
    /// <see href="http://purl.org/spar/datacite/uri"></see></summary>
    let uri = _prefix "uri"
    /// <summary>
    /// Uniform Resource Locator.
    /// <see href="http://purl.org/spar/datacite/url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// Uniform Resource Name.
    /// <see href="http://purl.org/spar/datacite/urn"></see></summary>
    let urn = _prefix "urn"
    /// <summary>
    /// The link between a metadata document and the scheme followed for creating metadata.
    /// <see href="http://purl.org/spar/datacite/usesMetadataScheme"></see></summary>
    let usesMetadataScheme = _prefix "usesMetadataScheme"
    /// <summary>
    /// The Virtual International Authority File is an international authority file created by amalagamating the national authority files of several national libraries and operated by the Online Computer Library Center (OCLC).  It contains information about many topics including personal names.
    /// <see href="http://purl.org/spar/datacite/viaf"></see></summary>
    let viaf = _prefix "viaf"
    /// <summary>
    /// Wikidata QID, which is resolvable from the following URL: https://www.wikidata.org/wiki/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/wikidata"></see></summary>
    let wikidata = _prefix "wikidata"
    /// <summary>
    /// Wikipedia page name, which is resolvable from the following URL: https://en.wikipedia.org/wiki/&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/wikipedia"></see></summary>
    let wikipedia = _prefix "wikipedia"
    /// <summary>
    /// zbMATH author identifier, which is resolvable from the following URL: https://zbmath.org/authors/?q=ai:&lt;identifier&gt;.
    /// <see href="http://purl.org/spar/datacite/zbmath"></see></summary>
    let zbmath = _prefix "zbmath"
