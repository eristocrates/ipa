namespace http.purl.org.net.tsn.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tsn =
    let _namespace_iri = Namespace_Iri tsn |> NamespaceIRI
    /// <summary>
    ///   <para>tsn:hasSuperUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the UnitVersion that is immediately above/contains the described UnitVersion.</para>
    /// labels<para>hasSuperUnit</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasSuperUnit">http://purl.org/net/tsn#hasSuperUnit</seealso>
    let hasSuperUnit = Prefixed_Name(tsn, "hasSuperUnit") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a resource is a Version, edition, or adaptation of the described resource.</para>
    /// labels<para>hasVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasVersion">http://purl.org/net/tsn#hasVersion</seealso>
    let hasVersion = Prefixed_Name(tsn, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>tsn:Territory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Territory concept describes an abstract representation of a portion of geographic space that is claimed or occupied by a person or group of persons or by an institution (source http://www.oxfordbibliographies.com/view/document/obo-9780199874002/obo-9780199874002-0076.xml). For instance, the European Union is a territory, the Grenoble metropole is a territory, etc.</para>
    /// labels<para>Territory</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#Territory">http://purl.org/net/tsn#Territory</seealso>
    let Territory = Prefixed_Name(tsn, "Territory") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Description of a TSNComponent. It may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the TSNComponent.</para>
    /// labels<para>hasDescription</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasDescription">http://purl.org/net/tsn#hasDescription</seealso>
    let hasDescription = Prefixed_Name(tsn, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>tsn:TSNFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The TSNFeature concept is the super class of features of a TSN (i.e., a geographic resource). The features of a TSN may be TerritoryVersion, LevelVersion and UnitVersion resources. The TSNFeature concept is a sub class of the geosparql:Feature concept of the OGC Geosparql ontology (please consult http://www.opengis.net/ont/geosparql#Feature for a definition of this concept)</para>
    /// labels<para>TSNFeature</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#TSNFeature">http://purl.org/net/tsn#TSNFeature</seealso>
    let TSNFeature = Prefixed_Name(tsn, "TSNFeature") |> PrefixedName
    /// <summary>
    ///   <para>tsn:TerritoryVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The TerritoryVersion concept describes a unique representation of a Territory at a specified period of time. As the boundaries of a territory may vary (e.g., fusion with another territory), it results succesives versions of it. A territory may have as many versions as it underwent modifications. For instance, the European Union of 27 and the European Union of 28 member states are two versions of the European Union territory.</para>
    /// labels<para>TerritoryVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#TerritoryVersion">http://purl.org/net/tsn#TerritoryVersion</seealso>
    let TerritoryVersion = Prefixed_Name(tsn, "TerritoryVersion") |> PrefixedName
    /// <summary>
    ///   <para>tsn:UnitVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The UnitVersion concept describes a unique representation of a Unit, stable for a period of time. This period of time is inherited from the reference period of the NomenclatureVersion the UnitVersion belongs to.</para>
    /// labels<para>UnitVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#UnitVersion">http://purl.org/net/tsn#UnitVersion</seealso>
    let UnitVersion = Prefixed_Name(tsn, "UnitVersion") |> PrefixedName
    /// <summary>
    ///   <para>tsn:Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Version concept describes one Version of a TSNComponent, valid for a period of time. A Version resource hold all the attributs of a TSNComponent that may vary, i.e., all attributs except those that hold the identity of the resource (i.e. Identifier of the TSNComponent). The Version concept is closed to the TimeSlice concept of ontologies of fluent. </para>
    /// labels<para>Version</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#Version">http://purl.org/net/tsn#Version</seealso>
    let Version = Prefixed_Name(tsn, "Version") |> PrefixedName
    /// <summary>
    ///   <para>tsn:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Unit concept describes a piece of geographic space that belongs to one Level of a Nomenclature, and may in turn contain sub-units (or not, if the unit belongs to the lowest level of the nomenclature). Statistical observation are made on Unit.</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#Unit">http://purl.org/net/tsn#Unit</seealso>
    let Unit = Prefixed_Name(tsn, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>tsn:belongsToLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the LevelVersion the described UnitVersion resource belongs to.</para>
    /// labels<para>belongsToLevel</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#belongsToLevel">http://purl.org/net/tsn#belongsToLevel</seealso>
    let belongsToLevel = Prefixed_Name(tsn, "belongsToLevel") |> PrefixedName

    /// <summary>
    ///   <para>tsn:belongsToNomenclatureVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the NomenclatureVersion the described LevelVersion resource belongs to.</para>
    /// labels<para>belongsToNomenclatureVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#belongsToNomenclatureVersion">http://purl.org/net/tsn#belongsToNomenclatureVersion</seealso>
    let belongsToNomenclatureVersion =
        Prefixed_Name(tsn, "belongsToNomenclatureVersion") |> PrefixedName

    /// <summary>
    ///   <para>tsn:hasLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a LevelVersion in the NomenclatureVersion hierarchy.</para>
    /// labels<para>hasLevel</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasLevel">http://purl.org/net/tsn#hasLevel</seealso>
    let hasLevel = Prefixed_Name(tsn, "hasLevel") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an Acronym of a TSNComponent (e.g., EU27 is the prefered acronym used to designate the European Union made of 27 members).</para>
    /// labels<para>hasAcronym</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasAcronym">http://purl.org/net/tsn#hasAcronym</seealso>
    let hasAcronym = Prefixed_Name(tsn, "hasAcronym") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a Geometry of a spatial resource (i.e., TSNFeature (TerritoryVersion, LevelVersion or UnitVersion) resource)</para>
    /// labels<para>hasGeometry</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasGeometry">http://purl.org/net/tsn#hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(tsn, "hasGeometry") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an unambiguous reference to a TSNComponent, throughout the TSN versions. This attribut holds the identity of the TSNComponent i.e., if this identifier changes then the TSNComponent ceases to exist.</para>
    /// labels<para>hasIdentifier</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasIdentifier">http://purl.org/net/tsn#hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(tsn, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the Name of a TSNComponent.</para>
    /// labels<para>hasName</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasName">http://purl.org/net/tsn#hasName</seealso>
    let hasName = Prefixed_Name(tsn, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>tsn:covers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a TerritoryVersion covered by a NomenclatureVersion i.e., the TerritoryVersion is the spatial applicability of the NomenclatureVersion.</para>
    /// labels<para>covers</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#covers">http://purl.org/net/tsn#covers</seealso>
    let covers = Prefixed_Name(tsn, "covers") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a UnitVersion that belongs to the described LevelVersion.</para>
    /// labels<para>hasUnit</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasUnit">http://purl.org/net/tsn#hasUnit</seealso>
    let hasUnit = Prefixed_Name(tsn, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>tsn:isCoveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a NomenclatureVersion that covers a TerritoryVersion i.e., the TerritoryVersion is the spatial applicability of the NomenclatureVersion.</para>
    /// labels<para>isCoveredBy</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#isCoveredBy">http://purl.org/net/tsn#isCoveredBy</seealso>
    let isCoveredBy = Prefixed_Name(tsn, "isCoveredBy") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasLowerLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the LevelVersion that is immediately below the described LevelVersion.</para>
    /// labels<para>hasLowerLevel</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasLowerLevel">http://purl.org/net/tsn#hasLowerLevel</seealso>
    let hasLowerLevel = Prefixed_Name(tsn, "hasLowerLevel") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasSubUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a UnitVersion that is contained (spatially or not, as, for instance, an administrative hierarchy may be based on other criteria than spatial criteria) in the described UnitVersion.</para>
    /// labels<para>hasSubUnit</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasSubUnit">http://purl.org/net/tsn#hasSubUnit</seealso>
    let hasSubUnit = Prefixed_Name(tsn, "hasSubUnit") |> PrefixedName
    /// <summary>
    ///   <para>tsn:hasUpperLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the LevelVersion that is immediately above the described LevelVersion.</para>
    /// labels<para>hasUpperLevel</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#hasUpperLevel">http://purl.org/net/tsn#hasUpperLevel</seealso>
    let hasUpperLevel = Prefixed_Name(tsn, "hasUpperLevel") |> PrefixedName

    /// <summary>
    ///   <para>tsn:nomenclatureVersionSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A related resource from which the described resource is derived. Example: European Commission - http://ec.europa.eu/eurostat/ramon/nuts/codelist_en.cfm?list=nuts</para>
    /// labels<para>nomenclatureVersionSource</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#nomenclatureVersionSource">http://purl.org/net/tsn#nomenclatureVersionSource</seealso>
    let nomenclatureVersionSource =
        Prefixed_Name(tsn, "nomenclatureVersionSource") |> PrefixedName

    /// <summary>
    ///   <para>tsn:versionRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Information about rights held in and over the resource. Typically, rights information includes a statement about various property rights associated with the resource, including intellectual property rights.</para>
    /// labels<para>versionRights</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#versionRights">http://purl.org/net/tsn#versionRights</seealso>
    let versionRights = Prefixed_Name(tsn, "versionRights") |> PrefixedName
    /// <summary>
    ///   <para>tsn:isVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a TSNComponent of which the described resource is a version, edition, or adaptation.</para>
    /// labels<para>isVersionOf</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#isVersionOf">http://purl.org/net/tsn#isVersionOf</seealso>
    let isVersionOf = Prefixed_Name(tsn, "isVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>tsn:referencePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the period of time (i.e., Interval defined with two point in time &lt;https://www.w3.org/2006/time#hasBeginning&gt; and &lt;https://www.w3.org/2006/time#hasEnd&gt;) to which a Version resource  is stable and considered as the official one.</para>
    /// labels<para>referencePeriod</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#referencePeriod">http://purl.org/net/tsn#referencePeriod</seealso>
    let referencePeriod = Prefixed_Name(tsn, "referencePeriod") |> PrefixedName
    /// <summary>
    ///   <para>tsn:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>First version of the vocabulary</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/tsn#">http://purl.org/net/tsn#</seealso>
    let _prefix_iri = Prefixed_Name(tsn, "") |> PrefixedName
    /// <summary>
    ///   <para>tsn:Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Level concept describes a level of observation of the Territory defined within the Nomenclature. Several levels of observation may be defined (e.g., region or district levels)</para>
    /// labels<para>Level</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#Level">http://purl.org/net/tsn#Level</seealso>
    let Level = Prefixed_Name(tsn, "Level") |> PrefixedName
    /// <summary>
    ///   <para>tsn:TSNComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The TSNComponent concept is the super class of any Territorial Statistical Nomenclature components.</para>
    /// labels<para>TSNComponent</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#TSNComponent">http://purl.org/net/tsn#TSNComponent</seealso>
    let TSNComponent = Prefixed_Name(tsn, "TSNComponent") |> PrefixedName
    /// <summary>
    ///   <para>tsn:LevelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The LevelVersion concept describes a unique representation of a Level, stable for a period of time. This period of time is inherited from the reference period of the NomenclatureVersion the LevelVersion belongs to.</para>
    /// labels<para>LevelVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#LevelVersion">http://purl.org/net/tsn#LevelVersion</seealso>
    let LevelVersion = Prefixed_Name(tsn, "LevelVersion") |> PrefixedName
    /// <summary>
    ///   <para>tsn:Nomenclature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Nomenclature concept describes an abstract representation of the subdivisions of a territory into Levels and Territorial Units (i.e. also called 'Structure'). A Nomenclature can be seen as a hierarchy of sets of Units with at least one Level. It is designed to answer administrative, electoral and especially statistical needs. </para>
    /// labels<para>Nomenclature</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#Nomenclature">http://purl.org/net/tsn#Nomenclature</seealso>
    let Nomenclature = Prefixed_Name(tsn, "Nomenclature") |> PrefixedName
    /// <summary>
    ///   <para>tsn:NomenclatureVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The NomenclatureVersion concept describes a unique representation of a Nomenclature, stable for a period of time. Stability ensures that statistical data refer to the same territorial units for a certain period of time (source http://ec.europa.eu/eurostat/web/nuts/history) (i.e., the reference period of the NomenclatureVersion).</para>
    /// labels<para>NomenclatureVersion</para></remarks>
    /// <seealso href="http://purl.org/net/tsn#NomenclatureVersion">http://purl.org/net/tsn#NomenclatureVersion</seealso>
    let NomenclatureVersion = Prefixed_Name(tsn, "NomenclatureVersion") |> PrefixedName
