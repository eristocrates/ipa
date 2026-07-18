namespace http.bimerr.iot.linkeddata.es.def.occupancy_profile.hash

open DoxAletheia.Rdf_Vocabulary

module bimerr_op =
    let _namespace_name = "http://bimerr.iot.linkeddata.es/def/occupancy-profile#"

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ASHRAEAdaptiveComfort"></see>
    /// </summary>
    let ASHRAEAdaptiveComfort =
        Namespaced_IRI.parse _namespace_name "ASHRAEAdaptiveComfort" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ASHRAEComfortEnvelop"></see>
    /// </summary>
    let ASHRAEComfortEnvelop =
        Namespaced_IRI.parse _namespace_name "ASHRAEComfortEnvelop" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ISOAdaptiveComfort"></see>
    /// </summary>
    let ISOAdaptiveComfort =
        Namespaced_IRI.parse _namespace_name "ISOAdaptiveComfort" |> NamespacedName

    /// <summary>
    /// Range of parameter values where occupants do not feel accoustic discomfort and therefore, they don't carry out any actions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#AccousticNeed"></see></summary>
    let AccousticNeed =
        Namespaced_IRI.parse _namespace_name "AccousticNeed" |> NamespacedName

    /// <summary>
    /// Range of parameter values where occupants do not feel indoor air quality discomfort and therefore, they don't carry out any actions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#IAQNeed"></see></summary>
    let IAQNeed = Namespaced_IRI.parse _namespace_name "IAQNeed" |> NamespacedName

    /// <summary>
    /// Range of parameter values where occupants do not feel thermal discomfort and therefore, they don't carry out any actions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ThermalNeed"></see></summary>
    let ThermalNeed =
        Namespaced_IRI.parse _namespace_name "ThermalNeed" |> NamespacedName

    /// <summary>
    /// Range of parameter values where occupants do not feel visual discomfort and therefore, they don't carry out any actions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#VisualNeed"></see></summary>
    let VisualNeed = Namespaced_IRI.parse _namespace_name "VisualNeed" |> NamespacedName

    /// <summary>
    /// Class to represent constant value mathematical formulas
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ConstantValueFormula"></see></summary>
    let ConstantValueFormula =
        Namespaced_IRI.parse _namespace_name "ConstantValueFormula" |> NamespacedName

    /// <summary>
    /// Class to represent linear mathematical formulas
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LinearFormula"></see></summary>
    let LinearFormula =
        Namespaced_IRI.parse _namespace_name "LinearFormula" |> NamespacedName

    /// <summary>
    /// Class to represent logit mathematical formulas.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LogitFormula"></see></summary>
    let LogitFormula =
        Namespaced_IRI.parse _namespace_name "LogitFormula" |> NamespacedName

    /// <summary>
    /// Class to represent quadratic mathematical formulas.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#QuadraticFormula"></see></summary>
    let QuadraticFormula =
        Namespaced_IRI.parse _namespace_name "QuadraticFormula" |> NamespacedName

    /// <summary>
    /// Class to represent weibull mathematical formulas.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#WeibullFormula"></see></summary>
    let WeibullFormula =
        Namespaced_IRI.parse _namespace_name "WeibullFormula" |> NamespacedName

    /// <summary>
    /// Identifier of an element given in the obXML file. Attribute considered for backward compatibility.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// A relationship indicating the address of a building
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#buildingAddress"></see></summary>
    let buildingAddress =
        Namespaced_IRI.parse _namespace_name "buildingAddress" |> NamespacedName

    /// <summary>
    /// Relationship that indicates the minimum number of occupants inside a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minNumberOccupants"></see></summary>
    let minNumberOccupants =
        Namespaced_IRI.parse _namespace_name "minNumberOccupants" |> NamespacedName

    /// <summary>
    /// Relationship that indicates the maximum number of occupants inside a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxNumberOccupants"></see></summary>
    let maxNumberOccupants =
        Namespaced_IRI.parse _namespace_name "maxNumberOccupants" |> NamespacedName

    /// <summary>
    /// Occupants or residents of a building.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Occupant"></see></summary>
    let Occupant = Namespaced_IRI.parse _namespace_name "Occupant" |> NamespacedName

    /// <summary>
    /// Relationship that indicates that an space can have an occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOccupant"></see></summary>
    let hasOccupant =
        Namespaced_IRI.parse _namespace_name "hasOccupant" |> NamespacedName

    /// <summary>
    /// Class to represent a meeting inside a communal space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Meeting"></see></summary>
    let Meeting = Namespaced_IRI.parse _namespace_name "Meeting" |> NamespacedName
    /// <summary>
    /// Indicates that a meeting can occur within a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasMeeting"></see></summary>
    let hasMeeting = Namespaced_IRI.parse _namespace_name "hasMeeting" |> NamespacedName

    /// <summary>
    /// Physical comfort need that could influence a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#PhysicalNeed"></see></summary>
    let PhysicalNeed =
        Namespaced_IRI.parse _namespace_name "PhysicalNeed" |> NamespacedName

    /// <summary>
    /// Actions are the interactions with systems or activities that an occupant can conduct to achieve environmental comfort. Actions connect occupants' inside-world needs with the environmental outside world. (Defintion taken from obXML)
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Adjustable"></see>
    /// </summary>
    let Adjustable = Namespaced_IRI.parse _namespace_name "Adjustable" |> NamespacedName

    /// <summary>
    /// Types of operational modes for space systems.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConcept"></see></summary>
    let OperationalModeConcept =
        Namespaced_IRI.parse _namespace_name "OperationalModeConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Afternoon"></see>
    /// </summary>
    let Afternoon = Namespaced_IRI.parse _namespace_name "Afternoon" |> NamespacedName
    /// <summary>
    /// Relative time of day.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TimeOfDay"></see></summary>
    let TimeOfDay = Namespaced_IRI.parse _namespace_name "TimeOfDay" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Arrival"></see>
    /// </summary>
    let Arrival = Namespaced_IRI.parse _namespace_name "Arrival" |> NamespacedName

    /// <summary>
    /// One time event involving occupancy status transition in building level.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionTypeConcept"></see></summary>
    let StatusTransitionTypeConcept =
        Namespaced_IRI.parse _namespace_name "StatusTransitionTypeConcept" |> NamespacedName

    /// <summary>
    /// Behavior related to the interaction with buildings
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Behavior"></see></summary>
    let Behavior = Namespaced_IRI.parse _namespace_name "Behavior" |> NamespacedName
    /// <summary>
    /// Needs represent the physical and non-physical requirements of the occupant's inside world that must be met in order to ensure the satisfaction of the occupant with their environment.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Need"></see></summary>
    let Need = Namespaced_IRI.parse _namespace_name "Need" |> NamespacedName

    /// <summary>
    /// Indicates that a driver can be influenced by an occupant comfort need.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#influencedByNeed"></see></summary>
    let influencedByNeed =
        Namespaced_IRI.parse _namespace_name "influencedByNeed" |> NamespacedName

    /// <summary>
    /// The Inaction class represents the decision of an occupant to not act and remain uncomfortable within a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Inaction"></see></summary>
    let Inaction = Namespaced_IRI.parse _namespace_name "Inaction" |> NamespacedName
    /// <summary>
    /// Relationship to indicate the outcome of a behavior. It could lead to an action over a building system to recover comfort or to a passive acceptance of the environmental conditions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#leadsTo"></see></summary>
    let leadsTo = Namespaced_IRI.parse _namespace_name "leadsTo" |> NamespacedName
    /// <summary>
    /// Set of drivers that could be causing a behavior at a specific time.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#DriverSet"></see></summary>
    let DriverSet = Namespaced_IRI.parse _namespace_name "DriverSet" |> NamespacedName
    /// <summary>
    /// Property to link an occupant with a set of internal or external drivers that are controlling its interactions with building systems.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#drivenBy"></see></summary>
    let drivenBy = Namespaced_IRI.parse _namespace_name "drivenBy" |> NamespacedName

    /// <summary>
    /// Class to represent the value and name of coefficients inside mathematical formulas.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Coefficient"></see></summary>
    let Coefficient =
        Namespaced_IRI.parse _namespace_name "Coefficient" |> NamespacedName

    /// <summary>
    /// A relationship indicating the value of a coefficient.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#coefficientValue"></see></summary>
    let coefficientValue =
        Namespaced_IRI.parse _namespace_name "coefficientValue" |> NamespacedName

    /// <summary>
    /// Formula to model the probability of interaction between ocupant and system.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionFormula"></see></summary>
    let InteractionFormula =
        Namespaced_IRI.parse _namespace_name "InteractionFormula" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ContinuousControl"></see>
    /// </summary>
    let ContinuousControl =
        Namespaced_IRI.parse _namespace_name "ContinuousControl" |> NamespacedName

    /// <summary>
    /// Class to represent instances of custom probabilistic models.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#CustomProbabilityModel"></see></summary>
    let CustomProbabilityModel =
        Namespaced_IRI.parse _namespace_name "CustomProbabilityModel" |> NamespacedName

    /// <summary>
    /// Relationship that links a probility to an event. For example the occurance probability of a meeting.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#probability"></see></summary>
    let probability =
        Namespaced_IRI.parse _namespace_name "probability" |> NamespacedName

    /// <summary>
    /// Probabilistic model to define occupant movements inside and between spaces.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#MovementModel"></see></summary>
    let MovementModel =
        Namespaced_IRI.parse _namespace_name "MovementModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Day"></see>
    /// </summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#DayLight"></see>
    /// </summary>
    let DayLight = Namespaced_IRI.parse _namespace_name "DayLight" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Departure"></see>
    /// </summary>
    let Departure = Namespaced_IRI.parse _namespace_name "Departure" |> NamespacedName
    /// <summary>
    /// A Driver represents the environmental factor from the outside world that stimulate occupants in their inside world to fulfill a physical, physiological or psychological need.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Driver"></see></summary>
    let Driver = Namespaced_IRI.parse _namespace_name "Driver" |> NamespacedName
    /// <summary>
    /// Relationship that indicates the composition of a set of drivers.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#composedOf"></see></summary>
    let composedOf = Namespaced_IRI.parse _namespace_name "composedOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnteringRoom"></see>
    /// </summary>
    let EnteringRoom =
        Namespaced_IRI.parse _namespace_name "EnteringRoom" |> NamespacedName

    /// <summary>
    /// Driver related to events that could be causing a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// Driver related to the environmental conditions that could be causing a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Environment"></see></summary>
    let Environment =
        Namespaced_IRI.parse _namespace_name "Environment" |> NamespacedName

    /// <summary>
    /// Class that represent a physical variable of the environment where the driver occurs. It could represent variables that impact directly on the comfort levels of the occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnvironmentalParameter"></see></summary>
    let EnvironmentalParameter =
        Namespaced_IRI.parse _namespace_name "EnvironmentalParameter" |> NamespacedName

    /// <summary>
    /// Relates and occupant environmental driver with an environmental property like temperature or illuminance.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasEnvironmentalParameter"></see></summary>
    let hasEnvironmentalParameter =
        Namespaced_IRI.parse _namespace_name "hasEnvironmentalParameter" |> NamespacedName

    /// <summary>
    /// Relates an environmental parameter with a unit of measure.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasUnitOfMeasure"></see></summary>
    let hasUnitOfMeasure =
        Namespaced_IRI.parse _namespace_name "hasUnitOfMeasure" |> NamespacedName

    /// <summary>
    /// Class to represent electrical equipments occupants interact with but do not have influence over indoor thermal conditions. These systems contribute to the energy bugdet estimation.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Equipment"></see></summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Evening"></see>
    /// </summary>
    let Evening = Namespaced_IRI.parse _namespace_name "Evening" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Fall"></see>
    /// </summary>
    let Fall = Namespaced_IRI.parse _namespace_name "Fall" |> NamespacedName
    /// <summary>
    /// Season of the year.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Season"></see></summary>
    let Season = Namespaced_IRI.parse _namespace_name "Season" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Fixed"></see>
    /// </summary>
    let Fixed = Namespaced_IRI.parse _namespace_name "Fixed" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Glare"></see>
    /// </summary>
    let Glare = Namespaced_IRI.parse _namespace_name "Glare" |> NamespacedName
    /// <summary>
    /// Driver related to habits that could be causing a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Habit"></see></summary>
    let Habit = Namespaced_IRI.parse _namespace_name "Habit" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Illuminance"></see>
    /// </summary>
    let Illuminance =
        Namespaced_IRI.parse _namespace_name "Illuminance" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#IndoorAirQuality"></see>
    /// </summary>
    let IndoorAirQuality =
        Namespaced_IRI.parse _namespace_name "IndoorAirQuality" |> NamespacedName

    /// <summary>
    /// The Interaction class represent the interactions of occupants with systems within a space to recover their comfort.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Interaction"></see></summary>
    let Interaction =
        Namespaced_IRI.parse _namespace_name "Interaction" |> NamespacedName

    /// <summary>
    /// A relationship indicating the magnitud of a control action over a building system.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#controlValue"></see></summary>
    let controlValue =
        Namespaced_IRI.parse _namespace_name "controlValue" |> NamespacedName

    /// <summary>
    /// Relationship that describes an interaction between an occupant and a building component or system.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#interactsOver"></see></summary>
    let interactsOver =
        Namespaced_IRI.parse _namespace_name "interactsOver" |> NamespacedName

    /// <summary>
    /// Property to relate an interaction with a formula describing the probability of occurance.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#describedByFormula"></see></summary>
    let describedByFormula =
        Namespaced_IRI.parse _namespace_name "describedByFormula" |> NamespacedName

    /// <summary>
    /// Types of interactions between occupants and systems.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionConcept"></see></summary>
    let InteractionConcept =
        Namespaced_IRI.parse _namespace_name "InteractionConcept" |> NamespacedName

    /// <summary>
    /// Relates a formula with an independent variable.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasIndependentVariable"></see></summary>
    let hasIndependentVariable =
        Namespaced_IRI.parse _namespace_name "hasIndependentVariable" |> NamespacedName

    /// <summary>
    /// Relates a formula with a coefficient.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasCoefficient"></see></summary>
    let hasCoefficient =
        Namespaced_IRI.parse _namespace_name "hasCoefficient" |> NamespacedName

    /// <summary>
    /// An aggregation of SKOS concepts regarding the interaction type between occupants and space systems
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionScheme"></see></summary>
    let InteractionScheme =
        Namespaced_IRI.parse _namespace_name "InteractionScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LeavingRoom"></see>
    /// </summary>
    let LeavingRoom =
        Namespaced_IRI.parse _namespace_name "LeavingRoom" |> NamespacedName

    /// <summary>
    /// A devide used for illumination.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LightingDevice"></see></summary>
    let LightingDevice =
        Namespaced_IRI.parse _namespace_name "LightingDevice" |> NamespacedName

    /// <summary>
    /// Class to represent instances of Markov chain models.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#MarkovChainModel"></see></summary>
    let MarkovChainModel =
        Namespaced_IRI.parse _namespace_name "MarkovChainModel" |> NamespacedName

    /// <summary>
    /// Typical occurrence time of an event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalTime"></see></summary>
    let typicalTime =
        Namespaced_IRI.parse _namespace_name "typicalTime" |> NamespacedName

    /// <summary>
    /// Earliest occurrence time of an event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#earlyOccurTime"></see></summary>
    let earlyOccurTime =
        Namespaced_IRI.parse _namespace_name "earlyOccurTime" |> NamespacedName

    /// <summary>
    /// The start time of an event or activity.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName
    /// <summary>
    /// The end time of an event or activity.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName
    /// <summary>
    /// Average duration of an event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Morning"></see>
    /// </summary>
    let Morning = Namespaced_IRI.parse _namespace_name "Morning" |> NamespacedName
    /// <summary>
    /// The Movement class is used to represent the occupant's movements inside or between spaces.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Movement"></see></summary>
    let Movement = Namespaced_IRI.parse _namespace_name "Movement" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Night"></see>
    /// </summary>
    let Night = Namespaced_IRI.parse _namespace_name "Night" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Noise"></see>
    /// </summary>
    let Noise = Namespaced_IRI.parse _namespace_name "Noise" |> NamespacedName

    /// <summary>
    /// Non physical comfort needs (e.g. privacy, status, etc) that could influence a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#NonPhysicalNeed"></see></summary>
    let NonPhysicalNeed =
        Namespaced_IRI.parse _namespace_name "NonPhysicalNeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Noon"></see>
    /// </summary>
    let Noon = Namespaced_IRI.parse _namespace_name "Noon" |> NamespacedName

    /// <summary>
    /// Class to represent instances of Normal probabilistic models.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#NormalProbabilityModel"></see></summary>
    let NormalProbabilityModel =
        Namespaced_IRI.parse _namespace_name "NormalProbabilityModel" |> NamespacedName

    /// <summary>
    /// Gender of an occupant
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantGender"></see></summary>
    let occupantGender =
        Namespaced_IRI.parse _namespace_name "occupantGender" |> NamespacedName

    /// <summary>
    /// Age of an occupant
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantAge"></see></summary>
    let occupantAge =
        Namespaced_IRI.parse _namespace_name "occupantAge" |> NamespacedName

    /// <summary>
    /// Jobtype of an occupant
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantJobtype"></see></summary>
    let occupantJobtype =
        Namespaced_IRI.parse _namespace_name "occupantJobtype" |> NamespacedName

    /// <summary>
    /// Lifestyle of an occupant
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantLifestyle"></see></summary>
    let occupantLifestyle =
        Namespaced_IRI.parse _namespace_name "occupantLifestyle" |> NamespacedName

    /// <summary>
    /// Property to indicate that an occupant has a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasBehavior"></see></summary>
    let hasBehavior =
        Namespaced_IRI.parse _namespace_name "hasBehavior" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OnOff"></see>
    /// </summary>
    let OnOff = Namespaced_IRI.parse _namespace_name "OnOff" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Operable"></see>
    /// </summary>
    let Operable = Namespaced_IRI.parse _namespace_name "Operable" |> NamespacedName

    /// <summary>
    /// An aggregation of SKOS concepts regarding the operational mode of space systems.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConceptScheme"></see></summary>
    let OperationalModeConceptScheme =
        Namespaced_IRI.parse _namespace_name "OperationalModeConceptScheme" |> NamespacedName

    /// <summary>
    /// Class to represent the minimum and maximm comfort values with respect to an environmental parameter.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ParameterRange"></see></summary>
    let ParameterRange =
        Namespaced_IRI.parse _namespace_name "ParameterRange" |> NamespacedName

    /// <summary>
    /// Lower boundary of a parameter range description.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minRangeValue"></see></summary>
    let minRangeValue =
        Namespaced_IRI.parse _namespace_name "minRangeValue" |> NamespacedName

    /// <summary>
    /// Upper boundary of a parameter range description.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxRangeValue"></see></summary>
    let maxRangeValue =
        Namespaced_IRI.parse _namespace_name "maxRangeValue" |> NamespacedName

    /// <summary>
    /// Relates a comfort envelop with an environmental parameter.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#describesParameter"></see></summary>
    let describesParameter =
        Namespaced_IRI.parse _namespace_name "describesParameter" |> NamespacedName

    /// <summary>
    /// Property used to describe occupant needs by defining comfort limits w.r.t. an environmental parameter.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#definedByRange"></see></summary>
    let definedByRange =
        Namespaced_IRI.parse _namespace_name "definedByRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Rain"></see>
    /// </summary>
    let Rain = Namespaced_IRI.parse _namespace_name "Rain" |> NamespacedName

    /// <summary>
    /// Type of occupant movements inside a building or space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#RandomMovement"></see></summary>
    let RandomMovement =
        Namespaced_IRI.parse _namespace_name "RandomMovement" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#RelativeHumidity"></see>
    /// </summary>
    let RelativeHumidity =
        Namespaced_IRI.parse _namespace_name "RelativeHumidity" |> NamespacedName

    /// <summary>
    /// The Report class indicates that an occupant seeks assistance or files a complaint about their personal discomfort, but does not take direct action to satisfy their needs.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName

    /// <summary>
    /// Relationship that indicates the month when a season start.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#startSeason"></see></summary>
    let startSeason =
        Namespaced_IRI.parse _namespace_name "startSeason" |> NamespacedName

    /// <summary>
    /// Relationship that indicates the month when a season ends.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#endSeason"></see></summary>
    let endSeason = Namespaced_IRI.parse _namespace_name "endSeason" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SetToControlValue"></see>
    /// </summary>
    let SetToControlValue =
        Namespaced_IRI.parse _namespace_name "SetToControlValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ShortTermLeaving"></see>
    /// </summary>
    let ShortTermLeaving =
        Namespaced_IRI.parse _namespace_name "ShortTermLeaving" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ShortTermVisiting"></see>
    /// </summary>
    let ShortTermVisiting =
        Namespaced_IRI.parse _namespace_name "ShortTermVisiting" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SolarIrradiance"></see>
    /// </summary>
    let SolarIrradiance =
        Namespaced_IRI.parse _namespace_name "SolarIrradiance" |> NamespacedName

    /// <summary>
    /// Occupancy percentage of staying in a specific space category in a building.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SpaceOccupancy"></see></summary>
    let SpaceOccupancy =
        Namespaced_IRI.parse _namespace_name "SpaceOccupancy" |> NamespacedName

    /// <summary>
    /// Percentage of occupancy time in a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#percentTimePresence"></see></summary>
    let percentTimePresence =
        Namespaced_IRI.parse _namespace_name "percentTimePresence" |> NamespacedName

    /// <summary>
    /// Property that relates space occupancy events to an specific building space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#relatedToSpace"></see></summary>
    let relatedToSpace =
        Namespaced_IRI.parse _namespace_name "relatedToSpace" |> NamespacedName

    /// <summary>
    /// Driver related to spatial conditions that could be causing a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spatial"></see></summary>
    let Spatial = Namespaced_IRI.parse _namespace_name "Spatial" |> NamespacedName
    /// <summary>
    /// Relates a spatial driver to an specific building space
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#detailedBy"></see></summary>
    let detailedBy = Namespaced_IRI.parse _namespace_name "detailedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spring"></see>
    /// </summary>
    let Spring = Namespaced_IRI.parse _namespace_name "Spring" |> NamespacedName

    /// <summary>
    /// Type of movements to represent transition events between spaces.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransition"></see></summary>
    let StatusTransition =
        Namespaced_IRI.parse _namespace_name "StatusTransition" |> NamespacedName

    /// <summary>
    /// The typical duration of an event or activity.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalDuration"></see></summary>
    let typicalDuration =
        Namespaced_IRI.parse _namespace_name "typicalDuration" |> NamespacedName

    /// <summary>
    /// The minimal duration of an event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minimalDuration"></see></summary>
    let minimalDuration =
        Namespaced_IRI.parse _namespace_name "minimalDuration" |> NamespacedName

    /// <summary>
    /// Relates a transition event to a movement model that describe this action.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#specifiedBy"></see></summary>
    let specifiedBy =
        Namespaced_IRI.parse _namespace_name "specifiedBy" |> NamespacedName

    /// <summary>
    /// Relationship that indicates the type of status transition event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTransitionType"></see></summary>
    let hasTransitionType =
        Namespaced_IRI.parse _namespace_name "hasTransitionType" |> NamespacedName

    /// <summary>
    /// An aggregation of SKOS concepts regarding the status transition type of movements between spaces.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionScheme"></see></summary>
    let StatusTransitionScheme =
        Namespaced_IRI.parse _namespace_name "StatusTransitionScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StayingInRoom"></see>
    /// </summary>
    let StayingInRoom =
        Namespaced_IRI.parse _namespace_name "StayingInRoom" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Summer"></see>
    /// </summary>
    let Summer = Namespaced_IRI.parse _namespace_name "Summer" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Temperature"></see>
    /// </summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    /// A thermostat is a component which senses the temperature of a physical space and performs actions so that the space temperature is maintained near a desired setpoint. (Definition adapted from Wikipedia)
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Thermostat"></see></summary>
    let Thermostat = Namespaced_IRI.parse _namespace_name "Thermostat" |> NamespacedName
    /// <summary>
    /// Driver related to time conditions that could be causing a behavior. It also describes the time when another type of driver occur.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Time"></see></summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    /// Indicates which days that act as time drivers are holidays.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#onHolidays"></see></summary>
    let onHolidays = Namespaced_IRI.parse _namespace_name "onHolidays" |> NamespacedName

    /// <summary>
    /// Indicates which times during a day are behavioral drivers for an occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTimeOfDay"></see></summary>
    let hasTimeOfDay =
        Namespaced_IRI.parse _namespace_name "hasTimeOfDay" |> NamespacedName

    /// <summary>
    /// Indicates which seasons are behavioral drivers for an occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasSeason"></see></summary>
    let hasSeason = Namespaced_IRI.parse _namespace_name "hasSeason" |> NamespacedName

    /// <summary>
    /// Indicates which days of the week are behavioral drivers for an occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasDayOfWeek"></see></summary>
    let hasDayOfWeek =
        Namespaced_IRI.parse _namespace_name "hasDayOfWeek" |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TurnOff"></see>
    /// </summary>
    let TurnOff = Namespaced_IRI.parse _namespace_name "TurnOff" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TurnOn"></see>
    /// </summary>
    let TurnOn = Namespaced_IRI.parse _namespace_name "TurnOn" |> NamespacedName
    /// <summary>
    /// A window is an opening in a wall, door, roof or vehicle that allows the passage of light, sound, and sometimes air. (Definition taken from Wikipedia)
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Window"></see></summary>
    let Window = Namespaced_IRI.parse _namespace_name "Window" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Winter"></see>
    /// </summary>
    let Winter = Namespaced_IRI.parse _namespace_name "Winter" |> NamespacedName
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ZoneOnOff"></see>
    /// </summary>
    let ZoneOnOff = Namespaced_IRI.parse _namespace_name "ZoneOnOff" |> NamespacedName

    /// <summary>
    /// Relationship to indicate the type of control mode of a system, such as fixed or operable modes for a window.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOperationalMode"></see></summary>
    let hasOperationalMode =
        Namespaced_IRI.parse _namespace_name "hasOperationalMode" |> NamespacedName
