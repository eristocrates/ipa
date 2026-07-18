namespace http.purl.org.uco.ns.hash

open DoxAletheia.Rdf_Vocabulary

module uco =
    let _namespace_name = "http://purl.org/uco/ns#"

    /// <summary>
    /// An authorized dealer of the manufacturer of the respective vehicle
    /// <see href="http://purl.org/uco/ns#AuthorizedDealer"></see></summary>
    let AuthorizedDealer =
        Namespaced_IRI.parse _namespace_name "AuthorizedDealer" |> NamespacedName

    /// <summary>
    /// The usage of a vehicle for general business purposes, i.e. excluding usages like as a taxi, rental car, or driving instructions.
    /// <see href="http://purl.org/uco/ns#Business"></see></summary>
    let Business = Namespaced_IRI.parse _namespace_name "Business" |> NamespacedName
    /// <summary>
    /// A type of usage of a vehicle, e.g. rental, taxi, driving school, commuting. It is best to either use one of the predefined individuals or DBpedia URIs whenever possible.
    /// <see href="http://purl.org/uco/ns#UsageType"></see></summary>
    let UsageType = Namespaced_IRI.parse _namespace_name "UsageType" |> NamespacedName
    /// <summary>
    /// The usage of a vehicle for car sharing networks
    /// <see href="http://purl.org/uco/ns#CarSharing"></see></summary>
    let CarSharing = Namespaced_IRI.parse _namespace_name "CarSharing" |> NamespacedName
    /// <summary>
    /// The parking of a vehicle under a protective roof, e.g. in a carport
    /// <see href="http://purl.org/uco/ns#Carport"></see></summary>
    let Carport = Namespaced_IRI.parse _namespace_name "Carport" |> NamespacedName

    /// <summary>
    /// A type of parking for a vehicle, e.g. in a garage, on the street (open-sky), or in a carport. You can use DBpedia URIs for additional types.
    /// <see href="http://purl.org/uco/ns#ParkingType"></see></summary>
    let ParkingType =
        Namespaced_IRI.parse _namespace_name "ParkingType" |> NamespacedName

    /// <summary>
    /// A mandatory or optional technical inspection, e.g. the MOT, a vendor-specific certification of used cars, etc.
    /// <see href="http://purl.org/uco/ns#Check"></see></summary>
    let Check = Namespaced_IRI.parse _namespace_name "Check" |> NamespacedName

    /// <summary>
    /// A damage or accident is an event in which the vehicle is being damaged.
    /// <see href="http://purl.org/uco/ns#DamageOrAccident"></see></summary>
    let DamageOrAccident =
        Namespaced_IRI.parse _namespace_name "DamageOrAccident" |> NamespacedName

    /// <summary>
    /// The usage of a vehicle for commercial driver's education
    /// <see href="http://purl.org/uco/ns#DrivingSchool"></see></summary>
    let DrivingSchool =
        Namespaced_IRI.parse _namespace_name "DrivingSchool" |> NamespacedName

    /// <summary>
    /// The parking of a vehicle in a closed garage
    /// <see href="http://purl.org/uco/ns#Garage"></see></summary>
    let Garage = Namespaced_IRI.parse _namespace_name "Garage" |> NamespacedName

    /// <summary>
    /// An independent dealer
    /// <see href="http://purl.org/uco/ns#IndependentDealer"></see></summary>
    let IndependentDealer =
        Namespaced_IRI.parse _namespace_name "IndependentDealer" |> NamespacedName

    /// <summary>
    /// A modification or maintenance is an event in which a part of the vehicle is being replaced or removed, or a new part is being added.
    /// Typical examples are the replacement of the engine or the installation of a trailor-hitch.
    /// <see href="http://purl.org/uco/ns#ModificationOrMaintenance"></see></summary>
    let ModificationOrMaintenance =
        Namespaced_IRI.parse _namespace_name "ModificationOrMaintenance" |> NamespacedName

    /// <summary>
    /// The promise to take back the vehicle without any specific reason for a full refund within a certain amount of time
    /// <see href="http://purl.org/uco/ns#MoneyBack"></see></summary>
    let MoneyBack = Namespaced_IRI.parse _namespace_name "MoneyBack" |> NamespacedName

    /// <summary>
    /// An ownership information node is a structured value representing information about the period of ownership of a vehicle by a person or organisation.
    /// <see href="http://purl.org/uco/ns#OwnershipInfo"></see></summary>
    let OwnershipInfo =
        Namespaced_IRI.parse _namespace_name "OwnershipInfo" |> NamespacedName

    /// <summary>
    /// The usage of a vehicle soleley for private purposes
    /// <see href="http://purl.org/uco/ns#Private"></see></summary>
    let Private = Namespaced_IRI.parse _namespace_name "Private" |> NamespacedName

    /// <summary>
    /// A property-value is a structured value for representing a feature of a vehicle in a semi-formal way.
    /// <see href="http://purl.org/uco/ns#PropertyValue"></see></summary>
    let PropertyValue =
        Namespaced_IRI.parse _namespace_name "PropertyValue" |> NamespacedName

    /// <summary>
    /// The usage of a vehicle as a rental car
    /// <see href="http://purl.org/uco/ns#Rental"></see></summary>
    let Rental = Namespaced_IRI.parse _namespace_name "Rental" |> NamespacedName
    /// <summary>
    /// A species, typically a pet, for indicating the type of animals that were regularly transported in the vehicle.
    ///
    /// If possible, use DBPedia URIs, e.g. http://dbpedia.org/resource/Dog.
    /// <see href="http://purl.org/uco/ns#Species"></see></summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName
    /// <summary>
    /// The parking of a vehicle on a public or private street
    /// <see href="http://purl.org/uco/ns#Street"></see></summary>
    let Street = Namespaced_IRI.parse _namespace_name "Street" |> NamespacedName
    /// <summary>
    /// The usage of a vehicle as a taxi
    /// <see href="http://purl.org/uco/ns#Taxi"></see></summary>
    let Taxi = Namespaced_IRI.parse _namespace_name "Taxi" |> NamespacedName

    /// <summary>
    /// This property indicates whether at least one of the airbags of the vehicle has been deployed in the respective accident (when attached to uco:DamageOrAccident) or ever (when directly applied to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#airbagDeployment"></see></summary>
    let airbagDeployment =
        Namespaced_IRI.parse _namespace_name "airbagDeployment" |> NamespacedName

    /// <summary>
    /// The business or type of business that carried out the check, repair, maintenance, or modification
    /// <see href="http://purl.org/uco/ns#carriedOutBy"></see></summary>
    let carriedOutBy =
        Namespaced_IRI.parse _namespace_name "carriedOutBy" |> NamespacedName

    /// <summary>
    /// A naive part-whole relation that allows providing more granular uco:OwnershipInfo data for a part of the duration of the ownership
    /// <see href="http://purl.org/uco/ns#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// The country or geo-political region in which the vehicle was initially sold officially, indicated as the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2) for regions or ISO 3166-2, which breaks down the countries from ISO 3166-1 into administrative subdivisions.
    /// <see href="http://purl.org/uco/ns#countryOfOrigin"></see></summary>
    let countryOfOrigin =
        Namespaced_IRI.parse _namespace_name "countryOfOrigin" |> NamespacedName

    /// <summary>
    /// The country or geo-political region in which the vehicle is currently registered, indicated as the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2) for regions or ISO 3166-2, which breaks down the countries from ISO 3166-1 into administrative subdivisions.
    /// <see href="http://purl.org/uco/ns#countryOfRegistration"></see></summary>
    let countryOfRegistration =
        Namespaced_IRI.parse _namespace_name "countryOfRegistration" |> NamespacedName

    /// <summary>
    /// The current location of the vehicle, i.e. where the car could be tested. For indicating alternative locations to which the seller is willing to bring the car, use gr:availableAtOrFrom attached to the gr:Offering, since those are aspects of the offer, not of the vehicle.
    /// <see href="http://purl.org/uco/ns#currentLocation"></see></summary>
    let currentLocation =
        Namespaced_IRI.parse _namespace_name "currentLocation" |> NamespacedName

    /// <summary>
    /// This property points to the current owner of the vehicle.
    /// <see href="http://purl.org/uco/ns#currentOwner"></see></summary>
    let currentOwner =
        Namespaced_IRI.parse _namespace_name "currentOwner" |> NamespacedName

    /// <summary>
    /// This property points to the owner of the vehicle for the respective period of time, as indicated by the uco:OwnershipInfo node.
    /// <see href="http://purl.org/uco/ns#owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName
    /// <summary>
    /// This property points to the driver or drivers that were regularly driving the vehicle during the respective period of time (when attached to uco:OwnershipInfo) or in total (when attached directly to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#driver"></see></summary>
    let driver = Namespaced_IRI.parse _namespace_name "driver" |> NamespacedName

    /// <summary>
    /// This property points to events related to the vehicle, like accidents and damages or major modifications or maintenance.
    /// <see href="http://purl.org/uco/ns#eventInformation"></see></summary>
    let eventInformation =
        Namespaced_IRI.parse _namespace_name "eventInformation" |> NamespacedName

    /// <summary>
    /// This property points to vehicle features in a semi-structured property-value form.
    /// <see href="http://purl.org/uco/ns#feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName
    /// <summary>
    /// This property indicates the beginning of the period of ownership represented by this uco:OwnershipInfo node.
    /// <see href="http://purl.org/uco/ns#from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName

    /// <summary>
    /// This property points to information about the current and previous owners of the vehicle.
    /// <see href="http://purl.org/uco/ns#hasOwnershipInfo"></see></summary>
    let hasOwnershipInfo =
        Namespaced_IRI.parse _namespace_name "hasOwnershipInfo" |> NamespacedName

    /// <summary>
    /// This property indicates whether it is likely or known that the odometer of the vehicle does not properly reflect the total mileage of the vehicle, e.g. because the odometer has been replaced, reset, or tampered with
    /// <see href="http://purl.org/uco/ns#indicationOfOdometerRollback"></see></summary>
    let indicationOfOdometerRollback =
        Namespaced_IRI.parse _namespace_name "indicationOfOdometerRollback" |> NamespacedName

    /// <summary>
    /// This property points to inspections and certifications that the vehicle has undergone.
    /// <see href="http://purl.org/uco/ns#inspected"></see></summary>
    let inspected = Namespaced_IRI.parse _namespace_name "inspected" |> NamespacedName

    /// <summary>
    /// The license plate string(s) assigned to the vehicle during the period of ownership
    /// <see href="http://purl.org/uco/ns#licensePlate"></see></summary>
    let licensePlate =
        Namespaced_IRI.parse _namespace_name "licensePlate" |> NamespacedName

    /// <summary>
    /// The original list price of the new car at the time of production
    /// <see href="http://purl.org/uco/ns#listPrice"></see></summary>
    let listPrice = Namespaced_IRI.parse _namespace_name "listPrice" |> NamespacedName

    /// <summary>
    /// The main location(s) of the vehicle during the period of ownership
    /// <see href="http://purl.org/uco/ns#mainLocation"></see></summary>
    let mainLocation =
        Namespaced_IRI.parse _namespace_name "mainLocation" |> NamespacedName

    /// <summary>
    /// The mileage of the vehicle at the event, e.g. at the accident, maintenance, check, or modification.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    /// <see href="http://purl.org/uco/ns#mileage"></see></summary>
    let mileage = Namespaced_IRI.parse _namespace_name "mileage" |> NamespacedName
    /// <summary>
    /// The mileage of the vehicle at the end of the period of ownership.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    /// <see href="http://purl.org/uco/ns#mileageEnd"></see></summary>
    let mileageEnd = Namespaced_IRI.parse _namespace_name "mileageEnd" |> NamespacedName

    /// <summary>
    /// The mileage of the vehicle at the beginning of the period of ownership.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    /// <see href="http://purl.org/uco/ns#mileageInitial"></see></summary>
    let mileageInitial =
        Namespaced_IRI.parse _namespace_name "mileageInitial" |> NamespacedName

    /// <summary>
    /// This property indicates whether the accident leading to the damage was a not-at-fault accident from the perspective of the owner.
    /// <see href="http://purl.org/uco/ns#notAtFaultAccident"></see></summary>
    let notAtFaultAccident =
        Namespaced_IRI.parse _namespace_name "notAtFaultAccident" |> NamespacedName

    /// <summary>
    /// The number of people who were/are regularly driving the vehicle in the respective period of time (when attached to uco:OwnershipInfo) or in total (when directly applied to a vso:Vehicle)
    /// <see href="http://purl.org/uco/ns#numberOfDrivers"></see></summary>
    let numberOfDrivers =
        Namespaced_IRI.parse _namespace_name "numberOfDrivers" |> NamespacedName

    /// <summary>
    /// The total number of people or organizations who owned the vehicle, including the current owner.
    ///
    /// Note that this value can be higher (but not lower) than the number of uco:OwnershipInfo nodes, since those records may be incomplete.
    /// <see href="http://purl.org/uco/ns#numberOfOwners"></see></summary>
    let numberOfOwners =
        Namespaced_IRI.parse _namespace_name "numberOfOwners" |> NamespacedName

    /// <summary>
    /// This indicates whether the parts used for repairing a damage, for a maintenance task, or a modification were all original.
    /// <see href="http://purl.org/uco/ns#originalPartsOnly"></see></summary>
    let originalPartsOnly =
        Namespaced_IRI.parse _namespace_name "originalPartsOnly" |> NamespacedName

    /// <summary>
    /// The main type(s) of parking that have been used for the vehicle during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly)
    /// <see href="http://purl.org/uco/ns#parking"></see></summary>
    let parking = Namespaced_IRI.parse _namespace_name "parking" |> NamespacedName
    /// <summary>
    /// A textual description of the part or parts added in the modification (e.g. tuning) or maintenance task
    /// <see href="http://purl.org/uco/ns#partAdded"></see></summary>
    let partAdded = Namespaced_IRI.parse _namespace_name "partAdded" |> NamespacedName

    /// <summary>
    /// A textual description of the part or parts removed in the modification (e.g. tuning) or maintenance task
    /// <see href="http://purl.org/uco/ns#partRemoved"></see></summary>
    let partRemoved =
        Namespaced_IRI.parse _namespace_name "partRemoved" |> NamespacedName

    /// <summary>
    /// A textual description of the part or parts replaced in the modification (e.g. tuning) or maintenance (e.g. new engine) task
    /// <see href="http://purl.org/uco/ns#partReplaced"></see></summary>
    let partReplaced =
        Namespaced_IRI.parse _namespace_name "partReplaced" |> NamespacedName

    /// <summary>
    /// The type(s) of animals that have been transported in the vehicle during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly).
    ///
    /// If possible, use DBPedia URIs, e.g. http://dbpedia.org/resource/Dog.
    /// <see href="http://purl.org/uco/ns#pets"></see></summary>
    let pets = Namespaced_IRI.parse _namespace_name "pets" |> NamespacedName
    /// <summary>
    /// A global identifier, e.g. a URI, a prefixed string, or any other identifier that can be used to refer to a standardized property type
    /// <see href="http://purl.org/uco/ns#propertyID"></see></summary>
    let propertyID = Namespaced_IRI.parse _namespace_name "propertyID" |> NamespacedName

    /// <summary>
    /// The name of the property
    /// <see href="http://purl.org/uco/ns#propertyName"></see></summary>
    let propertyName =
        Namespaced_IRI.parse _namespace_name "propertyName" |> NamespacedName

    /// <summary>
    /// The value of of the property
    /// <see href="http://purl.org/uco/ns#propertyValue"></see></summary>
    let propertyValue =
        Namespaced_IRI.parse _namespace_name "propertyValue" |> NamespacedName

    /// <summary>
    /// This indicates whether damages resulting from a certain uco:DamageOrAccident (when attached to this type) or all damages (when directly attached to a vso:Vehicle) have been properly repaired. Do not use this propery on a vso:Vehicle if it never had a damage.
    /// <see href="http://purl.org/uco/ns#repaired"></see></summary>
    let repaired = Namespaced_IRI.parse _namespace_name "repaired" |> NamespacedName
    /// <summary>
    /// This property indicates whether it has been smoked inside the car in the respective period of time (when attached to uco:OwnershipInfo) or ever (when directly applied to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#smoking"></see></summary>
    let smoking = Namespaced_IRI.parse _namespace_name "smoking" |> NamespacedName

    /// <summary>
    /// This property indicates whether the vehicle has suffered from structural damage in the respective accident (when attached to uco:DamageOrAccident) or ever (when directly applied to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#structuralDamage"></see></summary>
    let structuralDamage =
        Namespaced_IRI.parse _namespace_name "structuralDamage" |> NamespacedName

    /// <summary>
    /// This property indicates the end of the period of ownership represented by this uco:OwnershipInfo node.
    /// <see href="http://purl.org/uco/ns#to"></see></summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName
    /// <summary>
    /// This property indicates whether the vehicle is considered a total loss as the result of a damage in the respective accident (when attached to uco:DamageOrAccident) or in general (when directly applied to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#totalLoss"></see></summary>
    let totalLoss = Namespaced_IRI.parse _namespace_name "totalLoss" |> NamespacedName
    /// <summary>
    /// A UN/CEFACT Common Code for indicating the unit of measurement of the value, if available
    /// <see href="http://purl.org/uco/ns#unitCode"></see></summary>
    let unitCode = Namespaced_IRI.parse _namespace_name "unitCode" |> NamespacedName
    /// <summary>
    /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for uco:unitCode.
    /// <see href="http://purl.org/uco/ns#unitText"></see></summary>
    let unitText = Namespaced_IRI.parse _namespace_name "unitText" |> NamespacedName
    /// <summary>
    /// The type(s) of usage during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly)
    /// <see href="http://purl.org/uco/ns#usage"></see></summary>
    let usage = Namespaced_IRI.parse _namespace_name "usage" |> NamespacedName
    /// <summary>
    /// This property indicates the beginning of the validity of the inspection represented by the uco:Check node. This is typically the day of the inspection.
    /// <see href="http://purl.org/uco/ns#validFrom"></see></summary>
    let validFrom = Namespaced_IRI.parse _namespace_name "validFrom" |> NamespacedName

    /// <summary>
    /// This property indicates the end of the validity of the inspection represented by the uco:Check node. This is typically the day of the inspection plus one (UK MOT) or two years (e.g. German TÜV).
    /// <see href="http://purl.org/uco/ns#validThrough"></see></summary>
    let validThrough =
        Namespaced_IRI.parse _namespace_name "validThrough" |> NamespacedName

    /// <summary>
    /// The market price assessment gained by the respective valuation. Use gr:name to indicate the name of the valuation service.
    /// <see href="http://purl.org/uco/ns#valuation"></see></summary>
    let valuation = Namespaced_IRI.parse _namespace_name "valuation" |> NamespacedName
