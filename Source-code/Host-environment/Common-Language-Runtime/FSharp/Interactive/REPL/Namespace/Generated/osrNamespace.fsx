#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module osr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/core/space#" "osr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an aquatic region^^xsd:string</para>
    ///   <para>rdfs:label : Aquatic Region^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Aquatic">osr:Aquatic</a>
    /// </summary>
    let Aquatic = _prefixId.prefix "Aquatic"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an arable region^^xsd:string</para>
    ///   <para>rdfs:label : Arable^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Arable">osr:Arable</a>
    /// </summary>
    let Arable = _prefixId.prefix "Arable"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an arboreal region^^xsd:string</para>
    ///   <para>rdfs:label : Arboreal^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Arboreal">osr:Arboreal</a>
    /// </summary>
    let Arboreal = _prefixId.prefix "Arboreal"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a specific area^^xsd:string</para>
    ///   <para>rdfs:label : Area^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Area">osr:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a bay region^^xsd:string</para>
    ///   <para>rdfs:label : Bay^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Bay">osr:Bay</a>
    /// </summary>
    let Bay = _prefixId.prefix "Bay"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe the surface of a biological object^^xsd:string</para>
    ///   <para>rdfs:label : Biological Surface Space^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Biological-Surface-Space">osr:Biological-Surface-Space</a>
    /// </summary>
    let Biological_Surface_Space = _prefixId.prefix "Biological-Surface-Space"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a boggy region^^xsd:string</para>
    ///   <para>rdfs:label : Bog^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Bog">osr:Bog</a>
    /// </summary>
    let Bog = _prefixId.prefix "Bog"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a region that marks the boundary between other regions^^xsd:string</para>
    ///   <para>rdfs:label : Bounding^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Bounding">osr:Bounding</a>
    /// </summary>
    let Bounding = _prefixId.prefix "Bounding"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a Capital city^^xsd:string</para>
    ///   <para>rdfs:label : Capital^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Capital">osr:Capital</a>
    /// </summary>
    let Capital = _prefixId.prefix "Capital"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a city space^^xsd:string</para>
    ///   <para>rdfs:label : City^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#City">osr:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a container^^xsd:string</para>
    ///   <para>rdfs:label : Container^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Container">osr:Container</a>
    /// </summary>
    let Container = _prefixId.prefix "Container"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a continent^^xsd:string</para>
    ///   <para>rdfs:label : Continent^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Continent">osr:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a copse region^^xsd:string</para>
    ///   <para>rdfs:label : Copse^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Copse">osr:Copse</a>
    /// </summary>
    let Copse = _prefixId.prefix "Copse"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a country^^xsd:string</para>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Country">osr:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an estuary region^^xsd:string</para>
    ///   <para>rdfs:label : Estuary^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Estuary">osr:Estuary</a>
    /// </summary>
    let Estuary = _prefixId.prefix "Estuary"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a field^^xsd:string</para>
    ///   <para>rdfs:label : Field^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Field">osr:Field</a>
    /// </summary>
    let Field = _prefixId.prefix "Field"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a forested region^^xsd:string</para>
    ///   <para>rdfs:label : Forest^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Forest">osr:Forest</a>
    /// </summary>
    let Forest = _prefixId.prefix "Forest"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a galaxy^^xsd:string</para>
    ///   <para>rdfs:label : Galaxy^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Galaxy">osr:Galaxy</a>
    /// </summary>
    let Galaxy = _prefixId.prefix "Galaxy"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a gaseous region^^xsd:string</para>
    ///   <para>rdfs:label : Gaseous^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Gaseous">osr:Gaseous</a>
    /// </summary>
    let Gaseous = _prefixId.prefix "Gaseous"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a very damp region^^xsd:string</para>
    ///   <para>rdfs:label : Hydrated^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Hydrated">osr:Hydrated</a>
    /// </summary>
    let Hydrated = _prefixId.prefix "Hydrated"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a lake region^^xsd:string</para>
    ///   <para>rdfs:label : Lake^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Lake">osr:Lake</a>
    /// </summary>
    let Lake = _prefixId.prefix "Lake"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a region that forms a layer^^xsd:string</para>
    ///   <para>rdfs:label : Layer^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Layer">osr:Layer</a>
    /// </summary>
    let Layer = _prefixId.prefix "Layer"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a ledge i.e on the mountain wall^^xsd:string</para>
    ///   <para>rdfs:label : Ledge^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Ledge">osr:Ledge</a>
    /// </summary>
    let Ledge = _prefixId.prefix "Ledge"
    /// <summary>
    ///   <para>rdfs:comment : This class is used to represent a space which traverses levels^^xsd:string</para>
    ///   <para>rdfs:label : Level Traversing Space^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Level-Traversing-Space">osr:Level-Traversing-Space</a>
    /// </summary>
    let Level_Traversing_Space = _prefixId.prefix "Level-Traversing-Space"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a lot of land^^xsd:string</para>
    ///   <para>rdfs:label : Lot^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Lot">osr:Lot</a>
    /// </summary>
    let Lot = _prefixId.prefix "Lot"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a marshy region^^xsd:string</para>
    ///   <para>rdfs:label : Marsh^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Marsh">osr:Marsh</a>
    /// </summary>
    let Marsh = _prefixId.prefix "Marsh"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a metropolis^^xsd:string</para>
    ///   <para>rdfs:label : Metropolis^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Metropolis">osr:Metropolis</a>
    /// </summary>
    let Metropolis = _prefixId.prefix "Metropolis"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a mountain^^xsd:string</para>
    ///   <para>rdfs:label : Mountain^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Mountain">osr:Mountain</a>
    /// </summary>
    let Mountain = _prefixId.prefix "Mountain"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a continious mountainous region^^xsd:string</para>
    ///   <para>rdfs:label : Mountain Range^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Mountain-Range">osr:Mountain-Range</a>
    /// </summary>
    let Mountain_Range = _prefixId.prefix "Mountain-Range"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a necropolis^^xsd:string</para>
    ///   <para>rdfs:label : Necropolis^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Necropolis">osr:Necropolis</a>
    /// </summary>
    let Necropolis = _prefixId.prefix "Necropolis"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an ocean region^^xsd:string</para>
    ///   <para>rdfs:label : Ocean^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Ocean">osr:Ocean</a>
    /// </summary>
    let Ocean = _prefixId.prefix "Ocean"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe the path of an orbiting object^^xsd:string</para>
    ///   <para>rdfs:label : Orbit^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Orbit">osr:Orbit</a>
    /// </summary>
    let Orbit = _prefixId.prefix "Orbit"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a cultivated orchard region^^xsd:string</para>
    ///   <para>rdfs:label : Orchard^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Orchard">osr:Orchard</a>
    /// </summary>
    let Orchard = _prefixId.prefix "Orchard"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe plains^^xsd:string</para>
    ///   <para>rdfs:label : Plains^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Plains">osr:Plains</a>
    /// </summary>
    let Plains = _prefixId.prefix "Plains"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a man-made pond region^^xsd:string</para>
    ///   <para>rdfs:label : Pond^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Pond">osr:Pond</a>
    /// </summary>
    let Pond = _prefixId.prefix "Pond"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a pool region^^xsd:string</para>
    ///   <para>rdfs:label : Pool^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Pool">osr:Pool</a>
    /// </summary>
    let Pool = _prefixId.prefix "Pool"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a port city^^xsd:string</para>
    ///   <para>rdfs:label : Port^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Port">osr:Port</a>
    /// </summary>
    let Port = _prefixId.prefix "Port"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a portal i.e doorway, stargate^^xsd:string</para>
    ///   <para>rdfs:label : Portal^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Portal">osr:Portal</a>
    /// </summary>
    let Portal = _prefixId.prefix "Portal"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a puddle region^^xsd:string</para>
    ///   <para>rdfs:label : Puddle^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Puddle">osr:Puddle</a>
    /// </summary>
    let Puddle = _prefixId.prefix "Puddle"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a quay^^xsd:string</para>
    ///   <para>rdfs:label : Quay^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Quay">osr:Quay</a>
    /// </summary>
    let Quay = _prefixId.prefix "Quay"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a region^^xsd:string</para>
    ///   <para>rdfs:label : Region^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Region">osr:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a river region^^xsd:string</para>
    ///   <para>rdfs:label : River^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#River">osr:River</a>
    /// </summary>
    let River = _prefixId.prefix "River"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a riverbank^^xsd:string</para>
    ///   <para>rdfs:label : Riverbank^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Riverbank">osr:Riverbank</a>
    /// </summary>
    let Riverbank = _prefixId.prefix "Riverbank"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a sea region^^xsd:string</para>
    ///   <para>rdfs:label : Sea^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Sea">osr:Sea</a>
    /// </summary>
    let Sea = _prefixId.prefix "Sea"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a sea shore^^xsd:string</para>
    ///   <para>rdfs:label : Seashore^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Seashore">osr:Seashore</a>
    /// </summary>
    let Seashore = _prefixId.prefix "Seashore"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a space^^xsd:string</para>
    ///   <para>rdfs:label : Space^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Space">osr:Space</a>
    /// </summary>
    let Space = _prefixId.prefix "Space"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a stream region^^xsd:string</para>
    ///   <para>rdfs:label : Stream^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Stream">osr:Stream</a>
    /// </summary>
    let Stream = _prefixId.prefix "Stream"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe the surface of a object^^xsd:string</para>
    ///   <para>rdfs:label : Surface Space^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Surface-Space">osr:Surface-Space</a>
    /// </summary>
    let Surface_Space = _prefixId.prefix "Surface-Space"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a swampy region^^xsd:string</para>
    ///   <para>rdfs:label : Swamp^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Swamp">osr:Swamp</a>
    /// </summary>
    let Swamp = _prefixId.prefix "Swamp"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a town^^xsd:string</para>
    ///   <para>rdfs:label : Town^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Town">osr:Town</a>
    /// </summary>
    let Town = _prefixId.prefix "Town"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a universe^^xsd:string</para>
    ///   <para>rdfs:label : Universe^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Universe">osr:Universe</a>
    /// </summary>
    let Universe = _prefixId.prefix "Universe"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an urban area^^xsd:string</para>
    ///   <para>rdfs:label : Urban Area^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Urban-Area">osr:Urban-Area</a>
    /// </summary>
    let Urban_Area = _prefixId.prefix "Urban-Area"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a vessel^^xsd:string</para>
    ///   <para>rdfs:label : Vessel^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Vessel">osr:Vessel</a>
    /// </summary>
    let Vessel = _prefixId.prefix "Vessel"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a village space^^xsd:string</para>
    ///   <para>rdfs:label : Village^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Village">osr:Village</a>
    /// </summary>
    let Village = _prefixId.prefix "Village"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a volcano^^xsd:string</para>
    ///   <para>rdfs:label : Volcano^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Volcano">osr:Volcano</a>
    /// </summary>
    let Volcano = _prefixId.prefix "Volcano"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a wooded region^^xsd:string</para>
    ///   <para>rdfs:label : Wood^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#Wood">osr:Wood</a>
    /// </summary>
    let Wood = _prefixId.prefix "Wood"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe a world, planet, moon or other similar body^^xsd:string</para>
    ///   <para>rdfs:label : World^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#World">osr:World</a>
    /// </summary>
    let World = _prefixId.prefix "World"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an adjacent Space which is above the other^^xsd:string</para>
    ///   <para>rdfs:label : Adjacent Above^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#adjacent-above">osr:adjacent-above</a>
    /// </summary>
    let adjacent_above = _prefixId.prefix "adjacent-above"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an adjacent Space which is below the other^^xsd:string</para>
    ///   <para>rdfs:label : Adjacent Below^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#adjacent-below">osr:adjacent-below</a>
    /// </summary>
    let adjacent_below = _prefixId.prefix "adjacent-below"
    let adjacent_to = _prefixId.prefix "adjacent-to"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an Space which is the boundary of the Space^^xsd:string</para>
    ///   <para>rdfs:label : Has Boundary^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#has-boundary">osr:has-boundary</a>
    /// </summary>
    let has_boundary = _prefixId.prefix "has-boundary"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an item used to divide a portal^^xsd:string</para>
    ///   <para>rdfs:label : Has Dividing Item^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#has-dividing-item">osr:has-dividing-item</a>
    /// </summary>
    let has_dividing_item = _prefixId.prefix "has-dividing-item"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an Space of which the region is the boundary^^xsd:string</para>
    ///   <para>rdfs:label : Is Boundary Of^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#is-boundary-of">osr:is-boundary-of</a>
    /// </summary>
    let is_boundary_of = _prefixId.prefix "is-boundary-of"
    /// <summary>
    ///   <para>rdfs:comment : This property is to be used to describe an adjacent Space which describes an orbit around the other^^xsd:string</para>
    ///   <para>rdfs:label : Orbit Around^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/core/space#orbit-around">osr:orbit-around</a>
    /// </summary>
    let orbit_around = _prefixId.prefix "orbit-around"
