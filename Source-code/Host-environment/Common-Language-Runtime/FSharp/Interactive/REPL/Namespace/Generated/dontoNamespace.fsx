#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module donto =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://reference.data.gov.au/def/ont/dataset#" "donto"

    /// <summary>
    ///   <para>rdfs:label : Function</para>
    ///   <para>rdfs:comment : The Government Function defined by the Australian Governments' Interactive Functions Thesaurus that best describes the data contained within a Dataset.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#AGIFTFunction">donto:AGIFTFunction</a>
    /// </summary>
    let AGIFTFunction = _prefixId.prefix "AGIFTFunction"
    /// <summary>
    ///   <para>rdfs:comment : An AssociatedOrganisation is an Organisation that is responsible for an Event that changed a Dataset the Organisation is associated with.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#AssociatedOrganisation">donto:AssociatedOrganisation</a>
    /// </summary>
    let AssociatedOrganisation = _prefixId.prefix "AssociatedOrganisation"
    /// <summary>
    ///   <para>rdfs:label : Catalog</para>
    ///   <para>rdfs:isDefinedBy : https://www.w3.org/ns/dcat#Catalog</para>
    ///   <para>rdfs:comment : A Catalog is a curated collection of metadata about datasets.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Catalog">donto:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:comment : A classifier used for Australian Government Data.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Classifier">donto:Classifier</a>
    /// </summary>
    let Classifier = _prefixId.prefix "Classifier"
    /// <summary>
    ///   <para>rdfs:label : Dataset</para>
    ///   <para>rdfs:comment : A Dataset is a collection of resources, published or curated by an agent, and openly available for download in one or more formats.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Dataset">donto:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Dataset Change Event</para>
    ///   <para>rdfs:comment : A Dataset Change Event is a description of an event that happens at a given point in time and that results in any type of change to the Dataset.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#DatasetChangeEvent">donto:DatasetChangeEvent</a>
    /// </summary>
    let DatasetChangeEvent = _prefixId.prefix "DatasetChangeEvent"
    /// <summary>
    ///   <para>rdfs:label : Dataset Publication Event</para>
    ///   <para>rdfs:comment : A Dataset Publication Event is a description of an event that happens at a given point in time and that results in the publication of a Dataset on data.gov.au.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#DatasetPublicationEvent">donto:DatasetPublicationEvent</a>
    /// </summary>
    let DatasetPublicationEvent = _prefixId.prefix "DatasetPublicationEvent"
    /// <summary>
    ///   <para>rdfs:label : Distribution</para>
    ///   <para>rdfs:comment : A Distribution defines the available form of a Dataset, i.e. different formats of the Dataset or different type of endpoints the Dataset can be retrieved from.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Distribution">donto:Distribution</a>
    /// </summary>
    let Distribution = _prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>rdfs:label : Document</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Document">donto:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : Federal Government</para>
    ///   <para>rdfs:comment : Federal Government denotes the federal democratic administrative authority of the Commonwealth of Australia.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Federal">donto:Federal</a>
    /// </summary>
    let Federal = _prefixId.prefix "Federal"
    /// <summary>
    ///   <para>rdfs:label : Field of Research</para>
    ///   <para>rdfs:comment : The Field of Research defined by the Australian and New Zealand Standard Research Classification (ANZSRC) that best describes the type of methods applied to obtain the data contained within a Dataset.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#FieldOfResearch">donto:FieldOfResearch</a>
    /// </summary>
    let FieldOfResearch = _prefixId.prefix "FieldOfResearch"
    /// <summary>
    ///   <para>rdfs:label : Spatial Gazetteer</para>
    ///   <para>rdfs:comment : Locality with a name authorised by a government agency^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#GazettedLocality">donto:GazettedLocality</a>
    /// </summary>
    let GazettedLocality = _prefixId.prefix "GazettedLocality"
    let Geometry = _prefixId.prefix "Geometry"
    /// <summary>
    ///   <para>rdfs:label : Government Agency</para>
    ///   <para>rdfs:comment : A Government Agency is a kind of Organisation in the Commonwealth of Australia that is a distinct and recognisable body which has responsibility for carrying out administrative functions.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#GovernmentAgency">donto:GovernmentAgency</a>
    /// </summary>
    let GovernmentAgency = _prefixId.prefix "GovernmentAgency"
    /// <summary>
    ///   <para>rdfs:label : Level of Government</para>
    ///   <para>rdfs:comment : Level of Government is a description that is used to describe the Jurisidiction of an Organisation.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#LevelOfGovernment">donto:LevelOfGovernment</a>
    /// </summary>
    let LevelOfGovernment = _prefixId.prefix "LevelOfGovernment"
    /// <summary>
    ///   <para>rdfs:label : Local Government</para>
    ///   <para>rdfs:comment : Local Government is the lowest tier of government in the Commonwealth of Australia administered under the states and territories.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#LocalGovernmentArea">donto:LocalGovernmentArea</a>
    /// </summary>
    let LocalGovernmentArea = _prefixId.prefix "LocalGovernmentArea"
    /// <summary>
    ///   <para>rdfs:comment : Locality is a Spatial Thing corresponding to a place or area, which is denoted by a commonly recognised, or formally designated, name or description.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Locality">donto:Locality</a>
    /// </summary>
    let Locality = _prefixId.prefix "Locality"
    /// <summary>
    ///   <para>rdfs:label : Dataset Maintenance Arrangement</para>
    ///   <para>rdfs:comment : Provides information about the maintenance arrangements for the dataset. At a minimum the Agent and start-time for the maintenance responsibility is required.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#MaintenanceResponsibility">donto:MaintenanceResponsibility</a>
    /// </summary>
    let MaintenanceResponsibility = _prefixId.prefix "MaintenanceResponsibility"
    /// <summary>
    ///   <para>rdfs:label : Organisation</para>
    ///   <para>rdfs:comment : An Organisation is a kind of Agent representing, for example, a business or government, or organisational subunits thereof.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Organisation">donto:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:label : Point</para>
    ///   <para>rdfs:comment : A Point is a point in space using its geographic coordinates.rdfs:comment : This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom - likely to be from WGS84_pos or OGC GeoSPARQL or both, or something else as proposed by the W3C SDWWG.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Point">donto:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : Polygon</para>
    ///   <para>rdfs:comment : This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom in the data - likely to be from WGS84_pos or OGC GeoSPARQL or both, or something else as proposed by the W3C SDWWG.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Polygon">donto:Polygon</a>
    /// </summary>
    let Polygon = _prefixId.prefix "Polygon"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>rdfs:comment : A Role corresponds to the involvement of an Agent in an Event, e.g. fulfilling a publisher, contributor or custodian Role.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Role">donto:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Spatial Thing</para>
    ///   <para>rdfs:comment : A Spatial Thing describes the spatial characteristics of the resources within a Dataset, i.e. the geographical area where data was collected, a place which is the predominant subject of the Dataset, or a location which is the focus of an activity described in the Dataset.rdfs:comment : This is a stub class which allows us to defer which external vocabulary to adopt. Adoption can be at run-time through a owl:equivalentClass axiom in the data - likely to be  w3 geo or OGC GeoSPARQL or both, or something else as proposed by SDWWG.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#SpatialThing">donto:SpatialThing</a>
    /// </summary>
    let SpatialThing = _prefixId.prefix "SpatialThing"
    /// <summary>
    ///   <para>rdfs:label : State and Territories Government</para>
    ///   <para>rdfs:comment : States and Territories Government are the second tier of Government in the Commonwealth of Australia. The Commonwealth of Australia comprises of six states and various territories some of which enjoy a large degree of self-governance.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#StateOrTerritory">donto:StateOrTerritory</a>
    /// </summary>
    let StateOrTerritory = _prefixId.prefix "StateOrTerritory"
    /// <summary>
    ///   <para>rdfs:label : Time Interval</para>
    ///   <para>rdfs:comment : A Time Interval describes a time period (interval) during which data was collected or observations were made that are described in the Dataset.rdfs:comment : Note that this is a subclass of the Interval class from OWL-Time.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#Timelnterval">donto:Timelnterval</a>
    /// </summary>
    let Timelnterval = _prefixId.prefix "Timelnterval"
    /// <summary>
    ///   <para>rdfs:label : AGIFT Theme^^xsd:string</para>
    ///   <para>rdfs:comment : The AGIFT classification for this dataset^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#agiftFunction">donto:agiftFunction</a>
    /// </summary>
    let agiftFunction = _prefixId.prefix "agiftFunction"
    /// <summary>
    ///   <para>rdfs:comment : A relation to define the main category of the dataset. A dataset can have multiple themes.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#classifiedAs">donto:classifiedAs</a>
    /// </summary>
    let classifiedAs = _prefixId.prefix "classifiedAs"
    /// <summary>
    ///   <para>rdfs:label : Change Event Date</para>
    ///   <para>rdfs:comment : The date a change was made.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#dateChangeEvent">donto:dateChangeEvent</a>
    /// </summary>
    let dateChangeEvent = _prefixId.prefix "dateChangeEvent"
    /// <summary>
    ///   <para>rdfs:label : Update Date</para>
    ///   <para>rdfs:comment : A relation to define when the Dataset was updated, i.e. a minor change that is not reflected in a Dataset Change Event.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#dateUpdated">donto:dateUpdated</a>
    /// </summary>
    let dateUpdated = _prefixId.prefix "dateUpdated"
    /// <summary>
    ///   <para>rdfs:label : File Size</para>
    ///   <para>rdfs:comment : The size of a distribution in bytes.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#fileSize">donto:fileSize</a>
    /// </summary>
    let fileSize = _prefixId.prefix "fileSize"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relationship for the Agent responsible for a DatasetChangeEvent through an Association that defines the Organisation that the Agent is associated with for that Event.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasAgent">donto:hasAgent</a>
    /// </summary>
    let hasAgent = _prefixId.prefix "hasAgent"
    /// <summary>
    ///   <para>rdfs:comment : Defines an agent who is the contact for inquiries on a Dataset.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasContact">donto:hasContact</a>
    /// </summary>
    let hasContact = _prefixId.prefix "hasContact"
    /// <summary>
    ///   <para>rdfs:comment : Defines a Dataset to be part of a Catalog.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasDataset">donto:hasDataset</a>
    /// </summary>
    let hasDataset = _prefixId.prefix "hasDataset"
    /// <summary>
    ///   <para>rdfs:comment : Defines the available distribution(s) for a Dataset.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasDistribution">donto:hasDistribution</a>
    /// </summary>
    let hasDistribution = _prefixId.prefix "hasDistribution"
    /// <summary>
    ///   <para>rdfs:comment : Defines the URLs that contains the Distribution of the Dataset in a given format.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasDownloadURL">donto:hasDownloadURL</a>
    /// </summary>
    let hasDownloadURL = _prefixId.prefix "hasDownloadURL"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relation that associates a Catalog, Dataset or Distribution with its (one) main Web page that can be navigated to in a Web browser to gain access to the dataset, its distributions and/or additional information.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasLandingPage">donto:hasLandingPage</a>
    /// </summary>
    let hasLandingPage = _prefixId.prefix "hasLandingPage"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relation that denotes the Level of Government of an Organisation, typically a Government Agency.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasLevelOfGovernment">donto:hasLevelOfGovernment</a>
    /// </summary>
    let hasLevelOfGovernment = _prefixId.prefix "hasLevelOfGovernment"
    /// <summary>
    ///   <para>rdfs:comment : A relation that associates a Catalog, Dataset or Distribution to its license document under which it is made available.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasLicense">donto:hasLicense</a>
    /// </summary>
    let hasLicense = _prefixId.prefix "hasLicense"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relation that denotes the Local Government representing a Locality (a Spatial Thing).</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasLocalGovernmentArea">donto:hasLocalGovernmentArea</a>
    /// </summary>
    let hasLocalGovernmentArea = _prefixId.prefix "hasLocalGovernmentArea"
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:comment : The purpose of a Dataset.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasPurpose">donto:hasPurpose</a>
    /// </summary>
    let hasPurpose = _prefixId.prefix "hasPurpose"
    /// <summary>
    ///   <para>rdfs:comment : Spatial extent corresponds to the geographic area within which all items in the dataset fall.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasSpatialExtent">donto:hasSpatialExtent</a>
    /// </summary>
    let hasSpatialExtent = _prefixId.prefix "hasSpatialExtent"
    /// <summary>
    ///   <para>rdfs:comment : Temporal extent corresponds to the time interval within which all items in the dataset occur.^^xsd:string</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasTemporalExtent">donto:hasTemporalExtent</a>
    /// </summary>
    let hasTemporalExtent = _prefixId.prefix "hasTemporalExtent"
    /// <summary>
    ///   <para>rdfs:comment : Describes the anticipated frequency of updates of a Dataset.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#hasUpdateFrequency">donto:hasUpdateFrequency</a>
    /// </summary>
    let hasUpdateFrequency = _prefixId.prefix "hasUpdateFrequency"
    let inCatalog = _prefixId.prefix "inCatalog"
    /// <summary>
    ///   <para>rdfs:comment : Defines the State or Territory a Locality is located in.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#inState">donto:inState</a>
    /// </summary>
    let inState = _prefixId.prefix "inState"
    /// <summary>
    ///   <para>rdfs:comment : Defines an association between a Dataset Change Event (e.g. Publishing) and an Association that defines the Agent and/or the Organisation responsible for that Change Event.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#isAssociatedWith">donto:isAssociatedWith</a>
    /// </summary>
    let isAssociatedWith = _prefixId.prefix "isAssociatedWith"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relation that relates a Dataset Change Event to a Dataset. Typically, at least, a Publishing Change Event should be defined that describes when a Dataset is published on the Web.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#isChangedBy">donto:isChangedBy</a>
    /// </summary>
    let isChangedBy = _prefixId.prefix "isChangedBy"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relation that associates a Thing to a Dataset that describes the Dataset in more detail.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#isDescribedBy">donto:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:comment : Defines a relation that denotes the beloning of an Agent to an Organisation.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#isMemberOf">donto:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:label : Keyword</para>
    ///   <para>rdfs:comment : A keyword associated with the Dataset.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#keyword">donto:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:comment : Links to a description of a maintenance activity.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#maintenanceArrangement">donto:maintenanceArrangement</a>
    /// </summary>
    let maintenanceArrangement = _prefixId.prefix "maintenanceArrangement"
    let participatesIn = _prefixId.prefix "participatesIn"
    /// <summary>
    ///   <para>rdfs:comment : A relation that defines the Role someone plays in a Dataset Change event defined through an Association entity.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#playsRole">donto:playsRole</a>
    /// </summary>
    let playsRole = _prefixId.prefix "playsRole"
    /// <summary>
    ///   <para>rdfs:comment : A Publisher plays the Role of uploading the Dataset to data.gov.au.</para>
    ///   <a href="http://reference.data.gov.au/def/ont/dataset#publisher">donto:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    let resultedIn = _prefixId.prefix "resultedIn"
    let roleOf = _prefixId.prefix "roleOf"
    let title = _prefixId.prefix "title"
    let updateDate = _prefixId.prefix "updateDate"
