namespace https.saref.etsi.org.core.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module saref =
    let _namespace_iri = Namespace_Iri saref |> NamespaceIRI
    /// <summary>
    ///   <para>saref:Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device responsible for moving or controlling a mechanism or system by performing an actuating function</para>
    /// labels<para>Actuator</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Actuator">https://saref.etsi.org/core/Actuator</seealso>
    let Actuator = Prefixed_Name(saref, "Actuator") |> PrefixedName
    /// <summary>
    ///   <para>saref:Cleaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Task</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>Cleaning</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Cleaning">https://saref.etsi.org/core/Cleaning</seealso>
    let Cleaning = Prefixed_Name(saref, "Cleaning") |> PrefixedName
    /// <summary>
    ///   <para>saref:Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A directive that a device must support to perform a certain function. A command may act upon a state, but does not necessarily act upon a state. For example, the ON command acts upon the ON/OFF state, but the GET command does not act upon any state, it simply gives a directive to retrieve a certain value. We propose here a list of commands that are relevant for the purpose of SAREF, but this list can be extended.</para>
    /// labels<para>Command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Command">https://saref.etsi.org/core/Command</seealso>
    let Command = Prefixed_Name(saref, "Command") |> PrefixedName
    /// <summary>
    ///   <para>saref:OpenCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Open command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OpenCommand">https://saref.etsi.org/core/OpenCommand</seealso>
    let OpenCommand = Prefixed_Name(saref, "OpenCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:CloseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state of a device that is CLOSE</para>
    /// labels<para>Close state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/CloseState">https://saref.etsi.org/core/CloseState</seealso>
    let CloseState = Prefixed_Name(saref, "CloseState") |> PrefixedName
    /// <summary>
    ///   <para>saref:Motion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value that is measured in a unit of measure for motion</para>
    /// labels<para>Motion</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Motion">https://saref.etsi.org/core/Motion</seealso>
    let Motion = Prefixed_Name(saref, "Motion") |> PrefixedName
    /// <summary>
    ///   <para>saref:MultiLevelState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of state</para>
    /// labels<para>Multi level state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/MultiLevelState">https://saref.etsi.org/core/MultiLevelState</seealso>
    let MultiLevelState = Prefixed_Name(saref, "MultiLevelState") |> PrefixedName
    /// <summary>
    ///   <para>saref:Smoke</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value that is measured in a unit of measure for smoke</para>
    /// labels<para>Smoke</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Smoke">https://saref.etsi.org/core/Smoke</seealso>
    let Smoke = Prefixed_Name(saref, "Smoke") |> PrefixedName
    /// <summary>
    ///   <para>saref:StartStopFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuating function that allows to start and stop a device</para>
    /// labels<para>Start stop function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/StartStopFunction">https://saref.etsi.org/core/StartStopFunction</seealso>
    let StartStopFunction = Prefixed_Name(saref, "StartStopFunction") |> PrefixedName
    /// <summary>
    ///   <para>saref:StartStopState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of state</para>
    /// labels<para>Start stop state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/StartStopState">https://saref.etsi.org/core/StartStopState</seealso>
    let StartStopState = Prefixed_Name(saref, "StartStopState") |> PrefixedName
    /// <summary>
    ///   <para>saref:StepDownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Step down command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/StepDownCommand">https://saref.etsi.org/core/StepDownCommand</seealso>
    let StepDownCommand = Prefixed_Name(saref, "StepDownCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:OpenCloseFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuating function that allows to open and close a device</para>
    /// labels<para>Open close function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OpenCloseFunction">https://saref.etsi.org/core/OpenCloseFunction</seealso>
    let OpenCloseFunction = Prefixed_Name(saref, "OpenCloseFunction") |> PrefixedName
    /// <summary>
    ///   <para>saref:isCommandOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a command and a function.</para>
    /// labels<para>is command of</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isCommandOf">https://saref.etsi.org/core/isCommandOf</seealso>
    let isCommandOf = Prefixed_Name(saref, "isCommandOf") |> PrefixedName
    /// <summary>
    ///   <para>saref:Comfort</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Task</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>Comfort</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Comfort">https://saref.etsi.org/core/Comfort</seealso>
    let Comfort = Prefixed_Name(saref, "Comfort") |> PrefixedName
    /// <summary>
    ///   <para>saref:Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of units of measure for price</para>
    /// labels<para>Currency</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Currency">https://saref.etsi.org/core/Currency</seealso>
    let Currency = Prefixed_Name(saref, "Currency") |> PrefixedName
    /// <summary>
    ///   <para>saref:UnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The unit of measure is a standard for measurement of a quantity, such as a Property. For example,  Power is a property and Watt is a unit of power that represents a definite predetermined power: when we say 10 Watt, we actually mean 10 times the definite predetermined power called "watt". Our definition is based on the definition of unit of measure in the Ontology of units of Measure (OM). We propose here a list of some units of measure that are relevant for the purpose of SAREF, but this list can be extended, also using some other ontologies rather than the Ontology of units of Measure (OM).</para>
    /// labels<para>Unit of measure</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/UnitOfMeasure">https://saref.etsi.org/core/UnitOfMeasure</seealso>
    let UnitOfMeasure = Prefixed_Name(saref, "UnitOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship identifying the model of an entity (e.g., device). The value is expected to be a string or a string with language tag.</para>
    /// labels<para>has model</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasModel">https://saref.etsi.org/core/hasModel</seealso>
    let hasModel = Prefixed_Name(saref, "hasModel") |> PrefixedName
    /// <summary>
    ///   <para>saref:makesMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a device and the measurements it makes. Such measurement will link together the value of the measurement, its unit of measure and the property to which it relates.</para>
    /// labels<para>makes measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/makesMeasurement">https://saref.etsi.org/core/makesMeasurement</seealso>
    let makesMeasurement = Prefixed_Name(saref, "makesMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>saref:consistsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship indicating a composite entity that consists of other entities (e.g., a temperature/humidity sensor that consists of a temperature sensor and a humidity sensor)</para>
    /// labels<para>consists of</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/consistsOf">https://saref.etsi.org/core/consistsOf</seealso>
    let consistsOf = Prefixed_Name(saref, "consistsOf") |> PrefixedName
    /// <summary>
    ///   <para>saref:isUsedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the commodity for which a device is used for</para>
    /// labels<para>is used for</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isUsedFor">https://saref.etsi.org/core/isUsedFor</seealso>
    let isUsedFor = Prefixed_Name(saref, "isUsedFor") |> PrefixedName
    /// <summary>
    ///   <para>saref:Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specification associated to a device to collect information about a certain Property (e.g., Energy) for optimizing its usage in the home, office or building in which the device is located. This specification is about a certain Property (saref:isAbout), can be calculated over a time span (saref:hasTime) and can be associated to some costs (saref:hasPrice). An example is the Power Profile defined in the SAREF4ENER extension that can be associated to a device for optimizing the Energy efficiency in the home, office or building in which the device is located.</para>
    /// labels<para>Profile</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Profile">https://saref.etsi.org/core/Profile</seealso>
    let Profile = Prefixed_Name(saref, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship associating a profile to a certain device</para>
    /// labels<para>has profile</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasProfile">https://saref.etsi.org/core/hasProfile</seealso>
    let hasProfile = Prefixed_Name(saref, "hasProfile") |> PrefixedName
    /// <summary>
    ///   <para>saref:DoorSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A switch that performs the saref:OpenCloseFunction, is used for controlling a door, and can be found in the state saref:OpenCloseState. A saref:DoorSwitch is typically used to accomplish saref:Safety.</para>
    /// labels<para>Door switch</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/DoorSwitch">https://saref.etsi.org/core/DoorSwitch</seealso>
    let DoorSwitch = Prefixed_Name(saref, "DoorSwitch") |> PrefixedName
    /// <summary>
    ///   <para>saref:Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value measured in an energy unit (such as Kilowatt_Hour or Watt_hour). Furter specializations of the saref:Energy class can be found in the SAREF4ENER extension, where classes such as EnergyMax, EnergyMin and EnergyExpected are defined. </para>
    /// labels<para>Energy</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Energy">https://saref.etsi.org/core/Energy</seealso>
    let Energy = Prefixed_Name(saref, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>saref:EnergyEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Task</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>EnergyEfficiency</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/EnergyEfficiency">https://saref.etsi.org/core/EnergyEfficiency</seealso>
    let EnergyEfficiency = Prefixed_Name(saref, "EnergyEfficiency") |> PrefixedName
    /// <summary>
    ///   <para>saref:EventFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that allows to notify about some relevant activity; e.g., that a certain threshold value has been exceeded or that some object has moved.</para>
    /// labels<para>Event function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/EventFunction">https://saref.etsi.org/core/EventFunction</seealso>
    let EventFunction = Prefixed_Name(saref, "EventFunction") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a feature of interest and a measurement about it</para>
    /// labels<para>has measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasMeasurement">https://saref.etsi.org/core/hasMeasurement</seealso>
    let hasMeasurement = Prefixed_Name(saref, "hasMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>saref:Gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of commodity</para>
    /// labels<para>Gas</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Gas">https://saref.etsi.org/core/Gas</seealso>
    let Gas = Prefixed_Name(saref, "Gas") |> PrefixedName
    /// <summary>
    ///   <para>saref:GetCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Get command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/GetCommand">https://saref.etsi.org/core/GetCommand</seealso>
    let GetCommand = Prefixed_Name(saref, "GetCommand") |> PrefixedName

    /// <summary>
    ///   <para>saref:GetMeterHistoryCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of get command</para>
    /// labels<para>Get meter history command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/GetMeterHistoryCommand">https://saref.etsi.org/core/GetMeterHistoryCommand</seealso>
    let GetMeterHistoryCommand =
        Prefixed_Name(saref, "GetMeterHistoryCommand") |> PrefixedName

    /// <summary>
    ///   <para>saref:GetSensingDataCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of get command</para>
    /// labels<para>Get sensing data command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/GetSensingDataCommand">https://saref.etsi.org/core/GetSensingDataCommand</seealso>
    let GetSensingDataCommand =
        Prefixed_Name(saref, "GetSensingDataCommand") |> PrefixedName

    /// <summary>
    ///   <para>saref:IlluminanceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The unit of measure for light</para>
    /// labels<para>Illuminance unit</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/IlluminanceUnit">https://saref.etsi.org/core/IlluminanceUnit</seealso>
    let IlluminanceUnit = Prefixed_Name(saref, "IlluminanceUnit") |> PrefixedName

    /// <summary>
    ///   <para>saref:LevelControlFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuating function that allows to do level adjustments of a property in a certain range (e.g., 0%-100%), such as dimming a light in a room or setting the speed of an electric motor. </para>
    /// labels<para>Level control function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/LevelControlFunction">https://saref.etsi.org/core/LevelControlFunction</seealso>
    let LevelControlFunction =
        Prefixed_Name(saref, "LevelControlFunction") |> PrefixedName

    /// <summary>
    ///   <para>saref:OnOffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of state</para>
    /// labels<para>On off state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OnOffState">https://saref.etsi.org/core/OnOffState</seealso>
    let OnOffState = Prefixed_Name(saref, "OnOffState") |> PrefixedName
    /// <summary>
    ///   <para>saref:OnOffFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuating function that allows to switch on and off an actuator</para>
    /// labels<para>On off function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OnOffFunction">https://saref.etsi.org/core/OnOffFunction</seealso>
    let OnOffFunction = Prefixed_Name(saref, "OnOffFunction") |> PrefixedName
    /// <summary>
    ///   <para>saref:Lighting</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Task</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>Lighting</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Lighting">https://saref.etsi.org/core/Lighting</seealso>
    let Lighting = Prefixed_Name(saref, "Lighting") |> PrefixedName
    /// <summary>
    ///   <para>saref:isMeasurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a measurement and the feature of interest whose quality was measured</para>
    /// labels<para>isMeasurementOf</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isMeasurementOf">https://saref.etsi.org/core/isMeasurementOf</seealso>
    let isMeasurementOf = Prefixed_Name(saref, "isMeasurementOf") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the value of a certain property, e.g., energy or power. Note that, even if numeric values are expected to enable reasoning, measurement values could use other datatypes.</para>
    /// labels<para>has value</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasValue">https://saref.etsi.org/core/hasValue</seealso>
    let hasValue = Prefixed_Name(saref, "hasValue") |> PrefixedName

    /// <summary>
    ///   <para>saref:SetAbsoluteLevelCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of set level command</para>
    /// labels<para>Set absolute level command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/SetAbsoluteLevelCommand">https://saref.etsi.org/core/SetAbsoluteLevelCommand</seealso>
    let SetAbsoluteLevelCommand =
        Prefixed_Name(saref, "SetAbsoluteLevelCommand") |> PrefixedName

    /// <summary>
    ///   <para>saref:SetLevelCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Set level command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/SetLevelCommand">https://saref.etsi.org/core/SetLevelCommand</seealso>
    let SetLevelCommand = Prefixed_Name(saref, "SetLevelCommand") |> PrefixedName

    /// <summary>
    ///   <para>saref:SetRelativeLevelCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of set level command</para>
    /// labels<para>Set relative level command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/SetRelativeLevelCommand">https://saref.etsi.org/core/SetRelativeLevelCommand</seealso>
    let SetRelativeLevelCommand =
        Prefixed_Name(saref, "SetRelativeLevelCommand") |> PrefixedName

    /// <summary>
    ///   <para>saref:SmokeSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sensor that performs the saref:SensingFunction and the saref:EventFunction, and is used for the purpose of sensing a property of type saref:Smoke. A saref:SmokeSensor is typically used to saref:accomplish saref:Safety.</para>
    /// labels<para>Smoke sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/SmokeSensor">https://saref.etsi.org/core/SmokeSensor</seealso>
    let SmokeSensor = Prefixed_Name(saref, "SmokeSensor") |> PrefixedName
    /// <summary>
    ///   <para>saref:StartCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Start command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/StartCommand">https://saref.etsi.org/core/StartCommand</seealso>
    let StartCommand = Prefixed_Name(saref, "StartCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:StopCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Stop command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/StopCommand">https://saref.etsi.org/core/StopCommand</seealso>
    let StopCommand = Prefixed_Name(saref, "StopCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:StartState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state of a device that is STARTED</para>
    /// labels<para>Start state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/StartState">https://saref.etsi.org/core/StartState</seealso>
    let StartState = Prefixed_Name(saref, "StartState") |> PrefixedName
    /// <summary>
    ///   <para>saref:StopState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state of a device that is STOPPED</para>
    /// labels<para>Stop state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/StopState">https://saref.etsi.org/core/StopState</seealso>
    let StopState = Prefixed_Name(saref, "StopState") |> PrefixedName
    /// <summary>
    ///   <para>saref:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value that is measured in a temperature unit (degree_Celsius, degree_Fahrenheit, or degree_kelvin)</para>
    /// labels<para>Temperature</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Temperature">https://saref.etsi.org/core/Temperature</seealso>
    let Temperature = Prefixed_Name(saref, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>saref:TemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sensor that is used for the purpose of sensing a property of type saref:Temperature. A saref:TemperatureSensor is typically used to saref:accomplish saref:Comfort.</para>
    /// labels<para>Temperature sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/TemperatureSensor">https://saref.etsi.org/core/TemperatureSensor</seealso>
    let TemperatureSensor = Prefixed_Name(saref, "TemperatureSensor") |> PrefixedName
    /// <summary>
    ///   <para>saref:TemperatureUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The unit of measure for temperature</para>
    /// labels<para>Temperature unit</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/TemperatureUnit">https://saref.etsi.org/core/TemperatureUnit</seealso>
    let TemperatureUnit = Prefixed_Name(saref, "TemperatureUnit") |> PrefixedName
    /// <summary>
    ///   <para>saref:ToggleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Toggle command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/ToggleCommand">https://saref.etsi.org/core/ToggleCommand</seealso>
    let ToggleCommand = Prefixed_Name(saref, "ToggleCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:Washing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Task</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>Washing</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Washing">https://saref.etsi.org/core/Washing</seealso>
    let Washing = Prefixed_Name(saref, "Washing") |> PrefixedName
    /// <summary>
    ///   <para>saref:Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of commodity</para>
    /// labels<para>Water</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Water">https://saref.etsi.org/core/Water</seealso>
    let Water = Prefixed_Name(saref, "Water") |> PrefixedName
    /// <summary>
    ///   <para>saref:WellBeing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Task</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>WellBeing</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/WellBeing">https://saref.etsi.org/core/WellBeing</seealso>
    let WellBeing = Prefixed_Name(saref, "WellBeing") |> PrefixedName
    /// <summary>
    ///   <para>saref:isAccomplishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship identifying an entity (e.g., a device) that can accomplish a task.</para>
    /// labels<para>is accomplished by</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isAccomplishedBy">https://saref.etsi.org/core/isAccomplishedBy</seealso>
    let isAccomplishedBy = Prefixed_Name(saref, "isAccomplishedBy") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship providing a description of an entity (e.g., device). The value is expected to be a string or a string with language tag.</para>
    ///   <para>DEPRECATED: The use of rdfs:comment is recommended instead.</para>
    /// labels<para>has description</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasDescription">https://saref.etsi.org/core/hasDescription</seealso>
    let hasDescription = Prefixed_Name(saref, "hasDescription") |> PrefixedName

    /// <summary>
    ///   <para>saref:hasTypicalConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship identifying the typical (energy or power) consumption of a device</para>
    /// labels<para>has typical consumption</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasTypicalConsumption">https://saref.etsi.org/core/hasTypicalConsumption</seealso>
    let hasTypicalConsumption =
        Prefixed_Name(saref, "hasTypicalConsumption") |> PrefixedName

    /// <summary>
    ///   <para>saref:measurementMadeBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a measurement and the device that made it.</para>
    /// labels<para>measurement made by</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/measurementMadeBy">https://saref.etsi.org/core/measurementMadeBy</seealso>
    let measurementMadeBy = Prefixed_Name(saref, "measurementMadeBy") |> PrefixedName
    /// <summary>
    ///   <para>saref:SwitchOnService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of service that represents an on/off function to the network</para>
    /// labels<para>Switch on service</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/SwitchOnService">https://saref.etsi.org/core/SwitchOnService</seealso>
    let SwitchOnService = Prefixed_Name(saref, "SwitchOnService") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasSensingRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a sensing function and a measurement identifying the range of a sensor detection</para>
    /// labels<para>has sensing range</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasSensingRange">https://saref.etsi.org/core/hasSensingRange</seealso>
    let hasSensingRange = Prefixed_Name(saref, "hasSensingRange") |> PrefixedName
    /// <summary>
    ///   <para>saref:isOfferedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a service and a device that offers the service</para>
    /// labels<para>is offered by</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isOfferedBy">https://saref.etsi.org/core/isOfferedBy</seealso>
    let isOfferedBy = Prefixed_Name(saref, "isOfferedBy") |> PrefixedName
    /// <summary>
    ///   <para>saref:ActuatingFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that allows to transmit data to actuators, such as level settings (e.g., temperature) or binary switching (e.g., open/close, on/off)</para>
    /// labels<para>Actuating function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/ActuatingFunction">https://saref.etsi.org/core/ActuatingFunction</seealso>
    let ActuatingFunction = Prefixed_Name(saref, "ActuatingFunction") |> PrefixedName
    /// <summary>
    ///   <para>saref:Safety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Task</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>Safety</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Safety">https://saref.etsi.org/core/Safety</seealso>
    let Safety = Prefixed_Name(saref, "Safety") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasSensorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship identifying the sensing type of a sensor detection (i.e., Temperature, Occupancy, Humidity, Motion , Smoke, Pressure, etc.) </para>
    /// labels<para>has sensor type</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasSensorType">https://saref.etsi.org/core/hasSensorType</seealso>
    let hasSensorType = Prefixed_Name(saref, "hasSensorType") |> PrefixedName
    /// <summary>
    ///   <para>saref:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device that detects and responds to events or changes in the physical environment such as light, motion, or temperature changes. Further, a device of category saref:Sensor that performs a saref:SensingFunction.</para>
    /// labels<para>Sensor</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Sensor">https://saref.etsi.org/core/Sensor</seealso>
    let Sensor = Prefixed_Name(saref, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>saref:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a service and a function.</para>
    /// labels<para>represents</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/represents">https://saref.etsi.org/core/represents</seealso>
    let represents = Prefixed_Name(saref, "represents") |> PrefixedName
    /// <summary>
    ///   <para>saref:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tangible object designed to accomplish a particular task. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function.</para>
    /// labels<para>Device</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Device">https://saref.etsi.org/core/Device</seealso>
    let Device = Prefixed_Name(saref, "Device") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship identifying the type of state of a device</para>
    /// labels<para>has state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasState">https://saref.etsi.org/core/hasState</seealso>
    let hasState = Prefixed_Name(saref, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>saref:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quality of a feature of interest that can be measured; an aspect of a feature of interest that is intrinsic to and cannot exist without the feature</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Property">https://saref.etsi.org/core/Property</seealso>
    let Property = Prefixed_Name(saref, "Property") |> PrefixedName
    /// <summary>
    ///   <para>saref:PowerUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The unit of measure for power</para>
    /// labels<para>Power unit</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/PowerUnit">https://saref.etsi.org/core/PowerUnit</seealso>
    let PowerUnit = Prefixed_Name(saref, "PowerUnit") |> PrefixedName
    /// <summary>
    ///   <para>saref:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship identifying what an entity, such as a profile, is about</para>
    /// labels<para>isAbout</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isAbout">https://saref.etsi.org/core/isAbout</seealso>
    let isAbout = Prefixed_Name(saref, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>saref:StepUpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Step up command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/StepUpCommand">https://saref.etsi.org/core/StepUpCommand</seealso>
    let StepUpCommand = Prefixed_Name(saref, "StepUpCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The goal for which a device is designed (from a user perspective). For example, a washing machine is designed for the task of washing. We propose here a list of tasks that are relevant for the purpose of SAREF, but this list can be extended. Tasks can be accomplished by devices (saref:isAccomplishedBy).</para>
    /// labels<para>Task</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Task">https://saref.etsi.org/core/Task</seealso>
    let Task = Prefixed_Name(saref, "Task") |> PrefixedName
    /// <summary>
    ///   <para>saref:actsUpon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a command and a state</para>
    /// labels<para>acts upon</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/actsUpon">https://saref.etsi.org/core/actsUpon</seealso>
    let actsUpon = Prefixed_Name(saref, "actsUpon") |> PrefixedName
    /// <summary>
    ///   <para>saref:Commodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A marketable item for which there is demand, but which is supplied without qualitative differentiation across a market. SAREF refers to energy commodities such as electricity, gas, coal and oil. </para>
    /// labels<para>Commodity</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Commodity">https://saref.etsi.org/core/Commodity</seealso>
    let Commodity = Prefixed_Name(saref, "Commodity") |> PrefixedName
    /// <summary>
    ///   <para>saref:Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device built to accurately detect and display a quantity in a form readable by a human being. Further, a device of category saref:Meter that performs a saref:MeteringFunction.</para>
    /// labels<para>Meter</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Meter">https://saref.etsi.org/core/Meter</seealso>
    let Meter = Prefixed_Name(saref, "Meter") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasMeterReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a metering function and the measurement of the reading</para>
    /// labels<para>has meter reading</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasMeterReading">https://saref.etsi.org/core/hasMeterReading</seealso>
    let hasMeterReading = Prefixed_Name(saref, "hasMeterReading") |> PrefixedName
    /// <summary>
    ///   <para>saref:NotifyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Notify command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/NotifyCommand">https://saref.etsi.org/core/NotifyCommand</seealso>
    let NotifyCommand = Prefixed_Name(saref, "NotifyCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:OnCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>On command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OnCommand">https://saref.etsi.org/core/OnCommand</seealso>
    let OnCommand = Prefixed_Name(saref, "OnCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:OnState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state of a device that is On</para>
    /// labels<para>On state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OnState">https://saref.etsi.org/core/OnState</seealso>
    let OnState = Prefixed_Name(saref, "OnState") |> PrefixedName
    /// <summary>
    ///   <para>saref:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the measured value made over a property. It is also linked to the unit of measure in which the value is expressed and the timestamp of the measurement.</para>
    /// labels<para>Measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Measurement">https://saref.etsi.org/core/Measurement</seealso>
    let Measurement = Prefixed_Name(saref, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>saref:accomplishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a certain entity (e.g., a device) and the task it accomplishes</para>
    /// labels<para>accomplishes</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/accomplishes">https://saref.etsi.org/core/accomplishes</seealso>
    let accomplishes = Prefixed_Name(saref, "accomplishes") |> PrefixedName
    /// <summary>
    ///   <para>saref:Switch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device of category saref:Actuator that performs an actuating function of type saref:OnOffFunction or saref:OpenCloseFunction</para>
    /// labels<para>Switch</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Switch">https://saref.etsi.org/core/Switch</seealso>
    let Switch = Prefixed_Name(saref, "Switch") |> PrefixedName
    /// <summary>
    ///   <para>saref:EnergyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The unit of measure for energy</para>
    /// labels<para>Energy unit</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/EnergyUnit">https://saref.etsi.org/core/EnergyUnit</seealso>
    let EnergyUnit = Prefixed_Name(saref, "EnergyUnit") |> PrefixedName

    /// <summary>
    ///   <para>saref:hasThresholdMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship associated with an event function to notify that a certain threshold measurement has been exceeded</para>
    /// labels<para>has threshold measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasThresholdMeasurement">https://saref.etsi.org/core/hasThresholdMeasurement</seealso>
    let hasThresholdMeasurement =
        Prefixed_Name(saref, "hasThresholdMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>saref:FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A feature of interest represents any real world entity from which a property is measured.</para>
    /// labels<para>Feature of interest</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/FeatureOfInterest">https://saref.etsi.org/core/FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(saref, "FeatureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a function and a command</para>
    /// labels<para>has command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasCommand">https://saref.etsi.org/core/hasCommand</seealso>
    let hasCommand = Prefixed_Name(saref, "hasCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Information about changes compared to version 2.1.1:
    ///  - Added the saref:FeatureOfInterest class and the properties used to relate it to saref:Measurement (saref:hasMeasurement and saref:isMeasurementOf) and to saref:Property (saref:hasProperty and saref:isPropertyOf).
    ///  - Added the saref:measurementMadeBy property as inverse of saref:makesMeasurement.
    ///  - The saref:relatesToProperty and saref:relatesToMeasurement properties are now inverse of each other.
    ///  - The range of saref:hasValue, which was defined as xsd:float, has been removed to support other datatypes for measurements.
    ///  - The range of datatype properties, which was defined as xsd:string, has been removed in order to support strings with language tags (rdf:langString). This affects saref:hasDescription, saref:hasManufacturer, saref:hasModel and saref:hasName, which now have implicitly a range of rdfs:Literal.
    ///  - The saref:hasName property has been removed and the use of rdfs:label is recommended.
    ///  - The saref:hasDescription property has been deprecated and the use of rdfs:comment is recommended.
    ///  - Too restrictive restrictions have been removed and in some cases the ontology documentation has been updated to reflect this: a saref:Command having at most one saref:hasDescription; a saref:Task being accomplished by at least one saref:Device; a saref:Device having a typical consumption of only energy or power; a saref:Commodity being measured in units of measure; restrictions on the values of saref:accomplishes that only covered specific use cases; universal restrictions on the saref:actsUpon property have been changed to existential ones; restrictions on the commands that a saref:Function may have, since there could be others not included in the defined enumerations; restrictive documentation of saref:EventFunction and saref:SmokeSensor.
    ///  - Bugs have been fixed: some devices (saref:DoorSwitch, saref:EnergyMeter, saref:LigthSwitch, saref:SmokeSensor, and saref:TemperatureSensor) were defined as subclass of a device and at the same time as consisting of such device; a saref:LightSwitch controls light and does not measure light, since it is an actuator; incorrect documentation of saref:OnState and saref:OffState.
    ///  - The saref:BuildingRelated, saref:EnergyRelated and saref:FunctionRelated classes have been removed, since the different extensions already classify the device types.
    ///  - The instances of the subclasses of saref:Command have been removed, since they represent examples.
    ///  - The instances of saref:UnitOfMeasure have been moved to examples.
    ///  - The classes related to the SAREF4ENER extension have been removed: saref:Generator, saref:Storage, saref:Load and saref:EnergyMeter.
    ///  - Some instances of saref:Device have been moved to examples: saref:WashingMachine, saref:LightingDevice, saref:MicroRenewable, saref:Multimedia, and saref:Network.
    ///  - Added domain and range axioms wherever the definition of a property unambiguously identifies the domain or the range of the property.
    ///  - The OWL Time ontology is not imported anymore.
    ///  - The documentation of some ontology terms has been updated for clarification.
    ///  - Language tags have been added to all labels and comments.
    /// </para>
    ///   <para>Information about changes compared to version 1.1.1:
    ///  - The classes and properties related to how to represent devices in building spaces (such as the saref:BuildingSpace class,  saref:BuildingObject class and saref:isLocatedIn property) have been removed from SAREF and incorporated  into the SAREF4BLDG extension related to buildings, including the reuse of the W3C? WGS84 geo positioning vocabulary.
    ///  - The saref:DeviceCategory and saref:FunctionCategory classes have been removed. Instead, the hierarchy of device categories has been implemented directly as subclasses of the saref:Device class.
    ///  - The information specific for energy efficiency has been moved to the SAREF4ENER extension. For example, the saref:Profile class has been redefined to accommodate only the properties that are general enough for any type of profile, not only for energy and power. Details on how to specifically model a power profile can be found in the SAREF4ENER extension.
    ///  - The subclasses of the saref:Energy class  have been removed (i.e., Average Energy, Maximum Energy, Minimum Energy, Total Energy, HVAC Energy, Hot Water Energy and Lighting Energy).
    ///  - The saref:Property class has been split into two classes (saref:Property and saref:Measurement), as it is done in the SAREF4ENVI extension, in order to properly accommodate the distinction between the concept of property (an observable quality of something) and the concept of measurement (a concrete value observed for a property).
    ///  - Too restrictive cardinality restrictions have been revised, sometimes making them optional rather than mandatory (better to make properties mandatory in the extensions that specialize SAREF for a specific purpose, rather than restricting SAREF, whose purpose is more general). For example, definitions of units of measurement using an enumeration (owl:oneOf) were too restrictive because they did not allow using other units than those enumerated. Therefore, the individuals of each class are still there, but the owl:oneOf enumeration has been removed.
    ///  - The saref:UnitOfMeasure subclasses use individuals from the OM ontology for unit of measures, but this is not the only solution. It has been clarified in the comments that the OM ontology is an example, but other ontologies can be used.
    ///  - The global restrictions (rdfs:domain and rdfs:range) in object properties have been completely removed not to hinder interoperability. Object properties are now only restricted locally in the classes.
    ///  - The subclasses of saref:Task have been transormed in individuals.
    ///  - The saref:hasTask property has been removed from the saref:Profile class to resolve an ambiguity with the saref:Task class.</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/core/">https://saref.etsi.org/core/</seealso>
    let _prefix_iri = Prefixed_Name(saref, "") |> PrefixedName
    /// <summary>
    ///   <para>saref:v3.1.1/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/core/v3.1.1/">https://saref.etsi.org/core/v3.1.1/</seealso>
    let ``v3.1.1/`` = Prefixed_Name(saref, "v3.1.1/") |> PrefixedName
    /// <summary>
    ///   <para>saref:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The functionality necessary to accomplish the task for which a device is designed. A device can be designed to perform more than one function. Functions can be structured in categories (subclasses) that reflect different points of view, for example, considering the specific application area for which a function can be used (e.g., light, temperature, motion, heat, power, etc.), or the capability that a function can support (e.g., receive, reply, notify, etc.), and so forth. </para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Function">https://saref.etsi.org/core/Function</seealso>
    let Function = Prefixed_Name(saref, "Function") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship identifying the function of a device</para>
    /// labels<para>has function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasFunction">https://saref.etsi.org/core/hasFunction</seealso>
    let hasFunction = Prefixed_Name(saref, "hasFunction") |> PrefixedName
    /// <summary>
    ///   <para>saref:Appliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An electrical/mechanical machine that accomplish some household functions, such as cleaning or cooking</para>
    /// labels<para>Appliance</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Appliance">https://saref.etsi.org/core/Appliance</seealso>
    let Appliance = Prefixed_Name(saref, "Appliance") |> PrefixedName
    /// <summary>
    ///   <para>saref:CloseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Close command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/CloseCommand">https://saref.etsi.org/core/CloseCommand</seealso>
    let CloseCommand = Prefixed_Name(saref, "CloseCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:OpenCloseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of state</para>
    /// labels<para>Open close state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OpenCloseState">https://saref.etsi.org/core/OpenCloseState</seealso>
    let OpenCloseState = Prefixed_Name(saref, "OpenCloseState") |> PrefixedName
    /// <summary>
    ///   <para>saref:Coal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of commodity</para>
    /// labels<para>Coal</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Coal">https://saref.etsi.org/core/Coal</seealso>
    let Coal = Prefixed_Name(saref, "Coal") |> PrefixedName
    /// <summary>
    ///   <para>saref:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state in which a device can be found, e.g, ON/OFF/STANDBY, or ONLINE/OFFLINE. We propose here a list of states that are relevant for the purpose of SAREF, but this list can be extended.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/State">https://saref.etsi.org/core/State</seealso>
    let State = Prefixed_Name(saref, "State") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship identifying the manufacturer of an entity (e.g., device). The value is expected to be a string or a string with language tag.</para>
    /// labels<para>has manufacturer</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasManufacturer">https://saref.etsi.org/core/hasManufacturer</seealso>
    let hasManufacturer = Prefixed_Name(saref, "hasManufacturer") |> PrefixedName
    /// <summary>
    ///   <para>saref:controlsProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the property that can be controlled by a certain device</para>
    /// labels<para>controls property</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/controlsProperty">https://saref.etsi.org/core/controlsProperty</seealso>
    let controlsProperty = Prefixed_Name(saref, "controlsProperty") |> PrefixedName
    /// <summary>
    ///   <para>saref:measuresProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the property that can be measured by a certain device</para>
    /// labels<para>measures property</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/measuresProperty">https://saref.etsi.org/core/measuresProperty</seealso>
    let measuresProperty = Prefixed_Name(saref, "measuresProperty") |> PrefixedName
    /// <summary>
    ///   <para>saref:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A service is a representation of a function to a network that makes the function discoverable, registerable, remotely controllable by other devices in the network. A service can represent one or more functions. A Service is offered by a device that wants (a certain set of) its function(s) to be discoverable, registerable, remotely controllable by other devices in the network. A Service must specify the device that is offering the service and the function(s) to be represented.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Service">https://saref.etsi.org/core/Service</seealso>
    let Service = Prefixed_Name(saref, "Service") |> PrefixedName
    /// <summary>
    ///   <para>saref:offers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a device and a service</para>
    /// labels<para>offers</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/offers">https://saref.etsi.org/core/offers</seealso>
    let offers = Prefixed_Name(saref, "offers") |> PrefixedName
    /// <summary>
    ///   <para>saref:Drying</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Task</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>Drying</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Drying">https://saref.etsi.org/core/Drying</seealso>
    let Drying = Prefixed_Name(saref, "Drying") |> PrefixedName
    /// <summary>
    ///   <para>saref:Electricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of commodity</para>
    /// labels<para>Electricity</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Electricity">https://saref.etsi.org/core/Electricity</seealso>
    let Electricity = Prefixed_Name(saref, "Electricity") |> PrefixedName
    /// <summary>
    ///   <para>saref:Entertainment</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Task</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>Entertainment</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Entertainment">https://saref.etsi.org/core/Entertainment</seealso>
    let Entertainment = Prefixed_Name(saref, "Entertainment") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a feature of interest and a property of that feature</para>
    /// labels<para>has property</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasProperty">https://saref.etsi.org/core/hasProperty</seealso>
    let hasProperty = Prefixed_Name(saref, "hasProperty") |> PrefixedName

    /// <summary>
    ///   <para>saref:GetCurrentMeterValueCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of get command</para>
    /// labels<para>Get current meter value command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/GetCurrentMeterValueCommand">https://saref.etsi.org/core/GetCurrentMeterValueCommand</seealso>
    let GetCurrentMeterValueCommand =
        Prefixed_Name(saref, "GetCurrentMeterValueCommand") |> PrefixedName

    /// <summary>
    ///   <para>saref:MeteringFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that allows to get data from a meter, such as current meter reading or instantaneous demand</para>
    /// labels<para>Metering function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/MeteringFunction">https://saref.etsi.org/core/MeteringFunction</seealso>
    let MeteringFunction = Prefixed_Name(saref, "MeteringFunction") |> PrefixedName

    /// <summary>
    ///   <para>saref:GetMeterDataCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of get command</para>
    /// labels<para>Get meter data command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/GetMeterDataCommand">https://saref.etsi.org/core/GetMeterDataCommand</seealso>
    let GetMeterDataCommand =
        Prefixed_Name(saref, "GetMeterDataCommand") |> PrefixedName

    /// <summary>
    ///   <para>saref:SensingFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function that allows to transmit data from sensors, such as measurement values (e.g., temperature) or sensing data (e.g., occupancy)</para>
    /// labels<para>Sensing function</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/SensingFunction">https://saref.etsi.org/core/SensingFunction</seealso>
    let SensingFunction = Prefixed_Name(saref, "SensingFunction") |> PrefixedName
    /// <summary>
    ///   <para>saref:HVAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Heating, Ventilation and Air Conditioning (HVAC) device that provides indoor environmental comfort. A saref:HVAC is typically used to accomplish saref:Comfort.</para>
    /// labels<para>HVAC</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/HVAC">https://saref.etsi.org/core/HVAC</seealso>
    let HVAC = Prefixed_Name(saref, "HVAC") |> PrefixedName
    /// <summary>
    ///   <para>saref:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value that is measured in a humidity unit</para>
    /// labels<para>Humidity</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Humidity">https://saref.etsi.org/core/Humidity</seealso>
    let Humidity = Prefixed_Name(saref, "Humidity") |> PrefixedName
    /// <summary>
    ///   <para>saref:Light</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value that is measured in a illuminance unit (lux)</para>
    /// labels<para>Light</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Light">https://saref.etsi.org/core/Light</seealso>
    let Light = Prefixed_Name(saref, "Light") |> PrefixedName
    /// <summary>
    ///   <para>saref:LightSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A switch that performs the saref:OnOffFunction, controls the property saref:Light, and can be found in the state saref:OnOffState. It can offer a switch on service. A saref:LightSwitch is typically used to accomplish saref:Lighting.</para>
    /// labels<para>Light switch</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/LightSwitch">https://saref.etsi.org/core/LightSwitch</seealso>
    let LightSwitch = Prefixed_Name(saref, "LightSwitch") |> PrefixedName
    /// <summary>
    ///   <para>saref:relatesToProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a measurement and the property it relates to</para>
    /// labels<para>relates to property</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/relatesToProperty">https://saref.etsi.org/core/relatesToProperty</seealso>
    let relatesToProperty = Prefixed_Name(saref, "relatesToProperty") |> PrefixedName
    /// <summary>
    ///   <para>saref:isMeasuredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship identifying the unit of measure used for a certain entity.</para>
    /// labels<para>is measured in</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isMeasuredIn">https://saref.etsi.org/core/isMeasuredIn</seealso>
    let isMeasuredIn = Prefixed_Name(saref, "isMeasuredIn") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship stating the timestamp of an entity (e.g. a measurement).</para>
    /// labels<para>has timestamp</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasTimestamp">https://saref.etsi.org/core/hasTimestamp</seealso>
    let hasTimestamp = Prefixed_Name(saref, "hasTimestamp") |> PrefixedName
    /// <summary>
    ///   <para>saref:MeterReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Task</para>
    ///   <para>A type of task for which a device is designed</para>
    /// labels<para>Meter reading</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/MeterReading">https://saref.etsi.org/core/MeterReading</seealso>
    let MeterReading = Prefixed_Name(saref, "MeterReading") |> PrefixedName

    /// <summary>
    ///   <para>saref:hasMeterReadingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship identifying the reading type of a metering function (e.g., Water, Gas, Pressure , Energy , Power, etc.)</para>
    /// labels<para>has meter reading type</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasMeterReadingType">https://saref.etsi.org/core/hasMeterReadingType</seealso>
    let hasMeterReadingType =
        Prefixed_Name(saref, "hasMeterReadingType") |> PrefixedName

    /// <summary>
    ///   <para>saref:Occupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value (saref:hasValue property) that is measured in a unit of measure for occupancy</para>
    /// labels<para>Occupancy</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Occupancy">https://saref.etsi.org/core/Occupancy</seealso>
    let Occupancy = Prefixed_Name(saref, "Occupancy") |> PrefixedName
    /// <summary>
    ///   <para>saref:OffCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Off command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OffCommand">https://saref.etsi.org/core/OffCommand</seealso>
    let OffCommand = Prefixed_Name(saref, "OffCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:OffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state of a device that is Off</para>
    /// labels<para>Off state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OffState">https://saref.etsi.org/core/OffState</seealso>
    let OffState = Prefixed_Name(saref, "OffState") |> PrefixedName
    /// <summary>
    ///   <para>saref:OpenState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state of a device that is OPEN </para>
    /// labels<para>Open state</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/OpenState">https://saref.etsi.org/core/OpenState</seealso>
    let OpenState = Prefixed_Name(saref, "OpenState") |> PrefixedName
    /// <summary>
    ///   <para>saref:PauseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A type of command</para>
    /// labels<para>Pause command</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/PauseCommand">https://saref.etsi.org/core/PauseCommand</seealso>
    let PauseCommand = Prefixed_Name(saref, "PauseCommand") |> PrefixedName
    /// <summary>
    ///   <para>saref:Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value that is measured in a power unit (such as watt or kilowatt).  Further specializations of the saref:Power class can be found in the SAREF4ENER extension, where classes such as PowerMax, PowerMin and PowerExpected are defined.</para>
    /// labels<para>Power</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Power">https://saref.etsi.org/core/Power</seealso>
    let Power = Prefixed_Name(saref, "Power") |> PrefixedName
    /// <summary>
    ///   <para>saref:Pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property related to some measurements that are characterized by a certain value that is measured in a pressure unit (bar or pascal)</para>
    /// labels<para>Pressure</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Pressure">https://saref.etsi.org/core/Pressure</seealso>
    let Pressure = Prefixed_Name(saref, "Pressure") |> PrefixedName
    /// <summary>
    ///   <para>saref:PressureUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The unit of measure for pressure</para>
    /// labels<para>Pressure unit</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/PressureUnit">https://saref.etsi.org/core/PressureUnit</seealso>
    let PressureUnit = Prefixed_Name(saref, "PressureUnit") |> PrefixedName
    /// <summary>
    ///   <para>saref:Price</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A saref:Property crelated to some measurements that are characterized by a certain value that is measured using saref:Currency</para>
    /// labels<para>Price</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Price">https://saref.etsi.org/core/Price</seealso>
    let Price = Prefixed_Name(saref, "Price") |> PrefixedName
    /// <summary>
    ///   <para>saref:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class that allows to specify the time concept.</para>
    /// labels<para>Time</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/Time">https://saref.etsi.org/core/Time</seealso>
    let Time = Prefixed_Name(saref, "Time") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship to associate time information to an entity</para>
    /// labels<para>has time</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasTime">https://saref.etsi.org/core/hasTime</seealso>
    let hasTime = Prefixed_Name(saref, "hasTime") |> PrefixedName
    /// <summary>
    ///   <para>saref:hasPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship indentifying the price associated to an entity</para>
    /// labels<para>has price</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/hasPrice">https://saref.etsi.org/core/hasPrice</seealso>
    let hasPrice = Prefixed_Name(saref, "hasPrice") |> PrefixedName

    /// <summary>
    ///   <para>saref:relatesToMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a property and the measurements it relates to</para>
    /// labels<para>relates to measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/relatesToMeasurement">https://saref.etsi.org/core/relatesToMeasurement</seealso>
    let relatesToMeasurement =
        Prefixed_Name(saref, "relatesToMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>saref:isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship between a property and the feature of interest it belongs to</para>
    /// labels<para>is property of</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isPropertyOf">https://saref.etsi.org/core/isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(saref, "isPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>saref:isMeasuredByDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the devices that can measure a certain property</para>
    /// labels<para>is measured by device</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isMeasuredByDevice">https://saref.etsi.org/core/isMeasuredByDevice</seealso>
    let isMeasuredByDevice = Prefixed_Name(saref, "isMeasuredByDevice") |> PrefixedName

    /// <summary>
    ///   <para>saref:isControlledByDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship specifying the devices that can control a certain property</para>
    /// labels<para>is controlled by device</para></remarks>
    /// <seealso href="https://saref.etsi.org/core/isControlledByDevice">https://saref.etsi.org/core/isControlledByDevice</seealso>
    let isControlledByDevice =
        Prefixed_Name(saref, "isControlledByDevice") |> PrefixedName
