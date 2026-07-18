namespace https.saref.etsi.org.core.slash

open DoxAletheia.Rdf_Vocabulary

module saref =
    let _namespace_name = "https://saref.etsi.org/core/"
    /// <summary>
    ///   <see href="https://saref.etsi.org/core/v3.1.1/"></see>
    /// </summary>
    let ``v3.1.1/`` = Namespaced_IRI.parse _namespace_name "v3.1.1/" |> NamespacedName

    /// <summary>
    /// A function that allows to transmit data to actuators, such as level settings (e.g., temperature) or binary switching (e.g., open/close, on/off)
    /// <see href="https://saref.etsi.org/core/ActuatingFunction"></see></summary>
    let ActuatingFunction =
        Namespaced_IRI.parse _namespace_name "ActuatingFunction" |> NamespacedName

    /// <summary>
    /// The functionality necessary to accomplish the task for which a device is designed. A device can be designed to perform more than one function. Functions can be structured in categories (subclasses) that reflect different points of view, for example, considering the specific application area for which a function can be used (e.g., light, temperature, motion, heat, power, etc.), or the capability that a function can support (e.g., receive, reply, notify, etc.), and so forth.
    /// <see href="https://saref.etsi.org/core/Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName
    /// <summary>
    /// A device responsible for moving or controlling a mechanism or system by performing an actuating function
    /// <see href="https://saref.etsi.org/core/Actuator"></see></summary>
    let Actuator = Namespaced_IRI.parse _namespace_name "Actuator" |> NamespacedName

    /// <summary>
    /// A relationship identifying the function of a device
    /// <see href="https://saref.etsi.org/core/hasFunction"></see></summary>
    let hasFunction =
        Namespaced_IRI.parse _namespace_name "hasFunction" |> NamespacedName

    /// <summary>
    /// A tangible object designed to accomplish a particular task. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function.
    /// <see href="https://saref.etsi.org/core/Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    /// An electrical/mechanical machine that accomplish some household functions, such as cleaning or cooking
    /// <see href="https://saref.etsi.org/core/Appliance"></see></summary>
    let Appliance = Namespaced_IRI.parse _namespace_name "Appliance" |> NamespacedName
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Cleaning"></see></summary>
    let Cleaning = Namespaced_IRI.parse _namespace_name "Cleaning" |> NamespacedName
    /// <summary>
    /// The goal for which a device is designed (from a user perspective). For example, a washing machine is designed for the task of washing. We propose here a list of tasks that are relevant for the purpose of SAREF, but this list can be extended. Tasks can be accomplished by devices (saref:isAccomplishedBy).
    /// <see href="https://saref.etsi.org/core/Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/CloseCommand"></see></summary>
    let CloseCommand =
        Namespaced_IRI.parse _namespace_name "CloseCommand" |> NamespacedName

    /// <summary>
    /// An actuating function that allows to open and close a device
    /// <see href="https://saref.etsi.org/core/OpenCloseFunction"></see></summary>
    let OpenCloseFunction =
        Namespaced_IRI.parse _namespace_name "OpenCloseFunction" |> NamespacedName

    /// <summary>
    /// A relationship between a command and a function.
    /// <see href="https://saref.etsi.org/core/isCommandOf"></see></summary>
    let isCommandOf =
        Namespaced_IRI.parse _namespace_name "isCommandOf" |> NamespacedName

    /// <summary>
    /// A type of state
    /// <see href="https://saref.etsi.org/core/OpenCloseState"></see></summary>
    let OpenCloseState =
        Namespaced_IRI.parse _namespace_name "OpenCloseState" |> NamespacedName

    /// <summary>
    /// A relationship between a command and a state
    /// <see href="https://saref.etsi.org/core/actsUpon"></see></summary>
    let actsUpon = Namespaced_IRI.parse _namespace_name "actsUpon" |> NamespacedName
    /// <summary>
    /// A directive that a device must support to perform a certain function. A command may act upon a state, but does not necessarily act upon a state. For example, the ON command acts upon the ON/OFF state, but the GET command does not act upon any state, it simply gives a directive to retrieve a certain value. We propose here a list of commands that are relevant for the purpose of SAREF, but this list can be extended.
    /// <see href="https://saref.etsi.org/core/Command"></see></summary>
    let Command = Namespaced_IRI.parse _namespace_name "Command" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/OpenCommand"></see></summary>
    let OpenCommand =
        Namespaced_IRI.parse _namespace_name "OpenCommand" |> NamespacedName

    /// <summary>
    /// The state of a device that is CLOSE
    /// <see href="https://saref.etsi.org/core/CloseState"></see></summary>
    let CloseState = Namespaced_IRI.parse _namespace_name "CloseState" |> NamespacedName
    /// <summary>
    /// A type of commodity
    /// <see href="https://saref.etsi.org/core/Coal"></see></summary>
    let Coal = Namespaced_IRI.parse _namespace_name "Coal" |> NamespacedName
    /// <summary>
    /// A marketable item for which there is demand, but which is supplied without qualitative differentiation across a market. SAREF refers to energy commodities such as electricity, gas, coal and oil.
    /// <see href="https://saref.etsi.org/core/Commodity"></see></summary>
    let Commodity = Namespaced_IRI.parse _namespace_name "Commodity" |> NamespacedName
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Comfort"></see></summary>
    let Comfort = Namespaced_IRI.parse _namespace_name "Comfort" |> NamespacedName
    /// <summary>
    /// The state in which a device can be found, e.g, ON/OFF/STANDBY, or ONLINE/OFFLINE. We propose here a list of states that are relevant for the purpose of SAREF, but this list can be extended.
    /// <see href="https://saref.etsi.org/core/State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// The class of units of measure for price
    /// <see href="https://saref.etsi.org/core/Currency"></see></summary>
    let Currency = Namespaced_IRI.parse _namespace_name "Currency" |> NamespacedName

    /// <summary>
    /// The unit of measure is a standard for measurement of a quantity, such as a Property. For example,  Power is a property and Watt is a unit of power that represents a definite predetermined power: when we say 10 Watt, we actually mean 10 times the definite predetermined power called "watt". Our definition is based on the definition of unit of measure in the Ontology of units of Measure (OM). We propose here a list of some units of measure that are relevant for the purpose of SAREF, but this list can be extended, also using some other ontologies rather than the Ontology of units of Measure (OM).
    /// <see href="https://saref.etsi.org/core/UnitOfMeasure"></see></summary>
    let UnitOfMeasure =
        Namespaced_IRI.parse _namespace_name "UnitOfMeasure" |> NamespacedName

    /// <summary>
    /// A relationship identifying the manufacturer of an entity (e.g., device). The value is expected to be a string or a string with language tag.
    /// <see href="https://saref.etsi.org/core/hasManufacturer"></see></summary>
    let hasManufacturer =
        Namespaced_IRI.parse _namespace_name "hasManufacturer" |> NamespacedName

    /// <summary>
    /// A relationship identifying the model of an entity (e.g., device). The value is expected to be a string or a string with language tag.
    /// <see href="https://saref.etsi.org/core/hasModel"></see></summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName
    /// <summary>
    /// A relationship identifying the type of state of a device
    /// <see href="https://saref.etsi.org/core/hasState"></see></summary>
    let hasState = Namespaced_IRI.parse _namespace_name "hasState" |> NamespacedName

    /// <summary>
    /// Represents the measured value made over a property. It is also linked to the unit of measure in which the value is expressed and the timestamp of the measurement.
    /// <see href="https://saref.etsi.org/core/Measurement"></see></summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    /// A relation between a device and the measurements it makes. Such measurement will link together the value of the measurement, its unit of measure and the property to which it relates.
    /// <see href="https://saref.etsi.org/core/makesMeasurement"></see></summary>
    let makesMeasurement =
        Namespaced_IRI.parse _namespace_name "makesMeasurement" |> NamespacedName

    /// <summary>
    /// A quality of a feature of interest that can be measured; an aspect of a feature of interest that is intrinsic to and cannot exist without the feature
    /// <see href="https://saref.etsi.org/core/Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    /// A relationship specifying the property that can be controlled by a certain device
    /// <see href="https://saref.etsi.org/core/controlsProperty"></see></summary>
    let controlsProperty =
        Namespaced_IRI.parse _namespace_name "controlsProperty" |> NamespacedName

    /// <summary>
    /// A relationship specifying the property that can be measured by a certain device
    /// <see href="https://saref.etsi.org/core/measuresProperty"></see></summary>
    let measuresProperty =
        Namespaced_IRI.parse _namespace_name "measuresProperty" |> NamespacedName

    /// <summary>
    /// A relationship indicating a composite entity that consists of other entities (e.g., a temperature/humidity sensor that consists of a temperature sensor and a humidity sensor)
    /// <see href="https://saref.etsi.org/core/consistsOf"></see></summary>
    let consistsOf = Namespaced_IRI.parse _namespace_name "consistsOf" |> NamespacedName
    /// <summary>
    /// A relationship specifying the commodity for which a device is used for
    /// <see href="https://saref.etsi.org/core/isUsedFor"></see></summary>
    let isUsedFor = Namespaced_IRI.parse _namespace_name "isUsedFor" |> NamespacedName

    /// <summary>
    /// A relationship between a certain entity (e.g., a device) and the task it accomplishes
    /// <see href="https://saref.etsi.org/core/accomplishes"></see></summary>
    let accomplishes =
        Namespaced_IRI.parse _namespace_name "accomplishes" |> NamespacedName

    /// <summary>
    /// A service is a representation of a function to a network that makes the function discoverable, registerable, remotely controllable by other devices in the network. A service can represent one or more functions. A Service is offered by a device that wants (a certain set of) its function(s) to be discoverable, registerable, remotely controllable by other devices in the network. A Service must specify the device that is offering the service and the function(s) to be represented.
    /// <see href="https://saref.etsi.org/core/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// A relationship between a device and a service
    /// <see href="https://saref.etsi.org/core/offers"></see></summary>
    let offers = Namespaced_IRI.parse _namespace_name "offers" |> NamespacedName
    /// <summary>
    /// A specification associated to a device to collect information about a certain Property (e.g., Energy) for optimizing its usage in the home, office or building in which the device is located. This specification is about a certain Property (saref:isAbout), can be calculated over a time span (saref:hasTime) and can be associated to some costs (saref:hasPrice). An example is the Power Profile defined in the SAREF4ENER extension that can be associated to a device for optimizing the Energy efficiency in the home, office or building in which the device is located.
    /// <see href="https://saref.etsi.org/core/Profile"></see></summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName
    /// <summary>
    /// A relationship associating a profile to a certain device
    /// <see href="https://saref.etsi.org/core/hasProfile"></see></summary>
    let hasProfile = Namespaced_IRI.parse _namespace_name "hasProfile" |> NamespacedName
    /// <summary>
    /// A switch that performs the saref:OpenCloseFunction, is used for controlling a door, and can be found in the state saref:OpenCloseState. A saref:DoorSwitch is typically used to accomplish saref:Safety.
    /// <see href="https://saref.etsi.org/core/DoorSwitch"></see></summary>
    let DoorSwitch = Namespaced_IRI.parse _namespace_name "DoorSwitch" |> NamespacedName
    /// <summary>
    /// A device of category saref:Actuator that performs an actuating function of type saref:OnOffFunction or saref:OpenCloseFunction
    /// <see href="https://saref.etsi.org/core/Switch"></see></summary>
    let Switch = Namespaced_IRI.parse _namespace_name "Switch" |> NamespacedName
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Drying"></see></summary>
    let Drying = Namespaced_IRI.parse _namespace_name "Drying" |> NamespacedName

    /// <summary>
    /// A type of commodity
    /// <see href="https://saref.etsi.org/core/Electricity"></see></summary>
    let Electricity =
        Namespaced_IRI.parse _namespace_name "Electricity" |> NamespacedName

    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value measured in an energy unit (such as Kilowatt_Hour or Watt_hour). Furter specializations of the saref:Energy class can be found in the SAREF4ENER extension, where classes such as EnergyMax, EnergyMin and EnergyExpected are defined.
    /// <see href="https://saref.etsi.org/core/Energy"></see></summary>
    let Energy = Namespaced_IRI.parse _namespace_name "Energy" |> NamespacedName

    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/EnergyEfficiency"></see></summary>
    let EnergyEfficiency =
        Namespaced_IRI.parse _namespace_name "EnergyEfficiency" |> NamespacedName

    /// <summary>
    /// The unit of measure for energy
    /// <see href="https://saref.etsi.org/core/EnergyUnit"></see></summary>
    let EnergyUnit = Namespaced_IRI.parse _namespace_name "EnergyUnit" |> NamespacedName

    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Entertainment"></see></summary>
    let Entertainment =
        Namespaced_IRI.parse _namespace_name "Entertainment" |> NamespacedName

    /// <summary>
    /// A function that allows to notify about some relevant activity; e.g., that a certain threshold value has been exceeded or that some object has moved.
    /// <see href="https://saref.etsi.org/core/EventFunction"></see></summary>
    let EventFunction =
        Namespaced_IRI.parse _namespace_name "EventFunction" |> NamespacedName

    /// <summary>
    /// A relationship associated with an event function to notify that a certain threshold measurement has been exceeded
    /// <see href="https://saref.etsi.org/core/hasThresholdMeasurement"></see></summary>
    let hasThresholdMeasurement =
        Namespaced_IRI.parse _namespace_name "hasThresholdMeasurement" |> NamespacedName

    /// <summary>
    /// A feature of interest represents any real world entity from which a property is measured.
    /// <see href="https://saref.etsi.org/core/FeatureOfInterest"></see></summary>
    let FeatureOfInterest =
        Namespaced_IRI.parse _namespace_name "FeatureOfInterest" |> NamespacedName

    /// <summary>
    /// A relationship between a feature of interest and a measurement about it
    /// <see href="https://saref.etsi.org/core/hasMeasurement"></see></summary>
    let hasMeasurement =
        Namespaced_IRI.parse _namespace_name "hasMeasurement" |> NamespacedName

    /// <summary>
    /// A relationship between a feature of interest and a property of that feature
    /// <see href="https://saref.etsi.org/core/hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    /// A relationship between a function and a command
    /// <see href="https://saref.etsi.org/core/hasCommand"></see></summary>
    let hasCommand = Namespaced_IRI.parse _namespace_name "hasCommand" |> NamespacedName
    /// <summary>
    /// A type of commodity
    /// <see href="https://saref.etsi.org/core/Gas"></see></summary>
    let Gas = Namespaced_IRI.parse _namespace_name "Gas" |> NamespacedName
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/GetCommand"></see></summary>
    let GetCommand = Namespaced_IRI.parse _namespace_name "GetCommand" |> NamespacedName

    /// <summary>
    /// A type of get command
    /// <see href="https://saref.etsi.org/core/GetCurrentMeterValueCommand"></see></summary>
    let GetCurrentMeterValueCommand =
        Namespaced_IRI.parse _namespace_name "GetCurrentMeterValueCommand" |> NamespacedName

    /// <summary>
    /// A function that allows to get data from a meter, such as current meter reading or instantaneous demand
    /// <see href="https://saref.etsi.org/core/MeteringFunction"></see></summary>
    let MeteringFunction =
        Namespaced_IRI.parse _namespace_name "MeteringFunction" |> NamespacedName

    /// <summary>
    /// A type of get command
    /// <see href="https://saref.etsi.org/core/GetMeterDataCommand"></see></summary>
    let GetMeterDataCommand =
        Namespaced_IRI.parse _namespace_name "GetMeterDataCommand" |> NamespacedName

    /// <summary>
    /// A type of get command
    /// <see href="https://saref.etsi.org/core/GetMeterHistoryCommand"></see></summary>
    let GetMeterHistoryCommand =
        Namespaced_IRI.parse _namespace_name "GetMeterHistoryCommand" |> NamespacedName

    /// <summary>
    /// A type of get command
    /// <see href="https://saref.etsi.org/core/GetSensingDataCommand"></see></summary>
    let GetSensingDataCommand =
        Namespaced_IRI.parse _namespace_name "GetSensingDataCommand" |> NamespacedName

    /// <summary>
    /// A function that allows to transmit data from sensors, such as measurement values (e.g., temperature) or sensing data (e.g., occupancy)
    /// <see href="https://saref.etsi.org/core/SensingFunction"></see></summary>
    let SensingFunction =
        Namespaced_IRI.parse _namespace_name "SensingFunction" |> NamespacedName

    /// <summary>
    /// Heating, Ventilation and Air Conditioning (HVAC) device that provides indoor environmental comfort. A saref:HVAC is typically used to accomplish saref:Comfort.
    /// <see href="https://saref.etsi.org/core/HVAC"></see></summary>
    let HVAC = Namespaced_IRI.parse _namespace_name "HVAC" |> NamespacedName
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a humidity unit
    /// <see href="https://saref.etsi.org/core/Humidity"></see></summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName

    /// <summary>
    /// The unit of measure for light
    /// <see href="https://saref.etsi.org/core/IlluminanceUnit"></see></summary>
    let IlluminanceUnit =
        Namespaced_IRI.parse _namespace_name "IlluminanceUnit" |> NamespacedName

    /// <summary>
    /// An actuating function that allows to do level adjustments of a property in a certain range (e.g., 0%-100%), such as dimming a light in a room or setting the speed of an electric motor.
    /// <see href="https://saref.etsi.org/core/LevelControlFunction"></see></summary>
    let LevelControlFunction =
        Namespaced_IRI.parse _namespace_name "LevelControlFunction" |> NamespacedName

    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a illuminance unit (lux)
    /// <see href="https://saref.etsi.org/core/Light"></see></summary>
    let Light = Namespaced_IRI.parse _namespace_name "Light" |> NamespacedName

    /// <summary>
    /// A switch that performs the saref:OnOffFunction, controls the property saref:Light, and can be found in the state saref:OnOffState. It can offer a switch on service. A saref:LightSwitch is typically used to accomplish saref:Lighting.
    /// <see href="https://saref.etsi.org/core/LightSwitch"></see></summary>
    let LightSwitch =
        Namespaced_IRI.parse _namespace_name "LightSwitch" |> NamespacedName

    /// <summary>
    /// A type of service that represents an on/off function to the network
    /// <see href="https://saref.etsi.org/core/SwitchOnService"></see></summary>
    let SwitchOnService =
        Namespaced_IRI.parse _namespace_name "SwitchOnService" |> NamespacedName

    /// <summary>
    /// A type of state
    /// <see href="https://saref.etsi.org/core/OnOffState"></see></summary>
    let OnOffState = Namespaced_IRI.parse _namespace_name "OnOffState" |> NamespacedName

    /// <summary>
    /// An actuating function that allows to switch on and off an actuator
    /// <see href="https://saref.etsi.org/core/OnOffFunction"></see></summary>
    let OnOffFunction =
        Namespaced_IRI.parse _namespace_name "OnOffFunction" |> NamespacedName

    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Lighting"></see></summary>
    let Lighting = Namespaced_IRI.parse _namespace_name "Lighting" |> NamespacedName

    /// <summary>
    /// A relationship between a measurement and the property it relates to
    /// <see href="https://saref.etsi.org/core/relatesToProperty"></see></summary>
    let relatesToProperty =
        Namespaced_IRI.parse _namespace_name "relatesToProperty" |> NamespacedName

    /// <summary>
    /// A relationship identifying the unit of measure used for a certain entity.
    /// <see href="https://saref.etsi.org/core/isMeasuredIn"></see></summary>
    let isMeasuredIn =
        Namespaced_IRI.parse _namespace_name "isMeasuredIn" |> NamespacedName

    /// <summary>
    /// A relationship stating the timestamp of an entity (e.g. a measurement).
    /// <see href="https://saref.etsi.org/core/hasTimestamp"></see></summary>
    let hasTimestamp =
        Namespaced_IRI.parse _namespace_name "hasTimestamp" |> NamespacedName

    /// <summary>
    /// A relationship between a measurement and the feature of interest whose quality was measured
    /// <see href="https://saref.etsi.org/core/isMeasurementOf"></see></summary>
    let isMeasurementOf =
        Namespaced_IRI.parse _namespace_name "isMeasurementOf" |> NamespacedName

    /// <summary>
    /// A relationship defining the value of a certain property, e.g., energy or power. Note that, even if numeric values are expected to enable reasoning, measurement values could use other datatypes.
    /// <see href="https://saref.etsi.org/core/hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    /// A device built to accurately detect and display a quantity in a form readable by a human being. Further, a device of category saref:Meter that performs a saref:MeteringFunction.
    /// <see href="https://saref.etsi.org/core/Meter"></see></summary>
    let Meter = Namespaced_IRI.parse _namespace_name "Meter" |> NamespacedName

    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/MeterReading"></see></summary>
    let MeterReading =
        Namespaced_IRI.parse _namespace_name "MeterReading" |> NamespacedName

    /// <summary>
    /// A relationship identifying the reading type of a metering function (e.g., Water, Gas, Pressure , Energy , Power, etc.)
    /// <see href="https://saref.etsi.org/core/hasMeterReadingType"></see></summary>
    let hasMeterReadingType =
        Namespaced_IRI.parse _namespace_name "hasMeterReadingType" |> NamespacedName

    /// <summary>
    /// A relationship between a metering function and the measurement of the reading
    /// <see href="https://saref.etsi.org/core/hasMeterReading"></see></summary>
    let hasMeterReading =
        Namespaced_IRI.parse _namespace_name "hasMeterReading" |> NamespacedName

    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a unit of measure for motion
    /// <see href="https://saref.etsi.org/core/Motion"></see></summary>
    let Motion = Namespaced_IRI.parse _namespace_name "Motion" |> NamespacedName

    /// <summary>
    /// A type of state
    /// <see href="https://saref.etsi.org/core/MultiLevelState"></see></summary>
    let MultiLevelState =
        Namespaced_IRI.parse _namespace_name "MultiLevelState" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/NotifyCommand"></see></summary>
    let NotifyCommand =
        Namespaced_IRI.parse _namespace_name "NotifyCommand" |> NamespacedName

    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value (saref:hasValue property) that is measured in a unit of measure for occupancy
    /// <see href="https://saref.etsi.org/core/Occupancy"></see></summary>
    let Occupancy = Namespaced_IRI.parse _namespace_name "Occupancy" |> NamespacedName
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/OffCommand"></see></summary>
    let OffCommand = Namespaced_IRI.parse _namespace_name "OffCommand" |> NamespacedName
    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/OnCommand"></see></summary>
    let OnCommand = Namespaced_IRI.parse _namespace_name "OnCommand" |> NamespacedName
    /// <summary>
    /// The state of a device that is Off
    /// <see href="https://saref.etsi.org/core/OffState"></see></summary>
    let OffState = Namespaced_IRI.parse _namespace_name "OffState" |> NamespacedName
    /// <summary>
    /// The state of a device that is On
    /// <see href="https://saref.etsi.org/core/OnState"></see></summary>
    let OnState = Namespaced_IRI.parse _namespace_name "OnState" |> NamespacedName
    /// <summary>
    /// The state of a device that is OPEN
    /// <see href="https://saref.etsi.org/core/OpenState"></see></summary>
    let OpenState = Namespaced_IRI.parse _namespace_name "OpenState" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/PauseCommand"></see></summary>
    let PauseCommand =
        Namespaced_IRI.parse _namespace_name "PauseCommand" |> NamespacedName

    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a power unit (such as watt or kilowatt).  Further specializations of the saref:Power class can be found in the SAREF4ENER extension, where classes such as PowerMax, PowerMin and PowerExpected are defined.
    /// <see href="https://saref.etsi.org/core/Power"></see></summary>
    let Power = Namespaced_IRI.parse _namespace_name "Power" |> NamespacedName
    /// <summary>
    /// The unit of measure for power
    /// <see href="https://saref.etsi.org/core/PowerUnit"></see></summary>
    let PowerUnit = Namespaced_IRI.parse _namespace_name "PowerUnit" |> NamespacedName
    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a pressure unit (bar or pascal)
    /// <see href="https://saref.etsi.org/core/Pressure"></see></summary>
    let Pressure = Namespaced_IRI.parse _namespace_name "Pressure" |> NamespacedName

    /// <summary>
    /// The unit of measure for pressure
    /// <see href="https://saref.etsi.org/core/PressureUnit"></see></summary>
    let PressureUnit =
        Namespaced_IRI.parse _namespace_name "PressureUnit" |> NamespacedName

    /// <summary>
    /// A saref:Property crelated to some measurements that are characterized by a certain value that is measured using saref:Currency
    /// <see href="https://saref.etsi.org/core/Price"></see></summary>
    let Price = Namespaced_IRI.parse _namespace_name "Price" |> NamespacedName
    /// <summary>
    /// A relationship identifying what an entity, such as a profile, is about
    /// <see href="https://saref.etsi.org/core/isAbout"></see></summary>
    let isAbout = Namespaced_IRI.parse _namespace_name "isAbout" |> NamespacedName
    /// <summary>
    /// A class that allows to specify the time concept.
    /// <see href="https://saref.etsi.org/core/Time"></see></summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    /// A relationship to associate time information to an entity
    /// <see href="https://saref.etsi.org/core/hasTime"></see></summary>
    let hasTime = Namespaced_IRI.parse _namespace_name "hasTime" |> NamespacedName
    /// <summary>
    /// A relationship indentifying the price associated to an entity
    /// <see href="https://saref.etsi.org/core/hasPrice"></see></summary>
    let hasPrice = Namespaced_IRI.parse _namespace_name "hasPrice" |> NamespacedName

    /// <summary>
    /// A relationship between a property and the measurements it relates to
    /// <see href="https://saref.etsi.org/core/relatesToMeasurement"></see></summary>
    let relatesToMeasurement =
        Namespaced_IRI.parse _namespace_name "relatesToMeasurement" |> NamespacedName

    /// <summary>
    /// A relationship between a property and the feature of interest it belongs to
    /// <see href="https://saref.etsi.org/core/isPropertyOf"></see></summary>
    let isPropertyOf =
        Namespaced_IRI.parse _namespace_name "isPropertyOf" |> NamespacedName

    /// <summary>
    /// A relationship specifying the devices that can measure a certain property
    /// <see href="https://saref.etsi.org/core/isMeasuredByDevice"></see></summary>
    let isMeasuredByDevice =
        Namespaced_IRI.parse _namespace_name "isMeasuredByDevice" |> NamespacedName

    /// <summary>
    /// A relationship specifying the devices that can control a certain property
    /// <see href="https://saref.etsi.org/core/isControlledByDevice"></see></summary>
    let isControlledByDevice =
        Namespaced_IRI.parse _namespace_name "isControlledByDevice" |> NamespacedName

    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Safety"></see></summary>
    let Safety = Namespaced_IRI.parse _namespace_name "Safety" |> NamespacedName

    /// <summary>
    /// A relationship identifying the sensing type of a sensor detection (i.e., Temperature, Occupancy, Humidity, Motion , Smoke, Pressure, etc.)
    /// <see href="https://saref.etsi.org/core/hasSensorType"></see></summary>
    let hasSensorType =
        Namespaced_IRI.parse _namespace_name "hasSensorType" |> NamespacedName

    /// <summary>
    /// A relationship between a sensing function and a measurement identifying the range of a sensor detection
    /// <see href="https://saref.etsi.org/core/hasSensingRange"></see></summary>
    let hasSensingRange =
        Namespaced_IRI.parse _namespace_name "hasSensingRange" |> NamespacedName

    /// <summary>
    /// A device that detects and responds to events or changes in the physical environment such as light, motion, or temperature changes. Further, a device of category saref:Sensor that performs a saref:SensingFunction.
    /// <see href="https://saref.etsi.org/core/Sensor"></see></summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName
    /// <summary>
    /// A relationship between a service and a function.
    /// <see href="https://saref.etsi.org/core/represents"></see></summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName

    /// <summary>
    /// A relationship between a service and a device that offers the service
    /// <see href="https://saref.etsi.org/core/isOfferedBy"></see></summary>
    let isOfferedBy =
        Namespaced_IRI.parse _namespace_name "isOfferedBy" |> NamespacedName

    /// <summary>
    /// A type of set level command
    /// <see href="https://saref.etsi.org/core/SetAbsoluteLevelCommand"></see></summary>
    let SetAbsoluteLevelCommand =
        Namespaced_IRI.parse _namespace_name "SetAbsoluteLevelCommand" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/SetLevelCommand"></see></summary>
    let SetLevelCommand =
        Namespaced_IRI.parse _namespace_name "SetLevelCommand" |> NamespacedName

    /// <summary>
    /// A type of set level command
    /// <see href="https://saref.etsi.org/core/SetRelativeLevelCommand"></see></summary>
    let SetRelativeLevelCommand =
        Namespaced_IRI.parse _namespace_name "SetRelativeLevelCommand" |> NamespacedName

    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a unit of measure for smoke
    /// <see href="https://saref.etsi.org/core/Smoke"></see></summary>
    let Smoke = Namespaced_IRI.parse _namespace_name "Smoke" |> NamespacedName

    /// <summary>
    /// A sensor that performs the saref:SensingFunction and the saref:EventFunction, and is used for the purpose of sensing a property of type saref:Smoke. A saref:SmokeSensor is typically used to saref:accomplish saref:Safety.
    /// <see href="https://saref.etsi.org/core/SmokeSensor"></see></summary>
    let SmokeSensor =
        Namespaced_IRI.parse _namespace_name "SmokeSensor" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/StartCommand"></see></summary>
    let StartCommand =
        Namespaced_IRI.parse _namespace_name "StartCommand" |> NamespacedName

    /// <summary>
    /// An actuating function that allows to start and stop a device
    /// <see href="https://saref.etsi.org/core/StartStopFunction"></see></summary>
    let StartStopFunction =
        Namespaced_IRI.parse _namespace_name "StartStopFunction" |> NamespacedName

    /// <summary>
    /// A type of state
    /// <see href="https://saref.etsi.org/core/StartStopState"></see></summary>
    let StartStopState =
        Namespaced_IRI.parse _namespace_name "StartStopState" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/StopCommand"></see></summary>
    let StopCommand =
        Namespaced_IRI.parse _namespace_name "StopCommand" |> NamespacedName

    /// <summary>
    /// The state of a device that is STARTED
    /// <see href="https://saref.etsi.org/core/StartState"></see></summary>
    let StartState = Namespaced_IRI.parse _namespace_name "StartState" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/StepDownCommand"></see></summary>
    let StepDownCommand =
        Namespaced_IRI.parse _namespace_name "StepDownCommand" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/StepUpCommand"></see></summary>
    let StepUpCommand =
        Namespaced_IRI.parse _namespace_name "StepUpCommand" |> NamespacedName

    /// <summary>
    /// The state of a device that is STOPPED
    /// <see href="https://saref.etsi.org/core/StopState"></see></summary>
    let StopState = Namespaced_IRI.parse _namespace_name "StopState" |> NamespacedName

    /// <summary>
    /// A saref:Property related to some measurements that are characterized by a certain value that is measured in a temperature unit (degree_Celsius, degree_Fahrenheit, or degree_kelvin)
    /// <see href="https://saref.etsi.org/core/Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    /// A sensor that is used for the purpose of sensing a property of type saref:Temperature. A saref:TemperatureSensor is typically used to saref:accomplish saref:Comfort.
    /// <see href="https://saref.etsi.org/core/TemperatureSensor"></see></summary>
    let TemperatureSensor =
        Namespaced_IRI.parse _namespace_name "TemperatureSensor" |> NamespacedName

    /// <summary>
    /// The unit of measure for temperature
    /// <see href="https://saref.etsi.org/core/TemperatureUnit"></see></summary>
    let TemperatureUnit =
        Namespaced_IRI.parse _namespace_name "TemperatureUnit" |> NamespacedName

    /// <summary>
    /// A type of command
    /// <see href="https://saref.etsi.org/core/ToggleCommand"></see></summary>
    let ToggleCommand =
        Namespaced_IRI.parse _namespace_name "ToggleCommand" |> NamespacedName

    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/Washing"></see></summary>
    let Washing = Namespaced_IRI.parse _namespace_name "Washing" |> NamespacedName
    /// <summary>
    /// A type of commodity
    /// <see href="https://saref.etsi.org/core/Water"></see></summary>
    let Water = Namespaced_IRI.parse _namespace_name "Water" |> NamespacedName
    /// <summary>
    /// A type of task for which a device is designed
    /// <see href="https://saref.etsi.org/core/WellBeing"></see></summary>
    let WellBeing = Namespaced_IRI.parse _namespace_name "WellBeing" |> NamespacedName

    /// <summary>
    /// A relationship identifying an entity (e.g., a device) that can accomplish a task.
    /// <see href="https://saref.etsi.org/core/isAccomplishedBy"></see></summary>
    let isAccomplishedBy =
        Namespaced_IRI.parse _namespace_name "isAccomplishedBy" |> NamespacedName

    /// <summary>
    /// A relationship providing a description of an entity (e.g., device). The value is expected to be a string or a string with language tag.
    /// DEPRECATED: The use of rdfs:comment is recommended instead.
    /// <see href="https://saref.etsi.org/core/hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// A relationship identifying the typical (energy or power) consumption of a device
    /// <see href="https://saref.etsi.org/core/hasTypicalConsumption"></see></summary>
    let hasTypicalConsumption =
        Namespaced_IRI.parse _namespace_name "hasTypicalConsumption" |> NamespacedName

    /// <summary>
    /// A relation between a measurement and the device that made it.
    /// <see href="https://saref.etsi.org/core/measurementMadeBy"></see></summary>
    let measurementMadeBy =
        Namespaced_IRI.parse _namespace_name "measurementMadeBy" |> NamespacedName
