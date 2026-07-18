namespace https.purl.org.cityexplorer.hash

open DoxAletheia.Rdf_Vocabulary

module ce =
    let _namespace_name = "https://purl.org/cityexplorer#"

    /// <summary>
    /// Refers to restaurants serving food from Andalusia
    /// <see href="https://purl.org/cityexplorer#AndalusianRestaurant"></see></summary>
    let AndalusianRestaurant =
        Namespaced_IRI.parse _namespace_name "AndalusianRestaurant" |> NamespacedName

    /// <summary>
    /// Refers to restaurants serving food from Italy
    /// <see href="https://purl.org/cityexplorer#ItalianRestaurant"></see></summary>
    let ItalianRestaurant =
        Namespaced_IRI.parse _namespace_name "ItalianRestaurant" |> NamespacedName

    /// <summary>
    /// Refers to restaurants serving food from Japan
    /// <see href="https://purl.org/cityexplorer#JapaneseRestaurant"></see></summary>
    let JapaneseRestaurant =
        Namespaced_IRI.parse _namespace_name "JapaneseRestaurant" |> NamespacedName

    /// <summary>
    /// Refers to restaurants serving mediterranean food
    /// <see href="https://purl.org/cityexplorer#MediterraneanRestaurant"></see></summary>
    let MediterraneanRestaurant =
        Namespaced_IRI.parse _namespace_name "MediterraneanRestaurant" |> NamespacedName

    /// <summary>
    /// Refers to restaurants serving food from Mexico
    /// <see href="https://purl.org/cityexplorer#MexicanRestaurant"></see></summary>
    let MexicanRestaurant =
        Namespaced_IRI.parse _namespace_name "MexicanRestaurant" |> NamespacedName

    /// <summary>
    /// Refers to the category of events
    /// <see href="https://purl.org/cityexplorer#EventTypes"></see></summary>
    let EventTypes = Namespaced_IRI.parse _namespace_name "EventTypes" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Cultural"></see>
    /// </summary>
    let Cultural = Namespaced_IRI.parse _namespace_name "Cultural" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Gastronomic"></see>
    /// </summary>
    let Gastronomic =
        Namespaced_IRI.parse _namespace_name "Gastronomic" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Music"></see>
    /// </summary>
    let Music = Namespaced_IRI.parse _namespace_name "Music" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Sport"></see>
    /// </summary>
    let Sport = Namespaced_IRI.parse _namespace_name "Sport" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Technological"></see>
    /// </summary>
    let Technological =
        Namespaced_IRI.parse _namespace_name "Technological" |> NamespacedName

    /// <summary>
    /// Refers to attractions involving a beach
    /// <see href="https://purl.org/cityexplorer#BeachAttraction"></see></summary>
    let BeachAttraction =
        Namespaced_IRI.parse _namespace_name "BeachAttraction" |> NamespacedName

    /// <summary>
    /// Refers to attractions involving any kind of cultural activity
    /// <see href="https://purl.org/cityexplorer#CulturalAttraction"></see></summary>
    let CulturalAttraction =
        Namespaced_IRI.parse _namespace_name "CulturalAttraction" |> NamespacedName

    /// <summary>
    /// Refers to attractions involving a monument
    /// <see href="https://purl.org/cityexplorer#MonumentAttraction"></see></summary>
    let MonumentAttraction =
        Namespaced_IRI.parse _namespace_name "MonumentAttraction" |> NamespacedName

    /// <summary>
    /// Refers to attractions involving a museum
    /// <see href="https://purl.org/cityexplorer#MuseumAttraction"></see></summary>
    let MuseumAttraction =
        Namespaced_IRI.parse _namespace_name "MuseumAttraction" |> NamespacedName

    /// <summary>
    /// Refers to attractions involving a park
    /// <see href="https://purl.org/cityexplorer#ParkAttraction"></see></summary>
    let ParkAttraction =
        Namespaced_IRI.parse _namespace_name "ParkAttraction" |> NamespacedName

    /// <summary>
    /// Refers to the category of restaurants
    /// <see href="https://purl.org/cityexplorer#RestaurantTypes"></see></summary>
    let RestaurantTypes =
        Namespaced_IRI.parse _namespace_name "RestaurantTypes" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Andalusian"></see>
    /// </summary>
    let Andalusian = Namespaced_IRI.parse _namespace_name "Andalusian" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Italianian"></see>
    /// </summary>
    let Italianian = Namespaced_IRI.parse _namespace_name "Italianian" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Japanese"></see>
    /// </summary>
    let Japanese = Namespaced_IRI.parse _namespace_name "Japanese" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Mediterranean"></see>
    /// </summary>
    let Mediterranean =
        Namespaced_IRI.parse _namespace_name "Mediterranean" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Mexican"></see>
    /// </summary>
    let Mexican = Namespaced_IRI.parse _namespace_name "Mexican" |> NamespacedName

    /// <summary>
    /// Refers to cities located at the beach
    /// <see href="https://purl.org/cityexplorer#BeachCities"></see></summary>
    let BeachCities =
        Namespaced_IRI.parse _namespace_name "BeachCities" |> NamespacedName

    /// <summary>
    /// Refers to a city
    /// <see href="https://purl.org/cityexplorer#City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName
    /// <summary>
    /// Indicates if the city contains the specific property
    /// <see href="https://purl.org/cityexplorer#isCityOf"></see></summary>
    let isCityOf = Namespaced_IRI.parse _namespace_name "isCityOf" |> NamespacedName
    /// <summary>
    /// Refers to an attraction type, which can be cultural, park, etc.
    /// <see href="https://purl.org/cityexplorer#Attraction"></see></summary>
    let Attraction = Namespaced_IRI.parse _namespace_name "Attraction" |> NamespacedName
    /// <summary>
    /// Refers to a restaurant
    /// <see href="https://purl.org/cityexplorer#Restaurant"></see></summary>
    let Restaurant = Namespaced_IRI.parse _namespace_name "Restaurant" |> NamespacedName

    /// <summary>
    /// The overall rating, based on a collection of reviews or ratings, of the item
    /// <see href="https://purl.org/cityexplorer#aggregateRating"></see></summary>
    let aggregateRating =
        Namespaced_IRI.parse _namespace_name "aggregateRating" |> NamespacedName

    /// <summary>
    /// The price range of the business
    /// <see href="https://purl.org/cityexplorer#priceRange"></see></summary>
    let priceRange = Namespaced_IRI.parse _namespace_name "priceRange" |> NamespacedName

    /// <summary>
    /// Refers to restaurants that are recommended
    /// <see href="https://purl.org/cityexplorer#RecommendedRestaurants"></see></summary>
    let RecommendedRestaurants =
        Namespaced_IRI.parse _namespace_name "RecommendedRestaurants" |> NamespacedName

    /// <summary>
    /// Refers to an event involving any kind of cultural activity
    /// <see href="https://purl.org/cityexplorer#CulturalEvent"></see></summary>
    let CulturalEvent =
        Namespaced_IRI.parse _namespace_name "CulturalEvent" |> NamespacedName

    /// <summary>
    /// Refers to an event involving gastronomy
    /// <see href="https://purl.org/cityexplorer#GastronomicEvent"></see></summary>
    let GastronomicEvent =
        Namespaced_IRI.parse _namespace_name "GastronomicEvent" |> NamespacedName

    /// <summary>
    /// Refers to an event involving music
    /// <see href="https://purl.org/cityexplorer#MusicEvent"></see></summary>
    let MusicEvent = Namespaced_IRI.parse _namespace_name "MusicEvent" |> NamespacedName

    /// <summary>
    /// Refers to an event involving sports
    /// <see href="https://purl.org/cityexplorer#SportsEvent"></see></summary>
    let SportsEvent =
        Namespaced_IRI.parse _namespace_name "SportsEvent" |> NamespacedName

    /// <summary>
    /// Refers to an event involving tecnology
    /// <see href="https://purl.org/cityexplorer#TechnologicalEvent"></see></summary>
    let TechnologicalEvent =
        Namespaced_IRI.parse _namespace_name "TechnologicalEvent" |> NamespacedName

    /// <summary>
    /// Refers to the category of hotels
    /// <see href="https://purl.org/cityexplorer#HotelTypes"></see></summary>
    let HotelTypes = Namespaced_IRI.parse _namespace_name "HotelTypes" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Beach"></see>
    /// </summary>
    let Beach = Namespaced_IRI.parse _namespace_name "Beach" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Business"></see>
    /// </summary>
    let Business = Namespaced_IRI.parse _namespace_name "Business" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Luxury"></see>
    /// </summary>
    let Luxury = Namespaced_IRI.parse _namespace_name "Luxury" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Rural"></see>
    /// </summary>
    let Rural = Namespaced_IRI.parse _namespace_name "Rural" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Tourist"></see>
    /// </summary>
    let Tourist = Namespaced_IRI.parse _namespace_name "Tourist" |> NamespacedName

    /// <summary>
    /// Refers to the category of attractions
    /// <see href="https://purl.org/cityexplorer#AttractionTypes"></see></summary>
    let AttractionTypes =
        Namespaced_IRI.parse _namespace_name "AttractionTypes" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Monument"></see>
    /// </summary>
    let Monument = Namespaced_IRI.parse _namespace_name "Monument" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Museum"></see>
    /// </summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Park"></see>
    /// </summary>
    let Park = Namespaced_IRI.parse _namespace_name "Park" |> NamespacedName
    /// <summary>
    /// Refers to an event
    /// <see href="https://purl.org/cityexplorer#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// Refers to cities with cultural interest
    /// <see href="https://purl.org/cityexplorer#CulturalCities"></see></summary>
    let CulturalCities =
        Namespaced_IRI.parse _namespace_name "CulturalCities" |> NamespacedName

    /// <summary>
    /// Refers to the category of transports
    /// <see href="https://purl.org/cityexplorer#TransportTypes"></see></summary>
    let TransportTypes =
        Namespaced_IRI.parse _namespace_name "TransportTypes" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Bus"></see>
    /// </summary>
    let Bus = Namespaced_IRI.parse _namespace_name "Bus" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Metro"></see>
    /// </summary>
    let Metro = Namespaced_IRI.parse _namespace_name "Metro" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#PublicBike"></see>
    /// </summary>
    let PublicBike = Namespaced_IRI.parse _namespace_name "PublicBike" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Taxi"></see>
    /// </summary>
    let Taxi = Namespaced_IRI.parse _namespace_name "Taxi" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Tram"></see>
    /// </summary>
    let Tram = Namespaced_IRI.parse _namespace_name "Tram" |> NamespacedName
    /// <summary>
    /// Refers to hotels at the beach
    /// <see href="https://purl.org/cityexplorer#BeachHotel"></see></summary>
    let BeachHotel = Namespaced_IRI.parse _namespace_name "BeachHotel" |> NamespacedName

    /// <summary>
    /// Refers to hotels considered for business
    /// <see href="https://purl.org/cityexplorer#BusinessHotel"></see></summary>
    let BusinessHotel =
        Namespaced_IRI.parse _namespace_name "BusinessHotel" |> NamespacedName

    /// <summary>
    /// Refers to hotels considered luxurious
    /// <see href="https://purl.org/cityexplorer#LuxuryHotel"></see></summary>
    let LuxuryHotel =
        Namespaced_IRI.parse _namespace_name "LuxuryHotel" |> NamespacedName

    /// <summary>
    /// Refers to hotels considered rural
    /// <see href="https://purl.org/cityexplorer#RuralHotel"></see></summary>
    let RuralHotel = Namespaced_IRI.parse _namespace_name "RuralHotel" |> NamespacedName

    /// <summary>
    /// Refers to touristic hotels
    /// <see href="https://purl.org/cityexplorer#TouristHotel"></see></summary>
    let TouristHotel =
        Namespaced_IRI.parse _namespace_name "TouristHotel" |> NamespacedName

    /// <summary>
    /// Refers to bus transport
    /// <see href="https://purl.org/cityexplorer#BusTransport"></see></summary>
    let BusTransport =
        Namespaced_IRI.parse _namespace_name "BusTransport" |> NamespacedName

    /// <summary>
    /// Refers to metro transport
    /// <see href="https://purl.org/cityexplorer#MetroTransport"></see></summary>
    let MetroTransport =
        Namespaced_IRI.parse _namespace_name "MetroTransport" |> NamespacedName

    /// <summary>
    /// Refers to public bike transport
    /// <see href="https://purl.org/cityexplorer#PublicBikeTransport"></see></summary>
    let PublicBikeTransport =
        Namespaced_IRI.parse _namespace_name "PublicBikeTransport" |> NamespacedName

    /// <summary>
    /// Refers to taxi transport
    /// <see href="https://purl.org/cityexplorer#TaxiTransport"></see></summary>
    let TaxiTransport =
        Namespaced_IRI.parse _namespace_name "TaxiTransport" |> NamespacedName

    /// <summary>
    /// Refers to tram transport
    /// <see href="https://purl.org/cityexplorer#TramTransport"></see></summary>
    let TramTransport =
        Namespaced_IRI.parse _namespace_name "TramTransport" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_FiraBarcelona"></see>
    /// </summary>
    let _100_FiraBarcelona =
        Namespaced_IRI.parse _namespace_name "100_FiraBarcelona" |> NamespacedName

    /// <summary>
    /// Indicate if a class has a specific category
    /// <see href="https://purl.org/cityexplorer#hasCategory"></see></summary>
    let hasCategory =
        Namespaced_IRI.parse _namespace_name "hasCategory" |> NamespacedName

    /// <summary>
    /// The identifier of the object (city, etc.)
    /// <see href="https://purl.org/cityexplorer#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// Indicates if it's located in a city
    /// <see href="https://purl.org/cityexplorer#locatedInCity"></see></summary>
    let locatedInCity =
        Namespaced_IRI.parse _namespace_name "locatedInCity" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Barcelona"></see>
    /// </summary>
    let Barcelona = Namespaced_IRI.parse _namespace_name "Barcelona" |> NamespacedName
    /// <summary>
    /// The name of the item
    /// <see href="https://purl.org/cityexplorer#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// The start date and time of the item
    /// <see href="https://purl.org/cityexplorer#startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_HotelPalaceM%C3%A0laga"></see>
    /// </summary>
    let ``_100_HotelPalaceM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "100_HotelPalaceM%C3%A0laga" |> NamespacedName

    /// <summary>
    /// Refers to an hotel
    /// <see href="https://purl.org/cityexplorer#Hotel"></see></summary>
    let Hotel = Namespaced_IRI.parse _namespace_name "Hotel" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#M%C3%A0laga"></see>
    /// </summary>
    let ``M%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "M%C3%A0laga" |> NamespacedName

    /// <summary>
    /// An official rating for a lodging business or food establishment
    /// <see href="https://purl.org/cityexplorer#starRating"></see></summary>
    let starRating = Namespaced_IRI.parse _namespace_name "starRating" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_MuseuBilbao"></see>
    /// </summary>
    let _100_MuseuBilbao =
        Namespaced_IRI.parse _namespace_name "100_MuseuBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Bilbao"></see>
    /// </summary>
    let Bilbao = Namespaced_IRI.parse _namespace_name "Bilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_RestaurantGourmetToledo"></see>
    /// </summary>
    let _100_RestaurantGourmetToledo =
        Namespaced_IRI.parse _namespace_name "100_RestaurantGourmetToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Toledo"></see>
    /// </summary>
    let Toledo = Namespaced_IRI.parse _namespace_name "Toledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_TransPamplona"></see>
    /// </summary>
    let _100_TransPamplona =
        Namespaced_IRI.parse _namespace_name "100_TransPamplona" |> NamespacedName

    /// <summary>
    /// Refers to a way of transport
    /// <see href="https://purl.org/cityexplorer#Transport"></see></summary>
    let Transport = Namespaced_IRI.parse _namespace_name "Transport" |> NamespacedName
    /// <summary>
    /// The company of transport
    /// <see href="https://purl.org/cityexplorer#company"></see></summary>
    let company = Namespaced_IRI.parse _namespace_name "company" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Pamplona"></see>
    /// </summary>
    let Pamplona = Namespaced_IRI.parse _namespace_name "Pamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_CastellToledo"></see>
    /// </summary>
    let _10_CastellToledo =
        Namespaced_IRI.parse _namespace_name "10_CastellToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_10_Congr%C3%A9sBarcelona`` =
        Namespaced_IRI.parse _namespace_name "10_Congr%C3%A9sBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_HotelRoyalCadis"></see>
    /// </summary>
    let _10_HotelRoyalCadis =
        Namespaced_IRI.parse _namespace_name "10_HotelRoyalCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Cadis"></see>
    /// </summary>
    let Cadis = Namespaced_IRI.parse _namespace_name "Cadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_RestaurantDeliciaCadis"></see>
    /// </summary>
    let _10_RestaurantDeliciaCadis =
        Namespaced_IRI.parse _namespace_name "10_RestaurantDeliciaCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_TransSevilla"></see>
    /// </summary>
    let _10_TransSevilla =
        Namespaced_IRI.parse _namespace_name "10_TransSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Sevilla"></see>
    /// </summary>
    let Sevilla = Namespaced_IRI.parse _namespace_name "Sevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_CarnavalBilbao"></see>
    /// </summary>
    let _11_CarnavalBilbao =
        Namespaced_IRI.parse _namespace_name "11_CarnavalBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_HotelRoyalMadrid"></see>
    /// </summary>
    let _11_HotelRoyalMadrid =
        Namespaced_IRI.parse _namespace_name "11_HotelRoyalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Madrid"></see>
    /// </summary>
    let Madrid = Namespaced_IRI.parse _namespace_name "Madrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_ParcToledo"></see>
    /// </summary>
    let _11_ParcToledo =
        Namespaced_IRI.parse _namespace_name "11_ParcToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _11_RestaurantGourmetMadrid =
        Namespaced_IRI.parse _namespace_name "11_RestaurantGourmetMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_TransVal%C3%A8ncia"></see>
    /// </summary>
    let ``_11_TransVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "11_TransVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Val%C3%A8ncia"></see>
    /// </summary>
    let ``Val%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "Val%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_CatedralCadis"></see>
    /// </summary>
    let _12_CatedralCadis =
        Namespaced_IRI.parse _namespace_name "12_CatedralCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_CitySevilla"></see>
    /// </summary>
    let _12_CitySevilla =
        Namespaced_IRI.parse _namespace_name "12_CitySevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_FiraBarcelona"></see>
    /// </summary>
    let _12_FiraBarcelona =
        Namespaced_IRI.parse _namespace_name "12_FiraBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_HotelRoyalMadrid"></see>
    /// </summary>
    let _12_HotelRoyalMadrid =
        Namespaced_IRI.parse _namespace_name "12_HotelRoyalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_RestaurantSaborCadis"></see>
    /// </summary>
    let _12_RestaurantSaborCadis =
        Namespaced_IRI.parse _namespace_name "12_RestaurantSaborCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_CityCadis"></see>
    /// </summary>
    let _13_CityCadis =
        Namespaced_IRI.parse _namespace_name "13_CityCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_Congr%C3%A9sVal%C3%A8ncia"></see>
    /// </summary>
    let ``_13_Congr%C3%A9sVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "13_Congr%C3%A9sVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_HotelDelMarSevilla"></see>
    /// </summary>
    let _13_HotelDelMarSevilla =
        Namespaced_IRI.parse _namespace_name "13_HotelDelMarSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_PalauPamplona"></see>
    /// </summary>
    let _13_PalauPamplona =
        Namespaced_IRI.parse _namespace_name "13_PalauPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _13_RestaurantDeliciaSaragossa =
        Namespaced_IRI.parse _namespace_name "13_RestaurantDeliciaSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Saragossa"></see>
    /// </summary>
    let Saragossa = Namespaced_IRI.parse _namespace_name "Saragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_CastellPamplona"></see>
    /// </summary>
    let _14_CastellPamplona =
        Namespaced_IRI.parse _namespace_name "14_CastellPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_Congr%C3%A9sToledo"></see>
    /// </summary>
    let ``_14_Congr%C3%A9sToledo`` =
        Namespaced_IRI.parse _namespace_name "14_Congr%C3%A9sToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_HotelPalaceMadrid"></see>
    /// </summary>
    let _14_HotelPalaceMadrid =
        Namespaced_IRI.parse _namespace_name "14_HotelPalaceMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_MoviPamplona"></see>
    /// </summary>
    let _14_MoviPamplona =
        Namespaced_IRI.parse _namespace_name "14_MoviPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_RestaurantFusi%C3%B3Val%C3%A8ncia"></see>
    /// </summary>
    let ``_14_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "14_RestaurantFusi%C3%B3Val%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_CastellCadis"></see>
    /// </summary>
    let _15_CastellCadis =
        Namespaced_IRI.parse _namespace_name "15_CastellCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_FestivalSaragossa"></see>
    /// </summary>
    let _15_FestivalSaragossa =
        Namespaced_IRI.parse _namespace_name "15_FestivalSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_HotelPalaceCadis"></see>
    /// </summary>
    let _15_HotelPalaceCadis =
        Namespaced_IRI.parse _namespace_name "15_HotelPalaceCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_MoviCadis"></see>
    /// </summary>
    let _15_MoviCadis =
        Namespaced_IRI.parse _namespace_name "15_MoviCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _15_RestaurantDeliciaSaragossa =
        Namespaced_IRI.parse _namespace_name "15_RestaurantDeliciaSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_CastellBarcelona"></see>
    /// </summary>
    let _16_CastellBarcelona =
        Namespaced_IRI.parse _namespace_name "16_CastellBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_CityM%C3%A0laga"></see>
    /// </summary>
    let ``_16_CityM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "16_CityM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_ConcertSevilla"></see>
    /// </summary>
    let _16_ConcertSevilla =
        Namespaced_IRI.parse _namespace_name "16_ConcertSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_HotelPalaceSaragossa"></see>
    /// </summary>
    let _16_HotelPalaceSaragossa =
        Namespaced_IRI.parse _namespace_name "16_HotelPalaceSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_RestaurantFusi%C3%B3Pamplona"></see>
    /// </summary>
    let ``_16_RestaurantFusi%C3%B3Pamplona`` =
        Namespaced_IRI.parse _namespace_name "16_RestaurantFusi%C3%B3Pamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_CarnavalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_17_CarnavalVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "17_CarnavalVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_HotelDelMarToledo"></see>
    /// </summary>
    let _17_HotelDelMarToledo =
        Namespaced_IRI.parse _namespace_name "17_HotelDelMarToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_ParcMadrid"></see>
    /// </summary>
    let _17_ParcMadrid =
        Namespaced_IRI.parse _namespace_name "17_ParcMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_RestaurantGourmetCadis"></see>
    /// </summary>
    let _17_RestaurantGourmetCadis =
        Namespaced_IRI.parse _namespace_name "17_RestaurantGourmetCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_UrbanBilbao"></see>
    /// </summary>
    let _17_UrbanBilbao =
        Namespaced_IRI.parse _namespace_name "17_UrbanBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_FestivalSaragossa"></see>
    /// </summary>
    let _18_FestivalSaragossa =
        Namespaced_IRI.parse _namespace_name "18_FestivalSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_HotelPalaceMadrid"></see>
    /// </summary>
    let _18_HotelPalaceMadrid =
        Namespaced_IRI.parse _namespace_name "18_HotelPalaceMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_MetroBilbao"></see>
    /// </summary>
    let _18_MetroBilbao =
        Namespaced_IRI.parse _namespace_name "18_MetroBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_MuseuM%C3%A0laga"></see>
    /// </summary>
    let ``_18_MuseuM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "18_MuseuM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_RestaurantSaborCadis"></see>
    /// </summary>
    let _18_RestaurantSaborCadis =
        Namespaced_IRI.parse _namespace_name "18_RestaurantSaborCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_CityBilbao"></see>
    /// </summary>
    let _19_CityBilbao =
        Namespaced_IRI.parse _namespace_name "19_CityBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_ConcertVal%C3%A8ncia"></see>
    /// </summary>
    let ``_19_ConcertVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "19_ConcertVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_HotelSolBilbao"></see>
    /// </summary>
    let _19_HotelSolBilbao =
        Namespaced_IRI.parse _namespace_name "19_HotelSolBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_PalauBarcelona"></see>
    /// </summary>
    let _19_PalauBarcelona =
        Namespaced_IRI.parse _namespace_name "19_PalauBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_RestaurantFusi%C3%B3Madrid"></see>
    /// </summary>
    let ``_19_RestaurantFusi%C3%B3Madrid`` =
        Namespaced_IRI.parse _namespace_name "19_RestaurantFusi%C3%B3Madrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_CastellSaragossa"></see>
    /// </summary>
    let _1_CastellSaragossa =
        Namespaced_IRI.parse _namespace_name "1_CastellSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_Congr%C3%A9sCadis"></see>
    /// </summary>
    let ``_1_Congr%C3%A9sCadis`` =
        Namespaced_IRI.parse _namespace_name "1_Congr%C3%A9sCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_HotelVistaSevilla"></see>
    /// </summary>
    let _1_HotelVistaSevilla =
        Namespaced_IRI.parse _namespace_name "1_HotelVistaSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_RestaurantTradici%C3%B3Toledo"></see>
    /// </summary>
    let ``_1_RestaurantTradici%C3%B3Toledo`` =
        Namespaced_IRI.parse _namespace_name "1_RestaurantTradici%C3%B3Toledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_UrbanMadrid"></see>
    /// </summary>
    let _1_UrbanMadrid =
        Namespaced_IRI.parse _namespace_name "1_UrbanMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_CarnavalSevilla"></see>
    /// </summary>
    let _20_CarnavalSevilla =
        Namespaced_IRI.parse _namespace_name "20_CarnavalSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_CatedralBarcelona"></see>
    /// </summary>
    let _20_CatedralBarcelona =
        Namespaced_IRI.parse _namespace_name "20_CatedralBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_HotelVistaVal%C3%A8ncia"></see>
    /// </summary>
    let ``_20_HotelVistaVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "20_HotelVistaVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_MoviBilbao"></see>
    /// </summary>
    let _20_MoviBilbao =
        Namespaced_IRI.parse _namespace_name "20_MoviBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_20_RestaurantGourmetM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "20_RestaurantGourmetM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_CatedralM%C3%A0laga"></see>
    /// </summary>
    let ``_21_CatedralM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "21_CatedralM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_CityPamplona"></see>
    /// </summary>
    let _21_CityPamplona =
        Namespaced_IRI.parse _namespace_name "21_CityPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_FiraSevilla"></see>
    /// </summary>
    let _21_FiraSevilla =
        Namespaced_IRI.parse _namespace_name "21_FiraSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_HotelSolVal%C3%A8ncia"></see>
    /// </summary>
    let ``_21_HotelSolVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "21_HotelSolVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_RestaurantDeliciaMadrid"></see>
    /// </summary>
    let _21_RestaurantDeliciaMadrid =
        Namespaced_IRI.parse _namespace_name "21_RestaurantDeliciaMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_22_CatedralVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "22_CatedralVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_FestivalSevilla"></see>
    /// </summary>
    let _22_FestivalSevilla =
        Namespaced_IRI.parse _namespace_name "22_FestivalSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_HotelVistaM%C3%A0laga"></see>
    /// </summary>
    let ``_22_HotelVistaM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "22_HotelVistaM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_RestaurantTradici%C3%B3Madrid"></see>
    /// </summary>
    let ``_22_RestaurantTradici%C3%B3Madrid`` =
        Namespaced_IRI.parse _namespace_name "22_RestaurantTradici%C3%B3Madrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_UrbanSaragossa"></see>
    /// </summary>
    let _22_UrbanSaragossa =
        Namespaced_IRI.parse _namespace_name "22_UrbanSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_CastellSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_23_CastellSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "23_CastellSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#SantSebasti%C3%A0"></see>
    /// </summary>
    let ``SantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "SantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_Congr%C3%A9sSaragossa"></see>
    /// </summary>
    let ``_23_Congr%C3%A9sSaragossa`` =
        Namespaced_IRI.parse _namespace_name "23_Congr%C3%A9sSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_HotelVistaToledo"></see>
    /// </summary>
    let _23_HotelVistaToledo =
        Namespaced_IRI.parse _namespace_name "23_HotelVistaToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_MoviPamplona"></see>
    /// </summary>
    let _23_MoviPamplona =
        Namespaced_IRI.parse _namespace_name "23_MoviPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_RestaurantFusi%C3%B3Sevilla"></see>
    /// </summary>
    let ``_23_RestaurantFusi%C3%B3Sevilla`` =
        Namespaced_IRI.parse _namespace_name "23_RestaurantFusi%C3%B3Sevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_CastellSaragossa"></see>
    /// </summary>
    let _24_CastellSaragossa =
        Namespaced_IRI.parse _namespace_name "24_CastellSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_24_Congr%C3%A9sBarcelona`` =
        Namespaced_IRI.parse _namespace_name "24_Congr%C3%A9sBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_HotelRoyalSaragossa"></see>
    /// </summary>
    let _24_HotelRoyalSaragossa =
        Namespaced_IRI.parse _namespace_name "24_HotelRoyalSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_RestaurantGourmetSevilla"></see>
    /// </summary>
    let _24_RestaurantGourmetSevilla =
        Namespaced_IRI.parse _namespace_name "24_RestaurantGourmetSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_UrbanVal%C3%A8ncia"></see>
    /// </summary>
    let ``_24_UrbanVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "24_UrbanVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_CarnavalM%C3%A0laga"></see>
    /// </summary>
    let ``_25_CarnavalM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "25_CarnavalM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_HotelRoyalSevilla"></see>
    /// </summary>
    let _25_HotelRoyalSevilla =
        Namespaced_IRI.parse _namespace_name "25_HotelRoyalSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_MetroSaragossa"></see>
    /// </summary>
    let _25_MetroSaragossa =
        Namespaced_IRI.parse _namespace_name "25_MetroSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_ParcBilbao"></see>
    /// </summary>
    let _25_ParcBilbao =
        Namespaced_IRI.parse _namespace_name "25_ParcBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_RestaurantFusi%C3%B3Sevilla"></see>
    /// </summary>
    let ``_25_RestaurantFusi%C3%B3Sevilla`` =
        Namespaced_IRI.parse _namespace_name "25_RestaurantFusi%C3%B3Sevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_CarnavalBilbao"></see>
    /// </summary>
    let _26_CarnavalBilbao =
        Namespaced_IRI.parse _namespace_name "26_CarnavalBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_CatedralSaragossa"></see>
    /// </summary>
    let _26_CatedralSaragossa =
        Namespaced_IRI.parse _namespace_name "26_CatedralSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_HotelSolCadis"></see>
    /// </summary>
    let _26_HotelSolCadis =
        Namespaced_IRI.parse _namespace_name "26_HotelSolCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_MetroPamplona"></see>
    /// </summary>
    let _26_MetroPamplona =
        Namespaced_IRI.parse _namespace_name "26_MetroPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_RestaurantGourmetPamplona"></see>
    /// </summary>
    let _26_RestaurantGourmetPamplona =
        Namespaced_IRI.parse _namespace_name "26_RestaurantGourmetPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_CastellM%C3%A0laga"></see>
    /// </summary>
    let ``_27_CastellM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "27_CastellM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_Congr%C3%A9sBilbao"></see>
    /// </summary>
    let ``_27_Congr%C3%A9sBilbao`` =
        Namespaced_IRI.parse _namespace_name "27_Congr%C3%A9sBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_HotelSolBilbao"></see>
    /// </summary>
    let _27_HotelSolBilbao =
        Namespaced_IRI.parse _namespace_name "27_HotelSolBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_RestaurantTradici%C3%B3SantSebasti%C3%A0"></see>
    /// </summary>
    let ``_27_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "27_RestaurantTradici%C3%B3SantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_UrbanBarcelona"></see>
    /// </summary>
    let _27_UrbanBarcelona =
        Namespaced_IRI.parse _namespace_name "27_UrbanBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_FestivalToledo"></see>
    /// </summary>
    let _28_FestivalToledo =
        Namespaced_IRI.parse _namespace_name "28_FestivalToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_HotelDelMarSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_28_HotelDelMarSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "28_HotelDelMarSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_ParcSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_28_ParcSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "28_ParcSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_RestaurantFusi%C3%B3Cadis"></see>
    /// </summary>
    let ``_28_RestaurantFusi%C3%B3Cadis`` =
        Namespaced_IRI.parse _namespace_name "28_RestaurantFusi%C3%B3Cadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_UrbanPamplona"></see>
    /// </summary>
    let _28_UrbanPamplona =
        Namespaced_IRI.parse _namespace_name "28_UrbanPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_CastellSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_29_CastellSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "29_CastellSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_FiraMadrid"></see>
    /// </summary>
    let _29_FiraMadrid =
        Namespaced_IRI.parse _namespace_name "29_FiraMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_HotelRoyalMadrid"></see>
    /// </summary>
    let _29_HotelRoyalMadrid =
        Namespaced_IRI.parse _namespace_name "29_HotelRoyalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_MetroSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_29_MetroSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "29_MetroSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_RestaurantDeliciaVal%C3%A8ncia"></see>
    /// </summary>
    let ``_29_RestaurantDeliciaVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "29_RestaurantDeliciaVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_CarnavalCadis"></see>
    /// </summary>
    let _2_CarnavalCadis =
        Namespaced_IRI.parse _namespace_name "2_CarnavalCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_CastellSevilla"></see>
    /// </summary>
    let _2_CastellSevilla =
        Namespaced_IRI.parse _namespace_name "2_CastellSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_HotelRoyalPamplona"></see>
    /// </summary>
    let _2_HotelRoyalPamplona =
        Namespaced_IRI.parse _namespace_name "2_HotelRoyalPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _2_RestaurantGourmetMadrid =
        Namespaced_IRI.parse _namespace_name "2_RestaurantGourmetMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_TransBilbao"></see>
    /// </summary>
    let _2_TransBilbao =
        Namespaced_IRI.parse _namespace_name "2_TransBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_CastellVal%C3%A8ncia"></see>
    /// </summary>
    let ``_30_CastellVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "30_CastellVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_FestivalMadrid"></see>
    /// </summary>
    let _30_FestivalMadrid =
        Namespaced_IRI.parse _namespace_name "30_FestivalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_HotelDelMarPamplona"></see>
    /// </summary>
    let _30_HotelDelMarPamplona =
        Namespaced_IRI.parse _namespace_name "30_HotelDelMarPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_RestaurantDeliciaPamplona"></see>
    /// </summary>
    let _30_RestaurantDeliciaPamplona =
        Namespaced_IRI.parse _namespace_name "30_RestaurantDeliciaPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_UrbanM%C3%A0laga"></see>
    /// </summary>
    let ``_30_UrbanM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "30_UrbanM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_FiraMadrid"></see>
    /// </summary>
    let _31_FiraMadrid =
        Namespaced_IRI.parse _namespace_name "31_FiraMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_HotelVistaMadrid"></see>
    /// </summary>
    let _31_HotelVistaMadrid =
        Namespaced_IRI.parse _namespace_name "31_HotelVistaMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_PalauM%C3%A0laga"></see>
    /// </summary>
    let ``_31_PalauM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "31_PalauM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_RestaurantTradici%C3%B3Madrid"></see>
    /// </summary>
    let ``_31_RestaurantTradici%C3%B3Madrid`` =
        Namespaced_IRI.parse _namespace_name "31_RestaurantTradici%C3%B3Madrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_UrbanSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_31_UrbanSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "31_UrbanSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_ConcertPamplona"></see>
    /// </summary>
    let _32_ConcertPamplona =
        Namespaced_IRI.parse _namespace_name "32_ConcertPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_HotelPalaceToledo"></see>
    /// </summary>
    let _32_HotelPalaceToledo =
        Namespaced_IRI.parse _namespace_name "32_HotelPalaceToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_MetroMadrid"></see>
    /// </summary>
    let _32_MetroMadrid =
        Namespaced_IRI.parse _namespace_name "32_MetroMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_MuseuSaragossa"></see>
    /// </summary>
    let _32_MuseuSaragossa =
        Namespaced_IRI.parse _namespace_name "32_MuseuSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _32_RestaurantGourmetMadrid =
        Namespaced_IRI.parse _namespace_name "32_RestaurantGourmetMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_FestivalBarcelona"></see>
    /// </summary>
    let _33_FestivalBarcelona =
        Namespaced_IRI.parse _namespace_name "33_FestivalBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_HotelSolBarcelona"></see>
    /// </summary>
    let _33_HotelSolBarcelona =
        Namespaced_IRI.parse _namespace_name "33_HotelSolBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_MetroMadrid"></see>
    /// </summary>
    let _33_MetroMadrid =
        Namespaced_IRI.parse _namespace_name "33_MetroMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_MuseuBarcelona"></see>
    /// </summary>
    let _33_MuseuBarcelona =
        Namespaced_IRI.parse _namespace_name "33_MuseuBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_RestaurantTradici%C3%B3Toledo"></see>
    /// </summary>
    let ``_33_RestaurantTradici%C3%B3Toledo`` =
        Namespaced_IRI.parse _namespace_name "33_RestaurantTradici%C3%B3Toledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_CarnavalSaragossa"></see>
    /// </summary>
    let _34_CarnavalSaragossa =
        Namespaced_IRI.parse _namespace_name "34_CarnavalSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_HotelDelMarBarcelona"></see>
    /// </summary>
    let _34_HotelDelMarBarcelona =
        Namespaced_IRI.parse _namespace_name "34_HotelDelMarBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_MuseuSaragossa"></see>
    /// </summary>
    let _34_MuseuSaragossa =
        Namespaced_IRI.parse _namespace_name "34_MuseuSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_RestaurantDeliciaSevilla"></see>
    /// </summary>
    let _34_RestaurantDeliciaSevilla =
        Namespaced_IRI.parse _namespace_name "34_RestaurantDeliciaSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_UrbanSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_34_UrbanSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "34_UrbanSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_ConcertToledo"></see>
    /// </summary>
    let _35_ConcertToledo =
        Namespaced_IRI.parse _namespace_name "35_ConcertToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_HotelDelMarPamplona"></see>
    /// </summary>
    let _35_HotelDelMarPamplona =
        Namespaced_IRI.parse _namespace_name "35_HotelDelMarPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_MetroBilbao"></see>
    /// </summary>
    let _35_MetroBilbao =
        Namespaced_IRI.parse _namespace_name "35_MetroBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_PalauPamplona"></see>
    /// </summary>
    let _35_PalauPamplona =
        Namespaced_IRI.parse _namespace_name "35_PalauPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_RestaurantDeliciaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_35_RestaurantDeliciaSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "35_RestaurantDeliciaSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_CityBarcelona"></see>
    /// </summary>
    let _36_CityBarcelona =
        Namespaced_IRI.parse _namespace_name "36_CityBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_ConcertPamplona"></see>
    /// </summary>
    let _36_ConcertPamplona =
        Namespaced_IRI.parse _namespace_name "36_ConcertPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_HotelPalaceSaragossa"></see>
    /// </summary>
    let _36_HotelPalaceSaragossa =
        Namespaced_IRI.parse _namespace_name "36_HotelPalaceSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_ParcPamplona"></see>
    /// </summary>
    let _36_ParcPamplona =
        Namespaced_IRI.parse _namespace_name "36_ParcPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_RestaurantFusi%C3%B3Saragossa"></see>
    /// </summary>
    let ``_36_RestaurantFusi%C3%B3Saragossa`` =
        Namespaced_IRI.parse _namespace_name "36_RestaurantFusi%C3%B3Saragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_CastellMadrid"></see>
    /// </summary>
    let _37_CastellMadrid =
        Namespaced_IRI.parse _namespace_name "37_CastellMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_FestivalMadrid"></see>
    /// </summary>
    let _37_FestivalMadrid =
        Namespaced_IRI.parse _namespace_name "37_FestivalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_HotelDelMarVal%C3%A8ncia"></see>
    /// </summary>
    let ``_37_HotelDelMarVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "37_HotelDelMarVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_RestaurantSaborVal%C3%A8ncia"></see>
    /// </summary>
    let ``_37_RestaurantSaborVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "37_RestaurantSaborVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_TransM%C3%A0laga"></see>
    /// </summary>
    let ``_37_TransM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "37_TransM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_CarnavalSevilla"></see>
    /// </summary>
    let _38_CarnavalSevilla =
        Namespaced_IRI.parse _namespace_name "38_CarnavalSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_HotelDelMarM%C3%A0laga"></see>
    /// </summary>
    let ``_38_HotelDelMarM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "38_HotelDelMarM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_MoviMadrid"></see>
    /// </summary>
    let _38_MoviMadrid =
        Namespaced_IRI.parse _namespace_name "38_MoviMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_PalauToledo"></see>
    /// </summary>
    let _38_PalauToledo =
        Namespaced_IRI.parse _namespace_name "38_PalauToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_RestaurantDeliciaPamplona"></see>
    /// </summary>
    let _38_RestaurantDeliciaPamplona =
        Namespaced_IRI.parse _namespace_name "38_RestaurantDeliciaPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_CastellSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_39_CastellSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "39_CastellSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_FiraBarcelona"></see>
    /// </summary>
    let _39_FiraBarcelona =
        Namespaced_IRI.parse _namespace_name "39_FiraBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_HotelSolSaragossa"></see>
    /// </summary>
    let _39_HotelSolSaragossa =
        Namespaced_IRI.parse _namespace_name "39_HotelSolSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_MoviSevilla"></see>
    /// </summary>
    let _39_MoviSevilla =
        Namespaced_IRI.parse _namespace_name "39_MoviSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_RestaurantFusi%C3%B3Toledo"></see>
    /// </summary>
    let ``_39_RestaurantFusi%C3%B3Toledo`` =
        Namespaced_IRI.parse _namespace_name "39_RestaurantFusi%C3%B3Toledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_CastellSaragossa"></see>
    /// </summary>
    let _3_CastellSaragossa =
        Namespaced_IRI.parse _namespace_name "3_CastellSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_Congr%C3%A9sBilbao"></see>
    /// </summary>
    let ``_3_Congr%C3%A9sBilbao`` =
        Namespaced_IRI.parse _namespace_name "3_Congr%C3%A9sBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_HotelRoyalM%C3%A0laga"></see>
    /// </summary>
    let ``_3_HotelRoyalM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "3_HotelRoyalM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_RestaurantFusi%C3%B3Val%C3%A8ncia"></see>
    /// </summary>
    let ``_3_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "3_RestaurantFusi%C3%B3Val%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_TransToledo"></see>
    /// </summary>
    let _3_TransToledo =
        Namespaced_IRI.parse _namespace_name "3_TransToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_FestivalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_40_FestivalVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "40_FestivalVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_HotelDelMarSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_40_HotelDelMarSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "40_HotelDelMarSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_PalauCadis"></see>
    /// </summary>
    let _40_PalauCadis =
        Namespaced_IRI.parse _namespace_name "40_PalauCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_RestaurantGourmetVal%C3%A8ncia"></see>
    /// </summary>
    let ``_40_RestaurantGourmetVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "40_RestaurantGourmetVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_UrbanToledo"></see>
    /// </summary>
    let _40_UrbanToledo =
        Namespaced_IRI.parse _namespace_name "40_UrbanToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_CatedralToledo"></see>
    /// </summary>
    let _41_CatedralToledo =
        Namespaced_IRI.parse _namespace_name "41_CatedralToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_ConcertToledo"></see>
    /// </summary>
    let _41_ConcertToledo =
        Namespaced_IRI.parse _namespace_name "41_ConcertToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_HotelRoyalCadis"></see>
    /// </summary>
    let _41_HotelRoyalCadis =
        Namespaced_IRI.parse _namespace_name "41_HotelRoyalCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_MetroBarcelona"></see>
    /// </summary>
    let _41_MetroBarcelona =
        Namespaced_IRI.parse _namespace_name "41_MetroBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_RestaurantTradici%C3%B3Saragossa"></see>
    /// </summary>
    let ``_41_RestaurantTradici%C3%B3Saragossa`` =
        Namespaced_IRI.parse _namespace_name "41_RestaurantTradici%C3%B3Saragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_FestivalPamplona"></see>
    /// </summary>
    let _42_FestivalPamplona =
        Namespaced_IRI.parse _namespace_name "42_FestivalPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_HotelPalaceMadrid"></see>
    /// </summary>
    let _42_HotelPalaceMadrid =
        Namespaced_IRI.parse _namespace_name "42_HotelPalaceMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_MuseuMadrid"></see>
    /// </summary>
    let _42_MuseuMadrid =
        Namespaced_IRI.parse _namespace_name "42_MuseuMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_RestaurantTradici%C3%B3Sevilla"></see>
    /// </summary>
    let ``_42_RestaurantTradici%C3%B3Sevilla`` =
        Namespaced_IRI.parse _namespace_name "42_RestaurantTradici%C3%B3Sevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_UrbanSevilla"></see>
    /// </summary>
    let _42_UrbanSevilla =
        Namespaced_IRI.parse _namespace_name "42_UrbanSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_CityPamplona"></see>
    /// </summary>
    let _43_CityPamplona =
        Namespaced_IRI.parse _namespace_name "43_CityPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_FestivalMadrid"></see>
    /// </summary>
    let _43_FestivalMadrid =
        Namespaced_IRI.parse _namespace_name "43_FestivalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_HotelRoyalPamplona"></see>
    /// </summary>
    let _43_HotelRoyalPamplona =
        Namespaced_IRI.parse _namespace_name "43_HotelRoyalPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_ParcBarcelona"></see>
    /// </summary>
    let _43_ParcBarcelona =
        Namespaced_IRI.parse _namespace_name "43_ParcBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_RestaurantFusi%C3%B3Barcelona"></see>
    /// </summary>
    let ``_43_RestaurantFusi%C3%B3Barcelona`` =
        Namespaced_IRI.parse _namespace_name "43_RestaurantFusi%C3%B3Barcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_Congr%C3%A9sSevilla"></see>
    /// </summary>
    let ``_44_Congr%C3%A9sSevilla`` =
        Namespaced_IRI.parse _namespace_name "44_Congr%C3%A9sSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_HotelVistaSaragossa"></see>
    /// </summary>
    let _44_HotelVistaSaragossa =
        Namespaced_IRI.parse _namespace_name "44_HotelVistaSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_MoviSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_44_MoviSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "44_MoviSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_MuseuSevilla"></see>
    /// </summary>
    let _44_MuseuSevilla =
        Namespaced_IRI.parse _namespace_name "44_MuseuSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_44_RestaurantGourmetM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "44_RestaurantGourmetM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_CatedralBarcelona"></see>
    /// </summary>
    let _45_CatedralBarcelona =
        Namespaced_IRI.parse _namespace_name "45_CatedralBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_45_Congr%C3%A9sBarcelona`` =
        Namespaced_IRI.parse _namespace_name "45_Congr%C3%A9sBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_HotelRoyalBarcelona"></see>
    /// </summary>
    let _45_HotelRoyalBarcelona =
        Namespaced_IRI.parse _namespace_name "45_HotelRoyalBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_MetroPamplona"></see>
    /// </summary>
    let _45_MetroPamplona =
        Namespaced_IRI.parse _namespace_name "45_MetroPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_RestaurantFusi%C3%B3Saragossa"></see>
    /// </summary>
    let ``_45_RestaurantFusi%C3%B3Saragossa`` =
        Namespaced_IRI.parse _namespace_name "45_RestaurantFusi%C3%B3Saragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_Congr%C3%A9sVal%C3%A8ncia"></see>
    /// </summary>
    let ``_46_Congr%C3%A9sVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "46_Congr%C3%A9sVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_HotelVistaSevilla"></see>
    /// </summary>
    let _46_HotelVistaSevilla =
        Namespaced_IRI.parse _namespace_name "46_HotelVistaSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_MetroPamplona"></see>
    /// </summary>
    let _46_MetroPamplona =
        Namespaced_IRI.parse _namespace_name "46_MetroPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_MuseuToledo"></see>
    /// </summary>
    let _46_MuseuToledo =
        Namespaced_IRI.parse _namespace_name "46_MuseuToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_RestaurantSaborM%C3%A0laga"></see>
    /// </summary>
    let ``_46_RestaurantSaborM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "46_RestaurantSaborM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_FestivalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_47_FestivalVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "47_FestivalVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_HotelDelMarSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_47_HotelDelMarSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "47_HotelDelMarSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_MoviSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_47_MoviSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "47_MoviSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_PalauToledo"></see>
    /// </summary>
    let _47_PalauToledo =
        Namespaced_IRI.parse _namespace_name "47_PalauToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_RestaurantTradici%C3%B3SantSebasti%C3%A0"></see>
    /// </summary>
    let ``_47_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "47_RestaurantTradici%C3%B3SantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_FestivalBilbao"></see>
    /// </summary>
    let _48_FestivalBilbao =
        Namespaced_IRI.parse _namespace_name "48_FestivalBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_HotelPalaceM%C3%A0laga"></see>
    /// </summary>
    let ``_48_HotelPalaceM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "48_HotelPalaceM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_MoviToledo"></see>
    /// </summary>
    let _48_MoviToledo =
        Namespaced_IRI.parse _namespace_name "48_MoviToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_ParcSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_48_ParcSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "48_ParcSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_RestaurantSaborSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_48_RestaurantSaborSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "48_RestaurantSaborSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_CastellSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_49_CastellSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "49_CastellSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_CityMadrid"></see>
    /// </summary>
    let _49_CityMadrid =
        Namespaced_IRI.parse _namespace_name "49_CityMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_ConcertSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_49_ConcertSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "49_ConcertSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_HotelVistaPamplona"></see>
    /// </summary>
    let _49_HotelVistaPamplona =
        Namespaced_IRI.parse _namespace_name "49_HotelVistaPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_RestaurantSaborM%C3%A0laga"></see>
    /// </summary>
    let ``_49_RestaurantSaborM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "49_RestaurantSaborM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_CarnavalSevilla"></see>
    /// </summary>
    let _4_CarnavalSevilla =
        Namespaced_IRI.parse _namespace_name "4_CarnavalSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_CitySaragossa"></see>
    /// </summary>
    let _4_CitySaragossa =
        Namespaced_IRI.parse _namespace_name "4_CitySaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_HotelRoyalBilbao"></see>
    /// </summary>
    let _4_HotelRoyalBilbao =
        Namespaced_IRI.parse _namespace_name "4_HotelRoyalBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_MuseuMadrid"></see>
    /// </summary>
    let _4_MuseuMadrid =
        Namespaced_IRI.parse _namespace_name "4_MuseuMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_RestaurantDeliciaM%C3%A0laga"></see>
    /// </summary>
    let ``_4_RestaurantDeliciaM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "4_RestaurantDeliciaM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_FestivalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_50_FestivalVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "50_FestivalVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_HotelSolCadis"></see>
    /// </summary>
    let _50_HotelSolCadis =
        Namespaced_IRI.parse _namespace_name "50_HotelSolCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_ParcM%C3%A0laga"></see>
    /// </summary>
    let ``_50_ParcM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "50_ParcM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_RestaurantDeliciaBarcelona"></see>
    /// </summary>
    let _50_RestaurantDeliciaBarcelona =
        Namespaced_IRI.parse _namespace_name "50_RestaurantDeliciaBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_UrbanSaragossa"></see>
    /// </summary>
    let _50_UrbanSaragossa =
        Namespaced_IRI.parse _namespace_name "50_UrbanSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_CarnavalM%C3%A0laga"></see>
    /// </summary>
    let ``_51_CarnavalM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "51_CarnavalM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_HotelPalacePamplona"></see>
    /// </summary>
    let _51_HotelPalacePamplona =
        Namespaced_IRI.parse _namespace_name "51_HotelPalacePamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_PalauMadrid"></see>
    /// </summary>
    let _51_PalauMadrid =
        Namespaced_IRI.parse _namespace_name "51_PalauMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_RestaurantDeliciaSevilla"></see>
    /// </summary>
    let _51_RestaurantDeliciaSevilla =
        Namespaced_IRI.parse _namespace_name "51_RestaurantDeliciaSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_UrbanMadrid"></see>
    /// </summary>
    let _51_UrbanMadrid =
        Namespaced_IRI.parse _namespace_name "51_UrbanMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_CatedralMadrid"></see>
    /// </summary>
    let _52_CatedralMadrid =
        Namespaced_IRI.parse _namespace_name "52_CatedralMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_Congr%C3%A9sToledo"></see>
    /// </summary>
    let ``_52_Congr%C3%A9sToledo`` =
        Namespaced_IRI.parse _namespace_name "52_Congr%C3%A9sToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_HotelSolSevilla"></see>
    /// </summary>
    let _52_HotelSolSevilla =
        Namespaced_IRI.parse _namespace_name "52_HotelSolSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _52_RestaurantDeliciaSaragossa =
        Namespaced_IRI.parse _namespace_name "52_RestaurantDeliciaSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_TransMadrid"></see>
    /// </summary>
    let _52_TransMadrid =
        Namespaced_IRI.parse _namespace_name "52_TransMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_53_CatedralVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "53_CatedralVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_FiraBarcelona"></see>
    /// </summary>
    let _53_FiraBarcelona =
        Namespaced_IRI.parse _namespace_name "53_FiraBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_HotelDelMarM%C3%A0laga"></see>
    /// </summary>
    let ``_53_HotelDelMarM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "53_HotelDelMarM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_RestaurantDeliciaCadis"></see>
    /// </summary>
    let _53_RestaurantDeliciaCadis =
        Namespaced_IRI.parse _namespace_name "53_RestaurantDeliciaCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_UrbanToledo"></see>
    /// </summary>
    let _53_UrbanToledo =
        Namespaced_IRI.parse _namespace_name "53_UrbanToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_CatedralToledo"></see>
    /// </summary>
    let _54_CatedralToledo =
        Namespaced_IRI.parse _namespace_name "54_CatedralToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_FiraPamplona"></see>
    /// </summary>
    let _54_FiraPamplona =
        Namespaced_IRI.parse _namespace_name "54_FiraPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_HotelPalaceToledo"></see>
    /// </summary>
    let _54_HotelPalaceToledo =
        Namespaced_IRI.parse _namespace_name "54_HotelPalaceToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_MetroM%C3%A0laga"></see>
    /// </summary>
    let ``_54_MetroM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "54_MetroM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_RestaurantSaborSevilla"></see>
    /// </summary>
    let _54_RestaurantSaborSevilla =
        Namespaced_IRI.parse _namespace_name "54_RestaurantSaborSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_FiraSaragossa"></see>
    /// </summary>
    let _55_FiraSaragossa =
        Namespaced_IRI.parse _namespace_name "55_FiraSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_HotelVistaCadis"></see>
    /// </summary>
    let _55_HotelVistaCadis =
        Namespaced_IRI.parse _namespace_name "55_HotelVistaCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_MoviToledo"></see>
    /// </summary>
    let _55_MoviToledo =
        Namespaced_IRI.parse _namespace_name "55_MoviToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_ParcSaragossa"></see>
    /// </summary>
    let _55_ParcSaragossa =
        Namespaced_IRI.parse _namespace_name "55_ParcSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_RestaurantFusi%C3%B3M%C3%A0laga"></see>
    /// </summary>
    let ``_55_RestaurantFusi%C3%B3M%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "55_RestaurantFusi%C3%B3M%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_FestivalBarcelona"></see>
    /// </summary>
    let _56_FestivalBarcelona =
        Namespaced_IRI.parse _namespace_name "56_FestivalBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_HotelDelMarCadis"></see>
    /// </summary>
    let _56_HotelDelMarCadis =
        Namespaced_IRI.parse _namespace_name "56_HotelDelMarCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_MuseuToledo"></see>
    /// </summary>
    let _56_MuseuToledo =
        Namespaced_IRI.parse _namespace_name "56_MuseuToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_RestaurantTradici%C3%B3Madrid"></see>
    /// </summary>
    let ``_56_RestaurantTradici%C3%B3Madrid`` =
        Namespaced_IRI.parse _namespace_name "56_RestaurantTradici%C3%B3Madrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_TransVal%C3%A8ncia"></see>
    /// </summary>
    let ``_56_TransVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "56_TransVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_57_Congr%C3%A9sBarcelona`` =
        Namespaced_IRI.parse _namespace_name "57_Congr%C3%A9sBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_HotelSolSevilla"></see>
    /// </summary>
    let _57_HotelSolSevilla =
        Namespaced_IRI.parse _namespace_name "57_HotelSolSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_MoviVal%C3%A8ncia"></see>
    /// </summary>
    let ``_57_MoviVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "57_MoviVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_ParcCadis"></see>
    /// </summary>
    let _57_ParcCadis =
        Namespaced_IRI.parse _namespace_name "57_ParcCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_57_RestaurantGourmetM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "57_RestaurantGourmetM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_CarnavalSevilla"></see>
    /// </summary>
    let _58_CarnavalSevilla =
        Namespaced_IRI.parse _namespace_name "58_CarnavalSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_CatedralM%C3%A0laga"></see>
    /// </summary>
    let ``_58_CatedralM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "58_CatedralM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_HotelDelMarSevilla"></see>
    /// </summary>
    let _58_HotelDelMarSevilla =
        Namespaced_IRI.parse _namespace_name "58_HotelDelMarSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_MoviPamplona"></see>
    /// </summary>
    let _58_MoviPamplona =
        Namespaced_IRI.parse _namespace_name "58_MoviPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _58_RestaurantDeliciaSaragossa =
        Namespaced_IRI.parse _namespace_name "58_RestaurantDeliciaSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_CatedralBilbao"></see>
    /// </summary>
    let _59_CatedralBilbao =
        Namespaced_IRI.parse _namespace_name "59_CatedralBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_FestivalM%C3%A0laga"></see>
    /// </summary>
    let ``_59_FestivalM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "59_FestivalM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_HotelVistaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_59_HotelVistaSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "59_HotelVistaSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_MetroSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_59_MetroSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "59_MetroSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_RestaurantFusi%C3%B3Cadis"></see>
    /// </summary>
    let ``_59_RestaurantFusi%C3%B3Cadis`` =
        Namespaced_IRI.parse _namespace_name "59_RestaurantFusi%C3%B3Cadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_CastellCadis"></see>
    /// </summary>
    let _5_CastellCadis =
        Namespaced_IRI.parse _namespace_name "5_CastellCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_FiraToledo"></see>
    /// </summary>
    let _5_FiraToledo =
        Namespaced_IRI.parse _namespace_name "5_FiraToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_HotelPalaceSaragossa"></see>
    /// </summary>
    let _5_HotelPalaceSaragossa =
        Namespaced_IRI.parse _namespace_name "5_HotelPalaceSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_MoviCadis"></see>
    /// </summary>
    let _5_MoviCadis =
        Namespaced_IRI.parse _namespace_name "5_MoviCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_RestaurantDeliciaPamplona"></see>
    /// </summary>
    let _5_RestaurantDeliciaPamplona =
        Namespaced_IRI.parse _namespace_name "5_RestaurantDeliciaPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_FiraSevilla"></see>
    /// </summary>
    let _60_FiraSevilla =
        Namespaced_IRI.parse _namespace_name "60_FiraSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_HotelDelMarBarcelona"></see>
    /// </summary>
    let _60_HotelDelMarBarcelona =
        Namespaced_IRI.parse _namespace_name "60_HotelDelMarBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_ParcCadis"></see>
    /// </summary>
    let _60_ParcCadis =
        Namespaced_IRI.parse _namespace_name "60_ParcCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_RestaurantDeliciaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_60_RestaurantDeliciaSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "60_RestaurantDeliciaSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_UrbanMadrid"></see>
    /// </summary>
    let _60_UrbanMadrid =
        Namespaced_IRI.parse _namespace_name "60_UrbanMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_CarnavalToledo"></see>
    /// </summary>
    let _61_CarnavalToledo =
        Namespaced_IRI.parse _namespace_name "61_CarnavalToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_HotelDelMarCadis"></see>
    /// </summary>
    let _61_HotelDelMarCadis =
        Namespaced_IRI.parse _namespace_name "61_HotelDelMarCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_MetroBilbao"></see>
    /// </summary>
    let _61_MetroBilbao =
        Namespaced_IRI.parse _namespace_name "61_MetroBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_PalauSaragossa"></see>
    /// </summary>
    let _61_PalauSaragossa =
        Namespaced_IRI.parse _namespace_name "61_PalauSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _61_RestaurantGourmetMadrid =
        Namespaced_IRI.parse _namespace_name "61_RestaurantGourmetMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_CarnavalCadis"></see>
    /// </summary>
    let _62_CarnavalCadis =
        Namespaced_IRI.parse _namespace_name "62_CarnavalCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_62_CatedralVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "62_CatedralVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_CityCadis"></see>
    /// </summary>
    let _62_CityCadis =
        Namespaced_IRI.parse _namespace_name "62_CityCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_HotelPalaceBarcelona"></see>
    /// </summary>
    let _62_HotelPalaceBarcelona =
        Namespaced_IRI.parse _namespace_name "62_HotelPalaceBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_RestaurantTradici%C3%B3SantSebasti%C3%A0"></see>
    /// </summary>
    let ``_62_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "62_RestaurantTradici%C3%B3SantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_FiraM%C3%A0laga"></see>
    /// </summary>
    let ``_63_FiraM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "63_FiraM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_HotelSolBarcelona"></see>
    /// </summary>
    let _63_HotelSolBarcelona =
        Namespaced_IRI.parse _namespace_name "63_HotelSolBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_MetroM%C3%A0laga"></see>
    /// </summary>
    let ``_63_MetroM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "63_MetroM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_MuseuSaragossa"></see>
    /// </summary>
    let _63_MuseuSaragossa =
        Namespaced_IRI.parse _namespace_name "63_MuseuSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_RestaurantTradici%C3%B3Cadis"></see>
    /// </summary>
    let ``_63_RestaurantTradici%C3%B3Cadis`` =
        Namespaced_IRI.parse _namespace_name "63_RestaurantTradici%C3%B3Cadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_CityBarcelona"></see>
    /// </summary>
    let _64_CityBarcelona =
        Namespaced_IRI.parse _namespace_name "64_CityBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_FiraMadrid"></see>
    /// </summary>
    let _64_FiraMadrid =
        Namespaced_IRI.parse _namespace_name "64_FiraMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_HotelPalaceBarcelona"></see>
    /// </summary>
    let _64_HotelPalaceBarcelona =
        Namespaced_IRI.parse _namespace_name "64_HotelPalaceBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_MuseuSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_64_MuseuSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "64_MuseuSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_RestaurantTradici%C3%B3M%C3%A0laga"></see>
    /// </summary>
    let ``_64_RestaurantTradici%C3%B3M%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "64_RestaurantTradici%C3%B3M%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_CarnavalBarcelona"></see>
    /// </summary>
    let _65_CarnavalBarcelona =
        Namespaced_IRI.parse _namespace_name "65_CarnavalBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_HotelPalaceToledo"></see>
    /// </summary>
    let _65_HotelPalaceToledo =
        Namespaced_IRI.parse _namespace_name "65_HotelPalaceToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_ParcM%C3%A0laga"></see>
    /// </summary>
    let ``_65_ParcM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "65_ParcM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_65_RestaurantGourmetM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "65_RestaurantGourmetM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_UrbanPamplona"></see>
    /// </summary>
    let _65_UrbanPamplona =
        Namespaced_IRI.parse _namespace_name "65_UrbanPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_FestivalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_66_FestivalVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "66_FestivalVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_HotelSolMadrid"></see>
    /// </summary>
    let _66_HotelSolMadrid =
        Namespaced_IRI.parse _namespace_name "66_HotelSolMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_MetroSevilla"></see>
    /// </summary>
    let _66_MetroSevilla =
        Namespaced_IRI.parse _namespace_name "66_MetroSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_MuseuSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_66_MuseuSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "66_MuseuSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_RestaurantFusi%C3%B3Barcelona"></see>
    /// </summary>
    let ``_66_RestaurantFusi%C3%B3Barcelona`` =
        Namespaced_IRI.parse _namespace_name "66_RestaurantFusi%C3%B3Barcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_ConcertToledo"></see>
    /// </summary>
    let _67_ConcertToledo =
        Namespaced_IRI.parse _namespace_name "67_ConcertToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_HotelVistaMadrid"></see>
    /// </summary>
    let _67_HotelVistaMadrid =
        Namespaced_IRI.parse _namespace_name "67_HotelVistaMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_MetroToledo"></see>
    /// </summary>
    let _67_MetroToledo =
        Namespaced_IRI.parse _namespace_name "67_MetroToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_ParcCadis"></see>
    /// </summary>
    let _67_ParcCadis =
        Namespaced_IRI.parse _namespace_name "67_ParcCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_RestaurantFusi%C3%B3Toledo"></see>
    /// </summary>
    let ``_67_RestaurantFusi%C3%B3Toledo`` =
        Namespaced_IRI.parse _namespace_name "67_RestaurantFusi%C3%B3Toledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_CastellMadrid"></see>
    /// </summary>
    let _68_CastellMadrid =
        Namespaced_IRI.parse _namespace_name "68_CastellMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_FiraPamplona"></see>
    /// </summary>
    let _68_FiraPamplona =
        Namespaced_IRI.parse _namespace_name "68_FiraPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_HotelDelMarMadrid"></see>
    /// </summary>
    let _68_HotelDelMarMadrid =
        Namespaced_IRI.parse _namespace_name "68_HotelDelMarMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_TransM%C3%A0laga"></see>
    /// </summary>
    let ``_68_TransM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "68_TransM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_estaurantGourmetBarcelona"></see>
    /// </summary>
    let _68_estaurantGourmetBarcelona =
        Namespaced_IRI.parse _namespace_name "68_estaurantGourmetBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_Congr%C3%A9sSaragossa"></see>
    /// </summary>
    let ``_69_Congr%C3%A9sSaragossa`` =
        Namespaced_IRI.parse _namespace_name "69_Congr%C3%A9sSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_HotelRoyalMadrid"></see>
    /// </summary>
    let _69_HotelRoyalMadrid =
        Namespaced_IRI.parse _namespace_name "69_HotelRoyalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_MetroPamplona"></see>
    /// </summary>
    let _69_MetroPamplona =
        Namespaced_IRI.parse _namespace_name "69_MetroPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_ParcCadis"></see>
    /// </summary>
    let _69_ParcCadis =
        Namespaced_IRI.parse _namespace_name "69_ParcCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_RestaurantGourmetBarcelona"></see>
    /// </summary>
    let _69_RestaurantGourmetBarcelona =
        Namespaced_IRI.parse _namespace_name "69_RestaurantGourmetBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_Congr%C3%A9sBilbao"></see>
    /// </summary>
    let ``_6_Congr%C3%A9sBilbao`` =
        Namespaced_IRI.parse _namespace_name "6_Congr%C3%A9sBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_HotelRoyalSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_6_HotelRoyalSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "6_HotelRoyalSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_PalauBilbao"></see>
    /// </summary>
    let _6_PalauBilbao =
        Namespaced_IRI.parse _namespace_name "6_PalauBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_RestaurantSaborSevilla"></see>
    /// </summary>
    let _6_RestaurantSaborSevilla =
        Namespaced_IRI.parse _namespace_name "6_RestaurantSaborSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_TransPamplona"></see>
    /// </summary>
    let _6_TransPamplona =
        Namespaced_IRI.parse _namespace_name "6_TransPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_CastellPamplona"></see>
    /// </summary>
    let _70_CastellPamplona =
        Namespaced_IRI.parse _namespace_name "70_CastellPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_Congr%C3%A9sSaragossa"></see>
    /// </summary>
    let ``_70_Congr%C3%A9sSaragossa`` =
        Namespaced_IRI.parse _namespace_name "70_Congr%C3%A9sSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_HotelRoyalSaragossa"></see>
    /// </summary>
    let _70_HotelRoyalSaragossa =
        Namespaced_IRI.parse _namespace_name "70_HotelRoyalSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_RestaurantFusi%C3%B3Saragossa"></see>
    /// </summary>
    let ``_70_RestaurantFusi%C3%B3Saragossa`` =
        Namespaced_IRI.parse _namespace_name "70_RestaurantFusi%C3%B3Saragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_UrbanBilbao"></see>
    /// </summary>
    let _70_UrbanBilbao =
        Namespaced_IRI.parse _namespace_name "70_UrbanBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_FiraM%C3%A0laga"></see>
    /// </summary>
    let ``_71_FiraM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "71_FiraM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_HotelDelMarM%C3%A0laga"></see>
    /// </summary>
    let ``_71_HotelDelMarM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "71_HotelDelMarM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_MoviBarcelona"></see>
    /// </summary>
    let _71_MoviBarcelona =
        Namespaced_IRI.parse _namespace_name "71_MoviBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_ParcMadrid"></see>
    /// </summary>
    let _71_ParcMadrid =
        Namespaced_IRI.parse _namespace_name "71_ParcMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_RestaurantTradici%C3%B3Cadis"></see>
    /// </summary>
    let ``_71_RestaurantTradici%C3%B3Cadis`` =
        Namespaced_IRI.parse _namespace_name "71_RestaurantTradici%C3%B3Cadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_FiraCadis"></see>
    /// </summary>
    let _72_FiraCadis =
        Namespaced_IRI.parse _namespace_name "72_FiraCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_HotelDelMarSaragossa"></see>
    /// </summary>
    let _72_HotelDelMarSaragossa =
        Namespaced_IRI.parse _namespace_name "72_HotelDelMarSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_ParcVal%C3%A8ncia"></see>
    /// </summary>
    let ``_72_ParcVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "72_ParcVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_RestaurantFusi%C3%B3Bilbao"></see>
    /// </summary>
    let ``_72_RestaurantFusi%C3%B3Bilbao`` =
        Namespaced_IRI.parse _namespace_name "72_RestaurantFusi%C3%B3Bilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_UrbanSevilla"></see>
    /// </summary>
    let _72_UrbanSevilla =
        Namespaced_IRI.parse _namespace_name "72_UrbanSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_CarnavalSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_73_CarnavalSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "73_CarnavalSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_73_CatedralVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "73_CatedralVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_HotelVistaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_73_HotelVistaSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "73_HotelVistaSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_RestaurantGourmetVal%C3%A8ncia"></see>
    /// </summary>
    let ``_73_RestaurantGourmetVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "73_RestaurantGourmetVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_TransCadis"></see>
    /// </summary>
    let _73_TransCadis =
        Namespaced_IRI.parse _namespace_name "73_TransCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_CarnavalM%C3%A0laga"></see>
    /// </summary>
    let ``_74_CarnavalM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "74_CarnavalM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_HotelPalacePamplona"></see>
    /// </summary>
    let _74_HotelPalacePamplona =
        Namespaced_IRI.parse _namespace_name "74_HotelPalacePamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_PalauMadrid"></see>
    /// </summary>
    let _74_PalauMadrid =
        Namespaced_IRI.parse _namespace_name "74_PalauMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_RestaurantGourmetPamplona"></see>
    /// </summary>
    let _74_RestaurantGourmetPamplona =
        Namespaced_IRI.parse _namespace_name "74_RestaurantGourmetPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_UrbanSevilla"></see>
    /// </summary>
    let _74_UrbanSevilla =
        Namespaced_IRI.parse _namespace_name "74_UrbanSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_CatedralToledo"></see>
    /// </summary>
    let _75_CatedralToledo =
        Namespaced_IRI.parse _namespace_name "75_CatedralToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_FiraSevilla"></see>
    /// </summary>
    let _75_FiraSevilla =
        Namespaced_IRI.parse _namespace_name "75_FiraSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_HotelRoyalMadrid"></see>
    /// </summary>
    let _75_HotelRoyalMadrid =
        Namespaced_IRI.parse _namespace_name "75_HotelRoyalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_MetroPamplona"></see>
    /// </summary>
    let _75_MetroPamplona =
        Namespaced_IRI.parse _namespace_name "75_MetroPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_RestaurantSaborSevilla"></see>
    /// </summary>
    let _75_RestaurantSaborSevilla =
        Namespaced_IRI.parse _namespace_name "75_RestaurantSaborSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_CityMadrid"></see>
    /// </summary>
    let _76_CityMadrid =
        Namespaced_IRI.parse _namespace_name "76_CityMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_ConcertM%C3%A0laga"></see>
    /// </summary>
    let ``_76_ConcertM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "76_ConcertM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_HotelVistaBarcelona"></see>
    /// </summary>
    let _76_HotelVistaBarcelona =
        Namespaced_IRI.parse _namespace_name "76_HotelVistaBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_PalauBarcelona"></see>
    /// </summary>
    let _76_PalauBarcelona =
        Namespaced_IRI.parse _namespace_name "76_PalauBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_RestaurantFusi%C3%B3Val%C3%A8ncia"></see>
    /// </summary>
    let ``_76_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "76_RestaurantFusi%C3%B3Val%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_FestivalToledo"></see>
    /// </summary>
    let _77_FestivalToledo =
        Namespaced_IRI.parse _namespace_name "77_FestivalToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_HotelSolBarcelona"></see>
    /// </summary>
    let _77_HotelSolBarcelona =
        Namespaced_IRI.parse _namespace_name "77_HotelSolBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_MetroMadrid"></see>
    /// </summary>
    let _77_MetroMadrid =
        Namespaced_IRI.parse _namespace_name "77_MetroMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_PalauPamplona"></see>
    /// </summary>
    let _77_PalauPamplona =
        Namespaced_IRI.parse _namespace_name "77_PalauPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_RestaurantDeliciaSevilla"></see>
    /// </summary>
    let _77_RestaurantDeliciaSevilla =
        Namespaced_IRI.parse _namespace_name "77_RestaurantDeliciaSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_CarnavalCadis"></see>
    /// </summary>
    let _78_CarnavalCadis =
        Namespaced_IRI.parse _namespace_name "78_CarnavalCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_CastellBilbao"></see>
    /// </summary>
    let _78_CastellBilbao =
        Namespaced_IRI.parse _namespace_name "78_CastellBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_HotelRoyalBilbao"></see>
    /// </summary>
    let _78_HotelRoyalBilbao =
        Namespaced_IRI.parse _namespace_name "78_HotelRoyalBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_MoviBilbao"></see>
    /// </summary>
    let _78_MoviBilbao =
        Namespaced_IRI.parse _namespace_name "78_MoviBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_RestaurantFusi%C3%B3Val%C3%A8ncia"></see>
    /// </summary>
    let ``_78_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "78_RestaurantFusi%C3%B3Val%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_CatedralPamplona"></see>
    /// </summary>
    let _79_CatedralPamplona =
        Namespaced_IRI.parse _namespace_name "79_CatedralPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_Congr%C3%A9sCadis"></see>
    /// </summary>
    let ``_79_Congr%C3%A9sCadis`` =
        Namespaced_IRI.parse _namespace_name "79_Congr%C3%A9sCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_HotelSolM%C3%A0laga"></see>
    /// </summary>
    let ``_79_HotelSolM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "79_HotelSolM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_RestaurantSaborM%C3%A0laga"></see>
    /// </summary>
    let ``_79_RestaurantSaborM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "79_RestaurantSaborM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_TransSevilla"></see>
    /// </summary>
    let _79_TransSevilla =
        Namespaced_IRI.parse _namespace_name "79_TransSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_CatedralSevilla"></see>
    /// </summary>
    let _7_CatedralSevilla =
        Namespaced_IRI.parse _namespace_name "7_CatedralSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_FestivalMadrid"></see>
    /// </summary>
    let _7_FestivalMadrid =
        Namespaced_IRI.parse _namespace_name "7_FestivalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_HotelRoyalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_7_HotelRoyalVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "7_HotelRoyalVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_MetroCadis"></see>
    /// </summary>
    let _7_MetroCadis =
        Namespaced_IRI.parse _namespace_name "7_MetroCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_RestaurantGourmetSaragossa"></see>
    /// </summary>
    let _7_RestaurantGourmetSaragossa =
        Namespaced_IRI.parse _namespace_name "7_RestaurantGourmetSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_ConcertM%C3%A0laga"></see>
    /// </summary>
    let ``_80_ConcertM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "80_ConcertM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_HotelVistaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_80_HotelVistaSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "80_HotelVistaSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_ParcMadrid"></see>
    /// </summary>
    let _80_ParcMadrid =
        Namespaced_IRI.parse _namespace_name "80_ParcMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_RestaurantGourmetPamplona"></see>
    /// </summary>
    let _80_RestaurantGourmetPamplona =
        Namespaced_IRI.parse _namespace_name "80_RestaurantGourmetPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_TransPamplona"></see>
    /// </summary>
    let _80_TransPamplona =
        Namespaced_IRI.parse _namespace_name "80_TransPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_CityBilbao"></see>
    /// </summary>
    let _81_CityBilbao =
        Namespaced_IRI.parse _namespace_name "81_CityBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_Congr%C3%A9sToledo"></see>
    /// </summary>
    let ``_81_Congr%C3%A9sToledo`` =
        Namespaced_IRI.parse _namespace_name "81_Congr%C3%A9sToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_HotelVistaBarcelona"></see>
    /// </summary>
    let _81_HotelVistaBarcelona =
        Namespaced_IRI.parse _namespace_name "81_HotelVistaBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_ParcSevilla"></see>
    /// </summary>
    let _81_ParcSevilla =
        Namespaced_IRI.parse _namespace_name "81_ParcSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_RestaurantGourmetSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_81_RestaurantGourmetSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "81_RestaurantGourmetSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_CityMadrid"></see>
    /// </summary>
    let _82_CityMadrid =
        Namespaced_IRI.parse _namespace_name "82_CityMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_Congr%C3%A9sToledo"></see>
    /// </summary>
    let ``_82_Congr%C3%A9sToledo`` =
        Namespaced_IRI.parse _namespace_name "82_Congr%C3%A9sToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_HotelPalaceBilbao"></see>
    /// </summary>
    let _82_HotelPalaceBilbao =
        Namespaced_IRI.parse _namespace_name "82_HotelPalaceBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_PalauVal%C3%A8ncia"></see>
    /// </summary>
    let ``_82_PalauVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "82_PalauVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _82_RestaurantGourmetMadrid =
        Namespaced_IRI.parse _namespace_name "82_RestaurantGourmetMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_CastellM%C3%A0laga"></see>
    /// </summary>
    let ``_83_CastellM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "83_CastellM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_CityToledo"></see>
    /// </summary>
    let _83_CityToledo =
        Namespaced_IRI.parse _namespace_name "83_CityToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_ConcertCadis"></see>
    /// </summary>
    let _83_ConcertCadis =
        Namespaced_IRI.parse _namespace_name "83_ConcertCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_HotelPalaceCadis"></see>
    /// </summary>
    let _83_HotelPalaceCadis =
        Namespaced_IRI.parse _namespace_name "83_HotelPalaceCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_RestaurantDeliciaBilbao"></see>
    /// </summary>
    let _83_RestaurantDeliciaBilbao =
        Namespaced_IRI.parse _namespace_name "83_RestaurantDeliciaBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_CastellPamplona"></see>
    /// </summary>
    let _84_CastellPamplona =
        Namespaced_IRI.parse _namespace_name "84_CastellPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_FestivalSaragossa"></see>
    /// </summary>
    let _84_FestivalSaragossa =
        Namespaced_IRI.parse _namespace_name "84_FestivalSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_HotelVistaMadrid"></see>
    /// </summary>
    let _84_HotelVistaMadrid =
        Namespaced_IRI.parse _namespace_name "84_HotelVistaMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_RestaurantFusi%C3%B3Pamplona"></see>
    /// </summary>
    let ``_84_RestaurantFusi%C3%B3Pamplona`` =
        Namespaced_IRI.parse _namespace_name "84_RestaurantFusi%C3%B3Pamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_TransSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_84_TransSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "84_TransSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_CastellPamplona"></see>
    /// </summary>
    let _85_CastellPamplona =
        Namespaced_IRI.parse _namespace_name "85_CastellPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_FestivalSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_85_FestivalSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "85_FestivalSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_HotelPalaceMadrid"></see>
    /// </summary>
    let _85_HotelPalaceMadrid =
        Namespaced_IRI.parse _namespace_name "85_HotelPalaceMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_MoviSevilla"></see>
    /// </summary>
    let _85_MoviSevilla =
        Namespaced_IRI.parse _namespace_name "85_MoviSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_RestaurantFusi%C3%B3Madrid"></see>
    /// </summary>
    let ``_85_RestaurantFusi%C3%B3Madrid`` =
        Namespaced_IRI.parse _namespace_name "85_RestaurantFusi%C3%B3Madrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_CitySevilla"></see>
    /// </summary>
    let _86_CitySevilla =
        Namespaced_IRI.parse _namespace_name "86_CitySevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_FiraToledo"></see>
    /// </summary>
    let _86_FiraToledo =
        Namespaced_IRI.parse _namespace_name "86_FiraToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_HotelVistaToledo"></see>
    /// </summary>
    let _86_HotelVistaToledo =
        Namespaced_IRI.parse _namespace_name "86_HotelVistaToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_MuseuSaragossa"></see>
    /// </summary>
    let _86_MuseuSaragossa =
        Namespaced_IRI.parse _namespace_name "86_MuseuSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_RestaurantFusi%C3%B3Cadis"></see>
    /// </summary>
    let ``_86_RestaurantFusi%C3%B3Cadis`` =
        Namespaced_IRI.parse _namespace_name "86_RestaurantFusi%C3%B3Cadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_FestivalMadrid"></see>
    /// </summary>
    let _87_FestivalMadrid =
        Namespaced_IRI.parse _namespace_name "87_FestivalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_HotelSolSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_87_HotelSolSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "87_HotelSolSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_MoviBarcelona"></see>
    /// </summary>
    let _87_MoviBarcelona =
        Namespaced_IRI.parse _namespace_name "87_MoviBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_ParcSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_87_ParcSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "87_ParcSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_RestaurantSaborVal%C3%A8ncia"></see>
    /// </summary>
    let ``_87_RestaurantSaborVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "87_RestaurantSaborVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_FestivalToledo"></see>
    /// </summary>
    let _88_FestivalToledo =
        Namespaced_IRI.parse _namespace_name "88_FestivalToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_HotelVistaBarcelona"></see>
    /// </summary>
    let _88_HotelVistaBarcelona =
        Namespaced_IRI.parse _namespace_name "88_HotelVistaBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_PalauToledo"></see>
    /// </summary>
    let _88_PalauToledo =
        Namespaced_IRI.parse _namespace_name "88_PalauToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_RestaurantFusi%C3%B3Barcelona"></see>
    /// </summary>
    let ``_88_RestaurantFusi%C3%B3Barcelona`` =
        Namespaced_IRI.parse _namespace_name "88_RestaurantFusi%C3%B3Barcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_TransSaragossa"></see>
    /// </summary>
    let _88_TransSaragossa =
        Namespaced_IRI.parse _namespace_name "88_TransSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_CastellSaragossa"></see>
    /// </summary>
    let _89_CastellSaragossa =
        Namespaced_IRI.parse _namespace_name "89_CastellSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_FiraSaragossa"></see>
    /// </summary>
    let _89_FiraSaragossa =
        Namespaced_IRI.parse _namespace_name "89_FiraSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_HotelVistaBilbao"></see>
    /// </summary>
    let _89_HotelVistaBilbao =
        Namespaced_IRI.parse _namespace_name "89_HotelVistaBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_89_RestaurantGourmetM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "89_RestaurantGourmetM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_UrbanVal%C3%A8ncia"></see>
    /// </summary>
    let ``_89_UrbanVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "89_UrbanVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_CityMadrid"></see>
    /// </summary>
    let _8_CityMadrid =
        Namespaced_IRI.parse _namespace_name "8_CityMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_FiraM%C3%A0laga"></see>
    /// </summary>
    let ``_8_FiraM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "8_FiraM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_HotelVistaCadis"></see>
    /// </summary>
    let _8_HotelVistaCadis =
        Namespaced_IRI.parse _namespace_name "8_HotelVistaCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_ParcSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_8_ParcSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "8_ParcSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_RestaurantGourmetToledo"></see>
    /// </summary>
    let _8_RestaurantGourmetToledo =
        Namespaced_IRI.parse _namespace_name "8_RestaurantGourmetToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_CitySaragossa"></see>
    /// </summary>
    let _90_CitySaragossa =
        Namespaced_IRI.parse _namespace_name "90_CitySaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_Congr%C3%A9sVal%C3%A8ncia"></see>
    /// </summary>
    let ``_90_Congr%C3%A9sVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "90_Congr%C3%A9sVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_HotelDelMarSevilla"></see>
    /// </summary>
    let _90_HotelDelMarSevilla =
        Namespaced_IRI.parse _namespace_name "90_HotelDelMarSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_MuseuPamplona"></see>
    /// </summary>
    let _90_MuseuPamplona =
        Namespaced_IRI.parse _namespace_name "90_MuseuPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _90_RestaurantDeliciaSaragossa =
        Namespaced_IRI.parse _namespace_name "90_RestaurantDeliciaSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_CarnavalMadrid"></see>
    /// </summary>
    let _91_CarnavalMadrid =
        Namespaced_IRI.parse _namespace_name "91_CarnavalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_CatedralSevilla"></see>
    /// </summary>
    let _91_CatedralSevilla =
        Namespaced_IRI.parse _namespace_name "91_CatedralSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_HotelDelMarVal%C3%A8ncia"></see>
    /// </summary>
    let ``_91_HotelDelMarVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "91_HotelDelMarVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_RestaurantGourmetSaragossa"></see>
    /// </summary>
    let _91_RestaurantGourmetSaragossa =
        Namespaced_IRI.parse _namespace_name "91_RestaurantGourmetSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_UrbanBilbao"></see>
    /// </summary>
    let _91_UrbanBilbao =
        Namespaced_IRI.parse _namespace_name "91_UrbanBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_FestivalCadis"></see>
    /// </summary>
    let _92_FestivalCadis =
        Namespaced_IRI.parse _namespace_name "92_FestivalCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_HotelRoyalM%C3%A0laga"></see>
    /// </summary>
    let ``_92_HotelRoyalM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "92_HotelRoyalM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_MetroMadrid"></see>
    /// </summary>
    let _92_MetroMadrid =
        Namespaced_IRI.parse _namespace_name "92_MetroMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_MuseuCadis"></see>
    /// </summary>
    let _92_MuseuCadis =
        Namespaced_IRI.parse _namespace_name "92_MuseuCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_RestaurantGourmetPamplona"></see>
    /// </summary>
    let _92_RestaurantGourmetPamplona =
        Namespaced_IRI.parse _namespace_name "92_RestaurantGourmetPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_ConcertCadis"></see>
    /// </summary>
    let _93_ConcertCadis =
        Namespaced_IRI.parse _namespace_name "93_ConcertCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_HotelDelMarMadrid"></see>
    /// </summary>
    let _93_HotelDelMarMadrid =
        Namespaced_IRI.parse _namespace_name "93_HotelDelMarMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_ParcToledo"></see>
    /// </summary>
    let _93_ParcToledo =
        Namespaced_IRI.parse _namespace_name "93_ParcToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_RestaurantSaborSaragossa"></see>
    /// </summary>
    let _93_RestaurantSaborSaragossa =
        Namespaced_IRI.parse _namespace_name "93_RestaurantSaborSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_TransVal%C3%A8ncia"></see>
    /// </summary>
    let ``_93_TransVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "93_TransVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_CatedralToledo"></see>
    /// </summary>
    let _94_CatedralToledo =
        Namespaced_IRI.parse _namespace_name "94_CatedralToledo" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_FestivalMadrid"></see>
    /// </summary>
    let _94_FestivalMadrid =
        Namespaced_IRI.parse _namespace_name "94_FestivalMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_HotelVistaBilbao"></see>
    /// </summary>
    let _94_HotelVistaBilbao =
        Namespaced_IRI.parse _namespace_name "94_HotelVistaBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_MoviM%C3%A0laga"></see>
    /// </summary>
    let ``_94_MoviM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "94_MoviM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_RestaurantTradici%C3%B3Sevilla"></see>
    /// </summary>
    let ``_94_RestaurantTradici%C3%B3Sevilla`` =
        Namespaced_IRI.parse _namespace_name "94_RestaurantTradici%C3%B3Sevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_95_CatedralVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "95_CatedralVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_ConcertSaragossa"></see>
    /// </summary>
    let _95_ConcertSaragossa =
        Namespaced_IRI.parse _namespace_name "95_ConcertSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_HotelPalacePamplona"></see>
    /// </summary>
    let _95_HotelPalacePamplona =
        Namespaced_IRI.parse _namespace_name "95_HotelPalacePamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_RestaurantTradici%C3%B3Sevilla"></see>
    /// </summary>
    let ``_95_RestaurantTradici%C3%B3Sevilla`` =
        Namespaced_IRI.parse _namespace_name "95_RestaurantTradici%C3%B3Sevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_TransMadrid"></see>
    /// </summary>
    let _95_TransMadrid =
        Namespaced_IRI.parse _namespace_name "95_TransMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_96_Congr%C3%A9sBarcelona`` =
        Namespaced_IRI.parse _namespace_name "96_Congr%C3%A9sBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_HotelVistaPamplona"></see>
    /// </summary>
    let _96_HotelVistaPamplona =
        Namespaced_IRI.parse _namespace_name "96_HotelVistaPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_MuseuMadrid"></see>
    /// </summary>
    let _96_MuseuMadrid =
        Namespaced_IRI.parse _namespace_name "96_MuseuMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_RestaurantTradici%C3%B3Madrid"></see>
    /// </summary>
    let ``_96_RestaurantTradici%C3%B3Madrid`` =
        Namespaced_IRI.parse _namespace_name "96_RestaurantTradici%C3%B3Madrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_TransSaragossa"></see>
    /// </summary>
    let _96_TransSaragossa =
        Namespaced_IRI.parse _namespace_name "96_TransSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_CarnavalBilbao"></see>
    /// </summary>
    let _97_CarnavalBilbao =
        Namespaced_IRI.parse _namespace_name "97_CarnavalBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_CatedralSaragossa"></see>
    /// </summary>
    let _97_CatedralSaragossa =
        Namespaced_IRI.parse _namespace_name "97_CatedralSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_HotelPalaceM%C3%A0laga"></see>
    /// </summary>
    let ``_97_HotelPalaceM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "97_HotelPalaceM%C3%A0laga" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_RestaurantFusi%C3%B3Saragossa"></see>
    /// </summary>
    let ``_97_RestaurantFusi%C3%B3Saragossa`` =
        Namespaced_IRI.parse _namespace_name "97_RestaurantFusi%C3%B3Saragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_TransCadis"></see>
    /// </summary>
    let _97_TransCadis =
        Namespaced_IRI.parse _namespace_name "97_TransCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_CityPamplona"></see>
    /// </summary>
    let _98_CityPamplona =
        Namespaced_IRI.parse _namespace_name "98_CityPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_Congr%C3%A9sSaragossa"></see>
    /// </summary>
    let ``_98_Congr%C3%A9sSaragossa`` =
        Namespaced_IRI.parse _namespace_name "98_Congr%C3%A9sSaragossa" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_HotelPalaceMadrid"></see>
    /// </summary>
    let _98_HotelPalaceMadrid =
        Namespaced_IRI.parse _namespace_name "98_HotelPalaceMadrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_ParcCadis"></see>
    /// </summary>
    let _98_ParcCadis =
        Namespaced_IRI.parse _namespace_name "98_ParcCadis" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_RestaurantDeliciaSevilla"></see>
    /// </summary>
    let _98_RestaurantDeliciaSevilla =
        Namespaced_IRI.parse _namespace_name "98_RestaurantDeliciaSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_CatedralBilbao"></see>
    /// </summary>
    let _99_CatedralBilbao =
        Namespaced_IRI.parse _namespace_name "99_CatedralBilbao" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_FiraSevilla"></see>
    /// </summary>
    let _99_FiraSevilla =
        Namespaced_IRI.parse _namespace_name "99_FiraSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_HotelSolSevilla"></see>
    /// </summary>
    let _99_HotelSolSevilla =
        Namespaced_IRI.parse _namespace_name "99_HotelSolSevilla" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_MetroSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_99_MetroSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "99_MetroSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_RestaurantGourmetVal%C3%A8ncia"></see>
    /// </summary>
    let ``_99_RestaurantGourmetVal%C3%A8ncia`` =
        Namespaced_IRI.parse _namespace_name "99_RestaurantGourmetVal%C3%A8ncia" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_CatedralPamplona"></see>
    /// </summary>
    let _9_CatedralPamplona =
        Namespaced_IRI.parse _namespace_name "9_CatedralPamplona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_Congr%C3%A9sSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_9_Congr%C3%A9sSantSebasti%C3%A0`` =
        Namespaced_IRI.parse _namespace_name "9_Congr%C3%A9sSantSebasti%C3%A0" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_HotelRoyalBarcelona"></see>
    /// </summary>
    let _9_HotelRoyalBarcelona =
        Namespaced_IRI.parse _namespace_name "9_HotelRoyalBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_MetroBarcelona"></see>
    /// </summary>
    let _9_MetroBarcelona =
        Namespaced_IRI.parse _namespace_name "9_MetroBarcelona" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_RestaurantDeliciaM%C3%A0laga"></see>
    /// </summary>
    let ``_9_RestaurantDeliciaM%C3%A0laga`` =
        Namespaced_IRI.parse _namespace_name "9_RestaurantDeliciaM%C3%A0laga" |> NamespacedName

    /// <summary>
    /// Includes different restaurant categories
    /// <see href="https://purl.org/cityexplorer#RestaurantCategory"></see></summary>
    let RestaurantCategory =
        Namespaced_IRI.parse _namespace_name "RestaurantCategory" |> NamespacedName

    /// <summary>
    /// Includes different attraction categories
    /// <see href="https://purl.org/cityexplorer#AttractionCategory"></see></summary>
    let AttractionCategory =
        Namespaced_IRI.parse _namespace_name "AttractionCategory" |> NamespacedName

    /// <summary>
    /// Global category, including different categories
    /// <see href="https://purl.org/cityexplorer#Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName

    /// <summary>
    /// Refers to different types of categories
    /// <see href="https://purl.org/cityexplorer#CategoryTypes"></see></summary>
    let CategoryTypes =
        Namespaced_IRI.parse _namespace_name "CategoryTypes" |> NamespacedName

    /// <summary>
    /// The latitude of a location
    /// <see href="https://purl.org/cityexplorer#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    /// The longitude of a location
    /// <see href="https://purl.org/cityexplorer#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName

    /// <summary>
    /// Base class to make searches based on rules
    /// <see href="https://purl.org/cityexplorer#Recommendation"></see></summary>
    let Recommendation =
        Namespaced_IRI.parse _namespace_name "Recommendation" |> NamespacedName

    /// <summary>
    /// Includes different hotel categories
    /// <see href="https://purl.org/cityexplorer#HotelCategory"></see></summary>
    let HotelCategory =
        Namespaced_IRI.parse _namespace_name "HotelCategory" |> NamespacedName

    /// <summary>
    /// Includes different attraction categories
    /// <see href="https://purl.org/cityexplorer#TransportCategory"></see></summary>
    let TransportCategory =
        Namespaced_IRI.parse _namespace_name "TransportCategory" |> NamespacedName

    /// <summary>
    /// Includes different event categories
    /// <see href="https://purl.org/cityexplorer#EventCategory"></see></summary>
    let EventCategory =
        Namespaced_IRI.parse _namespace_name "EventCategory" |> NamespacedName

    /// <summary>
    /// Indicates if a category is a category of a class
    /// <see href="https://purl.org/cityexplorer#isCategoryOf"></see></summary>
    let isCategoryOf =
        Namespaced_IRI.parse _namespace_name "isCategoryOf" |> NamespacedName
