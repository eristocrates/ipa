namespace http.contextus.net.ontology.ontomedia.core.space.hash

open DoxAletheia.Rdf_Vocabulary

module osr =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/core/space#"
    /// <summary>
    /// This property is to be used to describe an aquatic region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Aquatic"></see></summary>
    let Aquatic = Namespaced_IRI.parse _namespace_name "Aquatic" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Region"></see></summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe an arable region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Arable"></see></summary>
    let Arable = Namespaced_IRI.parse _namespace_name "Arable" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe an arboreal region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Arboreal"></see></summary>
    let Arboreal = Namespaced_IRI.parse _namespace_name "Arboreal" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a specific area
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a bay region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Bay"></see></summary>
    let Bay = Namespaced_IRI.parse _namespace_name "Bay" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe the surface of a biological object
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Biological-Surface-Space"></see></summary>
    let ``Biological-Surface-Space`` =
        Namespaced_IRI.parse _namespace_name "Biological-Surface-Space" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe the surface of a object
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Surface-Space"></see></summary>
    let ``Surface-Space`` =
        Namespaced_IRI.parse _namespace_name "Surface-Space" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe a boggy region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Bog"></see></summary>
    let Bog = Namespaced_IRI.parse _namespace_name "Bog" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a very damp region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Hydrated"></see></summary>
    let Hydrated = Namespaced_IRI.parse _namespace_name "Hydrated" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a region that marks the boundary between other regions
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Bounding"></see></summary>
    let Bounding = Namespaced_IRI.parse _namespace_name "Bounding" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a Capital city
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Capital"></see></summary>
    let Capital = Namespaced_IRI.parse _namespace_name "Capital" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a metropolis
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Metropolis"></see></summary>
    let Metropolis = Namespaced_IRI.parse _namespace_name "Metropolis" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a city space
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe an urban area
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Urban-Area"></see></summary>
    let ``Urban-Area`` =
        Namespaced_IRI.parse _namespace_name "Urban-Area" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe a container
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Container"></see></summary>
    let Container = Namespaced_IRI.parse _namespace_name "Container" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a continent
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Continent"></see></summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a copse region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Copse"></see></summary>
    let Copse = Namespaced_IRI.parse _namespace_name "Copse" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a country
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe an estuary region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Estuary"></see></summary>
    let Estuary = Namespaced_IRI.parse _namespace_name "Estuary" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a field
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Field"></see></summary>
    let Field = Namespaced_IRI.parse _namespace_name "Field" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a forested region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Forest"></see></summary>
    let Forest = Namespaced_IRI.parse _namespace_name "Forest" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a galaxy
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Galaxy"></see></summary>
    let Galaxy = Namespaced_IRI.parse _namespace_name "Galaxy" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a gaseous region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Gaseous"></see></summary>
    let Gaseous = Namespaced_IRI.parse _namespace_name "Gaseous" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a lake region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Lake"></see></summary>
    let Lake = Namespaced_IRI.parse _namespace_name "Lake" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a region that forms a layer
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Layer"></see></summary>
    let Layer = Namespaced_IRI.parse _namespace_name "Layer" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a ledge i.e on the mountain wall
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Ledge"></see></summary>
    let Ledge = Namespaced_IRI.parse _namespace_name "Ledge" |> NamespacedName

    /// <summary>
    /// This class is used to represent a space which traverses levels
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Level-Traversing-Space"></see></summary>
    let ``Level-Traversing-Space`` =
        Namespaced_IRI.parse _namespace_name "Level-Traversing-Space" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe a space
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Space"></see></summary>
    let Space = Namespaced_IRI.parse _namespace_name "Space" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a lot of land
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Lot"></see></summary>
    let Lot = Namespaced_IRI.parse _namespace_name "Lot" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a marshy region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Marsh"></see></summary>
    let Marsh = Namespaced_IRI.parse _namespace_name "Marsh" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a mountain
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Mountain"></see></summary>
    let Mountain = Namespaced_IRI.parse _namespace_name "Mountain" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe a continious mountainous region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Mountain-Range"></see></summary>
    let ``Mountain-Range`` =
        Namespaced_IRI.parse _namespace_name "Mountain-Range" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe a necropolis
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Necropolis"></see></summary>
    let Necropolis = Namespaced_IRI.parse _namespace_name "Necropolis" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe an ocean region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Ocean"></see></summary>
    let Ocean = Namespaced_IRI.parse _namespace_name "Ocean" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe the path of an orbiting object
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Orbit"></see></summary>
    let Orbit = Namespaced_IRI.parse _namespace_name "Orbit" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a cultivated orchard region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Orchard"></see></summary>
    let Orchard = Namespaced_IRI.parse _namespace_name "Orchard" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe plains
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Plains"></see></summary>
    let Plains = Namespaced_IRI.parse _namespace_name "Plains" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a man-made pond region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Pond"></see></summary>
    let Pond = Namespaced_IRI.parse _namespace_name "Pond" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a pool region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Pool"></see></summary>
    let Pool = Namespaced_IRI.parse _namespace_name "Pool" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a port city
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Port"></see></summary>
    let Port = Namespaced_IRI.parse _namespace_name "Port" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a portal i.e doorway, stargate
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Portal"></see></summary>
    let Portal = Namespaced_IRI.parse _namespace_name "Portal" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a puddle region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Puddle"></see></summary>
    let Puddle = Namespaced_IRI.parse _namespace_name "Puddle" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a quay
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Quay"></see></summary>
    let Quay = Namespaced_IRI.parse _namespace_name "Quay" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a river region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#River"></see></summary>
    let River = Namespaced_IRI.parse _namespace_name "River" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a riverbank
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Riverbank"></see></summary>
    let Riverbank = Namespaced_IRI.parse _namespace_name "Riverbank" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a sea region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Sea"></see></summary>
    let Sea = Namespaced_IRI.parse _namespace_name "Sea" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a sea shore
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Seashore"></see></summary>
    let Seashore = Namespaced_IRI.parse _namespace_name "Seashore" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a stream region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Stream"></see></summary>
    let Stream = Namespaced_IRI.parse _namespace_name "Stream" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a swampy region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Swamp"></see></summary>
    let Swamp = Namespaced_IRI.parse _namespace_name "Swamp" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a town
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Town"></see></summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a universe
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Universe"></see></summary>
    let Universe = Namespaced_IRI.parse _namespace_name "Universe" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a vessel
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Vessel"></see></summary>
    let Vessel = Namespaced_IRI.parse _namespace_name "Vessel" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a village space
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Village"></see></summary>
    let Village = Namespaced_IRI.parse _namespace_name "Village" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a volcano
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Volcano"></see></summary>
    let Volcano = Namespaced_IRI.parse _namespace_name "Volcano" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a wooded region
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#Wood"></see></summary>
    let Wood = Namespaced_IRI.parse _namespace_name "Wood" |> NamespacedName
    /// <summary>
    /// This property is to be used to describe a world, planet, moon or other similar body
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#World"></see></summary>
    let World = Namespaced_IRI.parse _namespace_name "World" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe an adjacent Space which is above the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#adjacent-above"></see></summary>
    let ``adjacent-above`` =
        Namespaced_IRI.parse _namespace_name "adjacent-above" |> NamespacedName

    /// <summary>
    ///   <see href="http://contextus.net/ontology/ontomedia/core/space#adjacent-to"></see>
    /// </summary>
    let ``adjacent-to`` =
        Namespaced_IRI.parse _namespace_name "adjacent-to" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe an adjacent Space which is below the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#adjacent-below"></see></summary>
    let ``adjacent-below`` =
        Namespaced_IRI.parse _namespace_name "adjacent-below" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe an Space which is the boundary of the Space
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#has-boundary"></see></summary>
    let ``has-boundary`` =
        Namespaced_IRI.parse _namespace_name "has-boundary" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe an Space of which the region is the boundary
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#is-boundary-of"></see></summary>
    let ``is-boundary-of`` =
        Namespaced_IRI.parse _namespace_name "is-boundary-of" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe an item used to divide a portal
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#has-dividing-item"></see></summary>
    let ``has-dividing-item`` =
        Namespaced_IRI.parse _namespace_name "has-dividing-item" |> NamespacedName

    /// <summary>
    /// This property is to be used to describe an adjacent Space which describes an orbit around the other
    /// <see href="http://contextus.net/ontology/ontomedia/core/space#orbit-around"></see></summary>
    let ``orbit-around`` =
        Namespaced_IRI.parse _namespace_name "orbit-around" |> NamespacedName
