namespace http.www.disit.org.km4city.schema.hash

open DoxAletheia

module km4c =
    let _namespace_name = "http://www.disit.org/km4city/schema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Corsa programmata da una certa azienda TPL su un certo percorso di una certa linea
    /// <see href="http://www.disit.org/km4city/schema#AVMRecord"></see></summary>
    let AVMRecord = _prefix "AVMRecord"
    /// <summary>
    /// Percorso che percorre un mezzo di trasporto pubblico
    /// <see href="http://www.disit.org/km4city/schema#Route"></see></summary>
    let Route = _prefix "Route"
    /// <summary>
    /// rides and AVMrecords refer to a specific route
    /// <see href="http://www.disit.org/km4city/schema#onRoute"></see></summary>
    let onRoute = _prefix "onRoute"
    /// <summary>
    /// Alberghi e strutture simili
    /// <see href="http://www.disit.org/km4city/schema#Accommodation"></see></summary>
    let Accommodation = _prefix "Accommodation"
    /// <summary>
    /// attivita' commerciali, servizi al cittadino, uffici...che possono essere localizzati in un punto
    /// <see href="http://www.disit.org/km4city/schema#Service"></see></summary>
    let Service = _prefix "Service"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Accommodation_or_office_containers_rental"></see>
    /// </summary>
    let Accommodation_or_office_containers_rental =
        _prefix "Accommodation_or_office_containers_rental"

    /// <summary>
    /// Fornitura di utenze e servizi
    /// <see href="http://www.disit.org/km4city/schema#UtilitiesAndSupply"></see></summary>
    let UtilitiesAndSupply = _prefix "UtilitiesAndSupply"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Accountants"></see>
    /// </summary>
    let Accountants = _prefix "Accountants"
    /// <summary>
    /// banche, istituti monetari e altri servizi finanziari
    /// <see href="http://www.disit.org/km4city/schema#FinancialService"></see></summary>
    let FinancialService = _prefix "FinancialService"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Addiction_recovery_centre"></see>
    /// </summary>
    let Addiction_recovery_centre = _prefix "Addiction_recovery_centre"
    /// <summary>
    /// ospedali, studi medici, laboratori analisi e altre strutture che forniscono servizi sanitari
    /// <see href="http://www.disit.org/km4city/schema#HealthCare"></see></summary>
    let HealthCare = _prefix "HealthCare"
    /// <summary>
    /// Classe le cui istanze sono le estese amministrative definite nel grafo stradale
    /// <see href="http://www.disit.org/km4city/schema#AdministrativeRoad"></see></summary>
    let AdministrativeRoad = _prefix "AdministrativeRoad"
    /// <summary>
    /// Classe le cui istanze sono gli elementi che compongono le strade
    /// <see href="http://www.disit.org/km4city/schema#RoadElement"></see></summary>
    let RoadElement = _prefix "RoadElement"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Adult_clothing"></see>
    /// </summary>
    let Adult_clothing = _prefix "Adult_clothing"
    /// <summary>
    /// negozi, centri commerciali, spacci, ogni forma di attivita' di vendita al pubblico
    /// <see href="http://www.disit.org/km4city/schema#ShoppingAndService"></see></summary>
    let ShoppingAndService = _prefix "ShoppingAndService"
    /// <summary>
    /// Servizi legati al mondo della pubblicita'
    /// <see href="http://www.disit.org/km4city/schema#Advertising"></see></summary>
    let Advertising = _prefix "Advertising"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Advertising_and_promotion"></see>
    /// </summary>
    let Advertising_and_promotion = _prefix "Advertising_and_promotion"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Agents"></see>
    /// </summary>
    let Agents = _prefix "Agents"
    /// <summary>
    /// Attivita' e servizi relativi ad agricoltura ed allevamento
    /// <see href="http://www.disit.org/km4city/schema#AgricultureAndLivestock"></see></summary>
    let AgricultureAndLivestock = _prefix "AgricultureAndLivestock"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Agritourism"></see>
    /// </summary>
    let Agritourism = _prefix "Agritourism"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Airfields"></see>
    /// </summary>
    let Airfields = _prefix "Airfields"
    /// <summary>
    /// Parcheggi auto, stazioni ferroviarie o degli autobus, tutto cio' che deve essere localizzato su una mappa e fa riferimento al trasporto
    /// <see href="http://www.disit.org/km4city/schema#TransferServiceAndRenting"></see></summary>
    let TransferServiceAndRenting = _prefix "TransferServiceAndRenting"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Airplanes_rental"></see>
    /// </summary>
    let Airplanes_rental = _prefix "Airplanes_rental"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Airport_lost_property_office"></see>
    /// </summary>
    let Airport_lost_property_office = _prefix "Airport_lost_property_office"
    /// <summary>
    /// Uffici aperti al pubblico
    /// <see href="http://www.disit.org/km4city/schema#GovernmentOffice"></see></summary>
    let GovernmentOffice = _prefix "GovernmentOffice"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Amusement_activities"></see>
    /// </summary>
    let Amusement_activities = _prefix "Amusement_activities"
    /// <summary>
    /// Servizi per l'intrattenimento del cittadino
    /// <see href="http://www.disit.org/km4city/schema#Entertainment"></see></summary>
    let Entertainment = _prefix "Entertainment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Amusement_and_theme_parks"></see>
    /// </summary>
    let Amusement_and_theme_parks = _prefix "Amusement_and_theme_parks"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Animal_feeds_manufacture"></see>
    /// </summary>
    let Animal_feeds_manufacture = _prefix "Animal_feeds_manufacture"
    /// <summary>
    /// Servizi legati all'industria e al lavoro
    /// <see href="http://www.disit.org/km4city/schema#IndustryAndManufacturing"></see></summary>
    let IndustryAndManufacturing = _prefix "IndustryAndManufacturing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Animal_production"></see>
    /// </summary>
    let Animal_production = _prefix "Animal_production"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Antiques"></see>
    /// </summary>
    let Antiques = _prefix "Antiques"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Aquarium"></see>
    /// </summary>
    let Aquarium = _prefix "Aquarium"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Archaeological_site"></see>
    /// </summary>
    let Archaeological_site = _prefix "Archaeological_site"
    /// <summary>
    /// biblioteche, archivi, musei ed altre attivita' culturali
    /// <see href="http://www.disit.org/km4city/schema#CulturalActivity"></see></summary>
    let CulturalActivity = _prefix "CulturalActivity"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Architectural_consulting"></see>
    /// </summary>
    let Architectural_consulting = _prefix "Architectural_consulting"
    /// <summary>
    /// Servizi legati all'ingegneria civile ed edile
    /// <see href="http://www.disit.org/km4city/schema#CivilAndEdilEngineering"></see></summary>
    let CivilAndEdilEngineering = _prefix "CivilAndEdilEngineering"
    /// <summary>
    /// Servizi rappresentati da un'area di forma poligonale
    /// <see href="http://www.disit.org/km4city/schema#Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Art_galleries"></see>
    /// </summary>
    let Art_galleries = _prefix "Art_galleries"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Artisan_shop"></see>
    /// </summary>
    let Artisan_shop = _prefix "Artisan_shop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Associations"></see>
    /// </summary>
    let Associations = _prefix "Associations"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Atm"></see>
    /// </summary>
    let Atm = _prefix "Atm"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Auctioning_houses"></see>
    /// </summary>
    let Auctioning_houses = _prefix "Auctioning_houses"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Audio_and_video"></see>
    /// </summary>
    let Audio_and_video = _prefix "Audio_and_video"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Auditing_activities"></see>
    /// </summary>
    let Auditing_activities = _prefix "Auditing_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Auditorium"></see>
    /// </summary>
    let Auditorium = _prefix "Auditorium"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Automobile_driving_and_flying_schools"></see>
    /// </summary>
    let Automobile_driving_and_flying_schools =
        _prefix "Automobile_driving_and_flying_schools"

    /// <summary>
    /// Servizi quali scuole per ogni eta' e scuole di formazione
    /// <see href="http://www.disit.org/km4city/schema#EducationAndResearch"></see></summary>
    let EducationAndResearch = _prefix "EducationAndResearch"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bakery"></see>
    /// </summary>
    let Bakery = _prefix "Bakery"
    /// <summary>
    /// Ristoranti, enoteche e tutte le altre attivita' enogastronomiche
    /// <see href="http://www.disit.org/km4city/schema#WineAndFood"></see></summary>
    let WineAndFood = _prefix "WineAndFood"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bank"></see>
    /// </summary>
    let Bank = _prefix "Bank"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bar"></see>
    /// </summary>
    let Bar = _prefix "Bar"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Beach_resort"></see>
    /// </summary>
    let Beach_resort = _prefix "Beach_resort"
    /// <summary>
    /// Servizio associato ai Beacon che permettono di ricevere offerte
    /// Singolo beacon installato
    /// <see href="http://www.disit.org/km4city/schema#Beacon"></see></summary>
    let Beacon = _prefix "Beacon"
    /// <summary>
    /// attivita' dei servizi delle agenzie di viaggio, tour operator e servizi prenotazione
    /// <see href="http://www.disit.org/km4city/schema#TourismService"></see></summary>
    let TourismService = _prefix "TourismService"
    /// <summary>
    /// lettura proveniente da un singolo beacon
    /// <see href="http://www.disit.org/km4city/schema#BeaconObservation"></see></summary>
    let BeaconObservation = _prefix "BeaconObservation"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Beauty_centre"></see>
    /// </summary>
    let Beauty_centre = _prefix "Beauty_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bed_and_breakfast"></see>
    /// </summary>
    let Bed_and_breakfast = _prefix "Bed_and_breakfast"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Betting_shops"></see>
    /// </summary>
    let Betting_shops = _prefix "Betting_shops"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Beverage_manufacture"></see>
    /// </summary>
    let Beverage_manufacture = _prefix "Beverage_manufacture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bike_rack"></see>
    /// </summary>
    let Bike_rack = _prefix "Bike_rack"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bike_rental"></see>
    /// </summary>
    let Bike_rental = _prefix "Bike_rental"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Boarding_house"></see>
    /// </summary>
    let Boarding_house = _prefix "Boarding_house"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Boat_equipment"></see>
    /// </summary>
    let Boat_equipment = _prefix "Boat_equipment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Boats_and_ships_rental"></see>
    /// </summary>
    let Boats_and_ships_rental = _prefix "Boats_and_ships_rental"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bookshop"></see>
    /// </summary>
    let Bookshop = _prefix "Bookshop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Botanical_and_zoological_gardens"></see>
    /// </summary>
    let Botanical_and_zoological_gardens = _prefix "Botanical_and_zoological_gardens"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Boxoffice"></see>
    /// </summary>
    let Boxoffice = _prefix "Boxoffice"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Building_and_industrial_cleaning_activities"></see>
    /// </summary>
    let Building_and_industrial_cleaning_activities =
        _prefix "Building_and_industrial_cleaning_activities"

    /// <summary>
    /// Servizi legati all'ambiente
    /// <see href="http://www.disit.org/km4city/schema#Environment"></see></summary>
    let Environment = _prefix "Environment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Building_construction"></see>
    /// </summary>
    let Building_construction = _prefix "Building_construction"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Building_material"></see>
    /// </summary>
    let Building_material = _prefix "Building_material"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Building_materials_manufacture"></see>
    /// </summary>
    let Building_materials_manufacture = _prefix "Building_materials_manufacture"
    /// <summary>
    /// Punto di interconnessione tra segmenti di strada per determinare il percorso di una linea di TPL
    /// Servizio associato alla visualizzazione delle linee ATAF con le relative fermate
    /// <see href="http://www.disit.org/km4city/schema#BusStop"></see></summary>
    let BusStop = _prefix "BusStop"
    /// <summary>
    /// previsione di arrivo ad una certa fermata
    /// <see href="http://www.disit.org/km4city/schema#BusStopForecast"></see></summary>
    let BusStopForecast = _prefix "BusStopForecast"
    /// <summary>
    /// each forecast refers to a specific bus stop
    /// <see href="http://www.disit.org/km4city/schema#atBusStop"></see></summary>
    let atBusStop = _prefix "atBusStop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Bus_tickets_retail"></see>
    /// </summary>
    let Bus_tickets_retail = _prefix "Bus_tickets_retail"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Business_support"></see>
    /// </summary>
    let Business_support = _prefix "Business_support"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Call_center"></see>
    /// </summary>
    let Call_center = _prefix "Call_center"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Camper_service"></see>
    /// </summary>
    let Camper_service = _prefix "Camper_service"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Camping"></see>
    /// </summary>
    let Camping = _prefix "Camping"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Canteens_and_food_service"></see>
    /// </summary>
    let Canteens_and_food_service = _prefix "Canteens_and_food_service"
    /// <summary>
    /// Sensore che raccoglie i dati all'interno di un parcheggio
    /// <see href="http://www.disit.org/km4city/schema#CarParkSensor"></see></summary>
    let CarParkSensor = _prefix "CarParkSensor"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Car_park"></see>
    /// </summary>
    let Car_park = _prefix "Car_park"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Car_rental_with_driver"></see>
    /// </summary>
    let Car_rental_with_driver = _prefix "Car_rental_with_driver"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Car_washing"></see>
    /// </summary>
    let Car_washing = _prefix "Car_washing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Carabinieri"></see>
    /// </summary>
    let Carabinieri = _prefix "Carabinieri"
    /// <summary>
    /// Contiene tutte le classi relative ai servizi di emergenza
    /// <see href="http://www.disit.org/km4city/schema#Emergency"></see></summary>
    let Emergency = _prefix "Emergency"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cargo_handling"></see>
    /// </summary>
    let Cargo_handling = _prefix "Cargo_handling"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Carpentry"></see>
    /// </summary>
    let Carpentry = _prefix "Carpentry"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Carpets"></see>
    /// </summary>
    let Carpets = _prefix "Carpets"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Carpets_and_curtains"></see>
    /// </summary>
    let Carpets_and_curtains = _prefix "Carpets_and_curtains"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cartographers"></see>
    /// </summary>
    let Cartographers = _prefix "Cartographers"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Catering"></see>
    /// </summary>
    let Catering = _prefix "Catering"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Charging_stations"></see>
    /// </summary>
    let Charging_stations = _prefix "Charging_stations"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Charter_airlines"></see>
    /// </summary>
    let Charter_airlines = _prefix "Charter_airlines"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Churches"></see>
    /// </summary>
    let Churches = _prefix "Churches"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cinema"></see>
    /// </summary>
    let Cinema = _prefix "Cinema"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Civil_airport"></see>
    /// </summary>
    let Civil_airport = _prefix "Civil_airport"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Civil_engineering"></see>
    /// </summary>
    let Civil_engineering = _prefix "Civil_engineering"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Civil_protection"></see>
    /// </summary>
    let Civil_protection = _prefix "Civil_protection"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Civil_registry"></see>
    /// </summary>
    let Civil_registry = _prefix "Civil_registry"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cleaning_activities"></see>
    /// </summary>
    let Cleaning_activities = _prefix "Cleaning_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cleaning_materials"></see>
    /// </summary>
    let Cleaning_materials = _prefix "Cleaning_materials"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Climbing"></see>
    /// </summary>
    let Climbing = _prefix "Climbing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing"></see>
    /// </summary>
    let Clothing = _prefix "Clothing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing_accessories"></see>
    /// </summary>
    let Clothing_accessories = _prefix "Clothing_accessories"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing_and_linen"></see>
    /// </summary>
    let Clothing_and_linen = _prefix "Clothing_and_linen"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing_children_and_infants"></see>
    /// </summary>
    let Clothing_children_and_infants = _prefix "Clothing_children_and_infants"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Clothing_factory_outlet"></see>
    /// </summary>
    let Clothing_factory_outlet = _prefix "Clothing_factory_outlet"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Coast_guard_harbormaster"></see>
    /// </summary>
    let Coast_guard_harbormaster = _prefix "Coast_guard_harbormaster"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Coffee_rosters"></see>
    /// </summary>
    let Coffee_rosters = _prefix "Coffee_rosters"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Coke_and_petroleum_derivatives"></see>
    /// </summary>
    let Coke_and_petroleum_derivatives = _prefix "Coke_and_petroleum_derivatives"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Combined_facilities_support_activities"></see>
    /// </summary>
    let Combined_facilities_support_activities =
        _prefix "Combined_facilities_support_activities"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Commissariat_of_public_safety"></see>
    /// </summary>
    let Commissariat_of_public_safety = _prefix "Commissariat_of_public_safety"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Community_centre"></see>
    /// </summary>
    let Community_centre = _prefix "Community_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Computer_data_processing"></see>
    /// </summary>
    let Computer_data_processing = _prefix "Computer_data_processing"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Computer_programming_and_consultancy"></see>
    /// </summary>
    let Computer_programming_and_consultancy =
        _prefix "Computer_programming_and_consultancy"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Computer_systems"></see>
    /// </summary>
    let Computer_systems = _prefix "Computer_systems"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Computer_technician"></see>
    /// </summary>
    let Computer_technician = _prefix "Computer_technician"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Conservatory"></see>
    /// </summary>
    let Conservatory = _prefix "Conservatory"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Consulate"></see>
    /// </summary>
    let Consulate = _prefix "Consulate"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Consulting_services"></see>
    /// </summary>
    let Consulting_services = _prefix "Consulting_services"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Controlled_parking_zone"></see>
    /// </summary>
    let Controlled_parking_zone = _prefix "Controlled_parking_zone"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Corps_of_forest_rangers"></see>
    /// </summary>
    let Corps_of_forest_rangers = _prefix "Corps_of_forest_rangers"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Courier"></see>
    /// </summary>
    let Courier = _prefix "Courier"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Credit_collection_agencies"></see>
    /// </summary>
    let Credit_collection_agencies = _prefix "Credit_collection_agencies"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Crop_animal_production_hunting"></see>
    /// </summary>
    let Crop_animal_production_hunting = _prefix "Crop_animal_production_hunting"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Crop_production"></see>
    /// </summary>
    let Crop_production = _prefix "Crop_production"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cultural_and_recreation_goods"></see>
    /// </summary>
    let Cultural_and_recreation_goods = _prefix "Cultural_and_recreation_goods"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cultural_centre"></see>
    /// </summary>
    let Cultural_centre = _prefix "Cultural_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cultural_education"></see>
    /// </summary>
    let Cultural_education = _prefix "Cultural_education"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cultural_sites"></see>
    /// </summary>
    let Cultural_sites = _prefix "Cultural_sites"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Curtains_and_net_curtains"></see>
    /// </summary>
    let Curtains_and_net_curtains = _prefix "Curtains_and_net_curtains"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Cycle_paths"></see>
    /// </summary>
    let Cycle_paths = _prefix "Cycle_paths"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dairy_products"></see>
    /// </summary>
    let Dairy_products = _prefix "Dairy_products"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dance_schools"></see>
    /// </summary>
    let Dance_schools = _prefix "Dance_schools"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dating_service"></see>
    /// </summary>
    let Dating_service = _prefix "Dating_service"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Day_care_centre"></see>
    /// </summary>
    let Day_care_centre = _prefix "Day_care_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dentist"></see>
    /// </summary>
    let Dentist = _prefix "Dentist"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Department_of_motor_vehicles"></see>
    /// </summary>
    let Department_of_motor_vehicles = _prefix "Department_of_motor_vehicles"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Diet_products"></see>
    /// </summary>
    let Diet_products = _prefix "Diet_products"
    /// <summary>
    /// Servizi classificati dal comune di Firenze come Digital Location
    /// <see href="http://www.disit.org/km4city/schema#DigitalLocation"></see></summary>
    let DigitalLocation = _prefix "DigitalLocation"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Dining_hall"></see>
    /// </summary>
    let Dining_hall = _prefix "Dining_hall"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Discotheque"></see>
    /// </summary>
    let Discotheque = _prefix "Discotheque"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Discount"></see>
    /// </summary>
    let Discount = _prefix "Discount"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Disinfecting_and_exterminating_activities"></see>
    /// </summary>
    let Disinfecting_and_exterminating_activities =
        _prefix "Disinfecting_and_exterminating_activities"

    /// <summary>
    /// Zona che rappresenta l'estensione di un quartiere
    /// <see href="http://www.disit.org/km4city/schema#District"></see></summary>
    let District = _prefix "District"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Diving_school"></see>
    /// </summary>
    let Diving_school = _prefix "Diving_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Doctor_office"></see>
    /// </summary>
    let Doctor_office = _prefix "Doctor_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Door_to_door"></see>
    /// </summary>
    let Door_to_door = _prefix "Door_to_door"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Drinking_fountain"></see>
    /// </summary>
    let Drinking_fountain = _prefix "Drinking_fountain"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Educational_support_activities"></see>
    /// </summary>
    let Educational_support_activities = _prefix "Educational_support_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Emergency_medical_care"></see>
    /// </summary>
    let Emergency_medical_care = _prefix "Emergency_medical_care"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Emergency_services"></see>
    /// </summary>
    let Emergency_services = _prefix "Emergency_services"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Employment_exchange"></see>
    /// </summary>
    let Employment_exchange = _prefix "Employment_exchange"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Energy_supply"></see>
    /// </summary>
    let Energy_supply = _prefix "Energy_supply"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Engineering_consulting"></see>
    /// </summary>
    let Engineering_consulting = _prefix "Engineering_consulting"
    /// <summary>
    /// Classe le cui istanze sono i possibili ingressi ai numeri civici
    /// <see href="http://www.disit.org/km4city/schema#Entry"></see></summary>
    let Entry = _prefix "Entry"
    /// <summary>
    /// Classe le cui istanze sono i numeri civici conosciuti
    /// <see href="http://www.disit.org/km4city/schema#StreetNumber"></see></summary>
    let StreetNumber = _prefix "StreetNumber"
    /// <summary>
    /// Classe le cui istanze sono le regole di accesso ai differenti elementi stradali
    /// <see href="http://www.disit.org/km4city/schema#EntryRule"></see></summary>
    let EntryRule = _prefix "EntryRule"
    /// <summary>
    /// an entry rule refers to a specific Road element
    /// <see href="http://www.disit.org/km4city/schema#accessToElement"></see></summary>
    let accessToElement = _prefix "accessToElement"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Equipment_for_events_and_shows_rental"></see>
    /// </summary>
    let Equipment_for_events_and_shows_rental =
        _prefix "Equipment_for_events_and_shows_rental"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Estate_activities"></see>
    /// </summary>
    let Estate_activities = _prefix "Estate_activities"
    /// <summary>
    /// Eventi programmati dal comune di firenze e dintormi
    /// <see href="http://www.disit.org/km4city/schema#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Extraction_of_natural_gas"></see>
    /// </summary>
    let Extraction_of_natural_gas = _prefix "Extraction_of_natural_gas"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Extraction_of_salt"></see>
    /// </summary>
    let Extraction_of_salt = _prefix "Extraction_of_salt"
    /// <summary>
    /// Servizi legati alle attivita' di estrazione e cave
    /// <see href="http://www.disit.org/km4city/schema#MiningAndQuarrying"></see></summary>
    let MiningAndQuarrying = _prefix "MiningAndQuarrying"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Family_counselling"></see>
    /// </summary>
    let Family_counselling = _prefix "Family_counselling"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Farm_house"></see>
    /// </summary>
    let Farm_house = _prefix "Farm_house"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Financial_institute"></see>
    /// </summary>
    let Financial_institute = _prefix "Financial_institute"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fine_arts_articles"></see>
    /// </summary>
    let Fine_arts_articles = _prefix "Fine_arts_articles"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fire_brigade"></see>
    /// </summary>
    let Fire_brigade = _prefix "Fire_brigade"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#First_aid"></see>
    /// </summary>
    let First_aid = _prefix "First_aid"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fish_and_seafood"></see>
    /// </summary>
    let Fish_and_seafood = _prefix "Fish_and_seafood"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fishing_and_aquaculture"></see>
    /// </summary>
    let Fishing_and_aquaculture = _prefix "Fishing_and_aquaculture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fishing_reserve"></see>
    /// </summary>
    let Fishing_reserve = _prefix "Fishing_reserve"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Flight_companies"></see>
    /// </summary>
    let Flight_companies = _prefix "Flight_companies"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Flower_shop"></see>
    /// </summary>
    let Flower_shop = _prefix "Flower_shop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Food_and_ice_cream_truck"></see>
    /// </summary>
    let Food_and_ice_cream_truck = _prefix "Food_and_ice_cream_truck"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Food_and_tobacconist"></see>
    /// </summary>
    let Food_and_tobacconist = _prefix "Food_and_tobacconist"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Food_manufacture"></see>
    /// </summary>
    let Food_manufacture = _prefix "Food_manufacture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Food_trade"></see>
    /// </summary>
    let Food_trade = _prefix "Food_trade"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Footwear_and_accessories"></see>
    /// </summary>
    let Footwear_and_accessories = _prefix "Footwear_and_accessories"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Footwear_and_leather_goods"></see>
    /// </summary>
    let Footwear_and_leather_goods = _prefix "Footwear_and_leather_goods"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Footwear_factory_outlet"></see>
    /// </summary>
    let Footwear_factory_outlet = _prefix "Footwear_factory_outlet"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Footwear_manufacture"></see>
    /// </summary>
    let Footwear_manufacture = _prefix "Footwear_manufacture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Forestry"></see>
    /// </summary>
    let Forestry = _prefix "Forestry"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Freight_transport_and_furniture_removal"></see>
    /// </summary>
    let Freight_transport_and_furniture_removal =
        _prefix "Freight_transport_and_furniture_removal"

    /// <summary>
    /// Luoghi in cui e' possibile sedere all'aria condizionata durante l'estate
    /// <see href="http://www.disit.org/km4city/schema#Fresh_place"></see></summary>
    let Fresh_place = _prefix "Fresh_place"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Frozen_food"></see>
    /// </summary>
    let Frozen_food = _prefix "Frozen_food"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fruit_and_vegetables"></see>
    /// </summary>
    let Fruit_and_vegetables = _prefix "Fruit_and_vegetables"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fuel_station"></see>
    /// </summary>
    let Fuel_station = _prefix "Fuel_station"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Funeral"></see>
    /// </summary>
    let Funeral = _prefix "Funeral"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Funeral_and_cemetery_articles"></see>
    /// </summary>
    let Funeral_and_cemetery_articles = _prefix "Funeral_and_cemetery_articles"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Fur_and_leather_clothing"></see>
    /// </summary>
    let Fur_and_leather_clothing = _prefix "Fur_and_leather_clothing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Gambling_and_betting"></see>
    /// </summary>
    let Gambling_and_betting = _prefix "Gambling_and_betting"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Game_reserve"></see>
    /// </summary>
    let Game_reserve = _prefix "Game_reserve"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Game_room"></see>
    /// </summary>
    let Game_room = _prefix "Game_room"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Games_and_toys"></see>
    /// </summary>
    let Games_and_toys = _prefix "Games_and_toys"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Garden_and_agriculture"></see>
    /// </summary>
    let Garden_and_agriculture = _prefix "Garden_and_agriculture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Gardens"></see>
    /// </summary>
    let Gardens = _prefix "Gardens"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Geologists"></see>
    /// </summary>
    let Geologists = _prefix "Geologists"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Gifts_and_smoking_articles"></see>
    /// </summary>
    let Gifts_and_smoking_articles = _prefix "Gifts_and_smoking_articles"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Golf"></see>
    /// </summary>
    let Golf = _prefix "Golf"
    /// <summary>
    /// Scalo Merci, sono posizionati in corrispondenza di giunzioni ferroviarie con relazione 1:1
    /// <see href="http://www.disit.org/km4city/schema#GoodsYard"></see></summary>
    let GoodsYard = _prefix "GoodsYard"
    /// <summary>
    /// 2 giunzioni delimitano un elemento ferroviario e rappresentano stazioni ferroviarie o scali merce
    /// <see href="http://www.disit.org/km4city/schema#RailwayJunction"></see></summary>
    let RailwayJunction = _prefix "RailwayJunction"
    /// <summary>
    /// train station and good yard are located precisely on a junction
    /// <see href="http://www.disit.org/km4city/schema#correspondToJunction"></see></summary>
    let correspondToJunction = _prefix "correspondToJunction"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Green_areas"></see>
    /// </summary>
    let Green_areas = _prefix "Green_areas"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Grill"></see>
    /// </summary>
    let Grill = _prefix "Grill"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Group_practice"></see>
    /// </summary>
    let Group_practice = _prefix "Group_practice"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Gym_fitness"></see>
    /// </summary>
    let Gym_fitness = _prefix "Gym_fitness"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Haberdashery"></see>
    /// </summary>
    let Haberdashery = _prefix "Haberdashery"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Haircare_centres"></see>
    /// </summary>
    let Haircare_centres = _prefix "Haircare_centres"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hairdressing"></see>
    /// </summary>
    let Hairdressing = _prefix "Hairdressing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hairdressing_and_beauty_treatment"></see>
    /// </summary>
    let Hairdressing_and_beauty_treatment = _prefix "Hairdressing_and_beauty_treatment"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hardware_electrical_plumbing_and_heating"></see>
    /// </summary>
    let Hardware_electrical_plumbing_and_heating =
        _prefix "Hardware_electrical_plumbing_and_heating"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hardware_paints_and_glass"></see>
    /// </summary>
    let Hardware_paints_and_glass = _prefix "Hardware_paints_and_glass"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Health_district"></see>
    /// </summary>
    let Health_district = _prefix "Health_district"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Health_reservations_centre"></see>
    /// </summary>
    let Health_reservations_centre = _prefix "Health_reservations_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Healthcare_centre"></see>
    /// </summary>
    let Healthcare_centre = _prefix "Healthcare_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Helipads"></see>
    /// </summary>
    let Helipads = _prefix "Helipads"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Herbalists_shop"></see>
    /// </summary>
    let Herbalists_shop = _prefix "Herbalists_shop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Higher_education"></see>
    /// </summary>
    let Higher_education = _prefix "Higher_education"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Highway_stop"></see>
    /// </summary>
    let Highway_stop = _prefix "Highway_stop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hippodrome"></see>
    /// </summary>
    let Hippodrome = _prefix "Hippodrome"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Historic_residence"></see>
    /// </summary>
    let Historic_residence = _prefix "Historic_residence"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Historical_buildings"></see>
    /// </summary>
    let Historical_buildings = _prefix "Historical_buildings"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Holiday_village"></see>
    /// </summary>
    let Holiday_village = _prefix "Holiday_village"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hostel"></see>
    /// </summary>
    let Hostel = _prefix "Hostel"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hotel"></see>
    /// </summary>
    let Hotel = _prefix "Hotel"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_appliances_shop"></see>
    /// </summary>
    let Household_appliances_shop = _prefix "Household_appliances_shop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_articles"></see>
    /// </summary>
    let Household_articles = _prefix "Household_articles"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_fuel"></see>
    /// </summary>
    let Household_fuel = _prefix "Household_fuel"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_furniture"></see>
    /// </summary>
    let Household_furniture = _prefix "Household_furniture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_products"></see>
    /// </summary>
    let Household_products = _prefix "Household_products"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Household_utensils"></see>
    /// </summary>
    let Household_utensils = _prefix "Household_utensils"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Human_health_activities"></see>
    /// </summary>
    let Human_health_activities = _prefix "Human_health_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hunting_trapping_and_services"></see>
    /// </summary>
    let Hunting_trapping_and_services = _prefix "Hunting_trapping_and_services"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Hypermarket"></see>
    /// </summary>
    let Hypermarket = _prefix "Hypermarket"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#ICT_service"></see>
    /// </summary>
    let ICT_service = _prefix "ICT_service"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Ice_cream_parlour"></see>
    /// </summary>
    let Ice_cream_parlour = _prefix "Ice_cream_parlour"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Income_revenue_authority"></see>
    /// </summary>
    let Income_revenue_authority = _prefix "Income_revenue_authority"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Industrial_laundries"></see>
    /// </summary>
    let Industrial_laundries = _prefix "Industrial_laundries"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Installation_of_industrial_machinery"></see>
    /// </summary>
    let Installation_of_industrial_machinery =
        _prefix "Installation_of_industrial_machinery"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Insurance"></see>
    /// </summary>
    let Insurance = _prefix "Insurance"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Insurance_and_financial"></see>
    /// </summary>
    let Insurance_and_financial = _prefix "Insurance_and_financial"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Internet_point_and_public_telephone"></see>
    /// </summary>
    let Internet_point_and_public_telephone =
        _prefix "Internet_point_and_public_telephone"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Internet_service_provider"></see>
    /// </summary>
    let Internet_service_provider = _prefix "Internet_service_provider"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Investigation_activities"></see>
    /// </summary>
    let Investigation_activities = _prefix "Investigation_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Italian_finance_police"></see>
    /// </summary>
    let Italian_finance_police = _prefix "Italian_finance_police"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Jeweller"></see>
    /// </summary>
    let Jeweller = _prefix "Jeweller"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Jewellery"></see>
    /// </summary>
    let Jewellery = _prefix "Jewellery"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Journalist"></see>
    /// </summary>
    let Journalist = _prefix "Journalist"
    /// <summary>
    /// Punto di interconnessione tra segmenti di strada per disegnare un RoadElement
    /// <see href="http://www.disit.org/km4city/schema#Junction"></see></summary>
    let Junction = _prefix "Junction"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Knitted_manufacture"></see>
    /// </summary>
    let Knitted_manufacture = _prefix "Knitted_manufacture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Labour_consultant"></see>
    /// </summary>
    let Labour_consultant = _prefix "Labour_consultant"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Land_transport"></see>
    /// </summary>
    let Land_transport = _prefix "Land_transport"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Land_transport_rental"></see>
    /// </summary>
    let Land_transport_rental = _prefix "Land_transport_rental"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Landscape_care"></see>
    /// </summary>
    let Landscape_care = _prefix "Landscape_care"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Language_courses"></see>
    /// </summary>
    let Language_courses = _prefix "Language_courses"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Laundries_and_dry_cleaners"></see>
    /// </summary>
    let Laundries_and_dry_cleaners = _prefix "Laundries_and_dry_cleaners"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Leasing_of_intellectual_property"></see>
    /// </summary>
    let Leasing_of_intellectual_property = _prefix "Leasing_of_intellectual_property"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Leather_manufacture"></see>
    /// </summary>
    let Leather_manufacture = _prefix "Leather_manufacture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Legal_office"></see>
    /// </summary>
    let Legal_office = _prefix "Legal_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Library"></see>
    /// </summary>
    let Library = _prefix "Library"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Lifting_and_handling_equipment_rental"></see>
    /// </summary>
    let Lifting_and_handling_equipment_rental =
        _prefix "Lifting_and_handling_equipment_rental"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Lighting"></see>
    /// </summary>
    let Lighting = _prefix "Lighting"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Literary_cafe"></see>
    /// </summary>
    let Literary_cafe = _prefix "Literary_cafe"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Local_health_authority"></see>
    /// </summary>
    let Local_health_authority = _prefix "Local_health_authority"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Local_police"></see>
    /// </summary>
    let Local_police = _prefix "Local_police"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Logistics_activities"></see>
    /// </summary>
    let Logistics_activities = _prefix "Logistics_activities"
    /// <summary>
    /// Insieme di linee TPL, individuabili a livello regionale come lotto
    /// <see href="http://www.disit.org/km4city/schema#Lot"></see></summary>
    let Lot = _prefix "Lot"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Machinery_and_equipment_rental"></see>
    /// </summary>
    let Machinery_and_equipment_rental = _prefix "Machinery_and_equipment_rental"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Machinery_repair_and_installation"></see>
    /// </summary>
    let Machinery_repair_and_installation = _prefix "Machinery_repair_and_installation"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Maintenance_repair_of_motor_vehicles"></see>
    /// </summary>
    let Maintenance_repair_of_motor_vehicles =
        _prefix "Maintenance_repair_of_motor_vehicles"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Maintenance_repair_of_motorcycles"></see>
    /// </summary>
    let Maintenance_repair_of_motorcycles = _prefix "Maintenance_repair_of_motorcycles"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Management_consultancy"></see>
    /// </summary>
    let Management_consultancy = _prefix "Management_consultancy"
    /// <summary>
    /// Classe le cui istanze sono le possibili manovre che possono essere effettuate su un elemento stradale
    /// <see href="http://www.disit.org/km4city/schema#Maneuver"></see></summary>
    let Maneuver = _prefix "Maneuver"
    /// <summary>
    /// the second element concerned the maneuver
    /// <see href="http://www.disit.org/km4city/schema#hasSecondElem"></see></summary>
    let hasSecondElem = _prefix "hasSecondElem"
    /// <summary>
    /// Classe le cui istanze sono i nodi che congiungono gli elementi stradali
    /// <see href="http://www.disit.org/km4city/schema#Node"></see></summary>
    let Node = _prefix "Node"
    /// <summary>
    /// a maneuver takes place in correspondence of a node
    /// <see href="http://www.disit.org/km4city/schema#concerningNode"></see></summary>
    let concerningNode = _prefix "concerningNode"
    /// <summary>
    /// the third element concerned the maneuver
    /// <see href="http://www.disit.org/km4city/schema#hasThirdElem"></see></summary>
    let hasThirdElem = _prefix "hasThirdElem"
    /// <summary>
    /// the first element concerned the maneuver
    /// <see href="http://www.disit.org/km4city/schema#hasFirstElem"></see></summary>
    let hasFirstElem = _prefix "hasFirstElem"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manicure_and_pedicure"></see>
    /// </summary>
    let Manicure_and_pedicure = _prefix "Manicure_and_pedicure"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_basic_metals"></see>
    /// </summary>
    let Manufacture_of_basic_metals = _prefix "Manufacture_of_basic_metals"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_chemicals_products"></see>
    /// </summary>
    let Manufacture_of_chemicals_products = _prefix "Manufacture_of_chemicals_products"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_clay_and_ceramic"></see>
    /// </summary>
    let Manufacture_of_clay_and_ceramic = _prefix "Manufacture_of_clay_and_ceramic"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_electrical_equipment"></see>
    /// </summary>
    let Manufacture_of_electrical_equipment =
        _prefix "Manufacture_of_electrical_equipment"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_electronic_products"></see>
    /// </summary>
    let Manufacture_of_electronic_products =
        _prefix "Manufacture_of_electronic_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_furniture"></see>
    /// </summary>
    let Manufacture_of_furniture = _prefix "Manufacture_of_furniture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_glass"></see>
    /// </summary>
    let Manufacture_of_glass = _prefix "Manufacture_of_glass"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_jewellery_bijouterie"></see>
    /// </summary>
    let Manufacture_of_jewellery_bijouterie =
        _prefix "Manufacture_of_jewellery_bijouterie"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_machinery_and_equipment"></see>
    /// </summary>
    let Manufacture_of_machinery_and_equipment =
        _prefix "Manufacture_of_machinery_and_equipment"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_motor_vehicles"></see>
    /// </summary>
    let Manufacture_of_motor_vehicles = _prefix "Manufacture_of_motor_vehicles"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_musical_instruments"></see>
    /// </summary>
    let Manufacture_of_musical_instruments =
        _prefix "Manufacture_of_musical_instruments"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_non_metallic_mineral_products"></see>
    /// </summary>
    let Manufacture_of_non_metallic_mineral_products =
        _prefix "Manufacture_of_non_metallic_mineral_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_paper"></see>
    /// </summary>
    let Manufacture_of_paper = _prefix "Manufacture_of_paper"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_paper_products"></see>
    /// </summary>
    let Manufacture_of_paper_products = _prefix "Manufacture_of_paper_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_pharmaceutical_products"></see>
    /// </summary>
    let Manufacture_of_pharmaceutical_products =
        _prefix "Manufacture_of_pharmaceutical_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_plastics_products"></see>
    /// </summary>
    let Manufacture_of_plastics_products = _prefix "Manufacture_of_plastics_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_refined_petroleum_products"></see>
    /// </summary>
    let Manufacture_of_refined_petroleum_products =
        _prefix "Manufacture_of_refined_petroleum_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_refractory_products"></see>
    /// </summary>
    let Manufacture_of_refractory_products =
        _prefix "Manufacture_of_refractory_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_rubber_and_plastics_products"></see>
    /// </summary>
    let Manufacture_of_rubber_and_plastics_products =
        _prefix "Manufacture_of_rubber_and_plastics_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_rubber_products"></see>
    /// </summary>
    let Manufacture_of_rubber_products = _prefix "Manufacture_of_rubber_products"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_sports_goods"></see>
    /// </summary>
    let Manufacture_of_sports_goods = _prefix "Manufacture_of_sports_goods"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_structural_metal_products"></see>
    /// </summary>
    let Manufacture_of_structural_metal_products =
        _prefix "Manufacture_of_structural_metal_products"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_textiles"></see>
    /// </summary>
    let Manufacture_of_textiles = _prefix "Manufacture_of_textiles"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_toys_and_game"></see>
    /// </summary>
    let Manufacture_of_toys_and_game = _prefix "Manufacture_of_toys_and_game"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_transport_equipment"></see>
    /// </summary>
    let Manufacture_of_transport_equipment =
        _prefix "Manufacture_of_transport_equipment"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_travel_articles"></see>
    /// </summary>
    let Manufacture_of_travel_articles = _prefix "Manufacture_of_travel_articles"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_wearing_apparel"></see>
    /// </summary>
    let Manufacture_of_wearing_apparel = _prefix "Manufacture_of_wearing_apparel"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_wood"></see>
    /// </summary>
    let Manufacture_of_wood = _prefix "Manufacture_of_wood"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Manufacture_of_wood_products"></see>
    /// </summary>
    let Manufacture_of_wood_products = _prefix "Manufacture_of_wood_products"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Market_polling"></see>
    /// </summary>
    let Market_polling = _prefix "Market_polling"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Materials_recovery"></see>
    /// </summary>
    let Materials_recovery = _prefix "Materials_recovery"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Meat_and_poultry"></see>
    /// </summary>
    let Meat_and_poultry = _prefix "Meat_and_poultry"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mechanic_workshop"></see>
    /// </summary>
    let Mechanic_workshop = _prefix "Mechanic_workshop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Medical_analysis_laboratories"></see>
    /// </summary>
    let Medical_analysis_laboratories = _prefix "Medical_analysis_laboratories"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Medical_and_orthopaedic_goods"></see>
    /// </summary>
    let Medical_and_orthopaedic_goods = _prefix "Medical_and_orthopaedic_goods"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mental_health_centre"></see>
    /// </summary>
    let Mental_health_centre = _prefix "Mental_health_centre"
    /// <summary>
    /// Classe le cui istanze sono i cippi chilometrici che si trovano lungo le principali strade
    /// <see href="http://www.disit.org/km4city/schema#Milestone"></see></summary>
    let Milestone = _prefix "Milestone"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Minimarket"></see>
    /// </summary>
    let Minimarket = _prefix "Minimarket"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mining_of_metal_ores"></see>
    /// </summary>
    let Mining_of_metal_ores = _prefix "Mining_of_metal_ores"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mining_support_services"></see>
    /// </summary>
    let Mining_support_services = _prefix "Mining_support_services"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Monument_location"></see>
    /// </summary>
    let Monument_location = _prefix "Monument_location"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Motion_picture_and_television_programme_activities"></see>
    /// </summary>
    let Motion_picture_and_television_programme_activities =
        _prefix "Motion_picture_and_television_programme_activities"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Motor_Vehicles_wholesale_and_retail"></see>
    /// </summary>
    let Motor_Vehicles_wholesale_and_retail =
        _prefix "Motor_Vehicles_wholesale_and_retail"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Motorcycles_parts_wholesale_and_retail"></see>
    /// </summary>
    let Motorcycles_parts_wholesale_and_retail =
        _prefix "Motorcycles_parts_wholesale_and_retail"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Motorcycles_wholesale_and_retail"></see>
    /// </summary>
    let Motorcycles_wholesale_and_retail = _prefix "Motorcycles_wholesale_and_retail"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Mountain_shelter"></see>
    /// </summary>
    let Mountain_shelter = _prefix "Mountain_shelter"
    /// <summary>
    /// Classe le cui istanze sono i vari comuni
    /// <see href="http://www.disit.org/km4city/schema#Municipality"></see></summary>
    let Municipality = _prefix "Municipality"
    /// <summary>
    /// Comuni, regioni e provincie
    /// <see href="http://www.disit.org/km4city/schema#Pa"></see></summary>
    let Pa = _prefix "Pa"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Museum"></see>
    /// </summary>
    let Museum = _prefix "Museum"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Music_and_video_recordings"></see>
    /// </summary>
    let Music_and_video_recordings = _prefix "Music_and_video_recordings"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Musical_instruments_and_scores"></see>
    /// </summary>
    let Musical_instruments_and_scores = _prefix "Musical_instruments_and_scores"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#News_agency"></see>
    /// </summary>
    let News_agency = _prefix "News_agency"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Newspapers_and_stationery"></see>
    /// </summary>
    let Newspapers_and_stationery = _prefix "Newspapers_and_stationery"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Non_food_large_retailers"></see>
    /// </summary>
    let Non_food_large_retailers = _prefix "Non_food_large_retailers"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Non_food_products"></see>
    /// </summary>
    let Non_food_products = _prefix "Non_food_products"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Non_specialized_wholesale_trade"></see>
    /// </summary>
    let Non_specialized_wholesale_trade = _prefix "Non_specialized_wholesale_trade"
    /// <summary>
    /// Vendita all'ingrosso di qualsiasi cosa
    /// <see href="http://www.disit.org/km4city/schema#Wholesale"></see></summary>
    let Wholesale = _prefix "Wholesale"
    /// <summary>
    /// Singolo sensore per osservare velocita', traffico, concentrazione o densita'
    /// <see href="http://www.disit.org/km4city/schema#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Office_Furniture"></see>
    /// </summary>
    let Office_Furniture = _prefix "Office_Furniture"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Office_administrative_and_support_activities"></see>
    /// </summary>
    let Office_administrative_and_support_activities =
        _prefix "Office_administrative_and_support_activities"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Operation_of_casinos"></see>
    /// </summary>
    let Operation_of_casinos = _prefix "Operation_of_casinos"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Optics_and_photography"></see>
    /// </summary>
    let Optics_and_photography = _prefix "Optics_and_photography"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Organization_of_conventions_and_trade_shows"></see>
    /// </summary>
    let Organization_of_conventions_and_trade_shows =
        _prefix "Organization_of_conventions_and_trade_shows"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_accommodation"></see>
    /// </summary>
    let Other_accommodation = _prefix "Other_accommodation"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_broadcasting"></see>
    /// </summary>
    let Other_broadcasting = _prefix "Other_broadcasting"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_goods"></see>
    /// </summary>
    let Other_goods = _prefix "Other_goods"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_manufacturing"></see>
    /// </summary>
    let Other_manufacturing = _prefix "Other_manufacturing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_mining_and_quarrying"></see>
    /// </summary>
    let Other_mining_and_quarrying = _prefix "Other_mining_and_quarrying"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_office"></see>
    /// </summary>
    let Other_office = _prefix "Other_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_retail_sale"></see>
    /// </summary>
    let Other_retail_sale = _prefix "Other_retail_sale"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_specialized_construction"></see>
    /// </summary>
    let Other_specialized_construction = _prefix "Other_specialized_construction"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_specialized_wholesale"></see>
    /// </summary>
    let Other_specialized_wholesale = _prefix "Other_specialized_wholesale"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Other_telecommunications_activities"></see>
    /// </summary>
    let Other_telecommunications_activities =
        _prefix "Other_telecommunications_activities"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Packaging_activities"></see>
    /// </summary>
    let Packaging_activities = _prefix "Packaging_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Paramedical_activities"></see>
    /// </summary>
    let Paramedical_activities = _prefix "Paramedical_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Parties_and_ceremonies"></see>
    /// </summary>
    let Parties_and_ceremonies = _prefix "Parties_and_ceremonies"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Passenger_air_transport"></see>
    /// </summary>
    let Passenger_air_transport = _prefix "Passenger_air_transport"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pastry_shop"></see>
    /// </summary>
    let Pastry_shop = _prefix "Pastry_shop"
    /// <summary>
    /// Servizi rappresentati da una spezzata
    /// <see href="http://www.disit.org/km4city/schema#Path"></see></summary>
    let Path = _prefix "Path"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pedestrian_zone"></see>
    /// </summary>
    let Pedestrian_zone = _prefix "Pedestrian_zone"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Performing_arts_schools"></see>
    /// </summary>
    let Performing_arts_schools = _prefix "Performing_arts_schools"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Perfumery_and_cosmetic_articles"></see>
    /// </summary>
    let Perfumery_and_cosmetic_articles = _prefix "Perfumery_and_cosmetic_articles"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Personal_and_household_goods_rental"></see>
    /// </summary>
    let Personal_and_household_goods_rental =
        _prefix "Personal_and_household_goods_rental"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Personal_service_activities"></see>
    /// </summary>
    let Personal_service_activities = _prefix "Personal_service_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pet_care_services"></see>
    /// </summary>
    let Pet_care_services = _prefix "Pet_care_services"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pet_shop"></see>
    /// </summary>
    let Pet_shop = _prefix "Pet_shop"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Petroleum_and_natural_gas_extraction"></see>
    /// </summary>
    let Petroleum_and_natural_gas_extraction =
        _prefix "Petroleum_and_natural_gas_extraction"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pharmaceuticals"></see>
    /// </summary>
    let Pharmaceuticals = _prefix "Pharmaceuticals"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pharmacy"></see>
    /// </summary>
    let Pharmacy = _prefix "Pharmacy"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Photographic_activities"></see>
    /// </summary>
    let Photographic_activities = _prefix "Photographic_activities"
    /// <summary>
    /// geolocalizzazione degli impianti fotovoltaici funzionanti
    /// <see href="http://www.disit.org/km4city/schema#Photovoltaic_system"></see></summary>
    let Photovoltaic_system = _prefix "Photovoltaic_system"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Physical_therapy_centre"></see>
    /// </summary>
    let Physical_therapy_centre = _prefix "Physical_therapy_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pizzeria"></see>
    /// </summary>
    let Pizzeria = _prefix "Pizzeria"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Poison_control_centre"></see>
    /// </summary>
    let Poison_control_centre = _prefix "Poison_control_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Police_headquarters"></see>
    /// </summary>
    let Police_headquarters = _prefix "Police_headquarters"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pool"></see>
    /// </summary>
    let Pool = _prefix "Pool"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Post_secondary_education"></see>
    /// </summary>
    let Post_secondary_education = _prefix "Post_secondary_education"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Postal_and_courier_activities"></see>
    /// </summary>
    let Postal_and_courier_activities = _prefix "Postal_and_courier_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Postal_office"></see>
    /// </summary>
    let Postal_office = _prefix "Postal_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Pre_primary_education"></see>
    /// </summary>
    let Pre_primary_education = _prefix "Pre_primary_education"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Prefecture"></see>
    /// </summary>
    let Prefecture = _prefix "Prefecture"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Primary_education"></see>
    /// </summary>
    let Primary_education = _prefix "Primary_education"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Printing_and_recorded_media"></see>
    /// </summary>
    let Printing_and_recorded_media = _prefix "Printing_and_recorded_media"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Printing_and_services"></see>
    /// </summary>
    let Printing_and_services = _prefix "Printing_and_services"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_clinic"></see>
    /// </summary>
    let Private_clinic = _prefix "Private_clinic"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_high_school"></see>
    /// </summary>
    let Private_high_school = _prefix "Private_high_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_infant_school"></see>
    /// </summary>
    let Private_infant_school = _prefix "Private_infant_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_junior_high_school"></see>
    /// </summary>
    let Private_junior_high_school = _prefix "Private_junior_high_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_junior_school"></see>
    /// </summary>
    let Private_junior_school = _prefix "Private_junior_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_polytechnic_school"></see>
    /// </summary>
    let Private_polytechnic_school = _prefix "Private_polytechnic_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_preschool"></see>
    /// </summary>
    let Private_preschool = _prefix "Private_preschool"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_professional_institute"></see>
    /// </summary>
    let Private_professional_institute = _prefix "Private_professional_institute"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Private_security"></see>
    /// </summary>
    let Private_security = _prefix "Private_security"
    /// <summary>
    /// Classe le cui istanze sono le varie provincie
    /// <see href="http://www.disit.org/km4city/schema#Province"></see></summary>
    let Province = _prefix "Province"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Psychologists"></see>
    /// </summary>
    let Psychologists = _prefix "Psychologists"
    /// <summary>
    /// Servizio associato alla visualizzazione delle linee ATAF con le relative fermate
    /// Linea di una certa azienda TPL
    /// <see href="http://www.disit.org/km4city/schema#PublicTransportLine"></see></summary>
    let PublicTransportLine = _prefix "PublicTransportLine"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_high_school"></see>
    /// </summary>
    let Public_high_school = _prefix "Public_high_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_hospital"></see>
    /// </summary>
    let Public_hospital = _prefix "Public_hospital"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_infant_school"></see>
    /// </summary>
    let Public_infant_school = _prefix "Public_infant_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_junior_high_school"></see>
    /// </summary>
    let Public_junior_high_school = _prefix "Public_junior_high_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_junior_school"></see>
    /// </summary>
    let Public_junior_school = _prefix "Public_junior_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_polytechnic_school"></see>
    /// </summary>
    let Public_polytechnic_school = _prefix "Public_polytechnic_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_professional_institute"></see>
    /// </summary>
    let Public_professional_institute = _prefix "Public_professional_institute"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Public_university"></see>
    /// </summary>
    let Public_university = _prefix "Public_university"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Publishing_activities"></see>
    /// </summary>
    let Publishing_activities = _prefix "Publishing_activities"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Quality_control_and_certification"></see>
    /// </summary>
    let Quality_control_and_certification = _prefix "Quality_control_and_certification"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Quarrying_of_stone_sand_and_clay"></see>
    /// </summary>
    let Quarrying_of_stone_sand_and_clay = _prefix "Quarrying_of_stone_sand_and_clay"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#RTZgate"></see>
    /// </summary>
    let RTZgate = _prefix "RTZgate"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Radio_broadcasting"></see>
    /// </summary>
    let Radio_broadcasting = _prefix "Radio_broadcasting"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Rafting_kayak"></see>
    /// </summary>
    let Rafting_kayak = _prefix "Rafting_kayak"
    /// <summary>
    /// Classe le cui istanze sono le direttive ferroviarie
    /// <see href="http://www.disit.org/km4city/schema#RailwayDirection"></see></summary>
    let RailwayDirection = _prefix "RailwayDirection"
    /// <summary>
    /// Classe le cui istanze sono gli elementi che compongono le tratte, le sezioni o le linee ferroviarie
    /// <see href="http://www.disit.org/km4city/schema#RailwayElement"></see></summary>
    let RailwayElement = _prefix "RailwayElement"
    /// <summary>
    /// a railway Direction is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#consistOfElement"></see></summary>
    let consistOfElement = _prefix "consistOfElement"
    /// <summary>
    /// a railway element is delimited by two junctions
    /// <see href="http://www.disit.org/km4city/schema#endAtJunction"></see></summary>
    let endAtJunction = _prefix "endAtJunction"
    /// <summary>
    /// a railway element is delimited by two junctions
    /// <see href="http://www.disit.org/km4city/schema#startAtJunction"></see></summary>
    let startAtJunction = _prefix "startAtJunction"
    /// <summary>
    /// Classe le cui istanze sono le sezioni ferroviarie
    /// <see href="http://www.disit.org/km4city/schema#RailwaySection"></see></summary>
    let RailwaySection = _prefix "RailwaySection"
    /// <summary>
    /// Classe le cui istanze sono le linee ferroviarie
    /// <see href="http://www.disit.org/km4city/schema#RailwayLine"></see></summary>
    let RailwayLine = _prefix "RailwayLine"
    /// <summary>
    /// a railway line is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#hasElement"></see></summary>
    let hasElement = _prefix "hasElement"
    /// <summary>
    /// a railway Section is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#isComposedByElement"></see></summary>
    let isComposedByElement = _prefix "isComposedByElement"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Recreation_room"></see>
    /// </summary>
    let Recreation_room = _prefix "Recreation_room"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Recreational_and_sports_goods_rental"></see>
    /// </summary>
    let Recreational_and_sports_goods_rental =
        _prefix "Recreational_and_sports_goods_rental"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Recruitment"></see>
    /// </summary>
    let Recruitment = _prefix "Recruitment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Red_cross"></see>
    /// </summary>
    let Red_cross = _prefix "Red_cross"
    /// <summary>
    /// Classe le cui istanze sono le varie regioni
    /// <see href="http://www.disit.org/km4city/schema#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    /// servizi che possono avere altre caratteristiche, rappresentate come servizi trasversali
    /// <see href="http://www.disit.org/km4city/schema#RegularService"></see></summary>
    let RegularService = _prefix "RegularService"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Religiuos_guest_house"></see>
    /// </summary>
    let Religiuos_guest_house = _prefix "Religiuos_guest_house"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair"></see>
    /// </summary>
    let Repair = _prefix "Repair"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_musical_instruments"></see>
    /// </summary>
    let Repair_musical_instruments = _prefix "Repair_musical_instruments"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_communication_equipment"></see>
    /// </summary>
    let Repair_of_communication_equipment = _prefix "Repair_of_communication_equipment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_consumer_electronics"></see>
    /// </summary>
    let Repair_of_consumer_electronics = _prefix "Repair_of_consumer_electronics"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_footwear_and_leather_goods"></see>
    /// </summary>
    let Repair_of_footwear_and_leather_goods =
        _prefix "Repair_of_footwear_and_leather_goods"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_garden_equipment"></see>
    /// </summary>
    let Repair_of_garden_equipment = _prefix "Repair_of_garden_equipment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_home_equipment"></see>
    /// </summary>
    let Repair_of_home_equipment = _prefix "Repair_of_home_equipment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_household_appliances"></see>
    /// </summary>
    let Repair_of_household_appliances = _prefix "Repair_of_household_appliances"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Repair_of_sporting_goods"></see>
    /// </summary>
    let Repair_of_sporting_goods = _prefix "Repair_of_sporting_goods"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Reporting_agencies"></see>
    /// </summary>
    let Reporting_agencies = _prefix "Reporting_agencies"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Reproduction_recorded_media"></see>
    /// </summary>
    let Reproduction_recorded_media = _prefix "Reproduction_recorded_media"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Research_and_development"></see>
    /// </summary>
    let Research_and_development = _prefix "Research_and_development"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Residential_care_activities"></see>
    /// </summary>
    let Residential_care_activities = _prefix "Residential_care_activities"
    /// <summary>
    /// Delibera approvata da una qualche Pa
    /// <see href="http://www.disit.org/km4city/schema#Resolution"></see></summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Rest_home"></see>
    /// </summary>
    let Rest_home = _prefix "Rest_home"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Restaurant"></see>
    /// </summary>
    let Restaurant = _prefix "Restaurant"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Restorers"></see>
    /// </summary>
    let Restorers = _prefix "Restorers"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Retail_motor_vehicles_parts"></see>
    /// </summary>
    let Retail_motor_vehicles_parts = _prefix "Retail_motor_vehicles_parts"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Retail_sale_non_specialized_stores"></see>
    /// </summary>
    let Retail_sale_non_specialized_stores =
        _prefix "Retail_sale_non_specialized_stores"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Retail_trade"></see>
    /// </summary>
    let Retail_trade = _prefix "Retail_trade"
    /// <summary>
    /// Corsa programmata da una certa azienda TPL su un certo percorso di una certa linea
    /// <see href="http://www.disit.org/km4city/schema#Ride"></see></summary>
    let Ride = _prefix "Ride"
    /// <summary>
    /// a ride can be scheduled on a single line
    /// <see href="http://www.disit.org/km4city/schema#scheduledOnLine"></see></summary>
    let scheduledOnLine = _prefix "scheduledOnLine"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Riding_stables"></see>
    /// </summary>
    let Riding_stables = _prefix "Riding_stables"
    /// <summary>
    /// Classe le cui istanze sono le strade
    /// <see href="http://www.disit.org/km4city/schema#Road"></see></summary>
    let Road = _prefix "Road"
    /// <summary>
    /// a road element is delimited by 2 nodes
    /// <see href="http://www.disit.org/km4city/schema#startsAtNode"></see></summary>
    let startsAtNode = _prefix "startsAtNode"
    /// <summary>
    /// a road element is delimited by 2 nodes
    /// <see href="http://www.disit.org/km4city/schema#endsAtNode"></see></summary>
    let endsAtNode = _prefix "endsAtNode"
    /// <summary>
    /// Tratto di strada lineare delimitato da due giunzioni che compone il road element
    /// <see href="http://www.disit.org/km4city/schema#RoadLink"></see></summary>
    let RoadLink = _prefix "RoadLink"
    /// <summary>
    /// a road linnk is delimited by two junctions
    /// <see href="http://www.disit.org/km4city/schema#startingJunction"></see></summary>
    let startingJunction = _prefix "startingJunction"
    /// <summary>
    /// a road linnk is delimited by two junctions
    /// <see href="http://www.disit.org/km4city/schema#endingJunction"></see></summary>
    let endingJunction = _prefix "endingJunction"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Rope_cord_and_twine"></see>
    /// </summary>
    let Rope_cord_and_twine = _prefix "Rope_cord_and_twine"
    /// <summary>
    /// defines all the other section of a route
    /// <see href="http://www.disit.org/km4city/schema#hasSection"></see></summary>
    let hasSection = _prefix "hasSection"
    /// <summary>
    /// defines which is the departure stop of a route
    /// <see href="http://www.disit.org/km4city/schema#hasFirstStop"></see></summary>
    let hasFirstStop = _prefix "hasFirstStop"
    /// <summary>
    /// Tratto di strada compreso tra due successive fermate dell'autobus di una certa linea
    /// <see href="http://www.disit.org/km4city/schema#RouteSection"></see></summary>
    let RouteSection = _prefix "RouteSection"
    /// <summary>
    /// defines which is the departure section of a route
    /// <see href="http://www.disit.org/km4city/schema#hasFirstSection"></see></summary>
    let hasFirstSection = _prefix "hasFirstSection"
    /// <summary>
    /// Punto di interconnessione tra segmenti di strada per determinare il percorso di una linea di TPL
    /// <see href="http://www.disit.org/km4city/schema#RouteJunction"></see></summary>
    let RouteJunction = _prefix "RouteJunction"
    /// <summary>
    /// Tratto di strada delimitato da due TPL junction che determina il percorso di una linea TPL
    /// <see href="http://www.disit.org/km4city/schema#RouteLink"></see></summary>
    let RouteLink = _prefix "RouteLink"
    /// <summary>
    /// each routeLink, has a beginning and an end junction
    /// <see href="http://www.disit.org/km4city/schema#finishesAtJunction"></see></summary>
    let finishesAtJunction = _prefix "finishesAtJunction"
    /// <summary>
    /// each routeLink, has a beginning and an end junction
    /// <see href="http://www.disit.org/km4city/schema#beginsAtJunction"></see></summary>
    let beginsAtJunction = _prefix "beginsAtJunction"
    /// <summary>
    /// a route section is delimited by two consecutive bus stops
    /// <see href="http://www.disit.org/km4city/schema#startsAtStop"></see></summary>
    let startsAtStop = _prefix "startsAtStop"
    /// <summary>
    /// a route section is delimited by two consecutive bus stops
    /// <see href="http://www.disit.org/km4city/schema#endsAtStop"></see></summary>
    let endsAtStop = _prefix "endsAtStop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sailing_school"></see>
    /// </summary>
    let Sailing_school = _prefix "Sailing_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_motor_vehicles_parts"></see>
    /// </summary>
    let Sale_motor_vehicles_parts = _prefix "Sale_motor_vehicles_parts"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_of_motor_vehicles"></see>
    /// </summary>
    let Sale_of_motor_vehicles = _prefix "Sale_of_motor_vehicles"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_of_motor_vehicles_and_motorcycles"></see>
    /// </summary>
    let Sale_of_motor_vehicles_and_motorcycles =
        _prefix "Sale_of_motor_vehicles_and_motorcycles"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_of_motorcycles"></see>
    /// </summary>
    let Sale_of_motorcycles = _prefix "Sale_of_motorcycles"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sale_via_mail_order_houses_or_via_internet"></see>
    /// </summary>
    let Sale_via_mail_order_houses_or_via_internet =
        _prefix "Sale_via_mail_order_houses_or_via_internet"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sandwich_shop_pub"></see>
    /// </summary>
    let Sandwich_shop_pub = _prefix "Sandwich_shop_pub"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sanitary_equipment"></see>
    /// </summary>
    let Sanitary_equipment = _prefix "Sanitary_equipment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sawmilling"></see>
    /// </summary>
    let Sawmilling = _prefix "Sawmilling"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Second_hand_books"></see>
    /// </summary>
    let Second_hand_books = _prefix "Second_hand_books"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Second_hand_goods"></see>
    /// </summary>
    let Second_hand_goods = _prefix "Second_hand_goods"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Secondary_education"></see>
    /// </summary>
    let Secondary_education = _prefix "Secondary_education"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Secretarial_support_services"></see>
    /// </summary>
    let Secretarial_support_services = _prefix "Secretarial_support_services"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Security_systems"></see>
    /// </summary>
    let Security_systems = _prefix "Security_systems"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Security_systems_service"></see>
    /// </summary>
    let Security_systems_service = _prefix "Security_systems_service"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Senior_centre"></see>
    /// </summary>
    let Senior_centre = _prefix "Senior_centre"
    /// <summary>
    /// Sensore stradale che rilascia info sul traffico
    /// Singolo sensore per osservare velocita', traffico, concentrazione o densita'
    /// <see href="http://www.disit.org/km4city/schema#SensorSite"></see></summary>
    let SensorSite = _prefix "SensorSite"
    /// <summary>
    /// Insieme di sensori che rappresentano un unica installazione, un unico sito
    /// <see href="http://www.disit.org/km4city/schema#SensorSiteTable"></see></summary>
    let SensorSiteTable = _prefix "SensorSiteTable"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sewerage"></see>
    /// </summary>
    let Sewerage = _prefix "Sewerage"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sexy_shop"></see>
    /// </summary>
    let Sexy_shop = _prefix "Sexy_shop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Shopping_centre"></see>
    /// </summary>
    let Shopping_centre = _prefix "Shopping_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Single_brand_store"></see>
    /// </summary>
    let Single_brand_store = _prefix "Single_brand_store"
    /// <summary>
    /// Registrazione della situazione di occupazione di un determinato parcheggio in un certo istante
    /// <see href="http://www.disit.org/km4city/schema#SituationRecord"></see></summary>
    let SituationRecord = _prefix "SituationRecord"
    /// <summary>
    /// every XX minutes a sensor sends a report
    /// <see href="http://www.disit.org/km4city/schema#relatedToSensor"></see></summary>
    let relatedToSensor = _prefix "relatedToSensor"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Ski_school"></see>
    /// </summary>
    let Ski_school = _prefix "Ski_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Skiing_facility"></see>
    /// </summary>
    let Skiing_facility = _prefix "Skiing_facility"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Small_household_appliances"></see>
    /// </summary>
    let Small_household_appliances = _prefix "Small_household_appliances"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Small_shop"></see>
    /// </summary>
    let Small_shop = _prefix "Small_shop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Social_centre"></see>
    /// </summary>
    let Social_centre = _prefix "Social_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Social_security_service_office"></see>
    /// </summary>
    let Social_security_service_office = _prefix "Social_security_service_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Social_work"></see>
    /// </summary>
    let Social_work = _prefix "Social_work"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Software_publishing"></see>
    /// </summary>
    let Software_publishing = _prefix "Software_publishing"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sound_recording_and_music_publishing"></see>
    /// </summary>
    let Sound_recording_and_music_publishing =
        _prefix "Sound_recording_and_music_publishing"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Souvenirs_Craftwork_and_religious_articles"></see>
    /// </summary>
    let Souvenirs_Craftwork_and_religious_articles =
        _prefix "Souvenirs_Craftwork_and_religious_articles"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Specialized_construction"></see>
    /// </summary>
    let Specialized_construction = _prefix "Specialized_construction"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Specialized_design"></see>
    /// </summary>
    let Specialized_design = _prefix "Specialized_design"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sport_event_promoters"></see>
    /// </summary>
    let Sport_event_promoters = _prefix "Sport_event_promoters"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sporting_equipment"></see>
    /// </summary>
    let Sporting_equipment = _prefix "Sporting_equipment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sports_and_recreation_education"></see>
    /// </summary>
    let Sports_and_recreation_education = _prefix "Sports_and_recreation_education"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sports_clubs"></see>
    /// </summary>
    let Sports_clubs = _prefix "Sports_clubs"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sports_facility"></see>
    /// </summary>
    let Sports_facility = _prefix "Sports_facility"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Squares"></see>
    /// </summary>
    let Squares = _prefix "Squares"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stalls_and_markets"></see>
    /// </summary>
    let Stalls_and_markets = _prefix "Stalls_and_markets"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stalls_and_markets_of_clothing_and_footwear"></see>
    /// </summary>
    let Stalls_and_markets_of_clothing_and_footwear =
        _prefix "Stalls_and_markets_of_clothing_and_footwear"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stalls_and_markets_of_food"></see>
    /// </summary>
    let Stalls_and_markets_of_food = _prefix "Stalls_and_markets_of_food"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stalls_and_markets_other_goods"></see>
    /// </summary>
    let Stalls_and_markets_other_goods = _prefix "Stalls_and_markets_other_goods"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stamps_and_coins"></see>
    /// </summary>
    let Stamps_and_coins = _prefix "Stamps_and_coins"
    /// <summary>
    /// Valore che fa riferimento ad un dato statistico legato ad una strada o ad una Pa
    /// <see href="http://www.disit.org/km4city/schema#StatisticalData"></see></summary>
    let StatisticalData = _prefix "StatisticalData"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Stone_processing"></see>
    /// </summary>
    let Stone_processing = _prefix "Stone_processing"
    /// <summary>
    /// each road has street numbers
    /// <see href="http://www.disit.org/km4city/schema#belongToRoad"></see></summary>
    let belongToRoad = _prefix "belongToRoad"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Street_sweeping"></see>
    /// </summary>
    let Street_sweeping = _prefix "Street_sweeping"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Summer_camp"></see>
    /// </summary>
    let Summer_camp = _prefix "Summer_camp"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Summer_residence"></see>
    /// </summary>
    let Summer_residence = _prefix "Summer_residence"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Supermarket"></see>
    /// </summary>
    let Supermarket = _prefix "Supermarket"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Support_activities_for_transportation"></see>
    /// </summary>
    let Support_activities_for_transportation =
        _prefix "Support_activities_for_transportation"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Support_animal_production"></see>
    /// </summary>
    let Support_animal_production = _prefix "Support_animal_production"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Surveyor"></see>
    /// </summary>
    let Surveyor = _prefix "Surveyor"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Sushi_bar"></see>
    /// </summary>
    let Sushi_bar = _prefix "Sushi_bar"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Take_away"></see>
    /// </summary>
    let Take_away = _prefix "Take_away"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tannery"></see>
    /// </summary>
    let Tannery = _prefix "Tannery"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tattoo_and_piercing"></see>
    /// </summary>
    let Tattoo_and_piercing = _prefix "Tattoo_and_piercing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tax_advice"></see>
    /// </summary>
    let Tax_advice = _prefix "Tax_advice"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Taxi_company"></see>
    /// </summary>
    let Taxi_company = _prefix "Taxi_company"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Taxi_park"></see>
    /// </summary>
    let Taxi_park = _prefix "Taxi_park"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Technical_consultants"></see>
    /// </summary>
    let Technical_consultants = _prefix "Technical_consultants"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Technical_testing"></see>
    /// </summary>
    let Technical_testing = _prefix "Technical_testing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Telecommunications"></see>
    /// </summary>
    let Telecommunications = _prefix "Telecommunications"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Television_broadcasting"></see>
    /// </summary>
    let Television_broadcasting = _prefix "Television_broadcasting"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Temp_agency"></see>
    /// </summary>
    let Temp_agency = _prefix "Temp_agency"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Textile_manufacturing"></see>
    /// </summary>
    let Textile_manufacturing = _prefix "Textile_manufacturing"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Textiles_products"></see>
    /// </summary>
    let Textiles_products = _prefix "Textiles_products"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Theatre"></see>
    /// </summary>
    let Theatre = _prefix "Theatre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Ticket_sale"></see>
    /// </summary>
    let Ticket_sale = _prefix "Ticket_sale"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tobacco_industry"></see>
    /// </summary>
    let Tobacco_industry = _prefix "Tobacco_industry"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tobacco_shop"></see>
    /// </summary>
    let Tobacco_shop = _prefix "Tobacco_shop"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Toilet"></see>
    /// </summary>
    let Toilet = _prefix "Toilet"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tour_operator"></see>
    /// </summary>
    let Tour_operator = _prefix "Tour_operator"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tourist_complaints_office"></see>
    /// </summary>
    let Tourist_complaints_office = _prefix "Tourist_complaints_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tourist_guides"></see>
    /// </summary>
    let Tourist_guides = _prefix "Tourist_guides"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tourist_information_office"></see>
    /// </summary>
    let Tourist_information_office = _prefix "Tourist_information_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tourist_trail"></see>
    /// </summary>
    let Tourist_trail = _prefix "Tourist_trail"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Towing_and_roadside_assistance"></see>
    /// </summary>
    let Towing_and_roadside_assistance = _prefix "Towing_and_roadside_assistance"
    /// <summary>
    /// sottoclasse delle osservazioni relative alla concentrazione di auto
    /// <see href="http://www.disit.org/km4city/schema#TrafficConcentration"></see></summary>
    let TrafficConcentration = _prefix "TrafficConcentration"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#concentration"></see>
    /// </summary>
    let concentration = _prefix "concentration"
    /// <summary>
    /// sottoclasse delle osservazioni relative alla flusso auto
    /// <see href="http://www.disit.org/km4city/schema#TrafficFlow"></see></summary>
    let TrafficFlow = _prefix "TrafficFlow"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#vehicleFlow"></see>
    /// </summary>
    let vehicleFlow = _prefix "vehicleFlow"
    /// <summary>
    /// sottoclasse delle osservazioni sul tempo medio di transito tra auto
    /// <see href="http://www.disit.org/km4city/schema#TrafficHeadway"></see></summary>
    let TrafficHeadway = _prefix "TrafficHeadway"
    /// <summary>
    /// Tempo medio tra 2 transiti
    /// <see href="http://www.disit.org/km4city/schema#averageTime"></see></summary>
    let averageTime = _prefix "averageTime"
    /// <summary>
    /// sottoclasse delle osservazioni relative alla velocita' media
    /// <see href="http://www.disit.org/km4city/schema#TrafficSpeed"></see></summary>
    let TrafficSpeed = _prefix "TrafficSpeed"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#averageSpeed"></see>
    /// </summary>
    let averageSpeed = _prefix "averageSpeed"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Traffic_corps"></see>
    /// </summary>
    let Traffic_corps = _prefix "Traffic_corps"
    /// <summary>
    /// Stazione ferroviaria, sono posizionate in corrispondenza di giunzioni ferroviarie con relazione 1:1
    /// <see href="http://www.disit.org/km4city/schema#TrainStation"></see></summary>
    let TrainStation = _prefix "TrainStation"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Train_lost_property_office"></see>
    /// </summary>
    let Train_lost_property_office = _prefix "Train_lost_property_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Train_station"></see>
    /// </summary>
    let Train_station = _prefix "Train_station"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Training_school"></see>
    /// </summary>
    let Training_school = _prefix "Training_school"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Training_school_for_teachers"></see>
    /// </summary>
    let Training_school_for_teachers = _prefix "Training_school_for_teachers"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tram_stops"></see>
    /// </summary>
    let Tram_stops = _prefix "Tram_stops"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Tramline"></see>
    /// </summary>
    let Tramline = _prefix "Tramline"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Translation_and_interpreting"></see>
    /// </summary>
    let Translation_and_interpreting = _prefix "Translation_and_interpreting"
    /// <summary>
    /// servizi molto spesso collegati ad altri servizi, che presentano una loro geolocalizzazione
    /// <see href="http://www.disit.org/km4city/schema#TransverseService"></see></summary>
    let TransverseService = _prefix "TransverseService"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Trattoria"></see>
    /// </summary>
    let Trattoria = _prefix "Trattoria"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Travel_agency"></see>
    /// </summary>
    let Travel_agency = _prefix "Travel_agency"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Travel_bureau"></see>
    /// </summary>
    let Travel_bureau = _prefix "Travel_bureau"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Travel_goods"></see>
    /// </summary>
    let Travel_goods = _prefix "Travel_goods"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Travel_information"></see>
    /// </summary>
    let Travel_information = _prefix "Travel_information"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Trinkets"></see>
    /// </summary>
    let Trinkets = _prefix "Trinkets"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Underwear_knitwear_and_shirts"></see>
    /// </summary>
    let Underwear_knitwear_and_shirts = _prefix "Underwear_knitwear_and_shirts"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Upholsterer"></see>
    /// </summary>
    let Upholsterer = _prefix "Upholsterer"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Urban_bus"></see>
    /// </summary>
    let Urban_bus = _prefix "Urban_bus"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Useful_numbers"></see>
    /// </summary>
    let Useful_numbers = _prefix "Useful_numbers"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vacating_service"></see>
    /// </summary>
    let Vacating_service = _prefix "Vacating_service"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vacation_resort"></see>
    /// </summary>
    let Vacation_resort = _prefix "Vacation_resort"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vehicle_rental"></see>
    /// </summary>
    let Vehicle_rental = _prefix "Vehicle_rental"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vehicle_trade"></see>
    /// </summary>
    let Vehicle_trade = _prefix "Vehicle_trade"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Vending_machines"></see>
    /// </summary>
    let Vending_machines = _prefix "Vending_machines"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Veterinary"></see>
    /// </summary>
    let Veterinary = _prefix "Veterinary"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Video_tapes_disks_rental"></see>
    /// </summary>
    let Video_tapes_disks_rental = _prefix "Video_tapes_disks_rental"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wallpaper_and_floor_coverings"></see>
    /// </summary>
    let Wallpaper_and_floor_coverings = _prefix "Wallpaper_and_floor_coverings"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Warehousing_and_storage"></see>
    /// </summary>
    let Warehousing_and_storage = _prefix "Warehousing_and_storage"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Waste_collection_and_treatment"></see>
    /// </summary>
    let Waste_collection_and_treatment = _prefix "Waste_collection_and_treatment"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Water_collection_treatment_and_supply"></see>
    /// </summary>
    let Water_collection_treatment_and_supply =
        _prefix "Water_collection_treatment_and_supply"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Water_transport"></see>
    /// </summary>
    let Water_transport = _prefix "Water_transport"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Weapons_and_ammunition"></see>
    /// </summary>
    let Weapons_and_ammunition = _prefix "Weapons_and_ammunition"
    /// <summary>
    /// Previsione metereologica relativa ad una specifica parte del giorno
    /// <see href="http://www.disit.org/km4city/schema#WeatherPrediction"></see></summary>
    let WeatherPrediction = _prefix "WeatherPrediction"
    /// <summary>
    /// Bollettino metereologico con informazioni relative a temperatura, unidita', neve, etc
    /// <see href="http://www.disit.org/km4city/schema#WeatherReport"></see></summary>
    let WeatherReport = _prefix "WeatherReport"
    /// <summary>
    /// specifies the municipality for the weather forecast
    /// <see href="http://www.disit.org/km4city/schema#refersToMunicipality"></see></summary>
    let refersToMunicipality = _prefix "refersToMunicipality"
    /// <summary>
    /// Sensore meteo che rilascia info sulle previsioni meteo
    /// <see href="http://www.disit.org/km4city/schema#Weather_sensor"></see></summary>
    let Weather_sensor = _prefix "Weather_sensor"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Web_and_internet_provider"></see>
    /// </summary>
    let Web_and_internet_provider = _prefix "Web_and_internet_provider"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wedding_favors"></see>
    /// </summary>
    let Wedding_favors = _prefix "Wedding_favors"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Welfare_worker_office"></see>
    /// </summary>
    let Welfare_worker_office = _prefix "Welfare_worker_office"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wellness_centre"></see>
    /// </summary>
    let Wellness_centre = _prefix "Wellness_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_ICT_equipment"></see>
    /// </summary>
    let Wholesale_ICT_equipment = _prefix "Wholesale_ICT_equipment"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_agricultural_raw_materials_live_animals"></see>
    /// </summary>
    let Wholesale_agricultural_raw_materials_live_animals =
        _prefix "Wholesale_agricultural_raw_materials_live_animals"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_commission_trade"></see>
    /// </summary>
    let Wholesale_commission_trade = _prefix "Wholesale_commission_trade"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_food_beverages_tobacco"></see>
    /// </summary>
    let Wholesale_food_beverages_tobacco = _prefix "Wholesale_food_beverages_tobacco"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_household_goods"></see>
    /// </summary>
    let Wholesale_household_goods = _prefix "Wholesale_household_goods"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_machinery_equipmentent_supplies"></see>
    /// </summary>
    let Wholesale_machinery_equipmentent_supplies =
        _prefix "Wholesale_machinery_equipmentent_supplies"

    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_motor_vehicles_parts"></see>
    /// </summary>
    let Wholesale_motor_vehicles_parts = _prefix "Wholesale_motor_vehicles_parts"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wholesale_trade"></see>
    /// </summary>
    let Wholesale_trade = _prefix "Wholesale_trade"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wifi"></see>
    /// </summary>
    let Wifi = _prefix "Wifi"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Wine_shop_and_wine_bar"></see>
    /// </summary>
    let Wine_shop_and_wine_bar = _prefix "Wine_shop_and_wine_bar"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Youth_assistance"></see>
    /// </summary>
    let Youth_assistance = _prefix "Youth_assistance"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#Youth_information_centre"></see>
    /// </summary>
    let Youth_information_centre = _prefix "Youth_information_centre"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#accessType"></see>
    /// </summary>
    let accessType = _prefix "accessType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#adRoadName"></see>
    /// </summary>
    let adRoadName = _prefix "adRoadName"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#adminClass"></see>
    /// </summary>
    let adminClass = _prefix "adminClass"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#alterCode"></see>
    /// </summary>
    let alterCode = _prefix "alterCode"
    /// <summary>
    /// to connect a resolution to the municipality that have approved it
    /// <see href="http://www.disit.org/km4city/schema#approvedByPa"></see></summary>
    let approvedByPa = _prefix "approvedByPa"
    /// <summary>
    /// to connect a resolution to the municipality that have approved it
    /// <see href="http://www.disit.org/km4city/schema#hasResolution"></see></summary>
    let hasResolution = _prefix "hasResolution"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#areaCode"></see>
    /// </summary>
    let areaCode = _prefix "areaCode"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#areaName"></see>
    /// </summary>
    let areaName = _prefix "areaName"
    /// <summary>
    /// to connect each beacon to the road in which it is installed
    /// <see href="http://www.disit.org/km4city/schema#arrangedOnRoad"></see></summary>
    let arrangedOnRoad = _prefix "arrangedOnRoad"
    /// <summary>
    /// each forecast refers to a specific bus stop
    /// <see href="http://www.disit.org/km4city/schema#hasForecast"></see></summary>
    let hasForecast = _prefix "hasForecast"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#atecoCode"></see>
    /// </summary>
    let atecoCode = _prefix "atecoCode"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#automaticity"></see>
    /// </summary>
    let automaticity = _prefix "automaticity"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#averageDistance"></see>
    /// </summary>
    let averageDistance = _prefix "averageDistance"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#axialMass"></see>
    /// </summary>
    let axialMass = _prefix "axialMass"
    /// <summary>
    /// each road has street numbers
    /// <see href="http://www.disit.org/km4city/schema#hasStreetNumber"></see></summary>
    let hasStreetNumber = _prefix "hasStreetNumber"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#capacity"></see>
    /// </summary>
    let capacity = _prefix "capacity"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#carParkStatus"></see>
    /// </summary>
    let carParkStatus = _prefix "carParkStatus"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#category"></see>
    /// </summary>
    let category = _prefix "category"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#classCode"></see>
    /// </summary>
    let classCode = _prefix "classCode"
    /// <summary>
    /// there is no exact match between Road and AdministrativeRoad
    /// <see href="http://www.disit.org/km4city/schema#coincideWith"></see></summary>
    let coincideWith = _prefix "coincideWith"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#combinedTraffic"></see>
    /// </summary>
    let combinedTraffic = _prefix "combinedTraffic"
    /// <summary>
    /// a railway Direction is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#composeDirection"></see></summary>
    let composeDirection = _prefix "composeDirection"
    /// <summary>
    /// a railway Section is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#composeSection"></see></summary>
    let composeSection = _prefix "composeSection"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#composition"></see>
    /// </summary>
    let composition = _prefix "composition"
    /// <summary>
    /// an AVMrecord concert to a unique line
    /// <see href="http://www.disit.org/km4city/schema#concernLine"></see></summary>
    let concernLine = _prefix "concernLine"
    /// <summary>
    /// A road is formed by more elements road
    /// <see href="http://www.disit.org/km4city/schema#containsElement"></see></summary>
    let containsElement = _prefix "containsElement"
    /// <summary>
    /// More road elements compose a road
    /// <see href="http://www.disit.org/km4city/schema#isPartOfRoad"></see></summary>
    let isPartOfRoad = _prefix "isPartOfRoad"
    /// <summary>
    /// there is no exact match between Road and AdministrativeRoad
    /// <see href="http://www.disit.org/km4city/schema#correspondsTo"></see></summary>
    let correspondsTo = _prefix "correspondsTo"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#day"></see>
    /// </summary>
    let day = _prefix "day"
    /// <summary>
    /// direzione percorso
    /// <see href="http://www.disit.org/km4city/schema#direction"></see></summary>
    let direction = _prefix "direction"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#distance"></see>
    /// </summary>
    let distance = _prefix "distance"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#districtCode"></see>
    /// </summary>
    let districtCode = _prefix "districtCode"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#elemLocation"></see>
    /// </summary>
    let elemLocation = _prefix "elemLocation"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#elementClass"></see>
    /// </summary>
    let elementClass = _prefix "elementClass"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#elementType"></see>
    /// </summary>
    let elementType = _prefix "elementType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#entryType"></see>
    /// </summary>
    let entryType = _prefix "entryType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#eventCategory"></see>
    /// </summary>
    let eventCategory = _prefix "eventCategory"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#eventTime"></see>
    /// </summary>
    let eventTime = _prefix "eventTime"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#exitRate"></see>
    /// </summary>
    let exitRate = _prefix "exitRate"
    /// <summary>
    /// orario in cui e' previsto l'arrivo del bus a quella fermata DA ELIMINARE QUANDO INSTANT FUNZIONERA' ALLA PERFEZIONE
    /// <see href="http://www.disit.org/km4city/schema#expectedTime"></see></summary>
    let expectedTime = _prefix "expectedTime"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#exponent"></see>
    /// </summary>
    let exponent = _prefix "exponent"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#extendName"></see>
    /// </summary>
    let extendName = _prefix "extendName"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#extendNumber"></see>
    /// </summary>
    let extendNumber = _prefix "extendNumber"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#fillRate"></see>
    /// </summary>
    let fillRate = _prefix "fillRate"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#firenzeCard"></see>
    /// </summary>
    let firenzeCard = _prefix "firenzeCard"
    /// <summary>
    /// more road elements form an administrative road
    /// <see href="http://www.disit.org/km4city/schema#formingAdminRoad"></see></summary>
    let formingAdminRoad = _prefix "formingAdminRoad"
    /// <summary>
    /// more road elements form an administrative road
    /// <see href="http://www.disit.org/km4city/schema#hasRoadElement"></see></summary>
    let hasRoadElement = _prefix "hasRoadElement"
    /// <summary>
    /// more road sensors form a sensor Table
    /// <see href="http://www.disit.org/km4city/schema#formsTable"></see></summary>
    let formsTable = _prefix "formsTable"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#free"></see>
    /// </summary>
    let free = _prefix "free"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#freeEvent"></see>
    /// </summary>
    let freeEvent = _prefix "freeEvent"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#gauge"></see>
    /// </summary>
    let gauge = _prefix "gauge"
    /// <summary>
    /// the AVM refer to a specific ride code
    /// <see href="http://www.disit.org/km4city/schema#hasAVMRecord"></see></summary>
    let hasAVMRecord = _prefix "hasAVMRecord"
    /// <summary>
    /// point corresponding to the house number of service
    /// <see href="http://www.disit.org/km4city/schema#hasAccess"></see></summary>
    let hasAccess = _prefix "hasAccess"
    /// <summary>
    /// to connect each beacon to observations that it produces
    /// <see href="http://www.disit.org/km4city/schema#hasBObservation"></see></summary>
    let hasBObservation = _prefix "hasBObservation"
    /// <summary>
    /// to connect each car park to its installed sensor
    /// <see href="http://www.disit.org/km4city/schema#hasCarParkSensor"></see></summary>
    let hasCarParkSensor = _prefix "hasCarParkSensor"
    /// <summary>
    /// to connect each sensor to the referred car park service
    /// <see href="http://www.disit.org/km4city/schema#observeCarPark"></see></summary>
    let observeCarPark = _prefix "observeCarPark"
    /// <summary>
    /// the expected time at the next bus stops
    /// <see href="http://www.disit.org/km4city/schema#hasExpectedTime"></see></summary>
    let hasExpectedTime = _prefix "hasExpectedTime"
    /// <summary>
    /// the expected time at the next bus stops
    /// <see href="http://www.disit.org/km4city/schema#instantForecast"></see></summary>
    let instantForecast = _prefix "instantForecast"
    /// <summary>
    /// it corresponds to the outer gate of the building
    /// <see href="http://www.disit.org/km4city/schema#hasExternalAccess"></see></summary>
    let hasExternalAccess = _prefix "hasExternalAccess"
    /// <summary>
    /// some services and all railway elements have a specific geometry like polygons or linestrings
    /// <see href="http://www.disit.org/km4city/schema#hasGeometry"></see></summary>
    let hasGeometry = _prefix "hasGeometry"
    /// <summary>
    /// it corresponds to the door of the building
    /// <see href="http://www.disit.org/km4city/schema#hasInternalAccess"></see></summary>
    let hasInternalAccess = _prefix "hasInternalAccess"
    /// <summary>
    /// defines which is the last stop of a route
    /// <see href="http://www.disit.org/km4city/schema#hasLastStop"></see></summary>
    let hasLastStop = _prefix "hasLastStop"
    /// <summary>
    /// the arrival time at last bus stops
    /// <see href="http://www.disit.org/km4city/schema#hasLastStopTime"></see></summary>
    let hasLastStopTime = _prefix "hasLastStopTime"
    /// <summary>
    /// the arrival time at last bus stops
    /// <see href="http://www.disit.org/km4city/schema#instantAVM"></see></summary>
    let instantAVM = _prefix "instantAVM"
    /// <summary>
    /// an entry rule can be connected to a specific maneuver
    /// <see href="http://www.disit.org/km4city/schema#hasManeuver"></see></summary>
    let hasManeuver = _prefix "hasManeuver"
    /// <summary>
    /// a province is formed by more municipalities
    /// <see href="http://www.disit.org/km4city/schema#hasMunicipality"></see></summary>
    let hasMunicipality = _prefix "hasMunicipality"
    /// <summary>
    /// each road sensor produce a report every XX minuts
    /// <see href="http://www.disit.org/km4city/schema#hasObservation"></see></summary>
    let hasObservation = _prefix "hasObservation"
    /// <summary>
    /// a report is made up of more predictions
    /// <see href="http://www.disit.org/km4city/schema#hasPrediction"></see></summary>
    let hasPrediction = _prefix "hasPrediction"
    /// <summary>
    /// in a region there are more than one province
    /// <see href="http://www.disit.org/km4city/schema#hasProvince"></see></summary>
    let hasProvince = _prefix "hasProvince"
    /// <summary>
    /// in a region there are more than one province
    /// <see href="http://www.disit.org/km4city/schema#isPartOfRegion"></see></summary>
    let isPartOfRegion = _prefix "isPartOfRegion"
    /// <summary>
    /// every 10 minutes a sensor sends a report
    /// <see href="http://www.disit.org/km4city/schema#hasRecord"></see></summary>
    let hasRecord = _prefix "hasRecord"
    /// <summary>
    /// regular services can be connected to transverse services
    /// <see href="http://www.disit.org/km4city/schema#hasRegularService"></see></summary>
    let hasRegularService = _prefix "hasRegularService"
    /// <summary>
    /// each route refers to a line
    /// <see href="http://www.disit.org/km4city/schema#hasRoute"></see></summary>
    let hasRoute = _prefix "hasRoute"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#hasRouteLink"></see>
    /// </summary>
    let hasRouteLink = _prefix "hasRouteLink"
    /// <summary>
    /// some road elements subject to rules of access
    /// <see href="http://www.disit.org/km4city/schema#hasRule"></see></summary>
    let hasRule = _prefix "hasRule"
    /// <summary>
    /// each road element can be see as a collection of consecutive road link
    /// <see href="http://www.disit.org/km4city/schema#hasSegment"></see></summary>
    let hasSegment = _prefix "hasSegment"
    /// <summary>
    /// to connect a statistic to the referred municipality
    /// <see href="http://www.disit.org/km4city/schema#hasStatistic"></see></summary>
    let hasStatistic = _prefix "hasStatistic"
    /// <summary>
    /// to connect each train station tothe correspondant service
    /// <see href="http://www.disit.org/km4city/schema#hasTransferService"></see></summary>
    let hasTransferService = _prefix "hasTransferService"
    /// <summary>
    /// regular services can be connected to transverse services
    /// <see href="http://www.disit.org/km4city/schema#hasTransverseService"></see></summary>
    let hasTransverseService = _prefix "hasTransverseService"
    /// <summary>
    /// each weather forecasts is connected to a municipality
    /// <see href="http://www.disit.org/km4city/schema#hasWeatherReport"></see></summary>
    let hasWeatherReport = _prefix "hasWeatherReport"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#heightHour"></see>
    /// </summary>
    let heightHour = _prefix "heightHour"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#hour"></see>
    /// </summary>
    let hour = _prefix "hour"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#houseNumber"></see>
    /// </summary>
    let houseNumber = _prefix "houseNumber"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#humidity"></see>
    /// </summary>
    let humidity = _prefix "humidity"
    /// <summary>
    /// municipality to which the road belongs
    /// <see href="http://www.disit.org/km4city/schema#inMunicipalityOf"></see></summary>
    let inMunicipalityOf = _prefix "inMunicipalityOf"
    /// <summary>
    /// each AVMrecord includes more forecasts
    /// <see href="http://www.disit.org/km4city/schema#includeForecast"></see></summary>
    let includeForecast = _prefix "includeForecast"
    /// <summary>
    /// ime and date of each Beacon observation
    /// <see href="http://www.disit.org/km4city/schema#instantBObserv"></see></summary>
    let instantBObserv = _prefix "instantBObserv"
    /// <summary>
    /// Time and date of each Beacon observation
    /// <see href="http://www.disit.org/km4city/schema#measuredDate"></see></summary>
    let measuredDate = _prefix "measuredDate"
    /// <summary>
    /// the time of one observation
    /// <see href="http://www.disit.org/km4city/schema#instantObserv"></see></summary>
    let instantObserv = _prefix "instantObserv"
    /// <summary>
    /// the generation time of one situation record
    /// <see href="http://www.disit.org/km4city/schema#instantParking"></see></summary>
    let instantParking = _prefix "instantParking"
    /// <summary>
    /// the generation time of a new weather report
    /// <see href="http://www.disit.org/km4city/schema#instantWReport"></see></summary>
    let instantWReport = _prefix "instantWReport"
    /// <summary>
    /// each milestone need to refers to a road
    /// <see href="http://www.disit.org/km4city/schema#isInElement"></see></summary>
    let isInElement = _prefix "isInElement"
    /// <summary>
    /// A bus stop can be connected to the municipality to which belong
    /// <see href="http://www.disit.org/km4city/schema#isInMunicipality"></see></summary>
    let isInMunicipality = _prefix "isInMunicipality"
    /// <summary>
    ///  service and train station can be connected to the referred Road
    /// <see href="http://www.disit.org/km4city/schema#isInRoad"></see></summary>
    let isInRoad = _prefix "isInRoad"
    /// <summary>
    /// a railway line is composed by more railway element
    /// <see href="http://www.disit.org/km4city/schema#isPartOfLine"></see></summary>
    let isPartOfLine = _prefix "isPartOfLine"
    /// <summary>
    /// bus stops and bus lines are part of a lot
    /// <see href="http://www.disit.org/km4city/schema#isPartOfLot"></see></summary>
    let isPartOfLot = _prefix "isPartOfLot"
    /// <summary>
    /// a province is formed by more municipalities
    /// <see href="http://www.disit.org/km4city/schema#isPartOfProvince"></see></summary>
    let isPartOfProvince = _prefix "isPartOfProvince"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#juncType"></see>
    /// </summary>
    let juncType = _prefix "juncType"
    /// <summary>
    /// the AVMrecord specify which is the last bus stop made
    /// <see href="http://www.disit.org/km4city/schema#lastStop"></see></summary>
    let lastStop = _prefix "lastStop"
    /// <summary>
    /// orario in cui il bus ha raggiunto l'ultima fermata DA ELIMINARE QUANDO INSTANT FUNZIONERA' ALLA PERFEZIONE
    /// <see href="http://www.disit.org/km4city/schema#lastStopTime"></see></summary>
    let lastStopTime = _prefix "lastStopTime"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#lastTriples"></see>
    /// </summary>
    let lastTriples = _prefix "lastTriples"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#lastUpdate"></see>
    /// </summary>
    let lastUpdate = _prefix "lastUpdate"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#length"></see>
    /// </summary>
    let length = _prefix "length"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#lineNumber"></see>
    /// </summary>
    let lineNumber = _prefix "lineNumber"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#lunarPhase"></see>
    /// </summary>
    let lunarPhase = _prefix "lunarPhase"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#major"></see>
    /// </summary>
    let major = _prefix "major"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#managingAuth"></see>
    /// </summary>
    let managingAuth = _prefix "managingAuth"
    /// <summary>
    /// the authority that deals with the road elements management
    /// <see href="http://www.disit.org/km4city/schema#managingAuthority"></see></summary>
    let managingAuthority = _prefix "managingAuthority"
    /// <summary>
    /// ente gestore del sistema AVM o dei road sensor
    /// <see href="http://www.disit.org/km4city/schema#managingBy"></see></summary>
    let managingBy = _prefix "managingBy"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#maneuverType"></see>
    /// </summary>
    let maneuverType = _prefix "maneuverType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#maxTemp"></see>
    /// </summary>
    let maxTemp = _prefix "maxTemp"
    /// <summary>
    /// to connect each observation to the beacon that has product it
    /// <see href="http://www.disit.org/km4city/schema#measuredByBeacon"></see></summary>
    let measuredByBeacon = _prefix "measuredByBeacon"
    /// <summary>
    /// each observation refers to only one road sensor
    /// <see href="http://www.disit.org/km4city/schema#measuredBySensor"></see></summary>
    let measuredBySensor = _prefix "measuredBySensor"
    /// <summary>
    /// the time of one observation
    /// <see href="http://www.disit.org/km4city/schema#measuredTime"></see></summary>
    let measuredTime = _prefix "measuredTime"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#minTemp"></see>
    /// </summary>
    let minTemp = _prefix "minTemp"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#minor"></see>
    /// </summary>
    let minor = _prefix "minor"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#moonrise"></see>
    /// </summary>
    let moonrise = _prefix "moonrise"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#moonset"></see>
    /// </summary>
    let moonset = _prefix "moonset"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#multimediaResource"></see>
    /// </summary>
    let multimediaResource = _prefix "multimediaResource"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#nodeType"></see>
    /// </summary>
    let nodeType = _prefix "nodeType"
    /// <summary>
    /// numero di binari presenti. se in costruzione o dismesso inserire uno zero
    /// <see href="http://www.disit.org/km4city/schema#numTrack"></see></summary>
    let numTrack = _prefix "numTrack"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#number"></see>
    /// </summary>
    let number = _prefix "number"
    /// <summary>
    /// the generation time of one situation record
    /// <see href="http://www.disit.org/km4city/schema#observationTime"></see></summary>
    let observationTime = _prefix "observationTime"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#occupancy"></see>
    /// </summary>
    let occupancy = _prefix "occupancy"
    /// <summary>
    /// numero di posti occupati
    /// <see href="http://www.disit.org/km4city/schema#occupied"></see></summary>
    let occupied = _prefix "occupied"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#operatingStatus"></see>
    /// </summary>
    let operatingStatus = _prefix "operatingStatus"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#overtime"></see>
    /// </summary>
    let overtime = _prefix "overtime"
    /// <summary>
    /// sente proprietario del sistema AVM
    /// <see href="http://www.disit.org/km4city/schema#owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    /// the authority that owns the administrative road
    /// <see href="http://www.disit.org/km4city/schema#ownerAuthority"></see></summary>
    let ownerAuthority = _prefix "ownerAuthority"
    /// <summary>
    /// percentuale di posti occupati
    /// <see href="http://www.disit.org/km4city/schema#parkOccupancy"></see></summary>
    let parkOccupancy = _prefix "parkOccupancy"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#perTemp"></see>
    /// </summary>
    let perTemp = _prefix "perTemp"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#period"></see>
    /// </summary>
    let period = _prefix "period"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#placeName"></see>
    /// </summary>
    let placeName = _prefix "placeName"
    /// <summary>
    /// each entry need to refers to a road
    /// <see href="http://www.disit.org/km4city/schema#placedInElement"></see></summary>
    let placedInElement = _prefix "placedInElement"
    /// <summary>
    /// to connect each road sensor to the road in which is installed
    /// <see href="http://www.disit.org/km4city/schema#placedOnRoad"></see></summary>
    let placedOnRoad = _prefix "placedOnRoad"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#porteCochere"></see>
    /// </summary>
    let porteCochere = _prefix "porteCochere"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#power"></see>
    /// </summary>
    let power = _prefix "power"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#primaryType"></see>
    /// </summary>
    let primaryType = _prefix "primaryType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#processType"></see>
    /// </summary>
    let processType = _prefix "processType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#public"></see>
    /// </summary>
    let public_ = _prefix "public"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#railDepartment"></see>
    /// </summary>
    let railDepartment = _prefix "railDepartment"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#railwaySiding"></see>
    /// </summary>
    let railwaySiding = _prefix "railwaySiding"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#recTemp"></see>
    /// </summary>
    let recTemp = _prefix "recTemp"
    /// <summary>
    /// the AVM refer to a specific ride code
    /// <see href="http://www.disit.org/km4city/schema#refersToRide"></see></summary>
    let refersToRide = _prefix "refersToRide"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#restrictionType"></see>
    /// </summary>
    let restrictionType = _prefix "restrictionType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#restrictionValue"></see>
    /// </summary>
    let restrictionValue = _prefix "restrictionValue"
    /// <summary>
    /// stato della corsa: anticipo, ritardo, in orario
    /// <see href="http://www.disit.org/km4city/schema#rideState"></see></summary>
    let rideState = _prefix "rideState"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#roadName"></see>
    /// </summary>
    let roadName = _prefix "roadName"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#roadType"></see>
    /// </summary>
    let roadType = _prefix "roadType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#routeCode"></see>
    /// </summary>
    let routeCode = _prefix "routeCode"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#routeLength"></see>
    /// </summary>
    let routeLength = _prefix "routeLength"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#routePosition"></see>
    /// </summary>
    let routePosition = _prefix "routePosition"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#snow"></see>
    /// </summary>
    let snow = _prefix "snow"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#speedLimit"></see>
    /// </summary>
    let speedLimit = _prefix "speedLimit"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#speedPercentile"></see>
    /// </summary>
    let speedPercentile = _prefix "speedPercentile"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#state"></see>
    /// </summary>
    let state = _prefix "state"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#stopNumber"></see>
    /// </summary>
    let stopNumber = _prefix "stopNumber"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#sunHeight"></see>
    /// </summary>
    let sunHeight = _prefix "sunHeight"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#sunrise"></see>
    /// </summary>
    let sunrise = _prefix "sunrise"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#sunset"></see>
    /// </summary>
    let sunset = _prefix "sunset"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#supply"></see>
    /// </summary>
    let supply = _prefix "supply"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#text"></see>
    /// </summary>
    let text = _prefix "text"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#thresholdPerc"></see>
    /// </summary>
    let thresholdPerc = _prefix "thresholdPerc"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#time"></see>
    /// </summary>
    let time = _prefix "time"
    /// <summary>
    /// ANCHE SE VERRA' INSERITO IL COLLEGAMENTO CON INSTANT, QUESTO ATTRIBUTO NON VA CANCELLATO
    /// <see href="http://www.disit.org/km4city/schema#timestamp"></see></summary>
    let timestamp = _prefix "timestamp"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#trackType"></see>
    /// </summary>
    let trackType = _prefix "trackType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#trafficDir"></see>
    /// </summary>
    let trafficDir = _prefix "trafficDir"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#typeLabel"></see>
    /// </summary>
    let typeLabel = _prefix "typeLabel"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#typeOfResale"></see>
    /// </summary>
    let typeOfResale = _prefix "typeOfResale"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#underpass"></see>
    /// </summary>
    let underpass = _prefix "underpass"
    /// <summary>
    /// the generation time of a new weather report
    /// <see href="http://www.disit.org/km4city/schema#updateTime"></see></summary>
    let updateTime = _prefix "updateTime"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#uuid"></see>
    /// </summary>
    let uuid = _prefix "uuid"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#uv"></see>
    /// </summary>
    let uv = _prefix "uv"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#validityStatus"></see>
    /// </summary>
    let validityStatus = _prefix "validityStatus"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    /// numero di riconoscimento mezzo per azineda TPL
    /// <see href="http://www.disit.org/km4city/schema#vehicle"></see></summary>
    let vehicle = _prefix "vehicle"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#width"></see>
    /// </summary>
    let width = _prefix "width"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#wind"></see>
    /// </summary>
    let wind = _prefix "wind"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#yardType"></see>
    /// </summary>
    let yardType = _prefix "yardType"
    /// <summary>
    ///   <see href="http://www.disit.org/km4city/schema#year"></see>
    /// </summary>
    let year = _prefix "year"
