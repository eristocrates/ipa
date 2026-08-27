namespace http.purl.org.uco.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uco =
    let _namespace_iri = Namespace_Iri uco |> NamespaceIRI
    /// <summary>
    ///   <para>uco:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"UCO: The The Used Cars Ontology
    ///
    /// A Web vocabulary for describing aspects of used cars for e-commerce.
    ///
    /// Vocabulary:    http://purl.org/uco/ns#
    /// Namespace:     http://purl.org/uco/ns#
    ///
    /// The vocabulary is designed to be used in combination with
    /// (1) GoodRelations, a standard vocabulary for the commercial aspects of offers for sale, rental, repair, or disposal; and
    /// (2) the Vehicle Sales Ontology, a standard vocabulary for cars and other vehicles.
    ///
    /// See http://purl.org/goodrelations/ and http://purl.org/vso/ns for more information."</para>
    /// labels<para>"Used Cars Ontology"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#">http://purl.org/uco/ns#</seealso>
    let _prefix_iri = Prefixed_Name(uco, "") |> PrefixedName
    /// <summary>
    ///   <para>uco:AuthorizedDealer</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessEntityType</para>
    ///   <para>"An authorized dealer of the manufacturer of the respective vehicle"</para>
    /// labels<para>"Authorized Dealer (gr:BusinessEntityType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#AuthorizedDealer">http://purl.org/uco/ns#AuthorizedDealer</seealso>
    let AuthorizedDealer = Prefixed_Name(uco, "AuthorizedDealer") |> PrefixedName
    /// <summary>
    ///   <para>uco:Business</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:UsageType</para>
    ///   <para>"The usage of a vehicle for general business purposes, i.e. excluding usages like as a taxi, rental car, or driving instructions."</para>
    /// labels<para>"Business (uco:UsageType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Business">http://purl.org/uco/ns#Business</seealso>
    let Business = Prefixed_Name(uco, "Business") |> PrefixedName
    /// <summary>
    ///   <para>uco:CarSharing</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:UsageType</para>
    ///   <para>"The usage of a vehicle for car sharing networks"</para>
    /// labels<para>"Car Sharing (uco:UsageType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#CarSharing">http://purl.org/uco/ns#CarSharing</seealso>
    let CarSharing = Prefixed_Name(uco, "CarSharing") |> PrefixedName
    /// <summary>
    ///   <para>uco:Carport</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:ParkingType</para>
    ///   <para>"The parking of a vehicle under a protective roof, e.g. in a carport"</para>
    /// labels<para>"Carport (uco:ParkingType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Carport">http://purl.org/uco/ns#Carport</seealso>
    let Carport = Prefixed_Name(uco, "Carport") |> PrefixedName
    /// <summary>
    ///   <para>uco:Check</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mandatory or optional technical inspection, e.g. the MOT, a vendor-specific certification of used cars, etc."</para>
    /// labels<para>"Check"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Check">http://purl.org/uco/ns#Check</seealso>
    let Check = Prefixed_Name(uco, "Check") |> PrefixedName
    /// <summary>
    ///   <para>uco:DamageOrAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A damage or accident is an event in which the vehicle is being damaged."</para>
    /// labels<para>"Damage or Accident"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#DamageOrAccident">http://purl.org/uco/ns#DamageOrAccident</seealso>
    let DamageOrAccident = Prefixed_Name(uco, "DamageOrAccident") |> PrefixedName
    /// <summary>
    ///   <para>uco:DrivingSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:UsageType</para>
    ///   <para>"The usage of a vehicle for commercial driver's education"</para>
    /// labels<para>"Driving School (uco:UsageType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#DrivingSchool">http://purl.org/uco/ns#DrivingSchool</seealso>
    let DrivingSchool = Prefixed_Name(uco, "DrivingSchool") |> PrefixedName
    /// <summary>
    ///   <para>uco:Garage</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:ParkingType</para>
    ///   <para>"The parking of a vehicle in a closed garage"</para>
    /// labels<para>"Garage (uco:ParkingType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Garage">http://purl.org/uco/ns#Garage</seealso>
    let Garage = Prefixed_Name(uco, "Garage") |> PrefixedName
    /// <summary>
    ///   <para>uco:IndependentDealer</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessEntityType</para>
    ///   <para>"An independent dealer"</para>
    /// labels<para>"Independent Dealer (gr:BusinessEntityType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#IndependentDealer">http://purl.org/uco/ns#IndependentDealer</seealso>
    let IndependentDealer = Prefixed_Name(uco, "IndependentDealer") |> PrefixedName

    /// <summary>
    ///   <para>uco:ModificationOrMaintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A modification or maintenance is an event in which a part of the vehicle is being replaced or removed, or a new part is being added.
    /// Typical examples are the replacement of the engine or the installation of a trailor-hitch."</para>
    /// labels<para>"Modification or Maintenance"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#ModificationOrMaintenance">http://purl.org/uco/ns#ModificationOrMaintenance</seealso>
    let ModificationOrMaintenance =
        Prefixed_Name(uco, "ModificationOrMaintenance") |> PrefixedName

    /// <summary>
    ///   <para>uco:MoneyBack</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:WarrantyScope</para>
    ///   <para>"The promise to take back the vehicle without any specific reason for a full refund within a certain amount of time"</para>
    /// labels<para>"Money-back Guarantee (gr:WarrantyScope)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#MoneyBack">http://purl.org/uco/ns#MoneyBack</seealso>
    let MoneyBack = Prefixed_Name(uco, "MoneyBack") |> PrefixedName
    /// <summary>
    ///   <para>uco:OwnershipInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ownership information node is a structured value representing information about the period of ownership of a vehicle by a person or organisation."</para>
    /// labels<para>"Ownership Info"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#OwnershipInfo">http://purl.org/uco/ns#OwnershipInfo</seealso>
    let OwnershipInfo = Prefixed_Name(uco, "OwnershipInfo") |> PrefixedName
    /// <summary>
    ///   <para>uco:ParkingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of parking for a vehicle, e.g. in a garage, on the street (open-sky), or in a carport. You can use DBpedia URIs for additional types."</para>
    /// labels<para>"Parking Type"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#ParkingType">http://purl.org/uco/ns#ParkingType</seealso>
    let ParkingType = Prefixed_Name(uco, "ParkingType") |> PrefixedName
    /// <summary>
    ///   <para>uco:Private</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:UsageType</para>
    ///   <para>"The usage of a vehicle soleley for private purposes"</para>
    /// labels<para>"Private (uco:UsageType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Private">http://purl.org/uco/ns#Private</seealso>
    let Private = Prefixed_Name(uco, "Private") |> PrefixedName
    /// <summary>
    ///   <para>uco:PropertyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A property-value is a structured value for representing a feature of a vehicle in a semi-formal way."</para>
    /// labels<para>"Property Value"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#PropertyValue">http://purl.org/uco/ns#PropertyValue</seealso>
    let PropertyValue = Prefixed_Name(uco, "PropertyValue") |> PrefixedName
    /// <summary>
    ///   <para>uco:Rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:UsageType</para>
    ///   <para>"The usage of a vehicle as a rental car"</para>
    /// labels<para>"Rental (uco:UsageType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Rental">http://purl.org/uco/ns#Rental</seealso>
    let Rental = Prefixed_Name(uco, "Rental") |> PrefixedName
    /// <summary>
    ///   <para>uco:Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A species, typically a pet, for indicating the type of animals that were regularly transported in the vehicle.
    ///
    /// If possible, use DBPedia URIs, e.g. http://dbpedia.org/resource/Dog."</para>
    /// labels<para>"Species"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Species">http://purl.org/uco/ns#Species</seealso>
    let Species = Prefixed_Name(uco, "Species") |> PrefixedName
    /// <summary>
    ///   <para>uco:Street</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:ParkingType</para>
    ///   <para>"The parking of a vehicle on a public or private street"</para>
    /// labels<para>"Street (uco:ParkingType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Street">http://purl.org/uco/ns#Street</seealso>
    let Street = Prefixed_Name(uco, "Street") |> PrefixedName
    /// <summary>
    ///   <para>uco:Taxi</para>
    /// </summary>
    /// <remarks>
    ///   <para>uco:UsageType</para>
    ///   <para>"The usage of a vehicle as a taxi"</para>
    /// labels<para>"Taxi (uco:UsageType)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#Taxi">http://purl.org/uco/ns#Taxi</seealso>
    let Taxi = Prefixed_Name(uco, "Taxi") |> PrefixedName
    /// <summary>
    ///   <para>uco:UsageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of usage of a vehicle, e.g. rental, taxi, driving school, commuting. It is best to either use one of the predefined individuals or DBpedia URIs whenever possible."</para>
    /// labels<para>"Usage Type"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#UsageType">http://purl.org/uco/ns#UsageType</seealso>
    let UsageType = Prefixed_Name(uco, "UsageType") |> PrefixedName
    /// <summary>
    ///   <para>uco:airbagDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property indicates whether at least one of the airbags of the vehicle has been deployed in the respective accident (when attached to uco:DamageOrAccident) or ever (when directly applied to a vso:Vehicle)."</para>
    /// labels<para>"airbag deployment (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#airbagDeployment">http://purl.org/uco/ns#airbagDeployment</seealso>
    let airbagDeployment = Prefixed_Name(uco, "airbagDeployment") |> PrefixedName
    /// <summary>
    ///   <para>uco:carriedOutBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The business or type of business that carried out the check, repair, maintenance, or modification"</para>
    /// labels<para>"carried out by (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#carriedOutBy">http://purl.org/uco/ns#carriedOutBy</seealso>
    let carriedOutBy = Prefixed_Name(uco, "carriedOutBy") |> PrefixedName
    /// <summary>
    ///   <para>uco:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A naive part-whole relation that allows providing more granular uco:OwnershipInfo data for a part of the duration of the ownership"</para>
    /// labels<para>"contains (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#contains">http://purl.org/uco/ns#contains</seealso>
    let contains = Prefixed_Name(uco, "contains") |> PrefixedName
    /// <summary>
    ///   <para>uco:countryOfOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The country or geo-political region in which the vehicle was initially sold officially, indicated as the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2) for regions or ISO 3166-2, which breaks down the countries from ISO 3166-1 into administrative subdivisions."</para>
    /// labels<para>"country of origin (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#countryOfOrigin">http://purl.org/uco/ns#countryOfOrigin</seealso>
    let countryOfOrigin = Prefixed_Name(uco, "countryOfOrigin") |> PrefixedName

    /// <summary>
    ///   <para>uco:countryOfRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The country or geo-political region in which the vehicle is currently registered, indicated as the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2) for regions or ISO 3166-2, which breaks down the countries from ISO 3166-1 into administrative subdivisions."</para>
    /// labels<para>"country of registration (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#countryOfRegistration">http://purl.org/uco/ns#countryOfRegistration</seealso>
    let countryOfRegistration =
        Prefixed_Name(uco, "countryOfRegistration") |> PrefixedName

    /// <summary>
    ///   <para>uco:currentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The current location of the vehicle, i.e. where the car could be tested. For indicating alternative locations to which the seller is willing to bring the car, use gr:availableAtOrFrom attached to the gr:Offering, since those are aspects of the offer, not of the vehicle."</para>
    /// labels<para>"currentLocation (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#currentLocation">http://purl.org/uco/ns#currentLocation</seealso>
    let currentLocation = Prefixed_Name(uco, "currentLocation") |> PrefixedName
    /// <summary>
    ///   <para>uco:currentOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property points to the current owner of the vehicle."</para>
    /// labels<para>"currentOwner (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#currentOwner">http://purl.org/uco/ns#currentOwner</seealso>
    let currentOwner = Prefixed_Name(uco, "currentOwner") |> PrefixedName
    /// <summary>
    ///   <para>uco:driver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property points to the driver or drivers that were regularly driving the vehicle during the respective period of time (when attached to uco:OwnershipInfo) or in total (when attached directly to a vso:Vehicle)."</para>
    /// labels<para>"driver (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#driver">http://purl.org/uco/ns#driver</seealso>
    let driver = Prefixed_Name(uco, "driver") |> PrefixedName
    /// <summary>
    ///   <para>uco:eventInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property points to events related to the vehicle, like accidents and damages or major modifications or maintenance."</para>
    /// labels<para>"eventInformation (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#eventInformation">http://purl.org/uco/ns#eventInformation</seealso>
    let eventInformation = Prefixed_Name(uco, "eventInformation") |> PrefixedName
    /// <summary>
    ///   <para>uco:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property points to vehicle features in a semi-structured property-value form."</para>
    /// labels<para>"feature (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#feature">http://purl.org/uco/ns#feature</seealso>
    let feature = Prefixed_Name(uco, "feature") |> PrefixedName
    /// <summary>
    ///   <para>uco:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates the beginning of the period of ownership represented by this uco:OwnershipInfo node."</para>
    /// labels<para>"from (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#from">http://purl.org/uco/ns#from</seealso>
    let from = Prefixed_Name(uco, "from") |> PrefixedName
    /// <summary>
    ///   <para>uco:hasOwnershipInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property points to information about the current and previous owners of the vehicle."</para>
    /// labels<para>"hasOwnershipInfo (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#hasOwnershipInfo">http://purl.org/uco/ns#hasOwnershipInfo</seealso>
    let hasOwnershipInfo = Prefixed_Name(uco, "hasOwnershipInfo") |> PrefixedName

    /// <summary>
    ///   <para>uco:indicationOfOdometerRollback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates whether it is likely or known that the odometer of the vehicle does not properly reflect the total mileage of the vehicle, e.g. because the odometer has been replaced, reset, or tampered with "</para>
    /// labels<para>"indication of odometer rollback (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#indicationOfOdometerRollback">http://purl.org/uco/ns#indicationOfOdometerRollback</seealso>
    let indicationOfOdometerRollback =
        Prefixed_Name(uco, "indicationOfOdometerRollback") |> PrefixedName

    /// <summary>
    ///   <para>uco:inspected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property points to inspections and certifications that the vehicle has undergone."</para>
    /// labels<para>"inspected (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#inspected">http://purl.org/uco/ns#inspected</seealso>
    let inspected = Prefixed_Name(uco, "inspected") |> PrefixedName
    /// <summary>
    ///   <para>uco:licensePlate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The license plate string(s) assigned to the vehicle during the period of ownership"</para>
    /// labels<para>"license plate (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#licensePlate">http://purl.org/uco/ns#licensePlate</seealso>
    let licensePlate = Prefixed_Name(uco, "licensePlate") |> PrefixedName
    /// <summary>
    ///   <para>uco:listPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The original list price of the new car at the time of production"</para>
    /// labels<para>"listPrice (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#listPrice">http://purl.org/uco/ns#listPrice</seealso>
    let listPrice = Prefixed_Name(uco, "listPrice") |> PrefixedName
    /// <summary>
    ///   <para>uco:mainLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The main location(s) of the vehicle during the period of ownership"</para>
    /// labels<para>"main location (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#mainLocation">http://purl.org/uco/ns#mainLocation</seealso>
    let mainLocation = Prefixed_Name(uco, "mainLocation") |> PrefixedName
    /// <summary>
    ///   <para>uco:mileage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The mileage of the vehicle at the event, e.g. at the accident, maintenance, check, or modification.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles"</para>
    /// labels<para>"mileage (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#mileage">http://purl.org/uco/ns#mileage</seealso>
    let mileage = Prefixed_Name(uco, "mileage") |> PrefixedName
    /// <summary>
    ///   <para>uco:mileageEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The mileage of the vehicle at the end of the period of ownership.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles"</para>
    /// labels<para>"mileage end (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#mileageEnd">http://purl.org/uco/ns#mileageEnd</seealso>
    let mileageEnd = Prefixed_Name(uco, "mileageEnd") |> PrefixedName
    /// <summary>
    ///   <para>uco:mileageInitial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The mileage of the vehicle at the beginning of the period of ownership.
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles"</para>
    /// labels<para>"mileage initial (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#mileageInitial">http://purl.org/uco/ns#mileageInitial</seealso>
    let mileageInitial = Prefixed_Name(uco, "mileageInitial") |> PrefixedName
    /// <summary>
    ///   <para>uco:notAtFaultAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates whether the accident leading to the damage was a not-at-fault accident from the perspective of the owner."</para>
    /// labels<para>"total loss (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#notAtFaultAccident">http://purl.org/uco/ns#notAtFaultAccident</seealso>
    let notAtFaultAccident = Prefixed_Name(uco, "notAtFaultAccident") |> PrefixedName
    /// <summary>
    ///   <para>uco:numberOfDrivers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The number of people who were/are regularly driving the vehicle in the respective period of time (when attached to uco:OwnershipInfo) or in total (when directly applied to a vso:Vehicle)"</para>
    /// labels<para>"number of drivers (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#numberOfDrivers">http://purl.org/uco/ns#numberOfDrivers</seealso>
    let numberOfDrivers = Prefixed_Name(uco, "numberOfDrivers") |> PrefixedName
    /// <summary>
    ///   <para>uco:numberOfOwners</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The total number of people or organizations who owned the vehicle, including the current owner.
    ///
    /// Note that this value can be higher (but not lower) than the number of uco:OwnershipInfo nodes, since those records may be incomplete."</para>
    /// labels<para>"number of owners (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#numberOfOwners">http://purl.org/uco/ns#numberOfOwners</seealso>
    let numberOfOwners = Prefixed_Name(uco, "numberOfOwners") |> PrefixedName
    /// <summary>
    ///   <para>uco:originalPartsOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This indicates whether the parts used for repairing a damage, for a maintenance task, or a modification were all original."</para>
    /// labels<para>"original parts only (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#originalPartsOnly">http://purl.org/uco/ns#originalPartsOnly</seealso>
    let originalPartsOnly = Prefixed_Name(uco, "originalPartsOnly") |> PrefixedName
    /// <summary>
    ///   <para>uco:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property points to the owner of the vehicle for the respective period of time, as indicated by the uco:OwnershipInfo node."</para>
    /// labels<para>"owner (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#owner">http://purl.org/uco/ns#owner</seealso>
    let owner = Prefixed_Name(uco, "owner") |> PrefixedName
    /// <summary>
    ///   <para>uco:parking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The main type(s) of parking that have been used for the vehicle during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly)"</para>
    /// labels<para>"parking (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#parking">http://purl.org/uco/ns#parking</seealso>
    let parking = Prefixed_Name(uco, "parking") |> PrefixedName
    /// <summary>
    ///   <para>uco:partAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A textual description of the part or parts added in the modification (e.g. tuning) or maintenance task"</para>
    /// labels<para>"part added (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#partAdded">http://purl.org/uco/ns#partAdded</seealso>
    let partAdded = Prefixed_Name(uco, "partAdded") |> PrefixedName
    /// <summary>
    ///   <para>uco:partRemoved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A textual description of the part or parts removed in the modification (e.g. tuning) or maintenance task"</para>
    /// labels<para>"part removed (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#partRemoved">http://purl.org/uco/ns#partRemoved</seealso>
    let partRemoved = Prefixed_Name(uco, "partRemoved") |> PrefixedName
    /// <summary>
    ///   <para>uco:partReplaced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A textual description of the part or parts replaced in the modification (e.g. tuning) or maintenance (e.g. new engine) task"</para>
    /// labels<para>"part replaced (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#partReplaced">http://purl.org/uco/ns#partReplaced</seealso>
    let partReplaced = Prefixed_Name(uco, "partReplaced") |> PrefixedName
    /// <summary>
    ///   <para>uco:pets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type(s) of animals that have been transported in the vehicle during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly).
    ///
    /// If possible, use DBPedia URIs, e.g. http://dbpedia.org/resource/Dog."</para>
    /// labels<para>"pets (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#pets">http://purl.org/uco/ns#pets</seealso>
    let pets = Prefixed_Name(uco, "pets") |> PrefixedName
    /// <summary>
    ///   <para>uco:propertyID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A global identifier, e.g. a URI, a prefixed string, or any other identifier that can be used to refer to a standardized property type"</para>
    /// labels<para>"property ID (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#propertyID">http://purl.org/uco/ns#propertyID</seealso>
    let propertyID = Prefixed_Name(uco, "propertyID") |> PrefixedName
    /// <summary>
    ///   <para>uco:propertyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of the property"</para>
    /// labels<para>"property name (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#propertyName">http://purl.org/uco/ns#propertyName</seealso>
    let propertyName = Prefixed_Name(uco, "propertyName") |> PrefixedName
    /// <summary>
    ///   <para>uco:propertyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The value of of the property"</para>
    /// labels<para>"property value (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#propertyValue">http://purl.org/uco/ns#propertyValue</seealso>
    let propertyValue = Prefixed_Name(uco, "propertyValue") |> PrefixedName
    /// <summary>
    ///   <para>uco:repaired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This indicates whether damages resulting from a certain uco:DamageOrAccident (when attached to this type) or all damages (when directly attached to a vso:Vehicle) have been properly repaired. Do not use this propery on a vso:Vehicle if it never had a damage."</para>
    /// labels<para>"repaired (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#repaired">http://purl.org/uco/ns#repaired</seealso>
    let repaired = Prefixed_Name(uco, "repaired") |> PrefixedName
    /// <summary>
    ///   <para>uco:smoking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property indicates whether it has been smoked inside the car in the respective period of time (when attached to uco:OwnershipInfo) or ever (when directly applied to a vso:Vehicle)."</para>
    /// labels<para>"smoking (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#smoking">http://purl.org/uco/ns#smoking</seealso>
    let smoking = Prefixed_Name(uco, "smoking") |> PrefixedName
    /// <summary>
    ///   <para>uco:structuralDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates whether the vehicle has suffered from structural damage in the respective accident (when attached to uco:DamageOrAccident) or ever (when directly applied to a vso:Vehicle)."</para>
    /// labels<para>"structural damage (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#structuralDamage">http://purl.org/uco/ns#structuralDamage</seealso>
    let structuralDamage = Prefixed_Name(uco, "structuralDamage") |> PrefixedName
    /// <summary>
    ///   <para>uco:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates the end of the period of ownership represented by this uco:OwnershipInfo node."</para>
    /// labels<para>"to (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#to">http://purl.org/uco/ns#to</seealso>
    let to_ = Prefixed_Name(uco, "to") |> PrefixedName
    /// <summary>
    ///   <para>uco:totalLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates whether the vehicle is considered a total loss as the result of a damage in the respective accident (when attached to uco:DamageOrAccident) or in general (when directly applied to a vso:Vehicle)."</para>
    /// labels<para>"total loss (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#totalLoss">http://purl.org/uco/ns#totalLoss</seealso>
    let totalLoss = Prefixed_Name(uco, "totalLoss") |> PrefixedName
    /// <summary>
    ///   <para>uco:unitCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A UN/CEFACT Common Code for indicating the unit of measurement of the value, if available"</para>
    /// labels<para>"unit code (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#unitCode">http://purl.org/uco/ns#unitCode</seealso>
    let unitCode = Prefixed_Name(uco, "unitCode") |> PrefixedName
    /// <summary>
    ///   <para>uco:unitText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for uco:unitCode."</para>
    /// labels<para>"unit text (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#unitText">http://purl.org/uco/ns#unitText</seealso>
    let unitText = Prefixed_Name(uco, "unitText") |> PrefixedName
    /// <summary>
    ///   <para>uco:usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type(s) of usage during the period of ownership (if attached to uco:OwnershipInfo) or in general (if attached to the vso:Vehicle directly)"</para>
    /// labels<para>"usage (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#usage">http://purl.org/uco/ns#usage</seealso>
    let usage = Prefixed_Name(uco, "usage") |> PrefixedName
    /// <summary>
    ///   <para>uco:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates the beginning of the validity of the inspection represented by the uco:Check node. This is typically the day of the inspection."</para>
    /// labels<para>"valid from (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#validFrom">http://purl.org/uco/ns#validFrom</seealso>
    let validFrom = Prefixed_Name(uco, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>uco:validThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates the end of the validity of the inspection represented by the uco:Check node. This is typically the day of the inspection plus one (UK MOT) or two years (e.g. German TÜV)."</para>
    /// labels<para>"valid to (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#validThrough">http://purl.org/uco/ns#validThrough</seealso>
    let validThrough = Prefixed_Name(uco, "validThrough") |> PrefixedName
    /// <summary>
    ///   <para>uco:valuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The market price assessment gained by the respective valuation. Use gr:name to indicate the name of the valuation service."</para>
    /// labels<para>"valuation (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/uco/ns#valuation">http://purl.org/uco/ns#valuation</seealso>
    let valuation = Prefixed_Name(uco, "valuation") |> PrefixedName
