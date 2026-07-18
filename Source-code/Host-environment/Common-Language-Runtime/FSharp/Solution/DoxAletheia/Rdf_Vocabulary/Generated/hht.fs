namespace https.w3id.org.HHT.hash

open DoxAletheia.Rdf_Vocabulary

module hht =
    let _namespace_name = "https://w3id.org/HHT#"

    /// <summary>
    /// Any marker that could be used as temporal primitive for HHT.
    /// <see href="https://w3id.org/HHT#TemporalPrimitive"></see></summary>
    let TemporalPrimitive =
        Namespaced_IRI.parse _namespace_name "TemporalPrimitive" |> NamespacedName

    /// <summary>
    /// Any object characterised by a geospatial extent.
    /// <see href="https://w3id.org/HHT#Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    /// An area defined as the geometrical complementary of a defined area with regard to another area.
    /// <see href="https://w3id.org/HHT#AreaComplementary"></see></summary>
    let AreaComplementary =
        Namespaced_IRI.parse _namespace_name "AreaComplementary" |> NamespacedName

    /// <summary>
    /// A superclass for all areas that result from a classical set operation.
    /// <see href="https://w3id.org/HHT#SetAreaConstruction"></see></summary>
    let SetAreaConstruction =
        Namespaced_IRI.parse _namespace_name "SetAreaConstruction" |> NamespacedName

    /// <summary>
    /// Geographical area, which is defined by any human division.
    /// <see href="https://w3id.org/HHT#TerritoryVersion"></see></summary>
    let TerritoryVersion =
        Namespaced_IRI.parse _namespace_name "TerritoryVersion" |> NamespacedName

    /// <summary>
    /// Denotes the area to which a AreaComplementary is the complementary.
    /// <see href="https://w3id.org/HHT#complementaryTo"></see></summary>
    let complementaryTo =
        Namespaced_IRI.parse _namespace_name "complementaryTo" |> NamespacedName

    /// <summary>
    /// Denotes the area regarding which the AreaComplementary is supposed to denote.
    /// <see href="https://w3id.org/HHT#complementaryWithRegardOf"></see></summary>
    let complementaryWithRegardOf =
        Namespaced_IRI.parse _namespace_name "complementaryWithRegardOf" |> NamespacedName

    /// <summary>
    /// An area resulting from the geometrical intersection of two areas.
    /// <see href="https://w3id.org/HHT#AreaIntersection"></see></summary>
    let AreaIntersection =
        Namespaced_IRI.parse _namespace_name "AreaIntersection" |> NamespacedName

    /// <summary>
    /// Denotes the areas which are taking part into an AreaIntersection.
    /// <see href="https://w3id.org/HHT#intersectionOf"></see></summary>
    let intersectionOf =
        Namespaced_IRI.parse _namespace_name "intersectionOf" |> NamespacedName

    /// <summary>
    /// Denotes the expected number of areas taking part into the operatively created area.
    /// <see href="https://w3id.org/HHT#operatorCardinality"></see></summary>
    let operatorCardinality =
        Namespaced_IRI.parse _namespace_name "operatorCardinality" |> NamespacedName

    /// <summary>
    /// Area resulting from the geometrical union of several areas.
    /// <see href="https://w3id.org/HHT#AreaUnion"></see></summary>
    let AreaUnion = Namespaced_IRI.parse _namespace_name "AreaUnion" |> NamespacedName
    /// <summary>
    /// Denotes the areas which are taking part into an AreaUnion.
    /// <see href="https://w3id.org/HHT#unionOf"></see></summary>
    let unionOf = Namespaced_IRI.parse _namespace_name "unionOf" |> NamespacedName

    /// <summary>
    /// A set of stableBlockArea that represents a geometry.
    /// <see href="https://w3id.org/HHT#BlockGeometry"></see></summary>
    let BlockGeometry =
        Namespaced_IRI.parse _namespace_name "BlockGeometry" |> NamespacedName

    /// <summary>
    /// A block supposed to exist at all times, that is characterized only by its geometrical extent and has not necessarily any particular meaning other than that.
    /// <see href="https://w3id.org/HHT#stableBlockArea"></see></summary>
    let stableBlockArea =
        Namespaced_IRI.parse _namespace_name "stableBlockArea" |> NamespacedName

    /// <summary>
    /// Denotes the parts of a BlockGeometry.
    /// <see href="https://w3id.org/HHT#hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// Denotes the number of elements of the geometry set described in a BlockGeometry.
    /// <see href="https://w3id.org/HHT#setCardinality"></see></summary>
    let setCardinality =
        Namespaced_IRI.parse _namespace_name "setCardinality" |> NamespacedName

    /// <summary>
    /// An area which is considered to be stable during its whole existence which can be bounded or not. Typically, as they remain stable, their geometry does not depend on time.
    /// <see href="https://w3id.org/HHT#TimeStableArea"></see></summary>
    let TimeStableArea =
        Namespaced_IRI.parse _namespace_name "TimeStableArea" |> NamespacedName

    /// <summary>
    /// This subclass of level allows to define which level(s) will be considered to determine the building blocks of the geometry.
    /// <see href="https://w3id.org/HHT#ElementaryLevel"></see></summary>
    let ElementaryLevel =
        Namespaced_IRI.parse _namespace_name "ElementaryLevel" |> NamespacedName

    /// <summary>
    /// Hierarchical level of a territory.
    /// <see href="https://w3id.org/HHT#Level"></see></summary>
    let Level = Namespaced_IRI.parse _namespace_name "Level" |> NamespacedName

    /// <summary>
    /// A Level that is under an ElementaryLevel. Think typically of Buildings if a city is an ElementaryLevel.
    /// <see href="https://w3id.org/HHT#SubElementaryLevel"></see></summary>
    let SubElementaryLevel =
        Namespaced_IRI.parse _namespace_name "SubElementaryLevel" |> NamespacedName

    /// <summary>
    /// This subclass of level version allows to define which level(s) will be considered to determine the building blocks of the geometry.
    /// <see href="https://w3id.org/HHT#ElementaryLevelVersion"></see></summary>
    let ElementaryLevelVersion =
        Namespaced_IRI.parse _namespace_name "ElementaryLevelVersion" |> NamespacedName

    /// <summary>
    /// Links any versionable object to its versions. Classes of the object and its version should be coherent (ex : Unit and UnitVersion)
    /// <see href="https://w3id.org/HHT#hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// Version of a level.
    /// <see href="https://w3id.org/HHT#LevelVersion"></see></summary>
    let LevelVersion =
        Namespaced_IRI.parse _namespace_name "LevelVersion" |> NamespacedName

    /// <summary>
    /// Concept, principle or nomenclature inducing a hierarchical division of territories.
    /// <see href="https://w3id.org/HHT#HierarchicalCriterion"></see></summary>
    let HierarchicalCriterion =
        Namespaced_IRI.parse _namespace_name "HierarchicalCriterion" |> NamespacedName

    /// <summary>
    /// This class describes abstractly historical databases from which IDs can be collected, in order to improve reusability of data.
    /// <see href="https://w3id.org/HHT#IDSource"></see></summary>
    let IDSource = Namespaced_IRI.parse _namespace_name "IDSource" |> NamespacedName
    /// <summary>
    /// Denotes the hierarchical Criterion a level version is related to.
    /// <see href="https://w3id.org/HHT#isLevelOf"></see></summary>
    let isLevelOf = Namespaced_IRI.parse _namespace_name "isLevelOf" |> NamespacedName
    /// <summary>
    /// Time slice representing a temporary state of an object. It is attached to said object, which bears the identity.
    /// <see href="https://w3id.org/HHT#Version"></see></summary>
    let Version = Namespaced_IRI.parse _namespace_name "Version" |> NamespacedName

    /// <summary>
    /// A subclass of Unit to describe Units directly managed by an actor, which often is an institution.
    /// <see href="https://w3id.org/HHT#ManagedUnit"></see></summary>
    let ManagedUnit =
        Namespaced_IRI.parse _namespace_name "ManagedUnit" |> NamespacedName

    /// <summary>
    /// A territory normalized by an Actor, often taking part into a territorial hierarchy. Its state is further described using UnitVersion.
    /// <see href="https://w3id.org/HHT#Unit"></see></summary>
    let Unit = Namespaced_IRI.parse _namespace_name "Unit" |> NamespacedName

    /// <summary>
    /// Subtype of UnitVersion that adds the notion of the influence of the actors over it.
    /// <see href="https://w3id.org/HHT#ManagedUnitVersion"></see></summary>
    let ManagedUnitVersion =
        Namespaced_IRI.parse _namespace_name "ManagedUnitVersion" |> NamespacedName

    /// <summary>
    /// Time slice representing the state of a unit during a provided time interval.
    /// It is considered that the state of a unit is not affected by its upper and lower units, so long as it doesn't change its geometry.
    /// <see href="https://w3id.org/HHT#UnitVersion"></see></summary>
    let UnitVersion =
        Namespaced_IRI.parse _namespace_name "UnitVersion" |> NamespacedName

    /// <summary>
    /// Denotes the actor managing a ManagedUnit.
    /// <see href="https://w3id.org/HHT#isManagedBy"></see></summary>
    let isManagedBy =
        Namespaced_IRI.parse _namespace_name "isManagedBy" |> NamespacedName

    /// <summary>
    /// Any Area with an actual extent.
    /// <see href="https://w3id.org/HHT#NonVoidArea"></see></summary>
    let NonVoidArea =
        Namespaced_IRI.parse _namespace_name "NonVoidArea" |> NamespacedName

    /// <summary>
    /// An area whose with no extent, meaning its geometrical extent is null.
    /// <see href="https://w3id.org/HHT#VoidArea"></see></summary>
    let VoidArea = Namespaced_IRI.parse _namespace_name "VoidArea" |> NamespacedName

    /// <summary>
    /// Denotes the StableBlockAreas used to describe the geometry.
    /// <see href="https://w3id.org/HHT#hasGeometry"></see></summary>
    let hasGeometry =
        Namespaced_IRI.parse _namespace_name "hasGeometry" |> NamespacedName

    /// <summary>
    /// A SubLevel subclass used for levels below the Elementary levels.
    /// <see href="https://w3id.org/HHT#SubElementaryLevelVersion"></see></summary>
    let SubElementaryLevelVersion =
        Namespaced_IRI.parse _namespace_name "SubElementaryLevelVersion" |> NamespacedName

    /// <summary>
    /// Denotes hierarchical inferiority of a level version to another.
    /// <see href="https://w3id.org/HHT#hasUpperLevel"></see></summary>
    let hasUpperLevel =
        Namespaced_IRI.parse _namespace_name "hasUpperLevel" |> NamespacedName

    /// <summary>
    /// Qualifies geographical areas meaningful to a human population. Typically, an area is considered to be meaningful as soon as it has a designation that falls under one of the following characteristics:
    /// - A proper name, such as Paris or the Everest Mountain.
    /// â€“ An address, such as 417 fifth avenue, New York.
    /// â€“ A defined indexing designation, such as Paris third district.
    /// <see href="https://w3id.org/HHT#Territory"></see></summary>
    let Territory = Namespaced_IRI.parse _namespace_name "Territory" |> NamespacedName
    /// <summary>
    /// Denotes the level of an UnitVersion.
    /// <see href="https://w3id.org/HHT#isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    /// Denotes the actor who normalizes the Unit and integrates it in a territorial division.
    /// <see href="https://w3id.org/HHT#isDefinedBy"></see></summary>
    let isDefinedBy =
        Namespaced_IRI.parse _namespace_name "isDefinedBy" |> NamespacedName

    /// <summary>
    /// Denotes the time interval where the state described by a version is valid.
    /// <see href="https://w3id.org/HHT#validityPeriod"></see></summary>
    let validityPeriod =
        Namespaced_IRI.parse _namespace_name "validityPeriod" |> NamespacedName

    /// <summary>
    /// Denotes an interaction with a territory.
    /// <see href="https://w3id.org/HHT#attachedTo"></see></summary>
    let attachedTo = Namespaced_IRI.parse _namespace_name "attachedTo" |> NamespacedName
    /// <summary>
    /// Denotes an Actor impacting a territory.
    /// <see href="https://w3id.org/HHT#hasActor"></see></summary>
    let hasActor = Namespaced_IRI.parse _namespace_name "hasActor" |> NamespacedName
    /// <summary>
    /// Denotes a version geometrically included inside another unit version.
    /// <see href="https://w3id.org/HHT#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// Denotes the location of a unit version inside another one.
    /// <see href="https://w3id.org/HHT#isLocatedIn"></see></summary>
    let isLocatedIn =
        Namespaced_IRI.parse _namespace_name "isLocatedIn" |> NamespacedName

    /// <summary>
    /// Denotes a contains property that points to an Area resulting from a set Operation.
    /// <see href="https://w3id.org/HHT#operativeContent"></see></summary>
    let operativeContent =
        Namespaced_IRI.parse _namespace_name "operativeContent" |> NamespacedName

    /// <summary>
    /// Denotes the units an actor has normalized.
    /// <see href="https://w3id.org/HHT#defines"></see></summary>
    let defines = Namespaced_IRI.parse _namespace_name "defines" |> NamespacedName

    /// <summary>
    /// Denotes the equivalence of levels regarding their rank in the hierarchy they take part in.
    /// <see href="https://w3id.org/HHT#hasEquivalentLevel"></see></summary>
    let hasEquivalentLevel =
        Namespaced_IRI.parse _namespace_name "hasEquivalentLevel" |> NamespacedName

    /// <summary>
    /// Denotes the geometry as a set of stableBlockAreas with a declared cardinality.
    /// <see href="https://w3id.org/HHT#hasSetGeometry"></see></summary>
    let hasSetGeometry =
        Namespaced_IRI.parse _namespace_name "hasSetGeometry" |> NamespacedName

    /// <summary>
    /// Links a Unit to the outerID object representing its ID in another database.
    /// <see href="https://w3id.org/HHT#hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName
    /// <summary>
    /// This class is a reification of an ID data field that differs from intern indexation. It is attached to an IDSource which describes the origin of said ID, and an idValue which corresponds to the actual ID.
    /// <see href="https://w3id.org/HHT#outerID"></see></summary>
    let outerID = Namespaced_IRI.parse _namespace_name "outerID" |> NamespacedName
    /// <summary>
    /// Denotes the Unit which is attributed an ID from another database.
    /// <see href="https://w3id.org/HHT#isIDOf"></see></summary>
    let isIDOf = Namespaced_IRI.parse _namespace_name "isIDOf" |> NamespacedName
    /// <summary>
    /// Denotes that a hierarchy based on Hierarchical Criterion uses a Level version.
    /// <see href="https://w3id.org/HHT#hasLevel"></see></summary>
    let hasLevel = Namespaced_IRI.parse _namespace_name "hasLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/HHT#hasLevelVersion"></see>
    /// </summary>
    let hasLevelVersion =
        Namespaced_IRI.parse _namespace_name "hasLevelVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/HHT#hasManagedUnitVersion"></see>
    /// </summary>
    let hasManagedUnitVersion =
        Namespaced_IRI.parse _namespace_name "hasManagedUnitVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/HHT#hasUnitVersion"></see>
    /// </summary>
    let hasUnitVersion =
        Namespaced_IRI.parse _namespace_name "hasUnitVersion" |> NamespacedName

    /// <summary>
    /// Denotes that a Level Version is the level of a Unit Version.
    /// <see href="https://w3id.org/HHT#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName

    /// <summary>
    /// Denotes a Person living in a territory.
    /// <see href="https://w3id.org/HHT#hasResident"></see></summary>
    let hasResident =
        Namespaced_IRI.parse _namespace_name "hasResident" |> NamespacedName

    /// <summary>
    /// Denotes the residence of an actor. It may be its main or secundary residence.
    /// <see href="https://w3id.org/HHT#residesIn"></see></summary>
    let residesIn = Namespaced_IRI.parse _namespace_name "residesIn" |> NamespacedName

    /// <summary>
    /// Denotes hierarchical superiority of a level version to another.
    /// <see href="https://w3id.org/HHT#hasSubLevel"></see></summary>
    let hasSubLevel =
        Namespaced_IRI.parse _namespace_name "hasSubLevel" |> NamespacedName

    /// <summary>
    /// Denotes the hierarchical direct lower territory.
    /// <see href="https://w3id.org/HHT#hasSubUnit"></see></summary>
    let hasSubUnit = Namespaced_IRI.parse _namespace_name "hasSubUnit" |> NamespacedName

    /// <summary>
    /// Denotes the hierarchical direct upper territory.
    /// <see href="https://w3id.org/HHT#hasUpperUnit"></see></summary>
    let hasUpperUnit =
        Namespaced_IRI.parse _namespace_name "hasUpperUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/HHT#hasTerritoryVersion"></see>
    /// </summary>
    let hasTerritoryVersion =
        Namespaced_IRI.parse _namespace_name "hasTerritoryVersion" |> NamespacedName

    /// <summary>
    /// An unique ID used inside the ObARDI project to identify objects.
    /// <see href="https://w3id.org/HHT#idObardi"></see></summary>
    let idObardi = Namespaced_IRI.parse _namespace_name "idObardi" |> NamespacedName
    /// <summary>
    /// The value of an ID.
    /// <see href="https://w3id.org/HHT#idValue"></see></summary>
    let idValue = Namespaced_IRI.parse _namespace_name "idValue" |> NamespacedName

    /// <summary>
    /// A boolean, indicating whether a version is deprecated or not. Without any property regarding deprecation, a version is considered as non-deprecated.
    /// <see href="https://w3id.org/HHT#isDeprecated"></see></summary>
    let isDeprecated =
        Namespaced_IRI.parse _namespace_name "isDeprecated" |> NamespacedName

    /// <summary>
    /// Denotes the source of an outer ID.
    /// <see href="https://w3id.org/HHT#isFrom"></see></summary>
    let isFrom = Namespaced_IRI.parse _namespace_name "isFrom" |> NamespacedName
    /// <summary>
    /// Denotes the ManagedUnits which an actor manages.
    /// <see href="https://w3id.org/HHT#manages"></see></summary>
    let manages = Namespaced_IRI.parse _namespace_name "manages" |> NamespacedName

    /// <summary>
    /// Denotes a version geometrically strictly included inside another unit version. In most cases, it is equivalent to the contains property, except when a sub territory is coextensive to the subject territory of a triple involving this property, in which case properContains does not apply.
    /// <see href="https://w3id.org/HHT#properContains"></see></summary>
    let properContains =
        Namespaced_IRI.parse _namespace_name "properContains" |> NamespacedName
