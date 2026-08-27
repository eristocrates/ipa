namespace https.w3id.org.sbeo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sbeo =
    let _namespace_iri = Namespace_Iri sbeo |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:sbeo#Ability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Possession of the means or skill to do something (Oxford Dictionary of English)."</para>
    /// labels<para>"Ability"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Ability">https://w3id.org/sbeo#Ability</seealso>
    let Ability = Prefixed_Name(sbeo, "Ability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AbilityToHear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ability to hear."</para>
    /// labels<para>"Ability To Hear"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AbilityToHear">https://w3id.org/sbeo#AbilityToHear</seealso>
    let AbilityToHear = Prefixed_Name(sbeo, "AbilityToHear") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AbilityToRun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ability to run."</para>
    /// labels<para>"Ability To Run"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AbilityToRun">https://w3id.org/sbeo#AbilityToRun</seealso>
    let AbilityToRun = Prefixed_Name(sbeo, "AbilityToRun") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AbilityToSee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ability to hear."</para>
    /// labels<para>"Ability To See"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AbilityToSee">https://w3id.org/sbeo#AbilityToSee</seealso>
    let AbilityToSee = Prefixed_Name(sbeo, "AbilityToSee") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AbilityToTalk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ability to talk."</para>
    /// labels<para>"Ability To Talk"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AbilityToTalk">https://w3id.org/sbeo#AbilityToTalk</seealso>
    let AbilityToTalk = Prefixed_Name(sbeo, "AbilityToTalk") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AbilityToTouch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ability to touch."</para>
    /// labels<para>"Ability To Touch"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AbilityToTouch">https://w3id.org/sbeo#AbilityToTouch</seealso>
    let AbilityToTouch = Prefixed_Name(sbeo, "AbilityToTouch") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AbilityToUseStairs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ability to use the stairs. Note that the people on the wheelchair are not considered to have this ability no matter the stairs have a stairlift and a ramp."</para>
    /// labels<para>"Ability To Use Stairs"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AbilityToUseStairs">https://w3id.org/sbeo#AbilityToUseStairs</seealso>
    let AbilityToUseStairs = Prefixed_Name(sbeo, "AbilityToUseStairs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AbilityToWalk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ability of a person to walk. A person who is using crutches is also considered to have this ability."</para>
    /// labels<para>"Ability To Walk"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AbilityToWalk">https://w3id.org/sbeo#AbilityToWalk</seealso>
    let AbilityToWalk = Prefixed_Name(sbeo, "AbilityToWalk") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#ActiveFireProtectionDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is an integral part of the fire protection used as a first response to minimize the spread of fire and related effects."</para>
    /// labels<para>"Active Fire Protection Device"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ActiveFireProtectionDevice">https://w3id.org/sbeo#ActiveFireProtectionDevice</seealso>
    let ActiveFireProtectionDevice =
        Prefixed_Name(sbeo, "ActiveFireProtectionDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A process that a person, group of persons, or machine does during a specific amount of time, such as visiting, shopping, etc."</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Activity">https://w3id.org/sbeo#Activity</seealso>
    let Activity = Prefixed_Name(sbeo, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ActivityImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter to express the impact of an activity on a specific person (or type of persons) in terms of any specific value or a type."</para>
    /// labels<para>"Activity Impact"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ActivityImpact">https://w3id.org/sbeo#ActivityImpact</seealso>
    let ActivityImpact = Prefixed_Name(sbeo, "ActivityImpact") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ActivitySeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter to express the severity of an activity for a specific person (or type of persons) in terms of  potential severity levels."</para>
    /// labels<para>"Activity Severity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ActivitySeverity">https://w3id.org/sbeo#ActivitySeverity</seealso>
    let ActivitySeverity = Prefixed_Name(sbeo, "ActivitySeverity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ActivityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It expresses the status of a specific activity being performed by a person."</para>
    /// labels<para>"Activity Status"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ActivityStatus">https://w3id.org/sbeo#ActivityStatus</seealso>
    let ActivityStatus = Prefixed_Name(sbeo, "ActivityStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AlertingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Alerting devices are those devices that are used to react to normal as well as alarming situations to let people know that some specific condition is occuring."</para>
    /// labels<para>"Alerting Device"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AlertingDevice">https://w3id.org/sbeo#AlertingDevice</seealso>
    let AlertingDevice = Prefixed_Name(sbeo, "AlertingDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#AlertingDeviceForImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An alerting device that is used to assist or notify people with impairments during a specific circumstance."</para>
    /// labels<para>"Alerting Device For Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AlertingDeviceForImpairedPerson">https://w3id.org/sbeo#AlertingDeviceForImpairedPerson</seealso>
    let AlertingDeviceForImpairedPerson =
        Prefixed_Name(sbeo, "AlertingDeviceForImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#AlzheimersDiseasedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person having an Alzheimer's disease."</para>
    /// labels<para>"Alzheimer's Diseased Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AlzheimersDiseasedPerson">https://w3id.org/sbeo#AlzheimersDiseasedPerson</seealso>
    let AlzheimersDiseasedPerson =
        Prefixed_Name(sbeo, "AlzheimersDiseasedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#Apartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A suite of rooms usually on one floor of an apartment house (Cambridge English Dictionary)."</para>
    /// labels<para>"Apartment"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Apartment">https://w3id.org/sbeo#Apartment</seealso>
    let Apartment = Prefixed_Name(sbeo, "Apartment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AppartmentBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of one or more buildings that contain apartments in it."</para>
    /// labels<para>"Appartment Building"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AppartmentBuilding">https://w3id.org/sbeo#AppartmentBuilding</seealso>
    let AppartmentBuilding = Prefixed_Name(sbeo, "AppartmentBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AssemblyPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A place where people in an office, etc. should go if there is an emergency, for example, a fire (Cambridge English Dictionary) ."</para>
    /// labels<para>"Assembly Point"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AssemblyPoint">https://w3id.org/sbeo#AssemblyPoint</seealso>
    let AssemblyPoint = Prefixed_Name(sbeo, "AssemblyPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AssistedNavigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A type of navigation in which a person is assisted by a person or a machine to perform a specific activity."</para>
    /// labels<para>"Assisted Navigation"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AssistedNavigation">https://w3id.org/sbeo#AssistedNavigation</seealso>
    let AssistedNavigation = Prefixed_Name(sbeo, "AssistedNavigation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#AudioDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of description in which sounds such as voices, are used to provide the information about any entity."</para>
    /// labels<para>"Audio Description"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AudioDescription">https://w3id.org/sbeo#AudioDescription</seealso>
    let AudioDescription = Prefixed_Name(sbeo, "AudioDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#AutonomousMobilityPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who can walk on his/her with a help of a non-motorised device, e.g. crutches."</para>
    /// labels<para>"Autonomous Mobility Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AutonomousMobilityPerson">https://w3id.org/sbeo#AutonomousMobilityPerson</seealso>
    let AutonomousMobilityPerson =
        Prefixed_Name(sbeo, "AutonomousMobilityPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#AutonomousNavigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A type of navigation in which a person plans and executes his or her path without any human or machine intervention."</para>
    /// labels<para>"Autonomous Navigation"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AutonomousNavigation">https://w3id.org/sbeo#AutonomousNavigation</seealso>
    let AutonomousNavigation =
        Prefixed_Name(sbeo, "AutonomousNavigation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#AvailabilityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It expresses the status of something that is either available or not."</para>
    /// labels<para>"Availability Status"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#AvailabilityStatus">https://w3id.org/sbeo#AvailabilityStatus</seealso>
    let AvailabilityStatus = Prefixed_Name(sbeo, "AvailabilityStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Available</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Obtainable or accessible and ready for use or service."</para>
    /// labels<para>"Available"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Available">https://w3id.org/sbeo#Available</seealso>
    let Available = Prefixed_Name(sbeo, "Available") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#BlindPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has lost the vision completly and can neither see naturally nor with the help of any device."</para>
    /// labels<para>"Blind Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#BlindPerson">https://w3id.org/sbeo#BlindPerson</seealso>
    let BlindPerson = Prefixed_Name(sbeo, "BlindPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#BuildingEntrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the entrance to a building."</para>
    /// labels<para>"Building Entrance"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#BuildingEntrance">https://w3id.org/sbeo#BuildingEntrance</seealso>
    let BuildingEntrance = Prefixed_Name(sbeo, "BuildingEntrance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#BuildingExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the exit of a building."</para>
    /// labels<para>"Building Exit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#BuildingExit">https://w3id.org/sbeo#BuildingExit</seealso>
    let BuildingExit = Prefixed_Name(sbeo, "BuildingExit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ChemicalSpill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hazardous event that happens due to the spillage or leakge of any toxic chemical in the building."</para>
    /// labels<para>"Chemical Spill"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ChemicalSpill">https://w3id.org/sbeo#ChemicalSpill</seealso>
    let ChemicalSpill = Prefixed_Name(sbeo, "ChemicalSpill") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#CinemaBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A building in which movies are shown."</para>
    /// labels<para>"Cinema Building"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#CinemaBuilding">https://w3id.org/sbeo#CinemaBuilding</seealso>
    let CinemaBuilding = Prefixed_Name(sbeo, "CinemaBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Classroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A room, typically in a school, in which a class of students is taught (Oxford Dictionary of English)."</para>
    /// labels<para>"Classroom"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Classroom">https://w3id.org/sbeo#Classroom</seealso>
    let Classroom = Prefixed_Name(sbeo, "Classroom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#CollaborativeNavigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A type of navigation in which two or more persons are involved that may or may not have same objectives."</para>
    /// labels<para>"Collaborative Navigation"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#CollaborativeNavigation">https://w3id.org/sbeo#CollaborativeNavigation</seealso>
    let CollaborativeNavigation =
        Prefixed_Name(sbeo, "CollaborativeNavigation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#ColourBlindPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person having the decreased ability to see color or differences in color."</para>
    /// labels<para>"Colour Blind Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ColourBlindPerson">https://w3id.org/sbeo#ColourBlindPerson</seealso>
    let ColourBlindPerson = Prefixed_Name(sbeo, "ColourBlindPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Congestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event that happens at bottlenecks when the flow of people increases than a provided limit due to herding (and similar phenomena of human behaviour), especially during an emergency evacuation process."</para>
    /// labels<para>"Congestion"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Congestion">https://w3id.org/sbeo#Congestion</seealso>
    let Congestion = Prefixed_Name(sbeo, "Congestion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#CorridorEntrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the entrance to a corridor."</para>
    /// labels<para>"Corridor Entrance"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#CorridorEntrance">https://w3id.org/sbeo#CorridorEntrance</seealso>
    let CorridorEntrance = Prefixed_Name(sbeo, "CorridorEntrance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#CorridorExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the exit of a corridor."</para>
    /// labels<para>"Corridor Exit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#CorridorExit">https://w3id.org/sbeo#CorridorExit</seealso>
    let CorridorExit = Prefixed_Name(sbeo, "CorridorExit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#CorridorSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fragment or an atomic element of a corridor."</para>
    /// labels<para>"Corridor Segment"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#CorridorSegment">https://w3id.org/sbeo#CorridorSegment</seealso>
    let CorridorSegment = Prefixed_Name(sbeo, "CorridorSegment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#DayCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A place where infants and young children are provided a supervision and care of during the daytime, particularly so that their parents can hold jobs."</para>
    /// labels<para>"Day Care"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#DayCare">https://w3id.org/sbeo#DayCare</seealso>
    let DayCare = Prefixed_Name(sbeo, "DayCare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A representation and detail of a person, object, or event. It is used to describe the details of anything."</para>
    /// labels<para>"Description"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Description">https://w3id.org/sbeo#Description</seealso>
    let Description = Prefixed_Name(sbeo, "Description") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#DeviatingFromPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"When someone is deviating from the provided path."</para><para>"Deviating From Path"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#DeviatingFromPath">https://w3id.org/sbeo#DeviatingFromPath</seealso>
    let DeviatingFromPath = Prefixed_Name(sbeo, "DeviatingFromPath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#DeviationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models the user's deviation state from one's proposed route. For example, NoDeviate, RareDeviate, OftenDeviate, and TooOftenDeviate."</para>
    /// labels<para>"Deviation State"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#DeviationState">https://w3id.org/sbeo#DeviationState</seealso>
    let DeviationState = Prefixed_Name(sbeo, "DeviationState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thing made or adapted for a particular purpose, especially a piece of mechanical or electronic equipment (Oxford Dictionary of English)."</para>
    /// labels<para>"Device"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Device">https://w3id.org/sbeo#Device</seealso>
    let Device = Prefixed_Name(sbeo, "Device") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#DisplayScreen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A display screen is an output device to represent the information in visual or tactile form."</para>
    /// labels<para>"Display Screen"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#DisplayScreen">https://w3id.org/sbeo#DisplayScreen</seealso>
    let DisplayScreen = Prefixed_Name(sbeo, "DisplayScreen") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#DownSyndromePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person with Down's syndrome."</para>
    /// labels<para>"Down Syndrome Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#DownSyndromePerson">https://w3id.org/sbeo#DownSyndromePerson</seealso>
    let DownSyndromePerson = Prefixed_Name(sbeo, "DownSyndromePerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Earthquake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sudden violent shaking of the ground, typically causing great destruction, as a result of movements within the earth's crust or volcanic action (Oxford Dictionary of English). It may cause a sudden panic among the occupants of the building."</para>
    /// labels<para>"Earthquake"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Earthquake">https://w3id.org/sbeo#Earthquake</seealso>
    let Earthquake = Prefixed_Name(sbeo, "Earthquake") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#EmergencyActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity that is done with an urgency and highest priority."</para>
    /// labels<para>"Emergency Activity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EmergencyActivity">https://w3id.org/sbeo#EmergencyActivity</seealso>
    let EmergencyActivity = Prefixed_Name(sbeo, "EmergencyActivity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#EmergencyEvacuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents an immediate escape of people away from a particular area that has ongoing or imminent hazard to their lives or property."</para>
    /// labels<para>"Emergency Evacuation"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EmergencyEvacuation">https://w3id.org/sbeo#EmergencyEvacuation</seealso>
    let EmergencyEvacuation = Prefixed_Name(sbeo, "EmergencyEvacuation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#EmergencyEvacuationGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of two or more persons who are supposed to evacuate the building together."</para>
    /// labels<para>"Emergency Evacuation Group"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EmergencyEvacuationGroup">https://w3id.org/sbeo#EmergencyEvacuationGroup</seealso>
    let EmergencyEvacuationGroup =
        Prefixed_Name(sbeo, "EmergencyEvacuationGroup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#EmergencyEvacuationRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of route in which only those spaces are mentioned that are potentially safe for its users as well as the ending point of it must be an exit from a particular space."</para>
    /// labels<para>"Emergency Evacuation Route"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EmergencyEvacuationRoute">https://w3id.org/sbeo#EmergencyEvacuationRoute</seealso>
    let EmergencyEvacuationRoute =
        Prefixed_Name(sbeo, "EmergencyEvacuationRoute") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#EmergencyExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Emergency exit is logical point that is only used in case of any emergency conditions such as fire, etc."</para>
    /// labels<para>"Emergency Exit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EmergencyExit">https://w3id.org/sbeo#EmergencyExit</seealso>
    let EmergencyExit = Prefixed_Name(sbeo, "EmergencyExit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#EndPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logic point that is used to indicate the end of a corridor."</para>
    /// labels<para>"End Point"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EndPoint">https://w3id.org/sbeo#EndPoint</seealso>
    let EndPoint = Prefixed_Name(sbeo, "EndPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Entrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Entrance represents a space or a door that is used to enter into a building. Normally, it is also used as an exit."</para>
    /// labels<para>"Entrance"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Entrance">https://w3id.org/sbeo#Entrance</seealso>
    let Entrance = Prefixed_Name(sbeo, "Entrance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Escalator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A moving staircase consisting of an endlessly circulating belt of steps driven by a motor, which conveys people between the floors of a public building (Oxford Dictionary of English)."</para>
    /// labels<para>"Escalator"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Escalator">https://w3id.org/sbeo#Escalator</seealso>
    let Escalator = Prefixed_Name(sbeo, "Escalator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#EscortSupportedWheelchairPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical impaired person whose wheelchair is escorted by another person."</para>
    /// labels<para>"Escort Supported Wheelchair Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EscortSupportedWheelchairPerson">https://w3id.org/sbeo#EscortSupportedWheelchairPerson</seealso>
    let EscortSupportedWheelchairPerson =
        Prefixed_Name(sbeo, "EscortSupportedWheelchairPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#Evacuated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Evacuated"</para><para>"This instance is used to mention when a person has been evacuated successfully."</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Evacuated">https://w3id.org/sbeo#Evacuated</seealso>
    let Evacuated = Prefixed_Name(sbeo, "Evacuated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Evacuating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Evacuating"</para><para>"This instance is used to express when someone is in the process of evacuating some space."</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Evacuating">https://w3id.org/sbeo#Evacuating</seealso>
    let Evacuating = Prefixed_Name(sbeo, "Evacuating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An occurrence; something that happens (Oxford Dictionary of English). It represents when something planned or sudden happens."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Event">https://w3id.org/sbeo#Event</seealso>
    let Event = Prefixed_Name(sbeo, "Event") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#EventImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter to express the impact of an event on a specific person (or type of persons) in terms of any specific value or a type."</para>
    /// labels<para>"Event Impact"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EventImpact">https://w3id.org/sbeo#EventImpact</seealso>
    let EventImpact = Prefixed_Name(sbeo, "EventImpact") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#EventSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter to express the severity of an event for a specific person (or type of persons) in terms of  potential severity levels."</para>
    /// labels<para>"Event Severity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#EventSeverity">https://w3id.org/sbeo#EventSeverity</seealso>
    let EventSeverity = Prefixed_Name(sbeo, "EventSeverity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Exhausted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express the when someone has drained of one's energy or effectiveness."</para>
    /// labels<para>"Exhausted"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Exhausted">https://w3id.org/sbeo#Exhausted</seealso>
    let Exhausted = Prefixed_Name(sbeo, "Exhausted") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Exit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Exit represents a logical representation for escaping or releasing from a specific phsyical space. Generally, an exit is as same as an entrance."</para>
    /// labels<para>"Exit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Exit">https://w3id.org/sbeo#Exit</seealso>
    let Exit = Prefixed_Name(sbeo, "Exit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ExitRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of route in which the ending point represents the exit of a specific space."</para>
    /// labels<para>"Exit Route"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ExitRoute">https://w3id.org/sbeo#ExitRoute</seealso>
    let ExitRoute = Prefixed_Name(sbeo, "ExitRoute") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of two or more persons having family ties between them."</para>
    /// labels<para>"Family"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Family">https://w3id.org/sbeo#Family</seealso>
    let Family = Prefixed_Name(sbeo, "Family") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Fire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event that may burn different parts of the building and hazourdous for both the people and the building."</para>
    /// labels<para>"Fire"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Fire">https://w3id.org/sbeo#Fire</seealso>
    let Fire = Prefixed_Name(sbeo, "Fire") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#FireDoor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of door used to minimize the spread of fire and related effects by isolating two connected spaces or sections in the building."</para>
    /// labels<para>"Fire Door"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#FireDoor">https://w3id.org/sbeo#FireDoor</seealso>
    let FireDoor = Prefixed_Name(sbeo, "FireDoor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#FireEscapeLadder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of ladder which is used to make an emergency exit through the window out of fire accident site."</para>
    /// labels<para>"Fire Escape Ladder"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#FireEscapeLadder">https://w3id.org/sbeo#FireEscapeLadder</seealso>
    let FireEscapeLadder = Prefixed_Name(sbeo, "FireEscapeLadder") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#FireExtinguisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An active fire protection instrument used by persons to blow out small scale fire."</para>
    /// labels<para>"Fire Extinguisher"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#FireExtinguisher">https://w3id.org/sbeo#FireExtinguisher</seealso>
    let FireExtinguisher = Prefixed_Name(sbeo, "FireExtinguisher") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#FireProtectionDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that is used to minimize the effects of potentially danger fires."</para>
    /// labels<para>"Fire Protection Device"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#FireProtectionDevice">https://w3id.org/sbeo#FireProtectionDevice</seealso>
    let FireProtectionDevice =
        Prefixed_Name(sbeo, "FireProtectionDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#Fit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express when the physical and mental condition is sound of someone."</para>
    /// labels<para>"Fit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Fit">https://w3id.org/sbeo#Fit</seealso>
    let Fit = Prefixed_Name(sbeo, "Fit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#FitnessStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fitness status is associated with a person that represent the quality of being suitable for a specific activity."</para>
    /// labels<para>"Fitness Status"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#FitnessStatus">https://w3id.org/sbeo#FitnessStatus</seealso>
    let FitnessStatus = Prefixed_Name(sbeo, "FitnessStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#FloorEntrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the entrance to a floor."</para>
    /// labels<para>"Floor Entrance"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#FloorEntrance">https://w3id.org/sbeo#FloorEntrance</seealso>
    let FloorEntrance = Prefixed_Name(sbeo, "FloorEntrance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#FloorExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the exit of a specific floor and that leads to different floors of a building."</para>
    /// labels<para>"Floor Exit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#FloorExit">https://w3id.org/sbeo#FloorExit</seealso>
    let FloorExit = Prefixed_Name(sbeo, "FloorExit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#FollowingPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express when someone is following one's provided path."</para>
    /// labels<para>"Following Path"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#FollowingPath">https://w3id.org/sbeo#FollowingPath</seealso>
    let FollowingPath = Prefixed_Name(sbeo, "FollowingPath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Footpath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A path for pedestrians in a built-up area; a pavement."</para>
    /// labels<para>"Footpath"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Footpath">https://w3id.org/sbeo#Footpath</seealso>
    let Footpath = Prefixed_Name(sbeo, "Footpath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#GraphBasedRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A graph-based route is a graphical way of representing a route in terms of nodes (sometimes called vertices) and edges (sometimes called arcs)."</para>
    /// labels<para>"Graph-Based Route"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#GraphBasedRoute">https://w3id.org/sbeo#GraphBasedRoute</seealso>
    let GraphBasedRoute = Prefixed_Name(sbeo, "GraphBasedRoute") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents a collection of two or more people who interact with each other and may have the similar characteristics or objectives."</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Group">https://w3id.org/sbeo#Group</seealso>
    let Group = Prefixed_Name(sbeo, "Group") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#HallEntrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the entrance to a hall."</para>
    /// labels<para>"Hall Entrance"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#HallEntrance">https://w3id.org/sbeo#HallEntrance</seealso>
    let HallEntrance = Prefixed_Name(sbeo, "HallEntrance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#HallExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the exit of a Hall."</para>
    /// labels<para>"Hall Exit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#HallExit">https://w3id.org/sbeo#HallExit</seealso>
    let HallExit = Prefixed_Name(sbeo, "HallExit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#HallSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fragment or an atomic element of a hall."</para>
    /// labels<para>"Hall Segment"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#HallSegment">https://w3id.org/sbeo#HallSegment</seealso>
    let HallSegment = Prefixed_Name(sbeo, "HallSegment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#HandheldDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A smart device or a computer that is small enough to be used while holding it in the hands."</para>
    /// labels<para>"Handheld Device"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#HandheldDevice">https://w3id.org/sbeo#HandheldDevice</seealso>
    let HandheldDevice = Prefixed_Name(sbeo, "HandheldDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#HearingImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a partial or total unability to hear. It is also known as Hearing loss."</para>
    /// labels<para>"Hearing Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#HearingImpairedPerson">https://w3id.org/sbeo#HearingImpairedPerson</seealso>
    let HearingImpairedPerson =
        Prefixed_Name(sbeo, "HearingImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#HorizontalMovingPavement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A slow-moving conveyor mechanism that transports people across a horizontal plane over a short to medium distance."</para>
    /// labels<para>"Horizontal Moving Pavement"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#HorizontalMovingPavement">https://w3id.org/sbeo#HorizontalMovingPavement</seealso>
    let HorizontalMovingPavement =
        Prefixed_Name(sbeo, "HorizontalMovingPavement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#HorizontalPassage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of a passage that connects spatial elements located on the same storey or floor."</para>
    /// labels<para>"Horizontal Passage"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#HorizontalPassage">https://w3id.org/sbeo#HorizontalPassage</seealso>
    let HorizontalPassage = Prefixed_Name(sbeo, "HorizontalPassage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#HotelBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A building that contains rooms, apartments or suites where people stay for a specific time period."</para>
    /// labels<para>"Hotel Building"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#HotelBuilding">https://w3id.org/sbeo#HotelBuilding</seealso>
    let HotelBuilding = Prefixed_Name(sbeo, "HotelBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ImageDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of description in which images are given to provide information about any entity."</para>
    /// labels<para>"Image Description"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ImageDescription">https://w3id.org/sbeo#ImageDescription</seealso>
    let ImageDescription = Prefixed_Name(sbeo, "ImageDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An impact is a long-lasting effect of an event (or activity), that continues to exist after the event (or activity) has taken place."</para>
    /// labels<para>"Impact"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Impact">https://w3id.org/sbeo#Impact</seealso>
    let Impact = Prefixed_Name(sbeo, "Impact") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual whose natural senses or physical abilities are either diminished or damaged."</para>
    /// labels<para>"Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ImpairedPerson">https://w3id.org/sbeo#ImpairedPerson</seealso>
    let ImpairedPerson = Prefixed_Name(sbeo, "ImpairedPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Incident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event or occurance that can be dangerous for the occupants of the building."</para>
    /// labels<para>"Incident"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Incident">https://w3id.org/sbeo#Incident</seealso>
    let Incident = Prefixed_Name(sbeo, "Incident") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#IncidentProtectionDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that is used to avoid and minimize the effects of potentially danger events for the occupants of the building as well as for the structure of building itself."</para>
    /// labels<para>"Incident Protection Device"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#IncidentProtectionDevice">https://w3id.org/sbeo#IncidentProtectionDevice</seealso>
    let IncidentProtectionDevice =
        Prefixed_Name(sbeo, "IncidentProtectionDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#Injured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express when someone is not fit and has some injuries."</para>
    /// labels<para>"Injured"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Injured">https://w3id.org/sbeo#Injured</seealso>
    let Injured = Prefixed_Name(sbeo, "Injured") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Intensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The measurable amount of a property, such as force, brightness, or a magnetic field (Oxford Dictionary of English)."</para>
    /// labels<para>"Intensity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Intensity">https://w3id.org/sbeo#Intensity</seealso>
    let Intensity = Prefixed_Name(sbeo, "Intensity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Junction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logic point that connects more than two corridors."</para>
    /// labels<para>"Junction"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Junction">https://w3id.org/sbeo#Junction</seealso>
    let Junction = Prefixed_Name(sbeo, "Junction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#KidsArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A place where infants or young children can play which is surrounded by a boundary normally. It can be both indoor and outdoor."</para>
    /// labels<para>"Kids Area"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#KidsArea">https://w3id.org/sbeo#KidsArea</seealso>
    let KidsArea = Prefixed_Name(sbeo, "KidsArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#LowStaminaPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the unability to sustain physical or mental activity to a normal level."</para>
    /// labels<para>"Low Stamina Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#LowStaminaPerson">https://w3id.org/sbeo#LowStaminaPerson</seealso>
    let LowStaminaPerson = Prefixed_Name(sbeo, "LowStaminaPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#LowVisionPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person whose visual acuity is 20/70 or poorer in the better-seeing eye and cannot be corrected or improved with regular eyeglasses."</para>
    /// labels<para>"Low Vision Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#LowVisionPerson">https://w3id.org/sbeo#LowVisionPerson</seealso>
    let LowVisionPerson = Prefixed_Name(sbeo, "LowVisionPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#MeetingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of room designated for social gathering of people, especially professional meetings."</para>
    /// labels<para>"Meeting Room"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MeetingRoom">https://w3id.org/sbeo#MeetingRoom</seealso>
    let MeetingRoom = Prefixed_Name(sbeo, "MeetingRoom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#MentalAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The mental ability of an indi-vidual to remain focused on an external stimuli or an internal experience for a certain period of time (World Health Organisation)."</para>
    /// labels<para>"Mental Ability"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MentalAbility">https://w3id.org/sbeo#MentalAbility</seealso>
    let MentalAbility = Prefixed_Name(sbeo, "MentalAbility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MentalImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person having mental impairment in which one's mind is damaged or is not working properly and one have issues such as consciousness, orientation, concentration."</para>
    /// labels<para>"Mental Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MentalImpairedPerson">https://w3id.org/sbeo#MentalImpairedPerson</seealso>
    let MentalImpairedPerson =
        Prefixed_Name(sbeo, "MentalImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MildHearingImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who is only able to hear the sounds that are between 25 and 40 dB."</para>
    /// labels<para>"Mild Hearing Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MildHearingImpairedPerson">https://w3id.org/sbeo#MildHearingImpairedPerson</seealso>
    let MildHearingImpairedPerson =
        Prefixed_Name(sbeo, "MildHearingImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MobilePhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A telephone with access to a cellular radio system so it can be used over a wide area, without a physical connection to a network (Oxford Dictionary of English)."</para>
    /// labels<para>"Mobile Phone"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MobilePhone">https://w3id.org/sbeo#MobilePhone</seealso>
    let MobilePhone = Prefixed_Name(sbeo, "MobilePhone") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#MobilityAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This ability is used to represent all kinetic abilities a person may have."</para>
    /// labels<para>"Mobility Ability"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MobilityAbility">https://w3id.org/sbeo#MobilityAbility</seealso>
    let MobilityAbility = Prefixed_Name(sbeo, "MobilityAbility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MobilityWithAssistedDevicePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who used a motorised device for moving, such as motorised wheelchair or scooter, etc."</para>
    /// labels<para>"Mobility With Assisted Device Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MobilityWithAssistedDevicePerson">https://w3id.org/sbeo#MobilityWithAssistedDevicePerson</seealso>
    let MobilityWithAssistedDevicePerson =
        Prefixed_Name(sbeo, "MobilityWithAssistedDevicePerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MobilityWithWheelchairPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person using a wheelchair (a mobility device that is used while having any kind of tempoary or permanent physical impairment)."</para>
    /// labels<para>"Mobility With Wheelchair Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MobilityWithWheelchairPerson">https://w3id.org/sbeo#MobilityWithWheelchairPerson</seealso>
    let MobilityWithWheelchairPerson =
        Prefixed_Name(sbeo, "MobilityWithWheelchairPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#ModerateHearingImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who cannot hear sounds that are less than 40-75 dB."</para>
    /// labels<para>"Moderate Hearing Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ModerateHearingImpairedPerson">https://w3id.org/sbeo#ModerateHearingImpairedPerson</seealso>
    let ModerateHearingImpairedPerson =
        Prefixed_Name(sbeo, "ModerateHearingImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MotionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes the movement of a person."</para>
    /// labels<para>"Motion State"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MotionState">https://w3id.org/sbeo#MotionState</seealso>
    let MotionState = Prefixed_Name(sbeo, "MotionState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#MotorImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who has either partial or total loss of function of a body part, usually a limb or limbs."</para>
    /// labels<para>"Motor Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MotorImpairedPerson">https://w3id.org/sbeo#MotorImpairedPerson</seealso>
    let MotorImpairedPerson = Prefixed_Name(sbeo, "MotorImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MotorisedWheelchairPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a kind of wheelchair that has either a mechanical engine or an electric battery. It has more speed than a traditional wheelchair."</para>
    /// labels<para>"Motorised Wheelchair Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MotorisedWheelchairPerson">https://w3id.org/sbeo#MotorisedWheelchairPerson</seealso>
    let MotorisedWheelchairPerson =
        Prefixed_Name(sbeo, "MotorisedWheelchairPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MovingPavement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A slow-moving conveyor mechanism that transports people across a horizontal or inclined plane over a short to medium distance (Oxford Dictionary of English)."</para>
    /// labels<para>"Moving Pavement"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MovingPavement">https://w3id.org/sbeo#MovingPavement</seealso>
    let MovingPavement = Prefixed_Name(sbeo, "MovingPavement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#MultiObjectiveNavigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A type of navigation in which multiple point of interests are supposed to be visited by a person."</para>
    /// labels<para>"Multi-objective Navigation"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#MultiObjectiveNavigation">https://w3id.org/sbeo#MultiObjectiveNavigation</seealso>
    let MultiObjectiveNavigation =
        Prefixed_Name(sbeo, "MultiObjectiveNavigation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#Navigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process or activity of accurately ascertaining one's position and planning and following a route (Oxford Dictionary of English)."</para>
    /// labels<para>"Navigation"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Navigation">https://w3id.org/sbeo#Navigation</seealso>
    let Navigation = Prefixed_Name(sbeo, "Navigation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#NavigationalPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a special type of point that connects more than two corridors or enforce change of direction to users or indicate the end of corridors."</para>
    /// labels<para>"Navigational Point"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#NavigationalPoint">https://w3id.org/sbeo#NavigationalPoint</seealso>
    let NavigationalPoint = Prefixed_Name(sbeo, "NavigationalPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#NavigationalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models the user's navigational state while following the path."</para>
    /// labels<para>"Navigational State"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#NavigationalState">https://w3id.org/sbeo#NavigationalState</seealso>
    let NavigationalState = Prefixed_Name(sbeo, "NavigationalState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#NoDeviate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express when someone is not deviating at all while following one's provided path."</para>
    /// labels<para>"No Deviate"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#NoDeviate">https://w3id.org/sbeo#NoDeviate</seealso>
    let NoDeviate = Prefixed_Name(sbeo, "NoDeviate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#NonMotorisedWheelchairPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A traditional wheelchair that is used by hands. It has significantly lower speed than motorised wheelchairs."</para>
    /// labels<para>"Non-Motorised Wheelchair Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#NonMotorisedWheelchairPerson">https://w3id.org/sbeo#NonMotorisedWheelchairPerson</seealso>
    let NonMotorisedWheelchairPerson =
        Prefixed_Name(sbeo, "NonMotorisedWheelchairPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#OftenDeviate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express when someone is deviating frequently while following the provided path."</para>
    /// labels<para>"Often Deviate"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#OftenDeviate">https://w3id.org/sbeo#OftenDeviate</seealso>
    let OftenDeviate = Prefixed_Name(sbeo, "OftenDeviate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#OpenAreaEntrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the entrance to an open area."</para>
    /// labels<para>"Open Area Entrance"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#OpenAreaEntrance">https://w3id.org/sbeo#OpenAreaEntrance</seealso>
    let OpenAreaEntrance = Prefixed_Name(sbeo, "OpenAreaEntrance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#OpenAreaExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the exit from a specifc open space."</para>
    /// labels<para>"Open Area Exit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#OpenAreaExit">https://w3id.org/sbeo#OpenAreaExit</seealso>
    let OpenAreaExit = Prefixed_Name(sbeo, "OpenAreaExit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Panic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A  sudden uncontrollable fear or anxiety among the occupants of the building that often causes wildly unthinking behaviour (Oxford Dictionary of English). In indoor environments, it may happens due to several reasons such as earthquake, fire or other sudden hazardous situations."</para>
    /// labels<para>"Panic"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Panic">https://w3id.org/sbeo#Panic</seealso>
    let Panic = Prefixed_Name(sbeo, "Panic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A numerical or other measurable factor forming one of a set that defines a system or sets the conditions of its operation."</para>
    /// labels<para>"Parameter"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Parameter">https://w3id.org/sbeo#Parameter</seealso>
    let Parameter = Prefixed_Name(sbeo, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Passage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any spatial element that is part of a path and traversable by persons. In addition, it may be used as a logic representation of physical passages to represent an edge (or an arc) in a route graph."</para>
    /// labels<para>"Passage"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Passage">https://w3id.org/sbeo#Passage</seealso>
    let Passage = Prefixed_Name(sbeo, "Passage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#PassiveFireProtectionDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is an integral component installed in the building while construction to resist the fire."</para>
    /// labels<para>"Passive Fire Protection"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#PassiveFireProtectionDevice">https://w3id.org/sbeo#PassiveFireProtectionDevice</seealso>
    let PassiveFireProtectionDevice =
        Prefixed_Name(sbeo, "PassiveFireProtectionDevice") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#PersonAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter to express the quality of an ability a specific person (or type of persons) own."</para>
    /// labels<para>"Person Ability"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#PersonAbility">https://w3id.org/sbeo#PersonAbility</seealso>
    let PersonAbility = Prefixed_Name(sbeo, "PersonAbility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#PersonAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter to express the accessibility of any space for a specific person (or type of persons) in terms of some value."</para>
    /// labels<para>"Person Accessibility"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#PersonAccessibility">https://w3id.org/sbeo#PersonAccessibility</seealso>
    let PersonAccessibility = Prefixed_Name(sbeo, "PersonAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#PhysicallyImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical impairment is a condition in which any part of person's body is either  damaged or is not working properly."</para>
    /// labels<para>"Physically Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#PhysicallyImpairedPerson">https://w3id.org/sbeo#PhysicallyImpairedPerson</seealso>
    let PhysicallyImpairedPerson =
        Prefixed_Name(sbeo, "PhysicallyImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#PickingUpDependents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express when someone is picking up the dependent member of one's group."</para>
    /// labels<para>"Picking Up Dependents"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#PickingUpDependents">https://w3id.org/sbeo#PickingUpDependents</seealso>
    let PickingUpDependents = Prefixed_Name(sbeo, "PickingUpDependents") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#PointOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any physical or virtual location or object, which may be of interest to a user and may serve as a navigation destination (e.g., room, water dispenser, waiting zone, assembly point, shop, seat, etc)."</para>
    /// labels<para>"Point Of Interest"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#PointOfInterest">https://w3id.org/sbeo#PointOfInterest</seealso>
    let PointOfInterest = Prefixed_Name(sbeo, "PointOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#PointOfInterestSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A traverasal part of a space that is connected to a specific Point of Interest."</para>
    /// labels<para>"Point Of Interest Segement"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#PointOfInterestSegment">https://w3id.org/sbeo#PointOfInterestSegment</seealso>
    let PointOfInterestSegment =
        Prefixed_Name(sbeo, "PointOfInterestSegment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#ProfoundHearingImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who cannot hear sounds softer than 90-120 dB. A person suffering from profound hearing loss, using a hearing aid is also ineffective most of the time."</para>
    /// labels<para>"Profound Hearing Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ProfoundHearingImpairedPerson">https://w3id.org/sbeo#ProfoundHearingImpairedPerson</seealso>
    let ProfoundHearingImpairedPerson =
        Prefixed_Name(sbeo, "ProfoundHearingImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A degree or grade of excellence or worth."</para>
    /// labels<para>"Quality"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Quality">https://w3id.org/sbeo#Quality</seealso>
    let Quality = Prefixed_Name(sbeo, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Ramp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sloping surface joining two different levels, as at the entrance or between floors of a building (Oxford Dictionary of English)."</para>
    /// labels<para>"Ramp"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Ramp">https://w3id.org/sbeo#Ramp</seealso>
    let Ramp = Prefixed_Name(sbeo, "Ramp") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#RareDeviate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express when someone rarely deviates while following the provided path."</para>
    /// labels<para>"Rare Deviate"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#RareDeviate">https://w3id.org/sbeo#RareDeviate</seealso>
    let RareDeviate = Prefixed_Name(sbeo, "RareDeviate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Road</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A road is a way on land between two places that has been paved or otherwise improved to allow travel by foot or some form of conveyance, including a motor vehicle, cart, bicycle, or horse."</para>
    /// labels<para>"Road"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Road">https://w3id.org/sbeo#Road</seealso>
    let Road = Prefixed_Name(sbeo, "Road") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The function assumed or part played by a person or thing in a particular situation (Oxford Dictionary of English)."</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Role">https://w3id.org/sbeo#Role</seealso>
    let Role = Prefixed_Name(sbeo, "Role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#RoleInContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concept to express that an agent is playing a role in a given context."</para>
    /// labels<para>"Role In Context"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#RoleInContext">https://w3id.org/sbeo#RoleInContext</seealso>
    let RoleInContext = Prefixed_Name(sbeo, "RoleInContext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Rolling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A type of movement by turning over and over on an axis, usually performed by a person using a wheelchair,"</para>
    /// labels<para>"Rolling"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Rolling">https://w3id.org/sbeo#Rolling</seealso>
    let Rolling = Prefixed_Name(sbeo, "Rolling") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#RoomEntrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the entrance to a room."</para>
    /// labels<para>"Room Entrance"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#RoomEntrance">https://w3id.org/sbeo#RoomEntrance</seealso>
    let RoomEntrance = Prefixed_Name(sbeo, "RoomEntrance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#RoomExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logical point that is used to represent the exit of a room."</para>
    /// labels<para>"Room Exit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#RoomExit">https://w3id.org/sbeo#RoomExit</seealso>
    let RoomExit = Prefixed_Name(sbeo, "RoomExit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#RoomSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A traversable part in a room that is usually used to go the exit or the other part of the room."</para>
    /// labels<para>"Room Segment"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#RoomSegment">https://w3id.org/sbeo#RoomSegment</seealso>
    let RoomSegment = Prefixed_Name(sbeo, "RoomSegment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Route</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of connected spaces represented by a starting and ending point, that ultimately leads to some specific position or place."</para>
    /// labels<para>"Route"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Route">https://w3id.org/sbeo#Route</seealso>
    let Route = Prefixed_Name(sbeo, "Route") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#RouteElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents the physical or conceptual elements of a navigation path."</para>
    /// labels<para>"Route Element"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#RouteElement">https://w3id.org/sbeo#RouteElement</seealso>
    let RouteElement = Prefixed_Name(sbeo, "RouteElement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#RoutePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any spatial element that is part of a path and traversable by persons. In addition, it may be used as a logic representation of physical passages to represent a node (or a vertex) in a route graph."</para>
    /// labels<para>"Route Point"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#RoutePoint">https://w3id.org/sbeo#RoutePoint</seealso>
    let RoutePoint = Prefixed_Name(sbeo, "RoutePoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Running</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A movement of an able-bodied person at a speed faster than a walk"</para>
    /// labels<para>"Running"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Running">https://w3id.org/sbeo#Running</seealso>
    let Running = Prefixed_Name(sbeo, "Running") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Scooting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A type of movement usually performed while sitting in (or riding on) an automatic or mechical device, such as electrical wheelchair, electric scooter, etc."</para>
    /// labels<para>"Scooting"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Scooting">https://w3id.org/sbeo#Scooting</seealso>
    let Scooting = Prefixed_Name(sbeo, "Scooting") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#SeatingArrangementRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of route in which the ending point represents the seat of one or more individuals such as in cinema, stadiums, auditoriums, etc."</para>
    /// labels<para>"Seating Arrangement Route"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SeatingArrangementRoute">https://w3id.org/sbeo#SeatingArrangementRoute</seealso>
    let SeatingArrangementRoute =
        Prefixed_Name(sbeo, "SeatingArrangementRoute") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#SensorEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This concept is used to express an event detected by any sensor."</para>
    /// labels<para>"Sensor Event"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SensorEvent">https://w3id.org/sbeo#SensorEvent</seealso>
    let SensorEvent = Prefixed_Name(sbeo, "SensorEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#SensoryAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensory ability is referred to the brain's ability to receive, interpret, and effectively use the information provided by the senses in human beings such as touch, hear, smell, vision, etc."</para>
    /// labels<para>"Sensor Ability"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SensoryAbility">https://w3id.org/sbeo#SensoryAbility</seealso>
    let SensoryAbility = Prefixed_Name(sbeo, "SensoryAbility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#SensoryImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensory impairment is when one of the senses such as sight, hearing, smell, touch, taste and spatial awareness, is no longer normal."</para>
    /// labels<para>"Sensory Impairmed Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SensoryImpairedPerson">https://w3id.org/sbeo#SensoryImpairedPerson</seealso>
    let SensoryImpairedPerson =
        Prefixed_Name(sbeo, "SensoryImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#SevereHearingImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person who is unable to hear anything without wearing a hearing aid."</para>
    /// labels<para>"Severe Hearing Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SevereHearingImpairedPerson">https://w3id.org/sbeo#SevereHearingImpairedPerson</seealso>
    let SevereHearingImpairedPerson =
        Prefixed_Name(sbeo, "SevereHearingImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#Severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The quality of being hard to endure, uninviting or formidable."</para>
    /// labels<para>"Severity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Severity">https://w3id.org/sbeo#Severity</seealso>
    let Severity = Prefixed_Name(sbeo, "Severity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#ShoppingMallBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of one or more buildings forming a complex of shops representing merchandisers, with interconnecting walkways enabling visitors to easily walk from unit to unit, along with a parking area."</para>
    /// labels<para>"Shopping Mall Building"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ShoppingMallBuilding">https://w3id.org/sbeo#ShoppingMallBuilding</seealso>
    let ShoppingMallBuilding =
        Prefixed_Name(sbeo, "ShoppingMallBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#ShoppingRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of route in which the specific points of interest are mentioned in the form of connected spaces, according to the preferences or interests of a one or more individuals."</para>
    /// labels<para>"Shopping Route"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ShoppingRoute">https://w3id.org/sbeo#ShoppingRoute</seealso>
    let ShoppingRoute = Prefixed_Name(sbeo, "ShoppingRoute") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ShortestPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A type of route having minimum cost in terms of distance or time."</para>
    /// labels<para>"Shortest Path"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ShortestPath">https://w3id.org/sbeo#ShortestPath</seealso>
    let ShortestPath = Prefixed_Name(sbeo, "ShortestPath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#SimplestPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A type of route having minimum complexity in terms of the amount of information required to negotiate each decision point, such as turning points."</para>
    /// labels<para>"Simplest Path"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SimplestPath">https://w3id.org/sbeo#SimplestPath</seealso>
    let SimplestPath = Prefixed_Name(sbeo, "SimplestPath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#SmartPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mobile phone that is able to perform many of the functions of a computer, typically having a relatively large screen and an operating system capable of running general-purpose applications (Oxford Dictionary of English)."</para>
    /// labels<para>"Smartphone"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SmartPhone">https://w3id.org/sbeo#SmartPhone</seealso>
    let SmartPhone = Prefixed_Name(sbeo, "SmartPhone") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#SocialUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An individual, or a group or community, considered as a discrete constituent of a society or larger group (Oxford Dictionary of English)."</para>
    /// labels<para>"Social Unit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SocialUnit">https://w3id.org/sbeo#SocialUnit</seealso>
    let SocialUnit = Prefixed_Name(sbeo, "SocialUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical, three dimensional, and one of the most important elements in the design of architecture that can further be divided to create more spaces from it."</para>
    /// labels<para>"Space"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Space">https://w3id.org/sbeo#Space</seealso>
    let Space = Prefixed_Name(sbeo, "Space") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#SpaceSafety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A parameter to express the safety of any space for a specific person (or type of persons) in terms of some value."</para>
    /// labels<para>"Space Saftey"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SpaceSafety">https://w3id.org/sbeo#SpaceSafety</seealso>
    let SpaceSafety = Prefixed_Name(sbeo, "SpaceSafety") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#SpatialAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This ability expresses the capacity to understand, reason and remember the spatial relations among objects and spaces."</para>
    /// labels<para>"Spatial Ability"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#SpatialAbility">https://w3id.org/sbeo#SpatialAbility</seealso>
    let SpatialAbility = Prefixed_Name(sbeo, "SpatialAbility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#StadiumBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A building that has a large open area surrounded by many rows of seats, and  used for sports events, concerts, etc."</para>
    /// labels<para>"Stadium Building"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#StadiumBuilding">https://w3id.org/sbeo#StadiumBuilding</seealso>
    let StadiumBuilding = Prefixed_Name(sbeo, "StadiumBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Stampeding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sudden and uncontrollable run by the group of people caused by panic."</para>
    /// labels<para>"Stampeding"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Stampeding">https://w3id.org/sbeo#Stampeding</seealso>
    let Stampeding = Prefixed_Name(sbeo, "Stampeding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Standing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Having or maintaining an upright position, supported by one's feet (Oxford Dictionary of English)."</para>
    /// labels<para>"Standing"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Standing">https://w3id.org/sbeo#Standing</seealso>
    let Standing = Prefixed_Name(sbeo, "Standing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Suite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A suite of rooms usually on one floor of an apartment house (Cambridge English Dictionary). This term is normally used in hotels, resorts, guesthouses, etc."</para>
    /// labels<para>"Suite"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Suite">https://w3id.org/sbeo#Suite</seealso>
    let Suite = Prefixed_Name(sbeo, "Suite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device for transmitting voices over a distance using wire or radio, by converting acoustic vibrations to electrical signals (Oxford Dictionary of English)."</para>
    /// labels<para>"Telephone"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Telephone">https://w3id.org/sbeo#Telephone</seealso>
    let Telephone = Prefixed_Name(sbeo, "Telephone") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#TerroristAttack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A surprise event involving the deliberate use of violence against the occupants of the buildings."</para>
    /// labels<para>"Terrorist Attack"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#TerroristAttack">https://w3id.org/sbeo#TerroristAttack</seealso>
    let TerroristAttack = Prefixed_Name(sbeo, "TerroristAttack") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#TextualDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of description in which only text or writings are used to provide the information about any entity."</para>
    /// labels<para>"Textual Description"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#TextualDescription">https://w3id.org/sbeo#TextualDescription</seealso>
    let TextualDescription = Prefixed_Name(sbeo, "TextualDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Thoroughfare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A road or path forming a route between two places (Oxford Dictionary of English)."</para>
    /// labels<para>"Thoroughfare"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Thoroughfare">https://w3id.org/sbeo#Thoroughfare</seealso>
    let Thoroughfare = Prefixed_Name(sbeo, "Thoroughfare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#TooOftenDeviate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This instance is used to express when someone is deviating frequently while following the provided path."</para>
    /// labels<para>"Too Often Deviate"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#TooOftenDeviate">https://w3id.org/sbeo#TooOftenDeviate</seealso>
    let TooOftenDeviate = Prefixed_Name(sbeo, "TooOftenDeviate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#TransitionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A point at which person passes from one place to the next."</para>
    /// labels<para>"Transition Point"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#TransitionPoint">https://w3id.org/sbeo#TransitionPoint</seealso>
    let TransitionPoint = Prefixed_Name(sbeo, "TransitionPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#TurnPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logic point that is used to enforce people to change their direction."</para>
    /// labels<para>"Turn Point"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#TurnPoint">https://w3id.org/sbeo#TurnPoint</seealso>
    let TurnPoint = Prefixed_Name(sbeo, "TurnPoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#UnAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Not available or accessible."</para>
    /// labels<para>"Unavailable"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#UnAvailable">https://w3id.org/sbeo#UnAvailable</seealso>
    let UnAvailable = Prefixed_Name(sbeo, "UnAvailable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#VerticalMovingPavement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A slow-moving conveyor mechanism that transports people across an inclined plane over a short to medium distance."</para>
    /// labels<para>"Vertical Moving Pavement"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#VerticalMovingPavement">https://w3id.org/sbeo#VerticalMovingPavement</seealso>
    let VerticalMovingPavement =
        Prefixed_Name(sbeo, "VerticalMovingPavement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#VerticalPassage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of passage that connects spatial elements located on different storey or floor."</para>
    /// labels<para>"Vertical Passage"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#VerticalPassage">https://w3id.org/sbeo#VerticalPassage</seealso>
    let VerticalPassage = Prefixed_Name(sbeo, "VerticalPassage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Visit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity that represents an act of going to see a person or place as a guest, tourist or a spectator. Normally, this type of activity is considered as a leasiure or recreational activity."</para>
    /// labels<para>"Visit"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Visit">https://w3id.org/sbeo#Visit</seealso>
    let Visit = Prefixed_Name(sbeo, "Visit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#VisitRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A type of route created for visiting purposes within an indoor environment."</para>
    /// labels<para>"Visit Route"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#VisitRoute">https://w3id.org/sbeo#VisitRoute</seealso>
    let VisitRoute = Prefixed_Name(sbeo, "VisitRoute") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Visiting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The activity of making visits."</para>
    /// labels<para>"Visiting"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Visiting">https://w3id.org/sbeo#Visiting</seealso>
    let Visiting = Prefixed_Name(sbeo, "Visiting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#VisitingGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of two or more people that has the same objective of visiting any space."</para>
    /// labels<para>"Visiting Group"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#VisitingGroup">https://w3id.org/sbeo#VisitingGroup</seealso>
    let VisitingGroup = Prefixed_Name(sbeo, "VisitingGroup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#VisuallyImpairedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a partial or total unability to see. It is also known as visual loss. Here, we considered a person having visual impairment who as severe low vision; 20/200 to 20/400 or higher."</para>
    /// labels<para>"Visually Impaired Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#VisuallyImpairedPerson">https://w3id.org/sbeo#VisuallyImpairedPerson</seealso>
    let VisuallyImpairedPerson =
        Prefixed_Name(sbeo, "VisuallyImpairedPerson") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#WaitingZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A space (normally with seating), where people can wait to do some specific activity. During emergency condtions, it is also used for several purposes, such as unification of people with their family members, acquaintances or emergency rescue teams, etc."</para>
    /// labels<para>"Waiting Zone"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#WaitingZone">https://w3id.org/sbeo#WaitingZone</seealso>
    let WaitingZone = Prefixed_Name(sbeo, "WaitingZone") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#Walking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An unhurried rate of movement on foot (Oxford Dictionary of English)."</para>
    /// labels<para>"Walking"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#Walking">https://w3id.org/sbeo#Walking</seealso>
    let Walking = Prefixed_Name(sbeo, "Walking") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#accommodationCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The accommodating capacity (in terms of persons) of a particular space."</para>
    /// labels<para>"Accommodation Capacity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#accommodationCapacity">https://w3id.org/sbeo#accommodationCapacity</seealso>
    let accommodationCapacity =
        Prefixed_Name(sbeo, "accommodationCapacity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#accompanying</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Be present or associated with a person."</para>
    /// labels<para>"Accompanying"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#accompanying">https://w3id.org/sbeo#accompanying</seealso>
    let accompanying = Prefixed_Name(sbeo, "accompanying") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#acquaintanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Any friend or an acquaintance tie among occupants."</para>
    /// labels<para>"Acquaintance Of"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#acquaintanceOf">https://w3id.org/sbeo#acquaintanceOf</seealso>
    let acquaintanceOf = Prefixed_Name(sbeo, "acquaintanceOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#adjacentTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nearest in space or position; immediately adjoining without intervening space or element; an exact neighbour."</para>
    /// labels<para>"Adjacent To"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#adjacentTo">https://w3id.org/sbeo#adjacentTo</seealso>
    let adjacentTo = Prefixed_Name(sbeo, "adjacentTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#assignedRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A set of connected spaces(normally in the form of rdf:list) assigned to a social unit."</para>
    /// labels<para>"Assigned Route"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#assignedRoute">https://w3id.org/sbeo#assignedRoute</seealso>
    let assignedRoute = Prefixed_Name(sbeo, "assignedRoute") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time at which an activity or event occurred."</para>
    /// labels<para>"At Time"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#atTime">https://w3id.org/sbeo#atTime</seealso>
    let atTime = Prefixed_Name(sbeo, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#connectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Being joined by a common element; more specificially, a physical connection between two space elements."</para>
    /// labels<para>"Connected To"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#connectedTo">https://w3id.org/sbeo#connectedTo</seealso>
    let connectedTo = Prefixed_Name(sbeo, "connectedTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The circumstances that form the setting for an event, statement, or idea, and in terms of which it can be fully understood and assessed (Oxford Dictionary of English)."</para>
    /// labels<para>"Context"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#context">https://w3id.org/sbeo#context</seealso>
    let context = Prefixed_Name(sbeo, "context") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#cost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A numeric value associated with an edge or a complete route(path). It is also reffered to as a weight."</para>
    /// labels<para>"Cost"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#cost">https://w3id.org/sbeo#cost</seealso>
    let cost = Prefixed_Name(sbeo, "cost") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#currentOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The current occupancy (in terms of persons) of a particular space."</para>
    /// labels<para>"Current Occupancy"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#currentOccupancy">https://w3id.org/sbeo#currentOccupancy</seealso>
    let currentOccupancy = Prefixed_Name(sbeo, "currentOccupancy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#dynamicDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A dynamic or momentary information about a specific activity, event, social unit, or a space."</para>
    /// labels<para>"Dynamic Description"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#dynamicDescription">https://w3id.org/sbeo#dynamicDescription</seealso>
    let dynamicDescription = Prefixed_Name(sbeo, "dynamicDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#endedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The time at which an activity ended."</para>
    /// labels<para>"Ended At Time"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#endedAtTime">https://w3id.org/sbeo#endedAtTime</seealso>
    let endedAtTime = Prefixed_Name(sbeo, "endedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#excludedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Expresses the removal of any physical space or point of interest for the consideration of any social unit."</para>
    /// labels<para>"Excluded For"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#excludedFor">https://w3id.org/sbeo#excludedFor</seealso>
    let excludedFor = Prefixed_Name(sbeo, "excludedFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#familiarWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"States the familiarity of any social unit with a physical space or point of interest."</para>
    /// labels<para>"Familiar With"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#familiarWith">https://w3id.org/sbeo#familiarWith</seealso>
    let familiarWith = Prefixed_Name(sbeo, "familiarWith") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#forPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property to express a foaf:Person in a n-ary relation for sbeo:Parameter."</para>
    /// labels<para>"For Person"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#forPerson">https://w3id.org/sbeo#forPerson</seealso>
    let forPerson = Prefixed_Name(sbeo, "forPerson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasAbility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property to express a sbeo:Ability in a n-ary relation for sbeo:PersonAbility."</para>
    /// labels<para>"Has Ability"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasAbility">https://w3id.org/sbeo#hasAbility</seealso>
    let hasAbility = Prefixed_Name(sbeo, "hasAbility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasActivityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The status of an activity being performed by a social unit."</para>
    /// labels<para>"Has Activity Status"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasActivityStatus">https://w3id.org/sbeo#hasActivityStatus</seealso>
    let hasActivityStatus = Prefixed_Name(sbeo, "hasActivityStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#hasAvailabilityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The status of something in terms of availability. For example, available or unavailable."</para>
    /// labels<para>"Has Availability Status"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasAvailabilityStatus">https://w3id.org/sbeo#hasAvailabilityStatus</seealso>
    let hasAvailabilityStatus =
        Prefixed_Name(sbeo, "hasAvailabilityStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Expresses a descriptive information about any specific space, point, activiy, event or device."</para>
    /// labels<para>"Has Description"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasDescription">https://w3id.org/sbeo#hasDescription</seealso>
    let hasDescription = Prefixed_Name(sbeo, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasDeviationState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A deviation status of a person depending on how ofthen one deviates from the proposed route."</para>
    /// labels<para>"Has Deviation State"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasDeviationState">https://w3id.org/sbeo#hasDeviationState</seealso>
    let hasDeviationState = Prefixed_Name(sbeo, "hasDeviationState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasFitnessStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A fitness status is associated with a person that represent the quality of being suitable for a specific activity. There are three different levels of fitness levels are introduced that can be extended according to the needs of the application. These are 'Fit', 'Exhausted' and 'Injured'."</para>
    /// labels<para>"Has Fitness Status"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasFitnessStatus">https://w3id.org/sbeo#hasFitnessStatus</seealso>
    let hasFitnessStatus = Prefixed_Name(sbeo, "hasFitnessStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A property to express the impact of a particular sbeo:Activity or sbeo:Event."</para>
    /// labels<para>"Has Impact"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasImpact">https://w3id.org/sbeo#hasImpact</seealso>
    let hasImpact = Prefixed_Name(sbeo, "hasImpact") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property to express the intensity of a particular sbeo:Activity or sbeo:Event."</para>
    /// labels<para>"Has Intensity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasIntensity">https://w3id.org/sbeo#hasIntensity</seealso>
    let hasIntensity = Prefixed_Name(sbeo, "hasIntensity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Expresses one of the persons who compose a social group."</para>
    /// labels<para>"Has Member"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasMember">https://w3id.org/sbeo#hasMember</seealso>
    let hasMember = Prefixed_Name(sbeo, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasMotionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The motion state of a person."</para>
    /// labels<para>"Has Motion State"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasMotionState">https://w3id.org/sbeo#hasMotionState</seealso>
    let hasMotionState = Prefixed_Name(sbeo, "hasMotionState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#hasNavigationalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A navigational state of a social unit while following any path."</para>
    /// labels<para>"Has Navigational State"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasNavigationalState">https://w3id.org/sbeo#hasNavigationalState</seealso>
    let hasNavigationalState =
        Prefixed_Name(sbeo, "hasNavigationalState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#hasNavigationalType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A type of navigation provided to a person to perform a specific activity."</para>
    /// labels<para>"Has Navigation Type"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasNavigationalType">https://w3id.org/sbeo#hasNavigationalType</seealso>
    let hasNavigationalType = Prefixed_Name(sbeo, "hasNavigationalType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property to express a quality of something in terms of different levels. For example, good, bad, medium, perfect, mild, and so forth."</para>
    /// labels<para>"Has Quality"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasQuality">https://w3id.org/sbeo#hasQuality</seealso>
    let hasQuality = Prefixed_Name(sbeo, "hasQuality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A property to express a sbeo:Severity in a n-ary relation for sbeo:ActivitySeverity or  sbeo:EventSeverity."</para>
    /// labels<para>"Has Severity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasSeverity">https://w3id.org/sbeo#hasSeverity</seealso>
    let hasSeverity = Prefixed_Name(sbeo, "hasSeverity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a value that is a direct representation of an entity."</para>
    /// labels<para>"Value"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasValue">https://w3id.org/sbeo#hasValue</seealso>
    let hasValue = Prefixed_Name(sbeo, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#hasXTimesDeviated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of times a social unit is deviated while following the provided path."</para>
    /// labels<para>"Has X Time Deviated"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#hasXTimesDeviated">https://w3id.org/sbeo#hasXTimesDeviated</seealso>
    let hasXTimesDeviated = Prefixed_Name(sbeo, "hasXTimesDeviated") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An unique identification number of something such as, social unit, device, etc."</para>
    /// labels<para>"Identification Number"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#id">https://w3id.org/sbeo#id</seealso>
    let id = Prefixed_Name(sbeo, "id") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#installedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Place or fix (equipment or machinery) in position ready for use (Oxford Dictionary of English)."</para>
    /// labels<para>"Installed In"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#installedIn">https://w3id.org/sbeo#installedIn</seealso>
    let installedIn = Prefixed_Name(sbeo, "installedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#leadsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Be a means of access to a particular space or point."</para>
    /// labels<para>"Lead To"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#leadsTo">https://w3id.org/sbeo#leadsTo</seealso>
    let leadsTo = Prefixed_Name(sbeo, "leadsTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The measurement or extent of something from end to end (Oxford Dictionary of English)."</para>
    /// labels<para>"Length"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#length">https://w3id.org/sbeo#length</seealso>
    let length = Prefixed_Name(sbeo, "length") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"States the location of any social unit, activity, event, physical space, or a point of interest at any other physical space."</para>
    /// labels<para>"Located In"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#locatedIn">https://w3id.org/sbeo#locatedIn</seealso>
    let locatedIn = Prefixed_Name(sbeo, "locatedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#lower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Associates the lower storey in a building."</para>
    /// labels<para>"Lower"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#lower">https://w3id.org/sbeo#lower</seealso>
    let lower = Prefixed_Name(sbeo, "lower") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#meansOfNotification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A method of notifying a social unit."</para>
    /// labels<para>"Means of Notification"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#meansOfNotification">https://w3id.org/sbeo#meansOfNotification</seealso>
    let meansOfNotification = Prefixed_Name(sbeo, "meansOfNotification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#notificationPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A notification preference for any kind of social unit."</para>
    /// labels<para>"Notification Preference"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#notificationPreference">https://w3id.org/sbeo#notificationPreference</seealso>
    let notificationPreference =
        Prefixed_Name(sbeo, "notificationPreference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:sbeo#number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A number assigned to anything."</para>
    /// labels<para>"Has Number"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#number">https://w3id.org/sbeo#number</seealso>
    let number = Prefixed_Name(sbeo, "number") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ofActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A property to express a sbeo:Activity in a n-ary relation for sbeo:ActivitySeverity."</para>
    /// labels<para>"Of Activity"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ofActivity">https://w3id.org/sbeo#ofActivity</seealso>
    let ofActivity = Prefixed_Name(sbeo, "ofActivity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ofEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A property to express a sbeo:Event in a n-ary relation for sbeo:EventSeverity."</para>
    /// labels<para>"Of Event"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ofEvent">https://w3id.org/sbeo#ofEvent</seealso>
    let ofEvent = Prefixed_Name(sbeo, "ofEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#ofSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property to express a sbeo:Space in a n-ary relation for sbeo:Parameter."</para>
    /// labels<para>"Of Space"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#ofSpace">https://w3id.org/sbeo#ofSpace</seealso>
    let ofSpace = Prefixed_Name(sbeo, "ofSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Expresses a physical space as a part or a fragment of another physical space. For example, a block of apartments can be a part of apartment building, etc."</para>
    /// labels<para>"Part Of"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#partOf">https://w3id.org/sbeo#partOf</seealso>
    let partOf = Prefixed_Name(sbeo, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#performedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Expresses an activity carried out by a social unit."</para>
    /// labels<para>"Performed by"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#performedBy">https://w3id.org/sbeo#performedBy</seealso>
    let performedBy = Prefixed_Name(sbeo, "performedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#player</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It express an agent that plays a role in a specific context."</para>
    /// labels<para>"Player"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#player">https://w3id.org/sbeo#player</seealso>
    let player = Prefixed_Name(sbeo, "player") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#responsibleTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Having an obligation to do something, or having control over or care for someone, as part of one's role (Oxford Dictionary of English)."</para>
    /// labels<para>"Responsible To"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#responsibleTo">https://w3id.org/sbeo#responsibleTo</seealso>
    let responsibleTo = Prefixed_Name(sbeo, "responsibleTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Expresses a role of an agent."</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#role">https://w3id.org/sbeo#role</seealso>
    let role = Prefixed_Name(sbeo, "role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#routePreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Route preference of a social unit to perform an activity."</para>
    /// labels<para>"Route Preference"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#routePreference">https://w3id.org/sbeo#routePreference</seealso>
    let routePreference = Prefixed_Name(sbeo, "routePreference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#routeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to express the type of a route in terms of graph-based routes, such as Shortest Path, Simplest Path etc."</para>
    /// labels<para>"Route Type"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#routeType">https://w3id.org/sbeo#routeType</seealso>
    let routeType = Prefixed_Name(sbeo, "routeType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The average speed of a person."</para>
    /// labels<para>"Speed"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#speed">https://w3id.org/sbeo#speed</seealso>
    let speed = Prefixed_Name(sbeo, "speed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#speedFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A multiplying factor that may affect the speed of person while passing through a specific space."</para>
    /// labels<para>"Speed Factor"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#speedFactor">https://w3id.org/sbeo#speedFactor</seealso>
    let speedFactor = Prefixed_Name(sbeo, "speedFactor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#startedAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Start is when an activity is deemed to have been started by an entity, known as trigger."</para>
    /// labels<para>"Started At Time"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#startedAtTime">https://w3id.org/sbeo#startedAtTime</seealso>
    let startedAtTime = Prefixed_Name(sbeo, "startedAtTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#staticDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A static or a fix information about any activity, event, space, social unit, or point of interest."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Static Description"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#staticDescription">https://w3id.org/sbeo#staticDescription</seealso>
    let staticDescription = Prefixed_Name(sbeo, "staticDescription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#timeDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The length of time during which any activity or event lasts."</para>
    /// labels<para>"Time Duration"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#timeDuration">https://w3id.org/sbeo#timeDuration</seealso>
    let timeDuration = Prefixed_Name(sbeo, "timeDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#travelTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A specific period of time required to move from one place to another."</para>
    /// labels<para>"Travel Time"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#travelTime">https://w3id.org/sbeo#travelTime</seealso>
    let travelTime = Prefixed_Name(sbeo, "travelTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#upper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Associates the upper storey in a building."</para>
    /// labels<para>"Upper"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#upper">https://w3id.org/sbeo#upper</seealso>
    let upper = Prefixed_Name(sbeo, "upper") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Expresses a momentary information about a physical space or a point being used by a social unit."</para>
    /// labels<para>"Uses"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#uses">https://w3id.org/sbeo#uses</seealso>
    let uses = Prefixed_Name(sbeo, "uses") |> PrefixedName
    /// <summary>
    ///   <para>w3id:sbeo#width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The measurement or extent of something from side to side (Oxford Dictionary of English)."</para>
    /// labels<para>"Width"</para></remarks>
    /// <seealso href="https://w3id.org/sbeo#width">https://w3id.org/sbeo#width</seealso>
    let width = Prefixed_Name(sbeo, "width") |> PrefixedName
