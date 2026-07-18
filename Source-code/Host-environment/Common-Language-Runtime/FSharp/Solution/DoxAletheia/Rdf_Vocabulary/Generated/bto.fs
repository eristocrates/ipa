namespace https.w3id.org.bot.hash

open DoxAletheia.Rdf_Vocabulary

module bto =
    let _namespace_name = "https://w3id.org/bot#"
    /// <summary>
    /// An independent unit of the built environment with a characteristic spatial structure, intended to serve at least one function or user activity [ISO 12006-2:2013]. A bot:Building is a part of the physical world or a virtual world that is inherently both located in this world and having a 3D spatial extent, is contained in a building site, and can contain one or more storeys that are vertically connected.
    /// <see href="https://w3id.org/bot#Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    /// A part of the physical world or a virtual world that is inherently both located in this world and has a 3D spatial extent; Sub-classes of bot:Zone include bot:Site, bot:Building, bot:Storey, or bot:Space.  An instance of bot:Zone can contain other bot:Zone instances, making it possible to group or subdivide zones. An instance of bot:Zone can be adjacent to or intersecting other bot:Zone instances. Finally, a bot:Zone can instantiate three relations to bot:Element, which are either contained in (bot:containsElement), adjacent to it (bot:adjacentElement) or intersecting (bot:intersectingElement).
    /// <see href="https://w3id.org/bot#Zone"></see></summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName
    /// <summary>
    /// A part of the physical world or a virtual world whose 3D spatial extent is bounded actually or theoretically, and provides for certain functions within the zone it is contained in.
    /// <see href="https://w3id.org/bot#Space"></see></summary>
    let Space = Namespaced_IRI.parse _namespace_name "Space" |> NamespacedName
    /// <summary>
    /// A part of the physical world or a virtual world that is inherently both located in this world and having a 3D spatial extent. It is intended to contain or contains one or more buildings.
    /// <see href="https://w3id.org/bot#Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    /// A part of the physical world or a virtual world that is inherently both located in this world and having a 3D spatial extent. A bot:Storey is contained in one or more buildings, and is intended to contain one or more spaces that are horizontally connected. Storeys of a building are connected by means of vertical connections such as elevators and stairs. A bot:Storey encompasses both zones above and below ground, for example, a building with 21 floors above ground, one ground floor and 3 basements is equal to the sentence: A building has 25 instances of bot:Storey.
    /// <see href="https://w3id.org/bot#Storey"></see></summary>
    let Storey = Namespaced_IRI.parse _namespace_name "Storey" |> NamespacedName
    /// <summary>
    /// Constituent of a construction entity with a characteristic technical function, form or position [ISO 12006-2:2015, 3.4.7]
    /// <see href="https://w3id.org/bot#Element"></see></summary>
    let Element = Namespaced_IRI.parse _namespace_name "Element" |> NamespacedName
    /// <summary>
    /// A generic concept to qualify the relationship of two or more things in the world, where at least one is a building element or zone. Examples:
    ///     - Qualification of heat transmission between zones through one or more building elements. This includes one-dimensional (surface) heat losses from one zone to another through a single building element, a two dimensional (line) loss from one zone to another through the connection in which the two elements meet or a three dimensional (point) loss from one zone to another through the connection where three elements (typically two walls and a slab) meet.
    ///     - Connection of an electric device to the electric system of a building.
    ///     - A door between one room and another.
    /// <see href="https://w3id.org/bot#Interface"></see></summary>
    let Interface = Namespaced_IRI.parse _namespace_name "Interface" |> NamespacedName

    /// <summary>
    /// Relation between a zone and its adjacent building elements, bounding the zone.
    /// <see href="https://w3id.org/bot#adjacentElement"></see></summary>
    let adjacentElement =
        Namespaced_IRI.parse _namespace_name "adjacentElement" |> NamespacedName

    /// <summary>
    /// Links a Zone to an Element that is either contained in, adjacent to or intersecting with the Zone. The intended use of this relationship is not to be stated explicitly, but to be inferred from its sub-properties. It will, for example, allow one to query for all the doors of a building given that they have an adjacency to spaces of the building.
    /// <see href="https://w3id.org/bot#hasElement"></see></summary>
    let hasElement = Namespaced_IRI.parse _namespace_name "hasElement" |> NamespacedName

    /// <summary>
    /// Relation between a Zone and a building Element that intersects it.
    /// <see href="https://w3id.org/bot#intersectingElement"></see></summary>
    let intersectingElement =
        Namespaced_IRI.parse _namespace_name "intersectingElement" |> NamespacedName

    /// <summary>
    /// Relationship between two zones that share a common interface, but do not intersect.
    /// <see href="https://w3id.org/bot#adjacentZone"></see></summary>
    let adjacentZone =
        Namespaced_IRI.parse _namespace_name "adjacentZone" |> NamespacedName

    /// <summary>
    /// Relationship between two zones whose 3D extent intersect. For example, a stairwell intersects different storeys.
    /// <see href="https://w3id.org/bot#intersectsZone"></see></summary>
    let intersectsZone =
        Namespaced_IRI.parse _namespace_name "intersectsZone" |> NamespacedName

    /// <summary>
    /// Relation to a building element contained in a zone.
    /// <see href="https://w3id.org/bot#containsElement"></see></summary>
    let containsElement =
        Namespaced_IRI.parse _namespace_name "containsElement" |> NamespacedName

    /// <summary>
    /// Relationship to the subzones of a major zone. A space zone could for instance be contained in a storey zone which is further contained in a building zone. bot:containsZone is a transitive property. This implies that in the previous example a bot:containsZone relationship holds between the space zone and the building zone.
    /// <see href="https://w3id.org/bot#containsZone"></see></summary>
    let containsZone =
        Namespaced_IRI.parse _namespace_name "containsZone" |> NamespacedName

    /// <summary>
    /// Links any bot:Zone or bot:Element to a IRI that identifies its 3D Model. This 3D Model can then be described using some dedicated RDF vocabulary. Else, the 3D Model IRI could be dereferenceable, and when looking up the IRI one could retrieve a representation of the 3D Model with some existing data format for 3D models.
    /// <see href="https://w3id.org/bot#has3DModel"></see></summary>
    let has3DModel = Namespaced_IRI.parse _namespace_name "has3DModel" |> NamespacedName

    /// <summary>
    /// Relation to buildings contained in a zone. The typical domains of bot:hasBuilding are instances of bot:Site.
    /// <see href="https://w3id.org/bot#hasBuilding"></see></summary>
    let hasBuilding =
        Namespaced_IRI.parse _namespace_name "hasBuilding" |> NamespacedName

    /// <summary>
    /// Links any bot:Zone or bot:Element to a 3D Model encoded as a literal.
    /// <see href="https://w3id.org/bot#hasSimple3DModel"></see></summary>
    let hasSimple3DModel =
        Namespaced_IRI.parse _namespace_name "hasSimple3DModel" |> NamespacedName

    /// <summary>
    /// Relation to spaces contained in a zone. The typical domains of bot:hasSpace are instances of bot:Storey or bot:Building.
    /// <see href="https://w3id.org/bot#hasSpace"></see></summary>
    let hasSpace = Namespaced_IRI.parse _namespace_name "hasSpace" |> NamespacedName
    /// <summary>
    /// Relation to storeys contained in a zone. The typical domains of bot:hasStorey are instances of bot:Building.
    /// <see href="https://w3id.org/bot#hasStorey"></see></summary>
    let hasStorey = Namespaced_IRI.parse _namespace_name "hasStorey" |> NamespacedName

    /// <summary>
    /// Relation between two building elements, either one element hosting another (e.g. a wall hosts a window) or a subcomposition of a building element into smaller parts (e.g. an air handling unit has as a part a fan).
    /// <see href="https://w3id.org/bot#hasSubElement"></see></summary>
    let hasSubElement =
        Namespaced_IRI.parse _namespace_name "hasSubElement" |> NamespacedName

    /// <summary>
    /// Links a bot:Site to an instance that encodes the latitude and longitude of the Zero Point of the building site. This could be an instance of a wgs84:Point. The definition of GIS and geometry is not within the scope of BOT and an appropriate ontology needs to be selected here by the user. The use of this property is potentially ambiguous and it might be removed or revised in future editions of the ontology.
    /// <see href="https://w3id.org/bot#hasZeroPoint"></see></summary>
    let hasZeroPoint =
        Namespaced_IRI.parse _namespace_name "hasZeroPoint" |> NamespacedName

    /// <summary>
    /// Relationship between an interface and another thing (building zone, element or owl:Thing)
    /// <see href="https://w3id.org/bot#interfaceOf"></see></summary>
    let interfaceOf =
        Namespaced_IRI.parse _namespace_name "interfaceOf" |> NamespacedName
