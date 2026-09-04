#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gtm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.goudatijdmachine.nl/def#" "gtm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Addressingrdfs:label : Adressering</para>
    ///   <para>rdfs:comment : Addressering is de toekenning van een adres aan een locatie, object of entiteit binnen een geografisch gebied, waardoor deze uniek geïdentificeerd kan worden voor post- en identificatiedoeleinden.rdfs:comment : Addressing is the assignment of an address to a location, object, or entity within a geographic area, enabling it to be uniquely identified for postal and identification purposes.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Adressering">gtm:Adressering</a>
    /// </summary>
    let Adressering = _prefixId.prefix "Adressering"
    /// <summary>
    ///   <para>rdfs:label : Buurtrdfs:label : Neighbourhood</para>
    ///   <para>rdfs:comment : Onderdeel van een gemeente, dat op basis van historische dan wel stedenbouwkundige kenmerken homogeen is afgebakend. Homogeen wil zeggen dat één functie dominant is, bijvoorbeeld woonfunctie (woongebied), werkfunctie (industriegebied) of recreatieve functie (natuurgebied). Functies kunnen echter ook gemengd voorkomen. De gemeenten in Nederland zijn onderverdeeld in wijken en buurten. Buurten vormen het laagste regionale niveau. Wijken zijn optellingen van één of meer aaneengesloten buurten. De gemeente bepaalt zelf de indeling in wijken en buurten.rdfs:comment : Part of a municipality that is homogeneously demarcated on the basis of historical or urban development characteristics. Homogeneous means that one function is dominant, for example residential function (residential area), work function (industrial area) or recreational function (nature area). However, functions can also be mixed. The municipalities in the Netherlands are divided into districts and neighborhoods. Neighborhoods are the lowest regional level. Neighborhoods are sums of one or more contiguous neighborhoods. The municipality itself determines the division into districts and neighborhoods.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Buurt">gtm:Buurt</a>
    /// </summary>
    let Buurt = _prefixId.prefix "Buurt"
    /// <summary>
    ///   <para>rdfs:label : Constructierdfs:label : Construction</para>
    ///   <para>rdfs:comment : A construction is a human-made or naturally created object or ensemble, which have a physical form and function within a specific area.rdfs:comment : Een constructie is een door mensen gemaakt of natuurlijk gecreëerd object of geheel, die een fysieke vorm en functie hebben binnen een bepaald gebied.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Constructie">gtm:Constructie</a>
    /// </summary>
    let Constructie = _prefixId.prefix "Constructie"
    /// <summary>
    ///   <para>rdfs:label : Buildingrdfs:label : Gebouw</para>
    ///   <para>rdfs:comment : A building is the smallest functionally and architecturally-constructively independent unit that is directly and permanently connected to the earth and can be entered and locked.rdfs:comment : Een pand is een kleinste bij de totstandkoming functioneel en bouwkundig-constructief zelfstandige eenheid die direct en duurzaam met de aarde is verbonden en betreedbaar en afsluitbaar is.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Gebouw">gtm:Gebouw</a>
    /// </summary>
    let Gebouw = _prefixId.prefix "Gebouw"
    /// <summary>
    ///   <para>rdfs:label : Geo temporal objectrdfs:label : Geo-temporeel object</para>
    ///   <para>rdfs:comment : A geo-temporal object is an entity that has both geographical and temporal characteristics, enabling the specification and analysis of the location and time period of events or objects in space.rdfs:comment : Een geo-temporeel object is een entiteit die zowel geografische als temporele kenmerken heeft, waardoor het mogelijk is om de locatie en tijdsperiode van gebeurtenissen of objecten in de ruimte te specificeren en te analyseren.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#GeoTemporeelObject">gtm:GeoTemporeelObject</a>
    /// </summary>
    let GeoTemporeelObject = _prefixId.prefix "GeoTemporeelObject"
    /// <summary>
    ///   <para>rdfs:label : Courtyardrdfs:label : Hofje</para>
    ///   <para>rdfs:comment : A partly private community intended for the needy, usually consisting of a number of houses around a small park.rdfs:comment : Een deels besloten leefgemeenschap bedoeld voor behoeftigen, meestal bestaande uit een aantal huisjes rond een parkje.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Hofje">gtm:Hofje</a>
    /// </summary>
    let Hofje = _prefixId.prefix "Hofje"
    /// <summary>
    ///   <para>rdfs:label : Kunstwerkrdfs:label : Work of art</para>
    ///   <para>rdfs:comment : A work of art is a civil engineering work for the infrastructure of roads, water, railways, flood defenses and/or pipes and is not intended for permanent human residence.rdfs:comment : Een kunstwerk is een civiel-technisch werk voor de infrastructuur van wegen, water, spoorbanen, waterkeringen en/of leidingen en niet bedoeld voor permanent menselijk verblijf.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Kunstwerk">gtm:Kunstwerk</a>
    /// </summary>
    let Kunstwerk = _prefixId.prefix "Kunstwerk"
    /// <summary>
    ///   <para>rdfs:label : Kwartierrdfs:label : Quarter</para>
    ///   <para>rdfs:comment : A quarter is a part of a city or town that is often characterized by a specific function or population group, such as a residential, commercial, or entertainment area.rdfs:comment : Een kwartier is een deel van een stad of dorp dat vaak wordt gekenmerkt door een specifieke functie of bevolkingsgroep, zoals een woon-, winkel- of uitgaansgebied.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Kwartier">gtm:Kwartier</a>
    /// </summary>
    let Kwartier = _prefixId.prefix "Kwartier"
    /// <summary>
    ///   <para>rdfs:label : Naturerdfs:label : Natuur</para>
    ///   <para>rdfs:comment : Nature is everything in the physical world that is not made by humans, including plants, trees, landscapes, waterways, and other elements of the Earth.rdfs:comment : Natuur is alles in de fysieke wereld dat niet door mensen is gemaakt, inclusief planten, bomen, landschappen, waterwegen en andere elementen van de aarde.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Natuur">gtm:Natuur</a>
    /// </summary>
    let Natuur = _prefixId.prefix "Natuur"
    /// <summary>
    ///   <para>rdfs:label : Number designationrdfs:label : Nummer aanduiding</para>
    ///   <para>rdfs:comment : Een per wijk uitgegeven nummer.rdfs:comment : One number issued per district.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#NummerAanduiding">gtm:NummerAanduiding</a>
    /// </summary>
    let NummerAanduiding = _prefixId.prefix "NummerAanduiding"
    /// <summary>
    ///   <para>rdfs:label : Perceelrdfs:label : Plot</para>
    ///   <para>rdfs:comment : A plot is a limited part of Dutch territory that is cadastrally identified and bounded by cadastral boundaries.rdfs:comment : Een perceel is een begrensd deel van het Nederlands grondgebied dat kadastraal geïdentificeerd is en met kadastrale grenzen begrensd is.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Perceel">gtm:Perceel</a>
    /// </summary>
    let Perceel = _prefixId.prefix "Perceel"
    /// <summary>
    ///   <para>rdfs:label : Plaatsrdfs:label : Place</para>
    ///   <para>rdfs:comment : A place is an inhabited location such as a city, town, or other settlement, where people live and work.rdfs:comment : Een plaats is een bewoonde locatie zoals een stad, dorp of ander nederzetting, waar mensen wonen en werken.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#PlaatsPlaats">gtm:PlaatsPlaats</a>
    /// </summary>
    let PlaatsPlaats = _prefixId.prefix "PlaatsPlaats"
    /// <summary>
    ///   <para>rdfs:label : Plaatselijke aanduidingrdfs:label : Place designation</para>
    ///   <para>rdfs:comment : Combinatie van de wijkletter en een per wijk uitgegeven nummer.rdfs:comment : Combination of the district letter and a number issued per district.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#PlaatselijkeAanduiding">gtm:PlaatselijkeAanduiding</a>
    /// </summary>
    let PlaatselijkeAanduiding = _prefixId.prefix "PlaatselijkeAanduiding"
    /// <summary>
    ///   <para>rdfs:label : Sectierdfs:label : Section</para>
    ///   <para>rdfs:comment : De sectie die de sectie binnen de kadastrale gemeente uniek identificeert.rdfs:comment : The section that uniquely identifies the section within the cadastral municipality.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Sectie">gtm:Sectie</a>
    /// </summary>
    let Sectie = _prefixId.prefix "Sectie"
    /// <summary>
    ///   <para>rdfs:label : Straatrdfs:label : Street</para>
    ///   <para>rdfs:comment : A street is a public road in a village, town, or other inhabited area. Streets are usually used by vehicles and pedestrians and can have houses, businesses, and other buildings on either side.rdfs:comment : Een straat is een openbare weg in een dorp, stad of ander bewoond gebied. Straten worden meestal gebruikt door voertuigen en voetgangers en kunnen huizen, bedrijven en andere gebouwen aan weerszijden hebben.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Straat">gtm:Straat</a>
    /// </summary>
    let Straat = _prefixId.prefix "Straat"
    /// <summary>
    ///   <para>rdfs:label : Straatnummer aanduidingrdfs:label : Street number designation</para>
    ///   <para>rdfs:comment : A number issued per street.rdfs:comment : Een per straat uitgegeven nummer.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#StraatNummerAanduiding">gtm:StraatNummerAanduiding</a>
    /// </summary>
    let StraatNummerAanduiding = _prefixId.prefix "StraatNummerAanduiding"
    /// <summary>
    ///   <para>rdfs:label : Structurerdfs:label : Structuur</para>
    ///   <para>rdfs:comment : A structure is an organized collection of interconnected elements within a geographic area, such as a parcel, district, street, neighborhood, section, or place, that together form the physical and functional composition of a region.rdfs:comment : Een structuur is een georganiseerde verzameling van onderling verbonden elementen binnen een geografisch gebied, zoals een perceel, wijk, straat, buurt, sectie of plaats, die gezamenlijk de fysieke en functionele samenstelling van een regio vormen.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Structuur">gtm:Structuur</a>
    /// </summary>
    let Structuur = _prefixId.prefix "Structuur"
    /// <summary>
    ///   <para>rdfs:label : Districtrdfs:label : Wijk</para>
    ///   <para>rdfs:comment : Onderdeel van een gemeente en cluster van één of meerdere buurten, dat op basis van historische dan wel stedenbouwkundige kenmerken homogeen is afgebakend. Een wijk bestaat uit één of meerdere buurten.rdfs:comment : Part of a municipality and cluster of one or more neighborhoods, which is homogeneously demarcated on the basis of historical or urban development characteristics. A district consists of one or more neighborhoods.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#Wijk">gtm:Wijk</a>
    /// </summary>
    let Wijk = _prefixId.prefix "Wijk"
    /// <summary>
    ///   <para>rdfs:label : addressesrdfs:label : adresseert</para>
    ///   <para>rdfs:comment : De eigenschap 'adresseert' geeft aan dat een entiteit is geassocieerd met een specifiek adres, wat een unieke locatie aangeeft binnen een geografisch gebied.rdfs:comment : The property 'adresseert' (adresses) indicates that an entity is associated with a specific address, which denotes a unique location within a geographic area.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#adresseert">gtm:adresseert</a>
    /// </summary>
    let adresseert = _prefixId.prefix "adresseert"
    /// <summary>
    ///   <para>rdfs:label : has addressrdfs:label : heeft adres</para>
    ///   <para>rdfs:comment : De eigenschap 'heeft adres' geeft aan dat een entiteit is geassocieerd met een specifiek adres, wat een unieke locatie aangeeft binnen een geografisch gebied.rdfs:comment : The property 'heeft adres' (has address) indicates that an entity is associated with a specific address, which denotes a unique location within a geographic area.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#heeftAdres">gtm:heeftAdres</a>
    /// </summary>
    let heeftAdres = _prefixId.prefix "heeftAdres"
    /// <summary>
    ///   <para>rdfs:label : ligt inrdfs:label : located in</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#ligtIn">gtm:ligtIn</a>
    /// </summary>
    let ligtIn = _prefixId.prefix "ligtIn"
    /// <summary>
    ///   <para>rdfs:label : is located in streetrdfs:label : ligt in straat</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#ligtInStraat">gtm:ligtInStraat</a>
    /// </summary>
    let ligtInStraat = _prefixId.prefix "ligtInStraat"
    /// <summary>
    ///   <para>rdfs:label : is located in districtrdfs:label : ligt in wijk</para>
    ///   <para>rdfs:comment : De eigenschap 'ligt in wijk' geeft aan dat een buurt zich binnen een specifieke wijk bevindt, waarbij een wijk een afgebakend gebied is binnen een stad of dorp.rdfs:comment : The property 'located in district' indicates that an neighbourhood is situated within a specific district, where a district is a defined area within a city or town.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#ligtInWijk">gtm:ligtInWijk</a>
    /// </summary>
    let ligtInWijk = _prefixId.prefix "ligtInWijk"
    /// <summary>
    ///   <para>rdfs:label : build on plotrdfs:label : staat op perceel</para>
    ///   <para>rdfs:comment : De eigenschap 'staat op perceel' geeft aan dat een entiteit zich bevindt op een specifiek perceel grond, waarbij een perceel een stuk land is dat afgebakend is voor een specifieke functie.rdfs:comment : The property 'is located on parcel' indicates that an entity is situated on a specific parcel of land, where a parcel is a piece of land delineated for a specific purpose.</para>
    ///   <a href="https://www.goudatijdmachine.nl/def#staatOpPerceel">gtm:staatOpPerceel</a>
    /// </summary>
    let staatOpPerceel = _prefixId.prefix "staatOpPerceel"
