namespace http.bimerr.iot.linkeddata.es.def.occupancy_profile.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bimerr_op =
    let _namespace_iri = Namespace_Iri bimerr_op |> NamespaceIRI

    /// <summary>
    ///   <para>bimerr-op:ASHRAEAdaptiveComfort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:ThermalNeed</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ASHRAEAdaptiveComfort">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ASHRAEAdaptiveComfort</seealso>
    let ASHRAEAdaptiveComfort =
        Prefixed_Name(bimerr_op, "ASHRAEAdaptiveComfort") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:ISOAdaptiveComfort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:ThermalNeed</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ISOAdaptiveComfort">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ISOAdaptiveComfort</seealso>
    let ISOAdaptiveComfort =
        Prefixed_Name(bimerr_op, "ISOAdaptiveComfort") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:IAQNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Range of parameter values where occupants do not feel indoor air quality discomfort and therefore, they don't carry out any actions.</para>
    /// labels<para>IAQ Need</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#IAQNeed">http://bimerr.iot.linkeddata.es/def/occupancy-profile#IAQNeed</seealso>
    let IAQNeed = Prefixed_Name(bimerr_op, "IAQNeed") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:VisualNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Range of parameter values where occupants do not feel visual discomfort and therefore, they don't carry out any actions.</para>
    /// labels<para>Visual Need</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#VisualNeed">http://bimerr.iot.linkeddata.es/def/occupancy-profile#VisualNeed</seealso>
    let VisualNeed = Prefixed_Name(bimerr_op, "VisualNeed") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:WeibullFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent weibull mathematical formulas.</para>
    /// labels<para>Weibull Formula</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#WeibullFormula">http://bimerr.iot.linkeddata.es/def/occupancy-profile#WeibullFormula</seealso>
    let WeibullFormula = Prefixed_Name(bimerr_op, "WeibullFormula") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:IndoorAirQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:saref#Property</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#IndoorAirQuality">http://bimerr.iot.linkeddata.es/def/occupancy-profile#IndoorAirQuality</seealso>
    let IndoorAirQuality = Prefixed_Name(bimerr_op, "IndoorAirQuality") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Interaction class represent the interactions of occupants with systems within a space to recover their comfort.</para>
    /// labels<para>Interaction</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Interaction">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Interaction</seealso>
    let Interaction = Prefixed_Name(bimerr_op, "Interaction") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:hasIndependentVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a formula with an independent variable.</para>
    /// labels<para>has independent variable</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasIndependentVariable">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasIndependentVariable</seealso>
    let hasIndependentVariable =
        Prefixed_Name(bimerr_op, "hasIndependentVariable") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:LightingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A devide used for illumination.</para>
    /// labels<para>Lighting device</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LightingDevice">http://bimerr.iot.linkeddata.es/def/occupancy-profile#LightingDevice</seealso>
    let LightingDevice = Prefixed_Name(bimerr_op, "LightingDevice") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The start time of an event or activity.</para>
    /// labels<para>start time</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#startTime">http://bimerr.iot.linkeddata.es/def/occupancy-profile#startTime</seealso>
    let startTime = Prefixed_Name(bimerr_op, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Morning</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:TimeOfDay</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Morning">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Morning</seealso>
    let Morning = Prefixed_Name(bimerr_op, "Morning") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Movement class is used to represent the occupant's movements inside or between spaces.</para>
    /// labels<para>Movement</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Movement">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Movement</seealso>
    let Movement = Prefixed_Name(bimerr_op, "Movement") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Night</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:TimeOfDay</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Night">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Night</seealso>
    let Night = Prefixed_Name(bimerr_op, "Night") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Noon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:TimeOfDay</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Noon">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Noon</seealso>
    let Noon = Prefixed_Name(bimerr_op, "Noon") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:NormalProbabilityModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent instances of Normal probabilistic models.</para>
    /// labels<para>Normal probability model</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#NormalProbabilityModel">http://bimerr.iot.linkeddata.es/def/occupancy-profile#NormalProbabilityModel</seealso>
    let NormalProbabilityModel =
        Prefixed_Name(bimerr_op, "NormalProbabilityModel") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:occupantAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Age of an occupant</para>
    /// labels<para>occupant age</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantAge">http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantAge</seealso>
    let occupantAge = Prefixed_Name(bimerr_op, "occupantAge") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:occupantJobtype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Jobtype of an occupant</para>
    /// labels<para>occupant jobtype</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantJobtype">http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantJobtype</seealso>
    let occupantJobtype = Prefixed_Name(bimerr_op, "occupantJobtype") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:hasBehavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property to indicate that an occupant has a behavior.</para>
    /// labels<para>has behavior</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasBehavior">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasBehavior</seealso>
    let hasBehavior = Prefixed_Name(bimerr_op, "hasBehavior") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:OnOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:OperationalModeConcept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OnOff">http://bimerr.iot.linkeddata.es/def/occupancy-profile#OnOff</seealso>
    let OnOff = Prefixed_Name(bimerr_op, "OnOff") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Operable</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:OperationalModeConcept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Operable">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Operable</seealso>
    let Operable = Prefixed_Name(bimerr_op, "Operable") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:ParameterRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent the minimum and maximm comfort values with respect to an environmental parameter.</para>
    /// labels<para>Parameter Range</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ParameterRange">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ParameterRange</seealso>
    let ParameterRange = Prefixed_Name(bimerr_op, "ParameterRange") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:describesParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a comfort envelop with an environmental parameter.</para>
    /// labels<para>describes parameter</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#describesParameter">http://bimerr.iot.linkeddata.es/def/occupancy-profile#describesParameter</seealso>
    let describesParameter =
        Prefixed_Name(bimerr_op, "describesParameter") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:RelativeHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:saref#Property</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#RelativeHumidity">http://bimerr.iot.linkeddata.es/def/occupancy-profile#RelativeHumidity</seealso>
    let RelativeHumidity = Prefixed_Name(bimerr_op, "RelativeHumidity") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Report class indicates that an occupant seeks assistance or files a complaint about their personal discomfort, but does not take direct action to satisfy their needs.</para>
    /// labels<para>Report</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Report">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Report</seealso>
    let Report = Prefixed_Name(bimerr_op, "Report") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:endSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relationship that indicates the month when a season ends.</para>
    /// labels<para>end season</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#endSeason">http://bimerr.iot.linkeddata.es/def/occupancy-profile#endSeason</seealso>
    let endSeason = Prefixed_Name(bimerr_op, "endSeason") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:SetToControlValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:InteractionConcept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SetToControlValue">http://bimerr.iot.linkeddata.es/def/occupancy-profile#SetToControlValue</seealso>
    let SetToControlValue =
        Prefixed_Name(bimerr_op, "SetToControlValue") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:ShortTermLeaving</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:StatusTransitionTypeConcept</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ShortTermLeaving">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ShortTermLeaving</seealso>
    let ShortTermLeaving = Prefixed_Name(bimerr_op, "ShortTermLeaving") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:ShortTermVisiting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:StatusTransitionTypeConcept</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ShortTermVisiting">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ShortTermVisiting</seealso>
    let ShortTermVisiting =
        Prefixed_Name(bimerr_op, "ShortTermVisiting") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:SolarIrradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:saref#Property</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SolarIrradiance">http://bimerr.iot.linkeddata.es/def/occupancy-profile#SolarIrradiance</seealso>
    let SolarIrradiance = Prefixed_Name(bimerr_op, "SolarIrradiance") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:SpaceOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Occupancy percentage of staying in a specific space category in a building.</para>
    /// labels<para>Space occupancy</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#SpaceOccupancy">http://bimerr.iot.linkeddata.es/def/occupancy-profile#SpaceOccupancy</seealso>
    let SpaceOccupancy = Prefixed_Name(bimerr_op, "SpaceOccupancy") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:AccousticNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Range of parameter values where occupants do not feel accoustic discomfort and therefore, they don't carry out any actions.</para>
    /// labels<para>Accoustic Need</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#AccousticNeed">http://bimerr.iot.linkeddata.es/def/occupancy-profile#AccousticNeed</seealso>
    let AccousticNeed = Prefixed_Name(bimerr_op, "AccousticNeed") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Arrival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:StatusTransitionTypeConcept</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Arrival">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Arrival</seealso>
    let Arrival = Prefixed_Name(bimerr_op, "Arrival") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:StatusTransitionTypeConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One time event involving occupancy status transition in building level.</para>
    /// labels<para>Status transition type concept</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionTypeConcept">http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionTypeConcept</seealso>
    let StatusTransitionTypeConcept =
        Prefixed_Name(bimerr_op, "StatusTransitionTypeConcept") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:DriverSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of drivers that could be causing a behavior at a specific time.</para>
    /// labels<para>Driver set</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#DriverSet">http://bimerr.iot.linkeddata.es/def/occupancy-profile#DriverSet</seealso>
    let DriverSet = Prefixed_Name(bimerr_op, "DriverSet") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:InteractionFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Formula to model the probability of interaction between ocupant and system.</para>
    /// labels<para>Interaction Formula</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionFormula">http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionFormula</seealso>
    let InteractionFormula =
        Prefixed_Name(bimerr_op, "InteractionFormula") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:MovementModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Probabilistic model to define occupant movements inside and between spaces.</para>
    /// labels<para>Movement Model</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#MovementModel">http://bimerr.iot.linkeddata.es/def/occupancy-profile#MovementModel</seealso>
    let MovementModel = Prefixed_Name(bimerr_op, "MovementModel") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:TimeOfDay</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Day">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Day</seealso>
    let Day = Prefixed_Name(bimerr_op, "Day") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:LogitFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent logit mathematical formulas.</para>
    /// labels<para>Logit Formula</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LogitFormula">http://bimerr.iot.linkeddata.es/def/occupancy-profile#LogitFormula</seealso>
    let LogitFormula = Prefixed_Name(bimerr_op, "LogitFormula") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:ConstantValueFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent constant value mathematical formulas</para>
    /// labels<para>Constant Value Formula</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ConstantValueFormula">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ConstantValueFormula</seealso>
    let ConstantValueFormula =
        Prefixed_Name(bimerr_op, "ConstantValueFormula") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:maxNumberOccupants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relationship that indicates the maximum number of occupants inside a space.</para>
    /// labels<para>max number occupants</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxNumberOccupants">http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxNumberOccupants</seealso>
    let maxNumberOccupants =
        Prefixed_Name(bimerr_op, "maxNumberOccupants") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:Meeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent a meeting inside a communal space.</para>
    /// labels<para>Meeting</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Meeting">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Meeting</seealso>
    let Meeting = Prefixed_Name(bimerr_op, "Meeting") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:PhysicalNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Physical comfort need that could influence a behavior.</para>
    /// labels<para>Physical Need</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#PhysicalNeed">http://bimerr.iot.linkeddata.es/def/occupancy-profile#PhysicalNeed</seealso>
    let PhysicalNeed = Prefixed_Name(bimerr_op, "PhysicalNeed") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Actions are the interactions with systems or activities that an occupant can conduct to achieve environmental comfort. Actions connect occupants' inside-world needs with the environmental outside world. (Defintion taken from obXML)</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Action">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Action</seealso>
    let Action = Prefixed_Name(bimerr_op, "Action") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:OperationalModeConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of operational modes for space systems.</para>
    /// labels<para>Operational mode concept</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConcept">http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConcept</seealso>
    let OperationalModeConcept =
        Prefixed_Name(bimerr_op, "OperationalModeConcept") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:Afternoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:TimeOfDay</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Afternoon">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Afternoon</seealso>
    let Afternoon = Prefixed_Name(bimerr_op, "Afternoon") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Need</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Needs represent the physical and non-physical requirements of the occupant's inside world that must be met in order to ensure the satisfaction of the occupant with their environment.</para>
    /// labels<para>Need</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Need">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Need</seealso>
    let Need = Prefixed_Name(bimerr_op, "Need") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:influencedByNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a driver can be influenced by an occupant comfort need.</para>
    /// labels<para>influenced by need</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#influencedByNeed">http://bimerr.iot.linkeddata.es/def/occupancy-profile#influencedByNeed</seealso>
    let influencedByNeed = Prefixed_Name(bimerr_op, "influencedByNeed") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:minNumberOccupants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Relationship that indicates the minimum number of occupants inside a space.</para>
    /// labels<para>min number occupants</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minNumberOccupants">http://bimerr.iot.linkeddata.es/def/occupancy-profile#minNumberOccupants</seealso>
    let minNumberOccupants =
        Prefixed_Name(bimerr_op, "minNumberOccupants") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:hasOccupant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship that indicates that an space can have an occupant.</para>
    /// labels<para>has occupant</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOccupant">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOccupant</seealso>
    let hasOccupant = Prefixed_Name(bimerr_op, "hasOccupant") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:minimalDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The minimal duration of an event.</para>
    /// labels<para>minimal duration</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minimalDuration">http://bimerr.iot.linkeddata.es/def/occupancy-profile#minimalDuration</seealso>
    let minimalDuration = Prefixed_Name(bimerr_op, "minimalDuration") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Identifier of an element given in the obXML file. Attribute considered for backward compatibility.</para>
    /// labels<para>identifier</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#identifier">http://bimerr.iot.linkeddata.es/def/occupancy-profile#identifier</seealso>
    let identifier = Prefixed_Name(bimerr_op, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:occupantGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Gender of an occupant</para>
    /// labels<para>occupant gender</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantGender">http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantGender</seealso>
    let occupantGender = Prefixed_Name(bimerr_op, "occupantGender") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:occupantLifestyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Lifestyle of an occupant</para>
    /// labels<para>occupant lifestyle</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantLifestyle">http://bimerr.iot.linkeddata.es/def/occupancy-profile#occupantLifestyle</seealso>
    let occupantLifestyle =
        Prefixed_Name(bimerr_op, "occupantLifestyle") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:buildingAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship indicating the address of a building</para>
    /// labels<para>building address</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#buildingAddress">http://bimerr.iot.linkeddata.es/def/occupancy-profile#buildingAddress</seealso>
    let buildingAddress = Prefixed_Name(bimerr_op, "buildingAddress") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:OperationalModeConceptScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggregation of SKOS concepts regarding the operational mode of space systems.</para>
    /// labels<para>Operational mode scheme</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConceptScheme">http://bimerr.iot.linkeddata.es/def/occupancy-profile#OperationalModeConceptScheme</seealso>
    let OperationalModeConceptScheme =
        Prefixed_Name(bimerr_op, "OperationalModeConceptScheme") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:minRangeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Lower boundary of a parameter range description.</para>
    /// labels<para>min range value</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#minRangeValue">http://bimerr.iot.linkeddata.es/def/occupancy-profile#minRangeValue</seealso>
    let minRangeValue = Prefixed_Name(bimerr_op, "minRangeValue") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:maxRangeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Upper boundary of a parameter range description.</para>
    /// labels<para>max range value</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxRangeValue">http://bimerr.iot.linkeddata.es/def/occupancy-profile#maxRangeValue</seealso>
    let maxRangeValue = Prefixed_Name(bimerr_op, "maxRangeValue") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Rain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:saref#Property</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Rain">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Rain</seealso>
    let Rain = Prefixed_Name(bimerr_op, "Rain") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:RandomMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of occupant movements inside a building or space.</para>
    /// labels<para>Random movement</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#RandomMovement">http://bimerr.iot.linkeddata.es/def/occupancy-profile#RandomMovement</seealso>
    let RandomMovement = Prefixed_Name(bimerr_op, "RandomMovement") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:startSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relationship that indicates the month when a season start.</para>
    /// labels<para>start season</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#startSeason">http://bimerr.iot.linkeddata.es/def/occupancy-profile#startSeason</seealso>
    let startSeason = Prefixed_Name(bimerr_op, "startSeason") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:percentTimePresence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Percentage of occupancy time in a space.</para>
    /// labels<para>percent time presence</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#percentTimePresence">http://bimerr.iot.linkeddata.es/def/occupancy-profile#percentTimePresence</seealso>
    let percentTimePresence =
        Prefixed_Name(bimerr_op, "percentTimePresence") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:relatedToSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that relates space occupancy events to an specific building space.</para>
    /// labels<para>related to space</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#relatedToSpace">http://bimerr.iot.linkeddata.es/def/occupancy-profile#relatedToSpace</seealso>
    let relatedToSpace = Prefixed_Name(bimerr_op, "relatedToSpace") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:detailedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Relates a spatial driver to an specific building space</para>
    /// labels<para>detailed by</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#detailedBy">http://bimerr.iot.linkeddata.es/def/occupancy-profile#detailedBy</seealso>
    let detailedBy = Prefixed_Name(bimerr_op, "detailedBy") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Spring</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:Season</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spring">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spring</seealso>
    let Spring = Prefixed_Name(bimerr_op, "Spring") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:StatusTransition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of movements to represent transition events between spaces.</para>
    /// labels<para>Status transition</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransition">http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransition</seealso>
    let StatusTransition = Prefixed_Name(bimerr_op, "StatusTransition") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:hasTransitionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship that indicates the type of status transition event.</para>
    /// labels<para>has transition type</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTransitionType">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTransitionType</seealso>
    let hasTransitionType =
        Prefixed_Name(bimerr_op, "hasTransitionType") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:StatusTransitionScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggregation of SKOS concepts regarding the status transition type of movements between spaces.</para>
    /// labels<para>Status transition scheme</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionScheme">http://bimerr.iot.linkeddata.es/def/occupancy-profile#StatusTransitionScheme</seealso>
    let StatusTransitionScheme =
        Prefixed_Name(bimerr_op, "StatusTransitionScheme") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:Summer</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:Season</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Summer">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Summer</seealso>
    let Summer = Prefixed_Name(bimerr_op, "Summer") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:saref#Property</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Temperature">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Temperature</seealso>
    let Temperature = Prefixed_Name(bimerr_op, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Driver related to time conditions that could be causing a behavior. It also describes the time when another type of driver occur.</para>
    /// labels<para>Time</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Time">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Time</seealso>
    let Time = Prefixed_Name(bimerr_op, "Time") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:hasTimeOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates which times during a day are behavioral drivers for an occupant.</para>
    /// labels<para>has time of day</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTimeOfDay">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasTimeOfDay</seealso>
    let hasTimeOfDay = Prefixed_Name(bimerr_op, "hasTimeOfDay") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:hasSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates which seasons are behavioral drivers for an occupant.</para>
    /// labels<para>has season</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasSeason">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasSeason</seealso>
    let hasSeason = Prefixed_Name(bimerr_op, "hasSeason") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:hasDayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates which days of the week are behavioral drivers for an occupant.</para>
    /// labels<para>has day of week</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasDayOfWeek">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasDayOfWeek</seealso>
    let hasDayOfWeek = Prefixed_Name(bimerr_op, "hasDayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:TurnOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:InteractionConcept</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TurnOn">http://bimerr.iot.linkeddata.es/def/occupancy-profile#TurnOn</seealso>
    let TurnOn = Prefixed_Name(bimerr_op, "TurnOn") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Window</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A window is an opening in a wall, door, roof or vehicle that allows the passage of light, sound, and sometimes air. (Definition taken from Wikipedia)</para>
    /// labels<para>Window</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Window">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Window</seealso>
    let Window = Prefixed_Name(bimerr_op, "Window") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Winter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:Season</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Winter">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Winter</seealso>
    let Winter = Prefixed_Name(bimerr_op, "Winter") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:hasOperationalMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship to indicate the type of control mode of a system, such as fixed or operable modes for a window.</para>
    /// labels<para>has operational mode</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOperationalMode">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasOperationalMode</seealso>
    let hasOperationalMode =
        Prefixed_Name(bimerr_op, "hasOperationalMode") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:definedByRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property used to describe occupant needs by defining comfort limits w.r.t. an environmental parameter.</para>
    /// labels<para>defined by range</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#definedByRange">http://bimerr.iot.linkeddata.es/def/occupancy-profile#definedByRange</seealso>
    let definedByRange = Prefixed_Name(bimerr_op, "definedByRange") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Occupant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Occupants or residents of a building.</para>
    /// labels<para>Occupant</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Occupant">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Occupant</seealso>
    let Occupant = Prefixed_Name(bimerr_op, "Occupant") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Spatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Driver related to spatial conditions that could be causing a behavior.</para>
    /// labels<para>Spatial</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spatial">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Spatial</seealso>
    let Spatial = Prefixed_Name(bimerr_op, "Spatial") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:typicalDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The typical duration of an event or activity.</para>
    /// labels<para>typical duration</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalDuration">http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalDuration</seealso>
    let typicalDuration = Prefixed_Name(bimerr_op, "typicalDuration") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:specifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a transition event to a movement model that describe this action.</para>
    /// labels<para>specified by</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#specifiedBy">http://bimerr.iot.linkeddata.es/def/occupancy-profile#specifiedBy</seealso>
    let specifiedBy = Prefixed_Name(bimerr_op, "specifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:StayingInRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:Event</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#StayingInRoom">http://bimerr.iot.linkeddata.es/def/occupancy-profile#StayingInRoom</seealso>
    let StayingInRoom = Prefixed_Name(bimerr_op, "StayingInRoom") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Thermostat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A thermostat is a component which senses the temperature of a physical space and performs actions so that the space temperature is maintained near a desired setpoint. (Definition adapted from Wikipedia)</para>
    /// labels<para>Thermostat</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Thermostat">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Thermostat</seealso>
    let Thermostat = Prefixed_Name(bimerr_op, "Thermostat") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:onHolidays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates which days that act as time drivers are holidays.</para>
    /// labels<para>on holidays</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#onHolidays">http://bimerr.iot.linkeddata.es/def/occupancy-profile#onHolidays</seealso>
    let onHolidays = Prefixed_Name(bimerr_op, "onHolidays") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:hasMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a meeting can occur within a space.</para>
    /// labels<para>has meeting</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasMeeting">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasMeeting</seealso>
    let hasMeeting = Prefixed_Name(bimerr_op, "hasMeeting") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:TurnOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:InteractionConcept</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TurnOff">http://bimerr.iot.linkeddata.es/def/occupancy-profile#TurnOff</seealso>
    let TurnOff = Prefixed_Name(bimerr_op, "TurnOff") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:ZoneOnOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:OperationalModeConcept</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ZoneOnOff">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ZoneOnOff</seealso>
    let ZoneOnOff = Prefixed_Name(bimerr_op, "ZoneOnOff") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#">http://bimerr.iot.linkeddata.es/def/occupancy-profile#</seealso>
    let _prefix_iri = Prefixed_Name(bimerr_op, "") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:TimeOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relative time of day.</para>
    /// labels<para>Time Of Day</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#TimeOfDay">http://bimerr.iot.linkeddata.es/def/occupancy-profile#TimeOfDay</seealso>
    let TimeOfDay = Prefixed_Name(bimerr_op, "TimeOfDay") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Behavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Behavior related to the interaction with buildings</para>
    /// labels<para>Behavior</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Behavior">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Behavior</seealso>
    let Behavior = Prefixed_Name(bimerr_op, "Behavior") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Adjustable</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:OperationalModeConcept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Adjustable">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Adjustable</seealso>
    let Adjustable = Prefixed_Name(bimerr_op, "Adjustable") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Inaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:Inaction</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Inaction class represents the decision of an occupant to not act and remain uncomfortable within a space.</para>
    /// labels<para>Inaction</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Inaction">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Inaction</seealso>
    let Inaction = Prefixed_Name(bimerr_op, "Inaction") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:leadsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship to indicate the outcome of a behavior. It could lead to an action over a building system to recover comfort or to a passive acceptance of the environmental conditions.</para>
    /// labels<para>leads to</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#leadsTo">http://bimerr.iot.linkeddata.es/def/occupancy-profile#leadsTo</seealso>
    let leadsTo = Prefixed_Name(bimerr_op, "leadsTo") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Coefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent the value and name of coefficients inside mathematical formulas.</para>
    /// labels<para>Coefficient</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Coefficient">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Coefficient</seealso>
    let Coefficient = Prefixed_Name(bimerr_op, "Coefficient") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:ContinuousControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:OperationalModeConcept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ContinuousControl">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ContinuousControl</seealso>
    let ContinuousControl =
        Prefixed_Name(bimerr_op, "ContinuousControl") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:DayLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:saref#Property</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#DayLight">http://bimerr.iot.linkeddata.es/def/occupancy-profile#DayLight</seealso>
    let DayLight = Prefixed_Name(bimerr_op, "DayLight") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:composedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship that indicates the composition of a set of drivers.</para>
    /// labels<para>composed of</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#composedOf">http://bimerr.iot.linkeddata.es/def/occupancy-profile#composedOf</seealso>
    let composedOf = Prefixed_Name(bimerr_op, "composedOf") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:EnteringRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnteringRoom">http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnteringRoom</seealso>
    let EnteringRoom = Prefixed_Name(bimerr_op, "EnteringRoom") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:EnvironmentalParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that represent a physical variable of the environment where the driver occurs. It could represent variables that impact directly on the comfort levels of the occupant.</para>
    /// labels<para>Environmental parameter</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnvironmentalParameter">http://bimerr.iot.linkeddata.es/def/occupancy-profile#EnvironmentalParameter</seealso>
    let EnvironmentalParameter =
        Prefixed_Name(bimerr_op, "EnvironmentalParameter") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:drivenBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property to link an occupant with a set of internal or external drivers that are controlling its interactions with building systems.</para>
    /// labels<para>driven by</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#drivenBy">http://bimerr.iot.linkeddata.es/def/occupancy-profile#drivenBy</seealso>
    let drivenBy = Prefixed_Name(bimerr_op, "drivenBy") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:coefficientValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship indicating the value of a coefficient.</para>
    /// labels<para>coefficient value</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#coefficientValue">http://bimerr.iot.linkeddata.es/def/occupancy-profile#coefficientValue</seealso>
    let coefficientValue = Prefixed_Name(bimerr_op, "coefficientValue") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:CustomProbabilityModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent instances of custom probabilistic models.</para>
    /// labels<para>Custom probability model</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#CustomProbabilityModel">http://bimerr.iot.linkeddata.es/def/occupancy-profile#CustomProbabilityModel</seealso>
    let CustomProbabilityModel =
        Prefixed_Name(bimerr_op, "CustomProbabilityModel") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:probability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relationship that links a probility to an event. For example the occurance probability of a meeting.</para>
    /// labels<para>probability</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#probability">http://bimerr.iot.linkeddata.es/def/occupancy-profile#probability</seealso>
    let probability = Prefixed_Name(bimerr_op, "probability") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Departure</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:StatusTransitionTypeConcept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Departure">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Departure</seealso>
    let Departure = Prefixed_Name(bimerr_op, "Departure") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Driver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Driver represents the environmental factor from the outside world that stimulate occupants in their inside world to fulfill a physical, physiological or psychological need.</para>
    /// labels<para>Driver</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Driver">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Driver</seealso>
    let Driver = Prefixed_Name(bimerr_op, "Driver") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Driver related to events that could be causing a behavior.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Event">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Event</seealso>
    let Event = Prefixed_Name(bimerr_op, "Event") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent electrical equipments occupants interact with but do not have influence over indoor thermal conditions. These systems contribute to the energy bugdet estimation.</para>
    /// labels<para>Equipment</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Equipment">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Equipment</seealso>
    let Equipment = Prefixed_Name(bimerr_op, "Equipment") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Evening</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:TimeOfDay</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Evening">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Evening</seealso>
    let Evening = Prefixed_Name(bimerr_op, "Evening") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Fixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:OperationalModeConcept</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Fixed">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Fixed</seealso>
    let Fixed = Prefixed_Name(bimerr_op, "Fixed") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Driver related to the environmental conditions that could be causing a behavior.</para>
    /// labels<para>Environment</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Environment">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Environment</seealso>
    let Environment = Prefixed_Name(bimerr_op, "Environment") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:hasEnvironmentalParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates and occupant environmental driver with an environmental property like temperature or illuminance.</para>
    /// labels<para>has environmental parameter</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasEnvironmentalParameter">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasEnvironmentalParameter</seealso>
    let hasEnvironmentalParameter =
        Prefixed_Name(bimerr_op, "hasEnvironmentalParameter") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:hasUnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Relates an environmental parameter with a unit of measure.</para>
    /// labels<para>has unit of measure</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasUnitOfMeasure">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasUnitOfMeasure</seealso>
    let hasUnitOfMeasure = Prefixed_Name(bimerr_op, "hasUnitOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Fall</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:Season</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Fall">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Fall</seealso>
    let Fall = Prefixed_Name(bimerr_op, "Fall") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Glare</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:saref#Property</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Glare">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Glare</seealso>
    let Glare = Prefixed_Name(bimerr_op, "Glare") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Season</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Season of the year.</para>
    /// labels<para>Season</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Season">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Season</seealso>
    let Season = Prefixed_Name(bimerr_op, "Season") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Habit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Driver related to habits that could be causing a behavior.</para>
    /// labels<para>Habit</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Habit">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Habit</seealso>
    let Habit = Prefixed_Name(bimerr_op, "Habit") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Illuminance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:saref#Property</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Illuminance">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Illuminance</seealso>
    let Illuminance = Prefixed_Name(bimerr_op, "Illuminance") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:describedByFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property to relate an interaction with a formula describing the probability of occurance.</para>
    /// labels<para>described by formula</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#describedByFormula">http://bimerr.iot.linkeddata.es/def/occupancy-profile#describedByFormula</seealso>
    let describedByFormula =
        Prefixed_Name(bimerr_op, "describedByFormula") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:InteractionConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of interactions between occupants and systems.</para>
    /// labels<para>Interaction concept</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionConcept">http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionConcept</seealso>
    let InteractionConcept =
        Prefixed_Name(bimerr_op, "InteractionConcept") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:LeavingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>bimerr-op:Event</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LeavingRoom">http://bimerr.iot.linkeddata.es/def/occupancy-profile#LeavingRoom</seealso>
    let LeavingRoom = Prefixed_Name(bimerr_op, "LeavingRoom") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:controlValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship indicating the magnitud of a control action over a building system.</para>
    /// labels<para>control value</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#controlValue">http://bimerr.iot.linkeddata.es/def/occupancy-profile#controlValue</seealso>
    let controlValue = Prefixed_Name(bimerr_op, "controlValue") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:interactsOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship that describes an interaction between an occupant and a building component or system.</para>
    /// labels<para>interacts over</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#interactsOver">http://bimerr.iot.linkeddata.es/def/occupancy-profile#interactsOver</seealso>
    let interactsOver = Prefixed_Name(bimerr_op, "interactsOver") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:hasCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a formula with a coefficient.</para>
    /// labels<para>has coefficient</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasCoefficient">http://bimerr.iot.linkeddata.es/def/occupancy-profile#hasCoefficient</seealso>
    let hasCoefficient = Prefixed_Name(bimerr_op, "hasCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:InteractionScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggregation of SKOS concepts regarding the interaction type between occupants and space systems</para>
    /// labels<para>Interaction scheme</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionScheme">http://bimerr.iot.linkeddata.es/def/occupancy-profile#InteractionScheme</seealso>
    let InteractionScheme =
        Prefixed_Name(bimerr_op, "InteractionScheme") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:MarkovChainModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent instances of Markov chain models.</para>
    /// labels<para>Markov chain model</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#MarkovChainModel">http://bimerr.iot.linkeddata.es/def/occupancy-profile#MarkovChainModel</seealso>
    let MarkovChainModel = Prefixed_Name(bimerr_op, "MarkovChainModel") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:earlyOccurTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Earliest occurrence time of an event.</para>
    /// labels<para>early occur time</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#earlyOccurTime">http://bimerr.iot.linkeddata.es/def/occupancy-profile#earlyOccurTime</seealso>
    let earlyOccurTime = Prefixed_Name(bimerr_op, "earlyOccurTime") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The end time of an event or activity.</para>
    /// labels<para>end time</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#endTime">http://bimerr.iot.linkeddata.es/def/occupancy-profile#endTime</seealso>
    let endTime = Prefixed_Name(bimerr_op, "endTime") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:ASHRAEComfortEnvelop</para>
    /// </summary>
    /// <remarks>
    ///   <para>bimerr-op:ThermalNeed</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ASHRAEComfortEnvelop">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ASHRAEComfortEnvelop</seealso>
    let ASHRAEComfortEnvelop =
        Prefixed_Name(bimerr_op, "ASHRAEComfortEnvelop") |> PrefixedName

    /// <summary>
    ///   <para>bimerr-op:ThermalNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Range of parameter values where occupants do not feel thermal discomfort and therefore, they don't carry out any actions.</para>
    /// labels<para>Thermal Need</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#ThermalNeed">http://bimerr.iot.linkeddata.es/def/occupancy-profile#ThermalNeed</seealso>
    let ThermalNeed = Prefixed_Name(bimerr_op, "ThermalNeed") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:LinearFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent linear mathematical formulas</para>
    /// labels<para>Linear Formula</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#LinearFormula">http://bimerr.iot.linkeddata.es/def/occupancy-profile#LinearFormula</seealso>
    let LinearFormula = Prefixed_Name(bimerr_op, "LinearFormula") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:QuadraticFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class to represent quadratic mathematical formulas.</para>
    /// labels<para>Quadratic Formula</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#QuadraticFormula">http://bimerr.iot.linkeddata.es/def/occupancy-profile#QuadraticFormula</seealso>
    let QuadraticFormula = Prefixed_Name(bimerr_op, "QuadraticFormula") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:typicalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Typical occurrence time of an event.</para>
    /// labels<para>typical time</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalTime">http://bimerr.iot.linkeddata.es/def/occupancy-profile#typicalTime</seealso>
    let typicalTime = Prefixed_Name(bimerr_op, "typicalTime") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Average duration of an event.</para>
    /// labels<para>duration</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#duration">http://bimerr.iot.linkeddata.es/def/occupancy-profile#duration</seealso>
    let duration = Prefixed_Name(bimerr_op, "duration") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:Noise</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:saref#Property</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#Noise">http://bimerr.iot.linkeddata.es/def/occupancy-profile#Noise</seealso>
    let Noise = Prefixed_Name(bimerr_op, "Noise") |> PrefixedName
    /// <summary>
    ///   <para>bimerr-op:NonPhysicalNeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Non physical comfort needs (e.g. privacy, status, etc) that could influence a behavior.</para>
    /// labels<para>Non Physical Need</para></remarks>
    /// <seealso href="http://bimerr.iot.linkeddata.es/def/occupancy-profile#NonPhysicalNeed">http://bimerr.iot.linkeddata.es/def/occupancy-profile#NonPhysicalNeed</seealso>
    let NonPhysicalNeed = Prefixed_Name(bimerr_op, "NonPhysicalNeed") |> PrefixedName
