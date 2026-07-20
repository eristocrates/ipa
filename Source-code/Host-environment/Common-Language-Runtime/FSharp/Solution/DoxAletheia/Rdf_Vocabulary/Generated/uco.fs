namespace http.purl.org.uco.ns.hash

open DoxAletheia

module uco =
    let _namespace_name = "http://purl.org/uco/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An authorized dealer of the manufacturer of the respective vehicle
    /// <see href="http://purl.org/uco/ns#AuthorizedDealer"></see></summary>
    let AuthorizedDealer = _prefix "AuthorizedDealer"
    /// <summary>
    /// The usage of a vehicle for general business purposes, i.e. excluding usages like as a taxi, rental car, or driving instructions.
    /// <see href="http://purl.org/uco/ns#Business"></see></summary>
    let Business = _prefix "Business"
    /// <summary>
    /// A type of usage of a vehicle, e.g. rental, taxi, driving school, commuting. It is best to either use one of the predefined individuals or DBpedia URIs whenever possible.
    /// <see href="http://purl.org/uco/ns#UsageType"></see></summary>
    let UsageType = _prefix "UsageType"
    /// <summary>
    /// The usage of a vehicle for car sharing networks
    /// <see href="http://purl.org/uco/ns#CarSharing"></see></summary>
    let CarSharing = _prefix "CarSharing"
    /// <summary>
    /// The parking of a vehicle under a protective roof, e.g. in a carport
    /// <see href="http://purl.org/uco/ns#Carport"></see></summary>
    let Carport = _prefix "Carport"
    /// <summary>
    /// A type of parking for a vehicle, e.g. in a garage, on the street (open-sky), or in a carport. You can use DBpedia URIs for additional types.
    /// <see href="http://purl.org/uco/ns#ParkingType"></see></summary>
    let ParkingType = _prefix "ParkingType"
    /// <summary>
    /// A mandatory or optional technical inspection, e.g. the MOT, a vendor-specific certification of used cars, etc.
    /// <see href="http://purl.org/uco/ns#Check"></see></summary>
    let Check = _prefix "Check"
    /// <summary>
    /// A damage or accident is an event in which the vehicle is being damaged.
    /// <see href="http://purl.org/uco/ns#DamageOrAccident"></see></summary>
    let DamageOrAccident = _prefix "DamageOrAccident"
    /// <summary>
    /// The usage of a vehicle for commercial driver's education
    /// <see href="http://purl.org/uco/ns#DrivingSchool"></see></summary>
    let DrivingSchool = _prefix "DrivingSchool"
    /// <summary>
    /// The parking of a vehicle in a closed garage
    /// <see href="http://purl.org/uco/ns#Garage"></see></summary>
    let Garage = _prefix "Garage"
    /// <summary>
    /// An independent dealer
    /// <see href="http://purl.org/uco/ns#IndependentDealer"></see></summary>
    let IndependentDealer = _prefix "IndependentDealer"
    /// <summary>
    /// A modification or maintenance is an event in which a part of the vehicle is being replaced or removed, or a new part is being added.
    /// Typical examples are the replacement of the engine or the installation of a trailor-hitch.
    /// <see href="http://purl.org/uco/ns#ModificationOrMaintenance"></see></summary>
    let ModificationOrMaintenance = _prefix "ModificationOrMaintenance"
    /// <summary>
    /// The promise to take back the vehicle without any specific reason for a full refund within a certain amount of time
    /// <see href="http://purl.org/uco/ns#MoneyBack"></see></summary>
    let MoneyBack = _prefix "MoneyBack"
    /// <summary>
    /// An ownership information node is a structured value representing information about the period of ownership of a vehicle by a person or organisation.
    /// <see href="http://purl.org/uco/ns#OwnershipInfo"></see></summary>
    let OwnershipInfo = _prefix "OwnershipInfo"
    /// <summary>
    /// The usage of a vehicle soleley for private purposes
    /// <see href="http://purl.org/uco/ns#Private"></see></summary>
    let Private = _prefix "Private"
    /// <summary>
    /// A property-value is a structured value for representing a feature of a vehicle in a semi-formal way.
    /// <see href="http://purl.org/uco/ns#PropertyValue"></see></summary>
    let PropertyValue = _prefix "PropertyValue"
    /// <summary>
    /// The usage of a vehicle as a rental car
    /// <see href="http://purl.org/uco/ns#Rental"></see></summary>
    let Rental = _prefix "Rental"
    /// <summary>
    /// A species, typically a pet, for indicating the type of animals that were regularly transported in the vehicle.
    ///
    /// If possible, use DBPedia URIs, e.g. http://dbpedia.org/resource/Dog.
    /// <see href="http://purl.org/uco/ns#Species"></see></summary>
    let Species = _prefix "Species"
    /// <summary>
    /// The parking of a vehicle on a public or private street
    /// <see href="http://purl.org/uco/ns#Street"></see></summary>
    let Street = _prefix "Street"
    /// <summary>
    /// The usage of a vehicle as a taxi
    /// <see href="http://purl.org/uco/ns#Taxi"></see></summary>
    let Taxi = _prefix "Taxi"
    /// <summary>
    /// This property indicates whether at least one of the airbags of the vehicle has been deployed in the respective accident (when attached to uco:DamageOrAccident) or ever (when directly applied to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#airbagDeployment"></see></summary>
    let airbagDeployment = _prefix "airbagDeployment"
    /// <summary>
    /// The business or type of business that carried out the check, repair, maintenance, or modification
    /// <see href="http://purl.org/uco/ns#carriedOutBy"></see></summary>
    let carriedOutBy = _prefix "carriedOutBy"
    /// <summary>
    /// A naive part-whole relation that allows providing more granular uco:OwnershipInfo data for a part of the duration of the ownership
    /// <see href="http://purl.org/uco/ns#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// The country or geo-political region in which the vehicle was initially sold officially, indicated as the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2) for regions or ISO 3166-2, which breaks down the countries from ISO 3166-1 into administrative subdivisions.
    /// <see href="http://purl.org/uco/ns#countryOfOrigin"></see></summary>
    let countryOfOrigin = _prefix "countryOfOrigin"
    /// <summary>
    /// The country or geo-political region in which the vehicle is currently registered, indicated as the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2) for regions or ISO 3166-2, which breaks down the countries from ISO 3166-1 into administrative subdivisions.
    /// <see href="http://purl.org/uco/ns#countryOfRegistration"></see></summary>
    let countryOfRegistration = _prefix "countryOfRegistration"
    /// <summary>
    /// The current location of the vehicle, i.e. where the car could be tested. For indicating alternative locations to which the seller is willing to bring the car, use gr:availableAtOrFrom attached to the gr:Offering, since those are aspects of the offer, not of the vehicle.
    /// <see href="http://purl.org/uco/ns#currentLocation"></see></summary>
    let currentLocation = _prefix "currentLocation"
    /// <summary>
    /// This property points to the current owner of the vehicle.
    /// <see href="http://purl.org/uco/ns#currentOwner"></see></summary>
    let currentOwner = _prefix "currentOwner"
    /// <summary>
    /// This property points to the owner of the vehicle for the respective period of time, as indicated by the uco:OwnershipInfo node.
    /// <see href="http://purl.org/uco/ns#owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    /// This property points to the driver or drivers that were regularly driving the vehicle during the respective period of time (when attached to uco:OwnershipInfo) or in total (when attached directly to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#driver"></see></summary>
    let driver = _prefix "driver"
    /// <summary>
    /// This property points to events related to the vehicle, like accidents and damages or major modifications or maintenance.
    /// <see href="http://purl.org/uco/ns#eventInformation"></see></summary>
    let eventInformation = _prefix "eventInformation"
    /// <summary>
    /// This property points to vehicle features in a semi-structured property-value form.
    /// <see href="http://purl.org/uco/ns#feature"></see></summary>
    let feature = _prefix "feature"
    /// <summary>
    /// This property indicates the beginning of the period of ownership represented by this uco:OwnershipInfo node.
    /// <see href="http://purl.org/uco/ns#from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    /// This property points to information about the current and previous owners of the vehicle.
    /// <see href="http://purl.org/uco/ns#hasOwnershipInfo"></see></summary>
    let hasOwnershipInfo = _prefix "hasOwnershipInfo"
    /// <summary>
    /// This property indicates whether it is likely or known that the odometer of the vehicle does not properly reflect the total mileage of the vehicle, e.g. because the odometer has been replaced, reset, or tampered with
    /// <see href="http://purl.org/uco/ns#indicationOfOdometerRollback"></see></summary>
    let indicationOfOdometerRollback = _prefix "indicationOfOdometerRollback"
    /// <summary>
    /// This property points to inspections and certifications that the vehicle has undergone.
    /// <see href="http://purl.org/uco/ns#inspected"></see></summary>
    let inspected = _prefix "inspected"
    /// <summary>
    /// The license plate string(s) assigned to the vehicle during the period of ownership
    /// <see href="http://purl.org/uco/ns#licensePlate"></see></summary>
    let licensePlate = _prefix "licensePlate"
    /// <summary>
    /// The original list price of the new car at the time of production
    /// <see href="http://purl.org/uco/ns#listPrice"></see></summary>
    let listPrice = _prefix "listPrice"
    /// <summary>
    /// The main location(s) of the vehicle during the period of ownership
    /// <see href="http://purl.org/uco/ns#mainLocation"></see></summary>
    let mainLocation = _prefix "mainLocation"
    /// <summary>
    /// The mileage of the vehicle at the event, e.g. at the accident, maintenance, check, or modification.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    /// <see href="http://purl.org/uco/ns#mileage"></see></summary>
    let mileage = _prefix "mileage"
    /// <summary>
    /// The mileage of the vehicle at the end of the period of ownership.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    /// <see href="http://purl.org/uco/ns#mileageEnd"></see></summary>
    let mileageEnd = _prefix "mileageEnd"
    /// <summary>
    /// The mileage of the vehicle at the beginning of the period of ownership.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    /// <see href="http://purl.org/uco/ns#mileageInitial"></see></summary>
    let mileageInitial = _prefix "mileageInitial"
    /// <summary>
    /// This property indicates whether the accident leading to the damage was a not-at-fault accident from the perspective of the owner.
    /// <see href="http://purl.org/uco/ns#notAtFaultAccident"></see></summary>
    let notAtFaultAccident = _prefix "notAtFaultAccident"
    /// <summary>
    /// The number of people who were/are regularly driving the vehicle in the respective period of time (when attached to uco:OwnershipInfo) or in total (when directly applied to a vso:Vehicle)
    /// <see href="http://purl.org/uco/ns#numberOfDrivers"></see></summary>
    let numberOfDrivers = _prefix "numberOfDrivers"
    /// <summary>
    /// The total number of people or organizations who owned the vehicle, including the current owner.
    ///
    /// Note that this value can be higher (but not lower) than the number of uco:OwnershipInfo nodes, since those records may be incomplete.
    /// <see href="http://purl.org/uco/ns#numberOfOwners"></see></summary>
    let numberOfOwners = _prefix "numberOfOwners"
    /// <summary>
    /// This indicates whether the parts used for repairing a damage, for a maintenance task, or a modification were all original.
    /// <see href="http://purl.org/uco/ns#originalPartsOnly"></see></summary>
    let originalPartsOnly = _prefix "originalPartsOnly"
    /// <summary>
    /// The main type(s) of parking that have been used for the vehicle during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly)
    /// <see href="http://purl.org/uco/ns#parking"></see></summary>
    let parking = _prefix "parking"
    /// <summary>
    /// A textual description of the part or parts added in the modification (e.g. tuning) or maintenance task
    /// <see href="http://purl.org/uco/ns#partAdded"></see></summary>
    let partAdded = _prefix "partAdded"
    /// <summary>
    /// A textual description of the part or parts removed in the modification (e.g. tuning) or maintenance task
    /// <see href="http://purl.org/uco/ns#partRemoved"></see></summary>
    let partRemoved = _prefix "partRemoved"
    /// <summary>
    /// A textual description of the part or parts replaced in the modification (e.g. tuning) or maintenance (e.g. new engine) task
    /// <see href="http://purl.org/uco/ns#partReplaced"></see></summary>
    let partReplaced = _prefix "partReplaced"
    /// <summary>
    /// The type(s) of animals that have been transported in the vehicle during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly).
    ///
    /// If possible, use DBPedia URIs, e.g. http://dbpedia.org/resource/Dog.
    /// <see href="http://purl.org/uco/ns#pets"></see></summary>
    let pets = _prefix "pets"
    /// <summary>
    /// A global identifier, e.g. a URI, a prefixed string, or any other identifier that can be used to refer to a standardized property type
    /// <see href="http://purl.org/uco/ns#propertyID"></see></summary>
    let propertyID = _prefix "propertyID"
    /// <summary>
    /// The name of the property
    /// <see href="http://purl.org/uco/ns#propertyName"></see></summary>
    let propertyName = _prefix "propertyName"
    /// <summary>
    /// The value of of the property
    /// <see href="http://purl.org/uco/ns#propertyValue"></see></summary>
    let propertyValue = _prefix "propertyValue"
    /// <summary>
    /// This indicates whether damages resulting from a certain uco:DamageOrAccident (when attached to this type) or all damages (when directly attached to a vso:Vehicle) have been properly repaired. Do not use this propery on a vso:Vehicle if it never had a damage.
    /// <see href="http://purl.org/uco/ns#repaired"></see></summary>
    let repaired = _prefix "repaired"
    /// <summary>
    /// This property indicates whether it has been smoked inside the car in the respective period of time (when attached to uco:OwnershipInfo) or ever (when directly applied to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#smoking"></see></summary>
    let smoking = _prefix "smoking"
    /// <summary>
    /// This property indicates whether the vehicle has suffered from structural damage in the respective accident (when attached to uco:DamageOrAccident) or ever (when directly applied to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#structuralDamage"></see></summary>
    let structuralDamage = _prefix "structuralDamage"
    /// <summary>
    /// This property indicates the end of the period of ownership represented by this uco:OwnershipInfo node.
    /// <see href="http://purl.org/uco/ns#to"></see></summary>
    let to_ = _prefix "to"
    /// <summary>
    /// This property indicates whether the vehicle is considered a total loss as the result of a damage in the respective accident (when attached to uco:DamageOrAccident) or in general (when directly applied to a vso:Vehicle).
    /// <see href="http://purl.org/uco/ns#totalLoss"></see></summary>
    let totalLoss = _prefix "totalLoss"
    /// <summary>
    /// A UN/CEFACT Common Code for indicating the unit of measurement of the value, if available
    /// <see href="http://purl.org/uco/ns#unitCode"></see></summary>
    let unitCode = _prefix "unitCode"
    /// <summary>
    /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for uco:unitCode.
    /// <see href="http://purl.org/uco/ns#unitText"></see></summary>
    let unitText = _prefix "unitText"
    /// <summary>
    /// The type(s) of usage during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly)
    /// <see href="http://purl.org/uco/ns#usage"></see></summary>
    let usage = _prefix "usage"
    /// <summary>
    /// This property indicates the beginning of the validity of the inspection represented by the uco:Check node. This is typically the day of the inspection.
    /// <see href="http://purl.org/uco/ns#validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    /// This property indicates the end of the validity of the inspection represented by the uco:Check node. This is typically the day of the inspection plus one (UK MOT) or two years (e.g. German TÜV).
    /// <see href="http://purl.org/uco/ns#validThrough"></see></summary>
    let validThrough = _prefix "validThrough"
    /// <summary>
    /// The market price assessment gained by the respective valuation. Use gr:name to indicate the name of the valuation service.
    /// <see href="http://purl.org/uco/ns#valuation"></see></summary>
    let valuation = _prefix "valuation"
