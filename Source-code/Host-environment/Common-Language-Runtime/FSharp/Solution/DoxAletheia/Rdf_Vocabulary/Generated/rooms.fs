namespace http.vocab.deri.ie.rooms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rooms =
    let _namespace_iri = Namespace_Iri rooms |> NamespaceIRI

    /// <summary>
    ///   <para>rooms:Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway">http://vocab.deri.ie/rooms#Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway</seealso>
    let ``Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway`` =
        Prefixed_Name(rooms, "Digital%20Enterprise%20Research%20Institute%2C%20NUI%20Galway") |> PrefixedName

    /// <summary>
    ///   <para>rooms:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A space inside a structure, typically separated from the outside by exterior walls and from other rooms in the same structure by internal walls.</para>
    /// labels<para>Room</para></remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#Room">http://vocab.deri.ie/rooms#Room</seealso>
    let Room = Prefixed_Name(rooms, "Room") |> PrefixedName
    /// <summary>
    ///   <para>rooms:occupant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An agent that generally occupies the physical area of the subject resource. Having this property implies being a spatial object. Being the object of this property implies being an agent. Intended for use with buildings, rooms, desks, etc.</para>
    /// labels<para>Occupant</para></remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#occupant">http://vocab.deri.ie/rooms#occupant</seealso>
    let occupant = Prefixed_Name(rooms, "occupant") |> PrefixedName
    /// <summary>
    ///   <para>rooms:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#ttl">http://vocab.deri.ie/rooms#ttl</seealso>
    let ttl = Prefixed_Name(rooms, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>rooms:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#rdf">http://vocab.deri.ie/rooms#rdf</seealso>
    let rdf = Prefixed_Name(rooms, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>rooms:cygri</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#cygri">http://vocab.deri.ie/rooms#cygri</seealso>
    let cygri = Prefixed_Name(rooms, "cygri") |> PrefixedName
    /// <summary>
    ///   <para>rooms:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A human-made structure used for sheltering or continuous occupancy.</para>
    /// labels<para>Building</para></remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#Building">http://vocab.deri.ie/rooms#Building</seealso>
    let Building = Prefixed_Name(rooms, "Building") |> PrefixedName
    /// <summary>
    ///   <para>rooms:Desk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A table used in a work or office setting, typically for reading, writing, or computer use.</para>
    /// labels<para>Desk</para></remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#Desk">http://vocab.deri.ie/rooms#Desk</seealso>
    let Desk = Prefixed_Name(rooms, "Desk") |> PrefixedName
    /// <summary>
    ///   <para>rooms:Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A level part of a building that has a permanent roof. A storey of a building. </para>
    /// labels<para>Floor</para></remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#Floor">http://vocab.deri.ie/rooms#Floor</seealso>
    let Floor = Prefixed_Name(rooms, "Floor") |> PrefixedName
    /// <summary>
    ///   <para>rooms:FloorSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A named part of a floor of a building. Typically used to denote several rooms that are grouped together based on spatial arrangement or use.</para>
    /// labels<para>Floor Section</para></remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#FloorSection">http://vocab.deri.ie/rooms#FloorSection</seealso>
    let FloorSection = Prefixed_Name(rooms, "FloorSection") |> PrefixedName
    /// <summary>
    ///   <para>rooms:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An area of land with a designated purpose, such as a university Campus, a housing estate, or a building site.</para>
    /// labels<para>Site</para></remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#Site">http://vocab.deri.ie/rooms#Site</seealso>
    let Site = Prefixed_Name(rooms, "Site") |> PrefixedName
    /// <summary>
    ///   <para>rooms:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object resource is physically and spatially contained in the subject resource. Being the subject or object of this property implies being a spatial object. Intended for use in the context of buildings, rooms, etc.</para>
    /// labels<para>Contains</para></remarks>
    /// <seealso href="http://vocab.deri.ie/rooms#contains">http://vocab.deri.ie/rooms#contains</seealso>
    let contains = Prefixed_Name(rooms, "contains") |> PrefixedName
