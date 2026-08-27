namespace http.purl.org.acco.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module accom =
    let _namespace_iri = Namespace_Iri accom |> NamespaceIRI
    /// <summary>
    ///   <para>accom:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"ACCO: The Accommodation Ontology
    ///
    /// A Web vocabulary for hotels, vacation homes, camping sites, and other accommodation offers for e-commerce.
    ///
    /// Vocabulary:    http://purl.org/acco/ns#
    /// Namespace:     http://purl.org/acco/ns#
    ///
    /// The Accommodation Ontology is designed to be used in combination with GoodRelations, a standard vocabulary for the commercial aspects of offers for sale or rental.
    ///
    /// See http://purl.org/goodrelations/ for more information."</para>
    /// labels<para>"Accommodation Ontology"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#">http://purl.org/acco/ns#</seealso>
    let _prefix_iri = Prefixed_Name(accom, "") |> PrefixedName
    /// <summary>
    ///   <para>accom:Accommodation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    ///
    /// Note: For more specific types of accommodations not defined in this ontology, you can easily use any Wikipedia entry from
    ///
    ///     http://en.wikipedia.org/wiki/List_of_human_habitation_forms
    ///
    /// and replace the base URI
    ///
    ///     http://en.wikipedia.org/wiki/
    ///
    /// by
    ///
    ///     http://www.productontology.org/id/
    ///
    /// For instance, if you want want to describe an igloo (http://en.wikipedia.org/wiki/Igloo) for rent, you can use the local part 'Igloo' as a class identifier as follows:
    ///
    ///     http://www.productontology.org/id/Igloo"</para>
    /// labels<para>"Accommodation (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Accommodation">http://purl.org/acco/ns#Accommodation</seealso>
    let Accommodation = Prefixed_Name(accom, "Accommodation") |> PrefixedName

    /// <summary>
    ///   <para>accom:AccommodationFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accommodation feature is a structured value representing the feature of an accommodation as a property-value pair of varying degrees of formality."</para>
    /// labels<para>"Accommodation Feature"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#AccommodationFeature">http://purl.org/acco/ns#AccommodationFeature</seealso>
    let AccommodationFeature =
        Prefixed_Name(accom, "AccommodationFeature") |> PrefixedName

    /// <summary>
    ///   <para>accom:Allinclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All-inclusive in the sense of this vocabulary is a comprehesive set of foods and beverages, and sometimes complementing services, provided throughout the entire day."</para>
    /// labels<para>"All-inclusive (gr:ProductOrService)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Allinclusive">http://purl.org/acco/ns#Allinclusive</seealso>
    let Allinclusive = Prefixed_Name(accom, "Allinclusive") |> PrefixedName
    /// <summary>
    ///   <para>accom:Apartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Apartment)"</para>
    /// labels<para>"Apartment (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Apartment">http://purl.org/acco/ns#Apartment</seealso>
    let Apartment = Prefixed_Name(accom, "Apartment") |> PrefixedName
    /// <summary>
    ///   <para>accom:BedDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A node holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use acco:bed directly with acco:BedType instances."</para>
    /// labels<para>"Bed Details"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#BedDetails">http://purl.org/acco/ns#BedDetails</seealso>
    let BedDetails = Prefixed_Name(accom, "BedDetails") |> PrefixedName
    /// <summary>
    ///   <para>accom:BedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of bed. This is used for indicating the bed or beds available in an accommodation. Use DBpedia URIs whenever possible."</para>
    /// labels<para>"Bed Type"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#BedType">http://purl.org/acco/ns#BedType</seealso>
    let BedType = Prefixed_Name(accom, "BedType") |> PrefixedName
    /// <summary>
    ///   <para>accom:Breakfast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A breakfast is the first meal taken after rising from a night's sleep, most often eaten in the early morning before undertaking the day's work. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Breakfast)"</para>
    /// labels<para>"Breakfast (gr:ProductOrService)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Breakfast">http://purl.org/acco/ns#Breakfast</seealso>
    let Breakfast = Prefixed_Name(accom, "Breakfast") |> PrefixedName
    /// <summary>
    ///   <para>accom:CaliforniaKing</para>
    /// </summary>
    /// <remarks>
    ///   <para>accom:BedType</para>
    ///   <para>"A California King or King Long bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size."</para>
    /// labels<para>"California King or King Long bed (acco:BedType)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#CaliforniaKing">http://purl.org/acco/ns#CaliforniaKing</seealso>
    let CaliforniaKing = Prefixed_Name(accom, "CaliforniaKing") |> PrefixedName
    /// <summary>
    ///   <para>accom:CampingPitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A camping pitch is an individual place for overnight stay in the outdoors, typically being part of a larger acco:CampSite."</para>
    /// labels<para>"Camping Pitch (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#CampingPitch">http://purl.org/acco/ns#CampingPitch</seealso>
    let CampingPitch = Prefixed_Name(accom, "CampingPitch") |> PrefixedName
    /// <summary>
    ///   <para>accom:CampingSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A camping site, campsite, or campground is a place used for overnight stay in the outdoors. In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or parks a camper; a campground may contain many campsites. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Campsite)"</para>
    /// labels<para>"Camping Site (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#CampingSite">http://purl.org/acco/ns#CampingSite</seealso>
    let CampingSite = Prefixed_Name(accom, "CampingSite") |> PrefixedName
    /// <summary>
    ///   <para>accom:CompoundPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use gr:name for indicating the dimension (e.g. "electricity" or "final cleaning")."</para>
    /// labels<para>"Compound Price"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#CompoundPrice">http://purl.org/acco/ns#CompoundPrice</seealso>
    let CompoundPrice = Prefixed_Name(accom, "CompoundPrice") |> PrefixedName
    /// <summary>
    ///   <para>accom:Dinner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dinner is the main meal of the day, often consumed in the evening of the day."</para>
    /// labels<para>"Dinner (gr:ProductOrService)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Dinner">http://purl.org/acco/ns#Dinner</seealso>
    let Dinner = Prefixed_Name(accom, "Dinner") |> PrefixedName
    /// <summary>
    ///   <para>accom:Double</para>
    /// </summary>
    /// <remarks>
    ///   <para>accom:BedType</para>
    ///   <para>"A double bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size."</para>
    /// labels<para>"Double or full bed (acco:BedType)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Double">http://purl.org/acco/ns#Double</seealso>
    let Double = Prefixed_Name(accom, "Double") |> PrefixedName
    /// <summary>
    ///   <para>accom:DwellingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of dwelling, e.g. tent, mobile home, etc. for indicating the permitted usage on a campsite. Use DBpedia URIs whenever possible."</para>
    /// labels<para>"Dwelling Type"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#DwellingType">http://purl.org/acco/ns#DwellingType</seealso>
    let DwellingType = Prefixed_Name(accom, "DwellingType") |> PrefixedName
    /// <summary>
    ///   <para>accom:Hotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hotel is an establishment that provides lodging paid on a short-term basis. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel)"</para>
    /// labels<para>"Hotel (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Hotel">http://purl.org/acco/ns#Hotel</seealso>
    let Hotel = Prefixed_Name(accom, "Hotel") |> PrefixedName
    /// <summary>
    ///   <para>accom:HotelRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hotel room is a single room in a hotel."</para>
    /// labels<para>"Hotel Room (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#HotelRoom">http://purl.org/acco/ns#HotelRoom</seealso>
    let HotelRoom = Prefixed_Name(accom, "HotelRoom") |> PrefixedName
    /// <summary>
    ///   <para>accom:House</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/House)"</para>
    /// labels<para>"House (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#House">http://purl.org/acco/ns#House</seealso>
    let House = Prefixed_Name(accom, "House") |> PrefixedName
    /// <summary>
    ///   <para>accom:King</para>
    /// </summary>
    /// <remarks>
    ///   <para>accom:BedType</para>
    ///   <para>"An King or Super King bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size."</para>
    /// labels<para>"King or Super King bed (acco:BedType)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#King">http://purl.org/acco/ns#King</seealso>
    let King = Prefixed_Name(accom, "King") |> PrefixedName
    /// <summary>
    ///   <para>accom:Lunch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A luncheon, commonly abbreviated to lunch, is a middle of the day meal. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Lunch)"</para>
    /// labels<para>"Lunch (gr:ProductOrService)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Lunch">http://purl.org/acco/ns#Lunch</seealso>
    let Lunch = Prefixed_Name(accom, "Lunch") |> PrefixedName
    /// <summary>
    ///   <para>accom:Meal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A meal in the sense of this vocabulary is some combination of food or beverages."</para>
    /// labels<para>"Meal (gr:ProductOrService)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Meal">http://purl.org/acco/ns#Meal</seealso>
    let Meal = Prefixed_Name(accom, "Meal") |> PrefixedName
    /// <summary>
    ///   <para>accom:MeetingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Conference_hall)  "</para>
    /// labels<para>"Meeting Room (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#MeetingRoom">http://purl.org/acco/ns#MeetingRoom</seealso>
    let MeetingRoom = Prefixed_Name(accom, "MeetingRoom") |> PrefixedName
    /// <summary>
    ///   <para>accom:OlympicQueen</para>
    /// </summary>
    /// <remarks>
    ///   <para>accom:BedType</para>
    ///   <para>"An Olympic Queen bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size."</para>
    /// labels<para>"Olympic Queen bed (acco:BedType)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#OlympicQueen">http://purl.org/acco/ns#OlympicQueen</seealso>
    let OlympicQueen = Prefixed_Name(accom, "OlympicQueen") |> PrefixedName
    /// <summary>
    ///   <para>accom:Queen</para>
    /// </summary>
    /// <remarks>
    ///   <para>accom:BedType</para>
    ///   <para>"A Queen King (UK/Ire.) or Wide Double (Japan) bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size."</para>
    /// labels<para>"Queen King or Wide Double bed (acco:BedType)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Queen">http://purl.org/acco/ns#Queen</seealso>
    let Queen = Prefixed_Name(accom, "Queen") |> PrefixedName
    /// <summary>
    ///   <para>accom:Resort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Resort)"</para>
    /// labels<para>"Resort (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Resort">http://purl.org/acco/ns#Resort</seealso>
    let Resort = Prefixed_Name(accom, "Resort") |> PrefixedName
    /// <summary>
    ///   <para>accom:Single</para>
    /// </summary>
    /// <remarks>
    ///   <para>accom:BedType</para>
    ///   <para>"A single bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size."</para>
    /// labels<para>"Single or twin bed (acco:BedType)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Single">http://purl.org/acco/ns#Single</seealso>
    let Single = Prefixed_Name(accom, "Single") |> PrefixedName
    /// <summary>
    ///   <para>accom:Suite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Suite_(hotel)) "</para>
    /// labels<para>"Suite (gr:ProductOrService, gr:Location)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#Suite">http://purl.org/acco/ns#Suite</seealso>
    let Suite = Prefixed_Name(accom, "Suite") |> PrefixedName
    /// <summary>
    ///   <para>accom:availabilityTimes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the times of availability of a particular accommodation feature. Example: The sauna is available from 8:00 - 10:00 a.m. on weekdays."</para>
    /// labels<para>"availability times (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#availabilityTimes">http://purl.org/acco/ns#availabilityTimes</seealso>
    let availabilityTimes = Prefixed_Name(accom, "availabilityTimes") |> PrefixedName
    /// <summary>
    ///   <para>accom:bed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use acco:bed directly with acco:BedType instances. If you want to indicate the quantity of a certain acco:BedType, use an instance of acco:BedDetails. For more detailed information, use acco:feature."</para>
    /// labels<para>"bed (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#bed">http://purl.org/acco/ns#bed</seealso>
    let bed = Prefixed_Name(accom, "bed") |> PrefixedName
    /// <summary>
    ///   <para>accom:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A feature (e.g. a characteristic or service) of the acco:Accommodation. This generic property does not make a statement about whether the feature is included in the offer for the main accommodation or available at extra costs. "</para>
    /// labels<para>"feature (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#feature">http://purl.org/acco/ns#feature</seealso>
    let feature = Prefixed_Name(accom, "feature") |> PrefixedName
    /// <summary>
    ///   <para>accom:gated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether the accommodation is gated, i.e. access is controlled via a fence and some form of gate."</para>
    /// labels<para>"gated (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#gated">http://purl.org/acco/ns#gated</seealso>
    let gated = Prefixed_Name(accom, "gated") |> PrefixedName
    /// <summary>
    ///   <para>accom:includedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A feature (e.g. a characteristic or service) of the acco:Accommodation that is included in the offer for the main accommodation, i.e. at no extra costs. "</para>
    /// labels<para>"included feature (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#includedFeature">http://purl.org/acco/ns#includedFeature</seealso>
    let includedFeature = Prefixed_Name(accom, "includedFeature") |> PrefixedName
    /// <summary>
    ///   <para>accom:max</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The upper bound of the value for the feature. It is best to use this property with numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float."</para>
    /// labels<para>"max (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#max">http://purl.org/acco/ns#max</seealso>
    let max = Prefixed_Name(accom, "max") |> PrefixedName
    /// <summary>
    ///   <para>accom:min</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The lower bound of the value for the feature. It is best to use this property with numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float."</para>
    /// labels<para>"min (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#min">http://purl.org/acco/ns#min</seealso>
    let min = Prefixed_Name(accom, "min") |> PrefixedName
    /// <summary>
    ///   <para>accom:numberOfRooms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The number of rooms (excluding bathrooms and closets of the acco:Suite, acco:House, or acco:Apartment.
    /// Typical unit code(s): C62 for person"</para>
    /// labels<para>"number of rooms (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#numberOfRooms">http://purl.org/acco/ns#numberOfRooms</seealso>
    let numberOfRooms = Prefixed_Name(accom, "numberOfRooms") |> PrefixedName
    /// <summary>
    ///   <para>accom:occupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The allowed total occupancy for the accommodation in persons (including infants etc.
    /// Typical unit code(s): C62 for person"</para>
    /// labels<para>"occupancy (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#occupancy">http://purl.org/acco/ns#occupancy</seealso>
    let occupancy = Prefixed_Name(accom, "occupancy") |> PrefixedName
    /// <summary>
    ///   <para>accom:occupancyAdults</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The allowed total occupancy of adults (in the sense of fully paying guests) for the accommodation in persons. The exact definition of what constitutes an adult varies across regions and will typically not match the legal definition of being an adult.
    /// Typical unit code(s): C62 for person"</para>
    /// labels<para>"occupancy adults (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#occupancyAdults">http://purl.org/acco/ns#occupancyAdults</seealso>
    let occupancyAdults = Prefixed_Name(accom, "occupancyAdults") |> PrefixedName
    /// <summary>
    ///   <para>accom:occupancyMinors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The allowed total occupancy of minors (in the sense of not fully paying guests) for the accommodation in persons. The exact definition of what constitutes a minor varies across regions and will typically not match the legal definition of being a minor.
    /// Typical unit code(s): C62 for person"</para>
    /// labels<para>"occupancy minors (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#occupancyMinors">http://purl.org/acco/ns#occupancyMinors</seealso>
    let occupancyMinors = Prefixed_Name(accom, "occupancyMinors") |> PrefixedName
    /// <summary>
    ///   <para>accom:optionalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A feature (e.g. a characteristic or service) of the acco:Accommodation that is generally available but not included in the offer for the main accommodation, i.e. at  extra costs. "</para>
    /// labels<para>"optional feature (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#optionalFeature">http://purl.org/acco/ns#optionalFeature</seealso>
    let optionalFeature = Prefixed_Name(accom, "optionalFeature") |> PrefixedName
    /// <summary>
    ///   <para>accom:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A naive parthood relation between two acco:Accommodation instances. Examples: A certain hotel room is part of a certain hotel, a certain house is part of a holiday resort, etc. "</para>
    /// labels<para>"partOf (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#partOf">http://purl.org/acco/ns#partOf</seealso>
    let partOf = Prefixed_Name(accom, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>accom:permittedUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The type of objects that you are allowed to put on the camping pitch, e.g. a tent, car, boat, or mobile homre. Use DBpedia URIs whenever possible."</para>
    /// labels<para>"permitted usage (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#permittedUsage">http://purl.org/acco/ns#permittedUsage</seealso>
    let permittedUsage = Prefixed_Name(accom, "permittedUsage") |> PrefixedName
    /// <summary>
    ///   <para>accom:petsAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether pets are allowed to enter the accommodation."</para>
    /// labels<para>"pets allowed (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#petsAllowed">http://purl.org/acco/ns#petsAllowed</seealso>
    let petsAllowed = Prefixed_Name(accom, "petsAllowed") |> PrefixedName
    /// <summary>
    ///   <para>accom:priceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links to all gr:UnitPriceSpecification nodes that apply in parallel for the acco:CompoundPrice node."</para>
    /// labels<para>"price component (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#priceComponent">http://purl.org/acco/ns#priceComponent</seealso>
    let priceComponent = Prefixed_Name(accom, "priceComponent") |> PrefixedName
    /// <summary>
    ///   <para>accom:propertyID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A global identifier, e.g. a URI, a prefixed string, or any other identifier that can be used to refer to a standardized property type.
    ///
    /// The following prefixes and values are reserved:
    /// starRating:HOTREC
    /// starRating:DEHOGA
    /// starRating:WHR
    /// starRating:Hotelstars
    /// "</para>
    /// labels<para>"property ID (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#propertyID">http://purl.org/acco/ns#propertyID</seealso>
    let propertyID = Prefixed_Name(accom, "propertyID") |> PrefixedName
    /// <summary>
    ///   <para>accom:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The quantity of the given bed type available in the acco:HotelRoom, acco:Suite, acco:House, or acco:Apartment."</para>
    /// labels<para>"quantity (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#quantity">http://purl.org/acco/ns#quantity</seealso>
    let quantity = Prefixed_Name(accom, "quantity") |> PrefixedName
    /// <summary>
    ///   <para>accom:referenceQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for gr:hasUnitOfMeasurement for the advanced cases where the price does not relate to a standard unit."</para>
    /// labels<para>"reference quantity (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#referenceQuantity">http://purl.org/acco/ns#referenceQuantity</seealso>
    let referenceQuantity = Prefixed_Name(accom, "referenceQuantity") |> PrefixedName
    /// <summary>
    ///   <para>accom:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard "</para>
    /// labels<para>"size (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#size">http://purl.org/acco/ns#size</seealso>
    let size = Prefixed_Name(accom, "size") |> PrefixedName
    /// <summary>
    ///   <para>accom:typeOfBed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type of bed to which the acco:BedDetail node refers, i.e. the type of bed available in the quantity indicated by acco:quantity."</para>
    /// labels<para>"type of bed (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#typeOfBed">http://purl.org/acco/ns#typeOfBed</seealso>
    let typeOfBed = Prefixed_Name(accom, "typeOfBed") |> PrefixedName
    /// <summary>
    ///   <para>accom:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A textual representation of the unit of measurement, e.g. global identifier, e.g. "m" or "meter". When you have the UN/CEFACT Common Code for the unit available, it is better to use acco:unitCode. This property is for the cases where a standardized unit code is not available from the data source."</para>
    /// labels<para>"unit (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#unit">http://purl.org/acco/ns#unit</seealso>
    let unit = Prefixed_Name(accom, "unit") |> PrefixedName
    /// <summary>
    ///   <para>accom:unitCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The UN/CEFACT Common Code for the unit of measurement, e.g. "MTR" for meter, "HUR" for hours, etc. If you only have a textual representation of the unit of measurement, use acco:unit instead."</para>
    /// labels<para>"unit code (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#unitCode">http://purl.org/acco/ns#unitCode</seealso>
    let unitCode = Prefixed_Name(accom, "unitCode") |> PrefixedName
    /// <summary>
    ///   <para>accom:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the beginning of a time interval during which a certain feature is valid or available. For example, a sauna or swimming pool may only be available during certain periods."</para>
    /// labels<para>"valid from (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#validFrom">http://purl.org/acco/ns#validFrom</seealso>
    let validFrom = Prefixed_Name(accom, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>accom:validThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the beginning of a time interval during which a certain feature is valid or available. For example, a sauna or swimming pool may only be available during certain periods."</para>
    /// labels<para>"valid from (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#validThrough">http://purl.org/acco/ns#validThrough</seealso>
    let validThrough = Prefixed_Name(accom, "validThrough") |> PrefixedName
    /// <summary>
    ///   <para>accom:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The point value for the feature unless it is an interval. If possible, use numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float. Textual content is also acceptable, though."</para>
    /// labels<para>"value (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/acco/ns#value">http://purl.org/acco/ns#value</seealso>
    let value = Prefixed_Name(accom, "value") |> PrefixedName
