#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bflc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://id.loc.gov/ontologies/bflc/" "bflc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Applies to^^xsd:string</para>
    ///   <para>skos:definition : The component of a resource to which a characteristic applies.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/AppliesTo">bflc:AppliesTo</a>
    /// </summary>
    let AppliesTo = _prefixId.prefix "AppliesTo"
    /// <summary>
    ///   <para>rdfs:label : Creator characteristic^^xsd:string</para>
    ///   <para>skos:definition : Category to which the creators of the resource belong.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/CreatorCharacteristic">bflc:CreatorCharacteristic</a>
    /// </summary>
    let CreatorCharacteristic = _prefixId.prefix "CreatorCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Demographic group^^xsd:string</para>
    ///   <para>skos:definition : Characteristics of a group of agents.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/DemographicGroup">bflc:DemographicGroup</a>
    /// </summary>
    let DemographicGroup = _prefixId.prefix "DemographicGroup"
    /// <summary>
    ///   <para>rdfs:label : Deprecated^^xsd:string</para>
    ///   <para>skos:definition : The resource has been deprecated^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH6])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/Deprecated">bflc:Deprecated</a>
    /// </summary>
    let Deprecated = _prefixId.prefix "Deprecated"
    /// <summary>
    ///   <para>rdfs:label : Encoding level^^xsd:string</para>
    ///   <para>skos:definition : Designation of the fullness of the bibliographic description.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/EncodingLevel">bflc:EncodingLevel</a>
    /// </summary>
    let EncodingLevel = _prefixId.prefix "EncodingLevel"
    /// <summary>
    ///   <para>rdfs:label : Government Publication Type^^xsd:string</para>
    ///   <para>skos:definition : Information recording that the resource is published or produced by or for an international, national, state, provincial, or local government agency, or by any subdivision of such a body.^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-03-09 (New [GH10])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/GovernmentPubType">bflc:GovernmentPubType</a>
    /// </summary>
    let GovernmentPubType = _prefixId.prefix "GovernmentPubType"
    /// <summary>
    ///   <para>rdfs:label : Groove cutting^^xsd:string</para>
    ///   <para>skos:definition : Kind of cutting of the grooves used on a disc whose sound reproduction process involves a cutting head inscribing a modulated groove into the surface of a rotating cylinder or disc.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-07-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/GrooveCutting">bflc:GrooveCutting</a>
    /// </summary>
    let GrooveCutting = _prefixId.prefix "GrooveCutting"
    /// <summary>
    ///   <para>rdfs:label : Image bit depth^^xsd:string</para>
    ///   <para>skos:definition : The number of bits used to represent each pixel in an image.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/ImageBitDepth">bflc:ImageBitDepth</a>
    /// </summary>
    let ImageBitDepth = _prefixId.prefix "ImageBitDepth"
    /// <summary>
    ///   <para>rdfs:label : Model^^xsd:string</para>
    ///   <para>skos:definition : Model of the computing device on which the resource operates.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/MachineModel">bflc:MachineModel</a>
    /// </summary>
    let MachineModel = _prefixId.prefix "MachineModel"
    /// <summary>
    ///   <para>rdfs:label : Metadata licensor^^xsd:string</para>
    ///   <para>skos:definition : Organization that licenses the intellectual property rights to the data contained in the description.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/MetadataLicensor">bflc:MetadataLicensor</a>
    /// </summary>
    let MetadataLicensor = _prefixId.prefix "MetadataLicensor"
    /// <summary>
    ///   <para>rdfs:label : Moving Image Technique^^xsd:string</para>
    ///   <para>skos:definition : Specifies the technique used in creating motion in motion pictures or videorecordings.^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-02-13 (New [GH9])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/MovingImageTechnique">bflc:MovingImageTechnique</a>
    /// </summary>
    let MovingImageTechnique = _prefixId.prefix "MovingImageTechnique"
    /// <summary>
    ///   <para>rdfs:label : Operating system^^xsd:string</para>
    ///   <para>skos:definition : Software that directly operates a system's hardware and serves as a platform for applications.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/OperatingSystem">bflc:OperatingSystem</a>
    /// </summary>
    let OperatingSystem = _prefixId.prefix "OperatingSystem"
    /// <summary>
    ///   <para>rdfs:label : Primary contribution^^xsd:string</para>
    ///   <para>skos:definition : Contribution for which the agent is the name chosen as the name part of the name and title access point.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:stringdcterms:modified : 2023-11-30 (Added to BF [GH104])^^xsd:stringdcterms:modified : 2024-07-10 (Deprecated [GH21])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/PrimaryContribution">bflc:PrimaryContribution</a>
    /// </summary>
    let PrimaryContribution = _prefixId.prefix "PrimaryContribution"
    /// <summary>
    ///   <para>rdfs:label : Programming language^^xsd:string</para>
    ///   <para>skos:definition : Name of the programming language associated with the data comprising the resource.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/ProgrammingLanguage">bflc:ProgrammingLanguage</a>
    /// </summary>
    let ProgrammingLanguage = _prefixId.prefix "ProgrammingLanguage"
    /// <summary>
    ///   <para>rdfs:label : Relation^^xsd:string</para>
    ///   <para>skos:definition : Connection between resources.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:stringdcterms:modified : 2024-07-10 (Moved to BF [GH22])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/Relation">bflc:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:label : Relationship^^xsd:string</para>
    ///   <para>skos:definition : Resource and its connection to another resource.^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:stringdcterms:modified : 2024-07-10 (Moved to BF [GH22])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/Relationship">bflc:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>rdfs:label : Secondary Instance^^xsd:string</para>
    ///   <para>skos:definition : Instance created when a single MARC record is split into multiple MARC records for conversion to BIBFRAME; used to connect multiple Instance resources to a single Work^^xsd:string</para>
    ///   <para>dcterms:modified : 2023-11-30 (New [GH19])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SecondaryInstance">bflc:SecondaryInstance</a>
    /// </summary>
    let SecondaryInstance = _prefixId.prefix "SecondaryInstance"
    /// <summary>
    ///   <para>rdfs:label : Serial Publication Type^^xsd:string</para>
    ///   <para>skos:definition : Information recording the type of continuing resource.^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-03-18 (New [GH11])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SerialPubType">bflc:SerialPubType</a>
    /// </summary>
    let SerialPubType = _prefixId.prefix "SerialPubType"
    /// <summary>
    ///   <para>rdfs:label : Series analysis^^xsd:string</para>
    ///   <para>skos:definition : A specific organization's analysis practice for a series named in the bf:title field for a work. May also contain the volumes/dates and/or the institution/copy identification to which the practice applies.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SeriesAnalysis">bflc:SeriesAnalysis</a>
    /// </summary>
    let SeriesAnalysis = _prefixId.prefix "SeriesAnalysis"
    /// <summary>
    ///   <para>rdfs:label : Series classification^^xsd:string</para>
    ///   <para>skos:definition : A specific organization's classification practice for a series named in the bf:title field for a work. May also contain the volumes/dates and/or the institution/copy identification to which the practice applies.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SeriesClassification">bflc:SeriesClassification</a>
    /// </summary>
    let SeriesClassification = _prefixId.prefix "SeriesClassification"
    /// <summary>
    ///   <para>rdfs:label : Series numbering^^xsd:string</para>
    ///   <para>skos:definition : Sequential designation or numbering used in the bf:title field for a work.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SeriesNumbering">bflc:SeriesNumbering</a>
    /// </summary>
    let SeriesNumbering = _prefixId.prefix "SeriesNumbering"
    /// <summary>
    ///   <para>rdfs:label : Series numbering peculiarities^^xsd:string</para>
    ///   <para>skos:definition : Listing of irregularities in the report year coverage and/or numbering used in the bf:title field for a work. May also include a citation for the source of information.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SeriesNumberingPeculiarities">bflc:SeriesNumberingPeculiarities</a>
    /// </summary>
    let SeriesNumberingPeculiarities = _prefixId.prefix "SeriesNumberingPeculiarities"
    /// <summary>
    ///   <para>rdfs:label : Series provider^^xsd:string</para>
    ///   <para>skos:definition : Place of publication and the name of the publisher/issuing body used in the bf:title field for a work.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SeriesProvider">bflc:SeriesProvider</a>
    /// </summary>
    let SeriesProvider = _prefixId.prefix "SeriesProvider"
    /// <summary>
    ///   <para>rdfs:label : Series sequential designation^^xsd:string</para>
    ///   <para>skos:definition : Beginning/ending date(s) of publication and/or sequential designations used in the bf:title field for a work. May also include a citation for the source of information.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SeriesSequentialDesignation">bflc:SeriesSequentialDesignation</a>
    /// </summary>
    let SeriesSequentialDesignation = _prefixId.prefix "SeriesSequentialDesignation"
    /// <summary>
    ///   <para>rdfs:label : Series tracing^^xsd:string</para>
    ///   <para>skos:definition : A specific organization's tracing practice for a series named in the bf:title field for a work. May also contain the volumes/dates and/or the institution/copy identification to which the practice applies.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SeriesTracing">bflc:SeriesTracing</a>
    /// </summary>
    let SeriesTracing = _prefixId.prefix "SeriesTracing"
    /// <summary>
    ///   <para>rdfs:label : Series treatment^^xsd:string</para>
    ///   <para>skos:definition : Technical specification relating to the encoding of series data in a resource^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/SeriesTreatment">bflc:SeriesTreatment</a>
    /// </summary>
    let SeriesTreatment = _prefixId.prefix "SeriesTreatment"
    /// <summary>
    ///   <para>rdfs:label : Transliterated title^^xsd:string</para>
    ///   <para>skos:definition : Title transliterated from one script to another.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-07-12 (New)^^xsd:stringdcterms:modified : 2023-11-30 (Added to BF [GH94])^^xsd:stringdcterms:modified : 2024-07-10 (Deprecated [GH21])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/TransliteratedTitle">bflc:TransliteratedTitle</a>
    /// </summary>
    let TransliteratedTitle = _prefixId.prefix "TransliteratedTitle"
    /// <summary>
    ///   <para>rdfs:label : Uncontrolled^^xsd:string</para>
    ///   <para>skos:definition : Component of the resource that is not under authority control^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-11-02 (New [GH15])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/Uncontrolled">bflc:Uncontrolled</a>
    /// </summary>
    let Uncontrolled = _prefixId.prefix "Uncontrolled"
    /// <summary>
    ///   <para>skos:definition : A text string that represents the label of the resource. It could be a name/title combination, but could also include additional fields to make it unique within the catalog.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Authorized access point^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-11-02 (New [GH2])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/aap">bflc:aap</a>
    /// </summary>
    let aap = _prefixId.prefix "aap"
    /// <summary>
    ///   <para>skos:definition : Normalized version of the authorized access point with spaces, capitalization, and punctuation removed.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Normalized authorized access point^^xsd:string</para>
    ///   <para>dcterms:modified : 2021-11-02 (New [GH2])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/aap-normalized">bflc:aap-normalized</a>
    /// </summary>
    let aap_normalized = _prefixId.prefix "aap-normalized"
    /// <summary>
    ///   <para>skos:definition : Institutional location of a resource to which a particular piece of description applies.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Applicable institution^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/applicableInstitution">bflc:applicableInstitution</a>
    /// </summary>
    let applicableInstitution = _prefixId.prefix "applicableInstitution"
    /// <summary>
    ///   <para>skos:definition : The component of a resource to which a characteristic applies.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Applies to^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/appliesTo">bflc:appliesTo</a>
    /// </summary>
    let appliesTo = _prefixId.prefix "appliesTo"
    let ``bf:AdminMetadata`` = _prefixId.prefix "bf:AdminMetadata"
    /// <summary>
    ///   <para>skos:definition : ID of the cataloger who created or edited the description.^^xsd:string</para>
    ///   <para>rdfs:label : Cataloger ID^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-07-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/catalogerId">bflc:catalogerId</a>
    /// </summary>
    let catalogerId = _prefixId.prefix "catalogerId"
    /// <summary>
    ///   <para>skos:definition : A bibliographic reference to a related resource, which may include the specific location within the resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : missingLabel^^xsd:string</para>
    ///   <para>dcterms:modified : 2025-06-30 (New [GH25])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/citation">bflc:citation</a>
    /// </summary>
    let citation = _prefixId.prefix "citation"
    /// <summary>
    ///   <para>skos:definition : Category to which the creators of the resource belong.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Creator characteristic^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/creatorCharacteristic">bflc:creatorCharacteristic</a>
    /// </summary>
    let creatorCharacteristic = _prefixId.prefix "creatorCharacteristic"
    /// <summary>
    ///   <para>skos:definition : Characteristics of a group of agents.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Demographic group^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/demographicGroup">bflc:demographicGroup</a>
    /// </summary>
    let demographicGroup = _prefixId.prefix "demographicGroup"
    /// <summary>
    ///   <para>skos:definition : Statement related to the distribution of the resource; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Distribution statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-04 (New [GH18])^^xsd:stringdcterms:modified : 2024-07-10 (Moved to BF [GH23])^^xsd:stringdcterms:modified : 2025-01-24 (Deprecated [GH24])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/distributionStatement">bflc:distributionStatement</a>
    /// </summary>
    let distributionStatement = _prefixId.prefix "distributionStatement"
    /// <summary>
    ///   <para>skos:definition : Designation of the fullness of the bibliographic description.^^xsd:string</para>
    ///   <para>rdfs:label : Encoding level^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/encodingLevel">bflc:encodingLevel</a>
    /// </summary>
    let encodingLevel = _prefixId.prefix "encodingLevel"
    /// <summary>
    ///   <para>skos:definition : Information recording that the resource is published or produced by or for an international, national, state, provincial, or local government agency, or by any subdivision of such a body.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Government publication type^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-03-09 (New [GH10])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/governmentPubType">bflc:governmentPubType</a>
    /// </summary>
    let governmentPubType = _prefixId.prefix "governmentPubType"
    /// <summary>
    ///   <para>skos:definition : Citation to the resource where the material being described is indexed.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Indexed in^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-07-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/indexedIn">bflc:indexedIn</a>
    /// </summary>
    let indexedIn = _prefixId.prefix "indexedIn"
    /// <summary>
    ///   <para>skos:definition : Statement related to the manufacture of the resource; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Manufacture statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-04 (New [GH18])^^xsd:stringdcterms:modified : 2024-07-10 (Moved to BF [GH23])^^xsd:stringdcterms:modified : 2025-01-24 (Deprecated [GH24])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/manufactureStatement">bflc:manufactureStatement</a>
    /// </summary>
    let manufactureStatement = _prefixId.prefix "manufactureStatement"
    /// <summary>
    ///   <para>skos:definition : String to store MARC data^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : MARC key for headings^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH7])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/marcKey">bflc:marcKey</a>
    /// </summary>
    let marcKey = _prefixId.prefix "marcKey"
    /// <summary>
    ///   <para>skos:definition : Organization that licenses the intellectual property rights to the data contained in the description.^^xsd:string</para>
    ///   <para>rdfs:label : Metadata licensor^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/metadataLicensor">bflc:metadataLicensor</a>
    /// </summary>
    let metadataLicensor = _prefixId.prefix "metadataLicensor"
    /// <summary>
    ///   <para>skos:definition : Information recording the technique used in creating motion in motion pictures or videorecordings.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Moving Image Technique^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-02-13 (New [GH9])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/movingImageTechnique">bflc:movingImageTechnique</a>
    /// </summary>
    let movingImageTechnique = _prefixId.prefix "movingImageTechnique"
    /// <summary>
    ///   <para>skos:definition : Number of characters at the start of a label that should be skipped for indexing and sorting.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Non-sort character count^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-04 (New [GH17])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/nonSortNum">bflc:nonSortNum</a>
    /// </summary>
    let nonSortNum = _prefixId.prefix "nonSortNum"
    /// <summary>
    ///   <para>skos:definition : System-supplied processing information for the BIBFRAME description (e.g. "ibc update").^^xsd:string</para>
    ///   <para>rdfs:label : Processing Info^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-07-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/procInfo">bflc:procInfo</a>
    /// </summary>
    let procInfo = _prefixId.prefix "procInfo"
    /// <summary>
    ///   <para>skos:definition : Statement related to the production of the resource; usually transcribed.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Production statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-04 (New [GH18])^^xsd:stringdcterms:modified : 2024-07-10 (Moved to BF [GH23])^^xsd:stringdcterms:modified : 2025-01-24 (Deprecated [GH24])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/productionStatement">bflc:productionStatement</a>
    /// </summary>
    let productionStatement = _prefixId.prefix "productionStatement"
    /// <summary>
    ///   <para>skos:definition : Name of the BIBFRAME editor profile used to create or edit the description.^^xsd:string</para>
    ///   <para>rdfs:label : LC Editor profile^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-07-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/profile">bflc:profile</a>
    /// </summary>
    let profile = _prefixId.prefix "profile"
    /// <summary>
    ///   <para>skos:definition : Projected date of publication of the resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Projected publication date^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/projectedProvisionDate">bflc:projectedProvisionDate</a>
    /// </summary>
    let projectedProvisionDate = _prefixId.prefix "projectedProvisionDate"
    /// <summary>
    ///   <para>skos:definition : Statement related to the publication of the resource; ususally transcribed.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Publication statement^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-04 (New [GH18])^^xsd:stringdcterms:modified : 2024-07-10 (Moved to BF [GH23])^^xsd:stringdcterms:modified : 2025-01-24 (Deprecated [GH24])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/publicationStatement">bflc:publicationStatement</a>
    /// </summary>
    let publicationStatement = _prefixId.prefix "publicationStatement"
    /// <summary>
    ///   <para>skos:definition : Connection between resources.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Specific relationship^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:stringdcterms:modified : 2024-07-10 (Moved to BF [GH22])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/relation">bflc:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>skos:definition : Resource and its connection to another resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Related resource and relationship^^xsd:string</para>
    ///   <para>dcterms:modified : 2017-02-02 (New)^^xsd:stringdcterms:modified : 2024-07-10 (Moved to BF [GH22])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/relationship">bflc:relationship</a>
    /// </summary>
    let relationship = _prefixId.prefix "relationship"
    /// <summary>
    ///   <para>skos:definition : Information recording the type of continuing resource.^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Serial publication type^^xsd:string</para>
    ///   <para>dcterms:modified : 2020-03-18 (New [GH11])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/serialPubType">bflc:serialPubType</a>
    /// </summary>
    let serialPubType = _prefixId.prefix "serialPubType"
    /// <summary>
    ///   <para>skos:definition : Information concerning the treatment of a series in a resource^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Series treatment^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-10-12 (New)^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/seriesTreatment">bflc:seriesTreatment</a>
    /// </summary>
    let seriesTreatment = _prefixId.prefix "seriesTreatment"
    /// <summary>
    ///   <para>skos:definition : Name of publisher, distributor, manufacturer or producer as transcribed from the resource^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH14])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/simpleAgent">bflc:simpleAgent</a>
    /// </summary>
    let simpleAgent = _prefixId.prefix "simpleAgent"
    /// <summary>
    ///   <para>skos:definition : Date of publication, distribution, manufacture or production as transcribed from the resource^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Date^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH14])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/simpleDate">bflc:simpleDate</a>
    /// </summary>
    let simpleDate = _prefixId.prefix "simpleDate"
    /// <summary>
    ///   <para>skos:definition : Location of publication, distribution, manufacture or production as transcribed from the resource^^xsd:string</para>
    ///   <para>rdfs:comment : Used with Work, Instance or Item^^xsd:string</para>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <para>dcterms:modified : 2022-10-03 (New [GH14])^^xsd:string</para>
    ///   <a href="http://id.loc.gov/ontologies/bflc/simplePlace">bflc:simplePlace</a>
    /// </summary>
    let simplePlace = _prefixId.prefix "simplePlace"
