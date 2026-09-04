#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module place =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/places#" "place"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Arbitrary Regionrdfs:label : ArbitraryRegion^^xsd:stringrdfs:label : Région Arbitrairerdfs:label : 任意区域rdfs:label : Willkürliche Regionrdfs:label : Arbitraria Región</para>
    ///   <para>rdfs:comment : An area that is useful to illustrate a particular point but does not have a recognised political or cultural identity.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#ArbitraryRegion">place:ArbitraryRegion</a>
    /// </summary>
    let ArbitraryRegion = _prefixId.prefix "ArbitraryRegion"
    /// <summary>
    ///   <para>rdfs:label : Bay^^xsd:stringrdfs:label : Bayrdfs:label : Bayrdfs:label : Bayrdfs:label : 湾rdfs:label : Bahía</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : An indentation to a shoreline, a body of water enclosed but with a large mouth to a wider body of water.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Bay">place:Bay</a>
    /// </summary>
    let Bay = _prefixId.prefix "Bay"
    /// <summary>
    ///   <para>rdfs:label : Beach^^xsd:stringrdfs:label : Beachrdfs:label : Beachrdfs:label : Beachrdfs:label : Playardfs:label : 海滩</para>
    ///   <para>rdfs:comment : The shore of a body of water, usually sandy or pebbly.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Beach">place:Beach</a>
    /// </summary>
    let Beach = _prefixId.prefix "Beach"
    /// <summary>
    ///   <para>rdfs:label : Municipiordfs:label : Arrondissementrdfs:label : Bezirkrdfs:label : Borough^^xsd:stringrdfs:label : Boroughrdfs:label : 伯勒</para>
    ///   <para>rdfs:comment : An administrative region of governance.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Borough">place:Borough</a>
    /// </summary>
    let Borough = _prefixId.prefix "Borough"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Boundary^^xsd:string</para>
    ///   <para>rdfs:comment : A Boundary resource specifies a sequence of points which, if joined, give the boundary of a geographical area. The sequence may be a serious of resources, each with a latitude and longitude, or a series of points using the datatype place:latlong. If the final point is the same as the first then the boundary is considered to be a closed area, whereas if the first and last points differ the boundary is considered to be a border line.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Boundary">place:Boundary</a>
    /// </summary>
    let Boundary = _prefixId.prefix "Boundary"
    /// <summary>
    ///   <para>rdfs:label : Cape^^xsd:stringrdfs:label : Caperdfs:label : Caperdfs:label : Caprdfs:label : Cabordfs:label : 披肩</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A strip of land projecting into a body of water^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Cape">place:Cape</a>
    /// </summary>
    let Cape = _prefixId.prefix "Cape"
    /// <summary>
    ///   <para>rdfs:comment : A large settlement, often with some form of formal political recognition.^^xsd:string</para>
    ///   <para>rdfs:label : 市rdfs:label : Ciudadrdfs:label : City^^xsd:stringrdfs:label : Cityrdfs:label : Cityrdfs:label : City</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#City">place:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : Acantiladordfs:label : 悬崖rdfs:label : Cliff^^xsd:stringrdfs:label : Cliffrdfs:label : Cliffrdfs:label : Cliff</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A steep high face of rock.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Cliff">place:Cliff</a>
    /// </summary>
    let Cliff = _prefixId.prefix "Cliff"
    /// <summary>
    ///   <para>rdfs:label : Kontinentrdfs:label : Continent^^xsd:stringrdfs:label : Continentrdfs:label : Continentrdfs:label : 大陆rdfs:label : Continente</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A large landmass recognised by convention as a continent.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Continent">place:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>rdfs:comment : A region considered to be the territory of a recognised political state.^^xsd:string</para>
    ///   <para>rdfs:label : Country^^xsd:stringrdfs:label : Countryrdfs:label : Paísrdfs:label : 国家rdfs:label : Paysrdfs:label : Land</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Country">place:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : Comtérdfs:label : County^^xsd:stringrdfs:label : Condadordfs:label : Countyrdfs:label : Countyrdfs:label : 县</para>
    ///   <para>rdfs:comment : A county is a land area of local governance within a country. A county may have cities and towns within its area.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#County">place:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>rdfs:comment : A desert is a landscape or region that receives an extremely low amount of precipitation, less than enough to support growth of most plants.^^xsd:string</para>
    ///   <para>rdfs:label : 沙漠rdfs:label : Desert^^xsd:stringrdfs:label : Desertrdfs:label : Desertrdfs:label : Desertrdfs:label : Desierto</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Desert">place:Desert</a>
    /// </summary>
    let Desert = _prefixId.prefix "Desert"
    /// <summary>
    ///   <para>rdfs:comment : A region of governance.^^xsd:string</para>
    ///   <para>rdfs:label : District^^xsd:stringrdfs:label : 区rdfs:label : Districtrdfs:label : Districtrdfs:label : Distritordfs:label : Bezirk</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#District">place:District</a>
    /// </summary>
    let District = _prefixId.prefix "District"
    /// <summary>
    ///   <para>rdfs:label : Mündungrdfs:label : Estuariordfs:label : Estuary^^xsd:stringrdfs:label : Estuaryrdfs:label : 河口rdfs:label : Estuaire</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The widened area of a river as it opens to meet the sea or ocean.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Estuary">place:Estuary</a>
    /// </summary>
    let Estuary = _prefixId.prefix "Estuary"
    /// <summary>
    ///   <para>rdfs:label : Gletscherrdfs:label : Glacier^^xsd:stringrdfs:label : Glacierrdfs:label : Glacierrdfs:label : Glaciarrdfs:label : 冰川</para>
    ///   <para>rdfs:comment : A slow-moving mass of ice.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Glacier">place:Glacier</a>
    /// </summary>
    let Glacier = _prefixId.prefix "Glacier"
    /// <summary>
    ///   <para>rdfs:comment : Part of a sea or ocean that is partially enclosed by land. Like a bay but larger.^^xsd:string</para>
    ///   <para>rdfs:label : Gulf^^xsd:stringrdfs:label : Gulfrdfs:label : Gulfrdfs:label : 海湾rdfs:label : Golfordfs:label : Golfe</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Gulf">place:Gulf</a>
    /// </summary>
    let Gulf = _prefixId.prefix "Gulf"
    /// <summary>
    ///   <para>rdfs:label : Aldeardfs:label : Hamlet^^xsd:stringrdfs:label : Hamletrdfs:label : Hamletrdfs:label : Weilerrdfs:label : 村庄</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A Hamlet is a small human settlement consisting of just a few dwellings.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Hamlet">place:Hamlet</a>
    /// </summary>
    let Hamlet = _prefixId.prefix "Hamlet"
    /// <summary>
    ///   <para>rdfs:comment : A hill is a landform that extends above the surrounding terrain.^^xsd:string</para>
    ///   <para>rdfs:label : 希尔rdfs:label : Hill^^xsd:stringrdfs:label : Hillrdfs:label : Hillrdfs:label : Hillrdfs:label : Hill</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Hill">place:Hill</a>
    /// </summary>
    let Hill = _prefixId.prefix "Hill"
    /// <summary>
    ///   <para>rdfs:label : Islardfs:label : 岛rdfs:label : Island^^xsd:stringrdfs:label : Islandrdfs:label : Islandrdfs:label : Island</para>
    ///   <para>rdfs:comment : A landmass surrounded entirely by water.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Island">place:Island</a>
    /// </summary>
    let Island = _prefixId.prefix "Island"
    /// <summary>
    ///   <para>rdfs:label : Isthmerdfs:label : Istmordfs:label : Isthmus^^xsd:stringrdfs:label : Isthmusrdfs:label : Isthmusrdfs:label : 地峡</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A narrow strip of land, bounded by water on two sides, and connecting two larger landmasses.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Isthmus">place:Isthmus</a>
    /// </summary>
    let Isthmus = _prefixId.prefix "Isthmus"
    /// <summary>
    ///   <para>rdfs:comment : An inland body of water.^^xsd:string</para>
    ///   <para>rdfs:label : Lagordfs:label : 湖rdfs:label : Lake^^xsd:stringrdfs:label : Lakerdfs:label : Lakerdfs:label : Lake</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Lake">place:Lake</a>
    /// </summary>
    let Lake = _prefixId.prefix "Lake"
    /// <summary>
    ///   <para>rdfs:label : Masa de tierrardfs:label : LandMass^^xsd:stringrdfs:label : Landmassrdfs:label : Landmasserdfs:label : 陆地rdfs:label : La masse continentale</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A piece of land, useful in combination with Continent, Plate and others.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#LandMass">place:LandMass</a>
    /// </summary>
    let LandMass = _prefixId.prefix "LandMass"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A mountain is a large landform that stretches above the surrounding land in a limited area usually in the form of a peak. A mountain is generally steeper than a hill.^^xsd:string</para>
    ///   <para>rdfs:label : Mountain^^xsd:stringrdfs:label : Mountainrdfs:label : Mountainrdfs:label : Mountainrdfs:label : Montañardfs:label : 山</para>
    ///   <a href="http://purl.org/ontology/places#Mountain">place:Mountain</a>
    /// </summary>
    let Mountain = _prefixId.prefix "Mountain"
    /// <summary>
    ///   <para>rdfs:label : Municipiordfs:label : 市rdfs:label : Municipality^^xsd:stringrdfs:label : Municipalityrdfs:label : Municipalitérdfs:label : Gemeinde</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A region of governance, often self-governed.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Municipality">place:Municipality</a>
    /// </summary>
    let Municipality = _prefixId.prefix "Municipality"
    /// <summary>
    ///   <para>rdfs:label : Marrdfs:label : Ocean^^xsd:stringrdfs:label : Oceanrdfs:label : Oceanrdfs:label : Oceanrdfs:label : 海洋</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A major body of salt water.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Ocean">place:Ocean</a>
    /// </summary>
    let Ocean = _prefixId.prefix "Ocean"
    /// <summary>
    ///   <para>rdfs:label : Gemeinderdfs:label : Parish^^xsd:stringrdfs:label : Parishrdfs:label : Parroquiardfs:label : 教区rdfs:label : Paroisse</para>
    ///   <para>rdfs:comment : An area of regional governance stemming from the geographical area associated with a church.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Parish">place:Parish</a>
    /// </summary>
    let Parish = _prefixId.prefix "Parish"
    /// <summary>
    ///   <para>rdfs:label : 路径rdfs:label : Rutardfs:label : Path^^xsd:stringrdfs:label : Pathrdfs:label : Pathrdfs:label : Path</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment :  A Path is a recognised and maintained route from one place to another that is suitable for pedestrians.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Path">place:Path</a>
    /// </summary>
    let Path = _prefixId.prefix "Path"
    /// <summary>
    ///   <para>rdfs:comment : A landmass projecting out into a body of water.^^xsd:string</para>
    ///   <para>rdfs:label : Peninsula^^xsd:stringrdfs:label : Peninsulardfs:label : Penínsulardfs:label : Péninsulerdfs:label : Halbinselrdfs:label : 半岛</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Peninsula">place:Peninsula</a>
    /// </summary>
    let Peninsula = _prefixId.prefix "Peninsula"
    /// <summary>
    ///   <para>rdfs:label : Plain^^xsd:stringrdfs:label : Plainrdfs:label : Plainrdfs:label : Plainrdfs:label : Llanurardfs:label : 平原</para>
    ///   <para>rdfs:comment : A level area of land.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Plain">place:Plain</a>
    /// </summary>
    let Plain = _prefixId.prefix "Plain"
    /// <summary>
    ///   <para>rdfs:label : Plate^^xsd:stringrdfs:label : Platerdfs:label : Tafelrdfs:label : Placardfs:label : 板rdfs:label : Plate</para>
    ///   <para>rdfs:comment : A geological plate, a piece of the earth’s crust. Useful for geological descriptions involving the movement and separation of continents.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Plate">place:Plate</a>
    /// </summary>
    let Plate = _prefixId.prefix "Plate"
    /// <summary>
    ///   <para>rdfs:label : 高原rdfs:label : Mesetardfs:label : Plateau^^xsd:stringrdfs:label : Plateaurdfs:label : Plateaurdfs:label : Plateau</para>
    ///   <para>rdfs:comment : A flat highland, a large area of flat land higher than the surrounding land.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Plateau">place:Plateau</a>
    /// </summary>
    let Plateau = _prefixId.prefix "Plateau"
    /// <summary>
    ///   <para>rdfs:label : 省rdfs:label : Province^^xsd:stringrdfs:label : Provincerdfs:label : Provincerdfs:label : Provinzrdfs:label : Provincia</para>
    ///   <para>rdfs:comment : A region of governance.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Province">place:Province</a>
    /// </summary>
    let Province = _prefixId.prefix "Province"
    /// <summary>
    ///   <para>rdfs:label : Regiónrdfs:label : Region^^xsd:stringrdfs:label : Regionrdfs:label : Regionrdfs:label : Régionrdfs:label : 区</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A politically or culturally recognised area.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Region">place:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:label : 水库rdfs:label : Depósitordfs:label : Reservoir^^xsd:stringrdfs:label : Reservoirrdfs:label : Reservoirrdfs:label : Réservoir</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A man-made or natural lake used for the storage and regulation of a water supply.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Reservoir">place:Reservoir</a>
    /// </summary>
    let Reservoir = _prefixId.prefix "Reservoir"
    /// <summary>
    ///   <para>rdfs:label : 脊rdfs:label : Ridge^^xsd:stringrdfs:label : Ridgerdfs:label : Ridgerdfs:label : Ridgerdfs:label : Ridge</para>
    ///   <para>rdfs:comment : A long elevation or striation in the land.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Ridge">place:Ridge</a>
    /// </summary>
    let Ridge = _prefixId.prefix "Ridge"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Ríordfs:label : River^^xsd:stringrdfs:label : Riverrdfs:label : Riverrdfs:label : Riverrdfs:label : 河</para>
    ///   <para>rdfs:comment : A natural watercourse flowing towards an ocean, sea or lake.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#River">place:River</a>
    /// </summary>
    let River = _prefixId.prefix "River"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Por carreterardfs:label : Road^^xsd:stringrdfs:label : Roadrdfs:label : Roadrdfs:label : Roadrdfs:label : 路</para>
    ///   <para>rdfs:comment : A Road is a recognised and maintained route from one place to another that is suitable for vehicles.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Road">place:Road</a>
    /// </summary>
    let Road = _prefixId.prefix "Road"
    /// <summary>
    ///   <para>rdfs:comment : A large body of salt water, usually connected to an ocean.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Marrdfs:label : Merrdfs:label : Sea^^xsd:stringrdfs:label : Seardfs:label : Seardfs:label : 海</para>
    ///   <a href="http://purl.org/ontology/places#Sea">place:Sea</a>
    /// </summary>
    let Sea = _prefixId.prefix "Sea"
    /// <summary>
    ///   <para>rdfs:label : 解决rdfs:label : Siedlungrdfs:label : Règlementrdfs:label : Settlement^^xsd:stringrdfs:label : Settlementrdfs:label : Liquidación</para>
    ///   <para>rdfs:comment : A Settlement is an area of land inhabited by humans and usually having buildings.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Settlement">place:Settlement</a>
    /// </summary>
    let Settlement = _prefixId.prefix "Settlement"
    /// <summary>
    ///   <para>rdfs:label : State^^xsd:stringrdfs:label : Staterdfs:label : Staatrdfs:label : Estadordfs:label : Étatrdfs:label : 国家</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A State is a land area of governance within a country. A state may have counties, cities and towns within its area.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#State">place:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Strait^^xsd:stringrdfs:label : Straitrdfs:label : Estrechordfs:label : Meerengerdfs:label : Détroitrdfs:label : 海峡</para>
    ///   <para>rdfs:comment : A narrow channel of a sea joining two larger bodies of water.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Strait">place:Strait</a>
    /// </summary>
    let Strait = _prefixId.prefix "Strait"
    /// <summary>
    ///   <para>rdfs:label : Villerdfs:label : Ciudadrdfs:label : 镇rdfs:label : Town^^xsd:stringrdfs:label : Townrdfs:label : Town</para>
    ///   <para>rdfs:comment : A settlement smaller than a city but larger than a village.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Town">place:Town</a>
    /// </summary>
    let Town = _prefixId.prefix "Town"
    /// <summary>
    ///   <para>rdfs:label : Municipiordfs:label : Cantonrdfs:label : 乡rdfs:label : Township^^xsd:stringrdfs:label : Townshiprdfs:label : Township</para>
    ///   <para>rdfs:comment : A settlement and geographic area, less formally recognised than a town.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Township">place:Township</a>
    /// </summary>
    let Township = _prefixId.prefix "Township"
    /// <summary>
    ///   <para>rdfs:comment : A depressed area of land, often between mountains and often containing a river.^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Valley^^xsd:stringrdfs:label : Valleyrdfs:label : Valleyrdfs:label : Vallerdfs:label : Valléerdfs:label : 谷</para>
    ///   <a href="http://purl.org/ontology/places#Valley">place:Valley</a>
    /// </summary>
    let Valley = _prefixId.prefix "Valley"
    /// <summary>
    ///   <para>rdfs:label : Pueblordfs:label : 村rdfs:label : Village^^xsd:stringrdfs:label : Villagerdfs:label : Villagerdfs:label : Village</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A small human settlement.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Village">place:Village</a>
    /// </summary>
    let Village = _prefixId.prefix "Village"
    /// <summary>
    ///   <para>rdfs:label : 火山rdfs:label : Vulkanrdfs:label : Volcanrdfs:label : Volcano^^xsd:stringrdfs:label : Volcanordfs:label : Volcán</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A volcano is a crack in the Earth's crust that allows lava and hot gases to escape.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Volcano">place:Volcano</a>
    /// </summary>
    let Volcano = _prefixId.prefix "Volcano"
    /// <summary>
    ///   <para>rdfs:comment : A ridge of land seperating two adjacent water systems.^^xsd:string</para>
    ///   <para>rdfs:label : Watershed^^xsd:stringrdfs:label : Watershedrdfs:label : Wasserscheiderdfs:label : 流域rdfs:label : Des bassins versantsrdfs:label : Cuencas</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#Watershed">place:Watershed</a>
    /// </summary>
    let Watershed = _prefixId.prefix "Watershed"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : bounded by^^xsd:string</para>
    ///   <para>rdfs:comment : The bounded by property relates any place to a boundary that marks out the geographic area it covers.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#bounded_by">place:bounded_by</a>
    /// </summary>
    let bounded_by = _prefixId.prefix "bounded_by"
    /// <summary>
    ///   <para>rdfs:label : in^^xsd:stringrdfs:label : inrdfs:label : inrdfs:label : 在rdfs:label : dansrdfs:label : en</para>
    ///   <para>rdfs:comment : in is a property that allows you to say that a place is entirely within the boundaries of another place. It allows you to make statements like "Paris is in france".^^xsd:string</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#in">place:in</a>
    /// </summary>
    let in_ = _prefixId.prefix "in"
    let latlong = _prefixId.prefix "latlong"
    /// <summary>
    ///   <para>rdfs:label : solapamientosrdfs:label : overlaps^^xsd:stringrdfs:label : overlapsrdfs:label : 重叠rdfs:label : Überschneidungenrdfs:label : chevauchements</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Overlaps is a property for saying that a particular place shares an area of land with another place but that neither place is entirely within the other.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#overlaps">place:overlaps</a>
    /// </summary>
    let overlaps = _prefixId.prefix "overlaps"
    /// <summary>
    ///   <para>rdfs:label : Point on map^^xsd:string</para>
    ///   <para>rdfs:comment : The point on map property indicates where a place should be shown by a pin on a map.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/places#point_on_map">place:point_on_map</a>
    /// </summary>
    let point_on_map = _prefixId.prefix "point_on_map"
