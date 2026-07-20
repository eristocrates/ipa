namespace http.www.w3.org.ns.dcat.hash

open DoxAletheia

module dcat =
    let _namespace_name = "http://www.w3.org/ns/dcat#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A curated collection of metadata about resources (e.g., datasets and data services in the context of a data catalog).
    /// <see href="http://www.w3.org/ns/dcat#Catalog"></see></summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    /// Resource published or curated by a single agent.
    /// <see href="http://www.w3.org/ns/dcat#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// A collection of data, published or curated by a single source, and available for access or download in one or more represenations.
    /// <see href="http://www.w3.org/ns/dcat#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// A record in a data catalog, describing the registration of a single dataset or data service.
    /// <see href="http://www.w3.org/ns/dcat#CatalogRecord"></see></summary>
    let CatalogRecord = _prefix "CatalogRecord"
    /// <summary>
    /// A site or end-point providing operations related to the discovery of, access to, or processing functions on, data or related resources.
    /// <see href="http://www.w3.org/ns/dcat#DataService"></see></summary>
    let DataService = _prefix "DataService"
    /// <summary>
    /// The root location or primary endpoint of the service (a web-resolvable IRI).
    /// <see href="http://www.w3.org/ns/dcat#endpointURL"></see></summary>
    let endpointURL = _prefix "endpointURL"
    /// <summary>
    /// A specific representation of a dataset. A dataset might be available in multiple serializations that may differ in various ways, including natural language, media-type or format, schematic organization, temporal and spatial resolution, level of detail or profiles (which might specify any or all of the above).
    /// <see href="http://www.w3.org/ns/dcat#Distribution"></see></summary>
    let Distribution = _prefix "Distribution"
    /// <summary>
    /// An association class for attaching additional information to a relationship between DCAT Resources.
    /// <see href="http://www.w3.org/ns/dcat#Relationship"></see></summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    /// A role is the function of a resource or agent with respect to another resource, in the context of resource attribution or resource relationships.
    /// <see href="http://www.w3.org/ns/dcat#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// The function of an entity or agent with respect to another entity or resource.
    /// <see href="http://www.w3.org/ns/dcat#hadRole"></see></summary>
    let hadRole = _prefix "hadRole"
    /// <summary>
    /// A site or end-point that gives access to the distribution of the dataset.
    /// <see href="http://www.w3.org/ns/dcat#accessService"></see></summary>
    let accessService = _prefix "accessService"
    /// <summary>
    /// A URL of a resource that gives access to a distribution of the dataset. E.g. landing page, feed, SPARQL endpoint. Use for all cases except a simple download link, in which case downloadURL is preferred.
    /// <see href="http://www.w3.org/ns/dcat#accessURL"></see></summary>
    let accessURL = _prefix "accessURL"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dcat#bbox"></see>
    /// </summary>
    let bbox = _prefix "bbox"
    /// <summary>
    /// The size of a distribution in bytes.
    /// <see href="http://www.w3.org/ns/dcat#byteSize"></see></summary>
    let byteSize = _prefix "byteSize"
    /// <summary>
    /// A catalog whose contents are of interest in the context of this catalog.
    /// <see href="http://www.w3.org/ns/dcat#catalog"></see></summary>
    let catalog = _prefix "catalog"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dcat#centroid"></see>
    /// </summary>
    let centroid = _prefix "centroid"
    /// <summary>
    /// The compression format of the distribution in which the data is contained in a compressed form, e.g. to reduce the size of the downloadable file.
    /// <see href="http://www.w3.org/ns/dcat#compressFormat"></see></summary>
    let compressFormat = _prefix "compressFormat"
    /// <summary>
    /// Relevant contact information for the catalogued resource. Use of vCard is recommended.
    /// <see href="http://www.w3.org/ns/dcat#contactPoint"></see></summary>
    let contactPoint = _prefix "contactPoint"
    /// <summary>
    /// A collection of data that is listed in the catalog.
    /// <see href="http://www.w3.org/ns/dcat#dataset"></see></summary>
    let dataset = _prefix "dataset"
    /// <summary>
    /// An available distribution of the dataset.
    /// <see href="http://www.w3.org/ns/dcat#distribution"></see></summary>
    let distribution = _prefix "distribution"
    /// <summary>
    /// The URL of the downloadable file in a given format. E.g. CSV file or RDF file. The format is indicated by the distribution's dct:format and/or dcat:mediaType.
    /// <see href="http://www.w3.org/ns/dcat#downloadURL"></see></summary>
    let downloadURL = _prefix "downloadURL"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dcat#endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// A description of the service end-point, including its operations, parameters etc.
    /// <see href="http://www.w3.org/ns/dcat#endpointDescription"></see></summary>
    let endpointDescription = _prefix "endpointDescription"
    /// <summary>
    /// A keyword or tag describing a resource.
    /// <see href="http://www.w3.org/ns/dcat#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// A Web page that can be navigated to in a Web browser to gain access to the catalog, a dataset, its distributions and/or additional information.
    /// <see href="http://www.w3.org/ns/dcat#landingPage"></see></summary>
    let landingPage = _prefix "landingPage"
    /// <summary>
    /// The media type of the distribution as defined by IANA
    /// <see href="http://www.w3.org/ns/dcat#mediaType"></see></summary>
    let mediaType = _prefix "mediaType"
    /// <summary>
    /// The package format of the distribution in which one or more data files are grouped together, e.g. to enable a set of related files to be downloaded together.
    /// <see href="http://www.w3.org/ns/dcat#packageFormat"></see></summary>
    let packageFormat = _prefix "packageFormat"
    /// <summary>
    /// Link to a description of a relationship with another resource.
    /// <see href="http://www.w3.org/ns/dcat#qualifiedRelation"></see></summary>
    let qualifiedRelation = _prefix "qualifiedRelation"
    /// <summary>
    /// A record describing the registration of a single dataset or data service that is part of the catalog.
    /// <see href="http://www.w3.org/ns/dcat#record"></see></summary>
    let record = _prefix "record"
    /// <summary>
    /// A collection of data that this DataService can distribute.
    /// <see href="http://www.w3.org/ns/dcat#servesDataset"></see></summary>
    let servesDataset = _prefix "servesDataset"
    /// <summary>
    /// A site or endpoint that is listed in the catalog.
    /// <see href="http://www.w3.org/ns/dcat#service"></see></summary>
    let service = _prefix "service"
    /// <summary>
    /// minimum spatial separation resolvable in a dataset, measured in metres.
    /// minimum spatial separation resolvable in a dataset, measured in meters.
    /// <see href="http://www.w3.org/ns/dcat#spatialResolutionInMeters"></see></summary>
    let spatialResolutionInMeters = _prefix "spatialResolutionInMeters"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dcat#startDate"></see>
    /// </summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// minimum time period resolvable in a dataset.
    /// <see href="http://www.w3.org/ns/dcat#temporalResolution"></see></summary>
    let temporalResolution = _prefix "temporalResolution"
    /// <summary>
    /// A main category of the resource. A resource can have multiple themes.
    /// <see href="http://www.w3.org/ns/dcat#theme"></see></summary>
    let theme = _prefix "theme"
    /// <summary>
    /// The knowledge organization system (KOS) used to classify catalog's datasets.
    /// <see href="http://www.w3.org/ns/dcat#themeTaxonomy"></see></summary>
    let themeTaxonomy = _prefix "themeTaxonomy"
