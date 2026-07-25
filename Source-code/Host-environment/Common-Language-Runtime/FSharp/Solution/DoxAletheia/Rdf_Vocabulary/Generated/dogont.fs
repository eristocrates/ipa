namespace http.elite.polito.it.ontologies.dogont.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dogont =
    let _namespace_iri = Namespace_Iri dogont |> NamespaceIRI

    /// <summary>
    ///   <para>dogont:.owl#BTicinoProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BTicinoProperty">http://elite.polito.it/ontologies/dogont.owl#BTicinoProperty</seealso>
    let ``_.owl#BTicinoProperty`` =
        Prefixed_Name(dogont, ".owl#BTicinoProperty") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZWaveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZWaveProperty">http://elite.polito.it/ontologies/dogont.owl#ZWaveProperty</seealso>
    let ``_.owl#ZWaveProperty`` =
        Prefixed_Name(dogont, ".owl#ZWaveProperty") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePushLinkAuthenticationStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePushLinkAuthenticationStateValue">http://elite.polito.it/ontologies/dogont.owl#ActivePushLinkAuthenticationStateValue</seealso>
    let ``_.owl#ActivePushLinkAuthenticationStateValue`` =
        Prefixed_Name(dogont, ".owl#ActivePushLinkAuthenticationStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CDStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CDStateValue">http://elite.polito.it/ontologies/dogont.owl#CDStateValue</seealso>
    let ``_.owl#CDStateValue`` =
        Prefixed_Name(dogont, ".owl#CDStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CloseStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CloseStateValue">http://elite.polito.it/ontologies/dogont.owl#CloseStateValue</seealso>
    let ``_.owl#CloseStateValue`` =
        Prefixed_Name(dogont, ".owl#CloseStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CoolingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoolingStateValue">http://elite.polito.it/ontologies/dogont.owl#CoolingStateValue</seealso>
    let ``_.owl#CoolingStateValue`` =
        Prefixed_Name(dogont, ".owl#CoolingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisassociatingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisassociatingStateValue">http://elite.polito.it/ontologies/dogont.owl#DisassociatingStateValue</seealso>
    let ``_.owl#DisassociatingStateValue`` =
        Prefixed_Name(dogont, ".owl#DisassociatingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EmittingMicrowavesStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesStateValue">http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesStateValue</seealso>
    let ``_.owl#EmittingMicrowavesStateValue`` =
        Prefixed_Name(dogont, ".owl#EmittingMicrowavesStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FailureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FailureStateValue">http://elite.polito.it/ontologies/dogont.owl#FailureStateValue</seealso>
    let ``_.owl#FailureStateValue`` =
        Prefixed_Name(dogont, ".owl#FailureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FreeStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FreeStateValue">http://elite.polito.it/ontologies/dogont.owl#FreeStateValue</seealso>
    let ``_.owl#FreeStateValue`` =
        Prefixed_Name(dogont, ".owl#FreeStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovingStateValue">http://elite.polito.it/ontologies/dogont.owl#MovingStateValue</seealso>
    let ``_.owl#MovingStateValue`` =
        Prefixed_Name(dogont, ".owl#MovingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NeedingAuthenticationStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NeedingAuthenticationStateValue">http://elite.polito.it/ontologies/dogont.owl#NeedingAuthenticationStateValue</seealso>
    let ``_.owl#NeedingAuthenticationStateValue`` =
        Prefixed_Name(dogont, ".owl#NeedingAuthenticationStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotEmittingMicrowavesStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesStateValue">http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesStateValue</seealso>
    let ``_.owl#NotEmittingMicrowavesStateValue`` =
        Prefixed_Name(dogont, ".owl#NotEmittingMicrowavesStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotMovingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotMovingStateValue">http://elite.polito.it/ontologies/dogont.owl#NotMovingStateValue</seealso>
    let ``_.owl#NotMovingStateValue`` =
        Prefixed_Name(dogont, ".owl#NotMovingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OffStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OffStateValue">http://elite.polito.it/ontologies/dogont.owl#OffStateValue</seealso>
    let ``_.owl#OffStateValue`` =
        Prefixed_Name(dogont, ".owl#OffStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnStateValue">http://elite.polito.it/ontologies/dogont.owl#OnStateValue</seealso>
    let ``_.owl#OnStateValue`` =
        Prefixed_Name(dogont, ".owl#OnStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayStateValue">http://elite.polito.it/ontologies/dogont.owl#PlayStateValue</seealso>
    let ``_.owl#PlayStateValue`` =
        Prefixed_Name(dogont, ".owl#PlayStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresentStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresentStateValue">http://elite.polito.it/ontologies/dogont.owl#PresentStateValue</seealso>
    let ``_.owl#PresentStateValue`` =
        Prefixed_Name(dogont, ".owl#PresentStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RunningStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RunningStateValue">http://elite.polito.it/ontologies/dogont.owl#RunningStateValue</seealso>
    let ``_.owl#RunningStateValue`` =
        Prefixed_Name(dogont, ".owl#RunningStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StandByStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StandByStateValue">http://elite.polito.it/ontologies/dogont.owl#StandByStateValue</seealso>
    let ``_.owl#StandByStateValue`` =
        Prefixed_Name(dogont, ".owl#StandByStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Tape2StateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Tape2StateValue">http://elite.polito.it/ontologies/dogont.owl#Tape2StateValue</seealso>
    let ``_.owl#Tape2StateValue`` =
        Prefixed_Name(dogont, ".owl#Tape2StateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TunerStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TunerStateValue">http://elite.polito.it/ontologies/dogont.owl#TunerStateValue</seealso>
    let ``_.owl#TunerStateValue`` =
        Prefixed_Name(dogont, ".owl#TunerStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SecuritySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Security system for detecting dangerous situation and intrusion</para>
    /// labels<para>SecuritySystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SecuritySystem">http://elite.polito.it/ontologies/dogont.owl#SecuritySystem</seealso>
    let ``_.owl#SecuritySystem`` =
        Prefixed_Name(dogont, ".owl#SecuritySystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FireSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>System that detects the presence of fire</para>
    /// labels<para>FireSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FireSystem">http://elite.polito.it/ontologies/dogont.owl#FireSystem</seealso>
    let ``_.owl#FireSystem`` = Prefixed_Name(dogont, ".owl#FireSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FloodSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>System that detects the presence of flood</para>
    /// labels<para>FloodSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FloodSystem">http://elite.polito.it/ontologies/dogont.owl#FloodSystem</seealso>
    let ``_.owl#FloodSystem`` =
        Prefixed_Name(dogont, ".owl#FloodSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>System that detects the presence of gas</para>
    /// labels<para>GasSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasSystem">http://elite.polito.it/ontologies/dogont.owl#GasSystem</seealso>
    let ``_.owl#GasSystem`` = Prefixed_Name(dogont, ".owl#GasSystem") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Acoustic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Acoustic">http://elite.polito.it/ontologies/dogont.owl#Acoustic</seealso>
    let ``_.owl#Acoustic`` = Prefixed_Name(dogont, ".owl#Acoustic") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ActiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#EnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#EnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActiveEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyStateValue</seealso>
    let ``_.owl#ActiveEnergyStateValue`` =
        Prefixed_Name(dogont, ".owl#ActiveEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ContinuousValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ContinuousValue">http://elite.polito.it/ontologies/dogont.owl#ContinuousValue</seealso>
    let ``_.owl#ContinuousValue`` =
        Prefixed_Name(dogont, ".owl#ContinuousValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ChannelStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ChannelStateValue">http://elite.polito.it/ontologies/dogont.owl#ChannelStateValue</seealso>
    let ``_.owl#ChannelStateValue`` =
        Prefixed_Name(dogont, ".owl#ChannelStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureStateValue">http://elite.polito.it/ontologies/dogont.owl#PressureStateValue</seealso>
    let ``_.owl#PressureStateValue`` =
        Prefixed_Name(dogont, ".owl#PressureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AirConditioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A system that keeps air cool and dry</para>
    /// labels<para>AirConditioningSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AirConditioningSystem">http://elite.polito.it/ontologies/dogont.owl#AirConditioningSystem</seealso>
    let ``_.owl#AirConditioningSystem`` =
        Prefixed_Name(dogont, ".owl#AirConditioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provide the actual state to controllable things</para>
    /// labels<para>hasState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasState">http://elite.polito.it/ontologies/dogont.owl#hasState</seealso>
    let ``_.owl#hasState`` = Prefixed_Name(dogont, ".owl#hasState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Notification: on - off</para>
    /// labels<para>OnOffNotificationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffNotificationFunctionality</seealso>
    let ``_.owl#OnOffNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#OnOffNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThermostatControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionalities for the regulation of temperature</para>
    /// labels<para>TemperatureRegulationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThermostatControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThermostatControlFunctionality</seealso>
    let ``_.owl#ThermostatControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThermostatControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Pressure Sensor device measures and periodically reports the pressure of a liquid (typically water)</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureSensor">http://elite.polito.it/ontologies/dogont.owl#PressureSensor</seealso>
    let ``_.owl#PressureSensor`` =
        Prefixed_Name(dogont, ".owl#PressureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Pump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Pump device is a pump that may have variable speed. It may have optional built-in sensors and a regulation mechanism. It is typically used for pumping water. Derives from ZigBee HA specifications.</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Pump">http://elite.polito.it/ontologies/dogont.owl#Pump</seealso>
    let ``_.owl#Pump`` = Prefixed_Name(dogont, ".owl#Pump") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Computer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A machine for performing calculations automatically, work and play</para>
    /// labels<para>Computer</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Computer">http://elite.polito.it/ontologies/dogont.owl#Computer</seealso>
    let ``_.owl#Computer`` = Prefixed_Name(dogont, ".owl#Computer") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Entertainment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A diversion that holds the attention</para>
    /// labels<para>Entertainment</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Entertainment">http://elite.polito.it/ontologies/dogont.owl#Entertainment</seealso>
    let ``_.owl#Entertainment`` =
        Prefixed_Name(dogont, ".owl#Entertainment") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Appliances for communicate</para>
    /// labels<para>Communication</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Communication">http://elite.polito.it/ontologies/dogont.owl#Communication</seealso>
    let ``_.owl#Communication`` =
        Prefixed_Name(dogont, ".owl#Communication") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Fan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device for creating a current of air</para>
    /// labels<para>Fan</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Fan">http://elite.polito.it/ontologies/dogont.owl#Fan</seealso>
    let ``_.owl#Fan`` = Prefixed_Name(dogont, ".owl#Fan") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Printer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Output device that prints</para>
    /// labels<para>Printer</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Printer">http://elite.polito.it/ontologies/dogont.owl#Printer</seealso>
    let ``_.owl#Printer`` = Prefixed_Name(dogont, ".owl#Printer") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CoffeeMaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A kitchen appliance for brewing coffee automatically</para>
    /// labels<para>CoffeeMaker</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoffeeMaker">http://elite.polito.it/ontologies/dogont.owl#CoffeeMaker</seealso>
    let ``_.owl#CoffeeMaker`` =
        Prefixed_Name(dogont, ".owl#CoffeeMaker") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AlertNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AlertNotification">http://elite.polito.it/ontologies/dogont.owl#AlertNotification</seealso>
    let ``_.owl#AlertNotification`` =
        Prefixed_Name(dogont, ".owl#AlertNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnableDisableGasFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnableDisableGasFunctionality">http://elite.polito.it/ontologies/dogont.owl#EnableDisableGasFunctionality</seealso>
    let ``_.owl#EnableDisableGasFunctionality`` =
        Prefixed_Name(dogont, ".owl#EnableDisableGasFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnableGasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnableGasCommand">http://elite.polito.it/ontologies/dogont.owl#EnableGasCommand</seealso>
    let ``_.owl#EnableGasCommand`` =
        Prefixed_Name(dogont, ".owl#EnableGasCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ModbusComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModbusComponent">http://elite.polito.it/ontologies/dogont.owl#ModbusComponent</seealso>
    let ``_.owl#ModbusComponent`` =
        Prefixed_Name(dogont, ".owl#ModbusComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ModbusNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModbusNotification">http://elite.polito.it/ontologies/dogont.owl#ModbusNotification</seealso>
    let ``_.owl#ModbusNotification`` =
        Prefixed_Name(dogont, ".owl#ModbusNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkSpecificStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificStateValue">http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificStateValue</seealso>
    let ``_.owl#NetworkSpecificStateValue`` =
        Prefixed_Name(dogont, ".owl#NetworkSpecificStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresenceNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresenceNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PresenceNotificationFunctionality</seealso>
    let ``_.owl#PresenceNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#PresenceNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpDownNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpDownNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#UpDownNotificationFunctionality</seealso>
    let ``_.owl#UpDownNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#UpDownNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OccupancyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OccupancyState">http://elite.polito.it/ontologies/dogont.owl#OccupancyState</seealso>
    let ``_.owl#OccupancyState`` =
        Prefixed_Name(dogont, ".owl#OccupancyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresenceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresenceState">http://elite.polito.it/ontologies/dogont.owl#PresenceState</seealso>
    let ``_.owl#PresenceState`` =
        Prefixed_Name(dogont, ".owl#PresenceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovingUpDownState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovingUpDownState">http://elite.polito.it/ontologies/dogont.owl#MovingUpDownState</seealso>
    let ``_.owl#MovingUpDownState`` =
        Prefixed_Name(dogont, ".owl#MovingUpDownState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ceilingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ceilingOf">http://elite.polito.it/ontologies/dogont.owl#ceilingOf</seealso>
    let ``_.owl#ceilingOf`` = Prefixed_Name(dogont, ".owl#ceilingOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#commandOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#commandOf">http://elite.polito.it/ontologies/dogont.owl#commandOf</seealso>
    let ``_.owl#commandOf`` = Prefixed_Name(dogont, ".owl#commandOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#IPAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The IP address of the gateway</para>
    /// labels<para>IPAddress</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IPAddress">http://elite.polito.it/ontologies/dogont.owl#IPAddress</seealso>
    let ``_.owl#IPAddress`` = Prefixed_Name(dogont, ".owl#IPAddress") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#commandParamName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#commandParamName">http://elite.polito.it/ontologies/dogont.owl#commandParamName</seealso>
    let ``_.owl#commandParamName`` =
        Prefixed_Name(dogont, ".owl#commandParamName") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#nParams</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#nParams">http://elite.polito.it/ontologies/dogont.owl#nParams</seealso>
    let ``_.owl#nParams`` = Prefixed_Name(dogont, ".owl#nParams") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#notificationParamName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#notificationParamName">http://elite.polito.it/ontologies/dogont.owl#notificationParamName</seealso>
    let ``_.owl#notificationParamName`` =
        Prefixed_Name(dogont, ".owl#notificationParamName") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#port</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The port of the gateway</para>
    /// labels<para>port</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#port">http://elite.polito.it/ontologies/dogont.owl#port</seealso>
    let ``_.owl#port`` = Prefixed_Name(dogont, ".owl#port") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#weekDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#weekDay">http://elite.polito.it/ontologies/dogont.owl#weekDay</seealso>
    let ``_.owl#weekDay`` = Prefixed_Name(dogont, ".owl#weekDay") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotDetectedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotDetectedStateValue">http://elite.polito.it/ontologies/dogont.owl#NotDetectedStateValue</seealso>
    let ``_.owl#NotDetectedStateValue`` =
        Prefixed_Name(dogont, ".owl#NotDetectedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotPresentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotPresentState">http://elite.polito.it/ontologies/dogont.owl#NotPresentState</seealso>
    let ``_.owl#NotPresentState`` =
        Prefixed_Name(dogont, ".owl#NotPresentState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OccupiedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OccupiedStateValue">http://elite.polito.it/ontologies/dogont.owl#OccupiedStateValue</seealso>
    let ``_.owl#OccupiedStateValue`` =
        Prefixed_Name(dogont, ".owl#OccupiedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenStateValue">http://elite.polito.it/ontologies/dogont.owl#OpenStateValue</seealso>
    let ``_.owl#OpenStateValue`` =
        Prefixed_Name(dogont, ".owl#OpenStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PauseStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PauseStateValue">http://elite.polito.it/ontologies/dogont.owl#PauseStateValue</seealso>
    let ``_.owl#PauseStateValue`` =
        Prefixed_Name(dogont, ".owl#PauseStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ProgrammedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ProgrammedStateValue">http://elite.polito.it/ontologies/dogont.owl#ProgrammedStateValue</seealso>
    let ``_.owl#ProgrammedStateValue`` =
        Prefixed_Name(dogont, ".owl#ProgrammedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestTripleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestTripleStateValue">http://elite.polito.it/ontologies/dogont.owl#RestTripleStateValue</seealso>
    let ``_.owl#RestTripleStateValue`` =
        Prefixed_Name(dogont, ".owl#RestTripleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperFreezingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingStateValue">http://elite.polito.it/ontologies/dogont.owl#SuperFreezingStateValue</seealso>
    let ``_.owl#SuperFreezingStateValue`` =
        Prefixed_Name(dogont, ".owl#SuperFreezingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperHeatingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingStateValue">http://elite.polito.it/ontologies/dogont.owl#SuperHeatingStateValue</seealso>
    let ``_.owl#SuperHeatingStateValue`` =
        Prefixed_Name(dogont, ".owl#SuperHeatingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpTripleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpTripleStateValue">http://elite.polito.it/ontologies/dogont.owl#UpTripleStateValue</seealso>
    let ``_.owl#UpTripleStateValue`` =
        Prefixed_Name(dogont, ".owl#UpTripleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AccessControlSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>System that provides security about access</para>
    /// labels<para>AccessControlSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AccessControlSystem">http://elite.polito.it/ontologies/dogont.owl#AccessControlSystem</seealso>
    let ``_.owl#AccessControlSystem`` =
        Prefixed_Name(dogont, ".owl#AccessControlSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#isIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates in which building environment is contained an object, e.g. the lamp5 isIn Kitchen</para>
    /// labels<para>isIn</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#isIn">http://elite.polito.it/ontologies/dogont.owl#isIn</seealso>
    let ``_.owl#isIn`` = Prefixed_Name(dogont, ".owl#isIn") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerDelivery">http://elite.polito.it/ontologies/dogont.owl#PowerDelivery</seealso>
    let ``_.owl#PowerDelivery`` =
        Prefixed_Name(dogont, ".owl#PowerDelivery") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for grouping all electrically powered sensors</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Sensor">http://elite.polito.it/ontologies/dogont.owl#Sensor</seealso>
    let ``_.owl#Sensor`` = Prefixed_Name(dogont, ".owl#Sensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteValue">http://elite.polito.it/ontologies/dogont.owl#DiscreteValue</seealso>
    let ``_.owl#DiscreteValue`` =
        Prefixed_Name(dogont, ".owl#DiscreteValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#ActiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementFunctionality</seealso>
    let ``_.owl#EnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#EnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelStateValue">http://elite.polito.it/ontologies/dogont.owl#LevelStateValue</seealso>
    let ``_.owl#LevelStateValue`` =
        Prefixed_Name(dogont, ".owl#LevelStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactiveEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyStateValue</seealso>
    let ``_.owl#ReactiveEnergyStateValue`` =
        Prefixed_Name(dogont, ".owl#ReactiveEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementFunctionality</seealso>
    let ``_.owl#ActivePowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ActivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#PowerMeasurementFunctionality</seealso>
    let ``_.owl#PowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#PowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ActivePowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ActivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricPowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ElectricPowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ElectricPowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementState</seealso>
    let ``_.owl#ActivePowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#ActivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricPowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementState</seealso>
    let ``_.owl#ElectricPowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#ElectricPowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThermostatNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The thermostat request notification, requires a device having the thermostat control functionality to increase, set or decrease the current temperature. Derives from ZigBee HA (slightly modified...)</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThermostatNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThermostatNotificationFunctionality</seealso>
    let ``_.owl#ThermostatNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThermostatNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provide functionalities to controllable things</para>
    /// labels<para>hasFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasFunctionality">http://elite.polito.it/ontologies/dogont.owl#hasFunctionality</seealso>
    let ``_.owl#hasFunctionality`` =
        Prefixed_Name(dogont, ".owl#hasFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionality: turn on - turn off</para>
    /// labels<para>OnOffFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffFunctionality</seealso>
    let ``_.owl#OnOffFunctionality`` =
        Prefixed_Name(dogont, ".owl#OnOffFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HVACSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Heating Ventilating and Air Conditioning system</para>
    /// labels<para>HVACSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HVACSystem">http://elite.polito.it/ontologies/dogont.owl#HVACSystem</seealso>
    let ``_.owl#HVACSystem`` = Prefixed_Name(dogont, ".owl#HVACSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VentilatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VentilatingSystem">http://elite.polito.it/ontologies/dogont.owl#VentilatingSystem</seealso>
    let ``_.owl#VentilatingSystem`` =
        Prefixed_Name(dogont, ".owl#VentilatingSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Thermostat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Thermostat">http://elite.polito.it/ontologies/dogont.owl#Thermostat</seealso>
    let ``_.owl#Thermostat`` = Prefixed_Name(dogont, ".owl#Thermostat") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Utility to warm a building</para>
    /// labels<para>HeatingSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingSystem">http://elite.polito.it/ontologies/dogont.owl#HeatingSystem</seealso>
    let ``_.owl#HeatingSystem`` =
        Prefixed_Name(dogont, ".owl#HeatingSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleFlowSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Flow  Sensor device measures and periodically reports the flow rate of a liquid (typically water)</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleFlowSensor">http://elite.polito.it/ontologies/dogont.owl#SingleFlowSensor</seealso>
    let ``_.owl#SingleFlowSensor`` =
        Prefixed_Name(dogont, ".owl#SingleFlowSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingAndCoolingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Heating and Cooling Unit device can heat or cool a space in a house. It is not mandatory to provide both functionalities. It may be an indoor air handler. Derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnit">http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnit</seealso>
    let ``_.owl#HeatingAndCoolingUnit`` =
        Prefixed_Name(dogont, ".owl#HeatingAndCoolingUnit") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AlarmClock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A clock that wakes sleeper at preset time</para>
    /// labels<para>AlarmClock</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AlarmClock">http://elite.polito.it/ontologies/dogont.owl#AlarmClock</seealso>
    let ``_.owl#AlarmClock`` = Prefixed_Name(dogont, ".owl#AlarmClock") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasNotification">http://elite.polito.it/ontologies/dogont.owl#hasNotification</seealso>
    let ``_.owl#hasNotification`` =
        Prefixed_Name(dogont, ".owl#hasNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleValuedNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete notification with exactly one values</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleValuedNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SingleValuedNotificationFunctionality</seealso>
    let ``_.owl#SingleValuedNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SingleValuedNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AnsweringMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electronic device that answers the telephone and records messages</para>
    /// labels<para>AnsweringMachine</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AnsweringMachine">http://elite.polito.it/ontologies/dogont.owl#AnsweringMachine</seealso>
    let ``_.owl#AnsweringMachine`` =
        Prefixed_Name(dogont, ".owl#AnsweringMachine") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Appliance that send text and document</para>
    /// labels<para>Fax</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Fax">http://elite.polito.it/ontologies/dogont.owl#Fax</seealso>
    let ``_.owl#Fax`` = Prefixed_Name(dogont, ".owl#Fax") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Interphone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A telephonic intercommunication system linking different rooms in a building</para>
    /// labels<para>Interphone</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Interphone">http://elite.polito.it/ontologies/dogont.owl#Interphone</seealso>
    let ``_.owl#Interphone`` = Prefixed_Name(dogont, ".owl#Interphone") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Appliance to comunicate with other person</para>
    /// labels<para>Phone</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Phone">http://elite.polito.it/ontologies/dogont.owl#Phone</seealso>
    let ``_.owl#Phone`` = Prefixed_Name(dogont, ".owl#Phone") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementState</seealso>
    let ``_.owl#ApparentPowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#ApparentPowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeter">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeter</seealso>
    let ``_.owl#ApparentPowerMeter`` =
        Prefixed_Name(dogont, ".owl#ApparentPowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerStateValue">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerStateValue</seealso>
    let ``_.owl#ApparentPowerStateValue`` =
        Prefixed_Name(dogont, ".owl#ApparentPowerStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApplianceCycleTimingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApplianceCycleTimingNotification">http://elite.polito.it/ontologies/dogont.owl#ApplianceCycleTimingNotification</seealso>
    let ``_.owl#ApplianceCycleTimingNotification`` =
        Prefixed_Name(dogont, ".owl#ApplianceCycleTimingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EndTimeChangedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EndTimeChangedNotification">http://elite.polito.it/ontologies/dogont.owl#EndTimeChangedNotification</seealso>
    let ``_.owl#EndTimeChangedNotification`` =
        Prefixed_Name(dogont, ".owl#EndTimeChangedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApplianceManagementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApplianceManagementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ApplianceManagementFunctionality</seealso>
    let ``_.owl#ApplianceManagementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ApplianceManagementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeleteApplianceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeleteApplianceCommand">http://elite.polito.it/ontologies/dogont.owl#DeleteApplianceCommand</seealso>
    let ``_.owl#DeleteApplianceCommand`` =
        Prefixed_Name(dogont, ".owl#DeleteApplianceCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasCommand">http://elite.polito.it/ontologies/dogont.owl#hasCommand</seealso>
    let ``_.owl#hasCommand`` = Prefixed_Name(dogont, ".owl#hasCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#InstallApplianceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#InstallApplianceCommand">http://elite.polito.it/ontologies/dogont.owl#InstallApplianceCommand</seealso>
    let ``_.owl#InstallApplianceCommand`` =
        Prefixed_Name(dogont, ".owl#InstallApplianceCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derives from the general cluster functionalities defined in ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkFunctionality">http://elite.polito.it/ontologies/dogont.owl#NetworkFunctionality</seealso>
    let ``_.owl#NetworkFunctionality`` =
        Prefixed_Name(dogont, ".owl#NetworkFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NonParametricNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NonParametricNotification">http://elite.polito.it/ontologies/dogont.owl#NonParametricNotification</seealso>
    let ``_.owl#NonParametricNotification`` =
        Prefixed_Name(dogont, ".owl#NonParametricNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartApplianceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartApplianceNotification">http://elite.polito.it/ontologies/dogont.owl#StartApplianceNotification</seealso>
    let ``_.owl#StartApplianceNotification`` =
        Prefixed_Name(dogont, ".owl#StartApplianceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopApplianceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopApplianceNotification">http://elite.polito.it/ontologies/dogont.owl#StopApplianceNotification</seealso>
    let ``_.owl#StopApplianceNotification`` =
        Prefixed_Name(dogont, ".owl#StopApplianceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Appliances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Durable goods for home or office use</para>
    /// labels<para>Appliances</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Appliances">http://elite.polito.it/ontologies/dogont.owl#Appliances</seealso>
    let ``_.owl#Appliances`` = Prefixed_Name(dogont, ".owl#Appliances") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Architectural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All the architectural elements that compose the environment</para>
    /// labels<para>Architectural</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Architectural">http://elite.polito.it/ontologies/dogont.owl#Architectural</seealso>
    let ``_.owl#Architectural`` =
        Prefixed_Name(dogont, ".owl#Architectural") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UnControllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All building things that can't be controlled by domotic system</para>
    /// labels<para>UnControllable</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UnControllable">http://elite.polito.it/ontologies/dogont.owl#UnControllable</seealso>
    let ``_.owl#UnControllable`` =
        Prefixed_Name(dogont, ".owl#UnControllable") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Furniture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Furnishings that make a room or other area ready for occupancy</para>
    /// labels<para>Furniture</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Furniture">http://elite.polito.it/ontologies/dogont.owl#Furniture</seealso>
    let ``_.owl#Furniture`` = Prefixed_Name(dogont, ".owl#Furniture") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Armchair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Chair with a support on each side for arms</para>
    /// labels<para>Armchair</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Armchair">http://elite.polito.it/ontologies/dogont.owl#Armchair</seealso>
    let ``_.owl#Armchair`` = Prefixed_Name(dogont, ".owl#Armchair") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Awning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A canopy made of canvas to shelter people or things from rain or sun.</para>
    /// labels<para>Awning</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Awning">http://elite.polito.it/ontologies/dogont.owl#Awning</seealso>
    let ``_.owl#Awning`` = Prefixed_Name(dogont, ".owl#Awning") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Wardrobe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tall piece of furniture that provides storage space for clothes</para>
    /// labels<para>Wardrobe</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Wardrobe">http://elite.polito.it/ontologies/dogont.owl#Wardrobe</seealso>
    let ``_.owl#Wardrobe`` = Prefixed_Name(dogont, ".owl#Wardrobe") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Closet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Confine to a small space.</para>
    /// labels<para>Closet</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Closet">http://elite.polito.it/ontologies/dogont.owl#Closet</seealso>
    let ``_.owl#Closet`` = Prefixed_Name(dogont, ".owl#Closet") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Sofa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An upholstered seat for more than one person</para>
    /// labels<para>Sofa</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Sofa">http://elite.polito.it/ontologies/dogont.owl#Sofa</seealso>
    let ``_.owl#Sofa`` = Prefixed_Name(dogont, ".owl#Sofa") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Cupboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A small room (or recess) or cabinet used for storage space</para>
    /// labels<para>Cupboard</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Cupboard">http://elite.polito.it/ontologies/dogont.owl#Cupboard</seealso>
    let ``_.owl#Cupboard`` = Prefixed_Name(dogont, ".owl#Cupboard") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Shade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Shade object, the name includes an underscore sign only for distinguishing the name from the shade actuator, whose name is directly mapped from ZigBee</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Shade">http://elite.polito.it/ontologies/dogont.owl#Shade</seealso>
    let ``_.owl#Shade`` = Prefixed_Name(dogont, ".owl#Shade") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Chair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A seat for one person, with a support for the back.</para>
    /// labels<para>Chair</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Chair">http://elite.polito.it/ontologies/dogont.owl#Chair</seealso>
    let ``_.owl#Chair`` = Prefixed_Name(dogont, ".owl#Chair") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Bed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Piece of furniture that provides a place to sleep.</para>
    /// labels<para>Bed</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bed">http://elite.polito.it/ontologies/dogont.owl#Bed</seealso>
    let ``_.owl#Bed`` = Prefixed_Name(dogont, ".owl#Bed") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Drawer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A boxlike container in a piece of furniture; made so as to slide in and out</para>
    /// labels<para>Drawer</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Drawer">http://elite.polito.it/ontologies/dogont.owl#Drawer</seealso>
    let ``_.owl#Drawer`` = Prefixed_Name(dogont, ".owl#Drawer") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A piece of furniture having a smooth flat top that is usually supported by one or more vertical legs</para>
    /// labels<para>Table</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Table">http://elite.polito.it/ontologies/dogont.owl#Table</seealso>
    let ``_.owl#Table`` = Prefixed_Name(dogont, ".owl#Table") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociateCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociateCommand">http://elite.polito.it/ontologies/dogont.owl#AssociateCommand</seealso>
    let ``_.owl#AssociateCommand`` =
        Prefixed_Name(dogont, ".owl#AssociateCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NonParametricCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NonParametricCommand">http://elite.polito.it/ontologies/dogont.owl#NonParametricCommand</seealso>
    let ``_.owl#NonParametricCommand`` =
        Prefixed_Name(dogont, ".owl#NonParametricCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoidCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoidCommand">http://elite.polito.it/ontologies/dogont.owl#VoidCommand</seealso>
    let ``_.owl#VoidCommand`` =
        Prefixed_Name(dogont, ".owl#VoidCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociateFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociateFunctionality">http://elite.polito.it/ontologies/dogont.owl#AssociateFunctionality</seealso>
    let ``_.owl#AssociateFunctionality`` =
        Prefixed_Name(dogont, ".owl#AssociateFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisassociateCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisassociateCommand">http://elite.polito.it/ontologies/dogont.owl#DisassociateCommand</seealso>
    let ``_.owl#DisassociateCommand`` =
        Prefixed_Name(dogont, ".owl#DisassociateCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociatingDeviceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociatingDeviceNotification">http://elite.polito.it/ontologies/dogont.owl#AssociatingDeviceNotification</seealso>
    let ``_.owl#AssociatingDeviceNotification`` =
        Prefixed_Name(dogont, ".owl#AssociatingDeviceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZWaveNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZWaveNotification">http://elite.polito.it/ontologies/dogont.owl#ZWaveNotification</seealso>
    let ``_.owl#ZWaveNotification`` =
        Prefixed_Name(dogont, ".owl#ZWaveNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association between a mobile uncontrollable object and its actuator</para>
    /// labels<para>hasActuator</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasActuator">http://elite.polito.it/ontologies/dogont.owl#hasActuator</seealso>
    let ``_.owl#hasActuator`` =
        Prefixed_Name(dogont, ".owl#hasActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AwningActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanism that allow automatic control about awning</para>
    /// labels<para>AwningActuator</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AwningActuator">http://elite.polito.it/ontologies/dogont.owl#AwningActuator</seealso>
    let ``_.owl#AwningActuator`` =
        Prefixed_Name(dogont, ".owl#AwningActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenCloseFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionality: open - close</para>
    /// labels<para>OpenCloseFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseFunctionality">http://elite.polito.it/ontologies/dogont.owl#OpenCloseFunctionality</seealso>
    let ``_.owl#OpenCloseFunctionality`` =
        Prefixed_Name(dogont, ".owl#OpenCloseFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenCloseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>State: open - close</para>
    /// labels<para>OpenCloseState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseState">http://elite.polito.it/ontologies/dogont.owl#OpenCloseState</seealso>
    let ``_.owl#OpenCloseState`` =
        Prefixed_Name(dogont, ".owl#OpenCloseState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementState">http://elite.polito.it/ontologies/dogont.owl#MovementState</seealso>
    let ``_.owl#MovementState`` =
        Prefixed_Name(dogont, ".owl#MovementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#actuatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#actuatorOf">http://elite.polito.it/ontologies/dogont.owl#actuatorOf</seealso>
    let ``_.owl#actuatorOf`` = Prefixed_Name(dogont, ".owl#actuatorOf") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenCloseNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Notification: open - close</para>
    /// labels<para>OpenCloseNotification</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#OpenCloseNotificationFunctionality</seealso>
    let ``_.owl#OpenCloseNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#OpenCloseNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MovementNotificationFunctionality</seealso>
    let ``_.owl#MovementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MovementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WindowActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanism that allow automatic opening and closing about window</para>
    /// labels<para>WindowActuator</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WindowActuator">http://elite.polito.it/ontologies/dogont.owl#WindowActuator</seealso>
    let ``_.owl#WindowActuator`` =
        Prefixed_Name(dogont, ".owl#WindowActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DoorActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanism that allow automatic opening and closing about door</para>
    /// labels<para>DoorActuator</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoorActuator">http://elite.polito.it/ontologies/dogont.owl#DoorActuator</seealso>
    let ``_.owl#DoorActuator`` =
        Prefixed_Name(dogont, ".owl#DoorActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GateActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanism that allow automatic opening and closing about gate</para>
    /// labels<para>GateActuator</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GateActuator">http://elite.polito.it/ontologies/dogont.owl#GateActuator</seealso>
    let ``_.owl#GateActuator`` =
        Prefixed_Name(dogont, ".owl#GateActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShadeActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Shade Actuator device provides the ability to open or close window coverings, including setting partially open or partially closed states. This device type includes roller shades, drapes and tilt-only blinds actuators. Derives from ZigBee HA specifications (Shade device)</para>
    /// labels<para>Shade</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShadeActuator">http://elite.polito.it/ontologies/dogont.owl#ShadeActuator</seealso>
    let ``_.owl#ShadeActuator`` =
        Prefixed_Name(dogont, ".owl#ShadeActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShutterActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanism that allow automatic control about shutter</para>
    /// labels<para>ShutterActuator</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShutterActuator">http://elite.polito.it/ontologies/dogont.owl#ShutterActuator</seealso>
    let ``_.owl#ShutterActuator`` =
        Prefixed_Name(dogont, ".owl#ShutterActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZigBeeComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeComponent">http://elite.polito.it/ontologies/dogont.owl#ZigBeeComponent</seealso>
    let ``_.owl#ZigBeeComponent`` =
        Prefixed_Name(dogont, ".owl#ZigBeeComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BTicinoGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A BTIcino Gateway</para>
    /// labels<para>BTicinoGateway</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BTicinoGateway">http://elite.polito.it/ontologies/dogont.owl#BTicinoGateway</seealso>
    let ``_.owl#BTicinoGateway`` =
        Prefixed_Name(dogont, ".owl#BTicinoGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KonnexGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Konnex Gateway</para>
    /// labels<para>KonnexGateway</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexGateway">http://elite.polito.it/ontologies/dogont.owl#KonnexGateway</seealso>
    let ``_.owl#KonnexGateway`` =
        Prefixed_Name(dogont, ".owl#KonnexGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EliteGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A software emulator of a network level to be used for simulating devices not available in the real world</para>
    /// labels<para>EliteGateway</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EliteGateway">http://elite.polito.it/ontologies/dogont.owl#EliteGateway</seealso>
    let ``_.owl#EliteGateway`` =
        Prefixed_Name(dogont, ".owl#EliteGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Balcony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A platform projecting from the wall of a building and surrounded by a balustrade or railing or parapet</para>
    /// labels<para>Balcony</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Balcony">http://elite.polito.it/ontologies/dogont.owl#Balcony</seealso>
    let ``_.owl#Balcony`` = Prefixed_Name(dogont, ".owl#Balcony") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Horizontal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The horizontal architectural component of a building</para>
    /// labels<para>Horizontal</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Horizontal">http://elite.polito.it/ontologies/dogont.owl#Horizontal</seealso>
    let ``_.owl#Horizontal`` = Prefixed_Name(dogont, ".owl#Horizontal") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Ceiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The overhead upper surface of a room</para>
    /// labels<para>Ceiling</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Ceiling">http://elite.polito.it/ontologies/dogont.owl#Ceiling</seealso>
    let ``_.owl#Ceiling`` = Prefixed_Name(dogont, ".owl#Ceiling") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The inside lower horizontal surface of a room</para>
    /// labels<para>Floor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Floor">http://elite.polito.it/ontologies/dogont.owl#Floor</seealso>
    let ``_.owl#Floor`` = Prefixed_Name(dogont, ".owl#Floor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Terrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Outdoor area adjoining a residence</para>
    /// labels<para>Terrace</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Terrace">http://elite.polito.it/ontologies/dogont.owl#Terrace</seealso>
    let ``_.owl#Terrace`` = Prefixed_Name(dogont, ".owl#Terrace") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A room of the building</para>
    /// labels<para>Room</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Room">http://elite.polito.it/ontologies/dogont.owl#Room</seealso>
    let ``_.owl#Room`` = Prefixed_Name(dogont, ".owl#Room") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Bathtub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A relatively large open container that you fill with water and use to wash the body</para>
    /// labels<para>Bathtub</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bathtub">http://elite.polito.it/ontologies/dogont.owl#Bathtub</seealso>
    let ``_.owl#Bathtub`` = Prefixed_Name(dogont, ".owl#Bathtub") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Bidet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A basin for washing genitals and anal area</para>
    /// labels<para>Bidet</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bidet">http://elite.polito.it/ontologies/dogont.owl#Bidet</seealso>
    let ``_.owl#Bidet`` = Prefixed_Name(dogont, ".owl#Bidet") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Shower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A plumbing fixture that sprays water over you</para>
    /// labels<para>Shower</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Shower">http://elite.polito.it/ontologies/dogont.owl#Shower</seealso>
    let ``_.owl#Shower`` = Prefixed_Name(dogont, ".owl#Shower") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Washbasin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A basin for washing the hands</para>
    /// labels<para>Washbasin</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Washbasin">http://elite.polito.it/ontologies/dogont.owl#Washbasin</seealso>
    let ``_.owl#Washbasin`` = Prefixed_Name(dogont, ".owl#Washbasin") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterCloset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A plumbing fixture for defecation and urination</para>
    /// labels<para>WaterCloset</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterCloset">http://elite.polito.it/ontologies/dogont.owl#WaterCloset</seealso>
    let ``_.owl#WaterCloset`` =
        Prefixed_Name(dogont, ".owl#WaterCloset") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BatteryLevelNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotification">http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotification</seealso>
    let ``_.owl#BatteryLevelNotification`` =
        Prefixed_Name(dogont, ".owl#BatteryLevelNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetTemperatureMCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetTemperatureMCommand">http://elite.polito.it/ontologies/dogont.owl#GetTemperatureMCommand</seealso>
    let ``_.owl#GetTemperatureMCommand`` =
        Prefixed_Name(dogont, ".owl#GetTemperatureMCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetFlowRateMCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetFlowRateMCommand">http://elite.polito.it/ontologies/dogont.owl#GetFlowRateMCommand</seealso>
    let ``_.owl#GetFlowRateMCommand`` =
        Prefixed_Name(dogont, ".owl#GetFlowRateMCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkNotification">http://elite.polito.it/ontologies/dogont.owl#NetworkNotification</seealso>
    let ``_.owl#NetworkNotification`` =
        Prefixed_Name(dogont, ".owl#NetworkNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeviceAssociationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeviceAssociationState">http://elite.polito.it/ontologies/dogont.owl#DeviceAssociationState</seealso>
    let ``_.owl#DeviceAssociationState`` =
        Prefixed_Name(dogont, ".owl#DeviceAssociationState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TripleValuedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete states with exactly three values</para>
    /// labels<para>TripleValuedState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedState">http://elite.polito.it/ontologies/dogont.owl#TripleValuedState</seealso>
    let ``_.owl#TripleValuedState`` =
        Prefixed_Name(dogont, ".owl#TripleValuedState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SceneNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derives from the general cluster functionalities defined in ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SceneNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SceneNotificationFunctionality</seealso>
    let ``_.owl#SceneNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SceneNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SceneFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derives from the general cluster functionalities defined in ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SceneFunctionality">http://elite.polito.it/ontologies/dogont.owl#SceneFunctionality</seealso>
    let ``_.owl#SceneFunctionality`` =
        Prefixed_Name(dogont, ".owl#SceneFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GroupNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derives from the general cluster functionalities defined in ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GroupNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#GroupNotificationFunctionality</seealso>
    let ``_.owl#GroupNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#GroupNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GroupFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derives from the general cluster functionalities defined in ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GroupFunctionality">http://elite.polito.it/ontologies/dogont.owl#GroupFunctionality</seealso>
    let ``_.owl#GroupFunctionality`` =
        Prefixed_Name(dogont, ".owl#GroupFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DimmerLamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lamp that varies the level of illumination</para>
    /// labels<para>DimmerLamp</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DimmerLamp">http://elite.polito.it/ontologies/dogont.owl#DimmerLamp</seealso>
    let ``_.owl#DimmerLamp`` = Prefixed_Name(dogont, ".owl#DimmerLamp") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LightIntensityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Models the state of the object that illuminates</para>
    /// labels<para>LightIntensityState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LightIntensityState">http://elite.polito.it/ontologies/dogont.owl#LightIntensityState</seealso>
    let ``_.owl#LightIntensityState`` =
        Prefixed_Name(dogont, ".owl#LightIntensityState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SimpleLevelNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Notification functionality for controlling continuously adjustable device, e.g. dimmers, derives from ZigBee Home Automation specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SimpleLevelNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SimpleLevelNotificationFunctionality</seealso>
    let ``_.owl#SimpleLevelNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SimpleLevelNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SimpleLamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simple lamp that can be just turn on or turn off</para>
    /// labels<para>SimpleLamp</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SimpleLamp">http://elite.polito.it/ontologies/dogont.owl#SimpleLamp</seealso>
    let ``_.owl#SimpleLamp`` = Prefixed_Name(dogont, ".owl#SimpleLamp") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControlSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Level control switch, derives from the ZigBee Home Automation specification</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControlSwitch">http://elite.polito.it/ontologies/dogont.owl#LevelControlSwitch</seealso>
    let ``_.owl#LevelControlSwitch`` =
        Prefixed_Name(dogont, ".owl#LevelControlSwitch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisableGasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisableGasCommand">http://elite.polito.it/ontologies/dogont.owl#DisableGasCommand</seealso>
    let ``_.owl#DisableGasCommand`` =
        Prefixed_Name(dogont, ".owl#DisableGasCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryActiveNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryActiveNotification">http://elite.polito.it/ontologies/dogont.owl#DiscoveryActiveNotification</seealso>
    let ``_.owl#DiscoveryActiveNotification`` =
        Prefixed_Name(dogont, ".owl#DiscoveryActiveNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HueNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueNotification">http://elite.polito.it/ontologies/dogont.owl#HueNotification</seealso>
    let ``_.owl#HueNotification`` =
        Prefixed_Name(dogont, ".owl#HueNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscoveryFunctionality</seealso>
    let ``_.owl#DiscoveryFunctionality`` =
        Prefixed_Name(dogont, ".owl#DiscoveryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartDiscoveryCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartDiscoveryCommand">http://elite.polito.it/ontologies/dogont.owl#StartDiscoveryCommand</seealso>
    let ``_.owl#StartDiscoveryCommand`` =
        Prefixed_Name(dogont, ".owl#StartDiscoveryCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopDiscoveryCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopDiscoveryCommand">http://elite.polito.it/ontologies/dogont.owl#StopDiscoveryCommand</seealso>
    let ``_.owl#StopDiscoveryCommand`` =
        Prefixed_Name(dogont, ".owl#StopDiscoveryCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteOutputFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteOutputFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscreteOutputFunctionality</seealso>
    let ``_.owl#DiscreteOutputFunctionality`` =
        Prefixed_Name(dogont, ".owl#DiscreteOutputFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartStopPauseNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartStopPauseNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#StartStopPauseNotificationFunctionality</seealso>
    let ``_.owl#StartStopPauseNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#StartStopPauseNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartStopPauseFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A functionality describing the ability of a device, tipically an appliance, to start, stop or pause its current cycle.</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartStopPauseFunctionality">http://elite.polito.it/ontologies/dogont.owl#StartStopPauseFunctionality</seealso>
    let ``_.owl#StartStopPauseFunctionality`` =
        Prefixed_Name(dogont, ".owl#StartStopPauseFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisplayCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisplayCommand">http://elite.polito.it/ontologies/dogont.owl#DisplayCommand</seealso>
    let ``_.owl#DisplayCommand`` =
        Prefixed_Name(dogont, ".owl#DisplayCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisplayFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisplayFunctionality">http://elite.polito.it/ontologies/dogont.owl#DisplayFunctionality</seealso>
    let ``_.owl#DisplayFunctionality`` =
        Prefixed_Name(dogont, ".owl#DisplayFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Door</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A swinging or sliding barrier that will close the entrance to a room or building.</para>
    /// labels<para>Door</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Door">http://elite.polito.it/ontologies/dogont.owl#Door</seealso>
    let ``_.owl#Door`` = Prefixed_Name(dogont, ".owl#Door") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association between an object and its sensor</para>
    /// labels<para>hasSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasSensor">http://elite.polito.it/ontologies/dogont.owl#hasSensor</seealso>
    let ``_.owl#hasSensor`` = Prefixed_Name(dogont, ".owl#hasSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DoorSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that controls if a door is closed</para>
    /// labels<para>DoorSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoorSensor">http://elite.polito.it/ontologies/dogont.owl#DoorSensor</seealso>
    let ``_.owl#DoorSensor`` = Prefixed_Name(dogont, ".owl#DoorSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#sensorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association between a sensor and its sensed object</para>
    /// labels<para>isSensorOf</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#sensorOf">http://elite.polito.it/ontologies/dogont.owl#sensorOf</seealso>
    let ``_.owl#sensorOf`` = Prefixed_Name(dogont, ".owl#sensorOf") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WindowSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that controls if a window is closed</para>
    /// labels<para>WindowSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WindowSensor">http://elite.polito.it/ontologies/dogont.owl#WindowSensor</seealso>
    let ``_.owl#WindowSensor`` =
        Prefixed_Name(dogont, ".owl#WindowSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#InfraredSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that detects the presence of a living entity in the sensor's range</para>
    /// labels<para>InfraredSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#InfraredSensor">http://elite.polito.it/ontologies/dogont.owl#InfraredSensor</seealso>
    let ``_.owl#InfraredSensor`` =
        Prefixed_Name(dogont, ".owl#InfraredSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SmokeSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that detects the presence of smoke</para>
    /// labels<para>SmokeSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SmokeSensor">http://elite.polito.it/ontologies/dogont.owl#SmokeSensor</seealso>
    let ``_.owl#SmokeSensor`` =
        Prefixed_Name(dogont, ".owl#SmokeSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FloodSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that detects the presence of flood</para>
    /// labels<para>FloodSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FloodSensor">http://elite.polito.it/ontologies/dogont.owl#FloodSensor</seealso>
    let ``_.owl#FloodSensor`` =
        Prefixed_Name(dogont, ".owl#FloodSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OccupancySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Occupancy Sensor device reports the occupancy state of an area. Derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OccupancySensor">http://elite.polito.it/ontologies/dogont.owl#OccupancySensor</seealso>
    let ``_.owl#OccupancySensor`` =
        Prefixed_Name(dogont, ".owl#OccupancySensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SurveillanceCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Camera of video surveillance</para>
    /// labels<para>SurveillanceCamera</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SurveillanceCamera">http://elite.polito.it/ontologies/dogont.owl#SurveillanceCamera</seealso>
    let ``_.owl#SurveillanceCamera`` =
        Prefixed_Name(dogont, ".owl#SurveillanceCamera") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that detects the presence of gas</para>
    /// labels<para>GasSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasSensor">http://elite.polito.it/ontologies/dogont.owl#GasSensor</seealso>
    let ``_.owl#GasSensor`` = Prefixed_Name(dogont, ".owl#GasSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DoubleBed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoubleBed">http://elite.polito.it/ontologies/dogont.owl#DoubleBed</seealso>
    let ``_.owl#DoubleBed`` = Prefixed_Name(dogont, ".owl#DoubleBed") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#SingleBed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleBed">http://elite.polito.it/ontologies/dogont.owl#SingleBed</seealso>
    let ``_.owl#SingleBed`` = Prefixed_Name(dogont, ".owl#SingleBed") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayFunctionality">http://elite.polito.it/ontologies/dogont.owl#PlayFunctionality</seealso>
    let ``_.owl#PlayFunctionality`` =
        Prefixed_Name(dogont, ".owl#PlayFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleValuedFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete functionalities with exactly one value</para>
    /// labels<para>SingleValuedFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleValuedFunctionality">http://elite.polito.it/ontologies/dogont.owl#SingleValuedFunctionality</seealso>
    let ``_.owl#SingleValuedFunctionality`` =
        Prefixed_Name(dogont, ".owl#SingleValuedFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Notification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Notification">http://elite.polito.it/ontologies/dogont.owl#Notification</seealso>
    let ``_.owl#Notification`` =
        Prefixed_Name(dogont, ".owl#Notification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Radio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A communication system based on broadcasting electromagnetic waves</para>
    /// labels<para>Radio</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Radio">http://elite.polito.it/ontologies/dogont.owl#Radio</seealso>
    let ``_.owl#Radio`` = Prefixed_Name(dogont, ".owl#Radio") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HiFi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equipment for the reproduction of sound with high fidelity</para>
    /// labels<para>HiFi</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HiFi">http://elite.polito.it/ontologies/dogont.owl#HiFi</seealso>
    let ``_.owl#HiFi`` = Prefixed_Name(dogont, ".owl#HiFi") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Tv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A receiver that displays television images</para>
    /// labels<para>Tv</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Tv">http://elite.polito.it/ontologies/dogont.owl#Tv</seealso>
    let ``_.owl#Tv`` = Prefixed_Name(dogont, ".owl#Tv") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonCommand">http://elite.polito.it/ontologies/dogont.owl#EchelonCommand</seealso>
    let ``_.owl#EchelonCommand`` =
        Prefixed_Name(dogont, ".owl#EchelonCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkSpecificCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificCommand">http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificCommand</seealso>
    let ``_.owl#NetworkSpecificCommand`` =
        Prefixed_Name(dogont, ".owl#NetworkSpecificCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonIlon100Gateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Gateway">http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Gateway</seealso>
    let ``_.owl#EchelonIlon100Gateway`` =
        Prefixed_Name(dogont, ".owl#EchelonIlon100Gateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonNetworkComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonNetworkComponent">http://elite.polito.it/ontologies/dogont.owl#EchelonNetworkComponent</seealso>
    let ``_.owl#EchelonNetworkComponent`` =
        Prefixed_Name(dogont, ".owl#EchelonNetworkComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonIlon100Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Property">http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Property</seealso>
    let ``_.owl#EchelonIlon100Property`` =
        Prefixed_Name(dogont, ".owl#EchelonIlon100Property") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonNotification">http://elite.polito.it/ontologies/dogont.owl#EchelonNotification</seealso>
    let ``_.owl#EchelonNotification`` =
        Prefixed_Name(dogont, ".owl#EchelonNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkSpecificNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificNotification">http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificNotification</seealso>
    let ``_.owl#NetworkSpecificNotification`` =
        Prefixed_Name(dogont, ".owl#NetworkSpecificNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricalCooker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electrical Cooker</para>
    /// labels<para>ElectricalCooker</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricalCooker">http://elite.polito.it/ontologies/dogont.owl#ElectricalCooker</seealso>
    let ``_.owl#ElectricalCooker`` =
        Prefixed_Name(dogont, ".owl#ElectricalCooker") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasCooker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gas Cooker</para>
    /// labels<para>GasCooker</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasCooker">http://elite.polito.it/ontologies/dogont.owl#GasCooker</seealso>
    let ``_.owl#GasCooker`` = Prefixed_Name(dogont, ".owl#GasCooker") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Hotplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A portable electric appliance for heating or cooking or keeping food warm</para>
    /// labels<para>Hotplate</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Hotplate">http://elite.polito.it/ontologies/dogont.owl#Hotplate</seealso>
    let ``_.owl#Hotplate`` = Prefixed_Name(dogont, ".owl#Hotplate") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricalOven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electrical oven</para>
    /// labels<para>ElectricalOven</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricalOven">http://elite.polito.it/ontologies/dogont.owl#ElectricalOven</seealso>
    let ``_.owl#ElectricalOven`` =
        Prefixed_Name(dogont, ".owl#ElectricalOven") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MicrowaveOven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Microwave oven</para>
    /// labels<para>MicrowaveOven</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveOven">http://elite.polito.it/ontologies/dogont.owl#MicrowaveOven</seealso>
    let ``_.owl#MicrowaveOven`` =
        Prefixed_Name(dogont, ".owl#MicrowaveOven") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Meter">http://elite.polito.it/ontologies/dogont.owl#Meter</seealso>
    let ``_.owl#Meter`` = Prefixed_Name(dogont, ".owl#Meter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyAndPowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeter">http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeter</seealso>
    let ``_.owl#EnergyAndPowerMeter`` =
        Prefixed_Name(dogont, ".owl#EnergyAndPowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeter</seealso>
    let ``_.owl#SinglePhaseActivePowerMeter`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseEnergyMeter</seealso>
    let ``_.owl#SinglePhaseEnergyMeter`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyAndPowerMeteringLevelControllableOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeteringLevelControllableOutput">http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeteringLevelControllableOutput</seealso>
    let ``_.owl#EnergyAndPowerMeteringLevelControllableOutput`` =
        Prefixed_Name(dogont, ".owl#EnergyAndPowerMeteringLevelControllableOutput") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControllableOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Output device whose output level can be controlled continuously, by means of a level-control command (notification), derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControllableOutput">http://elite.polito.it/ontologies/dogont.owl#LevelControllableOutput</seealso>
    let ``_.owl#LevelControllableOutput`` =
        Prefixed_Name(dogont, ".owl#LevelControllableOutput") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeter</seealso>
    let ``_.owl#SinglePhaseActiveEnergyMeter`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActiveEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementState">http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementState</seealso>
    let ``_.owl#EnergyMeasurementState`` =
        Prefixed_Name(dogont, ".owl#EnergyMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeter">http://elite.polito.it/ontologies/dogont.owl#EnergyMeter</seealso>
    let ``_.owl#EnergyMeter`` =
        Prefixed_Name(dogont, ".owl#EnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeteringPowerOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeteringPowerOutlet">http://elite.polito.it/ontologies/dogont.owl#EnergyMeteringPowerOutlet</seealso>
    let ``_.owl#EnergyMeteringPowerOutlet`` =
        Prefixed_Name(dogont, ".owl#EnergyMeteringPowerOutlet") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MainsPowerOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MainsPowerOutlet">http://elite.polito.it/ontologies/dogont.owl#MainsPowerOutlet</seealso>
    let ``_.owl#MainsPowerOutlet`` =
        Prefixed_Name(dogont, ".owl#MainsPowerOutlet") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Entrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Entrance">http://elite.polito.it/ontologies/dogont.owl#Entrance</seealso>
    let ``_.owl#Entrance`` = Prefixed_Name(dogont, ".owl#Entrance") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EventNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EventNotification">http://elite.polito.it/ontologies/dogont.owl#EventNotification</seealso>
    let ``_.owl#EventNotification`` =
        Prefixed_Name(dogont, ".owl#EventNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EventNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EventNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#EventNotificationFunctionality</seealso>
    let ``_.owl#EventNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#EventNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EventsAndAlertsNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsNotificationFunctionality</seealso>
    let ``_.owl#EventsAndAlertsNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#EventsAndAlertsNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleAlertNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotificationFunctionality</seealso>
    let ``_.owl#MultipleAlertNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultipleAlertNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleEventNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotificationFunctionality</seealso>
    let ``_.owl#MultipleEventNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultipleEventNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EventsAndAlertsQueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsQueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsQueryFunctionality</seealso>
    let ``_.owl#EventsAndAlertsQueryFunctionality`` =
        Prefixed_Name(dogont, ".owl#EventsAndAlertsQueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetEventsAndAlertsCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetEventsAndAlertsCommand">http://elite.polito.it/ontologies/dogont.owl#GetEventsAndAlertsCommand</seealso>
    let ``_.owl#GetEventsAndAlertsCommand`` =
        Prefixed_Name(dogont, ".owl#GetEventsAndAlertsCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RaisingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RaisingStateValue">http://elite.polito.it/ontologies/dogont.owl#RaisingStateValue</seealso>
    let ``_.owl#RaisingStateValue`` =
        Prefixed_Name(dogont, ".owl#RaisingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffActiveEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffActiveEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#MultiTariffActiveEnergyStateValue</seealso>
    let ``_.owl#MultiTariffActiveEnergyStateValue`` =
        Prefixed_Name(dogont, ".owl#MultiTariffActiveEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#MultiTariffEnergyMeter</seealso>
    let ``_.owl#MultiTariffEnergyMeter`` =
        Prefixed_Name(dogont, ".owl#MultiTariffEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffReactiveEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffReactiveEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#MultiTariffReactiveEnergyStateValue</seealso>
    let ``_.owl#MultiTariffReactiveEnergyStateValue`` =
        Prefixed_Name(dogont, ".owl#MultiTariffReactiveEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification</seealso>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseActiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyState</seealso>
    let ``_.owl#MultiTariffSinglePhaseActiveEnergyState`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseActiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseEnergyMeter</seealso>
    let ``_.owl#MultiTariffSinglePhaseEnergyMeter`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ProgramState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ProgramState">http://elite.polito.it/ontologies/dogont.owl#ProgramState</seealso>
    let ``_.owl#ProgramState`` =
        Prefixed_Name(dogont, ".owl#ProgramState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#eZ430Chronos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#eZ430Chronos">http://elite.polito.it/ontologies/dogont.owl#eZ430Chronos</seealso>
    let ``_.owl#eZ430Chronos`` =
        Prefixed_Name(dogont, ".owl#eZ430Chronos") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ModBusProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModBusProperty">http://elite.polito.it/ontologies/dogont.owl#ModBusProperty</seealso>
    let ``_.owl#ModBusProperty`` =
        Prefixed_Name(dogont, ".owl#ModBusProperty") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#connectionTrials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of connection trials before failure</para>
    /// labels<para>connectionTrials</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#connectionTrials">http://elite.polito.it/ontologies/dogont.owl#connectionTrials</seealso>
    let ``_.owl#connectionTrials`` =
        Prefixed_Name(dogont, ".owl#connectionTrials") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#levelFromGround</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#levelFromGround">http://elite.polito.it/ontologies/dogont.owl#levelFromGround</seealso>
    let ``_.owl#levelFromGround`` =
        Prefixed_Name(dogont, ".owl#levelFromGround") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#pollingInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The interval between subsequent polls</para>
    /// labels<para>pollingInterval</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#pollingInterval">http://elite.polito.it/ontologies/dogont.owl#pollingInterval</seealso>
    let ``_.owl#pollingInterval`` =
        Prefixed_Name(dogont, ".owl#pollingInterval") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#realCommandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#realCommandName">http://elite.polito.it/ontologies/dogont.owl#realCommandName</seealso>
    let ``_.owl#realCommandName`` =
        Prefixed_Name(dogont, ".owl#realCommandName") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShadeController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Shade Controller device can control the level of a shade, derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShadeController">http://elite.polito.it/ontologies/dogont.owl#ShadeController</seealso>
    let ``_.owl#ShadeController`` =
        Prefixed_Name(dogont, ".owl#ShadeController") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ToggleRelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ToggleRelay">http://elite.polito.it/ontologies/dogont.owl#ToggleRelay</seealso>
    let ``_.owl#ToggleRelay`` =
        Prefixed_Name(dogont, ".owl#ToggleRelay") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressedMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressedMNotification">http://elite.polito.it/ontologies/dogont.owl#PressedMNotification</seealso>
    let ``_.owl#PressedMNotification`` =
        Prefixed_Name(dogont, ".owl#PressedMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DoubleValuedNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete notification with exactly two values</para>
    /// labels<para>DoubleValuedNotificationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#DoubleValuedNotificationFunctionality</seealso>
    let ``_.owl#DoubleValuedNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#DoubleValuedNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CameraPictureImageControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureImageControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#CameraPictureImageControlFunctionality</seealso>
    let ``_.owl#CameraPictureImageControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#CameraPictureImageControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseLuminosityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseLuminosityCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseLuminosityCommand</seealso>
    let ``_.owl#DecreaseLuminosityCommand`` =
        Prefixed_Name(dogont, ".owl#DecreaseLuminosityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseLuminosityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseLuminosityCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseLuminosityCommand</seealso>
    let ``_.owl#IncreaseLuminosityCommand`` =
        Prefixed_Name(dogont, ".owl#IncreaseLuminosityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WallOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An opening in a Wall</para>
    /// labels<para>WallOpening</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WallOpening">http://elite.polito.it/ontologies/dogont.owl#WallOpening</seealso>
    let ``_.owl#WallOpening`` =
        Prefixed_Name(dogont, ".owl#WallOpening") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Window</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A framework that contains a glass windowpane and is built into a wall or roof to admit light or air</para>
    /// labels<para>Window</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Window">http://elite.polito.it/ontologies/dogont.owl#Window</seealso>
    let ``_.owl#Window`` = Prefixed_Name(dogont, ".owl#Window") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#notificationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#notificationName">http://elite.polito.it/ontologies/dogont.owl#notificationName</seealso>
    let ``_.owl#notificationName`` =
        Prefixed_Name(dogont, ".owl#notificationName") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotEmittingMicrowavesNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesNotification">http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesNotification</seealso>
    let ``_.owl#NotEmittingMicrowavesNotification`` =
        Prefixed_Name(dogont, ".owl#NotEmittingMicrowavesNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OffNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OffNotification">http://elite.polito.it/ontologies/dogont.owl#OffNotification</seealso>
    let ``_.owl#OffNotification`` =
        Prefixed_Name(dogont, ".owl#OffNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressedNotification">http://elite.polito.it/ontologies/dogont.owl#PressedNotification</seealso>
    let ``_.owl#PressedNotification`` =
        Prefixed_Name(dogont, ".owl#PressedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#physicalType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The category of the component</para>
    /// labels<para>physicalType</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#physicalType">http://elite.polito.it/ontologies/dogont.owl#physicalType</seealso>
    let ``_.owl#physicalType`` =
        Prefixed_Name(dogont, ".owl#physicalType") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EliteComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Emulated component</para>
    /// labels<para>EliteComponent</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EliteComponent">http://elite.polito.it/ontologies/dogont.owl#EliteComponent</seealso>
    let ``_.owl#EliteComponent`` =
        Prefixed_Name(dogont, ".owl#EliteComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KonnexComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Components manufactured by Konnex</para>
    /// labels<para>KonnexComponent</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexComponent">http://elite.polito.it/ontologies/dogont.owl#KonnexComponent</seealso>
    let ``_.owl#KonnexComponent`` =
        Prefixed_Name(dogont, ".owl#KonnexComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TuningStepUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TuningStepUpNotification">http://elite.polito.it/ontologies/dogont.owl#TuningStepUpNotification</seealso>
    let ``_.owl#TuningStepUpNotification`` =
        Prefixed_Name(dogont, ".owl#TuningStepUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#pluggedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#pluggedIn">http://elite.polito.it/ontologies/dogont.owl#pluggedIn</seealso>
    let ``_.owl#pluggedIn`` = Prefixed_Name(dogont, ".owl#pluggedIn") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenNotification">http://elite.polito.it/ontologies/dogont.owl#OpenNotification</seealso>
    let ``_.owl#OpenNotification`` =
        Prefixed_Name(dogont, ".owl#OpenNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeter">http://elite.polito.it/ontologies/dogont.owl#CurrentMeter</seealso>
    let ``_.owl#CurrentMeter`` =
        Prefixed_Name(dogont, ".owl#CurrentMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetStartTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetStartTimeCommand">http://elite.polito.it/ontologies/dogont.owl#SetStartTimeCommand</seealso>
    let ``_.owl#SetStartTimeCommand`` =
        Prefixed_Name(dogont, ".owl#SetStartTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TripleValuedNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TripleValuedNotificationFunctionality</seealso>
    let ``_.owl#TripleValuedNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#TripleValuedNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CycleTimingQueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingQueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#CycleTimingQueryFunctionality</seealso>
    let ``_.owl#CycleTimingQueryFunctionality`` =
        Prefixed_Name(dogont, ".owl#CycleTimingQueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetRemainingTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetRemainingTimeCommand">http://elite.polito.it/ontologies/dogont.owl#GetRemainingTimeCommand</seealso>
    let ``_.owl#GetRemainingTimeCommand`` =
        Prefixed_Name(dogont, ".owl#GetRemainingTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureStateValue">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureStateValue</seealso>
    let ``_.owl#MultiplePressureStateValue`` =
        Prefixed_Name(dogont, ".owl#MultiplePressureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementFunctionality</seealso>
    let ``_.owl#ThreePhaseActivePowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#realStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#realStateValue">http://elite.polito.it/ontologies/dogont.owl#realStateValue</seealso>
    let ``_.owl#realStateValue`` =
        Prefixed_Name(dogont, ".owl#realStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#timeToOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time in seconds during which the object is turned on</para>
    /// labels<para>timeToOff</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#timeToOff">http://elite.polito.it/ontologies/dogont.owl#timeToOff</seealso>
    let ``_.owl#timeToOff`` = Prefixed_Name(dogont, ".owl#timeToOff") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingStateValue">http://elite.polito.it/ontologies/dogont.owl#HeatingStateValue</seealso>
    let ``_.owl#HeatingStateValue`` =
        Prefixed_Name(dogont, ".owl#HeatingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotProgrammedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotProgrammedStateValue">http://elite.polito.it/ontologies/dogont.owl#NotProgrammedStateValue</seealso>
    let ``_.owl#NotProgrammedStateValue`` =
        Prefixed_Name(dogont, ".owl#NotProgrammedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ProgramInterruptedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ProgramInterruptedStateValue">http://elite.polito.it/ontologies/dogont.owl#ProgramInterruptedStateValue</seealso>
    let ``_.owl#ProgramInterruptedStateValue`` =
        Prefixed_Name(dogont, ".owl#ProgramInterruptedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RewindStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RewindStateValue">http://elite.polito.it/ontologies/dogont.owl#RewindStateValue</seealso>
    let ``_.owl#RewindStateValue`` =
        Prefixed_Name(dogont, ".owl#RewindStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopStateValue">http://elite.polito.it/ontologies/dogont.owl#StopStateValue</seealso>
    let ``_.owl#StopStateValue`` =
        Prefixed_Name(dogont, ".owl#StopStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Tape1StateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Tape1StateValue">http://elite.polito.it/ontologies/dogont.owl#Tape1StateValue</seealso>
    let ``_.owl#Tape1StateValue`` =
        Prefixed_Name(dogont, ".owl#Tape1StateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl">http://elite.polito.it/ontologies/dogont.owl</seealso>
    let ``_.owl`` = Prefixed_Name(dogont, ".owl") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricalSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Utility that provides electricity</para>
    /// labels<para>ElectricalSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricalSystem">http://elite.polito.it/ontologies/dogont.owl#ElectricalSystem</seealso>
    let ``_.owl#ElectricalSystem`` =
        Prefixed_Name(dogont, ".owl#ElectricalSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanism that puts something into automatic action</para>
    /// labels<para>Actuator</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Actuator">http://elite.polito.it/ontologies/dogont.owl#Actuator</seealso>
    let ``_.owl#Actuator`` = Prefixed_Name(dogont, ".owl#Actuator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mechanism that controls the interaction with the electrical system</para>
    /// labels<para>Control</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Control">http://elite.polito.it/ontologies/dogont.owl#Control</seealso>
    let ``_.owl#Control`` = Prefixed_Name(dogont, ".owl#Control") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Lighting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>System that provides artificial light</para>
    /// labels<para>Lighting</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Lighting">http://elite.polito.it/ontologies/dogont.owl#Lighting</seealso>
    let ``_.owl#Lighting`` = Prefixed_Name(dogont, ".owl#Lighting") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureStateValue">http://elite.polito.it/ontologies/dogont.owl#TemperatureStateValue</seealso>
    let ``_.owl#TemperatureStateValue`` =
        Prefixed_Name(dogont, ".owl#TemperatureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowRateStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowRateStateValue">http://elite.polito.it/ontologies/dogont.owl#FlowRateStateValue</seealso>
    let ``_.owl#FlowRateStateValue`` =
        Prefixed_Name(dogont, ".owl#FlowRateStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShadeStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Value for the Shade position state, the shade position can be expressed as position=closedLimitx(255-level)/255, where with level 0 the shade is closed and with level 255 the shade is completely open. Derives from ZigBee HA specifications.</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShadeStateValue">http://elite.polito.it/ontologies/dogont.owl#ShadeStateValue</seealso>
    let ``_.owl#ShadeStateValue`` =
        Prefixed_Name(dogont, ".owl#ShadeStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityStateValue">http://elite.polito.it/ontologies/dogont.owl#HumidityStateValue</seealso>
    let ``_.owl#HumidityStateValue`` =
        Prefixed_Name(dogont, ".owl#HumidityStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeter</seealso>
    let ``_.owl#ActivePowerMeter`` =
        Prefixed_Name(dogont, ".owl#ActivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerMeter">http://elite.polito.it/ontologies/dogont.owl#PowerMeter</seealso>
    let ``_.owl#PowerMeter`` = Prefixed_Name(dogont, ".owl#PowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerStateValue">http://elite.polito.it/ontologies/dogont.owl#ActivePowerStateValue</seealso>
    let ``_.owl#ActivePowerStateValue`` =
        Prefixed_Name(dogont, ".owl#ActivePowerStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasStateValue">http://elite.polito.it/ontologies/dogont.owl#hasStateValue</seealso>
    let ``_.owl#hasStateValue`` =
        Prefixed_Name(dogont, ".owl#hasStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopHeatingCoolingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingCommand">http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingCommand</seealso>
    let ``_.owl#StopHeatingCoolingCommand`` =
        Prefixed_Name(dogont, ".owl#StopHeatingCoolingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetCommand">http://elite.polito.it/ontologies/dogont.owl#GetCommand</seealso>
    let ``_.owl#GetCommand`` = Prefixed_Name(dogont, ".owl#GetCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeleteGroupCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeleteGroupCommand">http://elite.polito.it/ontologies/dogont.owl#DeleteGroupCommand</seealso>
    let ``_.owl#DeleteGroupCommand`` =
        Prefixed_Name(dogont, ".owl#DeleteGroupCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetTimeoutCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetTimeoutCommand">http://elite.polito.it/ontologies/dogont.owl#SetTimeoutCommand</seealso>
    let ``_.owl#SetTimeoutCommand`` =
        Prefixed_Name(dogont, ".owl#SetTimeoutCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetOccupancyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the command for getting the occupancy state of a given room/environment</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetOccupancyCommand">http://elite.polito.it/ontologies/dogont.owl#GetOccupancyCommand</seealso>
    let ``_.owl#GetOccupancyCommand`` =
        Prefixed_Name(dogont, ".owl#GetOccupancyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RewindCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RewindCommand">http://elite.polito.it/ontologies/dogont.owl#RewindCommand</seealso>
    let ``_.owl#RewindCommand`` =
        Prefixed_Name(dogont, ".owl#RewindCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayCommand">http://elite.polito.it/ontologies/dogont.owl#PlayCommand</seealso>
    let ``_.owl#PlayCommand`` =
        Prefixed_Name(dogont, ".owl#PlayCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetChannelCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetChannelCommand">http://elite.polito.it/ontologies/dogont.owl#SetChannelCommand</seealso>
    let ``_.owl#SetChannelCommand`` =
        Prefixed_Name(dogont, ".owl#SetChannelCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DownCommand">http://elite.polito.it/ontologies/dogont.owl#DownCommand</seealso>
    let ``_.owl#DownCommand`` =
        Prefixed_Name(dogont, ".owl#DownCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestCommand">http://elite.polito.it/ontologies/dogont.owl#RestCommand</seealso>
    let ``_.owl#RestCommand`` =
        Prefixed_Name(dogont, ".owl#RestCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetCommand">http://elite.polito.it/ontologies/dogont.owl#SetCommand</seealso>
    let ``_.owl#SetCommand`` = Prefixed_Name(dogont, ".owl#SetCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetSpeedCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetSpeedCommand">http://elite.polito.it/ontologies/dogont.owl#SetSpeedCommand</seealso>
    let ``_.owl#SetSpeedCommand`` =
        Prefixed_Name(dogont, ".owl#SetSpeedCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CoolCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoolCommand">http://elite.polito.it/ontologies/dogont.owl#CoolCommand</seealso>
    let ``_.owl#CoolCommand`` =
        Prefixed_Name(dogont, ".owl#CoolCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StepDownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StepDownCommand">http://elite.polito.it/ontologies/dogont.owl#StepDownCommand</seealso>
    let ``_.owl#StepDownCommand`` =
        Prefixed_Name(dogont, ".owl#StepDownCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetSecondsCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetSecondsCommand">http://elite.polito.it/ontologies/dogont.owl#SetSecondsCommand</seealso>
    let ``_.owl#SetSecondsCommand`` =
        Prefixed_Name(dogont, ".owl#SetSecondsCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StepUpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StepUpCommand">http://elite.polito.it/ontologies/dogont.owl#StepUpCommand</seealso>
    let ``_.owl#StepUpCommand`` =
        Prefixed_Name(dogont, ".owl#StepUpCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PauseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PauseCommand">http://elite.polito.it/ontologies/dogont.owl#PauseCommand</seealso>
    let ``_.owl#PauseCommand`` =
        Prefixed_Name(dogont, ".owl#PauseCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetVolumeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetVolumeCommand">http://elite.polito.it/ontologies/dogont.owl#SetVolumeCommand</seealso>
    let ``_.owl#SetVolumeCommand`` =
        Prefixed_Name(dogont, ".owl#SetVolumeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TimedOnCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TimedOnCommand">http://elite.polito.it/ontologies/dogont.owl#TimedOnCommand</seealso>
    let ``_.owl#TimedOnCommand`` =
        Prefixed_Name(dogont, ".owl#TimedOnCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ModBusStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModBusStateValue">http://elite.polito.it/ontologies/dogont.owl#ModBusStateValue</seealso>
    let ``_.owl#ModBusStateValue`` =
        Prefixed_Name(dogont, ".owl#ModBusStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ModbusCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModbusCommand">http://elite.polito.it/ontologies/dogont.owl#ModbusCommand</seealso>
    let ``_.owl#ModbusCommand`` =
        Prefixed_Name(dogont, ".owl#ModbusCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementAndTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementAndTemperatureSensor">http://elite.polito.it/ontologies/dogont.owl#MovementAndTemperatureSensor</seealso>
    let ``_.owl#MovementAndTemperatureSensor`` =
        Prefixed_Name(dogont, ".owl#MovementAndTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementSensor">http://elite.polito.it/ontologies/dogont.owl#MovementSensor</seealso>
    let ``_.owl#MovementSensor`` =
        Prefixed_Name(dogont, ".owl#MovementSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that detects the temperature of the atmosphere</para>
    /// labels<para>TemperatureSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleTemperatureSensor">http://elite.polito.it/ontologies/dogont.owl#SingleTemperatureSensor</seealso>
    let ``_.owl#SingleTemperatureSensor`` =
        Prefixed_Name(dogont, ".owl#SingleTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovingDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovingDownNotification">http://elite.polito.it/ontologies/dogont.owl#MovingDownNotification</seealso>
    let ``_.owl#MovingDownNotification`` =
        Prefixed_Name(dogont, ".owl#MovingDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovingUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovingUpNotification">http://elite.polito.it/ontologies/dogont.owl#MovingUpNotification</seealso>
    let ``_.owl#MovingUpNotification`` =
        Prefixed_Name(dogont, ".owl#MovingUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZWaveComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZWaveComponent">http://elite.polito.it/ontologies/dogont.owl#ZWaveComponent</seealso>
    let ``_.owl#ZWaveComponent`` =
        Prefixed_Name(dogont, ".owl#ZWaveComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZWaveGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZWaveGateway">http://elite.polito.it/ontologies/dogont.owl#ZWaveGateway</seealso>
    let ``_.owl#ZWaveGateway`` =
        Prefixed_Name(dogont, ".owl#ZWaveGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZigBeeGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeGateway">http://elite.polito.it/ontologies/dogont.owl#ZigBeeGateway</seealso>
    let ``_.owl#ZigBeeGateway`` =
        Prefixed_Name(dogont, ".owl#ZigBeeGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#tariffID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#tariffID">http://elite.polito.it/ontologies/dogont.owl#tariffID</seealso>
    let ``_.owl#tariffID`` = Prefixed_Name(dogont, ".owl#tariffID") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Bedroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A room used primarily for sleeping</para>
    /// labels<para>Bedroom</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bedroom">http://elite.polito.it/ontologies/dogont.owl#Bedroom</seealso>
    let ``_.owl#Bedroom`` = Prefixed_Name(dogont, ".owl#Bedroom") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Kitchen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A room equipped for preparing meals</para>
    /// labels<para>Kitchen</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Kitchen">http://elite.polito.it/ontologies/dogont.owl#Kitchen</seealso>
    let ``_.owl#Kitchen`` = Prefixed_Name(dogont, ".owl#Kitchen") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Lobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A large entrance</para>
    /// labels<para>Lobby</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Lobby">http://elite.polito.it/ontologies/dogont.owl#Lobby</seealso>
    let ``_.owl#Lobby`` = Prefixed_Name(dogont, ".owl#Lobby") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementFunctionality</seealso>
    let ``_.owl#ApparentPowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ApparentPowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ApparentPowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ApparentPowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RemainingTimeChangedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RemainingTimeChangedNotification">http://elite.polito.it/ontologies/dogont.owl#RemainingTimeChangedNotification</seealso>
    let ``_.owl#RemainingTimeChangedNotification`` =
        Prefixed_Name(dogont, ".owl#RemainingTimeChangedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartTimeChangedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartTimeChangedNotification">http://elite.polito.it/ontologies/dogont.owl#StartTimeChangedNotification</seealso>
    let ``_.owl#StartTimeChangedNotification`` =
        Prefixed_Name(dogont, ".owl#StartTimeChangedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColdWaterM3MeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColdWaterM3MeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ColdWaterM3MeasurementNotification</seealso>
    let ``_.owl#ColdWaterM3MeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ColdWaterM3MeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ColorNotificationFunctionality</seealso>
    let ``_.owl#ColorNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ColorNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorHSBNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorHSBNotification">http://elite.polito.it/ontologies/dogont.owl#ColorHSBNotification</seealso>
    let ``_.owl#ColorHSBNotification`` =
        Prefixed_Name(dogont, ".owl#ColorHSBNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorRGBNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorRGBNotification">http://elite.polito.it/ontologies/dogont.owl#ColorRGBNotification</seealso>
    let ``_.owl#ColorRGBNotification`` =
        Prefixed_Name(dogont, ".owl#ColorRGBNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseReactiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyState</seealso>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyState`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseReactiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#ReactiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification</seealso>
    let ``_.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkAuthenticationActiveNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationActiveNotification">http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationActiveNotification</seealso>
    let ``_.owl#PushLinkAuthenticationActiveNotification`` =
        Prefixed_Name(dogont, ".owl#PushLinkAuthenticationActiveNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkAuthenticationIdleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationIdleNotification">http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationIdleNotification</seealso>
    let ``_.owl#PushLinkAuthenticationIdleNotification`` =
        Prefixed_Name(dogont, ".owl#PushLinkAuthenticationIdleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartPushLinkAuthenticationCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartPushLinkAuthenticationCommand">http://elite.polito.it/ontologies/dogont.owl#StartPushLinkAuthenticationCommand</seealso>
    let ``_.owl#StartPushLinkAuthenticationCommand`` =
        Prefixed_Name(dogont, ".owl#StartPushLinkAuthenticationCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#QuadSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#QuadSensor">http://elite.polito.it/ontologies/dogont.owl#QuadSensor</seealso>
    let ``_.owl#QuadSensor`` = Prefixed_Name(dogont, ".owl#QuadSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementFunctionality</seealso>
    let ``_.owl#ReactivePowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ReactivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ReactivePowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ReactivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementState</seealso>
    let ``_.owl#ReactivePowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#ReactivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeter</seealso>
    let ``_.owl#ReactivePowerMeter`` =
        Prefixed_Name(dogont, ".owl#ReactivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RunState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RunState">http://elite.polito.it/ontologies/dogont.owl#RunState</seealso>
    let ``_.owl#RunState`` = Prefixed_Name(dogont, ".owl#RunState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SelfClosingDoorActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SelfClosingDoorActuator">http://elite.polito.it/ontologies/dogont.owl#SelfClosingDoorActuator</seealso>
    let ``_.owl#SelfClosingDoorActuator`` =
        Prefixed_Name(dogont, ".owl#SelfClosingDoorActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VerticalNoMovementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VerticalNoMovementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#VerticalNoMovementNotificationFunctionality</seealso>
    let ``_.owl#VerticalNoMovementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#VerticalNoMovementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VerticalMovementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VerticalMovementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#VerticalMovementNotificationFunctionality</seealso>
    let ``_.owl#VerticalMovementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#VerticalMovementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShutterState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShutterState">http://elite.polito.it/ontologies/dogont.owl#ShutterState</seealso>
    let ``_.owl#ShutterState`` =
        Prefixed_Name(dogont, ".owl#ShutterState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShutterButton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShutterButton">http://elite.polito.it/ontologies/dogont.owl#ShutterButton</seealso>
    let ``_.owl#ShutterButton`` =
        Prefixed_Name(dogont, ".owl#ShutterButton") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpDownRestState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>State: up - down - rest</para>
    /// labels<para>UpDownRestState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpDownRestState">http://elite.polito.it/ontologies/dogont.owl#UpDownRestState</seealso>
    let ``_.owl#UpDownRestState`` =
        Prefixed_Name(dogont, ".owl#UpDownRestState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotification</seealso>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyState</seealso>
    let ``_.owl#SinglePhaseActiveEnergyState`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleTariffEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleTariffEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#SingleTariffEnergyMeter</seealso>
    let ``_.owl#SingleTariffEnergyMeter`` =
        Prefixed_Name(dogont, ".owl#SingleTariffEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementFunctionality</seealso>
    let ``_.owl#SinglePhaseActivePowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TridimensionalAccelerationNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotification">http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotification</seealso>
    let ``_.owl#TridimensionalAccelerationNotification`` =
        Prefixed_Name(dogont, ".owl#TridimensionalAccelerationNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TridimensionalAccelerationNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotificationFunctionality</seealso>
    let ``_.owl#TridimensionalAccelerationNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#TridimensionalAccelerationNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TripleSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TripleSensor">http://elite.polito.it/ontologies/dogont.owl#TripleSensor</seealso>
    let ``_.owl#TripleSensor`` =
        Prefixed_Name(dogont, ".owl#TripleSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#returnType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#returnType">http://elite.polito.it/ontologies/dogont.owl#returnType</seealso>
    let ``_.owl#returnType`` = Prefixed_Name(dogont, ".owl#returnType") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#svgFootprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A property holding the svg footprint for the given building environment object</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#svgFootprint">http://elite.polito.it/ontologies/dogont.owl#svgFootprint</seealso>
    let ``_.owl#svgFootprint`` =
        Prefixed_Name(dogont, ".owl#svgFootprint") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DownTripleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DownTripleStateValue">http://elite.polito.it/ontologies/dogont.owl#DownTripleStateValue</seealso>
    let ``_.owl#DownTripleStateValue`` =
        Prefixed_Name(dogont, ".owl#DownTripleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FireUpStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FireUpStateValue">http://elite.polito.it/ontologies/dogont.owl#FireUpStateValue</seealso>
    let ``_.owl#FireUpStateValue`` =
        Prefixed_Name(dogont, ".owl#FireUpStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ForwardStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ForwardStateValue">http://elite.polito.it/ontologies/dogont.owl#ForwardStateValue</seealso>
    let ``_.owl#ForwardStateValue`` =
        Prefixed_Name(dogont, ".owl#ForwardStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdleStateValue">http://elite.polito.it/ontologies/dogont.owl#IdleStateValue</seealso>
    let ``_.owl#IdleStateValue`` =
        Prefixed_Name(dogont, ".owl#IdleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NoFailureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NoFailureStateValue">http://elite.polito.it/ontologies/dogont.owl#NoFailureStateValue</seealso>
    let ``_.owl#NoFailureStateValue`` =
        Prefixed_Name(dogont, ".owl#NoFailureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TimeRegulationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionalities for the regulation of timer</para>
    /// labels<para>TimeRegulationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TimeRegulationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TimeRegulationFunctionality</seealso>
    let ``_.owl#TimeRegulationFunctionality`` =
        Prefixed_Name(dogont, ".owl#TimeRegulationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FanControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Models the capability of controlling the speed of a cooling/heating fan. Derives from ZigBee HA</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FanControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#FanControlFunctionality</seealso>
    let ``_.owl#FanControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#FanControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CameraPictureZoomPanControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureZoomPanControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#CameraPictureZoomPanControlFunctionality</seealso>
    let ``_.owl#CameraPictureZoomPanControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#CameraPictureZoomPanControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TunerFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TunerFunctionality">http://elite.polito.it/ontologies/dogont.owl#TunerFunctionality</seealso>
    let ``_.owl#TunerFunctionality`` =
        Prefixed_Name(dogont, ".owl#TunerFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseQualityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseQualityCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseQualityCommand</seealso>
    let ``_.owl#DecreaseQualityCommand`` =
        Prefixed_Name(dogont, ".owl#DecreaseQualityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PanLeftCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PanLeftCommand">http://elite.polito.it/ontologies/dogont.owl#PanLeftCommand</seealso>
    let ``_.owl#PanLeftCommand`` =
        Prefixed_Name(dogont, ".owl#PanLeftCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PanUpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PanUpCommand">http://elite.polito.it/ontologies/dogont.owl#PanUpCommand</seealso>
    let ``_.owl#PanUpCommand`` =
        Prefixed_Name(dogont, ".owl#PanUpCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeleteSceneNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeleteSceneNotification">http://elite.polito.it/ontologies/dogont.owl#DeleteSceneNotification</seealso>
    let ``_.owl#DeleteSceneNotification`` =
        Prefixed_Name(dogont, ".owl#DeleteSceneNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoreSceneNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoreSceneNotification">http://elite.polito.it/ontologies/dogont.owl#StoreSceneNotification</seealso>
    let ``_.owl#StoreSceneNotification`` =
        Prefixed_Name(dogont, ".owl#StoreSceneNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureMeasurementMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementMNotification">http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementMNotification</seealso>
    let ``_.owl#PressureMeasurementMNotification`` =
        Prefixed_Name(dogont, ".owl#PressureMeasurementMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#JoinGroupNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#JoinGroupNotification">http://elite.polito.it/ontologies/dogont.owl#JoinGroupNotification</seealso>
    let ``_.owl#JoinGroupNotification`` =
        Prefixed_Name(dogont, ".owl#JoinGroupNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControlNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControlNotification">http://elite.polito.it/ontologies/dogont.owl#LevelControlNotification</seealso>
    let ``_.owl#LevelControlNotification`` =
        Prefixed_Name(dogont, ".owl#LevelControlNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureMeasurementMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementMNotification">http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementMNotification</seealso>
    let ``_.owl#TemperatureMeasurementMNotification`` =
        Prefixed_Name(dogont, ".owl#TemperatureMeasurementMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowRateMeasurementMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementMNotification">http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementMNotification</seealso>
    let ``_.owl#FlowRateMeasurementMNotification`` =
        Prefixed_Name(dogont, ".owl#FlowRateMeasurementMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetClimateScheduleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetClimateScheduleCommand">http://elite.polito.it/ontologies/dogont.owl#SetClimateScheduleCommand</seealso>
    let ``_.owl#SetClimateScheduleCommand`` =
        Prefixed_Name(dogont, ".owl#SetClimateScheduleCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DoubleValuedFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete functionalities with exactly two values</para>
    /// labels<para>DoubleValuedFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedFunctionality">http://elite.polito.it/ontologies/dogont.owl#DoubleValuedFunctionality</seealso>
    let ``_.owl#DoubleValuedFunctionality`` =
        Prefixed_Name(dogont, ".owl#DoubleValuedFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotification">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotification</seealso>
    let ``_.owl#ClimateScheduleNotification`` =
        Prefixed_Name(dogont, ".owl#ClimateScheduleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Notification of fixed values</para>
    /// labels<para>DiscreteNotificationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscreteNotificationFunctionality</seealso>
    let ``_.owl#DiscreteNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#DiscreteNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleQueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleQueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleQueryFunctionality</seealso>
    let ``_.owl#ClimateScheduleQueryFunctionality`` =
        Prefixed_Name(dogont, ".owl#ClimateScheduleQueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetClimateScheduleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetClimateScheduleCommand">http://elite.polito.it/ontologies/dogont.owl#GetClimateScheduleCommand</seealso>
    let ``_.owl#GetClimateScheduleCommand`` =
        Prefixed_Name(dogont, ".owl#GetClimateScheduleCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CloseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CloseCommand">http://elite.polito.it/ontologies/dogont.owl#CloseCommand</seealso>
    let ``_.owl#CloseCommand`` =
        Prefixed_Name(dogont, ".owl#CloseCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PreviousTrackCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PreviousTrackCommand">http://elite.polito.it/ontologies/dogont.owl#PreviousTrackCommand</seealso>
    let ``_.owl#PreviousTrackCommand`` =
        Prefixed_Name(dogont, ".owl#PreviousTrackCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetHourCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetHourCommand">http://elite.polito.it/ontologies/dogont.owl#SetHourCommand</seealso>
    let ``_.owl#SetHourCommand`` =
        Prefixed_Name(dogont, ".owl#SetHourCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StandBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StandBy">http://elite.polito.it/ontologies/dogont.owl#StandBy</seealso>
    let ``_.owl#StandBy`` = Prefixed_Name(dogont, ".owl#StandBy") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OffCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OffCommand">http://elite.polito.it/ontologies/dogont.owl#OffCommand</seealso>
    let ``_.owl#OffCommand`` = Prefixed_Name(dogont, ".owl#OffCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GoToTrackCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GoToTrackCommand">http://elite.polito.it/ontologies/dogont.owl#GoToTrackCommand</seealso>
    let ``_.owl#GoToTrackCommand`` =
        Prefixed_Name(dogont, ".owl#GoToTrackCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ForwardCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ForwardCommand">http://elite.polito.it/ontologies/dogont.owl#ForwardCommand</seealso>
    let ``_.owl#ForwardCommand`` =
        Prefixed_Name(dogont, ".owl#ForwardCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoreSceneCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoreSceneCommand">http://elite.polito.it/ontologies/dogont.owl#StoreSceneCommand</seealso>
    let ``_.owl#StoreSceneCommand`` =
        Prefixed_Name(dogont, ".owl#StoreSceneCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnFlashingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnFlashingCommand">http://elite.polito.it/ontologies/dogont.owl#OnFlashingCommand</seealso>
    let ``_.owl#OnFlashingCommand`` =
        Prefixed_Name(dogont, ".owl#OnFlashingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpCommand">http://elite.polito.it/ontologies/dogont.owl#UpCommand</seealso>
    let ``_.owl#UpCommand`` = Prefixed_Name(dogont, ".owl#UpCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetPressureCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetPressureCommand">http://elite.polito.it/ontologies/dogont.owl#GetPressureCommand</seealso>
    let ``_.owl#GetPressureCommand`` =
        Prefixed_Name(dogont, ".owl#GetPressureCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnCommand">http://elite.polito.it/ontologies/dogont.owl#OnCommand</seealso>
    let ``_.owl#OnCommand`` = Prefixed_Name(dogont, ".owl#OnCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopPlayingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopPlayingCommand">http://elite.polito.it/ontologies/dogont.owl#StopPlayingCommand</seealso>
    let ``_.owl#StopPlayingCommand`` =
        Prefixed_Name(dogont, ".owl#StopPlayingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OffFlashingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OffFlashingCommand">http://elite.polito.it/ontologies/dogont.owl#OffFlashingCommand</seealso>
    let ``_.owl#OffFlashingCommand`` =
        Prefixed_Name(dogont, ".owl#OffFlashingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeleteSceneCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeleteSceneCommand">http://elite.polito.it/ontologies/dogont.owl#DeleteSceneCommand</seealso>
    let ``_.owl#DeleteSceneCommand`` =
        Prefixed_Name(dogont, ".owl#DeleteSceneCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedUpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedUpCommand">http://elite.polito.it/ontologies/dogont.owl#SpeedUpCommand</seealso>
    let ``_.owl#SpeedUpCommand`` =
        Prefixed_Name(dogont, ".owl#SpeedUpCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CloseNetworkCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CloseNetworkCommand">http://elite.polito.it/ontologies/dogont.owl#CloseNetworkCommand</seealso>
    let ``_.owl#CloseNetworkCommand`` =
        Prefixed_Name(dogont, ".owl#CloseNetworkCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetCo2ConcentrationCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetCo2ConcentrationCommand">http://elite.polito.it/ontologies/dogont.owl#GetCo2ConcentrationCommand</seealso>
    let ``_.owl#GetCo2ConcentrationCommand`` =
        Prefixed_Name(dogont, ".owl#GetCo2ConcentrationCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotification</seealso>
    let ``_.owl#Co2MeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#Co2MeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotificationFunctionality</seealso>
    let ``_.owl#Co2MeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#Co2MeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementStateValue">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementStateValue</seealso>
    let ``_.owl#Co2MeasurementStateValue`` =
        Prefixed_Name(dogont, ".owl#Co2MeasurementStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ContinuousState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>States continuous in time or space</para>
    /// labels<para>ContinuousState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ContinuousState">http://elite.polito.it/ontologies/dogont.owl#ContinuousState</seealso>
    let ``_.owl#ContinuousState`` =
        Prefixed_Name(dogont, ".owl#ContinuousState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2Sensor">http://elite.polito.it/ontologies/dogont.owl#Co2Sensor</seealso>
    let ``_.owl#Co2Sensor`` = Prefixed_Name(dogont, ".owl#Co2Sensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetColorRGBCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetColorRGBCommand">http://elite.polito.it/ontologies/dogont.owl#SetColorRGBCommand</seealso>
    let ``_.owl#SetColorRGBCommand`` =
        Prefixed_Name(dogont, ".owl#SetColorRGBCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetColorHSBCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetColorHSBCommand">http://elite.polito.it/ontologies/dogont.owl#SetColorHSBCommand</seealso>
    let ``_.owl#SetColorHSBCommand`` =
        Prefixed_Name(dogont, ".owl#SetColorHSBCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorDimmableLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Color Dimmable Light device can be switched on and off, and its luminance, hue and saturation levels may be controlled, derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorDimmableLight">http://elite.polito.it/ontologies/dogont.owl#ColorDimmableLight</seealso>
    let ``_.owl#ColorDimmableLight`` =
        Prefixed_Name(dogont, ".owl#ColorDimmableLight") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorState">http://elite.polito.it/ontologies/dogont.owl#ColorState</seealso>
    let ``_.owl#ColorState`` = Prefixed_Name(dogont, ".owl#ColorState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DimmableLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Dimmable Light device is a light that can be switched on and off, and whose luminance level may be controlled, derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DimmableLight">http://elite.polito.it/ontologies/dogont.owl#DimmableLight</seealso>
    let ``_.owl#DimmableLight`` =
        Prefixed_Name(dogont, ".owl#DimmableLight") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorDimmerSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Color Dimmer Switch device can turn a light on and off, and control the luminance, hue and saturation levels of a multicolor light, derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorDimmerSwitch">http://elite.polito.it/ontologies/dogont.owl#ColorDimmerSwitch</seealso>
    let ``_.owl#ColorDimmerSwitch`` =
        Prefixed_Name(dogont, ".owl#ColorDimmerSwitch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#controlledObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association between a controller and the controlled object</para>
    /// labels<para>controlledObject</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#controlledObject">http://elite.polito.it/ontologies/dogont.owl#controlledObject</seealso>
    let ``_.owl#controlledObject`` =
        Prefixed_Name(dogont, ".owl#controlledObject") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DimmerSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Switch for controlling dimmable lights, derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DimmerSwitch">http://elite.polito.it/ontologies/dogont.owl#DimmerSwitch</seealso>
    let ``_.owl#DimmerSwitch`` =
        Prefixed_Name(dogont, ".owl#DimmerSwitch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Vertical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The vertical architectural component of a building</para>
    /// labels<para>Vertical</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Vertical">http://elite.polito.it/ontologies/dogont.owl#Vertical</seealso>
    let ``_.owl#Vertical`` = Prefixed_Name(dogont, ".owl#Vertical") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FenceOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An opening in a Fence</para>
    /// labels<para>FenceOpening</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FenceOpening">http://elite.polito.it/ontologies/dogont.owl#FenceOpening</seealso>
    let ``_.owl#FenceOpening`` =
        Prefixed_Name(dogont, ".owl#FenceOpening") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Wall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An architectural partition used to divide or enclose an area or to support another structure.</para>
    /// labels<para>Wall</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Wall">http://elite.polito.it/ontologies/dogont.owl#Wall</seealso>
    let ``_.owl#Wall`` = Prefixed_Name(dogont, ".owl#Wall") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FireHeatCoolNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FireHeatCoolNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#FireHeatCoolNotificationFunctionality</seealso>
    let ``_.owl#FireHeatCoolNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#FireHeatCoolNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffFlashingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionality to switch on and off an object with a given switching period</para>
    /// labels<para>OnOffFlashingFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffFlashingFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffFlashingFunctionality</seealso>
    let ``_.owl#OnOffFlashingFunctionality`` =
        Prefixed_Name(dogont, ".owl#OnOffFlashingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simple lamp that can be just turn on or turn off</para>
    /// labels<para>SimpleLamp</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffLight">http://elite.polito.it/ontologies/dogont.owl#OnOffLight</seealso>
    let ``_.owl#OnOffLight`` = Prefixed_Name(dogont, ".owl#OnOffLight") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SensingState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SensingState">http://elite.polito.it/ontologies/dogont.owl#SensingState</seealso>
    let ``_.owl#SensingState`` =
        Prefixed_Name(dogont, ".owl#SensingState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementFunctionality</seealso>
    let ``_.owl#FlowMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#FlowMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The capability of measuring the humidity of a room</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementFunctionality</seealso>
    let ``_.owl#HumidityMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#HumidityMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LightSensingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The capability of sensing the luminance of the environment in which a device is located accepts only the get command, with 1 parameter, i.e. the luminance value. Derives from ZigBee specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LightSensingFunctionality">http://elite.polito.it/ontologies/dogont.owl#LightSensingFunctionality</seealso>
    let ``_.owl#LightSensingFunctionality`` =
        Prefixed_Name(dogont, ".owl#LightSensingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OccupancySensingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionality for getting the occupancy state of a given room</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OccupancySensingFunctionality">http://elite.polito.it/ontologies/dogont.owl#OccupancySensingFunctionality</seealso>
    let ``_.owl#OccupancySensingFunctionality`` =
        Prefixed_Name(dogont, ".owl#OccupancySensingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PictureGrabFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PictureGrabFunctionality">http://elite.polito.it/ontologies/dogont.owl#PictureGrabFunctionality</seealso>
    let ``_.owl#PictureGrabFunctionality`` =
        Prefixed_Name(dogont, ".owl#PictureGrabFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SimpleMovementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SimpleMovementNotification">http://elite.polito.it/ontologies/dogont.owl#SimpleMovementNotification</seealso>
    let ``_.owl#SimpleMovementNotification`` =
        Prefixed_Name(dogont, ".owl#SimpleMovementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelStepUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelStepUpNotification">http://elite.polito.it/ontologies/dogont.owl#LevelStepUpNotification</seealso>
    let ``_.owl#LevelStepUpNotification`` =
        Prefixed_Name(dogont, ".owl#LevelStepUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotification</seealso>
    let ``_.owl#HumidityMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#HumidityMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelStepDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelStepDownNotification">http://elite.polito.it/ontologies/dogont.owl#LevelStepDownNotification</seealso>
    let ``_.owl#LevelStepDownNotification`` =
        Prefixed_Name(dogont, ".owl#LevelStepDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotification</seealso>
    let ``_.owl#TemperatureMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#TemperatureMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotification</seealso>
    let ``_.owl#PressureMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#PressureMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SimpleNoMovementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SimpleNoMovementNotification">http://elite.polito.it/ontologies/dogont.owl#SimpleNoMovementNotification</seealso>
    let ``_.owl#SimpleNoMovementNotification`` =
        Prefixed_Name(dogont, ".owl#SimpleNoMovementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureState">http://elite.polito.it/ontologies/dogont.owl#PressureState</seealso>
    let ``_.owl#PressureState`` =
        Prefixed_Name(dogont, ".owl#PressureState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShadeState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShadeState">http://elite.polito.it/ontologies/dogont.owl#ShadeState</seealso>
    let ``_.owl#ShadeState`` = Prefixed_Name(dogont, ".owl#ShadeState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Models the temperature value</para>
    /// labels<para>TemperatureState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureState">http://elite.polito.it/ontologies/dogont.owl#TemperatureState</seealso>
    let ``_.owl#TemperatureState`` =
        Prefixed_Name(dogont, ".owl#TemperatureState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TunerState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TunerState">http://elite.polito.it/ontologies/dogont.owl#TunerState</seealso>
    let ``_.owl#TunerState`` = Prefixed_Name(dogont, ".owl#TunerState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#FlowSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowSensor">http://elite.polito.it/ontologies/dogont.owl#FlowSensor</seealso>
    let ``_.owl#FlowSensor`` = Prefixed_Name(dogont, ".owl#FlowSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ForwardNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ForwardNotification">http://elite.polito.it/ontologies/dogont.owl#ForwardNotification</seealso>
    let ``_.owl#ForwardNotification`` =
        Prefixed_Name(dogont, ".owl#ForwardNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementFunctionality</seealso>
    let ``_.owl#FrequencyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#FrequencyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#FrequencyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#FrequencyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementState">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementState</seealso>
    let ``_.owl#FrequencyMeasurementState`` =
        Prefixed_Name(dogont, ".owl#FrequencyMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyStateValue">http://elite.polito.it/ontologies/dogont.owl#FrequencyStateValue</seealso>
    let ``_.owl#FrequencyStateValue`` =
        Prefixed_Name(dogont, ".owl#FrequencyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeter">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeter</seealso>
    let ``_.owl#FrequencyMeter`` =
        Prefixed_Name(dogont, ".owl#FrequencyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperCoolingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotificationFunctionality</seealso>
    let ``_.owl#SuperCoolingNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SuperCoolingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasFloor">http://elite.polito.it/ontologies/dogont.owl#hasFloor</seealso>
    let ``_.owl#hasFloor`` = Prefixed_Name(dogont, ".owl#hasFloor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasCeiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasCeiling">http://elite.polito.it/ontologies/dogont.owl#hasCeiling</seealso>
    let ``_.owl#hasCeiling`` = Prefixed_Name(dogont, ".owl#hasCeiling") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#GasHeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Heater that combusts gas</para>
    /// labels<para>GasHeater</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasHeater">http://elite.polito.it/ontologies/dogont.owl#GasHeater</seealso>
    let ``_.owl#GasHeater`` = Prefixed_Name(dogont, ".owl#GasHeater") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Heater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device that heats water or supplies warmth</para>
    /// labels<para>Heater</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Heater">http://elite.polito.it/ontologies/dogont.owl#Heater</seealso>
    let ``_.owl#Heater`` = Prefixed_Name(dogont, ".owl#Heater") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasoilHeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Heater that combusts gasoil</para>
    /// labels<para>GasoilHeater</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasoilHeater">http://elite.polito.it/ontologies/dogont.owl#GasoilHeater</seealso>
    let ``_.owl#GasoilHeater`` =
        Prefixed_Name(dogont, ".owl#GasoilHeater") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PelletHeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Heater that combusts wood-pellet</para>
    /// labels<para>PelletHeater</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PelletHeater">http://elite.polito.it/ontologies/dogont.owl#PelletHeater</seealso>
    let ``_.owl#PelletHeater`` =
        Prefixed_Name(dogont, ".owl#PelletHeater") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasM3MeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasM3MeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#GasM3MeasurementNotification</seealso>
    let ``_.owl#GasM3MeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#GasM3MeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#GasMeasurementFunctionality</seealso>
    let ``_.owl#GasMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#GasMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetConsumedM3Gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetConsumedM3Gas">http://elite.polito.it/ontologies/dogont.owl#GetConsumedM3Gas</seealso>
    let ``_.owl#GetConsumedM3Gas`` =
        Prefixed_Name(dogont, ".owl#GetConsumedM3Gas") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementState">http://elite.polito.it/ontologies/dogont.owl#GasMeasurementState</seealso>
    let ``_.owl#GasMeasurementState`` =
        Prefixed_Name(dogont, ".owl#GasMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasStateValue">http://elite.polito.it/ontologies/dogont.owl#GasStateValue</seealso>
    let ``_.owl#GasStateValue`` =
        Prefixed_Name(dogont, ".owl#GasStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasMeter">http://elite.polito.it/ontologies/dogont.owl#GasMeter</seealso>
    let ``_.owl#GasMeter`` = Prefixed_Name(dogont, ".owl#GasMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseActiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActiveEnergyCommand</seealso>
    let ``_.owl#Get1PhaseActiveEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#Get1PhaseActiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NonVoidCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NonVoidCommand">http://elite.polito.it/ontologies/dogont.owl#NonVoidCommand</seealso>
    let ``_.owl#NonVoidCommand`` =
        Prefixed_Name(dogont, ".owl#NonVoidCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseActivePowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActivePowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActivePowerCommand</seealso>
    let ``_.owl#Get1PhaseActivePowerCommand`` =
        Prefixed_Name(dogont, ".owl#Get1PhaseActivePowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseApparentPowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseApparentPowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseApparentPowerCommand</seealso>
    let ``_.owl#Get1PhaseApparentPowerCommand`` =
        Prefixed_Name(dogont, ".owl#Get1PhaseApparentPowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseCurrentCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseCurrentCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseCurrentCommand</seealso>
    let ``_.owl#Get1PhaseCurrentCommand`` =
        Prefixed_Name(dogont, ".owl#Get1PhaseCurrentCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseReactiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactiveEnergyCommand</seealso>
    let ``_.owl#Get1PhaseReactiveEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#Get1PhaseReactiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseReactivePowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactivePowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactivePowerCommand</seealso>
    let ``_.owl#Get1PhaseReactivePowerCommand`` =
        Prefixed_Name(dogont, ".owl#Get1PhaseReactivePowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseVoltageCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseVoltageCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseVoltageCommand</seealso>
    let ``_.owl#Get1PhaseVoltageCommand`` =
        Prefixed_Name(dogont, ".owl#Get1PhaseVoltageCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseActiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActiveEnergyCommand</seealso>
    let ``_.owl#Get3PhaseActiveEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#Get3PhaseActiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseActivePowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActivePowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActivePowerCommand</seealso>
    let ``_.owl#Get3PhaseActivePowerCommand`` =
        Prefixed_Name(dogont, ".owl#Get3PhaseActivePowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseCurrentCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseCurrentCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseCurrentCommand</seealso>
    let ``_.owl#Get3PhaseCurrentCommand`` =
        Prefixed_Name(dogont, ".owl#Get3PhaseCurrentCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseLLVoltageCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLLVoltageCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLLVoltageCommand</seealso>
    let ``_.owl#Get3PhaseLLVoltageCommand`` =
        Prefixed_Name(dogont, ".owl#Get3PhaseLLVoltageCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseLNVoltageCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLNVoltageCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLNVoltageCommand</seealso>
    let ``_.owl#Get3PhaseLNVoltageCommand`` =
        Prefixed_Name(dogont, ".owl#Get3PhaseLNVoltageCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseReactiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactiveEnergyCommand</seealso>
    let ``_.owl#Get3PhaseReactiveEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#Get3PhaseReactiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseReactivePowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactivePowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactivePowerCommand</seealso>
    let ``_.owl#Get3PhaseReactivePowerCommand`` =
        Prefixed_Name(dogont, ".owl#Get3PhaseReactivePowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotification</seealso>
    let ``_.owl#SinglePhaseActivePowerMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActivePowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementState</seealso>
    let ``_.owl#SinglePhaseActivePowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseActivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementFunctionality</seealso>
    let ``_.owl#SinglePhaseApparentPowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseApparentPowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotification</seealso>
    let ``_.owl#SinglePhaseApparentPowerMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseApparentPowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementState</seealso>
    let ``_.owl#SinglePhaseApparentPowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseApparentPowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeter</seealso>
    let ``_.owl#SinglePhaseApparentPowerMeter`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseApparentPowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementFunctionality</seealso>
    let ``_.owl#SinglePhaseCurrentMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseCurrentMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotification</seealso>
    let ``_.owl#SinglePhaseCurrentMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseCurrentMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyState</seealso>
    let ``_.owl#SinglePhaseReactiveEnergyState`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotification</seealso>
    let ``_.owl#SinglePhaseReactiveEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementFunctionality</seealso>
    let ``_.owl#SinglePhaseReactivePowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotification</seealso>
    let ``_.owl#SinglePhaseReactivePowerMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactivePowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementState</seealso>
    let ``_.owl#SinglePhaseReactivePowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementFunctionality</seealso>
    let ``_.owl#SinglePhaseVoltageMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseVoltageMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementFunctionality</seealso>
    let ``_.owl#VoltageMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#VoltageMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#sleepTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time between connection trials</para>
    /// labels<para>sleepTime</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#sleepTime">http://elite.polito.it/ontologies/dogont.owl#sleepTime</seealso>
    let ``_.owl#sleepTime`` = Prefixed_Name(dogont, ".owl#sleepTime") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#stepValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#stepValue">http://elite.polito.it/ontologies/dogont.owl#stepValue</seealso>
    let ``_.owl#stepValue`` = Prefixed_Name(dogont, ".owl#stepValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OnOffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>State: on - off</para>
    /// labels<para>OnOffState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffState">http://elite.polito.it/ontologies/dogont.owl#OnOffState</seealso>
    let ``_.owl#OnOffState`` = Prefixed_Name(dogont, ".owl#OnOffState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PumpController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Pump device controller can control a Pump device</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PumpController">http://elite.polito.it/ontologies/dogont.owl#PumpController</seealso>
    let ``_.owl#PumpController`` =
        Prefixed_Name(dogont, ".owl#PumpController") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Clock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Clock">http://elite.polito.it/ontologies/dogont.owl#Clock</seealso>
    let ``_.owl#Clock`` = Prefixed_Name(dogont, ".owl#Clock") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ParametricNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ParametricNotification">http://elite.polito.it/ontologies/dogont.owl#ParametricNotification</seealso>
    let ``_.owl#ParametricNotification`` =
        Prefixed_Name(dogont, ".owl#ParametricNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AlertNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AlertNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#AlertNotificationFunctionality</seealso>
    let ``_.owl#AlertNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#AlertNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetMinutesCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetMinutesCommand">http://elite.polito.it/ontologies/dogont.owl#SetMinutesCommand</seealso>
    let ``_.owl#SetMinutesCommand`` =
        Prefixed_Name(dogont, ".owl#SetMinutesCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetRelativeHumidityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityCommand">http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityCommand</seealso>
    let ``_.owl#GetRelativeHumidityCommand`` =
        Prefixed_Name(dogont, ".owl#GetRelativeHumidityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenCommand">http://elite.polito.it/ontologies/dogont.owl#OpenCommand</seealso>
    let ``_.owl#OpenCommand`` =
        Prefixed_Name(dogont, ".owl#OpenCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetTemperatureCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetTemperatureCommand">http://elite.polito.it/ontologies/dogont.owl#GetTemperatureCommand</seealso>
    let ``_.owl#GetTemperatureCommand`` =
        Prefixed_Name(dogont, ".owl#GetTemperatureCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementFunctionality</seealso>
    let ``_.owl#Co2MeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#Co2MeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementState">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementState</seealso>
    let ``_.owl#Co2MeasurementState`` =
        Prefixed_Name(dogont, ".owl#Co2MeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FaultState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FaultState">http://elite.polito.it/ontologies/dogont.owl#FaultState</seealso>
    let ``_.owl#FaultState`` = Prefixed_Name(dogont, ".owl#FaultState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleStateValue">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleStateValue</seealso>
    let ``_.owl#ClimateScheduleStateValue`` =
        Prefixed_Name(dogont, ".owl#ClimateScheduleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ConnectedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ConnectedStateValue">http://elite.polito.it/ontologies/dogont.owl#ConnectedStateValue</seealso>
    let ``_.owl#ConnectedStateValue`` =
        Prefixed_Name(dogont, ".owl#ConnectedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DetectedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DetectedStateValue">http://elite.polito.it/ontologies/dogont.owl#DetectedStateValue</seealso>
    let ``_.owl#DetectedStateValue`` =
        Prefixed_Name(dogont, ".owl#DetectedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisconnectedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisconnectedStateValue">http://elite.polito.it/ontologies/dogont.owl#DisconnectedStateValue</seealso>
    let ``_.owl#DisconnectedStateValue`` =
        Prefixed_Name(dogont, ".owl#DisconnectedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EndProgrammedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EndProgrammedStateValue">http://elite.polito.it/ontologies/dogont.owl#EndProgrammedStateValue</seealso>
    let ``_.owl#EndProgrammedStateValue`` =
        Prefixed_Name(dogont, ".owl#EndProgrammedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryState">http://elite.polito.it/ontologies/dogont.owl#DiscoveryState</seealso>
    let ``_.owl#DiscoveryState`` =
        Prefixed_Name(dogont, ".owl#DiscoveryState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayNotification">http://elite.polito.it/ontologies/dogont.owl#PlayNotification</seealso>
    let ``_.owl#PlayNotification`` =
        Prefixed_Name(dogont, ".owl#PlayNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RewindNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RewindNotification">http://elite.polito.it/ontologies/dogont.owl#RewindNotification</seealso>
    let ``_.owl#RewindNotification`` =
        Prefixed_Name(dogont, ".owl#RewindNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopPlaybackNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopPlaybackNotification">http://elite.polito.it/ontologies/dogont.owl#StopPlaybackNotification</seealso>
    let ``_.owl#StopPlaybackNotification`` =
        Prefixed_Name(dogont, ".owl#StopPlaybackNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TrackControlNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TrackControlNotification">http://elite.polito.it/ontologies/dogont.owl#TrackControlNotification</seealso>
    let ``_.owl#TrackControlNotification`` =
        Prefixed_Name(dogont, ".owl#TrackControlNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementFunctionality</seealso>
    let ``_.owl#PowerFactorMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#PowerFactorMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StepShutterActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StepShutterActuator">http://elite.polito.it/ontologies/dogont.owl#StepShutterActuator</seealso>
    let ``_.owl#StepShutterActuator`` =
        Prefixed_Name(dogont, ".owl#StepShutterActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WirelessPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Phone with no wire</para>
    /// labels<para>WirelessPhone</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WirelessPhone">http://elite.polito.it/ontologies/dogont.owl#WirelessPhone</seealso>
    let ``_.owl#WirelessPhone`` =
        Prefixed_Name(dogont, ".owl#WirelessPhone") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PhonoStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PhonoStateValue">http://elite.polito.it/ontologies/dogont.owl#PhonoStateValue</seealso>
    let ``_.owl#PhonoStateValue`` =
        Prefixed_Name(dogont, ".owl#PhonoStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ProgrammedAndWaitingToStartStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ProgrammedAndWaitingToStartStateValue">http://elite.polito.it/ontologies/dogont.owl#ProgrammedAndWaitingToStartStateValue</seealso>
    let ``_.owl#ProgrammedAndWaitingToStartStateValue`` =
        Prefixed_Name(dogont, ".owl#ProgrammedAndWaitingToStartStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RinseHoldStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RinseHoldStateValue">http://elite.polito.it/ontologies/dogont.owl#RinseHoldStateValue</seealso>
    let ``_.owl#RinseHoldStateValue`` =
        Prefixed_Name(dogont, ".owl#RinseHoldStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperCoolingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingStateValue">http://elite.polito.it/ontologies/dogont.owl#SuperCoolingStateValue</seealso>
    let ``_.owl#SuperCoolingStateValue`` =
        Prefixed_Name(dogont, ".owl#SuperCoolingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseQualityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseQualityCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseQualityCommand</seealso>
    let ``_.owl#IncreaseQualityCommand`` =
        Prefixed_Name(dogont, ".owl#IncreaseQualityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetHotWaterM3Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetHotWaterM3Command">http://elite.polito.it/ontologies/dogont.owl#GetHotWaterM3Command</seealso>
    let ``_.owl#GetHotWaterM3Command`` =
        Prefixed_Name(dogont, ".owl#GetHotWaterM3Command") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Bathroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A room containing a bath or shower and usually a washbasin and toilet</para>
    /// labels<para>Bathroom</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bathroom">http://elite.polito.it/ontologies/dogont.owl#Bathroom</seealso>
    let ``_.owl#Bathroom`` = Prefixed_Name(dogont, ".owl#Bathroom") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#LivingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A room where people can sit and talk and relax</para>
    /// labels<para>LivingRoom</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LivingRoom">http://elite.polito.it/ontologies/dogont.owl#LivingRoom</seealso>
    let ``_.owl#LivingRoom`` = Prefixed_Name(dogont, ".owl#LivingRoom") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StorageRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Little Room for storage of things in the house</para>
    /// labels<para>StorageRoom</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StorageRoom">http://elite.polito.it/ontologies/dogont.owl#StorageRoom</seealso>
    let ``_.owl#StorageRoom`` =
        Prefixed_Name(dogont, ".owl#StorageRoom") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NextTrackCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NextTrackCommand">http://elite.polito.it/ontologies/dogont.owl#NextTrackCommand</seealso>
    let ``_.owl#NextTrackCommand`` =
        Prefixed_Name(dogont, ".owl#NextTrackCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetFlowRateCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetFlowRateCommand">http://elite.polito.it/ontologies/dogont.owl#GetFlowRateCommand</seealso>
    let ``_.owl#GetFlowRateCommand`` =
        Prefixed_Name(dogont, ".owl#GetFlowRateCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoreGroupCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoreGroupCommand">http://elite.polito.it/ontologies/dogont.owl#StoreGroupCommand</seealso>
    let ``_.owl#StoreGroupCommand`` =
        Prefixed_Name(dogont, ".owl#StoreGroupCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatCommand">http://elite.polito.it/ontologies/dogont.owl#HeatCommand</seealso>
    let ``_.owl#HeatCommand`` =
        Prefixed_Name(dogont, ".owl#HeatCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetDesiredTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetDesiredTemperature">http://elite.polito.it/ontologies/dogont.owl#SetDesiredTemperature</seealso>
    let ``_.owl#SetDesiredTemperature`` =
        Prefixed_Name(dogont, ".owl#SetDesiredTemperature") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GrabPictureCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GrabPictureCommand">http://elite.polito.it/ontologies/dogont.owl#GrabPictureCommand</seealso>
    let ``_.owl#GrabPictureCommand`` =
        Prefixed_Name(dogont, ".owl#GrabPictureCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedDownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedDownCommand">http://elite.polito.it/ontologies/dogont.owl#SpeedDownCommand</seealso>
    let ``_.owl#SpeedDownCommand`` =
        Prefixed_Name(dogont, ".owl#SpeedDownCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ToggleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ToggleCommand">http://elite.polito.it/ontologies/dogont.owl#ToggleCommand</seealso>
    let ``_.owl#ToggleCommand`` =
        Prefixed_Name(dogont, ".owl#ToggleCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiningRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A room used for dining</para>
    /// labels<para>DiningRoom</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiningRoom">http://elite.polito.it/ontologies/dogont.owl#DiningRoom</seealso>
    let ``_.owl#DiningRoom`` = Prefixed_Name(dogont, ".owl#DiningRoom") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentStateValue">http://elite.polito.it/ontologies/dogont.owl#CurrentStateValue</seealso>
    let ``_.owl#CurrentStateValue`` =
        Prefixed_Name(dogont, ".owl#CurrentStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ChangedDesiredTemperatureNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ChangedDesiredTemperatureNotification">http://elite.polito.it/ontologies/dogont.owl#ChangedDesiredTemperatureNotification</seealso>
    let ``_.owl#ChangedDesiredTemperatureNotification`` =
        Prefixed_Name(dogont, ".owl#ChangedDesiredTemperatureNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementMNotification">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementMNotification</seealso>
    let ``_.owl#HumidityMeasurementMNotification`` =
        Prefixed_Name(dogont, ".owl#HumidityMeasurementMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LeaveGroupNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LeaveGroupNotification">http://elite.polito.it/ontologies/dogont.owl#LeaveGroupNotification</seealso>
    let ``_.owl#LeaveGroupNotification`` =
        Prefixed_Name(dogont, ".owl#LeaveGroupNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ChannelControlNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ChannelControlNotification">http://elite.polito.it/ontologies/dogont.owl#ChannelControlNotification</seealso>
    let ``_.owl#ChannelControlNotification`` =
        Prefixed_Name(dogont, ".owl#ChannelControlNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ParametricLevelNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ParametricLevelNotification">http://elite.polito.it/ontologies/dogont.owl#ParametricLevelNotification</seealso>
    let ``_.owl#ParametricLevelNotification`` =
        Prefixed_Name(dogont, ".owl#ParametricLevelNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetDailyClimateScheduleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetDailyClimateScheduleCommand">http://elite.polito.it/ontologies/dogont.owl#SetDailyClimateScheduleCommand</seealso>
    let ``_.owl#SetDailyClimateScheduleCommand`` =
        Prefixed_Name(dogont, ".owl#SetDailyClimateScheduleCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotificationFunctionality</seealso>
    let ``_.owl#ClimateScheduleNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ClimateScheduleNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DailyClimateScheduleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DailyClimateScheduleNotification">http://elite.polito.it/ontologies/dogont.owl#DailyClimateScheduleNotification</seealso>
    let ``_.owl#DailyClimateScheduleNotification`` =
        Prefixed_Name(dogont, ".owl#DailyClimateScheduleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleState">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleState</seealso>
    let ``_.owl#ClimateScheduleState`` =
        Prefixed_Name(dogont, ".owl#ClimateScheduleState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>States not continuous, with fixed values</para>
    /// labels<para>DiscreteState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteState">http://elite.polito.it/ontologies/dogont.owl#DiscreteState</seealso>
    let ``_.owl#DiscreteState`` =
        Prefixed_Name(dogont, ".owl#DiscreteState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayState">http://elite.polito.it/ontologies/dogont.owl#PlayState</seealso>
    let ``_.owl#PlayState`` = Prefixed_Name(dogont, ".owl#PlayState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SourceSelectionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionState">http://elite.polito.it/ontologies/dogont.owl#SourceSelectionState</seealso>
    let ``_.owl#SourceSelectionState`` =
        Prefixed_Name(dogont, ".owl#SourceSelectionState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LoweringStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LoweringStateValue">http://elite.polito.it/ontologies/dogont.owl#LoweringStateValue</seealso>
    let ``_.owl#LoweringStateValue`` =
        Prefixed_Name(dogont, ".owl#LoweringStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MeteringPowerOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MeteringPowerOutlet">http://elite.polito.it/ontologies/dogont.owl#MeteringPowerOutlet</seealso>
    let ``_.owl#MeteringPowerOutlet`` =
        Prefixed_Name(dogont, ".owl#MeteringPowerOutlet") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeter">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeter</seealso>
    let ``_.owl#PowerFactorMeter`` =
        Prefixed_Name(dogont, ".owl#PowerFactorMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MicrowaveEmissionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionState">http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionState</seealso>
    let ``_.owl#MicrowaveEmissionState`` =
        Prefixed_Name(dogont, ".owl#MicrowaveEmissionState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopSuperHeatingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopSuperHeatingCommand">http://elite.polito.it/ontologies/dogont.owl#StopSuperHeatingCommand</seealso>
    let ``_.owl#StopSuperHeatingCommand`` =
        Prefixed_Name(dogont, ".owl#StopSuperHeatingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopSupercoolingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopSupercoolingCommand">http://elite.polito.it/ontologies/dogont.owl#StopSupercoolingCommand</seealso>
    let ``_.owl#StopSupercoolingCommand`` =
        Prefixed_Name(dogont, ".owl#StopSupercoolingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedSuperFreezingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperFreezingNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedSuperFreezingNotification</seealso>
    let ``_.owl#StoppedSuperFreezingNotification`` =
        Prefixed_Name(dogont, ".owl#StoppedSuperFreezingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedSuperHeatingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperHeatingNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedSuperHeatingNotification</seealso>
    let ``_.owl#StoppedSuperHeatingNotification`` =
        Prefixed_Name(dogont, ".owl#StoppedSuperHeatingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedWashingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedWashingNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedWashingNotification</seealso>
    let ``_.owl#StoppedWashingNotification`` =
        Prefixed_Name(dogont, ".owl#StoppedWashingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureAndHumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureAndHumiditySensor">http://elite.polito.it/ontologies/dogont.owl#TemperatureAndHumiditySensor</seealso>
    let ``_.owl#TemperatureAndHumiditySensor`` =
        Prefixed_Name(dogont, ".owl#TemperatureAndHumiditySensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TexasInstrumentsComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsComponent">http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsComponent</seealso>
    let ``_.owl#TexasInstrumentsComponent`` =
        Prefixed_Name(dogont, ".owl#TexasInstrumentsComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TexasInstrumentsGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsGateway">http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsGateway</seealso>
    let ``_.owl#TexasInstrumentsGateway`` =
        Prefixed_Name(dogont, ".owl#TexasInstrumentsGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApplianceRunNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApplianceRunNotification">http://elite.polito.it/ontologies/dogont.owl#ApplianceRunNotification</seealso>
    let ``_.owl#ApplianceRunNotification`` =
        Prefixed_Name(dogont, ".owl#ApplianceRunNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PauseApplianceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PauseApplianceNotification">http://elite.polito.it/ontologies/dogont.owl#PauseApplianceNotification</seealso>
    let ``_.owl#PauseApplianceNotification`` =
        Prefixed_Name(dogont, ".owl#PauseApplianceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Controllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All building things that can be controlled by domotic system</para>
    /// labels<para>Controllable</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Controllable">http://elite.polito.it/ontologies/dogont.owl#Controllable</seealso>
    let ``_.owl#Controllable`` =
        Prefixed_Name(dogont, ".owl#Controllable") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HousePlants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All plants of the house, e.g. Electrical system, Hydraulic system</para>
    /// labels<para>HousePlants</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HousePlants">http://elite.polito.it/ontologies/dogont.owl#HousePlants</seealso>
    let ``_.owl#HousePlants`` =
        Prefixed_Name(dogont, ".owl#HousePlants") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorStateHSB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorStateHSB">http://elite.polito.it/ontologies/dogont.owl#ColorStateHSB</seealso>
    let ``_.owl#ColorStateHSB`` =
        Prefixed_Name(dogont, ".owl#ColorStateHSB") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SaturationStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SaturationStateValue">http://elite.polito.it/ontologies/dogont.owl#SaturationStateValue</seealso>
    let ``_.owl#SaturationStateValue`` =
        Prefixed_Name(dogont, ".owl#SaturationStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedHeatingCycleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedHeatingCycleNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedHeatingCycleNotification</seealso>
    let ``_.owl#StoppedHeatingCycleNotification`` =
        Prefixed_Name(dogont, ".owl#StoppedHeatingCycleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotification</seealso>
    let ``_.owl#HeatingEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#HeatingEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementState">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementState</seealso>
    let ``_.owl#HeatingEnergyMeasurementState`` =
        Prefixed_Name(dogont, ".owl#HeatingEnergyMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyStateValue</seealso>
    let ``_.owl#HeatingEnergyStateValue`` =
        Prefixed_Name(dogont, ".owl#HeatingEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseActiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyState</seealso>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyState`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseActiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopPushLinkAuthenticationCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopPushLinkAuthenticationCommand">http://elite.polito.it/ontologies/dogont.owl#StopPushLinkAuthenticationCommand</seealso>
    let ``_.owl#StopPushLinkAuthenticationCommand`` =
        Prefixed_Name(dogont, ".owl#StopPushLinkAuthenticationCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#floorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#floorOf">http://elite.polito.it/ontologies/dogont.owl#floorOf</seealso>
    let ``_.owl#floorOf`` = Prefixed_Name(dogont, ".owl#floorOf") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleFunctionality">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleFunctionality</seealso>
    let ``_.owl#ClimateScheduleFunctionality`` =
        Prefixed_Name(dogont, ".owl#ClimateScheduleFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WeeklyClimateScheduleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WeeklyClimateScheduleNotification">http://elite.polito.it/ontologies/dogont.owl#WeeklyClimateScheduleNotification</seealso>
    let ``_.owl#WeeklyClimateScheduleNotification`` =
        Prefixed_Name(dogont, ".owl#WeeklyClimateScheduleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#QueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Capability of a controllable building thing that must reply to an interrogation about its state</para>
    /// labels<para>QueryFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#QueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#QueryFunctionality</seealso>
    let ``_.owl#QueryFunctionality`` =
        Prefixed_Name(dogont, ".owl#QueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingAndCoolingUnitState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnitState">http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnitState</seealso>
    let ``_.owl#HeatingAndCoolingUnitState`` =
        Prefixed_Name(dogont, ".owl#HeatingAndCoolingUnitState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Dvd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Appliance thar read dvd</para>
    /// labels<para>Dvd</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Dvd">http://elite.polito.it/ontologies/dogont.owl#Dvd</seealso>
    let ``_.owl#Dvd`` = Prefixed_Name(dogont, ".owl#Dvd") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffStandbyNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffStandbyNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffStandbyNotificationFunctionality</seealso>
    let ``_.owl#OnOffStandbyNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#OnOffStandbyNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VolumeLevelState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Models the volume value</para>
    /// labels<para>VolumeLevel</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VolumeLevelState">http://elite.polito.it/ontologies/dogont.owl#VolumeLevelState</seealso>
    let ``_.owl#VolumeLevelState`` =
        Prefixed_Name(dogont, ".owl#VolumeLevelState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StandByOnOffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StandByOnOffState">http://elite.polito.it/ontologies/dogont.owl#StandByOnOffState</seealso>
    let ``_.owl#StandByOnOffState`` =
        Prefixed_Name(dogont, ".owl#StandByOnOffState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffStandByFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffStandByFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffStandByFunctionality</seealso>
    let ``_.owl#OnOffStandByFunctionality`` =
        Prefixed_Name(dogont, ".owl#OnOffStandByFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PlayNotificationFunctionality</seealso>
    let ``_.owl#PlayNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#PlayNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VolumeRegulationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionalities for the regulation of volume</para>
    /// labels<para>VolumeRegulationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VolumeRegulationFunctionality">http://elite.polito.it/ontologies/dogont.owl#VolumeRegulationFunctionality</seealso>
    let ``_.owl#VolumeRegulationFunctionality`` =
        Prefixed_Name(dogont, ".owl#VolumeRegulationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LuminosityMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LuminosityMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#LuminosityMeasurementNotification</seealso>
    let ``_.owl#LuminosityMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#LuminosityMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerMeteringPowerOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerMeteringPowerOutlet">http://elite.polito.it/ontologies/dogont.owl#PowerMeteringPowerOutlet</seealso>
    let ``_.owl#PowerMeteringPowerOutlet`` =
        Prefixed_Name(dogont, ".owl#PowerMeteringPowerOutlet") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MicrowaveEmissionNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionNotificationFunctionality</seealso>
    let ``_.owl#MicrowaveEmissionNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MicrowaveEmissionNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementState">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementState</seealso>
    let ``_.owl#PowerFactorMeasurementState`` =
        Prefixed_Name(dogont, ".owl#PowerFactorMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorStateValue">http://elite.polito.it/ontologies/dogont.owl#PowerFactorStateValue</seealso>
    let ``_.owl#PowerFactorStateValue`` =
        Prefixed_Name(dogont, ".owl#PowerFactorStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopSuperFreezingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopSuperFreezingCommand">http://elite.polito.it/ontologies/dogont.owl#StopSuperFreezingCommand</seealso>
    let ``_.owl#StopSuperFreezingCommand`` =
        Prefixed_Name(dogont, ".owl#StopSuperFreezingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedSuperCoolingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperCoolingNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedSuperCoolingNotification</seealso>
    let ``_.owl#StoppedSuperCoolingNotification`` =
        Prefixed_Name(dogont, ".owl#StoppedSuperCoolingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AntiIntrusionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>System that provides security about intrusion</para>
    /// labels<para>AntiIntrusionSystem</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AntiIntrusionSystem">http://elite.polito.it/ontologies/dogont.owl#AntiIntrusionSystem</seealso>
    let ``_.owl#AntiIntrusionSystem`` =
        Prefixed_Name(dogont, ".owl#AntiIntrusionSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Fence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A barrier that serves to enclose an area</para>
    /// labels<para>Fence</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Fence">http://elite.polito.it/ontologies/dogont.owl#Fence</seealso>
    let ``_.owl#Fence`` = Prefixed_Name(dogont, ".owl#Fence") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlashingLamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lamp that emits light in sudden short or intermittent bursts</para>
    /// labels<para>FlashingLamp</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlashingLamp">http://elite.polito.it/ontologies/dogont.owl#FlashingLamp</seealso>
    let ``_.owl#FlashingLamp`` =
        Prefixed_Name(dogont, ".owl#FlashingLamp") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingCycleNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingCycleNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#HeatingCycleNotificationFunctionality</seealso>
    let ``_.owl#HeatingCycleNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#HeatingCycleNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedHeatingCycleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedHeatingCycleNotification">http://elite.polito.it/ontologies/dogont.owl#StartedHeatingCycleNotification</seealso>
    let ``_.owl#StartedHeatingCycleNotification`` =
        Prefixed_Name(dogont, ".owl#StartedHeatingCycleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementFunctionality</seealso>
    let ``_.owl#HeatingEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#HeatingEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#HeatingEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#HeatingEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TimedOnFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionality to switch on an object for a given period of time</para>
    /// labels<para>TimedOnFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TimedOnFunctionality">http://elite.polito.it/ontologies/dogont.owl#TimedOnFunctionality</seealso>
    let ``_.owl#TimedOnFunctionality`` =
        Prefixed_Name(dogont, ".owl#TimedOnFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SourceSelectionNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotificationFunctionality</seealso>
    let ``_.owl#SourceSelectionNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SourceSelectionNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TunerNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TunerNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TunerNotificationFunctionality</seealso>
    let ``_.owl#TunerNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#TunerNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HueBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueBridge">http://elite.polito.it/ontologies/dogont.owl#HueBridge</seealso>
    let ``_.owl#HueBridge`` = Prefixed_Name(dogont, ".owl#HueBridge") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkFunctionality">http://elite.polito.it/ontologies/dogont.owl#PushLinkFunctionality</seealso>
    let ``_.owl#PushLinkFunctionality`` =
        Prefixed_Name(dogont, ".owl#PushLinkFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkAuthenticationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationState">http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationState</seealso>
    let ``_.owl#PushLinkAuthenticationState`` =
        Prefixed_Name(dogont, ".owl#PushLinkAuthenticationState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PushLinkNotificationFunctionality</seealso>
    let ``_.owl#PushLinkNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#PushLinkNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HueComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueComponent">http://elite.polito.it/ontologies/dogont.owl#HueComponent</seealso>
    let ``_.owl#HueComponent`` =
        Prefixed_Name(dogont, ".owl#HueComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HueManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueManager">http://elite.polito.it/ontologies/dogont.owl#HueManager</seealso>
    let ``_.owl#HueManager`` = Prefixed_Name(dogont, ".owl#HueManager") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Pressure Sensor device measures and periodically reports the pressure of a liquid (typically water)</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureSensor">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureSensor</seealso>
    let ``_.owl#MultiplePressureSensor`` =
        Prefixed_Name(dogont, ".owl#MultiplePressureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureState">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureState</seealso>
    let ``_.owl#MultiplePressureState`` =
        Prefixed_Name(dogont, ".owl#MultiplePressureState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The capability of measuring temperatures</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementFunctionality</seealso>
    let ``_.owl#MultipleTemperatureMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultipleTemperatureMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Notifies the measurment of a temperature, through a proper temperature sensor</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementNotificationFunctionality</seealso>
    let ``_.owl#MultipleTemperatureMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultipleTemperatureMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that detects the temperature of the atmosphere</para>
    /// labels<para>TemperatureSensor</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureSensor">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureSensor</seealso>
    let ``_.owl#MultipleTemperatureSensor`` =
        Prefixed_Name(dogont, ".owl#MultipleTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureStateValue">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureStateValue</seealso>
    let ``_.owl#MultipleTemperatureStateValue`` =
        Prefixed_Name(dogont, ".owl#MultipleTemperatureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenNetworkCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenNetworkCommand">http://elite.polito.it/ontologies/dogont.owl#OpenNetworkCommand</seealso>
    let ``_.owl#OpenNetworkCommand`` =
        Prefixed_Name(dogont, ".owl#OpenNetworkCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkManagementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#NetworkManagementNotificationFunctionality</seealso>
    let ``_.owl#NetworkManagementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#NetworkManagementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkOpenedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkOpenedNotification">http://elite.polito.it/ontologies/dogont.owl#NetworkOpenedNotification</seealso>
    let ``_.owl#NetworkOpenedNotification`` =
        Prefixed_Name(dogont, ".owl#NetworkOpenedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkManagementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementState">http://elite.polito.it/ontologies/dogont.owl#NetworkManagementState</seealso>
    let ``_.owl#NetworkManagementState`` =
        Prefixed_Name(dogont, ".owl#NetworkManagementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#meterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#meterOf">http://elite.polito.it/ontologies/dogont.owl#meterOf</seealso>
    let ``_.owl#meterOf`` = Prefixed_Name(dogont, ".owl#meterOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasWall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association between a room and its walls</para>
    /// labels<para>hasWall</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasWall">http://elite.polito.it/ontologies/dogont.owl#hasWall</seealso>
    let ``_.owl#hasWall`` = Prefixed_Name(dogont, ".owl#hasWall") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasWallOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association between a wall and its opening like door,window</para>
    /// labels<para>hasWallOpening</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasWallOpening">http://elite.polito.it/ontologies/dogont.owl#hasWallOpening</seealso>
    let ``_.owl#hasWallOpening`` =
        Prefixed_Name(dogont, ".owl#hasWallOpening") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CloseNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CloseNotification">http://elite.polito.it/ontologies/dogont.owl#CloseNotification</seealso>
    let ``_.owl#CloseNotification`` =
        Prefixed_Name(dogont, ".owl#CloseNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DetectedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DetectedNotification">http://elite.polito.it/ontologies/dogont.owl#DetectedNotification</seealso>
    let ``_.owl#DetectedNotification`` =
        Prefixed_Name(dogont, ".owl#DetectedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FiringUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FiringUpNotification">http://elite.polito.it/ontologies/dogont.owl#FiringUpNotification</seealso>
    let ``_.owl#FiringUpNotification`` =
        Prefixed_Name(dogont, ".owl#FiringUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Nightstand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A small table or stand placed at a bedside.</para>
    /// labels<para>Nightstand</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Nightstand">http://elite.polito.it/ontologies/dogont.owl#Nightstand</seealso>
    let ``_.owl#Nightstand`` = Prefixed_Name(dogont, ".owl#Nightstand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SanitaryFixtures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All the fixtures of a bathroom</para>
    /// labels<para>SanitaryFixtures</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SanitaryFixtures">http://elite.polito.it/ontologies/dogont.owl#SanitaryFixtures</seealso>
    let ``_.owl#SanitaryFixtures`` =
        Prefixed_Name(dogont, ".owl#SanitaryFixtures") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GreenStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GreenStateValue">http://elite.polito.it/ontologies/dogont.owl#GreenStateValue</seealso>
    let ``_.owl#GreenStateValue`` =
        Prefixed_Name(dogont, ".owl#GreenStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Command">http://elite.polito.it/ontologies/dogont.owl#Command</seealso>
    let ``_.owl#Command`` = Prefixed_Name(dogont, ".owl#Command") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ConfigurationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ConfigurationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ConfigurationFunctionality</seealso>
    let ``_.owl#ConfigurationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ConfigurationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ConnectionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ConnectionState">http://elite.polito.it/ontologies/dogont.owl#ConnectionState</seealso>
    let ``_.owl#ConnectionState`` =
        Prefixed_Name(dogont, ".owl#ConnectionState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ConsumedWaterStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ConsumedWaterStateValue">http://elite.polito.it/ontologies/dogont.owl#ConsumedWaterStateValue</seealso>
    let ``_.owl#ConsumedWaterStateValue`` =
        Prefixed_Name(dogont, ".owl#ConsumedWaterStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionalities not continuous, with fixed values</para>
    /// labels<para>DiscreteFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscreteControlFunctionality</seealso>
    let ``_.owl#DiscreteControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#DiscreteControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Capability of a controllable building thing that notifies information,e.g.door sensor notifies "open"-"close"</para>
    /// labels<para>NotificationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#NotificationFunctionality</seealso>
    let ``_.owl#NotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#NotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StateValue">http://elite.polito.it/ontologies/dogont.owl#StateValue</seealso>
    let ``_.owl#StateValue`` = Prefixed_Name(dogont, ".owl#StateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowRateState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowRateState">http://elite.polito.it/ontologies/dogont.owl#FlowRateState</seealso>
    let ``_.owl#FlowRateState`` =
        Prefixed_Name(dogont, ".owl#FlowRateState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementState">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementState</seealso>
    let ``_.owl#HumidityMeasurementState`` =
        Prefixed_Name(dogont, ".owl#HumidityMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelState">http://elite.polito.it/ontologies/dogont.owl#LevelState</seealso>
    let ``_.owl#LevelState`` = Prefixed_Name(dogont, ".owl#LevelState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumiditySensor">http://elite.polito.it/ontologies/dogont.owl#HumiditySensor</seealso>
    let ``_.owl#HumiditySensor`` =
        Prefixed_Name(dogont, ".owl#HumiditySensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Models the temperature value</para>
    /// labels<para>MultipleTemperatureState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureState">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureState</seealso>
    let ``_.owl#MultipleTemperatureState`` =
        Prefixed_Name(dogont, ".owl#MultipleTemperatureState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureSensor">http://elite.polito.it/ontologies/dogont.owl#TemperatureSensor</seealso>
    let ``_.owl#TemperatureSensor`` =
        Prefixed_Name(dogont, ".owl#TemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkClosedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkClosedNotification">http://elite.polito.it/ontologies/dogont.owl#NetworkClosedNotification</seealso>
    let ``_.owl#NetworkClosedNotification`` =
        Prefixed_Name(dogont, ".owl#NetworkClosedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZigBeeNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeNotification">http://elite.polito.it/ontologies/dogont.owl#ZigBeeNotification</seealso>
    let ``_.owl#ZigBeeNotification`` =
        Prefixed_Name(dogont, ".owl#ZigBeeNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkManagementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementFunctionality">http://elite.polito.it/ontologies/dogont.owl#NetworkManagementFunctionality</seealso>
    let ``_.owl#NetworkManagementFunctionality`` =
        Prefixed_Name(dogont, ".owl#NetworkManagementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestDownNotification">http://elite.polito.it/ontologies/dogont.owl#RestDownNotification</seealso>
    let ``_.owl#RestDownNotification`` =
        Prefixed_Name(dogont, ".owl#RestDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestNotification">http://elite.polito.it/ontologies/dogont.owl#RestNotification</seealso>
    let ``_.owl#RestNotification`` =
        Prefixed_Name(dogont, ".owl#RestNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestUpNotification">http://elite.polito.it/ontologies/dogont.owl#RestUpNotification</seealso>
    let ``_.owl#RestUpNotification`` =
        Prefixed_Name(dogont, ".owl#RestUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedStepDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedStepDownNotification">http://elite.polito.it/ontologies/dogont.owl#SpeedStepDownNotification</seealso>
    let ``_.owl#SpeedStepDownNotification`` =
        Prefixed_Name(dogont, ".owl#SpeedStepDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedStepUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedStepUpNotification">http://elite.polito.it/ontologies/dogont.owl#SpeedStepUpNotification</seealso>
    let ``_.owl#SpeedStepUpNotification`` =
        Prefixed_Name(dogont, ".owl#SpeedStepUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TuningStepDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TuningStepDownNotification">http://elite.polito.it/ontologies/dogont.owl#TuningStepDownNotification</seealso>
    let ``_.owl#TuningStepDownNotification`` =
        Prefixed_Name(dogont, ".owl#TuningStepDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpDownFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionality: up - down</para>
    /// labels<para>UpDownFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpDownFunctionality">http://elite.polito.it/ontologies/dogont.owl#UpDownFunctionality</seealso>
    let ``_.owl#UpDownFunctionality`` =
        Prefixed_Name(dogont, ".owl#UpDownFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StepFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StepFunctionality">http://elite.polito.it/ontologies/dogont.owl#StepFunctionality</seealso>
    let ``_.owl#StepFunctionality`` =
        Prefixed_Name(dogont, ".owl#StepFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffLightSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>OnOffSwitch for Lights only, derives from ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffLightSwitch">http://elite.polito.it/ontologies/dogont.owl#OnOffLightSwitch</seealso>
    let ``_.owl#OnOffLightSwitch`` =
        Prefixed_Name(dogont, ".owl#OnOffLightSwitch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic OnOff switch, derives from the ZigBee Home Automation specification</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffSwitch">http://elite.polito.it/ontologies/dogont.owl#OnOffSwitch</seealso>
    let ``_.owl#OnOffSwitch`` =
        Prefixed_Name(dogont, ".owl#OnOffSwitch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpDownRestFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionality: up - down - rest</para>
    /// labels<para>UpDownRestFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpDownRestFunctionality">http://elite.polito.it/ontologies/dogont.owl#UpDownRestFunctionality</seealso>
    let ``_.owl#UpDownRestFunctionality`` =
        Prefixed_Name(dogont, ".owl#UpDownRestFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OverloadControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OverloadControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#OverloadControlFunctionality</seealso>
    let ``_.owl#OverloadControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#OverloadControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OverloadWarningCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OverloadWarningCommand">http://elite.polito.it/ontologies/dogont.owl#OverloadWarningCommand</seealso>
    let ``_.owl#OverloadWarningCommand`` =
        Prefixed_Name(dogont, ".owl#OverloadWarningCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Partition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A vertical structure that divides or separates</para>
    /// labels<para>Partition</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Partition">http://elite.polito.it/ontologies/dogont.owl#Partition</seealso>
    let ``_.owl#Partition`` = Prefixed_Name(dogont, ".owl#Partition") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PausePlaybackNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PausePlaybackNotification">http://elite.polito.it/ontologies/dogont.owl#PausePlaybackNotification</seealso>
    let ``_.owl#PausePlaybackNotification`` =
        Prefixed_Name(dogont, ".owl#PausePlaybackNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotification</seealso>
    let ``_.owl#SinglePhaseVoltageMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseVoltageMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotificationFunctionality</seealso>
    let ``_.owl#SinglePhaseVoltageMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseVoltageMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementNotificationFunctionality</seealso>
    let ``_.owl#VoltageMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#VoltageMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageState</seealso>
    let ``_.owl#SinglePhaseVoltageState`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseVoltageState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeter">http://elite.polito.it/ontologies/dogont.owl#VoltageMeter</seealso>
    let ``_.owl#VoltageMeter`` =
        Prefixed_Name(dogont, ".owl#VoltageMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageStateValue">http://elite.polito.it/ontologies/dogont.owl#VoltageStateValue</seealso>
    let ``_.owl#VoltageStateValue`` =
        Prefixed_Name(dogont, ".owl#VoltageStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementState">http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementState</seealso>
    let ``_.owl#VoltageMeasurementState`` =
        Prefixed_Name(dogont, ".owl#VoltageMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Siren</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device in which compressed air or steam is driven against a rotating perforated disk to create a loud, often wailing sound as a signal or warning.
    ///
    /// An electronic device producing a similar sound as a signal or warning: a police car siren.</para>
    /// labels<para>Siren</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Siren">http://elite.polito.it/ontologies/dogont.owl#Siren</seealso>
    let ``_.owl#Siren`` = Prefixed_Name(dogont, ".owl#Siren") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SnapshotCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SnapshotCamera">http://elite.polito.it/ontologies/dogont.owl#SnapshotCamera</seealso>
    let ``_.owl#SnapshotCamera`` =
        Prefixed_Name(dogont, ".owl#SnapshotCamera") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SoundFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Plays a Sound (default, or selected through a goTotrack, or...)</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SoundFunctionality">http://elite.polito.it/ontologies/dogont.owl#SoundFunctionality</seealso>
    let ``_.owl#SoundFunctionality`` =
        Prefixed_Name(dogont, ".owl#SoundFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ToggleFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ToggleFunctionality">http://elite.polito.it/ontologies/dogont.owl#ToggleFunctionality</seealso>
    let ``_.owl#ToggleFunctionality`` =
        Prefixed_Name(dogont, ".owl#ToggleFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SourceSelectionNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotification">http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotification</seealso>
    let ``_.owl#SourceSelectionNotification`` =
        Prefixed_Name(dogont, ".owl#SourceSelectionNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedControlNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedControlNotification">http://elite.polito.it/ontologies/dogont.owl#SpeedControlNotification</seealso>
    let ``_.owl#SpeedControlNotification`` =
        Prefixed_Name(dogont, ".owl#SpeedControlNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartCommand">http://elite.polito.it/ontologies/dogont.owl#StartCommand</seealso>
    let ``_.owl#StartCommand`` =
        Prefixed_Name(dogont, ".owl#StartCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopCommand">http://elite.polito.it/ontologies/dogont.owl#StopCommand</seealso>
    let ``_.owl#StopCommand`` =
        Prefixed_Name(dogont, ".owl#StopCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartSuperFreezingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartSuperFreezingCommand">http://elite.polito.it/ontologies/dogont.owl#StartSuperFreezingCommand</seealso>
    let ``_.owl#StartSuperFreezingCommand`` =
        Prefixed_Name(dogont, ".owl#StartSuperFreezingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartSuperHeatingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartSuperHeatingCommand">http://elite.polito.it/ontologies/dogont.owl#StartSuperHeatingCommand</seealso>
    let ``_.owl#StartSuperHeatingCommand`` =
        Prefixed_Name(dogont, ".owl#StartSuperHeatingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartSupercoolingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartSupercoolingCommand">http://elite.polito.it/ontologies/dogont.owl#StartSupercoolingCommand</seealso>
    let ``_.owl#StartSupercoolingCommand`` =
        Prefixed_Name(dogont, ".owl#StartSupercoolingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedSuperCoolingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperCoolingNotification">http://elite.polito.it/ontologies/dogont.owl#StartedSuperCoolingNotification</seealso>
    let ``_.owl#StartedSuperCoolingNotification`` =
        Prefixed_Name(dogont, ".owl#StartedSuperCoolingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedSuperFreezingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperFreezingNotification">http://elite.polito.it/ontologies/dogont.owl#StartedSuperFreezingNotification</seealso>
    let ``_.owl#StartedSuperFreezingNotification`` =
        Prefixed_Name(dogont, ".owl#StartedSuperFreezingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedSuperHeatingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperHeatingNotification">http://elite.polito.it/ontologies/dogont.owl#StartedSuperHeatingNotification</seealso>
    let ``_.owl#StartedSuperHeatingNotification`` =
        Prefixed_Name(dogont, ".owl#StartedSuperHeatingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedWashingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedWashingNotification">http://elite.polito.it/ontologies/dogont.owl#StartedWashingNotification</seealso>
    let ``_.owl#StartedWashingNotification`` =
        Prefixed_Name(dogont, ".owl#StartedWashingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterMeasurementFuctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementFuctionality">http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementFuctionality</seealso>
    let ``_.owl#WaterMeasurementFuctionality`` =
        Prefixed_Name(dogont, ".owl#WaterMeasurementFuctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementNotificationFunctionality</seealso>
    let ``_.owl#WaterMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#WaterMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementState">http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementState</seealso>
    let ``_.owl#WaterMeasurementState`` =
        Prefixed_Name(dogont, ".owl#WaterMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterMeter">http://elite.polito.it/ontologies/dogont.owl#WaterMeter</seealso>
    let ``_.owl#WaterMeter`` = Prefixed_Name(dogont, ".owl#WaterMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EmittingMicrowavesNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesNotification">http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesNotification</seealso>
    let ``_.owl#EmittingMicrowavesNotification`` =
        Prefixed_Name(dogont, ".owl#EmittingMicrowavesNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdentifyNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdentifyNotification">http://elite.polito.it/ontologies/dogont.owl#IdentifyNotification</seealso>
    let ``_.owl#IdentifyNotification`` =
        Prefixed_Name(dogont, ".owl#IdentifyNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IsPresentNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IsPresentNotification">http://elite.polito.it/ontologies/dogont.owl#IsPresentNotification</seealso>
    let ``_.owl#IsPresentNotification`` =
        Prefixed_Name(dogont, ".owl#IsPresentNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementNotification">http://elite.polito.it/ontologies/dogont.owl#MovementNotification</seealso>
    let ``_.owl#MovementNotification`` =
        Prefixed_Name(dogont, ".owl#MovementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotDetectedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotDetectedNotification">http://elite.polito.it/ontologies/dogont.owl#NotDetectedNotification</seealso>
    let ``_.owl#NotDetectedNotification`` =
        Prefixed_Name(dogont, ".owl#NotDetectedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociationNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociationNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#AssociationNotificationFunctionality</seealso>
    let ``_.owl#AssociationNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#AssociationNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisassociatingDeviceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisassociatingDeviceNotification">http://elite.polito.it/ontologies/dogont.owl#DisassociatingDeviceNotification</seealso>
    let ``_.owl#DisassociatingDeviceNotification`` =
        Prefixed_Name(dogont, ".owl#DisassociatingDeviceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derives from the general cluster functionalities defined in ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#NetworkNotificationFunctionality</seealso>
    let ``_.owl#NetworkNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#NetworkNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Capability of a controllable building thing that can receive commands</para>
    /// labels<para>ControlFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#ControlFunctionality</seealso>
    let ``_.owl#ControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#ControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#unitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#unitOfMeasure">http://elite.polito.it/ontologies/dogont.owl#unitOfMeasure</seealso>
    let ``_.owl#unitOfMeasure`` =
        Prefixed_Name(dogont, ".owl#unitOfMeasure") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementNotificationFunctionality</seealso>
    let ``_.owl#FlowMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#FlowMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotificationFunctionality</seealso>
    let ``_.owl#PressureMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#PressureMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Notifies the measurment of a temperature, through a proper temperature sensor</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotificationFunctionality</seealso>
    let ``_.owl#TemperatureMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#TemperatureMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleAlertNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotification">http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotification</seealso>
    let ``_.owl#MultipleAlertNotification`` =
        Prefixed_Name(dogont, ".owl#MultipleAlertNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CoolNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoolNotification">http://elite.polito.it/ontologies/dogont.owl#CoolNotification</seealso>
    let ``_.owl#CoolNotification`` =
        Prefixed_Name(dogont, ".owl#CoolNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HueStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueStateValue">http://elite.polito.it/ontologies/dogont.owl#HueStateValue</seealso>
    let ``_.owl#HueStateValue`` =
        Prefixed_Name(dogont, ".owl#HueStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorStateRGB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorStateRGB">http://elite.polito.it/ontologies/dogont.owl#ColorStateRGB</seealso>
    let ``_.owl#ColorStateRGB`` =
        Prefixed_Name(dogont, ".owl#ColorStateRGB") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RedStateValue">http://elite.polito.it/ontologies/dogont.owl#RedStateValue</seealso>
    let ``_.owl#RedStateValue`` =
        Prefixed_Name(dogont, ".owl#RedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetConfigurationCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetConfigurationCommand">http://elite.polito.it/ontologies/dogont.owl#GetConfigurationCommand</seealso>
    let ``_.owl#GetConfigurationCommand`` =
        Prefixed_Name(dogont, ".owl#GetConfigurationCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DoubleValuedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete states with exactly two values</para>
    /// labels<para>DoubleValuedState</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedState">http://elite.polito.it/ontologies/dogont.owl#DoubleValuedState</seealso>
    let ``_.owl#DoubleValuedState`` =
        Prefixed_Name(dogont, ".owl#DoubleValuedState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Models the states of the controllable objects</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#State">http://elite.polito.it/ontologies/dogont.owl#State</seealso>
    let ``_.owl#State`` = Prefixed_Name(dogont, ".owl#State") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Functionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Capability of a controllable building thing</para>
    /// labels<para>Functionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Functionality">http://elite.polito.it/ontologies/dogont.owl#Functionality</seealso>
    let ``_.owl#Functionality`` =
        Prefixed_Name(dogont, ".owl#Functionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SourceSelectionFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionFunctionality">http://elite.polito.it/ontologies/dogont.owl#SourceSelectionFunctionality</seealso>
    let ``_.owl#SourceSelectionFunctionality`` =
        Prefixed_Name(dogont, ".owl#SourceSelectionFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HotWaterM3MeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HotWaterM3MeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#HotWaterM3MeasurementNotification</seealso>
    let ``_.owl#HotWaterM3MeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#HotWaterM3MeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowRateState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateState">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateState</seealso>
    let ``_.owl#MultipleFlowRateState`` =
        Prefixed_Name(dogont, ".owl#MultipleFlowRateState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowRateStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateStateValue">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateStateValue</seealso>
    let ``_.owl#MultipleFlowRateStateValue`` =
        Prefixed_Name(dogont, ".owl#MultipleFlowRateStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerStateValue">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerStateValue</seealso>
    let ``_.owl#ReactivePowerStateValue`` =
        Prefixed_Name(dogont, ".owl#ReactivePowerStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a given domotic component with the network level gateway used to control it</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasGateway">http://elite.polito.it/ontologies/dogont.owl#hasGateway</seealso>
    let ``_.owl#hasGateway`` = Prefixed_Name(dogont, ".owl#hasGateway") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasMeter">http://elite.polito.it/ontologies/dogont.owl#hasMeter</seealso>
    let ``_.owl#hasMeter`` = Prefixed_Name(dogont, ".owl#hasMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NoMovementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NoMovementNotification">http://elite.polito.it/ontologies/dogont.owl#NoMovementNotification</seealso>
    let ``_.owl#NoMovementNotification`` =
        Prefixed_Name(dogont, ".owl#NoMovementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdleNotification">http://elite.polito.it/ontologies/dogont.owl#IdleNotification</seealso>
    let ``_.owl#IdleNotification`` =
        Prefixed_Name(dogont, ".owl#IdleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CoolingApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoolingApplianceState">http://elite.polito.it/ontologies/dogont.owl#CoolingApplianceState</seealso>
    let ``_.owl#CoolingApplianceState`` =
        Prefixed_Name(dogont, ".owl#CoolingApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementFunctionality</seealso>
    let ``_.owl#CurrentMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#CurrentMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementNotificationFunctionality</seealso>
    let ``_.owl#CurrentMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#CurrentMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CycleTimingControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#CycleTimingControlFunctionality</seealso>
    let ``_.owl#CycleTimingControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#CycleTimingControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetRemainingTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetRemainingTimeCommand">http://elite.polito.it/ontologies/dogont.owl#SetRemainingTimeCommand</seealso>
    let ``_.owl#SetRemainingTimeCommand`` =
        Prefixed_Name(dogont, ".owl#SetRemainingTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetFrequencyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetFrequencyCommand">http://elite.polito.it/ontologies/dogont.owl#GetFrequencyCommand</seealso>
    let ``_.owl#GetFrequencyCommand`` =
        Prefixed_Name(dogont, ".owl#GetFrequencyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotification</seealso>
    let ``_.owl#FrequencyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#FrequencyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KNXNetIPGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KNXNetIPGateway">http://elite.polito.it/ontologies/dogont.owl#KNXNetIPGateway</seealso>
    let ``_.owl#KNXNetIPGateway`` =
        Prefixed_Name(dogont, ".owl#KNXNetIPGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ModbusGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModbusGateway">http://elite.polito.it/ontologies/dogont.owl#ModbusGateway</seealso>
    let ``_.owl#ModbusGateway`` =
        Prefixed_Name(dogont, ".owl#ModbusGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseVolumeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseVolumeCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseVolumeCommand</seealso>
    let ``_.owl#IncreaseVolumeCommand`` =
        Prefixed_Name(dogont, ".owl#IncreaseVolumeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SensingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SensingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SensingNotificationFunctionality</seealso>
    let ``_.owl#SensingNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SensingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Jacuzzi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A large whirlpool bathtub with underwater jets that massage the body</para>
    /// labels<para>Jacuzzi</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Jacuzzi">http://elite.polito.it/ontologies/dogont.owl#Jacuzzi</seealso>
    let ``_.owl#Jacuzzi`` = Prefixed_Name(dogont, ".owl#Jacuzzi") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KNXNetIPComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KNXNetIPComponent">http://elite.polito.it/ontologies/dogont.owl#KNXNetIPComponent</seealso>
    let ``_.owl#KNXNetIPComponent`` =
        Prefixed_Name(dogont, ".owl#KNXNetIPComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KonnexCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexCommand">http://elite.polito.it/ontologies/dogont.owl#KonnexCommand</seealso>
    let ``_.owl#KonnexCommand`` =
        Prefixed_Name(dogont, ".owl#KonnexCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KonnexNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexNotification">http://elite.polito.it/ontologies/dogont.owl#KonnexNotification</seealso>
    let ``_.owl#KonnexNotification`` =
        Prefixed_Name(dogont, ".owl#KonnexNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LampHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LampHolder">http://elite.polito.it/ontologies/dogont.owl#LampHolder</seealso>
    let ``_.owl#LampHolder`` = Prefixed_Name(dogont, ".owl#LampHolder") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Models a binary output which can be only in on or off state (OnOffState), compatible with the ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffOutput">http://elite.polito.it/ontologies/dogont.owl#OnOffOutput</seealso>
    let ``_.owl#OnOffOutput`` =
        Prefixed_Name(dogont, ".owl#OnOffOutput") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentState</seealso>
    let ``_.owl#SinglePhaseCurrentState`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseCurrentState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseElectricityMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseElectricityMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseElectricityMeter</seealso>
    let ``_.owl#SinglePhaseElectricityMeter`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseElectricityMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeter</seealso>
    let ``_.owl#SinglePhaseReactivePowerMeter`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseReactivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeter</seealso>
    let ``_.owl#SinglePhaseVoltageMeter`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseVoltageMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Ventilator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device that circulates fresh air and expels stale or foul air.</para>
    /// labels<para>Ventilator</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Ventilator">http://elite.polito.it/ontologies/dogont.owl#Ventilator</seealso>
    let ``_.owl#Ventilator`` = Prefixed_Name(dogont, ".owl#Ventilator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#isInWall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association between a wallopening(door or window) and the wall opening where it is</para>
    /// labels<para>isInWall</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#isInWall">http://elite.polito.it/ontologies/dogont.owl#isInWall</seealso>
    let ``_.owl#isInWall`` = Prefixed_Name(dogont, ".owl#isInWall") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashRinseStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashRinseStateValue">http://elite.polito.it/ontologies/dogont.owl#WashRinseStateValue</seealso>
    let ``_.owl#WashRinseStateValue`` =
        Prefixed_Name(dogont, ".owl#WashRinseStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NonParametricLevelNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NonParametricLevelNotification">http://elite.polito.it/ontologies/dogont.owl#NonParametricLevelNotification</seealso>
    let ``_.owl#NonParametricLevelNotification`` =
        Prefixed_Name(dogont, ".owl#NonParametricLevelNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotPresentNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotPresentNotification">http://elite.polito.it/ontologies/dogont.owl#NotPresentNotification</seealso>
    let ``_.owl#NotPresentNotification`` =
        Prefixed_Name(dogont, ".owl#NotPresentNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GenericApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GenericApplianceState">http://elite.polito.it/ontologies/dogont.owl#GenericApplianceState</seealso>
    let ``_.owl#GenericApplianceState`` =
        Prefixed_Name(dogont, ".owl#GenericApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementState">http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementState</seealso>
    let ``_.owl#CurrentMeasurementState`` =
        Prefixed_Name(dogont, ".owl#CurrentMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricityMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricityMeter">http://elite.polito.it/ontologies/dogont.owl#ElectricityMeter</seealso>
    let ``_.owl#ElectricityMeter`` =
        Prefixed_Name(dogont, ".owl#ElectricityMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetEndTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetEndTimeCommand">http://elite.polito.it/ontologies/dogont.owl#SetEndTimeCommand</seealso>
    let ``_.owl#SetEndTimeCommand`` =
        Prefixed_Name(dogont, ".owl#SetEndTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TripleValuedFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete functionalities with exactly three values</para>
    /// labels<para>TripleValuedFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedFunctionality">http://elite.polito.it/ontologies/dogont.owl#TripleValuedFunctionality</seealso>
    let ``_.owl#TripleValuedFunctionality`` =
        Prefixed_Name(dogont, ".owl#TripleValuedFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CycleTimingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#CycleTimingNotificationFunctionality</seealso>
    let ``_.owl#CycleTimingNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#CycleTimingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetEndTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetEndTimeCommand">http://elite.polito.it/ontologies/dogont.owl#GetEndTimeCommand</seealso>
    let ``_.owl#GetEndTimeCommand`` =
        Prefixed_Name(dogont, ".owl#GetEndTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetStartTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetStartTimeCommand">http://elite.polito.it/ontologies/dogont.owl#GetStartTimeCommand</seealso>
    let ``_.owl#GetStartTimeCommand`` =
        Prefixed_Name(dogont, ".owl#GetStartTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseVolumeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseVolumeCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseVolumeCommand</seealso>
    let ``_.owl#DecreaseVolumeCommand`` =
        Prefixed_Name(dogont, ".owl#DecreaseVolumeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FreezingApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FreezingApplianceState">http://elite.polito.it/ontologies/dogont.owl#FreezingApplianceState</seealso>
    let ``_.owl#FreezingApplianceState`` =
        Prefixed_Name(dogont, ".owl#FreezingApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperFreezingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the ability of a device to start/stop a super freezing cycle, tipically defined for fridges, refrigerators and freezers. Derives from the energy@home zigbee extension and from the EN50523 standard</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperFreezingFunctionality</seealso>
    let ``_.owl#SuperFreezingFunctionality`` =
        Prefixed_Name(dogont, ".owl#SuperFreezingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SelectSourceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SelectSourceCommand">http://elite.polito.it/ontologies/dogont.owl#SelectSourceCommand</seealso>
    let ``_.owl#SelectSourceCommand`` =
        Prefixed_Name(dogont, ".owl#SelectSourceCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetRelativeHumidityMCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityMCommand">http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityMCommand</seealso>
    let ``_.owl#GetRelativeHumidityMCommand`` =
        Prefixed_Name(dogont, ".owl#GetRelativeHumidityMCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetPressureMCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetPressureMCommand">http://elite.polito.it/ontologies/dogont.owl#GetPressureMCommand</seealso>
    let ``_.owl#GetPressureMCommand`` =
        Prefixed_Name(dogont, ".owl#GetPressureMCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetLuminanceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetLuminanceCommand">http://elite.polito.it/ontologies/dogont.owl#GetLuminanceCommand</seealso>
    let ``_.owl#GetLuminanceCommand`` =
        Prefixed_Name(dogont, ".owl#GetLuminanceCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnNotification">http://elite.polito.it/ontologies/dogont.owl#OnNotification</seealso>
    let ``_.owl#OnNotification`` =
        Prefixed_Name(dogont, ".owl#OnNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressedDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressedDownNotification">http://elite.polito.it/ontologies/dogont.owl#PressedDownNotification</seealso>
    let ``_.owl#PressedDownNotification`` =
        Prefixed_Name(dogont, ".owl#PressedDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReleasedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReleasedNotification">http://elite.polito.it/ontologies/dogont.owl#ReleasedNotification</seealso>
    let ``_.owl#ReleasedNotification`` =
        Prefixed_Name(dogont, ".owl#ReleasedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopHeatingCoolingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingNotification">http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingNotification</seealso>
    let ``_.owl#StopHeatingCoolingNotification`` =
        Prefixed_Name(dogont, ".owl#StopHeatingCoolingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#GasMeasurementNotificationFunctionality</seealso>
    let ``_.owl#GasMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#GasMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseLLVoltageMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLLVoltageMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLLVoltageMeasurementNotification</seealso>
    let ``_.owl#ThreePhaseLLVoltageMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseLLVoltageMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlaybackNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlaybackNotification">http://elite.polito.it/ontologies/dogont.owl#PlaybackNotification</seealso>
    let ``_.owl#PlaybackNotification`` =
        Prefixed_Name(dogont, ".owl#PlaybackNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BTicinoComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Components manufactured by Bticino</para>
    /// labels<para>BTicinoComponent</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BTicinoComponent">http://elite.polito.it/ontologies/dogont.owl#BTicinoComponent</seealso>
    let ``_.owl#BTicinoComponent`` =
        Prefixed_Name(dogont, ".owl#BTicinoComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#physicalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The address of the component</para>
    /// labels<para>physicalAddress</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#physicalAddress">http://elite.polito.it/ontologies/dogont.owl#physicalAddress</seealso>
    let ``_.owl#physicalAddress`` =
        Prefixed_Name(dogont, ".owl#physicalAddress") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The manufacturers of the domotic component</para>
    /// labels<para>NetworkComponent</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkComponent">http://elite.polito.it/ontologies/dogont.owl#NetworkComponent</seealso>
    let ``_.owl#NetworkComponent`` =
        Prefixed_Name(dogont, ".owl#NetworkComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperCoolingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A functionality describing the ability of the device to start/stop a super cooling cycle (typical of fridges, freezers and refrigerators). This functionality is defined in the energy@home zigbee extension and in the EN50523 specification.</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperCoolingFunctionality</seealso>
    let ``_.owl#SuperCoolingFunctionality`` =
        Prefixed_Name(dogont, ".owl#SuperCoolingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotification</seealso>
    let ``_.owl#ThreePhaseCurrentMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseCurrentMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeter</seealso>
    let ``_.owl#ThreePhaseCurrentMeter`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseCurrentMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseElectricityMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseElectricityMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseElectricityMeter</seealso>
    let ``_.owl#ThreePhaseElectricityMeter`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseElectricityMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeter</seealso>
    let ``_.owl#ThreePhaseReactivePowerMeter`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyState</seealso>
    let ``_.owl#ThreePhaseReactiveEnergyState`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressedUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressedUpNotification">http://elite.polito.it/ontologies/dogont.owl#PressedUpNotification</seealso>
    let ``_.owl#PressedUpNotification`` =
        Prefixed_Name(dogont, ".owl#PressedUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StandByNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StandByNotification">http://elite.polito.it/ontologies/dogont.owl#StandByNotification</seealso>
    let ``_.owl#StandByNotification`` =
        Prefixed_Name(dogont, ".owl#StandByNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperFreezingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotification">http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotification</seealso>
    let ``_.owl#SuperFreezingNotification`` =
        Prefixed_Name(dogont, ".owl#SuperFreezingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashingNotification">http://elite.polito.it/ontologies/dogont.owl#WashingNotification</seealso>
    let ``_.owl#WashingNotification`` =
        Prefixed_Name(dogont, ".owl#WashingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hexValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hexValue">http://elite.polito.it/ontologies/dogont.owl#hexValue</seealso>
    let ``_.owl#hexValue`` = Prefixed_Name(dogont, ".owl#hexValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#scaleFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#scaleFactor">http://elite.polito.it/ontologies/dogont.owl#scaleFactor</seealso>
    let ``_.owl#scaleFactor`` =
        Prefixed_Name(dogont, ".owl#scaleFactor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#endpointAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The address (URL) of the web service endpoint at which the ILON100 server having this property offers data reading and writing services</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#endpointAddress">http://elite.polito.it/ontologies/dogont.owl#endpointAddress</seealso>
    let ``_.owl#endpointAddress`` =
        Prefixed_Name(dogont, ".owl#endpointAddress") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperHeatingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperHeatingFunctionality</seealso>
    let ``_.owl#SuperHeatingFunctionality`` =
        Prefixed_Name(dogont, ".owl#SuperHeatingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashingMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A home appliance for washing clothes and linens automatically</para>
    /// labels<para>WashingMachine</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashingMachine">http://elite.polito.it/ontologies/dogont.owl#WashingMachine</seealso>
    let ``_.owl#WashingMachine`` =
        Prefixed_Name(dogont, ".owl#WashingMachine") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Oven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kitchen appliance used for baking or roasting</para>
    /// labels<para>Oven</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Oven">http://elite.polito.it/ontologies/dogont.owl#Oven</seealso>
    let ``_.owl#Oven`` = Prefixed_Name(dogont, ".owl#Oven") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Stove</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Heating apparatus</para>
    /// labels<para>Stove</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Stove">http://elite.polito.it/ontologies/dogont.owl#Stove</seealso>
    let ``_.owl#Stove`` = Prefixed_Name(dogont, ".owl#Stove") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BrightnessStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BrightnessStateValue">http://elite.polito.it/ontologies/dogont.owl#BrightnessStateValue</seealso>
    let ``_.owl#BrightnessStateValue`` =
        Prefixed_Name(dogont, ".owl#BrightnessStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Building">http://elite.polito.it/ontologies/dogont.owl#Building</seealso>
    let ``_.owl#Building`` = Prefixed_Name(dogont, ".owl#Building") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Flat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Flat">http://elite.polito.it/ontologies/dogont.owl#Flat</seealso>
    let ``_.owl#Flat`` = Prefixed_Name(dogont, ".owl#Flat") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BuildingEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical environment in which people lives, e.g. kitchen, bathroom</para>
    /// labels<para>BuildingEnvironment</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BuildingEnvironment">http://elite.polito.it/ontologies/dogont.owl#BuildingEnvironment</seealso>
    let ``_.owl#BuildingEnvironment`` =
        Prefixed_Name(dogont, ".owl#BuildingEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Garage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The garage of the buinding</para>
    /// labels<para>Garage</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Garage">http://elite.polito.it/ontologies/dogont.owl#Garage</seealso>
    let ``_.owl#Garage`` = Prefixed_Name(dogont, ".owl#Garage") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Button</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A monostable electrical switch operated by pressing a button</para>
    /// labels<para>Button</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Button">http://elite.polito.it/ontologies/dogont.owl#Button</seealso>
    let ``_.owl#Button`` = Prefixed_Name(dogont, ".owl#Button") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ButtonNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ButtonNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ButtonNotificationFunctionality</seealso>
    let ``_.owl#ButtonNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ButtonNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SceneSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Scene Selector device is capable of setting up and selecting scenes on other devices, including group of devices. It derives from ZigBee HA specifications.</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SceneSelector">http://elite.polito.it/ontologies/dogont.owl#SceneSelector</seealso>
    let ``_.owl#SceneSelector`` =
        Prefixed_Name(dogont, ".owl#SceneSelector") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RemoteControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RemoteControl">http://elite.polito.it/ontologies/dogont.owl#RemoteControl</seealso>
    let ``_.owl#RemoteControl`` =
        Prefixed_Name(dogont, ".owl#RemoteControl") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Switch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Bi-stable control consisting of a mechanical or electrical or electronic device for making or breaking or changing the connections in a circuit</para>
    /// labels<para>Switch</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Switch">http://elite.polito.it/ontologies/dogont.owl#Switch</seealso>
    let ``_.owl#Switch`` = Prefixed_Name(dogont, ".owl#Switch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ButtonMNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ButtonMNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ButtonMNotificationFunctionality</seealso>
    let ``_.owl#ButtonMNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ButtonMNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Lamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An artificial source of visible illumination</para>
    /// labels<para>Lamp</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Lamp">http://elite.polito.it/ontologies/dogont.owl#Lamp</seealso>
    let ``_.owl#Lamp`` = Prefixed_Name(dogont, ".owl#Lamp") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetColdWaterM3Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetColdWaterM3Command">http://elite.polito.it/ontologies/dogont.owl#GetColdWaterM3Command</seealso>
    let ``_.owl#GetColdWaterM3Command`` =
        Prefixed_Name(dogont, ".owl#GetColdWaterM3Command") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#LevelNotificationFunctionality</seealso>
    let ``_.owl#LevelNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#LevelNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LightSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Light Sensor device reports the illuminance of an area</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LightSensor">http://elite.polito.it/ontologies/dogont.owl#LightSensor</seealso>
    let ``_.owl#LightSensor`` =
        Prefixed_Name(dogont, ".owl#LightSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LuminosityNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LuminosityNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#LuminosityNotificationFunctionality</seealso>
    let ``_.owl#LuminosityNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#LuminosityNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotification</seealso>
    let ``_.owl#PowerFactorMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#PowerFactorMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotificationFunctionality</seealso>
    let ``_.owl#PowerFactorMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#PowerFactorMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerMeteringLevelControllableOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerMeteringLevelControllableOutput">http://elite.polito.it/ontologies/dogont.owl#PowerMeteringLevelControllableOutput</seealso>
    let ``_.owl#PowerMeteringLevelControllableOutput`` =
        Prefixed_Name(dogont, ".owl#PowerMeteringLevelControllableOutput") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresenceAndMovementSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresenceAndMovementSensor">http://elite.polito.it/ontologies/dogont.owl#PresenceAndMovementSensor</seealso>
    let ``_.owl#PresenceAndMovementSensor`` =
        Prefixed_Name(dogont, ".owl#PresenceAndMovementSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresenceSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresenceSensor">http://elite.polito.it/ontologies/dogont.owl#PresenceSensor</seealso>
    let ``_.owl#PresenceSensor`` =
        Prefixed_Name(dogont, ".owl#PresenceSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperCoolingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotification">http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotification</seealso>
    let ``_.owl#SuperCoolingNotification`` =
        Prefixed_Name(dogont, ".owl#SuperCoolingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#groupAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The address of the group of the component</para>
    /// labels<para>groupAddress</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#groupAddress">http://elite.polito.it/ontologies/dogont.owl#groupAddress</seealso>
    let ``_.owl#groupAddress`` =
        Prefixed_Name(dogont, ".owl#groupAddress") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#registerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#registerType">http://elite.polito.it/ontologies/dogont.owl#registerType</seealso>
    let ``_.owl#registerType`` =
        Prefixed_Name(dogont, ".owl#registerType") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperFreezingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotificationFunctionality</seealso>
    let ``_.owl#SuperFreezingNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SuperFreezingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ParametricCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ParametricCommand">http://elite.polito.it/ontologies/dogont.owl#ParametricCommand</seealso>
    let ``_.owl#ParametricCommand`` =
        Prefixed_Name(dogont, ".owl#ParametricCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Gate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A door-like movable barrier in a fence</para>
    /// labels<para>Gate</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Gate">http://elite.polito.it/ontologies/dogont.owl#Gate</seealso>
    let ``_.owl#Gate`` = Prefixed_Name(dogont, ".owl#Gate") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotification</seealso>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementFunctionality</seealso>
    let ``_.owl#ThreePhaseReactivePowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotification</seealso>
    let ``_.owl#ThreePhaseReactivePowerMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactivePowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseVoltageMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementFunctionality</seealso>
    let ``_.owl#ThreePhaseVoltageMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseVoltageMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseVoltageMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ThreePhaseVoltageMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseVoltageMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperHeatingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotification">http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotification</seealso>
    let ``_.owl#SuperHeatingNotification`` =
        Prefixed_Name(dogont, ".owl#SuperHeatingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#individualAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The individual address of the component</para>
    /// labels<para>individualAddress</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#individualAddress">http://elite.polito.it/ontologies/dogont.owl#individualAddress</seealso>
    let ``_.owl#individualAddress`` =
        Prefixed_Name(dogont, ".owl#individualAddress") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BlueStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BlueStateValue">http://elite.polito.it/ontologies/dogont.owl#BlueStateValue</seealso>
    let ``_.owl#BlueStateValue`` =
        Prefixed_Name(dogont, ".owl#BlueStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingApplianceState">http://elite.polito.it/ontologies/dogont.owl#HeatingApplianceState</seealso>
    let ``_.owl#HeatingApplianceState`` =
        Prefixed_Name(dogont, ".owl#HeatingApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperHeatingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotificationFunctionality</seealso>
    let ``_.owl#SuperHeatingNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SuperHeatingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Cooker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A utensil for cooking</para>
    /// labels<para>Cooker</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Cooker">http://elite.polito.it/ontologies/dogont.owl#Cooker</seealso>
    let ``_.owl#Cooker`` = Prefixed_Name(dogont, ".owl#Cooker") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeepFreezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electric refrigerator in which food is frozen and stored for long periods of time</para>
    /// labels<para>DeepFreezer</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeepFreezer">http://elite.polito.it/ontologies/dogont.owl#DeepFreezer</seealso>
    let ``_.owl#DeepFreezer`` =
        Prefixed_Name(dogont, ".owl#DeepFreezer") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Fridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A refrigerator in which the coolant is pumped around by an electric motor</para>
    /// labels<para>Fridge</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Fridge">http://elite.polito.it/ontologies/dogont.owl#Fridge</seealso>
    let ``_.owl#Fridge`` = Prefixed_Name(dogont, ".owl#Fridge") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Dishwasher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A machine for washing dishes</para>
    /// labels<para>Dishwasher</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Dishwasher">http://elite.polito.it/ontologies/dogont.owl#Dishwasher</seealso>
    let ``_.owl#Dishwasher`` = Prefixed_Name(dogont, ".owl#Dishwasher") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseVoltageState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageState</seealso>
    let ``_.owl#ThreePhaseVoltageState`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseVoltageState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#registerAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#registerAddress">http://elite.polito.it/ontologies/dogont.owl#registerAddress</seealso>
    let ``_.owl#registerAddress`` =
        Prefixed_Name(dogont, ".owl#registerAddress") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#slaveId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#slaveId">http://elite.polito.it/ontologies/dogont.owl#slaveId</seealso>
    let ``_.owl#slaveId`` = Prefixed_Name(dogont, ".owl#slaveId") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#datapoinId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ILON id of a given datapoint associated to the command or notification of a given echelon-managed device</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#datapoinId">http://elite.polito.it/ontologies/dogont.owl#datapoinId</seealso>
    let ``_.owl#datapoinId`` = Prefixed_Name(dogont, ".owl#datapoinId") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#multicastIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The multicast address of the gateway</para>
    /// labels<para>multicastIP</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#multicastIP">http://elite.polito.it/ontologies/dogont.owl#multicastIP</seealso>
    let ``_.owl#multicastIP`` =
        Prefixed_Name(dogont, ".owl#multicastIP") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Garden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The garden of the building</para>
    /// labels<para>Garden</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Garden">http://elite.polito.it/ontologies/dogont.owl#Garden</seealso>
    let ``_.owl#Garden`` = Prefixed_Name(dogont, ".owl#Garden") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BuildingThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>All things that creates a Building, it is intended as root of all building components</para>
    /// labels<para>BuildingThing</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BuildingThing">http://elite.polito.it/ontologies/dogont.owl#BuildingThing</seealso>
    let ``_.owl#BuildingThing`` =
        Prefixed_Name(dogont, ".owl#BuildingThing") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleScenarioControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleScenarioControl">http://elite.polito.it/ontologies/dogont.owl#SingleScenarioControl</seealso>
    let ``_.owl#SingleScenarioControl`` =
        Prefixed_Name(dogont, ".owl#SingleScenarioControl") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Knob</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A round handle used to adjust continuous amplitude, e.g. volume</para>
    /// labels<para>Knob</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Knob">http://elite.polito.it/ontologies/dogont.owl#Knob</seealso>
    let ``_.owl#Knob`` = Prefixed_Name(dogont, ".owl#Knob") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReleasedMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReleasedMNotification">http://elite.polito.it/ontologies/dogont.owl#ReleasedMNotification</seealso>
    let ``_.owl#ReleasedMNotification`` =
        Prefixed_Name(dogont, ".owl#ReleasedMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Buzzer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An electric signaling device, such as a doorbell, that makes a buzzing sound.</para>
    /// labels<para>Buzzer</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Buzzer">http://elite.polito.it/ontologies/dogont.owl#Buzzer</seealso>
    let ``_.owl#Buzzer`` = Prefixed_Name(dogont, ".owl#Buzzer") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseColorCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseColorCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseColorCommand</seealso>
    let ``_.owl#IncreaseColorCommand`` =
        Prefixed_Name(dogont, ".owl#IncreaseColorCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseContrastCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseContrastCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseContrastCommand</seealso>
    let ``_.owl#IncreaseContrastCommand`` =
        Prefixed_Name(dogont, ".owl#IncreaseContrastCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ContinuousControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionalities continuous in time or space</para>
    /// labels<para>ContinuousFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ContinuousControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#ContinuousControlFunctionality</seealso>
    let ``_.owl#ContinuousControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#ContinuousControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseContrastCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseContrastCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseContrastCommand</seealso>
    let ``_.owl#DecreaseContrastCommand`` =
        Prefixed_Name(dogont, ".owl#DecreaseContrastCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseColorCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseColorCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseColorCommand</seealso>
    let ``_.owl#DecreaseColorCommand`` =
        Prefixed_Name(dogont, ".owl#DecreaseColorCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Level control functionality, used for allowing devices to be controlled in a continuous manner, derives from ZigBee Home Automation specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#LevelControlFunctionality</seealso>
    let ``_.owl#LevelControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#LevelControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShutterRegulationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionalities for the regulation of shutter</para>
    /// labels<para>ShutterRegulationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShutterRegulationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ShutterRegulationFunctionality</seealso>
    let ``_.owl#ShutterRegulationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ShutterRegulationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CameraPictureQualityControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureQualityControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#CameraPictureQualityControlFunctionality</seealso>
    let ``_.owl#CameraPictureQualityControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#CameraPictureQualityControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#ColorControlFunctionality</seealso>
    let ``_.owl#ColorControlFunctionality`` =
        Prefixed_Name(dogont, ".owl#ColorControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PanRightCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PanRightCommand">http://elite.polito.it/ontologies/dogont.owl#PanRightCommand</seealso>
    let ``_.owl#PanRightCommand`` =
        Prefixed_Name(dogont, ".owl#PanRightCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PanDownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PanDownCommand">http://elite.polito.it/ontologies/dogont.owl#PanDownCommand</seealso>
    let ``_.owl#PanDownCommand`` =
        Prefixed_Name(dogont, ".owl#PanDownCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZoomOutCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZoomOutCommand">http://elite.polito.it/ontologies/dogont.owl#ZoomOutCommand</seealso>
    let ``_.owl#ZoomOutCommand`` =
        Prefixed_Name(dogont, ".owl#ZoomOutCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZoomInCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZoomInCommand">http://elite.polito.it/ontologies/dogont.owl#ZoomInCommand</seealso>
    let ``_.owl#ZoomInCommand`` =
        Prefixed_Name(dogont, ".owl#ZoomInCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashingApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashingApplianceState">http://elite.polito.it/ontologies/dogont.owl#WashingApplianceState</seealso>
    let ``_.owl#WashingApplianceState`` =
        Prefixed_Name(dogont, ".owl#WashingApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashingCycleNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashingCycleNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#WashingCycleNotificationFunctionality</seealso>
    let ``_.owl#WashingCycleNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#WashingCycleNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BatteryLevelNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotificationFunctionality</seealso>
    let ``_.owl#BatteryLevelNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#BatteryLevelNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ContinuousNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Notification of continuous values</para>
    /// labels<para>ContinuousNotificationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ContinuousNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ContinuousNotificationFunctionality</seealso>
    let ``_.owl#ContinuousNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ContinuousNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ThreePhaseCurrentMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseCurrentMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentState</seealso>
    let ``_.owl#ThreePhaseCurrentState`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseCurrentState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseVoltageMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeter</seealso>
    let ``_.owl#ThreePhaseVoltageMeter`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseVoltageMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseEnergyMeter</seealso>
    let ``_.owl#ThreePhaseEnergyMeter`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#ThreePhaseReactiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseLNVoltageMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLNVoltageMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLNVoltageMeasurementNotification</seealso>
    let ``_.owl#ThreePhaseLNVoltageMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseLNVoltageMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#datapointAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#datapointAlias">http://elite.polito.it/ontologies/dogont.owl#datapointAlias</seealso>
    let ``_.owl#datapointAlias`` =
        Prefixed_Name(dogont, ".owl#datapointAlias") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BrownGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Small household electrical entertainment appliances</para>
    /// labels<para>BrownGoods</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BrownGoods">http://elite.polito.it/ontologies/dogont.owl#BrownGoods</seealso>
    let ``_.owl#BrownGoods`` = Prefixed_Name(dogont, ".owl#BrownGoods") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates which object are contained in a building environment, e.g. the kitchen contains Lamp1,Lamp2...</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#contains">http://elite.polito.it/ontologies/dogont.owl#contains</seealso>
    let ``_.owl#contains`` = Prefixed_Name(dogont, ".owl#contains") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Storey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Storey">http://elite.polito.it/ontologies/dogont.owl#Storey</seealso>
    let ``_.owl#Storey`` = Prefixed_Name(dogont, ".owl#Storey") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LightRegulationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionalities for the regulation of ligth</para>
    /// labels<para>LightRegulationFunctionality</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LightRegulationFunctionality">http://elite.polito.it/ontologies/dogont.owl#LightRegulationFunctionality</seealso>
    let ``_.owl#LightRegulationFunctionality`` =
        Prefixed_Name(dogont, ".owl#LightRegulationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OverloadPauseResumeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OverloadPauseResumeCommand">http://elite.polito.it/ontologies/dogont.owl#OverloadPauseResumeCommand</seealso>
    let ``_.owl#OverloadPauseResumeCommand`` =
        Prefixed_Name(dogont, ".owl#OverloadPauseResumeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OverloadPauseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OverloadPauseCommand">http://elite.polito.it/ontologies/dogont.owl#OverloadPauseCommand</seealso>
    let ``_.owl#OverloadPauseCommand`` =
        Prefixed_Name(dogont, ".owl#OverloadPauseCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotificationFunctionality</seealso>
    let ``_.owl#SinglePhaseCurrentMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseCurrentMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeter</seealso>
    let ``_.owl#SinglePhaseCurrentMeter`` =
        Prefixed_Name(dogont, ".owl#SinglePhaseCurrentMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Boiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sealed vessel where water is warm up</para>
    /// labels<para>Boiler</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Boiler">http://elite.polito.it/ontologies/dogont.owl#Boiler</seealso>
    let ``_.owl#Boiler`` = Prefixed_Name(dogont, ".owl#Boiler") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#WhiteGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Major household appliances.
    ///
    /// It mus be noticed that the functionality modeling uses existential quantifiers for functionalities that can be optional, this is only for the sake of easier interpretation and should be improved in future releases</para>
    /// labels<para>WhiteGoods</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WhiteGoods">http://elite.polito.it/ontologies/dogont.owl#WhiteGoods</seealso>
    let ``_.owl#WhiteGoods`` = Prefixed_Name(dogont, ".owl#WhiteGoods") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseApparentPowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseApparentPowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseApparentPowerCommand</seealso>
    let ``_.owl#Get3PhaseApparentPowerCommand`` =
        Prefixed_Name(dogont, ".owl#Get3PhaseApparentPowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementState</seealso>
    let ``_.owl#ThreePhaseReactivePowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseReactivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActiveDiscoveryStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActiveDiscoveryStateValue">http://elite.polito.it/ontologies/dogont.owl#ActiveDiscoveryStateValue</seealso>
    let ``_.owl#ActiveDiscoveryStateValue`` =
        Prefixed_Name(dogont, ".owl#ActiveDiscoveryStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociatingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociatingStateValue">http://elite.polito.it/ontologies/dogont.owl#AssociatingStateValue</seealso>
    let ``_.owl#AssociatingStateValue`` =
        Prefixed_Name(dogont, ".owl#AssociatingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AuthenticatedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AuthenticatedStateValue">http://elite.polito.it/ontologies/dogont.owl#AuthenticatedStateValue</seealso>
    let ``_.owl#AuthenticatedStateValue`` =
        Prefixed_Name(dogont, ".owl#AuthenticatedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AutoRegulationStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AutoRegulationStateValue">http://elite.polito.it/ontologies/dogont.owl#AutoRegulationStateValue</seealso>
    let ``_.owl#AutoRegulationStateValue`` =
        Prefixed_Name(dogont, ".owl#AutoRegulationStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AuxStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AuxStateValue">http://elite.polito.it/ontologies/dogont.owl#AuxStateValue</seealso>
    let ``_.owl#AuxStateValue`` =
        Prefixed_Name(dogont, ".owl#AuxStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryIdleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryIdleNotification">http://elite.polito.it/ontologies/dogont.owl#DiscoveryIdleNotification</seealso>
    let ``_.owl#DiscoveryIdleNotification`` =
        Prefixed_Name(dogont, ".owl#DiscoveryIdleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscoveryNotificationFunctionality</seealso>
    let ``_.owl#DiscoveryNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#DiscoveryNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetHeatingEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetHeatingEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetHeatingEnergyCommand</seealso>
    let ``_.owl#GetHeatingEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#GetHeatingEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetMultiTariff1PhaseActiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseActiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseActiveEnergyCommand</seealso>
    let ``_.owl#GetMultiTariff1PhaseActiveEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#GetMultiTariff1PhaseActiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetMultiTariff1PhaseReactiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseReactiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseReactiveEnergyCommand</seealso>
    let ``_.owl#GetMultiTariff1PhaseReactiveEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#GetMultiTariff1PhaseReactiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetMultiTariff3PhaseActiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseActiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseActiveEnergyCommand</seealso>
    let ``_.owl#GetMultiTariff3PhaseActiveEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#GetMultiTariff3PhaseActiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetMultiTariff3PhaseReactiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseReactiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseReactiveEnergyCommand</seealso>
    let ``_.owl#GetMultiTariff3PhaseReactiveEnergyCommand`` =
        Prefixed_Name(dogont, ".owl#GetMultiTariff3PhaseReactiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetPowerFactorCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetPowerFactorCommand">http://elite.polito.it/ontologies/dogont.owl#GetPowerFactorCommand</seealso>
    let ``_.owl#GetPowerFactorCommand`` =
        Prefixed_Name(dogont, ".owl#GetPowerFactorCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdentificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derives from the general cluster functionalities defined in ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdentificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#IdentificationFunctionality</seealso>
    let ``_.owl#IdentificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#IdentificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdentificationNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derives from the general cluster functionalities defined in ZigBee HA specifications</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdentificationNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#IdentificationNotificationFunctionality</seealso>
    let ``_.owl#IdentificationNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#IdentificationNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeaterState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeaterState">http://elite.polito.it/ontologies/dogont.owl#HeaterState</seealso>
    let ``_.owl#HeaterState`` =
        Prefixed_Name(dogont, ".owl#HeaterState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControlNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControlNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#LevelControlNotificationFunctionality</seealso>
    let ``_.owl#LevelControlNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#LevelControlNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SpeedNotificationFunctionality</seealso>
    let ``_.owl#SpeedNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#SpeedNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ReactiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification</seealso>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseEnergyMeter</seealso>
    let ``_.owl#MultiTariffThreePhaseEnergyMeter`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseReactiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyState</seealso>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyState`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseReactiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification</seealso>
    let ``_.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleEventNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotification">http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotification</seealso>
    let ``_.owl#MultipleEventNotification`` =
        Prefixed_Name(dogont, ".owl#MultipleEventNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementFunctionality</seealso>
    let ``_.owl#MultipleFlowMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultipleFlowMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementNotificationFunctionality</seealso>
    let ``_.owl#MultipleFlowMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultipleFlowMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Flow  Sensor device measures and periodically reports the flow rate of a liquid (typically water)</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowSensor">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowSensor</seealso>
    let ``_.owl#MultipleFlowSensor`` =
        Prefixed_Name(dogont, ".owl#MultipleFlowSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleHumidityMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The capability of measuring the humidity of a room</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementFunctionality</seealso>
    let ``_.owl#MultipleHumidityMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultipleHumidityMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleHumidityMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The notification for requesting humidity measurment...</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementNotificationFunctionality</seealso>
    let ``_.owl#MultipleHumidityMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultipleHumidityMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementFunctionality</seealso>
    let ``_.owl#MultiplePressureMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiplePressureMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementNotificationFunctionality</seealso>
    let ``_.owl#MultiplePressureMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#MultiplePressureMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThermostatQueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThermostatQueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThermostatQueryFunctionality</seealso>
    let ``_.owl#ThermostatQueryFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThermostatQueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThermostaticRadiatorValve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThermostaticRadiatorValve">http://elite.polito.it/ontologies/dogont.owl#ThermostaticRadiatorValve</seealso>
    let ``_.owl#ThermostaticRadiatorValve`` =
        Prefixed_Name(dogont, ".owl#ThermostaticRadiatorValve") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementFunctionality</seealso>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotification</seealso>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyState</seealso>
    let ``_.owl#ThreePhaseActiveEnergyState`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotification</seealso>
    let ``_.owl#ThreePhaseActivePowerMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActivePowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementState</seealso>
    let ``_.owl#ThreePhaseActivePowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeter</seealso>
    let ``_.owl#ThreePhaseActivePowerMeter`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseActivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementFunctionality</seealso>
    let ``_.owl#ThreePhaseApparentPowerMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseApparentPowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotification</seealso>
    let ``_.owl#ThreePhaseApparentPowerMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseApparentPowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality</seealso>
    let ``_.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementState</seealso>
    let ``_.owl#ThreePhaseApparentPowerMeasurementState`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseApparentPowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeter</seealso>
    let ``_.owl#ThreePhaseApparentPowerMeter`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseApparentPowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementFunctionality</seealso>
    let ``_.owl#ThreePhaseCurrentMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#ThreePhaseCurrentMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#instanceId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#instanceId">http://elite.polito.it/ontologies/dogont.owl#instanceId</seealso>
    let ``_.owl#instanceId`` = Prefixed_Name(dogont, ".owl#instanceId") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#nodeId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#nodeId">http://elite.polito.it/ontologies/dogont.owl#nodeId</seealso>
    let ``_.owl#nodeId`` = Prefixed_Name(dogont, ".owl#nodeId") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#notificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#notificationOf">http://elite.polito.it/ontologies/dogont.owl#notificationOf</seealso>
    let ``_.owl#notificationOf`` =
        Prefixed_Name(dogont, ".owl#notificationOf") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#plugOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#plugOf">http://elite.polito.it/ontologies/dogont.owl#plugOf</seealso>
    let ``_.owl#plugOf`` = Prefixed_Name(dogont, ".owl#plugOf") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#statevalueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#statevalueOf">http://elite.polito.it/ontologies/dogont.owl#statevalueOf</seealso>
    let ``_.owl#statevalueOf`` =
        Prefixed_Name(dogont, ".owl#statevalueOf") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonProperty">http://elite.polito.it/ontologies/dogont.owl#EchelonProperty</seealso>
    let ``_.owl#EchelonProperty`` =
        Prefixed_Name(dogont, ".owl#EchelonProperty") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KonnexProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexProperty">http://elite.polito.it/ontologies/dogont.owl#KonnexProperty</seealso>
    let ``_.owl#KonnexProperty`` =
        Prefixed_Name(dogont, ".owl#KonnexProperty") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#commandParamValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#commandParamValue">http://elite.polito.it/ontologies/dogont.owl#commandParamValue</seealso>
    let ``_.owl#commandParamValue`` =
        Prefixed_Name(dogont, ".owl#commandParamValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#connectionTimeOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The time before the connection expires</para>
    /// labels<para>connectionTimeOut</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#connectionTimeOut">http://elite.polito.it/ontologies/dogont.owl#connectionTimeOut</seealso>
    let ``_.owl#connectionTimeOut`` =
        Prefixed_Name(dogont, ".owl#connectionTimeOut") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#flashingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The flashing period duration in seconds</para>
    /// labels<para>flashingTime</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#flashingTime">http://elite.polito.it/ontologies/dogont.owl#flashingTime</seealso>
    let ``_.owl#flashingTime`` =
        Prefixed_Name(dogont, ".owl#flashingTime") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#phaseID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#phaseID">http://elite.polito.it/ontologies/dogont.owl#phaseID</seealso>
    let ``_.owl#phaseID`` = Prefixed_Name(dogont, ".owl#phaseID") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#probeID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#probeID">http://elite.polito.it/ontologies/dogont.owl#probeID</seealso>
    let ``_.owl#probeID`` = Prefixed_Name(dogont, ".owl#probeID") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatNotification">http://elite.polito.it/ontologies/dogont.owl#HeatNotification</seealso>
    let ``_.owl#HeatNotification`` =
        Prefixed_Name(dogont, ".owl#HeatNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Shutter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A hinged cover or screen for a window, usually fitted with louvers.</para>
    /// labels<para>Shutter</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Shutter">http://elite.polito.it/ontologies/dogont.owl#Shutter</seealso>
    let ``_.owl#Shutter`` = Prefixed_Name(dogont, ".owl#Shutter") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Desk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A piece of furniture with a writing surface and usually drawers or other compartments</para>
    /// labels<para>Desk</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Desk">http://elite.polito.it/ontologies/dogont.owl#Desk</seealso>
    let ``_.owl#Desk`` = Prefixed_Name(dogont, ".owl#Desk") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementFunctionality</seealso>
    let ``_.owl#PressureMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#PressureMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The capability of measuring temperatures</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementFunctionality</seealso>
    let ``_.owl#TemperatureMeasurementFunctionality`` =
        Prefixed_Name(dogont, ".owl#TemperatureMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowRateMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementNotification</seealso>
    let ``_.owl#FlowRateMeasurementNotification`` =
        Prefixed_Name(dogont, ".owl#FlowRateMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The notification for requesting humidity measurment...</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotificationFunctionality</seealso>
    let ``_.owl#HumidityMeasurementNotificationFunctionality`` =
        Prefixed_Name(dogont, ".owl#HumidityMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeter</seealso>
    let ``_.owl#HeatingEnergyMeter`` =
        Prefixed_Name(dogont, ".owl#HeatingEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#generateCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#generateCommand">http://elite.polito.it/ontologies/dogont.owl#generateCommand</seealso>
    let ``_.owl#generateCommand`` =
        Prefixed_Name(dogont, ".owl#generateCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#hasControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association between an object and its controller,e.g.switch,button,knob</para>
    /// labels<para>hasControl</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasControl">http://elite.polito.it/ontologies/dogont.owl#hasControl</seealso>
    let ``_.owl#hasControl`` = Prefixed_Name(dogont, ".owl#hasControl") |> PrefixedName
