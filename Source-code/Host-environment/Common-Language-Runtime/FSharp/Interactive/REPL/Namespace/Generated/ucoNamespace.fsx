#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module uco =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/uco/ns#" "uco"
    let _namespaceIri = _prefixId.prefix ""
    let AuthorizedDealer = _prefixId.prefix "AuthorizedDealer"
    let Business = _prefixId.prefix "Business"
    let CarSharing = _prefixId.prefix "CarSharing"
    let Carport = _prefixId.prefix "Carport"
    /// <summary>
    ///   <para>rdfs:label : Check</para>
    ///   <para>rdfs:comment : A mandatory or optional technical inspection, e.g. the MOT, a vendor-specific certification of used cars, etc.</para>
    ///   <a href="http://purl.org/uco/ns#Check">uco:Check</a>
    /// </summary>
    let Check = _prefixId.prefix "Check"
    /// <summary>
    ///   <para>rdfs:label : Damage or Accident</para>
    ///   <para>rdfs:comment : A damage or accident is an event in which the vehicle is being damaged.</para>
    ///   <a href="http://purl.org/uco/ns#DamageOrAccident">uco:DamageOrAccident</a>
    /// </summary>
    let DamageOrAccident = _prefixId.prefix "DamageOrAccident"
    let DrivingSchool = _prefixId.prefix "DrivingSchool"
    let Garage = _prefixId.prefix "Garage"
    let IndependentDealer = _prefixId.prefix "IndependentDealer"
    /// <summary>
    ///   <para>rdfs:label : Modification or Maintenance</para>
    ///   <para>rdfs:comment : A modification or maintenance is an event in which a part of the vehicle is being replaced or removed, or a new part is being added.
    /// Typical examples are the replacement of the engine or the installation of a trailor-hitch.</para>
    ///   <a href="http://purl.org/uco/ns#ModificationOrMaintenance">uco:ModificationOrMaintenance</a>
    /// </summary>
    let ModificationOrMaintenance = _prefixId.prefix "ModificationOrMaintenance"
    let MoneyBack = _prefixId.prefix "MoneyBack"
    /// <summary>
    ///   <para>rdfs:label : Ownership Info</para>
    ///   <para>rdfs:comment : An ownership information node is a structured value representing information about the period of ownership of a vehicle by a person or organisation.</para>
    ///   <a href="http://purl.org/uco/ns#OwnershipInfo">uco:OwnershipInfo</a>
    /// </summary>
    let OwnershipInfo = _prefixId.prefix "OwnershipInfo"
    /// <summary>
    ///   <para>rdfs:label : Parking Type</para>
    ///   <para>rdfs:comment : A type of parking for a vehicle, e.g. in a garage, on the street (open-sky), or in a carport. You can use DBpedia URIs for additional types.</para>
    ///   <a href="http://purl.org/uco/ns#ParkingType">uco:ParkingType</a>
    /// </summary>
    let ParkingType = _prefixId.prefix "ParkingType"
    let Private = _prefixId.prefix "Private"
    /// <summary>
    ///   <para>rdfs:label : Property Value</para>
    ///   <para>rdfs:comment : A property-value is a structured value for representing a feature of a vehicle in a semi-formal way.</para>
    ///   <a href="http://purl.org/uco/ns#PropertyValue">uco:PropertyValue</a>
    /// </summary>
    let PropertyValue = _prefixId.prefix "PropertyValue"
    let Rental = _prefixId.prefix "Rental"
    /// <summary>
    ///   <para>rdfs:label : Species</para>
    ///   <para>rdfs:comment : A species, typically a pet, for indicating the type of animals that were regularly transported in the vehicle.
    ///
    /// If possible, use DBPedia URIs, e.g. http://dbpedia.org/resource/Dog.</para>
    ///   <a href="http://purl.org/uco/ns#Species">uco:Species</a>
    /// </summary>
    let Species = _prefixId.prefix "Species"
    let Street = _prefixId.prefix "Street"
    let Taxi = _prefixId.prefix "Taxi"
    /// <summary>
    ///   <para>rdfs:label : Usage Type</para>
    ///   <para>rdfs:comment : A type of usage of a vehicle, e.g. rental, taxi, driving school, commuting. It is best to either use one of the predefined individuals or DBpedia URIs whenever possible.</para>
    ///   <a href="http://purl.org/uco/ns#UsageType">uco:UsageType</a>
    /// </summary>
    let UsageType = _prefixId.prefix "UsageType"
    /// <summary>
    ///   <para>rdfs:label : airbag deployment (0..1)</para>
    ///   <para>rdfs:comment : This property indicates whether at least one of the airbags of the vehicle has been deployed in the respective accident (when attached to uco:DamageOrAccident) or ever (when directly applied to a vso:Vehicle).</para>
    ///   <a href="http://purl.org/uco/ns#airbagDeployment">uco:airbagDeployment</a>
    /// </summary>
    let airbagDeployment = _prefixId.prefix "airbagDeployment"
    /// <summary>
    ///   <para>rdfs:label : carried out by (0..1)</para>
    ///   <para>rdfs:comment : The business or type of business that carried out the check, repair, maintenance, or modification</para>
    ///   <a href="http://purl.org/uco/ns#carriedOutBy">uco:carriedOutBy</a>
    /// </summary>
    let carriedOutBy = _prefixId.prefix "carriedOutBy"
    /// <summary>
    ///   <para>rdfs:label : contains (0..*)</para>
    ///   <para>rdfs:comment : A naive part-whole relation that allows providing more granular uco:OwnershipInfo data for a part of the duration of the ownership</para>
    ///   <a href="http://purl.org/uco/ns#contains">uco:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : country of origin (0..1)</para>
    ///   <para>rdfs:comment : The country or geo-political region in which the vehicle was initially sold officially, indicated as the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2) for regions or ISO 3166-2, which breaks down the countries from ISO 3166-1 into administrative subdivisions.</para>
    ///   <a href="http://purl.org/uco/ns#countryOfOrigin">uco:countryOfOrigin</a>
    /// </summary>
    let countryOfOrigin = _prefixId.prefix "countryOfOrigin"
    /// <summary>
    ///   <para>rdfs:label : country of registration (0..1)</para>
    ///   <para>rdfs:comment : The country or geo-political region in which the vehicle is currently registered, indicated as the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2) for regions or ISO 3166-2, which breaks down the countries from ISO 3166-1 into administrative subdivisions.</para>
    ///   <a href="http://purl.org/uco/ns#countryOfRegistration">uco:countryOfRegistration</a>
    /// </summary>
    let countryOfRegistration = _prefixId.prefix "countryOfRegistration"
    /// <summary>
    ///   <para>rdfs:label : currentLocation (0..1)</para>
    ///   <para>rdfs:comment : The current location of the vehicle, i.e. where the car could be tested. For indicating alternative locations to which the seller is willing to bring the car, use gr:availableAtOrFrom attached to the gr:Offering, since those are aspects of the offer, not of the vehicle.</para>
    ///   <a href="http://purl.org/uco/ns#currentLocation">uco:currentLocation</a>
    /// </summary>
    let currentLocation = _prefixId.prefix "currentLocation"
    /// <summary>
    ///   <para>rdfs:label : currentOwner (0..1)</para>
    ///   <para>rdfs:comment : This property points to the current owner of the vehicle.</para>
    ///   <a href="http://purl.org/uco/ns#currentOwner">uco:currentOwner</a>
    /// </summary>
    let currentOwner = _prefixId.prefix "currentOwner"
    /// <summary>
    ///   <para>rdfs:label : driver (0..*)</para>
    ///   <para>rdfs:comment : This property points to the driver or drivers that were regularly driving the vehicle during the respective period of time (when attached to uco:OwnershipInfo) or in total (when attached directly to a vso:Vehicle).</para>
    ///   <a href="http://purl.org/uco/ns#driver">uco:driver</a>
    /// </summary>
    let driver = _prefixId.prefix "driver"
    /// <summary>
    ///   <para>rdfs:label : eventInformation (0..*)</para>
    ///   <para>rdfs:comment : This property points to events related to the vehicle, like accidents and damages or major modifications or maintenance.</para>
    ///   <a href="http://purl.org/uco/ns#eventInformation">uco:eventInformation</a>
    /// </summary>
    let eventInformation = _prefixId.prefix "eventInformation"
    /// <summary>
    ///   <para>rdfs:label : feature (0..*)</para>
    ///   <para>rdfs:comment : This property points to vehicle features in a semi-structured property-value form.</para>
    ///   <a href="http://purl.org/uco/ns#feature">uco:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:label : from (0..1)</para>
    ///   <para>rdfs:comment : This property indicates the beginning of the period of ownership represented by this uco:OwnershipInfo node.</para>
    ///   <a href="http://purl.org/uco/ns#from">uco:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    /// <summary>
    ///   <para>rdfs:label : hasOwnershipInfo (0..*)</para>
    ///   <para>rdfs:comment : This property points to information about the current and previous owners of the vehicle.</para>
    ///   <a href="http://purl.org/uco/ns#hasOwnershipInfo">uco:hasOwnershipInfo</a>
    /// </summary>
    let hasOwnershipInfo = _prefixId.prefix "hasOwnershipInfo"
    /// <summary>
    ///   <para>rdfs:label : indication of odometer rollback (0..1)</para>
    ///   <para>rdfs:comment : This property indicates whether it is likely or known that the odometer of the vehicle does not properly reflect the total mileage of the vehicle, e.g. because the odometer has been replaced, reset, or tampered with </para>
    ///   <a href="http://purl.org/uco/ns#indicationOfOdometerRollback">uco:indicationOfOdometerRollback</a>
    /// </summary>
    let indicationOfOdometerRollback = _prefixId.prefix "indicationOfOdometerRollback"
    /// <summary>
    ///   <para>rdfs:label : inspected (0..*)</para>
    ///   <para>rdfs:comment : This property points to inspections and certifications that the vehicle has undergone.</para>
    ///   <a href="http://purl.org/uco/ns#inspected">uco:inspected</a>
    /// </summary>
    let inspected = _prefixId.prefix "inspected"
    /// <summary>
    ///   <para>rdfs:label : license plate (0..*)</para>
    ///   <para>rdfs:comment : The license plate string(s) assigned to the vehicle during the period of ownership</para>
    ///   <a href="http://purl.org/uco/ns#licensePlate">uco:licensePlate</a>
    /// </summary>
    let licensePlate = _prefixId.prefix "licensePlate"
    /// <summary>
    ///   <para>rdfs:label : listPrice (0..1)</para>
    ///   <para>rdfs:comment : The original list price of the new car at the time of production</para>
    ///   <a href="http://purl.org/uco/ns#listPrice">uco:listPrice</a>
    /// </summary>
    let listPrice = _prefixId.prefix "listPrice"
    /// <summary>
    ///   <para>rdfs:label : main location (0..*)</para>
    ///   <para>rdfs:comment : The main location(s) of the vehicle during the period of ownership</para>
    ///   <a href="http://purl.org/uco/ns#mainLocation">uco:mainLocation</a>
    /// </summary>
    let mainLocation = _prefixId.prefix "mainLocation"
    /// <summary>
    ///   <para>rdfs:label : mileage (0..1)</para>
    ///   <para>rdfs:comment : The mileage of the vehicle at the event, e.g. at the accident, maintenance, check, or modification.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles</para>
    ///   <a href="http://purl.org/uco/ns#mileage">uco:mileage</a>
    /// </summary>
    let mileage = _prefixId.prefix "mileage"
    /// <summary>
    ///   <para>rdfs:label : mileage end (0..1)</para>
    ///   <para>rdfs:comment : The mileage of the vehicle at the end of the period of ownership.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles</para>
    ///   <a href="http://purl.org/uco/ns#mileageEnd">uco:mileageEnd</a>
    /// </summary>
    let mileageEnd = _prefixId.prefix "mileageEnd"
    /// <summary>
    ///   <para>rdfs:label : mileage initial (0..1)</para>
    ///   <para>rdfs:comment : The mileage of the vehicle at the beginning of the period of ownership.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles</para>
    ///   <a href="http://purl.org/uco/ns#mileageInitial">uco:mileageInitial</a>
    /// </summary>
    let mileageInitial = _prefixId.prefix "mileageInitial"
    /// <summary>
    ///   <para>rdfs:label : total loss (0..1)</para>
    ///   <para>rdfs:comment : This property indicates whether the accident leading to the damage was a not-at-fault accident from the perspective of the owner.</para>
    ///   <a href="http://purl.org/uco/ns#notAtFaultAccident">uco:notAtFaultAccident</a>
    /// </summary>
    let notAtFaultAccident = _prefixId.prefix "notAtFaultAccident"
    /// <summary>
    ///   <para>rdfs:label : number of drivers (0..1)</para>
    ///   <para>rdfs:comment : The number of people who were/are regularly driving the vehicle in the respective period of time (when attached to uco:OwnershipInfo) or in total (when directly applied to a vso:Vehicle)</para>
    ///   <a href="http://purl.org/uco/ns#numberOfDrivers">uco:numberOfDrivers</a>
    /// </summary>
    let numberOfDrivers = _prefixId.prefix "numberOfDrivers"
    /// <summary>
    ///   <para>rdfs:label : number of owners (0..1)</para>
    ///   <para>rdfs:comment : The total number of people or organizations who owned the vehicle, including the current owner.
    ///
    /// Note that this value can be higher (but not lower) than the number of uco:OwnershipInfo nodes, since those records may be incomplete.</para>
    ///   <a href="http://purl.org/uco/ns#numberOfOwners">uco:numberOfOwners</a>
    /// </summary>
    let numberOfOwners = _prefixId.prefix "numberOfOwners"
    /// <summary>
    ///   <para>rdfs:label : original parts only (0..1)</para>
    ///   <para>rdfs:comment : This indicates whether the parts used for repairing a damage, for a maintenance task, or a modification were all original.</para>
    ///   <a href="http://purl.org/uco/ns#originalPartsOnly">uco:originalPartsOnly</a>
    /// </summary>
    let originalPartsOnly = _prefixId.prefix "originalPartsOnly"
    /// <summary>
    ///   <para>rdfs:label : owner (0..*)</para>
    ///   <para>rdfs:comment : This property points to the owner of the vehicle for the respective period of time, as indicated by the uco:OwnershipInfo node.</para>
    ///   <a href="http://purl.org/uco/ns#owner">uco:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:label : parking (0..*)</para>
    ///   <para>rdfs:comment : The main type(s) of parking that have been used for the vehicle during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly)</para>
    ///   <a href="http://purl.org/uco/ns#parking">uco:parking</a>
    /// </summary>
    let parking = _prefixId.prefix "parking"
    /// <summary>
    ///   <para>rdfs:label : part added (0..1)</para>
    ///   <para>rdfs:comment : A textual description of the part or parts added in the modification (e.g. tuning) or maintenance task</para>
    ///   <a href="http://purl.org/uco/ns#partAdded">uco:partAdded</a>
    /// </summary>
    let partAdded = _prefixId.prefix "partAdded"
    /// <summary>
    ///   <para>rdfs:label : part removed (0..1)</para>
    ///   <para>rdfs:comment : A textual description of the part or parts removed in the modification (e.g. tuning) or maintenance task</para>
    ///   <a href="http://purl.org/uco/ns#partRemoved">uco:partRemoved</a>
    /// </summary>
    let partRemoved = _prefixId.prefix "partRemoved"
    /// <summary>
    ///   <para>rdfs:label : part replaced (0..1)</para>
    ///   <para>rdfs:comment : A textual description of the part or parts replaced in the modification (e.g. tuning) or maintenance (e.g. new engine) task</para>
    ///   <a href="http://purl.org/uco/ns#partReplaced">uco:partReplaced</a>
    /// </summary>
    let partReplaced = _prefixId.prefix "partReplaced"
    /// <summary>
    ///   <para>rdfs:label : pets (0..*)</para>
    ///   <para>rdfs:comment : The type(s) of animals that have been transported in the vehicle during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly).
    ///
    /// If possible, use DBPedia URIs, e.g. http://dbpedia.org/resource/Dog.</para>
    ///   <a href="http://purl.org/uco/ns#pets">uco:pets</a>
    /// </summary>
    let pets = _prefixId.prefix "pets"
    /// <summary>
    ///   <para>rdfs:label : property ID (0..1)</para>
    ///   <para>rdfs:comment : A global identifier, e.g. a URI, a prefixed string, or any other identifier that can be used to refer to a standardized property type</para>
    ///   <a href="http://purl.org/uco/ns#propertyID">uco:propertyID</a>
    /// </summary>
    let propertyID = _prefixId.prefix "propertyID"
    /// <summary>
    ///   <para>rdfs:label : property name (0..1)</para>
    ///   <para>rdfs:comment : The name of the property</para>
    ///   <a href="http://purl.org/uco/ns#propertyName">uco:propertyName</a>
    /// </summary>
    let propertyName = _prefixId.prefix "propertyName"
    /// <summary>
    ///   <para>rdfs:label : property value (0..1)</para>
    ///   <para>rdfs:comment : The value of of the property</para>
    ///   <a href="http://purl.org/uco/ns#propertyValue">uco:propertyValue</a>
    /// </summary>
    let propertyValue = _prefixId.prefix "propertyValue"
    /// <summary>
    ///   <para>rdfs:label : repaired (0..1)</para>
    ///   <para>rdfs:comment : This indicates whether damages resulting from a certain uco:DamageOrAccident (when attached to this type) or all damages (when directly attached to a vso:Vehicle) have been properly repaired. Do not use this propery on a vso:Vehicle if it never had a damage.</para>
    ///   <a href="http://purl.org/uco/ns#repaired">uco:repaired</a>
    /// </summary>
    let repaired = _prefixId.prefix "repaired"
    /// <summary>
    ///   <para>rdfs:label : smoking (0..1)</para>
    ///   <para>rdfs:comment : This property indicates whether it has been smoked inside the car in the respective period of time (when attached to uco:OwnershipInfo) or ever (when directly applied to a vso:Vehicle).</para>
    ///   <a href="http://purl.org/uco/ns#smoking">uco:smoking</a>
    /// </summary>
    let smoking = _prefixId.prefix "smoking"
    /// <summary>
    ///   <para>rdfs:label : structural damage (0..1)</para>
    ///   <para>rdfs:comment : This property indicates whether the vehicle has suffered from structural damage in the respective accident (when attached to uco:DamageOrAccident) or ever (when directly applied to a vso:Vehicle).</para>
    ///   <a href="http://purl.org/uco/ns#structuralDamage">uco:structuralDamage</a>
    /// </summary>
    let structuralDamage = _prefixId.prefix "structuralDamage"
    /// <summary>
    ///   <para>rdfs:label : to (0..1)</para>
    ///   <para>rdfs:comment : This property indicates the end of the period of ownership represented by this uco:OwnershipInfo node.</para>
    ///   <a href="http://purl.org/uco/ns#to">uco:to</a>
    /// </summary>
    let to_ = _prefixId.prefix "to"
    /// <summary>
    ///   <para>rdfs:label : total loss (0..1)</para>
    ///   <para>rdfs:comment : This property indicates whether the vehicle is considered a total loss as the result of a damage in the respective accident (when attached to uco:DamageOrAccident) or in general (when directly applied to a vso:Vehicle).</para>
    ///   <a href="http://purl.org/uco/ns#totalLoss">uco:totalLoss</a>
    /// </summary>
    let totalLoss = _prefixId.prefix "totalLoss"
    /// <summary>
    ///   <para>rdfs:label : unit code (0..1)</para>
    ///   <para>rdfs:comment : A UN/CEFACT Common Code for indicating the unit of measurement of the value, if available</para>
    ///   <a href="http://purl.org/uco/ns#unitCode">uco:unitCode</a>
    /// </summary>
    let unitCode = _prefixId.prefix "unitCode"
    /// <summary>
    ///   <para>rdfs:label : unit text (0..1)</para>
    ///   <para>rdfs:comment : A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for uco:unitCode.</para>
    ///   <a href="http://purl.org/uco/ns#unitText">uco:unitText</a>
    /// </summary>
    let unitText = _prefixId.prefix "unitText"
    /// <summary>
    ///   <para>rdfs:label : usage (0..*)</para>
    ///   <para>rdfs:comment : The type(s) of usage during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly)</para>
    ///   <a href="http://purl.org/uco/ns#usage">uco:usage</a>
    /// </summary>
    let usage = _prefixId.prefix "usage"
    /// <summary>
    ///   <para>rdfs:label : valid from (0..1)</para>
    ///   <para>rdfs:comment : This property indicates the beginning of the validity of the inspection represented by the uco:Check node. This is typically the day of the inspection.</para>
    ///   <a href="http://purl.org/uco/ns#validFrom">uco:validFrom</a>
    /// </summary>
    let validFrom = _prefixId.prefix "validFrom"
    /// <summary>
    ///   <para>rdfs:label : valid to (0..1)</para>
    ///   <para>rdfs:comment : This property indicates the end of the validity of the inspection represented by the uco:Check node. This is typically the day of the inspection plus one (UK MOT) or two years (e.g. German TÜV).</para>
    ///   <a href="http://purl.org/uco/ns#validThrough">uco:validThrough</a>
    /// </summary>
    let validThrough = _prefixId.prefix "validThrough"
    /// <summary>
    ///   <para>rdfs:label : valuation (0..*)</para>
    ///   <para>rdfs:comment : The market price assessment gained by the respective valuation. Use gr:name to indicate the name of the valuation service.</para>
    ///   <a href="http://purl.org/uco/ns#valuation">uco:valuation</a>
    /// </summary>
    let valuation = _prefixId.prefix "valuation"
