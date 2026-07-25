namespace https.w3id.org.dco.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3dco =
    let _namespace_iri = Namespace_Iri w3dco |> NamespaceIRI

    /// <summary>
    ///   <para>w3dco:BuildingRenovationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building renovation date</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingRenovationDate">https://w3id.org/dco#BuildingRenovationDate</seealso>
    let BuildingRenovationDate =
        Prefixed_Name(w3dco, "BuildingRenovationDate") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:DeviceMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Device metadata</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceMetadata">https://w3id.org/dco#DeviceMetadata</seealso>
    let DeviceMetadata = Prefixed_Name(w3dco, "DeviceMetadata") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ReactivePowerImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reactive power Import</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReactivePowerImport">https://w3id.org/dco#ReactivePowerImport</seealso>
    let ReactivePowerImport =
        Prefixed_Name(w3dco, "ReactivePowerImport") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ReturnTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Return temperature sensor</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReturnTemperatureSensor">https://w3id.org/dco#ReturnTemperatureSensor</seealso>
    let ReturnTemperatureSensor =
        Prefixed_Name(w3dco, "ReturnTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:DeviceMinimumEnabledTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Device minimum enabled time</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceMinimumEnabledTime">https://w3id.org/dco#DeviceMinimumEnabledTime</seealso>
    let DeviceMinimumEnabledTime =
        Prefixed_Name(w3dco, "DeviceMinimumEnabledTime") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:EnergyClamp1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy clamp 1</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyClamp1">https://w3id.org/dco#EnergyClamp1</seealso>
    let EnergyClamp1 = Prefixed_Name(w3dco, "EnergyClamp1") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:EnergyFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy flow</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyFlow">https://w3id.org/dco#EnergyFlow</seealso>
    let EnergyFlow = Prefixed_Name(w3dco, "EnergyFlow") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:EnergyQuadrant1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy quadrant 1</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyQuadrant1">https://w3id.org/dco#EnergyQuadrant1</seealso>
    let EnergyQuadrant1 = Prefixed_Name(w3dco, "EnergyQuadrant1") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ThermostaticValveActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Thermostatic valve actuator</para></remarks>
    /// <seealso href="https://w3id.org/dco#ThermostaticValveActuator">https://w3id.org/dco#ThermostaticValveActuator</seealso>
    let ThermostaticValveActuator =
        Prefixed_Name(w3dco, "ThermostaticValveActuator") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ValveActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Valve actuator</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveActuator">https://w3id.org/dco#ValveActuator</seealso>
    let ValveActuator = Prefixed_Name(w3dco, "ValveActuator") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ValveController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Valve controller</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveController">https://w3id.org/dco#ValveController</seealso>
    let ValveController = Prefixed_Name(w3dco, "ValveController") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ValveMinimumOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Valve minimum opening</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveMinimumOpening">https://w3id.org/dco#ValveMinimumOpening</seealso>
    let ValveMinimumOpening =
        Prefixed_Name(w3dco, "ValveMinimumOpening") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ValveMinimumTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Valve minimum temperature</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveMinimumTemperature">https://w3id.org/dco#ValveMinimumTemperature</seealso>
    let ValveMinimumTemperature =
        Prefixed_Name(w3dco, "ValveMinimumTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:Volt-ampereReactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Volt-ampere reactive</para></remarks>
    /// <seealso href="https://w3id.org/dco#Volt-ampereReactive">https://w3id.org/dco#Volt-ampereReactive</seealso>
    let Volt_ampereReactive =
        Prefixed_Name(w3dco, "Volt-ampereReactive") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:VoltageProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Voltage property</para></remarks>
    /// <seealso href="https://w3id.org/dco#VoltageProperty">https://w3id.org/dco#VoltageProperty</seealso>
    let VoltageProperty = Prefixed_Name(w3dco, "VoltageProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:VoltageClamp1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Voltage clamp 1</para></remarks>
    /// <seealso href="https://w3id.org/dco#VoltageClamp1">https://w3id.org/dco#VoltageClamp1</seealso>
    let VoltageClamp1 = Prefixed_Name(w3dco, "VoltageClamp1") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:VoltageClamp2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Voltage clamp 2</para></remarks>
    /// <seealso href="https://w3id.org/dco#VoltageClamp2">https://w3id.org/dco#VoltageClamp2</seealso>
    let VoltageClamp2 = Prefixed_Name(w3dco, "VoltageClamp2") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:TemperatureUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Temperature unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#TemperatureUnit">https://w3id.org/dco#TemperatureUnit</seealso>
    let TemperatureUnit = Prefixed_Name(w3dco, "TemperatureUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:DefineTemperatureSetpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Define temperature setpoint</para></remarks>
    /// <seealso href="https://w3id.org/dco#DefineTemperatureSetpoint">https://w3id.org/dco#DefineTemperatureSetpoint</seealso>
    let DefineTemperatureSetpoint =
        Prefixed_Name(w3dco, "DefineTemperatureSetpoint") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:DeviceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Device identifier</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceIdentifier">https://w3id.org/dco#DeviceIdentifier</seealso>
    let DeviceIdentifier = Prefixed_Name(w3dco, "DeviceIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Celsius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Celsius</para></remarks>
    /// <seealso href="https://w3id.org/dco#Celsius">https://w3id.org/dco#Celsius</seealso>
    let Celsius = Prefixed_Name(w3dco, "Celsius") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:DesiredValveOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Desired Valve opening</para></remarks>
    /// <seealso href="https://w3id.org/dco#DesiredValveOpening">https://w3id.org/dco#DesiredValveOpening</seealso>
    let DesiredValveOpening =
        Prefixed_Name(w3dco, "DesiredValveOpening") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ValveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Valve property</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveProperty">https://w3id.org/dco#ValveProperty</seealso>
    let ValveProperty = Prefixed_Name(w3dco, "ValveProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:PowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Power meter</para></remarks>
    /// <seealso href="https://w3id.org/dco#PowerMeter">https://w3id.org/dco#PowerMeter</seealso>
    let PowerMeter = Prefixed_Name(w3dco, "PowerMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:PowerUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Power unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#PowerUnit">https://w3id.org/dco#PowerUnit</seealso>
    let PowerUnit = Prefixed_Name(w3dco, "PowerUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ReactivePowerExport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reactive power export</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReactivePowerExport">https://w3id.org/dco#ReactivePowerExport</seealso>
    let ReactivePowerExport =
        Prefixed_Name(w3dco, "ReactivePowerExport") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:HeatingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heating service</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatingService">https://w3id.org/dco#HeatingService</seealso>
    let HeatingService = Prefixed_Name(w3dco, "HeatingService") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:HumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Humidity sensor</para></remarks>
    /// <seealso href="https://w3id.org/dco#HumiditySensor">https://w3id.org/dco#HumiditySensor</seealso>
    let HumiditySensor = Prefixed_Name(w3dco, "HumiditySensor") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ImportedEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Imported energy</para></remarks>
    /// <seealso href="https://w3id.org/dco#ImportedEnergy">https://w3id.org/dco#ImportedEnergy</seealso>
    let ImportedEnergy = Prefixed_Name(w3dco, "ImportedEnergy") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ImportedEnergyWithPricing2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Imported energy with pricing 2</para></remarks>
    /// <seealso href="https://w3id.org/dco#ImportedEnergyWithPricing2">https://w3id.org/dco#ImportedEnergyWithPricing2</seealso>
    let ImportedEnergyWithPricing2 =
        Prefixed_Name(w3dco, "ImportedEnergyWithPricing2") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:PartsPerNotationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Parts per notation unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#PartsPerNotationUnit">https://w3id.org/dco#PartsPerNotationUnit</seealso>
    let PartsPerNotationUnit =
        Prefixed_Name(w3dco, "PartsPerNotationUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ReactiveEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reactive energy</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReactiveEnergy">https://w3id.org/dco#ReactiveEnergy</seealso>
    let ReactiveEnergy = Prefixed_Name(w3dco, "ReactiveEnergy") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ReactivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reactive power</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReactivePower">https://w3id.org/dco#ReactivePower</seealso>
    let ReactivePower = Prefixed_Name(w3dco, "ReactivePower") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ResidentialBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Residential building</para></remarks>
    /// <seealso href="https://w3id.org/dco#ResidentialBuilding">https://w3id.org/dco#ResidentialBuilding</seealso>
    let ResidentialBuilding =
        Prefixed_Name(w3dco, "ResidentialBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:DeviceManifucturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Device Metadata</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceManifucturer">https://w3id.org/dco#DeviceManifucturer</seealso>
    let DeviceManifucturer = Prefixed_Name(w3dco, "DeviceManifucturer") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:DeviceSoftwareVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>DeviceSoftwareVersion</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceSoftwareVersion">https://w3id.org/dco#DeviceSoftwareVersion</seealso>
    let DeviceSoftwareVersion =
        Prefixed_Name(w3dco, "DeviceSoftwareVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ValvePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Valve position</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValvePosition">https://w3id.org/dco#ValvePosition</seealso>
    let ValvePosition = Prefixed_Name(w3dco, "ValvePosition") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Voltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Voltage</para></remarks>
    /// <seealso href="https://w3id.org/dco#Voltage">https://w3id.org/dco#Voltage</seealso>
    let Voltage = Prefixed_Name(w3dco, "Voltage") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:VoltageClamp3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Voltage clamp 3</para></remarks>
    /// <seealso href="https://w3id.org/dco#VoltageClamp3">https://w3id.org/dco#VoltageClamp3</seealso>
    let VoltageClamp3 = Prefixed_Name(w3dco, "VoltageClamp3") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:DeviceMaximumDisabledTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Device maximum disabled time</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceMaximumDisabledTime">https://w3id.org/dco#DeviceMaximumDisabledTime</seealso>
    let DeviceMaximumDisabledTime =
        Prefixed_Name(w3dco, "DeviceMaximumDisabledTime") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:Setpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Setpoint</para></remarks>
    /// <seealso href="https://w3id.org/dco#Setpoint">https://w3id.org/dco#Setpoint</seealso>
    let Setpoint = Prefixed_Name(w3dco, "Setpoint") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Site</para></remarks>
    /// <seealso href="https://w3id.org/dco#Site">https://w3id.org/dco#Site</seealso>
    let Site = Prefixed_Name(w3dco, "Site") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:SolarPanelsAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Solar panels appliance</para></remarks>
    /// <seealso href="https://w3id.org/dco#SolarPanelsAppliance">https://w3id.org/dco#SolarPanelsAppliance</seealso>
    let SolarPanelsAppliance =
        Prefixed_Name(w3dco, "SolarPanelsAppliance") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:StartState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Start state</para></remarks>
    /// <seealso href="https://w3id.org/dco#StartState">https://w3id.org/dco#StartState</seealso>
    let StartState = Prefixed_Name(w3dco, "StartState") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:StopState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Stop state</para></remarks>
    /// <seealso href="https://w3id.org/dco#StopState">https://w3id.org/dco#StopState</seealso>
    let StopState = Prefixed_Name(w3dco, "StopState") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:DeviceMaximumPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Device maximum power</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceMaximumPower">https://w3id.org/dco#DeviceMaximumPower</seealso>
    let DeviceMaximumPower = Prefixed_Name(w3dco, "DeviceMaximumPower") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:DeviceSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Device serial number</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceSerialNumber">https://w3id.org/dco#DeviceSerialNumber</seealso>
    let DeviceSerialNumber = Prefixed_Name(w3dco, "DeviceSerialNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:EVChargingAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>EV charging appliance</para></remarks>
    /// <seealso href="https://w3id.org/dco#EVChargingAppliance">https://w3id.org/dco#EVChargingAppliance</seealso>
    let EVChargingAppliance =
        Prefixed_Name(w3dco, "EVChargingAppliance") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:EnergyClamp2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy clamp 2</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyClamp2">https://w3id.org/dco#EnergyClamp2</seealso>
    let EnergyClamp2 = Prefixed_Name(w3dco, "EnergyClamp2") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:EnergyClamp3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy Clamp 3</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyClamp3">https://w3id.org/dco#EnergyClamp3</seealso>
    let EnergyClamp3 = Prefixed_Name(w3dco, "EnergyClamp3") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Meter</para></remarks>
    /// <seealso href="https://w3id.org/dco#Meter">https://w3id.org/dco#Meter</seealso>
    let Meter = Prefixed_Name(w3dco, "Meter") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:EnergyQuadrant2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy quadrant 2</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyQuadrant2">https://w3id.org/dco#EnergyQuadrant2</seealso>
    let EnergyQuadrant2 = Prefixed_Name(w3dco, "EnergyQuadrant2") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:EnergyQuadrant3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy quadrant 3</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyQuadrant3">https://w3id.org/dco#EnergyQuadrant3</seealso>
    let EnergyQuadrant3 = Prefixed_Name(w3dco, "EnergyQuadrant3") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:EnergyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyUnit">https://w3id.org/dco#EnergyUnit</seealso>
    let EnergyUnit = Prefixed_Name(w3dco, "EnergyUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ExportedEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Exported energy</para></remarks>
    /// <seealso href="https://w3id.org/dco#ExportedEnergy">https://w3id.org/dco#ExportedEnergy</seealso>
    let ExportedEnergy = Prefixed_Name(w3dco, "ExportedEnergy") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ExportedEnergyWithPricing2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Exported energy with pricing 2</para></remarks>
    /// <seealso href="https://w3id.org/dco#ExportedEnergyWithPricing2">https://w3id.org/dco#ExportedEnergyWithPricing2</seealso>
    let ExportedEnergyWithPricing2 =
        Prefixed_Name(w3dco, "ExportedEnergyWithPricing2") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Feature of interest</para></remarks>
    /// <seealso href="https://w3id.org/dco#FeatureOfInterest">https://w3id.org/dco#FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(w3dco, "FeatureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:SingleFamilyHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Single family house</para></remarks>
    /// <seealso href="https://w3id.org/dco#SingleFamilyHouse">https://w3id.org/dco#SingleFamilyHouse</seealso>
    let SingleFamilyHouse = Prefixed_Name(w3dco, "SingleFamilyHouse") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:SmartMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SmartMeter</para></remarks>
    /// <seealso href="https://w3id.org/dco#SmartMeter">https://w3id.org/dco#SmartMeter</seealso>
    let SmartMeter = Prefixed_Name(w3dco, "SmartMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:SquareMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Square meter</para></remarks>
    /// <seealso href="https://w3id.org/dco#SquareMeter">https://w3id.org/dco#SquareMeter</seealso>
    let SquareMeter = Prefixed_Name(w3dco, "SquareMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:StartStopState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Start Stop state</para></remarks>
    /// <seealso href="https://w3id.org/dco#StartStopState">https://w3id.org/dco#StartStopState</seealso>
    let StartStopState = Prefixed_Name(w3dco, "StartStopState") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:SupplyTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Supply temperature sensor</para></remarks>
    /// <seealso href="https://w3id.org/dco#SupplyTemperatureSensor">https://w3id.org/dco#SupplyTemperatureSensor</seealso>
    let SupplyTemperatureSensor =
        Prefixed_Name(w3dco, "SupplyTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:TemperatureSetpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Temperature setpoint</para></remarks>
    /// <seealso href="https://w3id.org/dco#TemperatureSetpoint">https://w3id.org/dco#TemperatureSetpoint</seealso>
    let TemperatureSetpoint =
        Prefixed_Name(w3dco, "TemperatureSetpoint") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:TertiaryBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tertiary building</para></remarks>
    /// <seealso href="https://w3id.org/dco#TertiaryBuilding">https://w3id.org/dco#TertiaryBuilding</seealso>
    let TertiaryBuilding = Prefixed_Name(w3dco, "TertiaryBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Thermostat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Thermostat</para></remarks>
    /// <seealso href="https://w3id.org/dco#Thermostat">https://w3id.org/dco#Thermostat</seealso>
    let Thermostat = Prefixed_Name(w3dco, "Thermostat") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ToggleAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Toggle action</para></remarks>
    /// <seealso href="https://w3id.org/dco#ToggleAction">https://w3id.org/dco#ToggleAction</seealso>
    let ToggleAction = Prefixed_Name(w3dco, "ToggleAction") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ValveMaximumOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Valve maximum opening</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveMaximumOpening">https://w3id.org/dco#ValveMaximumOpening</seealso>
    let ValveMaximumOpening =
        Prefixed_Name(w3dco, "ValveMaximumOpening") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ValveMaximumTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Valve maximum temperature</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveMaximumTemperature">https://w3id.org/dco#ValveMaximumTemperature</seealso>
    let ValveMaximumTemperature =
        Prefixed_Name(w3dco, "ValveMaximumTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:EnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy meter</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyMeter">https://w3id.org/dco#EnergyMeter</seealso>
    let EnergyMeter = Prefixed_Name(w3dco, "EnergyMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:TankTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tank temperature</para></remarks>
    /// <seealso href="https://w3id.org/dco#TankTemperature">https://w3id.org/dco#TankTemperature</seealso>
    let TankTemperature = Prefixed_Name(w3dco, "TankTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:TemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Temperature Sensor</para></remarks>
    /// <seealso href="https://w3id.org/dco#TemperatureSensor">https://w3id.org/dco#TemperatureSensor</seealso>
    let TemperatureSensor = Prefixed_Name(w3dco, "TemperatureSensor") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:EnergyQuadrant4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy quadrant 4</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyQuadrant4">https://w3id.org/dco#EnergyQuadrant4</seealso>
    let EnergyQuadrant4 = Prefixed_Name(w3dco, "EnergyQuadrant4") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ExportedEnergyWithPricing1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Exported energy with pricing 1</para></remarks>
    /// <seealso href="https://w3id.org/dco#ExportedEnergyWithPricing1">https://w3id.org/dco#ExportedEnergyWithPricing1</seealso>
    let ExportedEnergyWithPricing1 =
        Prefixed_Name(w3dco, "ExportedEnergyWithPricing1") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:FeatureProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Feature property</para></remarks>
    /// <seealso href="https://w3id.org/dco#FeatureProperty">https://w3id.org/dco#FeatureProperty</seealso>
    let FeatureProperty = Prefixed_Name(w3dco, "FeatureProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:FlexibilityService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Flexibility service</para></remarks>
    /// <seealso href="https://w3id.org/dco#FlexibilityService">https://w3id.org/dco#FlexibilityService</seealso>
    let FlexibilityService = Prefixed_Name(w3dco, "FlexibilityService") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:GasBoiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gas boiler</para></remarks>
    /// <seealso href="https://w3id.org/dco#GasBoiler">https://w3id.org/dco#GasBoiler</seealso>
    let GasBoiler = Prefixed_Name(w3dco, "GasBoiler") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>hasSpace</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasSpace">https://w3id.org/dco#hasSpace</seealso>
    let hasSpace = Prefixed_Name(w3dco, "hasSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:isActionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is action of</para></remarks>
    /// <seealso href="https://w3id.org/dco#isActionOf">https://w3id.org/dco#isActionOf</seealso>
    let isActionOf = Prefixed_Name(w3dco, "isActionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:isEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is event of</para></remarks>
    /// <seealso href="https://w3id.org/dco#isEventOf">https://w3id.org/dco#isEventOf</seealso>
    let isEventOf = Prefixed_Name(w3dco, "isEventOf") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:hasThingDescriptionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasThingDescriptionProperty</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasThingDescriptionProperty">https://w3id.org/dco#hasThingDescriptionProperty</seealso>
    let hasThingDescriptionProperty =
        Prefixed_Name(w3dco, "hasThingDescriptionProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:hasTotalSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasTotalSpace</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasTotalSpace">https://w3id.org/dco#hasTotalSpace</seealso>
    let hasTotalSpace = Prefixed_Name(w3dco, "hasTotalSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasZipCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasZipCode</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasZipCode">https://w3id.org/dco#hasZipCode</seealso>
    let hasZipCode = Prefixed_Name(w3dco, "hasZipCode") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Event</para></remarks>
    /// <seealso href="https://w3id.org/dco#Event">https://w3id.org/dco#Event</seealso>
    let Event = Prefixed_Name(w3dco, "Event") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:WaterProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Water property</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterProperty">https://w3id.org/dco#WaterProperty</seealso>
    let WaterProperty = Prefixed_Name(w3dco, "WaterProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:WaterTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Water temperature</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterTemperature">https://w3id.org/dco#WaterTemperature</seealso>
    let WaterTemperature = Prefixed_Name(w3dco, "WaterTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:WaterVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Water volume</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterVolume">https://w3id.org/dco#WaterVolume</seealso>
    let WaterVolume = Prefixed_Name(w3dco, "WaterVolume") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:WattHourBasedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Watt hour based unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#WattHourBasedUnit">https://w3id.org/dco#WattHourBasedUnit</seealso>
    let WattHourBasedUnit = Prefixed_Name(w3dco, "WattHourBasedUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Zone</para></remarks>
    /// <seealso href="https://w3id.org/dco#Zone">https://w3id.org/dco#Zone</seealso>
    let Zone = Prefixed_Name(w3dco, "Zone") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:consitsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>consitsOf</para></remarks>
    /// <seealso href="https://w3id.org/dco#consitsOf">https://w3id.org/dco#consitsOf</seealso>
    let consitsOf = Prefixed_Name(w3dco, "consitsOf") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:isApartmentOF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is apartment of</para></remarks>
    /// <seealso href="https://w3id.org/dco#isApartmentOF">https://w3id.org/dco#isApartmentOF</seealso>
    let isApartmentOF = Prefixed_Name(w3dco, "isApartmentOF") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasBuilding</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasBuilding">https://w3id.org/dco#hasBuilding</seealso>
    let hasBuilding = Prefixed_Name(w3dco, "hasBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:hasConstructionYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasConstructionYear</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasConstructionYear">https://w3id.org/dco#hasConstructionYear</seealso>
    let hasConstructionYear =
        Prefixed_Name(w3dco, "hasConstructionYear") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:isFloorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is floor of</para></remarks>
    /// <seealso href="https://w3id.org/dco#isFloorOf">https://w3id.org/dco#isFloorOf</seealso>
    let isFloorOf = Prefixed_Name(w3dco, "isFloorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasID</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasID">https://w3id.org/dco#hasID</seealso>
    let hasID = Prefixed_Name(w3dco, "hasID") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:hasNumberOfInhabitants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasNumberOfInhabitants</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasNumberOfInhabitants">https://w3id.org/dco#hasNumberOfInhabitants</seealso>
    let hasNumberOfInhabitants =
        Prefixed_Name(w3dco, "hasNumberOfInhabitants") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:hasRenovationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasRenovationDate</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasRenovationDate">https://w3id.org/dco#hasRenovationDate</seealso>
    let hasRenovationDate = Prefixed_Name(w3dco, "hasRenovationDate") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:WaterFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Water flow</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterFlow">https://w3id.org/dco#WaterFlow</seealso>
    let WaterFlow = Prefixed_Name(w3dco, "WaterFlow") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:WaterFlowMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Water flow meter</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterFlowMeter">https://w3id.org/dco#WaterFlowMeter</seealso>
    let WaterFlowMeter = Prefixed_Name(w3dco, "WaterFlowMeter") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:WaterTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Water temperature sensor</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterTemperatureSensor">https://w3id.org/dco#WaterTemperatureSensor</seealso>
    let WaterTemperatureSensor =
        Prefixed_Name(w3dco, "WaterTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:Watt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Watt</para></remarks>
    /// <seealso href="https://w3id.org/dco#Watt">https://w3id.org/dco#Watt</seealso>
    let Watt = Prefixed_Name(w3dco, "Watt") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:WoTThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>WoT Thing</para></remarks>
    /// <seealso href="https://w3id.org/dco#WoTThing">https://w3id.org/dco#WoTThing</seealso>
    let WoTThing = Prefixed_Name(w3dco, "WoTThing") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:buildingZipCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>building zip code</para></remarks>
    /// <seealso href="https://w3id.org/dco#buildingZipCode">https://w3id.org/dco#buildingZipCode</seealso>
    let buildingZipCode = Prefixed_Name(w3dco, "buildingZipCode") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:containsDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contains device</para></remarks>
    /// <seealso href="https://w3id.org/dco#containsDevice">https://w3id.org/dco#containsDevice</seealso>
    let containsDevice = Prefixed_Name(w3dco, "containsDevice") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasAddress</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasAddress">https://w3id.org/dco#hasAddress</seealso>
    let hasAddress = Prefixed_Name(w3dco, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:isLocatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is located at</para></remarks>
    /// <seealso href="https://w3id.org/dco#isLocatedAt">https://w3id.org/dco#isLocatedAt</seealso>
    let isLocatedAt = Prefixed_Name(w3dco, "isLocatedAt") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasApartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasApartment</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasApartment">https://w3id.org/dco#hasApartment</seealso>
    let hasApartment = Prefixed_Name(w3dco, "hasApartment") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasCity</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasCity">https://w3id.org/dco#hasCity</seealso>
    let hasCity = Prefixed_Name(w3dco, "hasCity") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasFloor</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasFloor">https://w3id.org/dco#hasFloor</seealso>
    let hasFloor = Prefixed_Name(w3dco, "hasFloor") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>hasName</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasName">https://w3id.org/dco#hasName</seealso>
    let hasName = Prefixed_Name(w3dco, "hasName") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:hasThingDescriptionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasThingDescriptionAction</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasThingDescriptionAction">https://w3id.org/dco#hasThingDescriptionAction</seealso>
    let hasThingDescriptionAction =
        Prefixed_Name(w3dco, "hasThingDescriptionAction") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:hasThingDescriptionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasThingDescriptionEvent</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasThingDescriptionEvent">https://w3id.org/dco#hasThingDescriptionEvent</seealso>
    let hasThingDescriptionEvent =
        Prefixed_Name(w3dco, "hasThingDescriptionEvent") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is property of</para></remarks>
    /// <seealso href="https://w3id.org/dco#isPropertyOf">https://w3id.org/dco#isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(w3dco, "isPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:isMeasuredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isMeasuredIn</para></remarks>
    /// <seealso href="https://w3id.org/dco#isMeasuredIn">https://w3id.org/dco#isMeasuredIn</seealso>
    let isMeasuredIn = Prefixed_Name(w3dco, "isMeasuredIn") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:makesMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>makes measurement</para></remarks>
    /// <seealso href="https://w3id.org/dco#makesMeasurement">https://w3id.org/dco#makesMeasurement</seealso>
    let makesMeasurement = Prefixed_Name(w3dco, "makesMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:measurementMadeBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>measurement made by</para></remarks>
    /// <seealso href="https://w3id.org/dco#measurementMadeBy">https://w3id.org/dco#measurementMadeBy</seealso>
    let measurementMadeBy = Prefixed_Name(w3dco, "measurementMadeBy") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Floor</para></remarks>
    /// <seealso href="https://w3id.org/dco#Floor">https://w3id.org/dco#Floor</seealso>
    let Floor = Prefixed_Name(w3dco, "Floor") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:GasBoilerActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gas boiler actuator</para></remarks>
    /// <seealso href="https://w3id.org/dco#GasBoilerActuator">https://w3id.org/dco#GasBoilerActuator</seealso>
    let GasBoilerActuator = Prefixed_Name(w3dco, "GasBoilerActuator") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Gateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gateway</para></remarks>
    /// <seealso href="https://w3id.org/dco#Gateway">https://w3id.org/dco#Gateway</seealso>
    let Gateway = Prefixed_Name(w3dco, "Gateway") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:GetValveOpeningPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Get valve opening percentage</para></remarks>
    /// <seealso href="https://w3id.org/dco#GetValveOpeningPercentage">https://w3id.org/dco#GetValveOpeningPercentage</seealso>
    let GetValveOpeningPercentage =
        Prefixed_Name(w3dco, "GetValveOpeningPercentage") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:isUnitOfMeasurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is unit of measurement of</para></remarks>
    /// <seealso href="https://w3id.org/dco#isUnitOfMeasurementOf">https://w3id.org/dco#isUnitOfMeasurementOf</seealso>
    let isUnitOfMeasurementOf =
        Prefixed_Name(w3dco, "isUnitOfMeasurementOf") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:kilowatt-hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>kilowatt-hour</para></remarks>
    /// <seealso href="https://w3id.org/dco#kilowatt-hour">https://w3id.org/dco#kilowatt-hour</seealso>
    let kilowatt_hour = Prefixed_Name(w3dco, "kilowatt-hour") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:offersService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>offers service</para></remarks>
    /// <seealso href="https://w3id.org/dco#offersService">https://w3id.org/dco#offersService</seealso>
    let offersService = Prefixed_Name(w3dco, "offersService") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:serviceOfferedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>service offered by</para></remarks>
    /// <seealso href="https://w3id.org/dco#serviceOfferedBy">https://w3id.org/dco#serviceOfferedBy</seealso>
    let serviceOfferedBy = Prefixed_Name(w3dco, "serviceOfferedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:GasMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gas meter</para></remarks>
    /// <seealso href="https://w3id.org/dco#GasMeter">https://w3id.org/dco#GasMeter</seealso>
    let GasMeter = Prefixed_Name(w3dco, "GasMeter") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:GetTemperatureSetpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Get temperature setpoint</para></remarks>
    /// <seealso href="https://w3id.org/dco#GetTemperatureSetpoint">https://w3id.org/dco#GetTemperatureSetpoint</seealso>
    let GetTemperatureSetpoint =
        Prefixed_Name(w3dco, "GetTemperatureSetpoint") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:HeatPumpAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heat pump appliance</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatPumpAppliance">https://w3id.org/dco#HeatPumpAppliance</seealso>
    let HeatPumpAppliance = Prefixed_Name(w3dco, "HeatPumpAppliance") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:HeaterMaximalPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heater maximal power</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeaterMaximalPower">https://w3id.org/dco#HeaterMaximalPower</seealso>
    let HeaterMaximalPower = Prefixed_Name(w3dco, "HeaterMaximalPower") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:HeatingActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heating actuator</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatingActuator">https://w3id.org/dco#HeatingActuator</seealso>
    let HeatingActuator = Prefixed_Name(w3dco, "HeatingActuator") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:HotWaterProductionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hot water production service</para></remarks>
    /// <seealso href="https://w3id.org/dco#HotWaterProductionService">https://w3id.org/dco#HotWaterProductionService</seealso>
    let HotWaterProductionService =
        Prefixed_Name(w3dco, "HotWaterProductionService") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ImportedEnergyWithPricing1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Imported energy with pricing 1</para></remarks>
    /// <seealso href="https://w3id.org/dco#ImportedEnergyWithPricing1">https://w3id.org/dco#ImportedEnergyWithPricing1</seealso>
    let ImportedEnergyWithPricing1 =
        Prefixed_Name(w3dco, "ImportedEnergyWithPricing1") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:IndustrialBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Industrial building</para></remarks>
    /// <seealso href="https://w3id.org/dco#IndustrialBuilding">https://w3id.org/dco#IndustrialBuilding</seealso>
    let IndustrialBuilding = Prefixed_Name(w3dco, "IndustrialBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:IntelTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Intel temperature</para></remarks>
    /// <seealso href="https://w3id.org/dco#IntelTemperature">https://w3id.org/dco#IntelTemperature</seealso>
    let IntelTemperature = Prefixed_Name(w3dco, "IntelTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ThingDescriptionModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Thing description model</para></remarks>
    /// <seealso href="https://w3id.org/dco#ThingDescriptionModel">https://w3id.org/dco#ThingDescriptionModel</seealso>
    let ThingDescriptionModel =
        Prefixed_Name(w3dco, "ThingDescriptionModel") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:Kitchen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kitchen</para></remarks>
    /// <seealso href="https://w3id.org/dco#Kitchen">https://w3id.org/dco#Kitchen</seealso>
    let Kitchen = Prefixed_Name(w3dco, "Kitchen") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:LivingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Living room</para></remarks>
    /// <seealso href="https://w3id.org/dco#LivingRoom">https://w3id.org/dco#LivingRoom</seealso>
    let LivingRoom = Prefixed_Name(w3dco, "LivingRoom") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:MeasureTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Measure time stamp</para></remarks>
    /// <seealso href="https://w3id.org/dco#MeasureTimeStamp">https://w3id.org/dco#MeasureTimeStamp</seealso>
    let MeasureTimeStamp = Prefixed_Name(w3dco, "MeasureTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:MeasuredValveOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Measured valve opening</para></remarks>
    /// <seealso href="https://w3id.org/dco#MeasuredValveOpening">https://w3id.org/dco#MeasuredValveOpening</seealso>
    let MeasuredValveOpening =
        Prefixed_Name(w3dco, "MeasuredValveOpening") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:HeatMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heat meter</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatMeter">https://w3id.org/dco#HeatMeter</seealso>
    let HeatMeter = Prefixed_Name(w3dco, "HeatMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:watt-hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>watt-hour</para></remarks>
    /// <seealso href="https://w3id.org/dco#watt-hour">https://w3id.org/dco#watt-hour</seealso>
    let watt_hour = Prefixed_Name(w3dco, "watt-hour") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:HeatPumpRelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heat pump relay</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatPumpRelay">https://w3id.org/dco#HeatPumpRelay</seealso>
    let HeatPumpRelay = Prefixed_Name(w3dco, "HeatPumpRelay") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:HeaterMinimumPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heater minimum power</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeaterMinimumPower">https://w3id.org/dco#HeaterMinimumPower</seealso>
    let HeaterMinimumPower = Prefixed_Name(w3dco, "HeaterMinimumPower") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:HouseholdType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Household type</para></remarks>
    /// <seealso href="https://w3id.org/dco#HouseholdType">https://w3id.org/dco#HouseholdType</seealso>
    let HouseholdType = Prefixed_Name(w3dco, "HouseholdType") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:MagnetSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Magnet sensor</para></remarks>
    /// <seealso href="https://w3id.org/dco#MagnetSensor">https://w3id.org/dco#MagnetSensor</seealso>
    let MagnetSensor = Prefixed_Name(w3dco, "MagnetSensor") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:OffAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Off action</para></remarks>
    /// <seealso href="https://w3id.org/dco#OffAction">https://w3id.org/dco#OffAction</seealso>
    let OffAction = Prefixed_Name(w3dco, "OffAction") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:OnState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>On state</para></remarks>
    /// <seealso href="https://w3id.org/dco#OnState">https://w3id.org/dco#OnState</seealso>
    let OnState = Prefixed_Name(w3dco, "OnState") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Lobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lobby</para></remarks>
    /// <seealso href="https://w3id.org/dco#Lobby">https://w3id.org/dco#Lobby</seealso>
    let Lobby = Prefixed_Name(w3dco, "Lobby") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:MultiFamilyHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Multi family house</para></remarks>
    /// <seealso href="https://w3id.org/dco#MultiFamilyHouse">https://w3id.org/dco#MultiFamilyHouse</seealso>
    let MultiFamilyHouse = Prefixed_Name(w3dco, "MultiFamilyHouse") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:OffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Off state</para></remarks>
    /// <seealso href="https://w3id.org/dco#OffState">https://w3id.org/dco#OffState</seealso>
    let OffState = Prefixed_Name(w3dco, "OffState") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:OnOffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>On Off state</para></remarks>
    /// <seealso href="https://w3id.org/dco#OnOffState">https://w3id.org/dco#OnOffState</seealso>
    let OnOffState = Prefixed_Name(w3dco, "OnOffState") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:OnAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>On action</para></remarks>
    /// <seealso href="https://w3id.org/dco#OnAction">https://w3id.org/dco#OnAction</seealso>
    let OnAction = Prefixed_Name(w3dco, "OnAction") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>State</para></remarks>
    /// <seealso href="https://w3id.org/dco#State">https://w3id.org/dco#State</seealso>
    let State = Prefixed_Name(w3dco, "State") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:OpenState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Open state</para></remarks>
    /// <seealso href="https://w3id.org/dco#OpenState">https://w3id.org/dco#OpenState</seealso>
    let OpenState = Prefixed_Name(w3dco, "OpenState") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:OutdoorTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Outdoor temperature</para></remarks>
    /// <seealso href="https://w3id.org/dco#OutdoorTemperature">https://w3id.org/dco#OutdoorTemperature</seealso>
    let OutdoorTemperature = Prefixed_Name(w3dco, "OutdoorTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Percentage</para></remarks>
    /// <seealso href="https://w3id.org/dco#Percentage">https://w3id.org/dco#Percentage</seealso>
    let Percentage = Prefixed_Name(w3dco, "Percentage") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:PipeTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pipe temperature</para></remarks>
    /// <seealso href="https://w3id.org/dco#PipeTemperature">https://w3id.org/dco#PipeTemperature</seealso>
    let PipeTemperature = Prefixed_Name(w3dco, "PipeTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:PartsPerMillion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Parts per million</para></remarks>
    /// <seealso href="https://w3id.org/dco#PartsPerMillion">https://w3id.org/dco#PartsPerMillion</seealso>
    let PartsPerMillion = Prefixed_Name(w3dco, "PartsPerMillion") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:PercentageUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Percentage unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#PercentageUnit">https://w3id.org/dco#PercentageUnit</seealso>
    let PercentageUnit = Prefixed_Name(w3dco, "PercentageUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:hasSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasSite</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasSite">https://w3id.org/dco#hasSite</seealso>
    let hasSite = Prefixed_Name(w3dco, "hasSite") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:dCOCoreModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>dCO core model</para></remarks>
    /// <seealso href="https://w3id.org/dco#dCOCoreModel">https://w3id.org/dco#dCOCoreModel</seealso>
    let dCOCoreModel = Prefixed_Name(w3dco, "dCOCoreModel") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Action</para></remarks>
    /// <seealso href="https://w3id.org/dco#Action">https://w3id.org/dco#Action</seealso>
    let Action = Prefixed_Name(w3dco, "Action") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:InteractionAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Interaction Affordance</para></remarks>
    /// <seealso href="https://w3id.org/dco#InteractionAffordance">https://w3id.org/dco#InteractionAffordance</seealso>
    let InteractionAffordance =
        Prefixed_Name(w3dco, "InteractionAffordance") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ActiveEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Active energy</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActiveEnergy">https://w3id.org/dco#ActiveEnergy</seealso>
    let ActiveEnergy = Prefixed_Name(w3dco, "ActiveEnergy") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:EnergyProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Energy property</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyProperty">https://w3id.org/dco#EnergyProperty</seealso>
    let EnergyProperty = Prefixed_Name(w3dco, "EnergyProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ActiveEnergyExport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ActiveEnergyExport</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActiveEnergyExport">https://w3id.org/dco#ActiveEnergyExport</seealso>
    let ActiveEnergyExport = Prefixed_Name(w3dco, "ActiveEnergyExport") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ActiveEnergyImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Active energy import</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActiveEnergyImport">https://w3id.org/dco#ActiveEnergyImport</seealso>
    let ActiveEnergyImport = Prefixed_Name(w3dco, "ActiveEnergyImport") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ActivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Active power</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActivePower">https://w3id.org/dco#ActivePower</seealso>
    let ActivePower = Prefixed_Name(w3dco, "ActivePower") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:PowerProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Power property</para></remarks>
    /// <seealso href="https://w3id.org/dco#PowerProperty">https://w3id.org/dco#PowerProperty</seealso>
    let PowerProperty = Prefixed_Name(w3dco, "PowerProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ActivePowerExport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Active power export</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActivePowerExport">https://w3id.org/dco#ActivePowerExport</seealso>
    let ActivePowerExport = Prefixed_Name(w3dco, "ActivePowerExport") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ActivePowerImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Active power import</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActivePowerImport">https://w3id.org/dco#ActivePowerImport</seealso>
    let ActivePowerImport = Prefixed_Name(w3dco, "ActivePowerImport") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ActualPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Actual Power</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActualPower">https://w3id.org/dco#ActualPower</seealso>
    let ActualPower = Prefixed_Name(w3dco, "ActualPower") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Actuator</para></remarks>
    /// <seealso href="https://w3id.org/dco#Actuator">https://w3id.org/dco#Actuator</seealso>
    let Actuator = Prefixed_Name(w3dco, "Actuator") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Relay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Relay</para></remarks>
    /// <seealso href="https://w3id.org/dco#Relay">https://w3id.org/dco#Relay</seealso>
    let Relay = Prefixed_Name(w3dco, "Relay") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:AmbientHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ambient Humidity</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmbientHumidity">https://w3id.org/dco#AmbientHumidity</seealso>
    let AmbientHumidity = Prefixed_Name(w3dco, "AmbientHumidity") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:HumidityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Humidity property</para></remarks>
    /// <seealso href="https://w3id.org/dco#HumidityProperty">https://w3id.org/dco#HumidityProperty</seealso>
    let HumidityProperty = Prefixed_Name(w3dco, "HumidityProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:AmbientSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ambient Sensor</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmbientSensor">https://w3id.org/dco#AmbientSensor</seealso>
    let AmbientSensor = Prefixed_Name(w3dco, "AmbientSensor") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sensor</para></remarks>
    /// <seealso href="https://w3id.org/dco#Sensor">https://w3id.org/dco#Sensor</seealso>
    let Sensor = Prefixed_Name(w3dco, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:AmbientTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ambient temperature</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmbientTemperature">https://w3id.org/dco#AmbientTemperature</seealso>
    let AmbientTemperature = Prefixed_Name(w3dco, "AmbientTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:TemperatureProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Temperature Property</para></remarks>
    /// <seealso href="https://w3id.org/dco#TemperatureProperty">https://w3id.org/dco#TemperatureProperty</seealso>
    let TemperatureProperty =
        Prefixed_Name(w3dco, "TemperatureProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:Amperage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Amperage</para></remarks>
    /// <seealso href="https://w3id.org/dco#Amperage">https://w3id.org/dco#Amperage</seealso>
    let Amperage = Prefixed_Name(w3dco, "Amperage") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:AmperageProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Amperage property</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmperageProperty">https://w3id.org/dco#AmperageProperty</seealso>
    let AmperageProperty = Prefixed_Name(w3dco, "AmperageProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:AmperageClamp1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Amperage clamp 1</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmperageClamp1">https://w3id.org/dco#AmperageClamp1</seealso>
    let AmperageClamp1 = Prefixed_Name(w3dco, "AmperageClamp1") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:AmperageClamp2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Amperage clamp 2</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmperageClamp2">https://w3id.org/dco#AmperageClamp2</seealso>
    let AmperageClamp2 = Prefixed_Name(w3dco, "AmperageClamp2") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:AmperageClamp3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Amperage clamp 3</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmperageClamp3">https://w3id.org/dco#AmperageClamp3</seealso>
    let AmperageClamp3 = Prefixed_Name(w3dco, "AmperageClamp3") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Property</para></remarks>
    /// <seealso href="https://w3id.org/dco#Property">https://w3id.org/dco#Property</seealso>
    let Property = Prefixed_Name(w3dco, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Ampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ampere</para></remarks>
    /// <seealso href="https://w3id.org/dco#Ampere">https://w3id.org/dco#Ampere</seealso>
    let Ampere = Prefixed_Name(w3dco, "Ampere") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:ElectricUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Electric unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#ElectricUnit">https://w3id.org/dco#ElectricUnit</seealso>
    let ElectricUnit = Prefixed_Name(w3dco, "ElectricUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Apartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Apartment</para></remarks>
    /// <seealso href="https://w3id.org/dco#Apartment">https://w3id.org/dco#Apartment</seealso>
    let Apartment = Prefixed_Name(w3dco, "Apartment") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Space</para></remarks>
    /// <seealso href="https://w3id.org/dco#Space">https://w3id.org/dco#Space</seealso>
    let Space = Prefixed_Name(w3dco, "Space") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Appliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Appliance</para></remarks>
    /// <seealso href="https://w3id.org/dco#Appliance">https://w3id.org/dco#Appliance</seealso>
    let Appliance = Prefixed_Name(w3dco, "Appliance") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:AreaUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Area unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#AreaUnit">https://w3id.org/dco#AreaUnit</seealso>
    let AreaUnit = Prefixed_Name(w3dco, "AreaUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:UnitsOfMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Units of measurements</para></remarks>
    /// <seealso href="https://w3id.org/dco#UnitsOfMeasurements">https://w3id.org/dco#UnitsOfMeasurements</seealso>
    let UnitsOfMeasurements =
        Prefixed_Name(w3dco, "UnitsOfMeasurements") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:Bathroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bathroom</para></remarks>
    /// <seealso href="https://w3id.org/dco#Bathroom">https://w3id.org/dco#Bathroom</seealso>
    let Bathroom = Prefixed_Name(w3dco, "Bathroom") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Room</para></remarks>
    /// <seealso href="https://w3id.org/dco#Room">https://w3id.org/dco#Room</seealso>
    let Room = Prefixed_Name(w3dco, "Room") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BatteryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Battery level</para></remarks>
    /// <seealso href="https://w3id.org/dco#BatteryLevel">https://w3id.org/dco#BatteryLevel</seealso>
    let BatteryLevel = Prefixed_Name(w3dco, "BatteryLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BatteryProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Battery Property</para></remarks>
    /// <seealso href="https://w3id.org/dco#BatteryProperty">https://w3id.org/dco#BatteryProperty</seealso>
    let BatteryProperty = Prefixed_Name(w3dco, "BatteryProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Bedroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bedroom</para></remarks>
    /// <seealso href="https://w3id.org/dco#Bedroom">https://w3id.org/dco#Bedroom</seealso>
    let Bedroom = Prefixed_Name(w3dco, "Bedroom") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building</para></remarks>
    /// <seealso href="https://w3id.org/dco#Building">https://w3id.org/dco#Building</seealso>
    let Building = Prefixed_Name(w3dco, "Building") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BuildingAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building address</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingAddress">https://w3id.org/dco#BuildingAddress</seealso>
    let BuildingAddress = Prefixed_Name(w3dco, "BuildingAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BuildingMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building metadata</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingMetadata">https://w3id.org/dco#BuildingMetadata</seealso>
    let BuildingMetadata = Prefixed_Name(w3dco, "BuildingMetadata") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BuildingCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building city</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingCity">https://w3id.org/dco#BuildingCity</seealso>
    let BuildingCity = Prefixed_Name(w3dco, "BuildingCity") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:BuildingConstructionYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building construction year</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingConstructionYear">https://w3id.org/dco#BuildingConstructionYear</seealso>
    let BuildingConstructionYear =
        Prefixed_Name(w3dco, "BuildingConstructionYear") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:BuildingHeatedSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building heated surface</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingHeatedSurface">https://w3id.org/dco#BuildingHeatedSurface</seealso>
    let BuildingHeatedSurface =
        Prefixed_Name(w3dco, "BuildingHeatedSurface") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:BuildingLivingArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building living area</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingLivingArea">https://w3id.org/dco#BuildingLivingArea</seealso>
    let BuildingLivingArea = Prefixed_Name(w3dco, "BuildingLivingArea") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BuildingModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building model</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingModel">https://w3id.org/dco#BuildingModel</seealso>
    let BuildingModel = Prefixed_Name(w3dco, "BuildingModel") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BuildingName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building Name</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingName">https://w3id.org/dco#BuildingName</seealso>
    let BuildingName = Prefixed_Name(w3dco, "BuildingName") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:BuildingNumberOfInhabitants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building number of inhabitants</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingNumberOfInhabitants">https://w3id.org/dco#BuildingNumberOfInhabitants</seealso>
    let BuildingNumberOfInhabitants =
        Prefixed_Name(w3dco, "BuildingNumberOfInhabitants") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:BuildingTopology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building topology</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingTopology">https://w3id.org/dco#BuildingTopology</seealso>
    let BuildingTopology = Prefixed_Name(w3dco, "BuildingTopology") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BuildingTotalSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building total space</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingTotalSpace">https://w3id.org/dco#BuildingTotalSpace</seealso>
    let BuildingTotalSpace = Prefixed_Name(w3dco, "BuildingTotalSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BuildingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Building type</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingType">https://w3id.org/dco#BuildingType</seealso>
    let BuildingType = Prefixed_Name(w3dco, "BuildingType") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:BusinessBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Business building</para></remarks>
    /// <seealso href="https://w3id.org/dco#BusinessBuilding">https://w3id.org/dco#BusinessBuilding</seealso>
    let BusinessBuilding = Prefixed_Name(w3dco, "BusinessBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:CO2Concentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>CO2 concentration</para></remarks>
    /// <seealso href="https://w3id.org/dco#CO2Concentration">https://w3id.org/dco#CO2Concentration</seealso>
    let CO2Concentration = Prefixed_Name(w3dco, "CO2Concentration") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:CarbonDioxideProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Carbon dioxide property</para></remarks>
    /// <seealso href="https://w3id.org/dco#CarbonDioxideProperty">https://w3id.org/dco#CarbonDioxideProperty</seealso>
    let CarbonDioxideProperty =
        Prefixed_Name(w3dco, "CarbonDioxideProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:CloseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Close state</para></remarks>
    /// <seealso href="https://w3id.org/dco#CloseState">https://w3id.org/dco#CloseState</seealso>
    let CloseState = Prefixed_Name(w3dco, "CloseState") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:OpenCloseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Open Close State</para></remarks>
    /// <seealso href="https://w3id.org/dco#OpenCloseState">https://w3id.org/dco#OpenCloseState</seealso>
    let OpenCloseState = Prefixed_Name(w3dco, "OpenCloseState") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:ClosedLoopEnergyEfficiencyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Closed loop energy efficiency service</para></remarks>
    /// <seealso href="https://w3id.org/dco#ClosedLoopEnergyEfficiencyService">https://w3id.org/dco#ClosedLoopEnergyEfficiencyService</seealso>
    let ClosedLoopEnergyEfficiencyService =
        Prefixed_Name(w3dco, "ClosedLoopEnergyEfficiencyService") |> PrefixedName

    /// <summary>
    ///   <para>w3dco:Controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Controller</para></remarks>
    /// <seealso href="https://w3id.org/dco#Controller">https://w3id.org/dco#Controller</seealso>
    let Controller = Prefixed_Name(w3dco, "Controller") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:CubicMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cubic meter</para></remarks>
    /// <seealso href="https://w3id.org/dco#CubicMeter">https://w3id.org/dco#CubicMeter</seealso>
    let CubicMeter = Prefixed_Name(w3dco, "CubicMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:VolumeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Volume unit</para></remarks>
    /// <seealso href="https://w3id.org/dco#VolumeUnit">https://w3id.org/dco#VolumeUnit</seealso>
    let VolumeUnit = Prefixed_Name(w3dco, "VolumeUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3dco:CubicMeterPerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cubic meter per hour</para></remarks>
    /// <seealso href="https://w3id.org/dco#CubicMeterPerHour">https://w3id.org/dco#CubicMeterPerHour</seealso>
    let CubicMeterPerHour = Prefixed_Name(w3dco, "CubicMeterPerHour") |> PrefixedName
