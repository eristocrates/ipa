namespace http.purl.org.acco.ns.hash

open DoxAletheia.Rdf_Vocabulary

module accom =
    let _namespace_name = "http://purl.org/acco/ns#"

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
    let Accommodation =
        Namespaced_IRI.parse _namespace_name "Accommodation" |> NamespacedName

    /// <summary>
    /// An accommodation feature is a structured value representing the feature of an accommodation as a property-value pair of varying degrees of formality.
    /// <see href="http://purl.org/acco/ns#AccommodationFeature"></see></summary>
    let AccommodationFeature =
        Namespaced_IRI.parse _namespace_name "AccommodationFeature" |> NamespacedName

    /// <summary>
    /// All-inclusive in the sense of this vocabulary is a comprehesive set of foods and beverages, and sometimes complementing services, provided throughout the entire day.
    /// <see href="http://purl.org/acco/ns#Allinclusive"></see></summary>
    let Allinclusive =
        Namespaced_IRI.parse _namespace_name "Allinclusive" |> NamespacedName

    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Apartment)
    /// <see href="http://purl.org/acco/ns#Apartment"></see></summary>
    let Apartment = Namespaced_IRI.parse _namespace_name "Apartment" |> NamespacedName
    /// <summary>
    /// A node holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use acco:bed directly with acco:BedType instances.
    /// <see href="http://purl.org/acco/ns#BedDetails"></see></summary>
    let BedDetails = Namespaced_IRI.parse _namespace_name "BedDetails" |> NamespacedName
    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation. Use DBpedia URIs whenever possible.
    /// <see href="http://purl.org/acco/ns#BedType"></see></summary>
    let BedType = Namespaced_IRI.parse _namespace_name "BedType" |> NamespacedName
    /// <summary>
    /// A breakfast is the first meal taken after rising from a night's sleep, most often eaten in the early morning before undertaking the day's work. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Breakfast)
    /// <see href="http://purl.org/acco/ns#Breakfast"></see></summary>
    let Breakfast = Namespaced_IRI.parse _namespace_name "Breakfast" |> NamespacedName
    /// <summary>
    /// A meal in the sense of this vocabulary is some combination of food or beverages.
    /// <see href="http://purl.org/acco/ns#Meal"></see></summary>
    let Meal = Namespaced_IRI.parse _namespace_name "Meal" |> NamespacedName

    /// <summary>
    /// A California King or King Long bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#CaliforniaKing"></see></summary>
    let CaliforniaKing =
        Namespaced_IRI.parse _namespace_name "CaliforniaKing" |> NamespacedName

    /// <summary>
    /// A camping pitch is an individual place for overnight stay in the outdoors, typically being part of a larger acco:CampSite.
    /// <see href="http://purl.org/acco/ns#CampingPitch"></see></summary>
    let CampingPitch =
        Namespaced_IRI.parse _namespace_name "CampingPitch" |> NamespacedName

    /// <summary>
    /// A camping site, campsite, or campground is a place used for overnight stay in the outdoors. In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or parks a camper; a campground may contain many campsites. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Campsite)
    /// <see href="http://purl.org/acco/ns#CampingSite"></see></summary>
    let CampingSite =
        Namespaced_IRI.parse _namespace_name "CampingSite" |> NamespacedName

    /// <summary>
    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use gr:name for indicating the dimension (e.g. "electricity" or "final cleaning").
    /// <see href="http://purl.org/acco/ns#CompoundPrice"></see></summary>
    let CompoundPrice =
        Namespaced_IRI.parse _namespace_name "CompoundPrice" |> NamespacedName

    /// <summary>
    /// A dinner is the main meal of the day, often consumed in the evening of the day.
    /// <see href="http://purl.org/acco/ns#Dinner"></see></summary>
    let Dinner = Namespaced_IRI.parse _namespace_name "Dinner" |> NamespacedName
    /// <summary>
    /// A double bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#Double"></see></summary>
    let Double = Namespaced_IRI.parse _namespace_name "Double" |> NamespacedName

    /// <summary>
    /// A type of dwelling, e.g. tent, mobile home, etc. for indicating the permitted usage on a campsite. Use DBpedia URIs whenever possible.
    /// <see href="http://purl.org/acco/ns#DwellingType"></see></summary>
    let DwellingType =
        Namespaced_IRI.parse _namespace_name "DwellingType" |> NamespacedName

    /// <summary>
    /// A hotel is an establishment that provides lodging paid on a short-term basis. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel)
    /// <see href="http://purl.org/acco/ns#Hotel"></see></summary>
    let Hotel = Namespaced_IRI.parse _namespace_name "Hotel" |> NamespacedName
    /// <summary>
    /// A hotel room is a single room in a hotel.
    /// <see href="http://purl.org/acco/ns#HotelRoom"></see></summary>
    let HotelRoom = Namespaced_IRI.parse _namespace_name "HotelRoom" |> NamespacedName
    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/House)
    /// <see href="http://purl.org/acco/ns#House"></see></summary>
    let House = Namespaced_IRI.parse _namespace_name "House" |> NamespacedName
    /// <summary>
    /// An King or Super King bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#King"></see></summary>
    let King = Namespaced_IRI.parse _namespace_name "King" |> NamespacedName
    /// <summary>
    /// A luncheon, commonly abbreviated to lunch, is a middle of the day meal. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Lunch)
    /// <see href="http://purl.org/acco/ns#Lunch"></see></summary>
    let Lunch = Namespaced_IRI.parse _namespace_name "Lunch" |> NamespacedName

    /// <summary>
    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Conference_hall)
    /// <see href="http://purl.org/acco/ns#MeetingRoom"></see></summary>
    let MeetingRoom =
        Namespaced_IRI.parse _namespace_name "MeetingRoom" |> NamespacedName

    /// <summary>
    /// An Olympic Queen bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#OlympicQueen"></see></summary>
    let OlympicQueen =
        Namespaced_IRI.parse _namespace_name "OlympicQueen" |> NamespacedName

    /// <summary>
    /// A Queen King (UK/Ire.) or Wide Double (Japan) bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#Queen"></see></summary>
    let Queen = Namespaced_IRI.parse _namespace_name "Queen" |> NamespacedName
    /// <summary>
    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Resort)
    /// <see href="http://purl.org/acco/ns#Resort"></see></summary>
    let Resort = Namespaced_IRI.parse _namespace_name "Resort" |> NamespacedName
    /// <summary>
    /// A single bed. The actual dimension may vary by country, see http://en.wikipedia.org/wiki/Bed_size.
    /// <see href="http://purl.org/acco/ns#Single"></see></summary>
    let Single = Namespaced_IRI.parse _namespace_name "Single" |> NamespacedName
    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms. (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Suite_(hotel))
    /// <see href="http://purl.org/acco/ns#Suite"></see></summary>
    let Suite = Namespaced_IRI.parse _namespace_name "Suite" |> NamespacedName

    /// <summary>
    /// Indicates the times of availability of a particular accommodation feature. Example: The sauna is available from 8:00 - 10:00 a.m. on weekdays.
    /// <see href="http://purl.org/acco/ns#availabilityTimes"></see></summary>
    let availabilityTimes =
        Namespaced_IRI.parse _namespace_name "availabilityTimes" |> NamespacedName

    /// <summary>
    /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use acco:bed directly with acco:BedType instances. If you want to indicate the quantity of a certain acco:BedType, use an instance of acco:BedDetails. For more detailed information, use acco:feature.
    /// <see href="http://purl.org/acco/ns#bed"></see></summary>
    let bed = Namespaced_IRI.parse _namespace_name "bed" |> NamespacedName
    /// <summary>
    /// A feature (e.g. a characteristic or service) of the acco:Accommodation. This generic property does not make a statement about whether the feature is included in the offer for the main accommodation or available at extra costs.
    /// <see href="http://purl.org/acco/ns#feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName
    /// <summary>
    /// Indicates whether the accommodation is gated, i.e. access is controlled via a fence and some form of gate.
    /// <see href="http://purl.org/acco/ns#gated"></see></summary>
    let gated = Namespaced_IRI.parse _namespace_name "gated" |> NamespacedName

    /// <summary>
    /// A feature (e.g. a characteristic or service) of the acco:Accommodation that is included in the offer for the main accommodation, i.e. at no extra costs.
    /// <see href="http://purl.org/acco/ns#includedFeature"></see></summary>
    let includedFeature =
        Namespaced_IRI.parse _namespace_name "includedFeature" |> NamespacedName

    /// <summary>
    /// The upper bound of the value for the feature. It is best to use this property with numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float.
    /// <see href="http://purl.org/acco/ns#max"></see></summary>
    let max = Namespaced_IRI.parse _namespace_name "max" |> NamespacedName
    /// <summary>
    /// The lower bound of the value for the feature. It is best to use this property with numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float.
    /// <see href="http://purl.org/acco/ns#min"></see></summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName

    /// <summary>
    /// The number of rooms (excluding bathrooms and closets of the acco:Suite, acco:House, or acco:Apartment.
    /// Typical unit code(s): C62 for person
    /// <see href="http://purl.org/acco/ns#numberOfRooms"></see></summary>
    let numberOfRooms =
        Namespaced_IRI.parse _namespace_name "numberOfRooms" |> NamespacedName

    /// <summary>
    /// The allowed total occupancy for the accommodation in persons (including infants etc.
    /// Typical unit code(s): C62 for person
    /// <see href="http://purl.org/acco/ns#occupancy"></see></summary>
    let occupancy = Namespaced_IRI.parse _namespace_name "occupancy" |> NamespacedName

    /// <summary>
    /// The allowed total occupancy of adults (in the sense of fully paying guests) for the accommodation in persons. The exact definition of what constitutes an adult varies across regions and will typically not match the legal definition of being an adult.
    /// Typical unit code(s): C62 for person
    /// <see href="http://purl.org/acco/ns#occupancyAdults"></see></summary>
    let occupancyAdults =
        Namespaced_IRI.parse _namespace_name "occupancyAdults" |> NamespacedName

    /// <summary>
    /// The allowed total occupancy of minors (in the sense of not fully paying guests) for the accommodation in persons. The exact definition of what constitutes a minor varies across regions and will typically not match the legal definition of being a minor.
    /// Typical unit code(s): C62 for person
    /// <see href="http://purl.org/acco/ns#occupancyMinors"></see></summary>
    let occupancyMinors =
        Namespaced_IRI.parse _namespace_name "occupancyMinors" |> NamespacedName

    /// <summary>
    /// A feature (e.g. a characteristic or service) of the acco:Accommodation that is generally available but not included in the offer for the main accommodation, i.e. at  extra costs.
    /// <see href="http://purl.org/acco/ns#optionalFeature"></see></summary>
    let optionalFeature =
        Namespaced_IRI.parse _namespace_name "optionalFeature" |> NamespacedName

    /// <summary>
    /// A naive parthood relation between two acco:Accommodation instances. Examples: A certain hotel room is part of a certain hotel, a certain house is part of a holiday resort, etc.
    /// <see href="http://purl.org/acco/ns#partOf"></see></summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// The type of objects that you are allowed to put on the camping pitch, e.g. a tent, car, boat, or mobile homre. Use DBpedia URIs whenever possible.
    /// <see href="http://purl.org/acco/ns#permittedUsage"></see></summary>
    let permittedUsage =
        Namespaced_IRI.parse _namespace_name "permittedUsage" |> NamespacedName

    /// <summary>
    /// Indicates whether pets are allowed to enter the accommodation.
    /// <see href="http://purl.org/acco/ns#petsAllowed"></see></summary>
    let petsAllowed =
        Namespaced_IRI.parse _namespace_name "petsAllowed" |> NamespacedName

    /// <summary>
    /// This property links to all gr:UnitPriceSpecification nodes that apply in parallel for the acco:CompoundPrice node.
    /// <see href="http://purl.org/acco/ns#priceComponent"></see></summary>
    let priceComponent =
        Namespaced_IRI.parse _namespace_name "priceComponent" |> NamespacedName

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
    let propertyID = Namespaced_IRI.parse _namespace_name "propertyID" |> NamespacedName
    /// <summary>
    /// The quantity of the given bed type available in the acco:HotelRoom, acco:Suite, acco:House, or acco:Apartment.
    /// <see href="http://purl.org/acco/ns#quantity"></see></summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName

    /// <summary>
    /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for gr:hasUnitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
    /// <see href="http://purl.org/acco/ns#referenceQuantity"></see></summary>
    let referenceQuantity =
        Namespaced_IRI.parse _namespace_name "referenceQuantity" |> NamespacedName

    /// <summary>
    /// The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
    /// <see href="http://purl.org/acco/ns#size"></see></summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
    /// <summary>
    /// The type of bed to which the acco:BedDetail node refers, i.e. the type of bed available in the quantity indicated by acco:quantity.
    /// <see href="http://purl.org/acco/ns#typeOfBed"></see></summary>
    let typeOfBed = Namespaced_IRI.parse _namespace_name "typeOfBed" |> NamespacedName
    /// <summary>
    /// A textual representation of the unit of measurement, e.g. global identifier, e.g. "m" or "meter". When you have the UN/CEFACT Common Code for the unit available, it is better to use acco:unitCode. This property is for the cases where a standardized unit code is not available from the data source.
    /// <see href="http://purl.org/acco/ns#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName
    /// <summary>
    /// The UN/CEFACT Common Code for the unit of measurement, e.g. "MTR" for meter, "HUR" for hours, etc. If you only have a textual representation of the unit of measurement, use acco:unit instead.
    /// <see href="http://purl.org/acco/ns#unitCode"></see></summary>
    let unitCode = Namespaced_IRI.parse _namespace_name "unitCode" |> NamespacedName
    /// <summary>
    /// Indicates the beginning of a time interval during which a certain feature is valid or available. For example, a sauna or swimming pool may only be available during certain periods.
    /// <see href="http://purl.org/acco/ns#validFrom"></see></summary>
    let validFrom = Namespaced_IRI.parse _namespace_name "validFrom" |> NamespacedName

    /// <summary>
    /// Indicates the beginning of a time interval during which a certain feature is valid or available. For example, a sauna or swimming pool may only be available during certain periods.
    /// <see href="http://purl.org/acco/ns#validThrough"></see></summary>
    let validThrough =
        Namespaced_IRI.parse _namespace_name "validThrough" |> NamespacedName

    /// <summary>
    /// The point value for the feature unless it is an interval. If possible, use numerical datatypes, e.g. xsd:decimal, xsd:int, or xsd:float. Textual content is also acceptable, though.
    /// <see href="http://purl.org/acco/ns#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
