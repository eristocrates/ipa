namespace https.w3id.org.dco.hash

open DoxAletheia.Rdf_Vocabulary

module dco =
    let _namespace_name = "https://w3id.org/dco#"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasSite"></see>
    /// </summary>
    let hasSite = Namespaced_IRI.parse _namespace_name "hasSite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#dCOCoreModel"></see>
    /// </summary>
    let dCOCoreModel =
        Namespaced_IRI.parse _namespace_name "dCOCoreModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#InteractionAffordance"></see>
    /// </summary>
    let InteractionAffordance =
        Namespaced_IRI.parse _namespace_name "InteractionAffordance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ActiveEnergy"></see>
    /// </summary>
    let ActiveEnergy =
        Namespaced_IRI.parse _namespace_name "ActiveEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyProperty"></see>
    /// </summary>
    let EnergyProperty =
        Namespaced_IRI.parse _namespace_name "EnergyProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ActiveEnergyExport"></see>
    /// </summary>
    let ActiveEnergyExport =
        Namespaced_IRI.parse _namespace_name "ActiveEnergyExport" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ActiveEnergyImport"></see>
    /// </summary>
    let ActiveEnergyImport =
        Namespaced_IRI.parse _namespace_name "ActiveEnergyImport" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ActivePower"></see>
    /// </summary>
    let ActivePower =
        Namespaced_IRI.parse _namespace_name "ActivePower" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#PowerProperty"></see>
    /// </summary>
    let PowerProperty =
        Namespaced_IRI.parse _namespace_name "PowerProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ActivePowerExport"></see>
    /// </summary>
    let ActivePowerExport =
        Namespaced_IRI.parse _namespace_name "ActivePowerExport" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ActivePowerImport"></see>
    /// </summary>
    let ActivePowerImport =
        Namespaced_IRI.parse _namespace_name "ActivePowerImport" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ActualPower"></see>
    /// </summary>
    let ActualPower =
        Namespaced_IRI.parse _namespace_name "ActualPower" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Actuator"></see>
    /// </summary>
    let Actuator = Namespaced_IRI.parse _namespace_name "Actuator" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Relay"></see>
    /// </summary>
    let Relay = Namespaced_IRI.parse _namespace_name "Relay" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#AmbientHumidity"></see>
    /// </summary>
    let AmbientHumidity =
        Namespaced_IRI.parse _namespace_name "AmbientHumidity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HumidityProperty"></see>
    /// </summary>
    let HumidityProperty =
        Namespaced_IRI.parse _namespace_name "HumidityProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#AmbientSensor"></see>
    /// </summary>
    let AmbientSensor =
        Namespaced_IRI.parse _namespace_name "AmbientSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Sensor"></see>
    /// </summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#AmbientTemperature"></see>
    /// </summary>
    let AmbientTemperature =
        Namespaced_IRI.parse _namespace_name "AmbientTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#TemperatureProperty"></see>
    /// </summary>
    let TemperatureProperty =
        Namespaced_IRI.parse _namespace_name "TemperatureProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Amperage"></see>
    /// </summary>
    let Amperage = Namespaced_IRI.parse _namespace_name "Amperage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#AmperageProperty"></see>
    /// </summary>
    let AmperageProperty =
        Namespaced_IRI.parse _namespace_name "AmperageProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#AmperageClamp1"></see>
    /// </summary>
    let AmperageClamp1 =
        Namespaced_IRI.parse _namespace_name "AmperageClamp1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#AmperageClamp2"></see>
    /// </summary>
    let AmperageClamp2 =
        Namespaced_IRI.parse _namespace_name "AmperageClamp2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#AmperageClamp3"></see>
    /// </summary>
    let AmperageClamp3 =
        Namespaced_IRI.parse _namespace_name "AmperageClamp3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Property"></see>
    /// </summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Ampere"></see>
    /// </summary>
    let Ampere = Namespaced_IRI.parse _namespace_name "Ampere" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ElectricUnit"></see>
    /// </summary>
    let ElectricUnit =
        Namespaced_IRI.parse _namespace_name "ElectricUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Apartment"></see>
    /// </summary>
    let Apartment = Namespaced_IRI.parse _namespace_name "Apartment" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Space"></see>
    /// </summary>
    let Space = Namespaced_IRI.parse _namespace_name "Space" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Appliance"></see>
    /// </summary>
    let Appliance = Namespaced_IRI.parse _namespace_name "Appliance" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#AreaUnit"></see>
    /// </summary>
    let AreaUnit = Namespaced_IRI.parse _namespace_name "AreaUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#UnitsOfMeasurements"></see>
    /// </summary>
    let UnitsOfMeasurements =
        Namespaced_IRI.parse _namespace_name "UnitsOfMeasurements" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Bathroom"></see>
    /// </summary>
    let Bathroom = Namespaced_IRI.parse _namespace_name "Bathroom" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Room"></see>
    /// </summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BatteryLevel"></see>
    /// </summary>
    let BatteryLevel =
        Namespaced_IRI.parse _namespace_name "BatteryLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BatteryProperty"></see>
    /// </summary>
    let BatteryProperty =
        Namespaced_IRI.parse _namespace_name "BatteryProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Bedroom"></see>
    /// </summary>
    let Bedroom = Namespaced_IRI.parse _namespace_name "Bedroom" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Building"></see>
    /// </summary>
    let Building = Namespaced_IRI.parse _namespace_name "Building" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingAddress"></see>
    /// </summary>
    let BuildingAddress =
        Namespaced_IRI.parse _namespace_name "BuildingAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingMetadata"></see>
    /// </summary>
    let BuildingMetadata =
        Namespaced_IRI.parse _namespace_name "BuildingMetadata" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingCity"></see>
    /// </summary>
    let BuildingCity =
        Namespaced_IRI.parse _namespace_name "BuildingCity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingConstructionYear"></see>
    /// </summary>
    let BuildingConstructionYear =
        Namespaced_IRI.parse _namespace_name "BuildingConstructionYear" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingHeatedSurface"></see>
    /// </summary>
    let BuildingHeatedSurface =
        Namespaced_IRI.parse _namespace_name "BuildingHeatedSurface" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingLivingArea"></see>
    /// </summary>
    let BuildingLivingArea =
        Namespaced_IRI.parse _namespace_name "BuildingLivingArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingModel"></see>
    /// </summary>
    let BuildingModel =
        Namespaced_IRI.parse _namespace_name "BuildingModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingName"></see>
    /// </summary>
    let BuildingName =
        Namespaced_IRI.parse _namespace_name "BuildingName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingNumberOfInhabitants"></see>
    /// </summary>
    let BuildingNumberOfInhabitants =
        Namespaced_IRI.parse _namespace_name "BuildingNumberOfInhabitants" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingRenovationDate"></see>
    /// </summary>
    let BuildingRenovationDate =
        Namespaced_IRI.parse _namespace_name "BuildingRenovationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingTopology"></see>
    /// </summary>
    let BuildingTopology =
        Namespaced_IRI.parse _namespace_name "BuildingTopology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingTotalSpace"></see>
    /// </summary>
    let BuildingTotalSpace =
        Namespaced_IRI.parse _namespace_name "BuildingTotalSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingType"></see>
    /// </summary>
    let BuildingType =
        Namespaced_IRI.parse _namespace_name "BuildingType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#BusinessBuilding"></see>
    /// </summary>
    let BusinessBuilding =
        Namespaced_IRI.parse _namespace_name "BusinessBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#CO2Concentration"></see>
    /// </summary>
    let CO2Concentration =
        Namespaced_IRI.parse _namespace_name "CO2Concentration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#CarbonDioxideProperty"></see>
    /// </summary>
    let CarbonDioxideProperty =
        Namespaced_IRI.parse _namespace_name "CarbonDioxideProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Celsius"></see>
    /// </summary>
    let Celsius = Namespaced_IRI.parse _namespace_name "Celsius" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#TemperatureUnit"></see>
    /// </summary>
    let TemperatureUnit =
        Namespaced_IRI.parse _namespace_name "TemperatureUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#CloseState"></see>
    /// </summary>
    let CloseState = Namespaced_IRI.parse _namespace_name "CloseState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#OpenCloseState"></see>
    /// </summary>
    let OpenCloseState =
        Namespaced_IRI.parse _namespace_name "OpenCloseState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ClosedLoopEnergyEfficiencyService"></see>
    /// </summary>
    let ClosedLoopEnergyEfficiencyService =
        Namespaced_IRI.parse _namespace_name "ClosedLoopEnergyEfficiencyService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Controller"></see>
    /// </summary>
    let Controller = Namespaced_IRI.parse _namespace_name "Controller" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#CubicMeter"></see>
    /// </summary>
    let CubicMeter = Namespaced_IRI.parse _namespace_name "CubicMeter" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#VolumeUnit"></see>
    /// </summary>
    let VolumeUnit = Namespaced_IRI.parse _namespace_name "VolumeUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#CubicMeterPerHour"></see>
    /// </summary>
    let CubicMeterPerHour =
        Namespaced_IRI.parse _namespace_name "CubicMeterPerHour" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DefineTemperatureSetpoint"></see>
    /// </summary>
    let DefineTemperatureSetpoint =
        Namespaced_IRI.parse _namespace_name "DefineTemperatureSetpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DesiredValveOpening"></see>
    /// </summary>
    let DesiredValveOpening =
        Namespaced_IRI.parse _namespace_name "DesiredValveOpening" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveProperty"></see>
    /// </summary>
    let ValveProperty =
        Namespaced_IRI.parse _namespace_name "ValveProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceIdentifier"></see>
    /// </summary>
    let DeviceIdentifier =
        Namespaced_IRI.parse _namespace_name "DeviceIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceMetadata"></see>
    /// </summary>
    let DeviceMetadata =
        Namespaced_IRI.parse _namespace_name "DeviceMetadata" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceManifucturer"></see>
    /// </summary>
    let DeviceManifucturer =
        Namespaced_IRI.parse _namespace_name "DeviceManifucturer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceMaximumDisabledTime"></see>
    /// </summary>
    let DeviceMaximumDisabledTime =
        Namespaced_IRI.parse _namespace_name "DeviceMaximumDisabledTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceMaximumPower"></see>
    /// </summary>
    let DeviceMaximumPower =
        Namespaced_IRI.parse _namespace_name "DeviceMaximumPower" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceMinimumEnabledTime"></see>
    /// </summary>
    let DeviceMinimumEnabledTime =
        Namespaced_IRI.parse _namespace_name "DeviceMinimumEnabledTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceSerialNumber"></see>
    /// </summary>
    let DeviceSerialNumber =
        Namespaced_IRI.parse _namespace_name "DeviceSerialNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceSoftwareVersion"></see>
    /// </summary>
    let DeviceSoftwareVersion =
        Namespaced_IRI.parse _namespace_name "DeviceSoftwareVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EVChargingAppliance"></see>
    /// </summary>
    let EVChargingAppliance =
        Namespaced_IRI.parse _namespace_name "EVChargingAppliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyClamp1"></see>
    /// </summary>
    let EnergyClamp1 =
        Namespaced_IRI.parse _namespace_name "EnergyClamp1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyClamp2"></see>
    /// </summary>
    let EnergyClamp2 =
        Namespaced_IRI.parse _namespace_name "EnergyClamp2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyClamp3"></see>
    /// </summary>
    let EnergyClamp3 =
        Namespaced_IRI.parse _namespace_name "EnergyClamp3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyFlow"></see>
    /// </summary>
    let EnergyFlow = Namespaced_IRI.parse _namespace_name "EnergyFlow" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyMeter"></see>
    /// </summary>
    let EnergyMeter =
        Namespaced_IRI.parse _namespace_name "EnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Meter"></see>
    /// </summary>
    let Meter = Namespaced_IRI.parse _namespace_name "Meter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyQuadrant1"></see>
    /// </summary>
    let EnergyQuadrant1 =
        Namespaced_IRI.parse _namespace_name "EnergyQuadrant1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyQuadrant2"></see>
    /// </summary>
    let EnergyQuadrant2 =
        Namespaced_IRI.parse _namespace_name "EnergyQuadrant2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyQuadrant3"></see>
    /// </summary>
    let EnergyQuadrant3 =
        Namespaced_IRI.parse _namespace_name "EnergyQuadrant3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyQuadrant4"></see>
    /// </summary>
    let EnergyQuadrant4 =
        Namespaced_IRI.parse _namespace_name "EnergyQuadrant4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyUnit"></see>
    /// </summary>
    let EnergyUnit = Namespaced_IRI.parse _namespace_name "EnergyUnit" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ExportedEnergy"></see>
    /// </summary>
    let ExportedEnergy =
        Namespaced_IRI.parse _namespace_name "ExportedEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ExportedEnergyWithPricing1"></see>
    /// </summary>
    let ExportedEnergyWithPricing1 =
        Namespaced_IRI.parse _namespace_name "ExportedEnergyWithPricing1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ExportedEnergyWithPricing2"></see>
    /// </summary>
    let ExportedEnergyWithPricing2 =
        Namespaced_IRI.parse _namespace_name "ExportedEnergyWithPricing2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#FeatureOfInterest"></see>
    /// </summary>
    let FeatureOfInterest =
        Namespaced_IRI.parse _namespace_name "FeatureOfInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#FeatureProperty"></see>
    /// </summary>
    let FeatureProperty =
        Namespaced_IRI.parse _namespace_name "FeatureProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#FlexibilityService"></see>
    /// </summary>
    let FlexibilityService =
        Namespaced_IRI.parse _namespace_name "FlexibilityService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Floor"></see>
    /// </summary>
    let Floor = Namespaced_IRI.parse _namespace_name "Floor" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#GasBoiler"></see>
    /// </summary>
    let GasBoiler = Namespaced_IRI.parse _namespace_name "GasBoiler" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#GasBoilerActuator"></see>
    /// </summary>
    let GasBoilerActuator =
        Namespaced_IRI.parse _namespace_name "GasBoilerActuator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#GasMeter"></see>
    /// </summary>
    let GasMeter = Namespaced_IRI.parse _namespace_name "GasMeter" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Gateway"></see>
    /// </summary>
    let Gateway = Namespaced_IRI.parse _namespace_name "Gateway" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#GetTemperatureSetpoint"></see>
    /// </summary>
    let GetTemperatureSetpoint =
        Namespaced_IRI.parse _namespace_name "GetTemperatureSetpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#GetValveOpeningPercentage"></see>
    /// </summary>
    let GetValveOpeningPercentage =
        Namespaced_IRI.parse _namespace_name "GetValveOpeningPercentage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatMeter"></see>
    /// </summary>
    let HeatMeter = Namespaced_IRI.parse _namespace_name "HeatMeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatPumpAppliance"></see>
    /// </summary>
    let HeatPumpAppliance =
        Namespaced_IRI.parse _namespace_name "HeatPumpAppliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatPumpRelay"></see>
    /// </summary>
    let HeatPumpRelay =
        Namespaced_IRI.parse _namespace_name "HeatPumpRelay" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HeaterMaximalPower"></see>
    /// </summary>
    let HeaterMaximalPower =
        Namespaced_IRI.parse _namespace_name "HeaterMaximalPower" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HeaterMinimumPower"></see>
    /// </summary>
    let HeaterMinimumPower =
        Namespaced_IRI.parse _namespace_name "HeaterMinimumPower" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatingActuator"></see>
    /// </summary>
    let HeatingActuator =
        Namespaced_IRI.parse _namespace_name "HeatingActuator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatingService"></see>
    /// </summary>
    let HeatingService =
        Namespaced_IRI.parse _namespace_name "HeatingService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HotWaterProductionService"></see>
    /// </summary>
    let HotWaterProductionService =
        Namespaced_IRI.parse _namespace_name "HotWaterProductionService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HouseholdType"></see>
    /// </summary>
    let HouseholdType =
        Namespaced_IRI.parse _namespace_name "HouseholdType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#HumiditySensor"></see>
    /// </summary>
    let HumiditySensor =
        Namespaced_IRI.parse _namespace_name "HumiditySensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ImportedEnergy"></see>
    /// </summary>
    let ImportedEnergy =
        Namespaced_IRI.parse _namespace_name "ImportedEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ImportedEnergyWithPricing1"></see>
    /// </summary>
    let ImportedEnergyWithPricing1 =
        Namespaced_IRI.parse _namespace_name "ImportedEnergyWithPricing1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ImportedEnergyWithPricing2"></see>
    /// </summary>
    let ImportedEnergyWithPricing2 =
        Namespaced_IRI.parse _namespace_name "ImportedEnergyWithPricing2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#IndustrialBuilding"></see>
    /// </summary>
    let IndustrialBuilding =
        Namespaced_IRI.parse _namespace_name "IndustrialBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#IntelTemperature"></see>
    /// </summary>
    let IntelTemperature =
        Namespaced_IRI.parse _namespace_name "IntelTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ThingDescriptionModel"></see>
    /// </summary>
    let ThingDescriptionModel =
        Namespaced_IRI.parse _namespace_name "ThingDescriptionModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Kitchen"></see>
    /// </summary>
    let Kitchen = Namespaced_IRI.parse _namespace_name "Kitchen" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#LivingRoom"></see>
    /// </summary>
    let LivingRoom = Namespaced_IRI.parse _namespace_name "LivingRoom" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Lobby"></see>
    /// </summary>
    let Lobby = Namespaced_IRI.parse _namespace_name "Lobby" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#MagnetSensor"></see>
    /// </summary>
    let MagnetSensor =
        Namespaced_IRI.parse _namespace_name "MagnetSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#MeasureTimeStamp"></see>
    /// </summary>
    let MeasureTimeStamp =
        Namespaced_IRI.parse _namespace_name "MeasureTimeStamp" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#MeasuredValveOpening"></see>
    /// </summary>
    let MeasuredValveOpening =
        Namespaced_IRI.parse _namespace_name "MeasuredValveOpening" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#MultiFamilyHouse"></see>
    /// </summary>
    let MultiFamilyHouse =
        Namespaced_IRI.parse _namespace_name "MultiFamilyHouse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#OffAction"></see>
    /// </summary>
    let OffAction = Namespaced_IRI.parse _namespace_name "OffAction" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#OffState"></see>
    /// </summary>
    let OffState = Namespaced_IRI.parse _namespace_name "OffState" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#OnOffState"></see>
    /// </summary>
    let OnOffState = Namespaced_IRI.parse _namespace_name "OnOffState" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#OnAction"></see>
    /// </summary>
    let OnAction = Namespaced_IRI.parse _namespace_name "OnAction" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#OnState"></see>
    /// </summary>
    let OnState = Namespaced_IRI.parse _namespace_name "OnState" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#OpenState"></see>
    /// </summary>
    let OpenState = Namespaced_IRI.parse _namespace_name "OpenState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#OutdoorTemperature"></see>
    /// </summary>
    let OutdoorTemperature =
        Namespaced_IRI.parse _namespace_name "OutdoorTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#PartsPerMillion"></see>
    /// </summary>
    let PartsPerMillion =
        Namespaced_IRI.parse _namespace_name "PartsPerMillion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#PartsPerNotationUnit"></see>
    /// </summary>
    let PartsPerNotationUnit =
        Namespaced_IRI.parse _namespace_name "PartsPerNotationUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Percentage"></see>
    /// </summary>
    let Percentage = Namespaced_IRI.parse _namespace_name "Percentage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#PercentageUnit"></see>
    /// </summary>
    let PercentageUnit =
        Namespaced_IRI.parse _namespace_name "PercentageUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#PipeTemperature"></see>
    /// </summary>
    let PipeTemperature =
        Namespaced_IRI.parse _namespace_name "PipeTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#PowerMeter"></see>
    /// </summary>
    let PowerMeter = Namespaced_IRI.parse _namespace_name "PowerMeter" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#PowerUnit"></see>
    /// </summary>
    let PowerUnit = Namespaced_IRI.parse _namespace_name "PowerUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ReactiveEnergy"></see>
    /// </summary>
    let ReactiveEnergy =
        Namespaced_IRI.parse _namespace_name "ReactiveEnergy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ReactivePower"></see>
    /// </summary>
    let ReactivePower =
        Namespaced_IRI.parse _namespace_name "ReactivePower" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ReactivePowerExport"></see>
    /// </summary>
    let ReactivePowerExport =
        Namespaced_IRI.parse _namespace_name "ReactivePowerExport" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ReactivePowerImport"></see>
    /// </summary>
    let ReactivePowerImport =
        Namespaced_IRI.parse _namespace_name "ReactivePowerImport" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ResidentialBuilding"></see>
    /// </summary>
    let ResidentialBuilding =
        Namespaced_IRI.parse _namespace_name "ResidentialBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ReturnTemperatureSensor"></see>
    /// </summary>
    let ReturnTemperatureSensor =
        Namespaced_IRI.parse _namespace_name "ReturnTemperatureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Setpoint"></see>
    /// </summary>
    let Setpoint = Namespaced_IRI.parse _namespace_name "Setpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#SingleFamilyHouse"></see>
    /// </summary>
    let SingleFamilyHouse =
        Namespaced_IRI.parse _namespace_name "SingleFamilyHouse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Site"></see>
    /// </summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#SmartMeter"></see>
    /// </summary>
    let SmartMeter = Namespaced_IRI.parse _namespace_name "SmartMeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#SolarPanelsAppliance"></see>
    /// </summary>
    let SolarPanelsAppliance =
        Namespaced_IRI.parse _namespace_name "SolarPanelsAppliance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#SquareMeter"></see>
    /// </summary>
    let SquareMeter =
        Namespaced_IRI.parse _namespace_name "SquareMeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#StartState"></see>
    /// </summary>
    let StartState = Namespaced_IRI.parse _namespace_name "StartState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#StartStopState"></see>
    /// </summary>
    let StartStopState =
        Namespaced_IRI.parse _namespace_name "StartStopState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#StopState"></see>
    /// </summary>
    let StopState = Namespaced_IRI.parse _namespace_name "StopState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#SupplyTemperatureSensor"></see>
    /// </summary>
    let SupplyTemperatureSensor =
        Namespaced_IRI.parse _namespace_name "SupplyTemperatureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#TankTemperature"></see>
    /// </summary>
    let TankTemperature =
        Namespaced_IRI.parse _namespace_name "TankTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#TemperatureSensor"></see>
    /// </summary>
    let TemperatureSensor =
        Namespaced_IRI.parse _namespace_name "TemperatureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#TemperatureSetpoint"></see>
    /// </summary>
    let TemperatureSetpoint =
        Namespaced_IRI.parse _namespace_name "TemperatureSetpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#TertiaryBuilding"></see>
    /// </summary>
    let TertiaryBuilding =
        Namespaced_IRI.parse _namespace_name "TertiaryBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Thermostat"></see>
    /// </summary>
    let Thermostat = Namespaced_IRI.parse _namespace_name "Thermostat" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ThermostaticValveActuator"></see>
    /// </summary>
    let ThermostaticValveActuator =
        Namespaced_IRI.parse _namespace_name "ThermostaticValveActuator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ToggleAction"></see>
    /// </summary>
    let ToggleAction =
        Namespaced_IRI.parse _namespace_name "ToggleAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveActuator"></see>
    /// </summary>
    let ValveActuator =
        Namespaced_IRI.parse _namespace_name "ValveActuator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveController"></see>
    /// </summary>
    let ValveController =
        Namespaced_IRI.parse _namespace_name "ValveController" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveMaximumOpening"></see>
    /// </summary>
    let ValveMaximumOpening =
        Namespaced_IRI.parse _namespace_name "ValveMaximumOpening" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveMaximumTemperature"></see>
    /// </summary>
    let ValveMaximumTemperature =
        Namespaced_IRI.parse _namespace_name "ValveMaximumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveMinimumOpening"></see>
    /// </summary>
    let ValveMinimumOpening =
        Namespaced_IRI.parse _namespace_name "ValveMinimumOpening" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveMinimumTemperature"></see>
    /// </summary>
    let ValveMinimumTemperature =
        Namespaced_IRI.parse _namespace_name "ValveMinimumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#ValvePosition"></see>
    /// </summary>
    let ValvePosition =
        Namespaced_IRI.parse _namespace_name "ValvePosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Volt-ampereReactive"></see>
    /// </summary>
    let ``Volt-ampereReactive`` =
        Namespaced_IRI.parse _namespace_name "Volt-ampereReactive" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Voltage"></see>
    /// </summary>
    let Voltage = Namespaced_IRI.parse _namespace_name "Voltage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#VoltageProperty"></see>
    /// </summary>
    let VoltageProperty =
        Namespaced_IRI.parse _namespace_name "VoltageProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#VoltageClamp1"></see>
    /// </summary>
    let VoltageClamp1 =
        Namespaced_IRI.parse _namespace_name "VoltageClamp1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#VoltageClamp2"></see>
    /// </summary>
    let VoltageClamp2 =
        Namespaced_IRI.parse _namespace_name "VoltageClamp2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#VoltageClamp3"></see>
    /// </summary>
    let VoltageClamp3 =
        Namespaced_IRI.parse _namespace_name "VoltageClamp3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterFlow"></see>
    /// </summary>
    let WaterFlow = Namespaced_IRI.parse _namespace_name "WaterFlow" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterProperty"></see>
    /// </summary>
    let WaterProperty =
        Namespaced_IRI.parse _namespace_name "WaterProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterFlowMeter"></see>
    /// </summary>
    let WaterFlowMeter =
        Namespaced_IRI.parse _namespace_name "WaterFlowMeter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterTemperature"></see>
    /// </summary>
    let WaterTemperature =
        Namespaced_IRI.parse _namespace_name "WaterTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterTemperatureSensor"></see>
    /// </summary>
    let WaterTemperatureSensor =
        Namespaced_IRI.parse _namespace_name "WaterTemperatureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterVolume"></see>
    /// </summary>
    let WaterVolume =
        Namespaced_IRI.parse _namespace_name "WaterVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#Watt"></see>
    /// </summary>
    let Watt = Namespaced_IRI.parse _namespace_name "Watt" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#WattHourBasedUnit"></see>
    /// </summary>
    let WattHourBasedUnit =
        Namespaced_IRI.parse _namespace_name "WattHourBasedUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#WoTThing"></see>
    /// </summary>
    let WoTThing = Namespaced_IRI.parse _namespace_name "WoTThing" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#Zone"></see>
    /// </summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#buildingZipCode"></see>
    /// </summary>
    let buildingZipCode =
        Namespaced_IRI.parse _namespace_name "buildingZipCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#consitsOf"></see>
    /// </summary>
    let consitsOf = Namespaced_IRI.parse _namespace_name "consitsOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#containsDevice"></see>
    /// </summary>
    let containsDevice =
        Namespaced_IRI.parse _namespace_name "containsDevice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#isLocatedAt"></see>
    /// </summary>
    let isLocatedAt =
        Namespaced_IRI.parse _namespace_name "isLocatedAt" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasAddress"></see>
    /// </summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasApartment"></see>
    /// </summary>
    let hasApartment =
        Namespaced_IRI.parse _namespace_name "hasApartment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#isApartmentOF"></see>
    /// </summary>
    let isApartmentOF =
        Namespaced_IRI.parse _namespace_name "isApartmentOF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasBuilding"></see>
    /// </summary>
    let hasBuilding =
        Namespaced_IRI.parse _namespace_name "hasBuilding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasCity"></see>
    /// </summary>
    let hasCity = Namespaced_IRI.parse _namespace_name "hasCity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasConstructionYear"></see>
    /// </summary>
    let hasConstructionYear =
        Namespaced_IRI.parse _namespace_name "hasConstructionYear" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasFloor"></see>
    /// </summary>
    let hasFloor = Namespaced_IRI.parse _namespace_name "hasFloor" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#isFloorOf"></see>
    /// </summary>
    let isFloorOf = Namespaced_IRI.parse _namespace_name "isFloorOf" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasID"></see>
    /// </summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasNumberOfInhabitants"></see>
    /// </summary>
    let hasNumberOfInhabitants =
        Namespaced_IRI.parse _namespace_name "hasNumberOfInhabitants" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasRenovationDate"></see>
    /// </summary>
    let hasRenovationDate =
        Namespaced_IRI.parse _namespace_name "hasRenovationDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasSpace"></see>
    /// </summary>
    let hasSpace = Namespaced_IRI.parse _namespace_name "hasSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasThingDescriptionAction"></see>
    /// </summary>
    let hasThingDescriptionAction =
        Namespaced_IRI.parse _namespace_name "hasThingDescriptionAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#isActionOf"></see>
    /// </summary>
    let isActionOf = Namespaced_IRI.parse _namespace_name "isActionOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasThingDescriptionEvent"></see>
    /// </summary>
    let hasThingDescriptionEvent =
        Namespaced_IRI.parse _namespace_name "hasThingDescriptionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#isEventOf"></see>
    /// </summary>
    let isEventOf = Namespaced_IRI.parse _namespace_name "isEventOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasThingDescriptionProperty"></see>
    /// </summary>
    let hasThingDescriptionProperty =
        Namespaced_IRI.parse _namespace_name "hasThingDescriptionProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#isPropertyOf"></see>
    /// </summary>
    let isPropertyOf =
        Namespaced_IRI.parse _namespace_name "isPropertyOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasTotalSpace"></see>
    /// </summary>
    let hasTotalSpace =
        Namespaced_IRI.parse _namespace_name "hasTotalSpace" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasZipCode"></see>
    /// </summary>
    let hasZipCode = Namespaced_IRI.parse _namespace_name "hasZipCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#isMeasuredIn"></see>
    /// </summary>
    let isMeasuredIn =
        Namespaced_IRI.parse _namespace_name "isMeasuredIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#isUnitOfMeasurementOf"></see>
    /// </summary>
    let isUnitOfMeasurementOf =
        Namespaced_IRI.parse _namespace_name "isUnitOfMeasurementOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#kilowatt-hour"></see>
    /// </summary>
    let ``kilowatt-hour`` =
        Namespaced_IRI.parse _namespace_name "kilowatt-hour" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#makesMeasurement"></see>
    /// </summary>
    let makesMeasurement =
        Namespaced_IRI.parse _namespace_name "makesMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#measurementMadeBy"></see>
    /// </summary>
    let measurementMadeBy =
        Namespaced_IRI.parse _namespace_name "measurementMadeBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#offersService"></see>
    /// </summary>
    let offersService =
        Namespaced_IRI.parse _namespace_name "offersService" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#serviceOfferedBy"></see>
    /// </summary>
    let serviceOfferedBy =
        Namespaced_IRI.parse _namespace_name "serviceOfferedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#watt-hour"></see>
    /// </summary>
    let ``watt-hour`` =
        Namespaced_IRI.parse _namespace_name "watt-hour" |> NamespacedName
