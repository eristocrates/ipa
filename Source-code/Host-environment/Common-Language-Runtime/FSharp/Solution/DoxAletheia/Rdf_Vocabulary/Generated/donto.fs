namespace http.reference.data.gov.au.def.ont.dataset.hash

open DoxAletheia.Rdf_Vocabulary

module donto =
    let _namespace_name = "http://reference.data.gov.au/def/ont/dataset#"

    /// <summary>
    /// The Government Function defined by the Australian Governments' Interactive Functions Thesaurus that best describes the data contained within a Dataset.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#AGIFTFunction"></see></summary>
    let AGIFTFunction =
        Namespaced_IRI.parse _namespace_name "AGIFTFunction" |> NamespacedName

    /// <summary>
    /// A classifier used for Australian Government Data.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Classifier"></see></summary>
    let Classifier = Namespaced_IRI.parse _namespace_name "Classifier" |> NamespacedName

    /// <summary>
    /// An AssociatedOrganisation is an Organisation that is responsible for an Event that changed a Dataset the Organisation is associated with.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#AssociatedOrganisation"></see></summary>
    let AssociatedOrganisation =
        Namespaced_IRI.parse _namespace_name "AssociatedOrganisation" |> NamespacedName

    /// <summary>
    /// A Catalog is a curated collection of metadata about datasets.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Catalog"></see></summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName
    /// <summary>
    /// A Dataset is a collection of resources, published or curated by an agent, and openly available for download in one or more formats.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// The date a change was made.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#dateChangeEvent"></see></summary>
    let dateChangeEvent =
        Namespaced_IRI.parse _namespace_name "dateChangeEvent" |> NamespacedName

    /// <summary>
    /// A relation to define when the Dataset was updated, i.e. a minor change that is not reflected in a Dataset Change Event.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#dateUpdated"></see></summary>
    let dateUpdated =
        Namespaced_IRI.parse _namespace_name "dateUpdated" |> NamespacedName

    /// <summary>
    /// The AGIFT classification for this dataset
    /// <see href="http://reference.data.gov.au/def/ont/dataset#agiftFunction"></see></summary>
    let agiftFunction =
        Namespaced_IRI.parse _namespace_name "agiftFunction" |> NamespacedName

    /// <summary>
    /// A Dataset Change Event is a description of an event that happens at a given point in time and that results in any type of change to the Dataset.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#DatasetChangeEvent"></see></summary>
    let DatasetChangeEvent =
        Namespaced_IRI.parse _namespace_name "DatasetChangeEvent" |> NamespacedName

    /// <summary>
    /// A Dataset Publication Event is a description of an event that happens at a given point in time and that results in the publication of a Dataset on data.gov.au.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#DatasetPublicationEvent"></see></summary>
    let DatasetPublicationEvent =
        Namespaced_IRI.parse _namespace_name "DatasetPublicationEvent" |> NamespacedName

    /// <summary>
    /// A Distribution defines the available form of a Dataset, i.e. different formats of the Dataset or different type of endpoints the Dataset can be retrieved from.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Distribution"></see></summary>
    let Distribution =
        Namespaced_IRI.parse _namespace_name "Distribution" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#Document"></see>
    /// </summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// Federal Government denotes the federal democratic administrative authority of the Commonwealth of Australia.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Federal"></see></summary>
    let Federal = Namespaced_IRI.parse _namespace_name "Federal" |> NamespacedName

    /// <summary>
    /// Level of Government is a description that is used to describe the Jurisidiction of an Organisation.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#LevelOfGovernment"></see></summary>
    let LevelOfGovernment =
        Namespaced_IRI.parse _namespace_name "LevelOfGovernment" |> NamespacedName

    /// <summary>
    /// The Field of Research defined by the Australian and New Zealand Standard Research Classification (ANZSRC) that best describes the type of methods applied to obtain the data contained within a Dataset.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#FieldOfResearch"></see></summary>
    let FieldOfResearch =
        Namespaced_IRI.parse _namespace_name "FieldOfResearch" |> NamespacedName

    /// <summary>
    /// Locality with a name authorised by a government agency
    /// <see href="http://reference.data.gov.au/def/ont/dataset#GazettedLocality"></see></summary>
    let GazettedLocality =
        Namespaced_IRI.parse _namespace_name "GazettedLocality" |> NamespacedName

    /// <summary>
    /// Locality is a Spatial Thing corresponding to a place or area, which is denoted by a commonly recognised, or formally designated, name or description.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Locality"></see></summary>
    let Locality = Namespaced_IRI.parse _namespace_name "Locality" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#Geometry"></see>
    /// </summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName

    /// <summary>
    /// A Spatial Thing describes the spatial characteristics of the resources within a Dataset, i.e. the geographical area where data was collected, a place which is the predominant subject of the Dataset, or a location which is the focus of an activity described in the Dataset.
    /// This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom in the data - likely to be  w3 geo or OGC GeoSPARQL or both, or something else as proposed by SDWWG.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#SpatialThing"></see></summary>
    let SpatialThing =
        Namespaced_IRI.parse _namespace_name "SpatialThing" |> NamespacedName

    /// <summary>
    /// A Government Agency is a kind of Organisation in the Commonwealth of Australia that is a distinct and recognisable body which has responsibility for carrying out administrative functions.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#GovernmentAgency"></see></summary>
    let GovernmentAgency =
        Namespaced_IRI.parse _namespace_name "GovernmentAgency" |> NamespacedName

    /// <summary>
    /// An Organisation is a kind of Agent representing, for example, a business or government, or organisational subunits thereof.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Organisation"></see></summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    /// Local Government is the lowest tier of government in the Commonwealth of Australia administered under the states and territories.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#LocalGovernmentArea"></see></summary>
    let LocalGovernmentArea =
        Namespaced_IRI.parse _namespace_name "LocalGovernmentArea" |> NamespacedName

    /// <summary>
    /// Defines the State or Territory a Locality is located in.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#inState"></see></summary>
    let inState = Namespaced_IRI.parse _namespace_name "inState" |> NamespacedName

    /// <summary>
    /// Provides information about the maintenance arrangements for the dataset. At a minimum the Agent and start-time for the maintenance responsibility is required.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#MaintenanceResponsibility"></see></summary>
    let MaintenanceResponsibility =
        Namespaced_IRI.parse _namespace_name "MaintenanceResponsibility" |> NamespacedName

    /// <summary>
    /// A Point is a point in space using its geographic coordinates.
    /// This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom - likely to be from WGS84_pos or OGC GeoSPARQL or both, or something else as proposed by the W3C SDWWG.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Point"></see></summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName
    /// <summary>
    /// This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom in the data - likely to be from WGS84_pos or OGC GeoSPARQL or both, or something else as proposed by the W3C SDWWG.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Polygon"></see></summary>
    let Polygon = Namespaced_IRI.parse _namespace_name "Polygon" |> NamespacedName
    /// <summary>
    /// A Role corresponds to the involvement of an Agent in an Event, e.g. fulfilling a publisher, contributor or custodian Role.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    /// States and Territories Government are the second tier of Government in the Commonwealth of Australia. The Commonwealth of Australia comprises of six states and various territories some of which enjoy a large degree of self-governance.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#StateOrTerritory"></see></summary>
    let StateOrTerritory =
        Namespaced_IRI.parse _namespace_name "StateOrTerritory" |> NamespacedName

    /// <summary>
    /// A Time Interval describes a time period (interval) during which data was collected or observations were made that are described in the Dataset.
    /// Note that this is a subclass of the Interval class from OWL-Time.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#Timelnterval"></see></summary>
    let Timelnterval =
        Namespaced_IRI.parse _namespace_name "Timelnterval" |> NamespacedName

    /// <summary>
    /// A relation to define the main category of the dataset. A dataset can have multiple themes.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#classifiedAs"></see></summary>
    let classifiedAs =
        Namespaced_IRI.parse _namespace_name "classifiedAs" |> NamespacedName

    /// <summary>
    /// The size of a distribution in bytes.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#fileSize"></see></summary>
    let fileSize = Namespaced_IRI.parse _namespace_name "fileSize" |> NamespacedName
    /// <summary>
    /// Defines a relationship for the Agent responsible for a DatasetChangeEvent through an Association that defines the Organisation that the Agent is associated with for that Event.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasAgent"></see></summary>
    let hasAgent = Namespaced_IRI.parse _namespace_name "hasAgent" |> NamespacedName
    /// <summary>
    /// Defines an agent who is the contact for inquiries on a Dataset.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasContact"></see></summary>
    let hasContact = Namespaced_IRI.parse _namespace_name "hasContact" |> NamespacedName
    /// <summary>
    /// Defines a Dataset to be part of a Catalog.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasDataset"></see></summary>
    let hasDataset = Namespaced_IRI.parse _namespace_name "hasDataset" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#inCatalog"></see>
    /// </summary>
    let inCatalog = Namespaced_IRI.parse _namespace_name "inCatalog" |> NamespacedName

    /// <summary>
    /// Defines the available distribution(s) for a Dataset.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasDistribution"></see></summary>
    let hasDistribution =
        Namespaced_IRI.parse _namespace_name "hasDistribution" |> NamespacedName

    /// <summary>
    /// Defines the URLs that contains the Distribution of the Dataset in a given format.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasDownloadURL"></see></summary>
    let hasDownloadURL =
        Namespaced_IRI.parse _namespace_name "hasDownloadURL" |> NamespacedName

    /// <summary>
    /// Defines a relation that associates a Catalog, Dataset or Distribution with its (one) main Web page that can be navigated to in a Web browser to gain access to the dataset, its distributions and/or additional information.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasLandingPage"></see></summary>
    let hasLandingPage =
        Namespaced_IRI.parse _namespace_name "hasLandingPage" |> NamespacedName

    /// <summary>
    /// Defines a relation that denotes the Level of Government of an Organisation, typically a Government Agency.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasLevelOfGovernment"></see></summary>
    let hasLevelOfGovernment =
        Namespaced_IRI.parse _namespace_name "hasLevelOfGovernment" |> NamespacedName

    /// <summary>
    /// A relation that associates a Catalog, Dataset or Distribution to its license document under which it is made available.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasLicense"></see></summary>
    let hasLicense = Namespaced_IRI.parse _namespace_name "hasLicense" |> NamespacedName

    /// <summary>
    /// Defines a relation that denotes the Local Government representing a Locality (a Spatial Thing).
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasLocalGovernmentArea"></see></summary>
    let hasLocalGovernmentArea =
        Namespaced_IRI.parse _namespace_name "hasLocalGovernmentArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#hasMember"></see>
    /// </summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName
    /// <summary>
    /// Defines a relation that denotes the beloning of an Agent to an Organisation.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName
    /// <summary>
    /// The purpose of a Dataset.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasPurpose"></see></summary>
    let hasPurpose = Namespaced_IRI.parse _namespace_name "hasPurpose" |> NamespacedName

    /// <summary>
    /// Spatial extent corresponds to the geographic area within which all items in the dataset fall.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasSpatialExtent"></see></summary>
    let hasSpatialExtent =
        Namespaced_IRI.parse _namespace_name "hasSpatialExtent" |> NamespacedName

    /// <summary>
    /// Temporal extent corresponds to the time interval within which all items in the dataset occur.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasTemporalExtent"></see></summary>
    let hasTemporalExtent =
        Namespaced_IRI.parse _namespace_name "hasTemporalExtent" |> NamespacedName

    /// <summary>
    /// Describes the anticipated frequency of updates of a Dataset.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#hasUpdateFrequency"></see></summary>
    let hasUpdateFrequency =
        Namespaced_IRI.parse _namespace_name "hasUpdateFrequency" |> NamespacedName

    /// <summary>
    /// Defines an association between a Dataset Change Event (e.g. Publishing) and an Association that defines the Agent and/or the Organisation responsible for that Change Event.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#isAssociatedWith"></see></summary>
    let isAssociatedWith =
        Namespaced_IRI.parse _namespace_name "isAssociatedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#participatesIn"></see>
    /// </summary>
    let participatesIn =
        Namespaced_IRI.parse _namespace_name "participatesIn" |> NamespacedName

    /// <summary>
    /// Defines a relation that relates a Dataset Change Event to a Dataset. Typically, at least, a Publishing Change Event should be defined that describes when a Dataset is published on the Web.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#isChangedBy"></see></summary>
    let isChangedBy =
        Namespaced_IRI.parse _namespace_name "isChangedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#resultedIn"></see>
    /// </summary>
    let resultedIn = Namespaced_IRI.parse _namespace_name "resultedIn" |> NamespacedName

    /// <summary>
    /// Defines a relation that associates a Thing to a Dataset that describes the Dataset in more detail.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#isDescribedBy"></see></summary>
    let isDescribedBy =
        Namespaced_IRI.parse _namespace_name "isDescribedBy" |> NamespacedName

    /// <summary>
    /// A keyword associated with the Dataset.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName

    /// <summary>
    /// Links to a description of a maintenance activity.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#maintenanceArrangement"></see></summary>
    let maintenanceArrangement =
        Namespaced_IRI.parse _namespace_name "maintenanceArrangement" |> NamespacedName

    /// <summary>
    /// A relation that defines the Role someone plays in a Dataset Change event defined through an Association entity.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#playsRole"></see></summary>
    let playsRole = Namespaced_IRI.parse _namespace_name "playsRole" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#roleOf"></see>
    /// </summary>
    let roleOf = Namespaced_IRI.parse _namespace_name "roleOf" |> NamespacedName
    /// <summary>
    /// A Publisher plays the Role of uploading the Dataset to data.gov.au.
    /// <see href="http://reference.data.gov.au/def/ont/dataset#publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    ///   <see href="http://reference.data.gov.au/def/ont/dataset#updateDate"></see>
    /// </summary>
    let updateDate = Namespaced_IRI.parse _namespace_name "updateDate" |> NamespacedName
