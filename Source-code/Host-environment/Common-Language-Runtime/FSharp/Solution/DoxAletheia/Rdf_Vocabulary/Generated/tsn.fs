namespace http.purl.org.net.tsn.hash

open DoxAletheia.Rdf_Vocabulary

module tsn =
    let _namespace_name = "http://purl.org/net/tsn#"
    /// <summary>
    /// The Level concept describes a level of observation of the Territory defined within the Nomenclature. Several levels of observation may be defined (e.g., region or district levels)
    /// <see href="http://purl.org/net/tsn#Level"></see></summary>
    let Level = Namespaced_IRI.parse _namespace_name "Level" |> NamespacedName

    /// <summary>
    /// The TSNComponent concept is the super class of any Territorial Statistical Nomenclature components.
    /// <see href="http://purl.org/net/tsn#TSNComponent"></see></summary>
    let TSNComponent =
        Namespaced_IRI.parse _namespace_name "TSNComponent" |> NamespacedName

    /// <summary>
    /// The LevelVersion concept describes a unique representation of a Level, stable for a period of time. This period of time is inherited from the reference period of the NomenclatureVersion the LevelVersion belongs to.
    /// <see href="http://purl.org/net/tsn#LevelVersion"></see></summary>
    let LevelVersion =
        Namespaced_IRI.parse _namespace_name "LevelVersion" |> NamespacedName

    /// <summary>
    /// The TSNFeature concept is the super class of features of a TSN (i.e., a geographic resource). The features of a TSN may be TerritoryVersion, LevelVersion and UnitVersion resources. The TSNFeature concept is a sub class of the geosparql:Feature concept of the OGC Geosparql ontology (please consult http://www.opengis.net/ont/geosparql#Feature for a definition of this concept)
    /// <see href="http://purl.org/net/tsn#TSNFeature"></see></summary>
    let TSNFeature = Namespaced_IRI.parse _namespace_name "TSNFeature" |> NamespacedName
    /// <summary>
    /// The Version concept describes one Version of a TSNComponent, valid for a period of time. A Version resource hold all the attributs of a TSNComponent that may vary, i.e., all attributs except those that hold the identity of the resource (i.e. Identifier of the TSNComponent). The Version concept is closed to the TimeSlice concept of ontologies of fluent.
    /// <see href="http://purl.org/net/tsn#Version"></see></summary>
    let Version = Namespaced_IRI.parse _namespace_name "Version" |> NamespacedName

    /// <summary>
    /// The Nomenclature concept describes an abstract representation of the subdivisions of a territory into Levels and Territorial Units (i.e. also called 'Structure'). A Nomenclature can be seen as a hierarchy of sets of Units with at least one Level. It is designed to answer administrative, electoral and especially statistical needs.
    /// <see href="http://purl.org/net/tsn#Nomenclature"></see></summary>
    let Nomenclature =
        Namespaced_IRI.parse _namespace_name "Nomenclature" |> NamespacedName

    /// <summary>
    /// The NomenclatureVersion concept describes a unique representation of a Nomenclature, stable for a period of time. Stability ensures that statistical data refer to the same territorial units for a certain period of time (source http://ec.europa.eu/eurostat/web/nuts/history) (i.e., the reference period of the NomenclatureVersion).
    /// <see href="http://purl.org/net/tsn#NomenclatureVersion"></see></summary>
    let NomenclatureVersion =
        Namespaced_IRI.parse _namespace_name "NomenclatureVersion" |> NamespacedName

    /// <summary>
    /// The Territory concept describes an abstract representation of a portion of geographic space that is claimed or occupied by a person or group of persons or by an institution (source http://www.oxfordbibliographies.com/view/document/obo-9780199874002/obo-9780199874002-0076.xml). For instance, the European Union is a territory, the Grenoble metropole is a territory, etc.
    /// <see href="http://purl.org/net/tsn#Territory"></see></summary>
    let Territory = Namespaced_IRI.parse _namespace_name "Territory" |> NamespacedName

    /// <summary>
    /// The TerritoryVersion concept describes a unique representation of a Territory at a specified period of time. As the boundaries of a territory may vary (e.g., fusion with another territory), it results succesives versions of it. A territory may have as many versions as it underwent modifications. For instance, the European Union of 27 and the European Union of 28 member states are two versions of the European Union territory.
    /// <see href="http://purl.org/net/tsn#TerritoryVersion"></see></summary>
    let TerritoryVersion =
        Namespaced_IRI.parse _namespace_name "TerritoryVersion" |> NamespacedName

    /// <summary>
    /// The Unit concept describes a piece of geographic space that belongs to one Level of a Nomenclature, and may in turn contain sub-units (or not, if the unit belongs to the lowest level of the nomenclature). Statistical observation are made on Unit.
    /// <see href="http://purl.org/net/tsn#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    /// The UnitVersion concept describes a unique representation of a Unit, stable for a period of time. This period of time is inherited from the reference period of the NomenclatureVersion the UnitVersion belongs to.
    /// <see href="http://purl.org/net/tsn#UnitVersion"></see></summary>
    let UnitVersion =
        Namespaced_IRI.parse _namespace_name "UnitVersion" |> NamespacedName

    /// <summary>
    /// Indicates the LevelVersion the described UnitVersion resource belongs to.
    /// <see href="http://purl.org/net/tsn#belongsToLevel"></see></summary>
    let belongsToLevel =
        Namespaced_IRI.parse _namespace_name "belongsToLevel" |> NamespacedName

    /// <summary>
    /// Indicates a UnitVersion that belongs to the described LevelVersion.
    /// <see href="http://purl.org/net/tsn#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName

    /// <summary>
    /// Indicates the NomenclatureVersion the described LevelVersion resource belongs to.
    /// <see href="http://purl.org/net/tsn#belongsToNomenclatureVersion"></see></summary>
    let belongsToNomenclatureVersion =
        Namespaced_IRI.parse _namespace_name "belongsToNomenclatureVersion" |> NamespacedName

    /// <summary>
    /// Indicates a LevelVersion in the NomenclatureVersion hierarchy.
    /// <see href="http://purl.org/net/tsn#hasLevel"></see></summary>
    let hasLevel = Namespaced_IRI.parse _namespace_name "hasLevel" |> NamespacedName
    /// <summary>
    /// Indicates a TerritoryVersion covered by a NomenclatureVersion i.e., the TerritoryVersion is the spatial applicability of the NomenclatureVersion.
    /// <see href="http://purl.org/net/tsn#covers"></see></summary>
    let covers = Namespaced_IRI.parse _namespace_name "covers" |> NamespacedName

    /// <summary>
    /// Indicates a NomenclatureVersion that covers a TerritoryVersion i.e., the TerritoryVersion is the spatial applicability of the NomenclatureVersion.
    /// <see href="http://purl.org/net/tsn#isCoveredBy"></see></summary>
    let isCoveredBy =
        Namespaced_IRI.parse _namespace_name "isCoveredBy" |> NamespacedName

    /// <summary>
    /// Indicates an Acronym of a TSNComponent (e.g., EU27 is the prefered acronym used to designate the European Union made of 27 members).
    /// <see href="http://purl.org/net/tsn#hasAcronym"></see></summary>
    let hasAcronym = Namespaced_IRI.parse _namespace_name "hasAcronym" |> NamespacedName

    /// <summary>
    /// Indicates a Description of a TSNComponent. It may include but is not limited to: an abstract, a table of contents, a graphical representation, or a free-text account of the TSNComponent.
    /// <see href="http://purl.org/net/tsn#hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// Indicates a Geometry of a spatial resource (i.e., TSNFeature (TerritoryVersion, LevelVersion or UnitVersion) resource)
    /// <see href="http://purl.org/net/tsn#hasGeometry"></see></summary>
    let hasGeometry =
        Namespaced_IRI.parse _namespace_name "hasGeometry" |> NamespacedName

    /// <summary>
    /// Indicates an unambiguous reference to a TSNComponent, throughout the TSN versions. This attribut holds the identity of the TSNComponent i.e., if this identifier changes then the TSNComponent ceases to exist.
    /// <see href="http://purl.org/net/tsn#hasIdentifier"></see></summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    /// Indicates the LevelVersion that is immediately below the described LevelVersion.
    /// <see href="http://purl.org/net/tsn#hasLowerLevel"></see></summary>
    let hasLowerLevel =
        Namespaced_IRI.parse _namespace_name "hasLowerLevel" |> NamespacedName

    /// <summary>
    /// Indicates the LevelVersion that is immediately above the described LevelVersion.
    /// <see href="http://purl.org/net/tsn#hasUpperLevel"></see></summary>
    let hasUpperLevel =
        Namespaced_IRI.parse _namespace_name "hasUpperLevel" |> NamespacedName

    /// <summary>
    /// Indicates the Name of a TSNComponent.
    /// <see href="http://purl.org/net/tsn#hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    /// Indicates a UnitVersion that is contained (spatially or not, as, for instance, an administrative hierarchy may be based on other criteria than spatial criteria) in the described UnitVersion.
    /// <see href="http://purl.org/net/tsn#hasSubUnit"></see></summary>
    let hasSubUnit = Namespaced_IRI.parse _namespace_name "hasSubUnit" |> NamespacedName

    /// <summary>
    /// Indicates the UnitVersion that is immediately above/contains the described UnitVersion.
    /// <see href="http://purl.org/net/tsn#hasSuperUnit"></see></summary>
    let hasSuperUnit =
        Namespaced_IRI.parse _namespace_name "hasSuperUnit" |> NamespacedName

    /// <summary>
    /// Indicates a resource is a Version, edition, or adaptation of the described resource.
    /// <see href="http://purl.org/net/tsn#hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// Indicates a TSNComponent of which the described resource is a version, edition, or adaptation.
    /// <see href="http://purl.org/net/tsn#isVersionOf"></see></summary>
    let isVersionOf =
        Namespaced_IRI.parse _namespace_name "isVersionOf" |> NamespacedName

    /// <summary>
    /// A related resource from which the described resource is derived. Example: European Commission - http://ec.europa.eu/eurostat/ramon/nuts/codelist_en.cfm?list=nuts
    /// <see href="http://purl.org/net/tsn#nomenclatureVersionSource"></see></summary>
    let nomenclatureVersionSource =
        Namespaced_IRI.parse _namespace_name "nomenclatureVersionSource" |> NamespacedName

    /// <summary>
    /// Indicates the period of time (i.e., Interval defined with two point in time &lt;https://www.w3.org/2006/time#hasBeginning&gt; and &lt;https://www.w3.org/2006/time#hasEnd&gt;) to which a Version resource  is stable and considered as the official one.
    /// <see href="http://purl.org/net/tsn#referencePeriod"></see></summary>
    let referencePeriod =
        Namespaced_IRI.parse _namespace_name "referencePeriod" |> NamespacedName

    /// <summary>
    /// Information about rights held in and over the resource. Typically, rights information includes a statement about various property rights associated with the resource, including intellectual property rights.
    /// <see href="http://purl.org/net/tsn#versionRights"></see></summary>
    let versionRights =
        Namespaced_IRI.parse _namespace_name "versionRights" |> NamespacedName
