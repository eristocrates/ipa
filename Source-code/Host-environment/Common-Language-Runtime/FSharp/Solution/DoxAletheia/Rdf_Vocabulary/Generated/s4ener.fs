namespace https.saref.etsi.org.saref4ener.slash

open DoxAletheia.Rdf_Vocabulary

module s4ener =
    let _namespace_name = "https://saref.etsi.org/saref4ener/"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4ener/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = Namespaced_IRI.parse _namespace_name "v1.1.2/" |> NamespacedName

    /// <summary>
    /// The scheduled activation delay for a slot.
    /// <see href="https://saref.etsi.org/saref4ener/ActivationDelay"></see></summary>
    let ActivationDelay =
        Namespaced_IRI.parse _namespace_name "ActivationDelay" |> NamespacedName

    /// <summary>
    /// The duration description for the activation delay duration temporal entity
    /// <see href="https://saref.etsi.org/saref4ener/ActivationDelayDurationDescription"></see></summary>
    let ActivationDelayDurationDescription =
        Namespaced_IRI.parse _namespace_name "ActivationDelayDurationDescription" |> NamespacedName

    /// <summary>
    /// The duration description for the active duration (min and max, sum max and sum min) temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationDescription"></see></summary>
    let ActiveDurationDescription =
        Namespaced_IRI.parse _namespace_name "ActiveDurationDescription" |> NamespacedName

    /// <summary>
    /// The active maximum duration a power sequence can run without interruption.
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationMax"></see></summary>
    let ActiveDurationMax =
        Namespaced_IRI.parse _namespace_name "ActiveDurationMax" |> NamespacedName

    /// <summary>
    /// The active mininum duration a power sequence can run without interruption.
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationMin"></see></summary>
    let ActiveDurationMin =
        Namespaced_IRI.parse _namespace_name "ActiveDurationMin" |> NamespacedName

    /// <summary>
    /// The active maximum duration a power sequence can run in total (summation of all active times).
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationSumMax"></see></summary>
    let ActiveDurationSumMax =
        Namespaced_IRI.parse _namespace_name "ActiveDurationSumMax" |> NamespacedName

    /// <summary>
    /// The active minimum duration a power sequence must run in total (summation of all active times).
    /// <see href="https://saref.etsi.org/saref4ener/ActiveDurationSumMin"></see></summary>
    let ActiveDurationSumMin =
        Namespaced_IRI.parse _namespace_name "ActiveDurationSumMin" |> NamespacedName

    /// <summary>
    /// Independent from the ActuatorSwitch class, the ActuatorLevel class enables a user or application to model LEVEL commands (start, up, percentageAbsolute, relative, etc.). This can be used to dim a light, set the speed of an electric motor, etc.
    /// <see href="https://saref.etsi.org/saref4ener/ActuatorLevel"></see></summary>
    let ActuatorLevel =
        Namespaced_IRI.parse _namespace_name "ActuatorLevel" |> NamespacedName

    /// <summary>
    /// Basic on/off operations on a simple actuator can be modelled with the ActuatorSwitch class. Whether the function turns a device itself ON or OFF, or whether it switches a specific feature, depends on the implementation. For example, one could model the super freeze program of a freezer using ActuatorSwitch class. An ON command would then activate the super freeze program and an OFF command would deactivate it. This example shall just give an idea how ActuatorSwitch can be used for more purposes than only turning devices on and off.
    /// <see href="https://saref.etsi.org/saref4ener/ActuatorSwitch"></see></summary>
    let ActuatorSwitch =
        Namespaced_IRI.parse _namespace_name "ActuatorSwitch" |> NamespacedName

    /// <summary>
    /// A collection of power sequences for a certain profile
    /// <see href="https://saref.etsi.org/saref4ener/AlternativesGroup"></see></summary>
    let AlternativesGroup =
        Namespaced_IRI.parse _namespace_name "AlternativesGroup" |> NamespacedName

    /// <summary>
    /// The endpoint-wide unique identifier for the alternatives group instances provided by a power profile
    /// <see href="https://saref.etsi.org/saref4ener/alternativesGroupID"></see></summary>
    let alternativesGroupID =
        Namespaced_IRI.parse _namespace_name "alternativesGroupID" |> NamespacedName

    /// <summary>
    /// A relationship identifying the ownership of an entity. In particular, a slot belongs to a power sequence, a power sequence belongs to an alternative, an alternative  belongs to a power profile, a power profile belongs to a device.
    /// <see href="https://saref.etsi.org/saref4ener/belongsTo"></see></summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName

    /// <summary>
    /// A way to model curves of power and energy over time, which also provides definitions for the modelling of power scheduling including alternative plans. With a PowerProfile, a device (or power sequences server) exposes the power sequences that are potentially relevant for the CEM (or power sequences client).
    /// <see href="https://saref.etsi.org/saref4ener/PowerProfile"></see></summary>
    let PowerProfile =
        Namespaced_IRI.parse _namespace_name "PowerProfile" |> NamespacedName

    /// <summary>
    /// The specification of a task, such as wash or tumble dry, according to user preferences and/or manufacturer's settings for a certain device.  It is the most 'coarse' view, a power sequence can represent all single steps of a whole task,where the single steps are represented by slots. If the power sequence is pausable by the bound power sequences client, the property 'saref:isInterruptionPossible' SHALL be present and set to true. Otherwise it SHALL be omitted. If the power sequence is stoppable by the bound power sequences client, the property 'saref:isFlexible' SHALL be present and set to true. Otherwise it SHALL be omitted.
    /// <see href="https://saref.etsi.org/saref4ener/PowerSequence"></see></summary>
    let PowerSequence =
        Namespaced_IRI.parse _namespace_name "PowerSequence" |> NamespacedName

    /// <summary>
    /// The duration description for the anticipation duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/AnticipationDurationDescription"></see></summary>
    let AnticipationDurationDescription =
        Namespaced_IRI.parse _namespace_name "AnticipationDurationDescription" |> NamespacedName

    /// <summary>
    /// Power sequence state with value 'completed'
    /// <see href="https://saref.etsi.org/saref4ener/Completed"></see></summary>
    let Completed = Namespaced_IRI.parse _namespace_name "Completed" |> NamespacedName

    /// <summary>
    /// The current state of the power sequence. It can assume one of the values 'running', 'paused', 'scheduled', 'scheduled paused', 'pending', 'inactive', 'completed',  or 'invalid'.
    /// <see href="https://saref.etsi.org/saref4ener/PowerSequenceState"></see></summary>
    let PowerSequenceState =
        Namespaced_IRI.parse _namespace_name "PowerSequenceState" |> NamespacedName

    /// <summary>
    /// The duration of a slot (SHALL be present in case of 'determined slot'). If a slot has a configurable lenght, this element SHALL reflect the currently configured lenght
    /// <see href="https://saref.etsi.org/saref4ener/DefaultDuration"></see></summary>
    let DefaultDuration =
        Namespaced_IRI.parse _namespace_name "DefaultDuration" |> NamespacedName

    /// <summary>
    /// The duration description for the default duration temporal entity
    /// <see href="https://saref.etsi.org/saref4ener/DefaultDurationDescription"></see></summary>
    let DefaultDurationDescription =
        Namespaced_IRI.parse _namespace_name "DefaultDurationDescription" |> NamespacedName

    /// <summary>
    /// A specialization of a saref:Device that exposes a power profile with power sequences to the CEM (note that a s4ee:Device can also be called 'power sequence server'). Most of the existing devices can expose at most 1 power profile, but there are special cases in which more than one power profiles can be exposed by the same device. For example, consider the case of a combined fridge-freezer in which there are 2 logical devices (fridge and freezer) combined in 1 physical device. This combined device can expose 2 power profiles, one for the fridge and one for the freezer. A s4ee:Device (e.g. a household appliance or a smart meter) can also receive events about overload warning severity level and related load control commands (LoadControlEventData)
    /// <see href="https://saref.etsi.org/saref4ener/Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    /// A relationship between a device and its power profile
    /// <see href="https://saref.etsi.org/saref4ener/exposes"></see></summary>
    let exposes = Namespaced_IRI.parse _namespace_name "exposes" |> NamespacedName

    /// <summary>
    /// Indicates the power source of a device. Possible values are e.g. mainsSinglePhase or battery
    /// <see href="https://saref.etsi.org/saref4ener/powerSource"></see></summary>
    let powerSource =
        Namespaced_IRI.parse _namespace_name "powerSource" |> NamespacedName

    /// <summary>
    /// Provides the name of the vendor of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/vendorName"></see></summary>
    let vendorName = Namespaced_IRI.parse _namespace_name "vendorName" |> NamespacedName
    /// <summary>
    /// Provides a code for the vendor of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/vendorCode"></see></summary>
    let vendorCode = Namespaced_IRI.parse _namespace_name "vendorCode" |> NamespacedName
    /// <summary>
    /// A relationship between a device (e.g., an appliance or a smart meter) and a load control event
    /// <see href="https://saref.etsi.org/saref4ener/receives"></see></summary>
    let receives = Namespaced_IRI.parse _namespace_name "receives" |> NamespacedName

    /// <summary>
    /// An event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/LoadControlEventData"></see></summary>
    let LoadControlEventData =
        Namespaced_IRI.parse _namespace_name "LoadControlEventData" |> NamespacedName

    /// <summary>
    /// Indicates the hardware revision of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/hardwareRevision"></see></summary>
    let hardwareRevision =
        Namespaced_IRI.parse _namespace_name "hardwareRevision" |> NamespacedName

    /// <summary>
    /// Provides the name of the brand of a device. Useful where the name of the brand and the vendor differs.
    /// <see href="https://saref.etsi.org/saref4ener/brandName"></see></summary>
    let brandName = Namespaced_IRI.parse _namespace_name "brandName" |> NamespacedName

    /// <summary>
    /// A description for the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/manufacturerDescription"></see></summary>
    let manufacturerDescription =
        Namespaced_IRI.parse _namespace_name "manufacturerDescription" |> NamespacedName

    /// <summary>
    /// Indicates the serial number of a device as defined by the manufacturer. Usually the same as printed on the case.
    /// <see href="https://saref.etsi.org/saref4ener/serialNumber"></see></summary>
    let serialNumber =
        Namespaced_IRI.parse _namespace_name "serialNumber" |> NamespacedName

    /// <summary>
    /// Indicates the software revision of a device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/softwareRevision"></see></summary>
    let softwareRevision =
        Namespaced_IRI.parse _namespace_name "softwareRevision" |> NamespacedName

    /// <summary>
    /// Provides a device code for the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/deviceCode"></see></summary>
    let deviceCode = Namespaced_IRI.parse _namespace_name "deviceCode" |> NamespacedName

    /// <summary>
    /// A short label of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/manufacturerLabel"></see></summary>
    let manufacturerLabel =
        Namespaced_IRI.parse _namespace_name "manufacturerLabel" |> NamespacedName

    /// <summary>
    /// Indicates a node identification for the device as defined by the manufacturer. This could be used for the identification of a device, even if it was removed from the network and rejoined later with changed node address.
    /// <see href="https://saref.etsi.org/saref4ener/manufacturerNodeIdentification"></see></summary>
    let manufacturerNodeIdentification =
        Namespaced_IRI.parse _namespace_name "manufacturerNodeIdentification" |> NamespacedName

    /// <summary>
    /// Provides the name of the device as defined by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4ener/deviceName"></see></summary>
    let deviceName = Namespaced_IRI.parse _namespace_name "deviceName" |> NamespacedName

    /// <summary>
    /// The uncertainty of the duration
    /// <see href="https://saref.etsi.org/saref4ener/DurationUncertainty"></see></summary>
    let DurationUncertainty =
        Namespaced_IRI.parse _namespace_name "DurationUncertainty" |> NamespacedName

    /// <summary>
    /// The duration description for the duration uncertainty temporal entity
    /// <see href="https://saref.etsi.org/saref4ener/DurationUncertaintyDescription"></see></summary>
    let DurationUncertaintyDescription =
        Namespaced_IRI.parse _namespace_name "DurationUncertaintyDescription" |> NamespacedName

    /// <summary>
    /// The earliest possible start time for a power sequence or a slot. Only 'xs:duration' value types SHALL be used to denote a relative time which relates to 'now' as time 0.
    /// Note: This element applies to the first repetition of the slot number only.
    /// <see href="https://saref.etsi.org/saref4ener/EarliestStartTime"></see></summary>
    let EarliestStartTime =
        Namespaced_IRI.parse _namespace_name "EarliestStartTime" |> NamespacedName

    /// <summary>
    /// If state is set to 'running' or 'paused' AND the slot is determined, this element CAN contain the time the slot has already been in 'running' state (this also means the value remains constant during a 'paused' state). Otherwise it SHALL be omitted.
    /// <see href="https://saref.etsi.org/saref4ener/ElapsedSlotTime"></see></summary>
    let ElapsedSlotTime =
        Namespaced_IRI.parse _namespace_name "ElapsedSlotTime" |> NamespacedName

    /// <summary>
    /// Load control event action with value 'emergency'
    /// <see href="https://saref.etsi.org/saref4ener/Emergency"></see></summary>
    let Emergency = Namespaced_IRI.parse _namespace_name "Emergency" |> NamespacedName

    /// <summary>
    /// An action type used to express a produce action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/EventActionProduce"></see></summary>
    let EventActionProduce =
        Namespaced_IRI.parse _namespace_name "EventActionProduce" |> NamespacedName

    /// <summary>
    /// An action type used to express a consume action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/EventActionConsume"></see></summary>
    let EventActionConsume =
        Namespaced_IRI.parse _namespace_name "EventActionConsume" |> NamespacedName

    /// <summary>
    /// The endTime of a power sequence. If the value is available, it SHALL be denoted here. Otherwise the element SHALL be omitted.
    /// The end time of a slot MAY be stated in this element. The following equation SHALL apply: endTime - startTime = defaultDuration.
    /// <see href="https://saref.etsi.org/saref4ener/EndTime"></see></summary>
    let EndTime = Namespaced_IRI.parse _namespace_name "EndTime" |> NamespacedName

    /// <summary>
    /// The duration description for the end time duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/EndTimeDurationDescription"></see></summary>
    let EndTimeDurationDescription =
        Namespaced_IRI.parse _namespace_name "EndTimeDurationDescription" |> NamespacedName

    /// <summary>
    /// Energy type and value in a slot (i.e., Energy, EnergyMin, EnergyMax, EnergyExpected, EnergyStandardDeviation, EnergySkewness); or the ResumeEnergyEstimated in a power sequence, i.e., the additional energy the device will consume before resuming its normal operation (after a pause)
    /// <see href="https://saref.etsi.org/saref4ener/Energy"></see></summary>
    let Energy = Namespaced_IRI.parse _namespace_name "Energy" |> NamespacedName

    /// <summary>
    /// A possible type of energy in a slot that represents the expected energy consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergyExpected"></see></summary>
    let EnergyExpected =
        Namespaced_IRI.parse _namespace_name "EnergyExpected" |> NamespacedName

    /// <summary>
    /// A possible type of energy in a slot that represents the maximum energy consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergyMax"></see></summary>
    let EnergyMax = Namespaced_IRI.parse _namespace_name "EnergyMax" |> NamespacedName
    /// <summary>
    /// A possible type of energy in a slot that represents the minimum energy consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergyMin"></see></summary>
    let EnergyMin = Namespaced_IRI.parse _namespace_name "EnergyMin" |> NamespacedName

    /// <summary>
    /// A possible type of energy in a slot that represents the energy skewness and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergySkewness"></see></summary>
    let EnergySkewness =
        Namespaced_IRI.parse _namespace_name "EnergySkewness" |> NamespacedName

    /// <summary>
    /// A possible type of energy in a slot  that represents the energy standard deviation and its value
    /// <see href="https://saref.etsi.org/saref4ener/EnergyStandardDeviation"></see></summary>
    let EnergyStandardDeviation =
        Namespaced_IRI.parse _namespace_name "EnergyStandardDeviation" |> NamespacedName

    /// <summary>
    /// Load control state with value 'event accepted'
    /// <see href="https://saref.etsi.org/saref4ener/EventAccepted"></see></summary>
    let EventAccepted =
        Namespaced_IRI.parse _namespace_name "EventAccepted" |> NamespacedName

    /// <summary>
    /// In the load control, it expresses a produce state of an event an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/EventStateProduce"></see></summary>
    let EventStateProduce =
        Namespaced_IRI.parse _namespace_name "EventStateProduce" |> NamespacedName

    /// <summary>
    /// In the load control, it expresses a consume state of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/EventStateConsume"></see></summary>
    let EventStateConsume =
        Namespaced_IRI.parse _namespace_name "EventStateConsume" |> NamespacedName

    /// <summary>
    /// An action type used to express the action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/LoadControlEventAction"></see></summary>
    let LoadControlEventAction =
        Namespaced_IRI.parse _namespace_name "LoadControlEventAction" |> NamespacedName

    /// <summary>
    /// Load control event action with value 'pause'
    /// <see href="https://saref.etsi.org/saref4ener/Pause"></see></summary>
    let Pause = Namespaced_IRI.parse _namespace_name "Pause" |> NamespacedName
    /// <summary>
    /// Load control event action with value 'resume'
    /// <see href="https://saref.etsi.org/saref4ener/Resume"></see></summary>
    let Resume = Namespaced_IRI.parse _namespace_name "Resume" |> NamespacedName
    /// <summary>
    /// Load control event action with value 'reduce'
    /// <see href="https://saref.etsi.org/saref4ener/Reduce"></see></summary>
    let Reduce = Namespaced_IRI.parse _namespace_name "Reduce" |> NamespacedName
    /// <summary>
    /// Load control event action with value 'increase'
    /// <see href="https://saref.etsi.org/saref4ener/Increase"></see></summary>
    let Increase = Namespaced_IRI.parse _namespace_name "Increase" |> NamespacedName
    /// <summary>
    /// The value NORMAL used to instantiate the Load Control Event Action class and MeasurandState class
    /// <see href="https://saref.etsi.org/saref4ener/Normal"></see></summary>
    let Normal = Namespaced_IRI.parse _namespace_name "Normal" |> NamespacedName

    /// <summary>
    /// Load control state with value 'event cancelled'
    /// <see href="https://saref.etsi.org/saref4ener/EventCancelled"></see></summary>
    let EventCancelled =
        Namespaced_IRI.parse _namespace_name "EventCancelled" |> NamespacedName

    /// <summary>
    /// Load control state with value 'event error'
    /// <see href="https://saref.etsi.org/saref4ener/EventError"></see></summary>
    let EventError = Namespaced_IRI.parse _namespace_name "EventError" |> NamespacedName

    /// <summary>
    /// Load control state with value 'event rejected'
    /// <see href="https://saref.etsi.org/saref4ener/EventRejected"></see></summary>
    let EventRejected =
        Namespaced_IRI.parse _namespace_name "EventRejected" |> NamespacedName

    /// <summary>
    /// Load control state with value 'event started'
    /// <see href="https://saref.etsi.org/saref4ener/EventStarted"></see></summary>
    let EventStarted =
        Namespaced_IRI.parse _namespace_name "EventStarted" |> NamespacedName

    /// <summary>
    /// In the load control, it expresses the possible states of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/LoadControlEventState"></see></summary>
    let LoadControlEventState =
        Namespaced_IRI.parse _namespace_name "LoadControlEventState" |> NamespacedName

    /// <summary>
    /// Load control state with value 'event stopped'
    /// <see href="https://saref.etsi.org/saref4ener/EventStopped"></see></summary>
    let EventStopped =
        Namespaced_IRI.parse _namespace_name "EventStopped" |> NamespacedName

    /// <summary>
    /// Power sequence state with value 'inactive'
    /// <see href="https://saref.etsi.org/saref4ener/Inactive"></see></summary>
    let Inactive = Namespaced_IRI.parse _namespace_name "Inactive" |> NamespacedName
    /// <summary>
    /// Power sequence state with value 'invalid'
    /// <see href="https://saref.etsi.org/saref4ener/Invalid"></see></summary>
    let Invalid = Namespaced_IRI.parse _namespace_name "Invalid" |> NamespacedName

    /// <summary>
    /// The latest possible end time for a power sequence or a slot. Only 'xs:duration' value types SHALL be used to denote a relative time which relates to 'now' as time 0.
    /// Note: This element applies to the first repetition of the slot number only.
    /// <see href="https://saref.etsi.org/saref4ener/LatestEndTime"></see></summary>
    let LatestEndTime =
        Namespaced_IRI.parse _namespace_name "LatestEndTime" |> NamespacedName

    /// <summary>
    /// A relationship between a load control event (used to send overload warning severity level and related load control commands) and the device interested by this event.
    /// <see href="https://saref.etsi.org/saref4ener/hasDevice"></see></summary>
    let hasDevice = Namespaced_IRI.parse _namespace_name "hasDevice" |> NamespacedName

    /// <summary>
    /// A relationship between a load control event and the consume action triggered by this event
    /// <see href="https://saref.etsi.org/saref4ener/triggersEventActionConsume"></see></summary>
    let triggersEventActionConsume =
        Namespaced_IRI.parse _namespace_name "triggersEventActionConsume" |> NamespacedName

    /// <summary>
    /// A relationship between a load control event and the produce action triggered by this event
    /// <see href="https://saref.etsi.org/saref4ener/triggersEventActionProduce"></see></summary>
    let triggersEventActionProduce =
        Namespaced_IRI.parse _namespace_name "triggersEventActionProduce" |> NamespacedName

    /// <summary>
    /// Used in the Demand Response use case to identify an event
    /// <see href="https://saref.etsi.org/saref4ener/eventID"></see></summary>
    let eventID = Namespaced_IRI.parse _namespace_name "eventID" |> NamespacedName
    /// <summary>
    /// The time period associated with load control event data
    /// <see href="https://saref.etsi.org/saref4ener/TimePeriod"></see></summary>
    let TimePeriod = Namespaced_IRI.parse _namespace_name "TimePeriod" |> NamespacedName
    /// <summary>
    /// An entity that represents the possible states in SAREF4EE
    /// <see href="https://saref.etsi.org/saref4ener/State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName

    /// <summary>
    /// The representation of the state of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter).
    /// <see href="https://saref.etsi.org/saref4ener/LoadControlStateData"></see></summary>
    let LoadControlStateData =
        Namespaced_IRI.parse _namespace_name "LoadControlStateData" |> NamespacedName

    /// <summary>
    /// A relationship between the specification of the state of a load control event consume and the value that this state can assume.
    /// <see href="https://saref.etsi.org/saref4ener/hasEventStateConsume"></see></summary>
    let hasEventStateConsume =
        Namespaced_IRI.parse _namespace_name "hasEventStateConsume" |> NamespacedName

    /// <summary>
    /// A relationship between the specification of the state of a load control event produce and the value that this state can assume.
    /// <see href="https://saref.etsi.org/saref4ener/hasEventStateProduce"></see></summary>
    let hasEventStateProduce =
        Namespaced_IRI.parse _namespace_name "hasEventStateProduce" |> NamespacedName

    /// <summary>
    /// A relationship between the state of a load control event consume and the action to be performed as a consequence of this event.
    /// <see href="https://saref.etsi.org/saref4ener/hasAppliedEventActionConsume"></see></summary>
    let hasAppliedEventActionConsume =
        Namespaced_IRI.parse _namespace_name "hasAppliedEventActionConsume" |> NamespacedName

    /// <summary>
    /// A relationship between the state of a load control event produce and the action to be performed as a consequence of this event.
    /// <see href="https://saref.etsi.org/saref4ener/hasAppliedEventActionProduce"></see></summary>
    let hasAppliedEventActionProduce =
        Namespaced_IRI.parse _namespace_name "hasAppliedEventActionProduce" |> NamespacedName

    /// <summary>
    /// Maximum delay time between the end of the previous slot and the beginning of the current slot.
    /// <see href="https://saref.etsi.org/saref4ener/MaxActivationDelay"></see></summary>
    let MaxActivationDelay =
        Namespaced_IRI.parse _namespace_name "MaxActivationDelay" |> NamespacedName

    /// <summary>
    /// This field allows the anticipation of the phase if (and only if) the previous phase has the energy set to 0 Wh, each unit is a minute.
    /// <see href="https://saref.etsi.org/saref4ener/MaxAnticipation"></see></summary>
    let MaxAnticipation =
        Namespaced_IRI.parse _namespace_name "MaxAnticipation" |> NamespacedName

    /// <summary>
    /// If a slot has a configurable duration, it SHALL be present and denote the maximum supported configuration. Note: This element applies to the first repetition of the slot number only
    /// <see href="https://saref.etsi.org/saref4ener/MaxDuration"></see></summary>
    let MaxDuration =
        Namespaced_IRI.parse _namespace_name "MaxDuration" |> NamespacedName

    /// <summary>
    /// If a slot has a configurable duration, it SHALL be present and denote the minimum supported configuration. Note: This element applies to the first repetition of the slot number only.
    /// <see href="https://saref.etsi.org/saref4ener/MinDuration"></see></summary>
    let MinDuration =
        Namespaced_IRI.parse _namespace_name "MinDuration" |> NamespacedName

    /// <summary>
    /// The duration description for the pause duration (max and min) temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/PauseDurationDescription"></see></summary>
    let PauseDurationDescription =
        Namespaced_IRI.parse _namespace_name "PauseDurationDescription" |> NamespacedName

    /// <summary>
    /// The maximum duration a power sequence can pause after the end of an activity.
    /// <see href="https://saref.etsi.org/saref4ener/PauseDurationMax"></see></summary>
    let PauseDurationMax =
        Namespaced_IRI.parse _namespace_name "PauseDurationMax" |> NamespacedName

    /// <summary>
    /// The minimum duration a power sequence can pause after the end of an activity.
    /// <see href="https://saref.etsi.org/saref4ener/PauseDurationMin"></see></summary>
    let PauseDurationMin =
        Namespaced_IRI.parse _namespace_name "PauseDurationMin" |> NamespacedName

    /// <summary>
    /// The pause time of a power sequence or a slot
    /// <see href="https://saref.etsi.org/saref4ener/PauseTime"></see></summary>
    let PauseTime = Namespaced_IRI.parse _namespace_name "PauseTime" |> NamespacedName
    /// <summary>
    /// Power sequence state or sensor state with value 'paused'
    /// <see href="https://saref.etsi.org/saref4ener/Paused"></see></summary>
    let Paused = Namespaced_IRI.parse _namespace_name "Paused" |> NamespacedName
    /// <summary>
    /// Power sequence state with value 'pending'
    /// <see href="https://saref.etsi.org/saref4ener/Pending"></see></summary>
    let Pending = Namespaced_IRI.parse _namespace_name "Pending" |> NamespacedName
    /// <summary>
    /// Power type and value in a slot (i.e. power, powerMin, powerMax, powerExpectedValue, powerStandardDeviation, powerSkewness)
    /// <see href="https://saref.etsi.org/saref4ener/Power"></see></summary>
    let Power = Namespaced_IRI.parse _namespace_name "Power" |> NamespacedName

    /// <summary>
    /// A possible type of power in a slot that represents the expected power consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerExpected"></see></summary>
    let PowerExpected =
        Namespaced_IRI.parse _namespace_name "PowerExpected" |> NamespacedName

    /// <summary>
    /// A possible type of power in a slot that represents the maximum power consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerMax"></see></summary>
    let PowerMax = Namespaced_IRI.parse _namespace_name "PowerMax" |> NamespacedName
    /// <summary>
    /// A possible type of power in a slot that represents the minimum power consumption and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerMin"></see></summary>
    let PowerMin = Namespaced_IRI.parse _namespace_name "PowerMin" |> NamespacedName

    /// <summary>
    /// If set toTRUE, the power profile of a device does NOT permit the modification of more than one slot per configuration command.
    /// <see href="https://saref.etsi.org/saref4ener/supportsSingleSlotSchedulingOnly"></see></summary>
    let supportsSingleSlotSchedulingOnly =
        Namespaced_IRI.parse _namespace_name "supportsSingleSlotSchedulingOnly" |> NamespacedName

    /// <summary>
    /// Indicates the number of alternatives groups provided by a power profile
    /// <see href="https://saref.etsi.org/saref4ener/alternativesCount"></see></summary>
    let alternativesCount =
        Namespaced_IRI.parse _namespace_name "alternativesCount" |> NamespacedName

    /// <summary>
    /// Indicates whether the power profile of a device is configured for remote control (e.g., by an energy management system).This refers to the selection chosen by the user on the remote control feature of the device. If nodeRemoteControllable is equal to FALSE, all the supported power sequences shall set the sequenceRemoteControllable property to FALSE. If nodeRemoteControllable is equal to TRUE, at least one power sequence shall be remotely controllable by setting the sequenceRemoteControllable property to TRUE.
    /// <see href="https://saref.etsi.org/saref4ener/nodeRemoteControllable"></see></summary>
    let nodeRemoteControllable =
        Namespaced_IRI.parse _namespace_name "nodeRemoteControllable" |> NamespacedName

    /// <summary>
    /// If set toTRUE, the power profile of a device does not restrict the number of power sequence re-selections by the CEM, i.e. within a given alternative the CEM may first choose one power sequence, alter the selection by configuring another sequence later on, then alter the selection again, etc. (provided the process rules and data still permit configuration). If supportsReselection is set to FALSE, the device permits the CEM to select a power sequence of an alternative only once.
    /// <see href="https://saref.etsi.org/saref4ener/supportsReselection"></see></summary>
    let supportsReselection =
        Namespaced_IRI.parse _namespace_name "supportsReselection" |> NamespacedName

    /// <summary>
    /// Represents the total number of power sequences supported by the power profile of a device
    /// <see href="https://saref.etsi.org/saref4ener/totalSequencesCountMax"></see></summary>
    let totalSequencesCountMax =
        Namespaced_IRI.parse _namespace_name "totalSequencesCountMax" |> NamespacedName

    /// <summary>
    /// Specifies if the power sequence is stoppable.
    /// <see href="https://saref.etsi.org/saref4ener/isStoppable"></see></summary>
    let isStoppable =
        Namespaced_IRI.parse _namespace_name "isStoppable" |> NamespacedName

    /// <summary>
    /// Contains the total number of repetitions, if a power sequence repeats its sequence of slots. Absence of the element is equal to a presence with a value of 0 (zero). SHALL be absent if the value is 1.
    /// <see href="https://saref.etsi.org/saref4ener/repetitionsTotal"></see></summary>
    let repetitionsTotal =
        Namespaced_IRI.parse _namespace_name "repetitionsTotal" |> NamespacedName

    /// <summary>
    /// Represents the task identifier of the power sequence.
    /// <see href="https://saref.etsi.org/saref4ener/taskIdentifier"></see></summary>
    let taskIdentifier =
        Namespaced_IRI.parse _namespace_name "taskIdentifier" |> NamespacedName

    /// <summary>
    /// Indicates the current repetition of the sequence of slots. SHALL be present if a power sequence can repeat its sequence of slots (i.e., if s4ee:repetitionTotal is present and has a value &gt; 1). Otherwise, it SHALL be absent.
    /// <see href="https://saref.etsi.org/saref4ener/activeRepetitionNumber"></see></summary>
    let activeRepetitionNumber =
        Namespaced_IRI.parse _namespace_name "activeRepetitionNumber" |> NamespacedName

    /// <summary>
    /// A relationship between a power sequence and its energy (in terms of value and unit of measure)
    /// <see href="https://saref.etsi.org/saref4ener/hasEnergy"></see></summary>
    let hasEnergy = Namespaced_IRI.parse _namespace_name "hasEnergy" |> NamespacedName

    /// <summary>
    /// In a power sequence, the additional energy the device will consume before resuming its normal operation (after a pause). This is only an estimated value which will not be added to the value stated in any slot value information.
    /// <see href="https://saref.etsi.org/saref4ener/ResumeEnergyEstimated"></see></summary>
    let ResumeEnergyEstimated =
        Namespaced_IRI.parse _namespace_name "ResumeEnergyEstimated" |> NamespacedName

    /// <summary>
    /// Provides a unique power sequence identifier for a certain device
    /// <see href="https://saref.etsi.org/saref4ener/sequenceID"></see></summary>
    let sequenceID = Namespaced_IRI.parse _namespace_name "sequenceID" |> NamespacedName

    /// <summary>
    /// In a power sequence the additional costs for the resumption of a device to its normal operation (after a pause).
    /// <see href="https://saref.etsi.org/saref4ener/ResumeCostEstimated"></see></summary>
    let ResumeCostEstimated =
        Namespaced_IRI.parse _namespace_name "ResumeCostEstimated" |> NamespacedName

    /// <summary>
    /// Indicates the currently active slot number, if the power sequence state is set to 'running' or 'paused'. Otherwise it SHALL be omitted.
    /// <see href="https://saref.etsi.org/saref4ener/activeSlotNumber"></see></summary>
    let activeSlotNumber =
        Namespaced_IRI.parse _namespace_name "activeSlotNumber" |> NamespacedName

    /// <summary>
    /// Specifies if the power sequence is pausable.
    /// <see href="https://saref.etsi.org/saref4ener/isPausable"></see></summary>
    let isPausable = Namespaced_IRI.parse _namespace_name "isPausable" |> NamespacedName
    /// <summary>
    /// The single steps of a power sequence are represented by slots. A slot is associated with a slot number (while a power sequence is associated with a power sequence identifier). The slot numbers of two power sequences should be considered independent from each other, i.e., slot number 7 of sequence 1 describes a different slot than slot number 7 of sequence 2. Therefore a slot is only uniquely identified in combination with a sequence ID.
    /// <see href="https://saref.etsi.org/saref4ener/Slot"></see></summary>
    let Slot = Namespaced_IRI.parse _namespace_name "Slot" |> NamespacedName
    /// <summary>
    /// Indicates whether a power sequence applies a configuration that minimises the user’s energy bill (if set to TRUE). MAY be present. Absence of this element is equal to the presence with value FALSE.
    /// <see href="https://saref.etsi.org/saref4ener/cheapest"></see></summary>
    let cheapest = Namespaced_IRI.parse _namespace_name "cheapest" |> NamespacedName

    /// <summary>
    /// If state is set to 'running' or 'paused' AND the slot is determined, this element SHALL contain the time the slot still needs to be in 'running' state (this also means the value remains constant during a 'paused' state). Otherwise it SHALL be omitted.
    /// <see href="https://saref.etsi.org/saref4ener/RemainingSlotTime"></see></summary>
    let RemainingSlotTime =
        Namespaced_IRI.parse _namespace_name "RemainingSlotTime" |> NamespacedName

    /// <summary>
    /// States the maximum amount of starts a power sequence (of a device) allows per day.
    /// <see href="https://saref.etsi.org/saref4ener/maxCyclesPerDay"></see></summary>
    let maxCyclesPerDay =
        Namespaced_IRI.parse _namespace_name "maxCyclesPerDay" |> NamespacedName

    /// <summary>
    /// The startTime of a power sequence or slot. SHALL be present
    /// <see href="https://saref.etsi.org/saref4ener/StartTime"></see></summary>
    let StartTime = Namespaced_IRI.parse _namespace_name "StartTime" |> NamespacedName

    /// <summary>
    /// Indicates the source (origin/foundation) of the measurement forecasted values for a power sequence. If absent, the source is undefined. Remark: This element shall express the reliability of the forecast.
    /// <see href="https://saref.etsi.org/saref4ener/valueSource"></see></summary>
    let valueSource =
        Namespaced_IRI.parse _namespace_name "valueSource" |> NamespacedName

    /// <summary>
    /// Indicates whether a power sequence optimises the configuration towards the maximum availability of renewable energy (if set to TRUE). MAY be present. Absence of this element is equal to the presence with value FALSE.
    /// <see href="https://saref.etsi.org/saref4ener/greenest"></see></summary>
    let greenest = Namespaced_IRI.parse _namespace_name "greenest" |> NamespacedName

    /// <summary>
    /// Denotes whether a power sequence is modifiable (if value is TRUE) or not (if value is FALSE). Modifiability is required to configure power sequences and slots. It is also required to change a power sequence state.
    /// <see href="https://saref.etsi.org/saref4ener/sequenceRemoteControllable"></see></summary>
    let sequenceRemoteControllable =
        Namespaced_IRI.parse _namespace_name "sequenceRemoteControllable" |> NamespacedName

    /// <summary>
    /// Power sequence state with value 'running'
    /// <see href="https://saref.etsi.org/saref4ener/Running"></see></summary>
    let Running = Namespaced_IRI.parse _namespace_name "Running" |> NamespacedName
    /// <summary>
    /// Power sequence state with value 'scheduled'
    /// <see href="https://saref.etsi.org/saref4ener/Scheduled"></see></summary>
    let Scheduled = Namespaced_IRI.parse _namespace_name "Scheduled" |> NamespacedName

    /// <summary>
    /// Power sequence state with value 'scheduled paused'
    /// <see href="https://saref.etsi.org/saref4ener/ScheduledPaused"></see></summary>
    let ScheduledPaused =
        Namespaced_IRI.parse _namespace_name "ScheduledPaused" |> NamespacedName

    /// <summary>
    /// A possible type of power in a slot that represents the power skewness and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerSkewness"></see></summary>
    let PowerSkewness =
        Namespaced_IRI.parse _namespace_name "PowerSkewness" |> NamespacedName

    /// <summary>
    /// A possible type of power in a slot that represents the power standard deviation and its value
    /// <see href="https://saref.etsi.org/saref4ener/PowerStandardDeviation"></see></summary>
    let PowerStandardDeviation =
        Namespaced_IRI.parse _namespace_name "PowerStandardDeviation" |> NamespacedName

    /// <summary>
    /// The duration that the current slot (s4ee:activeSlotNumber) permits being paused. This element SHALL ONLY be present if the power sequence is interruptible. Otherwise, it SHALL be omitted. In case the power sequence is interruptible the following rules apply: If the element is absent this means there is no explicit pause duration restriction for the current slot; a value of 0s denoted the slot does not permit being paused.
    /// <see href="https://saref.etsi.org/saref4ener/RemainingPauseTime"></see></summary>
    let RemainingPauseTime =
        Namespaced_IRI.parse _namespace_name "RemainingPauseTime" |> NamespacedName

    /// <summary>
    /// Indicates whether a slot is optional (if set to TRUE). Otherwise, if a slot is mandatory, SHALL be omitted or set to FALSE. Note: This element applies to every repetition of the slot number.
    /// <see href="https://saref.etsi.org/saref4ener/optionalSlot"></see></summary>
    let optionalSlot =
        Namespaced_IRI.parse _namespace_name "optionalSlot" |> NamespacedName

    /// <summary>
    /// Provides a unique slot identifier for a certain power sequence
    /// <see href="https://saref.etsi.org/saref4ener/slotNumber"></see></summary>
    let slotNumber = Namespaced_IRI.parse _namespace_name "slotNumber" |> NamespacedName

    /// <summary>
    /// If a slot is optional, represents the current status of the slot (true = the slot will be executed, false = the slot will not be executed). If the slot is not optional, this element SHALL be absent.
    /// <see href="https://saref.etsi.org/saref4ener/slotActivated"></see></summary>
    let slotActivated =
        Namespaced_IRI.parse _namespace_name "slotActivated" |> NamespacedName

    /// <summary>
    /// A relationship representing a power value type
    /// <see href="https://saref.etsi.org/saref4ener/hasPowerValueType"></see></summary>
    let hasPowerValueType =
        Namespaced_IRI.parse _namespace_name "hasPowerValueType" |> NamespacedName

    /// <summary>
    /// A relation representing the value type of an entity
    /// <see href="https://saref.etsi.org/saref4ener/hasValueType"></see></summary>
    let hasValueType =
        Namespaced_IRI.parse _namespace_name "hasValueType" |> NamespacedName

    /// <summary>
    /// A relationship representing an energy value type
    /// <see href="https://saref.etsi.org/saref4ener/hasEnergyValueType"></see></summary>
    let hasEnergyValueType =
        Namespaced_IRI.parse _namespace_name "hasEnergyValueType" |> NamespacedName

    /// <summary>
    /// The duration description for the slot time duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/SlotTimeDurationDescription"></see></summary>
    let SlotTimeDurationDescription =
        Namespaced_IRI.parse _namespace_name "SlotTimeDurationDescription" |> NamespacedName

    /// <summary>
    /// The duration description for the start time duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/StartTimeDurationDescription"></see></summary>
    let StartTimeDurationDescription =
        Namespaced_IRI.parse _namespace_name "StartTimeDurationDescription" |> NamespacedName

    /// <summary>
    /// The duration description for the time period duration temporal entities
    /// <see href="https://saref.etsi.org/saref4ener/TimePeriodDurationDescription"></see></summary>
    let TimePeriodDurationDescription =
        Namespaced_IRI.parse _namespace_name "TimePeriodDurationDescription" |> NamespacedName

    /// <summary>
    /// Indicates whether a slot is used (activateSlot = true) or not (activateSlot = false). SHALL be present if a slot is optional (i.e., the property s4ee:optionalSlot is TRUE), otherwise SHALL be absent (i.e. in case the slot is mandatory).
    /// <see href="https://saref.etsi.org/saref4ener/activateSlot"></see></summary>
    let activateSlot =
        Namespaced_IRI.parse _namespace_name "activateSlot" |> NamespacedName

    /// <summary>
    /// In the Remote Network Management (RemoteNWM) use case, a relationship between a node in a network (i.e., a s4ee:Device) and its connections (i.e., a s4ee:DeviceConnections). The same s4ee:Device (or node) can have multiple device connections as it can be connected to several networks at the same time.
    /// <see href="https://saref.etsi.org/saref4ener/hasConnection"></see></summary>
    let hasConnection =
        Namespaced_IRI.parse _namespace_name "hasConnection" |> NamespacedName

    /// <summary>
    /// A relationship between an appliance parameter compatibility action and the associated expressions
    /// <see href="https://saref.etsi.org/saref4ener/hasExpression"></see></summary>
    let hasExpression =
        Namespaced_IRI.parse _namespace_name "hasExpression" |> NamespacedName

    /// <summary>
    /// A relationship identifying the functions performed by an actuator level and an actuator switch
    /// <see href="https://saref.etsi.org/saref4ener/hasFunction"></see></summary>
    let hasFunction =
        Namespaced_IRI.parse _namespace_name "hasFunction" |> NamespacedName

    /// <summary>
    /// Enables the identification of different sensors on one EEBus address.
    /// <see href="https://saref.etsi.org/saref4ener/measurementID"></see></summary>
    let measurementID =
        Namespaced_IRI.parse _namespace_name "measurementID" |> NamespacedName

    /// <summary>
    /// An identifier for one specific message. If a message is marked as obsolete, this number can be used to identify the original message.
    /// <see href="https://saref.etsi.org/saref4ener/messagingNumber"></see></summary>
    let messagingNumber =
        Namespaced_IRI.parse _namespace_name "messagingNumber" |> NamespacedName

    /// <summary>
    /// Indicates the type of the message. Possible values are:
    /// -	logging (used for messages, that shall be stored in a log file)
    /// -	information (messages, that shall be presented to the customer on a display; lower priority)
    /// -	warning (messages, that shall be presented to the customer on a display; medium priority)
    /// -	alarm (messages, that shall be presented to the customer on a display; high priority; if there is an alarm device in the household, it shall generate an alarm)
    /// -	emergency (messages, that shall be presented to the customer on a display; very high priority; if there is an alarm device in the household, it shall generate an alarm; additionally, if possible and configured, an emergency call shall be done)
    /// -	obsolete (previously sent messages, that shall be marked as obsolete)
    /// <see href="https://saref.etsi.org/saref4ener/messagingType"></see></summary>
    let messagingType =
        Namespaced_IRI.parse _namespace_name "messagingType" |> NamespacedName

    /// <summary>
    /// Indicates whether the tendency of a measurement is rising, stable or falling.
    /// <see href="https://saref.etsi.org/saref4ener/valueTendency"></see></summary>
    let valueTendency =
        Namespaced_IRI.parse _namespace_name "valueTendency" |> NamespacedName

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
    let xsdDuration =
        Namespaced_IRI.parse _namespace_name "xsdDuration" |> NamespacedName
