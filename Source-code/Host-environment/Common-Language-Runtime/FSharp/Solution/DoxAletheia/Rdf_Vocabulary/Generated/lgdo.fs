namespace http.linkedgeodata.org.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module lgdo =
    let _namespace_name = "http://linkedgeodata.org/ontology/"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ATM"></see>
    /// </summary>
    let ATM = Namespaced_IRI.parse _namespace_name "ATM" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ATM/key/amenity/value/ATM"></see>
    /// </summary>
    let ``ATM/key/amenity/value/ATM`` =
        Namespaced_IRI.parse _namespace_name "ATM/key/amenity/value/ATM" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Amenity"></see>
    /// </summary>
    let Amenity = Namespaced_IRI.parse _namespace_name "Amenity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AbandonedRailway"></see>
    /// </summary>
    let AbandonedRailway =
        Namespaced_IRI.parse _namespace_name "AbandonedRailway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AbandonedRailway/key/railway/value/abandoned"></see>
    /// </summary>
    let ``AbandonedRailway/key/railway/value/abandoned`` =
        Namespaced_IRI.parse _namespace_name "AbandonedRailway/key/railway/value/abandoned" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayThing"></see>
    /// </summary>
    let RailwayThing =
        Namespaced_IRI.parse _namespace_name "RailwayThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AbandonedStation"></see>
    /// </summary>
    let AbandonedStation =
        Namespaced_IRI.parse _namespace_name "AbandonedStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AbandonedStation/key/railway/value/abandoned_station"></see>
    /// </summary>
    let ``AbandonedStation/key/railway/value/abandoned_station`` =
        Namespaced_IRI.parse _namespace_name "AbandonedStation/key/railway/value/abandoned_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Abbey"></see>
    /// </summary>
    let Abbey = Namespaced_IRI.parse _namespace_name "Abbey" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Abbey/key/historic/value/abbey"></see>
    /// </summary>
    let ``Abbey/key/historic/value/abbey`` =
        Namespaced_IRI.parse _namespace_name "Abbey/key/historic/value/abbey" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricThing"></see>
    /// </summary>
    let HistoricThing =
        Namespaced_IRI.parse _namespace_name "HistoricThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Abutters"></see>
    /// </summary>
    let Abutters = Namespaced_IRI.parse _namespace_name "Abutters" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AccountantOffice"></see>
    /// </summary>
    let AccountantOffice =
        Namespaced_IRI.parse _namespace_name "AccountantOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AccountantOffice/key/office/value/accountant"></see>
    /// </summary>
    let ``AccountantOffice/key/office/value/accountant`` =
        Namespaced_IRI.parse _namespace_name "AccountantOffice/key/office/value/accountant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Office"></see>
    /// </summary>
    let Office = Namespaced_IRI.parse _namespace_name "Office" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Adit"></see>
    /// </summary>
    let Adit = Namespaced_IRI.parse _namespace_name "Adit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Adit/key/man_made/value/adit"></see>
    /// </summary>
    let ``Adit/key/man_made/value/adit`` =
        Namespaced_IRI.parse _namespace_name "Adit/key/man_made/value/adit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeThing"></see>
    /// </summary>
    let ManMadeThing =
        Namespaced_IRI.parse _namespace_name "ManMadeThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdministrativeBoundary"></see>
    /// </summary>
    let AdministrativeBoundary =
        Namespaced_IRI.parse _namespace_name "AdministrativeBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdministrativeBoundary/key/boundary/value/administrative"></see>
    /// </summary>
    let ``AdministrativeBoundary/key/boundary/value/administrative`` =
        Namespaced_IRI.parse _namespace_name "AdministrativeBoundary/key/boundary/value/administrative" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boundary"></see>
    /// </summary>
    let Boundary = Namespaced_IRI.parse _namespace_name "Boundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdministrativeOffice"></see>
    /// </summary>
    let AdministrativeOffice =
        Namespaced_IRI.parse _namespace_name "AdministrativeOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdministrativeOffice/key/office/value/administrative"></see>
    /// </summary>
    let ``AdministrativeOffice/key/office/value/administrative`` =
        Namespaced_IRI.parse _namespace_name "AdministrativeOffice/key/office/value/administrative" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdultShop"></see>
    /// </summary>
    let AdultShop = Namespaced_IRI.parse _namespace_name "AdultShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdultShop/key/shop/value/adult"></see>
    /// </summary>
    let ``AdultShop/key/shop/value/adult`` =
        Namespaced_IRI.parse _namespace_name "AdultShop/key/shop/value/adult" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shop"></see>
    /// </summary>
    let Shop = Namespaced_IRI.parse _namespace_name "Shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Advertisement"></see>
    /// </summary>
    let Advertisement =
        Namespaced_IRI.parse _namespace_name "Advertisement" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Advertisement/key/amenity/value/advertisement"></see>
    /// </summary>
    let ``Advertisement/key/amenity/value/advertisement`` =
        Namespaced_IRI.parse _namespace_name "Advertisement/key/amenity/value/advertisement" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Advertising"></see>
    /// </summary>
    let Advertising =
        Namespaced_IRI.parse _namespace_name "Advertising" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Advertising/key/amenity/value/advertising"></see>
    /// </summary>
    let ``Advertising/key/amenity/value/advertising`` =
        Namespaced_IRI.parse _namespace_name "Advertising/key/amenity/value/advertising" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayGoods"></see>
    /// </summary>
    let AerialwayGoods =
        Namespaced_IRI.parse _namespace_name "AerialwayGoods" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayGoods/key/aerialway/value/goods"></see>
    /// </summary>
    let ``AerialwayGoods/key/aerialway/value/goods`` =
        Namespaced_IRI.parse _namespace_name "AerialwayGoods/key/aerialway/value/goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayThing"></see>
    /// </summary>
    let AerialwayThing =
        Namespaced_IRI.parse _namespace_name "AerialwayThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayStation"></see>
    /// </summary>
    let AerialwayStation =
        Namespaced_IRI.parse _namespace_name "AerialwayStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayStation/key/aerialway/value/station"></see>
    /// </summary>
    let ``AerialwayStation/key/aerialway/value/station`` =
        Namespaced_IRI.parse _namespace_name "AerialwayStation/key/aerialway/value/station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerowayThing"></see>
    /// </summary>
    let AerowayThing =
        Namespaced_IRI.parse _namespace_name "AerowayThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Agrarian"></see>
    /// </summary>
    let Agrarian = Namespaced_IRI.parse _namespace_name "Agrarian" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Agrarian/key/shop/value/agrarian"></see>
    /// </summary>
    let ``Agrarian/key/shop/value/agrarian`` =
        Namespaced_IRI.parse _namespace_name "Agrarian/key/shop/value/agrarian" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AgriculturalEnginesCraft"></see>
    /// </summary>
    let AgriculturalEnginesCraft =
        Namespaced_IRI.parse _namespace_name "AgriculturalEnginesCraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AgriculturalEnginesCraft/key/craft/value/agricultural_engines"></see>
    /// </summary>
    let ``AgriculturalEnginesCraft/key/craft/value/agricultural_engines`` =
        Namespaced_IRI.parse _namespace_name "AgriculturalEnginesCraft/key/craft/value/agricultural_engines" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Craft"></see>
    /// </summary>
    let Craft = Namespaced_IRI.parse _namespace_name "Craft" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirFill"></see>
    /// </summary>
    let AirFill = Namespaced_IRI.parse _namespace_name "AirFill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirFill/key/amenity/value/air_fill"></see>
    /// </summary>
    let ``AirFill/key/amenity/value/air_fill`` =
        Namespaced_IRI.parse _namespace_name "AirFill/key/amenity/value/air_fill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airplane"></see>
    /// </summary>
    let Airplane = Namespaced_IRI.parse _namespace_name "Airplane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airplane/key/amenity/value/airplane"></see>
    /// </summary>
    let ``Airplane/key/amenity/value/airplane`` =
        Namespaced_IRI.parse _namespace_name "Airplane/key/amenity/value/airplane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airport"></see>
    /// </summary>
    let Airport = Namespaced_IRI.parse _namespace_name "Airport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airport/key/aeroway/value/aerodrome"></see>
    /// </summary>
    let ``Airport/key/aeroway/value/aerodrome`` =
        Namespaced_IRI.parse _namespace_name "Airport/key/aeroway/value/aerodrome" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airport/key/amenity/value/airport"></see>
    /// </summary>
    let ``Airport/key/amenity/value/airport`` =
        Namespaced_IRI.parse _namespace_name "Airport/key/amenity/value/airport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportField"></see>
    /// </summary>
    let AirportField =
        Namespaced_IRI.parse _namespace_name "AirportField" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportField/key/aeroway/value/airfield"></see>
    /// </summary>
    let ``AirportField/key/aeroway/value/airfield`` =
        Namespaced_IRI.parse _namespace_name "AirportField/key/aeroway/value/airfield" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportGate"></see>
    /// </summary>
    let AirportGate =
        Namespaced_IRI.parse _namespace_name "AirportGate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportGate/key/aeroway/value/gate"></see>
    /// </summary>
    let ``AirportGate/key/aeroway/value/gate`` =
        Namespaced_IRI.parse _namespace_name "AirportGate/key/aeroway/value/gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTaxiway"></see>
    /// </summary>
    let AirportTaxiway =
        Namespaced_IRI.parse _namespace_name "AirportTaxiway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTaxiway/key/aeroway/value/taxiway"></see>
    /// </summary>
    let ``AirportTaxiway/key/aeroway/value/taxiway`` =
        Namespaced_IRI.parse _namespace_name "AirportTaxiway/key/aeroway/value/taxiway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTerminal"></see>
    /// </summary>
    let AirportTerminal =
        Namespaced_IRI.parse _namespace_name "AirportTerminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTerminal/key/aeroway/value/terminal"></see>
    /// </summary>
    let ``AirportTerminal/key/aeroway/value/terminal`` =
        Namespaced_IRI.parse _namespace_name "AirportTerminal/key/aeroway/value/terminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTower"></see>
    /// </summary>
    let AirportTower =
        Namespaced_IRI.parse _namespace_name "AirportTower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTower/key/aeroway/value/tower"></see>
    /// </summary>
    let ``AirportTower/key/aeroway/value/tower`` =
        Namespaced_IRI.parse _namespace_name "AirportTower/key/aeroway/value/tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AlcoholShop"></see>
    /// </summary>
    let AlcoholShop =
        Namespaced_IRI.parse _namespace_name "AlcoholShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AlcoholShop/key/shop/value/alcohol"></see>
    /// </summary>
    let ``AlcoholShop/key/shop/value/alcohol`` =
        Namespaced_IRI.parse _namespace_name "AlcoholShop/key/shop/value/alcohol" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Alley"></see>
    /// </summary>
    let Alley = Namespaced_IRI.parse _namespace_name "Alley" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Alley/key/service/value/alley"></see>
    /// </summary>
    let ``Alley/key/service/value/alley`` =
        Namespaced_IRI.parse _namespace_name "Alley/key/service/value/alley" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Allotments"></see>
    /// </summary>
    let Allotments = Namespaced_IRI.parse _namespace_name "Allotments" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Allotments/key/landuse/value/allotments"></see>
    /// </summary>
    let ``Allotments/key/landuse/value/allotments`` =
        Namespaced_IRI.parse _namespace_name "Allotments/key/landuse/value/allotments" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landuse"></see>
    /// </summary>
    let Landuse = Namespaced_IRI.parse _namespace_name "Landuse" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Alm"></see>
    /// </summary>
    let Alm = Namespaced_IRI.parse _namespace_name "Alm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Alm/key/amenity/value/alm"></see>
    /// </summary>
    let ``Alm/key/amenity/value/alm`` =
        Namespaced_IRI.parse _namespace_name "Alm/key/amenity/value/alm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AlpineHut"></see>
    /// </summary>
    let AlpineHut = Namespaced_IRI.parse _namespace_name "AlpineHut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AlpineHut/key/tourism/value/alpine_hut"></see>
    /// </summary>
    let ``AlpineHut/key/tourism/value/alpine_hut`` =
        Namespaced_IRI.parse _namespace_name "AlpineHut/key/tourism/value/alpine_hut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TourismThing"></see>
    /// </summary>
    let TourismThing =
        Namespaced_IRI.parse _namespace_name "TourismThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ambulance"></see>
    /// </summary>
    let Ambulance = Namespaced_IRI.parse _namespace_name "Ambulance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ambulance/key/amenity/value/ambulance"></see>
    /// </summary>
    let ``Ambulance/key/amenity/value/ambulance`` =
        Namespaced_IRI.parse _namespace_name "Ambulance/key/amenity/value/ambulance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AmbulanceStation"></see>
    /// </summary>
    let AmbulanceStation =
        Namespaced_IRI.parse _namespace_name "AmbulanceStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AmbulanceStation/key/amenity/value/ambulance_station"></see>
    /// </summary>
    let ``AmbulanceStation/key/amenity/value/ambulance_station`` =
        Namespaced_IRI.parse _namespace_name "AmbulanceStation/key/amenity/value/ambulance_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AmbulanceStation/key/emergency/value/ambulance_station"></see>
    /// </summary>
    let ``AmbulanceStation/key/emergency/value/ambulance_station`` =
        Namespaced_IRI.parse _namespace_name "AmbulanceStation/key/emergency/value/ambulance_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyThing"></see>
    /// </summary>
    let EmergencyThing =
        Namespaced_IRI.parse _namespace_name "EmergencyThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Amenity/key/amenity/value/leisure"></see>
    /// </summary>
    let ``Amenity/key/amenity/value/leisure`` =
        Namespaced_IRI.parse _namespace_name "Amenity/key/amenity/value/leisure" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalShelter"></see>
    /// </summary>
    let AnimalShelter =
        Namespaced_IRI.parse _namespace_name "AnimalShelter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalShelter/key/amenity/value/animal_shelter"></see>
    /// </summary>
    let ``AnimalShelter/key/amenity/value/animal_shelter`` =
        Namespaced_IRI.parse _namespace_name "AnimalShelter/key/amenity/value/animal_shelter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalShop"></see>
    /// </summary>
    let AnimalShop = Namespaced_IRI.parse _namespace_name "AnimalShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalShop/key/shop/value/animal"></see>
    /// </summary>
    let ``AnimalShop/key/shop/value/animal`` =
        Namespaced_IRI.parse _namespace_name "AnimalShop/key/shop/value/animal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalsShop"></see>
    /// </summary>
    let AnimalsShop =
        Namespaced_IRI.parse _namespace_name "AnimalsShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalsShop/key/shop/value/animals"></see>
    /// </summary>
    let ``AnimalsShop/key/shop/value/animals`` =
        Namespaced_IRI.parse _namespace_name "AnimalsShop/key/shop/value/animals" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimeShop"></see>
    /// </summary>
    let AnimeShop = Namespaced_IRI.parse _namespace_name "AnimeShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimeShop/key/shop/value/anime"></see>
    /// </summary>
    let ``AnimeShop/key/shop/value/anime`` =
        Namespaced_IRI.parse _namespace_name "AnimeShop/key/shop/value/anime" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Antenna"></see>
    /// </summary>
    let Antenna = Namespaced_IRI.parse _namespace_name "Antenna" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Antenna/key/man_made/value/antenna"></see>
    /// </summary>
    let ``Antenna/key/man_made/value/antenna`` =
        Namespaced_IRI.parse _namespace_name "Antenna/key/man_made/value/antenna" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiqueShop"></see>
    /// </summary>
    let AntiqueShop =
        Namespaced_IRI.parse _namespace_name "AntiqueShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiqueShop/key/shop/value/antique"></see>
    /// </summary>
    let ``AntiqueShop/key/shop/value/antique`` =
        Namespaced_IRI.parse _namespace_name "AntiqueShop/key/shop/value/antique" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiquesShop"></see>
    /// </summary>
    let AntiquesShop =
        Namespaced_IRI.parse _namespace_name "AntiquesShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiquesShop/key/shop/value/antiques"></see>
    /// </summary>
    let ``AntiquesShop/key/shop/value/antiques`` =
        Namespaced_IRI.parse _namespace_name "AntiquesShop/key/shop/value/antiques" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiquitiesShop"></see>
    /// </summary>
    let AntiquitiesShop =
        Namespaced_IRI.parse _namespace_name "AntiquitiesShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiquitiesShop/key/shop/value/antiquities"></see>
    /// </summary>
    let ``AntiquitiesShop/key/shop/value/antiquities`` =
        Namespaced_IRI.parse _namespace_name "AntiquitiesShop/key/shop/value/antiquities" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ApartmentBuilding"></see>
    /// </summary>
    let ApartmentBuilding =
        Namespaced_IRI.parse _namespace_name "ApartmentBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ApartmentBuilding/key/building/value/apartments"></see>
    /// </summary>
    let ``ApartmentBuilding/key/building/value/apartments`` =
        Namespaced_IRI.parse _namespace_name "ApartmentBuilding/key/building/value/apartments" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Building"></see>
    /// </summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Apparel"></see>
    /// </summary>
    let Apparel = Namespaced_IRI.parse _namespace_name "Apparel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Apparel/key/shop/value/apparel"></see>
    /// </summary>
    let ``Apparel/key/shop/value/apparel`` =
        Namespaced_IRI.parse _namespace_name "Apparel/key/shop/value/apparel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Appliance"></see>
    /// </summary>
    let Appliance = Namespaced_IRI.parse _namespace_name "Appliance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Appliance/key/shop/value/appliance"></see>
    /// </summary>
    let ``Appliance/key/shop/value/appliance`` =
        Namespaced_IRI.parse _namespace_name "Appliance/key/shop/value/appliance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Appliances"></see>
    /// </summary>
    let Appliances = Namespaced_IRI.parse _namespace_name "Appliances" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Appliances/key/shop/value/appliances"></see>
    /// </summary>
    let ``Appliances/key/shop/value/appliances`` =
        Namespaced_IRI.parse _namespace_name "Appliances/key/shop/value/appliances" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Apron"></see>
    /// </summary>
    let Apron = Namespaced_IRI.parse _namespace_name "Apron" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Apron/key/aeroway/value/apron"></see>
    /// </summary>
    let ``Apron/key/aeroway/value/apron`` =
        Namespaced_IRI.parse _namespace_name "Apron/key/aeroway/value/apron" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Aqueduct"></see>
    /// </summary>
    let Aqueduct = Namespaced_IRI.parse _namespace_name "Aqueduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Aqueduct/key/waterway/value/aqueduct"></see>
    /// </summary>
    let ``Aqueduct/key/waterway/value/aqueduct`` =
        Namespaced_IRI.parse _namespace_name "Aqueduct/key/waterway/value/aqueduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayThing"></see>
    /// </summary>
    let WaterwayThing =
        Namespaced_IRI.parse _namespace_name "WaterwayThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArchaeologicalSite"></see>
    /// </summary>
    let ArchaeologicalSite =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArchaeologicalSite/key/historic/value/archaeological_site"></see>
    /// </summary>
    let ``ArchaeologicalSite/key/historic/value/archaeological_site`` =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalSite/key/historic/value/archaeological_site" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArchitectOffice"></see>
    /// </summary>
    let ArchitectOffice =
        Namespaced_IRI.parse _namespace_name "ArchitectOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArchitectOffice/key/office/value/architect"></see>
    /// </summary>
    let ``ArchitectOffice/key/office/value/architect`` =
        Namespaced_IRI.parse _namespace_name "ArchitectOffice/key/office/value/architect" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtGallery"></see>
    /// </summary>
    let ArtGallery = Namespaced_IRI.parse _namespace_name "ArtGallery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtGallery/key/amenity/value/art_gallery"></see>
    /// </summary>
    let ``ArtGallery/key/amenity/value/art_gallery`` =
        Namespaced_IRI.parse _namespace_name "ArtGallery/key/amenity/value/art_gallery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtGalleryShop"></see>
    /// </summary>
    let ArtGalleryShop =
        Namespaced_IRI.parse _namespace_name "ArtGalleryShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtGalleryShop/key/shop/value/art_gallery"></see>
    /// </summary>
    let ``ArtGalleryShop/key/shop/value/art_gallery`` =
        Namespaced_IRI.parse _namespace_name "ArtGalleryShop/key/shop/value/art_gallery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtShop"></see>
    /// </summary>
    let ArtShop = Namespaced_IRI.parse _namespace_name "ArtShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtShop/key/shop/value/art"></see>
    /// </summary>
    let ``ArtShop/key/shop/value/art`` =
        Namespaced_IRI.parse _namespace_name "ArtShop/key/shop/value/art" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtSupplies"></see>
    /// </summary>
    let ArtSupplies =
        Namespaced_IRI.parse _namespace_name "ArtSupplies" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtSupplies/key/shop/value/art_supplies"></see>
    /// </summary>
    let ``ArtSupplies/key/shop/value/art_supplies`` =
        Namespaced_IRI.parse _namespace_name "ArtSupplies/key/shop/value/art_supplies" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtsCentre"></see>
    /// </summary>
    let ArtsCentre = Namespaced_IRI.parse _namespace_name "ArtsCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtsCentre/key/amenity/value/arts_centre"></see>
    /// </summary>
    let ``ArtsCentre/key/amenity/value/arts_centre`` =
        Namespaced_IRI.parse _namespace_name "ArtsCentre/key/amenity/value/arts_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Artwork"></see>
    /// </summary>
    let Artwork = Namespaced_IRI.parse _namespace_name "Artwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Artwork/key/tourism/value/artwork"></see>
    /// </summary>
    let ``Artwork/key/tourism/value/artwork`` =
        Namespaced_IRI.parse _namespace_name "Artwork/key/tourism/value/artwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Artwork/key/amenity/value/artwork"></see>
    /// </summary>
    let ``Artwork/key/amenity/value/artwork`` =
        Namespaced_IRI.parse _namespace_name "Artwork/key/amenity/value/artwork" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Atm"></see>
    /// </summary>
    let Atm = Namespaced_IRI.parse _namespace_name "Atm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Atm/key/amenity/value/atm"></see>
    /// </summary>
    let ``Atm/key/amenity/value/atm`` =
        Namespaced_IRI.parse _namespace_name "Atm/key/amenity/value/atm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Attraction"></see>
    /// </summary>
    let Attraction = Namespaced_IRI.parse _namespace_name "Attraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Attraction/key/tourism/value/attraction"></see>
    /// </summary>
    let ``Attraction/key/tourism/value/attraction`` =
        Namespaced_IRI.parse _namespace_name "Attraction/key/tourism/value/attraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AudioVideoShop"></see>
    /// </summary>
    let AudioVideoShop =
        Namespaced_IRI.parse _namespace_name "AudioVideoShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AudioVideoShop/key/shop/value/audio_video"></see>
    /// </summary>
    let ``AudioVideoShop/key/shop/value/audio_video`` =
        Namespaced_IRI.parse _namespace_name "AudioVideoShop/key/shop/value/audio_video" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Audiologist"></see>
    /// </summary>
    let Audiologist =
        Namespaced_IRI.parse _namespace_name "Audiologist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Audiologist/key/shop/value/audiologist"></see>
    /// </summary>
    let ``Audiologist/key/shop/value/audiologist`` =
        Namespaced_IRI.parse _namespace_name "Audiologist/key/shop/value/audiologist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutoPartsShop"></see>
    /// </summary>
    let AutoPartsShop =
        Namespaced_IRI.parse _namespace_name "AutoPartsShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutoPartsShop/key/shop/value/auto_parts"></see>
    /// </summary>
    let ``AutoPartsShop/key/shop/value/auto_parts`` =
        Namespaced_IRI.parse _namespace_name "AutoPartsShop/key/shop/value/auto_parts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutoRepair"></see>
    /// </summary>
    let AutoRepair = Namespaced_IRI.parse _namespace_name "AutoRepair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutoRepair/key/shop/value/auto_repair"></see>
    /// </summary>
    let ``AutoRepair/key/shop/value/auto_repair`` =
        Namespaced_IRI.parse _namespace_name "AutoRepair/key/shop/value/auto_repair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutomotiveShop"></see>
    /// </summary>
    let AutomotiveShop =
        Namespaced_IRI.parse _namespace_name "AutomotiveShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutomotiveShop/key/shop/value/automotive"></see>
    /// </summary>
    let ``AutomotiveShop/key/shop/value/automotive`` =
        Namespaced_IRI.parse _namespace_name "AutomotiveShop/key/shop/value/automotive" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyGoodsShop"></see>
    /// </summary>
    let BabyGoodsShop =
        Namespaced_IRI.parse _namespace_name "BabyGoodsShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyGoodsShop/key/shop/value/baby_goods"></see>
    /// </summary>
    let ``BabyGoodsShop/key/shop/value/baby_goods`` =
        Namespaced_IRI.parse _namespace_name "BabyGoodsShop/key/shop/value/baby_goods" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyHatch"></see>
    /// </summary>
    let BabyHatch = Namespaced_IRI.parse _namespace_name "BabyHatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyHatch/key/amenity/value/baby_hatch"></see>
    /// </summary>
    let ``BabyHatch/key/amenity/value/baby_hatch`` =
        Namespaced_IRI.parse _namespace_name "BabyHatch/key/amenity/value/baby_hatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyShop"></see>
    /// </summary>
    let BabyShop = Namespaced_IRI.parse _namespace_name "BabyShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyShop/key/shop/value/baby"></see>
    /// </summary>
    let ``BabyShop/key/shop/value/baby`` =
        Namespaced_IRI.parse _namespace_name "BabyShop/key/shop/value/baby" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BagsShop"></see>
    /// </summary>
    let BagsShop = Namespaced_IRI.parse _namespace_name "BagsShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BagsShop/key/shop/value/bags"></see>
    /// </summary>
    let ``BagsShop/key/shop/value/bags`` =
        Namespaced_IRI.parse _namespace_name "BagsShop/key/shop/value/bags" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Baisschool"></see>
    /// </summary>
    let Baisschool = Namespaced_IRI.parse _namespace_name "Baisschool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Baisschool/key/amenity/value/Baisschool"></see>
    /// </summary>
    let ``Baisschool/key/amenity/value/Baisschool`` =
        Namespaced_IRI.parse _namespace_name "Baisschool/key/amenity/value/Baisschool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bakery"></see>
    /// </summary>
    let Bakery = Namespaced_IRI.parse _namespace_name "Bakery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bakery/key/shop/value/bakery"></see>
    /// </summary>
    let ``Bakery/key/shop/value/bakery`` =
        Namespaced_IRI.parse _namespace_name "Bakery/key/shop/value/bakery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bakery/key/amenity/value/bakery"></see>
    /// </summary>
    let ``Bakery/key/amenity/value/bakery`` =
        Namespaced_IRI.parse _namespace_name "Bakery/key/amenity/value/bakery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bandstand"></see>
    /// </summary>
    let Bandstand = Namespaced_IRI.parse _namespace_name "Bandstand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bandstand/key/amenity/value/bandstand"></see>
    /// </summary>
    let ``Bandstand/key/amenity/value/bandstand`` =
        Namespaced_IRI.parse _namespace_name "Bandstand/key/amenity/value/bandstand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bandstand/key/leisure/value/bandstand"></see>
    /// </summary>
    let ``Bandstand/key/leisure/value/bandstand`` =
        Namespaced_IRI.parse _namespace_name "Bandstand/key/leisure/value/bandstand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Leisure"></see>
    /// </summary>
    let Leisure = Namespaced_IRI.parse _namespace_name "Leisure" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank"></see>
    /// </summary>
    let Bank = Namespaced_IRI.parse _namespace_name "Bank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank/key/amenity/value/Bank"></see>
    /// </summary>
    let ``Bank/key/amenity/value/Bank`` =
        Namespaced_IRI.parse _namespace_name "Bank/key/amenity/value/Bank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank/key/amenity/value/bank"></see>
    /// </summary>
    let ``Bank/key/amenity/value/bank`` =
        Namespaced_IRI.parse _namespace_name "Bank/key/amenity/value/bank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank%2Catm"></see>
    /// </summary>
    let ``Bank%2Catm`` =
        Namespaced_IRI.parse _namespace_name "Bank%2Catm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank%2Catm/key/amenity/value/bank%2Catm"></see>
    /// </summary>
    let ``Bank%2Catm/key/amenity/value/bank%2Catm`` =
        Namespaced_IRI.parse _namespace_name "Bank%2Catm/key/amenity/value/bank%2Catm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank%3Batm"></see>
    /// </summary>
    let ``Bank%3Batm`` =
        Namespaced_IRI.parse _namespace_name "Bank%3Batm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank%3Batm/key/amenity/value/bank%3Batm"></see>
    /// </summary>
    let ``Bank%3Batm/key/amenity/value/bank%3Batm`` =
        Namespaced_IRI.parse _namespace_name "Bank%3Batm/key/amenity/value/bank%3Batm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bar"></see>
    /// </summary>
    let Bar = Namespaced_IRI.parse _namespace_name "Bar" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bar/key/amenity/value/bar"></see>
    /// </summary>
    let ``Bar/key/amenity/value/bar`` =
        Namespaced_IRI.parse _namespace_name "Bar/key/amenity/value/bar" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barbeque"></see>
    /// </summary>
    let Barbeque = Namespaced_IRI.parse _namespace_name "Barbeque" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barbeque/key/amenity/value/barbeque"></see>
    /// </summary>
    let ``Barbeque/key/amenity/value/barbeque`` =
        Namespaced_IRI.parse _namespace_name "Barbeque/key/amenity/value/barbeque" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barber"></see>
    /// </summary>
    let Barber = Namespaced_IRI.parse _namespace_name "Barber" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barber/key/shop/value/barber"></see>
    /// </summary>
    let ``Barber/key/shop/value/barber`` =
        Namespaced_IRI.parse _namespace_name "Barber/key/shop/value/barber" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barfusspfad"></see>
    /// </summary>
    let Barfusspfad =
        Namespaced_IRI.parse _namespace_name "Barfusspfad" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barfusspfad/key/amenity/value/Barfusspfad"></see>
    /// </summary>
    let ``Barfusspfad/key/amenity/value/Barfusspfad`` =
        Namespaced_IRI.parse _namespace_name "Barfusspfad/key/amenity/value/Barfusspfad" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barracks"></see>
    /// </summary>
    let Barracks = Namespaced_IRI.parse _namespace_name "Barracks" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barracks/key/military/value/barracks"></see>
    /// </summary>
    let ``Barracks/key/military/value/barracks`` =
        Namespaced_IRI.parse _namespace_name "Barracks/key/military/value/barracks" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryThing"></see>
    /// </summary>
    let MilitaryThing =
        Namespaced_IRI.parse _namespace_name "MilitaryThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BarrierThing"></see>
    /// </summary>
    let BarrierThing =
        Namespaced_IRI.parse _namespace_name "BarrierThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Basin"></see>
    /// </summary>
    let Basin = Namespaced_IRI.parse _namespace_name "Basin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Basin/key/landuse/value/basin"></see>
    /// </summary>
    let ``Basin/key/landuse/value/basin`` =
        Namespaced_IRI.parse _namespace_name "Basin/key/landuse/value/basin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BasketMaker"></see>
    /// </summary>
    let BasketMaker =
        Namespaced_IRI.parse _namespace_name "BasketMaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BasketMaker/key/craft/value/basket_maker"></see>
    /// </summary>
    let ``BasketMaker/key/craft/value/basket_maker`` =
        Namespaced_IRI.parse _namespace_name "BasketMaker/key/craft/value/basket_maker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bathroom"></see>
    /// </summary>
    let Bathroom = Namespaced_IRI.parse _namespace_name "Bathroom" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bathroom/key/shop/value/bathroom"></see>
    /// </summary>
    let ``Bathroom/key/shop/value/bathroom`` =
        Namespaced_IRI.parse _namespace_name "Bathroom/key/shop/value/bathroom" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BathroomFurnishingShop"></see>
    /// </summary>
    let BathroomFurnishingShop =
        Namespaced_IRI.parse _namespace_name "BathroomFurnishingShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BathroomFurnishingShop/key/shop/value/bathroom_furnishing"></see>
    /// </summary>
    let ``BathroomFurnishingShop/key/shop/value/bathroom_furnishing`` =
        Namespaced_IRI.parse _namespace_name "BathroomFurnishingShop/key/shop/value/bathroom_furnishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Battlefield"></see>
    /// </summary>
    let Battlefield =
        Namespaced_IRI.parse _namespace_name "Battlefield" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Battlefield/key/historic/value/battlefield%20"></see>
    /// </summary>
    let ``Battlefield/key/historic/value/battlefield%20`` =
        Namespaced_IRI.parse _namespace_name "Battlefield/key/historic/value/battlefield%20" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bay"></see>
    /// </summary>
    let Bay = Namespaced_IRI.parse _namespace_name "Bay" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bay/key/natural/value/bay"></see>
    /// </summary>
    let ``Bay/key/natural/value/bay`` =
        Namespaced_IRI.parse _namespace_name "Bay/key/natural/value/bay" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalThing"></see>
    /// </summary>
    let NaturalThing =
        Namespaced_IRI.parse _namespace_name "NaturalThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bbq"></see>
    /// </summary>
    let Bbq = Namespaced_IRI.parse _namespace_name "Bbq" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bbq/key/amenity/value/bbq"></see>
    /// </summary>
    let ``Bbq/key/amenity/value/bbq`` =
        Namespaced_IRI.parse _namespace_name "Bbq/key/amenity/value/bbq" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beach"></see>
    /// </summary>
    let Beach = Namespaced_IRI.parse _namespace_name "Beach" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beach/key/leisure/value/beach"></see>
    /// </summary>
    let ``Beach/key/leisure/value/beach`` =
        Namespaced_IRI.parse _namespace_name "Beach/key/leisure/value/beach" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beach/key/natural/value/beach"></see>
    /// </summary>
    let ``Beach/key/natural/value/beach`` =
        Namespaced_IRI.parse _namespace_name "Beach/key/natural/value/beach" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeachResort"></see>
    /// </summary>
    let BeachResort =
        Namespaced_IRI.parse _namespace_name "BeachResort" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeachResort/key/leisure/value/beach_resort"></see>
    /// </summary>
    let ``BeachResort/key/leisure/value/beach_resort`` =
        Namespaced_IRI.parse _namespace_name "BeachResort/key/leisure/value/beach_resort" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beacon"></see>
    /// </summary>
    let Beacon = Namespaced_IRI.parse _namespace_name "Beacon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beacon/key/man_made/value/beacon"></see>
    /// </summary>
    let ``Beacon/key/man_made/value/beacon`` =
        Namespaced_IRI.parse _namespace_name "Beacon/key/man_made/value/beacon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beautician"></see>
    /// </summary>
    let Beautician = Namespaced_IRI.parse _namespace_name "Beautician" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beautician/key/shop/value/beautician"></see>
    /// </summary>
    let ``Beautician/key/shop/value/beautician`` =
        Namespaced_IRI.parse _namespace_name "Beautician/key/shop/value/beautician" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeautySalon"></see>
    /// </summary>
    let BeautySalon =
        Namespaced_IRI.parse _namespace_name "BeautySalon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeautySalon/key/shop/value/beauty_salon"></see>
    /// </summary>
    let ``BeautySalon/key/shop/value/beauty_salon`` =
        Namespaced_IRI.parse _namespace_name "BeautySalon/key/shop/value/beauty_salon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeautyShop"></see>
    /// </summary>
    let BeautyShop = Namespaced_IRI.parse _namespace_name "BeautyShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeautyShop/key/shop/value/beauty"></see>
    /// </summary>
    let ``BeautyShop/key/shop/value/beauty`` =
        Namespaced_IRI.parse _namespace_name "BeautyShop/key/shop/value/beauty" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BedAndBreakfast"></see>
    /// </summary>
    let BedAndBreakfast =
        Namespaced_IRI.parse _namespace_name "BedAndBreakfast" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BedAndBreakfast/key/tourism/value/bed_and_breakfast"></see>
    /// </summary>
    let ``BedAndBreakfast/key/tourism/value/bed_and_breakfast`` =
        Namespaced_IRI.parse _namespace_name "BedAndBreakfast/key/tourism/value/bed_and_breakfast" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BedShop"></see>
    /// </summary>
    let BedShop = Namespaced_IRI.parse _namespace_name "BedShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BedShop/key/shop/value/bed"></see>
    /// </summary>
    let ``BedShop/key/shop/value/bed`` =
        Namespaced_IRI.parse _namespace_name "BedShop/key/shop/value/bed" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bedrock"></see>
    /// </summary>
    let Bedrock = Namespaced_IRI.parse _namespace_name "Bedrock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bedrock/key/natural/value/bedrock"></see>
    /// </summary>
    let ``Bedrock/key/natural/value/bedrock`` =
        Namespaced_IRI.parse _namespace_name "Bedrock/key/natural/value/bedrock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beekeeper"></see>
    /// </summary>
    let Beekeeper = Namespaced_IRI.parse _namespace_name "Beekeeper" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beekeeper/key/craft/value/beekeeper"></see>
    /// </summary>
    let ``Beekeeper/key/craft/value/beekeeper`` =
        Namespaced_IRI.parse _namespace_name "Beekeeper/key/craft/value/beekeeper" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bench"></see>
    /// </summary>
    let Bench = Namespaced_IRI.parse _namespace_name "Bench" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bench/key/amenity/value/bench"></see>
    /// </summary>
    let ``Bench/key/amenity/value/bench`` =
        Namespaced_IRI.parse _namespace_name "Bench/key/amenity/value/bench" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Betting"></see>
    /// </summary>
    let Betting = Namespaced_IRI.parse _namespace_name "Betting" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Betting/key/shop/value/betting"></see>
    /// </summary>
    let ``Betting/key/shop/value/betting`` =
        Namespaced_IRI.parse _namespace_name "Betting/key/shop/value/betting" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeverageMarket"></see>
    /// </summary>
    let BeverageMarket =
        Namespaced_IRI.parse _namespace_name "BeverageMarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeverageMarket/key/shop/value/beverages"></see>
    /// </summary>
    let ``BeverageMarket/key/shop/value/beverages`` =
        Namespaced_IRI.parse _namespace_name "BeverageMarket/key/shop/value/beverages" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleLockers"></see>
    /// </summary>
    let BicycleLockers =
        Namespaced_IRI.parse _namespace_name "BicycleLockers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleLockers/key/amenity/value/bicycle_lockers"></see>
    /// </summary>
    let ``BicycleLockers/key/amenity/value/bicycle_lockers`` =
        Namespaced_IRI.parse _namespace_name "BicycleLockers/key/amenity/value/bicycle_lockers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleParking"></see>
    /// </summary>
    let BicycleParking =
        Namespaced_IRI.parse _namespace_name "BicycleParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleParking/key/amenity/value/bicycle_parking"></see>
    /// </summary>
    let ``BicycleParking/key/amenity/value/bicycle_parking`` =
        Namespaced_IRI.parse _namespace_name "BicycleParking/key/amenity/value/bicycle_parking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleRental"></see>
    /// </summary>
    let BicycleRental =
        Namespaced_IRI.parse _namespace_name "BicycleRental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleRental/key/amenity/value/bicycle_rental"></see>
    /// </summary>
    let ``BicycleRental/key/amenity/value/bicycle_rental`` =
        Namespaced_IRI.parse _namespace_name "BicycleRental/key/amenity/value/bicycle_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleRoute"></see>
    /// </summary>
    let BicycleRoute =
        Namespaced_IRI.parse _namespace_name "BicycleRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleRoute/key/route/value/bicycle"></see>
    /// </summary>
    let ``BicycleRoute/key/route/value/bicycle`` =
        Namespaced_IRI.parse _namespace_name "BicycleRoute/key/route/value/bicycle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RouteThing"></see>
    /// </summary>
    let RouteThing = Namespaced_IRI.parse _namespace_name "RouteThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleShop"></see>
    /// </summary>
    let BicycleShop =
        Namespaced_IRI.parse _namespace_name "BicycleShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleShop/key/shop/value/bicycle"></see>
    /// </summary>
    let ``BicycleShop/key/shop/value/bicycle`` =
        Namespaced_IRI.parse _namespace_name "BicycleShop/key/shop/value/bicycle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Biergarten"></see>
    /// </summary>
    let Biergarten = Namespaced_IRI.parse _namespace_name "Biergarten" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Biergarten/key/amenity/value/biergarten"></see>
    /// </summary>
    let ``Biergarten/key/amenity/value/biergarten`` =
        Namespaced_IRI.parse _namespace_name "Biergarten/key/amenity/value/biergarten" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Billboard"></see>
    /// </summary>
    let Billboard = Namespaced_IRI.parse _namespace_name "Billboard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Billboard/key/amenity/value/billboard"></see>
    /// </summary>
    let ``Billboard/key/amenity/value/billboard`` =
        Namespaced_IRI.parse _namespace_name "Billboard/key/amenity/value/billboard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bingo"></see>
    /// </summary>
    let Bingo = Namespaced_IRI.parse _namespace_name "Bingo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bingo/key/leisure/value/bingo"></see>
    /// </summary>
    let ``Bingo/key/leisure/value/bingo`` =
        Namespaced_IRI.parse _namespace_name "Bingo/key/leisure/value/bingo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BirdHide"></see>
    /// </summary>
    let BirdHide = Namespaced_IRI.parse _namespace_name "BirdHide" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BirdHide/key/leisure/value/bird_hide"></see>
    /// </summary>
    let ``BirdHide/key/leisure/value/bird_hide`` =
        Namespaced_IRI.parse _namespace_name "BirdHide/key/leisure/value/bird_hide" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Biwak"></see>
    /// </summary>
    let Biwak = Namespaced_IRI.parse _namespace_name "Biwak" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Biwak/key/waterway/value/biwak"></see>
    /// </summary>
    let ``Biwak/key/waterway/value/biwak`` =
        Namespaced_IRI.parse _namespace_name "Biwak/key/waterway/value/biwak" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Blacksmith"></see>
    /// </summary>
    let Blacksmith = Namespaced_IRI.parse _namespace_name "Blacksmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Blacksmith/key/craft/value/blacksmith"></see>
    /// </summary>
    let ``Blacksmith/key/craft/value/blacksmith`` =
        Namespaced_IRI.parse _namespace_name "Blacksmith/key/craft/value/blacksmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Block"></see>
    /// </summary>
    let Block = Namespaced_IRI.parse _namespace_name "Block" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Block/key/barrier/value/block"></see>
    /// </summary>
    let ``Block/key/barrier/value/block`` =
        Namespaced_IRI.parse _namespace_name "Block/key/barrier/value/block" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoatRental"></see>
    /// </summary>
    let BoatRental = Namespaced_IRI.parse _namespace_name "BoatRental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoatRental/key/amenity/value/boat_rental"></see>
    /// </summary>
    let ``BoatRental/key/amenity/value/boat_rental`` =
        Namespaced_IRI.parse _namespace_name "BoatRental/key/amenity/value/boat_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boatbuilder"></see>
    /// </summary>
    let Boatbuilder =
        Namespaced_IRI.parse _namespace_name "Boatbuilder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boatbuilder/key/craft/value/boatbuilder"></see>
    /// </summary>
    let ``Boatbuilder/key/craft/value/boatbuilder`` =
        Namespaced_IRI.parse _namespace_name "Boatbuilder/key/craft/value/boatbuilder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boatyard"></see>
    /// </summary>
    let Boatyard = Namespaced_IRI.parse _namespace_name "Boatyard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boatyard/key/waterway/value/boatyard"></see>
    /// </summary>
    let ``Boatyard/key/waterway/value/boatyard`` =
        Namespaced_IRI.parse _namespace_name "Boatyard/key/waterway/value/boatyard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bollard"></see>
    /// </summary>
    let Bollard = Namespaced_IRI.parse _namespace_name "Bollard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bollard/key/barrier/value/bollard"></see>
    /// </summary>
    let ``Bollard/key/barrier/value/bollard`` =
        Namespaced_IRI.parse _namespace_name "Bollard/key/barrier/value/bollard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookShop"></see>
    /// </summary>
    let BookShop = Namespaced_IRI.parse _namespace_name "BookShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookShop/key/shop/value/books"></see>
    /// </summary>
    let ``BookShop/key/shop/value/books`` =
        Namespaced_IRI.parse _namespace_name "BookShop/key/shop/value/books" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bookbinder"></see>
    /// </summary>
    let Bookbinder = Namespaced_IRI.parse _namespace_name "Bookbinder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bookbinder/key/craft/value/bookbinder"></see>
    /// </summary>
    let ``Bookbinder/key/craft/value/bookbinder`` =
        Namespaced_IRI.parse _namespace_name "Bookbinder/key/craft/value/bookbinder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookmakerShop"></see>
    /// </summary>
    let BookmakerShop =
        Namespaced_IRI.parse _namespace_name "BookmakerShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookmakerShop/key/shop/value/bookmaker"></see>
    /// </summary>
    let ``BookmakerShop/key/shop/value/bookmaker`` =
        Namespaced_IRI.parse _namespace_name "BookmakerShop/key/shop/value/bookmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookmakersShop"></see>
    /// </summary>
    let BookmakersShop =
        Namespaced_IRI.parse _namespace_name "BookmakersShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookmakersShop/key/shop/value/bookmakers"></see>
    /// </summary>
    let ``BookmakersShop/key/shop/value/bookmakers`` =
        Namespaced_IRI.parse _namespace_name "BookmakersShop/key/shop/value/bookmakers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BooksShop"></see>
    /// </summary>
    let BooksShop = Namespaced_IRI.parse _namespace_name "BooksShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BooksShop/key/shop/value/books"></see>
    /// </summary>
    let ``BooksShop/key/shop/value/books`` =
        Namespaced_IRI.parse _namespace_name "BooksShop/key/shop/value/books" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BorderControl"></see>
    /// </summary>
    let BorderControl =
        Namespaced_IRI.parse _namespace_name "BorderControl" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BorderControl/key/amenity/value/border_control"></see>
    /// </summary>
    let ``BorderControl/key/amenity/value/border_control`` =
        Namespaced_IRI.parse _namespace_name "BorderControl/key/amenity/value/border_control" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BorderControl/key/barrier/value/border_control"></see>
    /// </summary>
    let ``BorderControl/key/barrier/value/border_control`` =
        Namespaced_IRI.parse _namespace_name "BorderControl/key/barrier/value/border_control" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Borderstone"></see>
    /// </summary>
    let Borderstone =
        Namespaced_IRI.parse _namespace_name "Borderstone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Borderstone/key/man_made/value/borderstone"></see>
    /// </summary>
    let ``Borderstone/key/man_made/value/borderstone`` =
        Namespaced_IRI.parse _namespace_name "Borderstone/key/man_made/value/borderstone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryForest"></see>
    /// </summary>
    let BoundaryForest =
        Namespaced_IRI.parse _namespace_name "BoundaryForest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryForest/key/boundary/value/forest"></see>
    /// </summary>
    let ``BoundaryForest/key/boundary/value/forest`` =
        Namespaced_IRI.parse _namespace_name "BoundaryForest/key/boundary/value/forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryMarker"></see>
    /// </summary>
    let BoundaryMarker =
        Namespaced_IRI.parse _namespace_name "BoundaryMarker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryMarker/key/historic/value/boundary_marker"></see>
    /// </summary>
    let ``BoundaryMarker/key/historic/value/boundary_marker`` =
        Namespaced_IRI.parse _namespace_name "BoundaryMarker/key/historic/value/boundary_marker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryMarker/key/boundary/value/marker"></see>
    /// </summary>
    let ``BoundaryMarker/key/boundary/value/marker`` =
        Namespaced_IRI.parse _namespace_name "BoundaryMarker/key/boundary/value/marker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryStone"></see>
    /// </summary>
    let BoundaryStone =
        Namespaced_IRI.parse _namespace_name "BoundaryStone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryStone/key/historic/value/boundary_stone%20"></see>
    /// </summary>
    let ``BoundaryStone/key/historic/value/boundary_stone%20`` =
        Namespaced_IRI.parse _namespace_name "BoundaryStone/key/historic/value/boundary_stone%20" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boutique"></see>
    /// </summary>
    let Boutique = Namespaced_IRI.parse _namespace_name "Boutique" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boutique/key/shop/value/boutique"></see>
    /// </summary>
    let ``Boutique/key/shop/value/boutique`` =
        Namespaced_IRI.parse _namespace_name "Boutique/key/shop/value/boutique" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brewery"></see>
    /// </summary>
    let Brewery = Namespaced_IRI.parse _namespace_name "Brewery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brewery/key/amenity/value/brewery"></see>
    /// </summary>
    let ``Brewery/key/amenity/value/brewery`` =
        Namespaced_IRI.parse _namespace_name "Brewery/key/amenity/value/brewery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brewery/key/craft/value/brewery"></see>
    /// </summary>
    let ``Brewery/key/craft/value/brewery`` =
        Namespaced_IRI.parse _namespace_name "Brewery/key/craft/value/brewery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge"></see>
    /// </summary>
    let Bridge = Namespaced_IRI.parse _namespace_name "Bridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge/key/railway/value/bridge"></see>
    /// </summary>
    let ``Bridge/key/railway/value/bridge`` =
        Namespaced_IRI.parse _namespace_name "Bridge/key/railway/value/bridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge+pier"></see>
    /// </summary>
    let ``Bridge+pier`` =
        Namespaced_IRI.parse _namespace_name "Bridge+pier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge+pier/key/man_made/value/bridge%20pier"></see>
    /// </summary>
    let ``Bridge+pier/key/man_made/value/bridge%20pier`` =
        Namespaced_IRI.parse _namespace_name "Bridge+pier/key/man_made/value/bridge%20pier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge+site"></see>
    /// </summary>
    let ``Bridge+site`` =
        Namespaced_IRI.parse _namespace_name "Bridge+site" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge+site/key/historic/value/bridge%20site"></see>
    /// </summary>
    let ``Bridge+site/key/historic/value/bridge%20site`` =
        Namespaced_IRI.parse _namespace_name "Bridge+site/key/historic/value/bridge%20site" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridleway"></see>
    /// </summary>
    let Bridleway = Namespaced_IRI.parse _namespace_name "Bridleway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridleway/key/highway/value/bridleway"></see>
    /// </summary>
    let ``Bridleway/key/highway/value/bridleway`` =
        Namespaced_IRI.parse _namespace_name "Bridleway/key/highway/value/bridleway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayThing"></see>
    /// </summary>
    let HighwayThing =
        Namespaced_IRI.parse _namespace_name "HighwayThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Briefkasten"></see>
    /// </summary>
    let Briefkasten =
        Namespaced_IRI.parse _namespace_name "Briefkasten" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Briefkasten/key/amenity/value/Briefkasten"></see>
    /// </summary>
    let ``Briefkasten/key/amenity/value/Briefkasten`` =
        Namespaced_IRI.parse _namespace_name "Briefkasten/key/amenity/value/Briefkasten" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brothel"></see>
    /// </summary>
    let Brothel = Namespaced_IRI.parse _namespace_name "Brothel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brothel/key/amenity/value/brothel"></see>
    /// </summary>
    let ``Brothel/key/amenity/value/brothel`` =
        Namespaced_IRI.parse _namespace_name "Brothel/key/amenity/value/brothel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brownfield"></see>
    /// </summary>
    let Brownfield = Namespaced_IRI.parse _namespace_name "Brownfield" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brownfield/key/landuse/value/brownfield"></see>
    /// </summary>
    let ``Brownfield/key/landuse/value/brownfield`` =
        Namespaced_IRI.parse _namespace_name "Brownfield/key/landuse/value/brownfield" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bts"></see>
    /// </summary>
    let Bts = Namespaced_IRI.parse _namespace_name "Bts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bts/key/amenity/value/bts"></see>
    /// </summary>
    let ``Bts/key/amenity/value/bts`` =
        Namespaced_IRI.parse _namespace_name "Bts/key/amenity/value/bts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BufferStop"></see>
    /// </summary>
    let BufferStop = Namespaced_IRI.parse _namespace_name "BufferStop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BufferStop/key/railway/value/buffer_stop"></see>
    /// </summary>
    let ``BufferStop/key/railway/value/buffer_stop`` =
        Namespaced_IRI.parse _namespace_name "BufferStop/key/railway/value/buffer_stop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Building/key/building/value/yes"></see>
    /// </summary>
    let ``Building/key/building/value/yes`` =
        Namespaced_IRI.parse _namespace_name "Building/key/building/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Building/key/building/value/1"></see>
    /// </summary>
    let ``Building/key/building/value/1`` =
        Namespaced_IRI.parse _namespace_name "Building/key/building/value/1" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Building/key/amenity/value/building"></see>
    /// </summary>
    let ``Building/key/amenity/value/building`` =
        Namespaced_IRI.parse _namespace_name "Building/key/amenity/value/building" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBarn"></see>
    /// </summary>
    let BuildingBarn =
        Namespaced_IRI.parse _namespace_name "BuildingBarn" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBarn/key/building/value/barn"></see>
    /// </summary>
    let ``BuildingBarn/key/building/value/barn`` =
        Namespaced_IRI.parse _namespace_name "BuildingBarn/key/building/value/barn" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBuilding"></see>
    /// </summary>
    let BuildingBuilding =
        Namespaced_IRI.parse _namespace_name "BuildingBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBuilding/key/building/value/building"></see>
    /// </summary>
    let ``BuildingBuilding/key/building/value/building`` =
        Namespaced_IRI.parse _namespace_name "BuildingBuilding/key/building/value/building" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBunker"></see>
    /// </summary>
    let BuildingBunker =
        Namespaced_IRI.parse _namespace_name "BuildingBunker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBunker/key/building/value/bunker"></see>
    /// </summary>
    let ``BuildingBunker/key/building/value/bunker`` =
        Namespaced_IRI.parse _namespace_name "BuildingBunker/key/building/value/bunker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingCabin"></see>
    /// </summary>
    let BuildingCabin =
        Namespaced_IRI.parse _namespace_name "BuildingCabin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingCabin/key/building/value/cabin"></see>
    /// </summary>
    let ``BuildingCabin/key/building/value/cabin`` =
        Namespaced_IRI.parse _namespace_name "BuildingCabin/key/building/value/cabin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingChapel"></see>
    /// </summary>
    let BuildingChapel =
        Namespaced_IRI.parse _namespace_name "BuildingChapel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingChapel/key/building/value/chapel"></see>
    /// </summary>
    let ``BuildingChapel/key/building/value/chapel`` =
        Namespaced_IRI.parse _namespace_name "BuildingChapel/key/building/value/chapel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingChurch"></see>
    /// </summary>
    let BuildingChurch =
        Namespaced_IRI.parse _namespace_name "BuildingChurch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingChurch/key/building/value/church"></see>
    /// </summary>
    let ``BuildingChurch/key/building/value/church`` =
        Namespaced_IRI.parse _namespace_name "BuildingChurch/key/building/value/church" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingCommercial"></see>
    /// </summary>
    let BuildingCommercial =
        Namespaced_IRI.parse _namespace_name "BuildingCommercial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingCommercial/key/building/value/commercial"></see>
    /// </summary>
    let ``BuildingCommercial/key/building/value/commercial`` =
        Namespaced_IRI.parse _namespace_name "BuildingCommercial/key/building/value/commercial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingDormitory"></see>
    /// </summary>
    let BuildingDormitory =
        Namespaced_IRI.parse _namespace_name "BuildingDormitory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingDormitory/key/building/value/dormitory"></see>
    /// </summary>
    let ``BuildingDormitory/key/building/value/dormitory`` =
        Namespaced_IRI.parse _namespace_name "BuildingDormitory/key/building/value/dormitory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingEntrance"></see>
    /// </summary>
    let BuildingEntrance =
        Namespaced_IRI.parse _namespace_name "BuildingEntrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingEntrance/key/building/value/entrance"></see>
    /// </summary>
    let ``BuildingEntrance/key/building/value/entrance`` =
        Namespaced_IRI.parse _namespace_name "BuildingEntrance/key/building/value/entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingEntrance/key/amenity/value/building_entrance"></see>
    /// </summary>
    let ``BuildingEntrance/key/amenity/value/building_entrance`` =
        Namespaced_IRI.parse _namespace_name "BuildingEntrance/key/amenity/value/building_entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingFarm"></see>
    /// </summary>
    let BuildingFarm =
        Namespaced_IRI.parse _namespace_name "BuildingFarm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingFarm/key/building/value/farm"></see>
    /// </summary>
    let ``BuildingFarm/key/building/value/farm`` =
        Namespaced_IRI.parse _namespace_name "BuildingFarm/key/building/value/farm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingGarage"></see>
    /// </summary>
    let BuildingGarage =
        Namespaced_IRI.parse _namespace_name "BuildingGarage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingGarage/key/building/value/garage"></see>
    /// </summary>
    let ``BuildingGarage/key/building/value/garage`` =
        Namespaced_IRI.parse _namespace_name "BuildingGarage/key/building/value/garage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHall"></see>
    /// </summary>
    let BuildingHall =
        Namespaced_IRI.parse _namespace_name "BuildingHall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHall/key/building/value/hall"></see>
    /// </summary>
    let ``BuildingHall/key/building/value/hall`` =
        Namespaced_IRI.parse _namespace_name "BuildingHall/key/building/value/hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHospital"></see>
    /// </summary>
    let BuildingHospital =
        Namespaced_IRI.parse _namespace_name "BuildingHospital" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHospital/key/building/value/hospital"></see>
    /// </summary>
    let ``BuildingHospital/key/building/value/hospital`` =
        Namespaced_IRI.parse _namespace_name "BuildingHospital/key/building/value/hospital" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHouse"></see>
    /// </summary>
    let BuildingHouse =
        Namespaced_IRI.parse _namespace_name "BuildingHouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHouse/key/building/value/house"></see>
    /// </summary>
    let ``BuildingHouse/key/building/value/house`` =
        Namespaced_IRI.parse _namespace_name "BuildingHouse/key/building/value/house" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHut"></see>
    /// </summary>
    let BuildingHut =
        Namespaced_IRI.parse _namespace_name "BuildingHut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHut/key/building/value/hut"></see>
    /// </summary>
    let ``BuildingHut/key/building/value/hut`` =
        Namespaced_IRI.parse _namespace_name "BuildingHut/key/building/value/hut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingKiosk"></see>
    /// </summary>
    let BuildingKiosk =
        Namespaced_IRI.parse _namespace_name "BuildingKiosk" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingKiosk/key/building/value/kiosk"></see>
    /// </summary>
    let ``BuildingKiosk/key/building/value/kiosk`` =
        Namespaced_IRI.parse _namespace_name "BuildingKiosk/key/building/value/kiosk" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingMonastery"></see>
    /// </summary>
    let BuildingMonastery =
        Namespaced_IRI.parse _namespace_name "BuildingMonastery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingMonastery/key/building/value/monastery"></see>
    /// </summary>
    let ``BuildingMonastery/key/building/value/monastery`` =
        Namespaced_IRI.parse _namespace_name "BuildingMonastery/key/building/value/monastery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingNo"></see>
    /// </summary>
    let BuildingNo = Namespaced_IRI.parse _namespace_name "BuildingNo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingNo/key/building/value/no"></see>
    /// </summary>
    let ``BuildingNo/key/building/value/no`` =
        Namespaced_IRI.parse _namespace_name "BuildingNo/key/building/value/no" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingOffice"></see>
    /// </summary>
    let BuildingOffice =
        Namespaced_IRI.parse _namespace_name "BuildingOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingOffice/key/building/value/office"></see>
    /// </summary>
    let ``BuildingOffice/key/building/value/office`` =
        Namespaced_IRI.parse _namespace_name "BuildingOffice/key/building/value/office" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingResidential"></see>
    /// </summary>
    let BuildingResidential =
        Namespaced_IRI.parse _namespace_name "BuildingResidential" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingResidential/key/building/value/residential"></see>
    /// </summary>
    let ``BuildingResidential/key/building/value/residential`` =
        Namespaced_IRI.parse _namespace_name "BuildingResidential/key/building/value/residential" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingRetail"></see>
    /// </summary>
    let BuildingRetail =
        Namespaced_IRI.parse _namespace_name "BuildingRetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingRetail/key/building/value/retail"></see>
    /// </summary>
    let ``BuildingRetail/key/building/value/retail`` =
        Namespaced_IRI.parse _namespace_name "BuildingRetail/key/building/value/retail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingSchool"></see>
    /// </summary>
    let BuildingSchool =
        Namespaced_IRI.parse _namespace_name "BuildingSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingSchool/key/building/value/school"></see>
    /// </summary>
    let ``BuildingSchool/key/building/value/school`` =
        Namespaced_IRI.parse _namespace_name "BuildingSchool/key/building/value/school" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingTower"></see>
    /// </summary>
    let BuildingTower =
        Namespaced_IRI.parse _namespace_name "BuildingTower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingTower/key/building/value/tower"></see>
    /// </summary>
    let ``BuildingTower/key/building/value/tower`` =
        Namespaced_IRI.parse _namespace_name "BuildingTower/key/building/value/tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingUniversity"></see>
    /// </summary>
    let BuildingUniversity =
        Namespaced_IRI.parse _namespace_name "BuildingUniversity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingUniversity/key/building/value/university"></see>
    /// </summary>
    let ``BuildingUniversity/key/building/value/university`` =
        Namespaced_IRI.parse _namespace_name "BuildingUniversity/key/building/value/university" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingUnknown"></see>
    /// </summary>
    let BuildingUnknown =
        Namespaced_IRI.parse _namespace_name "BuildingUnknown" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingUnknown/key/building/value/unknown"></see>
    /// </summary>
    let ``BuildingUnknown/key/building/value/unknown`` =
        Namespaced_IRI.parse _namespace_name "BuildingUnknown/key/building/value/unknown" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bump"></see>
    /// </summary>
    let Bump = Namespaced_IRI.parse _namespace_name "Bump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bump/key/traffic_calming/value/bump"></see>
    /// </summary>
    let ``Bump/key/traffic_calming/value/bump`` =
        Namespaced_IRI.parse _namespace_name "Bump/key/traffic_calming/value/bump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BureauDeChange"></see>
    /// </summary>
    let BureauDeChange =
        Namespaced_IRI.parse _namespace_name "BureauDeChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BureauDeChange/key/amenity/value/bureau_de_change"></see>
    /// </summary>
    let ``BureauDeChange/key/amenity/value/bureau_de_change`` =
        Namespaced_IRI.parse _namespace_name "BureauDeChange/key/amenity/value/bureau_de_change" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusGuideway"></see>
    /// </summary>
    let BusGuideway =
        Namespaced_IRI.parse _namespace_name "BusGuideway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusGuideway/key/highway/value/bus_guideway"></see>
    /// </summary>
    let ``BusGuideway/key/highway/value/bus_guideway`` =
        Namespaced_IRI.parse _namespace_name "BusGuideway/key/highway/value/bus_guideway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusRoute"></see>
    /// </summary>
    let BusRoute = Namespaced_IRI.parse _namespace_name "BusRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusRoute/key/route/value/bus"></see>
    /// </summary>
    let ``BusRoute/key/route/value/bus`` =
        Namespaced_IRI.parse _namespace_name "BusRoute/key/route/value/bus" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStation"></see>
    /// </summary>
    let BusStation = Namespaced_IRI.parse _namespace_name "BusStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStation/key/amenity/value/bus_station"></see>
    /// </summary>
    let ``BusStation/key/amenity/value/bus_station`` =
        Namespaced_IRI.parse _namespace_name "BusStation/key/amenity/value/bus_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStop"></see>
    /// </summary>
    let BusStop = Namespaced_IRI.parse _namespace_name "BusStop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStop/key/highway/value/bus_stop"></see>
    /// </summary>
    let ``BusStop/key/highway/value/bus_stop`` =
        Namespaced_IRI.parse _namespace_name "BusStop/key/highway/value/bus_stop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStop/key/amenity/value/bus_stop"></see>
    /// </summary>
    let ``BusStop/key/amenity/value/bus_stop`` =
        Namespaced_IRI.parse _namespace_name "BusStop/key/amenity/value/bus_stop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Butcher"></see>
    /// </summary>
    let Butcher = Namespaced_IRI.parse _namespace_name "Butcher" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Butcher/key/shop/value/butcher"></see>
    /// </summary>
    let ``Butcher/key/shop/value/butcher`` =
        Namespaced_IRI.parse _namespace_name "Butcher/key/shop/value/butcher" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Butchers"></see>
    /// </summary>
    let Butchers = Namespaced_IRI.parse _namespace_name "Butchers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Butchers/key/shop/value/butchers"></see>
    /// </summary>
    let ``Butchers/key/shop/value/butchers`` =
        Namespaced_IRI.parse _namespace_name "Butchers/key/shop/value/butchers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Byway"></see>
    /// </summary>
    let Byway = Namespaced_IRI.parse _namespace_name "Byway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Byway/key/highway/value/byway"></see>
    /// </summary>
    let ``Byway/key/highway/value/byway`` =
        Namespaced_IRI.parse _namespace_name "Byway/key/highway/value/byway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CableCar"></see>
    /// </summary>
    let CableCar = Namespaced_IRI.parse _namespace_name "CableCar" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CableCar/key/aerialway/value/cable_car"></see>
    /// </summary>
    let ``CableCar/key/aerialway/value/cable_car`` =
        Namespaced_IRI.parse _namespace_name "CableCar/key/aerialway/value/cable_car" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CableDistributionCabinet"></see>
    /// </summary>
    let CableDistributionCabinet =
        Namespaced_IRI.parse _namespace_name "CableDistributionCabinet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CableDistributionCabinet/key/power/value/cable_distribution_cabinet"></see>
    /// </summary>
    let ``CableDistributionCabinet/key/power/value/cable_distribution_cabinet`` =
        Namespaced_IRI.parse _namespace_name "CableDistributionCabinet/key/power/value/cable_distribution_cabinet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerThing"></see>
    /// </summary>
    let PowerThing = Namespaced_IRI.parse _namespace_name "PowerThing" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cafe"></see>
    /// </summary>
    let Cafe = Namespaced_IRI.parse _namespace_name "Cafe" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cafe/key/amenity/value/cafe"></see>
    /// </summary>
    let ``Cafe/key/amenity/value/cafe`` =
        Namespaced_IRI.parse _namespace_name "Cafe/key/amenity/value/cafe" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cairn"></see>
    /// </summary>
    let Cairn = Namespaced_IRI.parse _namespace_name "Cairn" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cairn/key/man_made/value/cairn"></see>
    /// </summary>
    let ``Cairn/key/man_made/value/cairn`` =
        Namespaced_IRI.parse _namespace_name "Cairn/key/man_made/value/cairn" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Camera"></see>
    /// </summary>
    let Camera = Namespaced_IRI.parse _namespace_name "Camera" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Camera/key/amenity/value/camera"></see>
    /// </summary>
    let ``Camera/key/amenity/value/camera`` =
        Namespaced_IRI.parse _namespace_name "Camera/key/amenity/value/camera" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CameraShop"></see>
    /// </summary>
    let CameraShop = Namespaced_IRI.parse _namespace_name "CameraShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CameraShop/key/shop/value/camera"></see>
    /// </summary>
    let ``CameraShop/key/shop/value/camera`` =
        Namespaced_IRI.parse _namespace_name "CameraShop/key/shop/value/camera" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CampSite"></see>
    /// </summary>
    let CampSite = Namespaced_IRI.parse _namespace_name "CampSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CampSite/key/tourism/value/camp_site"></see>
    /// </summary>
    let ``CampSite/key/tourism/value/camp_site`` =
        Namespaced_IRI.parse _namespace_name "CampSite/key/tourism/value/camp_site" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CampingOffice"></see>
    /// </summary>
    let CampingOffice =
        Namespaced_IRI.parse _namespace_name "CampingOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CampingOffice/key/office/value/camping"></see>
    /// </summary>
    let ``CampingOffice/key/office/value/camping`` =
        Namespaced_IRI.parse _namespace_name "CampingOffice/key/office/value/camping" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Campsite"></see>
    /// </summary>
    let Campsite = Namespaced_IRI.parse _namespace_name "Campsite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Campsite/key/amenity/value/campsite"></see>
    /// </summary>
    let ``Campsite/key/amenity/value/campsite`` =
        Namespaced_IRI.parse _namespace_name "Campsite/key/amenity/value/campsite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Canal"></see>
    /// </summary>
    let Canal = Namespaced_IRI.parse _namespace_name "Canal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Canal/key/waterway/value/canal"></see>
    /// </summary>
    let ``Canal/key/waterway/value/canal`` =
        Namespaced_IRI.parse _namespace_name "Canal/key/waterway/value/canal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CandyShop"></see>
    /// </summary>
    let CandyShop = Namespaced_IRI.parse _namespace_name "CandyShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CandyShop/key/shop/value/candy"></see>
    /// </summary>
    let ``CandyShop/key/shop/value/candy`` =
        Namespaced_IRI.parse _namespace_name "CandyShop/key/shop/value/candy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cape"></see>
    /// </summary>
    let Cape = Namespaced_IRI.parse _namespace_name "Cape" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cape/key/natural/value/cape"></see>
    /// </summary>
    let ``Cape/key/natural/value/cape`` =
        Namespaced_IRI.parse _namespace_name "Cape/key/natural/value/cape" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Car%3BcarRepair"></see>
    /// </summary>
    let ``Car%3BcarRepair`` =
        Namespaced_IRI.parse _namespace_name "Car%3BcarRepair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Car%3BcarRepair/key/shop/value/car%3Bcar_repair"></see>
    /// </summary>
    let ``Car%3BcarRepair/key/shop/value/car%3Bcar_repair`` =
        Namespaced_IRI.parse _namespace_name "Car%3BcarRepair/key/shop/value/car%3Bcar_repair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarDealer"></see>
    /// </summary>
    let CarDealer = Namespaced_IRI.parse _namespace_name "CarDealer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarDealer/key/shop/value/car_dealer"></see>
    /// </summary>
    let ``CarDealer/key/shop/value/car_dealer`` =
        Namespaced_IRI.parse _namespace_name "CarDealer/key/shop/value/car_dealer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarParts"></see>
    /// </summary>
    let CarParts = Namespaced_IRI.parse _namespace_name "CarParts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarParts/key/shop/value/car_parts"></see>
    /// </summary>
    let ``CarParts/key/shop/value/car_parts`` =
        Namespaced_IRI.parse _namespace_name "CarParts/key/shop/value/car_parts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRental"></see>
    /// </summary>
    let CarRental = Namespaced_IRI.parse _namespace_name "CarRental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRental/key/amenity/value/car_rental"></see>
    /// </summary>
    let ``CarRental/key/amenity/value/car_rental`` =
        Namespaced_IRI.parse _namespace_name "CarRental/key/amenity/value/car_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRepair"></see>
    /// </summary>
    let CarRepair = Namespaced_IRI.parse _namespace_name "CarRepair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRepair/key/amenity/value/car_repair"></see>
    /// </summary>
    let ``CarRepair/key/amenity/value/car_repair`` =
        Namespaced_IRI.parse _namespace_name "CarRepair/key/amenity/value/car_repair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRepairShop"></see>
    /// </summary>
    let CarRepairShop =
        Namespaced_IRI.parse _namespace_name "CarRepairShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRepairShop/key/shop/value/car_repair"></see>
    /// </summary>
    let ``CarRepairShop/key/shop/value/car_repair`` =
        Namespaced_IRI.parse _namespace_name "CarRepairShop/key/shop/value/car_repair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarSharing"></see>
    /// </summary>
    let CarSharing = Namespaced_IRI.parse _namespace_name "CarSharing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarSharing/key/amenity/value/car_sharing"></see>
    /// </summary>
    let ``CarSharing/key/amenity/value/car_sharing`` =
        Namespaced_IRI.parse _namespace_name "CarSharing/key/amenity/value/car_sharing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarShop"></see>
    /// </summary>
    let CarShop = Namespaced_IRI.parse _namespace_name "CarShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarShop/key/shop/value/car"></see>
    /// </summary>
    let ``CarShop/key/shop/value/car`` =
        Namespaced_IRI.parse _namespace_name "CarShop/key/shop/value/car" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarWash"></see>
    /// </summary>
    let CarWash = Namespaced_IRI.parse _namespace_name "CarWash" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarWash/key/amenity/value/car_wash"></see>
    /// </summary>
    let ``CarWash/key/amenity/value/car_wash`` =
        Namespaced_IRI.parse _namespace_name "CarWash/key/amenity/value/car_wash" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarWash/key/shop/value/car_wash"></see>
    /// </summary>
    let ``CarWash/key/shop/value/car_wash`` =
        Namespaced_IRI.parse _namespace_name "CarWash/key/shop/value/car_wash" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CaravanSite"></see>
    /// </summary>
    let CaravanSite =
        Namespaced_IRI.parse _namespace_name "CaravanSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CaravanSite/key/tourism/value/caravan_site"></see>
    /// </summary>
    let ``CaravanSite/key/tourism/value/caravan_site`` =
        Namespaced_IRI.parse _namespace_name "CaravanSite/key/tourism/value/caravan_site" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CardsShop"></see>
    /// </summary>
    let CardsShop = Namespaced_IRI.parse _namespace_name "CardsShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CardsShop/key/shop/value/cards"></see>
    /// </summary>
    let ``CardsShop/key/shop/value/cards`` =
        Namespaced_IRI.parse _namespace_name "CardsShop/key/shop/value/cards" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CareHome"></see>
    /// </summary>
    let CareHome = Namespaced_IRI.parse _namespace_name "CareHome" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CareHome/key/amenity/value/care_home"></see>
    /// </summary>
    let ``CareHome/key/amenity/value/care_home`` =
        Namespaced_IRI.parse _namespace_name "CareHome/key/amenity/value/care_home" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpenter"></see>
    /// </summary>
    let Carpenter = Namespaced_IRI.parse _namespace_name "Carpenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpenter/key/shop/value/carpenter"></see>
    /// </summary>
    let ``Carpenter/key/shop/value/carpenter`` =
        Namespaced_IRI.parse _namespace_name "Carpenter/key/shop/value/carpenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpenter/key/craft/value/carpenter"></see>
    /// </summary>
    let ``Carpenter/key/craft/value/carpenter`` =
        Namespaced_IRI.parse _namespace_name "Carpenter/key/craft/value/carpenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpet"></see>
    /// </summary>
    let Carpet = Namespaced_IRI.parse _namespace_name "Carpet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpet/key/shop/value/carpet"></see>
    /// </summary>
    let ``Carpet/key/shop/value/carpet`` =
        Namespaced_IRI.parse _namespace_name "Carpet/key/shop/value/carpet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarpetLayer"></see>
    /// </summary>
    let CarpetLayer =
        Namespaced_IRI.parse _namespace_name "CarpetLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarpetLayer/key/craft/value/carpet_layer"></see>
    /// </summary>
    let ``CarpetLayer/key/craft/value/carpet_layer`` =
        Namespaced_IRI.parse _namespace_name "CarpetLayer/key/craft/value/carpet_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpets"></see>
    /// </summary>
    let Carpets = Namespaced_IRI.parse _namespace_name "Carpets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpets/key/shop/value/carpets"></see>
    /// </summary>
    let ``Carpets/key/shop/value/carpets`` =
        Namespaced_IRI.parse _namespace_name "Carpets/key/shop/value/carpets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Casino"></see>
    /// </summary>
    let Casino = Namespaced_IRI.parse _namespace_name "Casino" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Casino/key/leisure/value/casino"></see>
    /// </summary>
    let ``Casino/key/leisure/value/casino`` =
        Namespaced_IRI.parse _namespace_name "Casino/key/leisure/value/casino" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Casino/key/amenity/value/casino"></see>
    /// </summary>
    let ``Casino/key/amenity/value/casino`` =
        Namespaced_IRI.parse _namespace_name "Casino/key/amenity/value/casino" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Castle"></see>
    /// </summary>
    let Castle = Namespaced_IRI.parse _namespace_name "Castle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Castle/key/historic/value/castle"></see>
    /// </summary>
    let ``Castle/key/historic/value/castle`` =
        Namespaced_IRI.parse _namespace_name "Castle/key/historic/value/castle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Catalogue"></see>
    /// </summary>
    let Catalogue = Namespaced_IRI.parse _namespace_name "Catalogue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Catalogue/key/shop/value/catalogue"></see>
    /// </summary>
    let ``Catalogue/key/shop/value/catalogue`` =
        Namespaced_IRI.parse _namespace_name "Catalogue/key/shop/value/catalogue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Catere"></see>
    /// </summary>
    let Catere = Namespaced_IRI.parse _namespace_name "Catere" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Catere/key/craft/value/caterer"></see>
    /// </summary>
    let ``Catere/key/craft/value/caterer`` =
        Namespaced_IRI.parse _namespace_name "Catere/key/craft/value/caterer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CattleGrid"></see>
    /// </summary>
    let CattleGrid = Namespaced_IRI.parse _namespace_name "CattleGrid" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CattleGrid/key/barrier/value/cattle_grid"></see>
    /// </summary>
    let ``CattleGrid/key/barrier/value/cattle_grid`` =
        Namespaced_IRI.parse _namespace_name "CattleGrid/key/barrier/value/cattle_grid" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cave"></see>
    /// </summary>
    let Cave = Namespaced_IRI.parse _namespace_name "Cave" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cave/key/natural/value/cave"></see>
    /// </summary>
    let ``Cave/key/natural/value/cave`` =
        Namespaced_IRI.parse _namespace_name "Cave/key/natural/value/cave" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CaveEntrance"></see>
    /// </summary>
    let CaveEntrance =
        Namespaced_IRI.parse _namespace_name "CaveEntrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CaveEntrance/key/natural/value/cave_entrance"></see>
    /// </summary>
    let ``CaveEntrance/key/natural/value/cave_entrance`` =
        Namespaced_IRI.parse _namespace_name "CaveEntrance/key/natural/value/cave_entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CellPhones"></see>
    /// </summary>
    let CellPhones = Namespaced_IRI.parse _namespace_name "CellPhones" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CellPhones/key/shop/value/cell_phones"></see>
    /// </summary>
    let ``CellPhones/key/shop/value/cell_phones`` =
        Namespaced_IRI.parse _namespace_name "CellPhones/key/shop/value/cell_phones" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cemetery"></see>
    /// </summary>
    let Cemetery = Namespaced_IRI.parse _namespace_name "Cemetery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cemetery/key/landuse/value/cemetery"></see>
    /// </summary>
    let ``Cemetery/key/landuse/value/cemetery`` =
        Namespaced_IRI.parse _namespace_name "Cemetery/key/landuse/value/cemetery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cemetery/key/amenity/value/cemetery"></see>
    /// </summary>
    let ``Cemetery/key/amenity/value/cemetery`` =
        Namespaced_IRI.parse _namespace_name "Cemetery/key/amenity/value/cemetery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Centre"></see>
    /// </summary>
    let Centre = Namespaced_IRI.parse _namespace_name "Centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Centre/key/amenity/value/leisure_centre"></see>
    /// </summary>
    let ``Centre/key/amenity/value/leisure_centre`` =
        Namespaced_IRI.parse _namespace_name "Centre/key/amenity/value/leisure_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ceramics"></see>
    /// </summary>
    let Ceramics = Namespaced_IRI.parse _namespace_name "Ceramics" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ceramics/key/shop/value/ceramics"></see>
    /// </summary>
    let ``Ceramics/key/shop/value/ceramics`` =
        Namespaced_IRI.parse _namespace_name "Ceramics/key/shop/value/ceramics" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chain"></see>
    /// </summary>
    let Chain = Namespaced_IRI.parse _namespace_name "Chain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chain/key/barrier/value/chain"></see>
    /// </summary>
    let ``Chain/key/barrier/value/chain`` =
        Namespaced_IRI.parse _namespace_name "Chain/key/barrier/value/chain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChairLift"></see>
    /// </summary>
    let ChairLift = Namespaced_IRI.parse _namespace_name "ChairLift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChairLift/key/aerialway/value/chair_lift"></see>
    /// </summary>
    let ``ChairLift/key/aerialway/value/chair_lift`` =
        Namespaced_IRI.parse _namespace_name "ChairLift/key/aerialway/value/chair_lift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chalet"></see>
    /// </summary>
    let Chalet = Namespaced_IRI.parse _namespace_name "Chalet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chalet/key/tourism/value/chalet"></see>
    /// </summary>
    let ``Chalet/key/tourism/value/chalet`` =
        Namespaced_IRI.parse _namespace_name "Chalet/key/tourism/value/chalet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chandler"></see>
    /// </summary>
    let Chandler = Namespaced_IRI.parse _namespace_name "Chandler" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chandler/key/shop/value/chandler"></see>
    /// </summary>
    let ``Chandler/key/shop/value/chandler`` =
        Namespaced_IRI.parse _namespace_name "Chandler/key/shop/value/chandler" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Channel"></see>
    /// </summary>
    let Channel = Namespaced_IRI.parse _namespace_name "Channel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Channel/key/natural/value/channel"></see>
    /// </summary>
    let ``Channel/key/natural/value/channel`` =
        Namespaced_IRI.parse _namespace_name "Channel/key/natural/value/channel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chapel"></see>
    /// </summary>
    let Chapel = Namespaced_IRI.parse _namespace_name "Chapel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chapel/key/amenity/value/chapel"></see>
    /// </summary>
    let ``Chapel/key/amenity/value/chapel`` =
        Namespaced_IRI.parse _namespace_name "Chapel/key/amenity/value/chapel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Charity"></see>
    /// </summary>
    let Charity = Namespaced_IRI.parse _namespace_name "Charity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Charity/key/amenity/value/charity"></see>
    /// </summary>
    let ``Charity/key/amenity/value/charity`` =
        Namespaced_IRI.parse _namespace_name "Charity/key/amenity/value/charity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CharityShop"></see>
    /// </summary>
    let CharityShop =
        Namespaced_IRI.parse _namespace_name "CharityShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CharityShop/key/shop/value/charity"></see>
    /// </summary>
    let ``CharityShop/key/shop/value/charity`` =
        Namespaced_IRI.parse _namespace_name "CharityShop/key/shop/value/charity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cheese"></see>
    /// </summary>
    let Cheese = Namespaced_IRI.parse _namespace_name "Cheese" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cheese/key/shop/value/cheese"></see>
    /// </summary>
    let ``Cheese/key/shop/value/cheese`` =
        Namespaced_IRI.parse _namespace_name "Cheese/key/shop/value/cheese" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chemist"></see>
    /// </summary>
    let Chemist = Namespaced_IRI.parse _namespace_name "Chemist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chemist/key/shop/value/chemist"></see>
    /// </summary>
    let ``Chemist/key/shop/value/chemist`` =
        Namespaced_IRI.parse _namespace_name "Chemist/key/shop/value/chemist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chicane"></see>
    /// </summary>
    let Chicane = Namespaced_IRI.parse _namespace_name "Chicane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chicane/key/traffic_calming/value/chicane"></see>
    /// </summary>
    let ``Chicane/key/traffic_calming/value/chicane`` =
        Namespaced_IRI.parse _namespace_name "Chicane/key/traffic_calming/value/chicane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChildCare"></see>
    /// </summary>
    let ChildCare = Namespaced_IRI.parse _namespace_name "ChildCare" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChildCare/key/amenity/value/child_care"></see>
    /// </summary>
    let ``ChildCare/key/amenity/value/child_care`` =
        Namespaced_IRI.parse _namespace_name "ChildCare/key/amenity/value/child_care" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chimney"></see>
    /// </summary>
    let Chimney = Namespaced_IRI.parse _namespace_name "Chimney" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chimney/key/man_made/value/chimney"></see>
    /// </summary>
    let ``Chimney/key/man_made/value/chimney`` =
        Namespaced_IRI.parse _namespace_name "Chimney/key/man_made/value/chimney" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chiropractor"></see>
    /// </summary>
    let Chiropractor =
        Namespaced_IRI.parse _namespace_name "Chiropractor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chiropractor/key/amenity/value/chiropractor"></see>
    /// </summary>
    let ``Chiropractor/key/amenity/value/chiropractor`` =
        Namespaced_IRI.parse _namespace_name "Chiropractor/key/amenity/value/chiropractor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chocolate"></see>
    /// </summary>
    let Chocolate = Namespaced_IRI.parse _namespace_name "Chocolate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chocolate/key/shop/value/chocolate"></see>
    /// </summary>
    let ``Chocolate/key/shop/value/chocolate`` =
        Namespaced_IRI.parse _namespace_name "Chocolate/key/shop/value/chocolate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Choker"></see>
    /// </summary>
    let Choker = Namespaced_IRI.parse _namespace_name "Choker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Choker/key/traffic_calming/value/choker"></see>
    /// </summary>
    let ``Choker/key/traffic_calming/value/choker`` =
        Namespaced_IRI.parse _namespace_name "Choker/key/traffic_calming/value/choker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Church"></see>
    /// </summary>
    let Church = Namespaced_IRI.parse _namespace_name "Church" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Church/key/amenity/value/church"></see>
    /// </summary>
    let ``Church/key/amenity/value/church`` =
        Namespaced_IRI.parse _namespace_name "Church/key/amenity/value/church" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChurchHall"></see>
    /// </summary>
    let ChurchHall = Namespaced_IRI.parse _namespace_name "ChurchHall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChurchHall/key/amenity/value/church_hall"></see>
    /// </summary>
    let ``ChurchHall/key/amenity/value/church_hall`` =
        Namespaced_IRI.parse _namespace_name "ChurchHall/key/amenity/value/church_hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cinema"></see>
    /// </summary>
    let Cinema = Namespaced_IRI.parse _namespace_name "Cinema" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cinema/key/amenity/value/cinema"></see>
    /// </summary>
    let ``Cinema/key/amenity/value/cinema`` =
        Namespaced_IRI.parse _namespace_name "Cinema/key/amenity/value/cinema" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CircuitBreaker"></see>
    /// </summary>
    let CircuitBreaker =
        Namespaced_IRI.parse _namespace_name "CircuitBreaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CircuitBreaker/key/power/value/circuit_breaker"></see>
    /// </summary>
    let ``CircuitBreaker/key/power/value/circuit_breaker`` =
        Namespaced_IRI.parse _namespace_name "CircuitBreaker/key/power/value/circuit_breaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/City"></see>
    /// </summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/City/key/place/value/city"></see>
    /// </summary>
    let ``City/key/place/value/city`` =
        Namespaced_IRI.parse _namespace_name "City/key/place/value/city" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityGate"></see>
    /// </summary>
    let CityGate = Namespaced_IRI.parse _namespace_name "CityGate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityGate/key/historic/value/city_gate"></see>
    /// </summary>
    let ``CityGate/key/historic/value/city_gate`` =
        Namespaced_IRI.parse _namespace_name "CityGate/key/historic/value/city_gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityLimit"></see>
    /// </summary>
    let CityLimit = Namespaced_IRI.parse _namespace_name "CityLimit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityLimit/key/boundary/value/city_limit"></see>
    /// </summary>
    let ``CityLimit/key/boundary/value/city_limit`` =
        Namespaced_IRI.parse _namespace_name "CityLimit/key/boundary/value/city_limit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityWall"></see>
    /// </summary>
    let CityWall = Namespaced_IRI.parse _namespace_name "CityWall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityWall/key/barrier/value/city_wall"></see>
    /// </summary>
    let ``CityWall/key/barrier/value/city_wall`` =
        Namespaced_IRI.parse _namespace_name "CityWall/key/barrier/value/city_wall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CitymapPost"></see>
    /// </summary>
    let CitymapPost =
        Namespaced_IRI.parse _namespace_name "CitymapPost" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CitymapPost/key/amenity/value/citymap_post"></see>
    /// </summary>
    let ``CitymapPost/key/amenity/value/citymap_post`` =
        Namespaced_IRI.parse _namespace_name "CitymapPost/key/amenity/value/citymap_post" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CivilBoundary"></see>
    /// </summary>
    let CivilBoundary =
        Namespaced_IRI.parse _namespace_name "CivilBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CivilBoundary/key/boundary/value/civil"></see>
    /// </summary>
    let ``CivilBoundary/key/boundary/value/civil`` =
        Namespaced_IRI.parse _namespace_name "CivilBoundary/key/boundary/value/civil" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cliff"></see>
    /// </summary>
    let Cliff = Namespaced_IRI.parse _namespace_name "Cliff" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cliff/key/natural/value/cliff"></see>
    /// </summary>
    let ``Cliff/key/natural/value/cliff`` =
        Namespaced_IRI.parse _namespace_name "Cliff/key/natural/value/cliff" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clinic"></see>
    /// </summary>
    let Clinic = Namespaced_IRI.parse _namespace_name "Clinic" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clinic/key/amenity/value/clinic"></see>
    /// </summary>
    let ``Clinic/key/amenity/value/clinic`` =
        Namespaced_IRI.parse _namespace_name "Clinic/key/amenity/value/clinic" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clock"></see>
    /// </summary>
    let Clock = Namespaced_IRI.parse _namespace_name "Clock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clock/key/amenity/value/clock"></see>
    /// </summary>
    let ``Clock/key/amenity/value/clock`` =
        Namespaced_IRI.parse _namespace_name "Clock/key/amenity/value/clock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clockmaker"></see>
    /// </summary>
    let Clockmaker = Namespaced_IRI.parse _namespace_name "Clockmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clockmaker/key/craft/value/clockmaker"></see>
    /// </summary>
    let ``Clockmaker/key/craft/value/clockmaker`` =
        Namespaced_IRI.parse _namespace_name "Clockmaker/key/craft/value/clockmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Closed"></see>
    /// </summary>
    let Closed = Namespaced_IRI.parse _namespace_name "Closed" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Closed/key/shop/value/closed"></see>
    /// </summary>
    let ``Closed/key/shop/value/closed`` =
        Namespaced_IRI.parse _namespace_name "Closed/key/shop/value/closed" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes"></see>
    /// </summary>
    let Clothes = Namespaced_IRI.parse _namespace_name "Clothes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes/key/shop/value/clothes"></see>
    /// </summary>
    let ``Clothes/key/shop/value/clothes`` =
        Namespaced_IRI.parse _namespace_name "Clothes/key/shop/value/clothes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes%3A+women"></see>
    /// </summary>
    let ``Clothes%3A+women`` =
        Namespaced_IRI.parse _namespace_name "Clothes%3A+women" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes%3A+women/key/shop/value/clothes%3A%20women"></see>
    /// </summary>
    let ``Clothes%3A+women/key/shop/value/clothes%3A%20women`` =
        Namespaced_IRI.parse _namespace_name "Clothes%3A+women/key/shop/value/clothes%3A%20women" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes%3Awomen"></see>
    /// </summary>
    let ``Clothes%3Awomen`` =
        Namespaced_IRI.parse _namespace_name "Clothes%3Awomen" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes%3Awomen/key/shop/value/clothes%3Awomen"></see>
    /// </summary>
    let ``Clothes%3Awomen/key/shop/value/clothes%3Awomen`` =
        Namespaced_IRI.parse _namespace_name "Clothes%3Awomen/key/shop/value/clothes%3Awomen" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothing"></see>
    /// </summary>
    let Clothing = Namespaced_IRI.parse _namespace_name "Clothing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothing/key/shop/value/clothing"></see>
    /// </summary>
    let ``Clothing/key/shop/value/clothing`` =
        Namespaced_IRI.parse _namespace_name "Clothing/key/shop/value/clothing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Club"></see>
    /// </summary>
    let Club = Namespaced_IRI.parse _namespace_name "Club" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Club/key/amenity/value/club"></see>
    /// </summary>
    let ``Club/key/amenity/value/club`` =
        Namespaced_IRI.parse _namespace_name "Club/key/amenity/value/club" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Club/key/leisure/value/club"></see>
    /// </summary>
    let ``Club/key/leisure/value/club`` =
        Namespaced_IRI.parse _namespace_name "Club/key/leisure/value/club" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ClubHouse"></see>
    /// </summary>
    let ClubHouse = Namespaced_IRI.parse _namespace_name "ClubHouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ClubHouse/key/amenity/value/club_house"></see>
    /// </summary>
    let ``ClubHouse/key/amenity/value/club_house`` =
        Namespaced_IRI.parse _namespace_name "ClubHouse/key/amenity/value/club_house" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clubhouse"></see>
    /// </summary>
    let Clubhouse = Namespaced_IRI.parse _namespace_name "Clubhouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clubhouse/key/building/value/clubhouse"></see>
    /// </summary>
    let ``Clubhouse/key/building/value/clubhouse`` =
        Namespaced_IRI.parse _namespace_name "Clubhouse/key/building/value/clubhouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Coastline"></see>
    /// </summary>
    let Coastline = Namespaced_IRI.parse _namespace_name "Coastline" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Coastline/key/natural/value/coastline"></see>
    /// </summary>
    let ``Coastline/key/natural/value/coastline`` =
        Namespaced_IRI.parse _namespace_name "Coastline/key/natural/value/coastline" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoffeeShop"></see>
    /// </summary>
    let CoffeeShop = Namespaced_IRI.parse _namespace_name "CoffeeShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoffeeShop/key/amenity/value/coffeeshop"></see>
    /// </summary>
    let ``CoffeeShop/key/amenity/value/coffeeshop`` =
        Namespaced_IRI.parse _namespace_name "CoffeeShop/key/amenity/value/coffeeshop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoffeeShop/key/shop/value/coffee"></see>
    /// </summary>
    let ``CoffeeShop/key/shop/value/coffee`` =
        Namespaced_IRI.parse _namespace_name "CoffeeShop/key/shop/value/coffee" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoffeeShop/key/shop/value/coffee_shop"></see>
    /// </summary>
    let ``CoffeeShop/key/shop/value/coffee_shop`` =
        Namespaced_IRI.parse _namespace_name "CoffeeShop/key/shop/value/coffee_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Col"></see>
    /// </summary>
    let Col = Namespaced_IRI.parse _namespace_name "Col" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Col/key/natural/value/col"></see>
    /// </summary>
    let ``Col/key/natural/value/col`` =
        Namespaced_IRI.parse _namespace_name "Col/key/natural/value/col" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Collapsed"></see>
    /// </summary>
    let Collapsed = Namespaced_IRI.parse _namespace_name "Collapsed" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Collapsed/key/building/value/collapsed"></see>
    /// </summary>
    let ``Collapsed/key/building/value/collapsed`` =
        Namespaced_IRI.parse _namespace_name "Collapsed/key/building/value/collapsed" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/College"></see>
    /// </summary>
    let College = Namespaced_IRI.parse _namespace_name "College" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/College/key/amenity/value/college"></see>
    /// </summary>
    let ``College/key/amenity/value/college`` =
        Namespaced_IRI.parse _namespace_name "College/key/amenity/value/college" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Commercial"></see>
    /// </summary>
    let Commercial = Namespaced_IRI.parse _namespace_name "Commercial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Commercial/key/amenity/value/commercial"></see>
    /// </summary>
    let ``Commercial/key/amenity/value/commercial`` =
        Namespaced_IRI.parse _namespace_name "Commercial/key/amenity/value/commercial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommercialLanduse"></see>
    /// </summary>
    let CommercialLanduse =
        Namespaced_IRI.parse _namespace_name "CommercialLanduse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommercialLanduse/key/landuse/value/commercial"></see>
    /// </summary>
    let ``CommercialLanduse/key/landuse/value/commercial`` =
        Namespaced_IRI.parse _namespace_name "CommercialLanduse/key/landuse/value/commercial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Common"></see>
    /// </summary>
    let Common = Namespaced_IRI.parse _namespace_name "Common" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Common/key/leisure/value/common"></see>
    /// </summary>
    let ``Common/key/leisure/value/common`` =
        Namespaced_IRI.parse _namespace_name "Common/key/leisure/value/common" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Communication"></see>
    /// </summary>
    let Communication =
        Namespaced_IRI.parse _namespace_name "Communication" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Communication/key/shop/value/communication"></see>
    /// </summary>
    let ``Communication/key/shop/value/communication`` =
        Namespaced_IRI.parse _namespace_name "Communication/key/shop/value/communication" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Communications"></see>
    /// </summary>
    let Communications =
        Namespaced_IRI.parse _namespace_name "Communications" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Communications/key/shop/value/communications"></see>
    /// </summary>
    let ``Communications/key/shop/value/communications`` =
        Namespaced_IRI.parse _namespace_name "Communications/key/shop/value/communications" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunicationsTower"></see>
    /// </summary>
    let CommunicationsTower =
        Namespaced_IRI.parse _namespace_name "CommunicationsTower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunicationsTower/key/man_made/value/communications_tower"></see>
    /// </summary>
    let ``CommunicationsTower/key/man_made/value/communications_tower`` =
        Namespaced_IRI.parse _namespace_name "CommunicationsTower/key/man_made/value/communications_tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunicationsTransponder"></see>
    /// </summary>
    let CommunicationsTransponder =
        Namespaced_IRI.parse _namespace_name "CommunicationsTransponder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunicationsTransponder/key/man_made/value/communications_transponder"></see>
    /// </summary>
    let ``CommunicationsTransponder/key/man_made/value/communications_transponder`` =
        Namespaced_IRI.parse _namespace_name "CommunicationsTransponder/key/man_made/value/communications_transponder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunityCentre"></see>
    /// </summary>
    let CommunityCentre =
        Namespaced_IRI.parse _namespace_name "CommunityCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunityCentre/key/amenity/value/community_centre"></see>
    /// </summary>
    let ``CommunityCentre/key/amenity/value/community_centre`` =
        Namespaced_IRI.parse _namespace_name "CommunityCentre/key/amenity/value/community_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunityHall"></see>
    /// </summary>
    let CommunityHall =
        Namespaced_IRI.parse _namespace_name "CommunityHall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunityHall/key/amenity/value/community_hall"></see>
    /// </summary>
    let ``CommunityHall/key/amenity/value/community_hall`` =
        Namespaced_IRI.parse _namespace_name "CommunityHall/key/amenity/value/community_hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Company"></see>
    /// </summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Company/key/amenity/value/company"></see>
    /// </summary>
    let ``Company/key/amenity/value/company`` =
        Namespaced_IRI.parse _namespace_name "Company/key/amenity/value/company" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CompanyOffice"></see>
    /// </summary>
    let CompanyOffice =
        Namespaced_IRI.parse _namespace_name "CompanyOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CompanyOffice/key/office/value/company"></see>
    /// </summary>
    let ``CompanyOffice/key/office/value/company`` =
        Namespaced_IRI.parse _namespace_name "CompanyOffice/key/office/value/company" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Computer"></see>
    /// </summary>
    let Computer = Namespaced_IRI.parse _namespace_name "Computer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Computer/key/shop/value/computer"></see>
    /// </summary>
    let ``Computer/key/shop/value/computer`` =
        Namespaced_IRI.parse _namespace_name "Computer/key/shop/value/computer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConcertHall"></see>
    /// </summary>
    let ConcertHall =
        Namespaced_IRI.parse _namespace_name "ConcertHall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConcertHall/key/amenity/value/concert_hall"></see>
    /// </summary>
    let ``ConcertHall/key/amenity/value/concert_hall`` =
        Namespaced_IRI.parse _namespace_name "ConcertHall/key/amenity/value/concert_hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Condos"></see>
    /// </summary>
    let Condos = Namespaced_IRI.parse _namespace_name "Condos" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Condos/key/shop/value/condos"></see>
    /// </summary>
    let ``Condos/key/shop/value/condos`` =
        Namespaced_IRI.parse _namespace_name "Condos/key/shop/value/condos" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Confectionery"></see>
    /// </summary>
    let Confectionery =
        Namespaced_IRI.parse _namespace_name "Confectionery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Confectionery/key/craft/value/confectionery"></see>
    /// </summary>
    let ``Confectionery/key/craft/value/confectionery`` =
        Namespaced_IRI.parse _namespace_name "Confectionery/key/craft/value/confectionery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Confectionery/key/shop/value/confectionery"></see>
    /// </summary>
    let ``Confectionery/key/shop/value/confectionery`` =
        Namespaced_IRI.parse _namespace_name "Confectionery/key/shop/value/confectionery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConferenceCentre"></see>
    /// </summary>
    let ConferenceCentre =
        Namespaced_IRI.parse _namespace_name "ConferenceCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConferenceCentre/key/amenity/value/conference_centre"></see>
    /// </summary>
    let ``ConferenceCentre/key/amenity/value/conference_centre`` =
        Namespaced_IRI.parse _namespace_name "ConferenceCentre/key/amenity/value/conference_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Construction"></see>
    /// </summary>
    let Construction =
        Namespaced_IRI.parse _namespace_name "Construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Construction/key/amenity/value/construction"></see>
    /// </summary>
    let ``Construction/key/amenity/value/construction`` =
        Namespaced_IRI.parse _namespace_name "Construction/key/amenity/value/construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConstructionLanduse"></see>
    /// </summary>
    let ConstructionLanduse =
        Namespaced_IRI.parse _namespace_name "ConstructionLanduse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConstructionLanduse/key/landuse/value/construction"></see>
    /// </summary>
    let ``ConstructionLanduse/key/landuse/value/construction`` =
        Namespaced_IRI.parse _namespace_name "ConstructionLanduse/key/landuse/value/construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConstructionShop"></see>
    /// </summary>
    let ConstructionShop =
        Namespaced_IRI.parse _namespace_name "ConstructionShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConstructionShop/key/shop/value/construction"></see>
    /// </summary>
    let ``ConstructionShop/key/shop/value/construction`` =
        Namespaced_IRI.parse _namespace_name "ConstructionShop/key/shop/value/construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Consulate"></see>
    /// </summary>
    let Consulate = Namespaced_IRI.parse _namespace_name "Consulate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Consulate/key/amenity/value/consulate"></see>
    /// </summary>
    let ``Consulate/key/amenity/value/consulate`` =
        Namespaced_IRI.parse _namespace_name "Consulate/key/amenity/value/consulate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Continent"></see>
    /// </summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Continent/key/place/value/continent"></see>
    /// </summary>
    let ``Continent/key/place/value/continent`` =
        Namespaced_IRI.parse _namespace_name "Continent/key/place/value/continent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Convenience"></see>
    /// </summary>
    let Convenience =
        Namespaced_IRI.parse _namespace_name "Convenience" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Convenience/key/shop/value/convenience"></see>
    /// </summary>
    let ``Convenience/key/shop/value/convenience`` =
        Namespaced_IRI.parse _namespace_name "Convenience/key/shop/value/convenience" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Copyshop"></see>
    /// </summary>
    let Copyshop = Namespaced_IRI.parse _namespace_name "Copyshop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Copyshop/key/shop/value/copyshop"></see>
    /// </summary>
    let ``Copyshop/key/shop/value/copyshop`` =
        Namespaced_IRI.parse _namespace_name "Copyshop/key/shop/value/copyshop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cosmetics"></see>
    /// </summary>
    let Cosmetics = Namespaced_IRI.parse _namespace_name "Cosmetics" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cosmetics/key/shop/value/cosmetics"></see>
    /// </summary>
    let ``Cosmetics/key/shop/value/cosmetics`` =
        Namespaced_IRI.parse _namespace_name "Cosmetics/key/shop/value/cosmetics" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Country/key/place/value/country"></see>
    /// </summary>
    let ``Country/key/place/value/country`` =
        Namespaced_IRI.parse _namespace_name "Country/key/place/value/country" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/County"></see>
    /// </summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/County/key/place/value/county"></see>
    /// </summary>
    let ``County/key/place/value/county`` =
        Namespaced_IRI.parse _namespace_name "County/key/place/value/county" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Courthouse"></see>
    /// </summary>
    let Courthouse = Namespaced_IRI.parse _namespace_name "Courthouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Courthouse/key/amenity/value/courthouse"></see>
    /// </summary>
    let ``Courthouse/key/amenity/value/courthouse`` =
        Namespaced_IRI.parse _namespace_name "Courthouse/key/amenity/value/courthouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoveredReservoir"></see>
    /// </summary>
    let CoveredReservoir =
        Namespaced_IRI.parse _namespace_name "CoveredReservoir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoveredReservoir/key/man_made/value/reservoir_covered"></see>
    /// </summary>
    let ``CoveredReservoir/key/man_made/value/reservoir_covered`` =
        Namespaced_IRI.parse _namespace_name "CoveredReservoir/key/man_made/value/reservoir_covered" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Craft/key/shop/value/craft"></see>
    /// </summary>
    let ``Craft/key/shop/value/craft`` =
        Namespaced_IRI.parse _namespace_name "Craft/key/shop/value/craft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crafts"></see>
    /// </summary>
    let Crafts = Namespaced_IRI.parse _namespace_name "Crafts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crafts/key/shop/value/crafts"></see>
    /// </summary>
    let ``Crafts/key/shop/value/crafts`` =
        Namespaced_IRI.parse _namespace_name "Crafts/key/shop/value/crafts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crane"></see>
    /// </summary>
    let Crane = Namespaced_IRI.parse _namespace_name "Crane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crane/key/man_made/value/crane"></see>
    /// </summary>
    let ``Crane/key/man_made/value/crane`` =
        Namespaced_IRI.parse _namespace_name "Crane/key/man_made/value/crane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crater"></see>
    /// </summary>
    let Crater = Namespaced_IRI.parse _namespace_name "Crater" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crater/key/natural/value/crater"></see>
    /// </summary>
    let ``Crater/key/natural/value/crater`` =
        Namespaced_IRI.parse _namespace_name "Crater/key/natural/value/crater" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crematorium"></see>
    /// </summary>
    let Crematorium =
        Namespaced_IRI.parse _namespace_name "Crematorium" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crematorium/key/amenity/value/crematorium"></see>
    /// </summary>
    let ``Crematorium/key/amenity/value/crematorium`` =
        Namespaced_IRI.parse _namespace_name "Crematorium/key/amenity/value/crematorium" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cross"></see>
    /// </summary>
    let Cross = Namespaced_IRI.parse _namespace_name "Cross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cross/key/amenity/value/cross"></see>
    /// </summary>
    let ``Cross/key/amenity/value/cross`` =
        Namespaced_IRI.parse _namespace_name "Cross/key/amenity/value/cross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cushion"></see>
    /// </summary>
    let Cushion = Namespaced_IRI.parse _namespace_name "Cushion" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cushion/key/traffic_calming/value/cushion"></see>
    /// </summary>
    let ``Cushion/key/traffic_calming/value/cushion`` =
        Namespaced_IRI.parse _namespace_name "Cushion/key/traffic_calming/value/cushion" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Customs"></see>
    /// </summary>
    let Customs = Namespaced_IRI.parse _namespace_name "Customs" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Customs/key/amenity/value/customs"></see>
    /// </summary>
    let ``Customs/key/amenity/value/customs`` =
        Namespaced_IRI.parse _namespace_name "Customs/key/amenity/value/customs" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cutline"></see>
    /// </summary>
    let Cutline = Namespaced_IRI.parse _namespace_name "Cutline" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cutline/key/man_made/value/cutline"></see>
    /// </summary>
    let ``Cutline/key/man_made/value/cutline`` =
        Namespaced_IRI.parse _namespace_name "Cutline/key/man_made/value/cutline" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CycleBarrier"></see>
    /// </summary>
    let CycleBarrier =
        Namespaced_IRI.parse _namespace_name "CycleBarrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CycleBarrier/key/barrier/value/cycle_barrier"></see>
    /// </summary>
    let ``CycleBarrier/key/barrier/value/cycle_barrier`` =
        Namespaced_IRI.parse _namespace_name "CycleBarrier/key/barrier/value/cycle_barrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cycleway"></see>
    /// </summary>
    let Cycleway = Namespaced_IRI.parse _namespace_name "Cycleway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cycleway/key/highway/value/cycleway"></see>
    /// </summary>
    let ``Cycleway/key/highway/value/cycleway`` =
        Namespaced_IRI.parse _namespace_name "Cycleway/key/highway/value/cycleway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayLane"></see>
    /// </summary>
    let CyclewayLane =
        Namespaced_IRI.parse _namespace_name "CyclewayLane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayLane/key/cycleway/value/lane"></see>
    /// </summary>
    let ``CyclewayLane/key/cycleway/value/lane`` =
        Namespaced_IRI.parse _namespace_name "CyclewayLane/key/cycleway/value/lane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayThing"></see>
    /// </summary>
    let CyclewayThing =
        Namespaced_IRI.parse _namespace_name "CyclewayThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOpposite"></see>
    /// </summary>
    let CyclewayOpposite =
        Namespaced_IRI.parse _namespace_name "CyclewayOpposite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOpposite/key/cycleway/value/opposite"></see>
    /// </summary>
    let ``CyclewayOpposite/key/cycleway/value/opposite`` =
        Namespaced_IRI.parse _namespace_name "CyclewayOpposite/key/cycleway/value/opposite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOppositeLane"></see>
    /// </summary>
    let CyclewayOppositeLane =
        Namespaced_IRI.parse _namespace_name "CyclewayOppositeLane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOppositeLane/key/cycleway/value/opposite_lane"></see>
    /// </summary>
    let ``CyclewayOppositeLane/key/cycleway/value/opposite_lane`` =
        Namespaced_IRI.parse _namespace_name "CyclewayOppositeLane/key/cycleway/value/opposite_lane" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOppositeTrack"></see>
    /// </summary>
    let CyclewayOppositeTrack =
        Namespaced_IRI.parse _namespace_name "CyclewayOppositeTrack" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOppositeTrack/key/cycleway/value/opposite_track"></see>
    /// </summary>
    let ``CyclewayOppositeTrack/key/cycleway/value/opposite_track`` =
        Namespaced_IRI.parse _namespace_name "CyclewayOppositeTrack/key/cycleway/value/opposite_track" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayTrack"></see>
    /// </summary>
    let CyclewayTrack =
        Namespaced_IRI.parse _namespace_name "CyclewayTrack" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayTrack/key/cycleway/value/track"></see>
    /// </summary>
    let ``CyclewayTrack/key/cycleway/value/track`` =
        Namespaced_IRI.parse _namespace_name "CyclewayTrack/key/cycleway/value/track" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dairy"></see>
    /// </summary>
    let Dairy = Namespaced_IRI.parse _namespace_name "Dairy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dairy/key/shop/value/dairy"></see>
    /// </summary>
    let ``Dairy/key/shop/value/dairy`` =
        Namespaced_IRI.parse _namespace_name "Dairy/key/shop/value/dairy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dam"></see>
    /// </summary>
    let Dam = Namespaced_IRI.parse _namespace_name "Dam" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dam/key/waterway/value/dam"></see>
    /// </summary>
    let ``Dam/key/waterway/value/dam`` =
        Namespaced_IRI.parse _namespace_name "Dam/key/waterway/value/dam" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dance"></see>
    /// </summary>
    let Dance = Namespaced_IRI.parse _namespace_name "Dance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dance/key/leisure/value/dance"></see>
    /// </summary>
    let ``Dance/key/leisure/value/dance`` =
        Namespaced_IRI.parse _namespace_name "Dance/key/leisure/value/dance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DangerArea"></see>
    /// </summary>
    let DangerArea = Namespaced_IRI.parse _namespace_name "DangerArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DangerArea/key/military/value/danger_area"></see>
    /// </summary>
    let ``DangerArea/key/military/value/danger_area`` =
        Namespaced_IRI.parse _namespace_name "DangerArea/key/military/value/danger_area" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Daycare"></see>
    /// </summary>
    let Daycare = Namespaced_IRI.parse _namespace_name "Daycare" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Daycare/key/amenity/value/daycare"></see>
    /// </summary>
    let ``Daycare/key/amenity/value/daycare`` =
        Namespaced_IRI.parse _namespace_name "Daycare/key/amenity/value/daycare" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DeadPub"></see>
    /// </summary>
    let DeadPub = Namespaced_IRI.parse _namespace_name "DeadPub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DeadPub/key/amenity/value/dead_pub"></see>
    /// </summary>
    let ``DeadPub/key/amenity/value/dead_pub`` =
        Namespaced_IRI.parse _namespace_name "DeadPub/key/amenity/value/dead_pub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Decoration"></see>
    /// </summary>
    let Decoration = Namespaced_IRI.parse _namespace_name "Decoration" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Decoration/key/shop/value/decoration"></see>
    /// </summary>
    let ``Decoration/key/shop/value/decoration`` =
        Namespaced_IRI.parse _namespace_name "Decoration/key/shop/value/decoration" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Deli"></see>
    /// </summary>
    let Deli = Namespaced_IRI.parse _namespace_name "Deli" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Deli/key/shop/value/deli"></see>
    /// </summary>
    let ``Deli/key/shop/value/deli`` =
        Namespaced_IRI.parse _namespace_name "Deli/key/shop/value/deli" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Delicatessen"></see>
    /// </summary>
    let Delicatessen =
        Namespaced_IRI.parse _namespace_name "Delicatessen" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Delicatessen/key/shop/value/delicatessen"></see>
    /// </summary>
    let ``Delicatessen/key/shop/value/delicatessen`` =
        Namespaced_IRI.parse _namespace_name "Delicatessen/key/shop/value/delicatessen" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dentist"></see>
    /// </summary>
    let Dentist = Namespaced_IRI.parse _namespace_name "Dentist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dentist/key/amenity/value/dentist"></see>
    /// </summary>
    let ``Dentist/key/amenity/value/dentist`` =
        Namespaced_IRI.parse _namespace_name "Dentist/key/amenity/value/dentist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DepartmentStore"></see>
    /// </summary>
    let DepartmentStore =
        Namespaced_IRI.parse _namespace_name "DepartmentStore" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DepartmentStore/key/shop/value/department_store"></see>
    /// </summary>
    let ``DepartmentStore/key/shop/value/department_store`` =
        Namespaced_IRI.parse _namespace_name "DepartmentStore/key/shop/value/department_store" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dept"></see>
    /// </summary>
    let Dept = Namespaced_IRI.parse _namespace_name "Dept" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dept/key/shop/value/dept"></see>
    /// </summary>
    let ``Dept/key/shop/value/dept`` =
        Namespaced_IRI.parse _namespace_name "Dept/key/shop/value/dept" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Depth"></see>
    /// </summary>
    let Depth = Namespaced_IRI.parse _namespace_name "Depth" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Depth/key/waterway/value/depth"></see>
    /// </summary>
    let ``Depth/key/waterway/value/depth`` =
        Namespaced_IRI.parse _namespace_name "Depth/key/waterway/value/depth" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Derestricted+speed+limit"></see>
    /// </summary>
    let ``Derestricted+speed+limit`` =
        Namespaced_IRI.parse _namespace_name "Derestricted+speed+limit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Derestricted+speed+limit/key/amenity/value/derestricted%20speed%20limit"></see>
    /// </summary>
    let ``Derestricted+speed+limit/key/amenity/value/derestricted%20speed%20limit`` =
        Namespaced_IRI.parse _namespace_name "Derestricted+speed+limit/key/amenity/value/derestricted%20speed%20limit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Design"></see>
    /// </summary>
    let Design = Namespaced_IRI.parse _namespace_name "Design" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Design/key/shop/value/design"></see>
    /// </summary>
    let ``Design/key/shop/value/design`` =
        Namespaced_IRI.parse _namespace_name "Design/key/shop/value/design" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Detached"></see>
    /// </summary>
    let Detached = Namespaced_IRI.parse _namespace_name "Detached" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Detached/key/building/value/detached"></see>
    /// </summary>
    let ``Detached/key/building/value/detached`` =
        Namespaced_IRI.parse _namespace_name "Detached/key/building/value/detached" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DetourRoute"></see>
    /// </summary>
    let DetourRoute =
        Namespaced_IRI.parse _namespace_name "DetourRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DetourRoute/key/route/value/detour"></see>
    /// </summary>
    let ``DetourRoute/key/route/value/detour`` =
        Namespaced_IRI.parse _namespace_name "DetourRoute/key/route/value/detour" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Discount"></see>
    /// </summary>
    let Discount = Namespaced_IRI.parse _namespace_name "Discount" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Discount/key/shop/value/discount"></see>
    /// </summary>
    let ``Discount/key/shop/value/discount`` =
        Namespaced_IRI.parse _namespace_name "Discount/key/shop/value/discount" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedPub"></see>
    /// </summary>
    let DisusedPub = Namespaced_IRI.parse _namespace_name "DisusedPub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedPub/key/amenity/value/disused_pub"></see>
    /// </summary>
    let ``DisusedPub/key/amenity/value/disused_pub`` =
        Namespaced_IRI.parse _namespace_name "DisusedPub/key/amenity/value/disused_pub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedRailway"></see>
    /// </summary>
    let DisusedRailway =
        Namespaced_IRI.parse _namespace_name "DisusedRailway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedRailway/key/railway/value/disused"></see>
    /// </summary>
    let ``DisusedRailway/key/railway/value/disused`` =
        Namespaced_IRI.parse _namespace_name "DisusedRailway/key/railway/value/disused" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedStation"></see>
    /// </summary>
    let DisusedStation =
        Namespaced_IRI.parse _namespace_name "DisusedStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedStation/key/railway/value/disused_station"></see>
    /// </summary>
    let ``DisusedStation/key/railway/value/disused_station`` =
        Namespaced_IRI.parse _namespace_name "DisusedStation/key/railway/value/disused_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ditch"></see>
    /// </summary>
    let Ditch = Namespaced_IRI.parse _namespace_name "Ditch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ditch/key/waterway/value/ditch"></see>
    /// </summary>
    let ``Ditch/key/waterway/value/ditch`` =
        Namespaced_IRI.parse _namespace_name "Ditch/key/waterway/value/ditch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DitchBarrier"></see>
    /// </summary>
    let DitchBarrier =
        Namespaced_IRI.parse _namespace_name "DitchBarrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DitchBarrier/key/barrier/value/ditch"></see>
    /// </summary>
    let ``DitchBarrier/key/barrier/value/ditch`` =
        Namespaced_IRI.parse _namespace_name "DitchBarrier/key/barrier/value/ditch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DiveCenter"></see>
    /// </summary>
    let DiveCenter = Namespaced_IRI.parse _namespace_name "DiveCenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DiveCenter/key/amenity/value/dive_center"></see>
    /// </summary>
    let ``DiveCenter/key/amenity/value/dive_center`` =
        Namespaced_IRI.parse _namespace_name "DiveCenter/key/amenity/value/dive_center" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DiveCentre"></see>
    /// </summary>
    let DiveCentre = Namespaced_IRI.parse _namespace_name "DiveCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DiveCentre/key/shop/value/dive_centre"></see>
    /// </summary>
    let ``DiveCentre/key/shop/value/dive_centre`` =
        Namespaced_IRI.parse _namespace_name "DiveCentre/key/shop/value/dive_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Diy"></see>
    /// </summary>
    let Diy = Namespaced_IRI.parse _namespace_name "Diy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Diy/key/shop/value/diy"></see>
    /// </summary>
    let ``Diy/key/shop/value/diy`` =
        Namespaced_IRI.parse _namespace_name "Diy/key/shop/value/diy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dock"></see>
    /// </summary>
    let Dock = Namespaced_IRI.parse _namespace_name "Dock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dock/key/waterway/value/dock"></see>
    /// </summary>
    let ``Dock/key/waterway/value/dock`` =
        Namespaced_IRI.parse _namespace_name "Dock/key/waterway/value/dock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doctor"></see>
    /// </summary>
    let Doctor = Namespaced_IRI.parse _namespace_name "Doctor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doctor/key/amenity/value/doctor"></see>
    /// </summary>
    let ``Doctor/key/amenity/value/doctor`` =
        Namespaced_IRI.parse _namespace_name "Doctor/key/amenity/value/doctor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doctors"></see>
    /// </summary>
    let Doctors = Namespaced_IRI.parse _namespace_name "Doctors" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doctors/key/amenity/value/doctors"></see>
    /// </summary>
    let ``Doctors/key/amenity/value/doctors`` =
        Namespaced_IRI.parse _namespace_name "Doctors/key/amenity/value/doctors" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogBin"></see>
    /// </summary>
    let DogBin = Namespaced_IRI.parse _namespace_name "DogBin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogBin/key/amenity/value/dog_bin"></see>
    /// </summary>
    let ``DogBin/key/amenity/value/dog_bin`` =
        Namespaced_IRI.parse _namespace_name "DogBin/key/amenity/value/dog_bin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogPark"></see>
    /// </summary>
    let DogPark = Namespaced_IRI.parse _namespace_name "DogPark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogPark/key/leisure/value/dog_park"></see>
    /// </summary>
    let ``DogPark/key/leisure/value/dog_park`` =
        Namespaced_IRI.parse _namespace_name "DogPark/key/leisure/value/dog_park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogWaste"></see>
    /// </summary>
    let DogWaste = Namespaced_IRI.parse _namespace_name "DogWaste" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogWaste/key/amenity/value/dog_waste"></see>
    /// </summary>
    let ``DogWaste/key/amenity/value/dog_waste`` =
        Namespaced_IRI.parse _namespace_name "DogWaste/key/amenity/value/dog_waste" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doityourself"></see>
    /// </summary>
    let Doityourself =
        Namespaced_IRI.parse _namespace_name "Doityourself" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doityourself/key/shop/value/doityourself"></see>
    /// </summary>
    let ``Doityourself/key/shop/value/doityourself`` =
        Namespaced_IRI.parse _namespace_name "Doityourself/key/shop/value/doityourself" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dollar"></see>
    /// </summary>
    let Dollar = Namespaced_IRI.parse _namespace_name "Dollar" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dollar/key/shop/value/dollar"></see>
    /// </summary>
    let ``Dollar/key/shop/value/dollar`` =
        Namespaced_IRI.parse _namespace_name "Dollar/key/shop/value/dollar" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dormitory"></see>
    /// </summary>
    let Dormitory = Namespaced_IRI.parse _namespace_name "Dormitory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dormitory/key/amenity/value/dormitory"></see>
    /// </summary>
    let ``Dormitory/key/amenity/value/dormitory`` =
        Namespaced_IRI.parse _namespace_name "Dormitory/key/amenity/value/dormitory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Downhill+Terminal"></see>
    /// </summary>
    let ``Downhill+Terminal`` =
        Namespaced_IRI.parse _namespace_name "Downhill+Terminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Downhill+Terminal/key/man_made/value/Downhill%20Terminal"></see>
    /// </summary>
    let ``Downhill+Terminal/key/man_made/value/Downhill%20Terminal`` =
        Namespaced_IRI.parse _namespace_name "Downhill+Terminal/key/man_made/value/Downhill%20Terminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DragLift"></see>
    /// </summary>
    let DragLift = Namespaced_IRI.parse _namespace_name "DragLift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DragLift/key/aerialway/value/drag_lift"></see>
    /// </summary>
    let ``DragLift/key/aerialway/value/drag_lift`` =
        Namespaced_IRI.parse _namespace_name "DragLift/key/aerialway/value/drag_lift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Drain"></see>
    /// </summary>
    let Drain = Namespaced_IRI.parse _namespace_name "Drain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Drain/key/waterway/value/drain"></see>
    /// </summary>
    let ``Drain/key/waterway/value/drain`` =
        Namespaced_IRI.parse _namespace_name "Drain/key/waterway/value/drain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dressmaker"></see>
    /// </summary>
    let Dressmaker = Namespaced_IRI.parse _namespace_name "Dressmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dressmaker/key/craft/value/dressmaker"></see>
    /// </summary>
    let ``Dressmaker/key/craft/value/dressmaker`` =
        Namespaced_IRI.parse _namespace_name "Dressmaker/key/craft/value/dressmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrinkingWater"></see>
    /// </summary>
    let DrinkingWater =
        Namespaced_IRI.parse _namespace_name "DrinkingWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrinkingWater/key/amenity/value/drinking_water"></see>
    /// </summary>
    let ``DrinkingWater/key/amenity/value/drinking_water`` =
        Namespaced_IRI.parse _namespace_name "DrinkingWater/key/amenity/value/drinking_water" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DriveWay"></see>
    /// </summary>
    let DriveWay = Namespaced_IRI.parse _namespace_name "DriveWay" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DriveWay/key/service/value/driveway"></see>
    /// </summary>
    let ``DriveWay/key/service/value/driveway`` =
        Namespaced_IRI.parse _namespace_name "DriveWay/key/service/value/driveway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrivingSchool"></see>
    /// </summary>
    let DrivingSchool =
        Namespaced_IRI.parse _namespace_name "DrivingSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrivingSchool/key/amenity/value/driving_school"></see>
    /// </summary>
    let ``DrivingSchool/key/amenity/value/driving_school`` =
        Namespaced_IRI.parse _namespace_name "DrivingSchool/key/amenity/value/driving_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrivingSchoolShop"></see>
    /// </summary>
    let DrivingSchoolShop =
        Namespaced_IRI.parse _namespace_name "DrivingSchoolShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrivingSchoolShop/key/shop/value/driving_school"></see>
    /// </summary>
    let ``DrivingSchoolShop/key/shop/value/driving_school`` =
        Namespaced_IRI.parse _namespace_name "DrivingSchoolShop/key/shop/value/driving_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Drugstore"></see>
    /// </summary>
    let Drugstore = Namespaced_IRI.parse _namespace_name "Drugstore" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Drugstore/key/shop/value/drugstore"></see>
    /// </summary>
    let ``Drugstore/key/shop/value/drugstore`` =
        Namespaced_IRI.parse _namespace_name "Drugstore/key/shop/value/drugstore" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DryCleaning"></see>
    /// </summary>
    let DryCleaning =
        Namespaced_IRI.parse _namespace_name "DryCleaning" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DryCleaning/key/shop/value/dry_cleaning"></see>
    /// </summary>
    let ``DryCleaning/key/shop/value/dry_cleaning`` =
        Namespaced_IRI.parse _namespace_name "DryCleaning/key/shop/value/dry_cleaning" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EducationalInstitutionOffice"></see>
    /// </summary>
    let EducationalInstitutionOffice =
        Namespaced_IRI.parse _namespace_name "EducationalInstitutionOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EducationalInstitutionOffice/key/office/value/educational_institution"></see>
    /// </summary>
    let ``EducationalInstitutionOffice/key/office/value/educational_institution`` =
        Namespaced_IRI.parse _namespace_name "EducationalInstitutionOffice/key/office/value/educational_institution" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electrician"></see>
    /// </summary>
    let Electrician =
        Namespaced_IRI.parse _namespace_name "Electrician" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electrician/key/shop/value/electrician"></see>
    /// </summary>
    let ``Electrician/key/shop/value/electrician`` =
        Namespaced_IRI.parse _namespace_name "Electrician/key/shop/value/electrician" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electrician/key/craft/value/electrician"></see>
    /// </summary>
    let ``Electrician/key/craft/value/electrician`` =
        Namespaced_IRI.parse _namespace_name "Electrician/key/craft/value/electrician" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electronics"></see>
    /// </summary>
    let Electronics =
        Namespaced_IRI.parse _namespace_name "Electronics" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electronics/key/shop/value/electronics"></see>
    /// </summary>
    let ``Electronics/key/shop/value/electronics`` =
        Namespaced_IRI.parse _namespace_name "Electronics/key/shop/value/electronics" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Elevator"></see>
    /// </summary>
    let Elevator = Namespaced_IRI.parse _namespace_name "Elevator" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Elevator/key/amenity/value/elevator"></see>
    /// </summary>
    let ``Elevator/key/amenity/value/elevator`` =
        Namespaced_IRI.parse _namespace_name "Elevator/key/amenity/value/elevator" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Embassy"></see>
    /// </summary>
    let Embassy = Namespaced_IRI.parse _namespace_name "Embassy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Embassy/key/amenity/value/embassy"></see>
    /// </summary>
    let ``Embassy/key/amenity/value/embassy`` =
        Namespaced_IRI.parse _namespace_name "Embassy/key/amenity/value/embassy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyAccessPoint"></see>
    /// </summary>
    let EmergencyAccessPoint =
        Namespaced_IRI.parse _namespace_name "EmergencyAccessPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyAccessPoint/key/highway/value/emergency_access_point"></see>
    /// </summary>
    let ``EmergencyAccessPoint/key/highway/value/emergency_access_point`` =
        Namespaced_IRI.parse _namespace_name "EmergencyAccessPoint/key/highway/value/emergency_access_point" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyPhone"></see>
    /// </summary>
    let EmergencyPhone =
        Namespaced_IRI.parse _namespace_name "EmergencyPhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyPhone/key/emergency/value/phone"></see>
    /// </summary>
    let ``EmergencyPhone/key/emergency/value/phone`` =
        Namespaced_IRI.parse _namespace_name "EmergencyPhone/key/emergency/value/phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyPhone/key/amenity/value/emergency_phone"></see>
    /// </summary>
    let ``EmergencyPhone/key/amenity/value/emergency_phone`` =
        Namespaced_IRI.parse _namespace_name "EmergencyPhone/key/amenity/value/emergency_phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencySiren"></see>
    /// </summary>
    let EmergencySiren =
        Namespaced_IRI.parse _namespace_name "EmergencySiren" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencySiren/key/emergency/value/siren"></see>
    /// </summary>
    let ``EmergencySiren/key/emergency/value/siren`` =
        Namespaced_IRI.parse _namespace_name "EmergencySiren/key/emergency/value/siren" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyTelephone"></see>
    /// </summary>
    let EmergencyTelephone =
        Namespaced_IRI.parse _namespace_name "EmergencyTelephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyTelephone/key/amenity/value/emergency_telephone"></see>
    /// </summary>
    let ``EmergencyTelephone/key/amenity/value/emergency_telephone`` =
        Namespaced_IRI.parse _namespace_name "EmergencyTelephone/key/amenity/value/emergency_telephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmploymentAgencyOffice"></see>
    /// </summary>
    let EmploymentAgencyOffice =
        Namespaced_IRI.parse _namespace_name "EmploymentAgencyOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmploymentAgencyOffice/key/office/value/employment_agency"></see>
    /// </summary>
    let ``EmploymentAgencyOffice/key/office/value/employment_agency`` =
        Namespaced_IRI.parse _namespace_name "EmploymentAgencyOffice/key/office/value/employment_agency" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Empty"></see>
    /// </summary>
    let Empty = Namespaced_IRI.parse _namespace_name "Empty" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Empty/key/shop/value/empty"></see>
    /// </summary>
    let ``Empty/key/shop/value/empty`` =
        Namespaced_IRI.parse _namespace_name "Empty/key/shop/value/empty" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entrance"></see>
    /// </summary>
    let Entrance = Namespaced_IRI.parse _namespace_name "Entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entrance/key/barrier/value/entrance"></see>
    /// </summary>
    let ``Entrance/key/barrier/value/entrance`` =
        Namespaced_IRI.parse _namespace_name "Entrance/key/barrier/value/entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entrance/key/amenity/value/entrance"></see>
    /// </summary>
    let ``Entrance/key/amenity/value/entrance`` =
        Namespaced_IRI.parse _namespace_name "Entrance/key/amenity/value/entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entry"></see>
    /// </summary>
    let Entry = Namespaced_IRI.parse _namespace_name "Entry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entry/key/building/value/entry"></see>
    /// </summary>
    let ``Entry/key/building/value/entry`` =
        Namespaced_IRI.parse _namespace_name "Entry/key/building/value/entry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EnvironmentalHazard"></see>
    /// </summary>
    let EnvironmentalHazard =
        Namespaced_IRI.parse _namespace_name "EnvironmentalHazard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EnvironmentalHazard/key/man_made/value/environmental_hazard"></see>
    /// </summary>
    let ``EnvironmentalHazard/key/man_made/value/environmental_hazard`` =
        Namespaced_IRI.parse _namespace_name "EnvironmentalHazard/key/man_made/value/environmental_hazard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Estanco"></see>
    /// </summary>
    let Estanco = Namespaced_IRI.parse _namespace_name "Estanco" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Estanco/key/shop/value/estanco"></see>
    /// </summary>
    let ``Estanco/key/shop/value/estanco`` =
        Namespaced_IRI.parse _namespace_name "Estanco/key/shop/value/estanco" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EstateAgent"></see>
    /// </summary>
    let EstateAgent =
        Namespaced_IRI.parse _namespace_name "EstateAgent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EstateAgent/key/shop/value/estate_agent"></see>
    /// </summary>
    let ``EstateAgent/key/shop/value/estate_agent`` =
        Namespaced_IRI.parse _namespace_name "EstateAgent/key/shop/value/estate_agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EstateAgentOffice"></see>
    /// </summary>
    let EstateAgentOffice =
        Namespaced_IRI.parse _namespace_name "EstateAgentOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EstateAgentOffice/key/office/value/estate_agent"></see>
    /// </summary>
    let ``EstateAgentOffice/key/office/value/estate_agent`` =
        Namespaced_IRI.parse _namespace_name "EstateAgentOffice/key/office/value/estate_agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EvCharging"></see>
    /// </summary>
    let EvCharging = Namespaced_IRI.parse _namespace_name "EvCharging" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EvCharging/key/amenity/value/ev_charging"></see>
    /// </summary>
    let ``EvCharging/key/amenity/value/ev_charging`` =
        Namespaced_IRI.parse _namespace_name "EvCharging/key/amenity/value/ev_charging" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fabric"></see>
    /// </summary>
    let Fabric = Namespaced_IRI.parse _namespace_name "Fabric" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fabric/key/shop/value/fabric"></see>
    /// </summary>
    let ``Fabric/key/shop/value/fabric`` =
        Namespaced_IRI.parse _namespace_name "Fabric/key/shop/value/fabric" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fabrics"></see>
    /// </summary>
    let Fabrics = Namespaced_IRI.parse _namespace_name "Fabrics" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fabrics/key/shop/value/fabrics"></see>
    /// </summary>
    let ``Fabrics/key/shop/value/fabrics`` =
        Namespaced_IRI.parse _namespace_name "Fabrics/key/shop/value/fabrics" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Factory"></see>
    /// </summary>
    let Factory = Namespaced_IRI.parse _namespace_name "Factory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Factory/key/amenity/value/factory"></see>
    /// </summary>
    let ``Factory/key/amenity/value/factory`` =
        Namespaced_IRI.parse _namespace_name "Factory/key/amenity/value/factory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fairtrade"></see>
    /// </summary>
    let Fairtrade = Namespaced_IRI.parse _namespace_name "Fairtrade" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fairtrade/key/shop/value/fairtrade"></see>
    /// </summary>
    let ``Fairtrade/key/shop/value/fairtrade`` =
        Namespaced_IRI.parse _namespace_name "Fairtrade/key/shop/value/fairtrade" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farm"></see>
    /// </summary>
    let Farm = Namespaced_IRI.parse _namespace_name "Farm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farm/key/place/value/farm"></see>
    /// </summary>
    let ``Farm/key/place/value/farm`` =
        Namespaced_IRI.parse _namespace_name "Farm/key/place/value/farm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farm/key/landuse/value/farm"></see>
    /// </summary>
    let ``Farm/key/landuse/value/farm`` =
        Namespaced_IRI.parse _namespace_name "Farm/key/landuse/value/farm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farm/key/amenity/value/farm"></see>
    /// </summary>
    let ``Farm/key/amenity/value/farm`` =
        Namespaced_IRI.parse _namespace_name "Farm/key/amenity/value/farm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FarmShop"></see>
    /// </summary>
    let FarmShop = Namespaced_IRI.parse _namespace_name "FarmShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FarmShop/key/shop/value/farm"></see>
    /// </summary>
    let ``FarmShop/key/shop/value/farm`` =
        Namespaced_IRI.parse _namespace_name "FarmShop/key/shop/value/farm" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FarmShop/key/shop/value/farm_shop"></see>
    /// </summary>
    let ``FarmShop/key/shop/value/farm_shop`` =
        Namespaced_IRI.parse _namespace_name "FarmShop/key/shop/value/farm_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farmland"></see>
    /// </summary>
    let Farmland = Namespaced_IRI.parse _namespace_name "Farmland" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farmland/key/landuse/value/farmland"></see>
    /// </summary>
    let ``Farmland/key/landuse/value/farmland`` =
        Namespaced_IRI.parse _namespace_name "Farmland/key/landuse/value/farmland" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farmyard"></see>
    /// </summary>
    let Farmyard = Namespaced_IRI.parse _namespace_name "Farmyard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farmyard/key/landuse/value/farmyard"></see>
    /// </summary>
    let ``Farmyard/key/landuse/value/farmyard`` =
        Namespaced_IRI.parse _namespace_name "Farmyard/key/landuse/value/farmyard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fashion"></see>
    /// </summary>
    let Fashion = Namespaced_IRI.parse _namespace_name "Fashion" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fashion/key/shop/value/fashion"></see>
    /// </summary>
    let ``Fashion/key/shop/value/fashion`` =
        Namespaced_IRI.parse _namespace_name "Fashion/key/shop/value/fashion" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FastFood"></see>
    /// </summary>
    let FastFood = Namespaced_IRI.parse _namespace_name "FastFood" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FastFood/key/amenity/value/fast_food"></see>
    /// </summary>
    let ``FastFood/key/amenity/value/fast_food`` =
        Namespaced_IRI.parse _namespace_name "FastFood/key/amenity/value/fast_food" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Feature"></see>
    /// </summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Feature/key/natural/value/feature"></see>
    /// </summary>
    let ``Feature/key/natural/value/feature`` =
        Namespaced_IRI.parse _namespace_name "Feature/key/natural/value/feature" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fell"></see>
    /// </summary>
    let Fell = Namespaced_IRI.parse _namespace_name "Fell" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fell/key/natural/value/fell"></see>
    /// </summary>
    let ``Fell/key/natural/value/fell`` =
        Namespaced_IRI.parse _namespace_name "Fell/key/natural/value/fell" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fen"></see>
    /// </summary>
    let Fen = Namespaced_IRI.parse _namespace_name "Fen" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fen/key/natural/value/fen"></see>
    /// </summary>
    let ``Fen/key/natural/value/fen`` =
        Namespaced_IRI.parse _namespace_name "Fen/key/natural/value/fen" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fence"></see>
    /// </summary>
    let Fence = Namespaced_IRI.parse _namespace_name "Fence" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fence/key/barrier/value/fence"></see>
    /// </summary>
    let ``Fence/key/barrier/value/fence`` =
        Namespaced_IRI.parse _namespace_name "Fence/key/barrier/value/fence" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FerryRoute"></see>
    /// </summary>
    let FerryRoute = Namespaced_IRI.parse _namespace_name "FerryRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FerryRoute/key/route/value/ferry"></see>
    /// </summary>
    let ``FerryRoute/key/route/value/ferry`` =
        Namespaced_IRI.parse _namespace_name "FerryRoute/key/route/value/ferry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FerryTerminal"></see>
    /// </summary>
    let FerryTerminal =
        Namespaced_IRI.parse _namespace_name "FerryTerminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FerryTerminal/key/amenity/value/ferry_terminal"></see>
    /// </summary>
    let ``FerryTerminal/key/amenity/value/ferry_terminal`` =
        Namespaced_IRI.parse _namespace_name "FerryTerminal/key/amenity/value/ferry_terminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Financial"></see>
    /// </summary>
    let Financial = Namespaced_IRI.parse _namespace_name "Financial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Financial/key/shop/value/financial"></see>
    /// </summary>
    let ``Financial/key/shop/value/financial`` =
        Namespaced_IRI.parse _namespace_name "Financial/key/shop/value/financial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireBeater"></see>
    /// </summary>
    let FireBeater = Namespaced_IRI.parse _namespace_name "FireBeater" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireBeater/key/amenity/value/fire_beater"></see>
    /// </summary>
    let ``FireBeater/key/amenity/value/fire_beater`` =
        Namespaced_IRI.parse _namespace_name "FireBeater/key/amenity/value/fire_beater" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireExtinguisher"></see>
    /// </summary>
    let FireExtinguisher =
        Namespaced_IRI.parse _namespace_name "FireExtinguisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireExtinguisher/key/emergency/value/fire_extinguisher"></see>
    /// </summary>
    let ``FireExtinguisher/key/emergency/value/fire_extinguisher`` =
        Namespaced_IRI.parse _namespace_name "FireExtinguisher/key/emergency/value/fire_extinguisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireFlapper"></see>
    /// </summary>
    let FireFlapper =
        Namespaced_IRI.parse _namespace_name "FireFlapper" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireFlapper/key/emergency/value/fire_flapper"></see>
    /// </summary>
    let ``FireFlapper/key/emergency/value/fire_flapper`` =
        Namespaced_IRI.parse _namespace_name "FireFlapper/key/emergency/value/fire_flapper" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHose"></see>
    /// </summary>
    let FireHose = Namespaced_IRI.parse _namespace_name "FireHose" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHose/key/emergency/value/fire_hose"></see>
    /// </summary>
    let ``FireHose/key/emergency/value/fire_hose`` =
        Namespaced_IRI.parse _namespace_name "FireHose/key/emergency/value/fire_hose" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHydrant"></see>
    /// </summary>
    let FireHydrant =
        Namespaced_IRI.parse _namespace_name "FireHydrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHydrant/key/amenity/value/fire_hydrant"></see>
    /// </summary>
    let ``FireHydrant/key/amenity/value/fire_hydrant`` =
        Namespaced_IRI.parse _namespace_name "FireHydrant/key/amenity/value/fire_hydrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHydrant/key/emergency/value/fire_hydrant"></see>
    /// </summary>
    let ``FireHydrant/key/emergency/value/fire_hydrant`` =
        Namespaced_IRI.parse _namespace_name "FireHydrant/key/emergency/value/fire_hydrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireStation"></see>
    /// </summary>
    let FireStation =
        Namespaced_IRI.parse _namespace_name "FireStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireStation/key/amenity/value/fire_station"></see>
    /// </summary>
    let ``FireStation/key/amenity/value/fire_station`` =
        Namespaced_IRI.parse _namespace_name "FireStation/key/amenity/value/fire_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fireplace"></see>
    /// </summary>
    let Fireplace = Namespaced_IRI.parse _namespace_name "Fireplace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fireplace/key/amenity/value/fireplace"></see>
    /// </summary>
    let ``Fireplace/key/amenity/value/fireplace`` =
        Namespaced_IRI.parse _namespace_name "Fireplace/key/amenity/value/fireplace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FirstAid"></see>
    /// </summary>
    let FirstAid = Namespaced_IRI.parse _namespace_name "FirstAid" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FirstAid/key/amenity/value/first_aid"></see>
    /// </summary>
    let ``FirstAid/key/amenity/value/first_aid`` =
        Namespaced_IRI.parse _namespace_name "FirstAid/key/amenity/value/first_aid" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fish"></see>
    /// </summary>
    let Fish = Namespaced_IRI.parse _namespace_name "Fish" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fish/key/shop/value/fish"></see>
    /// </summary>
    let ``Fish/key/shop/value/fish`` =
        Namespaced_IRI.parse _namespace_name "Fish/key/shop/value/fish" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fishing"></see>
    /// </summary>
    let Fishing = Namespaced_IRI.parse _namespace_name "Fishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fishing/key/leisure/value/fishing"></see>
    /// </summary>
    let ``Fishing/key/leisure/value/fishing`` =
        Namespaced_IRI.parse _namespace_name "Fishing/key/leisure/value/fishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FishingShop"></see>
    /// </summary>
    let FishingShop =
        Namespaced_IRI.parse _namespace_name "FishingShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FishingShop/key/shop/value/fishing"></see>
    /// </summary>
    let ``FishingShop/key/shop/value/fishing`` =
        Namespaced_IRI.parse _namespace_name "FishingShop/key/shop/value/fishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fishmonger"></see>
    /// </summary>
    let Fishmonger = Namespaced_IRI.parse _namespace_name "Fishmonger" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fishmonger/key/shop/value/fishmonger"></see>
    /// </summary>
    let ``Fishmonger/key/shop/value/fishmonger`` =
        Namespaced_IRI.parse _namespace_name "Fishmonger/key/shop/value/fishmonger" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fitness"></see>
    /// </summary>
    let Fitness = Namespaced_IRI.parse _namespace_name "Fitness" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fitness/key/leisure/value/fitness"></see>
    /// </summary>
    let ``Fitness/key/leisure/value/fitness`` =
        Namespaced_IRI.parse _namespace_name "Fitness/key/leisure/value/fitness" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fitness+trail"></see>
    /// </summary>
    let ``Fitness+trail`` =
        Namespaced_IRI.parse _namespace_name "Fitness+trail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fitness+trail/key/leisure/value/fitness%20trail"></see>
    /// </summary>
    let ``Fitness+trail/key/leisure/value/fitness%20trail`` =
        Namespaced_IRI.parse _namespace_name "Fitness+trail/key/leisure/value/fitness%20trail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FitnessCentre"></see>
    /// </summary>
    let FitnessCentre =
        Namespaced_IRI.parse _namespace_name "FitnessCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FitnessCentre/key/leisure/value/fitness_centre"></see>
    /// </summary>
    let ``FitnessCentre/key/leisure/value/fitness_centre`` =
        Namespaced_IRI.parse _namespace_name "FitnessCentre/key/leisure/value/fitness_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FitnessShop"></see>
    /// </summary>
    let FitnessShop =
        Namespaced_IRI.parse _namespace_name "FitnessShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FitnessShop/key/shop/value/fitness"></see>
    /// </summary>
    let ``FitnessShop/key/shop/value/fitness`` =
        Namespaced_IRI.parse _namespace_name "FitnessShop/key/shop/value/fitness" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fjord"></see>
    /// </summary>
    let Fjord = Namespaced_IRI.parse _namespace_name "Fjord" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fjord/key/natural/value/fjord"></see>
    /// </summary>
    let ``Fjord/key/natural/value/fjord`` =
        Namespaced_IRI.parse _namespace_name "Fjord/key/natural/value/fjord" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flagpole"></see>
    /// </summary>
    let Flagpole = Namespaced_IRI.parse _namespace_name "Flagpole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flagpole/key/man_made/value/flagpole"></see>
    /// </summary>
    let ``Flagpole/key/man_made/value/flagpole`` =
        Namespaced_IRI.parse _namespace_name "Flagpole/key/man_made/value/flagpole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flats"></see>
    /// </summary>
    let Flats = Namespaced_IRI.parse _namespace_name "Flats" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flats/key/building/value/flats"></see>
    /// </summary>
    let ``Flats/key/building/value/flats`` =
        Namespaced_IRI.parse _namespace_name "Flats/key/building/value/flats" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flooring"></see>
    /// </summary>
    let Flooring = Namespaced_IRI.parse _namespace_name "Flooring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flooring/key/shop/value/flooring"></see>
    /// </summary>
    let ``Flooring/key/shop/value/flooring`` =
        Namespaced_IRI.parse _namespace_name "Flooring/key/shop/value/flooring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Florist"></see>
    /// </summary>
    let Florist = Namespaced_IRI.parse _namespace_name "Florist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Florist/key/amenity/value/florist"></see>
    /// </summary>
    let ``Florist/key/amenity/value/florist`` =
        Namespaced_IRI.parse _namespace_name "Florist/key/amenity/value/florist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FloristShop"></see>
    /// </summary>
    let FloristShop =
        Namespaced_IRI.parse _namespace_name "FloristShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FloristShop/key/shop/value/florist"></see>
    /// </summary>
    let ``FloristShop/key/shop/value/florist`` =
        Namespaced_IRI.parse _namespace_name "FloristShop/key/shop/value/florist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flowers"></see>
    /// </summary>
    let Flowers = Namespaced_IRI.parse _namespace_name "Flowers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flowers/key/shop/value/flowers"></see>
    /// </summary>
    let ``Flowers/key/shop/value/flowers`` =
        Namespaced_IRI.parse _namespace_name "Flowers/key/shop/value/flowers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FolkArt"></see>
    /// </summary>
    let FolkArt = Namespaced_IRI.parse _namespace_name "FolkArt" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FolkArt/key/shop/value/folk_art"></see>
    /// </summary>
    let ``FolkArt/key/shop/value/folk_art`` =
        Namespaced_IRI.parse _namespace_name "FolkArt/key/shop/value/folk_art" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Food"></see>
    /// </summary>
    let Food = Namespaced_IRI.parse _namespace_name "Food" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Food/key/shop/value/food"></see>
    /// </summary>
    let ``Food/key/shop/value/food`` =
        Namespaced_IRI.parse _namespace_name "Food/key/shop/value/food" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FoodCourt"></see>
    /// </summary>
    let FoodCourt = Namespaced_IRI.parse _namespace_name "FoodCourt" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FoodCourt/key/amenity/value/food_court"></see>
    /// </summary>
    let ``FoodCourt/key/amenity/value/food_court`` =
        Namespaced_IRI.parse _namespace_name "FoodCourt/key/amenity/value/food_court" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FootShower"></see>
    /// </summary>
    let FootShower = Namespaced_IRI.parse _namespace_name "FootShower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FootShower/key/amenity/value/foot_shower"></see>
    /// </summary>
    let ``FootShower/key/amenity/value/foot_shower`` =
        Namespaced_IRI.parse _namespace_name "FootShower/key/amenity/value/foot_shower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Footway"></see>
    /// </summary>
    let Footway = Namespaced_IRI.parse _namespace_name "Footway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Footway/key/highway/value/footway"></see>
    /// </summary>
    let ``Footway/key/highway/value/footway`` =
        Namespaced_IRI.parse _namespace_name "Footway/key/highway/value/footway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Forest"></see>
    /// </summary>
    let Forest = Namespaced_IRI.parse _namespace_name "Forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Forest/key/landuse/value/forest"></see>
    /// </summary>
    let ``Forest/key/landuse/value/forest`` =
        Namespaced_IRI.parse _namespace_name "Forest/key/landuse/value/forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Forester"></see>
    /// </summary>
    let Forester = Namespaced_IRI.parse _namespace_name "Forester" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Forester/key/amenity/value/forester"></see>
    /// </summary>
    let ``Forester/key/amenity/value/forester`` =
        Namespaced_IRI.parse _namespace_name "Forester/key/amenity/value/forester" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fort"></see>
    /// </summary>
    let Fort = Namespaced_IRI.parse _namespace_name "Fort" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fort/key/historic/value/fort"></see>
    /// </summary>
    let ``Fort/key/historic/value/fort`` =
        Namespaced_IRI.parse _namespace_name "Fort/key/historic/value/fort" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fortress"></see>
    /// </summary>
    let Fortress = Namespaced_IRI.parse _namespace_name "Fortress" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fortress/key/building/value/fortress"></see>
    /// </summary>
    let ``Fortress/key/building/value/fortress`` =
        Namespaced_IRI.parse _namespace_name "Fortress/key/building/value/fortress" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Foto"></see>
    /// </summary>
    let Foto = Namespaced_IRI.parse _namespace_name "Foto" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Foto/key/shop/value/foto"></see>
    /// </summary>
    let ``Foto/key/shop/value/foto`` =
        Namespaced_IRI.parse _namespace_name "Foto/key/shop/value/foto" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fountain"></see>
    /// </summary>
    let Fountain = Namespaced_IRI.parse _namespace_name "Fountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fountain/key/amenity/value/fountain"></see>
    /// </summary>
    let ``Fountain/key/amenity/value/fountain`` =
        Namespaced_IRI.parse _namespace_name "Fountain/key/amenity/value/fountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fraternity"></see>
    /// </summary>
    let Fraternity = Namespaced_IRI.parse _namespace_name "Fraternity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fraternity/key/amenity/value/fraternity"></see>
    /// </summary>
    let ``Fraternity/key/amenity/value/fraternity`` =
        Namespaced_IRI.parse _namespace_name "Fraternity/key/amenity/value/fraternity" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FrozenFoodShop"></see>
    /// </summary>
    let FrozenFoodShop =
        Namespaced_IRI.parse _namespace_name "FrozenFoodShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FrozenFoodShop/key/shop/value/frozen_food"></see>
    /// </summary>
    let ``FrozenFoodShop/key/shop/value/frozen_food`` =
        Namespaced_IRI.parse _namespace_name "FrozenFoodShop/key/shop/value/frozen_food" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fruit"></see>
    /// </summary>
    let Fruit = Namespaced_IRI.parse _namespace_name "Fruit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fruit/key/shop/value/fruit"></see>
    /// </summary>
    let ``Fruit/key/shop/value/fruit`` =
        Namespaced_IRI.parse _namespace_name "Fruit/key/shop/value/fruit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fuel%3BcarWash"></see>
    /// </summary>
    let ``Fuel%3BcarWash`` =
        Namespaced_IRI.parse _namespace_name "Fuel%3BcarWash" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fuel%3BcarWash/key/amenity/value/fuel%3Bcar_wash"></see>
    /// </summary>
    let ``Fuel%3BcarWash/key/amenity/value/fuel%3Bcar_wash`` =
        Namespaced_IRI.parse _namespace_name "Fuel%3BcarWash/key/amenity/value/fuel%3Bcar_wash" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuelStation"></see>
    /// </summary>
    let FuelStation =
        Namespaced_IRI.parse _namespace_name "FuelStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuelStation/key/amenity/value/fuel"></see>
    /// </summary>
    let ``FuelStation/key/amenity/value/fuel`` =
        Namespaced_IRI.parse _namespace_name "FuelStation/key/amenity/value/fuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuneralDirectors"></see>
    /// </summary>
    let FuneralDirectors =
        Namespaced_IRI.parse _namespace_name "FuneralDirectors" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuneralDirectors/key/shop/value/funeral_directors"></see>
    /// </summary>
    let ``FuneralDirectors/key/shop/value/funeral_directors`` =
        Namespaced_IRI.parse _namespace_name "FuneralDirectors/key/shop/value/funeral_directors" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuneralHome"></see>
    /// </summary>
    let FuneralHome =
        Namespaced_IRI.parse _namespace_name "FuneralHome" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuneralHome/key/amenity/value/funeral_home"></see>
    /// </summary>
    let ``FuneralHome/key/amenity/value/funeral_home`` =
        Namespaced_IRI.parse _namespace_name "FuneralHome/key/amenity/value/funeral_home" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FunicularRailway"></see>
    /// </summary>
    let FunicularRailway =
        Namespaced_IRI.parse _namespace_name "FunicularRailway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FunicularRailway/key/railway/value/funicular"></see>
    /// </summary>
    let ``FunicularRailway/key/railway/value/funicular`` =
        Namespaced_IRI.parse _namespace_name "FunicularRailway/key/railway/value/funicular" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Furniture"></see>
    /// </summary>
    let Furniture = Namespaced_IRI.parse _namespace_name "Furniture" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Furniture/key/shop/value/furniture"></see>
    /// </summary>
    let ``Furniture/key/shop/value/furniture`` =
        Namespaced_IRI.parse _namespace_name "Furniture/key/shop/value/furniture" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GagingStation"></see>
    /// </summary>
    let GagingStation =
        Namespaced_IRI.parse _namespace_name "GagingStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GagingStation/key/man_made/value/gaging_station"></see>
    /// </summary>
    let ``GagingStation/key/man_made/value/gaging_station`` =
        Namespaced_IRI.parse _namespace_name "GagingStation/key/man_made/value/gaging_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gallery"></see>
    /// </summary>
    let Gallery = Namespaced_IRI.parse _namespace_name "Gallery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gallery/key/amenity/value/gallery"></see>
    /// </summary>
    let ``Gallery/key/amenity/value/gallery`` =
        Namespaced_IRI.parse _namespace_name "Gallery/key/amenity/value/gallery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GalleryShop"></see>
    /// </summary>
    let GalleryShop =
        Namespaced_IRI.parse _namespace_name "GalleryShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GalleryShop/key/shop/value/gallery"></see>
    /// </summary>
    let ``GalleryShop/key/shop/value/gallery`` =
        Namespaced_IRI.parse _namespace_name "GalleryShop/key/shop/value/gallery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gambling"></see>
    /// </summary>
    let Gambling = Namespaced_IRI.parse _namespace_name "Gambling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gambling/key/amenity/value/gambling"></see>
    /// </summary>
    let ``Gambling/key/amenity/value/gambling`` =
        Namespaced_IRI.parse _namespace_name "Gambling/key/amenity/value/gambling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GamblingShop"></see>
    /// </summary>
    let GamblingShop =
        Namespaced_IRI.parse _namespace_name "GamblingShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GamblingShop/key/shop/value/gambling"></see>
    /// </summary>
    let ``GamblingShop/key/shop/value/gambling`` =
        Namespaced_IRI.parse _namespace_name "GamblingShop/key/shop/value/gambling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Games"></see>
    /// </summary>
    let Games = Namespaced_IRI.parse _namespace_name "Games" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Games/key/shop/value/games"></see>
    /// </summary>
    let ``Games/key/shop/value/games`` =
        Namespaced_IRI.parse _namespace_name "Games/key/shop/value/games" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garage"></see>
    /// </summary>
    let Garage = Namespaced_IRI.parse _namespace_name "Garage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garage/key/amenity/value/garage"></see>
    /// </summary>
    let ``Garage/key/amenity/value/garage`` =
        Namespaced_IRI.parse _namespace_name "Garage/key/amenity/value/garage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GarageShop"></see>
    /// </summary>
    let GarageShop = Namespaced_IRI.parse _namespace_name "GarageShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GarageShop/key/shop/value/garage"></see>
    /// </summary>
    let ``GarageShop/key/shop/value/garage`` =
        Namespaced_IRI.parse _namespace_name "GarageShop/key/shop/value/garage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garages"></see>
    /// </summary>
    let Garages = Namespaced_IRI.parse _namespace_name "Garages" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garages/key/landuse/value/garages"></see>
    /// </summary>
    let ``Garages/key/landuse/value/garages`` =
        Namespaced_IRI.parse _namespace_name "Garages/key/landuse/value/garages" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garbage"></see>
    /// </summary>
    let Garbage = Namespaced_IRI.parse _namespace_name "Garbage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garbage/key/amenity/value/garbage"></see>
    /// </summary>
    let ``Garbage/key/amenity/value/garbage`` =
        Namespaced_IRI.parse _namespace_name "Garbage/key/amenity/value/garbage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garden"></see>
    /// </summary>
    let Garden = Namespaced_IRI.parse _namespace_name "Garden" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garden/key/leisure/value/garden"></see>
    /// </summary>
    let ``Garden/key/leisure/value/garden`` =
        Namespaced_IRI.parse _namespace_name "Garden/key/leisure/value/garden" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenCenter"></see>
    /// </summary>
    let GardenCenter =
        Namespaced_IRI.parse _namespace_name "GardenCenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenCenter/key/shop/value/garden_center"></see>
    /// </summary>
    let ``GardenCenter/key/shop/value/garden_center`` =
        Namespaced_IRI.parse _namespace_name "GardenCenter/key/shop/value/garden_center" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenCentre"></see>
    /// </summary>
    let GardenCentre =
        Namespaced_IRI.parse _namespace_name "GardenCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenCentre/key/shop/value/garden_centre"></see>
    /// </summary>
    let ``GardenCentre/key/shop/value/garden_centre`` =
        Namespaced_IRI.parse _namespace_name "GardenCentre/key/shop/value/garden_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenShop"></see>
    /// </summary>
    let GardenShop = Namespaced_IRI.parse _namespace_name "GardenShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenShop/key/shop/value/garden"></see>
    /// </summary>
    let ``GardenShop/key/shop/value/garden`` =
        Namespaced_IRI.parse _namespace_name "GardenShop/key/shop/value/garden" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gardener"></see>
    /// </summary>
    let Gardener = Namespaced_IRI.parse _namespace_name "Gardener" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gardener/key/craft/value/gardener"></see>
    /// </summary>
    let ``Gardener/key/craft/value/gardener`` =
        Namespaced_IRI.parse _namespace_name "Gardener/key/craft/value/gardener" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gasometer"></see>
    /// </summary>
    let Gasometer = Namespaced_IRI.parse _namespace_name "Gasometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gasometer/key/man_made/value/gasometer"></see>
    /// </summary>
    let ``Gasometer/key/man_made/value/gasometer`` =
        Namespaced_IRI.parse _namespace_name "Gasometer/key/man_made/value/gasometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gate"></see>
    /// </summary>
    let Gate = Namespaced_IRI.parse _namespace_name "Gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gate/key/barrier/value/gate"></see>
    /// </summary>
    let ``Gate/key/barrier/value/gate`` =
        Namespaced_IRI.parse _namespace_name "Gate/key/barrier/value/gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gazometer"></see>
    /// </summary>
    let Gazometer = Namespaced_IRI.parse _namespace_name "Gazometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gazometer/key/man_made/value/gazometer"></see>
    /// </summary>
    let ``Gazometer/key/man_made/value/gazometer`` =
        Namespaced_IRI.parse _namespace_name "Gazometer/key/man_made/value/gazometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/General"></see>
    /// </summary>
    let General = Namespaced_IRI.parse _namespace_name "General" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/General/key/shop/value/general"></see>
    /// </summary>
    let ``General/key/shop/value/general`` =
        Namespaced_IRI.parse _namespace_name "General/key/shop/value/general" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Geyser"></see>
    /// </summary>
    let Geyser = Namespaced_IRI.parse _namespace_name "Geyser" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Geyser/key/natural/value/geyser"></see>
    /// </summary>
    let ``Geyser/key/natural/value/geyser`` =
        Namespaced_IRI.parse _namespace_name "Geyser/key/natural/value/geyser" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gift"></see>
    /// </summary>
    let Gift = Namespaced_IRI.parse _namespace_name "Gift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gift/key/shop/value/gift"></see>
    /// </summary>
    let ``Gift/key/shop/value/gift`` =
        Namespaced_IRI.parse _namespace_name "Gift/key/shop/value/gift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gifts"></see>
    /// </summary>
    let Gifts = Namespaced_IRI.parse _namespace_name "Gifts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gifts/key/shop/value/gifts"></see>
    /// </summary>
    let ``Gifts/key/shop/value/gifts`` =
        Namespaced_IRI.parse _namespace_name "Gifts/key/shop/value/gifts" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GiveWaySign"></see>
    /// </summary>
    let GiveWaySign =
        Namespaced_IRI.parse _namespace_name "GiveWaySign" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GiveWaySign/key/highway/value/give_way"></see>
    /// </summary>
    let ``GiveWaySign/key/highway/value/give_way`` =
        Namespaced_IRI.parse _namespace_name "GiveWaySign/key/highway/value/give_way" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glacier"></see>
    /// </summary>
    let Glacier = Namespaced_IRI.parse _namespace_name "Glacier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glacier/key/natural/value/glacier"></see>
    /// </summary>
    let ``Glacier/key/natural/value/glacier`` =
        Namespaced_IRI.parse _namespace_name "Glacier/key/natural/value/glacier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glass"></see>
    /// </summary>
    let Glass = Namespaced_IRI.parse _namespace_name "Glass" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glass/key/shop/value/glass"></see>
    /// </summary>
    let ``Glass/key/shop/value/glass`` =
        Namespaced_IRI.parse _namespace_name "Glass/key/shop/value/glass" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glaziery"></see>
    /// </summary>
    let Glaziery = Namespaced_IRI.parse _namespace_name "Glaziery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glaziery/key/shop/value/glaziery"></see>
    /// </summary>
    let ``Glaziery/key/shop/value/glaziery`` =
        Namespaced_IRI.parse _namespace_name "Glaziery/key/shop/value/glaziery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glaziery/key/craft/value/glaziery"></see>
    /// </summary>
    let ``Glaziery/key/craft/value/glaziery`` =
        Namespaced_IRI.parse _namespace_name "Glaziery/key/craft/value/glaziery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Goldsmith"></see>
    /// </summary>
    let Goldsmith = Namespaced_IRI.parse _namespace_name "Goldsmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Goldsmith/key/shop/value/goldsmith"></see>
    /// </summary>
    let ``Goldsmith/key/shop/value/goldsmith`` =
        Namespaced_IRI.parse _namespace_name "Goldsmith/key/shop/value/goldsmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GolfCourse"></see>
    /// </summary>
    let GolfCourse = Namespaced_IRI.parse _namespace_name "GolfCourse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GolfCourse/key/leisure/value/golf_course"></see>
    /// </summary>
    let ``GolfCourse/key/leisure/value/golf_course`` =
        Namespaced_IRI.parse _namespace_name "GolfCourse/key/leisure/value/golf_course" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gondola"></see>
    /// </summary>
    let Gondola = Namespaced_IRI.parse _namespace_name "Gondola" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gondola/key/aerialway/value/gondola"></see>
    /// </summary>
    let ``Gondola/key/aerialway/value/gondola`` =
        Namespaced_IRI.parse _namespace_name "Gondola/key/aerialway/value/gondola" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GovermentBuilding"></see>
    /// </summary>
    let GovermentBuilding =
        Namespaced_IRI.parse _namespace_name "GovermentBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GovermentBuilding/key/amenity/value/goverment_building"></see>
    /// </summary>
    let ``GovermentBuilding/key/amenity/value/goverment_building`` =
        Namespaced_IRI.parse _namespace_name "GovermentBuilding/key/amenity/value/goverment_building" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GovernmentOffice"></see>
    /// </summary>
    let GovernmentOffice =
        Namespaced_IRI.parse _namespace_name "GovernmentOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GovernmentOffice/key/office/value/government"></see>
    /// </summary>
    let ``GovernmentOffice/key/office/value/government`` =
        Namespaced_IRI.parse _namespace_name "GovernmentOffice/key/office/value/government" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Granattrichter"></see>
    /// </summary>
    let Granattrichter =
        Namespaced_IRI.parse _namespace_name "Granattrichter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Granattrichter/key/historic/value/Granattrichter"></see>
    /// </summary>
    let ``Granattrichter/key/historic/value/Granattrichter`` =
        Namespaced_IRI.parse _namespace_name "Granattrichter/key/historic/value/Granattrichter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GrassLanduse"></see>
    /// </summary>
    let GrassLanduse =
        Namespaced_IRI.parse _namespace_name "GrassLanduse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GrassLanduse/key/landuse/value/grass"></see>
    /// </summary>
    let ``GrassLanduse/key/landuse/value/grass`` =
        Namespaced_IRI.parse _namespace_name "GrassLanduse/key/landuse/value/grass" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grassland"></see>
    /// </summary>
    let Grassland = Namespaced_IRI.parse _namespace_name "Grassland" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grassland/key/natural/value/grassland"></see>
    /// </summary>
    let ``Grassland/key/natural/value/grassland`` =
        Namespaced_IRI.parse _namespace_name "Grassland/key/natural/value/grassland" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grave"></see>
    /// </summary>
    let Grave = Namespaced_IRI.parse _namespace_name "Grave" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grave/key/amenity/value/grave"></see>
    /// </summary>
    let ``Grave/key/amenity/value/grave`` =
        Namespaced_IRI.parse _namespace_name "Grave/key/amenity/value/grave" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GraveYard"></see>
    /// </summary>
    let GraveYard = Namespaced_IRI.parse _namespace_name "GraveYard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GraveYard/key/amenity/value/grave_yard"></see>
    /// </summary>
    let ``GraveYard/key/amenity/value/grave_yard`` =
        Namespaced_IRI.parse _namespace_name "GraveYard/key/amenity/value/grave_yard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Greenfield"></see>
    /// </summary>
    let Greenfield = Namespaced_IRI.parse _namespace_name "Greenfield" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Greenfield/key/landuse/value/greenfield"></see>
    /// </summary>
    let ``Greenfield/key/landuse/value/greenfield`` =
        Namespaced_IRI.parse _namespace_name "Greenfield/key/landuse/value/greenfield" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Greengrocer"></see>
    /// </summary>
    let Greengrocer =
        Namespaced_IRI.parse _namespace_name "Greengrocer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Greengrocer/key/shop/value/greengrocer"></see>
    /// </summary>
    let ``Greengrocer/key/shop/value/greengrocer`` =
        Namespaced_IRI.parse _namespace_name "Greengrocer/key/shop/value/greengrocer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GreenhouseHorticulture"></see>
    /// </summary>
    let GreenhouseHorticulture =
        Namespaced_IRI.parse _namespace_name "GreenhouseHorticulture" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GreenhouseHorticulture/key/landuse/value/greenhouse_horticulture"></see>
    /// </summary>
    let ``GreenhouseHorticulture/key/landuse/value/greenhouse_horticulture`` =
        Namespaced_IRI.parse _namespace_name "GreenhouseHorticulture/key/landuse/value/greenhouse_horticulture" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GritBin"></see>
    /// </summary>
    let GritBin = Namespaced_IRI.parse _namespace_name "GritBin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GritBin/key/amenity/value/grit_bin"></see>
    /// </summary>
    let ``GritBin/key/amenity/value/grit_bin`` =
        Namespaced_IRI.parse _namespace_name "GritBin/key/amenity/value/grit_bin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Groceries"></see>
    /// </summary>
    let Groceries = Namespaced_IRI.parse _namespace_name "Groceries" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Groceries/key/shop/value/groceries"></see>
    /// </summary>
    let ``Groceries/key/shop/value/groceries`` =
        Namespaced_IRI.parse _namespace_name "Groceries/key/shop/value/groceries" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grocery"></see>
    /// </summary>
    let Grocery = Namespaced_IRI.parse _namespace_name "Grocery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grocery/key/shop/value/grocery"></see>
    /// </summary>
    let ``Grocery/key/shop/value/grocery`` =
        Namespaced_IRI.parse _namespace_name "Grocery/key/shop/value/grocery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GrouseButt"></see>
    /// </summary>
    let GrouseButt = Namespaced_IRI.parse _namespace_name "GrouseButt" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GrouseButt/key/man_made/value/grouse_butt"></see>
    /// </summary>
    let ``GrouseButt/key/man_made/value/grouse_butt`` =
        Namespaced_IRI.parse _namespace_name "GrouseButt/key/man_made/value/grouse_butt" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Groyne"></see>
    /// </summary>
    let Groyne = Namespaced_IRI.parse _namespace_name "Groyne" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Groyne/key/man_made/value/groyne"></see>
    /// </summary>
    let ``Groyne/key/man_made/value/groyne`` =
        Namespaced_IRI.parse _namespace_name "Groyne/key/man_made/value/groyne" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GuestHouse"></see>
    /// </summary>
    let GuestHouse = Namespaced_IRI.parse _namespace_name "GuestHouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GuestHouse/key/tourism/value/guest_house"></see>
    /// </summary>
    let ``GuestHouse/key/tourism/value/guest_house`` =
        Namespaced_IRI.parse _namespace_name "GuestHouse/key/tourism/value/guest_house" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Guidepost"></see>
    /// </summary>
    let Guidepost = Namespaced_IRI.parse _namespace_name "Guidepost" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Guidepost/key/amenity/value/guidepost"></see>
    /// </summary>
    let ``Guidepost/key/amenity/value/guidepost`` =
        Namespaced_IRI.parse _namespace_name "Guidepost/key/amenity/value/guidepost" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gym"></see>
    /// </summary>
    let Gym = Namespaced_IRI.parse _namespace_name "Gym" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gym/key/amenity/value/gym"></see>
    /// </summary>
    let ``Gym/key/amenity/value/gym`` =
        Namespaced_IRI.parse _namespace_name "Gym/key/amenity/value/gym" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gym/key/leisure/value/gym"></see>
    /// </summary>
    let ``Gym/key/leisure/value/gym`` =
        Namespaced_IRI.parse _namespace_name "Gym/key/leisure/value/gym" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GymShop"></see>
    /// </summary>
    let GymShop = Namespaced_IRI.parse _namespace_name "GymShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GymShop/key/shop/value/gym"></see>
    /// </summary>
    let ``GymShop/key/shop/value/gym`` =
        Namespaced_IRI.parse _namespace_name "GymShop/key/shop/value/gym" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Haberdashery"></see>
    /// </summary>
    let Haberdashery =
        Namespaced_IRI.parse _namespace_name "Haberdashery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Haberdashery/key/shop/value/haberdashery"></see>
    /// </summary>
    let ``Haberdashery/key/shop/value/haberdashery`` =
        Namespaced_IRI.parse _namespace_name "Haberdashery/key/shop/value/haberdashery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hackerspace"></see>
    /// </summary>
    let Hackerspace =
        Namespaced_IRI.parse _namespace_name "Hackerspace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hackerspace/key/leisure/value/hackerspace"></see>
    /// </summary>
    let ``Hackerspace/key/leisure/value/hackerspace`` =
        Namespaced_IRI.parse _namespace_name "Hackerspace/key/leisure/value/hackerspace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hairdresser"></see>
    /// </summary>
    let Hairdresser =
        Namespaced_IRI.parse _namespace_name "Hairdresser" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hairdresser/key/amenity/value/hairdresser"></see>
    /// </summary>
    let ``Hairdresser/key/amenity/value/hairdresser`` =
        Namespaced_IRI.parse _namespace_name "Hairdresser/key/amenity/value/hairdresser" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HairdresserShop"></see>
    /// </summary>
    let HairdresserShop =
        Namespaced_IRI.parse _namespace_name "HairdresserShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HairdresserShop/key/shop/value/hairdresser"></see>
    /// </summary>
    let ``HairdresserShop/key/shop/value/hairdresser`` =
        Namespaced_IRI.parse _namespace_name "HairdresserShop/key/shop/value/hairdresser" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hall"></see>
    /// </summary>
    let Hall = Namespaced_IRI.parse _namespace_name "Hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hall/key/amenity/value/hall"></see>
    /// </summary>
    let ``Hall/key/amenity/value/hall`` =
        Namespaced_IRI.parse _namespace_name "Hall/key/amenity/value/hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hamlet"></see>
    /// </summary>
    let Hamlet = Namespaced_IRI.parse _namespace_name "Hamlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hamlet/key/place/value/hamlet"></see>
    /// </summary>
    let ``Hamlet/key/place/value/hamlet`` =
        Namespaced_IRI.parse _namespace_name "Hamlet/key/place/value/hamlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hanami"></see>
    /// </summary>
    let Hanami = Namespaced_IRI.parse _namespace_name "Hanami" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hanami/key/tourism/value/hanami"></see>
    /// </summary>
    let ``Hanami/key/tourism/value/hanami`` =
        Namespaced_IRI.parse _namespace_name "Hanami/key/tourism/value/hanami" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Handicraft"></see>
    /// </summary>
    let Handicraft = Namespaced_IRI.parse _namespace_name "Handicraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Handicraft/key/craft/value/handicraft"></see>
    /// </summary>
    let ``Handicraft/key/craft/value/handicraft`` =
        Namespaced_IRI.parse _namespace_name "Handicraft/key/craft/value/handicraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Harbour"></see>
    /// </summary>
    let Harbour = Namespaced_IRI.parse _namespace_name "Harbour" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Harbour/key/waterway/value/harbour"></see>
    /// </summary>
    let ``Harbour/key/waterway/value/harbour`` =
        Namespaced_IRI.parse _namespace_name "Harbour/key/waterway/value/harbour" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hardware"></see>
    /// </summary>
    let Hardware = Namespaced_IRI.parse _namespace_name "Hardware" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hardware/key/shop/value/hardware"></see>
    /// </summary>
    let ``Hardware/key/shop/value/hardware`` =
        Namespaced_IRI.parse _namespace_name "Hardware/key/shop/value/hardware" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Headland"></see>
    /// </summary>
    let Headland = Namespaced_IRI.parse _namespace_name "Headland" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Headland/key/natural/value/headland"></see>
    /// </summary>
    let ``Headland/key/natural/value/headland`` =
        Namespaced_IRI.parse _namespace_name "Headland/key/natural/value/headland" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Health"></see>
    /// </summary>
    let Health = Namespaced_IRI.parse _namespace_name "Health" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Health/key/shop/value/health"></see>
    /// </summary>
    let ``Health/key/shop/value/health`` =
        Namespaced_IRI.parse _namespace_name "Health/key/shop/value/health" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthAndBeauty"></see>
    /// </summary>
    let HealthAndBeauty =
        Namespaced_IRI.parse _namespace_name "HealthAndBeauty" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthAndBeauty/key/shop/value/health_and_beauty"></see>
    /// </summary>
    let ``HealthAndBeauty/key/shop/value/health_and_beauty`` =
        Namespaced_IRI.parse _namespace_name "HealthAndBeauty/key/shop/value/health_and_beauty" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthCentre"></see>
    /// </summary>
    let HealthCentre =
        Namespaced_IRI.parse _namespace_name "HealthCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthCentre/key/amenity/value/health_centre"></see>
    /// </summary>
    let ``HealthCentre/key/amenity/value/health_centre`` =
        Namespaced_IRI.parse _namespace_name "HealthCentre/key/amenity/value/health_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthFood"></see>
    /// </summary>
    let HealthFood = Namespaced_IRI.parse _namespace_name "HealthFood" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthFood/key/shop/value/health_food"></see>
    /// </summary>
    let ``HealthFood/key/shop/value/health_food`` =
        Namespaced_IRI.parse _namespace_name "HealthFood/key/shop/value/health_food" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HearingAid"></see>
    /// </summary>
    let HearingAid = Namespaced_IRI.parse _namespace_name "HearingAid" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HearingAid/key/shop/value/hearing_aid"></see>
    /// </summary>
    let ``HearingAid/key/shop/value/hearing_aid`` =
        Namespaced_IRI.parse _namespace_name "HearingAid/key/shop/value/hearing_aid" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HearingAids"></see>
    /// </summary>
    let HearingAids =
        Namespaced_IRI.parse _namespace_name "HearingAids" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HearingAids/key/shop/value/hearing_aids"></see>
    /// </summary>
    let ``HearingAids/key/shop/value/hearing_aids`` =
        Namespaced_IRI.parse _namespace_name "HearingAids/key/shop/value/hearing_aids" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heath"></see>
    /// </summary>
    let Heath = Namespaced_IRI.parse _namespace_name "Heath" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heath/key/natural/value/heath"></see>
    /// </summary>
    let ``Heath/key/natural/value/heath`` =
        Namespaced_IRI.parse _namespace_name "Heath/key/natural/value/heath" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hedge"></see>
    /// </summary>
    let Hedge = Namespaced_IRI.parse _namespace_name "Hedge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hedge/key/barrier/value/hedge"></see>
    /// </summary>
    let ``Hedge/key/barrier/value/hedge`` =
        Namespaced_IRI.parse _namespace_name "Hedge/key/barrier/value/hedge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Helipad"></see>
    /// </summary>
    let Helipad = Namespaced_IRI.parse _namespace_name "Helipad" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Helipad/key/aeroway/value/helipad"></see>
    /// </summary>
    let ``Helipad/key/aeroway/value/helipad`` =
        Namespaced_IRI.parse _namespace_name "Helipad/key/aeroway/value/helipad" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heliport"></see>
    /// </summary>
    let Heliport = Namespaced_IRI.parse _namespace_name "Heliport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heliport/key/aeroway/value/heliport"></see>
    /// </summary>
    let ``Heliport/key/aeroway/value/heliport`` =
        Namespaced_IRI.parse _namespace_name "Heliport/key/aeroway/value/heliport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heritage"></see>
    /// </summary>
    let Heritage = Namespaced_IRI.parse _namespace_name "Heritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heritage/key/historic/value/heritage"></see>
    /// </summary>
    let ``Heritage/key/historic/value/heritage`` =
        Namespaced_IRI.parse _namespace_name "Heritage/key/historic/value/heritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heuriger"></see>
    /// </summary>
    let Heuriger = Namespaced_IRI.parse _namespace_name "Heuriger" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heuriger/key/amenity/value/heuriger"></see>
    /// </summary>
    let ``Heuriger/key/amenity/value/heuriger`` =
        Namespaced_IRI.parse _namespace_name "Heuriger/key/amenity/value/heuriger" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hide"></see>
    /// </summary>
    let Hide = Namespaced_IRI.parse _namespace_name "Hide" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hide/key/amenity/value/hide"></see>
    /// </summary>
    let ``Hide/key/amenity/value/hide`` =
        Namespaced_IRI.parse _namespace_name "Hide/key/amenity/value/hide" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hifi"></see>
    /// </summary>
    let Hifi = Namespaced_IRI.parse _namespace_name "Hifi" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hifi/key/shop/value/hifi"></see>
    /// </summary>
    let ``Hifi/key/shop/value/hifi`` =
        Namespaced_IRI.parse _namespace_name "Hifi/key/shop/value/hifi" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayConstruction"></see>
    /// </summary>
    let HighwayConstruction =
        Namespaced_IRI.parse _namespace_name "HighwayConstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayConstruction/key/highway/value/construction"></see>
    /// </summary>
    let ``HighwayConstruction/key/highway/value/construction`` =
        Namespaced_IRI.parse _namespace_name "HighwayConstruction/key/highway/value/construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayCrossing"></see>
    /// </summary>
    let HighwayCrossing =
        Namespaced_IRI.parse _namespace_name "HighwayCrossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayCrossing/key/highway/value/crossing"></see>
    /// </summary>
    let ``HighwayCrossing/key/highway/value/crossing`` =
        Namespaced_IRI.parse _namespace_name "HighwayCrossing/key/highway/value/crossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayFord"></see>
    /// </summary>
    let HighwayFord =
        Namespaced_IRI.parse _namespace_name "HighwayFord" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayFord/key/highway/value/ford"></see>
    /// </summary>
    let ``HighwayFord/key/highway/value/ford`` =
        Namespaced_IRI.parse _namespace_name "HighwayFord/key/highway/value/ford" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayPrimaryLink"></see>
    /// </summary>
    let HighwayPrimaryLink =
        Namespaced_IRI.parse _namespace_name "HighwayPrimaryLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayPrimaryLink/key/highway/value/primary_link"></see>
    /// </summary>
    let ``HighwayPrimaryLink/key/highway/value/primary_link`` =
        Namespaced_IRI.parse _namespace_name "HighwayPrimaryLink/key/highway/value/primary_link" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwaySecundaryLink"></see>
    /// </summary>
    let HighwaySecundaryLink =
        Namespaced_IRI.parse _namespace_name "HighwaySecundaryLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwaySecundaryLink/key/highway/value/secundary_link"></see>
    /// </summary>
    let ``HighwaySecundaryLink/key/highway/value/secundary_link`` =
        Namespaced_IRI.parse _namespace_name "HighwaySecundaryLink/key/highway/value/secundary_link" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayService"></see>
    /// </summary>
    let HighwayService =
        Namespaced_IRI.parse _namespace_name "HighwayService" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayService/key/highway/value/service"></see>
    /// </summary>
    let ``HighwayService/key/highway/value/service`` =
        Namespaced_IRI.parse _namespace_name "HighwayService/key/highway/value/service" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayTertiaryLink"></see>
    /// </summary>
    let HighwayTertiaryLink =
        Namespaced_IRI.parse _namespace_name "HighwayTertiaryLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayTertiaryLink/key/highway/value/tertiary_link"></see>
    /// </summary>
    let ``HighwayTertiaryLink/key/highway/value/tertiary_link`` =
        Namespaced_IRI.parse _namespace_name "HighwayTertiaryLink/key/highway/value/tertiary_link" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HikingRoute"></see>
    /// </summary>
    let HikingRoute =
        Namespaced_IRI.parse _namespace_name "HikingRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HikingRoute/key/route/value/hiking"></see>
    /// </summary>
    let ``HikingRoute/key/route/value/hiking`` =
        Namespaced_IRI.parse _namespace_name "HikingRoute/key/route/value/hiking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hill"></see>
    /// </summary>
    let Hill = Namespaced_IRI.parse _namespace_name "Hill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hill/key/natural/value/hill"></see>
    /// </summary>
    let ``Hill/key/natural/value/hill`` =
        Namespaced_IRI.parse _namespace_name "Hill/key/natural/value/hill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricBuilding"></see>
    /// </summary>
    let HistoricBuilding =
        Namespaced_IRI.parse _namespace_name "HistoricBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricBuilding/key/historic/value/building"></see>
    /// </summary>
    let ``HistoricBuilding/key/historic/value/building`` =
        Namespaced_IRI.parse _namespace_name "HistoricBuilding/key/historic/value/building" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricChapel"></see>
    /// </summary>
    let HistoricChapel =
        Namespaced_IRI.parse _namespace_name "HistoricChapel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricChapel/key/historic/value/chapel"></see>
    /// </summary>
    let ``HistoricChapel/key/historic/value/chapel`` =
        Namespaced_IRI.parse _namespace_name "HistoricChapel/key/historic/value/chapel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricChurch"></see>
    /// </summary>
    let HistoricChurch =
        Namespaced_IRI.parse _namespace_name "HistoricChurch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricChurch/key/historic/value/church"></see>
    /// </summary>
    let ``HistoricChurch/key/historic/value/church`` =
        Namespaced_IRI.parse _namespace_name "HistoricChurch/key/historic/value/church" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricFountain"></see>
    /// </summary>
    let HistoricFountain =
        Namespaced_IRI.parse _namespace_name "HistoricFountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricFountain/key/historic/value/fountain"></see>
    /// </summary>
    let ``HistoricFountain/key/historic/value/fountain`` =
        Namespaced_IRI.parse _namespace_name "HistoricFountain/key/historic/value/fountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricHouse"></see>
    /// </summary>
    let HistoricHouse =
        Namespaced_IRI.parse _namespace_name "HistoricHouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricHouse/key/historic/value/house"></see>
    /// </summary>
    let ``HistoricHouse/key/historic/value/house`` =
        Namespaced_IRI.parse _namespace_name "HistoricHouse/key/historic/value/house" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricIndustrial"></see>
    /// </summary>
    let HistoricIndustrial =
        Namespaced_IRI.parse _namespace_name "HistoricIndustrial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricIndustrial/key/historic/value/industrial"></see>
    /// </summary>
    let ``HistoricIndustrial/key/historic/value/industrial`` =
        Namespaced_IRI.parse _namespace_name "HistoricIndustrial/key/historic/value/industrial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMarker"></see>
    /// </summary>
    let HistoricMarker =
        Namespaced_IRI.parse _namespace_name "HistoricMarker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMarker/key/historic/value/marker"></see>
    /// </summary>
    let ``HistoricMarker/key/historic/value/marker`` =
        Namespaced_IRI.parse _namespace_name "HistoricMarker/key/historic/value/marker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMilestone"></see>
    /// </summary>
    let HistoricMilestone =
        Namespaced_IRI.parse _namespace_name "HistoricMilestone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMilestone/key/historic/value/milestone"></see>
    /// </summary>
    let ``HistoricMilestone/key/historic/value/milestone`` =
        Namespaced_IRI.parse _namespace_name "HistoricMilestone/key/historic/value/milestone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMine"></see>
    /// </summary>
    let HistoricMine =
        Namespaced_IRI.parse _namespace_name "HistoricMine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMine/key/historic/value/mine"></see>
    /// </summary>
    let ``HistoricMine/key/historic/value/mine`` =
        Namespaced_IRI.parse _namespace_name "HistoricMine/key/historic/value/mine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMonastery"></see>
    /// </summary>
    let HistoricMonastery =
        Namespaced_IRI.parse _namespace_name "HistoricMonastery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMonastery/key/historic/value/monastery"></see>
    /// </summary>
    let ``HistoricMonastery/key/historic/value/monastery`` =
        Namespaced_IRI.parse _namespace_name "HistoricMonastery/key/historic/value/monastery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMuseum"></see>
    /// </summary>
    let HistoricMuseum =
        Namespaced_IRI.parse _namespace_name "HistoricMuseum" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMuseum/key/historic/value/museum"></see>
    /// </summary>
    let ``HistoricMuseum/key/historic/value/museum`` =
        Namespaced_IRI.parse _namespace_name "HistoricMuseum/key/historic/value/museum" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricPointOfInterest"></see>
    /// </summary>
    let HistoricPointOfInterest =
        Namespaced_IRI.parse _namespace_name "HistoricPointOfInterest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricPointOfInterest/key/historic/value/yes"></see>
    /// </summary>
    let ``HistoricPointOfInterest/key/historic/value/yes`` =
        Namespaced_IRI.parse _namespace_name "HistoricPointOfInterest/key/historic/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricStation"></see>
    /// </summary>
    let HistoricStation =
        Namespaced_IRI.parse _namespace_name "HistoricStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricStation/key/railway/value/historic_station"></see>
    /// </summary>
    let ``HistoricStation/key/railway/value/historic_station`` =
        Namespaced_IRI.parse _namespace_name "HistoricStation/key/railway/value/historic_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricStatue"></see>
    /// </summary>
    let HistoricStatue =
        Namespaced_IRI.parse _namespace_name "HistoricStatue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricStatue/key/historic/value/statue"></see>
    /// </summary>
    let ``HistoricStatue/key/historic/value/statue`` =
        Namespaced_IRI.parse _namespace_name "HistoricStatue/key/historic/value/statue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricTower"></see>
    /// </summary>
    let HistoricTower =
        Namespaced_IRI.parse _namespace_name "HistoricTower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricTower/key/historic/value/tower"></see>
    /// </summary>
    let ``HistoricTower/key/historic/value/tower`` =
        Namespaced_IRI.parse _namespace_name "HistoricTower/key/historic/value/tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricWell"></see>
    /// </summary>
    let HistoricWell =
        Namespaced_IRI.parse _namespace_name "HistoricWell" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricWell/key/historic/value/well"></see>
    /// </summary>
    let ``HistoricWell/key/historic/value/well`` =
        Namespaced_IRI.parse _namespace_name "HistoricWell/key/historic/value/well" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hobby"></see>
    /// </summary>
    let Hobby = Namespaced_IRI.parse _namespace_name "Hobby" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hobby/key/shop/value/hobby"></see>
    /// </summary>
    let ``Hobby/key/shop/value/hobby`` =
        Namespaced_IRI.parse _namespace_name "Hobby/key/shop/value/hobby" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HoldingPoint"></see>
    /// </summary>
    let HoldingPoint =
        Namespaced_IRI.parse _namespace_name "HoldingPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HoldingPoint/key/aeroway/value/holding_point"></see>
    /// </summary>
    let ``HoldingPoint/key/aeroway/value/holding_point`` =
        Namespaced_IRI.parse _namespace_name "HoldingPoint/key/aeroway/value/holding_point" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hole"></see>
    /// </summary>
    let Hole = Namespaced_IRI.parse _namespace_name "Hole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hole/key/leisure/value/hole"></see>
    /// </summary>
    let ``Hole/key/leisure/value/hole`` =
        Namespaced_IRI.parse _namespace_name "Hole/key/leisure/value/hole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Home"></see>
    /// </summary>
    let Home = Namespaced_IRI.parse _namespace_name "Home" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Home/key/shop/value/home"></see>
    /// </summary>
    let ``Home/key/shop/value/home`` =
        Namespaced_IRI.parse _namespace_name "Home/key/shop/value/home" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HomeImprovement"></see>
    /// </summary>
    let HomeImprovement =
        Namespaced_IRI.parse _namespace_name "HomeImprovement" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HomeImprovement/key/shop/value/home_improvement"></see>
    /// </summary>
    let ``HomeImprovement/key/shop/value/home_improvement`` =
        Namespaced_IRI.parse _namespace_name "HomeImprovement/key/shop/value/home_improvement" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HorseRiding"></see>
    /// </summary>
    let HorseRiding =
        Namespaced_IRI.parse _namespace_name "HorseRiding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HorseRiding/key/leisure/value/horse_riding"></see>
    /// </summary>
    let ``HorseRiding/key/leisure/value/horse_riding`` =
        Namespaced_IRI.parse _namespace_name "HorseRiding/key/leisure/value/horse_riding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HorseStile"></see>
    /// </summary>
    let HorseStile = Namespaced_IRI.parse _namespace_name "HorseStile" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HorseStile/key/barrier/value/horse_stile"></see>
    /// </summary>
    let ``HorseStile/key/barrier/value/horse_stile`` =
        Namespaced_IRI.parse _namespace_name "HorseStile/key/barrier/value/horse_stile" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hospice"></see>
    /// </summary>
    let Hospice = Namespaced_IRI.parse _namespace_name "Hospice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hospice/key/amenity/value/hospice"></see>
    /// </summary>
    let ``Hospice/key/amenity/value/hospice`` =
        Namespaced_IRI.parse _namespace_name "Hospice/key/amenity/value/hospice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hospital"></see>
    /// </summary>
    let Hospital = Namespaced_IRI.parse _namespace_name "Hospital" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hospital/key/amenity/value/hospital"></see>
    /// </summary>
    let ``Hospital/key/amenity/value/hospital`` =
        Namespaced_IRI.parse _namespace_name "Hospital/key/amenity/value/hospital" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hostel"></see>
    /// </summary>
    let Hostel = Namespaced_IRI.parse _namespace_name "Hostel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hostel/key/tourism/value/hostel"></see>
    /// </summary>
    let ``Hostel/key/tourism/value/hostel`` =
        Namespaced_IRI.parse _namespace_name "Hostel/key/tourism/value/hostel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HotSpring"></see>
    /// </summary>
    let HotSpring = Namespaced_IRI.parse _namespace_name "HotSpring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HotSpring/key/leisure/value/hot_spring"></see>
    /// </summary>
    let ``HotSpring/key/leisure/value/hot_spring`` =
        Namespaced_IRI.parse _namespace_name "HotSpring/key/leisure/value/hot_spring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hotel"></see>
    /// </summary>
    let Hotel = Namespaced_IRI.parse _namespace_name "Hotel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hotel/key/amenity/value/hotel"></see>
    /// </summary>
    let ``Hotel/key/amenity/value/hotel`` =
        Namespaced_IRI.parse _namespace_name "Hotel/key/amenity/value/hotel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hotel/key/tourism/value/hotel"></see>
    /// </summary>
    let ``Hotel/key/tourism/value/hotel`` =
        Namespaced_IRI.parse _namespace_name "Hotel/key/tourism/value/hotel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HouseConnectionBox"></see>
    /// </summary>
    let HouseConnectionBox =
        Namespaced_IRI.parse _namespace_name "HouseConnectionBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HouseConnectionBox/key/power/value/house_connection_box"></see>
    /// </summary>
    let ``HouseConnectionBox/key/power/value/house_connection_box`` =
        Namespaced_IRI.parse _namespace_name "HouseConnectionBox/key/power/value/house_connection_box" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Household"></see>
    /// </summary>
    let Household = Namespaced_IRI.parse _namespace_name "Household" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Household/key/shop/value/household"></see>
    /// </summary>
    let ``Household/key/shop/value/household`` =
        Namespaced_IRI.parse _namespace_name "Household/key/shop/value/household" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Housewares"></see>
    /// </summary>
    let Housewares = Namespaced_IRI.parse _namespace_name "Housewares" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Housewares/key/shop/value/housewares"></see>
    /// </summary>
    let ``Housewares/key/shop/value/housewares`` =
        Namespaced_IRI.parse _namespace_name "Housewares/key/shop/value/housewares" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hump"></see>
    /// </summary>
    let Hump = Namespaced_IRI.parse _namespace_name "Hump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hump/key/traffic_calming/value/hump"></see>
    /// </summary>
    let ``Hump/key/traffic_calming/value/hump`` =
        Namespaced_IRI.parse _namespace_name "Hump/key/traffic_calming/value/hump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HuntingBlind"></see>
    /// </summary>
    let HuntingBlind =
        Namespaced_IRI.parse _namespace_name "HuntingBlind" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HuntingBlind/key/amenity/value/hunting_blind"></see>
    /// </summary>
    let ``HuntingBlind/key/amenity/value/hunting_blind`` =
        Namespaced_IRI.parse _namespace_name "HuntingBlind/key/amenity/value/hunting_blind" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HuntingStand"></see>
    /// </summary>
    let HuntingStand =
        Namespaced_IRI.parse _namespace_name "HuntingStand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HuntingStand/key/amenity/value/hunting_stand"></see>
    /// </summary>
    let ``HuntingStand/key/amenity/value/hunting_stand`` =
        Namespaced_IRI.parse _namespace_name "HuntingStand/key/amenity/value/hunting_stand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hut"></see>
    /// </summary>
    let Hut = Namespaced_IRI.parse _namespace_name "Hut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hut/key/amenity/value/hut"></see>
    /// </summary>
    let ``Hut/key/amenity/value/hut`` =
        Namespaced_IRI.parse _namespace_name "Hut/key/amenity/value/hut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hvac"></see>
    /// </summary>
    let Hvac = Namespaced_IRI.parse _namespace_name "Hvac" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hvac/key/craft/value/hvac"></see>
    /// </summary>
    let ``Hvac/key/craft/value/hvac`` =
        Namespaced_IRI.parse _namespace_name "Hvac/key/craft/value/hvac" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hydrant"></see>
    /// </summary>
    let Hydrant = Namespaced_IRI.parse _namespace_name "Hydrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hydrant/key/amenity/value/hydrant"></see>
    /// </summary>
    let ``Hydrant/key/amenity/value/hydrant`` =
        Namespaced_IRI.parse _namespace_name "Hydrant/key/amenity/value/hydrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceCream"></see>
    /// </summary>
    let IceCream = Namespaced_IRI.parse _namespace_name "IceCream" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceCream/key/amenity/value/ice_cream"></see>
    /// </summary>
    let ``IceCream/key/amenity/value/ice_cream`` =
        Namespaced_IRI.parse _namespace_name "IceCream/key/amenity/value/ice_cream" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceCreamShop"></see>
    /// </summary>
    let IceCreamShop =
        Namespaced_IRI.parse _namespace_name "IceCreamShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceCreamShop/key/shop/value/ice_cream"></see>
    /// </summary>
    let ``IceCreamShop/key/shop/value/ice_cream`` =
        Namespaced_IRI.parse _namespace_name "IceCreamShop/key/shop/value/ice_cream" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceRink"></see>
    /// </summary>
    let IceRink = Namespaced_IRI.parse _namespace_name "IceRink" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceRink/key/leisure/value/ice_rink"></see>
    /// </summary>
    let ``IceRink/key/leisure/value/ice_rink`` =
        Namespaced_IRI.parse _namespace_name "IceRink/key/leisure/value/ice_rink" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceRoad"></see>
    /// </summary>
    let IceRoad = Namespaced_IRI.parse _namespace_name "IceRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceRoad/key/ice_road/value/yes"></see>
    /// </summary>
    let ``IceRoad/key/ice_road/value/yes`` =
        Namespaced_IRI.parse _namespace_name "IceRoad/key/ice_road/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Icon"></see>
    /// </summary>
    let Icon = Namespaced_IRI.parse _namespace_name "Icon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Icon/key/historic/value/icon"></see>
    /// </summary>
    let ``Icon/key/historic/value/icon`` =
        Namespaced_IRI.parse _namespace_name "Icon/key/historic/value/icon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IndustrialLanduse"></see>
    /// </summary>
    let IndustrialLanduse =
        Namespaced_IRI.parse _namespace_name "IndustrialLanduse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IndustrialLanduse/key/landuse/value/industrial"></see>
    /// </summary>
    let ``IndustrialLanduse/key/landuse/value/industrial`` =
        Namespaced_IRI.parse _namespace_name "IndustrialLanduse/key/landuse/value/industrial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IndustrialProductionBuilding"></see>
    /// </summary>
    let IndustrialProductionBuilding =
        Namespaced_IRI.parse _namespace_name "IndustrialProductionBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IndustrialProductionBuilding/key/man_made/value/works"></see>
    /// </summary>
    let ``IndustrialProductionBuilding/key/man_made/value/works`` =
        Namespaced_IRI.parse _namespace_name "IndustrialProductionBuilding/key/man_made/value/works" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Information"></see>
    /// </summary>
    let Information =
        Namespaced_IRI.parse _namespace_name "Information" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Information/key/amenity/value/information"></see>
    /// </summary>
    let ``Information/key/amenity/value/information`` =
        Namespaced_IRI.parse _namespace_name "Information/key/amenity/value/information" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insulation"></see>
    /// </summary>
    let Insulation = Namespaced_IRI.parse _namespace_name "Insulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insulation/key/craft/value/insulation"></see>
    /// </summary>
    let ``Insulation/key/craft/value/insulation`` =
        Namespaced_IRI.parse _namespace_name "Insulation/key/craft/value/insulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insurance"></see>
    /// </summary>
    let Insurance = Namespaced_IRI.parse _namespace_name "Insurance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insurance/key/amenity/value/insurance"></see>
    /// </summary>
    let ``Insurance/key/amenity/value/insurance`` =
        Namespaced_IRI.parse _namespace_name "Insurance/key/amenity/value/insurance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insurance/key/shop/value/insurance"></see>
    /// </summary>
    let ``Insurance/key/shop/value/insurance`` =
        Namespaced_IRI.parse _namespace_name "Insurance/key/shop/value/insurance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InsuranceOffice"></see>
    /// </summary>
    let InsuranceOffice =
        Namespaced_IRI.parse _namespace_name "InsuranceOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InsuranceOffice/key/office/value/insurance"></see>
    /// </summary>
    let ``InsuranceOffice/key/office/value/insurance`` =
        Namespaced_IRI.parse _namespace_name "InsuranceOffice/key/office/value/insurance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Interiors"></see>
    /// </summary>
    let Interiors = Namespaced_IRI.parse _namespace_name "Interiors" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Interiors/key/shop/value/interiors"></see>
    /// </summary>
    let ``Interiors/key/shop/value/interiors`` =
        Namespaced_IRI.parse _namespace_name "Interiors/key/shop/value/interiors" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Intermittent"></see>
    /// </summary>
    let Intermittent =
        Namespaced_IRI.parse _namespace_name "Intermittent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Intermittent/key/intermittent/value/yes"></see>
    /// </summary>
    let ``Intermittent/key/intermittent/value/yes`` =
        Namespaced_IRI.parse _namespace_name "Intermittent/key/intermittent/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Internet"></see>
    /// </summary>
    let Internet = Namespaced_IRI.parse _namespace_name "Internet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Internet/key/amenity/value/internet"></see>
    /// </summary>
    let ``Internet/key/amenity/value/internet`` =
        Namespaced_IRI.parse _namespace_name "Internet/key/amenity/value/internet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetAccess"></see>
    /// </summary>
    let InternetAccess =
        Namespaced_IRI.parse _namespace_name "InternetAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetAccess/key/amenity/value/internet_access"></see>
    /// </summary>
    let ``InternetAccess/key/amenity/value/internet_access`` =
        Namespaced_IRI.parse _namespace_name "InternetAccess/key/amenity/value/internet_access" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetCafe"></see>
    /// </summary>
    let InternetCafe =
        Namespaced_IRI.parse _namespace_name "InternetCafe" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetCafe/key/amenity/value/internet_cafe"></see>
    /// </summary>
    let ``InternetCafe/key/amenity/value/internet_cafe`` =
        Namespaced_IRI.parse _namespace_name "InternetCafe/key/amenity/value/internet_cafe" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetCafe/key/shop/value/internet_cafe"></see>
    /// </summary>
    let ``InternetCafe/key/shop/value/internet_cafe`` =
        Namespaced_IRI.parse _namespace_name "InternetCafe/key/shop/value/internet_cafe" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Island"></see>
    /// </summary>
    let Island = Namespaced_IRI.parse _namespace_name "Island" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Island/key/place/value/island"></see>
    /// </summary>
    let ``Island/key/place/value/island`` =
        Namespaced_IRI.parse _namespace_name "Island/key/place/value/island" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Island/key/natural/value/island"></see>
    /// </summary>
    let ``Island/key/natural/value/island`` =
        Namespaced_IRI.parse _namespace_name "Island/key/natural/value/island" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Islet"></see>
    /// </summary>
    let Islet = Namespaced_IRI.parse _namespace_name "Islet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Islet/key/place/value/islet"></see>
    /// </summary>
    let ``Islet/key/place/value/islet`` =
        Namespaced_IRI.parse _namespace_name "Islet/key/place/value/islet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IsolatedDwelling"></see>
    /// </summary>
    let IsolatedDwelling =
        Namespaced_IRI.parse _namespace_name "IsolatedDwelling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IsolatedDwelling/key/place/value/isolated_dwelling"></see>
    /// </summary>
    let ``IsolatedDwelling/key/place/value/isolated_dwelling`` =
        Namespaced_IRI.parse _namespace_name "IsolatedDwelling/key/place/value/isolated_dwelling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ItOffice"></see>
    /// </summary>
    let ItOffice = Namespaced_IRI.parse _namespace_name "ItOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ItOffice/key/office/value/it"></see>
    /// </summary>
    let ``ItOffice/key/office/value/it`` =
        Namespaced_IRI.parse _namespace_name "ItOffice/key/office/value/it" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jewelers"></see>
    /// </summary>
    let Jewelers = Namespaced_IRI.parse _namespace_name "Jewelers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jewelers/key/shop/value/jewelers"></see>
    /// </summary>
    let ``Jewelers/key/shop/value/jewelers`` =
        Namespaced_IRI.parse _namespace_name "Jewelers/key/shop/value/jewelers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jeweller"></see>
    /// </summary>
    let Jeweller = Namespaced_IRI.parse _namespace_name "Jeweller" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jeweller/key/craft/value/jeweller"></see>
    /// </summary>
    let ``Jeweller/key/craft/value/jeweller`` =
        Namespaced_IRI.parse _namespace_name "Jeweller/key/craft/value/jeweller" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jewelry"></see>
    /// </summary>
    let Jewelry = Namespaced_IRI.parse _namespace_name "Jewelry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jewelry/key/shop/value/jewelry"></see>
    /// </summary>
    let ``Jewelry/key/shop/value/jewelry`` =
        Namespaced_IRI.parse _namespace_name "Jewelry/key/shop/value/jewelry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/JobCentre"></see>
    /// </summary>
    let JobCentre = Namespaced_IRI.parse _namespace_name "JobCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/JobCentre/key/amenity/value/job_centre"></see>
    /// </summary>
    let ``JobCentre/key/amenity/value/job_centre`` =
        Namespaced_IRI.parse _namespace_name "JobCentre/key/amenity/value/job_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KentCarriageGap"></see>
    /// </summary>
    let KentCarriageGap =
        Namespaced_IRI.parse _namespace_name "KentCarriageGap" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KentCarriageGap/key/barrier/value/kent_carriage_gap"></see>
    /// </summary>
    let ``KentCarriageGap/key/barrier/value/kent_carriage_gap`` =
        Namespaced_IRI.parse _namespace_name "KentCarriageGap/key/barrier/value/kent_carriage_gap" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KeyCutter"></see>
    /// </summary>
    let KeyCutter = Namespaced_IRI.parse _namespace_name "KeyCutter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KeyCutter/key/craft/value/key_cutter"></see>
    /// </summary>
    let ``KeyCutter/key/craft/value/key_cutter`` =
        Namespaced_IRI.parse _namespace_name "KeyCutter/key/craft/value/key_cutter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Keys"></see>
    /// </summary>
    let Keys = Namespaced_IRI.parse _namespace_name "Keys" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Keys/key/shop/value/keys"></see>
    /// </summary>
    let ``Keys/key/shop/value/keys`` =
        Namespaced_IRI.parse _namespace_name "Keys/key/shop/value/keys" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kindergarten"></see>
    /// </summary>
    let Kindergarten =
        Namespaced_IRI.parse _namespace_name "Kindergarten" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kindergarten/key/amenity/value/kindergarten"></see>
    /// </summary>
    let ``Kindergarten/key/amenity/value/kindergarten`` =
        Namespaced_IRI.parse _namespace_name "Kindergarten/key/amenity/value/kindergarten" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kiosk"></see>
    /// </summary>
    let Kiosk = Namespaced_IRI.parse _namespace_name "Kiosk" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kiosk/key/shop/value/kiosk"></see>
    /// </summary>
    let ``Kiosk/key/shop/value/kiosk`` =
        Namespaced_IRI.parse _namespace_name "Kiosk/key/shop/value/kiosk" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kiosk/key/shop/value/Kiosk"></see>
    /// </summary>
    let ``Kiosk/key/shop/value/Kiosk`` =
        Namespaced_IRI.parse _namespace_name "Kiosk/key/shop/value/Kiosk" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KissingGate"></see>
    /// </summary>
    let KissingGate =
        Namespaced_IRI.parse _namespace_name "KissingGate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KissingGate/key/barrier/value/kissing_gate"></see>
    /// </summary>
    let ``KissingGate/key/barrier/value/kissing_gate`` =
        Namespaced_IRI.parse _namespace_name "KissingGate/key/barrier/value/kissing_gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KitchenShop"></see>
    /// </summary>
    let KitchenShop =
        Namespaced_IRI.parse _namespace_name "KitchenShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KitchenShop/key/shop/value/kitchen"></see>
    /// </summary>
    let ``KitchenShop/key/shop/value/kitchen`` =
        Namespaced_IRI.parse _namespace_name "KitchenShop/key/shop/value/kitchen" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KneippWaterCure"></see>
    /// </summary>
    let KneippWaterCure =
        Namespaced_IRI.parse _namespace_name "KneippWaterCure" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KneippWaterCure/key/amenity/value/kneipp_water_cure"></see>
    /// </summary>
    let ``KneippWaterCure/key/amenity/value/kneipp_water_cure`` =
        Namespaced_IRI.parse _namespace_name "KneippWaterCure/key/amenity/value/kneipp_water_cure" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lamp"></see>
    /// </summary>
    let Lamp = Namespaced_IRI.parse _namespace_name "Lamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lamp/key/amenity/value/lamp"></see>
    /// </summary>
    let ``Lamp/key/amenity/value/lamp`` =
        Namespaced_IRI.parse _namespace_name "Lamp/key/amenity/value/lamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LampPost"></see>
    /// </summary>
    let LampPost = Namespaced_IRI.parse _namespace_name "LampPost" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LampPost/key/amenity/value/lamp_post"></see>
    /// </summary>
    let ``LampPost/key/amenity/value/lamp_post`` =
        Namespaced_IRI.parse _namespace_name "LampPost/key/amenity/value/lamp_post" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Land"></see>
    /// </summary>
    let Land = Namespaced_IRI.parse _namespace_name "Land" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Land/key/natural/value/land"></see>
    /// </summary>
    let ``Land/key/natural/value/land`` =
        Namespaced_IRI.parse _namespace_name "Land/key/natural/value/land" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landfill"></see>
    /// </summary>
    let Landfill = Namespaced_IRI.parse _namespace_name "Landfill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landfill/key/landuse/value/landfill"></see>
    /// </summary>
    let ``Landfill/key/landuse/value/landfill`` =
        Namespaced_IRI.parse _namespace_name "Landfill/key/landuse/value/landfill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LandingLight"></see>
    /// </summary>
    let LandingLight =
        Namespaced_IRI.parse _namespace_name "LandingLight" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LandingLight/key/aeroway/value/landing_light"></see>
    /// </summary>
    let ``LandingLight/key/aeroway/value/landing_light`` =
        Namespaced_IRI.parse _namespace_name "LandingLight/key/aeroway/value/landing_light" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landmark"></see>
    /// </summary>
    let Landmark = Namespaced_IRI.parse _namespace_name "Landmark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landmark/key/man_made/value/landmark"></see>
    /// </summary>
    let ``Landmark/key/man_made/value/landmark`` =
        Namespaced_IRI.parse _namespace_name "Landmark/key/man_made/value/landmark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseMine"></see>
    /// </summary>
    let LanduseMine =
        Namespaced_IRI.parse _namespace_name "LanduseMine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseMine/key/landuse/value/mine"></see>
    /// </summary>
    let ``LanduseMine/key/landuse/value/mine`` =
        Namespaced_IRI.parse _namespace_name "LanduseMine/key/landuse/value/mine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LandusePark"></see>
    /// </summary>
    let LandusePark =
        Namespaced_IRI.parse _namespace_name "LandusePark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LandusePark/key/landuse/value/park"></see>
    /// </summary>
    let ``LandusePark/key/landuse/value/park`` =
        Namespaced_IRI.parse _namespace_name "LandusePark/key/landuse/value/park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseParking"></see>
    /// </summary>
    let LanduseParking =
        Namespaced_IRI.parse _namespace_name "LanduseParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseParking/key/landuse/value/parking"></see>
    /// </summary>
    let ``LanduseParking/key/landuse/value/parking`` =
        Namespaced_IRI.parse _namespace_name "LanduseParking/key/landuse/value/parking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseWood"></see>
    /// </summary>
    let LanduseWood =
        Namespaced_IRI.parse _namespace_name "LanduseWood" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseWood/key/landuse/value/wood"></see>
    /// </summary>
    let ``LanduseWood/key/landuse/value/wood`` =
        Namespaced_IRI.parse _namespace_name "LanduseWood/key/landuse/value/wood" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanguageSchool"></see>
    /// </summary>
    let LanguageSchool =
        Namespaced_IRI.parse _namespace_name "LanguageSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanguageSchool/key/amenity/value/language_school"></see>
    /// </summary>
    let ``LanguageSchool/key/amenity/value/language_school`` =
        Namespaced_IRI.parse _namespace_name "LanguageSchool/key/amenity/value/language_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LaunchPad"></see>
    /// </summary>
    let LaunchPad = Namespaced_IRI.parse _namespace_name "LaunchPad" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LaunchPad/key/man_made/value/launch_pad"></see>
    /// </summary>
    let ``LaunchPad/key/man_made/value/launch_pad`` =
        Namespaced_IRI.parse _namespace_name "LaunchPad/key/man_made/value/launch_pad" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Laundry"></see>
    /// </summary>
    let Laundry = Namespaced_IRI.parse _namespace_name "Laundry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Laundry/key/shop/value/laundry"></see>
    /// </summary>
    let ``Laundry/key/shop/value/laundry`` =
        Namespaced_IRI.parse _namespace_name "Laundry/key/shop/value/laundry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lavoir"></see>
    /// </summary>
    let Lavoir = Namespaced_IRI.parse _namespace_name "Lavoir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lavoir/key/historic/value/lavoir"></see>
    /// </summary>
    let ``Lavoir/key/historic/value/lavoir`` =
        Namespaced_IRI.parse _namespace_name "Lavoir/key/historic/value/lavoir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lawyer"></see>
    /// </summary>
    let Lawyer = Namespaced_IRI.parse _namespace_name "Lawyer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lawyer/key/amenity/value/lawyer"></see>
    /// </summary>
    let ``Lawyer/key/amenity/value/lawyer`` =
        Namespaced_IRI.parse _namespace_name "Lawyer/key/amenity/value/lawyer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LawyerOffice"></see>
    /// </summary>
    let LawyerOffice =
        Namespaced_IRI.parse _namespace_name "LawyerOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LawyerOffice/key/office/value/lawyer"></see>
    /// </summary>
    let ``LawyerOffice/key/office/value/lawyer`` =
        Namespaced_IRI.parse _namespace_name "LawyerOffice/key/office/value/lawyer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Layby"></see>
    /// </summary>
    let Layby = Namespaced_IRI.parse _namespace_name "Layby" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Layby/key/amenity/value/layby"></see>
    /// </summary>
    let ``Layby/key/amenity/value/layby`` =
        Namespaced_IRI.parse _namespace_name "Layby/key/amenity/value/layby" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Leather"></see>
    /// </summary>
    let Leather = Namespaced_IRI.parse _namespace_name "Leather" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Leather/key/shop/value/leather"></see>
    /// </summary>
    let ``Leather/key/shop/value/leather`` =
        Namespaced_IRI.parse _namespace_name "Leather/key/shop/value/leather" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LegalServices"></see>
    /// </summary>
    let LegalServices =
        Namespaced_IRI.parse _namespace_name "LegalServices" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LegalServices/key/shop/value/legal_services"></see>
    /// </summary>
    let ``LegalServices/key/shop/value/legal_services`` =
        Namespaced_IRI.parse _namespace_name "LegalServices/key/shop/value/legal_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lettering"></see>
    /// </summary>
    let Lettering = Namespaced_IRI.parse _namespace_name "Lettering" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lettering/key/man_made/value/lettering"></see>
    /// </summary>
    let ``Lettering/key/man_made/value/lettering`` =
        Namespaced_IRI.parse _namespace_name "Lettering/key/man_made/value/lettering" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LevelCrossing"></see>
    /// </summary>
    let LevelCrossing =
        Namespaced_IRI.parse _namespace_name "LevelCrossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LevelCrossing/key/railway/value/level_crossing"></see>
    /// </summary>
    let ``LevelCrossing/key/railway/value/level_crossing`` =
        Namespaced_IRI.parse _namespace_name "LevelCrossing/key/railway/value/level_crossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Library"></see>
    /// </summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Library/key/amenity/value/library"></see>
    /// </summary>
    let ``Library/key/amenity/value/library`` =
        Namespaced_IRI.parse _namespace_name "Library/key/amenity/value/library" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LicensedClub"></see>
    /// </summary>
    let LicensedClub =
        Namespaced_IRI.parse _namespace_name "LicensedClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LicensedClub/key/amenity/value/licensed_club"></see>
    /// </summary>
    let ``LicensedClub/key/amenity/value/licensed_club`` =
        Namespaced_IRI.parse _namespace_name "LicensedClub/key/amenity/value/licensed_club" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Life-buoy"></see>
    /// </summary>
    let ``Life-buoy`` =
        Namespaced_IRI.parse _namespace_name "Life-buoy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Life-buoy/key/amenity/value/life-buoy"></see>
    /// </summary>
    let ``Life-buoy/key/amenity/value/life-buoy`` =
        Namespaced_IRI.parse _namespace_name "Life-buoy/key/amenity/value/life-buoy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LifeRing"></see>
    /// </summary>
    let LifeRing = Namespaced_IRI.parse _namespace_name "LifeRing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LifeRing/key/amenity/value/life_ring"></see>
    /// </summary>
    let ``LifeRing/key/amenity/value/life_ring`` =
        Namespaced_IRI.parse _namespace_name "LifeRing/key/amenity/value/life_ring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LifeboatStation"></see>
    /// </summary>
    let LifeboatStation =
        Namespaced_IRI.parse _namespace_name "LifeboatStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LifeboatStation/key/amenity/value/lifeboat_station"></see>
    /// </summary>
    let ``LifeboatStation/key/amenity/value/lifeboat_station`` =
        Namespaced_IRI.parse _namespace_name "LifeboatStation/key/amenity/value/lifeboat_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LiftGate"></see>
    /// </summary>
    let LiftGate = Namespaced_IRI.parse _namespace_name "LiftGate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LiftGate/key/barrier/value/lift_gate"></see>
    /// </summary>
    let ``LiftGate/key/barrier/value/lift_gate`` =
        Namespaced_IRI.parse _namespace_name "LiftGate/key/barrier/value/lift_gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LightRail"></see>
    /// </summary>
    let LightRail = Namespaced_IRI.parse _namespace_name "LightRail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LightRail/key/railway/value/light_rail"></see>
    /// </summary>
    let ``LightRail/key/railway/value/light_rail`` =
        Namespaced_IRI.parse _namespace_name "LightRail/key/railway/value/light_rail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lighthouse"></see>
    /// </summary>
    let Lighthouse = Namespaced_IRI.parse _namespace_name "Lighthouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lighthouse/key/man_made/value/lighthouse"></see>
    /// </summary>
    let ``Lighthouse/key/man_made/value/lighthouse`` =
        Namespaced_IRI.parse _namespace_name "Lighthouse/key/man_made/value/lighthouse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lighting"></see>
    /// </summary>
    let Lighting = Namespaced_IRI.parse _namespace_name "Lighting" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lighting/key/shop/value/lighting"></see>
    /// </summary>
    let ``Lighting/key/shop/value/lighting`` =
        Namespaced_IRI.parse _namespace_name "Lighting/key/shop/value/lighting" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LineConnection"></see>
    /// </summary>
    let LineConnection =
        Namespaced_IRI.parse _namespace_name "LineConnection" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LineConnection/key/power/value/line_connection"></see>
    /// </summary>
    let ``LineConnection/key/power/value/line_connection`` =
        Namespaced_IRI.parse _namespace_name "LineConnection/key/power/value/line_connection" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lingerie"></see>
    /// </summary>
    let Lingerie = Namespaced_IRI.parse _namespace_name "Lingerie" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lingerie/key/shop/value/lingerie"></see>
    /// </summary>
    let ``Lingerie/key/shop/value/lingerie`` =
        Namespaced_IRI.parse _namespace_name "Lingerie/key/shop/value/lingerie" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LitterBin"></see>
    /// </summary>
    let LitterBin = Namespaced_IRI.parse _namespace_name "LitterBin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LitterBin/key/amenity/value/litter_bin"></see>
    /// </summary>
    let ``LitterBin/key/amenity/value/litter_bin`` =
        Namespaced_IRI.parse _namespace_name "LitterBin/key/amenity/value/litter_bin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LivingStreet"></see>
    /// </summary>
    let LivingStreet =
        Namespaced_IRI.parse _namespace_name "LivingStreet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LivingStreet/key/highway/value/living_street"></see>
    /// </summary>
    let ``LivingStreet/key/highway/value/living_street`` =
        Namespaced_IRI.parse _namespace_name "LivingStreet/key/highway/value/living_street" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locality"></see>
    /// </summary>
    let Locality = Namespaced_IRI.parse _namespace_name "Locality" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locality/key/place/value/locality"></see>
    /// </summary>
    let ``Locality/key/place/value/locality`` =
        Namespaced_IRI.parse _namespace_name "Locality/key/place/value/locality" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lock"></see>
    /// </summary>
    let Lock = Namespaced_IRI.parse _namespace_name "Lock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lock/key/lock/value/yes"></see>
    /// </summary>
    let ``Lock/key/lock/value/yes`` =
        Namespaced_IRI.parse _namespace_name "Lock/key/lock/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LockThing"></see>
    /// </summary>
    let LockThing = Namespaced_IRI.parse _namespace_name "LockThing" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LockGate"></see>
    /// </summary>
    let LockGate = Namespaced_IRI.parse _namespace_name "LockGate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LockGate/key/waterway/value/lock_gate"></see>
    /// </summary>
    let ``LockGate/key/waterway/value/lock_gate`` =
        Namespaced_IRI.parse _namespace_name "LockGate/key/waterway/value/lock_gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locksmith"></see>
    /// </summary>
    let Locksmith = Namespaced_IRI.parse _namespace_name "Locksmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locksmith/key/shop/value/locksmith"></see>
    /// </summary>
    let ``Locksmith/key/shop/value/locksmith`` =
        Namespaced_IRI.parse _namespace_name "Locksmith/key/shop/value/locksmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locksmith/key/craft/value/locksmith"></see>
    /// </summary>
    let ``Locksmith/key/craft/value/locksmith`` =
        Namespaced_IRI.parse _namespace_name "Locksmith/key/craft/value/locksmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LookoutTower"></see>
    /// </summary>
    let LookoutTower =
        Namespaced_IRI.parse _namespace_name "LookoutTower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LookoutTower/key/man_made/value/lookout_tower"></see>
    /// </summary>
    let ``LookoutTower/key/man_made/value/lookout_tower`` =
        Namespaced_IRI.parse _namespace_name "LookoutTower/key/man_made/value/lookout_tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MDF"></see>
    /// </summary>
    let MDF = Namespaced_IRI.parse _namespace_name "MDF" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MDF/key/man_made/value/MDF"></see>
    /// </summary>
    let ``MDF/key/man_made/value/MDF`` =
        Namespaced_IRI.parse _namespace_name "MDF/key/man_made/value/MDF" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mall"></see>
    /// </summary>
    let Mall = Namespaced_IRI.parse _namespace_name "Mall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mall/key/shop/value/mall"></see>
    /// </summary>
    let ``Mall/key/shop/value/mall`` =
        Namespaced_IRI.parse _namespace_name "Mall/key/shop/value/mall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBarn"></see>
    /// </summary>
    let ManMadeBarn =
        Namespaced_IRI.parse _namespace_name "ManMadeBarn" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBarn/key/man_made/value/barn"></see>
    /// </summary>
    let ``ManMadeBarn/key/man_made/value/barn`` =
        Namespaced_IRI.parse _namespace_name "ManMadeBarn/key/man_made/value/barn" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBillboard"></see>
    /// </summary>
    let ManMadeBillboard =
        Namespaced_IRI.parse _namespace_name "ManMadeBillboard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBillboard/key/man_made/value/billboard"></see>
    /// </summary>
    let ``ManMadeBillboard/key/man_made/value/billboard`` =
        Namespaced_IRI.parse _namespace_name "ManMadeBillboard/key/man_made/value/billboard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBuilding"></see>
    /// </summary>
    let ManMadeBuilding =
        Namespaced_IRI.parse _namespace_name "ManMadeBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBuilding/key/man_made/value/building"></see>
    /// </summary>
    let ``ManMadeBuilding/key/man_made/value/building`` =
        Namespaced_IRI.parse _namespace_name "ManMadeBuilding/key/man_made/value/building" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBuoy"></see>
    /// </summary>
    let ManMadeBuoy =
        Namespaced_IRI.parse _namespace_name "ManMadeBuoy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBuoy/key/man_made/value/buoy"></see>
    /// </summary>
    let ``ManMadeBuoy/key/man_made/value/buoy`` =
        Namespaced_IRI.parse _namespace_name "ManMadeBuoy/key/man_made/value/buoy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeCross"></see>
    /// </summary>
    let ManMadeCross =
        Namespaced_IRI.parse _namespace_name "ManMadeCross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeCross/key/man_made/value/cross"></see>
    /// </summary>
    let ``ManMadeCross/key/man_made/value/cross`` =
        Namespaced_IRI.parse _namespace_name "ManMadeCross/key/man_made/value/cross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFireHydrant"></see>
    /// </summary>
    let ManMadeFireHydrant =
        Namespaced_IRI.parse _namespace_name "ManMadeFireHydrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFireHydrant/key/man_made/value/fire_hydrant"></see>
    /// </summary>
    let ``ManMadeFireHydrant/key/man_made/value/fire_hydrant`` =
        Namespaced_IRI.parse _namespace_name "ManMadeFireHydrant/key/man_made/value/fire_hydrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFixme"></see>
    /// </summary>
    let ManMadeFixme =
        Namespaced_IRI.parse _namespace_name "ManMadeFixme" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFixme/key/man_made/value/fixme"></see>
    /// </summary>
    let ``ManMadeFixme/key/man_made/value/fixme`` =
        Namespaced_IRI.parse _namespace_name "ManMadeFixme/key/man_made/value/fixme" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFountain"></see>
    /// </summary>
    let ManMadeFountain =
        Namespaced_IRI.parse _namespace_name "ManMadeFountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFountain/key/man_made/value/fountain"></see>
    /// </summary>
    let ``ManMadeFountain/key/man_made/value/fountain`` =
        Namespaced_IRI.parse _namespace_name "ManMadeFountain/key/man_made/value/fountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeGate"></see>
    /// </summary>
    let ManMadeGate =
        Namespaced_IRI.parse _namespace_name "ManMadeGate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeGate/key/man_made/value/gate"></see>
    /// </summary>
    let ``ManMadeGate/key/man_made/value/gate`` =
        Namespaced_IRI.parse _namespace_name "ManMadeGate/key/man_made/value/gate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeHut"></see>
    /// </summary>
    let ManMadeHut = Namespaced_IRI.parse _namespace_name "ManMadeHut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeHut/key/man_made/value/hut"></see>
    /// </summary>
    let ``ManMadeHut/key/man_made/value/hut`` =
        Namespaced_IRI.parse _namespace_name "ManMadeHut/key/man_made/value/hut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeLamp"></see>
    /// </summary>
    let ManMadeLamp =
        Namespaced_IRI.parse _namespace_name "ManMadeLamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeLamp/key/man_made/value/lamp"></see>
    /// </summary>
    let ``ManMadeLamp/key/man_made/value/lamp`` =
        Namespaced_IRI.parse _namespace_name "ManMadeLamp/key/man_made/value/lamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeLampPost"></see>
    /// </summary>
    let ManMadeLampPost =
        Namespaced_IRI.parse _namespace_name "ManMadeLampPost" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeLampPost/key/man_made/value/lamp_post"></see>
    /// </summary>
    let ``ManMadeLampPost/key/man_made/value/lamp_post`` =
        Namespaced_IRI.parse _namespace_name "ManMadeLampPost/key/man_made/value/lamp_post" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeMine"></see>
    /// </summary>
    let ManMadeMine =
        Namespaced_IRI.parse _namespace_name "ManMadeMine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeMine/key/man_made/value/mine"></see>
    /// </summary>
    let ``ManMadeMine/key/man_made/value/mine`` =
        Namespaced_IRI.parse _namespace_name "ManMadeMine/key/man_made/value/mine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeObservatory"></see>
    /// </summary>
    let ManMadeObservatory =
        Namespaced_IRI.parse _namespace_name "ManMadeObservatory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeObservatory/key/man_made/value/observatory"></see>
    /// </summary>
    let ``ManMadeObservatory/key/man_made/value/observatory`` =
        Namespaced_IRI.parse _namespace_name "ManMadeObservatory/key/man_made/value/observatory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadePole"></see>
    /// </summary>
    let ManMadePole =
        Namespaced_IRI.parse _namespace_name "ManMadePole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadePole/key/man_made/value/pole"></see>
    /// </summary>
    let ``ManMadePole/key/man_made/value/pole`` =
        Namespaced_IRI.parse _namespace_name "ManMadePole/key/man_made/value/pole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadePumpingStation"></see>
    /// </summary>
    let ManMadePumpingStation =
        Namespaced_IRI.parse _namespace_name "ManMadePumpingStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadePumpingStation/key/man_made/value/pumping_station"></see>
    /// </summary>
    let ``ManMadePumpingStation/key/man_made/value/pumping_station`` =
        Namespaced_IRI.parse _namespace_name "ManMadePumpingStation/key/man_made/value/pumping_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeSign"></see>
    /// </summary>
    let ManMadeSign =
        Namespaced_IRI.parse _namespace_name "ManMadeSign" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeSign/key/man_made/value/sign"></see>
    /// </summary>
    let ``ManMadeSign/key/man_made/value/sign`` =
        Namespaced_IRI.parse _namespace_name "ManMadeSign/key/man_made/value/sign" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeStatue"></see>
    /// </summary>
    let ManMadeStatue =
        Namespaced_IRI.parse _namespace_name "ManMadeStatue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeStatue/key/man_made/value/statue"></see>
    /// </summary>
    let ``ManMadeStatue/key/man_made/value/statue`` =
        Namespaced_IRI.parse _namespace_name "ManMadeStatue/key/man_made/value/statue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeStorage"></see>
    /// </summary>
    let ManMadeStorage =
        Namespaced_IRI.parse _namespace_name "ManMadeStorage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeStorage/key/man_made/value/storage"></see>
    /// </summary>
    let ``ManMadeStorage/key/man_made/value/storage`` =
        Namespaced_IRI.parse _namespace_name "ManMadeStorage/key/man_made/value/storage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeTank"></see>
    /// </summary>
    let ManMadeTank =
        Namespaced_IRI.parse _namespace_name "ManMadeTank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeTank/key/man_made/value/tank"></see>
    /// </summary>
    let ``ManMadeTank/key/man_made/value/tank`` =
        Namespaced_IRI.parse _namespace_name "ManMadeTank/key/man_made/value/tank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeWell"></see>
    /// </summary>
    let ManMadeWell =
        Namespaced_IRI.parse _namespace_name "ManMadeWell" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeWell/key/man_made/value/well"></see>
    /// </summary>
    let ``ManMadeWell/key/man_made/value/well`` =
        Namespaced_IRI.parse _namespace_name "ManMadeWell/key/man_made/value/well" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Manhole"></see>
    /// </summary>
    let Manhole = Namespaced_IRI.parse _namespace_name "Manhole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Manhole/key/man_made/value/manhole"></see>
    /// </summary>
    let ``Manhole/key/man_made/value/manhole`` =
        Namespaced_IRI.parse _namespace_name "Manhole/key/man_made/value/manhole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Manor"></see>
    /// </summary>
    let Manor = Namespaced_IRI.parse _namespace_name "Manor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Manor/key/historic/value/manor"></see>
    /// </summary>
    let ``Manor/key/historic/value/manor`` =
        Namespaced_IRI.parse _namespace_name "Manor/key/historic/value/manor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marina"></see>
    /// </summary>
    let Marina = Namespaced_IRI.parse _namespace_name "Marina" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marina/key/leisure/value/marina"></see>
    /// </summary>
    let ``Marina/key/leisure/value/marina`` =
        Namespaced_IRI.parse _namespace_name "Marina/key/leisure/value/marina" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MaritimeBoundary"></see>
    /// </summary>
    let MaritimeBoundary =
        Namespaced_IRI.parse _namespace_name "MaritimeBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MaritimeBoundary/key/boundary/value/maritime"></see>
    /// </summary>
    let ``MaritimeBoundary/key/boundary/value/maritime`` =
        Namespaced_IRI.parse _namespace_name "MaritimeBoundary/key/boundary/value/maritime" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Market"></see>
    /// </summary>
    let Market = Namespaced_IRI.parse _namespace_name "Market" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Market/key/shop/value/market"></see>
    /// </summary>
    let ``Market/key/shop/value/market`` =
        Namespaced_IRI.parse _namespace_name "Market/key/shop/value/market" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Market/key/amenity/value/market"></see>
    /// </summary>
    let ``Market/key/amenity/value/market`` =
        Namespaced_IRI.parse _namespace_name "Market/key/amenity/value/market" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marketplace"></see>
    /// </summary>
    let Marketplace =
        Namespaced_IRI.parse _namespace_name "Marketplace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marketplace/key/amenity/value/marketplace"></see>
    /// </summary>
    let ``Marketplace/key/amenity/value/marketplace`` =
        Namespaced_IRI.parse _namespace_name "Marketplace/key/amenity/value/marketplace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marsh"></see>
    /// </summary>
    let Marsh = Namespaced_IRI.parse _namespace_name "Marsh" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marsh/key/natural/value/marsh"></see>
    /// </summary>
    let ``Marsh/key/natural/value/marsh`` =
        Namespaced_IRI.parse _namespace_name "Marsh/key/natural/value/marsh" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Massage"></see>
    /// </summary>
    let Massage = Namespaced_IRI.parse _namespace_name "Massage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Massage/key/amenity/value/massage"></see>
    /// </summary>
    let ``Massage/key/amenity/value/massage`` =
        Namespaced_IRI.parse _namespace_name "Massage/key/amenity/value/massage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MassageShop"></see>
    /// </summary>
    let MassageShop =
        Namespaced_IRI.parse _namespace_name "MassageShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MassageShop/key/shop/value/massage"></see>
    /// </summary>
    let ``MassageShop/key/shop/value/massage`` =
        Namespaced_IRI.parse _namespace_name "MassageShop/key/shop/value/massage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mast"></see>
    /// </summary>
    let Mast = Namespaced_IRI.parse _namespace_name "Mast" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mast/key/man_made/value/mast"></see>
    /// </summary>
    let ``Mast/key/man_made/value/mast`` =
        Namespaced_IRI.parse _namespace_name "Mast/key/man_made/value/mast" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mattress"></see>
    /// </summary>
    let Mattress = Namespaced_IRI.parse _namespace_name "Mattress" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mattress/key/shop/value/mattress"></see>
    /// </summary>
    let ``Mattress/key/shop/value/mattress`` =
        Namespaced_IRI.parse _namespace_name "Mattress/key/shop/value/mattress" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Meadow"></see>
    /// </summary>
    let Meadow = Namespaced_IRI.parse _namespace_name "Meadow" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Meadow/key/landuse/value/meadow"></see>
    /// </summary>
    let ``Meadow/key/landuse/value/meadow`` =
        Namespaced_IRI.parse _namespace_name "Meadow/key/landuse/value/meadow" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Meat"></see>
    /// </summary>
    let Meat = Namespaced_IRI.parse _namespace_name "Meat" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Meat/key/shop/value/meat"></see>
    /// </summary>
    let ``Meat/key/shop/value/meat`` =
        Namespaced_IRI.parse _namespace_name "Meat/key/shop/value/meat" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Medical"></see>
    /// </summary>
    let Medical = Namespaced_IRI.parse _namespace_name "Medical" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Medical/key/amenity/value/medical"></see>
    /// </summary>
    let ``Medical/key/amenity/value/medical`` =
        Namespaced_IRI.parse _namespace_name "Medical/key/amenity/value/medical" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MedicalCentre"></see>
    /// </summary>
    let MedicalCentre =
        Namespaced_IRI.parse _namespace_name "MedicalCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MedicalCentre/key/amenity/value/medical_centre"></see>
    /// </summary>
    let ``MedicalCentre/key/amenity/value/medical_centre`` =
        Namespaced_IRI.parse _namespace_name "MedicalCentre/key/amenity/value/medical_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Memorial"></see>
    /// </summary>
    let Memorial = Namespaced_IRI.parse _namespace_name "Memorial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Memorial/key/historic/value/memorial"></see>
    /// </summary>
    let ``Memorial/key/historic/value/memorial`` =
        Namespaced_IRI.parse _namespace_name "Memorial/key/historic/value/memorial" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Menhir"></see>
    /// </summary>
    let Menhir = Namespaced_IRI.parse _namespace_name "Menhir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Menhir/key/historic/value/menhir"></see>
    /// </summary>
    let ``Menhir/key/historic/value/menhir`` =
        Namespaced_IRI.parse _namespace_name "Menhir/key/historic/value/menhir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MetalConstructionCraft"></see>
    /// </summary>
    let MetalConstructionCraft =
        Namespaced_IRI.parse _namespace_name "MetalConstructionCraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MetalConstructionCraft/key/craft/value/metal_construction"></see>
    /// </summary>
    let ``MetalConstructionCraft/key/craft/value/metal_construction`` =
        Namespaced_IRI.parse _namespace_name "MetalConstructionCraft/key/craft/value/metal_construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Milestone"></see>
    /// </summary>
    let Milestone = Namespaced_IRI.parse _namespace_name "Milestone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Milestone/key/amenity/value/milestone"></see>
    /// </summary>
    let ``Milestone/key/amenity/value/milestone`` =
        Namespaced_IRI.parse _namespace_name "Milestone/key/amenity/value/milestone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryAirport"></see>
    /// </summary>
    let MilitaryAirport =
        Namespaced_IRI.parse _namespace_name "MilitaryAirport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryAirport/key/military/value/airfield"></see>
    /// </summary>
    let ``MilitaryAirport/key/military/value/airfield`` =
        Namespaced_IRI.parse _namespace_name "MilitaryAirport/key/military/value/airfield" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryBunker"></see>
    /// </summary>
    let MilitaryBunker =
        Namespaced_IRI.parse _namespace_name "MilitaryBunker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryBunker/key/military/value/bunker"></see>
    /// </summary>
    let ``MilitaryBunker/key/military/value/bunker`` =
        Namespaced_IRI.parse _namespace_name "MilitaryBunker/key/military/value/bunker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryLanduse"></see>
    /// </summary>
    let MilitaryLanduse =
        Namespaced_IRI.parse _namespace_name "MilitaryLanduse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryLanduse/key/landuse/value/military"></see>
    /// </summary>
    let ``MilitaryLanduse/key/landuse/value/military`` =
        Namespaced_IRI.parse _namespace_name "MilitaryLanduse/key/landuse/value/military" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryRange"></see>
    /// </summary>
    let MilitaryRange =
        Namespaced_IRI.parse _namespace_name "MilitaryRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryRange/key/military/value/range"></see>
    /// </summary>
    let ``MilitaryRange/key/military/value/range`` =
        Namespaced_IRI.parse _namespace_name "MilitaryRange/key/military/value/range" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilkDispenser"></see>
    /// </summary>
    let MilkDispenser =
        Namespaced_IRI.parse _namespace_name "MilkDispenser" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilkDispenser/key/amenity/value/milk_dispenser"></see>
    /// </summary>
    let ``MilkDispenser/key/amenity/value/milk_dispenser`` =
        Namespaced_IRI.parse _namespace_name "MilkDispenser/key/amenity/value/milk_dispenser" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mill"></see>
    /// </summary>
    let Mill = Namespaced_IRI.parse _namespace_name "Mill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mill/key/historic/value/mill"></see>
    /// </summary>
    let ``Mill/key/historic/value/mill`` =
        Namespaced_IRI.parse _namespace_name "Mill/key/historic/value/mill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mine"></see>
    /// </summary>
    let Mine = Namespaced_IRI.parse _namespace_name "Mine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mine/key/amenity/value/mine"></see>
    /// </summary>
    let ``Mine/key/amenity/value/mine`` =
        Namespaced_IRI.parse _namespace_name "Mine/key/amenity/value/mine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MineShaft"></see>
    /// </summary>
    let MineShaft = Namespaced_IRI.parse _namespace_name "MineShaft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MineShaft/key/historic/value/mine_shaft"></see>
    /// </summary>
    let ``MineShaft/key/historic/value/mine_shaft`` =
        Namespaced_IRI.parse _namespace_name "MineShaft/key/historic/value/mine_shaft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MineralSpring"></see>
    /// </summary>
    let MineralSpring =
        Namespaced_IRI.parse _namespace_name "MineralSpring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MineralSpring/key/waterway/value/mineral_spring"></see>
    /// </summary>
    let ``MineralSpring/key/waterway/value/mineral_spring`` =
        Namespaced_IRI.parse _namespace_name "MineralSpring/key/waterway/value/mineral_spring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mineshaft"></see>
    /// </summary>
    let Mineshaft = Namespaced_IRI.parse _namespace_name "Mineshaft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mineshaft/key/man_made/value/mineshaft"></see>
    /// </summary>
    let ``Mineshaft/key/man_made/value/mineshaft`` =
        Namespaced_IRI.parse _namespace_name "Mineshaft/key/man_made/value/mineshaft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniRoundabout"></see>
    /// </summary>
    let MiniRoundabout =
        Namespaced_IRI.parse _namespace_name "MiniRoundabout" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniRoundabout/key/highway/value/mini_roundabout"></see>
    /// </summary>
    let ``MiniRoundabout/key/highway/value/mini_roundabout`` =
        Namespaced_IRI.parse _namespace_name "MiniRoundabout/key/highway/value/mini_roundabout" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniatureGolf"></see>
    /// </summary>
    let MiniatureGolf =
        Namespaced_IRI.parse _namespace_name "MiniatureGolf" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniatureGolf/key/leisure/value/miniature_golf"></see>
    /// </summary>
    let ``MiniatureGolf/key/leisure/value/miniature_golf`` =
        Namespaced_IRI.parse _namespace_name "MiniatureGolf/key/leisure/value/miniature_golf" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniatureRailway"></see>
    /// </summary>
    let MiniatureRailway =
        Namespaced_IRI.parse _namespace_name "MiniatureRailway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniatureRailway/key/railway/value/miniature"></see>
    /// </summary>
    let ``MiniatureRailway/key/railway/value/miniature`` =
        Namespaced_IRI.parse _namespace_name "MiniatureRailway/key/railway/value/miniature" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Minimarket"></see>
    /// </summary>
    let Minimarket = Namespaced_IRI.parse _namespace_name "Minimarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Minimarket/key/shop/value/minimarket"></see>
    /// </summary>
    let ``Minimarket/key/shop/value/minimarket`` =
        Namespaced_IRI.parse _namespace_name "Minimarket/key/shop/value/minimarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mining"></see>
    /// </summary>
    let Mining = Namespaced_IRI.parse _namespace_name "Mining" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mining/key/landuse/value/mining"></see>
    /// </summary>
    let ``Mining/key/landuse/value/mining`` =
        Namespaced_IRI.parse _namespace_name "Mining/key/landuse/value/mining" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Misc"></see>
    /// </summary>
    let Misc = Namespaced_IRI.parse _namespace_name "Misc" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Misc/key/shop/value/misc"></see>
    /// </summary>
    let ``Misc/key/shop/value/misc`` =
        Namespaced_IRI.parse _namespace_name "Misc/key/shop/value/misc" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MixedLift"></see>
    /// </summary>
    let MixedLift = Namespaced_IRI.parse _namespace_name "MixedLift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MixedLift/key/aerialway/value/mixed_lift"></see>
    /// </summary>
    let ``MixedLift/key/aerialway/value/mixed_lift`` =
        Namespaced_IRI.parse _namespace_name "MixedLift/key/aerialway/value/mixed_lift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mobile"></see>
    /// </summary>
    let Mobile = Namespaced_IRI.parse _namespace_name "Mobile" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mobile/key/shop/value/mobile"></see>
    /// </summary>
    let ``Mobile/key/shop/value/mobile`` =
        Namespaced_IRI.parse _namespace_name "Mobile/key/shop/value/mobile" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MobilePhone"></see>
    /// </summary>
    let MobilePhone =
        Namespaced_IRI.parse _namespace_name "MobilePhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MobilePhone/key/shop/value/mobile_phone"></see>
    /// </summary>
    let ``MobilePhone/key/shop/value/mobile_phone`` =
        Namespaced_IRI.parse _namespace_name "MobilePhone/key/shop/value/mobile_phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MobileTelephony"></see>
    /// </summary>
    let MobileTelephony =
        Namespaced_IRI.parse _namespace_name "MobileTelephony" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MobileTelephony/key/shop/value/mobile_telephony"></see>
    /// </summary>
    let ``MobileTelephony/key/shop/value/mobile_telephony`` =
        Namespaced_IRI.parse _namespace_name "MobileTelephony/key/shop/value/mobile_telephony" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monastery"></see>
    /// </summary>
    let Monastery = Namespaced_IRI.parse _namespace_name "Monastery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monastery/key/amenity/value/monastery"></see>
    /// </summary>
    let ``Monastery/key/amenity/value/monastery`` =
        Namespaced_IRI.parse _namespace_name "Monastery/key/amenity/value/monastery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MonitoringStation"></see>
    /// </summary>
    let MonitoringStation =
        Namespaced_IRI.parse _namespace_name "MonitoringStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MonitoringStation/key/man_made/value/monitoring_station"></see>
    /// </summary>
    let ``MonitoringStation/key/man_made/value/monitoring_station`` =
        Namespaced_IRI.parse _namespace_name "MonitoringStation/key/man_made/value/monitoring_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monorail"></see>
    /// </summary>
    let Monorail = Namespaced_IRI.parse _namespace_name "Monorail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monorail/key/railway/value/monorail"></see>
    /// </summary>
    let ``Monorail/key/railway/value/monorail`` =
        Namespaced_IRI.parse _namespace_name "Monorail/key/railway/value/monorail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monument"></see>
    /// </summary>
    let Monument = Namespaced_IRI.parse _namespace_name "Monument" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monument/key/historic/value/monument"></see>
    /// </summary>
    let ``Monument/key/historic/value/monument`` =
        Namespaced_IRI.parse _namespace_name "Monument/key/historic/value/monument" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Moor"></see>
    /// </summary>
    let Moor = Namespaced_IRI.parse _namespace_name "Moor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Moor/key/natural/value/moor"></see>
    /// </summary>
    let ``Moor/key/natural/value/moor`` =
        Namespaced_IRI.parse _namespace_name "Moor/key/natural/value/moor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mooring"></see>
    /// </summary>
    let Mooring = Namespaced_IRI.parse _namespace_name "Mooring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mooring/key/waterway/value/mooring"></see>
    /// </summary>
    let ``Mooring/key/waterway/value/mooring`` =
        Namespaced_IRI.parse _namespace_name "Mooring/key/waterway/value/mooring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mortuary"></see>
    /// </summary>
    let Mortuary = Namespaced_IRI.parse _namespace_name "Mortuary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mortuary/key/amenity/value/mortuary"></see>
    /// </summary>
    let ``Mortuary/key/amenity/value/mortuary`` =
        Namespaced_IRI.parse _namespace_name "Mortuary/key/amenity/value/mortuary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motel"></see>
    /// </summary>
    let Motel = Namespaced_IRI.parse _namespace_name "Motel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motel/key/tourism/value/motel"></see>
    /// </summary>
    let ``Motel/key/tourism/value/motel`` =
        Namespaced_IRI.parse _namespace_name "Motel/key/tourism/value/motel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorbike"></see>
    /// </summary>
    let Motorbike = Namespaced_IRI.parse _namespace_name "Motorbike" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorbike/key/shop/value/motorbike"></see>
    /// </summary>
    let ``Motorbike/key/shop/value/motorbike`` =
        Namespaced_IRI.parse _namespace_name "Motorbike/key/shop/value/motorbike" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorcycle"></see>
    /// </summary>
    let Motorcycle = Namespaced_IRI.parse _namespace_name "Motorcycle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorcycle/key/shop/value/motorcycle"></see>
    /// </summary>
    let ``Motorcycle/key/shop/value/motorcycle`` =
        Namespaced_IRI.parse _namespace_name "Motorcycle/key/shop/value/motorcycle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorcycleParking"></see>
    /// </summary>
    let MotorcycleParking =
        Namespaced_IRI.parse _namespace_name "MotorcycleParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorcycleParking/key/amenity/value/motorcycle_parking"></see>
    /// </summary>
    let ``MotorcycleParking/key/amenity/value/motorcycle_parking`` =
        Namespaced_IRI.parse _namespace_name "MotorcycleParking/key/amenity/value/motorcycle_parking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorcycleRepair"></see>
    /// </summary>
    let MotorcycleRepair =
        Namespaced_IRI.parse _namespace_name "MotorcycleRepair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorcycleRepair/key/shop/value/motorcycle_repair"></see>
    /// </summary>
    let ``MotorcycleRepair/key/shop/value/motorcycle_repair`` =
        Namespaced_IRI.parse _namespace_name "MotorcycleRepair/key/shop/value/motorcycle_repair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorway"></see>
    /// </summary>
    let Motorway = Namespaced_IRI.parse _namespace_name "Motorway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorway/key/highway/value/motorway"></see>
    /// </summary>
    let ``Motorway/key/highway/value/motorway`` =
        Namespaced_IRI.parse _namespace_name "Motorway/key/highway/value/motorway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorwayJunction"></see>
    /// </summary>
    let MotorwayJunction =
        Namespaced_IRI.parse _namespace_name "MotorwayJunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorwayJunction/key/highway/value/motorway_junction"></see>
    /// </summary>
    let ``MotorwayJunction/key/highway/value/motorway_junction`` =
        Namespaced_IRI.parse _namespace_name "MotorwayJunction/key/highway/value/motorway_junction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorwayLink"></see>
    /// </summary>
    let MotorwayLink =
        Namespaced_IRI.parse _namespace_name "MotorwayLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorwayLink/key/highway/value/motorway_link"></see>
    /// </summary>
    let ``MotorwayLink/key/highway/value/motorway_link`` =
        Namespaced_IRI.parse _namespace_name "MotorwayLink/key/highway/value/motorway_link" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MountainPass"></see>
    /// </summary>
    let MountainPass =
        Namespaced_IRI.parse _namespace_name "MountainPass" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MountainPass/key/natural/value/mountain_pass"></see>
    /// </summary>
    let ``MountainPass/key/natural/value/mountain_pass`` =
        Namespaced_IRI.parse _namespace_name "MountainPass/key/natural/value/mountain_pass" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MountainRescue"></see>
    /// </summary>
    let MountainRescue =
        Namespaced_IRI.parse _namespace_name "MountainRescue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MountainRescue/key/amenity/value/mountain_rescue"></see>
    /// </summary>
    let ``MountainRescue/key/amenity/value/mountain_rescue`` =
        Namespaced_IRI.parse _namespace_name "MountainRescue/key/amenity/value/mountain_rescue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MtbRoute"></see>
    /// </summary>
    let MtbRoute = Namespaced_IRI.parse _namespace_name "MtbRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MtbRoute/key/route/value/mtb"></see>
    /// </summary>
    let ``MtbRoute/key/route/value/mtb`` =
        Namespaced_IRI.parse _namespace_name "MtbRoute/key/route/value/mtb" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mud"></see>
    /// </summary>
    let Mud = Namespaced_IRI.parse _namespace_name "Mud" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mud/key/natural/value/mud"></see>
    /// </summary>
    let ``Mud/key/natural/value/mud`` =
        Namespaced_IRI.parse _namespace_name "Mud/key/natural/value/mud" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MultiPolygon"></see>
    /// </summary>
    let MultiPolygon =
        Namespaced_IRI.parse _namespace_name "MultiPolygon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MultiPolygon/key/type/value/multipolygon"></see>
    /// </summary>
    let ``MultiPolygon/key/type/value/multipolygon`` =
        Namespaced_IRI.parse _namespace_name "MultiPolygon/key/type/value/multipolygon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Municipality"></see>
    /// </summary>
    let Municipality =
        Namespaced_IRI.parse _namespace_name "Municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Municipality/key/place/value/municipality"></see>
    /// </summary>
    let ``Municipality/key/place/value/municipality`` =
        Namespaced_IRI.parse _namespace_name "Municipality/key/place/value/municipality" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Museum"></see>
    /// </summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Museum/key/tourism/value/museum"></see>
    /// </summary>
    let ``Museum/key/tourism/value/museum`` =
        Namespaced_IRI.parse _namespace_name "Museum/key/tourism/value/museum" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mushroom"></see>
    /// </summary>
    let Mushroom = Namespaced_IRI.parse _namespace_name "Mushroom" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mushroom/key/natural/value/mushroom"></see>
    /// </summary>
    let ``Mushroom/key/natural/value/mushroom`` =
        Namespaced_IRI.parse _namespace_name "Mushroom/key/natural/value/mushroom" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Music"></see>
    /// </summary>
    let Music = Namespaced_IRI.parse _namespace_name "Music" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Music/key/shop/value/music"></see>
    /// </summary>
    let ``Music/key/shop/value/music`` =
        Namespaced_IRI.parse _namespace_name "Music/key/shop/value/music" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicVenue"></see>
    /// </summary>
    let MusicVenue = Namespaced_IRI.parse _namespace_name "MusicVenue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicVenue/key/leisure/value/music_venue"></see>
    /// </summary>
    let ``MusicVenue/key/leisure/value/music_venue`` =
        Namespaced_IRI.parse _namespace_name "MusicVenue/key/leisure/value/music_venue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicVenue/key/amenity/value/music_venue"></see>
    /// </summary>
    let ``MusicVenue/key/amenity/value/music_venue`` =
        Namespaced_IRI.parse _namespace_name "MusicVenue/key/amenity/value/music_venue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicalInstruments"></see>
    /// </summary>
    let MusicalInstruments =
        Namespaced_IRI.parse _namespace_name "MusicalInstruments" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicalInstruments/key/shop/value/musical_instruments"></see>
    /// </summary>
    let ``MusicalInstruments/key/shop/value/musical_instruments`` =
        Namespaced_IRI.parse _namespace_name "MusicalInstruments/key/shop/value/musical_instruments" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NailSalon"></see>
    /// </summary>
    let NailSalon = Namespaced_IRI.parse _namespace_name "NailSalon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NailSalon/key/shop/value/nail_salon"></see>
    /// </summary>
    let ``NailSalon/key/shop/value/nail_salon`` =
        Namespaced_IRI.parse _namespace_name "NailSalon/key/shop/value/nail_salon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nails"></see>
    /// </summary>
    let Nails = Namespaced_IRI.parse _namespace_name "Nails" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nails/key/shop/value/nails"></see>
    /// </summary>
    let ``Nails/key/shop/value/nails`` =
        Namespaced_IRI.parse _namespace_name "Nails/key/shop/value/nails" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NarrowGauge"></see>
    /// </summary>
    let NarrowGauge =
        Namespaced_IRI.parse _namespace_name "NarrowGauge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NarrowGauge/key/railway/value/narrow_gauge"></see>
    /// </summary>
    let ``NarrowGauge/key/railway/value/narrow_gauge`` =
        Namespaced_IRI.parse _namespace_name "NarrowGauge/key/railway/value/narrow_gauge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NationalForest"></see>
    /// </summary>
    let NationalForest =
        Namespaced_IRI.parse _namespace_name "NationalForest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NationalForest/key/boundary/value/national_forest"></see>
    /// </summary>
    let ``NationalForest/key/boundary/value/national_forest`` =
        Namespaced_IRI.parse _namespace_name "NationalForest/key/boundary/value/national_forest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NationalPark"></see>
    /// </summary>
    let NationalPark =
        Namespaced_IRI.parse _namespace_name "NationalPark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NationalPark/key/boundary/value/national_park"></see>
    /// </summary>
    let ``NationalPark/key/boundary/value/national_park`` =
        Namespaced_IRI.parse _namespace_name "NationalPark/key/boundary/value/national_park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalBench"></see>
    /// </summary>
    let NaturalBench =
        Namespaced_IRI.parse _namespace_name "NaturalBench" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalBench/key/natural/value/bench"></see>
    /// </summary>
    let ``NaturalBench/key/natural/value/bench`` =
        Namespaced_IRI.parse _namespace_name "NaturalBench/key/natural/value/bench" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalRiver"></see>
    /// </summary>
    let NaturalRiver =
        Namespaced_IRI.parse _namespace_name "NaturalRiver" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalRiver/key/natural/value/river"></see>
    /// </summary>
    let ``NaturalRiver/key/natural/value/river`` =
        Namespaced_IRI.parse _namespace_name "NaturalRiver/key/natural/value/river" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalRock"></see>
    /// </summary>
    let NaturalRock =
        Namespaced_IRI.parse _namespace_name "NaturalRock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalRock/key/natural/value/rock"></see>
    /// </summary>
    let ``NaturalRock/key/natural/value/rock`` =
        Namespaced_IRI.parse _namespace_name "NaturalRock/key/natural/value/rock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalShelter"></see>
    /// </summary>
    let NaturalShelter =
        Namespaced_IRI.parse _namespace_name "NaturalShelter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalShelter/key/amenity/value/natural_shelter"></see>
    /// </summary>
    let ``NaturalShelter/key/amenity/value/natural_shelter`` =
        Namespaced_IRI.parse _namespace_name "NaturalShelter/key/amenity/value/natural_shelter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalValley"></see>
    /// </summary>
    let NaturalValley =
        Namespaced_IRI.parse _namespace_name "NaturalValley" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalValley/key/natural/value/valley"></see>
    /// </summary>
    let ``NaturalValley/key/natural/value/valley`` =
        Namespaced_IRI.parse _namespace_name "NaturalValley/key/natural/value/valley" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalWaterfall"></see>
    /// </summary>
    let NaturalWaterfall =
        Namespaced_IRI.parse _namespace_name "NaturalWaterfall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalWaterfall/key/natural/value/waterfall"></see>
    /// </summary>
    let ``NaturalWaterfall/key/natural/value/waterfall`` =
        Namespaced_IRI.parse _namespace_name "NaturalWaterfall/key/natural/value/waterfall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NatureReserve"></see>
    /// </summary>
    let NatureReserve =
        Namespaced_IRI.parse _namespace_name "NatureReserve" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NatureReserve/key/leisure/value/nature_reserve"></see>
    /// </summary>
    let ``NatureReserve/key/leisure/value/nature_reserve`` =
        Namespaced_IRI.parse _namespace_name "NatureReserve/key/leisure/value/nature_reserve" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NavalBase"></see>
    /// </summary>
    let NavalBase = Namespaced_IRI.parse _namespace_name "NavalBase" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NavalBase/key/military/value/naval_base"></see>
    /// </summary>
    let ``NavalBase/key/military/value/naval_base`` =
        Namespaced_IRI.parse _namespace_name "NavalBase/key/military/value/naval_base" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NestBox"></see>
    /// </summary>
    let NestBox = Namespaced_IRI.parse _namespace_name "NestBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NestBox/key/amenity/value/nest_box"></see>
    /// </summary>
    let ``NestBox/key/amenity/value/nest_box`` =
        Namespaced_IRI.parse _namespace_name "NestBox/key/amenity/value/nest_box" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Newsagent"></see>
    /// </summary>
    let Newsagent = Namespaced_IRI.parse _namespace_name "Newsagent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Newsagent/key/shop/value/newsagent"></see>
    /// </summary>
    let ``Newsagent/key/shop/value/newsagent`` =
        Namespaced_IRI.parse _namespace_name "Newsagent/key/shop/value/newsagent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NewspaperOffice"></see>
    /// </summary>
    let NewspaperOffice =
        Namespaced_IRI.parse _namespace_name "NewspaperOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NewspaperOffice/key/office/value/newspaper"></see>
    /// </summary>
    let ``NewspaperOffice/key/office/value/newspaper`` =
        Namespaced_IRI.parse _namespace_name "NewspaperOffice/key/office/value/newspaper" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Newsstand"></see>
    /// </summary>
    let Newsstand = Namespaced_IRI.parse _namespace_name "Newsstand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Newsstand/key/shop/value/newsstand"></see>
    /// </summary>
    let ``Newsstand/key/shop/value/newsstand`` =
        Namespaced_IRI.parse _namespace_name "Newsstand/key/shop/value/newsstand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NgoOffice"></see>
    /// </summary>
    let NgoOffice = Namespaced_IRI.parse _namespace_name "NgoOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NgoOffice/key/office/value/ngo"></see>
    /// </summary>
    let ``NgoOffice/key/office/value/ngo`` =
        Namespaced_IRI.parse _namespace_name "NgoOffice/key/office/value/ngo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nightclub"></see>
    /// </summary>
    let Nightclub = Namespaced_IRI.parse _namespace_name "Nightclub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nightclub/key/amenity/value/nightclub"></see>
    /// </summary>
    let ``Nightclub/key/amenity/value/nightclub`` =
        Namespaced_IRI.parse _namespace_name "Nightclub/key/amenity/value/nightclub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NotAShop"></see>
    /// </summary>
    let NotAShop = Namespaced_IRI.parse _namespace_name "NotAShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NotAShop/key/shop/value/no"></see>
    /// </summary>
    let ``NotAShop/key/shop/value/no`` =
        Namespaced_IRI.parse _namespace_name "NotAShop/key/shop/value/no" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Notice"></see>
    /// </summary>
    let Notice = Namespaced_IRI.parse _namespace_name "Notice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Notice/key/amenity/value/notice"></see>
    /// </summary>
    let ``Notice/key/amenity/value/notice`` =
        Namespaced_IRI.parse _namespace_name "Notice/key/amenity/value/notice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nursery"></see>
    /// </summary>
    let Nursery = Namespaced_IRI.parse _namespace_name "Nursery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nursery/key/amenity/value/nursery"></see>
    /// </summary>
    let ``Nursery/key/amenity/value/nursery`` =
        Namespaced_IRI.parse _namespace_name "Nursery/key/amenity/value/nursery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NursingHome"></see>
    /// </summary>
    let NursingHome =
        Namespaced_IRI.parse _namespace_name "NursingHome" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NursingHome/key/amenity/value/nursing_home"></see>
    /// </summary>
    let ``NursingHome/key/amenity/value/nursing_home`` =
        Namespaced_IRI.parse _namespace_name "NursingHome/key/amenity/value/nursing_home" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Observatory"></see>
    /// </summary>
    let Observatory =
        Namespaced_IRI.parse _namespace_name "Observatory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Observatory/key/amenity/value/observatory"></see>
    /// </summary>
    let ``Observatory/key/amenity/value/observatory`` =
        Namespaced_IRI.parse _namespace_name "Observatory/key/amenity/value/observatory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Office/key/amenity/value/office"></see>
    /// </summary>
    let ``Office/key/amenity/value/office`` =
        Namespaced_IRI.parse _namespace_name "Office/key/amenity/value/office" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OfficeShop"></see>
    /// </summary>
    let OfficeShop = Namespaced_IRI.parse _namespace_name "OfficeShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OfficeShop/key/shop/value/office"></see>
    /// </summary>
    let ``OfficeShop/key/shop/value/office`` =
        Namespaced_IRI.parse _namespace_name "OfficeShop/key/shop/value/office" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OfficeSupplies"></see>
    /// </summary>
    let OfficeSupplies =
        Namespaced_IRI.parse _namespace_name "OfficeSupplies" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OfficeSupplies/key/shop/value/office_supplies"></see>
    /// </summary>
    let ``OfficeSupplies/key/shop/value/office_supplies`` =
        Namespaced_IRI.parse _namespace_name "OfficeSupplies/key/shop/value/office_supplies" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Offices"></see>
    /// </summary>
    let Offices = Namespaced_IRI.parse _namespace_name "Offices" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Offices/key/building/value/offices"></see>
    /// </summary>
    let ``Offices/key/building/value/offices`` =
        Namespaced_IRI.parse _namespace_name "Offices/key/building/value/offices" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OilPlatform"></see>
    /// </summary>
    let OilPlatform =
        Namespaced_IRI.parse _namespace_name "OilPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OilPlatform/key/man_made/value/oil_platform"></see>
    /// </summary>
    let ``OilPlatform/key/man_made/value/oil_platform`` =
        Namespaced_IRI.parse _namespace_name "OilPlatform/key/man_made/value/oil_platform" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OpticianCraft"></see>
    /// </summary>
    let OpticianCraft =
        Namespaced_IRI.parse _namespace_name "OpticianCraft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OpticianCraft/key/craft/value/optician"></see>
    /// </summary>
    let ``OpticianCraft/key/craft/value/optician`` =
        Namespaced_IRI.parse _namespace_name "OpticianCraft/key/craft/value/optician" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OpticianShop"></see>
    /// </summary>
    let OpticianShop =
        Namespaced_IRI.parse _namespace_name "OpticianShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OpticianShop/key/shop/value/optician"></see>
    /// </summary>
    let ``OpticianShop/key/shop/value/optician`` =
        Namespaced_IRI.parse _namespace_name "OpticianShop/key/shop/value/optician" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Optometrist"></see>
    /// </summary>
    let Optometrist =
        Namespaced_IRI.parse _namespace_name "Optometrist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Optometrist/key/amenity/value/optometrist"></see>
    /// </summary>
    let ``Optometrist/key/amenity/value/optometrist`` =
        Namespaced_IRI.parse _namespace_name "Optometrist/key/amenity/value/optometrist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Orchard"></see>
    /// </summary>
    let Orchard = Namespaced_IRI.parse _namespace_name "Orchard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Orchard/key/landuse/value/orchard"></see>
    /// </summary>
    let ``Orchard/key/landuse/value/orchard`` =
        Namespaced_IRI.parse _namespace_name "Orchard/key/landuse/value/orchard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Organic"></see>
    /// </summary>
    let Organic = Namespaced_IRI.parse _namespace_name "Organic" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Organic/key/shop/value/organic"></see>
    /// </summary>
    let ``Organic/key/shop/value/organic`` =
        Namespaced_IRI.parse _namespace_name "Organic/key/shop/value/organic" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Other"></see>
    /// </summary>
    let Other = Namespaced_IRI.parse _namespace_name "Other" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Other/key/amenity/value/other"></see>
    /// </summary>
    let ``Other/key/amenity/value/other`` =
        Namespaced_IRI.parse _namespace_name "Other/key/amenity/value/other" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OtherShop"></see>
    /// </summary>
    let OtherShop = Namespaced_IRI.parse _namespace_name "OtherShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OtherShop/key/shop/value/other"></see>
    /// </summary>
    let ``OtherShop/key/shop/value/other`` =
        Namespaced_IRI.parse _namespace_name "OtherShop/key/shop/value/other" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outcrop"></see>
    /// </summary>
    let Outcrop = Namespaced_IRI.parse _namespace_name "Outcrop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outcrop/key/geological/value/outcrop"></see>
    /// </summary>
    let ``Outcrop/key/geological/value/outcrop`` =
        Namespaced_IRI.parse _namespace_name "Outcrop/key/geological/value/outcrop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outdoor"></see>
    /// </summary>
    let Outdoor = Namespaced_IRI.parse _namespace_name "Outdoor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outdoor/key/shop/value/outdoor"></see>
    /// </summary>
    let ``Outdoor/key/shop/value/outdoor`` =
        Namespaced_IRI.parse _namespace_name "Outdoor/key/shop/value/outdoor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outlet"></see>
    /// </summary>
    let Outlet = Namespaced_IRI.parse _namespace_name "Outlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outlet/key/shop/value/outlet"></see>
    /// </summary>
    let ``Outlet/key/shop/value/outlet`` =
        Namespaced_IRI.parse _namespace_name "Outlet/key/shop/value/outlet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Oven"></see>
    /// </summary>
    let Oven = Namespaced_IRI.parse _namespace_name "Oven" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Oven/key/man_made/value/oven"></see>
    /// </summary>
    let ``Oven/key/man_made/value/oven`` =
        Namespaced_IRI.parse _namespace_name "Oven/key/man_made/value/oven" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Paint"></see>
    /// </summary>
    let Paint = Namespaced_IRI.parse _namespace_name "Paint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Paint/key/shop/value/paint"></see>
    /// </summary>
    let ``Paint/key/shop/value/paint`` =
        Namespaced_IRI.parse _namespace_name "Paint/key/shop/value/paint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Painter"></see>
    /// </summary>
    let Painter = Namespaced_IRI.parse _namespace_name "Painter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Painter/key/shop/value/painter"></see>
    /// </summary>
    let ``Painter/key/shop/value/painter`` =
        Namespaced_IRI.parse _namespace_name "Painter/key/shop/value/painter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Painter/key/craft/value/painter"></see>
    /// </summary>
    let ``Painter/key/craft/value/painter`` =
        Namespaced_IRI.parse _namespace_name "Painter/key/craft/value/painter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Palace"></see>
    /// </summary>
    let Palace = Namespaced_IRI.parse _namespace_name "Palace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Palace/key/historic/value/palace"></see>
    /// </summary>
    let ``Palace/key/historic/value/palace`` =
        Namespaced_IRI.parse _namespace_name "Palace/key/historic/value/palace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PalaeontologicalSite"></see>
    /// </summary>
    let PalaeontologicalSite =
        Namespaced_IRI.parse _namespace_name "PalaeontologicalSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PalaeontologicalSite/key/geological/value/palaeontological_site"></see>
    /// </summary>
    let ``PalaeontologicalSite/key/geological/value/palaeontological_site`` =
        Namespaced_IRI.parse _namespace_name "PalaeontologicalSite/key/geological/value/palaeontological_site" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParcelBox"></see>
    /// </summary>
    let ParcelBox = Namespaced_IRI.parse _namespace_name "ParcelBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParcelBox/key/amenity/value/parcel_box"></see>
    /// </summary>
    let ``ParcelBox/key/amenity/value/parcel_box`` =
        Namespaced_IRI.parse _namespace_name "ParcelBox/key/amenity/value/parcel_box" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Park"></see>
    /// </summary>
    let Park = Namespaced_IRI.parse _namespace_name "Park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Park/key/amenity/value/park"></see>
    /// </summary>
    let ``Park/key/amenity/value/park`` =
        Namespaced_IRI.parse _namespace_name "Park/key/amenity/value/park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Park/key/leisure/value/park"></see>
    /// </summary>
    let ``Park/key/leisure/value/park`` =
        Namespaced_IRI.parse _namespace_name "Park/key/leisure/value/park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkBench"></see>
    /// </summary>
    let ParkBench = Namespaced_IRI.parse _namespace_name "ParkBench" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkBench/key/leisure/value/park_bench"></see>
    /// </summary>
    let ``ParkBench/key/leisure/value/park_bench`` =
        Namespaced_IRI.parse _namespace_name "ParkBench/key/leisure/value/park_bench" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkBench/key/amenity/value/park_bench"></see>
    /// </summary>
    let ``ParkBench/key/amenity/value/park_bench`` =
        Namespaced_IRI.parse _namespace_name "ParkBench/key/amenity/value/park_bench" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking"></see>
    /// </summary>
    let Parking = Namespaced_IRI.parse _namespace_name "Parking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking/key/amenity/value/parking"></see>
    /// </summary>
    let ``Parking/key/amenity/value/parking`` =
        Namespaced_IRI.parse _namespace_name "Parking/key/amenity/value/parking" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking%3Bfuel"></see>
    /// </summary>
    let ``Parking%3Bfuel`` =
        Namespaced_IRI.parse _namespace_name "Parking%3Bfuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking%3Bfuel/key/amenity/value/parking%3Bfuel"></see>
    /// </summary>
    let ``Parking%3Bfuel/key/amenity/value/parking%3Bfuel`` =
        Namespaced_IRI.parse _namespace_name "Parking%3Bfuel/key/amenity/value/parking%3Bfuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking%3Brestaurant%3Bfuel"></see>
    /// </summary>
    let ``Parking%3Brestaurant%3Bfuel`` =
        Namespaced_IRI.parse _namespace_name "Parking%3Brestaurant%3Bfuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking%3Brestaurant%3Bfuel/key/amenity/value/parking%3Brestaurant%3Bfuel"></see>
    /// </summary>
    let ``Parking%3Brestaurant%3Bfuel/key/amenity/value/parking%3Brestaurant%3Bfuel`` =
        Namespaced_IRI.parse _namespace_name "Parking%3Brestaurant%3Bfuel/key/amenity/value/parking%3Brestaurant%3Bfuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingAisle"></see>
    /// </summary>
    let ParkingAisle =
        Namespaced_IRI.parse _namespace_name "ParkingAisle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingAisle/key/service/value/parking_aisle"></see>
    /// </summary>
    let ``ParkingAisle/key/service/value/parking_aisle`` =
        Namespaced_IRI.parse _namespace_name "ParkingAisle/key/service/value/parking_aisle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingEntrance"></see>
    /// </summary>
    let ParkingEntrance =
        Namespaced_IRI.parse _namespace_name "ParkingEntrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingEntrance/key/amenity/value/parking_entrance"></see>
    /// </summary>
    let ``ParkingEntrance/key/amenity/value/parking_entrance`` =
        Namespaced_IRI.parse _namespace_name "ParkingEntrance/key/amenity/value/parking_entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingMeter"></see>
    /// </summary>
    let ParkingMeter =
        Namespaced_IRI.parse _namespace_name "ParkingMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingMeter/key/amenity/value/parking_meter"></see>
    /// </summary>
    let ``ParkingMeter/key/amenity/value/parking_meter`` =
        Namespaced_IRI.parse _namespace_name "ParkingMeter/key/amenity/value/parking_meter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingPosition"></see>
    /// </summary>
    let ParkingPosition =
        Namespaced_IRI.parse _namespace_name "ParkingPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingPosition/key/aeroway/value/parking_position"></see>
    /// </summary>
    let ``ParkingPosition/key/aeroway/value/parking_position`` =
        Namespaced_IRI.parse _namespace_name "ParkingPosition/key/aeroway/value/parking_position" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingSpace"></see>
    /// </summary>
    let ParkingSpace =
        Namespaced_IRI.parse _namespace_name "ParkingSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingSpace/key/amenity/value/parking_space"></see>
    /// </summary>
    let ``ParkingSpace/key/amenity/value/parking_space`` =
        Namespaced_IRI.parse _namespace_name "ParkingSpace/key/amenity/value/parking_space" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParquetLayer"></see>
    /// </summary>
    let ParquetLayer =
        Namespaced_IRI.parse _namespace_name "ParquetLayer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParquetLayer/key/craft/value/parquet_layer"></see>
    /// </summary>
    let ``ParquetLayer/key/craft/value/parquet_layer`` =
        Namespaced_IRI.parse _namespace_name "ParquetLayer/key/craft/value/parquet_layer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PassingPlace"></see>
    /// </summary>
    let PassingPlace =
        Namespaced_IRI.parse _namespace_name "PassingPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PassingPlace/key/highway/value/passing_place"></see>
    /// </summary>
    let ``PassingPlace/key/highway/value/passing_place`` =
        Namespaced_IRI.parse _namespace_name "PassingPlace/key/highway/value/passing_place" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PassingPlaces"></see>
    /// </summary>
    let PassingPlaces =
        Namespaced_IRI.parse _namespace_name "PassingPlaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PassingPlaces/key/highway/value/passing_places"></see>
    /// </summary>
    let ``PassingPlaces/key/highway/value/passing_places`` =
        Namespaced_IRI.parse _namespace_name "PassingPlaces/key/highway/value/passing_places" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pastry"></see>
    /// </summary>
    let Pastry = Namespaced_IRI.parse _namespace_name "Pastry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pastry/key/shop/value/pastry"></see>
    /// </summary>
    let ``Pastry/key/shop/value/pastry`` =
        Namespaced_IRI.parse _namespace_name "Pastry/key/shop/value/pastry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Path"></see>
    /// </summary>
    let Path = Namespaced_IRI.parse _namespace_name "Path" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Path/key/highway/value/path"></see>
    /// </summary>
    let ``Path/key/highway/value/path`` =
        Namespaced_IRI.parse _namespace_name "Path/key/highway/value/path" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Patisserie"></see>
    /// </summary>
    let Patisserie = Namespaced_IRI.parse _namespace_name "Patisserie" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Patisserie/key/shop/value/patisserie"></see>
    /// </summary>
    let ``Patisserie/key/shop/value/patisserie`` =
        Namespaced_IRI.parse _namespace_name "Patisserie/key/shop/value/patisserie" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pavilion"></see>
    /// </summary>
    let Pavilion = Namespaced_IRI.parse _namespace_name "Pavilion" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pavilion/key/building/value/pavilion"></see>
    /// </summary>
    let ``Pavilion/key/building/value/pavilion`` =
        Namespaced_IRI.parse _namespace_name "Pavilion/key/building/value/pavilion" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pawnshop"></see>
    /// </summary>
    let Pawnshop = Namespaced_IRI.parse _namespace_name "Pawnshop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pawnshop/key/shop/value/pawnshop"></see>
    /// </summary>
    let ``Pawnshop/key/shop/value/pawnshop`` =
        Namespaced_IRI.parse _namespace_name "Pawnshop/key/shop/value/pawnshop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PaydayLoans"></see>
    /// </summary>
    let PaydayLoans =
        Namespaced_IRI.parse _namespace_name "PaydayLoans" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PaydayLoans/key/shop/value/payday_loans"></see>
    /// </summary>
    let ``PaydayLoans/key/shop/value/payday_loans`` =
        Namespaced_IRI.parse _namespace_name "PaydayLoans/key/shop/value/payday_loans" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Peak"></see>
    /// </summary>
    let Peak = Namespaced_IRI.parse _namespace_name "Peak" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Peak/key/natural/value/peak"></see>
    /// </summary>
    let ``Peak/key/natural/value/peak`` =
        Namespaced_IRI.parse _namespace_name "Peak/key/natural/value/peak" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PedestrianUse"></see>
    /// </summary>
    let PedestrianUse =
        Namespaced_IRI.parse _namespace_name "PedestrianUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PedestrianUse/key/highway/value/pedestrian"></see>
    /// </summary>
    let ``PedestrianUse/key/highway/value/pedestrian`` =
        Namespaced_IRI.parse _namespace_name "PedestrianUse/key/highway/value/pedestrian" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Peninsula"></see>
    /// </summary>
    let Peninsula = Namespaced_IRI.parse _namespace_name "Peninsula" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Peninsula/key/natural/value/peninsula"></see>
    /// </summary>
    let ``Peninsula/key/natural/value/peninsula`` =
        Namespaced_IRI.parse _namespace_name "Peninsula/key/natural/value/peninsula" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Perfume"></see>
    /// </summary>
    let Perfume = Namespaced_IRI.parse _namespace_name "Perfume" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Perfume/key/shop/value/perfume"></see>
    /// </summary>
    let ``Perfume/key/shop/value/perfume`` =
        Namespaced_IRI.parse _namespace_name "Perfume/key/shop/value/perfume" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Perfumery"></see>
    /// </summary>
    let Perfumery = Namespaced_IRI.parse _namespace_name "Perfumery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Perfumery/key/shop/value/perfumery"></see>
    /// </summary>
    let ``Perfumery/key/shop/value/perfumery`` =
        Namespaced_IRI.parse _namespace_name "Perfumery/key/shop/value/perfumery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pet"></see>
    /// </summary>
    let Pet = Namespaced_IRI.parse _namespace_name "Pet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pet/key/shop/value/pet"></see>
    /// </summary>
    let ``Pet/key/shop/value/pet`` =
        Namespaced_IRI.parse _namespace_name "Pet/key/shop/value/pet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetFood"></see>
    /// </summary>
    let PetFood = Namespaced_IRI.parse _namespace_name "PetFood" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetFood/key/shop/value/pet_food"></see>
    /// </summary>
    let ``PetFood/key/shop/value/pet_food`` =
        Namespaced_IRI.parse _namespace_name "PetFood/key/shop/value/pet_food" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetShop"></see>
    /// </summary>
    let PetShop = Namespaced_IRI.parse _namespace_name "PetShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetShop/key/shop/value/pet_shop"></see>
    /// </summary>
    let ``PetShop/key/shop/value/pet_shop`` =
        Namespaced_IRI.parse _namespace_name "PetShop/key/shop/value/pet_shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetSupplies"></see>
    /// </summary>
    let PetSupplies =
        Namespaced_IRI.parse _namespace_name "PetSupplies" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetSupplies/key/shop/value/pet_supplies"></see>
    /// </summary>
    let ``PetSupplies/key/shop/value/pet_supplies`` =
        Namespaced_IRI.parse _namespace_name "PetSupplies/key/shop/value/pet_supplies" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetSupply"></see>
    /// </summary>
    let PetSupply = Namespaced_IRI.parse _namespace_name "PetSupply" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetSupply/key/shop/value/pet_supply"></see>
    /// </summary>
    let ``PetSupply/key/shop/value/pet_supply`` =
        Namespaced_IRI.parse _namespace_name "PetSupply/key/shop/value/pet_supply" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetroleumWell"></see>
    /// </summary>
    let PetroleumWell =
        Namespaced_IRI.parse _namespace_name "PetroleumWell" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetroleumWell/key/man_made/value/petroleum_well"></see>
    /// </summary>
    let ``PetroleumWell/key/man_made/value/petroleum_well`` =
        Namespaced_IRI.parse _namespace_name "PetroleumWell/key/man_made/value/petroleum_well" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pets"></see>
    /// </summary>
    let Pets = Namespaced_IRI.parse _namespace_name "Pets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pets/key/shop/value/pets"></see>
    /// </summary>
    let ``Pets/key/shop/value/pets`` =
        Namespaced_IRI.parse _namespace_name "Pets/key/shop/value/pets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pharmacy"></see>
    /// </summary>
    let Pharmacy = Namespaced_IRI.parse _namespace_name "Pharmacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pharmacy/key/shop/value/pharmacy"></see>
    /// </summary>
    let ``Pharmacy/key/shop/value/pharmacy`` =
        Namespaced_IRI.parse _namespace_name "Pharmacy/key/shop/value/pharmacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pharmacy/key/amenity/value/pharmacy"></see>
    /// </summary>
    let ``Pharmacy/key/amenity/value/pharmacy`` =
        Namespaced_IRI.parse _namespace_name "Pharmacy/key/amenity/value/pharmacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Phone"></see>
    /// </summary>
    let Phone = Namespaced_IRI.parse _namespace_name "Phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Phone/key/amenity/value/phone"></see>
    /// </summary>
    let ``Phone/key/amenity/value/phone`` =
        Namespaced_IRI.parse _namespace_name "Phone/key/amenity/value/phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhoneMast"></see>
    /// </summary>
    let PhoneMast = Namespaced_IRI.parse _namespace_name "PhoneMast" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhoneMast/key/man_made/value/phone_mast"></see>
    /// </summary>
    let ``PhoneMast/key/man_made/value/phone_mast`` =
        Namespaced_IRI.parse _namespace_name "PhoneMast/key/man_made/value/phone_mast" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhoneShop"></see>
    /// </summary>
    let PhoneShop = Namespaced_IRI.parse _namespace_name "PhoneShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhoneShop/key/shop/value/phone"></see>
    /// </summary>
    let ``PhoneShop/key/shop/value/phone`` =
        Namespaced_IRI.parse _namespace_name "PhoneShop/key/shop/value/phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photo"></see>
    /// </summary>
    let Photo = Namespaced_IRI.parse _namespace_name "Photo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photo/key/shop/value/photo"></see>
    /// </summary>
    let ``Photo/key/shop/value/photo`` =
        Namespaced_IRI.parse _namespace_name "Photo/key/shop/value/photo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photocopying"></see>
    /// </summary>
    let Photocopying =
        Namespaced_IRI.parse _namespace_name "Photocopying" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photocopying/key/shop/value/photocopying"></see>
    /// </summary>
    let ``Photocopying/key/shop/value/photocopying`` =
        Namespaced_IRI.parse _namespace_name "Photocopying/key/shop/value/photocopying" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photographer"></see>
    /// </summary>
    let Photographer =
        Namespaced_IRI.parse _namespace_name "Photographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photographer/key/craft/value/photographer"></see>
    /// </summary>
    let ``Photographer/key/craft/value/photographer`` =
        Namespaced_IRI.parse _namespace_name "Photographer/key/craft/value/photographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhotographicLaboratory"></see>
    /// </summary>
    let PhotographicLaboratory =
        Namespaced_IRI.parse _namespace_name "PhotographicLaboratory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhotographicLaboratory/key/craft/value/photographic_laboratory"></see>
    /// </summary>
    let ``PhotographicLaboratory/key/craft/value/photographic_laboratory`` =
        Namespaced_IRI.parse _namespace_name "PhotographicLaboratory/key/craft/value/photographic_laboratory" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Physiotherapy"></see>
    /// </summary>
    let Physiotherapy =
        Namespaced_IRI.parse _namespace_name "Physiotherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Physiotherapy/key/amenity/value/physiotherapy"></see>
    /// </summary>
    let ``Physiotherapy/key/amenity/value/physiotherapy`` =
        Namespaced_IRI.parse _namespace_name "Physiotherapy/key/amenity/value/physiotherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Picknick"></see>
    /// </summary>
    let Picknick = Namespaced_IRI.parse _namespace_name "Picknick" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Picknick/key/amenity/value/picknick"></see>
    /// </summary>
    let ``Picknick/key/amenity/value/picknick`` =
        Namespaced_IRI.parse _namespace_name "Picknick/key/amenity/value/picknick" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Picnic+table"></see>
    /// </summary>
    let ``Picnic+table`` =
        Namespaced_IRI.parse _namespace_name "Picnic+table" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Picnic+table/key/amenity/value/picnic%20table"></see>
    /// </summary>
    let ``Picnic+table/key/amenity/value/picnic%20table`` =
        Namespaced_IRI.parse _namespace_name "Picnic+table/key/amenity/value/picnic%20table" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PicnicSite"></see>
    /// </summary>
    let PicnicSite = Namespaced_IRI.parse _namespace_name "PicnicSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PicnicSite/key/tourism/value/picnic_site"></see>
    /// </summary>
    let ``PicnicSite/key/tourism/value/picnic_site`` =
        Namespaced_IRI.parse _namespace_name "PicnicSite/key/tourism/value/picnic_site" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PicnicTable"></see>
    /// </summary>
    let PicnicTable =
        Namespaced_IRI.parse _namespace_name "PicnicTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PicnicTable/key/amenity/value/picnic_table"></see>
    /// </summary>
    let ``PicnicTable/key/amenity/value/picnic_table`` =
        Namespaced_IRI.parse _namespace_name "PicnicTable/key/amenity/value/picnic_table" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pier"></see>
    /// </summary>
    let Pier = Namespaced_IRI.parse _namespace_name "Pier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pier/key/man_made/value/pier"></see>
    /// </summary>
    let ``Pier/key/man_made/value/pier`` =
        Namespaced_IRI.parse _namespace_name "Pier/key/man_made/value/pier" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pietra+miliare+FD"></see>
    /// </summary>
    let ``Pietra+miliare+FD`` =
        Namespaced_IRI.parse _namespace_name "Pietra+miliare+FD" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pietra+miliare+FD/key/amenity/value/pietra%20miliare%20FD"></see>
    /// </summary>
    let ``Pietra+miliare+FD/key/amenity/value/pietra%20miliare%20FD`` =
        Namespaced_IRI.parse _namespace_name "Pietra+miliare+FD/key/amenity/value/pietra%20miliare%20FD" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pipeline"></see>
    /// </summary>
    let Pipeline = Namespaced_IRI.parse _namespace_name "Pipeline" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pipeline/key/man_made/value/pipeline"></see>
    /// </summary>
    let ``Pipeline/key/man_made/value/pipeline`` =
        Namespaced_IRI.parse _namespace_name "Pipeline/key/man_made/value/pipeline" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PipelineMarker"></see>
    /// </summary>
    let PipelineMarker =
        Namespaced_IRI.parse _namespace_name "PipelineMarker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PipelineMarker/key/man_made/value/pipeline_marker"></see>
    /// </summary>
    let ``PipelineMarker/key/man_made/value/pipeline_marker`` =
        Namespaced_IRI.parse _namespace_name "PipelineMarker/key/man_made/value/pipeline_marker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pipelinemarker"></see>
    /// </summary>
    let Pipelinemarker =
        Namespaced_IRI.parse _namespace_name "Pipelinemarker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pipelinemarker/key/man_made/value/pipelinemarker"></see>
    /// </summary>
    let ``Pipelinemarker/key/man_made/value/pipelinemarker`` =
        Namespaced_IRI.parse _namespace_name "Pipelinemarker/key/man_made/value/pipelinemarker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PisteRoute"></see>
    /// </summary>
    let PisteRoute = Namespaced_IRI.parse _namespace_name "PisteRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PisteRoute/key/route/value/piste"></see>
    /// </summary>
    let ``PisteRoute/key/route/value/piste`` =
        Namespaced_IRI.parse _namespace_name "PisteRoute/key/route/value/piste" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pitch"></see>
    /// </summary>
    let Pitch = Namespaced_IRI.parse _namespace_name "Pitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pitch/key/leisure/value/pitch"></see>
    /// </summary>
    let ``Pitch/key/leisure/value/pitch`` =
        Namespaced_IRI.parse _namespace_name "Pitch/key/leisure/value/pitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PlaceOfWorship"></see>
    /// </summary>
    let PlaceOfWorship =
        Namespaced_IRI.parse _namespace_name "PlaceOfWorship" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PlaceOfWorship/key/amenity/value/place_of_worship"></see>
    /// </summary>
    let ``PlaceOfWorship/key/amenity/value/place_of_worship`` =
        Namespaced_IRI.parse _namespace_name "PlaceOfWorship/key/amenity/value/place_of_worship" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plain"></see>
    /// </summary>
    let Plain = Namespaced_IRI.parse _namespace_name "Plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plain/key/natural/value/plain"></see>
    /// </summary>
    let ``Plain/key/natural/value/plain`` =
        Namespaced_IRI.parse _namespace_name "Plain/key/natural/value/plain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PlantNursery"></see>
    /// </summary>
    let PlantNursery =
        Namespaced_IRI.parse _namespace_name "PlantNursery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PlantNursery/key/landuse/value/plant_nursery"></see>
    /// </summary>
    let ``PlantNursery/key/landuse/value/plant_nursery`` =
        Namespaced_IRI.parse _namespace_name "PlantNursery/key/landuse/value/plant_nursery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plasterer"></see>
    /// </summary>
    let Plasterer = Namespaced_IRI.parse _namespace_name "Plasterer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plasterer/key/craft/value/plasterer"></see>
    /// </summary>
    let ``Plasterer/key/craft/value/plasterer`` =
        Namespaced_IRI.parse _namespace_name "Plasterer/key/craft/value/plasterer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plateau"></see>
    /// </summary>
    let Plateau = Namespaced_IRI.parse _namespace_name "Plateau" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plateau/key/natural/value/plateau"></see>
    /// </summary>
    let ``Plateau/key/natural/value/plateau`` =
        Namespaced_IRI.parse _namespace_name "Plateau/key/natural/value/plateau" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Platform"></see>
    /// </summary>
    let Platform = Namespaced_IRI.parse _namespace_name "Platform" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Platform/key/public_transport/value/platform"></see>
    /// </summary>
    let ``Platform/key/public_transport/value/platform`` =
        Namespaced_IRI.parse _namespace_name "Platform/key/public_transport/value/platform" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicTransportThing"></see>
    /// </summary>
    let PublicTransportThing =
        Namespaced_IRI.parse _namespace_name "PublicTransportThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Playground"></see>
    /// </summary>
    let Playground = Namespaced_IRI.parse _namespace_name "Playground" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Playground/key/amenity/value/playground"></see>
    /// </summary>
    let ``Playground/key/amenity/value/playground`` =
        Namespaced_IRI.parse _namespace_name "Playground/key/amenity/value/playground" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Playground/key/leisure/value/playground"></see>
    /// </summary>
    let ``Playground/key/leisure/value/playground`` =
        Namespaced_IRI.parse _namespace_name "Playground/key/leisure/value/playground" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plumber"></see>
    /// </summary>
    let Plumber = Namespaced_IRI.parse _namespace_name "Plumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plumber/key/amenity/value/plumber"></see>
    /// </summary>
    let ``Plumber/key/amenity/value/plumber`` =
        Namespaced_IRI.parse _namespace_name "Plumber/key/amenity/value/plumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plumber/key/shop/value/plumber"></see>
    /// </summary>
    let ``Plumber/key/shop/value/plumber`` =
        Namespaced_IRI.parse _namespace_name "Plumber/key/shop/value/plumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plumber/key/craft/value/plumber"></see>
    /// </summary>
    let ``Plumber/key/craft/value/plumber`` =
        Namespaced_IRI.parse _namespace_name "Plumber/key/craft/value/plumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Point"></see>
    /// </summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Point/key/natural/value/point"></see>
    /// </summary>
    let ``Point/key/natural/value/point`` =
        Namespaced_IRI.parse _namespace_name "Point/key/natural/value/point" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PointOfInterest"></see>
    /// </summary>
    let PointOfInterest =
        Namespaced_IRI.parse _namespace_name "PointOfInterest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PointOfInterest/key/leisure/value/point_of_interest"></see>
    /// </summary>
    let ``PointOfInterest/key/leisure/value/point_of_interest`` =
        Namespaced_IRI.parse _namespace_name "PointOfInterest/key/leisure/value/point_of_interest" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PointOfInterest/key/tourism/value/yes"></see>
    /// </summary>
    let ``PointOfInterest/key/tourism/value/yes`` =
        Namespaced_IRI.parse _namespace_name "PointOfInterest/key/tourism/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Police"></see>
    /// </summary>
    let Police = Namespaced_IRI.parse _namespace_name "Police" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Police/key/amenity/value/police"></see>
    /// </summary>
    let ``Police/key/amenity/value/police`` =
        Namespaced_IRI.parse _namespace_name "Police/key/amenity/value/police" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PoliticalBoundary"></see>
    /// </summary>
    let PoliticalBoundary =
        Namespaced_IRI.parse _namespace_name "PoliticalBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PoliticalBoundary/key/boundary/value/political"></see>
    /// </summary>
    let ``PoliticalBoundary/key/boundary/value/political`` =
        Namespaced_IRI.parse _namespace_name "PoliticalBoundary/key/boundary/value/political" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PostBox"></see>
    /// </summary>
    let PostBox = Namespaced_IRI.parse _namespace_name "PostBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PostBox/key/amenity/value/post_box"></see>
    /// </summary>
    let ``PostBox/key/amenity/value/post_box`` =
        Namespaced_IRI.parse _namespace_name "PostBox/key/amenity/value/post_box" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PostOffice"></see>
    /// </summary>
    let PostOffice = Namespaced_IRI.parse _namespace_name "PostOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PostOffice/key/amenity/value/post_office"></see>
    /// </summary>
    let ``PostOffice/key/amenity/value/post_office`` =
        Namespaced_IRI.parse _namespace_name "PostOffice/key/amenity/value/post_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pottery"></see>
    /// </summary>
    let Pottery = Namespaced_IRI.parse _namespace_name "Pottery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pottery/key/shop/value/pottery"></see>
    /// </summary>
    let ``Pottery/key/shop/value/pottery`` =
        Namespaced_IRI.parse _namespace_name "Pottery/key/shop/value/pottery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pottery/key/craft/value/pottery"></see>
    /// </summary>
    let ``Pottery/key/craft/value/pottery`` =
        Namespaced_IRI.parse _namespace_name "Pottery/key/craft/value/pottery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerBox"></see>
    /// </summary>
    let PowerBox = Namespaced_IRI.parse _namespace_name "PowerBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerBox/key/power/value/box"></see>
    /// </summary>
    let ``PowerBox/key/power/value/box`` =
        Namespaced_IRI.parse _namespace_name "PowerBox/key/power/value/box" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerConstruction"></see>
    /// </summary>
    let PowerConstruction =
        Namespaced_IRI.parse _namespace_name "PowerConstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerConstruction/key/power/value/construction"></see>
    /// </summary>
    let ``PowerConstruction/key/power/value/construction`` =
        Namespaced_IRI.parse _namespace_name "PowerConstruction/key/power/value/construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerDismantled"></see>
    /// </summary>
    let PowerDismantled =
        Namespaced_IRI.parse _namespace_name "PowerDismantled" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerDismantled/key/power/value/dismantled"></see>
    /// </summary>
    let ``PowerDismantled/key/power/value/dismantled`` =
        Namespaced_IRI.parse _namespace_name "PowerDismantled/key/power/value/dismantled" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerGenerator"></see>
    /// </summary>
    let PowerGenerator =
        Namespaced_IRI.parse _namespace_name "PowerGenerator" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerGenerator/key/power/value/generator"></see>
    /// </summary>
    let ``PowerGenerator/key/power/value/generator`` =
        Namespaced_IRI.parse _namespace_name "PowerGenerator/key/power/value/generator" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerLine"></see>
    /// </summary>
    let PowerLine = Namespaced_IRI.parse _namespace_name "PowerLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerLine/key/power/value/line"></see>
    /// </summary>
    let ``PowerLine/key/power/value/line`` =
        Namespaced_IRI.parse _namespace_name "PowerLine/key/power/value/line" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerMinorLine"></see>
    /// </summary>
    let PowerMinorLine =
        Namespaced_IRI.parse _namespace_name "PowerMinorLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerMinorLine/key/power/value/minor_line"></see>
    /// </summary>
    let ``PowerMinorLine/key/power/value/minor_line`` =
        Namespaced_IRI.parse _namespace_name "PowerMinorLine/key/power/value/minor_line" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerPole"></see>
    /// </summary>
    let PowerPole = Namespaced_IRI.parse _namespace_name "PowerPole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerPole/key/power/value/pole"></see>
    /// </summary>
    let ``PowerPole/key/power/value/pole`` =
        Namespaced_IRI.parse _namespace_name "PowerPole/key/power/value/pole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerPylon"></see>
    /// </summary>
    let PowerPylon = Namespaced_IRI.parse _namespace_name "PowerPylon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerPylon/key/power/value/pylon"></see>
    /// </summary>
    let ``PowerPylon/key/power/value/pylon`` =
        Namespaced_IRI.parse _namespace_name "PowerPylon/key/power/value/pylon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerStation"></see>
    /// </summary>
    let PowerStation =
        Namespaced_IRI.parse _namespace_name "PowerStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerStation/key/power/value/station"></see>
    /// </summary>
    let ``PowerStation/key/power/value/station`` =
        Namespaced_IRI.parse _namespace_name "PowerStation/key/power/value/station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerSubStation"></see>
    /// </summary>
    let PowerSubStation =
        Namespaced_IRI.parse _namespace_name "PowerSubStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerSubStation/key/power/value/sub_station"></see>
    /// </summary>
    let ``PowerSubStation/key/power/value/sub_station`` =
        Namespaced_IRI.parse _namespace_name "PowerSubStation/key/power/value/sub_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerSwitch"></see>
    /// </summary>
    let PowerSwitch =
        Namespaced_IRI.parse _namespace_name "PowerSwitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerSwitch/key/power/value/switch"></see>
    /// </summary>
    let ``PowerSwitch/key/power/value/switch`` =
        Namespaced_IRI.parse _namespace_name "PowerSwitch/key/power/value/switch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerTower"></see>
    /// </summary>
    let PowerTower = Namespaced_IRI.parse _namespace_name "PowerTower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerTower/key/power/value/tower"></see>
    /// </summary>
    let ``PowerTower/key/power/value/tower`` =
        Namespaced_IRI.parse _namespace_name "PowerTower/key/power/value/tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Preschool"></see>
    /// </summary>
    let Preschool = Namespaced_IRI.parse _namespace_name "Preschool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Preschool/key/amenity/value/preschool"></see>
    /// </summary>
    let ``Preschool/key/amenity/value/preschool`` =
        Namespaced_IRI.parse _namespace_name "Preschool/key/amenity/value/preschool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PreservedRailway"></see>
    /// </summary>
    let PreservedRailway =
        Namespaced_IRI.parse _namespace_name "PreservedRailway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PreservedRailway/key/railway/value/preserved"></see>
    /// </summary>
    let ``PreservedRailway/key/railway/value/preserved`` =
        Namespaced_IRI.parse _namespace_name "PreservedRailway/key/railway/value/preserved" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PrimaryHighway"></see>
    /// </summary>
    let PrimaryHighway =
        Namespaced_IRI.parse _namespace_name "PrimaryHighway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PrimaryHighway/key/highway/value/primary"></see>
    /// </summary>
    let ``PrimaryHighway/key/highway/value/primary`` =
        Namespaced_IRI.parse _namespace_name "PrimaryHighway/key/highway/value/primary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Printer"></see>
    /// </summary>
    let Printer = Namespaced_IRI.parse _namespace_name "Printer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Printer/key/shop/value/printer"></see>
    /// </summary>
    let ``Printer/key/shop/value/printer`` =
        Namespaced_IRI.parse _namespace_name "Printer/key/shop/value/printer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Printing"></see>
    /// </summary>
    let Printing = Namespaced_IRI.parse _namespace_name "Printing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Printing/key/shop/value/printing"></see>
    /// </summary>
    let ``Printing/key/shop/value/printing`` =
        Namespaced_IRI.parse _namespace_name "Printing/key/shop/value/printing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Prison"></see>
    /// </summary>
    let Prison = Namespaced_IRI.parse _namespace_name "Prison" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Prison/key/amenity/value/prison"></see>
    /// </summary>
    let ``Prison/key/amenity/value/prison`` =
        Namespaced_IRI.parse _namespace_name "Prison/key/amenity/value/prison" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProposedHighway"></see>
    /// </summary>
    let ProposedHighway =
        Namespaced_IRI.parse _namespace_name "ProposedHighway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProposedHighway/key/highway/value/proposed"></see>
    /// </summary>
    let ``ProposedHighway/key/highway/value/proposed`` =
        Namespaced_IRI.parse _namespace_name "ProposedHighway/key/highway/value/proposed" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProtectedArea"></see>
    /// </summary>
    let ProtectedArea =
        Namespaced_IRI.parse _namespace_name "ProtectedArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProtectedArea/key/boundary/value/protected_area"></see>
    /// </summary>
    let ``ProtectedArea/key/boundary/value/protected_area`` =
        Namespaced_IRI.parse _namespace_name "ProtectedArea/key/boundary/value/protected_area" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProtectedBuilding"></see>
    /// </summary>
    let ProtectedBuilding =
        Namespaced_IRI.parse _namespace_name "ProtectedBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProtectedBuilding/key/historic/value/protected_building"></see>
    /// </summary>
    let ``ProtectedBuilding/key/historic/value/protected_building`` =
        Namespaced_IRI.parse _namespace_name "ProtectedBuilding/key/historic/value/protected_building" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pub"></see>
    /// </summary>
    let Pub = Namespaced_IRI.parse _namespace_name "Pub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pub/key/amenity/value/pub"></see>
    /// </summary>
    let ``Pub/key/amenity/value/pub`` =
        Namespaced_IRI.parse _namespace_name "Pub/key/amenity/value/pub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicBuilding"></see>
    /// </summary>
    let PublicBuilding =
        Namespaced_IRI.parse _namespace_name "PublicBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicBuilding/key/amenity/value/public_building"></see>
    /// </summary>
    let ``PublicBuilding/key/amenity/value/public_building`` =
        Namespaced_IRI.parse _namespace_name "PublicBuilding/key/amenity/value/public_building" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicMarket"></see>
    /// </summary>
    let PublicMarket =
        Namespaced_IRI.parse _namespace_name "PublicMarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicMarket/key/amenity/value/public_market"></see>
    /// </summary>
    let ``PublicMarket/key/amenity/value/public_market`` =
        Namespaced_IRI.parse _namespace_name "PublicMarket/key/amenity/value/public_market" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pump"></see>
    /// </summary>
    let Pump = Namespaced_IRI.parse _namespace_name "Pump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pump/key/man_made/value/pump"></see>
    /// </summary>
    let ``Pump/key/man_made/value/pump`` =
        Namespaced_IRI.parse _namespace_name "Pump/key/man_made/value/pump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PumpingRig"></see>
    /// </summary>
    let PumpingRig = Namespaced_IRI.parse _namespace_name "PumpingRig" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PumpingRig/key/man_made/value/pumping_rig"></see>
    /// </summary>
    let ``PumpingRig/key/man_made/value/pumping_rig`` =
        Namespaced_IRI.parse _namespace_name "PumpingRig/key/man_made/value/pumping_rig" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pumpjack"></see>
    /// </summary>
    let Pumpjack = Namespaced_IRI.parse _namespace_name "Pumpjack" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pumpjack/key/man_made/value/pumpjack"></see>
    /// </summary>
    let ``Pumpjack/key/man_made/value/pumpjack`` =
        Namespaced_IRI.parse _namespace_name "Pumpjack/key/man_made/value/pumpjack" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pylon"></see>
    /// </summary>
    let Pylon = Namespaced_IRI.parse _namespace_name "Pylon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pylon/key/aerialway/value/pylon"></see>
    /// </summary>
    let ``Pylon/key/aerialway/value/pylon`` =
        Namespaced_IRI.parse _namespace_name "Pylon/key/aerialway/value/pylon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/QuangoOffice"></see>
    /// </summary>
    let QuangoOffice =
        Namespaced_IRI.parse _namespace_name "QuangoOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/QuangoOffice/key/office/value/quango"></see>
    /// </summary>
    let ``QuangoOffice/key/office/value/quango`` =
        Namespaced_IRI.parse _namespace_name "QuangoOffice/key/office/value/quango" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Quarry"></see>
    /// </summary>
    let Quarry = Namespaced_IRI.parse _namespace_name "Quarry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Quarry/key/landuse/value/quarry"></see>
    /// </summary>
    let ``Quarry/key/landuse/value/quarry`` =
        Namespaced_IRI.parse _namespace_name "Quarry/key/landuse/value/quarry" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Raceway"></see>
    /// </summary>
    let Raceway = Namespaced_IRI.parse _namespace_name "Raceway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Raceway/key/highway/value/raceway"></see>
    /// </summary>
    let ``Raceway/key/highway/value/raceway`` =
        Namespaced_IRI.parse _namespace_name "Raceway/key/highway/value/raceway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rail"></see>
    /// </summary>
    let Rail = Namespaced_IRI.parse _namespace_name "Rail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rail/key/railway/value/rail"></see>
    /// </summary>
    let ``Rail/key/railway/value/rail`` =
        Namespaced_IRI.parse _namespace_name "Rail/key/railway/value/rail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayConstruction"></see>
    /// </summary>
    let RailwayConstruction =
        Namespaced_IRI.parse _namespace_name "RailwayConstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayConstruction/key/railway/value/construction"></see>
    /// </summary>
    let ``RailwayConstruction/key/railway/value/construction`` =
        Namespaced_IRI.parse _namespace_name "RailwayConstruction/key/railway/value/construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayCrossing"></see>
    /// </summary>
    let RailwayCrossing =
        Namespaced_IRI.parse _namespace_name "RailwayCrossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayCrossing/key/railway/value/crossing"></see>
    /// </summary>
    let ``RailwayCrossing/key/railway/value/crossing`` =
        Namespaced_IRI.parse _namespace_name "RailwayCrossing/key/railway/value/crossing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayHalt"></see>
    /// </summary>
    let RailwayHalt =
        Namespaced_IRI.parse _namespace_name "RailwayHalt" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayHalt/key/railway/value/halt"></see>
    /// </summary>
    let ``RailwayHalt/key/railway/value/halt`` =
        Namespaced_IRI.parse _namespace_name "RailwayHalt/key/railway/value/halt" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayJunction"></see>
    /// </summary>
    let RailwayJunction =
        Namespaced_IRI.parse _namespace_name "RailwayJunction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayJunction/key/railway/value/junction"></see>
    /// </summary>
    let ``RailwayJunction/key/railway/value/junction`` =
        Namespaced_IRI.parse _namespace_name "RailwayJunction/key/railway/value/junction" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayLanduse"></see>
    /// </summary>
    let RailwayLanduse =
        Namespaced_IRI.parse _namespace_name "RailwayLanduse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayLanduse/key/landuse/value/railway"></see>
    /// </summary>
    let ``RailwayLanduse/key/landuse/value/railway`` =
        Namespaced_IRI.parse _namespace_name "RailwayLanduse/key/landuse/value/railway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayMilestone"></see>
    /// </summary>
    let RailwayMilestone =
        Namespaced_IRI.parse _namespace_name "RailwayMilestone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayMilestone/key/railway/value/milestone"></see>
    /// </summary>
    let ``RailwayMilestone/key/railway/value/milestone`` =
        Namespaced_IRI.parse _namespace_name "RailwayMilestone/key/railway/value/milestone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayPhone"></see>
    /// </summary>
    let RailwayPhone =
        Namespaced_IRI.parse _namespace_name "RailwayPhone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayPhone/key/railway/value/phone"></see>
    /// </summary>
    let ``RailwayPhone/key/railway/value/phone`` =
        Namespaced_IRI.parse _namespace_name "RailwayPhone/key/railway/value/phone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayPlatform"></see>
    /// </summary>
    let RailwayPlatform =
        Namespaced_IRI.parse _namespace_name "RailwayPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayPlatform/key/railway/value/platform"></see>
    /// </summary>
    let ``RailwayPlatform/key/railway/value/platform`` =
        Namespaced_IRI.parse _namespace_name "RailwayPlatform/key/railway/value/platform" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayRoute"></see>
    /// </summary>
    let RailwayRoute =
        Namespaced_IRI.parse _namespace_name "RailwayRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayRoute/key/route/value/railway"></see>
    /// </summary>
    let ``RailwayRoute/key/route/value/railway`` =
        Namespaced_IRI.parse _namespace_name "RailwayRoute/key/route/value/railway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayStation"></see>
    /// </summary>
    let RailwayStation =
        Namespaced_IRI.parse _namespace_name "RailwayStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayStation/key/railway/value/station"></see>
    /// </summary>
    let ``RailwayStation/key/railway/value/station`` =
        Namespaced_IRI.parse _namespace_name "RailwayStation/key/railway/value/station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayStop"></see>
    /// </summary>
    let RailwayStop =
        Namespaced_IRI.parse _namespace_name "RailwayStop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayStop/key/railway/value/stop"></see>
    /// </summary>
    let ``RailwayStop/key/railway/value/stop`` =
        Namespaced_IRI.parse _namespace_name "RailwayStop/key/railway/value/stop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwaySwitch"></see>
    /// </summary>
    let RailwaySwitch =
        Namespaced_IRI.parse _namespace_name "RailwaySwitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwaySwitch/key/railway/value/switch"></see>
    /// </summary>
    let ``RailwaySwitch/key/railway/value/switch`` =
        Namespaced_IRI.parse _namespace_name "RailwaySwitch/key/railway/value/switch" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rapids"></see>
    /// </summary>
    let Rapids = Namespaced_IRI.parse _namespace_name "Rapids" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rapids/key/waterway/value/rapids"></see>
    /// </summary>
    let ``Rapids/key/waterway/value/rapids`` =
        Namespaced_IRI.parse _namespace_name "Rapids/key/waterway/value/rapids" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RealEstate"></see>
    /// </summary>
    let RealEstate = Namespaced_IRI.parse _namespace_name "RealEstate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RealEstate/key/shop/value/real_estate"></see>
    /// </summary>
    let ``RealEstate/key/shop/value/real_estate`` =
        Namespaced_IRI.parse _namespace_name "RealEstate/key/shop/value/real_estate" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ReceptionArea"></see>
    /// </summary>
    let ReceptionArea =
        Namespaced_IRI.parse _namespace_name "ReceptionArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ReceptionArea/key/amenity/value/reception_area"></see>
    /// </summary>
    let ``ReceptionArea/key/amenity/value/reception_area`` =
        Namespaced_IRI.parse _namespace_name "ReceptionArea/key/amenity/value/reception_area" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Records"></see>
    /// </summary>
    let Records = Namespaced_IRI.parse _namespace_name "Records" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Records/key/shop/value/records"></see>
    /// </summary>
    let ``Records/key/shop/value/records`` =
        Namespaced_IRI.parse _namespace_name "Records/key/shop/value/records" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RecreationGround"></see>
    /// </summary>
    let RecreationGround =
        Namespaced_IRI.parse _namespace_name "RecreationGround" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RecreationGround/key/landuse/value/recreation_ground"></see>
    /// </summary>
    let ``RecreationGround/key/landuse/value/recreation_ground`` =
        Namespaced_IRI.parse _namespace_name "RecreationGround/key/landuse/value/recreation_ground" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RecyclingFacility"></see>
    /// </summary>
    let RecyclingFacility =
        Namespaced_IRI.parse _namespace_name "RecyclingFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RecyclingFacility/key/amenity/value/recycling"></see>
    /// </summary>
    let ``RecyclingFacility/key/amenity/value/recycling`` =
        Namespaced_IRI.parse _namespace_name "RecyclingFacility/key/amenity/value/recycling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RedCross"></see>
    /// </summary>
    let RedCross = Namespaced_IRI.parse _namespace_name "RedCross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RedCross/key/amenity/value/red_cross"></see>
    /// </summary>
    let ``RedCross/key/amenity/value/red_cross`` =
        Namespaced_IRI.parse _namespace_name "RedCross/key/amenity/value/red_cross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reef"></see>
    /// </summary>
    let Reef = Namespaced_IRI.parse _namespace_name "Reef" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reef/key/natural/value/reef"></see>
    /// </summary>
    let ``Reef/key/natural/value/reef`` =
        Namespaced_IRI.parse _namespace_name "Reef/key/natural/value/reef" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Region/key/place/value/region"></see>
    /// </summary>
    let ``Region/key/place/value/region`` =
        Namespaced_IRI.parse _namespace_name "Region/key/place/value/region" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RegisterOffice"></see>
    /// </summary>
    let RegisterOffice =
        Namespaced_IRI.parse _namespace_name "RegisterOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RegisterOffice/key/amenity/value/register_office"></see>
    /// </summary>
    let ``RegisterOffice/key/amenity/value/register_office`` =
        Namespaced_IRI.parse _namespace_name "RegisterOffice/key/amenity/value/register_office" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RelayBox"></see>
    /// </summary>
    let RelayBox = Namespaced_IRI.parse _namespace_name "RelayBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RelayBox/key/amenity/value/relay_box"></see>
    /// </summary>
    let ``RelayBox/key/amenity/value/relay_box`` =
        Namespaced_IRI.parse _namespace_name "RelayBox/key/amenity/value/relay_box" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reportingpoint"></see>
    /// </summary>
    let Reportingpoint =
        Namespaced_IRI.parse _namespace_name "Reportingpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reportingpoint/key/aeroway/value/reportingpoint"></see>
    /// </summary>
    let ``Reportingpoint/key/aeroway/value/reportingpoint`` =
        Namespaced_IRI.parse _namespace_name "Reportingpoint/key/aeroway/value/reportingpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rescue"></see>
    /// </summary>
    let Rescue = Namespaced_IRI.parse _namespace_name "Rescue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rescue/key/amenity/value/rescue"></see>
    /// </summary>
    let ``Rescue/key/amenity/value/rescue`` =
        Namespaced_IRI.parse _namespace_name "Rescue/key/amenity/value/rescue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RescueBox"></see>
    /// </summary>
    let RescueBox = Namespaced_IRI.parse _namespace_name "RescueBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RescueBox/key/amenity/value/rescue_box"></see>
    /// </summary>
    let ``RescueBox/key/amenity/value/rescue_box`` =
        Namespaced_IRI.parse _namespace_name "RescueBox/key/amenity/value/rescue_box" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RescueService"></see>
    /// </summary>
    let RescueService =
        Namespaced_IRI.parse _namespace_name "RescueService" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RescueService/key/amenity/value/rescue_service"></see>
    /// </summary>
    let ``RescueService/key/amenity/value/rescue_service`` =
        Namespaced_IRI.parse _namespace_name "RescueService/key/amenity/value/rescue_service" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResearchOffice"></see>
    /// </summary>
    let ResearchOffice =
        Namespaced_IRI.parse _namespace_name "ResearchOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResearchOffice/key/office/value/research"></see>
    /// </summary>
    let ``ResearchOffice/key/office/value/research`` =
        Namespaced_IRI.parse _namespace_name "ResearchOffice/key/office/value/research" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reservoir"></see>
    /// </summary>
    let Reservoir = Namespaced_IRI.parse _namespace_name "Reservoir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reservoir/key/man_made/value/reservoir"></see>
    /// </summary>
    let ``Reservoir/key/man_made/value/reservoir`` =
        Namespaced_IRI.parse _namespace_name "Reservoir/key/man_made/value/reservoir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reservoir/key/landuse/value/reservoir"></see>
    /// </summary>
    let ``Reservoir/key/landuse/value/reservoir`` =
        Namespaced_IRI.parse _namespace_name "Reservoir/key/landuse/value/reservoir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Residential"></see>
    /// </summary>
    let Residential =
        Namespaced_IRI.parse _namespace_name "Residential" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Residential/key/amenity/value/residential"></see>
    /// </summary>
    let ``Residential/key/amenity/value/residential`` =
        Namespaced_IRI.parse _namespace_name "Residential/key/amenity/value/residential" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialHighway"></see>
    /// </summary>
    let ResidentialHighway =
        Namespaced_IRI.parse _namespace_name "ResidentialHighway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialHighway/key/highway/value/residential"></see>
    /// </summary>
    let ``ResidentialHighway/key/highway/value/residential`` =
        Namespaced_IRI.parse _namespace_name "ResidentialHighway/key/highway/value/residential" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialHome"></see>
    /// </summary>
    let ResidentialHome =
        Namespaced_IRI.parse _namespace_name "ResidentialHome" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialHome/key/amenity/value/residential_home"></see>
    /// </summary>
    let ``ResidentialHome/key/amenity/value/residential_home`` =
        Namespaced_IRI.parse _namespace_name "ResidentialHome/key/amenity/value/residential_home" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialLanduse"></see>
    /// </summary>
    let ResidentialLanduse =
        Namespaced_IRI.parse _namespace_name "ResidentialLanduse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialLanduse/key/landuse/value/residential"></see>
    /// </summary>
    let ``ResidentialLanduse/key/landuse/value/residential`` =
        Namespaced_IRI.parse _namespace_name "ResidentialLanduse/key/landuse/value/residential" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Resis"></see>
    /// </summary>
    let Resis = Namespaced_IRI.parse _namespace_name "Resis" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Resis/key/landuse/value/resis"></see>
    /// </summary>
    let ``Resis/key/landuse/value/resis`` =
        Namespaced_IRI.parse _namespace_name "Resis/key/landuse/value/resis" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RestArea"></see>
    /// </summary>
    let RestArea = Namespaced_IRI.parse _namespace_name "RestArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RestArea/key/highway/value/rest_area"></see>
    /// </summary>
    let ``RestArea/key/highway/value/rest_area`` =
        Namespaced_IRI.parse _namespace_name "RestArea/key/highway/value/rest_area" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Restaurant"></see>
    /// </summary>
    let Restaurant = Namespaced_IRI.parse _namespace_name "Restaurant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Restaurant/key/amenity/value/restaurant"></see>
    /// </summary>
    let ``Restaurant/key/amenity/value/restaurant`` =
        Namespaced_IRI.parse _namespace_name "Restaurant/key/amenity/value/restaurant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Restaurant%3Bpub"></see>
    /// </summary>
    let ``Restaurant%3Bpub`` =
        Namespaced_IRI.parse _namespace_name "Restaurant%3Bpub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Restaurant%3Bpub/key/amenity/value/restaurant%3Bpub"></see>
    /// </summary>
    let ``Restaurant%3Bpub/key/amenity/value/restaurant%3Bpub`` =
        Namespaced_IRI.parse _namespace_name "Restaurant%3Bpub/key/amenity/value/restaurant%3Bpub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Retail"></see>
    /// </summary>
    let Retail = Namespaced_IRI.parse _namespace_name "Retail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Retail/key/amenity/value/retail"></see>
    /// </summary>
    let ``Retail/key/amenity/value/retail`` =
        Namespaced_IRI.parse _namespace_name "Retail/key/amenity/value/retail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetailLanduse"></see>
    /// </summary>
    let RetailLanduse =
        Namespaced_IRI.parse _namespace_name "RetailLanduse" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetailLanduse/key/landuse/value/retail"></see>
    /// </summary>
    let ``RetailLanduse/key/landuse/value/retail`` =
        Namespaced_IRI.parse _namespace_name "RetailLanduse/key/landuse/value/retail" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetainingWall"></see>
    /// </summary>
    let RetainingWall =
        Namespaced_IRI.parse _namespace_name "RetainingWall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetainingWall/key/barrier/value/retaining_wall"></see>
    /// </summary>
    let ``RetainingWall/key/barrier/value/retaining_wall`` =
        Namespaced_IRI.parse _namespace_name "RetainingWall/key/barrier/value/retaining_wall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetirementHome"></see>
    /// </summary>
    let RetirementHome =
        Namespaced_IRI.parse _namespace_name "RetirementHome" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetirementHome/key/amenity/value/retirement_home"></see>
    /// </summary>
    let ``RetirementHome/key/amenity/value/retirement_home`` =
        Namespaced_IRI.parse _namespace_name "RetirementHome/key/amenity/value/retirement_home" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ridge"></see>
    /// </summary>
    let Ridge = Namespaced_IRI.parse _namespace_name "Ridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ridge/key/natural/value/ridge"></see>
    /// </summary>
    let ``Ridge/key/natural/value/ridge`` =
        Namespaced_IRI.parse _namespace_name "Ridge/key/natural/value/ridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rig"></see>
    /// </summary>
    let Rig = Namespaced_IRI.parse _namespace_name "Rig" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rig/key/man_made/value/rig"></see>
    /// </summary>
    let ``Rig/key/man_made/value/rig`` =
        Namespaced_IRI.parse _namespace_name "Rig/key/man_made/value/rig" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rigger"></see>
    /// </summary>
    let Rigger = Namespaced_IRI.parse _namespace_name "Rigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rigger/key/craft/value/rigger"></see>
    /// </summary>
    let ``Rigger/key/craft/value/rigger`` =
        Namespaced_IRI.parse _namespace_name "Rigger/key/craft/value/rigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/River"></see>
    /// </summary>
    let River = Namespaced_IRI.parse _namespace_name "River" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/River/key/waterway/value/river"></see>
    /// </summary>
    let ``River/key/waterway/value/river`` =
        Namespaced_IRI.parse _namespace_name "River/key/waterway/value/river" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Riverbank"></see>
    /// </summary>
    let Riverbank = Namespaced_IRI.parse _namespace_name "Riverbank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Riverbank/key/waterway/value/riverbank"></see>
    /// </summary>
    let ``Riverbank/key/waterway/value/riverbank`` =
        Namespaced_IRI.parse _namespace_name "Riverbank/key/waterway/value/riverbank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Road"></see>
    /// </summary>
    let Road = Namespaced_IRI.parse _namespace_name "Road" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Road/key/highway/value/road"></see>
    /// </summary>
    let ``Road/key/highway/value/road`` =
        Namespaced_IRI.parse _namespace_name "Road/key/highway/value/road" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RoadRoute"></see>
    /// </summary>
    let RoadRoute = Namespaced_IRI.parse _namespace_name "RoadRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RoadRoute/key/route/value/road"></see>
    /// </summary>
    let ``RoadRoute/key/route/value/road`` =
        Namespaced_IRI.parse _namespace_name "RoadRoute/key/route/value/road" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rocks"></see>
    /// </summary>
    let Rocks = Namespaced_IRI.parse _namespace_name "Rocks" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rocks/key/natural/value/rocks"></see>
    /// </summary>
    let ``Rocks/key/natural/value/rocks`` =
        Namespaced_IRI.parse _namespace_name "Rocks/key/natural/value/rocks" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Roofer"></see>
    /// </summary>
    let Roofer = Namespaced_IRI.parse _namespace_name "Roofer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Roofer/key/craft/value/roofer"></see>
    /// </summary>
    let ``Roofer/key/craft/value/roofer`` =
        Namespaced_IRI.parse _namespace_name "Roofer/key/craft/value/roofer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Roundabout"></see>
    /// </summary>
    let Roundabout = Namespaced_IRI.parse _namespace_name "Roundabout" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Roundabout/key/junction/value/roundabout"></see>
    /// </summary>
    let ``Roundabout/key/junction/value/roundabout`` =
        Namespaced_IRI.parse _namespace_name "Roundabout/key/junction/value/roundabout" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Route"></see>
    /// </summary>
    let Route = Namespaced_IRI.parse _namespace_name "Route" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Route/key/type/value/route"></see>
    /// </summary>
    let ``Route/key/type/value/route`` =
        Namespaced_IRI.parse _namespace_name "Route/key/type/value/route" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ruins"></see>
    /// </summary>
    let Ruins = Namespaced_IRI.parse _namespace_name "Ruins" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ruins/key/historic/value/ruins"></see>
    /// </summary>
    let ``Ruins/key/historic/value/ruins`` =
        Namespaced_IRI.parse _namespace_name "Ruins/key/historic/value/ruins" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RumbleStrip"></see>
    /// </summary>
    let RumbleStrip =
        Namespaced_IRI.parse _namespace_name "RumbleStrip" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RumbleStrip/key/traffic_calming/value/rumble_strip"></see>
    /// </summary>
    let ``RumbleStrip/key/traffic_calming/value/rumble_strip`` =
        Namespaced_IRI.parse _namespace_name "RumbleStrip/key/traffic_calming/value/rumble_strip" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RuneStone"></see>
    /// </summary>
    let RuneStone = Namespaced_IRI.parse _namespace_name "RuneStone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RuneStone/key/historic/value/rune_stone%20"></see>
    /// </summary>
    let ``RuneStone/key/historic/value/rune_stone%20`` =
        Namespaced_IRI.parse _namespace_name "RuneStone/key/historic/value/rune_stone%20" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Runway"></see>
    /// </summary>
    let Runway = Namespaced_IRI.parse _namespace_name "Runway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Runway/key/aeroway/value/runway"></see>
    /// </summary>
    let ``Runway/key/aeroway/value/runway`` =
        Namespaced_IRI.parse _namespace_name "Runway/key/aeroway/value/runway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sa"></see>
    /// </summary>
    let Sa = Namespaced_IRI.parse _namespace_name "Sa" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sa/key/natural/value/sa"></see>
    /// </summary>
    let ``Sa/key/natural/value/sa`` =
        Namespaced_IRI.parse _namespace_name "Sa/key/natural/value/sa" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Saddler"></see>
    /// </summary>
    let Saddler = Namespaced_IRI.parse _namespace_name "Saddler" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Saddler/key/craft/value/saddler"></see>
    /// </summary>
    let ``Saddler/key/craft/value/saddler`` =
        Namespaced_IRI.parse _namespace_name "Saddler/key/craft/value/saddler" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SailingClub"></see>
    /// </summary>
    let SailingClub =
        Namespaced_IRI.parse _namespace_name "SailingClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SailingClub/key/leisure/value/sailing_club"></see>
    /// </summary>
    let ``SailingClub/key/leisure/value/sailing_club`` =
        Namespaced_IRI.parse _namespace_name "SailingClub/key/leisure/value/sailing_club" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sailmaker"></see>
    /// </summary>
    let Sailmaker = Namespaced_IRI.parse _namespace_name "Sailmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sailmaker/key/craft/value/sailmaker"></see>
    /// </summary>
    let ``Sailmaker/key/craft/value/sailmaker`` =
        Namespaced_IRI.parse _namespace_name "Sailmaker/key/craft/value/sailmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SaintsCross"></see>
    /// </summary>
    let SaintsCross =
        Namespaced_IRI.parse _namespace_name "SaintsCross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SaintsCross/key/historic/value/saints_cross"></see>
    /// </summary>
    let ``SaintsCross/key/historic/value/saints_cross`` =
        Namespaced_IRI.parse _namespace_name "SaintsCross/key/historic/value/saints_cross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SallyPort"></see>
    /// </summary>
    let SallyPort = Namespaced_IRI.parse _namespace_name "SallyPort" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SallyPort/key/barrier/value/sally_port"></see>
    /// </summary>
    let ``SallyPort/key/barrier/value/sally_port`` =
        Namespaced_IRI.parse _namespace_name "SallyPort/key/barrier/value/sally_port" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Salon"></see>
    /// </summary>
    let Salon = Namespaced_IRI.parse _namespace_name "Salon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Salon/key/shop/value/salon"></see>
    /// </summary>
    let ``Salon/key/shop/value/salon`` =
        Namespaced_IRI.parse _namespace_name "Salon/key/shop/value/salon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Salon/key/amenity/value/salon"></see>
    /// </summary>
    let ``Salon/key/amenity/value/salon`` =
        Namespaced_IRI.parse _namespace_name "Salon/key/amenity/value/salon" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SaltPond"></see>
    /// </summary>
    let SaltPond = Namespaced_IRI.parse _namespace_name "SaltPond" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SaltPond/key/landuse/value/salt_pond"></see>
    /// </summary>
    let ``SaltPond/key/landuse/value/salt_pond`` =
        Namespaced_IRI.parse _namespace_name "SaltPond/key/landuse/value/salt_pond" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sand"></see>
    /// </summary>
    let Sand = Namespaced_IRI.parse _namespace_name "Sand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sand/key/natural/value/sand"></see>
    /// </summary>
    let ``Sand/key/natural/value/sand`` =
        Namespaced_IRI.parse _namespace_name "Sand/key/natural/value/sand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sauna"></see>
    /// </summary>
    let Sauna = Namespaced_IRI.parse _namespace_name "Sauna" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sauna/key/leisure/value/sauna"></see>
    /// </summary>
    let ``Sauna/key/leisure/value/sauna`` =
        Namespaced_IRI.parse _namespace_name "Sauna/key/leisure/value/sauna" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sauna/key/amenity/value/sauna"></see>
    /// </summary>
    let ``Sauna/key/amenity/value/sauna`` =
        Namespaced_IRI.parse _namespace_name "Sauna/key/amenity/value/sauna" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sawmill"></see>
    /// </summary>
    let Sawmill = Namespaced_IRI.parse _namespace_name "Sawmill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sawmill/key/craft/value/sawmill"></see>
    /// </summary>
    let ``Sawmill/key/craft/value/sawmill`` =
        Namespaced_IRI.parse _namespace_name "Sawmill/key/craft/value/sawmill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scaffolder"></see>
    /// </summary>
    let Scaffolder = Namespaced_IRI.parse _namespace_name "Scaffolder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scaffolder/key/craft/value/scaffolder"></see>
    /// </summary>
    let ``Scaffolder/key/craft/value/scaffolder`` =
        Namespaced_IRI.parse _namespace_name "Scaffolder/key/craft/value/scaffolder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/School"></see>
    /// </summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/School/key/amenity/value/school"></see>
    /// </summary>
    let ``School/key/amenity/value/school`` =
        Namespaced_IRI.parse _namespace_name "School/key/amenity/value/school" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScoutHall"></see>
    /// </summary>
    let ScoutHall = Namespaced_IRI.parse _namespace_name "ScoutHall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScoutHall/key/amenity/value/scout_hall"></see>
    /// </summary>
    let ``ScoutHall/key/amenity/value/scout_hall`` =
        Namespaced_IRI.parse _namespace_name "ScoutHall/key/amenity/value/scout_hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScoutHut"></see>
    /// </summary>
    let ScoutHut = Namespaced_IRI.parse _namespace_name "ScoutHut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScoutHut/key/amenity/value/scout_hut"></see>
    /// </summary>
    let ``ScoutHut/key/amenity/value/scout_hut`` =
        Namespaced_IRI.parse _namespace_name "ScoutHut/key/amenity/value/scout_hut" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scree"></see>
    /// </summary>
    let Scree = Namespaced_IRI.parse _namespace_name "Scree" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scree/key/natural/value/scree"></see>
    /// </summary>
    let ``Scree/key/natural/value/scree`` =
        Namespaced_IRI.parse _namespace_name "Scree/key/natural/value/scree" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scrub"></see>
    /// </summary>
    let Scrub = Namespaced_IRI.parse _namespace_name "Scrub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scrub/key/natural/value/scrub"></see>
    /// </summary>
    let ``Scrub/key/natural/value/scrub`` =
        Namespaced_IRI.parse _namespace_name "Scrub/key/natural/value/scrub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScubaDivingShop"></see>
    /// </summary>
    let ScubaDivingShop =
        Namespaced_IRI.parse _namespace_name "ScubaDivingShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScubaDivingShop/key/shop/value/scuba_diving"></see>
    /// </summary>
    let ``ScubaDivingShop/key/shop/value/scuba_diving`` =
        Namespaced_IRI.parse _namespace_name "ScubaDivingShop/key/shop/value/scuba_diving" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sculptor"></see>
    /// </summary>
    let Sculptor = Namespaced_IRI.parse _namespace_name "Sculptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sculptor/key/craft/value/sculptor"></see>
    /// </summary>
    let ``Sculptor/key/craft/value/sculptor`` =
        Namespaced_IRI.parse _namespace_name "Sculptor/key/craft/value/sculptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sea"></see>
    /// </summary>
    let Sea = Namespaced_IRI.parse _namespace_name "Sea" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sea/key/natural/value/sea"></see>
    /// </summary>
    let ``Sea/key/natural/value/sea`` =
        Namespaced_IRI.parse _namespace_name "Sea/key/natural/value/sea" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Seat"></see>
    /// </summary>
    let Seat = Namespaced_IRI.parse _namespace_name "Seat" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Seat/key/amenity/value/seat"></see>
    /// </summary>
    let ``Seat/key/amenity/value/seat`` =
        Namespaced_IRI.parse _namespace_name "Seat/key/amenity/value/seat" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Seating%2Cornamental"></see>
    /// </summary>
    let ``Seating%2Cornamental`` =
        Namespaced_IRI.parse _namespace_name "Seating%2Cornamental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Seating%2Cornamental/key/amenity/value/seating%2Cornamental"></see>
    /// </summary>
    let ``Seating%2Cornamental/key/amenity/value/seating%2Cornamental`` =
        Namespaced_IRI.parse _namespace_name "Seating%2Cornamental/key/amenity/value/seating%2Cornamental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SecondHand"></see>
    /// </summary>
    let SecondHand = Namespaced_IRI.parse _namespace_name "SecondHand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SecondHand/key/shop/value/second_hand"></see>
    /// </summary>
    let ``SecondHand/key/shop/value/second_hand`` =
        Namespaced_IRI.parse _namespace_name "SecondHand/key/shop/value/second_hand" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SecundaryHighway"></see>
    /// </summary>
    let SecundaryHighway =
        Namespaced_IRI.parse _namespace_name "SecundaryHighway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SecundaryHighway/key/highway/value/secundary"></see>
    /// </summary>
    let ``SecundaryHighway/key/highway/value/secundary`` =
        Namespaced_IRI.parse _namespace_name "SecundaryHighway/key/highway/value/secundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sento"></see>
    /// </summary>
    let Sento = Namespaced_IRI.parse _namespace_name "Sento" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sento/key/amenity/value/sento"></see>
    /// </summary>
    let ``Sento/key/amenity/value/sento`` =
        Namespaced_IRI.parse _namespace_name "Sento/key/amenity/value/sento" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Service"></see>
    /// </summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Service/key/amenity/value/service"></see>
    /// </summary>
    let ``Service/key/amenity/value/service`` =
        Namespaced_IRI.parse _namespace_name "Service/key/amenity/value/service" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServiceAreaInterface"></see>
    /// </summary>
    let ServiceAreaInterface =
        Namespaced_IRI.parse _namespace_name "ServiceAreaInterface" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServiceAreaInterface/key/man_made/value/service_area_interface"></see>
    /// </summary>
    let ``ServiceAreaInterface/key/man_made/value/service_area_interface`` =
        Namespaced_IRI.parse _namespace_name "ServiceAreaInterface/key/man_made/value/service_area_interface" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServiceStation"></see>
    /// </summary>
    let ServiceStation =
        Namespaced_IRI.parse _namespace_name "ServiceStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServiceStation/key/highway/value/services"></see>
    /// </summary>
    let ``ServiceStation/key/highway/value/services`` =
        Namespaced_IRI.parse _namespace_name "ServiceStation/key/highway/value/services" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Services"></see>
    /// </summary>
    let Services = Namespaced_IRI.parse _namespace_name "Services" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Services/key/amenity/value/services"></see>
    /// </summary>
    let ``Services/key/amenity/value/services`` =
        Namespaced_IRI.parse _namespace_name "Services/key/amenity/value/services" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServingAreaInterface"></see>
    /// </summary>
    let ServingAreaInterface =
        Namespaced_IRI.parse _namespace_name "ServingAreaInterface" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServingAreaInterface/key/man_made/value/serving_area_interface"></see>
    /// </summary>
    let ``ServingAreaInterface/key/man_made/value/serving_area_interface`` =
        Namespaced_IRI.parse _namespace_name "ServingAreaInterface/key/man_made/value/serving_area_interface" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SesStation"></see>
    /// </summary>
    let SesStation = Namespaced_IRI.parse _namespace_name "SesStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SesStation/key/emergency/value/ses_station"></see>
    /// </summary>
    let ``SesStation/key/emergency/value/ses_station`` =
        Namespaced_IRI.parse _namespace_name "SesStation/key/emergency/value/ses_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shed"></see>
    /// </summary>
    let Shed = Namespaced_IRI.parse _namespace_name "Shed" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shed/key/building/value/shed"></see>
    /// </summary>
    let ``Shed/key/building/value/shed`` =
        Namespaced_IRI.parse _namespace_name "Shed/key/building/value/shed" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sheepfold"></see>
    /// </summary>
    let Sheepfold = Namespaced_IRI.parse _namespace_name "Sheepfold" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sheepfold/key/man_made/value/sheepfold"></see>
    /// </summary>
    let ``Sheepfold/key/man_made/value/sheepfold`` =
        Namespaced_IRI.parse _namespace_name "Sheepfold/key/man_made/value/sheepfold" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shelter"></see>
    /// </summary>
    let Shelter = Namespaced_IRI.parse _namespace_name "Shelter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shelter/key/amenity/value/shelter"></see>
    /// </summary>
    let ``Shelter/key/amenity/value/shelter`` =
        Namespaced_IRI.parse _namespace_name "Shelter/key/amenity/value/shelter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShelteredHousing"></see>
    /// </summary>
    let ShelteredHousing =
        Namespaced_IRI.parse _namespace_name "ShelteredHousing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShelteredHousing/key/amenity/value/sheltered_housing"></see>
    /// </summary>
    let ``ShelteredHousing/key/amenity/value/sheltered_housing`` =
        Namespaced_IRI.parse _namespace_name "ShelteredHousing/key/amenity/value/sheltered_housing" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shipping"></see>
    /// </summary>
    let Shipping = Namespaced_IRI.parse _namespace_name "Shipping" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shipping/key/shop/value/shipping"></see>
    /// </summary>
    let ``Shipping/key/shop/value/shipping`` =
        Namespaced_IRI.parse _namespace_name "Shipping/key/shop/value/shipping" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoal"></see>
    /// </summary>
    let Shoal = Namespaced_IRI.parse _namespace_name "Shoal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoal/key/natural/value/shoal"></see>
    /// </summary>
    let ``Shoal/key/natural/value/shoal`` =
        Namespaced_IRI.parse _namespace_name "Shoal/key/natural/value/shoal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoeRepair"></see>
    /// </summary>
    let ShoeRepair = Namespaced_IRI.parse _namespace_name "ShoeRepair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoeRepair/key/shop/value/shoe_repair"></see>
    /// </summary>
    let ``ShoeRepair/key/shop/value/shoe_repair`` =
        Namespaced_IRI.parse _namespace_name "ShoeRepair/key/shop/value/shoe_repair" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoemaker"></see>
    /// </summary>
    let Shoemaker = Namespaced_IRI.parse _namespace_name "Shoemaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoemaker/key/shop/value/shoemaker"></see>
    /// </summary>
    let ``Shoemaker/key/shop/value/shoemaker`` =
        Namespaced_IRI.parse _namespace_name "Shoemaker/key/shop/value/shoemaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoemaker/key/craft/value/shoemaker"></see>
    /// </summary>
    let ``Shoemaker/key/craft/value/shoemaker`` =
        Namespaced_IRI.parse _namespace_name "Shoemaker/key/craft/value/shoemaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoes"></see>
    /// </summary>
    let Shoes = Namespaced_IRI.parse _namespace_name "Shoes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoes/key/shop/value/shoes"></see>
    /// </summary>
    let ``Shoes/key/shop/value/shoes`` =
        Namespaced_IRI.parse _namespace_name "Shoes/key/shop/value/shoes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shop/key/amenity/value/shop"></see>
    /// </summary>
    let ``Shop/key/amenity/value/shop`` =
        Namespaced_IRI.parse _namespace_name "Shop/key/amenity/value/shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shop/key/shop/value/yes"></see>
    /// </summary>
    let ``Shop/key/shop/value/yes`` =
        Namespaced_IRI.parse _namespace_name "Shop/key/shop/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shop/key/shop/value/shop"></see>
    /// </summary>
    let ``Shop/key/shop/value/shop`` =
        Namespaced_IRI.parse _namespace_name "Shop/key/shop/value/shop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShopFIXME"></see>
    /// </summary>
    let ShopFIXME = Namespaced_IRI.parse _namespace_name "ShopFIXME" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShopFIXME/key/shop/value/FIXME"></see>
    /// </summary>
    let ``ShopFIXME/key/shop/value/FIXME`` =
        Namespaced_IRI.parse _namespace_name "ShopFIXME/key/shop/value/FIXME" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShopFixme"></see>
    /// </summary>
    let ShopFixme = Namespaced_IRI.parse _namespace_name "ShopFixme" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShopFixme/key/shop/value/fixme"></see>
    /// </summary>
    let ``ShopFixme/key/shop/value/fixme`` =
        Namespaced_IRI.parse _namespace_name "ShopFixme/key/shop/value/fixme" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shopping"></see>
    /// </summary>
    let Shopping = Namespaced_IRI.parse _namespace_name "Shopping" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shopping/key/amenity/value/shopping"></see>
    /// </summary>
    let ``Shopping/key/amenity/value/shopping`` =
        Namespaced_IRI.parse _namespace_name "Shopping/key/amenity/value/shopping" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoppingCenter"></see>
    /// </summary>
    let ShoppingCenter =
        Namespaced_IRI.parse _namespace_name "ShoppingCenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoppingCenter/key/shop/value/shopping_center"></see>
    /// </summary>
    let ``ShoppingCenter/key/shop/value/shopping_center`` =
        Namespaced_IRI.parse _namespace_name "ShoppingCenter/key/shop/value/shopping_center" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoppingCentre"></see>
    /// </summary>
    let ShoppingCentre =
        Namespaced_IRI.parse _namespace_name "ShoppingCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoppingCentre/key/shop/value/shopping_centre"></see>
    /// </summary>
    let ``ShoppingCentre/key/shop/value/shopping_centre`` =
        Namespaced_IRI.parse _namespace_name "ShoppingCentre/key/shop/value/shopping_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shops"></see>
    /// </summary>
    let Shops = Namespaced_IRI.parse _namespace_name "Shops" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shops/key/amenity/value/shops"></see>
    /// </summary>
    let ``Shops/key/amenity/value/shops`` =
        Namespaced_IRI.parse _namespace_name "Shops/key/amenity/value/shops" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shower"></see>
    /// </summary>
    let Shower = Namespaced_IRI.parse _namespace_name "Shower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shower/key/amenity/value/shower"></see>
    /// </summary>
    let ``Shower/key/amenity/value/shower`` =
        Namespaced_IRI.parse _namespace_name "Shower/key/amenity/value/shower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Showers"></see>
    /// </summary>
    let Showers = Namespaced_IRI.parse _namespace_name "Showers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Showers/key/amenity/value/showers"></see>
    /// </summary>
    let ``Showers/key/amenity/value/showers`` =
        Namespaced_IRI.parse _namespace_name "Showers/key/amenity/value/showers" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Signal"></see>
    /// </summary>
    let Signal = Namespaced_IRI.parse _namespace_name "Signal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Signal/key/railway/value/signal"></see>
    /// </summary>
    let ``Signal/key/railway/value/signal`` =
        Namespaced_IRI.parse _namespace_name "Signal/key/railway/value/signal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Signpost"></see>
    /// </summary>
    let Signpost = Namespaced_IRI.parse _namespace_name "Signpost" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Signpost/key/amenity/value/signpost"></see>
    /// </summary>
    let ``Signpost/key/amenity/value/signpost`` =
        Namespaced_IRI.parse _namespace_name "Signpost/key/amenity/value/signpost" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Silo"></see>
    /// </summary>
    let Silo = Namespaced_IRI.parse _namespace_name "Silo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Silo/key/man_made/value/silo"></see>
    /// </summary>
    let ``Silo/key/man_made/value/silo`` =
        Namespaced_IRI.parse _namespace_name "Silo/key/man_made/value/silo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkatePark"></see>
    /// </summary>
    let SkatePark = Namespaced_IRI.parse _namespace_name "SkatePark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkatePark/key/leisure/value/skate_park"></see>
    /// </summary>
    let ``SkatePark/key/leisure/value/skate_park`` =
        Namespaced_IRI.parse _namespace_name "SkatePark/key/leisure/value/skate_park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiRental"></see>
    /// </summary>
    let SkiRental = Namespaced_IRI.parse _namespace_name "SkiRental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiRental/key/amenity/value/ski_rental"></see>
    /// </summary>
    let ``SkiRental/key/amenity/value/ski_rental`` =
        Namespaced_IRI.parse _namespace_name "SkiRental/key/amenity/value/ski_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiRoute"></see>
    /// </summary>
    let SkiRoute = Namespaced_IRI.parse _namespace_name "SkiRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiRoute/key/route/value/ski"></see>
    /// </summary>
    let ``SkiRoute/key/route/value/ski`` =
        Namespaced_IRI.parse _namespace_name "SkiRoute/key/route/value/ski" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiSchool"></see>
    /// </summary>
    let SkiSchool = Namespaced_IRI.parse _namespace_name "SkiSchool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiSchool/key/amenity/value/ski_school"></see>
    /// </summary>
    let ``SkiSchool/key/amenity/value/ski_school`` =
        Namespaced_IRI.parse _namespace_name "SkiSchool/key/amenity/value/ski_school" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Slipway"></see>
    /// </summary>
    let Slipway = Namespaced_IRI.parse _namespace_name "Slipway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Slipway/key/leisure/value/slipway"></see>
    /// </summary>
    let ``Slipway/key/leisure/value/slipway`` =
        Namespaced_IRI.parse _namespace_name "Slipway/key/leisure/value/slipway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sluice"></see>
    /// </summary>
    let Sluice = Namespaced_IRI.parse _namespace_name "Sluice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sluice/key/waterway/value/sluice"></see>
    /// </summary>
    let ``Sluice/key/waterway/value/sluice`` =
        Namespaced_IRI.parse _namespace_name "Sluice/key/waterway/value/sluice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Snacks"></see>
    /// </summary>
    let Snacks = Namespaced_IRI.parse _namespace_name "Snacks" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Snacks/key/shop/value/snacks"></see>
    /// </summary>
    let ``Snacks/key/shop/value/snacks`` =
        Namespaced_IRI.parse _namespace_name "Snacks/key/shop/value/snacks" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SnowPark"></see>
    /// </summary>
    let SnowPark = Namespaced_IRI.parse _namespace_name "SnowPark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SnowPark/key/amenity/value/snow_park"></see>
    /// </summary>
    let ``SnowPark/key/amenity/value/snow_park`` =
        Namespaced_IRI.parse _namespace_name "SnowPark/key/amenity/value/snow_park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialCentre"></see>
    /// </summary>
    let SocialCentre =
        Namespaced_IRI.parse _namespace_name "SocialCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialCentre/key/amenity/value/social_centre"></see>
    /// </summary>
    let ``SocialCentre/key/amenity/value/social_centre`` =
        Namespaced_IRI.parse _namespace_name "SocialCentre/key/amenity/value/social_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialClub"></see>
    /// </summary>
    let SocialClub = Namespaced_IRI.parse _namespace_name "SocialClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialClub/key/amenity/value/social_club"></see>
    /// </summary>
    let ``SocialClub/key/amenity/value/social_club`` =
        Namespaced_IRI.parse _namespace_name "SocialClub/key/amenity/value/social_club" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialClub/key/leisure/value/social_club"></see>
    /// </summary>
    let ``SocialClub/key/leisure/value/social_club`` =
        Namespaced_IRI.parse _namespace_name "SocialClub/key/leisure/value/social_club" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialFacility"></see>
    /// </summary>
    let SocialFacility =
        Namespaced_IRI.parse _namespace_name "SocialFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialFacility/key/amenity/value/social_facility"></see>
    /// </summary>
    let ``SocialFacility/key/amenity/value/social_facility`` =
        Namespaced_IRI.parse _namespace_name "SocialFacility/key/amenity/value/social_facility" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialServices"></see>
    /// </summary>
    let SocialServices =
        Namespaced_IRI.parse _namespace_name "SocialServices" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialServices/key/amenity/value/social_services"></see>
    /// </summary>
    let ``SocialServices/key/amenity/value/social_services`` =
        Namespaced_IRI.parse _namespace_name "SocialServices/key/amenity/value/social_services" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Solarium"></see>
    /// </summary>
    let Solarium = Namespaced_IRI.parse _namespace_name "Solarium" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Solarium/key/amenity/value/solarium"></see>
    /// </summary>
    let ``Solarium/key/amenity/value/solarium`` =
        Namespaced_IRI.parse _namespace_name "Solarium/key/amenity/value/solarium" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Solarium/key/shop/value/solarium"></see>
    /// </summary>
    let ``Solarium/key/shop/value/solarium`` =
        Namespaced_IRI.parse _namespace_name "Solarium/key/shop/value/solarium" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Souvenir"></see>
    /// </summary>
    let Souvenir = Namespaced_IRI.parse _namespace_name "Souvenir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Souvenir/key/shop/value/souvenir"></see>
    /// </summary>
    let ``Souvenir/key/shop/value/souvenir`` =
        Namespaced_IRI.parse _namespace_name "Souvenir/key/shop/value/souvenir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Souvenirs"></see>
    /// </summary>
    let Souvenirs = Namespaced_IRI.parse _namespace_name "Souvenirs" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Souvenirs/key/shop/value/souvenirs"></see>
    /// </summary>
    let ``Souvenirs/key/shop/value/souvenirs`` =
        Namespaced_IRI.parse _namespace_name "Souvenirs/key/shop/value/souvenirs" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Spa"></see>
    /// </summary>
    let Spa = Namespaced_IRI.parse _namespace_name "Spa" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Spa/key/amenity/value/spa"></see>
    /// </summary>
    let ``Spa/key/amenity/value/spa`` =
        Namespaced_IRI.parse _namespace_name "Spa/key/amenity/value/spa" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedCamera"></see>
    /// </summary>
    let SpeedCamera =
        Namespaced_IRI.parse _namespace_name "SpeedCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedCamera/key/highway/value/speed_camera"></see>
    /// </summary>
    let ``SpeedCamera/key/highway/value/speed_camera`` =
        Namespaced_IRI.parse _namespace_name "SpeedCamera/key/highway/value/speed_camera" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedEnforcement"></see>
    /// </summary>
    let SpeedEnforcement =
        Namespaced_IRI.parse _namespace_name "SpeedEnforcement" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedEnforcement/key/amenity/value/speed_enforcement"></see>
    /// </summary>
    let ``SpeedEnforcement/key/amenity/value/speed_enforcement`` =
        Namespaced_IRI.parse _namespace_name "SpeedEnforcement/key/amenity/value/speed_enforcement" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedTrap"></see>
    /// </summary>
    let SpeedTrap = Namespaced_IRI.parse _namespace_name "SpeedTrap" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedTrap/key/amenity/value/speed_trap"></see>
    /// </summary>
    let ``SpeedTrap/key/amenity/value/speed_trap`` =
        Namespaced_IRI.parse _namespace_name "SpeedTrap/key/amenity/value/speed_trap" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sport"></see>
    /// </summary>
    let Sport = Namespaced_IRI.parse _namespace_name "Sport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sport/key/leisure/value/sport"></see>
    /// </summary>
    let ``Sport/key/leisure/value/sport`` =
        Namespaced_IRI.parse _namespace_name "Sport/key/leisure/value/sport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sport/key/amenity/value/sport"></see>
    /// </summary>
    let ``Sport/key/amenity/value/sport`` =
        Namespaced_IRI.parse _namespace_name "Sport/key/amenity/value/sport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportShop"></see>
    /// </summary>
    let SportShop = Namespaced_IRI.parse _namespace_name "SportShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportShop/key/shop/value/sport"></see>
    /// </summary>
    let ``SportShop/key/shop/value/sport`` =
        Namespaced_IRI.parse _namespace_name "SportShop/key/shop/value/sport" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportThing"></see>
    /// </summary>
    let SportThing = Namespaced_IRI.parse _namespace_name "SportThing" |> NamespacedName
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sports"></see>
    /// </summary>
    let Sports = Namespaced_IRI.parse _namespace_name "Sports" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sports/key/shop/value/sports"></see>
    /// </summary>
    let ``Sports/key/shop/value/sports`` =
        Namespaced_IRI.parse _namespace_name "Sports/key/shop/value/sports" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportsCentre"></see>
    /// </summary>
    let SportsCentre =
        Namespaced_IRI.parse _namespace_name "SportsCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportsCentre/key/leisure/value/sports_centre"></see>
    /// </summary>
    let ``SportsCentre/key/leisure/value/sports_centre`` =
        Namespaced_IRI.parse _namespace_name "SportsCentre/key/leisure/value/sports_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportsCentre/key/amenity/value/sports_centre"></see>
    /// </summary>
    let ``SportsCentre/key/amenity/value/sports_centre`` =
        Namespaced_IRI.parse _namespace_name "SportsCentre/key/amenity/value/sports_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Spring"></see>
    /// </summary>
    let Spring = Namespaced_IRI.parse _namespace_name "Spring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Spring/key/natural/value/spring"></see>
    /// </summary>
    let ``Spring/key/natural/value/spring`` =
        Namespaced_IRI.parse _namespace_name "Spring/key/natural/value/spring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stadium"></see>
    /// </summary>
    let Stadium = Namespaced_IRI.parse _namespace_name "Stadium" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stadium/key/leisure/value/stadium"></see>
    /// </summary>
    let ``Stadium/key/leisure/value/stadium`` =
        Namespaced_IRI.parse _namespace_name "Stadium/key/leisure/value/stadium" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StandBuilder"></see>
    /// </summary>
    let StandBuilder =
        Namespaced_IRI.parse _namespace_name "StandBuilder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StandBuilder/key/craft/value/stand_builder"></see>
    /// </summary>
    let ``StandBuilder/key/craft/value/stand_builder`` =
        Namespaced_IRI.parse _namespace_name "StandBuilder/key/craft/value/stand_builder" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/State/key/place/value/state"></see>
    /// </summary>
    let ``State/key/place/value/state`` =
        Namespaced_IRI.parse _namespace_name "State/key/place/value/state" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Station"></see>
    /// </summary>
    let Station = Namespaced_IRI.parse _namespace_name "Station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Station/key/public_transport/value/station"></see>
    /// </summary>
    let ``Station/key/public_transport/value/station`` =
        Namespaced_IRI.parse _namespace_name "Station/key/public_transport/value/station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StationEntrance"></see>
    /// </summary>
    let StationEntrance =
        Namespaced_IRI.parse _namespace_name "StationEntrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StationEntrance/key/railway/value/station_entrance"></see>
    /// </summary>
    let ``StationEntrance/key/railway/value/station_entrance`` =
        Namespaced_IRI.parse _namespace_name "StationEntrance/key/railway/value/station_entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stationary"></see>
    /// </summary>
    let Stationary = Namespaced_IRI.parse _namespace_name "Stationary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stationary/key/shop/value/stationary"></see>
    /// </summary>
    let ``Stationary/key/shop/value/stationary`` =
        Namespaced_IRI.parse _namespace_name "Stationary/key/shop/value/stationary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stationery"></see>
    /// </summary>
    let Stationery = Namespaced_IRI.parse _namespace_name "Stationery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stationery/key/shop/value/stationery"></see>
    /// </summary>
    let ``Stationery/key/shop/value/stationery`` =
        Namespaced_IRI.parse _namespace_name "Stationery/key/shop/value/stationery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Statue"></see>
    /// </summary>
    let Statue = Namespaced_IRI.parse _namespace_name "Statue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Statue/key/amenity/value/statue"></see>
    /// </summary>
    let ``Statue/key/amenity/value/statue`` =
        Namespaced_IRI.parse _namespace_name "Statue/key/amenity/value/statue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Steps"></see>
    /// </summary>
    let Steps = Namespaced_IRI.parse _namespace_name "Steps" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Steps/key/highway/value/steps"></see>
    /// </summary>
    let ``Steps/key/highway/value/steps`` =
        Namespaced_IRI.parse _namespace_name "Steps/key/highway/value/steps" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stile"></see>
    /// </summary>
    let Stile = Namespaced_IRI.parse _namespace_name "Stile" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stile/key/barrier/value/stile"></see>
    /// </summary>
    let ``Stile/key/barrier/value/stile`` =
        Namespaced_IRI.parse _namespace_name "Stile/key/barrier/value/stile" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stone"></see>
    /// </summary>
    let Stone = Namespaced_IRI.parse _namespace_name "Stone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stone/key/natural/value/stone"></see>
    /// </summary>
    let ``Stone/key/natural/value/stone`` =
        Namespaced_IRI.parse _namespace_name "Stone/key/natural/value/stone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StoneCircle"></see>
    /// </summary>
    let StoneCircle =
        Namespaced_IRI.parse _namespace_name "StoneCircle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StoneCircle/key/historic/value/stone_circle"></see>
    /// </summary>
    let ``StoneCircle/key/historic/value/stone_circle`` =
        Namespaced_IRI.parse _namespace_name "StoneCircle/key/historic/value/stone_circle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stonemason"></see>
    /// </summary>
    let Stonemason = Namespaced_IRI.parse _namespace_name "Stonemason" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stonemason/key/craft/value/stonemason"></see>
    /// </summary>
    let ``Stonemason/key/craft/value/stonemason`` =
        Namespaced_IRI.parse _namespace_name "Stonemason/key/craft/value/stonemason" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StopPosition"></see>
    /// </summary>
    let StopPosition =
        Namespaced_IRI.parse _namespace_name "StopPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StopPosition/key/public_transport/value/stop_position"></see>
    /// </summary>
    let ``StopPosition/key/public_transport/value/stop_position`` =
        Namespaced_IRI.parse _namespace_name "StopPosition/key/public_transport/value/stop_position" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StopSign"></see>
    /// </summary>
    let StopSign = Namespaced_IRI.parse _namespace_name "StopSign" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StopSign/key/highway/value/stop"></see>
    /// </summary>
    let ``StopSign/key/highway/value/stop`` =
        Namespaced_IRI.parse _namespace_name "StopSign/key/highway/value/stop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Storage"></see>
    /// </summary>
    let Storage = Namespaced_IRI.parse _namespace_name "Storage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Storage/key/amenity/value/storage"></see>
    /// </summary>
    let ``Storage/key/amenity/value/storage`` =
        Namespaced_IRI.parse _namespace_name "Storage/key/amenity/value/storage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StorageTank"></see>
    /// </summary>
    let StorageTank =
        Namespaced_IRI.parse _namespace_name "StorageTank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StorageTank/key/man_made/value/storage_tank"></see>
    /// </summary>
    let ``StorageTank/key/man_made/value/storage_tank`` =
        Namespaced_IRI.parse _namespace_name "StorageTank/key/man_made/value/storage_tank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Strait"></see>
    /// </summary>
    let Strait = Namespaced_IRI.parse _namespace_name "Strait" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Strait/key/natural/value/strait"></see>
    /// </summary>
    let ``Strait/key/natural/value/strait`` =
        Namespaced_IRI.parse _namespace_name "Strait/key/natural/value/strait" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stream"></see>
    /// </summary>
    let Stream = Namespaced_IRI.parse _namespace_name "Stream" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stream/key/waterway/value/stream"></see>
    /// </summary>
    let ``Stream/key/waterway/value/stream`` =
        Namespaced_IRI.parse _namespace_name "Stream/key/waterway/value/stream" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLamp"></see>
    /// </summary>
    let StreetLamp = Namespaced_IRI.parse _namespace_name "StreetLamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLamp/key/highway/value/street_lamp"></see>
    /// </summary>
    let ``StreetLamp/key/highway/value/street_lamp`` =
        Namespaced_IRI.parse _namespace_name "StreetLamp/key/highway/value/street_lamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLamp/key/amenity/value/street_lamp"></see>
    /// </summary>
    let ``StreetLamp/key/amenity/value/street_lamp`` =
        Namespaced_IRI.parse _namespace_name "StreetLamp/key/amenity/value/street_lamp" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLight"></see>
    /// </summary>
    let StreetLight =
        Namespaced_IRI.parse _namespace_name "StreetLight" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLight/key/amenity/value/street_light"></see>
    /// </summary>
    let ``StreetLight/key/amenity/value/street_light`` =
        Namespaced_IRI.parse _namespace_name "StreetLight/key/amenity/value/street_light" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stripclub"></see>
    /// </summary>
    let Stripclub = Namespaced_IRI.parse _namespace_name "Stripclub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stripclub/key/amenity/value/stripclub"></see>
    /// </summary>
    let ``Stripclub/key/amenity/value/stripclub`` =
        Namespaced_IRI.parse _namespace_name "Stripclub/key/amenity/value/stripclub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Studio"></see>
    /// </summary>
    let Studio = Namespaced_IRI.parse _namespace_name "Studio" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Studio/key/amenity/value/studio"></see>
    /// </summary>
    let ``Studio/key/amenity/value/studio`` =
        Namespaced_IRI.parse _namespace_name "Studio/key/amenity/value/studio" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Subdivision"></see>
    /// </summary>
    let Subdivision =
        Namespaced_IRI.parse _namespace_name "Subdivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Subdivision/key/place/value/subdivision"></see>
    /// </summary>
    let ``Subdivision/key/place/value/subdivision`` =
        Namespaced_IRI.parse _namespace_name "Subdivision/key/place/value/subdivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Suburb"></see>
    /// </summary>
    let Suburb = Namespaced_IRI.parse _namespace_name "Suburb" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Suburb/key/place/value/suburb"></see>
    /// </summary>
    let ``Suburb/key/place/value/suburb`` =
        Namespaced_IRI.parse _namespace_name "Suburb/key/place/value/suburb" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Subway"></see>
    /// </summary>
    let Subway = Namespaced_IRI.parse _namespace_name "Subway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Subway/key/railway/value/subway"></see>
    /// </summary>
    let ``Subway/key/railway/value/subway`` =
        Namespaced_IRI.parse _namespace_name "Subway/key/railway/value/subway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SubwayEntrance"></see>
    /// </summary>
    let SubwayEntrance =
        Namespaced_IRI.parse _namespace_name "SubwayEntrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SubwayEntrance/key/railway/value/subway_entrance"></see>
    /// </summary>
    let ``SubwayEntrance/key/railway/value/subway_entrance`` =
        Namespaced_IRI.parse _namespace_name "SubwayEntrance/key/railway/value/subway_entrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SummitCross"></see>
    /// </summary>
    let SummitCross =
        Namespaced_IRI.parse _namespace_name "SummitCross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SummitCross/key/man_made/value/summit_cross"></see>
    /// </summary>
    let ``SummitCross/key/man_made/value/summit_cross`` =
        Namespaced_IRI.parse _namespace_name "SummitCross/key/man_made/value/summit_cross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SunProtection"></see>
    /// </summary>
    let SunProtection =
        Namespaced_IRI.parse _namespace_name "SunProtection" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SunProtection/key/craft/value/sun_protection"></see>
    /// </summary>
    let ``SunProtection/key/craft/value/sun_protection`` =
        Namespaced_IRI.parse _namespace_name "SunProtection/key/craft/value/sun_protection" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Supermarket"></see>
    /// </summary>
    let Supermarket =
        Namespaced_IRI.parse _namespace_name "Supermarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Supermarket/key/shop/value/supermarket"></see>
    /// </summary>
    let ``Supermarket/key/shop/value/supermarket`` =
        Namespaced_IRI.parse _namespace_name "Supermarket/key/shop/value/supermarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Supermarket/key/amenity/value/supermarket"></see>
    /// </summary>
    let ``Supermarket/key/amenity/value/supermarket`` =
        Namespaced_IRI.parse _namespace_name "Supermarket/key/amenity/value/supermarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Supermarket/key/shop/value/Supermarket"></see>
    /// </summary>
    let ``Supermarket/key/shop/value/Supermarket`` =
        Namespaced_IRI.parse _namespace_name "Supermarket/key/shop/value/Supermarket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Surgery"></see>
    /// </summary>
    let Surgery = Namespaced_IRI.parse _namespace_name "Surgery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Surgery/key/amenity/value/surgery"></see>
    /// </summary>
    let ``Surgery/key/amenity/value/surgery`` =
        Namespaced_IRI.parse _namespace_name "Surgery/key/amenity/value/surgery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Surveillance"></see>
    /// </summary>
    let Surveillance =
        Namespaced_IRI.parse _namespace_name "Surveillance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Surveillance/key/man_made/value/surveillance"></see>
    /// </summary>
    let ``Surveillance/key/man_made/value/surveillance`` =
        Namespaced_IRI.parse _namespace_name "Surveillance/key/man_made/value/surveillance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Survey"></see>
    /// </summary>
    let Survey = Namespaced_IRI.parse _namespace_name "Survey" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Survey/key/amenity/value/survey"></see>
    /// </summary>
    let ``Survey/key/amenity/value/survey`` =
        Namespaced_IRI.parse _namespace_name "Survey/key/amenity/value/survey" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SurveyPoint"></see>
    /// </summary>
    let SurveyPoint =
        Namespaced_IRI.parse _namespace_name "SurveyPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SurveyPoint/key/man_made/value/survey_point"></see>
    /// </summary>
    let ``SurveyPoint/key/man_made/value/survey_point`` =
        Namespaced_IRI.parse _namespace_name "SurveyPoint/key/man_made/value/survey_point" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sweep"></see>
    /// </summary>
    let Sweep = Namespaced_IRI.parse _namespace_name "Sweep" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sweep/key/craft/value/sweep"></see>
    /// </summary>
    let ``Sweep/key/craft/value/sweep`` =
        Namespaced_IRI.parse _namespace_name "Sweep/key/craft/value/sweep" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sweets"></see>
    /// </summary>
    let Sweets = Namespaced_IRI.parse _namespace_name "Sweets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sweets/key/shop/value/sweets"></see>
    /// </summary>
    let ``Sweets/key/shop/value/sweets`` =
        Namespaced_IRI.parse _namespace_name "Sweets/key/shop/value/sweets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SwimmingPool"></see>
    /// </summary>
    let SwimmingPool =
        Namespaced_IRI.parse _namespace_name "SwimmingPool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SwimmingPool/key/amenity/value/swimming_pool"></see>
    /// </summary>
    let ``SwimmingPool/key/amenity/value/swimming_pool`` =
        Namespaced_IRI.parse _namespace_name "SwimmingPool/key/amenity/value/swimming_pool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SwimmingPool/key/leisure/value/swimming_pool"></see>
    /// </summary>
    let ``SwimmingPool/key/leisure/value/swimming_pool`` =
        Namespaced_IRI.parse _namespace_name "SwimmingPool/key/leisure/value/swimming_pool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Table"></see>
    /// </summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Table/key/amenity/value/table"></see>
    /// </summary>
    let ``Table/key/amenity/value/table`` =
        Namespaced_IRI.parse _namespace_name "Table/key/amenity/value/table" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TableBump"></see>
    /// </summary>
    let TableBump = Namespaced_IRI.parse _namespace_name "TableBump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TableBump/key/traffic_calming/value/table"></see>
    /// </summary>
    let ``TableBump/key/traffic_calming/value/table`` =
        Namespaced_IRI.parse _namespace_name "TableBump/key/traffic_calming/value/table" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tailor"></see>
    /// </summary>
    let Tailor = Namespaced_IRI.parse _namespace_name "Tailor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tailor/key/shop/value/tailor"></see>
    /// </summary>
    let ``Tailor/key/shop/value/tailor`` =
        Namespaced_IRI.parse _namespace_name "Tailor/key/shop/value/tailor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tailor/key/craft/value/tailor"></see>
    /// </summary>
    let ``Tailor/key/craft/value/tailor`` =
        Namespaced_IRI.parse _namespace_name "Tailor/key/craft/value/tailor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TakeAway"></see>
    /// </summary>
    let TakeAway = Namespaced_IRI.parse _namespace_name "TakeAway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TakeAway/key/amenity/value/take_away"></see>
    /// </summary>
    let ``TakeAway/key/amenity/value/take_away`` =
        Namespaced_IRI.parse _namespace_name "TakeAway/key/amenity/value/take_away" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TakeAway/key/shop/value/take_away"></see>
    /// </summary>
    let ``TakeAway/key/shop/value/take_away`` =
        Namespaced_IRI.parse _namespace_name "TakeAway/key/shop/value/take_away" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tanning"></see>
    /// </summary>
    let Tanning = Namespaced_IRI.parse _namespace_name "Tanning" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tanning/key/shop/value/tanning"></see>
    /// </summary>
    let ``Tanning/key/shop/value/tanning`` =
        Namespaced_IRI.parse _namespace_name "Tanning/key/shop/value/tanning" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tattoo"></see>
    /// </summary>
    let Tattoo = Namespaced_IRI.parse _namespace_name "Tattoo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tattoo/key/shop/value/tattoo"></see>
    /// </summary>
    let ``Tattoo/key/shop/value/tattoo`` =
        Namespaced_IRI.parse _namespace_name "Tattoo/key/shop/value/tattoo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tax"></see>
    /// </summary>
    let Tax = Namespaced_IRI.parse _namespace_name "Tax" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tax/key/shop/value/tax"></see>
    /// </summary>
    let ``Tax/key/shop/value/tax`` =
        Namespaced_IRI.parse _namespace_name "Tax/key/shop/value/tax" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Taxi"></see>
    /// </summary>
    let Taxi = Namespaced_IRI.parse _namespace_name "Taxi" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Taxi/key/amenity/value/taxi"></see>
    /// </summary>
    let ``Taxi/key/amenity/value/taxi`` =
        Namespaced_IRI.parse _namespace_name "Taxi/key/amenity/value/taxi" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tea"></see>
    /// </summary>
    let Tea = Namespaced_IRI.parse _namespace_name "Tea" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tea/key/shop/value/tea"></see>
    /// </summary>
    let ``Tea/key/shop/value/tea`` =
        Namespaced_IRI.parse _namespace_name "Tea/key/shop/value/tea" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Technology"></see>
    /// </summary>
    let Technology = Namespaced_IRI.parse _namespace_name "Technology" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Technology/key/shop/value/technology"></see>
    /// </summary>
    let ``Technology/key/shop/value/technology`` =
        Namespaced_IRI.parse _namespace_name "Technology/key/shop/value/technology" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telecom"></see>
    /// </summary>
    let Telecom = Namespaced_IRI.parse _namespace_name "Telecom" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telecom/key/shop/value/telecom"></see>
    /// </summary>
    let ``Telecom/key/shop/value/telecom`` =
        Namespaced_IRI.parse _namespace_name "Telecom/key/shop/value/telecom" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telecommunication"></see>
    /// </summary>
    let Telecommunication =
        Namespaced_IRI.parse _namespace_name "Telecommunication" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telecommunication/key/shop/value/telecommunication"></see>
    /// </summary>
    let ``Telecommunication/key/shop/value/telecommunication`` =
        Namespaced_IRI.parse _namespace_name "Telecommunication/key/shop/value/telecommunication" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelecommunicationOffice"></see>
    /// </summary>
    let TelecommunicationOffice =
        Namespaced_IRI.parse _namespace_name "TelecommunicationOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelecommunicationOffice/key/office/value/telecommunication"></see>
    /// </summary>
    let ``TelecommunicationOffice/key/office/value/telecommunication`` =
        Namespaced_IRI.parse _namespace_name "TelecommunicationOffice/key/office/value/telecommunication" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telephone"></see>
    /// </summary>
    let Telephone = Namespaced_IRI.parse _namespace_name "Telephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telephone/key/amenity/value/telephone"></see>
    /// </summary>
    let ``Telephone/key/amenity/value/telephone`` =
        Namespaced_IRI.parse _namespace_name "Telephone/key/amenity/value/telephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelephoneExchange"></see>
    /// </summary>
    let TelephoneExchange =
        Namespaced_IRI.parse _namespace_name "TelephoneExchange" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelephoneExchange/key/man_made/value/telephone_exchange"></see>
    /// </summary>
    let ``TelephoneExchange/key/man_made/value/telephone_exchange`` =
        Namespaced_IRI.parse _namespace_name "TelephoneExchange/key/man_made/value/telephone_exchange" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelephoneShop"></see>
    /// </summary>
    let TelephoneShop =
        Namespaced_IRI.parse _namespace_name "TelephoneShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelephoneShop/key/shop/value/telephone"></see>
    /// </summary>
    let ``TelephoneShop/key/shop/value/telephone`` =
        Namespaced_IRI.parse _namespace_name "TelephoneShop/key/shop/value/telephone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telescope"></see>
    /// </summary>
    let Telescope = Namespaced_IRI.parse _namespace_name "Telescope" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telescope/key/man_made/value/telescope"></see>
    /// </summary>
    let ``Telescope/key/man_made/value/telescope`` =
        Namespaced_IRI.parse _namespace_name "Telescope/key/man_made/value/telescope" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Terrace"></see>
    /// </summary>
    let Terrace = Namespaced_IRI.parse _namespace_name "Terrace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Terrace/key/building/value/terrace"></see>
    /// </summary>
    let ``Terrace/key/building/value/terrace`` =
        Namespaced_IRI.parse _namespace_name "Terrace/key/building/value/terrace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TertiaryHighway"></see>
    /// </summary>
    let TertiaryHighway =
        Namespaced_IRI.parse _namespace_name "TertiaryHighway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TertiaryHighway/key/highway/value/tertiary"></see>
    /// </summary>
    let ``TertiaryHighway/key/highway/value/tertiary`` =
        Namespaced_IRI.parse _namespace_name "TertiaryHighway/key/highway/value/tertiary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Textiles"></see>
    /// </summary>
    let Textiles = Namespaced_IRI.parse _namespace_name "Textiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Textiles/key/shop/value/textiles"></see>
    /// </summary>
    let ``Textiles/key/shop/value/textiles`` =
        Namespaced_IRI.parse _namespace_name "Textiles/key/shop/value/textiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Theatre"></see>
    /// </summary>
    let Theatre = Namespaced_IRI.parse _namespace_name "Theatre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Theatre/key/amenity/value/theatre"></see>
    /// </summary>
    let ``Theatre/key/amenity/value/theatre`` =
        Namespaced_IRI.parse _namespace_name "Theatre/key/amenity/value/theatre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ThemePark"></see>
    /// </summary>
    let ThemePark = Namespaced_IRI.parse _namespace_name "ThemePark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ThemePark/key/tourism/value/theme_park"></see>
    /// </summary>
    let ``ThemePark/key/tourism/value/theme_park`` =
        Namespaced_IRI.parse _namespace_name "ThemePark/key/tourism/value/theme_park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ThresingFloor"></see>
    /// </summary>
    let ThresingFloor =
        Namespaced_IRI.parse _namespace_name "ThresingFloor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ThresingFloor/key/landuse/value/thresing_floor"></see>
    /// </summary>
    let ``ThresingFloor/key/landuse/value/thresing_floor`` =
        Namespaced_IRI.parse _namespace_name "ThresingFloor/key/landuse/value/thresing_floor" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Thrift"></see>
    /// </summary>
    let Thrift = Namespaced_IRI.parse _namespace_name "Thrift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Thrift/key/shop/value/thrift"></see>
    /// </summary>
    let ``Thrift/key/shop/value/thrift`` =
        Namespaced_IRI.parse _namespace_name "Thrift/key/shop/value/thrift" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ticket"></see>
    /// </summary>
    let Ticket = Namespaced_IRI.parse _namespace_name "Ticket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ticket/key/shop/value/ticket"></see>
    /// </summary>
    let ``Ticket/key/shop/value/ticket`` =
        Namespaced_IRI.parse _namespace_name "Ticket/key/shop/value/ticket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tickets"></see>
    /// </summary>
    let Tickets = Namespaced_IRI.parse _namespace_name "Tickets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tickets/key/shop/value/tickets"></see>
    /// </summary>
    let ``Tickets/key/shop/value/tickets`` =
        Namespaced_IRI.parse _namespace_name "Tickets/key/shop/value/tickets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tiler"></see>
    /// </summary>
    let Tiler = Namespaced_IRI.parse _namespace_name "Tiler" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tiler/key/craft/value/tiler"></see>
    /// </summary>
    let ``Tiler/key/craft/value/tiler`` =
        Namespaced_IRI.parse _namespace_name "Tiler/key/craft/value/tiler" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tinsmith"></see>
    /// </summary>
    let Tinsmith = Namespaced_IRI.parse _namespace_name "Tinsmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tinsmith/key/craft/value/tinsmith"></see>
    /// </summary>
    let ``Tinsmith/key/craft/value/tinsmith`` =
        Namespaced_IRI.parse _namespace_name "Tinsmith/key/craft/value/tinsmith" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tobacco"></see>
    /// </summary>
    let Tobacco = Namespaced_IRI.parse _namespace_name "Tobacco" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tobacco/key/shop/value/tobacco"></see>
    /// </summary>
    let ``Tobacco/key/shop/value/tobacco`` =
        Namespaced_IRI.parse _namespace_name "Tobacco/key/shop/value/tobacco" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tobacconist"></see>
    /// </summary>
    let Tobacconist =
        Namespaced_IRI.parse _namespace_name "Tobacconist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tobacconist/key/shop/value/tobacconist"></see>
    /// </summary>
    let ``Tobacconist/key/shop/value/tobacconist`` =
        Namespaced_IRI.parse _namespace_name "Tobacconist/key/shop/value/tobacconist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Toilets"></see>
    /// </summary>
    let Toilets = Namespaced_IRI.parse _namespace_name "Toilets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Toilets/key/amenity/value/toilets"></see>
    /// </summary>
    let ``Toilets/key/amenity/value/toilets`` =
        Namespaced_IRI.parse _namespace_name "Toilets/key/amenity/value/toilets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TollBooth"></see>
    /// </summary>
    let TollBooth = Namespaced_IRI.parse _namespace_name "TollBooth" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TollBooth/key/barrier/value/toll_booth"></see>
    /// </summary>
    let ``TollBooth/key/barrier/value/toll_booth`` =
        Namespaced_IRI.parse _namespace_name "TollBooth/key/barrier/value/toll_booth" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tombstone"></see>
    /// </summary>
    let Tombstone = Namespaced_IRI.parse _namespace_name "Tombstone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tombstone/key/historic/value/tombstone"></see>
    /// </summary>
    let ``Tombstone/key/historic/value/tombstone`` =
        Namespaced_IRI.parse _namespace_name "Tombstone/key/historic/value/tombstone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TourismInformation"></see>
    /// </summary>
    let TourismInformation =
        Namespaced_IRI.parse _namespace_name "TourismInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TourismInformation/key/tourism/value/information"></see>
    /// </summary>
    let ``TourismInformation/key/tourism/value/information`` =
        Namespaced_IRI.parse _namespace_name "TourismInformation/key/tourism/value/information" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tourist"></see>
    /// </summary>
    let Tourist = Namespaced_IRI.parse _namespace_name "Tourist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tourist/key/amenity/value/tourist"></see>
    /// </summary>
    let ``Tourist/key/amenity/value/tourist`` =
        Namespaced_IRI.parse _namespace_name "Tourist/key/amenity/value/tourist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TouristShop"></see>
    /// </summary>
    let TouristShop =
        Namespaced_IRI.parse _namespace_name "TouristShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TouristShop/key/shop/value/tourist"></see>
    /// </summary>
    let ``TouristShop/key/shop/value/tourist`` =
        Namespaced_IRI.parse _namespace_name "TouristShop/key/shop/value/tourist" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tower"></see>
    /// </summary>
    let Tower = Namespaced_IRI.parse _namespace_name "Tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tower/key/man_made/value/tower"></see>
    /// </summary>
    let ``Tower/key/man_made/value/tower`` =
        Namespaced_IRI.parse _namespace_name "Tower/key/man_made/value/tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Town"></see>
    /// </summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Town/key/place/value/town"></see>
    /// </summary>
    let ``Town/key/place/value/town`` =
        Namespaced_IRI.parse _namespace_name "Town/key/place/value/town" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Townhall"></see>
    /// </summary>
    let Townhall = Namespaced_IRI.parse _namespace_name "Townhall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Townhall/key/amenity/value/townhall"></see>
    /// </summary>
    let ``Townhall/key/amenity/value/townhall`` =
        Namespaced_IRI.parse _namespace_name "Townhall/key/amenity/value/townhall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Toys"></see>
    /// </summary>
    let Toys = Namespaced_IRI.parse _namespace_name "Toys" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Toys/key/shop/value/toys"></see>
    /// </summary>
    let ``Toys/key/shop/value/toys`` =
        Namespaced_IRI.parse _namespace_name "Toys/key/shop/value/toys" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Track"></see>
    /// </summary>
    let Track = Namespaced_IRI.parse _namespace_name "Track" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Track/key/leisure/value/track"></see>
    /// </summary>
    let ``Track/key/leisure/value/track`` =
        Namespaced_IRI.parse _namespace_name "Track/key/leisure/value/track" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Track/key/highway/value/track"></see>
    /// </summary>
    let ``Track/key/highway/value/track`` =
        Namespaced_IRI.parse _namespace_name "Track/key/highway/value/track" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackHalt"></see>
    /// </summary>
    let TrackHalt = Namespaced_IRI.parse _namespace_name "TrackHalt" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackHalt/key/railway/value/track_halt"></see>
    /// </summary>
    let ``TrackHalt/key/railway/value/track_halt`` =
        Namespaced_IRI.parse _namespace_name "TrackHalt/key/railway/value/track_halt" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType1"></see>
    /// </summary>
    let TrackType1 = Namespaced_IRI.parse _namespace_name "TrackType1" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType1/key/tracktype/value/grade1"></see>
    /// </summary>
    let ``TrackType1/key/tracktype/value/grade1`` =
        Namespaced_IRI.parse _namespace_name "TrackType1/key/tracktype/value/grade1" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType2"></see>
    /// </summary>
    let TrackType2 = Namespaced_IRI.parse _namespace_name "TrackType2" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType2/key/tracktype/value/grade2"></see>
    /// </summary>
    let ``TrackType2/key/tracktype/value/grade2`` =
        Namespaced_IRI.parse _namespace_name "TrackType2/key/tracktype/value/grade2" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType3"></see>
    /// </summary>
    let TrackType3 = Namespaced_IRI.parse _namespace_name "TrackType3" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType3/key/tracktype/value/grade3"></see>
    /// </summary>
    let ``TrackType3/key/tracktype/value/grade3`` =
        Namespaced_IRI.parse _namespace_name "TrackType3/key/tracktype/value/grade3" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType4"></see>
    /// </summary>
    let TrackType4 = Namespaced_IRI.parse _namespace_name "TrackType4" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType4/key/tracktype/value/grade4"></see>
    /// </summary>
    let ``TrackType4/key/tracktype/value/grade4`` =
        Namespaced_IRI.parse _namespace_name "TrackType4/key/tracktype/value/grade4" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType5"></see>
    /// </summary>
    let TrackType5 = Namespaced_IRI.parse _namespace_name "TrackType5" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType5/key/tracktype/value/grade5"></see>
    /// </summary>
    let ``TrackType5/key/tracktype/value/grade5`` =
        Namespaced_IRI.parse _namespace_name "TrackType5/key/tracktype/value/grade5" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trade"></see>
    /// </summary>
    let Trade = Namespaced_IRI.parse _namespace_name "Trade" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trade/key/amenity/value/trade"></see>
    /// </summary>
    let ``Trade/key/amenity/value/trade`` =
        Namespaced_IRI.parse _namespace_name "Trade/key/amenity/value/trade" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficCalming"></see>
    /// </summary>
    let TrafficCalming =
        Namespaced_IRI.parse _namespace_name "TrafficCalming" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficCalming/key/traffic_calming/value/yes"></see>
    /// </summary>
    let ``TrafficCalming/key/traffic_calming/value/yes`` =
        Namespaced_IRI.parse _namespace_name "TrafficCalming/key/traffic_calming/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficLight"></see>
    /// </summary>
    let TrafficLight =
        Namespaced_IRI.parse _namespace_name "TrafficLight" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficLight/key/amenity/value/traffic_light"></see>
    /// </summary>
    let ``TrafficLight/key/amenity/value/traffic_light`` =
        Namespaced_IRI.parse _namespace_name "TrafficLight/key/amenity/value/traffic_light" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficSignals"></see>
    /// </summary>
    let TrafficSignals =
        Namespaced_IRI.parse _namespace_name "TrafficSignals" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficSignals/key/highway/value/traffic_signals"></see>
    /// </summary>
    let ``TrafficSignals/key/highway/value/traffic_signals`` =
        Namespaced_IRI.parse _namespace_name "TrafficSignals/key/highway/value/traffic_signals" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrainRoute"></see>
    /// </summary>
    let TrainRoute = Namespaced_IRI.parse _namespace_name "TrainRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrainRoute/key/route/value/train"></see>
    /// </summary>
    let ``TrainRoute/key/route/value/train`` =
        Namespaced_IRI.parse _namespace_name "TrainRoute/key/route/value/train" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrainStation"></see>
    /// </summary>
    let TrainStation =
        Namespaced_IRI.parse _namespace_name "TrainStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrainStation/key/building/value/train_station"></see>
    /// </summary>
    let ``TrainStation/key/building/value/train_station`` =
        Namespaced_IRI.parse _namespace_name "TrainStation/key/building/value/train_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramRoute"></see>
    /// </summary>
    let TramRoute = Namespaced_IRI.parse _namespace_name "TramRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramRoute/key/route/value/tram"></see>
    /// </summary>
    let ``TramRoute/key/route/value/tram`` =
        Namespaced_IRI.parse _namespace_name "TramRoute/key/route/value/tram" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramStation"></see>
    /// </summary>
    let TramStation =
        Namespaced_IRI.parse _namespace_name "TramStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramStation/key/railway/value/tram_station"></see>
    /// </summary>
    let ``TramStation/key/railway/value/tram_station`` =
        Namespaced_IRI.parse _namespace_name "TramStation/key/railway/value/tram_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramStop"></see>
    /// </summary>
    let TramStop = Namespaced_IRI.parse _namespace_name "TramStop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramStop/key/railway/value/tram_stop"></see>
    /// </summary>
    let ``TramStop/key/railway/value/tram_stop`` =
        Namespaced_IRI.parse _namespace_name "TramStop/key/railway/value/tram_stop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tramway"></see>
    /// </summary>
    let Tramway = Namespaced_IRI.parse _namespace_name "Tramway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tramway/key/railway/value/tram"></see>
    /// </summary>
    let ``Tramway/key/railway/value/tram`` =
        Namespaced_IRI.parse _namespace_name "Tramway/key/railway/value/tram" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Transformer"></see>
    /// </summary>
    let Transformer =
        Namespaced_IRI.parse _namespace_name "Transformer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Transformer/key/power/value/transformer"></see>
    /// </summary>
    let ``Transformer/key/power/value/transformer`` =
        Namespaced_IRI.parse _namespace_name "Transformer/key/power/value/transformer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrashBin"></see>
    /// </summary>
    let TrashBin = Namespaced_IRI.parse _namespace_name "TrashBin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrashBin/key/amenity/value/trash_bin"></see>
    /// </summary>
    let ``TrashBin/key/amenity/value/trash_bin`` =
        Namespaced_IRI.parse _namespace_name "TrashBin/key/amenity/value/trash_bin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrashCan"></see>
    /// </summary>
    let TrashCan = Namespaced_IRI.parse _namespace_name "TrashCan" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrashCan/key/amenity/value/trash_can"></see>
    /// </summary>
    let ``TrashCan/key/amenity/value/trash_can`` =
        Namespaced_IRI.parse _namespace_name "TrashCan/key/amenity/value/trash_can" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgency"></see>
    /// </summary>
    let TravelAgency =
        Namespaced_IRI.parse _namespace_name "TravelAgency" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgency/key/shop/value/travel_agency"></see>
    /// </summary>
    let ``TravelAgency/key/shop/value/travel_agency`` =
        Namespaced_IRI.parse _namespace_name "TravelAgency/key/shop/value/travel_agency" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgency/key/shop/value/travel%20agency"></see>
    /// </summary>
    let ``TravelAgency/key/shop/value/travel%20agency`` =
        Namespaced_IRI.parse _namespace_name "TravelAgency/key/shop/value/travel%20agency" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgentOffice"></see>
    /// </summary>
    let TravelAgentOffice =
        Namespaced_IRI.parse _namespace_name "TravelAgentOffice" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgentOffice/key/office/value/travel_agent"></see>
    /// </summary>
    let ``TravelAgentOffice/key/office/value/travel_agent`` =
        Namespaced_IRI.parse _namespace_name "TravelAgentOffice/key/office/value/travel_agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tree"></see>
    /// </summary>
    let Tree = Namespaced_IRI.parse _namespace_name "Tree" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tree/key/natural/value/tree"></see>
    /// </summary>
    let ``Tree/key/natural/value/tree`` =
        Namespaced_IRI.parse _namespace_name "Tree/key/natural/value/tree" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Treerow"></see>
    /// </summary>
    let Treerow = Namespaced_IRI.parse _namespace_name "Treerow" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Treerow/key/landuse/value/treerow"></see>
    /// </summary>
    let ``Treerow/key/landuse/value/treerow`` =
        Namespaced_IRI.parse _namespace_name "Treerow/key/landuse/value/treerow" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TricycleStation"></see>
    /// </summary>
    let TricycleStation =
        Namespaced_IRI.parse _namespace_name "TricycleStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TricycleStation/key/amenity/value/tricycle_station"></see>
    /// </summary>
    let ``TricycleStation/key/amenity/value/tricycle_station`` =
        Namespaced_IRI.parse _namespace_name "TricycleStation/key/amenity/value/tricycle_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trumpet"></see>
    /// </summary>
    let Trumpet = Namespaced_IRI.parse _namespace_name "Trumpet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trumpet/key/shop/value/trumpet"></see>
    /// </summary>
    let ``Trumpet/key/shop/value/trumpet`` =
        Namespaced_IRI.parse _namespace_name "Trumpet/key/shop/value/trumpet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trunk"></see>
    /// </summary>
    let Trunk = Namespaced_IRI.parse _namespace_name "Trunk" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trunk/key/highway/value/trunk"></see>
    /// </summary>
    let ``Trunk/key/highway/value/trunk`` =
        Namespaced_IRI.parse _namespace_name "Trunk/key/highway/value/trunk" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrunkLink"></see>
    /// </summary>
    let TrunkLink = Namespaced_IRI.parse _namespace_name "TrunkLink" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrunkLink/key/highway/value/trunk_link"></see>
    /// </summary>
    let ``TrunkLink/key/highway/value/trunk_link`` =
        Namespaced_IRI.parse _namespace_name "TrunkLink/key/highway/value/trunk_link" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tumulus"></see>
    /// </summary>
    let Tumulus = Namespaced_IRI.parse _namespace_name "Tumulus" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tumulus/key/historic/value/tumulus"></see>
    /// </summary>
    let ``Tumulus/key/historic/value/tumulus`` =
        Namespaced_IRI.parse _namespace_name "Tumulus/key/historic/value/tumulus" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TunnelCulvert"></see>
    /// </summary>
    let TunnelCulvert =
        Namespaced_IRI.parse _namespace_name "TunnelCulvert" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TunnelCulvert/key/tunnel/value/culvert"></see>
    /// </summary>
    let ``TunnelCulvert/key/tunnel/value/culvert`` =
        Namespaced_IRI.parse _namespace_name "TunnelCulvert/key/tunnel/value/culvert" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TurningCircle"></see>
    /// </summary>
    let TurningCircle =
        Namespaced_IRI.parse _namespace_name "TurningCircle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TurningCircle/key/highway/value/turning_circle"></see>
    /// </summary>
    let ``TurningCircle/key/highway/value/turning_circle`` =
        Namespaced_IRI.parse _namespace_name "TurningCircle/key/highway/value/turning_circle" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TurningPoint"></see>
    /// </summary>
    let TurningPoint =
        Namespaced_IRI.parse _namespace_name "TurningPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TurningPoint/key/waterway/value/turning_point"></see>
    /// </summary>
    let ``TurningPoint/key/waterway/value/turning_point`` =
        Namespaced_IRI.parse _namespace_name "TurningPoint/key/waterway/value/turning_point" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Turnstile"></see>
    /// </summary>
    let Turnstile = Namespaced_IRI.parse _namespace_name "Turnstile" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Turnstile/key/barrier/value/turnstile"></see>
    /// </summary>
    let ``Turnstile/key/barrier/value/turnstile`` =
        Namespaced_IRI.parse _namespace_name "Turnstile/key/barrier/value/turnstile" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Turntable"></see>
    /// </summary>
    let Turntable = Namespaced_IRI.parse _namespace_name "Turntable" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Turntable/key/railway/value/turntable"></see>
    /// </summary>
    let ``Turntable/key/railway/value/turntable`` =
        Namespaced_IRI.parse _namespace_name "Turntable/key/railway/value/turntable" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tyres"></see>
    /// </summary>
    let Tyres = Namespaced_IRI.parse _namespace_name "Tyres" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tyres/key/shop/value/tyres"></see>
    /// </summary>
    let ``Tyres/key/shop/value/tyres`` =
        Namespaced_IRI.parse _namespace_name "Tyres/key/shop/value/tyres" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UNESCOWorldHeritage"></see>
    /// </summary>
    let UNESCOWorldHeritage =
        Namespaced_IRI.parse _namespace_name "UNESCOWorldHeritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UNESCOWorldHeritage/key/historic/value/UNESCO_world_heritage"></see>
    /// </summary>
    let ``UNESCOWorldHeritage/key/historic/value/UNESCO_world_heritage`` =
        Namespaced_IRI.parse _namespace_name "UNESCOWorldHeritage/key/historic/value/UNESCO_world_heritage" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UnclassifiedHighway"></see>
    /// </summary>
    let UnclassifiedHighway =
        Namespaced_IRI.parse _namespace_name "UnclassifiedHighway" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UnclassifiedHighway/key/highway/value/unclassified"></see>
    /// </summary>
    let ``UnclassifiedHighway/key/highway/value/unclassified`` =
        Namespaced_IRI.parse _namespace_name "UnclassifiedHighway/key/highway/value/unclassified" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UndefinedShop"></see>
    /// </summary>
    let UndefinedShop =
        Namespaced_IRI.parse _namespace_name "UndefinedShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UndefinedShop/key/shop/value/undefined"></see>
    /// </summary>
    let ``UndefinedShop/key/shop/value/undefined`` =
        Namespaced_IRI.parse _namespace_name "UndefinedShop/key/shop/value/undefined" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/University"></see>
    /// </summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/University/key/amenity/value/university"></see>
    /// </summary>
    let ``University/key/amenity/value/university`` =
        Namespaced_IRI.parse _namespace_name "University/key/amenity/value/university" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UnknownShop"></see>
    /// </summary>
    let UnknownShop =
        Namespaced_IRI.parse _namespace_name "UnknownShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UnknownShop/key/shop/value/unknown"></see>
    /// </summary>
    let ``UnknownShop/key/shop/value/unknown`` =
        Namespaced_IRI.parse _namespace_name "UnknownShop/key/shop/value/unknown" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Uphill+Terminal"></see>
    /// </summary>
    let ``Uphill+Terminal`` =
        Namespaced_IRI.parse _namespace_name "Uphill+Terminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Uphill+Terminal/key/man_made/value/Uphill%20Terminal"></see>
    /// </summary>
    let ``Uphill+Terminal/key/man_made/value/Uphill%20Terminal`` =
        Namespaced_IRI.parse _namespace_name "Uphill+Terminal/key/man_made/value/Uphill%20Terminal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Upholsterer"></see>
    /// </summary>
    let Upholsterer =
        Namespaced_IRI.parse _namespace_name "Upholsterer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Upholsterer/key/craft/value/upholsterer"></see>
    /// </summary>
    let ``Upholsterer/key/craft/value/upholsterer`` =
        Namespaced_IRI.parse _namespace_name "Upholsterer/key/craft/value/upholsterer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vacant"></see>
    /// </summary>
    let Vacant = Namespaced_IRI.parse _namespace_name "Vacant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vacant/key/shop/value/vacant"></see>
    /// </summary>
    let ``Vacant/key/shop/value/vacant`` =
        Namespaced_IRI.parse _namespace_name "Vacant/key/shop/value/vacant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Variety"></see>
    /// </summary>
    let Variety = Namespaced_IRI.parse _namespace_name "Variety" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Variety/key/shop/value/variety"></see>
    /// </summary>
    let ``Variety/key/shop/value/variety`` =
        Namespaced_IRI.parse _namespace_name "Variety/key/shop/value/variety" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vdsl-aru"></see>
    /// </summary>
    let ``Vdsl-aru`` = Namespaced_IRI.parse _namespace_name "Vdsl-aru" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vdsl-aru/key/amenity/value/vdsl-aru"></see>
    /// </summary>
    let ``Vdsl-aru/key/amenity/value/vdsl-aru`` =
        Namespaced_IRI.parse _namespace_name "Vdsl-aru/key/amenity/value/vdsl-aru" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VehicleInspection"></see>
    /// </summary>
    let VehicleInspection =
        Namespaced_IRI.parse _namespace_name "VehicleInspection" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VehicleInspection/key/amenity/value/vehicle_inspection"></see>
    /// </summary>
    let ``VehicleInspection/key/amenity/value/vehicle_inspection`` =
        Namespaced_IRI.parse _namespace_name "VehicleInspection/key/amenity/value/vehicle_inspection" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vending"></see>
    /// </summary>
    let Vending = Namespaced_IRI.parse _namespace_name "Vending" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vending/key/amenity/value/vending"></see>
    /// </summary>
    let ``Vending/key/amenity/value/vending`` =
        Namespaced_IRI.parse _namespace_name "Vending/key/amenity/value/vending" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vending+machine"></see>
    /// </summary>
    let ``Vending+machine`` =
        Namespaced_IRI.parse _namespace_name "Vending+machine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vending+machine/key/amenity/value/vending%20machine"></see>
    /// </summary>
    let ``Vending+machine/key/amenity/value/vending%20machine`` =
        Namespaced_IRI.parse _namespace_name "Vending+machine/key/amenity/value/vending%20machine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VendingMachine"></see>
    /// </summary>
    let VendingMachine =
        Namespaced_IRI.parse _namespace_name "VendingMachine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VendingMachine/key/amenity/value/vending_machine"></see>
    /// </summary>
    let ``VendingMachine/key/amenity/value/vending_machine`` =
        Namespaced_IRI.parse _namespace_name "VendingMachine/key/amenity/value/vending_machine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VendingMaschine"></see>
    /// </summary>
    let VendingMaschine =
        Namespaced_IRI.parse _namespace_name "VendingMaschine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VendingMaschine/key/amenity/value/vending_maschine"></see>
    /// </summary>
    let ``VendingMaschine/key/amenity/value/vending_maschine`` =
        Namespaced_IRI.parse _namespace_name "VendingMaschine/key/amenity/value/vending_maschine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VentilationShaft"></see>
    /// </summary>
    let VentilationShaft =
        Namespaced_IRI.parse _namespace_name "VentilationShaft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VentilationShaft/key/railway/value/ventilation_shaft"></see>
    /// </summary>
    let ``VentilationShaft/key/railway/value/ventilation_shaft`` =
        Namespaced_IRI.parse _namespace_name "VentilationShaft/key/railway/value/ventilation_shaft" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vet"></see>
    /// </summary>
    let Vet = Namespaced_IRI.parse _namespace_name "Vet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vet/key/amenity/value/vet"></see>
    /// </summary>
    let ``Vet/key/amenity/value/vet`` =
        Namespaced_IRI.parse _namespace_name "Vet/key/amenity/value/vet" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Veterinary"></see>
    /// </summary>
    let Veterinary = Namespaced_IRI.parse _namespace_name "Veterinary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Veterinary/key/amenity/value/veterinary"></see>
    /// </summary>
    let ``Veterinary/key/amenity/value/veterinary`` =
        Namespaced_IRI.parse _namespace_name "Veterinary/key/amenity/value/veterinary" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vets"></see>
    /// </summary>
    let Vets = Namespaced_IRI.parse _namespace_name "Vets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vets/key/amenity/value/vets"></see>
    /// </summary>
    let ``Vets/key/amenity/value/vets`` =
        Namespaced_IRI.parse _namespace_name "Vets/key/amenity/value/vets" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viaduct"></see>
    /// </summary>
    let Viaduct = Namespaced_IRI.parse _namespace_name "Viaduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viaduct/key/railway/value/viaduct"></see>
    /// </summary>
    let ``Viaduct/key/railway/value/viaduct`` =
        Namespaced_IRI.parse _namespace_name "Viaduct/key/railway/value/viaduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Video"></see>
    /// </summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Video/key/shop/value/video"></see>
    /// </summary>
    let ``Video/key/shop/value/video`` =
        Namespaced_IRI.parse _namespace_name "Video/key/shop/value/video" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoGames"></see>
    /// </summary>
    let VideoGames = Namespaced_IRI.parse _namespace_name "VideoGames" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoGames/key/shop/value/video_games"></see>
    /// </summary>
    let ``VideoGames/key/shop/value/video_games`` =
        Namespaced_IRI.parse _namespace_name "VideoGames/key/shop/value/video_games" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoRental"></see>
    /// </summary>
    let VideoRental =
        Namespaced_IRI.parse _namespace_name "VideoRental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoRental/key/amenity/value/video_rental"></see>
    /// </summary>
    let ``VideoRental/key/amenity/value/video_rental`` =
        Namespaced_IRI.parse _namespace_name "VideoRental/key/amenity/value/video_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoRental/key/shop/value/video_rental"></see>
    /// </summary>
    let ``VideoRental/key/shop/value/video_rental`` =
        Namespaced_IRI.parse _namespace_name "VideoRental/key/shop/value/video_rental" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Videosurveillance"></see>
    /// </summary>
    let Videosurveillance =
        Namespaced_IRI.parse _namespace_name "Videosurveillance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Videosurveillance/key/man_made/value/videosurveillance"></see>
    /// </summary>
    let ``Videosurveillance/key/man_made/value/videosurveillance`` =
        Namespaced_IRI.parse _namespace_name "Videosurveillance/key/man_made/value/videosurveillance" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viewpoint"></see>
    /// </summary>
    let Viewpoint = Namespaced_IRI.parse _namespace_name "Viewpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viewpoint/key/tourism/value/viewpoint"></see>
    /// </summary>
    let ``Viewpoint/key/tourism/value/viewpoint`` =
        Namespaced_IRI.parse _namespace_name "Viewpoint/key/tourism/value/viewpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Village"></see>
    /// </summary>
    let Village = Namespaced_IRI.parse _namespace_name "Village" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Village/key/place/value/village"></see>
    /// </summary>
    let ``Village/key/place/value/village`` =
        Namespaced_IRI.parse _namespace_name "Village/key/place/value/village" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillageGreen"></see>
    /// </summary>
    let VillageGreen =
        Namespaced_IRI.parse _namespace_name "VillageGreen" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillageGreen/key/landuse/value/village_green"></see>
    /// </summary>
    let ``VillageGreen/key/landuse/value/village_green`` =
        Namespaced_IRI.parse _namespace_name "VillageGreen/key/landuse/value/village_green" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillageHall"></see>
    /// </summary>
    let VillageHall =
        Namespaced_IRI.parse _namespace_name "VillageHall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillageHall/key/amenity/value/village_hall"></see>
    /// </summary>
    let ``VillageHall/key/amenity/value/village_hall`` =
        Namespaced_IRI.parse _namespace_name "VillageHall/key/amenity/value/village_hall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillagePump"></see>
    /// </summary>
    let VillagePump =
        Namespaced_IRI.parse _namespace_name "VillagePump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillagePump/key/man_made/value/village_pump"></see>
    /// </summary>
    let ``VillagePump/key/man_made/value/village_pump`` =
        Namespaced_IRI.parse _namespace_name "VillagePump/key/man_made/value/village_pump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vineyard"></see>
    /// </summary>
    let Vineyard = Namespaced_IRI.parse _namespace_name "Vineyard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vineyard/key/landuse/value/vineyard"></see>
    /// </summary>
    let ``Vineyard/key/landuse/value/vineyard`` =
        Namespaced_IRI.parse _namespace_name "Vineyard/key/landuse/value/vineyard" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viva+Blue"></see>
    /// </summary>
    let ``Viva+Blue`` =
        Namespaced_IRI.parse _namespace_name "Viva+Blue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viva+Blue/key/railway/value/Viva%20Blue"></see>
    /// </summary>
    let ``Viva+Blue/key/railway/value/Viva%20Blue`` =
        Namespaced_IRI.parse _namespace_name "Viva+Blue/key/railway/value/Viva%20Blue" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Volcano"></see>
    /// </summary>
    let Volcano = Namespaced_IRI.parse _namespace_name "Volcano" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Volcano/key/natural/value/volcano"></see>
    /// </summary>
    let ``Volcano/key/natural/value/volcano`` =
        Namespaced_IRI.parse _namespace_name "Volcano/key/natural/value/volcano" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WLAN"></see>
    /// </summary>
    let WLAN = Namespaced_IRI.parse _namespace_name "WLAN" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WLAN/key/amenity/value/WLAN"></see>
    /// </summary>
    let ``WLAN/key/amenity/value/WLAN`` =
        Namespaced_IRI.parse _namespace_name "WLAN/key/amenity/value/WLAN" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WalkingBus"></see>
    /// </summary>
    let WalkingBus = Namespaced_IRI.parse _namespace_name "WalkingBus" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WalkingBus/key/amenity/value/walking_bus"></see>
    /// </summary>
    let ``WalkingBus/key/amenity/value/walking_bus`` =
        Namespaced_IRI.parse _namespace_name "WalkingBus/key/amenity/value/walking_bus" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wall"></see>
    /// </summary>
    let Wall = Namespaced_IRI.parse _namespace_name "Wall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wall/key/barrier/value/wall"></see>
    /// </summary>
    let ``Wall/key/barrier/value/wall`` =
        Namespaced_IRI.parse _namespace_name "Wall/key/barrier/value/wall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waste"></see>
    /// </summary>
    let Waste = Namespaced_IRI.parse _namespace_name "Waste" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waste/key/amenity/value/waste"></see>
    /// </summary>
    let ``Waste/key/amenity/value/waste`` =
        Namespaced_IRI.parse _namespace_name "Waste/key/amenity/value/waste" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBasket"></see>
    /// </summary>
    let WasteBasket =
        Namespaced_IRI.parse _namespace_name "WasteBasket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBasket/key/amenity/value/waste_basket"></see>
    /// </summary>
    let ``WasteBasket/key/amenity/value/waste_basket`` =
        Namespaced_IRI.parse _namespace_name "WasteBasket/key/amenity/value/waste_basket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBasket%3Brecycling"></see>
    /// </summary>
    let ``WasteBasket%3Brecycling`` =
        Namespaced_IRI.parse _namespace_name "WasteBasket%3Brecycling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBasket%3Brecycling/key/amenity/value/waste_basket%3Brecycling"></see>
    /// </summary>
    let ``WasteBasket%3Brecycling/key/amenity/value/waste_basket%3Brecycling`` =
        Namespaced_IRI.parse _namespace_name "WasteBasket%3Brecycling/key/amenity/value/waste_basket%3Brecycling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBin"></see>
    /// </summary>
    let WasteBin = Namespaced_IRI.parse _namespace_name "WasteBin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBin/key/amenity/value/waste_bin"></see>
    /// </summary>
    let ``WasteBin/key/amenity/value/waste_bin`` =
        Namespaced_IRI.parse _namespace_name "WasteBin/key/amenity/value/waste_bin" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBucket"></see>
    /// </summary>
    let WasteBucket =
        Namespaced_IRI.parse _namespace_name "WasteBucket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBucket/key/amenity/value/waste_bucket"></see>
    /// </summary>
    let ``WasteBucket/key/amenity/value/waste_bucket`` =
        Namespaced_IRI.parse _namespace_name "WasteBucket/key/amenity/value/waste_bucket" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteContainer"></see>
    /// </summary>
    let WasteContainer =
        Namespaced_IRI.parse _namespace_name "WasteContainer" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteContainer/key/amenity/value/waste_container"></see>
    /// </summary>
    let ``WasteContainer/key/amenity/value/waste_container`` =
        Namespaced_IRI.parse _namespace_name "WasteContainer/key/amenity/value/waste_container" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteDisposal"></see>
    /// </summary>
    let WasteDisposal =
        Namespaced_IRI.parse _namespace_name "WasteDisposal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteDisposal/key/amenity/value/waste_disposal"></see>
    /// </summary>
    let ``WasteDisposal/key/amenity/value/waste_disposal`` =
        Namespaced_IRI.parse _namespace_name "WasteDisposal/key/amenity/value/waste_disposal" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WastewaterPlant"></see>
    /// </summary>
    let WastewaterPlant =
        Namespaced_IRI.parse _namespace_name "WastewaterPlant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WastewaterPlant/key/man_made/value/wastewater_plant"></see>
    /// </summary>
    let ``WastewaterPlant/key/man_made/value/wastewater_plant`` =
        Namespaced_IRI.parse _namespace_name "WastewaterPlant/key/man_made/value/wastewater_plant" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watches"></see>
    /// </summary>
    let Watches = Namespaced_IRI.parse _namespace_name "Watches" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watches/key/shop/value/watches"></see>
    /// </summary>
    let ``Watches/key/shop/value/watches`` =
        Namespaced_IRI.parse _namespace_name "Watches/key/shop/value/watches" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watchmaker"></see>
    /// </summary>
    let Watchmaker = Namespaced_IRI.parse _namespace_name "Watchmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watchmaker/key/craft/value/watchmaker"></see>
    /// </summary>
    let ``Watchmaker/key/craft/value/watchmaker`` =
        Namespaced_IRI.parse _namespace_name "Watchmaker/key/craft/value/watchmaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Water"></see>
    /// </summary>
    let Water = Namespaced_IRI.parse _namespace_name "Water" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Water/key/natural/value/water"></see>
    /// </summary>
    let ``Water/key/natural/value/water`` =
        Namespaced_IRI.parse _namespace_name "Water/key/natural/value/water" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Water/key/amenity/value/water"></see>
    /// </summary>
    let ``Water/key/amenity/value/water`` =
        Namespaced_IRI.parse _namespace_name "Water/key/amenity/value/water" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterFountain"></see>
    /// </summary>
    let WaterFountain =
        Namespaced_IRI.parse _namespace_name "WaterFountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterFountain/key/amenity/value/water_fountain"></see>
    /// </summary>
    let ``WaterFountain/key/amenity/value/water_fountain`` =
        Namespaced_IRI.parse _namespace_name "WaterFountain/key/amenity/value/water_fountain" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterPark"></see>
    /// </summary>
    let WaterPark = Namespaced_IRI.parse _namespace_name "WaterPark" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterPark/key/leisure/value/water_park"></see>
    /// </summary>
    let ``WaterPark/key/leisure/value/water_park`` =
        Namespaced_IRI.parse _namespace_name "WaterPark/key/leisure/value/water_park" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterPoint"></see>
    /// </summary>
    let WaterPoint = Namespaced_IRI.parse _namespace_name "WaterPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterPoint/key/waterway/value/water_point"></see>
    /// </summary>
    let ``WaterPoint/key/waterway/value/water_point`` =
        Namespaced_IRI.parse _namespace_name "WaterPoint/key/waterway/value/water_point" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterRefilling"></see>
    /// </summary>
    let WaterRefilling =
        Namespaced_IRI.parse _namespace_name "WaterRefilling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterRefilling/key/shop/value/water_refilling"></see>
    /// </summary>
    let ``WaterRefilling/key/shop/value/water_refilling`` =
        Namespaced_IRI.parse _namespace_name "WaterRefilling/key/shop/value/water_refilling" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterTank"></see>
    /// </summary>
    let WaterTank = Namespaced_IRI.parse _namespace_name "WaterTank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterTank/key/man_made/value/water_tank"></see>
    /// </summary>
    let ``WaterTank/key/man_made/value/water_tank`` =
        Namespaced_IRI.parse _namespace_name "WaterTank/key/man_made/value/water_tank" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterTower"></see>
    /// </summary>
    let WaterTower = Namespaced_IRI.parse _namespace_name "WaterTower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterTower/key/man_made/value/water_tower"></see>
    /// </summary>
    let ``WaterTower/key/man_made/value/water_tower`` =
        Namespaced_IRI.parse _namespace_name "WaterTower/key/man_made/value/water_tower" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWell"></see>
    /// </summary>
    let WaterWell = Namespaced_IRI.parse _namespace_name "WaterWell" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWell/key/man_made/value/water_well"></see>
    /// </summary>
    let ``WaterWell/key/man_made/value/water_well`` =
        Namespaced_IRI.parse _namespace_name "WaterWell/key/man_made/value/water_well" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWell/key/amenity/value/water_well"></see>
    /// </summary>
    let ``WaterWell/key/amenity/value/water_well`` =
        Namespaced_IRI.parse _namespace_name "WaterWell/key/amenity/value/water_well" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWorks"></see>
    /// </summary>
    let WaterWorks = Namespaced_IRI.parse _namespace_name "WaterWorks" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWorks/key/man_made/value/water_works"></see>
    /// </summary>
    let ``WaterWorks/key/man_made/value/water_works`` =
        Namespaced_IRI.parse _namespace_name "WaterWorks/key/man_made/value/water_works" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waterfall"></see>
    /// </summary>
    let Waterfall = Namespaced_IRI.parse _namespace_name "Waterfall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waterfall/key/waterway/value/waterfall"></see>
    /// </summary>
    let ``Waterfall/key/waterway/value/waterfall`` =
        Namespaced_IRI.parse _namespace_name "Waterfall/key/waterway/value/waterfall" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waterhole"></see>
    /// </summary>
    let Waterhole = Namespaced_IRI.parse _namespace_name "Waterhole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waterhole/key/natural/value/waterhole"></see>
    /// </summary>
    let ``Waterhole/key/natural/value/waterhole`` =
        Namespaced_IRI.parse _namespace_name "Waterhole/key/natural/value/waterhole" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WateringPlace"></see>
    /// </summary>
    let WateringPlace =
        Namespaced_IRI.parse _namespace_name "WateringPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WateringPlace/key/amenity/value/watering_place"></see>
    /// </summary>
    let ``WateringPlace/key/amenity/value/watering_place`` =
        Namespaced_IRI.parse _namespace_name "WateringPlace/key/amenity/value/watering_place" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watermill"></see>
    /// </summary>
    let Watermill = Namespaced_IRI.parse _namespace_name "Watermill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watermill/key/man_made/value/watermill"></see>
    /// </summary>
    let ``Watermill/key/man_made/value/watermill`` =
        Namespaced_IRI.parse _namespace_name "Watermill/key/man_made/value/watermill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayDrawbridge"></see>
    /// </summary>
    let WaterwayDrawbridge =
        Namespaced_IRI.parse _namespace_name "WaterwayDrawbridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayDrawbridge/key/waterway/value/drawbridge"></see>
    /// </summary>
    let ``WaterwayDrawbridge/key/waterway/value/drawbridge`` =
        Namespaced_IRI.parse _namespace_name "WaterwayDrawbridge/key/waterway/value/drawbridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayFord"></see>
    /// </summary>
    let WaterwayFord =
        Namespaced_IRI.parse _namespace_name "WaterwayFord" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayFord/key/waterway/value/ford"></see>
    /// </summary>
    let ``WaterwayFord/key/waterway/value/ford`` =
        Namespaced_IRI.parse _namespace_name "WaterwayFord/key/waterway/value/ford" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayFuel"></see>
    /// </summary>
    let WaterwayFuel =
        Namespaced_IRI.parse _namespace_name "WaterwayFuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayFuel/key/waterway/value/fuel"></see>
    /// </summary>
    let ``WaterwayFuel/key/waterway/value/fuel`` =
        Namespaced_IRI.parse _namespace_name "WaterwayFuel/key/waterway/value/fuel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayLock"></see>
    /// </summary>
    let WaterwayLock =
        Namespaced_IRI.parse _namespace_name "WaterwayLock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayLock/key/waterway/value/lock"></see>
    /// </summary>
    let ``WaterwayLock/key/waterway/value/lock`` =
        Namespaced_IRI.parse _namespace_name "WaterwayLock/key/waterway/value/lock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayMilestone"></see>
    /// </summary>
    let WaterwayMilestone =
        Namespaced_IRI.parse _namespace_name "WaterwayMilestone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayMilestone/key/waterway/value/milestone"></see>
    /// </summary>
    let ``WaterwayMilestone/key/waterway/value/milestone`` =
        Namespaced_IRI.parse _namespace_name "WaterwayMilestone/key/waterway/value/milestone" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayPumpingStation"></see>
    /// </summary>
    let WaterwayPumpingStation =
        Namespaced_IRI.parse _namespace_name "WaterwayPumpingStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayPumpingStation/key/waterway/value/pumping_station"></see>
    /// </summary>
    let ``WaterwayPumpingStation/key/waterway/value/pumping_station`` =
        Namespaced_IRI.parse _namespace_name "WaterwayPumpingStation/key/waterway/value/pumping_station" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayRock"></see>
    /// </summary>
    let WaterwayRock =
        Namespaced_IRI.parse _namespace_name "WaterwayRock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayRock/key/waterway/value/rock"></see>
    /// </summary>
    let ``WaterwayRock/key/waterway/value/rock`` =
        Namespaced_IRI.parse _namespace_name "WaterwayRock/key/waterway/value/rock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwaySpring"></see>
    /// </summary>
    let WaterwaySpring =
        Namespaced_IRI.parse _namespace_name "WaterwaySpring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwaySpring/key/waterway/value/spring"></see>
    /// </summary>
    let ``WaterwaySpring/key/waterway/value/spring`` =
        Namespaced_IRI.parse _namespace_name "WaterwaySpring/key/waterway/value/spring" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayWreck"></see>
    /// </summary>
    let WaterwayWreck =
        Namespaced_IRI.parse _namespace_name "WaterwayWreck" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayWreck/key/waterway/value/wreck"></see>
    /// </summary>
    let ``WaterwayWreck/key/waterway/value/wreck`` =
        Namespaced_IRI.parse _namespace_name "WaterwayWreck/key/waterway/value/wreck" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideChapel"></see>
    /// </summary>
    let WaysideChapel =
        Namespaced_IRI.parse _namespace_name "WaysideChapel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideChapel/key/historic/value/wayside_chapel"></see>
    /// </summary>
    let ``WaysideChapel/key/historic/value/wayside_chapel`` =
        Namespaced_IRI.parse _namespace_name "WaysideChapel/key/historic/value/wayside_chapel" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideCross"></see>
    /// </summary>
    let WaysideCross =
        Namespaced_IRI.parse _namespace_name "WaysideCross" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideCross/key/historic/value/wayside_cross%20"></see>
    /// </summary>
    let ``WaysideCross/key/historic/value/wayside_cross%20`` =
        Namespaced_IRI.parse _namespace_name "WaysideCross/key/historic/value/wayside_cross%20" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideShrine"></see>
    /// </summary>
    let WaysideShrine =
        Namespaced_IRI.parse _namespace_name "WaysideShrine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideShrine/key/historic/value/wayside_shrine%20"></see>
    /// </summary>
    let ``WaysideShrine/key/historic/value/wayside_shrine%20`` =
        Namespaced_IRI.parse _namespace_name "WaysideShrine/key/historic/value/wayside_shrine%20" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Weir"></see>
    /// </summary>
    let Weir = Namespaced_IRI.parse _namespace_name "Weir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Weir/key/waterway/value/weir"></see>
    /// </summary>
    let ``Weir/key/waterway/value/weir`` =
        Namespaced_IRI.parse _namespace_name "Weir/key/waterway/value/weir" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Well"></see>
    /// </summary>
    let Well = Namespaced_IRI.parse _namespace_name "Well" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Well/key/amenity/value/well"></see>
    /// </summary>
    let ``Well/key/amenity/value/well`` =
        Namespaced_IRI.parse _namespace_name "Well/key/amenity/value/well" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WellWater"></see>
    /// </summary>
    let WellWater = Namespaced_IRI.parse _namespace_name "WellWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WellWater/key/man_made/value/well_water"></see>
    /// </summary>
    let ``WellWater/key/man_made/value/well_water`` =
        Namespaced_IRI.parse _namespace_name "WellWater/key/man_made/value/well_water" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wetland"></see>
    /// </summary>
    let Wetland = Namespaced_IRI.parse _namespace_name "Wetland" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wetland/key/natural/value/wetland"></see>
    /// </summary>
    let ``Wetland/key/natural/value/wetland`` =
        Namespaced_IRI.parse _namespace_name "Wetland/key/natural/value/wetland" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Whatever"></see>
    /// </summary>
    let Whatever = Namespaced_IRI.parse _namespace_name "Whatever" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Whatever/key/shop/value/whatever"></see>
    /// </summary>
    let ``Whatever/key/shop/value/whatever`` =
        Namespaced_IRI.parse _namespace_name "Whatever/key/shop/value/whatever" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Whirlpool"></see>
    /// </summary>
    let Whirlpool = Namespaced_IRI.parse _namespace_name "Whirlpool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Whirlpool/key/amenity/value/whirlpool"></see>
    /// </summary>
    let ``Whirlpool/key/amenity/value/whirlpool`` =
        Namespaced_IRI.parse _namespace_name "Whirlpool/key/amenity/value/whirlpool" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wholesale"></see>
    /// </summary>
    let Wholesale = Namespaced_IRI.parse _namespace_name "Wholesale" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wholesale/key/shop/value/wholesale"></see>
    /// </summary>
    let ``Wholesale/key/shop/value/wholesale`` =
        Namespaced_IRI.parse _namespace_name "Wholesale/key/shop/value/wholesale" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wifi"></see>
    /// </summary>
    let Wifi = Namespaced_IRI.parse _namespace_name "Wifi" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wifi/key/amenity/value/wifi"></see>
    /// </summary>
    let ``Wifi/key/amenity/value/wifi`` =
        Namespaced_IRI.parse _namespace_name "Wifi/key/amenity/value/wifi" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WildlifeHide"></see>
    /// </summary>
    let WildlifeHide =
        Namespaced_IRI.parse _namespace_name "WildlifeHide" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WildlifeHide/key/man_made/value/wildlife_hide"></see>
    /// </summary>
    let ``WildlifeHide/key/man_made/value/wildlife_hide`` =
        Namespaced_IRI.parse _namespace_name "WildlifeHide/key/man_made/value/wildlife_hide" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windmill"></see>
    /// </summary>
    let Windmill = Namespaced_IRI.parse _namespace_name "Windmill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windmill/key/man_made/value/windmill"></see>
    /// </summary>
    let ``Windmill/key/man_made/value/windmill`` =
        Namespaced_IRI.parse _namespace_name "Windmill/key/man_made/value/windmill" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windows"></see>
    /// </summary>
    let Windows = Namespaced_IRI.parse _namespace_name "Windows" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windows/key/shop/value/windows"></see>
    /// </summary>
    let ``Windows/key/shop/value/windows`` =
        Namespaced_IRI.parse _namespace_name "Windows/key/shop/value/windows" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windpump"></see>
    /// </summary>
    let Windpump = Namespaced_IRI.parse _namespace_name "Windpump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windpump/key/man_made/value/windpump"></see>
    /// </summary>
    let ``Windpump/key/man_made/value/windpump`` =
        Namespaced_IRI.parse _namespace_name "Windpump/key/man_made/value/windpump" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windsock"></see>
    /// </summary>
    let Windsock = Namespaced_IRI.parse _namespace_name "Windsock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windsock/key/aeroway/value/windsock"></see>
    /// </summary>
    let ``Windsock/key/aeroway/value/windsock`` =
        Namespaced_IRI.parse _namespace_name "Windsock/key/aeroway/value/windsock" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wine"></see>
    /// </summary>
    let Wine = Namespaced_IRI.parse _namespace_name "Wine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wine/key/shop/value/wine"></see>
    /// </summary>
    let ``Wine/key/shop/value/wine`` =
        Namespaced_IRI.parse _namespace_name "Wine/key/shop/value/wine" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Winery"></see>
    /// </summary>
    let Winery = Namespaced_IRI.parse _namespace_name "Winery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Winery/key/amenity/value/winery"></see>
    /// </summary>
    let ``Winery/key/amenity/value/winery`` =
        Namespaced_IRI.parse _namespace_name "Winery/key/amenity/value/winery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WineryShop"></see>
    /// </summary>
    let WineryShop = Namespaced_IRI.parse _namespace_name "WineryShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WineryShop/key/shop/value/winery"></see>
    /// </summary>
    let ``WineryShop/key/shop/value/winery`` =
        Namespaced_IRI.parse _namespace_name "WineryShop/key/shop/value/winery" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WinterRoad"></see>
    /// </summary>
    let WinterRoad = Namespaced_IRI.parse _namespace_name "WinterRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WinterRoad/key/winter_road/value/yes"></see>
    /// </summary>
    let ``WinterRoad/key/winter_road/value/yes`` =
        Namespaced_IRI.parse _namespace_name "WinterRoad/key/winter_road/value/yes" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wlan"></see>
    /// </summary>
    let Wlan = Namespaced_IRI.parse _namespace_name "Wlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wlan/key/amenity/value/wlan"></see>
    /// </summary>
    let ``Wlan/key/amenity/value/wlan`` =
        Namespaced_IRI.parse _namespace_name "Wlan/key/amenity/value/wlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WolfPit"></see>
    /// </summary>
    let WolfPit = Namespaced_IRI.parse _namespace_name "WolfPit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WolfPit/key/man_made/value/wolf_pit"></see>
    /// </summary>
    let ``WolfPit/key/man_made/value/wolf_pit`` =
        Namespaced_IRI.parse _namespace_name "WolfPit/key/man_made/value/wolf_pit" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wood"></see>
    /// </summary>
    let Wood = Namespaced_IRI.parse _namespace_name "Wood" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wood/key/natural/value/wood"></see>
    /// </summary>
    let ``Wood/key/natural/value/wood`` =
        Namespaced_IRI.parse _namespace_name "Wood/key/natural/value/wood" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WoodShop"></see>
    /// </summary>
    let WoodShop = Namespaced_IRI.parse _namespace_name "WoodShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WoodShop/key/shop/value/wood"></see>
    /// </summary>
    let ``WoodShop/key/shop/value/wood`` =
        Namespaced_IRI.parse _namespace_name "WoodShop/key/shop/value/wood" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wreck"></see>
    /// </summary>
    let Wreck = Namespaced_IRI.parse _namespace_name "Wreck" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wreck/key/historic/value/wreck%20"></see>
    /// </summary>
    let ``Wreck/key/historic/value/wreck%20`` =
        Namespaced_IRI.parse _namespace_name "Wreck/key/historic/value/wreck%20" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/YouthCentre"></see>
    /// </summary>
    let YouthCentre =
        Namespaced_IRI.parse _namespace_name "YouthCentre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/YouthCentre/key/amenity/value/youth_centre"></see>
    /// </summary>
    let ``YouthCentre/key/amenity/value/youth_centre`` =
        Namespaced_IRI.parse _namespace_name "YouthCentre/key/amenity/value/youth_centre" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/YouthClub"></see>
    /// </summary>
    let YouthClub = Namespaced_IRI.parse _namespace_name "YouthClub" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/YouthClub/key/amenity/value/youth_club"></see>
    /// </summary>
    let ``YouthClub/key/amenity/value/youth_club`` =
        Namespaced_IRI.parse _namespace_name "YouthClub/key/amenity/value/youth_club" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Zoo"></see>
    /// </summary>
    let Zoo = Namespaced_IRI.parse _namespace_name "Zoo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Zoo/key/tourism/value/zoo"></see>
    /// </summary>
    let ``Zoo/key/tourism/value/zoo`` =
        Namespaced_IRI.parse _namespace_name "Zoo/key/tourism/value/zoo" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ZooShop"></see>
    /// </summary>
    let ZooShop = Namespaced_IRI.parse _namespace_name "ZooShop" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ZooShop/key/shop/value/zoo"></see>
    /// </summary>
    let ``ZooShop/key/shop/value/zoo`` =
        Namespaced_IRI.parse _namespace_name "ZooShop/key/shop/value/zoo" |> NamespacedName
