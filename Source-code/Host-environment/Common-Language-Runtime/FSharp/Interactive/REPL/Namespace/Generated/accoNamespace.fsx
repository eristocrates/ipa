#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module acco =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/acco/ns#" "acco"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Accommodation (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
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
    ///     http://www.productontology.org/id/Igloo</para>
    ///   <a href="http://purl.org/acco/ns#Accommodation">acco:Accommodation</a>
    /// </summary>
    let Accommodation = _prefixId.prefix "Accommodation"
    /// <summary>
    ///   <para>rdfs:label : Accommodation Feature</para>
    ///   <para>rdfs:comment : An accommodation feature is a structured value representing the feature of an accommodation as a property-value pair of varying degrees of formality.</para>
    ///   <a href="http://purl.org/acco/ns#AccommodationFeature">acco:AccommodationFeature</a>
    /// </summary>
    let AccommodationFeature = _prefixId.prefix "AccommodationFeature"
    /// <summary>
    ///   <para>rdfs:label : All-inclusive (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : All-inclusive in the sense of this vocabulary is a comprehesive set of foods and beverages, and sometimes complementing services, provided throughout the entire day.</para>
    ///   <a href="http://purl.org/acco/ns#Allinclusive">acco:Allinclusive</a>
    /// </summary>
    let Allinclusive = _prefixId.prefix "Allinclusive"
    /// <summary>
    ///   <para>rdfs:label : Apartment (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Apartment)</para>
    ///   <a href="http://purl.org/acco/ns#Apartment">acco:Apartment</a>
    /// </summary>
    let Apartment = _prefixId.prefix "Apartment"
    /// <summary>
    ///   <para>rdfs:label : Bed Details</para>
    ///   <para>rdfs:comment : A node holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use acco:bed directly with acco:BedType instances.</para>
    ///   <a href="http://purl.org/acco/ns#BedDetails">acco:BedDetails</a>
    /// </summary>
    let BedDetails = _prefixId.prefix "BedDetails"
    /// <summary>
    ///   <para>rdfs:label : Bed Type</para>
    ///   <para>rdfs:comment : A type of bed. This is used for indicating the bed or beds available in an accommodation. Use DBpedia URIs whenever possible.</para>
    ///   <a href="http://purl.org/acco/ns#BedType">acco:BedType</a>
    /// </summary>
    let BedType = _prefixId.prefix "BedType"
    /// <summary>
    ///   <para>rdfs:label : Breakfast (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A breakfast is the first meal taken after rising from a night's sleep, most often eaten in the early morning before undertaking the day's work. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Breakfast)</para>
    ///   <a href="http://purl.org/acco/ns#Breakfast">acco:Breakfast</a>
    /// </summary>
    let Breakfast = _prefixId.prefix "Breakfast"
    let CaliforniaKing = _prefixId.prefix "CaliforniaKing"
    /// <summary>
    ///   <para>rdfs:label : Camping Pitch (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : A camping pitch is an individual place for overnight stay in the outdoors, typically being part of a larger acco:CampSite.</para>
    ///   <a href="http://purl.org/acco/ns#CampingPitch">acco:CampingPitch</a>
    /// </summary>
    let CampingPitch = _prefixId.prefix "CampingPitch"
    /// <summary>
    ///   <para>rdfs:label : Camping Site (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : A camping site, campsite, or campground is a place used for overnight stay in the outdoors. In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or parks a camper; a campground may contain many campsites. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Campsite)</para>
    ///   <a href="http://purl.org/acco/ns#CampingSite">acco:CampingSite</a>
    /// </summary>
    let CampingSite = _prefixId.prefix "CampingSite"
    /// <summary>
    ///   <para>rdfs:label : Compound Price</para>
    ///   <para>rdfs:comment : A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use gr:name for indicating the dimension (e.g. "electricity" or "final cleaning").</para>
    ///   <a href="http://purl.org/acco/ns#CompoundPrice">acco:CompoundPrice</a>
    /// </summary>
    let CompoundPrice = _prefixId.prefix "CompoundPrice"
    /// <summary>
    ///   <para>rdfs:label : Dinner (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A dinner is the main meal of the day, often consumed in the evening of the day.</para>
    ///   <a href="http://purl.org/acco/ns#Dinner">acco:Dinner</a>
    /// </summary>
    let Dinner = _prefixId.prefix "Dinner"
    let Double = _prefixId.prefix "Double"
    /// <summary>
    ///   <para>rdfs:label : Dwelling Type</para>
    ///   <para>rdfs:comment : A type of dwelling, e.g. tent, mobile home, etc. for indicating the permitted usage on a campsite. Use DBpedia URIs whenever possible.</para>
    ///   <a href="http://purl.org/acco/ns#DwellingType">acco:DwellingType</a>
    /// </summary>
    let DwellingType = _prefixId.prefix "DwellingType"
    /// <summary>
    ///   <para>rdfs:label : Hotel (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : A hotel is an establishment that provides lodging paid on a short-term basis. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel)</para>
    ///   <a href="http://purl.org/acco/ns#Hotel">acco:Hotel</a>
    /// </summary>
    let Hotel = _prefixId.prefix "Hotel"
    /// <summary>
    ///   <para>rdfs:label : Hotel Room (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : A hotel room is a single room in a hotel.</para>
    ///   <a href="http://purl.org/acco/ns#HotelRoom">acco:HotelRoom</a>
    /// </summary>
    let HotelRoom = _prefixId.prefix "HotelRoom"
    /// <summary>
    ///   <para>rdfs:label : House (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/House)</para>
    ///   <a href="http://purl.org/acco/ns#House">acco:House</a>
    /// </summary>
    let House = _prefixId.prefix "House"
    let King = _prefixId.prefix "King"
    /// <summary>
    ///   <para>rdfs:label : Lunch (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A luncheon, commonly abbreviated to lunch, is a middle of the day meal. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Lunch)</para>
    ///   <a href="http://purl.org/acco/ns#Lunch">acco:Lunch</a>
    /// </summary>
    let Lunch = _prefixId.prefix "Lunch"
    /// <summary>
    ///   <para>rdfs:label : Meal (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A meal in the sense of this vocabulary is some combination of food or beverages.</para>
    ///   <a href="http://purl.org/acco/ns#Meal">acco:Meal</a>
    /// </summary>
    let Meal = _prefixId.prefix "Meal"
    /// <summary>
    ///   <para>rdfs:label : Meeting Room (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Conference_hall)  </para>
    ///   <a href="http://purl.org/acco/ns#MeetingRoom">acco:MeetingRoom</a>
    /// </summary>
    let MeetingRoom = _prefixId.prefix "MeetingRoom"
    let OlympicQueen = _prefixId.prefix "OlympicQueen"
    let Queen = _prefixId.prefix "Queen"
    /// <summary>
    ///   <para>rdfs:label : Resort (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Resort)</para>
    ///   <a href="http://purl.org/acco/ns#Resort">acco:Resort</a>
    /// </summary>
    let Resort = _prefixId.prefix "Resort"
    let Single = _prefixId.prefix "Single"
    /// <summary>
    ///   <para>rdfs:label : Suite (gr:ProductOrService, gr:Location)</para>
    ///   <para>rdfs:comment : A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Suite_(hotel)) </para>
    ///   <a href="http://purl.org/acco/ns#Suite">acco:Suite</a>
    /// </summary>
    let Suite = _prefixId.prefix "Suite"
    /// <summary>
    ///   <para>rdfs:label : availability times (0..1)</para>
    ///   <para>rdfs:comment : Indicates the times of availability of a particular accommodation feature. Example: The sauna is available from 8:00 - 10:00 a.m. on weekdays.</para>
    ///   <a href="http://purl.org/acco/ns#availabilityTimes">acco:availabilityTimes</a>
    /// </summary>
    let availabilityTimes = _prefixId.prefix "availabilityTimes"
    /// <summary>
    ///   <para>rdfs:label : bed (0..*)</para>
    ///   <para>rdfs:comment : The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use acco:bed directly with acco:BedType instances. If you want to indicate the quantity of a certain acco:BedType, use an instance of acco:BedDetails. For more detailed information, use acco:feature.</para>
    ///   <a href="http://purl.org/acco/ns#bed">acco:bed</a>
    /// </summary>
    let bed = _prefixId.prefix "bed"
    /// <summary>
    ///   <para>rdfs:label : feature (0..*)</para>
    ///   <para>rdfs:comment : A feature (e.g. a characteristic or service) of the acco:Accommodation. This generic property does not make a statement about whether the feature is included in the offer for the main accommodation or available at extra costs. </para>
    ///   <a href="http://purl.org/acco/ns#feature">acco:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:label : gated (0..1)</para>
    ///   <para>rdfs:comment : Indicates whether the accommodation is gated, i.e. access is controlled via a fence and some form of gate.</para>
    ///   <a href="http://purl.org/acco/ns#gated">acco:gated</a>
    /// </summary>
    let gated = _prefixId.prefix "gated"
    /// <summary>
    ///   <para>rdfs:label : included feature (0..*)</para>
    ///   <para>rdfs:comment : A feature (e.g. a characteristic or service) of the acco:Accommodation that is included in the offer for the main accommodation, i.e. at no extra costs. </para>
    ///   <a href="http://purl.org/acco/ns#includedFeature">acco:includedFeature</a>
    /// </summary>
    let includedFeature = _prefixId.prefix "includedFeature"
    /// <summary>
    ///   <para>rdfs:label : max (0..1)</para>
    ///   <para>rdfs:comment : The upper bound of the value for the feature. It is best to use this property with numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float.</para>
    ///   <a href="http://purl.org/acco/ns#max">acco:max</a>
    /// </summary>
    let max = _prefixId.prefix "max"
    /// <summary>
    ///   <para>rdfs:label : min (0..1)</para>
    ///   <para>rdfs:comment : The lower bound of the value for the feature. It is best to use this property with numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float.</para>
    ///   <a href="http://purl.org/acco/ns#min">acco:min</a>
    /// </summary>
    let min = _prefixId.prefix "min"
    /// <summary>
    ///   <para>rdfs:label : number of rooms (0..1)</para>
    ///   <para>rdfs:comment : The number of rooms (excluding bathrooms and closets of the acco:Suite, acco:House, or acco:Apartment.
    /// Typical unit code(s): C62 for person</para>
    ///   <a href="http://purl.org/acco/ns#numberOfRooms">acco:numberOfRooms</a>
    /// </summary>
    let numberOfRooms = _prefixId.prefix "numberOfRooms"
    /// <summary>
    ///   <para>rdfs:label : occupancy (0..1)</para>
    ///   <para>rdfs:comment : The allowed total occupancy for the accommodation in persons (including infants etc.
    /// Typical unit code(s): C62 for person</para>
    ///   <a href="http://purl.org/acco/ns#occupancy">acco:occupancy</a>
    /// </summary>
    let occupancy = _prefixId.prefix "occupancy"
    /// <summary>
    ///   <para>rdfs:label : occupancy adults (0..1)</para>
    ///   <para>rdfs:comment : The allowed total occupancy of adults (in the sense of fully paying guests) for the accommodation in persons. The exact definition of what constitutes an adult varies across regions and will typically not match the legal definition of being an adult.
    /// Typical unit code(s): C62 for person</para>
    ///   <a href="http://purl.org/acco/ns#occupancyAdults">acco:occupancyAdults</a>
    /// </summary>
    let occupancyAdults = _prefixId.prefix "occupancyAdults"
    /// <summary>
    ///   <para>rdfs:label : occupancy minors (0..1)</para>
    ///   <para>rdfs:comment : The allowed total occupancy of minors (in the sense of not fully paying guests) for the accommodation in persons. The exact definition of what constitutes a minor varies across regions and will typically not match the legal definition of being a minor.
    /// Typical unit code(s): C62 for person</para>
    ///   <a href="http://purl.org/acco/ns#occupancyMinors">acco:occupancyMinors</a>
    /// </summary>
    let occupancyMinors = _prefixId.prefix "occupancyMinors"
    /// <summary>
    ///   <para>rdfs:label : optional feature (0..*)</para>
    ///   <para>rdfs:comment : A feature (e.g. a characteristic or service) of the acco:Accommodation that is generally available but not included in the offer for the main accommodation, i.e. at  extra costs. </para>
    ///   <a href="http://purl.org/acco/ns#optionalFeature">acco:optionalFeature</a>
    /// </summary>
    let optionalFeature = _prefixId.prefix "optionalFeature"
    /// <summary>
    ///   <para>rdfs:label : partOf (0..*)</para>
    ///   <para>rdfs:comment : A naive parthood relation between two acco:Accommodation instances. Examples: A certain hotel room is part of a certain hotel, a certain house is part of a holiday resort, etc. </para>
    ///   <a href="http://purl.org/acco/ns#partOf">acco:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>rdfs:label : permitted usage (0..*)</para>
    ///   <para>rdfs:comment : The type of objects that you are allowed to put on the camping pitch, e.g. a tent, car, boat, or mobile homre. Use DBpedia URIs whenever possible.</para>
    ///   <a href="http://purl.org/acco/ns#permittedUsage">acco:permittedUsage</a>
    /// </summary>
    let permittedUsage = _prefixId.prefix "permittedUsage"
    /// <summary>
    ///   <para>rdfs:label : pets allowed (0..1)</para>
    ///   <para>rdfs:comment : Indicates whether pets are allowed to enter the accommodation.</para>
    ///   <a href="http://purl.org/acco/ns#petsAllowed">acco:petsAllowed</a>
    /// </summary>
    let petsAllowed = _prefixId.prefix "petsAllowed"
    /// <summary>
    ///   <para>rdfs:label : price component (0..*)</para>
    ///   <para>rdfs:comment : This property links to all gr:UnitPriceSpecification nodes that apply in parallel for the acco:CompoundPrice node.</para>
    ///   <a href="http://purl.org/acco/ns#priceComponent">acco:priceComponent</a>
    /// </summary>
    let priceComponent = _prefixId.prefix "priceComponent"
    /// <summary>
    ///   <para>rdfs:label : property ID (0..1)</para>
    ///   <para>rdfs:comment : A global identifier, e.g. a URI, a prefixed string, or any other identifier that can be used to refer to a standardized property type.
    ///
    /// The following prefixes and values are reserved:
    /// starRating:HOTREC
    /// starRating:DEHOGA
    /// starRating:WHR
    /// starRating:Hotelstars
    /// </para>
    ///   <a href="http://purl.org/acco/ns#propertyID">acco:propertyID</a>
    /// </summary>
    let propertyID = _prefixId.prefix "propertyID"
    /// <summary>
    ///   <para>rdfs:label : quantity (1..1)</para>
    ///   <para>rdfs:comment : The quantity of the given bed type available in the acco:HotelRoom, acco:Suite, acco:House, or acco:Apartment.</para>
    ///   <a href="http://purl.org/acco/ns#quantity">acco:quantity</a>
    /// </summary>
    let quantity = _prefixId.prefix "quantity"
    /// <summary>
    ///   <para>rdfs:label : reference quantity (0..*)</para>
    ///   <para>rdfs:comment : The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for gr:hasUnitOfMeasurement for the advanced cases where the price does not relate to a standard unit.</para>
    ///   <a href="http://purl.org/acco/ns#referenceQuantity">acco:referenceQuantity</a>
    /// </summary>
    let referenceQuantity = _prefixId.prefix "referenceQuantity"
    /// <summary>
    ///   <para>rdfs:label : size (0..1)</para>
    ///   <para>rdfs:comment : The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard </para>
    ///   <a href="http://purl.org/acco/ns#size">acco:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
    /// <summary>
    ///   <para>rdfs:label : type of bed (1..1)</para>
    ///   <para>rdfs:comment : The type of bed to which the acco:BedDetail node refers, i.e. the type of bed available in the quantity indicated by acco:quantity.</para>
    ///   <a href="http://purl.org/acco/ns#typeOfBed">acco:typeOfBed</a>
    /// </summary>
    let typeOfBed = _prefixId.prefix "typeOfBed"
    /// <summary>
    ///   <para>rdfs:label : unit (0..1)</para>
    ///   <para>rdfs:comment : A textual representation of the unit of measurement, e.g. global identifier, e.g. "m" or "meter". When you have the UN/CEFACT Common Code for the unit available, it is better to use acco:unitCode. This property is for the cases where a standardized unit code is not available from the data source.</para>
    ///   <a href="http://purl.org/acco/ns#unit">acco:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    /// <summary>
    ///   <para>rdfs:label : unit code (0..1)</para>
    ///   <para>rdfs:comment : The UN/CEFACT Common Code for the unit of measurement, e.g. "MTR" for meter, "HUR" for hours, etc. If you only have a textual representation of the unit of measurement, use acco:unit instead.</para>
    ///   <a href="http://purl.org/acco/ns#unitCode">acco:unitCode</a>
    /// </summary>
    let unitCode = _prefixId.prefix "unitCode"
    /// <summary>
    ///   <para>rdfs:label : valid from (0..1)</para>
    ///   <para>rdfs:comment : Indicates the beginning of a time interval during which a certain feature is valid or available. For example, a sauna or swimming pool may only be available during certain periods.</para>
    ///   <a href="http://purl.org/acco/ns#validFrom">acco:validFrom</a>
    /// </summary>
    let validFrom = _prefixId.prefix "validFrom"
    /// <summary>
    ///   <para>rdfs:label : valid from (0..1)</para>
    ///   <para>rdfs:comment : Indicates the beginning of a time interval during which a certain feature is valid or available. For example, a sauna or swimming pool may only be available during certain periods.</para>
    ///   <a href="http://purl.org/acco/ns#validThrough">acco:validThrough</a>
    /// </summary>
    let validThrough = _prefixId.prefix "validThrough"
    /// <summary>
    ///   <para>rdfs:label : value (0..1)</para>
    ///   <para>rdfs:comment : The point value for the feature unless it is an interval. If possible, use numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float. Textual content is also acceptable, though.</para>
    ///   <a href="http://purl.org/acco/ns#value">acco:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
