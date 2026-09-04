#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``of`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://owlrep.eu01.aws.af.cm/fridge#" "of"

    /// <summary>
    ///   <para>rdfs:label : Energy Observation^^xsd:string</para>
    ///   <para>rdfs:comment : An energy observation is the main class of the measurment system. The observation connects to the sensing device, the measurement property, the observed appliance, the measurment result, and the time of measurement.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#EnergyObservation">of:EnergyObservation</a>
    /// </summary>
    let EnergyObservation = _prefixId.prefix "EnergyObservation"
    /// <summary>
    ///   <para>rdfs:label : Energy Sensing Device^^xsd:string</para>
    ///   <para>rdfs:comment : An energy sensing device is sensing device for sensing energy consumption data^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#EnergySensingDevice">of:EnergySensingDevice</a>
    /// </summary>
    let EnergySensingDevice = _prefixId.prefix "EnergySensingDevice"
    /// <summary>
    ///   <para>rdfs:label : Open Fridge Household^^xsd:string</para>
    ///   <para>rdfs:comment : Information about the household of the open fridge user^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeHousehold">of:OpenFridgeHousehold</a>
    /// </summary>
    let OpenFridgeHousehold = _prefixId.prefix "OpenFridgeHousehold"
    /// <summary>
    ///   <para>rdfs:label : Open Fridge User^^xsd:string</para>
    ///   <para>rdfs:comment : The main user of the system, which lives in a household with a energy consumption measuring system.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeUser">of:OpenFridgeUser</a>
    /// </summary>
    let OpenFridgeUser = _prefixId.prefix "OpenFridgeUser"
    /// <summary>
    ///   <para>rdfs:label : Power^^xsd:string</para>
    ///   <para>rdfs:comment : Power is the observed measurment property^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#Power">of:Power</a>
    /// </summary>
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:comment : The date when an product or service was bought or brought into service.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#dateBringIntoService">of:dateBringIntoService</a>
    /// </summary>
    let dateBringIntoService = _prefixId.prefix "dateBringIntoService"
    /// <summary>
    ///   <para>rdfs:comment : The appliance ID of an energy sensing device^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#energySensingDeviceID">of:energySensingDeviceID</a>
    /// </summary>
    let energySensingDeviceID = _prefixId.prefix "energySensingDeviceID"
    /// <summary>
    ///   <para>rdfs:comment : Open fridge user has an open fridge household^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#hasHousehold">of:hasHousehold</a>
    /// </summary>
    let hasHousehold = _prefixId.prefix "hasHousehold"
    /// <summary>
    ///   <para>rdfs:comment : Number of people that live in the household^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#numberOfPeople">of:numberOfPeople</a>
    /// </summary>
    let numberOfPeople = _prefixId.prefix "numberOfPeople"
    /// <summary>
    ///   <para>rdfs:comment : Property of a fridge in the time period of observation.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#observationProperty">of:observationProperty</a>
    /// </summary>
    let observationProperty = _prefixId.prefix "observationProperty"

    /// <summary>
    ///   <para>rdfs:comment : The average filling level of a fridge in the time period of observation.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyFillingLevel">of:observationPropertyFillingLevel</a>
    /// </summary>
    let observationPropertyFillingLevel =
        _prefixId.prefix "observationPropertyFillingLevel"

    /// <summary>
    ///   <para>rdfs:comment : The number of door openings of a fridge in the time period of observation.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyNumberOfOpening">of:observationPropertyNumberOfOpening</a>
    /// </summary>
    let observationPropertyNumberOfOpening =
        _prefixId.prefix "observationPropertyNumberOfOpening"

    /// <summary>
    ///   <para>rdfs:comment : The average temperature of the room where the refrigerator stands observed in a time period.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyRoomTemperature">of:observationPropertyRoomTemperature</a>
    /// </summary>
    let observationPropertyRoomTemperature =
        _prefixId.prefix "observationPropertyRoomTemperature"

    /// <summary>
    ///   <para>rdfs:comment : The average temperature of a fridge in the time period of observation.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyTemperature">of:observationPropertyTemperature</a>
    /// </summary>
    let observationPropertyTemperature =
        _prefixId.prefix "observationPropertyTemperature"

    /// <summary>
    ///   <para>rdfs:comment : An open user owns a refrigerator.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#ownsFridge">of:ownsFridge</a>
    /// </summary>
    let ownsFridge = _prefixId.prefix "ownsFridge"
    /// <summary>
    ///   <para>rdfs:comment : Is the refrigerator located to the southwards or not.^^xsd:string</para>
    ///   <a href="http://owlrep.eu01.aws.af.cm/fridge#standSouth">of:standSouth</a>
    /// </summary>
    let standSouth = _prefixId.prefix "standSouth"
