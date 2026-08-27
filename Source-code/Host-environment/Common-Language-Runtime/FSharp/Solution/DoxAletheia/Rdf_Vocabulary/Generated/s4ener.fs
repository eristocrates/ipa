namespace https.saref.etsi.org.saref4ener.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4ener =
    let _namespace_iri = Namespace_Iri s4ener |> NamespaceIRI
    /// <summary>
    ///   <para>s4ener:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/">https://saref.etsi.org/saref4ener/</seealso>
    let _prefix_iri = Prefixed_Name(s4ener, "") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:ActivationDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The scheduled activation delay for a slot."</para>
    /// labels<para>"Activation delay"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActivationDelay">https://saref.etsi.org/saref4ener/ActivationDelay</seealso>
    let ActivationDelay = Prefixed_Name(s4ener, "ActivationDelay") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:ActivationDelayDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the activation delay duration temporal entity"</para>
    /// labels<para>"Activation delay duration description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActivationDelayDurationDescription">https://saref.etsi.org/saref4ener/ActivationDelayDurationDescription</seealso>
    let ActivationDelayDurationDescription =
        Prefixed_Name(s4ener, "ActivationDelayDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:ActiveDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the active duration (min and max, sum max and sum min) temporal entities"</para>
    /// labels<para>"Active duration description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActiveDurationDescription">https://saref.etsi.org/saref4ener/ActiveDurationDescription</seealso>
    let ActiveDurationDescription =
        Prefixed_Name(s4ener, "ActiveDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:ActiveDurationMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The active maximum duration a power sequence can run without interruption."</para>
    /// labels<para>"Active duration max"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActiveDurationMax">https://saref.etsi.org/saref4ener/ActiveDurationMax</seealso>
    let ActiveDurationMax = Prefixed_Name(s4ener, "ActiveDurationMax") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:ActiveDurationMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The active mininum duration a power sequence can run without interruption."</para>
    /// labels<para>"Active duration min"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActiveDurationMin">https://saref.etsi.org/saref4ener/ActiveDurationMin</seealso>
    let ActiveDurationMin = Prefixed_Name(s4ener, "ActiveDurationMin") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:ActiveDurationSumMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The active maximum duration a power sequence can run in total (summation of all active times)."</para>
    /// labels<para>"Active duration sum max"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActiveDurationSumMax">https://saref.etsi.org/saref4ener/ActiveDurationSumMax</seealso>
    let ActiveDurationSumMax =
        Prefixed_Name(s4ener, "ActiveDurationSumMax") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:ActiveDurationSumMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The active minimum duration a power sequence must run in total (summation of all active times)."</para>
    /// labels<para>"Active duration sum min"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActiveDurationSumMin">https://saref.etsi.org/saref4ener/ActiveDurationSumMin</seealso>
    let ActiveDurationSumMin =
        Prefixed_Name(s4ener, "ActiveDurationSumMin") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:ActuatorLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Independent from the ActuatorSwitch class, the ActuatorLevel class enables a user or application to model LEVEL commands (start, up, percentageAbsolute, relative, etc.). This can be used to dim a light, set the speed of an electric motor, etc."</para>
    /// labels<para>"Actuator level"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActuatorLevel">https://saref.etsi.org/saref4ener/ActuatorLevel</seealso>
    let ActuatorLevel = Prefixed_Name(s4ener, "ActuatorLevel") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:ActuatorSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Basic on/off operations on a simple actuator can be modelled with the ActuatorSwitch class. Whether the function turns a device itself ON or OFF, or whether it switches a specific feature, depends on the implementation. For example, one could model the super freeze program of a freezer using ActuatorSwitch class. An ON command would then activate the super freeze program and an OFF command would deactivate it. This example shall just give an idea how ActuatorSwitch can be used for more purposes than only turning devices on and off."</para>
    /// labels<para>"Actuator switch"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ActuatorSwitch">https://saref.etsi.org/saref4ener/ActuatorSwitch</seealso>
    let ActuatorSwitch = Prefixed_Name(s4ener, "ActuatorSwitch") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:AlternativesGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of power sequences for a certain profile"</para>
    /// labels<para>"Alternatives group"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/AlternativesGroup">https://saref.etsi.org/saref4ener/AlternativesGroup</seealso>
    let AlternativesGroup = Prefixed_Name(s4ener, "AlternativesGroup") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:AnticipationDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the anticipation duration temporal entities"</para>
    /// labels<para>"Anticipation duration description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/AnticipationDurationDescription">https://saref.etsi.org/saref4ener/AnticipationDurationDescription</seealso>
    let AnticipationDurationDescription =
        Prefixed_Name(s4ener, "AnticipationDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:Completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:PowerSequenceState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Power sequence state with value 'completed'"</para>
    /// labels<para>"Completed"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Completed">https://saref.etsi.org/saref4ener/Completed</seealso>
    let Completed = Prefixed_Name(s4ener, "Completed") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:DefaultDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration of a slot (SHALL be present in case of 'determined slot'). If a slot has a configurable lenght, this element SHALL reflect the currently configured lenght"</para>
    /// labels<para>"Default duration"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/DefaultDuration">https://saref.etsi.org/saref4ener/DefaultDuration</seealso>
    let DefaultDuration = Prefixed_Name(s4ener, "DefaultDuration") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:DefaultDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the default duration temporal entity"</para>
    /// labels<para>"Default duration description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/DefaultDurationDescription">https://saref.etsi.org/saref4ener/DefaultDurationDescription</seealso>
    let DefaultDurationDescription =
        Prefixed_Name(s4ener, "DefaultDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specialization of a saref:Device that exposes a power profile with power sequences to the CEM (note that a s4ee:Device can also be called 'power sequence server'). Most of the existing devices can expose at most 1 power profile, but there are special cases in which more than one power profiles can be exposed by the same device. For example, consider the case of a combined fridge-freezer in which there are 2 logical devices (fridge and freezer) combined in 1 physical device. This combined device can expose 2 power profiles, one for the fridge and one for the freezer. A s4ee:Device (e.g. a household appliance or a smart meter) can also receive events about overload warning severity level and related load control commands (LoadControlEventData)"</para>
    /// labels<para>"Device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Device">https://saref.etsi.org/saref4ener/Device</seealso>
    let Device = Prefixed_Name(s4ener, "Device") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:DurationUncertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The uncertainty of the duration "</para>
    /// labels<para>"Duration uncertainty"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/DurationUncertainty">https://saref.etsi.org/saref4ener/DurationUncertainty</seealso>
    let DurationUncertainty =
        Prefixed_Name(s4ener, "DurationUncertainty") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:DurationUncertaintyDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the duration uncertainty temporal entity"</para>
    /// labels<para>"Duration uncertainty description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/DurationUncertaintyDescription">https://saref.etsi.org/saref4ener/DurationUncertaintyDescription</seealso>
    let DurationUncertaintyDescription =
        Prefixed_Name(s4ener, "DurationUncertaintyDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:EarliestStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The earliest possible start time for a power sequence or a slot. Only 'xs:duration' value types SHALL be used to denote a relative time which relates to 'now' as time 0.
    /// Note: This element applies to the first repetition of the slot number only."</para>
    /// labels<para>"Earliest start time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EarliestStartTime">https://saref.etsi.org/saref4ener/EarliestStartTime</seealso>
    let EarliestStartTime = Prefixed_Name(s4ener, "EarliestStartTime") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:ElapsedSlotTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If state is set to 'running' or 'paused' AND the slot is determined, this element CAN contain the time the slot has already been in 'running' state (this also means the value remains constant during a 'paused' state). Otherwise it SHALL be omitted."</para>
    /// labels<para>"Elapsed slot time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ElapsedSlotTime">https://saref.etsi.org/saref4ener/ElapsedSlotTime</seealso>
    let ElapsedSlotTime = Prefixed_Name(s4ener, "ElapsedSlotTime") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Emergency</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventActionConsume</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:EventActionProduce</para>
    ///   <para>"Load control event action with value 'emergency'"</para>
    /// labels<para>"Emergency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Emergency">https://saref.etsi.org/saref4ener/Emergency</seealso>
    let Emergency = Prefixed_Name(s4ener, "Emergency") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The endTime of a power sequence. If the value is available, it SHALL be denoted here. Otherwise the element SHALL be omitted.
    /// The end time of a slot MAY be stated in this element. The following equation SHALL apply: endTime - startTime = defaultDuration."</para>
    /// labels<para>"End time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EndTime">https://saref.etsi.org/saref4ener/EndTime</seealso>
    let EndTime = Prefixed_Name(s4ener, "EndTime") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:EndTimeDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the end time duration temporal entities"</para>
    /// labels<para>"End time duration Description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EndTimeDurationDescription">https://saref.etsi.org/saref4ener/EndTimeDurationDescription</seealso>
    let EndTimeDurationDescription =
        Prefixed_Name(s4ener, "EndTimeDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Energy type and value in a slot (i.e., Energy, EnergyMin, EnergyMax, EnergyExpected, EnergyStandardDeviation, EnergySkewness); or the ResumeEnergyEstimated in a power sequence, i.e., the additional energy the device will consume before resuming its normal operation (after a pause)"</para>
    /// labels<para>"Energy"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Energy">https://saref.etsi.org/saref4ener/Energy</seealso>
    let Energy = Prefixed_Name(s4ener, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EnergyExpected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of energy in a slot that represents the expected energy consumption and its value"</para>
    /// labels<para>"Energy expected"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EnergyExpected">https://saref.etsi.org/saref4ener/EnergyExpected</seealso>
    let EnergyExpected = Prefixed_Name(s4ener, "EnergyExpected") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EnergyMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of energy in a slot that represents the maximum energy consumption and its value"</para>
    /// labels<para>"Energy max"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EnergyMax">https://saref.etsi.org/saref4ener/EnergyMax</seealso>
    let EnergyMax = Prefixed_Name(s4ener, "EnergyMax") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EnergyMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of energy in a slot that represents the minimum energy consumption and its value"</para>
    /// labels<para>"Energy min"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EnergyMin">https://saref.etsi.org/saref4ener/EnergyMin</seealso>
    let EnergyMin = Prefixed_Name(s4ener, "EnergyMin") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EnergySkewness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of energy in a slot that represents the energy skewness and its value"</para>
    /// labels<para>"Energy skewness"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EnergySkewness">https://saref.etsi.org/saref4ener/EnergySkewness</seealso>
    let EnergySkewness = Prefixed_Name(s4ener, "EnergySkewness") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:EnergyStandardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of energy in a slot  that represents the energy standard deviation and its value"</para>
    /// labels<para>"Energy Standard Deviation"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EnergyStandardDeviation">https://saref.etsi.org/saref4ener/EnergyStandardDeviation</seealso>
    let EnergyStandardDeviation =
        Prefixed_Name(s4ener, "EnergyStandardDeviation") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:EventAccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:EventStateProduce</para>
    ///   <para>s4ener:EventStateConsume</para>
    ///   <para>"Load control state with value 'event accepted'"</para>
    /// labels<para>"Event accepted"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventAccepted">https://saref.etsi.org/saref4ener/EventAccepted</seealso>
    let EventAccepted = Prefixed_Name(s4ener, "EventAccepted") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventActionConsume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An action type used to express a consume action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter)."</para>
    /// labels<para>"Event action consume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventActionConsume">https://saref.etsi.org/saref4ener/EventActionConsume</seealso>
    let EventActionConsume = Prefixed_Name(s4ener, "EventActionConsume") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventActionProduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An action type used to express a produce action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter)."</para>
    /// labels<para>"Event action produce"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventActionProduce">https://saref.etsi.org/saref4ener/EventActionProduce</seealso>
    let EventActionProduce = Prefixed_Name(s4ener, "EventActionProduce") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventStateConsume</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:EventStateProduce</para>
    ///   <para>"Load control state with value 'event cancelled'"</para>
    /// labels<para>"Event cancelled"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventCancelled">https://saref.etsi.org/saref4ener/EventCancelled</seealso>
    let EventCancelled = Prefixed_Name(s4ener, "EventCancelled") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventError</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventStateProduce</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:EventStateConsume</para>
    ///   <para>"Load control state with value 'event error'"</para>
    /// labels<para>"Event error"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventError">https://saref.etsi.org/saref4ener/EventError</seealso>
    let EventError = Prefixed_Name(s4ener, "EventError") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventRejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventStateConsume</para>
    ///   <para>s4ener:EventStateProduce</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Load control state with value 'event rejected'"</para>
    /// labels<para>"Event rejected"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventRejected">https://saref.etsi.org/saref4ener/EventRejected</seealso>
    let EventRejected = Prefixed_Name(s4ener, "EventRejected") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventStarted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:EventStateConsume</para>
    ///   <para>s4ener:EventStateProduce</para>
    ///   <para>"Load control state with value 'event started'"</para>
    /// labels<para>"Event started"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventStarted">https://saref.etsi.org/saref4ener/EventStarted</seealso>
    let EventStarted = Prefixed_Name(s4ener, "EventStarted") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventStateConsume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In the load control, it expresses a consume state of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter)."</para>
    /// labels<para>"Event state consume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventStateConsume">https://saref.etsi.org/saref4ener/EventStateConsume</seealso>
    let EventStateConsume = Prefixed_Name(s4ener, "EventStateConsume") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventStateProduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In the load control, it expresses a produce state of an event an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter)."</para>
    /// labels<para>"Event state produce"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventStateProduce">https://saref.etsi.org/saref4ener/EventStateProduce</seealso>
    let EventStateProduce = Prefixed_Name(s4ener, "EventStateProduce") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:EventStopped</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventStateConsume</para>
    ///   <para>s4ener:EventStateProduce</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Load control state with value 'event stopped'"</para>
    /// labels<para>"Event stopped"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/EventStopped">https://saref.etsi.org/saref4ener/EventStopped</seealso>
    let EventStopped = Prefixed_Name(s4ener, "EventStopped") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Inactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:PowerSequenceState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Power sequence state with value 'inactive'"</para>
    /// labels<para>"Inactive"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Inactive">https://saref.etsi.org/saref4ener/Inactive</seealso>
    let Inactive = Prefixed_Name(s4ener, "Inactive") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Increase</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventActionConsume</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:EventActionProduce</para>
    ///   <para>"Load control event action with value 'increase'"</para>
    /// labels<para>"Increase"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Increase">https://saref.etsi.org/saref4ener/Increase</seealso>
    let Increase = Prefixed_Name(s4ener, "Increase") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Invalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:PowerSequenceState</para>
    ///   <para>"Power sequence state with value 'invalid'"</para>
    /// labels<para>"Invalid"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Invalid">https://saref.etsi.org/saref4ener/Invalid</seealso>
    let Invalid = Prefixed_Name(s4ener, "Invalid") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:LatestEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The latest possible end time for a power sequence or a slot. Only 'xs:duration' value types SHALL be used to denote a relative time which relates to 'now' as time 0.
    /// Note: This element applies to the first repetition of the slot number only."</para>
    /// labels<para>"Latest end time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/LatestEndTime">https://saref.etsi.org/saref4ener/LatestEndTime</seealso>
    let LatestEndTime = Prefixed_Name(s4ener, "LatestEndTime") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:LoadControlEventAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An action type used to express the action to be performed as a consequence of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter)."</para>
    /// labels<para>"Load Control event action"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/LoadControlEventAction">https://saref.etsi.org/saref4ener/LoadControlEventAction</seealso>
    let LoadControlEventAction =
        Prefixed_Name(s4ener, "LoadControlEventAction") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:LoadControlEventData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter)."</para>
    /// labels<para>"Load control event data"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/LoadControlEventData">https://saref.etsi.org/saref4ener/LoadControlEventData</seealso>
    let LoadControlEventData =
        Prefixed_Name(s4ener, "LoadControlEventData") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:LoadControlEventState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In the load control, it expresses the possible states of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter)."</para>
    /// labels<para>"Load control event state "</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/LoadControlEventState">https://saref.etsi.org/saref4ener/LoadControlEventState</seealso>
    let LoadControlEventState =
        Prefixed_Name(s4ener, "LoadControlEventState") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:LoadControlStateData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The representation of the state of an event used to send overload warning severity level and related load control commands to a device (e.g. a household appliance or a smart meter)."</para>
    /// labels<para>"Load control state data"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/LoadControlStateData">https://saref.etsi.org/saref4ener/LoadControlStateData</seealso>
    let LoadControlStateData =
        Prefixed_Name(s4ener, "LoadControlStateData") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:MaxActivationDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Maximum delay time between the end of the previous slot and the beginning of the current slot."</para>
    /// labels<para>"Max activation delay"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/MaxActivationDelay">https://saref.etsi.org/saref4ener/MaxActivationDelay</seealso>
    let MaxActivationDelay = Prefixed_Name(s4ener, "MaxActivationDelay") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:MaxAnticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This field allows the anticipation of the phase if (and only if) the previous phase has the energy set to 0 Wh, each unit is a minute."</para>
    /// labels<para>"Max anticipation"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/MaxAnticipation">https://saref.etsi.org/saref4ener/MaxAnticipation</seealso>
    let MaxAnticipation = Prefixed_Name(s4ener, "MaxAnticipation") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:MaxDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If a slot has a configurable duration, it SHALL be present and denote the maximum supported configuration. Note: This element applies to the first repetition of the slot number only"</para>
    /// labels<para>"Max duration"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/MaxDuration">https://saref.etsi.org/saref4ener/MaxDuration</seealso>
    let MaxDuration = Prefixed_Name(s4ener, "MaxDuration") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:MinDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If a slot has a configurable duration, it SHALL be present and denote the minimum supported configuration. Note: This element applies to the first repetition of the slot number only."</para>
    /// labels<para>"Min duration"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/MinDuration">https://saref.etsi.org/saref4ener/MinDuration</seealso>
    let MinDuration = Prefixed_Name(s4ener, "MinDuration") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Normal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:EventActionProduce</para>
    ///   <para>s4ener:EventActionConsume</para>
    ///   <para>"The value NORMAL used to instantiate the Load Control Event Action class and MeasurandState class"</para>
    /// labels<para>"Normal"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Normal">https://saref.etsi.org/saref4ener/Normal</seealso>
    let Normal = Prefixed_Name(s4ener, "Normal") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Pause</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventActionProduce</para>
    ///   <para>s4ener:EventActionConsume</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Load control event action with value 'pause'"</para>
    /// labels<para>"Pause"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Pause">https://saref.etsi.org/saref4ener/Pause</seealso>
    let Pause = Prefixed_Name(s4ener, "Pause") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:PauseDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the pause duration (max and min) temporal entities"</para>
    /// labels<para>"Pause duration description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PauseDurationDescription">https://saref.etsi.org/saref4ener/PauseDurationDescription</seealso>
    let PauseDurationDescription =
        Prefixed_Name(s4ener, "PauseDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:PauseDurationMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The maximum duration a power sequence can pause after the end of an activity."</para>
    /// labels<para>"Pause duration max"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PauseDurationMax">https://saref.etsi.org/saref4ener/PauseDurationMax</seealso>
    let PauseDurationMax = Prefixed_Name(s4ener, "PauseDurationMax") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PauseDurationMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The minimum duration a power sequence can pause after the end of an activity."</para>
    /// labels<para>"Pause duration min"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PauseDurationMin">https://saref.etsi.org/saref4ener/PauseDurationMin</seealso>
    let PauseDurationMin = Prefixed_Name(s4ener, "PauseDurationMin") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PauseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The pause time of a power sequence or a slot"</para>
    /// labels<para>"Pause time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PauseTime">https://saref.etsi.org/saref4ener/PauseTime</seealso>
    let PauseTime = Prefixed_Name(s4ener, "PauseTime") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Paused</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:PowerSequenceState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Power sequence state or sensor state with value 'paused'"</para>
    /// labels<para>"Paused"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Paused">https://saref.etsi.org/saref4ener/Paused</seealso>
    let Paused = Prefixed_Name(s4ener, "Paused") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Pending</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:PowerSequenceState</para>
    ///   <para>"Power sequence state with value 'pending'"</para>
    /// labels<para>"Pending"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Pending">https://saref.etsi.org/saref4ener/Pending</seealso>
    let Pending = Prefixed_Name(s4ener, "Pending") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Power type and value in a slot (i.e. power, powerMin, powerMax, powerExpectedValue, powerStandardDeviation, powerSkewness)"</para>
    /// labels<para>"Power"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Power">https://saref.etsi.org/saref4ener/Power</seealso>
    let Power = Prefixed_Name(s4ener, "Power") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PowerExpected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of power in a slot that represents the expected power consumption and its value"</para>
    /// labels<para>"Power expected "</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PowerExpected">https://saref.etsi.org/saref4ener/PowerExpected</seealso>
    let PowerExpected = Prefixed_Name(s4ener, "PowerExpected") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PowerMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of power in a slot that represents the maximum power consumption and its value"</para>
    /// labels<para>"Power max"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PowerMax">https://saref.etsi.org/saref4ener/PowerMax</seealso>
    let PowerMax = Prefixed_Name(s4ener, "PowerMax") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PowerMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of power in a slot that represents the minimum power consumption and its value"</para>
    /// labels<para>"Power min"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PowerMin">https://saref.etsi.org/saref4ener/PowerMin</seealso>
    let PowerMin = Prefixed_Name(s4ener, "PowerMin") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PowerProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A way to model curves of power and energy over time, which also provides definitions for the modelling of power scheduling including alternative plans. With a PowerProfile, a device (or power sequences server) exposes the power sequences that are potentially relevant for the CEM (or power sequences client). "</para>
    /// labels<para>"Power profile"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PowerProfile">https://saref.etsi.org/saref4ener/PowerProfile</seealso>
    let PowerProfile = Prefixed_Name(s4ener, "PowerProfile") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PowerSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The specification of a task, such as wash or tumble dry, according to user preferences and/or manufacturer's settings for a certain device.  It is the most 'coarse' view, a power sequence can represent all single steps of a whole task,where the single steps are represented by slots. If the power sequence is pausable by the bound power sequences client, the property 'saref:isInterruptionPossible' SHALL be present and set to true. Otherwise it SHALL be omitted. If the power sequence is stoppable by the bound power sequences client, the property 'saref:isFlexible' SHALL be present and set to true. Otherwise it SHALL be omitted."</para>
    /// labels<para>"Power sequence"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PowerSequence">https://saref.etsi.org/saref4ener/PowerSequence</seealso>
    let PowerSequence = Prefixed_Name(s4ener, "PowerSequence") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PowerSequenceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The current state of the power sequence. It can assume one of the values 'running', 'paused', 'scheduled', 'scheduled paused', 'pending', 'inactive', 'completed',  or 'invalid'."</para>
    /// labels<para>"Power sequence state"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PowerSequenceState">https://saref.etsi.org/saref4ener/PowerSequenceState</seealso>
    let PowerSequenceState = Prefixed_Name(s4ener, "PowerSequenceState") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:PowerSkewness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of power in a slot that represents the power skewness and its value"</para>
    /// labels<para>"Power skewness"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PowerSkewness">https://saref.etsi.org/saref4ener/PowerSkewness</seealso>
    let PowerSkewness = Prefixed_Name(s4ener, "PowerSkewness") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:PowerStandardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A possible type of power in a slot that represents the power standard deviation and its value"</para>
    /// labels<para>"Power standard deviation"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/PowerStandardDeviation">https://saref.etsi.org/saref4ener/PowerStandardDeviation</seealso>
    let PowerStandardDeviation =
        Prefixed_Name(s4ener, "PowerStandardDeviation") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:Reduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventActionConsume</para>
    ///   <para>s4ener:EventActionProduce</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Load control event action with value 'reduce'"</para>
    /// labels<para>"Reduce"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Reduce">https://saref.etsi.org/saref4ener/Reduce</seealso>
    let Reduce = Prefixed_Name(s4ener, "Reduce") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:RemainingPauseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration that the current slot (s4ee:activeSlotNumber) permits being paused. This element SHALL ONLY be present if the power sequence is interruptible. Otherwise, it SHALL be omitted. In case the power sequence is interruptible the following rules apply: If the element is absent this means there is no explicit pause duration restriction for the current slot; a value of 0s denoted the slot does not permit being paused."</para>
    /// labels<para>"Remaining pause time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/RemainingPauseTime">https://saref.etsi.org/saref4ener/RemainingPauseTime</seealso>
    let RemainingPauseTime = Prefixed_Name(s4ener, "RemainingPauseTime") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:RemainingSlotTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If state is set to 'running' or 'paused' AND the slot is determined, this element SHALL contain the time the slot still needs to be in 'running' state (this also means the value remains constant during a 'paused' state). Otherwise it SHALL be omitted."</para>
    /// labels<para>"Remaining slot time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/RemainingSlotTime">https://saref.etsi.org/saref4ener/RemainingSlotTime</seealso>
    let RemainingSlotTime = Prefixed_Name(s4ener, "RemainingSlotTime") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Resume</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:EventActionProduce</para>
    ///   <para>s4ener:EventActionConsume</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Load control event action with value 'resume'"</para>
    /// labels<para>"Resume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Resume">https://saref.etsi.org/saref4ener/Resume</seealso>
    let Resume = Prefixed_Name(s4ener, "Resume") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:ResumeCostEstimated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In a power sequence the additional costs for the resumption of a device to its normal operation (after a pause)."</para>
    /// labels<para>"Resume cost estimated"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ResumeCostEstimated">https://saref.etsi.org/saref4ener/ResumeCostEstimated</seealso>
    let ResumeCostEstimated =
        Prefixed_Name(s4ener, "ResumeCostEstimated") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:ResumeEnergyEstimated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In a power sequence, the additional energy the device will consume before resuming its normal operation (after a pause). This is only an estimated value which will not be added to the value stated in any slot value information."</para>
    /// labels<para>"Resume energy estimated"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ResumeEnergyEstimated">https://saref.etsi.org/saref4ener/ResumeEnergyEstimated</seealso>
    let ResumeEnergyEstimated =
        Prefixed_Name(s4ener, "ResumeEnergyEstimated") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:Running</para>
    /// </summary>
    /// <remarks>
    ///   <para>s4ener:PowerSequenceState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Power sequence state with value 'running'"</para>
    /// labels<para>"Running"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Running">https://saref.etsi.org/saref4ener/Running</seealso>
    let Running = Prefixed_Name(s4ener, "Running") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Scheduled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:PowerSequenceState</para>
    ///   <para>"Power sequence state with value 'scheduled'"</para>
    /// labels<para>"Scheduled"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Scheduled">https://saref.etsi.org/saref4ener/Scheduled</seealso>
    let Scheduled = Prefixed_Name(s4ener, "Scheduled") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:ScheduledPaused</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>s4ener:PowerSequenceState</para>
    ///   <para>"Power sequence state with value 'scheduled paused'"</para>
    /// labels<para>"Scheduled paused"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/ScheduledPaused">https://saref.etsi.org/saref4ener/ScheduledPaused</seealso>
    let ScheduledPaused = Prefixed_Name(s4ener, "ScheduledPaused") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:Slot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The single steps of a power sequence are represented by slots. A slot is associated with a slot number (while a power sequence is associated with a power sequence identifier). The slot numbers of two power sequences should be considered independent from each other, i.e., slot number 7 of sequence 1 describes a different slot than slot number 7 of sequence 2. Therefore a slot is only uniquely identified in combination with a sequence ID. "</para>
    /// labels<para>"Slot"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/Slot">https://saref.etsi.org/saref4ener/Slot</seealso>
    let Slot = Prefixed_Name(s4ener, "Slot") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:SlotTimeDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the slot time duration temporal entities"</para>
    /// labels<para>"Slot time duration description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/SlotTimeDurationDescription">https://saref.etsi.org/saref4ener/SlotTimeDurationDescription</seealso>
    let SlotTimeDurationDescription =
        Prefixed_Name(s4ener, "SlotTimeDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:StartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The startTime of a power sequence or slot. SHALL be present"</para>
    /// labels<para>"Start time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/StartTime">https://saref.etsi.org/saref4ener/StartTime</seealso>
    let StartTime = Prefixed_Name(s4ener, "StartTime") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:StartTimeDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the start time duration temporal entities"</para>
    /// labels<para>"Start time duration description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/StartTimeDurationDescription">https://saref.etsi.org/saref4ener/StartTimeDurationDescription</seealso>
    let StartTimeDurationDescription =
        Prefixed_Name(s4ener, "StartTimeDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity that represents the possible states in SAREF4EE"</para>
    /// labels<para>"State"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/State">https://saref.etsi.org/saref4ener/State</seealso>
    let State = Prefixed_Name(s4ener, "State") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:TimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The time period associated with load control event data"</para>
    /// labels<para>"Time period"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/TimePeriod">https://saref.etsi.org/saref4ener/TimePeriod</seealso>
    let TimePeriod = Prefixed_Name(s4ener, "TimePeriod") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:TimePeriodDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The duration description for the time period duration temporal entities"</para>
    /// labels<para>"Time period duration description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/TimePeriodDurationDescription">https://saref.etsi.org/saref4ener/TimePeriodDurationDescription</seealso>
    let TimePeriodDurationDescription =
        Prefixed_Name(s4ener, "TimePeriodDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:activateSlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether a slot is used (activateSlot = true) or not (activateSlot = false). SHALL be present if a slot is optional (i.e., the property s4ee:optionalSlot is TRUE), otherwise SHALL be absent (i.e. in case the slot is mandatory)."</para>
    /// labels<para>"activate slot"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/activateSlot">https://saref.etsi.org/saref4ener/activateSlot</seealso>
    let activateSlot = Prefixed_Name(s4ener, "activateSlot") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:activeRepetitionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the current repetition of the sequence of slots. SHALL be present if a power sequence can repeat its sequence of slots (i.e., if s4ee:repetitionTotal is present and has a value &gt; 1). Otherwise, it SHALL be absent. "</para>
    /// labels<para>"active repetition number"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/activeRepetitionNumber">https://saref.etsi.org/saref4ener/activeRepetitionNumber</seealso>
    let activeRepetitionNumber =
        Prefixed_Name(s4ener, "activeRepetitionNumber") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:activeSlotNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the currently active slot number, if the power sequence state is set to 'running' or 'paused'. Otherwise it SHALL be omitted."</para>
    /// labels<para>"active slot number"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/activeSlotNumber">https://saref.etsi.org/saref4ener/activeSlotNumber</seealso>
    let activeSlotNumber = Prefixed_Name(s4ener, "activeSlotNumber") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:alternativesCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the number of alternatives groups provided by a power profile"</para>
    /// labels<para>"alternatives count"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/alternativesCount">https://saref.etsi.org/saref4ener/alternativesCount</seealso>
    let alternativesCount = Prefixed_Name(s4ener, "alternativesCount") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:alternativesGroupID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The endpoint-wide unique identifier for the alternatives group instances provided by a power profile"</para>
    /// labels<para>"alternatives group ID"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/alternativesGroupID">https://saref.etsi.org/saref4ener/alternativesGroupID</seealso>
    let alternativesGroupID =
        Prefixed_Name(s4ener, "alternativesGroupID") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship identifying the ownership of an entity. In particular, a slot belongs to a power sequence, a power sequence belongs to an alternative, an alternative  belongs to a power profile, a power profile belongs to a device.  "</para>
    /// labels<para>"belongs to"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/belongsTo">https://saref.etsi.org/saref4ener/belongsTo</seealso>
    let belongsTo = Prefixed_Name(s4ener, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:brandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides the name of the brand of a device. Useful where the name of the brand and the vendor differs."</para>
    /// labels<para>"brand name"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/brandName">https://saref.etsi.org/saref4ener/brandName</seealso>
    let brandName = Prefixed_Name(s4ener, "brandName") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:cheapest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether a power sequence applies a configuration that minimises the user’s energy bill (if set to TRUE). MAY be present. Absence of this element is equal to the presence with value FALSE. "</para>
    /// labels<para>"cheapest"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/cheapest">https://saref.etsi.org/saref4ener/cheapest</seealso>
    let cheapest = Prefixed_Name(s4ener, "cheapest") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:deviceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a device code for the device as defined by the manufacturer."</para>
    /// labels<para>"device code"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/deviceCode">https://saref.etsi.org/saref4ener/deviceCode</seealso>
    let deviceCode = Prefixed_Name(s4ener, "deviceCode") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:deviceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides the name of the device as defined by the manufacturer."</para>
    /// labels<para>"device name"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/deviceName">https://saref.etsi.org/saref4ener/deviceName</seealso>
    let deviceName = Prefixed_Name(s4ener, "deviceName") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:eventID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used in the Demand Response use case to identify an event"</para>
    /// labels<para>"event ID"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/eventID">https://saref.etsi.org/saref4ener/eventID</seealso>
    let eventID = Prefixed_Name(s4ener, "eventID") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:exposes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a device and its power profile"</para>
    /// labels<para>"exposes"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/exposes">https://saref.etsi.org/saref4ener/exposes</seealso>
    let exposes = Prefixed_Name(s4ener, "exposes") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:greenest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether a power sequence optimises the configuration towards the maximum availability of renewable energy (if set to TRUE). MAY be present. Absence of this element is equal to the presence with value FALSE. "</para>
    /// labels<para>"greenest"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/greenest">https://saref.etsi.org/saref4ener/greenest</seealso>
    let greenest = Prefixed_Name(s4ener, "greenest") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:hardwareRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the hardware revision of the device as defined by the manufacturer."</para>
    /// labels<para>"hardware revision "</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hardwareRevision">https://saref.etsi.org/saref4ener/hardwareRevision</seealso>
    let hardwareRevision = Prefixed_Name(s4ener, "hardwareRevision") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:hasAppliedEventActionConsume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between the state of a load control event consume and the action to be performed as a consequence of this event."</para>
    /// labels<para>"has applied event action consume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasAppliedEventActionConsume">https://saref.etsi.org/saref4ener/hasAppliedEventActionConsume</seealso>
    let hasAppliedEventActionConsume =
        Prefixed_Name(s4ener, "hasAppliedEventActionConsume") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:hasAppliedEventActionProduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between the state of a load control event produce and the action to be performed as a consequence of this event."</para>
    /// labels<para>"has applied event action produce"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasAppliedEventActionProduce">https://saref.etsi.org/saref4ener/hasAppliedEventActionProduce</seealso>
    let hasAppliedEventActionProduce =
        Prefixed_Name(s4ener, "hasAppliedEventActionProduce") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:hasConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the Remote Network Management (RemoteNWM) use case, a relationship between a node in a network (i.e., a s4ee:Device) and its connections (i.e., a s4ee:DeviceConnections). The same s4ee:Device (or node) can have multiple device connections as it can be connected to several networks at the same time."</para>
    /// labels<para>"has connection"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasConnection">https://saref.etsi.org/saref4ener/hasConnection</seealso>
    let hasConnection = Prefixed_Name(s4ener, "hasConnection") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:hasDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a load control event (used to send overload warning severity level and related load control commands) and the device interested by this event."</para>
    /// labels<para>"has device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasDevice">https://saref.etsi.org/saref4ener/hasDevice</seealso>
    let hasDevice = Prefixed_Name(s4ener, "hasDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:hasEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a power sequence and its energy (in terms of value and unit of measure)"</para>
    /// labels<para>"has energy"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasEnergy">https://saref.etsi.org/saref4ener/hasEnergy</seealso>
    let hasEnergy = Prefixed_Name(s4ener, "hasEnergy") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:hasEnergyValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship representing an energy value type"</para>
    /// labels<para>"has energy value type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasEnergyValueType">https://saref.etsi.org/saref4ener/hasEnergyValueType</seealso>
    let hasEnergyValueType = Prefixed_Name(s4ener, "hasEnergyValueType") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:hasEventStateConsume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between the specification of the state of a load control event consume and the value that this state can assume."</para>
    /// labels<para>"has event state consume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasEventStateConsume">https://saref.etsi.org/saref4ener/hasEventStateConsume</seealso>
    let hasEventStateConsume =
        Prefixed_Name(s4ener, "hasEventStateConsume") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:hasEventStateProduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between the specification of the state of a load control event produce and the value that this state can assume."</para>
    /// labels<para>"has event state produce"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasEventStateProduce">https://saref.etsi.org/saref4ener/hasEventStateProduce</seealso>
    let hasEventStateProduce =
        Prefixed_Name(s4ener, "hasEventStateProduce") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:hasExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between an appliance parameter compatibility action and the associated expressions"</para>
    /// labels<para>"has expression"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasExpression">https://saref.etsi.org/saref4ener/hasExpression</seealso>
    let hasExpression = Prefixed_Name(s4ener, "hasExpression") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:hasFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship identifying the functions performed by an actuator level and an actuator switch"</para>
    /// labels<para>"has function"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasFunction">https://saref.etsi.org/saref4ener/hasFunction</seealso>
    let hasFunction = Prefixed_Name(s4ener, "hasFunction") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:hasPowerValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship representing a power value type"</para>
    /// labels<para>"has power value type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasPowerValueType">https://saref.etsi.org/saref4ener/hasPowerValueType</seealso>
    let hasPowerValueType = Prefixed_Name(s4ener, "hasPowerValueType") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:hasValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation representing the value type of an entity"</para>
    /// labels<para>"has value type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/hasValueType">https://saref.etsi.org/saref4ener/hasValueType</seealso>
    let hasValueType = Prefixed_Name(s4ener, "hasValueType") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:isPausable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies if the power sequence is pausable."</para>
    /// labels<para>"is pausable"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/isPausable">https://saref.etsi.org/saref4ener/isPausable</seealso>
    let isPausable = Prefixed_Name(s4ener, "isPausable") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:isStoppable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies if the power sequence is stoppable."</para>
    /// labels<para>"is stoppable"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/isStoppable">https://saref.etsi.org/saref4ener/isStoppable</seealso>
    let isStoppable = Prefixed_Name(s4ener, "isStoppable") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:manufacturerDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A description for the device as defined by the manufacturer."</para>
    /// labels<para>"manufacturer description"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/manufacturerDescription">https://saref.etsi.org/saref4ener/manufacturerDescription</seealso>
    let manufacturerDescription =
        Prefixed_Name(s4ener, "manufacturerDescription") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:manufacturerLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A short label of the device as defined by the manufacturer. "</para>
    /// labels<para>"manufacturer label"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/manufacturerLabel">https://saref.etsi.org/saref4ener/manufacturerLabel</seealso>
    let manufacturerLabel = Prefixed_Name(s4ener, "manufacturerLabel") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:manufacturerNodeIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates a node identification for the device as defined by the manufacturer. This could be used for the identification of a device, even if it was removed from the network and rejoined later with changed node address."</para>
    /// labels<para>"manufacturer node identification"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/manufacturerNodeIdentification">https://saref.etsi.org/saref4ener/manufacturerNodeIdentification</seealso>
    let manufacturerNodeIdentification =
        Prefixed_Name(s4ener, "manufacturerNodeIdentification") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:maxCyclesPerDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"States the maximum amount of starts a power sequence (of a device) allows per day."</para>
    /// labels<para>"max cycles per day"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/maxCyclesPerDay">https://saref.etsi.org/saref4ener/maxCyclesPerDay</seealso>
    let maxCyclesPerDay = Prefixed_Name(s4ener, "maxCyclesPerDay") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:measurementID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Enables the identification of different sensors on one EEBus address."</para>
    /// labels<para>"measurement id"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/measurementID">https://saref.etsi.org/saref4ener/measurementID</seealso>
    let measurementID = Prefixed_Name(s4ener, "measurementID") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:messagingNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifier for one specific message. If a message is marked as obsolete, this number can be used to identify the original message."</para>
    /// labels<para>"messaging number"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/messagingNumber">https://saref.etsi.org/saref4ener/messagingNumber</seealso>
    let messagingNumber = Prefixed_Name(s4ener, "messagingNumber") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:messagingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Indicates the type of the message. Possible values are:
    /// -	logging (used for messages, that shall be stored in a log file)
    /// -	information (messages, that shall be presented to the customer on a display; lower priority)
    /// -	warning (messages, that shall be presented to the customer on a display; medium priority)
    /// -	alarm (messages, that shall be presented to the customer on a display; high priority; if there is an alarm device in the household, it shall generate an alarm)
    /// -	emergency (messages, that shall be presented to the customer on a display; very high priority; if there is an alarm device in the household, it shall generate an alarm; additionally, if possible and configured, an emergency call shall be done)
    /// -	obsolete (previously sent messages, that shall be marked as obsolete)"</para>
    /// labels<para>"messaging type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/messagingType">https://saref.etsi.org/saref4ener/messagingType</seealso>
    let messagingType = Prefixed_Name(s4ener, "messagingType") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:nodeRemoteControllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether the power profile of a device is configured for remote control (e.g., by an energy management system).This refers to the selection chosen by the user on the remote control feature of the device. If nodeRemoteControllable is equal to FALSE, all the supported power sequences shall set the sequenceRemoteControllable property to FALSE. If nodeRemoteControllable is equal to TRUE, at least one power sequence shall be remotely controllable by setting the sequenceRemoteControllable property to TRUE."</para>
    /// labels<para>"node remote controllable"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/nodeRemoteControllable">https://saref.etsi.org/saref4ener/nodeRemoteControllable</seealso>
    let nodeRemoteControllable =
        Prefixed_Name(s4ener, "nodeRemoteControllable") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:optionalSlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether a slot is optional (if set to TRUE). Otherwise, if a slot is mandatory, SHALL be omitted or set to FALSE. Note: This element applies to every repetition of the slot number."</para>
    /// labels<para>"optional slot"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/optionalSlot">https://saref.etsi.org/saref4ener/optionalSlot</seealso>
    let optionalSlot = Prefixed_Name(s4ener, "optionalSlot") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:powerSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Indicates the power source of a device. Possible values are e.g. mainsSinglePhase or battery "</para>
    /// labels<para>"power source"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/powerSource">https://saref.etsi.org/saref4ener/powerSource</seealso>
    let powerSource = Prefixed_Name(s4ener, "powerSource") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:receives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a device (e.g., an appliance or a smart meter) and a load control event"</para>
    /// labels<para>"receives"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/receives">https://saref.etsi.org/saref4ener/receives</seealso>
    let receives = Prefixed_Name(s4ener, "receives") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:repetitionsTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Contains the total number of repetitions, if a power sequence repeats its sequence of slots. Absence of the element is equal to a presence with a value of 0 (zero). SHALL be absent if the value is 1. "</para>
    /// labels<para>"repetition total"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/repetitionsTotal">https://saref.etsi.org/saref4ener/repetitionsTotal</seealso>
    let repetitionsTotal = Prefixed_Name(s4ener, "repetitionsTotal") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:sequenceID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a unique power sequence identifier for a certain device"</para>
    /// labels<para>"sequence ID"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/sequenceID">https://saref.etsi.org/saref4ener/sequenceID</seealso>
    let sequenceID = Prefixed_Name(s4ener, "sequenceID") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:sequenceRemoteControllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denotes whether a power sequence is modifiable (if value is TRUE) or not (if value is FALSE). Modifiability is required to configure power sequences and slots. It is also required to change a power sequence state."</para>
    /// labels<para>"sequence remote controllable"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/sequenceRemoteControllable">https://saref.etsi.org/saref4ener/sequenceRemoteControllable</seealso>
    let sequenceRemoteControllable =
        Prefixed_Name(s4ener, "sequenceRemoteControllable") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the serial number of a device as defined by the manufacturer. Usually the same as printed on the case."</para>
    /// labels<para>"serial number"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/serialNumber">https://saref.etsi.org/saref4ener/serialNumber</seealso>
    let serialNumber = Prefixed_Name(s4ener, "serialNumber") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:slotActivated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If a slot is optional, represents the current status of the slot (true = the slot will be executed, false = the slot will not be executed). If the slot is not optional, this element SHALL be absent."</para>
    /// labels<para>"slot activated"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/slotActivated">https://saref.etsi.org/saref4ener/slotActivated</seealso>
    let slotActivated = Prefixed_Name(s4ener, "slotActivated") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:slotNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a unique slot identifier for a certain power sequence"</para>
    /// labels<para>"slot number"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/slotNumber">https://saref.etsi.org/saref4ener/slotNumber</seealso>
    let slotNumber = Prefixed_Name(s4ener, "slotNumber") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:softwareRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the software revision of a device as defined by the manufacturer."</para>
    /// labels<para>"software revision"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/softwareRevision">https://saref.etsi.org/saref4ener/softwareRevision</seealso>
    let softwareRevision = Prefixed_Name(s4ener, "softwareRevision") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:supportsReselection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If set toTRUE, the power profile of a device does not restrict the number of power sequence re-selections by the CEM, i.e. within a given alternative the CEM may first choose one power sequence, alter the selection by configuring another sequence later on, then alter the selection again, etc. (provided the process rules and data still permit configuration). If supportsReselection is set to FALSE, the device permits the CEM to select a power sequence of an alternative only once."</para>
    /// labels<para>"supports reselection"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/supportsReselection">https://saref.etsi.org/saref4ener/supportsReselection</seealso>
    let supportsReselection =
        Prefixed_Name(s4ener, "supportsReselection") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:supportsSingleSlotSchedulingOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"If set toTRUE, the power profile of a device does NOT permit the modification of more than one slot per configuration command."</para>
    /// labels<para>"supports single slot scheduling only"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/supportsSingleSlotSchedulingOnly">https://saref.etsi.org/saref4ener/supportsSingleSlotSchedulingOnly</seealso>
    let supportsSingleSlotSchedulingOnly =
        Prefixed_Name(s4ener, "supportsSingleSlotSchedulingOnly") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:taskIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the task identifier of the power sequence."</para>
    /// labels<para>"task identifier"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/taskIdentifier">https://saref.etsi.org/saref4ener/taskIdentifier</seealso>
    let taskIdentifier = Prefixed_Name(s4ener, "taskIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:totalSequencesCountMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the total number of power sequences supported by the power profile of a device"</para>
    /// labels<para>"total sequences count max"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/totalSequencesCountMax">https://saref.etsi.org/saref4ener/totalSequencesCountMax</seealso>
    let totalSequencesCountMax =
        Prefixed_Name(s4ener, "totalSequencesCountMax") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:triggersEventActionConsume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a load control event and the consume action triggered by this event"</para>
    /// labels<para>"triggers event action consume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/triggersEventActionConsume">https://saref.etsi.org/saref4ener/triggersEventActionConsume</seealso>
    let triggersEventActionConsume =
        Prefixed_Name(s4ener, "triggersEventActionConsume") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:triggersEventActionProduce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relationship between a load control event and the produce action triggered by this event"</para>
    /// labels<para>"triggers event action produce"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/triggersEventActionProduce">https://saref.etsi.org/saref4ener/triggersEventActionProduce</seealso>
    let triggersEventActionProduce =
        Prefixed_Name(s4ener, "triggersEventActionProduce") |> PrefixedName

    /// <summary>
    ///   <para>s4ener:v1.1.2/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/v1.1.2/">https://saref.etsi.org/saref4ener/v1.1.2/</seealso>
    let ``v1.1.2/`` = Prefixed_Name(s4ener, "v1.1.2/") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:valueSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the source (origin/foundation) of the measurement forecasted values for a power sequence. If absent, the source is undefined. Remark: This element shall express the reliability of the forecast."</para>
    /// labels<para>"value source"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/valueSource">https://saref.etsi.org/saref4ener/valueSource</seealso>
    let valueSource = Prefixed_Name(s4ener, "valueSource") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:valueTendency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether the tendency of a measurement is rising, stable or falling."</para>
    /// labels<para>"value tendency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/valueTendency">https://saref.etsi.org/saref4ener/valueTendency</seealso>
    let valueTendency = Prefixed_Name(s4ener, "valueTendency") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:vendorCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a code for the vendor of the device as defined by the manufacturer."</para>
    /// labels<para>"vendor code"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/vendorCode">https://saref.etsi.org/saref4ener/vendorCode</seealso>
    let vendorCode = Prefixed_Name(s4ener, "vendorCode") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:vendorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides the name of the vendor of the device as defined by the manufacturer."</para>
    /// labels<para>"vendor name"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/vendorName">https://saref.etsi.org/saref4ener/vendorName</seealso>
    let vendorName = Prefixed_Name(s4ener, "vendorName") |> PrefixedName
    /// <summary>
    ///   <para>s4ener:xsdDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is added to the  time:DurationDescription class to allow to express time duration also as xsd:duration. This is necessary because in the EEBus/E@h model time is always expressed as xsd:duration. We use this property to express the following time information in the EEBus/E@h model:
    ///
    /// - the startTime of the power sequence (in the PowerSequence class). SHALL be present
    /// - the endTime of the power sequence (in the PowerSequence class). If the value is available, it SHALL be denoted here. Otherwise the element SHALL be omitted.
    /// - the startTime of measurement as absolute or relative value (in the Measurement class).
    /// - the endTime of measurement as absolute or relative value (in the Measurement class).
    ///
    /// The duration is expected to be described as in xsd:duration"</para>
    /// labels<para>"duration in xsd "</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4ener/xsdDuration">https://saref.etsi.org/saref4ener/xsdDuration</seealso>
    let xsdDuration = Prefixed_Name(s4ener, "xsdDuration") |> PrefixedName
