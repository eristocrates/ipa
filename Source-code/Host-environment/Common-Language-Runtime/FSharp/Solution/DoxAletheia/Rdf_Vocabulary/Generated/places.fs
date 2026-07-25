namespace http.purl.org.ontology.places.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module places =
    let _namespace_iri = Namespace_Iri places |> NamespaceIRI
    /// <summary>
    ///   <para>places:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A large landmass recognised by convention as a continent.</para>
    /// labels<para>Continente</para><para>Continent</para><para>Continent</para><para>Kontinent</para><para>Continent</para><para>大陆</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Continent">http://purl.org/ontology/places#Continent</seealso>
    let Continent = Prefixed_Name(places, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>places:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/places#">http://purl.org/ontology/places#</seealso>
    let _prefix_iri = Prefixed_Name(places, "") |> PrefixedName
    /// <summary>
    ///   <para>places:Bay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An indentation to a shoreline, a body of water enclosed but with a large mouth to a wider body of water.</para>
    /// labels<para>Bahía</para><para>Bay</para><para>Bay</para><para>Bay</para><para>Bay</para><para>湾</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Bay">http://purl.org/ontology/places#Bay</seealso>
    let Bay = Prefixed_Name(places, "Bay") |> PrefixedName
    /// <summary>
    ///   <para>places:Village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A small human settlement.</para>
    /// labels<para>Village</para><para>Village</para><para>Village</para><para>Village</para><para>Pueblo</para><para>村</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Village">http://purl.org/ontology/places#Village</seealso>
    let Village = Prefixed_Name(places, "Village") |> PrefixedName
    /// <summary>
    ///   <para>places:ArbitraryRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area that is useful to illustrate a particular point but does not have a recognised political or cultural identity.</para>
    /// labels<para>Willkürliche Region</para><para>Arbitraria Región</para><para>Région Arbitraire</para><para>Arbitrary Region</para><para>ArbitraryRegion</para><para>任意区域</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#ArbitraryRegion">http://purl.org/ontology/places#ArbitraryRegion</seealso>
    let ArbitraryRegion = Prefixed_Name(places, "ArbitraryRegion") |> PrefixedName
    /// <summary>
    ///   <para>places:Beach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The shore of a body of water, usually sandy or pebbly.</para>
    /// labels<para>Beach</para><para>Playa</para><para>Beach</para><para>Beach</para><para>Beach</para><para>海滩</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Beach">http://purl.org/ontology/places#Beach</seealso>
    let Beach = Prefixed_Name(places, "Beach") |> PrefixedName
    /// <summary>
    ///   <para>places:Borough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An administrative region of governance.</para>
    /// labels<para>Arrondissement</para><para>Municipio</para><para>Borough</para><para>Borough</para><para>Bezirk</para><para>伯勒</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Borough">http://purl.org/ontology/places#Borough</seealso>
    let Borough = Prefixed_Name(places, "Borough") |> PrefixedName
    /// <summary>
    ///   <para>places:Boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Boundary resource specifies a sequence of points which, if joined, give the boundary of a geographical area. The sequence may be a serious of resources, each with a latitude and longitude, or a series of points using the datatype place:latlong. If the final point is the same as the first then the boundary is considered to be a closed area, whereas if the first and last points differ the boundary is considered to be a border line.</para>
    /// labels<para>Boundary</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Boundary">http://purl.org/ontology/places#Boundary</seealso>
    let Boundary = Prefixed_Name(places, "Boundary") |> PrefixedName
    /// <summary>
    ///   <para>places:Cape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A strip of land projecting into a body of water</para>
    /// labels<para>Cape</para><para>Cape</para><para>Cabo</para><para>Cape</para><para>Cap</para><para>披肩</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Cape">http://purl.org/ontology/places#Cape</seealso>
    let Cape = Prefixed_Name(places, "Cape") |> PrefixedName
    /// <summary>
    ///   <para>places:latlong</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The Lat/long datatype allows us to specify that a literal value is a latitude/longitude pair, based in the WGS84 projection and in the comma-seperated, decimal format. e.g. "38.897605896,-77.0365219116"^^place:latlong would specify the WGS84 geographic co-ordinates of The White House, Washington DC.</para>
    /// labels<para>Lat/Long</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#latlong">http://purl.org/ontology/places#latlong</seealso>
    let latlong = Prefixed_Name(places, "latlong") |> PrefixedName
    /// <summary>
    ///   <para>places:Hamlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Hamlet is a small human settlement consisting of just a few dwellings.</para>
    /// labels<para>Hamlet</para><para>Hamlet</para><para>Weiler</para><para>Hamlet</para><para>Aldea</para><para>村庄</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Hamlet">http://purl.org/ontology/places#Hamlet</seealso>
    let Hamlet = Prefixed_Name(places, "Hamlet") |> PrefixedName
    /// <summary>
    ///   <para>places:Lake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An inland body of water.</para>
    /// labels<para>Lake</para><para>Lago</para><para>Lake</para><para>Lake</para><para>Lake</para><para>湖</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Lake">http://purl.org/ontology/places#Lake</seealso>
    let Lake = Prefixed_Name(places, "Lake") |> PrefixedName
    /// <summary>
    ///   <para>places:LandMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A piece of land, useful in combination with Continent, Plate and others.</para>
    /// labels<para>La masse continentale</para><para>Masa de tierra</para><para>Landmasse</para><para>Landmass</para><para>LandMass</para><para>陆地</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#LandMass">http://purl.org/ontology/places#LandMass</seealso>
    let LandMass = Prefixed_Name(places, "LandMass") |> PrefixedName
    /// <summary>
    ///   <para>places:Mountain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mountain is a large landform that stretches above the surrounding land in a limited area usually in the form of a peak. A mountain is generally steeper than a hill.</para>
    /// labels<para>Mountain</para><para>Mountain</para><para>Mountain</para><para>Mountain</para><para>Montaña</para><para>山</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Mountain">http://purl.org/ontology/places#Mountain</seealso>
    let Mountain = Prefixed_Name(places, "Mountain") |> PrefixedName
    /// <summary>
    ///   <para>places:Municipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A region of governance, often self-governed.</para>
    /// labels<para>Municipalité</para><para>Municipality</para><para>Municipality</para><para>Municipio</para><para>Gemeinde</para><para>市</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Municipality">http://purl.org/ontology/places#Municipality</seealso>
    let Municipality = Prefixed_Name(places, "Municipality") |> PrefixedName
    /// <summary>
    ///   <para>places:Ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A major body of salt water.</para>
    /// labels<para>Ocean</para><para>Ocean</para><para>Ocean</para><para>Ocean</para><para>Mar</para><para>海洋</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Ocean">http://purl.org/ontology/places#Ocean</seealso>
    let Ocean = Prefixed_Name(places, "Ocean") |> PrefixedName
    /// <summary>
    ///   <para>places:Peninsula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A landmass projecting out into a body of water.</para>
    /// labels<para>Halbinsel</para><para>Península</para><para>Péninsule</para><para>Peninsula</para><para>Peninsula</para><para>半岛</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Peninsula">http://purl.org/ontology/places#Peninsula</seealso>
    let Peninsula = Prefixed_Name(places, "Peninsula") |> PrefixedName
    /// <summary>
    ///   <para>places:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A large settlement, often with some form of formal political recognition.</para>
    /// labels<para>Ciudad</para><para>City</para><para>City</para><para>City</para><para>City</para><para>市</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#City">http://purl.org/ontology/places#City</seealso>
    let City = Prefixed_Name(places, "City") |> PrefixedName
    /// <summary>
    ///   <para>places:Cliff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A steep high face of rock.</para>
    /// labels<para>Acantilado</para><para>Cliff</para><para>Cliff</para><para>Cliff</para><para>Cliff</para><para>悬崖</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Cliff">http://purl.org/ontology/places#Cliff</seealso>
    let Cliff = Prefixed_Name(places, "Cliff") |> PrefixedName
    /// <summary>
    ///   <para>places:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A region considered to be the territory of a recognised political state.</para>
    /// labels<para>Country</para><para>Country</para><para>Land</para><para>Pays</para><para>País</para><para>国家</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Country">http://purl.org/ontology/places#Country</seealso>
    let Country = Prefixed_Name(places, "Country") |> PrefixedName
    /// <summary>
    ///   <para>places:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A county is a land area of local governance within a country. A county may have cities and towns within its area.</para>
    /// labels<para>Condado</para><para>County</para><para>County</para><para>County</para><para>Comté</para><para>县</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#County">http://purl.org/ontology/places#County</seealso>
    let County = Prefixed_Name(places, "County") |> PrefixedName
    /// <summary>
    ///   <para>places:Desert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A desert is a landscape or region that receives an extremely low amount of precipitation, less than enough to support growth of most plants.</para>
    /// labels<para>Desierto</para><para>Desert</para><para>Desert</para><para>Desert</para><para>Desert</para><para>沙漠</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Desert">http://purl.org/ontology/places#Desert</seealso>
    let Desert = Prefixed_Name(places, "Desert") |> PrefixedName
    /// <summary>
    ///   <para>places:District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A region of governance.</para>
    /// labels<para>District</para><para>District</para><para>District</para><para>Distrito</para><para>Bezirk</para><para>区</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#District">http://purl.org/ontology/places#District</seealso>
    let District = Prefixed_Name(places, "District") |> PrefixedName
    /// <summary>
    ///   <para>places:Estuary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The widened area of a river as it opens to meet the sea or ocean.</para>
    /// labels<para>Estuario</para><para>Estuaire</para><para>Estuary</para><para>Estuary</para><para>Mündung</para><para>河口</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Estuary">http://purl.org/ontology/places#Estuary</seealso>
    let Estuary = Prefixed_Name(places, "Estuary") |> PrefixedName
    /// <summary>
    ///   <para>places:Glacier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A slow-moving mass of ice.</para>
    /// labels<para>Gletscher</para><para>Glacier</para><para>Glaciar</para><para>Glacier</para><para>Glacier</para><para>冰川</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Glacier">http://purl.org/ontology/places#Glacier</seealso>
    let Glacier = Prefixed_Name(places, "Glacier") |> PrefixedName
    /// <summary>
    ///   <para>places:Gulf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Part of a sea or ocean that is partially enclosed by land. Like a bay but larger.</para>
    /// labels<para>Golfe</para><para>Golfo</para><para>Gulf</para><para>Gulf</para><para>Gulf</para><para>海湾</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Gulf">http://purl.org/ontology/places#Gulf</seealso>
    let Gulf = Prefixed_Name(places, "Gulf") |> PrefixedName
    /// <summary>
    ///   <para>places:Hill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A hill is a landform that extends above the surrounding terrain.</para>
    /// labels<para>Hill</para><para>Hill</para><para>Hill</para><para>Hill</para><para>Hill</para><para>希尔</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Hill">http://purl.org/ontology/places#Hill</seealso>
    let Hill = Prefixed_Name(places, "Hill") |> PrefixedName
    /// <summary>
    ///   <para>places:Island</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A landmass surrounded entirely by water.</para>
    /// labels<para>Island</para><para>Island</para><para>Island</para><para>Island</para><para>Isla</para><para>岛</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Island">http://purl.org/ontology/places#Island</seealso>
    let Island = Prefixed_Name(places, "Island") |> PrefixedName
    /// <summary>
    ///   <para>places:Isthmus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A narrow strip of land, bounded by water on two sides, and connecting two larger landmasses.</para>
    /// labels<para>Isthmus</para><para>Isthmus</para><para>Isthmus</para><para>Isthme</para><para>Istmo</para><para>地峡</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Isthmus">http://purl.org/ontology/places#Isthmus</seealso>
    let Isthmus = Prefixed_Name(places, "Isthmus") |> PrefixedName
    /// <summary>
    ///   <para>places:Parish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area of regional governance stemming from the geographical area associated with a church.</para>
    /// labels<para>Parroquia</para><para>Paroisse</para><para>Gemeinde</para><para>Parish</para><para>Parish</para><para>教区</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Parish">http://purl.org/ontology/places#Parish</seealso>
    let Parish = Prefixed_Name(places, "Parish") |> PrefixedName
    /// <summary>
    ///   <para>places:Path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> A Path is a recognised and maintained route from one place to another that is suitable for pedestrians.</para>
    /// labels<para>Ruta</para><para>Path</para><para>Path</para><para>Path</para><para>Path</para><para>路径</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Path">http://purl.org/ontology/places#Path</seealso>
    let Path = Prefixed_Name(places, "Path") |> PrefixedName
    /// <summary>
    ///   <para>places:Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A level area of land.</para>
    /// labels<para>Llanura</para><para>Plain</para><para>Plain</para><para>Plain</para><para>Plain</para><para>平原</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Plain">http://purl.org/ontology/places#Plain</seealso>
    let Plain = Prefixed_Name(places, "Plain") |> PrefixedName
    /// <summary>
    ///   <para>places:Plate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geological plate, a piece of the earth’s crust. Useful for geological descriptions involving the movement and separation of continents.</para>
    /// labels<para>Plate</para><para>Plate</para><para>Placa</para><para>Tafel</para><para>Plate</para><para>板</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Plate">http://purl.org/ontology/places#Plate</seealso>
    let Plate = Prefixed_Name(places, "Plate") |> PrefixedName
    /// <summary>
    ///   <para>places:Plateau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A flat highland, a large area of flat land higher than the surrounding land.</para>
    /// labels<para>Plateau</para><para>Plateau</para><para>Plateau</para><para>Plateau</para><para>Meseta</para><para>高原</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Plateau">http://purl.org/ontology/places#Plateau</seealso>
    let Plateau = Prefixed_Name(places, "Plateau") |> PrefixedName
    /// <summary>
    ///   <para>places:Province</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A region of governance.</para>
    /// labels<para>Provincia</para><para>Province</para><para>Province</para><para>Province</para><para>Provinz</para><para>省</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Province">http://purl.org/ontology/places#Province</seealso>
    let Province = Prefixed_Name(places, "Province") |> PrefixedName
    /// <summary>
    ///   <para>places:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A politically or culturally recognised area.</para>
    /// labels<para>Región</para><para>Region</para><para>Region</para><para>Région</para><para>Region</para><para>区</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Region">http://purl.org/ontology/places#Region</seealso>
    let Region = Prefixed_Name(places, "Region") |> PrefixedName
    /// <summary>
    ///   <para>places:Reservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A man-made or natural lake used for the storage and regulation of a water supply.</para>
    /// labels<para>Reservoir</para><para>Reservoir</para><para>Reservoir</para><para>Réservoir</para><para>Depósito</para><para>水库</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Reservoir">http://purl.org/ontology/places#Reservoir</seealso>
    let Reservoir = Prefixed_Name(places, "Reservoir") |> PrefixedName
    /// <summary>
    ///   <para>places:River</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A natural watercourse flowing towards an ocean, sea or lake.</para>
    /// labels<para>River</para><para>River</para><para>River</para><para>River</para><para>Río</para><para>河</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#River">http://purl.org/ontology/places#River</seealso>
    let River = Prefixed_Name(places, "River") |> PrefixedName
    /// <summary>
    ///   <para>places:Road</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Road is a recognised and maintained route from one place to another that is suitable for vehicles.</para>
    /// labels<para>Por carretera</para><para>Road</para><para>Road</para><para>Road</para><para>Road</para><para>路</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Road">http://purl.org/ontology/places#Road</seealso>
    let Road = Prefixed_Name(places, "Road") |> PrefixedName
    /// <summary>
    ///   <para>places:Settlement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Settlement is an area of land inhabited by humans and usually having buildings.</para>
    /// labels<para>Liquidación</para><para>Settlement</para><para>Settlement</para><para>Règlement</para><para>Siedlung</para><para>解决</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Settlement">http://purl.org/ontology/places#Settlement</seealso>
    let Settlement = Prefixed_Name(places, "Settlement") |> PrefixedName
    /// <summary>
    ///   <para>places:Strait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A narrow channel of a sea joining two larger bodies of water.</para>
    /// labels<para>Meerenge</para><para>Estrecho</para><para>Détroit</para><para>Strait</para><para>Strait</para><para>海峡</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Strait">http://purl.org/ontology/places#Strait</seealso>
    let Strait = Prefixed_Name(places, "Strait") |> PrefixedName
    /// <summary>
    ///   <para>places:Town</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A settlement smaller than a city but larger than a village.</para>
    /// labels<para>Ciudad</para><para>Ville</para><para>Town</para><para>Town</para><para>Town</para><para>镇</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Town">http://purl.org/ontology/places#Town</seealso>
    let Town = Prefixed_Name(places, "Town") |> PrefixedName
    /// <summary>
    ///   <para>places:Township</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A settlement and geographic area, less formally recognised than a town.</para>
    /// labels<para>Municipio</para><para>Township</para><para>Township</para><para>Township</para><para>Canton</para><para>乡</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Township">http://purl.org/ontology/places#Township</seealso>
    let Township = Prefixed_Name(places, "Township") |> PrefixedName
    /// <summary>
    ///   <para>places:Valley</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A depressed area of land, often between mountains and often containing a river.</para>
    /// labels<para>Vallée</para><para>Valley</para><para>Valley</para><para>Valley</para><para>Valle</para><para>谷</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Valley">http://purl.org/ontology/places#Valley</seealso>
    let Valley = Prefixed_Name(places, "Valley") |> PrefixedName
    /// <summary>
    ///   <para>places:Volcano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A volcano is a crack in the Earth's crust that allows lava and hot gases to escape.</para>
    /// labels<para>Volcano</para><para>Volcano</para><para>Volcan</para><para>Vulkan</para><para>Volcán</para><para>火山</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Volcano">http://purl.org/ontology/places#Volcano</seealso>
    let Volcano = Prefixed_Name(places, "Volcano") |> PrefixedName
    /// <summary>
    ///   <para>places:Watershed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A ridge of land seperating two adjacent water systems.</para>
    /// labels<para>Des bassins versants</para><para>Wasserscheide</para><para>Watershed</para><para>Watershed</para><para>Cuencas</para><para>流域</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Watershed">http://purl.org/ontology/places#Watershed</seealso>
    let Watershed = Prefixed_Name(places, "Watershed") |> PrefixedName
    /// <summary>
    ///   <para>places:bounded_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The bounded by property relates any place to a boundary that marks out the geographic area it covers.</para>
    /// labels<para>bounded by</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#bounded_by">http://purl.org/ontology/places#bounded_by</seealso>
    let bounded_by = Prefixed_Name(places, "bounded_by") |> PrefixedName
    /// <summary>
    ///   <para>places:in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>in is a property that allows you to say that a place is entirely within the boundaries of another place. It allows you to make statements like "Paris is in france".</para>
    /// labels<para>dans</para><para>in</para><para>in</para><para>en</para><para>in</para><para>在</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#in">http://purl.org/ontology/places#in</seealso>
    let in_ = Prefixed_Name(places, "in") |> PrefixedName
    /// <summary>
    ///   <para>places:overlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Overlaps is a property for saying that a particular place shares an area of land with another place but that neither place is entirely within the other.</para>
    /// labels<para>Überschneidungen</para><para>chevauchements</para><para>solapamientos</para><para>overlaps</para><para>overlaps</para><para>重叠</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#overlaps">http://purl.org/ontology/places#overlaps</seealso>
    let overlaps = Prefixed_Name(places, "overlaps") |> PrefixedName
    /// <summary>
    ///   <para>places:point_on_map</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The point on map property indicates where a place should be shown by a pin on a map.</para>
    /// labels<para>Point on map</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#point_on_map">http://purl.org/ontology/places#point_on_map</seealso>
    let point_on_map = Prefixed_Name(places, "point_on_map") |> PrefixedName
    /// <summary>
    ///   <para>places:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A State is a land area of governance within a country. A state may have counties, cities and towns within its area.</para>
    /// labels<para>Estado</para><para>Staat</para><para>State</para><para>State</para><para>État</para><para>国家</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#State">http://purl.org/ontology/places#State</seealso>
    let State = Prefixed_Name(places, "State") |> PrefixedName
    /// <summary>
    ///   <para>places:Ridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A long elevation or striation in the land.</para>
    /// labels<para>Ridge</para><para>Ridge</para><para>Ridge</para><para>Ridge</para><para>Ridge</para><para>脊</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Ridge">http://purl.org/ontology/places#Ridge</seealso>
    let Ridge = Prefixed_Name(places, "Ridge") |> PrefixedName
    /// <summary>
    ///   <para>places:Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A large body of salt water, usually connected to an ocean.</para>
    /// labels<para>Mer</para><para>Sea</para><para>Mar</para><para>Sea</para><para>Sea</para><para>海</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Sea">http://purl.org/ontology/places#Sea</seealso>
    let Sea = Prefixed_Name(places, "Sea") |> PrefixedName
