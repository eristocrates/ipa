namespace http.linkedgeodata.org.ontology.slash

open DoxAletheia

module lgdo =
    let _namespace_name = "http://linkedgeodata.org/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ATM"></see>
    /// </summary>
    let ATM = _prefix "ATM"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ATM/key/amenity/value/ATM"></see>
    /// </summary>
    let ``ATM/key/amenity/value/ATM`` = _prefix "ATM/key/amenity/value/ATM"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Amenity"></see>
    /// </summary>
    let Amenity = _prefix "Amenity"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AbandonedRailway"></see>
    /// </summary>
    let AbandonedRailway = _prefix "AbandonedRailway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AbandonedRailway/key/railway/value/abandoned"></see>
    /// </summary>
    let ``AbandonedRailway/key/railway/value/abandoned`` =
        _prefix "AbandonedRailway/key/railway/value/abandoned"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayThing"></see>
    /// </summary>
    let RailwayThing = _prefix "RailwayThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AbandonedStation"></see>
    /// </summary>
    let AbandonedStation = _prefix "AbandonedStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AbandonedStation/key/railway/value/abandoned_station"></see>
    /// </summary>
    let ``AbandonedStation/key/railway/value/abandoned_station`` =
        _prefix "AbandonedStation/key/railway/value/abandoned_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Abbey"></see>
    /// </summary>
    let Abbey = _prefix "Abbey"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Abbey/key/historic/value/abbey"></see>
    /// </summary>
    let ``Abbey/key/historic/value/abbey`` = _prefix "Abbey/key/historic/value/abbey"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricThing"></see>
    /// </summary>
    let HistoricThing = _prefix "HistoricThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Abutters"></see>
    /// </summary>
    let Abutters = _prefix "Abutters"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AccountantOffice"></see>
    /// </summary>
    let AccountantOffice = _prefix "AccountantOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AccountantOffice/key/office/value/accountant"></see>
    /// </summary>
    let ``AccountantOffice/key/office/value/accountant`` =
        _prefix "AccountantOffice/key/office/value/accountant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Office"></see>
    /// </summary>
    let Office = _prefix "Office"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Adit"></see>
    /// </summary>
    let Adit = _prefix "Adit"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Adit/key/man_made/value/adit"></see>
    /// </summary>
    let ``Adit/key/man_made/value/adit`` = _prefix "Adit/key/man_made/value/adit"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeThing"></see>
    /// </summary>
    let ManMadeThing = _prefix "ManMadeThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdministrativeBoundary"></see>
    /// </summary>
    let AdministrativeBoundary = _prefix "AdministrativeBoundary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdministrativeBoundary/key/boundary/value/administrative"></see>
    /// </summary>
    let ``AdministrativeBoundary/key/boundary/value/administrative`` =
        _prefix "AdministrativeBoundary/key/boundary/value/administrative"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boundary"></see>
    /// </summary>
    let Boundary = _prefix "Boundary"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdministrativeOffice"></see>
    /// </summary>
    let AdministrativeOffice = _prefix "AdministrativeOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdministrativeOffice/key/office/value/administrative"></see>
    /// </summary>
    let ``AdministrativeOffice/key/office/value/administrative`` =
        _prefix "AdministrativeOffice/key/office/value/administrative"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdultShop"></see>
    /// </summary>
    let AdultShop = _prefix "AdultShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AdultShop/key/shop/value/adult"></see>
    /// </summary>
    let ``AdultShop/key/shop/value/adult`` = _prefix "AdultShop/key/shop/value/adult"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shop"></see>
    /// </summary>
    let Shop = _prefix "Shop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Advertisement"></see>
    /// </summary>
    let Advertisement = _prefix "Advertisement"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Advertisement/key/amenity/value/advertisement"></see>
    /// </summary>
    let ``Advertisement/key/amenity/value/advertisement`` =
        _prefix "Advertisement/key/amenity/value/advertisement"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Advertising"></see>
    /// </summary>
    let Advertising = _prefix "Advertising"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Advertising/key/amenity/value/advertising"></see>
    /// </summary>
    let ``Advertising/key/amenity/value/advertising`` =
        _prefix "Advertising/key/amenity/value/advertising"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayGoods"></see>
    /// </summary>
    let AerialwayGoods = _prefix "AerialwayGoods"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayGoods/key/aerialway/value/goods"></see>
    /// </summary>
    let ``AerialwayGoods/key/aerialway/value/goods`` =
        _prefix "AerialwayGoods/key/aerialway/value/goods"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayThing"></see>
    /// </summary>
    let AerialwayThing = _prefix "AerialwayThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayStation"></see>
    /// </summary>
    let AerialwayStation = _prefix "AerialwayStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerialwayStation/key/aerialway/value/station"></see>
    /// </summary>
    let ``AerialwayStation/key/aerialway/value/station`` =
        _prefix "AerialwayStation/key/aerialway/value/station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AerowayThing"></see>
    /// </summary>
    let AerowayThing = _prefix "AerowayThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Agrarian"></see>
    /// </summary>
    let Agrarian = _prefix "Agrarian"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Agrarian/key/shop/value/agrarian"></see>
    /// </summary>
    let ``Agrarian/key/shop/value/agrarian`` =
        _prefix "Agrarian/key/shop/value/agrarian"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AgriculturalEnginesCraft"></see>
    /// </summary>
    let AgriculturalEnginesCraft = _prefix "AgriculturalEnginesCraft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AgriculturalEnginesCraft/key/craft/value/agricultural_engines"></see>
    /// </summary>
    let ``AgriculturalEnginesCraft/key/craft/value/agricultural_engines`` =
        _prefix "AgriculturalEnginesCraft/key/craft/value/agricultural_engines"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Craft"></see>
    /// </summary>
    let Craft = _prefix "Craft"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirFill"></see>
    /// </summary>
    let AirFill = _prefix "AirFill"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirFill/key/amenity/value/air_fill"></see>
    /// </summary>
    let ``AirFill/key/amenity/value/air_fill`` =
        _prefix "AirFill/key/amenity/value/air_fill"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airplane"></see>
    /// </summary>
    let Airplane = _prefix "Airplane"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airplane/key/amenity/value/airplane"></see>
    /// </summary>
    let ``Airplane/key/amenity/value/airplane`` =
        _prefix "Airplane/key/amenity/value/airplane"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airport"></see>
    /// </summary>
    let Airport = _prefix "Airport"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airport/key/aeroway/value/aerodrome"></see>
    /// </summary>
    let ``Airport/key/aeroway/value/aerodrome`` =
        _prefix "Airport/key/aeroway/value/aerodrome"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Airport/key/amenity/value/airport"></see>
    /// </summary>
    let ``Airport/key/amenity/value/airport`` =
        _prefix "Airport/key/amenity/value/airport"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportField"></see>
    /// </summary>
    let AirportField = _prefix "AirportField"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportField/key/aeroway/value/airfield"></see>
    /// </summary>
    let ``AirportField/key/aeroway/value/airfield`` =
        _prefix "AirportField/key/aeroway/value/airfield"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportGate"></see>
    /// </summary>
    let AirportGate = _prefix "AirportGate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportGate/key/aeroway/value/gate"></see>
    /// </summary>
    let ``AirportGate/key/aeroway/value/gate`` =
        _prefix "AirportGate/key/aeroway/value/gate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTaxiway"></see>
    /// </summary>
    let AirportTaxiway = _prefix "AirportTaxiway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTaxiway/key/aeroway/value/taxiway"></see>
    /// </summary>
    let ``AirportTaxiway/key/aeroway/value/taxiway`` =
        _prefix "AirportTaxiway/key/aeroway/value/taxiway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTerminal"></see>
    /// </summary>
    let AirportTerminal = _prefix "AirportTerminal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTerminal/key/aeroway/value/terminal"></see>
    /// </summary>
    let ``AirportTerminal/key/aeroway/value/terminal`` =
        _prefix "AirportTerminal/key/aeroway/value/terminal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTower"></see>
    /// </summary>
    let AirportTower = _prefix "AirportTower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AirportTower/key/aeroway/value/tower"></see>
    /// </summary>
    let ``AirportTower/key/aeroway/value/tower`` =
        _prefix "AirportTower/key/aeroway/value/tower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AlcoholShop"></see>
    /// </summary>
    let AlcoholShop = _prefix "AlcoholShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AlcoholShop/key/shop/value/alcohol"></see>
    /// </summary>
    let ``AlcoholShop/key/shop/value/alcohol`` =
        _prefix "AlcoholShop/key/shop/value/alcohol"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Alley"></see>
    /// </summary>
    let Alley = _prefix "Alley"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Alley/key/service/value/alley"></see>
    /// </summary>
    let ``Alley/key/service/value/alley`` = _prefix "Alley/key/service/value/alley"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Allotments"></see>
    /// </summary>
    let Allotments = _prefix "Allotments"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Allotments/key/landuse/value/allotments"></see>
    /// </summary>
    let ``Allotments/key/landuse/value/allotments`` =
        _prefix "Allotments/key/landuse/value/allotments"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landuse"></see>
    /// </summary>
    let Landuse = _prefix "Landuse"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Alm"></see>
    /// </summary>
    let Alm = _prefix "Alm"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Alm/key/amenity/value/alm"></see>
    /// </summary>
    let ``Alm/key/amenity/value/alm`` = _prefix "Alm/key/amenity/value/alm"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AlpineHut"></see>
    /// </summary>
    let AlpineHut = _prefix "AlpineHut"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AlpineHut/key/tourism/value/alpine_hut"></see>
    /// </summary>
    let ``AlpineHut/key/tourism/value/alpine_hut`` =
        _prefix "AlpineHut/key/tourism/value/alpine_hut"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TourismThing"></see>
    /// </summary>
    let TourismThing = _prefix "TourismThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ambulance"></see>
    /// </summary>
    let Ambulance = _prefix "Ambulance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ambulance/key/amenity/value/ambulance"></see>
    /// </summary>
    let ``Ambulance/key/amenity/value/ambulance`` =
        _prefix "Ambulance/key/amenity/value/ambulance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AmbulanceStation"></see>
    /// </summary>
    let AmbulanceStation = _prefix "AmbulanceStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AmbulanceStation/key/amenity/value/ambulance_station"></see>
    /// </summary>
    let ``AmbulanceStation/key/amenity/value/ambulance_station`` =
        _prefix "AmbulanceStation/key/amenity/value/ambulance_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AmbulanceStation/key/emergency/value/ambulance_station"></see>
    /// </summary>
    let ``AmbulanceStation/key/emergency/value/ambulance_station`` =
        _prefix "AmbulanceStation/key/emergency/value/ambulance_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyThing"></see>
    /// </summary>
    let EmergencyThing = _prefix "EmergencyThing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Amenity/key/amenity/value/leisure"></see>
    /// </summary>
    let ``Amenity/key/amenity/value/leisure`` =
        _prefix "Amenity/key/amenity/value/leisure"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalShelter"></see>
    /// </summary>
    let AnimalShelter = _prefix "AnimalShelter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalShelter/key/amenity/value/animal_shelter"></see>
    /// </summary>
    let ``AnimalShelter/key/amenity/value/animal_shelter`` =
        _prefix "AnimalShelter/key/amenity/value/animal_shelter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalShop"></see>
    /// </summary>
    let AnimalShop = _prefix "AnimalShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalShop/key/shop/value/animal"></see>
    /// </summary>
    let ``AnimalShop/key/shop/value/animal`` =
        _prefix "AnimalShop/key/shop/value/animal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalsShop"></see>
    /// </summary>
    let AnimalsShop = _prefix "AnimalsShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimalsShop/key/shop/value/animals"></see>
    /// </summary>
    let ``AnimalsShop/key/shop/value/animals`` =
        _prefix "AnimalsShop/key/shop/value/animals"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimeShop"></see>
    /// </summary>
    let AnimeShop = _prefix "AnimeShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AnimeShop/key/shop/value/anime"></see>
    /// </summary>
    let ``AnimeShop/key/shop/value/anime`` = _prefix "AnimeShop/key/shop/value/anime"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Antenna"></see>
    /// </summary>
    let Antenna = _prefix "Antenna"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Antenna/key/man_made/value/antenna"></see>
    /// </summary>
    let ``Antenna/key/man_made/value/antenna`` =
        _prefix "Antenna/key/man_made/value/antenna"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiqueShop"></see>
    /// </summary>
    let AntiqueShop = _prefix "AntiqueShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiqueShop/key/shop/value/antique"></see>
    /// </summary>
    let ``AntiqueShop/key/shop/value/antique`` =
        _prefix "AntiqueShop/key/shop/value/antique"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiquesShop"></see>
    /// </summary>
    let AntiquesShop = _prefix "AntiquesShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiquesShop/key/shop/value/antiques"></see>
    /// </summary>
    let ``AntiquesShop/key/shop/value/antiques`` =
        _prefix "AntiquesShop/key/shop/value/antiques"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiquitiesShop"></see>
    /// </summary>
    let AntiquitiesShop = _prefix "AntiquitiesShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AntiquitiesShop/key/shop/value/antiquities"></see>
    /// </summary>
    let ``AntiquitiesShop/key/shop/value/antiquities`` =
        _prefix "AntiquitiesShop/key/shop/value/antiquities"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ApartmentBuilding"></see>
    /// </summary>
    let ApartmentBuilding = _prefix "ApartmentBuilding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ApartmentBuilding/key/building/value/apartments"></see>
    /// </summary>
    let ``ApartmentBuilding/key/building/value/apartments`` =
        _prefix "ApartmentBuilding/key/building/value/apartments"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Building"></see>
    /// </summary>
    let Building = _prefix "Building"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Apparel"></see>
    /// </summary>
    let Apparel = _prefix "Apparel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Apparel/key/shop/value/apparel"></see>
    /// </summary>
    let ``Apparel/key/shop/value/apparel`` = _prefix "Apparel/key/shop/value/apparel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Appliance"></see>
    /// </summary>
    let Appliance = _prefix "Appliance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Appliance/key/shop/value/appliance"></see>
    /// </summary>
    let ``Appliance/key/shop/value/appliance`` =
        _prefix "Appliance/key/shop/value/appliance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Appliances"></see>
    /// </summary>
    let Appliances = _prefix "Appliances"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Appliances/key/shop/value/appliances"></see>
    /// </summary>
    let ``Appliances/key/shop/value/appliances`` =
        _prefix "Appliances/key/shop/value/appliances"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Apron"></see>
    /// </summary>
    let Apron = _prefix "Apron"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Apron/key/aeroway/value/apron"></see>
    /// </summary>
    let ``Apron/key/aeroway/value/apron`` = _prefix "Apron/key/aeroway/value/apron"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Aqueduct"></see>
    /// </summary>
    let Aqueduct = _prefix "Aqueduct"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Aqueduct/key/waterway/value/aqueduct"></see>
    /// </summary>
    let ``Aqueduct/key/waterway/value/aqueduct`` =
        _prefix "Aqueduct/key/waterway/value/aqueduct"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayThing"></see>
    /// </summary>
    let WaterwayThing = _prefix "WaterwayThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArchaeologicalSite"></see>
    /// </summary>
    let ArchaeologicalSite = _prefix "ArchaeologicalSite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArchaeologicalSite/key/historic/value/archaeological_site"></see>
    /// </summary>
    let ``ArchaeologicalSite/key/historic/value/archaeological_site`` =
        _prefix "ArchaeologicalSite/key/historic/value/archaeological_site"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArchitectOffice"></see>
    /// </summary>
    let ArchitectOffice = _prefix "ArchitectOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArchitectOffice/key/office/value/architect"></see>
    /// </summary>
    let ``ArchitectOffice/key/office/value/architect`` =
        _prefix "ArchitectOffice/key/office/value/architect"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtGallery"></see>
    /// </summary>
    let ArtGallery = _prefix "ArtGallery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtGallery/key/amenity/value/art_gallery"></see>
    /// </summary>
    let ``ArtGallery/key/amenity/value/art_gallery`` =
        _prefix "ArtGallery/key/amenity/value/art_gallery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtGalleryShop"></see>
    /// </summary>
    let ArtGalleryShop = _prefix "ArtGalleryShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtGalleryShop/key/shop/value/art_gallery"></see>
    /// </summary>
    let ``ArtGalleryShop/key/shop/value/art_gallery`` =
        _prefix "ArtGalleryShop/key/shop/value/art_gallery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtShop"></see>
    /// </summary>
    let ArtShop = _prefix "ArtShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtShop/key/shop/value/art"></see>
    /// </summary>
    let ``ArtShop/key/shop/value/art`` = _prefix "ArtShop/key/shop/value/art"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtSupplies"></see>
    /// </summary>
    let ArtSupplies = _prefix "ArtSupplies"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtSupplies/key/shop/value/art_supplies"></see>
    /// </summary>
    let ``ArtSupplies/key/shop/value/art_supplies`` =
        _prefix "ArtSupplies/key/shop/value/art_supplies"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtsCentre"></see>
    /// </summary>
    let ArtsCentre = _prefix "ArtsCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ArtsCentre/key/amenity/value/arts_centre"></see>
    /// </summary>
    let ``ArtsCentre/key/amenity/value/arts_centre`` =
        _prefix "ArtsCentre/key/amenity/value/arts_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Artwork"></see>
    /// </summary>
    let Artwork = _prefix "Artwork"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Artwork/key/tourism/value/artwork"></see>
    /// </summary>
    let ``Artwork/key/tourism/value/artwork`` =
        _prefix "Artwork/key/tourism/value/artwork"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Artwork/key/amenity/value/artwork"></see>
    /// </summary>
    let ``Artwork/key/amenity/value/artwork`` =
        _prefix "Artwork/key/amenity/value/artwork"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Atm"></see>
    /// </summary>
    let Atm = _prefix "Atm"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Atm/key/amenity/value/atm"></see>
    /// </summary>
    let ``Atm/key/amenity/value/atm`` = _prefix "Atm/key/amenity/value/atm"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Attraction"></see>
    /// </summary>
    let Attraction = _prefix "Attraction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Attraction/key/tourism/value/attraction"></see>
    /// </summary>
    let ``Attraction/key/tourism/value/attraction`` =
        _prefix "Attraction/key/tourism/value/attraction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AudioVideoShop"></see>
    /// </summary>
    let AudioVideoShop = _prefix "AudioVideoShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AudioVideoShop/key/shop/value/audio_video"></see>
    /// </summary>
    let ``AudioVideoShop/key/shop/value/audio_video`` =
        _prefix "AudioVideoShop/key/shop/value/audio_video"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Audiologist"></see>
    /// </summary>
    let Audiologist = _prefix "Audiologist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Audiologist/key/shop/value/audiologist"></see>
    /// </summary>
    let ``Audiologist/key/shop/value/audiologist`` =
        _prefix "Audiologist/key/shop/value/audiologist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutoPartsShop"></see>
    /// </summary>
    let AutoPartsShop = _prefix "AutoPartsShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutoPartsShop/key/shop/value/auto_parts"></see>
    /// </summary>
    let ``AutoPartsShop/key/shop/value/auto_parts`` =
        _prefix "AutoPartsShop/key/shop/value/auto_parts"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutoRepair"></see>
    /// </summary>
    let AutoRepair = _prefix "AutoRepair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutoRepair/key/shop/value/auto_repair"></see>
    /// </summary>
    let ``AutoRepair/key/shop/value/auto_repair`` =
        _prefix "AutoRepair/key/shop/value/auto_repair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutomotiveShop"></see>
    /// </summary>
    let AutomotiveShop = _prefix "AutomotiveShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/AutomotiveShop/key/shop/value/automotive"></see>
    /// </summary>
    let ``AutomotiveShop/key/shop/value/automotive`` =
        _prefix "AutomotiveShop/key/shop/value/automotive"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyGoodsShop"></see>
    /// </summary>
    let BabyGoodsShop = _prefix "BabyGoodsShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyGoodsShop/key/shop/value/baby_goods"></see>
    /// </summary>
    let ``BabyGoodsShop/key/shop/value/baby_goods`` =
        _prefix "BabyGoodsShop/key/shop/value/baby_goods"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyHatch"></see>
    /// </summary>
    let BabyHatch = _prefix "BabyHatch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyHatch/key/amenity/value/baby_hatch"></see>
    /// </summary>
    let ``BabyHatch/key/amenity/value/baby_hatch`` =
        _prefix "BabyHatch/key/amenity/value/baby_hatch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyShop"></see>
    /// </summary>
    let BabyShop = _prefix "BabyShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BabyShop/key/shop/value/baby"></see>
    /// </summary>
    let ``BabyShop/key/shop/value/baby`` = _prefix "BabyShop/key/shop/value/baby"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BagsShop"></see>
    /// </summary>
    let BagsShop = _prefix "BagsShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BagsShop/key/shop/value/bags"></see>
    /// </summary>
    let ``BagsShop/key/shop/value/bags`` = _prefix "BagsShop/key/shop/value/bags"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Baisschool"></see>
    /// </summary>
    let Baisschool = _prefix "Baisschool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Baisschool/key/amenity/value/Baisschool"></see>
    /// </summary>
    let ``Baisschool/key/amenity/value/Baisschool`` =
        _prefix "Baisschool/key/amenity/value/Baisschool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bakery"></see>
    /// </summary>
    let Bakery = _prefix "Bakery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bakery/key/shop/value/bakery"></see>
    /// </summary>
    let ``Bakery/key/shop/value/bakery`` = _prefix "Bakery/key/shop/value/bakery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bakery/key/amenity/value/bakery"></see>
    /// </summary>
    let ``Bakery/key/amenity/value/bakery`` = _prefix "Bakery/key/amenity/value/bakery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bandstand"></see>
    /// </summary>
    let Bandstand = _prefix "Bandstand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bandstand/key/amenity/value/bandstand"></see>
    /// </summary>
    let ``Bandstand/key/amenity/value/bandstand`` =
        _prefix "Bandstand/key/amenity/value/bandstand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bandstand/key/leisure/value/bandstand"></see>
    /// </summary>
    let ``Bandstand/key/leisure/value/bandstand`` =
        _prefix "Bandstand/key/leisure/value/bandstand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Leisure"></see>
    /// </summary>
    let Leisure = _prefix "Leisure"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank"></see>
    /// </summary>
    let Bank = _prefix "Bank"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank/key/amenity/value/Bank"></see>
    /// </summary>
    let ``Bank/key/amenity/value/Bank`` = _prefix "Bank/key/amenity/value/Bank"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank/key/amenity/value/bank"></see>
    /// </summary>
    let ``Bank/key/amenity/value/bank`` = _prefix "Bank/key/amenity/value/bank"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank%2Catm"></see>
    /// </summary>
    let ``Bank%2Catm`` = _prefix "Bank%2Catm"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank%2Catm/key/amenity/value/bank%2Catm"></see>
    /// </summary>
    let ``Bank%2Catm/key/amenity/value/bank%2Catm`` =
        _prefix "Bank%2Catm/key/amenity/value/bank%2Catm"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank%3Batm"></see>
    /// </summary>
    let ``Bank%3Batm`` = _prefix "Bank%3Batm"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bank%3Batm/key/amenity/value/bank%3Batm"></see>
    /// </summary>
    let ``Bank%3Batm/key/amenity/value/bank%3Batm`` =
        _prefix "Bank%3Batm/key/amenity/value/bank%3Batm"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bar"></see>
    /// </summary>
    let Bar = _prefix "Bar"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bar/key/amenity/value/bar"></see>
    /// </summary>
    let ``Bar/key/amenity/value/bar`` = _prefix "Bar/key/amenity/value/bar"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barbeque"></see>
    /// </summary>
    let Barbeque = _prefix "Barbeque"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barbeque/key/amenity/value/barbeque"></see>
    /// </summary>
    let ``Barbeque/key/amenity/value/barbeque`` =
        _prefix "Barbeque/key/amenity/value/barbeque"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barber"></see>
    /// </summary>
    let Barber = _prefix "Barber"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barber/key/shop/value/barber"></see>
    /// </summary>
    let ``Barber/key/shop/value/barber`` = _prefix "Barber/key/shop/value/barber"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barfusspfad"></see>
    /// </summary>
    let Barfusspfad = _prefix "Barfusspfad"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barfusspfad/key/amenity/value/Barfusspfad"></see>
    /// </summary>
    let ``Barfusspfad/key/amenity/value/Barfusspfad`` =
        _prefix "Barfusspfad/key/amenity/value/Barfusspfad"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barracks"></see>
    /// </summary>
    let Barracks = _prefix "Barracks"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Barracks/key/military/value/barracks"></see>
    /// </summary>
    let ``Barracks/key/military/value/barracks`` =
        _prefix "Barracks/key/military/value/barracks"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryThing"></see>
    /// </summary>
    let MilitaryThing = _prefix "MilitaryThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BarrierThing"></see>
    /// </summary>
    let BarrierThing = _prefix "BarrierThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Basin"></see>
    /// </summary>
    let Basin = _prefix "Basin"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Basin/key/landuse/value/basin"></see>
    /// </summary>
    let ``Basin/key/landuse/value/basin`` = _prefix "Basin/key/landuse/value/basin"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BasketMaker"></see>
    /// </summary>
    let BasketMaker = _prefix "BasketMaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BasketMaker/key/craft/value/basket_maker"></see>
    /// </summary>
    let ``BasketMaker/key/craft/value/basket_maker`` =
        _prefix "BasketMaker/key/craft/value/basket_maker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bathroom"></see>
    /// </summary>
    let Bathroom = _prefix "Bathroom"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bathroom/key/shop/value/bathroom"></see>
    /// </summary>
    let ``Bathroom/key/shop/value/bathroom`` =
        _prefix "Bathroom/key/shop/value/bathroom"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BathroomFurnishingShop"></see>
    /// </summary>
    let BathroomFurnishingShop = _prefix "BathroomFurnishingShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BathroomFurnishingShop/key/shop/value/bathroom_furnishing"></see>
    /// </summary>
    let ``BathroomFurnishingShop/key/shop/value/bathroom_furnishing`` =
        _prefix "BathroomFurnishingShop/key/shop/value/bathroom_furnishing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Battlefield"></see>
    /// </summary>
    let Battlefield = _prefix "Battlefield"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Battlefield/key/historic/value/battlefield%20"></see>
    /// </summary>
    let ``Battlefield/key/historic/value/battlefield%20`` =
        _prefix "Battlefield/key/historic/value/battlefield%20"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bay"></see>
    /// </summary>
    let Bay = _prefix "Bay"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bay/key/natural/value/bay"></see>
    /// </summary>
    let ``Bay/key/natural/value/bay`` = _prefix "Bay/key/natural/value/bay"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalThing"></see>
    /// </summary>
    let NaturalThing = _prefix "NaturalThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bbq"></see>
    /// </summary>
    let Bbq = _prefix "Bbq"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bbq/key/amenity/value/bbq"></see>
    /// </summary>
    let ``Bbq/key/amenity/value/bbq`` = _prefix "Bbq/key/amenity/value/bbq"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beach"></see>
    /// </summary>
    let Beach = _prefix "Beach"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beach/key/leisure/value/beach"></see>
    /// </summary>
    let ``Beach/key/leisure/value/beach`` = _prefix "Beach/key/leisure/value/beach"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beach/key/natural/value/beach"></see>
    /// </summary>
    let ``Beach/key/natural/value/beach`` = _prefix "Beach/key/natural/value/beach"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeachResort"></see>
    /// </summary>
    let BeachResort = _prefix "BeachResort"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeachResort/key/leisure/value/beach_resort"></see>
    /// </summary>
    let ``BeachResort/key/leisure/value/beach_resort`` =
        _prefix "BeachResort/key/leisure/value/beach_resort"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beacon"></see>
    /// </summary>
    let Beacon = _prefix "Beacon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beacon/key/man_made/value/beacon"></see>
    /// </summary>
    let ``Beacon/key/man_made/value/beacon`` =
        _prefix "Beacon/key/man_made/value/beacon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beautician"></see>
    /// </summary>
    let Beautician = _prefix "Beautician"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beautician/key/shop/value/beautician"></see>
    /// </summary>
    let ``Beautician/key/shop/value/beautician`` =
        _prefix "Beautician/key/shop/value/beautician"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeautySalon"></see>
    /// </summary>
    let BeautySalon = _prefix "BeautySalon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeautySalon/key/shop/value/beauty_salon"></see>
    /// </summary>
    let ``BeautySalon/key/shop/value/beauty_salon`` =
        _prefix "BeautySalon/key/shop/value/beauty_salon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeautyShop"></see>
    /// </summary>
    let BeautyShop = _prefix "BeautyShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeautyShop/key/shop/value/beauty"></see>
    /// </summary>
    let ``BeautyShop/key/shop/value/beauty`` =
        _prefix "BeautyShop/key/shop/value/beauty"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BedAndBreakfast"></see>
    /// </summary>
    let BedAndBreakfast = _prefix "BedAndBreakfast"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BedAndBreakfast/key/tourism/value/bed_and_breakfast"></see>
    /// </summary>
    let ``BedAndBreakfast/key/tourism/value/bed_and_breakfast`` =
        _prefix "BedAndBreakfast/key/tourism/value/bed_and_breakfast"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BedShop"></see>
    /// </summary>
    let BedShop = _prefix "BedShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BedShop/key/shop/value/bed"></see>
    /// </summary>
    let ``BedShop/key/shop/value/bed`` = _prefix "BedShop/key/shop/value/bed"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bedrock"></see>
    /// </summary>
    let Bedrock = _prefix "Bedrock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bedrock/key/natural/value/bedrock"></see>
    /// </summary>
    let ``Bedrock/key/natural/value/bedrock`` =
        _prefix "Bedrock/key/natural/value/bedrock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beekeeper"></see>
    /// </summary>
    let Beekeeper = _prefix "Beekeeper"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Beekeeper/key/craft/value/beekeeper"></see>
    /// </summary>
    let ``Beekeeper/key/craft/value/beekeeper`` =
        _prefix "Beekeeper/key/craft/value/beekeeper"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bench"></see>
    /// </summary>
    let Bench = _prefix "Bench"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bench/key/amenity/value/bench"></see>
    /// </summary>
    let ``Bench/key/amenity/value/bench`` = _prefix "Bench/key/amenity/value/bench"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Betting"></see>
    /// </summary>
    let Betting = _prefix "Betting"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Betting/key/shop/value/betting"></see>
    /// </summary>
    let ``Betting/key/shop/value/betting`` = _prefix "Betting/key/shop/value/betting"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeverageMarket"></see>
    /// </summary>
    let BeverageMarket = _prefix "BeverageMarket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BeverageMarket/key/shop/value/beverages"></see>
    /// </summary>
    let ``BeverageMarket/key/shop/value/beverages`` =
        _prefix "BeverageMarket/key/shop/value/beverages"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleLockers"></see>
    /// </summary>
    let BicycleLockers = _prefix "BicycleLockers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleLockers/key/amenity/value/bicycle_lockers"></see>
    /// </summary>
    let ``BicycleLockers/key/amenity/value/bicycle_lockers`` =
        _prefix "BicycleLockers/key/amenity/value/bicycle_lockers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleParking"></see>
    /// </summary>
    let BicycleParking = _prefix "BicycleParking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleParking/key/amenity/value/bicycle_parking"></see>
    /// </summary>
    let ``BicycleParking/key/amenity/value/bicycle_parking`` =
        _prefix "BicycleParking/key/amenity/value/bicycle_parking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleRental"></see>
    /// </summary>
    let BicycleRental = _prefix "BicycleRental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleRental/key/amenity/value/bicycle_rental"></see>
    /// </summary>
    let ``BicycleRental/key/amenity/value/bicycle_rental`` =
        _prefix "BicycleRental/key/amenity/value/bicycle_rental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleRoute"></see>
    /// </summary>
    let BicycleRoute = _prefix "BicycleRoute"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleRoute/key/route/value/bicycle"></see>
    /// </summary>
    let ``BicycleRoute/key/route/value/bicycle`` =
        _prefix "BicycleRoute/key/route/value/bicycle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RouteThing"></see>
    /// </summary>
    let RouteThing = _prefix "RouteThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleShop"></see>
    /// </summary>
    let BicycleShop = _prefix "BicycleShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BicycleShop/key/shop/value/bicycle"></see>
    /// </summary>
    let ``BicycleShop/key/shop/value/bicycle`` =
        _prefix "BicycleShop/key/shop/value/bicycle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Biergarten"></see>
    /// </summary>
    let Biergarten = _prefix "Biergarten"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Biergarten/key/amenity/value/biergarten"></see>
    /// </summary>
    let ``Biergarten/key/amenity/value/biergarten`` =
        _prefix "Biergarten/key/amenity/value/biergarten"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Billboard"></see>
    /// </summary>
    let Billboard = _prefix "Billboard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Billboard/key/amenity/value/billboard"></see>
    /// </summary>
    let ``Billboard/key/amenity/value/billboard`` =
        _prefix "Billboard/key/amenity/value/billboard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bingo"></see>
    /// </summary>
    let Bingo = _prefix "Bingo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bingo/key/leisure/value/bingo"></see>
    /// </summary>
    let ``Bingo/key/leisure/value/bingo`` = _prefix "Bingo/key/leisure/value/bingo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BirdHide"></see>
    /// </summary>
    let BirdHide = _prefix "BirdHide"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BirdHide/key/leisure/value/bird_hide"></see>
    /// </summary>
    let ``BirdHide/key/leisure/value/bird_hide`` =
        _prefix "BirdHide/key/leisure/value/bird_hide"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Biwak"></see>
    /// </summary>
    let Biwak = _prefix "Biwak"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Biwak/key/waterway/value/biwak"></see>
    /// </summary>
    let ``Biwak/key/waterway/value/biwak`` = _prefix "Biwak/key/waterway/value/biwak"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Blacksmith"></see>
    /// </summary>
    let Blacksmith = _prefix "Blacksmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Blacksmith/key/craft/value/blacksmith"></see>
    /// </summary>
    let ``Blacksmith/key/craft/value/blacksmith`` =
        _prefix "Blacksmith/key/craft/value/blacksmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Block"></see>
    /// </summary>
    let Block = _prefix "Block"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Block/key/barrier/value/block"></see>
    /// </summary>
    let ``Block/key/barrier/value/block`` = _prefix "Block/key/barrier/value/block"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoatRental"></see>
    /// </summary>
    let BoatRental = _prefix "BoatRental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoatRental/key/amenity/value/boat_rental"></see>
    /// </summary>
    let ``BoatRental/key/amenity/value/boat_rental`` =
        _prefix "BoatRental/key/amenity/value/boat_rental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boatbuilder"></see>
    /// </summary>
    let Boatbuilder = _prefix "Boatbuilder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boatbuilder/key/craft/value/boatbuilder"></see>
    /// </summary>
    let ``Boatbuilder/key/craft/value/boatbuilder`` =
        _prefix "Boatbuilder/key/craft/value/boatbuilder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boatyard"></see>
    /// </summary>
    let Boatyard = _prefix "Boatyard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boatyard/key/waterway/value/boatyard"></see>
    /// </summary>
    let ``Boatyard/key/waterway/value/boatyard`` =
        _prefix "Boatyard/key/waterway/value/boatyard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bollard"></see>
    /// </summary>
    let Bollard = _prefix "Bollard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bollard/key/barrier/value/bollard"></see>
    /// </summary>
    let ``Bollard/key/barrier/value/bollard`` =
        _prefix "Bollard/key/barrier/value/bollard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookShop"></see>
    /// </summary>
    let BookShop = _prefix "BookShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookShop/key/shop/value/books"></see>
    /// </summary>
    let ``BookShop/key/shop/value/books`` = _prefix "BookShop/key/shop/value/books"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bookbinder"></see>
    /// </summary>
    let Bookbinder = _prefix "Bookbinder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bookbinder/key/craft/value/bookbinder"></see>
    /// </summary>
    let ``Bookbinder/key/craft/value/bookbinder`` =
        _prefix "Bookbinder/key/craft/value/bookbinder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookmakerShop"></see>
    /// </summary>
    let BookmakerShop = _prefix "BookmakerShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookmakerShop/key/shop/value/bookmaker"></see>
    /// </summary>
    let ``BookmakerShop/key/shop/value/bookmaker`` =
        _prefix "BookmakerShop/key/shop/value/bookmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookmakersShop"></see>
    /// </summary>
    let BookmakersShop = _prefix "BookmakersShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BookmakersShop/key/shop/value/bookmakers"></see>
    /// </summary>
    let ``BookmakersShop/key/shop/value/bookmakers`` =
        _prefix "BookmakersShop/key/shop/value/bookmakers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BooksShop"></see>
    /// </summary>
    let BooksShop = _prefix "BooksShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BooksShop/key/shop/value/books"></see>
    /// </summary>
    let ``BooksShop/key/shop/value/books`` = _prefix "BooksShop/key/shop/value/books"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BorderControl"></see>
    /// </summary>
    let BorderControl = _prefix "BorderControl"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BorderControl/key/amenity/value/border_control"></see>
    /// </summary>
    let ``BorderControl/key/amenity/value/border_control`` =
        _prefix "BorderControl/key/amenity/value/border_control"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BorderControl/key/barrier/value/border_control"></see>
    /// </summary>
    let ``BorderControl/key/barrier/value/border_control`` =
        _prefix "BorderControl/key/barrier/value/border_control"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Borderstone"></see>
    /// </summary>
    let Borderstone = _prefix "Borderstone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Borderstone/key/man_made/value/borderstone"></see>
    /// </summary>
    let ``Borderstone/key/man_made/value/borderstone`` =
        _prefix "Borderstone/key/man_made/value/borderstone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryForest"></see>
    /// </summary>
    let BoundaryForest = _prefix "BoundaryForest"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryForest/key/boundary/value/forest"></see>
    /// </summary>
    let ``BoundaryForest/key/boundary/value/forest`` =
        _prefix "BoundaryForest/key/boundary/value/forest"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryMarker"></see>
    /// </summary>
    let BoundaryMarker = _prefix "BoundaryMarker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryMarker/key/historic/value/boundary_marker"></see>
    /// </summary>
    let ``BoundaryMarker/key/historic/value/boundary_marker`` =
        _prefix "BoundaryMarker/key/historic/value/boundary_marker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryMarker/key/boundary/value/marker"></see>
    /// </summary>
    let ``BoundaryMarker/key/boundary/value/marker`` =
        _prefix "BoundaryMarker/key/boundary/value/marker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryStone"></see>
    /// </summary>
    let BoundaryStone = _prefix "BoundaryStone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BoundaryStone/key/historic/value/boundary_stone%20"></see>
    /// </summary>
    let ``BoundaryStone/key/historic/value/boundary_stone%20`` =
        _prefix "BoundaryStone/key/historic/value/boundary_stone%20"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boutique"></see>
    /// </summary>
    let Boutique = _prefix "Boutique"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Boutique/key/shop/value/boutique"></see>
    /// </summary>
    let ``Boutique/key/shop/value/boutique`` =
        _prefix "Boutique/key/shop/value/boutique"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brewery"></see>
    /// </summary>
    let Brewery = _prefix "Brewery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brewery/key/amenity/value/brewery"></see>
    /// </summary>
    let ``Brewery/key/amenity/value/brewery`` =
        _prefix "Brewery/key/amenity/value/brewery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brewery/key/craft/value/brewery"></see>
    /// </summary>
    let ``Brewery/key/craft/value/brewery`` = _prefix "Brewery/key/craft/value/brewery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge"></see>
    /// </summary>
    let Bridge = _prefix "Bridge"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge/key/railway/value/bridge"></see>
    /// </summary>
    let ``Bridge/key/railway/value/bridge`` = _prefix "Bridge/key/railway/value/bridge"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge+pier"></see>
    /// </summary>
    let ``Bridge+pier`` = _prefix "Bridge+pier"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge+pier/key/man_made/value/bridge%20pier"></see>
    /// </summary>
    let ``Bridge+pier/key/man_made/value/bridge%20pier`` =
        _prefix "Bridge+pier/key/man_made/value/bridge%20pier"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge+site"></see>
    /// </summary>
    let ``Bridge+site`` = _prefix "Bridge+site"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridge+site/key/historic/value/bridge%20site"></see>
    /// </summary>
    let ``Bridge+site/key/historic/value/bridge%20site`` =
        _prefix "Bridge+site/key/historic/value/bridge%20site"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridleway"></see>
    /// </summary>
    let Bridleway = _prefix "Bridleway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bridleway/key/highway/value/bridleway"></see>
    /// </summary>
    let ``Bridleway/key/highway/value/bridleway`` =
        _prefix "Bridleway/key/highway/value/bridleway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayThing"></see>
    /// </summary>
    let HighwayThing = _prefix "HighwayThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Briefkasten"></see>
    /// </summary>
    let Briefkasten = _prefix "Briefkasten"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Briefkasten/key/amenity/value/Briefkasten"></see>
    /// </summary>
    let ``Briefkasten/key/amenity/value/Briefkasten`` =
        _prefix "Briefkasten/key/amenity/value/Briefkasten"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brothel"></see>
    /// </summary>
    let Brothel = _prefix "Brothel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brothel/key/amenity/value/brothel"></see>
    /// </summary>
    let ``Brothel/key/amenity/value/brothel`` =
        _prefix "Brothel/key/amenity/value/brothel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brownfield"></see>
    /// </summary>
    let Brownfield = _prefix "Brownfield"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Brownfield/key/landuse/value/brownfield"></see>
    /// </summary>
    let ``Brownfield/key/landuse/value/brownfield`` =
        _prefix "Brownfield/key/landuse/value/brownfield"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bts"></see>
    /// </summary>
    let Bts = _prefix "Bts"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bts/key/amenity/value/bts"></see>
    /// </summary>
    let ``Bts/key/amenity/value/bts`` = _prefix "Bts/key/amenity/value/bts"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BufferStop"></see>
    /// </summary>
    let BufferStop = _prefix "BufferStop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BufferStop/key/railway/value/buffer_stop"></see>
    /// </summary>
    let ``BufferStop/key/railway/value/buffer_stop`` =
        _prefix "BufferStop/key/railway/value/buffer_stop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Building/key/building/value/yes"></see>
    /// </summary>
    let ``Building/key/building/value/yes`` = _prefix "Building/key/building/value/yes"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Building/key/building/value/1"></see>
    /// </summary>
    let ``Building/key/building/value/1`` = _prefix "Building/key/building/value/1"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Building/key/amenity/value/building"></see>
    /// </summary>
    let ``Building/key/amenity/value/building`` =
        _prefix "Building/key/amenity/value/building"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBarn"></see>
    /// </summary>
    let BuildingBarn = _prefix "BuildingBarn"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBarn/key/building/value/barn"></see>
    /// </summary>
    let ``BuildingBarn/key/building/value/barn`` =
        _prefix "BuildingBarn/key/building/value/barn"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBuilding"></see>
    /// </summary>
    let BuildingBuilding = _prefix "BuildingBuilding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBuilding/key/building/value/building"></see>
    /// </summary>
    let ``BuildingBuilding/key/building/value/building`` =
        _prefix "BuildingBuilding/key/building/value/building"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBunker"></see>
    /// </summary>
    let BuildingBunker = _prefix "BuildingBunker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingBunker/key/building/value/bunker"></see>
    /// </summary>
    let ``BuildingBunker/key/building/value/bunker`` =
        _prefix "BuildingBunker/key/building/value/bunker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingCabin"></see>
    /// </summary>
    let BuildingCabin = _prefix "BuildingCabin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingCabin/key/building/value/cabin"></see>
    /// </summary>
    let ``BuildingCabin/key/building/value/cabin`` =
        _prefix "BuildingCabin/key/building/value/cabin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingChapel"></see>
    /// </summary>
    let BuildingChapel = _prefix "BuildingChapel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingChapel/key/building/value/chapel"></see>
    /// </summary>
    let ``BuildingChapel/key/building/value/chapel`` =
        _prefix "BuildingChapel/key/building/value/chapel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingChurch"></see>
    /// </summary>
    let BuildingChurch = _prefix "BuildingChurch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingChurch/key/building/value/church"></see>
    /// </summary>
    let ``BuildingChurch/key/building/value/church`` =
        _prefix "BuildingChurch/key/building/value/church"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingCommercial"></see>
    /// </summary>
    let BuildingCommercial = _prefix "BuildingCommercial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingCommercial/key/building/value/commercial"></see>
    /// </summary>
    let ``BuildingCommercial/key/building/value/commercial`` =
        _prefix "BuildingCommercial/key/building/value/commercial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingDormitory"></see>
    /// </summary>
    let BuildingDormitory = _prefix "BuildingDormitory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingDormitory/key/building/value/dormitory"></see>
    /// </summary>
    let ``BuildingDormitory/key/building/value/dormitory`` =
        _prefix "BuildingDormitory/key/building/value/dormitory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingEntrance"></see>
    /// </summary>
    let BuildingEntrance = _prefix "BuildingEntrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingEntrance/key/building/value/entrance"></see>
    /// </summary>
    let ``BuildingEntrance/key/building/value/entrance`` =
        _prefix "BuildingEntrance/key/building/value/entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingEntrance/key/amenity/value/building_entrance"></see>
    /// </summary>
    let ``BuildingEntrance/key/amenity/value/building_entrance`` =
        _prefix "BuildingEntrance/key/amenity/value/building_entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingFarm"></see>
    /// </summary>
    let BuildingFarm = _prefix "BuildingFarm"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingFarm/key/building/value/farm"></see>
    /// </summary>
    let ``BuildingFarm/key/building/value/farm`` =
        _prefix "BuildingFarm/key/building/value/farm"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingGarage"></see>
    /// </summary>
    let BuildingGarage = _prefix "BuildingGarage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingGarage/key/building/value/garage"></see>
    /// </summary>
    let ``BuildingGarage/key/building/value/garage`` =
        _prefix "BuildingGarage/key/building/value/garage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHall"></see>
    /// </summary>
    let BuildingHall = _prefix "BuildingHall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHall/key/building/value/hall"></see>
    /// </summary>
    let ``BuildingHall/key/building/value/hall`` =
        _prefix "BuildingHall/key/building/value/hall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHospital"></see>
    /// </summary>
    let BuildingHospital = _prefix "BuildingHospital"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHospital/key/building/value/hospital"></see>
    /// </summary>
    let ``BuildingHospital/key/building/value/hospital`` =
        _prefix "BuildingHospital/key/building/value/hospital"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHouse"></see>
    /// </summary>
    let BuildingHouse = _prefix "BuildingHouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHouse/key/building/value/house"></see>
    /// </summary>
    let ``BuildingHouse/key/building/value/house`` =
        _prefix "BuildingHouse/key/building/value/house"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHut"></see>
    /// </summary>
    let BuildingHut = _prefix "BuildingHut"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingHut/key/building/value/hut"></see>
    /// </summary>
    let ``BuildingHut/key/building/value/hut`` =
        _prefix "BuildingHut/key/building/value/hut"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingKiosk"></see>
    /// </summary>
    let BuildingKiosk = _prefix "BuildingKiosk"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingKiosk/key/building/value/kiosk"></see>
    /// </summary>
    let ``BuildingKiosk/key/building/value/kiosk`` =
        _prefix "BuildingKiosk/key/building/value/kiosk"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingMonastery"></see>
    /// </summary>
    let BuildingMonastery = _prefix "BuildingMonastery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingMonastery/key/building/value/monastery"></see>
    /// </summary>
    let ``BuildingMonastery/key/building/value/monastery`` =
        _prefix "BuildingMonastery/key/building/value/monastery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingNo"></see>
    /// </summary>
    let BuildingNo = _prefix "BuildingNo"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingNo/key/building/value/no"></see>
    /// </summary>
    let ``BuildingNo/key/building/value/no`` =
        _prefix "BuildingNo/key/building/value/no"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingOffice"></see>
    /// </summary>
    let BuildingOffice = _prefix "BuildingOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingOffice/key/building/value/office"></see>
    /// </summary>
    let ``BuildingOffice/key/building/value/office`` =
        _prefix "BuildingOffice/key/building/value/office"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingResidential"></see>
    /// </summary>
    let BuildingResidential = _prefix "BuildingResidential"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingResidential/key/building/value/residential"></see>
    /// </summary>
    let ``BuildingResidential/key/building/value/residential`` =
        _prefix "BuildingResidential/key/building/value/residential"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingRetail"></see>
    /// </summary>
    let BuildingRetail = _prefix "BuildingRetail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingRetail/key/building/value/retail"></see>
    /// </summary>
    let ``BuildingRetail/key/building/value/retail`` =
        _prefix "BuildingRetail/key/building/value/retail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingSchool"></see>
    /// </summary>
    let BuildingSchool = _prefix "BuildingSchool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingSchool/key/building/value/school"></see>
    /// </summary>
    let ``BuildingSchool/key/building/value/school`` =
        _prefix "BuildingSchool/key/building/value/school"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingTower"></see>
    /// </summary>
    let BuildingTower = _prefix "BuildingTower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingTower/key/building/value/tower"></see>
    /// </summary>
    let ``BuildingTower/key/building/value/tower`` =
        _prefix "BuildingTower/key/building/value/tower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingUniversity"></see>
    /// </summary>
    let BuildingUniversity = _prefix "BuildingUniversity"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingUniversity/key/building/value/university"></see>
    /// </summary>
    let ``BuildingUniversity/key/building/value/university`` =
        _prefix "BuildingUniversity/key/building/value/university"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingUnknown"></see>
    /// </summary>
    let BuildingUnknown = _prefix "BuildingUnknown"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BuildingUnknown/key/building/value/unknown"></see>
    /// </summary>
    let ``BuildingUnknown/key/building/value/unknown`` =
        _prefix "BuildingUnknown/key/building/value/unknown"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bump"></see>
    /// </summary>
    let Bump = _prefix "Bump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Bump/key/traffic_calming/value/bump"></see>
    /// </summary>
    let ``Bump/key/traffic_calming/value/bump`` =
        _prefix "Bump/key/traffic_calming/value/bump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BureauDeChange"></see>
    /// </summary>
    let BureauDeChange = _prefix "BureauDeChange"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BureauDeChange/key/amenity/value/bureau_de_change"></see>
    /// </summary>
    let ``BureauDeChange/key/amenity/value/bureau_de_change`` =
        _prefix "BureauDeChange/key/amenity/value/bureau_de_change"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusGuideway"></see>
    /// </summary>
    let BusGuideway = _prefix "BusGuideway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusGuideway/key/highway/value/bus_guideway"></see>
    /// </summary>
    let ``BusGuideway/key/highway/value/bus_guideway`` =
        _prefix "BusGuideway/key/highway/value/bus_guideway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusRoute"></see>
    /// </summary>
    let BusRoute = _prefix "BusRoute"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusRoute/key/route/value/bus"></see>
    /// </summary>
    let ``BusRoute/key/route/value/bus`` = _prefix "BusRoute/key/route/value/bus"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStation"></see>
    /// </summary>
    let BusStation = _prefix "BusStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStation/key/amenity/value/bus_station"></see>
    /// </summary>
    let ``BusStation/key/amenity/value/bus_station`` =
        _prefix "BusStation/key/amenity/value/bus_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStop"></see>
    /// </summary>
    let BusStop = _prefix "BusStop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStop/key/highway/value/bus_stop"></see>
    /// </summary>
    let ``BusStop/key/highway/value/bus_stop`` =
        _prefix "BusStop/key/highway/value/bus_stop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/BusStop/key/amenity/value/bus_stop"></see>
    /// </summary>
    let ``BusStop/key/amenity/value/bus_stop`` =
        _prefix "BusStop/key/amenity/value/bus_stop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Butcher"></see>
    /// </summary>
    let Butcher = _prefix "Butcher"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Butcher/key/shop/value/butcher"></see>
    /// </summary>
    let ``Butcher/key/shop/value/butcher`` = _prefix "Butcher/key/shop/value/butcher"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Butchers"></see>
    /// </summary>
    let Butchers = _prefix "Butchers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Butchers/key/shop/value/butchers"></see>
    /// </summary>
    let ``Butchers/key/shop/value/butchers`` =
        _prefix "Butchers/key/shop/value/butchers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Byway"></see>
    /// </summary>
    let Byway = _prefix "Byway"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Byway/key/highway/value/byway"></see>
    /// </summary>
    let ``Byway/key/highway/value/byway`` = _prefix "Byway/key/highway/value/byway"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CableCar"></see>
    /// </summary>
    let CableCar = _prefix "CableCar"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CableCar/key/aerialway/value/cable_car"></see>
    /// </summary>
    let ``CableCar/key/aerialway/value/cable_car`` =
        _prefix "CableCar/key/aerialway/value/cable_car"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CableDistributionCabinet"></see>
    /// </summary>
    let CableDistributionCabinet = _prefix "CableDistributionCabinet"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CableDistributionCabinet/key/power/value/cable_distribution_cabinet"></see>
    /// </summary>
    let ``CableDistributionCabinet/key/power/value/cable_distribution_cabinet`` =
        _prefix "CableDistributionCabinet/key/power/value/cable_distribution_cabinet"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerThing"></see>
    /// </summary>
    let PowerThing = _prefix "PowerThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cafe"></see>
    /// </summary>
    let Cafe = _prefix "Cafe"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cafe/key/amenity/value/cafe"></see>
    /// </summary>
    let ``Cafe/key/amenity/value/cafe`` = _prefix "Cafe/key/amenity/value/cafe"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cairn"></see>
    /// </summary>
    let Cairn = _prefix "Cairn"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cairn/key/man_made/value/cairn"></see>
    /// </summary>
    let ``Cairn/key/man_made/value/cairn`` = _prefix "Cairn/key/man_made/value/cairn"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Camera"></see>
    /// </summary>
    let Camera = _prefix "Camera"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Camera/key/amenity/value/camera"></see>
    /// </summary>
    let ``Camera/key/amenity/value/camera`` = _prefix "Camera/key/amenity/value/camera"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CameraShop"></see>
    /// </summary>
    let CameraShop = _prefix "CameraShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CameraShop/key/shop/value/camera"></see>
    /// </summary>
    let ``CameraShop/key/shop/value/camera`` =
        _prefix "CameraShop/key/shop/value/camera"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CampSite"></see>
    /// </summary>
    let CampSite = _prefix "CampSite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CampSite/key/tourism/value/camp_site"></see>
    /// </summary>
    let ``CampSite/key/tourism/value/camp_site`` =
        _prefix "CampSite/key/tourism/value/camp_site"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CampingOffice"></see>
    /// </summary>
    let CampingOffice = _prefix "CampingOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CampingOffice/key/office/value/camping"></see>
    /// </summary>
    let ``CampingOffice/key/office/value/camping`` =
        _prefix "CampingOffice/key/office/value/camping"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Campsite"></see>
    /// </summary>
    let Campsite = _prefix "Campsite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Campsite/key/amenity/value/campsite"></see>
    /// </summary>
    let ``Campsite/key/amenity/value/campsite`` =
        _prefix "Campsite/key/amenity/value/campsite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Canal"></see>
    /// </summary>
    let Canal = _prefix "Canal"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Canal/key/waterway/value/canal"></see>
    /// </summary>
    let ``Canal/key/waterway/value/canal`` = _prefix "Canal/key/waterway/value/canal"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CandyShop"></see>
    /// </summary>
    let CandyShop = _prefix "CandyShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CandyShop/key/shop/value/candy"></see>
    /// </summary>
    let ``CandyShop/key/shop/value/candy`` = _prefix "CandyShop/key/shop/value/candy"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cape"></see>
    /// </summary>
    let Cape = _prefix "Cape"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cape/key/natural/value/cape"></see>
    /// </summary>
    let ``Cape/key/natural/value/cape`` = _prefix "Cape/key/natural/value/cape"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Car%3BcarRepair"></see>
    /// </summary>
    let ``Car%3BcarRepair`` = _prefix "Car%3BcarRepair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Car%3BcarRepair/key/shop/value/car%3Bcar_repair"></see>
    /// </summary>
    let ``Car%3BcarRepair/key/shop/value/car%3Bcar_repair`` =
        _prefix "Car%3BcarRepair/key/shop/value/car%3Bcar_repair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarDealer"></see>
    /// </summary>
    let CarDealer = _prefix "CarDealer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarDealer/key/shop/value/car_dealer"></see>
    /// </summary>
    let ``CarDealer/key/shop/value/car_dealer`` =
        _prefix "CarDealer/key/shop/value/car_dealer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarParts"></see>
    /// </summary>
    let CarParts = _prefix "CarParts"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarParts/key/shop/value/car_parts"></see>
    /// </summary>
    let ``CarParts/key/shop/value/car_parts`` =
        _prefix "CarParts/key/shop/value/car_parts"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRental"></see>
    /// </summary>
    let CarRental = _prefix "CarRental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRental/key/amenity/value/car_rental"></see>
    /// </summary>
    let ``CarRental/key/amenity/value/car_rental`` =
        _prefix "CarRental/key/amenity/value/car_rental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRepair"></see>
    /// </summary>
    let CarRepair = _prefix "CarRepair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRepair/key/amenity/value/car_repair"></see>
    /// </summary>
    let ``CarRepair/key/amenity/value/car_repair`` =
        _prefix "CarRepair/key/amenity/value/car_repair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRepairShop"></see>
    /// </summary>
    let CarRepairShop = _prefix "CarRepairShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarRepairShop/key/shop/value/car_repair"></see>
    /// </summary>
    let ``CarRepairShop/key/shop/value/car_repair`` =
        _prefix "CarRepairShop/key/shop/value/car_repair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarSharing"></see>
    /// </summary>
    let CarSharing = _prefix "CarSharing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarSharing/key/amenity/value/car_sharing"></see>
    /// </summary>
    let ``CarSharing/key/amenity/value/car_sharing`` =
        _prefix "CarSharing/key/amenity/value/car_sharing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarShop"></see>
    /// </summary>
    let CarShop = _prefix "CarShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarShop/key/shop/value/car"></see>
    /// </summary>
    let ``CarShop/key/shop/value/car`` = _prefix "CarShop/key/shop/value/car"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarWash"></see>
    /// </summary>
    let CarWash = _prefix "CarWash"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarWash/key/amenity/value/car_wash"></see>
    /// </summary>
    let ``CarWash/key/amenity/value/car_wash`` =
        _prefix "CarWash/key/amenity/value/car_wash"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarWash/key/shop/value/car_wash"></see>
    /// </summary>
    let ``CarWash/key/shop/value/car_wash`` = _prefix "CarWash/key/shop/value/car_wash"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CaravanSite"></see>
    /// </summary>
    let CaravanSite = _prefix "CaravanSite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CaravanSite/key/tourism/value/caravan_site"></see>
    /// </summary>
    let ``CaravanSite/key/tourism/value/caravan_site`` =
        _prefix "CaravanSite/key/tourism/value/caravan_site"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CardsShop"></see>
    /// </summary>
    let CardsShop = _prefix "CardsShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CardsShop/key/shop/value/cards"></see>
    /// </summary>
    let ``CardsShop/key/shop/value/cards`` = _prefix "CardsShop/key/shop/value/cards"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CareHome"></see>
    /// </summary>
    let CareHome = _prefix "CareHome"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CareHome/key/amenity/value/care_home"></see>
    /// </summary>
    let ``CareHome/key/amenity/value/care_home`` =
        _prefix "CareHome/key/amenity/value/care_home"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpenter"></see>
    /// </summary>
    let Carpenter = _prefix "Carpenter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpenter/key/shop/value/carpenter"></see>
    /// </summary>
    let ``Carpenter/key/shop/value/carpenter`` =
        _prefix "Carpenter/key/shop/value/carpenter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpenter/key/craft/value/carpenter"></see>
    /// </summary>
    let ``Carpenter/key/craft/value/carpenter`` =
        _prefix "Carpenter/key/craft/value/carpenter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpet"></see>
    /// </summary>
    let Carpet = _prefix "Carpet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpet/key/shop/value/carpet"></see>
    /// </summary>
    let ``Carpet/key/shop/value/carpet`` = _prefix "Carpet/key/shop/value/carpet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarpetLayer"></see>
    /// </summary>
    let CarpetLayer = _prefix "CarpetLayer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CarpetLayer/key/craft/value/carpet_layer"></see>
    /// </summary>
    let ``CarpetLayer/key/craft/value/carpet_layer`` =
        _prefix "CarpetLayer/key/craft/value/carpet_layer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpets"></see>
    /// </summary>
    let Carpets = _prefix "Carpets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Carpets/key/shop/value/carpets"></see>
    /// </summary>
    let ``Carpets/key/shop/value/carpets`` = _prefix "Carpets/key/shop/value/carpets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Casino"></see>
    /// </summary>
    let Casino = _prefix "Casino"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Casino/key/leisure/value/casino"></see>
    /// </summary>
    let ``Casino/key/leisure/value/casino`` = _prefix "Casino/key/leisure/value/casino"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Casino/key/amenity/value/casino"></see>
    /// </summary>
    let ``Casino/key/amenity/value/casino`` = _prefix "Casino/key/amenity/value/casino"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Castle"></see>
    /// </summary>
    let Castle = _prefix "Castle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Castle/key/historic/value/castle"></see>
    /// </summary>
    let ``Castle/key/historic/value/castle`` =
        _prefix "Castle/key/historic/value/castle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Catalogue"></see>
    /// </summary>
    let Catalogue = _prefix "Catalogue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Catalogue/key/shop/value/catalogue"></see>
    /// </summary>
    let ``Catalogue/key/shop/value/catalogue`` =
        _prefix "Catalogue/key/shop/value/catalogue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Catere"></see>
    /// </summary>
    let Catere = _prefix "Catere"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Catere/key/craft/value/caterer"></see>
    /// </summary>
    let ``Catere/key/craft/value/caterer`` = _prefix "Catere/key/craft/value/caterer"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CattleGrid"></see>
    /// </summary>
    let CattleGrid = _prefix "CattleGrid"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CattleGrid/key/barrier/value/cattle_grid"></see>
    /// </summary>
    let ``CattleGrid/key/barrier/value/cattle_grid`` =
        _prefix "CattleGrid/key/barrier/value/cattle_grid"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cave"></see>
    /// </summary>
    let Cave = _prefix "Cave"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cave/key/natural/value/cave"></see>
    /// </summary>
    let ``Cave/key/natural/value/cave`` = _prefix "Cave/key/natural/value/cave"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CaveEntrance"></see>
    /// </summary>
    let CaveEntrance = _prefix "CaveEntrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CaveEntrance/key/natural/value/cave_entrance"></see>
    /// </summary>
    let ``CaveEntrance/key/natural/value/cave_entrance`` =
        _prefix "CaveEntrance/key/natural/value/cave_entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CellPhones"></see>
    /// </summary>
    let CellPhones = _prefix "CellPhones"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CellPhones/key/shop/value/cell_phones"></see>
    /// </summary>
    let ``CellPhones/key/shop/value/cell_phones`` =
        _prefix "CellPhones/key/shop/value/cell_phones"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cemetery"></see>
    /// </summary>
    let Cemetery = _prefix "Cemetery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cemetery/key/landuse/value/cemetery"></see>
    /// </summary>
    let ``Cemetery/key/landuse/value/cemetery`` =
        _prefix "Cemetery/key/landuse/value/cemetery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cemetery/key/amenity/value/cemetery"></see>
    /// </summary>
    let ``Cemetery/key/amenity/value/cemetery`` =
        _prefix "Cemetery/key/amenity/value/cemetery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Centre"></see>
    /// </summary>
    let Centre = _prefix "Centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Centre/key/amenity/value/leisure_centre"></see>
    /// </summary>
    let ``Centre/key/amenity/value/leisure_centre`` =
        _prefix "Centre/key/amenity/value/leisure_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ceramics"></see>
    /// </summary>
    let Ceramics = _prefix "Ceramics"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ceramics/key/shop/value/ceramics"></see>
    /// </summary>
    let ``Ceramics/key/shop/value/ceramics`` =
        _prefix "Ceramics/key/shop/value/ceramics"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chain"></see>
    /// </summary>
    let Chain = _prefix "Chain"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chain/key/barrier/value/chain"></see>
    /// </summary>
    let ``Chain/key/barrier/value/chain`` = _prefix "Chain/key/barrier/value/chain"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChairLift"></see>
    /// </summary>
    let ChairLift = _prefix "ChairLift"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChairLift/key/aerialway/value/chair_lift"></see>
    /// </summary>
    let ``ChairLift/key/aerialway/value/chair_lift`` =
        _prefix "ChairLift/key/aerialway/value/chair_lift"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chalet"></see>
    /// </summary>
    let Chalet = _prefix "Chalet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chalet/key/tourism/value/chalet"></see>
    /// </summary>
    let ``Chalet/key/tourism/value/chalet`` = _prefix "Chalet/key/tourism/value/chalet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chandler"></see>
    /// </summary>
    let Chandler = _prefix "Chandler"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chandler/key/shop/value/chandler"></see>
    /// </summary>
    let ``Chandler/key/shop/value/chandler`` =
        _prefix "Chandler/key/shop/value/chandler"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Channel"></see>
    /// </summary>
    let Channel = _prefix "Channel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Channel/key/natural/value/channel"></see>
    /// </summary>
    let ``Channel/key/natural/value/channel`` =
        _prefix "Channel/key/natural/value/channel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chapel"></see>
    /// </summary>
    let Chapel = _prefix "Chapel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chapel/key/amenity/value/chapel"></see>
    /// </summary>
    let ``Chapel/key/amenity/value/chapel`` = _prefix "Chapel/key/amenity/value/chapel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Charity"></see>
    /// </summary>
    let Charity = _prefix "Charity"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Charity/key/amenity/value/charity"></see>
    /// </summary>
    let ``Charity/key/amenity/value/charity`` =
        _prefix "Charity/key/amenity/value/charity"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CharityShop"></see>
    /// </summary>
    let CharityShop = _prefix "CharityShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CharityShop/key/shop/value/charity"></see>
    /// </summary>
    let ``CharityShop/key/shop/value/charity`` =
        _prefix "CharityShop/key/shop/value/charity"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cheese"></see>
    /// </summary>
    let Cheese = _prefix "Cheese"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cheese/key/shop/value/cheese"></see>
    /// </summary>
    let ``Cheese/key/shop/value/cheese`` = _prefix "Cheese/key/shop/value/cheese"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chemist"></see>
    /// </summary>
    let Chemist = _prefix "Chemist"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chemist/key/shop/value/chemist"></see>
    /// </summary>
    let ``Chemist/key/shop/value/chemist`` = _prefix "Chemist/key/shop/value/chemist"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chicane"></see>
    /// </summary>
    let Chicane = _prefix "Chicane"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chicane/key/traffic_calming/value/chicane"></see>
    /// </summary>
    let ``Chicane/key/traffic_calming/value/chicane`` =
        _prefix "Chicane/key/traffic_calming/value/chicane"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChildCare"></see>
    /// </summary>
    let ChildCare = _prefix "ChildCare"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChildCare/key/amenity/value/child_care"></see>
    /// </summary>
    let ``ChildCare/key/amenity/value/child_care`` =
        _prefix "ChildCare/key/amenity/value/child_care"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chimney"></see>
    /// </summary>
    let Chimney = _prefix "Chimney"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chimney/key/man_made/value/chimney"></see>
    /// </summary>
    let ``Chimney/key/man_made/value/chimney`` =
        _prefix "Chimney/key/man_made/value/chimney"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chiropractor"></see>
    /// </summary>
    let Chiropractor = _prefix "Chiropractor"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chiropractor/key/amenity/value/chiropractor"></see>
    /// </summary>
    let ``Chiropractor/key/amenity/value/chiropractor`` =
        _prefix "Chiropractor/key/amenity/value/chiropractor"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chocolate"></see>
    /// </summary>
    let Chocolate = _prefix "Chocolate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Chocolate/key/shop/value/chocolate"></see>
    /// </summary>
    let ``Chocolate/key/shop/value/chocolate`` =
        _prefix "Chocolate/key/shop/value/chocolate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Choker"></see>
    /// </summary>
    let Choker = _prefix "Choker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Choker/key/traffic_calming/value/choker"></see>
    /// </summary>
    let ``Choker/key/traffic_calming/value/choker`` =
        _prefix "Choker/key/traffic_calming/value/choker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Church"></see>
    /// </summary>
    let Church = _prefix "Church"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Church/key/amenity/value/church"></see>
    /// </summary>
    let ``Church/key/amenity/value/church`` = _prefix "Church/key/amenity/value/church"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChurchHall"></see>
    /// </summary>
    let ChurchHall = _prefix "ChurchHall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ChurchHall/key/amenity/value/church_hall"></see>
    /// </summary>
    let ``ChurchHall/key/amenity/value/church_hall`` =
        _prefix "ChurchHall/key/amenity/value/church_hall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cinema"></see>
    /// </summary>
    let Cinema = _prefix "Cinema"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cinema/key/amenity/value/cinema"></see>
    /// </summary>
    let ``Cinema/key/amenity/value/cinema`` = _prefix "Cinema/key/amenity/value/cinema"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CircuitBreaker"></see>
    /// </summary>
    let CircuitBreaker = _prefix "CircuitBreaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CircuitBreaker/key/power/value/circuit_breaker"></see>
    /// </summary>
    let ``CircuitBreaker/key/power/value/circuit_breaker`` =
        _prefix "CircuitBreaker/key/power/value/circuit_breaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/City"></see>
    /// </summary>
    let City = _prefix "City"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/City/key/place/value/city"></see>
    /// </summary>
    let ``City/key/place/value/city`` = _prefix "City/key/place/value/city"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Place"></see>
    /// </summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityGate"></see>
    /// </summary>
    let CityGate = _prefix "CityGate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityGate/key/historic/value/city_gate"></see>
    /// </summary>
    let ``CityGate/key/historic/value/city_gate`` =
        _prefix "CityGate/key/historic/value/city_gate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityLimit"></see>
    /// </summary>
    let CityLimit = _prefix "CityLimit"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityLimit/key/boundary/value/city_limit"></see>
    /// </summary>
    let ``CityLimit/key/boundary/value/city_limit`` =
        _prefix "CityLimit/key/boundary/value/city_limit"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityWall"></see>
    /// </summary>
    let CityWall = _prefix "CityWall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CityWall/key/barrier/value/city_wall"></see>
    /// </summary>
    let ``CityWall/key/barrier/value/city_wall`` =
        _prefix "CityWall/key/barrier/value/city_wall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CitymapPost"></see>
    /// </summary>
    let CitymapPost = _prefix "CitymapPost"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CitymapPost/key/amenity/value/citymap_post"></see>
    /// </summary>
    let ``CitymapPost/key/amenity/value/citymap_post`` =
        _prefix "CitymapPost/key/amenity/value/citymap_post"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CivilBoundary"></see>
    /// </summary>
    let CivilBoundary = _prefix "CivilBoundary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CivilBoundary/key/boundary/value/civil"></see>
    /// </summary>
    let ``CivilBoundary/key/boundary/value/civil`` =
        _prefix "CivilBoundary/key/boundary/value/civil"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cliff"></see>
    /// </summary>
    let Cliff = _prefix "Cliff"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cliff/key/natural/value/cliff"></see>
    /// </summary>
    let ``Cliff/key/natural/value/cliff`` = _prefix "Cliff/key/natural/value/cliff"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clinic"></see>
    /// </summary>
    let Clinic = _prefix "Clinic"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clinic/key/amenity/value/clinic"></see>
    /// </summary>
    let ``Clinic/key/amenity/value/clinic`` = _prefix "Clinic/key/amenity/value/clinic"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clock"></see>
    /// </summary>
    let Clock = _prefix "Clock"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clock/key/amenity/value/clock"></see>
    /// </summary>
    let ``Clock/key/amenity/value/clock`` = _prefix "Clock/key/amenity/value/clock"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clockmaker"></see>
    /// </summary>
    let Clockmaker = _prefix "Clockmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clockmaker/key/craft/value/clockmaker"></see>
    /// </summary>
    let ``Clockmaker/key/craft/value/clockmaker`` =
        _prefix "Clockmaker/key/craft/value/clockmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Closed"></see>
    /// </summary>
    let Closed = _prefix "Closed"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Closed/key/shop/value/closed"></see>
    /// </summary>
    let ``Closed/key/shop/value/closed`` = _prefix "Closed/key/shop/value/closed"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes"></see>
    /// </summary>
    let Clothes = _prefix "Clothes"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes/key/shop/value/clothes"></see>
    /// </summary>
    let ``Clothes/key/shop/value/clothes`` = _prefix "Clothes/key/shop/value/clothes"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes%3A+women"></see>
    /// </summary>
    let ``Clothes%3A+women`` = _prefix "Clothes%3A+women"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes%3A+women/key/shop/value/clothes%3A%20women"></see>
    /// </summary>
    let ``Clothes%3A+women/key/shop/value/clothes%3A%20women`` =
        _prefix "Clothes%3A+women/key/shop/value/clothes%3A%20women"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes%3Awomen"></see>
    /// </summary>
    let ``Clothes%3Awomen`` = _prefix "Clothes%3Awomen"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothes%3Awomen/key/shop/value/clothes%3Awomen"></see>
    /// </summary>
    let ``Clothes%3Awomen/key/shop/value/clothes%3Awomen`` =
        _prefix "Clothes%3Awomen/key/shop/value/clothes%3Awomen"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothing"></see>
    /// </summary>
    let Clothing = _prefix "Clothing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clothing/key/shop/value/clothing"></see>
    /// </summary>
    let ``Clothing/key/shop/value/clothing`` =
        _prefix "Clothing/key/shop/value/clothing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Club"></see>
    /// </summary>
    let Club = _prefix "Club"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Club/key/amenity/value/club"></see>
    /// </summary>
    let ``Club/key/amenity/value/club`` = _prefix "Club/key/amenity/value/club"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Club/key/leisure/value/club"></see>
    /// </summary>
    let ``Club/key/leisure/value/club`` = _prefix "Club/key/leisure/value/club"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ClubHouse"></see>
    /// </summary>
    let ClubHouse = _prefix "ClubHouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ClubHouse/key/amenity/value/club_house"></see>
    /// </summary>
    let ``ClubHouse/key/amenity/value/club_house`` =
        _prefix "ClubHouse/key/amenity/value/club_house"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clubhouse"></see>
    /// </summary>
    let Clubhouse = _prefix "Clubhouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Clubhouse/key/building/value/clubhouse"></see>
    /// </summary>
    let ``Clubhouse/key/building/value/clubhouse`` =
        _prefix "Clubhouse/key/building/value/clubhouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Coastline"></see>
    /// </summary>
    let Coastline = _prefix "Coastline"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Coastline/key/natural/value/coastline"></see>
    /// </summary>
    let ``Coastline/key/natural/value/coastline`` =
        _prefix "Coastline/key/natural/value/coastline"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoffeeShop"></see>
    /// </summary>
    let CoffeeShop = _prefix "CoffeeShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoffeeShop/key/amenity/value/coffeeshop"></see>
    /// </summary>
    let ``CoffeeShop/key/amenity/value/coffeeshop`` =
        _prefix "CoffeeShop/key/amenity/value/coffeeshop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoffeeShop/key/shop/value/coffee"></see>
    /// </summary>
    let ``CoffeeShop/key/shop/value/coffee`` =
        _prefix "CoffeeShop/key/shop/value/coffee"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoffeeShop/key/shop/value/coffee_shop"></see>
    /// </summary>
    let ``CoffeeShop/key/shop/value/coffee_shop`` =
        _prefix "CoffeeShop/key/shop/value/coffee_shop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Col"></see>
    /// </summary>
    let Col = _prefix "Col"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Col/key/natural/value/col"></see>
    /// </summary>
    let ``Col/key/natural/value/col`` = _prefix "Col/key/natural/value/col"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Collapsed"></see>
    /// </summary>
    let Collapsed = _prefix "Collapsed"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Collapsed/key/building/value/collapsed"></see>
    /// </summary>
    let ``Collapsed/key/building/value/collapsed`` =
        _prefix "Collapsed/key/building/value/collapsed"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/College"></see>
    /// </summary>
    let College = _prefix "College"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/College/key/amenity/value/college"></see>
    /// </summary>
    let ``College/key/amenity/value/college`` =
        _prefix "College/key/amenity/value/college"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Commercial"></see>
    /// </summary>
    let Commercial = _prefix "Commercial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Commercial/key/amenity/value/commercial"></see>
    /// </summary>
    let ``Commercial/key/amenity/value/commercial`` =
        _prefix "Commercial/key/amenity/value/commercial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommercialLanduse"></see>
    /// </summary>
    let CommercialLanduse = _prefix "CommercialLanduse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommercialLanduse/key/landuse/value/commercial"></see>
    /// </summary>
    let ``CommercialLanduse/key/landuse/value/commercial`` =
        _prefix "CommercialLanduse/key/landuse/value/commercial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Common"></see>
    /// </summary>
    let Common = _prefix "Common"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Common/key/leisure/value/common"></see>
    /// </summary>
    let ``Common/key/leisure/value/common`` = _prefix "Common/key/leisure/value/common"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Communication"></see>
    /// </summary>
    let Communication = _prefix "Communication"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Communication/key/shop/value/communication"></see>
    /// </summary>
    let ``Communication/key/shop/value/communication`` =
        _prefix "Communication/key/shop/value/communication"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Communications"></see>
    /// </summary>
    let Communications = _prefix "Communications"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Communications/key/shop/value/communications"></see>
    /// </summary>
    let ``Communications/key/shop/value/communications`` =
        _prefix "Communications/key/shop/value/communications"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunicationsTower"></see>
    /// </summary>
    let CommunicationsTower = _prefix "CommunicationsTower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunicationsTower/key/man_made/value/communications_tower"></see>
    /// </summary>
    let ``CommunicationsTower/key/man_made/value/communications_tower`` =
        _prefix "CommunicationsTower/key/man_made/value/communications_tower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunicationsTransponder"></see>
    /// </summary>
    let CommunicationsTransponder = _prefix "CommunicationsTransponder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunicationsTransponder/key/man_made/value/communications_transponder"></see>
    /// </summary>
    let ``CommunicationsTransponder/key/man_made/value/communications_transponder`` =
        _prefix "CommunicationsTransponder/key/man_made/value/communications_transponder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunityCentre"></see>
    /// </summary>
    let CommunityCentre = _prefix "CommunityCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunityCentre/key/amenity/value/community_centre"></see>
    /// </summary>
    let ``CommunityCentre/key/amenity/value/community_centre`` =
        _prefix "CommunityCentre/key/amenity/value/community_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunityHall"></see>
    /// </summary>
    let CommunityHall = _prefix "CommunityHall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CommunityHall/key/amenity/value/community_hall"></see>
    /// </summary>
    let ``CommunityHall/key/amenity/value/community_hall`` =
        _prefix "CommunityHall/key/amenity/value/community_hall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Company"></see>
    /// </summary>
    let Company = _prefix "Company"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Company/key/amenity/value/company"></see>
    /// </summary>
    let ``Company/key/amenity/value/company`` =
        _prefix "Company/key/amenity/value/company"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CompanyOffice"></see>
    /// </summary>
    let CompanyOffice = _prefix "CompanyOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CompanyOffice/key/office/value/company"></see>
    /// </summary>
    let ``CompanyOffice/key/office/value/company`` =
        _prefix "CompanyOffice/key/office/value/company"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Computer"></see>
    /// </summary>
    let Computer = _prefix "Computer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Computer/key/shop/value/computer"></see>
    /// </summary>
    let ``Computer/key/shop/value/computer`` =
        _prefix "Computer/key/shop/value/computer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConcertHall"></see>
    /// </summary>
    let ConcertHall = _prefix "ConcertHall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConcertHall/key/amenity/value/concert_hall"></see>
    /// </summary>
    let ``ConcertHall/key/amenity/value/concert_hall`` =
        _prefix "ConcertHall/key/amenity/value/concert_hall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Condos"></see>
    /// </summary>
    let Condos = _prefix "Condos"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Condos/key/shop/value/condos"></see>
    /// </summary>
    let ``Condos/key/shop/value/condos`` = _prefix "Condos/key/shop/value/condos"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Confectionery"></see>
    /// </summary>
    let Confectionery = _prefix "Confectionery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Confectionery/key/craft/value/confectionery"></see>
    /// </summary>
    let ``Confectionery/key/craft/value/confectionery`` =
        _prefix "Confectionery/key/craft/value/confectionery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Confectionery/key/shop/value/confectionery"></see>
    /// </summary>
    let ``Confectionery/key/shop/value/confectionery`` =
        _prefix "Confectionery/key/shop/value/confectionery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConferenceCentre"></see>
    /// </summary>
    let ConferenceCentre = _prefix "ConferenceCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConferenceCentre/key/amenity/value/conference_centre"></see>
    /// </summary>
    let ``ConferenceCentre/key/amenity/value/conference_centre`` =
        _prefix "ConferenceCentre/key/amenity/value/conference_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Construction"></see>
    /// </summary>
    let Construction = _prefix "Construction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Construction/key/amenity/value/construction"></see>
    /// </summary>
    let ``Construction/key/amenity/value/construction`` =
        _prefix "Construction/key/amenity/value/construction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConstructionLanduse"></see>
    /// </summary>
    let ConstructionLanduse = _prefix "ConstructionLanduse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConstructionLanduse/key/landuse/value/construction"></see>
    /// </summary>
    let ``ConstructionLanduse/key/landuse/value/construction`` =
        _prefix "ConstructionLanduse/key/landuse/value/construction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConstructionShop"></see>
    /// </summary>
    let ConstructionShop = _prefix "ConstructionShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ConstructionShop/key/shop/value/construction"></see>
    /// </summary>
    let ``ConstructionShop/key/shop/value/construction`` =
        _prefix "ConstructionShop/key/shop/value/construction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Consulate"></see>
    /// </summary>
    let Consulate = _prefix "Consulate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Consulate/key/amenity/value/consulate"></see>
    /// </summary>
    let ``Consulate/key/amenity/value/consulate`` =
        _prefix "Consulate/key/amenity/value/consulate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Continent"></see>
    /// </summary>
    let Continent = _prefix "Continent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Continent/key/place/value/continent"></see>
    /// </summary>
    let ``Continent/key/place/value/continent`` =
        _prefix "Continent/key/place/value/continent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Convenience"></see>
    /// </summary>
    let Convenience = _prefix "Convenience"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Convenience/key/shop/value/convenience"></see>
    /// </summary>
    let ``Convenience/key/shop/value/convenience`` =
        _prefix "Convenience/key/shop/value/convenience"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Copyshop"></see>
    /// </summary>
    let Copyshop = _prefix "Copyshop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Copyshop/key/shop/value/copyshop"></see>
    /// </summary>
    let ``Copyshop/key/shop/value/copyshop`` =
        _prefix "Copyshop/key/shop/value/copyshop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cosmetics"></see>
    /// </summary>
    let Cosmetics = _prefix "Cosmetics"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cosmetics/key/shop/value/cosmetics"></see>
    /// </summary>
    let ``Cosmetics/key/shop/value/cosmetics`` =
        _prefix "Cosmetics/key/shop/value/cosmetics"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Country/key/place/value/country"></see>
    /// </summary>
    let ``Country/key/place/value/country`` = _prefix "Country/key/place/value/country"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/County"></see>
    /// </summary>
    let County = _prefix "County"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/County/key/place/value/county"></see>
    /// </summary>
    let ``County/key/place/value/county`` = _prefix "County/key/place/value/county"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Courthouse"></see>
    /// </summary>
    let Courthouse = _prefix "Courthouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Courthouse/key/amenity/value/courthouse"></see>
    /// </summary>
    let ``Courthouse/key/amenity/value/courthouse`` =
        _prefix "Courthouse/key/amenity/value/courthouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoveredReservoir"></see>
    /// </summary>
    let CoveredReservoir = _prefix "CoveredReservoir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CoveredReservoir/key/man_made/value/reservoir_covered"></see>
    /// </summary>
    let ``CoveredReservoir/key/man_made/value/reservoir_covered`` =
        _prefix "CoveredReservoir/key/man_made/value/reservoir_covered"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Craft/key/shop/value/craft"></see>
    /// </summary>
    let ``Craft/key/shop/value/craft`` = _prefix "Craft/key/shop/value/craft"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crafts"></see>
    /// </summary>
    let Crafts = _prefix "Crafts"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crafts/key/shop/value/crafts"></see>
    /// </summary>
    let ``Crafts/key/shop/value/crafts`` = _prefix "Crafts/key/shop/value/crafts"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crane"></see>
    /// </summary>
    let Crane = _prefix "Crane"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crane/key/man_made/value/crane"></see>
    /// </summary>
    let ``Crane/key/man_made/value/crane`` = _prefix "Crane/key/man_made/value/crane"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crater"></see>
    /// </summary>
    let Crater = _prefix "Crater"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crater/key/natural/value/crater"></see>
    /// </summary>
    let ``Crater/key/natural/value/crater`` = _prefix "Crater/key/natural/value/crater"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crematorium"></see>
    /// </summary>
    let Crematorium = _prefix "Crematorium"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Crematorium/key/amenity/value/crematorium"></see>
    /// </summary>
    let ``Crematorium/key/amenity/value/crematorium`` =
        _prefix "Crematorium/key/amenity/value/crematorium"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cross"></see>
    /// </summary>
    let Cross = _prefix "Cross"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cross/key/amenity/value/cross"></see>
    /// </summary>
    let ``Cross/key/amenity/value/cross`` = _prefix "Cross/key/amenity/value/cross"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cushion"></see>
    /// </summary>
    let Cushion = _prefix "Cushion"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cushion/key/traffic_calming/value/cushion"></see>
    /// </summary>
    let ``Cushion/key/traffic_calming/value/cushion`` =
        _prefix "Cushion/key/traffic_calming/value/cushion"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Customs"></see>
    /// </summary>
    let Customs = _prefix "Customs"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Customs/key/amenity/value/customs"></see>
    /// </summary>
    let ``Customs/key/amenity/value/customs`` =
        _prefix "Customs/key/amenity/value/customs"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cutline"></see>
    /// </summary>
    let Cutline = _prefix "Cutline"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cutline/key/man_made/value/cutline"></see>
    /// </summary>
    let ``Cutline/key/man_made/value/cutline`` =
        _prefix "Cutline/key/man_made/value/cutline"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CycleBarrier"></see>
    /// </summary>
    let CycleBarrier = _prefix "CycleBarrier"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CycleBarrier/key/barrier/value/cycle_barrier"></see>
    /// </summary>
    let ``CycleBarrier/key/barrier/value/cycle_barrier`` =
        _prefix "CycleBarrier/key/barrier/value/cycle_barrier"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cycleway"></see>
    /// </summary>
    let Cycleway = _prefix "Cycleway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Cycleway/key/highway/value/cycleway"></see>
    /// </summary>
    let ``Cycleway/key/highway/value/cycleway`` =
        _prefix "Cycleway/key/highway/value/cycleway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayLane"></see>
    /// </summary>
    let CyclewayLane = _prefix "CyclewayLane"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayLane/key/cycleway/value/lane"></see>
    /// </summary>
    let ``CyclewayLane/key/cycleway/value/lane`` =
        _prefix "CyclewayLane/key/cycleway/value/lane"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayThing"></see>
    /// </summary>
    let CyclewayThing = _prefix "CyclewayThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOpposite"></see>
    /// </summary>
    let CyclewayOpposite = _prefix "CyclewayOpposite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOpposite/key/cycleway/value/opposite"></see>
    /// </summary>
    let ``CyclewayOpposite/key/cycleway/value/opposite`` =
        _prefix "CyclewayOpposite/key/cycleway/value/opposite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOppositeLane"></see>
    /// </summary>
    let CyclewayOppositeLane = _prefix "CyclewayOppositeLane"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOppositeLane/key/cycleway/value/opposite_lane"></see>
    /// </summary>
    let ``CyclewayOppositeLane/key/cycleway/value/opposite_lane`` =
        _prefix "CyclewayOppositeLane/key/cycleway/value/opposite_lane"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOppositeTrack"></see>
    /// </summary>
    let CyclewayOppositeTrack = _prefix "CyclewayOppositeTrack"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayOppositeTrack/key/cycleway/value/opposite_track"></see>
    /// </summary>
    let ``CyclewayOppositeTrack/key/cycleway/value/opposite_track`` =
        _prefix "CyclewayOppositeTrack/key/cycleway/value/opposite_track"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayTrack"></see>
    /// </summary>
    let CyclewayTrack = _prefix "CyclewayTrack"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/CyclewayTrack/key/cycleway/value/track"></see>
    /// </summary>
    let ``CyclewayTrack/key/cycleway/value/track`` =
        _prefix "CyclewayTrack/key/cycleway/value/track"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dairy"></see>
    /// </summary>
    let Dairy = _prefix "Dairy"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dairy/key/shop/value/dairy"></see>
    /// </summary>
    let ``Dairy/key/shop/value/dairy`` = _prefix "Dairy/key/shop/value/dairy"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dam"></see>
    /// </summary>
    let Dam = _prefix "Dam"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dam/key/waterway/value/dam"></see>
    /// </summary>
    let ``Dam/key/waterway/value/dam`` = _prefix "Dam/key/waterway/value/dam"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dance"></see>
    /// </summary>
    let Dance = _prefix "Dance"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dance/key/leisure/value/dance"></see>
    /// </summary>
    let ``Dance/key/leisure/value/dance`` = _prefix "Dance/key/leisure/value/dance"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DangerArea"></see>
    /// </summary>
    let DangerArea = _prefix "DangerArea"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DangerArea/key/military/value/danger_area"></see>
    /// </summary>
    let ``DangerArea/key/military/value/danger_area`` =
        _prefix "DangerArea/key/military/value/danger_area"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Daycare"></see>
    /// </summary>
    let Daycare = _prefix "Daycare"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Daycare/key/amenity/value/daycare"></see>
    /// </summary>
    let ``Daycare/key/amenity/value/daycare`` =
        _prefix "Daycare/key/amenity/value/daycare"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DeadPub"></see>
    /// </summary>
    let DeadPub = _prefix "DeadPub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DeadPub/key/amenity/value/dead_pub"></see>
    /// </summary>
    let ``DeadPub/key/amenity/value/dead_pub`` =
        _prefix "DeadPub/key/amenity/value/dead_pub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Decoration"></see>
    /// </summary>
    let Decoration = _prefix "Decoration"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Decoration/key/shop/value/decoration"></see>
    /// </summary>
    let ``Decoration/key/shop/value/decoration`` =
        _prefix "Decoration/key/shop/value/decoration"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Deli"></see>
    /// </summary>
    let Deli = _prefix "Deli"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Deli/key/shop/value/deli"></see>
    /// </summary>
    let ``Deli/key/shop/value/deli`` = _prefix "Deli/key/shop/value/deli"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Delicatessen"></see>
    /// </summary>
    let Delicatessen = _prefix "Delicatessen"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Delicatessen/key/shop/value/delicatessen"></see>
    /// </summary>
    let ``Delicatessen/key/shop/value/delicatessen`` =
        _prefix "Delicatessen/key/shop/value/delicatessen"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dentist"></see>
    /// </summary>
    let Dentist = _prefix "Dentist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dentist/key/amenity/value/dentist"></see>
    /// </summary>
    let ``Dentist/key/amenity/value/dentist`` =
        _prefix "Dentist/key/amenity/value/dentist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DepartmentStore"></see>
    /// </summary>
    let DepartmentStore = _prefix "DepartmentStore"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DepartmentStore/key/shop/value/department_store"></see>
    /// </summary>
    let ``DepartmentStore/key/shop/value/department_store`` =
        _prefix "DepartmentStore/key/shop/value/department_store"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dept"></see>
    /// </summary>
    let Dept = _prefix "Dept"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dept/key/shop/value/dept"></see>
    /// </summary>
    let ``Dept/key/shop/value/dept`` = _prefix "Dept/key/shop/value/dept"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Depth"></see>
    /// </summary>
    let Depth = _prefix "Depth"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Depth/key/waterway/value/depth"></see>
    /// </summary>
    let ``Depth/key/waterway/value/depth`` = _prefix "Depth/key/waterway/value/depth"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Derestricted+speed+limit"></see>
    /// </summary>
    let ``Derestricted+speed+limit`` = _prefix "Derestricted+speed+limit"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Derestricted+speed+limit/key/amenity/value/derestricted%20speed%20limit"></see>
    /// </summary>
    let ``Derestricted+speed+limit/key/amenity/value/derestricted%20speed%20limit`` =
        _prefix "Derestricted+speed+limit/key/amenity/value/derestricted%20speed%20limit"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Design"></see>
    /// </summary>
    let Design = _prefix "Design"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Design/key/shop/value/design"></see>
    /// </summary>
    let ``Design/key/shop/value/design`` = _prefix "Design/key/shop/value/design"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Detached"></see>
    /// </summary>
    let Detached = _prefix "Detached"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Detached/key/building/value/detached"></see>
    /// </summary>
    let ``Detached/key/building/value/detached`` =
        _prefix "Detached/key/building/value/detached"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DetourRoute"></see>
    /// </summary>
    let DetourRoute = _prefix "DetourRoute"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DetourRoute/key/route/value/detour"></see>
    /// </summary>
    let ``DetourRoute/key/route/value/detour`` =
        _prefix "DetourRoute/key/route/value/detour"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Discount"></see>
    /// </summary>
    let Discount = _prefix "Discount"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Discount/key/shop/value/discount"></see>
    /// </summary>
    let ``Discount/key/shop/value/discount`` =
        _prefix "Discount/key/shop/value/discount"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedPub"></see>
    /// </summary>
    let DisusedPub = _prefix "DisusedPub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedPub/key/amenity/value/disused_pub"></see>
    /// </summary>
    let ``DisusedPub/key/amenity/value/disused_pub`` =
        _prefix "DisusedPub/key/amenity/value/disused_pub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedRailway"></see>
    /// </summary>
    let DisusedRailway = _prefix "DisusedRailway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedRailway/key/railway/value/disused"></see>
    /// </summary>
    let ``DisusedRailway/key/railway/value/disused`` =
        _prefix "DisusedRailway/key/railway/value/disused"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedStation"></see>
    /// </summary>
    let DisusedStation = _prefix "DisusedStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DisusedStation/key/railway/value/disused_station"></see>
    /// </summary>
    let ``DisusedStation/key/railway/value/disused_station`` =
        _prefix "DisusedStation/key/railway/value/disused_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ditch"></see>
    /// </summary>
    let Ditch = _prefix "Ditch"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ditch/key/waterway/value/ditch"></see>
    /// </summary>
    let ``Ditch/key/waterway/value/ditch`` = _prefix "Ditch/key/waterway/value/ditch"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DitchBarrier"></see>
    /// </summary>
    let DitchBarrier = _prefix "DitchBarrier"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DitchBarrier/key/barrier/value/ditch"></see>
    /// </summary>
    let ``DitchBarrier/key/barrier/value/ditch`` =
        _prefix "DitchBarrier/key/barrier/value/ditch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DiveCenter"></see>
    /// </summary>
    let DiveCenter = _prefix "DiveCenter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DiveCenter/key/amenity/value/dive_center"></see>
    /// </summary>
    let ``DiveCenter/key/amenity/value/dive_center`` =
        _prefix "DiveCenter/key/amenity/value/dive_center"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DiveCentre"></see>
    /// </summary>
    let DiveCentre = _prefix "DiveCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DiveCentre/key/shop/value/dive_centre"></see>
    /// </summary>
    let ``DiveCentre/key/shop/value/dive_centre`` =
        _prefix "DiveCentre/key/shop/value/dive_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Diy"></see>
    /// </summary>
    let Diy = _prefix "Diy"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Diy/key/shop/value/diy"></see>
    /// </summary>
    let ``Diy/key/shop/value/diy`` = _prefix "Diy/key/shop/value/diy"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dock"></see>
    /// </summary>
    let Dock = _prefix "Dock"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dock/key/waterway/value/dock"></see>
    /// </summary>
    let ``Dock/key/waterway/value/dock`` = _prefix "Dock/key/waterway/value/dock"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doctor"></see>
    /// </summary>
    let Doctor = _prefix "Doctor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doctor/key/amenity/value/doctor"></see>
    /// </summary>
    let ``Doctor/key/amenity/value/doctor`` = _prefix "Doctor/key/amenity/value/doctor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doctors"></see>
    /// </summary>
    let Doctors = _prefix "Doctors"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doctors/key/amenity/value/doctors"></see>
    /// </summary>
    let ``Doctors/key/amenity/value/doctors`` =
        _prefix "Doctors/key/amenity/value/doctors"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogBin"></see>
    /// </summary>
    let DogBin = _prefix "DogBin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogBin/key/amenity/value/dog_bin"></see>
    /// </summary>
    let ``DogBin/key/amenity/value/dog_bin`` =
        _prefix "DogBin/key/amenity/value/dog_bin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogPark"></see>
    /// </summary>
    let DogPark = _prefix "DogPark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogPark/key/leisure/value/dog_park"></see>
    /// </summary>
    let ``DogPark/key/leisure/value/dog_park`` =
        _prefix "DogPark/key/leisure/value/dog_park"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogWaste"></see>
    /// </summary>
    let DogWaste = _prefix "DogWaste"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DogWaste/key/amenity/value/dog_waste"></see>
    /// </summary>
    let ``DogWaste/key/amenity/value/dog_waste`` =
        _prefix "DogWaste/key/amenity/value/dog_waste"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doityourself"></see>
    /// </summary>
    let Doityourself = _prefix "Doityourself"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Doityourself/key/shop/value/doityourself"></see>
    /// </summary>
    let ``Doityourself/key/shop/value/doityourself`` =
        _prefix "Doityourself/key/shop/value/doityourself"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dollar"></see>
    /// </summary>
    let Dollar = _prefix "Dollar"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dollar/key/shop/value/dollar"></see>
    /// </summary>
    let ``Dollar/key/shop/value/dollar`` = _prefix "Dollar/key/shop/value/dollar"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dormitory"></see>
    /// </summary>
    let Dormitory = _prefix "Dormitory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dormitory/key/amenity/value/dormitory"></see>
    /// </summary>
    let ``Dormitory/key/amenity/value/dormitory`` =
        _prefix "Dormitory/key/amenity/value/dormitory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Downhill+Terminal"></see>
    /// </summary>
    let ``Downhill+Terminal`` = _prefix "Downhill+Terminal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Downhill+Terminal/key/man_made/value/Downhill%20Terminal"></see>
    /// </summary>
    let ``Downhill+Terminal/key/man_made/value/Downhill%20Terminal`` =
        _prefix "Downhill+Terminal/key/man_made/value/Downhill%20Terminal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DragLift"></see>
    /// </summary>
    let DragLift = _prefix "DragLift"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DragLift/key/aerialway/value/drag_lift"></see>
    /// </summary>
    let ``DragLift/key/aerialway/value/drag_lift`` =
        _prefix "DragLift/key/aerialway/value/drag_lift"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Drain"></see>
    /// </summary>
    let Drain = _prefix "Drain"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Drain/key/waterway/value/drain"></see>
    /// </summary>
    let ``Drain/key/waterway/value/drain`` = _prefix "Drain/key/waterway/value/drain"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dressmaker"></see>
    /// </summary>
    let Dressmaker = _prefix "Dressmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Dressmaker/key/craft/value/dressmaker"></see>
    /// </summary>
    let ``Dressmaker/key/craft/value/dressmaker`` =
        _prefix "Dressmaker/key/craft/value/dressmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrinkingWater"></see>
    /// </summary>
    let DrinkingWater = _prefix "DrinkingWater"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrinkingWater/key/amenity/value/drinking_water"></see>
    /// </summary>
    let ``DrinkingWater/key/amenity/value/drinking_water`` =
        _prefix "DrinkingWater/key/amenity/value/drinking_water"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DriveWay"></see>
    /// </summary>
    let DriveWay = _prefix "DriveWay"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DriveWay/key/service/value/driveway"></see>
    /// </summary>
    let ``DriveWay/key/service/value/driveway`` =
        _prefix "DriveWay/key/service/value/driveway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrivingSchool"></see>
    /// </summary>
    let DrivingSchool = _prefix "DrivingSchool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrivingSchool/key/amenity/value/driving_school"></see>
    /// </summary>
    let ``DrivingSchool/key/amenity/value/driving_school`` =
        _prefix "DrivingSchool/key/amenity/value/driving_school"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrivingSchoolShop"></see>
    /// </summary>
    let DrivingSchoolShop = _prefix "DrivingSchoolShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DrivingSchoolShop/key/shop/value/driving_school"></see>
    /// </summary>
    let ``DrivingSchoolShop/key/shop/value/driving_school`` =
        _prefix "DrivingSchoolShop/key/shop/value/driving_school"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Drugstore"></see>
    /// </summary>
    let Drugstore = _prefix "Drugstore"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Drugstore/key/shop/value/drugstore"></see>
    /// </summary>
    let ``Drugstore/key/shop/value/drugstore`` =
        _prefix "Drugstore/key/shop/value/drugstore"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DryCleaning"></see>
    /// </summary>
    let DryCleaning = _prefix "DryCleaning"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/DryCleaning/key/shop/value/dry_cleaning"></see>
    /// </summary>
    let ``DryCleaning/key/shop/value/dry_cleaning`` =
        _prefix "DryCleaning/key/shop/value/dry_cleaning"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EducationalInstitutionOffice"></see>
    /// </summary>
    let EducationalInstitutionOffice = _prefix "EducationalInstitutionOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EducationalInstitutionOffice/key/office/value/educational_institution"></see>
    /// </summary>
    let ``EducationalInstitutionOffice/key/office/value/educational_institution`` =
        _prefix "EducationalInstitutionOffice/key/office/value/educational_institution"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electrician"></see>
    /// </summary>
    let Electrician = _prefix "Electrician"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electrician/key/shop/value/electrician"></see>
    /// </summary>
    let ``Electrician/key/shop/value/electrician`` =
        _prefix "Electrician/key/shop/value/electrician"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electrician/key/craft/value/electrician"></see>
    /// </summary>
    let ``Electrician/key/craft/value/electrician`` =
        _prefix "Electrician/key/craft/value/electrician"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electronics"></see>
    /// </summary>
    let Electronics = _prefix "Electronics"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Electronics/key/shop/value/electronics"></see>
    /// </summary>
    let ``Electronics/key/shop/value/electronics`` =
        _prefix "Electronics/key/shop/value/electronics"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Elevator"></see>
    /// </summary>
    let Elevator = _prefix "Elevator"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Elevator/key/amenity/value/elevator"></see>
    /// </summary>
    let ``Elevator/key/amenity/value/elevator`` =
        _prefix "Elevator/key/amenity/value/elevator"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Embassy"></see>
    /// </summary>
    let Embassy = _prefix "Embassy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Embassy/key/amenity/value/embassy"></see>
    /// </summary>
    let ``Embassy/key/amenity/value/embassy`` =
        _prefix "Embassy/key/amenity/value/embassy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyAccessPoint"></see>
    /// </summary>
    let EmergencyAccessPoint = _prefix "EmergencyAccessPoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyAccessPoint/key/highway/value/emergency_access_point"></see>
    /// </summary>
    let ``EmergencyAccessPoint/key/highway/value/emergency_access_point`` =
        _prefix "EmergencyAccessPoint/key/highway/value/emergency_access_point"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyPhone"></see>
    /// </summary>
    let EmergencyPhone = _prefix "EmergencyPhone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyPhone/key/emergency/value/phone"></see>
    /// </summary>
    let ``EmergencyPhone/key/emergency/value/phone`` =
        _prefix "EmergencyPhone/key/emergency/value/phone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyPhone/key/amenity/value/emergency_phone"></see>
    /// </summary>
    let ``EmergencyPhone/key/amenity/value/emergency_phone`` =
        _prefix "EmergencyPhone/key/amenity/value/emergency_phone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencySiren"></see>
    /// </summary>
    let EmergencySiren = _prefix "EmergencySiren"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencySiren/key/emergency/value/siren"></see>
    /// </summary>
    let ``EmergencySiren/key/emergency/value/siren`` =
        _prefix "EmergencySiren/key/emergency/value/siren"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyTelephone"></see>
    /// </summary>
    let EmergencyTelephone = _prefix "EmergencyTelephone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmergencyTelephone/key/amenity/value/emergency_telephone"></see>
    /// </summary>
    let ``EmergencyTelephone/key/amenity/value/emergency_telephone`` =
        _prefix "EmergencyTelephone/key/amenity/value/emergency_telephone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmploymentAgencyOffice"></see>
    /// </summary>
    let EmploymentAgencyOffice = _prefix "EmploymentAgencyOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EmploymentAgencyOffice/key/office/value/employment_agency"></see>
    /// </summary>
    let ``EmploymentAgencyOffice/key/office/value/employment_agency`` =
        _prefix "EmploymentAgencyOffice/key/office/value/employment_agency"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Empty"></see>
    /// </summary>
    let Empty = _prefix "Empty"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Empty/key/shop/value/empty"></see>
    /// </summary>
    let ``Empty/key/shop/value/empty`` = _prefix "Empty/key/shop/value/empty"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entrance"></see>
    /// </summary>
    let Entrance = _prefix "Entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entrance/key/barrier/value/entrance"></see>
    /// </summary>
    let ``Entrance/key/barrier/value/entrance`` =
        _prefix "Entrance/key/barrier/value/entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entrance/key/amenity/value/entrance"></see>
    /// </summary>
    let ``Entrance/key/amenity/value/entrance`` =
        _prefix "Entrance/key/amenity/value/entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entry"></see>
    /// </summary>
    let Entry = _prefix "Entry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Entry/key/building/value/entry"></see>
    /// </summary>
    let ``Entry/key/building/value/entry`` = _prefix "Entry/key/building/value/entry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EnvironmentalHazard"></see>
    /// </summary>
    let EnvironmentalHazard = _prefix "EnvironmentalHazard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EnvironmentalHazard/key/man_made/value/environmental_hazard"></see>
    /// </summary>
    let ``EnvironmentalHazard/key/man_made/value/environmental_hazard`` =
        _prefix "EnvironmentalHazard/key/man_made/value/environmental_hazard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Estanco"></see>
    /// </summary>
    let Estanco = _prefix "Estanco"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Estanco/key/shop/value/estanco"></see>
    /// </summary>
    let ``Estanco/key/shop/value/estanco`` = _prefix "Estanco/key/shop/value/estanco"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EstateAgent"></see>
    /// </summary>
    let EstateAgent = _prefix "EstateAgent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EstateAgent/key/shop/value/estate_agent"></see>
    /// </summary>
    let ``EstateAgent/key/shop/value/estate_agent`` =
        _prefix "EstateAgent/key/shop/value/estate_agent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EstateAgentOffice"></see>
    /// </summary>
    let EstateAgentOffice = _prefix "EstateAgentOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EstateAgentOffice/key/office/value/estate_agent"></see>
    /// </summary>
    let ``EstateAgentOffice/key/office/value/estate_agent`` =
        _prefix "EstateAgentOffice/key/office/value/estate_agent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EvCharging"></see>
    /// </summary>
    let EvCharging = _prefix "EvCharging"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/EvCharging/key/amenity/value/ev_charging"></see>
    /// </summary>
    let ``EvCharging/key/amenity/value/ev_charging`` =
        _prefix "EvCharging/key/amenity/value/ev_charging"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fabric"></see>
    /// </summary>
    let Fabric = _prefix "Fabric"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fabric/key/shop/value/fabric"></see>
    /// </summary>
    let ``Fabric/key/shop/value/fabric`` = _prefix "Fabric/key/shop/value/fabric"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fabrics"></see>
    /// </summary>
    let Fabrics = _prefix "Fabrics"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fabrics/key/shop/value/fabrics"></see>
    /// </summary>
    let ``Fabrics/key/shop/value/fabrics`` = _prefix "Fabrics/key/shop/value/fabrics"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Factory"></see>
    /// </summary>
    let Factory = _prefix "Factory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Factory/key/amenity/value/factory"></see>
    /// </summary>
    let ``Factory/key/amenity/value/factory`` =
        _prefix "Factory/key/amenity/value/factory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fairtrade"></see>
    /// </summary>
    let Fairtrade = _prefix "Fairtrade"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fairtrade/key/shop/value/fairtrade"></see>
    /// </summary>
    let ``Fairtrade/key/shop/value/fairtrade`` =
        _prefix "Fairtrade/key/shop/value/fairtrade"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farm"></see>
    /// </summary>
    let Farm = _prefix "Farm"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farm/key/place/value/farm"></see>
    /// </summary>
    let ``Farm/key/place/value/farm`` = _prefix "Farm/key/place/value/farm"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farm/key/landuse/value/farm"></see>
    /// </summary>
    let ``Farm/key/landuse/value/farm`` = _prefix "Farm/key/landuse/value/farm"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farm/key/amenity/value/farm"></see>
    /// </summary>
    let ``Farm/key/amenity/value/farm`` = _prefix "Farm/key/amenity/value/farm"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FarmShop"></see>
    /// </summary>
    let FarmShop = _prefix "FarmShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FarmShop/key/shop/value/farm"></see>
    /// </summary>
    let ``FarmShop/key/shop/value/farm`` = _prefix "FarmShop/key/shop/value/farm"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FarmShop/key/shop/value/farm_shop"></see>
    /// </summary>
    let ``FarmShop/key/shop/value/farm_shop`` =
        _prefix "FarmShop/key/shop/value/farm_shop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farmland"></see>
    /// </summary>
    let Farmland = _prefix "Farmland"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farmland/key/landuse/value/farmland"></see>
    /// </summary>
    let ``Farmland/key/landuse/value/farmland`` =
        _prefix "Farmland/key/landuse/value/farmland"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farmyard"></see>
    /// </summary>
    let Farmyard = _prefix "Farmyard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Farmyard/key/landuse/value/farmyard"></see>
    /// </summary>
    let ``Farmyard/key/landuse/value/farmyard`` =
        _prefix "Farmyard/key/landuse/value/farmyard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fashion"></see>
    /// </summary>
    let Fashion = _prefix "Fashion"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fashion/key/shop/value/fashion"></see>
    /// </summary>
    let ``Fashion/key/shop/value/fashion`` = _prefix "Fashion/key/shop/value/fashion"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FastFood"></see>
    /// </summary>
    let FastFood = _prefix "FastFood"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FastFood/key/amenity/value/fast_food"></see>
    /// </summary>
    let ``FastFood/key/amenity/value/fast_food`` =
        _prefix "FastFood/key/amenity/value/fast_food"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Feature"></see>
    /// </summary>
    let Feature = _prefix "Feature"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Feature/key/natural/value/feature"></see>
    /// </summary>
    let ``Feature/key/natural/value/feature`` =
        _prefix "Feature/key/natural/value/feature"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fell"></see>
    /// </summary>
    let Fell = _prefix "Fell"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fell/key/natural/value/fell"></see>
    /// </summary>
    let ``Fell/key/natural/value/fell`` = _prefix "Fell/key/natural/value/fell"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fen"></see>
    /// </summary>
    let Fen = _prefix "Fen"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fen/key/natural/value/fen"></see>
    /// </summary>
    let ``Fen/key/natural/value/fen`` = _prefix "Fen/key/natural/value/fen"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fence"></see>
    /// </summary>
    let Fence = _prefix "Fence"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fence/key/barrier/value/fence"></see>
    /// </summary>
    let ``Fence/key/barrier/value/fence`` = _prefix "Fence/key/barrier/value/fence"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FerryRoute"></see>
    /// </summary>
    let FerryRoute = _prefix "FerryRoute"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FerryRoute/key/route/value/ferry"></see>
    /// </summary>
    let ``FerryRoute/key/route/value/ferry`` =
        _prefix "FerryRoute/key/route/value/ferry"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FerryTerminal"></see>
    /// </summary>
    let FerryTerminal = _prefix "FerryTerminal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FerryTerminal/key/amenity/value/ferry_terminal"></see>
    /// </summary>
    let ``FerryTerminal/key/amenity/value/ferry_terminal`` =
        _prefix "FerryTerminal/key/amenity/value/ferry_terminal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Financial"></see>
    /// </summary>
    let Financial = _prefix "Financial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Financial/key/shop/value/financial"></see>
    /// </summary>
    let ``Financial/key/shop/value/financial`` =
        _prefix "Financial/key/shop/value/financial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireBeater"></see>
    /// </summary>
    let FireBeater = _prefix "FireBeater"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireBeater/key/amenity/value/fire_beater"></see>
    /// </summary>
    let ``FireBeater/key/amenity/value/fire_beater`` =
        _prefix "FireBeater/key/amenity/value/fire_beater"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireExtinguisher"></see>
    /// </summary>
    let FireExtinguisher = _prefix "FireExtinguisher"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireExtinguisher/key/emergency/value/fire_extinguisher"></see>
    /// </summary>
    let ``FireExtinguisher/key/emergency/value/fire_extinguisher`` =
        _prefix "FireExtinguisher/key/emergency/value/fire_extinguisher"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireFlapper"></see>
    /// </summary>
    let FireFlapper = _prefix "FireFlapper"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireFlapper/key/emergency/value/fire_flapper"></see>
    /// </summary>
    let ``FireFlapper/key/emergency/value/fire_flapper`` =
        _prefix "FireFlapper/key/emergency/value/fire_flapper"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHose"></see>
    /// </summary>
    let FireHose = _prefix "FireHose"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHose/key/emergency/value/fire_hose"></see>
    /// </summary>
    let ``FireHose/key/emergency/value/fire_hose`` =
        _prefix "FireHose/key/emergency/value/fire_hose"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHydrant"></see>
    /// </summary>
    let FireHydrant = _prefix "FireHydrant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHydrant/key/amenity/value/fire_hydrant"></see>
    /// </summary>
    let ``FireHydrant/key/amenity/value/fire_hydrant`` =
        _prefix "FireHydrant/key/amenity/value/fire_hydrant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireHydrant/key/emergency/value/fire_hydrant"></see>
    /// </summary>
    let ``FireHydrant/key/emergency/value/fire_hydrant`` =
        _prefix "FireHydrant/key/emergency/value/fire_hydrant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireStation"></see>
    /// </summary>
    let FireStation = _prefix "FireStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FireStation/key/amenity/value/fire_station"></see>
    /// </summary>
    let ``FireStation/key/amenity/value/fire_station`` =
        _prefix "FireStation/key/amenity/value/fire_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fireplace"></see>
    /// </summary>
    let Fireplace = _prefix "Fireplace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fireplace/key/amenity/value/fireplace"></see>
    /// </summary>
    let ``Fireplace/key/amenity/value/fireplace`` =
        _prefix "Fireplace/key/amenity/value/fireplace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FirstAid"></see>
    /// </summary>
    let FirstAid = _prefix "FirstAid"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FirstAid/key/amenity/value/first_aid"></see>
    /// </summary>
    let ``FirstAid/key/amenity/value/first_aid`` =
        _prefix "FirstAid/key/amenity/value/first_aid"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fish"></see>
    /// </summary>
    let Fish = _prefix "Fish"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fish/key/shop/value/fish"></see>
    /// </summary>
    let ``Fish/key/shop/value/fish`` = _prefix "Fish/key/shop/value/fish"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fishing"></see>
    /// </summary>
    let Fishing = _prefix "Fishing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fishing/key/leisure/value/fishing"></see>
    /// </summary>
    let ``Fishing/key/leisure/value/fishing`` =
        _prefix "Fishing/key/leisure/value/fishing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FishingShop"></see>
    /// </summary>
    let FishingShop = _prefix "FishingShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FishingShop/key/shop/value/fishing"></see>
    /// </summary>
    let ``FishingShop/key/shop/value/fishing`` =
        _prefix "FishingShop/key/shop/value/fishing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fishmonger"></see>
    /// </summary>
    let Fishmonger = _prefix "Fishmonger"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fishmonger/key/shop/value/fishmonger"></see>
    /// </summary>
    let ``Fishmonger/key/shop/value/fishmonger`` =
        _prefix "Fishmonger/key/shop/value/fishmonger"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fitness"></see>
    /// </summary>
    let Fitness = _prefix "Fitness"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fitness/key/leisure/value/fitness"></see>
    /// </summary>
    let ``Fitness/key/leisure/value/fitness`` =
        _prefix "Fitness/key/leisure/value/fitness"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fitness+trail"></see>
    /// </summary>
    let ``Fitness+trail`` = _prefix "Fitness+trail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fitness+trail/key/leisure/value/fitness%20trail"></see>
    /// </summary>
    let ``Fitness+trail/key/leisure/value/fitness%20trail`` =
        _prefix "Fitness+trail/key/leisure/value/fitness%20trail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FitnessCentre"></see>
    /// </summary>
    let FitnessCentre = _prefix "FitnessCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FitnessCentre/key/leisure/value/fitness_centre"></see>
    /// </summary>
    let ``FitnessCentre/key/leisure/value/fitness_centre`` =
        _prefix "FitnessCentre/key/leisure/value/fitness_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FitnessShop"></see>
    /// </summary>
    let FitnessShop = _prefix "FitnessShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FitnessShop/key/shop/value/fitness"></see>
    /// </summary>
    let ``FitnessShop/key/shop/value/fitness`` =
        _prefix "FitnessShop/key/shop/value/fitness"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fjord"></see>
    /// </summary>
    let Fjord = _prefix "Fjord"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fjord/key/natural/value/fjord"></see>
    /// </summary>
    let ``Fjord/key/natural/value/fjord`` = _prefix "Fjord/key/natural/value/fjord"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flagpole"></see>
    /// </summary>
    let Flagpole = _prefix "Flagpole"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flagpole/key/man_made/value/flagpole"></see>
    /// </summary>
    let ``Flagpole/key/man_made/value/flagpole`` =
        _prefix "Flagpole/key/man_made/value/flagpole"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flats"></see>
    /// </summary>
    let Flats = _prefix "Flats"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flats/key/building/value/flats"></see>
    /// </summary>
    let ``Flats/key/building/value/flats`` = _prefix "Flats/key/building/value/flats"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flooring"></see>
    /// </summary>
    let Flooring = _prefix "Flooring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flooring/key/shop/value/flooring"></see>
    /// </summary>
    let ``Flooring/key/shop/value/flooring`` =
        _prefix "Flooring/key/shop/value/flooring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Florist"></see>
    /// </summary>
    let Florist = _prefix "Florist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Florist/key/amenity/value/florist"></see>
    /// </summary>
    let ``Florist/key/amenity/value/florist`` =
        _prefix "Florist/key/amenity/value/florist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FloristShop"></see>
    /// </summary>
    let FloristShop = _prefix "FloristShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FloristShop/key/shop/value/florist"></see>
    /// </summary>
    let ``FloristShop/key/shop/value/florist`` =
        _prefix "FloristShop/key/shop/value/florist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flowers"></see>
    /// </summary>
    let Flowers = _prefix "Flowers"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Flowers/key/shop/value/flowers"></see>
    /// </summary>
    let ``Flowers/key/shop/value/flowers`` = _prefix "Flowers/key/shop/value/flowers"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FolkArt"></see>
    /// </summary>
    let FolkArt = _prefix "FolkArt"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FolkArt/key/shop/value/folk_art"></see>
    /// </summary>
    let ``FolkArt/key/shop/value/folk_art`` = _prefix "FolkArt/key/shop/value/folk_art"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Food"></see>
    /// </summary>
    let Food = _prefix "Food"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Food/key/shop/value/food"></see>
    /// </summary>
    let ``Food/key/shop/value/food`` = _prefix "Food/key/shop/value/food"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FoodCourt"></see>
    /// </summary>
    let FoodCourt = _prefix "FoodCourt"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FoodCourt/key/amenity/value/food_court"></see>
    /// </summary>
    let ``FoodCourt/key/amenity/value/food_court`` =
        _prefix "FoodCourt/key/amenity/value/food_court"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FootShower"></see>
    /// </summary>
    let FootShower = _prefix "FootShower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FootShower/key/amenity/value/foot_shower"></see>
    /// </summary>
    let ``FootShower/key/amenity/value/foot_shower`` =
        _prefix "FootShower/key/amenity/value/foot_shower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Footway"></see>
    /// </summary>
    let Footway = _prefix "Footway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Footway/key/highway/value/footway"></see>
    /// </summary>
    let ``Footway/key/highway/value/footway`` =
        _prefix "Footway/key/highway/value/footway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Forest"></see>
    /// </summary>
    let Forest = _prefix "Forest"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Forest/key/landuse/value/forest"></see>
    /// </summary>
    let ``Forest/key/landuse/value/forest`` = _prefix "Forest/key/landuse/value/forest"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Forester"></see>
    /// </summary>
    let Forester = _prefix "Forester"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Forester/key/amenity/value/forester"></see>
    /// </summary>
    let ``Forester/key/amenity/value/forester`` =
        _prefix "Forester/key/amenity/value/forester"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fort"></see>
    /// </summary>
    let Fort = _prefix "Fort"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fort/key/historic/value/fort"></see>
    /// </summary>
    let ``Fort/key/historic/value/fort`` = _prefix "Fort/key/historic/value/fort"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fortress"></see>
    /// </summary>
    let Fortress = _prefix "Fortress"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fortress/key/building/value/fortress"></see>
    /// </summary>
    let ``Fortress/key/building/value/fortress`` =
        _prefix "Fortress/key/building/value/fortress"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Foto"></see>
    /// </summary>
    let Foto = _prefix "Foto"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Foto/key/shop/value/foto"></see>
    /// </summary>
    let ``Foto/key/shop/value/foto`` = _prefix "Foto/key/shop/value/foto"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fountain"></see>
    /// </summary>
    let Fountain = _prefix "Fountain"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fountain/key/amenity/value/fountain"></see>
    /// </summary>
    let ``Fountain/key/amenity/value/fountain`` =
        _prefix "Fountain/key/amenity/value/fountain"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fraternity"></see>
    /// </summary>
    let Fraternity = _prefix "Fraternity"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fraternity/key/amenity/value/fraternity"></see>
    /// </summary>
    let ``Fraternity/key/amenity/value/fraternity`` =
        _prefix "Fraternity/key/amenity/value/fraternity"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FrozenFoodShop"></see>
    /// </summary>
    let FrozenFoodShop = _prefix "FrozenFoodShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FrozenFoodShop/key/shop/value/frozen_food"></see>
    /// </summary>
    let ``FrozenFoodShop/key/shop/value/frozen_food`` =
        _prefix "FrozenFoodShop/key/shop/value/frozen_food"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fruit"></see>
    /// </summary>
    let Fruit = _prefix "Fruit"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fruit/key/shop/value/fruit"></see>
    /// </summary>
    let ``Fruit/key/shop/value/fruit`` = _prefix "Fruit/key/shop/value/fruit"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fuel%3BcarWash"></see>
    /// </summary>
    let ``Fuel%3BcarWash`` = _prefix "Fuel%3BcarWash"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Fuel%3BcarWash/key/amenity/value/fuel%3Bcar_wash"></see>
    /// </summary>
    let ``Fuel%3BcarWash/key/amenity/value/fuel%3Bcar_wash`` =
        _prefix "Fuel%3BcarWash/key/amenity/value/fuel%3Bcar_wash"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuelStation"></see>
    /// </summary>
    let FuelStation = _prefix "FuelStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuelStation/key/amenity/value/fuel"></see>
    /// </summary>
    let ``FuelStation/key/amenity/value/fuel`` =
        _prefix "FuelStation/key/amenity/value/fuel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuneralDirectors"></see>
    /// </summary>
    let FuneralDirectors = _prefix "FuneralDirectors"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuneralDirectors/key/shop/value/funeral_directors"></see>
    /// </summary>
    let ``FuneralDirectors/key/shop/value/funeral_directors`` =
        _prefix "FuneralDirectors/key/shop/value/funeral_directors"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuneralHome"></see>
    /// </summary>
    let FuneralHome = _prefix "FuneralHome"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FuneralHome/key/amenity/value/funeral_home"></see>
    /// </summary>
    let ``FuneralHome/key/amenity/value/funeral_home`` =
        _prefix "FuneralHome/key/amenity/value/funeral_home"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FunicularRailway"></see>
    /// </summary>
    let FunicularRailway = _prefix "FunicularRailway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/FunicularRailway/key/railway/value/funicular"></see>
    /// </summary>
    let ``FunicularRailway/key/railway/value/funicular`` =
        _prefix "FunicularRailway/key/railway/value/funicular"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Furniture"></see>
    /// </summary>
    let Furniture = _prefix "Furniture"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Furniture/key/shop/value/furniture"></see>
    /// </summary>
    let ``Furniture/key/shop/value/furniture`` =
        _prefix "Furniture/key/shop/value/furniture"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GagingStation"></see>
    /// </summary>
    let GagingStation = _prefix "GagingStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GagingStation/key/man_made/value/gaging_station"></see>
    /// </summary>
    let ``GagingStation/key/man_made/value/gaging_station`` =
        _prefix "GagingStation/key/man_made/value/gaging_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gallery"></see>
    /// </summary>
    let Gallery = _prefix "Gallery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gallery/key/amenity/value/gallery"></see>
    /// </summary>
    let ``Gallery/key/amenity/value/gallery`` =
        _prefix "Gallery/key/amenity/value/gallery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GalleryShop"></see>
    /// </summary>
    let GalleryShop = _prefix "GalleryShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GalleryShop/key/shop/value/gallery"></see>
    /// </summary>
    let ``GalleryShop/key/shop/value/gallery`` =
        _prefix "GalleryShop/key/shop/value/gallery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gambling"></see>
    /// </summary>
    let Gambling = _prefix "Gambling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gambling/key/amenity/value/gambling"></see>
    /// </summary>
    let ``Gambling/key/amenity/value/gambling`` =
        _prefix "Gambling/key/amenity/value/gambling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GamblingShop"></see>
    /// </summary>
    let GamblingShop = _prefix "GamblingShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GamblingShop/key/shop/value/gambling"></see>
    /// </summary>
    let ``GamblingShop/key/shop/value/gambling`` =
        _prefix "GamblingShop/key/shop/value/gambling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Games"></see>
    /// </summary>
    let Games = _prefix "Games"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Games/key/shop/value/games"></see>
    /// </summary>
    let ``Games/key/shop/value/games`` = _prefix "Games/key/shop/value/games"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garage"></see>
    /// </summary>
    let Garage = _prefix "Garage"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garage/key/amenity/value/garage"></see>
    /// </summary>
    let ``Garage/key/amenity/value/garage`` = _prefix "Garage/key/amenity/value/garage"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GarageShop"></see>
    /// </summary>
    let GarageShop = _prefix "GarageShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GarageShop/key/shop/value/garage"></see>
    /// </summary>
    let ``GarageShop/key/shop/value/garage`` =
        _prefix "GarageShop/key/shop/value/garage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garages"></see>
    /// </summary>
    let Garages = _prefix "Garages"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garages/key/landuse/value/garages"></see>
    /// </summary>
    let ``Garages/key/landuse/value/garages`` =
        _prefix "Garages/key/landuse/value/garages"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garbage"></see>
    /// </summary>
    let Garbage = _prefix "Garbage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garbage/key/amenity/value/garbage"></see>
    /// </summary>
    let ``Garbage/key/amenity/value/garbage`` =
        _prefix "Garbage/key/amenity/value/garbage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garden"></see>
    /// </summary>
    let Garden = _prefix "Garden"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Garden/key/leisure/value/garden"></see>
    /// </summary>
    let ``Garden/key/leisure/value/garden`` = _prefix "Garden/key/leisure/value/garden"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenCenter"></see>
    /// </summary>
    let GardenCenter = _prefix "GardenCenter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenCenter/key/shop/value/garden_center"></see>
    /// </summary>
    let ``GardenCenter/key/shop/value/garden_center`` =
        _prefix "GardenCenter/key/shop/value/garden_center"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenCentre"></see>
    /// </summary>
    let GardenCentre = _prefix "GardenCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenCentre/key/shop/value/garden_centre"></see>
    /// </summary>
    let ``GardenCentre/key/shop/value/garden_centre`` =
        _prefix "GardenCentre/key/shop/value/garden_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenShop"></see>
    /// </summary>
    let GardenShop = _prefix "GardenShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GardenShop/key/shop/value/garden"></see>
    /// </summary>
    let ``GardenShop/key/shop/value/garden`` =
        _prefix "GardenShop/key/shop/value/garden"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gardener"></see>
    /// </summary>
    let Gardener = _prefix "Gardener"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gardener/key/craft/value/gardener"></see>
    /// </summary>
    let ``Gardener/key/craft/value/gardener`` =
        _prefix "Gardener/key/craft/value/gardener"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gasometer"></see>
    /// </summary>
    let Gasometer = _prefix "Gasometer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gasometer/key/man_made/value/gasometer"></see>
    /// </summary>
    let ``Gasometer/key/man_made/value/gasometer`` =
        _prefix "Gasometer/key/man_made/value/gasometer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gate"></see>
    /// </summary>
    let Gate = _prefix "Gate"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gate/key/barrier/value/gate"></see>
    /// </summary>
    let ``Gate/key/barrier/value/gate`` = _prefix "Gate/key/barrier/value/gate"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gazometer"></see>
    /// </summary>
    let Gazometer = _prefix "Gazometer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gazometer/key/man_made/value/gazometer"></see>
    /// </summary>
    let ``Gazometer/key/man_made/value/gazometer`` =
        _prefix "Gazometer/key/man_made/value/gazometer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/General"></see>
    /// </summary>
    let General = _prefix "General"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/General/key/shop/value/general"></see>
    /// </summary>
    let ``General/key/shop/value/general`` = _prefix "General/key/shop/value/general"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Geyser"></see>
    /// </summary>
    let Geyser = _prefix "Geyser"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Geyser/key/natural/value/geyser"></see>
    /// </summary>
    let ``Geyser/key/natural/value/geyser`` = _prefix "Geyser/key/natural/value/geyser"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gift"></see>
    /// </summary>
    let Gift = _prefix "Gift"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gift/key/shop/value/gift"></see>
    /// </summary>
    let ``Gift/key/shop/value/gift`` = _prefix "Gift/key/shop/value/gift"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gifts"></see>
    /// </summary>
    let Gifts = _prefix "Gifts"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gifts/key/shop/value/gifts"></see>
    /// </summary>
    let ``Gifts/key/shop/value/gifts`` = _prefix "Gifts/key/shop/value/gifts"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GiveWaySign"></see>
    /// </summary>
    let GiveWaySign = _prefix "GiveWaySign"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GiveWaySign/key/highway/value/give_way"></see>
    /// </summary>
    let ``GiveWaySign/key/highway/value/give_way`` =
        _prefix "GiveWaySign/key/highway/value/give_way"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glacier"></see>
    /// </summary>
    let Glacier = _prefix "Glacier"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glacier/key/natural/value/glacier"></see>
    /// </summary>
    let ``Glacier/key/natural/value/glacier`` =
        _prefix "Glacier/key/natural/value/glacier"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glass"></see>
    /// </summary>
    let Glass = _prefix "Glass"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glass/key/shop/value/glass"></see>
    /// </summary>
    let ``Glass/key/shop/value/glass`` = _prefix "Glass/key/shop/value/glass"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glaziery"></see>
    /// </summary>
    let Glaziery = _prefix "Glaziery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glaziery/key/shop/value/glaziery"></see>
    /// </summary>
    let ``Glaziery/key/shop/value/glaziery`` =
        _prefix "Glaziery/key/shop/value/glaziery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Glaziery/key/craft/value/glaziery"></see>
    /// </summary>
    let ``Glaziery/key/craft/value/glaziery`` =
        _prefix "Glaziery/key/craft/value/glaziery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Goldsmith"></see>
    /// </summary>
    let Goldsmith = _prefix "Goldsmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Goldsmith/key/shop/value/goldsmith"></see>
    /// </summary>
    let ``Goldsmith/key/shop/value/goldsmith`` =
        _prefix "Goldsmith/key/shop/value/goldsmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GolfCourse"></see>
    /// </summary>
    let GolfCourse = _prefix "GolfCourse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GolfCourse/key/leisure/value/golf_course"></see>
    /// </summary>
    let ``GolfCourse/key/leisure/value/golf_course`` =
        _prefix "GolfCourse/key/leisure/value/golf_course"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gondola"></see>
    /// </summary>
    let Gondola = _prefix "Gondola"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gondola/key/aerialway/value/gondola"></see>
    /// </summary>
    let ``Gondola/key/aerialway/value/gondola`` =
        _prefix "Gondola/key/aerialway/value/gondola"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GovermentBuilding"></see>
    /// </summary>
    let GovermentBuilding = _prefix "GovermentBuilding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GovermentBuilding/key/amenity/value/goverment_building"></see>
    /// </summary>
    let ``GovermentBuilding/key/amenity/value/goverment_building`` =
        _prefix "GovermentBuilding/key/amenity/value/goverment_building"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GovernmentOffice"></see>
    /// </summary>
    let GovernmentOffice = _prefix "GovernmentOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GovernmentOffice/key/office/value/government"></see>
    /// </summary>
    let ``GovernmentOffice/key/office/value/government`` =
        _prefix "GovernmentOffice/key/office/value/government"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Granattrichter"></see>
    /// </summary>
    let Granattrichter = _prefix "Granattrichter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Granattrichter/key/historic/value/Granattrichter"></see>
    /// </summary>
    let ``Granattrichter/key/historic/value/Granattrichter`` =
        _prefix "Granattrichter/key/historic/value/Granattrichter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GrassLanduse"></see>
    /// </summary>
    let GrassLanduse = _prefix "GrassLanduse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GrassLanduse/key/landuse/value/grass"></see>
    /// </summary>
    let ``GrassLanduse/key/landuse/value/grass`` =
        _prefix "GrassLanduse/key/landuse/value/grass"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grassland"></see>
    /// </summary>
    let Grassland = _prefix "Grassland"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grassland/key/natural/value/grassland"></see>
    /// </summary>
    let ``Grassland/key/natural/value/grassland`` =
        _prefix "Grassland/key/natural/value/grassland"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grave"></see>
    /// </summary>
    let Grave = _prefix "Grave"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grave/key/amenity/value/grave"></see>
    /// </summary>
    let ``Grave/key/amenity/value/grave`` = _prefix "Grave/key/amenity/value/grave"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GraveYard"></see>
    /// </summary>
    let GraveYard = _prefix "GraveYard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GraveYard/key/amenity/value/grave_yard"></see>
    /// </summary>
    let ``GraveYard/key/amenity/value/grave_yard`` =
        _prefix "GraveYard/key/amenity/value/grave_yard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Greenfield"></see>
    /// </summary>
    let Greenfield = _prefix "Greenfield"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Greenfield/key/landuse/value/greenfield"></see>
    /// </summary>
    let ``Greenfield/key/landuse/value/greenfield`` =
        _prefix "Greenfield/key/landuse/value/greenfield"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Greengrocer"></see>
    /// </summary>
    let Greengrocer = _prefix "Greengrocer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Greengrocer/key/shop/value/greengrocer"></see>
    /// </summary>
    let ``Greengrocer/key/shop/value/greengrocer`` =
        _prefix "Greengrocer/key/shop/value/greengrocer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GreenhouseHorticulture"></see>
    /// </summary>
    let GreenhouseHorticulture = _prefix "GreenhouseHorticulture"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GreenhouseHorticulture/key/landuse/value/greenhouse_horticulture"></see>
    /// </summary>
    let ``GreenhouseHorticulture/key/landuse/value/greenhouse_horticulture`` =
        _prefix "GreenhouseHorticulture/key/landuse/value/greenhouse_horticulture"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GritBin"></see>
    /// </summary>
    let GritBin = _prefix "GritBin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GritBin/key/amenity/value/grit_bin"></see>
    /// </summary>
    let ``GritBin/key/amenity/value/grit_bin`` =
        _prefix "GritBin/key/amenity/value/grit_bin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Groceries"></see>
    /// </summary>
    let Groceries = _prefix "Groceries"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Groceries/key/shop/value/groceries"></see>
    /// </summary>
    let ``Groceries/key/shop/value/groceries`` =
        _prefix "Groceries/key/shop/value/groceries"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grocery"></see>
    /// </summary>
    let Grocery = _prefix "Grocery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Grocery/key/shop/value/grocery"></see>
    /// </summary>
    let ``Grocery/key/shop/value/grocery`` = _prefix "Grocery/key/shop/value/grocery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GrouseButt"></see>
    /// </summary>
    let GrouseButt = _prefix "GrouseButt"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GrouseButt/key/man_made/value/grouse_butt"></see>
    /// </summary>
    let ``GrouseButt/key/man_made/value/grouse_butt`` =
        _prefix "GrouseButt/key/man_made/value/grouse_butt"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Groyne"></see>
    /// </summary>
    let Groyne = _prefix "Groyne"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Groyne/key/man_made/value/groyne"></see>
    /// </summary>
    let ``Groyne/key/man_made/value/groyne`` =
        _prefix "Groyne/key/man_made/value/groyne"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GuestHouse"></see>
    /// </summary>
    let GuestHouse = _prefix "GuestHouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GuestHouse/key/tourism/value/guest_house"></see>
    /// </summary>
    let ``GuestHouse/key/tourism/value/guest_house`` =
        _prefix "GuestHouse/key/tourism/value/guest_house"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Guidepost"></see>
    /// </summary>
    let Guidepost = _prefix "Guidepost"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Guidepost/key/amenity/value/guidepost"></see>
    /// </summary>
    let ``Guidepost/key/amenity/value/guidepost`` =
        _prefix "Guidepost/key/amenity/value/guidepost"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gym"></see>
    /// </summary>
    let Gym = _prefix "Gym"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gym/key/amenity/value/gym"></see>
    /// </summary>
    let ``Gym/key/amenity/value/gym`` = _prefix "Gym/key/amenity/value/gym"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Gym/key/leisure/value/gym"></see>
    /// </summary>
    let ``Gym/key/leisure/value/gym`` = _prefix "Gym/key/leisure/value/gym"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GymShop"></see>
    /// </summary>
    let GymShop = _prefix "GymShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/GymShop/key/shop/value/gym"></see>
    /// </summary>
    let ``GymShop/key/shop/value/gym`` = _prefix "GymShop/key/shop/value/gym"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Haberdashery"></see>
    /// </summary>
    let Haberdashery = _prefix "Haberdashery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Haberdashery/key/shop/value/haberdashery"></see>
    /// </summary>
    let ``Haberdashery/key/shop/value/haberdashery`` =
        _prefix "Haberdashery/key/shop/value/haberdashery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hackerspace"></see>
    /// </summary>
    let Hackerspace = _prefix "Hackerspace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hackerspace/key/leisure/value/hackerspace"></see>
    /// </summary>
    let ``Hackerspace/key/leisure/value/hackerspace`` =
        _prefix "Hackerspace/key/leisure/value/hackerspace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hairdresser"></see>
    /// </summary>
    let Hairdresser = _prefix "Hairdresser"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hairdresser/key/amenity/value/hairdresser"></see>
    /// </summary>
    let ``Hairdresser/key/amenity/value/hairdresser`` =
        _prefix "Hairdresser/key/amenity/value/hairdresser"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HairdresserShop"></see>
    /// </summary>
    let HairdresserShop = _prefix "HairdresserShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HairdresserShop/key/shop/value/hairdresser"></see>
    /// </summary>
    let ``HairdresserShop/key/shop/value/hairdresser`` =
        _prefix "HairdresserShop/key/shop/value/hairdresser"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hall"></see>
    /// </summary>
    let Hall = _prefix "Hall"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hall/key/amenity/value/hall"></see>
    /// </summary>
    let ``Hall/key/amenity/value/hall`` = _prefix "Hall/key/amenity/value/hall"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hamlet"></see>
    /// </summary>
    let Hamlet = _prefix "Hamlet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hamlet/key/place/value/hamlet"></see>
    /// </summary>
    let ``Hamlet/key/place/value/hamlet`` = _prefix "Hamlet/key/place/value/hamlet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hanami"></see>
    /// </summary>
    let Hanami = _prefix "Hanami"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hanami/key/tourism/value/hanami"></see>
    /// </summary>
    let ``Hanami/key/tourism/value/hanami`` = _prefix "Hanami/key/tourism/value/hanami"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Handicraft"></see>
    /// </summary>
    let Handicraft = _prefix "Handicraft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Handicraft/key/craft/value/handicraft"></see>
    /// </summary>
    let ``Handicraft/key/craft/value/handicraft`` =
        _prefix "Handicraft/key/craft/value/handicraft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Harbour"></see>
    /// </summary>
    let Harbour = _prefix "Harbour"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Harbour/key/waterway/value/harbour"></see>
    /// </summary>
    let ``Harbour/key/waterway/value/harbour`` =
        _prefix "Harbour/key/waterway/value/harbour"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hardware"></see>
    /// </summary>
    let Hardware = _prefix "Hardware"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hardware/key/shop/value/hardware"></see>
    /// </summary>
    let ``Hardware/key/shop/value/hardware`` =
        _prefix "Hardware/key/shop/value/hardware"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Headland"></see>
    /// </summary>
    let Headland = _prefix "Headland"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Headland/key/natural/value/headland"></see>
    /// </summary>
    let ``Headland/key/natural/value/headland`` =
        _prefix "Headland/key/natural/value/headland"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Health"></see>
    /// </summary>
    let Health = _prefix "Health"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Health/key/shop/value/health"></see>
    /// </summary>
    let ``Health/key/shop/value/health`` = _prefix "Health/key/shop/value/health"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthAndBeauty"></see>
    /// </summary>
    let HealthAndBeauty = _prefix "HealthAndBeauty"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthAndBeauty/key/shop/value/health_and_beauty"></see>
    /// </summary>
    let ``HealthAndBeauty/key/shop/value/health_and_beauty`` =
        _prefix "HealthAndBeauty/key/shop/value/health_and_beauty"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthCentre"></see>
    /// </summary>
    let HealthCentre = _prefix "HealthCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthCentre/key/amenity/value/health_centre"></see>
    /// </summary>
    let ``HealthCentre/key/amenity/value/health_centre`` =
        _prefix "HealthCentre/key/amenity/value/health_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthFood"></see>
    /// </summary>
    let HealthFood = _prefix "HealthFood"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HealthFood/key/shop/value/health_food"></see>
    /// </summary>
    let ``HealthFood/key/shop/value/health_food`` =
        _prefix "HealthFood/key/shop/value/health_food"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HearingAid"></see>
    /// </summary>
    let HearingAid = _prefix "HearingAid"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HearingAid/key/shop/value/hearing_aid"></see>
    /// </summary>
    let ``HearingAid/key/shop/value/hearing_aid`` =
        _prefix "HearingAid/key/shop/value/hearing_aid"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HearingAids"></see>
    /// </summary>
    let HearingAids = _prefix "HearingAids"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HearingAids/key/shop/value/hearing_aids"></see>
    /// </summary>
    let ``HearingAids/key/shop/value/hearing_aids`` =
        _prefix "HearingAids/key/shop/value/hearing_aids"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heath"></see>
    /// </summary>
    let Heath = _prefix "Heath"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heath/key/natural/value/heath"></see>
    /// </summary>
    let ``Heath/key/natural/value/heath`` = _prefix "Heath/key/natural/value/heath"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hedge"></see>
    /// </summary>
    let Hedge = _prefix "Hedge"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hedge/key/barrier/value/hedge"></see>
    /// </summary>
    let ``Hedge/key/barrier/value/hedge`` = _prefix "Hedge/key/barrier/value/hedge"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Helipad"></see>
    /// </summary>
    let Helipad = _prefix "Helipad"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Helipad/key/aeroway/value/helipad"></see>
    /// </summary>
    let ``Helipad/key/aeroway/value/helipad`` =
        _prefix "Helipad/key/aeroway/value/helipad"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heliport"></see>
    /// </summary>
    let Heliport = _prefix "Heliport"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heliport/key/aeroway/value/heliport"></see>
    /// </summary>
    let ``Heliport/key/aeroway/value/heliport`` =
        _prefix "Heliport/key/aeroway/value/heliport"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heritage"></see>
    /// </summary>
    let Heritage = _prefix "Heritage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heritage/key/historic/value/heritage"></see>
    /// </summary>
    let ``Heritage/key/historic/value/heritage`` =
        _prefix "Heritage/key/historic/value/heritage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heuriger"></see>
    /// </summary>
    let Heuriger = _prefix "Heuriger"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Heuriger/key/amenity/value/heuriger"></see>
    /// </summary>
    let ``Heuriger/key/amenity/value/heuriger`` =
        _prefix "Heuriger/key/amenity/value/heuriger"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hide"></see>
    /// </summary>
    let Hide = _prefix "Hide"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hide/key/amenity/value/hide"></see>
    /// </summary>
    let ``Hide/key/amenity/value/hide`` = _prefix "Hide/key/amenity/value/hide"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hifi"></see>
    /// </summary>
    let Hifi = _prefix "Hifi"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hifi/key/shop/value/hifi"></see>
    /// </summary>
    let ``Hifi/key/shop/value/hifi`` = _prefix "Hifi/key/shop/value/hifi"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayConstruction"></see>
    /// </summary>
    let HighwayConstruction = _prefix "HighwayConstruction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayConstruction/key/highway/value/construction"></see>
    /// </summary>
    let ``HighwayConstruction/key/highway/value/construction`` =
        _prefix "HighwayConstruction/key/highway/value/construction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayCrossing"></see>
    /// </summary>
    let HighwayCrossing = _prefix "HighwayCrossing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayCrossing/key/highway/value/crossing"></see>
    /// </summary>
    let ``HighwayCrossing/key/highway/value/crossing`` =
        _prefix "HighwayCrossing/key/highway/value/crossing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayFord"></see>
    /// </summary>
    let HighwayFord = _prefix "HighwayFord"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayFord/key/highway/value/ford"></see>
    /// </summary>
    let ``HighwayFord/key/highway/value/ford`` =
        _prefix "HighwayFord/key/highway/value/ford"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayPrimaryLink"></see>
    /// </summary>
    let HighwayPrimaryLink = _prefix "HighwayPrimaryLink"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayPrimaryLink/key/highway/value/primary_link"></see>
    /// </summary>
    let ``HighwayPrimaryLink/key/highway/value/primary_link`` =
        _prefix "HighwayPrimaryLink/key/highway/value/primary_link"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwaySecundaryLink"></see>
    /// </summary>
    let HighwaySecundaryLink = _prefix "HighwaySecundaryLink"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwaySecundaryLink/key/highway/value/secundary_link"></see>
    /// </summary>
    let ``HighwaySecundaryLink/key/highway/value/secundary_link`` =
        _prefix "HighwaySecundaryLink/key/highway/value/secundary_link"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayService"></see>
    /// </summary>
    let HighwayService = _prefix "HighwayService"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayService/key/highway/value/service"></see>
    /// </summary>
    let ``HighwayService/key/highway/value/service`` =
        _prefix "HighwayService/key/highway/value/service"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayTertiaryLink"></see>
    /// </summary>
    let HighwayTertiaryLink = _prefix "HighwayTertiaryLink"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HighwayTertiaryLink/key/highway/value/tertiary_link"></see>
    /// </summary>
    let ``HighwayTertiaryLink/key/highway/value/tertiary_link`` =
        _prefix "HighwayTertiaryLink/key/highway/value/tertiary_link"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HikingRoute"></see>
    /// </summary>
    let HikingRoute = _prefix "HikingRoute"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HikingRoute/key/route/value/hiking"></see>
    /// </summary>
    let ``HikingRoute/key/route/value/hiking`` =
        _prefix "HikingRoute/key/route/value/hiking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hill"></see>
    /// </summary>
    let Hill = _prefix "Hill"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hill/key/natural/value/hill"></see>
    /// </summary>
    let ``Hill/key/natural/value/hill`` = _prefix "Hill/key/natural/value/hill"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricBuilding"></see>
    /// </summary>
    let HistoricBuilding = _prefix "HistoricBuilding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricBuilding/key/historic/value/building"></see>
    /// </summary>
    let ``HistoricBuilding/key/historic/value/building`` =
        _prefix "HistoricBuilding/key/historic/value/building"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricChapel"></see>
    /// </summary>
    let HistoricChapel = _prefix "HistoricChapel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricChapel/key/historic/value/chapel"></see>
    /// </summary>
    let ``HistoricChapel/key/historic/value/chapel`` =
        _prefix "HistoricChapel/key/historic/value/chapel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricChurch"></see>
    /// </summary>
    let HistoricChurch = _prefix "HistoricChurch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricChurch/key/historic/value/church"></see>
    /// </summary>
    let ``HistoricChurch/key/historic/value/church`` =
        _prefix "HistoricChurch/key/historic/value/church"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricFountain"></see>
    /// </summary>
    let HistoricFountain = _prefix "HistoricFountain"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricFountain/key/historic/value/fountain"></see>
    /// </summary>
    let ``HistoricFountain/key/historic/value/fountain`` =
        _prefix "HistoricFountain/key/historic/value/fountain"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricHouse"></see>
    /// </summary>
    let HistoricHouse = _prefix "HistoricHouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricHouse/key/historic/value/house"></see>
    /// </summary>
    let ``HistoricHouse/key/historic/value/house`` =
        _prefix "HistoricHouse/key/historic/value/house"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricIndustrial"></see>
    /// </summary>
    let HistoricIndustrial = _prefix "HistoricIndustrial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricIndustrial/key/historic/value/industrial"></see>
    /// </summary>
    let ``HistoricIndustrial/key/historic/value/industrial`` =
        _prefix "HistoricIndustrial/key/historic/value/industrial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMarker"></see>
    /// </summary>
    let HistoricMarker = _prefix "HistoricMarker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMarker/key/historic/value/marker"></see>
    /// </summary>
    let ``HistoricMarker/key/historic/value/marker`` =
        _prefix "HistoricMarker/key/historic/value/marker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMilestone"></see>
    /// </summary>
    let HistoricMilestone = _prefix "HistoricMilestone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMilestone/key/historic/value/milestone"></see>
    /// </summary>
    let ``HistoricMilestone/key/historic/value/milestone`` =
        _prefix "HistoricMilestone/key/historic/value/milestone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMine"></see>
    /// </summary>
    let HistoricMine = _prefix "HistoricMine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMine/key/historic/value/mine"></see>
    /// </summary>
    let ``HistoricMine/key/historic/value/mine`` =
        _prefix "HistoricMine/key/historic/value/mine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMonastery"></see>
    /// </summary>
    let HistoricMonastery = _prefix "HistoricMonastery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMonastery/key/historic/value/monastery"></see>
    /// </summary>
    let ``HistoricMonastery/key/historic/value/monastery`` =
        _prefix "HistoricMonastery/key/historic/value/monastery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMuseum"></see>
    /// </summary>
    let HistoricMuseum = _prefix "HistoricMuseum"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricMuseum/key/historic/value/museum"></see>
    /// </summary>
    let ``HistoricMuseum/key/historic/value/museum`` =
        _prefix "HistoricMuseum/key/historic/value/museum"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricPointOfInterest"></see>
    /// </summary>
    let HistoricPointOfInterest = _prefix "HistoricPointOfInterest"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricPointOfInterest/key/historic/value/yes"></see>
    /// </summary>
    let ``HistoricPointOfInterest/key/historic/value/yes`` =
        _prefix "HistoricPointOfInterest/key/historic/value/yes"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricStation"></see>
    /// </summary>
    let HistoricStation = _prefix "HistoricStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricStation/key/railway/value/historic_station"></see>
    /// </summary>
    let ``HistoricStation/key/railway/value/historic_station`` =
        _prefix "HistoricStation/key/railway/value/historic_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricStatue"></see>
    /// </summary>
    let HistoricStatue = _prefix "HistoricStatue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricStatue/key/historic/value/statue"></see>
    /// </summary>
    let ``HistoricStatue/key/historic/value/statue`` =
        _prefix "HistoricStatue/key/historic/value/statue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricTower"></see>
    /// </summary>
    let HistoricTower = _prefix "HistoricTower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricTower/key/historic/value/tower"></see>
    /// </summary>
    let ``HistoricTower/key/historic/value/tower`` =
        _prefix "HistoricTower/key/historic/value/tower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricWell"></see>
    /// </summary>
    let HistoricWell = _prefix "HistoricWell"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HistoricWell/key/historic/value/well"></see>
    /// </summary>
    let ``HistoricWell/key/historic/value/well`` =
        _prefix "HistoricWell/key/historic/value/well"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hobby"></see>
    /// </summary>
    let Hobby = _prefix "Hobby"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hobby/key/shop/value/hobby"></see>
    /// </summary>
    let ``Hobby/key/shop/value/hobby`` = _prefix "Hobby/key/shop/value/hobby"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HoldingPoint"></see>
    /// </summary>
    let HoldingPoint = _prefix "HoldingPoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HoldingPoint/key/aeroway/value/holding_point"></see>
    /// </summary>
    let ``HoldingPoint/key/aeroway/value/holding_point`` =
        _prefix "HoldingPoint/key/aeroway/value/holding_point"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hole"></see>
    /// </summary>
    let Hole = _prefix "Hole"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hole/key/leisure/value/hole"></see>
    /// </summary>
    let ``Hole/key/leisure/value/hole`` = _prefix "Hole/key/leisure/value/hole"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Home"></see>
    /// </summary>
    let Home = _prefix "Home"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Home/key/shop/value/home"></see>
    /// </summary>
    let ``Home/key/shop/value/home`` = _prefix "Home/key/shop/value/home"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HomeImprovement"></see>
    /// </summary>
    let HomeImprovement = _prefix "HomeImprovement"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HomeImprovement/key/shop/value/home_improvement"></see>
    /// </summary>
    let ``HomeImprovement/key/shop/value/home_improvement`` =
        _prefix "HomeImprovement/key/shop/value/home_improvement"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HorseRiding"></see>
    /// </summary>
    let HorseRiding = _prefix "HorseRiding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HorseRiding/key/leisure/value/horse_riding"></see>
    /// </summary>
    let ``HorseRiding/key/leisure/value/horse_riding`` =
        _prefix "HorseRiding/key/leisure/value/horse_riding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HorseStile"></see>
    /// </summary>
    let HorseStile = _prefix "HorseStile"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HorseStile/key/barrier/value/horse_stile"></see>
    /// </summary>
    let ``HorseStile/key/barrier/value/horse_stile`` =
        _prefix "HorseStile/key/barrier/value/horse_stile"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hospice"></see>
    /// </summary>
    let Hospice = _prefix "Hospice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hospice/key/amenity/value/hospice"></see>
    /// </summary>
    let ``Hospice/key/amenity/value/hospice`` =
        _prefix "Hospice/key/amenity/value/hospice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hospital"></see>
    /// </summary>
    let Hospital = _prefix "Hospital"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hospital/key/amenity/value/hospital"></see>
    /// </summary>
    let ``Hospital/key/amenity/value/hospital`` =
        _prefix "Hospital/key/amenity/value/hospital"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hostel"></see>
    /// </summary>
    let Hostel = _prefix "Hostel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hostel/key/tourism/value/hostel"></see>
    /// </summary>
    let ``Hostel/key/tourism/value/hostel`` = _prefix "Hostel/key/tourism/value/hostel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HotSpring"></see>
    /// </summary>
    let HotSpring = _prefix "HotSpring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HotSpring/key/leisure/value/hot_spring"></see>
    /// </summary>
    let ``HotSpring/key/leisure/value/hot_spring`` =
        _prefix "HotSpring/key/leisure/value/hot_spring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hotel"></see>
    /// </summary>
    let Hotel = _prefix "Hotel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hotel/key/amenity/value/hotel"></see>
    /// </summary>
    let ``Hotel/key/amenity/value/hotel`` = _prefix "Hotel/key/amenity/value/hotel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hotel/key/tourism/value/hotel"></see>
    /// </summary>
    let ``Hotel/key/tourism/value/hotel`` = _prefix "Hotel/key/tourism/value/hotel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HouseConnectionBox"></see>
    /// </summary>
    let HouseConnectionBox = _prefix "HouseConnectionBox"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HouseConnectionBox/key/power/value/house_connection_box"></see>
    /// </summary>
    let ``HouseConnectionBox/key/power/value/house_connection_box`` =
        _prefix "HouseConnectionBox/key/power/value/house_connection_box"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Household"></see>
    /// </summary>
    let Household = _prefix "Household"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Household/key/shop/value/household"></see>
    /// </summary>
    let ``Household/key/shop/value/household`` =
        _prefix "Household/key/shop/value/household"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Housewares"></see>
    /// </summary>
    let Housewares = _prefix "Housewares"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Housewares/key/shop/value/housewares"></see>
    /// </summary>
    let ``Housewares/key/shop/value/housewares`` =
        _prefix "Housewares/key/shop/value/housewares"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hump"></see>
    /// </summary>
    let Hump = _prefix "Hump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hump/key/traffic_calming/value/hump"></see>
    /// </summary>
    let ``Hump/key/traffic_calming/value/hump`` =
        _prefix "Hump/key/traffic_calming/value/hump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HuntingBlind"></see>
    /// </summary>
    let HuntingBlind = _prefix "HuntingBlind"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HuntingBlind/key/amenity/value/hunting_blind"></see>
    /// </summary>
    let ``HuntingBlind/key/amenity/value/hunting_blind`` =
        _prefix "HuntingBlind/key/amenity/value/hunting_blind"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HuntingStand"></see>
    /// </summary>
    let HuntingStand = _prefix "HuntingStand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/HuntingStand/key/amenity/value/hunting_stand"></see>
    /// </summary>
    let ``HuntingStand/key/amenity/value/hunting_stand`` =
        _prefix "HuntingStand/key/amenity/value/hunting_stand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hut"></see>
    /// </summary>
    let Hut = _prefix "Hut"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hut/key/amenity/value/hut"></see>
    /// </summary>
    let ``Hut/key/amenity/value/hut`` = _prefix "Hut/key/amenity/value/hut"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hvac"></see>
    /// </summary>
    let Hvac = _prefix "Hvac"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hvac/key/craft/value/hvac"></see>
    /// </summary>
    let ``Hvac/key/craft/value/hvac`` = _prefix "Hvac/key/craft/value/hvac"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hydrant"></see>
    /// </summary>
    let Hydrant = _prefix "Hydrant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Hydrant/key/amenity/value/hydrant"></see>
    /// </summary>
    let ``Hydrant/key/amenity/value/hydrant`` =
        _prefix "Hydrant/key/amenity/value/hydrant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceCream"></see>
    /// </summary>
    let IceCream = _prefix "IceCream"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceCream/key/amenity/value/ice_cream"></see>
    /// </summary>
    let ``IceCream/key/amenity/value/ice_cream`` =
        _prefix "IceCream/key/amenity/value/ice_cream"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceCreamShop"></see>
    /// </summary>
    let IceCreamShop = _prefix "IceCreamShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceCreamShop/key/shop/value/ice_cream"></see>
    /// </summary>
    let ``IceCreamShop/key/shop/value/ice_cream`` =
        _prefix "IceCreamShop/key/shop/value/ice_cream"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceRink"></see>
    /// </summary>
    let IceRink = _prefix "IceRink"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceRink/key/leisure/value/ice_rink"></see>
    /// </summary>
    let ``IceRink/key/leisure/value/ice_rink`` =
        _prefix "IceRink/key/leisure/value/ice_rink"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceRoad"></see>
    /// </summary>
    let IceRoad = _prefix "IceRoad"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IceRoad/key/ice_road/value/yes"></see>
    /// </summary>
    let ``IceRoad/key/ice_road/value/yes`` = _prefix "IceRoad/key/ice_road/value/yes"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Icon"></see>
    /// </summary>
    let Icon = _prefix "Icon"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Icon/key/historic/value/icon"></see>
    /// </summary>
    let ``Icon/key/historic/value/icon`` = _prefix "Icon/key/historic/value/icon"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IndustrialLanduse"></see>
    /// </summary>
    let IndustrialLanduse = _prefix "IndustrialLanduse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IndustrialLanduse/key/landuse/value/industrial"></see>
    /// </summary>
    let ``IndustrialLanduse/key/landuse/value/industrial`` =
        _prefix "IndustrialLanduse/key/landuse/value/industrial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IndustrialProductionBuilding"></see>
    /// </summary>
    let IndustrialProductionBuilding = _prefix "IndustrialProductionBuilding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IndustrialProductionBuilding/key/man_made/value/works"></see>
    /// </summary>
    let ``IndustrialProductionBuilding/key/man_made/value/works`` =
        _prefix "IndustrialProductionBuilding/key/man_made/value/works"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Information"></see>
    /// </summary>
    let Information = _prefix "Information"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Information/key/amenity/value/information"></see>
    /// </summary>
    let ``Information/key/amenity/value/information`` =
        _prefix "Information/key/amenity/value/information"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insulation"></see>
    /// </summary>
    let Insulation = _prefix "Insulation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insulation/key/craft/value/insulation"></see>
    /// </summary>
    let ``Insulation/key/craft/value/insulation`` =
        _prefix "Insulation/key/craft/value/insulation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insurance"></see>
    /// </summary>
    let Insurance = _prefix "Insurance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insurance/key/amenity/value/insurance"></see>
    /// </summary>
    let ``Insurance/key/amenity/value/insurance`` =
        _prefix "Insurance/key/amenity/value/insurance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Insurance/key/shop/value/insurance"></see>
    /// </summary>
    let ``Insurance/key/shop/value/insurance`` =
        _prefix "Insurance/key/shop/value/insurance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InsuranceOffice"></see>
    /// </summary>
    let InsuranceOffice = _prefix "InsuranceOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InsuranceOffice/key/office/value/insurance"></see>
    /// </summary>
    let ``InsuranceOffice/key/office/value/insurance`` =
        _prefix "InsuranceOffice/key/office/value/insurance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Interiors"></see>
    /// </summary>
    let Interiors = _prefix "Interiors"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Interiors/key/shop/value/interiors"></see>
    /// </summary>
    let ``Interiors/key/shop/value/interiors`` =
        _prefix "Interiors/key/shop/value/interiors"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Intermittent"></see>
    /// </summary>
    let Intermittent = _prefix "Intermittent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Intermittent/key/intermittent/value/yes"></see>
    /// </summary>
    let ``Intermittent/key/intermittent/value/yes`` =
        _prefix "Intermittent/key/intermittent/value/yes"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Internet"></see>
    /// </summary>
    let Internet = _prefix "Internet"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Internet/key/amenity/value/internet"></see>
    /// </summary>
    let ``Internet/key/amenity/value/internet`` =
        _prefix "Internet/key/amenity/value/internet"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetAccess"></see>
    /// </summary>
    let InternetAccess = _prefix "InternetAccess"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetAccess/key/amenity/value/internet_access"></see>
    /// </summary>
    let ``InternetAccess/key/amenity/value/internet_access`` =
        _prefix "InternetAccess/key/amenity/value/internet_access"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetCafe"></see>
    /// </summary>
    let InternetCafe = _prefix "InternetCafe"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetCafe/key/amenity/value/internet_cafe"></see>
    /// </summary>
    let ``InternetCafe/key/amenity/value/internet_cafe`` =
        _prefix "InternetCafe/key/amenity/value/internet_cafe"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/InternetCafe/key/shop/value/internet_cafe"></see>
    /// </summary>
    let ``InternetCafe/key/shop/value/internet_cafe`` =
        _prefix "InternetCafe/key/shop/value/internet_cafe"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Island"></see>
    /// </summary>
    let Island = _prefix "Island"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Island/key/place/value/island"></see>
    /// </summary>
    let ``Island/key/place/value/island`` = _prefix "Island/key/place/value/island"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Island/key/natural/value/island"></see>
    /// </summary>
    let ``Island/key/natural/value/island`` = _prefix "Island/key/natural/value/island"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Islet"></see>
    /// </summary>
    let Islet = _prefix "Islet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Islet/key/place/value/islet"></see>
    /// </summary>
    let ``Islet/key/place/value/islet`` = _prefix "Islet/key/place/value/islet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IsolatedDwelling"></see>
    /// </summary>
    let IsolatedDwelling = _prefix "IsolatedDwelling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/IsolatedDwelling/key/place/value/isolated_dwelling"></see>
    /// </summary>
    let ``IsolatedDwelling/key/place/value/isolated_dwelling`` =
        _prefix "IsolatedDwelling/key/place/value/isolated_dwelling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ItOffice"></see>
    /// </summary>
    let ItOffice = _prefix "ItOffice"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ItOffice/key/office/value/it"></see>
    /// </summary>
    let ``ItOffice/key/office/value/it`` = _prefix "ItOffice/key/office/value/it"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jewelers"></see>
    /// </summary>
    let Jewelers = _prefix "Jewelers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jewelers/key/shop/value/jewelers"></see>
    /// </summary>
    let ``Jewelers/key/shop/value/jewelers`` =
        _prefix "Jewelers/key/shop/value/jewelers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jeweller"></see>
    /// </summary>
    let Jeweller = _prefix "Jeweller"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jeweller/key/craft/value/jeweller"></see>
    /// </summary>
    let ``Jeweller/key/craft/value/jeweller`` =
        _prefix "Jeweller/key/craft/value/jeweller"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jewelry"></see>
    /// </summary>
    let Jewelry = _prefix "Jewelry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Jewelry/key/shop/value/jewelry"></see>
    /// </summary>
    let ``Jewelry/key/shop/value/jewelry`` = _prefix "Jewelry/key/shop/value/jewelry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/JobCentre"></see>
    /// </summary>
    let JobCentre = _prefix "JobCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/JobCentre/key/amenity/value/job_centre"></see>
    /// </summary>
    let ``JobCentre/key/amenity/value/job_centre`` =
        _prefix "JobCentre/key/amenity/value/job_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KentCarriageGap"></see>
    /// </summary>
    let KentCarriageGap = _prefix "KentCarriageGap"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KentCarriageGap/key/barrier/value/kent_carriage_gap"></see>
    /// </summary>
    let ``KentCarriageGap/key/barrier/value/kent_carriage_gap`` =
        _prefix "KentCarriageGap/key/barrier/value/kent_carriage_gap"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KeyCutter"></see>
    /// </summary>
    let KeyCutter = _prefix "KeyCutter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KeyCutter/key/craft/value/key_cutter"></see>
    /// </summary>
    let ``KeyCutter/key/craft/value/key_cutter`` =
        _prefix "KeyCutter/key/craft/value/key_cutter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Keys"></see>
    /// </summary>
    let Keys = _prefix "Keys"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Keys/key/shop/value/keys"></see>
    /// </summary>
    let ``Keys/key/shop/value/keys`` = _prefix "Keys/key/shop/value/keys"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kindergarten"></see>
    /// </summary>
    let Kindergarten = _prefix "Kindergarten"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kindergarten/key/amenity/value/kindergarten"></see>
    /// </summary>
    let ``Kindergarten/key/amenity/value/kindergarten`` =
        _prefix "Kindergarten/key/amenity/value/kindergarten"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kiosk"></see>
    /// </summary>
    let Kiosk = _prefix "Kiosk"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kiosk/key/shop/value/kiosk"></see>
    /// </summary>
    let ``Kiosk/key/shop/value/kiosk`` = _prefix "Kiosk/key/shop/value/kiosk"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Kiosk/key/shop/value/Kiosk"></see>
    /// </summary>
    let ``Kiosk/key/shop/value/Kiosk`` = _prefix "Kiosk/key/shop/value/Kiosk"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KissingGate"></see>
    /// </summary>
    let KissingGate = _prefix "KissingGate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KissingGate/key/barrier/value/kissing_gate"></see>
    /// </summary>
    let ``KissingGate/key/barrier/value/kissing_gate`` =
        _prefix "KissingGate/key/barrier/value/kissing_gate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KitchenShop"></see>
    /// </summary>
    let KitchenShop = _prefix "KitchenShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KitchenShop/key/shop/value/kitchen"></see>
    /// </summary>
    let ``KitchenShop/key/shop/value/kitchen`` =
        _prefix "KitchenShop/key/shop/value/kitchen"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KneippWaterCure"></see>
    /// </summary>
    let KneippWaterCure = _prefix "KneippWaterCure"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/KneippWaterCure/key/amenity/value/kneipp_water_cure"></see>
    /// </summary>
    let ``KneippWaterCure/key/amenity/value/kneipp_water_cure`` =
        _prefix "KneippWaterCure/key/amenity/value/kneipp_water_cure"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lamp"></see>
    /// </summary>
    let Lamp = _prefix "Lamp"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lamp/key/amenity/value/lamp"></see>
    /// </summary>
    let ``Lamp/key/amenity/value/lamp`` = _prefix "Lamp/key/amenity/value/lamp"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LampPost"></see>
    /// </summary>
    let LampPost = _prefix "LampPost"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LampPost/key/amenity/value/lamp_post"></see>
    /// </summary>
    let ``LampPost/key/amenity/value/lamp_post`` =
        _prefix "LampPost/key/amenity/value/lamp_post"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Land"></see>
    /// </summary>
    let Land = _prefix "Land"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Land/key/natural/value/land"></see>
    /// </summary>
    let ``Land/key/natural/value/land`` = _prefix "Land/key/natural/value/land"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landfill"></see>
    /// </summary>
    let Landfill = _prefix "Landfill"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landfill/key/landuse/value/landfill"></see>
    /// </summary>
    let ``Landfill/key/landuse/value/landfill`` =
        _prefix "Landfill/key/landuse/value/landfill"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LandingLight"></see>
    /// </summary>
    let LandingLight = _prefix "LandingLight"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LandingLight/key/aeroway/value/landing_light"></see>
    /// </summary>
    let ``LandingLight/key/aeroway/value/landing_light`` =
        _prefix "LandingLight/key/aeroway/value/landing_light"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landmark"></see>
    /// </summary>
    let Landmark = _prefix "Landmark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Landmark/key/man_made/value/landmark"></see>
    /// </summary>
    let ``Landmark/key/man_made/value/landmark`` =
        _prefix "Landmark/key/man_made/value/landmark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseMine"></see>
    /// </summary>
    let LanduseMine = _prefix "LanduseMine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseMine/key/landuse/value/mine"></see>
    /// </summary>
    let ``LanduseMine/key/landuse/value/mine`` =
        _prefix "LanduseMine/key/landuse/value/mine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LandusePark"></see>
    /// </summary>
    let LandusePark = _prefix "LandusePark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LandusePark/key/landuse/value/park"></see>
    /// </summary>
    let ``LandusePark/key/landuse/value/park`` =
        _prefix "LandusePark/key/landuse/value/park"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseParking"></see>
    /// </summary>
    let LanduseParking = _prefix "LanduseParking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseParking/key/landuse/value/parking"></see>
    /// </summary>
    let ``LanduseParking/key/landuse/value/parking`` =
        _prefix "LanduseParking/key/landuse/value/parking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseWood"></see>
    /// </summary>
    let LanduseWood = _prefix "LanduseWood"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanduseWood/key/landuse/value/wood"></see>
    /// </summary>
    let ``LanduseWood/key/landuse/value/wood`` =
        _prefix "LanduseWood/key/landuse/value/wood"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanguageSchool"></see>
    /// </summary>
    let LanguageSchool = _prefix "LanguageSchool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LanguageSchool/key/amenity/value/language_school"></see>
    /// </summary>
    let ``LanguageSchool/key/amenity/value/language_school`` =
        _prefix "LanguageSchool/key/amenity/value/language_school"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LaunchPad"></see>
    /// </summary>
    let LaunchPad = _prefix "LaunchPad"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LaunchPad/key/man_made/value/launch_pad"></see>
    /// </summary>
    let ``LaunchPad/key/man_made/value/launch_pad`` =
        _prefix "LaunchPad/key/man_made/value/launch_pad"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Laundry"></see>
    /// </summary>
    let Laundry = _prefix "Laundry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Laundry/key/shop/value/laundry"></see>
    /// </summary>
    let ``Laundry/key/shop/value/laundry`` = _prefix "Laundry/key/shop/value/laundry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lavoir"></see>
    /// </summary>
    let Lavoir = _prefix "Lavoir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lavoir/key/historic/value/lavoir"></see>
    /// </summary>
    let ``Lavoir/key/historic/value/lavoir`` =
        _prefix "Lavoir/key/historic/value/lavoir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lawyer"></see>
    /// </summary>
    let Lawyer = _prefix "Lawyer"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lawyer/key/amenity/value/lawyer"></see>
    /// </summary>
    let ``Lawyer/key/amenity/value/lawyer`` = _prefix "Lawyer/key/amenity/value/lawyer"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LawyerOffice"></see>
    /// </summary>
    let LawyerOffice = _prefix "LawyerOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LawyerOffice/key/office/value/lawyer"></see>
    /// </summary>
    let ``LawyerOffice/key/office/value/lawyer`` =
        _prefix "LawyerOffice/key/office/value/lawyer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Layby"></see>
    /// </summary>
    let Layby = _prefix "Layby"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Layby/key/amenity/value/layby"></see>
    /// </summary>
    let ``Layby/key/amenity/value/layby`` = _prefix "Layby/key/amenity/value/layby"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Leather"></see>
    /// </summary>
    let Leather = _prefix "Leather"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Leather/key/shop/value/leather"></see>
    /// </summary>
    let ``Leather/key/shop/value/leather`` = _prefix "Leather/key/shop/value/leather"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LegalServices"></see>
    /// </summary>
    let LegalServices = _prefix "LegalServices"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LegalServices/key/shop/value/legal_services"></see>
    /// </summary>
    let ``LegalServices/key/shop/value/legal_services`` =
        _prefix "LegalServices/key/shop/value/legal_services"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lettering"></see>
    /// </summary>
    let Lettering = _prefix "Lettering"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lettering/key/man_made/value/lettering"></see>
    /// </summary>
    let ``Lettering/key/man_made/value/lettering`` =
        _prefix "Lettering/key/man_made/value/lettering"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LevelCrossing"></see>
    /// </summary>
    let LevelCrossing = _prefix "LevelCrossing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LevelCrossing/key/railway/value/level_crossing"></see>
    /// </summary>
    let ``LevelCrossing/key/railway/value/level_crossing`` =
        _prefix "LevelCrossing/key/railway/value/level_crossing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Library"></see>
    /// </summary>
    let Library = _prefix "Library"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Library/key/amenity/value/library"></see>
    /// </summary>
    let ``Library/key/amenity/value/library`` =
        _prefix "Library/key/amenity/value/library"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LicensedClub"></see>
    /// </summary>
    let LicensedClub = _prefix "LicensedClub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LicensedClub/key/amenity/value/licensed_club"></see>
    /// </summary>
    let ``LicensedClub/key/amenity/value/licensed_club`` =
        _prefix "LicensedClub/key/amenity/value/licensed_club"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Life-buoy"></see>
    /// </summary>
    let ``Life-buoy`` = _prefix "Life-buoy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Life-buoy/key/amenity/value/life-buoy"></see>
    /// </summary>
    let ``Life-buoy/key/amenity/value/life-buoy`` =
        _prefix "Life-buoy/key/amenity/value/life-buoy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LifeRing"></see>
    /// </summary>
    let LifeRing = _prefix "LifeRing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LifeRing/key/amenity/value/life_ring"></see>
    /// </summary>
    let ``LifeRing/key/amenity/value/life_ring`` =
        _prefix "LifeRing/key/amenity/value/life_ring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LifeboatStation"></see>
    /// </summary>
    let LifeboatStation = _prefix "LifeboatStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LifeboatStation/key/amenity/value/lifeboat_station"></see>
    /// </summary>
    let ``LifeboatStation/key/amenity/value/lifeboat_station`` =
        _prefix "LifeboatStation/key/amenity/value/lifeboat_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LiftGate"></see>
    /// </summary>
    let LiftGate = _prefix "LiftGate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LiftGate/key/barrier/value/lift_gate"></see>
    /// </summary>
    let ``LiftGate/key/barrier/value/lift_gate`` =
        _prefix "LiftGate/key/barrier/value/lift_gate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LightRail"></see>
    /// </summary>
    let LightRail = _prefix "LightRail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LightRail/key/railway/value/light_rail"></see>
    /// </summary>
    let ``LightRail/key/railway/value/light_rail`` =
        _prefix "LightRail/key/railway/value/light_rail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lighthouse"></see>
    /// </summary>
    let Lighthouse = _prefix "Lighthouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lighthouse/key/man_made/value/lighthouse"></see>
    /// </summary>
    let ``Lighthouse/key/man_made/value/lighthouse`` =
        _prefix "Lighthouse/key/man_made/value/lighthouse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lighting"></see>
    /// </summary>
    let Lighting = _prefix "Lighting"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lighting/key/shop/value/lighting"></see>
    /// </summary>
    let ``Lighting/key/shop/value/lighting`` =
        _prefix "Lighting/key/shop/value/lighting"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LineConnection"></see>
    /// </summary>
    let LineConnection = _prefix "LineConnection"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LineConnection/key/power/value/line_connection"></see>
    /// </summary>
    let ``LineConnection/key/power/value/line_connection`` =
        _prefix "LineConnection/key/power/value/line_connection"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lingerie"></see>
    /// </summary>
    let Lingerie = _prefix "Lingerie"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lingerie/key/shop/value/lingerie"></see>
    /// </summary>
    let ``Lingerie/key/shop/value/lingerie`` =
        _prefix "Lingerie/key/shop/value/lingerie"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LitterBin"></see>
    /// </summary>
    let LitterBin = _prefix "LitterBin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LitterBin/key/amenity/value/litter_bin"></see>
    /// </summary>
    let ``LitterBin/key/amenity/value/litter_bin`` =
        _prefix "LitterBin/key/amenity/value/litter_bin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LivingStreet"></see>
    /// </summary>
    let LivingStreet = _prefix "LivingStreet"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LivingStreet/key/highway/value/living_street"></see>
    /// </summary>
    let ``LivingStreet/key/highway/value/living_street`` =
        _prefix "LivingStreet/key/highway/value/living_street"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locality"></see>
    /// </summary>
    let Locality = _prefix "Locality"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locality/key/place/value/locality"></see>
    /// </summary>
    let ``Locality/key/place/value/locality`` =
        _prefix "Locality/key/place/value/locality"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lock"></see>
    /// </summary>
    let Lock = _prefix "Lock"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Lock/key/lock/value/yes"></see>
    /// </summary>
    let ``Lock/key/lock/value/yes`` = _prefix "Lock/key/lock/value/yes"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LockThing"></see>
    /// </summary>
    let LockThing = _prefix "LockThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LockGate"></see>
    /// </summary>
    let LockGate = _prefix "LockGate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LockGate/key/waterway/value/lock_gate"></see>
    /// </summary>
    let ``LockGate/key/waterway/value/lock_gate`` =
        _prefix "LockGate/key/waterway/value/lock_gate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locksmith"></see>
    /// </summary>
    let Locksmith = _prefix "Locksmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locksmith/key/shop/value/locksmith"></see>
    /// </summary>
    let ``Locksmith/key/shop/value/locksmith`` =
        _prefix "Locksmith/key/shop/value/locksmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Locksmith/key/craft/value/locksmith"></see>
    /// </summary>
    let ``Locksmith/key/craft/value/locksmith`` =
        _prefix "Locksmith/key/craft/value/locksmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LookoutTower"></see>
    /// </summary>
    let LookoutTower = _prefix "LookoutTower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/LookoutTower/key/man_made/value/lookout_tower"></see>
    /// </summary>
    let ``LookoutTower/key/man_made/value/lookout_tower`` =
        _prefix "LookoutTower/key/man_made/value/lookout_tower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MDF"></see>
    /// </summary>
    let MDF = _prefix "MDF"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MDF/key/man_made/value/MDF"></see>
    /// </summary>
    let ``MDF/key/man_made/value/MDF`` = _prefix "MDF/key/man_made/value/MDF"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mall"></see>
    /// </summary>
    let Mall = _prefix "Mall"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mall/key/shop/value/mall"></see>
    /// </summary>
    let ``Mall/key/shop/value/mall`` = _prefix "Mall/key/shop/value/mall"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBarn"></see>
    /// </summary>
    let ManMadeBarn = _prefix "ManMadeBarn"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBarn/key/man_made/value/barn"></see>
    /// </summary>
    let ``ManMadeBarn/key/man_made/value/barn`` =
        _prefix "ManMadeBarn/key/man_made/value/barn"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBillboard"></see>
    /// </summary>
    let ManMadeBillboard = _prefix "ManMadeBillboard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBillboard/key/man_made/value/billboard"></see>
    /// </summary>
    let ``ManMadeBillboard/key/man_made/value/billboard`` =
        _prefix "ManMadeBillboard/key/man_made/value/billboard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBuilding"></see>
    /// </summary>
    let ManMadeBuilding = _prefix "ManMadeBuilding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBuilding/key/man_made/value/building"></see>
    /// </summary>
    let ``ManMadeBuilding/key/man_made/value/building`` =
        _prefix "ManMadeBuilding/key/man_made/value/building"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBuoy"></see>
    /// </summary>
    let ManMadeBuoy = _prefix "ManMadeBuoy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeBuoy/key/man_made/value/buoy"></see>
    /// </summary>
    let ``ManMadeBuoy/key/man_made/value/buoy`` =
        _prefix "ManMadeBuoy/key/man_made/value/buoy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeCross"></see>
    /// </summary>
    let ManMadeCross = _prefix "ManMadeCross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeCross/key/man_made/value/cross"></see>
    /// </summary>
    let ``ManMadeCross/key/man_made/value/cross`` =
        _prefix "ManMadeCross/key/man_made/value/cross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFireHydrant"></see>
    /// </summary>
    let ManMadeFireHydrant = _prefix "ManMadeFireHydrant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFireHydrant/key/man_made/value/fire_hydrant"></see>
    /// </summary>
    let ``ManMadeFireHydrant/key/man_made/value/fire_hydrant`` =
        _prefix "ManMadeFireHydrant/key/man_made/value/fire_hydrant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFixme"></see>
    /// </summary>
    let ManMadeFixme = _prefix "ManMadeFixme"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFixme/key/man_made/value/fixme"></see>
    /// </summary>
    let ``ManMadeFixme/key/man_made/value/fixme`` =
        _prefix "ManMadeFixme/key/man_made/value/fixme"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFountain"></see>
    /// </summary>
    let ManMadeFountain = _prefix "ManMadeFountain"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeFountain/key/man_made/value/fountain"></see>
    /// </summary>
    let ``ManMadeFountain/key/man_made/value/fountain`` =
        _prefix "ManMadeFountain/key/man_made/value/fountain"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeGate"></see>
    /// </summary>
    let ManMadeGate = _prefix "ManMadeGate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeGate/key/man_made/value/gate"></see>
    /// </summary>
    let ``ManMadeGate/key/man_made/value/gate`` =
        _prefix "ManMadeGate/key/man_made/value/gate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeHut"></see>
    /// </summary>
    let ManMadeHut = _prefix "ManMadeHut"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeHut/key/man_made/value/hut"></see>
    /// </summary>
    let ``ManMadeHut/key/man_made/value/hut`` =
        _prefix "ManMadeHut/key/man_made/value/hut"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeLamp"></see>
    /// </summary>
    let ManMadeLamp = _prefix "ManMadeLamp"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeLamp/key/man_made/value/lamp"></see>
    /// </summary>
    let ``ManMadeLamp/key/man_made/value/lamp`` =
        _prefix "ManMadeLamp/key/man_made/value/lamp"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeLampPost"></see>
    /// </summary>
    let ManMadeLampPost = _prefix "ManMadeLampPost"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeLampPost/key/man_made/value/lamp_post"></see>
    /// </summary>
    let ``ManMadeLampPost/key/man_made/value/lamp_post`` =
        _prefix "ManMadeLampPost/key/man_made/value/lamp_post"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeMine"></see>
    /// </summary>
    let ManMadeMine = _prefix "ManMadeMine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeMine/key/man_made/value/mine"></see>
    /// </summary>
    let ``ManMadeMine/key/man_made/value/mine`` =
        _prefix "ManMadeMine/key/man_made/value/mine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeObservatory"></see>
    /// </summary>
    let ManMadeObservatory = _prefix "ManMadeObservatory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeObservatory/key/man_made/value/observatory"></see>
    /// </summary>
    let ``ManMadeObservatory/key/man_made/value/observatory`` =
        _prefix "ManMadeObservatory/key/man_made/value/observatory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadePole"></see>
    /// </summary>
    let ManMadePole = _prefix "ManMadePole"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadePole/key/man_made/value/pole"></see>
    /// </summary>
    let ``ManMadePole/key/man_made/value/pole`` =
        _prefix "ManMadePole/key/man_made/value/pole"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadePumpingStation"></see>
    /// </summary>
    let ManMadePumpingStation = _prefix "ManMadePumpingStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadePumpingStation/key/man_made/value/pumping_station"></see>
    /// </summary>
    let ``ManMadePumpingStation/key/man_made/value/pumping_station`` =
        _prefix "ManMadePumpingStation/key/man_made/value/pumping_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeSign"></see>
    /// </summary>
    let ManMadeSign = _prefix "ManMadeSign"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeSign/key/man_made/value/sign"></see>
    /// </summary>
    let ``ManMadeSign/key/man_made/value/sign`` =
        _prefix "ManMadeSign/key/man_made/value/sign"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeStatue"></see>
    /// </summary>
    let ManMadeStatue = _prefix "ManMadeStatue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeStatue/key/man_made/value/statue"></see>
    /// </summary>
    let ``ManMadeStatue/key/man_made/value/statue`` =
        _prefix "ManMadeStatue/key/man_made/value/statue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeStorage"></see>
    /// </summary>
    let ManMadeStorage = _prefix "ManMadeStorage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeStorage/key/man_made/value/storage"></see>
    /// </summary>
    let ``ManMadeStorage/key/man_made/value/storage`` =
        _prefix "ManMadeStorage/key/man_made/value/storage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeTank"></see>
    /// </summary>
    let ManMadeTank = _prefix "ManMadeTank"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeTank/key/man_made/value/tank"></see>
    /// </summary>
    let ``ManMadeTank/key/man_made/value/tank`` =
        _prefix "ManMadeTank/key/man_made/value/tank"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeWell"></see>
    /// </summary>
    let ManMadeWell = _prefix "ManMadeWell"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ManMadeWell/key/man_made/value/well"></see>
    /// </summary>
    let ``ManMadeWell/key/man_made/value/well`` =
        _prefix "ManMadeWell/key/man_made/value/well"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Manhole"></see>
    /// </summary>
    let Manhole = _prefix "Manhole"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Manhole/key/man_made/value/manhole"></see>
    /// </summary>
    let ``Manhole/key/man_made/value/manhole`` =
        _prefix "Manhole/key/man_made/value/manhole"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Manor"></see>
    /// </summary>
    let Manor = _prefix "Manor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Manor/key/historic/value/manor"></see>
    /// </summary>
    let ``Manor/key/historic/value/manor`` = _prefix "Manor/key/historic/value/manor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marina"></see>
    /// </summary>
    let Marina = _prefix "Marina"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marina/key/leisure/value/marina"></see>
    /// </summary>
    let ``Marina/key/leisure/value/marina`` = _prefix "Marina/key/leisure/value/marina"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MaritimeBoundary"></see>
    /// </summary>
    let MaritimeBoundary = _prefix "MaritimeBoundary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MaritimeBoundary/key/boundary/value/maritime"></see>
    /// </summary>
    let ``MaritimeBoundary/key/boundary/value/maritime`` =
        _prefix "MaritimeBoundary/key/boundary/value/maritime"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Market"></see>
    /// </summary>
    let Market = _prefix "Market"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Market/key/shop/value/market"></see>
    /// </summary>
    let ``Market/key/shop/value/market`` = _prefix "Market/key/shop/value/market"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Market/key/amenity/value/market"></see>
    /// </summary>
    let ``Market/key/amenity/value/market`` = _prefix "Market/key/amenity/value/market"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marketplace"></see>
    /// </summary>
    let Marketplace = _prefix "Marketplace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marketplace/key/amenity/value/marketplace"></see>
    /// </summary>
    let ``Marketplace/key/amenity/value/marketplace`` =
        _prefix "Marketplace/key/amenity/value/marketplace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marsh"></see>
    /// </summary>
    let Marsh = _prefix "Marsh"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Marsh/key/natural/value/marsh"></see>
    /// </summary>
    let ``Marsh/key/natural/value/marsh`` = _prefix "Marsh/key/natural/value/marsh"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Massage"></see>
    /// </summary>
    let Massage = _prefix "Massage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Massage/key/amenity/value/massage"></see>
    /// </summary>
    let ``Massage/key/amenity/value/massage`` =
        _prefix "Massage/key/amenity/value/massage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MassageShop"></see>
    /// </summary>
    let MassageShop = _prefix "MassageShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MassageShop/key/shop/value/massage"></see>
    /// </summary>
    let ``MassageShop/key/shop/value/massage`` =
        _prefix "MassageShop/key/shop/value/massage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mast"></see>
    /// </summary>
    let Mast = _prefix "Mast"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mast/key/man_made/value/mast"></see>
    /// </summary>
    let ``Mast/key/man_made/value/mast`` = _prefix "Mast/key/man_made/value/mast"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mattress"></see>
    /// </summary>
    let Mattress = _prefix "Mattress"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mattress/key/shop/value/mattress"></see>
    /// </summary>
    let ``Mattress/key/shop/value/mattress`` =
        _prefix "Mattress/key/shop/value/mattress"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Meadow"></see>
    /// </summary>
    let Meadow = _prefix "Meadow"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Meadow/key/landuse/value/meadow"></see>
    /// </summary>
    let ``Meadow/key/landuse/value/meadow`` = _prefix "Meadow/key/landuse/value/meadow"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Meat"></see>
    /// </summary>
    let Meat = _prefix "Meat"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Meat/key/shop/value/meat"></see>
    /// </summary>
    let ``Meat/key/shop/value/meat`` = _prefix "Meat/key/shop/value/meat"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Medical"></see>
    /// </summary>
    let Medical = _prefix "Medical"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Medical/key/amenity/value/medical"></see>
    /// </summary>
    let ``Medical/key/amenity/value/medical`` =
        _prefix "Medical/key/amenity/value/medical"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MedicalCentre"></see>
    /// </summary>
    let MedicalCentre = _prefix "MedicalCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MedicalCentre/key/amenity/value/medical_centre"></see>
    /// </summary>
    let ``MedicalCentre/key/amenity/value/medical_centre`` =
        _prefix "MedicalCentre/key/amenity/value/medical_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Memorial"></see>
    /// </summary>
    let Memorial = _prefix "Memorial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Memorial/key/historic/value/memorial"></see>
    /// </summary>
    let ``Memorial/key/historic/value/memorial`` =
        _prefix "Memorial/key/historic/value/memorial"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Menhir"></see>
    /// </summary>
    let Menhir = _prefix "Menhir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Menhir/key/historic/value/menhir"></see>
    /// </summary>
    let ``Menhir/key/historic/value/menhir`` =
        _prefix "Menhir/key/historic/value/menhir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MetalConstructionCraft"></see>
    /// </summary>
    let MetalConstructionCraft = _prefix "MetalConstructionCraft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MetalConstructionCraft/key/craft/value/metal_construction"></see>
    /// </summary>
    let ``MetalConstructionCraft/key/craft/value/metal_construction`` =
        _prefix "MetalConstructionCraft/key/craft/value/metal_construction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Milestone"></see>
    /// </summary>
    let Milestone = _prefix "Milestone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Milestone/key/amenity/value/milestone"></see>
    /// </summary>
    let ``Milestone/key/amenity/value/milestone`` =
        _prefix "Milestone/key/amenity/value/milestone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryAirport"></see>
    /// </summary>
    let MilitaryAirport = _prefix "MilitaryAirport"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryAirport/key/military/value/airfield"></see>
    /// </summary>
    let ``MilitaryAirport/key/military/value/airfield`` =
        _prefix "MilitaryAirport/key/military/value/airfield"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryBunker"></see>
    /// </summary>
    let MilitaryBunker = _prefix "MilitaryBunker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryBunker/key/military/value/bunker"></see>
    /// </summary>
    let ``MilitaryBunker/key/military/value/bunker`` =
        _prefix "MilitaryBunker/key/military/value/bunker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryLanduse"></see>
    /// </summary>
    let MilitaryLanduse = _prefix "MilitaryLanduse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryLanduse/key/landuse/value/military"></see>
    /// </summary>
    let ``MilitaryLanduse/key/landuse/value/military`` =
        _prefix "MilitaryLanduse/key/landuse/value/military"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryRange"></see>
    /// </summary>
    let MilitaryRange = _prefix "MilitaryRange"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilitaryRange/key/military/value/range"></see>
    /// </summary>
    let ``MilitaryRange/key/military/value/range`` =
        _prefix "MilitaryRange/key/military/value/range"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilkDispenser"></see>
    /// </summary>
    let MilkDispenser = _prefix "MilkDispenser"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MilkDispenser/key/amenity/value/milk_dispenser"></see>
    /// </summary>
    let ``MilkDispenser/key/amenity/value/milk_dispenser`` =
        _prefix "MilkDispenser/key/amenity/value/milk_dispenser"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mill"></see>
    /// </summary>
    let Mill = _prefix "Mill"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mill/key/historic/value/mill"></see>
    /// </summary>
    let ``Mill/key/historic/value/mill`` = _prefix "Mill/key/historic/value/mill"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mine"></see>
    /// </summary>
    let Mine = _prefix "Mine"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mine/key/amenity/value/mine"></see>
    /// </summary>
    let ``Mine/key/amenity/value/mine`` = _prefix "Mine/key/amenity/value/mine"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MineShaft"></see>
    /// </summary>
    let MineShaft = _prefix "MineShaft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MineShaft/key/historic/value/mine_shaft"></see>
    /// </summary>
    let ``MineShaft/key/historic/value/mine_shaft`` =
        _prefix "MineShaft/key/historic/value/mine_shaft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MineralSpring"></see>
    /// </summary>
    let MineralSpring = _prefix "MineralSpring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MineralSpring/key/waterway/value/mineral_spring"></see>
    /// </summary>
    let ``MineralSpring/key/waterway/value/mineral_spring`` =
        _prefix "MineralSpring/key/waterway/value/mineral_spring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mineshaft"></see>
    /// </summary>
    let Mineshaft = _prefix "Mineshaft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mineshaft/key/man_made/value/mineshaft"></see>
    /// </summary>
    let ``Mineshaft/key/man_made/value/mineshaft`` =
        _prefix "Mineshaft/key/man_made/value/mineshaft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniRoundabout"></see>
    /// </summary>
    let MiniRoundabout = _prefix "MiniRoundabout"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniRoundabout/key/highway/value/mini_roundabout"></see>
    /// </summary>
    let ``MiniRoundabout/key/highway/value/mini_roundabout`` =
        _prefix "MiniRoundabout/key/highway/value/mini_roundabout"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniatureGolf"></see>
    /// </summary>
    let MiniatureGolf = _prefix "MiniatureGolf"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniatureGolf/key/leisure/value/miniature_golf"></see>
    /// </summary>
    let ``MiniatureGolf/key/leisure/value/miniature_golf`` =
        _prefix "MiniatureGolf/key/leisure/value/miniature_golf"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniatureRailway"></see>
    /// </summary>
    let MiniatureRailway = _prefix "MiniatureRailway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MiniatureRailway/key/railway/value/miniature"></see>
    /// </summary>
    let ``MiniatureRailway/key/railway/value/miniature`` =
        _prefix "MiniatureRailway/key/railway/value/miniature"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Minimarket"></see>
    /// </summary>
    let Minimarket = _prefix "Minimarket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Minimarket/key/shop/value/minimarket"></see>
    /// </summary>
    let ``Minimarket/key/shop/value/minimarket`` =
        _prefix "Minimarket/key/shop/value/minimarket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mining"></see>
    /// </summary>
    let Mining = _prefix "Mining"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mining/key/landuse/value/mining"></see>
    /// </summary>
    let ``Mining/key/landuse/value/mining`` = _prefix "Mining/key/landuse/value/mining"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Misc"></see>
    /// </summary>
    let Misc = _prefix "Misc"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Misc/key/shop/value/misc"></see>
    /// </summary>
    let ``Misc/key/shop/value/misc`` = _prefix "Misc/key/shop/value/misc"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MixedLift"></see>
    /// </summary>
    let MixedLift = _prefix "MixedLift"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MixedLift/key/aerialway/value/mixed_lift"></see>
    /// </summary>
    let ``MixedLift/key/aerialway/value/mixed_lift`` =
        _prefix "MixedLift/key/aerialway/value/mixed_lift"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mobile"></see>
    /// </summary>
    let Mobile = _prefix "Mobile"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mobile/key/shop/value/mobile"></see>
    /// </summary>
    let ``Mobile/key/shop/value/mobile`` = _prefix "Mobile/key/shop/value/mobile"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MobilePhone"></see>
    /// </summary>
    let MobilePhone = _prefix "MobilePhone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MobilePhone/key/shop/value/mobile_phone"></see>
    /// </summary>
    let ``MobilePhone/key/shop/value/mobile_phone`` =
        _prefix "MobilePhone/key/shop/value/mobile_phone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MobileTelephony"></see>
    /// </summary>
    let MobileTelephony = _prefix "MobileTelephony"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MobileTelephony/key/shop/value/mobile_telephony"></see>
    /// </summary>
    let ``MobileTelephony/key/shop/value/mobile_telephony`` =
        _prefix "MobileTelephony/key/shop/value/mobile_telephony"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monastery"></see>
    /// </summary>
    let Monastery = _prefix "Monastery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monastery/key/amenity/value/monastery"></see>
    /// </summary>
    let ``Monastery/key/amenity/value/monastery`` =
        _prefix "Monastery/key/amenity/value/monastery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MonitoringStation"></see>
    /// </summary>
    let MonitoringStation = _prefix "MonitoringStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MonitoringStation/key/man_made/value/monitoring_station"></see>
    /// </summary>
    let ``MonitoringStation/key/man_made/value/monitoring_station`` =
        _prefix "MonitoringStation/key/man_made/value/monitoring_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monorail"></see>
    /// </summary>
    let Monorail = _prefix "Monorail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monorail/key/railway/value/monorail"></see>
    /// </summary>
    let ``Monorail/key/railway/value/monorail`` =
        _prefix "Monorail/key/railway/value/monorail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monument"></see>
    /// </summary>
    let Monument = _prefix "Monument"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Monument/key/historic/value/monument"></see>
    /// </summary>
    let ``Monument/key/historic/value/monument`` =
        _prefix "Monument/key/historic/value/monument"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Moor"></see>
    /// </summary>
    let Moor = _prefix "Moor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Moor/key/natural/value/moor"></see>
    /// </summary>
    let ``Moor/key/natural/value/moor`` = _prefix "Moor/key/natural/value/moor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mooring"></see>
    /// </summary>
    let Mooring = _prefix "Mooring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mooring/key/waterway/value/mooring"></see>
    /// </summary>
    let ``Mooring/key/waterway/value/mooring`` =
        _prefix "Mooring/key/waterway/value/mooring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mortuary"></see>
    /// </summary>
    let Mortuary = _prefix "Mortuary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mortuary/key/amenity/value/mortuary"></see>
    /// </summary>
    let ``Mortuary/key/amenity/value/mortuary`` =
        _prefix "Mortuary/key/amenity/value/mortuary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motel"></see>
    /// </summary>
    let Motel = _prefix "Motel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motel/key/tourism/value/motel"></see>
    /// </summary>
    let ``Motel/key/tourism/value/motel`` = _prefix "Motel/key/tourism/value/motel"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorbike"></see>
    /// </summary>
    let Motorbike = _prefix "Motorbike"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorbike/key/shop/value/motorbike"></see>
    /// </summary>
    let ``Motorbike/key/shop/value/motorbike`` =
        _prefix "Motorbike/key/shop/value/motorbike"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorcycle"></see>
    /// </summary>
    let Motorcycle = _prefix "Motorcycle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorcycle/key/shop/value/motorcycle"></see>
    /// </summary>
    let ``Motorcycle/key/shop/value/motorcycle`` =
        _prefix "Motorcycle/key/shop/value/motorcycle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorcycleParking"></see>
    /// </summary>
    let MotorcycleParking = _prefix "MotorcycleParking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorcycleParking/key/amenity/value/motorcycle_parking"></see>
    /// </summary>
    let ``MotorcycleParking/key/amenity/value/motorcycle_parking`` =
        _prefix "MotorcycleParking/key/amenity/value/motorcycle_parking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorcycleRepair"></see>
    /// </summary>
    let MotorcycleRepair = _prefix "MotorcycleRepair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorcycleRepair/key/shop/value/motorcycle_repair"></see>
    /// </summary>
    let ``MotorcycleRepair/key/shop/value/motorcycle_repair`` =
        _prefix "MotorcycleRepair/key/shop/value/motorcycle_repair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorway"></see>
    /// </summary>
    let Motorway = _prefix "Motorway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Motorway/key/highway/value/motorway"></see>
    /// </summary>
    let ``Motorway/key/highway/value/motorway`` =
        _prefix "Motorway/key/highway/value/motorway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorwayJunction"></see>
    /// </summary>
    let MotorwayJunction = _prefix "MotorwayJunction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorwayJunction/key/highway/value/motorway_junction"></see>
    /// </summary>
    let ``MotorwayJunction/key/highway/value/motorway_junction`` =
        _prefix "MotorwayJunction/key/highway/value/motorway_junction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorwayLink"></see>
    /// </summary>
    let MotorwayLink = _prefix "MotorwayLink"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MotorwayLink/key/highway/value/motorway_link"></see>
    /// </summary>
    let ``MotorwayLink/key/highway/value/motorway_link`` =
        _prefix "MotorwayLink/key/highway/value/motorway_link"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MountainPass"></see>
    /// </summary>
    let MountainPass = _prefix "MountainPass"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MountainPass/key/natural/value/mountain_pass"></see>
    /// </summary>
    let ``MountainPass/key/natural/value/mountain_pass`` =
        _prefix "MountainPass/key/natural/value/mountain_pass"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MountainRescue"></see>
    /// </summary>
    let MountainRescue = _prefix "MountainRescue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MountainRescue/key/amenity/value/mountain_rescue"></see>
    /// </summary>
    let ``MountainRescue/key/amenity/value/mountain_rescue`` =
        _prefix "MountainRescue/key/amenity/value/mountain_rescue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MtbRoute"></see>
    /// </summary>
    let MtbRoute = _prefix "MtbRoute"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MtbRoute/key/route/value/mtb"></see>
    /// </summary>
    let ``MtbRoute/key/route/value/mtb`` = _prefix "MtbRoute/key/route/value/mtb"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mud"></see>
    /// </summary>
    let Mud = _prefix "Mud"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mud/key/natural/value/mud"></see>
    /// </summary>
    let ``Mud/key/natural/value/mud`` = _prefix "Mud/key/natural/value/mud"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MultiPolygon"></see>
    /// </summary>
    let MultiPolygon = _prefix "MultiPolygon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MultiPolygon/key/type/value/multipolygon"></see>
    /// </summary>
    let ``MultiPolygon/key/type/value/multipolygon`` =
        _prefix "MultiPolygon/key/type/value/multipolygon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Municipality"></see>
    /// </summary>
    let Municipality = _prefix "Municipality"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Municipality/key/place/value/municipality"></see>
    /// </summary>
    let ``Municipality/key/place/value/municipality`` =
        _prefix "Municipality/key/place/value/municipality"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Museum"></see>
    /// </summary>
    let Museum = _prefix "Museum"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Museum/key/tourism/value/museum"></see>
    /// </summary>
    let ``Museum/key/tourism/value/museum`` = _prefix "Museum/key/tourism/value/museum"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mushroom"></see>
    /// </summary>
    let Mushroom = _prefix "Mushroom"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Mushroom/key/natural/value/mushroom"></see>
    /// </summary>
    let ``Mushroom/key/natural/value/mushroom`` =
        _prefix "Mushroom/key/natural/value/mushroom"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Music"></see>
    /// </summary>
    let Music = _prefix "Music"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Music/key/shop/value/music"></see>
    /// </summary>
    let ``Music/key/shop/value/music`` = _prefix "Music/key/shop/value/music"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicVenue"></see>
    /// </summary>
    let MusicVenue = _prefix "MusicVenue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicVenue/key/leisure/value/music_venue"></see>
    /// </summary>
    let ``MusicVenue/key/leisure/value/music_venue`` =
        _prefix "MusicVenue/key/leisure/value/music_venue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicVenue/key/amenity/value/music_venue"></see>
    /// </summary>
    let ``MusicVenue/key/amenity/value/music_venue`` =
        _prefix "MusicVenue/key/amenity/value/music_venue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicalInstruments"></see>
    /// </summary>
    let MusicalInstruments = _prefix "MusicalInstruments"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/MusicalInstruments/key/shop/value/musical_instruments"></see>
    /// </summary>
    let ``MusicalInstruments/key/shop/value/musical_instruments`` =
        _prefix "MusicalInstruments/key/shop/value/musical_instruments"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NailSalon"></see>
    /// </summary>
    let NailSalon = _prefix "NailSalon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NailSalon/key/shop/value/nail_salon"></see>
    /// </summary>
    let ``NailSalon/key/shop/value/nail_salon`` =
        _prefix "NailSalon/key/shop/value/nail_salon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nails"></see>
    /// </summary>
    let Nails = _prefix "Nails"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nails/key/shop/value/nails"></see>
    /// </summary>
    let ``Nails/key/shop/value/nails`` = _prefix "Nails/key/shop/value/nails"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NarrowGauge"></see>
    /// </summary>
    let NarrowGauge = _prefix "NarrowGauge"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NarrowGauge/key/railway/value/narrow_gauge"></see>
    /// </summary>
    let ``NarrowGauge/key/railway/value/narrow_gauge`` =
        _prefix "NarrowGauge/key/railway/value/narrow_gauge"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NationalForest"></see>
    /// </summary>
    let NationalForest = _prefix "NationalForest"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NationalForest/key/boundary/value/national_forest"></see>
    /// </summary>
    let ``NationalForest/key/boundary/value/national_forest`` =
        _prefix "NationalForest/key/boundary/value/national_forest"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NationalPark"></see>
    /// </summary>
    let NationalPark = _prefix "NationalPark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NationalPark/key/boundary/value/national_park"></see>
    /// </summary>
    let ``NationalPark/key/boundary/value/national_park`` =
        _prefix "NationalPark/key/boundary/value/national_park"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalBench"></see>
    /// </summary>
    let NaturalBench = _prefix "NaturalBench"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalBench/key/natural/value/bench"></see>
    /// </summary>
    let ``NaturalBench/key/natural/value/bench`` =
        _prefix "NaturalBench/key/natural/value/bench"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalRiver"></see>
    /// </summary>
    let NaturalRiver = _prefix "NaturalRiver"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalRiver/key/natural/value/river"></see>
    /// </summary>
    let ``NaturalRiver/key/natural/value/river`` =
        _prefix "NaturalRiver/key/natural/value/river"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalRock"></see>
    /// </summary>
    let NaturalRock = _prefix "NaturalRock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalRock/key/natural/value/rock"></see>
    /// </summary>
    let ``NaturalRock/key/natural/value/rock`` =
        _prefix "NaturalRock/key/natural/value/rock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalShelter"></see>
    /// </summary>
    let NaturalShelter = _prefix "NaturalShelter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalShelter/key/amenity/value/natural_shelter"></see>
    /// </summary>
    let ``NaturalShelter/key/amenity/value/natural_shelter`` =
        _prefix "NaturalShelter/key/amenity/value/natural_shelter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalValley"></see>
    /// </summary>
    let NaturalValley = _prefix "NaturalValley"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalValley/key/natural/value/valley"></see>
    /// </summary>
    let ``NaturalValley/key/natural/value/valley`` =
        _prefix "NaturalValley/key/natural/value/valley"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalWaterfall"></see>
    /// </summary>
    let NaturalWaterfall = _prefix "NaturalWaterfall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NaturalWaterfall/key/natural/value/waterfall"></see>
    /// </summary>
    let ``NaturalWaterfall/key/natural/value/waterfall`` =
        _prefix "NaturalWaterfall/key/natural/value/waterfall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NatureReserve"></see>
    /// </summary>
    let NatureReserve = _prefix "NatureReserve"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NatureReserve/key/leisure/value/nature_reserve"></see>
    /// </summary>
    let ``NatureReserve/key/leisure/value/nature_reserve`` =
        _prefix "NatureReserve/key/leisure/value/nature_reserve"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NavalBase"></see>
    /// </summary>
    let NavalBase = _prefix "NavalBase"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NavalBase/key/military/value/naval_base"></see>
    /// </summary>
    let ``NavalBase/key/military/value/naval_base`` =
        _prefix "NavalBase/key/military/value/naval_base"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NestBox"></see>
    /// </summary>
    let NestBox = _prefix "NestBox"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NestBox/key/amenity/value/nest_box"></see>
    /// </summary>
    let ``NestBox/key/amenity/value/nest_box`` =
        _prefix "NestBox/key/amenity/value/nest_box"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Newsagent"></see>
    /// </summary>
    let Newsagent = _prefix "Newsagent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Newsagent/key/shop/value/newsagent"></see>
    /// </summary>
    let ``Newsagent/key/shop/value/newsagent`` =
        _prefix "Newsagent/key/shop/value/newsagent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NewspaperOffice"></see>
    /// </summary>
    let NewspaperOffice = _prefix "NewspaperOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NewspaperOffice/key/office/value/newspaper"></see>
    /// </summary>
    let ``NewspaperOffice/key/office/value/newspaper`` =
        _prefix "NewspaperOffice/key/office/value/newspaper"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Newsstand"></see>
    /// </summary>
    let Newsstand = _prefix "Newsstand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Newsstand/key/shop/value/newsstand"></see>
    /// </summary>
    let ``Newsstand/key/shop/value/newsstand`` =
        _prefix "Newsstand/key/shop/value/newsstand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NgoOffice"></see>
    /// </summary>
    let NgoOffice = _prefix "NgoOffice"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NgoOffice/key/office/value/ngo"></see>
    /// </summary>
    let ``NgoOffice/key/office/value/ngo`` = _prefix "NgoOffice/key/office/value/ngo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nightclub"></see>
    /// </summary>
    let Nightclub = _prefix "Nightclub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nightclub/key/amenity/value/nightclub"></see>
    /// </summary>
    let ``Nightclub/key/amenity/value/nightclub`` =
        _prefix "Nightclub/key/amenity/value/nightclub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NotAShop"></see>
    /// </summary>
    let NotAShop = _prefix "NotAShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NotAShop/key/shop/value/no"></see>
    /// </summary>
    let ``NotAShop/key/shop/value/no`` = _prefix "NotAShop/key/shop/value/no"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Notice"></see>
    /// </summary>
    let Notice = _prefix "Notice"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Notice/key/amenity/value/notice"></see>
    /// </summary>
    let ``Notice/key/amenity/value/notice`` = _prefix "Notice/key/amenity/value/notice"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nursery"></see>
    /// </summary>
    let Nursery = _prefix "Nursery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Nursery/key/amenity/value/nursery"></see>
    /// </summary>
    let ``Nursery/key/amenity/value/nursery`` =
        _prefix "Nursery/key/amenity/value/nursery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NursingHome"></see>
    /// </summary>
    let NursingHome = _prefix "NursingHome"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/NursingHome/key/amenity/value/nursing_home"></see>
    /// </summary>
    let ``NursingHome/key/amenity/value/nursing_home`` =
        _prefix "NursingHome/key/amenity/value/nursing_home"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Observatory"></see>
    /// </summary>
    let Observatory = _prefix "Observatory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Observatory/key/amenity/value/observatory"></see>
    /// </summary>
    let ``Observatory/key/amenity/value/observatory`` =
        _prefix "Observatory/key/amenity/value/observatory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Office/key/amenity/value/office"></see>
    /// </summary>
    let ``Office/key/amenity/value/office`` = _prefix "Office/key/amenity/value/office"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OfficeShop"></see>
    /// </summary>
    let OfficeShop = _prefix "OfficeShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OfficeShop/key/shop/value/office"></see>
    /// </summary>
    let ``OfficeShop/key/shop/value/office`` =
        _prefix "OfficeShop/key/shop/value/office"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OfficeSupplies"></see>
    /// </summary>
    let OfficeSupplies = _prefix "OfficeSupplies"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OfficeSupplies/key/shop/value/office_supplies"></see>
    /// </summary>
    let ``OfficeSupplies/key/shop/value/office_supplies`` =
        _prefix "OfficeSupplies/key/shop/value/office_supplies"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Offices"></see>
    /// </summary>
    let Offices = _prefix "Offices"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Offices/key/building/value/offices"></see>
    /// </summary>
    let ``Offices/key/building/value/offices`` =
        _prefix "Offices/key/building/value/offices"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OilPlatform"></see>
    /// </summary>
    let OilPlatform = _prefix "OilPlatform"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OilPlatform/key/man_made/value/oil_platform"></see>
    /// </summary>
    let ``OilPlatform/key/man_made/value/oil_platform`` =
        _prefix "OilPlatform/key/man_made/value/oil_platform"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OpticianCraft"></see>
    /// </summary>
    let OpticianCraft = _prefix "OpticianCraft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OpticianCraft/key/craft/value/optician"></see>
    /// </summary>
    let ``OpticianCraft/key/craft/value/optician`` =
        _prefix "OpticianCraft/key/craft/value/optician"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OpticianShop"></see>
    /// </summary>
    let OpticianShop = _prefix "OpticianShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OpticianShop/key/shop/value/optician"></see>
    /// </summary>
    let ``OpticianShop/key/shop/value/optician`` =
        _prefix "OpticianShop/key/shop/value/optician"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Optometrist"></see>
    /// </summary>
    let Optometrist = _prefix "Optometrist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Optometrist/key/amenity/value/optometrist"></see>
    /// </summary>
    let ``Optometrist/key/amenity/value/optometrist`` =
        _prefix "Optometrist/key/amenity/value/optometrist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Orchard"></see>
    /// </summary>
    let Orchard = _prefix "Orchard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Orchard/key/landuse/value/orchard"></see>
    /// </summary>
    let ``Orchard/key/landuse/value/orchard`` =
        _prefix "Orchard/key/landuse/value/orchard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Organic"></see>
    /// </summary>
    let Organic = _prefix "Organic"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Organic/key/shop/value/organic"></see>
    /// </summary>
    let ``Organic/key/shop/value/organic`` = _prefix "Organic/key/shop/value/organic"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Other"></see>
    /// </summary>
    let Other = _prefix "Other"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Other/key/amenity/value/other"></see>
    /// </summary>
    let ``Other/key/amenity/value/other`` = _prefix "Other/key/amenity/value/other"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OtherShop"></see>
    /// </summary>
    let OtherShop = _prefix "OtherShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/OtherShop/key/shop/value/other"></see>
    /// </summary>
    let ``OtherShop/key/shop/value/other`` = _prefix "OtherShop/key/shop/value/other"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outcrop"></see>
    /// </summary>
    let Outcrop = _prefix "Outcrop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outcrop/key/geological/value/outcrop"></see>
    /// </summary>
    let ``Outcrop/key/geological/value/outcrop`` =
        _prefix "Outcrop/key/geological/value/outcrop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outdoor"></see>
    /// </summary>
    let Outdoor = _prefix "Outdoor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outdoor/key/shop/value/outdoor"></see>
    /// </summary>
    let ``Outdoor/key/shop/value/outdoor`` = _prefix "Outdoor/key/shop/value/outdoor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outlet"></see>
    /// </summary>
    let Outlet = _prefix "Outlet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Outlet/key/shop/value/outlet"></see>
    /// </summary>
    let ``Outlet/key/shop/value/outlet`` = _prefix "Outlet/key/shop/value/outlet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Oven"></see>
    /// </summary>
    let Oven = _prefix "Oven"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Oven/key/man_made/value/oven"></see>
    /// </summary>
    let ``Oven/key/man_made/value/oven`` = _prefix "Oven/key/man_made/value/oven"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Paint"></see>
    /// </summary>
    let Paint = _prefix "Paint"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Paint/key/shop/value/paint"></see>
    /// </summary>
    let ``Paint/key/shop/value/paint`` = _prefix "Paint/key/shop/value/paint"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Painter"></see>
    /// </summary>
    let Painter = _prefix "Painter"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Painter/key/shop/value/painter"></see>
    /// </summary>
    let ``Painter/key/shop/value/painter`` = _prefix "Painter/key/shop/value/painter"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Painter/key/craft/value/painter"></see>
    /// </summary>
    let ``Painter/key/craft/value/painter`` = _prefix "Painter/key/craft/value/painter"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Palace"></see>
    /// </summary>
    let Palace = _prefix "Palace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Palace/key/historic/value/palace"></see>
    /// </summary>
    let ``Palace/key/historic/value/palace`` =
        _prefix "Palace/key/historic/value/palace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PalaeontologicalSite"></see>
    /// </summary>
    let PalaeontologicalSite = _prefix "PalaeontologicalSite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PalaeontologicalSite/key/geological/value/palaeontological_site"></see>
    /// </summary>
    let ``PalaeontologicalSite/key/geological/value/palaeontological_site`` =
        _prefix "PalaeontologicalSite/key/geological/value/palaeontological_site"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParcelBox"></see>
    /// </summary>
    let ParcelBox = _prefix "ParcelBox"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParcelBox/key/amenity/value/parcel_box"></see>
    /// </summary>
    let ``ParcelBox/key/amenity/value/parcel_box`` =
        _prefix "ParcelBox/key/amenity/value/parcel_box"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Park"></see>
    /// </summary>
    let Park = _prefix "Park"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Park/key/amenity/value/park"></see>
    /// </summary>
    let ``Park/key/amenity/value/park`` = _prefix "Park/key/amenity/value/park"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Park/key/leisure/value/park"></see>
    /// </summary>
    let ``Park/key/leisure/value/park`` = _prefix "Park/key/leisure/value/park"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkBench"></see>
    /// </summary>
    let ParkBench = _prefix "ParkBench"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkBench/key/leisure/value/park_bench"></see>
    /// </summary>
    let ``ParkBench/key/leisure/value/park_bench`` =
        _prefix "ParkBench/key/leisure/value/park_bench"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkBench/key/amenity/value/park_bench"></see>
    /// </summary>
    let ``ParkBench/key/amenity/value/park_bench`` =
        _prefix "ParkBench/key/amenity/value/park_bench"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking"></see>
    /// </summary>
    let Parking = _prefix "Parking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking/key/amenity/value/parking"></see>
    /// </summary>
    let ``Parking/key/amenity/value/parking`` =
        _prefix "Parking/key/amenity/value/parking"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking%3Bfuel"></see>
    /// </summary>
    let ``Parking%3Bfuel`` = _prefix "Parking%3Bfuel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking%3Bfuel/key/amenity/value/parking%3Bfuel"></see>
    /// </summary>
    let ``Parking%3Bfuel/key/amenity/value/parking%3Bfuel`` =
        _prefix "Parking%3Bfuel/key/amenity/value/parking%3Bfuel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking%3Brestaurant%3Bfuel"></see>
    /// </summary>
    let ``Parking%3Brestaurant%3Bfuel`` = _prefix "Parking%3Brestaurant%3Bfuel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Parking%3Brestaurant%3Bfuel/key/amenity/value/parking%3Brestaurant%3Bfuel"></see>
    /// </summary>
    let ``Parking%3Brestaurant%3Bfuel/key/amenity/value/parking%3Brestaurant%3Bfuel`` =
        _prefix "Parking%3Brestaurant%3Bfuel/key/amenity/value/parking%3Brestaurant%3Bfuel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingAisle"></see>
    /// </summary>
    let ParkingAisle = _prefix "ParkingAisle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingAisle/key/service/value/parking_aisle"></see>
    /// </summary>
    let ``ParkingAisle/key/service/value/parking_aisle`` =
        _prefix "ParkingAisle/key/service/value/parking_aisle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingEntrance"></see>
    /// </summary>
    let ParkingEntrance = _prefix "ParkingEntrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingEntrance/key/amenity/value/parking_entrance"></see>
    /// </summary>
    let ``ParkingEntrance/key/amenity/value/parking_entrance`` =
        _prefix "ParkingEntrance/key/amenity/value/parking_entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingMeter"></see>
    /// </summary>
    let ParkingMeter = _prefix "ParkingMeter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingMeter/key/amenity/value/parking_meter"></see>
    /// </summary>
    let ``ParkingMeter/key/amenity/value/parking_meter`` =
        _prefix "ParkingMeter/key/amenity/value/parking_meter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingPosition"></see>
    /// </summary>
    let ParkingPosition = _prefix "ParkingPosition"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingPosition/key/aeroway/value/parking_position"></see>
    /// </summary>
    let ``ParkingPosition/key/aeroway/value/parking_position`` =
        _prefix "ParkingPosition/key/aeroway/value/parking_position"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingSpace"></see>
    /// </summary>
    let ParkingSpace = _prefix "ParkingSpace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParkingSpace/key/amenity/value/parking_space"></see>
    /// </summary>
    let ``ParkingSpace/key/amenity/value/parking_space`` =
        _prefix "ParkingSpace/key/amenity/value/parking_space"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParquetLayer"></see>
    /// </summary>
    let ParquetLayer = _prefix "ParquetLayer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ParquetLayer/key/craft/value/parquet_layer"></see>
    /// </summary>
    let ``ParquetLayer/key/craft/value/parquet_layer`` =
        _prefix "ParquetLayer/key/craft/value/parquet_layer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PassingPlace"></see>
    /// </summary>
    let PassingPlace = _prefix "PassingPlace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PassingPlace/key/highway/value/passing_place"></see>
    /// </summary>
    let ``PassingPlace/key/highway/value/passing_place`` =
        _prefix "PassingPlace/key/highway/value/passing_place"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PassingPlaces"></see>
    /// </summary>
    let PassingPlaces = _prefix "PassingPlaces"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PassingPlaces/key/highway/value/passing_places"></see>
    /// </summary>
    let ``PassingPlaces/key/highway/value/passing_places`` =
        _prefix "PassingPlaces/key/highway/value/passing_places"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pastry"></see>
    /// </summary>
    let Pastry = _prefix "Pastry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pastry/key/shop/value/pastry"></see>
    /// </summary>
    let ``Pastry/key/shop/value/pastry`` = _prefix "Pastry/key/shop/value/pastry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Path"></see>
    /// </summary>
    let Path = _prefix "Path"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Path/key/highway/value/path"></see>
    /// </summary>
    let ``Path/key/highway/value/path`` = _prefix "Path/key/highway/value/path"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Patisserie"></see>
    /// </summary>
    let Patisserie = _prefix "Patisserie"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Patisserie/key/shop/value/patisserie"></see>
    /// </summary>
    let ``Patisserie/key/shop/value/patisserie`` =
        _prefix "Patisserie/key/shop/value/patisserie"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pavilion"></see>
    /// </summary>
    let Pavilion = _prefix "Pavilion"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pavilion/key/building/value/pavilion"></see>
    /// </summary>
    let ``Pavilion/key/building/value/pavilion`` =
        _prefix "Pavilion/key/building/value/pavilion"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pawnshop"></see>
    /// </summary>
    let Pawnshop = _prefix "Pawnshop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pawnshop/key/shop/value/pawnshop"></see>
    /// </summary>
    let ``Pawnshop/key/shop/value/pawnshop`` =
        _prefix "Pawnshop/key/shop/value/pawnshop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PaydayLoans"></see>
    /// </summary>
    let PaydayLoans = _prefix "PaydayLoans"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PaydayLoans/key/shop/value/payday_loans"></see>
    /// </summary>
    let ``PaydayLoans/key/shop/value/payday_loans`` =
        _prefix "PaydayLoans/key/shop/value/payday_loans"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Peak"></see>
    /// </summary>
    let Peak = _prefix "Peak"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Peak/key/natural/value/peak"></see>
    /// </summary>
    let ``Peak/key/natural/value/peak`` = _prefix "Peak/key/natural/value/peak"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PedestrianUse"></see>
    /// </summary>
    let PedestrianUse = _prefix "PedestrianUse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PedestrianUse/key/highway/value/pedestrian"></see>
    /// </summary>
    let ``PedestrianUse/key/highway/value/pedestrian`` =
        _prefix "PedestrianUse/key/highway/value/pedestrian"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Peninsula"></see>
    /// </summary>
    let Peninsula = _prefix "Peninsula"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Peninsula/key/natural/value/peninsula"></see>
    /// </summary>
    let ``Peninsula/key/natural/value/peninsula`` =
        _prefix "Peninsula/key/natural/value/peninsula"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Perfume"></see>
    /// </summary>
    let Perfume = _prefix "Perfume"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Perfume/key/shop/value/perfume"></see>
    /// </summary>
    let ``Perfume/key/shop/value/perfume`` = _prefix "Perfume/key/shop/value/perfume"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Perfumery"></see>
    /// </summary>
    let Perfumery = _prefix "Perfumery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Perfumery/key/shop/value/perfumery"></see>
    /// </summary>
    let ``Perfumery/key/shop/value/perfumery`` =
        _prefix "Perfumery/key/shop/value/perfumery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pet"></see>
    /// </summary>
    let Pet = _prefix "Pet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pet/key/shop/value/pet"></see>
    /// </summary>
    let ``Pet/key/shop/value/pet`` = _prefix "Pet/key/shop/value/pet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetFood"></see>
    /// </summary>
    let PetFood = _prefix "PetFood"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetFood/key/shop/value/pet_food"></see>
    /// </summary>
    let ``PetFood/key/shop/value/pet_food`` = _prefix "PetFood/key/shop/value/pet_food"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetShop"></see>
    /// </summary>
    let PetShop = _prefix "PetShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetShop/key/shop/value/pet_shop"></see>
    /// </summary>
    let ``PetShop/key/shop/value/pet_shop`` = _prefix "PetShop/key/shop/value/pet_shop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetSupplies"></see>
    /// </summary>
    let PetSupplies = _prefix "PetSupplies"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetSupplies/key/shop/value/pet_supplies"></see>
    /// </summary>
    let ``PetSupplies/key/shop/value/pet_supplies`` =
        _prefix "PetSupplies/key/shop/value/pet_supplies"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetSupply"></see>
    /// </summary>
    let PetSupply = _prefix "PetSupply"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetSupply/key/shop/value/pet_supply"></see>
    /// </summary>
    let ``PetSupply/key/shop/value/pet_supply`` =
        _prefix "PetSupply/key/shop/value/pet_supply"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetroleumWell"></see>
    /// </summary>
    let PetroleumWell = _prefix "PetroleumWell"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PetroleumWell/key/man_made/value/petroleum_well"></see>
    /// </summary>
    let ``PetroleumWell/key/man_made/value/petroleum_well`` =
        _prefix "PetroleumWell/key/man_made/value/petroleum_well"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pets"></see>
    /// </summary>
    let Pets = _prefix "Pets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pets/key/shop/value/pets"></see>
    /// </summary>
    let ``Pets/key/shop/value/pets`` = _prefix "Pets/key/shop/value/pets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pharmacy"></see>
    /// </summary>
    let Pharmacy = _prefix "Pharmacy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pharmacy/key/shop/value/pharmacy"></see>
    /// </summary>
    let ``Pharmacy/key/shop/value/pharmacy`` =
        _prefix "Pharmacy/key/shop/value/pharmacy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pharmacy/key/amenity/value/pharmacy"></see>
    /// </summary>
    let ``Pharmacy/key/amenity/value/pharmacy`` =
        _prefix "Pharmacy/key/amenity/value/pharmacy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Phone"></see>
    /// </summary>
    let Phone = _prefix "Phone"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Phone/key/amenity/value/phone"></see>
    /// </summary>
    let ``Phone/key/amenity/value/phone`` = _prefix "Phone/key/amenity/value/phone"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhoneMast"></see>
    /// </summary>
    let PhoneMast = _prefix "PhoneMast"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhoneMast/key/man_made/value/phone_mast"></see>
    /// </summary>
    let ``PhoneMast/key/man_made/value/phone_mast`` =
        _prefix "PhoneMast/key/man_made/value/phone_mast"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhoneShop"></see>
    /// </summary>
    let PhoneShop = _prefix "PhoneShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhoneShop/key/shop/value/phone"></see>
    /// </summary>
    let ``PhoneShop/key/shop/value/phone`` = _prefix "PhoneShop/key/shop/value/phone"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photo"></see>
    /// </summary>
    let Photo = _prefix "Photo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photo/key/shop/value/photo"></see>
    /// </summary>
    let ``Photo/key/shop/value/photo`` = _prefix "Photo/key/shop/value/photo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photocopying"></see>
    /// </summary>
    let Photocopying = _prefix "Photocopying"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photocopying/key/shop/value/photocopying"></see>
    /// </summary>
    let ``Photocopying/key/shop/value/photocopying`` =
        _prefix "Photocopying/key/shop/value/photocopying"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photographer"></see>
    /// </summary>
    let Photographer = _prefix "Photographer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Photographer/key/craft/value/photographer"></see>
    /// </summary>
    let ``Photographer/key/craft/value/photographer`` =
        _prefix "Photographer/key/craft/value/photographer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhotographicLaboratory"></see>
    /// </summary>
    let PhotographicLaboratory = _prefix "PhotographicLaboratory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PhotographicLaboratory/key/craft/value/photographic_laboratory"></see>
    /// </summary>
    let ``PhotographicLaboratory/key/craft/value/photographic_laboratory`` =
        _prefix "PhotographicLaboratory/key/craft/value/photographic_laboratory"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Physiotherapy"></see>
    /// </summary>
    let Physiotherapy = _prefix "Physiotherapy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Physiotherapy/key/amenity/value/physiotherapy"></see>
    /// </summary>
    let ``Physiotherapy/key/amenity/value/physiotherapy`` =
        _prefix "Physiotherapy/key/amenity/value/physiotherapy"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Picknick"></see>
    /// </summary>
    let Picknick = _prefix "Picknick"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Picknick/key/amenity/value/picknick"></see>
    /// </summary>
    let ``Picknick/key/amenity/value/picknick`` =
        _prefix "Picknick/key/amenity/value/picknick"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Picnic+table"></see>
    /// </summary>
    let ``Picnic+table`` = _prefix "Picnic+table"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Picnic+table/key/amenity/value/picnic%20table"></see>
    /// </summary>
    let ``Picnic+table/key/amenity/value/picnic%20table`` =
        _prefix "Picnic+table/key/amenity/value/picnic%20table"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PicnicSite"></see>
    /// </summary>
    let PicnicSite = _prefix "PicnicSite"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PicnicSite/key/tourism/value/picnic_site"></see>
    /// </summary>
    let ``PicnicSite/key/tourism/value/picnic_site`` =
        _prefix "PicnicSite/key/tourism/value/picnic_site"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PicnicTable"></see>
    /// </summary>
    let PicnicTable = _prefix "PicnicTable"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PicnicTable/key/amenity/value/picnic_table"></see>
    /// </summary>
    let ``PicnicTable/key/amenity/value/picnic_table`` =
        _prefix "PicnicTable/key/amenity/value/picnic_table"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pier"></see>
    /// </summary>
    let Pier = _prefix "Pier"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pier/key/man_made/value/pier"></see>
    /// </summary>
    let ``Pier/key/man_made/value/pier`` = _prefix "Pier/key/man_made/value/pier"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pietra+miliare+FD"></see>
    /// </summary>
    let ``Pietra+miliare+FD`` = _prefix "Pietra+miliare+FD"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pietra+miliare+FD/key/amenity/value/pietra%20miliare%20FD"></see>
    /// </summary>
    let ``Pietra+miliare+FD/key/amenity/value/pietra%20miliare%20FD`` =
        _prefix "Pietra+miliare+FD/key/amenity/value/pietra%20miliare%20FD"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pipeline"></see>
    /// </summary>
    let Pipeline = _prefix "Pipeline"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pipeline/key/man_made/value/pipeline"></see>
    /// </summary>
    let ``Pipeline/key/man_made/value/pipeline`` =
        _prefix "Pipeline/key/man_made/value/pipeline"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PipelineMarker"></see>
    /// </summary>
    let PipelineMarker = _prefix "PipelineMarker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PipelineMarker/key/man_made/value/pipeline_marker"></see>
    /// </summary>
    let ``PipelineMarker/key/man_made/value/pipeline_marker`` =
        _prefix "PipelineMarker/key/man_made/value/pipeline_marker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pipelinemarker"></see>
    /// </summary>
    let Pipelinemarker = _prefix "Pipelinemarker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pipelinemarker/key/man_made/value/pipelinemarker"></see>
    /// </summary>
    let ``Pipelinemarker/key/man_made/value/pipelinemarker`` =
        _prefix "Pipelinemarker/key/man_made/value/pipelinemarker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PisteRoute"></see>
    /// </summary>
    let PisteRoute = _prefix "PisteRoute"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PisteRoute/key/route/value/piste"></see>
    /// </summary>
    let ``PisteRoute/key/route/value/piste`` =
        _prefix "PisteRoute/key/route/value/piste"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pitch"></see>
    /// </summary>
    let Pitch = _prefix "Pitch"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pitch/key/leisure/value/pitch"></see>
    /// </summary>
    let ``Pitch/key/leisure/value/pitch`` = _prefix "Pitch/key/leisure/value/pitch"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PlaceOfWorship"></see>
    /// </summary>
    let PlaceOfWorship = _prefix "PlaceOfWorship"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PlaceOfWorship/key/amenity/value/place_of_worship"></see>
    /// </summary>
    let ``PlaceOfWorship/key/amenity/value/place_of_worship`` =
        _prefix "PlaceOfWorship/key/amenity/value/place_of_worship"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plain"></see>
    /// </summary>
    let Plain = _prefix "Plain"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plain/key/natural/value/plain"></see>
    /// </summary>
    let ``Plain/key/natural/value/plain`` = _prefix "Plain/key/natural/value/plain"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PlantNursery"></see>
    /// </summary>
    let PlantNursery = _prefix "PlantNursery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PlantNursery/key/landuse/value/plant_nursery"></see>
    /// </summary>
    let ``PlantNursery/key/landuse/value/plant_nursery`` =
        _prefix "PlantNursery/key/landuse/value/plant_nursery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plasterer"></see>
    /// </summary>
    let Plasterer = _prefix "Plasterer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plasterer/key/craft/value/plasterer"></see>
    /// </summary>
    let ``Plasterer/key/craft/value/plasterer`` =
        _prefix "Plasterer/key/craft/value/plasterer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plateau"></see>
    /// </summary>
    let Plateau = _prefix "Plateau"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plateau/key/natural/value/plateau"></see>
    /// </summary>
    let ``Plateau/key/natural/value/plateau`` =
        _prefix "Plateau/key/natural/value/plateau"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Platform"></see>
    /// </summary>
    let Platform = _prefix "Platform"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Platform/key/public_transport/value/platform"></see>
    /// </summary>
    let ``Platform/key/public_transport/value/platform`` =
        _prefix "Platform/key/public_transport/value/platform"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicTransportThing"></see>
    /// </summary>
    let PublicTransportThing = _prefix "PublicTransportThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Playground"></see>
    /// </summary>
    let Playground = _prefix "Playground"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Playground/key/amenity/value/playground"></see>
    /// </summary>
    let ``Playground/key/amenity/value/playground`` =
        _prefix "Playground/key/amenity/value/playground"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Playground/key/leisure/value/playground"></see>
    /// </summary>
    let ``Playground/key/leisure/value/playground`` =
        _prefix "Playground/key/leisure/value/playground"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plumber"></see>
    /// </summary>
    let Plumber = _prefix "Plumber"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plumber/key/amenity/value/plumber"></see>
    /// </summary>
    let ``Plumber/key/amenity/value/plumber`` =
        _prefix "Plumber/key/amenity/value/plumber"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plumber/key/shop/value/plumber"></see>
    /// </summary>
    let ``Plumber/key/shop/value/plumber`` = _prefix "Plumber/key/shop/value/plumber"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Plumber/key/craft/value/plumber"></see>
    /// </summary>
    let ``Plumber/key/craft/value/plumber`` = _prefix "Plumber/key/craft/value/plumber"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Point"></see>
    /// </summary>
    let Point = _prefix "Point"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Point/key/natural/value/point"></see>
    /// </summary>
    let ``Point/key/natural/value/point`` = _prefix "Point/key/natural/value/point"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PointOfInterest"></see>
    /// </summary>
    let PointOfInterest = _prefix "PointOfInterest"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PointOfInterest/key/leisure/value/point_of_interest"></see>
    /// </summary>
    let ``PointOfInterest/key/leisure/value/point_of_interest`` =
        _prefix "PointOfInterest/key/leisure/value/point_of_interest"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PointOfInterest/key/tourism/value/yes"></see>
    /// </summary>
    let ``PointOfInterest/key/tourism/value/yes`` =
        _prefix "PointOfInterest/key/tourism/value/yes"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Police"></see>
    /// </summary>
    let Police = _prefix "Police"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Police/key/amenity/value/police"></see>
    /// </summary>
    let ``Police/key/amenity/value/police`` = _prefix "Police/key/amenity/value/police"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PoliticalBoundary"></see>
    /// </summary>
    let PoliticalBoundary = _prefix "PoliticalBoundary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PoliticalBoundary/key/boundary/value/political"></see>
    /// </summary>
    let ``PoliticalBoundary/key/boundary/value/political`` =
        _prefix "PoliticalBoundary/key/boundary/value/political"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PostBox"></see>
    /// </summary>
    let PostBox = _prefix "PostBox"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PostBox/key/amenity/value/post_box"></see>
    /// </summary>
    let ``PostBox/key/amenity/value/post_box`` =
        _prefix "PostBox/key/amenity/value/post_box"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PostOffice"></see>
    /// </summary>
    let PostOffice = _prefix "PostOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PostOffice/key/amenity/value/post_office"></see>
    /// </summary>
    let ``PostOffice/key/amenity/value/post_office`` =
        _prefix "PostOffice/key/amenity/value/post_office"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pottery"></see>
    /// </summary>
    let Pottery = _prefix "Pottery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pottery/key/shop/value/pottery"></see>
    /// </summary>
    let ``Pottery/key/shop/value/pottery`` = _prefix "Pottery/key/shop/value/pottery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pottery/key/craft/value/pottery"></see>
    /// </summary>
    let ``Pottery/key/craft/value/pottery`` = _prefix "Pottery/key/craft/value/pottery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerBox"></see>
    /// </summary>
    let PowerBox = _prefix "PowerBox"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerBox/key/power/value/box"></see>
    /// </summary>
    let ``PowerBox/key/power/value/box`` = _prefix "PowerBox/key/power/value/box"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerConstruction"></see>
    /// </summary>
    let PowerConstruction = _prefix "PowerConstruction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerConstruction/key/power/value/construction"></see>
    /// </summary>
    let ``PowerConstruction/key/power/value/construction`` =
        _prefix "PowerConstruction/key/power/value/construction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerDismantled"></see>
    /// </summary>
    let PowerDismantled = _prefix "PowerDismantled"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerDismantled/key/power/value/dismantled"></see>
    /// </summary>
    let ``PowerDismantled/key/power/value/dismantled`` =
        _prefix "PowerDismantled/key/power/value/dismantled"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerGenerator"></see>
    /// </summary>
    let PowerGenerator = _prefix "PowerGenerator"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerGenerator/key/power/value/generator"></see>
    /// </summary>
    let ``PowerGenerator/key/power/value/generator`` =
        _prefix "PowerGenerator/key/power/value/generator"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerLine"></see>
    /// </summary>
    let PowerLine = _prefix "PowerLine"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerLine/key/power/value/line"></see>
    /// </summary>
    let ``PowerLine/key/power/value/line`` = _prefix "PowerLine/key/power/value/line"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerMinorLine"></see>
    /// </summary>
    let PowerMinorLine = _prefix "PowerMinorLine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerMinorLine/key/power/value/minor_line"></see>
    /// </summary>
    let ``PowerMinorLine/key/power/value/minor_line`` =
        _prefix "PowerMinorLine/key/power/value/minor_line"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerPole"></see>
    /// </summary>
    let PowerPole = _prefix "PowerPole"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerPole/key/power/value/pole"></see>
    /// </summary>
    let ``PowerPole/key/power/value/pole`` = _prefix "PowerPole/key/power/value/pole"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerPylon"></see>
    /// </summary>
    let PowerPylon = _prefix "PowerPylon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerPylon/key/power/value/pylon"></see>
    /// </summary>
    let ``PowerPylon/key/power/value/pylon`` =
        _prefix "PowerPylon/key/power/value/pylon"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerStation"></see>
    /// </summary>
    let PowerStation = _prefix "PowerStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerStation/key/power/value/station"></see>
    /// </summary>
    let ``PowerStation/key/power/value/station`` =
        _prefix "PowerStation/key/power/value/station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerSubStation"></see>
    /// </summary>
    let PowerSubStation = _prefix "PowerSubStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerSubStation/key/power/value/sub_station"></see>
    /// </summary>
    let ``PowerSubStation/key/power/value/sub_station`` =
        _prefix "PowerSubStation/key/power/value/sub_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerSwitch"></see>
    /// </summary>
    let PowerSwitch = _prefix "PowerSwitch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerSwitch/key/power/value/switch"></see>
    /// </summary>
    let ``PowerSwitch/key/power/value/switch`` =
        _prefix "PowerSwitch/key/power/value/switch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerTower"></see>
    /// </summary>
    let PowerTower = _prefix "PowerTower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PowerTower/key/power/value/tower"></see>
    /// </summary>
    let ``PowerTower/key/power/value/tower`` =
        _prefix "PowerTower/key/power/value/tower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Preschool"></see>
    /// </summary>
    let Preschool = _prefix "Preschool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Preschool/key/amenity/value/preschool"></see>
    /// </summary>
    let ``Preschool/key/amenity/value/preschool`` =
        _prefix "Preschool/key/amenity/value/preschool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PreservedRailway"></see>
    /// </summary>
    let PreservedRailway = _prefix "PreservedRailway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PreservedRailway/key/railway/value/preserved"></see>
    /// </summary>
    let ``PreservedRailway/key/railway/value/preserved`` =
        _prefix "PreservedRailway/key/railway/value/preserved"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PrimaryHighway"></see>
    /// </summary>
    let PrimaryHighway = _prefix "PrimaryHighway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PrimaryHighway/key/highway/value/primary"></see>
    /// </summary>
    let ``PrimaryHighway/key/highway/value/primary`` =
        _prefix "PrimaryHighway/key/highway/value/primary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Printer"></see>
    /// </summary>
    let Printer = _prefix "Printer"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Printer/key/shop/value/printer"></see>
    /// </summary>
    let ``Printer/key/shop/value/printer`` = _prefix "Printer/key/shop/value/printer"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Printing"></see>
    /// </summary>
    let Printing = _prefix "Printing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Printing/key/shop/value/printing"></see>
    /// </summary>
    let ``Printing/key/shop/value/printing`` =
        _prefix "Printing/key/shop/value/printing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Prison"></see>
    /// </summary>
    let Prison = _prefix "Prison"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Prison/key/amenity/value/prison"></see>
    /// </summary>
    let ``Prison/key/amenity/value/prison`` = _prefix "Prison/key/amenity/value/prison"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProposedHighway"></see>
    /// </summary>
    let ProposedHighway = _prefix "ProposedHighway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProposedHighway/key/highway/value/proposed"></see>
    /// </summary>
    let ``ProposedHighway/key/highway/value/proposed`` =
        _prefix "ProposedHighway/key/highway/value/proposed"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProtectedArea"></see>
    /// </summary>
    let ProtectedArea = _prefix "ProtectedArea"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProtectedArea/key/boundary/value/protected_area"></see>
    /// </summary>
    let ``ProtectedArea/key/boundary/value/protected_area`` =
        _prefix "ProtectedArea/key/boundary/value/protected_area"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProtectedBuilding"></see>
    /// </summary>
    let ProtectedBuilding = _prefix "ProtectedBuilding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ProtectedBuilding/key/historic/value/protected_building"></see>
    /// </summary>
    let ``ProtectedBuilding/key/historic/value/protected_building`` =
        _prefix "ProtectedBuilding/key/historic/value/protected_building"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pub"></see>
    /// </summary>
    let Pub = _prefix "Pub"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pub/key/amenity/value/pub"></see>
    /// </summary>
    let ``Pub/key/amenity/value/pub`` = _prefix "Pub/key/amenity/value/pub"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicBuilding"></see>
    /// </summary>
    let PublicBuilding = _prefix "PublicBuilding"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicBuilding/key/amenity/value/public_building"></see>
    /// </summary>
    let ``PublicBuilding/key/amenity/value/public_building`` =
        _prefix "PublicBuilding/key/amenity/value/public_building"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicMarket"></see>
    /// </summary>
    let PublicMarket = _prefix "PublicMarket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PublicMarket/key/amenity/value/public_market"></see>
    /// </summary>
    let ``PublicMarket/key/amenity/value/public_market`` =
        _prefix "PublicMarket/key/amenity/value/public_market"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pump"></see>
    /// </summary>
    let Pump = _prefix "Pump"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pump/key/man_made/value/pump"></see>
    /// </summary>
    let ``Pump/key/man_made/value/pump`` = _prefix "Pump/key/man_made/value/pump"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PumpingRig"></see>
    /// </summary>
    let PumpingRig = _prefix "PumpingRig"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/PumpingRig/key/man_made/value/pumping_rig"></see>
    /// </summary>
    let ``PumpingRig/key/man_made/value/pumping_rig`` =
        _prefix "PumpingRig/key/man_made/value/pumping_rig"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pumpjack"></see>
    /// </summary>
    let Pumpjack = _prefix "Pumpjack"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pumpjack/key/man_made/value/pumpjack"></see>
    /// </summary>
    let ``Pumpjack/key/man_made/value/pumpjack`` =
        _prefix "Pumpjack/key/man_made/value/pumpjack"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pylon"></see>
    /// </summary>
    let Pylon = _prefix "Pylon"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Pylon/key/aerialway/value/pylon"></see>
    /// </summary>
    let ``Pylon/key/aerialway/value/pylon`` = _prefix "Pylon/key/aerialway/value/pylon"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/QuangoOffice"></see>
    /// </summary>
    let QuangoOffice = _prefix "QuangoOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/QuangoOffice/key/office/value/quango"></see>
    /// </summary>
    let ``QuangoOffice/key/office/value/quango`` =
        _prefix "QuangoOffice/key/office/value/quango"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Quarry"></see>
    /// </summary>
    let Quarry = _prefix "Quarry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Quarry/key/landuse/value/quarry"></see>
    /// </summary>
    let ``Quarry/key/landuse/value/quarry`` = _prefix "Quarry/key/landuse/value/quarry"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Raceway"></see>
    /// </summary>
    let Raceway = _prefix "Raceway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Raceway/key/highway/value/raceway"></see>
    /// </summary>
    let ``Raceway/key/highway/value/raceway`` =
        _prefix "Raceway/key/highway/value/raceway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rail"></see>
    /// </summary>
    let Rail = _prefix "Rail"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rail/key/railway/value/rail"></see>
    /// </summary>
    let ``Rail/key/railway/value/rail`` = _prefix "Rail/key/railway/value/rail"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayConstruction"></see>
    /// </summary>
    let RailwayConstruction = _prefix "RailwayConstruction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayConstruction/key/railway/value/construction"></see>
    /// </summary>
    let ``RailwayConstruction/key/railway/value/construction`` =
        _prefix "RailwayConstruction/key/railway/value/construction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayCrossing"></see>
    /// </summary>
    let RailwayCrossing = _prefix "RailwayCrossing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayCrossing/key/railway/value/crossing"></see>
    /// </summary>
    let ``RailwayCrossing/key/railway/value/crossing`` =
        _prefix "RailwayCrossing/key/railway/value/crossing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayHalt"></see>
    /// </summary>
    let RailwayHalt = _prefix "RailwayHalt"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayHalt/key/railway/value/halt"></see>
    /// </summary>
    let ``RailwayHalt/key/railway/value/halt`` =
        _prefix "RailwayHalt/key/railway/value/halt"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayJunction"></see>
    /// </summary>
    let RailwayJunction = _prefix "RailwayJunction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayJunction/key/railway/value/junction"></see>
    /// </summary>
    let ``RailwayJunction/key/railway/value/junction`` =
        _prefix "RailwayJunction/key/railway/value/junction"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayLanduse"></see>
    /// </summary>
    let RailwayLanduse = _prefix "RailwayLanduse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayLanduse/key/landuse/value/railway"></see>
    /// </summary>
    let ``RailwayLanduse/key/landuse/value/railway`` =
        _prefix "RailwayLanduse/key/landuse/value/railway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayMilestone"></see>
    /// </summary>
    let RailwayMilestone = _prefix "RailwayMilestone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayMilestone/key/railway/value/milestone"></see>
    /// </summary>
    let ``RailwayMilestone/key/railway/value/milestone`` =
        _prefix "RailwayMilestone/key/railway/value/milestone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayPhone"></see>
    /// </summary>
    let RailwayPhone = _prefix "RailwayPhone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayPhone/key/railway/value/phone"></see>
    /// </summary>
    let ``RailwayPhone/key/railway/value/phone`` =
        _prefix "RailwayPhone/key/railway/value/phone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayPlatform"></see>
    /// </summary>
    let RailwayPlatform = _prefix "RailwayPlatform"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayPlatform/key/railway/value/platform"></see>
    /// </summary>
    let ``RailwayPlatform/key/railway/value/platform`` =
        _prefix "RailwayPlatform/key/railway/value/platform"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayRoute"></see>
    /// </summary>
    let RailwayRoute = _prefix "RailwayRoute"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayRoute/key/route/value/railway"></see>
    /// </summary>
    let ``RailwayRoute/key/route/value/railway`` =
        _prefix "RailwayRoute/key/route/value/railway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayStation"></see>
    /// </summary>
    let RailwayStation = _prefix "RailwayStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayStation/key/railway/value/station"></see>
    /// </summary>
    let ``RailwayStation/key/railway/value/station`` =
        _prefix "RailwayStation/key/railway/value/station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayStop"></see>
    /// </summary>
    let RailwayStop = _prefix "RailwayStop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwayStop/key/railway/value/stop"></see>
    /// </summary>
    let ``RailwayStop/key/railway/value/stop`` =
        _prefix "RailwayStop/key/railway/value/stop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwaySwitch"></see>
    /// </summary>
    let RailwaySwitch = _prefix "RailwaySwitch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RailwaySwitch/key/railway/value/switch"></see>
    /// </summary>
    let ``RailwaySwitch/key/railway/value/switch`` =
        _prefix "RailwaySwitch/key/railway/value/switch"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rapids"></see>
    /// </summary>
    let Rapids = _prefix "Rapids"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rapids/key/waterway/value/rapids"></see>
    /// </summary>
    let ``Rapids/key/waterway/value/rapids`` =
        _prefix "Rapids/key/waterway/value/rapids"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RealEstate"></see>
    /// </summary>
    let RealEstate = _prefix "RealEstate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RealEstate/key/shop/value/real_estate"></see>
    /// </summary>
    let ``RealEstate/key/shop/value/real_estate`` =
        _prefix "RealEstate/key/shop/value/real_estate"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ReceptionArea"></see>
    /// </summary>
    let ReceptionArea = _prefix "ReceptionArea"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ReceptionArea/key/amenity/value/reception_area"></see>
    /// </summary>
    let ``ReceptionArea/key/amenity/value/reception_area`` =
        _prefix "ReceptionArea/key/amenity/value/reception_area"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Records"></see>
    /// </summary>
    let Records = _prefix "Records"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Records/key/shop/value/records"></see>
    /// </summary>
    let ``Records/key/shop/value/records`` = _prefix "Records/key/shop/value/records"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RecreationGround"></see>
    /// </summary>
    let RecreationGround = _prefix "RecreationGround"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RecreationGround/key/landuse/value/recreation_ground"></see>
    /// </summary>
    let ``RecreationGround/key/landuse/value/recreation_ground`` =
        _prefix "RecreationGround/key/landuse/value/recreation_ground"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RecyclingFacility"></see>
    /// </summary>
    let RecyclingFacility = _prefix "RecyclingFacility"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RecyclingFacility/key/amenity/value/recycling"></see>
    /// </summary>
    let ``RecyclingFacility/key/amenity/value/recycling`` =
        _prefix "RecyclingFacility/key/amenity/value/recycling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RedCross"></see>
    /// </summary>
    let RedCross = _prefix "RedCross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RedCross/key/amenity/value/red_cross"></see>
    /// </summary>
    let ``RedCross/key/amenity/value/red_cross`` =
        _prefix "RedCross/key/amenity/value/red_cross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reef"></see>
    /// </summary>
    let Reef = _prefix "Reef"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reef/key/natural/value/reef"></see>
    /// </summary>
    let ``Reef/key/natural/value/reef`` = _prefix "Reef/key/natural/value/reef"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Region"></see>
    /// </summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Region/key/place/value/region"></see>
    /// </summary>
    let ``Region/key/place/value/region`` = _prefix "Region/key/place/value/region"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RegisterOffice"></see>
    /// </summary>
    let RegisterOffice = _prefix "RegisterOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RegisterOffice/key/amenity/value/register_office"></see>
    /// </summary>
    let ``RegisterOffice/key/amenity/value/register_office`` =
        _prefix "RegisterOffice/key/amenity/value/register_office"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RelayBox"></see>
    /// </summary>
    let RelayBox = _prefix "RelayBox"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RelayBox/key/amenity/value/relay_box"></see>
    /// </summary>
    let ``RelayBox/key/amenity/value/relay_box`` =
        _prefix "RelayBox/key/amenity/value/relay_box"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reportingpoint"></see>
    /// </summary>
    let Reportingpoint = _prefix "Reportingpoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reportingpoint/key/aeroway/value/reportingpoint"></see>
    /// </summary>
    let ``Reportingpoint/key/aeroway/value/reportingpoint`` =
        _prefix "Reportingpoint/key/aeroway/value/reportingpoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rescue"></see>
    /// </summary>
    let Rescue = _prefix "Rescue"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rescue/key/amenity/value/rescue"></see>
    /// </summary>
    let ``Rescue/key/amenity/value/rescue`` = _prefix "Rescue/key/amenity/value/rescue"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RescueBox"></see>
    /// </summary>
    let RescueBox = _prefix "RescueBox"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RescueBox/key/amenity/value/rescue_box"></see>
    /// </summary>
    let ``RescueBox/key/amenity/value/rescue_box`` =
        _prefix "RescueBox/key/amenity/value/rescue_box"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RescueService"></see>
    /// </summary>
    let RescueService = _prefix "RescueService"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RescueService/key/amenity/value/rescue_service"></see>
    /// </summary>
    let ``RescueService/key/amenity/value/rescue_service`` =
        _prefix "RescueService/key/amenity/value/rescue_service"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResearchOffice"></see>
    /// </summary>
    let ResearchOffice = _prefix "ResearchOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResearchOffice/key/office/value/research"></see>
    /// </summary>
    let ``ResearchOffice/key/office/value/research`` =
        _prefix "ResearchOffice/key/office/value/research"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reservoir"></see>
    /// </summary>
    let Reservoir = _prefix "Reservoir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reservoir/key/man_made/value/reservoir"></see>
    /// </summary>
    let ``Reservoir/key/man_made/value/reservoir`` =
        _prefix "Reservoir/key/man_made/value/reservoir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Reservoir/key/landuse/value/reservoir"></see>
    /// </summary>
    let ``Reservoir/key/landuse/value/reservoir`` =
        _prefix "Reservoir/key/landuse/value/reservoir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Residential"></see>
    /// </summary>
    let Residential = _prefix "Residential"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Residential/key/amenity/value/residential"></see>
    /// </summary>
    let ``Residential/key/amenity/value/residential`` =
        _prefix "Residential/key/amenity/value/residential"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialHighway"></see>
    /// </summary>
    let ResidentialHighway = _prefix "ResidentialHighway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialHighway/key/highway/value/residential"></see>
    /// </summary>
    let ``ResidentialHighway/key/highway/value/residential`` =
        _prefix "ResidentialHighway/key/highway/value/residential"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialHome"></see>
    /// </summary>
    let ResidentialHome = _prefix "ResidentialHome"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialHome/key/amenity/value/residential_home"></see>
    /// </summary>
    let ``ResidentialHome/key/amenity/value/residential_home`` =
        _prefix "ResidentialHome/key/amenity/value/residential_home"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialLanduse"></see>
    /// </summary>
    let ResidentialLanduse = _prefix "ResidentialLanduse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ResidentialLanduse/key/landuse/value/residential"></see>
    /// </summary>
    let ``ResidentialLanduse/key/landuse/value/residential`` =
        _prefix "ResidentialLanduse/key/landuse/value/residential"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Resis"></see>
    /// </summary>
    let Resis = _prefix "Resis"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Resis/key/landuse/value/resis"></see>
    /// </summary>
    let ``Resis/key/landuse/value/resis`` = _prefix "Resis/key/landuse/value/resis"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RestArea"></see>
    /// </summary>
    let RestArea = _prefix "RestArea"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RestArea/key/highway/value/rest_area"></see>
    /// </summary>
    let ``RestArea/key/highway/value/rest_area`` =
        _prefix "RestArea/key/highway/value/rest_area"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Restaurant"></see>
    /// </summary>
    let Restaurant = _prefix "Restaurant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Restaurant/key/amenity/value/restaurant"></see>
    /// </summary>
    let ``Restaurant/key/amenity/value/restaurant`` =
        _prefix "Restaurant/key/amenity/value/restaurant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Restaurant%3Bpub"></see>
    /// </summary>
    let ``Restaurant%3Bpub`` = _prefix "Restaurant%3Bpub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Restaurant%3Bpub/key/amenity/value/restaurant%3Bpub"></see>
    /// </summary>
    let ``Restaurant%3Bpub/key/amenity/value/restaurant%3Bpub`` =
        _prefix "Restaurant%3Bpub/key/amenity/value/restaurant%3Bpub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Retail"></see>
    /// </summary>
    let Retail = _prefix "Retail"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Retail/key/amenity/value/retail"></see>
    /// </summary>
    let ``Retail/key/amenity/value/retail`` = _prefix "Retail/key/amenity/value/retail"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetailLanduse"></see>
    /// </summary>
    let RetailLanduse = _prefix "RetailLanduse"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetailLanduse/key/landuse/value/retail"></see>
    /// </summary>
    let ``RetailLanduse/key/landuse/value/retail`` =
        _prefix "RetailLanduse/key/landuse/value/retail"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetainingWall"></see>
    /// </summary>
    let RetainingWall = _prefix "RetainingWall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetainingWall/key/barrier/value/retaining_wall"></see>
    /// </summary>
    let ``RetainingWall/key/barrier/value/retaining_wall`` =
        _prefix "RetainingWall/key/barrier/value/retaining_wall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetirementHome"></see>
    /// </summary>
    let RetirementHome = _prefix "RetirementHome"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RetirementHome/key/amenity/value/retirement_home"></see>
    /// </summary>
    let ``RetirementHome/key/amenity/value/retirement_home`` =
        _prefix "RetirementHome/key/amenity/value/retirement_home"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ridge"></see>
    /// </summary>
    let Ridge = _prefix "Ridge"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ridge/key/natural/value/ridge"></see>
    /// </summary>
    let ``Ridge/key/natural/value/ridge`` = _prefix "Ridge/key/natural/value/ridge"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rig"></see>
    /// </summary>
    let Rig = _prefix "Rig"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rig/key/man_made/value/rig"></see>
    /// </summary>
    let ``Rig/key/man_made/value/rig`` = _prefix "Rig/key/man_made/value/rig"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rigger"></see>
    /// </summary>
    let Rigger = _prefix "Rigger"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rigger/key/craft/value/rigger"></see>
    /// </summary>
    let ``Rigger/key/craft/value/rigger`` = _prefix "Rigger/key/craft/value/rigger"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/River"></see>
    /// </summary>
    let River = _prefix "River"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/River/key/waterway/value/river"></see>
    /// </summary>
    let ``River/key/waterway/value/river`` = _prefix "River/key/waterway/value/river"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Riverbank"></see>
    /// </summary>
    let Riverbank = _prefix "Riverbank"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Riverbank/key/waterway/value/riverbank"></see>
    /// </summary>
    let ``Riverbank/key/waterway/value/riverbank`` =
        _prefix "Riverbank/key/waterway/value/riverbank"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Road"></see>
    /// </summary>
    let Road = _prefix "Road"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Road/key/highway/value/road"></see>
    /// </summary>
    let ``Road/key/highway/value/road`` = _prefix "Road/key/highway/value/road"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RoadRoute"></see>
    /// </summary>
    let RoadRoute = _prefix "RoadRoute"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RoadRoute/key/route/value/road"></see>
    /// </summary>
    let ``RoadRoute/key/route/value/road`` = _prefix "RoadRoute/key/route/value/road"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rocks"></see>
    /// </summary>
    let Rocks = _prefix "Rocks"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Rocks/key/natural/value/rocks"></see>
    /// </summary>
    let ``Rocks/key/natural/value/rocks`` = _prefix "Rocks/key/natural/value/rocks"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Roofer"></see>
    /// </summary>
    let Roofer = _prefix "Roofer"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Roofer/key/craft/value/roofer"></see>
    /// </summary>
    let ``Roofer/key/craft/value/roofer`` = _prefix "Roofer/key/craft/value/roofer"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Roundabout"></see>
    /// </summary>
    let Roundabout = _prefix "Roundabout"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Roundabout/key/junction/value/roundabout"></see>
    /// </summary>
    let ``Roundabout/key/junction/value/roundabout`` =
        _prefix "Roundabout/key/junction/value/roundabout"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Route"></see>
    /// </summary>
    let Route = _prefix "Route"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Route/key/type/value/route"></see>
    /// </summary>
    let ``Route/key/type/value/route`` = _prefix "Route/key/type/value/route"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ruins"></see>
    /// </summary>
    let Ruins = _prefix "Ruins"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ruins/key/historic/value/ruins"></see>
    /// </summary>
    let ``Ruins/key/historic/value/ruins`` = _prefix "Ruins/key/historic/value/ruins"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RumbleStrip"></see>
    /// </summary>
    let RumbleStrip = _prefix "RumbleStrip"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RumbleStrip/key/traffic_calming/value/rumble_strip"></see>
    /// </summary>
    let ``RumbleStrip/key/traffic_calming/value/rumble_strip`` =
        _prefix "RumbleStrip/key/traffic_calming/value/rumble_strip"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RuneStone"></see>
    /// </summary>
    let RuneStone = _prefix "RuneStone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/RuneStone/key/historic/value/rune_stone%20"></see>
    /// </summary>
    let ``RuneStone/key/historic/value/rune_stone%20`` =
        _prefix "RuneStone/key/historic/value/rune_stone%20"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Runway"></see>
    /// </summary>
    let Runway = _prefix "Runway"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Runway/key/aeroway/value/runway"></see>
    /// </summary>
    let ``Runway/key/aeroway/value/runway`` = _prefix "Runway/key/aeroway/value/runway"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sa"></see>
    /// </summary>
    let Sa = _prefix "Sa"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sa/key/natural/value/sa"></see>
    /// </summary>
    let ``Sa/key/natural/value/sa`` = _prefix "Sa/key/natural/value/sa"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Saddler"></see>
    /// </summary>
    let Saddler = _prefix "Saddler"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Saddler/key/craft/value/saddler"></see>
    /// </summary>
    let ``Saddler/key/craft/value/saddler`` = _prefix "Saddler/key/craft/value/saddler"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SailingClub"></see>
    /// </summary>
    let SailingClub = _prefix "SailingClub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SailingClub/key/leisure/value/sailing_club"></see>
    /// </summary>
    let ``SailingClub/key/leisure/value/sailing_club`` =
        _prefix "SailingClub/key/leisure/value/sailing_club"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sailmaker"></see>
    /// </summary>
    let Sailmaker = _prefix "Sailmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sailmaker/key/craft/value/sailmaker"></see>
    /// </summary>
    let ``Sailmaker/key/craft/value/sailmaker`` =
        _prefix "Sailmaker/key/craft/value/sailmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SaintsCross"></see>
    /// </summary>
    let SaintsCross = _prefix "SaintsCross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SaintsCross/key/historic/value/saints_cross"></see>
    /// </summary>
    let ``SaintsCross/key/historic/value/saints_cross`` =
        _prefix "SaintsCross/key/historic/value/saints_cross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SallyPort"></see>
    /// </summary>
    let SallyPort = _prefix "SallyPort"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SallyPort/key/barrier/value/sally_port"></see>
    /// </summary>
    let ``SallyPort/key/barrier/value/sally_port`` =
        _prefix "SallyPort/key/barrier/value/sally_port"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Salon"></see>
    /// </summary>
    let Salon = _prefix "Salon"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Salon/key/shop/value/salon"></see>
    /// </summary>
    let ``Salon/key/shop/value/salon`` = _prefix "Salon/key/shop/value/salon"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Salon/key/amenity/value/salon"></see>
    /// </summary>
    let ``Salon/key/amenity/value/salon`` = _prefix "Salon/key/amenity/value/salon"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SaltPond"></see>
    /// </summary>
    let SaltPond = _prefix "SaltPond"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SaltPond/key/landuse/value/salt_pond"></see>
    /// </summary>
    let ``SaltPond/key/landuse/value/salt_pond`` =
        _prefix "SaltPond/key/landuse/value/salt_pond"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sand"></see>
    /// </summary>
    let Sand = _prefix "Sand"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sand/key/natural/value/sand"></see>
    /// </summary>
    let ``Sand/key/natural/value/sand`` = _prefix "Sand/key/natural/value/sand"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sauna"></see>
    /// </summary>
    let Sauna = _prefix "Sauna"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sauna/key/leisure/value/sauna"></see>
    /// </summary>
    let ``Sauna/key/leisure/value/sauna`` = _prefix "Sauna/key/leisure/value/sauna"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sauna/key/amenity/value/sauna"></see>
    /// </summary>
    let ``Sauna/key/amenity/value/sauna`` = _prefix "Sauna/key/amenity/value/sauna"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sawmill"></see>
    /// </summary>
    let Sawmill = _prefix "Sawmill"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sawmill/key/craft/value/sawmill"></see>
    /// </summary>
    let ``Sawmill/key/craft/value/sawmill`` = _prefix "Sawmill/key/craft/value/sawmill"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scaffolder"></see>
    /// </summary>
    let Scaffolder = _prefix "Scaffolder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scaffolder/key/craft/value/scaffolder"></see>
    /// </summary>
    let ``Scaffolder/key/craft/value/scaffolder`` =
        _prefix "Scaffolder/key/craft/value/scaffolder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/School"></see>
    /// </summary>
    let School = _prefix "School"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/School/key/amenity/value/school"></see>
    /// </summary>
    let ``School/key/amenity/value/school`` = _prefix "School/key/amenity/value/school"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScoutHall"></see>
    /// </summary>
    let ScoutHall = _prefix "ScoutHall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScoutHall/key/amenity/value/scout_hall"></see>
    /// </summary>
    let ``ScoutHall/key/amenity/value/scout_hall`` =
        _prefix "ScoutHall/key/amenity/value/scout_hall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScoutHut"></see>
    /// </summary>
    let ScoutHut = _prefix "ScoutHut"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScoutHut/key/amenity/value/scout_hut"></see>
    /// </summary>
    let ``ScoutHut/key/amenity/value/scout_hut`` =
        _prefix "ScoutHut/key/amenity/value/scout_hut"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scree"></see>
    /// </summary>
    let Scree = _prefix "Scree"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scree/key/natural/value/scree"></see>
    /// </summary>
    let ``Scree/key/natural/value/scree`` = _prefix "Scree/key/natural/value/scree"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scrub"></see>
    /// </summary>
    let Scrub = _prefix "Scrub"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Scrub/key/natural/value/scrub"></see>
    /// </summary>
    let ``Scrub/key/natural/value/scrub`` = _prefix "Scrub/key/natural/value/scrub"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScubaDivingShop"></see>
    /// </summary>
    let ScubaDivingShop = _prefix "ScubaDivingShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ScubaDivingShop/key/shop/value/scuba_diving"></see>
    /// </summary>
    let ``ScubaDivingShop/key/shop/value/scuba_diving`` =
        _prefix "ScubaDivingShop/key/shop/value/scuba_diving"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sculptor"></see>
    /// </summary>
    let Sculptor = _prefix "Sculptor"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sculptor/key/craft/value/sculptor"></see>
    /// </summary>
    let ``Sculptor/key/craft/value/sculptor`` =
        _prefix "Sculptor/key/craft/value/sculptor"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sea"></see>
    /// </summary>
    let Sea = _prefix "Sea"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sea/key/natural/value/sea"></see>
    /// </summary>
    let ``Sea/key/natural/value/sea`` = _prefix "Sea/key/natural/value/sea"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Seat"></see>
    /// </summary>
    let Seat = _prefix "Seat"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Seat/key/amenity/value/seat"></see>
    /// </summary>
    let ``Seat/key/amenity/value/seat`` = _prefix "Seat/key/amenity/value/seat"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Seating%2Cornamental"></see>
    /// </summary>
    let ``Seating%2Cornamental`` = _prefix "Seating%2Cornamental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Seating%2Cornamental/key/amenity/value/seating%2Cornamental"></see>
    /// </summary>
    let ``Seating%2Cornamental/key/amenity/value/seating%2Cornamental`` =
        _prefix "Seating%2Cornamental/key/amenity/value/seating%2Cornamental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SecondHand"></see>
    /// </summary>
    let SecondHand = _prefix "SecondHand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SecondHand/key/shop/value/second_hand"></see>
    /// </summary>
    let ``SecondHand/key/shop/value/second_hand`` =
        _prefix "SecondHand/key/shop/value/second_hand"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SecundaryHighway"></see>
    /// </summary>
    let SecundaryHighway = _prefix "SecundaryHighway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SecundaryHighway/key/highway/value/secundary"></see>
    /// </summary>
    let ``SecundaryHighway/key/highway/value/secundary`` =
        _prefix "SecundaryHighway/key/highway/value/secundary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sento"></see>
    /// </summary>
    let Sento = _prefix "Sento"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sento/key/amenity/value/sento"></see>
    /// </summary>
    let ``Sento/key/amenity/value/sento`` = _prefix "Sento/key/amenity/value/sento"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Service"></see>
    /// </summary>
    let Service = _prefix "Service"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Service/key/amenity/value/service"></see>
    /// </summary>
    let ``Service/key/amenity/value/service`` =
        _prefix "Service/key/amenity/value/service"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServiceAreaInterface"></see>
    /// </summary>
    let ServiceAreaInterface = _prefix "ServiceAreaInterface"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServiceAreaInterface/key/man_made/value/service_area_interface"></see>
    /// </summary>
    let ``ServiceAreaInterface/key/man_made/value/service_area_interface`` =
        _prefix "ServiceAreaInterface/key/man_made/value/service_area_interface"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServiceStation"></see>
    /// </summary>
    let ServiceStation = _prefix "ServiceStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServiceStation/key/highway/value/services"></see>
    /// </summary>
    let ``ServiceStation/key/highway/value/services`` =
        _prefix "ServiceStation/key/highway/value/services"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Services"></see>
    /// </summary>
    let Services = _prefix "Services"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Services/key/amenity/value/services"></see>
    /// </summary>
    let ``Services/key/amenity/value/services`` =
        _prefix "Services/key/amenity/value/services"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServingAreaInterface"></see>
    /// </summary>
    let ServingAreaInterface = _prefix "ServingAreaInterface"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ServingAreaInterface/key/man_made/value/serving_area_interface"></see>
    /// </summary>
    let ``ServingAreaInterface/key/man_made/value/serving_area_interface`` =
        _prefix "ServingAreaInterface/key/man_made/value/serving_area_interface"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SesStation"></see>
    /// </summary>
    let SesStation = _prefix "SesStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SesStation/key/emergency/value/ses_station"></see>
    /// </summary>
    let ``SesStation/key/emergency/value/ses_station`` =
        _prefix "SesStation/key/emergency/value/ses_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shed"></see>
    /// </summary>
    let Shed = _prefix "Shed"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shed/key/building/value/shed"></see>
    /// </summary>
    let ``Shed/key/building/value/shed`` = _prefix "Shed/key/building/value/shed"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sheepfold"></see>
    /// </summary>
    let Sheepfold = _prefix "Sheepfold"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sheepfold/key/man_made/value/sheepfold"></see>
    /// </summary>
    let ``Sheepfold/key/man_made/value/sheepfold`` =
        _prefix "Sheepfold/key/man_made/value/sheepfold"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shelter"></see>
    /// </summary>
    let Shelter = _prefix "Shelter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shelter/key/amenity/value/shelter"></see>
    /// </summary>
    let ``Shelter/key/amenity/value/shelter`` =
        _prefix "Shelter/key/amenity/value/shelter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShelteredHousing"></see>
    /// </summary>
    let ShelteredHousing = _prefix "ShelteredHousing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShelteredHousing/key/amenity/value/sheltered_housing"></see>
    /// </summary>
    let ``ShelteredHousing/key/amenity/value/sheltered_housing`` =
        _prefix "ShelteredHousing/key/amenity/value/sheltered_housing"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shipping"></see>
    /// </summary>
    let Shipping = _prefix "Shipping"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shipping/key/shop/value/shipping"></see>
    /// </summary>
    let ``Shipping/key/shop/value/shipping`` =
        _prefix "Shipping/key/shop/value/shipping"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoal"></see>
    /// </summary>
    let Shoal = _prefix "Shoal"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoal/key/natural/value/shoal"></see>
    /// </summary>
    let ``Shoal/key/natural/value/shoal`` = _prefix "Shoal/key/natural/value/shoal"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoeRepair"></see>
    /// </summary>
    let ShoeRepair = _prefix "ShoeRepair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoeRepair/key/shop/value/shoe_repair"></see>
    /// </summary>
    let ``ShoeRepair/key/shop/value/shoe_repair`` =
        _prefix "ShoeRepair/key/shop/value/shoe_repair"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoemaker"></see>
    /// </summary>
    let Shoemaker = _prefix "Shoemaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoemaker/key/shop/value/shoemaker"></see>
    /// </summary>
    let ``Shoemaker/key/shop/value/shoemaker`` =
        _prefix "Shoemaker/key/shop/value/shoemaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoemaker/key/craft/value/shoemaker"></see>
    /// </summary>
    let ``Shoemaker/key/craft/value/shoemaker`` =
        _prefix "Shoemaker/key/craft/value/shoemaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoes"></see>
    /// </summary>
    let Shoes = _prefix "Shoes"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shoes/key/shop/value/shoes"></see>
    /// </summary>
    let ``Shoes/key/shop/value/shoes`` = _prefix "Shoes/key/shop/value/shoes"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shop/key/amenity/value/shop"></see>
    /// </summary>
    let ``Shop/key/amenity/value/shop`` = _prefix "Shop/key/amenity/value/shop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shop/key/shop/value/yes"></see>
    /// </summary>
    let ``Shop/key/shop/value/yes`` = _prefix "Shop/key/shop/value/yes"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shop/key/shop/value/shop"></see>
    /// </summary>
    let ``Shop/key/shop/value/shop`` = _prefix "Shop/key/shop/value/shop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShopFIXME"></see>
    /// </summary>
    let ShopFIXME = _prefix "ShopFIXME"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShopFIXME/key/shop/value/FIXME"></see>
    /// </summary>
    let ``ShopFIXME/key/shop/value/FIXME`` = _prefix "ShopFIXME/key/shop/value/FIXME"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShopFixme"></see>
    /// </summary>
    let ShopFixme = _prefix "ShopFixme"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShopFixme/key/shop/value/fixme"></see>
    /// </summary>
    let ``ShopFixme/key/shop/value/fixme`` = _prefix "ShopFixme/key/shop/value/fixme"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shopping"></see>
    /// </summary>
    let Shopping = _prefix "Shopping"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shopping/key/amenity/value/shopping"></see>
    /// </summary>
    let ``Shopping/key/amenity/value/shopping`` =
        _prefix "Shopping/key/amenity/value/shopping"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoppingCenter"></see>
    /// </summary>
    let ShoppingCenter = _prefix "ShoppingCenter"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoppingCenter/key/shop/value/shopping_center"></see>
    /// </summary>
    let ``ShoppingCenter/key/shop/value/shopping_center`` =
        _prefix "ShoppingCenter/key/shop/value/shopping_center"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoppingCentre"></see>
    /// </summary>
    let ShoppingCentre = _prefix "ShoppingCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ShoppingCentre/key/shop/value/shopping_centre"></see>
    /// </summary>
    let ``ShoppingCentre/key/shop/value/shopping_centre`` =
        _prefix "ShoppingCentre/key/shop/value/shopping_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shops"></see>
    /// </summary>
    let Shops = _prefix "Shops"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shops/key/amenity/value/shops"></see>
    /// </summary>
    let ``Shops/key/amenity/value/shops`` = _prefix "Shops/key/amenity/value/shops"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shower"></see>
    /// </summary>
    let Shower = _prefix "Shower"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Shower/key/amenity/value/shower"></see>
    /// </summary>
    let ``Shower/key/amenity/value/shower`` = _prefix "Shower/key/amenity/value/shower"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Showers"></see>
    /// </summary>
    let Showers = _prefix "Showers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Showers/key/amenity/value/showers"></see>
    /// </summary>
    let ``Showers/key/amenity/value/showers`` =
        _prefix "Showers/key/amenity/value/showers"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Signal"></see>
    /// </summary>
    let Signal = _prefix "Signal"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Signal/key/railway/value/signal"></see>
    /// </summary>
    let ``Signal/key/railway/value/signal`` = _prefix "Signal/key/railway/value/signal"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Signpost"></see>
    /// </summary>
    let Signpost = _prefix "Signpost"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Signpost/key/amenity/value/signpost"></see>
    /// </summary>
    let ``Signpost/key/amenity/value/signpost`` =
        _prefix "Signpost/key/amenity/value/signpost"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Silo"></see>
    /// </summary>
    let Silo = _prefix "Silo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Silo/key/man_made/value/silo"></see>
    /// </summary>
    let ``Silo/key/man_made/value/silo`` = _prefix "Silo/key/man_made/value/silo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkatePark"></see>
    /// </summary>
    let SkatePark = _prefix "SkatePark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkatePark/key/leisure/value/skate_park"></see>
    /// </summary>
    let ``SkatePark/key/leisure/value/skate_park`` =
        _prefix "SkatePark/key/leisure/value/skate_park"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiRental"></see>
    /// </summary>
    let SkiRental = _prefix "SkiRental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiRental/key/amenity/value/ski_rental"></see>
    /// </summary>
    let ``SkiRental/key/amenity/value/ski_rental`` =
        _prefix "SkiRental/key/amenity/value/ski_rental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiRoute"></see>
    /// </summary>
    let SkiRoute = _prefix "SkiRoute"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiRoute/key/route/value/ski"></see>
    /// </summary>
    let ``SkiRoute/key/route/value/ski`` = _prefix "SkiRoute/key/route/value/ski"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiSchool"></see>
    /// </summary>
    let SkiSchool = _prefix "SkiSchool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SkiSchool/key/amenity/value/ski_school"></see>
    /// </summary>
    let ``SkiSchool/key/amenity/value/ski_school`` =
        _prefix "SkiSchool/key/amenity/value/ski_school"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Slipway"></see>
    /// </summary>
    let Slipway = _prefix "Slipway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Slipway/key/leisure/value/slipway"></see>
    /// </summary>
    let ``Slipway/key/leisure/value/slipway`` =
        _prefix "Slipway/key/leisure/value/slipway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sluice"></see>
    /// </summary>
    let Sluice = _prefix "Sluice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sluice/key/waterway/value/sluice"></see>
    /// </summary>
    let ``Sluice/key/waterway/value/sluice`` =
        _prefix "Sluice/key/waterway/value/sluice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Snacks"></see>
    /// </summary>
    let Snacks = _prefix "Snacks"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Snacks/key/shop/value/snacks"></see>
    /// </summary>
    let ``Snacks/key/shop/value/snacks`` = _prefix "Snacks/key/shop/value/snacks"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SnowPark"></see>
    /// </summary>
    let SnowPark = _prefix "SnowPark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SnowPark/key/amenity/value/snow_park"></see>
    /// </summary>
    let ``SnowPark/key/amenity/value/snow_park`` =
        _prefix "SnowPark/key/amenity/value/snow_park"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialCentre"></see>
    /// </summary>
    let SocialCentre = _prefix "SocialCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialCentre/key/amenity/value/social_centre"></see>
    /// </summary>
    let ``SocialCentre/key/amenity/value/social_centre`` =
        _prefix "SocialCentre/key/amenity/value/social_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialClub"></see>
    /// </summary>
    let SocialClub = _prefix "SocialClub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialClub/key/amenity/value/social_club"></see>
    /// </summary>
    let ``SocialClub/key/amenity/value/social_club`` =
        _prefix "SocialClub/key/amenity/value/social_club"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialClub/key/leisure/value/social_club"></see>
    /// </summary>
    let ``SocialClub/key/leisure/value/social_club`` =
        _prefix "SocialClub/key/leisure/value/social_club"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialFacility"></see>
    /// </summary>
    let SocialFacility = _prefix "SocialFacility"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialFacility/key/amenity/value/social_facility"></see>
    /// </summary>
    let ``SocialFacility/key/amenity/value/social_facility`` =
        _prefix "SocialFacility/key/amenity/value/social_facility"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialServices"></see>
    /// </summary>
    let SocialServices = _prefix "SocialServices"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SocialServices/key/amenity/value/social_services"></see>
    /// </summary>
    let ``SocialServices/key/amenity/value/social_services`` =
        _prefix "SocialServices/key/amenity/value/social_services"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Solarium"></see>
    /// </summary>
    let Solarium = _prefix "Solarium"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Solarium/key/amenity/value/solarium"></see>
    /// </summary>
    let ``Solarium/key/amenity/value/solarium`` =
        _prefix "Solarium/key/amenity/value/solarium"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Solarium/key/shop/value/solarium"></see>
    /// </summary>
    let ``Solarium/key/shop/value/solarium`` =
        _prefix "Solarium/key/shop/value/solarium"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Souvenir"></see>
    /// </summary>
    let Souvenir = _prefix "Souvenir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Souvenir/key/shop/value/souvenir"></see>
    /// </summary>
    let ``Souvenir/key/shop/value/souvenir`` =
        _prefix "Souvenir/key/shop/value/souvenir"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Souvenirs"></see>
    /// </summary>
    let Souvenirs = _prefix "Souvenirs"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Souvenirs/key/shop/value/souvenirs"></see>
    /// </summary>
    let ``Souvenirs/key/shop/value/souvenirs`` =
        _prefix "Souvenirs/key/shop/value/souvenirs"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Spa"></see>
    /// </summary>
    let Spa = _prefix "Spa"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Spa/key/amenity/value/spa"></see>
    /// </summary>
    let ``Spa/key/amenity/value/spa`` = _prefix "Spa/key/amenity/value/spa"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedCamera"></see>
    /// </summary>
    let SpeedCamera = _prefix "SpeedCamera"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedCamera/key/highway/value/speed_camera"></see>
    /// </summary>
    let ``SpeedCamera/key/highway/value/speed_camera`` =
        _prefix "SpeedCamera/key/highway/value/speed_camera"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedEnforcement"></see>
    /// </summary>
    let SpeedEnforcement = _prefix "SpeedEnforcement"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedEnforcement/key/amenity/value/speed_enforcement"></see>
    /// </summary>
    let ``SpeedEnforcement/key/amenity/value/speed_enforcement`` =
        _prefix "SpeedEnforcement/key/amenity/value/speed_enforcement"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedTrap"></see>
    /// </summary>
    let SpeedTrap = _prefix "SpeedTrap"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SpeedTrap/key/amenity/value/speed_trap"></see>
    /// </summary>
    let ``SpeedTrap/key/amenity/value/speed_trap`` =
        _prefix "SpeedTrap/key/amenity/value/speed_trap"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sport"></see>
    /// </summary>
    let Sport = _prefix "Sport"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sport/key/leisure/value/sport"></see>
    /// </summary>
    let ``Sport/key/leisure/value/sport`` = _prefix "Sport/key/leisure/value/sport"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sport/key/amenity/value/sport"></see>
    /// </summary>
    let ``Sport/key/amenity/value/sport`` = _prefix "Sport/key/amenity/value/sport"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportShop"></see>
    /// </summary>
    let SportShop = _prefix "SportShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportShop/key/shop/value/sport"></see>
    /// </summary>
    let ``SportShop/key/shop/value/sport`` = _prefix "SportShop/key/shop/value/sport"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportThing"></see>
    /// </summary>
    let SportThing = _prefix "SportThing"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sports"></see>
    /// </summary>
    let Sports = _prefix "Sports"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sports/key/shop/value/sports"></see>
    /// </summary>
    let ``Sports/key/shop/value/sports`` = _prefix "Sports/key/shop/value/sports"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportsCentre"></see>
    /// </summary>
    let SportsCentre = _prefix "SportsCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportsCentre/key/leisure/value/sports_centre"></see>
    /// </summary>
    let ``SportsCentre/key/leisure/value/sports_centre`` =
        _prefix "SportsCentre/key/leisure/value/sports_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SportsCentre/key/amenity/value/sports_centre"></see>
    /// </summary>
    let ``SportsCentre/key/amenity/value/sports_centre`` =
        _prefix "SportsCentre/key/amenity/value/sports_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Spring"></see>
    /// </summary>
    let Spring = _prefix "Spring"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Spring/key/natural/value/spring"></see>
    /// </summary>
    let ``Spring/key/natural/value/spring`` = _prefix "Spring/key/natural/value/spring"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stadium"></see>
    /// </summary>
    let Stadium = _prefix "Stadium"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stadium/key/leisure/value/stadium"></see>
    /// </summary>
    let ``Stadium/key/leisure/value/stadium`` =
        _prefix "Stadium/key/leisure/value/stadium"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StandBuilder"></see>
    /// </summary>
    let StandBuilder = _prefix "StandBuilder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StandBuilder/key/craft/value/stand_builder"></see>
    /// </summary>
    let ``StandBuilder/key/craft/value/stand_builder`` =
        _prefix "StandBuilder/key/craft/value/stand_builder"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/State/key/place/value/state"></see>
    /// </summary>
    let ``State/key/place/value/state`` = _prefix "State/key/place/value/state"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Station"></see>
    /// </summary>
    let Station = _prefix "Station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Station/key/public_transport/value/station"></see>
    /// </summary>
    let ``Station/key/public_transport/value/station`` =
        _prefix "Station/key/public_transport/value/station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StationEntrance"></see>
    /// </summary>
    let StationEntrance = _prefix "StationEntrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StationEntrance/key/railway/value/station_entrance"></see>
    /// </summary>
    let ``StationEntrance/key/railway/value/station_entrance`` =
        _prefix "StationEntrance/key/railway/value/station_entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stationary"></see>
    /// </summary>
    let Stationary = _prefix "Stationary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stationary/key/shop/value/stationary"></see>
    /// </summary>
    let ``Stationary/key/shop/value/stationary`` =
        _prefix "Stationary/key/shop/value/stationary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stationery"></see>
    /// </summary>
    let Stationery = _prefix "Stationery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stationery/key/shop/value/stationery"></see>
    /// </summary>
    let ``Stationery/key/shop/value/stationery`` =
        _prefix "Stationery/key/shop/value/stationery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Statue"></see>
    /// </summary>
    let Statue = _prefix "Statue"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Statue/key/amenity/value/statue"></see>
    /// </summary>
    let ``Statue/key/amenity/value/statue`` = _prefix "Statue/key/amenity/value/statue"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Steps"></see>
    /// </summary>
    let Steps = _prefix "Steps"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Steps/key/highway/value/steps"></see>
    /// </summary>
    let ``Steps/key/highway/value/steps`` = _prefix "Steps/key/highway/value/steps"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stile"></see>
    /// </summary>
    let Stile = _prefix "Stile"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stile/key/barrier/value/stile"></see>
    /// </summary>
    let ``Stile/key/barrier/value/stile`` = _prefix "Stile/key/barrier/value/stile"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stone"></see>
    /// </summary>
    let Stone = _prefix "Stone"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stone/key/natural/value/stone"></see>
    /// </summary>
    let ``Stone/key/natural/value/stone`` = _prefix "Stone/key/natural/value/stone"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StoneCircle"></see>
    /// </summary>
    let StoneCircle = _prefix "StoneCircle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StoneCircle/key/historic/value/stone_circle"></see>
    /// </summary>
    let ``StoneCircle/key/historic/value/stone_circle`` =
        _prefix "StoneCircle/key/historic/value/stone_circle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stonemason"></see>
    /// </summary>
    let Stonemason = _prefix "Stonemason"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stonemason/key/craft/value/stonemason"></see>
    /// </summary>
    let ``Stonemason/key/craft/value/stonemason`` =
        _prefix "Stonemason/key/craft/value/stonemason"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StopPosition"></see>
    /// </summary>
    let StopPosition = _prefix "StopPosition"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StopPosition/key/public_transport/value/stop_position"></see>
    /// </summary>
    let ``StopPosition/key/public_transport/value/stop_position`` =
        _prefix "StopPosition/key/public_transport/value/stop_position"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StopSign"></see>
    /// </summary>
    let StopSign = _prefix "StopSign"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StopSign/key/highway/value/stop"></see>
    /// </summary>
    let ``StopSign/key/highway/value/stop`` = _prefix "StopSign/key/highway/value/stop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Storage"></see>
    /// </summary>
    let Storage = _prefix "Storage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Storage/key/amenity/value/storage"></see>
    /// </summary>
    let ``Storage/key/amenity/value/storage`` =
        _prefix "Storage/key/amenity/value/storage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StorageTank"></see>
    /// </summary>
    let StorageTank = _prefix "StorageTank"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StorageTank/key/man_made/value/storage_tank"></see>
    /// </summary>
    let ``StorageTank/key/man_made/value/storage_tank`` =
        _prefix "StorageTank/key/man_made/value/storage_tank"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Strait"></see>
    /// </summary>
    let Strait = _prefix "Strait"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Strait/key/natural/value/strait"></see>
    /// </summary>
    let ``Strait/key/natural/value/strait`` = _prefix "Strait/key/natural/value/strait"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stream"></see>
    /// </summary>
    let Stream = _prefix "Stream"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stream/key/waterway/value/stream"></see>
    /// </summary>
    let ``Stream/key/waterway/value/stream`` =
        _prefix "Stream/key/waterway/value/stream"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLamp"></see>
    /// </summary>
    let StreetLamp = _prefix "StreetLamp"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLamp/key/highway/value/street_lamp"></see>
    /// </summary>
    let ``StreetLamp/key/highway/value/street_lamp`` =
        _prefix "StreetLamp/key/highway/value/street_lamp"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLamp/key/amenity/value/street_lamp"></see>
    /// </summary>
    let ``StreetLamp/key/amenity/value/street_lamp`` =
        _prefix "StreetLamp/key/amenity/value/street_lamp"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLight"></see>
    /// </summary>
    let StreetLight = _prefix "StreetLight"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/StreetLight/key/amenity/value/street_light"></see>
    /// </summary>
    let ``StreetLight/key/amenity/value/street_light`` =
        _prefix "StreetLight/key/amenity/value/street_light"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stripclub"></see>
    /// </summary>
    let Stripclub = _prefix "Stripclub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Stripclub/key/amenity/value/stripclub"></see>
    /// </summary>
    let ``Stripclub/key/amenity/value/stripclub`` =
        _prefix "Stripclub/key/amenity/value/stripclub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Studio"></see>
    /// </summary>
    let Studio = _prefix "Studio"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Studio/key/amenity/value/studio"></see>
    /// </summary>
    let ``Studio/key/amenity/value/studio`` = _prefix "Studio/key/amenity/value/studio"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Subdivision"></see>
    /// </summary>
    let Subdivision = _prefix "Subdivision"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Subdivision/key/place/value/subdivision"></see>
    /// </summary>
    let ``Subdivision/key/place/value/subdivision`` =
        _prefix "Subdivision/key/place/value/subdivision"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Suburb"></see>
    /// </summary>
    let Suburb = _prefix "Suburb"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Suburb/key/place/value/suburb"></see>
    /// </summary>
    let ``Suburb/key/place/value/suburb`` = _prefix "Suburb/key/place/value/suburb"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Subway"></see>
    /// </summary>
    let Subway = _prefix "Subway"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Subway/key/railway/value/subway"></see>
    /// </summary>
    let ``Subway/key/railway/value/subway`` = _prefix "Subway/key/railway/value/subway"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SubwayEntrance"></see>
    /// </summary>
    let SubwayEntrance = _prefix "SubwayEntrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SubwayEntrance/key/railway/value/subway_entrance"></see>
    /// </summary>
    let ``SubwayEntrance/key/railway/value/subway_entrance`` =
        _prefix "SubwayEntrance/key/railway/value/subway_entrance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SummitCross"></see>
    /// </summary>
    let SummitCross = _prefix "SummitCross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SummitCross/key/man_made/value/summit_cross"></see>
    /// </summary>
    let ``SummitCross/key/man_made/value/summit_cross`` =
        _prefix "SummitCross/key/man_made/value/summit_cross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SunProtection"></see>
    /// </summary>
    let SunProtection = _prefix "SunProtection"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SunProtection/key/craft/value/sun_protection"></see>
    /// </summary>
    let ``SunProtection/key/craft/value/sun_protection`` =
        _prefix "SunProtection/key/craft/value/sun_protection"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Supermarket"></see>
    /// </summary>
    let Supermarket = _prefix "Supermarket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Supermarket/key/shop/value/supermarket"></see>
    /// </summary>
    let ``Supermarket/key/shop/value/supermarket`` =
        _prefix "Supermarket/key/shop/value/supermarket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Supermarket/key/amenity/value/supermarket"></see>
    /// </summary>
    let ``Supermarket/key/amenity/value/supermarket`` =
        _prefix "Supermarket/key/amenity/value/supermarket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Supermarket/key/shop/value/Supermarket"></see>
    /// </summary>
    let ``Supermarket/key/shop/value/Supermarket`` =
        _prefix "Supermarket/key/shop/value/Supermarket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Surgery"></see>
    /// </summary>
    let Surgery = _prefix "Surgery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Surgery/key/amenity/value/surgery"></see>
    /// </summary>
    let ``Surgery/key/amenity/value/surgery`` =
        _prefix "Surgery/key/amenity/value/surgery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Surveillance"></see>
    /// </summary>
    let Surveillance = _prefix "Surveillance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Surveillance/key/man_made/value/surveillance"></see>
    /// </summary>
    let ``Surveillance/key/man_made/value/surveillance`` =
        _prefix "Surveillance/key/man_made/value/surveillance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Survey"></see>
    /// </summary>
    let Survey = _prefix "Survey"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Survey/key/amenity/value/survey"></see>
    /// </summary>
    let ``Survey/key/amenity/value/survey`` = _prefix "Survey/key/amenity/value/survey"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SurveyPoint"></see>
    /// </summary>
    let SurveyPoint = _prefix "SurveyPoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SurveyPoint/key/man_made/value/survey_point"></see>
    /// </summary>
    let ``SurveyPoint/key/man_made/value/survey_point`` =
        _prefix "SurveyPoint/key/man_made/value/survey_point"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sweep"></see>
    /// </summary>
    let Sweep = _prefix "Sweep"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sweep/key/craft/value/sweep"></see>
    /// </summary>
    let ``Sweep/key/craft/value/sweep`` = _prefix "Sweep/key/craft/value/sweep"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sweets"></see>
    /// </summary>
    let Sweets = _prefix "Sweets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Sweets/key/shop/value/sweets"></see>
    /// </summary>
    let ``Sweets/key/shop/value/sweets`` = _prefix "Sweets/key/shop/value/sweets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SwimmingPool"></see>
    /// </summary>
    let SwimmingPool = _prefix "SwimmingPool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SwimmingPool/key/amenity/value/swimming_pool"></see>
    /// </summary>
    let ``SwimmingPool/key/amenity/value/swimming_pool`` =
        _prefix "SwimmingPool/key/amenity/value/swimming_pool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/SwimmingPool/key/leisure/value/swimming_pool"></see>
    /// </summary>
    let ``SwimmingPool/key/leisure/value/swimming_pool`` =
        _prefix "SwimmingPool/key/leisure/value/swimming_pool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Table"></see>
    /// </summary>
    let Table = _prefix "Table"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Table/key/amenity/value/table"></see>
    /// </summary>
    let ``Table/key/amenity/value/table`` = _prefix "Table/key/amenity/value/table"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TableBump"></see>
    /// </summary>
    let TableBump = _prefix "TableBump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TableBump/key/traffic_calming/value/table"></see>
    /// </summary>
    let ``TableBump/key/traffic_calming/value/table`` =
        _prefix "TableBump/key/traffic_calming/value/table"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tailor"></see>
    /// </summary>
    let Tailor = _prefix "Tailor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tailor/key/shop/value/tailor"></see>
    /// </summary>
    let ``Tailor/key/shop/value/tailor`` = _prefix "Tailor/key/shop/value/tailor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tailor/key/craft/value/tailor"></see>
    /// </summary>
    let ``Tailor/key/craft/value/tailor`` = _prefix "Tailor/key/craft/value/tailor"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TakeAway"></see>
    /// </summary>
    let TakeAway = _prefix "TakeAway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TakeAway/key/amenity/value/take_away"></see>
    /// </summary>
    let ``TakeAway/key/amenity/value/take_away`` =
        _prefix "TakeAway/key/amenity/value/take_away"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TakeAway/key/shop/value/take_away"></see>
    /// </summary>
    let ``TakeAway/key/shop/value/take_away`` =
        _prefix "TakeAway/key/shop/value/take_away"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tanning"></see>
    /// </summary>
    let Tanning = _prefix "Tanning"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tanning/key/shop/value/tanning"></see>
    /// </summary>
    let ``Tanning/key/shop/value/tanning`` = _prefix "Tanning/key/shop/value/tanning"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tattoo"></see>
    /// </summary>
    let Tattoo = _prefix "Tattoo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tattoo/key/shop/value/tattoo"></see>
    /// </summary>
    let ``Tattoo/key/shop/value/tattoo`` = _prefix "Tattoo/key/shop/value/tattoo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tax"></see>
    /// </summary>
    let Tax = _prefix "Tax"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tax/key/shop/value/tax"></see>
    /// </summary>
    let ``Tax/key/shop/value/tax`` = _prefix "Tax/key/shop/value/tax"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Taxi"></see>
    /// </summary>
    let Taxi = _prefix "Taxi"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Taxi/key/amenity/value/taxi"></see>
    /// </summary>
    let ``Taxi/key/amenity/value/taxi`` = _prefix "Taxi/key/amenity/value/taxi"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tea"></see>
    /// </summary>
    let Tea = _prefix "Tea"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tea/key/shop/value/tea"></see>
    /// </summary>
    let ``Tea/key/shop/value/tea`` = _prefix "Tea/key/shop/value/tea"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Technology"></see>
    /// </summary>
    let Technology = _prefix "Technology"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Technology/key/shop/value/technology"></see>
    /// </summary>
    let ``Technology/key/shop/value/technology`` =
        _prefix "Technology/key/shop/value/technology"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telecom"></see>
    /// </summary>
    let Telecom = _prefix "Telecom"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telecom/key/shop/value/telecom"></see>
    /// </summary>
    let ``Telecom/key/shop/value/telecom`` = _prefix "Telecom/key/shop/value/telecom"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telecommunication"></see>
    /// </summary>
    let Telecommunication = _prefix "Telecommunication"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telecommunication/key/shop/value/telecommunication"></see>
    /// </summary>
    let ``Telecommunication/key/shop/value/telecommunication`` =
        _prefix "Telecommunication/key/shop/value/telecommunication"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelecommunicationOffice"></see>
    /// </summary>
    let TelecommunicationOffice = _prefix "TelecommunicationOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelecommunicationOffice/key/office/value/telecommunication"></see>
    /// </summary>
    let ``TelecommunicationOffice/key/office/value/telecommunication`` =
        _prefix "TelecommunicationOffice/key/office/value/telecommunication"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telephone"></see>
    /// </summary>
    let Telephone = _prefix "Telephone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telephone/key/amenity/value/telephone"></see>
    /// </summary>
    let ``Telephone/key/amenity/value/telephone`` =
        _prefix "Telephone/key/amenity/value/telephone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelephoneExchange"></see>
    /// </summary>
    let TelephoneExchange = _prefix "TelephoneExchange"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelephoneExchange/key/man_made/value/telephone_exchange"></see>
    /// </summary>
    let ``TelephoneExchange/key/man_made/value/telephone_exchange`` =
        _prefix "TelephoneExchange/key/man_made/value/telephone_exchange"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelephoneShop"></see>
    /// </summary>
    let TelephoneShop = _prefix "TelephoneShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TelephoneShop/key/shop/value/telephone"></see>
    /// </summary>
    let ``TelephoneShop/key/shop/value/telephone`` =
        _prefix "TelephoneShop/key/shop/value/telephone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telescope"></see>
    /// </summary>
    let Telescope = _prefix "Telescope"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Telescope/key/man_made/value/telescope"></see>
    /// </summary>
    let ``Telescope/key/man_made/value/telescope`` =
        _prefix "Telescope/key/man_made/value/telescope"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Terrace"></see>
    /// </summary>
    let Terrace = _prefix "Terrace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Terrace/key/building/value/terrace"></see>
    /// </summary>
    let ``Terrace/key/building/value/terrace`` =
        _prefix "Terrace/key/building/value/terrace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TertiaryHighway"></see>
    /// </summary>
    let TertiaryHighway = _prefix "TertiaryHighway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TertiaryHighway/key/highway/value/tertiary"></see>
    /// </summary>
    let ``TertiaryHighway/key/highway/value/tertiary`` =
        _prefix "TertiaryHighway/key/highway/value/tertiary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Textiles"></see>
    /// </summary>
    let Textiles = _prefix "Textiles"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Textiles/key/shop/value/textiles"></see>
    /// </summary>
    let ``Textiles/key/shop/value/textiles`` =
        _prefix "Textiles/key/shop/value/textiles"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Theatre"></see>
    /// </summary>
    let Theatre = _prefix "Theatre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Theatre/key/amenity/value/theatre"></see>
    /// </summary>
    let ``Theatre/key/amenity/value/theatre`` =
        _prefix "Theatre/key/amenity/value/theatre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ThemePark"></see>
    /// </summary>
    let ThemePark = _prefix "ThemePark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ThemePark/key/tourism/value/theme_park"></see>
    /// </summary>
    let ``ThemePark/key/tourism/value/theme_park`` =
        _prefix "ThemePark/key/tourism/value/theme_park"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ThresingFloor"></see>
    /// </summary>
    let ThresingFloor = _prefix "ThresingFloor"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ThresingFloor/key/landuse/value/thresing_floor"></see>
    /// </summary>
    let ``ThresingFloor/key/landuse/value/thresing_floor`` =
        _prefix "ThresingFloor/key/landuse/value/thresing_floor"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Thrift"></see>
    /// </summary>
    let Thrift = _prefix "Thrift"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Thrift/key/shop/value/thrift"></see>
    /// </summary>
    let ``Thrift/key/shop/value/thrift`` = _prefix "Thrift/key/shop/value/thrift"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ticket"></see>
    /// </summary>
    let Ticket = _prefix "Ticket"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Ticket/key/shop/value/ticket"></see>
    /// </summary>
    let ``Ticket/key/shop/value/ticket`` = _prefix "Ticket/key/shop/value/ticket"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tickets"></see>
    /// </summary>
    let Tickets = _prefix "Tickets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tickets/key/shop/value/tickets"></see>
    /// </summary>
    let ``Tickets/key/shop/value/tickets`` = _prefix "Tickets/key/shop/value/tickets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tiler"></see>
    /// </summary>
    let Tiler = _prefix "Tiler"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tiler/key/craft/value/tiler"></see>
    /// </summary>
    let ``Tiler/key/craft/value/tiler`` = _prefix "Tiler/key/craft/value/tiler"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tinsmith"></see>
    /// </summary>
    let Tinsmith = _prefix "Tinsmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tinsmith/key/craft/value/tinsmith"></see>
    /// </summary>
    let ``Tinsmith/key/craft/value/tinsmith`` =
        _prefix "Tinsmith/key/craft/value/tinsmith"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tobacco"></see>
    /// </summary>
    let Tobacco = _prefix "Tobacco"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tobacco/key/shop/value/tobacco"></see>
    /// </summary>
    let ``Tobacco/key/shop/value/tobacco`` = _prefix "Tobacco/key/shop/value/tobacco"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tobacconist"></see>
    /// </summary>
    let Tobacconist = _prefix "Tobacconist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tobacconist/key/shop/value/tobacconist"></see>
    /// </summary>
    let ``Tobacconist/key/shop/value/tobacconist`` =
        _prefix "Tobacconist/key/shop/value/tobacconist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Toilets"></see>
    /// </summary>
    let Toilets = _prefix "Toilets"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Toilets/key/amenity/value/toilets"></see>
    /// </summary>
    let ``Toilets/key/amenity/value/toilets`` =
        _prefix "Toilets/key/amenity/value/toilets"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TollBooth"></see>
    /// </summary>
    let TollBooth = _prefix "TollBooth"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TollBooth/key/barrier/value/toll_booth"></see>
    /// </summary>
    let ``TollBooth/key/barrier/value/toll_booth`` =
        _prefix "TollBooth/key/barrier/value/toll_booth"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tombstone"></see>
    /// </summary>
    let Tombstone = _prefix "Tombstone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tombstone/key/historic/value/tombstone"></see>
    /// </summary>
    let ``Tombstone/key/historic/value/tombstone`` =
        _prefix "Tombstone/key/historic/value/tombstone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TourismInformation"></see>
    /// </summary>
    let TourismInformation = _prefix "TourismInformation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TourismInformation/key/tourism/value/information"></see>
    /// </summary>
    let ``TourismInformation/key/tourism/value/information`` =
        _prefix "TourismInformation/key/tourism/value/information"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tourist"></see>
    /// </summary>
    let Tourist = _prefix "Tourist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tourist/key/amenity/value/tourist"></see>
    /// </summary>
    let ``Tourist/key/amenity/value/tourist`` =
        _prefix "Tourist/key/amenity/value/tourist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TouristShop"></see>
    /// </summary>
    let TouristShop = _prefix "TouristShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TouristShop/key/shop/value/tourist"></see>
    /// </summary>
    let ``TouristShop/key/shop/value/tourist`` =
        _prefix "TouristShop/key/shop/value/tourist"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tower"></see>
    /// </summary>
    let Tower = _prefix "Tower"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tower/key/man_made/value/tower"></see>
    /// </summary>
    let ``Tower/key/man_made/value/tower`` = _prefix "Tower/key/man_made/value/tower"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Town"></see>
    /// </summary>
    let Town = _prefix "Town"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Town/key/place/value/town"></see>
    /// </summary>
    let ``Town/key/place/value/town`` = _prefix "Town/key/place/value/town"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Townhall"></see>
    /// </summary>
    let Townhall = _prefix "Townhall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Townhall/key/amenity/value/townhall"></see>
    /// </summary>
    let ``Townhall/key/amenity/value/townhall`` =
        _prefix "Townhall/key/amenity/value/townhall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Toys"></see>
    /// </summary>
    let Toys = _prefix "Toys"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Toys/key/shop/value/toys"></see>
    /// </summary>
    let ``Toys/key/shop/value/toys`` = _prefix "Toys/key/shop/value/toys"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Track"></see>
    /// </summary>
    let Track = _prefix "Track"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Track/key/leisure/value/track"></see>
    /// </summary>
    let ``Track/key/leisure/value/track`` = _prefix "Track/key/leisure/value/track"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Track/key/highway/value/track"></see>
    /// </summary>
    let ``Track/key/highway/value/track`` = _prefix "Track/key/highway/value/track"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackHalt"></see>
    /// </summary>
    let TrackHalt = _prefix "TrackHalt"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackHalt/key/railway/value/track_halt"></see>
    /// </summary>
    let ``TrackHalt/key/railway/value/track_halt`` =
        _prefix "TrackHalt/key/railway/value/track_halt"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType1"></see>
    /// </summary>
    let TrackType1 = _prefix "TrackType1"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType1/key/tracktype/value/grade1"></see>
    /// </summary>
    let ``TrackType1/key/tracktype/value/grade1`` =
        _prefix "TrackType1/key/tracktype/value/grade1"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType2"></see>
    /// </summary>
    let TrackType2 = _prefix "TrackType2"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType2/key/tracktype/value/grade2"></see>
    /// </summary>
    let ``TrackType2/key/tracktype/value/grade2`` =
        _prefix "TrackType2/key/tracktype/value/grade2"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType3"></see>
    /// </summary>
    let TrackType3 = _prefix "TrackType3"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType3/key/tracktype/value/grade3"></see>
    /// </summary>
    let ``TrackType3/key/tracktype/value/grade3`` =
        _prefix "TrackType3/key/tracktype/value/grade3"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType4"></see>
    /// </summary>
    let TrackType4 = _prefix "TrackType4"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType4/key/tracktype/value/grade4"></see>
    /// </summary>
    let ``TrackType4/key/tracktype/value/grade4`` =
        _prefix "TrackType4/key/tracktype/value/grade4"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType5"></see>
    /// </summary>
    let TrackType5 = _prefix "TrackType5"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrackType5/key/tracktype/value/grade5"></see>
    /// </summary>
    let ``TrackType5/key/tracktype/value/grade5`` =
        _prefix "TrackType5/key/tracktype/value/grade5"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trade"></see>
    /// </summary>
    let Trade = _prefix "Trade"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trade/key/amenity/value/trade"></see>
    /// </summary>
    let ``Trade/key/amenity/value/trade`` = _prefix "Trade/key/amenity/value/trade"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficCalming"></see>
    /// </summary>
    let TrafficCalming = _prefix "TrafficCalming"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficCalming/key/traffic_calming/value/yes"></see>
    /// </summary>
    let ``TrafficCalming/key/traffic_calming/value/yes`` =
        _prefix "TrafficCalming/key/traffic_calming/value/yes"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficLight"></see>
    /// </summary>
    let TrafficLight = _prefix "TrafficLight"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficLight/key/amenity/value/traffic_light"></see>
    /// </summary>
    let ``TrafficLight/key/amenity/value/traffic_light`` =
        _prefix "TrafficLight/key/amenity/value/traffic_light"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficSignals"></see>
    /// </summary>
    let TrafficSignals = _prefix "TrafficSignals"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrafficSignals/key/highway/value/traffic_signals"></see>
    /// </summary>
    let ``TrafficSignals/key/highway/value/traffic_signals`` =
        _prefix "TrafficSignals/key/highway/value/traffic_signals"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrainRoute"></see>
    /// </summary>
    let TrainRoute = _prefix "TrainRoute"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrainRoute/key/route/value/train"></see>
    /// </summary>
    let ``TrainRoute/key/route/value/train`` =
        _prefix "TrainRoute/key/route/value/train"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrainStation"></see>
    /// </summary>
    let TrainStation = _prefix "TrainStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrainStation/key/building/value/train_station"></see>
    /// </summary>
    let ``TrainStation/key/building/value/train_station`` =
        _prefix "TrainStation/key/building/value/train_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramRoute"></see>
    /// </summary>
    let TramRoute = _prefix "TramRoute"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramRoute/key/route/value/tram"></see>
    /// </summary>
    let ``TramRoute/key/route/value/tram`` = _prefix "TramRoute/key/route/value/tram"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramStation"></see>
    /// </summary>
    let TramStation = _prefix "TramStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramStation/key/railway/value/tram_station"></see>
    /// </summary>
    let ``TramStation/key/railway/value/tram_station`` =
        _prefix "TramStation/key/railway/value/tram_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramStop"></see>
    /// </summary>
    let TramStop = _prefix "TramStop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TramStop/key/railway/value/tram_stop"></see>
    /// </summary>
    let ``TramStop/key/railway/value/tram_stop`` =
        _prefix "TramStop/key/railway/value/tram_stop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tramway"></see>
    /// </summary>
    let Tramway = _prefix "Tramway"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tramway/key/railway/value/tram"></see>
    /// </summary>
    let ``Tramway/key/railway/value/tram`` = _prefix "Tramway/key/railway/value/tram"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Transformer"></see>
    /// </summary>
    let Transformer = _prefix "Transformer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Transformer/key/power/value/transformer"></see>
    /// </summary>
    let ``Transformer/key/power/value/transformer`` =
        _prefix "Transformer/key/power/value/transformer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrashBin"></see>
    /// </summary>
    let TrashBin = _prefix "TrashBin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrashBin/key/amenity/value/trash_bin"></see>
    /// </summary>
    let ``TrashBin/key/amenity/value/trash_bin`` =
        _prefix "TrashBin/key/amenity/value/trash_bin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrashCan"></see>
    /// </summary>
    let TrashCan = _prefix "TrashCan"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrashCan/key/amenity/value/trash_can"></see>
    /// </summary>
    let ``TrashCan/key/amenity/value/trash_can`` =
        _prefix "TrashCan/key/amenity/value/trash_can"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgency"></see>
    /// </summary>
    let TravelAgency = _prefix "TravelAgency"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgency/key/shop/value/travel_agency"></see>
    /// </summary>
    let ``TravelAgency/key/shop/value/travel_agency`` =
        _prefix "TravelAgency/key/shop/value/travel_agency"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgency/key/shop/value/travel%20agency"></see>
    /// </summary>
    let ``TravelAgency/key/shop/value/travel%20agency`` =
        _prefix "TravelAgency/key/shop/value/travel%20agency"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgentOffice"></see>
    /// </summary>
    let TravelAgentOffice = _prefix "TravelAgentOffice"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TravelAgentOffice/key/office/value/travel_agent"></see>
    /// </summary>
    let ``TravelAgentOffice/key/office/value/travel_agent`` =
        _prefix "TravelAgentOffice/key/office/value/travel_agent"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tree"></see>
    /// </summary>
    let Tree = _prefix "Tree"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tree/key/natural/value/tree"></see>
    /// </summary>
    let ``Tree/key/natural/value/tree`` = _prefix "Tree/key/natural/value/tree"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Treerow"></see>
    /// </summary>
    let Treerow = _prefix "Treerow"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Treerow/key/landuse/value/treerow"></see>
    /// </summary>
    let ``Treerow/key/landuse/value/treerow`` =
        _prefix "Treerow/key/landuse/value/treerow"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TricycleStation"></see>
    /// </summary>
    let TricycleStation = _prefix "TricycleStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TricycleStation/key/amenity/value/tricycle_station"></see>
    /// </summary>
    let ``TricycleStation/key/amenity/value/tricycle_station`` =
        _prefix "TricycleStation/key/amenity/value/tricycle_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trumpet"></see>
    /// </summary>
    let Trumpet = _prefix "Trumpet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trumpet/key/shop/value/trumpet"></see>
    /// </summary>
    let ``Trumpet/key/shop/value/trumpet`` = _prefix "Trumpet/key/shop/value/trumpet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trunk"></see>
    /// </summary>
    let Trunk = _prefix "Trunk"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Trunk/key/highway/value/trunk"></see>
    /// </summary>
    let ``Trunk/key/highway/value/trunk`` = _prefix "Trunk/key/highway/value/trunk"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrunkLink"></see>
    /// </summary>
    let TrunkLink = _prefix "TrunkLink"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TrunkLink/key/highway/value/trunk_link"></see>
    /// </summary>
    let ``TrunkLink/key/highway/value/trunk_link`` =
        _prefix "TrunkLink/key/highway/value/trunk_link"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tumulus"></see>
    /// </summary>
    let Tumulus = _prefix "Tumulus"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tumulus/key/historic/value/tumulus"></see>
    /// </summary>
    let ``Tumulus/key/historic/value/tumulus`` =
        _prefix "Tumulus/key/historic/value/tumulus"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TunnelCulvert"></see>
    /// </summary>
    let TunnelCulvert = _prefix "TunnelCulvert"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TunnelCulvert/key/tunnel/value/culvert"></see>
    /// </summary>
    let ``TunnelCulvert/key/tunnel/value/culvert`` =
        _prefix "TunnelCulvert/key/tunnel/value/culvert"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TurningCircle"></see>
    /// </summary>
    let TurningCircle = _prefix "TurningCircle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TurningCircle/key/highway/value/turning_circle"></see>
    /// </summary>
    let ``TurningCircle/key/highway/value/turning_circle`` =
        _prefix "TurningCircle/key/highway/value/turning_circle"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TurningPoint"></see>
    /// </summary>
    let TurningPoint = _prefix "TurningPoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/TurningPoint/key/waterway/value/turning_point"></see>
    /// </summary>
    let ``TurningPoint/key/waterway/value/turning_point`` =
        _prefix "TurningPoint/key/waterway/value/turning_point"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Turnstile"></see>
    /// </summary>
    let Turnstile = _prefix "Turnstile"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Turnstile/key/barrier/value/turnstile"></see>
    /// </summary>
    let ``Turnstile/key/barrier/value/turnstile`` =
        _prefix "Turnstile/key/barrier/value/turnstile"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Turntable"></see>
    /// </summary>
    let Turntable = _prefix "Turntable"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Turntable/key/railway/value/turntable"></see>
    /// </summary>
    let ``Turntable/key/railway/value/turntable`` =
        _prefix "Turntable/key/railway/value/turntable"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tyres"></see>
    /// </summary>
    let Tyres = _prefix "Tyres"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Tyres/key/shop/value/tyres"></see>
    /// </summary>
    let ``Tyres/key/shop/value/tyres`` = _prefix "Tyres/key/shop/value/tyres"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UNESCOWorldHeritage"></see>
    /// </summary>
    let UNESCOWorldHeritage = _prefix "UNESCOWorldHeritage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UNESCOWorldHeritage/key/historic/value/UNESCO_world_heritage"></see>
    /// </summary>
    let ``UNESCOWorldHeritage/key/historic/value/UNESCO_world_heritage`` =
        _prefix "UNESCOWorldHeritage/key/historic/value/UNESCO_world_heritage"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UnclassifiedHighway"></see>
    /// </summary>
    let UnclassifiedHighway = _prefix "UnclassifiedHighway"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UnclassifiedHighway/key/highway/value/unclassified"></see>
    /// </summary>
    let ``UnclassifiedHighway/key/highway/value/unclassified`` =
        _prefix "UnclassifiedHighway/key/highway/value/unclassified"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UndefinedShop"></see>
    /// </summary>
    let UndefinedShop = _prefix "UndefinedShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UndefinedShop/key/shop/value/undefined"></see>
    /// </summary>
    let ``UndefinedShop/key/shop/value/undefined`` =
        _prefix "UndefinedShop/key/shop/value/undefined"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/University"></see>
    /// </summary>
    let University = _prefix "University"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/University/key/amenity/value/university"></see>
    /// </summary>
    let ``University/key/amenity/value/university`` =
        _prefix "University/key/amenity/value/university"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UnknownShop"></see>
    /// </summary>
    let UnknownShop = _prefix "UnknownShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/UnknownShop/key/shop/value/unknown"></see>
    /// </summary>
    let ``UnknownShop/key/shop/value/unknown`` =
        _prefix "UnknownShop/key/shop/value/unknown"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Uphill+Terminal"></see>
    /// </summary>
    let ``Uphill+Terminal`` = _prefix "Uphill+Terminal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Uphill+Terminal/key/man_made/value/Uphill%20Terminal"></see>
    /// </summary>
    let ``Uphill+Terminal/key/man_made/value/Uphill%20Terminal`` =
        _prefix "Uphill+Terminal/key/man_made/value/Uphill%20Terminal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Upholsterer"></see>
    /// </summary>
    let Upholsterer = _prefix "Upholsterer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Upholsterer/key/craft/value/upholsterer"></see>
    /// </summary>
    let ``Upholsterer/key/craft/value/upholsterer`` =
        _prefix "Upholsterer/key/craft/value/upholsterer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vacant"></see>
    /// </summary>
    let Vacant = _prefix "Vacant"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vacant/key/shop/value/vacant"></see>
    /// </summary>
    let ``Vacant/key/shop/value/vacant`` = _prefix "Vacant/key/shop/value/vacant"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Variety"></see>
    /// </summary>
    let Variety = _prefix "Variety"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Variety/key/shop/value/variety"></see>
    /// </summary>
    let ``Variety/key/shop/value/variety`` = _prefix "Variety/key/shop/value/variety"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vdsl-aru"></see>
    /// </summary>
    let ``Vdsl-aru`` = _prefix "Vdsl-aru"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vdsl-aru/key/amenity/value/vdsl-aru"></see>
    /// </summary>
    let ``Vdsl-aru/key/amenity/value/vdsl-aru`` =
        _prefix "Vdsl-aru/key/amenity/value/vdsl-aru"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VehicleInspection"></see>
    /// </summary>
    let VehicleInspection = _prefix "VehicleInspection"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VehicleInspection/key/amenity/value/vehicle_inspection"></see>
    /// </summary>
    let ``VehicleInspection/key/amenity/value/vehicle_inspection`` =
        _prefix "VehicleInspection/key/amenity/value/vehicle_inspection"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vending"></see>
    /// </summary>
    let Vending = _prefix "Vending"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vending/key/amenity/value/vending"></see>
    /// </summary>
    let ``Vending/key/amenity/value/vending`` =
        _prefix "Vending/key/amenity/value/vending"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vending+machine"></see>
    /// </summary>
    let ``Vending+machine`` = _prefix "Vending+machine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vending+machine/key/amenity/value/vending%20machine"></see>
    /// </summary>
    let ``Vending+machine/key/amenity/value/vending%20machine`` =
        _prefix "Vending+machine/key/amenity/value/vending%20machine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VendingMachine"></see>
    /// </summary>
    let VendingMachine = _prefix "VendingMachine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VendingMachine/key/amenity/value/vending_machine"></see>
    /// </summary>
    let ``VendingMachine/key/amenity/value/vending_machine`` =
        _prefix "VendingMachine/key/amenity/value/vending_machine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VendingMaschine"></see>
    /// </summary>
    let VendingMaschine = _prefix "VendingMaschine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VendingMaschine/key/amenity/value/vending_maschine"></see>
    /// </summary>
    let ``VendingMaschine/key/amenity/value/vending_maschine`` =
        _prefix "VendingMaschine/key/amenity/value/vending_maschine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VentilationShaft"></see>
    /// </summary>
    let VentilationShaft = _prefix "VentilationShaft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VentilationShaft/key/railway/value/ventilation_shaft"></see>
    /// </summary>
    let ``VentilationShaft/key/railway/value/ventilation_shaft`` =
        _prefix "VentilationShaft/key/railway/value/ventilation_shaft"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vet"></see>
    /// </summary>
    let Vet = _prefix "Vet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vet/key/amenity/value/vet"></see>
    /// </summary>
    let ``Vet/key/amenity/value/vet`` = _prefix "Vet/key/amenity/value/vet"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Veterinary"></see>
    /// </summary>
    let Veterinary = _prefix "Veterinary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Veterinary/key/amenity/value/veterinary"></see>
    /// </summary>
    let ``Veterinary/key/amenity/value/veterinary`` =
        _prefix "Veterinary/key/amenity/value/veterinary"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vets"></see>
    /// </summary>
    let Vets = _prefix "Vets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vets/key/amenity/value/vets"></see>
    /// </summary>
    let ``Vets/key/amenity/value/vets`` = _prefix "Vets/key/amenity/value/vets"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viaduct"></see>
    /// </summary>
    let Viaduct = _prefix "Viaduct"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viaduct/key/railway/value/viaduct"></see>
    /// </summary>
    let ``Viaduct/key/railway/value/viaduct`` =
        _prefix "Viaduct/key/railway/value/viaduct"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Video"></see>
    /// </summary>
    let Video = _prefix "Video"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Video/key/shop/value/video"></see>
    /// </summary>
    let ``Video/key/shop/value/video`` = _prefix "Video/key/shop/value/video"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoGames"></see>
    /// </summary>
    let VideoGames = _prefix "VideoGames"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoGames/key/shop/value/video_games"></see>
    /// </summary>
    let ``VideoGames/key/shop/value/video_games`` =
        _prefix "VideoGames/key/shop/value/video_games"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoRental"></see>
    /// </summary>
    let VideoRental = _prefix "VideoRental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoRental/key/amenity/value/video_rental"></see>
    /// </summary>
    let ``VideoRental/key/amenity/value/video_rental`` =
        _prefix "VideoRental/key/amenity/value/video_rental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VideoRental/key/shop/value/video_rental"></see>
    /// </summary>
    let ``VideoRental/key/shop/value/video_rental`` =
        _prefix "VideoRental/key/shop/value/video_rental"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Videosurveillance"></see>
    /// </summary>
    let Videosurveillance = _prefix "Videosurveillance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Videosurveillance/key/man_made/value/videosurveillance"></see>
    /// </summary>
    let ``Videosurveillance/key/man_made/value/videosurveillance`` =
        _prefix "Videosurveillance/key/man_made/value/videosurveillance"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viewpoint"></see>
    /// </summary>
    let Viewpoint = _prefix "Viewpoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viewpoint/key/tourism/value/viewpoint"></see>
    /// </summary>
    let ``Viewpoint/key/tourism/value/viewpoint`` =
        _prefix "Viewpoint/key/tourism/value/viewpoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Village"></see>
    /// </summary>
    let Village = _prefix "Village"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Village/key/place/value/village"></see>
    /// </summary>
    let ``Village/key/place/value/village`` = _prefix "Village/key/place/value/village"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillageGreen"></see>
    /// </summary>
    let VillageGreen = _prefix "VillageGreen"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillageGreen/key/landuse/value/village_green"></see>
    /// </summary>
    let ``VillageGreen/key/landuse/value/village_green`` =
        _prefix "VillageGreen/key/landuse/value/village_green"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillageHall"></see>
    /// </summary>
    let VillageHall = _prefix "VillageHall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillageHall/key/amenity/value/village_hall"></see>
    /// </summary>
    let ``VillageHall/key/amenity/value/village_hall`` =
        _prefix "VillageHall/key/amenity/value/village_hall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillagePump"></see>
    /// </summary>
    let VillagePump = _prefix "VillagePump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/VillagePump/key/man_made/value/village_pump"></see>
    /// </summary>
    let ``VillagePump/key/man_made/value/village_pump`` =
        _prefix "VillagePump/key/man_made/value/village_pump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vineyard"></see>
    /// </summary>
    let Vineyard = _prefix "Vineyard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Vineyard/key/landuse/value/vineyard"></see>
    /// </summary>
    let ``Vineyard/key/landuse/value/vineyard`` =
        _prefix "Vineyard/key/landuse/value/vineyard"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viva+Blue"></see>
    /// </summary>
    let ``Viva+Blue`` = _prefix "Viva+Blue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Viva+Blue/key/railway/value/Viva%20Blue"></see>
    /// </summary>
    let ``Viva+Blue/key/railway/value/Viva%20Blue`` =
        _prefix "Viva+Blue/key/railway/value/Viva%20Blue"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Volcano"></see>
    /// </summary>
    let Volcano = _prefix "Volcano"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Volcano/key/natural/value/volcano"></see>
    /// </summary>
    let ``Volcano/key/natural/value/volcano`` =
        _prefix "Volcano/key/natural/value/volcano"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WLAN"></see>
    /// </summary>
    let WLAN = _prefix "WLAN"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WLAN/key/amenity/value/WLAN"></see>
    /// </summary>
    let ``WLAN/key/amenity/value/WLAN`` = _prefix "WLAN/key/amenity/value/WLAN"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WalkingBus"></see>
    /// </summary>
    let WalkingBus = _prefix "WalkingBus"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WalkingBus/key/amenity/value/walking_bus"></see>
    /// </summary>
    let ``WalkingBus/key/amenity/value/walking_bus`` =
        _prefix "WalkingBus/key/amenity/value/walking_bus"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wall"></see>
    /// </summary>
    let Wall = _prefix "Wall"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wall/key/barrier/value/wall"></see>
    /// </summary>
    let ``Wall/key/barrier/value/wall`` = _prefix "Wall/key/barrier/value/wall"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waste"></see>
    /// </summary>
    let Waste = _prefix "Waste"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waste/key/amenity/value/waste"></see>
    /// </summary>
    let ``Waste/key/amenity/value/waste`` = _prefix "Waste/key/amenity/value/waste"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBasket"></see>
    /// </summary>
    let WasteBasket = _prefix "WasteBasket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBasket/key/amenity/value/waste_basket"></see>
    /// </summary>
    let ``WasteBasket/key/amenity/value/waste_basket`` =
        _prefix "WasteBasket/key/amenity/value/waste_basket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBasket%3Brecycling"></see>
    /// </summary>
    let ``WasteBasket%3Brecycling`` = _prefix "WasteBasket%3Brecycling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBasket%3Brecycling/key/amenity/value/waste_basket%3Brecycling"></see>
    /// </summary>
    let ``WasteBasket%3Brecycling/key/amenity/value/waste_basket%3Brecycling`` =
        _prefix "WasteBasket%3Brecycling/key/amenity/value/waste_basket%3Brecycling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBin"></see>
    /// </summary>
    let WasteBin = _prefix "WasteBin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBin/key/amenity/value/waste_bin"></see>
    /// </summary>
    let ``WasteBin/key/amenity/value/waste_bin`` =
        _prefix "WasteBin/key/amenity/value/waste_bin"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBucket"></see>
    /// </summary>
    let WasteBucket = _prefix "WasteBucket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteBucket/key/amenity/value/waste_bucket"></see>
    /// </summary>
    let ``WasteBucket/key/amenity/value/waste_bucket`` =
        _prefix "WasteBucket/key/amenity/value/waste_bucket"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteContainer"></see>
    /// </summary>
    let WasteContainer = _prefix "WasteContainer"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteContainer/key/amenity/value/waste_container"></see>
    /// </summary>
    let ``WasteContainer/key/amenity/value/waste_container`` =
        _prefix "WasteContainer/key/amenity/value/waste_container"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteDisposal"></see>
    /// </summary>
    let WasteDisposal = _prefix "WasteDisposal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WasteDisposal/key/amenity/value/waste_disposal"></see>
    /// </summary>
    let ``WasteDisposal/key/amenity/value/waste_disposal`` =
        _prefix "WasteDisposal/key/amenity/value/waste_disposal"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WastewaterPlant"></see>
    /// </summary>
    let WastewaterPlant = _prefix "WastewaterPlant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WastewaterPlant/key/man_made/value/wastewater_plant"></see>
    /// </summary>
    let ``WastewaterPlant/key/man_made/value/wastewater_plant`` =
        _prefix "WastewaterPlant/key/man_made/value/wastewater_plant"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watches"></see>
    /// </summary>
    let Watches = _prefix "Watches"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watches/key/shop/value/watches"></see>
    /// </summary>
    let ``Watches/key/shop/value/watches`` = _prefix "Watches/key/shop/value/watches"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watchmaker"></see>
    /// </summary>
    let Watchmaker = _prefix "Watchmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watchmaker/key/craft/value/watchmaker"></see>
    /// </summary>
    let ``Watchmaker/key/craft/value/watchmaker`` =
        _prefix "Watchmaker/key/craft/value/watchmaker"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Water"></see>
    /// </summary>
    let Water = _prefix "Water"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Water/key/natural/value/water"></see>
    /// </summary>
    let ``Water/key/natural/value/water`` = _prefix "Water/key/natural/value/water"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Water/key/amenity/value/water"></see>
    /// </summary>
    let ``Water/key/amenity/value/water`` = _prefix "Water/key/amenity/value/water"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterFountain"></see>
    /// </summary>
    let WaterFountain = _prefix "WaterFountain"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterFountain/key/amenity/value/water_fountain"></see>
    /// </summary>
    let ``WaterFountain/key/amenity/value/water_fountain`` =
        _prefix "WaterFountain/key/amenity/value/water_fountain"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterPark"></see>
    /// </summary>
    let WaterPark = _prefix "WaterPark"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterPark/key/leisure/value/water_park"></see>
    /// </summary>
    let ``WaterPark/key/leisure/value/water_park`` =
        _prefix "WaterPark/key/leisure/value/water_park"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterPoint"></see>
    /// </summary>
    let WaterPoint = _prefix "WaterPoint"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterPoint/key/waterway/value/water_point"></see>
    /// </summary>
    let ``WaterPoint/key/waterway/value/water_point`` =
        _prefix "WaterPoint/key/waterway/value/water_point"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterRefilling"></see>
    /// </summary>
    let WaterRefilling = _prefix "WaterRefilling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterRefilling/key/shop/value/water_refilling"></see>
    /// </summary>
    let ``WaterRefilling/key/shop/value/water_refilling`` =
        _prefix "WaterRefilling/key/shop/value/water_refilling"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterTank"></see>
    /// </summary>
    let WaterTank = _prefix "WaterTank"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterTank/key/man_made/value/water_tank"></see>
    /// </summary>
    let ``WaterTank/key/man_made/value/water_tank`` =
        _prefix "WaterTank/key/man_made/value/water_tank"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterTower"></see>
    /// </summary>
    let WaterTower = _prefix "WaterTower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterTower/key/man_made/value/water_tower"></see>
    /// </summary>
    let ``WaterTower/key/man_made/value/water_tower`` =
        _prefix "WaterTower/key/man_made/value/water_tower"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWell"></see>
    /// </summary>
    let WaterWell = _prefix "WaterWell"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWell/key/man_made/value/water_well"></see>
    /// </summary>
    let ``WaterWell/key/man_made/value/water_well`` =
        _prefix "WaterWell/key/man_made/value/water_well"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWell/key/amenity/value/water_well"></see>
    /// </summary>
    let ``WaterWell/key/amenity/value/water_well`` =
        _prefix "WaterWell/key/amenity/value/water_well"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWorks"></see>
    /// </summary>
    let WaterWorks = _prefix "WaterWorks"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterWorks/key/man_made/value/water_works"></see>
    /// </summary>
    let ``WaterWorks/key/man_made/value/water_works`` =
        _prefix "WaterWorks/key/man_made/value/water_works"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waterfall"></see>
    /// </summary>
    let Waterfall = _prefix "Waterfall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waterfall/key/waterway/value/waterfall"></see>
    /// </summary>
    let ``Waterfall/key/waterway/value/waterfall`` =
        _prefix "Waterfall/key/waterway/value/waterfall"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waterhole"></see>
    /// </summary>
    let Waterhole = _prefix "Waterhole"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Waterhole/key/natural/value/waterhole"></see>
    /// </summary>
    let ``Waterhole/key/natural/value/waterhole`` =
        _prefix "Waterhole/key/natural/value/waterhole"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WateringPlace"></see>
    /// </summary>
    let WateringPlace = _prefix "WateringPlace"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WateringPlace/key/amenity/value/watering_place"></see>
    /// </summary>
    let ``WateringPlace/key/amenity/value/watering_place`` =
        _prefix "WateringPlace/key/amenity/value/watering_place"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watermill"></see>
    /// </summary>
    let Watermill = _prefix "Watermill"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Watermill/key/man_made/value/watermill"></see>
    /// </summary>
    let ``Watermill/key/man_made/value/watermill`` =
        _prefix "Watermill/key/man_made/value/watermill"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayDrawbridge"></see>
    /// </summary>
    let WaterwayDrawbridge = _prefix "WaterwayDrawbridge"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayDrawbridge/key/waterway/value/drawbridge"></see>
    /// </summary>
    let ``WaterwayDrawbridge/key/waterway/value/drawbridge`` =
        _prefix "WaterwayDrawbridge/key/waterway/value/drawbridge"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayFord"></see>
    /// </summary>
    let WaterwayFord = _prefix "WaterwayFord"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayFord/key/waterway/value/ford"></see>
    /// </summary>
    let ``WaterwayFord/key/waterway/value/ford`` =
        _prefix "WaterwayFord/key/waterway/value/ford"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayFuel"></see>
    /// </summary>
    let WaterwayFuel = _prefix "WaterwayFuel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayFuel/key/waterway/value/fuel"></see>
    /// </summary>
    let ``WaterwayFuel/key/waterway/value/fuel`` =
        _prefix "WaterwayFuel/key/waterway/value/fuel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayLock"></see>
    /// </summary>
    let WaterwayLock = _prefix "WaterwayLock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayLock/key/waterway/value/lock"></see>
    /// </summary>
    let ``WaterwayLock/key/waterway/value/lock`` =
        _prefix "WaterwayLock/key/waterway/value/lock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayMilestone"></see>
    /// </summary>
    let WaterwayMilestone = _prefix "WaterwayMilestone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayMilestone/key/waterway/value/milestone"></see>
    /// </summary>
    let ``WaterwayMilestone/key/waterway/value/milestone`` =
        _prefix "WaterwayMilestone/key/waterway/value/milestone"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayPumpingStation"></see>
    /// </summary>
    let WaterwayPumpingStation = _prefix "WaterwayPumpingStation"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayPumpingStation/key/waterway/value/pumping_station"></see>
    /// </summary>
    let ``WaterwayPumpingStation/key/waterway/value/pumping_station`` =
        _prefix "WaterwayPumpingStation/key/waterway/value/pumping_station"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayRock"></see>
    /// </summary>
    let WaterwayRock = _prefix "WaterwayRock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayRock/key/waterway/value/rock"></see>
    /// </summary>
    let ``WaterwayRock/key/waterway/value/rock`` =
        _prefix "WaterwayRock/key/waterway/value/rock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwaySpring"></see>
    /// </summary>
    let WaterwaySpring = _prefix "WaterwaySpring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwaySpring/key/waterway/value/spring"></see>
    /// </summary>
    let ``WaterwaySpring/key/waterway/value/spring`` =
        _prefix "WaterwaySpring/key/waterway/value/spring"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayWreck"></see>
    /// </summary>
    let WaterwayWreck = _prefix "WaterwayWreck"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaterwayWreck/key/waterway/value/wreck"></see>
    /// </summary>
    let ``WaterwayWreck/key/waterway/value/wreck`` =
        _prefix "WaterwayWreck/key/waterway/value/wreck"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideChapel"></see>
    /// </summary>
    let WaysideChapel = _prefix "WaysideChapel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideChapel/key/historic/value/wayside_chapel"></see>
    /// </summary>
    let ``WaysideChapel/key/historic/value/wayside_chapel`` =
        _prefix "WaysideChapel/key/historic/value/wayside_chapel"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideCross"></see>
    /// </summary>
    let WaysideCross = _prefix "WaysideCross"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideCross/key/historic/value/wayside_cross%20"></see>
    /// </summary>
    let ``WaysideCross/key/historic/value/wayside_cross%20`` =
        _prefix "WaysideCross/key/historic/value/wayside_cross%20"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideShrine"></see>
    /// </summary>
    let WaysideShrine = _prefix "WaysideShrine"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WaysideShrine/key/historic/value/wayside_shrine%20"></see>
    /// </summary>
    let ``WaysideShrine/key/historic/value/wayside_shrine%20`` =
        _prefix "WaysideShrine/key/historic/value/wayside_shrine%20"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Weir"></see>
    /// </summary>
    let Weir = _prefix "Weir"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Weir/key/waterway/value/weir"></see>
    /// </summary>
    let ``Weir/key/waterway/value/weir`` = _prefix "Weir/key/waterway/value/weir"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Well"></see>
    /// </summary>
    let Well = _prefix "Well"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Well/key/amenity/value/well"></see>
    /// </summary>
    let ``Well/key/amenity/value/well`` = _prefix "Well/key/amenity/value/well"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WellWater"></see>
    /// </summary>
    let WellWater = _prefix "WellWater"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WellWater/key/man_made/value/well_water"></see>
    /// </summary>
    let ``WellWater/key/man_made/value/well_water`` =
        _prefix "WellWater/key/man_made/value/well_water"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wetland"></see>
    /// </summary>
    let Wetland = _prefix "Wetland"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wetland/key/natural/value/wetland"></see>
    /// </summary>
    let ``Wetland/key/natural/value/wetland`` =
        _prefix "Wetland/key/natural/value/wetland"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Whatever"></see>
    /// </summary>
    let Whatever = _prefix "Whatever"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Whatever/key/shop/value/whatever"></see>
    /// </summary>
    let ``Whatever/key/shop/value/whatever`` =
        _prefix "Whatever/key/shop/value/whatever"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Whirlpool"></see>
    /// </summary>
    let Whirlpool = _prefix "Whirlpool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Whirlpool/key/amenity/value/whirlpool"></see>
    /// </summary>
    let ``Whirlpool/key/amenity/value/whirlpool`` =
        _prefix "Whirlpool/key/amenity/value/whirlpool"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wholesale"></see>
    /// </summary>
    let Wholesale = _prefix "Wholesale"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wholesale/key/shop/value/wholesale"></see>
    /// </summary>
    let ``Wholesale/key/shop/value/wholesale`` =
        _prefix "Wholesale/key/shop/value/wholesale"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wifi"></see>
    /// </summary>
    let Wifi = _prefix "Wifi"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wifi/key/amenity/value/wifi"></see>
    /// </summary>
    let ``Wifi/key/amenity/value/wifi`` = _prefix "Wifi/key/amenity/value/wifi"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WildlifeHide"></see>
    /// </summary>
    let WildlifeHide = _prefix "WildlifeHide"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WildlifeHide/key/man_made/value/wildlife_hide"></see>
    /// </summary>
    let ``WildlifeHide/key/man_made/value/wildlife_hide`` =
        _prefix "WildlifeHide/key/man_made/value/wildlife_hide"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windmill"></see>
    /// </summary>
    let Windmill = _prefix "Windmill"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windmill/key/man_made/value/windmill"></see>
    /// </summary>
    let ``Windmill/key/man_made/value/windmill`` =
        _prefix "Windmill/key/man_made/value/windmill"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windows"></see>
    /// </summary>
    let Windows = _prefix "Windows"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windows/key/shop/value/windows"></see>
    /// </summary>
    let ``Windows/key/shop/value/windows`` = _prefix "Windows/key/shop/value/windows"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windpump"></see>
    /// </summary>
    let Windpump = _prefix "Windpump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windpump/key/man_made/value/windpump"></see>
    /// </summary>
    let ``Windpump/key/man_made/value/windpump`` =
        _prefix "Windpump/key/man_made/value/windpump"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windsock"></see>
    /// </summary>
    let Windsock = _prefix "Windsock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Windsock/key/aeroway/value/windsock"></see>
    /// </summary>
    let ``Windsock/key/aeroway/value/windsock`` =
        _prefix "Windsock/key/aeroway/value/windsock"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wine"></see>
    /// </summary>
    let Wine = _prefix "Wine"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wine/key/shop/value/wine"></see>
    /// </summary>
    let ``Wine/key/shop/value/wine`` = _prefix "Wine/key/shop/value/wine"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Winery"></see>
    /// </summary>
    let Winery = _prefix "Winery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Winery/key/amenity/value/winery"></see>
    /// </summary>
    let ``Winery/key/amenity/value/winery`` = _prefix "Winery/key/amenity/value/winery"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WineryShop"></see>
    /// </summary>
    let WineryShop = _prefix "WineryShop"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WineryShop/key/shop/value/winery"></see>
    /// </summary>
    let ``WineryShop/key/shop/value/winery`` =
        _prefix "WineryShop/key/shop/value/winery"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WinterRoad"></see>
    /// </summary>
    let WinterRoad = _prefix "WinterRoad"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WinterRoad/key/winter_road/value/yes"></see>
    /// </summary>
    let ``WinterRoad/key/winter_road/value/yes`` =
        _prefix "WinterRoad/key/winter_road/value/yes"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wlan"></see>
    /// </summary>
    let Wlan = _prefix "Wlan"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wlan/key/amenity/value/wlan"></see>
    /// </summary>
    let ``Wlan/key/amenity/value/wlan`` = _prefix "Wlan/key/amenity/value/wlan"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WolfPit"></see>
    /// </summary>
    let WolfPit = _prefix "WolfPit"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WolfPit/key/man_made/value/wolf_pit"></see>
    /// </summary>
    let ``WolfPit/key/man_made/value/wolf_pit`` =
        _prefix "WolfPit/key/man_made/value/wolf_pit"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wood"></see>
    /// </summary>
    let Wood = _prefix "Wood"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wood/key/natural/value/wood"></see>
    /// </summary>
    let ``Wood/key/natural/value/wood`` = _prefix "Wood/key/natural/value/wood"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WoodShop"></see>
    /// </summary>
    let WoodShop = _prefix "WoodShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/WoodShop/key/shop/value/wood"></see>
    /// </summary>
    let ``WoodShop/key/shop/value/wood`` = _prefix "WoodShop/key/shop/value/wood"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wreck"></see>
    /// </summary>
    let Wreck = _prefix "Wreck"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Wreck/key/historic/value/wreck%20"></see>
    /// </summary>
    let ``Wreck/key/historic/value/wreck%20`` =
        _prefix "Wreck/key/historic/value/wreck%20"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/YouthCentre"></see>
    /// </summary>
    let YouthCentre = _prefix "YouthCentre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/YouthCentre/key/amenity/value/youth_centre"></see>
    /// </summary>
    let ``YouthCentre/key/amenity/value/youth_centre`` =
        _prefix "YouthCentre/key/amenity/value/youth_centre"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/YouthClub"></see>
    /// </summary>
    let YouthClub = _prefix "YouthClub"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/YouthClub/key/amenity/value/youth_club"></see>
    /// </summary>
    let ``YouthClub/key/amenity/value/youth_club`` =
        _prefix "YouthClub/key/amenity/value/youth_club"

    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Zoo"></see>
    /// </summary>
    let Zoo = _prefix "Zoo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/Zoo/key/tourism/value/zoo"></see>
    /// </summary>
    let ``Zoo/key/tourism/value/zoo`` = _prefix "Zoo/key/tourism/value/zoo"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ZooShop"></see>
    /// </summary>
    let ZooShop = _prefix "ZooShop"
    /// <summary>
    ///   <see href="http://linkedgeodata.org/ontology/ZooShop/key/shop/value/zoo"></see>
    /// </summary>
    let ``ZooShop/key/shop/value/zoo`` = _prefix "ZooShop/key/shop/value/zoo"
