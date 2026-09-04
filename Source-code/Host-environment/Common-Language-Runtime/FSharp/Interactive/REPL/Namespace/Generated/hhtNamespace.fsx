#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hht =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/HHT#" "hht"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Area</para>
    ///   <para>rdfs:comment : Any object characterised by a geospatial extent.</para>
    ///   <a href="https://w3id.org/HHT#Area">hht:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:label : AreaComplementary</para>
    ///   <para>rdfs:comment : An area defined as the geometrical complementary of a defined area with regard to another area.</para>
    ///   <a href="https://w3id.org/HHT#AreaComplementary">hht:AreaComplementary</a>
    /// </summary>
    let AreaComplementary = _prefixId.prefix "AreaComplementary"
    /// <summary>
    ///   <para>rdfs:label : AreaIntersection</para>
    ///   <para>rdfs:comment : An area resulting from the geometrical intersection of two areas.</para>
    ///   <a href="https://w3id.org/HHT#AreaIntersection">hht:AreaIntersection</a>
    /// </summary>
    let AreaIntersection = _prefixId.prefix "AreaIntersection"
    /// <summary>
    ///   <para>rdfs:label : AreaUnion</para>
    ///   <para>rdfs:comment : Area resulting from the geometrical union of several areas.</para>
    ///   <a href="https://w3id.org/HHT#AreaUnion">hht:AreaUnion</a>
    /// </summary>
    let AreaUnion = _prefixId.prefix "AreaUnion"
    /// <summary>
    ///   <para>rdfs:label : BlockGeometry</para>
    ///   <para>rdfs:comment : A set of stableBlockArea that represents a geometry.</para>
    ///   <a href="https://w3id.org/HHT#BlockGeometry">hht:BlockGeometry</a>
    /// </summary>
    let BlockGeometry = _prefixId.prefix "BlockGeometry"
    /// <summary>
    ///   <para>rdfs:label : ElementaryLevel^^xsd:string</para>
    ///   <para>rdfs:comment : This subclass of level allows to define which level(s) will be considered to determine the building blocks of the geometry.</para>
    ///   <a href="https://w3id.org/HHT#ElementaryLevel">hht:ElementaryLevel</a>
    /// </summary>
    let ElementaryLevel = _prefixId.prefix "ElementaryLevel"
    /// <summary>
    ///   <para>rdfs:label : ElementaryLevelVersion^^xsd:string</para>
    ///   <para>rdfs:comment : This subclass of level version allows to define which level(s) will be considered to determine the building blocks of the geometry.</para>
    ///   <a href="https://w3id.org/HHT#ElementaryLevelVersion">hht:ElementaryLevelVersion</a>
    /// </summary>
    let ElementaryLevelVersion = _prefixId.prefix "ElementaryLevelVersion"
    /// <summary>
    ///   <para>rdfs:label : HierarchicalCriterion^^xsd:string</para>
    ///   <para>rdfs:comment : Concept, principle or nomenclature inducing a hierarchical division of territories.</para>
    ///   <a href="https://w3id.org/HHT#HierarchicalCriterion">hht:HierarchicalCriterion</a>
    /// </summary>
    let HierarchicalCriterion = _prefixId.prefix "HierarchicalCriterion"
    /// <summary>
    ///   <para>rdfs:label : IDSource^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes abstractly historical databases from which IDs can be collected, in order to improve reusability of data.</para>
    ///   <a href="https://w3id.org/HHT#IDSource">hht:IDSource</a>
    /// </summary>
    let IDSource = _prefixId.prefix "IDSource"
    /// <summary>
    ///   <para>rdfs:label : Level^^xsd:string</para>
    ///   <para>rdfs:comment : Hierarchical level of a territory.</para>
    ///   <a href="https://w3id.org/HHT#Level">hht:Level</a>
    /// </summary>
    let Level = _prefixId.prefix "Level"
    /// <summary>
    ///   <para>rdfs:label : LevelVersion^^xsd:string</para>
    ///   <para>rdfs:comment : Version of a level.</para>
    ///   <a href="https://w3id.org/HHT#LevelVersion">hht:LevelVersion</a>
    /// </summary>
    let LevelVersion = _prefixId.prefix "LevelVersion"
    /// <summary>
    ///   <para>rdfs:label : ManagedUnit^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of Unit to describe Units directly managed by an actor, which often is an institution.</para>
    ///   <a href="https://w3id.org/HHT#ManagedUnit">hht:ManagedUnit</a>
    /// </summary>
    let ManagedUnit = _prefixId.prefix "ManagedUnit"
    /// <summary>
    ///   <para>rdfs:label : ManagedUnitVersion^^xsd:string</para>
    ///   <para>rdfs:comment : Subtype of UnitVersion that adds the notion of the influence of the actors over it.</para>
    ///   <a href="https://w3id.org/HHT#ManagedUnitVersion">hht:ManagedUnitVersion</a>
    /// </summary>
    let ManagedUnitVersion = _prefixId.prefix "ManagedUnitVersion"
    /// <summary>
    ///   <para>rdfs:label : NonVoidArea</para>
    ///   <para>rdfs:comment : Any Area with an actual extent.</para>
    ///   <a href="https://w3id.org/HHT#NonVoidArea">hht:NonVoidArea</a>
    /// </summary>
    let NonVoidArea = _prefixId.prefix "NonVoidArea"
    /// <summary>
    ///   <para>rdfs:label : SetAreaConstruction</para>
    ///   <para>rdfs:comment : A superclass for all areas that result from a classical set operation.</para>
    ///   <a href="https://w3id.org/HHT#SetAreaConstruction">hht:SetAreaConstruction</a>
    /// </summary>
    let SetAreaConstruction = _prefixId.prefix "SetAreaConstruction"
    /// <summary>
    ///   <para>rdfs:label : SubElementaryLevel</para>
    ///   <para>rdfs:comment : A Level that is under an ElementaryLevel. Think typically of Buildings if a city is an ElementaryLevel.</para>
    ///   <a href="https://w3id.org/HHT#SubElementaryLevel">hht:SubElementaryLevel</a>
    /// </summary>
    let SubElementaryLevel = _prefixId.prefix "SubElementaryLevel"
    /// <summary>
    ///   <para>rdfs:label : SubElementaryLevelVersion</para>
    ///   <para>rdfs:comment : A SubLevel subclass used for levels below the Elementary levels.</para>
    ///   <a href="https://w3id.org/HHT#SubElementaryLevelVersion">hht:SubElementaryLevelVersion</a>
    /// </summary>
    let SubElementaryLevelVersion = _prefixId.prefix "SubElementaryLevelVersion"
    /// <summary>
    ///   <para>rdfs:label : Temporal Primitive</para>
    ///   <para>rdfs:comment : Any marker that could be used as temporal primitive for HHT.</para>
    ///   <a href="https://w3id.org/HHT#TemporalPrimitive">hht:TemporalPrimitive</a>
    /// </summary>
    let TemporalPrimitive = _prefixId.prefix "TemporalPrimitive"
    /// <summary>
    ///   <para>rdfs:label : Territory^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifies geographical areas meaningful to a human population. Typically, an area is considered to be meaningful as soon as it has a designation that falls under one of the following characteristics:
    /// - A proper name, such as Paris or the Everest Mountain.
    /// â€“ An address, such as 417 fifth avenue, New York.
    /// â€“ A defined indexing designation, such as Paris third district.</para>
    ///   <a href="https://w3id.org/HHT#Territory">hht:Territory</a>
    /// </summary>
    let Territory = _prefixId.prefix "Territory"
    /// <summary>
    ///   <para>rdfs:label : TerritoryVersion^^xsd:string</para>
    ///   <para>rdfs:comment : Geographical area, which is defined by any human division.</para>
    ///   <a href="https://w3id.org/HHT#TerritoryVersion">hht:TerritoryVersion</a>
    /// </summary>
    let TerritoryVersion = _prefixId.prefix "TerritoryVersion"
    /// <summary>
    ///   <para>rdfs:label : TimeStableArea</para>
    ///   <para>rdfs:comment : An area which is considered to be stable during its whole existence which can be bounded or not. Typically, as they remain stable, their geometry does not depend on time.</para>
    ///   <a href="https://w3id.org/HHT#TimeStableArea">hht:TimeStableArea</a>
    /// </summary>
    let TimeStableArea = _prefixId.prefix "TimeStableArea"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <para>rdfs:comment : A territory normalized by an Actor, often taking part into a territorial hierarchy. Its state is further described using UnitVersion.</para>
    ///   <a href="https://w3id.org/HHT#Unit">hht:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : UnitVersion^^xsd:string</para>
    ///   <para>rdfs:comment : Time slice representing the state of a unit during a provided time interval.
    /// It is considered that the state of a unit is not affected by its upper and lower units, so long as it doesn't change its geometry.</para>
    ///   <a href="https://w3id.org/HHT#UnitVersion">hht:UnitVersion</a>
    /// </summary>
    let UnitVersion = _prefixId.prefix "UnitVersion"
    /// <summary>
    ///   <para>rdfs:label : Version^^xsd:string</para>
    ///   <para>rdfs:comment : Time slice representing a temporary state of an object. It is attached to said object, which bears the identity.</para>
    ///   <a href="https://w3id.org/HHT#Version">hht:Version</a>
    /// </summary>
    let Version = _prefixId.prefix "Version"
    /// <summary>
    ///   <para>rdfs:label : VoidArea</para>
    ///   <para>rdfs:comment : An area whose with no extent, meaning its geometrical extent is null.</para>
    ///   <a href="https://w3id.org/HHT#VoidArea">hht:VoidArea</a>
    /// </summary>
    let VoidArea = _prefixId.prefix "VoidArea"
    /// <summary>
    ///   <para>rdfs:label : attachedTo^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes an interaction with a territory.</para>
    ///   <a href="https://w3id.org/HHT#attachedTo">hht:attachedTo</a>
    /// </summary>
    let attachedTo = _prefixId.prefix "attachedTo"
    /// <summary>
    ///   <para>rdfs:label : complementaryTo</para>
    ///   <para>rdfs:comment : Denotes the area to which a AreaComplementary is the complementary.</para>
    ///   <a href="https://w3id.org/HHT#complementaryTo">hht:complementaryTo</a>
    /// </summary>
    let complementaryTo = _prefixId.prefix "complementaryTo"
    /// <summary>
    ///   <para>rdfs:label : complementaryWithRegardOf</para>
    ///   <para>rdfs:comment : Denotes the area regarding which the AreaComplementary is supposed to denote.</para>
    ///   <a href="https://w3id.org/HHT#complementaryWithRegardOf">hht:complementaryWithRegardOf</a>
    /// </summary>
    let complementaryWithRegardOf = _prefixId.prefix "complementaryWithRegardOf"
    /// <summary>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a version geometrically included inside another unit version.</para>
    ///   <a href="https://w3id.org/HHT#contains">hht:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : defines^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the units an actor has normalized.</para>
    ///   <a href="https://w3id.org/HHT#defines">hht:defines</a>
    /// </summary>
    let defines = _prefixId.prefix "defines"
    /// <summary>
    ///   <para>rdfs:label : hasActor^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes an Actor impacting a territory.^^xsd:string</para>
    ///   <a href="https://w3id.org/HHT#hasActor">hht:hasActor</a>
    /// </summary>
    let hasActor = _prefixId.prefix "hasActor"
    /// <summary>
    ///   <para>rdfs:label : hasComponent</para>
    ///   <para>rdfs:comment : Denotes the parts of a BlockGeometry.</para>
    ///   <a href="https://w3id.org/HHT#hasComponent">hht:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:label : hasEquivalentLevel^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the equivalence of levels regarding their rank in the hierarchy they take part in.</para>
    ///   <a href="https://w3id.org/HHT#hasEquivalentLevel">hht:hasEquivalentLevel</a>
    /// </summary>
    let hasEquivalentLevel = _prefixId.prefix "hasEquivalentLevel"
    /// <summary>
    ///   <para>rdfs:label : hasGeometry</para>
    ///   <para>rdfs:comment : Denotes the StableBlockAreas used to describe the geometry.</para>
    ///   <a href="https://w3id.org/HHT#hasGeometry">hht:hasGeometry</a>
    /// </summary>
    let hasGeometry = _prefixId.prefix "hasGeometry"
    /// <summary>
    ///   <para>rdfs:label : hasID^^xsd:string</para>
    ///   <para>rdfs:comment : Links a Unit to the outerID object representing its ID in another database.</para>
    ///   <a href="https://w3id.org/HHT#hasID">hht:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:label : hasLevel^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes that a hierarchy based on Hierarchical Criterion uses a Level version.</para>
    ///   <a href="https://w3id.org/HHT#hasLevel">hht:hasLevel</a>
    /// </summary>
    let hasLevel = _prefixId.prefix "hasLevel"
    /// <summary>
    ///   <para>rdfs:label : hasLevelVersion^^xsd:string</para>
    ///   <a href="https://w3id.org/HHT#hasLevelVersion">hht:hasLevelVersion</a>
    /// </summary>
    let hasLevelVersion = _prefixId.prefix "hasLevelVersion"
    /// <summary>
    ///   <para>rdfs:label : hasManagedUnitVersion^^xsd:string</para>
    ///   <a href="https://w3id.org/HHT#hasManagedUnitVersion">hht:hasManagedUnitVersion</a>
    /// </summary>
    let hasManagedUnitVersion = _prefixId.prefix "hasManagedUnitVersion"
    /// <summary>
    ///   <para>rdfs:label : hasMember^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes that a Level Version is the level of a Unit Version.</para>
    ///   <a href="https://w3id.org/HHT#hasMember">hht:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : hasResident^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes a Person living in a territory.</para>
    ///   <a href="https://w3id.org/HHT#hasResident">hht:hasResident</a>
    /// </summary>
    let hasResident = _prefixId.prefix "hasResident"
    /// <summary>
    ///   <para>rdfs:label : hasSetGeometry</para>
    ///   <para>rdfs:comment : Denotes the geometry as a set of stableBlockAreas with a declared cardinality.</para>
    ///   <a href="https://w3id.org/HHT#hasSetGeometry">hht:hasSetGeometry</a>
    /// </summary>
    let hasSetGeometry = _prefixId.prefix "hasSetGeometry"
    /// <summary>
    ///   <para>rdfs:label : hasSubLevel^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes hierarchical superiority of a level version to another.</para>
    ///   <a href="https://w3id.org/HHT#hasSubLevel">hht:hasSubLevel</a>
    /// </summary>
    let hasSubLevel = _prefixId.prefix "hasSubLevel"
    /// <summary>
    ///   <para>rdfs:label : hasSubUnit^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the hierarchical direct lower territory.</para>
    ///   <a href="https://w3id.org/HHT#hasSubUnit">hht:hasSubUnit</a>
    /// </summary>
    let hasSubUnit = _prefixId.prefix "hasSubUnit"
    /// <summary>
    ///   <para>rdfs:label : hasTerritoryVersion^^xsd:string</para>
    ///   <a href="https://w3id.org/HHT#hasTerritoryVersion">hht:hasTerritoryVersion</a>
    /// </summary>
    let hasTerritoryVersion = _prefixId.prefix "hasTerritoryVersion"
    /// <summary>
    ///   <para>rdfs:label : hasUnitVersion^^xsd:string</para>
    ///   <a href="https://w3id.org/HHT#hasUnitVersion">hht:hasUnitVersion</a>
    /// </summary>
    let hasUnitVersion = _prefixId.prefix "hasUnitVersion"
    /// <summary>
    ///   <para>rdfs:label : hasUpperLevel^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes hierarchical inferiority of a level version to another.</para>
    ///   <a href="https://w3id.org/HHT#hasUpperLevel">hht:hasUpperLevel</a>
    /// </summary>
    let hasUpperLevel = _prefixId.prefix "hasUpperLevel"
    /// <summary>
    ///   <para>rdfs:label : hasUpperUnit^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the hierarchical direct upper territory.</para>
    ///   <a href="https://w3id.org/HHT#hasUpperUnit">hht:hasUpperUnit</a>
    /// </summary>
    let hasUpperUnit = _prefixId.prefix "hasUpperUnit"
    /// <summary>
    ///   <para>rdfs:label : hasVersion^^xsd:string</para>
    ///   <para>rdfs:comment : Links any versionable object to its versions. Classes of the object and its version should be coherent (ex : Unit and UnitVersion)</para>
    ///   <a href="https://w3id.org/HHT#hasVersion">hht:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : idObardi^^xsd:string</para>
    ///   <para>rdfs:comment : An unique ID used inside the ObARDI project to identify objects.</para>
    ///   <a href="https://w3id.org/HHT#idObardi">hht:idObardi</a>
    /// </summary>
    let idObardi = _prefixId.prefix "idObardi"
    /// <summary>
    ///   <para>rdfs:label : idValue^^xsd:string</para>
    ///   <para>rdfs:comment : The value of an ID.</para>
    ///   <a href="https://w3id.org/HHT#idValue">hht:idValue</a>
    /// </summary>
    let idValue = _prefixId.prefix "idValue"
    /// <summary>
    ///   <para>rdfs:label : intersectionOf</para>
    ///   <para>rdfs:comment : Denotes the areas which are taking part into an AreaIntersection.</para>
    ///   <a href="https://w3id.org/HHT#intersectionOf">hht:intersectionOf</a>
    /// </summary>
    let intersectionOf = _prefixId.prefix "intersectionOf"
    /// <summary>
    ///   <para>rdfs:label : isDefinedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the actor who normalizes the Unit and integrates it in a territorial division.</para>
    ///   <a href="https://w3id.org/HHT#isDefinedBy">hht:isDefinedBy</a>
    /// </summary>
    let isDefinedBy = _prefixId.prefix "isDefinedBy"
    /// <summary>
    ///   <para>rdfs:label : is deprecated</para>
    ///   <para>rdfs:comment : A boolean, indicating whether a version is deprecated or not. Without any property regarding deprecation, a version is considered as non-deprecated.</para>
    ///   <a href="https://w3id.org/HHT#isDeprecated">hht:isDeprecated</a>
    /// </summary>
    let isDeprecated = _prefixId.prefix "isDeprecated"
    /// <summary>
    ///   <para>rdfs:label : isFrom^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the source of an outer ID.</para>
    ///   <a href="https://w3id.org/HHT#isFrom">hht:isFrom</a>
    /// </summary>
    let isFrom = _prefixId.prefix "isFrom"
    /// <summary>
    ///   <para>rdfs:label : isIDOf^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the Unit which is attributed an ID from another database.</para>
    ///   <a href="https://w3id.org/HHT#isIDOf">hht:isIDOf</a>
    /// </summary>
    let isIDOf = _prefixId.prefix "isIDOf"
    /// <summary>
    ///   <para>rdfs:label : isLevelOf^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the hierarchical Criterion a level version is related to.</para>
    ///   <a href="https://w3id.org/HHT#isLevelOf">hht:isLevelOf</a>
    /// </summary>
    let isLevelOf = _prefixId.prefix "isLevelOf"
    /// <summary>
    ///   <para>rdfs:label : isLocatedIn^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the location of a unit version inside another one.</para>
    ///   <a href="https://w3id.org/HHT#isLocatedIn">hht:isLocatedIn</a>
    /// </summary>
    let isLocatedIn = _prefixId.prefix "isLocatedIn"
    /// <summary>
    ///   <para>rdfs:label : isManagedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the actor managing a ManagedUnit.</para>
    ///   <a href="https://w3id.org/HHT#isManagedBy">hht:isManagedBy</a>
    /// </summary>
    let isManagedBy = _prefixId.prefix "isManagedBy"
    /// <summary>
    ///   <para>rdfs:label : isMemberOf^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the level of an UnitVersion.</para>
    ///   <a href="https://w3id.org/HHT#isMemberOf">hht:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:label : manages^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the ManagedUnits which an actor manages.</para>
    ///   <a href="https://w3id.org/HHT#manages">hht:manages</a>
    /// </summary>
    let manages = _prefixId.prefix "manages"
    /// <summary>
    ///   <para>rdfs:label : operativeContent</para>
    ///   <para>rdfs:comment : Denotes a contains property that points to an Area resulting from a set Operation.</para>
    ///   <a href="https://w3id.org/HHT#operativeContent">hht:operativeContent</a>
    /// </summary>
    let operativeContent = _prefixId.prefix "operativeContent"
    /// <summary>
    ///   <para>rdfs:label : operatorCardinality</para>
    ///   <para>rdfs:comment : Denotes the expected number of areas taking part into the operatively created area.</para>
    ///   <a href="https://w3id.org/HHT#operatorCardinality">hht:operatorCardinality</a>
    /// </summary>
    let operatorCardinality = _prefixId.prefix "operatorCardinality"
    /// <summary>
    ///   <para>rdfs:label : outerID^^xsd:string</para>
    ///   <para>rdfs:comment : This class is a reification of an ID data field that differs from intern indexation. It is attached to an IDSource which describes the origin of said ID, and an idValue which corresponds to the actual ID.</para>
    ///   <a href="https://w3id.org/HHT#outerID">hht:outerID</a>
    /// </summary>
    let outerID = _prefixId.prefix "outerID"
    /// <summary>
    ///   <para>rdfs:label : properContains</para>
    ///   <para>rdfs:comment : Denotes a version geometrically strictly included inside another unit version. In most cases, it is equivalent to the contains property, except when a sub territory is coextensive to the subject territory of a triple involving this property, in which case properContains does not apply.</para>
    ///   <a href="https://w3id.org/HHT#properContains">hht:properContains</a>
    /// </summary>
    let properContains = _prefixId.prefix "properContains"
    /// <summary>
    ///   <para>rdfs:label : residesIn^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the residence of an actor. It may be its main or secundary residence.</para>
    ///   <a href="https://w3id.org/HHT#residesIn">hht:residesIn</a>
    /// </summary>
    let residesIn = _prefixId.prefix "residesIn"
    /// <summary>
    ///   <para>rdfs:label : setCardinality</para>
    ///   <para>rdfs:comment : Denotes the number of elements of the geometry set described in a BlockGeometry.</para>
    ///   <a href="https://w3id.org/HHT#setCardinality">hht:setCardinality</a>
    /// </summary>
    let setCardinality = _prefixId.prefix "setCardinality"
    /// <summary>
    ///   <para>rdfs:label : stable block area</para>
    ///   <para>rdfs:comment : A block supposed to exist at all times, that is characterized only by its geometrical extent and has not necessarily any particular meaning other than that.</para>
    ///   <a href="https://w3id.org/HHT#stableBlockArea">hht:stableBlockArea</a>
    /// </summary>
    let stableBlockArea = _prefixId.prefix "stableBlockArea"
    /// <summary>
    ///   <para>rdfs:label : unionOf</para>
    ///   <para>rdfs:comment : Denotes the areas which are taking part into an AreaUnion.</para>
    ///   <a href="https://w3id.org/HHT#unionOf">hht:unionOf</a>
    /// </summary>
    let unionOf = _prefixId.prefix "unionOf"
    /// <summary>
    ///   <para>rdfs:label : validityPeriod^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes the time interval where the state described by a version is valid.</para>
    ///   <a href="https://w3id.org/HHT#validityPeriod">hht:validityPeriod</a>
    /// </summary>
    let validityPeriod = _prefixId.prefix "validityPeriod"
