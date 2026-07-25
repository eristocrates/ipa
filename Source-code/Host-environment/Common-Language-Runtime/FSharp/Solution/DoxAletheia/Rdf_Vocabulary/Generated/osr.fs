namespace http.contextus.net.ontology.ontomedia.core.space.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osr =
    let _namespace_iri = Namespace_Iri osr |> NamespaceIRI
    /// <summary>
    ///   <para>osr:Aquatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe an aquatic region</para>
    /// labels<para>Aquatic Region</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Aquatic">http://contextus.net/ontology/ontomedia/core/space#Aquatic</seealso>
    let Aquatic = Prefixed_Name(osr, "Aquatic") |> PrefixedName
    /// <summary>
    ///   <para>osr:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a region</para>
    /// labels<para>Region</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Region">http://contextus.net/ontology/ontomedia/core/space#Region</seealso>
    let Region = Prefixed_Name(osr, "Region") |> PrefixedName
    /// <summary>
    ///   <para>osr:Arable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe an arable region</para>
    /// labels<para>Arable</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Arable">http://contextus.net/ontology/ontomedia/core/space#Arable</seealso>
    let Arable = Prefixed_Name(osr, "Arable") |> PrefixedName

    /// <summary>
    ///   <para>osr:Biological-Surface-Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe the surface of a biological object</para>
    /// labels<para>Biological Surface Space</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Biological-Surface-Space">http://contextus.net/ontology/ontomedia/core/space#Biological-Surface-Space</seealso>
    let Biological_Surface_Space =
        Prefixed_Name(osr, "Biological-Surface-Space") |> PrefixedName

    /// <summary>
    ///   <para>osr:Hydrated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a very damp region</para>
    /// labels<para>Hydrated</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Hydrated">http://contextus.net/ontology/ontomedia/core/space#Hydrated</seealso>
    let Hydrated = Prefixed_Name(osr, "Hydrated") |> PrefixedName
    /// <summary>
    ///   <para>osr:Bounding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a region that marks the boundary between other regions</para>
    /// labels<para>Bounding</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Bounding">http://contextus.net/ontology/ontomedia/core/space#Bounding</seealso>
    let Bounding = Prefixed_Name(osr, "Bounding") |> PrefixedName
    /// <summary>
    ///   <para>osr:Urban-Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe an urban area</para>
    /// labels<para>Urban Area</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Urban-Area">http://contextus.net/ontology/ontomedia/core/space#Urban-Area</seealso>
    let Urban_Area = Prefixed_Name(osr, "Urban-Area") |> PrefixedName
    /// <summary>
    ///   <para>osr:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a container</para>
    /// labels<para>Container</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Container">http://contextus.net/ontology/ontomedia/core/space#Container</seealso>
    let Container = Prefixed_Name(osr, "Container") |> PrefixedName
    /// <summary>
    ///   <para>osr:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a country</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Country">http://contextus.net/ontology/ontomedia/core/space#Country</seealso>
    let Country = Prefixed_Name(osr, "Country") |> PrefixedName
    /// <summary>
    ///   <para>osr:Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a forested region</para>
    /// labels<para>Forest</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Forest">http://contextus.net/ontology/ontomedia/core/space#Forest</seealso>
    let Forest = Prefixed_Name(osr, "Forest") |> PrefixedName
    /// <summary>
    ///   <para>osr:Lake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a lake region</para>
    /// labels<para>Lake</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Lake">http://contextus.net/ontology/ontomedia/core/space#Lake</seealso>
    let Lake = Prefixed_Name(osr, "Lake") |> PrefixedName
    /// <summary>
    ///   <para>osr:Ledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a ledge i.e on the mountain wall</para>
    /// labels<para>Ledge</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Ledge">http://contextus.net/ontology/ontomedia/core/space#Ledge</seealso>
    let Ledge = Prefixed_Name(osr, "Ledge") |> PrefixedName
    /// <summary>
    ///   <para>osr:Arboreal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe an arboreal region</para>
    /// labels<para>Arboreal</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Arboreal">http://contextus.net/ontology/ontomedia/core/space#Arboreal</seealso>
    let Arboreal = Prefixed_Name(osr, "Arboreal") |> PrefixedName
    /// <summary>
    ///   <para>osr:Capital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a Capital city</para>
    /// labels<para>Capital</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Capital">http://contextus.net/ontology/ontomedia/core/space#Capital</seealso>
    let Capital = Prefixed_Name(osr, "Capital") |> PrefixedName
    /// <summary>
    ///   <para>osr:Pool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a pool region</para>
    /// labels<para>Pool</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Pool">http://contextus.net/ontology/ontomedia/core/space#Pool</seealso>
    let Pool = Prefixed_Name(osr, "Pool") |> PrefixedName
    /// <summary>
    ///   <para>osr:Quay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a quay</para>
    /// labels<para>Quay</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Quay">http://contextus.net/ontology/ontomedia/core/space#Quay</seealso>
    let Quay = Prefixed_Name(osr, "Quay") |> PrefixedName
    /// <summary>
    ///   <para>osr:Riverbank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a riverbank</para>
    /// labels<para>Riverbank</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Riverbank">http://contextus.net/ontology/ontomedia/core/space#Riverbank</seealso>
    let Riverbank = Prefixed_Name(osr, "Riverbank") |> PrefixedName
    /// <summary>
    ///   <para>osr:Seashore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a sea shore</para>
    /// labels<para>Seashore</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Seashore">http://contextus.net/ontology/ontomedia/core/space#Seashore</seealso>
    let Seashore = Prefixed_Name(osr, "Seashore") |> PrefixedName
    /// <summary>
    ///   <para>osr:Stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a stream region</para>
    /// labels<para>Stream</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Stream">http://contextus.net/ontology/ontomedia/core/space#Stream</seealso>
    let Stream = Prefixed_Name(osr, "Stream") |> PrefixedName
    /// <summary>
    ///   <para>osr:Town</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a town</para>
    /// labels<para>Town</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Town">http://contextus.net/ontology/ontomedia/core/space#Town</seealso>
    let Town = Prefixed_Name(osr, "Town") |> PrefixedName
    /// <summary>
    ///   <para>osr:Vessel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a vessel</para>
    /// labels<para>Vessel</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Vessel">http://contextus.net/ontology/ontomedia/core/space#Vessel</seealso>
    let Vessel = Prefixed_Name(osr, "Vessel") |> PrefixedName
    /// <summary>
    ///   <para>osr:Wood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a wooded region</para>
    /// labels<para>Wood</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Wood">http://contextus.net/ontology/ontomedia/core/space#Wood</seealso>
    let Wood = Prefixed_Name(osr, "Wood") |> PrefixedName
    /// <summary>
    ///   <para>osr:adjacent-to</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#adjacent-to">http://contextus.net/ontology/ontomedia/core/space#adjacent-to</seealso>
    let adjacent_to = Prefixed_Name(osr, "adjacent-to") |> PrefixedName
    /// <summary>
    ///   <para>osr:is-boundary-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is to be used to describe an Space of which the region is the boundary</para>
    /// labels<para>Is Boundary Of</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#is-boundary-of">http://contextus.net/ontology/ontomedia/core/space#is-boundary-of</seealso>
    let is_boundary_of = Prefixed_Name(osr, "is-boundary-of") |> PrefixedName
    /// <summary>
    ///   <para>osr:orbit-around</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is to be used to describe an adjacent Space which describes an orbit around the other</para>
    /// labels<para>Orbit Around</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#orbit-around">http://contextus.net/ontology/ontomedia/core/space#orbit-around</seealso>
    let orbit_around = Prefixed_Name(osr, "orbit-around") |> PrefixedName
    /// <summary>
    ///   <para>osr:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a city space</para>
    /// labels<para>City</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#City">http://contextus.net/ontology/ontomedia/core/space#City</seealso>
    let City = Prefixed_Name(osr, "City") |> PrefixedName
    /// <summary>
    ///   <para>osr:Estuary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe an estuary region</para>
    /// labels<para>Estuary</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Estuary">http://contextus.net/ontology/ontomedia/core/space#Estuary</seealso>
    let Estuary = Prefixed_Name(osr, "Estuary") |> PrefixedName
    /// <summary>
    ///   <para>osr:has-dividing-item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is to be used to describe an item used to divide a portal</para>
    /// labels<para>Has Dividing Item</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#has-dividing-item">http://contextus.net/ontology/ontomedia/core/space#has-dividing-item</seealso>
    let has_dividing_item = Prefixed_Name(osr, "has-dividing-item") |> PrefixedName
    /// <summary>
    ///   <para>osr:Galaxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a galaxy</para>
    /// labels<para>Galaxy</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Galaxy">http://contextus.net/ontology/ontomedia/core/space#Galaxy</seealso>
    let Galaxy = Prefixed_Name(osr, "Galaxy") |> PrefixedName
    /// <summary>
    ///   <para>osr:Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a region that forms a layer</para>
    /// labels<para>Layer</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Layer">http://contextus.net/ontology/ontomedia/core/space#Layer</seealso>
    let Layer = Prefixed_Name(osr, "Layer") |> PrefixedName
    /// <summary>
    ///   <para>osr:Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a space</para>
    /// labels<para>Space</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Space">http://contextus.net/ontology/ontomedia/core/space#Space</seealso>
    let Space = Prefixed_Name(osr, "Space") |> PrefixedName
    /// <summary>
    ///   <para>osr:Necropolis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a necropolis</para>
    /// labels<para>Necropolis</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Necropolis">http://contextus.net/ontology/ontomedia/core/space#Necropolis</seealso>
    let Necropolis = Prefixed_Name(osr, "Necropolis") |> PrefixedName
    /// <summary>
    ///   <para>osr:Orbit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe the path of an orbiting object</para>
    /// labels<para>Orbit</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Orbit">http://contextus.net/ontology/ontomedia/core/space#Orbit</seealso>
    let Orbit = Prefixed_Name(osr, "Orbit") |> PrefixedName
    /// <summary>
    ///   <para>osr:Pond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a man-made pond region</para>
    /// labels<para>Pond</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Pond">http://contextus.net/ontology/ontomedia/core/space#Pond</seealso>
    let Pond = Prefixed_Name(osr, "Pond") |> PrefixedName
    /// <summary>
    ///   <para>osr:Port</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a port city</para>
    /// labels<para>Port</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Port">http://contextus.net/ontology/ontomedia/core/space#Port</seealso>
    let Port = Prefixed_Name(osr, "Port") |> PrefixedName
    /// <summary>
    ///   <para>osr:Puddle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a puddle region</para>
    /// labels<para>Puddle</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Puddle">http://contextus.net/ontology/ontomedia/core/space#Puddle</seealso>
    let Puddle = Prefixed_Name(osr, "Puddle") |> PrefixedName
    /// <summary>
    ///   <para>osr:River</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a river region</para>
    /// labels<para>River</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#River">http://contextus.net/ontology/ontomedia/core/space#River</seealso>
    let River = Prefixed_Name(osr, "River") |> PrefixedName
    /// <summary>
    ///   <para>osr:Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a sea region</para>
    /// labels<para>Sea</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Sea">http://contextus.net/ontology/ontomedia/core/space#Sea</seealso>
    let Sea = Prefixed_Name(osr, "Sea") |> PrefixedName
    /// <summary>
    ///   <para>osr:Swamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a swampy region</para>
    /// labels<para>Swamp</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Swamp">http://contextus.net/ontology/ontomedia/core/space#Swamp</seealso>
    let Swamp = Prefixed_Name(osr, "Swamp") |> PrefixedName
    /// <summary>
    ///   <para>osr:Universe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a universe</para>
    /// labels<para>Universe</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Universe">http://contextus.net/ontology/ontomedia/core/space#Universe</seealso>
    let Universe = Prefixed_Name(osr, "Universe") |> PrefixedName
    /// <summary>
    ///   <para>osr:Village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a village space</para>
    /// labels<para>Village</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Village">http://contextus.net/ontology/ontomedia/core/space#Village</seealso>
    let Village = Prefixed_Name(osr, "Village") |> PrefixedName
    /// <summary>
    ///   <para>osr:Volcano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a volcano</para>
    /// labels<para>Volcano</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Volcano">http://contextus.net/ontology/ontomedia/core/space#Volcano</seealso>
    let Volcano = Prefixed_Name(osr, "Volcano") |> PrefixedName
    /// <summary>
    ///   <para>osr:World</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a world, planet, moon or other similar body</para>
    /// labels<para>World</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#World">http://contextus.net/ontology/ontomedia/core/space#World</seealso>
    let World = Prefixed_Name(osr, "World") |> PrefixedName
    /// <summary>
    ///   <para>osr:adjacent-above</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is to be used to describe an adjacent Space which is above the other</para>
    /// labels<para>Adjacent Above</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#adjacent-above">http://contextus.net/ontology/ontomedia/core/space#adjacent-above</seealso>
    let adjacent_above = Prefixed_Name(osr, "adjacent-above") |> PrefixedName
    /// <summary>
    ///   <para>osr:adjacent-below</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is to be used to describe an adjacent Space which is below the other</para>
    /// labels<para>Adjacent Below</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#adjacent-below">http://contextus.net/ontology/ontomedia/core/space#adjacent-below</seealso>
    let adjacent_below = Prefixed_Name(osr, "adjacent-below") |> PrefixedName
    /// <summary>
    ///   <para>osr:has-boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is to be used to describe an Space which is the boundary of the Space</para>
    /// labels<para>Has Boundary</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#has-boundary">http://contextus.net/ontology/ontomedia/core/space#has-boundary</seealso>
    let has_boundary = Prefixed_Name(osr, "has-boundary") |> PrefixedName
    /// <summary>
    ///   <para>osr:Lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a lot of land</para>
    /// labels<para>Lot</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Lot">http://contextus.net/ontology/ontomedia/core/space#Lot</seealso>
    let Lot = Prefixed_Name(osr, "Lot") |> PrefixedName
    /// <summary>
    ///   <para>osr:Mountain-Range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a continious mountainous region</para>
    /// labels<para>Mountain Range</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Mountain-Range">http://contextus.net/ontology/ontomedia/core/space#Mountain-Range</seealso>
    let Mountain_Range = Prefixed_Name(osr, "Mountain-Range") |> PrefixedName
    /// <summary>
    ///   <para>osr:Plains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe plains</para>
    /// labels<para>Plains</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Plains">http://contextus.net/ontology/ontomedia/core/space#Plains</seealso>
    let Plains = Prefixed_Name(osr, "Plains") |> PrefixedName
    /// <summary>
    ///   <para>osr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>OntoMedia Space Representation</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#">http://contextus.net/ontology/ontomedia/core/space#</seealso>
    let _prefix_iri = Prefixed_Name(osr, "") |> PrefixedName
    /// <summary>
    ///   <para>osr:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a specific area</para>
    /// labels<para>Area</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Area">http://contextus.net/ontology/ontomedia/core/space#Area</seealso>
    let Area = Prefixed_Name(osr, "Area") |> PrefixedName
    /// <summary>
    ///   <para>osr:Bay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a bay region</para>
    /// labels<para>Bay</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Bay">http://contextus.net/ontology/ontomedia/core/space#Bay</seealso>
    let Bay = Prefixed_Name(osr, "Bay") |> PrefixedName
    /// <summary>
    ///   <para>osr:Surface-Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe the surface of a object</para>
    /// labels<para>Surface Space</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Surface-Space">http://contextus.net/ontology/ontomedia/core/space#Surface-Space</seealso>
    let Surface_Space = Prefixed_Name(osr, "Surface-Space") |> PrefixedName
    /// <summary>
    ///   <para>osr:Bog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a boggy region</para>
    /// labels<para>Bog</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Bog">http://contextus.net/ontology/ontomedia/core/space#Bog</seealso>
    let Bog = Prefixed_Name(osr, "Bog") |> PrefixedName
    /// <summary>
    ///   <para>osr:Metropolis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a metropolis</para>
    /// labels<para>Metropolis</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Metropolis">http://contextus.net/ontology/ontomedia/core/space#Metropolis</seealso>
    let Metropolis = Prefixed_Name(osr, "Metropolis") |> PrefixedName
    /// <summary>
    ///   <para>osr:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a continent</para>
    /// labels<para>Continent</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Continent">http://contextus.net/ontology/ontomedia/core/space#Continent</seealso>
    let Continent = Prefixed_Name(osr, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>osr:Copse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a copse region</para>
    /// labels<para>Copse</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Copse">http://contextus.net/ontology/ontomedia/core/space#Copse</seealso>
    let Copse = Prefixed_Name(osr, "Copse") |> PrefixedName
    /// <summary>
    ///   <para>osr:Field</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a field</para>
    /// labels<para>Field</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Field">http://contextus.net/ontology/ontomedia/core/space#Field</seealso>
    let Field = Prefixed_Name(osr, "Field") |> PrefixedName
    /// <summary>
    ///   <para>osr:Gaseous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a gaseous region</para>
    /// labels<para>Gaseous</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Gaseous">http://contextus.net/ontology/ontomedia/core/space#Gaseous</seealso>
    let Gaseous = Prefixed_Name(osr, "Gaseous") |> PrefixedName

    /// <summary>
    ///   <para>osr:Level-Traversing-Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is used to represent a space which traverses levels</para>
    /// labels<para>Level Traversing Space</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Level-Traversing-Space">http://contextus.net/ontology/ontomedia/core/space#Level-Traversing-Space</seealso>
    let Level_Traversing_Space =
        Prefixed_Name(osr, "Level-Traversing-Space") |> PrefixedName

    /// <summary>
    ///   <para>osr:Marsh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a marshy region</para>
    /// labels<para>Marsh</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Marsh">http://contextus.net/ontology/ontomedia/core/space#Marsh</seealso>
    let Marsh = Prefixed_Name(osr, "Marsh") |> PrefixedName
    /// <summary>
    ///   <para>osr:Mountain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a mountain</para>
    /// labels<para>Mountain</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Mountain">http://contextus.net/ontology/ontomedia/core/space#Mountain</seealso>
    let Mountain = Prefixed_Name(osr, "Mountain") |> PrefixedName
    /// <summary>
    ///   <para>osr:Ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe an ocean region</para>
    /// labels<para>Ocean</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Ocean">http://contextus.net/ontology/ontomedia/core/space#Ocean</seealso>
    let Ocean = Prefixed_Name(osr, "Ocean") |> PrefixedName
    /// <summary>
    ///   <para>osr:Orchard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a cultivated orchard region</para>
    /// labels<para>Orchard</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Orchard">http://contextus.net/ontology/ontomedia/core/space#Orchard</seealso>
    let Orchard = Prefixed_Name(osr, "Orchard") |> PrefixedName
    /// <summary>
    ///   <para>osr:Portal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This property is to be used to describe a portal i.e doorway, stargate</para>
    /// labels<para>Portal</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/core/space#Portal">http://contextus.net/ontology/ontomedia/core/space#Portal</seealso>
    let Portal = Prefixed_Name(osr, "Portal") |> PrefixedName
