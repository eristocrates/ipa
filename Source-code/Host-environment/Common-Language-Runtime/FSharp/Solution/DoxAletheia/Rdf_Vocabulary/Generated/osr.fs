namespace http.contextus.net.ontology.ontomedia.core.space.hash

open DoxAletheia

module osr =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/core/space#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This property is to be used to describe an aquatic region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Aquatic"></see></summary>
    let Aquatic = _prefix "Aquatic"
    /// <summary>
    /// This property is to be used to describe a region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    /// This property is to be used to describe an arable region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Arable"></see></summary>
    let Arable = _prefix "Arable"
    /// <summary>
    /// This property is to be used to describe an arboreal region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Arboreal"></see></summary>
    let Arboreal = _prefix "Arboreal"
    /// <summary>
    /// This property is to be used to describe a specific area
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    /// This property is to be used to describe a bay region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Bay"></see></summary>
    let Bay = _prefix "Bay"
    /// <summary>
    /// This property is to be used to describe the surface of a biological object
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Biological-Surface-Space"></see></summary>
    let ``Biological-Surface-Space`` = _prefix "Biological-Surface-Space"
    /// <summary>
    /// This property is to be used to describe the surface of a object
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Surface-Space"></see></summary>
    let ``Surface-Space`` = _prefix "Surface-Space"
    /// <summary>
    /// This property is to be used to describe a boggy region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Bog"></see></summary>
    let Bog = _prefix "Bog"
    /// <summary>
    /// This property is to be used to describe a very damp region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Hydrated"></see></summary>
    let Hydrated = _prefix "Hydrated"
    /// <summary>
    /// This property is to be used to describe a region that marks the boundary between other regions
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Bounding"></see></summary>
    let Bounding = _prefix "Bounding"
    /// <summary>
    /// This property is to be used to describe a Capital city
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Capital"></see></summary>
    let Capital = _prefix "Capital"
    /// <summary>
    /// This property is to be used to describe a metropolis
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Metropolis"></see></summary>
    let Metropolis = _prefix "Metropolis"
    /// <summary>
    /// This property is to be used to describe a city space
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// This property is to be used to describe an urban area
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Urban-Area"></see></summary>
    let ``Urban-Area`` = _prefix "Urban-Area"
    /// <summary>
    /// This property is to be used to describe a container
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Container"></see></summary>
    let Container = _prefix "Container"
    /// <summary>
    /// This property is to be used to describe a continent
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Continent"></see></summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// This property is to be used to describe a copse region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Copse"></see></summary>
    let Copse = _prefix "Copse"
    /// <summary>
    /// This property is to be used to describe a country
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// This property is to be used to describe an estuary region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Estuary"></see></summary>
    let Estuary = _prefix "Estuary"
    /// <summary>
    /// This property is to be used to describe a field
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Field"></see></summary>
    let Field = _prefix "Field"
    /// <summary>
    /// This property is to be used to describe a forested region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Forest"></see></summary>
    let Forest = _prefix "Forest"
    /// <summary>
    /// This property is to be used to describe a galaxy
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Galaxy"></see></summary>
    let Galaxy = _prefix "Galaxy"
    /// <summary>
    /// This property is to be used to describe a gaseous region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Gaseous"></see></summary>
    let Gaseous = _prefix "Gaseous"
    /// <summary>
    /// This property is to be used to describe a lake region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Lake"></see></summary>
    let Lake = _prefix "Lake"
    /// <summary>
    /// This property is to be used to describe a region that forms a layer
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Layer"></see></summary>
    let Layer = _prefix "Layer"
    /// <summary>
    /// This property is to be used to describe a ledge i.e on the mountain wall
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Ledge"></see></summary>
    let Ledge = _prefix "Ledge"
    /// <summary>
    /// This class is used to represent a space which traverses levels
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Level-Traversing-Space"></see></summary>
    let ``Level-Traversing-Space`` = _prefix "Level-Traversing-Space"
    /// <summary>
    /// This property is to be used to describe a space
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Space"></see></summary>
    let Space = _prefix "Space"
    /// <summary>
    /// This property is to be used to describe a lot of land
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Lot"></see></summary>
    let Lot = _prefix "Lot"
    /// <summary>
    /// This property is to be used to describe a marshy region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Marsh"></see></summary>
    let Marsh = _prefix "Marsh"
    /// <summary>
    /// This property is to be used to describe a mountain
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Mountain"></see></summary>
    let Mountain = _prefix "Mountain"
    /// <summary>
    /// This property is to be used to describe a continious mountainous region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Mountain-Range"></see></summary>
    let ``Mountain-Range`` = _prefix "Mountain-Range"
    /// <summary>
    /// This property is to be used to describe a necropolis
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Necropolis"></see></summary>
    let Necropolis = _prefix "Necropolis"
    /// <summary>
    /// This property is to be used to describe an ocean region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Ocean"></see></summary>
    let Ocean = _prefix "Ocean"
    /// <summary>
    /// This property is to be used to describe the path of an orbiting object
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Orbit"></see></summary>
    let Orbit = _prefix "Orbit"
    /// <summary>
    /// This property is to be used to describe a cultivated orchard region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Orchard"></see></summary>
    let Orchard = _prefix "Orchard"
    /// <summary>
    /// This property is to be used to describe plains
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Plains"></see></summary>
    let Plains = _prefix "Plains"
    /// <summary>
    /// This property is to be used to describe a man-made pond region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Pond"></see></summary>
    let Pond = _prefix "Pond"
    /// <summary>
    /// This property is to be used to describe a pool region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Pool"></see></summary>
    let Pool = _prefix "Pool"
    /// <summary>
    /// This property is to be used to describe a port city
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Port"></see></summary>
    let Port = _prefix "Port"
    /// <summary>
    /// This property is to be used to describe a portal i.e doorway, stargate
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Portal"></see></summary>
    let Portal = _prefix "Portal"
    /// <summary>
    /// This property is to be used to describe a puddle region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Puddle"></see></summary>
    let Puddle = _prefix "Puddle"
    /// <summary>
    /// This property is to be used to describe a quay
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Quay"></see></summary>
    let Quay = _prefix "Quay"
    /// <summary>
    /// This property is to be used to describe a river region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#River"></see></summary>
    let River = _prefix "River"
    /// <summary>
    /// This property is to be used to describe a riverbank
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Riverbank"></see></summary>
    let Riverbank = _prefix "Riverbank"
    /// <summary>
    /// This property is to be used to describe a sea region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Sea"></see></summary>
    let Sea = _prefix "Sea"
    /// <summary>
    /// This property is to be used to describe a sea shore
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Seashore"></see></summary>
    let Seashore = _prefix "Seashore"
    /// <summary>
    /// This property is to be used to describe a stream region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Stream"></see></summary>
    let Stream = _prefix "Stream"
    /// <summary>
    /// This property is to be used to describe a swampy region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Swamp"></see></summary>
    let Swamp = _prefix "Swamp"
    /// <summary>
    /// This property is to be used to describe a town
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Town"></see></summary>
    let Town = _prefix "Town"
    /// <summary>
    /// This property is to be used to describe a universe
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Universe"></see></summary>
    let Universe = _prefix "Universe"
    /// <summary>
    /// This property is to be used to describe a vessel
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Vessel"></see></summary>
    let Vessel = _prefix "Vessel"
    /// <summary>
    /// This property is to be used to describe a village space
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Village"></see></summary>
    let Village = _prefix "Village"
    /// <summary>
    /// This property is to be used to describe a volcano
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Volcano"></see></summary>
    let Volcano = _prefix "Volcano"
    /// <summary>
    /// This property is to be used to describe a wooded region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Wood"></see></summary>
    let Wood = _prefix "Wood"
    /// <summary>
    /// This property is to be used to describe a world, planet, moon or other similar body
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#World"></see></summary>
    let World = _prefix "World"
    /// <summary>
    /// This property is to be used to describe an adjacent Space which is above the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#adjacent-above"></see></summary>
    let ``adjacent-above`` = _prefix "adjacent-above"
    /// <summary>
    ///   <see href="http://contextus.net/ontology/ontomedia/core/space#adjacent-to"></see>
    /// </summary>
    let ``adjacent-to`` = _prefix "adjacent-to"
    /// <summary>
    /// This property is to be used to describe an adjacent Space which is below the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#adjacent-below"></see></summary>
    let ``adjacent-below`` = _prefix "adjacent-below"
    /// <summary>
    /// This property is to be used to describe an Space which is the boundary of the Space
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#has-boundary"></see></summary>
    let ``has-boundary`` = _prefix "has-boundary"
    /// <summary>
    /// This property is to be used to describe an Space of which the region is the boundary
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#is-boundary-of"></see></summary>
    let ``is-boundary-of`` = _prefix "is-boundary-of"
    /// <summary>
    /// This property is to be used to describe an item used to divide a portal
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#has-dividing-item"></see></summary>
    let ``has-dividing-item`` = _prefix "has-dividing-item"
    /// <summary>
    /// This property is to be used to describe an adjacent Space which describes an orbit around the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#orbit-around"></see></summary>
    let ``orbit-around`` = _prefix "orbit-around"
