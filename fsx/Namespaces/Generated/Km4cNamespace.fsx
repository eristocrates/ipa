#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module km4c =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.disit.org/km4city/schema#" "km4c"

    /// <summary>
    ///   <para>rdfs:comment : Corsa programmata da una certa azienda TPL su un certo percorso di una certa linea^^xsd:string</para>
    ///   <para>rdfs:label : Registrazione AVMrdfs:label : AVM Record</para>
    ///   <a href="http://www.disit.org/km4city/schema#AVMRecord">km4c:AVMRecord</a>
    /// </summary>
    let AVMRecord = _prefixId.prefix "AVMRecord"
    /// <summary>
    ///   <para>rdfs:comment : Alberghi e strutture simili^^xsd:string</para>
    ///   <para>rdfs:label : Alloggiordfs:label : Accommodation</para>
    ///   <a href="http://www.disit.org/km4city/schema#Accommodation">km4c:Accommodation</a>
    /// </summary>
    let Accommodation = _prefixId.prefix "Accommodation"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio Container per alloggi o ufficordfs:label : Accommodation or office containers rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Accommodation_or_office_containers_rental">km4c:Accommodation_or_office_containers_rental</a>
    /// </summary>
    let Accommodation_or_office_containers_rental = _prefixId.prefix "Accommodation_or_office_containers_rental"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ragionieri Commercialisti e periti commercialirdfs:label : Accountants</para>
    ///   <a href="http://www.disit.org/km4city/schema#Accountants">km4c:Accountants</a>
    /// </summary>
    let Accountants = _prefixId.prefix "Accountants"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Comunita e centri di recupero per dipendenzerdfs:label : Addiction recovery centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Addiction_recovery_centre">km4c:Addiction_recovery_centre</a>
    /// </summary>
    let Addiction_recovery_centre = _prefixId.prefix "Addiction_recovery_centre"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le estese amministrative definite nel grafo stradale^^xsd:string</para>
    ///   <para>rdfs:label : Estesa Amministrativardfs:label : Administrative Road</para>
    ///   <a href="http://www.disit.org/km4city/schema#AdministrativeRoad">km4c:AdministrativeRoad</a>
    /// </summary>
    let AdministrativeRoad = _prefixId.prefix "AdministrativeRoad"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Abbigliamento Uomo Donnardfs:label : Adult Clothing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Adult_clothing">km4c:Adult_clothing</a>
    /// </summary>
    let Adult_clothing = _prefixId.prefix "Adult_clothing"
    /// <summary>
    ///   <para>rdfs:comment : Servizi legati al mondo della pubblicita'^^xsd:string</para>
    ///   <para>rdfs:label : Pubblicita'rdfs:label : Advertising</para>
    ///   <a href="http://www.disit.org/km4city/schema#Advertising">km4c:Advertising</a>
    /// </summary>
    let Advertising = _prefixId.prefix "Advertising"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pubblicita' e Concessionarierdfs:label : Advertising and promotion</para>
    ///   <a href="http://www.disit.org/km4city/schema#Advertising_and_promotion">km4c:Advertising_and_promotion</a>
    /// </summary>
    let Advertising_and_promotion = _prefixId.prefix "Advertising_and_promotion"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenti e procuratorirdfs:label : Agents</para>
    ///   <a href="http://www.disit.org/km4city/schema#Agents">km4c:Agents</a>
    /// </summary>
    let Agents = _prefixId.prefix "Agents"
    /// <summary>
    ///   <para>rdfs:comment : Attivita' e servizi relativi ad agricoltura ed allevamento^^xsd:string</para>
    ///   <para>rdfs:label : Agricoltura ed allevamentordfs:label : Agriculture and livestock</para>
    ///   <a href="http://www.disit.org/km4city/schema#AgricultureAndLivestock">km4c:AgricultureAndLivestock</a>
    /// </summary>
    let AgricultureAndLivestock = _prefixId.prefix "AgricultureAndLivestock"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agriturismordfs:label : Agritourism</para>
    ///   <a href="http://www.disit.org/km4city/schema#Agritourism">km4c:Agritourism</a>
    /// </summary>
    let Agritourism = _prefixId.prefix "Agritourism"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Aviosuperficirdfs:label : Airfields</para>
    ///   <a href="http://www.disit.org/km4city/schema#Airfields">km4c:Airfields</a>
    /// </summary>
    let Airfields = _prefixId.prefix "Airfields"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio aereirdfs:label : Airplanes rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Airplanes_rental">km4c:Airplanes_rental</a>
    /// </summary>
    let Airplanes_rental = _prefixId.prefix "Airplanes_rental"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ufficio oggetti smarriti aeroportordfs:label : Airport lost property office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Airport_lost_property_office">km4c:Airport_lost_property_office</a>
    /// </summary>
    let Airport_lost_property_office = _prefixId.prefix "Airport_lost_property_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Attivita' ricreativerdfs:label : Amusement activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Amusement_activities">km4c:Amusement_activities</a>
    /// </summary>
    let Amusement_activities = _prefixId.prefix "Amusement_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Parchi divertimento e tematicirdfs:label : Amusement and theme parks</para>
    ///   <a href="http://www.disit.org/km4city/schema#Amusement_and_theme_parks">km4c:Amusement_and_theme_parks</a>
    /// </summary>
    let Amusement_and_theme_parks = _prefixId.prefix "Amusement_and_theme_parks"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Mangimirdfs:label : Animal Feeds Manufacture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Animal_feeds_manufacture">km4c:Animal_feeds_manufacture</a>
    /// </summary>
    let Animal_feeds_manufacture = _prefixId.prefix "Animal_feeds_manufacture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Animalirdfs:label : Animal Production</para>
    ///   <a href="http://www.disit.org/km4city/schema#Animal_production">km4c:Animal_production</a>
    /// </summary>
    let Animal_production = _prefixId.prefix "Animal_production"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Antichita'rdfs:label : Antiques</para>
    ///   <a href="http://www.disit.org/km4city/schema#Antiques">km4c:Antiques</a>
    /// </summary>
    let Antiques = _prefixId.prefix "Antiques"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Acquariordfs:label : Aquarium</para>
    ///   <a href="http://www.disit.org/km4city/schema#Aquarium">km4c:Aquarium</a>
    /// </summary>
    let Aquarium = _prefixId.prefix "Aquarium"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Sito archeologicordfs:label : Archaeological site</para>
    ///   <a href="http://www.disit.org/km4city/schema#Archaeological_site">km4c:Archaeological_site</a>
    /// </summary>
    let Archaeological_site = _prefixId.prefix "Archaeological_site"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Studi di Architetturardfs:label : Architectural consulting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Architectural_consulting">km4c:Architectural_consulting</a>
    /// </summary>
    let Architectural_consulting = _prefixId.prefix "Architectural_consulting"
    /// <summary>
    ///   <para>rdfs:comment : Servizi rappresentati da un'area di forma poligonale^^xsd:string</para>
    ///   <para>rdfs:label : Servizio di forma poligonalerdfs:label : Polygonal Service</para>
    ///   <a href="http://www.disit.org/km4city/schema#Area">km4c:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Gallerie Arterdfs:label : Art Galleries</para>
    ///   <a href="http://www.disit.org/km4city/schema#Art_galleries">km4c:Art_galleries</a>
    /// </summary>
    let Art_galleries = _prefixId.prefix "Art_galleries"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Negozio artigianordfs:label : Artisanshop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Artisan_shop">km4c:Artisan_shop</a>
    /// </summary>
    let Artisan_shop = _prefixId.prefix "Artisan_shop"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Associazionirdfs:label : Associations</para>
    ///   <a href="http://www.disit.org/km4city/schema#Associations">km4c:Associations</a>
    /// </summary>
    let Associations = _prefixId.prefix "Associations"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Atmrdfs:label : Atm</para>
    ///   <a href="http://www.disit.org/km4city/schema#Atm">km4c:Atm</a>
    /// </summary>
    let Atm = _prefixId.prefix "Atm"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Case d'Astardfs:label : Auctioning Houses</para>
    ///   <a href="http://www.disit.org/km4city/schema#Auctioning_houses">km4c:Auctioning_houses</a>
    /// </summary>
    let Auctioning_houses = _prefixId.prefix "Auctioning_houses"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Audio e Videordfs:label : Audio and Video</para>
    ///   <a href="http://www.disit.org/km4city/schema#Audio_and_video">km4c:Audio_and_video</a>
    /// </summary>
    let Audio_and_video = _prefixId.prefix "Audio_and_video"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Revisione e cerificazione bilancirdfs:label : Auditing activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Auditing_activities">km4c:Auditing_activities</a>
    /// </summary>
    let Auditing_activities = _prefixId.prefix "Auditing_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Auditoriumrdfs:label : Auditorium</para>
    ///   <a href="http://www.disit.org/km4city/schema#Auditorium">km4c:Auditorium</a>
    /// </summary>
    let Auditorium = _prefixId.prefix "Auditorium"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Autoscuole, scuole di pilotaggio e nauticherdfs:label : Automobile driving and flying schools</para>
    ///   <a href="http://www.disit.org/km4city/schema#Automobile_driving_and_flying_schools">km4c:Automobile_driving_and_flying_schools</a>
    /// </summary>
    let Automobile_driving_and_flying_schools = _prefixId.prefix "Automobile_driving_and_flying_schools"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Fornordfs:label : Bakery</para>
    ///   <a href="http://www.disit.org/km4city/schema#Bakery">km4c:Bakery</a>
    /// </summary>
    let Bakery = _prefixId.prefix "Bakery"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Bancardfs:label : Bank</para>
    ///   <a href="http://www.disit.org/km4city/schema#Bank">km4c:Bank</a>
    /// </summary>
    let Bank = _prefixId.prefix "Bank"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Barrdfs:label : Bar</para>
    ///   <a href="http://www.disit.org/km4city/schema#Bar">km4c:Bar</a>
    /// </summary>
    let Bar = _prefixId.prefix "Bar"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Stabilimento balnearerdfs:label : Beach resort</para>
    ///   <a href="http://www.disit.org/km4city/schema#Beach_resort">km4c:Beach_resort</a>
    /// </summary>
    let Beach_resort = _prefixId.prefix "Beach_resort"
    /// <summary>
    ///   <para>rdfs:comment : Servizio associato ai Beacon che permettono di ricevere offerte^^xsd:stringrdfs:comment : Singolo beacon installato^^xsd:string</para>
    ///   <para>rdfs:label : Beaconrdfs:label : Beacon</para>
    ///   <a href="http://www.disit.org/km4city/schema#Beacon">km4c:Beacon</a>
    /// </summary>
    let Beacon = _prefixId.prefix "Beacon"
    /// <summary>
    ///   <para>rdfs:comment : lettura proveniente da un singolo beacon^^xsd:string</para>
    ///   <para>rdfs:label : Lettura di un beaconrdfs:label : Beacon observation</para>
    ///   <a href="http://www.disit.org/km4city/schema#BeaconObservation">km4c:BeaconObservation</a>
    /// </summary>
    let BeaconObservation = _prefixId.prefix "BeaconObservation"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Istituti di bellezzardfs:label : Beauty centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Beauty_centre">km4c:Beauty_centre</a>
    /// </summary>
    let Beauty_centre = _prefixId.prefix "Beauty_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Bed and breakfastrdfs:label : Bed and breakfast</para>
    ///   <a href="http://www.disit.org/km4city/schema#Bed_and_breakfast">km4c:Bed_and_breakfast</a>
    /// </summary>
    let Bed_and_breakfast = _prefixId.prefix "Bed_and_breakfast"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ricevitorierdfs:label : Betting shops</para>
    ///   <a href="http://www.disit.org/km4city/schema#Betting_shops">km4c:Betting_shops</a>
    /// </summary>
    let Betting_shops = _prefixId.prefix "Betting_shops"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Bevanderdfs:label : Beverage Manufacture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Beverage_manufacture">km4c:Beverage_manufacture</a>
    /// </summary>
    let Beverage_manufacture = _prefixId.prefix "Beverage_manufacture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rastrelliera per bicicletterdfs:label : Bike rack</para>
    ///   <a href="http://www.disit.org/km4city/schema#Bike_rack">km4c:Bike_rack</a>
    /// </summary>
    let Bike_rack = _prefixId.prefix "Bike_rack"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Punto noleggio bicirdfs:label : Bike rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Bike_rental">km4c:Bike_rental</a>
    /// </summary>
    let Bike_rental = _prefixId.prefix "Bike_rental"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Affittacamererdfs:label : Boarding house</para>
    ///   <a href="http://www.disit.org/km4city/schema#Boarding_house">km4c:Boarding_house</a>
    /// </summary>
    let Boarding_house = _prefixId.prefix "Boarding_house"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli per natantirdfs:label : Boat equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Boat_equipment">km4c:Boat_equipment</a>
    /// </summary>
    let Boat_equipment = _prefixId.prefix "Boat_equipment"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio barcherdfs:label : Boats and ships rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Boats_and_ships_rental">km4c:Boats_and_ships_rental</a>
    /// </summary>
    let Boats_and_ships_rental = _prefixId.prefix "Boats_and_ships_rental"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Libreria, cartolibreriardfs:label : Book Shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Bookshop">km4c:Bookshop</a>
    /// </summary>
    let Bookshop = _prefixId.prefix "Bookshop"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Giardini botanici e zoologicirdfs:label : Botanical and zoological gardens</para>
    ///   <a href="http://www.disit.org/km4city/schema#Botanical_and_zoological_gardens">km4c:Botanical_and_zoological_gardens</a>
    /// </summary>
    let Botanical_and_zoological_gardens = _prefixId.prefix "Botanical_and_zoological_gardens"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Boxofficerdfs:label : Boxoffice</para>
    ///   <a href="http://www.disit.org/km4city/schema#Boxoffice">km4c:Boxoffice</a>
    /// </summary>
    let Boxoffice = _prefixId.prefix "Boxoffice"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pulizia edifici e impianti industrialirdfs:label : Building and industrial cleaning activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Building_and_industrial_cleaning_activities">km4c:Building_and_industrial_cleaning_activities</a>
    /// </summary>
    let Building_and_industrial_cleaning_activities = _prefixId.prefix "Building_and_industrial_cleaning_activities"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Costruzione Edificirdfs:label : Building Construction</para>
    ///   <a href="http://www.disit.org/km4city/schema#Building_construction">km4c:Building_construction</a>
    /// </summary>
    let Building_construction = _prefixId.prefix "Building_construction"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Materiali Edilirdfs:label : Building Material</para>
    ///   <a href="http://www.disit.org/km4city/schema#Building_material">km4c:Building_material</a>
    /// </summary>
    let Building_material = _prefixId.prefix "Building_material"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Materiali Edilirdfs:label : Building Materials Manufacture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Building_materials_manufacture">km4c:Building_materials_manufacture</a>
    /// </summary>
    let Building_materials_manufacture = _prefixId.prefix "Building_materials_manufacture"

    /// <summary>
    ///   <para>rdfs:label : Bus Stoprdfs:label : Fermata bus</para>
    ///   <para>rdfs:comment : Punto di interconnessione tra segmenti di strada per determinare il percorso di una linea di TPL^^xsd:stringrdfs:comment : Servizio associato alla visualizzazione delle linee ATAF con le relative fermate^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#BusStop">km4c:BusStop</a>
    /// </summary>
    let BusStop = _prefixId.prefix "BusStop"
    /// <summary>
    ///   <para>rdfs:comment : previsione di arrivo ad una certa fermata^^xsd:string</para>
    ///   <para>rdfs:label : Previsione arrivo in fermatardfs:label : BusStop Forecast</para>
    ///   <a href="http://www.disit.org/km4city/schema#BusStopForecast">km4c:BusStopForecast</a>
    /// </summary>
    let BusStopForecast = _prefixId.prefix "BusStopForecast"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rivendita biglietti autobusrdfs:label : Bus tickets retail</para>
    ///   <a href="http://www.disit.org/km4city/schema#Bus_tickets_retail">km4c:Bus_tickets_retail</a>
    /// </summary>
    let Bus_tickets_retail = _prefixId.prefix "Bus_tickets_retail"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Sostegno alle impreserdfs:label : Business support</para>
    ///   <a href="http://www.disit.org/km4city/schema#Business_support">km4c:Business_support</a>
    /// </summary>
    let Business_support = _prefixId.prefix "Business_support"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Call Centerrdfs:label : Call center</para>
    ///   <a href="http://www.disit.org/km4city/schema#Call_center">km4c:Call_center</a>
    /// </summary>
    let Call_center = _prefixId.prefix "Call_center"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Camper servicerdfs:label : Camper service</para>
    ///   <a href="http://www.disit.org/km4city/schema#Camper_service">km4c:Camper_service</a>
    /// </summary>
    let Camper_service = _prefixId.prefix "Camper_service"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Campeggiordfs:label : Camping</para>
    ///   <a href="http://www.disit.org/km4city/schema#Camping">km4c:Camping</a>
    /// </summary>
    let Camping = _prefixId.prefix "Camping"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Mense e servizi di ristorazionerdfs:label : Canteens and Food Service</para>
    ///   <a href="http://www.disit.org/km4city/schema#Canteens_and_food_service">km4c:Canteens_and_food_service</a>
    /// </summary>
    let Canteens_and_food_service = _prefixId.prefix "Canteens_and_food_service"
    /// <summary>
    ///   <para>rdfs:comment : Sensore che raccoglie i dati all'interno di un parcheggio^^xsd:string</para>
    ///   <para>rdfs:label : Sensore presente in parcheggiordfs:label : Car Park Sensor</para>
    ///   <a href="http://www.disit.org/km4city/schema#CarParkSensor">km4c:CarParkSensor</a>
    /// </summary>
    let CarParkSensor = _prefixId.prefix "CarParkSensor"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Parcheggio autordfs:label : Car park</para>
    ///   <a href="http://www.disit.org/km4city/schema#Car_park">km4c:Car_park</a>
    /// </summary>
    let Car_park = _prefixId.prefix "Car_park"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio Auto con Conducenterdfs:label : Car Rental With Driver</para>
    ///   <a href="http://www.disit.org/km4city/schema#Car_rental_with_driver">km4c:Car_rental_with_driver</a>
    /// </summary>
    let Car_rental_with_driver = _prefixId.prefix "Car_rental_with_driver"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Lavaggio Autordfs:label : Car Washing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Car_washing">km4c:Car_washing</a>
    /// </summary>
    let Car_washing = _prefixId.prefix "Car_washing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Carabinierirdfs:label : Carabinieri</para>
    ///   <a href="http://www.disit.org/km4city/schema#Carabinieri">km4c:Carabinieri</a>
    /// </summary>
    let Carabinieri = _prefixId.prefix "Carabinieri"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Movimentazione Mercirdfs:label : Cargo Handling</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cargo_handling">km4c:Cargo_handling</a>
    /// </summary>
    let Cargo_handling = _prefixId.prefix "Cargo_handling"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Falegnamerierdfs:label : Carpentry</para>
    ///   <a href="http://www.disit.org/km4city/schema#Carpentry">km4c:Carpentry</a>
    /// </summary>
    let Carpentry = _prefixId.prefix "Carpentry"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Tappetirdfs:label : Carpets</para>
    ///   <a href="http://www.disit.org/km4city/schema#Carpets">km4c:Carpets</a>
    /// </summary>
    let Carpets = _prefixId.prefix "Carpets"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Tappeti e Tenderdfs:label : Carpets and Curtains</para>
    ///   <a href="http://www.disit.org/km4city/schema#Carpets_and_curtains">km4c:Carpets_and_curtains</a>
    /// </summary>
    let Carpets_and_curtains = _prefixId.prefix "Carpets_and_curtains"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Cartografirdfs:label : Cartographers</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cartographers">km4c:Cartographers</a>
    /// </summary>
    let Cartographers = _prefixId.prefix "Cartographers"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Cateringrdfs:label : Catering</para>
    ///   <a href="http://www.disit.org/km4city/schema#Catering">km4c:Catering</a>
    /// </summary>
    let Catering = _prefixId.prefix "Catering"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Colonnina di ricaricardfs:label : Charging stations</para>
    ///   <a href="http://www.disit.org/km4city/schema#Charging_stations">km4c:Charging_stations</a>
    /// </summary>
    let Charging_stations = _prefixId.prefix "Charging_stations"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Compagnie di Charterrdfs:label : Charter Airlines</para>
    ///   <a href="http://www.disit.org/km4city/schema#Charter_airlines">km4c:Charter_airlines</a>
    /// </summary>
    let Charter_airlines = _prefixId.prefix "Charter_airlines"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Chieserdfs:label : Churches</para>
    ///   <a href="http://www.disit.org/km4city/schema#Churches">km4c:Churches</a>
    /// </summary>
    let Churches = _prefixId.prefix "Churches"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Cinemardfs:label : Cinema</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cinema">km4c:Cinema</a>
    /// </summary>
    let Cinema = _prefixId.prefix "Cinema"
    /// <summary>
    ///   <para>rdfs:comment : Servizi legati all'ingegneria civile ed edile^^xsd:string</para>
    ///   <para>rdfs:label : Ingegneria civile ed edilerdfs:label : Civil and edil engineering</para>
    ///   <a href="http://www.disit.org/km4city/schema#CivilAndEdilEngineering">km4c:CivilAndEdilEngineering</a>
    /// </summary>
    let CivilAndEdilEngineering = _prefixId.prefix "CivilAndEdilEngineering"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Aeroporto civilerdfs:label : Civil airport</para>
    ///   <a href="http://www.disit.org/km4city/schema#Civil_airport">km4c:Civil_airport</a>
    /// </summary>
    let Civil_airport = _prefixId.prefix "Civil_airport"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ingegneria Civilerdfs:label : Civil Engineering</para>
    ///   <a href="http://www.disit.org/km4city/schema#Civil_engineering">km4c:Civil_engineering</a>
    /// </summary>
    let Civil_engineering = _prefixId.prefix "Civil_engineering"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Protezione civilerdfs:label : Civil protection</para>
    ///   <a href="http://www.disit.org/km4city/schema#Civil_protection">km4c:Civil_protection</a>
    /// </summary>
    let Civil_protection = _prefixId.prefix "Civil_protection"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Anagraferdfs:label : Civil registry</para>
    ///   <a href="http://www.disit.org/km4city/schema#Civil_registry">km4c:Civil_registry</a>
    /// </summary>
    let Civil_registry = _prefixId.prefix "Civil_registry"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Puliziardfs:label : Cleaning activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cleaning_activities">km4c:Cleaning_activities</a>
    /// </summary>
    let Cleaning_activities = _prefixId.prefix "Cleaning_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Prodotti Puliziardfs:label : Cleaning Materials</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cleaning_materials">km4c:Cleaning_materials</a>
    /// </summary>
    let Cleaning_materials = _prefixId.prefix "Cleaning_materials"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Alpinismordfs:label : Climbing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Climbing">km4c:Climbing</a>
    /// </summary>
    let Climbing = _prefixId.prefix "Climbing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Abbigliamentordfs:label : Clothing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Clothing">km4c:Clothing</a>
    /// </summary>
    let Clothing = _prefixId.prefix "Clothing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Accessori Abbigliamentordfs:label : Clothing Accessories</para>
    ///   <a href="http://www.disit.org/km4city/schema#Clothing_accessories">km4c:Clothing_accessories</a>
    /// </summary>
    let Clothing_accessories = _prefixId.prefix "Clothing_accessories"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Abbigliamento e Biancheriardfs:label : Clothing and Linen</para>
    ///   <a href="http://www.disit.org/km4city/schema#Clothing_and_linen">km4c:Clothing_and_linen</a>
    /// </summary>
    let Clothing_and_linen = _prefixId.prefix "Clothing_and_linen"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Abbigliamento Bambinordfs:label : Clothing Children and Infants</para>
    ///   <a href="http://www.disit.org/km4city/schema#Clothing_children_and_infants">km4c:Clothing_children_and_infants</a>
    /// </summary>
    let Clothing_children_and_infants = _prefixId.prefix "Clothing_children_and_infants"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Spacci outlet abbigliamentordfs:label : Clothing factory outlet</para>
    ///   <a href="http://www.disit.org/km4city/schema#Clothing_factory_outlet">km4c:Clothing_factory_outlet</a>
    /// </summary>
    let Clothing_factory_outlet = _prefixId.prefix "Clothing_factory_outlet"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Guardia costiera capitaneria di portordfs:label : Coast guard harbormaster</para>
    ///   <a href="http://www.disit.org/km4city/schema#Coast_guard_harbormaster">km4c:Coast_guard_harbormaster</a>
    /// </summary>
    let Coast_guard_harbormaster = _prefixId.prefix "Coast_guard_harbormaster"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Torrefazionirdfs:label : Coffee Rosters</para>
    ///   <a href="http://www.disit.org/km4city/schema#Coffee_rosters">km4c:Coffee_rosters</a>
    /// </summary>
    let Coffee_rosters = _prefixId.prefix "Coffee_rosters"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Coke e Petroliferi Derivatirdfs:label : Coke and Petroleum Derivatives</para>
    ///   <a href="http://www.disit.org/km4city/schema#Coke_and_petroleum_derivatives">km4c:Coke_and_petroleum_derivatives</a>
    /// </summary>
    let Coke_and_petroleum_derivatives = _prefixId.prefix "Coke_and_petroleum_derivatives"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Servizi integrati di gestione agli edificirdfs:label : Combined facilities support activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Combined_facilities_support_activities">km4c:Combined_facilities_support_activities</a>
    /// </summary>
    let Combined_facilities_support_activities = _prefixId.prefix "Combined_facilities_support_activities"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Commissariato di pubblica sicurezzardfs:label : Commissariat of public safety</para>
    ///   <a href="http://www.disit.org/km4city/schema#Commissariat_of_public_safety">km4c:Commissariat_of_public_safety</a>
    /// </summary>
    let Commissariat_of_public_safety = _prefixId.prefix "Commissariat_of_public_safety"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri diurnirdfs:label : Community centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Community_centre">km4c:Community_centre</a>
    /// </summary>
    let Community_centre = _prefixId.prefix "Community_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Elaborazione datirdfs:label : Computer data processing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Computer_data_processing">km4c:Computer_data_processing</a>
    /// </summary>
    let Computer_data_processing = _prefixId.prefix "Computer_data_processing"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Programmazione e consulenza computerrdfs:label : Computer programming and consultancy</para>
    ///   <a href="http://www.disit.org/km4city/schema#Computer_programming_and_consultancy">km4c:Computer_programming_and_consultancy</a>
    /// </summary>
    let Computer_programming_and_consultancy = _prefixId.prefix "Computer_programming_and_consultancy"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Informaticardfs:label : Computer Systems</para>
    ///   <a href="http://www.disit.org/km4city/schema#Computer_systems">km4c:Computer_systems</a>
    /// </summary>
    let Computer_systems = _prefixId.prefix "Computer_systems"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione computer e perifericherdfs:label : Computer technician</para>
    ///   <a href="http://www.disit.org/km4city/schema#Computer_technician">km4c:Computer_technician</a>
    /// </summary>
    let Computer_technician = _prefixId.prefix "Computer_technician"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Conservatoriordfs:label : Conservatory</para>
    ///   <a href="http://www.disit.org/km4city/schema#Conservatory">km4c:Conservatory</a>
    /// </summary>
    let Conservatory = _prefixId.prefix "Conservatory"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Consolatordfs:label : Consulate</para>
    ///   <a href="http://www.disit.org/km4city/schema#Consulate">km4c:Consulate</a>
    /// </summary>
    let Consulate = _prefixId.prefix "Consulate"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Servizi di Consulenzardfs:label : Consulting services</para>
    ///   <a href="http://www.disit.org/km4city/schema#Consulting_services">km4c:Consulting_services</a>
    /// </summary>
    let Consulting_services = _prefixId.prefix "Consulting_services"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Zona a sosta controllatardfs:label : Controlled parking zone</para>
    ///   <a href="http://www.disit.org/km4city/schema#Controlled_parking_zone">km4c:Controlled_parking_zone</a>
    /// </summary>
    let Controlled_parking_zone = _prefixId.prefix "Controlled_parking_zone"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Corpo forestale dello statordfs:label : Corps of forest rangers</para>
    ///   <a href="http://www.disit.org/km4city/schema#Corps_of_forest_rangers">km4c:Corps_of_forest_rangers</a>
    /// </summary>
    let Corps_of_forest_rangers = _prefixId.prefix "Corps_of_forest_rangers"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Corriere espressordfs:label : Courier</para>
    ///   <a href="http://www.disit.org/km4city/schema#Courier">km4c:Courier</a>
    /// </summary>
    let Courier = _prefixId.prefix "Courier"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenzie recupero creditirdfs:label : Credit collection agencies</para>
    ///   <a href="http://www.disit.org/km4city/schema#Credit_collection_agencies">km4c:Credit_collection_agencies</a>
    /// </summary>
    let Credit_collection_agencies = _prefixId.prefix "Credit_collection_agencies"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Animali, Vegetali e Cacciardfs:label : Crop Animal Production Hunting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Crop_animal_production_hunting">km4c:Crop_animal_production_hunting</a>
    /// </summary>
    let Crop_animal_production_hunting = _prefixId.prefix "Crop_animal_production_hunting"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Vegetalirdfs:label : Crop Production</para>
    ///   <a href="http://www.disit.org/km4city/schema#Crop_production">km4c:Crop_production</a>
    /// </summary>
    let Crop_production = _prefixId.prefix "Crop_production"
    /// <summary>
    ///   <para>rdfs:comment : biblioteche, archivi, musei ed altre attivita' culturali^^xsd:string</para>
    ///   <para>rdfs:label : Attivita' Culturalerdfs:label : Cultural Activity</para>
    ///   <a href="http://www.disit.org/km4city/schema#CulturalActivity">km4c:CulturalActivity</a>
    /// </summary>
    let CulturalActivity = _prefixId.prefix "CulturalActivity"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli Culturali e Ricreativirdfs:label : Cultural and Recreation Goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cultural_and_recreation_goods">km4c:Cultural_and_recreation_goods</a>
    /// </summary>
    let Cultural_and_recreation_goods = _prefixId.prefix "Cultural_and_recreation_goods"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centro culturalerdfs:label : Cultural centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cultural_centre">km4c:Cultural_centre</a>
    /// </summary>
    let Cultural_centre = _prefixId.prefix "Cultural_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Formazione culturalerdfs:label : Cultural education</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cultural_education">km4c:Cultural_education</a>
    /// </summary>
    let Cultural_education = _prefixId.prefix "Cultural_education"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Attivita' culturalirdfs:label : Cultural sites</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cultural_sites">km4c:Cultural_sites</a>
    /// </summary>
    let Cultural_sites = _prefixId.prefix "Cultural_sites"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Tende e Tendinerdfs:label : Curtains and Net Curtains</para>
    ///   <a href="http://www.disit.org/km4city/schema#Curtains_and_net_curtains">km4c:Curtains_and_net_curtains</a>
    /// </summary>
    let Curtains_and_net_curtains = _prefixId.prefix "Curtains_and_net_curtains"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ciclopercorsirdfs:label : Cycle paths</para>
    ///   <a href="http://www.disit.org/km4city/schema#Cycle_paths">km4c:Cycle_paths</a>
    /// </summary>
    let Cycle_paths = _prefixId.prefix "Cycle_paths"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Latte e Latticinirdfs:label : Dairy products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Dairy_products">km4c:Dairy_products</a>
    /// </summary>
    let Dairy_products = _prefixId.prefix "Dairy_products"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole di danzardfs:label : Dance schools</para>
    ///   <a href="http://www.disit.org/km4city/schema#Dance_schools">km4c:Dance_schools</a>
    /// </summary>
    let Dance_schools = _prefixId.prefix "Dance_schools"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenzie matrimonialirdfs:label : Dating service</para>
    ///   <a href="http://www.disit.org/km4city/schema#Dating_service">km4c:Dating_service</a>
    /// </summary>
    let Dating_service = _prefixId.prefix "Dating_service"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri accoglienza e case alloggiordfs:label : Day care centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Day_care_centre">km4c:Day_care_centre</a>
    /// </summary>
    let Day_care_centre = _prefixId.prefix "Day_care_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Dentistardfs:label : Dentist</para>
    ///   <a href="http://www.disit.org/km4city/schema#Dentist">km4c:Dentist</a>
    /// </summary>
    let Dentist = _prefixId.prefix "Dentist"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Motorizzazione civilerdfs:label : Department of motor vehicles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Department_of_motor_vehicles">km4c:Department_of_motor_vehicles</a>
    /// </summary>
    let Department_of_motor_vehicles = _prefixId.prefix "Department_of_motor_vehicles"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Prodotti Dieteticirdfs:label : Diet Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Diet_products">km4c:Diet_products</a>
    /// </summary>
    let Diet_products = _prefixId.prefix "Diet_products"
    /// <summary>
    ///   <para>rdfs:comment : Servizi classificati dal comune di Firenze come Digital Location^^xsd:string</para>
    ///   <para>rdfs:label : Digital Locationrdfs:label : Digital Location</para>
    ///   <a href="http://www.disit.org/km4city/schema#DigitalLocation">km4c:DigitalLocation</a>
    /// </summary>
    let DigitalLocation = _prefixId.prefix "DigitalLocation"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Menserdfs:label : Dining hall</para>
    ///   <a href="http://www.disit.org/km4city/schema#Dining_hall">km4c:Dining_hall</a>
    /// </summary>
    let Dining_hall = _prefixId.prefix "Dining_hall"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Discotecardfs:label : Discotheque</para>
    ///   <a href="http://www.disit.org/km4city/schema#Discotheque">km4c:Discotheque</a>
    /// </summary>
    let Discotheque = _prefixId.prefix "Discotheque"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Discountrdfs:label : Discount</para>
    ///   <a href="http://www.disit.org/km4city/schema#Discount">km4c:Discount</a>
    /// </summary>
    let Discount = _prefixId.prefix "Discount"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pulizia e disinfestazionerdfs:label : Disinfecting and exterminating activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Disinfecting_and_exterminating_activities">km4c:Disinfecting_and_exterminating_activities</a>
    /// </summary>
    let Disinfecting_and_exterminating_activities = _prefixId.prefix "Disinfecting_and_exterminating_activities"

    /// <summary>
    ///   <para>rdfs:comment : Zona che rappresenta l'estensione di un quartiere^^xsd:string</para>
    ///   <para>rdfs:label : Quartiererdfs:label : District</para>
    ///   <a href="http://www.disit.org/km4city/schema#District">km4c:District</a>
    /// </summary>
    let District = _prefixId.prefix "District"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuola di subrdfs:label : Diving school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Diving_school">km4c:Diving_school</a>
    /// </summary>
    let Diving_school = _prefixId.prefix "Diving_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ambulatorio medicordfs:label : Doctor office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Doctor_office">km4c:Doctor_office</a>
    /// </summary>
    let Doctor_office = _prefixId.prefix "Doctor_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Porta a Portardfs:label : Door to Door</para>
    ///   <a href="http://www.disit.org/km4city/schema#Door_to_door">km4c:Door_to_door</a>
    /// </summary>
    let Door_to_door = _prefixId.prefix "Door_to_door"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Fontanellerdfs:label : Drinking fountain</para>
    ///   <a href="http://www.disit.org/km4city/schema#Drinking_fountain">km4c:Drinking_fountain</a>
    /// </summary>
    let Drinking_fountain = _prefixId.prefix "Drinking_fountain"
    /// <summary>
    ///   <para>rdfs:comment : Servizi quali scuole per ogni eta' e scuole di formazione^^xsd:string</para>
    ///   <para>rdfs:label : Istruzionerdfs:label : EducationAndResearch</para>
    ///   <a href="http://www.disit.org/km4city/schema#EducationAndResearch">km4c:EducationAndResearch</a>
    /// </summary>
    let EducationAndResearch = _prefixId.prefix "EducationAndResearch"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Altri servizi all'istruzionerdfs:label : Educational support activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Educational_support_activities">km4c:Educational_support_activities</a>
    /// </summary>
    let Educational_support_activities = _prefixId.prefix "Educational_support_activities"

    /// <summary>
    ///   <para>rdfs:comment : Contiene tutte le classi relative ai servizi di emergenza^^xsd:string</para>
    ///   <para>rdfs:label : Emergenzerdfs:label : Emergency</para>
    ///   <a href="http://www.disit.org/km4city/schema#Emergency">km4c:Emergency</a>
    /// </summary>
    let Emergency = _prefixId.prefix "Emergency"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Guardia medicardfs:label : Emergency medical care</para>
    ///   <a href="http://www.disit.org/km4city/schema#Emergency_medical_care">km4c:Emergency_medical_care</a>
    /// </summary>
    let Emergency_medical_care = _prefixId.prefix "Emergency_medical_care"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Soccorso stradalerdfs:label : Emergency services</para>
    ///   <a href="http://www.disit.org/km4city/schema#Emergency_services">km4c:Emergency_services</a>
    /// </summary>
    let Emergency_services = _prefixId.prefix "Emergency_services"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centro per l'impiegordfs:label : Employment exchange</para>
    ///   <a href="http://www.disit.org/km4city/schema#Employment_exchange">km4c:Employment_exchange</a>
    /// </summary>
    let Employment_exchange = _prefixId.prefix "Employment_exchange"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Fornitura Produzione Energiardfs:label : Energy Supply</para>
    ///   <a href="http://www.disit.org/km4city/schema#Energy_supply">km4c:Energy_supply</a>
    /// </summary>
    let Energy_supply = _prefixId.prefix "Energy_supply"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Studi di Ingegneriardfs:label : Engineering consulting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Engineering_consulting">km4c:Engineering_consulting</a>
    /// </summary>
    let Engineering_consulting = _prefixId.prefix "Engineering_consulting"
    /// <summary>
    ///   <para>rdfs:comment : Servizi per l'intrattenimento del cittadino^^xsd:string</para>
    ///   <para>rdfs:label : Intrattenimentordfs:label : Entertainment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Entertainment">km4c:Entertainment</a>
    /// </summary>
    let Entertainment = _prefixId.prefix "Entertainment"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono i possibili ingressi ai numeri civici^^xsd:string</para>
    ///   <para>rdfs:label : Accessordfs:label : Entry</para>
    ///   <a href="http://www.disit.org/km4city/schema#Entry">km4c:Entry</a>
    /// </summary>
    let Entry = _prefixId.prefix "Entry"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le regole di accesso ai differenti elementi stradali^^xsd:string</para>
    ///   <para>rdfs:label : Regola di Acessordfs:label : Entry Rule</para>
    ///   <a href="http://www.disit.org/km4city/schema#EntryRule">km4c:EntryRule</a>
    /// </summary>
    let EntryRule = _prefixId.prefix "EntryRule"
    /// <summary>
    ///   <para>rdfs:comment : Servizi legati all'ambiente^^xsd:string</para>
    ///   <para>rdfs:label : Ambienterdfs:label : Environment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Environment">km4c:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio attrezzature per manifestazioni e spettacolirdfs:label : Equipment for events and shows rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Equipment_for_events_and_shows_rental">km4c:Equipment_for_events_and_shows_rental</a>
    /// </summary>
    let Equipment_for_events_and_shows_rental = _prefixId.prefix "Equipment_for_events_and_shows_rental"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenzia immobiliarerdfs:label : Estate activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Estate_activities">km4c:Estate_activities</a>
    /// </summary>
    let Estate_activities = _prefixId.prefix "Estate_activities"
    /// <summary>
    ///   <para>rdfs:comment : Eventi programmati dal comune di firenze e dintormi^^xsd:string</para>
    ///   <para>rdfs:label : Eventordfs:label : Event</para>
    ///   <a href="http://www.disit.org/km4city/schema#Event">km4c:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Estrazione Gas Naturalerdfs:label : Extraction of natural gas</para>
    ///   <a href="http://www.disit.org/km4city/schema#Extraction_of_natural_gas">km4c:Extraction_of_natural_gas</a>
    /// </summary>
    let Extraction_of_natural_gas = _prefixId.prefix "Extraction_of_natural_gas"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Estrazione di salerdfs:label : Extraction of salt</para>
    ///   <a href="http://www.disit.org/km4city/schema#Extraction_of_salt">km4c:Extraction_of_salt</a>
    /// </summary>
    let Extraction_of_salt = _prefixId.prefix "Extraction_of_salt"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Consultorirdfs:label : Family counselling</para>
    ///   <a href="http://www.disit.org/km4city/schema#Family_counselling">km4c:Family_counselling</a>
    /// </summary>
    let Family_counselling = _prefixId.prefix "Family_counselling"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Residenza turistica alberghierardfs:label : Farm house</para>
    ///   <a href="http://www.disit.org/km4city/schema#Farm_house">km4c:Farm_house</a>
    /// </summary>
    let Farm_house = _prefixId.prefix "Farm_house"
    /// <summary>
    ///   <para>rdfs:comment : banche, istituti monetari e altri servizi finanziari^^xsd:string</para>
    ///   <para>rdfs:label : Servizio Finanziariordfs:label : Financial Service</para>
    ///   <a href="http://www.disit.org/km4city/schema#FinancialService">km4c:FinancialService</a>
    /// </summary>
    let FinancialService = _prefixId.prefix "FinancialService"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Istituto monetariordfs:label : Financial institute</para>
    ///   <a href="http://www.disit.org/km4city/schema#Financial_institute">km4c:Financial_institute</a>
    /// </summary>
    let Financial_institute = _prefixId.prefix "Financial_institute"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli Belle Artirdfs:label : Fine Arts Articles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fine_arts_articles">km4c:Fine_arts_articles</a>
    /// </summary>
    let Fine_arts_articles = _prefixId.prefix "Fine_arts_articles"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vigili del fuocordfs:label : Fire brigade</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fire_brigade">km4c:Fire_brigade</a>
    /// </summary>
    let Fire_brigade = _prefixId.prefix "Fire_brigade"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pronto soccorsordfs:label : First aid</para>
    ///   <a href="http://www.disit.org/km4city/schema#First_aid">km4c:First_aid</a>
    /// </summary>
    let First_aid = _prefixId.prefix "First_aid"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pescherierdfs:label : Fish and Seafood</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fish_and_seafood">km4c:Fish_and_seafood</a>
    /// </summary>
    let Fish_and_seafood = _prefixId.prefix "Fish_and_seafood"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pesca e Acquicolturardfs:label : Fishing and Aquaculture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fishing_and_aquaculture">km4c:Fishing_and_aquaculture</a>
    /// </summary>
    let Fishing_and_aquaculture = _prefixId.prefix "Fishing_and_aquaculture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riserve di pescardfs:label : Fishing reserve</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fishing_reserve">km4c:Fishing_reserve</a>
    /// </summary>
    let Fishing_reserve = _prefixId.prefix "Fishing_reserve"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Compagnie di Volordfs:label : Flight Companies</para>
    ///   <a href="http://www.disit.org/km4city/schema#Flight_companies">km4c:Flight_companies</a>
    /// </summary>
    let Flight_companies = _prefixId.prefix "Flight_companies"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Fioraiordfs:label : Flower shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Flower_shop">km4c:Flower_shop</a>
    /// </summary>
    let Flower_shop = _prefixId.prefix "Flower_shop"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ristorazione e Gelaterie Ambulantirdfs:label : Food and Ice Cream Truck</para>
    ///   <a href="http://www.disit.org/km4city/schema#Food_and_ice_cream_truck">km4c:Food_and_ice_cream_truck</a>
    /// </summary>
    let Food_and_ice_cream_truck = _prefixId.prefix "Food_and_ice_cream_truck"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Alimentari e Tabaccherierdfs:label : Food and Tobacconist</para>
    ///   <a href="http://www.disit.org/km4city/schema#Food_and_tobacconist">km4c:Food_and_tobacconist</a>
    /// </summary>
    let Food_and_tobacconist = _prefixId.prefix "Food_and_tobacconist"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Alimentarerdfs:label : Food Manufacture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Food_manufacture">km4c:Food_manufacture</a>
    /// </summary>
    let Food_manufacture = _prefixId.prefix "Food_manufacture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rivendite di alimentirdfs:label : Food trade</para>
    ///   <a href="http://www.disit.org/km4city/schema#Food_trade">km4c:Food_trade</a>
    /// </summary>
    let Food_trade = _prefixId.prefix "Food_trade"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Calzaturerdfs:label : Footwear and Accessories</para>
    ///   <a href="http://www.disit.org/km4city/schema#Footwear_and_accessories">km4c:Footwear_and_accessories</a>
    /// </summary>
    let Footwear_and_accessories = _prefixId.prefix "Footwear_and_accessories"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Calzature e Articoli in Pellerdfs:label : Footwear and Leather Goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Footwear_and_leather_goods">km4c:Footwear_and_leather_goods</a>
    /// </summary>
    let Footwear_and_leather_goods = _prefixId.prefix "Footwear_and_leather_goods"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Spacci outlet calzaturerdfs:label : Footwear factory outlet</para>
    ///   <a href="http://www.disit.org/km4city/schema#Footwear_factory_outlet">km4c:Footwear_factory_outlet</a>
    /// </summary>
    let Footwear_factory_outlet = _prefixId.prefix "Footwear_factory_outlet"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Calzaturerdfs:label : Footwear Manufacture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Footwear_manufacture">km4c:Footwear_manufacture</a>
    /// </summary>
    let Footwear_manufacture = _prefixId.prefix "Footwear_manufacture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Silvicolturardfs:label : Forestry</para>
    ///   <a href="http://www.disit.org/km4city/schema#Forestry">km4c:Forestry</a>
    /// </summary>
    let Forestry = _prefixId.prefix "Forestry"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Trasporto Merci e Traslochirdfs:label : Freight Transport and Furniture Removal</para>
    ///   <a href="http://www.disit.org/km4city/schema#Freight_transport_and_furniture_removal">km4c:Freight_transport_and_furniture_removal</a>
    /// </summary>
    let Freight_transport_and_furniture_removal = _prefixId.prefix "Freight_transport_and_furniture_removal"

    /// <summary>
    ///   <para>rdfs:comment : Luoghi in cui e' possibile sedere all'aria condizionata durante l'estate^^xsd:string</para>
    ///   <para>rdfs:label : Luoghi freschirdfs:label : Fresh place</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fresh_place">km4c:Fresh_place</a>
    /// </summary>
    let Fresh_place = _prefixId.prefix "Fresh_place"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Surgelatirdfs:label : Frozen Food</para>
    ///   <a href="http://www.disit.org/km4city/schema#Frozen_food">km4c:Frozen_food</a>
    /// </summary>
    let Frozen_food = _prefixId.prefix "Frozen_food"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Frutta e Verdurardfs:label : Fruit and Vegetables</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fruit_and_vegetables">km4c:Fruit_and_vegetables</a>
    /// </summary>
    let Fruit_and_vegetables = _prefixId.prefix "Fruit_and_vegetables"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Distributore di carburanterdfs:label : Fuel station</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fuel_station">km4c:Fuel_station</a>
    /// </summary>
    let Fuel_station = _prefixId.prefix "Fuel_station"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pompe funebrirdfs:label : Funeral</para>
    ///   <a href="http://www.disit.org/km4city/schema#Funeral">km4c:Funeral</a>
    /// </summary>
    let Funeral = _prefixId.prefix "Funeral"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli Funerari e Cimiterialirdfs:label : Funeral and Cemetery Articles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Funeral_and_cemetery_articles">km4c:Funeral_and_cemetery_articles</a>
    /// </summary>
    let Funeral_and_cemetery_articles = _prefixId.prefix "Funeral_and_cemetery_articles"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pellicce Abbigliamento Pellerdfs:label : Fur and Leather Clothing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Fur_and_leather_clothing">km4c:Fur_and_leather_clothing</a>
    /// </summary>
    let Fur_and_leather_clothing = _prefixId.prefix "Fur_and_leather_clothing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Lotterie e scommesserdfs:label : Gambling and betting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Gambling_and_betting">km4c:Gambling_and_betting</a>
    /// </summary>
    let Gambling_and_betting = _prefixId.prefix "Gambling_and_betting"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Parco naturalerdfs:label : Game reserve</para>
    ///   <a href="http://www.disit.org/km4city/schema#Game_reserve">km4c:Game_reserve</a>
    /// </summary>
    let Game_reserve = _prefixId.prefix "Game_reserve"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ludoteca e biliardirdfs:label : Game room</para>
    ///   <a href="http://www.disit.org/km4city/schema#Game_room">km4c:Game_room</a>
    /// </summary>
    let Game_room = _prefixId.prefix "Game_room"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Giochi e Giocattolirdfs:label : Games and toys</para>
    ///   <a href="http://www.disit.org/km4city/schema#Games_and_toys">km4c:Games_and_toys</a>
    /// </summary>
    let Games_and_toys = _prefixId.prefix "Games_and_toys"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Giardinaggio e Agriculturardfs:label : Garden and Agriculture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Garden_and_agriculture">km4c:Garden_and_agriculture</a>
    /// </summary>
    let Garden_and_agriculture = _prefixId.prefix "Garden_and_agriculture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Giardinirdfs:label : Gardens</para>
    ///   <a href="http://www.disit.org/km4city/schema#Gardens">km4c:Gardens</a>
    /// </summary>
    let Gardens = _prefixId.prefix "Gardens"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Geologirdfs:label : Geologists</para>
    ///   <a href="http://www.disit.org/km4city/schema#Geologists">km4c:Geologists</a>
    /// </summary>
    let Geologists = _prefixId.prefix "Geologists"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli da Regalo e per Fumatorirdfs:label : Gifts and Smoking Articles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Gifts_and_smoking_articles">km4c:Gifts_and_smoking_articles</a>
    /// </summary>
    let Gifts_and_smoking_articles = _prefixId.prefix "Gifts_and_smoking_articles"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Golfrdfs:label : Golf</para>
    ///   <a href="http://www.disit.org/km4city/schema#Golf">km4c:Golf</a>
    /// </summary>
    let Golf = _prefixId.prefix "Golf"
    /// <summary>
    ///   <para>rdfs:comment : Scalo Merci, sono posizionati in corrispondenza di giunzioni ferroviarie con relazione 1:1^^xsd:string</para>
    ///   <para>rdfs:label : Scalo Mercirdfs:label : Goods Yard</para>
    ///   <a href="http://www.disit.org/km4city/schema#GoodsYard">km4c:GoodsYard</a>
    /// </summary>
    let GoodsYard = _prefixId.prefix "GoodsYard"
    /// <summary>
    ///   <para>rdfs:comment : Uffici aperti al pubblico^^xsd:string</para>
    ///   <para>rdfs:label : Uffici Pubblicirdfs:label : Government Office</para>
    ///   <a href="http://www.disit.org/km4city/schema#GovernmentOffice">km4c:GovernmentOffice</a>
    /// </summary>
    let GovernmentOffice = _prefixId.prefix "GovernmentOffice"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Aree verdirdfs:label : Green areas</para>
    ///   <a href="http://www.disit.org/km4city/schema#Green_areas">km4c:Green_areas</a>
    /// </summary>
    let Green_areas = _prefixId.prefix "Green_areas"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rosticceriardfs:label : Grill</para>
    ///   <a href="http://www.disit.org/km4city/schema#Grill">km4c:Grill</a>
    /// </summary>
    let Grill = _prefixId.prefix "Grill"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Poliambulatoriordfs:label : Group practice</para>
    ///   <a href="http://www.disit.org/km4city/schema#Group_practice">km4c:Group_practice</a>
    /// </summary>
    let Group_practice = _prefixId.prefix "Group_practice"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Palestra fitnessrdfs:label : Gym fitness</para>
    ///   <a href="http://www.disit.org/km4city/schema#Gym_fitness">km4c:Gym_fitness</a>
    /// </summary>
    let Gym_fitness = _prefixId.prefix "Gym_fitness"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Merceria, filatirdfs:label : Haberdashery</para>
    ///   <a href="http://www.disit.org/km4city/schema#Haberdashery">km4c:Haberdashery</a>
    /// </summary>
    let Haberdashery = _prefixId.prefix "Haberdashery"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri tricologicirdfs:label : Haircare centres</para>
    ///   <a href="http://www.disit.org/km4city/schema#Haircare_centres">km4c:Haircare_centres</a>
    /// </summary>
    let Haircare_centres = _prefixId.prefix "Haircare_centres"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Barbieri e parrucchiererdfs:label : Hairdressing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hairdressing">km4c:Hairdressing</a>
    /// </summary>
    let Hairdressing = _prefixId.prefix "Hairdressing"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Parrucchieri e trattamenti di bellezzardfs:label : Hairdressing and beauty treatment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hairdressing_and_beauty_treatment">km4c:Hairdressing_and_beauty_treatment</a>
    /// </summary>
    let Hairdressing_and_beauty_treatment = _prefixId.prefix "Hairdressing_and_beauty_treatment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ferramenta Elettricita' Termoidraulicardfs:label : Hardware Electrical Plumbing and Heating</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hardware_electrical_plumbing_and_heating">km4c:Hardware_electrical_plumbing_and_heating</a>
    /// </summary>
    let Hardware_electrical_plumbing_and_heating = _prefixId.prefix "Hardware_electrical_plumbing_and_heating"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ferramenta Vernici Vetrordfs:label : Hardware Paints and Glass</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hardware_paints_and_glass">km4c:Hardware_paints_and_glass</a>
    /// </summary>
    let Hardware_paints_and_glass = _prefixId.prefix "Hardware_paints_and_glass"
    /// <summary>
    ///   <para>rdfs:comment : ospedali, studi medici, laboratori analisi e altre strutture che forniscono servizi sanitari^^xsd:string</para>
    ///   <para>rdfs:label : Assistenza Sanitariardfs:label : Health Care</para>
    ///   <a href="http://www.disit.org/km4city/schema#HealthCare">km4c:HealthCare</a>
    /// </summary>
    let HealthCare = _prefixId.prefix "HealthCare"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Distretto sanitariordfs:label : Health district</para>
    ///   <a href="http://www.disit.org/km4city/schema#Health_district">km4c:Health_district</a>
    /// </summary>
    let Health_district = _prefixId.prefix "Health_district"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centro unico di prenotazionerdfs:label : Health reservations centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Health_reservations_centre">km4c:Health_reservations_centre</a>
    /// </summary>
    let Health_reservations_centre = _prefixId.prefix "Health_reservations_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri assistenzardfs:label : Healthcare centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Healthcare_centre">km4c:Healthcare_centre</a>
    /// </summary>
    let Healthcare_centre = _prefixId.prefix "Healthcare_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Elisuperficirdfs:label : Helipads</para>
    ///   <a href="http://www.disit.org/km4city/schema#Helipads">km4c:Helipads</a>
    /// </summary>
    let Helipads = _prefixId.prefix "Helipads"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Erboristerierdfs:label : Herbalist's Shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Herbalists_shop">km4c:Herbalists_shop</a>
    /// </summary>
    let Herbalists_shop = _prefixId.prefix "Herbalists_shop"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Universita'rdfs:label : Higher education</para>
    ///   <a href="http://www.disit.org/km4city/schema#Higher_education">km4c:Higher_education</a>
    /// </summary>
    let Higher_education = _prefixId.prefix "Higher_education"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Autogrillrdfs:label : Highway stop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Highway_stop">km4c:Highway_stop</a>
    /// </summary>
    let Highway_stop = _prefixId.prefix "Highway_stop"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ippodromordfs:label : Hippodrome</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hippodrome">km4c:Hippodrome</a>
    /// </summary>
    let Hippodrome = _prefixId.prefix "Hippodrome"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Residenze epocardfs:label : Historic residence</para>
    ///   <a href="http://www.disit.org/km4city/schema#Historic_residence">km4c:Historic_residence</a>
    /// </summary>
    let Historic_residence = _prefixId.prefix "Historic_residence"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Palazzirdfs:label : Historical buildings</para>
    ///   <a href="http://www.disit.org/km4city/schema#Historical_buildings">km4c:Historical_buildings</a>
    /// </summary>
    let Historical_buildings = _prefixId.prefix "Historical_buildings"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Villaggio vacanzerdfs:label : Holiday village</para>
    ///   <a href="http://www.disit.org/km4city/schema#Holiday_village">km4c:Holiday_village</a>
    /// </summary>
    let Holiday_village = _prefixId.prefix "Holiday_village"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ostellordfs:label : Hostel</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hostel">km4c:Hostel</a>
    /// </summary>
    let Hostel = _prefixId.prefix "Hostel"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Albergo hotelrdfs:label : Hotel</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hotel">km4c:Hotel</a>
    /// </summary>
    let Hotel = _prefixId.prefix "Hotel"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita e riparazione elettrodomesticirdfs:label : Household appliances shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Household_appliances_shop">km4c:Household_appliances_shop</a>
    /// </summary>
    let Household_appliances_shop = _prefixId.prefix "Household_appliances_shop"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli per la Casardfs:label : Household Articles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Household_articles">km4c:Household_articles</a>
    /// </summary>
    let Household_articles = _prefixId.prefix "Household_articles"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Combustibile Uso Domesticordfs:label : Household Fuel</para>
    ///   <a href="http://www.disit.org/km4city/schema#Household_fuel">km4c:Household_fuel</a>
    /// </summary>
    let Household_fuel = _prefixId.prefix "Household_fuel"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Mobili per la Casardfs:label : Household Furniture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Household_furniture">km4c:Household_furniture</a>
    /// </summary>
    let Household_furniture = _prefixId.prefix "Household_furniture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Prodotti Uso Domesticordfs:label : Household Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Household_products">km4c:Household_products</a>
    /// </summary>
    let Household_products = _prefixId.prefix "Household_products"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Prodotti per la Casardfs:label : Household Utensils</para>
    ///   <a href="http://www.disit.org/km4city/schema#Household_utensils">km4c:Household_utensils</a>
    /// </summary>
    let Household_utensils = _prefixId.prefix "Household_utensils"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Assistenza Sanitariardfs:label : Human health activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Human_health_activities">km4c:Human_health_activities</a>
    /// </summary>
    let Human_health_activities = _prefixId.prefix "Human_health_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Caccia Cattura e Servizirdfs:label : Hunting Trapping and Services</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hunting_trapping_and_services">km4c:Hunting_trapping_and_services</a>
    /// </summary>
    let Hunting_trapping_and_services = _prefixId.prefix "Hunting_trapping_and_services"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ipermercatirdfs:label : Hypermarket</para>
    ///   <a href="http://www.disit.org/km4city/schema#Hypermarket">km4c:Hypermarket</a>
    /// </summary>
    let Hypermarket = _prefixId.prefix "Hypermarket"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Servizi ICTrdfs:label : ICT service</para>
    ///   <a href="http://www.disit.org/km4city/schema#ICT_service">km4c:ICT_service</a>
    /// </summary>
    let ICT_service = _prefixId.prefix "ICT_service"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Gelateriardfs:label : Ice cream parlour</para>
    ///   <a href="http://www.disit.org/km4city/schema#Ice_cream_parlour">km4c:Ice_cream_parlour</a>
    /// </summary>
    let Ice_cream_parlour = _prefixId.prefix "Ice_cream_parlour"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenzia delle entraterdfs:label : Income revenue authority</para>
    ///   <a href="http://www.disit.org/km4city/schema#Income_revenue_authority">km4c:Income_revenue_authority</a>
    /// </summary>
    let Income_revenue_authority = _prefixId.prefix "Income_revenue_authority"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Lavanderie industrialirdfs:label : industrial laundries</para>
    ///   <a href="http://www.disit.org/km4city/schema#Industrial_laundries">km4c:Industrial_laundries</a>
    /// </summary>
    let Industrial_laundries = _prefixId.prefix "Industrial_laundries"
    /// <summary>
    ///   <para>rdfs:comment : Servizi legati all'industria e al lavoro^^xsd:string</para>
    ///   <para>rdfs:label : Industria e produzionerdfs:label : Industry and manufacturing</para>
    ///   <a href="http://www.disit.org/km4city/schema#IndustryAndManufacturing">km4c:IndustryAndManufacturing</a>
    /// </summary>
    let IndustryAndManufacturing = _prefixId.prefix "IndustryAndManufacturing"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Installazione Macchinari Industrialirdfs:label : Installation of Industrial Machinery</para>
    ///   <a href="http://www.disit.org/km4city/schema#Installation_of_industrial_machinery">km4c:Installation_of_industrial_machinery</a>
    /// </summary>
    let Installation_of_industrial_machinery = _prefixId.prefix "Installation_of_industrial_machinery"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Assicurazionerdfs:label : Insurance</para>
    ///   <a href="http://www.disit.org/km4city/schema#Insurance">km4c:Insurance</a>
    /// </summary>
    let Insurance = _prefixId.prefix "Insurance"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Assicurazione e finanziariordfs:label : Insurance and financial</para>
    ///   <a href="http://www.disit.org/km4city/schema#Insurance_and_financial">km4c:Insurance_and_financial</a>
    /// </summary>
    let Insurance_and_financial = _prefixId.prefix "Insurance_and_financial"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Internet Pointrdfs:label : Internet Point and Public Telephone</para>
    ///   <a href="http://www.disit.org/km4city/schema#Internet_point_and_public_telephone">km4c:Internet_point_and_public_telephone</a>
    /// </summary>
    let Internet_point_and_public_telephone = _prefixId.prefix "Internet_point_and_public_telephone"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Servizi di accesso ad internetrdfs:label : Internet Service Provider</para>
    ///   <a href="http://www.disit.org/km4city/schema#Internet_service_provider">km4c:Internet_service_provider</a>
    /// </summary>
    let Internet_service_provider = _prefixId.prefix "Internet_service_provider"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Servizi investigativi privatirdfs:label : Investigation activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Investigation_activities">km4c:Investigation_activities</a>
    /// </summary>
    let Investigation_activities = _prefixId.prefix "Investigation_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Guardia di finanzardfs:label : Italian finance police</para>
    ///   <a href="http://www.disit.org/km4city/schema#Italian_finance_police">km4c:Italian_finance_police</a>
    /// </summary>
    let Italian_finance_police = _prefixId.prefix "Italian_finance_police"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione orologi e gioiellirdfs:label : Jeweller</para>
    ///   <a href="http://www.disit.org/km4city/schema#Jeweller">km4c:Jeweller</a>
    /// </summary>
    let Jeweller = _prefixId.prefix "Jeweller"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Gioielleriardfs:label : Jewellery</para>
    ///   <a href="http://www.disit.org/km4city/schema#Jewellery">km4c:Jewellery</a>
    /// </summary>
    let Jewellery = _prefixId.prefix "Jewellery"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Giornalisti indipendentirdfs:label : Journalist</para>
    ///   <a href="http://www.disit.org/km4city/schema#Journalist">km4c:Journalist</a>
    /// </summary>
    let Journalist = _prefixId.prefix "Journalist"
    /// <summary>
    ///   <para>rdfs:comment : Punto di interconnessione tra segmenti di strada per disegnare un RoadElement^^xsd:string</para>
    ///   <para>rdfs:label : giunzione stradalerdfs:label : Junction</para>
    ///   <a href="http://www.disit.org/km4city/schema#Junction">km4c:Junction</a>
    /// </summary>
    let Junction = _prefixId.prefix "Junction"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione a Magliardfs:label : Knitted Manufacture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Knitted_manufacture">km4c:Knitted_manufacture</a>
    /// </summary>
    let Knitted_manufacture = _prefixId.prefix "Knitted_manufacture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Consulenti del lavorordfs:label : Labour consultant</para>
    ///   <a href="http://www.disit.org/km4city/schema#Labour_consultant">km4c:Labour_consultant</a>
    /// </summary>
    let Labour_consultant = _prefixId.prefix "Labour_consultant"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Trasporti Terrestrirdfs:label : Land Transport</para>
    ///   <a href="http://www.disit.org/km4city/schema#Land_transport">km4c:Land_transport</a>
    /// </summary>
    let Land_transport = _prefixId.prefix "Land_transport"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio altri mezzi trasporto terrestrirdfs:label : Land-transport rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Land_transport_rental">km4c:Land_transport_rental</a>
    /// </summary>
    let Land_transport_rental = _prefixId.prefix "Land_transport_rental"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Cura del paesaggiordfs:label : Landscape care</para>
    ///   <a href="http://www.disit.org/km4city/schema#Landscape_care">km4c:Landscape_care</a>
    /// </summary>
    let Landscape_care = _prefixId.prefix "Landscape_care"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Corsi di linguerdfs:label : Language courses</para>
    ///   <a href="http://www.disit.org/km4city/schema#Language_courses">km4c:Language_courses</a>
    /// </summary>
    let Language_courses = _prefixId.prefix "Language_courses"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Lavenderie e tintorierdfs:label : laundries and dry cleaners</para>
    ///   <a href="http://www.disit.org/km4city/schema#Laundries_and_dry_cleaners">km4c:Laundries_and_dry_cleaners</a>
    /// </summary>
    let Laundries_and_dry_cleaners = _prefixId.prefix "Laundries_and_dry_cleaners"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Concessione dei diritti di sfruttamento di proprieta' intellettualerdfs:label : Leasing of intellectual property</para>
    ///   <a href="http://www.disit.org/km4city/schema#Leasing_of_intellectual_property">km4c:Leasing_of_intellectual_property</a>
    /// </summary>
    let Leasing_of_intellectual_property = _prefixId.prefix "Leasing_of_intellectual_property"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione in Pellerdfs:label : Leather Manufacture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Leather_manufacture">km4c:Leather_manufacture</a>
    /// </summary>
    let Leather_manufacture = _prefixId.prefix "Leather_manufacture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Studi Legalirdfs:label : Legal office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Legal_office">km4c:Legal_office</a>
    /// </summary>
    let Legal_office = _prefixId.prefix "Legal_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Bibliotecardfs:label : Library</para>
    ///   <a href="http://www.disit.org/km4city/schema#Library">km4c:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio attrezzature sollevamento e movimentazionerdfs:label : Lifting and handling equipment rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Lifting_and_handling_equipment_rental">km4c:Lifting_and_handling_equipment_rental</a>
    /// </summary>
    let Lifting_and_handling_equipment_rental = _prefixId.prefix "Lifting_and_handling_equipment_rental"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Illuminazionerdfs:label : Lighting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Lighting">km4c:Lighting</a>
    /// </summary>
    let Lighting = _prefixId.prefix "Lighting"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : caffe letterariordfs:label : literary cafe</para>
    ///   <a href="http://www.disit.org/km4city/schema#Literary_cafe">km4c:Literary_cafe</a>
    /// </summary>
    let Literary_cafe = _prefixId.prefix "Literary_cafe"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Aslrdfs:label : Local health authority</para>
    ///   <a href="http://www.disit.org/km4city/schema#Local_health_authority">km4c:Local_health_authority</a>
    /// </summary>
    let Local_health_authority = _prefixId.prefix "Local_health_authority"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Polizia municipalerdfs:label : Local police</para>
    ///   <a href="http://www.disit.org/km4city/schema#Local_police">km4c:Local_police</a>
    /// </summary>
    let Local_police = _prefixId.prefix "Local_police"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Attivita' di Logisticardfs:label : Logistics Activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Logistics_activities">km4c:Logistics_activities</a>
    /// </summary>
    let Logistics_activities = _prefixId.prefix "Logistics_activities"
    /// <summary>
    ///   <para>rdfs:comment : Insieme di linee TPL, individuabili a livello regionale come lotto^^xsd:string</para>
    ///   <para>rdfs:label : Lotto TPLrdfs:label : TPL Lot</para>
    ///   <a href="http://www.disit.org/km4city/schema#Lot">km4c:Lot</a>
    /// </summary>
    let Lot = _prefixId.prefix "Lot"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio macchinari e attrezzature rdfs:label : Machinery and Eequipment Rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Machinery_and_equipment_rental">km4c:Machinery_and_equipment_rental</a>
    /// </summary>
    let Machinery_and_equipment_rental = _prefixId.prefix "Machinery_and_equipment_rental"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione Manutenzione Macchinari Utensilirdfs:label : Machinery Repair and Installation</para>
    ///   <a href="http://www.disit.org/km4city/schema#Machinery_repair_and_installation">km4c:Machinery_repair_and_installation</a>
    /// </summary>
    let Machinery_repair_and_installation = _prefixId.prefix "Machinery_repair_and_installation"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Manutenzione Riparazione Autoveicolirdfs:label : Maintenance Repair of Motor Vehicles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Maintenance_repair_of_motor_vehicles">km4c:Maintenance_repair_of_motor_vehicles</a>
    /// </summary>
    let Maintenance_repair_of_motor_vehicles = _prefixId.prefix "Maintenance_repair_of_motor_vehicles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Manutenzione Riparazione Motociclirdfs:label : Maintenance Repair of Motorcycles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Maintenance_repair_of_motorcycles">km4c:Maintenance_repair_of_motorcycles</a>
    /// </summary>
    let Maintenance_repair_of_motorcycles = _prefixId.prefix "Maintenance_repair_of_motorcycles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Consulenza Imprenditoriale e Gestionalerdfs:label : Management consultancy</para>
    ///   <a href="http://www.disit.org/km4city/schema#Management_consultancy">km4c:Management_consultancy</a>
    /// </summary>
    let Management_consultancy = _prefixId.prefix "Management_consultancy"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le possibili manovre che possono essere effettuate su un elemento stradale^^xsd:string</para>
    ///   <para>rdfs:label : Manovrardfs:label : Maneuver</para>
    ///   <a href="http://www.disit.org/km4city/schema#Maneuver">km4c:Maneuver</a>
    /// </summary>
    let Maneuver = _prefixId.prefix "Maneuver"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Manicure e pedicurerdfs:label : Manicure and pedicure</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manicure_and_pedicure">km4c:Manicure_and_pedicure</a>
    /// </summary>
    let Manicure_and_pedicure = _prefixId.prefix "Manicure_and_pedicure"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Attivita' Metallurgicherdfs:label : Manufacture of Basic Metals</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_basic_metals">km4c:Manufacture_of_basic_metals</a>
    /// </summary>
    let Manufacture_of_basic_metals = _prefixId.prefix "Manufacture_of_basic_metals"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti Chimicirdfs:label : Manufacture of Chemicals Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_chemicals_products">km4c:Manufacture_of_chemicals_products</a>
    /// </summary>
    let Manufacture_of_chemicals_products = _prefixId.prefix "Manufacture_of_chemicals_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Ceramica e Terracottardfs:label : Manufacture of Clay and Ceramic</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_clay_and_ceramic">km4c:Manufacture_of_clay_and_ceramic</a>
    /// </summary>
    let Manufacture_of_clay_and_ceramic = _prefixId.prefix "Manufacture_of_clay_and_ceramic"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Apparecchiature Elettricherdfs:label : Manufacture of Electrical Equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_electrical_equipment">km4c:Manufacture_of_electrical_equipment</a>
    /// </summary>
    let Manufacture_of_electrical_equipment = _prefixId.prefix "Manufacture_of_electrical_equipment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti Elettronicirdfs:label : Manufacture of Electronic Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_electronic_products">km4c:Manufacture_of_electronic_products</a>
    /// </summary>
    let Manufacture_of_electronic_products = _prefixId.prefix "Manufacture_of_electronic_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Mobilirdfs:label : Manufacture of Furniture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_furniture">km4c:Manufacture_of_furniture</a>
    /// </summary>
    let Manufacture_of_furniture = _prefixId.prefix "Manufacture_of_furniture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione e Lavorazione Vetrordfs:label : Manufacture of Glass</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_glass">km4c:Manufacture_of_glass</a>
    /// </summary>
    let Manufacture_of_glass = _prefixId.prefix "Manufacture_of_glass"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Gioielleria Bigiotteriardfs:label : Manufacture of Jewellery Bijouterie</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_jewellery_bijouterie">km4c:Manufacture_of_jewellery_bijouterie</a>
    /// </summary>
    let Manufacture_of_jewellery_bijouterie = _prefixId.prefix "Manufacture_of_jewellery_bijouterie"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Macchinari e Utensilirdfs:label : Manufacture of Machinery and Equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_machinery_and_equipment">km4c:Manufacture_of_machinery_and_equipment</a>
    /// </summary>
    let Manufacture_of_machinery_and_equipment = _prefixId.prefix "Manufacture_of_machinery_and_equipment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Autoveicolirdfs:label : Manufacture of Motor Vehicles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_motor_vehicles">km4c:Manufacture_of_motor_vehicles</a>
    /// </summary>
    let Manufacture_of_motor_vehicles = _prefixId.prefix "Manufacture_of_motor_vehicles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Strumenti Musicalirdfs:label : Manufacture of Musical Instruments</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_musical_instruments">km4c:Manufacture_of_musical_instruments</a>
    /// </summary>
    let Manufacture_of_musical_instruments = _prefixId.prefix "Manufacture_of_musical_instruments"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti Minerali non Metalliferirdfs:label : Manufacture of Non-Metallic Mineral Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_non_metallic_mineral_products">km4c:Manufacture_of_non_metallic_mineral_products</a>
    /// </summary>
    let Manufacture_of_non_metallic_mineral_products = _prefixId.prefix "Manufacture_of_non_metallic_mineral_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Industria della Cartardfs:label : Manufacture of Paper</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_paper">km4c:Manufacture_of_paper</a>
    /// </summary>
    let Manufacture_of_paper = _prefixId.prefix "Manufacture_of_paper"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti di Cartardfs:label : Manufacture of Paper Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_paper_products">km4c:Manufacture_of_paper_products</a>
    /// </summary>
    let Manufacture_of_paper_products = _prefixId.prefix "Manufacture_of_paper_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti Farmaceuticirdfs:label : Manufacture of Pharmaceutical Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_pharmaceutical_products">km4c:Manufacture_of_pharmaceutical_products</a>
    /// </summary>
    let Manufacture_of_pharmaceutical_products = _prefixId.prefix "Manufacture_of_pharmaceutical_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti di Plasticardfs:label : Manufacture of Plastics Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_plastics_products">km4c:Manufacture_of_plastics_products</a>
    /// </summary>
    let Manufacture_of_plastics_products = _prefixId.prefix "Manufacture_of_plastics_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti Petroliferi Raffinatirdfs:label : Manufacture of Refined Petroleum Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_refined_petroleum_products">km4c:Manufacture_of_refined_petroleum_products</a>
    /// </summary>
    let Manufacture_of_refined_petroleum_products = _prefixId.prefix "Manufacture_of_refined_petroleum_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti Refrattarirdfs:label : Manufacture of Refractory Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_refractory_products">km4c:Manufacture_of_refractory_products</a>
    /// </summary>
    let Manufacture_of_refractory_products = _prefixId.prefix "Manufacture_of_refractory_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti di Gomma e Plasticardfs:label : Manufacture of Rubber and Plastics Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_rubber_and_plastics_products">km4c:Manufacture_of_rubber_and_plastics_products</a>
    /// </summary>
    let Manufacture_of_rubber_and_plastics_products = _prefixId.prefix "Manufacture_of_rubber_and_plastics_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti di Gommardfs:label : Manufacture of Rubber Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_rubber_products">km4c:Manufacture_of_rubber_products</a>
    /// </summary>
    let Manufacture_of_rubber_products = _prefixId.prefix "Manufacture_of_rubber_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Articoli Sportivirdfs:label : Manufacture of Sports Goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_sports_goods">km4c:Manufacture_of_sports_goods</a>
    /// </summary>
    let Manufacture_of_sports_goods = _prefixId.prefix "Manufacture_of_sports_goods"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti in Metallordfs:label : Manufacture of Structural Metal Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_structural_metal_products">km4c:Manufacture_of_structural_metal_products</a>
    /// </summary>
    let Manufacture_of_structural_metal_products = _prefixId.prefix "Manufacture_of_structural_metal_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Industrie Tessilerdfs:label : Manufacture of textiles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_textiles">km4c:Manufacture_of_textiles</a>
    /// </summary>
    let Manufacture_of_textiles = _prefixId.prefix "Manufacture_of_textiles"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Gioattoli Giochirdfs:label : Manufacture of Toys and Game</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_toys_and_game">km4c:Manufacture_of_toys_and_game</a>
    /// </summary>
    let Manufacture_of_toys_and_game = _prefixId.prefix "Manufacture_of_toys_and_game"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Mezzi di Trasportordfs:label : Manufacture of Transport Equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_transport_equipment">km4c:Manufacture_of_transport_equipment</a>
    /// </summary>
    let Manufacture_of_transport_equipment = _prefixId.prefix "Manufacture_of_transport_equipment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Articoli da Viaggiordfs:label : Manufacture of Travel Articles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_travel_articles">km4c:Manufacture_of_travel_articles</a>
    /// </summary>
    let Manufacture_of_travel_articles = _prefixId.prefix "Manufacture_of_travel_articles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Confezione Abbigliamentordfs:label : Manufacture of Wearing Apparel</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_wearing_apparel">km4c:Manufacture_of_wearing_apparel</a>
    /// </summary>
    let Manufacture_of_wearing_apparel = _prefixId.prefix "Manufacture_of_wearing_apparel"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Industria del Legnordfs:label : Manufacture of Wood</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_wood">km4c:Manufacture_of_wood</a>
    /// </summary>
    let Manufacture_of_wood = _prefixId.prefix "Manufacture_of_wood"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Prodotti in Legnordfs:label : Manufacture of Wood Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Manufacture_of_wood_products">km4c:Manufacture_of_wood_products</a>
    /// </summary>
    let Manufacture_of_wood_products = _prefixId.prefix "Manufacture_of_wood_products"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ricerche di mercatordfs:label : Market polling</para>
    ///   <a href="http://www.disit.org/km4city/schema#Market_polling">km4c:Market_polling</a>
    /// </summary>
    let Market_polling = _prefixId.prefix "Market_polling"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Recupero Materialirdfs:label : Materials Recovery</para>
    ///   <a href="http://www.disit.org/km4city/schema#Materials_recovery">km4c:Materials_recovery</a>
    /// </summary>
    let Materials_recovery = _prefixId.prefix "Materials_recovery"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Carne e Pollamerdfs:label : Meat and Poultry</para>
    ///   <a href="http://www.disit.org/km4city/schema#Meat_and_poultry">km4c:Meat_and_poultry</a>
    /// </summary>
    let Meat_and_poultry = _prefixId.prefix "Meat_and_poultry"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Officinardfs:label : Mechanic Workshop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Mechanic_workshop">km4c:Mechanic_workshop</a>
    /// </summary>
    let Mechanic_workshop = _prefixId.prefix "Mechanic_workshop"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Laboratori analisi medicherdfs:label : Medical analysis laboratories</para>
    ///   <a href="http://www.disit.org/km4city/schema#Medical_analysis_laboratories">km4c:Medical_analysis_laboratories</a>
    /// </summary>
    let Medical_analysis_laboratories = _prefixId.prefix "Medical_analysis_laboratories"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli Medicali e Ortopedicirdfs:label : Medical and Orthopaedic Goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Medical_and_orthopaedic_goods">km4c:Medical_and_orthopaedic_goods</a>
    /// </summary>
    let Medical_and_orthopaedic_goods = _prefixId.prefix "Medical_and_orthopaedic_goods"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri di salute mentalerdfs:label : Mental health centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Mental_health_centre">km4c:Mental_health_centre</a>
    /// </summary>
    let Mental_health_centre = _prefixId.prefix "Mental_health_centre"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono i cippi chilometrici che si trovano lungo le principali strade^^xsd:string</para>
    ///   <para>rdfs:label : Cippo chilometricordfs:label : milestone mileage</para>
    ///   <a href="http://www.disit.org/km4city/schema#Milestone">km4c:Milestone</a>
    /// </summary>
    let Milestone = _prefixId.prefix "Milestone"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Minimarketrdfs:label : Minimarket</para>
    ///   <a href="http://www.disit.org/km4city/schema#Minimarket">km4c:Minimarket</a>
    /// </summary>
    let Minimarket = _prefixId.prefix "Minimarket"
    /// <summary>
    ///   <para>rdfs:comment : Servizi legati alle attivita' di estrazione e cave^^xsd:string</para>
    ///   <para>rdfs:label : Attivita' estrattiverdfs:label : Mining and quarrying</para>
    ///   <a href="http://www.disit.org/km4city/schema#MiningAndQuarrying">km4c:MiningAndQuarrying</a>
    /// </summary>
    let MiningAndQuarrying = _prefixId.prefix "MiningAndQuarrying"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Estrazione minerali metalliferirdfs:label : Mining of metal ores</para>
    ///   <a href="http://www.disit.org/km4city/schema#Mining_of_metal_ores">km4c:Mining_of_metal_ores</a>
    /// </summary>
    let Mining_of_metal_ores = _prefixId.prefix "Mining_of_metal_ores"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Servizi Industria Minerariardfs:label : Mining Support Services</para>
    ///   <a href="http://www.disit.org/km4city/schema#Mining_support_services">km4c:Mining_support_services</a>
    /// </summary>
    let Mining_support_services = _prefixId.prefix "Mining_support_services"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Luogo monumentordfs:label : Monument location</para>
    ///   <a href="http://www.disit.org/km4city/schema#Monument_location">km4c:Monument_location</a>
    /// </summary>
    let Monument_location = _prefixId.prefix "Monument_location"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Cinama e TV  Produzione e Distribuzionerdfs:label : Motion picture and television programme activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Motion_picture_and_television_programme_activities">km4c:Motion_picture_and_television_programme_activities</a>
    /// </summary>
    let Motion_picture_and_television_programme_activities = _prefixId.prefix "Motion_picture_and_television_programme_activities"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Autoveicoli Ingrosso Dettagliordfs:label : Motor Vehicles Wholesale and Retail</para>
    ///   <a href="http://www.disit.org/km4city/schema#Motor_Vehicles_wholesale_and_retail">km4c:Motor_Vehicles_wholesale_and_retail</a>
    /// </summary>
    let Motor_Vehicles_wholesale_and_retail = _prefixId.prefix "Motor_Vehicles_wholesale_and_retail"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Ingrosso Dettaglio Ricambi Motociclirdfs:label : Motorcycles Parts Wholesale and Retail</para>
    ///   <a href="http://www.disit.org/km4city/schema#Motorcycles_parts_wholesale_and_retail">km4c:Motorcycles_parts_wholesale_and_retail</a>
    /// </summary>
    let Motorcycles_parts_wholesale_and_retail = _prefixId.prefix "Motorcycles_parts_wholesale_and_retail"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Motocicli Ingrosso Dettagliordfs:label : Motorcycles Wholesale and Retail</para>
    ///   <a href="http://www.disit.org/km4city/schema#Motorcycles_wholesale_and_retail">km4c:Motorcycles_wholesale_and_retail</a>
    /// </summary>
    let Motorcycles_wholesale_and_retail = _prefixId.prefix "Motorcycles_wholesale_and_retail"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rifugi di Montagnardfs:label : Mountain shelter</para>
    ///   <a href="http://www.disit.org/km4city/schema#Mountain_shelter">km4c:Mountain_shelter</a>
    /// </summary>
    let Mountain_shelter = _prefixId.prefix "Mountain_shelter"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono i vari comuni^^xsd:string</para>
    ///   <para>rdfs:label : Amministrazione Comunalerdfs:label : Municipality Administration</para>
    ///   <a href="http://www.disit.org/km4city/schema#Municipality">km4c:Municipality</a>
    /// </summary>
    let Municipality = _prefixId.prefix "Municipality"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Museordfs:label : Museum</para>
    ///   <a href="http://www.disit.org/km4city/schema#Museum">km4c:Museum</a>
    /// </summary>
    let Museum = _prefixId.prefix "Museum"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Registrazioni musicali e videordfs:label : Music and Video Recordings</para>
    ///   <a href="http://www.disit.org/km4city/schema#Music_and_video_recordings">km4c:Music_and_video_recordings</a>
    /// </summary>
    let Music_and_video_recordings = _prefixId.prefix "Music_and_video_recordings"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Strumenti Musicalirdfs:label : Musical Instruments and Scores</para>
    ///   <a href="http://www.disit.org/km4city/schema#Musical_instruments_and_scores">km4c:Musical_instruments_and_scores</a>
    /// </summary>
    let Musical_instruments_and_scores = _prefixId.prefix "Musical_instruments_and_scores"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenzie di stampardfs:label : News agency</para>
    ///   <a href="http://www.disit.org/km4city/schema#News_agency">km4c:News_agency</a>
    /// </summary>
    let News_agency = _prefixId.prefix "News_agency"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Edicole e cartolerierdfs:label : Newspapers and Stationery</para>
    ///   <a href="http://www.disit.org/km4city/schema#Newspapers_and_stationery">km4c:Newspapers_and_stationery</a>
    /// </summary>
    let Newspapers_and_stationery = _prefixId.prefix "Newspapers_and_stationery"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono i nodi che congiungono gli elementi stradali^^xsd:string</para>
    ///   <para>rdfs:label : Nodordfs:label : Node</para>
    ///   <a href="http://www.disit.org/km4city/schema#Node">km4c:Node</a>
    /// </summary>
    let Node = _prefixId.prefix "Node"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Grande distribuzione non alimentarerdfs:label : non food large retailers</para>
    ///   <a href="http://www.disit.org/km4city/schema#Non_food_large_retailers">km4c:Non_food_large_retailers</a>
    /// </summary>
    let Non_food_large_retailers = _prefixId.prefix "Non_food_large_retailers"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Altri Prodotti non Alimentarirdfs:label : Non-Food Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Non_food_products">km4c:Non_food_products</a>
    /// </summary>
    let Non_food_products = _prefixId.prefix "Non_food_products"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ingrosso Non Specializzatordfs:label : Non-specialized Wholesale Trade</para>
    ///   <a href="http://www.disit.org/km4city/schema#Non_specialized_wholesale_trade">km4c:Non_specialized_wholesale_trade</a>
    /// </summary>
    let Non_specialized_wholesale_trade = _prefixId.prefix "Non_specialized_wholesale_trade"

    /// <summary>
    ///   <para>rdfs:comment : Singolo sensore per osservare velocita', traffico, concentrazione o densita'^^xsd:string</para>
    ///   <para>rdfs:label : Osservazionerdfs:label : Observation</para>
    ///   <a href="http://www.disit.org/km4city/schema#Observation">km4c:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Mobili per Ufficiordfs:label : Office Furniture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Office_Furniture">km4c:Office_Furniture</a>
    /// </summary>
    let Office_Furniture = _prefixId.prefix "Office_Furniture"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Supporto per le funzioni d'ufficiordfs:label : Office administrative and support activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Office_administrative_and_support_activities">km4c:Office_administrative_and_support_activities</a>
    /// </summary>
    let Office_administrative_and_support_activities = _prefixId.prefix "Office_administrative_and_support_activities"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Slot Machinesrdfs:label : Operation of casinos</para>
    ///   <a href="http://www.disit.org/km4city/schema#Operation_of_casinos">km4c:Operation_of_casinos</a>
    /// </summary>
    let Operation_of_casinos = _prefixId.prefix "Operation_of_casinos"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ottica e Fotografiardfs:label : Optics and Photography</para>
    ///   <a href="http://www.disit.org/km4city/schema#Optics_and_photography">km4c:Optics_and_photography</a>
    /// </summary>
    let Optics_and_photography = _prefixId.prefix "Optics_and_photography"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Organizzazione di convegni e fiererdfs:label : Organization of conventions and trade shows</para>
    ///   <a href="http://www.disit.org/km4city/schema#Organization_of_conventions_and_trade_shows">km4c:Organization_of_conventions_and_trade_shows</a>
    /// </summary>
    let Organization_of_conventions_and_trade_shows = _prefixId.prefix "Organization_of_conventions_and_trade_shows"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Altre sistemazionirdfs:label : Other Accommodation</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_accommodation">km4c:Other_accommodation</a>
    /// </summary>
    let Other_accommodation = _prefixId.prefix "Other_accommodation"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Altre emittentirdfs:label : Other broadcasting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_broadcasting">km4c:Other_broadcasting</a>
    /// </summary>
    let Other_broadcasting = _prefixId.prefix "Other_broadcasting"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli Varirdfs:label : Other Goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_goods">km4c:Other_goods</a>
    /// </summary>
    let Other_goods = _prefixId.prefix "Other_goods"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Altre Industrie Manifatturiererdfs:label : Other Manufacturing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_manufacturing">km4c:Other_manufacturing</a>
    /// </summary>
    let Other_manufacturing = _prefixId.prefix "Other_manufacturing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Estrazione di altri mineralirdfs:label : Other mining and quarrying</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_mining_and_quarrying">km4c:Other_mining_and_quarrying</a>
    /// </summary>
    let Other_mining_and_quarrying = _prefixId.prefix "Other_mining_and_quarrying"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Altri Ufficirdfs:label : Other Office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_office">km4c:Other_office</a>
    /// </summary>
    let Other_office = _prefixId.prefix "Other_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Altri Esercizirdfs:label : Other Retail Sale</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_retail_sale">km4c:Other_retail_sale</a>
    /// </summary>
    let Other_retail_sale = _prefixId.prefix "Other_retail_sale"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Altri Lavori Costruzione Specializzatirdfs:label : Other Specialized Construction</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_specialized_construction">km4c:Other_specialized_construction</a>
    /// </summary>
    let Other_specialized_construction = _prefixId.prefix "Other_specialized_construction"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ingrosso Specializzatordfs:label : Other Specialized Wholesale</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_specialized_wholesale">km4c:Other_specialized_wholesale</a>
    /// </summary>
    let Other_specialized_wholesale = _prefixId.prefix "Other_specialized_wholesale"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Servizi di telecomunicazionerdfs:label : Other Telecommunications Activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Other_telecommunications_activities">km4c:Other_telecommunications_activities</a>
    /// </summary>
    let Other_telecommunications_activities = _prefixId.prefix "Other_telecommunications_activities"

    /// <summary>
    ///   <para>rdfs:comment : Comuni, regioni e provincie^^xsd:string</para>
    ///   <para>rdfs:label : Pubblica Amministrazionerdfs:label : Public Administration</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pa">km4c:Pa</a>
    /// </summary>
    let Pa = _prefixId.prefix "Pa"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Imballaggio e confezionamentordfs:label : Packaging activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Packaging_activities">km4c:Packaging_activities</a>
    /// </summary>
    let Packaging_activities = _prefixId.prefix "Packaging_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Attivita' paramedicherdfs:label : Paramedical activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Paramedical_activities">km4c:Paramedical_activities</a>
    /// </summary>
    let Paramedical_activities = _prefixId.prefix "Paramedical_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Organizzazione feste e cerimonierdfs:label : Parties and ceremonies</para>
    ///   <a href="http://www.disit.org/km4city/schema#Parties_and_ceremonies">km4c:Parties_and_ceremonies</a>
    /// </summary>
    let Parties_and_ceremonies = _prefixId.prefix "Parties_and_ceremonies"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Trasporto Aereordfs:label : Passenger Air Transport</para>
    ///   <a href="http://www.disit.org/km4city/schema#Passenger_air_transport">km4c:Passenger_air_transport</a>
    /// </summary>
    let Passenger_air_transport = _prefixId.prefix "Passenger_air_transport"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pasticceriardfs:label : Pastry shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pastry_shop">km4c:Pastry_shop</a>
    /// </summary>
    let Pastry_shop = _prefixId.prefix "Pastry_shop"
    /// <summary>
    ///   <para>rdfs:comment : Servizi rappresentati da una spezzata^^xsd:string</para>
    ///   <para>rdfs:label : Servizio con forma linearerdfs:label : String Service</para>
    ///   <a href="http://www.disit.org/km4city/schema#Path">km4c:Path</a>
    /// </summary>
    let Path = _prefixId.prefix "Path"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : area pedonalerdfs:label : pedestrian zone</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pedestrian_zone">km4c:Pedestrian_zone</a>
    /// </summary>
    let Pedestrian_zone = _prefixId.prefix "Pedestrian_zone"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Conservatori e accademierdfs:label : Performing arts schools</para>
    ///   <a href="http://www.disit.org/km4city/schema#Performing_arts_schools">km4c:Performing_arts_schools</a>
    /// </summary>
    let Performing_arts_schools = _prefixId.prefix "Performing_arts_schools"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Profumeria Cosmeticardfs:label : Perfumery and Cosmetic Articles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Perfumery_and_cosmetic_articles">km4c:Perfumery_and_cosmetic_articles</a>
    /// </summary>
    let Perfumery_and_cosmetic_articles = _prefixId.prefix "Perfumery_and_cosmetic_articles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio di beni personali e per la casardfs:label : Personal and household goods rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Personal_and_household_goods_rental">km4c:Personal_and_household_goods_rental</a>
    /// </summary>
    let Personal_and_household_goods_rental = _prefixId.prefix "Personal_and_household_goods_rental"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Servizi alla personardfs:label : Personal service activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Personal_service_activities">km4c:Personal_service_activities</a>
    /// </summary>
    let Personal_service_activities = _prefixId.prefix "Personal_service_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Toilette animalirdfs:label : Pet care services</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pet_care_services">km4c:Pet_care_services</a>
    /// </summary>
    let Pet_care_services = _prefixId.prefix "Pet_care_services"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Negozio di Animalirdfs:label : Pet Shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pet_shop">km4c:Pet_shop</a>
    /// </summary>
    let Pet_shop = _prefixId.prefix "Pet_shop"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Estrazione petrolio e gas natualerdfs:label : Petroleum and natural gas extraction</para>
    ///   <a href="http://www.disit.org/km4city/schema#Petroleum_and_natural_gas_extraction">km4c:Petroleum_and_natural_gas_extraction</a>
    /// </summary>
    let Petroleum_and_natural_gas_extraction = _prefixId.prefix "Petroleum_and_natural_gas_extraction"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Prodotti Farmaceuticirdfs:label : Pharmaceuticals</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pharmaceuticals">km4c:Pharmaceuticals</a>
    /// </summary>
    let Pharmaceuticals = _prefixId.prefix "Pharmaceuticals"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Farmaciardfs:label : Pharmacy</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pharmacy">km4c:Pharmacy</a>
    /// </summary>
    let Pharmacy = _prefixId.prefix "Pharmacy"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Fotografia e studi fotograficirdfs:label : Photographic activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Photographic_activities">km4c:Photographic_activities</a>
    /// </summary>
    let Photographic_activities = _prefixId.prefix "Photographic_activities"
    /// <summary>
    ///   <para>rdfs:comment : geolocalizzazione degli impianti fotovoltaici funzionanti^^xsd:string</para>
    ///   <para>rdfs:label : Impianti fotovoltaicirdfs:label : Photovoltaic system</para>
    ///   <a href="http://www.disit.org/km4city/schema#Photovoltaic_system">km4c:Photovoltaic_system</a>
    /// </summary>
    let Photovoltaic_system = _prefixId.prefix "Photovoltaic_system"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri di riabilitazionerdfs:label : Physical therapy centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Physical_therapy_centre">km4c:Physical_therapy_centre</a>
    /// </summary>
    let Physical_therapy_centre = _prefixId.prefix "Physical_therapy_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pizzeriardfs:label : Pizzeria</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pizzeria">km4c:Pizzeria</a>
    /// </summary>
    let Pizzeria = _prefixId.prefix "Pizzeria"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centro antivelenirdfs:label : Poison control centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Poison_control_centre">km4c:Poison_control_centre</a>
    /// </summary>
    let Poison_control_centre = _prefixId.prefix "Poison_control_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Questurardfs:label : Police headquarters</para>
    ///   <a href="http://www.disit.org/km4city/schema#Police_headquarters">km4c:Police_headquarters</a>
    /// </summary>
    let Police_headquarters = _prefixId.prefix "Police_headquarters"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Piscinardfs:label : Pool</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pool">km4c:Pool</a>
    /// </summary>
    let Pool = _prefixId.prefix "Pool"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Istruzione e formazione tecnica superiore (IFTS)rdfs:label : Post-secondary education</para>
    ///   <a href="http://www.disit.org/km4city/schema#Post_secondary_education">km4c:Post_secondary_education</a>
    /// </summary>
    let Post_secondary_education = _prefixId.prefix "Post_secondary_education"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Poste e Corrierirdfs:label : Postal and Courier Activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Postal_and_courier_activities">km4c:Postal_and_courier_activities</a>
    /// </summary>
    let Postal_and_courier_activities = _prefixId.prefix "Postal_and_courier_activities"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ufficio postalerdfs:label : Postal office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Postal_office">km4c:Postal_office</a>
    /// </summary>
    let Postal_office = _prefixId.prefix "Postal_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole dell'infanziardfs:label : Pre-primary education</para>
    ///   <a href="http://www.disit.org/km4city/schema#Pre_primary_education">km4c:Pre_primary_education</a>
    /// </summary>
    let Pre_primary_education = _prefixId.prefix "Pre_primary_education"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Prefetturardfs:label : Prefecture</para>
    ///   <a href="http://www.disit.org/km4city/schema#Prefecture">km4c:Prefecture</a>
    /// </summary>
    let Prefecture = _prefixId.prefix "Prefecture"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole elementarirdfs:label : Primary education</para>
    ///   <a href="http://www.disit.org/km4city/schema#Primary_education">km4c:Primary_education</a>
    /// </summary>
    let Primary_education = _prefixId.prefix "Primary_education"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Stampa e Supporti Registratirdfs:label : Printing and Recorded Media</para>
    ///   <a href="http://www.disit.org/km4city/schema#Printing_and_recorded_media">km4c:Printing_and_recorded_media</a>
    /// </summary>
    let Printing_and_recorded_media = _prefixId.prefix "Printing_and_recorded_media"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Stampa e Servizirdfs:label : Printing and Services</para>
    ///   <a href="http://www.disit.org/km4city/schema#Printing_and_services">km4c:Printing_and_services</a>
    /// </summary>
    let Printing_and_services = _prefixId.prefix "Printing_and_services"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Clinica privatardfs:label : Private clinic</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_clinic">km4c:Private_clinic</a>
    /// </summary>
    let Private_clinic = _prefixId.prefix "Private_clinic"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Licei privatirdfs:label : Private high school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_high_school">km4c:Private_high_school</a>
    /// </summary>
    let Private_high_school = _prefixId.prefix "Private_high_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole materne privaterdfs:label : Private infant school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_infant_school">km4c:Private_infant_school</a>
    /// </summary>
    let Private_infant_school = _prefixId.prefix "Private_infant_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole medie privaterdfs:label : Private junior high school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_junior_high_school">km4c:Private_junior_high_school</a>
    /// </summary>
    let Private_junior_high_school = _prefixId.prefix "Private_junior_high_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole elementari privaterdfs:label : Private junior school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_junior_school">km4c:Private_junior_school</a>
    /// </summary>
    let Private_junior_school = _prefixId.prefix "Private_junior_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Istituti tecnici privatirdfs:label : Private polytechnic school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_polytechnic_school">km4c:Private_polytechnic_school</a>
    /// </summary>
    let Private_polytechnic_school = _prefixId.prefix "Private_polytechnic_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Nidi privatirdfs:label : Private preschool</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_preschool">km4c:Private_preschool</a>
    /// </summary>
    let Private_preschool = _prefixId.prefix "Private_preschool"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Istituti professionali privatirdfs:label : Private professional institute</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_professional_institute">km4c:Private_professional_institute</a>
    /// </summary>
    let Private_professional_institute = _prefixId.prefix "Private_professional_institute"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vigilanza privatardfs:label : Private security</para>
    ///   <a href="http://www.disit.org/km4city/schema#Private_security">km4c:Private_security</a>
    /// </summary>
    let Private_security = _prefixId.prefix "Private_security"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le varie provincie^^xsd:string</para>
    ///   <para>rdfs:label : Amministrazione Provincialerdfs:label : Provincial Administration</para>
    ///   <a href="http://www.disit.org/km4city/schema#Province">km4c:Province</a>
    /// </summary>
    let Province = _prefixId.prefix "Province"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Psicologirdfs:label : Psychologists</para>
    ///   <a href="http://www.disit.org/km4city/schema#Psychologists">km4c:Psychologists</a>
    /// </summary>
    let Psychologists = _prefixId.prefix "Psychologists"
    /// <summary>
    ///   <para>rdfs:comment : Servizio associato alla visualizzazione delle linee ATAF con le relative fermate^^xsd:stringrdfs:comment : Linea di una certa azienda TPL^^xsd:string</para>
    ///   <para>rdfs:label : Linea busrdfs:label : Linea TPLrdfs:label : Public Transport Linerdfs:label : Bus Line</para>
    ///   <a href="http://www.disit.org/km4city/schema#PublicTransportLine">km4c:PublicTransportLine</a>
    /// </summary>
    let PublicTransportLine = _prefixId.prefix "PublicTransportLine"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Licei pubblicirdfs:label : Public high school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Public_high_school">km4c:Public_high_school</a>
    /// </summary>
    let Public_high_school = _prefixId.prefix "Public_high_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ospedale pubblicordfs:label : Public hospital</para>
    ///   <a href="http://www.disit.org/km4city/schema#Public_hospital">km4c:Public_hospital</a>
    /// </summary>
    let Public_hospital = _prefixId.prefix "Public_hospital"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole materne pubblicherdfs:label : Public infant school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Public_infant_school">km4c:Public_infant_school</a>
    /// </summary>
    let Public_infant_school = _prefixId.prefix "Public_infant_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole medie pubblicherdfs:label : Public junior high school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Public_junior_high_school">km4c:Public_junior_high_school</a>
    /// </summary>
    let Public_junior_high_school = _prefixId.prefix "Public_junior_high_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole elementari pubblicherdfs:label : Public junior school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Public_junior_school">km4c:Public_junior_school</a>
    /// </summary>
    let Public_junior_school = _prefixId.prefix "Public_junior_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Istituti tecnici pubblicirdfs:label : Public polytechnic school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Public_polytechnic_school">km4c:Public_polytechnic_school</a>
    /// </summary>
    let Public_polytechnic_school = _prefixId.prefix "Public_polytechnic_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Istituti professionali pubblicirdfs:label : Public professional institute</para>
    ///   <a href="http://www.disit.org/km4city/schema#Public_professional_institute">km4c:Public_professional_institute</a>
    /// </summary>
    let Public_professional_institute = _prefixId.prefix "Public_professional_institute"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Universita pubblicherdfs:label : Public university</para>
    ///   <a href="http://www.disit.org/km4city/schema#Public_university">km4c:Public_university</a>
    /// </summary>
    let Public_university = _prefixId.prefix "Public_university"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Editoriardfs:label : Publishing activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Publishing_activities">km4c:Publishing_activities</a>
    /// </summary>
    let Publishing_activities = _prefixId.prefix "Publishing_activities"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Certificazione e controllo qualita'rdfs:label : Quality Control and Certification</para>
    ///   <a href="http://www.disit.org/km4city/schema#Quality_control_and_certification">km4c:Quality_control_and_certification</a>
    /// </summary>
    let Quality_control_and_certification = _prefixId.prefix "Quality_control_and_certification"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Estrazione di pietra, sabbia e argillardfs:label : Quarrying of stone sand and clay</para>
    ///   <a href="http://www.disit.org/km4city/schema#Quarrying_of_stone_sand_and_clay">km4c:Quarrying_of_stone_sand_and_clay</a>
    /// </summary>
    let Quarrying_of_stone_sand_and_clay = _prefixId.prefix "Quarrying_of_stone_sand_and_clay"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Varco ZTLrdfs:label : RTZ gate</para>
    ///   <a href="http://www.disit.org/km4city/schema#RTZgate">km4c:RTZgate</a>
    /// </summary>
    let RTZgate = _prefixId.prefix "RTZgate"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Emittenti Radiordfs:label : Radio broadcasting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Radio_broadcasting">km4c:Radio_broadcasting</a>
    /// </summary>
    let Radio_broadcasting = _prefixId.prefix "Radio_broadcasting"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rafting canoa e kayakrdfs:label : Rafting kayak</para>
    ///   <a href="http://www.disit.org/km4city/schema#Rafting_kayak">km4c:Rafting_kayak</a>
    /// </summary>
    let Rafting_kayak = _prefixId.prefix "Rafting_kayak"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le direttive ferroviarie^^xsd:string</para>
    ///   <para>rdfs:label : Direttiva Ferroviariardfs:label : Railway Direction</para>
    ///   <a href="http://www.disit.org/km4city/schema#RailwayDirection">km4c:RailwayDirection</a>
    /// </summary>
    let RailwayDirection = _prefixId.prefix "RailwayDirection"
    /// <summary>
    ///   <para>rdfs:label : Railway Elementrdfs:label : Elemento Ferroviario</para>
    ///   <para>rdfs:comment : Classe le cui istanze sono gli elementi che compongono le tratte, le sezioni o le linee ferroviarie^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#RailwayElement">km4c:RailwayElement</a>
    /// </summary>
    let RailwayElement = _prefixId.prefix "RailwayElement"
    /// <summary>
    ///   <para>rdfs:comment : 2 giunzioni delimitano un elemento ferroviario e rappresentano stazioni ferroviarie o scali merce^^xsd:string</para>
    ///   <para>rdfs:label : Giunzione Ferroviariardfs:label : Railway Junction</para>
    ///   <a href="http://www.disit.org/km4city/schema#RailwayJunction">km4c:RailwayJunction</a>
    /// </summary>
    let RailwayJunction = _prefixId.prefix "RailwayJunction"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le linee ferroviarie^^xsd:string</para>
    ///   <para>rdfs:label : Linea Ferroviariardfs:label : Railway Line</para>
    ///   <a href="http://www.disit.org/km4city/schema#RailwayLine">km4c:RailwayLine</a>
    /// </summary>
    let RailwayLine = _prefixId.prefix "RailwayLine"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le sezioni ferroviarie^^xsd:string</para>
    ///   <para>rdfs:label : Sezione Ferroviariardfs:label : Railway Section</para>
    ///   <a href="http://www.disit.org/km4city/schema#RailwaySection">km4c:RailwaySection</a>
    /// </summary>
    let RailwaySection = _prefixId.prefix "RailwaySection"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Sala giocordfs:label : Recreation room</para>
    ///   <a href="http://www.disit.org/km4city/schema#Recreation_room">km4c:Recreation_room</a>
    /// </summary>
    let Recreation_room = _prefixId.prefix "Recreation_room"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio  attrezzature sportive e ricreativerdfs:label : Recreational and Sports Goods rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Recreational_and_sports_goods_rental">km4c:Recreational_and_sports_goods_rental</a>
    /// </summary>
    let Recreational_and_sports_goods_rental = _prefixId.prefix "Recreational_and_sports_goods_rental"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ricerca e Selezione personalerdfs:label : Recruitment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Recruitment">km4c:Recruitment</a>
    /// </summary>
    let Recruitment = _prefixId.prefix "Recruitment"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Croce rossardfs:label : Red cross</para>
    ///   <a href="http://www.disit.org/km4city/schema#Red_cross">km4c:Red_cross</a>
    /// </summary>
    let Red_cross = _prefixId.prefix "Red_cross"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le varie regioni^^xsd:string</para>
    ///   <para>rdfs:label : Amministrazione Regionalerdfs:label : Regional Administration</para>
    ///   <a href="http://www.disit.org/km4city/schema#Region">km4c:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:comment : servizi che possono avere altre caratteristiche, rappresentate come servizi trasversali^^xsd:string</para>
    ///   <para>rdfs:label : Servizio Regolarerdfs:label : Regular Service</para>
    ///   <a href="http://www.disit.org/km4city/schema#RegularService">km4c:RegularService</a>
    /// </summary>
    let RegularService = _prefixId.prefix "RegularService"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Casa per ferierdfs:label : Religiuos guest house</para>
    ///   <a href="http://www.disit.org/km4city/schema#Religiuos_guest_house">km4c:Religiuos_guest_house</a>
    /// </summary>
    let Religiuos_guest_house = _prefixId.prefix "Religiuos_guest_house"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazionirdfs:label : Repair</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair">km4c:Repair</a>
    /// </summary>
    let Repair = _prefixId.prefix "Repair"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione strumenti musicalirdfs:label : Repair musical instruments</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair_musical_instruments">km4c:Repair_musical_instruments</a>
    /// </summary>
    let Repair_musical_instruments = _prefixId.prefix "Repair_musical_instruments"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione telefoni, cellulari, faxrdfs:label : Repair of communication equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair_of_communication_equipment">km4c:Repair_of_communication_equipment</a>
    /// </summary>
    let Repair_of_communication_equipment = _prefixId.prefix "Repair_of_communication_equipment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione Tv, video e audiordfs:label : Repair of consumer electronics</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair_of_consumer_electronics">km4c:Repair_of_consumer_electronics</a>
    /// </summary>
    let Repair_of_consumer_electronics = _prefixId.prefix "Repair_of_consumer_electronics"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione calzature e articolo da viaggiordfs:label : Repair of footwear and leather goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair_of_footwear_and_leather_goods">km4c:Repair_of_footwear_and_leather_goods</a>
    /// </summary>
    let Repair_of_footwear_and_leather_goods = _prefixId.prefix "Repair_of_footwear_and_leather_goods"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione articoli giardinaggiordfs:label : Repair of garden equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair_of_garden_equipment">km4c:Repair_of_garden_equipment</a>
    /// </summary>
    let Repair_of_garden_equipment = _prefixId.prefix "Repair_of_garden_equipment"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione articoli per la casardfs:label : Repair of home equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair_of_home_equipment">km4c:Repair_of_home_equipment</a>
    /// </summary>
    let Repair_of_home_equipment = _prefixId.prefix "Repair_of_home_equipment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione elettrodomesticirdfs:label : Repair of household appliances</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair_of_household_appliances">km4c:Repair_of_household_appliances</a>
    /// </summary>
    let Repair_of_household_appliances = _prefixId.prefix "Repair_of_household_appliances"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riparazione articoli sportivi e da campeggiordfs:label : Repair of sporting goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Repair_of_sporting_goods">km4c:Repair_of_sporting_goods</a>
    /// </summary>
    let Repair_of_sporting_goods = _prefixId.prefix "Repair_of_sporting_goods"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenzie di informazioni commercialirdfs:label : Reporting agencies</para>
    ///   <a href="http://www.disit.org/km4city/schema#Reporting_agencies">km4c:Reporting_agencies</a>
    /// </summary>
    let Reporting_agencies = _prefixId.prefix "Reporting_agencies"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Riproduzione Supporti Registratirdfs:label : Reproduction Recorded Media</para>
    ///   <a href="http://www.disit.org/km4city/schema#Reproduction_recorded_media">km4c:Reproduction_recorded_media</a>
    /// </summary>
    let Reproduction_recorded_media = _prefixId.prefix "Reproduction_recorded_media"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ricerca e Sviluppordfs:label : Research and development</para>
    ///   <a href="http://www.disit.org/km4city/schema#Research_and_development">km4c:Research_and_development</a>
    /// </summary>
    let Research_and_development = _prefixId.prefix "Research_and_development"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Assistenza residenzialerdfs:label : Residential care activities</para>
    ///   <a href="http://www.disit.org/km4city/schema#Residential_care_activities">km4c:Residential_care_activities</a>
    /// </summary>
    let Residential_care_activities = _prefixId.prefix "Residential_care_activities"
    /// <summary>
    ///   <para>rdfs:comment : Delibera approvata da una qualche Pa^^xsd:string</para>
    ///   <para>rdfs:label : Deliberardfs:label : Resolution</para>
    ///   <a href="http://www.disit.org/km4city/schema#Resolution">km4c:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Casa di riposordfs:label : Rest home</para>
    ///   <a href="http://www.disit.org/km4city/schema#Rest_home">km4c:Rest_home</a>
    /// </summary>
    let Rest_home = _prefixId.prefix "Rest_home"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ristoranterdfs:label : Restaurant</para>
    ///   <a href="http://www.disit.org/km4city/schema#Restaurant">km4c:Restaurant</a>
    /// </summary>
    let Restaurant = _prefixId.prefix "Restaurant"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Restauratorirdfs:label : Restorers</para>
    ///   <a href="http://www.disit.org/km4city/schema#Restorers">km4c:Restorers</a>
    /// </summary>
    let Restorers = _prefixId.prefix "Restorers"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Dettaglio Ricambi Autoveicolirdfs:label : Retail Motor Vehicles Parts</para>
    ///   <a href="http://www.disit.org/km4city/schema#Retail_motor_vehicles_parts">km4c:Retail_motor_vehicles_parts</a>
    /// </summary>
    let Retail_motor_vehicles_parts = _prefixId.prefix "Retail_motor_vehicles_parts"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Dettaglio Esercizi Non Specializzatirdfs:label : Retail Sale Non-Specialized Stores</para>
    ///   <a href="http://www.disit.org/km4city/schema#Retail_sale_non_specialized_stores">km4c:Retail_sale_non_specialized_stores</a>
    /// </summary>
    let Retail_sale_non_specialized_stores = _prefixId.prefix "Retail_sale_non_specialized_stores"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Dettagliordfs:label : Retail Trade</para>
    ///   <a href="http://www.disit.org/km4city/schema#Retail_trade">km4c:Retail_trade</a>
    /// </summary>
    let Retail_trade = _prefixId.prefix "Retail_trade"
    /// <summary>
    ///   <para>rdfs:comment : Corsa programmata da una certa azienda TPL su un certo percorso di una certa linea^^xsd:string</para>
    ///   <para>rdfs:label : Corsardfs:label : Ride</para>
    ///   <a href="http://www.disit.org/km4city/schema#Ride">km4c:Ride</a>
    /// </summary>
    let Ride = _prefixId.prefix "Ride"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Maneggirdfs:label : Riding stables</para>
    ///   <a href="http://www.disit.org/km4city/schema#Riding_stables">km4c:Riding_stables</a>
    /// </summary>
    let Riding_stables = _prefixId.prefix "Riding_stables"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono le strade^^xsd:string</para>
    ///   <para>rdfs:label : Stradardfs:label : Road</para>
    ///   <a href="http://www.disit.org/km4city/schema#Road">km4c:Road</a>
    /// </summary>
    let Road = _prefixId.prefix "Road"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono gli elementi che compongono le strade^^xsd:string</para>
    ///   <para>rdfs:label : Elemento Stradalerdfs:label : Road element</para>
    ///   <a href="http://www.disit.org/km4city/schema#RoadElement">km4c:RoadElement</a>
    /// </summary>
    let RoadElement = _prefixId.prefix "RoadElement"
    /// <summary>
    ///   <para>rdfs:comment : Tratto di strada lineare delimitato da due giunzioni che compone il road element^^xsd:string</para>
    ///   <para>rdfs:label : tratto di strada linearerdfs:label : RoadLink</para>
    ///   <a href="http://www.disit.org/km4city/schema#RoadLink">km4c:RoadLink</a>
    /// </summary>
    let RoadLink = _prefixId.prefix "RoadLink"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Corde, funi e sacchirdfs:label : Rope cord and twine</para>
    ///   <a href="http://www.disit.org/km4city/schema#Rope_cord_and_twine">km4c:Rope_cord_and_twine</a>
    /// </summary>
    let Rope_cord_and_twine = _prefixId.prefix "Rope_cord_and_twine"
    /// <summary>
    ///   <para>rdfs:comment : Percorso che percorre un mezzo di trasporto pubblico^^xsd:string</para>
    ///   <para>rdfs:label : Percorsordfs:label : Route</para>
    ///   <a href="http://www.disit.org/km4city/schema#Route">km4c:Route</a>
    /// </summary>
    let Route = _prefixId.prefix "Route"
    /// <summary>
    ///   <para>rdfs:comment : Punto di interconnessione tra segmenti di strada per determinare il percorso di una linea di TPL^^xsd:string</para>
    ///   <para>rdfs:label : giunzione dei percorsirdfs:label : Route Junction</para>
    ///   <a href="http://www.disit.org/km4city/schema#RouteJunction">km4c:RouteJunction</a>
    /// </summary>
    let RouteJunction = _prefixId.prefix "RouteJunction"
    /// <summary>
    ///   <para>rdfs:comment : Tratto di strada delimitato da due TPL junction che determina il percorso di una linea TPL^^xsd:string</para>
    ///   <para>rdfs:label : strada di collegamentordfs:label : RouteLink</para>
    ///   <a href="http://www.disit.org/km4city/schema#RouteLink">km4c:RouteLink</a>
    /// </summary>
    let RouteLink = _prefixId.prefix "RouteLink"
    /// <summary>
    ///   <para>rdfs:comment : Tratto di strada compreso tra due successive fermate dell'autobus di una certa linea^^xsd:string</para>
    ///   <para>rdfs:label : Sezione di percorsordfs:label : Route Section</para>
    ///   <a href="http://www.disit.org/km4city/schema#RouteSection">km4c:RouteSection</a>
    /// </summary>
    let RouteSection = _prefixId.prefix "RouteSection"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuola di velardfs:label : Sailing school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sailing_school">km4c:Sailing_school</a>
    /// </summary>
    let Sailing_school = _prefixId.prefix "Sailing_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Ricambi Autoveicolirdfs:label : Sale Motor Vehicles Parts</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sale_motor_vehicles_parts">km4c:Sale_motor_vehicles_parts</a>
    /// </summary>
    let Sale_motor_vehicles_parts = _prefixId.prefix "Sale_motor_vehicles_parts"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Autoveicolirdfs:label : Sale of Motor Vehicles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sale_of_motor_vehicles">km4c:Sale_of_motor_vehicles</a>
    /// </summary>
    let Sale_of_motor_vehicles = _prefixId.prefix "Sale_of_motor_vehicles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Autoveicoli Motociclirdfs:label : Sale of Motor Vehicles and Motorcycles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sale_of_motor_vehicles_and_motorcycles">km4c:Sale_of_motor_vehicles_and_motorcycles</a>
    /// </summary>
    let Sale_of_motor_vehicles_and_motorcycles = _prefixId.prefix "Sale_of_motor_vehicles_and_motorcycles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Motociclirdfs:label : Sale of Motorcycles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sale_of_motorcycles">km4c:Sale_of_motorcycles</a>
    /// </summary>
    let Sale_of_motorcycles = _prefixId.prefix "Sale_of_motorcycles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita per Corrispondenza o via Internetrdfs:label : Sale Via Mail Order Houses or Via Internet</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sale_via_mail_order_houses_or_via_internet">km4c:Sale_via_mail_order_houses_or_via_internet</a>
    /// </summary>
    let Sale_via_mail_order_houses_or_via_internet = _prefixId.prefix "Sale_via_mail_order_houses_or_via_internet"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Paninoteche pubsrdfs:label : Sandwich shop pub</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sandwich_shop_pub">km4c:Sandwich_shop_pub</a>
    /// </summary>
    let Sandwich_shop_pub = _prefixId.prefix "Sandwich_shop_pub"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli Igienico-Sanitarirdfs:label : Sanitary Equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sanitary_equipment">km4c:Sanitary_equipment</a>
    /// </summary>
    let Sanitary_equipment = _prefixId.prefix "Sanitary_equipment"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Segherierdfs:label : Sawmilling</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sawmilling">km4c:Sawmilling</a>
    /// </summary>
    let Sawmilling = _prefixId.prefix "Sawmilling"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Libri Usatirdfs:label : Second-Hand Books</para>
    ///   <a href="http://www.disit.org/km4city/schema#Second_hand_books">km4c:Second_hand_books</a>
    /// </summary>
    let Second_hand_books = _prefixId.prefix "Second_hand_books"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli Usatirdfs:label : Second-Hand Goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Second_hand_goods">km4c:Second_hand_goods</a>
    /// </summary>
    let Second_hand_goods = _prefixId.prefix "Second_hand_goods"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuole medie, licei e istituti tecnicirdfs:label : Secondary education</para>
    ///   <a href="http://www.disit.org/km4city/schema#Secondary_education">km4c:Secondary_education</a>
    /// </summary>
    let Secondary_education = _prefixId.prefix "Secondary_education"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Supporto di segreteriardfs:label : Secretarial support services</para>
    ///   <a href="http://www.disit.org/km4city/schema#Secretarial_support_services">km4c:Secretarial_support_services</a>
    /// </summary>
    let Secretarial_support_services = _prefixId.prefix "Secretarial_support_services"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Allarmi e sistemi di sicurezzardfs:label : Security systems</para>
    ///   <a href="http://www.disit.org/km4city/schema#Security_systems">km4c:Security_systems</a>
    /// </summary>
    let Security_systems = _prefixId.prefix "Security_systems"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Sistemi di sicurezzardfs:label : Security systems service</para>
    ///   <a href="http://www.disit.org/km4city/schema#Security_systems_service">km4c:Security_systems_service</a>
    /// </summary>
    let Security_systems_service = _prefixId.prefix "Security_systems_service"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ricoverirdfs:label : Senior centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Senior_centre">km4c:Senior_centre</a>
    /// </summary>
    let Senior_centre = _prefixId.prefix "Senior_centre"
    /// <summary>
    ///   <para>rdfs:comment : Sensore stradale che rilascia info sul traffico^^xsd:stringrdfs:comment : Singolo sensore per osservare velocita', traffico, concentrazione o densita'^^xsd:string</para>
    ///   <para>rdfs:label : Sensori del trafficordfs:label : Traffic sensorrdfs:label : Sensor</para>
    ///   <a href="http://www.disit.org/km4city/schema#SensorSite">km4c:SensorSite</a>
    /// </summary>
    let SensorSite = _prefixId.prefix "SensorSite"
    /// <summary>
    ///   <para>rdfs:comment : Insieme di sensori che rappresentano un unica installazione, un unico sito^^xsd:string</para>
    ///   <para>rdfs:label : Tabella di sensorirdfs:label : Sensor Site Table</para>
    ///   <a href="http://www.disit.org/km4city/schema#SensorSiteTable">km4c:SensorSiteTable</a>
    /// </summary>
    let SensorSiteTable = _prefixId.prefix "SensorSiteTable"
    /// <summary>
    ///   <para>rdfs:comment : attivita' commerciali, servizi al cittadino, uffici...che possono essere localizzati in un punto^^xsd:string</para>
    ///   <para>rdfs:label : Serviziordfs:label : Service</para>
    ///   <a href="http://www.disit.org/km4city/schema#Service">km4c:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rete Fognariardfs:label : Sewerage</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sewerage">km4c:Sewerage</a>
    /// </summary>
    let Sewerage = _prefixId.prefix "Sewerage"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Sexy Shoprdfs:label : Sexy Shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sexy_shop">km4c:Sexy_shop</a>
    /// </summary>
    let Sexy_shop = _prefixId.prefix "Sexy_shop"
    /// <summary>
    ///   <para>rdfs:comment : negozi, centri commerciali, spacci, ogni forma di attivita' di vendita al pubblico^^xsd:string</para>
    ///   <para>rdfs:label : Shopping e servizirdfs:label : Shopping and service</para>
    ///   <a href="http://www.disit.org/km4city/schema#ShoppingAndService">km4c:ShoppingAndService</a>
    /// </summary>
    let ShoppingAndService = _prefixId.prefix "ShoppingAndService"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri Commercialirdfs:label : Shopping centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Shopping_centre">km4c:Shopping_centre</a>
    /// </summary>
    let Shopping_centre = _prefixId.prefix "Shopping_centre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Negozi monomarcardfs:label : Single brand store</para>
    ///   <a href="http://www.disit.org/km4city/schema#Single_brand_store">km4c:Single_brand_store</a>
    /// </summary>
    let Single_brand_store = _prefixId.prefix "Single_brand_store"
    /// <summary>
    ///   <para>rdfs:comment : Registrazione della situazione di occupazione di un determinato parcheggio in un certo istante^^xsd:string</para>
    ///   <para>rdfs:label : Situazione di un parcheggiordfs:label : Situation Record of a Car Park</para>
    ///   <a href="http://www.disit.org/km4city/schema#SituationRecord">km4c:SituationRecord</a>
    /// </summary>
    let SituationRecord = _prefixId.prefix "SituationRecord"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Scuola di scirdfs:label : Ski school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Ski_school">km4c:Ski_school</a>
    /// </summary>
    let Ski_school = _prefixId.prefix "Ski_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Impianti sciisticirdfs:label : Skiing facility</para>
    ///   <a href="http://www.disit.org/km4city/schema#Skiing_facility">km4c:Skiing_facility</a>
    /// </summary>
    let Skiing_facility = _prefixId.prefix "Skiing_facility"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Piccoli Elettrodomesticirdfs:label : Small Household Appliances</para>
    ///   <a href="http://www.disit.org/km4city/schema#Small_household_appliances">km4c:Small_household_appliances</a>
    /// </summary>
    let Small_household_appliances = _prefixId.prefix "Small_household_appliances"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Bottegardfs:label : Small shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Small_shop">km4c:Small_shop</a>
    /// </summary>
    let Small_shop = _prefixId.prefix "Small_shop"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centro socialerdfs:label : Social centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Social_centre">km4c:Social_centre</a>
    /// </summary>
    let Social_centre = _prefixId.prefix "Social_centre"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ufficio inpsrdfs:label : Social security service office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Social_security_service_office">km4c:Social_security_service_office</a>
    /// </summary>
    let Social_security_service_office = _prefixId.prefix "Social_security_service_office"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Assistenza socialerdfs:label : Social work</para>
    ///   <a href="http://www.disit.org/km4city/schema#Social_work">km4c:Social_work</a>
    /// </summary>
    let Social_work = _prefixId.prefix "Social_work"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Editoria Softwarerdfs:label : Software publishing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Software_publishing">km4c:Software_publishing</a>
    /// </summary>
    let Software_publishing = _prefixId.prefix "Software_publishing"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Registrazione sonora e editoria musicalerdfs:label : Sound Recording and Music Publishing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sound_recording_and_music_publishing">km4c:Sound_recording_and_music_publishing</a>
    /// </summary>
    let Sound_recording_and_music_publishing = _prefixId.prefix "Sound_recording_and_music_publishing"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Souvenir Artigianato e Articoli Religiosirdfs:label : Souvenirs Craftwork and Religious Articles</para>
    ///   <a href="http://www.disit.org/km4city/schema#Souvenirs_Craftwork_and_religious_articles">km4c:Souvenirs_Craftwork_and_religious_articles</a>
    /// </summary>
    let Souvenirs_Craftwork_and_religious_articles = _prefixId.prefix "Souvenirs_Craftwork_and_religious_articles"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Lavori Costruzione Specializzatirdfs:label : Specialized Construction</para>
    ///   <a href="http://www.disit.org/km4city/schema#Specialized_construction">km4c:Specialized_construction</a>
    /// </summary>
    let Specialized_construction = _prefixId.prefix "Specialized_construction"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Grafici e disegnatorirdfs:label : Specialized Design</para>
    ///   <a href="http://www.disit.org/km4city/schema#Specialized_design">km4c:Specialized_design</a>
    /// </summary>
    let Specialized_design = _prefixId.prefix "Specialized_design"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Organizzazione eventi sportivirdfs:label : Sport event promoters</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sport_event_promoters">km4c:Sport_event_promoters</a>
    /// </summary>
    let Sport_event_promoters = _prefixId.prefix "Sport_event_promoters"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli Sportivirdfs:label : Sporting Equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sporting_equipment">km4c:Sporting_equipment</a>
    /// </summary>
    let Sporting_equipment = _prefixId.prefix "Sporting_equipment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Corsi sportivi e ricreativirdfs:label : Sports and recreation education</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sports_and_recreation_education">km4c:Sports_and_recreation_education</a>
    /// </summary>
    let Sports_and_recreation_education = _prefixId.prefix "Sports_and_recreation_education"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Societa' sportiverdfs:label : Sports clubs</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sports_clubs">km4c:Sports_clubs</a>
    /// </summary>
    let Sports_clubs = _prefixId.prefix "Sports_clubs"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Impianti sportivirdfs:label : Sports facility</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sports_facility">km4c:Sports_facility</a>
    /// </summary>
    let Sports_facility = _prefixId.prefix "Sports_facility"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Piazzerdfs:label : Squares</para>
    ///   <a href="http://www.disit.org/km4city/schema#Squares">km4c:Squares</a>
    /// </summary>
    let Squares = _prefixId.prefix "Squares"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Ambulanterdfs:label : Stalls and Markets</para>
    ///   <a href="http://www.disit.org/km4city/schema#Stalls_and_markets">km4c:Stalls_and_markets</a>
    /// </summary>
    let Stalls_and_markets = _prefixId.prefix "Stalls_and_markets"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Ambulante Abbigliamento e Calzaturerdfs:label : Stalls and Markets of Clothing and Footwear</para>
    ///   <a href="http://www.disit.org/km4city/schema#Stalls_and_markets_of_clothing_and_footwear">km4c:Stalls_and_markets_of_clothing_and_footwear</a>
    /// </summary>
    let Stalls_and_markets_of_clothing_and_footwear = _prefixId.prefix "Stalls_and_markets_of_clothing_and_footwear"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Ambulante Alimentarirdfs:label : Stalls and Markets of Food</para>
    ///   <a href="http://www.disit.org/km4city/schema#Stalls_and_markets_of_food">km4c:Stalls_and_markets_of_food</a>
    /// </summary>
    let Stalls_and_markets_of_food = _prefixId.prefix "Stalls_and_markets_of_food"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Ambulante Altri Prodottirdfs:label : Stalls and Markets Other Goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Stalls_and_markets_other_goods">km4c:Stalls_and_markets_other_goods</a>
    /// </summary>
    let Stalls_and_markets_other_goods = _prefixId.prefix "Stalls_and_markets_other_goods"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Filatelia e Numismaticardfs:label : Stamps and Coins</para>
    ///   <a href="http://www.disit.org/km4city/schema#Stamps_and_coins">km4c:Stamps_and_coins</a>
    /// </summary>
    let Stamps_and_coins = _prefixId.prefix "Stamps_and_coins"
    /// <summary>
    ///   <para>rdfs:comment : Valore che fa riferimento ad un dato statistico legato ad una strada o ad una Pa^^xsd:string</para>
    ///   <para>rdfs:label : Dato statisticordfs:label : StatisticalData</para>
    ///   <a href="http://www.disit.org/km4city/schema#StatisticalData">km4c:StatisticalData</a>
    /// </summary>
    let StatisticalData = _prefixId.prefix "StatisticalData"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Lavorazione Pietrardfs:label : Stone Processing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Stone_processing">km4c:Stone_processing</a>
    /// </summary>
    let Stone_processing = _prefixId.prefix "Stone_processing"
    /// <summary>
    ///   <para>rdfs:comment : Classe le cui istanze sono i numeri civici conosciuti^^xsd:string</para>
    ///   <para>rdfs:label : Numero Civicordfs:label : Street Number</para>
    ///   <a href="http://www.disit.org/km4city/schema#StreetNumber">km4c:StreetNumber</a>
    /// </summary>
    let StreetNumber = _prefixId.prefix "StreetNumber"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Pulizia aree pubbliche e straderdfs:label : Street sweeping</para>
    ///   <a href="http://www.disit.org/km4city/schema#Street_sweeping">km4c:Street_sweeping</a>
    /// </summary>
    let Street_sweeping = _prefixId.prefix "Street_sweeping"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Colonie per ragazzirdfs:label : Summer camp</para>
    ///   <a href="http://www.disit.org/km4city/schema#Summer_camp">km4c:Summer_camp</a>
    /// </summary>
    let Summer_camp = _prefixId.prefix "Summer_camp"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : casa per vacanzerdfs:label : Summer residence</para>
    ///   <a href="http://www.disit.org/km4city/schema#Summer_residence">km4c:Summer_residence</a>
    /// </summary>
    let Summer_residence = _prefixId.prefix "Summer_residence"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Supermercatordfs:label : Supermarket</para>
    ///   <a href="http://www.disit.org/km4city/schema#Supermarket">km4c:Supermarket</a>
    /// </summary>
    let Supermarket = _prefixId.prefix "Supermarket"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Attivita' di Supporto ai trasportirdfs:label : Support Activities for Transportation</para>
    ///   <a href="http://www.disit.org/km4city/schema#Support_activities_for_transportation">km4c:Support_activities_for_transportation</a>
    /// </summary>
    let Support_activities_for_transportation = _prefixId.prefix "Support_activities_for_transportation"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Supporto Produzione Animalirdfs:label : Support Animal Production</para>
    ///   <a href="http://www.disit.org/km4city/schema#Support_animal_production">km4c:Support_animal_production</a>
    /// </summary>
    let Support_animal_production = _prefixId.prefix "Support_animal_production"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Geometrirdfs:label : Surveyor</para>
    ///   <a href="http://www.disit.org/km4city/schema#Surveyor">km4c:Surveyor</a>
    /// </summary>
    let Surveyor = _prefixId.prefix "Surveyor"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Sushi barrdfs:label : Sushi bar</para>
    ///   <a href="http://www.disit.org/km4city/schema#Sushi_bar">km4c:Sushi_bar</a>
    /// </summary>
    let Sushi_bar = _prefixId.prefix "Sushi_bar"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Take Awayrdfs:label : Take Away</para>
    ///   <a href="http://www.disit.org/km4city/schema#Take_away">km4c:Take_away</a>
    /// </summary>
    let Take_away = _prefixId.prefix "Take_away"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Conceriardfs:label : Tannery</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tannery">km4c:Tannery</a>
    /// </summary>
    let Tannery = _prefixId.prefix "Tannery"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Tatuaggio e piercingrdfs:label : Tattoo and piercing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tattoo_and_piercing">km4c:Tattoo_and_piercing</a>
    /// </summary>
    let Tattoo_and_piercing = _prefixId.prefix "Tattoo_and_piercing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri assistenza fiscale (CAF)rdfs:label : Tax advice</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tax_advice">km4c:Tax_advice</a>
    /// </summary>
    let Tax_advice = _prefixId.prefix "Tax_advice"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Taxirdfs:label : Taxi Company</para>
    ///   <a href="http://www.disit.org/km4city/schema#Taxi_company">km4c:Taxi_company</a>
    /// </summary>
    let Taxi_company = _prefixId.prefix "Taxi_company"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Aree sosta taxirdfs:label : Taxi park</para>
    ///   <a href="http://www.disit.org/km4city/schema#Taxi_park">km4c:Taxi_park</a>
    /// </summary>
    let Taxi_park = _prefixId.prefix "Taxi_park"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Studi Tecnicirdfs:label : Technical consultants</para>
    ///   <a href="http://www.disit.org/km4city/schema#Technical_consultants">km4c:Technical_consultants</a>
    /// </summary>
    let Technical_consultants = _prefixId.prefix "Technical_consultants"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Collaudi tecnicirdfs:label : Technical testing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Technical_testing">km4c:Technical_testing</a>
    /// </summary>
    let Technical_testing = _prefixId.prefix "Technical_testing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Telefonia e Telecomunicazionirdfs:label : Telecommunications</para>
    ///   <a href="http://www.disit.org/km4city/schema#Telecommunications">km4c:Telecommunications</a>
    /// </summary>
    let Telecommunications = _prefixId.prefix "Telecommunications"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Emittenti Televisiverdfs:label : Television broadcasting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Television_broadcasting">km4c:Television_broadcasting</a>
    /// </summary>
    let Television_broadcasting = _prefixId.prefix "Television_broadcasting"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenzie Interinalirdfs:label : Temp agency</para>
    ///   <a href="http://www.disit.org/km4city/schema#Temp_agency">km4c:Temp_agency</a>
    /// </summary>
    let Temp_agency = _prefixId.prefix "Temp_agency"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Produzione Tessilerdfs:label : Textile Manufacturing</para>
    ///   <a href="http://www.disit.org/km4city/schema#Textile_manufacturing">km4c:Textile_manufacturing</a>
    /// </summary>
    let Textile_manufacturing = _prefixId.prefix "Textile_manufacturing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Prodotti Tessilirdfs:label : Textiles Products</para>
    ///   <a href="http://www.disit.org/km4city/schema#Textiles_products">km4c:Textiles_products</a>
    /// </summary>
    let Textiles_products = _prefixId.prefix "Textiles_products"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Teatrordfs:label : Theatre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Theatre">km4c:Theatre</a>
    /// </summary>
    let Theatre = _prefixId.prefix "Theatre"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rivendita bigliettirdfs:label : Ticket sale</para>
    ///   <a href="http://www.disit.org/km4city/schema#Ticket_sale">km4c:Ticket_sale</a>
    /// </summary>
    let Ticket_sale = _prefixId.prefix "Ticket_sale"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Industria del Tabaccordfs:label : Tobacco Industry</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tobacco_industry">km4c:Tobacco_industry</a>
    /// </summary>
    let Tobacco_industry = _prefixId.prefix "Tobacco_industry"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Tabaccheriardfs:label : Tobacco shop</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tobacco_shop">km4c:Tobacco_shop</a>
    /// </summary>
    let Tobacco_shop = _prefixId.prefix "Tobacco_shop"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Bagnordfs:label : Toilet</para>
    ///   <a href="http://www.disit.org/km4city/schema#Toilet">km4c:Toilet</a>
    /// </summary>
    let Toilet = _prefixId.prefix "Toilet"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Tour operatorrdfs:label : Tour operator</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tour_operator">km4c:Tour_operator</a>
    /// </summary>
    let Tour_operator = _prefixId.prefix "Tour_operator"
    /// <summary>
    ///   <para>rdfs:comment : attivita' dei servizi delle agenzie di viaggio, tour operator e servizi prenotazione^^xsd:string</para>
    ///   <para>rdfs:label : Servizi per il turismordfs:label : Tourism Services</para>
    ///   <a href="http://www.disit.org/km4city/schema#TourismService">km4c:TourismService</a>
    /// </summary>
    let TourismService = _prefixId.prefix "TourismService"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Uffici Reclami Turisticirdfs:label : Tourist complaints office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tourist_complaints_office">km4c:Tourist_complaints_office</a>
    /// </summary>
    let Tourist_complaints_office = _prefixId.prefix "Tourist_complaints_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Guide Turisticherdfs:label : Tourist guides</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tourist_guides">km4c:Tourist_guides</a>
    /// </summary>
    let Tourist_guides = _prefixId.prefix "Tourist_guides"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ufficio Informazioni Turisticherdfs:label : Tourist information office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tourist_information_office">km4c:Tourist_information_office</a>
    /// </summary>
    let Tourist_information_office = _prefixId.prefix "Tourist_information_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Itinerario turisticordfs:label : tourist trail</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tourist_trail">km4c:Tourist_trail</a>
    /// </summary>
    let Tourist_trail = _prefixId.prefix "Tourist_trail"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Traino e Soccorso Stradalerdfs:label : Towing and Roadside Assistance</para>
    ///   <a href="http://www.disit.org/km4city/schema#Towing_and_roadside_assistance">km4c:Towing_and_roadside_assistance</a>
    /// </summary>
    let Towing_and_roadside_assistance = _prefixId.prefix "Towing_and_roadside_assistance"

    /// <summary>
    ///   <para>rdfs:comment : sottoclasse delle osservazioni relative alla concentrazione di auto^^xsd:string</para>
    ///   <para>rdfs:label : Osservazione sulla concentrazione di autordfs:label : Traffic Concentration Observation</para>
    ///   <a href="http://www.disit.org/km4city/schema#TrafficConcentration">km4c:TrafficConcentration</a>
    /// </summary>
    let TrafficConcentration = _prefixId.prefix "TrafficConcentration"
    /// <summary>
    ///   <para>rdfs:comment : sottoclasse delle osservazioni relative alla flusso auto^^xsd:string</para>
    ///   <para>rdfs:label : Osservazione sul flussordfs:label : Traffic Flow Observation</para>
    ///   <a href="http://www.disit.org/km4city/schema#TrafficFlow">km4c:TrafficFlow</a>
    /// </summary>
    let TrafficFlow = _prefixId.prefix "TrafficFlow"
    /// <summary>
    ///   <para>rdfs:comment : sottoclasse delle osservazioni sul tempo medio di transito tra auto^^xsd:string</para>
    ///   <para>rdfs:label : Osservazione sulla densita' di autordfs:label : Traffic Headway Observation</para>
    ///   <a href="http://www.disit.org/km4city/schema#TrafficHeadway">km4c:TrafficHeadway</a>
    /// </summary>
    let TrafficHeadway = _prefixId.prefix "TrafficHeadway"
    /// <summary>
    ///   <para>rdfs:comment : sottoclasse delle osservazioni relative alla velocita' media^^xsd:string</para>
    ///   <para>rdfs:label : Osservazione sulla velocita'rdfs:label : TrafficSpeed Observation</para>
    ///   <a href="http://www.disit.org/km4city/schema#TrafficSpeed">km4c:TrafficSpeed</a>
    /// </summary>
    let TrafficSpeed = _prefixId.prefix "TrafficSpeed"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Polizia stradalerdfs:label : Traffic corps</para>
    ///   <a href="http://www.disit.org/km4city/schema#Traffic_corps">km4c:Traffic_corps</a>
    /// </summary>
    let Traffic_corps = _prefixId.prefix "Traffic_corps"
    /// <summary>
    ///   <para>rdfs:comment : Stazione ferroviaria, sono posizionate in corrispondenza di giunzioni ferroviarie con relazione 1:1^^xsd:string</para>
    ///   <para>rdfs:label : Stazione Ferroviariardfs:label : Train Station</para>
    ///   <a href="http://www.disit.org/km4city/schema#TrainStation">km4c:TrainStation</a>
    /// </summary>
    let TrainStation = _prefixId.prefix "TrainStation"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ufficio oggetti smarriti stazione trenordfs:label : Train lost property office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Train_lost_property_office">km4c:Train_lost_property_office</a>
    /// </summary>
    let Train_lost_property_office = _prefixId.prefix "Train_lost_property_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Stazione ferroviariardfs:label : Train station</para>
    ///   <a href="http://www.disit.org/km4city/schema#Train_station">km4c:Train_station</a>
    /// </summary>
    let Train_station = _prefixId.prefix "Train_station"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Formazione e aggiornamento professionalerdfs:label : Training school</para>
    ///   <a href="http://www.disit.org/km4city/schema#Training_school">km4c:Training_school</a>
    /// </summary>
    let Training_school = _prefixId.prefix "Training_school"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Istituti magistralirdfs:label : Training school for teachers</para>
    ///   <a href="http://www.disit.org/km4city/schema#Training_school_for_teachers">km4c:Training_school_for_teachers</a>
    /// </summary>
    let Training_school_for_teachers = _prefixId.prefix "Training_school_for_teachers"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Fermate del tramrdfs:label : Tram stops</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tram_stops">km4c:Tram_stops</a>
    /// </summary>
    let Tram_stops = _prefixId.prefix "Tram_stops"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Linea del Tramrdfs:label : Tram line</para>
    ///   <a href="http://www.disit.org/km4city/schema#Tramline">km4c:Tramline</a>
    /// </summary>
    let Tramline = _prefixId.prefix "Tramline"
    /// <summary>
    ///   <para>rdfs:comment : Parcheggi auto, stazioni ferroviarie o degli autobus, tutto cio' che deve essere localizzato su una mappa e fa riferimento al trasporto^^xsd:string</para>
    ///   <para>rdfs:label : Servizio di trasferimento e noleggiordfs:label : Transfer service and renting</para>
    ///   <a href="http://www.disit.org/km4city/schema#TransferServiceAndRenting">km4c:TransferServiceAndRenting</a>
    /// </summary>
    let TransferServiceAndRenting = _prefixId.prefix "TransferServiceAndRenting"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Traduttori e interpretirdfs:label : Translation and interpreting</para>
    ///   <a href="http://www.disit.org/km4city/schema#Translation_and_interpreting">km4c:Translation_and_interpreting</a>
    /// </summary>
    let Translation_and_interpreting = _prefixId.prefix "Translation_and_interpreting"
    /// <summary>
    ///   <para>rdfs:comment : servizi molto spesso collegati ad altri servizi, che presentano una loro geolocalizzazione^^xsd:string</para>
    ///   <para>rdfs:label : Servizio Trasversalerdfs:label : Transverse Service</para>
    ///   <a href="http://www.disit.org/km4city/schema#TransverseService">km4c:TransverseService</a>
    /// </summary>
    let TransverseService = _prefixId.prefix "TransverseService"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Trattoriardfs:label : Trattoria</para>
    ///   <a href="http://www.disit.org/km4city/schema#Trattoria">km4c:Trattoria</a>
    /// </summary>
    let Trattoria = _prefixId.prefix "Trattoria"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Agenzia di viaggiordfs:label : Travel agency</para>
    ///   <a href="http://www.disit.org/km4city/schema#Travel_agency">km4c:Travel_agency</a>
    /// </summary>
    let Travel_agency = _prefixId.prefix "Travel_agency"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ufficio visite guidaterdfs:label : Travel bureau</para>
    ///   <a href="http://www.disit.org/km4city/schema#Travel_bureau">km4c:Travel_bureau</a>
    /// </summary>
    let Travel_bureau = _prefixId.prefix "Travel_bureau"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Articoli da Viaggiordfs:label : Travel goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Travel_goods">km4c:Travel_goods</a>
    /// </summary>
    let Travel_goods = _prefixId.prefix "Travel_goods"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Assistenza Turisticardfs:label : Travel information</para>
    ///   <a href="http://www.disit.org/km4city/schema#Travel_information">km4c:Travel_information</a>
    /// </summary>
    let Travel_information = _prefixId.prefix "Travel_information"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Bigiotteriardfs:label : Trinkets</para>
    ///   <a href="http://www.disit.org/km4city/schema#Trinkets">km4c:Trinkets</a>
    /// </summary>
    let Trinkets = _prefixId.prefix "Trinkets"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Biancheria Maglieria Camicierdfs:label : Underwear, Knitwear and Shirts</para>
    ///   <a href="http://www.disit.org/km4city/schema#Underwear_knitwear_and_shirts">km4c:Underwear_knitwear_and_shirts</a>
    /// </summary>
    let Underwear_knitwear_and_shirts = _prefixId.prefix "Underwear_knitwear_and_shirts"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Tappezzerierdfs:label : Upholsterer</para>
    ///   <a href="http://www.disit.org/km4city/schema#Upholsterer">km4c:Upholsterer</a>
    /// </summary>
    let Upholsterer = _prefixId.prefix "Upholsterer"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Autobus urbanirdfs:label : Urban bus</para>
    ///   <a href="http://www.disit.org/km4city/schema#Urban_bus">km4c:Urban_bus</a>
    /// </summary>
    let Urban_bus = _prefixId.prefix "Urban_bus"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Numeri utilirdfs:label : Useful numbers</para>
    ///   <a href="http://www.disit.org/km4city/schema#Useful_numbers">km4c:Useful_numbers</a>
    /// </summary>
    let Useful_numbers = _prefixId.prefix "Useful_numbers"
    /// <summary>
    ///   <para>rdfs:comment : Fornitura di utenze e servizi^^xsd:string</para>
    ///   <para>rdfs:label : Forniture di servizirdfs:label : Utilities and supply</para>
    ///   <a href="http://www.disit.org/km4city/schema#UtilitiesAndSupply">km4c:UtilitiesAndSupply</a>
    /// </summary>
    let UtilitiesAndSupply = _prefixId.prefix "UtilitiesAndSupply"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Sgombero di cantine, solai e garagerdfs:label : Vacating service</para>
    ///   <a href="http://www.disit.org/km4city/schema#Vacating_service">km4c:Vacating_service</a>
    /// </summary>
    let Vacating_service = _prefixId.prefix "Vacating_service"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Residence di villeggiaturardfs:label : Vacation resort</para>
    ///   <a href="http://www.disit.org/km4city/schema#Vacation_resort">km4c:Vacation_resort</a>
    /// </summary>
    let Vacation_resort = _prefixId.prefix "Vacation_resort"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio veicolirdfs:label : Vehicle rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Vehicle_rental">km4c:Vehicle_rental</a>
    /// </summary>
    let Vehicle_rental = _prefixId.prefix "Vehicle_rental"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Rivendita autoveicolirdfs:label : Vehicle trade</para>
    ///   <a href="http://www.disit.org/km4city/schema#Vehicle_trade">km4c:Vehicle_trade</a>
    /// </summary>
    let Vehicle_trade = _prefixId.prefix "Vehicle_trade"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Distributori Automaticirdfs:label : Vending Machines</para>
    ///   <a href="http://www.disit.org/km4city/schema#Vending_machines">km4c:Vending_machines</a>
    /// </summary>
    let Vending_machines = _prefixId.prefix "Vending_machines"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Veterinarirdfs:label : Veterinary</para>
    ///   <a href="http://www.disit.org/km4city/schema#Veterinary">km4c:Veterinary</a>
    /// </summary>
    let Veterinary = _prefixId.prefix "Veterinary"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Noleggio Audiovisirdfs:label : Video tapes disks rental</para>
    ///   <a href="http://www.disit.org/km4city/schema#Video_tapes_disks_rental">km4c:Video_tapes_disks_rental</a>
    /// </summary>
    let Video_tapes_disks_rental = _prefixId.prefix "Video_tapes_disks_rental"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Carta da Parati Rivestimento Pavimentirdfs:label : Wallpaper and Floor Coverings</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wallpaper_and_floor_coverings">km4c:Wallpaper_and_floor_coverings</a>
    /// </summary>
    let Wallpaper_and_floor_coverings = _prefixId.prefix "Wallpaper_and_floor_coverings"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Magazzini e Custodiardfs:label : Warehousing and Storage</para>
    ///   <a href="http://www.disit.org/km4city/schema#Warehousing_and_storage">km4c:Warehousing_and_storage</a>
    /// </summary>
    let Warehousing_and_storage = _prefixId.prefix "Warehousing_and_storage"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Raccolta Trattamento Rifiutirdfs:label : Waste Collection and Treatment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Waste_collection_and_treatment">km4c:Waste_collection_and_treatment</a>
    /// </summary>
    let Waste_collection_and_treatment = _prefixId.prefix "Waste_collection_and_treatment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Raccolta Fornitura Trattamento Acquardfs:label : Water Collection Treatment and Supply</para>
    ///   <a href="http://www.disit.org/km4city/schema#Water_collection_treatment_and_supply">km4c:Water_collection_treatment_and_supply</a>
    /// </summary>
    let Water_collection_treatment_and_supply = _prefixId.prefix "Water_collection_treatment_and_supply"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Trasporto Marittimo e Fluvialirdfs:label : Water Transport</para>
    ///   <a href="http://www.disit.org/km4city/schema#Water_transport">km4c:Water_transport</a>
    /// </summary>
    let Water_transport = _prefixId.prefix "Water_transport"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Armi e Munizionirdfs:label : Weapons and Ammunition</para>
    ///   <a href="http://www.disit.org/km4city/schema#Weapons_and_ammunition">km4c:Weapons_and_ammunition</a>
    /// </summary>
    let Weapons_and_ammunition = _prefixId.prefix "Weapons_and_ammunition"
    /// <summary>
    ///   <para>rdfs:comment : Previsione metereologica relativa ad una specifica parte del giorno^^xsd:string</para>
    ///   <para>rdfs:label : Previsione metereologicardfs:label : Weather prediction</para>
    ///   <a href="http://www.disit.org/km4city/schema#WeatherPrediction">km4c:WeatherPrediction</a>
    /// </summary>
    let WeatherPrediction = _prefixId.prefix "WeatherPrediction"
    /// <summary>
    ///   <para>rdfs:comment : Bollettino metereologico con informazioni relative a temperatura, unidita', neve, etc^^xsd:string</para>
    ///   <para>rdfs:label : Bollettino metereologicordfs:label : Weather Report</para>
    ///   <a href="http://www.disit.org/km4city/schema#WeatherReport">km4c:WeatherReport</a>
    /// </summary>
    let WeatherReport = _prefixId.prefix "WeatherReport"
    /// <summary>
    ///   <para>rdfs:comment : Sensore meteo che rilascia info sulle previsioni meteo^^xsd:string</para>
    ///   <para>rdfs:label : Sensori meteordfs:label : Weather sensor</para>
    ///   <a href="http://www.disit.org/km4city/schema#Weather_sensor">km4c:Weather_sensor</a>
    /// </summary>
    let Weather_sensor = _prefixId.prefix "Weather_sensor"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Web e Internet Providerrdfs:label : Web and Internet Provider</para>
    ///   <a href="http://www.disit.org/km4city/schema#Web_and_internet_provider">km4c:Web_and_internet_provider</a>
    /// </summary>
    let Web_and_internet_provider = _prefixId.prefix "Web_and_internet_provider"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Bomboniererdfs:label : Wedding Favors</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wedding_favors">km4c:Wedding_favors</a>
    /// </summary>
    let Wedding_favors = _prefixId.prefix "Wedding_favors"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Assistenti sociali ufficirdfs:label : Welfare worker office</para>
    ///   <a href="http://www.disit.org/km4city/schema#Welfare_worker_office">km4c:Welfare_worker_office</a>
    /// </summary>
    let Welfare_worker_office = _prefixId.prefix "Welfare_worker_office"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Centri benessererdfs:label : Wellness centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wellness_centre">km4c:Wellness_centre</a>
    /// </summary>
    let Wellness_centre = _prefixId.prefix "Wellness_centre"
    /// <summary>
    ///   <para>rdfs:comment : Vendita all'ingrosso di qualsiasi cosa^^xsd:string</para>
    ///   <para>rdfs:label : Vendita all'ingrossordfs:label : Wholesale</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale">km4c:Wholesale</a>
    /// </summary>
    let Wholesale = _prefixId.prefix "Wholesale"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ingrosso Apparecchiature ICTrdfs:label : Wholesale ICT Equipment</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale_ICT_equipment">km4c:Wholesale_ICT_equipment</a>
    /// </summary>
    let Wholesale_ICT_equipment = _prefixId.prefix "Wholesale_ICT_equipment"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ingrosso Materie Prime Agricole e Animalirdfs:label : Wholesale Agricultural Raw Materials Live Animals</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale_agricultural_raw_materials_live_animals">km4c:Wholesale_agricultural_raw_materials_live_animals</a>
    /// </summary>
    let Wholesale_agricultural_raw_materials_live_animals = _prefixId.prefix "Wholesale_agricultural_raw_materials_live_animals"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Intermediari Commercio Ingrossordfs:label : Wholesale Commission Trade</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale_commission_trade">km4c:Wholesale_commission_trade</a>
    /// </summary>
    let Wholesale_commission_trade = _prefixId.prefix "Wholesale_commission_trade"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ingrosso Alimenti Bevande Tabaccordfs:label : Wholesale Food Beverages Tobacco</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale_food_beverages_tobacco">km4c:Wholesale_food_beverages_tobacco</a>
    /// </summary>
    let Wholesale_food_beverages_tobacco = _prefixId.prefix "Wholesale_food_beverages_tobacco"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ingrosso Beni Cosumordfs:label : Wholesale Household Goods</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale_household_goods">km4c:Wholesale_household_goods</a>
    /// </summary>
    let Wholesale_household_goods = _prefixId.prefix "Wholesale_household_goods"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Ingrosso Apparecchiature Macchinari Forniturerdfs:label : Wholesale Machinery Equipmentent Supplies</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale_machinery_equipmentent_supplies">km4c:Wholesale_machinery_equipmentent_supplies</a>
    /// </summary>
    let Wholesale_machinery_equipmentent_supplies = _prefixId.prefix "Wholesale_machinery_equipmentent_supplies"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Vendita Ingrosso Ricambi Autoveicolirdfs:label : Wholesale Motor Vehicles Parts</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale_motor_vehicles_parts">km4c:Wholesale_motor_vehicles_parts</a>
    /// </summary>
    let Wholesale_motor_vehicles_parts = _prefixId.prefix "Wholesale_motor_vehicles_parts"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Commercio Ingrossordfs:label : Wholesale Trade</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wholesale_trade">km4c:Wholesale_trade</a>
    /// </summary>
    let Wholesale_trade = _prefixId.prefix "Wholesale_trade"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Punto di accesso alla WiFirdfs:label : Free WiFi point</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wifi">km4c:Wifi</a>
    /// </summary>
    let Wifi = _prefixId.prefix "Wifi"
    /// <summary>
    ///   <para>rdfs:comment : Ristoranti, enoteche e tutte le altre attivita' enogastronomiche^^xsd:string</para>
    ///   <para>rdfs:label : Enogastronomiardfs:label : Wine And Food</para>
    ///   <a href="http://www.disit.org/km4city/schema#WineAndFood">km4c:WineAndFood</a>
    /// </summary>
    let WineAndFood = _prefixId.prefix "WineAndFood"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Enoteche e wine barrdfs:label : Wine shop and wine bar</para>
    ///   <a href="http://www.disit.org/km4city/schema#Wine_shop_and_wine_bar">km4c:Wine_shop_and_wine_bar</a>
    /// </summary>
    let Wine_shop_and_wine_bar = _prefixId.prefix "Wine_shop_and_wine_bar"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Assistenza minorirdfs:label : Youth assistance</para>
    ///   <a href="http://www.disit.org/km4city/schema#Youth_assistance">km4c:Youth_assistance</a>
    /// </summary>
    let Youth_assistance = _prefixId.prefix "Youth_assistance"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Informa Giovanirdfs:label : Youth information centre</para>
    ///   <a href="http://www.disit.org/km4city/schema#Youth_information_centre">km4c:Youth_information_centre</a>
    /// </summary>
    let Youth_information_centre = _prefixId.prefix "Youth_information_centre"
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>rdfs:comment : an entry rule refers to a specific Road element^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#accessToElement">km4c:accessToElement</a>
    /// </summary>
    let accessToElement = _prefixId.prefix "accessToElement"
    let accessType = _prefixId.prefix "accessType"
    let adRoadName = _prefixId.prefix "adRoadName"
    let adminClass = _prefixId.prefix "adminClass"
    let alterCode = _prefixId.prefix "alterCode"
    /// <summary>
    ///   <para>rdfs:comment : to connect a resolution to the municipality that have approved it^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#approvedByPa">km4c:approvedByPa</a>
    /// </summary>
    let approvedByPa = _prefixId.prefix "approvedByPa"
    let areaCode = _prefixId.prefix "areaCode"
    let areaName = _prefixId.prefix "areaName"
    /// <summary>
    ///   <para>rdfs:comment : to connect each beacon to the road in which it is installed^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#arrangedOnRoad">km4c:arrangedOnRoad</a>
    /// </summary>
    let arrangedOnRoad = _prefixId.prefix "arrangedOnRoad"
    /// <summary>
    ///   <para>rdfs:comment : each forecast refers to a specific bus stop^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#atBusStop">km4c:atBusStop</a>
    /// </summary>
    let atBusStop = _prefixId.prefix "atBusStop"
    let atecoCode = _prefixId.prefix "atecoCode"
    let automaticity = _prefixId.prefix "automaticity"
    let averageDistance = _prefixId.prefix "averageDistance"
    let averageSpeed = _prefixId.prefix "averageSpeed"
    /// <summary>
    ///   <para>rdfs:comment : Tempo medio tra 2 transiti^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#averageTime">km4c:averageTime</a>
    /// </summary>
    let averageTime = _prefixId.prefix "averageTime"
    let axialMass = _prefixId.prefix "axialMass"
    /// <summary>
    ///   <para>rdfs:comment : each routeLink, has a beginning and an end junction^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#beginsAtJunction">km4c:beginsAtJunction</a>
    /// </summary>
    let beginsAtJunction = _prefixId.prefix "beginsAtJunction"
    /// <summary>
    ///   <para>rdfs:comment : each road has street numbers^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#belongToRoad">km4c:belongToRoad</a>
    /// </summary>
    let belongToRoad = _prefixId.prefix "belongToRoad"
    let capacity = _prefixId.prefix "capacity"
    let carParkStatus = _prefixId.prefix "carParkStatus"
    let category = _prefixId.prefix "category"
    let classCode = _prefixId.prefix "classCode"
    /// <summary>
    ///   <para>rdfs:comment : there is no exact match between Road and AdministrativeRoad^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#coincideWith">km4c:coincideWith</a>
    /// </summary>
    let coincideWith = _prefixId.prefix "coincideWith"
    let combinedTraffic = _prefixId.prefix "combinedTraffic"
    /// <summary>
    ///   <para>rdfs:comment : a railway Direction is composed by more railway element^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#composeDirection">km4c:composeDirection</a>
    /// </summary>
    let composeDirection = _prefixId.prefix "composeDirection"
    /// <summary>
    ///   <para>rdfs:comment : a railway Section is composed by more railway element^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#composeSection">km4c:composeSection</a>
    /// </summary>
    let composeSection = _prefixId.prefix "composeSection"
    let composition = _prefixId.prefix "composition"
    let concentration = _prefixId.prefix "concentration"
    /// <summary>
    ///   <para>rdfs:comment : an AVMrecord concert to a unique line^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#concernLine">km4c:concernLine</a>
    /// </summary>
    let concernLine = _prefixId.prefix "concernLine"
    /// <summary>
    ///   <para>rdfs:comment : a maneuver takes place in correspondence of a node^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#concerningNode">km4c:concerningNode</a>
    /// </summary>
    let concerningNode = _prefixId.prefix "concerningNode"
    /// <summary>
    ///   <para>rdfs:comment : a railway Direction is composed by more railway element^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#consistOfElement">km4c:consistOfElement</a>
    /// </summary>
    let consistOfElement = _prefixId.prefix "consistOfElement"
    /// <summary>
    ///   <para>rdfs:comment : A road is formed by more elements road^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#containsElement">km4c:containsElement</a>
    /// </summary>
    let containsElement = _prefixId.prefix "containsElement"
    /// <summary>
    ///   <para>rdfs:comment : train station and good yard are located precisely on a junction^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#correspondToJunction">km4c:correspondToJunction</a>
    /// </summary>
    let correspondToJunction = _prefixId.prefix "correspondToJunction"
    /// <summary>
    ///   <para>rdfs:comment : there is no exact match between Road and AdministrativeRoad^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#correspondsTo">km4c:correspondsTo</a>
    /// </summary>
    let correspondsTo = _prefixId.prefix "correspondsTo"
    let day = _prefixId.prefix "day"
    /// <summary>
    ///   <para>rdfs:comment : direzione percorso^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#direction">km4c:direction</a>
    /// </summary>
    let direction = _prefixId.prefix "direction"
    let distance = _prefixId.prefix "distance"
    let districtCode = _prefixId.prefix "districtCode"
    let elemLocation = _prefixId.prefix "elemLocation"
    let elementClass = _prefixId.prefix "elementClass"
    let elementType = _prefixId.prefix "elementType"
    /// <summary>
    ///   <para>rdfs:comment : a railway element is delimited by two junctions^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#endAtJunction">km4c:endAtJunction</a>
    /// </summary>
    let endAtJunction = _prefixId.prefix "endAtJunction"
    /// <summary>
    ///   <para>rdfs:comment : a road linnk is delimited by two junctions^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#endingJunction">km4c:endingJunction</a>
    /// </summary>
    let endingJunction = _prefixId.prefix "endingJunction"
    /// <summary>
    ///   <para>rdfs:comment : a road element is delimited by 2 nodes^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#endsAtNode">km4c:endsAtNode</a>
    /// </summary>
    let endsAtNode = _prefixId.prefix "endsAtNode"
    /// <summary>
    ///   <para>rdfs:comment : a route section is delimited by two consecutive bus stops^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#endsAtStop">km4c:endsAtStop</a>
    /// </summary>
    let endsAtStop = _prefixId.prefix "endsAtStop"
    let entryType = _prefixId.prefix "entryType"
    let eventCategory = _prefixId.prefix "eventCategory"
    let eventTime = _prefixId.prefix "eventTime"
    let exitRate = _prefixId.prefix "exitRate"
    /// <summary>
    ///   <para>rdfs:comment : orario in cui e' previsto l'arrivo del bus a quella fermata DA ELIMINARE QUANDO INSTANT FUNZIONERA' ALLA PERFEZIONE^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#expectedTime">km4c:expectedTime</a>
    /// </summary>
    let expectedTime = _prefixId.prefix "expectedTime"
    let exponent = _prefixId.prefix "exponent"
    let extendName = _prefixId.prefix "extendName"
    let extendNumber = _prefixId.prefix "extendNumber"
    let fillRate = _prefixId.prefix "fillRate"
    /// <summary>
    ///   <para>rdfs:comment : each routeLink, has a beginning and an end junction^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#finishesAtJunction">km4c:finishesAtJunction</a>
    /// </summary>
    let finishesAtJunction = _prefixId.prefix "finishesAtJunction"
    let firenzeCard = _prefixId.prefix "firenzeCard"
    /// <summary>
    ///   <para>rdfs:comment : more road elements form an administrative road^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#formingAdminRoad">km4c:formingAdminRoad</a>
    /// </summary>
    let formingAdminRoad = _prefixId.prefix "formingAdminRoad"
    /// <summary>
    ///   <para>rdfs:comment : more road sensors form a sensor Table^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#formsTable">km4c:formsTable</a>
    /// </summary>
    let formsTable = _prefixId.prefix "formsTable"
    let free = _prefixId.prefix "free"
    let freeEvent = _prefixId.prefix "freeEvent"
    let gauge = _prefixId.prefix "gauge"
    /// <summary>
    ///   <para>rdfs:comment : the AVM refer to a specific ride code^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasAVMRecord">km4c:hasAVMRecord</a>
    /// </summary>
    let hasAVMRecord = _prefixId.prefix "hasAVMRecord"
    /// <summary>
    ///   <para>rdfs:comment : point corresponding to the house number of service^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasAccess">km4c:hasAccess</a>
    /// </summary>
    let hasAccess = _prefixId.prefix "hasAccess"
    /// <summary>
    ///   <para>rdfs:comment : to connect each beacon to observations that it produces^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasBObservation">km4c:hasBObservation</a>
    /// </summary>
    let hasBObservation = _prefixId.prefix "hasBObservation"
    /// <summary>
    ///   <para>rdfs:comment : to connect each car park to its installed sensor^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasCarParkSensor">km4c:hasCarParkSensor</a>
    /// </summary>
    let hasCarParkSensor = _prefixId.prefix "hasCarParkSensor"
    /// <summary>
    ///   <para>rdfs:comment : a railway line is composed by more railway element^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasElement">km4c:hasElement</a>
    /// </summary>
    let hasElement = _prefixId.prefix "hasElement"
    /// <summary>
    ///   <para>rdfs:comment : the expected time at the next bus stops^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasExpectedTime">km4c:hasExpectedTime</a>
    /// </summary>
    let hasExpectedTime = _prefixId.prefix "hasExpectedTime"
    /// <summary>
    ///   <para>rdfs:comment : it corresponds to the outer gate of the building^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasExternalAccess">km4c:hasExternalAccess</a>
    /// </summary>
    let hasExternalAccess = _prefixId.prefix "hasExternalAccess"
    /// <summary>
    ///   <para>rdfs:comment : the first element concerned the maneuver^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasFirstElem">km4c:hasFirstElem</a>
    /// </summary>
    let hasFirstElem = _prefixId.prefix "hasFirstElem"
    /// <summary>
    ///   <para>rdfs:comment : defines which is the departure section of a route^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasFirstSection">km4c:hasFirstSection</a>
    /// </summary>
    let hasFirstSection = _prefixId.prefix "hasFirstSection"
    /// <summary>
    ///   <para>rdfs:comment : defines which is the departure stop of a route^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasFirstStop">km4c:hasFirstStop</a>
    /// </summary>
    let hasFirstStop = _prefixId.prefix "hasFirstStop"
    /// <summary>
    ///   <para>rdfs:comment : each forecast refers to a specific bus stop^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasForecast">km4c:hasForecast</a>
    /// </summary>
    let hasForecast = _prefixId.prefix "hasForecast"
    /// <summary>
    ///   <para>rdfs:comment : some services and all railway elements have a specific geometry like polygons or linestrings^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasGeometry">km4c:hasGeometry</a>
    /// </summary>
    let hasGeometry = _prefixId.prefix "hasGeometry"
    /// <summary>
    ///   <para>rdfs:comment : it corresponds to the door of the building^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasInternalAccess">km4c:hasInternalAccess</a>
    /// </summary>
    let hasInternalAccess = _prefixId.prefix "hasInternalAccess"
    /// <summary>
    ///   <para>rdfs:comment : defines which is the last stop of a route^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasLastStop">km4c:hasLastStop</a>
    /// </summary>
    let hasLastStop = _prefixId.prefix "hasLastStop"
    /// <summary>
    ///   <para>rdfs:comment : the arrival time at last bus stops^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasLastStopTime">km4c:hasLastStopTime</a>
    /// </summary>
    let hasLastStopTime = _prefixId.prefix "hasLastStopTime"
    /// <summary>
    ///   <para>rdfs:comment : an entry rule can be connected to a specific maneuver^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasManeuver">km4c:hasManeuver</a>
    /// </summary>
    let hasManeuver = _prefixId.prefix "hasManeuver"
    /// <summary>
    ///   <para>rdfs:comment : a province is formed by more municipalities^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasMunicipality">km4c:hasMunicipality</a>
    /// </summary>
    let hasMunicipality = _prefixId.prefix "hasMunicipality"
    /// <summary>
    ///   <para>rdfs:comment : each road sensor produce a report every XX minuts^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasObservation">km4c:hasObservation</a>
    /// </summary>
    let hasObservation = _prefixId.prefix "hasObservation"
    /// <summary>
    ///   <para>rdfs:comment : a report is made up of more predictions^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasPrediction">km4c:hasPrediction</a>
    /// </summary>
    let hasPrediction = _prefixId.prefix "hasPrediction"
    /// <summary>
    ///   <para>rdfs:comment : in a region there are more than one province^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasProvince">km4c:hasProvince</a>
    /// </summary>
    let hasProvince = _prefixId.prefix "hasProvince"
    /// <summary>
    ///   <para>rdfs:comment : every 10 minutes a sensor sends a report^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasRecord">km4c:hasRecord</a>
    /// </summary>
    let hasRecord = _prefixId.prefix "hasRecord"
    /// <summary>
    ///   <para>rdfs:comment : regular services can be connected to transverse services^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasRegularService">km4c:hasRegularService</a>
    /// </summary>
    let hasRegularService = _prefixId.prefix "hasRegularService"
    /// <summary>
    ///   <para>rdfs:comment : to connect a resolution to the municipality that have approved it^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasResolution">km4c:hasResolution</a>
    /// </summary>
    let hasResolution = _prefixId.prefix "hasResolution"
    /// <summary>
    ///   <para>rdfs:comment : more road elements form an administrative road^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasRoadElement">km4c:hasRoadElement</a>
    /// </summary>
    let hasRoadElement = _prefixId.prefix "hasRoadElement"
    /// <summary>
    ///   <para>rdfs:comment : each route refers to a line^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasRoute">km4c:hasRoute</a>
    /// </summary>
    let hasRoute = _prefixId.prefix "hasRoute"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasRouteLink">km4c:hasRouteLink</a>
    /// </summary>
    let hasRouteLink = _prefixId.prefix "hasRouteLink"
    /// <summary>
    ///   <para>rdfs:comment : some road elements subject to rules of access^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasRule">km4c:hasRule</a>
    /// </summary>
    let hasRule = _prefixId.prefix "hasRule"
    /// <summary>
    ///   <para>rdfs:comment : the second element concerned the maneuver^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasSecondElem">km4c:hasSecondElem</a>
    /// </summary>
    let hasSecondElem = _prefixId.prefix "hasSecondElem"
    /// <summary>
    ///   <para>rdfs:comment : defines all the other section of a route^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasSection">km4c:hasSection</a>
    /// </summary>
    let hasSection = _prefixId.prefix "hasSection"
    /// <summary>
    ///   <para>rdfs:comment : each road element can be see as a collection of consecutive road link^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasSegment">km4c:hasSegment</a>
    /// </summary>
    let hasSegment = _prefixId.prefix "hasSegment"
    /// <summary>
    ///   <para>rdfs:comment : to connect a statistic to the referred municipality^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasStatistic">km4c:hasStatistic</a>
    /// </summary>
    let hasStatistic = _prefixId.prefix "hasStatistic"
    /// <summary>
    ///   <para>rdfs:comment : each road has street numbers^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasStreetNumber">km4c:hasStreetNumber</a>
    /// </summary>
    let hasStreetNumber = _prefixId.prefix "hasStreetNumber"
    /// <summary>
    ///   <para>rdfs:comment : the third element concerned the maneuver^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasThirdElem">km4c:hasThirdElem</a>
    /// </summary>
    let hasThirdElem = _prefixId.prefix "hasThirdElem"
    /// <summary>
    ///   <para>rdfs:comment : to connect each train station tothe correspondant service^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasTransferService">km4c:hasTransferService</a>
    /// </summary>
    let hasTransferService = _prefixId.prefix "hasTransferService"
    /// <summary>
    ///   <para>rdfs:comment : regular services can be connected to transverse services^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasTransverseService">km4c:hasTransverseService</a>
    /// </summary>
    let hasTransverseService = _prefixId.prefix "hasTransverseService"
    /// <summary>
    ///   <para>rdfs:comment : each weather forecasts is connected to a municipality^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#hasWeatherReport">km4c:hasWeatherReport</a>
    /// </summary>
    let hasWeatherReport = _prefixId.prefix "hasWeatherReport"
    let heightHour = _prefixId.prefix "heightHour"
    let hour = _prefixId.prefix "hour"
    let houseNumber = _prefixId.prefix "houseNumber"
    let humidity = _prefixId.prefix "humidity"
    /// <summary>
    ///   <para>rdfs:comment : municipality to which the road belongs^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#inMunicipalityOf">km4c:inMunicipalityOf</a>
    /// </summary>
    let inMunicipalityOf = _prefixId.prefix "inMunicipalityOf"
    /// <summary>
    ///   <para>rdfs:comment : each AVMrecord includes more forecasts^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#includeForecast">km4c:includeForecast</a>
    /// </summary>
    let includeForecast = _prefixId.prefix "includeForecast"
    /// <summary>
    ///   <para>rdfs:comment : the arrival time at last bus stops^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#instantAVM">km4c:instantAVM</a>
    /// </summary>
    let instantAVM = _prefixId.prefix "instantAVM"
    /// <summary>
    ///   <para>rdfs:comment : ime and date of each Beacon observation^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#instantBObserv">km4c:instantBObserv</a>
    /// </summary>
    let instantBObserv = _prefixId.prefix "instantBObserv"
    /// <summary>
    ///   <para>rdfs:comment : the expected time at the next bus stops^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#instantForecast">km4c:instantForecast</a>
    /// </summary>
    let instantForecast = _prefixId.prefix "instantForecast"
    /// <summary>
    ///   <para>rdfs:comment : the time of one observation^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#instantObserv">km4c:instantObserv</a>
    /// </summary>
    let instantObserv = _prefixId.prefix "instantObserv"
    /// <summary>
    ///   <para>rdfs:comment : the generation time of one situation record^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#instantParking">km4c:instantParking</a>
    /// </summary>
    let instantParking = _prefixId.prefix "instantParking"
    /// <summary>
    ///   <para>rdfs:comment : the generation time of a new weather report^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#instantWReport">km4c:instantWReport</a>
    /// </summary>
    let instantWReport = _prefixId.prefix "instantWReport"
    /// <summary>
    ///   <para>rdfs:comment : a railway Section is composed by more railway element^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isComposedByElement">km4c:isComposedByElement</a>
    /// </summary>
    let isComposedByElement = _prefixId.prefix "isComposedByElement"
    /// <summary>
    ///   <para>rdfs:comment : each milestone need to refers to a road^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isInElement">km4c:isInElement</a>
    /// </summary>
    let isInElement = _prefixId.prefix "isInElement"
    /// <summary>
    ///   <para>rdfs:comment : A bus stop can be connected to the municipality to which belong^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isInMunicipality">km4c:isInMunicipality</a>
    /// </summary>
    let isInMunicipality = _prefixId.prefix "isInMunicipality"
    /// <summary>
    ///   <para>rdfs:comment :  service and train station can be connected to the referred Road^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isInRoad">km4c:isInRoad</a>
    /// </summary>
    let isInRoad = _prefixId.prefix "isInRoad"
    /// <summary>
    ///   <para>rdfs:comment : a railway line is composed by more railway element^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isPartOfLine">km4c:isPartOfLine</a>
    /// </summary>
    let isPartOfLine = _prefixId.prefix "isPartOfLine"
    /// <summary>
    ///   <para>rdfs:comment : bus stops and bus lines are part of a lot^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isPartOfLot">km4c:isPartOfLot</a>
    /// </summary>
    let isPartOfLot = _prefixId.prefix "isPartOfLot"
    /// <summary>
    ///   <para>rdfs:comment : a province is formed by more municipalities^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isPartOfProvince">km4c:isPartOfProvince</a>
    /// </summary>
    let isPartOfProvince = _prefixId.prefix "isPartOfProvince"
    /// <summary>
    ///   <para>rdfs:comment : in a region there are more than one province^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isPartOfRegion">km4c:isPartOfRegion</a>
    /// </summary>
    let isPartOfRegion = _prefixId.prefix "isPartOfRegion"
    /// <summary>
    ///   <para>rdfs:comment : More road elements compose a road^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#isPartOfRoad">km4c:isPartOfRoad</a>
    /// </summary>
    let isPartOfRoad = _prefixId.prefix "isPartOfRoad"
    let juncType = _prefixId.prefix "juncType"
    /// <summary>
    ///   <para>rdfs:comment : the AVMrecord specify which is the last bus stop made^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#lastStop">km4c:lastStop</a>
    /// </summary>
    let lastStop = _prefixId.prefix "lastStop"
    /// <summary>
    ///   <para>rdfs:comment : orario in cui il bus ha raggiunto l'ultima fermata DA ELIMINARE QUANDO INSTANT FUNZIONERA' ALLA PERFEZIONE^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#lastStopTime">km4c:lastStopTime</a>
    /// </summary>
    let lastStopTime = _prefixId.prefix "lastStopTime"
    let lastTriples = _prefixId.prefix "lastTriples"
    let lastUpdate = _prefixId.prefix "lastUpdate"
    let length = _prefixId.prefix "length"
    let lineNumber = _prefixId.prefix "lineNumber"
    let lunarPhase = _prefixId.prefix "lunarPhase"
    let major = _prefixId.prefix "major"
    let managingAuth = _prefixId.prefix "managingAuth"
    /// <summary>
    ///   <para>rdfs:comment : the authority that deals with the road elements management^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#managingAuthority">km4c:managingAuthority</a>
    /// </summary>
    let managingAuthority = _prefixId.prefix "managingAuthority"
    /// <summary>
    ///   <para>rdfs:comment : ente gestore del sistema AVM o dei road sensor^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#managingBy">km4c:managingBy</a>
    /// </summary>
    let managingBy = _prefixId.prefix "managingBy"
    let maneuverType = _prefixId.prefix "maneuverType"
    let maxTemp = _prefixId.prefix "maxTemp"
    /// <summary>
    ///   <para>rdfs:comment : to connect each observation to the beacon that has product it^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#measuredByBeacon">km4c:measuredByBeacon</a>
    /// </summary>
    let measuredByBeacon = _prefixId.prefix "measuredByBeacon"
    /// <summary>
    ///   <para>rdfs:comment : each observation refers to only one road sensor^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#measuredBySensor">km4c:measuredBySensor</a>
    /// </summary>
    let measuredBySensor = _prefixId.prefix "measuredBySensor"
    /// <summary>
    ///   <para>rdfs:comment : Time and date of each Beacon observation^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#measuredDate">km4c:measuredDate</a>
    /// </summary>
    let measuredDate = _prefixId.prefix "measuredDate"
    /// <summary>
    ///   <para>rdfs:comment : the time of one observation^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#measuredTime">km4c:measuredTime</a>
    /// </summary>
    let measuredTime = _prefixId.prefix "measuredTime"
    let minTemp = _prefixId.prefix "minTemp"
    let minor = _prefixId.prefix "minor"
    let moonrise = _prefixId.prefix "moonrise"
    let moonset = _prefixId.prefix "moonset"
    let multimediaResource = _prefixId.prefix "multimediaResource"
    let nodeType = _prefixId.prefix "nodeType"
    /// <summary>
    ///   <para>rdfs:comment : numero di binari presenti. se in costruzione o dismesso inserire uno zero^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#numTrack">km4c:numTrack</a>
    /// </summary>
    let numTrack = _prefixId.prefix "numTrack"
    let number = _prefixId.prefix "number"
    /// <summary>
    ///   <para>rdfs:comment : the generation time of one situation record^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#observationTime">km4c:observationTime</a>
    /// </summary>
    let observationTime = _prefixId.prefix "observationTime"
    /// <summary>
    ///   <para>rdfs:comment : to connect each sensor to the referred car park service^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#observeCarPark">km4c:observeCarPark</a>
    /// </summary>
    let observeCarPark = _prefixId.prefix "observeCarPark"
    let occupancy = _prefixId.prefix "occupancy"
    /// <summary>
    ///   <para>rdfs:comment : numero di posti occupati^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#occupied">km4c:occupied</a>
    /// </summary>
    let occupied = _prefixId.prefix "occupied"
    /// <summary>
    ///   <para>rdfs:comment : rides and AVMrecords refer to a specific route^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#onRoute">km4c:onRoute</a>
    /// </summary>
    let onRoute = _prefixId.prefix "onRoute"
    let operatingStatus = _prefixId.prefix "operatingStatus"
    let overtime = _prefixId.prefix "overtime"
    /// <summary>
    ///   <para>rdfs:comment : sente proprietario del sistema AVM^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#owner">km4c:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:comment : the authority that owns the administrative road^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#ownerAuthority">km4c:ownerAuthority</a>
    /// </summary>
    let ownerAuthority = _prefixId.prefix "ownerAuthority"
    /// <summary>
    ///   <para>rdfs:comment : percentuale di posti occupati^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#parkOccupancy">km4c:parkOccupancy</a>
    /// </summary>
    let parkOccupancy = _prefixId.prefix "parkOccupancy"
    let perTemp = _prefixId.prefix "perTemp"
    let period = _prefixId.prefix "period"
    let placeName = _prefixId.prefix "placeName"
    /// <summary>
    ///   <para>rdfs:comment : each entry need to refers to a road^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#placedInElement">km4c:placedInElement</a>
    /// </summary>
    let placedInElement = _prefixId.prefix "placedInElement"
    /// <summary>
    ///   <para>rdfs:comment : to connect each road sensor to the road in which is installed^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#placedOnRoad">km4c:placedOnRoad</a>
    /// </summary>
    let placedOnRoad = _prefixId.prefix "placedOnRoad"
    let porteCochere = _prefixId.prefix "porteCochere"
    let power = _prefixId.prefix "power"
    let primaryType = _prefixId.prefix "primaryType"
    let processType = _prefixId.prefix "processType"
    let public_ = _prefixId.prefix "public"
    let railDepartment = _prefixId.prefix "railDepartment"
    let railwaySiding = _prefixId.prefix "railwaySiding"
    let recTemp = _prefixId.prefix "recTemp"
    /// <summary>
    ///   <para>rdfs:comment : specifies the municipality for the weather forecast^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#refersToMunicipality">km4c:refersToMunicipality</a>
    /// </summary>
    let refersToMunicipality = _prefixId.prefix "refersToMunicipality"
    /// <summary>
    ///   <para>rdfs:comment : the AVM refer to a specific ride code^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#refersToRide">km4c:refersToRide</a>
    /// </summary>
    let refersToRide = _prefixId.prefix "refersToRide"
    /// <summary>
    ///   <para>rdfs:comment : every XX minutes a sensor sends a report^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#relatedToSensor">km4c:relatedToSensor</a>
    /// </summary>
    let relatedToSensor = _prefixId.prefix "relatedToSensor"
    let restrictionType = _prefixId.prefix "restrictionType"
    let restrictionValue = _prefixId.prefix "restrictionValue"
    /// <summary>
    ///   <para>rdfs:comment : stato della corsa: anticipo, ritardo, in orario^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#rideState">km4c:rideState</a>
    /// </summary>
    let rideState = _prefixId.prefix "rideState"
    let roadName = _prefixId.prefix "roadName"
    let roadType = _prefixId.prefix "roadType"
    let routeCode = _prefixId.prefix "routeCode"
    let routeLength = _prefixId.prefix "routeLength"
    let routePosition = _prefixId.prefix "routePosition"
    /// <summary>
    ///   <para>rdfs:comment : a ride can be scheduled on a single line^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#scheduledOnLine">km4c:scheduledOnLine</a>
    /// </summary>
    let scheduledOnLine = _prefixId.prefix "scheduledOnLine"
    let snow = _prefixId.prefix "snow"
    let speedLimit = _prefixId.prefix "speedLimit"
    let speedPercentile = _prefixId.prefix "speedPercentile"
    /// <summary>
    ///   <para>rdfs:comment : a railway element is delimited by two junctions^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#startAtJunction">km4c:startAtJunction</a>
    /// </summary>
    let startAtJunction = _prefixId.prefix "startAtJunction"
    /// <summary>
    ///   <para>rdfs:comment : a road linnk is delimited by two junctions^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#startingJunction">km4c:startingJunction</a>
    /// </summary>
    let startingJunction = _prefixId.prefix "startingJunction"
    /// <summary>
    ///   <para>rdfs:comment : a road element is delimited by 2 nodes^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#startsAtNode">km4c:startsAtNode</a>
    /// </summary>
    let startsAtNode = _prefixId.prefix "startsAtNode"
    /// <summary>
    ///   <para>rdfs:comment : a route section is delimited by two consecutive bus stops^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#startsAtStop">km4c:startsAtStop</a>
    /// </summary>
    let startsAtStop = _prefixId.prefix "startsAtStop"
    let state = _prefixId.prefix "state"
    let stopNumber = _prefixId.prefix "stopNumber"
    let sunHeight = _prefixId.prefix "sunHeight"
    let sunrise = _prefixId.prefix "sunrise"
    let sunset = _prefixId.prefix "sunset"
    let supply = _prefixId.prefix "supply"
    let text = _prefixId.prefix "text"
    let thresholdPerc = _prefixId.prefix "thresholdPerc"
    let time = _prefixId.prefix "time"
    /// <summary>
    ///   <para>rdfs:comment : ANCHE SE VERRA' INSERITO IL COLLEGAMENTO CON INSTANT, QUESTO ATTRIBUTO NON VA CANCELLATO^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#timestamp">km4c:timestamp</a>
    /// </summary>
    let timestamp = _prefixId.prefix "timestamp"
    let trackType = _prefixId.prefix "trackType"
    let trafficDir = _prefixId.prefix "trafficDir"
    let type_ = _prefixId.prefix "type"
    let typeLabel = _prefixId.prefix "typeLabel"
    let typeOfResale = _prefixId.prefix "typeOfResale"
    let underpass = _prefixId.prefix "underpass"
    /// <summary>
    ///   <para>rdfs:comment : the generation time of a new weather report^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#updateTime">km4c:updateTime</a>
    /// </summary>
    let updateTime = _prefixId.prefix "updateTime"
    let uuid = _prefixId.prefix "uuid"
    let uv = _prefixId.prefix "uv"
    let validityStatus = _prefixId.prefix "validityStatus"
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:comment : numero di riconoscimento mezzo per azineda TPL^^xsd:string</para>
    ///   <a href="http://www.disit.org/km4city/schema#vehicle">km4c:vehicle</a>
    /// </summary>
    let vehicle = _prefixId.prefix "vehicle"
    let vehicleFlow = _prefixId.prefix "vehicleFlow"
    let width = _prefixId.prefix "width"
    let wind = _prefixId.prefix "wind"
    let yardType = _prefixId.prefix "yardType"
    let year = _prefixId.prefix "year"
