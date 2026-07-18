namespace http.www.disit.org.km4city.schema.hash

open DoxAletheia.Rdf_Vocabulary

module km4c =
    let _namespace_name = "http://www.disit.org/km4city/schema#"
    /// <summary>
    /// Corsa programmata da una certa azienda TPL su un certo percorso di una certa linea
    /// <see href="http://www.disit.org/km4city/schema#AVMRecord"></see></summary>
    let AVMRecord = Namespaced_IRI.parse _namespace_name "AVMRecord" |> NamespacedName
    /// <summary>
    /// Percorso che percorre un mezzo di trasporto pubblico
    /// <see href="http://www.disit.org/km4city/schema#Route"></see></summary>
    let Route = Namespaced_IRI.parse _namespace_name "Route" |> NamespacedName
    /// <summary>
    /// rides and AVMrecords refer to a specific route
    /// <see href="http://www.disit.org/km4city/schema#onRoute"></see></summary>
    let onRoute = Namespaced_IRI.parse _namespace_name "onRoute" |> NamespacedName

    /// <summary>
    /// Alberghi e strutture simili
    /// <see href="http://www.disit.org/km4city/schema#Accommodation"></see></summary>
    let Accommodation =
        Namespaced_IRI.parse _namespace_name "Accommodation" |> NamespacedName

    /// <summary>
    /// attivita' commerciali, servizi al cittadino, uffici...che possono essere localizzati in un punto
    /// <see href="http://www.disit.org/km4city/schema#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Accommodation_or_office_containers_rental"></see>
    /// </summary>
    let Accommodation_or_office_containers_rental =
        Namespaced_IRI.parse _namespace_name "Accommodation_or_office_containers_rental" |> NamespacedName

    /// <summary>
    /// Fornitura di utenze e servizi
    /// <see href="http://www.disit.org/km4city/schema#UtilitiesAndSupply"></see></summary>
    let UtilitiesAndSupply =
        Namespaced_IRI.parse _namespace_name "UtilitiesAndSupply" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Accountants"></see>
    /// </summary>
    let Accountants =
        Namespaced_IRI.parse _namespace_name "Accountants" |> NamespacedName

    /// <summary>
    /// banche, istituti monetari e altri servizi finanziari
    /// <see href="http://www.disit.org/km4city/schema#FinancialService"></see></summary>
    let FinancialService =
        Namespaced_IRI.parse _namespace_name "FinancialService" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Addiction_recovery_centre"></see>
    /// </summary>
    let Addiction_recovery_centre =
        Namespaced_IRI.parse _namespace_name "Addiction_recovery_centre" |> NamespacedName

    /// <summary>
    /// ospedali, studi medici, laboratori analisi e altre strutture che forniscono servizi sanitari
    /// <see href="http://www.disit.org/km4city/schema#HealthCare"></see></summary>
    let HealthCare = Namespaced_IRI.parse _namespace_name "HealthCare" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono le estese amministrative definite nel grafo stradale
    /// <see href="http://www.disit.org/km4city/schema#AdministrativeRoad"></see></summary>
    let AdministrativeRoad =
        Namespaced_IRI.parse _namespace_name "AdministrativeRoad" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono gli elementi che compongono le strade
    /// <see href="http://www.disit.org/km4city/schema#RoadElement"></see></summary>
    let RoadElement =
        Namespaced_IRI.parse _namespace_name "RoadElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Adult_clothing"></see>
    /// </summary>
    let Adult_clothing =
        Namespaced_IRI.parse _namespace_name "Adult_clothing" |> NamespacedName

    /// <summary>
    /// negozi, centri commerciali, spacci, ogni forma di attivita' di vendita al pubblico
    /// <see href="http://www.disit.org/km4city/schema#ShoppingAndService"></see></summary>
    let ShoppingAndService =
        Namespaced_IRI.parse _namespace_name "ShoppingAndService" |> NamespacedName

    /// <summary>
    /// Servizi legati al mondo della pubblicita'
    /// <see href="http://www.disit.org/km4city/schema#Advertising"></see></summary>
    let Advertising =
        Namespaced_IRI.parse _namespace_name "Advertising" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Advertising_and_promotion"></see>
    /// </summary>
    let Advertising_and_promotion =
        Namespaced_IRI.parse _namespace_name "Advertising_and_promotion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Agents"></see>
    /// </summary>
    let Agents = Namespaced_IRI.parse _namespace_name "Agents" |> NamespacedName

    /// <summary>
    /// Attivita' e servizi relativi ad agricoltura ed allevamento
    /// <see href="http://www.disit.org/km4city/schema#AgricultureAndLivestock"></see></summary>
    let AgricultureAndLivestock =
        Namespaced_IRI.parse _namespace_name "AgricultureAndLivestock" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Agritourism"></see>
    /// </summary>
    let Agritourism =
        Namespaced_IRI.parse _namespace_name "Agritourism" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Airfields"></see>
    /// </summary>
    let Airfields = Namespaced_IRI.parse _namespace_name "Airfields" |> NamespacedName

    /// <summary>
    /// Parcheggi auto, stazioni ferroviarie o degli autobus, tutto cio' che deve essere localizzato su una mappa e fa riferimento al trasporto
    /// <see href="http://www.disit.org/km4city/schema#TransferServiceAndRenting"></see></summary>
    let TransferServiceAndRenting =
        Namespaced_IRI.parse _namespace_name "TransferServiceAndRenting" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Airplanes_rental"></see>
    /// </summary>
    let Airplanes_rental =
        Namespaced_IRI.parse _namespace_name "Airplanes_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Airport_lost_property_office"></see>
    /// </summary>
    let Airport_lost_property_office =
        Namespaced_IRI.parse _namespace_name "Airport_lost_property_office" |> NamespacedName

    /// <summary>
    /// Uffici aperti al pubblico
    /// <see href="http://www.disit.org/km4city/schema#GovernmentOffice"></see></summary>
    let GovernmentOffice =
        Namespaced_IRI.parse _namespace_name "GovernmentOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Amusement_activities"></see>
    /// </summary>
    let Amusement_activities =
        Namespaced_IRI.parse _namespace_name "Amusement_activities" |> NamespacedName

    /// <summary>
    /// Servizi per l'intrattenimento del cittadino
    /// <see href="http://www.disit.org/km4city/schema#Entertainment"></see></summary>
    let Entertainment =
        Namespaced_IRI.parse _namespace_name "Entertainment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Amusement_and_theme_parks"></see>
    /// </summary>
    let Amusement_and_theme_parks =
        Namespaced_IRI.parse _namespace_name "Amusement_and_theme_parks" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Animal_feeds_manufacture"></see>
    /// </summary>
    let Animal_feeds_manufacture =
        Namespaced_IRI.parse _namespace_name "Animal_feeds_manufacture" |> NamespacedName

    /// <summary>
    /// Servizi legati all'industria e al lavoro
    /// <see href="http://www.disit.org/km4city/schema#IndustryAndManufacturing"></see></summary>
    let IndustryAndManufacturing =
        Namespaced_IRI.parse _namespace_name "IndustryAndManufacturing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Animal_production"></see>
    /// </summary>
    let Animal_production =
        Namespaced_IRI.parse _namespace_name "Animal_production" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Antiques"></see>
    /// </summary>
    let Antiques = Namespaced_IRI.parse _namespace_name "Antiques" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Aquarium"></see>
    /// </summary>
    let Aquarium = Namespaced_IRI.parse _namespace_name "Aquarium" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Archaeological_site"></see>
    /// </summary>
    let Archaeological_site =
        Namespaced_IRI.parse _namespace_name "Archaeological_site" |> NamespacedName

    /// <summary>
    /// biblioteche, archivi, musei ed altre attivita' culturali
    /// <see href="http://www.disit.org/km4city/schema#CulturalActivity"></see></summary>
    let CulturalActivity =
        Namespaced_IRI.parse _namespace_name "CulturalActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Architectural_consulting"></see>
    /// </summary>
    let Architectural_consulting =
        Namespaced_IRI.parse _namespace_name "Architectural_consulting" |> NamespacedName

    /// <summary>
    /// Servizi legati all'ingegneria civile ed edile
    /// <see href="http://www.disit.org/km4city/schema#CivilAndEdilEngineering"></see></summary>
    let CivilAndEdilEngineering =
        Namespaced_IRI.parse _namespace_name "CivilAndEdilEngineering" |> NamespacedName

    /// <summary>
    /// Servizi rappresentati da un'area di forma poligonale
    /// <see href="http://www.disit.org/km4city/schema#Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Art_galleries"></see>
    /// </summary>
    let Art_galleries =
        Namespaced_IRI.parse _namespace_name "Art_galleries" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Artisan_shop"></see>
    /// </summary>
    let Artisan_shop =
        Namespaced_IRI.parse _namespace_name "Artisan_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Associations"></see>
    /// </summary>
    let Associations =
        Namespaced_IRI.parse _namespace_name "Associations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Atm"></see>
    /// </summary>
    let Atm = Namespaced_IRI.parse _namespace_name "Atm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Auctioning_houses"></see>
    /// </summary>
    let Auctioning_houses =
        Namespaced_IRI.parse _namespace_name "Auctioning_houses" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Audio_and_video"></see>
    /// </summary>
    let Audio_and_video =
        Namespaced_IRI.parse _namespace_name "Audio_and_video" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Auditing_activities"></see>
    /// </summary>
    let Auditing_activities =
        Namespaced_IRI.parse _namespace_name "Auditing_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Auditorium"></see>
    /// </summary>
    let Auditorium = Namespaced_IRI.parse _namespace_name "Auditorium" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Automobile_driving_and_flying_schools"></see>
    /// </summary>
    let Automobile_driving_and_flying_schools =
        Namespaced_IRI.parse _namespace_name "Automobile_driving_and_flying_schools" |> NamespacedName

    /// <summary>
    /// Servizi quali scuole per ogni eta' e scuole di formazione
    /// <see href="http://www.disit.org/km4city/schema#EducationAndResearch"></see></summary>
    let EducationAndResearch =
        Namespaced_IRI.parse _namespace_name "EducationAndResearch" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bakery"></see>
    /// </summary>
    let Bakery = Namespaced_IRI.parse _namespace_name "Bakery" |> NamespacedName

    /// <summary>
    /// Ristoranti, enoteche e tutte le altre attivita' enogastronomiche
    /// <see href="http://www.disit.org/km4city/schema#WineAndFood"></see></summary>
    let WineAndFood =
        Namespaced_IRI.parse _namespace_name "WineAndFood" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bank"></see>
    /// </summary>
    let Bank = Namespaced_IRI.parse _namespace_name "Bank" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bar"></see>
    /// </summary>
    let Bar = Namespaced_IRI.parse _namespace_name "Bar" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Beach_resort"></see>
    /// </summary>
    let Beach_resort =
        Namespaced_IRI.parse _namespace_name "Beach_resort" |> NamespacedName

    /// <summary>
    /// Servizio associato ai Beacon che permettono di ricevere offerte
    /// Singolo beacon installato
    /// <see href="http://www.disit.org/km4city/schema#Beacon"></see></summary>
    let Beacon = Namespaced_IRI.parse _namespace_name "Beacon" |> NamespacedName

    /// <summary>
    /// attivita' dei servizi delle agenzie di viaggio, tour operator e servizi prenotazione
    /// <see href="http://www.disit.org/km4city/schema#TourismService"></see></summary>
    let TourismService =
        Namespaced_IRI.parse _namespace_name "TourismService" |> NamespacedName

    /// <summary>
    /// lettura proveniente da un singolo beacon
    /// <see href="http://www.disit.org/km4city/schema#BeaconObservation"></see></summary>
    let BeaconObservation =
        Namespaced_IRI.parse _namespace_name "BeaconObservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Beauty_centre"></see>
    /// </summary>
    let Beauty_centre =
        Namespaced_IRI.parse _namespace_name "Beauty_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bed_and_breakfast"></see>
    /// </summary>
    let Bed_and_breakfast =
        Namespaced_IRI.parse _namespace_name "Bed_and_breakfast" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Betting_shops"></see>
    /// </summary>
    let Betting_shops =
        Namespaced_IRI.parse _namespace_name "Betting_shops" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Beverage_manufacture"></see>
    /// </summary>
    let Beverage_manufacture =
        Namespaced_IRI.parse _namespace_name "Beverage_manufacture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bike_rack"></see>
    /// </summary>
    let Bike_rack = Namespaced_IRI.parse _namespace_name "Bike_rack" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bike_rental"></see>
    /// </summary>
    let Bike_rental =
        Namespaced_IRI.parse _namespace_name "Bike_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Boarding_house"></see>
    /// </summary>
    let Boarding_house =
        Namespaced_IRI.parse _namespace_name "Boarding_house" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Boat_equipment"></see>
    /// </summary>
    let Boat_equipment =
        Namespaced_IRI.parse _namespace_name "Boat_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Boats_and_ships_rental"></see>
    /// </summary>
    let Boats_and_ships_rental =
        Namespaced_IRI.parse _namespace_name "Boats_and_ships_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bookshop"></see>
    /// </summary>
    let Bookshop = Namespaced_IRI.parse _namespace_name "Bookshop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Botanical_and_zoological_gardens"></see>
    /// </summary>
    let Botanical_and_zoological_gardens =
        Namespaced_IRI.parse _namespace_name "Botanical_and_zoological_gardens" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Boxoffice"></see>
    /// </summary>
    let Boxoffice = Namespaced_IRI.parse _namespace_name "Boxoffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Building_and_industrial_cleaning_activities"></see>
    /// </summary>
    let Building_and_industrial_cleaning_activities =
        Namespaced_IRI.parse _namespace_name "Building_and_industrial_cleaning_activities" |> NamespacedName

    /// <summary>
    /// Servizi legati all'ambiente
    /// <see href="http://www.disit.org/km4city/schema#Environment"></see></summary>
    let Environment =
        Namespaced_IRI.parse _namespace_name "Environment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Building_construction"></see>
    /// </summary>
    let Building_construction =
        Namespaced_IRI.parse _namespace_name "Building_construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Building_material"></see>
    /// </summary>
    let Building_material =
        Namespaced_IRI.parse _namespace_name "Building_material" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Building_materials_manufacture"></see>
    /// </summary>
    let Building_materials_manufacture =
        Namespaced_IRI.parse _namespace_name "Building_materials_manufacture" |> NamespacedName

    /// <summary>
    /// Punto di interconnessione tra segmenti di strada per determinare il percorso di una linea di TPL
    /// Servizio associato alla visualizzazione delle linee ATAF con le relative fermate
    /// <see href="http://www.disit.org/km4city/schema#BusStop"></see></summary>
    let BusStop = Namespaced_IRI.parse _namespace_name "BusStop" |> NamespacedName

    /// <summary>
    /// previsione di arrivo ad una certa fermata
    /// <see href="http://www.disit.org/km4city/schema#BusStopForecast"></see></summary>
    let BusStopForecast =
        Namespaced_IRI.parse _namespace_name "BusStopForecast" |> NamespacedName

    /// <summary>
    /// each forecast refers to a specific bus stop
    /// <see href="http://www.disit.org/km4city/schema#atBusStop"></see></summary>
    let atBusStop = Namespaced_IRI.parse _namespace_name "atBusStop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bus_tickets_retail"></see>
    /// </summary>
    let Bus_tickets_retail =
        Namespaced_IRI.parse _namespace_name "Bus_tickets_retail" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Business_support"></see>
    /// </summary>
    let Business_support =
        Namespaced_IRI.parse _namespace_name "Business_support" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Call_center"></see>
    /// </summary>
    let Call_center =
        Namespaced_IRI.parse _namespace_name "Call_center" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Camper_service"></see>
    /// </summary>
    let Camper_service =
        Namespaced_IRI.parse _namespace_name "Camper_service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Camping"></see>
    /// </summary>
    let Camping = Namespaced_IRI.parse _namespace_name "Camping" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Canteens_and_food_service"></see>
    /// </summary>
    let Canteens_and_food_service =
        Namespaced_IRI.parse _namespace_name "Canteens_and_food_service" |> NamespacedName

    /// <summary>
    /// Sensore che raccoglie i dati all'interno di un parcheggio
    /// <see href="http://www.disit.org/km4city/schema#CarParkSensor"></see></summary>
    let CarParkSensor =
        Namespaced_IRI.parse _namespace_name "CarParkSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Car_park"></see>
    /// </summary>
    let Car_park = Namespaced_IRI.parse _namespace_name "Car_park" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Car_rental_with_driver"></see>
    /// </summary>
    let Car_rental_with_driver =
        Namespaced_IRI.parse _namespace_name "Car_rental_with_driver" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Car_washing"></see>
    /// </summary>
    let Car_washing =
        Namespaced_IRI.parse _namespace_name "Car_washing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Carabinieri"></see>
    /// </summary>
    let Carabinieri =
        Namespaced_IRI.parse _namespace_name "Carabinieri" |> NamespacedName

    /// <summary>
    /// Contiene tutte le classi relative ai servizi di emergenza
    /// <see href="http://www.disit.org/km4city/schema#Emergency"></see></summary>
    let Emergency = Namespaced_IRI.parse _namespace_name "Emergency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cargo_handling"></see>
    /// </summary>
    let Cargo_handling =
        Namespaced_IRI.parse _namespace_name "Cargo_handling" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Carpentry"></see>
    /// </summary>
    let Carpentry = Namespaced_IRI.parse _namespace_name "Carpentry" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Carpets"></see>
    /// </summary>
    let Carpets = Namespaced_IRI.parse _namespace_name "Carpets" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Carpets_and_curtains"></see>
    /// </summary>
    let Carpets_and_curtains =
        Namespaced_IRI.parse _namespace_name "Carpets_and_curtains" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cartographers"></see>
    /// </summary>
    let Cartographers =
        Namespaced_IRI.parse _namespace_name "Cartographers" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Catering"></see>
    /// </summary>
    let Catering = Namespaced_IRI.parse _namespace_name "Catering" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Charging_stations"></see>
    /// </summary>
    let Charging_stations =
        Namespaced_IRI.parse _namespace_name "Charging_stations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Charter_airlines"></see>
    /// </summary>
    let Charter_airlines =
        Namespaced_IRI.parse _namespace_name "Charter_airlines" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Churches"></see>
    /// </summary>
    let Churches = Namespaced_IRI.parse _namespace_name "Churches" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cinema"></see>
    /// </summary>
    let Cinema = Namespaced_IRI.parse _namespace_name "Cinema" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Civil_airport"></see>
    /// </summary>
    let Civil_airport =
        Namespaced_IRI.parse _namespace_name "Civil_airport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Civil_engineering"></see>
    /// </summary>
    let Civil_engineering =
        Namespaced_IRI.parse _namespace_name "Civil_engineering" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Civil_protection"></see>
    /// </summary>
    let Civil_protection =
        Namespaced_IRI.parse _namespace_name "Civil_protection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Civil_registry"></see>
    /// </summary>
    let Civil_registry =
        Namespaced_IRI.parse _namespace_name "Civil_registry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cleaning_activities"></see>
    /// </summary>
    let Cleaning_activities =
        Namespaced_IRI.parse _namespace_name "Cleaning_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cleaning_materials"></see>
    /// </summary>
    let Cleaning_materials =
        Namespaced_IRI.parse _namespace_name "Cleaning_materials" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Climbing"></see>
    /// </summary>
    let Climbing = Namespaced_IRI.parse _namespace_name "Climbing" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing"></see>
    /// </summary>
    let Clothing = Namespaced_IRI.parse _namespace_name "Clothing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing_accessories"></see>
    /// </summary>
    let Clothing_accessories =
        Namespaced_IRI.parse _namespace_name "Clothing_accessories" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing_and_linen"></see>
    /// </summary>
    let Clothing_and_linen =
        Namespaced_IRI.parse _namespace_name "Clothing_and_linen" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing_children_and_infants"></see>
    /// </summary>
    let Clothing_children_and_infants =
        Namespaced_IRI.parse _namespace_name "Clothing_children_and_infants" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing_factory_outlet"></see>
    /// </summary>
    let Clothing_factory_outlet =
        Namespaced_IRI.parse _namespace_name "Clothing_factory_outlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Coast_guard_harbormaster"></see>
    /// </summary>
    let Coast_guard_harbormaster =
        Namespaced_IRI.parse _namespace_name "Coast_guard_harbormaster" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Coffee_rosters"></see>
    /// </summary>
    let Coffee_rosters =
        Namespaced_IRI.parse _namespace_name "Coffee_rosters" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Coke_and_petroleum_derivatives"></see>
    /// </summary>
    let Coke_and_petroleum_derivatives =
        Namespaced_IRI.parse _namespace_name "Coke_and_petroleum_derivatives" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Combined_facilities_support_activities"></see>
    /// </summary>
    let Combined_facilities_support_activities =
        Namespaced_IRI.parse _namespace_name "Combined_facilities_support_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Commissariat_of_public_safety"></see>
    /// </summary>
    let Commissariat_of_public_safety =
        Namespaced_IRI.parse _namespace_name "Commissariat_of_public_safety" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Community_centre"></see>
    /// </summary>
    let Community_centre =
        Namespaced_IRI.parse _namespace_name "Community_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Computer_data_processing"></see>
    /// </summary>
    let Computer_data_processing =
        Namespaced_IRI.parse _namespace_name "Computer_data_processing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Computer_programming_and_consultancy"></see>
    /// </summary>
    let Computer_programming_and_consultancy =
        Namespaced_IRI.parse _namespace_name "Computer_programming_and_consultancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Computer_systems"></see>
    /// </summary>
    let Computer_systems =
        Namespaced_IRI.parse _namespace_name "Computer_systems" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Computer_technician"></see>
    /// </summary>
    let Computer_technician =
        Namespaced_IRI.parse _namespace_name "Computer_technician" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Conservatory"></see>
    /// </summary>
    let Conservatory =
        Namespaced_IRI.parse _namespace_name "Conservatory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Consulate"></see>
    /// </summary>
    let Consulate = Namespaced_IRI.parse _namespace_name "Consulate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Consulting_services"></see>
    /// </summary>
    let Consulting_services =
        Namespaced_IRI.parse _namespace_name "Consulting_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Controlled_parking_zone"></see>
    /// </summary>
    let Controlled_parking_zone =
        Namespaced_IRI.parse _namespace_name "Controlled_parking_zone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Corps_of_forest_rangers"></see>
    /// </summary>
    let Corps_of_forest_rangers =
        Namespaced_IRI.parse _namespace_name "Corps_of_forest_rangers" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Courier"></see>
    /// </summary>
    let Courier = Namespaced_IRI.parse _namespace_name "Courier" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Credit_collection_agencies"></see>
    /// </summary>
    let Credit_collection_agencies =
        Namespaced_IRI.parse _namespace_name "Credit_collection_agencies" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Crop_animal_production_hunting"></see>
    /// </summary>
    let Crop_animal_production_hunting =
        Namespaced_IRI.parse _namespace_name "Crop_animal_production_hunting" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Crop_production"></see>
    /// </summary>
    let Crop_production =
        Namespaced_IRI.parse _namespace_name "Crop_production" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cultural_and_recreation_goods"></see>
    /// </summary>
    let Cultural_and_recreation_goods =
        Namespaced_IRI.parse _namespace_name "Cultural_and_recreation_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cultural_centre"></see>
    /// </summary>
    let Cultural_centre =
        Namespaced_IRI.parse _namespace_name "Cultural_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cultural_education"></see>
    /// </summary>
    let Cultural_education =
        Namespaced_IRI.parse _namespace_name "Cultural_education" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cultural_sites"></see>
    /// </summary>
    let Cultural_sites =
        Namespaced_IRI.parse _namespace_name "Cultural_sites" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Curtains_and_net_curtains"></see>
    /// </summary>
    let Curtains_and_net_curtains =
        Namespaced_IRI.parse _namespace_name "Curtains_and_net_curtains" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cycle_paths"></see>
    /// </summary>
    let Cycle_paths =
        Namespaced_IRI.parse _namespace_name "Cycle_paths" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dairy_products"></see>
    /// </summary>
    let Dairy_products =
        Namespaced_IRI.parse _namespace_name "Dairy_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dance_schools"></see>
    /// </summary>
    let Dance_schools =
        Namespaced_IRI.parse _namespace_name "Dance_schools" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dating_service"></see>
    /// </summary>
    let Dating_service =
        Namespaced_IRI.parse _namespace_name "Dating_service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Day_care_centre"></see>
    /// </summary>
    let Day_care_centre =
        Namespaced_IRI.parse _namespace_name "Day_care_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dentist"></see>
    /// </summary>
    let Dentist = Namespaced_IRI.parse _namespace_name "Dentist" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Department_of_motor_vehicles"></see>
    /// </summary>
    let Department_of_motor_vehicles =
        Namespaced_IRI.parse _namespace_name "Department_of_motor_vehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Diet_products"></see>
    /// </summary>
    let Diet_products =
        Namespaced_IRI.parse _namespace_name "Diet_products" |> NamespacedName

    /// <summary>
    /// Servizi classificati dal comune di Firenze come Digital Location
    /// <see href="http://www.disit.org/km4city/schema#DigitalLocation"></see></summary>
    let DigitalLocation =
        Namespaced_IRI.parse _namespace_name "DigitalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dining_hall"></see>
    /// </summary>
    let Dining_hall =
        Namespaced_IRI.parse _namespace_name "Dining_hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Discotheque"></see>
    /// </summary>
    let Discotheque =
        Namespaced_IRI.parse _namespace_name "Discotheque" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Discount"></see>
    /// </summary>
    let Discount = Namespaced_IRI.parse _namespace_name "Discount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Disinfecting_and_exterminating_activities"></see>
    /// </summary>
    let Disinfecting_and_exterminating_activities =
        Namespaced_IRI.parse _namespace_name "Disinfecting_and_exterminating_activities" |> NamespacedName

    /// <summary>
    /// Zona che rappresenta l'estensione di un quartiere
    /// <see href="http://www.disit.org/km4city/schema#District"></see></summary>
    let District = Namespaced_IRI.parse _namespace_name "District" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Diving_school"></see>
    /// </summary>
    let Diving_school =
        Namespaced_IRI.parse _namespace_name "Diving_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Doctor_office"></see>
    /// </summary>
    let Doctor_office =
        Namespaced_IRI.parse _namespace_name "Doctor_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Door_to_door"></see>
    /// </summary>
    let Door_to_door =
        Namespaced_IRI.parse _namespace_name "Door_to_door" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Drinking_fountain"></see>
    /// </summary>
    let Drinking_fountain =
        Namespaced_IRI.parse _namespace_name "Drinking_fountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Educational_support_activities"></see>
    /// </summary>
    let Educational_support_activities =
        Namespaced_IRI.parse _namespace_name "Educational_support_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Emergency_medical_care"></see>
    /// </summary>
    let Emergency_medical_care =
        Namespaced_IRI.parse _namespace_name "Emergency_medical_care" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Emergency_services"></see>
    /// </summary>
    let Emergency_services =
        Namespaced_IRI.parse _namespace_name "Emergency_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Employment_exchange"></see>
    /// </summary>
    let Employment_exchange =
        Namespaced_IRI.parse _namespace_name "Employment_exchange" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Energy_supply"></see>
    /// </summary>
    let Energy_supply =
        Namespaced_IRI.parse _namespace_name "Energy_supply" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Engineering_consulting"></see>
    /// </summary>
    let Engineering_consulting =
        Namespaced_IRI.parse _namespace_name "Engineering_consulting" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono i possibili ingressi ai numeri civici
    /// <see href="http://www.disit.org/km4city/schema#Entry"></see></summary>
    let Entry = Namespaced_IRI.parse _namespace_name "Entry" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono i numeri civici conosciuti
    /// <see href="http://www.disit.org/km4city/schema#StreetNumber"></see></summary>
    let StreetNumber =
        Namespaced_IRI.parse _namespace_name "StreetNumber" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono le regole di accesso ai differenti elementi stradali
    /// <see href="http://www.disit.org/km4city/schema#EntryRule"></see></summary>
    let EntryRule = Namespaced_IRI.parse _namespace_name "EntryRule" |> NamespacedName

    /// <summary>
    /// an entry rule refers to a specific Road element
    /// <see href="http://www.disit.org/km4city/schema#accessToElement"></see></summary>
    let accessToElement =
        Namespaced_IRI.parse _namespace_name "accessToElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Equipment_for_events_and_shows_rental"></see>
    /// </summary>
    let Equipment_for_events_and_shows_rental =
        Namespaced_IRI.parse _namespace_name "Equipment_for_events_and_shows_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Estate_activities"></see>
    /// </summary>
    let Estate_activities =
        Namespaced_IRI.parse _namespace_name "Estate_activities" |> NamespacedName

    /// <summary>
    /// Eventi programmati dal comune di firenze e dintormi
    /// <see href="http://www.disit.org/km4city/schema#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Extraction_of_natural_gas"></see>
    /// </summary>
    let Extraction_of_natural_gas =
        Namespaced_IRI.parse _namespace_name "Extraction_of_natural_gas" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Extraction_of_salt"></see>
    /// </summary>
    let Extraction_of_salt =
        Namespaced_IRI.parse _namespace_name "Extraction_of_salt" |> NamespacedName

    /// <summary>
    /// Servizi legati alle attivita' di estrazione e cave
    /// <see href="http://www.disit.org/km4city/schema#MiningAndQuarrying"></see></summary>
    let MiningAndQuarrying =
        Namespaced_IRI.parse _namespace_name "MiningAndQuarrying" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Family_counselling"></see>
    /// </summary>
    let Family_counselling =
        Namespaced_IRI.parse _namespace_name "Family_counselling" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Farm_house"></see>
    /// </summary>
    let Farm_house = Namespaced_IRI.parse _namespace_name "Farm_house" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Financial_institute"></see>
    /// </summary>
    let Financial_institute =
        Namespaced_IRI.parse _namespace_name "Financial_institute" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fine_arts_articles"></see>
    /// </summary>
    let Fine_arts_articles =
        Namespaced_IRI.parse _namespace_name "Fine_arts_articles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fire_brigade"></see>
    /// </summary>
    let Fire_brigade =
        Namespaced_IRI.parse _namespace_name "Fire_brigade" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#First_aid"></see>
    /// </summary>
    let First_aid = Namespaced_IRI.parse _namespace_name "First_aid" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fish_and_seafood"></see>
    /// </summary>
    let Fish_and_seafood =
        Namespaced_IRI.parse _namespace_name "Fish_and_seafood" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fishing_and_aquaculture"></see>
    /// </summary>
    let Fishing_and_aquaculture =
        Namespaced_IRI.parse _namespace_name "Fishing_and_aquaculture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fishing_reserve"></see>
    /// </summary>
    let Fishing_reserve =
        Namespaced_IRI.parse _namespace_name "Fishing_reserve" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Flight_companies"></see>
    /// </summary>
    let Flight_companies =
        Namespaced_IRI.parse _namespace_name "Flight_companies" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Flower_shop"></see>
    /// </summary>
    let Flower_shop =
        Namespaced_IRI.parse _namespace_name "Flower_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Food_and_ice_cream_truck"></see>
    /// </summary>
    let Food_and_ice_cream_truck =
        Namespaced_IRI.parse _namespace_name "Food_and_ice_cream_truck" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Food_and_tobacconist"></see>
    /// </summary>
    let Food_and_tobacconist =
        Namespaced_IRI.parse _namespace_name "Food_and_tobacconist" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Food_manufacture"></see>
    /// </summary>
    let Food_manufacture =
        Namespaced_IRI.parse _namespace_name "Food_manufacture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Food_trade"></see>
    /// </summary>
    let Food_trade = Namespaced_IRI.parse _namespace_name "Food_trade" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Footwear_and_accessories"></see>
    /// </summary>
    let Footwear_and_accessories =
        Namespaced_IRI.parse _namespace_name "Footwear_and_accessories" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Footwear_and_leather_goods"></see>
    /// </summary>
    let Footwear_and_leather_goods =
        Namespaced_IRI.parse _namespace_name "Footwear_and_leather_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Footwear_factory_outlet"></see>
    /// </summary>
    let Footwear_factory_outlet =
        Namespaced_IRI.parse _namespace_name "Footwear_factory_outlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Footwear_manufacture"></see>
    /// </summary>
    let Footwear_manufacture =
        Namespaced_IRI.parse _namespace_name "Footwear_manufacture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Forestry"></see>
    /// </summary>
    let Forestry = Namespaced_IRI.parse _namespace_name "Forestry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Freight_transport_and_furniture_removal"></see>
    /// </summary>
    let Freight_transport_and_furniture_removal =
        Namespaced_IRI.parse _namespace_name "Freight_transport_and_furniture_removal" |> NamespacedName

    /// <summary>
    /// Luoghi in cui e' possibile sedere all'aria condizionata durante l'estate
    /// <see href="http://www.disit.org/km4city/schema#Fresh_place"></see></summary>
    let Fresh_place =
        Namespaced_IRI.parse _namespace_name "Fresh_place" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Frozen_food"></see>
    /// </summary>
    let Frozen_food =
        Namespaced_IRI.parse _namespace_name "Frozen_food" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fruit_and_vegetables"></see>
    /// </summary>
    let Fruit_and_vegetables =
        Namespaced_IRI.parse _namespace_name "Fruit_and_vegetables" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fuel_station"></see>
    /// </summary>
    let Fuel_station =
        Namespaced_IRI.parse _namespace_name "Fuel_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Funeral"></see>
    /// </summary>
    let Funeral = Namespaced_IRI.parse _namespace_name "Funeral" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Funeral_and_cemetery_articles"></see>
    /// </summary>
    let Funeral_and_cemetery_articles =
        Namespaced_IRI.parse _namespace_name "Funeral_and_cemetery_articles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fur_and_leather_clothing"></see>
    /// </summary>
    let Fur_and_leather_clothing =
        Namespaced_IRI.parse _namespace_name "Fur_and_leather_clothing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Gambling_and_betting"></see>
    /// </summary>
    let Gambling_and_betting =
        Namespaced_IRI.parse _namespace_name "Gambling_and_betting" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Game_reserve"></see>
    /// </summary>
    let Game_reserve =
        Namespaced_IRI.parse _namespace_name "Game_reserve" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Game_room"></see>
    /// </summary>
    let Game_room = Namespaced_IRI.parse _namespace_name "Game_room" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Games_and_toys"></see>
    /// </summary>
    let Games_and_toys =
        Namespaced_IRI.parse _namespace_name "Games_and_toys" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Garden_and_agriculture"></see>
    /// </summary>
    let Garden_and_agriculture =
        Namespaced_IRI.parse _namespace_name "Garden_and_agriculture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Gardens"></see>
    /// </summary>
    let Gardens = Namespaced_IRI.parse _namespace_name "Gardens" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Geologists"></see>
    /// </summary>
    let Geologists = Namespaced_IRI.parse _namespace_name "Geologists" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Gifts_and_smoking_articles"></see>
    /// </summary>
    let Gifts_and_smoking_articles =
        Namespaced_IRI.parse _namespace_name "Gifts_and_smoking_articles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Golf"></see>
    /// </summary>
    let Golf = Namespaced_IRI.parse _namespace_name "Golf" |> NamespacedName
    /// <summary>
    /// Scalo Merci, sono posizionati in corrispondenza di giunzioni ferroviarie con relazione 1:1
    /// <see href="http://www.disit.org/km4city/schema#GoodsYard"></see></summary>
    let GoodsYard = Namespaced_IRI.parse _namespace_name "GoodsYard" |> NamespacedName

    /// <summary>
    /// 2 giunzioni delimitano un elemento ferroviario e rappresentano stazioni ferroviarie o scali merce
    /// <see href="http://www.disit.org/km4city/schema#RailwayJunction"></see></summary>
    let RailwayJunction =
        Namespaced_IRI.parse _namespace_name "RailwayJunction" |> NamespacedName

    /// <summary>
    /// train station and good yard are located precisely on a junction
    /// <see href="http://www.disit.org/km4city/schema#correspondToJunction"></see></summary>
    let correspondToJunction =
        Namespaced_IRI.parse _namespace_name "correspondToJunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Green_areas"></see>
    /// </summary>
    let Green_areas =
        Namespaced_IRI.parse _namespace_name "Green_areas" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Grill"></see>
    /// </summary>
    let Grill = Namespaced_IRI.parse _namespace_name "Grill" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Group_practice"></see>
    /// </summary>
    let Group_practice =
        Namespaced_IRI.parse _namespace_name "Group_practice" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Gym_fitness"></see>
    /// </summary>
    let Gym_fitness =
        Namespaced_IRI.parse _namespace_name "Gym_fitness" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Haberdashery"></see>
    /// </summary>
    let Haberdashery =
        Namespaced_IRI.parse _namespace_name "Haberdashery" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Haircare_centres"></see>
    /// </summary>
    let Haircare_centres =
        Namespaced_IRI.parse _namespace_name "Haircare_centres" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hairdressing"></see>
    /// </summary>
    let Hairdressing =
        Namespaced_IRI.parse _namespace_name "Hairdressing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hairdressing_and_beauty_treatment"></see>
    /// </summary>
    let Hairdressing_and_beauty_treatment =
        Namespaced_IRI.parse _namespace_name "Hairdressing_and_beauty_treatment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hardware_electrical_plumbing_and_heating"></see>
    /// </summary>
    let Hardware_electrical_plumbing_and_heating =
        Namespaced_IRI.parse _namespace_name "Hardware_electrical_plumbing_and_heating" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hardware_paints_and_glass"></see>
    /// </summary>
    let Hardware_paints_and_glass =
        Namespaced_IRI.parse _namespace_name "Hardware_paints_and_glass" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Health_district"></see>
    /// </summary>
    let Health_district =
        Namespaced_IRI.parse _namespace_name "Health_district" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Health_reservations_centre"></see>
    /// </summary>
    let Health_reservations_centre =
        Namespaced_IRI.parse _namespace_name "Health_reservations_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Healthcare_centre"></see>
    /// </summary>
    let Healthcare_centre =
        Namespaced_IRI.parse _namespace_name "Healthcare_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Helipads"></see>
    /// </summary>
    let Helipads = Namespaced_IRI.parse _namespace_name "Helipads" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Herbalists_shop"></see>
    /// </summary>
    let Herbalists_shop =
        Namespaced_IRI.parse _namespace_name "Herbalists_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Higher_education"></see>
    /// </summary>
    let Higher_education =
        Namespaced_IRI.parse _namespace_name "Higher_education" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Highway_stop"></see>
    /// </summary>
    let Highway_stop =
        Namespaced_IRI.parse _namespace_name "Highway_stop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hippodrome"></see>
    /// </summary>
    let Hippodrome = Namespaced_IRI.parse _namespace_name "Hippodrome" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Historic_residence"></see>
    /// </summary>
    let Historic_residence =
        Namespaced_IRI.parse _namespace_name "Historic_residence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Historical_buildings"></see>
    /// </summary>
    let Historical_buildings =
        Namespaced_IRI.parse _namespace_name "Historical_buildings" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Holiday_village"></see>
    /// </summary>
    let Holiday_village =
        Namespaced_IRI.parse _namespace_name "Holiday_village" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hostel"></see>
    /// </summary>
    let Hostel = Namespaced_IRI.parse _namespace_name "Hostel" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hotel"></see>
    /// </summary>
    let Hotel = Namespaced_IRI.parse _namespace_name "Hotel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_appliances_shop"></see>
    /// </summary>
    let Household_appliances_shop =
        Namespaced_IRI.parse _namespace_name "Household_appliances_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_articles"></see>
    /// </summary>
    let Household_articles =
        Namespaced_IRI.parse _namespace_name "Household_articles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_fuel"></see>
    /// </summary>
    let Household_fuel =
        Namespaced_IRI.parse _namespace_name "Household_fuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_furniture"></see>
    /// </summary>
    let Household_furniture =
        Namespaced_IRI.parse _namespace_name "Household_furniture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_products"></see>
    /// </summary>
    let Household_products =
        Namespaced_IRI.parse _namespace_name "Household_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_utensils"></see>
    /// </summary>
    let Household_utensils =
        Namespaced_IRI.parse _namespace_name "Household_utensils" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Human_health_activities"></see>
    /// </summary>
    let Human_health_activities =
        Namespaced_IRI.parse _namespace_name "Human_health_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hunting_trapping_and_services"></see>
    /// </summary>
    let Hunting_trapping_and_services =
        Namespaced_IRI.parse _namespace_name "Hunting_trapping_and_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hypermarket"></see>
    /// </summary>
    let Hypermarket =
        Namespaced_IRI.parse _namespace_name "Hypermarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#ICT_service"></see>
    /// </summary>
    let ICT_service =
        Namespaced_IRI.parse _namespace_name "ICT_service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Ice_cream_parlour"></see>
    /// </summary>
    let Ice_cream_parlour =
        Namespaced_IRI.parse _namespace_name "Ice_cream_parlour" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Income_revenue_authority"></see>
    /// </summary>
    let Income_revenue_authority =
        Namespaced_IRI.parse _namespace_name "Income_revenue_authority" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Industrial_laundries"></see>
    /// </summary>
    let Industrial_laundries =
        Namespaced_IRI.parse _namespace_name "Industrial_laundries" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Installation_of_industrial_machinery"></see>
    /// </summary>
    let Installation_of_industrial_machinery =
        Namespaced_IRI.parse _namespace_name "Installation_of_industrial_machinery" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Insurance"></see>
    /// </summary>
    let Insurance = Namespaced_IRI.parse _namespace_name "Insurance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Insurance_and_financial"></see>
    /// </summary>
    let Insurance_and_financial =
        Namespaced_IRI.parse _namespace_name "Insurance_and_financial" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Internet_point_and_public_telephone"></see>
    /// </summary>
    let Internet_point_and_public_telephone =
        Namespaced_IRI.parse _namespace_name "Internet_point_and_public_telephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Internet_service_provider"></see>
    /// </summary>
    let Internet_service_provider =
        Namespaced_IRI.parse _namespace_name "Internet_service_provider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Investigation_activities"></see>
    /// </summary>
    let Investigation_activities =
        Namespaced_IRI.parse _namespace_name "Investigation_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Italian_finance_police"></see>
    /// </summary>
    let Italian_finance_police =
        Namespaced_IRI.parse _namespace_name "Italian_finance_police" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Jeweller"></see>
    /// </summary>
    let Jeweller = Namespaced_IRI.parse _namespace_name "Jeweller" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Jewellery"></see>
    /// </summary>
    let Jewellery = Namespaced_IRI.parse _namespace_name "Jewellery" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Journalist"></see>
    /// </summary>
    let Journalist = Namespaced_IRI.parse _namespace_name "Journalist" |> NamespacedName
    /// <summary>
    /// Punto di interconnessione tra segmenti di strada per disegnare un RoadElement
    /// <see href="http://www.disit.org/km4city/schema#Junction"></see></summary>
    let Junction = Namespaced_IRI.parse _namespace_name "Junction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Knitted_manufacture"></see>
    /// </summary>
    let Knitted_manufacture =
        Namespaced_IRI.parse _namespace_name "Knitted_manufacture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Labour_consultant"></see>
    /// </summary>
    let Labour_consultant =
        Namespaced_IRI.parse _namespace_name "Labour_consultant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Land_transport"></see>
    /// </summary>
    let Land_transport =
        Namespaced_IRI.parse _namespace_name "Land_transport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Land_transport_rental"></see>
    /// </summary>
    let Land_transport_rental =
        Namespaced_IRI.parse _namespace_name "Land_transport_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Landscape_care"></see>
    /// </summary>
    let Landscape_care =
        Namespaced_IRI.parse _namespace_name "Landscape_care" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Language_courses"></see>
    /// </summary>
    let Language_courses =
        Namespaced_IRI.parse _namespace_name "Language_courses" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Laundries_and_dry_cleaners"></see>
    /// </summary>
    let Laundries_and_dry_cleaners =
        Namespaced_IRI.parse _namespace_name "Laundries_and_dry_cleaners" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Leasing_of_intellectual_property"></see>
    /// </summary>
    let Leasing_of_intellectual_property =
        Namespaced_IRI.parse _namespace_name "Leasing_of_intellectual_property" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Leather_manufacture"></see>
    /// </summary>
    let Leather_manufacture =
        Namespaced_IRI.parse _namespace_name "Leather_manufacture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Legal_office"></see>
    /// </summary>
    let Legal_office =
        Namespaced_IRI.parse _namespace_name "Legal_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Library"></see>
    /// </summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Lifting_and_handling_equipment_rental"></see>
    /// </summary>
    let Lifting_and_handling_equipment_rental =
        Namespaced_IRI.parse _namespace_name "Lifting_and_handling_equipment_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Lighting"></see>
    /// </summary>
    let Lighting = Namespaced_IRI.parse _namespace_name "Lighting" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Literary_cafe"></see>
    /// </summary>
    let Literary_cafe =
        Namespaced_IRI.parse _namespace_name "Literary_cafe" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Local_health_authority"></see>
    /// </summary>
    let Local_health_authority =
        Namespaced_IRI.parse _namespace_name "Local_health_authority" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Local_police"></see>
    /// </summary>
    let Local_police =
        Namespaced_IRI.parse _namespace_name "Local_police" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Logistics_activities"></see>
    /// </summary>
    let Logistics_activities =
        Namespaced_IRI.parse _namespace_name "Logistics_activities" |> NamespacedName

    /// <summary>
    /// Insieme di linee TPL, individuabili a livello regionale come lotto
    /// <see href="http://www.disit.org/km4city/schema#Lot"></see></summary>
    let Lot = Namespaced_IRI.parse _namespace_name "Lot" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Machinery_and_equipment_rental"></see>
    /// </summary>
    let Machinery_and_equipment_rental =
        Namespaced_IRI.parse _namespace_name "Machinery_and_equipment_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Machinery_repair_and_installation"></see>
    /// </summary>
    let Machinery_repair_and_installation =
        Namespaced_IRI.parse _namespace_name "Machinery_repair_and_installation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Maintenance_repair_of_motor_vehicles"></see>
    /// </summary>
    let Maintenance_repair_of_motor_vehicles =
        Namespaced_IRI.parse _namespace_name "Maintenance_repair_of_motor_vehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Maintenance_repair_of_motorcycles"></see>
    /// </summary>
    let Maintenance_repair_of_motorcycles =
        Namespaced_IRI.parse _namespace_name "Maintenance_repair_of_motorcycles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Management_consultancy"></see>
    /// </summary>
    let Management_consultancy =
        Namespaced_IRI.parse _namespace_name "Management_consultancy" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono le possibili manovre che possono essere effettuate su un elemento stradale
    /// <see href="http://www.disit.org/km4city/schema#Maneuver"></see></summary>
    let Maneuver = Namespaced_IRI.parse _namespace_name "Maneuver" |> NamespacedName

    /// <summary>
    /// the second element concerned the maneuver
    /// <see href="http://www.disit.org/km4city/schema#hasSecondElem"></see></summary>
    let hasSecondElem =
        Namespaced_IRI.parse _namespace_name "hasSecondElem" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono i nodi che congiungono gli elementi stradali
    /// <see href="http://www.disit.org/km4city/schema#Node"></see></summary>
    let Node = Namespaced_IRI.parse _namespace_name "Node" |> NamespacedName

    /// <summary>
    /// a maneuver takes place in correspondence of a node
    /// <see href="http://www.disit.org/km4city/schema#concerningNode"></see></summary>
    let concerningNode =
        Namespaced_IRI.parse _namespace_name "concerningNode" |> NamespacedName

    /// <summary>
    /// the third element concerned the maneuver
    /// <see href="http://www.disit.org/km4city/schema#hasThirdElem"></see></summary>
    let hasThirdElem =
        Namespaced_IRI.parse _namespace_name "hasThirdElem" |> NamespacedName

    /// <summary>
    /// the first element concerned the maneuver
    /// <see href="http://www.disit.org/km4city/schema#hasFirstElem"></see></summary>
    let hasFirstElem =
        Namespaced_IRI.parse _namespace_name "hasFirstElem" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manicure_and_pedicure"></see>
    /// </summary>
    let Manicure_and_pedicure =
        Namespaced_IRI.parse _namespace_name "Manicure_and_pedicure" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_basic_metals"></see>
    /// </summary>
    let Manufacture_of_basic_metals =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_basic_metals" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_chemicals_products"></see>
    /// </summary>
    let Manufacture_of_chemicals_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_chemicals_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_clay_and_ceramic"></see>
    /// </summary>
    let Manufacture_of_clay_and_ceramic =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_clay_and_ceramic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_electrical_equipment"></see>
    /// </summary>
    let Manufacture_of_electrical_equipment =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_electrical_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_electronic_products"></see>
    /// </summary>
    let Manufacture_of_electronic_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_electronic_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_furniture"></see>
    /// </summary>
    let Manufacture_of_furniture =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_furniture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_glass"></see>
    /// </summary>
    let Manufacture_of_glass =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_glass" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_jewellery_bijouterie"></see>
    /// </summary>
    let Manufacture_of_jewellery_bijouterie =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_jewellery_bijouterie" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_machinery_and_equipment"></see>
    /// </summary>
    let Manufacture_of_machinery_and_equipment =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_machinery_and_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_motor_vehicles"></see>
    /// </summary>
    let Manufacture_of_motor_vehicles =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_motor_vehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_musical_instruments"></see>
    /// </summary>
    let Manufacture_of_musical_instruments =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_musical_instruments" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_non_metallic_mineral_products"></see>
    /// </summary>
    let Manufacture_of_non_metallic_mineral_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_non_metallic_mineral_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_paper"></see>
    /// </summary>
    let Manufacture_of_paper =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_paper" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_paper_products"></see>
    /// </summary>
    let Manufacture_of_paper_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_paper_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_pharmaceutical_products"></see>
    /// </summary>
    let Manufacture_of_pharmaceutical_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_pharmaceutical_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_plastics_products"></see>
    /// </summary>
    let Manufacture_of_plastics_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_plastics_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_refined_petroleum_products"></see>
    /// </summary>
    let Manufacture_of_refined_petroleum_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_refined_petroleum_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_refractory_products"></see>
    /// </summary>
    let Manufacture_of_refractory_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_refractory_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_rubber_and_plastics_products"></see>
    /// </summary>
    let Manufacture_of_rubber_and_plastics_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_rubber_and_plastics_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_rubber_products"></see>
    /// </summary>
    let Manufacture_of_rubber_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_rubber_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_sports_goods"></see>
    /// </summary>
    let Manufacture_of_sports_goods =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_sports_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_structural_metal_products"></see>
    /// </summary>
    let Manufacture_of_structural_metal_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_structural_metal_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_textiles"></see>
    /// </summary>
    let Manufacture_of_textiles =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_textiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_toys_and_game"></see>
    /// </summary>
    let Manufacture_of_toys_and_game =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_toys_and_game" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_transport_equipment"></see>
    /// </summary>
    let Manufacture_of_transport_equipment =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_transport_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_travel_articles"></see>
    /// </summary>
    let Manufacture_of_travel_articles =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_travel_articles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_wearing_apparel"></see>
    /// </summary>
    let Manufacture_of_wearing_apparel =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_wearing_apparel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_wood"></see>
    /// </summary>
    let Manufacture_of_wood =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_wood" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_wood_products"></see>
    /// </summary>
    let Manufacture_of_wood_products =
        Namespaced_IRI.parse _namespace_name "Manufacture_of_wood_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Market_polling"></see>
    /// </summary>
    let Market_polling =
        Namespaced_IRI.parse _namespace_name "Market_polling" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Materials_recovery"></see>
    /// </summary>
    let Materials_recovery =
        Namespaced_IRI.parse _namespace_name "Materials_recovery" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Meat_and_poultry"></see>
    /// </summary>
    let Meat_and_poultry =
        Namespaced_IRI.parse _namespace_name "Meat_and_poultry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mechanic_workshop"></see>
    /// </summary>
    let Mechanic_workshop =
        Namespaced_IRI.parse _namespace_name "Mechanic_workshop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Medical_analysis_laboratories"></see>
    /// </summary>
    let Medical_analysis_laboratories =
        Namespaced_IRI.parse _namespace_name "Medical_analysis_laboratories" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Medical_and_orthopaedic_goods"></see>
    /// </summary>
    let Medical_and_orthopaedic_goods =
        Namespaced_IRI.parse _namespace_name "Medical_and_orthopaedic_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mental_health_centre"></see>
    /// </summary>
    let Mental_health_centre =
        Namespaced_IRI.parse _namespace_name "Mental_health_centre" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono i cippi chilometrici che si trovano lungo le principali strade
    /// <see href="http://www.disit.org/km4city/schema#Milestone"></see></summary>
    let Milestone = Namespaced_IRI.parse _namespace_name "Milestone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Minimarket"></see>
    /// </summary>
    let Minimarket = Namespaced_IRI.parse _namespace_name "Minimarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mining_of_metal_ores"></see>
    /// </summary>
    let Mining_of_metal_ores =
        Namespaced_IRI.parse _namespace_name "Mining_of_metal_ores" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mining_support_services"></see>
    /// </summary>
    let Mining_support_services =
        Namespaced_IRI.parse _namespace_name "Mining_support_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Monument_location"></see>
    /// </summary>
    let Monument_location =
        Namespaced_IRI.parse _namespace_name "Monument_location" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Motion_picture_and_television_programme_activities"></see>
    /// </summary>
    let Motion_picture_and_television_programme_activities =
        Namespaced_IRI.parse _namespace_name "Motion_picture_and_television_programme_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Motor_Vehicles_wholesale_and_retail"></see>
    /// </summary>
    let Motor_Vehicles_wholesale_and_retail =
        Namespaced_IRI.parse _namespace_name "Motor_Vehicles_wholesale_and_retail" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Motorcycles_parts_wholesale_and_retail"></see>
    /// </summary>
    let Motorcycles_parts_wholesale_and_retail =
        Namespaced_IRI.parse _namespace_name "Motorcycles_parts_wholesale_and_retail" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Motorcycles_wholesale_and_retail"></see>
    /// </summary>
    let Motorcycles_wholesale_and_retail =
        Namespaced_IRI.parse _namespace_name "Motorcycles_wholesale_and_retail" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mountain_shelter"></see>
    /// </summary>
    let Mountain_shelter =
        Namespaced_IRI.parse _namespace_name "Mountain_shelter" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono i vari comuni
    /// <see href="http://www.disit.org/km4city/schema#Municipality"></see></summary>
    let Municipality =
        Namespaced_IRI.parse _namespace_name "Municipality" |> NamespacedName

    /// <summary>
    /// Comuni, regioni e provincie
    /// <see href="http://www.disit.org/km4city/schema#Pa"></see></summary>
    let Pa = Namespaced_IRI.parse _namespace_name "Pa" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Museum"></see>
    /// </summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Music_and_video_recordings"></see>
    /// </summary>
    let Music_and_video_recordings =
        Namespaced_IRI.parse _namespace_name "Music_and_video_recordings" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Musical_instruments_and_scores"></see>
    /// </summary>
    let Musical_instruments_and_scores =
        Namespaced_IRI.parse _namespace_name "Musical_instruments_and_scores" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#News_agency"></see>
    /// </summary>
    let News_agency =
        Namespaced_IRI.parse _namespace_name "News_agency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Newspapers_and_stationery"></see>
    /// </summary>
    let Newspapers_and_stationery =
        Namespaced_IRI.parse _namespace_name "Newspapers_and_stationery" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Non_food_large_retailers"></see>
    /// </summary>
    let Non_food_large_retailers =
        Namespaced_IRI.parse _namespace_name "Non_food_large_retailers" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Non_food_products"></see>
    /// </summary>
    let Non_food_products =
        Namespaced_IRI.parse _namespace_name "Non_food_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Non_specialized_wholesale_trade"></see>
    /// </summary>
    let Non_specialized_wholesale_trade =
        Namespaced_IRI.parse _namespace_name "Non_specialized_wholesale_trade" |> NamespacedName

    /// <summary>
    /// Vendita all'ingrosso di qualsiasi cosa
    /// <see href="http://www.disit.org/km4city/schema#Wholesale"></see></summary>
    let Wholesale = Namespaced_IRI.parse _namespace_name "Wholesale" |> NamespacedName

    /// <summary>
    /// Singolo sensore per osservare velocita', traffico, concentrazione o densita'
    /// <see href="http://www.disit.org/km4city/schema#Observation"></see></summary>
    let Observation =
        Namespaced_IRI.parse _namespace_name "Observation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Office_Furniture"></see>
    /// </summary>
    let Office_Furniture =
        Namespaced_IRI.parse _namespace_name "Office_Furniture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Office_administrative_and_support_activities"></see>
    /// </summary>
    let Office_administrative_and_support_activities =
        Namespaced_IRI.parse _namespace_name "Office_administrative_and_support_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Operation_of_casinos"></see>
    /// </summary>
    let Operation_of_casinos =
        Namespaced_IRI.parse _namespace_name "Operation_of_casinos" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Optics_and_photography"></see>
    /// </summary>
    let Optics_and_photography =
        Namespaced_IRI.parse _namespace_name "Optics_and_photography" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Organization_of_conventions_and_trade_shows"></see>
    /// </summary>
    let Organization_of_conventions_and_trade_shows =
        Namespaced_IRI.parse _namespace_name "Organization_of_conventions_and_trade_shows" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_accommodation"></see>
    /// </summary>
    let Other_accommodation =
        Namespaced_IRI.parse _namespace_name "Other_accommodation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_broadcasting"></see>
    /// </summary>
    let Other_broadcasting =
        Namespaced_IRI.parse _namespace_name "Other_broadcasting" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_goods"></see>
    /// </summary>
    let Other_goods =
        Namespaced_IRI.parse _namespace_name "Other_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_manufacturing"></see>
    /// </summary>
    let Other_manufacturing =
        Namespaced_IRI.parse _namespace_name "Other_manufacturing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_mining_and_quarrying"></see>
    /// </summary>
    let Other_mining_and_quarrying =
        Namespaced_IRI.parse _namespace_name "Other_mining_and_quarrying" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_office"></see>
    /// </summary>
    let Other_office =
        Namespaced_IRI.parse _namespace_name "Other_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_retail_sale"></see>
    /// </summary>
    let Other_retail_sale =
        Namespaced_IRI.parse _namespace_name "Other_retail_sale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_specialized_construction"></see>
    /// </summary>
    let Other_specialized_construction =
        Namespaced_IRI.parse _namespace_name "Other_specialized_construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_specialized_wholesale"></see>
    /// </summary>
    let Other_specialized_wholesale =
        Namespaced_IRI.parse _namespace_name "Other_specialized_wholesale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_telecommunications_activities"></see>
    /// </summary>
    let Other_telecommunications_activities =
        Namespaced_IRI.parse _namespace_name "Other_telecommunications_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Packaging_activities"></see>
    /// </summary>
    let Packaging_activities =
        Namespaced_IRI.parse _namespace_name "Packaging_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Paramedical_activities"></see>
    /// </summary>
    let Paramedical_activities =
        Namespaced_IRI.parse _namespace_name "Paramedical_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Parties_and_ceremonies"></see>
    /// </summary>
    let Parties_and_ceremonies =
        Namespaced_IRI.parse _namespace_name "Parties_and_ceremonies" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Passenger_air_transport"></see>
    /// </summary>
    let Passenger_air_transport =
        Namespaced_IRI.parse _namespace_name "Passenger_air_transport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pastry_shop"></see>
    /// </summary>
    let Pastry_shop =
        Namespaced_IRI.parse _namespace_name "Pastry_shop" |> NamespacedName

    /// <summary>
    /// Servizi rappresentati da una spezzata
    /// <see href="http://www.disit.org/km4city/schema#Path"></see></summary>
    let Path = Namespaced_IRI.parse _namespace_name "Path" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pedestrian_zone"></see>
    /// </summary>
    let Pedestrian_zone =
        Namespaced_IRI.parse _namespace_name "Pedestrian_zone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Performing_arts_schools"></see>
    /// </summary>
    let Performing_arts_schools =
        Namespaced_IRI.parse _namespace_name "Performing_arts_schools" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Perfumery_and_cosmetic_articles"></see>
    /// </summary>
    let Perfumery_and_cosmetic_articles =
        Namespaced_IRI.parse _namespace_name "Perfumery_and_cosmetic_articles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Personal_and_household_goods_rental"></see>
    /// </summary>
    let Personal_and_household_goods_rental =
        Namespaced_IRI.parse _namespace_name "Personal_and_household_goods_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Personal_service_activities"></see>
    /// </summary>
    let Personal_service_activities =
        Namespaced_IRI.parse _namespace_name "Personal_service_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pet_care_services"></see>
    /// </summary>
    let Pet_care_services =
        Namespaced_IRI.parse _namespace_name "Pet_care_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pet_shop"></see>
    /// </summary>
    let Pet_shop = Namespaced_IRI.parse _namespace_name "Pet_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Petroleum_and_natural_gas_extraction"></see>
    /// </summary>
    let Petroleum_and_natural_gas_extraction =
        Namespaced_IRI.parse _namespace_name "Petroleum_and_natural_gas_extraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pharmaceuticals"></see>
    /// </summary>
    let Pharmaceuticals =
        Namespaced_IRI.parse _namespace_name "Pharmaceuticals" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pharmacy"></see>
    /// </summary>
    let Pharmacy = Namespaced_IRI.parse _namespace_name "Pharmacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Photographic_activities"></see>
    /// </summary>
    let Photographic_activities =
        Namespaced_IRI.parse _namespace_name "Photographic_activities" |> NamespacedName

    /// <summary>
    /// geolocalizzazione degli impianti fotovoltaici funzionanti
    /// <see href="http://www.disit.org/km4city/schema#Photovoltaic_system"></see></summary>
    let Photovoltaic_system =
        Namespaced_IRI.parse _namespace_name "Photovoltaic_system" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Physical_therapy_centre"></see>
    /// </summary>
    let Physical_therapy_centre =
        Namespaced_IRI.parse _namespace_name "Physical_therapy_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pizzeria"></see>
    /// </summary>
    let Pizzeria = Namespaced_IRI.parse _namespace_name "Pizzeria" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Poison_control_centre"></see>
    /// </summary>
    let Poison_control_centre =
        Namespaced_IRI.parse _namespace_name "Poison_control_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Police_headquarters"></see>
    /// </summary>
    let Police_headquarters =
        Namespaced_IRI.parse _namespace_name "Police_headquarters" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pool"></see>
    /// </summary>
    let Pool = Namespaced_IRI.parse _namespace_name "Pool" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Post_secondary_education"></see>
    /// </summary>
    let Post_secondary_education =
        Namespaced_IRI.parse _namespace_name "Post_secondary_education" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Postal_and_courier_activities"></see>
    /// </summary>
    let Postal_and_courier_activities =
        Namespaced_IRI.parse _namespace_name "Postal_and_courier_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Postal_office"></see>
    /// </summary>
    let Postal_office =
        Namespaced_IRI.parse _namespace_name "Postal_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pre_primary_education"></see>
    /// </summary>
    let Pre_primary_education =
        Namespaced_IRI.parse _namespace_name "Pre_primary_education" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Prefecture"></see>
    /// </summary>
    let Prefecture = Namespaced_IRI.parse _namespace_name "Prefecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Primary_education"></see>
    /// </summary>
    let Primary_education =
        Namespaced_IRI.parse _namespace_name "Primary_education" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Printing_and_recorded_media"></see>
    /// </summary>
    let Printing_and_recorded_media =
        Namespaced_IRI.parse _namespace_name "Printing_and_recorded_media" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Printing_and_services"></see>
    /// </summary>
    let Printing_and_services =
        Namespaced_IRI.parse _namespace_name "Printing_and_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_clinic"></see>
    /// </summary>
    let Private_clinic =
        Namespaced_IRI.parse _namespace_name "Private_clinic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_high_school"></see>
    /// </summary>
    let Private_high_school =
        Namespaced_IRI.parse _namespace_name "Private_high_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_infant_school"></see>
    /// </summary>
    let Private_infant_school =
        Namespaced_IRI.parse _namespace_name "Private_infant_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_junior_high_school"></see>
    /// </summary>
    let Private_junior_high_school =
        Namespaced_IRI.parse _namespace_name "Private_junior_high_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_junior_school"></see>
    /// </summary>
    let Private_junior_school =
        Namespaced_IRI.parse _namespace_name "Private_junior_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_polytechnic_school"></see>
    /// </summary>
    let Private_polytechnic_school =
        Namespaced_IRI.parse _namespace_name "Private_polytechnic_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_preschool"></see>
    /// </summary>
    let Private_preschool =
        Namespaced_IRI.parse _namespace_name "Private_preschool" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_professional_institute"></see>
    /// </summary>
    let Private_professional_institute =
        Namespaced_IRI.parse _namespace_name "Private_professional_institute" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_security"></see>
    /// </summary>
    let Private_security =
        Namespaced_IRI.parse _namespace_name "Private_security" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono le varie provincie
    /// <see href="http://www.disit.org/km4city/schema#Province"></see></summary>
    let Province = Namespaced_IRI.parse _namespace_name "Province" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Psychologists"></see>
    /// </summary>
    let Psychologists =
        Namespaced_IRI.parse _namespace_name "Psychologists" |> NamespacedName

    /// <summary>
    /// Servizio associato alla visualizzazione delle linee ATAF con le relative fermate
    /// Linea di una certa azienda TPL
    /// <see href="http://www.disit.org/km4city/schema#PublicTransportLine"></see></summary>
    let PublicTransportLine =
        Namespaced_IRI.parse _namespace_name "PublicTransportLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_high_school"></see>
    /// </summary>
    let Public_high_school =
        Namespaced_IRI.parse _namespace_name "Public_high_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_hospital"></see>
    /// </summary>
    let Public_hospital =
        Namespaced_IRI.parse _namespace_name "Public_hospital" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_infant_school"></see>
    /// </summary>
    let Public_infant_school =
        Namespaced_IRI.parse _namespace_name "Public_infant_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_junior_high_school"></see>
    /// </summary>
    let Public_junior_high_school =
        Namespaced_IRI.parse _namespace_name "Public_junior_high_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_junior_school"></see>
    /// </summary>
    let Public_junior_school =
        Namespaced_IRI.parse _namespace_name "Public_junior_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_polytechnic_school"></see>
    /// </summary>
    let Public_polytechnic_school =
        Namespaced_IRI.parse _namespace_name "Public_polytechnic_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_professional_institute"></see>
    /// </summary>
    let Public_professional_institute =
        Namespaced_IRI.parse _namespace_name "Public_professional_institute" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_university"></see>
    /// </summary>
    let Public_university =
        Namespaced_IRI.parse _namespace_name "Public_university" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Publishing_activities"></see>
    /// </summary>
    let Publishing_activities =
        Namespaced_IRI.parse _namespace_name "Publishing_activities" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Quality_control_and_certification"></see>
    /// </summary>
    let Quality_control_and_certification =
        Namespaced_IRI.parse _namespace_name "Quality_control_and_certification" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Quarrying_of_stone_sand_and_clay"></see>
    /// </summary>
    let Quarrying_of_stone_sand_and_clay =
        Namespaced_IRI.parse _namespace_name "Quarrying_of_stone_sand_and_clay" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#RTZgate"></see>
    /// </summary>
    let RTZgate = Namespaced_IRI.parse _namespace_name "RTZgate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Radio_broadcasting"></see>
    /// </summary>
    let Radio_broadcasting =
        Namespaced_IRI.parse _namespace_name "Radio_broadcasting" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Rafting_kayak"></see>
    /// </summary>
    let Rafting_kayak =
        Namespaced_IRI.parse _namespace_name "Rafting_kayak" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono le direttive ferroviarie
    /// <see href="http://www.disit.org/km4city/schema#RailwayDirection"></see></summary>
    let RailwayDirection =
        Namespaced_IRI.parse _namespace_name "RailwayDirection" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono gli elementi che compongono le tratte, le sezioni o le linee ferroviarie
    /// <see href="http://www.disit.org/km4city/schema#RailwayElement"></see></summary>
    let RailwayElement =
        Namespaced_IRI.parse _namespace_name "RailwayElement" |> NamespacedName

    /// <summary>
    /// a railway Direction is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#consistOfElement"></see></summary>
    let consistOfElement =
        Namespaced_IRI.parse _namespace_name "consistOfElement" |> NamespacedName

    /// <summary>
    /// a railway element is delimited by two junctions
    /// <see href="http://www.disit.org/km4city/schema#endAtJunction"></see></summary>
    let endAtJunction =
        Namespaced_IRI.parse _namespace_name "endAtJunction" |> NamespacedName

    /// <summary>
    /// a railway element is delimited by two junctions
    /// <see href="http://www.disit.org/km4city/schema#startAtJunction"></see></summary>
    let startAtJunction =
        Namespaced_IRI.parse _namespace_name "startAtJunction" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono le sezioni ferroviarie
    /// <see href="http://www.disit.org/km4city/schema#RailwaySection"></see></summary>
    let RailwaySection =
        Namespaced_IRI.parse _namespace_name "RailwaySection" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono le linee ferroviarie
    /// <see href="http://www.disit.org/km4city/schema#RailwayLine"></see></summary>
    let RailwayLine =
        Namespaced_IRI.parse _namespace_name "RailwayLine" |> NamespacedName

    /// <summary>
    /// a railway line is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#hasElement"></see></summary>
    let hasElement = Namespaced_IRI.parse _namespace_name "hasElement" |> NamespacedName

    /// <summary>
    /// a railway Section is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#isComposedByElement"></see></summary>
    let isComposedByElement =
        Namespaced_IRI.parse _namespace_name "isComposedByElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Recreation_room"></see>
    /// </summary>
    let Recreation_room =
        Namespaced_IRI.parse _namespace_name "Recreation_room" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Recreational_and_sports_goods_rental"></see>
    /// </summary>
    let Recreational_and_sports_goods_rental =
        Namespaced_IRI.parse _namespace_name "Recreational_and_sports_goods_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Recruitment"></see>
    /// </summary>
    let Recruitment =
        Namespaced_IRI.parse _namespace_name "Recruitment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Red_cross"></see>
    /// </summary>
    let Red_cross = Namespaced_IRI.parse _namespace_name "Red_cross" |> NamespacedName
    /// <summary>
    /// Classe le cui istanze sono le varie regioni
    /// <see href="http://www.disit.org/km4city/schema#Region"></see></summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    /// servizi che possono avere altre caratteristiche, rappresentate come servizi trasversali
    /// <see href="http://www.disit.org/km4city/schema#RegularService"></see></summary>
    let RegularService =
        Namespaced_IRI.parse _namespace_name "RegularService" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Religiuos_guest_house"></see>
    /// </summary>
    let Religiuos_guest_house =
        Namespaced_IRI.parse _namespace_name "Religiuos_guest_house" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair"></see>
    /// </summary>
    let Repair = Namespaced_IRI.parse _namespace_name "Repair" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_musical_instruments"></see>
    /// </summary>
    let Repair_musical_instruments =
        Namespaced_IRI.parse _namespace_name "Repair_musical_instruments" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_communication_equipment"></see>
    /// </summary>
    let Repair_of_communication_equipment =
        Namespaced_IRI.parse _namespace_name "Repair_of_communication_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_consumer_electronics"></see>
    /// </summary>
    let Repair_of_consumer_electronics =
        Namespaced_IRI.parse _namespace_name "Repair_of_consumer_electronics" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_footwear_and_leather_goods"></see>
    /// </summary>
    let Repair_of_footwear_and_leather_goods =
        Namespaced_IRI.parse _namespace_name "Repair_of_footwear_and_leather_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_garden_equipment"></see>
    /// </summary>
    let Repair_of_garden_equipment =
        Namespaced_IRI.parse _namespace_name "Repair_of_garden_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_home_equipment"></see>
    /// </summary>
    let Repair_of_home_equipment =
        Namespaced_IRI.parse _namespace_name "Repair_of_home_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_household_appliances"></see>
    /// </summary>
    let Repair_of_household_appliances =
        Namespaced_IRI.parse _namespace_name "Repair_of_household_appliances" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_sporting_goods"></see>
    /// </summary>
    let Repair_of_sporting_goods =
        Namespaced_IRI.parse _namespace_name "Repair_of_sporting_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Reporting_agencies"></see>
    /// </summary>
    let Reporting_agencies =
        Namespaced_IRI.parse _namespace_name "Reporting_agencies" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Reproduction_recorded_media"></see>
    /// </summary>
    let Reproduction_recorded_media =
        Namespaced_IRI.parse _namespace_name "Reproduction_recorded_media" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Research_and_development"></see>
    /// </summary>
    let Research_and_development =
        Namespaced_IRI.parse _namespace_name "Research_and_development" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Residential_care_activities"></see>
    /// </summary>
    let Residential_care_activities =
        Namespaced_IRI.parse _namespace_name "Residential_care_activities" |> NamespacedName

    /// <summary>
    /// Delibera approvata da una qualche Pa
    /// <see href="http://www.disit.org/km4city/schema#Resolution"></see></summary>
    let Resolution = Namespaced_IRI.parse _namespace_name "Resolution" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Rest_home"></see>
    /// </summary>
    let Rest_home = Namespaced_IRI.parse _namespace_name "Rest_home" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Restaurant"></see>
    /// </summary>
    let Restaurant = Namespaced_IRI.parse _namespace_name "Restaurant" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Restorers"></see>
    /// </summary>
    let Restorers = Namespaced_IRI.parse _namespace_name "Restorers" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Retail_motor_vehicles_parts"></see>
    /// </summary>
    let Retail_motor_vehicles_parts =
        Namespaced_IRI.parse _namespace_name "Retail_motor_vehicles_parts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Retail_sale_non_specialized_stores"></see>
    /// </summary>
    let Retail_sale_non_specialized_stores =
        Namespaced_IRI.parse _namespace_name "Retail_sale_non_specialized_stores" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Retail_trade"></see>
    /// </summary>
    let Retail_trade =
        Namespaced_IRI.parse _namespace_name "Retail_trade" |> NamespacedName

    /// <summary>
    /// Corsa programmata da una certa azienda TPL su un certo percorso di una certa linea
    /// <see href="http://www.disit.org/km4city/schema#Ride"></see></summary>
    let Ride = Namespaced_IRI.parse _namespace_name "Ride" |> NamespacedName

    /// <summary>
    /// a ride can be scheduled on a single line
    /// <see href="http://www.disit.org/km4city/schema#scheduledOnLine"></see></summary>
    let scheduledOnLine =
        Namespaced_IRI.parse _namespace_name "scheduledOnLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Riding_stables"></see>
    /// </summary>
    let Riding_stables =
        Namespaced_IRI.parse _namespace_name "Riding_stables" |> NamespacedName

    /// <summary>
    /// Classe le cui istanze sono le strade
    /// <see href="http://www.disit.org/km4city/schema#Road"></see></summary>
    let Road = Namespaced_IRI.parse _namespace_name "Road" |> NamespacedName

    /// <summary>
    /// a road element is delimited by 2 nodes
    /// <see href="http://www.disit.org/km4city/schema#startsAtNode"></see></summary>
    let startsAtNode =
        Namespaced_IRI.parse _namespace_name "startsAtNode" |> NamespacedName

    /// <summary>
    /// a road element is delimited by 2 nodes
    /// <see href="http://www.disit.org/km4city/schema#endsAtNode"></see></summary>
    let endsAtNode = Namespaced_IRI.parse _namespace_name "endsAtNode" |> NamespacedName
    /// <summary>
    /// Tratto di strada lineare delimitato da due giunzioni che compone il road element
    /// <see href="http://www.disit.org/km4city/schema#RoadLink"></see></summary>
    let RoadLink = Namespaced_IRI.parse _namespace_name "RoadLink" |> NamespacedName

    /// <summary>
    /// a road linnk is delimited by two junctions
    /// <see href="http://www.disit.org/km4city/schema#startingJunction"></see></summary>
    let startingJunction =
        Namespaced_IRI.parse _namespace_name "startingJunction" |> NamespacedName

    /// <summary>
    /// a road linnk is delimited by two junctions
    /// <see href="http://www.disit.org/km4city/schema#endingJunction"></see></summary>
    let endingJunction =
        Namespaced_IRI.parse _namespace_name "endingJunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Rope_cord_and_twine"></see>
    /// </summary>
    let Rope_cord_and_twine =
        Namespaced_IRI.parse _namespace_name "Rope_cord_and_twine" |> NamespacedName

    /// <summary>
    /// defines all the other section of a route
    /// <see href="http://www.disit.org/km4city/schema#hasSection"></see></summary>
    let hasSection = Namespaced_IRI.parse _namespace_name "hasSection" |> NamespacedName

    /// <summary>
    /// defines which is the departure stop of a route
    /// <see href="http://www.disit.org/km4city/schema#hasFirstStop"></see></summary>
    let hasFirstStop =
        Namespaced_IRI.parse _namespace_name "hasFirstStop" |> NamespacedName

    /// <summary>
    /// Tratto di strada compreso tra due successive fermate dell'autobus di una certa linea
    /// <see href="http://www.disit.org/km4city/schema#RouteSection"></see></summary>
    let RouteSection =
        Namespaced_IRI.parse _namespace_name "RouteSection" |> NamespacedName

    /// <summary>
    /// defines which is the departure section of a route
    /// <see href="http://www.disit.org/km4city/schema#hasFirstSection"></see></summary>
    let hasFirstSection =
        Namespaced_IRI.parse _namespace_name "hasFirstSection" |> NamespacedName

    /// <summary>
    /// Punto di interconnessione tra segmenti di strada per determinare il percorso di una linea di TPL
    /// <see href="http://www.disit.org/km4city/schema#RouteJunction"></see></summary>
    let RouteJunction =
        Namespaced_IRI.parse _namespace_name "RouteJunction" |> NamespacedName

    /// <summary>
    /// Tratto di strada delimitato da due TPL junction che determina il percorso di una linea TPL
    /// <see href="http://www.disit.org/km4city/schema#RouteLink"></see></summary>
    let RouteLink = Namespaced_IRI.parse _namespace_name "RouteLink" |> NamespacedName

    /// <summary>
    /// each routeLink, has a beginning and an end junction
    /// <see href="http://www.disit.org/km4city/schema#finishesAtJunction"></see></summary>
    let finishesAtJunction =
        Namespaced_IRI.parse _namespace_name "finishesAtJunction" |> NamespacedName

    /// <summary>
    /// each routeLink, has a beginning and an end junction
    /// <see href="http://www.disit.org/km4city/schema#beginsAtJunction"></see></summary>
    let beginsAtJunction =
        Namespaced_IRI.parse _namespace_name "beginsAtJunction" |> NamespacedName

    /// <summary>
    /// a route section is delimited by two consecutive bus stops
    /// <see href="http://www.disit.org/km4city/schema#startsAtStop"></see></summary>
    let startsAtStop =
        Namespaced_IRI.parse _namespace_name "startsAtStop" |> NamespacedName

    /// <summary>
    /// a route section is delimited by two consecutive bus stops
    /// <see href="http://www.disit.org/km4city/schema#endsAtStop"></see></summary>
    let endsAtStop = Namespaced_IRI.parse _namespace_name "endsAtStop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sailing_school"></see>
    /// </summary>
    let Sailing_school =
        Namespaced_IRI.parse _namespace_name "Sailing_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_motor_vehicles_parts"></see>
    /// </summary>
    let Sale_motor_vehicles_parts =
        Namespaced_IRI.parse _namespace_name "Sale_motor_vehicles_parts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_of_motor_vehicles"></see>
    /// </summary>
    let Sale_of_motor_vehicles =
        Namespaced_IRI.parse _namespace_name "Sale_of_motor_vehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_of_motor_vehicles_and_motorcycles"></see>
    /// </summary>
    let Sale_of_motor_vehicles_and_motorcycles =
        Namespaced_IRI.parse _namespace_name "Sale_of_motor_vehicles_and_motorcycles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_of_motorcycles"></see>
    /// </summary>
    let Sale_of_motorcycles =
        Namespaced_IRI.parse _namespace_name "Sale_of_motorcycles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_via_mail_order_houses_or_via_internet"></see>
    /// </summary>
    let Sale_via_mail_order_houses_or_via_internet =
        Namespaced_IRI.parse _namespace_name "Sale_via_mail_order_houses_or_via_internet" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sandwich_shop_pub"></see>
    /// </summary>
    let Sandwich_shop_pub =
        Namespaced_IRI.parse _namespace_name "Sandwich_shop_pub" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sanitary_equipment"></see>
    /// </summary>
    let Sanitary_equipment =
        Namespaced_IRI.parse _namespace_name "Sanitary_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sawmilling"></see>
    /// </summary>
    let Sawmilling = Namespaced_IRI.parse _namespace_name "Sawmilling" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Second_hand_books"></see>
    /// </summary>
    let Second_hand_books =
        Namespaced_IRI.parse _namespace_name "Second_hand_books" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Second_hand_goods"></see>
    /// </summary>
    let Second_hand_goods =
        Namespaced_IRI.parse _namespace_name "Second_hand_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Secondary_education"></see>
    /// </summary>
    let Secondary_education =
        Namespaced_IRI.parse _namespace_name "Secondary_education" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Secretarial_support_services"></see>
    /// </summary>
    let Secretarial_support_services =
        Namespaced_IRI.parse _namespace_name "Secretarial_support_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Security_systems"></see>
    /// </summary>
    let Security_systems =
        Namespaced_IRI.parse _namespace_name "Security_systems" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Security_systems_service"></see>
    /// </summary>
    let Security_systems_service =
        Namespaced_IRI.parse _namespace_name "Security_systems_service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Senior_centre"></see>
    /// </summary>
    let Senior_centre =
        Namespaced_IRI.parse _namespace_name "Senior_centre" |> NamespacedName

    /// <summary>
    /// Sensore stradale che rilascia info sul traffico
    /// Singolo sensore per osservare velocita', traffico, concentrazione o densita'
    /// <see href="http://www.disit.org/km4city/schema#SensorSite"></see></summary>
    let SensorSite = Namespaced_IRI.parse _namespace_name "SensorSite" |> NamespacedName

    /// <summary>
    /// Insieme di sensori che rappresentano un unica installazione, un unico sito
    /// <see href="http://www.disit.org/km4city/schema#SensorSiteTable"></see></summary>
    let SensorSiteTable =
        Namespaced_IRI.parse _namespace_name "SensorSiteTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sewerage"></see>
    /// </summary>
    let Sewerage = Namespaced_IRI.parse _namespace_name "Sewerage" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sexy_shop"></see>
    /// </summary>
    let Sexy_shop = Namespaced_IRI.parse _namespace_name "Sexy_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Shopping_centre"></see>
    /// </summary>
    let Shopping_centre =
        Namespaced_IRI.parse _namespace_name "Shopping_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Single_brand_store"></see>
    /// </summary>
    let Single_brand_store =
        Namespaced_IRI.parse _namespace_name "Single_brand_store" |> NamespacedName

    /// <summary>
    /// Registrazione della situazione di occupazione di un determinato parcheggio in un certo istante
    /// <see href="http://www.disit.org/km4city/schema#SituationRecord"></see></summary>
    let SituationRecord =
        Namespaced_IRI.parse _namespace_name "SituationRecord" |> NamespacedName

    /// <summary>
    /// every XX minutes a sensor sends a report
    /// <see href="http://www.disit.org/km4city/schema#relatedToSensor"></see></summary>
    let relatedToSensor =
        Namespaced_IRI.parse _namespace_name "relatedToSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Ski_school"></see>
    /// </summary>
    let Ski_school = Namespaced_IRI.parse _namespace_name "Ski_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Skiing_facility"></see>
    /// </summary>
    let Skiing_facility =
        Namespaced_IRI.parse _namespace_name "Skiing_facility" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Small_household_appliances"></see>
    /// </summary>
    let Small_household_appliances =
        Namespaced_IRI.parse _namespace_name "Small_household_appliances" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Small_shop"></see>
    /// </summary>
    let Small_shop = Namespaced_IRI.parse _namespace_name "Small_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Social_centre"></see>
    /// </summary>
    let Social_centre =
        Namespaced_IRI.parse _namespace_name "Social_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Social_security_service_office"></see>
    /// </summary>
    let Social_security_service_office =
        Namespaced_IRI.parse _namespace_name "Social_security_service_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Social_work"></see>
    /// </summary>
    let Social_work =
        Namespaced_IRI.parse _namespace_name "Social_work" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Software_publishing"></see>
    /// </summary>
    let Software_publishing =
        Namespaced_IRI.parse _namespace_name "Software_publishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sound_recording_and_music_publishing"></see>
    /// </summary>
    let Sound_recording_and_music_publishing =
        Namespaced_IRI.parse _namespace_name "Sound_recording_and_music_publishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Souvenirs_Craftwork_and_religious_articles"></see>
    /// </summary>
    let Souvenirs_Craftwork_and_religious_articles =
        Namespaced_IRI.parse _namespace_name "Souvenirs_Craftwork_and_religious_articles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Specialized_construction"></see>
    /// </summary>
    let Specialized_construction =
        Namespaced_IRI.parse _namespace_name "Specialized_construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Specialized_design"></see>
    /// </summary>
    let Specialized_design =
        Namespaced_IRI.parse _namespace_name "Specialized_design" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sport_event_promoters"></see>
    /// </summary>
    let Sport_event_promoters =
        Namespaced_IRI.parse _namespace_name "Sport_event_promoters" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sporting_equipment"></see>
    /// </summary>
    let Sporting_equipment =
        Namespaced_IRI.parse _namespace_name "Sporting_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sports_and_recreation_education"></see>
    /// </summary>
    let Sports_and_recreation_education =
        Namespaced_IRI.parse _namespace_name "Sports_and_recreation_education" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sports_clubs"></see>
    /// </summary>
    let Sports_clubs =
        Namespaced_IRI.parse _namespace_name "Sports_clubs" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sports_facility"></see>
    /// </summary>
    let Sports_facility =
        Namespaced_IRI.parse _namespace_name "Sports_facility" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Squares"></see>
    /// </summary>
    let Squares = Namespaced_IRI.parse _namespace_name "Squares" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stalls_and_markets"></see>
    /// </summary>
    let Stalls_and_markets =
        Namespaced_IRI.parse _namespace_name "Stalls_and_markets" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stalls_and_markets_of_clothing_and_footwear"></see>
    /// </summary>
    let Stalls_and_markets_of_clothing_and_footwear =
        Namespaced_IRI.parse _namespace_name "Stalls_and_markets_of_clothing_and_footwear" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stalls_and_markets_of_food"></see>
    /// </summary>
    let Stalls_and_markets_of_food =
        Namespaced_IRI.parse _namespace_name "Stalls_and_markets_of_food" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stalls_and_markets_other_goods"></see>
    /// </summary>
    let Stalls_and_markets_other_goods =
        Namespaced_IRI.parse _namespace_name "Stalls_and_markets_other_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stamps_and_coins"></see>
    /// </summary>
    let Stamps_and_coins =
        Namespaced_IRI.parse _namespace_name "Stamps_and_coins" |> NamespacedName

    /// <summary>
    /// Valore che fa riferimento ad un dato statistico legato ad una strada o ad una Pa
    /// <see href="http://www.disit.org/km4city/schema#StatisticalData"></see></summary>
    let StatisticalData =
        Namespaced_IRI.parse _namespace_name "StatisticalData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stone_processing"></see>
    /// </summary>
    let Stone_processing =
        Namespaced_IRI.parse _namespace_name "Stone_processing" |> NamespacedName

    /// <summary>
    /// each road has street numbers
    /// <see href="http://www.disit.org/km4city/schema#belongToRoad"></see></summary>
    let belongToRoad =
        Namespaced_IRI.parse _namespace_name "belongToRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Street_sweeping"></see>
    /// </summary>
    let Street_sweeping =
        Namespaced_IRI.parse _namespace_name "Street_sweeping" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Summer_camp"></see>
    /// </summary>
    let Summer_camp =
        Namespaced_IRI.parse _namespace_name "Summer_camp" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Summer_residence"></see>
    /// </summary>
    let Summer_residence =
        Namespaced_IRI.parse _namespace_name "Summer_residence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Supermarket"></see>
    /// </summary>
    let Supermarket =
        Namespaced_IRI.parse _namespace_name "Supermarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Support_activities_for_transportation"></see>
    /// </summary>
    let Support_activities_for_transportation =
        Namespaced_IRI.parse _namespace_name "Support_activities_for_transportation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Support_animal_production"></see>
    /// </summary>
    let Support_animal_production =
        Namespaced_IRI.parse _namespace_name "Support_animal_production" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Surveyor"></see>
    /// </summary>
    let Surveyor = Namespaced_IRI.parse _namespace_name "Surveyor" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sushi_bar"></see>
    /// </summary>
    let Sushi_bar = Namespaced_IRI.parse _namespace_name "Sushi_bar" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Take_away"></see>
    /// </summary>
    let Take_away = Namespaced_IRI.parse _namespace_name "Take_away" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tannery"></see>
    /// </summary>
    let Tannery = Namespaced_IRI.parse _namespace_name "Tannery" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tattoo_and_piercing"></see>
    /// </summary>
    let Tattoo_and_piercing =
        Namespaced_IRI.parse _namespace_name "Tattoo_and_piercing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tax_advice"></see>
    /// </summary>
    let Tax_advice = Namespaced_IRI.parse _namespace_name "Tax_advice" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Taxi_company"></see>
    /// </summary>
    let Taxi_company =
        Namespaced_IRI.parse _namespace_name "Taxi_company" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Taxi_park"></see>
    /// </summary>
    let Taxi_park = Namespaced_IRI.parse _namespace_name "Taxi_park" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Technical_consultants"></see>
    /// </summary>
    let Technical_consultants =
        Namespaced_IRI.parse _namespace_name "Technical_consultants" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Technical_testing"></see>
    /// </summary>
    let Technical_testing =
        Namespaced_IRI.parse _namespace_name "Technical_testing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Telecommunications"></see>
    /// </summary>
    let Telecommunications =
        Namespaced_IRI.parse _namespace_name "Telecommunications" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Television_broadcasting"></see>
    /// </summary>
    let Television_broadcasting =
        Namespaced_IRI.parse _namespace_name "Television_broadcasting" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Temp_agency"></see>
    /// </summary>
    let Temp_agency =
        Namespaced_IRI.parse _namespace_name "Temp_agency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Textile_manufacturing"></see>
    /// </summary>
    let Textile_manufacturing =
        Namespaced_IRI.parse _namespace_name "Textile_manufacturing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Textiles_products"></see>
    /// </summary>
    let Textiles_products =
        Namespaced_IRI.parse _namespace_name "Textiles_products" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Theatre"></see>
    /// </summary>
    let Theatre = Namespaced_IRI.parse _namespace_name "Theatre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Ticket_sale"></see>
    /// </summary>
    let Ticket_sale =
        Namespaced_IRI.parse _namespace_name "Ticket_sale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tobacco_industry"></see>
    /// </summary>
    let Tobacco_industry =
        Namespaced_IRI.parse _namespace_name "Tobacco_industry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tobacco_shop"></see>
    /// </summary>
    let Tobacco_shop =
        Namespaced_IRI.parse _namespace_name "Tobacco_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Toilet"></see>
    /// </summary>
    let Toilet = Namespaced_IRI.parse _namespace_name "Toilet" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tour_operator"></see>
    /// </summary>
    let Tour_operator =
        Namespaced_IRI.parse _namespace_name "Tour_operator" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tourist_complaints_office"></see>
    /// </summary>
    let Tourist_complaints_office =
        Namespaced_IRI.parse _namespace_name "Tourist_complaints_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tourist_guides"></see>
    /// </summary>
    let Tourist_guides =
        Namespaced_IRI.parse _namespace_name "Tourist_guides" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tourist_information_office"></see>
    /// </summary>
    let Tourist_information_office =
        Namespaced_IRI.parse _namespace_name "Tourist_information_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tourist_trail"></see>
    /// </summary>
    let Tourist_trail =
        Namespaced_IRI.parse _namespace_name "Tourist_trail" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Towing_and_roadside_assistance"></see>
    /// </summary>
    let Towing_and_roadside_assistance =
        Namespaced_IRI.parse _namespace_name "Towing_and_roadside_assistance" |> NamespacedName

    /// <summary>
    /// sottoclasse delle osservazioni relative alla concentrazione di auto
    /// <see href="http://www.disit.org/km4city/schema#TrafficConcentration"></see></summary>
    let TrafficConcentration =
        Namespaced_IRI.parse _namespace_name "TrafficConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#concentration"></see>
    /// </summary>
    let concentration =
        Namespaced_IRI.parse _namespace_name "concentration" |> NamespacedName

    /// <summary>
    /// sottoclasse delle osservazioni relative alla flusso auto
    /// <see href="http://www.disit.org/km4city/schema#TrafficFlow"></see></summary>
    let TrafficFlow =
        Namespaced_IRI.parse _namespace_name "TrafficFlow" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#vehicleFlow"></see>
    /// </summary>
    let vehicleFlow =
        Namespaced_IRI.parse _namespace_name "vehicleFlow" |> NamespacedName

    /// <summary>
    /// sottoclasse delle osservazioni sul tempo medio di transito tra auto
    /// <see href="http://www.disit.org/km4city/schema#TrafficHeadway"></see></summary>
    let TrafficHeadway =
        Namespaced_IRI.parse _namespace_name "TrafficHeadway" |> NamespacedName

    /// <summary>
    /// Tempo medio tra 2 transiti
    /// <see href="http://www.disit.org/km4city/schema#averageTime"></see></summary>
    let averageTime =
        Namespaced_IRI.parse _namespace_name "averageTime" |> NamespacedName

    /// <summary>
    /// sottoclasse delle osservazioni relative alla velocita' media
    /// <see href="http://www.disit.org/km4city/schema#TrafficSpeed"></see></summary>
    let TrafficSpeed =
        Namespaced_IRI.parse _namespace_name "TrafficSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#averageSpeed"></see>
    /// </summary>
    let averageSpeed =
        Namespaced_IRI.parse _namespace_name "averageSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Traffic_corps"></see>
    /// </summary>
    let Traffic_corps =
        Namespaced_IRI.parse _namespace_name "Traffic_corps" |> NamespacedName

    /// <summary>
    /// Stazione ferroviaria, sono posizionate in corrispondenza di giunzioni ferroviarie con relazione 1:1
    /// <see href="http://www.disit.org/km4city/schema#TrainStation"></see></summary>
    let TrainStation =
        Namespaced_IRI.parse _namespace_name "TrainStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Train_lost_property_office"></see>
    /// </summary>
    let Train_lost_property_office =
        Namespaced_IRI.parse _namespace_name "Train_lost_property_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Train_station"></see>
    /// </summary>
    let Train_station =
        Namespaced_IRI.parse _namespace_name "Train_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Training_school"></see>
    /// </summary>
    let Training_school =
        Namespaced_IRI.parse _namespace_name "Training_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Training_school_for_teachers"></see>
    /// </summary>
    let Training_school_for_teachers =
        Namespaced_IRI.parse _namespace_name "Training_school_for_teachers" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tram_stops"></see>
    /// </summary>
    let Tram_stops = Namespaced_IRI.parse _namespace_name "Tram_stops" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tramline"></see>
    /// </summary>
    let Tramline = Namespaced_IRI.parse _namespace_name "Tramline" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Translation_and_interpreting"></see>
    /// </summary>
    let Translation_and_interpreting =
        Namespaced_IRI.parse _namespace_name "Translation_and_interpreting" |> NamespacedName

    /// <summary>
    /// servizi molto spesso collegati ad altri servizi, che presentano una loro geolocalizzazione
    /// <see href="http://www.disit.org/km4city/schema#TransverseService"></see></summary>
    let TransverseService =
        Namespaced_IRI.parse _namespace_name "TransverseService" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Trattoria"></see>
    /// </summary>
    let Trattoria = Namespaced_IRI.parse _namespace_name "Trattoria" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Travel_agency"></see>
    /// </summary>
    let Travel_agency =
        Namespaced_IRI.parse _namespace_name "Travel_agency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Travel_bureau"></see>
    /// </summary>
    let Travel_bureau =
        Namespaced_IRI.parse _namespace_name "Travel_bureau" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Travel_goods"></see>
    /// </summary>
    let Travel_goods =
        Namespaced_IRI.parse _namespace_name "Travel_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Travel_information"></see>
    /// </summary>
    let Travel_information =
        Namespaced_IRI.parse _namespace_name "Travel_information" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Trinkets"></see>
    /// </summary>
    let Trinkets = Namespaced_IRI.parse _namespace_name "Trinkets" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Underwear_knitwear_and_shirts"></see>
    /// </summary>
    let Underwear_knitwear_and_shirts =
        Namespaced_IRI.parse _namespace_name "Underwear_knitwear_and_shirts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Upholsterer"></see>
    /// </summary>
    let Upholsterer =
        Namespaced_IRI.parse _namespace_name "Upholsterer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Urban_bus"></see>
    /// </summary>
    let Urban_bus = Namespaced_IRI.parse _namespace_name "Urban_bus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Useful_numbers"></see>
    /// </summary>
    let Useful_numbers =
        Namespaced_IRI.parse _namespace_name "Useful_numbers" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vacating_service"></see>
    /// </summary>
    let Vacating_service =
        Namespaced_IRI.parse _namespace_name "Vacating_service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vacation_resort"></see>
    /// </summary>
    let Vacation_resort =
        Namespaced_IRI.parse _namespace_name "Vacation_resort" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vehicle_rental"></see>
    /// </summary>
    let Vehicle_rental =
        Namespaced_IRI.parse _namespace_name "Vehicle_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vehicle_trade"></see>
    /// </summary>
    let Vehicle_trade =
        Namespaced_IRI.parse _namespace_name "Vehicle_trade" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vending_machines"></see>
    /// </summary>
    let Vending_machines =
        Namespaced_IRI.parse _namespace_name "Vending_machines" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Veterinary"></see>
    /// </summary>
    let Veterinary = Namespaced_IRI.parse _namespace_name "Veterinary" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Video_tapes_disks_rental"></see>
    /// </summary>
    let Video_tapes_disks_rental =
        Namespaced_IRI.parse _namespace_name "Video_tapes_disks_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wallpaper_and_floor_coverings"></see>
    /// </summary>
    let Wallpaper_and_floor_coverings =
        Namespaced_IRI.parse _namespace_name "Wallpaper_and_floor_coverings" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Warehousing_and_storage"></see>
    /// </summary>
    let Warehousing_and_storage =
        Namespaced_IRI.parse _namespace_name "Warehousing_and_storage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Waste_collection_and_treatment"></see>
    /// </summary>
    let Waste_collection_and_treatment =
        Namespaced_IRI.parse _namespace_name "Waste_collection_and_treatment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Water_collection_treatment_and_supply"></see>
    /// </summary>
    let Water_collection_treatment_and_supply =
        Namespaced_IRI.parse _namespace_name "Water_collection_treatment_and_supply" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Water_transport"></see>
    /// </summary>
    let Water_transport =
        Namespaced_IRI.parse _namespace_name "Water_transport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Weapons_and_ammunition"></see>
    /// </summary>
    let Weapons_and_ammunition =
        Namespaced_IRI.parse _namespace_name "Weapons_and_ammunition" |> NamespacedName

    /// <summary>
    /// Previsione metereologica relativa ad una specifica parte del giorno
    /// <see href="http://www.disit.org/km4city/schema#WeatherPrediction"></see></summary>
    let WeatherPrediction =
        Namespaced_IRI.parse _namespace_name "WeatherPrediction" |> NamespacedName

    /// <summary>
    /// Bollettino metereologico con informazioni relative a temperatura, unidita', neve, etc
    /// <see href="http://www.disit.org/km4city/schema#WeatherReport"></see></summary>
    let WeatherReport =
        Namespaced_IRI.parse _namespace_name "WeatherReport" |> NamespacedName

    /// <summary>
    /// specifies the municipality for the weather forecast
    /// <see href="http://www.disit.org/km4city/schema#refersToMunicipality"></see></summary>
    let refersToMunicipality =
        Namespaced_IRI.parse _namespace_name "refersToMunicipality" |> NamespacedName

    /// <summary>
    /// Sensore meteo che rilascia info sulle previsioni meteo
    /// <see href="http://www.disit.org/km4city/schema#Weather_sensor"></see></summary>
    let Weather_sensor =
        Namespaced_IRI.parse _namespace_name "Weather_sensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Web_and_internet_provider"></see>
    /// </summary>
    let Web_and_internet_provider =
        Namespaced_IRI.parse _namespace_name "Web_and_internet_provider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wedding_favors"></see>
    /// </summary>
    let Wedding_favors =
        Namespaced_IRI.parse _namespace_name "Wedding_favors" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Welfare_worker_office"></see>
    /// </summary>
    let Welfare_worker_office =
        Namespaced_IRI.parse _namespace_name "Welfare_worker_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wellness_centre"></see>
    /// </summary>
    let Wellness_centre =
        Namespaced_IRI.parse _namespace_name "Wellness_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_ICT_equipment"></see>
    /// </summary>
    let Wholesale_ICT_equipment =
        Namespaced_IRI.parse _namespace_name "Wholesale_ICT_equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_agricultural_raw_materials_live_animals"></see>
    /// </summary>
    let Wholesale_agricultural_raw_materials_live_animals =
        Namespaced_IRI.parse _namespace_name "Wholesale_agricultural_raw_materials_live_animals" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_commission_trade"></see>
    /// </summary>
    let Wholesale_commission_trade =
        Namespaced_IRI.parse _namespace_name "Wholesale_commission_trade" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_food_beverages_tobacco"></see>
    /// </summary>
    let Wholesale_food_beverages_tobacco =
        Namespaced_IRI.parse _namespace_name "Wholesale_food_beverages_tobacco" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_household_goods"></see>
    /// </summary>
    let Wholesale_household_goods =
        Namespaced_IRI.parse _namespace_name "Wholesale_household_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_machinery_equipmentent_supplies"></see>
    /// </summary>
    let Wholesale_machinery_equipmentent_supplies =
        Namespaced_IRI.parse _namespace_name "Wholesale_machinery_equipmentent_supplies" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_motor_vehicles_parts"></see>
    /// </summary>
    let Wholesale_motor_vehicles_parts =
        Namespaced_IRI.parse _namespace_name "Wholesale_motor_vehicles_parts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_trade"></see>
    /// </summary>
    let Wholesale_trade =
        Namespaced_IRI.parse _namespace_name "Wholesale_trade" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wifi"></see>
    /// </summary>
    let Wifi = Namespaced_IRI.parse _namespace_name "Wifi" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wine_shop_and_wine_bar"></see>
    /// </summary>
    let Wine_shop_and_wine_bar =
        Namespaced_IRI.parse _namespace_name "Wine_shop_and_wine_bar" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Youth_assistance"></see>
    /// </summary>
    let Youth_assistance =
        Namespaced_IRI.parse _namespace_name "Youth_assistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Youth_information_centre"></see>
    /// </summary>
    let Youth_information_centre =
        Namespaced_IRI.parse _namespace_name "Youth_information_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#abbreviation"></see>
    /// </summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#accessType"></see>
    /// </summary>
    let accessType = Namespaced_IRI.parse _namespace_name "accessType" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#adRoadName"></see>
    /// </summary>
    let adRoadName = Namespaced_IRI.parse _namespace_name "adRoadName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#adminClass"></see>
    /// </summary>
    let adminClass = Namespaced_IRI.parse _namespace_name "adminClass" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#alterCode"></see>
    /// </summary>
    let alterCode = Namespaced_IRI.parse _namespace_name "alterCode" |> NamespacedName

    /// <summary>
    /// to connect a resolution to the municipality that have approved it
    /// <see href="http://www.disit.org/km4city/schema#approvedByPa"></see></summary>
    let approvedByPa =
        Namespaced_IRI.parse _namespace_name "approvedByPa" |> NamespacedName

    /// <summary>
    /// to connect a resolution to the municipality that have approved it
    /// <see href="http://www.disit.org/km4city/schema#hasResolution"></see></summary>
    let hasResolution =
        Namespaced_IRI.parse _namespace_name "hasResolution" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#areaCode"></see>
    /// </summary>
    let areaCode = Namespaced_IRI.parse _namespace_name "areaCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#areaName"></see>
    /// </summary>
    let areaName = Namespaced_IRI.parse _namespace_name "areaName" |> NamespacedName

    /// <summary>
    /// to connect each beacon to the road in which it is installed
    /// <see href="http://www.disit.org/km4city/schema#arrangedOnRoad"></see></summary>
    let arrangedOnRoad =
        Namespaced_IRI.parse _namespace_name "arrangedOnRoad" |> NamespacedName

    /// <summary>
    /// each forecast refers to a specific bus stop
    /// <see href="http://www.disit.org/km4city/schema#hasForecast"></see></summary>
    let hasForecast =
        Namespaced_IRI.parse _namespace_name "hasForecast" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#atecoCode"></see>
    /// </summary>
    let atecoCode = Namespaced_IRI.parse _namespace_name "atecoCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#automaticity"></see>
    /// </summary>
    let automaticity =
        Namespaced_IRI.parse _namespace_name "automaticity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#averageDistance"></see>
    /// </summary>
    let averageDistance =
        Namespaced_IRI.parse _namespace_name "averageDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#axialMass"></see>
    /// </summary>
    let axialMass = Namespaced_IRI.parse _namespace_name "axialMass" |> NamespacedName

    /// <summary>
    /// each road has street numbers
    /// <see href="http://www.disit.org/km4city/schema#hasStreetNumber"></see></summary>
    let hasStreetNumber =
        Namespaced_IRI.parse _namespace_name "hasStreetNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#capacity"></see>
    /// </summary>
    let capacity = Namespaced_IRI.parse _namespace_name "capacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#carParkStatus"></see>
    /// </summary>
    let carParkStatus =
        Namespaced_IRI.parse _namespace_name "carParkStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#category"></see>
    /// </summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#classCode"></see>
    /// </summary>
    let classCode = Namespaced_IRI.parse _namespace_name "classCode" |> NamespacedName

    /// <summary>
    /// there is no exact match between Road and AdministrativeRoad
    /// <see href="http://www.disit.org/km4city/schema#coincideWith"></see></summary>
    let coincideWith =
        Namespaced_IRI.parse _namespace_name "coincideWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#combinedTraffic"></see>
    /// </summary>
    let combinedTraffic =
        Namespaced_IRI.parse _namespace_name "combinedTraffic" |> NamespacedName

    /// <summary>
    /// a railway Direction is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#composeDirection"></see></summary>
    let composeDirection =
        Namespaced_IRI.parse _namespace_name "composeDirection" |> NamespacedName

    /// <summary>
    /// a railway Section is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#composeSection"></see></summary>
    let composeSection =
        Namespaced_IRI.parse _namespace_name "composeSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#composition"></see>
    /// </summary>
    let composition =
        Namespaced_IRI.parse _namespace_name "composition" |> NamespacedName

    /// <summary>
    /// an AVMrecord concert to a unique line
    /// <see href="http://www.disit.org/km4city/schema#concernLine"></see></summary>
    let concernLine =
        Namespaced_IRI.parse _namespace_name "concernLine" |> NamespacedName

    /// <summary>
    /// A road is formed by more elements road
    /// <see href="http://www.disit.org/km4city/schema#containsElement"></see></summary>
    let containsElement =
        Namespaced_IRI.parse _namespace_name "containsElement" |> NamespacedName

    /// <summary>
    /// More road elements compose a road
    /// <see href="http://www.disit.org/km4city/schema#isPartOfRoad"></see></summary>
    let isPartOfRoad =
        Namespaced_IRI.parse _namespace_name "isPartOfRoad" |> NamespacedName

    /// <summary>
    /// there is no exact match between Road and AdministrativeRoad
    /// <see href="http://www.disit.org/km4city/schema#correspondsTo"></see></summary>
    let correspondsTo =
        Namespaced_IRI.parse _namespace_name "correspondsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#day"></see>
    /// </summary>
    let day = Namespaced_IRI.parse _namespace_name "day" |> NamespacedName
    /// <summary>
    /// direzione percorso
    /// <see href="http://www.disit.org/km4city/schema#direction"></see></summary>
    let direction = Namespaced_IRI.parse _namespace_name "direction" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#distance"></see>
    /// </summary>
    let distance = Namespaced_IRI.parse _namespace_name "distance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#districtCode"></see>
    /// </summary>
    let districtCode =
        Namespaced_IRI.parse _namespace_name "districtCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#elemLocation"></see>
    /// </summary>
    let elemLocation =
        Namespaced_IRI.parse _namespace_name "elemLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#elementClass"></see>
    /// </summary>
    let elementClass =
        Namespaced_IRI.parse _namespace_name "elementClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#elementType"></see>
    /// </summary>
    let elementType =
        Namespaced_IRI.parse _namespace_name "elementType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#entryType"></see>
    /// </summary>
    let entryType = Namespaced_IRI.parse _namespace_name "entryType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#eventCategory"></see>
    /// </summary>
    let eventCategory =
        Namespaced_IRI.parse _namespace_name "eventCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#eventTime"></see>
    /// </summary>
    let eventTime = Namespaced_IRI.parse _namespace_name "eventTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#exitRate"></see>
    /// </summary>
    let exitRate = Namespaced_IRI.parse _namespace_name "exitRate" |> NamespacedName

    /// <summary>
    /// orario in cui e' previsto l'arrivo del bus a quella fermata DA ELIMINARE QUANDO INSTANT FUNZIONERA' ALLA PERFEZIONE
    /// <see href="http://www.disit.org/km4city/schema#expectedTime"></see></summary>
    let expectedTime =
        Namespaced_IRI.parse _namespace_name "expectedTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#exponent"></see>
    /// </summary>
    let exponent = Namespaced_IRI.parse _namespace_name "exponent" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#extendName"></see>
    /// </summary>
    let extendName = Namespaced_IRI.parse _namespace_name "extendName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#extendNumber"></see>
    /// </summary>
    let extendNumber =
        Namespaced_IRI.parse _namespace_name "extendNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#fillRate"></see>
    /// </summary>
    let fillRate = Namespaced_IRI.parse _namespace_name "fillRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#firenzeCard"></see>
    /// </summary>
    let firenzeCard =
        Namespaced_IRI.parse _namespace_name "firenzeCard" |> NamespacedName

    /// <summary>
    /// more road elements form an administrative road
    /// <see href="http://www.disit.org/km4city/schema#formingAdminRoad"></see></summary>
    let formingAdminRoad =
        Namespaced_IRI.parse _namespace_name "formingAdminRoad" |> NamespacedName

    /// <summary>
    /// more road elements form an administrative road
    /// <see href="http://www.disit.org/km4city/schema#hasRoadElement"></see></summary>
    let hasRoadElement =
        Namespaced_IRI.parse _namespace_name "hasRoadElement" |> NamespacedName

    /// <summary>
    /// more road sensors form a sensor Table
    /// <see href="http://www.disit.org/km4city/schema#formsTable"></see></summary>
    let formsTable = Namespaced_IRI.parse _namespace_name "formsTable" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#free"></see>
    /// </summary>
    let free = Namespaced_IRI.parse _namespace_name "free" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#freeEvent"></see>
    /// </summary>
    let freeEvent = Namespaced_IRI.parse _namespace_name "freeEvent" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#gauge"></see>
    /// </summary>
    let gauge = Namespaced_IRI.parse _namespace_name "gauge" |> NamespacedName

    /// <summary>
    /// the AVM refer to a specific ride code
    /// <see href="http://www.disit.org/km4city/schema#hasAVMRecord"></see></summary>
    let hasAVMRecord =
        Namespaced_IRI.parse _namespace_name "hasAVMRecord" |> NamespacedName

    /// <summary>
    /// point corresponding to the house number of service
    /// <see href="http://www.disit.org/km4city/schema#hasAccess"></see></summary>
    let hasAccess = Namespaced_IRI.parse _namespace_name "hasAccess" |> NamespacedName

    /// <summary>
    /// to connect each beacon to observations that it produces
    /// <see href="http://www.disit.org/km4city/schema#hasBObservation"></see></summary>
    let hasBObservation =
        Namespaced_IRI.parse _namespace_name "hasBObservation" |> NamespacedName

    /// <summary>
    /// to connect each car park to its installed sensor
    /// <see href="http://www.disit.org/km4city/schema#hasCarParkSensor"></see></summary>
    let hasCarParkSensor =
        Namespaced_IRI.parse _namespace_name "hasCarParkSensor" |> NamespacedName

    /// <summary>
    /// to connect each sensor to the referred car park service
    /// <see href="http://www.disit.org/km4city/schema#observeCarPark"></see></summary>
    let observeCarPark =
        Namespaced_IRI.parse _namespace_name "observeCarPark" |> NamespacedName

    /// <summary>
    /// the expected time at the next bus stops
    /// <see href="http://www.disit.org/km4city/schema#hasExpectedTime"></see></summary>
    let hasExpectedTime =
        Namespaced_IRI.parse _namespace_name "hasExpectedTime" |> NamespacedName

    /// <summary>
    /// the expected time at the next bus stops
    /// <see href="http://www.disit.org/km4city/schema#instantForecast"></see></summary>
    let instantForecast =
        Namespaced_IRI.parse _namespace_name "instantForecast" |> NamespacedName

    /// <summary>
    /// it corresponds to the outer gate of the building
    /// <see href="http://www.disit.org/km4city/schema#hasExternalAccess"></see></summary>
    let hasExternalAccess =
        Namespaced_IRI.parse _namespace_name "hasExternalAccess" |> NamespacedName

    /// <summary>
    /// some services and all railway elements have a specific geometry like polygons or linestrings
    /// <see href="http://www.disit.org/km4city/schema#hasGeometry"></see></summary>
    let hasGeometry =
        Namespaced_IRI.parse _namespace_name "hasGeometry" |> NamespacedName

    /// <summary>
    /// it corresponds to the door of the building
    /// <see href="http://www.disit.org/km4city/schema#hasInternalAccess"></see></summary>
    let hasInternalAccess =
        Namespaced_IRI.parse _namespace_name "hasInternalAccess" |> NamespacedName

    /// <summary>
    /// defines which is the last stop of a route
    /// <see href="http://www.disit.org/km4city/schema#hasLastStop"></see></summary>
    let hasLastStop =
        Namespaced_IRI.parse _namespace_name "hasLastStop" |> NamespacedName

    /// <summary>
    /// the arrival time at last bus stops
    /// <see href="http://www.disit.org/km4city/schema#hasLastStopTime"></see></summary>
    let hasLastStopTime =
        Namespaced_IRI.parse _namespace_name "hasLastStopTime" |> NamespacedName

    /// <summary>
    /// the arrival time at last bus stops
    /// <see href="http://www.disit.org/km4city/schema#instantAVM"></see></summary>
    let instantAVM = Namespaced_IRI.parse _namespace_name "instantAVM" |> NamespacedName

    /// <summary>
    /// an entry rule can be connected to a specific maneuver
    /// <see href="http://www.disit.org/km4city/schema#hasManeuver"></see></summary>
    let hasManeuver =
        Namespaced_IRI.parse _namespace_name "hasManeuver" |> NamespacedName

    /// <summary>
    /// a province is formed by more municipalities
    /// <see href="http://www.disit.org/km4city/schema#hasMunicipality"></see></summary>
    let hasMunicipality =
        Namespaced_IRI.parse _namespace_name "hasMunicipality" |> NamespacedName

    /// <summary>
    /// each road sensor produce a report every XX minuts
    /// <see href="http://www.disit.org/km4city/schema#hasObservation"></see></summary>
    let hasObservation =
        Namespaced_IRI.parse _namespace_name "hasObservation" |> NamespacedName

    /// <summary>
    /// a report is made up of more predictions
    /// <see href="http://www.disit.org/km4city/schema#hasPrediction"></see></summary>
    let hasPrediction =
        Namespaced_IRI.parse _namespace_name "hasPrediction" |> NamespacedName

    /// <summary>
    /// in a region there are more than one province
    /// <see href="http://www.disit.org/km4city/schema#hasProvince"></see></summary>
    let hasProvince =
        Namespaced_IRI.parse _namespace_name "hasProvince" |> NamespacedName

    /// <summary>
    /// in a region there are more than one province
    /// <see href="http://www.disit.org/km4city/schema#isPartOfRegion"></see></summary>
    let isPartOfRegion =
        Namespaced_IRI.parse _namespace_name "isPartOfRegion" |> NamespacedName

    /// <summary>
    /// every 10 minutes a sensor sends a report
    /// <see href="http://www.disit.org/km4city/schema#hasRecord"></see></summary>
    let hasRecord = Namespaced_IRI.parse _namespace_name "hasRecord" |> NamespacedName

    /// <summary>
    /// regular services can be connected to transverse services
    /// <see href="http://www.disit.org/km4city/schema#hasRegularService"></see></summary>
    let hasRegularService =
        Namespaced_IRI.parse _namespace_name "hasRegularService" |> NamespacedName

    /// <summary>
    /// each route refers to a line
    /// <see href="http://www.disit.org/km4city/schema#hasRoute"></see></summary>
    let hasRoute = Namespaced_IRI.parse _namespace_name "hasRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#hasRouteLink"></see>
    /// </summary>
    let hasRouteLink =
        Namespaced_IRI.parse _namespace_name "hasRouteLink" |> NamespacedName

    /// <summary>
    /// some road elements subject to rules of access
    /// <see href="http://www.disit.org/km4city/schema#hasRule"></see></summary>
    let hasRule = Namespaced_IRI.parse _namespace_name "hasRule" |> NamespacedName
    /// <summary>
    /// each road element can be see as a collection of consecutive road link
    /// <see href="http://www.disit.org/km4city/schema#hasSegment"></see></summary>
    let hasSegment = Namespaced_IRI.parse _namespace_name "hasSegment" |> NamespacedName

    /// <summary>
    /// to connect a statistic to the referred municipality
    /// <see href="http://www.disit.org/km4city/schema#hasStatistic"></see></summary>
    let hasStatistic =
        Namespaced_IRI.parse _namespace_name "hasStatistic" |> NamespacedName

    /// <summary>
    /// to connect each train station tothe correspondant service
    /// <see href="http://www.disit.org/km4city/schema#hasTransferService"></see></summary>
    let hasTransferService =
        Namespaced_IRI.parse _namespace_name "hasTransferService" |> NamespacedName

    /// <summary>
    /// regular services can be connected to transverse services
    /// <see href="http://www.disit.org/km4city/schema#hasTransverseService"></see></summary>
    let hasTransverseService =
        Namespaced_IRI.parse _namespace_name "hasTransverseService" |> NamespacedName

    /// <summary>
    /// each weather forecasts is connected to a municipality
    /// <see href="http://www.disit.org/km4city/schema#hasWeatherReport"></see></summary>
    let hasWeatherReport =
        Namespaced_IRI.parse _namespace_name "hasWeatherReport" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#heightHour"></see>
    /// </summary>
    let heightHour = Namespaced_IRI.parse _namespace_name "heightHour" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#hour"></see>
    /// </summary>
    let hour = Namespaced_IRI.parse _namespace_name "hour" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#houseNumber"></see>
    /// </summary>
    let houseNumber =
        Namespaced_IRI.parse _namespace_name "houseNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#humidity"></see>
    /// </summary>
    let humidity = Namespaced_IRI.parse _namespace_name "humidity" |> NamespacedName

    /// <summary>
    /// municipality to which the road belongs
    /// <see href="http://www.disit.org/km4city/schema#inMunicipalityOf"></see></summary>
    let inMunicipalityOf =
        Namespaced_IRI.parse _namespace_name "inMunicipalityOf" |> NamespacedName

    /// <summary>
    /// each AVMrecord includes more forecasts
    /// <see href="http://www.disit.org/km4city/schema#includeForecast"></see></summary>
    let includeForecast =
        Namespaced_IRI.parse _namespace_name "includeForecast" |> NamespacedName

    /// <summary>
    /// ime and date of each Beacon observation
    /// <see href="http://www.disit.org/km4city/schema#instantBObserv"></see></summary>
    let instantBObserv =
        Namespaced_IRI.parse _namespace_name "instantBObserv" |> NamespacedName

    /// <summary>
    /// Time and date of each Beacon observation
    /// <see href="http://www.disit.org/km4city/schema#measuredDate"></see></summary>
    let measuredDate =
        Namespaced_IRI.parse _namespace_name "measuredDate" |> NamespacedName

    /// <summary>
    /// the time of one observation
    /// <see href="http://www.disit.org/km4city/schema#instantObserv"></see></summary>
    let instantObserv =
        Namespaced_IRI.parse _namespace_name "instantObserv" |> NamespacedName

    /// <summary>
    /// the generation time of one situation record
    /// <see href="http://www.disit.org/km4city/schema#instantParking"></see></summary>
    let instantParking =
        Namespaced_IRI.parse _namespace_name "instantParking" |> NamespacedName

    /// <summary>
    /// the generation time of a new weather report
    /// <see href="http://www.disit.org/km4city/schema#instantWReport"></see></summary>
    let instantWReport =
        Namespaced_IRI.parse _namespace_name "instantWReport" |> NamespacedName

    /// <summary>
    /// each milestone need to refers to a road
    /// <see href="http://www.disit.org/km4city/schema#isInElement"></see></summary>
    let isInElement =
        Namespaced_IRI.parse _namespace_name "isInElement" |> NamespacedName

    /// <summary>
    /// A bus stop can be connected to the municipality to which belong
    /// <see href="http://www.disit.org/km4city/schema#isInMunicipality"></see></summary>
    let isInMunicipality =
        Namespaced_IRI.parse _namespace_name "isInMunicipality" |> NamespacedName

    /// <summary>
    ///  service and train station can be connected to the referred Road
    /// <see href="http://www.disit.org/km4city/schema#isInRoad"></see></summary>
    let isInRoad = Namespaced_IRI.parse _namespace_name "isInRoad" |> NamespacedName

    /// <summary>
    /// a railway line is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#isPartOfLine"></see></summary>
    let isPartOfLine =
        Namespaced_IRI.parse _namespace_name "isPartOfLine" |> NamespacedName

    /// <summary>
    /// bus stops and bus lines are part of a lot
    /// <see href="http://www.disit.org/km4city/schema#isPartOfLot"></see></summary>
    let isPartOfLot =
        Namespaced_IRI.parse _namespace_name "isPartOfLot" |> NamespacedName

    /// <summary>
    /// a province is formed by more municipalities
    /// <see href="http://www.disit.org/km4city/schema#isPartOfProvince"></see></summary>
    let isPartOfProvince =
        Namespaced_IRI.parse _namespace_name "isPartOfProvince" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#juncType"></see>
    /// </summary>
    let juncType = Namespaced_IRI.parse _namespace_name "juncType" |> NamespacedName
    /// <summary>
    /// the AVMrecord specify which is the last bus stop made
    /// <see href="http://www.disit.org/km4city/schema#lastStop"></see></summary>
    let lastStop = Namespaced_IRI.parse _namespace_name "lastStop" |> NamespacedName

    /// <summary>
    /// orario in cui il bus ha raggiunto l'ultima fermata DA ELIMINARE QUANDO INSTANT FUNZIONERA' ALLA PERFEZIONE
    /// <see href="http://www.disit.org/km4city/schema#lastStopTime"></see></summary>
    let lastStopTime =
        Namespaced_IRI.parse _namespace_name "lastStopTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#lastTriples"></see>
    /// </summary>
    let lastTriples =
        Namespaced_IRI.parse _namespace_name "lastTriples" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#lastUpdate"></see>
    /// </summary>
    let lastUpdate = Namespaced_IRI.parse _namespace_name "lastUpdate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#length"></see>
    /// </summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#lineNumber"></see>
    /// </summary>
    let lineNumber = Namespaced_IRI.parse _namespace_name "lineNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#lunarPhase"></see>
    /// </summary>
    let lunarPhase = Namespaced_IRI.parse _namespace_name "lunarPhase" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#major"></see>
    /// </summary>
    let major = Namespaced_IRI.parse _namespace_name "major" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#managingAuth"></see>
    /// </summary>
    let managingAuth =
        Namespaced_IRI.parse _namespace_name "managingAuth" |> NamespacedName

    /// <summary>
    /// the authority that deals with the road elements management
    /// <see href="http://www.disit.org/km4city/schema#managingAuthority"></see></summary>
    let managingAuthority =
        Namespaced_IRI.parse _namespace_name "managingAuthority" |> NamespacedName

    /// <summary>
    /// ente gestore del sistema AVM o dei road sensor
    /// <see href="http://www.disit.org/km4city/schema#managingBy"></see></summary>
    let managingBy = Namespaced_IRI.parse _namespace_name "managingBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#maneuverType"></see>
    /// </summary>
    let maneuverType =
        Namespaced_IRI.parse _namespace_name "maneuverType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#maxTemp"></see>
    /// </summary>
    let maxTemp = Namespaced_IRI.parse _namespace_name "maxTemp" |> NamespacedName

    /// <summary>
    /// to connect each observation to the beacon that has product it
    /// <see href="http://www.disit.org/km4city/schema#measuredByBeacon"></see></summary>
    let measuredByBeacon =
        Namespaced_IRI.parse _namespace_name "measuredByBeacon" |> NamespacedName

    /// <summary>
    /// each observation refers to only one road sensor
    /// <see href="http://www.disit.org/km4city/schema#measuredBySensor"></see></summary>
    let measuredBySensor =
        Namespaced_IRI.parse _namespace_name "measuredBySensor" |> NamespacedName

    /// <summary>
    /// the time of one observation
    /// <see href="http://www.disit.org/km4city/schema#measuredTime"></see></summary>
    let measuredTime =
        Namespaced_IRI.parse _namespace_name "measuredTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#minTemp"></see>
    /// </summary>
    let minTemp = Namespaced_IRI.parse _namespace_name "minTemp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#minor"></see>
    /// </summary>
    let minor = Namespaced_IRI.parse _namespace_name "minor" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#moonrise"></see>
    /// </summary>
    let moonrise = Namespaced_IRI.parse _namespace_name "moonrise" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#moonset"></see>
    /// </summary>
    let moonset = Namespaced_IRI.parse _namespace_name "moonset" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#multimediaResource"></see>
    /// </summary>
    let multimediaResource =
        Namespaced_IRI.parse _namespace_name "multimediaResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#nodeType"></see>
    /// </summary>
    let nodeType = Namespaced_IRI.parse _namespace_name "nodeType" |> NamespacedName
    /// <summary>
    /// numero di binari presenti. se in costruzione o dismesso inserire uno zero
    /// <see href="http://www.disit.org/km4city/schema#numTrack"></see></summary>
    let numTrack = Namespaced_IRI.parse _namespace_name "numTrack" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#number"></see>
    /// </summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName

    /// <summary>
    /// the generation time of one situation record
    /// <see href="http://www.disit.org/km4city/schema#observationTime"></see></summary>
    let observationTime =
        Namespaced_IRI.parse _namespace_name "observationTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#occupancy"></see>
    /// </summary>
    let occupancy = Namespaced_IRI.parse _namespace_name "occupancy" |> NamespacedName
    /// <summary>
    /// numero di posti occupati
    /// <see href="http://www.disit.org/km4city/schema#occupied"></see></summary>
    let occupied = Namespaced_IRI.parse _namespace_name "occupied" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#operatingStatus"></see>
    /// </summary>
    let operatingStatus =
        Namespaced_IRI.parse _namespace_name "operatingStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#overtime"></see>
    /// </summary>
    let overtime = Namespaced_IRI.parse _namespace_name "overtime" |> NamespacedName
    /// <summary>
    /// sente proprietario del sistema AVM
    /// <see href="http://www.disit.org/km4city/schema#owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName

    /// <summary>
    /// the authority that owns the administrative road
    /// <see href="http://www.disit.org/km4city/schema#ownerAuthority"></see></summary>
    let ownerAuthority =
        Namespaced_IRI.parse _namespace_name "ownerAuthority" |> NamespacedName

    /// <summary>
    /// percentuale di posti occupati
    /// <see href="http://www.disit.org/km4city/schema#parkOccupancy"></see></summary>
    let parkOccupancy =
        Namespaced_IRI.parse _namespace_name "parkOccupancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#perTemp"></see>
    /// </summary>
    let perTemp = Namespaced_IRI.parse _namespace_name "perTemp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#period"></see>
    /// </summary>
    let period = Namespaced_IRI.parse _namespace_name "period" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#placeName"></see>
    /// </summary>
    let placeName = Namespaced_IRI.parse _namespace_name "placeName" |> NamespacedName

    /// <summary>
    /// each entry need to refers to a road
    /// <see href="http://www.disit.org/km4city/schema#placedInElement"></see></summary>
    let placedInElement =
        Namespaced_IRI.parse _namespace_name "placedInElement" |> NamespacedName

    /// <summary>
    /// to connect each road sensor to the road in which is installed
    /// <see href="http://www.disit.org/km4city/schema#placedOnRoad"></see></summary>
    let placedOnRoad =
        Namespaced_IRI.parse _namespace_name "placedOnRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#porteCochere"></see>
    /// </summary>
    let porteCochere =
        Namespaced_IRI.parse _namespace_name "porteCochere" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#power"></see>
    /// </summary>
    let power = Namespaced_IRI.parse _namespace_name "power" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#primaryType"></see>
    /// </summary>
    let primaryType =
        Namespaced_IRI.parse _namespace_name "primaryType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#processType"></see>
    /// </summary>
    let processType =
        Namespaced_IRI.parse _namespace_name "processType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#public"></see>
    /// </summary>
    let public_ = Namespaced_IRI.parse _namespace_name "public" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#railDepartment"></see>
    /// </summary>
    let railDepartment =
        Namespaced_IRI.parse _namespace_name "railDepartment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#railwaySiding"></see>
    /// </summary>
    let railwaySiding =
        Namespaced_IRI.parse _namespace_name "railwaySiding" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#recTemp"></see>
    /// </summary>
    let recTemp = Namespaced_IRI.parse _namespace_name "recTemp" |> NamespacedName

    /// <summary>
    /// the AVM refer to a specific ride code
    /// <see href="http://www.disit.org/km4city/schema#refersToRide"></see></summary>
    let refersToRide =
        Namespaced_IRI.parse _namespace_name "refersToRide" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#restrictionType"></see>
    /// </summary>
    let restrictionType =
        Namespaced_IRI.parse _namespace_name "restrictionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#restrictionValue"></see>
    /// </summary>
    let restrictionValue =
        Namespaced_IRI.parse _namespace_name "restrictionValue" |> NamespacedName

    /// <summary>
    /// stato della corsa: anticipo, ritardo, in orario
    /// <see href="http://www.disit.org/km4city/schema#rideState"></see></summary>
    let rideState = Namespaced_IRI.parse _namespace_name "rideState" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#roadName"></see>
    /// </summary>
    let roadName = Namespaced_IRI.parse _namespace_name "roadName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#roadType"></see>
    /// </summary>
    let roadType = Namespaced_IRI.parse _namespace_name "roadType" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#routeCode"></see>
    /// </summary>
    let routeCode = Namespaced_IRI.parse _namespace_name "routeCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#routeLength"></see>
    /// </summary>
    let routeLength =
        Namespaced_IRI.parse _namespace_name "routeLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#routePosition"></see>
    /// </summary>
    let routePosition =
        Namespaced_IRI.parse _namespace_name "routePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#snow"></see>
    /// </summary>
    let snow = Namespaced_IRI.parse _namespace_name "snow" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#speedLimit"></see>
    /// </summary>
    let speedLimit = Namespaced_IRI.parse _namespace_name "speedLimit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#speedPercentile"></see>
    /// </summary>
    let speedPercentile =
        Namespaced_IRI.parse _namespace_name "speedPercentile" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#state"></see>
    /// </summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#stopNumber"></see>
    /// </summary>
    let stopNumber = Namespaced_IRI.parse _namespace_name "stopNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#sunHeight"></see>
    /// </summary>
    let sunHeight = Namespaced_IRI.parse _namespace_name "sunHeight" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#sunrise"></see>
    /// </summary>
    let sunrise = Namespaced_IRI.parse _namespace_name "sunrise" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#sunset"></see>
    /// </summary>
    let sunset = Namespaced_IRI.parse _namespace_name "sunset" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#supply"></see>
    /// </summary>
    let supply = Namespaced_IRI.parse _namespace_name "supply" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#text"></see>
    /// </summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#thresholdPerc"></see>
    /// </summary>
    let thresholdPerc =
        Namespaced_IRI.parse _namespace_name "thresholdPerc" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#time"></see>
    /// </summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName
    /// <summary>
    /// ANCHE SE VERRA' INSERITO IL COLLEGAMENTO CON INSTANT, QUESTO ATTRIBUTO NON VA CANCELLATO
    /// <see href="http://www.disit.org/km4city/schema#timestamp"></see></summary>
    let timestamp = Namespaced_IRI.parse _namespace_name "timestamp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#trackType"></see>
    /// </summary>
    let trackType = Namespaced_IRI.parse _namespace_name "trackType" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#trafficDir"></see>
    /// </summary>
    let trafficDir = Namespaced_IRI.parse _namespace_name "trafficDir" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#typeLabel"></see>
    /// </summary>
    let typeLabel = Namespaced_IRI.parse _namespace_name "typeLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#typeOfResale"></see>
    /// </summary>
    let typeOfResale =
        Namespaced_IRI.parse _namespace_name "typeOfResale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#underpass"></see>
    /// </summary>
    let underpass = Namespaced_IRI.parse _namespace_name "underpass" |> NamespacedName
    /// <summary>
    /// the generation time of a new weather report
    /// <see href="http://www.disit.org/km4city/schema#updateTime"></see></summary>
    let updateTime = Namespaced_IRI.parse _namespace_name "updateTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#uuid"></see>
    /// </summary>
    let uuid = Namespaced_IRI.parse _namespace_name "uuid" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#uv"></see>
    /// </summary>
    let uv = Namespaced_IRI.parse _namespace_name "uv" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#validityStatus"></see>
    /// </summary>
    let validityStatus =
        Namespaced_IRI.parse _namespace_name "validityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// numero di riconoscimento mezzo per azineda TPL
    /// <see href="http://www.disit.org/km4city/schema#vehicle"></see></summary>
    let vehicle = Namespaced_IRI.parse _namespace_name "vehicle" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#width"></see>
    /// </summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#wind"></see>
    /// </summary>
    let wind = Namespaced_IRI.parse _namespace_name "wind" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#yardType"></see>
    /// </summary>
    let yardType = Namespaced_IRI.parse _namespace_name "yardType" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
