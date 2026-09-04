#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tsn =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/tsn#" "tsn"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Level</para>
    ///   <para>rdfs:comment : The Level concept describes a level of observation of the Territory defined within the Nomenclature. Several levels of observation may be defined (e.g., region or district levels)</para>
    ///   <a href="http://purl.org/net/tsn#Level">tsn:Level</a>
    /// </summary>
    let Level = _prefixId.prefix "Level"
    /// <summary>
    ///   <para>rdfs:label : LevelVersion</para>
    ///   <para>rdfs:comment : The LevelVersion concept describes a unique representation of a Level, stable for a period of time. This period of time is inherited from the reference period of the NomenclatureVersion the LevelVersion belongs to.</para>
    ///   <a href="http://purl.org/net/tsn#LevelVersion">tsn:LevelVersion</a>
    /// </summary>
    let LevelVersion = _prefixId.prefix "LevelVersion"
    /// <summary>
    ///   <para>rdfs:label : Nomenclature</para>
    ///   <para>rdfs:comment : The Nomenclature concept describes an abstract representation of the subdivisions of a territory into Levels and Territorial Units (i.e. also called 'Structure'). A Nomenclature can be seen as a hierarchy of sets of Units with at least one Level. It is designed to answer administrative, electoral and especially statistical needs. </para>
    ///   <a href="http://purl.org/net/tsn#Nomenclature">tsn:Nomenclature</a>
    /// </summary>
    let Nomenclature = _prefixId.prefix "Nomenclature"
    /// <summary>
    ///   <para>rdfs:label : NomenclatureVersion</para>
    ///   <para>rdfs:comment : The NomenclatureVersion concept describes a unique representation of a Nomenclature, stable for a period of time. Stability ensures that statistical data refer to the same territorial units for a certain period of time (source http://ec.europa.eu/eurostat/web/nuts/history) (i.e., the reference period of the NomenclatureVersion).</para>
    ///   <a href="http://purl.org/net/tsn#NomenclatureVersion">tsn:NomenclatureVersion</a>
    /// </summary>
    let NomenclatureVersion = _prefixId.prefix "NomenclatureVersion"
    /// <summary>
    ///   <para>rdfs:label : TSNComponent</para>
    ///   <para>rdfs:comment : The TSNComponent concept is the super class of any Territorial Statistical Nomenclature components.^^xsd:string</para>
    ///   <a href="http://purl.org/net/tsn#TSNComponent">tsn:TSNComponent</a>
    /// </summary>
    let TSNComponent = _prefixId.prefix "TSNComponent"
    /// <summary>
    ///   <para>rdfs:label : TSNFeature</para>
    ///   <para>rdfs:comment : The TSNFeature concept is the super class of features of a TSN (i.e., a geographic resource). The features of a TSN may be TerritoryVersion, LevelVersion and UnitVersion resources. The TSNFeature concept is a sub class of the geosparql:Feature concept of the OGC Geosparql ontology (please consult http://www.opengis.net/ont/geosparql#Feature for a definition of this concept)</para>
    ///   <a href="http://purl.org/net/tsn#TSNFeature">tsn:TSNFeature</a>
    /// </summary>
    let TSNFeature = _prefixId.prefix "TSNFeature"
    /// <summary>
    ///   <para>rdfs:label : Territory</para>
    ///   <para>rdfs:comment : The Territory concept describes an abstract representation of a portion of geographic space that is claimed or occupied by a person or group of persons or by an institution (source http://www.oxfordbibliographies.com/view/document/obo-9780199874002/obo-9780199874002-0076.xml). For instance, the European Union is a territory, the Grenoble metropole is a territory, etc.</para>
    ///   <a href="http://purl.org/net/tsn#Territory">tsn:Territory</a>
    /// </summary>
    let Territory = _prefixId.prefix "Territory"
    /// <summary>
    ///   <para>rdfs:label : TerritoryVersion</para>
    ///   <para>rdfs:comment : The TerritoryVersion concept describes a unique representation of a Territory at a specified period of time. As the boundaries of a territory may vary (e.g., fusion with another territory), it results succesives versions of it. A territory may have as many versions as it underwent modifications. For instance, the European Union of 27 and the European Union of 28 member states are two versions of the European Union territory.</para>
    ///   <a href="http://purl.org/net/tsn#TerritoryVersion">tsn:TerritoryVersion</a>
    /// </summary>
    let TerritoryVersion = _prefixId.prefix "TerritoryVersion"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <para>rdfs:comment : The Unit concept describes a piece of geographic space that belongs to one Level of a Nomenclature, and may in turn contain sub-units (or not, if the unit belongs to the lowest level of the nomenclature). Statistical observation are made on Unit.</para>
    ///   <a href="http://purl.org/net/tsn#Unit">tsn:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : UnitVersion</para>
    ///   <para>rdfs:comment : The UnitVersion concept describes a unique representation of a Unit, stable for a period of time. This period of time is inherited from the reference period of the NomenclatureVersion the UnitVersion belongs to.</para>
    ///   <a href="http://purl.org/net/tsn#UnitVersion">tsn:UnitVersion</a>
    /// </summary>
    let UnitVersion = _prefixId.prefix "UnitVersion"
    /// <summary>
    ///   <para>rdfs:label : Version</para>
    ///   <para>rdfs:comment : The Version concept describes one Version of a TSNComponent, valid for a period of time. A Version resource hold all the attributs of a TSNComponent that may vary, i.e., all attributs except those that hold the identity of the resource (i.e. Identifier of the TSNComponent). The Version concept is closed to the TimeSlice concept of ontologies of fluent. </para>
    ///   <a href="http://purl.org/net/tsn#Version">tsn:Version</a>
    /// </summary>
    let Version = _prefixId.prefix "Version"
    /// <summary>
    ///   <para>rdfs:label : belongsToLevel</para>
    ///   <para>rdfs:comment : Indicates the LevelVersion the described UnitVersion resource belongs to.</para>
    ///   <a href="http://purl.org/net/tsn#belongsToLevel">tsn:belongsToLevel</a>
    /// </summary>
    let belongsToLevel = _prefixId.prefix "belongsToLevel"
    /// <summary>
    ///   <para>rdfs:label : belongsToNomenclatureVersion</para>
    ///   <para>rdfs:comment : Indicates the NomenclatureVersion the described LevelVersion resource belongs to.</para>
    ///   <a href="http://purl.org/net/tsn#belongsToNomenclatureVersion">tsn:belongsToNomenclatureVersion</a>
    /// </summary>
    let belongsToNomenclatureVersion = _prefixId.prefix "belongsToNomenclatureVersion"
    /// <summary>
    ///   <para>rdfs:label : covers</para>
    ///   <para>rdfs:comment : Indicates a TerritoryVersion covered by a NomenclatureVersion i.e., the TerritoryVersion is the spatial applicability of the NomenclatureVersion.</para>
    ///   <a href="http://purl.org/net/tsn#covers">tsn:covers</a>
    /// </summary>
    let covers = _prefixId.prefix "covers"
    /// <summary>
    ///   <para>rdfs:label : hasAcronym</para>
    ///   <para>rdfs:comment : Indicates an Acronym of a TSNComponent (e.g., EU27 is the prefered acronym used to designate the European Union made of 27 members).</para>
    ///   <a href="http://purl.org/net/tsn#hasAcronym">tsn:hasAcronym</a>
    /// </summary>
    let hasAcronym = _prefixId.prefix "hasAcronym"
    /// <summary>
    ///   <para>rdfs:label : hasDescription</para>
    ///   <para>rdfs:comment : Indicates a Description of a TSNComponent. It may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the TSNComponent.</para>
    ///   <a href="http://purl.org/net/tsn#hasDescription">tsn:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : hasGeometry</para>
    ///   <para>rdfs:comment : Indicates a Geometry of a spatial resource (i.e., TSNFeature (TerritoryVersion, LevelVersion or UnitVersion) resource)</para>
    ///   <a href="http://purl.org/net/tsn#hasGeometry">tsn:hasGeometry</a>
    /// </summary>
    let hasGeometry = _prefixId.prefix "hasGeometry"
    /// <summary>
    ///   <para>rdfs:label : hasIdentifier</para>
    ///   <para>rdfs:comment : Indicates an unambiguous reference to a TSNComponent, throughout the TSN versions. This attribut holds the identity of the TSNComponent i.e., if this identifier changes then the TSNComponent ceases to exist.</para>
    ///   <a href="http://purl.org/net/tsn#hasIdentifier">tsn:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>rdfs:label : hasLevel</para>
    ///   <para>rdfs:comment : Indicates a LevelVersion in the NomenclatureVersion hierarchy.</para>
    ///   <a href="http://purl.org/net/tsn#hasLevel">tsn:hasLevel</a>
    /// </summary>
    let hasLevel = _prefixId.prefix "hasLevel"
    /// <summary>
    ///   <para>rdfs:label : hasLowerLevel</para>
    ///   <para>rdfs:comment : Indicates the LevelVersion that is immediately below the described LevelVersion.</para>
    ///   <a href="http://purl.org/net/tsn#hasLowerLevel">tsn:hasLowerLevel</a>
    /// </summary>
    let hasLowerLevel = _prefixId.prefix "hasLowerLevel"
    /// <summary>
    ///   <para>rdfs:label : hasName</para>
    ///   <para>rdfs:comment : Indicates the Name of a TSNComponent.</para>
    ///   <a href="http://purl.org/net/tsn#hasName">tsn:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : hasSubUnit</para>
    ///   <para>rdfs:comment : Indicates a UnitVersion that is contained (spatially or not, as, for instance, an administrative hierarchy may be based on other criteria than spatial criteria) in the described UnitVersion.</para>
    ///   <a href="http://purl.org/net/tsn#hasSubUnit">tsn:hasSubUnit</a>
    /// </summary>
    let hasSubUnit = _prefixId.prefix "hasSubUnit"
    /// <summary>
    ///   <para>rdfs:label : hasSuperUnit</para>
    ///   <para>rdfs:comment : Indicates the UnitVersion that is immediately above/contains the described UnitVersion.</para>
    ///   <a href="http://purl.org/net/tsn#hasSuperUnit">tsn:hasSuperUnit</a>
    /// </summary>
    let hasSuperUnit = _prefixId.prefix "hasSuperUnit"
    /// <summary>
    ///   <para>rdfs:label : hasUnit</para>
    ///   <para>rdfs:comment : Indicates a UnitVersion that belongs to the described LevelVersion.</para>
    ///   <a href="http://purl.org/net/tsn#hasUnit">tsn:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:label : hasUpperLevel</para>
    ///   <para>rdfs:comment : Indicates the LevelVersion that is immediately above the described LevelVersion.</para>
    ///   <a href="http://purl.org/net/tsn#hasUpperLevel">tsn:hasUpperLevel</a>
    /// </summary>
    let hasUpperLevel = _prefixId.prefix "hasUpperLevel"
    /// <summary>
    ///   <para>rdfs:label : hasVersion</para>
    ///   <para>rdfs:comment : Indicates a resource is a Version, edition, or adaptation of the described resource.</para>
    ///   <a href="http://purl.org/net/tsn#hasVersion">tsn:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : isCoveredBy</para>
    ///   <para>rdfs:comment : Indicates a NomenclatureVersion that covers a TerritoryVersion i.e., the TerritoryVersion is the spatial applicability of the NomenclatureVersion.</para>
    ///   <a href="http://purl.org/net/tsn#isCoveredBy">tsn:isCoveredBy</a>
    /// </summary>
    let isCoveredBy = _prefixId.prefix "isCoveredBy"
    /// <summary>
    ///   <para>rdfs:label : isVersionOf</para>
    ///   <para>rdfs:comment : Indicates a TSNComponent of which the described resource is a version, edition, or adaptation.</para>
    ///   <a href="http://purl.org/net/tsn#isVersionOf">tsn:isVersionOf</a>
    /// </summary>
    let isVersionOf = _prefixId.prefix "isVersionOf"
    /// <summary>
    ///   <para>rdfs:label : nomenclatureVersionSource</para>
    ///   <para>rdfs:comment : A related resource from which the described resource is derived. Example: European Commission - http://ec.europa.eu/eurostat/ramon/nuts/codelist_en.cfm?list=nuts</para>
    ///   <a href="http://purl.org/net/tsn#nomenclatureVersionSource">tsn:nomenclatureVersionSource</a>
    /// </summary>
    let nomenclatureVersionSource = _prefixId.prefix "nomenclatureVersionSource"
    /// <summary>
    ///   <para>rdfs:label : referencePeriod</para>
    ///   <para>rdfs:comment : Indicates the period of time (i.e., Interval defined with two point in time &lt;https://www.w3.org/2006/time#hasBeginning&gt; and &lt;https://www.w3.org/2006/time#hasEnd&gt;) to which a Version resource  is stable and considered as the official one.</para>
    ///   <a href="http://purl.org/net/tsn#referencePeriod">tsn:referencePeriod</a>
    /// </summary>
    let referencePeriod = _prefixId.prefix "referencePeriod"
    /// <summary>
    ///   <para>rdfs:label : versionRights</para>
    ///   <para>rdfs:comment : Information about rights held in and over the resource. Typically, rights information includes a statement about various property rights associated with the resource, including intellectual property rights.</para>
    ///   <a href="http://purl.org/net/tsn#versionRights">tsn:versionRights</a>
    /// </summary>
    let versionRights = _prefixId.prefix "versionRights"
