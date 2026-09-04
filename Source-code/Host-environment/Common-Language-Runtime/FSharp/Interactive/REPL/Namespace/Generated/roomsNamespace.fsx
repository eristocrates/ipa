#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rooms =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/rooms#" "rooms"
    /// <summary>
    ///   <para>rdfs:label : Building^^xsd:string</para>
    ///   <para>rdfs:comment : A human-made structure used for sheltering or continuous occupancy.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/rooms#Building">rooms:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:label : Desk^^xsd:string</para>
    ///   <para>rdfs:comment : A table used in a work or office setting, typically for reading, writing, or computer use.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/rooms#Desk">rooms:Desk</a>
    /// </summary>
    let Desk = _prefixId.prefix "Desk"

    let ``Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway`` =
        _prefixId.prefix "Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway"

    /// <summary>
    ///   <para>rdfs:label : Floor^^xsd:string</para>
    ///   <para>rdfs:comment : A level part of a building that has a permanent roof. A storey of a building. ^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/rooms#Floor">rooms:Floor</a>
    /// </summary>
    let Floor = _prefixId.prefix "Floor"
    /// <summary>
    ///   <para>rdfs:label : Floor Section^^xsd:string</para>
    ///   <para>rdfs:comment : A named part of a floor of a building. Typically used to denote several rooms that are grouped together based on spatial arrangement or use.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/rooms#FloorSection">rooms:FloorSection</a>
    /// </summary>
    let FloorSection = _prefixId.prefix "FloorSection"
    /// <summary>
    ///   <para>rdfs:label : Room^^xsd:string</para>
    ///   <para>rdfs:comment : A space inside a structure, typically separated from the outside by exterior walls and from other rooms in the same structure by internal walls.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/rooms#Room">rooms:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>rdfs:label : Site^^xsd:string</para>
    ///   <para>rdfs:comment : An area of land with a designated purpose, such as a university Campus, a housing estate, or a building site.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/rooms#Site">rooms:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : Contains^^xsd:string</para>
    ///   <para>rdfs:comment : The object resource is physically and spatially contained in the subject resource. Being the subject or object of this property implies being a spatial object. Intended for use in the context of buildings, rooms, etc.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/rooms#contains">rooms:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    let cygri = _prefixId.prefix "cygri"
    /// <summary>
    ///   <para>rdfs:label : Occupant^^xsd:string</para>
    ///   <para>rdfs:comment : An agent that generally occupies the physical area of the subject resource. Having this property implies being a spatial object. Being the object of this property implies being an agent. Intended for use with buildings, rooms, desks, etc.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/rooms#occupant">rooms:occupant</a>
    /// </summary>
    let occupant = _prefixId.prefix "occupant"
    let rdf = _prefixId.prefix "rdf"
    let ttl = _prefixId.prefix "ttl"
