namespace https.w3id.org.sbeo.hash

open DoxAletheia.Rdf_Vocabulary

module sbeo =
    let _namespace_name = "https://w3id.org/sbeo#"
    /// <summary>
    /// The measurement or extent of something from end to end (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName
    /// <summary>
    /// An individual, or a group or community, considered as a discrete constituent of a society or larger group (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#SocialUnit"></see></summary>
    let SocialUnit = Namespaced_IRI.parse _namespace_name "SocialUnit" |> NamespacedName
    /// <summary>
    /// Possession of the means or skill to do something (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Ability"></see></summary>
    let Ability = Namespaced_IRI.parse _namespace_name "Ability" |> NamespacedName

    /// <summary>
    /// An ability to hear.
    /// <see href="https://w3id.org/sbeo#AbilityToHear"></see></summary>
    let AbilityToHear =
        Namespaced_IRI.parse _namespace_name "AbilityToHear" |> NamespacedName

    /// <summary>
    /// Sensory ability is referred to the brain's ability to receive, interpret, and effectively use the information provided by the senses in human beings such as touch, hear, smell, vision, etc.
    /// <see href="https://w3id.org/sbeo#SensoryAbility"></see></summary>
    let SensoryAbility =
        Namespaced_IRI.parse _namespace_name "SensoryAbility" |> NamespacedName

    /// <summary>
    /// An ability to run.
    /// <see href="https://w3id.org/sbeo#AbilityToRun"></see></summary>
    let AbilityToRun =
        Namespaced_IRI.parse _namespace_name "AbilityToRun" |> NamespacedName

    /// <summary>
    /// This ability is used to represent all kinetic abilities a person may have.
    /// <see href="https://w3id.org/sbeo#MobilityAbility"></see></summary>
    let MobilityAbility =
        Namespaced_IRI.parse _namespace_name "MobilityAbility" |> NamespacedName

    /// <summary>
    /// An ability to hear.
    /// <see href="https://w3id.org/sbeo#AbilityToSee"></see></summary>
    let AbilityToSee =
        Namespaced_IRI.parse _namespace_name "AbilityToSee" |> NamespacedName

    /// <summary>
    /// An ability to talk.
    /// <see href="https://w3id.org/sbeo#AbilityToTalk"></see></summary>
    let AbilityToTalk =
        Namespaced_IRI.parse _namespace_name "AbilityToTalk" |> NamespacedName

    /// <summary>
    /// An ability to touch.
    /// <see href="https://w3id.org/sbeo#AbilityToTouch"></see></summary>
    let AbilityToTouch =
        Namespaced_IRI.parse _namespace_name "AbilityToTouch" |> NamespacedName

    /// <summary>
    /// An ability to use the stairs. Note that the people on the wheelchair are not considered to have this ability no matter the stairs have a stairlift and a ramp.
    /// <see href="https://w3id.org/sbeo#AbilityToUseStairs"></see></summary>
    let AbilityToUseStairs =
        Namespaced_IRI.parse _namespace_name "AbilityToUseStairs" |> NamespacedName

    /// <summary>
    /// An ability of a person to walk. A person who is using crutches is also considered to have this ability.
    /// <see href="https://w3id.org/sbeo#AbilityToWalk"></see></summary>
    let AbilityToWalk =
        Namespaced_IRI.parse _namespace_name "AbilityToWalk" |> NamespacedName

    /// <summary>
    /// It is an integral part of the fire protection used as a first response to minimize the spread of fire and related effects.
    /// <see href="https://w3id.org/sbeo#ActiveFireProtectionDevice"></see></summary>
    let ActiveFireProtectionDevice =
        Namespaced_IRI.parse _namespace_name "ActiveFireProtectionDevice" |> NamespacedName

    /// <summary>
    /// Device that is used to minimize the effects of potentially danger fires.
    /// <see href="https://w3id.org/sbeo#FireProtectionDevice"></see></summary>
    let FireProtectionDevice =
        Namespaced_IRI.parse _namespace_name "FireProtectionDevice" |> NamespacedName

    /// <summary>
    /// A process that a person, group of persons, or machine does during a specific amount of time, such as visiting, shopping, etc.
    /// <see href="https://w3id.org/sbeo#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    /// The measurable amount of a property, such as force, brightness, or a magnetic field (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Intensity"></see></summary>
    let Intensity = Namespaced_IRI.parse _namespace_name "Intensity" |> NamespacedName

    /// <summary>
    /// A property to express the intensity of a particular sbeo:Activity or sbeo:Event.
    /// <see href="https://w3id.org/sbeo#hasIntensity"></see></summary>
    let hasIntensity =
        Namespaced_IRI.parse _namespace_name "hasIntensity" |> NamespacedName

    /// <summary>
    /// A parameter to express the impact of an activity on a specific person (or type of persons) in terms of any specific value or a type.
    /// <see href="https://w3id.org/sbeo#ActivityImpact"></see></summary>
    let ActivityImpact =
        Namespaced_IRI.parse _namespace_name "ActivityImpact" |> NamespacedName

    /// <summary>
    /// A property to express a foaf:Person in a n-ary relation for sbeo:Parameter.
    /// <see href="https://w3id.org/sbeo#forPerson"></see></summary>
    let forPerson = Namespaced_IRI.parse _namespace_name "forPerson" |> NamespacedName
    /// <summary>
    /// A property to express the impact of a particular sbeo:Activity or sbeo:Event.
    /// <see href="https://w3id.org/sbeo#hasImpact"></see></summary>
    let hasImpact = Namespaced_IRI.parse _namespace_name "hasImpact" |> NamespacedName
    /// <summary>
    /// An impact is a long-lasting effect of an event (or activity), that continues to exist after the event (or activity) has taken place.
    /// <see href="https://w3id.org/sbeo#Impact"></see></summary>
    let Impact = Namespaced_IRI.parse _namespace_name "Impact" |> NamespacedName
    /// <summary>
    /// A property to express a sbeo:Activity in a n-ary relation for sbeo:ActivitySeverity.
    /// <see href="https://w3id.org/sbeo#ofActivity"></see></summary>
    let ofActivity = Namespaced_IRI.parse _namespace_name "ofActivity" |> NamespacedName
    /// <summary>
    /// A numerical or other measurable factor forming one of a set that defines a system or sets the conditions of its operation.
    /// <see href="https://w3id.org/sbeo#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName

    /// <summary>
    /// A parameter to express the severity of an activity for a specific person (or type of persons) in terms of  potential severity levels.
    /// <see href="https://w3id.org/sbeo#ActivitySeverity"></see></summary>
    let ActivitySeverity =
        Namespaced_IRI.parse _namespace_name "ActivitySeverity" |> NamespacedName

    /// <summary>
    /// A property to express a sbeo:Severity in a n-ary relation for sbeo:ActivitySeverity or  sbeo:EventSeverity.
    /// <see href="https://w3id.org/sbeo#hasSeverity"></see></summary>
    let hasSeverity =
        Namespaced_IRI.parse _namespace_name "hasSeverity" |> NamespacedName

    /// <summary>
    /// The quality of being hard to endure, uninviting or formidable.
    /// <see href="https://w3id.org/sbeo#Severity"></see></summary>
    let Severity = Namespaced_IRI.parse _namespace_name "Severity" |> NamespacedName

    /// <summary>
    /// It expresses the status of a specific activity being performed by a person.
    /// <see href="https://w3id.org/sbeo#ActivityStatus"></see></summary>
    let ActivityStatus =
        Namespaced_IRI.parse _namespace_name "ActivityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sbeo#Evacuated"></see>
    /// </summary>
    let Evacuated = Namespaced_IRI.parse _namespace_name "Evacuated" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/sbeo#Evacuating"></see>
    /// </summary>
    let Evacuating = Namespaced_IRI.parse _namespace_name "Evacuating" |> NamespacedName

    /// <summary>
    /// This instance is used to express when someone is picking up the dependent member of one's group.
    /// <see href="https://w3id.org/sbeo#PickingUpDependents"></see></summary>
    let PickingUpDependents =
        Namespaced_IRI.parse _namespace_name "PickingUpDependents" |> NamespacedName

    /// <summary>
    /// The activity of making visits.
    /// <see href="https://w3id.org/sbeo#Visiting"></see></summary>
    let Visiting = Namespaced_IRI.parse _namespace_name "Visiting" |> NamespacedName

    /// <summary>
    /// Alerting devices are those devices that are used to react to normal as well as alarming situations to let people know that some specific condition is occuring.
    /// <see href="https://w3id.org/sbeo#AlertingDevice"></see></summary>
    let AlertingDevice =
        Namespaced_IRI.parse _namespace_name "AlertingDevice" |> NamespacedName

    /// <summary>
    /// A thing made or adapted for a particular purpose, especially a piece of mechanical or electronic equipment (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName

    /// <summary>
    /// An alerting device that is used to assist or notify people with impairments during a specific circumstance.
    /// <see href="https://w3id.org/sbeo#AlertingDeviceForImpairedPerson"></see></summary>
    let AlertingDeviceForImpairedPerson =
        Namespaced_IRI.parse _namespace_name "AlertingDeviceForImpairedPerson" |> NamespacedName

    /// <summary>
    /// A person having an Alzheimer's disease.
    /// <see href="https://w3id.org/sbeo#AlzheimersDiseasedPerson"></see></summary>
    let AlzheimersDiseasedPerson =
        Namespaced_IRI.parse _namespace_name "AlzheimersDiseasedPerson" |> NamespacedName

    /// <summary>
    /// A person having mental impairment in which one's mind is damaged or is not working properly and one have issues such as consciousness, orientation, concentration.
    /// <see href="https://w3id.org/sbeo#MentalImpairedPerson"></see></summary>
    let MentalImpairedPerson =
        Namespaced_IRI.parse _namespace_name "MentalImpairedPerson" |> NamespacedName

    /// <summary>
    /// A suite of rooms usually on one floor of an apartment house (Cambridge English Dictionary).
    /// <see href="https://w3id.org/sbeo#Apartment"></see></summary>
    let Apartment = Namespaced_IRI.parse _namespace_name "Apartment" |> NamespacedName

    /// <summary>
    /// A set of one or more buildings that contain apartments in it.
    /// <see href="https://w3id.org/sbeo#AppartmentBuilding"></see></summary>
    let AppartmentBuilding =
        Namespaced_IRI.parse _namespace_name "AppartmentBuilding" |> NamespacedName

    /// <summary>
    /// A place where people in an office, etc. should go if there is an emergency, for example, a fire (Cambridge English Dictionary) .
    /// <see href="https://w3id.org/sbeo#AssemblyPoint"></see></summary>
    let AssemblyPoint =
        Namespaced_IRI.parse _namespace_name "AssemblyPoint" |> NamespacedName

    /// <summary>
    /// Any spatial element that is part of a path and traversable by persons. In addition, it may be used as a logic representation of physical passages to represent a node (or a vertex) in a route graph.
    /// <see href="https://w3id.org/sbeo#RoutePoint"></see></summary>
    let RoutePoint = Namespaced_IRI.parse _namespace_name "RoutePoint" |> NamespacedName

    /// <summary>
    /// A type of navigation in which a person is assisted by a person or a machine to perform a specific activity.
    /// <see href="https://w3id.org/sbeo#AssistedNavigation"></see></summary>
    let AssistedNavigation =
        Namespaced_IRI.parse _namespace_name "AssistedNavigation" |> NamespacedName

    /// <summary>
    /// A type of description in which sounds such as voices, are used to provide the information about any entity.
    /// <see href="https://w3id.org/sbeo#AudioDescription"></see></summary>
    let AudioDescription =
        Namespaced_IRI.parse _namespace_name "AudioDescription" |> NamespacedName

    /// <summary>
    /// A representation and detail of a person, object, or event. It is used to describe the details of anything.
    /// <see href="https://w3id.org/sbeo#Description"></see></summary>
    let Description =
        Namespaced_IRI.parse _namespace_name "Description" |> NamespacedName

    /// <summary>
    /// A person who can walk on his/her with a help of a non-motorised device, e.g. crutches.
    /// <see href="https://w3id.org/sbeo#AutonomousMobilityPerson"></see></summary>
    let AutonomousMobilityPerson =
        Namespaced_IRI.parse _namespace_name "AutonomousMobilityPerson" |> NamespacedName

    /// <summary>
    /// A person who has either partial or total loss of function of a body part, usually a limb or limbs.
    /// <see href="https://w3id.org/sbeo#MotorImpairedPerson"></see></summary>
    let MotorImpairedPerson =
        Namespaced_IRI.parse _namespace_name "MotorImpairedPerson" |> NamespacedName

    /// <summary>
    /// A type of navigation in which a person plans and executes his or her path without any human or machine intervention.
    /// <see href="https://w3id.org/sbeo#AutonomousNavigation"></see></summary>
    let AutonomousNavigation =
        Namespaced_IRI.parse _namespace_name "AutonomousNavigation" |> NamespacedName

    /// <summary>
    /// It expresses the status of something that is either available or not.
    /// <see href="https://w3id.org/sbeo#AvailabilityStatus"></see></summary>
    let AvailabilityStatus =
        Namespaced_IRI.parse _namespace_name "AvailabilityStatus" |> NamespacedName

    /// <summary>
    /// Obtainable or accessible and ready for use or service.
    /// <see href="https://w3id.org/sbeo#Available"></see></summary>
    let Available = Namespaced_IRI.parse _namespace_name "Available" |> NamespacedName

    /// <summary>
    /// Not available or accessible.
    /// <see href="https://w3id.org/sbeo#UnAvailable"></see></summary>
    let UnAvailable =
        Namespaced_IRI.parse _namespace_name "UnAvailable" |> NamespacedName

    /// <summary>
    /// A person who has lost the vision completly and can neither see naturally nor with the help of any device.
    /// <see href="https://w3id.org/sbeo#BlindPerson"></see></summary>
    let BlindPerson =
        Namespaced_IRI.parse _namespace_name "BlindPerson" |> NamespacedName

    /// <summary>
    /// It is a partial or total unability to see. It is also known as visual loss. Here, we considered a person having visual impairment who as severe low vision; 20/200 to 20/400 or higher.
    /// <see href="https://w3id.org/sbeo#VisuallyImpairedPerson"></see></summary>
    let VisuallyImpairedPerson =
        Namespaced_IRI.parse _namespace_name "VisuallyImpairedPerson" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the entrance to a building.
    /// <see href="https://w3id.org/sbeo#BuildingEntrance"></see></summary>
    let BuildingEntrance =
        Namespaced_IRI.parse _namespace_name "BuildingEntrance" |> NamespacedName

    /// <summary>
    /// Entrance represents a space or a door that is used to enter into a building. Normally, it is also used as an exit.
    /// <see href="https://w3id.org/sbeo#Entrance"></see></summary>
    let Entrance = Namespaced_IRI.parse _namespace_name "Entrance" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the exit of a building.
    /// <see href="https://w3id.org/sbeo#BuildingExit"></see></summary>
    let BuildingExit =
        Namespaced_IRI.parse _namespace_name "BuildingExit" |> NamespacedName

    /// <summary>
    /// Exit represents a logical representation for escaping or releasing from a specific phsyical space. Generally, an exit is as same as an entrance.
    /// <see href="https://w3id.org/sbeo#Exit"></see></summary>
    let Exit = Namespaced_IRI.parse _namespace_name "Exit" |> NamespacedName

    /// <summary>
    /// A hazardous event that happens due to the spillage or leakge of any toxic chemical in the building.
    /// <see href="https://w3id.org/sbeo#ChemicalSpill"></see></summary>
    let ChemicalSpill =
        Namespaced_IRI.parse _namespace_name "ChemicalSpill" |> NamespacedName

    /// <summary>
    /// An event or occurance that can be dangerous for the occupants of the building.
    /// <see href="https://w3id.org/sbeo#Incident"></see></summary>
    let Incident = Namespaced_IRI.parse _namespace_name "Incident" |> NamespacedName

    /// <summary>
    /// A building in which movies are shown.
    /// <see href="https://w3id.org/sbeo#CinemaBuilding"></see></summary>
    let CinemaBuilding =
        Namespaced_IRI.parse _namespace_name "CinemaBuilding" |> NamespacedName

    /// <summary>
    /// A room, typically in a school, in which a class of students is taught (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Classroom"></see></summary>
    let Classroom = Namespaced_IRI.parse _namespace_name "Classroom" |> NamespacedName

    /// <summary>
    /// A type of navigation in which two or more persons are involved that may or may not have same objectives.
    /// <see href="https://w3id.org/sbeo#CollaborativeNavigation"></see></summary>
    let CollaborativeNavigation =
        Namespaced_IRI.parse _namespace_name "CollaborativeNavigation" |> NamespacedName

    /// <summary>
    /// A person having the decreased ability to see color or differences in color.
    /// <see href="https://w3id.org/sbeo#ColourBlindPerson"></see></summary>
    let ColourBlindPerson =
        Namespaced_IRI.parse _namespace_name "ColourBlindPerson" |> NamespacedName

    /// <summary>
    /// An event that happens at bottlenecks when the flow of people increases than a provided limit due to herding (and similar phenomena of human behaviour), especially during an emergency evacuation process.
    /// <see href="https://w3id.org/sbeo#Congestion"></see></summary>
    let Congestion = Namespaced_IRI.parse _namespace_name "Congestion" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the entrance to a corridor.
    /// <see href="https://w3id.org/sbeo#CorridorEntrance"></see></summary>
    let CorridorEntrance =
        Namespaced_IRI.parse _namespace_name "CorridorEntrance" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the exit of a corridor.
    /// <see href="https://w3id.org/sbeo#CorridorExit"></see></summary>
    let CorridorExit =
        Namespaced_IRI.parse _namespace_name "CorridorExit" |> NamespacedName

    /// <summary>
    /// A fragment or an atomic element of a corridor.
    /// <see href="https://w3id.org/sbeo#CorridorSegment"></see></summary>
    let CorridorSegment =
        Namespaced_IRI.parse _namespace_name "CorridorSegment" |> NamespacedName

    /// <summary>
    /// A place where infants and young children are provided a supervision and care of during the daytime, particularly so that their parents can hold jobs.
    /// <see href="https://w3id.org/sbeo#DayCare"></see></summary>
    let DayCare = Namespaced_IRI.parse _namespace_name "DayCare" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/sbeo#DeviatingFromPath"></see>
    /// </summary>
    let DeviatingFromPath =
        Namespaced_IRI.parse _namespace_name "DeviatingFromPath" |> NamespacedName

    /// <summary>
    /// It models the user's deviation state from one's proposed route. For example, NoDeviate, RareDeviate, OftenDeviate, and TooOftenDeviate.
    /// <see href="https://w3id.org/sbeo#DeviationState"></see></summary>
    let DeviationState =
        Namespaced_IRI.parse _namespace_name "DeviationState" |> NamespacedName

    /// <summary>
    /// This instance is used to express when someone is not deviating at all while following one's provided path.
    /// <see href="https://w3id.org/sbeo#NoDeviate"></see></summary>
    let NoDeviate = Namespaced_IRI.parse _namespace_name "NoDeviate" |> NamespacedName

    /// <summary>
    /// This instance is used to express when someone is deviating frequently while following the provided path.
    /// <see href="https://w3id.org/sbeo#OftenDeviate"></see></summary>
    let OftenDeviate =
        Namespaced_IRI.parse _namespace_name "OftenDeviate" |> NamespacedName

    /// <summary>
    /// This instance is used to express when someone rarely deviates while following the provided path.
    /// <see href="https://w3id.org/sbeo#RareDeviate"></see></summary>
    let RareDeviate =
        Namespaced_IRI.parse _namespace_name "RareDeviate" |> NamespacedName

    /// <summary>
    /// This instance is used to express when someone is deviating frequently while following the provided path.
    /// <see href="https://w3id.org/sbeo#TooOftenDeviate"></see></summary>
    let TooOftenDeviate =
        Namespaced_IRI.parse _namespace_name "TooOftenDeviate" |> NamespacedName

    /// <summary>
    /// The status of something in terms of availability. For example, available or unavailable.
    /// <see href="https://w3id.org/sbeo#hasAvailabilityStatus"></see></summary>
    let hasAvailabilityStatus =
        Namespaced_IRI.parse _namespace_name "hasAvailabilityStatus" |> NamespacedName

    /// <summary>
    /// A display screen is an output device to represent the information in visual or tactile form.
    /// <see href="https://w3id.org/sbeo#DisplayScreen"></see></summary>
    let DisplayScreen =
        Namespaced_IRI.parse _namespace_name "DisplayScreen" |> NamespacedName

    /// <summary>
    /// A person with Down's syndrome.
    /// <see href="https://w3id.org/sbeo#DownSyndromePerson"></see></summary>
    let DownSyndromePerson =
        Namespaced_IRI.parse _namespace_name "DownSyndromePerson" |> NamespacedName

    /// <summary>
    /// A sudden violent shaking of the ground, typically causing great destruction, as a result of movements within the earth's crust or volcanic action (Oxford Dictionary of English). It may cause a sudden panic among the occupants of the building.
    /// <see href="https://w3id.org/sbeo#Earthquake"></see></summary>
    let Earthquake = Namespaced_IRI.parse _namespace_name "Earthquake" |> NamespacedName

    /// <summary>
    /// An activity that is done with an urgency and highest priority.
    /// <see href="https://w3id.org/sbeo#EmergencyActivity"></see></summary>
    let EmergencyActivity =
        Namespaced_IRI.parse _namespace_name "EmergencyActivity" |> NamespacedName

    /// <summary>
    /// It represents an immediate escape of people away from a particular area that has ongoing or imminent hazard to their lives or property.
    /// <see href="https://w3id.org/sbeo#EmergencyEvacuation"></see></summary>
    let EmergencyEvacuation =
        Namespaced_IRI.parse _namespace_name "EmergencyEvacuation" |> NamespacedName

    /// <summary>
    /// A group of two or more persons who are supposed to evacuate the building together.
    /// <see href="https://w3id.org/sbeo#EmergencyEvacuationGroup"></see></summary>
    let EmergencyEvacuationGroup =
        Namespaced_IRI.parse _namespace_name "EmergencyEvacuationGroup" |> NamespacedName

    /// <summary>
    /// It represents a collection of two or more people who interact with each other and may have the similar characteristics or objectives.
    /// <see href="https://w3id.org/sbeo#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName

    /// <summary>
    /// A type of route in which only those spaces are mentioned that are potentially safe for its users as well as the ending point of it must be an exit from a particular space.
    /// <see href="https://w3id.org/sbeo#EmergencyEvacuationRoute"></see></summary>
    let EmergencyEvacuationRoute =
        Namespaced_IRI.parse _namespace_name "EmergencyEvacuationRoute" |> NamespacedName

    /// <summary>
    /// A type of route in which the ending point represents the exit of a specific space.
    /// <see href="https://w3id.org/sbeo#ExitRoute"></see></summary>
    let ExitRoute = Namespaced_IRI.parse _namespace_name "ExitRoute" |> NamespacedName

    /// <summary>
    /// Emergency exit is logical point that is only used in case of any emergency conditions such as fire, etc.
    /// <see href="https://w3id.org/sbeo#EmergencyExit"></see></summary>
    let EmergencyExit =
        Namespaced_IRI.parse _namespace_name "EmergencyExit" |> NamespacedName

    /// <summary>
    /// A logic point that is used to indicate the end of a corridor.
    /// <see href="https://w3id.org/sbeo#EndPoint"></see></summary>
    let EndPoint = Namespaced_IRI.parse _namespace_name "EndPoint" |> NamespacedName

    /// <summary>
    /// It is a special type of point that connects more than two corridors or enforce change of direction to users or indicate the end of corridors.
    /// <see href="https://w3id.org/sbeo#NavigationalPoint"></see></summary>
    let NavigationalPoint =
        Namespaced_IRI.parse _namespace_name "NavigationalPoint" |> NamespacedName

    /// <summary>
    /// A point at which person passes from one place to the next.
    /// <see href="https://w3id.org/sbeo#TransitionPoint"></see></summary>
    let TransitionPoint =
        Namespaced_IRI.parse _namespace_name "TransitionPoint" |> NamespacedName

    /// <summary>
    /// A moving staircase consisting of an endlessly circulating belt of steps driven by a motor, which conveys people between the floors of a public building (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Escalator"></see></summary>
    let Escalator = Namespaced_IRI.parse _namespace_name "Escalator" |> NamespacedName

    /// <summary>
    /// A type of passage that connects spatial elements located on different storey or floor.
    /// <see href="https://w3id.org/sbeo#VerticalPassage"></see></summary>
    let VerticalPassage =
        Namespaced_IRI.parse _namespace_name "VerticalPassage" |> NamespacedName

    /// <summary>
    /// A physical impaired person whose wheelchair is escorted by another person.
    /// <see href="https://w3id.org/sbeo#EscortSupportedWheelchairPerson"></see></summary>
    let EscortSupportedWheelchairPerson =
        Namespaced_IRI.parse _namespace_name "EscortSupportedWheelchairPerson" |> NamespacedName

    /// <summary>
    /// A person using a wheelchair (a mobility device that is used while having any kind of tempoary or permanent physical impairment).
    /// <see href="https://w3id.org/sbeo#MobilityWithWheelchairPerson"></see></summary>
    let MobilityWithWheelchairPerson =
        Namespaced_IRI.parse _namespace_name "MobilityWithWheelchairPerson" |> NamespacedName

    /// <summary>
    /// An occurrence; something that happens (Oxford Dictionary of English). It represents when something planned or sudden happens.
    /// <see href="https://w3id.org/sbeo#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// A parameter to express the impact of an event on a specific person (or type of persons) in terms of any specific value or a type.
    /// <see href="https://w3id.org/sbeo#EventImpact"></see></summary>
    let EventImpact =
        Namespaced_IRI.parse _namespace_name "EventImpact" |> NamespacedName

    /// <summary>
    /// A property to express a sbeo:Event in a n-ary relation for sbeo:EventSeverity.
    /// <see href="https://w3id.org/sbeo#ofEvent"></see></summary>
    let ofEvent = Namespaced_IRI.parse _namespace_name "ofEvent" |> NamespacedName

    /// <summary>
    /// A parameter to express the severity of an event for a specific person (or type of persons) in terms of  potential severity levels.
    /// <see href="https://w3id.org/sbeo#EventSeverity"></see></summary>
    let EventSeverity =
        Namespaced_IRI.parse _namespace_name "EventSeverity" |> NamespacedName

    /// <summary>
    /// This instance is used to express the when someone has drained of one's energy or effectiveness.
    /// <see href="https://w3id.org/sbeo#Exhausted"></see></summary>
    let Exhausted = Namespaced_IRI.parse _namespace_name "Exhausted" |> NamespacedName
    /// <summary>
    /// A set of connected spaces represented by a starting and ending point, that ultimately leads to some specific position or place.
    /// <see href="https://w3id.org/sbeo#Route"></see></summary>
    let Route = Namespaced_IRI.parse _namespace_name "Route" |> NamespacedName
    /// <summary>
    /// A group of two or more persons having family ties between them.
    /// <see href="https://w3id.org/sbeo#Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    /// An event that may burn different parts of the building and hazourdous for both the people and the building.
    /// <see href="https://w3id.org/sbeo#Fire"></see></summary>
    let Fire = Namespaced_IRI.parse _namespace_name "Fire" |> NamespacedName
    /// <summary>
    /// A type of door used to minimize the spread of fire and related effects by isolating two connected spaces or sections in the building.
    /// <see href="https://w3id.org/sbeo#FireDoor"></see></summary>
    let FireDoor = Namespaced_IRI.parse _namespace_name "FireDoor" |> NamespacedName

    /// <summary>
    /// It is an integral component installed in the building while construction to resist the fire.
    /// <see href="https://w3id.org/sbeo#PassiveFireProtectionDevice"></see></summary>
    let PassiveFireProtectionDevice =
        Namespaced_IRI.parse _namespace_name "PassiveFireProtectionDevice" |> NamespacedName

    /// <summary>
    /// A type of ladder which is used to make an emergency exit through the window out of fire accident site.
    /// <see href="https://w3id.org/sbeo#FireEscapeLadder"></see></summary>
    let FireEscapeLadder =
        Namespaced_IRI.parse _namespace_name "FireEscapeLadder" |> NamespacedName

    /// <summary>
    /// An active fire protection instrument used by persons to blow out small scale fire.
    /// <see href="https://w3id.org/sbeo#FireExtinguisher"></see></summary>
    let FireExtinguisher =
        Namespaced_IRI.parse _namespace_name "FireExtinguisher" |> NamespacedName

    /// <summary>
    /// Device that is used to avoid and minimize the effects of potentially danger events for the occupants of the building as well as for the structure of building itself.
    /// <see href="https://w3id.org/sbeo#IncidentProtectionDevice"></see></summary>
    let IncidentProtectionDevice =
        Namespaced_IRI.parse _namespace_name "IncidentProtectionDevice" |> NamespacedName

    /// <summary>
    /// This instance is used to express when the physical and mental condition is sound of someone.
    /// <see href="https://w3id.org/sbeo#Fit"></see></summary>
    let Fit = Namespaced_IRI.parse _namespace_name "Fit" |> NamespacedName

    /// <summary>
    /// A fitness status is associated with a person that represent the quality of being suitable for a specific activity.
    /// <see href="https://w3id.org/sbeo#FitnessStatus"></see></summary>
    let FitnessStatus =
        Namespaced_IRI.parse _namespace_name "FitnessStatus" |> NamespacedName

    /// <summary>
    /// This instance is used to express when someone is not fit and has some injuries.
    /// <see href="https://w3id.org/sbeo#Injured"></see></summary>
    let Injured = Namespaced_IRI.parse _namespace_name "Injured" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the entrance to a floor.
    /// <see href="https://w3id.org/sbeo#FloorEntrance"></see></summary>
    let FloorEntrance =
        Namespaced_IRI.parse _namespace_name "FloorEntrance" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the exit of a specific floor and that leads to different floors of a building.
    /// <see href="https://w3id.org/sbeo#FloorExit"></see></summary>
    let FloorExit = Namespaced_IRI.parse _namespace_name "FloorExit" |> NamespacedName

    /// <summary>
    /// This instance is used to express when someone is following one's provided path.
    /// <see href="https://w3id.org/sbeo#FollowingPath"></see></summary>
    let FollowingPath =
        Namespaced_IRI.parse _namespace_name "FollowingPath" |> NamespacedName

    /// <summary>
    /// A path for pedestrians in a built-up area; a pavement.
    /// <see href="https://w3id.org/sbeo#Footpath"></see></summary>
    let Footpath = Namespaced_IRI.parse _namespace_name "Footpath" |> NamespacedName

    /// <summary>
    /// A type of a passage that connects spatial elements located on the same storey or floor.
    /// <see href="https://w3id.org/sbeo#HorizontalPassage"></see></summary>
    let HorizontalPassage =
        Namespaced_IRI.parse _namespace_name "HorizontalPassage" |> NamespacedName

    /// <summary>
    /// A road or path forming a route between two places (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Thoroughfare"></see></summary>
    let Thoroughfare =
        Namespaced_IRI.parse _namespace_name "Thoroughfare" |> NamespacedName

    /// <summary>
    /// A graph-based route is a graphical way of representing a route in terms of nodes (sometimes called vertices) and edges (sometimes called arcs).
    /// <see href="https://w3id.org/sbeo#GraphBasedRoute"></see></summary>
    let GraphBasedRoute =
        Namespaced_IRI.parse _namespace_name "GraphBasedRoute" |> NamespacedName

    /// <summary>
    /// A type of route having minimum cost in terms of distance or time.
    /// <see href="https://w3id.org/sbeo#ShortestPath"></see></summary>
    let ShortestPath =
        Namespaced_IRI.parse _namespace_name "ShortestPath" |> NamespacedName

    /// <summary>
    /// A type of route having minimum complexity in terms of the amount of information required to negotiate each decision point, such as turning points.
    /// <see href="https://w3id.org/sbeo#SimplestPath"></see></summary>
    let SimplestPath =
        Namespaced_IRI.parse _namespace_name "SimplestPath" |> NamespacedName

    /// <summary>
    /// Expresses one of the persons who compose a social group.
    /// <see href="https://w3id.org/sbeo#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the entrance to a hall.
    /// <see href="https://w3id.org/sbeo#HallEntrance"></see></summary>
    let HallEntrance =
        Namespaced_IRI.parse _namespace_name "HallEntrance" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the exit of a Hall.
    /// <see href="https://w3id.org/sbeo#HallExit"></see></summary>
    let HallExit = Namespaced_IRI.parse _namespace_name "HallExit" |> NamespacedName

    /// <summary>
    /// A fragment or an atomic element of a hall.
    /// <see href="https://w3id.org/sbeo#HallSegment"></see></summary>
    let HallSegment =
        Namespaced_IRI.parse _namespace_name "HallSegment" |> NamespacedName

    /// <summary>
    /// A smart device or a computer that is small enough to be used while holding it in the hands.
    /// <see href="https://w3id.org/sbeo#HandheldDevice"></see></summary>
    let HandheldDevice =
        Namespaced_IRI.parse _namespace_name "HandheldDevice" |> NamespacedName

    /// <summary>
    /// It is a partial or total unability to hear. It is also known as Hearing loss.
    /// <see href="https://w3id.org/sbeo#HearingImpairedPerson"></see></summary>
    let HearingImpairedPerson =
        Namespaced_IRI.parse _namespace_name "HearingImpairedPerson" |> NamespacedName

    /// <summary>
    /// Sensory impairment is when one of the senses such as sight, hearing, smell, touch, taste and spatial awareness, is no longer normal.
    /// <see href="https://w3id.org/sbeo#SensoryImpairedPerson"></see></summary>
    let SensoryImpairedPerson =
        Namespaced_IRI.parse _namespace_name "SensoryImpairedPerson" |> NamespacedName

    /// <summary>
    /// A slow-moving conveyor mechanism that transports people across a horizontal plane over a short to medium distance.
    /// <see href="https://w3id.org/sbeo#HorizontalMovingPavement"></see></summary>
    let HorizontalMovingPavement =
        Namespaced_IRI.parse _namespace_name "HorizontalMovingPavement" |> NamespacedName

    /// <summary>
    /// A slow-moving conveyor mechanism that transports people across a horizontal or inclined plane over a short to medium distance (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#MovingPavement"></see></summary>
    let MovingPavement =
        Namespaced_IRI.parse _namespace_name "MovingPavement" |> NamespacedName

    /// <summary>
    /// A slow-moving conveyor mechanism that transports people across an inclined plane over a short to medium distance.
    /// <see href="https://w3id.org/sbeo#VerticalMovingPavement"></see></summary>
    let VerticalMovingPavement =
        Namespaced_IRI.parse _namespace_name "VerticalMovingPavement" |> NamespacedName

    /// <summary>
    /// Any spatial element that is part of a path and traversable by persons. In addition, it may be used as a logic representation of physical passages to represent an edge (or an arc) in a route graph.
    /// <see href="https://w3id.org/sbeo#Passage"></see></summary>
    let Passage = Namespaced_IRI.parse _namespace_name "Passage" |> NamespacedName

    /// <summary>
    /// A building that contains rooms, apartments or suites where people stay for a specific time period.
    /// <see href="https://w3id.org/sbeo#HotelBuilding"></see></summary>
    let HotelBuilding =
        Namespaced_IRI.parse _namespace_name "HotelBuilding" |> NamespacedName

    /// <summary>
    /// A type of description in which images are given to provide information about any entity.
    /// <see href="https://w3id.org/sbeo#ImageDescription"></see></summary>
    let ImageDescription =
        Namespaced_IRI.parse _namespace_name "ImageDescription" |> NamespacedName

    /// <summary>
    /// An individual whose natural senses or physical abilities are either diminished or damaged.
    /// <see href="https://w3id.org/sbeo#ImpairedPerson"></see></summary>
    let ImpairedPerson =
        Namespaced_IRI.parse _namespace_name "ImpairedPerson" |> NamespacedName

    /// <summary>
    /// A logic point that connects more than two corridors.
    /// <see href="https://w3id.org/sbeo#Junction"></see></summary>
    let Junction = Namespaced_IRI.parse _namespace_name "Junction" |> NamespacedName
    /// <summary>
    /// A place where infants or young children can play which is surrounded by a boundary normally. It can be both indoor and outdoor.
    /// <see href="https://w3id.org/sbeo#KidsArea"></see></summary>
    let KidsArea = Namespaced_IRI.parse _namespace_name "KidsArea" |> NamespacedName

    /// <summary>
    /// It is the unability to sustain physical or mental activity to a normal level.
    /// <see href="https://w3id.org/sbeo#LowStaminaPerson"></see></summary>
    let LowStaminaPerson =
        Namespaced_IRI.parse _namespace_name "LowStaminaPerson" |> NamespacedName

    /// <summary>
    /// A physical impairment is a condition in which any part of person's body is either  damaged or is not working properly.
    /// <see href="https://w3id.org/sbeo#PhysicallyImpairedPerson"></see></summary>
    let PhysicallyImpairedPerson =
        Namespaced_IRI.parse _namespace_name "PhysicallyImpairedPerson" |> NamespacedName

    /// <summary>
    /// A person whose visual acuity is 20/70 or poorer in the better-seeing eye and cannot be corrected or improved with regular eyeglasses.
    /// <see href="https://w3id.org/sbeo#LowVisionPerson"></see></summary>
    let LowVisionPerson =
        Namespaced_IRI.parse _namespace_name "LowVisionPerson" |> NamespacedName

    /// <summary>
    /// A type of room designated for social gathering of people, especially professional meetings.
    /// <see href="https://w3id.org/sbeo#MeetingRoom"></see></summary>
    let MeetingRoom =
        Namespaced_IRI.parse _namespace_name "MeetingRoom" |> NamespacedName

    /// <summary>
    /// The mental ability of an indi-vidual to remain focused on an external stimuli or an internal experience for a certain period of time (World Health Organisation).
    /// <see href="https://w3id.org/sbeo#MentalAbility"></see></summary>
    let MentalAbility =
        Namespaced_IRI.parse _namespace_name "MentalAbility" |> NamespacedName

    /// <summary>
    /// A person who is only able to hear the sounds that are between 25 and 40 dB.
    /// <see href="https://w3id.org/sbeo#MildHearingImpairedPerson"></see></summary>
    let MildHearingImpairedPerson =
        Namespaced_IRI.parse _namespace_name "MildHearingImpairedPerson" |> NamespacedName

    /// <summary>
    /// A telephone with access to a cellular radio system so it can be used over a wide area, without a physical connection to a network (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#MobilePhone"></see></summary>
    let MobilePhone =
        Namespaced_IRI.parse _namespace_name "MobilePhone" |> NamespacedName

    /// <summary>
    /// A device for transmitting voices over a distance using wire or radio, by converting acoustic vibrations to electrical signals (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Telephone"></see></summary>
    let Telephone = Namespaced_IRI.parse _namespace_name "Telephone" |> NamespacedName

    /// <summary>
    /// A person who used a motorised device for moving, such as motorised wheelchair or scooter, etc.
    /// <see href="https://w3id.org/sbeo#MobilityWithAssistedDevicePerson"></see></summary>
    let MobilityWithAssistedDevicePerson =
        Namespaced_IRI.parse _namespace_name "MobilityWithAssistedDevicePerson" |> NamespacedName

    /// <summary>
    /// A person who cannot hear sounds that are less than 40-75 dB.
    /// <see href="https://w3id.org/sbeo#ModerateHearingImpairedPerson"></see></summary>
    let ModerateHearingImpairedPerson =
        Namespaced_IRI.parse _namespace_name "ModerateHearingImpairedPerson" |> NamespacedName

    /// <summary>
    /// It describes the movement of a person.
    /// <see href="https://w3id.org/sbeo#MotionState"></see></summary>
    let MotionState =
        Namespaced_IRI.parse _namespace_name "MotionState" |> NamespacedName

    /// <summary>
    /// A type of movement by turning over and over on an axis, usually performed by a person using a wheelchair,
    /// <see href="https://w3id.org/sbeo#Rolling"></see></summary>
    let Rolling = Namespaced_IRI.parse _namespace_name "Rolling" |> NamespacedName
    /// <summary>
    /// A movement of an able-bodied person at a speed faster than a walk
    /// <see href="https://w3id.org/sbeo#Running"></see></summary>
    let Running = Namespaced_IRI.parse _namespace_name "Running" |> NamespacedName
    /// <summary>
    /// A type of movement usually performed while sitting in (or riding on) an automatic or mechical device, such as electrical wheelchair, electric scooter, etc.
    /// <see href="https://w3id.org/sbeo#Scooting"></see></summary>
    let Scooting = Namespaced_IRI.parse _namespace_name "Scooting" |> NamespacedName
    /// <summary>
    /// Having or maintaining an upright position, supported by one's feet (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Standing"></see></summary>
    let Standing = Namespaced_IRI.parse _namespace_name "Standing" |> NamespacedName
    /// <summary>
    /// An unhurried rate of movement on foot (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Walking"></see></summary>
    let Walking = Namespaced_IRI.parse _namespace_name "Walking" |> NamespacedName

    /// <summary>
    /// It is a kind of wheelchair that has either a mechanical engine or an electric battery. It has more speed than a traditional wheelchair.
    /// <see href="https://w3id.org/sbeo#MotorisedWheelchairPerson"></see></summary>
    let MotorisedWheelchairPerson =
        Namespaced_IRI.parse _namespace_name "MotorisedWheelchairPerson" |> NamespacedName

    /// <summary>
    /// A type of navigation in which multiple point of interests are supposed to be visited by a person.
    /// <see href="https://w3id.org/sbeo#MultiObjectiveNavigation"></see></summary>
    let MultiObjectiveNavigation =
        Namespaced_IRI.parse _namespace_name "MultiObjectiveNavigation" |> NamespacedName

    /// <summary>
    /// The process or activity of accurately ascertaining one's position and planning and following a route (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Navigation"></see></summary>
    let Navigation = Namespaced_IRI.parse _namespace_name "Navigation" |> NamespacedName

    /// <summary>
    /// It models the user's navigational state while following the path.
    /// <see href="https://w3id.org/sbeo#NavigationalState"></see></summary>
    let NavigationalState =
        Namespaced_IRI.parse _namespace_name "NavigationalState" |> NamespacedName

    /// <summary>
    /// A traditional wheelchair that is used by hands. It has significantly lower speed than motorised wheelchairs.
    /// <see href="https://w3id.org/sbeo#NonMotorisedWheelchairPerson"></see></summary>
    let NonMotorisedWheelchairPerson =
        Namespaced_IRI.parse _namespace_name "NonMotorisedWheelchairPerson" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the entrance to an open area.
    /// <see href="https://w3id.org/sbeo#OpenAreaEntrance"></see></summary>
    let OpenAreaEntrance =
        Namespaced_IRI.parse _namespace_name "OpenAreaEntrance" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the exit from a specifc open space.
    /// <see href="https://w3id.org/sbeo#OpenAreaExit"></see></summary>
    let OpenAreaExit =
        Namespaced_IRI.parse _namespace_name "OpenAreaExit" |> NamespacedName

    /// <summary>
    /// A  sudden uncontrollable fear or anxiety among the occupants of the building that often causes wildly unthinking behaviour (Oxford Dictionary of English). In indoor environments, it may happens due to several reasons such as earthquake, fire or other sudden hazardous situations.
    /// <see href="https://w3id.org/sbeo#Panic"></see></summary>
    let Panic = Namespaced_IRI.parse _namespace_name "Panic" |> NamespacedName

    /// <summary>
    /// It represents the physical or conceptual elements of a navigation path.
    /// <see href="https://w3id.org/sbeo#RouteElement"></see></summary>
    let RouteElement =
        Namespaced_IRI.parse _namespace_name "RouteElement" |> NamespacedName

    /// <summary>
    /// A parameter to express the quality of an ability a specific person (or type of persons) own.
    /// <see href="https://w3id.org/sbeo#PersonAbility"></see></summary>
    let PersonAbility =
        Namespaced_IRI.parse _namespace_name "PersonAbility" |> NamespacedName

    /// <summary>
    /// A property to express a sbeo:Ability in a n-ary relation for sbeo:PersonAbility.
    /// <see href="https://w3id.org/sbeo#hasAbility"></see></summary>
    let hasAbility = Namespaced_IRI.parse _namespace_name "hasAbility" |> NamespacedName
    /// <summary>
    /// A property to express a quality of something in terms of different levels. For example, good, bad, medium, perfect, mild, and so forth.
    /// <see href="https://w3id.org/sbeo#hasQuality"></see></summary>
    let hasQuality = Namespaced_IRI.parse _namespace_name "hasQuality" |> NamespacedName
    /// <summary>
    /// A degree or grade of excellence or worth.
    /// <see href="https://w3id.org/sbeo#Quality"></see></summary>
    let Quality = Namespaced_IRI.parse _namespace_name "Quality" |> NamespacedName

    /// <summary>
    /// A parameter to express the accessibility of any space for a specific person (or type of persons) in terms of some value.
    /// <see href="https://w3id.org/sbeo#PersonAccessibility"></see></summary>
    let PersonAccessibility =
        Namespaced_IRI.parse _namespace_name "PersonAccessibility" |> NamespacedName

    /// <summary>
    /// A physical, three dimensional, and one of the most important elements in the design of architecture that can further be divided to create more spaces from it.
    /// <see href="https://w3id.org/sbeo#Space"></see></summary>
    let Space = Namespaced_IRI.parse _namespace_name "Space" |> NamespacedName
    /// <summary>
    /// A property to express a sbeo:Space in a n-ary relation for sbeo:Parameter.
    /// <see href="https://w3id.org/sbeo#ofSpace"></see></summary>
    let ofSpace = Namespaced_IRI.parse _namespace_name "ofSpace" |> NamespacedName
    /// <summary>
    /// Provides a value that is a direct representation of an entity.
    /// <see href="https://w3id.org/sbeo#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// Any physical or virtual location or object, which may be of interest to a user and may serve as a navigation destination (e.g., room, water dispenser, waiting zone, assembly point, shop, seat, etc).
    /// <see href="https://w3id.org/sbeo#PointOfInterest"></see></summary>
    let PointOfInterest =
        Namespaced_IRI.parse _namespace_name "PointOfInterest" |> NamespacedName

    /// <summary>
    /// A traverasal part of a space that is connected to a specific Point of Interest.
    /// <see href="https://w3id.org/sbeo#PointOfInterestSegment"></see></summary>
    let PointOfInterestSegment =
        Namespaced_IRI.parse _namespace_name "PointOfInterestSegment" |> NamespacedName

    /// <summary>
    /// A person who cannot hear sounds softer than 90-120 dB. A person suffering from profound hearing loss, using a hearing aid is also ineffective most of the time.
    /// <see href="https://w3id.org/sbeo#ProfoundHearingImpairedPerson"></see></summary>
    let ProfoundHearingImpairedPerson =
        Namespaced_IRI.parse _namespace_name "ProfoundHearingImpairedPerson" |> NamespacedName

    /// <summary>
    /// A sloping surface joining two different levels, as at the entrance or between floors of a building (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Ramp"></see></summary>
    let Ramp = Namespaced_IRI.parse _namespace_name "Ramp" |> NamespacedName
    /// <summary>
    /// A road is a way on land between two places that has been paved or otherwise improved to allow travel by foot or some form of conveyance, including a motor vehicle, cart, bicycle, or horse.
    /// <see href="https://w3id.org/sbeo#Road"></see></summary>
    let Road = Namespaced_IRI.parse _namespace_name "Road" |> NamespacedName
    /// <summary>
    /// The function assumed or part played by a person or thing in a particular situation (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    /// A concept to express that an agent is playing a role in a given context.
    /// <see href="https://w3id.org/sbeo#RoleInContext"></see></summary>
    let RoleInContext =
        Namespaced_IRI.parse _namespace_name "RoleInContext" |> NamespacedName

    /// <summary>
    /// The circumstances that form the setting for an event, statement, or idea, and in terms of which it can be fully understood and assessed (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#context"></see></summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    /// It express an agent that plays a role in a specific context.
    /// <see href="https://w3id.org/sbeo#player"></see></summary>
    let player = Namespaced_IRI.parse _namespace_name "player" |> NamespacedName
    /// <summary>
    /// Expresses a role of an agent.
    /// <see href="https://w3id.org/sbeo#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the entrance to a room.
    /// <see href="https://w3id.org/sbeo#RoomEntrance"></see></summary>
    let RoomEntrance =
        Namespaced_IRI.parse _namespace_name "RoomEntrance" |> NamespacedName

    /// <summary>
    /// A logical point that is used to represent the exit of a room.
    /// <see href="https://w3id.org/sbeo#RoomExit"></see></summary>
    let RoomExit = Namespaced_IRI.parse _namespace_name "RoomExit" |> NamespacedName

    /// <summary>
    /// A traversable part in a room that is usually used to go the exit or the other part of the room.
    /// <see href="https://w3id.org/sbeo#RoomSegment"></see></summary>
    let RoomSegment =
        Namespaced_IRI.parse _namespace_name "RoomSegment" |> NamespacedName

    /// <summary>
    /// A type of route in which the ending point represents the seat of one or more individuals such as in cinema, stadiums, auditoriums, etc.
    /// <see href="https://w3id.org/sbeo#SeatingArrangementRoute"></see></summary>
    let SeatingArrangementRoute =
        Namespaced_IRI.parse _namespace_name "SeatingArrangementRoute" |> NamespacedName

    /// <summary>
    /// This concept is used to express an event detected by any sensor.
    /// <see href="https://w3id.org/sbeo#SensorEvent"></see></summary>
    let SensorEvent =
        Namespaced_IRI.parse _namespace_name "SensorEvent" |> NamespacedName

    /// <summary>
    /// A person who is unable to hear anything without wearing a hearing aid.
    /// <see href="https://w3id.org/sbeo#SevereHearingImpairedPerson"></see></summary>
    let SevereHearingImpairedPerson =
        Namespaced_IRI.parse _namespace_name "SevereHearingImpairedPerson" |> NamespacedName

    /// <summary>
    /// A set of one or more buildings forming a complex of shops representing merchandisers, with interconnecting walkways enabling visitors to easily walk from unit to unit, along with a parking area.
    /// <see href="https://w3id.org/sbeo#ShoppingMallBuilding"></see></summary>
    let ShoppingMallBuilding =
        Namespaced_IRI.parse _namespace_name "ShoppingMallBuilding" |> NamespacedName

    /// <summary>
    /// A type of route in which the specific points of interest are mentioned in the form of connected spaces, according to the preferences or interests of a one or more individuals.
    /// <see href="https://w3id.org/sbeo#ShoppingRoute"></see></summary>
    let ShoppingRoute =
        Namespaced_IRI.parse _namespace_name "ShoppingRoute" |> NamespacedName

    /// <summary>
    /// A type of route created for visiting purposes within an indoor environment.
    /// <see href="https://w3id.org/sbeo#VisitRoute"></see></summary>
    let VisitRoute = Namespaced_IRI.parse _namespace_name "VisitRoute" |> NamespacedName
    /// <summary>
    /// A mobile phone that is able to perform many of the functions of a computer, typically having a relatively large screen and an operating system capable of running general-purpose applications (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#SmartPhone"></see></summary>
    let SmartPhone = Namespaced_IRI.parse _namespace_name "SmartPhone" |> NamespacedName

    /// <summary>
    /// A parameter to express the safety of any space for a specific person (or type of persons) in terms of some value.
    /// <see href="https://w3id.org/sbeo#SpaceSafety"></see></summary>
    let SpaceSafety =
        Namespaced_IRI.parse _namespace_name "SpaceSafety" |> NamespacedName

    /// <summary>
    /// This ability expresses the capacity to understand, reason and remember the spatial relations among objects and spaces.
    /// <see href="https://w3id.org/sbeo#SpatialAbility"></see></summary>
    let SpatialAbility =
        Namespaced_IRI.parse _namespace_name "SpatialAbility" |> NamespacedName

    /// <summary>
    /// A building that has a large open area surrounded by many rows of seats, and  used for sports events, concerts, etc.
    /// <see href="https://w3id.org/sbeo#StadiumBuilding"></see></summary>
    let StadiumBuilding =
        Namespaced_IRI.parse _namespace_name "StadiumBuilding" |> NamespacedName

    /// <summary>
    /// A sudden and uncontrollable run by the group of people caused by panic.
    /// <see href="https://w3id.org/sbeo#Stampeding"></see></summary>
    let Stampeding = Namespaced_IRI.parse _namespace_name "Stampeding" |> NamespacedName
    /// <summary>
    /// A suite of rooms usually on one floor of an apartment house (Cambridge English Dictionary). This term is normally used in hotels, resorts, guesthouses, etc.
    /// <see href="https://w3id.org/sbeo#Suite"></see></summary>
    let Suite = Namespaced_IRI.parse _namespace_name "Suite" |> NamespacedName

    /// <summary>
    /// A surprise event involving the deliberate use of violence against the occupants of the buildings.
    /// <see href="https://w3id.org/sbeo#TerroristAttack"></see></summary>
    let TerroristAttack =
        Namespaced_IRI.parse _namespace_name "TerroristAttack" |> NamespacedName

    /// <summary>
    /// A type of description in which only text or writings are used to provide the information about any entity.
    /// <see href="https://w3id.org/sbeo#TextualDescription"></see></summary>
    let TextualDescription =
        Namespaced_IRI.parse _namespace_name "TextualDescription" |> NamespacedName

    /// <summary>
    /// A logic point that is used to enforce people to change their direction.
    /// <see href="https://w3id.org/sbeo#TurnPoint"></see></summary>
    let TurnPoint = Namespaced_IRI.parse _namespace_name "TurnPoint" |> NamespacedName
    /// <summary>
    /// An activity that represents an act of going to see a person or place as a guest, tourist or a spectator. Normally, this type of activity is considered as a leasiure or recreational activity.
    /// <see href="https://w3id.org/sbeo#Visit"></see></summary>
    let Visit = Namespaced_IRI.parse _namespace_name "Visit" |> NamespacedName

    /// <summary>
    /// A group of two or more people that has the same objective of visiting any space.
    /// <see href="https://w3id.org/sbeo#VisitingGroup"></see></summary>
    let VisitingGroup =
        Namespaced_IRI.parse _namespace_name "VisitingGroup" |> NamespacedName

    /// <summary>
    /// A space (normally with seating), where people can wait to do some specific activity. During emergency condtions, it is also used for several purposes, such as unification of people with their family members, acquaintances or emergency rescue teams, etc.
    /// <see href="https://w3id.org/sbeo#WaitingZone"></see></summary>
    let WaitingZone =
        Namespaced_IRI.parse _namespace_name "WaitingZone" |> NamespacedName

    /// <summary>
    /// The accommodating capacity (in terms of persons) of a particular space.
    /// <see href="https://w3id.org/sbeo#accommodationCapacity"></see></summary>
    let accommodationCapacity =
        Namespaced_IRI.parse _namespace_name "accommodationCapacity" |> NamespacedName

    /// <summary>
    /// Be present or associated with a person.
    /// <see href="https://w3id.org/sbeo#accompanying"></see></summary>
    let accompanying =
        Namespaced_IRI.parse _namespace_name "accompanying" |> NamespacedName

    /// <summary>
    /// Any friend or an acquaintance tie among occupants.
    /// <see href="https://w3id.org/sbeo#acquaintanceOf"></see></summary>
    let acquaintanceOf =
        Namespaced_IRI.parse _namespace_name "acquaintanceOf" |> NamespacedName

    /// <summary>
    /// Nearest in space or position; immediately adjoining without intervening space or element; an exact neighbour.
    /// <see href="https://w3id.org/sbeo#adjacentTo"></see></summary>
    let adjacentTo = Namespaced_IRI.parse _namespace_name "adjacentTo" |> NamespacedName

    /// <summary>
    /// A set of connected spaces(normally in the form of rdf:list) assigned to a social unit.
    /// <see href="https://w3id.org/sbeo#assignedRoute"></see></summary>
    let assignedRoute =
        Namespaced_IRI.parse _namespace_name "assignedRoute" |> NamespacedName

    /// <summary>
    /// The time at which an activity or event occurred.
    /// <see href="https://w3id.org/sbeo#atTime"></see></summary>
    let atTime = Namespaced_IRI.parse _namespace_name "atTime" |> NamespacedName

    /// <summary>
    /// Being joined by a common element; more specificially, a physical connection between two space elements.
    /// <see href="https://w3id.org/sbeo#connectedTo"></see></summary>
    let connectedTo =
        Namespaced_IRI.parse _namespace_name "connectedTo" |> NamespacedName

    /// <summary>
    /// A numeric value associated with an edge or a complete route(path). It is also reffered to as a weight.
    /// <see href="https://w3id.org/sbeo#cost"></see></summary>
    let cost = Namespaced_IRI.parse _namespace_name "cost" |> NamespacedName

    /// <summary>
    /// The current occupancy (in terms of persons) of a particular space.
    /// <see href="https://w3id.org/sbeo#currentOccupancy"></see></summary>
    let currentOccupancy =
        Namespaced_IRI.parse _namespace_name "currentOccupancy" |> NamespacedName

    /// <summary>
    /// A dynamic or momentary information about a specific activity, event, social unit, or a space.
    /// <see href="https://w3id.org/sbeo#dynamicDescription"></see></summary>
    let dynamicDescription =
        Namespaced_IRI.parse _namespace_name "dynamicDescription" |> NamespacedName

    /// <summary>
    /// The time at which an activity ended.
    /// <see href="https://w3id.org/sbeo#endedAtTime"></see></summary>
    let endedAtTime =
        Namespaced_IRI.parse _namespace_name "endedAtTime" |> NamespacedName

    /// <summary>
    /// Start is when an activity is deemed to have been started by an entity, known as trigger.
    /// <see href="https://w3id.org/sbeo#startedAtTime"></see></summary>
    let startedAtTime =
        Namespaced_IRI.parse _namespace_name "startedAtTime" |> NamespacedName

    /// <summary>
    /// Expresses the removal of any physical space or point of interest for the consideration of any social unit.
    /// <see href="https://w3id.org/sbeo#excludedFor"></see></summary>
    let excludedFor =
        Namespaced_IRI.parse _namespace_name "excludedFor" |> NamespacedName

    /// <summary>
    /// States the familiarity of any social unit with a physical space or point of interest.
    /// <see href="https://w3id.org/sbeo#familiarWith"></see></summary>
    let familiarWith =
        Namespaced_IRI.parse _namespace_name "familiarWith" |> NamespacedName

    /// <summary>
    /// The status of an activity being performed by a social unit.
    /// <see href="https://w3id.org/sbeo#hasActivityStatus"></see></summary>
    let hasActivityStatus =
        Namespaced_IRI.parse _namespace_name "hasActivityStatus" |> NamespacedName

    /// <summary>
    /// Expresses a descriptive information about any specific space, point, activiy, event or device.
    /// <see href="https://w3id.org/sbeo#hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// A deviation status of a person depending on how ofthen one deviates from the proposed route.
    /// <see href="https://w3id.org/sbeo#hasDeviationState"></see></summary>
    let hasDeviationState =
        Namespaced_IRI.parse _namespace_name "hasDeviationState" |> NamespacedName

    /// <summary>
    /// A fitness status is associated with a person that represent the quality of being suitable for a specific activity. There are three different levels of fitness levels are introduced that can be extended according to the needs of the application. These are 'Fit', 'Exhausted' and 'Injured'.
    /// <see href="https://w3id.org/sbeo#hasFitnessStatus"></see></summary>
    let hasFitnessStatus =
        Namespaced_IRI.parse _namespace_name "hasFitnessStatus" |> NamespacedName

    /// <summary>
    /// The motion state of a person.
    /// <see href="https://w3id.org/sbeo#hasMotionState"></see></summary>
    let hasMotionState =
        Namespaced_IRI.parse _namespace_name "hasMotionState" |> NamespacedName

    /// <summary>
    /// A navigational state of a social unit while following any path.
    /// <see href="https://w3id.org/sbeo#hasNavigationalState"></see></summary>
    let hasNavigationalState =
        Namespaced_IRI.parse _namespace_name "hasNavigationalState" |> NamespacedName

    /// <summary>
    /// A type of navigation provided to a person to perform a specific activity.
    /// <see href="https://w3id.org/sbeo#hasNavigationalType"></see></summary>
    let hasNavigationalType =
        Namespaced_IRI.parse _namespace_name "hasNavigationalType" |> NamespacedName

    /// <summary>
    /// Number of times a social unit is deviated while following the provided path.
    /// <see href="https://w3id.org/sbeo#hasXTimesDeviated"></see></summary>
    let hasXTimesDeviated =
        Namespaced_IRI.parse _namespace_name "hasXTimesDeviated" |> NamespacedName

    /// <summary>
    /// An unique identification number of something such as, social unit, device, etc.
    /// <see href="https://w3id.org/sbeo#id"></see></summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    /// Place or fix (equipment or machinery) in position ready for use (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#installedIn"></see></summary>
    let installedIn =
        Namespaced_IRI.parse _namespace_name "installedIn" |> NamespacedName

    /// <summary>
    /// Be a means of access to a particular space or point.
    /// <see href="https://w3id.org/sbeo#leadsTo"></see></summary>
    let leadsTo = Namespaced_IRI.parse _namespace_name "leadsTo" |> NamespacedName
    /// <summary>
    /// States the location of any social unit, activity, event, physical space, or a point of interest at any other physical space.
    /// <see href="https://w3id.org/sbeo#locatedIn"></see></summary>
    let locatedIn = Namespaced_IRI.parse _namespace_name "locatedIn" |> NamespacedName
    /// <summary>
    /// Associates the lower storey in a building.
    /// <see href="https://w3id.org/sbeo#lower"></see></summary>
    let lower = Namespaced_IRI.parse _namespace_name "lower" |> NamespacedName
    /// <summary>
    /// Associates the upper storey in a building.
    /// <see href="https://w3id.org/sbeo#upper"></see></summary>
    let upper = Namespaced_IRI.parse _namespace_name "upper" |> NamespacedName

    /// <summary>
    /// A method of notifying a social unit.
    /// <see href="https://w3id.org/sbeo#meansOfNotification"></see></summary>
    let meansOfNotification =
        Namespaced_IRI.parse _namespace_name "meansOfNotification" |> NamespacedName

    /// <summary>
    /// A notification preference for any kind of social unit.
    /// <see href="https://w3id.org/sbeo#notificationPreference"></see></summary>
    let notificationPreference =
        Namespaced_IRI.parse _namespace_name "notificationPreference" |> NamespacedName

    /// <summary>
    /// A number assigned to anything.
    /// <see href="https://w3id.org/sbeo#number"></see></summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName
    /// <summary>
    /// Expresses a physical space as a part or a fragment of another physical space. For example, a block of apartments can be a part of apartment building, etc.
    /// <see href="https://w3id.org/sbeo#partOf"></see></summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// Expresses an activity carried out by a social unit.
    /// <see href="https://w3id.org/sbeo#performedBy"></see></summary>
    let performedBy =
        Namespaced_IRI.parse _namespace_name "performedBy" |> NamespacedName

    /// <summary>
    /// Having an obligation to do something, or having control over or care for someone, as part of one's role (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#responsibleTo"></see></summary>
    let responsibleTo =
        Namespaced_IRI.parse _namespace_name "responsibleTo" |> NamespacedName

    /// <summary>
    /// Route preference of a social unit to perform an activity.
    /// <see href="https://w3id.org/sbeo#routePreference"></see></summary>
    let routePreference =
        Namespaced_IRI.parse _namespace_name "routePreference" |> NamespacedName

    /// <summary>
    /// This property is used to express the type of a route in terms of graph-based routes, such as Shortest Path, Simplest Path etc.
    /// <see href="https://w3id.org/sbeo#routeType"></see></summary>
    let routeType = Namespaced_IRI.parse _namespace_name "routeType" |> NamespacedName
    /// <summary>
    /// The average speed of a person.
    /// <see href="https://w3id.org/sbeo#speed"></see></summary>
    let speed = Namespaced_IRI.parse _namespace_name "speed" |> NamespacedName

    /// <summary>
    /// A multiplying factor that may affect the speed of person while passing through a specific space.
    /// <see href="https://w3id.org/sbeo#speedFactor"></see></summary>
    let speedFactor =
        Namespaced_IRI.parse _namespace_name "speedFactor" |> NamespacedName

    /// <summary>
    /// A static or a fix information about any activity, event, space, social unit, or point of interest.
    /// <see href="https://w3id.org/sbeo#staticDescription"></see></summary>
    let staticDescription =
        Namespaced_IRI.parse _namespace_name "staticDescription" |> NamespacedName

    /// <summary>
    /// The length of time during which any activity or event lasts.
    /// <see href="https://w3id.org/sbeo#timeDuration"></see></summary>
    let timeDuration =
        Namespaced_IRI.parse _namespace_name "timeDuration" |> NamespacedName

    /// <summary>
    /// A specific period of time required to move from one place to another.
    /// <see href="https://w3id.org/sbeo#travelTime"></see></summary>
    let travelTime = Namespaced_IRI.parse _namespace_name "travelTime" |> NamespacedName
    /// <summary>
    /// Expresses a momentary information about a physical space or a point being used by a social unit.
    /// <see href="https://w3id.org/sbeo#uses"></see></summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName
    /// <summary>
    /// The measurement or extent of something from side to side (Oxford Dictionary of English).
    /// <see href="https://w3id.org/sbeo#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
