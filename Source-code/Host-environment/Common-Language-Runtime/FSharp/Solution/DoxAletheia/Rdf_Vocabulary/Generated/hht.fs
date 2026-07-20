namespace https.w3id.org.HHT.hash

open DoxAletheia

module hht =
    let _namespace_name = "https://w3id.org/HHT#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Any marker that could be used as temporal primitive for HHT.
    /// <see href="https://w3id.org/HHT#TemporalPrimitive"></see></summary>
    let TemporalPrimitive = _prefix "TemporalPrimitive"
    /// <summary>
    /// Any object characterised by a geospatial extent.
    /// <see href="https://w3id.org/HHT#Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    /// An area defined as the geometrical complementary of a defined area with regard to another area.
    /// <see href="https://w3id.org/HHT#AreaComplementary"></see></summary>
    let AreaComplementary = _prefix "AreaComplementary"
    /// <summary>
    /// A superclass for all areas that result from a classical set operation.
    /// <see href="https://w3id.org/HHT#SetAreaConstruction"></see></summary>
    let SetAreaConstruction = _prefix "SetAreaConstruction"
    /// <summary>
    /// Geographical area, which is defined by any human division.
    /// <see href="https://w3id.org/HHT#TerritoryVersion"></see></summary>
    let TerritoryVersion = _prefix "TerritoryVersion"
    /// <summary>
    /// Denotes the area to which a AreaComplementary is the complementary.
    /// <see href="https://w3id.org/HHT#complementaryTo"></see></summary>
    let complementaryTo = _prefix "complementaryTo"
    /// <summary>
    /// Denotes the area regarding which the AreaComplementary is supposed to denote.
    /// <see href="https://w3id.org/HHT#complementaryWithRegardOf"></see></summary>
    let complementaryWithRegardOf = _prefix "complementaryWithRegardOf"
    /// <summary>
    /// An area resulting from the geometrical intersection of two areas.
    /// <see href="https://w3id.org/HHT#AreaIntersection"></see></summary>
    let AreaIntersection = _prefix "AreaIntersection"
    /// <summary>
    /// Denotes the areas which are taking part into an AreaIntersection.
    /// <see href="https://w3id.org/HHT#intersectionOf"></see></summary>
    let intersectionOf = _prefix "intersectionOf"
    /// <summary>
    /// Denotes the expected number of areas taking part into the operatively created area.
    /// <see href="https://w3id.org/HHT#operatorCardinality"></see></summary>
    let operatorCardinality = _prefix "operatorCardinality"
    /// <summary>
    /// Area resulting from the geometrical union of several areas.
    /// <see href="https://w3id.org/HHT#AreaUnion"></see></summary>
    let AreaUnion = _prefix "AreaUnion"
    /// <summary>
    /// Denotes the areas which are taking part into an AreaUnion.
    /// <see href="https://w3id.org/HHT#unionOf"></see></summary>
    let unionOf = _prefix "unionOf"
    /// <summary>
    /// A set of stableBlockArea that represents a geometry.
    /// <see href="https://w3id.org/HHT#BlockGeometry"></see></summary>
    let BlockGeometry = _prefix "BlockGeometry"
    /// <summary>
    /// A block supposed to exist at all times, that is characterized only by its geometrical extent and has not necessarily any particular meaning other than that.
    /// <see href="https://w3id.org/HHT#stableBlockArea"></see></summary>
    let stableBlockArea = _prefix "stableBlockArea"
    /// <summary>
    /// Denotes the parts of a BlockGeometry.
    /// <see href="https://w3id.org/HHT#hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// Denotes the number of elements of the geometry set described in a BlockGeometry.
    /// <see href="https://w3id.org/HHT#setCardinality"></see></summary>
    let setCardinality = _prefix "setCardinality"
    /// <summary>
    /// An area which is considered to be stable during its whole existence which can be bounded or not. Typically, as they remain stable, their geometry does not depend on time.
    /// <see href="https://w3id.org/HHT#TimeStableArea"></see></summary>
    let TimeStableArea = _prefix "TimeStableArea"
    /// <summary>
    /// This subclass of level allows to define which level(s) will be considered to determine the building blocks of the geometry.
    /// <see href="https://w3id.org/HHT#ElementaryLevel"></see></summary>
    let ElementaryLevel = _prefix "ElementaryLevel"
    /// <summary>
    /// Hierarchical level of a territory.
    /// <see href="https://w3id.org/HHT#Level"></see></summary>
    let Level = _prefix "Level"
    /// <summary>
    /// A Level that is under an ElementaryLevel. Think typically of Buildings if a city is an ElementaryLevel.
    /// <see href="https://w3id.org/HHT#SubElementaryLevel"></see></summary>
    let SubElementaryLevel = _prefix "SubElementaryLevel"
    /// <summary>
    /// This subclass of level version allows to define which level(s) will be considered to determine the building blocks of the geometry.
    /// <see href="https://w3id.org/HHT#ElementaryLevelVersion"></see></summary>
    let ElementaryLevelVersion = _prefix "ElementaryLevelVersion"
    /// <summary>
    /// Links any versionable object to its versions. Classes of the object and its version should be coherent (ex : Unit and UnitVersion)
    /// <see href="https://w3id.org/HHT#hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// Version of a level.
    /// <see href="https://w3id.org/HHT#LevelVersion"></see></summary>
    let LevelVersion = _prefix "LevelVersion"
    /// <summary>
    /// Concept, principle or nomenclature inducing a hierarchical division of territories.
    /// <see href="https://w3id.org/HHT#HierarchicalCriterion"></see></summary>
    let HierarchicalCriterion = _prefix "HierarchicalCriterion"
    /// <summary>
    /// This class describes abstractly historical databases from which IDs can be collected, in order to improve reusability of data.
    /// <see href="https://w3id.org/HHT#IDSource"></see></summary>
    let IDSource = _prefix "IDSource"
    /// <summary>
    /// Denotes the hierarchical Criterion a level version is related to.
    /// <see href="https://w3id.org/HHT#isLevelOf"></see></summary>
    let isLevelOf = _prefix "isLevelOf"
    /// <summary>
    /// Time slice representing a temporary state of an object. It is attached to said object, which bears the identity.
    /// <see href="https://w3id.org/HHT#Version"></see></summary>
    let Version = _prefix "Version"
    /// <summary>
    /// A subclass of Unit to describe Units directly managed by an actor, which often is an institution.
    /// <see href="https://w3id.org/HHT#ManagedUnit"></see></summary>
    let ManagedUnit = _prefix "ManagedUnit"
    /// <summary>
    /// A territory normalized by an Actor, often taking part into a territorial hierarchy. Its state is further described using UnitVersion.
    /// <see href="https://w3id.org/HHT#Unit"></see></summary>
    let Unit = _prefix "Unit"
    /// <summary>
    /// Subtype of UnitVersion that adds the notion of the influence of the actors over it.
    /// <see href="https://w3id.org/HHT#ManagedUnitVersion"></see></summary>
    let ManagedUnitVersion = _prefix "ManagedUnitVersion"
    /// <summary>
    /// Time slice representing the state of a unit during a provided time interval.
    /// It is considered that the state of a unit is not affected by its upper and lower units, so long as it doesn't change its geometry.
    /// <see href="https://w3id.org/HHT#UnitVersion"></see></summary>
    let UnitVersion = _prefix "UnitVersion"
    /// <summary>
    /// Denotes the actor managing a ManagedUnit.
    /// <see href="https://w3id.org/HHT#isManagedBy"></see></summary>
    let isManagedBy = _prefix "isManagedBy"
    /// <summary>
    /// Any Area with an actual extent.
    /// <see href="https://w3id.org/HHT#NonVoidArea"></see></summary>
    let NonVoidArea = _prefix "NonVoidArea"
    /// <summary>
    /// An area whose with no extent, meaning its geometrical extent is null.
    /// <see href="https://w3id.org/HHT#VoidArea"></see></summary>
    let VoidArea = _prefix "VoidArea"
    /// <summary>
    /// Denotes the StableBlockAreas used to describe the geometry.
    /// <see href="https://w3id.org/HHT#hasGeometry"></see></summary>
    let hasGeometry = _prefix "hasGeometry"
    /// <summary>
    /// A SubLevel subclass used for levels below the Elementary levels.
    /// <see href="https://w3id.org/HHT#SubElementaryLevelVersion"></see></summary>
    let SubElementaryLevelVersion = _prefix "SubElementaryLevelVersion"
    /// <summary>
    /// Denotes hierarchical inferiority of a level version to another.
    /// <see href="https://w3id.org/HHT#hasUpperLevel"></see></summary>
    let hasUpperLevel = _prefix "hasUpperLevel"
    /// <summary>
    /// Qualifies geographical areas meaningful to a human population. Typically, an area is considered to be meaningful as soon as it has a designation that falls under one of the following characteristics:
    /// - A proper name, such as Paris or the Everest Mountain.
    /// â€“ An address, such as 417 fifth avenue, New York.
    /// â€“ A defined indexing designation, such as Paris third district.
    /// <see href="https://w3id.org/HHT#Territory"></see></summary>
    let Territory = _prefix "Territory"
    /// <summary>
    /// Denotes the level of an UnitVersion.
    /// <see href="https://w3id.org/HHT#isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    /// Denotes the actor who normalizes the Unit and integrates it in a territorial division.
    /// <see href="https://w3id.org/HHT#isDefinedBy"></see></summary>
    let isDefinedBy = _prefix "isDefinedBy"
    /// <summary>
    /// Denotes the time interval where the state described by a version is valid.
    /// <see href="https://w3id.org/HHT#validityPeriod"></see></summary>
    let validityPeriod = _prefix "validityPeriod"
    /// <summary>
    /// Denotes an interaction with a territory.
    /// <see href="https://w3id.org/HHT#attachedTo"></see></summary>
    let attachedTo = _prefix "attachedTo"
    /// <summary>
    /// Denotes an Actor impacting a territory.
    /// <see href="https://w3id.org/HHT#hasActor"></see></summary>
    let hasActor = _prefix "hasActor"
    /// <summary>
    /// Denotes a version geometrically included inside another unit version.
    /// <see href="https://w3id.org/HHT#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// Denotes the location of a unit version inside another one.
    /// <see href="https://w3id.org/HHT#isLocatedIn"></see></summary>
    let isLocatedIn = _prefix "isLocatedIn"
    /// <summary>
    /// Denotes a contains property that points to an Area resulting from a set Operation.
    /// <see href="https://w3id.org/HHT#operativeContent"></see></summary>
    let operativeContent = _prefix "operativeContent"
    /// <summary>
    /// Denotes the units an actor has normalized.
    /// <see href="https://w3id.org/HHT#defines"></see></summary>
    let defines = _prefix "defines"
    /// <summary>
    /// Denotes the equivalence of levels regarding their rank in the hierarchy they take part in.
    /// <see href="https://w3id.org/HHT#hasEquivalentLevel"></see></summary>
    let hasEquivalentLevel = _prefix "hasEquivalentLevel"
    /// <summary>
    /// Denotes the geometry as a set of stableBlockAreas with a declared cardinality.
    /// <see href="https://w3id.org/HHT#hasSetGeometry"></see></summary>
    let hasSetGeometry = _prefix "hasSetGeometry"
    /// <summary>
    /// Links a Unit to the outerID object representing its ID in another database.
    /// <see href="https://w3id.org/HHT#hasID"></see></summary>
    let hasID = _prefix "hasID"
    /// <summary>
    /// This class is a reification of an ID data field that differs from intern indexation. It is attached to an IDSource which describes the origin of said ID, and an idValue which corresponds to the actual ID.
    /// <see href="https://w3id.org/HHT#outerID"></see></summary>
    let outerID = _prefix "outerID"
    /// <summary>
    /// Denotes the Unit which is attributed an ID from another database.
    /// <see href="https://w3id.org/HHT#isIDOf"></see></summary>
    let isIDOf = _prefix "isIDOf"
    /// <summary>
    /// Denotes that a hierarchy based on Hierarchical Criterion uses a Level version.
    /// <see href="https://w3id.org/HHT#hasLevel"></see></summary>
    let hasLevel = _prefix "hasLevel"
    /// <summary>
    ///   <see href="https://w3id.org/HHT#hasLevelVersion"></see>
    /// </summary>
    let hasLevelVersion = _prefix "hasLevelVersion"
    /// <summary>
    ///   <see href="https://w3id.org/HHT#hasManagedUnitVersion"></see>
    /// </summary>
    let hasManagedUnitVersion = _prefix "hasManagedUnitVersion"
    /// <summary>
    ///   <see href="https://w3id.org/HHT#hasUnitVersion"></see>
    /// </summary>
    let hasUnitVersion = _prefix "hasUnitVersion"
    /// <summary>
    /// Denotes that a Level Version is the level of a Unit Version.
    /// <see href="https://w3id.org/HHT#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// Denotes a Person living in a territory.
    /// <see href="https://w3id.org/HHT#hasResident"></see></summary>
    let hasResident = _prefix "hasResident"
    /// <summary>
    /// Denotes the residence of an actor. It may be its main or secundary residence.
    /// <see href="https://w3id.org/HHT#residesIn"></see></summary>
    let residesIn = _prefix "residesIn"
    /// <summary>
    /// Denotes hierarchical superiority of a level version to another.
    /// <see href="https://w3id.org/HHT#hasSubLevel"></see></summary>
    let hasSubLevel = _prefix "hasSubLevel"
    /// <summary>
    /// Denotes the hierarchical direct lower territory.
    /// <see href="https://w3id.org/HHT#hasSubUnit"></see></summary>
    let hasSubUnit = _prefix "hasSubUnit"
    /// <summary>
    /// Denotes the hierarchical direct upper territory.
    /// <see href="https://w3id.org/HHT#hasUpperUnit"></see></summary>
    let hasUpperUnit = _prefix "hasUpperUnit"
    /// <summary>
    ///   <see href="https://w3id.org/HHT#hasTerritoryVersion"></see>
    /// </summary>
    let hasTerritoryVersion = _prefix "hasTerritoryVersion"
    /// <summary>
    /// An unique ID used inside the ObARDI project to identify objects.
    /// <see href="https://w3id.org/HHT#idObardi"></see></summary>
    let idObardi = _prefix "idObardi"
    /// <summary>
    /// The value of an ID.
    /// <see href="https://w3id.org/HHT#idValue"></see></summary>
    let idValue = _prefix "idValue"
    /// <summary>
    /// A boolean, indicating whether a version is deprecated or not. Without any property regarding deprecation, a version is considered as non-deprecated.
    /// <see href="https://w3id.org/HHT#isDeprecated"></see></summary>
    let isDeprecated = _prefix "isDeprecated"
    /// <summary>
    /// Denotes the source of an outer ID.
    /// <see href="https://w3id.org/HHT#isFrom"></see></summary>
    let isFrom = _prefix "isFrom"
    /// <summary>
    /// Denotes the ManagedUnits which an actor manages.
    /// <see href="https://w3id.org/HHT#manages"></see></summary>
    let manages = _prefix "manages"
    /// <summary>
    /// Denotes a version geometrically strictly included inside another unit version. In most cases, it is equivalent to the contains property, except when a sub territory is coextensive to the subject territory of a triple involving this property, in which case properContains does not apply.
    /// <see href="https://w3id.org/HHT#properContains"></see></summary>
    let properContains = _prefix "properContains"
