#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dco =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/dco#" "dco"
    /// <summary>
    ///   <para>skos:definition : An Interaction Affordance that allows to invoke a function of the Thing, which manipulates state (e.g., toggling a lamp on or off) or triggers a process on the Thing (e.g., dim a lamp over time).^^xsd:string</para>
    ///   <para>rdfs:label : Action^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Action">dco:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : Active energy^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ActiveEnergy">dco:ActiveEnergy</a>
    /// </summary>
    let ActiveEnergy = _prefixId.prefix "ActiveEnergy"
    /// <summary>
    ///   <para>rdfs:label : ActiveEnergyExport^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ActiveEnergyExport">dco:ActiveEnergyExport</a>
    /// </summary>
    let ActiveEnergyExport = _prefixId.prefix "ActiveEnergyExport"
    /// <summary>
    ///   <para>rdfs:label : Active energy import^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ActiveEnergyImport">dco:ActiveEnergyImport</a>
    /// </summary>
    let ActiveEnergyImport = _prefixId.prefix "ActiveEnergyImport"
    /// <summary>
    ///   <para>skos:definition : The power which is actually consumed or utilised in an AC Circuit is called True power or Active power or Real power. It is measured in kilowatt (kW) or MW. It is the actual outcomes of the electrical system which runs the electric circuits or load.^^xsd:string</para>
    ///   <para>rdfs:label : Active power^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ActivePower">dco:ActivePower</a>
    /// </summary>
    let ActivePower = _prefixId.prefix "ActivePower"
    /// <summary>
    ///   <para>rdfs:label : Active power export^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ActivePowerExport">dco:ActivePowerExport</a>
    /// </summary>
    let ActivePowerExport = _prefixId.prefix "ActivePowerExport"
    /// <summary>
    ///   <para>rdfs:label : Active power import^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ActivePowerImport">dco:ActivePowerImport</a>
    /// </summary>
    let ActivePowerImport = _prefixId.prefix "ActivePowerImport"
    /// <summary>
    ///   <para>skos:definition : A property related to some measurements that are characterized by a certain value that is measured in a power unit (such as watt or kilowatt).^^xsd:string</para>
    ///   <para>rdfs:label : Actual Power^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ActualPower">dco:ActualPower</a>
    /// </summary>
    let ActualPower = _prefixId.prefix "ActualPower"
    /// <summary>
    ///   <para>skos:definition : A device that is used by, or implements, an (Actuation) Procedure that changes the state of the world.^^xsd:string</para>
    ///   <para>rdfs:label : Actuator^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Actuator">dco:Actuator</a>
    /// </summary>
    let Actuator = _prefixId.prefix "Actuator"
    /// <summary>
    ///   <para>skos:definition : Property of the environment indicating the humidity.^^xsd:string</para>
    ///   <para>rdfs:label : Ambient Humidity^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#AmbientHumidity">dco:AmbientHumidity</a>
    /// </summary>
    let AmbientHumidity = _prefixId.prefix "AmbientHumidity"
    /// <summary>
    ///   <para>skos:definition : The Ambient sensor can measure the ambient temperature and humidity^^xsd:string</para>
    ///   <para>rdfs:label : Ambient Sensor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#AmbientSensor">dco:AmbientSensor</a>
    /// </summary>
    let AmbientSensor = _prefixId.prefix "AmbientSensor"
    /// <summary>
    ///   <para>rdfs:label : Ambient temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#AmbientTemperature">dco:AmbientTemperature</a>
    /// </summary>
    let AmbientTemperature = _prefixId.prefix "AmbientTemperature"
    /// <summary>
    ///   <para>rdfs:label : Amperage^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Amperage">dco:Amperage</a>
    /// </summary>
    let Amperage = _prefixId.prefix "Amperage"
    /// <summary>
    ///   <para>rdfs:label : Amperage clamp 1^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#AmperageClamp1">dco:AmperageClamp1</a>
    /// </summary>
    let AmperageClamp1 = _prefixId.prefix "AmperageClamp1"
    /// <summary>
    ///   <para>rdfs:label : Amperage clamp 2^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#AmperageClamp2">dco:AmperageClamp2</a>
    /// </summary>
    let AmperageClamp2 = _prefixId.prefix "AmperageClamp2"
    /// <summary>
    ///   <para>rdfs:label : Amperage clamp 3^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#AmperageClamp3">dco:AmperageClamp3</a>
    /// </summary>
    let AmperageClamp3 = _prefixId.prefix "AmperageClamp3"
    /// <summary>
    ///   <para>rdfs:label : Amperage property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#AmperageProperty">dco:AmperageProperty</a>
    /// </summary>
    let AmperageProperty = _prefixId.prefix "AmperageProperty"
    /// <summary>
    ///   <para>rdfs:label : Ampere^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Ampere">dco:Ampere</a>
    /// </summary>
    let Ampere = _prefixId.prefix "Ampere"
    /// <summary>
    ///   <para>rdfs:label : Apartment^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Apartment">dco:Apartment</a>
    /// </summary>
    let Apartment = _prefixId.prefix "Apartment"
    /// <summary>
    ///   <para>skos:definition : An electrical/mechanical machine that accomplish some household functions, such as cleaning or cooking.^^xsd:string</para>
    ///   <para>rdfs:label : Appliance^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Appliance">dco:Appliance</a>
    /// </summary>
    let Appliance = _prefixId.prefix "Appliance"
    /// <summary>
    ///   <para>skos:definition : "An area unit which is equal to an area enclosed by a square with sides each 1 meter long." [NIST:NIST]^^xsd:string</para>
    ///   <para>rdfs:label : Area unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#AreaUnit">dco:AreaUnit</a>
    /// </summary>
    let AreaUnit = _prefixId.prefix "AreaUnit"
    /// <summary>
    ///   <para>rdfs:label : Bathroom^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Bathroom">dco:Bathroom</a>
    /// </summary>
    let Bathroom = _prefixId.prefix "Bathroom"
    /// <summary>
    ///   <para>skos:definition : The level of remaining battery (if any : in percent) for a device.^^xsd:string</para>
    ///   <para>rdfs:label : Battery level^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BatteryLevel">dco:BatteryLevel</a>
    /// </summary>
    let BatteryLevel = _prefixId.prefix "BatteryLevel"
    /// <summary>
    ///   <para>rdfs:label : Battery Property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BatteryProperty">dco:BatteryProperty</a>
    /// </summary>
    let BatteryProperty = _prefixId.prefix "BatteryProperty"
    /// <summary>
    ///   <para>rdfs:label : Bedroom^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Bedroom">dco:Bedroom</a>
    /// </summary>
    let Bedroom = _prefixId.prefix "Bedroom"
    /// <summary>
    ///   <para>skos:definition : A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space). The basement floor of a building is floor number 0.^^xsd:string</para>
    ///   <para>rdfs:label : Building^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Building">dco:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>skos:definition : Represent the address of the building^^xsd:string</para>
    ///   <para>rdfs:label : Building address^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingAddress">dco:BuildingAddress</a>
    /// </summary>
    let BuildingAddress = _prefixId.prefix "BuildingAddress"
    /// <summary>
    ///   <para>skos:definition : Represent the city of where the building is located^^xsd:string</para>
    ///   <para>rdfs:label : Building city^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingCity">dco:BuildingCity</a>
    /// </summary>
    let BuildingCity = _prefixId.prefix "BuildingCity"
    /// <summary>
    ///   <para>rdfs:label : Building construction year^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingConstructionYear">dco:BuildingConstructionYear</a>
    /// </summary>
    let BuildingConstructionYear = _prefixId.prefix "BuildingConstructionYear"
    /// <summary>
    ///   <para>skos:definition : Represent the total heated surface of a building.^^xsd:string</para>
    ///   <para>rdfs:label : Building heated surface^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingHeatedSurface">dco:BuildingHeatedSurface</a>
    /// </summary>
    let BuildingHeatedSurface = _prefixId.prefix "BuildingHeatedSurface"
    /// <summary>
    ///   <para>skos:definition : Represent the total living area of a building. This can me measured in square meter.^^xsd:string</para>
    ///   <para>rdfs:label : Building living area^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingLivingArea">dco:BuildingLivingArea</a>
    /// </summary>
    let BuildingLivingArea = _prefixId.prefix "BuildingLivingArea"
    /// <summary>
    ///   <para>rdfs:label : Building metadata^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingMetadata">dco:BuildingMetadata</a>
    /// </summary>
    let BuildingMetadata = _prefixId.prefix "BuildingMetadata"
    /// <summary>
    ///   <para>rdfs:label : Building model^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingModel">dco:BuildingModel</a>
    /// </summary>
    let BuildingModel = _prefixId.prefix "BuildingModel"
    /// <summary>
    ///   <para>rdfs:label : Building Name^^xsd:string</para>
    ///   <para>dce:description : Represent the given name of a building.^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingName">dco:BuildingName</a>
    /// </summary>
    let BuildingName = _prefixId.prefix "BuildingName"
    /// <summary>
    ///   <para>rdfs:label : Building number of inhabitants^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingNumberOfInhabitants">dco:BuildingNumberOfInhabitants</a>
    /// </summary>
    let BuildingNumberOfInhabitants = _prefixId.prefix "BuildingNumberOfInhabitants"
    /// <summary>
    ///   <para>skos:definition : Represent the date of renovation of a building.^^xsd:string</para>
    ///   <para>rdfs:label : Building renovation date^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingRenovationDate">dco:BuildingRenovationDate</a>
    /// </summary>
    let BuildingRenovationDate = _prefixId.prefix "BuildingRenovationDate"
    /// <summary>
    ///   <para>rdfs:label : Building topology^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingTopology">dco:BuildingTopology</a>
    /// </summary>
    let BuildingTopology = _prefixId.prefix "BuildingTopology"
    /// <summary>
    ///   <para>skos:definition : Represent the total space of a building measured in meter square.^^xsd:string</para>
    ///   <para>rdfs:label : Building total space^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingTotalSpace">dco:BuildingTotalSpace</a>
    /// </summary>
    let BuildingTotalSpace = _prefixId.prefix "BuildingTotalSpace"
    /// <summary>
    ///   <para>skos:definition : Represent the type of building (e.g., residential Buildings, educational buildings, institutional buildings)^^xsd:string</para>
    ///   <para>rdfs:label : Building type^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BuildingType">dco:BuildingType</a>
    /// </summary>
    let BuildingType = _prefixId.prefix "BuildingType"
    /// <summary>
    ///   <para>rdfs:label : Business building^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#BusinessBuilding">dco:BusinessBuilding</a>
    /// </summary>
    let BusinessBuilding = _prefixId.prefix "BusinessBuilding"
    /// <summary>
    ///   <para>skos:definition : A property representing the carbon dioxide concentration that can be measured in "ppm".^^xsd:string</para>
    ///   <para>rdfs:label : CO2 concentration^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#CO2Concentration">dco:CO2Concentration</a>
    /// </summary>
    let CO2Concentration = _prefixId.prefix "CO2Concentration"
    /// <summary>
    ///   <para>rdfs:label : Carbon dioxide property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#CarbonDioxideProperty">dco:CarbonDioxideProperty</a>
    /// </summary>
    let CarbonDioxideProperty = _prefixId.prefix "CarbonDioxideProperty"
    /// <summary>
    ///   <para>skos:definition : "A temperature unit which is equal to one kelvin degree. However, they have their zeros at different points. The centigrade scale has its zero at 273.15 K." [NIST:NIST]^^xsd:string</para>
    ///   <para>rdfs:label : Celsius^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Celsius">dco:Celsius</a>
    /// </summary>
    let Celsius = _prefixId.prefix "Celsius"
    /// <summary>
    ///   <para>rdfs:label : Close state^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#CloseState">dco:CloseState</a>
    /// </summary>
    let CloseState = _prefixId.prefix "CloseState"

    /// <summary>
    ///   <para>skos:definition : Represent the service of closed loop energy efficiency.^^xsd:string</para>
    ///   <para>rdfs:label : Closed loop energy efficiency service^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ClosedLoopEnergyEfficiencyService">dco:ClosedLoopEnergyEfficiencyService</a>
    /// </summary>
    let ClosedLoopEnergyEfficiencyService =
        _prefixId.prefix "ClosedLoopEnergyEfficiencyService"

    /// <summary>
    ///   <para>skos:definition : A controller is a device that monitors inputs and controls outputs within a building automation system. A controller may be physical (having placement within a spatial structure) or logical (a software interface or aggregated within a programmable physical controller).^^xsd:string</para>
    ///   <para>rdfs:label : Controller^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Controller">dco:Controller</a>
    /// </summary>
    let Controller = _prefixId.prefix "Controller"
    /// <summary>
    ///   <para>skos:definition : "A volume unit which is equal to the volume of a cube with edges one meter in length. One cubic meter equals to 1000 liters." [NIST:NIST]^^xsd:string</para>
    ///   <para>rdfs:label : Cubic meter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#CubicMeter">dco:CubicMeter</a>
    /// </summary>
    let CubicMeter = _prefixId.prefix "CubicMeter"
    /// <summary>
    ///   <para>rdfs:label : Cubic meter per hour^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#CubicMeterPerHour">dco:CubicMeterPerHour</a>
    /// </summary>
    let CubicMeterPerHour = _prefixId.prefix "CubicMeterPerHour"
    /// <summary>
    ///   <para>rdfs:label : Define temperature setpoint^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DefineTemperatureSetpoint">dco:DefineTemperatureSetpoint</a>
    /// </summary>
    let DefineTemperatureSetpoint = _prefixId.prefix "DefineTemperatureSetpoint"
    /// <summary>
    ///   <para>skos:definition : Represent the desired valve opening.^^xsd:string</para>
    ///   <para>rdfs:label : Desired Valve opening^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DesiredValveOpening">dco:DesiredValveOpening</a>
    /// </summary>
    let DesiredValveOpening = _prefixId.prefix "DesiredValveOpening"
    /// <summary>
    ///   <para>rdfs:label : Device identifier^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DeviceIdentifier">dco:DeviceIdentifier</a>
    /// </summary>
    let DeviceIdentifier = _prefixId.prefix "DeviceIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Device Metadata^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DeviceManifucturer">dco:DeviceManifucturer</a>
    /// </summary>
    let DeviceManifucturer = _prefixId.prefix "DeviceManifucturer"
    /// <summary>
    ///   <para>skos:definition : Represent the maximum time that a device can be disabled in a household.^^xsd:string</para>
    ///   <para>rdfs:label : Device maximum disabled time^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DeviceMaximumDisabledTime">dco:DeviceMaximumDisabledTime</a>
    /// </summary>
    let DeviceMaximumDisabledTime = _prefixId.prefix "DeviceMaximumDisabledTime"
    /// <summary>
    ///   <para>skos:definition : Represent the maximum power that a device can support.^^xsd:string</para>
    ///   <para>rdfs:label : Device maximum power^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DeviceMaximumPower">dco:DeviceMaximumPower</a>
    /// </summary>
    let DeviceMaximumPower = _prefixId.prefix "DeviceMaximumPower"
    /// <summary>
    ///   <para>rdfs:label : Device metadata^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DeviceMetadata">dco:DeviceMetadata</a>
    /// </summary>
    let DeviceMetadata = _prefixId.prefix "DeviceMetadata"
    /// <summary>
    ///   <para>skos:definition : Represent the minimum time that an appliance should be working.^^xsd:string</para>
    ///   <para>rdfs:label : Device minimum enabled time^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DeviceMinimumEnabledTime">dco:DeviceMinimumEnabledTime</a>
    /// </summary>
    let DeviceMinimumEnabledTime = _prefixId.prefix "DeviceMinimumEnabledTime"
    /// <summary>
    ///   <para>rdfs:label : Device serial number^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DeviceSerialNumber">dco:DeviceSerialNumber</a>
    /// </summary>
    let DeviceSerialNumber = _prefixId.prefix "DeviceSerialNumber"
    /// <summary>
    ///   <para>rdfs:label : DeviceSoftwareVersion^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#DeviceSoftwareVersion">dco:DeviceSoftwareVersion</a>
    /// </summary>
    let DeviceSoftwareVersion = _prefixId.prefix "DeviceSoftwareVersion"
    /// <summary>
    ///   <para>skos:definition : Represent an electric vehicule charching appliance.^^xsd:string</para>
    ///   <para>rdfs:label : EV charging appliance^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EVChargingAppliance">dco:EVChargingAppliance</a>
    /// </summary>
    let EVChargingAppliance = _prefixId.prefix "EVChargingAppliance"
    /// <summary>
    ///   <para>rdfs:label : Electric unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ElectricUnit">dco:ElectricUnit</a>
    /// </summary>
    let ElectricUnit = _prefixId.prefix "ElectricUnit"
    /// <summary>
    ///   <para>rdfs:label : Energy clamp 1^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyClamp1">dco:EnergyClamp1</a>
    /// </summary>
    let EnergyClamp1 = _prefixId.prefix "EnergyClamp1"
    /// <summary>
    ///   <para>rdfs:label : Energy clamp 2^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyClamp2">dco:EnergyClamp2</a>
    /// </summary>
    let EnergyClamp2 = _prefixId.prefix "EnergyClamp2"
    /// <summary>
    ///   <para>rdfs:label : Energy Clamp 3^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyClamp3">dco:EnergyClamp3</a>
    /// </summary>
    let EnergyClamp3 = _prefixId.prefix "EnergyClamp3"
    /// <summary>
    ///   <para>rdfs:label : Energy flow^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyFlow">dco:EnergyFlow</a>
    /// </summary>
    let EnergyFlow = _prefixId.prefix "EnergyFlow"
    /// <summary>
    ///   <para>skos:definition : A device built to accurately detect and display energy in a form readable by machines.^^xsd:string</para>
    ///   <para>rdfs:label : Energy meter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyMeter">dco:EnergyMeter</a>
    /// </summary>
    let EnergyMeter = _prefixId.prefix "EnergyMeter"
    /// <summary>
    ///   <para>rdfs:label : Energy property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyProperty">dco:EnergyProperty</a>
    /// </summary>
    let EnergyProperty = _prefixId.prefix "EnergyProperty"
    /// <summary>
    ///   <para>skos:definition : Represent the quantity of energy from quadrant 1^^xsd:string</para>
    ///   <para>rdfs:label : Energy quadrant 1^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyQuadrant1">dco:EnergyQuadrant1</a>
    /// </summary>
    let EnergyQuadrant1 = _prefixId.prefix "EnergyQuadrant1"
    /// <summary>
    ///   <para>rdfs:label : Energy quadrant 2^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyQuadrant2">dco:EnergyQuadrant2</a>
    /// </summary>
    let EnergyQuadrant2 = _prefixId.prefix "EnergyQuadrant2"
    /// <summary>
    ///   <para>rdfs:label : Energy quadrant 3^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyQuadrant3">dco:EnergyQuadrant3</a>
    /// </summary>
    let EnergyQuadrant3 = _prefixId.prefix "EnergyQuadrant3"
    /// <summary>
    ///   <para>rdfs:label : Energy quadrant 4^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyQuadrant4">dco:EnergyQuadrant4</a>
    /// </summary>
    let EnergyQuadrant4 = _prefixId.prefix "EnergyQuadrant4"
    /// <summary>
    ///   <para>rdfs:label : Energy unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#EnergyUnit">dco:EnergyUnit</a>
    /// </summary>
    let EnergyUnit = _prefixId.prefix "EnergyUnit"
    /// <summary>
    ///   <para>skos:definition : An Interaction Affordance that describes an event source, which asynchronously pushes event data to Consumers (e.g., overheating alerts).^^xsd:string</para>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Event">dco:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Exported energy^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ExportedEnergy">dco:ExportedEnergy</a>
    /// </summary>
    let ExportedEnergy = _prefixId.prefix "ExportedEnergy"
    /// <summary>
    ///   <para>rdfs:label : Exported energy with pricing 1^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ExportedEnergyWithPricing1">dco:ExportedEnergyWithPricing1</a>
    /// </summary>
    let ExportedEnergyWithPricing1 = _prefixId.prefix "ExportedEnergyWithPricing1"
    /// <summary>
    ///   <para>rdfs:label : Exported energy with pricing 2^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ExportedEnergyWithPricing2">dco:ExportedEnergyWithPricing2</a>
    /// </summary>
    let ExportedEnergyWithPricing2 = _prefixId.prefix "ExportedEnergyWithPricing2"
    /// <summary>
    ///   <para>rdfs:label : Feature of interest^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#FeatureOfInterest">dco:FeatureOfInterest</a>
    /// </summary>
    let FeatureOfInterest = _prefixId.prefix "FeatureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : Feature property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#FeatureProperty">dco:FeatureProperty</a>
    /// </summary>
    let FeatureProperty = _prefixId.prefix "FeatureProperty"
    /// <summary>
    ///   <para>skos:definition : Represent the energy flexibility service.^^xsd:string</para>
    ///   <para>rdfs:label : Flexibility service^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#FlexibilityService">dco:FlexibilityService</a>
    /// </summary>
    let FlexibilityService = _prefixId.prefix "FlexibilityService"
    /// <summary>
    ///   <para>skos:definition : A part of the physical world or a virtual world that is inherently both located in this world and having a 3D spatial extent. A Storey is contained in one or more buildings, and is intended to contain one or more spaces that are horizontally connected. Storeys of a building are connected by means of vertical connections such as elevators and stairs. A bot:Storey encompasses both zones above and below ground, for example, a building with 21 floors above ground, one ground floor and 3 basements is equal to the sentence: A building has 25 instances of bot:Storey.^^xsd:string</para>
    ///   <para>rdfs:label : Floor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Floor">dco:Floor</a>
    /// </summary>
    let Floor = _prefixId.prefix "Floor"
    /// <summary>
    ///   <para>skos:definition : Gas boilers are used to provide hot water and heating to households.^^xsd:string</para>
    ///   <para>rdfs:label : Gas boiler^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#GasBoiler">dco:GasBoiler</a>
    /// </summary>
    let GasBoiler = _prefixId.prefix "GasBoiler"
    /// <summary>
    ///   <para>skos:definition : Represent the actuator of the gas boiler.^^xsd:string</para>
    ///   <para>rdfs:label : Gas boiler actuator^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#GasBoilerActuator">dco:GasBoilerActuator</a>
    /// </summary>
    let GasBoilerActuator = _prefixId.prefix "GasBoilerActuator"
    /// <summary>
    ///   <para>skos:definition : A gas meter is a specialized flow meter, used to measure the volume of fuel gases such as natural gas and liquefied petroleum gas. Gas meters are used at residential, commercial, and industrial buildings that consume fuel gas supplied by a gas utility^^xsd:string</para>
    ///   <para>rdfs:label : Gas meter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#GasMeter">dco:GasMeter</a>
    /// </summary>
    let GasMeter = _prefixId.prefix "GasMeter"
    /// <summary>
    ///   <para>rdfs:label : Gateway^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Gateway">dco:Gateway</a>
    /// </summary>
    let Gateway = _prefixId.prefix "Gateway"
    /// <summary>
    ///   <para>rdfs:label : Get temperature setpoint^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#GetTemperatureSetpoint">dco:GetTemperatureSetpoint</a>
    /// </summary>
    let GetTemperatureSetpoint = _prefixId.prefix "GetTemperatureSetpoint"
    /// <summary>
    ///   <para>rdfs:label : Get valve opening percentage^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#GetValveOpeningPercentage">dco:GetValveOpeningPercentage</a>
    /// </summary>
    let GetValveOpeningPercentage = _prefixId.prefix "GetValveOpeningPercentage"
    /// <summary>
    ///   <para>skos:definition : A heat meter is a device which measures thermal energy provided by a source or delivered to a sink, by measuring the flow rate of the heat transfer fluid and the change in its temperature (ΔT) between the outflow and return legs of the system.^^xsd:string</para>
    ///   <para>rdfs:label : Heat meter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HeatMeter">dco:HeatMeter</a>
    /// </summary>
    let HeatMeter = _prefixId.prefix "HeatMeter"
    /// <summary>
    ///   <para>skos:definition : A heat pump appliance is used to warm and sometimes also cool buildings by transferring thermal energy from a cooler space to a warmer space using the refrigeration cycle, being the opposite direction in which heat transfer would take place without the application of external power^^xsd:string</para>
    ///   <para>rdfs:label : Heat pump appliance^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HeatPumpAppliance">dco:HeatPumpAppliance</a>
    /// </summary>
    let HeatPumpAppliance = _prefixId.prefix "HeatPumpAppliance"
    /// <summary>
    ///   <para>skos:definition : Represent the replay of a heat pump.^^xsd:string</para>
    ///   <para>rdfs:label : Heat pump relay^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HeatPumpRelay">dco:HeatPumpRelay</a>
    /// </summary>
    let HeatPumpRelay = _prefixId.prefix "HeatPumpRelay"
    /// <summary>
    ///   <para>skos:definition : Represent the the minimal power that a heater can accept.^^xsd:string</para>
    ///   <para>rdfs:label : Heater maximal power^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HeaterMaximalPower">dco:HeaterMaximalPower</a>
    /// </summary>
    let HeaterMaximalPower = _prefixId.prefix "HeaterMaximalPower"
    /// <summary>
    ///   <para>skos:definition : Represent the the minimal power that a heater can accept.^^xsd:string</para>
    ///   <para>rdfs:label : Heater minimum power^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HeaterMinimumPower">dco:HeaterMinimumPower</a>
    /// </summary>
    let HeaterMinimumPower = _prefixId.prefix "HeaterMinimumPower"
    /// <summary>
    ///   <para>rdfs:label : Heating actuator^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HeatingActuator">dco:HeatingActuator</a>
    /// </summary>
    let HeatingActuator = _prefixId.prefix "HeatingActuator"
    /// <summary>
    ///   <para>skos:definition : A type of service that represent the heating.^^xsd:string</para>
    ///   <para>rdfs:label : Heating service^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HeatingService">dco:HeatingService</a>
    /// </summary>
    let HeatingService = _prefixId.prefix "HeatingService"
    /// <summary>
    ///   <para>skos:definition : A type of service that represent the hot water production.^^xsd:string</para>
    ///   <para>rdfs:label : Hot water production service^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HotWaterProductionService">dco:HotWaterProductionService</a>
    /// </summary>
    let HotWaterProductionService = _prefixId.prefix "HotWaterProductionService"
    /// <summary>
    ///   <para>rdfs:label : Household type^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HouseholdType">dco:HouseholdType</a>
    /// </summary>
    let HouseholdType = _prefixId.prefix "HouseholdType"
    /// <summary>
    ///   <para>rdfs:label : Humidity property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HumidityProperty">dco:HumidityProperty</a>
    /// </summary>
    let HumidityProperty = _prefixId.prefix "HumidityProperty"
    /// <summary>
    ///   <para>skos:definition : The humidity sensor measures the concentration of water vapor in air.^^xsd:string</para>
    ///   <para>rdfs:label : Humidity sensor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#HumiditySensor">dco:HumiditySensor</a>
    /// </summary>
    let HumiditySensor = _prefixId.prefix "HumiditySensor"
    /// <summary>
    ///   <para>rdfs:label : Imported energy^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ImportedEnergy">dco:ImportedEnergy</a>
    /// </summary>
    let ImportedEnergy = _prefixId.prefix "ImportedEnergy"
    /// <summary>
    ///   <para>skos:definition : Represent the quantity of exported energy with pricing 1^^xsd:string</para>
    ///   <para>rdfs:label : Imported energy with pricing 1^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ImportedEnergyWithPricing1">dco:ImportedEnergyWithPricing1</a>
    /// </summary>
    let ImportedEnergyWithPricing1 = _prefixId.prefix "ImportedEnergyWithPricing1"
    /// <summary>
    ///   <para>rdfs:label : Imported energy with pricing 2^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ImportedEnergyWithPricing2">dco:ImportedEnergyWithPricing2</a>
    /// </summary>
    let ImportedEnergyWithPricing2 = _prefixId.prefix "ImportedEnergyWithPricing2"
    /// <summary>
    ///   <para>rdfs:label : Industrial building^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#IndustrialBuilding">dco:IndustrialBuilding</a>
    /// </summary>
    let IndustrialBuilding = _prefixId.prefix "IndustrialBuilding"
    /// <summary>
    ///   <para>skos:definition : temperature measured by the radiator valve at the entry of the radiator (i.e. at the connection between the radiator and the valve)^^xsd:string</para>
    ///   <para>rdfs:label : Intel temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#IntelTemperature">dco:IntelTemperature</a>
    /// </summary>
    let IntelTemperature = _prefixId.prefix "IntelTemperature"
    /// <summary>
    ///   <para>rdfs:label : Interaction Affordance^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#InteractionAffordance">dco:InteractionAffordance</a>
    /// </summary>
    let InteractionAffordance = _prefixId.prefix "InteractionAffordance"
    /// <summary>
    ///   <para>rdfs:label : Kitchen^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Kitchen">dco:Kitchen</a>
    /// </summary>
    let Kitchen = _prefixId.prefix "Kitchen"
    /// <summary>
    ///   <para>rdfs:label : Living room^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#LivingRoom">dco:LivingRoom</a>
    /// </summary>
    let LivingRoom = _prefixId.prefix "LivingRoom"
    /// <summary>
    ///   <para>rdfs:label : Lobby^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Lobby">dco:Lobby</a>
    /// </summary>
    let Lobby = _prefixId.prefix "Lobby"
    /// <summary>
    ///   <para>rdfs:label : Magnet sensor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#MagnetSensor">dco:MagnetSensor</a>
    /// </summary>
    let MagnetSensor = _prefixId.prefix "MagnetSensor"
    /// <summary>
    ///   <para>rdfs:label : Measure time stamp^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#MeasureTimeStamp">dco:MeasureTimeStamp</a>
    /// </summary>
    let MeasureTimeStamp = _prefixId.prefix "MeasureTimeStamp"
    /// <summary>
    ///   <para>skos:definition : Represent the measured valve opeing.^^xsd:string</para>
    ///   <para>rdfs:label : Measured valve opening^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#MeasuredValveOpening">dco:MeasuredValveOpening</a>
    /// </summary>
    let MeasuredValveOpening = _prefixId.prefix "MeasuredValveOpening"
    /// <summary>
    ///   <para>skos:definition : A device that measure usage or consumption of some media --- typically a form energy or power.^^xsd:string</para>
    ///   <para>rdfs:label : Meter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Meter">dco:Meter</a>
    /// </summary>
    let Meter = _prefixId.prefix "Meter"
    /// <summary>
    ///   <para>skos:definition : Represent a household of a more than one family.^^xsd:string</para>
    ///   <para>rdfs:label : Multi family house^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#MultiFamilyHouse">dco:MultiFamilyHouse</a>
    /// </summary>
    let MultiFamilyHouse = _prefixId.prefix "MultiFamilyHouse"
    /// <summary>
    ///   <para>rdfs:label : Off action^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#OffAction">dco:OffAction</a>
    /// </summary>
    let OffAction = _prefixId.prefix "OffAction"
    /// <summary>
    ///   <para>rdfs:label : Off state^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#OffState">dco:OffState</a>
    /// </summary>
    let OffState = _prefixId.prefix "OffState"
    /// <summary>
    ///   <para>rdfs:label : On action^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#OnAction">dco:OnAction</a>
    /// </summary>
    let OnAction = _prefixId.prefix "OnAction"
    /// <summary>
    ///   <para>skos:definition : A type of state^^xsd:string</para>
    ///   <para>rdfs:label : On Off state^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#OnOffState">dco:OnOffState</a>
    /// </summary>
    let OnOffState = _prefixId.prefix "OnOffState"
    /// <summary>
    ///   <para>rdfs:label : On state^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#OnState">dco:OnState</a>
    /// </summary>
    let OnState = _prefixId.prefix "OnState"
    /// <summary>
    ///   <para>rdfs:label : Open Close State^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#OpenCloseState">dco:OpenCloseState</a>
    /// </summary>
    let OpenCloseState = _prefixId.prefix "OpenCloseState"
    /// <summary>
    ///   <para>rdfs:label : Open state^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#OpenState">dco:OpenState</a>
    /// </summary>
    let OpenState = _prefixId.prefix "OpenState"
    /// <summary>
    ///   <para>skos:definition : Repesent the temperature property oustide a building.^^xsd:string</para>
    ///   <para>rdfs:label : Outdoor temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#OutdoorTemperature">dco:OutdoorTemperature</a>
    /// </summary>
    let OutdoorTemperature = _prefixId.prefix "OutdoorTemperature"
    /// <summary>
    ///   <para>skos:definition : A dimensionless concentration notation which denotes the amount of a given substance in a total amount of 1,000,000 regardless of the units of measure used as long as they are the same or 1 part in 10^[6].^^xsd:string</para>
    ///   <para>rdfs:label : Parts per million^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#PartsPerMillion">dco:PartsPerMillion</a>
    /// </summary>
    let PartsPerMillion = _prefixId.prefix "PartsPerMillion"
    /// <summary>
    ///   <para>skos:definition : "A dimensionless concentration notation which describes the amount of one substance in another. It is the ratio of the amount of the substance of interest to the amount of that substance plus the amount of the substance." [Wikipedia:Wikipedia]^^xsd:string</para>
    ///   <para>rdfs:label : Parts per notation unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#PartsPerNotationUnit">dco:PartsPerNotationUnit</a>
    /// </summary>
    let PartsPerNotationUnit = _prefixId.prefix "PartsPerNotationUnit"
    /// <summary>
    ///   <para>rdfs:label : Percentage^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Percentage">dco:Percentage</a>
    /// </summary>
    let Percentage = _prefixId.prefix "Percentage"
    /// <summary>
    ///   <para>rdfs:label : Percentage unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#PercentageUnit">dco:PercentageUnit</a>
    /// </summary>
    let PercentageUnit = _prefixId.prefix "PercentageUnit"
    /// <summary>
    ///   <para>skos:definition : Represent the temperature of the pipe. It typically requires that pipe be kept to a temperature just above freezing typically at 40°F (4.4°C).^^xsd:string</para>
    ///   <para>rdfs:label : Pipe temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#PipeTemperature">dco:PipeTemperature</a>
    /// </summary>
    let PipeTemperature = _prefixId.prefix "PipeTemperature"
    /// <summary>
    ///   <para>skos:definition : Represent a power meter.^^xsd:string</para>
    ///   <para>rdfs:label : Power meter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#PowerMeter">dco:PowerMeter</a>
    /// </summary>
    let PowerMeter = _prefixId.prefix "PowerMeter"
    /// <summary>
    ///   <para>rdfs:label : Power property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#PowerProperty">dco:PowerProperty</a>
    /// </summary>
    let PowerProperty = _prefixId.prefix "PowerProperty"
    /// <summary>
    ///   <para>rdfs:label : Power unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#PowerUnit">dco:PowerUnit</a>
    /// </summary>
    let PowerUnit = _prefixId.prefix "PowerUnit"
    /// <summary>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Property">dco:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:label : Reactive energy^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ReactiveEnergy">dco:ReactiveEnergy</a>
    /// </summary>
    let ReactiveEnergy = _prefixId.prefix "ReactiveEnergy"
    /// <summary>
    ///   <para>skos:definition : The power which flows back and forth that means it moves in both the directions in the circuit or reacts upon itself, is called Reactive Power. The reactive power is measured in kilo volt-ampere reactive (kVAR) or MVAR.^^xsd:string</para>
    ///   <para>rdfs:label : Reactive power^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ReactivePower">dco:ReactivePower</a>
    /// </summary>
    let ReactivePower = _prefixId.prefix "ReactivePower"
    /// <summary>
    ///   <para>rdfs:label : Reactive power export^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ReactivePowerExport">dco:ReactivePowerExport</a>
    /// </summary>
    let ReactivePowerExport = _prefixId.prefix "ReactivePowerExport"
    /// <summary>
    ///   <para>rdfs:label : Reactive power Import^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ReactivePowerImport">dco:ReactivePowerImport</a>
    /// </summary>
    let ReactivePowerImport = _prefixId.prefix "ReactivePowerImport"
    /// <summary>
    ///   <para>rdfs:label : Relay^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Relay">dco:Relay</a>
    /// </summary>
    let Relay = _prefixId.prefix "Relay"
    /// <summary>
    ///   <para>rdfs:label : Residential building^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ResidentialBuilding">dco:ResidentialBuilding</a>
    /// </summary>
    let ResidentialBuilding = _prefixId.prefix "ResidentialBuilding"
    /// <summary>
    ///   <para>skos:definition : This sensor measures the return temperature.^^xsd:string</para>
    ///   <para>rdfs:label : Return temperature sensor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ReturnTemperatureSensor">dco:ReturnTemperatureSensor</a>
    /// </summary>
    let ReturnTemperatureSensor = _prefixId.prefix "ReturnTemperatureSensor"
    /// <summary>
    ///   <para>rdfs:label : Room^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Room">dco:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>skos:definition : Device, agent (including humans), or software (simulation) involved in, or implementing, a Procedure. Sensors respond to a stimulus, e.g., a change in the environment, or input data composed from the results of prior Observations, and generate a Result. Sensors can be hosted by Platforms.^^xsd:string</para>
    ///   <para>rdfs:label : Sensor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Sensor">dco:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Setpoint^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Setpoint">dco:Setpoint</a>
    /// </summary>
    let Setpoint = _prefixId.prefix "Setpoint"
    /// <summary>
    ///   <para>skos:definition : Represent a household of a single family.^^xsd:string</para>
    ///   <para>rdfs:label : Single family house^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#SingleFamilyHouse">dco:SingleFamilyHouse</a>
    /// </summary>
    let SingleFamilyHouse = _prefixId.prefix "SingleFamilyHouse"
    /// <summary>
    ///   <para>skos:definition : A part of the physical world or a virtual world that is inherently both located in this world and having a 3D spatial extent. It is intended to contain or contains one or more buildings.^^xsd:string</para>
    ///   <para>rdfs:label : Site^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Site">dco:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : SmartMeter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#SmartMeter">dco:SmartMeter</a>
    /// </summary>
    let SmartMeter = _prefixId.prefix "SmartMeter"
    /// <summary>
    ///   <para>skos:definition : A solar panel, or photo-voltaic (PV) module, is an assembly of photo-voltaic cells mounted in a framework for installation. Solar panels use sunlight as a source of energy and generate direct current electricity.^^xsd:string</para>
    ///   <para>rdfs:label : Solar panels appliance^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#SolarPanelsAppliance">dco:SolarPanelsAppliance</a>
    /// </summary>
    let SolarPanelsAppliance = _prefixId.prefix "SolarPanelsAppliance"
    /// <summary>
    ///   <para>skos:definition : A part of the physical world or a virtual world whose 3D spatial extent is bounded actually or theoretically, and provides for certain functions within the zone it is contained in.^^xsd:string</para>
    ///   <para>rdfs:label : Space^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Space">dco:Space</a>
    /// </summary>
    let Space = _prefixId.prefix "Space"
    /// <summary>
    ///   <para>skos:definition : "An area unit which is equal to an area enclosed by a square with sides each 1 meter long." [NIST:NIST]^^xsd:string</para>
    ///   <para>rdfs:label : Square meter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#SquareMeter">dco:SquareMeter</a>
    /// </summary>
    let SquareMeter = _prefixId.prefix "SquareMeter"
    /// <summary>
    ///   <para>rdfs:label : Start state^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#StartState">dco:StartState</a>
    /// </summary>
    let StartState = _prefixId.prefix "StartState"
    /// <summary>
    ///   <para>rdfs:label : Start Stop state^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#StartStopState">dco:StartStopState</a>
    /// </summary>
    let StartStopState = _prefixId.prefix "StartStopState"
    /// <summary>
    ///   <para>skos:definition : The state in which a device can be found, e.g, ON/OFF/STANDBY, or ONLINE/OFFLINE^^xsd:string</para>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#State">dco:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Stop state^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#StopState">dco:StopState</a>
    /// </summary>
    let StopState = _prefixId.prefix "StopState"
    /// <summary>
    ///   <para>skos:definition : This sensor measures the supplied temperature by a directly from the heater.^^xsd:string</para>
    ///   <para>rdfs:label : Supply temperature sensor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#SupplyTemperatureSensor">dco:SupplyTemperatureSensor</a>
    /// </summary>
    let SupplyTemperatureSensor = _prefixId.prefix "SupplyTemperatureSensor"
    /// <summary>
    ///   <para>skos:definition : Represent the temperature of a tank.^^xsd:string</para>
    ///   <para>rdfs:label : Tank temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#TankTemperature">dco:TankTemperature</a>
    /// </summary>
    let TankTemperature = _prefixId.prefix "TankTemperature"
    /// <summary>
    ///   <para>rdfs:label : Temperature Property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#TemperatureProperty">dco:TemperatureProperty</a>
    /// </summary>
    let TemperatureProperty = _prefixId.prefix "TemperatureProperty"
    /// <summary>
    ///   <para>skos:definition : A sensor that is used for the purpose of sensing the temperature property.^^xsd:string</para>
    ///   <para>rdfs:label : Temperature Sensor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#TemperatureSensor">dco:TemperatureSensor</a>
    /// </summary>
    let TemperatureSensor = _prefixId.prefix "TemperatureSensor"
    /// <summary>
    ///   <para>skos:definition : A setpoint is the desired target value of a property.^^xsd:string</para>
    ///   <para>rdfs:label : Temperature setpoint^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#TemperatureSetpoint">dco:TemperatureSetpoint</a>
    /// </summary>
    let TemperatureSetpoint = _prefixId.prefix "TemperatureSetpoint"
    /// <summary>
    ///   <para>skos:definition : "A unit which is a standard measure of the average kinetic energy of the particles in a sample of matter." [Wikipedia:Wikipedia]^^xsd:string</para>
    ///   <para>rdfs:label : Temperature unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#TemperatureUnit">dco:TemperatureUnit</a>
    /// </summary>
    let TemperatureUnit = _prefixId.prefix "TemperatureUnit"
    /// <summary>
    ///   <para>skos:definition : Tertiary sector buildings include all of the infrastructure occupied by public authorities, associations and companies providing services.^^xsd:string</para>
    ///   <para>rdfs:label : Tertiary building^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#TertiaryBuilding">dco:TertiaryBuilding</a>
    /// </summary>
    let TertiaryBuilding = _prefixId.prefix "TertiaryBuilding"
    /// <summary>
    ///   <para>skos:definition : An automatic control device used to maintain temperature at a fixed or adjustable setpoint.^^xsd:string</para>
    ///   <para>rdfs:label : Thermostat^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Thermostat">dco:Thermostat</a>
    /// </summary>
    let Thermostat = _prefixId.prefix "Thermostat"
    /// <summary>
    ///   <para>rdfs:label : Thermostatic valve actuator^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ThermostaticValveActuator">dco:ThermostaticValveActuator</a>
    /// </summary>
    let ThermostaticValveActuator = _prefixId.prefix "ThermostaticValveActuator"
    /// <summary>
    ///   <para>rdfs:label : Thing description model^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ThingDescriptionModel">dco:ThingDescriptionModel</a>
    /// </summary>
    let ThingDescriptionModel = _prefixId.prefix "ThingDescriptionModel"
    /// <summary>
    ///   <para>rdfs:label : Toggle action^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ToggleAction">dco:ToggleAction</a>
    /// </summary>
    let ToggleAction = _prefixId.prefix "ToggleAction"
    /// <summary>
    ///   <para>skos:definition : A unit of measurement is a definite magnitude of a quantity, defined and adopted by convention and/or by law. It is used as a standard for measurement of the same quantity, where any other value of the quantity can be expressed as a simple multiple of the unit of measure. For example, length is a quantity; the metre is a unit of length that represents a definite predetermined length. When we say 10 metre (or 10 m), we actually mean 10 times the definite predetermined length called "metre".^^xsd:string</para>
    ///   <para>rdfs:label : Units of measurements^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#UnitsOfMeasurements">dco:UnitsOfMeasurements</a>
    /// </summary>
    let UnitsOfMeasurements = _prefixId.prefix "UnitsOfMeasurements"
    /// <summary>
    ///   <para>skos:definition : Represent the actuator of the valve.^^xsd:string</para>
    ///   <para>rdfs:label : Valve actuator^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ValveActuator">dco:ValveActuator</a>
    /// </summary>
    let ValveActuator = _prefixId.prefix "ValveActuator"
    /// <summary>
    ///   <para>skos:definition : Represent the controller of a valve.^^xsd:string</para>
    ///   <para>rdfs:label : Valve controller^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ValveController">dco:ValveController</a>
    /// </summary>
    let ValveController = _prefixId.prefix "ValveController"
    /// <summary>
    ///   <para>rdfs:label : Valve maximum opening^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ValveMaximumOpening">dco:ValveMaximumOpening</a>
    /// </summary>
    let ValveMaximumOpening = _prefixId.prefix "ValveMaximumOpening"
    /// <summary>
    ///   <para>rdfs:label : Valve maximum temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ValveMaximumTemperature">dco:ValveMaximumTemperature</a>
    /// </summary>
    let ValveMaximumTemperature = _prefixId.prefix "ValveMaximumTemperature"
    /// <summary>
    ///   <para>rdfs:label : Valve minimum opening^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ValveMinimumOpening">dco:ValveMinimumOpening</a>
    /// </summary>
    let ValveMinimumOpening = _prefixId.prefix "ValveMinimumOpening"
    /// <summary>
    ///   <para>rdfs:label : Valve minimum temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ValveMinimumTemperature">dco:ValveMinimumTemperature</a>
    /// </summary>
    let ValveMinimumTemperature = _prefixId.prefix "ValveMinimumTemperature"
    /// <summary>
    ///   <para>skos:definition : Represent the current position of a valve^^xsd:string</para>
    ///   <para>rdfs:label : Valve position^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ValvePosition">dco:ValvePosition</a>
    /// </summary>
    let ValvePosition = _prefixId.prefix "ValvePosition"
    /// <summary>
    ///   <para>rdfs:label : Valve property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#ValveProperty">dco:ValveProperty</a>
    /// </summary>
    let ValveProperty = _prefixId.prefix "ValveProperty"
    /// <summary>
    ///   <para>skos:definition : In electric power transmission and distribution, volt-ampere reactive (var) is a unit in which reactive power is expressed in an AC electric power system.^^xsd:string</para>
    ///   <para>rdfs:label : Volt-ampere reactive^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Volt-ampereReactive">dco:Volt-ampereReactive</a>
    /// </summary>
    let Volt_ampereReactive = _prefixId.prefix "Volt-ampereReactive"
    /// <summary>
    ///   <para>rdfs:label : Voltage^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Voltage">dco:Voltage</a>
    /// </summary>
    let Voltage = _prefixId.prefix "Voltage"
    /// <summary>
    ///   <para>rdfs:label : Voltage clamp 1^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#VoltageClamp1">dco:VoltageClamp1</a>
    /// </summary>
    let VoltageClamp1 = _prefixId.prefix "VoltageClamp1"
    /// <summary>
    ///   <para>rdfs:label : Voltage clamp 2^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#VoltageClamp2">dco:VoltageClamp2</a>
    /// </summary>
    let VoltageClamp2 = _prefixId.prefix "VoltageClamp2"
    /// <summary>
    ///   <para>rdfs:label : Voltage clamp 3^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#VoltageClamp3">dco:VoltageClamp3</a>
    /// </summary>
    let VoltageClamp3 = _prefixId.prefix "VoltageClamp3"
    /// <summary>
    ///   <para>rdfs:label : Voltage property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#VoltageProperty">dco:VoltageProperty</a>
    /// </summary>
    let VoltageProperty = _prefixId.prefix "VoltageProperty"
    /// <summary>
    ///   <para>skos:definition : "A unit which is a standard measure of the amount of space occupied by any substance, whether solid, liquid, or gas." [NIST:NIST]^^xsd:string</para>
    ///   <para>rdfs:label : Volume unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#VolumeUnit">dco:VolumeUnit</a>
    /// </summary>
    let VolumeUnit = _prefixId.prefix "VolumeUnit"
    /// <summary>
    ///   <para>skos:definition : Water flow refers to the amount of water coming out of a hose, faucet or other pipe fixture in a certain amount of time.^^xsd:string</para>
    ///   <para>rdfs:label : Water flow^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#WaterFlow">dco:WaterFlow</a>
    /// </summary>
    let WaterFlow = _prefixId.prefix "WaterFlow"
    /// <summary>
    ///   <para>skos:definition : A water meter is an instrument intended to measure continuously, memorize, and display the volume of water passing through the meter.^^xsd:string</para>
    ///   <para>rdfs:label : Water flow meter^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#WaterFlowMeter">dco:WaterFlowMeter</a>
    /// </summary>
    let WaterFlowMeter = _prefixId.prefix "WaterFlowMeter"
    /// <summary>
    ///   <para>rdfs:label : Water property^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#WaterProperty">dco:WaterProperty</a>
    /// </summary>
    let WaterProperty = _prefixId.prefix "WaterProperty"
    /// <summary>
    ///   <para>rdfs:label : Water temperature^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#WaterTemperature">dco:WaterTemperature</a>
    /// </summary>
    let WaterTemperature = _prefixId.prefix "WaterTemperature"
    /// <summary>
    ///   <para>skos:definition : This sensor measures the water temperature.^^xsd:string</para>
    ///   <para>rdfs:label : Water temperature sensor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#WaterTemperatureSensor">dco:WaterTemperatureSensor</a>
    /// </summary>
    let WaterTemperatureSensor = _prefixId.prefix "WaterTemperatureSensor"
    /// <summary>
    ///   <para>skos:definition : Water volume means the quantity of water that can be measured in liters, cubic meters, gallons, milliliters, teaspoons, and ounces, though many other units exist.^^xsd:string</para>
    ///   <para>rdfs:label : Water volume^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#WaterVolume">dco:WaterVolume</a>
    /// </summary>
    let WaterVolume = _prefixId.prefix "WaterVolume"
    /// <summary>
    ///   <para>skos:definition : "A power unit which is equal to the power used when work is done at the rate of 1 joule per second." [NIST:NIST]^^xsd:string</para>
    ///   <para>rdfs:label : Watt^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Watt">dco:Watt</a>
    /// </summary>
    let Watt = _prefixId.prefix "Watt"
    /// <summary>
    ///   <para>rdfs:label : Watt hour based unit^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#WattHourBasedUnit">dco:WattHourBasedUnit</a>
    /// </summary>
    let WattHourBasedUnit = _prefixId.prefix "WattHourBasedUnit"
    /// <summary>
    ///   <para>skos:definition : An abstraction of a physical or a virtual entity whose metadata and interfaces are described by a WoT Thing Description, whereas a virtual entity is the composition of one or more Things.^^xsd:string</para>
    ///   <para>rdfs:label : WoT Thing^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#WoTThing">dco:WoTThing</a>
    /// </summary>
    let WoTThing = _prefixId.prefix "WoTThing"
    /// <summary>
    ///   <para>rdfs:label : Zone^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#Zone">dco:Zone</a>
    /// </summary>
    let Zone = _prefixId.prefix "Zone"
    /// <summary>
    ///   <para>skos:definition : Represent the zip code of the building^^xsd:string</para>
    ///   <para>rdfs:label : building zip code^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#buildingZipCode">dco:buildingZipCode</a>
    /// </summary>
    let buildingZipCode = _prefixId.prefix "buildingZipCode"
    /// <summary>
    ///   <para>rdfs:label : consitsOf^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#consitsOf">dco:consitsOf</a>
    /// </summary>
    let consitsOf = _prefixId.prefix "consitsOf"
    /// <summary>
    ///   <para>rdfs:label : contains device^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#containsDevice">dco:containsDevice</a>
    /// </summary>
    let containsDevice = _prefixId.prefix "containsDevice"
    /// <summary>
    ///   <para>rdfs:label : dCO core model^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#dCOCoreModel">dco:dCOCoreModel</a>
    /// </summary>
    let dCOCoreModel = _prefixId.prefix "dCOCoreModel"
    /// <summary>
    ///   <para>rdfs:label : hasAddress^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasAddress">dco:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>rdfs:label : hasApartment^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasApartment">dco:hasApartment</a>
    /// </summary>
    let hasApartment = _prefixId.prefix "hasApartment"
    /// <summary>
    ///   <para>rdfs:label : hasBuilding^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasBuilding">dco:hasBuilding</a>
    /// </summary>
    let hasBuilding = _prefixId.prefix "hasBuilding"
    /// <summary>
    ///   <para>rdfs:label : hasCity^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasCity">dco:hasCity</a>
    /// </summary>
    let hasCity = _prefixId.prefix "hasCity"
    /// <summary>
    ///   <para>rdfs:label : hasConstructionYear^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasConstructionYear">dco:hasConstructionYear</a>
    /// </summary>
    let hasConstructionYear = _prefixId.prefix "hasConstructionYear"
    /// <summary>
    ///   <para>rdfs:label : hasFloor^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasFloor">dco:hasFloor</a>
    /// </summary>
    let hasFloor = _prefixId.prefix "hasFloor"
    /// <summary>
    ///   <para>rdfs:label : hasID^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasID">dco:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:label : hasName^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasName">dco:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : hasNumberOfInhabitants^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasNumberOfInhabitants">dco:hasNumberOfInhabitants</a>
    /// </summary>
    let hasNumberOfInhabitants = _prefixId.prefix "hasNumberOfInhabitants"
    /// <summary>
    ///   <para>rdfs:label : hasRenovationDate^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasRenovationDate">dco:hasRenovationDate</a>
    /// </summary>
    let hasRenovationDate = _prefixId.prefix "hasRenovationDate"
    /// <summary>
    ///   <para>rdfs:label : hasSite^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasSite">dco:hasSite</a>
    /// </summary>
    let hasSite = _prefixId.prefix "hasSite"
    /// <summary>
    ///   <para>rdfs:label : hasSpace^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasSpace">dco:hasSpace</a>
    /// </summary>
    let hasSpace = _prefixId.prefix "hasSpace"
    /// <summary>
    ///   <para>rdfs:label : hasThingDescriptionAction^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasThingDescriptionAction">dco:hasThingDescriptionAction</a>
    /// </summary>
    let hasThingDescriptionAction = _prefixId.prefix "hasThingDescriptionAction"
    /// <summary>
    ///   <para>rdfs:label : hasThingDescriptionEvent^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasThingDescriptionEvent">dco:hasThingDescriptionEvent</a>
    /// </summary>
    let hasThingDescriptionEvent = _prefixId.prefix "hasThingDescriptionEvent"
    /// <summary>
    ///   <para>rdfs:label : hasThingDescriptionProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasThingDescriptionProperty">dco:hasThingDescriptionProperty</a>
    /// </summary>
    let hasThingDescriptionProperty = _prefixId.prefix "hasThingDescriptionProperty"
    /// <summary>
    ///   <para>skos:definition : This defines the total surface of a dCO:Space measured in square meter^^xsd:string</para>
    ///   <para>rdfs:label : hasTotalSpace^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasTotalSpace">dco:hasTotalSpace</a>
    /// </summary>
    let hasTotalSpace = _prefixId.prefix "hasTotalSpace"
    /// <summary>
    ///   <para>rdfs:label : hasZipCode^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#hasZipCode">dco:hasZipCode</a>
    /// </summary>
    let hasZipCode = _prefixId.prefix "hasZipCode"
    /// <summary>
    ///   <para>rdfs:label : is action of^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#isActionOf">dco:isActionOf</a>
    /// </summary>
    let isActionOf = _prefixId.prefix "isActionOf"
    /// <summary>
    ///   <para>rdfs:label : is apartment of^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#isApartmentOF">dco:isApartmentOF</a>
    /// </summary>
    let isApartmentOF = _prefixId.prefix "isApartmentOF"
    /// <summary>
    ///   <para>rdfs:label : is event of^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#isEventOf">dco:isEventOf</a>
    /// </summary>
    let isEventOf = _prefixId.prefix "isEventOf"
    /// <summary>
    ///   <para>rdfs:label : is floor of^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#isFloorOf">dco:isFloorOf</a>
    /// </summary>
    let isFloorOf = _prefixId.prefix "isFloorOf"
    /// <summary>
    ///   <para>rdfs:label : is located at^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#isLocatedAt">dco:isLocatedAt</a>
    /// </summary>
    let isLocatedAt = _prefixId.prefix "isLocatedAt"
    /// <summary>
    ///   <para>rdfs:label : isMeasuredIn^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#isMeasuredIn">dco:isMeasuredIn</a>
    /// </summary>
    let isMeasuredIn = _prefixId.prefix "isMeasuredIn"
    /// <summary>
    ///   <para>rdfs:label : is property of^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#isPropertyOf">dco:isPropertyOf</a>
    /// </summary>
    let isPropertyOf = _prefixId.prefix "isPropertyOf"
    /// <summary>
    ///   <para>rdfs:label : is unit of measurement of^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#isUnitOfMeasurementOf">dco:isUnitOfMeasurementOf</a>
    /// </summary>
    let isUnitOfMeasurementOf = _prefixId.prefix "isUnitOfMeasurementOf"
    /// <summary>
    ///   <para>skos:definition : "An energy unit which is equal to 1,000 watt-hours." [Wikipedia:Wikipedia]^^xsd:string</para>
    ///   <para>rdfs:label : kilowatt-hour^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#kilowatt-hour">dco:kilowatt-hour</a>
    /// </summary>
    let kilowatt_hour = _prefixId.prefix "kilowatt-hour"
    /// <summary>
    ///   <para>rdfs:label : makes measurement^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#makesMeasurement">dco:makesMeasurement</a>
    /// </summary>
    let makesMeasurement = _prefixId.prefix "makesMeasurement"
    /// <summary>
    ///   <para>rdfs:label : measurement made by^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#measurementMadeBy">dco:measurementMadeBy</a>
    /// </summary>
    let measurementMadeBy = _prefixId.prefix "measurementMadeBy"
    /// <summary>
    ///   <para>rdfs:label : offers service^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#offersService">dco:offersService</a>
    /// </summary>
    let offersService = _prefixId.prefix "offersService"
    /// <summary>
    ///   <para>rdfs:label : service offered by^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#serviceOfferedBy">dco:serviceOfferedBy</a>
    /// </summary>
    let serviceOfferedBy = _prefixId.prefix "serviceOfferedBy"
    /// <summary>
    ///   <para>rdfs:label : watt-hour^^xsd:string</para>
    ///   <a href="https://w3id.org/dco#watt-hour">dco:watt-hour</a>
    /// </summary>
    let watt_hour = _prefixId.prefix "watt-hour"
