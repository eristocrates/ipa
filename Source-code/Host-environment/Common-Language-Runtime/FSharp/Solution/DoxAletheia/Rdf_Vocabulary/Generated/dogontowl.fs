namespace http.elite.polito.it.ontologies.dogont.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dogontowl =
    let _namespace_iri = Namespace_Iri dogontowl |> NamespaceIRI

    /// <summary>
    ///   <para>dogont:.owl#AccessControlSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System that provides security about access"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AccessControlSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AccessControlSystem">http://elite.polito.it/ontologies/dogont.owl#AccessControlSystem</seealso>
    let AccessControlSystem =
        Prefixed_Name(dogontowl, "AccessControlSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Acoustic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Acoustic">http://elite.polito.it/ontologies/dogont.owl#Acoustic</seealso>
    let Acoustic = Prefixed_Name(dogontowl, "Acoustic") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActiveDiscoveryStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActiveDiscoveryStateValue">http://elite.polito.it/ontologies/dogont.owl#ActiveDiscoveryStateValue</seealso>
    let ActiveDiscoveryStateValue =
        Prefixed_Name(dogontowl, "ActiveDiscoveryStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementFunctionality</seealso>
    let ActiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyMeasurementNotificationFunctionality</seealso>
    let ActiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActiveEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#ActiveEnergyStateValue</seealso>
    let ActiveEnergyStateValue =
        Prefixed_Name(dogontowl, "ActiveEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementFunctionality</seealso>
    let ActivePowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ActivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementNotificationFunctionality</seealso>
    let ActivePowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ActivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeasurementState</seealso>
    let ActivePowerMeasurementState =
        Prefixed_Name(dogontowl, "ActivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#ActivePowerMeter</seealso>
    let ActivePowerMeter = Prefixed_Name(dogontowl, "ActivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePowerStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePowerStateValue">http://elite.polito.it/ontologies/dogont.owl#ActivePowerStateValue</seealso>
    let ActivePowerStateValue =
        Prefixed_Name(dogontowl, "ActivePowerStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ActivePushLinkAuthenticationStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ActivePushLinkAuthenticationStateValue">http://elite.polito.it/ontologies/dogont.owl#ActivePushLinkAuthenticationStateValue</seealso>
    let ActivePushLinkAuthenticationStateValue =
        Prefixed_Name(dogontowl, "ActivePushLinkAuthenticationStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mechanism that puts something into automatic action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Actuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Actuator">http://elite.polito.it/ontologies/dogont.owl#Actuator</seealso>
    let Actuator = Prefixed_Name(dogontowl, "Actuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AirConditioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A system that keeps air cool and dry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AirConditioningSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AirConditioningSystem">http://elite.polito.it/ontologies/dogont.owl#AirConditioningSystem</seealso>
    let AirConditioningSystem =
        Prefixed_Name(dogontowl, "AirConditioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AlarmClock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A clock that wakes sleeper at preset time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AlarmClock"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AlarmClock">http://elite.polito.it/ontologies/dogont.owl#AlarmClock</seealso>
    let AlarmClock = Prefixed_Name(dogontowl, "AlarmClock") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AlertNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AlertNotification">http://elite.polito.it/ontologies/dogont.owl#AlertNotification</seealso>
    let AlertNotification =
        Prefixed_Name(dogontowl, "AlertNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AlertNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AlertNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#AlertNotificationFunctionality</seealso>
    let AlertNotificationFunctionality =
        Prefixed_Name(dogontowl, "AlertNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AnsweringMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electronic device that answers the telephone and records messages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AnsweringMachine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AnsweringMachine">http://elite.polito.it/ontologies/dogont.owl#AnsweringMachine</seealso>
    let AnsweringMachine = Prefixed_Name(dogontowl, "AnsweringMachine") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AntiIntrusionSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System that provides security about intrusion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AntiIntrusionSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AntiIntrusionSystem">http://elite.polito.it/ontologies/dogont.owl#AntiIntrusionSystem</seealso>
    let AntiIntrusionSystem =
        Prefixed_Name(dogontowl, "AntiIntrusionSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementFunctionality</seealso>
    let ApparentPowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ApparentPowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementNotificationFunctionality</seealso>
    let ApparentPowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ApparentPowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeasurementState</seealso>
    let ApparentPowerMeasurementState =
        Prefixed_Name(dogontowl, "ApparentPowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeter">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerMeter</seealso>
    let ApparentPowerMeter =
        Prefixed_Name(dogontowl, "ApparentPowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApparentPowerStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApparentPowerStateValue">http://elite.polito.it/ontologies/dogont.owl#ApparentPowerStateValue</seealso>
    let ApparentPowerStateValue =
        Prefixed_Name(dogontowl, "ApparentPowerStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApplianceCycleTimingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApplianceCycleTimingNotification">http://elite.polito.it/ontologies/dogont.owl#ApplianceCycleTimingNotification</seealso>
    let ApplianceCycleTimingNotification =
        Prefixed_Name(dogontowl, "ApplianceCycleTimingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApplianceManagementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApplianceManagementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ApplianceManagementFunctionality</seealso>
    let ApplianceManagementFunctionality =
        Prefixed_Name(dogontowl, "ApplianceManagementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ApplianceRunNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ApplianceRunNotification">http://elite.polito.it/ontologies/dogont.owl#ApplianceRunNotification</seealso>
    let ApplianceRunNotification =
        Prefixed_Name(dogontowl, "ApplianceRunNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Appliances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Durable goods for home or office use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Appliances"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Appliances">http://elite.polito.it/ontologies/dogont.owl#Appliances</seealso>
    let Appliances = Prefixed_Name(dogontowl, "Appliances") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Architectural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All the architectural elements that compose the environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Architectural"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Architectural">http://elite.polito.it/ontologies/dogont.owl#Architectural</seealso>
    let Architectural = Prefixed_Name(dogontowl, "Architectural") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Armchair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Chair with a support on each side for arms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Armchair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Armchair">http://elite.polito.it/ontologies/dogont.owl#Armchair</seealso>
    let Armchair = Prefixed_Name(dogontowl, "Armchair") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#AssociateCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociateCommand">http://elite.polito.it/ontologies/dogont.owl#AssociateCommand</seealso>
    let AssociateCommand = Prefixed_Name(dogontowl, "AssociateCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociateFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociateFunctionality">http://elite.polito.it/ontologies/dogont.owl#AssociateFunctionality</seealso>
    let AssociateFunctionality =
        Prefixed_Name(dogontowl, "AssociateFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociatingDeviceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociatingDeviceNotification">http://elite.polito.it/ontologies/dogont.owl#AssociatingDeviceNotification</seealso>
    let AssociatingDeviceNotification =
        Prefixed_Name(dogontowl, "AssociatingDeviceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociatingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociatingStateValue">http://elite.polito.it/ontologies/dogont.owl#AssociatingStateValue</seealso>
    let AssociatingStateValue =
        Prefixed_Name(dogontowl, "AssociatingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AssociationNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AssociationNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#AssociationNotificationFunctionality</seealso>
    let AssociationNotificationFunctionality =
        Prefixed_Name(dogontowl, "AssociationNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AuthenticatedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AuthenticatedStateValue">http://elite.polito.it/ontologies/dogont.owl#AuthenticatedStateValue</seealso>
    let AuthenticatedStateValue =
        Prefixed_Name(dogontowl, "AuthenticatedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AutoRegulationStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AutoRegulationStateValue">http://elite.polito.it/ontologies/dogont.owl#AutoRegulationStateValue</seealso>
    let AutoRegulationStateValue =
        Prefixed_Name(dogontowl, "AutoRegulationStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#AuxStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AuxStateValue">http://elite.polito.it/ontologies/dogont.owl#AuxStateValue</seealso>
    let AuxStateValue = Prefixed_Name(dogontowl, "AuxStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Awning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A canopy made of canvas to shelter people or things from rain or sun."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Awning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Awning">http://elite.polito.it/ontologies/dogont.owl#Awning</seealso>
    let Awning = Prefixed_Name(dogontowl, "Awning") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#AwningActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mechanism that allow automatic control about awning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AwningActuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#AwningActuator">http://elite.polito.it/ontologies/dogont.owl#AwningActuator</seealso>
    let AwningActuator = Prefixed_Name(dogontowl, "AwningActuator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#BTicinoComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Components manufactured by Bticino"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BTicinoComponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BTicinoComponent">http://elite.polito.it/ontologies/dogont.owl#BTicinoComponent</seealso>
    let BTicinoComponent = Prefixed_Name(dogontowl, "BTicinoComponent") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#BTicinoGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A BTIcino Gateway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BTicinoGateway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BTicinoGateway">http://elite.polito.it/ontologies/dogont.owl#BTicinoGateway</seealso>
    let BTicinoGateway = Prefixed_Name(dogontowl, "BTicinoGateway") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#BTicinoProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BTicinoProperty">http://elite.polito.it/ontologies/dogont.owl#BTicinoProperty</seealso>
    let BTicinoProperty = Prefixed_Name(dogontowl, "BTicinoProperty") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Balcony</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A platform projecting from the wall of a building and surrounded by a balustrade or railing or parapet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Balcony"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Balcony">http://elite.polito.it/ontologies/dogont.owl#Balcony</seealso>
    let Balcony = Prefixed_Name(dogontowl, "Balcony") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Bathroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room containing a bath or shower and usually a washbasin and toilet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bathroom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bathroom">http://elite.polito.it/ontologies/dogont.owl#Bathroom</seealso>
    let Bathroom = Prefixed_Name(dogontowl, "Bathroom") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Bathtub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A relatively large open container that you fill with water and use to wash the body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bathtub"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bathtub">http://elite.polito.it/ontologies/dogont.owl#Bathtub</seealso>
    let Bathtub = Prefixed_Name(dogontowl, "Bathtub") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BatteryLevelNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotification">http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotification</seealso>
    let BatteryLevelNotification =
        Prefixed_Name(dogontowl, "BatteryLevelNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BatteryLevelNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#BatteryLevelNotificationFunctionality</seealso>
    let BatteryLevelNotificationFunctionality =
        Prefixed_Name(dogontowl, "BatteryLevelNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Bed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Piece of furniture that provides a place to sleep."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bed">http://elite.polito.it/ontologies/dogont.owl#Bed</seealso>
    let Bed = Prefixed_Name(dogontowl, "Bed") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Bedroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room used primarily for sleeping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bedroom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bedroom">http://elite.polito.it/ontologies/dogont.owl#Bedroom</seealso>
    let Bedroom = Prefixed_Name(dogontowl, "Bedroom") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Bidet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A basin for washing genitals and anal area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bidet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Bidet">http://elite.polito.it/ontologies/dogont.owl#Bidet</seealso>
    let Bidet = Prefixed_Name(dogontowl, "Bidet") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#BlueStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BlueStateValue">http://elite.polito.it/ontologies/dogont.owl#BlueStateValue</seealso>
    let BlueStateValue = Prefixed_Name(dogontowl, "BlueStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Boiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sealed vessel where water is warm up"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Boiler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Boiler">http://elite.polito.it/ontologies/dogont.owl#Boiler</seealso>
    let Boiler = Prefixed_Name(dogontowl, "Boiler") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BrightnessStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BrightnessStateValue">http://elite.polito.it/ontologies/dogont.owl#BrightnessStateValue</seealso>
    let BrightnessStateValue =
        Prefixed_Name(dogontowl, "BrightnessStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BrownGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Small household electrical entertainment appliances"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BrownGoods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BrownGoods">http://elite.polito.it/ontologies/dogont.owl#BrownGoods</seealso>
    let BrownGoods = Prefixed_Name(dogontowl, "BrownGoods") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Building">http://elite.polito.it/ontologies/dogont.owl#Building</seealso>
    let Building = Prefixed_Name(dogontowl, "Building") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BuildingEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical environment in which people lives, e.g. kitchen, bathroom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BuildingEnvironment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BuildingEnvironment">http://elite.polito.it/ontologies/dogont.owl#BuildingEnvironment</seealso>
    let BuildingEnvironment =
        Prefixed_Name(dogontowl, "BuildingEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#BuildingThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All things that creates a Building, it is intended as root of all building components"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BuildingThing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#BuildingThing">http://elite.polito.it/ontologies/dogont.owl#BuildingThing</seealso>
    let BuildingThing = Prefixed_Name(dogontowl, "BuildingThing") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Button</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A monostable electrical switch operated by pressing a button"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Button"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Button">http://elite.polito.it/ontologies/dogont.owl#Button</seealso>
    let Button = Prefixed_Name(dogontowl, "Button") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ButtonMNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ButtonMNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ButtonMNotificationFunctionality</seealso>
    let ButtonMNotificationFunctionality =
        Prefixed_Name(dogontowl, "ButtonMNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ButtonNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ButtonNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ButtonNotificationFunctionality</seealso>
    let ButtonNotificationFunctionality =
        Prefixed_Name(dogontowl, "ButtonNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Buzzer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An electric signaling device, such as a doorbell, that makes a buzzing sound."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Buzzer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Buzzer">http://elite.polito.it/ontologies/dogont.owl#Buzzer</seealso>
    let Buzzer = Prefixed_Name(dogontowl, "Buzzer") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#CDStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CDStateValue">http://elite.polito.it/ontologies/dogont.owl#CDStateValue</seealso>
    let CDStateValue = Prefixed_Name(dogontowl, "CDStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CameraPictureImageControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureImageControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#CameraPictureImageControlFunctionality</seealso>
    let CameraPictureImageControlFunctionality =
        Prefixed_Name(dogontowl, "CameraPictureImageControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CameraPictureQualityControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureQualityControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#CameraPictureQualityControlFunctionality</seealso>
    let CameraPictureQualityControlFunctionality =
        Prefixed_Name(dogontowl, "CameraPictureQualityControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CameraPictureZoomPanControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CameraPictureZoomPanControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#CameraPictureZoomPanControlFunctionality</seealso>
    let CameraPictureZoomPanControlFunctionality =
        Prefixed_Name(dogontowl, "CameraPictureZoomPanControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Ceiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The overhead upper surface of a room"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ceiling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Ceiling">http://elite.polito.it/ontologies/dogont.owl#Ceiling</seealso>
    let Ceiling = Prefixed_Name(dogontowl, "Ceiling") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Chair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A seat for one person, with a support for the back."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Chair">http://elite.polito.it/ontologies/dogont.owl#Chair</seealso>
    let Chair = Prefixed_Name(dogontowl, "Chair") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ChangedDesiredTemperatureNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ChangedDesiredTemperatureNotification">http://elite.polito.it/ontologies/dogont.owl#ChangedDesiredTemperatureNotification</seealso>
    let ChangedDesiredTemperatureNotification =
        Prefixed_Name(dogontowl, "ChangedDesiredTemperatureNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ChannelControlNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ChannelControlNotification">http://elite.polito.it/ontologies/dogont.owl#ChannelControlNotification</seealso>
    let ChannelControlNotification =
        Prefixed_Name(dogontowl, "ChannelControlNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ChannelStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ChannelStateValue">http://elite.polito.it/ontologies/dogont.owl#ChannelStateValue</seealso>
    let ChannelStateValue =
        Prefixed_Name(dogontowl, "ChannelStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleFunctionality">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleFunctionality</seealso>
    let ClimateScheduleFunctionality =
        Prefixed_Name(dogontowl, "ClimateScheduleFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotification">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotification</seealso>
    let ClimateScheduleNotification =
        Prefixed_Name(dogontowl, "ClimateScheduleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleNotificationFunctionality</seealso>
    let ClimateScheduleNotificationFunctionality =
        Prefixed_Name(dogontowl, "ClimateScheduleNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleQueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleQueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleQueryFunctionality</seealso>
    let ClimateScheduleQueryFunctionality =
        Prefixed_Name(dogontowl, "ClimateScheduleQueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleState">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleState</seealso>
    let ClimateScheduleState =
        Prefixed_Name(dogontowl, "ClimateScheduleState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ClimateScheduleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleStateValue">http://elite.polito.it/ontologies/dogont.owl#ClimateScheduleStateValue</seealso>
    let ClimateScheduleStateValue =
        Prefixed_Name(dogontowl, "ClimateScheduleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Clock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Clock">http://elite.polito.it/ontologies/dogont.owl#Clock</seealso>
    let Clock = Prefixed_Name(dogontowl, "Clock") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#CloseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CloseCommand">http://elite.polito.it/ontologies/dogont.owl#CloseCommand</seealso>
    let CloseCommand = Prefixed_Name(dogontowl, "CloseCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CloseNetworkCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CloseNetworkCommand">http://elite.polito.it/ontologies/dogont.owl#CloseNetworkCommand</seealso>
    let CloseNetworkCommand =
        Prefixed_Name(dogontowl, "CloseNetworkCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CloseNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CloseNotification">http://elite.polito.it/ontologies/dogont.owl#CloseNotification</seealso>
    let CloseNotification =
        Prefixed_Name(dogontowl, "CloseNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CloseStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CloseStateValue">http://elite.polito.it/ontologies/dogont.owl#CloseStateValue</seealso>
    let CloseStateValue = Prefixed_Name(dogontowl, "CloseStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Closet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Confine to a small space."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Closet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Closet">http://elite.polito.it/ontologies/dogont.owl#Closet</seealso>
    let Closet = Prefixed_Name(dogontowl, "Closet") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementFunctionality</seealso>
    let Co2MeasurementFunctionality =
        Prefixed_Name(dogontowl, "Co2MeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotification</seealso>
    let Co2MeasurementNotification =
        Prefixed_Name(dogontowl, "Co2MeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementNotificationFunctionality</seealso>
    let Co2MeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "Co2MeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementState">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementState</seealso>
    let Co2MeasurementState =
        Prefixed_Name(dogontowl, "Co2MeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2MeasurementStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementStateValue">http://elite.polito.it/ontologies/dogont.owl#Co2MeasurementStateValue</seealso>
    let Co2MeasurementStateValue =
        Prefixed_Name(dogontowl, "Co2MeasurementStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Co2Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Co2Sensor">http://elite.polito.it/ontologies/dogont.owl#Co2Sensor</seealso>
    let Co2Sensor = Prefixed_Name(dogontowl, "Co2Sensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#CoffeeMaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A kitchen appliance for brewing coffee automatically"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CoffeeMaker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoffeeMaker">http://elite.polito.it/ontologies/dogont.owl#CoffeeMaker</seealso>
    let CoffeeMaker = Prefixed_Name(dogontowl, "CoffeeMaker") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColdWaterM3MeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColdWaterM3MeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ColdWaterM3MeasurementNotification</seealso>
    let ColdWaterM3MeasurementNotification =
        Prefixed_Name(dogontowl, "ColdWaterM3MeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#ColorControlFunctionality</seealso>
    let ColorControlFunctionality =
        Prefixed_Name(dogontowl, "ColorControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorDimmableLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Color Dimmable Light device can be switched on and off, and its luminance, hue and saturation levels may be controlled, derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorDimmableLight">http://elite.polito.it/ontologies/dogont.owl#ColorDimmableLight</seealso>
    let ColorDimmableLight =
        Prefixed_Name(dogontowl, "ColorDimmableLight") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorDimmerSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Color Dimmer Switch device can turn a light on and off, and control the luminance, hue and saturation levels of a multicolor light, derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorDimmerSwitch">http://elite.polito.it/ontologies/dogont.owl#ColorDimmerSwitch</seealso>
    let ColorDimmerSwitch =
        Prefixed_Name(dogontowl, "ColorDimmerSwitch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorHSBNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorHSBNotification">http://elite.polito.it/ontologies/dogont.owl#ColorHSBNotification</seealso>
    let ColorHSBNotification =
        Prefixed_Name(dogontowl, "ColorHSBNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ColorNotificationFunctionality</seealso>
    let ColorNotificationFunctionality =
        Prefixed_Name(dogontowl, "ColorNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorRGBNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorRGBNotification">http://elite.polito.it/ontologies/dogont.owl#ColorRGBNotification</seealso>
    let ColorRGBNotification =
        Prefixed_Name(dogontowl, "ColorRGBNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ColorState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorState">http://elite.polito.it/ontologies/dogont.owl#ColorState</seealso>
    let ColorState = Prefixed_Name(dogontowl, "ColorState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ColorStateHSB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorStateHSB">http://elite.polito.it/ontologies/dogont.owl#ColorStateHSB</seealso>
    let ColorStateHSB = Prefixed_Name(dogontowl, "ColorStateHSB") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ColorStateRGB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ColorStateRGB">http://elite.polito.it/ontologies/dogont.owl#ColorStateRGB</seealso>
    let ColorStateRGB = Prefixed_Name(dogontowl, "ColorStateRGB") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Command">http://elite.polito.it/ontologies/dogont.owl#Command</seealso>
    let Command = Prefixed_Name(dogontowl, "Command") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Appliances for communicate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Communication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Communication">http://elite.polito.it/ontologies/dogont.owl#Communication</seealso>
    let Communication = Prefixed_Name(dogontowl, "Communication") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Computer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A machine for performing calculations automatically, work and play"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Computer">http://elite.polito.it/ontologies/dogont.owl#Computer</seealso>
    let Computer = Prefixed_Name(dogontowl, "Computer") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ConfigurationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ConfigurationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ConfigurationFunctionality</seealso>
    let ConfigurationFunctionality =
        Prefixed_Name(dogontowl, "ConfigurationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ConnectedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ConnectedStateValue">http://elite.polito.it/ontologies/dogont.owl#ConnectedStateValue</seealso>
    let ConnectedStateValue =
        Prefixed_Name(dogontowl, "ConnectedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ConnectionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ConnectionState">http://elite.polito.it/ontologies/dogont.owl#ConnectionState</seealso>
    let ConnectionState = Prefixed_Name(dogontowl, "ConnectionState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ConsumedWaterStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ConsumedWaterStateValue">http://elite.polito.it/ontologies/dogont.owl#ConsumedWaterStateValue</seealso>
    let ConsumedWaterStateValue =
        Prefixed_Name(dogontowl, "ConsumedWaterStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ContinuousControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionalities continuous in time or space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContinuousFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ContinuousControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#ContinuousControlFunctionality</seealso>
    let ContinuousControlFunctionality =
        Prefixed_Name(dogontowl, "ContinuousControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ContinuousNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Notification of continuous values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContinuousNotificationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ContinuousNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ContinuousNotificationFunctionality</seealso>
    let ContinuousNotificationFunctionality =
        Prefixed_Name(dogontowl, "ContinuousNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ContinuousState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"States continuous in time or space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContinuousState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ContinuousState">http://elite.polito.it/ontologies/dogont.owl#ContinuousState</seealso>
    let ContinuousState = Prefixed_Name(dogontowl, "ContinuousState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ContinuousValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Continuous value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ContinuousValue">http://elite.polito.it/ontologies/dogont.owl#ContinuousValue</seealso>
    let ContinuousValue = Prefixed_Name(dogontowl, "ContinuousValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mechanism that controls the interaction with the electrical system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Control"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Control">http://elite.polito.it/ontologies/dogont.owl#Control</seealso>
    let Control = Prefixed_Name(dogontowl, "Control") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Capability of a controllable building thing that can receive commands"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ControlFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#ControlFunctionality</seealso>
    let ControlFunctionality =
        Prefixed_Name(dogontowl, "ControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Controllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All building things that can be controlled by domotic system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Controllable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Controllable">http://elite.polito.it/ontologies/dogont.owl#Controllable</seealso>
    let Controllable = Prefixed_Name(dogontowl, "Controllable") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Cooker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A utensil for cooking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cooker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Cooker">http://elite.polito.it/ontologies/dogont.owl#Cooker</seealso>
    let Cooker = Prefixed_Name(dogontowl, "Cooker") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#CoolCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoolCommand">http://elite.polito.it/ontologies/dogont.owl#CoolCommand</seealso>
    let CoolCommand = Prefixed_Name(dogontowl, "CoolCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#CoolNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoolNotification">http://elite.polito.it/ontologies/dogont.owl#CoolNotification</seealso>
    let CoolNotification = Prefixed_Name(dogontowl, "CoolNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CoolingApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoolingApplianceState">http://elite.polito.it/ontologies/dogont.owl#CoolingApplianceState</seealso>
    let CoolingApplianceState =
        Prefixed_Name(dogontowl, "CoolingApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CoolingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CoolingStateValue">http://elite.polito.it/ontologies/dogont.owl#CoolingStateValue</seealso>
    let CoolingStateValue =
        Prefixed_Name(dogontowl, "CoolingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Cupboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small room (or recess) or cabinet used for storage space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cupboard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Cupboard">http://elite.polito.it/ontologies/dogont.owl#Cupboard</seealso>
    let Cupboard = Prefixed_Name(dogontowl, "Cupboard") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementFunctionality</seealso>
    let CurrentMeasurementFunctionality =
        Prefixed_Name(dogontowl, "CurrentMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementNotificationFunctionality</seealso>
    let CurrentMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "CurrentMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementState">http://elite.polito.it/ontologies/dogont.owl#CurrentMeasurementState</seealso>
    let CurrentMeasurementState =
        Prefixed_Name(dogontowl, "CurrentMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentMeter">http://elite.polito.it/ontologies/dogont.owl#CurrentMeter</seealso>
    let CurrentMeter = Prefixed_Name(dogontowl, "CurrentMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CurrentStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CurrentStateValue">http://elite.polito.it/ontologies/dogont.owl#CurrentStateValue</seealso>
    let CurrentStateValue =
        Prefixed_Name(dogontowl, "CurrentStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CycleTimingControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#CycleTimingControlFunctionality</seealso>
    let CycleTimingControlFunctionality =
        Prefixed_Name(dogontowl, "CycleTimingControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CycleTimingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#CycleTimingNotificationFunctionality</seealso>
    let CycleTimingNotificationFunctionality =
        Prefixed_Name(dogontowl, "CycleTimingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#CycleTimingQueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#CycleTimingQueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#CycleTimingQueryFunctionality</seealso>
    let CycleTimingQueryFunctionality =
        Prefixed_Name(dogontowl, "CycleTimingQueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DailyClimateScheduleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DailyClimateScheduleNotification">http://elite.polito.it/ontologies/dogont.owl#DailyClimateScheduleNotification</seealso>
    let DailyClimateScheduleNotification =
        Prefixed_Name(dogontowl, "DailyClimateScheduleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseColorCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseColorCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseColorCommand</seealso>
    let DecreaseColorCommand =
        Prefixed_Name(dogontowl, "DecreaseColorCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseContrastCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseContrastCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseContrastCommand</seealso>
    let DecreaseContrastCommand =
        Prefixed_Name(dogontowl, "DecreaseContrastCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseLuminosityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseLuminosityCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseLuminosityCommand</seealso>
    let DecreaseLuminosityCommand =
        Prefixed_Name(dogontowl, "DecreaseLuminosityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseQualityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseQualityCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseQualityCommand</seealso>
    let DecreaseQualityCommand =
        Prefixed_Name(dogontowl, "DecreaseQualityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DecreaseVolumeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DecreaseVolumeCommand">http://elite.polito.it/ontologies/dogont.owl#DecreaseVolumeCommand</seealso>
    let DecreaseVolumeCommand =
        Prefixed_Name(dogontowl, "DecreaseVolumeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeepFreezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electric refrigerator in which food is frozen and stored for long periods of time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeepFreezer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeepFreezer">http://elite.polito.it/ontologies/dogont.owl#DeepFreezer</seealso>
    let DeepFreezer = Prefixed_Name(dogontowl, "DeepFreezer") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeleteApplianceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeleteApplianceCommand">http://elite.polito.it/ontologies/dogont.owl#DeleteApplianceCommand</seealso>
    let DeleteApplianceCommand =
        Prefixed_Name(dogontowl, "DeleteApplianceCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeleteGroupCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeleteGroupCommand">http://elite.polito.it/ontologies/dogont.owl#DeleteGroupCommand</seealso>
    let DeleteGroupCommand =
        Prefixed_Name(dogontowl, "DeleteGroupCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeleteSceneCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeleteSceneCommand">http://elite.polito.it/ontologies/dogont.owl#DeleteSceneCommand</seealso>
    let DeleteSceneCommand =
        Prefixed_Name(dogontowl, "DeleteSceneCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeleteSceneNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeleteSceneNotification">http://elite.polito.it/ontologies/dogont.owl#DeleteSceneNotification</seealso>
    let DeleteSceneNotification =
        Prefixed_Name(dogontowl, "DeleteSceneNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Desk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of furniture with a writing surface and usually drawers or other compartments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Desk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Desk">http://elite.polito.it/ontologies/dogont.owl#Desk</seealso>
    let Desk = Prefixed_Name(dogontowl, "Desk") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DetectedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DetectedNotification">http://elite.polito.it/ontologies/dogont.owl#DetectedNotification</seealso>
    let DetectedNotification =
        Prefixed_Name(dogontowl, "DetectedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DetectedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DetectedStateValue">http://elite.polito.it/ontologies/dogont.owl#DetectedStateValue</seealso>
    let DetectedStateValue =
        Prefixed_Name(dogontowl, "DetectedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DeviceAssociationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DeviceAssociationState">http://elite.polito.it/ontologies/dogont.owl#DeviceAssociationState</seealso>
    let DeviceAssociationState =
        Prefixed_Name(dogontowl, "DeviceAssociationState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DimmableLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Dimmable Light device is a light that can be switched on and off, and whose luminance level may be controlled, derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DimmableLight">http://elite.polito.it/ontologies/dogont.owl#DimmableLight</seealso>
    let DimmableLight = Prefixed_Name(dogontowl, "DimmableLight") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DimmerLamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lamp that varies the level of illumination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DimmerLamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DimmerLamp">http://elite.polito.it/ontologies/dogont.owl#DimmerLamp</seealso>
    let DimmerLamp = Prefixed_Name(dogontowl, "DimmerLamp") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DimmerSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Switch for controlling dimmable lights, derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DimmerSwitch">http://elite.polito.it/ontologies/dogont.owl#DimmerSwitch</seealso>
    let DimmerSwitch = Prefixed_Name(dogontowl, "DimmerSwitch") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DiningRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room used for dining"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DiningRoom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiningRoom">http://elite.polito.it/ontologies/dogont.owl#DiningRoom</seealso>
    let DiningRoom = Prefixed_Name(dogontowl, "DiningRoom") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisableGasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisableGasCommand">http://elite.polito.it/ontologies/dogont.owl#DisableGasCommand</seealso>
    let DisableGasCommand =
        Prefixed_Name(dogontowl, "DisableGasCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisassociateCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisassociateCommand">http://elite.polito.it/ontologies/dogont.owl#DisassociateCommand</seealso>
    let DisassociateCommand =
        Prefixed_Name(dogontowl, "DisassociateCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisassociatingDeviceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisassociatingDeviceNotification">http://elite.polito.it/ontologies/dogont.owl#DisassociatingDeviceNotification</seealso>
    let DisassociatingDeviceNotification =
        Prefixed_Name(dogontowl, "DisassociatingDeviceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisassociatingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisassociatingStateValue">http://elite.polito.it/ontologies/dogont.owl#DisassociatingStateValue</seealso>
    let DisassociatingStateValue =
        Prefixed_Name(dogontowl, "DisassociatingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisconnectedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisconnectedStateValue">http://elite.polito.it/ontologies/dogont.owl#DisconnectedStateValue</seealso>
    let DisconnectedStateValue =
        Prefixed_Name(dogontowl, "DisconnectedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryActiveNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryActiveNotification">http://elite.polito.it/ontologies/dogont.owl#DiscoveryActiveNotification</seealso>
    let DiscoveryActiveNotification =
        Prefixed_Name(dogontowl, "DiscoveryActiveNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscoveryFunctionality</seealso>
    let DiscoveryFunctionality =
        Prefixed_Name(dogontowl, "DiscoveryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryIdleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryIdleNotification">http://elite.polito.it/ontologies/dogont.owl#DiscoveryIdleNotification</seealso>
    let DiscoveryIdleNotification =
        Prefixed_Name(dogontowl, "DiscoveryIdleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscoveryNotificationFunctionality</seealso>
    let DiscoveryNotificationFunctionality =
        Prefixed_Name(dogontowl, "DiscoveryNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscoveryState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscoveryState">http://elite.polito.it/ontologies/dogont.owl#DiscoveryState</seealso>
    let DiscoveryState = Prefixed_Name(dogontowl, "DiscoveryState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionalities not continuous, with fixed values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DiscreteFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscreteControlFunctionality</seealso>
    let DiscreteControlFunctionality =
        Prefixed_Name(dogontowl, "DiscreteControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Notification of fixed values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DiscreteNotificationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscreteNotificationFunctionality</seealso>
    let DiscreteNotificationFunctionality =
        Prefixed_Name(dogontowl, "DiscreteNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteOutputFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteOutputFunctionality">http://elite.polito.it/ontologies/dogont.owl#DiscreteOutputFunctionality</seealso>
    let DiscreteOutputFunctionality =
        Prefixed_Name(dogontowl, "DiscreteOutputFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DiscreteState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"States not continuous, with fixed values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DiscreteState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteState">http://elite.polito.it/ontologies/dogont.owl#DiscreteState</seealso>
    let DiscreteState = Prefixed_Name(dogontowl, "DiscreteState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DiscreteValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Discrete value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DiscreteValue">http://elite.polito.it/ontologies/dogont.owl#DiscreteValue</seealso>
    let DiscreteValue = Prefixed_Name(dogontowl, "DiscreteValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Dishwasher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A machine for washing dishes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dishwasher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Dishwasher">http://elite.polito.it/ontologies/dogont.owl#Dishwasher</seealso>
    let Dishwasher = Prefixed_Name(dogontowl, "Dishwasher") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DisplayCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisplayCommand">http://elite.polito.it/ontologies/dogont.owl#DisplayCommand</seealso>
    let DisplayCommand = Prefixed_Name(dogontowl, "DisplayCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DisplayFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DisplayFunctionality">http://elite.polito.it/ontologies/dogont.owl#DisplayFunctionality</seealso>
    let DisplayFunctionality =
        Prefixed_Name(dogontowl, "DisplayFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Door</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A swinging or sliding barrier that will close the entrance to a room or building."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Door"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Door">http://elite.polito.it/ontologies/dogont.owl#Door</seealso>
    let Door = Prefixed_Name(dogontowl, "Door") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DoorActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mechanism that allow automatic opening and closing about door"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DoorActuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoorActuator">http://elite.polito.it/ontologies/dogont.owl#DoorActuator</seealso>
    let DoorActuator = Prefixed_Name(dogontowl, "DoorActuator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DoorSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that controls if a door is closed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DoorSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoorSensor">http://elite.polito.it/ontologies/dogont.owl#DoorSensor</seealso>
    let DoorSensor = Prefixed_Name(dogontowl, "DoorSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#DoubleBed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoubleBed">http://elite.polito.it/ontologies/dogont.owl#DoubleBed</seealso>
    let DoubleBed = Prefixed_Name(dogontowl, "DoubleBed") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DoubleValuedFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Discrete functionalities with exactly two values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DoubleValuedFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedFunctionality">http://elite.polito.it/ontologies/dogont.owl#DoubleValuedFunctionality</seealso>
    let DoubleValuedFunctionality =
        Prefixed_Name(dogontowl, "DoubleValuedFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DoubleValuedNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Discrete notification with exactly two values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DoubleValuedNotificationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#DoubleValuedNotificationFunctionality</seealso>
    let DoubleValuedNotificationFunctionality =
        Prefixed_Name(dogontowl, "DoubleValuedNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DoubleValuedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Discrete states with exactly two values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DoubleValuedState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DoubleValuedState">http://elite.polito.it/ontologies/dogont.owl#DoubleValuedState</seealso>
    let DoubleValuedState =
        Prefixed_Name(dogontowl, "DoubleValuedState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DownCommand">http://elite.polito.it/ontologies/dogont.owl#DownCommand</seealso>
    let DownCommand = Prefixed_Name(dogontowl, "DownCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#DownTripleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#DownTripleStateValue">http://elite.polito.it/ontologies/dogont.owl#DownTripleStateValue</seealso>
    let DownTripleStateValue =
        Prefixed_Name(dogontowl, "DownTripleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Drawer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A boxlike container in a piece of furniture; made so as to slide in and out"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Drawer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Drawer">http://elite.polito.it/ontologies/dogont.owl#Drawer</seealso>
    let Drawer = Prefixed_Name(dogontowl, "Drawer") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Dvd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Appliance thar read dvd"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dvd"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Dvd">http://elite.polito.it/ontologies/dogont.owl#Dvd</seealso>
    let Dvd = Prefixed_Name(dogontowl, "Dvd") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#EchelonCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonCommand">http://elite.polito.it/ontologies/dogont.owl#EchelonCommand</seealso>
    let EchelonCommand = Prefixed_Name(dogontowl, "EchelonCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonIlon100Gateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Gateway">http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Gateway</seealso>
    let EchelonIlon100Gateway =
        Prefixed_Name(dogontowl, "EchelonIlon100Gateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonIlon100Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Property">http://elite.polito.it/ontologies/dogont.owl#EchelonIlon100Property</seealso>
    let EchelonIlon100Property =
        Prefixed_Name(dogontowl, "EchelonIlon100Property") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonNetworkComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonNetworkComponent">http://elite.polito.it/ontologies/dogont.owl#EchelonNetworkComponent</seealso>
    let EchelonNetworkComponent =
        Prefixed_Name(dogontowl, "EchelonNetworkComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonNotification">http://elite.polito.it/ontologies/dogont.owl#EchelonNotification</seealso>
    let EchelonNotification =
        Prefixed_Name(dogontowl, "EchelonNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EchelonProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EchelonProperty">http://elite.polito.it/ontologies/dogont.owl#EchelonProperty</seealso>
    let EchelonProperty = Prefixed_Name(dogontowl, "EchelonProperty") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricPowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementNotificationFunctionality</seealso>
    let ElectricPowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ElectricPowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricPowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ElectricPowerMeasurementState</seealso>
    let ElectricPowerMeasurementState =
        Prefixed_Name(dogontowl, "ElectricPowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ElectricalCooker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electrical Cooker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElectricalCooker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricalCooker">http://elite.polito.it/ontologies/dogont.owl#ElectricalCooker</seealso>
    let ElectricalCooker = Prefixed_Name(dogontowl, "ElectricalCooker") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ElectricalOven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electrical oven"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElectricalOven"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricalOven">http://elite.polito.it/ontologies/dogont.owl#ElectricalOven</seealso>
    let ElectricalOven = Prefixed_Name(dogontowl, "ElectricalOven") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ElectricalSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Utility that provides electricity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElectricalSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricalSystem">http://elite.polito.it/ontologies/dogont.owl#ElectricalSystem</seealso>
    let ElectricalSystem = Prefixed_Name(dogontowl, "ElectricalSystem") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ElectricityMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ElectricityMeter">http://elite.polito.it/ontologies/dogont.owl#ElectricityMeter</seealso>
    let ElectricityMeter = Prefixed_Name(dogontowl, "ElectricityMeter") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#EliteComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Emulated component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EliteComponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EliteComponent">http://elite.polito.it/ontologies/dogont.owl#EliteComponent</seealso>
    let EliteComponent = Prefixed_Name(dogontowl, "EliteComponent") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#EliteGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software emulator of a network level to be used for simulating devices not available in the real world"</para>
    /// labels<para>"EliteGateway"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EliteGateway">http://elite.polito.it/ontologies/dogont.owl#EliteGateway</seealso>
    let EliteGateway = Prefixed_Name(dogontowl, "EliteGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EmittingMicrowavesNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesNotification">http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesNotification</seealso>
    let EmittingMicrowavesNotification =
        Prefixed_Name(dogontowl, "EmittingMicrowavesNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EmittingMicrowavesStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesStateValue">http://elite.polito.it/ontologies/dogont.owl#EmittingMicrowavesStateValue</seealso>
    let EmittingMicrowavesStateValue =
        Prefixed_Name(dogontowl, "EmittingMicrowavesStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnableDisableGasFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnableDisableGasFunctionality">http://elite.polito.it/ontologies/dogont.owl#EnableDisableGasFunctionality</seealso>
    let EnableDisableGasFunctionality =
        Prefixed_Name(dogontowl, "EnableDisableGasFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnableGasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnableGasCommand">http://elite.polito.it/ontologies/dogont.owl#EnableGasCommand</seealso>
    let EnableGasCommand = Prefixed_Name(dogontowl, "EnableGasCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EndProgrammedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EndProgrammedStateValue">http://elite.polito.it/ontologies/dogont.owl#EndProgrammedStateValue</seealso>
    let EndProgrammedStateValue =
        Prefixed_Name(dogontowl, "EndProgrammedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EndTimeChangedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EndTimeChangedNotification">http://elite.polito.it/ontologies/dogont.owl#EndTimeChangedNotification</seealso>
    let EndTimeChangedNotification =
        Prefixed_Name(dogontowl, "EndTimeChangedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyAndPowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeter">http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeter</seealso>
    let EnergyAndPowerMeter =
        Prefixed_Name(dogontowl, "EnergyAndPowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyAndPowerMeteringLevelControllableOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeteringLevelControllableOutput">http://elite.polito.it/ontologies/dogont.owl#EnergyAndPowerMeteringLevelControllableOutput</seealso>
    let EnergyAndPowerMeteringLevelControllableOutput =
        Prefixed_Name(dogontowl, "EnergyAndPowerMeteringLevelControllableOutput") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementFunctionality</seealso>
    let EnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "EnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementNotificationFunctionality</seealso>
    let EnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "EnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementState">http://elite.polito.it/ontologies/dogont.owl#EnergyMeasurementState</seealso>
    let EnergyMeasurementState =
        Prefixed_Name(dogontowl, "EnergyMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeter">http://elite.polito.it/ontologies/dogont.owl#EnergyMeter</seealso>
    let EnergyMeter = Prefixed_Name(dogontowl, "EnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EnergyMeteringPowerOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EnergyMeteringPowerOutlet">http://elite.polito.it/ontologies/dogont.owl#EnergyMeteringPowerOutlet</seealso>
    let EnergyMeteringPowerOutlet =
        Prefixed_Name(dogontowl, "EnergyMeteringPowerOutlet") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Entertainment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A diversion that holds the attention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entertainment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Entertainment">http://elite.polito.it/ontologies/dogont.owl#Entertainment</seealso>
    let Entertainment = Prefixed_Name(dogontowl, "Entertainment") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Entrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Entrance">http://elite.polito.it/ontologies/dogont.owl#Entrance</seealso>
    let Entrance = Prefixed_Name(dogontowl, "Entrance") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EventNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EventNotification">http://elite.polito.it/ontologies/dogont.owl#EventNotification</seealso>
    let EventNotification =
        Prefixed_Name(dogontowl, "EventNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EventNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EventNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#EventNotificationFunctionality</seealso>
    let EventNotificationFunctionality =
        Prefixed_Name(dogontowl, "EventNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EventsAndAlertsNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsNotificationFunctionality</seealso>
    let EventsAndAlertsNotificationFunctionality =
        Prefixed_Name(dogontowl, "EventsAndAlertsNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#EventsAndAlertsQueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsQueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#EventsAndAlertsQueryFunctionality</seealso>
    let EventsAndAlertsQueryFunctionality =
        Prefixed_Name(dogontowl, "EventsAndAlertsQueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FailureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FailureStateValue">http://elite.polito.it/ontologies/dogont.owl#FailureStateValue</seealso>
    let FailureStateValue =
        Prefixed_Name(dogontowl, "FailureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Fan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device for creating a current of air"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Fan">http://elite.polito.it/ontologies/dogont.owl#Fan</seealso>
    let Fan = Prefixed_Name(dogontowl, "Fan") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FanControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models the capability of controlling the speed of a cooling/heating fan. Derives from ZigBee HA"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FanControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#FanControlFunctionality</seealso>
    let FanControlFunctionality =
        Prefixed_Name(dogontowl, "FanControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FaultState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FaultState">http://elite.polito.it/ontologies/dogont.owl#FaultState</seealso>
    let FaultState = Prefixed_Name(dogontowl, "FaultState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Appliance that send text and document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fax"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Fax">http://elite.polito.it/ontologies/dogont.owl#Fax</seealso>
    let Fax = Prefixed_Name(dogontowl, "Fax") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Fence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A barrier that serves to enclose an area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Fence">http://elite.polito.it/ontologies/dogont.owl#Fence</seealso>
    let Fence = Prefixed_Name(dogontowl, "Fence") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#FenceOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An opening in a Fence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FenceOpening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FenceOpening">http://elite.polito.it/ontologies/dogont.owl#FenceOpening</seealso>
    let FenceOpening = Prefixed_Name(dogontowl, "FenceOpening") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FireHeatCoolNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FireHeatCoolNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#FireHeatCoolNotificationFunctionality</seealso>
    let FireHeatCoolNotificationFunctionality =
        Prefixed_Name(dogontowl, "FireHeatCoolNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FireSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System that detects the presence of fire"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FireSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FireSystem">http://elite.polito.it/ontologies/dogont.owl#FireSystem</seealso>
    let FireSystem = Prefixed_Name(dogontowl, "FireSystem") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#FireUpStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FireUpStateValue">http://elite.polito.it/ontologies/dogont.owl#FireUpStateValue</seealso>
    let FireUpStateValue = Prefixed_Name(dogontowl, "FireUpStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FiringUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FiringUpNotification">http://elite.polito.it/ontologies/dogont.owl#FiringUpNotification</seealso>
    let FiringUpNotification =
        Prefixed_Name(dogontowl, "FiringUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlashingLamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lamp that emits light in sudden short or intermittent bursts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FlashingLamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlashingLamp">http://elite.polito.it/ontologies/dogont.owl#FlashingLamp</seealso>
    let FlashingLamp = Prefixed_Name(dogontowl, "FlashingLamp") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Flat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Flat">http://elite.polito.it/ontologies/dogont.owl#Flat</seealso>
    let Flat = Prefixed_Name(dogontowl, "Flat") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#FloodSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that detects the presence of flood"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FloodSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FloodSensor">http://elite.polito.it/ontologies/dogont.owl#FloodSensor</seealso>
    let FloodSensor = Prefixed_Name(dogontowl, "FloodSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#FloodSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System that detects the presence of flood"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FloodSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FloodSystem">http://elite.polito.it/ontologies/dogont.owl#FloodSystem</seealso>
    let FloodSystem = Prefixed_Name(dogontowl, "FloodSystem") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The inside lower horizontal surface of a room"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Floor">http://elite.polito.it/ontologies/dogont.owl#Floor</seealso>
    let Floor = Prefixed_Name(dogontowl, "Floor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementFunctionality</seealso>
    let FlowMeasurementFunctionality =
        Prefixed_Name(dogontowl, "FlowMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#FlowMeasurementNotificationFunctionality</seealso>
    let FlowMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "FlowMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowRateMeasurementMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementMNotification">http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementMNotification</seealso>
    let FlowRateMeasurementMNotification =
        Prefixed_Name(dogontowl, "FlowRateMeasurementMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowRateMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#FlowRateMeasurementNotification</seealso>
    let FlowRateMeasurementNotification =
        Prefixed_Name(dogontowl, "FlowRateMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowRateState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowRateState">http://elite.polito.it/ontologies/dogont.owl#FlowRateState</seealso>
    let FlowRateState = Prefixed_Name(dogontowl, "FlowRateState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowRateStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowRateStateValue">http://elite.polito.it/ontologies/dogont.owl#FlowRateStateValue</seealso>
    let FlowRateStateValue =
        Prefixed_Name(dogontowl, "FlowRateStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FlowSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FlowSensor">http://elite.polito.it/ontologies/dogont.owl#FlowSensor</seealso>
    let FlowSensor = Prefixed_Name(dogontowl, "FlowSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ForwardCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ForwardCommand">http://elite.polito.it/ontologies/dogont.owl#ForwardCommand</seealso>
    let ForwardCommand = Prefixed_Name(dogontowl, "ForwardCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ForwardNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ForwardNotification">http://elite.polito.it/ontologies/dogont.owl#ForwardNotification</seealso>
    let ForwardNotification =
        Prefixed_Name(dogontowl, "ForwardNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ForwardStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ForwardStateValue">http://elite.polito.it/ontologies/dogont.owl#ForwardStateValue</seealso>
    let ForwardStateValue =
        Prefixed_Name(dogontowl, "ForwardStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FreeStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FreeStateValue">http://elite.polito.it/ontologies/dogont.owl#FreeStateValue</seealso>
    let FreeStateValue = Prefixed_Name(dogontowl, "FreeStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FreezingApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FreezingApplianceState">http://elite.polito.it/ontologies/dogont.owl#FreezingApplianceState</seealso>
    let FreezingApplianceState =
        Prefixed_Name(dogontowl, "FreezingApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementFunctionality</seealso>
    let FrequencyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "FrequencyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotification</seealso>
    let FrequencyMeasurementNotification =
        Prefixed_Name(dogontowl, "FrequencyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementNotificationFunctionality</seealso>
    let FrequencyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "FrequencyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementState">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeasurementState</seealso>
    let FrequencyMeasurementState =
        Prefixed_Name(dogontowl, "FrequencyMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyMeter">http://elite.polito.it/ontologies/dogont.owl#FrequencyMeter</seealso>
    let FrequencyMeter = Prefixed_Name(dogontowl, "FrequencyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#FrequencyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#FrequencyStateValue">http://elite.polito.it/ontologies/dogont.owl#FrequencyStateValue</seealso>
    let FrequencyStateValue =
        Prefixed_Name(dogontowl, "FrequencyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Fridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A refrigerator in which the coolant is pumped around by an electric motor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fridge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Fridge">http://elite.polito.it/ontologies/dogont.owl#Fridge</seealso>
    let Fridge = Prefixed_Name(dogontowl, "Fridge") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Functionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Capability of a controllable building thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Functionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Functionality">http://elite.polito.it/ontologies/dogont.owl#Functionality</seealso>
    let Functionality = Prefixed_Name(dogontowl, "Functionality") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Furniture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Furnishings that make a room or other area ready for occupancy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Furniture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Furniture">http://elite.polito.it/ontologies/dogont.owl#Furniture</seealso>
    let Furniture = Prefixed_Name(dogontowl, "Furniture") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Garage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The garage of the buinding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Garage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Garage">http://elite.polito.it/ontologies/dogont.owl#Garage</seealso>
    let Garage = Prefixed_Name(dogontowl, "Garage") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Garden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The garden of the building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Garden"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Garden">http://elite.polito.it/ontologies/dogont.owl#Garden</seealso>
    let Garden = Prefixed_Name(dogontowl, "Garden") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#GasCooker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Gas Cooker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GasCooker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasCooker">http://elite.polito.it/ontologies/dogont.owl#GasCooker</seealso>
    let GasCooker = Prefixed_Name(dogontowl, "GasCooker") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#GasHeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Heater that combusts gas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GasHeater"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasHeater">http://elite.polito.it/ontologies/dogont.owl#GasHeater</seealso>
    let GasHeater = Prefixed_Name(dogontowl, "GasHeater") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasM3MeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasM3MeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#GasM3MeasurementNotification</seealso>
    let GasM3MeasurementNotification =
        Prefixed_Name(dogontowl, "GasM3MeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#GasMeasurementFunctionality</seealso>
    let GasMeasurementFunctionality =
        Prefixed_Name(dogontowl, "GasMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#GasMeasurementNotificationFunctionality</seealso>
    let GasMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "GasMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasMeasurementState">http://elite.polito.it/ontologies/dogont.owl#GasMeasurementState</seealso>
    let GasMeasurementState =
        Prefixed_Name(dogontowl, "GasMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GasMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasMeter">http://elite.polito.it/ontologies/dogont.owl#GasMeter</seealso>
    let GasMeter = Prefixed_Name(dogontowl, "GasMeter") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#GasSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that detects the presence of gas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GasSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasSensor">http://elite.polito.it/ontologies/dogont.owl#GasSensor</seealso>
    let GasSensor = Prefixed_Name(dogontowl, "GasSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#GasStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasStateValue">http://elite.polito.it/ontologies/dogont.owl#GasStateValue</seealso>
    let GasStateValue = Prefixed_Name(dogontowl, "GasStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#GasSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System that detects the presence of gas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GasSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasSystem">http://elite.polito.it/ontologies/dogont.owl#GasSystem</seealso>
    let GasSystem = Prefixed_Name(dogontowl, "GasSystem") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#GasoilHeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Heater that combusts gasoil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GasoilHeater"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GasoilHeater">http://elite.polito.it/ontologies/dogont.owl#GasoilHeater</seealso>
    let GasoilHeater = Prefixed_Name(dogontowl, "GasoilHeater") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Gate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A door-like movable barrier in a fence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Gate">http://elite.polito.it/ontologies/dogont.owl#Gate</seealso>
    let Gate = Prefixed_Name(dogontowl, "Gate") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#GateActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mechanism that allow automatic opening and closing about gate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GateActuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GateActuator">http://elite.polito.it/ontologies/dogont.owl#GateActuator</seealso>
    let GateActuator = Prefixed_Name(dogontowl, "GateActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GenericApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GenericApplianceState">http://elite.polito.it/ontologies/dogont.owl#GenericApplianceState</seealso>
    let GenericApplianceState =
        Prefixed_Name(dogontowl, "GenericApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseActiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActiveEnergyCommand</seealso>
    let Get1PhaseActiveEnergyCommand =
        Prefixed_Name(dogontowl, "Get1PhaseActiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseActivePowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActivePowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseActivePowerCommand</seealso>
    let Get1PhaseActivePowerCommand =
        Prefixed_Name(dogontowl, "Get1PhaseActivePowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseApparentPowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseApparentPowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseApparentPowerCommand</seealso>
    let Get1PhaseApparentPowerCommand =
        Prefixed_Name(dogontowl, "Get1PhaseApparentPowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseCurrentCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseCurrentCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseCurrentCommand</seealso>
    let Get1PhaseCurrentCommand =
        Prefixed_Name(dogontowl, "Get1PhaseCurrentCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseReactiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactiveEnergyCommand</seealso>
    let Get1PhaseReactiveEnergyCommand =
        Prefixed_Name(dogontowl, "Get1PhaseReactiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseReactivePowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactivePowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseReactivePowerCommand</seealso>
    let Get1PhaseReactivePowerCommand =
        Prefixed_Name(dogontowl, "Get1PhaseReactivePowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get1PhaseVoltageCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get1PhaseVoltageCommand">http://elite.polito.it/ontologies/dogont.owl#Get1PhaseVoltageCommand</seealso>
    let Get1PhaseVoltageCommand =
        Prefixed_Name(dogontowl, "Get1PhaseVoltageCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseActiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActiveEnergyCommand</seealso>
    let Get3PhaseActiveEnergyCommand =
        Prefixed_Name(dogontowl, "Get3PhaseActiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseActivePowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActivePowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseActivePowerCommand</seealso>
    let Get3PhaseActivePowerCommand =
        Prefixed_Name(dogontowl, "Get3PhaseActivePowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseApparentPowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseApparentPowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseApparentPowerCommand</seealso>
    let Get3PhaseApparentPowerCommand =
        Prefixed_Name(dogontowl, "Get3PhaseApparentPowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseCurrentCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseCurrentCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseCurrentCommand</seealso>
    let Get3PhaseCurrentCommand =
        Prefixed_Name(dogontowl, "Get3PhaseCurrentCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseLLVoltageCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLLVoltageCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLLVoltageCommand</seealso>
    let Get3PhaseLLVoltageCommand =
        Prefixed_Name(dogontowl, "Get3PhaseLLVoltageCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseLNVoltageCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLNVoltageCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseLNVoltageCommand</seealso>
    let Get3PhaseLNVoltageCommand =
        Prefixed_Name(dogontowl, "Get3PhaseLNVoltageCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseReactiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactiveEnergyCommand</seealso>
    let Get3PhaseReactiveEnergyCommand =
        Prefixed_Name(dogontowl, "Get3PhaseReactiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Get3PhaseReactivePowerCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactivePowerCommand">http://elite.polito.it/ontologies/dogont.owl#Get3PhaseReactivePowerCommand</seealso>
    let Get3PhaseReactivePowerCommand =
        Prefixed_Name(dogontowl, "Get3PhaseReactivePowerCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetClimateScheduleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetClimateScheduleCommand">http://elite.polito.it/ontologies/dogont.owl#GetClimateScheduleCommand</seealso>
    let GetClimateScheduleCommand =
        Prefixed_Name(dogontowl, "GetClimateScheduleCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetCo2ConcentrationCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetCo2ConcentrationCommand">http://elite.polito.it/ontologies/dogont.owl#GetCo2ConcentrationCommand</seealso>
    let GetCo2ConcentrationCommand =
        Prefixed_Name(dogontowl, "GetCo2ConcentrationCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetColdWaterM3Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetColdWaterM3Command">http://elite.polito.it/ontologies/dogont.owl#GetColdWaterM3Command</seealso>
    let GetColdWaterM3Command =
        Prefixed_Name(dogontowl, "GetColdWaterM3Command") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetCommand">http://elite.polito.it/ontologies/dogont.owl#GetCommand</seealso>
    let GetCommand = Prefixed_Name(dogontowl, "GetCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetConfigurationCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetConfigurationCommand">http://elite.polito.it/ontologies/dogont.owl#GetConfigurationCommand</seealso>
    let GetConfigurationCommand =
        Prefixed_Name(dogontowl, "GetConfigurationCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetConsumedM3Gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetConsumedM3Gas">http://elite.polito.it/ontologies/dogont.owl#GetConsumedM3Gas</seealso>
    let GetConsumedM3Gas = Prefixed_Name(dogontowl, "GetConsumedM3Gas") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetEndTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetEndTimeCommand">http://elite.polito.it/ontologies/dogont.owl#GetEndTimeCommand</seealso>
    let GetEndTimeCommand =
        Prefixed_Name(dogontowl, "GetEndTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetEventsAndAlertsCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetEventsAndAlertsCommand">http://elite.polito.it/ontologies/dogont.owl#GetEventsAndAlertsCommand</seealso>
    let GetEventsAndAlertsCommand =
        Prefixed_Name(dogontowl, "GetEventsAndAlertsCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetFlowRateCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetFlowRateCommand">http://elite.polito.it/ontologies/dogont.owl#GetFlowRateCommand</seealso>
    let GetFlowRateCommand =
        Prefixed_Name(dogontowl, "GetFlowRateCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetFlowRateMCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetFlowRateMCommand">http://elite.polito.it/ontologies/dogont.owl#GetFlowRateMCommand</seealso>
    let GetFlowRateMCommand =
        Prefixed_Name(dogontowl, "GetFlowRateMCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetFrequencyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetFrequencyCommand">http://elite.polito.it/ontologies/dogont.owl#GetFrequencyCommand</seealso>
    let GetFrequencyCommand =
        Prefixed_Name(dogontowl, "GetFrequencyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetHeatingEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetHeatingEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetHeatingEnergyCommand</seealso>
    let GetHeatingEnergyCommand =
        Prefixed_Name(dogontowl, "GetHeatingEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetHotWaterM3Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetHotWaterM3Command">http://elite.polito.it/ontologies/dogont.owl#GetHotWaterM3Command</seealso>
    let GetHotWaterM3Command =
        Prefixed_Name(dogontowl, "GetHotWaterM3Command") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetLuminanceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetLuminanceCommand">http://elite.polito.it/ontologies/dogont.owl#GetLuminanceCommand</seealso>
    let GetLuminanceCommand =
        Prefixed_Name(dogontowl, "GetLuminanceCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetMultiTariff1PhaseActiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseActiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseActiveEnergyCommand</seealso>
    let GetMultiTariff1PhaseActiveEnergyCommand =
        Prefixed_Name(dogontowl, "GetMultiTariff1PhaseActiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetMultiTariff1PhaseReactiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseReactiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff1PhaseReactiveEnergyCommand</seealso>
    let GetMultiTariff1PhaseReactiveEnergyCommand =
        Prefixed_Name(dogontowl, "GetMultiTariff1PhaseReactiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetMultiTariff3PhaseActiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseActiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseActiveEnergyCommand</seealso>
    let GetMultiTariff3PhaseActiveEnergyCommand =
        Prefixed_Name(dogontowl, "GetMultiTariff3PhaseActiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetMultiTariff3PhaseReactiveEnergyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseReactiveEnergyCommand">http://elite.polito.it/ontologies/dogont.owl#GetMultiTariff3PhaseReactiveEnergyCommand</seealso>
    let GetMultiTariff3PhaseReactiveEnergyCommand =
        Prefixed_Name(dogontowl, "GetMultiTariff3PhaseReactiveEnergyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetOccupancyCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the command for getting the occupancy state of a given room/environment"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetOccupancyCommand">http://elite.polito.it/ontologies/dogont.owl#GetOccupancyCommand</seealso>
    let GetOccupancyCommand =
        Prefixed_Name(dogontowl, "GetOccupancyCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetPowerFactorCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetPowerFactorCommand">http://elite.polito.it/ontologies/dogont.owl#GetPowerFactorCommand</seealso>
    let GetPowerFactorCommand =
        Prefixed_Name(dogontowl, "GetPowerFactorCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetPressureCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetPressureCommand">http://elite.polito.it/ontologies/dogont.owl#GetPressureCommand</seealso>
    let GetPressureCommand =
        Prefixed_Name(dogontowl, "GetPressureCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetPressureMCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetPressureMCommand">http://elite.polito.it/ontologies/dogont.owl#GetPressureMCommand</seealso>
    let GetPressureMCommand =
        Prefixed_Name(dogontowl, "GetPressureMCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetRelativeHumidityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityCommand">http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityCommand</seealso>
    let GetRelativeHumidityCommand =
        Prefixed_Name(dogontowl, "GetRelativeHumidityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetRelativeHumidityMCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityMCommand">http://elite.polito.it/ontologies/dogont.owl#GetRelativeHumidityMCommand</seealso>
    let GetRelativeHumidityMCommand =
        Prefixed_Name(dogontowl, "GetRelativeHumidityMCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetRemainingTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetRemainingTimeCommand">http://elite.polito.it/ontologies/dogont.owl#GetRemainingTimeCommand</seealso>
    let GetRemainingTimeCommand =
        Prefixed_Name(dogontowl, "GetRemainingTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetStartTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetStartTimeCommand">http://elite.polito.it/ontologies/dogont.owl#GetStartTimeCommand</seealso>
    let GetStartTimeCommand =
        Prefixed_Name(dogontowl, "GetStartTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetTemperatureCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetTemperatureCommand">http://elite.polito.it/ontologies/dogont.owl#GetTemperatureCommand</seealso>
    let GetTemperatureCommand =
        Prefixed_Name(dogontowl, "GetTemperatureCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GetTemperatureMCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GetTemperatureMCommand">http://elite.polito.it/ontologies/dogont.owl#GetTemperatureMCommand</seealso>
    let GetTemperatureMCommand =
        Prefixed_Name(dogontowl, "GetTemperatureMCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GoToTrackCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GoToTrackCommand">http://elite.polito.it/ontologies/dogont.owl#GoToTrackCommand</seealso>
    let GoToTrackCommand = Prefixed_Name(dogontowl, "GoToTrackCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GrabPictureCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GrabPictureCommand">http://elite.polito.it/ontologies/dogont.owl#GrabPictureCommand</seealso>
    let GrabPictureCommand =
        Prefixed_Name(dogontowl, "GrabPictureCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GreenStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GreenStateValue">http://elite.polito.it/ontologies/dogont.owl#GreenStateValue</seealso>
    let GreenStateValue = Prefixed_Name(dogontowl, "GreenStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GroupFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Derives from the general cluster functionalities defined in ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GroupFunctionality">http://elite.polito.it/ontologies/dogont.owl#GroupFunctionality</seealso>
    let GroupFunctionality =
        Prefixed_Name(dogontowl, "GroupFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#GroupNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Derives from the general cluster functionalities defined in ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#GroupNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#GroupNotificationFunctionality</seealso>
    let GroupNotificationFunctionality =
        Prefixed_Name(dogontowl, "GroupNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HVACSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Heating Ventilating and Air Conditioning system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HVACSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HVACSystem">http://elite.polito.it/ontologies/dogont.owl#HVACSystem</seealso>
    let HVACSystem = Prefixed_Name(dogontowl, "HVACSystem") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HeatCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatCommand">http://elite.polito.it/ontologies/dogont.owl#HeatCommand</seealso>
    let HeatCommand = Prefixed_Name(dogontowl, "HeatCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HeatNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatNotification">http://elite.polito.it/ontologies/dogont.owl#HeatNotification</seealso>
    let HeatNotification = Prefixed_Name(dogontowl, "HeatNotification") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Heater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that heats water or supplies warmth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heater"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Heater">http://elite.polito.it/ontologies/dogont.owl#Heater</seealso>
    let Heater = Prefixed_Name(dogontowl, "Heater") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HeaterState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeaterState">http://elite.polito.it/ontologies/dogont.owl#HeaterState</seealso>
    let HeaterState = Prefixed_Name(dogontowl, "HeaterState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingAndCoolingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Heating and Cooling Unit device can heat or cool a space in a house. It is not mandatory to provide both functionalities. It may be an indoor air handler. Derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnit">http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnit</seealso>
    let HeatingAndCoolingUnit =
        Prefixed_Name(dogontowl, "HeatingAndCoolingUnit") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingAndCoolingUnitState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnitState">http://elite.polito.it/ontologies/dogont.owl#HeatingAndCoolingUnitState</seealso>
    let HeatingAndCoolingUnitState =
        Prefixed_Name(dogontowl, "HeatingAndCoolingUnitState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingApplianceState">http://elite.polito.it/ontologies/dogont.owl#HeatingApplianceState</seealso>
    let HeatingApplianceState =
        Prefixed_Name(dogontowl, "HeatingApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingCycleNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingCycleNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#HeatingCycleNotificationFunctionality</seealso>
    let HeatingCycleNotificationFunctionality =
        Prefixed_Name(dogontowl, "HeatingCycleNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementFunctionality</seealso>
    let HeatingEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "HeatingEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotification</seealso>
    let HeatingEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "HeatingEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementNotificationFunctionality</seealso>
    let HeatingEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "HeatingEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementState">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeasurementState</seealso>
    let HeatingEnergyMeasurementState =
        Prefixed_Name(dogontowl, "HeatingEnergyMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyMeter</seealso>
    let HeatingEnergyMeter =
        Prefixed_Name(dogontowl, "HeatingEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#HeatingEnergyStateValue</seealso>
    let HeatingEnergyStateValue =
        Prefixed_Name(dogontowl, "HeatingEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingStateValue">http://elite.polito.it/ontologies/dogont.owl#HeatingStateValue</seealso>
    let HeatingStateValue =
        Prefixed_Name(dogontowl, "HeatingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HeatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Utility to warm a building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HeatingSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HeatingSystem">http://elite.polito.it/ontologies/dogont.owl#HeatingSystem</seealso>
    let HeatingSystem = Prefixed_Name(dogontowl, "HeatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HiFi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Equipment for the reproduction of sound with high fidelity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HiFi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HiFi">http://elite.polito.it/ontologies/dogont.owl#HiFi</seealso>
    let HiFi = Prefixed_Name(dogontowl, "HiFi") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Horizontal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The horizontal architectural component of a building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Horizontal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Horizontal">http://elite.polito.it/ontologies/dogont.owl#Horizontal</seealso>
    let Horizontal = Prefixed_Name(dogontowl, "Horizontal") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HotWaterM3MeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HotWaterM3MeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#HotWaterM3MeasurementNotification</seealso>
    let HotWaterM3MeasurementNotification =
        Prefixed_Name(dogontowl, "HotWaterM3MeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Hotplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A portable electric appliance for heating or cooking or keeping food warm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hotplate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Hotplate">http://elite.polito.it/ontologies/dogont.owl#Hotplate</seealso>
    let Hotplate = Prefixed_Name(dogontowl, "Hotplate") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HousePlants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All plants of the house, e.g. Electrical system, Hydraulic system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HousePlants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HousePlants">http://elite.polito.it/ontologies/dogont.owl#HousePlants</seealso>
    let HousePlants = Prefixed_Name(dogontowl, "HousePlants") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HueBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueBridge">http://elite.polito.it/ontologies/dogont.owl#HueBridge</seealso>
    let HueBridge = Prefixed_Name(dogontowl, "HueBridge") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HueComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueComponent">http://elite.polito.it/ontologies/dogont.owl#HueComponent</seealso>
    let HueComponent = Prefixed_Name(dogontowl, "HueComponent") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HueManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueManager">http://elite.polito.it/ontologies/dogont.owl#HueManager</seealso>
    let HueManager = Prefixed_Name(dogontowl, "HueManager") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HueNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueNotification">http://elite.polito.it/ontologies/dogont.owl#HueNotification</seealso>
    let HueNotification = Prefixed_Name(dogontowl, "HueNotification") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#HueStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HueStateValue">http://elite.polito.it/ontologies/dogont.owl#HueStateValue</seealso>
    let HueStateValue = Prefixed_Name(dogontowl, "HueStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The capability of measuring the humidity of a room"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementFunctionality</seealso>
    let HumidityMeasurementFunctionality =
        Prefixed_Name(dogontowl, "HumidityMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementMNotification">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementMNotification</seealso>
    let HumidityMeasurementMNotification =
        Prefixed_Name(dogontowl, "HumidityMeasurementMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotification</seealso>
    let HumidityMeasurementNotification =
        Prefixed_Name(dogontowl, "HumidityMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The notification for requesting humidity measurment..."</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementNotificationFunctionality</seealso>
    let HumidityMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "HumidityMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementState">http://elite.polito.it/ontologies/dogont.owl#HumidityMeasurementState</seealso>
    let HumidityMeasurementState =
        Prefixed_Name(dogontowl, "HumidityMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumiditySensor">http://elite.polito.it/ontologies/dogont.owl#HumiditySensor</seealso>
    let HumiditySensor = Prefixed_Name(dogontowl, "HumiditySensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#HumidityStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#HumidityStateValue">http://elite.polito.it/ontologies/dogont.owl#HumidityStateValue</seealso>
    let HumidityStateValue =
        Prefixed_Name(dogontowl, "HumidityStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IPAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The IP address of the gateway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IPAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IPAddress">http://elite.polito.it/ontologies/dogont.owl#IPAddress</seealso>
    let IPAddress = Prefixed_Name(dogontowl, "IPAddress") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdentificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Derives from the general cluster functionalities defined in ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdentificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#IdentificationFunctionality</seealso>
    let IdentificationFunctionality =
        Prefixed_Name(dogontowl, "IdentificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdentificationNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Derives from the general cluster functionalities defined in ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdentificationNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#IdentificationNotificationFunctionality</seealso>
    let IdentificationNotificationFunctionality =
        Prefixed_Name(dogontowl, "IdentificationNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdentifyNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdentifyNotification">http://elite.polito.it/ontologies/dogont.owl#IdentifyNotification</seealso>
    let IdentifyNotification =
        Prefixed_Name(dogontowl, "IdentifyNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IdleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdleNotification">http://elite.polito.it/ontologies/dogont.owl#IdleNotification</seealso>
    let IdleNotification = Prefixed_Name(dogontowl, "IdleNotification") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#IdleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IdleStateValue">http://elite.polito.it/ontologies/dogont.owl#IdleStateValue</seealso>
    let IdleStateValue = Prefixed_Name(dogontowl, "IdleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseColorCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseColorCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseColorCommand</seealso>
    let IncreaseColorCommand =
        Prefixed_Name(dogontowl, "IncreaseColorCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseContrastCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseContrastCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseContrastCommand</seealso>
    let IncreaseContrastCommand =
        Prefixed_Name(dogontowl, "IncreaseContrastCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseLuminosityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseLuminosityCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseLuminosityCommand</seealso>
    let IncreaseLuminosityCommand =
        Prefixed_Name(dogontowl, "IncreaseLuminosityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseQualityCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseQualityCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseQualityCommand</seealso>
    let IncreaseQualityCommand =
        Prefixed_Name(dogontowl, "IncreaseQualityCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IncreaseVolumeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IncreaseVolumeCommand">http://elite.polito.it/ontologies/dogont.owl#IncreaseVolumeCommand</seealso>
    let IncreaseVolumeCommand =
        Prefixed_Name(dogontowl, "IncreaseVolumeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#InfraredSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that detects the presence of a living entity in the sensor's range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InfraredSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#InfraredSensor">http://elite.polito.it/ontologies/dogont.owl#InfraredSensor</seealso>
    let InfraredSensor = Prefixed_Name(dogontowl, "InfraredSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#InstallApplianceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#InstallApplianceCommand">http://elite.polito.it/ontologies/dogont.owl#InstallApplianceCommand</seealso>
    let InstallApplianceCommand =
        Prefixed_Name(dogontowl, "InstallApplianceCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Interphone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A telephonic intercommunication system linking different rooms in a building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interphone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Interphone">http://elite.polito.it/ontologies/dogont.owl#Interphone</seealso>
    let Interphone = Prefixed_Name(dogontowl, "Interphone") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#IsPresentNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#IsPresentNotification">http://elite.polito.it/ontologies/dogont.owl#IsPresentNotification</seealso>
    let IsPresentNotification =
        Prefixed_Name(dogontowl, "IsPresentNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Jacuzzi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large whirlpool bathtub with underwater jets that massage the body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Jacuzzi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Jacuzzi">http://elite.polito.it/ontologies/dogont.owl#Jacuzzi</seealso>
    let Jacuzzi = Prefixed_Name(dogontowl, "Jacuzzi") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#JoinGroupNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#JoinGroupNotification">http://elite.polito.it/ontologies/dogont.owl#JoinGroupNotification</seealso>
    let JoinGroupNotification =
        Prefixed_Name(dogontowl, "JoinGroupNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KNXNetIPComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KNXNetIPComponent">http://elite.polito.it/ontologies/dogont.owl#KNXNetIPComponent</seealso>
    let KNXNetIPComponent =
        Prefixed_Name(dogontowl, "KNXNetIPComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KNXNetIPGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KNXNetIPGateway">http://elite.polito.it/ontologies/dogont.owl#KNXNetIPGateway</seealso>
    let KNXNetIPGateway = Prefixed_Name(dogontowl, "KNXNetIPGateway") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Kitchen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room equipped for preparing meals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Kitchen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Kitchen">http://elite.polito.it/ontologies/dogont.owl#Kitchen</seealso>
    let Kitchen = Prefixed_Name(dogontowl, "Kitchen") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Knob</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A round handle used to adjust continuous amplitude, e.g. volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Knob"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Knob">http://elite.polito.it/ontologies/dogont.owl#Knob</seealso>
    let Knob = Prefixed_Name(dogontowl, "Knob") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#KonnexCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexCommand">http://elite.polito.it/ontologies/dogont.owl#KonnexCommand</seealso>
    let KonnexCommand = Prefixed_Name(dogontowl, "KonnexCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#KonnexComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Components manufactured by Konnex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"KonnexComponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexComponent">http://elite.polito.it/ontologies/dogont.owl#KonnexComponent</seealso>
    let KonnexComponent = Prefixed_Name(dogontowl, "KonnexComponent") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#KonnexGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Konnex Gateway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"KonnexGateway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexGateway">http://elite.polito.it/ontologies/dogont.owl#KonnexGateway</seealso>
    let KonnexGateway = Prefixed_Name(dogontowl, "KonnexGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KonnexNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexNotification">http://elite.polito.it/ontologies/dogont.owl#KonnexNotification</seealso>
    let KonnexNotification =
        Prefixed_Name(dogontowl, "KonnexNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#KonnexProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#KonnexProperty">http://elite.polito.it/ontologies/dogont.owl#KonnexProperty</seealso>
    let KonnexProperty = Prefixed_Name(dogontowl, "KonnexProperty") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Lamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artificial source of visible illumination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Lamp">http://elite.polito.it/ontologies/dogont.owl#Lamp</seealso>
    let Lamp = Prefixed_Name(dogontowl, "Lamp") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#LampHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LampHolder">http://elite.polito.it/ontologies/dogont.owl#LampHolder</seealso>
    let LampHolder = Prefixed_Name(dogontowl, "LampHolder") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LeaveGroupNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LeaveGroupNotification">http://elite.polito.it/ontologies/dogont.owl#LeaveGroupNotification</seealso>
    let LeaveGroupNotification =
        Prefixed_Name(dogontowl, "LeaveGroupNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Level control functionality, used for allowing devices to be controlled in a continuous manner, derives from ZigBee Home Automation specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#LevelControlFunctionality</seealso>
    let LevelControlFunctionality =
        Prefixed_Name(dogontowl, "LevelControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControlNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControlNotification">http://elite.polito.it/ontologies/dogont.owl#LevelControlNotification</seealso>
    let LevelControlNotification =
        Prefixed_Name(dogontowl, "LevelControlNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControlNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControlNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#LevelControlNotificationFunctionality</seealso>
    let LevelControlNotificationFunctionality =
        Prefixed_Name(dogontowl, "LevelControlNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControlSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Level control switch, derives from the ZigBee Home Automation specification"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControlSwitch">http://elite.polito.it/ontologies/dogont.owl#LevelControlSwitch</seealso>
    let LevelControlSwitch =
        Prefixed_Name(dogontowl, "LevelControlSwitch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelControllableOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Output device whose output level can be controlled continuously, by means of a level-control command (notification), derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelControllableOutput">http://elite.polito.it/ontologies/dogont.owl#LevelControllableOutput</seealso>
    let LevelControllableOutput =
        Prefixed_Name(dogontowl, "LevelControllableOutput") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#LevelNotificationFunctionality</seealso>
    let LevelNotificationFunctionality =
        Prefixed_Name(dogontowl, "LevelNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelState">http://elite.polito.it/ontologies/dogont.owl#LevelState</seealso>
    let LevelState = Prefixed_Name(dogontowl, "LevelState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#LevelStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelStateValue">http://elite.polito.it/ontologies/dogont.owl#LevelStateValue</seealso>
    let LevelStateValue = Prefixed_Name(dogontowl, "LevelStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelStepDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelStepDownNotification">http://elite.polito.it/ontologies/dogont.owl#LevelStepDownNotification</seealso>
    let LevelStepDownNotification =
        Prefixed_Name(dogontowl, "LevelStepDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LevelStepUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LevelStepUpNotification">http://elite.polito.it/ontologies/dogont.owl#LevelStepUpNotification</seealso>
    let LevelStepUpNotification =
        Prefixed_Name(dogontowl, "LevelStepUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LightIntensityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models the state of the object that illuminates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LightIntensityState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LightIntensityState">http://elite.polito.it/ontologies/dogont.owl#LightIntensityState</seealso>
    let LightIntensityState =
        Prefixed_Name(dogontowl, "LightIntensityState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LightRegulationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionalities for the regulation of ligth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LightRegulationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LightRegulationFunctionality">http://elite.polito.it/ontologies/dogont.owl#LightRegulationFunctionality</seealso>
    let LightRegulationFunctionality =
        Prefixed_Name(dogontowl, "LightRegulationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LightSensingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The capability of sensing the luminance of the environment in which a device is located accepts only the get command, with 1 parameter, i.e. the luminance value. Derives from ZigBee specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LightSensingFunctionality">http://elite.polito.it/ontologies/dogont.owl#LightSensingFunctionality</seealso>
    let LightSensingFunctionality =
        Prefixed_Name(dogontowl, "LightSensingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LightSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Light Sensor device reports the illuminance of an area"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LightSensor">http://elite.polito.it/ontologies/dogont.owl#LightSensor</seealso>
    let LightSensor = Prefixed_Name(dogontowl, "LightSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Lighting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System that provides artificial light"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lighting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Lighting">http://elite.polito.it/ontologies/dogont.owl#Lighting</seealso>
    let Lighting = Prefixed_Name(dogontowl, "Lighting") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#LivingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room where people can sit and talk and relax"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LivingRoom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LivingRoom">http://elite.polito.it/ontologies/dogont.owl#LivingRoom</seealso>
    let LivingRoom = Prefixed_Name(dogontowl, "LivingRoom") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Lobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A large entrance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lobby"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Lobby">http://elite.polito.it/ontologies/dogont.owl#Lobby</seealso>
    let Lobby = Prefixed_Name(dogontowl, "Lobby") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LoweringStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LoweringStateValue">http://elite.polito.it/ontologies/dogont.owl#LoweringStateValue</seealso>
    let LoweringStateValue =
        Prefixed_Name(dogontowl, "LoweringStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LuminosityMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LuminosityMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#LuminosityMeasurementNotification</seealso>
    let LuminosityMeasurementNotification =
        Prefixed_Name(dogontowl, "LuminosityMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#LuminosityNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#LuminosityNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#LuminosityNotificationFunctionality</seealso>
    let LuminosityNotificationFunctionality =
        Prefixed_Name(dogontowl, "LuminosityNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MainsPowerOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MainsPowerOutlet">http://elite.polito.it/ontologies/dogont.owl#MainsPowerOutlet</seealso>
    let MainsPowerOutlet = Prefixed_Name(dogontowl, "MainsPowerOutlet") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Meter">http://elite.polito.it/ontologies/dogont.owl#Meter</seealso>
    let Meter = Prefixed_Name(dogontowl, "Meter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MeteringPowerOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MeteringPowerOutlet">http://elite.polito.it/ontologies/dogont.owl#MeteringPowerOutlet</seealso>
    let MeteringPowerOutlet =
        Prefixed_Name(dogontowl, "MeteringPowerOutlet") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MicrowaveEmissionNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionNotificationFunctionality</seealso>
    let MicrowaveEmissionNotificationFunctionality =
        Prefixed_Name(dogontowl, "MicrowaveEmissionNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MicrowaveEmissionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionState">http://elite.polito.it/ontologies/dogont.owl#MicrowaveEmissionState</seealso>
    let MicrowaveEmissionState =
        Prefixed_Name(dogontowl, "MicrowaveEmissionState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MicrowaveOven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Microwave oven"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MicrowaveOven"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MicrowaveOven">http://elite.polito.it/ontologies/dogont.owl#MicrowaveOven</seealso>
    let MicrowaveOven = Prefixed_Name(dogontowl, "MicrowaveOven") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ModBusProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModBusProperty">http://elite.polito.it/ontologies/dogont.owl#ModBusProperty</seealso>
    let ModBusProperty = Prefixed_Name(dogontowl, "ModBusProperty") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ModBusStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModBusStateValue">http://elite.polito.it/ontologies/dogont.owl#ModBusStateValue</seealso>
    let ModBusStateValue = Prefixed_Name(dogontowl, "ModBusStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ModbusCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModbusCommand">http://elite.polito.it/ontologies/dogont.owl#ModbusCommand</seealso>
    let ModbusCommand = Prefixed_Name(dogontowl, "ModbusCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ModbusComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModbusComponent">http://elite.polito.it/ontologies/dogont.owl#ModbusComponent</seealso>
    let ModbusComponent = Prefixed_Name(dogontowl, "ModbusComponent") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ModbusGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModbusGateway">http://elite.polito.it/ontologies/dogont.owl#ModbusGateway</seealso>
    let ModbusGateway = Prefixed_Name(dogontowl, "ModbusGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ModbusNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ModbusNotification">http://elite.polito.it/ontologies/dogont.owl#ModbusNotification</seealso>
    let ModbusNotification =
        Prefixed_Name(dogontowl, "ModbusNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementAndTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementAndTemperatureSensor">http://elite.polito.it/ontologies/dogont.owl#MovementAndTemperatureSensor</seealso>
    let MovementAndTemperatureSensor =
        Prefixed_Name(dogontowl, "MovementAndTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementNotification">http://elite.polito.it/ontologies/dogont.owl#MovementNotification</seealso>
    let MovementNotification =
        Prefixed_Name(dogontowl, "MovementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MovementNotificationFunctionality</seealso>
    let MovementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MovementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovementSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementSensor">http://elite.polito.it/ontologies/dogont.owl#MovementSensor</seealso>
    let MovementSensor = Prefixed_Name(dogontowl, "MovementSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#MovementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovementState">http://elite.polito.it/ontologies/dogont.owl#MovementState</seealso>
    let MovementState = Prefixed_Name(dogontowl, "MovementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovingDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovingDownNotification">http://elite.polito.it/ontologies/dogont.owl#MovingDownNotification</seealso>
    let MovingDownNotification =
        Prefixed_Name(dogontowl, "MovingDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovingStateValue">http://elite.polito.it/ontologies/dogont.owl#MovingStateValue</seealso>
    let MovingStateValue = Prefixed_Name(dogontowl, "MovingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovingUpDownState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovingUpDownState">http://elite.polito.it/ontologies/dogont.owl#MovingUpDownState</seealso>
    let MovingUpDownState =
        Prefixed_Name(dogontowl, "MovingUpDownState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MovingUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MovingUpNotification">http://elite.polito.it/ontologies/dogont.owl#MovingUpNotification</seealso>
    let MovingUpNotification =
        Prefixed_Name(dogontowl, "MovingUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffActiveEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffActiveEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#MultiTariffActiveEnergyStateValue</seealso>
    let MultiTariffActiveEnergyStateValue =
        Prefixed_Name(dogontowl, "MultiTariffActiveEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#MultiTariffEnergyMeter</seealso>
    let MultiTariffEnergyMeter =
        Prefixed_Name(dogontowl, "MultiTariffEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffReactiveEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffReactiveEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#MultiTariffReactiveEnergyStateValue</seealso>
    let MultiTariffReactiveEnergyStateValue =
        Prefixed_Name(dogontowl, "MultiTariffReactiveEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality</seealso>
    let MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotification</seealso>
    let MultiTariffSinglePhaseActiveEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseActiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality</seealso>
    let MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseActiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseActiveEnergyState</seealso>
    let MultiTariffSinglePhaseActiveEnergyState =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseActiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseEnergyMeter</seealso>
    let MultiTariffSinglePhaseEnergyMeter =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality</seealso>
    let MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotification</seealso>
    let MultiTariffSinglePhaseReactiveEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseReactiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffSinglePhaseReactiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#MultiTariffSinglePhaseReactiveEnergyState</seealso>
    let MultiTariffSinglePhaseReactiveEnergyState =
        Prefixed_Name(dogontowl, "MultiTariffSinglePhaseReactiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementFunctionality</seealso>
    let MultiTariffThreePhaseActiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotification</seealso>
    let MultiTariffThreePhaseActiveEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseActiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality</seealso>
    let MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseActiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseActiveEnergyState</seealso>
    let MultiTariffThreePhaseActiveEnergyState =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseActiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseEnergyMeter</seealso>
    let MultiTariffThreePhaseEnergyMeter =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality</seealso>
    let MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotification</seealso>
    let MultiTariffThreePhaseReactiveEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseReactiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiTariffThreePhaseReactiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#MultiTariffThreePhaseReactiveEnergyState</seealso>
    let MultiTariffThreePhaseReactiveEnergyState =
        Prefixed_Name(dogontowl, "MultiTariffThreePhaseReactiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleAlertNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotification">http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotification</seealso>
    let MultipleAlertNotification =
        Prefixed_Name(dogontowl, "MultipleAlertNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleAlertNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleAlertNotificationFunctionality</seealso>
    let MultipleAlertNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultipleAlertNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleEventNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotification">http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotification</seealso>
    let MultipleEventNotification =
        Prefixed_Name(dogontowl, "MultipleEventNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleEventNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleEventNotificationFunctionality</seealso>
    let MultipleEventNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultipleEventNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementFunctionality</seealso>
    let MultipleFlowMeasurementFunctionality =
        Prefixed_Name(dogontowl, "MultipleFlowMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowMeasurementNotificationFunctionality</seealso>
    let MultipleFlowMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultipleFlowMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowRateState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateState">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateState</seealso>
    let MultipleFlowRateState =
        Prefixed_Name(dogontowl, "MultipleFlowRateState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowRateStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateStateValue">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowRateStateValue</seealso>
    let MultipleFlowRateStateValue =
        Prefixed_Name(dogontowl, "MultipleFlowRateStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleFlowSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Flow  Sensor device measures and periodically reports the flow rate of a liquid (typically water)"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleFlowSensor">http://elite.polito.it/ontologies/dogont.owl#MultipleFlowSensor</seealso>
    let MultipleFlowSensor =
        Prefixed_Name(dogontowl, "MultipleFlowSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleHumidityMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The capability of measuring the humidity of a room"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementFunctionality</seealso>
    let MultipleHumidityMeasurementFunctionality =
        Prefixed_Name(dogontowl, "MultipleHumidityMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleHumidityMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The notification for requesting humidity measurment..."</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleHumidityMeasurementNotificationFunctionality</seealso>
    let MultipleHumidityMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultipleHumidityMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementFunctionality</seealso>
    let MultiplePressureMeasurementFunctionality =
        Prefixed_Name(dogontowl, "MultiplePressureMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureMeasurementNotificationFunctionality</seealso>
    let MultiplePressureMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultiplePressureMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Pressure Sensor device measures and periodically reports the pressure of a liquid (typically water)"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureSensor">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureSensor</seealso>
    let MultiplePressureSensor =
        Prefixed_Name(dogontowl, "MultiplePressureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureState">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureState</seealso>
    let MultiplePressureState =
        Prefixed_Name(dogontowl, "MultiplePressureState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultiplePressureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultiplePressureStateValue">http://elite.polito.it/ontologies/dogont.owl#MultiplePressureStateValue</seealso>
    let MultiplePressureStateValue =
        Prefixed_Name(dogontowl, "MultiplePressureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The capability of measuring temperatures"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementFunctionality</seealso>
    let MultipleTemperatureMeasurementFunctionality =
        Prefixed_Name(dogontowl, "MultipleTemperatureMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Notifies the measurment of a temperature, through a proper temperature sensor"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureMeasurementNotificationFunctionality</seealso>
    let MultipleTemperatureMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "MultipleTemperatureMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that detects the temperature of the atmosphere"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TemperatureSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureSensor">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureSensor</seealso>
    let MultipleTemperatureSensor =
        Prefixed_Name(dogontowl, "MultipleTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models the temperature value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MultipleTemperatureState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureState">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureState</seealso>
    let MultipleTemperatureState =
        Prefixed_Name(dogontowl, "MultipleTemperatureState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#MultipleTemperatureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureStateValue">http://elite.polito.it/ontologies/dogont.owl#MultipleTemperatureStateValue</seealso>
    let MultipleTemperatureStateValue =
        Prefixed_Name(dogontowl, "MultipleTemperatureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NeedingAuthenticationStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NeedingAuthenticationStateValue">http://elite.polito.it/ontologies/dogont.owl#NeedingAuthenticationStateValue</seealso>
    let NeedingAuthenticationStateValue =
        Prefixed_Name(dogontowl, "NeedingAuthenticationStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkClosedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkClosedNotification">http://elite.polito.it/ontologies/dogont.owl#NetworkClosedNotification</seealso>
    let NetworkClosedNotification =
        Prefixed_Name(dogontowl, "NetworkClosedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The manufacturers of the domotic component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NetworkComponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkComponent">http://elite.polito.it/ontologies/dogont.owl#NetworkComponent</seealso>
    let NetworkComponent = Prefixed_Name(dogontowl, "NetworkComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Derives from the general cluster functionalities defined in ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkFunctionality">http://elite.polito.it/ontologies/dogont.owl#NetworkFunctionality</seealso>
    let NetworkFunctionality =
        Prefixed_Name(dogontowl, "NetworkFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkManagementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementFunctionality">http://elite.polito.it/ontologies/dogont.owl#NetworkManagementFunctionality</seealso>
    let NetworkManagementFunctionality =
        Prefixed_Name(dogontowl, "NetworkManagementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkManagementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#NetworkManagementNotificationFunctionality</seealso>
    let NetworkManagementNotificationFunctionality =
        Prefixed_Name(dogontowl, "NetworkManagementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkManagementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkManagementState">http://elite.polito.it/ontologies/dogont.owl#NetworkManagementState</seealso>
    let NetworkManagementState =
        Prefixed_Name(dogontowl, "NetworkManagementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkNotification">http://elite.polito.it/ontologies/dogont.owl#NetworkNotification</seealso>
    let NetworkNotification =
        Prefixed_Name(dogontowl, "NetworkNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Derives from the general cluster functionalities defined in ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#NetworkNotificationFunctionality</seealso>
    let NetworkNotificationFunctionality =
        Prefixed_Name(dogontowl, "NetworkNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkOpenedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkOpenedNotification">http://elite.polito.it/ontologies/dogont.owl#NetworkOpenedNotification</seealso>
    let NetworkOpenedNotification =
        Prefixed_Name(dogontowl, "NetworkOpenedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkSpecificCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificCommand">http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificCommand</seealso>
    let NetworkSpecificCommand =
        Prefixed_Name(dogontowl, "NetworkSpecificCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkSpecificNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificNotification">http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificNotification</seealso>
    let NetworkSpecificNotification =
        Prefixed_Name(dogontowl, "NetworkSpecificNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NetworkSpecificStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Network specific state value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificStateValue">http://elite.polito.it/ontologies/dogont.owl#NetworkSpecificStateValue</seealso>
    let NetworkSpecificStateValue =
        Prefixed_Name(dogontowl, "NetworkSpecificStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NextTrackCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NextTrackCommand">http://elite.polito.it/ontologies/dogont.owl#NextTrackCommand</seealso>
    let NextTrackCommand = Prefixed_Name(dogontowl, "NextTrackCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Nightstand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A small table or stand placed at a bedside."</para>
    /// labels<para>"Nightstand"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Nightstand">http://elite.polito.it/ontologies/dogont.owl#Nightstand</seealso>
    let Nightstand = Prefixed_Name(dogontowl, "Nightstand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NoFailureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NoFailureStateValue">http://elite.polito.it/ontologies/dogont.owl#NoFailureStateValue</seealso>
    let NoFailureStateValue =
        Prefixed_Name(dogontowl, "NoFailureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NoMovementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NoMovementNotification">http://elite.polito.it/ontologies/dogont.owl#NoMovementNotification</seealso>
    let NoMovementNotification =
        Prefixed_Name(dogontowl, "NoMovementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NonParametricCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NonParametricCommand">http://elite.polito.it/ontologies/dogont.owl#NonParametricCommand</seealso>
    let NonParametricCommand =
        Prefixed_Name(dogontowl, "NonParametricCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NonParametricLevelNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NonParametricLevelNotification">http://elite.polito.it/ontologies/dogont.owl#NonParametricLevelNotification</seealso>
    let NonParametricLevelNotification =
        Prefixed_Name(dogontowl, "NonParametricLevelNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NonParametricNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NonParametricNotification">http://elite.polito.it/ontologies/dogont.owl#NonParametricNotification</seealso>
    let NonParametricNotification =
        Prefixed_Name(dogontowl, "NonParametricNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NonVoidCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NonVoidCommand">http://elite.polito.it/ontologies/dogont.owl#NonVoidCommand</seealso>
    let NonVoidCommand = Prefixed_Name(dogontowl, "NonVoidCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotDetectedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotDetectedNotification">http://elite.polito.it/ontologies/dogont.owl#NotDetectedNotification</seealso>
    let NotDetectedNotification =
        Prefixed_Name(dogontowl, "NotDetectedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotDetectedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotDetectedStateValue">http://elite.polito.it/ontologies/dogont.owl#NotDetectedStateValue</seealso>
    let NotDetectedStateValue =
        Prefixed_Name(dogontowl, "NotDetectedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotEmittingMicrowavesNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesNotification">http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesNotification</seealso>
    let NotEmittingMicrowavesNotification =
        Prefixed_Name(dogontowl, "NotEmittingMicrowavesNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotEmittingMicrowavesStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesStateValue">http://elite.polito.it/ontologies/dogont.owl#NotEmittingMicrowavesStateValue</seealso>
    let NotEmittingMicrowavesStateValue =
        Prefixed_Name(dogontowl, "NotEmittingMicrowavesStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotMovingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotMovingStateValue">http://elite.polito.it/ontologies/dogont.owl#NotMovingStateValue</seealso>
    let NotMovingStateValue =
        Prefixed_Name(dogontowl, "NotMovingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotPresentNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotPresentNotification">http://elite.polito.it/ontologies/dogont.owl#NotPresentNotification</seealso>
    let NotPresentNotification =
        Prefixed_Name(dogontowl, "NotPresentNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotPresentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotPresentState">http://elite.polito.it/ontologies/dogont.owl#NotPresentState</seealso>
    let NotPresentState = Prefixed_Name(dogontowl, "NotPresentState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotProgrammedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotProgrammedStateValue">http://elite.polito.it/ontologies/dogont.owl#NotProgrammedStateValue</seealso>
    let NotProgrammedStateValue =
        Prefixed_Name(dogontowl, "NotProgrammedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Notification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Notification">http://elite.polito.it/ontologies/dogont.owl#Notification</seealso>
    let Notification = Prefixed_Name(dogontowl, "Notification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#NotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Capability of a controllable building thing that notifies information,e.g.door sensor notifies "open"-"close""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NotificationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#NotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#NotificationFunctionality</seealso>
    let NotificationFunctionality =
        Prefixed_Name(dogontowl, "NotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OccupancySensingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionality for getting the occupancy state of a given room"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OccupancySensingFunctionality">http://elite.polito.it/ontologies/dogont.owl#OccupancySensingFunctionality</seealso>
    let OccupancySensingFunctionality =
        Prefixed_Name(dogontowl, "OccupancySensingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OccupancySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Occupancy Sensor device reports the occupancy state of an area. Derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OccupancySensor">http://elite.polito.it/ontologies/dogont.owl#OccupancySensor</seealso>
    let OccupancySensor = Prefixed_Name(dogontowl, "OccupancySensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OccupancyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OccupancyState">http://elite.polito.it/ontologies/dogont.owl#OccupancyState</seealso>
    let OccupancyState = Prefixed_Name(dogontowl, "OccupancyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OccupiedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OccupiedStateValue">http://elite.polito.it/ontologies/dogont.owl#OccupiedStateValue</seealso>
    let OccupiedStateValue =
        Prefixed_Name(dogontowl, "OccupiedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OffCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OffCommand">http://elite.polito.it/ontologies/dogont.owl#OffCommand</seealso>
    let OffCommand = Prefixed_Name(dogontowl, "OffCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OffFlashingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OffFlashingCommand">http://elite.polito.it/ontologies/dogont.owl#OffFlashingCommand</seealso>
    let OffFlashingCommand =
        Prefixed_Name(dogontowl, "OffFlashingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OffNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OffNotification">http://elite.polito.it/ontologies/dogont.owl#OffNotification</seealso>
    let OffNotification = Prefixed_Name(dogontowl, "OffNotification") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OffStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OffStateValue">http://elite.polito.it/ontologies/dogont.owl#OffStateValue</seealso>
    let OffStateValue = Prefixed_Name(dogontowl, "OffStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OnCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnCommand">http://elite.polito.it/ontologies/dogont.owl#OnCommand</seealso>
    let OnCommand = Prefixed_Name(dogontowl, "OnCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnFlashingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnFlashingCommand">http://elite.polito.it/ontologies/dogont.owl#OnFlashingCommand</seealso>
    let OnFlashingCommand =
        Prefixed_Name(dogontowl, "OnFlashingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnNotification">http://elite.polito.it/ontologies/dogont.owl#OnNotification</seealso>
    let OnNotification = Prefixed_Name(dogontowl, "OnNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffFlashingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionality to switch on and off an object with a given switching period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OnOffFlashingFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffFlashingFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffFlashingFunctionality</seealso>
    let OnOffFlashingFunctionality =
        Prefixed_Name(dogontowl, "OnOffFlashingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionality: turn on - turn off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OnOffFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffFunctionality</seealso>
    let OnOffFunctionality =
        Prefixed_Name(dogontowl, "OnOffFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Simple lamp that can be just turn on or turn off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SimpleLamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffLight">http://elite.polito.it/ontologies/dogont.owl#OnOffLight</seealso>
    let OnOffLight = Prefixed_Name(dogontowl, "OnOffLight") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OnOffLightSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"OnOffSwitch for Lights only, derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffLightSwitch">http://elite.polito.it/ontologies/dogont.owl#OnOffLightSwitch</seealso>
    let OnOffLightSwitch = Prefixed_Name(dogontowl, "OnOffLightSwitch") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Notification: on - off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OnOffNotificationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffNotificationFunctionality</seealso>
    let OnOffNotificationFunctionality =
        Prefixed_Name(dogontowl, "OnOffNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models a binary output which can be only in on or off state (OnOffState), compatible with the ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffOutput">http://elite.polito.it/ontologies/dogont.owl#OnOffOutput</seealso>
    let OnOffOutput = Prefixed_Name(dogontowl, "OnOffOutput") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffStandByFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffStandByFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffStandByFunctionality</seealso>
    let OnOffStandByFunctionality =
        Prefixed_Name(dogontowl, "OnOffStandByFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffStandbyNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffStandbyNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#OnOffStandbyNotificationFunctionality</seealso>
    let OnOffStandbyNotificationFunctionality =
        Prefixed_Name(dogontowl, "OnOffStandbyNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OnOffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State: on - off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OnOffState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffState">http://elite.polito.it/ontologies/dogont.owl#OnOffState</seealso>
    let OnOffState = Prefixed_Name(dogontowl, "OnOffState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OnOffSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Generic OnOff switch, derives from the ZigBee Home Automation specification"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnOffSwitch">http://elite.polito.it/ontologies/dogont.owl#OnOffSwitch</seealso>
    let OnOffSwitch = Prefixed_Name(dogontowl, "OnOffSwitch") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OnStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OnStateValue">http://elite.polito.it/ontologies/dogont.owl#OnStateValue</seealso>
    let OnStateValue = Prefixed_Name(dogontowl, "OnStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenCloseFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionality: open - close"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OpenCloseFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseFunctionality">http://elite.polito.it/ontologies/dogont.owl#OpenCloseFunctionality</seealso>
    let OpenCloseFunctionality =
        Prefixed_Name(dogontowl, "OpenCloseFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenCloseNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Notification: open - close"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OpenCloseNotification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#OpenCloseNotificationFunctionality</seealso>
    let OpenCloseNotificationFunctionality =
        Prefixed_Name(dogontowl, "OpenCloseNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenCloseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State: open - close"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OpenCloseState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenCloseState">http://elite.polito.it/ontologies/dogont.owl#OpenCloseState</seealso>
    let OpenCloseState = Prefixed_Name(dogontowl, "OpenCloseState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OpenCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenCommand">http://elite.polito.it/ontologies/dogont.owl#OpenCommand</seealso>
    let OpenCommand = Prefixed_Name(dogontowl, "OpenCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenNetworkCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenNetworkCommand">http://elite.polito.it/ontologies/dogont.owl#OpenNetworkCommand</seealso>
    let OpenNetworkCommand =
        Prefixed_Name(dogontowl, "OpenNetworkCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OpenNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenNotification">http://elite.polito.it/ontologies/dogont.owl#OpenNotification</seealso>
    let OpenNotification = Prefixed_Name(dogontowl, "OpenNotification") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#OpenStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OpenStateValue">http://elite.polito.it/ontologies/dogont.owl#OpenStateValue</seealso>
    let OpenStateValue = Prefixed_Name(dogontowl, "OpenStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Oven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Kitchen appliance used for baking or roasting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oven"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Oven">http://elite.polito.it/ontologies/dogont.owl#Oven</seealso>
    let Oven = Prefixed_Name(dogontowl, "Oven") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OverloadControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OverloadControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#OverloadControlFunctionality</seealso>
    let OverloadControlFunctionality =
        Prefixed_Name(dogontowl, "OverloadControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OverloadPauseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OverloadPauseCommand">http://elite.polito.it/ontologies/dogont.owl#OverloadPauseCommand</seealso>
    let OverloadPauseCommand =
        Prefixed_Name(dogontowl, "OverloadPauseCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OverloadPauseResumeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OverloadPauseResumeCommand">http://elite.polito.it/ontologies/dogont.owl#OverloadPauseResumeCommand</seealso>
    let OverloadPauseResumeCommand =
        Prefixed_Name(dogontowl, "OverloadPauseResumeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#OverloadWarningCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#OverloadWarningCommand">http://elite.polito.it/ontologies/dogont.owl#OverloadWarningCommand</seealso>
    let OverloadWarningCommand =
        Prefixed_Name(dogontowl, "OverloadWarningCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PanDownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PanDownCommand">http://elite.polito.it/ontologies/dogont.owl#PanDownCommand</seealso>
    let PanDownCommand = Prefixed_Name(dogontowl, "PanDownCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PanLeftCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PanLeftCommand">http://elite.polito.it/ontologies/dogont.owl#PanLeftCommand</seealso>
    let PanLeftCommand = Prefixed_Name(dogontowl, "PanLeftCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PanRightCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PanRightCommand">http://elite.polito.it/ontologies/dogont.owl#PanRightCommand</seealso>
    let PanRightCommand = Prefixed_Name(dogontowl, "PanRightCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PanUpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PanUpCommand">http://elite.polito.it/ontologies/dogont.owl#PanUpCommand</seealso>
    let PanUpCommand = Prefixed_Name(dogontowl, "PanUpCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ParametricCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ParametricCommand">http://elite.polito.it/ontologies/dogont.owl#ParametricCommand</seealso>
    let ParametricCommand =
        Prefixed_Name(dogontowl, "ParametricCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ParametricLevelNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ParametricLevelNotification">http://elite.polito.it/ontologies/dogont.owl#ParametricLevelNotification</seealso>
    let ParametricLevelNotification =
        Prefixed_Name(dogontowl, "ParametricLevelNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ParametricNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ParametricNotification">http://elite.polito.it/ontologies/dogont.owl#ParametricNotification</seealso>
    let ParametricNotification =
        Prefixed_Name(dogontowl, "ParametricNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Partition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vertical structure that divides or separates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Partition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Partition">http://elite.polito.it/ontologies/dogont.owl#Partition</seealso>
    let Partition = Prefixed_Name(dogontowl, "Partition") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PauseApplianceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PauseApplianceNotification">http://elite.polito.it/ontologies/dogont.owl#PauseApplianceNotification</seealso>
    let PauseApplianceNotification =
        Prefixed_Name(dogontowl, "PauseApplianceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PauseCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PauseCommand">http://elite.polito.it/ontologies/dogont.owl#PauseCommand</seealso>
    let PauseCommand = Prefixed_Name(dogontowl, "PauseCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PausePlaybackNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PausePlaybackNotification">http://elite.polito.it/ontologies/dogont.owl#PausePlaybackNotification</seealso>
    let PausePlaybackNotification =
        Prefixed_Name(dogontowl, "PausePlaybackNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PauseStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PauseStateValue">http://elite.polito.it/ontologies/dogont.owl#PauseStateValue</seealso>
    let PauseStateValue = Prefixed_Name(dogontowl, "PauseStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PelletHeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Heater that combusts wood-pellet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PelletHeater"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PelletHeater">http://elite.polito.it/ontologies/dogont.owl#PelletHeater</seealso>
    let PelletHeater = Prefixed_Name(dogontowl, "PelletHeater") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Appliance to comunicate with other person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Phone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Phone">http://elite.polito.it/ontologies/dogont.owl#Phone</seealso>
    let Phone = Prefixed_Name(dogontowl, "Phone") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PhonoStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PhonoStateValue">http://elite.polito.it/ontologies/dogont.owl#PhonoStateValue</seealso>
    let PhonoStateValue = Prefixed_Name(dogontowl, "PhonoStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PictureGrabFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PictureGrabFunctionality">http://elite.polito.it/ontologies/dogont.owl#PictureGrabFunctionality</seealso>
    let PictureGrabFunctionality =
        Prefixed_Name(dogontowl, "PictureGrabFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayCommand">http://elite.polito.it/ontologies/dogont.owl#PlayCommand</seealso>
    let PlayCommand = Prefixed_Name(dogontowl, "PlayCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayFunctionality">http://elite.polito.it/ontologies/dogont.owl#PlayFunctionality</seealso>
    let PlayFunctionality =
        Prefixed_Name(dogontowl, "PlayFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayNotification">http://elite.polito.it/ontologies/dogont.owl#PlayNotification</seealso>
    let PlayNotification = Prefixed_Name(dogontowl, "PlayNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PlayNotificationFunctionality</seealso>
    let PlayNotificationFunctionality =
        Prefixed_Name(dogontowl, "PlayNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlayState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayState">http://elite.polito.it/ontologies/dogont.owl#PlayState</seealso>
    let PlayState = Prefixed_Name(dogontowl, "PlayState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PlayStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlayStateValue">http://elite.polito.it/ontologies/dogont.owl#PlayStateValue</seealso>
    let PlayStateValue = Prefixed_Name(dogontowl, "PlayStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PlaybackNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PlaybackNotification">http://elite.polito.it/ontologies/dogont.owl#PlaybackNotification</seealso>
    let PlaybackNotification =
        Prefixed_Name(dogontowl, "PlaybackNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerDelivery">http://elite.polito.it/ontologies/dogont.owl#PowerDelivery</seealso>
    let PowerDelivery = Prefixed_Name(dogontowl, "PowerDelivery") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementFunctionality</seealso>
    let PowerFactorMeasurementFunctionality =
        Prefixed_Name(dogontowl, "PowerFactorMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotification</seealso>
    let PowerFactorMeasurementNotification =
        Prefixed_Name(dogontowl, "PowerFactorMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementNotificationFunctionality</seealso>
    let PowerFactorMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "PowerFactorMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementState">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeasurementState</seealso>
    let PowerFactorMeasurementState =
        Prefixed_Name(dogontowl, "PowerFactorMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeter">http://elite.polito.it/ontologies/dogont.owl#PowerFactorMeter</seealso>
    let PowerFactorMeter = Prefixed_Name(dogontowl, "PowerFactorMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerFactorStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerFactorStateValue">http://elite.polito.it/ontologies/dogont.owl#PowerFactorStateValue</seealso>
    let PowerFactorStateValue =
        Prefixed_Name(dogontowl, "PowerFactorStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#PowerMeasurementFunctionality</seealso>
    let PowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "PowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerMeter">http://elite.polito.it/ontologies/dogont.owl#PowerMeter</seealso>
    let PowerMeter = Prefixed_Name(dogontowl, "PowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerMeteringLevelControllableOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerMeteringLevelControllableOutput">http://elite.polito.it/ontologies/dogont.owl#PowerMeteringLevelControllableOutput</seealso>
    let PowerMeteringLevelControllableOutput =
        Prefixed_Name(dogontowl, "PowerMeteringLevelControllableOutput") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PowerMeteringPowerOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PowerMeteringPowerOutlet">http://elite.polito.it/ontologies/dogont.owl#PowerMeteringPowerOutlet</seealso>
    let PowerMeteringPowerOutlet =
        Prefixed_Name(dogontowl, "PowerMeteringPowerOutlet") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresenceAndMovementSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresenceAndMovementSensor">http://elite.polito.it/ontologies/dogont.owl#PresenceAndMovementSensor</seealso>
    let PresenceAndMovementSensor =
        Prefixed_Name(dogontowl, "PresenceAndMovementSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresenceNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresenceNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PresenceNotificationFunctionality</seealso>
    let PresenceNotificationFunctionality =
        Prefixed_Name(dogontowl, "PresenceNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresenceSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresenceSensor">http://elite.polito.it/ontologies/dogont.owl#PresenceSensor</seealso>
    let PresenceSensor = Prefixed_Name(dogontowl, "PresenceSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PresenceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresenceState">http://elite.polito.it/ontologies/dogont.owl#PresenceState</seealso>
    let PresenceState = Prefixed_Name(dogontowl, "PresenceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PresentStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PresentStateValue">http://elite.polito.it/ontologies/dogont.owl#PresentStateValue</seealso>
    let PresentStateValue =
        Prefixed_Name(dogontowl, "PresentStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressedDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressedDownNotification">http://elite.polito.it/ontologies/dogont.owl#PressedDownNotification</seealso>
    let PressedDownNotification =
        Prefixed_Name(dogontowl, "PressedDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressedMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressedMNotification">http://elite.polito.it/ontologies/dogont.owl#PressedMNotification</seealso>
    let PressedMNotification =
        Prefixed_Name(dogontowl, "PressedMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressedNotification">http://elite.polito.it/ontologies/dogont.owl#PressedNotification</seealso>
    let PressedNotification =
        Prefixed_Name(dogontowl, "PressedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressedUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressedUpNotification">http://elite.polito.it/ontologies/dogont.owl#PressedUpNotification</seealso>
    let PressedUpNotification =
        Prefixed_Name(dogontowl, "PressedUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementFunctionality</seealso>
    let PressureMeasurementFunctionality =
        Prefixed_Name(dogontowl, "PressureMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureMeasurementMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementMNotification">http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementMNotification</seealso>
    let PressureMeasurementMNotification =
        Prefixed_Name(dogontowl, "PressureMeasurementMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotification</seealso>
    let PressureMeasurementNotification =
        Prefixed_Name(dogontowl, "PressureMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PressureMeasurementNotificationFunctionality</seealso>
    let PressureMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "PressureMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Pressure Sensor device measures and periodically reports the pressure of a liquid (typically water)"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureSensor">http://elite.polito.it/ontologies/dogont.owl#PressureSensor</seealso>
    let PressureSensor = Prefixed_Name(dogontowl, "PressureSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PressureState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureState">http://elite.polito.it/ontologies/dogont.owl#PressureState</seealso>
    let PressureState = Prefixed_Name(dogontowl, "PressureState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PressureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PressureStateValue">http://elite.polito.it/ontologies/dogont.owl#PressureStateValue</seealso>
    let PressureStateValue =
        Prefixed_Name(dogontowl, "PressureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PreviousTrackCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PreviousTrackCommand">http://elite.polito.it/ontologies/dogont.owl#PreviousTrackCommand</seealso>
    let PreviousTrackCommand =
        Prefixed_Name(dogontowl, "PreviousTrackCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Printer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Output device that prints"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Printer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Printer">http://elite.polito.it/ontologies/dogont.owl#Printer</seealso>
    let Printer = Prefixed_Name(dogontowl, "Printer") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ProgramInterruptedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ProgramInterruptedStateValue">http://elite.polito.it/ontologies/dogont.owl#ProgramInterruptedStateValue</seealso>
    let ProgramInterruptedStateValue =
        Prefixed_Name(dogontowl, "ProgramInterruptedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ProgramState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ProgramState">http://elite.polito.it/ontologies/dogont.owl#ProgramState</seealso>
    let ProgramState = Prefixed_Name(dogontowl, "ProgramState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ProgrammedAndWaitingToStartStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ProgrammedAndWaitingToStartStateValue">http://elite.polito.it/ontologies/dogont.owl#ProgrammedAndWaitingToStartStateValue</seealso>
    let ProgrammedAndWaitingToStartStateValue =
        Prefixed_Name(dogontowl, "ProgrammedAndWaitingToStartStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ProgrammedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ProgrammedStateValue">http://elite.polito.it/ontologies/dogont.owl#ProgrammedStateValue</seealso>
    let ProgrammedStateValue =
        Prefixed_Name(dogontowl, "ProgrammedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Pump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Pump device is a pump that may have variable speed. It may have optional built-in sensors and a regulation mechanism. It is typically used for pumping water. Derives from ZigBee HA specifications."</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Pump">http://elite.polito.it/ontologies/dogont.owl#Pump</seealso>
    let Pump = Prefixed_Name(dogontowl, "Pump") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#PumpController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Pump device controller can control a Pump device"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PumpController">http://elite.polito.it/ontologies/dogont.owl#PumpController</seealso>
    let PumpController = Prefixed_Name(dogontowl, "PumpController") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkAuthenticationActiveNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationActiveNotification">http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationActiveNotification</seealso>
    let PushLinkAuthenticationActiveNotification =
        Prefixed_Name(dogontowl, "PushLinkAuthenticationActiveNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkAuthenticationIdleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationIdleNotification">http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationIdleNotification</seealso>
    let PushLinkAuthenticationIdleNotification =
        Prefixed_Name(dogontowl, "PushLinkAuthenticationIdleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkAuthenticationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationState">http://elite.polito.it/ontologies/dogont.owl#PushLinkAuthenticationState</seealso>
    let PushLinkAuthenticationState =
        Prefixed_Name(dogontowl, "PushLinkAuthenticationState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkFunctionality">http://elite.polito.it/ontologies/dogont.owl#PushLinkFunctionality</seealso>
    let PushLinkFunctionality =
        Prefixed_Name(dogontowl, "PushLinkFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#PushLinkNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#PushLinkNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#PushLinkNotificationFunctionality</seealso>
    let PushLinkNotificationFunctionality =
        Prefixed_Name(dogontowl, "PushLinkNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#QuadSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#QuadSensor">http://elite.polito.it/ontologies/dogont.owl#QuadSensor</seealso>
    let QuadSensor = Prefixed_Name(dogontowl, "QuadSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#QueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Capability of a controllable building thing that must reply to an interrogation about its state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"QueryFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#QueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#QueryFunctionality</seealso>
    let QueryFunctionality =
        Prefixed_Name(dogontowl, "QueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Radio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A communication system based on broadcasting electromagnetic waves"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Radio">http://elite.polito.it/ontologies/dogont.owl#Radio</seealso>
    let Radio = Prefixed_Name(dogontowl, "Radio") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RaisingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RaisingStateValue">http://elite.polito.it/ontologies/dogont.owl#RaisingStateValue</seealso>
    let RaisingStateValue =
        Prefixed_Name(dogontowl, "RaisingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementFunctionality</seealso>
    let ReactiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let ReactiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactiveEnergyStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyStateValue">http://elite.polito.it/ontologies/dogont.owl#ReactiveEnergyStateValue</seealso>
    let ReactiveEnergyStateValue =
        Prefixed_Name(dogontowl, "ReactiveEnergyStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementFunctionality</seealso>
    let ReactivePowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ReactivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementNotificationFunctionality</seealso>
    let ReactivePowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ReactivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeasurementState</seealso>
    let ReactivePowerMeasurementState =
        Prefixed_Name(dogontowl, "ReactivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerMeter</seealso>
    let ReactivePowerMeter =
        Prefixed_Name(dogontowl, "ReactivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReactivePowerStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReactivePowerStateValue">http://elite.polito.it/ontologies/dogont.owl#ReactivePowerStateValue</seealso>
    let ReactivePowerStateValue =
        Prefixed_Name(dogontowl, "ReactivePowerStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RedStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RedStateValue">http://elite.polito.it/ontologies/dogont.owl#RedStateValue</seealso>
    let RedStateValue = Prefixed_Name(dogontowl, "RedStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReleasedMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReleasedMNotification">http://elite.polito.it/ontologies/dogont.owl#ReleasedMNotification</seealso>
    let ReleasedMNotification =
        Prefixed_Name(dogontowl, "ReleasedMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ReleasedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ReleasedNotification">http://elite.polito.it/ontologies/dogont.owl#ReleasedNotification</seealso>
    let ReleasedNotification =
        Prefixed_Name(dogontowl, "ReleasedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RemainingTimeChangedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RemainingTimeChangedNotification">http://elite.polito.it/ontologies/dogont.owl#RemainingTimeChangedNotification</seealso>
    let RemainingTimeChangedNotification =
        Prefixed_Name(dogontowl, "RemainingTimeChangedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RemoteControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RemoteControl">http://elite.polito.it/ontologies/dogont.owl#RemoteControl</seealso>
    let RemoteControl = Prefixed_Name(dogontowl, "RemoteControl") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#RestCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestCommand">http://elite.polito.it/ontologies/dogont.owl#RestCommand</seealso>
    let RestCommand = Prefixed_Name(dogontowl, "RestCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestDownNotification">http://elite.polito.it/ontologies/dogont.owl#RestDownNotification</seealso>
    let RestDownNotification =
        Prefixed_Name(dogontowl, "RestDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestNotification">http://elite.polito.it/ontologies/dogont.owl#RestNotification</seealso>
    let RestNotification = Prefixed_Name(dogontowl, "RestNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestTripleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestTripleStateValue">http://elite.polito.it/ontologies/dogont.owl#RestTripleStateValue</seealso>
    let RestTripleStateValue =
        Prefixed_Name(dogontowl, "RestTripleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RestUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RestUpNotification">http://elite.polito.it/ontologies/dogont.owl#RestUpNotification</seealso>
    let RestUpNotification =
        Prefixed_Name(dogontowl, "RestUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RewindCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RewindCommand">http://elite.polito.it/ontologies/dogont.owl#RewindCommand</seealso>
    let RewindCommand = Prefixed_Name(dogontowl, "RewindCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RewindNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RewindNotification">http://elite.polito.it/ontologies/dogont.owl#RewindNotification</seealso>
    let RewindNotification =
        Prefixed_Name(dogontowl, "RewindNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RewindStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RewindStateValue">http://elite.polito.it/ontologies/dogont.owl#RewindStateValue</seealso>
    let RewindStateValue = Prefixed_Name(dogontowl, "RewindStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RinseHoldStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RinseHoldStateValue">http://elite.polito.it/ontologies/dogont.owl#RinseHoldStateValue</seealso>
    let RinseHoldStateValue =
        Prefixed_Name(dogontowl, "RinseHoldStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room of the building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Room"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Room">http://elite.polito.it/ontologies/dogont.owl#Room</seealso>
    let Room = Prefixed_Name(dogontowl, "Room") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#RunState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RunState">http://elite.polito.it/ontologies/dogont.owl#RunState</seealso>
    let RunState = Prefixed_Name(dogontowl, "RunState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#RunningStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#RunningStateValue">http://elite.polito.it/ontologies/dogont.owl#RunningStateValue</seealso>
    let RunningStateValue =
        Prefixed_Name(dogontowl, "RunningStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SanitaryFixtures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All the fixtures of a bathroom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SanitaryFixtures"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SanitaryFixtures">http://elite.polito.it/ontologies/dogont.owl#SanitaryFixtures</seealso>
    let SanitaryFixtures = Prefixed_Name(dogontowl, "SanitaryFixtures") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SaturationStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SaturationStateValue">http://elite.polito.it/ontologies/dogont.owl#SaturationStateValue</seealso>
    let SaturationStateValue =
        Prefixed_Name(dogontowl, "SaturationStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SceneFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Derives from the general cluster functionalities defined in ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SceneFunctionality">http://elite.polito.it/ontologies/dogont.owl#SceneFunctionality</seealso>
    let SceneFunctionality =
        Prefixed_Name(dogontowl, "SceneFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SceneNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Derives from the general cluster functionalities defined in ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SceneNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SceneNotificationFunctionality</seealso>
    let SceneNotificationFunctionality =
        Prefixed_Name(dogontowl, "SceneNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SceneSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Scene Selector device is capable of setting up and selecting scenes on other devices, including group of devices. It derives from ZigBee HA specifications."</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SceneSelector">http://elite.polito.it/ontologies/dogont.owl#SceneSelector</seealso>
    let SceneSelector = Prefixed_Name(dogontowl, "SceneSelector") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#SecuritySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Security system for detecting dangerous situation and intrusion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SecuritySystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SecuritySystem">http://elite.polito.it/ontologies/dogont.owl#SecuritySystem</seealso>
    let SecuritySystem = Prefixed_Name(dogontowl, "SecuritySystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SelectSourceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SelectSourceCommand">http://elite.polito.it/ontologies/dogont.owl#SelectSourceCommand</seealso>
    let SelectSourceCommand =
        Prefixed_Name(dogontowl, "SelectSourceCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SelfClosingDoorActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SelfClosingDoorActuator">http://elite.polito.it/ontologies/dogont.owl#SelfClosingDoorActuator</seealso>
    let SelfClosingDoorActuator =
        Prefixed_Name(dogontowl, "SelfClosingDoorActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SensingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SensingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SensingNotificationFunctionality</seealso>
    let SensingNotificationFunctionality =
        Prefixed_Name(dogontowl, "SensingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SensingState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SensingState">http://elite.polito.it/ontologies/dogont.owl#SensingState</seealso>
    let SensingState = Prefixed_Name(dogontowl, "SensingState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class for grouping all electrically powered sensors"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Sensor">http://elite.polito.it/ontologies/dogont.owl#Sensor</seealso>
    let Sensor = Prefixed_Name(dogontowl, "Sensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetChannelCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetChannelCommand">http://elite.polito.it/ontologies/dogont.owl#SetChannelCommand</seealso>
    let SetChannelCommand =
        Prefixed_Name(dogontowl, "SetChannelCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetClimateScheduleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetClimateScheduleCommand">http://elite.polito.it/ontologies/dogont.owl#SetClimateScheduleCommand</seealso>
    let SetClimateScheduleCommand =
        Prefixed_Name(dogontowl, "SetClimateScheduleCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetColorHSBCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetColorHSBCommand">http://elite.polito.it/ontologies/dogont.owl#SetColorHSBCommand</seealso>
    let SetColorHSBCommand =
        Prefixed_Name(dogontowl, "SetColorHSBCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetColorRGBCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetColorRGBCommand">http://elite.polito.it/ontologies/dogont.owl#SetColorRGBCommand</seealso>
    let SetColorRGBCommand =
        Prefixed_Name(dogontowl, "SetColorRGBCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetCommand">http://elite.polito.it/ontologies/dogont.owl#SetCommand</seealso>
    let SetCommand = Prefixed_Name(dogontowl, "SetCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetDailyClimateScheduleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetDailyClimateScheduleCommand">http://elite.polito.it/ontologies/dogont.owl#SetDailyClimateScheduleCommand</seealso>
    let SetDailyClimateScheduleCommand =
        Prefixed_Name(dogontowl, "SetDailyClimateScheduleCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetDesiredTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetDesiredTemperature">http://elite.polito.it/ontologies/dogont.owl#SetDesiredTemperature</seealso>
    let SetDesiredTemperature =
        Prefixed_Name(dogontowl, "SetDesiredTemperature") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetEndTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetEndTimeCommand">http://elite.polito.it/ontologies/dogont.owl#SetEndTimeCommand</seealso>
    let SetEndTimeCommand =
        Prefixed_Name(dogontowl, "SetEndTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetHourCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetHourCommand">http://elite.polito.it/ontologies/dogont.owl#SetHourCommand</seealso>
    let SetHourCommand = Prefixed_Name(dogontowl, "SetHourCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetMinutesCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetMinutesCommand">http://elite.polito.it/ontologies/dogont.owl#SetMinutesCommand</seealso>
    let SetMinutesCommand =
        Prefixed_Name(dogontowl, "SetMinutesCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetRemainingTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetRemainingTimeCommand">http://elite.polito.it/ontologies/dogont.owl#SetRemainingTimeCommand</seealso>
    let SetRemainingTimeCommand =
        Prefixed_Name(dogontowl, "SetRemainingTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetSecondsCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetSecondsCommand">http://elite.polito.it/ontologies/dogont.owl#SetSecondsCommand</seealso>
    let SetSecondsCommand =
        Prefixed_Name(dogontowl, "SetSecondsCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetSpeedCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetSpeedCommand">http://elite.polito.it/ontologies/dogont.owl#SetSpeedCommand</seealso>
    let SetSpeedCommand = Prefixed_Name(dogontowl, "SetSpeedCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetStartTimeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetStartTimeCommand">http://elite.polito.it/ontologies/dogont.owl#SetStartTimeCommand</seealso>
    let SetStartTimeCommand =
        Prefixed_Name(dogontowl, "SetStartTimeCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetTimeoutCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetTimeoutCommand">http://elite.polito.it/ontologies/dogont.owl#SetTimeoutCommand</seealso>
    let SetTimeoutCommand =
        Prefixed_Name(dogontowl, "SetTimeoutCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SetVolumeCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SetVolumeCommand">http://elite.polito.it/ontologies/dogont.owl#SetVolumeCommand</seealso>
    let SetVolumeCommand = Prefixed_Name(dogontowl, "SetVolumeCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Shade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Shade object, the name includes an underscore sign only for distinguishing the name from the shade actuator, whose name is directly mapped from ZigBee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Shade">http://elite.polito.it/ontologies/dogont.owl#Shade</seealso>
    let Shade = Prefixed_Name(dogontowl, "Shade") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ShadeActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Shade Actuator device provides the ability to open or close window coverings, including setting partially open or partially closed states. This device type includes roller shades, drapes and tilt-only blinds actuators. Derives from ZigBee HA specifications (Shade device)"</para>
    /// labels<para>"Shade"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShadeActuator">http://elite.polito.it/ontologies/dogont.owl#ShadeActuator</seealso>
    let ShadeActuator = Prefixed_Name(dogontowl, "ShadeActuator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ShadeController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Shade Controller device can control the level of a shade, derives from ZigBee HA specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShadeController">http://elite.polito.it/ontologies/dogont.owl#ShadeController</seealso>
    let ShadeController = Prefixed_Name(dogontowl, "ShadeController") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ShadeState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShadeState">http://elite.polito.it/ontologies/dogont.owl#ShadeState</seealso>
    let ShadeState = Prefixed_Name(dogontowl, "ShadeState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ShadeStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Value for the Shade position state, the shade position can be expressed as position=closedLimitx(255-level)/255, where with level 0 the shade is closed and with level 255 the shade is completely open. Derives from ZigBee HA specifications."</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShadeStateValue">http://elite.polito.it/ontologies/dogont.owl#ShadeStateValue</seealso>
    let ShadeStateValue = Prefixed_Name(dogontowl, "ShadeStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Shower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plumbing fixture that sprays water over you"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Shower"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Shower">http://elite.polito.it/ontologies/dogont.owl#Shower</seealso>
    let Shower = Prefixed_Name(dogontowl, "Shower") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Shutter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hinged cover or screen for a window, usually fitted with louvers."</para>
    /// labels<para>"Shutter"</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Shutter">http://elite.polito.it/ontologies/dogont.owl#Shutter</seealso>
    let Shutter = Prefixed_Name(dogontowl, "Shutter") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ShutterActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mechanism that allow automatic control about shutter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ShutterActuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShutterActuator">http://elite.polito.it/ontologies/dogont.owl#ShutterActuator</seealso>
    let ShutterActuator = Prefixed_Name(dogontowl, "ShutterActuator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ShutterButton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShutterButton">http://elite.polito.it/ontologies/dogont.owl#ShutterButton</seealso>
    let ShutterButton = Prefixed_Name(dogontowl, "ShutterButton") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShutterRegulationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionalities for the regulation of shutter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ShutterRegulationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShutterRegulationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ShutterRegulationFunctionality</seealso>
    let ShutterRegulationFunctionality =
        Prefixed_Name(dogontowl, "ShutterRegulationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ShutterState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ShutterState">http://elite.polito.it/ontologies/dogont.owl#ShutterState</seealso>
    let ShutterState = Prefixed_Name(dogontowl, "ShutterState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#SimpleLamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Simple lamp that can be just turn on or turn off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SimpleLamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SimpleLamp">http://elite.polito.it/ontologies/dogont.owl#SimpleLamp</seealso>
    let SimpleLamp = Prefixed_Name(dogontowl, "SimpleLamp") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SimpleLevelNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Notification functionality for controlling continuously adjustable device, e.g. dimmers, derives from ZigBee Home Automation specifications"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SimpleLevelNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SimpleLevelNotificationFunctionality</seealso>
    let SimpleLevelNotificationFunctionality =
        Prefixed_Name(dogontowl, "SimpleLevelNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SimpleMovementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SimpleMovementNotification">http://elite.polito.it/ontologies/dogont.owl#SimpleMovementNotification</seealso>
    let SimpleMovementNotification =
        Prefixed_Name(dogontowl, "SimpleMovementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SimpleNoMovementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SimpleNoMovementNotification">http://elite.polito.it/ontologies/dogont.owl#SimpleNoMovementNotification</seealso>
    let SimpleNoMovementNotification =
        Prefixed_Name(dogontowl, "SimpleNoMovementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleBed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleBed">http://elite.polito.it/ontologies/dogont.owl#SingleBed</seealso>
    let SingleBed = Prefixed_Name(dogontowl, "SingleBed") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#SingleFlowSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Flow  Sensor device measures and periodically reports the flow rate of a liquid (typically water)"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleFlowSensor">http://elite.polito.it/ontologies/dogont.owl#SingleFlowSensor</seealso>
    let SingleFlowSensor = Prefixed_Name(dogontowl, "SingleFlowSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementFunctionality</seealso>
    let SinglePhaseActiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotification</seealso>
    let SinglePhaseActiveEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "SinglePhaseActiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeasurementNotificationFunctionality</seealso>
    let SinglePhaseActiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyMeter</seealso>
    let SinglePhaseActiveEnergyMeter =
        Prefixed_Name(dogontowl, "SinglePhaseActiveEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActiveEnergyState</seealso>
    let SinglePhaseActiveEnergyState =
        Prefixed_Name(dogontowl, "SinglePhaseActiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementFunctionality</seealso>
    let SinglePhaseActivePowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseActivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotification</seealso>
    let SinglePhaseActivePowerMeasurementNotification =
        Prefixed_Name(dogontowl, "SinglePhaseActivePowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementNotificationFunctionality</seealso>
    let SinglePhaseActivePowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseActivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeasurementState</seealso>
    let SinglePhaseActivePowerMeasurementState =
        Prefixed_Name(dogontowl, "SinglePhaseActivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseActivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseActivePowerMeter</seealso>
    let SinglePhaseActivePowerMeter =
        Prefixed_Name(dogontowl, "SinglePhaseActivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementFunctionality</seealso>
    let SinglePhaseApparentPowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseApparentPowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotification</seealso>
    let SinglePhaseApparentPowerMeasurementNotification =
        Prefixed_Name(dogontowl, "SinglePhaseApparentPowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementNotificationFunctionality</seealso>
    let SinglePhaseApparentPowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseApparentPowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeasurementState</seealso>
    let SinglePhaseApparentPowerMeasurementState =
        Prefixed_Name(dogontowl, "SinglePhaseApparentPowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseApparentPowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseApparentPowerMeter</seealso>
    let SinglePhaseApparentPowerMeter =
        Prefixed_Name(dogontowl, "SinglePhaseApparentPowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementFunctionality</seealso>
    let SinglePhaseCurrentMeasurementFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseCurrentMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotification</seealso>
    let SinglePhaseCurrentMeasurementNotification =
        Prefixed_Name(dogontowl, "SinglePhaseCurrentMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeasurementNotificationFunctionality</seealso>
    let SinglePhaseCurrentMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseCurrentMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentMeter</seealso>
    let SinglePhaseCurrentMeter =
        Prefixed_Name(dogontowl, "SinglePhaseCurrentMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseCurrentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseCurrentState</seealso>
    let SinglePhaseCurrentState =
        Prefixed_Name(dogontowl, "SinglePhaseCurrentState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseElectricityMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseElectricityMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseElectricityMeter</seealso>
    let SinglePhaseElectricityMeter =
        Prefixed_Name(dogontowl, "SinglePhaseElectricityMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseEnergyMeter</seealso>
    let SinglePhaseEnergyMeter =
        Prefixed_Name(dogontowl, "SinglePhaseEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementFunctionality</seealso>
    let SinglePhaseReactiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotification</seealso>
    let SinglePhaseReactiveEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "SinglePhaseReactiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let SinglePhaseReactiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactiveEnergyState</seealso>
    let SinglePhaseReactiveEnergyState =
        Prefixed_Name(dogontowl, "SinglePhaseReactiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementFunctionality</seealso>
    let SinglePhaseReactivePowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseReactivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotification</seealso>
    let SinglePhaseReactivePowerMeasurementNotification =
        Prefixed_Name(dogontowl, "SinglePhaseReactivePowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementNotificationFunctionality</seealso>
    let SinglePhaseReactivePowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseReactivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeasurementState</seealso>
    let SinglePhaseReactivePowerMeasurementState =
        Prefixed_Name(dogontowl, "SinglePhaseReactivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseReactivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseReactivePowerMeter</seealso>
    let SinglePhaseReactivePowerMeter =
        Prefixed_Name(dogontowl, "SinglePhaseReactivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementFunctionality</seealso>
    let SinglePhaseVoltageMeasurementFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseVoltageMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotification</seealso>
    let SinglePhaseVoltageMeasurementNotification =
        Prefixed_Name(dogontowl, "SinglePhaseVoltageMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeasurementNotificationFunctionality</seealso>
    let SinglePhaseVoltageMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "SinglePhaseVoltageMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeter">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageMeter</seealso>
    let SinglePhaseVoltageMeter =
        Prefixed_Name(dogontowl, "SinglePhaseVoltageMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SinglePhaseVoltageState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageState">http://elite.polito.it/ontologies/dogont.owl#SinglePhaseVoltageState</seealso>
    let SinglePhaseVoltageState =
        Prefixed_Name(dogontowl, "SinglePhaseVoltageState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleScenarioControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleScenarioControl">http://elite.polito.it/ontologies/dogont.owl#SingleScenarioControl</seealso>
    let SingleScenarioControl =
        Prefixed_Name(dogontowl, "SingleScenarioControl") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleTariffEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleTariffEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#SingleTariffEnergyMeter</seealso>
    let SingleTariffEnergyMeter =
        Prefixed_Name(dogontowl, "SingleTariffEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that detects the temperature of the atmosphere"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TemperatureSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleTemperatureSensor">http://elite.polito.it/ontologies/dogont.owl#SingleTemperatureSensor</seealso>
    let SingleTemperatureSensor =
        Prefixed_Name(dogontowl, "SingleTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleValuedFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Discrete functionalities with exactly one value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SingleValuedFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleValuedFunctionality">http://elite.polito.it/ontologies/dogont.owl#SingleValuedFunctionality</seealso>
    let SingleValuedFunctionality =
        Prefixed_Name(dogontowl, "SingleValuedFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SingleValuedNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Discrete notification with exactly one values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SingleValuedNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SingleValuedNotificationFunctionality</seealso>
    let SingleValuedNotificationFunctionality =
        Prefixed_Name(dogontowl, "SingleValuedNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Siren</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device in which compressed air or steam is driven against a rotating perforated disk to create a loud, often wailing sound as a signal or warning.
    ///
    /// An electronic device producing a similar sound as a signal or warning: a police car siren."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Siren"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Siren">http://elite.polito.it/ontologies/dogont.owl#Siren</seealso>
    let Siren = Prefixed_Name(dogontowl, "Siren") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#SmokeSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that detects the presence of smoke"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SmokeSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SmokeSensor">http://elite.polito.it/ontologies/dogont.owl#SmokeSensor</seealso>
    let SmokeSensor = Prefixed_Name(dogontowl, "SmokeSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#SnapshotCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SnapshotCamera">http://elite.polito.it/ontologies/dogont.owl#SnapshotCamera</seealso>
    let SnapshotCamera = Prefixed_Name(dogontowl, "SnapshotCamera") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Sofa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An upholstered seat for more than one person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sofa"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Sofa">http://elite.polito.it/ontologies/dogont.owl#Sofa</seealso>
    let Sofa = Prefixed_Name(dogontowl, "Sofa") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SoundFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plays a Sound (default, or selected through a goTotrack, or...)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SoundFunctionality">http://elite.polito.it/ontologies/dogont.owl#SoundFunctionality</seealso>
    let SoundFunctionality =
        Prefixed_Name(dogontowl, "SoundFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SourceSelectionFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionFunctionality">http://elite.polito.it/ontologies/dogont.owl#SourceSelectionFunctionality</seealso>
    let SourceSelectionFunctionality =
        Prefixed_Name(dogontowl, "SourceSelectionFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SourceSelectionNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotification">http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotification</seealso>
    let SourceSelectionNotification =
        Prefixed_Name(dogontowl, "SourceSelectionNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SourceSelectionNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SourceSelectionNotificationFunctionality</seealso>
    let SourceSelectionNotificationFunctionality =
        Prefixed_Name(dogontowl, "SourceSelectionNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SourceSelectionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SourceSelectionState">http://elite.polito.it/ontologies/dogont.owl#SourceSelectionState</seealso>
    let SourceSelectionState =
        Prefixed_Name(dogontowl, "SourceSelectionState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedControlNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedControlNotification">http://elite.polito.it/ontologies/dogont.owl#SpeedControlNotification</seealso>
    let SpeedControlNotification =
        Prefixed_Name(dogontowl, "SpeedControlNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedDownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedDownCommand">http://elite.polito.it/ontologies/dogont.owl#SpeedDownCommand</seealso>
    let SpeedDownCommand = Prefixed_Name(dogontowl, "SpeedDownCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SpeedNotificationFunctionality</seealso>
    let SpeedNotificationFunctionality =
        Prefixed_Name(dogontowl, "SpeedNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedStepDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedStepDownNotification">http://elite.polito.it/ontologies/dogont.owl#SpeedStepDownNotification</seealso>
    let SpeedStepDownNotification =
        Prefixed_Name(dogontowl, "SpeedStepDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedStepUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedStepUpNotification">http://elite.polito.it/ontologies/dogont.owl#SpeedStepUpNotification</seealso>
    let SpeedStepUpNotification =
        Prefixed_Name(dogontowl, "SpeedStepUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SpeedUpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SpeedUpCommand">http://elite.polito.it/ontologies/dogont.owl#SpeedUpCommand</seealso>
    let SpeedUpCommand = Prefixed_Name(dogontowl, "SpeedUpCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#StandBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StandBy">http://elite.polito.it/ontologies/dogont.owl#StandBy</seealso>
    let StandBy = Prefixed_Name(dogontowl, "StandBy") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StandByNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StandByNotification">http://elite.polito.it/ontologies/dogont.owl#StandByNotification</seealso>
    let StandByNotification =
        Prefixed_Name(dogontowl, "StandByNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StandByOnOffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StandByOnOffState">http://elite.polito.it/ontologies/dogont.owl#StandByOnOffState</seealso>
    let StandByOnOffState =
        Prefixed_Name(dogontowl, "StandByOnOffState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StandByStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StandByStateValue">http://elite.polito.it/ontologies/dogont.owl#StandByStateValue</seealso>
    let StandByStateValue =
        Prefixed_Name(dogontowl, "StandByStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartApplianceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartApplianceNotification">http://elite.polito.it/ontologies/dogont.owl#StartApplianceNotification</seealso>
    let StartApplianceNotification =
        Prefixed_Name(dogontowl, "StartApplianceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartCommand">http://elite.polito.it/ontologies/dogont.owl#StartCommand</seealso>
    let StartCommand = Prefixed_Name(dogontowl, "StartCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartDiscoveryCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartDiscoveryCommand">http://elite.polito.it/ontologies/dogont.owl#StartDiscoveryCommand</seealso>
    let StartDiscoveryCommand =
        Prefixed_Name(dogontowl, "StartDiscoveryCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartPushLinkAuthenticationCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartPushLinkAuthenticationCommand">http://elite.polito.it/ontologies/dogont.owl#StartPushLinkAuthenticationCommand</seealso>
    let StartPushLinkAuthenticationCommand =
        Prefixed_Name(dogontowl, "StartPushLinkAuthenticationCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartStopPauseFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A functionality describing the ability of a device, tipically an appliance, to start, stop or pause its current cycle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartStopPauseFunctionality">http://elite.polito.it/ontologies/dogont.owl#StartStopPauseFunctionality</seealso>
    let StartStopPauseFunctionality =
        Prefixed_Name(dogontowl, "StartStopPauseFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartStopPauseNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartStopPauseNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#StartStopPauseNotificationFunctionality</seealso>
    let StartStopPauseNotificationFunctionality =
        Prefixed_Name(dogontowl, "StartStopPauseNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartSuperFreezingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartSuperFreezingCommand">http://elite.polito.it/ontologies/dogont.owl#StartSuperFreezingCommand</seealso>
    let StartSuperFreezingCommand =
        Prefixed_Name(dogontowl, "StartSuperFreezingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartSuperHeatingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartSuperHeatingCommand">http://elite.polito.it/ontologies/dogont.owl#StartSuperHeatingCommand</seealso>
    let StartSuperHeatingCommand =
        Prefixed_Name(dogontowl, "StartSuperHeatingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartSupercoolingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartSupercoolingCommand">http://elite.polito.it/ontologies/dogont.owl#StartSupercoolingCommand</seealso>
    let StartSupercoolingCommand =
        Prefixed_Name(dogontowl, "StartSupercoolingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartTimeChangedNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartTimeChangedNotification">http://elite.polito.it/ontologies/dogont.owl#StartTimeChangedNotification</seealso>
    let StartTimeChangedNotification =
        Prefixed_Name(dogontowl, "StartTimeChangedNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedHeatingCycleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedHeatingCycleNotification">http://elite.polito.it/ontologies/dogont.owl#StartedHeatingCycleNotification</seealso>
    let StartedHeatingCycleNotification =
        Prefixed_Name(dogontowl, "StartedHeatingCycleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedSuperCoolingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperCoolingNotification">http://elite.polito.it/ontologies/dogont.owl#StartedSuperCoolingNotification</seealso>
    let StartedSuperCoolingNotification =
        Prefixed_Name(dogontowl, "StartedSuperCoolingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedSuperFreezingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperFreezingNotification">http://elite.polito.it/ontologies/dogont.owl#StartedSuperFreezingNotification</seealso>
    let StartedSuperFreezingNotification =
        Prefixed_Name(dogontowl, "StartedSuperFreezingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedSuperHeatingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedSuperHeatingNotification">http://elite.polito.it/ontologies/dogont.owl#StartedSuperHeatingNotification</seealso>
    let StartedSuperHeatingNotification =
        Prefixed_Name(dogontowl, "StartedSuperHeatingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StartedWashingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StartedWashingNotification">http://elite.polito.it/ontologies/dogont.owl#StartedWashingNotification</seealso>
    let StartedWashingNotification =
        Prefixed_Name(dogontowl, "StartedWashingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models the states of the controllable objects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#State">http://elite.polito.it/ontologies/dogont.owl#State</seealso>
    let State = Prefixed_Name(dogontowl, "State") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#StateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"State value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StateValue">http://elite.polito.it/ontologies/dogont.owl#StateValue</seealso>
    let StateValue = Prefixed_Name(dogontowl, "StateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#StepDownCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StepDownCommand">http://elite.polito.it/ontologies/dogont.owl#StepDownCommand</seealso>
    let StepDownCommand = Prefixed_Name(dogontowl, "StepDownCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StepFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StepFunctionality">http://elite.polito.it/ontologies/dogont.owl#StepFunctionality</seealso>
    let StepFunctionality =
        Prefixed_Name(dogontowl, "StepFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StepShutterActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StepShutterActuator">http://elite.polito.it/ontologies/dogont.owl#StepShutterActuator</seealso>
    let StepShutterActuator =
        Prefixed_Name(dogontowl, "StepShutterActuator") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StepUpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StepUpCommand">http://elite.polito.it/ontologies/dogont.owl#StepUpCommand</seealso>
    let StepUpCommand = Prefixed_Name(dogontowl, "StepUpCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopApplianceNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopApplianceNotification">http://elite.polito.it/ontologies/dogont.owl#StopApplianceNotification</seealso>
    let StopApplianceNotification =
        Prefixed_Name(dogontowl, "StopApplianceNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopCommand">http://elite.polito.it/ontologies/dogont.owl#StopCommand</seealso>
    let StopCommand = Prefixed_Name(dogontowl, "StopCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopDiscoveryCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopDiscoveryCommand">http://elite.polito.it/ontologies/dogont.owl#StopDiscoveryCommand</seealso>
    let StopDiscoveryCommand =
        Prefixed_Name(dogontowl, "StopDiscoveryCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopHeatingCoolingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingCommand">http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingCommand</seealso>
    let StopHeatingCoolingCommand =
        Prefixed_Name(dogontowl, "StopHeatingCoolingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopHeatingCoolingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingNotification">http://elite.polito.it/ontologies/dogont.owl#StopHeatingCoolingNotification</seealso>
    let StopHeatingCoolingNotification =
        Prefixed_Name(dogontowl, "StopHeatingCoolingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopPlaybackNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopPlaybackNotification">http://elite.polito.it/ontologies/dogont.owl#StopPlaybackNotification</seealso>
    let StopPlaybackNotification =
        Prefixed_Name(dogontowl, "StopPlaybackNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopPlayingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopPlayingCommand">http://elite.polito.it/ontologies/dogont.owl#StopPlayingCommand</seealso>
    let StopPlayingCommand =
        Prefixed_Name(dogontowl, "StopPlayingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopPushLinkAuthenticationCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopPushLinkAuthenticationCommand">http://elite.polito.it/ontologies/dogont.owl#StopPushLinkAuthenticationCommand</seealso>
    let StopPushLinkAuthenticationCommand =
        Prefixed_Name(dogontowl, "StopPushLinkAuthenticationCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopStateValue">http://elite.polito.it/ontologies/dogont.owl#StopStateValue</seealso>
    let StopStateValue = Prefixed_Name(dogontowl, "StopStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopSuperFreezingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopSuperFreezingCommand">http://elite.polito.it/ontologies/dogont.owl#StopSuperFreezingCommand</seealso>
    let StopSuperFreezingCommand =
        Prefixed_Name(dogontowl, "StopSuperFreezingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopSuperHeatingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopSuperHeatingCommand">http://elite.polito.it/ontologies/dogont.owl#StopSuperHeatingCommand</seealso>
    let StopSuperHeatingCommand =
        Prefixed_Name(dogontowl, "StopSuperHeatingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StopSupercoolingCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StopSupercoolingCommand">http://elite.polito.it/ontologies/dogont.owl#StopSupercoolingCommand</seealso>
    let StopSupercoolingCommand =
        Prefixed_Name(dogontowl, "StopSupercoolingCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedHeatingCycleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedHeatingCycleNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedHeatingCycleNotification</seealso>
    let StoppedHeatingCycleNotification =
        Prefixed_Name(dogontowl, "StoppedHeatingCycleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedSuperCoolingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperCoolingNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedSuperCoolingNotification</seealso>
    let StoppedSuperCoolingNotification =
        Prefixed_Name(dogontowl, "StoppedSuperCoolingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedSuperFreezingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperFreezingNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedSuperFreezingNotification</seealso>
    let StoppedSuperFreezingNotification =
        Prefixed_Name(dogontowl, "StoppedSuperFreezingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedSuperHeatingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedSuperHeatingNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedSuperHeatingNotification</seealso>
    let StoppedSuperHeatingNotification =
        Prefixed_Name(dogontowl, "StoppedSuperHeatingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoppedWashingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoppedWashingNotification">http://elite.polito.it/ontologies/dogont.owl#StoppedWashingNotification</seealso>
    let StoppedWashingNotification =
        Prefixed_Name(dogontowl, "StoppedWashingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StorageRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Little Room for storage of things in the house"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StorageRoom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StorageRoom">http://elite.polito.it/ontologies/dogont.owl#StorageRoom</seealso>
    let StorageRoom = Prefixed_Name(dogontowl, "StorageRoom") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoreGroupCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoreGroupCommand">http://elite.polito.it/ontologies/dogont.owl#StoreGroupCommand</seealso>
    let StoreGroupCommand =
        Prefixed_Name(dogontowl, "StoreGroupCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoreSceneCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoreSceneCommand">http://elite.polito.it/ontologies/dogont.owl#StoreSceneCommand</seealso>
    let StoreSceneCommand =
        Prefixed_Name(dogontowl, "StoreSceneCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#StoreSceneNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#StoreSceneNotification">http://elite.polito.it/ontologies/dogont.owl#StoreSceneNotification</seealso>
    let StoreSceneNotification =
        Prefixed_Name(dogontowl, "StoreSceneNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Storey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Storey">http://elite.polito.it/ontologies/dogont.owl#Storey</seealso>
    let Storey = Prefixed_Name(dogontowl, "Storey") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Stove</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Heating apparatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stove"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Stove">http://elite.polito.it/ontologies/dogont.owl#Stove</seealso>
    let Stove = Prefixed_Name(dogontowl, "Stove") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperCoolingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A functionality describing the ability of the device to start/stop a super cooling cycle (typical of fridges, freezers and refrigerators). This functionality is defined in the energy@home zigbee extension and in the EN50523 specification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperCoolingFunctionality</seealso>
    let SuperCoolingFunctionality =
        Prefixed_Name(dogontowl, "SuperCoolingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperCoolingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotification">http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotification</seealso>
    let SuperCoolingNotification =
        Prefixed_Name(dogontowl, "SuperCoolingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperCoolingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperCoolingNotificationFunctionality</seealso>
    let SuperCoolingNotificationFunctionality =
        Prefixed_Name(dogontowl, "SuperCoolingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperCoolingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperCoolingStateValue">http://elite.polito.it/ontologies/dogont.owl#SuperCoolingStateValue</seealso>
    let SuperCoolingStateValue =
        Prefixed_Name(dogontowl, "SuperCoolingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperFreezingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the ability of a device to start/stop a super freezing cycle, tipically defined for fridges, refrigerators and freezers. Derives from the energy@home zigbee extension and from the EN50523 standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperFreezingFunctionality</seealso>
    let SuperFreezingFunctionality =
        Prefixed_Name(dogontowl, "SuperFreezingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperFreezingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotification">http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotification</seealso>
    let SuperFreezingNotification =
        Prefixed_Name(dogontowl, "SuperFreezingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperFreezingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperFreezingNotificationFunctionality</seealso>
    let SuperFreezingNotificationFunctionality =
        Prefixed_Name(dogontowl, "SuperFreezingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperFreezingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperFreezingStateValue">http://elite.polito.it/ontologies/dogont.owl#SuperFreezingStateValue</seealso>
    let SuperFreezingStateValue =
        Prefixed_Name(dogontowl, "SuperFreezingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperHeatingFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperHeatingFunctionality</seealso>
    let SuperHeatingFunctionality =
        Prefixed_Name(dogontowl, "SuperHeatingFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperHeatingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotification">http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotification</seealso>
    let SuperHeatingNotification =
        Prefixed_Name(dogontowl, "SuperHeatingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperHeatingNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#SuperHeatingNotificationFunctionality</seealso>
    let SuperHeatingNotificationFunctionality =
        Prefixed_Name(dogontowl, "SuperHeatingNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SuperHeatingStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SuperHeatingStateValue">http://elite.polito.it/ontologies/dogont.owl#SuperHeatingStateValue</seealso>
    let SuperHeatingStateValue =
        Prefixed_Name(dogontowl, "SuperHeatingStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#SurveillanceCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Camera of video surveillance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SurveillanceCamera"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#SurveillanceCamera">http://elite.polito.it/ontologies/dogont.owl#SurveillanceCamera</seealso>
    let SurveillanceCamera =
        Prefixed_Name(dogontowl, "SurveillanceCamera") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Switch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bi-stable control consisting of a mechanical or electrical or electronic device for making or breaking or changing the connections in a circuit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Switch"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Switch">http://elite.polito.it/ontologies/dogont.owl#Switch</seealso>
    let Switch = Prefixed_Name(dogontowl, "Switch") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of furniture having a smooth flat top that is usually supported by one or more vertical legs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Table"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Table">http://elite.polito.it/ontologies/dogont.owl#Table</seealso>
    let Table = Prefixed_Name(dogontowl, "Table") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Tape1StateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Tape1StateValue">http://elite.polito.it/ontologies/dogont.owl#Tape1StateValue</seealso>
    let Tape1StateValue = Prefixed_Name(dogontowl, "Tape1StateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Tape2StateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Tape2StateValue">http://elite.polito.it/ontologies/dogont.owl#Tape2StateValue</seealso>
    let Tape2StateValue = Prefixed_Name(dogontowl, "Tape2StateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureAndHumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureAndHumiditySensor">http://elite.polito.it/ontologies/dogont.owl#TemperatureAndHumiditySensor</seealso>
    let TemperatureAndHumiditySensor =
        Prefixed_Name(dogontowl, "TemperatureAndHumiditySensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The capability of measuring temperatures"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementFunctionality</seealso>
    let TemperatureMeasurementFunctionality =
        Prefixed_Name(dogontowl, "TemperatureMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureMeasurementMNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementMNotification">http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementMNotification</seealso>
    let TemperatureMeasurementMNotification =
        Prefixed_Name(dogontowl, "TemperatureMeasurementMNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotification</seealso>
    let TemperatureMeasurementNotification =
        Prefixed_Name(dogontowl, "TemperatureMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Notifies the measurment of a temperature, through a proper temperature sensor"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TemperatureMeasurementNotificationFunctionality</seealso>
    let TemperatureMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "TemperatureMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureSensor">http://elite.polito.it/ontologies/dogont.owl#TemperatureSensor</seealso>
    let TemperatureSensor =
        Prefixed_Name(dogontowl, "TemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models the temperature value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TemperatureState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureState">http://elite.polito.it/ontologies/dogont.owl#TemperatureState</seealso>
    let TemperatureState = Prefixed_Name(dogontowl, "TemperatureState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TemperatureStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TemperatureStateValue">http://elite.polito.it/ontologies/dogont.owl#TemperatureStateValue</seealso>
    let TemperatureStateValue =
        Prefixed_Name(dogontowl, "TemperatureStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Terrace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Outdoor area adjoining a residence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Terrace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Terrace">http://elite.polito.it/ontologies/dogont.owl#Terrace</seealso>
    let Terrace = Prefixed_Name(dogontowl, "Terrace") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TexasInstrumentsComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsComponent">http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsComponent</seealso>
    let TexasInstrumentsComponent =
        Prefixed_Name(dogontowl, "TexasInstrumentsComponent") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TexasInstrumentsGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsGateway">http://elite.polito.it/ontologies/dogont.owl#TexasInstrumentsGateway</seealso>
    let TexasInstrumentsGateway =
        Prefixed_Name(dogontowl, "TexasInstrumentsGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Thermostat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Thermostat">http://elite.polito.it/ontologies/dogont.owl#Thermostat</seealso>
    let Thermostat = Prefixed_Name(dogontowl, "Thermostat") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThermostatControlFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionalities for the regulation of temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TemperatureRegulationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThermostatControlFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThermostatControlFunctionality</seealso>
    let ThermostatControlFunctionality =
        Prefixed_Name(dogontowl, "ThermostatControlFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThermostatNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The thermostat request notification, requires a device having the thermostat control functionality to increase, set or decrease the current temperature. Derives from ZigBee HA (slightly modified...)"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThermostatNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThermostatNotificationFunctionality</seealso>
    let ThermostatNotificationFunctionality =
        Prefixed_Name(dogontowl, "ThermostatNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThermostatQueryFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThermostatQueryFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThermostatQueryFunctionality</seealso>
    let ThermostatQueryFunctionality =
        Prefixed_Name(dogontowl, "ThermostatQueryFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThermostaticRadiatorValve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThermostaticRadiatorValve">http://elite.polito.it/ontologies/dogont.owl#ThermostaticRadiatorValve</seealso>
    let ThermostaticRadiatorValve =
        Prefixed_Name(dogontowl, "ThermostaticRadiatorValve") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementFunctionality</seealso>
    let ThreePhaseActiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseActiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotification</seealso>
    let ThreePhaseActiveEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "ThreePhaseActiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyMeasurementNotificationFunctionality</seealso>
    let ThreePhaseActiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseActiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActiveEnergyState</seealso>
    let ThreePhaseActiveEnergyState =
        Prefixed_Name(dogontowl, "ThreePhaseActiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementFunctionality</seealso>
    let ThreePhaseActivePowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseActivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotification</seealso>
    let ThreePhaseActivePowerMeasurementNotification =
        Prefixed_Name(dogontowl, "ThreePhaseActivePowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementNotificationFunctionality</seealso>
    let ThreePhaseActivePowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseActivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeasurementState</seealso>
    let ThreePhaseActivePowerMeasurementState =
        Prefixed_Name(dogontowl, "ThreePhaseActivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseActivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseActivePowerMeter</seealso>
    let ThreePhaseActivePowerMeter =
        Prefixed_Name(dogontowl, "ThreePhaseActivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementFunctionality</seealso>
    let ThreePhaseApparentPowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseApparentPowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotification</seealso>
    let ThreePhaseApparentPowerMeasurementNotification =
        Prefixed_Name(dogontowl, "ThreePhaseApparentPowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementNotificationFunctionality</seealso>
    let ThreePhaseApparentPowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseApparentPowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeasurementState</seealso>
    let ThreePhaseApparentPowerMeasurementState =
        Prefixed_Name(dogontowl, "ThreePhaseApparentPowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseApparentPowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseApparentPowerMeter</seealso>
    let ThreePhaseApparentPowerMeter =
        Prefixed_Name(dogontowl, "ThreePhaseApparentPowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementFunctionality</seealso>
    let ThreePhaseCurrentMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseCurrentMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotification</seealso>
    let ThreePhaseCurrentMeasurementNotification =
        Prefixed_Name(dogontowl, "ThreePhaseCurrentMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeasurementNotificationFunctionality</seealso>
    let ThreePhaseCurrentMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseCurrentMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentMeter</seealso>
    let ThreePhaseCurrentMeter =
        Prefixed_Name(dogontowl, "ThreePhaseCurrentMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseCurrentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseCurrentState</seealso>
    let ThreePhaseCurrentState =
        Prefixed_Name(dogontowl, "ThreePhaseCurrentState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseElectricityMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseElectricityMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseElectricityMeter</seealso>
    let ThreePhaseElectricityMeter =
        Prefixed_Name(dogontowl, "ThreePhaseElectricityMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseEnergyMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseEnergyMeter</seealso>
    let ThreePhaseEnergyMeter =
        Prefixed_Name(dogontowl, "ThreePhaseEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseLLVoltageMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLLVoltageMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLLVoltageMeasurementNotification</seealso>
    let ThreePhaseLLVoltageMeasurementNotification =
        Prefixed_Name(dogontowl, "ThreePhaseLLVoltageMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseLNVoltageMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLNVoltageMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseLNVoltageMeasurementNotification</seealso>
    let ThreePhaseLNVoltageMeasurementNotification =
        Prefixed_Name(dogontowl, "ThreePhaseLNVoltageMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactiveEnergyMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementFunctionality</seealso>
    let ThreePhaseReactiveEnergyMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseReactiveEnergyMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactiveEnergyMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotification</seealso>
    let ThreePhaseReactiveEnergyMeasurementNotification =
        Prefixed_Name(dogontowl, "ThreePhaseReactiveEnergyMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyMeasurementNotificationFunctionality</seealso>
    let ThreePhaseReactiveEnergyMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseReactiveEnergyMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactiveEnergyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactiveEnergyState</seealso>
    let ThreePhaseReactiveEnergyState =
        Prefixed_Name(dogontowl, "ThreePhaseReactiveEnergyState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementFunctionality</seealso>
    let ThreePhaseReactivePowerMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseReactivePowerMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeasurementNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotification">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotification</seealso>
    let ThreePhaseReactivePowerMeasurementNotification =
        Prefixed_Name(dogontowl, "ThreePhaseReactivePowerMeasurementNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementNotificationFunctionality</seealso>
    let ThreePhaseReactivePowerMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseReactivePowerMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeasurementState</seealso>
    let ThreePhaseReactivePowerMeasurementState =
        Prefixed_Name(dogontowl, "ThreePhaseReactivePowerMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseReactivePowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseReactivePowerMeter</seealso>
    let ThreePhaseReactivePowerMeter =
        Prefixed_Name(dogontowl, "ThreePhaseReactivePowerMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseVoltageMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementFunctionality</seealso>
    let ThreePhaseVoltageMeasurementFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseVoltageMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseVoltageMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeasurementNotificationFunctionality</seealso>
    let ThreePhaseVoltageMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "ThreePhaseVoltageMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseVoltageMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeter">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageMeter</seealso>
    let ThreePhaseVoltageMeter =
        Prefixed_Name(dogontowl, "ThreePhaseVoltageMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ThreePhaseVoltageState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageState">http://elite.polito.it/ontologies/dogont.owl#ThreePhaseVoltageState</seealso>
    let ThreePhaseVoltageState =
        Prefixed_Name(dogontowl, "ThreePhaseVoltageState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TimeRegulationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionalities for the regulation of timer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TimeRegulationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TimeRegulationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TimeRegulationFunctionality</seealso>
    let TimeRegulationFunctionality =
        Prefixed_Name(dogontowl, "TimeRegulationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TimedOnCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TimedOnCommand">http://elite.polito.it/ontologies/dogont.owl#TimedOnCommand</seealso>
    let TimedOnCommand = Prefixed_Name(dogontowl, "TimedOnCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TimedOnFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionality to switch on an object for a given period of time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TimedOnFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TimedOnFunctionality">http://elite.polito.it/ontologies/dogont.owl#TimedOnFunctionality</seealso>
    let TimedOnFunctionality =
        Prefixed_Name(dogontowl, "TimedOnFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ToggleCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ToggleCommand">http://elite.polito.it/ontologies/dogont.owl#ToggleCommand</seealso>
    let ToggleCommand = Prefixed_Name(dogontowl, "ToggleCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ToggleFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ToggleFunctionality">http://elite.polito.it/ontologies/dogont.owl#ToggleFunctionality</seealso>
    let ToggleFunctionality =
        Prefixed_Name(dogontowl, "ToggleFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ToggleRelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ToggleRelay">http://elite.polito.it/ontologies/dogont.owl#ToggleRelay</seealso>
    let ToggleRelay = Prefixed_Name(dogontowl, "ToggleRelay") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TrackControlNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TrackControlNotification">http://elite.polito.it/ontologies/dogont.owl#TrackControlNotification</seealso>
    let TrackControlNotification =
        Prefixed_Name(dogontowl, "TrackControlNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TridimensionalAccelerationNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotification">http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotification</seealso>
    let TridimensionalAccelerationNotification =
        Prefixed_Name(dogontowl, "TridimensionalAccelerationNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TridimensionalAccelerationNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TridimensionalAccelerationNotificationFunctionality</seealso>
    let TridimensionalAccelerationNotificationFunctionality =
        Prefixed_Name(dogontowl, "TridimensionalAccelerationNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TripleSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TripleSensor">http://elite.polito.it/ontologies/dogont.owl#TripleSensor</seealso>
    let TripleSensor = Prefixed_Name(dogontowl, "TripleSensor") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TripleValuedFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Discrete functionalities with exactly three values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TripleValuedFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedFunctionality">http://elite.polito.it/ontologies/dogont.owl#TripleValuedFunctionality</seealso>
    let TripleValuedFunctionality =
        Prefixed_Name(dogontowl, "TripleValuedFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TripleValuedNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TripleValuedNotificationFunctionality</seealso>
    let TripleValuedNotificationFunctionality =
        Prefixed_Name(dogontowl, "TripleValuedNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TripleValuedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Discrete states with exactly three values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TripleValuedState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TripleValuedState">http://elite.polito.it/ontologies/dogont.owl#TripleValuedState</seealso>
    let TripleValuedState =
        Prefixed_Name(dogontowl, "TripleValuedState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TunerFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TunerFunctionality">http://elite.polito.it/ontologies/dogont.owl#TunerFunctionality</seealso>
    let TunerFunctionality =
        Prefixed_Name(dogontowl, "TunerFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TunerNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TunerNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#TunerNotificationFunctionality</seealso>
    let TunerNotificationFunctionality =
        Prefixed_Name(dogontowl, "TunerNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TunerState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TunerState">http://elite.polito.it/ontologies/dogont.owl#TunerState</seealso>
    let TunerState = Prefixed_Name(dogontowl, "TunerState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#TunerStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TunerStateValue">http://elite.polito.it/ontologies/dogont.owl#TunerStateValue</seealso>
    let TunerStateValue = Prefixed_Name(dogontowl, "TunerStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TuningStepDownNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TuningStepDownNotification">http://elite.polito.it/ontologies/dogont.owl#TuningStepDownNotification</seealso>
    let TuningStepDownNotification =
        Prefixed_Name(dogontowl, "TuningStepDownNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#TuningStepUpNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#TuningStepUpNotification">http://elite.polito.it/ontologies/dogont.owl#TuningStepUpNotification</seealso>
    let TuningStepUpNotification =
        Prefixed_Name(dogontowl, "TuningStepUpNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Tv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A receiver that displays television images"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tv"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Tv">http://elite.polito.it/ontologies/dogont.owl#Tv</seealso>
    let Tv = Prefixed_Name(dogontowl, "Tv") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#UnControllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"All building things that can't be controlled by domotic system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UnControllable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UnControllable">http://elite.polito.it/ontologies/dogont.owl#UnControllable</seealso>
    let UnControllable = Prefixed_Name(dogontowl, "UnControllable") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#UpCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpCommand">http://elite.polito.it/ontologies/dogont.owl#UpCommand</seealso>
    let UpCommand = Prefixed_Name(dogontowl, "UpCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpDownFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionality: up - down"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UpDownFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpDownFunctionality">http://elite.polito.it/ontologies/dogont.owl#UpDownFunctionality</seealso>
    let UpDownFunctionality =
        Prefixed_Name(dogontowl, "UpDownFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpDownNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpDownNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#UpDownNotificationFunctionality</seealso>
    let UpDownNotificationFunctionality =
        Prefixed_Name(dogontowl, "UpDownNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpDownRestFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionality: up - down - rest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UpDownRestFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpDownRestFunctionality">http://elite.polito.it/ontologies/dogont.owl#UpDownRestFunctionality</seealso>
    let UpDownRestFunctionality =
        Prefixed_Name(dogontowl, "UpDownRestFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpDownRestState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State: up - down - rest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UpDownRestState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpDownRestState">http://elite.polito.it/ontologies/dogont.owl#UpDownRestState</seealso>
    let UpDownRestState = Prefixed_Name(dogontowl, "UpDownRestState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#UpTripleStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#UpTripleStateValue">http://elite.polito.it/ontologies/dogont.owl#UpTripleStateValue</seealso>
    let UpTripleStateValue =
        Prefixed_Name(dogontowl, "UpTripleStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VentilatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VentilatingSystem">http://elite.polito.it/ontologies/dogont.owl#VentilatingSystem</seealso>
    let VentilatingSystem =
        Prefixed_Name(dogontowl, "VentilatingSystem") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Ventilator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device that circulates fresh air and expels stale or foul air."</para>
    /// labels<para>"Ventilator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Ventilator">http://elite.polito.it/ontologies/dogont.owl#Ventilator</seealso>
    let Ventilator = Prefixed_Name(dogontowl, "Ventilator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Vertical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The vertical architectural component of a building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vertical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Vertical">http://elite.polito.it/ontologies/dogont.owl#Vertical</seealso>
    let Vertical = Prefixed_Name(dogontowl, "Vertical") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VerticalMovementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VerticalMovementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#VerticalMovementNotificationFunctionality</seealso>
    let VerticalMovementNotificationFunctionality =
        Prefixed_Name(dogontowl, "VerticalMovementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VerticalNoMovementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VerticalNoMovementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#VerticalNoMovementNotificationFunctionality</seealso>
    let VerticalNoMovementNotificationFunctionality =
        Prefixed_Name(dogontowl, "VerticalNoMovementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoidCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoidCommand">http://elite.polito.it/ontologies/dogont.owl#VoidCommand</seealso>
    let VoidCommand = Prefixed_Name(dogontowl, "VoidCommand") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageMeasurementFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementFunctionality">http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementFunctionality</seealso>
    let VoltageMeasurementFunctionality =
        Prefixed_Name(dogontowl, "VoltageMeasurementFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementNotificationFunctionality</seealso>
    let VoltageMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "VoltageMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementState">http://elite.polito.it/ontologies/dogont.owl#VoltageMeasurementState</seealso>
    let VoltageMeasurementState =
        Prefixed_Name(dogontowl, "VoltageMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageMeter">http://elite.polito.it/ontologies/dogont.owl#VoltageMeter</seealso>
    let VoltageMeter = Prefixed_Name(dogontowl, "VoltageMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VoltageStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VoltageStateValue">http://elite.polito.it/ontologies/dogont.owl#VoltageStateValue</seealso>
    let VoltageStateValue =
        Prefixed_Name(dogontowl, "VoltageStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VolumeLevelState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models the volume value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VolumeLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VolumeLevelState">http://elite.polito.it/ontologies/dogont.owl#VolumeLevelState</seealso>
    let VolumeLevelState = Prefixed_Name(dogontowl, "VolumeLevelState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#VolumeRegulationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Functionalities for the regulation of volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VolumeRegulationFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#VolumeRegulationFunctionality">http://elite.polito.it/ontologies/dogont.owl#VolumeRegulationFunctionality</seealso>
    let VolumeRegulationFunctionality =
        Prefixed_Name(dogontowl, "VolumeRegulationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Wall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An architectural partition used to divide or enclose an area or to support another structure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wall"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Wall">http://elite.polito.it/ontologies/dogont.owl#Wall</seealso>
    let Wall = Prefixed_Name(dogontowl, "Wall") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#WallOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An opening in a Wall"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WallOpening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WallOpening">http://elite.polito.it/ontologies/dogont.owl#WallOpening</seealso>
    let WallOpening = Prefixed_Name(dogontowl, "WallOpening") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Wardrobe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tall piece of furniture that provides storage space for clothes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wardrobe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Wardrobe">http://elite.polito.it/ontologies/dogont.owl#Wardrobe</seealso>
    let Wardrobe = Prefixed_Name(dogontowl, "Wardrobe") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashRinseStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashRinseStateValue">http://elite.polito.it/ontologies/dogont.owl#WashRinseStateValue</seealso>
    let WashRinseStateValue =
        Prefixed_Name(dogontowl, "WashRinseStateValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#Washbasin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A basin for washing the hands"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Washbasin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Washbasin">http://elite.polito.it/ontologies/dogont.owl#Washbasin</seealso>
    let Washbasin = Prefixed_Name(dogontowl, "Washbasin") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashingApplianceState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashingApplianceState">http://elite.polito.it/ontologies/dogont.owl#WashingApplianceState</seealso>
    let WashingApplianceState =
        Prefixed_Name(dogontowl, "WashingApplianceState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashingCycleNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashingCycleNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#WashingCycleNotificationFunctionality</seealso>
    let WashingCycleNotificationFunctionality =
        Prefixed_Name(dogontowl, "WashingCycleNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashingMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A home appliance for washing clothes and linens automatically"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WashingMachine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashingMachine">http://elite.polito.it/ontologies/dogont.owl#WashingMachine</seealso>
    let WashingMachine = Prefixed_Name(dogontowl, "WashingMachine") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WashingNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WashingNotification">http://elite.polito.it/ontologies/dogont.owl#WashingNotification</seealso>
    let WashingNotification =
        Prefixed_Name(dogontowl, "WashingNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterCloset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plumbing fixture for defecation and urination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WaterCloset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterCloset">http://elite.polito.it/ontologies/dogont.owl#WaterCloset</seealso>
    let WaterCloset = Prefixed_Name(dogontowl, "WaterCloset") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterMeasurementFuctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementFuctionality">http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementFuctionality</seealso>
    let WaterMeasurementFuctionality =
        Prefixed_Name(dogontowl, "WaterMeasurementFuctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterMeasurementNotificationFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementNotificationFunctionality">http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementNotificationFunctionality</seealso>
    let WaterMeasurementNotificationFunctionality =
        Prefixed_Name(dogontowl, "WaterMeasurementNotificationFunctionality") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterMeasurementState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementState">http://elite.polito.it/ontologies/dogont.owl#WaterMeasurementState</seealso>
    let WaterMeasurementState =
        Prefixed_Name(dogontowl, "WaterMeasurementState") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WaterMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WaterMeter">http://elite.polito.it/ontologies/dogont.owl#WaterMeter</seealso>
    let WaterMeter = Prefixed_Name(dogontowl, "WaterMeter") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WeeklyClimateScheduleNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WeeklyClimateScheduleNotification">http://elite.polito.it/ontologies/dogont.owl#WeeklyClimateScheduleNotification</seealso>
    let WeeklyClimateScheduleNotification =
        Prefixed_Name(dogontowl, "WeeklyClimateScheduleNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#WhiteGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Major household appliances.
    ///
    /// It mus be noticed that the functionality modeling uses existential quantifiers for functionalities that can be optional, this is only for the sake of easier interpretation and should be improved in future releases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WhiteGoods"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WhiteGoods">http://elite.polito.it/ontologies/dogont.owl#WhiteGoods</seealso>
    let WhiteGoods = Prefixed_Name(dogontowl, "WhiteGoods") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#Window</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A framework that contains a glass windowpane and is built into a wall or roof to admit light or air"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Window"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#Window">http://elite.polito.it/ontologies/dogont.owl#Window</seealso>
    let Window = Prefixed_Name(dogontowl, "Window") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#WindowActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mechanism that allow automatic opening and closing about window"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WindowActuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WindowActuator">http://elite.polito.it/ontologies/dogont.owl#WindowActuator</seealso>
    let WindowActuator = Prefixed_Name(dogontowl, "WindowActuator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#WindowSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that controls if a window is closed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WindowSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WindowSensor">http://elite.polito.it/ontologies/dogont.owl#WindowSensor</seealso>
    let WindowSensor = Prefixed_Name(dogontowl, "WindowSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#WirelessPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Phone with no wire"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WirelessPhone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#WirelessPhone">http://elite.polito.it/ontologies/dogont.owl#WirelessPhone</seealso>
    let WirelessPhone = Prefixed_Name(dogontowl, "WirelessPhone") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ZWaveComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZWaveComponent">http://elite.polito.it/ontologies/dogont.owl#ZWaveComponent</seealso>
    let ZWaveComponent = Prefixed_Name(dogontowl, "ZWaveComponent") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ZWaveGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZWaveGateway">http://elite.polito.it/ontologies/dogont.owl#ZWaveGateway</seealso>
    let ZWaveGateway = Prefixed_Name(dogontowl, "ZWaveGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZWaveNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZWaveNotification">http://elite.polito.it/ontologies/dogont.owl#ZWaveNotification</seealso>
    let ZWaveNotification =
        Prefixed_Name(dogontowl, "ZWaveNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZWaveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZWaveProperty">http://elite.polito.it/ontologies/dogont.owl#ZWaveProperty</seealso>
    let ZWaveProperty = Prefixed_Name(dogontowl, "ZWaveProperty") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ZigBeeComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeComponent">http://elite.polito.it/ontologies/dogont.owl#ZigBeeComponent</seealso>
    let ZigBeeComponent = Prefixed_Name(dogontowl, "ZigBeeComponent") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ZigBeeGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeGateway">http://elite.polito.it/ontologies/dogont.owl#ZigBeeGateway</seealso>
    let ZigBeeGateway = Prefixed_Name(dogontowl, "ZigBeeGateway") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZigBeeNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZigBeeNotification">http://elite.polito.it/ontologies/dogont.owl#ZigBeeNotification</seealso>
    let ZigBeeNotification =
        Prefixed_Name(dogontowl, "ZigBeeNotification") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#ZoomInCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZoomInCommand">http://elite.polito.it/ontologies/dogont.owl#ZoomInCommand</seealso>
    let ZoomInCommand = Prefixed_Name(dogontowl, "ZoomInCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ZoomOutCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ZoomOutCommand">http://elite.polito.it/ontologies/dogont.owl#ZoomOutCommand</seealso>
    let ZoomOutCommand = Prefixed_Name(dogontowl, "ZoomOutCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#actuatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#actuatorOf">http://elite.polito.it/ontologies/dogont.owl#actuatorOf</seealso>
    let actuatorOf = Prefixed_Name(dogontowl, "actuatorOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#ceilingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#ceilingOf">http://elite.polito.it/ontologies/dogont.owl#ceilingOf</seealso>
    let ceilingOf = Prefixed_Name(dogontowl, "ceilingOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#commandOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#commandOf">http://elite.polito.it/ontologies/dogont.owl#commandOf</seealso>
    let commandOf = Prefixed_Name(dogontowl, "commandOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#commandParamName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#commandParamName">http://elite.polito.it/ontologies/dogont.owl#commandParamName</seealso>
    let commandParamName = Prefixed_Name(dogontowl, "commandParamName") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#commandParamValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#commandParamValue">http://elite.polito.it/ontologies/dogont.owl#commandParamValue</seealso>
    let commandParamValue =
        Prefixed_Name(dogontowl, "commandParamValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#connectionTimeOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time before the connection expires"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"connectionTimeOut"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#connectionTimeOut">http://elite.polito.it/ontologies/dogont.owl#connectionTimeOut</seealso>
    let connectionTimeOut =
        Prefixed_Name(dogontowl, "connectionTimeOut") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#connectionTrials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Number of connection trials before failure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"connectionTrials"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#connectionTrials">http://elite.polito.it/ontologies/dogont.owl#connectionTrials</seealso>
    let connectionTrials = Prefixed_Name(dogontowl, "connectionTrials") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates which object are contained in a building environment, e.g. the kitchen contains Lamp1,Lamp2..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#contains">http://elite.polito.it/ontologies/dogont.owl#contains</seealso>
    let contains = Prefixed_Name(dogontowl, "contains") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#controlledObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Association between a controller and the controlled object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"controlledObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#controlledObject">http://elite.polito.it/ontologies/dogont.owl#controlledObject</seealso>
    let controlledObject = Prefixed_Name(dogontowl, "controlledObject") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#datapoinId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ILON id of a given datapoint associated to the command or notification of a given echelon-managed device"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#datapoinId">http://elite.polito.it/ontologies/dogont.owl#datapoinId</seealso>
    let datapoinId = Prefixed_Name(dogontowl, "datapoinId") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#datapointAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#datapointAlias">http://elite.polito.it/ontologies/dogont.owl#datapointAlias</seealso>
    let datapointAlias = Prefixed_Name(dogontowl, "datapointAlias") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#eZ430Chronos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#eZ430Chronos">http://elite.polito.it/ontologies/dogont.owl#eZ430Chronos</seealso>
    let eZ430Chronos = Prefixed_Name(dogontowl, "eZ430Chronos") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#endpointAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The address (URL) of the web service endpoint at which the ILON100 server having this property offers data reading and writing services"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#endpointAddress">http://elite.polito.it/ontologies/dogont.owl#endpointAddress</seealso>
    let endpointAddress = Prefixed_Name(dogontowl, "endpointAddress") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#flashingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The flashing period duration in seconds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"flashingTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#flashingTime">http://elite.polito.it/ontologies/dogont.owl#flashingTime</seealso>
    let flashingTime = Prefixed_Name(dogontowl, "flashingTime") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#floorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#floorOf">http://elite.polito.it/ontologies/dogont.owl#floorOf</seealso>
    let floorOf = Prefixed_Name(dogontowl, "floorOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#generateCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#generateCommand">http://elite.polito.it/ontologies/dogont.owl#generateCommand</seealso>
    let generateCommand = Prefixed_Name(dogontowl, "generateCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#groupAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The address of the group of the component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"groupAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#groupAddress">http://elite.polito.it/ontologies/dogont.owl#groupAddress</seealso>
    let groupAddress = Prefixed_Name(dogontowl, "groupAddress") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Association between a mobile uncontrollable object and its actuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasActuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasActuator">http://elite.polito.it/ontologies/dogont.owl#hasActuator</seealso>
    let hasActuator = Prefixed_Name(dogontowl, "hasActuator") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasCeiling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasCeiling">http://elite.polito.it/ontologies/dogont.owl#hasCeiling</seealso>
    let hasCeiling = Prefixed_Name(dogontowl, "hasCeiling") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasCommand">http://elite.polito.it/ontologies/dogont.owl#hasCommand</seealso>
    let hasCommand = Prefixed_Name(dogontowl, "hasCommand") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Association between an object and its controller,e.g.switch,button,knob"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasControl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasControl">http://elite.polito.it/ontologies/dogont.owl#hasControl</seealso>
    let hasControl = Prefixed_Name(dogontowl, "hasControl") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasFloor">http://elite.polito.it/ontologies/dogont.owl#hasFloor</seealso>
    let hasFloor = Prefixed_Name(dogontowl, "hasFloor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasFunctionality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provide functionalities to controllable things"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasFunctionality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasFunctionality">http://elite.polito.it/ontologies/dogont.owl#hasFunctionality</seealso>
    let hasFunctionality = Prefixed_Name(dogontowl, "hasFunctionality") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasGateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Relates a given domotic component with the network level gateway used to control it"</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasGateway">http://elite.polito.it/ontologies/dogont.owl#hasGateway</seealso>
    let hasGateway = Prefixed_Name(dogontowl, "hasGateway") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasMeter">http://elite.polito.it/ontologies/dogont.owl#hasMeter</seealso>
    let hasMeter = Prefixed_Name(dogontowl, "hasMeter") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasNotification">http://elite.polito.it/ontologies/dogont.owl#hasNotification</seealso>
    let hasNotification = Prefixed_Name(dogontowl, "hasNotification") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Association between an object and its sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasSensor">http://elite.polito.it/ontologies/dogont.owl#hasSensor</seealso>
    let hasSensor = Prefixed_Name(dogontowl, "hasSensor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provide the actual state to controllable things"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"hasState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasState">http://elite.polito.it/ontologies/dogont.owl#hasState</seealso>
    let hasState = Prefixed_Name(dogontowl, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has state value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasStateValue">http://elite.polito.it/ontologies/dogont.owl#hasStateValue</seealso>
    let hasStateValue = Prefixed_Name(dogontowl, "hasStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasWall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Association between a room and its walls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasWall"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasWall">http://elite.polito.it/ontologies/dogont.owl#hasWall</seealso>
    let hasWall = Prefixed_Name(dogontowl, "hasWall") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hasWallOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Association between a wall and its opening like door,window"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasWallOpening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hasWallOpening">http://elite.polito.it/ontologies/dogont.owl#hasWallOpening</seealso>
    let hasWallOpening = Prefixed_Name(dogontowl, "hasWallOpening") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#hexValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#hexValue">http://elite.polito.it/ontologies/dogont.owl#hexValue</seealso>
    let hexValue = Prefixed_Name(dogontowl, "hexValue") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#individualAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The individual address of the component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"individualAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#individualAddress">http://elite.polito.it/ontologies/dogont.owl#individualAddress</seealso>
    let individualAddress =
        Prefixed_Name(dogontowl, "individualAddress") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#instanceId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#instanceId">http://elite.polito.it/ontologies/dogont.owl#instanceId</seealso>
    let instanceId = Prefixed_Name(dogontowl, "instanceId") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#isIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates in which building environment is contained an object, e.g. the lamp5 isIn Kitchen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#isIn">http://elite.polito.it/ontologies/dogont.owl#isIn</seealso>
    let isIn = Prefixed_Name(dogontowl, "isIn") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#isInWall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Association between a wallopening(door or window) and the wall opening where it is"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isInWall"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#isInWall">http://elite.polito.it/ontologies/dogont.owl#isInWall</seealso>
    let isInWall = Prefixed_Name(dogontowl, "isInWall") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#levelFromGround</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#levelFromGround">http://elite.polito.it/ontologies/dogont.owl#levelFromGround</seealso>
    let levelFromGround = Prefixed_Name(dogontowl, "levelFromGround") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#meterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#meterOf">http://elite.polito.it/ontologies/dogont.owl#meterOf</seealso>
    let meterOf = Prefixed_Name(dogontowl, "meterOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#multicastIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The multicast address of the gateway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"multicastIP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#multicastIP">http://elite.polito.it/ontologies/dogont.owl#multicastIP</seealso>
    let multicastIP = Prefixed_Name(dogontowl, "multicastIP") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#nParams</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#nParams">http://elite.polito.it/ontologies/dogont.owl#nParams</seealso>
    let nParams = Prefixed_Name(dogontowl, "nParams") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#nodeId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#nodeId">http://elite.polito.it/ontologies/dogont.owl#nodeId</seealso>
    let nodeId = Prefixed_Name(dogontowl, "nodeId") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#notificationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#notificationName">http://elite.polito.it/ontologies/dogont.owl#notificationName</seealso>
    let notificationName = Prefixed_Name(dogontowl, "notificationName") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#notificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#notificationOf">http://elite.polito.it/ontologies/dogont.owl#notificationOf</seealso>
    let notificationOf = Prefixed_Name(dogontowl, "notificationOf") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#notificationParamName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#notificationParamName">http://elite.polito.it/ontologies/dogont.owl#notificationParamName</seealso>
    let notificationParamName =
        Prefixed_Name(dogontowl, "notificationParamName") |> PrefixedName

    /// <summary>
    ///   <para>dogont:.owl#phaseID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#phaseID">http://elite.polito.it/ontologies/dogont.owl#phaseID</seealso>
    let phaseID = Prefixed_Name(dogontowl, "phaseID") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#physicalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The address of the component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"physicalAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#physicalAddress">http://elite.polito.it/ontologies/dogont.owl#physicalAddress</seealso>
    let physicalAddress = Prefixed_Name(dogontowl, "physicalAddress") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#physicalType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The category of the component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"physicalType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#physicalType">http://elite.polito.it/ontologies/dogont.owl#physicalType</seealso>
    let physicalType = Prefixed_Name(dogontowl, "physicalType") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#plugOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#plugOf">http://elite.polito.it/ontologies/dogont.owl#plugOf</seealso>
    let plugOf = Prefixed_Name(dogontowl, "plugOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#pluggedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#pluggedIn">http://elite.polito.it/ontologies/dogont.owl#pluggedIn</seealso>
    let pluggedIn = Prefixed_Name(dogontowl, "pluggedIn") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#pollingInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The interval between subsequent polls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pollingInterval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#pollingInterval">http://elite.polito.it/ontologies/dogont.owl#pollingInterval</seealso>
    let pollingInterval = Prefixed_Name(dogontowl, "pollingInterval") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#port</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The port of the gateway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"port"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#port">http://elite.polito.it/ontologies/dogont.owl#port</seealso>
    let port = Prefixed_Name(dogontowl, "port") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#probeID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#probeID">http://elite.polito.it/ontologies/dogont.owl#probeID</seealso>
    let probeID = Prefixed_Name(dogontowl, "probeID") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#realCommandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#realCommandName">http://elite.polito.it/ontologies/dogont.owl#realCommandName</seealso>
    let realCommandName = Prefixed_Name(dogontowl, "realCommandName") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#realStateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#realStateValue">http://elite.polito.it/ontologies/dogont.owl#realStateValue</seealso>
    let realStateValue = Prefixed_Name(dogontowl, "realStateValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#registerAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#registerAddress">http://elite.polito.it/ontologies/dogont.owl#registerAddress</seealso>
    let registerAddress = Prefixed_Name(dogontowl, "registerAddress") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#registerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#registerType">http://elite.polito.it/ontologies/dogont.owl#registerType</seealso>
    let registerType = Prefixed_Name(dogontowl, "registerType") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#returnType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#returnType">http://elite.polito.it/ontologies/dogont.owl#returnType</seealso>
    let returnType = Prefixed_Name(dogontowl, "returnType") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#scaleFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#scaleFactor">http://elite.polito.it/ontologies/dogont.owl#scaleFactor</seealso>
    let scaleFactor = Prefixed_Name(dogontowl, "scaleFactor") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#sensorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Association between a sensor and its sensed object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isSensorOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#sensorOf">http://elite.polito.it/ontologies/dogont.owl#sensorOf</seealso>
    let sensorOf = Prefixed_Name(dogontowl, "sensorOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#slaveId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#slaveId">http://elite.polito.it/ontologies/dogont.owl#slaveId</seealso>
    let slaveId = Prefixed_Name(dogontowl, "slaveId") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#sleepTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time between connection trials"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sleepTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#sleepTime">http://elite.polito.it/ontologies/dogont.owl#sleepTime</seealso>
    let sleepTime = Prefixed_Name(dogontowl, "sleepTime") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#statevalueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#statevalueOf">http://elite.polito.it/ontologies/dogont.owl#statevalueOf</seealso>
    let statevalueOf = Prefixed_Name(dogontowl, "statevalueOf") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#stepValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#stepValue">http://elite.polito.it/ontologies/dogont.owl#stepValue</seealso>
    let stepValue = Prefixed_Name(dogontowl, "stepValue") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#svgFootprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A property holding the svg footprint for the given building environment object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#svgFootprint">http://elite.polito.it/ontologies/dogont.owl#svgFootprint</seealso>
    let svgFootprint = Prefixed_Name(dogontowl, "svgFootprint") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#tariffID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#tariffID">http://elite.polito.it/ontologies/dogont.owl#tariffID</seealso>
    let tariffID = Prefixed_Name(dogontowl, "tariffID") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#timeToOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The time in seconds during which the object is turned on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timeToOff"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#timeToOff">http://elite.polito.it/ontologies/dogont.owl#timeToOff</seealso>
    let timeToOff = Prefixed_Name(dogontowl, "timeToOff") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#unitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#unitOfMeasure">http://elite.polito.it/ontologies/dogont.owl#unitOfMeasure</seealso>
    let unitOfMeasure = Prefixed_Name(dogontowl, "unitOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>dogont:.owl#weekDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl#weekDay">http://elite.polito.it/ontologies/dogont.owl#weekDay</seealso>
    let weekDay = Prefixed_Name(dogontowl, "weekDay") |> PrefixedName
