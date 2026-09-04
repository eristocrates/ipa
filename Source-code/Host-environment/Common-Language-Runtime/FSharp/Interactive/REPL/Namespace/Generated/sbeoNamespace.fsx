#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sbeo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/sbeo#" "sbeo"
    /// <summary>
    ///   <para>rdfs:label : Ability</para>
    ///   <para>rdfs:comment : Possession of the means or skill to do something (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Ability">sbeo:Ability</a>
    /// </summary>
    let Ability = _prefixId.prefix "Ability"
    /// <summary>
    ///   <para>rdfs:label : Ability To Hear</para>
    ///   <para>rdfs:comment : An ability to hear.</para>
    ///   <a href="https://w3id.org/sbeo#AbilityToHear">sbeo:AbilityToHear</a>
    /// </summary>
    let AbilityToHear = _prefixId.prefix "AbilityToHear"
    /// <summary>
    ///   <para>rdfs:label : Ability To Run</para>
    ///   <para>rdfs:comment : An ability to run.</para>
    ///   <a href="https://w3id.org/sbeo#AbilityToRun">sbeo:AbilityToRun</a>
    /// </summary>
    let AbilityToRun = _prefixId.prefix "AbilityToRun"
    /// <summary>
    ///   <para>rdfs:label : Ability To See</para>
    ///   <para>rdfs:comment : An ability to hear.</para>
    ///   <a href="https://w3id.org/sbeo#AbilityToSee">sbeo:AbilityToSee</a>
    /// </summary>
    let AbilityToSee = _prefixId.prefix "AbilityToSee"
    /// <summary>
    ///   <para>rdfs:label : Ability To Talk</para>
    ///   <para>rdfs:comment : An ability to talk.</para>
    ///   <a href="https://w3id.org/sbeo#AbilityToTalk">sbeo:AbilityToTalk</a>
    /// </summary>
    let AbilityToTalk = _prefixId.prefix "AbilityToTalk"
    /// <summary>
    ///   <para>rdfs:label : Ability To Touch</para>
    ///   <para>rdfs:comment : An ability to touch.</para>
    ///   <a href="https://w3id.org/sbeo#AbilityToTouch">sbeo:AbilityToTouch</a>
    /// </summary>
    let AbilityToTouch = _prefixId.prefix "AbilityToTouch"
    /// <summary>
    ///   <para>rdfs:label : Ability To Use Stairs</para>
    ///   <para>rdfs:comment : An ability to use the stairs. Note that the people on the wheelchair are not considered to have this ability no matter the stairs have a stairlift and a ramp.</para>
    ///   <a href="https://w3id.org/sbeo#AbilityToUseStairs">sbeo:AbilityToUseStairs</a>
    /// </summary>
    let AbilityToUseStairs = _prefixId.prefix "AbilityToUseStairs"
    /// <summary>
    ///   <para>rdfs:label : Ability To Walk</para>
    ///   <para>rdfs:comment : An ability of a person to walk. A person who is using crutches is also considered to have this ability.</para>
    ///   <a href="https://w3id.org/sbeo#AbilityToWalk">sbeo:AbilityToWalk</a>
    /// </summary>
    let AbilityToWalk = _prefixId.prefix "AbilityToWalk"
    /// <summary>
    ///   <para>rdfs:label : Active Fire Protection Device</para>
    ///   <para>rdfs:comment : It is an integral part of the fire protection used as a first response to minimize the spread of fire and related effects.</para>
    ///   <a href="https://w3id.org/sbeo#ActiveFireProtectionDevice">sbeo:ActiveFireProtectionDevice</a>
    /// </summary>
    let ActiveFireProtectionDevice = _prefixId.prefix "ActiveFireProtectionDevice"
    /// <summary>
    ///   <para>rdfs:label : Activity</para>
    ///   <para>rdfs:comment : A process that a person, group of persons, or machine does during a specific amount of time, such as visiting, shopping, etc.</para>
    ///   <a href="https://w3id.org/sbeo#Activity">sbeo:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Activity Impact</para>
    ///   <para>rdfs:comment : A parameter to express the impact of an activity on a specific person (or type of persons) in terms of any specific value or a type.</para>
    ///   <a href="https://w3id.org/sbeo#ActivityImpact">sbeo:ActivityImpact</a>
    /// </summary>
    let ActivityImpact = _prefixId.prefix "ActivityImpact"
    /// <summary>
    ///   <para>rdfs:label : Activity Severity</para>
    ///   <para>rdfs:comment : A parameter to express the severity of an activity for a specific person (or type of persons) in terms of  potential severity levels.</para>
    ///   <a href="https://w3id.org/sbeo#ActivitySeverity">sbeo:ActivitySeverity</a>
    /// </summary>
    let ActivitySeverity = _prefixId.prefix "ActivitySeverity"
    /// <summary>
    ///   <para>rdfs:label : Activity Status</para>
    ///   <para>rdfs:comment : It expresses the status of a specific activity being performed by a person.</para>
    ///   <a href="https://w3id.org/sbeo#ActivityStatus">sbeo:ActivityStatus</a>
    /// </summary>
    let ActivityStatus = _prefixId.prefix "ActivityStatus"
    /// <summary>
    ///   <para>rdfs:label : Alerting Device</para>
    ///   <para>rdfs:comment : Alerting devices are those devices that are used to react to normal as well as alarming situations to let people know that some specific condition is occuring.</para>
    ///   <a href="https://w3id.org/sbeo#AlertingDevice">sbeo:AlertingDevice</a>
    /// </summary>
    let AlertingDevice = _prefixId.prefix "AlertingDevice"

    /// <summary>
    ///   <para>rdfs:label : Alerting Device For Impaired Person</para>
    ///   <para>rdfs:comment : An alerting device that is used to assist or notify people with impairments during a specific circumstance.</para>
    ///   <a href="https://w3id.org/sbeo#AlertingDeviceForImpairedPerson">sbeo:AlertingDeviceForImpairedPerson</a>
    /// </summary>
    let AlertingDeviceForImpairedPerson =
        _prefixId.prefix "AlertingDeviceForImpairedPerson"

    /// <summary>
    ///   <para>rdfs:label : Alzheimer's Diseased Person</para>
    ///   <para>rdfs:comment : A person having an Alzheimer's disease.</para>
    ///   <a href="https://w3id.org/sbeo#AlzheimersDiseasedPerson">sbeo:AlzheimersDiseasedPerson</a>
    /// </summary>
    let AlzheimersDiseasedPerson = _prefixId.prefix "AlzheimersDiseasedPerson"
    /// <summary>
    ///   <para>rdfs:label : Apartment</para>
    ///   <para>rdfs:comment : A suite of rooms usually on one floor of an apartment house (Cambridge English Dictionary).</para>
    ///   <a href="https://w3id.org/sbeo#Apartment">sbeo:Apartment</a>
    /// </summary>
    let Apartment = _prefixId.prefix "Apartment"
    /// <summary>
    ///   <para>rdfs:label : Appartment Building</para>
    ///   <para>rdfs:comment : A set of one or more buildings that contain apartments in it.</para>
    ///   <a href="https://w3id.org/sbeo#AppartmentBuilding">sbeo:AppartmentBuilding</a>
    /// </summary>
    let AppartmentBuilding = _prefixId.prefix "AppartmentBuilding"
    /// <summary>
    ///   <para>rdfs:label : Assembly Point</para>
    ///   <para>rdfs:comment : A place where people in an office, etc. should go if there is an emergency, for example, a fire (Cambridge English Dictionary) .</para>
    ///   <a href="https://w3id.org/sbeo#AssemblyPoint">sbeo:AssemblyPoint</a>
    /// </summary>
    let AssemblyPoint = _prefixId.prefix "AssemblyPoint"
    let AssistedNavigation = _prefixId.prefix "AssistedNavigation"
    /// <summary>
    ///   <para>rdfs:label : Audio Description</para>
    ///   <para>rdfs:comment : A type of description in which sounds such as voices, are used to provide the information about any entity.</para>
    ///   <a href="https://w3id.org/sbeo#AudioDescription">sbeo:AudioDescription</a>
    /// </summary>
    let AudioDescription = _prefixId.prefix "AudioDescription"
    /// <summary>
    ///   <para>rdfs:label : Autonomous Mobility Person</para>
    ///   <para>rdfs:comment : A person who can walk on his/her with a help of a non-motorised device, e.g. crutches.</para>
    ///   <a href="https://w3id.org/sbeo#AutonomousMobilityPerson">sbeo:AutonomousMobilityPerson</a>
    /// </summary>
    let AutonomousMobilityPerson = _prefixId.prefix "AutonomousMobilityPerson"
    let AutonomousNavigation = _prefixId.prefix "AutonomousNavigation"
    /// <summary>
    ///   <para>rdfs:label : Availability Status</para>
    ///   <para>rdfs:comment : It expresses the status of something that is either available or not.</para>
    ///   <a href="https://w3id.org/sbeo#AvailabilityStatus">sbeo:AvailabilityStatus</a>
    /// </summary>
    let AvailabilityStatus = _prefixId.prefix "AvailabilityStatus"
    let Available = _prefixId.prefix "Available"
    /// <summary>
    ///   <para>rdfs:label : Blind Person</para>
    ///   <para>rdfs:comment : A person who has lost the vision completly and can neither see naturally nor with the help of any device.</para>
    ///   <a href="https://w3id.org/sbeo#BlindPerson">sbeo:BlindPerson</a>
    /// </summary>
    let BlindPerson = _prefixId.prefix "BlindPerson"
    /// <summary>
    ///   <para>rdfs:label : Building Entrance</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the entrance to a building.</para>
    ///   <a href="https://w3id.org/sbeo#BuildingEntrance">sbeo:BuildingEntrance</a>
    /// </summary>
    let BuildingEntrance = _prefixId.prefix "BuildingEntrance"
    /// <summary>
    ///   <para>rdfs:label : Building Exit</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the exit of a building.</para>
    ///   <a href="https://w3id.org/sbeo#BuildingExit">sbeo:BuildingExit</a>
    /// </summary>
    let BuildingExit = _prefixId.prefix "BuildingExit"
    /// <summary>
    ///   <para>rdfs:label : Chemical Spill</para>
    ///   <para>rdfs:comment : A hazardous event that happens due to the spillage or leakge of any toxic chemical in the building.</para>
    ///   <a href="https://w3id.org/sbeo#ChemicalSpill">sbeo:ChemicalSpill</a>
    /// </summary>
    let ChemicalSpill = _prefixId.prefix "ChemicalSpill"
    /// <summary>
    ///   <para>rdfs:label : Cinema Building</para>
    ///   <para>rdfs:comment : A building in which movies are shown.</para>
    ///   <a href="https://w3id.org/sbeo#CinemaBuilding">sbeo:CinemaBuilding</a>
    /// </summary>
    let CinemaBuilding = _prefixId.prefix "CinemaBuilding"
    /// <summary>
    ///   <para>rdfs:label : Classroom</para>
    ///   <para>rdfs:comment : A room, typically in a school, in which a class of students is taught (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Classroom">sbeo:Classroom</a>
    /// </summary>
    let Classroom = _prefixId.prefix "Classroom"
    let CollaborativeNavigation = _prefixId.prefix "CollaborativeNavigation"
    /// <summary>
    ///   <para>rdfs:label : Colour Blind Person</para>
    ///   <para>rdfs:comment : A person having the decreased ability to see color or differences in color.</para>
    ///   <a href="https://w3id.org/sbeo#ColourBlindPerson">sbeo:ColourBlindPerson</a>
    /// </summary>
    let ColourBlindPerson = _prefixId.prefix "ColourBlindPerson"
    /// <summary>
    ///   <para>rdfs:label : Congestion</para>
    ///   <para>rdfs:comment : An event that happens at bottlenecks when the flow of people increases than a provided limit due to herding (and similar phenomena of human behaviour), especially during an emergency evacuation process.</para>
    ///   <a href="https://w3id.org/sbeo#Congestion">sbeo:Congestion</a>
    /// </summary>
    let Congestion = _prefixId.prefix "Congestion"
    /// <summary>
    ///   <para>rdfs:label : Corridor Entrance</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the entrance to a corridor.</para>
    ///   <a href="https://w3id.org/sbeo#CorridorEntrance">sbeo:CorridorEntrance</a>
    /// </summary>
    let CorridorEntrance = _prefixId.prefix "CorridorEntrance"
    /// <summary>
    ///   <para>rdfs:label : Corridor Exit</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the exit of a corridor.</para>
    ///   <a href="https://w3id.org/sbeo#CorridorExit">sbeo:CorridorExit</a>
    /// </summary>
    let CorridorExit = _prefixId.prefix "CorridorExit"
    /// <summary>
    ///   <para>rdfs:label : Corridor Segment</para>
    ///   <para>rdfs:comment : A fragment or an atomic element of a corridor.</para>
    ///   <a href="https://w3id.org/sbeo#CorridorSegment">sbeo:CorridorSegment</a>
    /// </summary>
    let CorridorSegment = _prefixId.prefix "CorridorSegment"
    /// <summary>
    ///   <para>rdfs:label : Day Care</para>
    ///   <para>rdfs:comment : A place where infants and young children are provided a supervision and care of during the daytime, particularly so that their parents can hold jobs.</para>
    ///   <a href="https://w3id.org/sbeo#DayCare">sbeo:DayCare</a>
    /// </summary>
    let DayCare = _prefixId.prefix "DayCare"
    /// <summary>
    ///   <para>rdfs:label : Description</para>
    ///   <para>rdfs:comment : A representation and detail of a person, object, or event. It is used to describe the details of anything.</para>
    ///   <a href="https://w3id.org/sbeo#Description">sbeo:Description</a>
    /// </summary>
    let Description = _prefixId.prefix "Description"
    let DeviatingFromPath = _prefixId.prefix "DeviatingFromPath"
    /// <summary>
    ///   <para>rdfs:label : Deviation State</para>
    ///   <para>rdfs:comment : It models the user's deviation state from one's proposed route. For example, NoDeviate, RareDeviate, OftenDeviate, and TooOftenDeviate.</para>
    ///   <a href="https://w3id.org/sbeo#DeviationState">sbeo:DeviationState</a>
    /// </summary>
    let DeviationState = _prefixId.prefix "DeviationState"
    /// <summary>
    ///   <para>rdfs:label : Device</para>
    ///   <para>rdfs:comment : A thing made or adapted for a particular purpose, especially a piece of mechanical or electronic equipment (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Device">sbeo:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>rdfs:label : Display Screen</para>
    ///   <para>rdfs:comment : A display screen is an output device to represent the information in visual or tactile form.</para>
    ///   <a href="https://w3id.org/sbeo#DisplayScreen">sbeo:DisplayScreen</a>
    /// </summary>
    let DisplayScreen = _prefixId.prefix "DisplayScreen"
    /// <summary>
    ///   <para>rdfs:label : Down Syndrome Person</para>
    ///   <para>rdfs:comment : A person with Down's syndrome.</para>
    ///   <a href="https://w3id.org/sbeo#DownSyndromePerson">sbeo:DownSyndromePerson</a>
    /// </summary>
    let DownSyndromePerson = _prefixId.prefix "DownSyndromePerson"
    /// <summary>
    ///   <para>rdfs:label : Earthquake</para>
    ///   <para>rdfs:comment : A sudden violent shaking of the ground, typically causing great destruction, as a result of movements within the earth's crust or volcanic action (Oxford Dictionary of English). It may cause a sudden panic among the occupants of the building.</para>
    ///   <a href="https://w3id.org/sbeo#Earthquake">sbeo:Earthquake</a>
    /// </summary>
    let Earthquake = _prefixId.prefix "Earthquake"
    /// <summary>
    ///   <para>rdfs:label : Emergency Activity</para>
    ///   <para>rdfs:comment : An activity that is done with an urgency and highest priority.</para>
    ///   <a href="https://w3id.org/sbeo#EmergencyActivity">sbeo:EmergencyActivity</a>
    /// </summary>
    let EmergencyActivity = _prefixId.prefix "EmergencyActivity"
    /// <summary>
    ///   <para>rdfs:label : Emergency Evacuation</para>
    ///   <para>rdfs:comment : It represents an immediate escape of people away from a particular area that has ongoing or imminent hazard to their lives or property.</para>
    ///   <a href="https://w3id.org/sbeo#EmergencyEvacuation">sbeo:EmergencyEvacuation</a>
    /// </summary>
    let EmergencyEvacuation = _prefixId.prefix "EmergencyEvacuation"
    /// <summary>
    ///   <para>rdfs:label : Emergency Evacuation Group</para>
    ///   <para>rdfs:comment : A group of two or more persons who are supposed to evacuate the building together.</para>
    ///   <a href="https://w3id.org/sbeo#EmergencyEvacuationGroup">sbeo:EmergencyEvacuationGroup</a>
    /// </summary>
    let EmergencyEvacuationGroup = _prefixId.prefix "EmergencyEvacuationGroup"
    /// <summary>
    ///   <para>rdfs:label : Emergency Evacuation Route</para>
    ///   <para>rdfs:comment : A type of route in which only those spaces are mentioned that are potentially safe for its users as well as the ending point of it must be an exit from a particular space.</para>
    ///   <a href="https://w3id.org/sbeo#EmergencyEvacuationRoute">sbeo:EmergencyEvacuationRoute</a>
    /// </summary>
    let EmergencyEvacuationRoute = _prefixId.prefix "EmergencyEvacuationRoute"
    /// <summary>
    ///   <para>rdfs:label : Emergency Exit</para>
    ///   <para>rdfs:comment : Emergency exit is logical point that is only used in case of any emergency conditions such as fire, etc.</para>
    ///   <a href="https://w3id.org/sbeo#EmergencyExit">sbeo:EmergencyExit</a>
    /// </summary>
    let EmergencyExit = _prefixId.prefix "EmergencyExit"
    /// <summary>
    ///   <para>rdfs:label : End Point</para>
    ///   <para>rdfs:comment : A logic point that is used to indicate the end of a corridor.</para>
    ///   <a href="https://w3id.org/sbeo#EndPoint">sbeo:EndPoint</a>
    /// </summary>
    let EndPoint = _prefixId.prefix "EndPoint"
    /// <summary>
    ///   <para>rdfs:label : Entrance</para>
    ///   <para>rdfs:comment : Entrance represents a space or a door that is used to enter into a building. Normally, it is also used as an exit.</para>
    ///   <a href="https://w3id.org/sbeo#Entrance">sbeo:Entrance</a>
    /// </summary>
    let Entrance = _prefixId.prefix "Entrance"
    /// <summary>
    ///   <para>rdfs:label : Escalator</para>
    ///   <para>rdfs:comment : A moving staircase consisting of an endlessly circulating belt of steps driven by a motor, which conveys people between the floors of a public building (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Escalator">sbeo:Escalator</a>
    /// </summary>
    let Escalator = _prefixId.prefix "Escalator"

    /// <summary>
    ///   <para>rdfs:label : Escort Supported Wheelchair Person</para>
    ///   <para>rdfs:comment : A physical impaired person whose wheelchair is escorted by another person.</para>
    ///   <a href="https://w3id.org/sbeo#EscortSupportedWheelchairPerson">sbeo:EscortSupportedWheelchairPerson</a>
    /// </summary>
    let EscortSupportedWheelchairPerson =
        _prefixId.prefix "EscortSupportedWheelchairPerson"

    let Evacuated = _prefixId.prefix "Evacuated"
    let Evacuating = _prefixId.prefix "Evacuating"
    /// <summary>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : An occurrence; something that happens (Oxford Dictionary of English). It represents when something planned or sudden happens.</para>
    ///   <a href="https://w3id.org/sbeo#Event">sbeo:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Event Impact</para>
    ///   <para>rdfs:comment : A parameter to express the impact of an event on a specific person (or type of persons) in terms of any specific value or a type.</para>
    ///   <a href="https://w3id.org/sbeo#EventImpact">sbeo:EventImpact</a>
    /// </summary>
    let EventImpact = _prefixId.prefix "EventImpact"
    /// <summary>
    ///   <para>rdfs:label : Event Severity</para>
    ///   <para>rdfs:comment : A parameter to express the severity of an event for a specific person (or type of persons) in terms of  potential severity levels.</para>
    ///   <a href="https://w3id.org/sbeo#EventSeverity">sbeo:EventSeverity</a>
    /// </summary>
    let EventSeverity = _prefixId.prefix "EventSeverity"
    let Exhausted = _prefixId.prefix "Exhausted"
    /// <summary>
    ///   <para>rdfs:label : Exit</para>
    ///   <para>rdfs:comment : Exit represents a logical representation for escaping or releasing from a specific phsyical space. Generally, an exit is as same as an entrance.</para>
    ///   <a href="https://w3id.org/sbeo#Exit">sbeo:Exit</a>
    /// </summary>
    let Exit = _prefixId.prefix "Exit"
    /// <summary>
    ///   <para>rdfs:label : Exit Route</para>
    ///   <para>rdfs:comment : A type of route in which the ending point represents the exit of a specific space.</para>
    ///   <a href="https://w3id.org/sbeo#ExitRoute">sbeo:ExitRoute</a>
    /// </summary>
    let ExitRoute = _prefixId.prefix "ExitRoute"
    /// <summary>
    ///   <para>rdfs:label : Family</para>
    ///   <para>rdfs:comment : A group of two or more persons having family ties between them.</para>
    ///   <a href="https://w3id.org/sbeo#Family">sbeo:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:label : Fire</para>
    ///   <para>rdfs:comment : An event that may burn different parts of the building and hazourdous for both the people and the building.</para>
    ///   <a href="https://w3id.org/sbeo#Fire">sbeo:Fire</a>
    /// </summary>
    let Fire = _prefixId.prefix "Fire"
    /// <summary>
    ///   <para>rdfs:label : Fire Door</para>
    ///   <para>rdfs:comment : A type of door used to minimize the spread of fire and related effects by isolating two connected spaces or sections in the building.</para>
    ///   <a href="https://w3id.org/sbeo#FireDoor">sbeo:FireDoor</a>
    /// </summary>
    let FireDoor = _prefixId.prefix "FireDoor"
    /// <summary>
    ///   <para>rdfs:label : Fire Escape Ladder</para>
    ///   <para>rdfs:comment : A type of ladder which is used to make an emergency exit through the window out of fire accident site.</para>
    ///   <a href="https://w3id.org/sbeo#FireEscapeLadder">sbeo:FireEscapeLadder</a>
    /// </summary>
    let FireEscapeLadder = _prefixId.prefix "FireEscapeLadder"
    /// <summary>
    ///   <para>rdfs:label : Fire Extinguisher</para>
    ///   <para>rdfs:comment : An active fire protection instrument used by persons to blow out small scale fire.</para>
    ///   <a href="https://w3id.org/sbeo#FireExtinguisher">sbeo:FireExtinguisher</a>
    /// </summary>
    let FireExtinguisher = _prefixId.prefix "FireExtinguisher"
    /// <summary>
    ///   <para>rdfs:label : Fire Protection Device</para>
    ///   <para>rdfs:comment : Device that is used to minimize the effects of potentially danger fires.</para>
    ///   <a href="https://w3id.org/sbeo#FireProtectionDevice">sbeo:FireProtectionDevice</a>
    /// </summary>
    let FireProtectionDevice = _prefixId.prefix "FireProtectionDevice"
    let Fit = _prefixId.prefix "Fit"
    /// <summary>
    ///   <para>rdfs:label : Fitness Status</para>
    ///   <para>rdfs:comment : A fitness status is associated with a person that represent the quality of being suitable for a specific activity.</para>
    ///   <a href="https://w3id.org/sbeo#FitnessStatus">sbeo:FitnessStatus</a>
    /// </summary>
    let FitnessStatus = _prefixId.prefix "FitnessStatus"
    /// <summary>
    ///   <para>rdfs:label : Floor Entrance</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the entrance to a floor.</para>
    ///   <a href="https://w3id.org/sbeo#FloorEntrance">sbeo:FloorEntrance</a>
    /// </summary>
    let FloorEntrance = _prefixId.prefix "FloorEntrance"
    /// <summary>
    ///   <para>rdfs:label : Floor Exit</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the exit of a specific floor and that leads to different floors of a building.</para>
    ///   <a href="https://w3id.org/sbeo#FloorExit">sbeo:FloorExit</a>
    /// </summary>
    let FloorExit = _prefixId.prefix "FloorExit"
    let FollowingPath = _prefixId.prefix "FollowingPath"
    /// <summary>
    ///   <para>rdfs:label : Footpath</para>
    ///   <para>rdfs:comment : A path for pedestrians in a built-up area; a pavement.</para>
    ///   <a href="https://w3id.org/sbeo#Footpath">sbeo:Footpath</a>
    /// </summary>
    let Footpath = _prefixId.prefix "Footpath"
    /// <summary>
    ///   <para>rdfs:label : Graph-Based Route</para>
    ///   <para>rdfs:comment : A graph-based route is a graphical way of representing a route in terms of nodes (sometimes called vertices) and edges (sometimes called arcs).</para>
    ///   <a href="https://w3id.org/sbeo#GraphBasedRoute">sbeo:GraphBasedRoute</a>
    /// </summary>
    let GraphBasedRoute = _prefixId.prefix "GraphBasedRoute"
    /// <summary>
    ///   <para>rdfs:label : Group</para>
    ///   <para>rdfs:comment : It represents a collection of two or more people who interact with each other and may have the similar characteristics or objectives.</para>
    ///   <a href="https://w3id.org/sbeo#Group">sbeo:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : Hall Entrance</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the entrance to a hall.</para>
    ///   <a href="https://w3id.org/sbeo#HallEntrance">sbeo:HallEntrance</a>
    /// </summary>
    let HallEntrance = _prefixId.prefix "HallEntrance"
    /// <summary>
    ///   <para>rdfs:label : Hall Exit</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the exit of a Hall.</para>
    ///   <a href="https://w3id.org/sbeo#HallExit">sbeo:HallExit</a>
    /// </summary>
    let HallExit = _prefixId.prefix "HallExit"
    /// <summary>
    ///   <para>rdfs:label : Hall Segment</para>
    ///   <para>rdfs:comment : A fragment or an atomic element of a hall.</para>
    ///   <a href="https://w3id.org/sbeo#HallSegment">sbeo:HallSegment</a>
    /// </summary>
    let HallSegment = _prefixId.prefix "HallSegment"
    /// <summary>
    ///   <para>rdfs:label : Handheld Device</para>
    ///   <para>rdfs:comment : A smart device or a computer that is small enough to be used while holding it in the hands.</para>
    ///   <a href="https://w3id.org/sbeo#HandheldDevice">sbeo:HandheldDevice</a>
    /// </summary>
    let HandheldDevice = _prefixId.prefix "HandheldDevice"
    /// <summary>
    ///   <para>rdfs:label : Hearing Impaired Person</para>
    ///   <para>rdfs:comment : It is a partial or total unability to hear. It is also known as Hearing loss.</para>
    ///   <a href="https://w3id.org/sbeo#HearingImpairedPerson">sbeo:HearingImpairedPerson</a>
    /// </summary>
    let HearingImpairedPerson = _prefixId.prefix "HearingImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Horizontal Moving Pavement</para>
    ///   <para>rdfs:comment : A slow-moving conveyor mechanism that transports people across a horizontal plane over a short to medium distance.</para>
    ///   <a href="https://w3id.org/sbeo#HorizontalMovingPavement">sbeo:HorizontalMovingPavement</a>
    /// </summary>
    let HorizontalMovingPavement = _prefixId.prefix "HorizontalMovingPavement"
    /// <summary>
    ///   <para>rdfs:label : Horizontal Passage</para>
    ///   <para>rdfs:comment : A type of a passage that connects spatial elements located on the same storey or floor.</para>
    ///   <a href="https://w3id.org/sbeo#HorizontalPassage">sbeo:HorizontalPassage</a>
    /// </summary>
    let HorizontalPassage = _prefixId.prefix "HorizontalPassage"
    /// <summary>
    ///   <para>rdfs:label : Hotel Building</para>
    ///   <para>rdfs:comment : A building that contains rooms, apartments or suites where people stay for a specific time period.</para>
    ///   <a href="https://w3id.org/sbeo#HotelBuilding">sbeo:HotelBuilding</a>
    /// </summary>
    let HotelBuilding = _prefixId.prefix "HotelBuilding"
    /// <summary>
    ///   <para>rdfs:label : Image Description</para>
    ///   <para>rdfs:comment : A type of description in which images are given to provide information about any entity.</para>
    ///   <a href="https://w3id.org/sbeo#ImageDescription">sbeo:ImageDescription</a>
    /// </summary>
    let ImageDescription = _prefixId.prefix "ImageDescription"
    /// <summary>
    ///   <para>rdfs:label : Impact</para>
    ///   <para>rdfs:comment : An impact is a long-lasting effect of an event (or activity), that continues to exist after the event (or activity) has taken place.</para>
    ///   <a href="https://w3id.org/sbeo#Impact">sbeo:Impact</a>
    /// </summary>
    let Impact = _prefixId.prefix "Impact"
    /// <summary>
    ///   <para>rdfs:label : Impaired Person</para>
    ///   <para>rdfs:comment : An individual whose natural senses or physical abilities are either diminished or damaged.</para>
    ///   <a href="https://w3id.org/sbeo#ImpairedPerson">sbeo:ImpairedPerson</a>
    /// </summary>
    let ImpairedPerson = _prefixId.prefix "ImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Incident</para>
    ///   <para>rdfs:comment : An event or occurance that can be dangerous for the occupants of the building.</para>
    ///   <a href="https://w3id.org/sbeo#Incident">sbeo:Incident</a>
    /// </summary>
    let Incident = _prefixId.prefix "Incident"
    /// <summary>
    ///   <para>rdfs:label : Incident Protection Device</para>
    ///   <para>rdfs:comment : Device that is used to avoid and minimize the effects of potentially danger events for the occupants of the building as well as for the structure of building itself.</para>
    ///   <a href="https://w3id.org/sbeo#IncidentProtectionDevice">sbeo:IncidentProtectionDevice</a>
    /// </summary>
    let IncidentProtectionDevice = _prefixId.prefix "IncidentProtectionDevice"
    let Injured = _prefixId.prefix "Injured"
    /// <summary>
    ///   <para>rdfs:label : Intensity</para>
    ///   <para>rdfs:comment : The measurable amount of a property, such as force, brightness, or a magnetic field (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Intensity">sbeo:Intensity</a>
    /// </summary>
    let Intensity = _prefixId.prefix "Intensity"
    /// <summary>
    ///   <para>rdfs:label : Junction</para>
    ///   <para>rdfs:comment : A logic point that connects more than two corridors.</para>
    ///   <a href="https://w3id.org/sbeo#Junction">sbeo:Junction</a>
    /// </summary>
    let Junction = _prefixId.prefix "Junction"
    /// <summary>
    ///   <para>rdfs:label : Kids Area</para>
    ///   <para>rdfs:comment : A place where infants or young children can play which is surrounded by a boundary normally. It can be both indoor and outdoor.</para>
    ///   <a href="https://w3id.org/sbeo#KidsArea">sbeo:KidsArea</a>
    /// </summary>
    let KidsArea = _prefixId.prefix "KidsArea"
    /// <summary>
    ///   <para>rdfs:label : Low Stamina Person</para>
    ///   <para>rdfs:comment : It is the unability to sustain physical or mental activity to a normal level.</para>
    ///   <a href="https://w3id.org/sbeo#LowStaminaPerson">sbeo:LowStaminaPerson</a>
    /// </summary>
    let LowStaminaPerson = _prefixId.prefix "LowStaminaPerson"
    /// <summary>
    ///   <para>rdfs:label : Low Vision Person</para>
    ///   <para>rdfs:comment : A person whose visual acuity is 20/70 or poorer in the better-seeing eye and cannot be corrected or improved with regular eyeglasses.</para>
    ///   <a href="https://w3id.org/sbeo#LowVisionPerson">sbeo:LowVisionPerson</a>
    /// </summary>
    let LowVisionPerson = _prefixId.prefix "LowVisionPerson"
    /// <summary>
    ///   <para>rdfs:label : Meeting Room</para>
    ///   <para>rdfs:comment : A type of room designated for social gathering of people, especially professional meetings.</para>
    ///   <a href="https://w3id.org/sbeo#MeetingRoom">sbeo:MeetingRoom</a>
    /// </summary>
    let MeetingRoom = _prefixId.prefix "MeetingRoom"
    /// <summary>
    ///   <para>rdfs:label : Mental Ability</para>
    ///   <para>rdfs:comment : The mental ability of an indi-vidual to remain focused on an external stimuli or an internal experience for a certain period of time (World Health Organisation).</para>
    ///   <a href="https://w3id.org/sbeo#MentalAbility">sbeo:MentalAbility</a>
    /// </summary>
    let MentalAbility = _prefixId.prefix "MentalAbility"
    /// <summary>
    ///   <para>rdfs:label : Mental Impaired Person</para>
    ///   <para>rdfs:comment : A person having mental impairment in which one's mind is damaged or is not working properly and one have issues such as consciousness, orientation, concentration.</para>
    ///   <a href="https://w3id.org/sbeo#MentalImpairedPerson">sbeo:MentalImpairedPerson</a>
    /// </summary>
    let MentalImpairedPerson = _prefixId.prefix "MentalImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Mild Hearing Impaired Person</para>
    ///   <para>rdfs:comment : A person who is only able to hear the sounds that are between 25 and 40 dB.</para>
    ///   <a href="https://w3id.org/sbeo#MildHearingImpairedPerson">sbeo:MildHearingImpairedPerson</a>
    /// </summary>
    let MildHearingImpairedPerson = _prefixId.prefix "MildHearingImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Mobile Phone</para>
    ///   <para>rdfs:comment : A telephone with access to a cellular radio system so it can be used over a wide area, without a physical connection to a network (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#MobilePhone">sbeo:MobilePhone</a>
    /// </summary>
    let MobilePhone = _prefixId.prefix "MobilePhone"
    /// <summary>
    ///   <para>rdfs:label : Mobility Ability</para>
    ///   <para>rdfs:comment : This ability is used to represent all kinetic abilities a person may have.</para>
    ///   <a href="https://w3id.org/sbeo#MobilityAbility">sbeo:MobilityAbility</a>
    /// </summary>
    let MobilityAbility = _prefixId.prefix "MobilityAbility"

    /// <summary>
    ///   <para>rdfs:label : Mobility With Assisted Device Person</para>
    ///   <para>rdfs:comment : A person who used a motorised device for moving, such as motorised wheelchair or scooter, etc.</para>
    ///   <a href="https://w3id.org/sbeo#MobilityWithAssistedDevicePerson">sbeo:MobilityWithAssistedDevicePerson</a>
    /// </summary>
    let MobilityWithAssistedDevicePerson =
        _prefixId.prefix "MobilityWithAssistedDevicePerson"

    /// <summary>
    ///   <para>rdfs:label : Mobility With Wheelchair Person</para>
    ///   <para>rdfs:comment : A person using a wheelchair (a mobility device that is used while having any kind of tempoary or permanent physical impairment).</para>
    ///   <a href="https://w3id.org/sbeo#MobilityWithWheelchairPerson">sbeo:MobilityWithWheelchairPerson</a>
    /// </summary>
    let MobilityWithWheelchairPerson = _prefixId.prefix "MobilityWithWheelchairPerson"
    /// <summary>
    ///   <para>rdfs:label : Moderate Hearing Impaired Person</para>
    ///   <para>rdfs:comment : A person who cannot hear sounds that are less than 40-75 dB.</para>
    ///   <a href="https://w3id.org/sbeo#ModerateHearingImpairedPerson">sbeo:ModerateHearingImpairedPerson</a>
    /// </summary>
    let ModerateHearingImpairedPerson = _prefixId.prefix "ModerateHearingImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Motion State</para>
    ///   <para>rdfs:comment : It describes the movement of a person.</para>
    ///   <a href="https://w3id.org/sbeo#MotionState">sbeo:MotionState</a>
    /// </summary>
    let MotionState = _prefixId.prefix "MotionState"
    /// <summary>
    ///   <para>rdfs:label : Motor Impaired Person</para>
    ///   <para>rdfs:comment : A person who has either partial or total loss of function of a body part, usually a limb or limbs.</para>
    ///   <a href="https://w3id.org/sbeo#MotorImpairedPerson">sbeo:MotorImpairedPerson</a>
    /// </summary>
    let MotorImpairedPerson = _prefixId.prefix "MotorImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Motorised Wheelchair Person</para>
    ///   <para>rdfs:comment : It is a kind of wheelchair that has either a mechanical engine or an electric battery. It has more speed than a traditional wheelchair.</para>
    ///   <a href="https://w3id.org/sbeo#MotorisedWheelchairPerson">sbeo:MotorisedWheelchairPerson</a>
    /// </summary>
    let MotorisedWheelchairPerson = _prefixId.prefix "MotorisedWheelchairPerson"
    /// <summary>
    ///   <para>rdfs:label : Moving Pavement</para>
    ///   <para>rdfs:comment : A slow-moving conveyor mechanism that transports people across a horizontal or inclined plane over a short to medium distance (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#MovingPavement">sbeo:MovingPavement</a>
    /// </summary>
    let MovingPavement = _prefixId.prefix "MovingPavement"
    let MultiObjectiveNavigation = _prefixId.prefix "MultiObjectiveNavigation"
    /// <summary>
    ///   <para>rdfs:label : Navigation</para>
    ///   <para>rdfs:comment : The process or activity of accurately ascertaining one's position and planning and following a route (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Navigation">sbeo:Navigation</a>
    /// </summary>
    let Navigation = _prefixId.prefix "Navigation"
    /// <summary>
    ///   <para>rdfs:label : Navigational Point</para>
    ///   <para>rdfs:comment : It is a special type of point that connects more than two corridors or enforce change of direction to users or indicate the end of corridors.</para>
    ///   <a href="https://w3id.org/sbeo#NavigationalPoint">sbeo:NavigationalPoint</a>
    /// </summary>
    let NavigationalPoint = _prefixId.prefix "NavigationalPoint"
    /// <summary>
    ///   <para>rdfs:label : Navigational State</para>
    ///   <para>rdfs:comment : It models the user's navigational state while following the path.</para>
    ///   <a href="https://w3id.org/sbeo#NavigationalState">sbeo:NavigationalState</a>
    /// </summary>
    let NavigationalState = _prefixId.prefix "NavigationalState"
    let NoDeviate = _prefixId.prefix "NoDeviate"
    /// <summary>
    ///   <para>rdfs:label : Non-Motorised Wheelchair Person</para>
    ///   <para>rdfs:comment : A traditional wheelchair that is used by hands. It has significantly lower speed than motorised wheelchairs.</para>
    ///   <a href="https://w3id.org/sbeo#NonMotorisedWheelchairPerson">sbeo:NonMotorisedWheelchairPerson</a>
    /// </summary>
    let NonMotorisedWheelchairPerson = _prefixId.prefix "NonMotorisedWheelchairPerson"
    let OftenDeviate = _prefixId.prefix "OftenDeviate"
    /// <summary>
    ///   <para>rdfs:label : Open Area Entrance</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the entrance to an open area.</para>
    ///   <a href="https://w3id.org/sbeo#OpenAreaEntrance">sbeo:OpenAreaEntrance</a>
    /// </summary>
    let OpenAreaEntrance = _prefixId.prefix "OpenAreaEntrance"
    /// <summary>
    ///   <para>rdfs:label : Open Area Exit</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the exit from a specifc open space.</para>
    ///   <a href="https://w3id.org/sbeo#OpenAreaExit">sbeo:OpenAreaExit</a>
    /// </summary>
    let OpenAreaExit = _prefixId.prefix "OpenAreaExit"
    /// <summary>
    ///   <para>rdfs:label : Panic</para>
    ///   <para>rdfs:comment : A  sudden uncontrollable fear or anxiety among the occupants of the building that often causes wildly unthinking behaviour (Oxford Dictionary of English). In indoor environments, it may happens due to several reasons such as earthquake, fire or other sudden hazardous situations.</para>
    ///   <a href="https://w3id.org/sbeo#Panic">sbeo:Panic</a>
    /// </summary>
    let Panic = _prefixId.prefix "Panic"
    /// <summary>
    ///   <para>rdfs:label : Parameter</para>
    ///   <para>rdfs:comment : A numerical or other measurable factor forming one of a set that defines a system or sets the conditions of its operation.</para>
    ///   <a href="https://w3id.org/sbeo#Parameter">sbeo:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:label : Passage</para>
    ///   <para>rdfs:comment : Any spatial element that is part of a path and traversable by persons. In addition, it may be used as a logic representation of physical passages to represent an edge (or an arc) in a route graph.</para>
    ///   <a href="https://w3id.org/sbeo#Passage">sbeo:Passage</a>
    /// </summary>
    let Passage = _prefixId.prefix "Passage"
    /// <summary>
    ///   <para>rdfs:label : Passive Fire Protection</para>
    ///   <para>rdfs:comment : It is an integral component installed in the building while construction to resist the fire.</para>
    ///   <a href="https://w3id.org/sbeo#PassiveFireProtectionDevice">sbeo:PassiveFireProtectionDevice</a>
    /// </summary>
    let PassiveFireProtectionDevice = _prefixId.prefix "PassiveFireProtectionDevice"
    /// <summary>
    ///   <para>rdfs:label : Person Ability</para>
    ///   <para>rdfs:comment : A parameter to express the quality of an ability a specific person (or type of persons) own.</para>
    ///   <a href="https://w3id.org/sbeo#PersonAbility">sbeo:PersonAbility</a>
    /// </summary>
    let PersonAbility = _prefixId.prefix "PersonAbility"
    /// <summary>
    ///   <para>rdfs:label : Person Accessibility</para>
    ///   <para>rdfs:comment : A parameter to express the accessibility of any space for a specific person (or type of persons) in terms of some value.</para>
    ///   <a href="https://w3id.org/sbeo#PersonAccessibility">sbeo:PersonAccessibility</a>
    /// </summary>
    let PersonAccessibility = _prefixId.prefix "PersonAccessibility"
    /// <summary>
    ///   <para>rdfs:label : Physically Impaired Person</para>
    ///   <para>rdfs:comment : A physical impairment is a condition in which any part of person's body is either  damaged or is not working properly.</para>
    ///   <a href="https://w3id.org/sbeo#PhysicallyImpairedPerson">sbeo:PhysicallyImpairedPerson</a>
    /// </summary>
    let PhysicallyImpairedPerson = _prefixId.prefix "PhysicallyImpairedPerson"
    let PickingUpDependents = _prefixId.prefix "PickingUpDependents"
    /// <summary>
    ///   <para>rdfs:label : Point Of Interest</para>
    ///   <para>rdfs:comment : Any physical or virtual location or object, which may be of interest to a user and may serve as a navigation destination (e.g., room, water dispenser, waiting zone, assembly point, shop, seat, etc).</para>
    ///   <a href="https://w3id.org/sbeo#PointOfInterest">sbeo:PointOfInterest</a>
    /// </summary>
    let PointOfInterest = _prefixId.prefix "PointOfInterest"
    /// <summary>
    ///   <para>rdfs:label : Point Of Interest Segement</para>
    ///   <para>rdfs:comment : A traverasal part of a space that is connected to a specific Point of Interest.</para>
    ///   <a href="https://w3id.org/sbeo#PointOfInterestSegment">sbeo:PointOfInterestSegment</a>
    /// </summary>
    let PointOfInterestSegment = _prefixId.prefix "PointOfInterestSegment"
    /// <summary>
    ///   <para>rdfs:label : Profound Hearing Impaired Person</para>
    ///   <para>rdfs:comment : A person who cannot hear sounds softer than 90-120 dB. A person suffering from profound hearing loss, using a hearing aid is also ineffective most of the time.</para>
    ///   <a href="https://w3id.org/sbeo#ProfoundHearingImpairedPerson">sbeo:ProfoundHearingImpairedPerson</a>
    /// </summary>
    let ProfoundHearingImpairedPerson = _prefixId.prefix "ProfoundHearingImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Quality</para>
    ///   <para>rdfs:comment : A degree or grade of excellence or worth.</para>
    ///   <a href="https://w3id.org/sbeo#Quality">sbeo:Quality</a>
    /// </summary>
    let Quality = _prefixId.prefix "Quality"
    /// <summary>
    ///   <para>rdfs:label : Ramp</para>
    ///   <para>rdfs:comment : A sloping surface joining two different levels, as at the entrance or between floors of a building (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Ramp">sbeo:Ramp</a>
    /// </summary>
    let Ramp = _prefixId.prefix "Ramp"
    let RareDeviate = _prefixId.prefix "RareDeviate"
    /// <summary>
    ///   <para>rdfs:label : Road</para>
    ///   <para>rdfs:comment : A road is a way on land between two places that has been paved or otherwise improved to allow travel by foot or some form of conveyance, including a motor vehicle, cart, bicycle, or horse.</para>
    ///   <a href="https://w3id.org/sbeo#Road">sbeo:Road</a>
    /// </summary>
    let Road = _prefixId.prefix "Road"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>rdfs:comment : The function assumed or part played by a person or thing in a particular situation (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Role">sbeo:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Role In Context</para>
    ///   <para>rdfs:comment : A concept to express that an agent is playing a role in a given context.</para>
    ///   <a href="https://w3id.org/sbeo#RoleInContext">sbeo:RoleInContext</a>
    /// </summary>
    let RoleInContext = _prefixId.prefix "RoleInContext"
    let Rolling = _prefixId.prefix "Rolling"
    /// <summary>
    ///   <para>rdfs:label : Room Entrance</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the entrance to a room.</para>
    ///   <a href="https://w3id.org/sbeo#RoomEntrance">sbeo:RoomEntrance</a>
    /// </summary>
    let RoomEntrance = _prefixId.prefix "RoomEntrance"
    /// <summary>
    ///   <para>rdfs:label : Room Exit</para>
    ///   <para>rdfs:comment : A logical point that is used to represent the exit of a room.</para>
    ///   <a href="https://w3id.org/sbeo#RoomExit">sbeo:RoomExit</a>
    /// </summary>
    let RoomExit = _prefixId.prefix "RoomExit"
    /// <summary>
    ///   <para>rdfs:label : Room Segment</para>
    ///   <para>rdfs:comment : A traversable part in a room that is usually used to go the exit or the other part of the room.</para>
    ///   <a href="https://w3id.org/sbeo#RoomSegment">sbeo:RoomSegment</a>
    /// </summary>
    let RoomSegment = _prefixId.prefix "RoomSegment"
    /// <summary>
    ///   <para>rdfs:label : Route</para>
    ///   <para>rdfs:comment : A set of connected spaces represented by a starting and ending point, that ultimately leads to some specific position or place.</para>
    ///   <a href="https://w3id.org/sbeo#Route">sbeo:Route</a>
    /// </summary>
    let Route = _prefixId.prefix "Route"
    /// <summary>
    ///   <para>rdfs:label : Route Element</para>
    ///   <para>rdfs:comment : It represents the physical or conceptual elements of a navigation path.</para>
    ///   <a href="https://w3id.org/sbeo#RouteElement">sbeo:RouteElement</a>
    /// </summary>
    let RouteElement = _prefixId.prefix "RouteElement"
    /// <summary>
    ///   <para>rdfs:label : Route Point</para>
    ///   <para>rdfs:comment : Any spatial element that is part of a path and traversable by persons. In addition, it may be used as a logic representation of physical passages to represent a node (or a vertex) in a route graph.</para>
    ///   <a href="https://w3id.org/sbeo#RoutePoint">sbeo:RoutePoint</a>
    /// </summary>
    let RoutePoint = _prefixId.prefix "RoutePoint"
    let Running = _prefixId.prefix "Running"
    let Scooting = _prefixId.prefix "Scooting"
    /// <summary>
    ///   <para>rdfs:label : Seating Arrangement Route</para>
    ///   <para>rdfs:comment : A type of route in which the ending point represents the seat of one or more individuals such as in cinema, stadiums, auditoriums, etc.</para>
    ///   <a href="https://w3id.org/sbeo#SeatingArrangementRoute">sbeo:SeatingArrangementRoute</a>
    /// </summary>
    let SeatingArrangementRoute = _prefixId.prefix "SeatingArrangementRoute"
    /// <summary>
    ///   <para>rdfs:label : Sensor Event</para>
    ///   <para>rdfs:comment : This concept is used to express an event detected by any sensor.</para>
    ///   <a href="https://w3id.org/sbeo#SensorEvent">sbeo:SensorEvent</a>
    /// </summary>
    let SensorEvent = _prefixId.prefix "SensorEvent"
    /// <summary>
    ///   <para>rdfs:label : Sensor Ability</para>
    ///   <para>rdfs:comment : Sensory ability is referred to the brain's ability to receive, interpret, and effectively use the information provided by the senses in human beings such as touch, hear, smell, vision, etc.</para>
    ///   <a href="https://w3id.org/sbeo#SensoryAbility">sbeo:SensoryAbility</a>
    /// </summary>
    let SensoryAbility = _prefixId.prefix "SensoryAbility"
    /// <summary>
    ///   <para>rdfs:label : Sensory Impairmed Person</para>
    ///   <para>rdfs:comment : Sensory impairment is when one of the senses such as sight, hearing, smell, touch, taste and spatial awareness, is no longer normal.</para>
    ///   <a href="https://w3id.org/sbeo#SensoryImpairedPerson">sbeo:SensoryImpairedPerson</a>
    /// </summary>
    let SensoryImpairedPerson = _prefixId.prefix "SensoryImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Severe Hearing Impaired Person</para>
    ///   <para>rdfs:comment : A person who is unable to hear anything without wearing a hearing aid.</para>
    ///   <a href="https://w3id.org/sbeo#SevereHearingImpairedPerson">sbeo:SevereHearingImpairedPerson</a>
    /// </summary>
    let SevereHearingImpairedPerson = _prefixId.prefix "SevereHearingImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Severity</para>
    ///   <para>rdfs:comment : The quality of being hard to endure, uninviting or formidable.</para>
    ///   <a href="https://w3id.org/sbeo#Severity">sbeo:Severity</a>
    /// </summary>
    let Severity = _prefixId.prefix "Severity"
    /// <summary>
    ///   <para>rdfs:label : Shopping Mall Building</para>
    ///   <para>rdfs:comment : A set of one or more buildings forming a complex of shops representing merchandisers, with interconnecting walkways enabling visitors to easily walk from unit to unit, along with a parking area.</para>
    ///   <a href="https://w3id.org/sbeo#ShoppingMallBuilding">sbeo:ShoppingMallBuilding</a>
    /// </summary>
    let ShoppingMallBuilding = _prefixId.prefix "ShoppingMallBuilding"
    /// <summary>
    ///   <para>rdfs:label : Shopping Route</para>
    ///   <para>rdfs:comment : A type of route in which the specific points of interest are mentioned in the form of connected spaces, according to the preferences or interests of a one or more individuals.</para>
    ///   <a href="https://w3id.org/sbeo#ShoppingRoute">sbeo:ShoppingRoute</a>
    /// </summary>
    let ShoppingRoute = _prefixId.prefix "ShoppingRoute"
    let ShortestPath = _prefixId.prefix "ShortestPath"
    let SimplestPath = _prefixId.prefix "SimplestPath"
    /// <summary>
    ///   <para>rdfs:label : Smartphone</para>
    ///   <para>rdfs:comment : A mobile phone that is able to perform many of the functions of a computer, typically having a relatively large screen and an operating system capable of running general-purpose applications (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#SmartPhone">sbeo:SmartPhone</a>
    /// </summary>
    let SmartPhone = _prefixId.prefix "SmartPhone"
    /// <summary>
    ///   <para>rdfs:label : Social Unit</para>
    ///   <para>rdfs:comment : An individual, or a group or community, considered as a discrete constituent of a society or larger group (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#SocialUnit">sbeo:SocialUnit</a>
    /// </summary>
    let SocialUnit = _prefixId.prefix "SocialUnit"
    /// <summary>
    ///   <para>rdfs:label : Space</para>
    ///   <para>rdfs:comment : A physical, three dimensional, and one of the most important elements in the design of architecture that can further be divided to create more spaces from it.</para>
    ///   <a href="https://w3id.org/sbeo#Space">sbeo:Space</a>
    /// </summary>
    let Space = _prefixId.prefix "Space"
    /// <summary>
    ///   <para>rdfs:label : Space Saftey</para>
    ///   <para>rdfs:comment : A parameter to express the safety of any space for a specific person (or type of persons) in terms of some value.</para>
    ///   <a href="https://w3id.org/sbeo#SpaceSafety">sbeo:SpaceSafety</a>
    /// </summary>
    let SpaceSafety = _prefixId.prefix "SpaceSafety"
    /// <summary>
    ///   <para>rdfs:label : Spatial Ability</para>
    ///   <para>rdfs:comment : This ability expresses the capacity to understand, reason and remember the spatial relations among objects and spaces.</para>
    ///   <a href="https://w3id.org/sbeo#SpatialAbility">sbeo:SpatialAbility</a>
    /// </summary>
    let SpatialAbility = _prefixId.prefix "SpatialAbility"
    /// <summary>
    ///   <para>rdfs:label : Stadium Building</para>
    ///   <para>rdfs:comment : A building that has a large open area surrounded by many rows of seats, and  used for sports events, concerts, etc.</para>
    ///   <a href="https://w3id.org/sbeo#StadiumBuilding">sbeo:StadiumBuilding</a>
    /// </summary>
    let StadiumBuilding = _prefixId.prefix "StadiumBuilding"
    /// <summary>
    ///   <para>rdfs:label : Stampeding</para>
    ///   <para>rdfs:comment : A sudden and uncontrollable run by the group of people caused by panic.</para>
    ///   <a href="https://w3id.org/sbeo#Stampeding">sbeo:Stampeding</a>
    /// </summary>
    let Stampeding = _prefixId.prefix "Stampeding"
    let Standing = _prefixId.prefix "Standing"
    /// <summary>
    ///   <para>rdfs:label : Suite</para>
    ///   <para>rdfs:comment : A suite of rooms usually on one floor of an apartment house (Cambridge English Dictionary). This term is normally used in hotels, resorts, guesthouses, etc.</para>
    ///   <a href="https://w3id.org/sbeo#Suite">sbeo:Suite</a>
    /// </summary>
    let Suite = _prefixId.prefix "Suite"
    /// <summary>
    ///   <para>rdfs:label : Telephone</para>
    ///   <para>rdfs:comment : A device for transmitting voices over a distance using wire or radio, by converting acoustic vibrations to electrical signals (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Telephone">sbeo:Telephone</a>
    /// </summary>
    let Telephone = _prefixId.prefix "Telephone"
    /// <summary>
    ///   <para>rdfs:label : Terrorist Attack</para>
    ///   <para>rdfs:comment : A surprise event involving the deliberate use of violence against the occupants of the buildings.</para>
    ///   <a href="https://w3id.org/sbeo#TerroristAttack">sbeo:TerroristAttack</a>
    /// </summary>
    let TerroristAttack = _prefixId.prefix "TerroristAttack"
    /// <summary>
    ///   <para>rdfs:label : Textual Description</para>
    ///   <para>rdfs:comment : A type of description in which only text or writings are used to provide the information about any entity.</para>
    ///   <a href="https://w3id.org/sbeo#TextualDescription">sbeo:TextualDescription</a>
    /// </summary>
    let TextualDescription = _prefixId.prefix "TextualDescription"
    /// <summary>
    ///   <para>rdfs:label : Thoroughfare</para>
    ///   <para>rdfs:comment : A road or path forming a route between two places (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#Thoroughfare">sbeo:Thoroughfare</a>
    /// </summary>
    let Thoroughfare = _prefixId.prefix "Thoroughfare"
    let TooOftenDeviate = _prefixId.prefix "TooOftenDeviate"
    /// <summary>
    ///   <para>rdfs:label : Transition Point</para>
    ///   <para>rdfs:comment : A point at which person passes from one place to the next.</para>
    ///   <a href="https://w3id.org/sbeo#TransitionPoint">sbeo:TransitionPoint</a>
    /// </summary>
    let TransitionPoint = _prefixId.prefix "TransitionPoint"
    /// <summary>
    ///   <para>rdfs:label : Turn Point</para>
    ///   <para>rdfs:comment : A logic point that is used to enforce people to change their direction.</para>
    ///   <a href="https://w3id.org/sbeo#TurnPoint">sbeo:TurnPoint</a>
    /// </summary>
    let TurnPoint = _prefixId.prefix "TurnPoint"
    let UnAvailable = _prefixId.prefix "UnAvailable"
    /// <summary>
    ///   <para>rdfs:label : Vertical Moving Pavement</para>
    ///   <para>rdfs:comment : A slow-moving conveyor mechanism that transports people across an inclined plane over a short to medium distance.</para>
    ///   <a href="https://w3id.org/sbeo#VerticalMovingPavement">sbeo:VerticalMovingPavement</a>
    /// </summary>
    let VerticalMovingPavement = _prefixId.prefix "VerticalMovingPavement"
    /// <summary>
    ///   <para>rdfs:label : Vertical Passage</para>
    ///   <para>rdfs:comment : A type of passage that connects spatial elements located on different storey or floor.</para>
    ///   <a href="https://w3id.org/sbeo#VerticalPassage">sbeo:VerticalPassage</a>
    /// </summary>
    let VerticalPassage = _prefixId.prefix "VerticalPassage"
    /// <summary>
    ///   <para>rdfs:label : Visit</para>
    ///   <para>rdfs:comment : An activity that represents an act of going to see a person or place as a guest, tourist or a spectator. Normally, this type of activity is considered as a leasiure or recreational activity.</para>
    ///   <a href="https://w3id.org/sbeo#Visit">sbeo:Visit</a>
    /// </summary>
    let Visit = _prefixId.prefix "Visit"
    /// <summary>
    ///   <para>rdfs:label : Visit Route</para>
    ///   <para>rdfs:comment : A type of route created for visiting purposes within an indoor environment.</para>
    ///   <a href="https://w3id.org/sbeo#VisitRoute">sbeo:VisitRoute</a>
    /// </summary>
    let VisitRoute = _prefixId.prefix "VisitRoute"
    let Visiting = _prefixId.prefix "Visiting"
    /// <summary>
    ///   <para>rdfs:label : Visiting Group</para>
    ///   <para>rdfs:comment : A group of two or more people that has the same objective of visiting any space.</para>
    ///   <a href="https://w3id.org/sbeo#VisitingGroup">sbeo:VisitingGroup</a>
    /// </summary>
    let VisitingGroup = _prefixId.prefix "VisitingGroup"
    /// <summary>
    ///   <para>rdfs:label : Visually Impaired Person</para>
    ///   <para>rdfs:comment : It is a partial or total unability to see. It is also known as visual loss. Here, we considered a person having visual impairment who as severe low vision; 20/200 to 20/400 or higher.</para>
    ///   <a href="https://w3id.org/sbeo#VisuallyImpairedPerson">sbeo:VisuallyImpairedPerson</a>
    /// </summary>
    let VisuallyImpairedPerson = _prefixId.prefix "VisuallyImpairedPerson"
    /// <summary>
    ///   <para>rdfs:label : Waiting Zone</para>
    ///   <para>rdfs:comment : A space (normally with seating), where people can wait to do some specific activity. During emergency condtions, it is also used for several purposes, such as unification of people with their family members, acquaintances or emergency rescue teams, etc.</para>
    ///   <a href="https://w3id.org/sbeo#WaitingZone">sbeo:WaitingZone</a>
    /// </summary>
    let WaitingZone = _prefixId.prefix "WaitingZone"
    let Walking = _prefixId.prefix "Walking"
    /// <summary>
    ///   <para>rdfs:label : Accommodation Capacity</para>
    ///   <para>rdfs:comment : The accommodating capacity (in terms of persons) of a particular space.</para>
    ///   <a href="https://w3id.org/sbeo#accommodationCapacity">sbeo:accommodationCapacity</a>
    /// </summary>
    let accommodationCapacity = _prefixId.prefix "accommodationCapacity"
    /// <summary>
    ///   <para>rdfs:label : Accompanying</para>
    ///   <para>rdfs:comment : Be present or associated with a person.</para>
    ///   <a href="https://w3id.org/sbeo#accompanying">sbeo:accompanying</a>
    /// </summary>
    let accompanying = _prefixId.prefix "accompanying"
    /// <summary>
    ///   <para>rdfs:label : Acquaintance Of</para>
    ///   <para>rdfs:comment : Any friend or an acquaintance tie among occupants.</para>
    ///   <a href="https://w3id.org/sbeo#acquaintanceOf">sbeo:acquaintanceOf</a>
    /// </summary>
    let acquaintanceOf = _prefixId.prefix "acquaintanceOf"
    /// <summary>
    ///   <para>rdfs:label : Adjacent To</para>
    ///   <para>rdfs:comment : Nearest in space or position; immediately adjoining without intervening space or element; an exact neighbour.</para>
    ///   <a href="https://w3id.org/sbeo#adjacentTo">sbeo:adjacentTo</a>
    /// </summary>
    let adjacentTo = _prefixId.prefix "adjacentTo"
    /// <summary>
    ///   <para>rdfs:label : Assigned Route</para>
    ///   <para>rdfs:comment : A set of connected spaces(normally in the form of rdf:list) assigned to a social unit.</para>
    ///   <a href="https://w3id.org/sbeo#assignedRoute">sbeo:assignedRoute</a>
    /// </summary>
    let assignedRoute = _prefixId.prefix "assignedRoute"
    /// <summary>
    ///   <para>rdfs:label : At Time</para>
    ///   <para>rdfs:comment : The time at which an activity or event occurred.</para>
    ///   <a href="https://w3id.org/sbeo#atTime">sbeo:atTime</a>
    /// </summary>
    let atTime = _prefixId.prefix "atTime"
    /// <summary>
    ///   <para>rdfs:label : Connected To</para>
    ///   <para>rdfs:comment : Being joined by a common element; more specificially, a physical connection between two space elements.</para>
    ///   <a href="https://w3id.org/sbeo#connectedTo">sbeo:connectedTo</a>
    /// </summary>
    let connectedTo = _prefixId.prefix "connectedTo"
    /// <summary>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : The circumstances that form the setting for an event, statement, or idea, and in terms of which it can be fully understood and assessed (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#context">sbeo:context</a>
    /// </summary>
    let context = _prefixId.prefix "context"
    /// <summary>
    ///   <para>rdfs:label : Cost</para>
    ///   <para>rdfs:comment : A numeric value associated with an edge or a complete route(path). It is also reffered to as a weight.</para>
    ///   <a href="https://w3id.org/sbeo#cost">sbeo:cost</a>
    /// </summary>
    let cost = _prefixId.prefix "cost"
    /// <summary>
    ///   <para>rdfs:label : Current Occupancy</para>
    ///   <para>rdfs:comment : The current occupancy (in terms of persons) of a particular space.</para>
    ///   <a href="https://w3id.org/sbeo#currentOccupancy">sbeo:currentOccupancy</a>
    /// </summary>
    let currentOccupancy = _prefixId.prefix "currentOccupancy"
    /// <summary>
    ///   <para>rdfs:label : Dynamic Description</para>
    ///   <para>rdfs:comment : A dynamic or momentary information about a specific activity, event, social unit, or a space.</para>
    ///   <a href="https://w3id.org/sbeo#dynamicDescription">sbeo:dynamicDescription</a>
    /// </summary>
    let dynamicDescription = _prefixId.prefix "dynamicDescription"
    /// <summary>
    ///   <para>rdfs:label : Ended At Time</para>
    ///   <para>rdfs:comment : The time at which an activity ended.</para>
    ///   <a href="https://w3id.org/sbeo#endedAtTime">sbeo:endedAtTime</a>
    /// </summary>
    let endedAtTime = _prefixId.prefix "endedAtTime"
    /// <summary>
    ///   <para>rdfs:label : Excluded For</para>
    ///   <para>rdfs:comment : Expresses the removal of any physical space or point of interest for the consideration of any social unit.</para>
    ///   <a href="https://w3id.org/sbeo#excludedFor">sbeo:excludedFor</a>
    /// </summary>
    let excludedFor = _prefixId.prefix "excludedFor"
    /// <summary>
    ///   <para>rdfs:label : Familiar With</para>
    ///   <para>rdfs:comment : States the familiarity of any social unit with a physical space or point of interest.</para>
    ///   <a href="https://w3id.org/sbeo#familiarWith">sbeo:familiarWith</a>
    /// </summary>
    let familiarWith = _prefixId.prefix "familiarWith"
    /// <summary>
    ///   <para>rdfs:label : For Person</para>
    ///   <para>rdfs:comment : A property to express a foaf:Person in a n-ary relation for sbeo:Parameter.</para>
    ///   <a href="https://w3id.org/sbeo#forPerson">sbeo:forPerson</a>
    /// </summary>
    let forPerson = _prefixId.prefix "forPerson"
    /// <summary>
    ///   <para>rdfs:label : Has Ability</para>
    ///   <para>rdfs:comment : A property to express a sbeo:Ability in a n-ary relation for sbeo:PersonAbility.</para>
    ///   <a href="https://w3id.org/sbeo#hasAbility">sbeo:hasAbility</a>
    /// </summary>
    let hasAbility = _prefixId.prefix "hasAbility"
    /// <summary>
    ///   <para>rdfs:label : Has Activity Status</para>
    ///   <para>rdfs:comment : The status of an activity being performed by a social unit.</para>
    ///   <a href="https://w3id.org/sbeo#hasActivityStatus">sbeo:hasActivityStatus</a>
    /// </summary>
    let hasActivityStatus = _prefixId.prefix "hasActivityStatus"
    /// <summary>
    ///   <para>rdfs:label : Has Availability Status</para>
    ///   <para>rdfs:comment : The status of something in terms of availability. For example, available or unavailable.</para>
    ///   <a href="https://w3id.org/sbeo#hasAvailabilityStatus">sbeo:hasAvailabilityStatus</a>
    /// </summary>
    let hasAvailabilityStatus = _prefixId.prefix "hasAvailabilityStatus"
    /// <summary>
    ///   <para>rdfs:label : Has Description</para>
    ///   <para>rdfs:comment : Expresses a descriptive information about any specific space, point, activiy, event or device.</para>
    ///   <a href="https://w3id.org/sbeo#hasDescription">sbeo:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : Has Deviation State</para>
    ///   <para>rdfs:comment : A deviation status of a person depending on how ofthen one deviates from the proposed route.</para>
    ///   <a href="https://w3id.org/sbeo#hasDeviationState">sbeo:hasDeviationState</a>
    /// </summary>
    let hasDeviationState = _prefixId.prefix "hasDeviationState"
    /// <summary>
    ///   <para>rdfs:label : Has Fitness Status</para>
    ///   <para>rdfs:comment : A fitness status is associated with a person that represent the quality of being suitable for a specific activity. There are three different levels of fitness levels are introduced that can be extended according to the needs of the application. These are 'Fit', 'Exhausted' and 'Injured'.</para>
    ///   <a href="https://w3id.org/sbeo#hasFitnessStatus">sbeo:hasFitnessStatus</a>
    /// </summary>
    let hasFitnessStatus = _prefixId.prefix "hasFitnessStatus"
    /// <summary>
    ///   <para>rdfs:label : Has Impact</para>
    ///   <para>rdfs:comment : A property to express the impact of a particular sbeo:Activity or sbeo:Event.</para>
    ///   <a href="https://w3id.org/sbeo#hasImpact">sbeo:hasImpact</a>
    /// </summary>
    let hasImpact = _prefixId.prefix "hasImpact"
    /// <summary>
    ///   <para>rdfs:label : Has Intensity</para>
    ///   <para>rdfs:comment : A property to express the intensity of a particular sbeo:Activity or sbeo:Event.</para>
    ///   <a href="https://w3id.org/sbeo#hasIntensity">sbeo:hasIntensity</a>
    /// </summary>
    let hasIntensity = _prefixId.prefix "hasIntensity"
    /// <summary>
    ///   <para>rdfs:label : Has Member</para>
    ///   <para>rdfs:comment : Expresses one of the persons who compose a social group.</para>
    ///   <a href="https://w3id.org/sbeo#hasMember">sbeo:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : Has Motion State</para>
    ///   <para>rdfs:comment : The motion state of a person.</para>
    ///   <a href="https://w3id.org/sbeo#hasMotionState">sbeo:hasMotionState</a>
    /// </summary>
    let hasMotionState = _prefixId.prefix "hasMotionState"
    /// <summary>
    ///   <para>rdfs:label : Has Navigational State</para>
    ///   <para>rdfs:comment : A navigational state of a social unit while following any path.</para>
    ///   <a href="https://w3id.org/sbeo#hasNavigationalState">sbeo:hasNavigationalState</a>
    /// </summary>
    let hasNavigationalState = _prefixId.prefix "hasNavigationalState"
    /// <summary>
    ///   <para>rdfs:label : Has Navigation Type</para>
    ///   <para>rdfs:comment : A type of navigation provided to a person to perform a specific activity.</para>
    ///   <a href="https://w3id.org/sbeo#hasNavigationalType">sbeo:hasNavigationalType</a>
    /// </summary>
    let hasNavigationalType = _prefixId.prefix "hasNavigationalType"
    /// <summary>
    ///   <para>rdfs:label : Has Quality</para>
    ///   <para>rdfs:comment : A property to express a quality of something in terms of different levels. For example, good, bad, medium, perfect, mild, and so forth.</para>
    ///   <a href="https://w3id.org/sbeo#hasQuality">sbeo:hasQuality</a>
    /// </summary>
    let hasQuality = _prefixId.prefix "hasQuality"
    /// <summary>
    ///   <para>rdfs:label : Has Severity</para>
    ///   <para>rdfs:comment : A property to express a sbeo:Severity in a n-ary relation for sbeo:ActivitySeverity or  sbeo:EventSeverity.</para>
    ///   <a href="https://w3id.org/sbeo#hasSeverity">sbeo:hasSeverity</a>
    /// </summary>
    let hasSeverity = _prefixId.prefix "hasSeverity"
    /// <summary>
    ///   <para>rdfs:label : Value</para>
    ///   <para>rdfs:comment : Provides a value that is a direct representation of an entity.</para>
    ///   <a href="https://w3id.org/sbeo#hasValue">sbeo:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : Has X Time Deviated</para>
    ///   <para>rdfs:comment : Number of times a social unit is deviated while following the provided path.</para>
    ///   <a href="https://w3id.org/sbeo#hasXTimesDeviated">sbeo:hasXTimesDeviated</a>
    /// </summary>
    let hasXTimesDeviated = _prefixId.prefix "hasXTimesDeviated"
    /// <summary>
    ///   <para>rdfs:label : Identification Number</para>
    ///   <para>rdfs:comment : An unique identification number of something such as, social unit, device, etc.</para>
    ///   <a href="https://w3id.org/sbeo#id">sbeo:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:label : Installed In</para>
    ///   <para>rdfs:comment : Place or fix (equipment or machinery) in position ready for use (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#installedIn">sbeo:installedIn</a>
    /// </summary>
    let installedIn = _prefixId.prefix "installedIn"
    /// <summary>
    ///   <para>rdfs:label : Lead To</para>
    ///   <para>rdfs:comment : Be a means of access to a particular space or point.</para>
    ///   <a href="https://w3id.org/sbeo#leadsTo">sbeo:leadsTo</a>
    /// </summary>
    let leadsTo = _prefixId.prefix "leadsTo"
    /// <summary>
    ///   <para>rdfs:label : Length</para>
    ///   <para>rdfs:comment : The measurement or extent of something from end to end (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#length">sbeo:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:label : Located In</para>
    ///   <para>rdfs:comment : States the location of any social unit, activity, event, physical space, or a point of interest at any other physical space.</para>
    ///   <a href="https://w3id.org/sbeo#locatedIn">sbeo:locatedIn</a>
    /// </summary>
    let locatedIn = _prefixId.prefix "locatedIn"
    /// <summary>
    ///   <para>rdfs:label : Lower</para>
    ///   <para>rdfs:comment : Associates the lower storey in a building.</para>
    ///   <a href="https://w3id.org/sbeo#lower">sbeo:lower</a>
    /// </summary>
    let lower = _prefixId.prefix "lower"
    /// <summary>
    ///   <para>rdfs:label : Means of Notification</para>
    ///   <para>rdfs:comment : A method of notifying a social unit.</para>
    ///   <a href="https://w3id.org/sbeo#meansOfNotification">sbeo:meansOfNotification</a>
    /// </summary>
    let meansOfNotification = _prefixId.prefix "meansOfNotification"
    /// <summary>
    ///   <para>rdfs:label : Notification Preference</para>
    ///   <para>rdfs:comment : A notification preference for any kind of social unit.</para>
    ///   <a href="https://w3id.org/sbeo#notificationPreference">sbeo:notificationPreference</a>
    /// </summary>
    let notificationPreference = _prefixId.prefix "notificationPreference"
    /// <summary>
    ///   <para>rdfs:label : Has Number</para>
    ///   <para>rdfs:comment : A number assigned to anything.</para>
    ///   <a href="https://w3id.org/sbeo#number">sbeo:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    /// <summary>
    ///   <para>rdfs:label : Of Activity</para>
    ///   <para>rdfs:comment : A property to express a sbeo:Activity in a n-ary relation for sbeo:ActivitySeverity.</para>
    ///   <a href="https://w3id.org/sbeo#ofActivity">sbeo:ofActivity</a>
    /// </summary>
    let ofActivity = _prefixId.prefix "ofActivity"
    /// <summary>
    ///   <para>rdfs:label : Of Event</para>
    ///   <para>rdfs:comment : A property to express a sbeo:Event in a n-ary relation for sbeo:EventSeverity.</para>
    ///   <a href="https://w3id.org/sbeo#ofEvent">sbeo:ofEvent</a>
    /// </summary>
    let ofEvent = _prefixId.prefix "ofEvent"
    /// <summary>
    ///   <para>rdfs:label : Of Space</para>
    ///   <para>rdfs:comment : A property to express a sbeo:Space in a n-ary relation for sbeo:Parameter.</para>
    ///   <a href="https://w3id.org/sbeo#ofSpace">sbeo:ofSpace</a>
    /// </summary>
    let ofSpace = _prefixId.prefix "ofSpace"
    /// <summary>
    ///   <para>rdfs:label : Part Of</para>
    ///   <para>rdfs:comment : Expresses a physical space as a part or a fragment of another physical space. For example, a block of apartments can be a part of apartment building, etc.</para>
    ///   <a href="https://w3id.org/sbeo#partOf">sbeo:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>rdfs:label : Performed by</para>
    ///   <para>rdfs:comment : Expresses an activity carried out by a social unit.</para>
    ///   <a href="https://w3id.org/sbeo#performedBy">sbeo:performedBy</a>
    /// </summary>
    let performedBy = _prefixId.prefix "performedBy"
    /// <summary>
    ///   <para>rdfs:label : Player</para>
    ///   <para>rdfs:comment : It express an agent that plays a role in a specific context.</para>
    ///   <a href="https://w3id.org/sbeo#player">sbeo:player</a>
    /// </summary>
    let player = _prefixId.prefix "player"
    /// <summary>
    ///   <para>rdfs:label : Responsible To</para>
    ///   <para>rdfs:comment : Having an obligation to do something, or having control over or care for someone, as part of one's role (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#responsibleTo">sbeo:responsibleTo</a>
    /// </summary>
    let responsibleTo = _prefixId.prefix "responsibleTo"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>rdfs:comment : Expresses a role of an agent.</para>
    ///   <a href="https://w3id.org/sbeo#role">sbeo:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>rdfs:label : Route Preference</para>
    ///   <para>rdfs:comment : Route preference of a social unit to perform an activity.</para>
    ///   <a href="https://w3id.org/sbeo#routePreference">sbeo:routePreference</a>
    /// </summary>
    let routePreference = _prefixId.prefix "routePreference"
    /// <summary>
    ///   <para>rdfs:label : Route Type</para>
    ///   <para>rdfs:comment : This property is used to express the type of a route in terms of graph-based routes, such as Shortest Path, Simplest Path etc.</para>
    ///   <a href="https://w3id.org/sbeo#routeType">sbeo:routeType</a>
    /// </summary>
    let routeType = _prefixId.prefix "routeType"
    /// <summary>
    ///   <para>rdfs:label : Speed</para>
    ///   <para>rdfs:comment : The average speed of a person.</para>
    ///   <a href="https://w3id.org/sbeo#speed">sbeo:speed</a>
    /// </summary>
    let speed = _prefixId.prefix "speed"
    /// <summary>
    ///   <para>rdfs:label : Speed Factor</para>
    ///   <para>rdfs:comment : A multiplying factor that may affect the speed of person while passing through a specific space.</para>
    ///   <a href="https://w3id.org/sbeo#speedFactor">sbeo:speedFactor</a>
    /// </summary>
    let speedFactor = _prefixId.prefix "speedFactor"
    /// <summary>
    ///   <para>rdfs:label : Started At Time</para>
    ///   <para>rdfs:comment : Start is when an activity is deemed to have been started by an entity, known as trigger.</para>
    ///   <a href="https://w3id.org/sbeo#startedAtTime">sbeo:startedAtTime</a>
    /// </summary>
    let startedAtTime = _prefixId.prefix "startedAtTime"
    /// <summary>
    ///   <para>rdfs:label : Static Description</para>
    ///   <para>rdfs:comment : A static or a fix information about any activity, event, space, social unit, or point of interest.^^xsd:string</para>
    ///   <a href="https://w3id.org/sbeo#staticDescription">sbeo:staticDescription</a>
    /// </summary>
    let staticDescription = _prefixId.prefix "staticDescription"
    /// <summary>
    ///   <para>rdfs:label : Time Duration</para>
    ///   <para>rdfs:comment : The length of time during which any activity or event lasts.</para>
    ///   <a href="https://w3id.org/sbeo#timeDuration">sbeo:timeDuration</a>
    /// </summary>
    let timeDuration = _prefixId.prefix "timeDuration"
    /// <summary>
    ///   <para>rdfs:label : Travel Time</para>
    ///   <para>rdfs:comment : A specific period of time required to move from one place to another.</para>
    ///   <a href="https://w3id.org/sbeo#travelTime">sbeo:travelTime</a>
    /// </summary>
    let travelTime = _prefixId.prefix "travelTime"
    /// <summary>
    ///   <para>rdfs:label : Upper</para>
    ///   <para>rdfs:comment : Associates the upper storey in a building.</para>
    ///   <a href="https://w3id.org/sbeo#upper">sbeo:upper</a>
    /// </summary>
    let upper = _prefixId.prefix "upper"
    /// <summary>
    ///   <para>rdfs:label : Uses</para>
    ///   <para>rdfs:comment : Expresses a momentary information about a physical space or a point being used by a social unit.</para>
    ///   <a href="https://w3id.org/sbeo#uses">sbeo:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
    /// <summary>
    ///   <para>rdfs:label : Width</para>
    ///   <para>rdfs:comment : The measurement or extent of something from side to side (Oxford Dictionary of English).</para>
    ///   <a href="https://w3id.org/sbeo#width">sbeo:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
