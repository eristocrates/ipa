namespace https.w3id.org.HHT.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hht =
    let _namespace_iri = Namespace_Iri hht |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:HHT#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/HHT#">https://w3id.org/HHT#</seealso>
    let _prefix_iri = Prefixed_Name(hht, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any object characterised by a geospatial extent."</para>
    /// labels<para>"Area"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#Area">https://w3id.org/HHT#Area</seealso>
    let Area = Prefixed_Name(hht, "Area") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#AreaComplementary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area defined as the geometrical complementary of a defined area with regard to another area."</para>
    /// labels<para>"AreaComplementary"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#AreaComplementary">https://w3id.org/HHT#AreaComplementary</seealso>
    let AreaComplementary = Prefixed_Name(hht, "AreaComplementary") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#AreaIntersection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"An area resulting from the geometrical intersection of two areas."</para>
    /// labels<para>"AreaIntersection"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#AreaIntersection">https://w3id.org/HHT#AreaIntersection</seealso>
    let AreaIntersection = Prefixed_Name(hht, "AreaIntersection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#AreaUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Area resulting from the geometrical union of several areas."</para>
    /// labels<para>"AreaUnion"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#AreaUnion">https://w3id.org/HHT#AreaUnion</seealso>
    let AreaUnion = Prefixed_Name(hht, "AreaUnion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#BlockGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"A set of stableBlockArea that represents a geometry."</para>
    /// labels<para>"BlockGeometry"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#BlockGeometry">https://w3id.org/HHT#BlockGeometry</seealso>
    let BlockGeometry = Prefixed_Name(hht, "BlockGeometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#ElementaryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This subclass of level allows to define which level(s) will be considered to determine the building blocks of the geometry."</para>
    /// labels<para>"ElementaryLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#ElementaryLevel">https://w3id.org/HHT#ElementaryLevel</seealso>
    let ElementaryLevel = Prefixed_Name(hht, "ElementaryLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#ElementaryLevelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This subclass of level version allows to define which level(s) will be considered to determine the building blocks of the geometry."</para>
    /// labels<para>"ElementaryLevelVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#ElementaryLevelVersion">https://w3id.org/HHT#ElementaryLevelVersion</seealso>
    let ElementaryLevelVersion =
        Prefixed_Name(hht, "ElementaryLevelVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#HierarchicalCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Concept, principle or nomenclature inducing a hierarchical division of territories."</para>
    /// labels<para>"HierarchicalCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#HierarchicalCriterion">https://w3id.org/HHT#HierarchicalCriterion</seealso>
    let HierarchicalCriterion =
        Prefixed_Name(hht, "HierarchicalCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#IDSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes abstractly historical databases from which IDs can be collected, in order to improve reusability of data."</para>
    /// labels<para>"IDSource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#IDSource">https://w3id.org/HHT#IDSource</seealso>
    let IDSource = Prefixed_Name(hht, "IDSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Hierarchical level of a territory."</para>
    /// labels<para>"Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#Level">https://w3id.org/HHT#Level</seealso>
    let Level = Prefixed_Name(hht, "Level") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#LevelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Version of a level."</para>
    /// labels<para>"LevelVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#LevelVersion">https://w3id.org/HHT#LevelVersion</seealso>
    let LevelVersion = Prefixed_Name(hht, "LevelVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#ManagedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subclass of Unit to describe Units directly managed by an actor, which often is an institution."</para>
    /// labels<para>"ManagedUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#ManagedUnit">https://w3id.org/HHT#ManagedUnit</seealso>
    let ManagedUnit = Prefixed_Name(hht, "ManagedUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#ManagedUnitVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Subtype of UnitVersion that adds the notion of the influence of the actors over it."</para>
    /// labels<para>"ManagedUnitVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#ManagedUnitVersion">https://w3id.org/HHT#ManagedUnitVersion</seealso>
    let ManagedUnitVersion = Prefixed_Name(hht, "ManagedUnitVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#NonVoidArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Area with an actual extent."</para>
    /// labels<para>"NonVoidArea"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#NonVoidArea">https://w3id.org/HHT#NonVoidArea</seealso>
    let NonVoidArea = Prefixed_Name(hht, "NonVoidArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#SetAreaConstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A superclass for all areas that result from a classical set operation."</para>
    /// labels<para>"SetAreaConstruction"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#SetAreaConstruction">https://w3id.org/HHT#SetAreaConstruction</seealso>
    let SetAreaConstruction = Prefixed_Name(hht, "SetAreaConstruction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#SubElementaryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Level that is under an ElementaryLevel. Think typically of Buildings if a city is an ElementaryLevel."</para>
    /// labels<para>"SubElementaryLevel"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#SubElementaryLevel">https://w3id.org/HHT#SubElementaryLevel</seealso>
    let SubElementaryLevel = Prefixed_Name(hht, "SubElementaryLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#SubElementaryLevelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A SubLevel subclass used for levels below the Elementary levels."</para>
    /// labels<para>"SubElementaryLevelVersion"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#SubElementaryLevelVersion">https://w3id.org/HHT#SubElementaryLevelVersion</seealso>
    let SubElementaryLevelVersion =
        Prefixed_Name(hht, "SubElementaryLevelVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#TemporalPrimitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any marker that could be used as temporal primitive for HHT."</para>
    /// labels<para>"Temporal Primitive"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#TemporalPrimitive">https://w3id.org/HHT#TemporalPrimitive</seealso>
    let TemporalPrimitive = Prefixed_Name(hht, "TemporalPrimitive") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#Territory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Qualifies geographical areas meaningful to a human population. Typically, an area is considered to be meaningful as soon as it has a designation that falls under one of the following characteristics:
    /// - A proper name, such as Paris or the Everest Mountain.
    /// â€“ An address, such as 417 fifth avenue, New York.
    /// â€“ A defined indexing designation, such as Paris third district."</para>
    /// labels<para>"Territory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#Territory">https://w3id.org/HHT#Territory</seealso>
    let Territory = Prefixed_Name(hht, "Territory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#TerritoryVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Geographical area, which is defined by any human division."</para>
    /// labels<para>"TerritoryVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#TerritoryVersion">https://w3id.org/HHT#TerritoryVersion</seealso>
    let TerritoryVersion = Prefixed_Name(hht, "TerritoryVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#TimeStableArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area which is considered to be stable during its whole existence which can be bounded or not. Typically, as they remain stable, their geometry does not depend on time."</para>
    /// labels<para>"TimeStableArea"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#TimeStableArea">https://w3id.org/HHT#TimeStableArea</seealso>
    let TimeStableArea = Prefixed_Name(hht, "TimeStableArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A territory normalized by an Actor, often taking part into a territorial hierarchy. Its state is further described using UnitVersion."</para>
    /// labels<para>"Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#Unit">https://w3id.org/HHT#Unit</seealso>
    let Unit = Prefixed_Name(hht, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#UnitVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Time slice representing the state of a unit during a provided time interval.
    /// It is considered that the state of a unit is not affected by its upper and lower units, so long as it doesn't change its geometry."</para>
    /// labels<para>"UnitVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#UnitVersion">https://w3id.org/HHT#UnitVersion</seealso>
    let UnitVersion = Prefixed_Name(hht, "UnitVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Time slice representing a temporary state of an object. It is attached to said object, which bears the identity."</para>
    /// labels<para>"Version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#Version">https://w3id.org/HHT#Version</seealso>
    let Version = Prefixed_Name(hht, "Version") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#VoidArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area whose with no extent, meaning its geometrical extent is null."</para>
    /// labels<para>"VoidArea"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#VoidArea">https://w3id.org/HHT#VoidArea</seealso>
    let VoidArea = Prefixed_Name(hht, "VoidArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#attachedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes an interaction with a territory."</para>
    /// labels<para>"attachedTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#attachedTo">https://w3id.org/HHT#attachedTo</seealso>
    let attachedTo = Prefixed_Name(hht, "attachedTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#complementaryTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the area to which a AreaComplementary is the complementary."</para>
    /// labels<para>"complementaryTo"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#complementaryTo">https://w3id.org/HHT#complementaryTo</seealso>
    let complementaryTo = Prefixed_Name(hht, "complementaryTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#complementaryWithRegardOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the area regarding which the AreaComplementary is supposed to denote."</para>
    /// labels<para>"complementaryWithRegardOf"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#complementaryWithRegardOf">https://w3id.org/HHT#complementaryWithRegardOf</seealso>
    let complementaryWithRegardOf =
        Prefixed_Name(hht, "complementaryWithRegardOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Denotes a version geometrically included inside another unit version."</para>
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#contains">https://w3id.org/HHT#contains</seealso>
    let contains = Prefixed_Name(hht, "contains") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the units an actor has normalized."</para>
    /// labels<para>"defines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#defines">https://w3id.org/HHT#defines</seealso>
    let defines = Prefixed_Name(hht, "defines") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes an Actor impacting a territory."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasActor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasActor">https://w3id.org/HHT#hasActor</seealso>
    let hasActor = Prefixed_Name(hht, "hasActor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the parts of a BlockGeometry."</para>
    /// labels<para>"hasComponent"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasComponent">https://w3id.org/HHT#hasComponent</seealso>
    let hasComponent = Prefixed_Name(hht, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasEquivalentLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Denotes the equivalence of levels regarding their rank in the hierarchy they take part in."</para>
    /// labels<para>"hasEquivalentLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasEquivalentLevel">https://w3id.org/HHT#hasEquivalentLevel</seealso>
    let hasEquivalentLevel = Prefixed_Name(hht, "hasEquivalentLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the StableBlockAreas used to describe the geometry."</para>
    /// labels<para>"hasGeometry"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasGeometry">https://w3id.org/HHT#hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(hht, "hasGeometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Unit to the outerID object representing its ID in another database."</para>
    /// labels<para>"hasID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasID">https://w3id.org/HHT#hasID</seealso>
    let hasID = Prefixed_Name(hht, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes that a hierarchy based on Hierarchical Criterion uses a Level version."</para>
    /// labels<para>"hasLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasLevel">https://w3id.org/HHT#hasLevel</seealso>
    let hasLevel = Prefixed_Name(hht, "hasLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasLevelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLevelVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasLevelVersion">https://w3id.org/HHT#hasLevelVersion</seealso>
    let hasLevelVersion = Prefixed_Name(hht, "hasLevelVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#hasManagedUnitVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasManagedUnitVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasManagedUnitVersion">https://w3id.org/HHT#hasManagedUnitVersion</seealso>
    let hasManagedUnitVersion =
        Prefixed_Name(hht, "hasManagedUnitVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:HHT#hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes that a Level Version is the level of a Unit Version."</para>
    /// labels<para>"hasMember"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasMember">https://w3id.org/HHT#hasMember</seealso>
    let hasMember = Prefixed_Name(hht, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasResident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes a Person living in a territory."</para>
    /// labels<para>"hasResident"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasResident">https://w3id.org/HHT#hasResident</seealso>
    let hasResident = Prefixed_Name(hht, "hasResident") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasSetGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Denotes the geometry as a set of stableBlockAreas with a declared cardinality."</para>
    /// labels<para>"hasSetGeometry"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasSetGeometry">https://w3id.org/HHT#hasSetGeometry</seealso>
    let hasSetGeometry = Prefixed_Name(hht, "hasSetGeometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasSubLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes hierarchical superiority of a level version to another."</para>
    /// labels<para>"hasSubLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasSubLevel">https://w3id.org/HHT#hasSubLevel</seealso>
    let hasSubLevel = Prefixed_Name(hht, "hasSubLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasSubUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the hierarchical direct lower territory."</para>
    /// labels<para>"hasSubUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasSubUnit">https://w3id.org/HHT#hasSubUnit</seealso>
    let hasSubUnit = Prefixed_Name(hht, "hasSubUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasTerritoryVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTerritoryVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasTerritoryVersion">https://w3id.org/HHT#hasTerritoryVersion</seealso>
    let hasTerritoryVersion = Prefixed_Name(hht, "hasTerritoryVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasUnitVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasUnitVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasUnitVersion">https://w3id.org/HHT#hasUnitVersion</seealso>
    let hasUnitVersion = Prefixed_Name(hht, "hasUnitVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasUpperLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes hierarchical inferiority of a level version to another."</para>
    /// labels<para>"hasUpperLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasUpperLevel">https://w3id.org/HHT#hasUpperLevel</seealso>
    let hasUpperLevel = Prefixed_Name(hht, "hasUpperLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasUpperUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the hierarchical direct upper territory."</para>
    /// labels<para>"hasUpperUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasUpperUnit">https://w3id.org/HHT#hasUpperUnit</seealso>
    let hasUpperUnit = Prefixed_Name(hht, "hasUpperUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links any versionable object to its versions. Classes of the object and its version should be coherent (ex : Unit and UnitVersion)"</para>
    /// labels<para>"hasVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#hasVersion">https://w3id.org/HHT#hasVersion</seealso>
    let hasVersion = Prefixed_Name(hht, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#idObardi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An unique ID used inside the ObARDI project to identify objects."</para>
    /// labels<para>"idObardi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#idObardi">https://w3id.org/HHT#idObardi</seealso>
    let idObardi = Prefixed_Name(hht, "idObardi") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#idValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The value of an ID."</para>
    /// labels<para>"idValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#idValue">https://w3id.org/HHT#idValue</seealso>
    let idValue = Prefixed_Name(hht, "idValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#intersectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the areas which are taking part into an AreaIntersection."</para>
    /// labels<para>"intersectionOf"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#intersectionOf">https://w3id.org/HHT#intersectionOf</seealso>
    let intersectionOf = Prefixed_Name(hht, "intersectionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the actor who normalizes the Unit and integrates it in a territorial division."</para>
    /// labels<para>"isDefinedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#isDefinedBy">https://w3id.org/HHT#isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(hht, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#isDeprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A boolean, indicating whether a version is deprecated or not. Without any property regarding deprecation, a version is considered as non-deprecated."</para>
    /// labels<para>"is deprecated"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#isDeprecated">https://w3id.org/HHT#isDeprecated</seealso>
    let isDeprecated = Prefixed_Name(hht, "isDeprecated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#isFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the source of an outer ID."</para>
    /// labels<para>"isFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#isFrom">https://w3id.org/HHT#isFrom</seealso>
    let isFrom = Prefixed_Name(hht, "isFrom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#isIDOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the Unit which is attributed an ID from another database."</para>
    /// labels<para>"isIDOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#isIDOf">https://w3id.org/HHT#isIDOf</seealso>
    let isIDOf = Prefixed_Name(hht, "isIDOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#isLevelOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the hierarchical Criterion a level version is related to."</para>
    /// labels<para>"isLevelOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#isLevelOf">https://w3id.org/HHT#isLevelOf</seealso>
    let isLevelOf = Prefixed_Name(hht, "isLevelOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"Denotes the location of a unit version inside another one."</para>
    /// labels<para>"isLocatedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#isLocatedIn">https://w3id.org/HHT#isLocatedIn</seealso>
    let isLocatedIn = Prefixed_Name(hht, "isLocatedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#isManagedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the actor managing a ManagedUnit."</para>
    /// labels<para>"isManagedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#isManagedBy">https://w3id.org/HHT#isManagedBy</seealso>
    let isManagedBy = Prefixed_Name(hht, "isManagedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the level of an UnitVersion."</para>
    /// labels<para>"isMemberOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#isMemberOf">https://w3id.org/HHT#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(hht, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#manages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the ManagedUnits which an actor manages."</para>
    /// labels<para>"manages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#manages">https://w3id.org/HHT#manages</seealso>
    let manages = Prefixed_Name(hht, "manages") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#operativeContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes a contains property that points to an Area resulting from a set Operation."</para>
    /// labels<para>"operativeContent"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#operativeContent">https://w3id.org/HHT#operativeContent</seealso>
    let operativeContent = Prefixed_Name(hht, "operativeContent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#operatorCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes the expected number of areas taking part into the operatively created area."</para>
    /// labels<para>"operatorCardinality"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#operatorCardinality">https://w3id.org/HHT#operatorCardinality</seealso>
    let operatorCardinality = Prefixed_Name(hht, "operatorCardinality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#outerID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is a reification of an ID data field that differs from intern indexation. It is attached to an IDSource which describes the origin of said ID, and an idValue which corresponds to the actual ID."</para>
    /// labels<para>"outerID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#outerID">https://w3id.org/HHT#outerID</seealso>
    let outerID = Prefixed_Name(hht, "outerID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#properContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes a version geometrically strictly included inside another unit version. In most cases, it is equivalent to the contains property, except when a sub territory is coextensive to the subject territory of a triple involving this property, in which case properContains does not apply."</para>
    /// labels<para>"properContains"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#properContains">https://w3id.org/HHT#properContains</seealso>
    let properContains = Prefixed_Name(hht, "properContains") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#residesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the residence of an actor. It may be its main or secundary residence."</para>
    /// labels<para>"residesIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#residesIn">https://w3id.org/HHT#residesIn</seealso>
    let residesIn = Prefixed_Name(hht, "residesIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#setCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes the number of elements of the geometry set described in a BlockGeometry."</para>
    /// labels<para>"setCardinality"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#setCardinality">https://w3id.org/HHT#setCardinality</seealso>
    let setCardinality = Prefixed_Name(hht, "setCardinality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#stableBlockArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A block supposed to exist at all times, that is characterized only by its geometrical extent and has not necessarily any particular meaning other than that."</para>
    /// labels<para>"stable block area"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#stableBlockArea">https://w3id.org/HHT#stableBlockArea</seealso>
    let stableBlockArea = Prefixed_Name(hht, "stableBlockArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#unionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the areas which are taking part into an AreaUnion."</para>
    /// labels<para>"unionOf"</para></remarks>
    /// <seealso href="https://w3id.org/HHT#unionOf">https://w3id.org/HHT#unionOf</seealso>
    let unionOf = Prefixed_Name(hht, "unionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:HHT#validityPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Denotes the time interval where the state described by a version is valid."</para>
    /// labels<para>"validityPeriod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/HHT#validityPeriod">https://w3id.org/HHT#validityPeriod</seealso>
    let validityPeriod = Prefixed_Name(hht, "validityPeriod") |> PrefixedName
