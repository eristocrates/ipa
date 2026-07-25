namespace https.www.goudatijdmachine.nl.def.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gtm =
    let _namespace_iri = Namespace_Iri gtm |> NamespaceIRI
    /// <summary>
    ///   <para>gtm:GeoTemporeelObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een geo-temporeel object is een entiteit die zowel geografische als temporele kenmerken heeft, waardoor het mogelijk is om de locatie en tijdsperiode van gebeurtenissen of objecten in de ruimte te specificeren en te analyseren.</para>
    ///   <para>A geo-temporal object is an entity that has both geographical and temporal characteristics, enabling the specification and analysis of the location and time period of events or objects in space.</para>
    /// labels<para>Geo-temporeel object</para><para>Geo temporal object</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#GeoTemporeelObject">https://www.goudatijdmachine.nl/def#GeoTemporeelObject</seealso>
    let GeoTemporeelObject = Prefixed_Name(gtm, "GeoTemporeelObject") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Buurt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Onderdeel van een gemeente, dat op basis van historische dan wel stedenbouwkundige kenmerken homogeen is afgebakend. Homogeen wil zeggen dat één functie dominant is, bijvoorbeeld woonfunctie (woongebied), werkfunctie (industriegebied) of recreatieve functie (natuurgebied). Functies kunnen echter ook gemengd voorkomen. De gemeenten in Nederland zijn onderverdeeld in wijken en buurten. Buurten vormen het laagste regionale niveau. Wijken zijn optellingen van één of meer aaneengesloten buurten. De gemeente bepaalt zelf de indeling in wijken en buurten.</para>
    ///   <para>Part of a municipality that is homogeneously demarcated on the basis of historical or urban development characteristics. Homogeneous means that one function is dominant, for example residential function (residential area), work function (industrial area) or recreational function (nature area). However, functions can also be mixed. The municipalities in the Netherlands are divided into districts and neighborhoods. Neighborhoods are the lowest regional level. Neighborhoods are sums of one or more contiguous neighborhoods. The municipality itself determines the division into districts and neighborhoods.</para>
    /// labels<para>Neighbourhood</para><para>Buurt</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Buurt">https://www.goudatijdmachine.nl/def#Buurt</seealso>
    let Buurt = Prefixed_Name(gtm, "Buurt") |> PrefixedName
    /// <summary>
    ///   <para>gtm:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#">https://www.goudatijdmachine.nl/def#</seealso>
    let _prefix_iri = Prefixed_Name(gtm, "") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Adressering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Addressing is the assignment of an address to a location, object, or entity within a geographic area, enabling it to be uniquely identified for postal and identification purposes.</para>
    ///   <para>Addressering is de toekenning van een adres aan een locatie, object of entiteit binnen een geografisch gebied, waardoor deze uniek geïdentificeerd kan worden voor post- en identificatiedoeleinden.</para>
    /// labels<para>Adressering</para><para>Addressing</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Adressering">https://www.goudatijdmachine.nl/def#Adressering</seealso>
    let Adressering = Prefixed_Name(gtm, "Adressering") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Constructie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een constructie is een door mensen gemaakt of natuurlijk gecreëerd object of geheel, die een fysieke vorm en functie hebben binnen een bepaald gebied.</para>
    ///   <para>A construction is a human-made or naturally created object or ensemble, which have a physical form and function within a specific area.</para>
    /// labels<para>Construction</para><para>Constructie</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Constructie">https://www.goudatijdmachine.nl/def#Constructie</seealso>
    let Constructie = Prefixed_Name(gtm, "Constructie") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Gebouw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A building is the smallest functionally and architecturally-constructively independent unit that is directly and permanently connected to the earth and can be entered and locked.</para>
    ///   <para>Een pand is een kleinste bij de totstandkoming functioneel en bouwkundig-constructief zelfstandige eenheid die direct en duurzaam met de aarde is verbonden en betreedbaar en afsluitbaar is.</para>
    /// labels<para>Building</para><para>Gebouw</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Gebouw">https://www.goudatijdmachine.nl/def#Gebouw</seealso>
    let Gebouw = Prefixed_Name(gtm, "Gebouw") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Hofje</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een deels besloten leefgemeenschap bedoeld voor behoeftigen, meestal bestaande uit een aantal huisjes rond een parkje.</para>
    ///   <para>A partly private community intended for the needy, usually consisting of a number of houses around a small park.</para>
    /// labels<para>Courtyard</para><para>Hofje</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Hofje">https://www.goudatijdmachine.nl/def#Hofje</seealso>
    let Hofje = Prefixed_Name(gtm, "Hofje") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Kwartier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quarter is a part of a city or town that is often characterized by a specific function or population group, such as a residential, commercial, or entertainment area.</para>
    ///   <para>Een kwartier is een deel van een stad of dorp dat vaak wordt gekenmerkt door een specifieke functie of bevolkingsgroep, zoals een woon-, winkel- of uitgaansgebied.</para>
    /// labels<para>Kwartier</para><para>Quarter</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Kwartier">https://www.goudatijdmachine.nl/def#Kwartier</seealso>
    let Kwartier = Prefixed_Name(gtm, "Kwartier") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Structuur</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A structure is an organized collection of interconnected elements within a geographic area, such as a parcel, district, street, neighborhood, section, or place, that together form the physical and functional composition of a region.</para>
    ///   <para>Een structuur is een georganiseerde verzameling van onderling verbonden elementen binnen een geografisch gebied, zoals een perceel, wijk, straat, buurt, sectie of plaats, die gezamenlijk de fysieke en functionele samenstelling van een regio vormen.</para>
    /// labels<para>Structuur</para><para>Structure</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Structuur">https://www.goudatijdmachine.nl/def#Structuur</seealso>
    let Structuur = Prefixed_Name(gtm, "Structuur") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Natuur</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Nature is everything in the physical world that is not made by humans, including plants, trees, landscapes, waterways, and other elements of the Earth.</para>
    ///   <para>Natuur is alles in de fysieke wereld dat niet door mensen is gemaakt, inclusief planten, bomen, landschappen, waterwegen en andere elementen van de aarde.</para>
    /// labels<para>Nature</para><para>Natuur</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Natuur">https://www.goudatijdmachine.nl/def#Natuur</seealso>
    let Natuur = Prefixed_Name(gtm, "Natuur") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Kunstwerk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A work of art is a civil engineering work for the infrastructure of roads, water, railways, flood defenses and/or pipes and is not intended for permanent human residence.</para>
    ///   <para>Een kunstwerk is een civiel-technisch werk voor de infrastructuur van wegen, water, spoorbanen, waterkeringen en/of leidingen en niet bedoeld voor permanent menselijk verblijf.</para>
    /// labels<para>Work of art</para><para>Kunstwerk</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Kunstwerk">https://www.goudatijdmachine.nl/def#Kunstwerk</seealso>
    let Kunstwerk = Prefixed_Name(gtm, "Kunstwerk") |> PrefixedName
    /// <summary>
    ///   <para>gtm:NummerAanduiding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een per wijk uitgegeven nummer.</para>
    ///   <para>One number issued per district.</para>
    /// labels<para>Number designation</para><para>Nummer aanduiding</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#NummerAanduiding">https://www.goudatijdmachine.nl/def#NummerAanduiding</seealso>
    let NummerAanduiding = Prefixed_Name(gtm, "NummerAanduiding") |> PrefixedName

    /// <summary>
    ///   <para>gtm:PlaatselijkeAanduiding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Combination of the district letter and a number issued per district.</para>
    ///   <para>Combinatie van de wijkletter en een per wijk uitgegeven nummer.</para>
    /// labels<para>Plaatselijke aanduiding</para><para>Place designation</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#PlaatselijkeAanduiding">https://www.goudatijdmachine.nl/def#PlaatselijkeAanduiding</seealso>
    let PlaatselijkeAanduiding =
        Prefixed_Name(gtm, "PlaatselijkeAanduiding") |> PrefixedName

    /// <summary>
    ///   <para>gtm:Perceel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A plot is a limited part of Dutch territory that is cadastrally identified and bounded by cadastral boundaries.</para>
    ///   <para>Een perceel is een begrensd deel van het Nederlands grondgebied dat kadastraal geïdentificeerd is en met kadastrale grenzen begrensd is.</para>
    /// labels<para>Perceel</para><para>Plot</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Perceel">https://www.goudatijdmachine.nl/def#Perceel</seealso>
    let Perceel = Prefixed_Name(gtm, "Perceel") |> PrefixedName
    /// <summary>
    ///   <para>gtm:PlaatsPlaats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een plaats is een bewoonde locatie zoals een stad, dorp of ander nederzetting, waar mensen wonen en werken.</para>
    ///   <para>A place is an inhabited location such as a city, town, or other settlement, where people live and work.</para>
    /// labels<para>Plaats</para><para>Place</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#PlaatsPlaats">https://www.goudatijdmachine.nl/def#PlaatsPlaats</seealso>
    let PlaatsPlaats = Prefixed_Name(gtm, "PlaatsPlaats") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Straat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A street is a public road in a village, town, or other inhabited area. Streets are usually used by vehicles and pedestrians and can have houses, businesses, and other buildings on either side.</para>
    ///   <para>Een straat is een openbare weg in een dorp, stad of ander bewoond gebied. Straten worden meestal gebruikt door voertuigen en voetgangers en kunnen huizen, bedrijven en andere gebouwen aan weerszijden hebben.</para>
    /// labels<para>Straat</para><para>Street</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Straat">https://www.goudatijdmachine.nl/def#Straat</seealso>
    let Straat = Prefixed_Name(gtm, "Straat") |> PrefixedName
    /// <summary>
    ///   <para>gtm:heeftAdres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property 'heeft adres' (has address) indicates that an entity is associated with a specific address, which denotes a unique location within a geographic area.</para>
    ///   <para>De eigenschap 'heeft adres' geeft aan dat een entiteit is geassocieerd met een specifiek adres, wat een unieke locatie aangeeft binnen een geografisch gebied.</para>
    /// labels<para>has address</para><para>heeft adres</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#heeftAdres">https://www.goudatijdmachine.nl/def#heeftAdres</seealso>
    let heeftAdres = Prefixed_Name(gtm, "heeftAdres") |> PrefixedName
    /// <summary>
    ///   <para>gtm:ligtIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>located in</para><para>ligt in</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#ligtIn">https://www.goudatijdmachine.nl/def#ligtIn</seealso>
    let ligtIn = Prefixed_Name(gtm, "ligtIn") |> PrefixedName
    /// <summary>
    ///   <para>gtm:ligtInStraat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is located in street</para><para>ligt in straat</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#ligtInStraat">https://www.goudatijdmachine.nl/def#ligtInStraat</seealso>
    let ligtInStraat = Prefixed_Name(gtm, "ligtInStraat") |> PrefixedName

    /// <summary>
    ///   <para>gtm:StraatNummerAanduiding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A number issued per street.</para>
    ///   <para>Een per straat uitgegeven nummer.</para>
    /// labels<para>Street number designation</para><para>Straatnummer aanduiding</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#StraatNummerAanduiding">https://www.goudatijdmachine.nl/def#StraatNummerAanduiding</seealso>
    let StraatNummerAanduiding =
        Prefixed_Name(gtm, "StraatNummerAanduiding") |> PrefixedName

    /// <summary>
    ///   <para>gtm:Sectie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>De sectie die de sectie binnen de kadastrale gemeente uniek identificeert.</para>
    ///   <para>The section that uniquely identifies the section within the cadastral municipality.</para>
    /// labels<para>Section</para><para>Sectie</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Sectie">https://www.goudatijdmachine.nl/def#Sectie</seealso>
    let Sectie = Prefixed_Name(gtm, "Sectie") |> PrefixedName
    /// <summary>
    ///   <para>gtm:Wijk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Onderdeel van een gemeente en cluster van één of meerdere buurten, dat op basis van historische dan wel stedenbouwkundige kenmerken homogeen is afgebakend. Een wijk bestaat uit één of meerdere buurten.</para>
    ///   <para>Part of a municipality and cluster of one or more neighborhoods, which is homogeneously demarcated on the basis of historical or urban development characteristics. A district consists of one or more neighborhoods.</para>
    /// labels<para>District</para><para>Wijk</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#Wijk">https://www.goudatijdmachine.nl/def#Wijk</seealso>
    let Wijk = Prefixed_Name(gtm, "Wijk") |> PrefixedName
    /// <summary>
    ///   <para>gtm:adresseert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De eigenschap 'adresseert' geeft aan dat een entiteit is geassocieerd met een specifiek adres, wat een unieke locatie aangeeft binnen een geografisch gebied.</para>
    ///   <para>The property 'adresseert' (adresses) indicates that an entity is associated with a specific address, which denotes a unique location within a geographic area.</para>
    /// labels<para>adresseert</para><para>addresses</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#adresseert">https://www.goudatijdmachine.nl/def#adresseert</seealso>
    let adresseert = Prefixed_Name(gtm, "adresseert") |> PrefixedName
    /// <summary>
    ///   <para>gtm:staatOpPerceel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De eigenschap 'staat op perceel' geeft aan dat een entiteit zich bevindt op een specifiek perceel grond, waarbij een perceel een stuk land is dat afgebakend is voor een specifieke functie.</para>
    ///   <para>The property 'is located on parcel' indicates that an entity is situated on a specific parcel of land, where a parcel is a piece of land delineated for a specific purpose.</para>
    /// labels<para>staat op perceel</para><para>build on plot</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#staatOpPerceel">https://www.goudatijdmachine.nl/def#staatOpPerceel</seealso>
    let staatOpPerceel = Prefixed_Name(gtm, "staatOpPerceel") |> PrefixedName
    /// <summary>
    ///   <para>gtm:ligtInWijk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De eigenschap 'ligt in wijk' geeft aan dat een buurt zich binnen een specifieke wijk bevindt, waarbij een wijk een afgebakend gebied is binnen een stad of dorp.</para>
    ///   <para>The property 'located in district' indicates that an neighbourhood is situated within a specific district, where a district is a defined area within a city or town.</para>
    /// labels<para>is located in district</para><para>ligt in wijk</para></remarks>
    /// <seealso href="https://www.goudatijdmachine.nl/def#ligtInWijk">https://www.goudatijdmachine.nl/def#ligtInWijk</seealso>
    let ligtInWijk = Prefixed_Name(gtm, "ligtInWijk") |> PrefixedName
