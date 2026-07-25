namespace http.owlrep.eu01.aws.af.cm.fridge.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module of_ =
    let _namespace_iri = Namespace_Iri of_ |> NamespaceIRI

    /// <summary>
    ///   <para>of:observationPropertyTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The average temperature of a fridge in the time period of observation.</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyTemperature">http://owlrep.eu01.aws.af.cm/fridge#observationPropertyTemperature</seealso>
    let observationPropertyTemperature =
        Prefixed_Name(of_, "observationPropertyTemperature") |> PrefixedName

    /// <summary>
    ///   <para>of:EnergySensingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An energy sensing device is sensing device for sensing energy consumption data</para>
    /// labels<para>Energy Sensing Device</para></remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#EnergySensingDevice">http://owlrep.eu01.aws.af.cm/fridge#EnergySensingDevice</seealso>
    let EnergySensingDevice = Prefixed_Name(of_, "EnergySensingDevice") |> PrefixedName
    /// <summary>
    ///   <para>of:EnergyObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An energy observation is the main class of the measurment system. The observation connects to the sensing device, the measurement property, the observed appliance, the measurment result, and the time of measurement.</para>
    /// labels<para>Energy Observation</para></remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#EnergyObservation">http://owlrep.eu01.aws.af.cm/fridge#EnergyObservation</seealso>
    let EnergyObservation = Prefixed_Name(of_, "EnergyObservation") |> PrefixedName
    /// <summary>
    ///   <para>of:Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Power is the observed measurment property</para>
    /// labels<para>Power</para></remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#Power">http://owlrep.eu01.aws.af.cm/fridge#Power</seealso>
    let Power = Prefixed_Name(of_, "Power") |> PrefixedName
    /// <summary>
    ///   <para>of:OpenFridgeHousehold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about the household of the open fridge user</para>
    /// labels<para>Open Fridge Household</para></remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeHousehold">http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeHousehold</seealso>
    let OpenFridgeHousehold = Prefixed_Name(of_, "OpenFridgeHousehold") |> PrefixedName
    /// <summary>
    ///   <para>of:OpenFridgeUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The main user of the system, which lives in a household with a energy consumption measuring system.</para>
    /// labels<para>Open Fridge User</para></remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeUser">http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeUser</seealso>
    let OpenFridgeUser = Prefixed_Name(of_, "OpenFridgeUser") |> PrefixedName
    /// <summary>
    ///   <para>of:hasHousehold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Open fridge user has an open fridge household</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#hasHousehold">http://owlrep.eu01.aws.af.cm/fridge#hasHousehold</seealso>
    let hasHousehold = Prefixed_Name(of_, "hasHousehold") |> PrefixedName

    /// <summary>
    ///   <para>of:dateBringIntoService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date when an product or service was bought or brought into service.</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#dateBringIntoService">http://owlrep.eu01.aws.af.cm/fridge#dateBringIntoService</seealso>
    let dateBringIntoService =
        Prefixed_Name(of_, "dateBringIntoService") |> PrefixedName

    /// <summary>
    ///   <para>of:energySensingDeviceID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The appliance ID of an energy sensing device</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#energySensingDeviceID">http://owlrep.eu01.aws.af.cm/fridge#energySensingDeviceID</seealso>
    let energySensingDeviceID =
        Prefixed_Name(of_, "energySensingDeviceID") |> PrefixedName

    /// <summary>
    ///   <para>of:numberOfPeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of people that live in the household</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#numberOfPeople">http://owlrep.eu01.aws.af.cm/fridge#numberOfPeople</seealso>
    let numberOfPeople = Prefixed_Name(of_, "numberOfPeople") |> PrefixedName

    /// <summary>
    ///   <para>of:observationPropertyFillingLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The average filling level of a fridge in the time period of observation.</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyFillingLevel">http://owlrep.eu01.aws.af.cm/fridge#observationPropertyFillingLevel</seealso>
    let observationPropertyFillingLevel =
        Prefixed_Name(of_, "observationPropertyFillingLevel") |> PrefixedName

    /// <summary>
    ///   <para>of:observationPropertyRoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The average temperature of the room where the refrigerator stands observed in a time period.</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyRoomTemperature">http://owlrep.eu01.aws.af.cm/fridge#observationPropertyRoomTemperature</seealso>
    let observationPropertyRoomTemperature =
        Prefixed_Name(of_, "observationPropertyRoomTemperature") |> PrefixedName

    /// <summary>
    ///   <para>of:ownsFridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An open user owns a refrigerator.</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#ownsFridge">http://owlrep.eu01.aws.af.cm/fridge#ownsFridge</seealso>
    let ownsFridge = Prefixed_Name(of_, "ownsFridge") |> PrefixedName
    /// <summary>
    ///   <para>of:observationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property of a fridge in the time period of observation.</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#observationProperty">http://owlrep.eu01.aws.af.cm/fridge#observationProperty</seealso>
    let observationProperty = Prefixed_Name(of_, "observationProperty") |> PrefixedName

    /// <summary>
    ///   <para>of:observationPropertyNumberOfOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of door openings of a fridge in the time period of observation.</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyNumberOfOpening">http://owlrep.eu01.aws.af.cm/fridge#observationPropertyNumberOfOpening</seealso>
    let observationPropertyNumberOfOpening =
        Prefixed_Name(of_, "observationPropertyNumberOfOpening") |> PrefixedName

    /// <summary>
    ///   <para>of:standSouth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Is the refrigerator located to the southwards or not.</para>
    /// </remarks>
    /// <seealso href="http://owlrep.eu01.aws.af.cm/fridge#standSouth">http://owlrep.eu01.aws.af.cm/fridge#standSouth</seealso>
    let standSouth = Prefixed_Name(of_, "standSouth") |> PrefixedName
