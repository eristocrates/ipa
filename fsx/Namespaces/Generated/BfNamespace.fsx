#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bf =
    let _prefixId = PrefixId.fromNamespaceLabel "http://id.loc.gov/ontologies/bibframe/" "bf"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Abbreviated title^^xsd:string</para>
    ///   <para>skos:definition : Title as abbreviated for citation, indexing, and/or identification^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AbbreviatedTitle">bf:AbbreviatedTitle</a>
    /// </summary>
    let AbbreviatedTitle = _prefixId.prefix "AbbreviatedTitle"
    /// <summary>
    ///   <para>rdfs:label : Access policy^^xsd:string</para>
    ///   <para>skos:definition : Access restrictions and allowances regarding access to a resource, e.g., lending policy, access restrictions, embargos^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AccessPolicy">bf:AccessPolicy</a>
    /// </summary>
    let AccessPolicy = _prefixId.prefix "AccessPolicy"
    /// <summary>
    ///   <para>rdfs:label : Accession number^^xsd:string</para>
    ///   <para>skos:definition : Accession Number^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH11])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AccessionNumber">bf:AccessionNumber</a>
    /// </summary>
    let AccessionNumber = _prefixId.prefix "AccessionNumber"
    /// <summary>
    ///   <para>rdfs:label : Acquisition source^^xsd:string</para>
    ///   <para>skos:definition : Information about an organization, person, etc., from which a resource may be obtained^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-06 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AcquisitionSource">bf:AcquisitionSource</a>
    /// </summary>
    let AcquisitionSource = _prefixId.prefix "AcquisitionSource"
    /// <summary>
    ///   <para>rdfs:label : Administrative metadata^^xsd:string</para>
    ///   <para>skos:definition : Metadata about the metadata, especially provenance information^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AdminMetadata">bf:AdminMetadata</a>
    /// </summary>
    let AdminMetadata = _prefixId.prefix "AdminMetadata"
    /// <summary>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <para>skos:definition : Entity having a role in a resource, such as a person or organization^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-05-13 (New subclass)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Agent">bf:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : ANSI number^^xsd:string</para>
    ///   <para>skos:definition : American National Standards Institute identifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Ansi">bf:Ansi</a>
    /// </summary>
    let Ansi = _prefixId.prefix "Ansi"
    /// <summary>
    ///   <para>rdfs:label : Applied material^^xsd:string</para>
    ///   <para>skos:definition : Physical or chemical substance applied to a base material of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Changed subclass to Material [GH28])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AppliedMaterial">bf:AppliedMaterial</a>
    /// </summary>
    let AppliedMaterial = _prefixId.prefix "AppliedMaterial"
    /// <summary>
    ///   <para>rdfs:label : Archival controlled^^xsd:string</para>
    ///   <para>skos:definition : Resources organically created, accumulated, and/or used by a person, family, or organization in the course of conduct of affairs and preserved because of their continuing value^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Archival">bf:Archival</a>
    /// </summary>
    let Archival = _prefixId.prefix "Archival"
    /// <summary>
    ///   <para>rdfs:label : Arrangement^^xsd:string</para>
    ///   <para>skos:definition : Resource that represents an arrangement of another resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Redefined [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Arrangement">bf:Arrangement</a>
    /// </summary>
    let Arrangement = _prefixId.prefix "Arrangement"
    /// <summary>
    ///   <para>rdfs:label : Aspect ratio^^xsd:string</para>
    ///   <para>skos:definition : Proportional relationship between an image's width and its height^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AspectRatio">bf:AspectRatio</a>
    /// </summary>
    let AspectRatio = _prefixId.prefix "AspectRatio"
    /// <summary>
    ///   <para>rdfs:label : Audio^^xsd:string</para>
    ///   <para>skos:definition : Resources expressed in an audible form, including music or other sounds^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Audio">bf:Audio</a>
    /// </summary>
    let Audio = _prefixId.prefix "Audio"
    /// <summary>
    ///   <para>rdfs:label : Audio issue number^^xsd:string</para>
    ///   <para>skos:definition : Number assigned by publishers of sound recordings to identify the issue designation, or serial identification, of the resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Revised property name and definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AudioIssueNumber">bf:AudioIssueNumber</a>
    /// </summary>
    let AudioIssueNumber = _prefixId.prefix "AudioIssueNumber"
    /// <summary>
    ///   <para>rdfs:label : Audio recording take^^xsd:string</para>
    ///   <para>skos:definition : Identifier assigned to the smallest identifiable unit of a recording session, e.g., a specific recording of an individual song^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-03 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/AudioTake">bf:AudioTake</a>
    /// </summary>
    let AudioTake = _prefixId.prefix "AudioTake"
    /// <summary>
    ///   <para>rdfs:label : Barcode^^xsd:string</para>
    ///   <para>skos:definition : Optical machine-readable representation of data relating to the item to which it is attached^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Moved to Identifier class group from Item group)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Barcode">bf:Barcode</a>
    /// </summary>
    let Barcode = _prefixId.prefix "Barcode"
    /// <summary>
    ///   <para>rdfs:label : Base material^^xsd:string</para>
    ///   <para>skos:definition : Underlying physical material of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Changed subclass to Material [GH28])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/BaseMaterial">bf:BaseMaterial</a>
    /// </summary>
    let BaseMaterial = _prefixId.prefix "BaseMaterial"
    /// <summary>
    ///   <para>rdfs:label : Binding method^^xsd:string</para>
    ///   <para>skos:definition : Information about methods used to bind a published or unpublished resource, or other binding information^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Binding">bf:Binding</a>
    /// </summary>
    let Binding = _prefixId.prefix "Binding"
    /// <summary>
    ///   <para>rdfs:label : Book format^^xsd:string</para>
    ///   <para>skos:definition : Result of folding a printed sheet to form a gathering of leaves^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/BookFormat">bf:BookFormat</a>
    /// </summary>
    let BookFormat = _prefixId.prefix "BookFormat"
    /// <summary>
    ///   <para>rdfs:label : Broadcast standard^^xsd:string</para>
    ///   <para>skos:definition : System used to format a video resource for television broadcast, e.g., HDTV, PAL^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/BroadcastStandard">bf:BroadcastStandard</a>
    /// </summary>
    let BroadcastStandard = _prefixId.prefix "BroadcastStandard"
    /// <summary>
    ///   <para>rdfs:label : Capture of content^^xsd:string</para>
    ///   <para>skos:definition : Information about place and date associated with the capture (i.e., recording, filming, etc.) of the content of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Capture">bf:Capture</a>
    /// </summary>
    let Capture = _prefixId.prefix "Capture"
    /// <summary>
    ///   <para>rdfs:label : Capture and Storage Technique^^xsd:string</para>
    ///   <para>skos:definition : Specifies the sound capture and storage technique used on a sound recording resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-11-30 (New [GH104])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/CaptureStorage">bf:CaptureStorage</a>
    /// </summary>
    let CaptureStorage = _prefixId.prefix "CaptureStorage"
    /// <summary>
    ///   <para>rdfs:label : Carrier type^^xsd:string</para>
    ///   <para>skos:definition : Categorization reflecting the format of the storage medium and housing of a carrier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Carrier">bf:Carrier</a>
    /// </summary>
    let Carrier = _prefixId.prefix "Carrier"
    /// <summary>
    ///   <para>rdfs:label : Cartographic information^^xsd:string</para>
    ///   <para>skos:definition : Content that represents the whole or part of the earth, any celestial body, or imaginary place at any scale^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Cartographic">bf:Cartographic</a>
    /// </summary>
    let Cartographic = _prefixId.prefix "Cartographic"
    /// <summary>
    ///   <para>rdfs:label : Digital cartographic data type^^xsd:string</para>
    ///   <para>skos:definition : Data type for encoding of geospatial information in a cartographic resource, e.g., raster, vector, point^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/CartographicDataType">bf:CartographicDataType</a>
    /// </summary>
    let CartographicDataType = _prefixId.prefix "CartographicDataType"
    /// <summary>
    ///   <para>rdfs:label : Digital cartographic object type^^xsd:string</para>
    ///   <para>skos:definition : Object type for encoding of geospatial information in a cartographic resource, e.g., point, line, polygon^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/CartographicObjectType">bf:CartographicObjectType</a>
    /// </summary>
    let CartographicObjectType = _prefixId.prefix "CartographicObjectType"
    /// <summary>
    ///   <para>rdfs:label : Cartography^^xsd:string</para>
    ///   <para>skos:definition : Resource that shows spatial information, including maps, atlases, globes, digital, and other cartographic resources^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-25 (fixed typo in definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Cartography">bf:Cartography</a>
    /// </summary>
    let Cartography = _prefixId.prefix "Cartography"
    /// <summary>
    ///   <para>rdfs:label : Chronology^^xsd:string</para>
    ///   <para>skos:definition : Dates associated with issues or items held^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Chronology">bf:Chronology</a>
    /// </summary>
    let Chronology = _prefixId.prefix "Chronology"
    /// <summary>
    ///   <para>rdfs:label : Classification entity^^xsd:string</para>
    ///   <para>skos:definition : System of coding and organizing materials according to their subject^^xsd:string</para>
    ///   <para>skos:editorialNote : Any entry from the Classification Schemes vocabulary at ID may be used; all have been defined as a bf:Classification^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Added editorial note [GH55])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Classification">bf:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>rdfs:label : DDC Classification^^xsd:string</para>
    ///   <para>skos:definition : Dewey Decimal Classification number used for subject access^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ClassificationDdc">bf:ClassificationDdc</a>
    /// </summary>
    let ClassificationDdc = _prefixId.prefix "ClassificationDdc"
    /// <summary>
    ///   <para>rdfs:label : LCC Classification^^xsd:string</para>
    ///   <para>skos:definition : Library of Congress Classification number used for subject access^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ClassificationLcc">bf:ClassificationLcc</a>
    /// </summary>
    let ClassificationLcc = _prefixId.prefix "ClassificationLcc"
    /// <summary>
    ///   <para>rdfs:label : NAL classification^^xsd:string</para>
    ///   <para>skos:definition : National Library of Agriculture number used for subject access^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-07-10 (New [GH119])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ClassificationNal">bf:ClassificationNal</a>
    /// </summary>
    let ClassificationNal = _prefixId.prefix "ClassificationNal"
    /// <summary>
    ///   <para>rdfs:label : NLM classification^^xsd:string</para>
    ///   <para>skos:definition : National Library of Medicine Classification number used for subject access^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ClassificationNlm">bf:ClassificationNlm</a>
    /// </summary>
    let ClassificationNlm = _prefixId.prefix "ClassificationNlm"
    /// <summary>
    ///   <para>rdfs:label : UDC Classification^^xsd:string</para>
    ///   <para>skos:definition : Universal Decimal Classification number used for subject access^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ClassificationUdc">bf:ClassificationUdc</a>
    /// </summary>
    let ClassificationUdc = _prefixId.prefix "ClassificationUdc"
    /// <summary>
    ///   <para>rdfs:label : CODEN^^xsd:string</para>
    ///   <para>skos:definition : Identifier for scientific and technical periodical titles assigned by the International CODEN Section of Chemical Abstracts Service^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Coden">bf:Coden</a>
    /// </summary>
    let Coden = _prefixId.prefix "Coden"
    /// <summary>
    ///   <para>rdfs:label : Collection^^xsd:string</para>
    ///   <para>skos:definition : Aggregation of resources, generally gathered together artificially^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (changed subClassOf [GH92])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Collection">bf:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : Organization of materials information^^xsd:string</para>
    ///   <para>skos:definition : Information about the organization and arrangement of a collection of items^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/CollectionArrangement">bf:CollectionArrangement</a>
    /// </summary>
    let CollectionArrangement = _prefixId.prefix "CollectionArrangement"
    /// <summary>
    ///   <para>rdfs:label : Collective title^^xsd:string</para>
    ///   <para>skos:definition : Title for a compilation of resources^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/CollectiveTitle">bf:CollectiveTitle</a>
    /// </summary>
    let CollectiveTitle = _prefixId.prefix "CollectiveTitle"
    /// <summary>
    ///   <para>rdfs:label : Color content^^xsd:string</para>
    ///   <para>skos:definition : Color characteristics of a resource, e.g., black and white, multicolored, etc.^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ColorContent">bf:ColorContent</a>
    /// </summary>
    let ColorContent = _prefixId.prefix "ColorContent"
    /// <summary>
    ///   <para>rdfs:label : Content type^^xsd:string</para>
    ///   <para>skos:definition : Categorization reflecting the fundamental form of communication in which the content is expressed and the human sense through which it is intended to be perceived^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Content">bf:Content</a>
    /// </summary>
    let Content = _prefixId.prefix "Content"
    /// <summary>
    ///   <para>rdfs:label : Content accessibility information^^xsd:string</para>
    ///   <para>skos:definition : Information that assists those with a sensory impairment for greater understanding of content, e.g., captions^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-07 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ContentAccessibility">bf:ContentAccessibility</a>
    /// </summary>
    let ContentAccessibility = _prefixId.prefix "ContentAccessibility"
    /// <summary>
    ///   <para>rdfs:label : Contribution^^xsd:string</para>
    ///   <para>skos:definition : Agent and role with respect to the resource being described^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Contribution">bf:Contribution</a>
    /// </summary>
    let Contribution = _prefixId.prefix "Contribution"
    /// <summary>
    ///   <para>rdfs:label : Copyright-legal deposit number^^xsd:string</para>
    ///   <para>skos:definition : Identifier assigned to a copyright registration or legal deposit^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/CopyrightNumber">bf:CopyrightNumber</a>
    /// </summary>
    let CopyrightNumber = _prefixId.prefix "CopyrightNumber"
    /// <summary>
    ///   <para>rdfs:label : Copyright registration^^xsd:string</para>
    ///   <para>skos:definition : Copyright or Legal Deposit registration information^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-05-04 (Class name corrected)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/CopyrightRegistration">bf:CopyrightRegistration</a>
    /// </summary>
    let CopyrightRegistration = _prefixId.prefix "CopyrightRegistration"
    /// <summary>
    ///   <para>rdfs:label : Cover art^^xsd:string</para>
    ///   <para>skos:definition : Cover illustration of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/CoverArt">bf:CoverArt</a>
    /// </summary>
    let CoverArt = _prefixId.prefix "CoverArt"
    /// <summary>
    ///   <para>rdfs:label : Dataset^^xsd:string</para>
    ///   <para>skos:definition : Data encoded in a defined structure, including numeric data, environmental data, etc., used by applications software^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Dataset">bf:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Metadata authentication^^xsd:string</para>
    ///   <para>skos:definition : Indication of specific types of reviews that have been carried out on the description information^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (fixed class name)^^xsd:stringdcterms:modified : 2022-10-03 (removed subClassOf [GH90])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/DescriptionAuthentication">bf:DescriptionAuthentication</a>
    /// </summary>
    let DescriptionAuthentication = _prefixId.prefix "DescriptionAuthentication"
    /// <summary>
    ///   <para>rdfs:label : Description conventions^^xsd:string</para>
    ///   <para>skos:definition : Rules used for the descriptive content of the resource description^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-24 (fixed class name)^^xsd:stringdcterms:modified : 2022-10-03 (removed subClassOf [GH90])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/DescriptionConventions">bf:DescriptionConventions</a>
    /// </summary>
    let DescriptionConventions = _prefixId.prefix "DescriptionConventions"
    /// <summary>
    ///   <para>rdfs:label : Description level^^xsd:string</para>
    ///   <para>skos:definition : Designation of the descriptive content of the metadata^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH43])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/DescriptionLevel">bf:DescriptionLevel</a>
    /// </summary>
    let DescriptionLevel = _prefixId.prefix "DescriptionLevel"
    /// <summary>
    ///   <para>rdfs:label : Digital characteristic^^xsd:string</para>
    ///   <para>skos:definition : Technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/DigitalCharacteristic">bf:DigitalCharacteristic</a>
    /// </summary>
    let DigitalCharacteristic = _prefixId.prefix "DigitalCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Dissertation information^^xsd:string</para>
    ///   <para>skos:definition : Information about a work presented as part of the formal requirements for an academic degree^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Dissertation">bf:Dissertation</a>
    /// </summary>
    let Dissertation = _prefixId.prefix "Dissertation"
    /// <summary>
    ///   <para>rdfs:label : Dissertation Identifier^^xsd:string</para>
    ///   <para>skos:definition : Identifier assigned to a thesis or dissertation for identification purposes^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/DissertationIdentifier">bf:DissertationIdentifier</a>
    /// </summary>
    let DissertationIdentifier = _prefixId.prefix "DissertationIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Distributor^^xsd:string</para>
    ///   <para>skos:definition : Information relating to distribution of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Distribution">bf:Distribution</a>
    /// </summary>
    let Distribution = _prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>rdfs:label : DOI^^xsd:string</para>
    ///   <para>skos:definition : Digital Object Identifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Doi">bf:Doi</a>
    /// </summary>
    let Doi = _prefixId.prefix "Doi"
    /// <summary>
    ///   <para>rdfs:label : Dramatic role^^xsd:string</para>
    ///   <para>skos:definition : The dramatic role performed by a contributing agent^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/DramaticRole">bf:DramaticRole</a>
    /// </summary>
    let DramaticRole = _prefixId.prefix "DramaticRole"
    /// <summary>
    ///   <para>rdfs:label : EAN^^xsd:string</para>
    ///   <para>skos:definition : International Article Identifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Ean">bf:Ean</a>
    /// </summary>
    let Ean = _prefixId.prefix "Ean"
    /// <summary>
    ///   <para>rdfs:label : EIDR^^xsd:string</para>
    ///   <para>skos:definition : Entertainment Identifier Registry^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH78])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Eidr">bf:Eidr</a>
    /// </summary>
    let Eidr = _prefixId.prefix "Eidr"
    /// <summary>
    ///   <para>rdfs:label : Electronic^^xsd:string</para>
    ///   <para>skos:definition : Resource that is intended for manipulation by a computer, accessed either directly or remotely^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Electronic">bf:Electronic</a>
    /// </summary>
    let Electronic = _prefixId.prefix "Electronic"
    /// <summary>
    ///   <para>rdfs:label : Emulsion^^xsd:string</para>
    ///   <para>skos:definition : Suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche, e.g., silver halide^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Emulsion">bf:Emulsion</a>
    /// </summary>
    let Emulsion = _prefixId.prefix "Emulsion"
    /// <summary>
    ///   <para>rdfs:label : Encoded bitrate^^xsd:string</para>
    ///   <para>skos:definition : Speed at which streaming audio, video, etc., is designed to play, e.g., 32 kbps^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/EncodedBitrate">bf:EncodedBitrate</a>
    /// </summary>
    let EncodedBitrate = _prefixId.prefix "EncodedBitrate"
    /// <summary>
    ///   <para>rdfs:label : Encoding format^^xsd:string</para>
    ///   <para>skos:definition : Schema, standard, etc., used to encode the digital content of a resource, e.g., MP3, XML, JPEG^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/EncodingFormat">bf:EncodingFormat</a>
    /// </summary>
    let EncodingFormat = _prefixId.prefix "EncodingFormat"
    /// <summary>
    ///   <para>rdfs:label : Ensemble^^xsd:string</para>
    ///   <para>skos:definition : Composition of the ensemble, including the size of the ensemble and the medium of performance components^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH56])^^xsd:stringdcterms:modified : 2025-12-01 (Revised definition [GH135])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Ensemble">bf:Ensemble</a>
    /// </summary>
    let Ensemble = _prefixId.prefix "Ensemble"
    /// <summary>
    ///   <para>rdfs:label : Ensemble size^^xsd:string</para>
    ///   <para>skos:definition : A designation of the size of the individual musical ensemble^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/EnsembleSize">bf:EnsembleSize</a>
    /// </summary>
    let EnsembleSize = _prefixId.prefix "EnsembleSize"
    /// <summary>
    ///   <para>rdfs:label : Enumeration^^xsd:string</para>
    ///   <para>skos:definition : Numbering or other enumeration associated with issues or items held^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Enumeration">bf:Enumeration</a>
    /// </summary>
    let Enumeration = _prefixId.prefix "Enumeration"
    /// <summary>
    ///   <para>rdfs:label : Enumeration and chronology^^xsd:string</para>
    ///   <para>skos:definition : Numbering or other enumeration and dates associated with issues or items held^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/EnumerationAndChronology">bf:EnumerationAndChronology</a>
    /// </summary>
    let EnumerationAndChronology = _prefixId.prefix "EnumerationAndChronology"
    /// <summary>
    ///   <para>rdfs:label : Event entity^^xsd:string</para>
    ///   <para>skos:definition : Something that happens at a certain time and location, such as a performance, speech, or athletic event^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broaden definition [GH12])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Event">bf:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Extent^^xsd:string</para>
    ///   <para>skos:definition : Number and type of units and/or subunits making up a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Extent">bf:Extent</a>
    /// </summary>
    let Extent = _prefixId.prefix "Extent"
    /// <summary>
    ///   <para>rdfs:label : Family^^xsd:string</para>
    ///   <para>skos:definition : Two or more persons related by birth, marriage, adoption, civil union, or similar legal status, or who otherwise present themselves as a family^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Family">bf:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:label : File size^^xsd:string</para>
    ///   <para>skos:definition : Number of bytes in a digital file, e.g., 162 KB^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/FileSize">bf:FileSize</a>
    /// </summary>
    let FileSize = _prefixId.prefix "FileSize"
    /// <summary>
    ///   <para>rdfs:label : File type^^xsd:string</para>
    ///   <para>skos:definition : General type of data content encoded in a computer file, e.g., text file, audio file^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/FileType">bf:FileType</a>
    /// </summary>
    let FileType = _prefixId.prefix "FileType"
    /// <summary>
    ///   <para>rdfs:label : Fingerprint identifier^^xsd:string</para>
    ///   <para>skos:definition : Identifier that is used to assist in the identification of antiquarian books by recording information comprising groups of characters taken from specified positions on specified pages of the book^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Fingerprint">bf:Fingerprint</a>
    /// </summary>
    let Fingerprint = _prefixId.prefix "Fingerprint"
    /// <summary>
    ///   <para>rdfs:label : Font size^^xsd:string</para>
    ///   <para>skos:definition : Size of the type used to represent the characters and symbols in a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/FontSize">bf:FontSize</a>
    /// </summary>
    let FontSize = _prefixId.prefix "FontSize"
    /// <summary>
    ///   <para>rdfs:label : Frequency^^xsd:string</para>
    ///   <para>skos:definition : Information about intervals at which the parts of a serially produced resource or the updates to an integrating resource are issued^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Frequency">bf:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:label : Generation^^xsd:string</para>
    ///   <para>skos:definition : Relationship between an original carrier and the carrier of a reproduction made from the original^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Generation">bf:Generation</a>
    /// </summary>
    let Generation = _prefixId.prefix "Generation"
    /// <summary>
    ///   <para>rdfs:label : Generation process^^xsd:string</para>
    ///   <para>skos:definition : Indication of the program or process used to generate the description by application of a particular transformation^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-24 (fixed class name)^^xsd:stringdcterms:modified : 2022-10-03 (removed subClassOf [GH90])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/GenerationProcess">bf:GenerationProcess</a>
    /// </summary>
    let GenerationProcess = _prefixId.prefix "GenerationProcess"
    /// <summary>
    ///   <para>rdfs:label : Genre/form^^xsd:string</para>
    ///   <para>skos:definition : Form category or genre to which a resource belongs^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broaden definition [GH17])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/GenreForm">bf:GenreForm</a>
    /// </summary>
    let GenreForm = _prefixId.prefix "GenreForm"
    /// <summary>
    ///   <para>rdfs:label : Geographic coverage^^xsd:string</para>
    ///   <para>skos:definition : Geographic coverage of the content of the resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-06 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/GeographicCoverage">bf:GeographicCoverage</a>
    /// </summary>
    let GeographicCoverage = _prefixId.prefix "GeographicCoverage"
    /// <summary>
    ///   <para>rdfs:label : Groove characteristic^^xsd:string</para>
    ///   <para>skos:definition : Groove width of an analog disc or the groove pitch of an analog cylinder, e.g., coarse groove, microgroove^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-26 (fixed typo in definition)^^xsd:stringdcterms:modified : 2017-02-03 (Fixed name of property)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/GrooveCharacteristic">bf:GrooveCharacteristic</a>
    /// </summary>
    let GrooveCharacteristic = _prefixId.prefix "GrooveCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Global Trade Item Number 14^^xsd:string</para>
    ///   <para>skos:definition : 14-digit number assigned to identify trade items as various packaging levels that encompasses EAN/UCC-128 and ITF-14^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-03 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Gtin14Number">bf:Gtin14Number</a>
    /// </summary>
    let Gtin14Number = _prefixId.prefix "Gtin14Number"
    /// <summary>
    ///   <para>rdfs:label : Handle^^xsd:string</para>
    ///   <para>skos:definition : Unique and persistent identifier for digital objects developed by the Corporation for National Research Initiatives^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Hdl">bf:Hdl</a>
    /// </summary>
    let Hdl = _prefixId.prefix "Hdl"
    /// <summary>
    ///   <para>rdfs:label : Hub^^xsd:string</para>
    ///   <para>skos:definition : An abstract resource that functions as a bridge between two Works^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH75])^^xsd:stringdcterms:modified : 2023-11-30 (moved to Basic Model Class [GH108])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Hub">bf:Hub</a>
    /// </summary>
    let Hub = _prefixId.prefix "Hub"
    /// <summary>
    ///   <para>rdfs:label : Identifier^^xsd:string</para>
    ///   <para>skos:definition : Token or name that is associated with a resource, such as a URI or an ISBN^^xsd:string</para>
    ///   <para>skos:editorialNote : Any entry from the Standard Identifiers vocabulary at ID may be used; all have been defined as a bf:Identifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Added editorial note [GH44])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Identifier">bf:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>rdfs:label : Illustrative content^^xsd:string</para>
    ///   <para>skos:definition : Information about content intended to illustrate a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Illustration">bf:Illustration</a>
    /// </summary>
    let Illustration = _prefixId.prefix "Illustration"
    /// <summary>
    ///   <para>rdfs:label : Immediate acquisition^^xsd:string</para>
    ///   <para>skos:definition : Information about the circumstances, e.g., source, date, method, under which the resource was directly acquired^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-06 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ImmediateAcquisition">bf:ImmediateAcquisition</a>
    /// </summary>
    let ImmediateAcquisition = _prefixId.prefix "ImmediateAcquisition"
    /// <summary>
    ///   <para>rdfs:label : Instance^^xsd:string</para>
    ///   <para>skos:definition : Resource reflecting an individual, material embodiment of a Work^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Instance">bf:Instance</a>
    /// </summary>
    let Instance = _prefixId.prefix "Instance"
    /// <summary>
    ///   <para>rdfs:label : Integrating resource^^xsd:string</para>
    ///   <para>skos:definition : Resource that is added to or changed by updates that do not remain discrete but are integrated into the whole^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Integrating">bf:Integrating</a>
    /// </summary>
    let Integrating = _prefixId.prefix "Integrating"
    /// <summary>
    ///   <para>rdfs:label : Intended audience information^^xsd:string</para>
    ///   <para>skos:definition : Information that identifies the specific intended or target audience or intellectual level for which the content described is considered appropriate; also used to record interest and motivation levels and special learner characteristics^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/IntendedAudience">bf:IntendedAudience</a>
    /// </summary>
    let IntendedAudience = _prefixId.prefix "IntendedAudience"
    /// <summary>
    ///   <para>rdfs:label : ISAN^^xsd:string</para>
    ///   <para>skos:definition : International Standard Audiovisual Number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Isan">bf:Isan</a>
    /// </summary>
    let Isan = _prefixId.prefix "Isan"
    /// <summary>
    ///   <para>rdfs:label : ISBN^^xsd:string</para>
    ///   <para>skos:definition : International Standard Book Number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Isbn">bf:Isbn</a>
    /// </summary>
    let Isbn = _prefixId.prefix "Isbn"
    /// <summary>
    ///   <para>rdfs:label : ISMN^^xsd:string</para>
    ///   <para>skos:definition : International Standard Music Number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Ismn">bf:Ismn</a>
    /// </summary>
    let Ismn = _prefixId.prefix "Ismn"
    /// <summary>
    ///   <para>rdfs:label : ISNI^^xsd:string</para>
    ///   <para>skos:definition : International Standard Name Identifier, a unique, persistent reference number for the identities of contributors to creative works^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-03 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Isni">bf:Isni</a>
    /// </summary>
    let Isni = _prefixId.prefix "Isni"
    /// <summary>
    ///   <para>rdfs:label : ISO number^^xsd:string</para>
    ///   <para>skos:definition : International Organization for Standardization standard number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Iso">bf:Iso</a>
    /// </summary>
    let Iso = _prefixId.prefix "Iso"
    /// <summary>
    ///   <para>rdfs:label : ISRC^^xsd:string</para>
    ///   <para>skos:definition : International Standard Recording Code^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Isrc">bf:Isrc</a>
    /// </summary>
    let Isrc = _prefixId.prefix "Isrc"
    /// <summary>
    ///   <para>rdfs:label : ISSN^^xsd:string</para>
    ///   <para>skos:definition : International Standard Serial Number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Issn">bf:Issn</a>
    /// </summary>
    let Issn = _prefixId.prefix "Issn"
    /// <summary>
    ///   <para>rdfs:label : ISSN-L^^xsd:string</para>
    ///   <para>skos:definition : International Standard Serial Number that links together various media versions of a continuing resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/IssnL">bf:IssnL</a>
    /// </summary>
    let IssnL = _prefixId.prefix "IssnL"
    /// <summary>
    ///   <para>rdfs:label : Mode of issuance^^xsd:string</para>
    ///   <para>skos:definition : Information about whether a resource is issued in one or more parts, the way it is updated, and its intended termination^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Issuance">bf:Issuance</a>
    /// </summary>
    let Issuance = _prefixId.prefix "Issuance"
    /// <summary>
    ///   <para>rdfs:label : ISTC^^xsd:string</para>
    ///   <para>skos:definition : International Standard Text Code, a numbering system developed to enable the unique identification of textual works^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Istc">bf:Istc</a>
    /// </summary>
    let Istc = _prefixId.prefix "Istc"
    /// <summary>
    ///   <para>rdfs:label : ISWC^^xsd:string</para>
    ///   <para>skos:definition : International Standard Musical Work Code, a unique, persistent reference number for the identification of musical works^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Iswc">bf:Iswc</a>
    /// </summary>
    let Iswc = _prefixId.prefix "Iswc"
    /// <summary>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <para>skos:definition : Single example of an Instance^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Item">bf:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Jurisdiction^^xsd:string</para>
    ///   <para>skos:definition : Legal or political unit administering a geographic area^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Jurisdiction">bf:Jurisdiction</a>
    /// </summary>
    let Jurisdiction = _prefixId.prefix "Jurisdiction"
    /// <summary>
    ///   <para>rdfs:label : Key and mode^^xsd:string</para>
    ///   <para>skos:definition : Key and mode, or key only if no mode is present, of a music work^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/KeyMode">bf:KeyMode</a>
    /// </summary>
    let KeyMode = _prefixId.prefix "KeyMode"
    /// <summary>
    ///   <para>rdfs:label : Key title^^xsd:string</para>
    ///   <para>skos:definition : Unique title for a continuing resource that is assigned by the ISSN International Center in conjunction with an ISSN^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/KeyTitle">bf:KeyTitle</a>
    /// </summary>
    let KeyTitle = _prefixId.prefix "KeyTitle"
    /// <summary>
    ///   <para>rdfs:label : Kit^^xsd:string</para>
    ///   <para>skos:definition : Resource that contains a mixture of various components issued as a unit and intended primarily for instructional purposes^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Kit">bf:Kit</a>
    /// </summary>
    let Kit = _prefixId.prefix "Kit"
    /// <summary>
    ///   <para>rdfs:label : Language entity^^xsd:string</para>
    ///   <para>skos:definition : Language entity^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Language">bf:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:label : Layout^^xsd:string</para>
    ///   <para>skos:definition : Arrangement of text, images, tactile notation, etc., in a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Layout">bf:Layout</a>
    /// </summary>
    let Layout = _prefixId.prefix "Layout"
    /// <summary>
    ///   <para>rdfs:label : LC acquisition program^^xsd:string</para>
    ///   <para>skos:definition : Identification number assigned by the Library of Congress to works acquired through one of its collaborative overseas acquisition programs^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/LcOverseasAcq">bf:LcOverseasAcq</a>
    /// </summary>
    let LcOverseasAcq = _prefixId.prefix "LcOverseasAcq"
    /// <summary>
    ///   <para>rdfs:label : LCCN^^xsd:string</para>
    ///   <para>skos:definition : Library of Congress Control Number that identifies a resource description^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Lccn">bf:Lccn</a>
    /// </summary>
    let Lccn = _prefixId.prefix "Lccn"
    /// <summary>
    ///   <para>rdfs:label : Local identifier^^xsd:string</para>
    ///   <para>skos:definition : Identifier established locally and not a standard number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Local">bf:Local</a>
    /// </summary>
    let Local = _prefixId.prefix "Local"
    /// <summary>
    ///   <para>rdfs:label : Manufacturer^^xsd:string</para>
    ///   <para>skos:definition : Information relating to manufacture of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Manufacture">bf:Manufacture</a>
    /// </summary>
    let Manufacture = _prefixId.prefix "Manufacture"
    /// <summary>
    ///   <para>rdfs:label : Manuscript^^xsd:string</para>
    ///   <para>skos:definition : Resource which is written in handwriting or typescript^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (changed subClassOf [GH92])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Manuscript">bf:Manuscript</a>
    /// </summary>
    let Manuscript = _prefixId.prefix "Manuscript"
    /// <summary>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <para>skos:definition : Substance or composition of the resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH28])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Material">bf:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:label : Audio matrix number^^xsd:string</para>
    ///   <para>skos:definition : Matrix identifier assigned to the master from which a specific sound recording was pressed^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Revised definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MatrixNumber">bf:MatrixNumber</a>
    /// </summary>
    let MatrixNumber = _prefixId.prefix "MatrixNumber"
    /// <summary>
    ///   <para>rdfs:label : Media type^^xsd:string</para>
    ///   <para>skos:definition : Categorization reflecting the general type of intermediation device required to view, play, run, etc., the content of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Media">bf:Media</a>
    /// </summary>
    let Media = _prefixId.prefix "Media"
    /// <summary>
    ///   <para>rdfs:label : Medium component^^xsd:string</para>
    ///   <para>skos:definition : An individual component of a medium of performance, gathering together the medium of performance, medium count, number of hands, and component qualifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MediumComponent">bf:MediumComponent</a>
    /// </summary>
    let MediumComponent = _prefixId.prefix "MediumComponent"
    let MediumComponentQualifer = _prefixId.prefix "MediumComponentQualifer"
    /// <summary>
    ///   <para>rdfs:label : Medium component qualifier^^xsd:string</para>
    ///   <para>skos:definition : Relates a medium component to a qualifier (solo, optional, etc.) that affects the medium component^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MediumComponentQualifier">bf:MediumComponentQualifier</a>
    /// </summary>
    let MediumComponentQualifier = _prefixId.prefix "MediumComponentQualifier"
    /// <summary>
    ///   <para>rdfs:label : Medium of performance^^xsd:string</para>
    ///   <para>skos:definition : An individual instrument, voice, ensemble, or instrumental group^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MediumOfPerformance">bf:MediumOfPerformance</a>
    /// </summary>
    let MediumOfPerformance = _prefixId.prefix "MediumOfPerformance"
    /// <summary>
    ///   <para>rdfs:label : Meeting^^xsd:string</para>
    ///   <para>skos:definition : Gathering of individuals or representatives of various bodies for the purpose of discussing and/or acting on topics of common interest^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Meeting">bf:Meeting</a>
    /// </summary>
    let Meeting = _prefixId.prefix "Meeting"
    /// <summary>
    ///   <para>rdfs:label : Microform^^xsd:string</para>
    ///   <para>skos:definition : Resource that contains microimages, either transparent or opaque, that may be reproductions of existing textual or graphic materials or may be original publications^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-11-30 (New [GH101])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Microform">bf:Microform</a>
    /// </summary>
    let Microform = _prefixId.prefix "Microform"
    /// <summary>
    ///   <para>rdfs:label : Mixed material^^xsd:string</para>
    ///   <para>skos:definition : Resource comprised of multiple types which is not driven by software, e.g. an archival collection of text, photographs and sound recordings^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (revised definition [GH92])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MixedMaterial">bf:MixedMaterial</a>
    /// </summary>
    let MixedMaterial = _prefixId.prefix "MixedMaterial"
    /// <summary>
    ///   <para>rdfs:label : Mode^^xsd:string</para>
    ///   <para>skos:definition : Mode (not associated with a key) of a musical work^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Mode">bf:Mode</a>
    /// </summary>
    let Mode = _prefixId.prefix "Mode"
    /// <summary>
    ///   <para>rdfs:label : Modification^^xsd:string</para>
    ///   <para>skos:definition : Information relating to modification of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH69])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Modification">bf:Modification</a>
    /// </summary>
    let Modification = _prefixId.prefix "Modification"
    /// <summary>
    ///   <para>rdfs:label : Monograph^^xsd:string</para>
    ///   <para>skos:definition : Resource that is issued as a single physical unit or intangible single logical unit^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Monograph">bf:Monograph</a>
    /// </summary>
    let Monograph = _prefixId.prefix "Monograph"
    /// <summary>
    ///   <para>rdfs:label : Mount^^xsd:string</para>
    ///   <para>skos:definition : Physical material or object used for the support or backing to which the base material of a resource has been attached^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Amended definition [GH29])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Mount">bf:Mount</a>
    /// </summary>
    let Mount = _prefixId.prefix "Mount"
    /// <summary>
    ///   <para>rdfs:label : Movement notation^^xsd:string</para>
    ///   <para>skos:definition : Information on the symbol system used to convey the content of a movement resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Modified label [GH67])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MovementNotation">bf:MovementNotation</a>
    /// </summary>
    let MovementNotation = _prefixId.prefix "MovementNotation"
    /// <summary>
    ///   <para>rdfs:label : Moving image^^xsd:string</para>
    ///   <para>skos:definition : Images intended to be perceived as moving, including motion pictures (using live action and/or animation) or video recordings of performances or events^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-26 (fixed typo in definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MovingImage">bf:MovingImage</a>
    /// </summary>
    let MovingImage = _prefixId.prefix "MovingImage"
    /// <summary>
    ///   <para>rdfs:label : Software or multimedia^^xsd:string</para>
    ///   <para>skos:definition : Electronic resource which is a computer program or consists of multiple media types that are software driven, such as videogames^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (revised definition [GH92])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Multimedia">bf:Multimedia</a>
    /// </summary>
    let Multimedia = _prefixId.prefix "Multimedia"
    /// <summary>
    ///   <para>rdfs:label : Music audio^^xsd:string</para>
    ///   <para>skos:definition : Music resource expressed in an audible form^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicAudio">bf:MusicAudio</a>
    /// </summary>
    let MusicAudio = _prefixId.prefix "MusicAudio"
    /// <summary>
    ///   <para>rdfs:label : Music distributor number^^xsd:string</para>
    ///   <para>skos:definition : Identifier appearing on a resource assigned by a distributor to a specific audio recording, notated music publication, music-related publication, or videorecording^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-07 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicDistributorNumber">bf:MusicDistributorNumber</a>
    /// </summary>
    let MusicDistributorNumber = _prefixId.prefix "MusicDistributorNumber"
    /// <summary>
    ///   <para>rdfs:label : Music ensemble^^xsd:string</para>
    ///   <para>skos:definition : Ensemble for which a musical work is appropriate^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Changed subclass to Ensemble [GH56])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicEnsemble">bf:MusicEnsemble</a>
    /// </summary>
    let MusicEnsemble = _prefixId.prefix "MusicEnsemble"
    /// <summary>
    ///   <para>rdfs:label : Notated music format^^xsd:string</para>
    ///   <para>skos:definition : Layout for content of a resource that is presented in the form of musical notation^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicFormat">bf:MusicFormat</a>
    /// </summary>
    let MusicFormat = _prefixId.prefix "MusicFormat"
    /// <summary>
    ///   <para>rdfs:label : Musical instrument^^xsd:string</para>
    ///   <para>skos:definition : Instrument for which a musical work is appropriate^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicInstrument">bf:MusicInstrument</a>
    /// </summary>
    let MusicInstrument = _prefixId.prefix "MusicInstrument"
    /// <summary>
    ///   <para>rdfs:label : Music medium information^^xsd:string</para>
    ///   <para>skos:definition : Summary statement of the medium for a musical work^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicMedium">bf:MusicMedium</a>
    /// </summary>
    let MusicMedium = _prefixId.prefix "MusicMedium"
    /// <summary>
    ///   <para>rdfs:label : Music notation^^xsd:string</para>
    ///   <para>skos:definition : Information on the symbol system used to convey the content of a music resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Modified label [GH67])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicNotation">bf:MusicNotation</a>
    /// </summary>
    let MusicNotation = _prefixId.prefix "MusicNotation"
    /// <summary>
    ///   <para>rdfs:label : Music plate number^^xsd:string</para>
    ///   <para>skos:definition : Identifiers assigned by a music publisher or printer to the printing plates for the notated portion of a notated music publication, or an identifier that emulates the printing plate tradition in contemporary publications^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Revised definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicPlate">bf:MusicPlate</a>
    /// </summary>
    let MusicPlate = _prefixId.prefix "MusicPlate"
    /// <summary>
    ///   <para>rdfs:label : Music publisher number^^xsd:string</para>
    ///   <para>skos:definition : Identifier assigned to a notated music publication other than an issue, matrix, or plate number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Revised definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicPublisherNumber">bf:MusicPublisherNumber</a>
    /// </summary>
    let MusicPublisherNumber = _prefixId.prefix "MusicPublisherNumber"
    /// <summary>
    ///   <para>rdfs:label : Music voice^^xsd:string</para>
    ///   <para>skos:definition : Voice for which a musical work is appropriate^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/MusicVoice">bf:MusicVoice</a>
    /// </summary>
    let MusicVoice = _prefixId.prefix "MusicVoice"
    /// <summary>
    ///   <para>rdfs:label : NBN^^xsd:string</para>
    ///   <para>skos:definition : National Bibliography Number that identifies a resource description^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Nbn">bf:Nbn</a>
    /// </summary>
    let Nbn = _prefixId.prefix "Nbn"
    /// <summary>
    ///   <para>rdfs:label : Non-music audio^^xsd:string</para>
    ///   <para>skos:definition : Resource expressed in an audible form, including spoken word and other non-musical sounds^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/NonMusicAudio">bf:NonMusicAudio</a>
    /// </summary>
    let NonMusicAudio = _prefixId.prefix "NonMusicAudio"
    /// <summary>
    ///   <para>rdfs:label : Notated movement^^xsd:string</para>
    ///   <para>skos:definition : Graphic, non-realized representations of movement intended to be perceived visually, e.g. dance^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/NotatedMovement">bf:NotatedMovement</a>
    /// </summary>
    let NotatedMovement = _prefixId.prefix "NotatedMovement"
    /// <summary>
    ///   <para>rdfs:label : Notated music^^xsd:string</para>
    ///   <para>skos:definition : Graphic, non-realized representations of musical works intended to be perceived visually^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/NotatedMusic">bf:NotatedMusic</a>
    /// </summary>
    let NotatedMusic = _prefixId.prefix "NotatedMusic"
    /// <summary>
    ///   <para>rdfs:label : Notation^^xsd:string</para>
    ///   <para>skos:definition : Information on the alphabet, script, or symbol system used to convey the content of the resource, including specialized scripts, typefaces, tactile notation, movement notation, and musical notation^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Notation">bf:Notation</a>
    /// </summary>
    let Notation = _prefixId.prefix "Notation"
    /// <summary>
    ///   <para>rdfs:label : Note^^xsd:string</para>
    ///   <para>skos:definition : Information, usually in textual form, on attributes of a resource or some aspect of a resource^^xsd:string</para>
    ///   <para>skos:editorialNote : Any entry from the Note Types vocabulary at ID may be used; all have been defined as a bf:Note^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Added editorial note [GH35])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Note">bf:Note</a>
    /// </summary>
    let Note = _prefixId.prefix "Note"
    /// <summary>
    ///   <para>rdfs:label : Three-dimensional object^^xsd:string</para>
    ///   <para>skos:definition : Resource in a form intended to be perceived visually in three-dimensions, including man-made objects such as models, sculptures, clothing, and toys, as well as naturally occurring objects such as specimens mounted for viewing^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Object">bf:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : Digital cartographic object count^^xsd:string</para>
    ///   <para>skos:definition : Number of objects in encoded geospatial information in a cartographic resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ObjectCount">bf:ObjectCount</a>
    /// </summary>
    let ObjectCount = _prefixId.prefix "ObjectCount"
    /// <summary>
    ///   <para>rdfs:label : OCLC number^^xsd:string</para>
    ///   <para>skos:definition : Identifier assigned by OCLC^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-07-10 (New [GH120])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/OclcNumber">bf:OclcNumber</a>
    /// </summary>
    let OclcNumber = _prefixId.prefix "OclcNumber"
    /// <summary>
    ///   <para>rdfs:label : Opus number^^xsd:string</para>
    ///   <para>skos:definition : An opus number assigned to a musical work^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/OpusNumber">bf:OpusNumber</a>
    /// </summary>
    let OpusNumber = _prefixId.prefix "OpusNumber"
    /// <summary>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <para>skos:definition : Corporation or group of persons and/or organizations that acts, or may act, as a unit^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Organization">bf:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Parallel title proper^^xsd:string</para>
    ///   <para>skos:definition : Title in another language and/or script^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ParallelTitle">bf:ParallelTitle</a>
    /// </summary>
    let ParallelTitle = _prefixId.prefix "ParallelTitle"
    /// <summary>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <para>skos:definition : Individual or identity established by an individual (either alone or in collaboration with one or more other individuals)^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Person">bf:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <para>skos:definition : Geographic location^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Place">bf:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : Configuration of playback channels^^xsd:string</para>
    ///   <para>skos:definition : Configuration/number of sound channels used to make a recording, such as one channel for a monophonic recording, e.g., mono, stereo, quadraphonic, surround^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/PlaybackChannels">bf:PlaybackChannels</a>
    /// </summary>
    let PlaybackChannels = _prefixId.prefix "PlaybackChannels"
    /// <summary>
    ///   <para>rdfs:label : Special playback characteristics^^xsd:string</para>
    ///   <para>skos:definition : Equalization system, noise reduction system, etc., used in making an audio recording, e.g., CCIR standard, CX encoded, Dolby^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/PlaybackCharacteristic">bf:PlaybackCharacteristic</a>
    /// </summary>
    let PlaybackCharacteristic = _prefixId.prefix "PlaybackCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Playing speed^^xsd:string</para>
    ///   <para>skos:definition : Speed at which an audio carrier must be operated to produce the sound intended, e.g., 78 rpm, 19 cm/s^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/PlayingSpeed">bf:PlayingSpeed</a>
    /// </summary>
    let PlayingSpeed = _prefixId.prefix "PlayingSpeed"
    /// <summary>
    ///   <para>rdfs:label : Polarity^^xsd:string</para>
    ///   <para>skos:definition : Relationship of the colors and tones in an image to the colors and tones of the object reproduced^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Polarity">bf:Polarity</a>
    /// </summary>
    let Polarity = _prefixId.prefix "Polarity"
    /// <summary>
    ///   <para>rdfs:label : Postal registration number^^xsd:string</para>
    ///   <para>skos:definition : Number assigned to a publication for which the specified postal service permits the use of a special mailing class privilege^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/PostalRegistration">bf:PostalRegistration</a>
    /// </summary>
    let PostalRegistration = _prefixId.prefix "PostalRegistration"
    /// <summary>
    ///   <para>rdfs:label : Presentation format^^xsd:string</para>
    ///   <para>skos:definition : Format used in the production of a projected image, e.g., Cinerama, IMAX^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/PresentationFormat">bf:PresentationFormat</a>
    /// </summary>
    let PresentationFormat = _prefixId.prefix "PresentationFormat"
    /// <summary>
    ///   <para>rdfs:label : Primary contribution^^xsd:string</para>
    ///   <para>skos:definition : Contribution for which the agent is the name chosen as the name part of the name and title access point^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-11-30 (New [GH104])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/PrimaryContribution">bf:PrimaryContribution</a>
    /// </summary>
    let PrimaryContribution = _prefixId.prefix "PrimaryContribution"
    /// <summary>
    ///   <para>rdfs:label : Printed^^xsd:string</para>
    ///   <para>skos:definition : Resource that is printed^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Print">bf:Print</a>
    /// </summary>
    let Print = _prefixId.prefix "Print"
    /// <summary>
    ///   <para>rdfs:label : Producer^^xsd:string</para>
    ///   <para>skos:definition : Information relating to production of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Production">bf:Production</a>
    /// </summary>
    let Production = _prefixId.prefix "Production"
    /// <summary>
    ///   <para>rdfs:label : Production method^^xsd:string</para>
    ///   <para>skos:definition : Process used to produce a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ProductionMethod">bf:ProductionMethod</a>
    /// </summary>
    let ProductionMethod = _prefixId.prefix "ProductionMethod"
    /// <summary>
    ///   <para>rdfs:label : Projection^^xsd:string</para>
    ///   <para>skos:definition : Method or system used to represent the surface of the earth or of a celestial sphere on a plane^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-03 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Projection">bf:Projection</a>
    /// </summary>
    let Projection = _prefixId.prefix "Projection"
    /// <summary>
    ///   <para>rdfs:label : Projection characteristic^^xsd:string</para>
    ///   <para>skos:definition : Technical specification relating to the projection of a motion picture film^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ProjectionCharacteristic">bf:ProjectionCharacteristic</a>
    /// </summary>
    let ProjectionCharacteristic = _prefixId.prefix "ProjectionCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Projection speed^^xsd:string</para>
    ///   <para>skos:definition : Speed at which a projected carrier must be operated to produce the moving image intended, e.g., 20 fps^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ProjectionSpeed">bf:ProjectionSpeed</a>
    /// </summary>
    let ProjectionSpeed = _prefixId.prefix "ProjectionSpeed"
    /// <summary>
    ///   <para>rdfs:label : Provider entity^^xsd:string</para>
    ///   <para>skos:definition : Information about the agent or place relating to the publication, printing, distribution, issue, release, or production of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ProvisionActivity">bf:ProvisionActivity</a>
    /// </summary>
    let ProvisionActivity = _prefixId.prefix "ProvisionActivity"
    /// <summary>
    ///   <para>rdfs:label : Publication Frequency^^xsd:string</para>
    ///   <para>skos:definition : Information about the publication frequency of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH76])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/PubFrequency">bf:PubFrequency</a>
    /// </summary>
    let PubFrequency = _prefixId.prefix "PubFrequency"
    /// <summary>
    ///   <para>rdfs:label : Publisher^^xsd:string</para>
    ///   <para>skos:definition : Information relating to publication of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Publication">bf:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Publisher number^^xsd:string</para>
    ///   <para>skos:definition : Number assigned by a publisher that is not one of the specific defined types^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/PublisherNumber">bf:PublisherNumber</a>
    /// </summary>
    let PublisherNumber = _prefixId.prefix "PublisherNumber"
    /// <summary>
    ///   <para>rdfs:label : Recording medium^^xsd:string</para>
    ///   <para>skos:definition : Type of medium used to record sound on an audio carrier, e.g., magnetic, optical^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/RecordingMedium">bf:RecordingMedium</a>
    /// </summary>
    let RecordingMedium = _prefixId.prefix "RecordingMedium"
    /// <summary>
    ///   <para>rdfs:label : Type of recording^^xsd:string</para>
    ///   <para>skos:definition : Method used to encode audio content for playback, e.g., analog, digital^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/RecordingMethod">bf:RecordingMethod</a>
    /// </summary>
    let RecordingMethod = _prefixId.prefix "RecordingMethod"
    /// <summary>
    ///   <para>rdfs:label : Reduction ratio^^xsd:string</para>
    ///   <para>skos:definition : Size of a micro-image in relation to the original from which it was produced^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ReductionRatio">bf:ReductionRatio</a>
    /// </summary>
    let ReductionRatio = _prefixId.prefix "ReductionRatio"
    /// <summary>
    ///   <para>rdfs:label : Regional encoding^^xsd:string</para>
    ///   <para>skos:definition : Identification of the region of the world for which a videodisc has been encoded, e.g., region 4^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/RegionalEncoding">bf:RegionalEncoding</a>
    /// </summary>
    let RegionalEncoding = _prefixId.prefix "RegionalEncoding"
    /// <summary>
    ///   <para>rdfs:label : Relation^^xsd:string</para>
    ///   <para>skos:definition : Associated resource and its relationship to the resource being described^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-07-10 (New [GH116])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Relation">bf:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:label : Relationship^^xsd:string</para>
    ///   <para>skos:definition : Type of relationship between resources^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-07-10 (New [GH116])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Relationship">bf:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>rdfs:label : Relief^^xsd:string</para>
    ///   <para>skos:definition : Relief term specified on a cartographic resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-11-30 (New [GH104])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Relief">bf:Relief</a>
    /// </summary>
    let Relief = _prefixId.prefix "Relief"
    /// <summary>
    ///   <para>rdfs:label : Technical report number^^xsd:string</para>
    ///   <para>skos:definition : Identification number of a technical report that is not a Standard Technical Report Number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ReportNumber">bf:ReportNumber</a>
    /// </summary>
    let ReportNumber = _prefixId.prefix "ReportNumber"
    /// <summary>
    ///   <para>rdfs:label : Resolution^^xsd:string</para>
    ///   <para>skos:definition : Clarity or fineness of detail in a digital image, expressed by the measurement of the image in pixels, etc., e.g., 3.1 megapixels^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Resolution">bf:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>rdfs:label : Retention policy^^xsd:string</para>
    ///   <para>skos:definition : Policy of holding institution for retaining resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/RetentionPolicy">bf:RetentionPolicy</a>
    /// </summary>
    let RetentionPolicy = _prefixId.prefix "RetentionPolicy"
    /// <summary>
    ///   <para>rdfs:label : Review^^xsd:string</para>
    ///   <para>skos:definition : Review of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Review">bf:Review</a>
    /// </summary>
    let Review = _prefixId.prefix "Review"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>skos:definition : Function played or provided by a contributor, e.g., author or illustrator^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-03 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Role">bf:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Scale^^xsd:string</para>
    ///   <para>skos:definition : Ratio of the dimensions of a form contained or embodied in a resource to the dimensions of the entity it represents, e.g., for images or cartographic resources^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-03 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Scale">bf:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>rdfs:label : Script^^xsd:string</para>
    ///   <para>skos:definition : Information on the script, or symbol system used to convey the content of a text resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Modified label [GH67])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Script">bf:Script</a>
    /// </summary>
    let Script = _prefixId.prefix "Script"
    /// <summary>
    ///   <para>rdfs:label : Serial^^xsd:string</para>
    ///   <para>skos:definition : Resource that is issued in successive parts, usually numbered, that has no predetermined conclusion^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Serial">bf:Serial</a>
    /// </summary>
    let Serial = _prefixId.prefix "Serial"
    /// <summary>
    ///   <para>rdfs:label : Serial number^^xsd:string</para>
    ///   <para>skos:definition : A serial number assigned to a work^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/SerialNumber">bf:SerialNumber</a>
    /// </summary>
    let SerialNumber = _prefixId.prefix "SerialNumber"
    /// <summary>
    ///   <para>rdfs:label : Series^^xsd:string</para>
    ///   <para>skos:definition : Resource with a collective title that applies to a group of separate resources, each of which also has its own title^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Series">bf:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>rdfs:label : Shelf location^^xsd:string</para>
    ///   <para>skos:definition : Piece/item identifier, such as a call or other type of number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ShelfMark">bf:ShelfMark</a>
    /// </summary>
    let ShelfMark = _prefixId.prefix "ShelfMark"
    /// <summary>
    ///   <para>rdfs:label : DDC call number^^xsd:string</para>
    ///   <para>skos:definition : Shelf mark based on Dewey Decimal Classification^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ShelfMarkDdc">bf:ShelfMarkDdc</a>
    /// </summary>
    let ShelfMarkDdc = _prefixId.prefix "ShelfMarkDdc"
    /// <summary>
    ///   <para>rdfs:label : LCC call number^^xsd:string</para>
    ///   <para>skos:definition : Shelf mark based on Library of Congress Classification^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ShelfMarkLcc">bf:ShelfMarkLcc</a>
    /// </summary>
    let ShelfMarkLcc = _prefixId.prefix "ShelfMarkLcc"
    /// <summary>
    ///   <para>rdfs:label : NLM call number^^xsd:string</para>
    ///   <para>skos:definition : Shelf mark based on National Library of Medicine Classification^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ShelfMarkNlm">bf:ShelfMarkNlm</a>
    /// </summary>
    let ShelfMarkNlm = _prefixId.prefix "ShelfMarkNlm"
    /// <summary>
    ///   <para>rdfs:label : UDC call number^^xsd:string</para>
    ///   <para>skos:definition : Shelf mark based on Universal Decimal Classification^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ShelfMarkUdc">bf:ShelfMarkUdc</a>
    /// </summary>
    let ShelfMarkUdc = _prefixId.prefix "ShelfMarkUdc"
    /// <summary>
    ///   <para>rdfs:label : SICI^^xsd:string</para>
    ///   <para>skos:definition : Serial Item and Contribution Identifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Sici">bf:Sici</a>
    /// </summary>
    let Sici = _prefixId.prefix "Sici"
    /// <summary>
    ///   <para>rdfs:label : Sound characteristic^^xsd:string</para>
    ///   <para>skos:definition : Technical specification relating to the encoding of sound in a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/SoundCharacteristic">bf:SoundCharacteristic</a>
    /// </summary>
    let SoundCharacteristic = _prefixId.prefix "SoundCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Sound content^^xsd:string</para>
    ///   <para>skos:definition : Indication of whether the production of sound is an integral part of the resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/SoundContent">bf:SoundContent</a>
    /// </summary>
    let SoundContent = _prefixId.prefix "SoundContent"
    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <para>skos:definition : Resource from which value or label came or was derived^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Source">bf:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <para>skos:definition : Designation of the validity or position of something, e.g., whether something is incorrect or available^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Status">bf:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : Still image^^xsd:string</para>
    ///   <para>skos:definition : Resource expressed through line, shape, shading, etc., intended to be perceived visually as a still image or images in two dimensions, including two-dimensional images and slides and transparencies^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/StillImage">bf:StillImage</a>
    /// </summary>
    let StillImage = _prefixId.prefix "StillImage"
    /// <summary>
    ///   <para>rdfs:label : Stock number^^xsd:string</para>
    ///   <para>skos:definition : Identification number used for stock purposes and assigned by agencies such as distributors, publishers, or vendors^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/StockNumber">bf:StockNumber</a>
    /// </summary>
    let StockNumber = _prefixId.prefix "StockNumber"
    /// <summary>
    ///   <para>rdfs:label : STRN^^xsd:string</para>
    ///   <para>skos:definition : Standard Technical Report Number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Strn">bf:Strn</a>
    /// </summary>
    let Strn = _prefixId.prefix "Strn"
    /// <summary>
    ///   <para>rdfs:label : Study number^^xsd:string</para>
    ///   <para>skos:definition : Identification number for a computer data file^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/StudyNumber">bf:StudyNumber</a>
    /// </summary>
    let StudyNumber = _prefixId.prefix "StudyNumber"
    /// <summary>
    ///   <para>rdfs:label : Sublocation^^xsd:string</para>
    ///   <para>skos:definition : Specific place within the holding entity where the item is located or made available^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Sublocation">bf:Sublocation</a>
    /// </summary>
    let Sublocation = _prefixId.prefix "Sublocation"
    /// <summary>
    ///   <para>rdfs:label : Summary^^xsd:string</para>
    ///   <para>skos:definition : Description of the content of a resource, such as an abstract, summary, etc.^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Summary">bf:Summary</a>
    /// </summary>
    let Summary = _prefixId.prefix "Summary"
    /// <summary>
    ///   <para>rdfs:label : Supplementary material^^xsd:string</para>
    ///   <para>skos:definition : Index, bibliography, appendix, etc. intended to supplement the primary content of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/SupplementaryContent">bf:SupplementaryContent</a>
    /// </summary>
    let SupplementaryContent = _prefixId.prefix "SupplementaryContent"
    /// <summary>
    ///   <para>rdfs:label : System Requirement^^xsd:string</para>
    ///   <para>skos:definition : Equipment or system requirements beyond what is normal and obvious for the type of carrier or type of file, such as make and model of equipment or hardware, operating system, amount of memory, programming language, other necessary software, any plug-ins or peripherals required to play, view, or run the resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-06 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/SystemRequirement">bf:SystemRequirement</a>
    /// </summary>
    let SystemRequirement = _prefixId.prefix "SystemRequirement"
    /// <summary>
    ///   <para>rdfs:label : Table of contents^^xsd:string</para>
    ///   <para>skos:definition : Table of contents of a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/TableOfContents">bf:TableOfContents</a>
    /// </summary>
    let TableOfContents = _prefixId.prefix "TableOfContents"
    /// <summary>
    ///   <para>rdfs:label : Tactile material^^xsd:string</para>
    ///   <para>skos:definition : Resource that is intended to be perceived by touch^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Tactile">bf:Tactile</a>
    /// </summary>
    let Tactile = _prefixId.prefix "Tactile"
    /// <summary>
    ///   <para>rdfs:label : Tactile notation^^xsd:string</para>
    ///   <para>skos:definition : Information on the symbol system used to convey the content of a tactile resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Modified label [GH67])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/TactileNotation">bf:TactileNotation</a>
    /// </summary>
    let TactileNotation = _prefixId.prefix "TactileNotation"
    /// <summary>
    ///   <para>rdfs:label : Tape configuration^^xsd:string</para>
    ///   <para>skos:definition : Number of tracks on an audiotape, e.g., 12 track^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/TapeConfig">bf:TapeConfig</a>
    /// </summary>
    let TapeConfig = _prefixId.prefix "TapeConfig"
    /// <summary>
    ///   <para>rdfs:label : Tempo^^xsd:string</para>
    ///   <para>skos:definition : The speed of pace of a music work, whether declared in a score or performed^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Tempo">bf:Tempo</a>
    /// </summary>
    let Tempo = _prefixId.prefix "Tempo"
    /// <summary>
    ///   <para>rdfs:label : Temporal concept^^xsd:string</para>
    ///   <para>skos:definition : Chronological period^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Temporal">bf:Temporal</a>
    /// </summary>
    let Temporal = _prefixId.prefix "Temporal"
    /// <summary>
    ///   <para>rdfs:label : Text^^xsd:string</para>
    ///   <para>skos:definition : Resource intended to be perceived visually and understood through the use of language in written or spoken form^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Text">bf:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:label : Thematic catalog number^^xsd:string</para>
    ///   <para>skos:definition : A numeric or alphanumeric designation of a musical work as found in a thematic index or catalog^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ThematicCatalogNumber">bf:ThematicCatalogNumber</a>
    /// </summary>
    let ThematicCatalogNumber = _prefixId.prefix "ThematicCatalogNumber"
    /// <summary>
    ///   <para>rdfs:label : Title entity^^xsd:string</para>
    ///   <para>skos:definition : Title information relating to a resource: work title, preferred title, instance title, transcribed title, translated title, variant form of title, etc.^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Definition changed)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Title">bf:Title</a>
    /// </summary>
    let Title = _prefixId.prefix "Title"
    /// <summary>
    ///   <para>rdfs:label : Topic^^xsd:string</para>
    ///   <para>skos:definition : Concept or area of knowledge^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Topic">bf:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>rdfs:label : Track configuration^^xsd:string</para>
    ///   <para>skos:definition : Configuration of the audio track on a sound-track film, e.g., center track, edge track^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/TrackConfig">bf:TrackConfig</a>
    /// </summary>
    let TrackConfig = _prefixId.prefix "TrackConfig"
    /// <summary>
    ///   <para>rdfs:label : Transliterated title^^xsd:string</para>
    ///   <para>skos:definition : Title transliterated from one script to another^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-11-30 (New [GH104])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/TransliteratedTitle">bf:TransliteratedTitle</a>
    /// </summary>
    let TransliteratedTitle = _prefixId.prefix "TransliteratedTitle"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <para>skos:definition : Units in which a value is expressed^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Unit">bf:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : UPC^^xsd:string</para>
    ///   <para>skos:definition : Universal Product Code^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Upc">bf:Upc</a>
    /// </summary>
    let Upc = _prefixId.prefix "Upc"
    /// <summary>
    ///   <para>rdfs:label : URN^^xsd:string</para>
    ///   <para>skos:definition : Uniform Resource Name^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Corrected definition [GH51])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Urn">bf:Urn</a>
    /// </summary>
    let Urn = _prefixId.prefix "Urn"
    /// <summary>
    ///   <para>rdfs:label : Use and access conditions^^xsd:string</para>
    ///   <para>skos:definition : General statement of allowances and restrictions on access to a resource, including retention, reproduction, access, and lending^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/UsageAndAccessPolicy">bf:UsageAndAccessPolicy</a>
    /// </summary>
    let UsageAndAccessPolicy = _prefixId.prefix "UsageAndAccessPolicy"
    /// <summary>
    ///   <para>rdfs:label : Use policy^^xsd:string</para>
    ///   <para>skos:definition : Usage limitations placed on a resource with respect to reproduction, publication, exhibition, etc.^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/UsePolicy">bf:UsePolicy</a>
    /// </summary>
    let UsePolicy = _prefixId.prefix "UsePolicy"
    /// <summary>
    ///   <para>rdfs:label : Title variation^^xsd:string</para>
    ///   <para>skos:definition : Title associated with the resource that is different from the Work or Instance title^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/VariantTitle">bf:VariantTitle</a>
    /// </summary>
    let VariantTitle = _prefixId.prefix "VariantTitle"
    /// <summary>
    ///   <para>rdfs:label : Video characteristic^^xsd:string</para>
    ///   <para>skos:definition : Technical specification relating to the encoding of video images in a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/VideoCharacteristic">bf:VideoCharacteristic</a>
    /// </summary>
    let VideoCharacteristic = _prefixId.prefix "VideoCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Video format^^xsd:string</para>
    ///   <para>skos:definition : Standard, etc., used to encode the analog video content of a resource, e.g., Beta, 8mm^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/VideoFormat">bf:VideoFormat</a>
    /// </summary>
    let VideoFormat = _prefixId.prefix "VideoFormat"
    /// <summary>
    ///   <para>rdfs:label : Video recording number^^xsd:string</para>
    ///   <para>skos:definition : Number assigned by a publisher to a video recording^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Corrected case in class name)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/VideoRecordingNumber">bf:VideoRecordingNumber</a>
    /// </summary>
    let VideoRecordingNumber = _prefixId.prefix "VideoRecordingNumber"
    /// <summary>
    ///   <para>rdfs:label : Videogame platform identifier^^xsd:string</para>
    ///   <para>skos:definition : An identifier assigned to a videogame platform^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/VideogamePlatformId">bf:VideogamePlatformId</a>
    /// </summary>
    let VideogamePlatformId = _prefixId.prefix "VideogamePlatformId"
    /// <summary>
    ///   <para>rdfs:label : Work^^xsd:string</para>
    ///   <para>skos:definition : Resource reflecting a conceptual essence of a cataloging resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/Work">bf:Work</a>
    /// </summary>
    let Work = _prefixId.prefix "Work"
    /// <summary>
    ///   <para>skos:definition : Resource that has been incorporated into another resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Absorption of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/absorbed">bf:absorbed</a>
    /// </summary>
    let absorbed = _prefixId.prefix "absorbed"
    /// <summary>
    ///   <para>skos:definition : Resource that incorporates another resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Absorbed by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/absorbedBy">bf:absorbedBy</a>
    /// </summary>
    let absorbedBy = _prefixId.prefix "absorbedBy"
    /// <summary>
    ///   <para>skos:definition : Resource that accompanies the described resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:stringrdfs:comment : Suggested value - Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Accompanied by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/accompaniedBy">bf:accompaniedBy</a>
    /// </summary>
    let accompaniedBy = _prefixId.prefix "accompaniedBy"
    /// <summary>
    ///   <para>skos:definition : Resource that adds to or is issued with the described resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:stringrdfs:comment : Suggested value - Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Accompanies^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/accompanies">bf:accompanies</a>
    /// </summary>
    let accompanies = _prefixId.prefix "accompanies"
    /// <summary>
    ///   <para>skos:definition : Information about an organization, person, etc., from which a resource may be obtained.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Source of acquisition^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-06 (Changed from data to object property, slight change to definition)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH63])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/acquisitionSource">bf:acquisitionSource</a>
    /// </summary>
    let acquisitionSource = _prefixId.prefix "acquisitionSource"
    /// <summary>
    ///   <para>skos:definition : Conditions under which the publisher, distributor, etc., will normally supply a resource, e.g., price of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Terms of acquisition^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/acquisitionTerms">bf:acquisitionTerms</a>
    /// </summary>
    let acquisitionTerms = _prefixId.prefix "acquisitionTerms"
    /// <summary>
    ///   <para>skos:definition : Metadata about the metadata, especially provenance information.^^xsd:string</para>
    ///   <para>rdfs:label : Administrative metadata^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/adminMetadata">bf:adminMetadata</a>
    /// </summary>
    let adminMetadata = _prefixId.prefix "adminMetadata"
    /// <summary>
    ///   <para>skos:definition : Relates an Administrative metadata resource to the resource it captures information about.^^xsd:string</para>
    ///   <para>rdfs:label : Administrative metadata for^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH59])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/adminMetadataFor">bf:adminMetadataFor</a>
    /// </summary>
    let adminMetadataFor = _prefixId.prefix "adminMetadataFor"
    /// <summary>
    ///   <para>skos:definition : Entity associated with a resource or element of description, such as the name of the entity responsible for the content or of the publication, printing, distribution, issue, release or production of a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Associated agent^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - bf:Agent or foaf:Agent^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH63])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/agent">bf:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>skos:definition : Property relating an agent, such as an entity responsible for the content or of the publication, printing, distribution, issue, release or production, to another resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With bf:Agent or foaf:Agent^^xsd:string</para>
    ///   <para>rdfs:label : Associated agent of^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH3])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/agentOf">bf:agentOf</a>
    /// </summary>
    let agentOf = _prefixId.prefix "agentOf"
    /// <summary>
    ///   <para>skos:definition : Physical or chemical substance applied to a base material of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Applied material^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH24], Broadened domain, Made subproperty of material [GH26])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/appliedMaterial">bf:appliedMaterial</a>
    /// </summary>
    let appliedMaterial = _prefixId.prefix "appliedMaterial"
    /// <summary>
    ///   <para>skos:definition : Relates a Material resource to that which it is the applied material of.^^xsd:string</para>
    ///   <para>rdfs:label : Applied material of^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH25])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/appliedMaterialOf">bf:appliedMaterialOf</a>
    /// </summary>
    let appliedMaterialOf = _prefixId.prefix "appliedMaterialOf"
    /// <summary>
    ///   <para>skos:definition : Relates one resource to another of which it is an arrangement of the first^^xsd:string</para>
    ///   <para>rdfs:label : Arrangement^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Redefined [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/arrangement">bf:arrangement</a>
    /// </summary>
    let arrangement = _prefixId.prefix "arrangement"
    /// <summary>
    ///   <para>skos:definition : Relates an arrangement to the resource of which it is an arrangement.^^xsd:string</para>
    ///   <para>rdfs:label : Arrangement of^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/arrangementOf">bf:arrangementOf</a>
    /// </summary>
    let arrangementOf = _prefixId.prefix "arrangementOf"
    /// <summary>
    ///   <para>skos:definition : System for identifying the location of a celestial object in the sky covered by the cartographic content of a resource using the angles of right ascension and declination.^^xsd:string</para>
    ///   <para>rdfs:label : Cartographic ascension and declination^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ascensionAndDeclination">bf:ascensionAndDeclination</a>
    /// </summary>
    let ascensionAndDeclination = _prefixId.prefix "ascensionAndDeclination"
    /// <summary>
    ///   <para>skos:definition : Proportional relationship between an image's width and its height.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Aspect ratio^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/aspectRatio">bf:aspectRatio</a>
    /// </summary>
    let aspectRatio = _prefixId.prefix "aspectRatio"
    /// <summary>
    ///   <para>skos:definition : Entity that assigned the metadata, such as the entity that assigned a classification number, entity that assigned a name, entity that assigned an identifier.^^xsd:string</para>
    ///   <para>rdfs:label : Assigner^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broaden domain [GH60], Broadened range [GH63])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:stringdcterms:modified : 2025-07-15 (Expected value fix [GH132])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/assigner">bf:assigner</a>
    /// </summary>
    let assigner = _prefixId.prefix "assigner"
    /// <summary>
    ///   <para>skos:definition : Associated resource^^xsd:string</para>
    ///   <para>rdfs:label : Associated resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - With Work or Hub^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-07-10 (New [GH116])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/associatedResource">bf:associatedResource</a>
    /// </summary>
    let associatedResource = _prefixId.prefix "associatedResource"
    /// <summary>
    ///   <para>skos:definition : Information on awards associated with the described resource.^^xsd:string</para>
    ///   <para>skos:editorialNote : See also the ARM Ontology for strategies to model this information in greater detail.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Award note^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Added note [GH37])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/awards">bf:awards</a>
    /// </summary>
    let awards = _prefixId.prefix "awards"
    /// <summary>
    ///   <para>skos:definition : Underlying physical material of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Base material^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH24], Broadened domain, Made subproperty of material [GH26])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/baseMaterial">bf:baseMaterial</a>
    /// </summary>
    let baseMaterial = _prefixId.prefix "baseMaterial"
    /// <summary>
    ///   <para>skos:definition : Relates a Material resource to that which it is the base material of.^^xsd:string</para>
    ///   <para>rdfs:label : Base material of^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH25])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/baseMaterialOf">bf:baseMaterialOf</a>
    /// </summary>
    let baseMaterialOf = _prefixId.prefix "baseMaterialOf"
    /// <summary>
    ///   <para>skos:definition : A method used to bind a published or unpublished resource,or other binding information.^^xsd:string</para>
    ///   <para>rdfs:label : Binding method^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH91])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/binding">bf:binding</a>
    /// </summary>
    let binding = _prefixId.prefix "binding"
    /// <summary>
    ///   <para>skos:definition : Result of folding a printed sheet to form a gathering of leaves.^^xsd:string</para>
    ///   <para>rdfs:label : Book format^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/bookFormat">bf:bookFormat</a>
    /// </summary>
    let bookFormat = _prefixId.prefix "bookFormat"
    /// <summary>
    ///   <para>skos:definition : Information about place and date associated with the capture (e.g., recording, filming) of the content of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Capture of content^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/capture">bf:capture</a>
    /// </summary>
    let capture = _prefixId.prefix "capture"
    /// <summary>
    ///   <para>skos:definition : Categorization reflecting the format of the storage medium and housing of a carrier.^^xsd:string</para>
    ///   <para>rdfs:label : Carrier type^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - bf:Carrier or skos:Concept^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (Broadened range [GH72])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/carrier">bf:carrier</a>
    /// </summary>
    let carrier = _prefixId.prefix "carrier"
    /// <summary>
    ///   <para>skos:definition : Cartographic data that identifies characteristics of the resource, such as coordinates, projection, etc.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Cartographic data^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/cartographicAttributes">bf:cartographicAttributes</a>
    /// </summary>
    let cartographicAttributes = _prefixId.prefix "cartographicAttributes"
    /// <summary>
    ///   <para>skos:definition : Date or date and time on which the metadata was modified^^xsd:string</para>
    ///   <para>rdfs:label : Description change date^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/changeDate">bf:changeDate</a>
    /// </summary>
    let changeDate = _prefixId.prefix "changeDate"
    /// <summary>
    ///   <para>skos:definition : Classification number in any scheme.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Classification^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/classification">bf:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    /// <summary>
    ///   <para>skos:definition : Classification number (single class number or beginning number of a span) that indicates the subject by applying a formal system of coding and organizing resources.^^xsd:string</para>
    ///   <para>rdfs:label : Classification number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/classificationPortion">bf:classificationPortion</a>
    /// </summary>
    let classificationPortion = _prefixId.prefix "classificationPortion"
    /// <summary>
    ///   <para>skos:definition : String of characters that serves as a code representing information.^^xsd:string</para>
    ///   <para>rdfs:label : Code^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/code">bf:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>skos:definition : Information about the organization and arrangement of a collection of resources.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Collection Organization and arrangement^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/collectionArrangement">bf:collectionArrangement</a>
    /// </summary>
    let collectionArrangement = _prefixId.prefix "collectionArrangement"
    /// <summary>
    ///   <para>skos:definition : Relates an Arrangement resource to that which it describes.^^xsd:string</para>
    ///   <para>rdfs:label : Organization and arrangement of Collection^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/collectionArrangementOf">bf:collectionArrangementOf</a>
    /// </summary>
    let collectionArrangementOf = _prefixId.prefix "collectionArrangementOf"
    /// <summary>
    ///   <para>skos:definition : Manner in which the resource is divided into smaller units.^^xsd:string</para>
    ///   <para>rdfs:label : Organization of material^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/collectionOrganization">bf:collectionOrganization</a>
    /// </summary>
    let collectionOrganization = _prefixId.prefix "collectionOrganization"
    /// <summary>
    ///   <para>skos:definition : Color characteristics, e.g., black and white, multicolored.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Color content^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broaden range [GH31])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/colorContent">bf:colorContent</a>
    /// </summary>
    let colorContent = _prefixId.prefix "colorContent"
    /// <summary>
    ///   <para>skos:definition : Categorization reflecting the fundamental form of communication in which the content is expressed and the human sense through which it is intended to be perceived.^^xsd:string</para>
    ///   <para>rdfs:label : Content type^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - bf:Content or skos:Concept^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (Broadened range [GH71])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/content">bf:content</a>
    /// </summary>
    let content = _prefixId.prefix "content"
    /// <summary>
    ///   <para>skos:definition : Information that assists those with a sensory impairment for greater understanding of content, e.g., captions.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Content accessibility information^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (changed from data to object property)^^xsd:stringdcterms:modified : 2017-03-15 (fixed typo in range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/contentAccessibility">bf:contentAccessibility</a>
    /// </summary>
    let contentAccessibility = _prefixId.prefix "contentAccessibility"
    /// <summary>
    ///   <para>skos:definition : Resource whose content continues an earlier resource under a new title^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Continued by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/continuedBy">bf:continuedBy</a>
    /// </summary>
    let continuedBy = _prefixId.prefix "continuedBy"
    /// <summary>
    ///   <para>skos:definition : Resource part of whose content separated from an earlier resource to form a new resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Continued in part by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/continuedInPartBy">bf:continuedInPartBy</a>
    /// </summary>
    let continuedInPartBy = _prefixId.prefix "continuedInPartBy"
    /// <summary>
    ///   <para>skos:definition : Resource that is continued by the content of a later resource under a new title^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Continuation of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/continues">bf:continues</a>
    /// </summary>
    let continues = _prefixId.prefix "continues"
    /// <summary>
    ///   <para>skos:definition : Resource that split into two or more separate resources with new titles^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Continuation in part of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/continuesInPart">bf:continuesInPart</a>
    /// </summary>
    let continuesInPart = _prefixId.prefix "continuesInPart"
    /// <summary>
    ///   <para>skos:definition : Agent and its role in relation to the resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Contributor and role^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Corrected label)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/contribution">bf:contribution</a>
    /// </summary>
    let contribution = _prefixId.prefix "contribution"
    /// <summary>
    ///   <para>skos:definition : Relates a contribution resource, which associates an Agent and Role together, to the relevant resource^^xsd:string</para>
    ///   <para>rdfs:label : Contribution of^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - Work, Instance or Item^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH4])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/contributionOf">bf:contributionOf</a>
    /// </summary>
    let contributionOf = _prefixId.prefix "contributionOf"
    /// <summary>
    ///   <para>skos:definition : Mathematical system for identifying the area covered by the cartographic content of a resource, expressed either by means of longitude and latitude on the surface of planets or by the angles of right ascension and declination for celestial cartographic content.^^xsd:string</para>
    ///   <para>rdfs:label : Cartographic coordinates^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/coordinates">bf:coordinates</a>
    /// </summary>
    let coordinates = _prefixId.prefix "coordinates"
    /// <summary>
    ///   <para>skos:definition : Date associated with a claim of protection under copyright or a similar regime.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Copyright date^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/copyrightDate">bf:copyrightDate</a>
    /// </summary>
    let copyrightDate = _prefixId.prefix "copyrightDate"
    /// <summary>
    ///   <para>skos:definition : Copyright and Legal Deposit registration information^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Copyright registration information^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-05-04 (Corrected expected value)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/copyrightRegistration">bf:copyrightRegistration</a>
    /// </summary>
    let copyrightRegistration = _prefixId.prefix "copyrightRegistration"
    /// <summary>
    ///   <para>skos:definition : Number associated with a measure of units, such as the number of units and/or subunits making up a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Number of units^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/count">bf:count</a>
    /// </summary>
    let count = _prefixId.prefix "count"
    /// <summary>
    ///   <para>skos:definition : Cover art image of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Cover art^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/coverArt">bf:coverArt</a>
    /// </summary>
    let coverArt = _prefixId.prefix "coverArt"
    /// <summary>
    ///   <para>skos:definition : Date or date and time on which the original metadata first created^^xsd:string</para>
    ///   <para>rdfs:label : Description creation date^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/creationDate">bf:creationDate</a>
    /// </summary>
    let creationDate = _prefixId.prefix "creationDate"
    /// <summary>
    ///   <para>skos:definition : Information in note form of credits for persons or organizations who have participated in the creation and/or production of the resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Credits note^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/credits">bf:credits</a>
    /// </summary>
    let credits = _prefixId.prefix "credits"
    /// <summary>
    ///   <para>skos:definition : Information about the provenance, such as origin, ownership and custodial history (chain of custody), of a resource.^^xsd:string</para>
    ///   <para>skos:editorialNote : See also the ARM Ontology for strategies to model this information in greater detail.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Custodial history^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Added note [GH38])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/custodialHistory">bf:custodialHistory</a>
    /// </summary>
    let custodialHistory = _prefixId.prefix "custodialHistory"
    /// <summary>
    ///   <para>skos:definition : Resource that is a data source to which the described resource is related; may contain information about other files, printed sources, or collection procedures^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Data source^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/dataSource">bf:dataSource</a>
    /// </summary>
    let dataSource = _prefixId.prefix "dataSource"
    /// <summary>
    ///   <para>skos:definition : Date designation associated with a resource or element of description, such as date of title variation; year a degree was awarded; date associated with the publication, printing, distribution, issue, release or production of a resource. May be date typed.^^xsd:string</para>
    ///   <para>rdfs:label : Date^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Removed defined range [GH125])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/date">bf:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>skos:definition : Degree for which author was a candidate.^^xsd:string</para>
    ///   <para>rdfs:label : Degree^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/degree">bf:degree</a>
    /// </summary>
    let degree = _prefixId.prefix "degree"
    /// <summary>
    ///   <para>skos:definition : A relationship that records the fact that one resource is a derivative of another resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Is derivative of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:stringdcterms:modified : 2025-12-01 (revised definition [GH138])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/derivativeOf">bf:derivativeOf</a>
    /// </summary>
    let derivativeOf = _prefixId.prefix "derivativeOf"
    /// <summary>
    ///   <para>skos:definition : Meant to establish a link from a description that was derived from, perhaps via copy, another description; example: X description/metadata was derived from Y description/metadata^^xsd:string</para>
    ///   <para>rdfs:label : Source metadata^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH41])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:stringdcterms:modified : 2025-12-01 (revised definition [GH138])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/derivedFrom">bf:derivedFrom</a>
    /// </summary>
    let derivedFrom = _prefixId.prefix "derivedFrom"
    /// <summary>
    ///   <para>skos:definition : Indication of specific types of reviews that have been carried out on the description information^^xsd:string</para>
    ///   <para>rdfs:label : Description authentication^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/descriptionAuthentication">bf:descriptionAuthentication</a>
    /// </summary>
    let descriptionAuthentication = _prefixId.prefix "descriptionAuthentication"
    /// <summary>
    ///   <para>skos:definition : Rules used for the descriptive content of the resource description^^xsd:string</para>
    ///   <para>rdfs:label : Description conventions^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-24 (fixed domain name)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/descriptionConventions">bf:descriptionConventions</a>
    /// </summary>
    let descriptionConventions = _prefixId.prefix "descriptionConventions"
    /// <summary>
    ///   <para>skos:definition : Language used for the metadata^^xsd:string</para>
    ///   <para>rdfs:label : Description language^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/descriptionLanguage">bf:descriptionLanguage</a>
    /// </summary>
    let descriptionLanguage = _prefixId.prefix "descriptionLanguage"
    /// <summary>
    ///   <para>skos:definition : Designation of the descriptive content of the metadata^^xsd:string</para>
    ///   <para>rdfs:label : Description level^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH43])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/descriptionLevel">bf:descriptionLevel</a>
    /// </summary>
    let descriptionLevel = _prefixId.prefix "descriptionLevel"
    /// <summary>
    ///   <para>skos:definition : Agency that modified a description^^xsd:string</para>
    ///   <para>rdfs:label : Description modifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH63])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/descriptionModifier">bf:descriptionModifier</a>
    /// </summary>
    let descriptionModifier = _prefixId.prefix "descriptionModifier"
    /// <summary>
    ///   <para>skos:definition : Technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Digital characteristic^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/digitalCharacteristic">bf:digitalCharacteristic</a>
    /// </summary>
    let digitalCharacteristic = _prefixId.prefix "digitalCharacteristic"
    /// <summary>
    ///   <para>skos:definition : Measurements of the carrier or carriers and/or the container of a resource.^^xsd:string</para>
    ///   <para>skos:editorialNote : See also the ARM Ontology for strategies to model this information in greater detail.^^xsd:string</para>
    ///   <para>rdfs:label : Dimensions^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Added note [GH39])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/dimensions">bf:dimensions</a>
    /// </summary>
    let dimensions = _prefixId.prefix "dimensions"
    /// <summary>
    ///   <para>skos:definition : Work presented as part of the formal requirements for an academic degree.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Dissertation Information^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/dissertation">bf:dissertation</a>
    /// </summary>
    let dissertation = _prefixId.prefix "dissertation"
    /// <summary>
    ///   <para>skos:definition : Statement related to the distribution of the resources; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Distribution statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-07-10 (New [GH124])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/distributionStatement">bf:distributionStatement</a>
    /// </summary>
    let distributionStatement = _prefixId.prefix "distributionStatement"
    /// <summary>
    ///   <para>skos:definition : Relates a contribution to a dramatic role^^xsd:string</para>
    ///   <para>rdfs:label : Dramatic Role^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/dramaticRole">bf:dramaticRole</a>
    /// </summary>
    let dramaticRole = _prefixId.prefix "dramaticRole"
    /// <summary>
    ///   <para>skos:definition : Information about the playing time, running time, etc. of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Duration^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/duration">bf:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>skos:definition : Edition of the classification scheme, such as full, abridged or a number, when a classification scheme designates editions.^^xsd:string</para>
    ///   <para>rdfs:label : Classification scheme edition^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/edition">bf:edition</a>
    /// </summary>
    let edition = _prefixId.prefix "edition"
    /// <summary>
    ///   <para>skos:definition : Enumeration of the edition; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Edition enumeration^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/editionEnumeration">bf:editionEnumeration</a>
    /// </summary>
    let editionEnumeration = _prefixId.prefix "editionEnumeration"
    /// <summary>
    ///   <para>skos:definition : Information identifying the edition or version of the resource and associated statements of responsibility for the edition; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Edition statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/editionStatement">bf:editionStatement</a>
    /// </summary>
    let editionStatement = _prefixId.prefix "editionStatement"
    /// <summary>
    ///   <para>skos:definition : Electronic location from which the resource is available.^^xsd:string</para>
    ///   <para>rdfs:label : Electronic location^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Removed domain [GH66])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/electronicLocator">bf:electronicLocator</a>
    /// </summary>
    let electronicLocator = _prefixId.prefix "electronicLocator"
    /// <summary>
    ///   <para>skos:definition : Suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche, e.g., silver halide.^^xsd:string</para>
    ///   <para>rdfs:label : Emulsion^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/emulsion">bf:emulsion</a>
    /// </summary>
    let emulsion = _prefixId.prefix "emulsion"
    /// <summary>
    ///   <para>skos:definition : Composition of the ensemble applicable to the Work.^^xsd:string</para>
    ///   <para>rdfs:label : Ensemble^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Changed domain [GH56], Modified definition [GH56])^^xsd:stringdcterms:modified : 2025-12-01 (Modified definition [GH135])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ensemble">bf:ensemble</a>
    /// </summary>
    let ensemble = _prefixId.prefix "ensemble"
    /// <summary>
    ///   <para>skos:definition : Relates a work to the musical ensemble size^^xsd:string</para>
    ///   <para>rdfs:label : Ensemble size^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ensembleSize">bf:ensembleSize</a>
    /// </summary>
    let ensembleSize = _prefixId.prefix "ensembleSize"
    /// <summary>
    ///   <para>skos:definition : Specific type of ensemble, such as orchestra, band, guitar ensemble.^^xsd:string</para>
    ///   <para>rdfs:label : Ensemble type^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Changed domain [GH56])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/ensembleType">bf:ensembleType</a>
    /// </summary>
    let ensembleType = _prefixId.prefix "ensembleType"
    /// <summary>
    ///   <para>skos:definition : Numbering and dates of issues or items held.^^xsd:string</para>
    ///   <para>rdfs:label : Enumeration and chronology^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-07-15 (Broadened range [GH129])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/enumerationAndChronology">bf:enumerationAndChronology</a>
    /// </summary>
    let enumerationAndChronology = _prefixId.prefix "enumerationAndChronology"
    /// <summary>
    ///   <para>skos:definition : One of two points of intersection of the ecliptic and the celestial equator, occupied by the sun when its declination is 0 degrees.^^xsd:string</para>
    ///   <para>rdfs:label : Cartographic equinox^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/equinox">bf:equinox</a>
    /// </summary>
    let equinox = _prefixId.prefix "equinox"
    /// <summary>
    ///   <para>skos:definition : Work whose content is the described event^^xsd:string</para>
    ///   <para>rdfs:label : Event content^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/eventContent">bf:eventContent</a>
    /// </summary>
    let eventContent = _prefixId.prefix "eventContent"
    /// <summary>
    ///   <para>skos:definition : Event that is the content of the described work^^xsd:string</para>
    ///   <para>rdfs:label : Has event content^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/eventContentOf">bf:eventContentOf</a>
    /// </summary>
    let eventContentOf = _prefixId.prefix "eventContentOf"
    /// <summary>
    ///   <para>skos:definition : Coordinate pairs that identify the closed non-intersecting boundary of the area contained within the G-polygon outer ring that is excluded.^^xsd:string</para>
    ///   <para>rdfs:label : Cartographic G ring area excluded^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/exclusionGRing">bf:exclusionGRing</a>
    /// </summary>
    let exclusionGRing = _prefixId.prefix "exclusionGRing"
    /// <summary>
    ///   <para>skos:definition : Work or Hub that the described Work or Hub is an expression of; used to connect Works and/or Hubs under LRM/RDA guidelines or similar implementations^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Hub^^xsd:stringrdfs:comment : Suggested value - With Work or Hub^^xsd:string</para>
    ///   <para>rdfs:label : Expression of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:stringdcterms:modified : 2021-06-09 (Modified definition [GH8])^^xsd:stringdcterms:modified : 2023-11-30 (Modified domain/range to support Hub [GH110])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/expressionOf">bf:expressionOf</a>
    /// </summary>
    let expressionOf = _prefixId.prefix "expressionOf"
    /// <summary>
    ///   <para>skos:definition : Number and type of units and/or subunits making up a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Extent^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH30])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/extent">bf:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>skos:definition : Relationship for archival, visual, and manuscript resources to a finding aid or similar control materials^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Finding aid^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/findingAid">bf:findingAid</a>
    /// </summary>
    let findingAid = _prefixId.prefix "findingAid"
    /// <summary>
    ///   <para>skos:definition : Finding aid or similar control materials for archival, visual, and manuscript resources^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Finding aid for^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/findingAidOf">bf:findingAidOf</a>
    /// </summary>
    let findingAidOf = _prefixId.prefix "findingAidOf"
    /// <summary>
    ///   <para>skos:definition : Beginning date of a resource and/or the sequential designations.^^xsd:string</para>
    ///   <para>rdfs:label : Multipart first issue^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Removed domain [GH76])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/firstIssue">bf:firstIssue</a>
    /// </summary>
    let firstIssue = _prefixId.prefix "firstIssue"
    /// <summary>
    ///   <para>skos:definition : Size of the type used to represent the characters and symbols in a resource.^^xsd:string</para>
    ///   <para>skos:editorialNote : See also the ARM Ontology for strategies to model this information in greater detail.^^xsd:string</para>
    ///   <para>rdfs:label : Font size^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Added note [GH40])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/fontSize">bf:fontSize</a>
    /// </summary>
    let fontSize = _prefixId.prefix "fontSize"
    /// <summary>
    ///   <para>skos:definition : Intervals at which the parts of a serially produced resource or the updates to an integrating resource are issued.^^xsd:string</para>
    ///   <para>rdfs:label : Frequency^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Removed domain [GH76])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/frequency">bf:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    /// <summary>
    ///   <para>skos:definition : Relationship between an original carrier and the carrier of a reproduction made from the original.^^xsd:string</para>
    ///   <para>rdfs:label : Generation^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/generation">bf:generation</a>
    /// </summary>
    let generation = _prefixId.prefix "generation"
    /// <summary>
    ///   <para>skos:definition : Date of conversion of the metadata from another format^^xsd:string</para>
    ///   <para>rdfs:label : Date generated^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/generationDate">bf:generationDate</a>
    /// </summary>
    let generationDate = _prefixId.prefix "generationDate"
    /// <summary>
    ///   <para>skos:definition : Indication of the program or process used to generate the description by application of a particular transformation^^xsd:string</para>
    ///   <para>rdfs:label : Description generation^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/generationProcess">bf:generationProcess</a>
    /// </summary>
    let generationProcess = _prefixId.prefix "generationProcess"
    /// <summary>
    ///   <para>skos:definition : Form category or genre to which a resource belongs^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:stringrdfs:comment : Suggested value - bf:GenreForm or madsrdf:GenreForm or skos:Concept^^xsd:string</para>
    ///   <para>rdfs:label : Genre/form^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH16])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/genreForm">bf:genreForm</a>
    /// </summary>
    let genreForm = _prefixId.prefix "genreForm"
    /// <summary>
    ///   <para>skos:definition : Geographic coverage of the content of the resource.^^xsd:string</para>
    ///   <para>rdfs:label : Geographic coverage^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - bf:GeographicCoverage or bf:Place or madsrdf:Geographic^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-06 (Changed from data to object property)^^xsd:stringdcterms:modified : 2021-06-09 (Removed domain [GH15])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/geographicCoverage">bf:geographicCoverage</a>
    /// </summary>
    let geographicCoverage = _prefixId.prefix "geographicCoverage"
    /// <summary>
    ///   <para>skos:definition : Name of degree granting institution.^^xsd:string</para>
    ///   <para>rdfs:label : Degree issuing institution^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH63])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/grantingInstitution">bf:grantingInstitution</a>
    /// </summary>
    let grantingInstitution = _prefixId.prefix "grantingInstitution"
    /// <summary>
    ///   <para>skos:definition : A relationship which records that the described resource has a derivative resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Has derivative^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:stringdcterms:modified : 2025-12-01 (revised definition [GH138])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hasDerivative">bf:hasDerivative</a>
    /// </summary>
    let hasDerivative = _prefixId.prefix "hasDerivative"
    let hasEquivalent = _prefixId.prefix "hasEquivalent"
    /// <summary>
    ///   <para>skos:definition : Work or Hub that is an expression of a described Work or Hub; used to relate Works and/or Hubs under LRM/RDA guidelines or similar implementations^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Hub^^xsd:stringrdfs:comment : Suggested value - With Work or Hub^^xsd:string</para>
    ///   <para>rdfs:label : Expressed as^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:stringdcterms:modified : 2021-06-09 (Modified definition [GH8])^^xsd:stringdcterms:modified : 2023-11-30 (Modified domain/range to support Hub [GH110])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hasExpression">bf:hasExpression</a>
    /// </summary>
    let hasExpression = _prefixId.prefix "hasExpression"
    /// <summary>
    ///   <para>skos:definition : Instance is related to described Work ; used to connect Works to Instances in the BIBFRAME structure^^xsd:string</para>
    ///   <para>rdfs:label : Instance of Work^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hasInstance">bf:hasInstance</a>
    /// </summary>
    let hasInstance = _prefixId.prefix "hasInstance"
    /// <summary>
    ///   <para>skos:definition : Item which is an example of the described Instance^^xsd:string</para>
    ///   <para>rdfs:label : Has holding^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:stringdcterms:modified : 2017-02-07 (slight revision of definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hasItem">bf:hasItem</a>
    /// </summary>
    let hasItem = _prefixId.prefix "hasItem"
    /// <summary>
    ///   <para>skos:definition : Resource that is included either physically or logically in the described resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance, Item or Event^^xsd:stringrdfs:comment : Suggested value - Work, Instance, Item or Event^^xsd:string</para>
    ///   <para>rdfs:label : Has part^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:stringdcterms:modified : 2021-06-09 (Use with Event also [GH9])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hasPart">bf:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>skos:definition : Resource that reproduces another Resource^^xsd:string</para>
    ///   <para>rdfs:label : Reproduced as^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hasReproduction">bf:hasReproduction</a>
    /// </summary>
    let hasReproduction = _prefixId.prefix "hasReproduction"
    /// <summary>
    ///   <para>skos:definition : Relation between a resource and the larger resource in which it has been issued; the title of the encompassing larger resource features on the part^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : In series^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2024-07-10 (updated definition [GF106])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hasSeries">bf:hasSeries</a>
    /// </summary>
    let hasSeries = _prefixId.prefix "hasSeries"
    /// <summary>
    ///   <para>skos:definition : Relation between a resource and the larger Series resource in which it has been issued; the larger Series resource is part of another overarching Series resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Subseries^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2024-07-10 (updated definition [GF106])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hasSubseries">bf:hasSubseries</a>
    /// </summary>
    let hasSubseries = _prefixId.prefix "hasSubseries"
    /// <summary>
    ///   <para>skos:definition : Entity holding the item or from which it is available.^^xsd:string</para>
    ///   <para>rdfs:label : Held by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH63])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/heldBy">bf:heldBy</a>
    /// </summary>
    let heldBy = _prefixId.prefix "heldBy"
    /// <summary>
    ///   <para>skos:definition : Hierarchical position of the described materials relative to other material from the same source.^^xsd:string</para>
    ///   <para>rdfs:label : Hierarchical level of material^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Modified range [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/hierarchicalLevel">bf:hierarchicalLevel</a>
    /// </summary>
    let hierarchicalLevel = _prefixId.prefix "hierarchicalLevel"
    /// <summary>
    ///   <para>skos:definition : Information about the history of a Work.^^xsd:string</para>
    ///   <para>rdfs:label : History of the work^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/historyOfWork">bf:historyOfWork</a>
    /// </summary>
    let historyOfWork = _prefixId.prefix "historyOfWork"
    /// <summary>
    ///   <para>skos:definition : Character string associated with a resource that serves to differentiate that resource from other resources, i.e., that uniquely identifies an entity.^^xsd:string</para>
    ///   <para>rdfs:label : Identifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-05-04 (New inverse)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/identifiedBy">bf:identifiedBy</a>
    /// </summary>
    let identifiedBy = _prefixId.prefix "identifiedBy"
    /// <summary>
    ///   <para>skos:definition : Resource that is associated with a character string that serves to differentiate one resource from another.^^xsd:string</para>
    ///   <para>rdfs:label : Resource identified^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-03 (New inverse)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/identifies">bf:identifies</a>
    /// </summary>
    let identifies = _prefixId.prefix "identifies"
    /// <summary>
    ///   <para>skos:definition : Information about content intended to illustrate a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Illustrative content information^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/illustrativeContent">bf:illustrativeContent</a>
    /// </summary>
    let illustrativeContent = _prefixId.prefix "illustrativeContent"
    /// <summary>
    ///   <para>skos:definition : Information about the circumstances, e.g., source, date, method, under which the resource was directly acquired.^^xsd:string</para>
    ///   <para>rdfs:label : Immediate acquisition^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-06 (Changed from data to object property)^^xsd:stringdcterms:modified : 2025-07-15 (Broadened range [GH127])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/immediateAcquisition">bf:immediateAcquisition</a>
    /// </summary>
    let immediateAcquisition = _prefixId.prefix "immediateAcquisition"
    /// <summary>
    ///   <para>skos:definition : Resource has an accompanying index^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Has index^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2017-02-03 (corrected label)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/index">bf:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    /// <summary>
    ///   <para>skos:definition : Index that accompanies a resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Index to^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/indexOf">bf:indexOf</a>
    /// </summary>
    let indexOf = _prefixId.prefix "indexOf"
    /// <summary>
    ///   <para>skos:definition : Work the Instance described instantiates or manifests; used to connect Instances to Works in the BIBFRAME structure^^xsd:string</para>
    ///   <para>rdfs:label : Instance of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/instanceOf">bf:instanceOf</a>
    /// </summary>
    let instanceOf = _prefixId.prefix "instanceOf"
    /// <summary>
    ///   <para>skos:definition : Instrument for which a musical Work is appropriate.^^xsd:string</para>
    ///   <para>rdfs:label : Instrument^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/instrument">bf:instrument</a>
    /// </summary>
    let instrument = _prefixId.prefix "instrument"
    /// <summary>
    ///   <para>skos:definition : Specific role of instrument, such as alternate, doubling, solo, ensemble.^^xsd:string</para>
    ///   <para>rdfs:label : Instrument role^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/instrumentalType">bf:instrumentalType</a>
    /// </summary>
    let instrumentalType = _prefixId.prefix "instrumentalType"
    /// <summary>
    ///   <para>skos:definition : Information that identifies the specific audience or intellectual level for which the content of the resource is considered appropriate.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Intended audience^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (Broadened range [GH74])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/intendedAudience">bf:intendedAudience</a>
    /// </summary>
    let intendedAudience = _prefixId.prefix "intendedAudience"
    /// <summary>
    ///   <para>skos:definition : Categorization reflecting whether a resource is issued in one or more parts, the way it is updated, and its intended termination.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Mode of issuance^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/issuance">bf:issuance</a>
    /// </summary>
    let issuance = _prefixId.prefix "issuance"
    let issuedWith = _prefixId.prefix "issuedWith"
    /// <summary>
    ///   <para>skos:definition : Instance for which the described Item is an example^^xsd:string</para>
    ///   <para>rdfs:label : Holding for^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:stringdcterms:modified : 2017-02-07 (slight revision of definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/itemOf">bf:itemOf</a>
    /// </summary>
    let itemOf = _prefixId.prefix "itemOf"
    /// <summary>
    ///   <para>skos:definition : Number attached to a classification string that indicates a particular item.^^xsd:string</para>
    ///   <para>rdfs:label : Classification item number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/itemPortion">bf:itemPortion</a>
    /// </summary>
    let itemPortion = _prefixId.prefix "itemPortion"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a musical key and mode^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Hub^^xsd:string</para>
    ///   <para>rdfs:label : Key and mode^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/keyMode">bf:keyMode</a>
    /// </summary>
    let keyMode = _prefixId.prefix "keyMode"
    /// <summary>
    ///   <para>skos:definition : Language associated with a resource or its parts.^^xsd:string</para>
    ///   <para>rdfs:label : Language information^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - bf:Language or madsrdf:Language^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (Broadened range [GH70])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/language">bf:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>skos:definition : Ending date of a resource and/or the sequential designations.^^xsd:string</para>
    ///   <para>rdfs:label : Multipart last issue^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Removed domain [GH76])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/lastIssue">bf:lastIssue</a>
    /// </summary>
    let lastIssue = _prefixId.prefix "lastIssue"
    /// <summary>
    ///   <para>skos:definition : Arrangement of text, images, tactile notation, etc., in a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Layout^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/layout">bf:layout</a>
    /// </summary>
    let layout = _prefixId.prefix "layout"
    /// <summary>
    ///   <para>skos:definition : Date of legal work, or promulgation of a law, or signing of a treaty.^^xsd:string</para>
    ///   <para>rdfs:label : Date of legal work^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/legalDate">bf:legalDate</a>
    /// </summary>
    let legalDate = _prefixId.prefix "legalDate"
    /// <summary>
    ///   <para>skos:definition : Title being addressed. Possible title component.^^xsd:string</para>
    ///   <para>rdfs:label : Main title^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/mainTitle">bf:mainTitle</a>
    /// </summary>
    let mainTitle = _prefixId.prefix "mainTitle"
    /// <summary>
    ///   <para>skos:definition : Statement related to the manufacture of the resources; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Manufacture statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-07-10 (New [GH124])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/manufactureStatement">bf:manufactureStatement</a>
    /// </summary>
    let manufactureStatement = _prefixId.prefix "manufactureStatement"
    /// <summary>
    ///   <para>skos:definition : Resource uses, is composed of, integrates, etc. the related material.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH26])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/material">bf:material</a>
    /// </summary>
    let material = _prefixId.prefix "material"
    /// <summary>
    ///   <para>skos:definition : This material is related to a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Material of^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH26])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/materialOf">bf:materialOf</a>
    /// </summary>
    let materialOf = _prefixId.prefix "materialOf"
    /// <summary>
    ///   <para>skos:definition : Categorization reflecting the general type of intermediation device required to view, play, run, etc., the content of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - bf:Media or skos:Concept^^xsd:string</para>
    ///   <para>rdfs:label : Media type^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2022-10-03 (Broadened range [GH73])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/media">bf:media</a>
    /// </summary>
    let media = _prefixId.prefix "media"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a medium component^^xsd:string</para>
    ///   <para>rdfs:label : Medium component^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/mediumComponent">bf:mediumComponent</a>
    /// </summary>
    let mediumComponent = _prefixId.prefix "mediumComponent"
    /// <summary>
    ///   <para>skos:definition : Relates a medium component to a qualifier that affects the medium of component^^xsd:string</para>
    ///   <para>rdfs:label : Medium component qualifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/mediumComponentQualifier">bf:mediumComponentQualifier</a>
    /// </summary>
    let mediumComponentQualifier = _prefixId.prefix "mediumComponentQualifier"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a musical medium of performance^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With MediumComponent or Contribution^^xsd:string</para>
    ///   <para>rdfs:label : Medium of performance^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:stringdcterms:modified : 2025-12-03 (Fix domain bug)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/mediumOfPerformance">bf:mediumOfPerformance</a>
    /// </summary>
    let mediumOfPerformance = _prefixId.prefix "mediumOfPerformance"
    /// <summary>
    ///   <para>skos:definition : One of two or more resources that come together to form a new resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Merged to form^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/mergedToForm">bf:mergedToForm</a>
    /// </summary>
    let mergedToForm = _prefixId.prefix "mergedToForm"
    /// <summary>
    ///   <para>skos:definition : One of two or more resources which came together to form a new resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Merger of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/mergerOf">bf:mergerOf</a>
    /// </summary>
    let mergerOf = _prefixId.prefix "mergerOf"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a music mode^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Hub^^xsd:string</para>
    ///   <para>rdfs:label : Mode^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/mode">bf:mode</a>
    /// </summary>
    let mode = _prefixId.prefix "mode"
    /// <summary>
    ///   <para>skos:definition : Physical material or object used for the support or backing to which the base material of a resource has been attached.^^xsd:string</para>
    ///   <para>rdfs:label : Mount material or object^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Modified label [GH29])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/mount">bf:mount</a>
    /// </summary>
    let mount = _prefixId.prefix "mount"
    /// <summary>
    ///   <para>skos:definition : Layout for content of a resource that is presented in the form of musical notation, such as full score, condensed score, vocal score, etc.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Format of notated music^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/musicFormat">bf:musicFormat</a>
    /// </summary>
    let musicFormat = _prefixId.prefix "musicFormat"
    /// <summary>
    ///   <para>skos:definition : Pitch and mode for music.^^xsd:string</para>
    ///   <para>rdfs:label : Music key^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-12-01 (Deprecated [GH137])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/musicKey">bf:musicKey</a>
    /// </summary>
    let musicKey = _prefixId.prefix "musicKey"
    /// <summary>
    ///   <para>skos:definition : Instrumental, vocal, and/or other medium of performance for which a musical resource was originally conceived, written or performed.^^xsd:string</para>
    ///   <para>rdfs:label : Music medium^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-12-01 (Revised label [GH135])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/musicMedium">bf:musicMedium</a>
    /// </summary>
    let musicMedium = _prefixId.prefix "musicMedium"
    /// <summary>
    ///   <para>skos:definition : Numeric designation of a musical work assigned by a composer, publisher, or a musicologist.^^xsd:string</para>
    ///   <para>rdfs:label : Music opus number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-12-01 (Deprecated [GH137])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/musicOpusNumber">bf:musicOpusNumber</a>
    /// </summary>
    let musicOpusNumber = _prefixId.prefix "musicOpusNumber"
    /// <summary>
    ///   <para>skos:definition : Numeric designation for musical works consecutively numbered in music reference sources.^^xsd:string</para>
    ///   <para>rdfs:label : Music serial number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-12-01 (Deprecated [GH137])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/musicSerialNumber">bf:musicSerialNumber</a>
    /// </summary>
    let musicSerialNumber = _prefixId.prefix "musicSerialNumber"
    /// <summary>
    ///   <para>skos:definition : Numeric designation for a musical work as found in a thematic index for the composer.^^xsd:string</para>
    ///   <para>rdfs:label : Music thematic number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-12-01 (Deprecated [GH137])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/musicThematicNumber">bf:musicThematicNumber</a>
    /// </summary>
    let musicThematicNumber = _prefixId.prefix "musicThematicNumber"
    /// <summary>
    ///   <para>skos:definition : Characterization that epitomizes the primary content of a resource, e.g., field recording of birdsong; combined time series analysis and graph plotting system.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Content nature^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/natureOfContent">bf:natureOfContent</a>
    /// </summary>
    let natureOfContent = _prefixId.prefix "natureOfContent"
    /// <summary>
    ///   <para>skos:definition : Alphabet, script, or symbol system used to convey the content of the resource, including specialized scripts, typefaces, tactile notation, movement notation, and musical notation.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Notation system^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/notation">bf:notation</a>
    /// </summary>
    let notation = _prefixId.prefix "notation"
    /// <summary>
    ///   <para>skos:definition : General textual information relating to a resource, such as Information about a specific copy of a resource or information about a particular attribute of a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Note^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/note">bf:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>skos:definition : Relates a Note resource to the resource to which the note pertains.^^xsd:string</para>
    ///   <para>rdfs:label : Note for^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH34])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/noteFor">bf:noteFor</a>
    /// </summary>
    let noteFor = _prefixId.prefix "noteFor"
    /// <summary>
    ///   <para>skos:definition : Type of note.^^xsd:string</para>
    ///   <para>rdfs:label : Note type^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/noteType">bf:noteType</a>
    /// </summary>
    let noteType = _prefixId.prefix "noteType"
    /// <summary>
    ///   <para>skos:definition : Relates a medium component to the number of hands required for performance^^xsd:string</para>
    ///   <para>rdfs:label : Number of hands^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/numberOfHands">bf:numberOfHands</a>
    /// </summary>
    let numberOfHands = _prefixId.prefix "numberOfHands"
    /// <summary>
    ///   <para>skos:definition : Date or date range associated with the creation of a Work.^^xsd:string</para>
    ///   <para>rdfs:label : Origin date^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Better align definition with property name [GH50])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/originDate">bf:originDate</a>
    /// </summary>
    let originDate = _prefixId.prefix "originDate"
    /// <summary>
    ///   <para>skos:definition : Place from which the creation of the resource originated.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - bf:Place or madsrdf:Geographic^^xsd:string</para>
    ///   <para>rdfs:label : Origin place^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Better align definition with property name [GH50], Broadened range [GH19])^^xsd:stringdcterms:modified : 2022-10-03 (updated domain [GH83])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/originPlace">bf:originPlace</a>
    /// </summary>
    let originPlace = _prefixId.prefix "originPlace"
    /// <summary>
    ///   <para>skos:definition : Resource is the original version of which this resource is a reproduction^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Original version^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/originalVersion">bf:originalVersion</a>
    /// </summary>
    let originalVersion = _prefixId.prefix "originalVersion"
    /// <summary>
    ///   <para>skos:definition : Original version of a resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Original version of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/originalVersionOf">bf:originalVersionOf</a>
    /// </summary>
    let originalVersionOf = _prefixId.prefix "originalVersionOf"
    let otherEdition = _prefixId.prefix "otherEdition"
    let otherPhysicalFormat = _prefixId.prefix "otherPhysicalFormat"
    /// <summary>
    ///   <para>skos:definition : Coordinate pairs that identify the closed non-intersecting boundary of the area covered.^^xsd:string</para>
    ///   <para>rdfs:label : Cartographic outer G ring area covered^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/outerGRing">bf:outerGRing</a>
    /// </summary>
    let outerGRing = _prefixId.prefix "outerGRing"
    /// <summary>
    ///   <para>skos:definition : Part of a resource to which information applies.^^xsd:string</para>
    ///   <para>rdfs:label : Part^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/part">bf:part</a>
    /// </summary>
    let part = _prefixId.prefix "part"
    /// <summary>
    ///   <para>skos:definition : Part or section name of a title. Possible title component.^^xsd:string</para>
    ///   <para>rdfs:label : Part title^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/partName">bf:partName</a>
    /// </summary>
    let partName = _prefixId.prefix "partName"
    /// <summary>
    ///   <para>skos:definition : Part or section enumeration of a title. Possible title component.^^xsd:string</para>
    ///   <para>rdfs:label : Part number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/partNumber">bf:partNumber</a>
    /// </summary>
    let partNumber = _prefixId.prefix "partNumber"
    /// <summary>
    ///   <para>skos:definition : Resource in which the described resource is physically or logically contained^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance, Item or Event^^xsd:stringrdfs:comment : Suggested value - Work, Instance, Item or Event^^xsd:string</para>
    ///   <para>rdfs:label : Is part of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:stringdcterms:modified : 2021-06-09 (Use with Event also [GH9])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/partOf">bf:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>skos:definition : Pattern of arrangement of materials within a unit.^^xsd:string</para>
    ///   <para>rdfs:label : Arrangement of material^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Modified range [GH77])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/pattern">bf:pattern</a>
    /// </summary>
    let pattern = _prefixId.prefix "pattern"
    /// <summary>
    ///   <para>skos:definition : Relates a work or instance to a phonogram copyright date for a work that is an audio recording^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Phonogram date^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/phonogramDate">bf:phonogramDate</a>
    /// </summary>
    let phonogramDate = _prefixId.prefix "phonogramDate"
    /// <summary>
    ///   <para>skos:definition : Location in the holding agency where the item is shelved or stored.^^xsd:string</para>
    ///   <para>rdfs:label : Storing or shelving location^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/physicalLocation">bf:physicalLocation</a>
    /// </summary>
    let physicalLocation = _prefixId.prefix "physicalLocation"
    /// <summary>
    ///   <para>skos:definition : Geographic location or place entity associated with a resource or element of description, such as the place associated with the publication, printing, distribution, issue, release or production of a resource, place of an event.^^xsd:string</para>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - bf:Place or madsrdf:Geographic^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH19])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/place">bf:place</a>
    /// </summary>
    let place = _prefixId.prefix "place"
    /// <summary>
    ///   <para>skos:definition : Relationship of the colors and tones in an image to the colors and tones of the object reproduced.^^xsd:string</para>
    ///   <para>rdfs:label : Polarity^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/polarity">bf:polarity</a>
    /// </summary>
    let polarity = _prefixId.prefix "polarity"
    /// <summary>
    ///   <para>skos:definition : Resource that precedes the resource being described, e.g., is earlier in time or before in narrative^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Preceded by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/precededBy">bf:precededBy</a>
    /// </summary>
    let precededBy = _prefixId.prefix "precededBy"
    /// <summary>
    ///   <para>skos:definition : Citation to the resource preferred by its custodian of the resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Preferred citation^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/preferredCitation">bf:preferredCitation</a>
    /// </summary>
    let preferredCitation = _prefixId.prefix "preferredCitation"
    /// <summary>
    ///   <para>skos:definition : Process used to produce a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Production method^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/productionMethod">bf:productionMethod</a>
    /// </summary>
    let productionMethod = _prefixId.prefix "productionMethod"
    /// <summary>
    ///   <para>skos:definition : Statement related to the production of the resources; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Production statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-07-10 (New [GH124])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/productionStatement">bf:productionStatement</a>
    /// </summary>
    let productionStatement = _prefixId.prefix "productionStatement"
    /// <summary>
    ///   <para>skos:definition : Method or system used to represent the surface of the earth or of a celestial sphere on a plane.^^xsd:string</para>
    ///   <para>rdfs:label : Cartographic projection^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (changed from data to object property)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/projection">bf:projection</a>
    /// </summary>
    let projection = _prefixId.prefix "projection"
    /// <summary>
    ///   <para>skos:definition : Technical specification relating to the projection of a motion picture film.^^xsd:string</para>
    ///   <para>rdfs:label : Projection characteristic^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (fixed typo in property name)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/projectionCharacteristic">bf:projectionCharacteristic</a>
    /// </summary>
    let projectionCharacteristic = _prefixId.prefix "projectionCharacteristic"
    /// <summary>
    ///   <para>skos:definition : Place, name, and/or date information relating to the publication, printing, distribution, issue, release, production, etc. of a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Provision activity^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (revised label and slightly revised definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/provisionActivity">bf:provisionActivity</a>
    /// </summary>
    let provisionActivity = _prefixId.prefix "provisionActivity"
    /// <summary>
    ///   <para>skos:definition : Statement relating to providers of a resource; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Provider statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/provisionActivityStatement">bf:provisionActivityStatement</a>
    /// </summary>
    let provisionActivityStatement = _prefixId.prefix "provisionActivityStatement"
    /// <summary>
    ///   <para>skos:definition : Relates a resource to a publication frequency resource to capture such details as first issue, last issue, status, etc.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Publication frequency^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH76])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/pubFrequency">bf:pubFrequency</a>
    /// </summary>
    let pubFrequency = _prefixId.prefix "pubFrequency"
    /// <summary>
    ///   <para>skos:definition : Statement related to the publication of the resources; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Publication statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2024-07-10 (New [GH124])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/publicationStatement">bf:publicationStatement</a>
    /// </summary>
    let publicationStatement = _prefixId.prefix "publicationStatement"
    /// <summary>
    ///   <para>skos:definition : Qualifier of information, such as an addition to a title to make it unique or qualifying information associated with an identifier.^^xsd:string</para>
    ///   <para>rdfs:label : Qualifier^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/qualifier">bf:qualifier</a>
    /// </summary>
    let qualifier = _prefixId.prefix "qualifier"
    /// <summary>
    ///   <para>skos:definition : Size of a micro-image in relation to the original from which it was produced.^^xsd:string</para>
    ///   <para>rdfs:label : Reduction ratio^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/reductionRatio">bf:reductionRatio</a>
    /// </summary>
    let reductionRatio = _prefixId.prefix "reductionRatio"
    /// <summary>
    ///   <para>skos:definition : Resource that references the described resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:stringrdfs:comment : Suggested value - Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Referenced by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/referencedBy">bf:referencedBy</a>
    /// </summary>
    let referencedBy = _prefixId.prefix "referencedBy"
    /// <summary>
    ///   <para>skos:definition : Resource that is referenced by the described resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:stringrdfs:comment : Suggested value - Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : References^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/references">bf:references</a>
    /// </summary>
    let references = _prefixId.prefix "references"
    let relatedTo = _prefixId.prefix "relatedTo"
    /// <summary>
    ///   <para>skos:definition : Associated resource and its relationship to the resource being described^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Relation^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-07-10 (New [GH116])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/relation">bf:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>skos:definition : Type of relationship between resources^^xsd:string</para>
    ///   <para>rdfs:label : Relationship^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-07-10 (New [GH116])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/relationship">bf:relationship</a>
    /// </summary>
    let relationship = _prefixId.prefix "relationship"
    /// <summary>
    ///   <para>skos:definition : Relief term specified on a cartographic resource^^xsd:string</para>
    ///   <para>rdfs:label : Relief^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-11-30 (New [GH104])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/relief">bf:relief</a>
    /// </summary>
    let relief = _prefixId.prefix "relief"
    /// <summary>
    ///   <para>skos:definition : Later resource used in place of an earlier resource, usually because the later resource contains updated or new information^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Replaced by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2022-10-03 (corrected label [GH85])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/replacedBy">bf:replacedBy</a>
    /// </summary>
    let replacedBy = _prefixId.prefix "replacedBy"
    /// <summary>
    ///   <para>skos:definition : Earlier resource whose content has been replaced by a later resource, usually because the later resource contains updated or new information^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Replacement of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2022-10-03 (corrected label [GH85])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/replacementOf">bf:replacementOf</a>
    /// </summary>
    let replacementOf = _prefixId.prefix "replacementOf"
    /// <summary>
    ///   <para>skos:definition : Resource that is a reproduction of another Resource^^xsd:string</para>
    ///   <para>rdfs:label : Reproduction of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/reproductionOf">bf:reproductionOf</a>
    /// </summary>
    let reproductionOf = _prefixId.prefix "reproductionOf"
    /// <summary>
    ///   <para>skos:definition : Statement relating to any persons, families, or corporate bodies responsible for the creation of, or contributing to the content of a resource; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Creative responsibility statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/responsibilityStatement">bf:responsibilityStatement</a>
    /// </summary>
    let responsibilityStatement = _prefixId.prefix "responsibilityStatement"
    /// <summary>
    ///   <para>skos:definition : Review of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Review content^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/review">bf:review</a>
    /// </summary>
    let review = _prefixId.prefix "review"
    /// <summary>
    ///   <para>skos:definition : Function provided by a contributor, e.g., author, illustrator, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Contributor role^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (Changed from data to object property, adjusted label and definition)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/role">bf:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>skos:definition : Ratio of the dimensions of a form contained or embodied in a resource to the dimensions of the entity it represents, e.g., for images or cartographic resources.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Scale^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-03 (changed from data to object property)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/scale">bf:scale</a>
    /// </summary>
    let scale = _prefixId.prefix "scale"
    /// <summary>
    ///   <para>skos:definition : Designates whether the classification number is from the standard or optional part of a schedule or table.^^xsd:string</para>
    ///   <para>rdfs:label : Classification designation^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/schedulePart">bf:schedulePart</a>
    /// </summary>
    let schedulePart = _prefixId.prefix "schedulePart"
    /// <summary>
    ///   <para>skos:definition : Resource that spun off a part of its content to form a new resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Separated from^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/separatedFrom">bf:separatedFrom</a>
    /// </summary>
    let separatedFrom = _prefixId.prefix "separatedFrom"
    /// <summary>
    ///   <para>skos:definition : Series enumeration of the resource; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Series enumeration^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2024-07-10 (changed domain [GH100])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/seriesEnumeration">bf:seriesEnumeration</a>
    /// </summary>
    let seriesEnumeration = _prefixId.prefix "seriesEnumeration"
    /// <summary>
    ///   <para>skos:definition : Relation between a larger resource and the resources it encompasses, forming a series, the title of the larger resource appears on the parts^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Series container of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2024-07-10 (updated definition [GF106])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/seriesOf">bf:seriesOf</a>
    /// </summary>
    let seriesOf = _prefixId.prefix "seriesOf"
    /// <summary>
    ///   <para>skos:definition : Statement of the series the resource is in; usually transcribed; includes the ISSN if applicable.^^xsd:string</para>
    ///   <para>rdfs:label : Series statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/seriesStatement">bf:seriesStatement</a>
    /// </summary>
    let seriesStatement = _prefixId.prefix "seriesStatement"
    /// <summary>
    ///   <para>skos:definition : Piece identifier, such as a call or other type of number.^^xsd:string</para>
    ///   <para>rdfs:label : Shelf mark^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/shelfMark">bf:shelfMark</a>
    /// </summary>
    let shelfMark = _prefixId.prefix "shelfMark"
    /// <summary>
    ///   <para>skos:definition : Technical specification relating to the encoding of sound in a resource.^^xsd:string</para>
    ///   <para>rdfs:label : Sound characteristic^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-21 (fixed name and range typos)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/soundCharacteristic">bf:soundCharacteristic</a>
    /// </summary>
    let soundCharacteristic = _prefixId.prefix "soundCharacteristic"
    /// <summary>
    ///   <para>skos:definition : Indication of whether the production of sound is an integral part of the resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Sound content^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/soundContent">bf:soundContent</a>
    /// </summary>
    let soundContent = _prefixId.prefix "soundContent"
    /// <summary>
    ///   <para>skos:definition : Resource from which value or label came or was derived, such as the formal source/scheme from which a classification number is taken or derived, list from which an agent name is taken or derived, source within which an identifier is unique.^^xsd:string</para>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened range [GH63])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:stringdcterms:modified : 2025-07-09 (Expected value fix [GH132])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/source">bf:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>skos:definition : Ending number of classification number span.^^xsd:string</para>
    ///   <para>rdfs:label : Classification number span end^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/spanEnd">bf:spanEnd</a>
    /// </summary>
    let spanEnd = _prefixId.prefix "spanEnd"
    /// <summary>
    ///   <para>skos:definition : One of two or more resources resulting from the division of an earlier resource into separate resources^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Split into^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/splitInto">bf:splitInto</a>
    /// </summary>
    let splitInto = _prefixId.prefix "splitInto"
    /// <summary>
    ///   <para>skos:definition : Designation of the validity or position of something, such as indication that the classification number is canceled or invalid, circulation availability of an item, indication of whether the identifier is canceled or invalid.^^xsd:string</para>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/status">bf:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>skos:definition : Subject term(s) describing a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance, Item or Event^^xsd:stringrdfs:comment : Suggested value - bf:Agent or bf:Topic or bf:Hub^^xsd:string</para>
    ///   <para>rdfs:label : Subject^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened domain [GH21])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/subject">bf:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>skos:definition : Relates a subject to that which it describes.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With bf:Agent or bf:Topic or bf:Hub^^xsd:stringrdfs:comment : Suggested value - Work, Instance, Item or Event^^xsd:string</para>
    ///   <para>rdfs:label : Subject of^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH20])^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/subjectOf">bf:subjectOf</a>
    /// </summary>
    let subjectOf = _prefixId.prefix "subjectOf"
    /// <summary>
    ///   <para>skos:definition : Specific place within the holding entity where the item is located or made available.^^xsd:string</para>
    ///   <para>rdfs:label : Held in sublocation^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/sublocation">bf:sublocation</a>
    /// </summary>
    let sublocation = _prefixId.prefix "sublocation"
    /// <summary>
    ///   <para>skos:definition : Subseries enumeration of the resource; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:label : Subseries enumeration^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/subseriesEnumeration">bf:subseriesEnumeration</a>
    /// </summary>
    let subseriesEnumeration = _prefixId.prefix "subseriesEnumeration"
    /// <summary>
    ///   <para>skos:definition : Relation between a Series resource and the resources it encompasses, forming a Subseries; the Series resource itself has a relation with a larger resource, of which it is a part^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Subseries of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2024-07-10 (updated definition [GF106])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/subseriesOf">bf:subseriesOf</a>
    /// </summary>
    let subseriesOf = _prefixId.prefix "subseriesOf"
    /// <summary>
    ///   <para>skos:definition : Statement of the subseries the resource is in; usually transcribed; includes the ISSN if applicable.^^xsd:string</para>
    ///   <para>rdfs:label : Subseries statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/subseriesStatement">bf:subseriesStatement</a>
    /// </summary>
    let subseriesStatement = _prefixId.prefix "subseriesStatement"
    /// <summary>
    ///   <para>skos:definition : Word, character, or group of words and/or characters that contains the remainder of the title after the main title. Possible title component.^^xsd:string</para>
    ///   <para>rdfs:label : Subtitle^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/subtitle">bf:subtitle</a>
    /// </summary>
    let subtitle = _prefixId.prefix "subtitle"
    /// <summary>
    ///   <para>skos:definition : Resource that succeeds the resource being described, e.g., later in time or after in a narrative^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Succeeded by^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/succeededBy">bf:succeededBy</a>
    /// </summary>
    let succeededBy = _prefixId.prefix "succeededBy"
    /// <summary>
    ///   <para>skos:definition : Summary or abstract of the resource described.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Summary content^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/summary">bf:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>skos:definition : Resource that updates or otherwise complements the predominant resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Supplement^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/supplement">bf:supplement</a>
    /// </summary>
    let supplement = _prefixId.prefix "supplement"
    /// <summary>
    ///   <para>skos:definition : Resource that is updated or otherwise complemented by the augmenting resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Supplement to^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/supplementTo">bf:supplementTo</a>
    /// </summary>
    let supplementTo = _prefixId.prefix "supplementTo"
    /// <summary>
    ///   <para>skos:definition : Material such as an index, bibliography, appendix intended to supplement the primary content of a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Supplementary material^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/supplementaryContent">bf:supplementaryContent</a>
    /// </summary>
    let supplementaryContent = _prefixId.prefix "supplementaryContent"
    /// <summary>
    ///   <para>skos:definition : Equipment or system requirement beyond what is normal and obvious for the type of carrier or type of file, such as make and model of equipment or hardware, operating system, amount of memory, programming language, other necessary software, any plug-ins or peripherals required to play, view, or run the resource, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Equipment or system requirements^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2017-02-06 (Changed from data to object property, changed property name from plural to singular)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/systemRequirement">bf:systemRequirement</a>
    /// </summary>
    let systemRequirement = _prefixId.prefix "systemRequirement"
    /// <summary>
    ///   <para>skos:definition : Number of the table from which the classification number in a subdivision entry is taken, e.g., a DDC table.^^xsd:string</para>
    ///   <para>rdfs:label : Classification table identification^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/table">bf:table</a>
    /// </summary>
    let table = _prefixId.prefix "table"
    /// <summary>
    ///   <para>skos:definition : Table of contents of the described resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Table of contents content^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/tableOfContents">bf:tableOfContents</a>
    /// </summary>
    let tableOfContents = _prefixId.prefix "tableOfContents"
    /// <summary>
    ///   <para>skos:definition : Sequence number or other identifier for an internal classification sub arrangement or add in a classification scheme.^^xsd:string</para>
    ///   <para>rdfs:label : Classification table sequence number^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/tableSeq">bf:tableSeq</a>
    /// </summary>
    let tableSeq = _prefixId.prefix "tableSeq"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a music tempo^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Hub^^xsd:string</para>
    ///   <para>rdfs:label : Tempo^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/tempo">bf:tempo</a>
    /// </summary>
    let tempo = _prefixId.prefix "tempo"
    /// <summary>
    ///   <para>skos:definition : Time period coverage of the content of the resource.^^xsd:string</para>
    ///   <para>rdfs:label : Temporal coverage^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/temporalCoverage">bf:temporalCoverage</a>
    /// </summary>
    let temporalCoverage = _prefixId.prefix "temporalCoverage"
    /// <summary>
    ///   <para>skos:definition : Name given to a resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance, Item or Event^^xsd:string</para>
    ///   <para>rdfs:label : Title resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2021-06-09 (Broadened domain [GH23])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/title">bf:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>skos:definition : Relates a title resource to that which it is the title of.^^xsd:string</para>
    ///   <para>rdfs:label : Title of^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested value - Work, Instance, Item or Event^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-06-09 (New [GH22])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/titleOf">bf:titleOf</a>
    /// </summary>
    let titleOf = _prefixId.prefix "titleOf"
    /// <summary>
    ///   <para>skos:definition : Resource that translates the text of the source entity into a language different from that of the original^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Translation as^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2017-02-03 (corrected subproperty)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/translation">bf:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"
    /// <summary>
    ///   <para>skos:definition : Resource that has been translated, i.e., the text is expressed in a language different from that of the original resource^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work or Instance^^xsd:stringrdfs:comment : Suggested value - Work or Instance^^xsd:string</para>
    ///   <para>rdfs:label : Translation of^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2016-04-29 (added inverse, updated range)^^xsd:stringdcterms:modified : 2017-02-03 (corrected subproperty)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/translationOf">bf:translationOf</a>
    /// </summary>
    let translationOf = _prefixId.prefix "translationOf"
    /// <summary>
    ///   <para>skos:definition : Units in which a value is expressed, such as the physical or logical constituent of a resource (e.g., a volume, audiocassette, film reel, a map, a digital file).^^xsd:string</para>
    ///   <para>rdfs:label : Type of unit^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:stringdcterms:modified : 2025-01-23 (Ontological correction - partially addresses [GH121])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/unit">bf:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    /// <summary>
    ///   <para>skos:definition : General statement of allowances and restrictions on access to a resource, including retention, reproduction, access, and lending.^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested use - With Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Use and access condition^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/usageAndAccessPolicy">bf:usageAndAccessPolicy</a>
    /// </summary>
    let usageAndAccessPolicy = _prefixId.prefix "usageAndAccessPolicy"
    /// <summary>
    ///   <para>skos:definition : The medium of performance used by a contributing agent^^xsd:string</para>
    ///   <para>rdfs:label : Uses medium of performance^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-12-01 (New [GH134])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/usesMediumOfPerformance">bf:usesMediumOfPerformance</a>
    /// </summary>
    let usesMediumOfPerformance = _prefixId.prefix "usesMediumOfPerformance"
    /// <summary>
    ///   <para>skos:definition : The date or date range during which the resource is accurate.^^xsd:string</para>
    ///   <para>rdfs:label : Valid date^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH68])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/validDate">bf:validDate</a>
    /// </summary>
    let validDate = _prefixId.prefix "validDate"
    /// <summary>
    ///   <para>skos:definition : Type of title variation, e.g., acronym, cover, spine, earlier, later, series version.^^xsd:string</para>
    ///   <para>rdfs:label : Variant title type^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/variantType">bf:variantType</a>
    /// </summary>
    let variantType = _prefixId.prefix "variantType"
    /// <summary>
    ///   <para>skos:definition : Term or terms that identify works such as arranged for music, vulgate for religious work, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Version^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/version">bf:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>skos:definition : Technical specification relating to the encoding of video images in a resource^^xsd:string</para>
    ///   <para>rdfs:label : Video characteristic^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/videoCharacteristic">bf:videoCharacteristic</a>
    /// </summary>
    let videoCharacteristic = _prefixId.prefix "videoCharacteristic"
    /// <summary>
    ///   <para>skos:definition : Voice for which a musical work is appropriate, such as soprano, tenor, mixed.^^xsd:string</para>
    ///   <para>rdfs:label : Voice^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/voice">bf:voice</a>
    /// </summary>
    let voice = _prefixId.prefix "voice"
    /// <summary>
    ///   <para>skos:definition : Specific type of voice group, such as chorus, solo.^^xsd:string</para>
    ///   <para>rdfs:label : Type of voice^^xsd:string</para>
    ///   <para>dcterms:modified : 2016-04-21 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bibframe/voiceType">bf:voiceType</a>
    /// </summary>
    let voiceType = _prefixId.prefix "voiceType"
