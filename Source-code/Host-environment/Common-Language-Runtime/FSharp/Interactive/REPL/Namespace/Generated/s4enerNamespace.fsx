#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4ener =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4ener/" "s4ener"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Activation delay</para>
    ///   <para>rdfs:comment : The scheduled activation delay for a slot.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActivationDelay">s4ener:ActivationDelay</a>
    /// </summary>
    let ActivationDelay = _prefixId.prefix "ActivationDelay"

    /// <summary>
    ///   <para>rdfs:label : Activation delay duration description</para>
    ///   <para>rdfs:comment : The duration description for the activation delay duration temporal entity</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActivationDelayDurationDescription">s4ener:ActivationDelayDurationDescription</a>
    /// </summary>
    let ActivationDelayDurationDescription =
        _prefixId.prefix "ActivationDelayDurationDescription"

    /// <summary>
    ///   <para>rdfs:label : Active duration description</para>
    ///   <para>rdfs:comment : The duration description for the active duration (min and max, sum max and sum min) temporal entities</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActiveDurationDescription">s4ener:ActiveDurationDescription</a>
    /// </summary>
    let ActiveDurationDescription = _prefixId.prefix "ActiveDurationDescription"
    /// <summary>
    ///   <para>rdfs:label : Active duration max</para>
    ///   <para>rdfs:comment : The active maximum duration a power sequence can run without interruption.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActiveDurationMax">s4ener:ActiveDurationMax</a>
    /// </summary>
    let ActiveDurationMax = _prefixId.prefix "ActiveDurationMax"
    /// <summary>
    ///   <para>rdfs:label : Active duration min</para>
    ///   <para>rdfs:comment : The active mininum duration a power sequence can run without interruption.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActiveDurationMin">s4ener:ActiveDurationMin</a>
    /// </summary>
    let ActiveDurationMin = _prefixId.prefix "ActiveDurationMin"
    /// <summary>
    ///   <para>rdfs:label : Active duration sum max</para>
    ///   <para>rdfs:comment : The active maximum duration a power sequence can run in total (summation of all active times).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActiveDurationSumMax">s4ener:ActiveDurationSumMax</a>
    /// </summary>
    let ActiveDurationSumMax = _prefixId.prefix "ActiveDurationSumMax"
    /// <summary>
    ///   <para>rdfs:label : Active duration sum min</para>
    ///   <para>rdfs:comment : The active minimum duration a power sequence must run in total (summation of all active times).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActiveDurationSumMin">s4ener:ActiveDurationSumMin</a>
    /// </summary>
    let ActiveDurationSumMin = _prefixId.prefix "ActiveDurationSumMin"
    /// <summary>
    ///   <para>rdfs:label : Actuator level</para>
    ///   <para>rdfs:comment : Independent from the ActuatorSwitch class, the ActuatorLevel class enables a user or application to model LEVEL commands (start, up, percentageAbsolute, relative, etc.). This can be used to dim a light, set the speed of an electric motor, etc.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActuatorLevel">s4ener:ActuatorLevel</a>
    /// </summary>
    let ActuatorLevel = _prefixId.prefix "ActuatorLevel"
    /// <summary>
    ///   <para>rdfs:label : Actuator switch</para>
    ///   <para>rdfs:comment : Basic on/off operations on a simple actuator can be modelled with the ActuatorSwitch class. Whether the function turns a device itself ON or OFF, or whether it switches a specific feature, depends on the implementation. For example, one could model the super freeze program of a freezer using ActuatorSwitch class. An ON command would then activate the super freeze program and an OFF command would deactivate it. This example shall just give an idea how ActuatorSwitch can be used for more purposes than only turning devices on and off.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ActuatorSwitch">s4ener:ActuatorSwitch</a>
    /// </summary>
    let ActuatorSwitch = _prefixId.prefix "ActuatorSwitch"
    /// <summary>
    ///   <para>rdfs:label : Alternatives group</para>
    ///   <para>rdfs:comment : A collection of power sequences for a certain profile</para>
    ///   <a href="https://saref.etsi.org/saref4ener/AlternativesGroup">s4ener:AlternativesGroup</a>
    /// </summary>
    let AlternativesGroup = _prefixId.prefix "AlternativesGroup"

    /// <summary>
    ///   <para>rdfs:label : Anticipation duration description</para>
    ///   <para>rdfs:comment : The duration description for the anticipation duration temporal entities</para>
    ///   <a href="https://saref.etsi.org/saref4ener/AnticipationDurationDescription">s4ener:AnticipationDurationDescription</a>
    /// </summary>
    let AnticipationDurationDescription =
        _prefixId.prefix "AnticipationDurationDescription"

    let Completed = _prefixId.prefix "Completed"
    /// <summary>
    ///   <para>rdfs:label : Default duration</para>
    ///   <para>rdfs:comment : The duration of a slot (SHALL be present in case of 'determined slot'). If a slot has a configurable lenght, this element SHALL reflect the currently configured lenght</para>
    ///   <a href="https://saref.etsi.org/saref4ener/DefaultDuration">s4ener:DefaultDuration</a>
    /// </summary>
    let DefaultDuration = _prefixId.prefix "DefaultDuration"
    /// <summary>
    ///   <para>rdfs:label : Default duration description</para>
    ///   <para>rdfs:comment : The duration description for the default duration temporal entity</para>
    ///   <a href="https://saref.etsi.org/saref4ener/DefaultDurationDescription">s4ener:DefaultDurationDescription</a>
    /// </summary>
    let DefaultDurationDescription = _prefixId.prefix "DefaultDurationDescription"
    /// <summary>
    ///   <para>rdfs:label : Device</para>
    ///   <para>rdfs:comment : A specialization of a saref:Device that exposes a power profile with power sequences to the CEM (note that a s4ee:Device can also be called 'power sequence server'). Most of the existing devices can expose at most 1 power profile, but there are special cases in which more than one power profiles can be exposed by the same device. For example, consider the case of a combined fridge-freezer in which there are 2 logical devices (fridge and freezer) combined in 1 physical device. This combined device can expose 2 power profiles, one for the fridge and one for the freezer. A s4ee:Device (e.g. a household appliance or a smart meter) can also receive events about overload warning severity level and related load control commands (LoadControlEventData)</para>
    ///   <a href="https://saref.etsi.org/saref4ener/Device">s4ener:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>rdfs:label : Duration uncertainty</para>
    ///   <para>rdfs:comment : The uncertainty of the duration </para>
    ///   <a href="https://saref.etsi.org/saref4ener/DurationUncertainty">s4ener:DurationUncertainty</a>
    /// </summary>
    let DurationUncertainty = _prefixId.prefix "DurationUncertainty"

    /// <summary>
    ///   <para>rdfs:label : Duration uncertainty description</para>
    ///   <para>rdfs:comment : The duration description for the duration uncertainty temporal entity</para>
    ///   <a href="https://saref.etsi.org/saref4ener/DurationUncertaintyDescription">s4ener:DurationUncertaintyDescription</a>
    /// </summary>
    let DurationUncertaintyDescription =
        _prefixId.prefix "DurationUncertaintyDescription"

    /// <summary>
    ///   <para>rdfs:label : Earliest start time</para>
    ///   <para>rdfs:comment : The earliest possible start time for a power sequence or a slot. Only 'xs:duration' value types SHALL be used to denote a relative time which relates to 'now' as time 0.
    /// Note: This element applies to the first repetition of the slot number only.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EarliestStartTime">s4ener:EarliestStartTime</a>
    /// </summary>
    let EarliestStartTime = _prefixId.prefix "EarliestStartTime"
    /// <summary>
    ///   <para>rdfs:label : Elapsed slot time</para>
    ///   <para>rdfs:comment : If state is set to 'running' or 'paused' AND the slot is determined, this element CAN contain the time the slot has already been in 'running' state (this also means the value remains constant during a 'paused' state). Otherwise it SHALL be omitted.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ElapsedSlotTime">s4ener:ElapsedSlotTime</a>
    /// </summary>
    let ElapsedSlotTime = _prefixId.prefix "ElapsedSlotTime"
    let Emergency = _prefixId.prefix "Emergency"
    /// <summary>
    ///   <para>rdfs:label : End time</para>
    ///   <para>rdfs:comment : The endTime of a power sequence. If the value is available, it SHALL be denoted here. Otherwise the element SHALL be omitted.
    /// The end time of a slot MAY be stated in this element. The following equation SHALL apply: endTime - startTime = defaultDuration.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EndTime">s4ener:EndTime</a>
    /// </summary>
    let EndTime = _prefixId.prefix "EndTime"
    /// <summary>
    ///   <para>rdfs:label : End time duration Description</para>
    ///   <para>rdfs:comment : The duration description for the end time duration temporal entities</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EndTimeDurationDescription">s4ener:EndTimeDurationDescription</a>
    /// </summary>
    let EndTimeDurationDescription = _prefixId.prefix "EndTimeDurationDescription"
    /// <summary>
    ///   <para>rdfs:label : Energy</para>
    ///   <para>rdfs:comment : Energy type and value in a slot (i.e., Energy, EnergyMin, EnergyMax, EnergyExpected, EnergyStandardDeviation, EnergySkewness); or the ResumeEnergyEstimated in a power sequence, i.e., the additional energy the device will consume before resuming its normal operation (after a pause)</para>
    ///   <a href="https://saref.etsi.org/saref4ener/Energy">s4ener:Energy</a>
    /// </summary>
    let Energy = _prefixId.prefix "Energy"
    /// <summary>
    ///   <para>rdfs:label : Energy expected</para>
    ///   <para>rdfs:comment : A possible type of energy in a slot that represents the expected energy consumption and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EnergyExpected">s4ener:EnergyExpected</a>
    /// </summary>
    let EnergyExpected = _prefixId.prefix "EnergyExpected"
    /// <summary>
    ///   <para>rdfs:label : Energy max</para>
    ///   <para>rdfs:comment : A possible type of energy in a slot that represents the maximum energy consumption and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EnergyMax">s4ener:EnergyMax</a>
    /// </summary>
    let EnergyMax = _prefixId.prefix "EnergyMax"
    /// <summary>
    ///   <para>rdfs:label : Energy min</para>
    ///   <para>rdfs:comment : A possible type of energy in a slot that represents the minimum energy consumption and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EnergyMin">s4ener:EnergyMin</a>
    /// </summary>
    let EnergyMin = _prefixId.prefix "EnergyMin"
    /// <summary>
    ///   <para>rdfs:label : Energy skewness</para>
    ///   <para>rdfs:comment : A possible type of energy in a slot that represents the energy skewness and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EnergySkewness">s4ener:EnergySkewness</a>
    /// </summary>
    let EnergySkewness = _prefixId.prefix "EnergySkewness"
    /// <summary>
    ///   <para>rdfs:label : Energy Standard Deviation</para>
    ///   <para>rdfs:comment : A possible type of energy in a slot  that represents the energy standard deviation and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EnergyStandardDeviation">s4ener:EnergyStandardDeviation</a>
    /// </summary>
    let EnergyStandardDeviation = _prefixId.prefix "EnergyStandardDeviation"
    let EventAccepted = _prefixId.prefix "EventAccepted"
    /// <summary>
    ///   <para>rdfs:comment : An action type used to express a consume action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).</para>
    ///   <para>rdfs:label : Event action consume</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EventActionConsume">s4ener:EventActionConsume</a>
    /// </summary>
    let EventActionConsume = _prefixId.prefix "EventActionConsume"
    /// <summary>
    ///   <para>rdfs:comment : An action type used to express a produce action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).</para>
    ///   <para>rdfs:label : Event action produce</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EventActionProduce">s4ener:EventActionProduce</a>
    /// </summary>
    let EventActionProduce = _prefixId.prefix "EventActionProduce"
    let EventCancelled = _prefixId.prefix "EventCancelled"
    let EventError = _prefixId.prefix "EventError"
    let EventRejected = _prefixId.prefix "EventRejected"
    let EventStarted = _prefixId.prefix "EventStarted"
    /// <summary>
    ///   <para>rdfs:label : Event state consume</para>
    ///   <para>rdfs:comment : In the load control, it expresses a consume state of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EventStateConsume">s4ener:EventStateConsume</a>
    /// </summary>
    let EventStateConsume = _prefixId.prefix "EventStateConsume"
    /// <summary>
    ///   <para>rdfs:label : Event state produce</para>
    ///   <para>rdfs:comment : In the load control, it expresses a produce state of an event an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/EventStateProduce">s4ener:EventStateProduce</a>
    /// </summary>
    let EventStateProduce = _prefixId.prefix "EventStateProduce"
    let EventStopped = _prefixId.prefix "EventStopped"
    let Inactive = _prefixId.prefix "Inactive"
    let Increase = _prefixId.prefix "Increase"
    let Invalid = _prefixId.prefix "Invalid"
    /// <summary>
    ///   <para>rdfs:label : Latest end time</para>
    ///   <para>rdfs:comment : The latest possible end time for a power sequence or a slot. Only 'xs:duration' value types SHALL be used to denote a relative time which relates to 'now' as time 0.
    /// Note: This element applies to the first repetition of the slot number only.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/LatestEndTime">s4ener:LatestEndTime</a>
    /// </summary>
    let LatestEndTime = _prefixId.prefix "LatestEndTime"
    /// <summary>
    ///   <para>rdfs:label : Load Control event action</para>
    ///   <para>rdfs:comment : An action type used to express the action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/LoadControlEventAction">s4ener:LoadControlEventAction</a>
    /// </summary>
    let LoadControlEventAction = _prefixId.prefix "LoadControlEventAction"
    /// <summary>
    ///   <para>rdfs:comment : An event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).</para>
    ///   <para>rdfs:label : Load control event data</para>
    ///   <a href="https://saref.etsi.org/saref4ener/LoadControlEventData">s4ener:LoadControlEventData</a>
    /// </summary>
    let LoadControlEventData = _prefixId.prefix "LoadControlEventData"
    /// <summary>
    ///   <para>rdfs:label : Load control event state </para>
    ///   <para>rdfs:comment : In the load control, it expresses the possible states of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/LoadControlEventState">s4ener:LoadControlEventState</a>
    /// </summary>
    let LoadControlEventState = _prefixId.prefix "LoadControlEventState"
    /// <summary>
    ///   <para>rdfs:label : Load control state data</para>
    ///   <para>rdfs:comment : The representation of the state of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/LoadControlStateData">s4ener:LoadControlStateData</a>
    /// </summary>
    let LoadControlStateData = _prefixId.prefix "LoadControlStateData"
    /// <summary>
    ///   <para>rdfs:label : Max activation delay</para>
    ///   <para>rdfs:comment : Maximum delay time between the end of the previous slot and the beginning of the current slot.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/MaxActivationDelay">s4ener:MaxActivationDelay</a>
    /// </summary>
    let MaxActivationDelay = _prefixId.prefix "MaxActivationDelay"
    /// <summary>
    ///   <para>rdfs:label : Max anticipation</para>
    ///   <para>rdfs:comment : This field allows the anticipation of the phase if (and only if) the previous phase has the energy set to 0 Wh, each unit is a minute.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/MaxAnticipation">s4ener:MaxAnticipation</a>
    /// </summary>
    let MaxAnticipation = _prefixId.prefix "MaxAnticipation"
    /// <summary>
    ///   <para>rdfs:label : Max duration</para>
    ///   <para>rdfs:comment : If a slot has a configurable duration, it SHALL be present and denote the maximum supported configuration. Note: This element applies to the first repetition of the slot number only</para>
    ///   <a href="https://saref.etsi.org/saref4ener/MaxDuration">s4ener:MaxDuration</a>
    /// </summary>
    let MaxDuration = _prefixId.prefix "MaxDuration"
    /// <summary>
    ///   <para>rdfs:label : Min duration</para>
    ///   <para>rdfs:comment : If a slot has a configurable duration, it SHALL be present and denote the minimum supported configuration. Note: This element applies to the first repetition of the slot number only.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/MinDuration">s4ener:MinDuration</a>
    /// </summary>
    let MinDuration = _prefixId.prefix "MinDuration"
    let Normal = _prefixId.prefix "Normal"
    let Pause = _prefixId.prefix "Pause"
    /// <summary>
    ///   <para>rdfs:label : Pause duration description</para>
    ///   <para>rdfs:comment : The duration description for the pause duration (max and min) temporal entities</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PauseDurationDescription">s4ener:PauseDurationDescription</a>
    /// </summary>
    let PauseDurationDescription = _prefixId.prefix "PauseDurationDescription"
    /// <summary>
    ///   <para>rdfs:label : Pause duration max</para>
    ///   <para>rdfs:comment : The maximum duration a power sequence can pause after the end of an activity.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PauseDurationMax">s4ener:PauseDurationMax</a>
    /// </summary>
    let PauseDurationMax = _prefixId.prefix "PauseDurationMax"
    /// <summary>
    ///   <para>rdfs:label : Pause duration min</para>
    ///   <para>rdfs:comment : The minimum duration a power sequence can pause after the end of an activity.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PauseDurationMin">s4ener:PauseDurationMin</a>
    /// </summary>
    let PauseDurationMin = _prefixId.prefix "PauseDurationMin"
    /// <summary>
    ///   <para>rdfs:label : Pause time</para>
    ///   <para>rdfs:comment : The pause time of a power sequence or a slot</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PauseTime">s4ener:PauseTime</a>
    /// </summary>
    let PauseTime = _prefixId.prefix "PauseTime"
    let Paused = _prefixId.prefix "Paused"
    let Pending = _prefixId.prefix "Pending"
    /// <summary>
    ///   <para>rdfs:label : Power</para>
    ///   <para>rdfs:comment : Power type and value in a slot (i.e. power, powerMin, powerMax, powerExpectedValue, powerStandardDeviation, powerSkewness)</para>
    ///   <a href="https://saref.etsi.org/saref4ener/Power">s4ener:Power</a>
    /// </summary>
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:label : Power expected </para>
    ///   <para>rdfs:comment : A possible type of power in a slot that represents the expected power consumption and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PowerExpected">s4ener:PowerExpected</a>
    /// </summary>
    let PowerExpected = _prefixId.prefix "PowerExpected"
    /// <summary>
    ///   <para>rdfs:label : Power max</para>
    ///   <para>rdfs:comment : A possible type of power in a slot that represents the maximum power consumption and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PowerMax">s4ener:PowerMax</a>
    /// </summary>
    let PowerMax = _prefixId.prefix "PowerMax"
    /// <summary>
    ///   <para>rdfs:label : Power min</para>
    ///   <para>rdfs:comment : A possible type of power in a slot that represents the minimum power consumption and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PowerMin">s4ener:PowerMin</a>
    /// </summary>
    let PowerMin = _prefixId.prefix "PowerMin"
    /// <summary>
    ///   <para>rdfs:label : Power profile</para>
    ///   <para>rdfs:comment : A way to model curves of power and energy over time, which also provides definitions for the modelling of power scheduling including alternative plans. With a PowerProfile, a device (or power sequences server) exposes the power sequences that are potentially relevant for the CEM (or power sequences client). </para>
    ///   <a href="https://saref.etsi.org/saref4ener/PowerProfile">s4ener:PowerProfile</a>
    /// </summary>
    let PowerProfile = _prefixId.prefix "PowerProfile"
    /// <summary>
    ///   <para>rdfs:label : Power sequence</para>
    ///   <para>rdfs:comment : The specification of a task, such as wash or tumble dry, according to user preferences and/or manufacturer's settings for a certain device.  It is the most 'coarse' view, a power sequence can represent all single steps of a whole task,where the single steps are represented by slots. If the power sequence is pausable by the bound power sequences client, the property 'saref:isInterruptionPossible' SHALL be present and set to true. Otherwise it SHALL be omitted. If the power sequence is stoppable by the bound power sequences client, the property 'saref:isFlexible' SHALL be present and set to true. Otherwise it SHALL be omitted.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PowerSequence">s4ener:PowerSequence</a>
    /// </summary>
    let PowerSequence = _prefixId.prefix "PowerSequence"
    /// <summary>
    ///   <para>rdfs:label : Power sequence state</para>
    ///   <para>rdfs:comment : The current state of the power sequence. It can assume one of the values 'running', 'paused', 'scheduled', 'scheduled paused', 'pending', 'inactive', 'completed',  or 'invalid'.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PowerSequenceState">s4ener:PowerSequenceState</a>
    /// </summary>
    let PowerSequenceState = _prefixId.prefix "PowerSequenceState"
    /// <summary>
    ///   <para>rdfs:label : Power skewness</para>
    ///   <para>rdfs:comment : A possible type of power in a slot that represents the power skewness and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PowerSkewness">s4ener:PowerSkewness</a>
    /// </summary>
    let PowerSkewness = _prefixId.prefix "PowerSkewness"
    /// <summary>
    ///   <para>rdfs:label : Power standard deviation</para>
    ///   <para>rdfs:comment : A possible type of power in a slot that represents the power standard deviation and its value</para>
    ///   <a href="https://saref.etsi.org/saref4ener/PowerStandardDeviation">s4ener:PowerStandardDeviation</a>
    /// </summary>
    let PowerStandardDeviation = _prefixId.prefix "PowerStandardDeviation"
    let Reduce = _prefixId.prefix "Reduce"
    /// <summary>
    ///   <para>rdfs:label : Remaining pause time</para>
    ///   <para>rdfs:comment : The duration that the current slot (s4ee:activeSlotNumber) permits being paused. This element SHALL ONLY be present if the power sequence is interruptible. Otherwise, it SHALL be omitted. In case the power sequence is interruptible the following rules apply: If the element is absent this means there is no explicit pause duration restriction for the current slot; a value of 0s denoted the slot does not permit being paused.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/RemainingPauseTime">s4ener:RemainingPauseTime</a>
    /// </summary>
    let RemainingPauseTime = _prefixId.prefix "RemainingPauseTime"
    /// <summary>
    ///   <para>rdfs:label : Remaining slot time</para>
    ///   <para>rdfs:comment : If state is set to 'running' or 'paused' AND the slot is determined, this element SHALL contain the time the slot still needs to be in 'running' state (this also means the value remains constant during a 'paused' state). Otherwise it SHALL be omitted.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/RemainingSlotTime">s4ener:RemainingSlotTime</a>
    /// </summary>
    let RemainingSlotTime = _prefixId.prefix "RemainingSlotTime"
    let Resume = _prefixId.prefix "Resume"
    /// <summary>
    ///   <para>rdfs:label : Resume cost estimated</para>
    ///   <para>rdfs:comment : In a power sequence the additional costs for the resumption of a device to its normal operation (after a pause).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ResumeCostEstimated">s4ener:ResumeCostEstimated</a>
    /// </summary>
    let ResumeCostEstimated = _prefixId.prefix "ResumeCostEstimated"
    /// <summary>
    ///   <para>rdfs:label : Resume energy estimated</para>
    ///   <para>rdfs:comment : In a power sequence, the additional energy the device will consume before resuming its normal operation (after a pause). This is only an estimated value which will not be added to the value stated in any slot value information.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/ResumeEnergyEstimated">s4ener:ResumeEnergyEstimated</a>
    /// </summary>
    let ResumeEnergyEstimated = _prefixId.prefix "ResumeEnergyEstimated"
    let Running = _prefixId.prefix "Running"
    let Scheduled = _prefixId.prefix "Scheduled"
    let ScheduledPaused = _prefixId.prefix "ScheduledPaused"
    /// <summary>
    ///   <para>rdfs:label : Slot</para>
    ///   <para>rdfs:comment : The single steps of a power sequence are represented by slots. A slot is associated with a slot number (while a power sequence is associated with a power sequence identifier). The slot numbers of two power sequences should be considered independent from each other, i.e., slot number 7 of sequence 1 describes a different slot than slot number 7 of sequence 2. Therefore a slot is only uniquely identified in combination with a sequence ID. </para>
    ///   <a href="https://saref.etsi.org/saref4ener/Slot">s4ener:Slot</a>
    /// </summary>
    let Slot = _prefixId.prefix "Slot"
    /// <summary>
    ///   <para>rdfs:label : Slot time duration description</para>
    ///   <para>rdfs:comment : The duration description for the slot time duration temporal entities</para>
    ///   <a href="https://saref.etsi.org/saref4ener/SlotTimeDurationDescription">s4ener:SlotTimeDurationDescription</a>
    /// </summary>
    let SlotTimeDurationDescription = _prefixId.prefix "SlotTimeDurationDescription"
    /// <summary>
    ///   <para>rdfs:label : Start time</para>
    ///   <para>rdfs:comment : The startTime of a power sequence or slot. SHALL be present</para>
    ///   <a href="https://saref.etsi.org/saref4ener/StartTime">s4ener:StartTime</a>
    /// </summary>
    let StartTime = _prefixId.prefix "StartTime"
    /// <summary>
    ///   <para>rdfs:label : Start time duration description</para>
    ///   <para>rdfs:comment : The duration description for the start time duration temporal entities</para>
    ///   <a href="https://saref.etsi.org/saref4ener/StartTimeDurationDescription">s4ener:StartTimeDurationDescription</a>
    /// </summary>
    let StartTimeDurationDescription = _prefixId.prefix "StartTimeDurationDescription"
    /// <summary>
    ///   <para>rdfs:label : State</para>
    ///   <para>rdfs:comment : An entity that represents the possible states in SAREF4EE</para>
    ///   <a href="https://saref.etsi.org/saref4ener/State">s4ener:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : Time period</para>
    ///   <para>rdfs:comment : The time period associated with load control event data</para>
    ///   <a href="https://saref.etsi.org/saref4ener/TimePeriod">s4ener:TimePeriod</a>
    /// </summary>
    let TimePeriod = _prefixId.prefix "TimePeriod"
    /// <summary>
    ///   <para>rdfs:label : Time period duration description</para>
    ///   <para>rdfs:comment : The duration description for the time period duration temporal entities</para>
    ///   <a href="https://saref.etsi.org/saref4ener/TimePeriodDurationDescription">s4ener:TimePeriodDurationDescription</a>
    /// </summary>
    let TimePeriodDurationDescription = _prefixId.prefix "TimePeriodDurationDescription"
    /// <summary>
    ///   <para>rdfs:label : activate slot</para>
    ///   <para>rdfs:comment : Indicates whether a slot is used (activateSlot = true) or not (activateSlot = false). SHALL be present if a slot is optional (i.e., the property s4ee:optionalSlot is TRUE), otherwise SHALL be absent (i.e. in case the slot is mandatory).</para>
    ///   <a href="https://saref.etsi.org/saref4ener/activateSlot">s4ener:activateSlot</a>
    /// </summary>
    let activateSlot = _prefixId.prefix "activateSlot"
    /// <summary>
    ///   <para>rdfs:label : active repetition number</para>
    ///   <para>rdfs:comment : Indicates the current repetition of the sequence of slots. SHALL be present if a power sequence can repeat its sequence of slots (i.e., if s4ee:repetitionTotal is present and has a value &gt; 1). Otherwise, it SHALL be absent. </para>
    ///   <a href="https://saref.etsi.org/saref4ener/activeRepetitionNumber">s4ener:activeRepetitionNumber</a>
    /// </summary>
    let activeRepetitionNumber = _prefixId.prefix "activeRepetitionNumber"
    /// <summary>
    ///   <para>rdfs:label : active slot number</para>
    ///   <para>rdfs:comment : Indicates the currently active slot number, if the power sequence state is set to 'running' or 'paused'. Otherwise it SHALL be omitted.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/activeSlotNumber">s4ener:activeSlotNumber</a>
    /// </summary>
    let activeSlotNumber = _prefixId.prefix "activeSlotNumber"
    /// <summary>
    ///   <para>rdfs:label : alternatives count</para>
    ///   <para>rdfs:comment : Indicates the number of alternatives groups provided by a power profile</para>
    ///   <a href="https://saref.etsi.org/saref4ener/alternativesCount">s4ener:alternativesCount</a>
    /// </summary>
    let alternativesCount = _prefixId.prefix "alternativesCount"
    /// <summary>
    ///   <para>rdfs:label : alternatives group ID</para>
    ///   <para>rdfs:comment : The endpoint-wide unique identifier for the alternatives group instances provided by a power profile</para>
    ///   <a href="https://saref.etsi.org/saref4ener/alternativesGroupID">s4ener:alternativesGroupID</a>
    /// </summary>
    let alternativesGroupID = _prefixId.prefix "alternativesGroupID"
    /// <summary>
    ///   <para>rdfs:label : belongs to</para>
    ///   <para>rdfs:comment : A relationship identifying the ownership of an entity. In particular, a slot belongs to a power sequence, a power sequence belongs to an alternative, an alternative  belongs to a power profile, a power profile belongs to a device.  </para>
    ///   <a href="https://saref.etsi.org/saref4ener/belongsTo">s4ener:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>rdfs:label : brand name</para>
    ///   <para>rdfs:comment : Provides the name of the brand of a device. Useful where the name of the brand and the vendor differs.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/brandName">s4ener:brandName</a>
    /// </summary>
    let brandName = _prefixId.prefix "brandName"
    /// <summary>
    ///   <para>rdfs:label : cheapest</para>
    ///   <para>rdfs:comment : Indicates whether a power sequence applies a configuration that minimises the user’s energy bill (if set to TRUE). MAY be present. Absence of this element is equal to the presence with value FALSE. </para>
    ///   <a href="https://saref.etsi.org/saref4ener/cheapest">s4ener:cheapest</a>
    /// </summary>
    let cheapest = _prefixId.prefix "cheapest"
    /// <summary>
    ///   <para>rdfs:label : device code</para>
    ///   <para>rdfs:comment : Provides a device code for the device as defined by the manufacturer.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/deviceCode">s4ener:deviceCode</a>
    /// </summary>
    let deviceCode = _prefixId.prefix "deviceCode"
    /// <summary>
    ///   <para>rdfs:label : device name</para>
    ///   <para>rdfs:comment : Provides the name of the device as defined by the manufacturer.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/deviceName">s4ener:deviceName</a>
    /// </summary>
    let deviceName = _prefixId.prefix "deviceName"
    /// <summary>
    ///   <para>rdfs:label : event ID</para>
    ///   <para>rdfs:comment : Used in the Demand Response use case to identify an event</para>
    ///   <a href="https://saref.etsi.org/saref4ener/eventID">s4ener:eventID</a>
    /// </summary>
    let eventID = _prefixId.prefix "eventID"
    /// <summary>
    ///   <para>rdfs:label : exposes</para>
    ///   <para>rdfs:comment : A relationship between a device and its power profile</para>
    ///   <a href="https://saref.etsi.org/saref4ener/exposes">s4ener:exposes</a>
    /// </summary>
    let exposes = _prefixId.prefix "exposes"
    /// <summary>
    ///   <para>rdfs:label : greenest</para>
    ///   <para>rdfs:comment : Indicates whether a power sequence optimises the configuration towards the maximum availability of renewable energy (if set to TRUE). MAY be present. Absence of this element is equal to the presence with value FALSE. </para>
    ///   <a href="https://saref.etsi.org/saref4ener/greenest">s4ener:greenest</a>
    /// </summary>
    let greenest = _prefixId.prefix "greenest"
    /// <summary>
    ///   <para>rdfs:label : hardware revision </para>
    ///   <para>rdfs:comment : Indicates the hardware revision of the device as defined by the manufacturer.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hardwareRevision">s4ener:hardwareRevision</a>
    /// </summary>
    let hardwareRevision = _prefixId.prefix "hardwareRevision"
    /// <summary>
    ///   <para>rdfs:label : has applied event action consume</para>
    ///   <para>rdfs:comment : A relationship between the state of a load control event consume and the action to be performed as a consequence of this event.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasAppliedEventActionConsume">s4ener:hasAppliedEventActionConsume</a>
    /// </summary>
    let hasAppliedEventActionConsume = _prefixId.prefix "hasAppliedEventActionConsume"
    /// <summary>
    ///   <para>rdfs:label : has applied event action produce</para>
    ///   <para>rdfs:comment : A relationship between the state of a load control event produce and the action to be performed as a consequence of this event.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasAppliedEventActionProduce">s4ener:hasAppliedEventActionProduce</a>
    /// </summary>
    let hasAppliedEventActionProduce = _prefixId.prefix "hasAppliedEventActionProduce"
    /// <summary>
    ///   <para>rdfs:label : has connection</para>
    ///   <para>rdfs:comment : In the Remote Network Management (RemoteNWM) use case, a relationship between a node in a network (i.e., a s4ee:Device) and its connections (i.e., a s4ee:DeviceConnections). The same s4ee:Device (or node) can have multiple device connections as it can be connected to several networks at the same time.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasConnection">s4ener:hasConnection</a>
    /// </summary>
    let hasConnection = _prefixId.prefix "hasConnection"
    /// <summary>
    ///   <para>rdfs:label : has device</para>
    ///   <para>rdfs:comment : A relationship between a load control event (used to send overload warning severity level and related load control commands) and the device interested by this event.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasDevice">s4ener:hasDevice</a>
    /// </summary>
    let hasDevice = _prefixId.prefix "hasDevice"
    /// <summary>
    ///   <para>rdfs:label : has energy</para>
    ///   <para>rdfs:comment : A relationship between a power sequence and its energy (in terms of value and unit of measure)</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasEnergy">s4ener:hasEnergy</a>
    /// </summary>
    let hasEnergy = _prefixId.prefix "hasEnergy"
    /// <summary>
    ///   <para>rdfs:label : has energy value type</para>
    ///   <para>rdfs:comment : A relationship representing an energy value type</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasEnergyValueType">s4ener:hasEnergyValueType</a>
    /// </summary>
    let hasEnergyValueType = _prefixId.prefix "hasEnergyValueType"
    /// <summary>
    ///   <para>rdfs:label : has event state consume</para>
    ///   <para>rdfs:comment : A relationship between the specification of the state of a load control event consume and the value that this state can assume.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasEventStateConsume">s4ener:hasEventStateConsume</a>
    /// </summary>
    let hasEventStateConsume = _prefixId.prefix "hasEventStateConsume"
    /// <summary>
    ///   <para>rdfs:label : has event state produce</para>
    ///   <para>rdfs:comment : A relationship between the specification of the state of a load control event produce and the value that this state can assume.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasEventStateProduce">s4ener:hasEventStateProduce</a>
    /// </summary>
    let hasEventStateProduce = _prefixId.prefix "hasEventStateProduce"
    /// <summary>
    ///   <para>rdfs:label : has expression</para>
    ///   <para>rdfs:comment : A relationship between an appliance parameter compatibility action and the associated expressions</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasExpression">s4ener:hasExpression</a>
    /// </summary>
    let hasExpression = _prefixId.prefix "hasExpression"
    /// <summary>
    ///   <para>rdfs:label : has function</para>
    ///   <para>rdfs:comment : A relationship identifying the functions performed by an actuator level and an actuator switch</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasFunction">s4ener:hasFunction</a>
    /// </summary>
    let hasFunction = _prefixId.prefix "hasFunction"
    /// <summary>
    ///   <para>rdfs:label : has power value type</para>
    ///   <para>rdfs:comment : A relationship representing a power value type</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasPowerValueType">s4ener:hasPowerValueType</a>
    /// </summary>
    let hasPowerValueType = _prefixId.prefix "hasPowerValueType"
    /// <summary>
    ///   <para>rdfs:label : has value type</para>
    ///   <para>rdfs:comment : A relation representing the value type of an entity</para>
    ///   <a href="https://saref.etsi.org/saref4ener/hasValueType">s4ener:hasValueType</a>
    /// </summary>
    let hasValueType = _prefixId.prefix "hasValueType"
    /// <summary>
    ///   <para>rdfs:label : is pausable</para>
    ///   <para>rdfs:comment : Specifies if the power sequence is pausable.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/isPausable">s4ener:isPausable</a>
    /// </summary>
    let isPausable = _prefixId.prefix "isPausable"
    /// <summary>
    ///   <para>rdfs:label : is stoppable</para>
    ///   <para>rdfs:comment : Specifies if the power sequence is stoppable.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/isStoppable">s4ener:isStoppable</a>
    /// </summary>
    let isStoppable = _prefixId.prefix "isStoppable"
    /// <summary>
    ///   <para>rdfs:label : manufacturer description</para>
    ///   <para>rdfs:comment : A description for the device as defined by the manufacturer.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/manufacturerDescription">s4ener:manufacturerDescription</a>
    /// </summary>
    let manufacturerDescription = _prefixId.prefix "manufacturerDescription"
    /// <summary>
    ///   <para>rdfs:label : manufacturer label</para>
    ///   <para>rdfs:comment : A short label of the device as defined by the manufacturer. </para>
    ///   <a href="https://saref.etsi.org/saref4ener/manufacturerLabel">s4ener:manufacturerLabel</a>
    /// </summary>
    let manufacturerLabel = _prefixId.prefix "manufacturerLabel"

    /// <summary>
    ///   <para>rdfs:label : manufacturer node identification</para>
    ///   <para>rdfs:comment : Indicates a node identification for the device as defined by the manufacturer. This could be used for the identification of a device, even if it was removed from the network and rejoined later with changed node address.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/manufacturerNodeIdentification">s4ener:manufacturerNodeIdentification</a>
    /// </summary>
    let manufacturerNodeIdentification =
        _prefixId.prefix "manufacturerNodeIdentification"

    /// <summary>
    ///   <para>rdfs:label : max cycles per day</para>
    ///   <para>rdfs:comment : States the maximum amount of starts a power sequence (of a device) allows per day.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/maxCyclesPerDay">s4ener:maxCyclesPerDay</a>
    /// </summary>
    let maxCyclesPerDay = _prefixId.prefix "maxCyclesPerDay"
    /// <summary>
    ///   <para>rdfs:label : measurement id</para>
    ///   <para>rdfs:comment : Enables the identification of different sensors on one EEBus address.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/measurementID">s4ener:measurementID</a>
    /// </summary>
    let measurementID = _prefixId.prefix "measurementID"
    /// <summary>
    ///   <para>rdfs:label : messaging number</para>
    ///   <para>rdfs:comment : An identifier for one specific message. If a message is marked as obsolete, this number can be used to identify the original message.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/messagingNumber">s4ener:messagingNumber</a>
    /// </summary>
    let messagingNumber = _prefixId.prefix "messagingNumber"
    /// <summary>
    ///   <para>rdfs:label : messaging type</para>
    ///   <para>rdfs:comment : Indicates the type of the message. Possible values are:
    /// -	logging (used for messages, that shall be stored in a log file)
    /// -	information (messages, that shall be presented to the customer on a display; lower priority)
    /// -	warning (messages, that shall be presented to the customer on a display; medium priority)
    /// -	alarm (messages, that shall be presented to the customer on a display; high priority; if there is an alarm device in the household, it shall generate an alarm)
    /// -	emergency (messages, that shall be presented to the customer on a display; very high priority; if there is an alarm device in the household, it shall generate an alarm; additionally, if possible and configured, an emergency call shall be done)
    /// -	obsolete (previously sent messages, that shall be marked as obsolete)</para>
    ///   <a href="https://saref.etsi.org/saref4ener/messagingType">s4ener:messagingType</a>
    /// </summary>
    let messagingType = _prefixId.prefix "messagingType"
    /// <summary>
    ///   <para>rdfs:label : node remote controllable</para>
    ///   <para>rdfs:comment : Indicates whether the power profile of a device is configured for remote control (e.g., by an energy management system).This refers to the selection chosen by the user on the remote control feature of the device. If nodeRemoteControllable is equal to FALSE, all the supported power sequences shall set the sequenceRemoteControllable property to FALSE. If nodeRemoteControllable is equal to TRUE, at least one power sequence shall be remotely controllable by setting the sequenceRemoteControllable property to TRUE.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/nodeRemoteControllable">s4ener:nodeRemoteControllable</a>
    /// </summary>
    let nodeRemoteControllable = _prefixId.prefix "nodeRemoteControllable"
    /// <summary>
    ///   <para>rdfs:label : optional slot</para>
    ///   <para>rdfs:comment : Indicates whether a slot is optional (if set to TRUE). Otherwise, if a slot is mandatory, SHALL be omitted or set to FALSE. Note: This element applies to every repetition of the slot number.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/optionalSlot">s4ener:optionalSlot</a>
    /// </summary>
    let optionalSlot = _prefixId.prefix "optionalSlot"
    /// <summary>
    ///   <para>rdfs:label : power source</para>
    ///   <para>rdfs:comment : Indicates the power source of a device. Possible values are e.g. mainsSinglePhase or battery </para>
    ///   <a href="https://saref.etsi.org/saref4ener/powerSource">s4ener:powerSource</a>
    /// </summary>
    let powerSource = _prefixId.prefix "powerSource"
    /// <summary>
    ///   <para>rdfs:label : receives</para>
    ///   <para>rdfs:comment : A relationship between a device (e.g., an appliance or a smart meter) and a load control event</para>
    ///   <a href="https://saref.etsi.org/saref4ener/receives">s4ener:receives</a>
    /// </summary>
    let receives = _prefixId.prefix "receives"
    /// <summary>
    ///   <para>rdfs:label : repetition total</para>
    ///   <para>rdfs:comment : Contains the total number of repetitions, if a power sequence repeats its sequence of slots. Absence of the element is equal to a presence with a value of 0 (zero). SHALL be absent if the value is 1. </para>
    ///   <a href="https://saref.etsi.org/saref4ener/repetitionsTotal">s4ener:repetitionsTotal</a>
    /// </summary>
    let repetitionsTotal = _prefixId.prefix "repetitionsTotal"
    /// <summary>
    ///   <para>rdfs:label : sequence ID</para>
    ///   <para>rdfs:comment : Provides a unique power sequence identifier for a certain device</para>
    ///   <a href="https://saref.etsi.org/saref4ener/sequenceID">s4ener:sequenceID</a>
    /// </summary>
    let sequenceID = _prefixId.prefix "sequenceID"
    /// <summary>
    ///   <para>rdfs:label : sequence remote controllable</para>
    ///   <para>rdfs:comment : Denotes whether a power sequence is modifiable (if value is TRUE) or not (if value is FALSE). Modifiability is required to configure power sequences and slots. It is also required to change a power sequence state.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/sequenceRemoteControllable">s4ener:sequenceRemoteControllable</a>
    /// </summary>
    let sequenceRemoteControllable = _prefixId.prefix "sequenceRemoteControllable"
    /// <summary>
    ///   <para>rdfs:label : serial number</para>
    ///   <para>rdfs:comment : Indicates the serial number of a device as defined by the manufacturer. Usually the same as printed on the case.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/serialNumber">s4ener:serialNumber</a>
    /// </summary>
    let serialNumber = _prefixId.prefix "serialNumber"
    /// <summary>
    ///   <para>rdfs:label : slot activated</para>
    ///   <para>rdfs:comment : If a slot is optional, represents the current status of the slot (true = the slot will be executed, false = the slot will not be executed). If the slot is not optional, this element SHALL be absent.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/slotActivated">s4ener:slotActivated</a>
    /// </summary>
    let slotActivated = _prefixId.prefix "slotActivated"
    /// <summary>
    ///   <para>rdfs:label : slot number</para>
    ///   <para>rdfs:comment : Provides a unique slot identifier for a certain power sequence</para>
    ///   <a href="https://saref.etsi.org/saref4ener/slotNumber">s4ener:slotNumber</a>
    /// </summary>
    let slotNumber = _prefixId.prefix "slotNumber"
    /// <summary>
    ///   <para>rdfs:label : software revision</para>
    ///   <para>rdfs:comment : Indicates the software revision of a device as defined by the manufacturer.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/softwareRevision">s4ener:softwareRevision</a>
    /// </summary>
    let softwareRevision = _prefixId.prefix "softwareRevision"
    /// <summary>
    ///   <para>rdfs:label : supports reselection</para>
    ///   <para>rdfs:comment : If set toTRUE, the power profile of a device does not restrict the number of power sequence re-selections by the CEM, i.e. within a given alternative the CEM may first choose one power sequence, alter the selection by configuring another sequence later on, then alter the selection again, etc. (provided the process rules and data still permit configuration). If supportsReselection is set to FALSE, the device permits the CEM to select a power sequence of an alternative only once.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/supportsReselection">s4ener:supportsReselection</a>
    /// </summary>
    let supportsReselection = _prefixId.prefix "supportsReselection"

    /// <summary>
    ///   <para>rdfs:label : supports single slot scheduling only</para>
    ///   <para>rdfs:comment : If set toTRUE, the power profile of a device does NOT permit the modification of more than one slot per configuration command.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/supportsSingleSlotSchedulingOnly">s4ener:supportsSingleSlotSchedulingOnly</a>
    /// </summary>
    let supportsSingleSlotSchedulingOnly =
        _prefixId.prefix "supportsSingleSlotSchedulingOnly"

    /// <summary>
    ///   <para>rdfs:label : task identifier</para>
    ///   <para>rdfs:comment : Represents the task identifier of the power sequence.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/taskIdentifier">s4ener:taskIdentifier</a>
    /// </summary>
    let taskIdentifier = _prefixId.prefix "taskIdentifier"
    /// <summary>
    ///   <para>rdfs:label : total sequences count max</para>
    ///   <para>rdfs:comment : Represents the total number of power sequences supported by the power profile of a device</para>
    ///   <a href="https://saref.etsi.org/saref4ener/totalSequencesCountMax">s4ener:totalSequencesCountMax</a>
    /// </summary>
    let totalSequencesCountMax = _prefixId.prefix "totalSequencesCountMax"
    /// <summary>
    ///   <para>rdfs:label : triggers event action consume</para>
    ///   <para>rdfs:comment : A relationship between a load control event and the consume action triggered by this event</para>
    ///   <a href="https://saref.etsi.org/saref4ener/triggersEventActionConsume">s4ener:triggersEventActionConsume</a>
    /// </summary>
    let triggersEventActionConsume = _prefixId.prefix "triggersEventActionConsume"
    /// <summary>
    ///   <para>rdfs:label : triggers event action produce</para>
    ///   <para>rdfs:comment : A relationship between a load control event and the produce action triggered by this event</para>
    ///   <a href="https://saref.etsi.org/saref4ener/triggersEventActionProduce">s4ener:triggersEventActionProduce</a>
    /// </summary>
    let triggersEventActionProduce = _prefixId.prefix "triggersEventActionProduce"
    /// <summary>
    ///   <para>rdfs:label : value source</para>
    ///   <para>rdfs:comment : Indicates the source (origin/foundation) of the measurement forecasted values for a power sequence. If absent, the source is undefined. Remark: This element shall express the reliability of the forecast.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/valueSource">s4ener:valueSource</a>
    /// </summary>
    let valueSource = _prefixId.prefix "valueSource"
    /// <summary>
    ///   <para>rdfs:label : value tendency</para>
    ///   <para>rdfs:comment : Indicates whether the tendency of a measurement is rising, stable or falling.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/valueTendency">s4ener:valueTendency</a>
    /// </summary>
    let valueTendency = _prefixId.prefix "valueTendency"
    /// <summary>
    ///   <para>rdfs:label : vendor code</para>
    ///   <para>rdfs:comment : Provides a code for the vendor of the device as defined by the manufacturer.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/vendorCode">s4ener:vendorCode</a>
    /// </summary>
    let vendorCode = _prefixId.prefix "vendorCode"
    /// <summary>
    ///   <para>rdfs:label : vendor name</para>
    ///   <para>rdfs:comment : Provides the name of the vendor of the device as defined by the manufacturer.</para>
    ///   <a href="https://saref.etsi.org/saref4ener/vendorName">s4ener:vendorName</a>
    /// </summary>
    let vendorName = _prefixId.prefix "vendorName"
    /// <summary>
    ///   <para>rdfs:label : duration in xsd </para>
    ///   <para>rdfs:comment : This property is added to the  time:DurationDescription class to allow to express time duration also as xsd:duration. This is necessary because in the EEBus/E@h model time is always expressed as xsd:duration. We use this property to express the following time information in the EEBus/E@h model:
    ///
    /// - the startTime of the power sequence (in the PowerSequence class). SHALL be present
    /// - the endTime of the power sequence (in the PowerSequence class). If the value is available, it SHALL be denoted here. Otherwise the element SHALL be omitted.
    /// - the startTime of measurement as absolute or relative value (in the Measurement class).
    /// - the endTime of measurement as absolute or relative value (in the Measurement class).
    ///
    /// The duration is expected to be described as in xsd:duration</para>
    ///   <a href="https://saref.etsi.org/saref4ener/xsdDuration">s4ener:xsdDuration</a>
    /// </summary>
    let xsdDuration = _prefixId.prefix "xsdDuration"
