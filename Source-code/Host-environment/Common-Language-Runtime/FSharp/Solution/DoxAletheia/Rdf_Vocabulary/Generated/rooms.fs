namespace http.vocab.deri.ie.rooms.hash

open DoxAletheia.Rdf_Vocabulary

module rooms =
    let _namespace_name = "http://vocab.deri.ie/rooms#"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/rooms#cygri"></see>
    /// </summary>
    let cygri = Namespaced_IRI.parse _namespace_name "cygri" |> NamespacedName
    /// <summary>
    /// A human-made structure used for sheltering or continuous occupancy.
    /// <see href="http://vocab.deri.ie/rooms#Building"></see></summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    /// A table used in a work or office setting, typically for reading, writing, or computer use.
    /// <see href="http://vocab.deri.ie/rooms#Desk"></see></summary>
    let Desk = Namespaced_IRI.parse _namespace_name "Desk" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/rooms#Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway`` =
        Namespaced_IRI.parse _namespace_name "Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway" |> NamespacedName

    /// <summary>
    /// A level part of a building that has a permanent roof. A storey of a building.
    /// <see href="http://vocab.deri.ie/rooms#Floor"></see></summary>
    let Floor = Namespaced_IRI.parse _namespace_name "Floor" |> NamespacedName

    /// <summary>
    /// A named part of a floor of a building. Typically used to denote several rooms that are grouped together based on spatial arrangement or use.
    /// <see href="http://vocab.deri.ie/rooms#FloorSection"></see></summary>
    let FloorSection =
        Namespaced_IRI.parse _namespace_name "FloorSection" |> NamespacedName

    /// <summary>
    /// A space inside a structure, typically separated from the outside by exterior walls and from other rooms in the same structure by internal walls.
    /// <see href="http://vocab.deri.ie/rooms#Room"></see></summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName
    /// <summary>
    /// An area of land with a designated purpose, such as a university Campus, a housing estate, or a building site.
    /// <see href="http://vocab.deri.ie/rooms#Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    /// The object resource is physically and spatially contained in the subject resource. Being the subject or object of this property implies being a spatial object. Intended for use in the context of buildings, rooms, etc.
    /// <see href="http://vocab.deri.ie/rooms#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    /// An agent that generally occupies the physical area of the subject resource. Having this property implies being a spatial object. Being the object of this property implies being an agent. Intended for use with buildings, rooms, desks, etc.
    /// <see href="http://vocab.deri.ie/rooms#occupant"></see></summary>
    let occupant = Namespaced_IRI.parse _namespace_name "occupant" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/rooms#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.deri.ie/rooms#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName
