namespace http.purl.org.acco.ns.hash

open DoxAletheia

module accom =
    let _namespace_name = "http://purl.org/acco/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
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
    ///     http://www.productontology.org/id/Igloo
    /// <see href="http://purl.org/acco/ns#Accommodation"></see></summary>
    let Accommodation = _prefix "Accommodation"
    /// <summary>
    /// An accommodation feature is a structured value representing the feature of an accommodation as a property-value pair of varying degrees of formality.
    /// <see href="http://purl.org/acco/ns#AccommodationFeature"></see></summary>
    let AccommodationFeature = _prefix "AccommodationFeature"
    /// <summary>
    /// All-inclusive in the sense of this vocabulary is a comprehesive set of foods and beverages, and sometimes complementing services, provided throughout the entire day.
    /// <see href="http://purl.org/acco/ns#Allinclusive"></see></summary>
    let Allinclusive = _prefix "Allinclusive"
    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Apartment)
    /// <see href="http://purl.org/acco/ns#Apartment"></see></summary>
    let Apartment = _prefix "Apartment"
    /// <summary>
    /// A node holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use acco:bed directly with acco:BedType instances.
    /// <see href="http://purl.org/acco/ns#BedDetails"></see></summary>
    let BedDetails = _prefix "BedDetails"
    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation. Use DBpedia URIs whenever possible.
    /// <see href="http://purl.org/acco/ns#BedType"></see></summary>
    let BedType = _prefix "BedType"
    /// <summary>
    /// A breakfast is the first meal taken after rising from a night's sleep, most often eaten in the early morning before undertaking the day's work. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Breakfast)
    /// <see href="http://purl.org/acco/ns#Breakfast"></see></summary>
    let Breakfast = _prefix "Breakfast"
    /// <summary>
    /// A meal in the sense of this vocabulary is some combination of food or beverages.
    /// <see href="http://purl.org/acco/ns#Meal"></see></summary>
    let Meal = _prefix "Meal"
    /// <summary>
    /// A California King or King Long bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#CaliforniaKing"></see></summary>
    let CaliforniaKing = _prefix "CaliforniaKing"
    /// <summary>
    /// A camping pitch is an individual place for overnight stay in the outdoors, typically being part of a larger acco:CampSite.
    /// <see href="http://purl.org/acco/ns#CampingPitch"></see></summary>
    let CampingPitch = _prefix "CampingPitch"
    /// <summary>
    /// A camping site, campsite, or campground is a place used for overnight stay in the outdoors. In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or parks a camper; a campground may contain many campsites. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Campsite)
    /// <see href="http://purl.org/acco/ns#CampingSite"></see></summary>
    let CampingSite = _prefix "CampingSite"
    /// <summary>
    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use gr:name for indicating the dimension (e.g. "electricity" or "final cleaning").
    /// <see href="http://purl.org/acco/ns#CompoundPrice"></see></summary>
    let CompoundPrice = _prefix "CompoundPrice"
    /// <summary>
    /// A dinner is the main meal of the day, often consumed in the evening of the day.
    /// <see href="http://purl.org/acco/ns#Dinner"></see></summary>
    let Dinner = _prefix "Dinner"
    /// <summary>
    /// A double bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#Double"></see></summary>
    let Double = _prefix "Double"
    /// <summary>
    /// A type of dwelling, e.g. tent, mobile home, etc. for indicating the permitted usage on a campsite. Use DBpedia URIs whenever possible.
    /// <see href="http://purl.org/acco/ns#DwellingType"></see></summary>
    let DwellingType = _prefix "DwellingType"
    /// <summary>
    /// A hotel is an establishment that provides lodging paid on a short-term basis. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel)
    /// <see href="http://purl.org/acco/ns#Hotel"></see></summary>
    let Hotel = _prefix "Hotel"
    /// <summary>
    /// A hotel room is a single room in a hotel.
    /// <see href="http://purl.org/acco/ns#HotelRoom"></see></summary>
    let HotelRoom = _prefix "HotelRoom"
    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/House)
    /// <see href="http://purl.org/acco/ns#House"></see></summary>
    let House = _prefix "House"
    /// <summary>
    /// An King or Super King bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#King"></see></summary>
    let King = _prefix "King"
    /// <summary>
    /// A luncheon, commonly abbreviated to lunch, is a middle of the day meal. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Lunch)
    /// <see href="http://purl.org/acco/ns#Lunch"></see></summary>
    let Lunch = _prefix "Lunch"
    /// <summary>
    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Conference_hall)
    /// <see href="http://purl.org/acco/ns#MeetingRoom"></see></summary>
    let MeetingRoom = _prefix "MeetingRoom"
    /// <summary>
    /// An Olympic Queen bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#OlympicQueen"></see></summary>
    let OlympicQueen = _prefix "OlympicQueen"
    /// <summary>
    /// A Queen King (UK/Ire.) or Wide Double (Japan) bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#Queen"></see></summary>
    let Queen = _prefix "Queen"
    /// <summary>
    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Resort)
    /// <see href="http://purl.org/acco/ns#Resort"></see></summary>
    let Resort = _prefix "Resort"
    /// <summary>
    /// A single bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#Single"></see></summary>
    let Single = _prefix "Single"
    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Suite_(hotel))
    /// <see href="http://purl.org/acco/ns#Suite"></see></summary>
    let Suite = _prefix "Suite"
    /// <summary>
    /// Indicates the times of availability of a particular accommodation feature. Example: The sauna is available from 8:00 - 10:00 a.m. on weekdays.
    /// <see href="http://purl.org/acco/ns#availabilityTimes"></see></summary>
    let availabilityTimes = _prefix "availabilityTimes"
    /// <summary>
    /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use acco:bed directly with acco:BedType instances. If you want to indicate the quantity of a certain acco:BedType, use an instance of acco:BedDetails. For more detailed information, use acco:feature.
    /// <see href="http://purl.org/acco/ns#bed"></see></summary>
    let bed = _prefix "bed"
    /// <summary>
    /// A feature (e.g. a characteristic or service) of the acco:Accommodation. This generic property does not make a statement about whether the feature is included in the offer for the main accommodation or available at extra costs.
    /// <see href="http://purl.org/acco/ns#feature"></see></summary>
    let feature = _prefix "feature"
    /// <summary>
    /// Indicates whether the accommodation is gated, i.e. access is controlled via a fence and some form of gate.
    /// <see href="http://purl.org/acco/ns#gated"></see></summary>
    let gated = _prefix "gated"
    /// <summary>
    /// A feature (e.g. a characteristic or service) of the acco:Accommodation that is included in the offer for the main accommodation, i.e. at no extra costs.
    /// <see href="http://purl.org/acco/ns#includedFeature"></see></summary>
    let includedFeature = _prefix "includedFeature"
    /// <summary>
    /// The upper bound of the value for the feature. It is best to use this property with numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float.
    /// <see href="http://purl.org/acco/ns#max"></see></summary>
    let max = _prefix "max"
    /// <summary>
    /// The lower bound of the value for the feature. It is best to use this property with numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float.
    /// <see href="http://purl.org/acco/ns#min"></see></summary>
    let min = _prefix "min"
    /// <summary>
    /// The number of rooms (excluding bathrooms and closets of the acco:Suite, acco:House, or acco:Apartment.
    /// Typical unit code(s): C62 for person
    /// <see href="http://purl.org/acco/ns#numberOfRooms"></see></summary>
    let numberOfRooms = _prefix "numberOfRooms"
    /// <summary>
    /// The allowed total occupancy for the accommodation in persons (including infants etc.
    /// Typical unit code(s): C62 for person
    /// <see href="http://purl.org/acco/ns#occupancy"></see></summary>
    let occupancy = _prefix "occupancy"
    /// <summary>
    /// The allowed total occupancy of adults (in the sense of fully paying guests) for the accommodation in persons. The exact definition of what constitutes an adult varies across regions and will typically not match the legal definition of being an adult.
    /// Typical unit code(s): C62 for person
    /// <see href="http://purl.org/acco/ns#occupancyAdults"></see></summary>
    let occupancyAdults = _prefix "occupancyAdults"
    /// <summary>
    /// The allowed total occupancy of minors (in the sense of not fully paying guests) for the accommodation in persons. The exact definition of what constitutes a minor varies across regions and will typically not match the legal definition of being a minor.
    /// Typical unit code(s): C62 for person
    /// <see href="http://purl.org/acco/ns#occupancyMinors"></see></summary>
    let occupancyMinors = _prefix "occupancyMinors"
    /// <summary>
    /// A feature (e.g. a characteristic or service) of the acco:Accommodation that is generally available but not included in the offer for the main accommodation, i.e. at  extra costs.
    /// <see href="http://purl.org/acco/ns#optionalFeature"></see></summary>
    let optionalFeature = _prefix "optionalFeature"
    /// <summary>
    /// A naive parthood relation between two acco:Accommodation instances. Examples: A certain hotel room is part of a certain hotel, a certain house is part of a holiday resort, etc.
    /// <see href="http://purl.org/acco/ns#partOf"></see></summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// The type of objects that you are allowed to put on the camping pitch, e.g. a tent, car, boat, or mobile homre. Use DBpedia URIs whenever possible.
    /// <see href="http://purl.org/acco/ns#permittedUsage"></see></summary>
    let permittedUsage = _prefix "permittedUsage"
    /// <summary>
    /// Indicates whether pets are allowed to enter the accommodation.
    /// <see href="http://purl.org/acco/ns#petsAllowed"></see></summary>
    let petsAllowed = _prefix "petsAllowed"
    /// <summary>
    /// This property links to all gr:UnitPriceSpecification nodes that apply in parallel for the acco:CompoundPrice node.
    /// <see href="http://purl.org/acco/ns#priceComponent"></see></summary>
    let priceComponent = _prefix "priceComponent"
    /// <summary>
    /// A global identifier, e.g. a URI, a prefixed string, or any other identifier that can be used to refer to a standardized property type.
    ///
    /// The following prefixes and values are reserved:
    /// starRating:HOTREC
    /// starRating:DEHOGA
    /// starRating:WHR
    /// starRating:Hotelstars
    ///
    /// <see href="http://purl.org/acco/ns#propertyID"></see></summary>
    let propertyID = _prefix "propertyID"
    /// <summary>
    /// The quantity of the given bed type available in the acco:HotelRoom, acco:Suite, acco:House, or acco:Apartment.
    /// <see href="http://purl.org/acco/ns#quantity"></see></summary>
    let quantity = _prefix "quantity"
    /// <summary>
    /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for gr:hasUnitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
    /// <see href="http://purl.org/acco/ns#referenceQuantity"></see></summary>
    let referenceQuantity = _prefix "referenceQuantity"
    /// <summary>
    /// The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
    /// <see href="http://purl.org/acco/ns#size"></see></summary>
    let size = _prefix "size"
    /// <summary>
    /// The type of bed to which the acco:BedDetail node refers, i.e. the type of bed available in the quantity indicated by acco:quantity.
    /// <see href="http://purl.org/acco/ns#typeOfBed"></see></summary>
    let typeOfBed = _prefix "typeOfBed"
    /// <summary>
    /// A textual representation of the unit of measurement, e.g. global identifier, e.g. "m" or "meter". When you have the UN/CEFACT Common Code for the unit available, it is better to use acco:unitCode. This property is for the cases where a standardized unit code is not available from the data source.
    /// <see href="http://purl.org/acco/ns#unit"></see></summary>
    let unit = _prefix "unit"
    /// <summary>
    /// The UN/CEFACT Common Code for the unit of measurement, e.g. "MTR" for meter, "HUR" for hours, etc. If you only have a textual representation of the unit of measurement, use acco:unit instead.
    /// <see href="http://purl.org/acco/ns#unitCode"></see></summary>
    let unitCode = _prefix "unitCode"
    /// <summary>
    /// Indicates the beginning of a time interval during which a certain feature is valid or available. For example, a sauna or swimming pool may only be available during certain periods.
    /// <see href="http://purl.org/acco/ns#validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    /// Indicates the beginning of a time interval during which a certain feature is valid or available. For example, a sauna or swimming pool may only be available during certain periods.
    /// <see href="http://purl.org/acco/ns#validThrough"></see></summary>
    let validThrough = _prefix "validThrough"
    /// <summary>
    /// The point value for the feature unless it is an interval. If possible, use numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float. Textual content is also acceptable, though.
    /// <see href="http://purl.org/acco/ns#value"></see></summary>
    let value = _prefix "value"
