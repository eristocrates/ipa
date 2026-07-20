namespace https.purl.org.cityexplorer.hash

open DoxAletheia

module ce =
    let _namespace_name = "https://purl.org/cityexplorer#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Refers to restaurants serving food from Andalusia
    /// <see href="https://purl.org/cityexplorer#AndalusianRestaurant"></see></summary>
    let AndalusianRestaurant = _prefix "AndalusianRestaurant"
    /// <summary>
    /// Refers to restaurants serving food from Italy
    /// <see href="https://purl.org/cityexplorer#ItalianRestaurant"></see></summary>
    let ItalianRestaurant = _prefix "ItalianRestaurant"
    /// <summary>
    /// Refers to restaurants serving food from Japan
    /// <see href="https://purl.org/cityexplorer#JapaneseRestaurant"></see></summary>
    let JapaneseRestaurant = _prefix "JapaneseRestaurant"
    /// <summary>
    /// Refers to restaurants serving mediterranean food
    /// <see href="https://purl.org/cityexplorer#MediterraneanRestaurant"></see></summary>
    let MediterraneanRestaurant = _prefix "MediterraneanRestaurant"
    /// <summary>
    /// Refers to restaurants serving food from Mexico
    /// <see href="https://purl.org/cityexplorer#MexicanRestaurant"></see></summary>
    let MexicanRestaurant = _prefix "MexicanRestaurant"
    /// <summary>
    /// Refers to the category of events
    /// <see href="https://purl.org/cityexplorer#EventTypes"></see></summary>
    let EventTypes = _prefix "EventTypes"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Cultural"></see>
    /// </summary>
    let Cultural = _prefix "Cultural"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Gastronomic"></see>
    /// </summary>
    let Gastronomic = _prefix "Gastronomic"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Music"></see>
    /// </summary>
    let Music = _prefix "Music"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Sport"></see>
    /// </summary>
    let Sport = _prefix "Sport"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Technological"></see>
    /// </summary>
    let Technological = _prefix "Technological"
    /// <summary>
    /// Refers to attractions involving a beach
    /// <see href="https://purl.org/cityexplorer#BeachAttraction"></see></summary>
    let BeachAttraction = _prefix "BeachAttraction"
    /// <summary>
    /// Refers to attractions involving any kind of cultural activity
    /// <see href="https://purl.org/cityexplorer#CulturalAttraction"></see></summary>
    let CulturalAttraction = _prefix "CulturalAttraction"
    /// <summary>
    /// Refers to attractions involving a monument
    /// <see href="https://purl.org/cityexplorer#MonumentAttraction"></see></summary>
    let MonumentAttraction = _prefix "MonumentAttraction"
    /// <summary>
    /// Refers to attractions involving a museum
    /// <see href="https://purl.org/cityexplorer#MuseumAttraction"></see></summary>
    let MuseumAttraction = _prefix "MuseumAttraction"
    /// <summary>
    /// Refers to attractions involving a park
    /// <see href="https://purl.org/cityexplorer#ParkAttraction"></see></summary>
    let ParkAttraction = _prefix "ParkAttraction"
    /// <summary>
    /// Refers to the category of restaurants
    /// <see href="https://purl.org/cityexplorer#RestaurantTypes"></see></summary>
    let RestaurantTypes = _prefix "RestaurantTypes"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Andalusian"></see>
    /// </summary>
    let Andalusian = _prefix "Andalusian"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Italianian"></see>
    /// </summary>
    let Italianian = _prefix "Italianian"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Japanese"></see>
    /// </summary>
    let Japanese = _prefix "Japanese"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Mediterranean"></see>
    /// </summary>
    let Mediterranean = _prefix "Mediterranean"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Mexican"></see>
    /// </summary>
    let Mexican = _prefix "Mexican"
    /// <summary>
    /// Refers to cities located at the beach
    /// <see href="https://purl.org/cityexplorer#BeachCities"></see></summary>
    let BeachCities = _prefix "BeachCities"
    /// <summary>
    /// Refers to a city
    /// <see href="https://purl.org/cityexplorer#City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// Indicates if the city contains the specific property
    /// <see href="https://purl.org/cityexplorer#isCityOf"></see></summary>
    let isCityOf = _prefix "isCityOf"
    /// <summary>
    /// Refers to an attraction type, which can be cultural, park, etc.
    /// <see href="https://purl.org/cityexplorer#Attraction"></see></summary>
    let Attraction = _prefix "Attraction"
    /// <summary>
    /// Refers to a restaurant
    /// <see href="https://purl.org/cityexplorer#Restaurant"></see></summary>
    let Restaurant = _prefix "Restaurant"
    /// <summary>
    /// The overall rating, based on a collection of reviews or ratings, of the item
    /// <see href="https://purl.org/cityexplorer#aggregateRating"></see></summary>
    let aggregateRating = _prefix "aggregateRating"
    /// <summary>
    /// The price range of the business
    /// <see href="https://purl.org/cityexplorer#priceRange"></see></summary>
    let priceRange = _prefix "priceRange"
    /// <summary>
    /// Refers to restaurants that are recommended
    /// <see href="https://purl.org/cityexplorer#RecommendedRestaurants"></see></summary>
    let RecommendedRestaurants = _prefix "RecommendedRestaurants"
    /// <summary>
    /// Refers to an event involving any kind of cultural activity
    /// <see href="https://purl.org/cityexplorer#CulturalEvent"></see></summary>
    let CulturalEvent = _prefix "CulturalEvent"
    /// <summary>
    /// Refers to an event involving gastronomy
    /// <see href="https://purl.org/cityexplorer#GastronomicEvent"></see></summary>
    let GastronomicEvent = _prefix "GastronomicEvent"
    /// <summary>
    /// Refers to an event involving music
    /// <see href="https://purl.org/cityexplorer#MusicEvent"></see></summary>
    let MusicEvent = _prefix "MusicEvent"
    /// <summary>
    /// Refers to an event involving sports
    /// <see href="https://purl.org/cityexplorer#SportsEvent"></see></summary>
    let SportsEvent = _prefix "SportsEvent"
    /// <summary>
    /// Refers to an event involving tecnology
    /// <see href="https://purl.org/cityexplorer#TechnologicalEvent"></see></summary>
    let TechnologicalEvent = _prefix "TechnologicalEvent"
    /// <summary>
    /// Refers to the category of hotels
    /// <see href="https://purl.org/cityexplorer#HotelTypes"></see></summary>
    let HotelTypes = _prefix "HotelTypes"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Beach"></see>
    /// </summary>
    let Beach = _prefix "Beach"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Business"></see>
    /// </summary>
    let Business = _prefix "Business"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Luxury"></see>
    /// </summary>
    let Luxury = _prefix "Luxury"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Rural"></see>
    /// </summary>
    let Rural = _prefix "Rural"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Tourist"></see>
    /// </summary>
    let Tourist = _prefix "Tourist"
    /// <summary>
    /// Refers to the category of attractions
    /// <see href="https://purl.org/cityexplorer#AttractionTypes"></see></summary>
    let AttractionTypes = _prefix "AttractionTypes"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Monument"></see>
    /// </summary>
    let Monument = _prefix "Monument"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Museum"></see>
    /// </summary>
    let Museum = _prefix "Museum"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Park"></see>
    /// </summary>
    let Park = _prefix "Park"
    /// <summary>
    /// Refers to an event
    /// <see href="https://purl.org/cityexplorer#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Refers to cities with cultural interest
    /// <see href="https://purl.org/cityexplorer#CulturalCities"></see></summary>
    let CulturalCities = _prefix "CulturalCities"
    /// <summary>
    /// Refers to the category of transports
    /// <see href="https://purl.org/cityexplorer#TransportTypes"></see></summary>
    let TransportTypes = _prefix "TransportTypes"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Bus"></see>
    /// </summary>
    let Bus = _prefix "Bus"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Metro"></see>
    /// </summary>
    let Metro = _prefix "Metro"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#PublicBike"></see>
    /// </summary>
    let PublicBike = _prefix "PublicBike"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Taxi"></see>
    /// </summary>
    let Taxi = _prefix "Taxi"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Tram"></see>
    /// </summary>
    let Tram = _prefix "Tram"
    /// <summary>
    /// Refers to hotels at the beach
    /// <see href="https://purl.org/cityexplorer#BeachHotel"></see></summary>
    let BeachHotel = _prefix "BeachHotel"
    /// <summary>
    /// Refers to hotels considered for business
    /// <see href="https://purl.org/cityexplorer#BusinessHotel"></see></summary>
    let BusinessHotel = _prefix "BusinessHotel"
    /// <summary>
    /// Refers to hotels considered luxurious
    /// <see href="https://purl.org/cityexplorer#LuxuryHotel"></see></summary>
    let LuxuryHotel = _prefix "LuxuryHotel"
    /// <summary>
    /// Refers to hotels considered rural
    /// <see href="https://purl.org/cityexplorer#RuralHotel"></see></summary>
    let RuralHotel = _prefix "RuralHotel"
    /// <summary>
    /// Refers to touristic hotels
    /// <see href="https://purl.org/cityexplorer#TouristHotel"></see></summary>
    let TouristHotel = _prefix "TouristHotel"
    /// <summary>
    /// Refers to bus transport
    /// <see href="https://purl.org/cityexplorer#BusTransport"></see></summary>
    let BusTransport = _prefix "BusTransport"
    /// <summary>
    /// Refers to metro transport
    /// <see href="https://purl.org/cityexplorer#MetroTransport"></see></summary>
    let MetroTransport = _prefix "MetroTransport"
    /// <summary>
    /// Refers to public bike transport
    /// <see href="https://purl.org/cityexplorer#PublicBikeTransport"></see></summary>
    let PublicBikeTransport = _prefix "PublicBikeTransport"
    /// <summary>
    /// Refers to taxi transport
    /// <see href="https://purl.org/cityexplorer#TaxiTransport"></see></summary>
    let TaxiTransport = _prefix "TaxiTransport"
    /// <summary>
    /// Refers to tram transport
    /// <see href="https://purl.org/cityexplorer#TramTransport"></see></summary>
    let TramTransport = _prefix "TramTransport"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_FiraBarcelona"></see>
    /// </summary>
    let _100_FiraBarcelona = _prefix "100_FiraBarcelona"
    /// <summary>
    /// Indicate if a class has a specific category
    /// <see href="https://purl.org/cityexplorer#hasCategory"></see></summary>
    let hasCategory = _prefix "hasCategory"
    /// <summary>
    /// The identifier of the object (city, etc.)
    /// <see href="https://purl.org/cityexplorer#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// Indicates if it's located in a city
    /// <see href="https://purl.org/cityexplorer#locatedInCity"></see></summary>
    let locatedInCity = _prefix "locatedInCity"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Barcelona"></see>
    /// </summary>
    let Barcelona = _prefix "Barcelona"
    /// <summary>
    /// The name of the item
    /// <see href="https://purl.org/cityexplorer#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// The start date and time of the item
    /// <see href="https://purl.org/cityexplorer#startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_HotelPalaceM%C3%A0laga"></see>
    /// </summary>
    let ``_100_HotelPalaceM%C3%A0laga`` = _prefix "100_HotelPalaceM%C3%A0laga"
    /// <summary>
    /// Refers to an hotel
    /// <see href="https://purl.org/cityexplorer#Hotel"></see></summary>
    let Hotel = _prefix "Hotel"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#M%C3%A0laga"></see>
    /// </summary>
    let ``M%C3%A0laga`` = _prefix "M%C3%A0laga"
    /// <summary>
    /// An official rating for a lodging business or food establishment
    /// <see href="https://purl.org/cityexplorer#starRating"></see></summary>
    let starRating = _prefix "starRating"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_MuseuBilbao"></see>
    /// </summary>
    let _100_MuseuBilbao = _prefix "100_MuseuBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Bilbao"></see>
    /// </summary>
    let Bilbao = _prefix "Bilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_RestaurantGourmetToledo"></see>
    /// </summary>
    let _100_RestaurantGourmetToledo = _prefix "100_RestaurantGourmetToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Toledo"></see>
    /// </summary>
    let Toledo = _prefix "Toledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#100_TransPamplona"></see>
    /// </summary>
    let _100_TransPamplona = _prefix "100_TransPamplona"
    /// <summary>
    /// Refers to a way of transport
    /// <see href="https://purl.org/cityexplorer#Transport"></see></summary>
    let Transport = _prefix "Transport"
    /// <summary>
    /// The company of transport
    /// <see href="https://purl.org/cityexplorer#company"></see></summary>
    let company = _prefix "company"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Pamplona"></see>
    /// </summary>
    let Pamplona = _prefix "Pamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_CastellToledo"></see>
    /// </summary>
    let _10_CastellToledo = _prefix "10_CastellToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_10_Congr%C3%A9sBarcelona`` = _prefix "10_Congr%C3%A9sBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_HotelRoyalCadis"></see>
    /// </summary>
    let _10_HotelRoyalCadis = _prefix "10_HotelRoyalCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Cadis"></see>
    /// </summary>
    let Cadis = _prefix "Cadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_RestaurantDeliciaCadis"></see>
    /// </summary>
    let _10_RestaurantDeliciaCadis = _prefix "10_RestaurantDeliciaCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#10_TransSevilla"></see>
    /// </summary>
    let _10_TransSevilla = _prefix "10_TransSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Sevilla"></see>
    /// </summary>
    let Sevilla = _prefix "Sevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_CarnavalBilbao"></see>
    /// </summary>
    let _11_CarnavalBilbao = _prefix "11_CarnavalBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_HotelRoyalMadrid"></see>
    /// </summary>
    let _11_HotelRoyalMadrid = _prefix "11_HotelRoyalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Madrid"></see>
    /// </summary>
    let Madrid = _prefix "Madrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_ParcToledo"></see>
    /// </summary>
    let _11_ParcToledo = _prefix "11_ParcToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _11_RestaurantGourmetMadrid = _prefix "11_RestaurantGourmetMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#11_TransVal%C3%A8ncia"></see>
    /// </summary>
    let ``_11_TransVal%C3%A8ncia`` = _prefix "11_TransVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Val%C3%A8ncia"></see>
    /// </summary>
    let ``Val%C3%A8ncia`` = _prefix "Val%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_CatedralCadis"></see>
    /// </summary>
    let _12_CatedralCadis = _prefix "12_CatedralCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_CitySevilla"></see>
    /// </summary>
    let _12_CitySevilla = _prefix "12_CitySevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_FiraBarcelona"></see>
    /// </summary>
    let _12_FiraBarcelona = _prefix "12_FiraBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_HotelRoyalMadrid"></see>
    /// </summary>
    let _12_HotelRoyalMadrid = _prefix "12_HotelRoyalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#12_RestaurantSaborCadis"></see>
    /// </summary>
    let _12_RestaurantSaborCadis = _prefix "12_RestaurantSaborCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_CityCadis"></see>
    /// </summary>
    let _13_CityCadis = _prefix "13_CityCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_Congr%C3%A9sVal%C3%A8ncia"></see>
    /// </summary>
    let ``_13_Congr%C3%A9sVal%C3%A8ncia`` = _prefix "13_Congr%C3%A9sVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_HotelDelMarSevilla"></see>
    /// </summary>
    let _13_HotelDelMarSevilla = _prefix "13_HotelDelMarSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_PalauPamplona"></see>
    /// </summary>
    let _13_PalauPamplona = _prefix "13_PalauPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#13_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _13_RestaurantDeliciaSaragossa = _prefix "13_RestaurantDeliciaSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#Saragossa"></see>
    /// </summary>
    let Saragossa = _prefix "Saragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_CastellPamplona"></see>
    /// </summary>
    let _14_CastellPamplona = _prefix "14_CastellPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_Congr%C3%A9sToledo"></see>
    /// </summary>
    let ``_14_Congr%C3%A9sToledo`` = _prefix "14_Congr%C3%A9sToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_HotelPalaceMadrid"></see>
    /// </summary>
    let _14_HotelPalaceMadrid = _prefix "14_HotelPalaceMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_MoviPamplona"></see>
    /// </summary>
    let _14_MoviPamplona = _prefix "14_MoviPamplona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#14_RestaurantFusi%C3%B3Val%C3%A8ncia"></see>
    /// </summary>
    let ``_14_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        _prefix "14_RestaurantFusi%C3%B3Val%C3%A8ncia"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_CastellCadis"></see>
    /// </summary>
    let _15_CastellCadis = _prefix "15_CastellCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_FestivalSaragossa"></see>
    /// </summary>
    let _15_FestivalSaragossa = _prefix "15_FestivalSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_HotelPalaceCadis"></see>
    /// </summary>
    let _15_HotelPalaceCadis = _prefix "15_HotelPalaceCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_MoviCadis"></see>
    /// </summary>
    let _15_MoviCadis = _prefix "15_MoviCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#15_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _15_RestaurantDeliciaSaragossa = _prefix "15_RestaurantDeliciaSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_CastellBarcelona"></see>
    /// </summary>
    let _16_CastellBarcelona = _prefix "16_CastellBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_CityM%C3%A0laga"></see>
    /// </summary>
    let ``_16_CityM%C3%A0laga`` = _prefix "16_CityM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_ConcertSevilla"></see>
    /// </summary>
    let _16_ConcertSevilla = _prefix "16_ConcertSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_HotelPalaceSaragossa"></see>
    /// </summary>
    let _16_HotelPalaceSaragossa = _prefix "16_HotelPalaceSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#16_RestaurantFusi%C3%B3Pamplona"></see>
    /// </summary>
    let ``_16_RestaurantFusi%C3%B3Pamplona`` = _prefix "16_RestaurantFusi%C3%B3Pamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_CarnavalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_17_CarnavalVal%C3%A8ncia`` = _prefix "17_CarnavalVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_HotelDelMarToledo"></see>
    /// </summary>
    let _17_HotelDelMarToledo = _prefix "17_HotelDelMarToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_ParcMadrid"></see>
    /// </summary>
    let _17_ParcMadrid = _prefix "17_ParcMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_RestaurantGourmetCadis"></see>
    /// </summary>
    let _17_RestaurantGourmetCadis = _prefix "17_RestaurantGourmetCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#17_UrbanBilbao"></see>
    /// </summary>
    let _17_UrbanBilbao = _prefix "17_UrbanBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_FestivalSaragossa"></see>
    /// </summary>
    let _18_FestivalSaragossa = _prefix "18_FestivalSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_HotelPalaceMadrid"></see>
    /// </summary>
    let _18_HotelPalaceMadrid = _prefix "18_HotelPalaceMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_MetroBilbao"></see>
    /// </summary>
    let _18_MetroBilbao = _prefix "18_MetroBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_MuseuM%C3%A0laga"></see>
    /// </summary>
    let ``_18_MuseuM%C3%A0laga`` = _prefix "18_MuseuM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#18_RestaurantSaborCadis"></see>
    /// </summary>
    let _18_RestaurantSaborCadis = _prefix "18_RestaurantSaborCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_CityBilbao"></see>
    /// </summary>
    let _19_CityBilbao = _prefix "19_CityBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_ConcertVal%C3%A8ncia"></see>
    /// </summary>
    let ``_19_ConcertVal%C3%A8ncia`` = _prefix "19_ConcertVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_HotelSolBilbao"></see>
    /// </summary>
    let _19_HotelSolBilbao = _prefix "19_HotelSolBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_PalauBarcelona"></see>
    /// </summary>
    let _19_PalauBarcelona = _prefix "19_PalauBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#19_RestaurantFusi%C3%B3Madrid"></see>
    /// </summary>
    let ``_19_RestaurantFusi%C3%B3Madrid`` = _prefix "19_RestaurantFusi%C3%B3Madrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_CastellSaragossa"></see>
    /// </summary>
    let _1_CastellSaragossa = _prefix "1_CastellSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_Congr%C3%A9sCadis"></see>
    /// </summary>
    let ``_1_Congr%C3%A9sCadis`` = _prefix "1_Congr%C3%A9sCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_HotelVistaSevilla"></see>
    /// </summary>
    let _1_HotelVistaSevilla = _prefix "1_HotelVistaSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_RestaurantTradici%C3%B3Toledo"></see>
    /// </summary>
    let ``_1_RestaurantTradici%C3%B3Toledo`` = _prefix "1_RestaurantTradici%C3%B3Toledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#1_UrbanMadrid"></see>
    /// </summary>
    let _1_UrbanMadrid = _prefix "1_UrbanMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_CarnavalSevilla"></see>
    /// </summary>
    let _20_CarnavalSevilla = _prefix "20_CarnavalSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_CatedralBarcelona"></see>
    /// </summary>
    let _20_CatedralBarcelona = _prefix "20_CatedralBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_HotelVistaVal%C3%A8ncia"></see>
    /// </summary>
    let ``_20_HotelVistaVal%C3%A8ncia`` = _prefix "20_HotelVistaVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_MoviBilbao"></see>
    /// </summary>
    let _20_MoviBilbao = _prefix "20_MoviBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#20_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_20_RestaurantGourmetM%C3%A0laga`` = _prefix "20_RestaurantGourmetM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_CatedralM%C3%A0laga"></see>
    /// </summary>
    let ``_21_CatedralM%C3%A0laga`` = _prefix "21_CatedralM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_CityPamplona"></see>
    /// </summary>
    let _21_CityPamplona = _prefix "21_CityPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_FiraSevilla"></see>
    /// </summary>
    let _21_FiraSevilla = _prefix "21_FiraSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_HotelSolVal%C3%A8ncia"></see>
    /// </summary>
    let ``_21_HotelSolVal%C3%A8ncia`` = _prefix "21_HotelSolVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#21_RestaurantDeliciaMadrid"></see>
    /// </summary>
    let _21_RestaurantDeliciaMadrid = _prefix "21_RestaurantDeliciaMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_22_CatedralVal%C3%A8ncia`` = _prefix "22_CatedralVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_FestivalSevilla"></see>
    /// </summary>
    let _22_FestivalSevilla = _prefix "22_FestivalSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_HotelVistaM%C3%A0laga"></see>
    /// </summary>
    let ``_22_HotelVistaM%C3%A0laga`` = _prefix "22_HotelVistaM%C3%A0laga"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_RestaurantTradici%C3%B3Madrid"></see>
    /// </summary>
    let ``_22_RestaurantTradici%C3%B3Madrid`` =
        _prefix "22_RestaurantTradici%C3%B3Madrid"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#22_UrbanSaragossa"></see>
    /// </summary>
    let _22_UrbanSaragossa = _prefix "22_UrbanSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_CastellSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_23_CastellSantSebasti%C3%A0`` = _prefix "23_CastellSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#SantSebasti%C3%A0"></see>
    /// </summary>
    let ``SantSebasti%C3%A0`` = _prefix "SantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_Congr%C3%A9sSaragossa"></see>
    /// </summary>
    let ``_23_Congr%C3%A9sSaragossa`` = _prefix "23_Congr%C3%A9sSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_HotelVistaToledo"></see>
    /// </summary>
    let _23_HotelVistaToledo = _prefix "23_HotelVistaToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_MoviPamplona"></see>
    /// </summary>
    let _23_MoviPamplona = _prefix "23_MoviPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#23_RestaurantFusi%C3%B3Sevilla"></see>
    /// </summary>
    let ``_23_RestaurantFusi%C3%B3Sevilla`` = _prefix "23_RestaurantFusi%C3%B3Sevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_CastellSaragossa"></see>
    /// </summary>
    let _24_CastellSaragossa = _prefix "24_CastellSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_24_Congr%C3%A9sBarcelona`` = _prefix "24_Congr%C3%A9sBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_HotelRoyalSaragossa"></see>
    /// </summary>
    let _24_HotelRoyalSaragossa = _prefix "24_HotelRoyalSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_RestaurantGourmetSevilla"></see>
    /// </summary>
    let _24_RestaurantGourmetSevilla = _prefix "24_RestaurantGourmetSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#24_UrbanVal%C3%A8ncia"></see>
    /// </summary>
    let ``_24_UrbanVal%C3%A8ncia`` = _prefix "24_UrbanVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_CarnavalM%C3%A0laga"></see>
    /// </summary>
    let ``_25_CarnavalM%C3%A0laga`` = _prefix "25_CarnavalM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_HotelRoyalSevilla"></see>
    /// </summary>
    let _25_HotelRoyalSevilla = _prefix "25_HotelRoyalSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_MetroSaragossa"></see>
    /// </summary>
    let _25_MetroSaragossa = _prefix "25_MetroSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_ParcBilbao"></see>
    /// </summary>
    let _25_ParcBilbao = _prefix "25_ParcBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#25_RestaurantFusi%C3%B3Sevilla"></see>
    /// </summary>
    let ``_25_RestaurantFusi%C3%B3Sevilla`` = _prefix "25_RestaurantFusi%C3%B3Sevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_CarnavalBilbao"></see>
    /// </summary>
    let _26_CarnavalBilbao = _prefix "26_CarnavalBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_CatedralSaragossa"></see>
    /// </summary>
    let _26_CatedralSaragossa = _prefix "26_CatedralSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_HotelSolCadis"></see>
    /// </summary>
    let _26_HotelSolCadis = _prefix "26_HotelSolCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_MetroPamplona"></see>
    /// </summary>
    let _26_MetroPamplona = _prefix "26_MetroPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#26_RestaurantGourmetPamplona"></see>
    /// </summary>
    let _26_RestaurantGourmetPamplona = _prefix "26_RestaurantGourmetPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_CastellM%C3%A0laga"></see>
    /// </summary>
    let ``_27_CastellM%C3%A0laga`` = _prefix "27_CastellM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_Congr%C3%A9sBilbao"></see>
    /// </summary>
    let ``_27_Congr%C3%A9sBilbao`` = _prefix "27_Congr%C3%A9sBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_HotelSolBilbao"></see>
    /// </summary>
    let _27_HotelSolBilbao = _prefix "27_HotelSolBilbao"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_RestaurantTradici%C3%B3SantSebasti%C3%A0"></see>
    /// </summary>
    let ``_27_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        _prefix "27_RestaurantTradici%C3%B3SantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#27_UrbanBarcelona"></see>
    /// </summary>
    let _27_UrbanBarcelona = _prefix "27_UrbanBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_FestivalToledo"></see>
    /// </summary>
    let _28_FestivalToledo = _prefix "28_FestivalToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_HotelDelMarSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_28_HotelDelMarSantSebasti%C3%A0`` = _prefix "28_HotelDelMarSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_ParcSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_28_ParcSantSebasti%C3%A0`` = _prefix "28_ParcSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_RestaurantFusi%C3%B3Cadis"></see>
    /// </summary>
    let ``_28_RestaurantFusi%C3%B3Cadis`` = _prefix "28_RestaurantFusi%C3%B3Cadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#28_UrbanPamplona"></see>
    /// </summary>
    let _28_UrbanPamplona = _prefix "28_UrbanPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_CastellSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_29_CastellSantSebasti%C3%A0`` = _prefix "29_CastellSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_FiraMadrid"></see>
    /// </summary>
    let _29_FiraMadrid = _prefix "29_FiraMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_HotelRoyalMadrid"></see>
    /// </summary>
    let _29_HotelRoyalMadrid = _prefix "29_HotelRoyalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_MetroSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_29_MetroSantSebasti%C3%A0`` = _prefix "29_MetroSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#29_RestaurantDeliciaVal%C3%A8ncia"></see>
    /// </summary>
    let ``_29_RestaurantDeliciaVal%C3%A8ncia`` =
        _prefix "29_RestaurantDeliciaVal%C3%A8ncia"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_CarnavalCadis"></see>
    /// </summary>
    let _2_CarnavalCadis = _prefix "2_CarnavalCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_CastellSevilla"></see>
    /// </summary>
    let _2_CastellSevilla = _prefix "2_CastellSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_HotelRoyalPamplona"></see>
    /// </summary>
    let _2_HotelRoyalPamplona = _prefix "2_HotelRoyalPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _2_RestaurantGourmetMadrid = _prefix "2_RestaurantGourmetMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#2_TransBilbao"></see>
    /// </summary>
    let _2_TransBilbao = _prefix "2_TransBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_CastellVal%C3%A8ncia"></see>
    /// </summary>
    let ``_30_CastellVal%C3%A8ncia`` = _prefix "30_CastellVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_FestivalMadrid"></see>
    /// </summary>
    let _30_FestivalMadrid = _prefix "30_FestivalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_HotelDelMarPamplona"></see>
    /// </summary>
    let _30_HotelDelMarPamplona = _prefix "30_HotelDelMarPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_RestaurantDeliciaPamplona"></see>
    /// </summary>
    let _30_RestaurantDeliciaPamplona = _prefix "30_RestaurantDeliciaPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#30_UrbanM%C3%A0laga"></see>
    /// </summary>
    let ``_30_UrbanM%C3%A0laga`` = _prefix "30_UrbanM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_FiraMadrid"></see>
    /// </summary>
    let _31_FiraMadrid = _prefix "31_FiraMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_HotelVistaMadrid"></see>
    /// </summary>
    let _31_HotelVistaMadrid = _prefix "31_HotelVistaMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_PalauM%C3%A0laga"></see>
    /// </summary>
    let ``_31_PalauM%C3%A0laga`` = _prefix "31_PalauM%C3%A0laga"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_RestaurantTradici%C3%B3Madrid"></see>
    /// </summary>
    let ``_31_RestaurantTradici%C3%B3Madrid`` =
        _prefix "31_RestaurantTradici%C3%B3Madrid"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#31_UrbanSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_31_UrbanSantSebasti%C3%A0`` = _prefix "31_UrbanSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_ConcertPamplona"></see>
    /// </summary>
    let _32_ConcertPamplona = _prefix "32_ConcertPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_HotelPalaceToledo"></see>
    /// </summary>
    let _32_HotelPalaceToledo = _prefix "32_HotelPalaceToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_MetroMadrid"></see>
    /// </summary>
    let _32_MetroMadrid = _prefix "32_MetroMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_MuseuSaragossa"></see>
    /// </summary>
    let _32_MuseuSaragossa = _prefix "32_MuseuSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#32_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _32_RestaurantGourmetMadrid = _prefix "32_RestaurantGourmetMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_FestivalBarcelona"></see>
    /// </summary>
    let _33_FestivalBarcelona = _prefix "33_FestivalBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_HotelSolBarcelona"></see>
    /// </summary>
    let _33_HotelSolBarcelona = _prefix "33_HotelSolBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_MetroMadrid"></see>
    /// </summary>
    let _33_MetroMadrid = _prefix "33_MetroMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_MuseuBarcelona"></see>
    /// </summary>
    let _33_MuseuBarcelona = _prefix "33_MuseuBarcelona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#33_RestaurantTradici%C3%B3Toledo"></see>
    /// </summary>
    let ``_33_RestaurantTradici%C3%B3Toledo`` =
        _prefix "33_RestaurantTradici%C3%B3Toledo"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_CarnavalSaragossa"></see>
    /// </summary>
    let _34_CarnavalSaragossa = _prefix "34_CarnavalSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_HotelDelMarBarcelona"></see>
    /// </summary>
    let _34_HotelDelMarBarcelona = _prefix "34_HotelDelMarBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_MuseuSaragossa"></see>
    /// </summary>
    let _34_MuseuSaragossa = _prefix "34_MuseuSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_RestaurantDeliciaSevilla"></see>
    /// </summary>
    let _34_RestaurantDeliciaSevilla = _prefix "34_RestaurantDeliciaSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#34_UrbanSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_34_UrbanSantSebasti%C3%A0`` = _prefix "34_UrbanSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_ConcertToledo"></see>
    /// </summary>
    let _35_ConcertToledo = _prefix "35_ConcertToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_HotelDelMarPamplona"></see>
    /// </summary>
    let _35_HotelDelMarPamplona = _prefix "35_HotelDelMarPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_MetroBilbao"></see>
    /// </summary>
    let _35_MetroBilbao = _prefix "35_MetroBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_PalauPamplona"></see>
    /// </summary>
    let _35_PalauPamplona = _prefix "35_PalauPamplona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#35_RestaurantDeliciaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_35_RestaurantDeliciaSantSebasti%C3%A0`` =
        _prefix "35_RestaurantDeliciaSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_CityBarcelona"></see>
    /// </summary>
    let _36_CityBarcelona = _prefix "36_CityBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_ConcertPamplona"></see>
    /// </summary>
    let _36_ConcertPamplona = _prefix "36_ConcertPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_HotelPalaceSaragossa"></see>
    /// </summary>
    let _36_HotelPalaceSaragossa = _prefix "36_HotelPalaceSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_ParcPamplona"></see>
    /// </summary>
    let _36_ParcPamplona = _prefix "36_ParcPamplona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#36_RestaurantFusi%C3%B3Saragossa"></see>
    /// </summary>
    let ``_36_RestaurantFusi%C3%B3Saragossa`` =
        _prefix "36_RestaurantFusi%C3%B3Saragossa"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_CastellMadrid"></see>
    /// </summary>
    let _37_CastellMadrid = _prefix "37_CastellMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_FestivalMadrid"></see>
    /// </summary>
    let _37_FestivalMadrid = _prefix "37_FestivalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_HotelDelMarVal%C3%A8ncia"></see>
    /// </summary>
    let ``_37_HotelDelMarVal%C3%A8ncia`` = _prefix "37_HotelDelMarVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_RestaurantSaborVal%C3%A8ncia"></see>
    /// </summary>
    let ``_37_RestaurantSaborVal%C3%A8ncia`` = _prefix "37_RestaurantSaborVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#37_TransM%C3%A0laga"></see>
    /// </summary>
    let ``_37_TransM%C3%A0laga`` = _prefix "37_TransM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_CarnavalSevilla"></see>
    /// </summary>
    let _38_CarnavalSevilla = _prefix "38_CarnavalSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_HotelDelMarM%C3%A0laga"></see>
    /// </summary>
    let ``_38_HotelDelMarM%C3%A0laga`` = _prefix "38_HotelDelMarM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_MoviMadrid"></see>
    /// </summary>
    let _38_MoviMadrid = _prefix "38_MoviMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_PalauToledo"></see>
    /// </summary>
    let _38_PalauToledo = _prefix "38_PalauToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#38_RestaurantDeliciaPamplona"></see>
    /// </summary>
    let _38_RestaurantDeliciaPamplona = _prefix "38_RestaurantDeliciaPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_CastellSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_39_CastellSantSebasti%C3%A0`` = _prefix "39_CastellSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_FiraBarcelona"></see>
    /// </summary>
    let _39_FiraBarcelona = _prefix "39_FiraBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_HotelSolSaragossa"></see>
    /// </summary>
    let _39_HotelSolSaragossa = _prefix "39_HotelSolSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_MoviSevilla"></see>
    /// </summary>
    let _39_MoviSevilla = _prefix "39_MoviSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#39_RestaurantFusi%C3%B3Toledo"></see>
    /// </summary>
    let ``_39_RestaurantFusi%C3%B3Toledo`` = _prefix "39_RestaurantFusi%C3%B3Toledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_CastellSaragossa"></see>
    /// </summary>
    let _3_CastellSaragossa = _prefix "3_CastellSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_Congr%C3%A9sBilbao"></see>
    /// </summary>
    let ``_3_Congr%C3%A9sBilbao`` = _prefix "3_Congr%C3%A9sBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_HotelRoyalM%C3%A0laga"></see>
    /// </summary>
    let ``_3_HotelRoyalM%C3%A0laga`` = _prefix "3_HotelRoyalM%C3%A0laga"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_RestaurantFusi%C3%B3Val%C3%A8ncia"></see>
    /// </summary>
    let ``_3_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        _prefix "3_RestaurantFusi%C3%B3Val%C3%A8ncia"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#3_TransToledo"></see>
    /// </summary>
    let _3_TransToledo = _prefix "3_TransToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_FestivalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_40_FestivalVal%C3%A8ncia`` = _prefix "40_FestivalVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_HotelDelMarSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_40_HotelDelMarSantSebasti%C3%A0`` = _prefix "40_HotelDelMarSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_PalauCadis"></see>
    /// </summary>
    let _40_PalauCadis = _prefix "40_PalauCadis"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_RestaurantGourmetVal%C3%A8ncia"></see>
    /// </summary>
    let ``_40_RestaurantGourmetVal%C3%A8ncia`` =
        _prefix "40_RestaurantGourmetVal%C3%A8ncia"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#40_UrbanToledo"></see>
    /// </summary>
    let _40_UrbanToledo = _prefix "40_UrbanToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_CatedralToledo"></see>
    /// </summary>
    let _41_CatedralToledo = _prefix "41_CatedralToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_ConcertToledo"></see>
    /// </summary>
    let _41_ConcertToledo = _prefix "41_ConcertToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_HotelRoyalCadis"></see>
    /// </summary>
    let _41_HotelRoyalCadis = _prefix "41_HotelRoyalCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_MetroBarcelona"></see>
    /// </summary>
    let _41_MetroBarcelona = _prefix "41_MetroBarcelona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#41_RestaurantTradici%C3%B3Saragossa"></see>
    /// </summary>
    let ``_41_RestaurantTradici%C3%B3Saragossa`` =
        _prefix "41_RestaurantTradici%C3%B3Saragossa"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_FestivalPamplona"></see>
    /// </summary>
    let _42_FestivalPamplona = _prefix "42_FestivalPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_HotelPalaceMadrid"></see>
    /// </summary>
    let _42_HotelPalaceMadrid = _prefix "42_HotelPalaceMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_MuseuMadrid"></see>
    /// </summary>
    let _42_MuseuMadrid = _prefix "42_MuseuMadrid"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_RestaurantTradici%C3%B3Sevilla"></see>
    /// </summary>
    let ``_42_RestaurantTradici%C3%B3Sevilla`` =
        _prefix "42_RestaurantTradici%C3%B3Sevilla"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#42_UrbanSevilla"></see>
    /// </summary>
    let _42_UrbanSevilla = _prefix "42_UrbanSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_CityPamplona"></see>
    /// </summary>
    let _43_CityPamplona = _prefix "43_CityPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_FestivalMadrid"></see>
    /// </summary>
    let _43_FestivalMadrid = _prefix "43_FestivalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_HotelRoyalPamplona"></see>
    /// </summary>
    let _43_HotelRoyalPamplona = _prefix "43_HotelRoyalPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_ParcBarcelona"></see>
    /// </summary>
    let _43_ParcBarcelona = _prefix "43_ParcBarcelona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#43_RestaurantFusi%C3%B3Barcelona"></see>
    /// </summary>
    let ``_43_RestaurantFusi%C3%B3Barcelona`` =
        _prefix "43_RestaurantFusi%C3%B3Barcelona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_Congr%C3%A9sSevilla"></see>
    /// </summary>
    let ``_44_Congr%C3%A9sSevilla`` = _prefix "44_Congr%C3%A9sSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_HotelVistaSaragossa"></see>
    /// </summary>
    let _44_HotelVistaSaragossa = _prefix "44_HotelVistaSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_MoviSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_44_MoviSantSebasti%C3%A0`` = _prefix "44_MoviSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_MuseuSevilla"></see>
    /// </summary>
    let _44_MuseuSevilla = _prefix "44_MuseuSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#44_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_44_RestaurantGourmetM%C3%A0laga`` = _prefix "44_RestaurantGourmetM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_CatedralBarcelona"></see>
    /// </summary>
    let _45_CatedralBarcelona = _prefix "45_CatedralBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_45_Congr%C3%A9sBarcelona`` = _prefix "45_Congr%C3%A9sBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_HotelRoyalBarcelona"></see>
    /// </summary>
    let _45_HotelRoyalBarcelona = _prefix "45_HotelRoyalBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_MetroPamplona"></see>
    /// </summary>
    let _45_MetroPamplona = _prefix "45_MetroPamplona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#45_RestaurantFusi%C3%B3Saragossa"></see>
    /// </summary>
    let ``_45_RestaurantFusi%C3%B3Saragossa`` =
        _prefix "45_RestaurantFusi%C3%B3Saragossa"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_Congr%C3%A9sVal%C3%A8ncia"></see>
    /// </summary>
    let ``_46_Congr%C3%A9sVal%C3%A8ncia`` = _prefix "46_Congr%C3%A9sVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_HotelVistaSevilla"></see>
    /// </summary>
    let _46_HotelVistaSevilla = _prefix "46_HotelVistaSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_MetroPamplona"></see>
    /// </summary>
    let _46_MetroPamplona = _prefix "46_MetroPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_MuseuToledo"></see>
    /// </summary>
    let _46_MuseuToledo = _prefix "46_MuseuToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#46_RestaurantSaborM%C3%A0laga"></see>
    /// </summary>
    let ``_46_RestaurantSaborM%C3%A0laga`` = _prefix "46_RestaurantSaborM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_FestivalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_47_FestivalVal%C3%A8ncia`` = _prefix "47_FestivalVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_HotelDelMarSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_47_HotelDelMarSantSebasti%C3%A0`` = _prefix "47_HotelDelMarSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_MoviSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_47_MoviSantSebasti%C3%A0`` = _prefix "47_MoviSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_PalauToledo"></see>
    /// </summary>
    let _47_PalauToledo = _prefix "47_PalauToledo"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#47_RestaurantTradici%C3%B3SantSebasti%C3%A0"></see>
    /// </summary>
    let ``_47_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        _prefix "47_RestaurantTradici%C3%B3SantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_FestivalBilbao"></see>
    /// </summary>
    let _48_FestivalBilbao = _prefix "48_FestivalBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_HotelPalaceM%C3%A0laga"></see>
    /// </summary>
    let ``_48_HotelPalaceM%C3%A0laga`` = _prefix "48_HotelPalaceM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_MoviToledo"></see>
    /// </summary>
    let _48_MoviToledo = _prefix "48_MoviToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_ParcSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_48_ParcSantSebasti%C3%A0`` = _prefix "48_ParcSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#48_RestaurantSaborSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_48_RestaurantSaborSantSebasti%C3%A0`` =
        _prefix "48_RestaurantSaborSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_CastellSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_49_CastellSantSebasti%C3%A0`` = _prefix "49_CastellSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_CityMadrid"></see>
    /// </summary>
    let _49_CityMadrid = _prefix "49_CityMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_ConcertSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_49_ConcertSantSebasti%C3%A0`` = _prefix "49_ConcertSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_HotelVistaPamplona"></see>
    /// </summary>
    let _49_HotelVistaPamplona = _prefix "49_HotelVistaPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#49_RestaurantSaborM%C3%A0laga"></see>
    /// </summary>
    let ``_49_RestaurantSaborM%C3%A0laga`` = _prefix "49_RestaurantSaborM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_CarnavalSevilla"></see>
    /// </summary>
    let _4_CarnavalSevilla = _prefix "4_CarnavalSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_CitySaragossa"></see>
    /// </summary>
    let _4_CitySaragossa = _prefix "4_CitySaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_HotelRoyalBilbao"></see>
    /// </summary>
    let _4_HotelRoyalBilbao = _prefix "4_HotelRoyalBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_MuseuMadrid"></see>
    /// </summary>
    let _4_MuseuMadrid = _prefix "4_MuseuMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#4_RestaurantDeliciaM%C3%A0laga"></see>
    /// </summary>
    let ``_4_RestaurantDeliciaM%C3%A0laga`` = _prefix "4_RestaurantDeliciaM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_FestivalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_50_FestivalVal%C3%A8ncia`` = _prefix "50_FestivalVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_HotelSolCadis"></see>
    /// </summary>
    let _50_HotelSolCadis = _prefix "50_HotelSolCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_ParcM%C3%A0laga"></see>
    /// </summary>
    let ``_50_ParcM%C3%A0laga`` = _prefix "50_ParcM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_RestaurantDeliciaBarcelona"></see>
    /// </summary>
    let _50_RestaurantDeliciaBarcelona = _prefix "50_RestaurantDeliciaBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#50_UrbanSaragossa"></see>
    /// </summary>
    let _50_UrbanSaragossa = _prefix "50_UrbanSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_CarnavalM%C3%A0laga"></see>
    /// </summary>
    let ``_51_CarnavalM%C3%A0laga`` = _prefix "51_CarnavalM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_HotelPalacePamplona"></see>
    /// </summary>
    let _51_HotelPalacePamplona = _prefix "51_HotelPalacePamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_PalauMadrid"></see>
    /// </summary>
    let _51_PalauMadrid = _prefix "51_PalauMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_RestaurantDeliciaSevilla"></see>
    /// </summary>
    let _51_RestaurantDeliciaSevilla = _prefix "51_RestaurantDeliciaSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#51_UrbanMadrid"></see>
    /// </summary>
    let _51_UrbanMadrid = _prefix "51_UrbanMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_CatedralMadrid"></see>
    /// </summary>
    let _52_CatedralMadrid = _prefix "52_CatedralMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_Congr%C3%A9sToledo"></see>
    /// </summary>
    let ``_52_Congr%C3%A9sToledo`` = _prefix "52_Congr%C3%A9sToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_HotelSolSevilla"></see>
    /// </summary>
    let _52_HotelSolSevilla = _prefix "52_HotelSolSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _52_RestaurantDeliciaSaragossa = _prefix "52_RestaurantDeliciaSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#52_TransMadrid"></see>
    /// </summary>
    let _52_TransMadrid = _prefix "52_TransMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_53_CatedralVal%C3%A8ncia`` = _prefix "53_CatedralVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_FiraBarcelona"></see>
    /// </summary>
    let _53_FiraBarcelona = _prefix "53_FiraBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_HotelDelMarM%C3%A0laga"></see>
    /// </summary>
    let ``_53_HotelDelMarM%C3%A0laga`` = _prefix "53_HotelDelMarM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_RestaurantDeliciaCadis"></see>
    /// </summary>
    let _53_RestaurantDeliciaCadis = _prefix "53_RestaurantDeliciaCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#53_UrbanToledo"></see>
    /// </summary>
    let _53_UrbanToledo = _prefix "53_UrbanToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_CatedralToledo"></see>
    /// </summary>
    let _54_CatedralToledo = _prefix "54_CatedralToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_FiraPamplona"></see>
    /// </summary>
    let _54_FiraPamplona = _prefix "54_FiraPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_HotelPalaceToledo"></see>
    /// </summary>
    let _54_HotelPalaceToledo = _prefix "54_HotelPalaceToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_MetroM%C3%A0laga"></see>
    /// </summary>
    let ``_54_MetroM%C3%A0laga`` = _prefix "54_MetroM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#54_RestaurantSaborSevilla"></see>
    /// </summary>
    let _54_RestaurantSaborSevilla = _prefix "54_RestaurantSaborSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_FiraSaragossa"></see>
    /// </summary>
    let _55_FiraSaragossa = _prefix "55_FiraSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_HotelVistaCadis"></see>
    /// </summary>
    let _55_HotelVistaCadis = _prefix "55_HotelVistaCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_MoviToledo"></see>
    /// </summary>
    let _55_MoviToledo = _prefix "55_MoviToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_ParcSaragossa"></see>
    /// </summary>
    let _55_ParcSaragossa = _prefix "55_ParcSaragossa"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#55_RestaurantFusi%C3%B3M%C3%A0laga"></see>
    /// </summary>
    let ``_55_RestaurantFusi%C3%B3M%C3%A0laga`` =
        _prefix "55_RestaurantFusi%C3%B3M%C3%A0laga"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_FestivalBarcelona"></see>
    /// </summary>
    let _56_FestivalBarcelona = _prefix "56_FestivalBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_HotelDelMarCadis"></see>
    /// </summary>
    let _56_HotelDelMarCadis = _prefix "56_HotelDelMarCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_MuseuToledo"></see>
    /// </summary>
    let _56_MuseuToledo = _prefix "56_MuseuToledo"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_RestaurantTradici%C3%B3Madrid"></see>
    /// </summary>
    let ``_56_RestaurantTradici%C3%B3Madrid`` =
        _prefix "56_RestaurantTradici%C3%B3Madrid"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#56_TransVal%C3%A8ncia"></see>
    /// </summary>
    let ``_56_TransVal%C3%A8ncia`` = _prefix "56_TransVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_57_Congr%C3%A9sBarcelona`` = _prefix "57_Congr%C3%A9sBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_HotelSolSevilla"></see>
    /// </summary>
    let _57_HotelSolSevilla = _prefix "57_HotelSolSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_MoviVal%C3%A8ncia"></see>
    /// </summary>
    let ``_57_MoviVal%C3%A8ncia`` = _prefix "57_MoviVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_ParcCadis"></see>
    /// </summary>
    let _57_ParcCadis = _prefix "57_ParcCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#57_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_57_RestaurantGourmetM%C3%A0laga`` = _prefix "57_RestaurantGourmetM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_CarnavalSevilla"></see>
    /// </summary>
    let _58_CarnavalSevilla = _prefix "58_CarnavalSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_CatedralM%C3%A0laga"></see>
    /// </summary>
    let ``_58_CatedralM%C3%A0laga`` = _prefix "58_CatedralM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_HotelDelMarSevilla"></see>
    /// </summary>
    let _58_HotelDelMarSevilla = _prefix "58_HotelDelMarSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_MoviPamplona"></see>
    /// </summary>
    let _58_MoviPamplona = _prefix "58_MoviPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#58_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _58_RestaurantDeliciaSaragossa = _prefix "58_RestaurantDeliciaSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_CatedralBilbao"></see>
    /// </summary>
    let _59_CatedralBilbao = _prefix "59_CatedralBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_FestivalM%C3%A0laga"></see>
    /// </summary>
    let ``_59_FestivalM%C3%A0laga`` = _prefix "59_FestivalM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_HotelVistaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_59_HotelVistaSantSebasti%C3%A0`` = _prefix "59_HotelVistaSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_MetroSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_59_MetroSantSebasti%C3%A0`` = _prefix "59_MetroSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#59_RestaurantFusi%C3%B3Cadis"></see>
    /// </summary>
    let ``_59_RestaurantFusi%C3%B3Cadis`` = _prefix "59_RestaurantFusi%C3%B3Cadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_CastellCadis"></see>
    /// </summary>
    let _5_CastellCadis = _prefix "5_CastellCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_FiraToledo"></see>
    /// </summary>
    let _5_FiraToledo = _prefix "5_FiraToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_HotelPalaceSaragossa"></see>
    /// </summary>
    let _5_HotelPalaceSaragossa = _prefix "5_HotelPalaceSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_MoviCadis"></see>
    /// </summary>
    let _5_MoviCadis = _prefix "5_MoviCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#5_RestaurantDeliciaPamplona"></see>
    /// </summary>
    let _5_RestaurantDeliciaPamplona = _prefix "5_RestaurantDeliciaPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_FiraSevilla"></see>
    /// </summary>
    let _60_FiraSevilla = _prefix "60_FiraSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_HotelDelMarBarcelona"></see>
    /// </summary>
    let _60_HotelDelMarBarcelona = _prefix "60_HotelDelMarBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_ParcCadis"></see>
    /// </summary>
    let _60_ParcCadis = _prefix "60_ParcCadis"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_RestaurantDeliciaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_60_RestaurantDeliciaSantSebasti%C3%A0`` =
        _prefix "60_RestaurantDeliciaSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#60_UrbanMadrid"></see>
    /// </summary>
    let _60_UrbanMadrid = _prefix "60_UrbanMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_CarnavalToledo"></see>
    /// </summary>
    let _61_CarnavalToledo = _prefix "61_CarnavalToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_HotelDelMarCadis"></see>
    /// </summary>
    let _61_HotelDelMarCadis = _prefix "61_HotelDelMarCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_MetroBilbao"></see>
    /// </summary>
    let _61_MetroBilbao = _prefix "61_MetroBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_PalauSaragossa"></see>
    /// </summary>
    let _61_PalauSaragossa = _prefix "61_PalauSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#61_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _61_RestaurantGourmetMadrid = _prefix "61_RestaurantGourmetMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_CarnavalCadis"></see>
    /// </summary>
    let _62_CarnavalCadis = _prefix "62_CarnavalCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_62_CatedralVal%C3%A8ncia`` = _prefix "62_CatedralVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_CityCadis"></see>
    /// </summary>
    let _62_CityCadis = _prefix "62_CityCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_HotelPalaceBarcelona"></see>
    /// </summary>
    let _62_HotelPalaceBarcelona = _prefix "62_HotelPalaceBarcelona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#62_RestaurantTradici%C3%B3SantSebasti%C3%A0"></see>
    /// </summary>
    let ``_62_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        _prefix "62_RestaurantTradici%C3%B3SantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_FiraM%C3%A0laga"></see>
    /// </summary>
    let ``_63_FiraM%C3%A0laga`` = _prefix "63_FiraM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_HotelSolBarcelona"></see>
    /// </summary>
    let _63_HotelSolBarcelona = _prefix "63_HotelSolBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_MetroM%C3%A0laga"></see>
    /// </summary>
    let ``_63_MetroM%C3%A0laga`` = _prefix "63_MetroM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_MuseuSaragossa"></see>
    /// </summary>
    let _63_MuseuSaragossa = _prefix "63_MuseuSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#63_RestaurantTradici%C3%B3Cadis"></see>
    /// </summary>
    let ``_63_RestaurantTradici%C3%B3Cadis`` = _prefix "63_RestaurantTradici%C3%B3Cadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_CityBarcelona"></see>
    /// </summary>
    let _64_CityBarcelona = _prefix "64_CityBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_FiraMadrid"></see>
    /// </summary>
    let _64_FiraMadrid = _prefix "64_FiraMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_HotelPalaceBarcelona"></see>
    /// </summary>
    let _64_HotelPalaceBarcelona = _prefix "64_HotelPalaceBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_MuseuSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_64_MuseuSantSebasti%C3%A0`` = _prefix "64_MuseuSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#64_RestaurantTradici%C3%B3M%C3%A0laga"></see>
    /// </summary>
    let ``_64_RestaurantTradici%C3%B3M%C3%A0laga`` =
        _prefix "64_RestaurantTradici%C3%B3M%C3%A0laga"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_CarnavalBarcelona"></see>
    /// </summary>
    let _65_CarnavalBarcelona = _prefix "65_CarnavalBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_HotelPalaceToledo"></see>
    /// </summary>
    let _65_HotelPalaceToledo = _prefix "65_HotelPalaceToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_ParcM%C3%A0laga"></see>
    /// </summary>
    let ``_65_ParcM%C3%A0laga`` = _prefix "65_ParcM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_65_RestaurantGourmetM%C3%A0laga`` = _prefix "65_RestaurantGourmetM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#65_UrbanPamplona"></see>
    /// </summary>
    let _65_UrbanPamplona = _prefix "65_UrbanPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_FestivalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_66_FestivalVal%C3%A8ncia`` = _prefix "66_FestivalVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_HotelSolMadrid"></see>
    /// </summary>
    let _66_HotelSolMadrid = _prefix "66_HotelSolMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_MetroSevilla"></see>
    /// </summary>
    let _66_MetroSevilla = _prefix "66_MetroSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_MuseuSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_66_MuseuSantSebasti%C3%A0`` = _prefix "66_MuseuSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#66_RestaurantFusi%C3%B3Barcelona"></see>
    /// </summary>
    let ``_66_RestaurantFusi%C3%B3Barcelona`` =
        _prefix "66_RestaurantFusi%C3%B3Barcelona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_ConcertToledo"></see>
    /// </summary>
    let _67_ConcertToledo = _prefix "67_ConcertToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_HotelVistaMadrid"></see>
    /// </summary>
    let _67_HotelVistaMadrid = _prefix "67_HotelVistaMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_MetroToledo"></see>
    /// </summary>
    let _67_MetroToledo = _prefix "67_MetroToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_ParcCadis"></see>
    /// </summary>
    let _67_ParcCadis = _prefix "67_ParcCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#67_RestaurantFusi%C3%B3Toledo"></see>
    /// </summary>
    let ``_67_RestaurantFusi%C3%B3Toledo`` = _prefix "67_RestaurantFusi%C3%B3Toledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_CastellMadrid"></see>
    /// </summary>
    let _68_CastellMadrid = _prefix "68_CastellMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_FiraPamplona"></see>
    /// </summary>
    let _68_FiraPamplona = _prefix "68_FiraPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_HotelDelMarMadrid"></see>
    /// </summary>
    let _68_HotelDelMarMadrid = _prefix "68_HotelDelMarMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_TransM%C3%A0laga"></see>
    /// </summary>
    let ``_68_TransM%C3%A0laga`` = _prefix "68_TransM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#68_estaurantGourmetBarcelona"></see>
    /// </summary>
    let _68_estaurantGourmetBarcelona = _prefix "68_estaurantGourmetBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_Congr%C3%A9sSaragossa"></see>
    /// </summary>
    let ``_69_Congr%C3%A9sSaragossa`` = _prefix "69_Congr%C3%A9sSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_HotelRoyalMadrid"></see>
    /// </summary>
    let _69_HotelRoyalMadrid = _prefix "69_HotelRoyalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_MetroPamplona"></see>
    /// </summary>
    let _69_MetroPamplona = _prefix "69_MetroPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_ParcCadis"></see>
    /// </summary>
    let _69_ParcCadis = _prefix "69_ParcCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#69_RestaurantGourmetBarcelona"></see>
    /// </summary>
    let _69_RestaurantGourmetBarcelona = _prefix "69_RestaurantGourmetBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_Congr%C3%A9sBilbao"></see>
    /// </summary>
    let ``_6_Congr%C3%A9sBilbao`` = _prefix "6_Congr%C3%A9sBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_HotelRoyalSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_6_HotelRoyalSantSebasti%C3%A0`` = _prefix "6_HotelRoyalSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_PalauBilbao"></see>
    /// </summary>
    let _6_PalauBilbao = _prefix "6_PalauBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_RestaurantSaborSevilla"></see>
    /// </summary>
    let _6_RestaurantSaborSevilla = _prefix "6_RestaurantSaborSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#6_TransPamplona"></see>
    /// </summary>
    let _6_TransPamplona = _prefix "6_TransPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_CastellPamplona"></see>
    /// </summary>
    let _70_CastellPamplona = _prefix "70_CastellPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_Congr%C3%A9sSaragossa"></see>
    /// </summary>
    let ``_70_Congr%C3%A9sSaragossa`` = _prefix "70_Congr%C3%A9sSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_HotelRoyalSaragossa"></see>
    /// </summary>
    let _70_HotelRoyalSaragossa = _prefix "70_HotelRoyalSaragossa"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_RestaurantFusi%C3%B3Saragossa"></see>
    /// </summary>
    let ``_70_RestaurantFusi%C3%B3Saragossa`` =
        _prefix "70_RestaurantFusi%C3%B3Saragossa"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#70_UrbanBilbao"></see>
    /// </summary>
    let _70_UrbanBilbao = _prefix "70_UrbanBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_FiraM%C3%A0laga"></see>
    /// </summary>
    let ``_71_FiraM%C3%A0laga`` = _prefix "71_FiraM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_HotelDelMarM%C3%A0laga"></see>
    /// </summary>
    let ``_71_HotelDelMarM%C3%A0laga`` = _prefix "71_HotelDelMarM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_MoviBarcelona"></see>
    /// </summary>
    let _71_MoviBarcelona = _prefix "71_MoviBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_ParcMadrid"></see>
    /// </summary>
    let _71_ParcMadrid = _prefix "71_ParcMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#71_RestaurantTradici%C3%B3Cadis"></see>
    /// </summary>
    let ``_71_RestaurantTradici%C3%B3Cadis`` = _prefix "71_RestaurantTradici%C3%B3Cadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_FiraCadis"></see>
    /// </summary>
    let _72_FiraCadis = _prefix "72_FiraCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_HotelDelMarSaragossa"></see>
    /// </summary>
    let _72_HotelDelMarSaragossa = _prefix "72_HotelDelMarSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_ParcVal%C3%A8ncia"></see>
    /// </summary>
    let ``_72_ParcVal%C3%A8ncia`` = _prefix "72_ParcVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_RestaurantFusi%C3%B3Bilbao"></see>
    /// </summary>
    let ``_72_RestaurantFusi%C3%B3Bilbao`` = _prefix "72_RestaurantFusi%C3%B3Bilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#72_UrbanSevilla"></see>
    /// </summary>
    let _72_UrbanSevilla = _prefix "72_UrbanSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_CarnavalSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_73_CarnavalSantSebasti%C3%A0`` = _prefix "73_CarnavalSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_73_CatedralVal%C3%A8ncia`` = _prefix "73_CatedralVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_HotelVistaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_73_HotelVistaSantSebasti%C3%A0`` = _prefix "73_HotelVistaSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_RestaurantGourmetVal%C3%A8ncia"></see>
    /// </summary>
    let ``_73_RestaurantGourmetVal%C3%A8ncia`` =
        _prefix "73_RestaurantGourmetVal%C3%A8ncia"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#73_TransCadis"></see>
    /// </summary>
    let _73_TransCadis = _prefix "73_TransCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_CarnavalM%C3%A0laga"></see>
    /// </summary>
    let ``_74_CarnavalM%C3%A0laga`` = _prefix "74_CarnavalM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_HotelPalacePamplona"></see>
    /// </summary>
    let _74_HotelPalacePamplona = _prefix "74_HotelPalacePamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_PalauMadrid"></see>
    /// </summary>
    let _74_PalauMadrid = _prefix "74_PalauMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_RestaurantGourmetPamplona"></see>
    /// </summary>
    let _74_RestaurantGourmetPamplona = _prefix "74_RestaurantGourmetPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#74_UrbanSevilla"></see>
    /// </summary>
    let _74_UrbanSevilla = _prefix "74_UrbanSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_CatedralToledo"></see>
    /// </summary>
    let _75_CatedralToledo = _prefix "75_CatedralToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_FiraSevilla"></see>
    /// </summary>
    let _75_FiraSevilla = _prefix "75_FiraSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_HotelRoyalMadrid"></see>
    /// </summary>
    let _75_HotelRoyalMadrid = _prefix "75_HotelRoyalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_MetroPamplona"></see>
    /// </summary>
    let _75_MetroPamplona = _prefix "75_MetroPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#75_RestaurantSaborSevilla"></see>
    /// </summary>
    let _75_RestaurantSaborSevilla = _prefix "75_RestaurantSaborSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_CityMadrid"></see>
    /// </summary>
    let _76_CityMadrid = _prefix "76_CityMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_ConcertM%C3%A0laga"></see>
    /// </summary>
    let ``_76_ConcertM%C3%A0laga`` = _prefix "76_ConcertM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_HotelVistaBarcelona"></see>
    /// </summary>
    let _76_HotelVistaBarcelona = _prefix "76_HotelVistaBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_PalauBarcelona"></see>
    /// </summary>
    let _76_PalauBarcelona = _prefix "76_PalauBarcelona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#76_RestaurantFusi%C3%B3Val%C3%A8ncia"></see>
    /// </summary>
    let ``_76_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        _prefix "76_RestaurantFusi%C3%B3Val%C3%A8ncia"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_FestivalToledo"></see>
    /// </summary>
    let _77_FestivalToledo = _prefix "77_FestivalToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_HotelSolBarcelona"></see>
    /// </summary>
    let _77_HotelSolBarcelona = _prefix "77_HotelSolBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_MetroMadrid"></see>
    /// </summary>
    let _77_MetroMadrid = _prefix "77_MetroMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_PalauPamplona"></see>
    /// </summary>
    let _77_PalauPamplona = _prefix "77_PalauPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#77_RestaurantDeliciaSevilla"></see>
    /// </summary>
    let _77_RestaurantDeliciaSevilla = _prefix "77_RestaurantDeliciaSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_CarnavalCadis"></see>
    /// </summary>
    let _78_CarnavalCadis = _prefix "78_CarnavalCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_CastellBilbao"></see>
    /// </summary>
    let _78_CastellBilbao = _prefix "78_CastellBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_HotelRoyalBilbao"></see>
    /// </summary>
    let _78_HotelRoyalBilbao = _prefix "78_HotelRoyalBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_MoviBilbao"></see>
    /// </summary>
    let _78_MoviBilbao = _prefix "78_MoviBilbao"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#78_RestaurantFusi%C3%B3Val%C3%A8ncia"></see>
    /// </summary>
    let ``_78_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        _prefix "78_RestaurantFusi%C3%B3Val%C3%A8ncia"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_CatedralPamplona"></see>
    /// </summary>
    let _79_CatedralPamplona = _prefix "79_CatedralPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_Congr%C3%A9sCadis"></see>
    /// </summary>
    let ``_79_Congr%C3%A9sCadis`` = _prefix "79_Congr%C3%A9sCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_HotelSolM%C3%A0laga"></see>
    /// </summary>
    let ``_79_HotelSolM%C3%A0laga`` = _prefix "79_HotelSolM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_RestaurantSaborM%C3%A0laga"></see>
    /// </summary>
    let ``_79_RestaurantSaborM%C3%A0laga`` = _prefix "79_RestaurantSaborM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#79_TransSevilla"></see>
    /// </summary>
    let _79_TransSevilla = _prefix "79_TransSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_CatedralSevilla"></see>
    /// </summary>
    let _7_CatedralSevilla = _prefix "7_CatedralSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_FestivalMadrid"></see>
    /// </summary>
    let _7_FestivalMadrid = _prefix "7_FestivalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_HotelRoyalVal%C3%A8ncia"></see>
    /// </summary>
    let ``_7_HotelRoyalVal%C3%A8ncia`` = _prefix "7_HotelRoyalVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_MetroCadis"></see>
    /// </summary>
    let _7_MetroCadis = _prefix "7_MetroCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#7_RestaurantGourmetSaragossa"></see>
    /// </summary>
    let _7_RestaurantGourmetSaragossa = _prefix "7_RestaurantGourmetSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_ConcertM%C3%A0laga"></see>
    /// </summary>
    let ``_80_ConcertM%C3%A0laga`` = _prefix "80_ConcertM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_HotelVistaSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_80_HotelVistaSantSebasti%C3%A0`` = _prefix "80_HotelVistaSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_ParcMadrid"></see>
    /// </summary>
    let _80_ParcMadrid = _prefix "80_ParcMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_RestaurantGourmetPamplona"></see>
    /// </summary>
    let _80_RestaurantGourmetPamplona = _prefix "80_RestaurantGourmetPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#80_TransPamplona"></see>
    /// </summary>
    let _80_TransPamplona = _prefix "80_TransPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_CityBilbao"></see>
    /// </summary>
    let _81_CityBilbao = _prefix "81_CityBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_Congr%C3%A9sToledo"></see>
    /// </summary>
    let ``_81_Congr%C3%A9sToledo`` = _prefix "81_Congr%C3%A9sToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_HotelVistaBarcelona"></see>
    /// </summary>
    let _81_HotelVistaBarcelona = _prefix "81_HotelVistaBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_ParcSevilla"></see>
    /// </summary>
    let _81_ParcSevilla = _prefix "81_ParcSevilla"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#81_RestaurantGourmetSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_81_RestaurantGourmetSantSebasti%C3%A0`` =
        _prefix "81_RestaurantGourmetSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_CityMadrid"></see>
    /// </summary>
    let _82_CityMadrid = _prefix "82_CityMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_Congr%C3%A9sToledo"></see>
    /// </summary>
    let ``_82_Congr%C3%A9sToledo`` = _prefix "82_Congr%C3%A9sToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_HotelPalaceBilbao"></see>
    /// </summary>
    let _82_HotelPalaceBilbao = _prefix "82_HotelPalaceBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_PalauVal%C3%A8ncia"></see>
    /// </summary>
    let ``_82_PalauVal%C3%A8ncia`` = _prefix "82_PalauVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#82_RestaurantGourmetMadrid"></see>
    /// </summary>
    let _82_RestaurantGourmetMadrid = _prefix "82_RestaurantGourmetMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_CastellM%C3%A0laga"></see>
    /// </summary>
    let ``_83_CastellM%C3%A0laga`` = _prefix "83_CastellM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_CityToledo"></see>
    /// </summary>
    let _83_CityToledo = _prefix "83_CityToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_ConcertCadis"></see>
    /// </summary>
    let _83_ConcertCadis = _prefix "83_ConcertCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_HotelPalaceCadis"></see>
    /// </summary>
    let _83_HotelPalaceCadis = _prefix "83_HotelPalaceCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#83_RestaurantDeliciaBilbao"></see>
    /// </summary>
    let _83_RestaurantDeliciaBilbao = _prefix "83_RestaurantDeliciaBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_CastellPamplona"></see>
    /// </summary>
    let _84_CastellPamplona = _prefix "84_CastellPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_FestivalSaragossa"></see>
    /// </summary>
    let _84_FestivalSaragossa = _prefix "84_FestivalSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_HotelVistaMadrid"></see>
    /// </summary>
    let _84_HotelVistaMadrid = _prefix "84_HotelVistaMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_RestaurantFusi%C3%B3Pamplona"></see>
    /// </summary>
    let ``_84_RestaurantFusi%C3%B3Pamplona`` = _prefix "84_RestaurantFusi%C3%B3Pamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#84_TransSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_84_TransSantSebasti%C3%A0`` = _prefix "84_TransSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_CastellPamplona"></see>
    /// </summary>
    let _85_CastellPamplona = _prefix "85_CastellPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_FestivalSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_85_FestivalSantSebasti%C3%A0`` = _prefix "85_FestivalSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_HotelPalaceMadrid"></see>
    /// </summary>
    let _85_HotelPalaceMadrid = _prefix "85_HotelPalaceMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_MoviSevilla"></see>
    /// </summary>
    let _85_MoviSevilla = _prefix "85_MoviSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#85_RestaurantFusi%C3%B3Madrid"></see>
    /// </summary>
    let ``_85_RestaurantFusi%C3%B3Madrid`` = _prefix "85_RestaurantFusi%C3%B3Madrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_CitySevilla"></see>
    /// </summary>
    let _86_CitySevilla = _prefix "86_CitySevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_FiraToledo"></see>
    /// </summary>
    let _86_FiraToledo = _prefix "86_FiraToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_HotelVistaToledo"></see>
    /// </summary>
    let _86_HotelVistaToledo = _prefix "86_HotelVistaToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_MuseuSaragossa"></see>
    /// </summary>
    let _86_MuseuSaragossa = _prefix "86_MuseuSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#86_RestaurantFusi%C3%B3Cadis"></see>
    /// </summary>
    let ``_86_RestaurantFusi%C3%B3Cadis`` = _prefix "86_RestaurantFusi%C3%B3Cadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_FestivalMadrid"></see>
    /// </summary>
    let _87_FestivalMadrid = _prefix "87_FestivalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_HotelSolSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_87_HotelSolSantSebasti%C3%A0`` = _prefix "87_HotelSolSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_MoviBarcelona"></see>
    /// </summary>
    let _87_MoviBarcelona = _prefix "87_MoviBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_ParcSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_87_ParcSantSebasti%C3%A0`` = _prefix "87_ParcSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#87_RestaurantSaborVal%C3%A8ncia"></see>
    /// </summary>
    let ``_87_RestaurantSaborVal%C3%A8ncia`` = _prefix "87_RestaurantSaborVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_FestivalToledo"></see>
    /// </summary>
    let _88_FestivalToledo = _prefix "88_FestivalToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_HotelVistaBarcelona"></see>
    /// </summary>
    let _88_HotelVistaBarcelona = _prefix "88_HotelVistaBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_PalauToledo"></see>
    /// </summary>
    let _88_PalauToledo = _prefix "88_PalauToledo"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_RestaurantFusi%C3%B3Barcelona"></see>
    /// </summary>
    let ``_88_RestaurantFusi%C3%B3Barcelona`` =
        _prefix "88_RestaurantFusi%C3%B3Barcelona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#88_TransSaragossa"></see>
    /// </summary>
    let _88_TransSaragossa = _prefix "88_TransSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_CastellSaragossa"></see>
    /// </summary>
    let _89_CastellSaragossa = _prefix "89_CastellSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_FiraSaragossa"></see>
    /// </summary>
    let _89_FiraSaragossa = _prefix "89_FiraSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_HotelVistaBilbao"></see>
    /// </summary>
    let _89_HotelVistaBilbao = _prefix "89_HotelVistaBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_RestaurantGourmetM%C3%A0laga"></see>
    /// </summary>
    let ``_89_RestaurantGourmetM%C3%A0laga`` = _prefix "89_RestaurantGourmetM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#89_UrbanVal%C3%A8ncia"></see>
    /// </summary>
    let ``_89_UrbanVal%C3%A8ncia`` = _prefix "89_UrbanVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_CityMadrid"></see>
    /// </summary>
    let _8_CityMadrid = _prefix "8_CityMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_FiraM%C3%A0laga"></see>
    /// </summary>
    let ``_8_FiraM%C3%A0laga`` = _prefix "8_FiraM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_HotelVistaCadis"></see>
    /// </summary>
    let _8_HotelVistaCadis = _prefix "8_HotelVistaCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_ParcSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_8_ParcSantSebasti%C3%A0`` = _prefix "8_ParcSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#8_RestaurantGourmetToledo"></see>
    /// </summary>
    let _8_RestaurantGourmetToledo = _prefix "8_RestaurantGourmetToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_CitySaragossa"></see>
    /// </summary>
    let _90_CitySaragossa = _prefix "90_CitySaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_Congr%C3%A9sVal%C3%A8ncia"></see>
    /// </summary>
    let ``_90_Congr%C3%A9sVal%C3%A8ncia`` = _prefix "90_Congr%C3%A9sVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_HotelDelMarSevilla"></see>
    /// </summary>
    let _90_HotelDelMarSevilla = _prefix "90_HotelDelMarSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_MuseuPamplona"></see>
    /// </summary>
    let _90_MuseuPamplona = _prefix "90_MuseuPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#90_RestaurantDeliciaSaragossa"></see>
    /// </summary>
    let _90_RestaurantDeliciaSaragossa = _prefix "90_RestaurantDeliciaSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_CarnavalMadrid"></see>
    /// </summary>
    let _91_CarnavalMadrid = _prefix "91_CarnavalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_CatedralSevilla"></see>
    /// </summary>
    let _91_CatedralSevilla = _prefix "91_CatedralSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_HotelDelMarVal%C3%A8ncia"></see>
    /// </summary>
    let ``_91_HotelDelMarVal%C3%A8ncia`` = _prefix "91_HotelDelMarVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_RestaurantGourmetSaragossa"></see>
    /// </summary>
    let _91_RestaurantGourmetSaragossa = _prefix "91_RestaurantGourmetSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#91_UrbanBilbao"></see>
    /// </summary>
    let _91_UrbanBilbao = _prefix "91_UrbanBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_FestivalCadis"></see>
    /// </summary>
    let _92_FestivalCadis = _prefix "92_FestivalCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_HotelRoyalM%C3%A0laga"></see>
    /// </summary>
    let ``_92_HotelRoyalM%C3%A0laga`` = _prefix "92_HotelRoyalM%C3%A0laga"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_MetroMadrid"></see>
    /// </summary>
    let _92_MetroMadrid = _prefix "92_MetroMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_MuseuCadis"></see>
    /// </summary>
    let _92_MuseuCadis = _prefix "92_MuseuCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#92_RestaurantGourmetPamplona"></see>
    /// </summary>
    let _92_RestaurantGourmetPamplona = _prefix "92_RestaurantGourmetPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_ConcertCadis"></see>
    /// </summary>
    let _93_ConcertCadis = _prefix "93_ConcertCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_HotelDelMarMadrid"></see>
    /// </summary>
    let _93_HotelDelMarMadrid = _prefix "93_HotelDelMarMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_ParcToledo"></see>
    /// </summary>
    let _93_ParcToledo = _prefix "93_ParcToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_RestaurantSaborSaragossa"></see>
    /// </summary>
    let _93_RestaurantSaborSaragossa = _prefix "93_RestaurantSaborSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#93_TransVal%C3%A8ncia"></see>
    /// </summary>
    let ``_93_TransVal%C3%A8ncia`` = _prefix "93_TransVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_CatedralToledo"></see>
    /// </summary>
    let _94_CatedralToledo = _prefix "94_CatedralToledo"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_FestivalMadrid"></see>
    /// </summary>
    let _94_FestivalMadrid = _prefix "94_FestivalMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_HotelVistaBilbao"></see>
    /// </summary>
    let _94_HotelVistaBilbao = _prefix "94_HotelVistaBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_MoviM%C3%A0laga"></see>
    /// </summary>
    let ``_94_MoviM%C3%A0laga`` = _prefix "94_MoviM%C3%A0laga"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#94_RestaurantTradici%C3%B3Sevilla"></see>
    /// </summary>
    let ``_94_RestaurantTradici%C3%B3Sevilla`` =
        _prefix "94_RestaurantTradici%C3%B3Sevilla"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_CatedralVal%C3%A8ncia"></see>
    /// </summary>
    let ``_95_CatedralVal%C3%A8ncia`` = _prefix "95_CatedralVal%C3%A8ncia"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_ConcertSaragossa"></see>
    /// </summary>
    let _95_ConcertSaragossa = _prefix "95_ConcertSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_HotelPalacePamplona"></see>
    /// </summary>
    let _95_HotelPalacePamplona = _prefix "95_HotelPalacePamplona"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_RestaurantTradici%C3%B3Sevilla"></see>
    /// </summary>
    let ``_95_RestaurantTradici%C3%B3Sevilla`` =
        _prefix "95_RestaurantTradici%C3%B3Sevilla"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#95_TransMadrid"></see>
    /// </summary>
    let _95_TransMadrid = _prefix "95_TransMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_Congr%C3%A9sBarcelona"></see>
    /// </summary>
    let ``_96_Congr%C3%A9sBarcelona`` = _prefix "96_Congr%C3%A9sBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_HotelVistaPamplona"></see>
    /// </summary>
    let _96_HotelVistaPamplona = _prefix "96_HotelVistaPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_MuseuMadrid"></see>
    /// </summary>
    let _96_MuseuMadrid = _prefix "96_MuseuMadrid"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_RestaurantTradici%C3%B3Madrid"></see>
    /// </summary>
    let ``_96_RestaurantTradici%C3%B3Madrid`` =
        _prefix "96_RestaurantTradici%C3%B3Madrid"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#96_TransSaragossa"></see>
    /// </summary>
    let _96_TransSaragossa = _prefix "96_TransSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_CarnavalBilbao"></see>
    /// </summary>
    let _97_CarnavalBilbao = _prefix "97_CarnavalBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_CatedralSaragossa"></see>
    /// </summary>
    let _97_CatedralSaragossa = _prefix "97_CatedralSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_HotelPalaceM%C3%A0laga"></see>
    /// </summary>
    let ``_97_HotelPalaceM%C3%A0laga`` = _prefix "97_HotelPalaceM%C3%A0laga"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_RestaurantFusi%C3%B3Saragossa"></see>
    /// </summary>
    let ``_97_RestaurantFusi%C3%B3Saragossa`` =
        _prefix "97_RestaurantFusi%C3%B3Saragossa"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#97_TransCadis"></see>
    /// </summary>
    let _97_TransCadis = _prefix "97_TransCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_CityPamplona"></see>
    /// </summary>
    let _98_CityPamplona = _prefix "98_CityPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_Congr%C3%A9sSaragossa"></see>
    /// </summary>
    let ``_98_Congr%C3%A9sSaragossa`` = _prefix "98_Congr%C3%A9sSaragossa"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_HotelPalaceMadrid"></see>
    /// </summary>
    let _98_HotelPalaceMadrid = _prefix "98_HotelPalaceMadrid"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_ParcCadis"></see>
    /// </summary>
    let _98_ParcCadis = _prefix "98_ParcCadis"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#98_RestaurantDeliciaSevilla"></see>
    /// </summary>
    let _98_RestaurantDeliciaSevilla = _prefix "98_RestaurantDeliciaSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_CatedralBilbao"></see>
    /// </summary>
    let _99_CatedralBilbao = _prefix "99_CatedralBilbao"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_FiraSevilla"></see>
    /// </summary>
    let _99_FiraSevilla = _prefix "99_FiraSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_HotelSolSevilla"></see>
    /// </summary>
    let _99_HotelSolSevilla = _prefix "99_HotelSolSevilla"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_MetroSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_99_MetroSantSebasti%C3%A0`` = _prefix "99_MetroSantSebasti%C3%A0"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#99_RestaurantGourmetVal%C3%A8ncia"></see>
    /// </summary>
    let ``_99_RestaurantGourmetVal%C3%A8ncia`` =
        _prefix "99_RestaurantGourmetVal%C3%A8ncia"

    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_CatedralPamplona"></see>
    /// </summary>
    let _9_CatedralPamplona = _prefix "9_CatedralPamplona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_Congr%C3%A9sSantSebasti%C3%A0"></see>
    /// </summary>
    let ``_9_Congr%C3%A9sSantSebasti%C3%A0`` = _prefix "9_Congr%C3%A9sSantSebasti%C3%A0"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_HotelRoyalBarcelona"></see>
    /// </summary>
    let _9_HotelRoyalBarcelona = _prefix "9_HotelRoyalBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_MetroBarcelona"></see>
    /// </summary>
    let _9_MetroBarcelona = _prefix "9_MetroBarcelona"
    /// <summary>
    ///   <see href="https://purl.org/cityexplorer#9_RestaurantDeliciaM%C3%A0laga"></see>
    /// </summary>
    let ``_9_RestaurantDeliciaM%C3%A0laga`` = _prefix "9_RestaurantDeliciaM%C3%A0laga"
    /// <summary>
    /// Includes different restaurant categories
    /// <see href="https://purl.org/cityexplorer#RestaurantCategory"></see></summary>
    let RestaurantCategory = _prefix "RestaurantCategory"
    /// <summary>
    /// Includes different attraction categories
    /// <see href="https://purl.org/cityexplorer#AttractionCategory"></see></summary>
    let AttractionCategory = _prefix "AttractionCategory"
    /// <summary>
    /// Global category, including different categories
    /// <see href="https://purl.org/cityexplorer#Category"></see></summary>
    let Category = _prefix "Category"
    /// <summary>
    /// Refers to different types of categories
    /// <see href="https://purl.org/cityexplorer#CategoryTypes"></see></summary>
    let CategoryTypes = _prefix "CategoryTypes"
    /// <summary>
    /// The latitude of a location
    /// <see href="https://purl.org/cityexplorer#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// The longitude of a location
    /// <see href="https://purl.org/cityexplorer#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// Base class to make searches based on rules
    /// <see href="https://purl.org/cityexplorer#Recommendation"></see></summary>
    let Recommendation = _prefix "Recommendation"
    /// <summary>
    /// Includes different hotel categories
    /// <see href="https://purl.org/cityexplorer#HotelCategory"></see></summary>
    let HotelCategory = _prefix "HotelCategory"
    /// <summary>
    /// Includes different attraction categories
    /// <see href="https://purl.org/cityexplorer#TransportCategory"></see></summary>
    let TransportCategory = _prefix "TransportCategory"
    /// <summary>
    /// Includes different event categories
    /// <see href="https://purl.org/cityexplorer#EventCategory"></see></summary>
    let EventCategory = _prefix "EventCategory"
    /// <summary>
    /// Indicates if a category is a category of a class
    /// <see href="https://purl.org/cityexplorer#isCategoryOf"></see></summary>
    let isCategoryOf = _prefix "isCategoryOf"
