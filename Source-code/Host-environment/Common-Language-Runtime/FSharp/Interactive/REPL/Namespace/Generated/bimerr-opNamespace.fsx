#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``bimerr-op`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://bimerr.iot.linkeddata.es/def/occupancy-profile#" "bimerr-op"

    let _namespaceIri = _prefixId.prefix ""
    let ASHRAEAdaptiveComfort = _prefixId.prefix "ASHRAEAdaptiveComfort"
    let ASHRAEComfortEnvelop = _prefixId.prefix "ASHRAEComfortEnvelop"
    /// <summary>
    ///   <para>rdfs:label : Accoustic Need</para>
    ///   <para>rdfs:comment : Range of parameter values where occupants do not feel accoustic discomfort and therefore, they don't carry out any actions.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#AccousticNeed">bimerr-op:AccousticNeed</a>
    /// </summary>
    let AccousticNeed = _prefixId.prefix "AccousticNeed"
    /// <summary>
    ///   <para>rdfs:label : Action</para>
    ///   <para>rdfs:comment : Actions are the interactions with systems or activities that an occupant can conduct to achieve environmental comfort. Actions connect occupants' inside-world needs with the environmental outside world. (Defintion taken from obXML)</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Action">bimerr-op:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    let Adjustable = _prefixId.prefix "Adjustable"
    let Afternoon = _prefixId.prefix "Afternoon"
    let Arrival = _prefixId.prefix "Arrival"
    /// <summary>
    ///   <para>rdfs:label : Behavior</para>
    ///   <para>rdfs:comment : Behavior related to the interaction with buildings</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Behavior">bimerr-op:Behavior</a>
    /// </summary>
    let Behavior = _prefixId.prefix "Behavior"
    /// <summary>
    ///   <para>rdfs:label : Coefficient</para>
    ///   <para>rdfs:comment : Class to represent the value and name of coefficients inside mathematical formulas.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Coefficient">bimerr-op:Coefficient</a>
    /// </summary>
    let Coefficient = _prefixId.prefix "Coefficient"
    /// <summary>
    ///   <para>rdfs:label : Constant Value Formula</para>
    ///   <para>rdfs:comment : Class to represent constant value mathematical formulas</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ConstantValueFormula">bimerr-op:ConstantValueFormula</a>
    /// </summary>
    let ConstantValueFormula = _prefixId.prefix "ConstantValueFormula"
    let ContinuousControl = _prefixId.prefix "ContinuousControl"
    /// <summary>
    ///   <para>rdfs:label : Custom probability model</para>
    ///   <para>rdfs:comment : Class to represent instances of custom probabilistic models.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#CustomProbabilityModel">bimerr-op:CustomProbabilityModel</a>
    /// </summary>
    let CustomProbabilityModel = _prefixId.prefix "CustomProbabilityModel"
    let Day = _prefixId.prefix "Day"
    let DayLight = _prefixId.prefix "DayLight"
    let Departure = _prefixId.prefix "Departure"
    /// <summary>
    ///   <para>rdfs:label : Driver</para>
    ///   <para>rdfs:comment : A Driver represents the environmental factor from the outside world that stimulate occupants in their inside world to fulfill a physical, physiological or psychological need.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Driver">bimerr-op:Driver</a>
    /// </summary>
    let Driver = _prefixId.prefix "Driver"
    /// <summary>
    ///   <para>rdfs:label : Driver set</para>
    ///   <para>rdfs:comment : Set of drivers that could be causing a behavior at a specific time.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#DriverSet">bimerr-op:DriverSet</a>
    /// </summary>
    let DriverSet = _prefixId.prefix "DriverSet"
    let EnteringRoom = _prefixId.prefix "EnteringRoom"
    /// <summary>
    ///   <para>rdfs:label : Environment</para>
    ///   <para>rdfs:comment : Driver related to the environmental conditions that could be causing a behavior.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Environment">bimerr-op:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>rdfs:label : Environmental parameter</para>
    ///   <para>rdfs:comment : Class that represent a physical variable of the environment where the driver occurs. It could represent variables that impact directly on the comfort levels of the occupant.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnvironmentalParameter">bimerr-op:EnvironmentalParameter</a>
    /// </summary>
    let EnvironmentalParameter = _prefixId.prefix "EnvironmentalParameter"
    /// <summary>
    ///   <para>rdfs:label : Equipment</para>
    ///   <para>rdfs:comment : Class to represent electrical equipments occupants interact with but do not have influence over indoor thermal conditions. These systems contribute to the energy bugdet estimation.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Equipment">bimerr-op:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    let Evening = _prefixId.prefix "Evening"
    /// <summary>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : Driver related to events that could be causing a behavior.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Event">bimerr-op:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let Fall = _prefixId.prefix "Fall"
    let Fixed = _prefixId.prefix "Fixed"
    let Glare = _prefixId.prefix "Glare"
    /// <summary>
    ///   <para>rdfs:label : Habit</para>
    ///   <para>rdfs:comment : Driver related to habits that could be causing a behavior.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Habit">bimerr-op:Habit</a>
    /// </summary>
    let Habit = _prefixId.prefix "Habit"
    /// <summary>
    ///   <para>rdfs:label : IAQ Need</para>
    ///   <para>rdfs:comment : Range of parameter values where occupants do not feel indoor air quality discomfort and therefore, they don't carry out any actions.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#IAQNeed">bimerr-op:IAQNeed</a>
    /// </summary>
    let IAQNeed = _prefixId.prefix "IAQNeed"
    let ISOAdaptiveComfort = _prefixId.prefix "ISOAdaptiveComfort"
    let Illuminance = _prefixId.prefix "Illuminance"
    /// <summary>
    ///   <para>rdfs:label : Inaction</para>
    ///   <para>rdfs:comment : The Inaction class represents the decision of an occupant to not act and remain uncomfortable within a space.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Inaction">bimerr-op:Inaction</a>
    /// </summary>
    let Inaction = _prefixId.prefix "Inaction"
    let IndoorAirQuality = _prefixId.prefix "IndoorAirQuality"
    /// <summary>
    ///   <para>rdfs:label : Interaction</para>
    ///   <para>rdfs:comment : The Interaction class represent the interactions of occupants with systems within a space to recover their comfort.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Interaction">bimerr-op:Interaction</a>
    /// </summary>
    let Interaction = _prefixId.prefix "Interaction"
    /// <summary>
    ///   <para>rdfs:label : Interaction concept</para>
    ///   <para>rdfs:comment : Types of interactions between occupants and systems.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionConcept">bimerr-op:InteractionConcept</a>
    /// </summary>
    let InteractionConcept = _prefixId.prefix "InteractionConcept"
    /// <summary>
    ///   <para>rdfs:label : Interaction Formula</para>
    ///   <para>rdfs:comment : Formula to model the probability of interaction between ocupant and system.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionFormula">bimerr-op:InteractionFormula</a>
    /// </summary>
    let InteractionFormula = _prefixId.prefix "InteractionFormula"
    /// <summary>
    ///   <para>rdfs:label : Interaction scheme</para>
    ///   <para>rdfs:comment : An aggregation of SKOS concepts regarding the interaction type between occupants and space systems</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionScheme">bimerr-op:InteractionScheme</a>
    /// </summary>
    let InteractionScheme = _prefixId.prefix "InteractionScheme"
    let LeavingRoom = _prefixId.prefix "LeavingRoom"
    /// <summary>
    ///   <para>rdfs:label : Lighting device</para>
    ///   <para>rdfs:comment : A devide used for illumination.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LightingDevice">bimerr-op:LightingDevice</a>
    /// </summary>
    let LightingDevice = _prefixId.prefix "LightingDevice"
    /// <summary>
    ///   <para>rdfs:label : Linear Formula</para>
    ///   <para>rdfs:comment : Class to represent linear mathematical formulas</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LinearFormula">bimerr-op:LinearFormula</a>
    /// </summary>
    let LinearFormula = _prefixId.prefix "LinearFormula"
    /// <summary>
    ///   <para>rdfs:label : Logit Formula</para>
    ///   <para>rdfs:comment : Class to represent logit mathematical formulas.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LogitFormula">bimerr-op:LogitFormula</a>
    /// </summary>
    let LogitFormula = _prefixId.prefix "LogitFormula"
    /// <summary>
    ///   <para>rdfs:label : Markov chain model</para>
    ///   <para>rdfs:comment : Class to represent instances of Markov chain models.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#MarkovChainModel">bimerr-op:MarkovChainModel</a>
    /// </summary>
    let MarkovChainModel = _prefixId.prefix "MarkovChainModel"
    /// <summary>
    ///   <para>rdfs:label : Meeting</para>
    ///   <para>rdfs:comment : Class to represent a meeting inside a communal space.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Meeting">bimerr-op:Meeting</a>
    /// </summary>
    let Meeting = _prefixId.prefix "Meeting"
    let Morning = _prefixId.prefix "Morning"
    /// <summary>
    ///   <para>rdfs:label : Movement</para>
    ///   <para>rdfs:comment : The Movement class is used to represent the occupant's movements inside or between spaces.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Movement">bimerr-op:Movement</a>
    /// </summary>
    let Movement = _prefixId.prefix "Movement"
    /// <summary>
    ///   <para>rdfs:label : Movement Model</para>
    ///   <para>rdfs:comment : Probabilistic model to define occupant movements inside and between spaces.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#MovementModel">bimerr-op:MovementModel</a>
    /// </summary>
    let MovementModel = _prefixId.prefix "MovementModel"
    /// <summary>
    ///   <para>rdfs:label : Need</para>
    ///   <para>rdfs:comment : Needs represent the physical and non-physical requirements of the occupant's inside world that must be met in order to ensure the satisfaction of the occupant with their environment.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Need">bimerr-op:Need</a>
    /// </summary>
    let Need = _prefixId.prefix "Need"
    let Night = _prefixId.prefix "Night"
    let Noise = _prefixId.prefix "Noise"
    /// <summary>
    ///   <para>rdfs:label : Non Physical Need</para>
    ///   <para>rdfs:comment : Non physical comfort needs (e.g. privacy, status, etc) that could influence a behavior.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#NonPhysicalNeed">bimerr-op:NonPhysicalNeed</a>
    /// </summary>
    let NonPhysicalNeed = _prefixId.prefix "NonPhysicalNeed"
    let Noon = _prefixId.prefix "Noon"
    /// <summary>
    ///   <para>rdfs:label : Normal probability model</para>
    ///   <para>rdfs:comment : Class to represent instances of Normal probabilistic models.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#NormalProbabilityModel">bimerr-op:NormalProbabilityModel</a>
    /// </summary>
    let NormalProbabilityModel = _prefixId.prefix "NormalProbabilityModel"
    /// <summary>
    ///   <para>rdfs:comment : Occupants or residents of a building.</para>
    ///   <para>rdfs:label : Occupant</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Occupant">bimerr-op:Occupant</a>
    /// </summary>
    let Occupant = _prefixId.prefix "Occupant"
    let OnOff = _prefixId.prefix "OnOff"
    let Operable = _prefixId.prefix "Operable"
    /// <summary>
    ///   <para>rdfs:label : Operational mode concept</para>
    ///   <para>rdfs:comment : Types of operational modes for space systems.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConcept">bimerr-op:OperationalModeConcept</a>
    /// </summary>
    let OperationalModeConcept = _prefixId.prefix "OperationalModeConcept"
    /// <summary>
    ///   <para>rdfs:label : Operational mode scheme</para>
    ///   <para>rdfs:comment : An aggregation of SKOS concepts regarding the operational mode of space systems.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConceptScheme">bimerr-op:OperationalModeConceptScheme</a>
    /// </summary>
    let OperationalModeConceptScheme = _prefixId.prefix "OperationalModeConceptScheme"
    /// <summary>
    ///   <para>rdfs:label : Parameter Range</para>
    ///   <para>rdfs:comment : Class to represent the minimum and maximm comfort values with respect to an environmental parameter.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ParameterRange">bimerr-op:ParameterRange</a>
    /// </summary>
    let ParameterRange = _prefixId.prefix "ParameterRange"
    /// <summary>
    ///   <para>rdfs:label : Physical Need</para>
    ///   <para>rdfs:comment : Physical comfort need that could influence a behavior.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#PhysicalNeed">bimerr-op:PhysicalNeed</a>
    /// </summary>
    let PhysicalNeed = _prefixId.prefix "PhysicalNeed"
    /// <summary>
    ///   <para>rdfs:label : Quadratic Formula</para>
    ///   <para>rdfs:comment : Class to represent quadratic mathematical formulas.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#QuadraticFormula">bimerr-op:QuadraticFormula</a>
    /// </summary>
    let QuadraticFormula = _prefixId.prefix "QuadraticFormula"
    let Rain = _prefixId.prefix "Rain"
    /// <summary>
    ///   <para>rdfs:label : Random movement</para>
    ///   <para>rdfs:comment : Type of occupant movements inside a building or space.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#RandomMovement">bimerr-op:RandomMovement</a>
    /// </summary>
    let RandomMovement = _prefixId.prefix "RandomMovement"
    let RelativeHumidity = _prefixId.prefix "RelativeHumidity"
    /// <summary>
    ///   <para>rdfs:label : Report</para>
    ///   <para>rdfs:comment : The Report class indicates that an occupant seeks assistance or files a complaint about their personal discomfort, but does not take direct action to satisfy their needs.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Report">bimerr-op:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : Season</para>
    ///   <para>rdfs:comment : Season of the year.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Season">bimerr-op:Season</a>
    /// </summary>
    let Season = _prefixId.prefix "Season"
    let SetToControlValue = _prefixId.prefix "SetToControlValue"
    let ShortTermLeaving = _prefixId.prefix "ShortTermLeaving"
    let ShortTermVisiting = _prefixId.prefix "ShortTermVisiting"
    let SolarIrradiance = _prefixId.prefix "SolarIrradiance"
    /// <summary>
    ///   <para>rdfs:label : Space occupancy</para>
    ///   <para>rdfs:comment : Occupancy percentage of staying in a specific space category in a building.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SpaceOccupancy">bimerr-op:SpaceOccupancy</a>
    /// </summary>
    let SpaceOccupancy = _prefixId.prefix "SpaceOccupancy"
    /// <summary>
    ///   <para>rdfs:label : Spatial</para>
    ///   <para>rdfs:comment : Driver related to spatial conditions that could be causing a behavior.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spatial">bimerr-op:Spatial</a>
    /// </summary>
    let Spatial = _prefixId.prefix "Spatial"
    let Spring = _prefixId.prefix "Spring"
    /// <summary>
    ///   <para>rdfs:label : Status transition</para>
    ///   <para>rdfs:comment : Type of movements to represent transition events between spaces.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransition">bimerr-op:StatusTransition</a>
    /// </summary>
    let StatusTransition = _prefixId.prefix "StatusTransition"
    /// <summary>
    ///   <para>rdfs:label : Status transition scheme</para>
    ///   <para>rdfs:comment : An aggregation of SKOS concepts regarding the status transition type of movements between spaces.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionScheme">bimerr-op:StatusTransitionScheme</a>
    /// </summary>
    let StatusTransitionScheme = _prefixId.prefix "StatusTransitionScheme"
    /// <summary>
    ///   <para>rdfs:label : Status transition type concept</para>
    ///   <para>rdfs:comment : One time event involving occupancy status transition in building level.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionTypeConcept">bimerr-op:StatusTransitionTypeConcept</a>
    /// </summary>
    let StatusTransitionTypeConcept = _prefixId.prefix "StatusTransitionTypeConcept"
    let StayingInRoom = _prefixId.prefix "StayingInRoom"
    let Summer = _prefixId.prefix "Summer"
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>rdfs:label : Thermal Need</para>
    ///   <para>rdfs:comment : Range of parameter values where occupants do not feel thermal discomfort and therefore, they don't carry out any actions.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ThermalNeed">bimerr-op:ThermalNeed</a>
    /// </summary>
    let ThermalNeed = _prefixId.prefix "ThermalNeed"
    /// <summary>
    ///   <para>rdfs:label : Thermostat</para>
    ///   <para>rdfs:comment : A thermostat is a component which senses the temperature of a physical space and performs actions so that the space temperature is maintained near a desired setpoint. (Definition adapted from Wikipedia)</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Thermostat">bimerr-op:Thermostat</a>
    /// </summary>
    let Thermostat = _prefixId.prefix "Thermostat"
    /// <summary>
    ///   <para>rdfs:label : Time</para>
    ///   <para>rdfs:comment : Driver related to time conditions that could be causing a behavior. It also describes the time when another type of driver occur.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Time">bimerr-op:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:label : Time Of Day</para>
    ///   <para>rdfs:comment : Relative time of day.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TimeOfDay">bimerr-op:TimeOfDay</a>
    /// </summary>
    let TimeOfDay = _prefixId.prefix "TimeOfDay"
    let TurnOff = _prefixId.prefix "TurnOff"
    let TurnOn = _prefixId.prefix "TurnOn"
    /// <summary>
    ///   <para>rdfs:label : Visual Need</para>
    ///   <para>rdfs:comment : Range of parameter values where occupants do not feel visual discomfort and therefore, they don't carry out any actions.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#VisualNeed">bimerr-op:VisualNeed</a>
    /// </summary>
    let VisualNeed = _prefixId.prefix "VisualNeed"
    /// <summary>
    ///   <para>rdfs:label : Weibull Formula</para>
    ///   <para>rdfs:comment : Class to represent weibull mathematical formulas.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#WeibullFormula">bimerr-op:WeibullFormula</a>
    /// </summary>
    let WeibullFormula = _prefixId.prefix "WeibullFormula"
    /// <summary>
    ///   <para>rdfs:label : Window</para>
    ///   <para>rdfs:comment : A window is an opening in a wall, door, roof or vehicle that allows the passage of light, sound, and sometimes air. (Definition taken from Wikipedia)</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Window">bimerr-op:Window</a>
    /// </summary>
    let Window = _prefixId.prefix "Window"
    let Winter = _prefixId.prefix "Winter"
    let ZoneOnOff = _prefixId.prefix "ZoneOnOff"
    /// <summary>
    ///   <para>rdfs:label : building address</para>
    ///   <para>rdfs:comment : A relationship indicating the address of a building</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#buildingAddress">bimerr-op:buildingAddress</a>
    /// </summary>
    let buildingAddress = _prefixId.prefix "buildingAddress"
    /// <summary>
    ///   <para>rdfs:label : coefficient value</para>
    ///   <para>rdfs:comment : A relationship indicating the value of a coefficient.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#coefficientValue">bimerr-op:coefficientValue</a>
    /// </summary>
    let coefficientValue = _prefixId.prefix "coefficientValue"
    /// <summary>
    ///   <para>rdfs:label : composed of</para>
    ///   <para>rdfs:comment : Relationship that indicates the composition of a set of drivers.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#composedOf">bimerr-op:composedOf</a>
    /// </summary>
    let composedOf = _prefixId.prefix "composedOf"
    /// <summary>
    ///   <para>rdfs:label : control value</para>
    ///   <para>rdfs:comment : A relationship indicating the magnitud of a control action over a building system.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#controlValue">bimerr-op:controlValue</a>
    /// </summary>
    let controlValue = _prefixId.prefix "controlValue"
    /// <summary>
    ///   <para>rdfs:label : defined by range</para>
    ///   <para>rdfs:comment : Property used to describe occupant needs by defining comfort limits w.r.t. an environmental parameter.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#definedByRange">bimerr-op:definedByRange</a>
    /// </summary>
    let definedByRange = _prefixId.prefix "definedByRange"
    /// <summary>
    ///   <para>rdfs:label : described by formula</para>
    ///   <para>rdfs:comment : Property to relate an interaction with a formula describing the probability of occurance.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#describedByFormula">bimerr-op:describedByFormula</a>
    /// </summary>
    let describedByFormula = _prefixId.prefix "describedByFormula"
    /// <summary>
    ///   <para>rdfs:label : describes parameter</para>
    ///   <para>rdfs:comment : Relates a comfort envelop with an environmental parameter.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#describesParameter">bimerr-op:describesParameter</a>
    /// </summary>
    let describesParameter = _prefixId.prefix "describesParameter"
    /// <summary>
    ///   <para>rdfs:label : detailed by</para>
    ///   <para>rdfs:comment : Relates a spatial driver to an specific building space</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#detailedBy">bimerr-op:detailedBy</a>
    /// </summary>
    let detailedBy = _prefixId.prefix "detailedBy"
    /// <summary>
    ///   <para>rdfs:label : driven by</para>
    ///   <para>rdfs:comment : Property to link an occupant with a set of internal or external drivers that are controlling its interactions with building systems.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#drivenBy">bimerr-op:drivenBy</a>
    /// </summary>
    let drivenBy = _prefixId.prefix "drivenBy"
    /// <summary>
    ///   <para>rdfs:label : duration</para>
    ///   <para>rdfs:comment : Average duration of an event.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#duration">bimerr-op:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:label : early occur time</para>
    ///   <para>rdfs:comment : Earliest occurrence time of an event.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#earlyOccurTime">bimerr-op:earlyOccurTime</a>
    /// </summary>
    let earlyOccurTime = _prefixId.prefix "earlyOccurTime"
    /// <summary>
    ///   <para>rdfs:label : end season</para>
    ///   <para>rdfs:comment : Relationship that indicates the month when a season ends.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#endSeason">bimerr-op:endSeason</a>
    /// </summary>
    let endSeason = _prefixId.prefix "endSeason"
    /// <summary>
    ///   <para>rdfs:label : end time</para>
    ///   <para>rdfs:comment : The end time of an event or activity.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#endTime">bimerr-op:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>rdfs:label : has behavior</para>
    ///   <para>rdfs:comment : Property to indicate that an occupant has a behavior.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasBehavior">bimerr-op:hasBehavior</a>
    /// </summary>
    let hasBehavior = _prefixId.prefix "hasBehavior"
    /// <summary>
    ///   <para>rdfs:label : has coefficient</para>
    ///   <para>rdfs:comment : Relates a formula with a coefficient.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasCoefficient">bimerr-op:hasCoefficient</a>
    /// </summary>
    let hasCoefficient = _prefixId.prefix "hasCoefficient"
    /// <summary>
    ///   <para>rdfs:label : has day of week</para>
    ///   <para>rdfs:comment : Indicates which days of the week are behavioral drivers for an occupant.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasDayOfWeek">bimerr-op:hasDayOfWeek</a>
    /// </summary>
    let hasDayOfWeek = _prefixId.prefix "hasDayOfWeek"
    /// <summary>
    ///   <para>rdfs:label : has environmental parameter</para>
    ///   <para>rdfs:comment : Relates and occupant environmental driver with an environmental property like temperature or illuminance.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasEnvironmentalParameter">bimerr-op:hasEnvironmentalParameter</a>
    /// </summary>
    let hasEnvironmentalParameter = _prefixId.prefix "hasEnvironmentalParameter"
    /// <summary>
    ///   <para>rdfs:label : has independent variable</para>
    ///   <para>rdfs:comment : Relates a formula with an independent variable.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasIndependentVariable">bimerr-op:hasIndependentVariable</a>
    /// </summary>
    let hasIndependentVariable = _prefixId.prefix "hasIndependentVariable"
    /// <summary>
    ///   <para>rdfs:label : has meeting</para>
    ///   <para>rdfs:comment : Indicates that a meeting can occur within a space.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasMeeting">bimerr-op:hasMeeting</a>
    /// </summary>
    let hasMeeting = _prefixId.prefix "hasMeeting"
    /// <summary>
    ///   <para>rdfs:label : has occupant</para>
    ///   <para>rdfs:comment : Relationship that indicates that an space can have an occupant.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOccupant">bimerr-op:hasOccupant</a>
    /// </summary>
    let hasOccupant = _prefixId.prefix "hasOccupant"
    /// <summary>
    ///   <para>rdfs:label : has operational mode</para>
    ///   <para>rdfs:comment : Relationship to indicate the type of control mode of a system, such as fixed or operable modes for a window.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOperationalMode">bimerr-op:hasOperationalMode</a>
    /// </summary>
    let hasOperationalMode = _prefixId.prefix "hasOperationalMode"
    /// <summary>
    ///   <para>rdfs:label : has season</para>
    ///   <para>rdfs:comment : Indicates which seasons are behavioral drivers for an occupant.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasSeason">bimerr-op:hasSeason</a>
    /// </summary>
    let hasSeason = _prefixId.prefix "hasSeason"
    /// <summary>
    ///   <para>rdfs:label : has time of day</para>
    ///   <para>rdfs:comment : Indicates which times during a day are behavioral drivers for an occupant.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTimeOfDay">bimerr-op:hasTimeOfDay</a>
    /// </summary>
    let hasTimeOfDay = _prefixId.prefix "hasTimeOfDay"
    /// <summary>
    ///   <para>rdfs:label : has transition type</para>
    ///   <para>rdfs:comment : Relationship that indicates the type of status transition event.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTransitionType">bimerr-op:hasTransitionType</a>
    /// </summary>
    let hasTransitionType = _prefixId.prefix "hasTransitionType"
    /// <summary>
    ///   <para>rdfs:label : has unit of measure</para>
    ///   <para>rdfs:comment : Relates an environmental parameter with a unit of measure.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasUnitOfMeasure">bimerr-op:hasUnitOfMeasure</a>
    /// </summary>
    let hasUnitOfMeasure = _prefixId.prefix "hasUnitOfMeasure"
    /// <summary>
    ///   <para>rdfs:label : identifier</para>
    ///   <para>rdfs:comment : Identifier of an element given in the obXML file. Attribute considered for backward compatibility.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#identifier">bimerr-op:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : influenced by need</para>
    ///   <para>rdfs:comment : Indicates that a driver can be influenced by an occupant comfort need.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#influencedByNeed">bimerr-op:influencedByNeed</a>
    /// </summary>
    let influencedByNeed = _prefixId.prefix "influencedByNeed"
    /// <summary>
    ///   <para>rdfs:label : interacts over</para>
    ///   <para>rdfs:comment : Relationship that describes an interaction between an occupant and a building component or system.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#interactsOver">bimerr-op:interactsOver</a>
    /// </summary>
    let interactsOver = _prefixId.prefix "interactsOver"
    /// <summary>
    ///   <para>rdfs:label : leads to</para>
    ///   <para>rdfs:comment : Relationship to indicate the outcome of a behavior. It could lead to an action over a building system to recover comfort or to a passive acceptance of the environmental conditions.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#leadsTo">bimerr-op:leadsTo</a>
    /// </summary>
    let leadsTo = _prefixId.prefix "leadsTo"
    /// <summary>
    ///   <para>rdfs:label : max number occupants</para>
    ///   <para>rdfs:comment : Relationship that indicates the maximum number of occupants inside a space.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxNumberOccupants">bimerr-op:maxNumberOccupants</a>
    /// </summary>
    let maxNumberOccupants = _prefixId.prefix "maxNumberOccupants"
    /// <summary>
    ///   <para>rdfs:label : max range value</para>
    ///   <para>rdfs:comment : Upper boundary of a parameter range description.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxRangeValue">bimerr-op:maxRangeValue</a>
    /// </summary>
    let maxRangeValue = _prefixId.prefix "maxRangeValue"
    /// <summary>
    ///   <para>rdfs:label : min number occupants</para>
    ///   <para>rdfs:comment : Relationship that indicates the minimum number of occupants inside a space.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minNumberOccupants">bimerr-op:minNumberOccupants</a>
    /// </summary>
    let minNumberOccupants = _prefixId.prefix "minNumberOccupants"
    /// <summary>
    ///   <para>rdfs:label : min range value</para>
    ///   <para>rdfs:comment : Lower boundary of a parameter range description.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minRangeValue">bimerr-op:minRangeValue</a>
    /// </summary>
    let minRangeValue = _prefixId.prefix "minRangeValue"
    /// <summary>
    ///   <para>rdfs:label : minimal duration</para>
    ///   <para>rdfs:comment : The minimal duration of an event.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minimalDuration">bimerr-op:minimalDuration</a>
    /// </summary>
    let minimalDuration = _prefixId.prefix "minimalDuration"
    /// <summary>
    ///   <para>rdfs:label : occupant age</para>
    ///   <para>rdfs:comment : Age of an occupant</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantAge">bimerr-op:occupantAge</a>
    /// </summary>
    let occupantAge = _prefixId.prefix "occupantAge"
    /// <summary>
    ///   <para>rdfs:label : occupant gender</para>
    ///   <para>rdfs:comment : Gender of an occupant</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantGender">bimerr-op:occupantGender</a>
    /// </summary>
    let occupantGender = _prefixId.prefix "occupantGender"
    /// <summary>
    ///   <para>rdfs:label : occupant jobtype</para>
    ///   <para>rdfs:comment : Jobtype of an occupant</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantJobtype">bimerr-op:occupantJobtype</a>
    /// </summary>
    let occupantJobtype = _prefixId.prefix "occupantJobtype"
    /// <summary>
    ///   <para>rdfs:label : occupant lifestyle</para>
    ///   <para>rdfs:comment : Lifestyle of an occupant</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantLifestyle">bimerr-op:occupantLifestyle</a>
    /// </summary>
    let occupantLifestyle = _prefixId.prefix "occupantLifestyle"
    /// <summary>
    ///   <para>rdfs:label : on holidays</para>
    ///   <para>rdfs:comment : Indicates which days that act as time drivers are holidays.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#onHolidays">bimerr-op:onHolidays</a>
    /// </summary>
    let onHolidays = _prefixId.prefix "onHolidays"
    /// <summary>
    ///   <para>rdfs:label : percent time presence</para>
    ///   <para>rdfs:comment : Percentage of occupancy time in a space.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#percentTimePresence">bimerr-op:percentTimePresence</a>
    /// </summary>
    let percentTimePresence = _prefixId.prefix "percentTimePresence"
    /// <summary>
    ///   <para>rdfs:label : probability</para>
    ///   <para>rdfs:comment : Relationship that links a probility to an event. For example the occurance probability of a meeting.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#probability">bimerr-op:probability</a>
    /// </summary>
    let probability = _prefixId.prefix "probability"
    /// <summary>
    ///   <para>rdfs:label : related to space</para>
    ///   <para>rdfs:comment : Property that relates space occupancy events to an specific building space.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#relatedToSpace">bimerr-op:relatedToSpace</a>
    /// </summary>
    let relatedToSpace = _prefixId.prefix "relatedToSpace"
    /// <summary>
    ///   <para>rdfs:label : specified by</para>
    ///   <para>rdfs:comment : Relates a transition event to a movement model that describe this action.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#specifiedBy">bimerr-op:specifiedBy</a>
    /// </summary>
    let specifiedBy = _prefixId.prefix "specifiedBy"
    /// <summary>
    ///   <para>rdfs:label : start season</para>
    ///   <para>rdfs:comment : Relationship that indicates the month when a season start.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#startSeason">bimerr-op:startSeason</a>
    /// </summary>
    let startSeason = _prefixId.prefix "startSeason"
    /// <summary>
    ///   <para>rdfs:label : start time</para>
    ///   <para>rdfs:comment : The start time of an event or activity.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#startTime">bimerr-op:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>rdfs:label : typical duration</para>
    ///   <para>rdfs:comment : The typical duration of an event or activity.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalDuration">bimerr-op:typicalDuration</a>
    /// </summary>
    let typicalDuration = _prefixId.prefix "typicalDuration"
    /// <summary>
    ///   <para>rdfs:label : typical time</para>
    ///   <para>rdfs:comment : Typical occurrence time of an event.</para>
    ///   <a href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalTime">bimerr-op:typicalTime</a>
    /// </summary>
    let typicalTime = _prefixId.prefix "typicalTime"
