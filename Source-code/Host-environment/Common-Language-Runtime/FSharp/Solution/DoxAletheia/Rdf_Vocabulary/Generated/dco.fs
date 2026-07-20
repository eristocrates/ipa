namespace https.w3id.org.dco.hash

open DoxAletheia

module dco =
    let _namespace_name = "https://w3id.org/dco#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dco#hasSite"></see>
    /// </summary>
    let hasSite = _prefix "hasSite"
    /// <summary>
    ///   <see href="https://w3id.org/dco#dCOCoreModel"></see>
    /// </summary>
    let dCOCoreModel = _prefix "dCOCoreModel"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="https://w3id.org/dco#InteractionAffordance"></see>
    /// </summary>
    let InteractionAffordance = _prefix "InteractionAffordance"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ActiveEnergy"></see>
    /// </summary>
    let ActiveEnergy = _prefix "ActiveEnergy"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyProperty"></see>
    /// </summary>
    let EnergyProperty = _prefix "EnergyProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ActiveEnergyExport"></see>
    /// </summary>
    let ActiveEnergyExport = _prefix "ActiveEnergyExport"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ActiveEnergyImport"></see>
    /// </summary>
    let ActiveEnergyImport = _prefix "ActiveEnergyImport"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ActivePower"></see>
    /// </summary>
    let ActivePower = _prefix "ActivePower"
    /// <summary>
    ///   <see href="https://w3id.org/dco#PowerProperty"></see>
    /// </summary>
    let PowerProperty = _prefix "PowerProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ActivePowerExport"></see>
    /// </summary>
    let ActivePowerExport = _prefix "ActivePowerExport"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ActivePowerImport"></see>
    /// </summary>
    let ActivePowerImport = _prefix "ActivePowerImport"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ActualPower"></see>
    /// </summary>
    let ActualPower = _prefix "ActualPower"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Actuator"></see>
    /// </summary>
    let Actuator = _prefix "Actuator"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Relay"></see>
    /// </summary>
    let Relay = _prefix "Relay"
    /// <summary>
    ///   <see href="https://w3id.org/dco#AmbientHumidity"></see>
    /// </summary>
    let AmbientHumidity = _prefix "AmbientHumidity"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HumidityProperty"></see>
    /// </summary>
    let HumidityProperty = _prefix "HumidityProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#AmbientSensor"></see>
    /// </summary>
    let AmbientSensor = _prefix "AmbientSensor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Sensor"></see>
    /// </summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#AmbientTemperature"></see>
    /// </summary>
    let AmbientTemperature = _prefix "AmbientTemperature"
    /// <summary>
    ///   <see href="https://w3id.org/dco#TemperatureProperty"></see>
    /// </summary>
    let TemperatureProperty = _prefix "TemperatureProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Amperage"></see>
    /// </summary>
    let Amperage = _prefix "Amperage"
    /// <summary>
    ///   <see href="https://w3id.org/dco#AmperageProperty"></see>
    /// </summary>
    let AmperageProperty = _prefix "AmperageProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#AmperageClamp1"></see>
    /// </summary>
    let AmperageClamp1 = _prefix "AmperageClamp1"
    /// <summary>
    ///   <see href="https://w3id.org/dco#AmperageClamp2"></see>
    /// </summary>
    let AmperageClamp2 = _prefix "AmperageClamp2"
    /// <summary>
    ///   <see href="https://w3id.org/dco#AmperageClamp3"></see>
    /// </summary>
    let AmperageClamp3 = _prefix "AmperageClamp3"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Property"></see>
    /// </summary>
    let Property = _prefix "Property"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Ampere"></see>
    /// </summary>
    let Ampere = _prefix "Ampere"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ElectricUnit"></see>
    /// </summary>
    let ElectricUnit = _prefix "ElectricUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Apartment"></see>
    /// </summary>
    let Apartment = _prefix "Apartment"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Space"></see>
    /// </summary>
    let Space = _prefix "Space"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Appliance"></see>
    /// </summary>
    let Appliance = _prefix "Appliance"
    /// <summary>
    ///   <see href="https://w3id.org/dco#AreaUnit"></see>
    /// </summary>
    let AreaUnit = _prefix "AreaUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#UnitsOfMeasurements"></see>
    /// </summary>
    let UnitsOfMeasurements = _prefix "UnitsOfMeasurements"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Bathroom"></see>
    /// </summary>
    let Bathroom = _prefix "Bathroom"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Room"></see>
    /// </summary>
    let Room = _prefix "Room"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BatteryLevel"></see>
    /// </summary>
    let BatteryLevel = _prefix "BatteryLevel"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BatteryProperty"></see>
    /// </summary>
    let BatteryProperty = _prefix "BatteryProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Bedroom"></see>
    /// </summary>
    let Bedroom = _prefix "Bedroom"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Building"></see>
    /// </summary>
    let Building = _prefix "Building"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingAddress"></see>
    /// </summary>
    let BuildingAddress = _prefix "BuildingAddress"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingMetadata"></see>
    /// </summary>
    let BuildingMetadata = _prefix "BuildingMetadata"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingCity"></see>
    /// </summary>
    let BuildingCity = _prefix "BuildingCity"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingConstructionYear"></see>
    /// </summary>
    let BuildingConstructionYear = _prefix "BuildingConstructionYear"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingHeatedSurface"></see>
    /// </summary>
    let BuildingHeatedSurface = _prefix "BuildingHeatedSurface"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingLivingArea"></see>
    /// </summary>
    let BuildingLivingArea = _prefix "BuildingLivingArea"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingModel"></see>
    /// </summary>
    let BuildingModel = _prefix "BuildingModel"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingName"></see>
    /// </summary>
    let BuildingName = _prefix "BuildingName"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingNumberOfInhabitants"></see>
    /// </summary>
    let BuildingNumberOfInhabitants = _prefix "BuildingNumberOfInhabitants"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingRenovationDate"></see>
    /// </summary>
    let BuildingRenovationDate = _prefix "BuildingRenovationDate"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingTopology"></see>
    /// </summary>
    let BuildingTopology = _prefix "BuildingTopology"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingTotalSpace"></see>
    /// </summary>
    let BuildingTotalSpace = _prefix "BuildingTotalSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BuildingType"></see>
    /// </summary>
    let BuildingType = _prefix "BuildingType"
    /// <summary>
    ///   <see href="https://w3id.org/dco#BusinessBuilding"></see>
    /// </summary>
    let BusinessBuilding = _prefix "BusinessBuilding"
    /// <summary>
    ///   <see href="https://w3id.org/dco#CO2Concentration"></see>
    /// </summary>
    let CO2Concentration = _prefix "CO2Concentration"
    /// <summary>
    ///   <see href="https://w3id.org/dco#CarbonDioxideProperty"></see>
    /// </summary>
    let CarbonDioxideProperty = _prefix "CarbonDioxideProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Celsius"></see>
    /// </summary>
    let Celsius = _prefix "Celsius"
    /// <summary>
    ///   <see href="https://w3id.org/dco#TemperatureUnit"></see>
    /// </summary>
    let TemperatureUnit = _prefix "TemperatureUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#CloseState"></see>
    /// </summary>
    let CloseState = _prefix "CloseState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#OpenCloseState"></see>
    /// </summary>
    let OpenCloseState = _prefix "OpenCloseState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ClosedLoopEnergyEfficiencyService"></see>
    /// </summary>
    let ClosedLoopEnergyEfficiencyService = _prefix "ClosedLoopEnergyEfficiencyService"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Controller"></see>
    /// </summary>
    let Controller = _prefix "Controller"
    /// <summary>
    ///   <see href="https://w3id.org/dco#CubicMeter"></see>
    /// </summary>
    let CubicMeter = _prefix "CubicMeter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#VolumeUnit"></see>
    /// </summary>
    let VolumeUnit = _prefix "VolumeUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#CubicMeterPerHour"></see>
    /// </summary>
    let CubicMeterPerHour = _prefix "CubicMeterPerHour"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DefineTemperatureSetpoint"></see>
    /// </summary>
    let DefineTemperatureSetpoint = _prefix "DefineTemperatureSetpoint"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DesiredValveOpening"></see>
    /// </summary>
    let DesiredValveOpening = _prefix "DesiredValveOpening"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveProperty"></see>
    /// </summary>
    let ValveProperty = _prefix "ValveProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceIdentifier"></see>
    /// </summary>
    let DeviceIdentifier = _prefix "DeviceIdentifier"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceMetadata"></see>
    /// </summary>
    let DeviceMetadata = _prefix "DeviceMetadata"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceManifucturer"></see>
    /// </summary>
    let DeviceManifucturer = _prefix "DeviceManifucturer"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceMaximumDisabledTime"></see>
    /// </summary>
    let DeviceMaximumDisabledTime = _prefix "DeviceMaximumDisabledTime"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceMaximumPower"></see>
    /// </summary>
    let DeviceMaximumPower = _prefix "DeviceMaximumPower"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceMinimumEnabledTime"></see>
    /// </summary>
    let DeviceMinimumEnabledTime = _prefix "DeviceMinimumEnabledTime"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceSerialNumber"></see>
    /// </summary>
    let DeviceSerialNumber = _prefix "DeviceSerialNumber"
    /// <summary>
    ///   <see href="https://w3id.org/dco#DeviceSoftwareVersion"></see>
    /// </summary>
    let DeviceSoftwareVersion = _prefix "DeviceSoftwareVersion"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EVChargingAppliance"></see>
    /// </summary>
    let EVChargingAppliance = _prefix "EVChargingAppliance"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyClamp1"></see>
    /// </summary>
    let EnergyClamp1 = _prefix "EnergyClamp1"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyClamp2"></see>
    /// </summary>
    let EnergyClamp2 = _prefix "EnergyClamp2"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyClamp3"></see>
    /// </summary>
    let EnergyClamp3 = _prefix "EnergyClamp3"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyFlow"></see>
    /// </summary>
    let EnergyFlow = _prefix "EnergyFlow"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyMeter"></see>
    /// </summary>
    let EnergyMeter = _prefix "EnergyMeter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Meter"></see>
    /// </summary>
    let Meter = _prefix "Meter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyQuadrant1"></see>
    /// </summary>
    let EnergyQuadrant1 = _prefix "EnergyQuadrant1"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyQuadrant2"></see>
    /// </summary>
    let EnergyQuadrant2 = _prefix "EnergyQuadrant2"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyQuadrant3"></see>
    /// </summary>
    let EnergyQuadrant3 = _prefix "EnergyQuadrant3"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyQuadrant4"></see>
    /// </summary>
    let EnergyQuadrant4 = _prefix "EnergyQuadrant4"
    /// <summary>
    ///   <see href="https://w3id.org/dco#EnergyUnit"></see>
    /// </summary>
    let EnergyUnit = _prefix "EnergyUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ExportedEnergy"></see>
    /// </summary>
    let ExportedEnergy = _prefix "ExportedEnergy"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ExportedEnergyWithPricing1"></see>
    /// </summary>
    let ExportedEnergyWithPricing1 = _prefix "ExportedEnergyWithPricing1"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ExportedEnergyWithPricing2"></see>
    /// </summary>
    let ExportedEnergyWithPricing2 = _prefix "ExportedEnergyWithPricing2"
    /// <summary>
    ///   <see href="https://w3id.org/dco#FeatureOfInterest"></see>
    /// </summary>
    let FeatureOfInterest = _prefix "FeatureOfInterest"
    /// <summary>
    ///   <see href="https://w3id.org/dco#FeatureProperty"></see>
    /// </summary>
    let FeatureProperty = _prefix "FeatureProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#FlexibilityService"></see>
    /// </summary>
    let FlexibilityService = _prefix "FlexibilityService"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Floor"></see>
    /// </summary>
    let Floor = _prefix "Floor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#GasBoiler"></see>
    /// </summary>
    let GasBoiler = _prefix "GasBoiler"
    /// <summary>
    ///   <see href="https://w3id.org/dco#GasBoilerActuator"></see>
    /// </summary>
    let GasBoilerActuator = _prefix "GasBoilerActuator"
    /// <summary>
    ///   <see href="https://w3id.org/dco#GasMeter"></see>
    /// </summary>
    let GasMeter = _prefix "GasMeter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Gateway"></see>
    /// </summary>
    let Gateway = _prefix "Gateway"
    /// <summary>
    ///   <see href="https://w3id.org/dco#GetTemperatureSetpoint"></see>
    /// </summary>
    let GetTemperatureSetpoint = _prefix "GetTemperatureSetpoint"
    /// <summary>
    ///   <see href="https://w3id.org/dco#GetValveOpeningPercentage"></see>
    /// </summary>
    let GetValveOpeningPercentage = _prefix "GetValveOpeningPercentage"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatMeter"></see>
    /// </summary>
    let HeatMeter = _prefix "HeatMeter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatPumpAppliance"></see>
    /// </summary>
    let HeatPumpAppliance = _prefix "HeatPumpAppliance"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatPumpRelay"></see>
    /// </summary>
    let HeatPumpRelay = _prefix "HeatPumpRelay"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HeaterMaximalPower"></see>
    /// </summary>
    let HeaterMaximalPower = _prefix "HeaterMaximalPower"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HeaterMinimumPower"></see>
    /// </summary>
    let HeaterMinimumPower = _prefix "HeaterMinimumPower"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatingActuator"></see>
    /// </summary>
    let HeatingActuator = _prefix "HeatingActuator"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HeatingService"></see>
    /// </summary>
    let HeatingService = _prefix "HeatingService"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HotWaterProductionService"></see>
    /// </summary>
    let HotWaterProductionService = _prefix "HotWaterProductionService"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HouseholdType"></see>
    /// </summary>
    let HouseholdType = _prefix "HouseholdType"
    /// <summary>
    ///   <see href="https://w3id.org/dco#HumiditySensor"></see>
    /// </summary>
    let HumiditySensor = _prefix "HumiditySensor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ImportedEnergy"></see>
    /// </summary>
    let ImportedEnergy = _prefix "ImportedEnergy"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ImportedEnergyWithPricing1"></see>
    /// </summary>
    let ImportedEnergyWithPricing1 = _prefix "ImportedEnergyWithPricing1"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ImportedEnergyWithPricing2"></see>
    /// </summary>
    let ImportedEnergyWithPricing2 = _prefix "ImportedEnergyWithPricing2"
    /// <summary>
    ///   <see href="https://w3id.org/dco#IndustrialBuilding"></see>
    /// </summary>
    let IndustrialBuilding = _prefix "IndustrialBuilding"
    /// <summary>
    ///   <see href="https://w3id.org/dco#IntelTemperature"></see>
    /// </summary>
    let IntelTemperature = _prefix "IntelTemperature"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ThingDescriptionModel"></see>
    /// </summary>
    let ThingDescriptionModel = _prefix "ThingDescriptionModel"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Kitchen"></see>
    /// </summary>
    let Kitchen = _prefix "Kitchen"
    /// <summary>
    ///   <see href="https://w3id.org/dco#LivingRoom"></see>
    /// </summary>
    let LivingRoom = _prefix "LivingRoom"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Lobby"></see>
    /// </summary>
    let Lobby = _prefix "Lobby"
    /// <summary>
    ///   <see href="https://w3id.org/dco#MagnetSensor"></see>
    /// </summary>
    let MagnetSensor = _prefix "MagnetSensor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#MeasureTimeStamp"></see>
    /// </summary>
    let MeasureTimeStamp = _prefix "MeasureTimeStamp"
    /// <summary>
    ///   <see href="https://w3id.org/dco#MeasuredValveOpening"></see>
    /// </summary>
    let MeasuredValveOpening = _prefix "MeasuredValveOpening"
    /// <summary>
    ///   <see href="https://w3id.org/dco#MultiFamilyHouse"></see>
    /// </summary>
    let MultiFamilyHouse = _prefix "MultiFamilyHouse"
    /// <summary>
    ///   <see href="https://w3id.org/dco#OffAction"></see>
    /// </summary>
    let OffAction = _prefix "OffAction"
    /// <summary>
    ///   <see href="https://w3id.org/dco#OffState"></see>
    /// </summary>
    let OffState = _prefix "OffState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#OnOffState"></see>
    /// </summary>
    let OnOffState = _prefix "OnOffState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#OnAction"></see>
    /// </summary>
    let OnAction = _prefix "OnAction"
    /// <summary>
    ///   <see href="https://w3id.org/dco#State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="https://w3id.org/dco#OnState"></see>
    /// </summary>
    let OnState = _prefix "OnState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#OpenState"></see>
    /// </summary>
    let OpenState = _prefix "OpenState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#OutdoorTemperature"></see>
    /// </summary>
    let OutdoorTemperature = _prefix "OutdoorTemperature"
    /// <summary>
    ///   <see href="https://w3id.org/dco#PartsPerMillion"></see>
    /// </summary>
    let PartsPerMillion = _prefix "PartsPerMillion"
    /// <summary>
    ///   <see href="https://w3id.org/dco#PartsPerNotationUnit"></see>
    /// </summary>
    let PartsPerNotationUnit = _prefix "PartsPerNotationUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Percentage"></see>
    /// </summary>
    let Percentage = _prefix "Percentage"
    /// <summary>
    ///   <see href="https://w3id.org/dco#PercentageUnit"></see>
    /// </summary>
    let PercentageUnit = _prefix "PercentageUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#PipeTemperature"></see>
    /// </summary>
    let PipeTemperature = _prefix "PipeTemperature"
    /// <summary>
    ///   <see href="https://w3id.org/dco#PowerMeter"></see>
    /// </summary>
    let PowerMeter = _prefix "PowerMeter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#PowerUnit"></see>
    /// </summary>
    let PowerUnit = _prefix "PowerUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ReactiveEnergy"></see>
    /// </summary>
    let ReactiveEnergy = _prefix "ReactiveEnergy"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ReactivePower"></see>
    /// </summary>
    let ReactivePower = _prefix "ReactivePower"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ReactivePowerExport"></see>
    /// </summary>
    let ReactivePowerExport = _prefix "ReactivePowerExport"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ReactivePowerImport"></see>
    /// </summary>
    let ReactivePowerImport = _prefix "ReactivePowerImport"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ResidentialBuilding"></see>
    /// </summary>
    let ResidentialBuilding = _prefix "ResidentialBuilding"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ReturnTemperatureSensor"></see>
    /// </summary>
    let ReturnTemperatureSensor = _prefix "ReturnTemperatureSensor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Setpoint"></see>
    /// </summary>
    let Setpoint = _prefix "Setpoint"
    /// <summary>
    ///   <see href="https://w3id.org/dco#SingleFamilyHouse"></see>
    /// </summary>
    let SingleFamilyHouse = _prefix "SingleFamilyHouse"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Site"></see>
    /// </summary>
    let Site = _prefix "Site"
    /// <summary>
    ///   <see href="https://w3id.org/dco#SmartMeter"></see>
    /// </summary>
    let SmartMeter = _prefix "SmartMeter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#SolarPanelsAppliance"></see>
    /// </summary>
    let SolarPanelsAppliance = _prefix "SolarPanelsAppliance"
    /// <summary>
    ///   <see href="https://w3id.org/dco#SquareMeter"></see>
    /// </summary>
    let SquareMeter = _prefix "SquareMeter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#StartState"></see>
    /// </summary>
    let StartState = _prefix "StartState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#StartStopState"></see>
    /// </summary>
    let StartStopState = _prefix "StartStopState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#StopState"></see>
    /// </summary>
    let StopState = _prefix "StopState"
    /// <summary>
    ///   <see href="https://w3id.org/dco#SupplyTemperatureSensor"></see>
    /// </summary>
    let SupplyTemperatureSensor = _prefix "SupplyTemperatureSensor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#TankTemperature"></see>
    /// </summary>
    let TankTemperature = _prefix "TankTemperature"
    /// <summary>
    ///   <see href="https://w3id.org/dco#TemperatureSensor"></see>
    /// </summary>
    let TemperatureSensor = _prefix "TemperatureSensor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#TemperatureSetpoint"></see>
    /// </summary>
    let TemperatureSetpoint = _prefix "TemperatureSetpoint"
    /// <summary>
    ///   <see href="https://w3id.org/dco#TertiaryBuilding"></see>
    /// </summary>
    let TertiaryBuilding = _prefix "TertiaryBuilding"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Thermostat"></see>
    /// </summary>
    let Thermostat = _prefix "Thermostat"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ThermostaticValveActuator"></see>
    /// </summary>
    let ThermostaticValveActuator = _prefix "ThermostaticValveActuator"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ToggleAction"></see>
    /// </summary>
    let ToggleAction = _prefix "ToggleAction"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveActuator"></see>
    /// </summary>
    let ValveActuator = _prefix "ValveActuator"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveController"></see>
    /// </summary>
    let ValveController = _prefix "ValveController"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveMaximumOpening"></see>
    /// </summary>
    let ValveMaximumOpening = _prefix "ValveMaximumOpening"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveMaximumTemperature"></see>
    /// </summary>
    let ValveMaximumTemperature = _prefix "ValveMaximumTemperature"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveMinimumOpening"></see>
    /// </summary>
    let ValveMinimumOpening = _prefix "ValveMinimumOpening"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ValveMinimumTemperature"></see>
    /// </summary>
    let ValveMinimumTemperature = _prefix "ValveMinimumTemperature"
    /// <summary>
    ///   <see href="https://w3id.org/dco#ValvePosition"></see>
    /// </summary>
    let ValvePosition = _prefix "ValvePosition"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Volt-ampereReactive"></see>
    /// </summary>
    let ``Volt-ampereReactive`` = _prefix "Volt-ampereReactive"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Voltage"></see>
    /// </summary>
    let Voltage = _prefix "Voltage"
    /// <summary>
    ///   <see href="https://w3id.org/dco#VoltageProperty"></see>
    /// </summary>
    let VoltageProperty = _prefix "VoltageProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#VoltageClamp1"></see>
    /// </summary>
    let VoltageClamp1 = _prefix "VoltageClamp1"
    /// <summary>
    ///   <see href="https://w3id.org/dco#VoltageClamp2"></see>
    /// </summary>
    let VoltageClamp2 = _prefix "VoltageClamp2"
    /// <summary>
    ///   <see href="https://w3id.org/dco#VoltageClamp3"></see>
    /// </summary>
    let VoltageClamp3 = _prefix "VoltageClamp3"
    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterFlow"></see>
    /// </summary>
    let WaterFlow = _prefix "WaterFlow"
    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterProperty"></see>
    /// </summary>
    let WaterProperty = _prefix "WaterProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterFlowMeter"></see>
    /// </summary>
    let WaterFlowMeter = _prefix "WaterFlowMeter"
    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterTemperature"></see>
    /// </summary>
    let WaterTemperature = _prefix "WaterTemperature"
    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterTemperatureSensor"></see>
    /// </summary>
    let WaterTemperatureSensor = _prefix "WaterTemperatureSensor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#WaterVolume"></see>
    /// </summary>
    let WaterVolume = _prefix "WaterVolume"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Watt"></see>
    /// </summary>
    let Watt = _prefix "Watt"
    /// <summary>
    ///   <see href="https://w3id.org/dco#WattHourBasedUnit"></see>
    /// </summary>
    let WattHourBasedUnit = _prefix "WattHourBasedUnit"
    /// <summary>
    ///   <see href="https://w3id.org/dco#WoTThing"></see>
    /// </summary>
    let WoTThing = _prefix "WoTThing"
    /// <summary>
    ///   <see href="https://w3id.org/dco#Zone"></see>
    /// </summary>
    let Zone = _prefix "Zone"
    /// <summary>
    ///   <see href="https://w3id.org/dco#buildingZipCode"></see>
    /// </summary>
    let buildingZipCode = _prefix "buildingZipCode"
    /// <summary>
    ///   <see href="https://w3id.org/dco#consitsOf"></see>
    /// </summary>
    let consitsOf = _prefix "consitsOf"
    /// <summary>
    ///   <see href="https://w3id.org/dco#containsDevice"></see>
    /// </summary>
    let containsDevice = _prefix "containsDevice"
    /// <summary>
    ///   <see href="https://w3id.org/dco#isLocatedAt"></see>
    /// </summary>
    let isLocatedAt = _prefix "isLocatedAt"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasAddress"></see>
    /// </summary>
    let hasAddress = _prefix "hasAddress"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasApartment"></see>
    /// </summary>
    let hasApartment = _prefix "hasApartment"
    /// <summary>
    ///   <see href="https://w3id.org/dco#isApartmentOF"></see>
    /// </summary>
    let isApartmentOF = _prefix "isApartmentOF"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasBuilding"></see>
    /// </summary>
    let hasBuilding = _prefix "hasBuilding"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasCity"></see>
    /// </summary>
    let hasCity = _prefix "hasCity"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasConstructionYear"></see>
    /// </summary>
    let hasConstructionYear = _prefix "hasConstructionYear"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasFloor"></see>
    /// </summary>
    let hasFloor = _prefix "hasFloor"
    /// <summary>
    ///   <see href="https://w3id.org/dco#isFloorOf"></see>
    /// </summary>
    let isFloorOf = _prefix "isFloorOf"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasID"></see>
    /// </summary>
    let hasID = _prefix "hasID"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasNumberOfInhabitants"></see>
    /// </summary>
    let hasNumberOfInhabitants = _prefix "hasNumberOfInhabitants"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasRenovationDate"></see>
    /// </summary>
    let hasRenovationDate = _prefix "hasRenovationDate"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasSpace"></see>
    /// </summary>
    let hasSpace = _prefix "hasSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasThingDescriptionAction"></see>
    /// </summary>
    let hasThingDescriptionAction = _prefix "hasThingDescriptionAction"
    /// <summary>
    ///   <see href="https://w3id.org/dco#isActionOf"></see>
    /// </summary>
    let isActionOf = _prefix "isActionOf"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasThingDescriptionEvent"></see>
    /// </summary>
    let hasThingDescriptionEvent = _prefix "hasThingDescriptionEvent"
    /// <summary>
    ///   <see href="https://w3id.org/dco#isEventOf"></see>
    /// </summary>
    let isEventOf = _prefix "isEventOf"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasThingDescriptionProperty"></see>
    /// </summary>
    let hasThingDescriptionProperty = _prefix "hasThingDescriptionProperty"
    /// <summary>
    ///   <see href="https://w3id.org/dco#isPropertyOf"></see>
    /// </summary>
    let isPropertyOf = _prefix "isPropertyOf"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasTotalSpace"></see>
    /// </summary>
    let hasTotalSpace = _prefix "hasTotalSpace"
    /// <summary>
    ///   <see href="https://w3id.org/dco#hasZipCode"></see>
    /// </summary>
    let hasZipCode = _prefix "hasZipCode"
    /// <summary>
    ///   <see href="https://w3id.org/dco#isMeasuredIn"></see>
    /// </summary>
    let isMeasuredIn = _prefix "isMeasuredIn"
    /// <summary>
    ///   <see href="https://w3id.org/dco#isUnitOfMeasurementOf"></see>
    /// </summary>
    let isUnitOfMeasurementOf = _prefix "isUnitOfMeasurementOf"
    /// <summary>
    ///   <see href="https://w3id.org/dco#kilowatt-hour"></see>
    /// </summary>
    let ``kilowatt-hour`` = _prefix "kilowatt-hour"
    /// <summary>
    ///   <see href="https://w3id.org/dco#makesMeasurement"></see>
    /// </summary>
    let makesMeasurement = _prefix "makesMeasurement"
    /// <summary>
    ///   <see href="https://w3id.org/dco#measurementMadeBy"></see>
    /// </summary>
    let measurementMadeBy = _prefix "measurementMadeBy"
    /// <summary>
    ///   <see href="https://w3id.org/dco#offersService"></see>
    /// </summary>
    let offersService = _prefix "offersService"
    /// <summary>
    ///   <see href="https://w3id.org/dco#serviceOfferedBy"></see>
    /// </summary>
    let serviceOfferedBy = _prefix "serviceOfferedBy"
    /// <summary>
    ///   <see href="https://w3id.org/dco#watt-hour"></see>
    /// </summary>
    let ``watt-hour`` = _prefix "watt-hour"
