namespace http.vocab.deri.ie.rooms.hash

open DoxAletheia

module rooms =
    let _namespace_name = "http://vocab.deri.ie/rooms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.deri.ie/rooms#cygri"></see>
    /// </summary>
    let cygri = _prefix "cygri"
    /// <summary>
    /// A human-made structure used for sheltering or continuous occupancy.
    /// <see href="http://vocab.deri.ie/rooms#Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    /// A table used in a work or office setting, typically for reading, writing, or computer use.
    /// <see href="http://vocab.deri.ie/rooms#Desk"></see></summary>
    let Desk = _prefix "Desk"

    /// <summary>
    ///   <see href="http://vocab.deri.ie/rooms#Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway"></see>
    /// </summary>
    let ``Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway`` =
        _prefix "Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway"

    /// <summary>
    /// A level part of a building that has a permanent roof. A storey of a building.
    /// <see href="http://vocab.deri.ie/rooms#Floor"></see></summary>
    let Floor = _prefix "Floor"
    /// <summary>
    /// A named part of a floor of a building. Typically used to denote several rooms that are grouped together based on spatial arrangement or use.
    /// <see href="http://vocab.deri.ie/rooms#FloorSection"></see></summary>
    let FloorSection = _prefix "FloorSection"
    /// <summary>
    /// A space inside a structure, typically separated from the outside by exterior walls and from other rooms in the same structure by internal walls.
    /// <see href="http://vocab.deri.ie/rooms#Room"></see></summary>
    let Room = _prefix "Room"
    /// <summary>
    /// An area of land with a designated purpose, such as a university Campus, a housing estate, or a building site.
    /// <see href="http://vocab.deri.ie/rooms#Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    /// The object resource is physically and spatially contained in the subject resource. Being the subject or object of this property implies being a spatial object. Intended for use in the context of buildings, rooms, etc.
    /// <see href="http://vocab.deri.ie/rooms#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// An agent that generally occupies the physical area of the subject resource. Having this property implies being a spatial object. Being the object of this property implies being an agent. Intended for use with buildings, rooms, desks, etc.
    /// <see href="http://vocab.deri.ie/rooms#occupant"></see></summary>
    let occupant = _prefix "occupant"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/rooms#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    ///   <see href="http://vocab.deri.ie/rooms#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
