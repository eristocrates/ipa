namespace http.www.w3.org.ns.dcat.hash

open DoxAletheia.Rdf_Vocabulary

module dcat =
    let _namespace_name = "http://www.w3.org/ns/dcat#"
    /// <summary>
    /// A curated collection of metadata about resources (e.g., datasets and data services in the context of a data catalog).
    /// <see href="http://www.w3.org/ns/dcat#Catalog"></see></summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName
    /// <summary>
    /// Resource published or curated by a single agent.
    /// <see href="http://www.w3.org/ns/dcat#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    /// A collection of data, published or curated by a single source, and available for access or download in one or more represenations.
    /// <see href="http://www.w3.org/ns/dcat#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// A record in a data catalog, describing the registration of a single dataset or data service.
    /// <see href="http://www.w3.org/ns/dcat#CatalogRecord"></see></summary>
    let CatalogRecord =
        Namespaced_IRI.parse _namespace_name "CatalogRecord" |> NamespacedName

    /// <summary>
    /// A site or end-point providing operations related to the discovery of, access to, or processing functions on, data or related resources.
    /// <see href="http://www.w3.org/ns/dcat#DataService"></see></summary>
    let DataService =
        Namespaced_IRI.parse _namespace_name "DataService" |> NamespacedName

    /// <summary>
    /// The root location or primary endpoint of the service (a web-resolvable IRI).
    /// <see href="http://www.w3.org/ns/dcat#endpointURL"></see></summary>
    let endpointURL =
        Namespaced_IRI.parse _namespace_name "endpointURL" |> NamespacedName

    /// <summary>
    /// A specific representation of a dataset. A dataset might be available in multiple serializations that may differ in various ways, including natural language, media-type or format, schematic organization, temporal and spatial resolution, level of detail or profiles (which might specify any or all of the above).
    /// <see href="http://www.w3.org/ns/dcat#Distribution"></see></summary>
    let Distribution =
        Namespaced_IRI.parse _namespace_name "Distribution" |> NamespacedName

    /// <summary>
    /// An association class for attaching additional information to a relationship between DCAT Resources.
    /// <see href="http://www.w3.org/ns/dcat#Relationship"></see></summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    /// A role is the function of a resource or agent with respect to another resource, in the context of resource attribution or resource relationships.
    /// <see href="http://www.w3.org/ns/dcat#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// The function of an entity or agent with respect to another entity or resource.
    /// <see href="http://www.w3.org/ns/dcat#hadRole"></see></summary>
    let hadRole = Namespaced_IRI.parse _namespace_name "hadRole" |> NamespacedName

    /// <summary>
    /// A site or end-point that gives access to the distribution of the dataset.
    /// <see href="http://www.w3.org/ns/dcat#accessService"></see></summary>
    let accessService =
        Namespaced_IRI.parse _namespace_name "accessService" |> NamespacedName

    /// <summary>
    /// A URL of a resource that gives access to a distribution of the dataset. E.g. landing page, feed, SPARQL endpoint. Use for all cases except a simple download link, in which case downloadURL is preferred.
    /// <see href="http://www.w3.org/ns/dcat#accessURL"></see></summary>
    let accessURL = Namespaced_IRI.parse _namespace_name "accessURL" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dcat#bbox"></see>
    /// </summary>
    let bbox = Namespaced_IRI.parse _namespace_name "bbox" |> NamespacedName
    /// <summary>
    /// The size of a distribution in bytes.
    /// <see href="http://www.w3.org/ns/dcat#byteSize"></see></summary>
    let byteSize = Namespaced_IRI.parse _namespace_name "byteSize" |> NamespacedName
    /// <summary>
    /// A catalog whose contents are of interest in the context of this catalog.
    /// <see href="http://www.w3.org/ns/dcat#catalog"></see></summary>
    let catalog = Namespaced_IRI.parse _namespace_name "catalog" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/dcat#centroid"></see>
    /// </summary>
    let centroid = Namespaced_IRI.parse _namespace_name "centroid" |> NamespacedName

    /// <summary>
    /// The compression format of the distribution in which the data is contained in a compressed form, e.g. to reduce the size of the downloadable file.
    /// <see href="http://www.w3.org/ns/dcat#compressFormat"></see></summary>
    let compressFormat =
        Namespaced_IRI.parse _namespace_name "compressFormat" |> NamespacedName

    /// <summary>
    /// Relevant contact information for the catalogued resource. Use of vCard is recommended.
    /// <see href="http://www.w3.org/ns/dcat#contactPoint"></see></summary>
    let contactPoint =
        Namespaced_IRI.parse _namespace_name "contactPoint" |> NamespacedName

    /// <summary>
    /// A collection of data that is listed in the catalog.
    /// <see href="http://www.w3.org/ns/dcat#dataset"></see></summary>
    let dataset = Namespaced_IRI.parse _namespace_name "dataset" |> NamespacedName

    /// <summary>
    /// An available distribution of the dataset.
    /// <see href="http://www.w3.org/ns/dcat#distribution"></see></summary>
    let distribution =
        Namespaced_IRI.parse _namespace_name "distribution" |> NamespacedName

    /// <summary>
    /// The URL of the downloadable file in a given format. E.g. CSV file or RDF file. The format is indicated by the distribution's dct:format and/or dcat:mediaType.
    /// <see href="http://www.w3.org/ns/dcat#downloadURL"></see></summary>
    let downloadURL =
        Namespaced_IRI.parse _namespace_name "downloadURL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dcat#endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    /// A description of the service end-point, including its operations, parameters etc.
    /// <see href="http://www.w3.org/ns/dcat#endpointDescription"></see></summary>
    let endpointDescription =
        Namespaced_IRI.parse _namespace_name "endpointDescription" |> NamespacedName

    /// <summary>
    /// A keyword or tag describing a resource.
    /// <see href="http://www.w3.org/ns/dcat#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName

    /// <summary>
    /// A Web page that can be navigated to in a Web browser to gain access to the catalog, a dataset, its distributions and/or additional information.
    /// <see href="http://www.w3.org/ns/dcat#landingPage"></see></summary>
    let landingPage =
        Namespaced_IRI.parse _namespace_name "landingPage" |> NamespacedName

    /// <summary>
    /// The media type of the distribution as defined by IANA
    /// <see href="http://www.w3.org/ns/dcat#mediaType"></see></summary>
    let mediaType = Namespaced_IRI.parse _namespace_name "mediaType" |> NamespacedName

    /// <summary>
    /// The package format of the distribution in which one or more data files are grouped together, e.g. to enable a set of related files to be downloaded together.
    /// <see href="http://www.w3.org/ns/dcat#packageFormat"></see></summary>
    let packageFormat =
        Namespaced_IRI.parse _namespace_name "packageFormat" |> NamespacedName

    /// <summary>
    /// Link to a description of a relationship with another resource.
    /// <see href="http://www.w3.org/ns/dcat#qualifiedRelation"></see></summary>
    let qualifiedRelation =
        Namespaced_IRI.parse _namespace_name "qualifiedRelation" |> NamespacedName

    /// <summary>
    /// A record describing the registration of a single dataset or data service that is part of the catalog.
    /// <see href="http://www.w3.org/ns/dcat#record"></see></summary>
    let record = Namespaced_IRI.parse _namespace_name "record" |> NamespacedName

    /// <summary>
    /// A collection of data that this DataService can distribute.
    /// <see href="http://www.w3.org/ns/dcat#servesDataset"></see></summary>
    let servesDataset =
        Namespaced_IRI.parse _namespace_name "servesDataset" |> NamespacedName

    /// <summary>
    /// A site or endpoint that is listed in the catalog.
    /// <see href="http://www.w3.org/ns/dcat#service"></see></summary>
    let service = Namespaced_IRI.parse _namespace_name "service" |> NamespacedName

    /// <summary>
    /// minimum spatial separation resolvable in a dataset, measured in metres.
    /// minimum spatial separation resolvable in a dataset, measured in meters.
    /// <see href="http://www.w3.org/ns/dcat#spatialResolutionInMeters"></see></summary>
    let spatialResolutionInMeters =
        Namespaced_IRI.parse _namespace_name "spatialResolutionInMeters" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/dcat#startDate"></see>
    /// </summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    /// minimum time period resolvable in a dataset.
    /// <see href="http://www.w3.org/ns/dcat#temporalResolution"></see></summary>
    let temporalResolution =
        Namespaced_IRI.parse _namespace_name "temporalResolution" |> NamespacedName

    /// <summary>
    /// A main category of the resource. A resource can have multiple themes.
    /// <see href="http://www.w3.org/ns/dcat#theme"></see></summary>
    let theme = Namespaced_IRI.parse _namespace_name "theme" |> NamespacedName

    /// <summary>
    /// The knowledge organization system (KOS) used to classify catalog's datasets.
    /// <see href="http://www.w3.org/ns/dcat#themeTaxonomy"></see></summary>
    let themeTaxonomy =
        Namespaced_IRI.parse _namespace_name "themeTaxonomy" |> NamespacedName
