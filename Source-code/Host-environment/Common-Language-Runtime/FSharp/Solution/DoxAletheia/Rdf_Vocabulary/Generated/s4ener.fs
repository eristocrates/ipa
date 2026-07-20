namespace https.saref.etsi.org.saref4ener.slash

open DoxAletheia

module s4ener =
    let _namespace_name = "https://saref.etsi.org/saref4ener/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4ener/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = _prefix "v1.1.2/"
    /// <summary>
    /// The scheduled activation delay for a slot.
    /// <see href="https://saref.etsi.org/saref4ener/ActivationDelay"></see></summary>
    let ActivationDelay = _prefix "ActivationDelay"

    /// <summary>
    /// The duration description for the activation delay duration temporal entity
    /// <see href="https://saref.etsi.org/saref4ener/ActivationDelayDurationDescription"></see></summary>
    let ActivationDelayDurationDescription =
        _prefix "ActivationDelayDurationDescription"

    /// <summary>
    /// The duration description for the active duration (min and max, sum max and sum min) temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationDescription"></see></summary>
    let ActiveDurationDescription = _prefix "ActiveDurationDescription"
    /// <summary>
    /// The active maximum duration a power sequence can run without interruption.
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationMax"></see></summary>
    let ActiveDurationMax = _prefix "ActiveDurationMax"
    /// <summary>
    /// The active mininum duration a power sequence can run without interruption.
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationMin"></see></summary>
    let ActiveDurationMin = _prefix "ActiveDurationMin"
    /// <summary>
    /// The active maximum duration a power sequence can run in total (summation of all active times).
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationSumMax"></see></summary>
    let ActiveDurationSumMax = _prefix "ActiveDurationSumMax"
    /// <summary>
    /// The active minimum duration a power sequence must run in total (summation of all active times).
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationSumMin"></see></summary>
    let ActiveDurationSumMin = _prefix "ActiveDurationSumMin"
    /// <summary>
    /// Independent from the ActuatorSwitch class, the ActuatorLevel class enables a user or application to model LEVEL commands (start, up, percentageAbsolute, relative, etc.). This can be used to dim a light, set the speed of an electric motor, etc.
    /// <see href="https://saref.etsi.org/saref4ener/ActuatorLevel"></see></summary>
    let ActuatorLevel = _prefix "ActuatorLevel"
    /// <summary>
    /// Basic on/off operations on a simple actuator can be modelled with the ActuatorSwitch class. Whether the function turns a device itself ON or OFF, or whether it switches a specific feature, depends on the implementation. For example, one could model the super freeze program of a freezer using ActuatorSwitch class. An ON command would then activate the super freeze program and an OFF command would deactivate it. This example shall just give an idea how ActuatorSwitch can be used for more purposes than only turning devices on and off.
    /// <see href="https://saref.etsi.org/saref4ener/ActuatorSwitch"></see></summary>
    let ActuatorSwitch = _prefix "ActuatorSwitch"
    /// <summary>
    /// A collection of power sequences for a certain profile
    /// <see href="https://saref.etsi.org/saref4ener/AlternativesGroup"></see></summary>
    let AlternativesGroup = _prefix "AlternativesGroup"
    /// <summary>
    /// The endpoint-wide unique identifier for the alternatives group instances provided by a power profile
    /// <see href="https://saref.etsi.org/saref4ener/alternativesGroupID"></see></summary>
    let alternativesGroupID = _prefix "alternativesGroupID"
    /// <summary>
    /// A relationship identifying the ownership of an entity. In particular, a slot belongs to a power sequence, a power sequence belongs to an alternative, an alternative  belongs to a power profile, a power profile belongs to a device.
    /// <see href="https://saref.etsi.org/saref4ener/belongsTo"></see></summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    /// A way to model curves of power and energy over time, which also provides definitions for the modelling of power scheduling including alternative plans. With a PowerProfile, a device (or power sequences server) exposes the power sequences that are potentially relevant for the CEM (or power sequences client).
    /// <see href="https://saref.etsi.org/saref4ener/PowerProfile"></see></summary>
    let PowerProfile = _prefix "PowerProfile"
    /// <summary>
    /// The specification of a task, such as wash or tumble dry, according to user preferences and/or manufacturer's settings for a certain device.  It is the most 'coarse' view, a power sequence can represent all single steps of a whole task,where the single steps are represented by slots. If the power sequence is pausable by the bound power sequences client, the property 'saref:isInterruptionPossible' SHALL be present and set to true. Otherwise it SHALL be omitted. If the power sequence is stoppable by the bound power sequences client, the property 'saref:isFlexible' SHALL be present and set to true. Otherwise it SHALL be omitted.
    /// <see href="https://saref.etsi.org/saref4ener/PowerSequence"></see></summary>
    let PowerSequence = _prefix "PowerSequence"
    /// <summary>
    /// The duration description for the anticipation duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/AnticipationDurationDescription"></see></summary>
    let AnticipationDurationDescription = _prefix "AnticipationDurationDescription"
    /// <summary>
    /// Power sequence state with value 'completed'
    /// <see href="https://saref.etsi.org/saref4ener/Completed"></see></summary>
    let Completed = _prefix "Completed"
    /// <summary>
    /// The current state of the power sequence. It can assume one of the values 'running', 'paused', 'scheduled', 'scheduled paused', 'pending', 'inactive', 'completed',  or 'invalid'.
    /// <see href="https://saref.etsi.org/saref4ener/PowerSequenceState"></see></summary>
    let PowerSequenceState = _prefix "PowerSequenceState"
    /// <summary>
    /// The duration of a slot (SHALL be present in case of 'determined slot'). If a slot has a configurable lenght, this element SHALL reflect the currently configured lenght
    /// <see href="https://saref.etsi.org/saref4ener/DefaultDuration"></see></summary>
    let DefaultDuration = _prefix "DefaultDuration"
    /// <summary>
    /// The duration description for the default duration temporal entity
    /// <see href="https://saref.etsi.org/saref4ener/DefaultDurationDescription"></see></summary>
    let DefaultDurationDescription = _prefix "DefaultDurationDescription"
    /// <summary>
    /// A specialization of a saref:Device that exposes a power profile with power sequences to the CEM (note that a s4ee:Device can also be called 'power sequence server'). Most of the existing devices can expose at most 1 power profile, but there are special cases in which more than one power profiles can be exposed by the same device. For example, consider the case of a combined fridge-freezer in which there are 2 logical devices (fridge and freezer) combined in 1 physical device. This combined device can expose 2 power profiles, one for the fridge and one for the freezer. A s4ee:Device (e.g. a household appliance or a smart meter) can also receive events about overload warning severity level and related load control commands (LoadControlEventData)
    /// <see href="https://saref.etsi.org/saref4ener/Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// A relationship between a device and its power profile
    /// <see href="https://saref.etsi.org/saref4ener/exposes"></see></summary>
    let exposes = _prefix "exposes"
    /// <summary>
    /// Indicates the power source of a device. Possible values are e.g. mainsSinglePhase or battery
    /// <see href="https://saref.etsi.org/saref4ener/powerSource"></see></summary>
    let powerSource = _prefix "powerSource"
    /// <summary>
    /// Provides the name of the vendor of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/vendorName"></see></summary>
    let vendorName = _prefix "vendorName"
    /// <summary>
    /// Provides a code for the vendor of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/vendorCode"></see></summary>
    let vendorCode = _prefix "vendorCode"
    /// <summary>
    /// A relationship between a device (e.g., an appliance or a smart meter) and a load control event
    /// <see href="https://saref.etsi.org/saref4ener/receives"></see></summary>
    let receives = _prefix "receives"
    /// <summary>
    /// An event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/LoadControlEventData"></see></summary>
    let LoadControlEventData = _prefix "LoadControlEventData"
    /// <summary>
    /// Indicates the hardware revision of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/hardwareRevision"></see></summary>
    let hardwareRevision = _prefix "hardwareRevision"
    /// <summary>
    /// Provides the name of the brand of a device. Useful where the name of the brand and the vendor differs.
    /// <see href="https://saref.etsi.org/saref4ener/brandName"></see></summary>
    let brandName = _prefix "brandName"
    /// <summary>
    /// A description for the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/manufacturerDescription"></see></summary>
    let manufacturerDescription = _prefix "manufacturerDescription"
    /// <summary>
    /// Indicates the serial number of a device as defined by the manufacturer. Usually the same as printed on the case.
    /// <see href="https://saref.etsi.org/saref4ener/serialNumber"></see></summary>
    let serialNumber = _prefix "serialNumber"
    /// <summary>
    /// Indicates the software revision of a device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/softwareRevision"></see></summary>
    let softwareRevision = _prefix "softwareRevision"
    /// <summary>
    /// Provides a device code for the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/deviceCode"></see></summary>
    let deviceCode = _prefix "deviceCode"
    /// <summary>
    /// A short label of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/manufacturerLabel"></see></summary>
    let manufacturerLabel = _prefix "manufacturerLabel"
    /// <summary>
    /// Indicates a node identification for the device as defined by the manufacturer. This could be used for the identification of a device, even if it was removed from the network and rejoined later with changed node address.
    /// <see href="https://saref.etsi.org/saref4ener/manufacturerNodeIdentification"></see></summary>
    let manufacturerNodeIdentification = _prefix "manufacturerNodeIdentification"
    /// <summary>
    /// Provides the name of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/deviceName"></see></summary>
    let deviceName = _prefix "deviceName"
    /// <summary>
    /// The uncertainty of the duration
    /// <see href="https://saref.etsi.org/saref4ener/DurationUncertainty"></see></summary>
    let DurationUncertainty = _prefix "DurationUncertainty"
    /// <summary>
    /// The duration description for the duration uncertainty temporal entity
    /// <see href="https://saref.etsi.org/saref4ener/DurationUncertaintyDescription"></see></summary>
    let DurationUncertaintyDescription = _prefix "DurationUncertaintyDescription"
    /// <summary>
    /// The earliest possible start time for a power sequence or a slot. Only 'xs:duration' value types SHALL be used to denote a relative time which relates to 'now' as time 0.
    /// Note: This element applies to the first repetition of the slot number only.
    /// <see href="https://saref.etsi.org/saref4ener/EarliestStartTime"></see></summary>
    let EarliestStartTime = _prefix "EarliestStartTime"
    /// <summary>
    /// If state is set to 'running' or 'paused' AND the slot is determined, this element CAN contain the time the slot has already been in 'running' state (this also means the value remains constant during a 'paused' state). Otherwise it SHALL be omitted.
    /// <see href="https://saref.etsi.org/saref4ener/ElapsedSlotTime"></see></summary>
    let ElapsedSlotTime = _prefix "ElapsedSlotTime"
    /// <summary>
    /// Load control event action with value 'emergency'
    /// <see href="https://saref.etsi.org/saref4ener/Emergency"></see></summary>
    let Emergency = _prefix "Emergency"
    /// <summary>
    /// An action type used to express a produce action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/EventActionProduce"></see></summary>
    let EventActionProduce = _prefix "EventActionProduce"
    /// <summary>
    /// An action type used to express a consume action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/EventActionConsume"></see></summary>
    let EventActionConsume = _prefix "EventActionConsume"
    /// <summary>
    /// The endTime of a power sequence. If the value is available, it SHALL be denoted here. Otherwise the element SHALL be omitted.
    /// The end time of a slot MAY be stated in this element. The following equation SHALL apply: endTime - startTime = defaultDuration.
    /// <see href="https://saref.etsi.org/saref4ener/EndTime"></see></summary>
    let EndTime = _prefix "EndTime"
    /// <summary>
    /// The duration description for the end time duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/EndTimeDurationDescription"></see></summary>
    let EndTimeDurationDescription = _prefix "EndTimeDurationDescription"
    /// <summary>
    /// Energy type and value in a slot (i.e., Energy, EnergyMin, EnergyMax, EnergyExpected, EnergyStandardDeviation, EnergySkewness); or the ResumeEnergyEstimated in a power sequence, i.e., the additional energy the device will consume before resuming its normal operation (after a pause)
    /// <see href="https://saref.etsi.org/saref4ener/Energy"></see></summary>
    let Energy = _prefix "Energy"
    /// <summary>
    /// A possible type of energy in a slot that represents the expected energy consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergyExpected"></see></summary>
    let EnergyExpected = _prefix "EnergyExpected"
    /// <summary>
    /// A possible type of energy in a slot that represents the maximum energy consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergyMax"></see></summary>
    let EnergyMax = _prefix "EnergyMax"
    /// <summary>
    /// A possible type of energy in a slot that represents the minimum energy consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergyMin"></see></summary>
    let EnergyMin = _prefix "EnergyMin"
    /// <summary>
    /// A possible type of energy in a slot that represents the energy skewness and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergySkewness"></see></summary>
    let EnergySkewness = _prefix "EnergySkewness"
    /// <summary>
    /// A possible type of energy in a slot  that represents the energy standard deviation and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergyStandardDeviation"></see></summary>
    let EnergyStandardDeviation = _prefix "EnergyStandardDeviation"
    /// <summary>
    /// Load control state with value 'event accepted'
    /// <see href="https://saref.etsi.org/saref4ener/EventAccepted"></see></summary>
    let EventAccepted = _prefix "EventAccepted"
    /// <summary>
    /// In the load control, it expresses a produce state of an event an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/EventStateProduce"></see></summary>
    let EventStateProduce = _prefix "EventStateProduce"
    /// <summary>
    /// In the load control, it expresses a consume state of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/EventStateConsume"></see></summary>
    let EventStateConsume = _prefix "EventStateConsume"
    /// <summary>
    /// An action type used to express the action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/LoadControlEventAction"></see></summary>
    let LoadControlEventAction = _prefix "LoadControlEventAction"
    /// <summary>
    /// Load control event action with value 'pause'
    /// <see href="https://saref.etsi.org/saref4ener/Pause"></see></summary>
    let Pause = _prefix "Pause"
    /// <summary>
    /// Load control event action with value 'resume'
    /// <see href="https://saref.etsi.org/saref4ener/Resume"></see></summary>
    let Resume = _prefix "Resume"
    /// <summary>
    /// Load control event action with value 'reduce'
    /// <see href="https://saref.etsi.org/saref4ener/Reduce"></see></summary>
    let Reduce = _prefix "Reduce"
    /// <summary>
    /// Load control event action with value 'increase'
    /// <see href="https://saref.etsi.org/saref4ener/Increase"></see></summary>
    let Increase = _prefix "Increase"
    /// <summary>
    /// The value NORMAL used to instantiate the Load Control Event Action class and MeasurandState class
    /// <see href="https://saref.etsi.org/saref4ener/Normal"></see></summary>
    let Normal = _prefix "Normal"
    /// <summary>
    /// Load control state with value 'event cancelled'
    /// <see href="https://saref.etsi.org/saref4ener/EventCancelled"></see></summary>
    let EventCancelled = _prefix "EventCancelled"
    /// <summary>
    /// Load control state with value 'event error'
    /// <see href="https://saref.etsi.org/saref4ener/EventError"></see></summary>
    let EventError = _prefix "EventError"
    /// <summary>
    /// Load control state with value 'event rejected'
    /// <see href="https://saref.etsi.org/saref4ener/EventRejected"></see></summary>
    let EventRejected = _prefix "EventRejected"
    /// <summary>
    /// Load control state with value 'event started'
    /// <see href="https://saref.etsi.org/saref4ener/EventStarted"></see></summary>
    let EventStarted = _prefix "EventStarted"
    /// <summary>
    /// In the load control, it expresses the possible states of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/LoadControlEventState"></see></summary>
    let LoadControlEventState = _prefix "LoadControlEventState"
    /// <summary>
    /// Load control state with value 'event stopped'
    /// <see href="https://saref.etsi.org/saref4ener/EventStopped"></see></summary>
    let EventStopped = _prefix "EventStopped"
    /// <summary>
    /// Power sequence state with value 'inactive'
    /// <see href="https://saref.etsi.org/saref4ener/Inactive"></see></summary>
    let Inactive = _prefix "Inactive"
    /// <summary>
    /// Power sequence state with value 'invalid'
    /// <see href="https://saref.etsi.org/saref4ener/Invalid"></see></summary>
    let Invalid = _prefix "Invalid"
    /// <summary>
    /// The latest possible end time for a power sequence or a slot. Only 'xs:duration' value types SHALL be used to denote a relative time which relates to 'now' as time 0.
    /// Note: This element applies to the first repetition of the slot number only.
    /// <see href="https://saref.etsi.org/saref4ener/LatestEndTime"></see></summary>
    let LatestEndTime = _prefix "LatestEndTime"
    /// <summary>
    /// A relationship between a load control event (used to send overload warning severity level and related load control commands) and the device interested by this event.
    /// <see href="https://saref.etsi.org/saref4ener/hasDevice"></see></summary>
    let hasDevice = _prefix "hasDevice"
    /// <summary>
    /// A relationship between a load control event and the consume action triggered by this event
    /// <see href="https://saref.etsi.org/saref4ener/triggersEventActionConsume"></see></summary>
    let triggersEventActionConsume = _prefix "triggersEventActionConsume"
    /// <summary>
    /// A relationship between a load control event and the produce action triggered by this event
    /// <see href="https://saref.etsi.org/saref4ener/triggersEventActionProduce"></see></summary>
    let triggersEventActionProduce = _prefix "triggersEventActionProduce"
    /// <summary>
    /// Used in the Demand Response use case to identify an event
    /// <see href="https://saref.etsi.org/saref4ener/eventID"></see></summary>
    let eventID = _prefix "eventID"
    /// <summary>
    /// The time period associated with load control event data
    /// <see href="https://saref.etsi.org/saref4ener/TimePeriod"></see></summary>
    let TimePeriod = _prefix "TimePeriod"
    /// <summary>
    /// An entity that represents the possible states in SAREF4EE
    /// <see href="https://saref.etsi.org/saref4ener/State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// The representation of the state of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/LoadControlStateData"></see></summary>
    let LoadControlStateData = _prefix "LoadControlStateData"
    /// <summary>
    /// A relationship between the specification of the state of a load control event consume and the value that this state can assume.
    /// <see href="https://saref.etsi.org/saref4ener/hasEventStateConsume"></see></summary>
    let hasEventStateConsume = _prefix "hasEventStateConsume"
    /// <summary>
    /// A relationship between the specification of the state of a load control event produce and the value that this state can assume.
    /// <see href="https://saref.etsi.org/saref4ener/hasEventStateProduce"></see></summary>
    let hasEventStateProduce = _prefix "hasEventStateProduce"
    /// <summary>
    /// A relationship between the state of a load control event consume and the action to be performed as a consequence of this event.
    /// <see href="https://saref.etsi.org/saref4ener/hasAppliedEventActionConsume"></see></summary>
    let hasAppliedEventActionConsume = _prefix "hasAppliedEventActionConsume"
    /// <summary>
    /// A relationship between the state of a load control event produce and the action to be performed as a consequence of this event.
    /// <see href="https://saref.etsi.org/saref4ener/hasAppliedEventActionProduce"></see></summary>
    let hasAppliedEventActionProduce = _prefix "hasAppliedEventActionProduce"
    /// <summary>
    /// Maximum delay time between the end of the previous slot and the beginning of the current slot.
    /// <see href="https://saref.etsi.org/saref4ener/MaxActivationDelay"></see></summary>
    let MaxActivationDelay = _prefix "MaxActivationDelay"
    /// <summary>
    /// This field allows the anticipation of the phase if (and only if) the previous phase has the energy set to 0 Wh, each unit is a minute.
    /// <see href="https://saref.etsi.org/saref4ener/MaxAnticipation"></see></summary>
    let MaxAnticipation = _prefix "MaxAnticipation"
    /// <summary>
    /// If a slot has a configurable duration, it SHALL be present and denote the maximum supported configuration. Note: This element applies to the first repetition of the slot number only
    /// <see href="https://saref.etsi.org/saref4ener/MaxDuration"></see></summary>
    let MaxDuration = _prefix "MaxDuration"
    /// <summary>
    /// If a slot has a configurable duration, it SHALL be present and denote the minimum supported configuration. Note: This element applies to the first repetition of the slot number only.
    /// <see href="https://saref.etsi.org/saref4ener/MinDuration"></see></summary>
    let MinDuration = _prefix "MinDuration"
    /// <summary>
    /// The duration description for the pause duration (max and min) temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/PauseDurationDescription"></see></summary>
    let PauseDurationDescription = _prefix "PauseDurationDescription"
    /// <summary>
    /// The maximum duration a power sequence can pause after the end of an activity.
    /// <see href="https://saref.etsi.org/saref4ener/PauseDurationMax"></see></summary>
    let PauseDurationMax = _prefix "PauseDurationMax"
    /// <summary>
    /// The minimum duration a power sequence can pause after the end of an activity.
    /// <see href="https://saref.etsi.org/saref4ener/PauseDurationMin"></see></summary>
    let PauseDurationMin = _prefix "PauseDurationMin"
    /// <summary>
    /// The pause time of a power sequence or a slot
    /// <see href="https://saref.etsi.org/saref4ener/PauseTime"></see></summary>
    let PauseTime = _prefix "PauseTime"
    /// <summary>
    /// Power sequence state or sensor state with value 'paused'
    /// <see href="https://saref.etsi.org/saref4ener/Paused"></see></summary>
    let Paused = _prefix "Paused"
    /// <summary>
    /// Power sequence state with value 'pending'
    /// <see href="https://saref.etsi.org/saref4ener/Pending"></see></summary>
    let Pending = _prefix "Pending"
    /// <summary>
    /// Power type and value in a slot (i.e. power, powerMin, powerMax, powerExpectedValue, powerStandardDeviation, powerSkewness)
    /// <see href="https://saref.etsi.org/saref4ener/Power"></see></summary>
    let Power = _prefix "Power"
    /// <summary>
    /// A possible type of power in a slot that represents the expected power consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerExpected"></see></summary>
    let PowerExpected = _prefix "PowerExpected"
    /// <summary>
    /// A possible type of power in a slot that represents the maximum power consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerMax"></see></summary>
    let PowerMax = _prefix "PowerMax"
    /// <summary>
    /// A possible type of power in a slot that represents the minimum power consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerMin"></see></summary>
    let PowerMin = _prefix "PowerMin"
    /// <summary>
    /// If set toTRUE, the power profile of a device does NOT permit the modification of more than one slot per configuration command.
    /// <see href="https://saref.etsi.org/saref4ener/supportsSingleSlotSchedulingOnly"></see></summary>
    let supportsSingleSlotSchedulingOnly = _prefix "supportsSingleSlotSchedulingOnly"
    /// <summary>
    /// Indicates the number of alternatives groups provided by a power profile
    /// <see href="https://saref.etsi.org/saref4ener/alternativesCount"></see></summary>
    let alternativesCount = _prefix "alternativesCount"
    /// <summary>
    /// Indicates whether the power profile of a device is configured for remote control (e.g., by an energy management system).This refers to the selection chosen by the user on the remote control feature of the device. If nodeRemoteControllable is equal to FALSE, all the supported power sequences shall set the sequenceRemoteControllable property to FALSE. If nodeRemoteControllable is equal to TRUE, at least one power sequence shall be remotely controllable by setting the sequenceRemoteControllable property to TRUE.
    /// <see href="https://saref.etsi.org/saref4ener/nodeRemoteControllable"></see></summary>
    let nodeRemoteControllable = _prefix "nodeRemoteControllable"
    /// <summary>
    /// If set toTRUE, the power profile of a device does not restrict the number of power sequence re-selections by the CEM, i.e. within a given alternative the CEM may first choose one power sequence, alter the selection by configuring another sequence later on, then alter the selection again, etc. (provided the process rules and data still permit configuration). If supportsReselection is set to FALSE, the device permits the CEM to select a power sequence of an alternative only once.
    /// <see href="https://saref.etsi.org/saref4ener/supportsReselection"></see></summary>
    let supportsReselection = _prefix "supportsReselection"
    /// <summary>
    /// Represents the total number of power sequences supported by the power profile of a device
    /// <see href="https://saref.etsi.org/saref4ener/totalSequencesCountMax"></see></summary>
    let totalSequencesCountMax = _prefix "totalSequencesCountMax"
    /// <summary>
    /// Specifies if the power sequence is stoppable.
    /// <see href="https://saref.etsi.org/saref4ener/isStoppable"></see></summary>
    let isStoppable = _prefix "isStoppable"
    /// <summary>
    /// Contains the total number of repetitions, if a power sequence repeats its sequence of slots. Absence of the element is equal to a presence with a value of 0 (zero). SHALL be absent if the value is 1.
    /// <see href="https://saref.etsi.org/saref4ener/repetitionsTotal"></see></summary>
    let repetitionsTotal = _prefix "repetitionsTotal"
    /// <summary>
    /// Represents the task identifier of the power sequence.
    /// <see href="https://saref.etsi.org/saref4ener/taskIdentifier"></see></summary>
    let taskIdentifier = _prefix "taskIdentifier"
    /// <summary>
    /// Indicates the current repetition of the sequence of slots. SHALL be present if a power sequence can repeat its sequence of slots (i.e., if s4ee:repetitionTotal is present and has a value &gt; 1). Otherwise, it SHALL be absent.
    /// <see href="https://saref.etsi.org/saref4ener/activeRepetitionNumber"></see></summary>
    let activeRepetitionNumber = _prefix "activeRepetitionNumber"
    /// <summary>
    /// A relationship between a power sequence and its energy (in terms of value and unit of measure)
    /// <see href="https://saref.etsi.org/saref4ener/hasEnergy"></see></summary>
    let hasEnergy = _prefix "hasEnergy"
    /// <summary>
    /// In a power sequence, the additional energy the device will consume before resuming its normal operation (after a pause). This is only an estimated value which will not be added to the value stated in any slot value information.
    /// <see href="https://saref.etsi.org/saref4ener/ResumeEnergyEstimated"></see></summary>
    let ResumeEnergyEstimated = _prefix "ResumeEnergyEstimated"
    /// <summary>
    /// Provides a unique power sequence identifier for a certain device
    /// <see href="https://saref.etsi.org/saref4ener/sequenceID"></see></summary>
    let sequenceID = _prefix "sequenceID"
    /// <summary>
    /// In a power sequence the additional costs for the resumption of a device to its normal operation (after a pause).
    /// <see href="https://saref.etsi.org/saref4ener/ResumeCostEstimated"></see></summary>
    let ResumeCostEstimated = _prefix "ResumeCostEstimated"
    /// <summary>
    /// Indicates the currently active slot number, if the power sequence state is set to 'running' or 'paused'. Otherwise it SHALL be omitted.
    /// <see href="https://saref.etsi.org/saref4ener/activeSlotNumber"></see></summary>
    let activeSlotNumber = _prefix "activeSlotNumber"
    /// <summary>
    /// Specifies if the power sequence is pausable.
    /// <see href="https://saref.etsi.org/saref4ener/isPausable"></see></summary>
    let isPausable = _prefix "isPausable"
    /// <summary>
    /// The single steps of a power sequence are represented by slots. A slot is associated with a slot number (while a power sequence is associated with a power sequence identifier). The slot numbers of two power sequences should be considered independent from each other, i.e., slot number 7 of sequence 1 describes a different slot than slot number 7 of sequence 2. Therefore a slot is only uniquely identified in combination with a sequence ID.
    /// <see href="https://saref.etsi.org/saref4ener/Slot"></see></summary>
    let Slot = _prefix "Slot"
    /// <summary>
    /// Indicates whether a power sequence applies a configuration that minimises the user’s energy bill (if set to TRUE). MAY be present. Absence of this element is equal to the presence with value FALSE.
    /// <see href="https://saref.etsi.org/saref4ener/cheapest"></see></summary>
    let cheapest = _prefix "cheapest"
    /// <summary>
    /// If state is set to 'running' or 'paused' AND the slot is determined, this element SHALL contain the time the slot still needs to be in 'running' state (this also means the value remains constant during a 'paused' state). Otherwise it SHALL be omitted.
    /// <see href="https://saref.etsi.org/saref4ener/RemainingSlotTime"></see></summary>
    let RemainingSlotTime = _prefix "RemainingSlotTime"
    /// <summary>
    /// States the maximum amount of starts a power sequence (of a device) allows per day.
    /// <see href="https://saref.etsi.org/saref4ener/maxCyclesPerDay"></see></summary>
    let maxCyclesPerDay = _prefix "maxCyclesPerDay"
    /// <summary>
    /// The startTime of a power sequence or slot. SHALL be present
    /// <see href="https://saref.etsi.org/saref4ener/StartTime"></see></summary>
    let StartTime = _prefix "StartTime"
    /// <summary>
    /// Indicates the source (origin/foundation) of the measurement forecasted values for a power sequence. If absent, the source is undefined. Remark: This element shall express the reliability of the forecast.
    /// <see href="https://saref.etsi.org/saref4ener/valueSource"></see></summary>
    let valueSource = _prefix "valueSource"
    /// <summary>
    /// Indicates whether a power sequence optimises the configuration towards the maximum availability of renewable energy (if set to TRUE). MAY be present. Absence of this element is equal to the presence with value FALSE.
    /// <see href="https://saref.etsi.org/saref4ener/greenest"></see></summary>
    let greenest = _prefix "greenest"
    /// <summary>
    /// Denotes whether a power sequence is modifiable (if value is TRUE) or not (if value is FALSE). Modifiability is required to configure power sequences and slots. It is also required to change a power sequence state.
    /// <see href="https://saref.etsi.org/saref4ener/sequenceRemoteControllable"></see></summary>
    let sequenceRemoteControllable = _prefix "sequenceRemoteControllable"
    /// <summary>
    /// Power sequence state with value 'running'
    /// <see href="https://saref.etsi.org/saref4ener/Running"></see></summary>
    let Running = _prefix "Running"
    /// <summary>
    /// Power sequence state with value 'scheduled'
    /// <see href="https://saref.etsi.org/saref4ener/Scheduled"></see></summary>
    let Scheduled = _prefix "Scheduled"
    /// <summary>
    /// Power sequence state with value 'scheduled paused'
    /// <see href="https://saref.etsi.org/saref4ener/ScheduledPaused"></see></summary>
    let ScheduledPaused = _prefix "ScheduledPaused"
    /// <summary>
    /// A possible type of power in a slot that represents the power skewness and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerSkewness"></see></summary>
    let PowerSkewness = _prefix "PowerSkewness"
    /// <summary>
    /// A possible type of power in a slot that represents the power standard deviation and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerStandardDeviation"></see></summary>
    let PowerStandardDeviation = _prefix "PowerStandardDeviation"
    /// <summary>
    /// The duration that the current slot (s4ee:activeSlotNumber) permits being paused. This element SHALL ONLY be present if the power sequence is interruptible. Otherwise, it SHALL be omitted. In case the power sequence is interruptible the following rules apply: If the element is absent this means there is no explicit pause duration restriction for the current slot; a value of 0s denoted the slot does not permit being paused.
    /// <see href="https://saref.etsi.org/saref4ener/RemainingPauseTime"></see></summary>
    let RemainingPauseTime = _prefix "RemainingPauseTime"
    /// <summary>
    /// Indicates whether a slot is optional (if set to TRUE). Otherwise, if a slot is mandatory, SHALL be omitted or set to FALSE. Note: This element applies to every repetition of the slot number.
    /// <see href="https://saref.etsi.org/saref4ener/optionalSlot"></see></summary>
    let optionalSlot = _prefix "optionalSlot"
    /// <summary>
    /// Provides a unique slot identifier for a certain power sequence
    /// <see href="https://saref.etsi.org/saref4ener/slotNumber"></see></summary>
    let slotNumber = _prefix "slotNumber"
    /// <summary>
    /// If a slot is optional, represents the current status of the slot (true = the slot will be executed, false = the slot will not be executed). If the slot is not optional, this element SHALL be absent.
    /// <see href="https://saref.etsi.org/saref4ener/slotActivated"></see></summary>
    let slotActivated = _prefix "slotActivated"
    /// <summary>
    /// A relationship representing a power value type
    /// <see href="https://saref.etsi.org/saref4ener/hasPowerValueType"></see></summary>
    let hasPowerValueType = _prefix "hasPowerValueType"
    /// <summary>
    /// A relation representing the value type of an entity
    /// <see href="https://saref.etsi.org/saref4ener/hasValueType"></see></summary>
    let hasValueType = _prefix "hasValueType"
    /// <summary>
    /// A relationship representing an energy value type
    /// <see href="https://saref.etsi.org/saref4ener/hasEnergyValueType"></see></summary>
    let hasEnergyValueType = _prefix "hasEnergyValueType"
    /// <summary>
    /// The duration description for the slot time duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/SlotTimeDurationDescription"></see></summary>
    let SlotTimeDurationDescription = _prefix "SlotTimeDurationDescription"
    /// <summary>
    /// The duration description for the start time duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/StartTimeDurationDescription"></see></summary>
    let StartTimeDurationDescription = _prefix "StartTimeDurationDescription"
    /// <summary>
    /// The duration description for the time period duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/TimePeriodDurationDescription"></see></summary>
    let TimePeriodDurationDescription = _prefix "TimePeriodDurationDescription"
    /// <summary>
    /// Indicates whether a slot is used (activateSlot = true) or not (activateSlot = false). SHALL be present if a slot is optional (i.e., the property s4ee:optionalSlot is TRUE), otherwise SHALL be absent (i.e. in case the slot is mandatory).
    /// <see href="https://saref.etsi.org/saref4ener/activateSlot"></see></summary>
    let activateSlot = _prefix "activateSlot"
    /// <summary>
    /// In the Remote Network Management (RemoteNWM) use case, a relationship between a node in a network (i.e., a s4ee:Device) and its connections (i.e., a s4ee:DeviceConnections). The same s4ee:Device (or node) can have multiple device connections as it can be connected to several networks at the same time.
    /// <see href="https://saref.etsi.org/saref4ener/hasConnection"></see></summary>
    let hasConnection = _prefix "hasConnection"
    /// <summary>
    /// A relationship between an appliance parameter compatibility action and the associated expressions
    /// <see href="https://saref.etsi.org/saref4ener/hasExpression"></see></summary>
    let hasExpression = _prefix "hasExpression"
    /// <summary>
    /// A relationship identifying the functions performed by an actuator level and an actuator switch
    /// <see href="https://saref.etsi.org/saref4ener/hasFunction"></see></summary>
    let hasFunction = _prefix "hasFunction"
    /// <summary>
    /// Enables the identification of different sensors on one EEBus address.
    /// <see href="https://saref.etsi.org/saref4ener/measurementID"></see></summary>
    let measurementID = _prefix "measurementID"
    /// <summary>
    /// An identifier for one specific message. If a message is marked as obsolete, this number can be used to identify the original message.
    /// <see href="https://saref.etsi.org/saref4ener/messagingNumber"></see></summary>
    let messagingNumber = _prefix "messagingNumber"
    /// <summary>
    /// Indicates the type of the message. Possible values are:
    /// -	logging (used for messages, that shall be stored in a log file)
    /// -	information (messages, that shall be presented to the customer on a display; lower priority)
    /// -	warning (messages, that shall be presented to the customer on a display; medium priority)
    /// -	alarm (messages, that shall be presented to the customer on a display; high priority; if there is an alarm device in the household, it shall generate an alarm)
    /// -	emergency (messages, that shall be presented to the customer on a display; very high priority; if there is an alarm device in the household, it shall generate an alarm; additionally, if possible and configured, an emergency call shall be done)
    /// -	obsolete (previously sent messages, that shall be marked as obsolete)
    /// <see href="https://saref.etsi.org/saref4ener/messagingType"></see></summary>
    let messagingType = _prefix "messagingType"
    /// <summary>
    /// Indicates whether the tendency of a measurement is rising, stable or falling.
    /// <see href="https://saref.etsi.org/saref4ener/valueTendency"></see></summary>
    let valueTendency = _prefix "valueTendency"
    /// <summary>
    /// This property is added to the  time:DurationDescription class to allow to express time duration also as xsd:duration. This is necessary because in the EEBus/E@h model time is always expressed as xsd:duration. We use this property to express the following time information in the EEBus/E@h model:
    ///
    /// - the startTime of the power sequence (in the PowerSequence class). SHALL be present
    /// - the endTime of the power sequence (in the PowerSequence class). If the value is available, it SHALL be denoted here. Otherwise the element SHALL be omitted.
    /// - the startTime of measurement as absolute or relative value (in the Measurement class).
    /// - the endTime of measurement as absolute or relative value (in the Measurement class).
    ///
    /// The duration is expected to be described as in xsd:duration
    /// <see href="https://saref.etsi.org/saref4ener/xsdDuration"></see></summary>
    let xsdDuration = _prefix "xsdDuration"
