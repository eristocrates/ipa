namespace http.purl.org.ontology.places.hash

open DoxAletheia

module places =
    let _namespace_name = "http://purl.org/ontology/places#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An area that is useful to illustrate a particular point but does not have a recognised political or cultural identity.
    /// <see href="http://purl.org/ontology/places#ArbitraryRegion"></see></summary>
    let ArbitraryRegion = _prefix "ArbitraryRegion"
    /// <summary>
    /// An indentation to a shoreline, a body of water enclosed but with a large mouth to a wider body of water.
    /// <see href="http://purl.org/ontology/places#Bay"></see></summary>
    let Bay = _prefix "Bay"
    /// <summary>
    /// The shore of a body of water, usually sandy or pebbly.
    /// <see href="http://purl.org/ontology/places#Beach"></see></summary>
    let Beach = _prefix "Beach"
    /// <summary>
    /// An administrative region of governance.
    /// <see href="http://purl.org/ontology/places#Borough"></see></summary>
    let Borough = _prefix "Borough"
    /// <summary>
    /// A Boundary resource specifies a sequence of points which, if joined, give the boundary of a geographical area. The sequence may be a serious of resources, each with a latitude and longitude, or a series of points using the datatype place:latlong. If the final point is the same as the first then the boundary is considered to be a closed area, whereas if the first and last points differ the boundary is considered to be a border line.
    /// <see href="http://purl.org/ontology/places#Boundary"></see></summary>
    let Boundary = _prefix "Boundary"
    /// <summary>
    /// A strip of land projecting into a body of water
    /// <see href="http://purl.org/ontology/places#Cape"></see></summary>
    let Cape = _prefix "Cape"
    /// <summary>
    /// A large settlement, often with some form of formal political recognition.
    /// <see href="http://purl.org/ontology/places#City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// A steep high face of rock.
    /// <see href="http://purl.org/ontology/places#Cliff"></see></summary>
    let Cliff = _prefix "Cliff"
    /// <summary>
    /// A large landmass recognised by convention as a continent.
    /// <see href="http://purl.org/ontology/places#Continent"></see></summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// A region considered to be the territory of a recognised political state.
    /// <see href="http://purl.org/ontology/places#Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// A county is a land area of local governance within a country. A county may have cities and towns within its area.
    /// <see href="http://purl.org/ontology/places#County"></see></summary>
    let County = _prefix "County"
    /// <summary>
    /// A desert is a landscape or region that receives an extremely low amount of precipitation, less than enough to support growth of most plants.
    /// <see href="http://purl.org/ontology/places#Desert"></see></summary>
    let Desert = _prefix "Desert"
    /// <summary>
    /// A region of governance.
    /// <see href="http://purl.org/ontology/places#District"></see></summary>
    let District = _prefix "District"
    /// <summary>
    /// The widened area of a river as it opens to meet the sea or ocean.
    /// <see href="http://purl.org/ontology/places#Estuary"></see></summary>
    let Estuary = _prefix "Estuary"
    /// <summary>
    /// A slow-moving mass of ice.
    /// <see href="http://purl.org/ontology/places#Glacier"></see></summary>
    let Glacier = _prefix "Glacier"
    /// <summary>
    /// Part of a sea or ocean that is partially enclosed by land. Like a bay but larger.
    /// <see href="http://purl.org/ontology/places#Gulf"></see></summary>
    let Gulf = _prefix "Gulf"
    /// <summary>
    /// A Hamlet is a small human settlement consisting of just a few dwellings.
    /// <see href="http://purl.org/ontology/places#Hamlet"></see></summary>
    let Hamlet = _prefix "Hamlet"
    /// <summary>
    /// A hill is a landform that extends above the surrounding terrain.
    /// <see href="http://purl.org/ontology/places#Hill"></see></summary>
    let Hill = _prefix "Hill"
    /// <summary>
    /// A landmass surrounded entirely by water.
    /// <see href="http://purl.org/ontology/places#Island"></see></summary>
    let Island = _prefix "Island"
    /// <summary>
    /// A narrow strip of land, bounded by water on two sides, and connecting two larger landmasses.
    /// <see href="http://purl.org/ontology/places#Isthmus"></see></summary>
    let Isthmus = _prefix "Isthmus"
    /// <summary>
    /// An inland body of water.
    /// <see href="http://purl.org/ontology/places#Lake"></see></summary>
    let Lake = _prefix "Lake"
    /// <summary>
    /// A piece of land, useful in combination with Continent, Plate and others.
    /// <see href="http://purl.org/ontology/places#LandMass"></see></summary>
    let LandMass = _prefix "LandMass"
    /// <summary>
    /// A mountain is a large landform that stretches above the surrounding land in a limited area usually in the form of a peak. A mountain is generally steeper than a hill.
    /// <see href="http://purl.org/ontology/places#Mountain"></see></summary>
    let Mountain = _prefix "Mountain"
    /// <summary>
    /// A region of governance, often self-governed.
    /// <see href="http://purl.org/ontology/places#Municipality"></see></summary>
    let Municipality = _prefix "Municipality"
    /// <summary>
    /// A major body of salt water.
    /// <see href="http://purl.org/ontology/places#Ocean"></see></summary>
    let Ocean = _prefix "Ocean"
    /// <summary>
    /// An area of regional governance stemming from the geographical area associated with a church.
    /// <see href="http://purl.org/ontology/places#Parish"></see></summary>
    let Parish = _prefix "Parish"
    /// <summary>
    ///  A Path is a recognised and maintained route from one place to another that is suitable for pedestrians.
    /// <see href="http://purl.org/ontology/places#Path"></see></summary>
    let Path = _prefix "Path"
    /// <summary>
    /// A landmass projecting out into a body of water.
    /// <see href="http://purl.org/ontology/places#Peninsula"></see></summary>
    let Peninsula = _prefix "Peninsula"
    /// <summary>
    /// A level area of land.
    /// <see href="http://purl.org/ontology/places#Plain"></see></summary>
    let Plain = _prefix "Plain"
    /// <summary>
    /// A geological plate, a piece of the earth’s crust. Useful for geological descriptions involving the movement and separation of continents.
    /// <see href="http://purl.org/ontology/places#Plate"></see></summary>
    let Plate = _prefix "Plate"
    /// <summary>
    /// A flat highland, a large area of flat land higher than the surrounding land.
    /// <see href="http://purl.org/ontology/places#Plateau"></see></summary>
    let Plateau = _prefix "Plateau"
    /// <summary>
    /// A region of governance.
    /// <see href="http://purl.org/ontology/places#Province"></see></summary>
    let Province = _prefix "Province"
    /// <summary>
    /// A politically or culturally recognised area.
    /// <see href="http://purl.org/ontology/places#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    /// A man-made or natural lake used for the storage and regulation of a water supply.
    /// <see href="http://purl.org/ontology/places#Reservoir"></see></summary>
    let Reservoir = _prefix "Reservoir"
    /// <summary>
    /// A long elevation or striation in the land.
    /// <see href="http://purl.org/ontology/places#Ridge"></see></summary>
    let Ridge = _prefix "Ridge"
    /// <summary>
    /// A natural watercourse flowing towards an ocean, sea or lake.
    /// <see href="http://purl.org/ontology/places#River"></see></summary>
    let River = _prefix "River"
    /// <summary>
    /// A Road is a recognised and maintained route from one place to another that is suitable for vehicles.
    /// <see href="http://purl.org/ontology/places#Road"></see></summary>
    let Road = _prefix "Road"
    /// <summary>
    /// A large body of salt water, usually connected to an ocean.
    /// <see href="http://purl.org/ontology/places#Sea"></see></summary>
    let Sea = _prefix "Sea"
    /// <summary>
    /// A Settlement is an area of land inhabited by humans and usually having buildings.
    /// <see href="http://purl.org/ontology/places#Settlement"></see></summary>
    let Settlement = _prefix "Settlement"
    /// <summary>
    /// A State is a land area of governance within a country. A state may have counties, cities and towns within its area.
    /// <see href="http://purl.org/ontology/places#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// A narrow channel of a sea joining two larger bodies of water.
    /// <see href="http://purl.org/ontology/places#Strait"></see></summary>
    let Strait = _prefix "Strait"
    /// <summary>
    /// A settlement smaller than a city but larger than a village.
    /// <see href="http://purl.org/ontology/places#Town"></see></summary>
    let Town = _prefix "Town"
    /// <summary>
    /// A settlement and geographic area, less formally recognised than a town.
    /// <see href="http://purl.org/ontology/places#Township"></see></summary>
    let Township = _prefix "Township"
    /// <summary>
    /// A depressed area of land, often between mountains and often containing a river.
    /// <see href="http://purl.org/ontology/places#Valley"></see></summary>
    let Valley = _prefix "Valley"
    /// <summary>
    /// A small human settlement.
    /// <see href="http://purl.org/ontology/places#Village"></see></summary>
    let Village = _prefix "Village"
    /// <summary>
    /// A volcano is a crack in the Earth's crust that allows lava and hot gases to escape.
    /// <see href="http://purl.org/ontology/places#Volcano"></see></summary>
    let Volcano = _prefix "Volcano"
    /// <summary>
    /// A ridge of land seperating two adjacent water systems.
    /// <see href="http://purl.org/ontology/places#Watershed"></see></summary>
    let Watershed = _prefix "Watershed"
    /// <summary>
    /// The bounded by property relates any place to a boundary that marks out the geographic area it covers.
    /// <see href="http://purl.org/ontology/places#bounded_by"></see></summary>
    let bounded_by = _prefix "bounded_by"
    /// <summary>
    /// in is a property that allows you to say that a place is entirely within the boundaries of another place. It allows you to make statements like "Paris is in france".
    /// <see href="http://purl.org/ontology/places#in"></see></summary>
    let in_ = _prefix "in"
    /// <summary>
    /// The Lat/long datatype allows us to specify that a literal value is a latitude/longitude pair, based in the WGS84 projection and in the comma-seperated, decimal format. e.g. "38.897605896,-77.0365219116"^^place:latlong would specify the WGS84 geographic co-ordinates of The White House, Washington DC.
    /// <see href="http://purl.org/ontology/places#latlong"></see></summary>
    let latlong = _prefix "latlong"
    /// <summary>
    /// Overlaps is a property for saying that a particular place shares an area of land with another place but that neither place is entirely within the other.
    /// <see href="http://purl.org/ontology/places#overlaps"></see></summary>
    let overlaps = _prefix "overlaps"
    /// <summary>
    /// The point on map property indicates where a place should be shown by a pin on a map.
    /// <see href="http://purl.org/ontology/places#point_on_map"></see></summary>
    let point_on_map = _prefix "point_on_map"
