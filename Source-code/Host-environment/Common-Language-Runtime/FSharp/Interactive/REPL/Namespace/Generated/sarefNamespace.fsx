#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module saref =
    let _prefixId = PrefixId.fromNamespaceLabel "https://saref.etsi.org/core/" "saref"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actuating function</para>
    ///   <para>rdfs:comment : A function that allows to transmit data to actuators, such as level settings (e.g., temperature) or binary switching (e.g., open/close, on/off)</para>
    ///   <a href="https://saref.etsi.org/core/ActuatingFunction">saref:ActuatingFunction</a>
    /// </summary>
    let ActuatingFunction = _prefixId.prefix "ActuatingFunction"
    /// <summary>
    ///   <para>rdfs:label : Actuator</para>
    ///   <para>rdfs:comment : A device responsible for moving or controlling a mechanism or system by performing an actuating function</para>
    ///   <a href="https://saref.etsi.org/core/Actuator">saref:Actuator</a>
    /// </summary>
    let Actuator = _prefixId.prefix "Actuator"
    /// <summary>
    ///   <para>rdfs:label : Appliance</para>
    ///   <para>rdfs:comment : An electrical/mechanical machine that accomplish some household functions, such as cleaning or cooking</para>
    ///   <a href="https://saref.etsi.org/core/Appliance">saref:Appliance</a>
    /// </summary>
    let Appliance = _prefixId.prefix "Appliance"
    let Cleaning = _prefixId.prefix "Cleaning"
    /// <summary>
    ///   <para>rdfs:label : Close command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/CloseCommand">saref:CloseCommand</a>
    /// </summary>
    let CloseCommand = _prefixId.prefix "CloseCommand"
    /// <summary>
    ///   <para>rdfs:label : Close state</para>
    ///   <para>rdfs:comment : The state of a device that is CLOSE</para>
    ///   <a href="https://saref.etsi.org/core/CloseState">saref:CloseState</a>
    /// </summary>
    let CloseState = _prefixId.prefix "CloseState"
    /// <summary>
    ///   <para>rdfs:label : Coal</para>
    ///   <para>rdfs:comment : A type of commodity</para>
    ///   <a href="https://saref.etsi.org/core/Coal">saref:Coal</a>
    /// </summary>
    let Coal = _prefixId.prefix "Coal"
    let Comfort = _prefixId.prefix "Comfort"
    /// <summary>
    ///   <para>rdfs:label : Command</para>
    ///   <para>rdfs:comment : A directive that a device must support to perform a certain function. A command may act upon a state, but does not necessarily act upon a state. For example, the ON command acts upon the ON/OFF state, but the GET command does not act upon any state, it simply gives a directive to retrieve a certain value. We propose here a list of commands that are relevant for the purpose of SAREF, but this list can be extended.</para>
    ///   <a href="https://saref.etsi.org/core/Command">saref:Command</a>
    /// </summary>
    let Command = _prefixId.prefix "Command"
    /// <summary>
    ///   <para>rdfs:label : Commodity</para>
    ///   <para>rdfs:comment : A marketable item for which there is demand, but which is supplied without qualitative differentiation across a market. SAREF refers to energy commodities such as electricity, gas, coal and oil. </para>
    ///   <a href="https://saref.etsi.org/core/Commodity">saref:Commodity</a>
    /// </summary>
    let Commodity = _prefixId.prefix "Commodity"
    /// <summary>
    ///   <para>rdfs:label : Currency</para>
    ///   <para>rdfs:comment : The class of units of measure for price</para>
    ///   <a href="https://saref.etsi.org/core/Currency">saref:Currency</a>
    /// </summary>
    let Currency = _prefixId.prefix "Currency"
    /// <summary>
    ///   <para>rdfs:comment : A tangible object designed to accomplish a particular task. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function.</para>
    ///   <para>rdfs:label : Device</para>
    ///   <a href="https://saref.etsi.org/core/Device">saref:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>rdfs:label : Door switch</para>
    ///   <para>rdfs:comment : A switch that performs the saref:OpenCloseFunction, is used for controlling a door, and can be found in the state saref:OpenCloseState. A saref:DoorSwitch is typically used to accomplish saref:Safety.</para>
    ///   <a href="https://saref.etsi.org/core/DoorSwitch">saref:DoorSwitch</a>
    /// </summary>
    let DoorSwitch = _prefixId.prefix "DoorSwitch"
    let Drying = _prefixId.prefix "Drying"
    /// <summary>
    ///   <para>rdfs:label : Electricity</para>
    ///   <para>rdfs:comment : A type of commodity</para>
    ///   <a href="https://saref.etsi.org/core/Electricity">saref:Electricity</a>
    /// </summary>
    let Electricity = _prefixId.prefix "Electricity"
    /// <summary>
    ///   <para>rdfs:label : Energy</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value measured in an energy unit (such as Kilowatt_Hour or Watt_hour). Furter specializations of the saref:Energy class can be found in the SAREF4ENER extension, where classes such as EnergyMax, EnergyMin and EnergyExpected are defined. </para>
    ///   <a href="https://saref.etsi.org/core/Energy">saref:Energy</a>
    /// </summary>
    let Energy = _prefixId.prefix "Energy"
    let EnergyEfficiency = _prefixId.prefix "EnergyEfficiency"
    /// <summary>
    ///   <para>rdfs:label : Energy unit</para>
    ///   <para>rdfs:comment : The unit of measure for energy</para>
    ///   <a href="https://saref.etsi.org/core/EnergyUnit">saref:EnergyUnit</a>
    /// </summary>
    let EnergyUnit = _prefixId.prefix "EnergyUnit"
    let Entertainment = _prefixId.prefix "Entertainment"
    /// <summary>
    ///   <para>rdfs:label : Event function</para>
    ///   <para>rdfs:comment : A function that allows to notify about some relevant activity; e.g., that a certain threshold value has been exceeded or that some object has moved.</para>
    ///   <a href="https://saref.etsi.org/core/EventFunction">saref:EventFunction</a>
    /// </summary>
    let EventFunction = _prefixId.prefix "EventFunction"
    /// <summary>
    ///   <para>rdfs:label : Feature of interest</para>
    ///   <para>rdfs:comment : A feature of interest represents any real world entity from which a property is measured.</para>
    ///   <a href="https://saref.etsi.org/core/FeatureOfInterest">saref:FeatureOfInterest</a>
    /// </summary>
    let FeatureOfInterest = _prefixId.prefix "FeatureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : Function</para>
    ///   <para>rdfs:comment : The functionality necessary to accomplish the task for which a device is designed. A device can be designed to perform more than one function. Functions can be structured in categories (subclasses) that reflect different points of view, for example, considering the specific application area for which a function can be used (e.g., light, temperature, motion, heat, power, etc.), or the capability that a function can support (e.g., receive, reply, notify, etc.), and so forth. </para>
    ///   <a href="https://saref.etsi.org/core/Function">saref:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    /// <summary>
    ///   <para>rdfs:label : Gas</para>
    ///   <para>rdfs:comment : A type of commodity</para>
    ///   <a href="https://saref.etsi.org/core/Gas">saref:Gas</a>
    /// </summary>
    let Gas = _prefixId.prefix "Gas"
    /// <summary>
    ///   <para>rdfs:label : Get command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/GetCommand">saref:GetCommand</a>
    /// </summary>
    let GetCommand = _prefixId.prefix "GetCommand"
    /// <summary>
    ///   <para>rdfs:label : Get current meter value command</para>
    ///   <para>rdfs:comment : A type of get command</para>
    ///   <a href="https://saref.etsi.org/core/GetCurrentMeterValueCommand">saref:GetCurrentMeterValueCommand</a>
    /// </summary>
    let GetCurrentMeterValueCommand = _prefixId.prefix "GetCurrentMeterValueCommand"
    /// <summary>
    ///   <para>rdfs:label : Get meter data command</para>
    ///   <para>rdfs:comment : A type of get command</para>
    ///   <a href="https://saref.etsi.org/core/GetMeterDataCommand">saref:GetMeterDataCommand</a>
    /// </summary>
    let GetMeterDataCommand = _prefixId.prefix "GetMeterDataCommand"
    /// <summary>
    ///   <para>rdfs:label : Get meter history command</para>
    ///   <para>rdfs:comment : A type of get command</para>
    ///   <a href="https://saref.etsi.org/core/GetMeterHistoryCommand">saref:GetMeterHistoryCommand</a>
    /// </summary>
    let GetMeterHistoryCommand = _prefixId.prefix "GetMeterHistoryCommand"
    /// <summary>
    ///   <para>rdfs:label : Get sensing data command</para>
    ///   <para>rdfs:comment : A type of get command</para>
    ///   <a href="https://saref.etsi.org/core/GetSensingDataCommand">saref:GetSensingDataCommand</a>
    /// </summary>
    let GetSensingDataCommand = _prefixId.prefix "GetSensingDataCommand"
    /// <summary>
    ///   <para>rdfs:label : HVAC</para>
    ///   <para>rdfs:comment : Heating, Ventilation and Air Conditioning (HVAC) device that provides indoor environmental comfort. A saref:HVAC is typically used to accomplish saref:Comfort.</para>
    ///   <a href="https://saref.etsi.org/core/HVAC">saref:HVAC</a>
    /// </summary>
    let HVAC = _prefixId.prefix "HVAC"
    /// <summary>
    ///   <para>rdfs:label : Humidity</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value that is measured in a humidity unit</para>
    ///   <a href="https://saref.etsi.org/core/Humidity">saref:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>rdfs:label : Illuminance unit</para>
    ///   <para>rdfs:comment : The unit of measure for light</para>
    ///   <a href="https://saref.etsi.org/core/IlluminanceUnit">saref:IlluminanceUnit</a>
    /// </summary>
    let IlluminanceUnit = _prefixId.prefix "IlluminanceUnit"
    /// <summary>
    ///   <para>rdfs:label : Level control function</para>
    ///   <para>rdfs:comment : An actuating function that allows to do level adjustments of a property in a certain range (e.g., 0%-100%), such as dimming a light in a room or setting the speed of an electric motor. </para>
    ///   <a href="https://saref.etsi.org/core/LevelControlFunction">saref:LevelControlFunction</a>
    /// </summary>
    let LevelControlFunction = _prefixId.prefix "LevelControlFunction"
    /// <summary>
    ///   <para>rdfs:label : Light</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value that is measured in a illuminance unit (lux)</para>
    ///   <a href="https://saref.etsi.org/core/Light">saref:Light</a>
    /// </summary>
    let Light = _prefixId.prefix "Light"
    /// <summary>
    ///   <para>rdfs:label : Light switch</para>
    ///   <para>rdfs:comment : A switch that performs the saref:OnOffFunction, controls the property saref:Light, and can be found in the state saref:OnOffState. It can offer a switch on service. A saref:LightSwitch is typically used to accomplish saref:Lighting.</para>
    ///   <a href="https://saref.etsi.org/core/LightSwitch">saref:LightSwitch</a>
    /// </summary>
    let LightSwitch = _prefixId.prefix "LightSwitch"
    let Lighting = _prefixId.prefix "Lighting"
    /// <summary>
    ///   <para>rdfs:comment : Represents the measured value made over a property. It is also linked to the unit of measure in which the value is expressed and the timestamp of the measurement.</para>
    ///   <para>rdfs:label : Measurement</para>
    ///   <a href="https://saref.etsi.org/core/Measurement">saref:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : Meter</para>
    ///   <para>rdfs:comment : A device built to accurately detect and display a quantity in a form readable by a human being. Further, a device of category saref:Meter that performs a saref:MeteringFunction.</para>
    ///   <a href="https://saref.etsi.org/core/Meter">saref:Meter</a>
    /// </summary>
    let Meter = _prefixId.prefix "Meter"
    let MeterReading = _prefixId.prefix "MeterReading"
    /// <summary>
    ///   <para>rdfs:label : Metering function</para>
    ///   <para>rdfs:comment : A function that allows to get data from a meter, such as current meter reading or instantaneous demand</para>
    ///   <a href="https://saref.etsi.org/core/MeteringFunction">saref:MeteringFunction</a>
    /// </summary>
    let MeteringFunction = _prefixId.prefix "MeteringFunction"
    /// <summary>
    ///   <para>rdfs:label : Motion</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value that is measured in a unit of measure for motion</para>
    ///   <a href="https://saref.etsi.org/core/Motion">saref:Motion</a>
    /// </summary>
    let Motion = _prefixId.prefix "Motion"
    /// <summary>
    ///   <para>rdfs:label : Multi level state</para>
    ///   <para>rdfs:comment : A type of state</para>
    ///   <a href="https://saref.etsi.org/core/MultiLevelState">saref:MultiLevelState</a>
    /// </summary>
    let MultiLevelState = _prefixId.prefix "MultiLevelState"
    /// <summary>
    ///   <para>rdfs:label : Notify command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/NotifyCommand">saref:NotifyCommand</a>
    /// </summary>
    let NotifyCommand = _prefixId.prefix "NotifyCommand"
    /// <summary>
    ///   <para>rdfs:label : Occupancy</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value (saref:hasValue property) that is measured in a unit of measure for occupancy</para>
    ///   <a href="https://saref.etsi.org/core/Occupancy">saref:Occupancy</a>
    /// </summary>
    let Occupancy = _prefixId.prefix "Occupancy"
    /// <summary>
    ///   <para>rdfs:label : Off command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/OffCommand">saref:OffCommand</a>
    /// </summary>
    let OffCommand = _prefixId.prefix "OffCommand"
    /// <summary>
    ///   <para>rdfs:label : Off state</para>
    ///   <para>rdfs:comment : The state of a device that is Off</para>
    ///   <a href="https://saref.etsi.org/core/OffState">saref:OffState</a>
    /// </summary>
    let OffState = _prefixId.prefix "OffState"
    /// <summary>
    ///   <para>rdfs:label : On command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/OnCommand">saref:OnCommand</a>
    /// </summary>
    let OnCommand = _prefixId.prefix "OnCommand"
    /// <summary>
    ///   <para>rdfs:label : On off function</para>
    ///   <para>rdfs:comment : An actuating function that allows to switch on and off an actuator</para>
    ///   <a href="https://saref.etsi.org/core/OnOffFunction">saref:OnOffFunction</a>
    /// </summary>
    let OnOffFunction = _prefixId.prefix "OnOffFunction"
    /// <summary>
    ///   <para>rdfs:label : On off state</para>
    ///   <para>rdfs:comment : A type of state</para>
    ///   <a href="https://saref.etsi.org/core/OnOffState">saref:OnOffState</a>
    /// </summary>
    let OnOffState = _prefixId.prefix "OnOffState"
    /// <summary>
    ///   <para>rdfs:label : On state</para>
    ///   <para>rdfs:comment : The state of a device that is On</para>
    ///   <a href="https://saref.etsi.org/core/OnState">saref:OnState</a>
    /// </summary>
    let OnState = _prefixId.prefix "OnState"
    /// <summary>
    ///   <para>rdfs:label : Open close function</para>
    ///   <para>rdfs:comment : An actuating function that allows to open and close a device</para>
    ///   <a href="https://saref.etsi.org/core/OpenCloseFunction">saref:OpenCloseFunction</a>
    /// </summary>
    let OpenCloseFunction = _prefixId.prefix "OpenCloseFunction"
    /// <summary>
    ///   <para>rdfs:label : Open close state</para>
    ///   <para>rdfs:comment : A type of state</para>
    ///   <a href="https://saref.etsi.org/core/OpenCloseState">saref:OpenCloseState</a>
    /// </summary>
    let OpenCloseState = _prefixId.prefix "OpenCloseState"
    /// <summary>
    ///   <para>rdfs:label : Open command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/OpenCommand">saref:OpenCommand</a>
    /// </summary>
    let OpenCommand = _prefixId.prefix "OpenCommand"
    /// <summary>
    ///   <para>rdfs:label : Open state</para>
    ///   <para>rdfs:comment : The state of a device that is OPEN </para>
    ///   <a href="https://saref.etsi.org/core/OpenState">saref:OpenState</a>
    /// </summary>
    let OpenState = _prefixId.prefix "OpenState"
    /// <summary>
    ///   <para>rdfs:label : Pause command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/PauseCommand">saref:PauseCommand</a>
    /// </summary>
    let PauseCommand = _prefixId.prefix "PauseCommand"
    /// <summary>
    ///   <para>rdfs:label : Power</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value that is measured in a power unit (such as watt or kilowatt).  Further specializations of the saref:Power class can be found in the SAREF4ENER extension, where classes such as PowerMax, PowerMin and PowerExpected are defined.</para>
    ///   <a href="https://saref.etsi.org/core/Power">saref:Power</a>
    /// </summary>
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:label : Power unit</para>
    ///   <para>rdfs:comment : The unit of measure for power</para>
    ///   <a href="https://saref.etsi.org/core/PowerUnit">saref:PowerUnit</a>
    /// </summary>
    let PowerUnit = _prefixId.prefix "PowerUnit"
    /// <summary>
    ///   <para>rdfs:label : Pressure</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value that is measured in a pressure unit (bar or pascal)</para>
    ///   <a href="https://saref.etsi.org/core/Pressure">saref:Pressure</a>
    /// </summary>
    let Pressure = _prefixId.prefix "Pressure"
    /// <summary>
    ///   <para>rdfs:label : Pressure unit</para>
    ///   <para>rdfs:comment : The unit of measure for pressure</para>
    ///   <a href="https://saref.etsi.org/core/PressureUnit">saref:PressureUnit</a>
    /// </summary>
    let PressureUnit = _prefixId.prefix "PressureUnit"
    /// <summary>
    ///   <para>rdfs:label : Price</para>
    ///   <para>rdfs:comment : A saref:Property crelated to some measurements that are characterized by a certain value that is measured using saref:Currency</para>
    ///   <a href="https://saref.etsi.org/core/Price">saref:Price</a>
    /// </summary>
    let Price = _prefixId.prefix "Price"
    /// <summary>
    ///   <para>rdfs:label : Profile</para>
    ///   <para>rdfs:comment : A specification associated to a device to collect information about a certain Property (e.g., Energy) for optimizing its usage in the home, office or building in which the device is located. This specification is about a certain Property (saref:isAbout), can be calculated over a time span (saref:hasTime) and can be associated to some costs (saref:hasPrice). An example is the Power Profile defined in the SAREF4ENER extension that can be associated to a device for optimizing the Energy efficiency in the home, office or building in which the device is located.</para>
    ///   <a href="https://saref.etsi.org/core/Profile">saref:Profile</a>
    /// </summary>
    let Profile = _prefixId.prefix "Profile"
    /// <summary>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : A quality of a feature of interest that can be measured; an aspect of a feature of interest that is intrinsic to and cannot exist without the feature</para>
    ///   <a href="https://saref.etsi.org/core/Property">saref:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    let Safety = _prefixId.prefix "Safety"
    /// <summary>
    ///   <para>rdfs:label : Sensing function</para>
    ///   <para>rdfs:comment : A function that allows to transmit data from sensors, such as measurement values (e.g., temperature) or sensing data (e.g., occupancy)</para>
    ///   <a href="https://saref.etsi.org/core/SensingFunction">saref:SensingFunction</a>
    /// </summary>
    let SensingFunction = _prefixId.prefix "SensingFunction"
    /// <summary>
    ///   <para>rdfs:label : Sensor</para>
    ///   <para>rdfs:comment : A device that detects and responds to events or changes in the physical environment such as light, motion, or temperature changes. Further, a device of category saref:Sensor that performs a saref:SensingFunction.</para>
    ///   <a href="https://saref.etsi.org/core/Sensor">saref:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : A service is a representation of a function to a network that makes the function discoverable, registerable, remotely controllable by other devices in the network. A service can represent one or more functions. A Service is offered by a device that wants (a certain set of) its function(s) to be discoverable, registerable, remotely controllable by other devices in the network. A Service must specify the device that is offering the service and the function(s) to be represented.</para>
    ///   <a href="https://saref.etsi.org/core/Service">saref:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Set absolute level command</para>
    ///   <para>rdfs:comment : A type of set level command</para>
    ///   <a href="https://saref.etsi.org/core/SetAbsoluteLevelCommand">saref:SetAbsoluteLevelCommand</a>
    /// </summary>
    let SetAbsoluteLevelCommand = _prefixId.prefix "SetAbsoluteLevelCommand"
    /// <summary>
    ///   <para>rdfs:label : Set level command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/SetLevelCommand">saref:SetLevelCommand</a>
    /// </summary>
    let SetLevelCommand = _prefixId.prefix "SetLevelCommand"
    /// <summary>
    ///   <para>rdfs:label : Set relative level command</para>
    ///   <para>rdfs:comment : A type of set level command</para>
    ///   <a href="https://saref.etsi.org/core/SetRelativeLevelCommand">saref:SetRelativeLevelCommand</a>
    /// </summary>
    let SetRelativeLevelCommand = _prefixId.prefix "SetRelativeLevelCommand"
    /// <summary>
    ///   <para>rdfs:label : Smoke</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value that is measured in a unit of measure for smoke</para>
    ///   <a href="https://saref.etsi.org/core/Smoke">saref:Smoke</a>
    /// </summary>
    let Smoke = _prefixId.prefix "Smoke"
    /// <summary>
    ///   <para>rdfs:label : Smoke sensor</para>
    ///   <para>rdfs:comment : A sensor that performs the saref:SensingFunction and the saref:EventFunction, and is used for the purpose of sensing a property of type saref:Smoke. A saref:SmokeSensor is typically used to saref:accomplish saref:Safety.</para>
    ///   <a href="https://saref.etsi.org/core/SmokeSensor">saref:SmokeSensor</a>
    /// </summary>
    let SmokeSensor = _prefixId.prefix "SmokeSensor"
    /// <summary>
    ///   <para>rdfs:label : Start command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/StartCommand">saref:StartCommand</a>
    /// </summary>
    let StartCommand = _prefixId.prefix "StartCommand"
    /// <summary>
    ///   <para>rdfs:label : Start state</para>
    ///   <para>rdfs:comment : The state of a device that is STARTED</para>
    ///   <a href="https://saref.etsi.org/core/StartState">saref:StartState</a>
    /// </summary>
    let StartState = _prefixId.prefix "StartState"
    /// <summary>
    ///   <para>rdfs:label : Start stop function</para>
    ///   <para>rdfs:comment : An actuating function that allows to start and stop a device</para>
    ///   <a href="https://saref.etsi.org/core/StartStopFunction">saref:StartStopFunction</a>
    /// </summary>
    let StartStopFunction = _prefixId.prefix "StartStopFunction"
    /// <summary>
    ///   <para>rdfs:label : Start stop state</para>
    ///   <para>rdfs:comment : A type of state</para>
    ///   <a href="https://saref.etsi.org/core/StartStopState">saref:StartStopState</a>
    /// </summary>
    let StartStopState = _prefixId.prefix "StartStopState"
    /// <summary>
    ///   <para>rdfs:label : State</para>
    ///   <para>rdfs:comment : The state in which a device can be found, e.g, ON/OFF/STANDBY, or ONLINE/OFFLINE. We propose here a list of states that are relevant for the purpose of SAREF, but this list can be extended.</para>
    ///   <a href="https://saref.etsi.org/core/State">saref:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Step down command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/StepDownCommand">saref:StepDownCommand</a>
    /// </summary>
    let StepDownCommand = _prefixId.prefix "StepDownCommand"
    /// <summary>
    ///   <para>rdfs:label : Step up command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/StepUpCommand">saref:StepUpCommand</a>
    /// </summary>
    let StepUpCommand = _prefixId.prefix "StepUpCommand"
    /// <summary>
    ///   <para>rdfs:label : Stop command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/StopCommand">saref:StopCommand</a>
    /// </summary>
    let StopCommand = _prefixId.prefix "StopCommand"
    /// <summary>
    ///   <para>rdfs:label : Stop state</para>
    ///   <para>rdfs:comment : The state of a device that is STOPPED</para>
    ///   <a href="https://saref.etsi.org/core/StopState">saref:StopState</a>
    /// </summary>
    let StopState = _prefixId.prefix "StopState"
    /// <summary>
    ///   <para>rdfs:label : Switch</para>
    ///   <para>rdfs:comment : A device of category saref:Actuator that performs an actuating function of type saref:OnOffFunction or saref:OpenCloseFunction</para>
    ///   <a href="https://saref.etsi.org/core/Switch">saref:Switch</a>
    /// </summary>
    let Switch = _prefixId.prefix "Switch"
    /// <summary>
    ///   <para>rdfs:label : Switch on service</para>
    ///   <para>rdfs:comment : A type of service that represents an on/off function to the network</para>
    ///   <a href="https://saref.etsi.org/core/SwitchOnService">saref:SwitchOnService</a>
    /// </summary>
    let SwitchOnService = _prefixId.prefix "SwitchOnService"
    /// <summary>
    ///   <para>rdfs:label : Task</para>
    ///   <para>rdfs:comment : The goal for which a device is designed (from a user perspective). For example, a washing machine is designed for the task of washing. We propose here a list of tasks that are relevant for the purpose of SAREF, but this list can be extended. Tasks can be accomplished by devices (saref:isAccomplishedBy).</para>
    ///   <a href="https://saref.etsi.org/core/Task">saref:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:label : Temperature</para>
    ///   <para>rdfs:comment : A saref:Property related to some measurements that are characterized by a certain value that is measured in a temperature unit (degree_Celsius, degree_Fahrenheit, or degree_kelvin)</para>
    ///   <a href="https://saref.etsi.org/core/Temperature">saref:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>rdfs:label : Temperature sensor</para>
    ///   <para>rdfs:comment : A sensor that is used for the purpose of sensing a property of type saref:Temperature. A saref:TemperatureSensor is typically used to saref:accomplish saref:Comfort.</para>
    ///   <a href="https://saref.etsi.org/core/TemperatureSensor">saref:TemperatureSensor</a>
    /// </summary>
    let TemperatureSensor = _prefixId.prefix "TemperatureSensor"
    /// <summary>
    ///   <para>rdfs:label : Temperature unit</para>
    ///   <para>rdfs:comment : The unit of measure for temperature</para>
    ///   <a href="https://saref.etsi.org/core/TemperatureUnit">saref:TemperatureUnit</a>
    /// </summary>
    let TemperatureUnit = _prefixId.prefix "TemperatureUnit"
    /// <summary>
    ///   <para>rdfs:label : Time</para>
    ///   <para>rdfs:comment : A class that allows to specify the time concept.</para>
    ///   <a href="https://saref.etsi.org/core/Time">saref:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:label : Toggle command</para>
    ///   <para>rdfs:comment : A type of command</para>
    ///   <a href="https://saref.etsi.org/core/ToggleCommand">saref:ToggleCommand</a>
    /// </summary>
    let ToggleCommand = _prefixId.prefix "ToggleCommand"
    /// <summary>
    ///   <para>rdfs:label : Unit of measure</para>
    ///   <para>rdfs:comment : The unit of measure is a standard for measurement of a quantity, such as a Property. For example,  Power is a property and Watt is a unit of power that represents a definite predetermined power: when we say 10 Watt, we actually mean 10 times the definite predetermined power called "watt". Our definition is based on the definition of unit of measure in the Ontology of units of Measure (OM). We propose here a list of some units of measure that are relevant for the purpose of SAREF, but this list can be extended, also using some other ontologies rather than the Ontology of units of Measure (OM).</para>
    ///   <a href="https://saref.etsi.org/core/UnitOfMeasure">saref:UnitOfMeasure</a>
    /// </summary>
    let UnitOfMeasure = _prefixId.prefix "UnitOfMeasure"
    let Washing = _prefixId.prefix "Washing"
    /// <summary>
    ///   <para>rdfs:label : Water</para>
    ///   <para>rdfs:comment : A type of commodity</para>
    ///   <a href="https://saref.etsi.org/core/Water">saref:Water</a>
    /// </summary>
    let Water = _prefixId.prefix "Water"
    let WellBeing = _prefixId.prefix "WellBeing"
    /// <summary>
    ///   <para>rdfs:label : accomplishes</para>
    ///   <para>rdfs:comment : A relationship between a certain entity (e.g., a device) and the task it accomplishes</para>
    ///   <a href="https://saref.etsi.org/core/accomplishes">saref:accomplishes</a>
    /// </summary>
    let accomplishes = _prefixId.prefix "accomplishes"
    /// <summary>
    ///   <para>rdfs:label : acts upon</para>
    ///   <para>rdfs:comment : A relationship between a command and a state</para>
    ///   <a href="https://saref.etsi.org/core/actsUpon">saref:actsUpon</a>
    /// </summary>
    let actsUpon = _prefixId.prefix "actsUpon"
    /// <summary>
    ///   <para>rdfs:label : consists of</para>
    ///   <para>rdfs:comment : A relationship indicating a composite entity that consists of other entities (e.g., a temperature/humidity sensor that consists of a temperature sensor and a humidity sensor)</para>
    ///   <a href="https://saref.etsi.org/core/consistsOf">saref:consistsOf</a>
    /// </summary>
    let consistsOf = _prefixId.prefix "consistsOf"
    /// <summary>
    ///   <para>rdfs:label : controls property</para>
    ///   <para>rdfs:comment : A relationship specifying the property that can be controlled by a certain device</para>
    ///   <a href="https://saref.etsi.org/core/controlsProperty">saref:controlsProperty</a>
    /// </summary>
    let controlsProperty = _prefixId.prefix "controlsProperty"
    /// <summary>
    ///   <para>rdfs:label : has command</para>
    ///   <para>rdfs:comment : A relationship between a function and a command</para>
    ///   <a href="https://saref.etsi.org/core/hasCommand">saref:hasCommand</a>
    /// </summary>
    let hasCommand = _prefixId.prefix "hasCommand"
    /// <summary>
    ///   <para>rdfs:label : has description</para>
    ///   <para>rdfs:comment : A relationship providing a description of an entity (e.g., device). The value is expected to be a string or a string with language tag.rdfs:comment : DEPRECATED: The use of rdfs:comment is recommended instead.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <a href="https://saref.etsi.org/core/hasDescription">saref:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : has function</para>
    ///   <para>rdfs:comment : A relationship identifying the function of a device</para>
    ///   <a href="https://saref.etsi.org/core/hasFunction">saref:hasFunction</a>
    /// </summary>
    let hasFunction = _prefixId.prefix "hasFunction"
    /// <summary>
    ///   <para>rdfs:label : has manufacturer</para>
    ///   <para>rdfs:comment : A relationship identifying the manufacturer of an entity (e.g., device). The value is expected to be a string or a string with language tag.</para>
    ///   <a href="https://saref.etsi.org/core/hasManufacturer">saref:hasManufacturer</a>
    /// </summary>
    let hasManufacturer = _prefixId.prefix "hasManufacturer"
    /// <summary>
    ///   <para>rdfs:label : has measurement</para>
    ///   <para>rdfs:comment : A relationship between a feature of interest and a measurement about it</para>
    ///   <a href="https://saref.etsi.org/core/hasMeasurement">saref:hasMeasurement</a>
    /// </summary>
    let hasMeasurement = _prefixId.prefix "hasMeasurement"
    /// <summary>
    ///   <para>rdfs:label : has meter reading</para>
    ///   <para>rdfs:comment : A relationship between a metering function and the measurement of the reading</para>
    ///   <a href="https://saref.etsi.org/core/hasMeterReading">saref:hasMeterReading</a>
    /// </summary>
    let hasMeterReading = _prefixId.prefix "hasMeterReading"
    /// <summary>
    ///   <para>rdfs:label : has meter reading type</para>
    ///   <para>rdfs:comment : A relationship identifying the reading type of a metering function (e.g., Water, Gas, Pressure , Energy , Power, etc.)</para>
    ///   <a href="https://saref.etsi.org/core/hasMeterReadingType">saref:hasMeterReadingType</a>
    /// </summary>
    let hasMeterReadingType = _prefixId.prefix "hasMeterReadingType"
    /// <summary>
    ///   <para>rdfs:label : has model</para>
    ///   <para>rdfs:comment : A relationship identifying the model of an entity (e.g., device). The value is expected to be a string or a string with language tag.</para>
    ///   <a href="https://saref.etsi.org/core/hasModel">saref:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    /// <summary>
    ///   <para>rdfs:label : has price</para>
    ///   <para>rdfs:comment : A relationship indentifying the price associated to an entity</para>
    ///   <a href="https://saref.etsi.org/core/hasPrice">saref:hasPrice</a>
    /// </summary>
    let hasPrice = _prefixId.prefix "hasPrice"
    /// <summary>
    ///   <para>rdfs:label : has profile</para>
    ///   <para>rdfs:comment : A relationship associating a profile to a certain device</para>
    ///   <a href="https://saref.etsi.org/core/hasProfile">saref:hasProfile</a>
    /// </summary>
    let hasProfile = _prefixId.prefix "hasProfile"
    /// <summary>
    ///   <para>rdfs:label : has property</para>
    ///   <para>rdfs:comment : A relationship between a feature of interest and a property of that feature</para>
    ///   <a href="https://saref.etsi.org/core/hasProperty">saref:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>rdfs:label : has sensing range</para>
    ///   <para>rdfs:comment : A relationship between a sensing function and a measurement identifying the range of a sensor detection</para>
    ///   <a href="https://saref.etsi.org/core/hasSensingRange">saref:hasSensingRange</a>
    /// </summary>
    let hasSensingRange = _prefixId.prefix "hasSensingRange"
    /// <summary>
    ///   <para>rdfs:label : has sensor type</para>
    ///   <para>rdfs:comment : A relationship identifying the sensing type of a sensor detection (i.e., Temperature, Occupancy, Humidity, Motion , Smoke, Pressure, etc.) </para>
    ///   <a href="https://saref.etsi.org/core/hasSensorType">saref:hasSensorType</a>
    /// </summary>
    let hasSensorType = _prefixId.prefix "hasSensorType"
    /// <summary>
    ///   <para>rdfs:label : has state</para>
    ///   <para>rdfs:comment : A relationship identifying the type of state of a device</para>
    ///   <a href="https://saref.etsi.org/core/hasState">saref:hasState</a>
    /// </summary>
    let hasState = _prefixId.prefix "hasState"
    /// <summary>
    ///   <para>rdfs:label : has threshold measurement</para>
    ///   <para>rdfs:comment : A relationship associated with an event function to notify that a certain threshold measurement has been exceeded</para>
    ///   <a href="https://saref.etsi.org/core/hasThresholdMeasurement">saref:hasThresholdMeasurement</a>
    /// </summary>
    let hasThresholdMeasurement = _prefixId.prefix "hasThresholdMeasurement"
    /// <summary>
    ///   <para>rdfs:label : has time</para>
    ///   <para>rdfs:comment : A relationship to associate time information to an entity</para>
    ///   <a href="https://saref.etsi.org/core/hasTime">saref:hasTime</a>
    /// </summary>
    let hasTime = _prefixId.prefix "hasTime"
    /// <summary>
    ///   <para>rdfs:label : has timestamp</para>
    ///   <para>rdfs:comment : A relationship stating the timestamp of an entity (e.g. a measurement).</para>
    ///   <a href="https://saref.etsi.org/core/hasTimestamp">saref:hasTimestamp</a>
    /// </summary>
    let hasTimestamp = _prefixId.prefix "hasTimestamp"
    /// <summary>
    ///   <para>rdfs:label : has typical consumption</para>
    ///   <para>rdfs:comment : A relationship identifying the typical (energy or power) consumption of a device</para>
    ///   <a href="https://saref.etsi.org/core/hasTypicalConsumption">saref:hasTypicalConsumption</a>
    /// </summary>
    let hasTypicalConsumption = _prefixId.prefix "hasTypicalConsumption"
    /// <summary>
    ///   <para>rdfs:label : has value</para>
    ///   <para>rdfs:comment : A relationship defining the value of a certain property, e.g., energy or power. Note that, even if numeric values are expected to enable reasoning, measurement values could use other datatypes.</para>
    ///   <a href="https://saref.etsi.org/core/hasValue">saref:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : isAbout</para>
    ///   <para>rdfs:comment : A relationship identifying what an entity, such as a profile, is about</para>
    ///   <a href="https://saref.etsi.org/core/isAbout">saref:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : is accomplished by</para>
    ///   <para>rdfs:comment : A relationship identifying an entity (e.g., a device) that can accomplish a task.</para>
    ///   <a href="https://saref.etsi.org/core/isAccomplishedBy">saref:isAccomplishedBy</a>
    /// </summary>
    let isAccomplishedBy = _prefixId.prefix "isAccomplishedBy"
    /// <summary>
    ///   <para>rdfs:label : is command of</para>
    ///   <para>rdfs:comment : A relationship between a command and a function.</para>
    ///   <a href="https://saref.etsi.org/core/isCommandOf">saref:isCommandOf</a>
    /// </summary>
    let isCommandOf = _prefixId.prefix "isCommandOf"
    /// <summary>
    ///   <para>rdfs:label : is controlled by device</para>
    ///   <para>rdfs:comment : A relationship specifying the devices that can control a certain property</para>
    ///   <a href="https://saref.etsi.org/core/isControlledByDevice">saref:isControlledByDevice</a>
    /// </summary>
    let isControlledByDevice = _prefixId.prefix "isControlledByDevice"
    /// <summary>
    ///   <para>rdfs:label : is measured by device</para>
    ///   <para>rdfs:comment : A relationship specifying the devices that can measure a certain property</para>
    ///   <a href="https://saref.etsi.org/core/isMeasuredByDevice">saref:isMeasuredByDevice</a>
    /// </summary>
    let isMeasuredByDevice = _prefixId.prefix "isMeasuredByDevice"
    /// <summary>
    ///   <para>rdfs:label : is measured in</para>
    ///   <para>rdfs:comment : A relationship identifying the unit of measure used for a certain entity.</para>
    ///   <a href="https://saref.etsi.org/core/isMeasuredIn">saref:isMeasuredIn</a>
    /// </summary>
    let isMeasuredIn = _prefixId.prefix "isMeasuredIn"
    /// <summary>
    ///   <para>rdfs:label : isMeasurementOf</para>
    ///   <para>rdfs:comment : A relationship between a measurement and the feature of interest whose quality was measured</para>
    ///   <a href="https://saref.etsi.org/core/isMeasurementOf">saref:isMeasurementOf</a>
    /// </summary>
    let isMeasurementOf = _prefixId.prefix "isMeasurementOf"
    /// <summary>
    ///   <para>rdfs:label : is offered by</para>
    ///   <para>rdfs:comment : A relationship between a service and a device that offers the service</para>
    ///   <a href="https://saref.etsi.org/core/isOfferedBy">saref:isOfferedBy</a>
    /// </summary>
    let isOfferedBy = _prefixId.prefix "isOfferedBy"
    /// <summary>
    ///   <para>rdfs:label : is property of</para>
    ///   <para>rdfs:comment : A relationship between a property and the feature of interest it belongs to</para>
    ///   <a href="https://saref.etsi.org/core/isPropertyOf">saref:isPropertyOf</a>
    /// </summary>
    let isPropertyOf = _prefixId.prefix "isPropertyOf"
    /// <summary>
    ///   <para>rdfs:label : is used for</para>
    ///   <para>rdfs:comment : A relationship specifying the commodity for which a device is used for</para>
    ///   <a href="https://saref.etsi.org/core/isUsedFor">saref:isUsedFor</a>
    /// </summary>
    let isUsedFor = _prefixId.prefix "isUsedFor"
    /// <summary>
    ///   <para>rdfs:label : makes measurement</para>
    ///   <para>rdfs:comment : A relation between a device and the measurements it makes. Such measurement will link together the value of the measurement, its unit of measure and the property to which it relates.</para>
    ///   <a href="https://saref.etsi.org/core/makesMeasurement">saref:makesMeasurement</a>
    /// </summary>
    let makesMeasurement = _prefixId.prefix "makesMeasurement"
    /// <summary>
    ///   <para>rdfs:label : measurement made by</para>
    ///   <para>rdfs:comment : A relation between a measurement and the device that made it.</para>
    ///   <a href="https://saref.etsi.org/core/measurementMadeBy">saref:measurementMadeBy</a>
    /// </summary>
    let measurementMadeBy = _prefixId.prefix "measurementMadeBy"
    /// <summary>
    ///   <para>rdfs:label : measures property</para>
    ///   <para>rdfs:comment : A relationship specifying the property that can be measured by a certain device</para>
    ///   <a href="https://saref.etsi.org/core/measuresProperty">saref:measuresProperty</a>
    /// </summary>
    let measuresProperty = _prefixId.prefix "measuresProperty"
    /// <summary>
    ///   <para>rdfs:label : offers</para>
    ///   <para>rdfs:comment : A relationship between a device and a service</para>
    ///   <a href="https://saref.etsi.org/core/offers">saref:offers</a>
    /// </summary>
    let offers = _prefixId.prefix "offers"
    /// <summary>
    ///   <para>rdfs:label : relates to measurement</para>
    ///   <para>rdfs:comment : A relationship between a property and the measurements it relates to</para>
    ///   <a href="https://saref.etsi.org/core/relatesToMeasurement">saref:relatesToMeasurement</a>
    /// </summary>
    let relatesToMeasurement = _prefixId.prefix "relatesToMeasurement"
    /// <summary>
    ///   <para>rdfs:label : relates to property</para>
    ///   <para>rdfs:comment : A relationship between a measurement and the property it relates to</para>
    ///   <a href="https://saref.etsi.org/core/relatesToProperty">saref:relatesToProperty</a>
    /// </summary>
    let relatesToProperty = _prefixId.prefix "relatesToProperty"
    /// <summary>
    ///   <para>rdfs:label : represents</para>
    ///   <para>rdfs:comment : A relationship between a service and a function.</para>
    ///   <a href="https://saref.etsi.org/core/represents">saref:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
