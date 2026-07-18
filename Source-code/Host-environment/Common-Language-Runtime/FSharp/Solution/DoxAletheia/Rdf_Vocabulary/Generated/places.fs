namespace http.purl.org.ontology.places.hash

open DoxAletheia.Rdf_Vocabulary

module places =
    let _namespace_name = "http://purl.org/ontology/places#"

    /// <summary>
    /// An area that is useful to illustrate a particular point but does not have a recognised political or cultural identity.
    /// <see href="http://purl.org/ontology/places#ArbitraryRegion"></see></summary>
    let ArbitraryRegion =
        Namespaced_IRI.parse _namespace_name "ArbitraryRegion" |> NamespacedName

    /// <summary>
    /// An indentation to a shoreline, a body of water enclosed but with a large mouth to a wider body of water.
    /// <see href="http://purl.org/ontology/places#Bay"></see></summary>
    let Bay = Namespaced_IRI.parse _namespace_name "Bay" |> NamespacedName
    /// <summary>
    /// The shore of a body of water, usually sandy or pebbly.
    /// <see href="http://purl.org/ontology/places#Beach"></see></summary>
    let Beach = Namespaced_IRI.parse _namespace_name "Beach" |> NamespacedName
    /// <summary>
    /// An administrative region of governance.
    /// <see href="http://purl.org/ontology/places#Borough"></see></summary>
    let Borough = Namespaced_IRI.parse _namespace_name "Borough" |> NamespacedName
    /// <summary>
    /// A Boundary resource specifies a sequence of points which, if joined, give the boundary of a geographical area. The sequence may be a serious of resources, each with a latitude and longitude, or a series of points using the datatype place:latlong. If the final point is the same as the first then the boundary is considered to be a closed area, whereas if the first and last points differ the boundary is considered to be a border line.
    /// <see href="http://purl.org/ontology/places#Boundary"></see></summary>
    let Boundary = Namespaced_IRI.parse _namespace_name "Boundary" |> NamespacedName
    /// <summary>
    /// A strip of land projecting into a body of water
    /// <see href="http://purl.org/ontology/places#Cape"></see></summary>
    let Cape = Namespaced_IRI.parse _namespace_name "Cape" |> NamespacedName
    /// <summary>
    /// A large settlement, often with some form of formal political recognition.
    /// <see href="http://purl.org/ontology/places#City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName
    /// <summary>
    /// A steep high face of rock.
    /// <see href="http://purl.org/ontology/places#Cliff"></see></summary>
    let Cliff = Namespaced_IRI.parse _namespace_name "Cliff" |> NamespacedName
    /// <summary>
    /// A large landmass recognised by convention as a continent.
    /// <see href="http://purl.org/ontology/places#Continent"></see></summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName
    /// <summary>
    /// A region considered to be the territory of a recognised political state.
    /// <see href="http://purl.org/ontology/places#Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    /// A county is a land area of local governance within a country. A county may have cities and towns within its area.
    /// <see href="http://purl.org/ontology/places#County"></see></summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName
    /// <summary>
    /// A desert is a landscape or region that receives an extremely low amount of precipitation, less than enough to support growth of most plants.
    /// <see href="http://purl.org/ontology/places#Desert"></see></summary>
    let Desert = Namespaced_IRI.parse _namespace_name "Desert" |> NamespacedName
    /// <summary>
    /// A region of governance.
    /// <see href="http://purl.org/ontology/places#District"></see></summary>
    let District = Namespaced_IRI.parse _namespace_name "District" |> NamespacedName
    /// <summary>
    /// The widened area of a river as it opens to meet the sea or ocean.
    /// <see href="http://purl.org/ontology/places#Estuary"></see></summary>
    let Estuary = Namespaced_IRI.parse _namespace_name "Estuary" |> NamespacedName
    /// <summary>
    /// A slow-moving mass of ice.
    /// <see href="http://purl.org/ontology/places#Glacier"></see></summary>
    let Glacier = Namespaced_IRI.parse _namespace_name "Glacier" |> NamespacedName
    /// <summary>
    /// Part of a sea or ocean that is partially enclosed by land. Like a bay but larger.
    /// <see href="http://purl.org/ontology/places#Gulf"></see></summary>
    let Gulf = Namespaced_IRI.parse _namespace_name "Gulf" |> NamespacedName
    /// <summary>
    /// A Hamlet is a small human settlement consisting of just a few dwellings.
    /// <see href="http://purl.org/ontology/places#Hamlet"></see></summary>
    let Hamlet = Namespaced_IRI.parse _namespace_name "Hamlet" |> NamespacedName
    /// <summary>
    /// A hill is a landform that extends above the surrounding terrain.
    /// <see href="http://purl.org/ontology/places#Hill"></see></summary>
    let Hill = Namespaced_IRI.parse _namespace_name "Hill" |> NamespacedName
    /// <summary>
    /// A landmass surrounded entirely by water.
    /// <see href="http://purl.org/ontology/places#Island"></see></summary>
    let Island = Namespaced_IRI.parse _namespace_name "Island" |> NamespacedName
    /// <summary>
    /// A narrow strip of land, bounded by water on two sides, and connecting two larger landmasses.
    /// <see href="http://purl.org/ontology/places#Isthmus"></see></summary>
    let Isthmus = Namespaced_IRI.parse _namespace_name "Isthmus" |> NamespacedName
    /// <summary>
    /// An inland body of water.
    /// <see href="http://purl.org/ontology/places#Lake"></see></summary>
    let Lake = Namespaced_IRI.parse _namespace_name "Lake" |> NamespacedName
    /// <summary>
    /// A piece of land, useful in combination with Continent, Plate and others.
    /// <see href="http://purl.org/ontology/places#LandMass"></see></summary>
    let LandMass = Namespaced_IRI.parse _namespace_name "LandMass" |> NamespacedName
    /// <summary>
    /// A mountain is a large landform that stretches above the surrounding land in a limited area usually in the form of a peak. A mountain is generally steeper than a hill.
    /// <see href="http://purl.org/ontology/places#Mountain"></see></summary>
    let Mountain = Namespaced_IRI.parse _namespace_name "Mountain" |> NamespacedName

    /// <summary>
    /// A region of governance, often self-governed.
    /// <see href="http://purl.org/ontology/places#Municipality"></see></summary>
    let Municipality =
        Namespaced_IRI.parse _namespace_name "Municipality" |> NamespacedName

    /// <summary>
    /// A major body of salt water.
    /// <see href="http://purl.org/ontology/places#Ocean"></see></summary>
    let Ocean = Namespaced_IRI.parse _namespace_name "Ocean" |> NamespacedName
    /// <summary>
    /// An area of regional governance stemming from the geographical area associated with a church.
    /// <see href="http://purl.org/ontology/places#Parish"></see></summary>
    let Parish = Namespaced_IRI.parse _namespace_name "Parish" |> NamespacedName
    /// <summary>
    ///  A Path is a recognised and maintained route from one place to another that is suitable for pedestrians.
    /// <see href="http://purl.org/ontology/places#Path"></see></summary>
    let Path = Namespaced_IRI.parse _namespace_name "Path" |> NamespacedName
    /// <summary>
    /// A landmass projecting out into a body of water.
    /// <see href="http://purl.org/ontology/places#Peninsula"></see></summary>
    let Peninsula = Namespaced_IRI.parse _namespace_name "Peninsula" |> NamespacedName
    /// <summary>
    /// A level area of land.
    /// <see href="http://purl.org/ontology/places#Plain"></see></summary>
    let Plain = Namespaced_IRI.parse _namespace_name "Plain" |> NamespacedName
    /// <summary>
    /// A geological plate, a piece of the earth’s crust. Useful for geological descriptions involving the movement and separation of continents.
    /// <see href="http://purl.org/ontology/places#Plate"></see></summary>
    let Plate = Namespaced_IRI.parse _namespace_name "Plate" |> NamespacedName
    /// <summary>
    /// A flat highland, a large area of flat land higher than the surrounding land.
    /// <see href="http://purl.org/ontology/places#Plateau"></see></summary>
    let Plateau = Namespaced_IRI.parse _namespace_name "Plateau" |> NamespacedName
    /// <summary>
    /// A region of governance.
    /// <see href="http://purl.org/ontology/places#Province"></see></summary>
    let Province = Namespaced_IRI.parse _namespace_name "Province" |> NamespacedName
    /// <summary>
    /// A politically or culturally recognised area.
    /// <see href="http://purl.org/ontology/places#Region"></see></summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName
    /// <summary>
    /// A man-made or natural lake used for the storage and regulation of a water supply.
    /// <see href="http://purl.org/ontology/places#Reservoir"></see></summary>
    let Reservoir = Namespaced_IRI.parse _namespace_name "Reservoir" |> NamespacedName
    /// <summary>
    /// A long elevation or striation in the land.
    /// <see href="http://purl.org/ontology/places#Ridge"></see></summary>
    let Ridge = Namespaced_IRI.parse _namespace_name "Ridge" |> NamespacedName
    /// <summary>
    /// A natural watercourse flowing towards an ocean, sea or lake.
    /// <see href="http://purl.org/ontology/places#River"></see></summary>
    let River = Namespaced_IRI.parse _namespace_name "River" |> NamespacedName
    /// <summary>
    /// A Road is a recognised and maintained route from one place to another that is suitable for vehicles.
    /// <see href="http://purl.org/ontology/places#Road"></see></summary>
    let Road = Namespaced_IRI.parse _namespace_name "Road" |> NamespacedName
    /// <summary>
    /// A large body of salt water, usually connected to an ocean.
    /// <see href="http://purl.org/ontology/places#Sea"></see></summary>
    let Sea = Namespaced_IRI.parse _namespace_name "Sea" |> NamespacedName
    /// <summary>
    /// A Settlement is an area of land inhabited by humans and usually having buildings.
    /// <see href="http://purl.org/ontology/places#Settlement"></see></summary>
    let Settlement = Namespaced_IRI.parse _namespace_name "Settlement" |> NamespacedName
    /// <summary>
    /// A State is a land area of governance within a country. A state may have counties, cities and towns within its area.
    /// <see href="http://purl.org/ontology/places#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// A narrow channel of a sea joining two larger bodies of water.
    /// <see href="http://purl.org/ontology/places#Strait"></see></summary>
    let Strait = Namespaced_IRI.parse _namespace_name "Strait" |> NamespacedName
    /// <summary>
    /// A settlement smaller than a city but larger than a village.
    /// <see href="http://purl.org/ontology/places#Town"></see></summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName
    /// <summary>
    /// A settlement and geographic area, less formally recognised than a town.
    /// <see href="http://purl.org/ontology/places#Township"></see></summary>
    let Township = Namespaced_IRI.parse _namespace_name "Township" |> NamespacedName
    /// <summary>
    /// A depressed area of land, often between mountains and often containing a river.
    /// <see href="http://purl.org/ontology/places#Valley"></see></summary>
    let Valley = Namespaced_IRI.parse _namespace_name "Valley" |> NamespacedName
    /// <summary>
    /// A small human settlement.
    /// <see href="http://purl.org/ontology/places#Village"></see></summary>
    let Village = Namespaced_IRI.parse _namespace_name "Village" |> NamespacedName
    /// <summary>
    /// A volcano is a crack in the Earth's crust that allows lava and hot gases to escape.
    /// <see href="http://purl.org/ontology/places#Volcano"></see></summary>
    let Volcano = Namespaced_IRI.parse _namespace_name "Volcano" |> NamespacedName
    /// <summary>
    /// A ridge of land seperating two adjacent water systems.
    /// <see href="http://purl.org/ontology/places#Watershed"></see></summary>
    let Watershed = Namespaced_IRI.parse _namespace_name "Watershed" |> NamespacedName
    /// <summary>
    /// The bounded by property relates any place to a boundary that marks out the geographic area it covers.
    /// <see href="http://purl.org/ontology/places#bounded_by"></see></summary>
    let bounded_by = Namespaced_IRI.parse _namespace_name "bounded_by" |> NamespacedName
    /// <summary>
    /// in is a property that allows you to say that a place is entirely within the boundaries of another place. It allows you to make statements like "Paris is in france".
    /// <see href="http://purl.org/ontology/places#in"></see></summary>
    let in_ = Namespaced_IRI.parse _namespace_name "in" |> NamespacedName
    /// <summary>
    /// The Lat/long datatype allows us to specify that a literal value is a latitude/longitude pair, based in the WGS84 projection and in the comma-seperated, decimal format. e.g. "38.897605896,-77.0365219116"^^place:latlong would specify the WGS84 geographic co-ordinates of The White House, Washington DC.
    /// <see href="http://purl.org/ontology/places#latlong"></see></summary>
    let latlong = Namespaced_IRI.parse _namespace_name "latlong" |> NamespacedName
    /// <summary>
    /// Overlaps is a property for saying that a particular place shares an area of land with another place but that neither place is entirely within the other.
    /// <see href="http://purl.org/ontology/places#overlaps"></see></summary>
    let overlaps = Namespaced_IRI.parse _namespace_name "overlaps" |> NamespacedName

    /// <summary>
    /// The point on map property indicates where a place should be shown by a pin on a map.
    /// <see href="http://purl.org/ontology/places#point_on_map"></see></summary>
    let point_on_map =
        Namespaced_IRI.parse _namespace_name "point_on_map" |> NamespacedName
