namespace http.reference.data.gov.au.def.ont.dataset.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module donto =
    let _namespace_iri = Namespace_Iri donto |> NamespaceIRI
    /// <summary>
    ///   <para>donto:hasTemporalExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Temporal extent corresponds to the time interval within which all items in the dataset occur.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasTemporalExtent">http://reference.data.gov.au/def/ont/dataset#hasTemporalExtent</seealso>
    let hasTemporalExtent = Prefixed_Name(donto, "hasTemporalExtent") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasUpdateFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the anticipated frequency of updates of a Dataset.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasUpdateFrequency">http://reference.data.gov.au/def/ont/dataset#hasUpdateFrequency</seealso>
    let hasUpdateFrequency = Prefixed_Name(donto, "hasUpdateFrequency") |> PrefixedName
    /// <summary>
    ///   <para>donto:isAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines an association between a Dataset Change Event (e.g. Publishing) and an Association that defines the Agent and/or the Organisation responsible for that Change Event.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#isAssociatedWith">http://reference.data.gov.au/def/ont/dataset#isAssociatedWith</seealso>
    let isAssociatedWith = Prefixed_Name(donto, "isAssociatedWith") |> PrefixedName
    /// <summary>
    ///   <para>donto:isChangedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a relation that relates a Dataset Change Event to a Dataset. Typically, at least, a Publishing Change Event should be defined that describes when a Dataset is published on the Web.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#isChangedBy">http://reference.data.gov.au/def/ont/dataset#isChangedBy</seealso>
    let isChangedBy = Prefixed_Name(donto, "isChangedBy") |> PrefixedName
    /// <summary>
    ///   <para>donto:resultedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#resultedIn">http://reference.data.gov.au/def/ont/dataset#resultedIn</seealso>
    let resultedIn = Prefixed_Name(donto, "resultedIn") |> PrefixedName
    /// <summary>
    ///   <para>donto:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a relation that associates a Thing to a Dataset that describes the Dataset in more detail.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#isDescribedBy">http://reference.data.gov.au/def/ont/dataset#isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(donto, "isDescribedBy") |> PrefixedName

    /// <summary>
    ///   <para>donto:MaintenanceResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides information about the maintenance arrangements for the dataset. At a minimum the Agent and start-time for the maintenance responsibility is required.</para>
    /// labels<para>Dataset Maintenance Arrangement</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#MaintenanceResponsibility">http://reference.data.gov.au/def/ont/dataset#MaintenanceResponsibility</seealso>
    let MaintenanceResponsibility =
        Prefixed_Name(donto, "MaintenanceResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>donto:agiftFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The AGIFT classification for this dataset</para>
    /// labels<para>AGIFT Theme</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#agiftFunction">http://reference.data.gov.au/def/ont/dataset#agiftFunction</seealso>
    let agiftFunction = Prefixed_Name(donto, "agiftFunction") |> PrefixedName
    /// <summary>
    ///   <para>donto:DatasetChangeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Dataset Change Event is a description of an event that happens at a given point in time and that results in any type of change to the Dataset.</para>
    /// labels<para>Dataset Change Event</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#DatasetChangeEvent">http://reference.data.gov.au/def/ont/dataset#DatasetChangeEvent</seealso>
    let DatasetChangeEvent = Prefixed_Name(donto, "DatasetChangeEvent") |> PrefixedName
    /// <summary>
    ///   <para>donto:Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Distribution defines the available form of a Dataset, i.e. different formats of the Dataset or different type of endpoints the Dataset can be retrieved from.</para>
    /// labels<para>Distribution</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Distribution">http://reference.data.gov.au/def/ont/dataset#Distribution</seealso>
    let Distribution = Prefixed_Name(donto, "Distribution") |> PrefixedName

    /// <summary>
    ///   <para>donto:DatasetPublicationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Dataset Publication Event is a description of an event that happens at a given point in time and that results in the publication of a Dataset on data.gov.au.</para>
    /// labels<para>Dataset Publication Event</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#DatasetPublicationEvent">http://reference.data.gov.au/def/ont/dataset#DatasetPublicationEvent</seealso>
    let DatasetPublicationEvent =
        Prefixed_Name(donto, "DatasetPublicationEvent") |> PrefixedName

    /// <summary>
    ///   <para>donto:fileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The size of a distribution in bytes.</para>
    /// labels<para>File Size</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#fileSize">http://reference.data.gov.au/def/ont/dataset#fileSize</seealso>
    let fileSize = Prefixed_Name(donto, "fileSize") |> PrefixedName
    /// <summary>
    ///   <para>donto:participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#participatesIn">http://reference.data.gov.au/def/ont/dataset#participatesIn</seealso>
    let participatesIn = Prefixed_Name(donto, "participatesIn") |> PrefixedName
    /// <summary>
    ///   <para>donto:AGIFTFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Government Function defined by the Australian Governments' Interactive Functions Thesaurus that best describes the data contained within a Dataset.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#AGIFTFunction">http://reference.data.gov.au/def/ont/dataset#AGIFTFunction</seealso>
    let AGIFTFunction = Prefixed_Name(donto, "AGIFTFunction") |> PrefixedName
    /// <summary>
    ///   <para>donto:Classifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A classifier used for Australian Government Data.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Classifier">http://reference.data.gov.au/def/ont/dataset#Classifier</seealso>
    let Classifier = Prefixed_Name(donto, "Classifier") |> PrefixedName

    /// <summary>
    ///   <para>donto:AssociatedOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An AssociatedOrganisation is an Organisation that is responsible for an Event that changed a Dataset the Organisation is associated with.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#AssociatedOrganisation">http://reference.data.gov.au/def/ont/dataset#AssociatedOrganisation</seealso>
    let AssociatedOrganisation =
        Prefixed_Name(donto, "AssociatedOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>donto:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Catalog is a curated collection of metadata about datasets.</para>
    /// labels<para>Catalog</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Catalog">http://reference.data.gov.au/def/ont/dataset#Catalog</seealso>
    let Catalog = Prefixed_Name(donto, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>donto:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Dataset is a collection of resources, published or curated by an agent, and openly available for download in one or more formats.</para>
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Dataset">http://reference.data.gov.au/def/ont/dataset#Dataset</seealso>
    let Dataset = Prefixed_Name(donto, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>donto:dateChangeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date a change was made.</para>
    /// labels<para>Change Event Date</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#dateChangeEvent">http://reference.data.gov.au/def/ont/dataset#dateChangeEvent</seealso>
    let dateChangeEvent = Prefixed_Name(donto, "dateChangeEvent") |> PrefixedName
    /// <summary>
    ///   <para>donto:dateUpdated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to define when the Dataset was updated, i.e. a minor change that is not reflected in a Dataset Change Event.</para>
    /// labels<para>Update Date</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#dateUpdated">http://reference.data.gov.au/def/ont/dataset#dateUpdated</seealso>
    let dateUpdated = Prefixed_Name(donto, "dateUpdated") |> PrefixedName
    /// <summary>
    ///   <para>donto:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Document</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Document">http://reference.data.gov.au/def/ont/dataset#Document</seealso>
    let Document = Prefixed_Name(donto, "Document") |> PrefixedName
    /// <summary>
    ///   <para>donto:Federal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Federal Government denotes the federal democratic administrative authority of the Commonwealth of Australia.</para>
    /// labels<para>Federal Government</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Federal">http://reference.data.gov.au/def/ont/dataset#Federal</seealso>
    let Federal = Prefixed_Name(donto, "Federal") |> PrefixedName
    /// <summary>
    ///   <para>donto:LevelOfGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Level of Government is a description that is used to describe the Jurisidiction of an Organisation.</para>
    /// labels<para>Level of Government</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#LevelOfGovernment">http://reference.data.gov.au/def/ont/dataset#LevelOfGovernment</seealso>
    let LevelOfGovernment = Prefixed_Name(donto, "LevelOfGovernment") |> PrefixedName
    /// <summary>
    ///   <para>donto:FieldOfResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Field of Research defined by the Australian and New Zealand Standard Research Classification (ANZSRC) that best describes the type of methods applied to obtain the data contained within a Dataset.</para>
    /// labels<para>Field of Research</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#FieldOfResearch">http://reference.data.gov.au/def/ont/dataset#FieldOfResearch</seealso>
    let FieldOfResearch = Prefixed_Name(donto, "FieldOfResearch") |> PrefixedName
    /// <summary>
    ///   <para>donto:GazettedLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Locality with a name authorised by a government agency</para>
    /// labels<para>Spatial Gazetteer</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#GazettedLocality">http://reference.data.gov.au/def/ont/dataset#GazettedLocality</seealso>
    let GazettedLocality = Prefixed_Name(donto, "GazettedLocality") |> PrefixedName
    /// <summary>
    ///   <para>donto:Locality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Locality is a Spatial Thing corresponding to a place or area, which is denoted by a commonly recognised, or formally designated, name or description.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Locality">http://reference.data.gov.au/def/ont/dataset#Locality</seealso>
    let Locality = Prefixed_Name(donto, "Locality") |> PrefixedName
    /// <summary>
    ///   <para>donto:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Geometry">http://reference.data.gov.au/def/ont/dataset#Geometry</seealso>
    let Geometry = Prefixed_Name(donto, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>donto:SpatialThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom in the data - likely to be  w3 geo or OGC GeoSPARQL or both, or something else as proposed by SDWWG.</para>
    ///   <para>A Spatial Thing describes the spatial characteristics of the resources within a Dataset, i.e. the geographical area where data was collected, a place which is the predominant subject of the Dataset, or a location which is the focus of an activity described in the Dataset.</para>
    /// labels<para>Spatial Thing</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#SpatialThing">http://reference.data.gov.au/def/ont/dataset#SpatialThing</seealso>
    let SpatialThing = Prefixed_Name(donto, "SpatialThing") |> PrefixedName
    /// <summary>
    ///   <para>donto:GovernmentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Government Agency is a kind of Organisation in the Commonwealth of Australia that is a distinct and recognisable body which has responsibility for carrying out administrative functions.</para>
    /// labels<para>Government Agency</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#GovernmentAgency">http://reference.data.gov.au/def/ont/dataset#GovernmentAgency</seealso>
    let GovernmentAgency = Prefixed_Name(donto, "GovernmentAgency") |> PrefixedName
    /// <summary>
    ///   <para>donto:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Organisation is a kind of Agent representing, for example, a business or government, or organisational subunits thereof.</para>
    /// labels<para>Organisation</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Organisation">http://reference.data.gov.au/def/ont/dataset#Organisation</seealso>
    let Organisation = Prefixed_Name(donto, "Organisation") |> PrefixedName

    /// <summary>
    ///   <para>donto:LocalGovernmentArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Local Government is the lowest tier of government in the Commonwealth of Australia administered under the states and territories.</para>
    /// labels<para>Local Government</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#LocalGovernmentArea">http://reference.data.gov.au/def/ont/dataset#LocalGovernmentArea</seealso>
    let LocalGovernmentArea =
        Prefixed_Name(donto, "LocalGovernmentArea") |> PrefixedName

    /// <summary>
    ///   <para>donto:inState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the State or Territory a Locality is located in.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#inState">http://reference.data.gov.au/def/ont/dataset#inState</seealso>
    let inState = Prefixed_Name(donto, "inState") |> PrefixedName
    /// <summary>
    ///   <para>donto:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom - likely to be from WGS84_pos or OGC GeoSPARQL or both, or something else as proposed by the W3C SDWWG.</para>
    ///   <para>A Point is a point in space using its geographic coordinates.</para>
    /// labels<para>Point</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Point">http://reference.data.gov.au/def/ont/dataset#Point</seealso>
    let Point = Prefixed_Name(donto, "Point") |> PrefixedName
    /// <summary>
    ///   <para>donto:Polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom in the data - likely to be from WGS84_pos or OGC GeoSPARQL or both, or something else as proposed by the W3C SDWWG.</para>
    /// labels<para>Polygon</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Polygon">http://reference.data.gov.au/def/ont/dataset#Polygon</seealso>
    let Polygon = Prefixed_Name(donto, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>donto:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Role corresponds to the involvement of an Agent in an Event, e.g. fulfilling a publisher, contributor or custodian Role.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Role">http://reference.data.gov.au/def/ont/dataset#Role</seealso>
    let Role = Prefixed_Name(donto, "Role") |> PrefixedName
    /// <summary>
    ///   <para>donto:StateOrTerritory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>States and Territories Government are the second tier of Government in the Commonwealth of Australia. The Commonwealth of Australia comprises of six states and various territories some of which enjoy a large degree of self-governance.</para>
    /// labels<para>State and Territories Government</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#StateOrTerritory">http://reference.data.gov.au/def/ont/dataset#StateOrTerritory</seealso>
    let StateOrTerritory = Prefixed_Name(donto, "StateOrTerritory") |> PrefixedName
    /// <summary>
    ///   <para>donto:Timelnterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Time Interval describes a time period (interval) during which data was collected or observations were made that are described in the Dataset.</para>
    ///   <para>Note that this is a subclass of the Interval class from OWL-Time.</para>
    /// labels<para>Time Interval</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#Timelnterval">http://reference.data.gov.au/def/ont/dataset#Timelnterval</seealso>
    let Timelnterval = Prefixed_Name(donto, "Timelnterval") |> PrefixedName
    /// <summary>
    ///   <para>donto:classifiedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to define the main category of the dataset. A dataset can have multiple themes.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#classifiedAs">http://reference.data.gov.au/def/ont/dataset#classifiedAs</seealso>
    let classifiedAs = Prefixed_Name(donto, "classifiedAs") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a relationship for the Agent responsible for a DatasetChangeEvent through an Association that defines the Organisation that the Agent is associated with for that Event.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasAgent">http://reference.data.gov.au/def/ont/dataset#hasAgent</seealso>
    let hasAgent = Prefixed_Name(donto, "hasAgent") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines an agent who is the contact for inquiries on a Dataset.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasContact">http://reference.data.gov.au/def/ont/dataset#hasContact</seealso>
    let hasContact = Prefixed_Name(donto, "hasContact") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a Dataset to be part of a Catalog.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasDataset">http://reference.data.gov.au/def/ont/dataset#hasDataset</seealso>
    let hasDataset = Prefixed_Name(donto, "hasDataset") |> PrefixedName
    /// <summary>
    ///   <para>donto:inCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#inCatalog">http://reference.data.gov.au/def/ont/dataset#inCatalog</seealso>
    let inCatalog = Prefixed_Name(donto, "inCatalog") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the available distribution(s) for a Dataset.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasDistribution">http://reference.data.gov.au/def/ont/dataset#hasDistribution</seealso>
    let hasDistribution = Prefixed_Name(donto, "hasDistribution") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasDownloadURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the URLs that contains the Distribution of the Dataset in a given format.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasDownloadURL">http://reference.data.gov.au/def/ont/dataset#hasDownloadURL</seealso>
    let hasDownloadURL = Prefixed_Name(donto, "hasDownloadURL") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasLandingPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a relation that associates a Catalog, Dataset or Distribution with its (one) main Web page that can be navigated to in a Web browser to gain access to the dataset, its distributions and/or additional information.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasLandingPage">http://reference.data.gov.au/def/ont/dataset#hasLandingPage</seealso>
    let hasLandingPage = Prefixed_Name(donto, "hasLandingPage") |> PrefixedName

    /// <summary>
    ///   <para>donto:hasLevelOfGovernment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a relation that denotes the Level of Government of an Organisation, typically a Government Agency.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasLevelOfGovernment">http://reference.data.gov.au/def/ont/dataset#hasLevelOfGovernment</seealso>
    let hasLevelOfGovernment =
        Prefixed_Name(donto, "hasLevelOfGovernment") |> PrefixedName

    /// <summary>
    ///   <para>donto:hasLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation that associates a Catalog, Dataset or Distribution to its license document under which it is made available.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasLicense">http://reference.data.gov.au/def/ont/dataset#hasLicense</seealso>
    let hasLicense = Prefixed_Name(donto, "hasLicense") |> PrefixedName

    /// <summary>
    ///   <para>donto:hasLocalGovernmentArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a relation that denotes the Local Government representing a Locality (a Spatial Thing).</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasLocalGovernmentArea">http://reference.data.gov.au/def/ont/dataset#hasLocalGovernmentArea</seealso>
    let hasLocalGovernmentArea =
        Prefixed_Name(donto, "hasLocalGovernmentArea") |> PrefixedName

    /// <summary>
    ///   <para>donto:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasMember">http://reference.data.gov.au/def/ont/dataset#hasMember</seealso>
    let hasMember = Prefixed_Name(donto, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>donto:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines a relation that denotes the beloning of an Agent to an Organisation.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#isMemberOf">http://reference.data.gov.au/def/ont/dataset#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(donto, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The purpose of a Dataset.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasPurpose">http://reference.data.gov.au/def/ont/dataset#hasPurpose</seealso>
    let hasPurpose = Prefixed_Name(donto, "hasPurpose") |> PrefixedName
    /// <summary>
    ///   <para>donto:hasSpatialExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Spatial extent corresponds to the geographic area within which all items in the dataset fall.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#hasSpatialExtent">http://reference.data.gov.au/def/ont/dataset#hasSpatialExtent</seealso>
    let hasSpatialExtent = Prefixed_Name(donto, "hasSpatialExtent") |> PrefixedName
    /// <summary>
    ///   <para>donto:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A keyword associated with the Dataset.</para>
    /// labels<para>Keyword</para></remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#keyword">http://reference.data.gov.au/def/ont/dataset#keyword</seealso>
    let keyword = Prefixed_Name(donto, "keyword") |> PrefixedName

    /// <summary>
    ///   <para>donto:maintenanceArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to a description of a maintenance activity.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#maintenanceArrangement">http://reference.data.gov.au/def/ont/dataset#maintenanceArrangement</seealso>
    let maintenanceArrangement =
        Prefixed_Name(donto, "maintenanceArrangement") |> PrefixedName

    /// <summary>
    ///   <para>donto:playsRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation that defines the Role someone plays in a Dataset Change event defined through an Association entity.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#playsRole">http://reference.data.gov.au/def/ont/dataset#playsRole</seealso>
    let playsRole = Prefixed_Name(donto, "playsRole") |> PrefixedName
    /// <summary>
    ///   <para>donto:roleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#roleOf">http://reference.data.gov.au/def/ont/dataset#roleOf</seealso>
    let roleOf = Prefixed_Name(donto, "roleOf") |> PrefixedName
    /// <summary>
    ///   <para>donto:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A Publisher plays the Role of uploading the Dataset to data.gov.au.</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#publisher">http://reference.data.gov.au/def/ont/dataset#publisher</seealso>
    let publisher = Prefixed_Name(donto, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>donto:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#title">http://reference.data.gov.au/def/ont/dataset#title</seealso>
    let title = Prefixed_Name(donto, "title") |> PrefixedName
    /// <summary>
    ///   <para>donto:updateDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://reference.data.gov.au/def/ont/dataset#updateDate">http://reference.data.gov.au/def/ont/dataset#updateDate</seealso>
    let updateDate = Prefixed_Name(donto, "updateDate") |> PrefixedName
