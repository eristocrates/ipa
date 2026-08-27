namespace http.purl.org.ontology.places.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module places =
    let _namespace_iri = Namespace_Iri places |> NamespaceIRI
    /// <summary>
    ///   <para>places:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/places#">http://purl.org/ontology/places#</seealso>
    let _prefix_iri = Prefixed_Name(places, "") |> PrefixedName
    /// <summary>
    ///   <para>places:ArbitraryRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area that is useful to illustrate a particular point but does not have a recognised political or cultural identity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"任意区域"</para><para>"Arbitraria Región"</para><para>"Région Arbitraire"</para><para>"Willkürliche Region"</para><para>"Arbitrary Region"</para><para>"ArbitraryRegion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#ArbitraryRegion">http://purl.org/ontology/places#ArbitraryRegion</seealso>
    let ArbitraryRegion = Prefixed_Name(places, "ArbitraryRegion") |> PrefixedName
    /// <summary>
    ///   <para>places:Bay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An indentation to a shoreline, a body of water enclosed but with a large mouth to a wider body of water."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bahía"</para><para>"Bay"</para><para>"Bay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"湾"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Bay">http://purl.org/ontology/places#Bay</seealso>
    let Bay = Prefixed_Name(places, "Bay") |> PrefixedName
    /// <summary>
    ///   <para>places:Beach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The shore of a body of water, usually sandy or pebbly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Beach"</para><para>"Beach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Playa"</para><para>"海滩"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Beach">http://purl.org/ontology/places#Beach</seealso>
    let Beach = Prefixed_Name(places, "Beach") |> PrefixedName
    /// <summary>
    ///   <para>places:Borough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An administrative region of governance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"伯勒"</para><para>"Borough"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Bezirk"</para><para>"Municipio"</para><para>"Borough"</para><para>"Arrondissement"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Borough">http://purl.org/ontology/places#Borough</seealso>
    let Borough = Prefixed_Name(places, "Borough") |> PrefixedName
    /// <summary>
    ///   <para>places:Boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Boundary resource specifies a sequence of points which, if joined, give the boundary of a geographical area. The sequence may be a serious of resources, each with a latitude and longitude, or a series of points using the datatype place:latlong. If the final point is the same as the first then the boundary is considered to be a closed area, whereas if the first and last points differ the boundary is considered to be a border line."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Boundary">http://purl.org/ontology/places#Boundary</seealso>
    let Boundary = Prefixed_Name(places, "Boundary") |> PrefixedName
    /// <summary>
    ///   <para>places:Cape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A strip of land projecting into a body of water"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cap"</para><para>"Cabo"</para><para>"Cape"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"披肩"</para><para>"Cape"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Cape">http://purl.org/ontology/places#Cape</seealso>
    let Cape = Prefixed_Name(places, "Cape") |> PrefixedName
    /// <summary>
    ///   <para>places:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large settlement, often with some form of formal political recognition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"City"</para><para>"City"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"市"</para><para>"Ciudad"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#City">http://purl.org/ontology/places#City</seealso>
    let City = Prefixed_Name(places, "City") |> PrefixedName
    /// <summary>
    ///   <para>places:Cliff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A steep high face of rock."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acantilado"</para><para>"悬崖"</para><para>"Cliff"</para><para>"Cliff"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Cliff">http://purl.org/ontology/places#Cliff</seealso>
    let Cliff = Prefixed_Name(places, "Cliff") |> PrefixedName
    /// <summary>
    ///   <para>places:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large landmass recognised by convention as a continent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Continent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"大陆"</para><para>"Continente"</para><para>"Continent"</para><para>"Kontinent"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Continent">http://purl.org/ontology/places#Continent</seealso>
    let Continent = Prefixed_Name(places, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>places:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A region considered to be the territory of a recognised political state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Land"</para><para>"Pays"</para><para>"国家"</para><para>"Country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Country"</para><para>"País"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Country">http://purl.org/ontology/places#Country</seealso>
    let Country = Prefixed_Name(places, "Country") |> PrefixedName
    /// <summary>
    ///   <para>places:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A county is a land area of local governance within a country. A county may have cities and towns within its area."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Comté"</para><para>"County"</para><para>"县"</para><para>"County"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Condado"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#County">http://purl.org/ontology/places#County</seealso>
    let County = Prefixed_Name(places, "County") |> PrefixedName
    /// <summary>
    ///   <para>places:Desert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A desert is a landscape or region that receives an extremely low amount of precipitation, less than enough to support growth of most plants."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Desierto"</para><para>"Desert"</para><para>"Desert"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"沙漠"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Desert">http://purl.org/ontology/places#Desert</seealso>
    let Desert = Prefixed_Name(places, "Desert") |> PrefixedName
    /// <summary>
    ///   <para>places:District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A region of governance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"区"</para><para>"District"</para><para>"Distrito"</para><para>"District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Bezirk"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#District">http://purl.org/ontology/places#District</seealso>
    let District = Prefixed_Name(places, "District") |> PrefixedName
    /// <summary>
    ///   <para>places:Estuary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The widened area of a river as it opens to meet the sea or ocean."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Estuaire"</para><para>"Estuary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Estuary"</para><para>"Estuario"</para><para>"河口"</para><para>"Mündung"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Estuary">http://purl.org/ontology/places#Estuary</seealso>
    let Estuary = Prefixed_Name(places, "Estuary") |> PrefixedName
    /// <summary>
    ///   <para>places:Glacier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A slow-moving mass of ice."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glacier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Glacier"</para><para>"冰川"</para><para>"Gletscher"</para><para>"Glaciar"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Glacier">http://purl.org/ontology/places#Glacier</seealso>
    let Glacier = Prefixed_Name(places, "Glacier") |> PrefixedName
    /// <summary>
    ///   <para>places:Gulf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Part of a sea or ocean that is partially enclosed by land. Like a bay but larger."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gulf"</para><para>"Golfo"</para><para>"Gulf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"海湾"</para><para>"Golfe"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Gulf">http://purl.org/ontology/places#Gulf</seealso>
    let Gulf = Prefixed_Name(places, "Gulf") |> PrefixedName
    /// <summary>
    ///   <para>places:Hamlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Hamlet is a small human settlement consisting of just a few dwellings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Weiler"</para><para>"Aldea"</para><para>"Hamlet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"村庄"</para><para>"Hamlet"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Hamlet">http://purl.org/ontology/places#Hamlet</seealso>
    let Hamlet = Prefixed_Name(places, "Hamlet") |> PrefixedName
    /// <summary>
    ///   <para>places:Hill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hill is a landform that extends above the surrounding terrain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"希尔"</para><para>"Hill"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Hill"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Hill">http://purl.org/ontology/places#Hill</seealso>
    let Hill = Prefixed_Name(places, "Hill") |> PrefixedName
    /// <summary>
    ///   <para>places:Island</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A landmass surrounded entirely by water."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Isla"</para><para>"Island"</para><para>"岛"</para><para>"Island"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Island">http://purl.org/ontology/places#Island</seealso>
    let Island = Prefixed_Name(places, "Island") |> PrefixedName
    /// <summary>
    ///   <para>places:Isthmus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A narrow strip of land, bounded by water on two sides, and connecting two larger landmasses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Isthme"</para><para>"Isthmus"</para><para>"Istmo"</para><para>"Isthmus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"地峡"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Isthmus">http://purl.org/ontology/places#Isthmus</seealso>
    let Isthmus = Prefixed_Name(places, "Isthmus") |> PrefixedName
    /// <summary>
    ///   <para>places:Lake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An inland body of water."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lake"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"湖"</para><para>"Lake"</para><para>"Lago"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Lake">http://purl.org/ontology/places#Lake</seealso>
    let Lake = Prefixed_Name(places, "Lake") |> PrefixedName
    /// <summary>
    ///   <para>places:LandMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of land, useful in combination with Continent, Plate and others."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Landmass"</para><para>"La masse continentale"</para><para>"陆地"</para><para>"LandMass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Masa de tierra"</para><para>"Landmasse"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#LandMass">http://purl.org/ontology/places#LandMass</seealso>
    let LandMass = Prefixed_Name(places, "LandMass") |> PrefixedName
    /// <summary>
    ///   <para>places:Mountain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mountain is a large landform that stretches above the surrounding land in a limited area usually in the form of a peak. A mountain is generally steeper than a hill."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Montaña"</para><para>"Mountain"</para><para>"山"</para><para>"Mountain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Mountain">http://purl.org/ontology/places#Mountain</seealso>
    let Mountain = Prefixed_Name(places, "Mountain") |> PrefixedName
    /// <summary>
    ///   <para>places:Municipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A region of governance, often self-governed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gemeinde"</para><para>"市"</para><para>"Municipality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Municipalité"</para><para>"Municipality"</para><para>"Municipio"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Municipality">http://purl.org/ontology/places#Municipality</seealso>
    let Municipality = Prefixed_Name(places, "Municipality") |> PrefixedName
    /// <summary>
    ///   <para>places:Ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A major body of salt water."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ocean"</para><para>"Mar"</para><para>"海洋"</para><para>"Ocean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Ocean">http://purl.org/ontology/places#Ocean</seealso>
    let Ocean = Prefixed_Name(places, "Ocean") |> PrefixedName
    /// <summary>
    ///   <para>places:Parish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An area of regional governance stemming from the geographical area associated with a church."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parish"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Paroisse"</para><para>"Parroquia"</para><para>"Gemeinde"</para><para>"Parish"</para><para>"教区"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Parish">http://purl.org/ontology/places#Parish</seealso>
    let Parish = Prefixed_Name(places, "Parish") |> PrefixedName
    /// <summary>
    ///   <para>places:Path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" A Path is a recognised and maintained route from one place to another that is suitable for pedestrians."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Path"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Path"</para><para>"路径"</para><para>"Ruta"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Path">http://purl.org/ontology/places#Path</seealso>
    let Path = Prefixed_Name(places, "Path") |> PrefixedName
    /// <summary>
    ///   <para>places:Peninsula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A landmass projecting out into a body of water."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Peninsula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"半岛"</para><para>"Péninsule"</para><para>"Halbinsel"</para><para>"Península"</para><para>"Peninsula"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Peninsula">http://purl.org/ontology/places#Peninsula</seealso>
    let Peninsula = Prefixed_Name(places, "Peninsula") |> PrefixedName
    /// <summary>
    ///   <para>places:Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A level area of land."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Llanura"</para><para>"Plain"</para><para>"Plain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"平原"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Plain">http://purl.org/ontology/places#Plain</seealso>
    let Plain = Prefixed_Name(places, "Plain") |> PrefixedName
    /// <summary>
    ///   <para>places:Plate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A geological plate, a piece of the earth’s crust. Useful for geological descriptions involving the movement and separation of continents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"板"</para><para>"Tafel"</para><para>"Plate"</para><para>"Placa"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Plate">http://purl.org/ontology/places#Plate</seealso>
    let Plate = Prefixed_Name(places, "Plate") |> PrefixedName
    /// <summary>
    ///   <para>places:Plateau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A flat highland, a large area of flat land higher than the surrounding land."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plateau"</para><para>"Meseta"</para><para>"Plateau"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"高原"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Plateau">http://purl.org/ontology/places#Plateau</seealso>
    let Plateau = Prefixed_Name(places, "Plateau") |> PrefixedName
    /// <summary>
    ///   <para>places:Province</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A region of governance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"省"</para><para>"Province"</para><para>"Provinz"</para><para>"Province"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Provincia"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Province">http://purl.org/ontology/places#Province</seealso>
    let Province = Prefixed_Name(places, "Province") |> PrefixedName
    /// <summary>
    ///   <para>places:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A politically or culturally recognised area."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Région"</para><para>"Region"</para><para>"区"</para><para>"Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Región"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Region">http://purl.org/ontology/places#Region</seealso>
    let Region = Prefixed_Name(places, "Region") |> PrefixedName
    /// <summary>
    ///   <para>places:Reservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A man-made or natural lake used for the storage and regulation of a water supply."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reservoir"</para><para>"水库"</para><para>"Réservoir"</para><para>"Depósito"</para><para>"Reservoir"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Reservoir">http://purl.org/ontology/places#Reservoir</seealso>
    let Reservoir = Prefixed_Name(places, "Reservoir") |> PrefixedName
    /// <summary>
    ///   <para>places:Ridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A long elevation or striation in the land."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Ridge"</para><para>"脊"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Ridge">http://purl.org/ontology/places#Ridge</seealso>
    let Ridge = Prefixed_Name(places, "Ridge") |> PrefixedName
    /// <summary>
    ///   <para>places:River</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A natural watercourse flowing towards an ocean, sea or lake."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"River"</para><para>"Río"</para><para>"河"</para><para>"River"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#River">http://purl.org/ontology/places#River</seealso>
    let River = Prefixed_Name(places, "River") |> PrefixedName
    /// <summary>
    ///   <para>places:Road</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Road is a recognised and maintained route from one place to another that is suitable for vehicles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Por carretera"</para><para>"Road"</para><para>"路"</para><para>"Road"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Road">http://purl.org/ontology/places#Road</seealso>
    let Road = Prefixed_Name(places, "Road") |> PrefixedName
    /// <summary>
    ///   <para>places:Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large body of salt water, usually connected to an ocean."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"海"</para><para>"Mer"</para><para>"Sea"</para><para>"Mar"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Sea">http://purl.org/ontology/places#Sea</seealso>
    let Sea = Prefixed_Name(places, "Sea") |> PrefixedName
    /// <summary>
    ///   <para>places:Settlement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Settlement is an area of land inhabited by humans and usually having buildings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Règlement"</para><para>"解决"</para><para>"Settlement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Settlement"</para><para>"Liquidación"</para><para>"Siedlung"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Settlement">http://purl.org/ontology/places#Settlement</seealso>
    let Settlement = Prefixed_Name(places, "Settlement") |> PrefixedName
    /// <summary>
    ///   <para>places:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A State is a land area of governance within a country. A state may have counties, cities and towns within its area."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Estado"</para><para>"Staat"</para><para>"État"</para><para>"State"</para><para>"State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"国家"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#State">http://purl.org/ontology/places#State</seealso>
    let State = Prefixed_Name(places, "State") |> PrefixedName
    /// <summary>
    ///   <para>places:Strait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A narrow channel of a sea joining two larger bodies of water."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Meerenge"</para><para>"海峡"</para><para>"Estrecho"</para><para>"Strait"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Strait"</para><para>"Détroit"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Strait">http://purl.org/ontology/places#Strait</seealso>
    let Strait = Prefixed_Name(places, "Strait") |> PrefixedName
    /// <summary>
    ///   <para>places:Town</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A settlement smaller than a city but larger than a village."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"镇"</para><para>"Ville"</para><para>"Town"</para><para>"Town"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Ciudad"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Town">http://purl.org/ontology/places#Town</seealso>
    let Town = Prefixed_Name(places, "Town") |> PrefixedName
    /// <summary>
    ///   <para>places:Township</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A settlement and geographic area, less formally recognised than a town."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Canton"</para><para>"Municipio"</para><para>"Township"</para><para>"Township"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"乡"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Township">http://purl.org/ontology/places#Township</seealso>
    let Township = Prefixed_Name(places, "Township") |> PrefixedName
    /// <summary>
    ///   <para>places:Valley</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A depressed area of land, often between mountains and often containing a river."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"谷"</para><para>"Valley"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Valley"</para><para>"Valle"</para><para>"Vallée"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Valley">http://purl.org/ontology/places#Valley</seealso>
    let Valley = Prefixed_Name(places, "Valley") |> PrefixedName
    /// <summary>
    ///   <para>places:Village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small human settlement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Village"</para><para>"Village"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"村"</para><para>"Pueblo"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Village">http://purl.org/ontology/places#Village</seealso>
    let Village = Prefixed_Name(places, "Village") |> PrefixedName
    /// <summary>
    ///   <para>places:Volcano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A volcano is a crack in the Earth's crust that allows lava and hot gases to escape."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"火山"</para><para>"Vulkan"</para><para>"Volcano"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Volcan"</para><para>"Volcano"</para><para>"Volcán"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Volcano">http://purl.org/ontology/places#Volcano</seealso>
    let Volcano = Prefixed_Name(places, "Volcano") |> PrefixedName
    /// <summary>
    ///   <para>places:Watershed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ridge of land seperating two adjacent water systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Watershed"</para><para>"Wasserscheide"</para><para>"Watershed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Des bassins versants"</para><para>"流域"</para><para>"Cuencas"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#Watershed">http://purl.org/ontology/places#Watershed</seealso>
    let Watershed = Prefixed_Name(places, "Watershed") |> PrefixedName
    /// <summary>
    ///   <para>places:bounded_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The bounded by property relates any place to a boundary that marks out the geographic area it covers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bounded by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#bounded_by">http://purl.org/ontology/places#bounded_by</seealso>
    let bounded_by = Prefixed_Name(places, "bounded_by") |> PrefixedName
    /// <summary>
    ///   <para>places:in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"in is a property that allows you to say that a place is entirely within the boundaries of another place. It allows you to make statements like "Paris is in france"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"in"</para><para>"in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"dans"</para><para>"en"</para><para>"在"</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#in">http://purl.org/ontology/places#in</seealso>
    let in_ = Prefixed_Name(places, "in") |> PrefixedName
    /// <summary>
    ///   <para>places:latlong</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The Lat/long datatype allows us to specify that a literal value is a latitude/longitude pair, based in the WGS84 projection and in the comma-seperated, decimal format. e.g. "38.897605896,-77.0365219116"^^place:latlong would specify the WGS84 geographic co-ordinates of The White House, Washington DC."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lat/Long"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#latlong">http://purl.org/ontology/places#latlong</seealso>
    let latlong = Prefixed_Name(places, "latlong") |> PrefixedName
    /// <summary>
    ///   <para>places:overlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Overlaps is a property for saying that a particular place shares an area of land with another place but that neither place is entirely within the other."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Überschneidungen"</para><para>"overlaps"</para><para>"solapamientos"</para><para>"重叠"</para><para>"chevauchements"</para><para>"overlaps"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#overlaps">http://purl.org/ontology/places#overlaps</seealso>
    let overlaps = Prefixed_Name(places, "overlaps") |> PrefixedName
    /// <summary>
    ///   <para>places:point_on_map</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The point on map property indicates where a place should be shown by a pin on a map."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Point on map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/ontology/places#point_on_map">http://purl.org/ontology/places#point_on_map</seealso>
    let point_on_map = Prefixed_Name(places, "point_on_map") |> PrefixedName
