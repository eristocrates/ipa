namespace https.w3id.org.sbeo.hash

open DoxAletheia

module sbeo =
    let _namespace_name = "https://w3id.org/sbeo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The measurement or extent of something from end to end (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// An individual, or a group or community, considered as a discrete constituent of a society or larger group (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#SocialUnit"></see></summary>
    let SocialUnit = _prefix "SocialUnit"
    /// <summary>
    /// Possession of the means or skill to do something (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Ability"></see></summary>
    let Ability = _prefix "Ability"
    /// <summary>
    /// An ability to hear.
    /// <see href="https://w3id.org/sbeo#AbilityToHear"></see></summary>
    let AbilityToHear = _prefix "AbilityToHear"
    /// <summary>
    /// Sensory ability is referred to the brain's ability to receive, interpret, and effectively use the information provided by the senses in human beings such as touch, hear, smell, vision, etc.
    /// <see href="https://w3id.org/sbeo#SensoryAbility"></see></summary>
    let SensoryAbility = _prefix "SensoryAbility"
    /// <summary>
    /// An ability to run.
    /// <see href="https://w3id.org/sbeo#AbilityToRun"></see></summary>
    let AbilityToRun = _prefix "AbilityToRun"
    /// <summary>
    /// This ability is used to represent all kinetic abilities a person may have.
    /// <see href="https://w3id.org/sbeo#MobilityAbility"></see></summary>
    let MobilityAbility = _prefix "MobilityAbility"
    /// <summary>
    /// An ability to hear.
    /// <see href="https://w3id.org/sbeo#AbilityToSee"></see></summary>
    let AbilityToSee = _prefix "AbilityToSee"
    /// <summary>
    /// An ability to talk.
    /// <see href="https://w3id.org/sbeo#AbilityToTalk"></see></summary>
    let AbilityToTalk = _prefix "AbilityToTalk"
    /// <summary>
    /// An ability to touch.
    /// <see href="https://w3id.org/sbeo#AbilityToTouch"></see></summary>
    let AbilityToTouch = _prefix "AbilityToTouch"
    /// <summary>
    /// An ability to use the stairs. Note that the people on the wheelchair are not considered to have this ability no matter the stairs have a stairlift and a ramp.
    /// <see href="https://w3id.org/sbeo#AbilityToUseStairs"></see></summary>
    let AbilityToUseStairs = _prefix "AbilityToUseStairs"
    /// <summary>
    /// An ability of a person to walk. A person who is using crutches is also considered to have this ability.
    /// <see href="https://w3id.org/sbeo#AbilityToWalk"></see></summary>
    let AbilityToWalk = _prefix "AbilityToWalk"
    /// <summary>
    /// It is an integral part of the fire protection used as a first response to minimize the spread of fire and related effects.
    /// <see href="https://w3id.org/sbeo#ActiveFireProtectionDevice"></see></summary>
    let ActiveFireProtectionDevice = _prefix "ActiveFireProtectionDevice"
    /// <summary>
    /// Device that is used to minimize the effects of potentially danger fires.
    /// <see href="https://w3id.org/sbeo#FireProtectionDevice"></see></summary>
    let FireProtectionDevice = _prefix "FireProtectionDevice"
    /// <summary>
    /// A process that a person, group of persons, or machine does during a specific amount of time, such as visiting, shopping, etc.
    /// <see href="https://w3id.org/sbeo#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// The measurable amount of a property, such as force, brightness, or a magnetic field (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Intensity"></see></summary>
    let Intensity = _prefix "Intensity"
    /// <summary>
    /// A property to express the intensity of a particular sbeo:Activity or sbeo:Event.
    /// <see href="https://w3id.org/sbeo#hasIntensity"></see></summary>
    let hasIntensity = _prefix "hasIntensity"
    /// <summary>
    /// A parameter to express the impact of an activity on a specific person (or type of persons) in terms of any specific value or a type.
    /// <see href="https://w3id.org/sbeo#ActivityImpact"></see></summary>
    let ActivityImpact = _prefix "ActivityImpact"
    /// <summary>
    /// A property to express a foaf:Person in a n-ary relation for sbeo:Parameter.
    /// <see href="https://w3id.org/sbeo#forPerson"></see></summary>
    let forPerson = _prefix "forPerson"
    /// <summary>
    /// A property to express the impact of a particular sbeo:Activity or sbeo:Event.
    /// <see href="https://w3id.org/sbeo#hasImpact"></see></summary>
    let hasImpact = _prefix "hasImpact"
    /// <summary>
    /// An impact is a long-lasting effect of an event (or activity), that continues to exist after the event (or activity) has taken place.
    /// <see href="https://w3id.org/sbeo#Impact"></see></summary>
    let Impact = _prefix "Impact"
    /// <summary>
    /// A property to express a sbeo:Activity in a n-ary relation for sbeo:ActivitySeverity.
    /// <see href="https://w3id.org/sbeo#ofActivity"></see></summary>
    let ofActivity = _prefix "ofActivity"
    /// <summary>
    /// A numerical or other measurable factor forming one of a set that defines a system or sets the conditions of its operation.
    /// <see href="https://w3id.org/sbeo#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// A parameter to express the severity of an activity for a specific person (or type of persons) in terms of  potential severity levels.
    /// <see href="https://w3id.org/sbeo#ActivitySeverity"></see></summary>
    let ActivitySeverity = _prefix "ActivitySeverity"
    /// <summary>
    /// A property to express a sbeo:Severity in a n-ary relation for sbeo:ActivitySeverity or  sbeo:EventSeverity.
    /// <see href="https://w3id.org/sbeo#hasSeverity"></see></summary>
    let hasSeverity = _prefix "hasSeverity"
    /// <summary>
    /// The quality of being hard to endure, uninviting or formidable.
    /// <see href="https://w3id.org/sbeo#Severity"></see></summary>
    let Severity = _prefix "Severity"
    /// <summary>
    /// It expresses the status of a specific activity being performed by a person.
    /// <see href="https://w3id.org/sbeo#ActivityStatus"></see></summary>
    let ActivityStatus = _prefix "ActivityStatus"
    /// <summary>
    ///   <see href="https://w3id.org/sbeo#Evacuated"></see>
    /// </summary>
    let Evacuated = _prefix "Evacuated"
    /// <summary>
    ///   <see href="https://w3id.org/sbeo#Evacuating"></see>
    /// </summary>
    let Evacuating = _prefix "Evacuating"
    /// <summary>
    /// This instance is used to express when someone is picking up the dependent member of one's group.
    /// <see href="https://w3id.org/sbeo#PickingUpDependents"></see></summary>
    let PickingUpDependents = _prefix "PickingUpDependents"
    /// <summary>
    /// The activity of making visits.
    /// <see href="https://w3id.org/sbeo#Visiting"></see></summary>
    let Visiting = _prefix "Visiting"
    /// <summary>
    /// Alerting devices are those devices that are used to react to normal as well as alarming situations to let people know that some specific condition is occuring.
    /// <see href="https://w3id.org/sbeo#AlertingDevice"></see></summary>
    let AlertingDevice = _prefix "AlertingDevice"
    /// <summary>
    /// A thing made or adapted for a particular purpose, especially a piece of mechanical or electronic equipment (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// An alerting device that is used to assist or notify people with impairments during a specific circumstance.
    /// <see href="https://w3id.org/sbeo#AlertingDeviceForImpairedPerson"></see></summary>
    let AlertingDeviceForImpairedPerson = _prefix "AlertingDeviceForImpairedPerson"
    /// <summary>
    /// A person having an Alzheimer's disease.
    /// <see href="https://w3id.org/sbeo#AlzheimersDiseasedPerson"></see></summary>
    let AlzheimersDiseasedPerson = _prefix "AlzheimersDiseasedPerson"
    /// <summary>
    /// A person having mental impairment in which one's mind is damaged or is not working properly and one have issues such as consciousness, orientation, concentration.
    /// <see href="https://w3id.org/sbeo#MentalImpairedPerson"></see></summary>
    let MentalImpairedPerson = _prefix "MentalImpairedPerson"
    /// <summary>
    /// A suite of rooms usually on one floor of an apartment house (Cambridge English Dictionary).
    /// <see href="https://w3id.org/sbeo#Apartment"></see></summary>
    let Apartment = _prefix "Apartment"
    /// <summary>
    /// A set of one or more buildings that contain apartments in it.
    /// <see href="https://w3id.org/sbeo#AppartmentBuilding"></see></summary>
    let AppartmentBuilding = _prefix "AppartmentBuilding"
    /// <summary>
    /// A place where people in an office, etc. should go if there is an emergency, for example, a fire (Cambridge English Dictionary) .
    /// <see href="https://w3id.org/sbeo#AssemblyPoint"></see></summary>
    let AssemblyPoint = _prefix "AssemblyPoint"
    /// <summary>
    /// Any spatial element that is part of a path and traversable by persons. In addition, it may be used as a logic representation of physical passages to represent a node (or a vertex) in a route graph.
    /// <see href="https://w3id.org/sbeo#RoutePoint"></see></summary>
    let RoutePoint = _prefix "RoutePoint"
    /// <summary>
    /// A type of navigation in which a person is assisted by a person or a machine to perform a specific activity.
    /// <see href="https://w3id.org/sbeo#AssistedNavigation"></see></summary>
    let AssistedNavigation = _prefix "AssistedNavigation"
    /// <summary>
    /// A type of description in which sounds such as voices, are used to provide the information about any entity.
    /// <see href="https://w3id.org/sbeo#AudioDescription"></see></summary>
    let AudioDescription = _prefix "AudioDescription"
    /// <summary>
    /// A representation and detail of a person, object, or event. It is used to describe the details of anything.
    /// <see href="https://w3id.org/sbeo#Description"></see></summary>
    let Description = _prefix "Description"
    /// <summary>
    /// A person who can walk on his/her with a help of a non-motorised device, e.g. crutches.
    /// <see href="https://w3id.org/sbeo#AutonomousMobilityPerson"></see></summary>
    let AutonomousMobilityPerson = _prefix "AutonomousMobilityPerson"
    /// <summary>
    /// A person who has either partial or total loss of function of a body part, usually a limb or limbs.
    /// <see href="https://w3id.org/sbeo#MotorImpairedPerson"></see></summary>
    let MotorImpairedPerson = _prefix "MotorImpairedPerson"
    /// <summary>
    /// A type of navigation in which a person plans and executes his or her path without any human or machine intervention.
    /// <see href="https://w3id.org/sbeo#AutonomousNavigation"></see></summary>
    let AutonomousNavigation = _prefix "AutonomousNavigation"
    /// <summary>
    /// It expresses the status of something that is either available or not.
    /// <see href="https://w3id.org/sbeo#AvailabilityStatus"></see></summary>
    let AvailabilityStatus = _prefix "AvailabilityStatus"
    /// <summary>
    /// Obtainable or accessible and ready for use or service.
    /// <see href="https://w3id.org/sbeo#Available"></see></summary>
    let Available = _prefix "Available"
    /// <summary>
    /// Not available or accessible.
    /// <see href="https://w3id.org/sbeo#UnAvailable"></see></summary>
    let UnAvailable = _prefix "UnAvailable"
    /// <summary>
    /// A person who has lost the vision completly and can neither see naturally nor with the help of any device.
    /// <see href="https://w3id.org/sbeo#BlindPerson"></see></summary>
    let BlindPerson = _prefix "BlindPerson"
    /// <summary>
    /// It is a partial or total unability to see. It is also known as visual loss. Here, we considered a person having visual impairment who as severe low vision; 20/200 to 20/400 or higher.
    /// <see href="https://w3id.org/sbeo#VisuallyImpairedPerson"></see></summary>
    let VisuallyImpairedPerson = _prefix "VisuallyImpairedPerson"
    /// <summary>
    /// A logical point that is used to represent the entrance to a building.
    /// <see href="https://w3id.org/sbeo#BuildingEntrance"></see></summary>
    let BuildingEntrance = _prefix "BuildingEntrance"
    /// <summary>
    /// Entrance represents a space or a door that is used to enter into a building. Normally, it is also used as an exit.
    /// <see href="https://w3id.org/sbeo#Entrance"></see></summary>
    let Entrance = _prefix "Entrance"
    /// <summary>
    /// A logical point that is used to represent the exit of a building.
    /// <see href="https://w3id.org/sbeo#BuildingExit"></see></summary>
    let BuildingExit = _prefix "BuildingExit"
    /// <summary>
    /// Exit represents a logical representation for escaping or releasing from a specific phsyical space. Generally, an exit is as same as an entrance.
    /// <see href="https://w3id.org/sbeo#Exit"></see></summary>
    let Exit = _prefix "Exit"
    /// <summary>
    /// A hazardous event that happens due to the spillage or leakge of any toxic chemical in the building.
    /// <see href="https://w3id.org/sbeo#ChemicalSpill"></see></summary>
    let ChemicalSpill = _prefix "ChemicalSpill"
    /// <summary>
    /// An event or occurance that can be dangerous for the occupants of the building.
    /// <see href="https://w3id.org/sbeo#Incident"></see></summary>
    let Incident = _prefix "Incident"
    /// <summary>
    /// A building in which movies are shown.
    /// <see href="https://w3id.org/sbeo#CinemaBuilding"></see></summary>
    let CinemaBuilding = _prefix "CinemaBuilding"
    /// <summary>
    /// A room, typically in a school, in which a class of students is taught (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Classroom"></see></summary>
    let Classroom = _prefix "Classroom"
    /// <summary>
    /// A type of navigation in which two or more persons are involved that may or may not have same objectives.
    /// <see href="https://w3id.org/sbeo#CollaborativeNavigation"></see></summary>
    let CollaborativeNavigation = _prefix "CollaborativeNavigation"
    /// <summary>
    /// A person having the decreased ability to see color or differences in color.
    /// <see href="https://w3id.org/sbeo#ColourBlindPerson"></see></summary>
    let ColourBlindPerson = _prefix "ColourBlindPerson"
    /// <summary>
    /// An event that happens at bottlenecks when the flow of people increases than a provided limit due to herding (and similar phenomena of human behaviour), especially during an emergency evacuation process.
    /// <see href="https://w3id.org/sbeo#Congestion"></see></summary>
    let Congestion = _prefix "Congestion"
    /// <summary>
    /// A logical point that is used to represent the entrance to a corridor.
    /// <see href="https://w3id.org/sbeo#CorridorEntrance"></see></summary>
    let CorridorEntrance = _prefix "CorridorEntrance"
    /// <summary>
    /// A logical point that is used to represent the exit of a corridor.
    /// <see href="https://w3id.org/sbeo#CorridorExit"></see></summary>
    let CorridorExit = _prefix "CorridorExit"
    /// <summary>
    /// A fragment or an atomic element of a corridor.
    /// <see href="https://w3id.org/sbeo#CorridorSegment"></see></summary>
    let CorridorSegment = _prefix "CorridorSegment"
    /// <summary>
    /// A place where infants and young children are provided a supervision and care of during the daytime, particularly so that their parents can hold jobs.
    /// <see href="https://w3id.org/sbeo#DayCare"></see></summary>
    let DayCare = _prefix "DayCare"
    /// <summary>
    ///   <see href="https://w3id.org/sbeo#DeviatingFromPath"></see>
    /// </summary>
    let DeviatingFromPath = _prefix "DeviatingFromPath"
    /// <summary>
    /// It models the user's deviation state from one's proposed route. For example, NoDeviate, RareDeviate, OftenDeviate, and TooOftenDeviate.
    /// <see href="https://w3id.org/sbeo#DeviationState"></see></summary>
    let DeviationState = _prefix "DeviationState"
    /// <summary>
    /// This instance is used to express when someone is not deviating at all while following one's provided path.
    /// <see href="https://w3id.org/sbeo#NoDeviate"></see></summary>
    let NoDeviate = _prefix "NoDeviate"
    /// <summary>
    /// This instance is used to express when someone is deviating frequently while following the provided path.
    /// <see href="https://w3id.org/sbeo#OftenDeviate"></see></summary>
    let OftenDeviate = _prefix "OftenDeviate"
    /// <summary>
    /// This instance is used to express when someone rarely deviates while following the provided path.
    /// <see href="https://w3id.org/sbeo#RareDeviate"></see></summary>
    let RareDeviate = _prefix "RareDeviate"
    /// <summary>
    /// This instance is used to express when someone is deviating frequently while following the provided path.
    /// <see href="https://w3id.org/sbeo#TooOftenDeviate"></see></summary>
    let TooOftenDeviate = _prefix "TooOftenDeviate"
    /// <summary>
    /// The status of something in terms of availability. For example, available or unavailable.
    /// <see href="https://w3id.org/sbeo#hasAvailabilityStatus"></see></summary>
    let hasAvailabilityStatus = _prefix "hasAvailabilityStatus"
    /// <summary>
    /// A display screen is an output device to represent the information in visual or tactile form.
    /// <see href="https://w3id.org/sbeo#DisplayScreen"></see></summary>
    let DisplayScreen = _prefix "DisplayScreen"
    /// <summary>
    /// A person with Down's syndrome.
    /// <see href="https://w3id.org/sbeo#DownSyndromePerson"></see></summary>
    let DownSyndromePerson = _prefix "DownSyndromePerson"
    /// <summary>
    /// A sudden violent shaking of the ground, typically causing great destruction, as a result of movements within the earth's crust or volcanic action (Oxford Dictionary of English). It may cause a sudden panic among the occupants of the building.
    /// <see href="https://w3id.org/sbeo#Earthquake"></see></summary>
    let Earthquake = _prefix "Earthquake"
    /// <summary>
    /// An activity that is done with an urgency and highest priority.
    /// <see href="https://w3id.org/sbeo#EmergencyActivity"></see></summary>
    let EmergencyActivity = _prefix "EmergencyActivity"
    /// <summary>
    /// It represents an immediate escape of people away from a particular area that has ongoing or imminent hazard to their lives or property.
    /// <see href="https://w3id.org/sbeo#EmergencyEvacuation"></see></summary>
    let EmergencyEvacuation = _prefix "EmergencyEvacuation"
    /// <summary>
    /// A group of two or more persons who are supposed to evacuate the building together.
    /// <see href="https://w3id.org/sbeo#EmergencyEvacuationGroup"></see></summary>
    let EmergencyEvacuationGroup = _prefix "EmergencyEvacuationGroup"
    /// <summary>
    /// It represents a collection of two or more people who interact with each other and may have the similar characteristics or objectives.
    /// <see href="https://w3id.org/sbeo#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// A type of route in which only those spaces are mentioned that are potentially safe for its users as well as the ending point of it must be an exit from a particular space.
    /// <see href="https://w3id.org/sbeo#EmergencyEvacuationRoute"></see></summary>
    let EmergencyEvacuationRoute = _prefix "EmergencyEvacuationRoute"
    /// <summary>
    /// A type of route in which the ending point represents the exit of a specific space.
    /// <see href="https://w3id.org/sbeo#ExitRoute"></see></summary>
    let ExitRoute = _prefix "ExitRoute"
    /// <summary>
    /// Emergency exit is logical point that is only used in case of any emergency conditions such as fire, etc.
    /// <see href="https://w3id.org/sbeo#EmergencyExit"></see></summary>
    let EmergencyExit = _prefix "EmergencyExit"
    /// <summary>
    /// A logic point that is used to indicate the end of a corridor.
    /// <see href="https://w3id.org/sbeo#EndPoint"></see></summary>
    let EndPoint = _prefix "EndPoint"
    /// <summary>
    /// It is a special type of point that connects more than two corridors or enforce change of direction to users or indicate the end of corridors.
    /// <see href="https://w3id.org/sbeo#NavigationalPoint"></see></summary>
    let NavigationalPoint = _prefix "NavigationalPoint"
    /// <summary>
    /// A point at which person passes from one place to the next.
    /// <see href="https://w3id.org/sbeo#TransitionPoint"></see></summary>
    let TransitionPoint = _prefix "TransitionPoint"
    /// <summary>
    /// A moving staircase consisting of an endlessly circulating belt of steps driven by a motor, which conveys people between the floors of a public building (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Escalator"></see></summary>
    let Escalator = _prefix "Escalator"
    /// <summary>
    /// A type of passage that connects spatial elements located on different storey or floor.
    /// <see href="https://w3id.org/sbeo#VerticalPassage"></see></summary>
    let VerticalPassage = _prefix "VerticalPassage"
    /// <summary>
    /// A physical impaired person whose wheelchair is escorted by another person.
    /// <see href="https://w3id.org/sbeo#EscortSupportedWheelchairPerson"></see></summary>
    let EscortSupportedWheelchairPerson = _prefix "EscortSupportedWheelchairPerson"
    /// <summary>
    /// A person using a wheelchair (a mobility device that is used while having any kind of tempoary or permanent physical impairment).
    /// <see href="https://w3id.org/sbeo#MobilityWithWheelchairPerson"></see></summary>
    let MobilityWithWheelchairPerson = _prefix "MobilityWithWheelchairPerson"
    /// <summary>
    /// An occurrence; something that happens (Oxford Dictionary of English). It represents when something planned or sudden happens.
    /// <see href="https://w3id.org/sbeo#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// A parameter to express the impact of an event on a specific person (or type of persons) in terms of any specific value or a type.
    /// <see href="https://w3id.org/sbeo#EventImpact"></see></summary>
    let EventImpact = _prefix "EventImpact"
    /// <summary>
    /// A property to express a sbeo:Event in a n-ary relation for sbeo:EventSeverity.
    /// <see href="https://w3id.org/sbeo#ofEvent"></see></summary>
    let ofEvent = _prefix "ofEvent"
    /// <summary>
    /// A parameter to express the severity of an event for a specific person (or type of persons) in terms of  potential severity levels.
    /// <see href="https://w3id.org/sbeo#EventSeverity"></see></summary>
    let EventSeverity = _prefix "EventSeverity"
    /// <summary>
    /// This instance is used to express the when someone has drained of one's energy or effectiveness.
    /// <see href="https://w3id.org/sbeo#Exhausted"></see></summary>
    let Exhausted = _prefix "Exhausted"
    /// <summary>
    /// A set of connected spaces represented by a starting and ending point, that ultimately leads to some specific position or place.
    /// <see href="https://w3id.org/sbeo#Route"></see></summary>
    let Route = _prefix "Route"
    /// <summary>
    /// A group of two or more persons having family ties between them.
    /// <see href="https://w3id.org/sbeo#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// An event that may burn different parts of the building and hazourdous for both the people and the building.
    /// <see href="https://w3id.org/sbeo#Fire"></see></summary>
    let Fire = _prefix "Fire"
    /// <summary>
    /// A type of door used to minimize the spread of fire and related effects by isolating two connected spaces or sections in the building.
    /// <see href="https://w3id.org/sbeo#FireDoor"></see></summary>
    let FireDoor = _prefix "FireDoor"
    /// <summary>
    /// It is an integral component installed in the building while construction to resist the fire.
    /// <see href="https://w3id.org/sbeo#PassiveFireProtectionDevice"></see></summary>
    let PassiveFireProtectionDevice = _prefix "PassiveFireProtectionDevice"
    /// <summary>
    /// A type of ladder which is used to make an emergency exit through the window out of fire accident site.
    /// <see href="https://w3id.org/sbeo#FireEscapeLadder"></see></summary>
    let FireEscapeLadder = _prefix "FireEscapeLadder"
    /// <summary>
    /// An active fire protection instrument used by persons to blow out small scale fire.
    /// <see href="https://w3id.org/sbeo#FireExtinguisher"></see></summary>
    let FireExtinguisher = _prefix "FireExtinguisher"
    /// <summary>
    /// Device that is used to avoid and minimize the effects of potentially danger events for the occupants of the building as well as for the structure of building itself.
    /// <see href="https://w3id.org/sbeo#IncidentProtectionDevice"></see></summary>
    let IncidentProtectionDevice = _prefix "IncidentProtectionDevice"
    /// <summary>
    /// This instance is used to express when the physical and mental condition is sound of someone.
    /// <see href="https://w3id.org/sbeo#Fit"></see></summary>
    let Fit = _prefix "Fit"
    /// <summary>
    /// A fitness status is associated with a person that represent the quality of being suitable for a specific activity.
    /// <see href="https://w3id.org/sbeo#FitnessStatus"></see></summary>
    let FitnessStatus = _prefix "FitnessStatus"
    /// <summary>
    /// This instance is used to express when someone is not fit and has some injuries.
    /// <see href="https://w3id.org/sbeo#Injured"></see></summary>
    let Injured = _prefix "Injured"
    /// <summary>
    /// A logical point that is used to represent the entrance to a floor.
    /// <see href="https://w3id.org/sbeo#FloorEntrance"></see></summary>
    let FloorEntrance = _prefix "FloorEntrance"
    /// <summary>
    /// A logical point that is used to represent the exit of a specific floor and that leads to different floors of a building.
    /// <see href="https://w3id.org/sbeo#FloorExit"></see></summary>
    let FloorExit = _prefix "FloorExit"
    /// <summary>
    /// This instance is used to express when someone is following one's provided path.
    /// <see href="https://w3id.org/sbeo#FollowingPath"></see></summary>
    let FollowingPath = _prefix "FollowingPath"
    /// <summary>
    /// A path for pedestrians in a built-up area; a pavement.
    /// <see href="https://w3id.org/sbeo#Footpath"></see></summary>
    let Footpath = _prefix "Footpath"
    /// <summary>
    /// A type of a passage that connects spatial elements located on the same storey or floor.
    /// <see href="https://w3id.org/sbeo#HorizontalPassage"></see></summary>
    let HorizontalPassage = _prefix "HorizontalPassage"
    /// <summary>
    /// A road or path forming a route between two places (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Thoroughfare"></see></summary>
    let Thoroughfare = _prefix "Thoroughfare"
    /// <summary>
    /// A graph-based route is a graphical way of representing a route in terms of nodes (sometimes called vertices) and edges (sometimes called arcs).
    /// <see href="https://w3id.org/sbeo#GraphBasedRoute"></see></summary>
    let GraphBasedRoute = _prefix "GraphBasedRoute"
    /// <summary>
    /// A type of route having minimum cost in terms of distance or time.
    /// <see href="https://w3id.org/sbeo#ShortestPath"></see></summary>
    let ShortestPath = _prefix "ShortestPath"
    /// <summary>
    /// A type of route having minimum complexity in terms of the amount of information required to negotiate each decision point, such as turning points.
    /// <see href="https://w3id.org/sbeo#SimplestPath"></see></summary>
    let SimplestPath = _prefix "SimplestPath"
    /// <summary>
    /// Expresses one of the persons who compose a social group.
    /// <see href="https://w3id.org/sbeo#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// A logical point that is used to represent the entrance to a hall.
    /// <see href="https://w3id.org/sbeo#HallEntrance"></see></summary>
    let HallEntrance = _prefix "HallEntrance"
    /// <summary>
    /// A logical point that is used to represent the exit of a Hall.
    /// <see href="https://w3id.org/sbeo#HallExit"></see></summary>
    let HallExit = _prefix "HallExit"
    /// <summary>
    /// A fragment or an atomic element of a hall.
    /// <see href="https://w3id.org/sbeo#HallSegment"></see></summary>
    let HallSegment = _prefix "HallSegment"
    /// <summary>
    /// A smart device or a computer that is small enough to be used while holding it in the hands.
    /// <see href="https://w3id.org/sbeo#HandheldDevice"></see></summary>
    let HandheldDevice = _prefix "HandheldDevice"
    /// <summary>
    /// It is a partial or total unability to hear. It is also known as Hearing loss.
    /// <see href="https://w3id.org/sbeo#HearingImpairedPerson"></see></summary>
    let HearingImpairedPerson = _prefix "HearingImpairedPerson"
    /// <summary>
    /// Sensory impairment is when one of the senses such as sight, hearing, smell, touch, taste and spatial awareness, is no longer normal.
    /// <see href="https://w3id.org/sbeo#SensoryImpairedPerson"></see></summary>
    let SensoryImpairedPerson = _prefix "SensoryImpairedPerson"
    /// <summary>
    /// A slow-moving conveyor mechanism that transports people across a horizontal plane over a short to medium distance.
    /// <see href="https://w3id.org/sbeo#HorizontalMovingPavement"></see></summary>
    let HorizontalMovingPavement = _prefix "HorizontalMovingPavement"
    /// <summary>
    /// A slow-moving conveyor mechanism that transports people across a horizontal or inclined plane over a short to medium distance (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#MovingPavement"></see></summary>
    let MovingPavement = _prefix "MovingPavement"
    /// <summary>
    /// A slow-moving conveyor mechanism that transports people across an inclined plane over a short to medium distance.
    /// <see href="https://w3id.org/sbeo#VerticalMovingPavement"></see></summary>
    let VerticalMovingPavement = _prefix "VerticalMovingPavement"
    /// <summary>
    /// Any spatial element that is part of a path and traversable by persons. In addition, it may be used as a logic representation of physical passages to represent an edge (or an arc) in a route graph.
    /// <see href="https://w3id.org/sbeo#Passage"></see></summary>
    let Passage = _prefix "Passage"
    /// <summary>
    /// A building that contains rooms, apartments or suites where people stay for a specific time period.
    /// <see href="https://w3id.org/sbeo#HotelBuilding"></see></summary>
    let HotelBuilding = _prefix "HotelBuilding"
    /// <summary>
    /// A type of description in which images are given to provide information about any entity.
    /// <see href="https://w3id.org/sbeo#ImageDescription"></see></summary>
    let ImageDescription = _prefix "ImageDescription"
    /// <summary>
    /// An individual whose natural senses or physical abilities are either diminished or damaged.
    /// <see href="https://w3id.org/sbeo#ImpairedPerson"></see></summary>
    let ImpairedPerson = _prefix "ImpairedPerson"
    /// <summary>
    /// A logic point that connects more than two corridors.
    /// <see href="https://w3id.org/sbeo#Junction"></see></summary>
    let Junction = _prefix "Junction"
    /// <summary>
    /// A place where infants or young children can play which is surrounded by a boundary normally. It can be both indoor and outdoor.
    /// <see href="https://w3id.org/sbeo#KidsArea"></see></summary>
    let KidsArea = _prefix "KidsArea"
    /// <summary>
    /// It is the unability to sustain physical or mental activity to a normal level.
    /// <see href="https://w3id.org/sbeo#LowStaminaPerson"></see></summary>
    let LowStaminaPerson = _prefix "LowStaminaPerson"
    /// <summary>
    /// A physical impairment is a condition in which any part of person's body is either  damaged or is not working properly.
    /// <see href="https://w3id.org/sbeo#PhysicallyImpairedPerson"></see></summary>
    let PhysicallyImpairedPerson = _prefix "PhysicallyImpairedPerson"
    /// <summary>
    /// A person whose visual acuity is 20/70 or poorer in the better-seeing eye and cannot be corrected or improved with regular eyeglasses.
    /// <see href="https://w3id.org/sbeo#LowVisionPerson"></see></summary>
    let LowVisionPerson = _prefix "LowVisionPerson"
    /// <summary>
    /// A type of room designated for social gathering of people, especially professional meetings.
    /// <see href="https://w3id.org/sbeo#MeetingRoom"></see></summary>
    let MeetingRoom = _prefix "MeetingRoom"
    /// <summary>
    /// The mental ability of an indi-vidual to remain focused on an external stimuli or an internal experience for a certain period of time (World Health Organisation).
    /// <see href="https://w3id.org/sbeo#MentalAbility"></see></summary>
    let MentalAbility = _prefix "MentalAbility"
    /// <summary>
    /// A person who is only able to hear the sounds that are between 25 and 40 dB.
    /// <see href="https://w3id.org/sbeo#MildHearingImpairedPerson"></see></summary>
    let MildHearingImpairedPerson = _prefix "MildHearingImpairedPerson"
    /// <summary>
    /// A telephone with access to a cellular radio system so it can be used over a wide area, without a physical connection to a network (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#MobilePhone"></see></summary>
    let MobilePhone = _prefix "MobilePhone"
    /// <summary>
    /// A device for transmitting voices over a distance using wire or radio, by converting acoustic vibrations to electrical signals (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Telephone"></see></summary>
    let Telephone = _prefix "Telephone"
    /// <summary>
    /// A person who used a motorised device for moving, such as motorised wheelchair or scooter, etc.
    /// <see href="https://w3id.org/sbeo#MobilityWithAssistedDevicePerson"></see></summary>
    let MobilityWithAssistedDevicePerson = _prefix "MobilityWithAssistedDevicePerson"
    /// <summary>
    /// A person who cannot hear sounds that are less than 40-75 dB.
    /// <see href="https://w3id.org/sbeo#ModerateHearingImpairedPerson"></see></summary>
    let ModerateHearingImpairedPerson = _prefix "ModerateHearingImpairedPerson"
    /// <summary>
    /// It describes the movement of a person.
    /// <see href="https://w3id.org/sbeo#MotionState"></see></summary>
    let MotionState = _prefix "MotionState"
    /// <summary>
    /// A type of movement by turning over and over on an axis, usually performed by a person using a wheelchair,
    /// <see href="https://w3id.org/sbeo#Rolling"></see></summary>
    let Rolling = _prefix "Rolling"
    /// <summary>
    /// A movement of an able-bodied person at a speed faster than a walk
    /// <see href="https://w3id.org/sbeo#Running"></see></summary>
    let Running = _prefix "Running"
    /// <summary>
    /// A type of movement usually performed while sitting in (or riding on) an automatic or mechical device, such as electrical wheelchair, electric scooter, etc.
    /// <see href="https://w3id.org/sbeo#Scooting"></see></summary>
    let Scooting = _prefix "Scooting"
    /// <summary>
    /// Having or maintaining an upright position, supported by one's feet (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Standing"></see></summary>
    let Standing = _prefix "Standing"
    /// <summary>
    /// An unhurried rate of movement on foot (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Walking"></see></summary>
    let Walking = _prefix "Walking"
    /// <summary>
    /// It is a kind of wheelchair that has either a mechanical engine or an electric battery. It has more speed than a traditional wheelchair.
    /// <see href="https://w3id.org/sbeo#MotorisedWheelchairPerson"></see></summary>
    let MotorisedWheelchairPerson = _prefix "MotorisedWheelchairPerson"
    /// <summary>
    /// A type of navigation in which multiple point of interests are supposed to be visited by a person.
    /// <see href="https://w3id.org/sbeo#MultiObjectiveNavigation"></see></summary>
    let MultiObjectiveNavigation = _prefix "MultiObjectiveNavigation"
    /// <summary>
    /// The process or activity of accurately ascertaining one's position and planning and following a route (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Navigation"></see></summary>
    let Navigation = _prefix "Navigation"
    /// <summary>
    /// It models the user's navigational state while following the path.
    /// <see href="https://w3id.org/sbeo#NavigationalState"></see></summary>
    let NavigationalState = _prefix "NavigationalState"
    /// <summary>
    /// A traditional wheelchair that is used by hands. It has significantly lower speed than motorised wheelchairs.
    /// <see href="https://w3id.org/sbeo#NonMotorisedWheelchairPerson"></see></summary>
    let NonMotorisedWheelchairPerson = _prefix "NonMotorisedWheelchairPerson"
    /// <summary>
    /// A logical point that is used to represent the entrance to an open area.
    /// <see href="https://w3id.org/sbeo#OpenAreaEntrance"></see></summary>
    let OpenAreaEntrance = _prefix "OpenAreaEntrance"
    /// <summary>
    /// A logical point that is used to represent the exit from a specifc open space.
    /// <see href="https://w3id.org/sbeo#OpenAreaExit"></see></summary>
    let OpenAreaExit = _prefix "OpenAreaExit"
    /// <summary>
    /// A  sudden uncontrollable fear or anxiety among the occupants of the building that often causes wildly unthinking behaviour (Oxford Dictionary of English). In indoor environments, it may happens due to several reasons such as earthquake, fire or other sudden hazardous situations.
    /// <see href="https://w3id.org/sbeo#Panic"></see></summary>
    let Panic = _prefix "Panic"
    /// <summary>
    /// It represents the physical or conceptual elements of a navigation path.
    /// <see href="https://w3id.org/sbeo#RouteElement"></see></summary>
    let RouteElement = _prefix "RouteElement"
    /// <summary>
    /// A parameter to express the quality of an ability a specific person (or type of persons) own.
    /// <see href="https://w3id.org/sbeo#PersonAbility"></see></summary>
    let PersonAbility = _prefix "PersonAbility"
    /// <summary>
    /// A property to express a sbeo:Ability in a n-ary relation for sbeo:PersonAbility.
    /// <see href="https://w3id.org/sbeo#hasAbility"></see></summary>
    let hasAbility = _prefix "hasAbility"
    /// <summary>
    /// A property to express a quality of something in terms of different levels. For example, good, bad, medium, perfect, mild, and so forth.
    /// <see href="https://w3id.org/sbeo#hasQuality"></see></summary>
    let hasQuality = _prefix "hasQuality"
    /// <summary>
    /// A degree or grade of excellence or worth.
    /// <see href="https://w3id.org/sbeo#Quality"></see></summary>
    let Quality = _prefix "Quality"
    /// <summary>
    /// A parameter to express the accessibility of any space for a specific person (or type of persons) in terms of some value.
    /// <see href="https://w3id.org/sbeo#PersonAccessibility"></see></summary>
    let PersonAccessibility = _prefix "PersonAccessibility"
    /// <summary>
    /// A physical, three dimensional, and one of the most important elements in the design of architecture that can further be divided to create more spaces from it.
    /// <see href="https://w3id.org/sbeo#Space"></see></summary>
    let Space = _prefix "Space"
    /// <summary>
    /// A property to express a sbeo:Space in a n-ary relation for sbeo:Parameter.
    /// <see href="https://w3id.org/sbeo#ofSpace"></see></summary>
    let ofSpace = _prefix "ofSpace"
    /// <summary>
    /// Provides a value that is a direct representation of an entity.
    /// <see href="https://w3id.org/sbeo#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// Any physical or virtual location or object, which may be of interest to a user and may serve as a navigation destination (e.g., room, water dispenser, waiting zone, assembly point, shop, seat, etc).
    /// <see href="https://w3id.org/sbeo#PointOfInterest"></see></summary>
    let PointOfInterest = _prefix "PointOfInterest"
    /// <summary>
    /// A traverasal part of a space that is connected to a specific Point of Interest.
    /// <see href="https://w3id.org/sbeo#PointOfInterestSegment"></see></summary>
    let PointOfInterestSegment = _prefix "PointOfInterestSegment"
    /// <summary>
    /// A person who cannot hear sounds softer than 90-120 dB. A person suffering from profound hearing loss, using a hearing aid is also ineffective most of the time.
    /// <see href="https://w3id.org/sbeo#ProfoundHearingImpairedPerson"></see></summary>
    let ProfoundHearingImpairedPerson = _prefix "ProfoundHearingImpairedPerson"
    /// <summary>
    /// A sloping surface joining two different levels, as at the entrance or between floors of a building (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Ramp"></see></summary>
    let Ramp = _prefix "Ramp"
    /// <summary>
    /// A road is a way on land between two places that has been paved or otherwise improved to allow travel by foot or some form of conveyance, including a motor vehicle, cart, bicycle, or horse.
    /// <see href="https://w3id.org/sbeo#Road"></see></summary>
    let Road = _prefix "Road"
    /// <summary>
    /// The function assumed or part played by a person or thing in a particular situation (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A concept to express that an agent is playing a role in a given context.
    /// <see href="https://w3id.org/sbeo#RoleInContext"></see></summary>
    let RoleInContext = _prefix "RoleInContext"
    /// <summary>
    /// The circumstances that form the setting for an event, statement, or idea, and in terms of which it can be fully understood and assessed (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#context"></see></summary>
    let context = _prefix "context"
    /// <summary>
    /// It express an agent that plays a role in a specific context.
    /// <see href="https://w3id.org/sbeo#player"></see></summary>
    let player = _prefix "player"
    /// <summary>
    /// Expresses a role of an agent.
    /// <see href="https://w3id.org/sbeo#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// A logical point that is used to represent the entrance to a room.
    /// <see href="https://w3id.org/sbeo#RoomEntrance"></see></summary>
    let RoomEntrance = _prefix "RoomEntrance"
    /// <summary>
    /// A logical point that is used to represent the exit of a room.
    /// <see href="https://w3id.org/sbeo#RoomExit"></see></summary>
    let RoomExit = _prefix "RoomExit"
    /// <summary>
    /// A traversable part in a room that is usually used to go the exit or the other part of the room.
    /// <see href="https://w3id.org/sbeo#RoomSegment"></see></summary>
    let RoomSegment = _prefix "RoomSegment"
    /// <summary>
    /// A type of route in which the ending point represents the seat of one or more individuals such as in cinema, stadiums, auditoriums, etc.
    /// <see href="https://w3id.org/sbeo#SeatingArrangementRoute"></see></summary>
    let SeatingArrangementRoute = _prefix "SeatingArrangementRoute"
    /// <summary>
    /// This concept is used to express an event detected by any sensor.
    /// <see href="https://w3id.org/sbeo#SensorEvent"></see></summary>
    let SensorEvent = _prefix "SensorEvent"
    /// <summary>
    /// A person who is unable to hear anything without wearing a hearing aid.
    /// <see href="https://w3id.org/sbeo#SevereHearingImpairedPerson"></see></summary>
    let SevereHearingImpairedPerson = _prefix "SevereHearingImpairedPerson"
    /// <summary>
    /// A set of one or more buildings forming a complex of shops representing merchandisers, with interconnecting walkways enabling visitors to easily walk from unit to unit, along with a parking area.
    /// <see href="https://w3id.org/sbeo#ShoppingMallBuilding"></see></summary>
    let ShoppingMallBuilding = _prefix "ShoppingMallBuilding"
    /// <summary>
    /// A type of route in which the specific points of interest are mentioned in the form of connected spaces, according to the preferences or interests of a one or more individuals.
    /// <see href="https://w3id.org/sbeo#ShoppingRoute"></see></summary>
    let ShoppingRoute = _prefix "ShoppingRoute"
    /// <summary>
    /// A type of route created for visiting purposes within an indoor environment.
    /// <see href="https://w3id.org/sbeo#VisitRoute"></see></summary>
    let VisitRoute = _prefix "VisitRoute"
    /// <summary>
    /// A mobile phone that is able to perform many of the functions of a computer, typically having a relatively large screen and an operating system capable of running general-purpose applications (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#SmartPhone"></see></summary>
    let SmartPhone = _prefix "SmartPhone"
    /// <summary>
    /// A parameter to express the safety of any space for a specific person (or type of persons) in terms of some value.
    /// <see href="https://w3id.org/sbeo#SpaceSafety"></see></summary>
    let SpaceSafety = _prefix "SpaceSafety"
    /// <summary>
    /// This ability expresses the capacity to understand, reason and remember the spatial relations among objects and spaces.
    /// <see href="https://w3id.org/sbeo#SpatialAbility"></see></summary>
    let SpatialAbility = _prefix "SpatialAbility"
    /// <summary>
    /// A building that has a large open area surrounded by many rows of seats, and  used for sports events, concerts, etc.
    /// <see href="https://w3id.org/sbeo#StadiumBuilding"></see></summary>
    let StadiumBuilding = _prefix "StadiumBuilding"
    /// <summary>
    /// A sudden and uncontrollable run by the group of people caused by panic.
    /// <see href="https://w3id.org/sbeo#Stampeding"></see></summary>
    let Stampeding = _prefix "Stampeding"
    /// <summary>
    /// A suite of rooms usually on one floor of an apartment house (Cambridge English Dictionary). This term is normally used in hotels, resorts, guesthouses, etc.
    /// <see href="https://w3id.org/sbeo#Suite"></see></summary>
    let Suite = _prefix "Suite"
    /// <summary>
    /// A surprise event involving the deliberate use of violence against the occupants of the buildings.
    /// <see href="https://w3id.org/sbeo#TerroristAttack"></see></summary>
    let TerroristAttack = _prefix "TerroristAttack"
    /// <summary>
    /// A type of description in which only text or writings are used to provide the information about any entity.
    /// <see href="https://w3id.org/sbeo#TextualDescription"></see></summary>
    let TextualDescription = _prefix "TextualDescription"
    /// <summary>
    /// A logic point that is used to enforce people to change their direction.
    /// <see href="https://w3id.org/sbeo#TurnPoint"></see></summary>
    let TurnPoint = _prefix "TurnPoint"
    /// <summary>
    /// An activity that represents an act of going to see a person or place as a guest, tourist or a spectator. Normally, this type of activity is considered as a leasiure or recreational activity.
    /// <see href="https://w3id.org/sbeo#Visit"></see></summary>
    let Visit = _prefix "Visit"
    /// <summary>
    /// A group of two or more people that has the same objective of visiting any space.
    /// <see href="https://w3id.org/sbeo#VisitingGroup"></see></summary>
    let VisitingGroup = _prefix "VisitingGroup"
    /// <summary>
    /// A space (normally with seating), where people can wait to do some specific activity. During emergency condtions, it is also used for several purposes, such as unification of people with their family members, acquaintances or emergency rescue teams, etc.
    /// <see href="https://w3id.org/sbeo#WaitingZone"></see></summary>
    let WaitingZone = _prefix "WaitingZone"
    /// <summary>
    /// The accommodating capacity (in terms of persons) of a particular space.
    /// <see href="https://w3id.org/sbeo#accommodationCapacity"></see></summary>
    let accommodationCapacity = _prefix "accommodationCapacity"
    /// <summary>
    /// Be present or associated with a person.
    /// <see href="https://w3id.org/sbeo#accompanying"></see></summary>
    let accompanying = _prefix "accompanying"
    /// <summary>
    /// Any friend or an acquaintance tie among occupants.
    /// <see href="https://w3id.org/sbeo#acquaintanceOf"></see></summary>
    let acquaintanceOf = _prefix "acquaintanceOf"
    /// <summary>
    /// Nearest in space or position; immediately adjoining without intervening space or element; an exact neighbour.
    /// <see href="https://w3id.org/sbeo#adjacentTo"></see></summary>
    let adjacentTo = _prefix "adjacentTo"
    /// <summary>
    /// A set of connected spaces(normally in the form of rdf:list) assigned to a social unit.
    /// <see href="https://w3id.org/sbeo#assignedRoute"></see></summary>
    let assignedRoute = _prefix "assignedRoute"
    /// <summary>
    /// The time at which an activity or event occurred.
    /// <see href="https://w3id.org/sbeo#atTime"></see></summary>
    let atTime = _prefix "atTime"
    /// <summary>
    /// Being joined by a common element; more specificially, a physical connection between two space elements.
    /// <see href="https://w3id.org/sbeo#connectedTo"></see></summary>
    let connectedTo = _prefix "connectedTo"
    /// <summary>
    /// A numeric value associated with an edge or a complete route(path). It is also reffered to as a weight.
    /// <see href="https://w3id.org/sbeo#cost"></see></summary>
    let cost = _prefix "cost"
    /// <summary>
    /// The current occupancy (in terms of persons) of a particular space.
    /// <see href="https://w3id.org/sbeo#currentOccupancy"></see></summary>
    let currentOccupancy = _prefix "currentOccupancy"
    /// <summary>
    /// A dynamic or momentary information about a specific activity, event, social unit, or a space.
    /// <see href="https://w3id.org/sbeo#dynamicDescription"></see></summary>
    let dynamicDescription = _prefix "dynamicDescription"
    /// <summary>
    /// The time at which an activity ended.
    /// <see href="https://w3id.org/sbeo#endedAtTime"></see></summary>
    let endedAtTime = _prefix "endedAtTime"
    /// <summary>
    /// Start is when an activity is deemed to have been started by an entity, known as trigger.
    /// <see href="https://w3id.org/sbeo#startedAtTime"></see></summary>
    let startedAtTime = _prefix "startedAtTime"
    /// <summary>
    /// Expresses the removal of any physical space or point of interest for the consideration of any social unit.
    /// <see href="https://w3id.org/sbeo#excludedFor"></see></summary>
    let excludedFor = _prefix "excludedFor"
    /// <summary>
    /// States the familiarity of any social unit with a physical space or point of interest.
    /// <see href="https://w3id.org/sbeo#familiarWith"></see></summary>
    let familiarWith = _prefix "familiarWith"
    /// <summary>
    /// The status of an activity being performed by a social unit.
    /// <see href="https://w3id.org/sbeo#hasActivityStatus"></see></summary>
    let hasActivityStatus = _prefix "hasActivityStatus"
    /// <summary>
    /// Expresses a descriptive information about any specific space, point, activiy, event or device.
    /// <see href="https://w3id.org/sbeo#hasDescription"></see></summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    /// A deviation status of a person depending on how ofthen one deviates from the proposed route.
    /// <see href="https://w3id.org/sbeo#hasDeviationState"></see></summary>
    let hasDeviationState = _prefix "hasDeviationState"
    /// <summary>
    /// A fitness status is associated with a person that represent the quality of being suitable for a specific activity. There are three different levels of fitness levels are introduced that can be extended according to the needs of the application. These are 'Fit', 'Exhausted' and 'Injured'.
    /// <see href="https://w3id.org/sbeo#hasFitnessStatus"></see></summary>
    let hasFitnessStatus = _prefix "hasFitnessStatus"
    /// <summary>
    /// The motion state of a person.
    /// <see href="https://w3id.org/sbeo#hasMotionState"></see></summary>
    let hasMotionState = _prefix "hasMotionState"
    /// <summary>
    /// A navigational state of a social unit while following any path.
    /// <see href="https://w3id.org/sbeo#hasNavigationalState"></see></summary>
    let hasNavigationalState = _prefix "hasNavigationalState"
    /// <summary>
    /// A type of navigation provided to a person to perform a specific activity.
    /// <see href="https://w3id.org/sbeo#hasNavigationalType"></see></summary>
    let hasNavigationalType = _prefix "hasNavigationalType"
    /// <summary>
    /// Number of times a social unit is deviated while following the provided path.
    /// <see href="https://w3id.org/sbeo#hasXTimesDeviated"></see></summary>
    let hasXTimesDeviated = _prefix "hasXTimesDeviated"
    /// <summary>
    /// An unique identification number of something such as, social unit, device, etc.
    /// <see href="https://w3id.org/sbeo#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// Place or fix (equipment or machinery) in position ready for use (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#installedIn"></see></summary>
    let installedIn = _prefix "installedIn"
    /// <summary>
    /// Be a means of access to a particular space or point.
    /// <see href="https://w3id.org/sbeo#leadsTo"></see></summary>
    let leadsTo = _prefix "leadsTo"
    /// <summary>
    /// States the location of any social unit, activity, event, physical space, or a point of interest at any other physical space.
    /// <see href="https://w3id.org/sbeo#locatedIn"></see></summary>
    let locatedIn = _prefix "locatedIn"
    /// <summary>
    /// Associates the lower storey in a building.
    /// <see href="https://w3id.org/sbeo#lower"></see></summary>
    let lower = _prefix "lower"
    /// <summary>
    /// Associates the upper storey in a building.
    /// <see href="https://w3id.org/sbeo#upper"></see></summary>
    let upper = _prefix "upper"
    /// <summary>
    /// A method of notifying a social unit.
    /// <see href="https://w3id.org/sbeo#meansOfNotification"></see></summary>
    let meansOfNotification = _prefix "meansOfNotification"
    /// <summary>
    /// A notification preference for any kind of social unit.
    /// <see href="https://w3id.org/sbeo#notificationPreference"></see></summary>
    let notificationPreference = _prefix "notificationPreference"
    /// <summary>
    /// A number assigned to anything.
    /// <see href="https://w3id.org/sbeo#number"></see></summary>
    let number = _prefix "number"
    /// <summary>
    /// Expresses a physical space as a part or a fragment of another physical space. For example, a block of apartments can be a part of apartment building, etc.
    /// <see href="https://w3id.org/sbeo#partOf"></see></summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// Expresses an activity carried out by a social unit.
    /// <see href="https://w3id.org/sbeo#performedBy"></see></summary>
    let performedBy = _prefix "performedBy"
    /// <summary>
    /// Having an obligation to do something, or having control over or care for someone, as part of one's role (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#responsibleTo"></see></summary>
    let responsibleTo = _prefix "responsibleTo"
    /// <summary>
    /// Route preference of a social unit to perform an activity.
    /// <see href="https://w3id.org/sbeo#routePreference"></see></summary>
    let routePreference = _prefix "routePreference"
    /// <summary>
    /// This property is used to express the type of a route in terms of graph-based routes, such as Shortest Path, Simplest Path etc.
    /// <see href="https://w3id.org/sbeo#routeType"></see></summary>
    let routeType = _prefix "routeType"
    /// <summary>
    /// The average speed of a person.
    /// <see href="https://w3id.org/sbeo#speed"></see></summary>
    let speed = _prefix "speed"
    /// <summary>
    /// A multiplying factor that may affect the speed of person while passing through a specific space.
    /// <see href="https://w3id.org/sbeo#speedFactor"></see></summary>
    let speedFactor = _prefix "speedFactor"
    /// <summary>
    /// A static or a fix information about any activity, event, space, social unit, or point of interest.
    /// <see href="https://w3id.org/sbeo#staticDescription"></see></summary>
    let staticDescription = _prefix "staticDescription"
    /// <summary>
    /// The length of time during which any activity or event lasts.
    /// <see href="https://w3id.org/sbeo#timeDuration"></see></summary>
    let timeDuration = _prefix "timeDuration"
    /// <summary>
    /// A specific period of time required to move from one place to another.
    /// <see href="https://w3id.org/sbeo#travelTime"></see></summary>
    let travelTime = _prefix "travelTime"
    /// <summary>
    /// Expresses a momentary information about a physical space or a point being used by a social unit.
    /// <see href="https://w3id.org/sbeo#uses"></see></summary>
    let uses = _prefix "uses"
    /// <summary>
    /// The measurement or extent of something from side to side (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#width"></see></summary>
    let width = _prefix "width"
