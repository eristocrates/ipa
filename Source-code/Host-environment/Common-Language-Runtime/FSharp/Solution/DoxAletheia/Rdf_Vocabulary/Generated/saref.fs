namespace https.saref.etsi.org.core.slash

open DoxAletheia

module saref =
    let _namespace_name = "https://saref.etsi.org/core/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://saref.etsi.org/core/v3.1.1/"></see>
    /// </summary>
    let ``v3.1.1/`` = _prefix "v3.1.1/"
    /// <summary>
    /// A function that allows to transmit data to actuators, such as level settings (e.g., temperature) or binary switching (e.g., open/close, on/off)
    /// <see href="https://saref.etsi.org/core/ActuatingFunction"></see></summary>
    let ActuatingFunction = _prefix "ActuatingFunction"
    /// <summary>
    /// The functionality necessary to accomplish the task for which a device is designed. A device can be designed to perform more than one function. Functions can be structured in categories (subclasses) that reflect different points of view, for example, considering the specific application area for which a function can be used (e.g., light, temperature, motion, heat, power, etc.), or the capability that a function can support (e.g., receive, reply, notify, etc.), and so forth.
    /// <see href="https://saref.etsi.org/core/Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// A device responsible for moving or controlling a mechanism or system by performing an actuating function
    /// <see href="https://saref.etsi.org/core/Actuator"></see></summary>
    let Actuator = _prefix "Actuator"
    /// <summary>
    /// A relationship identifying the function of a device
    /// <see href="https://saref.etsi.org/core/hasFunction"></see></summary>
    let hasFunction = _prefix "hasFunction"
    /// <summary>
    /// A tangible object designed to accomplish a particular task. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function.
    /// <see href="https://saref.etsi.org/core/Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// An electrical/mechanical machine that accomplish some household functions, such as cleaning or cooking
    /// <see href="https://saref.etsi.org/core/Appliance"></see></summary>
    let Appliance = _prefix "Appliance"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Cleaning"></see></summary>
    let Cleaning = _prefix "Cleaning"
    /// <summary>
    /// The goal for which a device is designed (from a user perspective). For example, a washing machine is designed for the task of washing. We propose here a list of tasks that are relevant for the purpose of SAREF, but this list can be extended. Tasks can be accomplished by devices (saref:isAccomplishedBy).
    /// <see href="https://saref.etsi.org/core/Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/CloseCommand"></see></summary>
    let CloseCommand = _prefix "CloseCommand"
    /// <summary>
    /// An actuating function that allows to open and close a device
    /// <see href="https://saref.etsi.org/core/OpenCloseFunction"></see></summary>
    let OpenCloseFunction = _prefix "OpenCloseFunction"
    /// <summary>
    /// A relationship between a command and a function.
    /// <see href="https://saref.etsi.org/core/isCommandOf"></see></summary>
    let isCommandOf = _prefix "isCommandOf"
    /// <summary>
    /// A type of state
    /// <see href="https://saref.etsi.org/core/OpenCloseState"></see></summary>
    let OpenCloseState = _prefix "OpenCloseState"
    /// <summary>
    /// A relationship between a command and a state
    /// <see href="https://saref.etsi.org/core/actsUpon"></see></summary>
    let actsUpon = _prefix "actsUpon"
    /// <summary>
    /// A directive that a device must support to perform a certain function. A command may act upon a state, but does not necessarily act upon a state. For example, the ON command acts upon the ON/OFF state, but the GET command does not act upon any state, it simply gives a directive to retrieve a certain value. We propose here a list of commands that are relevant for the purpose of SAREF, but this list can be extended.
    /// <see href="https://saref.etsi.org/core/Command"></see></summary>
    let Command = _prefix "Command"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/OpenCommand"></see></summary>
    let OpenCommand = _prefix "OpenCommand"
    /// <summary>
    /// The state of a device that is CLOSE
    /// <see href="https://saref.etsi.org/core/CloseState"></see></summary>
    let CloseState = _prefix "CloseState"
    /// <summary>
    /// A type of commodity
    /// <see href="https://saref.etsi.org/core/Coal"></see></summary>
    let Coal = _prefix "Coal"
    /// <summary>
    /// A marketable item for which there is demand, but which is supplied without qualitative differentiation across a market. SAREF refers to energy commodities such as electricity, gas, coal and oil.
    /// <see href="https://saref.etsi.org/core/Commodity"></see></summary>
    let Commodity = _prefix "Commodity"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Comfort"></see></summary>
    let Comfort = _prefix "Comfort"
    /// <summary>
    /// The state in which a device can be found, e.g, ON/OFF/STANDBY, or ONLINE/OFFLINE. We propose here a list of states that are relevant for the purpose of SAREF, but this list can be extended.
    /// <see href="https://saref.etsi.org/core/State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// The class of units of measure for price
    /// <see href="https://saref.etsi.org/core/Currency"></see></summary>
    let Currency = _prefix "Currency"
    /// <summary>
    /// The unit of measure is a standard for measurement of a quantity, such as a Property. For example,  Power is a property and Watt is a unit of power that represents a definite predetermined power: when we say 10 Watt, we actually mean 10 times the definite predetermined power called "watt". Our definition is based on the definition of unit of measure in the Ontology of units of Measure (OM). We propose here a list of some units of measure that are relevant for the purpose of SAREF, but this list can be extended, also using some other ontologies rather than the Ontology of units of Measure (OM).
    /// <see href="https://saref.etsi.org/core/UnitOfMeasure"></see></summary>
    let UnitOfMeasure = _prefix "UnitOfMeasure"
    /// <summary>
    /// A relationship identifying the manufacturer of an entity (e.g., device). The value is expected to be a string or a string with language tag.
    /// <see href="https://saref.etsi.org/core/hasManufacturer"></see></summary>
    let hasManufacturer = _prefix "hasManufacturer"
    /// <summary>
    /// A relationship identifying the model of an entity (e.g., device). The value is expected to be a string or a string with language tag.
    /// <see href="https://saref.etsi.org/core/hasModel"></see></summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    /// A relationship identifying the type of state of a device
    /// <see href="https://saref.etsi.org/core/hasState"></see></summary>
    let hasState = _prefix "hasState"
    /// <summary>
    /// Represents the measured value made over a property. It is also linked to the unit of measure in which the value is expressed and the timestamp of the measurement.
    /// <see href="https://saref.etsi.org/core/Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// A relation between a device and the measurements it makes. Such measurement will link together the value of the measurement, its unit of measure and the property to which it relates.
    /// <see href="https://saref.etsi.org/core/makesMeasurement"></see></summary>
    let makesMeasurement = _prefix "makesMeasurement"
    /// <summary>
    /// A quality of a feature of interest that can be measured; an aspect of a feature of interest that is intrinsic to and cannot exist without the feature
    /// <see href="https://saref.etsi.org/core/Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// A relationship specifying the property that can be controlled by a certain device
    /// <see href="https://saref.etsi.org/core/controlsProperty"></see></summary>
    let controlsProperty = _prefix "controlsProperty"
    /// <summary>
    /// A relationship specifying the property that can be measured by a certain device
    /// <see href="https://saref.etsi.org/core/measuresProperty"></see></summary>
    let measuresProperty = _prefix "measuresProperty"
    /// <summary>
    /// A relationship indicating a composite entity that consists of other entities (e.g., a temperature/humidity sensor that consists of a temperature sensor and a humidity sensor)
    /// <see href="https://saref.etsi.org/core/consistsOf"></see></summary>
    let consistsOf = _prefix "consistsOf"
    /// <summary>
    /// A relationship specifying the commodity for which a device is used for
    /// <see href="https://saref.etsi.org/core/isUsedFor"></see></summary>
    let isUsedFor = _prefix "isUsedFor"
    /// <summary>
    /// A relationship between a certain entity (e.g., a device) and the task it accomplishes
    /// <see href="https://saref.etsi.org/core/accomplishes"></see></summary>
    let accomplishes = _prefix "accomplishes"
    /// <summary>
    /// A service is a representation of a function to a network that makes the function discoverable, registerable, remotely controllable by other devices in the network. A service can represent one or more functions. A Service is offered by a device that wants (a certain set of) its function(s) to be discoverable, registerable, remotely controllable by other devices in the network. A Service must specify the device that is offering the service and the function(s) to be represented.
    /// <see href="https://saref.etsi.org/core/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A relationship between a device and a service
    /// <see href="https://saref.etsi.org/core/offers"></see></summary>
    let offers = _prefix "offers"
    /// <summary>
    /// A specification associated to a device to collect information about a certain Property (e.g., Energy) for optimizing its usage in the home, office or building in which the device is located. This specification is about a certain Property (saref:isAbout), can be calculated over a time span (saref:hasTime) and can be associated to some costs (saref:hasPrice). An example is the Power Profile defined in the SAREF4ENER extension that can be associated to a device for optimizing the Energy efficiency in the home, office or building in which the device is located.
    /// <see href="https://saref.etsi.org/core/Profile"></see></summary>
    let Profile = _prefix "Profile"
    /// <summary>
    /// A relationship associating a profile to a certain device
    /// <see href="https://saref.etsi.org/core/hasProfile"></see></summary>
    let hasProfile = _prefix "hasProfile"
    /// <summary>
    /// A switch that performs the saref:OpenCloseFunction, is used for controlling a door, and can be found in the state saref:OpenCloseState. A saref:DoorSwitch is typically used to accomplish saref:Safety.
    /// <see href="https://saref.etsi.org/core/DoorSwitch"></see></summary>
    let DoorSwitch = _prefix "DoorSwitch"
    /// <summary>
    /// A device of category saref:Actuator that performs an actuating function of type saref:OnOffFunction or saref:OpenCloseFunction
    /// <see href="https://saref.etsi.org/core/Switch"></see></summary>
    let Switch = _prefix "Switch"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Drying"></see></summary>
    let Drying = _prefix "Drying"
    /// <summary>
    /// A type of commodity
    /// <see href="https://saref.etsi.org/core/Electricity"></see></summary>
    let Electricity = _prefix "Electricity"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value measured in an energy unit (such as Kilowatt_Hour or Watt_hour). Furter specializations of the saref:Energy class can be found in the SAREF4ENER extension, where classes such as EnergyMax, EnergyMin and EnergyExpected are defined.
    /// <see href="https://saref.etsi.org/core/Energy"></see></summary>
    let Energy = _prefix "Energy"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/EnergyEfficiency"></see></summary>
    let EnergyEfficiency = _prefix "EnergyEfficiency"
    /// <summary>
    /// The unit of measure for energy
    /// <see href="https://saref.etsi.org/core/EnergyUnit"></see></summary>
    let EnergyUnit = _prefix "EnergyUnit"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Entertainment"></see></summary>
    let Entertainment = _prefix "Entertainment"
    /// <summary>
    /// A function that allows to notify about some relevant activity; e.g., that a certain threshold value has been exceeded or that some object has moved.
    /// <see href="https://saref.etsi.org/core/EventFunction"></see></summary>
    let EventFunction = _prefix "EventFunction"
    /// <summary>
    /// A relationship associated with an event function to notify that a certain threshold measurement has been exceeded
    /// <see href="https://saref.etsi.org/core/hasThresholdMeasurement"></see></summary>
    let hasThresholdMeasurement = _prefix "hasThresholdMeasurement"
    /// <summary>
    /// A feature of interest represents any real world entity from which a property is measured.
    /// <see href="https://saref.etsi.org/core/FeatureOfInterest"></see></summary>
    let FeatureOfInterest = _prefix "FeatureOfInterest"
    /// <summary>
    /// A relationship between a feature of interest and a measurement about it
    /// <see href="https://saref.etsi.org/core/hasMeasurement"></see></summary>
    let hasMeasurement = _prefix "hasMeasurement"
    /// <summary>
    /// A relationship between a feature of interest and a property of that feature
    /// <see href="https://saref.etsi.org/core/hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// A relationship between a function and a command
    /// <see href="https://saref.etsi.org/core/hasCommand"></see></summary>
    let hasCommand = _prefix "hasCommand"
    /// <summary>
    /// A type of commodity
    /// <see href="https://saref.etsi.org/core/Gas"></see></summary>
    let Gas = _prefix "Gas"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/GetCommand"></see></summary>
    let GetCommand = _prefix "GetCommand"
    /// <summary>
    /// A type of get command
    /// <see href="https://saref.etsi.org/core/GetCurrentMeterValueCommand"></see></summary>
    let GetCurrentMeterValueCommand = _prefix "GetCurrentMeterValueCommand"
    /// <summary>
    /// A function that allows to get data from a meter, such as current meter reading or instantaneous demand
    /// <see href="https://saref.etsi.org/core/MeteringFunction"></see></summary>
    let MeteringFunction = _prefix "MeteringFunction"
    /// <summary>
    /// A type of get command
    /// <see href="https://saref.etsi.org/core/GetMeterDataCommand"></see></summary>
    let GetMeterDataCommand = _prefix "GetMeterDataCommand"
    /// <summary>
    /// A type of get command
    /// <see href="https://saref.etsi.org/core/GetMeterHistoryCommand"></see></summary>
    let GetMeterHistoryCommand = _prefix "GetMeterHistoryCommand"
    /// <summary>
    /// A type of get command
    /// <see href="https://saref.etsi.org/core/GetSensingDataCommand"></see></summary>
    let GetSensingDataCommand = _prefix "GetSensingDataCommand"
    /// <summary>
    /// A function that allows to transmit data from sensors, such as measurement values (e.g., temperature) or sensing data (e.g., occupancy)
    /// <see href="https://saref.etsi.org/core/SensingFunction"></see></summary>
    let SensingFunction = _prefix "SensingFunction"
    /// <summary>
    /// Heating, Ventilation and Air Conditioning (HVAC) device that provides indoor environmental comfort. A saref:HVAC is typically used to accomplish saref:Comfort.
    /// <see href="https://saref.etsi.org/core/HVAC"></see></summary>
    let HVAC = _prefix "HVAC"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a humidity unit
    /// <see href="https://saref.etsi.org/core/Humidity"></see></summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    /// The unit of measure for light
    /// <see href="https://saref.etsi.org/core/IlluminanceUnit"></see></summary>
    let IlluminanceUnit = _prefix "IlluminanceUnit"
    /// <summary>
    /// An actuating function that allows to do level adjustments of a property in a certain range (e.g., 0%-100%), such as dimming a light in a room or setting the speed of an electric motor.
    /// <see href="https://saref.etsi.org/core/LevelControlFunction"></see></summary>
    let LevelControlFunction = _prefix "LevelControlFunction"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a illuminance unit (lux)
    /// <see href="https://saref.etsi.org/core/Light"></see></summary>
    let Light = _prefix "Light"
    /// <summary>
    /// A switch that performs the saref:OnOffFunction, controls the property saref:Light, and can be found in the state saref:OnOffState. It can offer a switch on service. A saref:LightSwitch is typically used to accomplish saref:Lighting.
    /// <see href="https://saref.etsi.org/core/LightSwitch"></see></summary>
    let LightSwitch = _prefix "LightSwitch"
    /// <summary>
    /// A type of service that represents an on/off function to the network
    /// <see href="https://saref.etsi.org/core/SwitchOnService"></see></summary>
    let SwitchOnService = _prefix "SwitchOnService"
    /// <summary>
    /// A type of state
    /// <see href="https://saref.etsi.org/core/OnOffState"></see></summary>
    let OnOffState = _prefix "OnOffState"
    /// <summary>
    /// An actuating function that allows to switch on and off an actuator
    /// <see href="https://saref.etsi.org/core/OnOffFunction"></see></summary>
    let OnOffFunction = _prefix "OnOffFunction"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Lighting"></see></summary>
    let Lighting = _prefix "Lighting"
    /// <summary>
    /// A relationship between a measurement and the property it relates to
    /// <see href="https://saref.etsi.org/core/relatesToProperty"></see></summary>
    let relatesToProperty = _prefix "relatesToProperty"
    /// <summary>
    /// A relationship identifying the unit of measure used for a certain entity.
    /// <see href="https://saref.etsi.org/core/isMeasuredIn"></see></summary>
    let isMeasuredIn = _prefix "isMeasuredIn"
    /// <summary>
    /// A relationship stating the timestamp of an entity (e.g. a measurement).
    /// <see href="https://saref.etsi.org/core/hasTimestamp"></see></summary>
    let hasTimestamp = _prefix "hasTimestamp"
    /// <summary>
    /// A relationship between a measurement and the feature of interest whose quality was measured
    /// <see href="https://saref.etsi.org/core/isMeasurementOf"></see></summary>
    let isMeasurementOf = _prefix "isMeasurementOf"
    /// <summary>
    /// A relationship defining the value of a certain property, e.g., energy or power. Note that, even if numeric values are expected to enable reasoning, measurement values could use other datatypes.
    /// <see href="https://saref.etsi.org/core/hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// A device built to accurately detect and display a quantity in a form readable by a human being. Further, a device of category saref:Meter that performs a saref:MeteringFunction.
    /// <see href="https://saref.etsi.org/core/Meter"></see></summary>
    let Meter = _prefix "Meter"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/MeterReading"></see></summary>
    let MeterReading = _prefix "MeterReading"
    /// <summary>
    /// A relationship identifying the reading type of a metering function (e.g., Water, Gas, Pressure , Energy , Power, etc.)
    /// <see href="https://saref.etsi.org/core/hasMeterReadingType"></see></summary>
    let hasMeterReadingType = _prefix "hasMeterReadingType"
    /// <summary>
    /// A relationship between a metering function and the measurement of the reading
    /// <see href="https://saref.etsi.org/core/hasMeterReading"></see></summary>
    let hasMeterReading = _prefix "hasMeterReading"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a unit of measure for motion
    /// <see href="https://saref.etsi.org/core/Motion"></see></summary>
    let Motion = _prefix "Motion"
    /// <summary>
    /// A type of state
    /// <see href="https://saref.etsi.org/core/MultiLevelState"></see></summary>
    let MultiLevelState = _prefix "MultiLevelState"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/NotifyCommand"></see></summary>
    let NotifyCommand = _prefix "NotifyCommand"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value (saref:hasValue property) that is measured in a unit of measure for occupancy
    /// <see href="https://saref.etsi.org/core/Occupancy"></see></summary>
    let Occupancy = _prefix "Occupancy"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/OffCommand"></see></summary>
    let OffCommand = _prefix "OffCommand"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/OnCommand"></see></summary>
    let OnCommand = _prefix "OnCommand"
    /// <summary>
    /// The state of a device that is Off
    /// <see href="https://saref.etsi.org/core/OffState"></see></summary>
    let OffState = _prefix "OffState"
    /// <summary>
    /// The state of a device that is On
    /// <see href="https://saref.etsi.org/core/OnState"></see></summary>
    let OnState = _prefix "OnState"
    /// <summary>
    /// The state of a device that is OPEN
    /// <see href="https://saref.etsi.org/core/OpenState"></see></summary>
    let OpenState = _prefix "OpenState"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/PauseCommand"></see></summary>
    let PauseCommand = _prefix "PauseCommand"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a power unit (such as watt or kilowatt).  Further specializations of the saref:Power class can be found in the SAREF4ENER extension, where classes such as PowerMax, PowerMin and PowerExpected are defined.
    /// <see href="https://saref.etsi.org/core/Power"></see></summary>
    let Power = _prefix "Power"
    /// <summary>
    /// The unit of measure for power
    /// <see href="https://saref.etsi.org/core/PowerUnit"></see></summary>
    let PowerUnit = _prefix "PowerUnit"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a pressure unit (bar or pascal)
    /// <see href="https://saref.etsi.org/core/Pressure"></see></summary>
    let Pressure = _prefix "Pressure"
    /// <summary>
    /// The unit of measure for pressure
    /// <see href="https://saref.etsi.org/core/PressureUnit"></see></summary>
    let PressureUnit = _prefix "PressureUnit"
    /// <summary>
    /// A saref:Property crelated to some measurements that are characterized by a certain value that is measured using saref:Currency
    /// <see href="https://saref.etsi.org/core/Price"></see></summary>
    let Price = _prefix "Price"
    /// <summary>
    /// A relationship identifying what an entity, such as a profile, is about
    /// <see href="https://saref.etsi.org/core/isAbout"></see></summary>
    let isAbout = _prefix "isAbout"
    /// <summary>
    /// A class that allows to specify the time concept.
    /// <see href="https://saref.etsi.org/core/Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// A relationship to associate time information to an entity
    /// <see href="https://saref.etsi.org/core/hasTime"></see></summary>
    let hasTime = _prefix "hasTime"
    /// <summary>
    /// A relationship indentifying the price associated to an entity
    /// <see href="https://saref.etsi.org/core/hasPrice"></see></summary>
    let hasPrice = _prefix "hasPrice"
    /// <summary>
    /// A relationship between a property and the measurements it relates to
    /// <see href="https://saref.etsi.org/core/relatesToMeasurement"></see></summary>
    let relatesToMeasurement = _prefix "relatesToMeasurement"
    /// <summary>
    /// A relationship between a property and the feature of interest it belongs to
    /// <see href="https://saref.etsi.org/core/isPropertyOf"></see></summary>
    let isPropertyOf = _prefix "isPropertyOf"
    /// <summary>
    /// A relationship specifying the devices that can measure a certain property
    /// <see href="https://saref.etsi.org/core/isMeasuredByDevice"></see></summary>
    let isMeasuredByDevice = _prefix "isMeasuredByDevice"
    /// <summary>
    /// A relationship specifying the devices that can control a certain property
    /// <see href="https://saref.etsi.org/core/isControlledByDevice"></see></summary>
    let isControlledByDevice = _prefix "isControlledByDevice"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Safety"></see></summary>
    let Safety = _prefix "Safety"
    /// <summary>
    /// A relationship identifying the sensing type of a sensor detection (i.e., Temperature, Occupancy, Humidity, Motion , Smoke, Pressure, etc.)
    /// <see href="https://saref.etsi.org/core/hasSensorType"></see></summary>
    let hasSensorType = _prefix "hasSensorType"
    /// <summary>
    /// A relationship between a sensing function and a measurement identifying the range of a sensor detection
    /// <see href="https://saref.etsi.org/core/hasSensingRange"></see></summary>
    let hasSensingRange = _prefix "hasSensingRange"
    /// <summary>
    /// A device that detects and responds to events or changes in the physical environment such as light, motion, or temperature changes. Further, a device of category saref:Sensor that performs a saref:SensingFunction.
    /// <see href="https://saref.etsi.org/core/Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// A relationship between a service and a function.
    /// <see href="https://saref.etsi.org/core/represents"></see></summary>
    let represents = _prefix "represents"
    /// <summary>
    /// A relationship between a service and a device that offers the service
    /// <see href="https://saref.etsi.org/core/isOfferedBy"></see></summary>
    let isOfferedBy = _prefix "isOfferedBy"
    /// <summary>
    /// A type of set level command
    /// <see href="https://saref.etsi.org/core/SetAbsoluteLevelCommand"></see></summary>
    let SetAbsoluteLevelCommand = _prefix "SetAbsoluteLevelCommand"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/SetLevelCommand"></see></summary>
    let SetLevelCommand = _prefix "SetLevelCommand"
    /// <summary>
    /// A type of set level command
    /// <see href="https://saref.etsi.org/core/SetRelativeLevelCommand"></see></summary>
    let SetRelativeLevelCommand = _prefix "SetRelativeLevelCommand"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a unit of measure for smoke
    /// <see href="https://saref.etsi.org/core/Smoke"></see></summary>
    let Smoke = _prefix "Smoke"
    /// <summary>
    /// A sensor that performs the saref:SensingFunction and the saref:EventFunction, and is used for the purpose of sensing a property of type saref:Smoke. A saref:SmokeSensor is typically used to saref:accomplish saref:Safety.
    /// <see href="https://saref.etsi.org/core/SmokeSensor"></see></summary>
    let SmokeSensor = _prefix "SmokeSensor"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/StartCommand"></see></summary>
    let StartCommand = _prefix "StartCommand"
    /// <summary>
    /// An actuating function that allows to start and stop a device
    /// <see href="https://saref.etsi.org/core/StartStopFunction"></see></summary>
    let StartStopFunction = _prefix "StartStopFunction"
    /// <summary>
    /// A type of state
    /// <see href="https://saref.etsi.org/core/StartStopState"></see></summary>
    let StartStopState = _prefix "StartStopState"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/StopCommand"></see></summary>
    let StopCommand = _prefix "StopCommand"
    /// <summary>
    /// The state of a device that is STARTED
    /// <see href="https://saref.etsi.org/core/StartState"></see></summary>
    let StartState = _prefix "StartState"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/StepDownCommand"></see></summary>
    let StepDownCommand = _prefix "StepDownCommand"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/StepUpCommand"></see></summary>
    let StepUpCommand = _prefix "StepUpCommand"
    /// <summary>
    /// The state of a device that is STOPPED
    /// <see href="https://saref.etsi.org/core/StopState"></see></summary>
    let StopState = _prefix "StopState"
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a temperature unit (degree_Celsius, degree_Fahrenheit, or degree_kelvin)
    /// <see href="https://saref.etsi.org/core/Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    /// A sensor that is used for the purpose of sensing a property of type saref:Temperature. A saref:TemperatureSensor is typically used to saref:accomplish saref:Comfort.
    /// <see href="https://saref.etsi.org/core/TemperatureSensor"></see></summary>
    let TemperatureSensor = _prefix "TemperatureSensor"
    /// <summary>
    /// The unit of measure for temperature
    /// <see href="https://saref.etsi.org/core/TemperatureUnit"></see></summary>
    let TemperatureUnit = _prefix "TemperatureUnit"
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/ToggleCommand"></see></summary>
    let ToggleCommand = _prefix "ToggleCommand"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Washing"></see></summary>
    let Washing = _prefix "Washing"
    /// <summary>
    /// A type of commodity
    /// <see href="https://saref.etsi.org/core/Water"></see></summary>
    let Water = _prefix "Water"
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/WellBeing"></see></summary>
    let WellBeing = _prefix "WellBeing"
    /// <summary>
    /// A relationship identifying an entity (e.g., a device) that can accomplish a task.
    /// <see href="https://saref.etsi.org/core/isAccomplishedBy"></see></summary>
    let isAccomplishedBy = _prefix "isAccomplishedBy"
    /// <summary>
    /// A relationship providing a description of an entity (e.g., device). The value is expected to be a string or a string with language tag.
    /// DEPRECATED: The use of rdfs:comment is recommended instead.
    /// <see href="https://saref.etsi.org/core/hasDescription"></see></summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    /// A relationship identifying the typical (energy or power) consumption of a device
    /// <see href="https://saref.etsi.org/core/hasTypicalConsumption"></see></summary>
    let hasTypicalConsumption = _prefix "hasTypicalConsumption"
    /// <summary>
    /// A relation between a measurement and the device that made it.
    /// <see href="https://saref.etsi.org/core/measurementMadeBy"></see></summary>
    let measurementMadeBy = _prefix "measurementMadeBy"
