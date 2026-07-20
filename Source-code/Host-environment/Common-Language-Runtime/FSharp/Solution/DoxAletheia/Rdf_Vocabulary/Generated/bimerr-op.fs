namespace http.bimerr.iot.linkeddata.es.def.occupancy_profile.hash

open DoxAletheia

module bimerr_op =
    let _namespace_name = "http://bimerr.iot.linkeddata.es/def/occupancy-profile#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ASHRAEAdaptiveComfort"></see>
    /// </summary>
    let ASHRAEAdaptiveComfort = _prefix "ASHRAEAdaptiveComfort"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ASHRAEComfortEnvelop"></see>
    /// </summary>
    let ASHRAEComfortEnvelop = _prefix "ASHRAEComfortEnvelop"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ISOAdaptiveComfort"></see>
    /// </summary>
    let ISOAdaptiveComfort = _prefix "ISOAdaptiveComfort"
    /// <summary>
    /// Range of parameter values where occupants do not feel accoustic discomfort and therefore, they don't carry out any actions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#AccousticNeed"></see></summary>
    let AccousticNeed = _prefix "AccousticNeed"
    /// <summary>
    /// Range of parameter values where occupants do not feel indoor air quality discomfort and therefore, they don't carry out any actions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#IAQNeed"></see></summary>
    let IAQNeed = _prefix "IAQNeed"
    /// <summary>
    /// Range of parameter values where occupants do not feel thermal discomfort and therefore, they don't carry out any actions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ThermalNeed"></see></summary>
    let ThermalNeed = _prefix "ThermalNeed"
    /// <summary>
    /// Range of parameter values where occupants do not feel visual discomfort and therefore, they don't carry out any actions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#VisualNeed"></see></summary>
    let VisualNeed = _prefix "VisualNeed"
    /// <summary>
    /// Class to represent constant value mathematical formulas
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ConstantValueFormula"></see></summary>
    let ConstantValueFormula = _prefix "ConstantValueFormula"
    /// <summary>
    /// Class to represent linear mathematical formulas
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LinearFormula"></see></summary>
    let LinearFormula = _prefix "LinearFormula"
    /// <summary>
    /// Class to represent logit mathematical formulas.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LogitFormula"></see></summary>
    let LogitFormula = _prefix "LogitFormula"
    /// <summary>
    /// Class to represent quadratic mathematical formulas.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#QuadraticFormula"></see></summary>
    let QuadraticFormula = _prefix "QuadraticFormula"
    /// <summary>
    /// Class to represent weibull mathematical formulas.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#WeibullFormula"></see></summary>
    let WeibullFormula = _prefix "WeibullFormula"
    /// <summary>
    /// Identifier of an element given in the obXML file. Attribute considered for backward compatibility.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// A relationship indicating the address of a building
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#buildingAddress"></see></summary>
    let buildingAddress = _prefix "buildingAddress"
    /// <summary>
    /// Relationship that indicates the minimum number of occupants inside a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minNumberOccupants"></see></summary>
    let minNumberOccupants = _prefix "minNumberOccupants"
    /// <summary>
    /// Relationship that indicates the maximum number of occupants inside a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxNumberOccupants"></see></summary>
    let maxNumberOccupants = _prefix "maxNumberOccupants"
    /// <summary>
    /// Occupants or residents of a building.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Occupant"></see></summary>
    let Occupant = _prefix "Occupant"
    /// <summary>
    /// Relationship that indicates that an space can have an occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOccupant"></see></summary>
    let hasOccupant = _prefix "hasOccupant"
    /// <summary>
    /// Class to represent a meeting inside a communal space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Meeting"></see></summary>
    let Meeting = _prefix "Meeting"
    /// <summary>
    /// Indicates that a meeting can occur within a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasMeeting"></see></summary>
    let hasMeeting = _prefix "hasMeeting"
    /// <summary>
    /// Physical comfort need that could influence a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#PhysicalNeed"></see></summary>
    let PhysicalNeed = _prefix "PhysicalNeed"
    /// <summary>
    /// Actions are the interactions with systems or activities that an occupant can conduct to achieve environmental comfort. Actions connect occupants' inside-world needs with the environmental outside world. (Defintion taken from obXML)
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Adjustable"></see>
    /// </summary>
    let Adjustable = _prefix "Adjustable"
    /// <summary>
    /// Types of operational modes for space systems.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConcept"></see></summary>
    let OperationalModeConcept = _prefix "OperationalModeConcept"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Afternoon"></see>
    /// </summary>
    let Afternoon = _prefix "Afternoon"
    /// <summary>
    /// Relative time of day.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TimeOfDay"></see></summary>
    let TimeOfDay = _prefix "TimeOfDay"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Arrival"></see>
    /// </summary>
    let Arrival = _prefix "Arrival"
    /// <summary>
    /// One time event involving occupancy status transition in building level.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionTypeConcept"></see></summary>
    let StatusTransitionTypeConcept = _prefix "StatusTransitionTypeConcept"
    /// <summary>
    /// Behavior related to the interaction with buildings
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Behavior"></see></summary>
    let Behavior = _prefix "Behavior"
    /// <summary>
    /// Needs represent the physical and non-physical requirements of the occupant's inside world that must be met in order to ensure the satisfaction of the occupant with their environment.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Need"></see></summary>
    let Need = _prefix "Need"
    /// <summary>
    /// Indicates that a driver can be influenced by an occupant comfort need.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#influencedByNeed"></see></summary>
    let influencedByNeed = _prefix "influencedByNeed"
    /// <summary>
    /// The Inaction class represents the decision of an occupant to not act and remain uncomfortable within a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Inaction"></see></summary>
    let Inaction = _prefix "Inaction"
    /// <summary>
    /// Relationship to indicate the outcome of a behavior. It could lead to an action over a building system to recover comfort or to a passive acceptance of the environmental conditions.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#leadsTo"></see></summary>
    let leadsTo = _prefix "leadsTo"
    /// <summary>
    /// Set of drivers that could be causing a behavior at a specific time.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#DriverSet"></see></summary>
    let DriverSet = _prefix "DriverSet"
    /// <summary>
    /// Property to link an occupant with a set of internal or external drivers that are controlling its interactions with building systems.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#drivenBy"></see></summary>
    let drivenBy = _prefix "drivenBy"
    /// <summary>
    /// Class to represent the value and name of coefficients inside mathematical formulas.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Coefficient"></see></summary>
    let Coefficient = _prefix "Coefficient"
    /// <summary>
    /// A relationship indicating the value of a coefficient.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#coefficientValue"></see></summary>
    let coefficientValue = _prefix "coefficientValue"
    /// <summary>
    /// Formula to model the probability of interaction between ocupant and system.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionFormula"></see></summary>
    let InteractionFormula = _prefix "InteractionFormula"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ContinuousControl"></see>
    /// </summary>
    let ContinuousControl = _prefix "ContinuousControl"
    /// <summary>
    /// Class to represent instances of custom probabilistic models.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#CustomProbabilityModel"></see></summary>
    let CustomProbabilityModel = _prefix "CustomProbabilityModel"
    /// <summary>
    /// Relationship that links a probility to an event. For example the occurance probability of a meeting.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#probability"></see></summary>
    let probability = _prefix "probability"
    /// <summary>
    /// Probabilistic model to define occupant movements inside and between spaces.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#MovementModel"></see></summary>
    let MovementModel = _prefix "MovementModel"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Day"></see>
    /// </summary>
    let Day = _prefix "Day"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#DayLight"></see>
    /// </summary>
    let DayLight = _prefix "DayLight"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Departure"></see>
    /// </summary>
    let Departure = _prefix "Departure"
    /// <summary>
    /// A Driver represents the environmental factor from the outside world that stimulate occupants in their inside world to fulfill a physical, physiological or psychological need.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Driver"></see></summary>
    let Driver = _prefix "Driver"
    /// <summary>
    /// Relationship that indicates the composition of a set of drivers.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#composedOf"></see></summary>
    let composedOf = _prefix "composedOf"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnteringRoom"></see>
    /// </summary>
    let EnteringRoom = _prefix "EnteringRoom"
    /// <summary>
    /// Driver related to events that could be causing a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Driver related to the environmental conditions that could be causing a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Environment"></see></summary>
    let Environment = _prefix "Environment"
    /// <summary>
    /// Class that represent a physical variable of the environment where the driver occurs. It could represent variables that impact directly on the comfort levels of the occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnvironmentalParameter"></see></summary>
    let EnvironmentalParameter = _prefix "EnvironmentalParameter"
    /// <summary>
    /// Relates and occupant environmental driver with an environmental property like temperature or illuminance.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasEnvironmentalParameter"></see></summary>
    let hasEnvironmentalParameter = _prefix "hasEnvironmentalParameter"
    /// <summary>
    /// Relates an environmental parameter with a unit of measure.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasUnitOfMeasure"></see></summary>
    let hasUnitOfMeasure = _prefix "hasUnitOfMeasure"
    /// <summary>
    /// Class to represent electrical equipments occupants interact with but do not have influence over indoor thermal conditions. These systems contribute to the energy bugdet estimation.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Equipment"></see></summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Evening"></see>
    /// </summary>
    let Evening = _prefix "Evening"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Fall"></see>
    /// </summary>
    let Fall = _prefix "Fall"
    /// <summary>
    /// Season of the year.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Season"></see></summary>
    let Season = _prefix "Season"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Fixed"></see>
    /// </summary>
    let Fixed = _prefix "Fixed"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Glare"></see>
    /// </summary>
    let Glare = _prefix "Glare"
    /// <summary>
    /// Driver related to habits that could be causing a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Habit"></see></summary>
    let Habit = _prefix "Habit"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Illuminance"></see>
    /// </summary>
    let Illuminance = _prefix "Illuminance"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#IndoorAirQuality"></see>
    /// </summary>
    let IndoorAirQuality = _prefix "IndoorAirQuality"
    /// <summary>
    /// The Interaction class represent the interactions of occupants with systems within a space to recover their comfort.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Interaction"></see></summary>
    let Interaction = _prefix "Interaction"
    /// <summary>
    /// A relationship indicating the magnitud of a control action over a building system.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#controlValue"></see></summary>
    let controlValue = _prefix "controlValue"
    /// <summary>
    /// Relationship that describes an interaction between an occupant and a building component or system.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#interactsOver"></see></summary>
    let interactsOver = _prefix "interactsOver"
    /// <summary>
    /// Property to relate an interaction with a formula describing the probability of occurance.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#describedByFormula"></see></summary>
    let describedByFormula = _prefix "describedByFormula"
    /// <summary>
    /// Types of interactions between occupants and systems.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionConcept"></see></summary>
    let InteractionConcept = _prefix "InteractionConcept"
    /// <summary>
    /// Relates a formula with an independent variable.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasIndependentVariable"></see></summary>
    let hasIndependentVariable = _prefix "hasIndependentVariable"
    /// <summary>
    /// Relates a formula with a coefficient.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasCoefficient"></see></summary>
    let hasCoefficient = _prefix "hasCoefficient"
    /// <summary>
    /// An aggregation of SKOS concepts regarding the interaction type between occupants and space systems
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionScheme"></see></summary>
    let InteractionScheme = _prefix "InteractionScheme"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LeavingRoom"></see>
    /// </summary>
    let LeavingRoom = _prefix "LeavingRoom"
    /// <summary>
    /// A devide used for illumination.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LightingDevice"></see></summary>
    let LightingDevice = _prefix "LightingDevice"
    /// <summary>
    /// Class to represent instances of Markov chain models.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#MarkovChainModel"></see></summary>
    let MarkovChainModel = _prefix "MarkovChainModel"
    /// <summary>
    /// Typical occurrence time of an event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalTime"></see></summary>
    let typicalTime = _prefix "typicalTime"
    /// <summary>
    /// Earliest occurrence time of an event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#earlyOccurTime"></see></summary>
    let earlyOccurTime = _prefix "earlyOccurTime"
    /// <summary>
    /// The start time of an event or activity.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// The end time of an event or activity.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// Average duration of an event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Morning"></see>
    /// </summary>
    let Morning = _prefix "Morning"
    /// <summary>
    /// The Movement class is used to represent the occupant's movements inside or between spaces.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Movement"></see></summary>
    let Movement = _prefix "Movement"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Night"></see>
    /// </summary>
    let Night = _prefix "Night"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Noise"></see>
    /// </summary>
    let Noise = _prefix "Noise"
    /// <summary>
    /// Non physical comfort needs (e.g. privacy, status, etc) that could influence a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#NonPhysicalNeed"></see></summary>
    let NonPhysicalNeed = _prefix "NonPhysicalNeed"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Noon"></see>
    /// </summary>
    let Noon = _prefix "Noon"
    /// <summary>
    /// Class to represent instances of Normal probabilistic models.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#NormalProbabilityModel"></see></summary>
    let NormalProbabilityModel = _prefix "NormalProbabilityModel"
    /// <summary>
    /// Gender of an occupant
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantGender"></see></summary>
    let occupantGender = _prefix "occupantGender"
    /// <summary>
    /// Age of an occupant
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantAge"></see></summary>
    let occupantAge = _prefix "occupantAge"
    /// <summary>
    /// Jobtype of an occupant
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantJobtype"></see></summary>
    let occupantJobtype = _prefix "occupantJobtype"
    /// <summary>
    /// Lifestyle of an occupant
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantLifestyle"></see></summary>
    let occupantLifestyle = _prefix "occupantLifestyle"
    /// <summary>
    /// Property to indicate that an occupant has a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasBehavior"></see></summary>
    let hasBehavior = _prefix "hasBehavior"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OnOff"></see>
    /// </summary>
    let OnOff = _prefix "OnOff"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Operable"></see>
    /// </summary>
    let Operable = _prefix "Operable"
    /// <summary>
    /// An aggregation of SKOS concepts regarding the operational mode of space systems.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConceptScheme"></see></summary>
    let OperationalModeConceptScheme = _prefix "OperationalModeConceptScheme"
    /// <summary>
    /// Class to represent the minimum and maximm comfort values with respect to an environmental parameter.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ParameterRange"></see></summary>
    let ParameterRange = _prefix "ParameterRange"
    /// <summary>
    /// Lower boundary of a parameter range description.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minRangeValue"></see></summary>
    let minRangeValue = _prefix "minRangeValue"
    /// <summary>
    /// Upper boundary of a parameter range description.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxRangeValue"></see></summary>
    let maxRangeValue = _prefix "maxRangeValue"
    /// <summary>
    /// Relates a comfort envelop with an environmental parameter.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#describesParameter"></see></summary>
    let describesParameter = _prefix "describesParameter"
    /// <summary>
    /// Property used to describe occupant needs by defining comfort limits w.r.t. an environmental parameter.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#definedByRange"></see></summary>
    let definedByRange = _prefix "definedByRange"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Rain"></see>
    /// </summary>
    let Rain = _prefix "Rain"
    /// <summary>
    /// Type of occupant movements inside a building or space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#RandomMovement"></see></summary>
    let RandomMovement = _prefix "RandomMovement"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#RelativeHumidity"></see>
    /// </summary>
    let RelativeHumidity = _prefix "RelativeHumidity"
    /// <summary>
    /// The Report class indicates that an occupant seeks assistance or files a complaint about their personal discomfort, but does not take direct action to satisfy their needs.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// Relationship that indicates the month when a season start.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#startSeason"></see></summary>
    let startSeason = _prefix "startSeason"
    /// <summary>
    /// Relationship that indicates the month when a season ends.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#endSeason"></see></summary>
    let endSeason = _prefix "endSeason"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SetToControlValue"></see>
    /// </summary>
    let SetToControlValue = _prefix "SetToControlValue"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ShortTermLeaving"></see>
    /// </summary>
    let ShortTermLeaving = _prefix "ShortTermLeaving"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ShortTermVisiting"></see>
    /// </summary>
    let ShortTermVisiting = _prefix "ShortTermVisiting"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SolarIrradiance"></see>
    /// </summary>
    let SolarIrradiance = _prefix "SolarIrradiance"
    /// <summary>
    /// Occupancy percentage of staying in a specific space category in a building.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SpaceOccupancy"></see></summary>
    let SpaceOccupancy = _prefix "SpaceOccupancy"
    /// <summary>
    /// Percentage of occupancy time in a space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#percentTimePresence"></see></summary>
    let percentTimePresence = _prefix "percentTimePresence"
    /// <summary>
    /// Property that relates space occupancy events to an specific building space.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#relatedToSpace"></see></summary>
    let relatedToSpace = _prefix "relatedToSpace"
    /// <summary>
    /// Driver related to spatial conditions that could be causing a behavior.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spatial"></see></summary>
    let Spatial = _prefix "Spatial"
    /// <summary>
    /// Relates a spatial driver to an specific building space
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#detailedBy"></see></summary>
    let detailedBy = _prefix "detailedBy"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spring"></see>
    /// </summary>
    let Spring = _prefix "Spring"
    /// <summary>
    /// Type of movements to represent transition events between spaces.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransition"></see></summary>
    let StatusTransition = _prefix "StatusTransition"
    /// <summary>
    /// The typical duration of an event or activity.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalDuration"></see></summary>
    let typicalDuration = _prefix "typicalDuration"
    /// <summary>
    /// The minimal duration of an event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minimalDuration"></see></summary>
    let minimalDuration = _prefix "minimalDuration"
    /// <summary>
    /// Relates a transition event to a movement model that describe this action.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#specifiedBy"></see></summary>
    let specifiedBy = _prefix "specifiedBy"
    /// <summary>
    /// Relationship that indicates the type of status transition event.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTransitionType"></see></summary>
    let hasTransitionType = _prefix "hasTransitionType"
    /// <summary>
    /// An aggregation of SKOS concepts regarding the status transition type of movements between spaces.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionScheme"></see></summary>
    let StatusTransitionScheme = _prefix "StatusTransitionScheme"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StayingInRoom"></see>
    /// </summary>
    let StayingInRoom = _prefix "StayingInRoom"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Summer"></see>
    /// </summary>
    let Summer = _prefix "Summer"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Temperature"></see>
    /// </summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    /// A thermostat is a component which senses the temperature of a physical space and performs actions so that the space temperature is maintained near a desired setpoint. (Definition adapted from Wikipedia)
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Thermostat"></see></summary>
    let Thermostat = _prefix "Thermostat"
    /// <summary>
    /// Driver related to time conditions that could be causing a behavior. It also describes the time when another type of driver occur.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// Indicates which days that act as time drivers are holidays.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#onHolidays"></see></summary>
    let onHolidays = _prefix "onHolidays"
    /// <summary>
    /// Indicates which times during a day are behavioral drivers for an occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTimeOfDay"></see></summary>
    let hasTimeOfDay = _prefix "hasTimeOfDay"
    /// <summary>
    /// Indicates which seasons are behavioral drivers for an occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasSeason"></see></summary>
    let hasSeason = _prefix "hasSeason"
    /// <summary>
    /// Indicates which days of the week are behavioral drivers for an occupant.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasDayOfWeek"></see></summary>
    let hasDayOfWeek = _prefix "hasDayOfWeek"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TurnOff"></see>
    /// </summary>
    let TurnOff = _prefix "TurnOff"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TurnOn"></see>
    /// </summary>
    let TurnOn = _prefix "TurnOn"
    /// <summary>
    /// A window is an opening in a wall, door, roof or vehicle that allows the passage of light, sound, and sometimes air. (Definition taken from Wikipedia)
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Window"></see></summary>
    let Window = _prefix "Window"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Winter"></see>
    /// </summary>
    let Winter = _prefix "Winter"
    /// <summary>
    ///   <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ZoneOnOff"></see>
    /// </summary>
    let ZoneOnOff = _prefix "ZoneOnOff"
    /// <summary>
    /// Relationship to indicate the type of control mode of a system, such as fixed or operable modes for a window.
    /// <see href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOperationalMode"></see></summary>
    let hasOperationalMode = _prefix "hasOperationalMode"
