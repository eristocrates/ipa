namespace https.w3id.org.timebank.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tb =
    let _namespace_iri = Namespace_Iri tb |> NamespaceIRI
    /// <summary>
    ///   <para>tb:FearOfAnimals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Fear of animals. This can include dogs, cats, snakes, insects, etc.</para>
    /// labels<para>Fear of Animals</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfAnimals">https://w3id.org/timebank#FearOfAnimals</seealso>
    let FearOfAnimals = Prefixed_Name(tb, "FearOfAnimals") |> PrefixedName
    /// <summary>
    ///   <para>tb:Diabetes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A disorder characterized by high blood sugar levels during a long period.</para>
    /// labels<para>Diabetes Mellitus</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Diabetes">https://w3id.org/timebank#Diabetes</seealso>
    let Diabetes = Prefixed_Name(tb, "Diabetes") |> PrefixedName
    /// <summary>
    ///   <para>tb:Hypertension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The blood pressure is high in a long period.</para>
    /// labels<para>Hypertension</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Hypertension">https://w3id.org/timebank#Hypertension</seealso>
    let Hypertension = Prefixed_Name(tb, "Hypertension") |> PrefixedName
    /// <summary>
    ///   <para>tb:Hypotension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The blood pressure is low in a long period.</para>
    /// labels<para>Hypotension</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Hypotension">https://w3id.org/timebank#Hypotension</seealso>
    let Hypotension = Prefixed_Name(tb, "Hypotension") |> PrefixedName
    /// <summary>
    ///   <para>tb:Advice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Skills to provide particular services which requires some sort of education or training.</para>
    /// labels<para>Advice</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Advice">https://w3id.org/timebank#Advice</seealso>
    let Advice = Prefixed_Name(tb, "Advice") |> PrefixedName
    /// <summary>
    ///   <para>tb:Crafting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Crafting skills.</para>
    /// labels<para>Crafting</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Crafting">https://w3id.org/timebank#Crafting</seealso>
    let Crafting = Prefixed_Name(tb, "Crafting") |> PrefixedName
    /// <summary>
    ///   <para>tb:OfficeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to provide help with office related work.</para>
    /// labels<para>Office Work</para></remarks>
    /// <seealso href="https://w3id.org/timebank#OfficeWork">https://w3id.org/timebank#OfficeWork</seealso>
    let OfficeWork = Prefixed_Name(tb, "OfficeWork") |> PrefixedName
    /// <summary>
    ///   <para>tb:PeopleCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to provide care for people.</para>
    /// labels<para>Care for People</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PeopleCare">https://w3id.org/timebank#PeopleCare</seealso>
    let PeopleCare = Prefixed_Name(tb, "PeopleCare") |> PrefixedName
    /// <summary>
    ///   <para>tb:SalesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to help with selling and buying products.</para>
    /// labels<para>Sales Service</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SalesService">https://w3id.org/timebank#SalesService</seealso>
    let SalesService = Prefixed_Name(tb, "SalesService") |> PrefixedName
    /// <summary>
    ///   <para>tb:Transportation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to provide services related to transportation.</para>
    /// labels<para>TransportationServices</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Transportation">https://w3id.org/timebank#Transportation</seealso>
    let Transportation = Prefixed_Name(tb, "Transportation") |> PrefixedName
    /// <summary>
    ///   <para>tb:HygieneAssitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist someone on hygienical matters.</para>
    /// labels<para>Hygiene Assitance</para></remarks>
    /// <seealso href="https://w3id.org/timebank#HygieneAssitance">https://w3id.org/timebank#HygieneAssitance</seealso>
    let HygieneAssitance = Prefixed_Name(tb, "HygieneAssitance") |> PrefixedName
    /// <summary>
    ///   <para>tb:Allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A collection of allergies, which is caused by hypersensitivity of the immune system.</para>
    /// labels<para>Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Allergy">https://w3id.org/timebank#Allergy</seealso>
    let Allergy = Prefixed_Name(tb, "Allergy") |> PrefixedName

    /// <summary>
    ///   <para>tb:PhysicalInconvenience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This is a collection of physical disorders that negatively affect a person's daily life.</para>
    /// labels<para>Physical Inconvenience</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PhysicalInconvenience">https://w3id.org/timebank#PhysicalInconvenience</seealso>
    let PhysicalInconvenience =
        Prefixed_Name(tb, "PhysicalInconvenience") |> PrefixedName

    /// <summary>
    ///   <para>tb:DrivingTractors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Experience in driving tractors.</para>
    /// labels<para>Driving Tractors</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingTractors">https://w3id.org/timebank#DrivingTractors</seealso>
    let DrivingTractors = Prefixed_Name(tb, "DrivingTractors") |> PrefixedName
    /// <summary>
    ///   <para>tb:DrivingTrucks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Experience in driving with trucks.</para>
    /// labels<para>Driving Trucks</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingTrucks">https://w3id.org/timebank#DrivingTrucks</seealso>
    let DrivingTrucks = Prefixed_Name(tb, "DrivingTrucks") |> PrefixedName
    /// <summary>
    ///   <para>tb:CognitiveImpairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A person with cognitive impairment can't think and remember things clearly.</para>
    /// labels<para>Cognitive Impairment</para></remarks>
    /// <seealso href="https://w3id.org/timebank#CognitiveImpairment">https://w3id.org/timebank#CognitiveImpairment</seealso>
    let CognitiveImpairment = Prefixed_Name(tb, "CognitiveImpairment") |> PrefixedName
    /// <summary>
    ///   <para>tb:Depression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A person with depression has a depressed mood over a long period and may even have thoughts of suicide.</para>
    /// labels<para>Depression</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Depression">https://w3id.org/timebank#Depression</seealso>
    let Depression = Prefixed_Name(tb, "Depression") |> PrefixedName
    /// <summary>
    ///   <para>tb:Dogs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Indicates that dogs might be present.</para>
    /// labels<para>Dogs</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Dogs">https://w3id.org/timebank#Dogs</seealso>
    let Dogs = Prefixed_Name(tb, "Dogs") |> PrefixedName
    /// <summary>
    ///   <para>tb:DrivingLightVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Experience in driving light vehicles.</para>
    /// labels<para>Driving Light Vehicles</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingLightVehicles">https://w3id.org/timebank#DrivingLightVehicles</seealso>
    let DrivingLightVehicles = Prefixed_Name(tb, "DrivingLightVehicles") |> PrefixedName
    /// <summary>
    ///   <para>tb:DrivingVans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Experience in driving vans.</para>
    /// labels<para>Driving Vans</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingVans">https://w3id.org/timebank#DrivingVans</seealso>
    let DrivingVans = Prefixed_Name(tb, "DrivingVans") |> PrefixedName
    /// <summary>
    ///   <para>tb:DrivingHeavyVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Experience in driving heavy vehicles.</para>
    /// labels<para>Driving Heavy Vehicles</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingHeavyVehicles">https://w3id.org/timebank#DrivingHeavyVehicles</seealso>
    let DrivingHeavyVehicles = Prefixed_Name(tb, "DrivingHeavyVehicles") |> PrefixedName
    /// <summary>
    ///   <para>tb:isExpectedDurationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead.</para>
    /// labels<para>is expected duration of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isExpectedDurationOf">https://w3id.org/timebank#isExpectedDurationOf</seealso>
    let isExpectedDurationOf = Prefixed_Name(tb, "isExpectedDurationOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a Timebank user suffers from a certain limitation.</para>
    /// labels<para>has limitation</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasLimitation">https://w3id.org/timebank#hasLimitation</seealso>
    let hasLimitation = Prefixed_Name(tb, "hasLimitation") |> PrefixedName
    /// <summary>
    ///   <para>tb:isLimitationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a certain limitation applies to the Timebank user.</para>
    /// labels<para>is limitation of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isLimitationOf">https://w3id.org/timebank#isLimitationOf</seealso>
    let isLimitationOf = Prefixed_Name(tb, "isLimitationOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasNotEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a certain Location Specifier has a specific environmental factor.</para>
    /// labels<para>has not environment</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasNotEnvironment">https://w3id.org/timebank#hasNotEnvironment</seealso>
    let hasNotEnvironment = Prefixed_Name(tb, "hasNotEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>tb:isNotEnvironmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a certain Location Specifier has a specific environmental factor.</para>
    /// labels<para>is not environment of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isNotEnvironmentOf">https://w3id.org/timebank#isNotEnvironmentOf</seealso>
    let isNotEnvironmentOf = Prefixed_Name(tb, "isNotEnvironmentOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:isOriginatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the user is the originator of the request.</para>
    /// labels<para>is originator of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isOriginatorOf">https://w3id.org/timebank#isOriginatorOf</seealso>
    let isOriginatorOf = Prefixed_Name(tb, "isOriginatorOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the severity of a limitation.</para>
    /// labels<para>has severity</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasSeverity">https://w3id.org/timebank#hasSeverity</seealso>
    let hasSeverity = Prefixed_Name(tb, "hasSeverity") |> PrefixedName
    /// <summary>
    ///   <para>tb:isSeverityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the severity of a limitation.</para>
    /// labels<para>is severity of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isSeverityOf">https://w3id.org/timebank#isSeverityOf</seealso>
    let isSeverityOf = Prefixed_Name(tb, "isSeverityOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the Skill of a certain Timebank user.</para>
    /// labels<para>has skill</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasSkill">https://w3id.org/timebank#hasSkill</seealso>
    let hasSkill = Prefixed_Name(tb, "hasSkill") |> PrefixedName
    /// <summary>
    ///   <para>tb:isSkillLevelOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the proficiency level of a skill.</para>
    /// labels<para>is skill level of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isSkillLevelOf">https://w3id.org/timebank#isSkillLevelOf</seealso>
    let isSkillLevelOf = Prefixed_Name(tb, "isSkillLevelOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:isStatusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Every request can have at most one status assigned to it.</para>
    /// labels<para>is status of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isStatusOf">https://w3id.org/timebank#isStatusOf</seealso>
    let isStatusOf = Prefixed_Name(tb, "isStatusOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasSubPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street.</para>
    /// labels<para>has sub-part</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasSubPart">https://w3id.org/timebank#hasSubPart</seealso>
    let hasSubPart = Prefixed_Name(tb, "hasSubPart") |> PrefixedName
    /// <summary>
    ///   <para>tb:isTimeBalanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the current time-balance of a Timebank user.</para>
    /// labels<para>is time-balance of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isTimeBalanceOf">https://w3id.org/timebank#isTimeBalanceOf</seealso>
    let isTimeBalanceOf = Prefixed_Name(tb, "isTimeBalanceOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasTimeWindow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time window in which the request can/should be completed.</para>
    /// labels<para>has time window</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasTimeWindow">https://w3id.org/timebank#hasTimeWindow</seealso>
    let hasTimeWindow = Prefixed_Name(tb, "hasTimeWindow") |> PrefixedName
    /// <summary>
    ///   <para>tb:isTimeWindowOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time window in which the request can/should be completed.</para>
    /// labels<para>is time window of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isTimeWindowOf">https://w3id.org/timebank#isTimeWindowOf</seealso>
    let isTimeWindowOf = Prefixed_Name(tb, "isTimeWindowOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:isAcceptanceDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time and date when the Timebank request was accepted by the assigned helper.</para>
    /// labels<para>is acceptance date of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAcceptanceDateOf">https://w3id.org/timebank#isAcceptanceDateOf</seealso>
    let isAcceptanceDateOf = Prefixed_Name(tb, "isAcceptanceDateOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:isAvailabilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the availability of a Timebank user to act as a helper for a Timebank request.</para>
    /// labels<para>is availability of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAvailabilityOf">https://w3id.org/timebank#isAvailabilityOf</seealso>
    let isAvailabilityOf = Prefixed_Name(tb, "isAvailabilityOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:isAvailableOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the availability of a Timebank user to act as a helper for a Timebank request.</para>
    /// labels<para>is available on</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAvailableOn">https://w3id.org/timebank#isAvailableOn</seealso>
    let isAvailableOn = Prefixed_Name(tb, "isAvailableOn") |> PrefixedName
    /// <summary>
    ///   <para>tb:isCancellationDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time and date when the Timebank request was cancelled.</para>
    /// labels<para>is cancellation date of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isCancellationDateOf">https://w3id.org/timebank#isCancellationDateOf</seealso>
    let isCancellationDateOf = Prefixed_Name(tb, "isCancellationDateOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:isCancelledOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time and date when the Timebank request was cancelled.</para>
    /// labels<para>is cancelled on</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isCancelledOn">https://w3id.org/timebank#isCancelledOn</seealso>
    let isCancelledOn = Prefixed_Name(tb, "isCancelledOn") |> PrefixedName
    /// <summary>
    ///   <para>tb:isCompletedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time and date of the completion of a Timebank request.</para>
    /// labels<para>is completed on</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isCompletedOn">https://w3id.org/timebank#isCompletedOn</seealso>
    let isCompletedOn = Prefixed_Name(tb, "isCompletedOn") |> PrefixedName
    /// <summary>
    ///   <para>tb:isCompletionDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time and date of the completion of a Timebank request.</para>
    /// labels<para>is completion date of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isCompletionDateOf">https://w3id.org/timebank#isCompletionDateOf</seealso>
    let isCompletionDateOf = Prefixed_Name(tb, "isCompletionDateOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:isPublicationDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time and date of the publication of a Timebank request.</para>
    /// labels<para>is publication date of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isPublicationDateOf">https://w3id.org/timebank#isPublicationDateOf</seealso>
    let isPublicationDateOf = Prefixed_Name(tb, "isPublicationDateOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:isPublishedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time and date of the publication of a Timebank request.</para>
    /// labels<para>is published on</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isPublishedOn">https://w3id.org/timebank#isPublishedOn</seealso>
    let isPublishedOn = Prefixed_Name(tb, "isPublishedOn") |> PrefixedName
    /// <summary>
    ///   <para>tb:isRepetitionDayOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a time interval repeats on the specified weekdays.</para>
    /// labels<para>is repetition date of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isRepetitionDayOf">https://w3id.org/timebank#isRepetitionDayOf</seealso>
    let isRepetitionDayOf = Prefixed_Name(tb, "isRepetitionDayOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:repeatsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a time interval repeats on the specified weekdays.</para>
    /// labels<para>repeats on</para></remarks>
    /// <seealso href="https://w3id.org/timebank#repeatsOn">https://w3id.org/timebank#repeatsOn</seealso>
    let repeatsOn = Prefixed_Name(tb, "repeatsOn") |> PrefixedName
    /// <summary>
    ///   <para>tb:FearOfDark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Fear of dark places.</para>
    /// labels<para>Fear of Dark</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfDark">https://w3id.org/timebank#FearOfDark</seealso>
    let FearOfDark = Prefixed_Name(tb, "FearOfDark") |> PrefixedName
    /// <summary>
    ///   <para>tb:CraftingClothes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The ability to craft any kind of clothes.</para>
    /// labels<para>Crafting Clothes</para></remarks>
    /// <seealso href="https://w3id.org/timebank#CraftingClothes">https://w3id.org/timebank#CraftingClothes</seealso>
    let CraftingClothes = Prefixed_Name(tb, "CraftingClothes") |> PrefixedName
    /// <summary>
    ///   <para>tb:SlipperyFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The person needs to be aware of slippery floor.</para>
    /// labels<para>Splippery Floor</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SlipperyFloor">https://w3id.org/timebank#SlipperyFloor</seealso>
    let SlipperyFloor = Prefixed_Name(tb, "SlipperyFloor") |> PrefixedName
    /// <summary>
    ///   <para>tb:Stairs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The person might have to climb stairs to complete the task.</para>
    /// labels<para>Stairs</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Stairs">https://w3id.org/timebank#Stairs</seealso>
    let Stairs = Prefixed_Name(tb, "Stairs") |> PrefixedName
    /// <summary>
    ///   <para>tb:isSkillOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the Skill of a certain Timebank user.</para>
    /// labels<para>is skill of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isSkillOf">https://w3id.org/timebank#isSkillOf</seealso>
    let isSkillOf = Prefixed_Name(tb, "isSkillOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasSkillLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the proficiency level of a skill.</para>
    /// labels<para>has skill level</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasSkillLevel">https://w3id.org/timebank#hasSkillLevel</seealso>
    let hasSkillLevel = Prefixed_Name(tb, "hasSkillLevel") |> PrefixedName
    /// <summary>
    ///   <para>tb:FearOfHeights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Fear or phobia of heights.</para>
    /// labels<para>Fear of Heights</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfHeights">https://w3id.org/timebank#FearOfHeights</seealso>
    let FearOfHeights = Prefixed_Name(tb, "FearOfHeights") |> PrefixedName
    /// <summary>
    ///   <para>tb:Knitting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Specialized in knitting clothes.</para>
    /// labels<para>Knitting</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Knitting">https://w3id.org/timebank#Knitting</seealso>
    let Knitting = Prefixed_Name(tb, "Knitting") |> PrefixedName
    /// <summary>
    ///   <para>tb:GlutenAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Allergies to grains with gluten such as wheat, barley, rye, and oats.</para>
    /// labels<para>Gluten Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#GlutenAllergy">https://w3id.org/timebank#GlutenAllergy</seealso>
    let GlutenAllergy = Prefixed_Name(tb, "GlutenAllergy") |> PrefixedName
    /// <summary>
    ///   <para>tb:isSubPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street.</para>
    /// labels<para>is sub-part of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isSubPartOf">https://w3id.org/timebank#isSubPartOf</seealso>
    let isSubPartOf = Prefixed_Name(tb, "isSubPartOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:HeartDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A condition of diseases that negatively affect one's heart such as blood vessel diseases and heart rhythm problems.</para>
    /// labels<para>Heart Diseases</para></remarks>
    /// <seealso href="https://w3id.org/timebank#HeartDisease">https://w3id.org/timebank#HeartDisease</seealso>
    let HeartDisease = Prefixed_Name(tb, "HeartDisease") |> PrefixedName
    /// <summary>
    ///   <para>tb:StrokeHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>It indicates a person once had a storke. A stroke happens when blood flow to the brain is blocked and oxygen for the brain cells is insufficient, which could leads to cell death.</para>
    /// labels<para>History of Strokes</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StrokeHistory">https://w3id.org/timebank#StrokeHistory</seealso>
    let StrokeHistory = Prefixed_Name(tb, "StrokeHistory") |> PrefixedName

    /// <summary>
    ///   <para>tb:hasAccreditedDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead.</para>
    /// labels<para>has accredited duration</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasAccreditedDuration">https://w3id.org/timebank#hasAccreditedDuration</seealso>
    let hasAccreditedDuration =
        Prefixed_Name(tb, "hasAccreditedDuration") |> PrefixedName

    /// <summary>
    ///   <para>tb:hasOriginator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the request has the specific originator.</para>
    /// labels<para>has originator</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasOriginator">https://w3id.org/timebank#hasOriginator</seealso>
    let hasOriginator = Prefixed_Name(tb, "hasOriginator") |> PrefixedName
    /// <summary>
    ///   <para>tb:rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The rating given by the originator of a request to the assigned helper for completing the specific request.</para>
    /// labels<para>rating</para></remarks>
    /// <seealso href="https://w3id.org/timebank#rating">https://w3id.org/timebank#rating</seealso>
    let rating = Prefixed_Name(tb, "rating") |> PrefixedName
    /// <summary>
    ///   <para>tb:StatusAssigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that a request is assigned to a helper but not yet completed.</para>
    /// labels<para>Status: Assigned</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StatusAssigned">https://w3id.org/timebank#StatusAssigned</seealso>
    let StatusAssigned = Prefixed_Name(tb, "StatusAssigned") |> PrefixedName
    /// <summary>
    ///   <para>tb:StatusCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that a request is cancelled and no helper is needed anymore.</para>
    /// labels<para>Status: Cancelled</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StatusCancelled">https://w3id.org/timebank#StatusCancelled</seealso>
    let StatusCancelled = Prefixed_Name(tb, "StatusCancelled") |> PrefixedName
    /// <summary>
    ///   <para>tb:StatusOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that a request is open and no helper is assigned to it.</para>
    /// labels<para>Status: Open</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StatusOpen">https://w3id.org/timebank#StatusOpen</seealso>
    let StatusOpen = Prefixed_Name(tb, "StatusOpen") |> PrefixedName
    /// <summary>
    ///   <para>tb:Tools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Tools can be provided.</para>
    /// labels<para>Tools</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Tools">https://w3id.org/timebank#Tools</seealso>
    let Tools = Prefixed_Name(tb, "Tools") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasTimeBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the current time-balance of a Timebank user.</para>
    /// labels<para>has time-balance</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasTimeBalance">https://w3id.org/timebank#hasTimeBalance</seealso>
    let hasTimeBalance = Prefixed_Name(tb, "hasTimeBalance") |> PrefixedName
    /// <summary>
    ///   <para>tb:Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Water outlet is available.</para>
    /// labels<para>Water</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Water">https://w3id.org/timebank#Water</seealso>
    let Water = Prefixed_Name(tb, "Water") |> PrefixedName
    /// <summary>
    ///   <para>tb:accepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a user who is willing to help accepted the request.</para>
    /// labels<para>accepts</para></remarks>
    /// <seealso href="https://w3id.org/timebank#accepts">https://w3id.org/timebank#accepts</seealso>
    let accepts = Prefixed_Name(tb, "accepts") |> PrefixedName
    /// <summary>
    ///   <para>tb:isAcceptedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a request is accepted by a user who is willing to help completing the request.</para>
    /// labels<para>is accepted by</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAcceptedBy">https://w3id.org/timebank#isAcceptedBy</seealso>
    let isAcceptedBy = Prefixed_Name(tb, "isAcceptedBy") |> PrefixedName
    /// <summary>
    ///   <para>tb:endsRepeatingOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a time-interval is repeating until this time and date.</para>
    /// labels<para>ends repeating on</para></remarks>
    /// <seealso href="https://w3id.org/timebank#endsRepeatingOn">https://w3id.org/timebank#endsRepeatingOn</seealso>
    let endsRepeatingOn = Prefixed_Name(tb, "endsRepeatingOn") |> PrefixedName

    /// <summary>
    ///   <para>tb:isRepeatingEndpointOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a specific time and date marks the end of a repetition of a time-interval.</para>
    /// labels<para>is repeating endpoint of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isRepeatingEndpointOf">https://w3id.org/timebank#isRepeatingEndpointOf</seealso>
    let isRepeatingEndpointOf =
        Prefixed_Name(tb, "isRepeatingEndpointOf") |> PrefixedName

    /// <summary>
    ///   <para>tb:excludesUserByLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to describe that a request exludes helpers having a certain limitation.</para>
    /// labels<para>excludes user by limitation</para></remarks>
    /// <seealso href="https://w3id.org/timebank#excludesUserByLimitation">https://w3id.org/timebank#excludesUserByLimitation</seealso>
    let excludesUserByLimitation =
        Prefixed_Name(tb, "excludesUserByLimitation") |> PrefixedName

    /// <summary>
    ///   <para>tb:excludesUserFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to describe that a certain limitation excludes certain helpers from the request.</para>
    /// labels<para>excludes user from</para></remarks>
    /// <seealso href="https://w3id.org/timebank#excludesUserFrom">https://w3id.org/timebank#excludesUserFrom</seealso>
    let excludesUserFrom = Prefixed_Name(tb, "excludesUserFrom") |> PrefixedName
    /// <summary>
    ///   <para>tb:isAccreditedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead.</para>
    /// labels<para>is accredited to</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAccreditedTo">https://w3id.org/timebank#isAccreditedTo</seealso>
    let isAccreditedTo = Prefixed_Name(tb, "isAccreditedTo") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a certain Location Specifier has a specific environmental factor.</para>
    /// labels<para>has environment</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasEnvironment">https://w3id.org/timebank#hasEnvironment</seealso>
    let hasEnvironment = Prefixed_Name(tb, "hasEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>tb:isEnvironmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a certain Location Specifier has a specific environmental factor.</para>
    /// labels<para>is environment of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isEnvironmentOf">https://w3id.org/timebank#isEnvironmentOf</seealso>
    let isEnvironmentOf = Prefixed_Name(tb, "isEnvironmentOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasExpectedDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead.</para>
    /// labels<para>has expected duration</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasExpectedDuration">https://w3id.org/timebank#hasExpectedDuration</seealso>
    let hasExpectedDuration = Prefixed_Name(tb, "hasExpectedDuration") |> PrefixedName
    /// <summary>
    ///   <para>tb:Rheumatism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Diseases that causes chronic pain in joints and muscles such as back, shoulder and neck.</para>
    /// labels<para>Rheumatism</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Rheumatism">https://w3id.org/timebank#Rheumatism</seealso>
    let Rheumatism = Prefixed_Name(tb, "Rheumatism") |> PrefixedName
    /// <summary>
    ///   <para>tb:FoodService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to provide services related to food products.</para>
    /// labels<para>Food Service</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FoodService">https://w3id.org/timebank#FoodService</seealso>
    let FoodService = Prefixed_Name(tb, "FoodService") |> PrefixedName
    /// <summary>
    ///   <para>tb:PersonalService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Personal services which include hygiene and daily care.</para>
    /// labels<para>Personal Service</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PersonalService">https://w3id.org/timebank#PersonalService</seealso>
    let PersonalService = Prefixed_Name(tb, "PersonalService") |> PrefixedName
    /// <summary>
    ///   <para>tb:Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to help with maintenance of equipment.</para>
    /// labels<para>Maintenance</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Maintenance">https://w3id.org/timebank#Maintenance</seealso>
    let Maintenance = Prefixed_Name(tb, "Maintenance") |> PrefixedName
    /// <summary>
    ///   <para>tb:Repair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Skill to repair equipment and facilities.</para>
    /// labels<para>Repair</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Repair">https://w3id.org/timebank#Repair</seealso>
    let Repair = Prefixed_Name(tb, "Repair") |> PrefixedName
    /// <summary>
    ///   <para>tb:Recreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to provide services related to recreation.</para>
    /// labels<para>Recreation</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Recreation">https://w3id.org/timebank#Recreation</seealso>
    let Recreation = Prefixed_Name(tb, "Recreation") |> PrefixedName
    /// <summary>
    ///   <para>tb:DressingAssistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist someone with dressing.</para>
    /// labels<para>Dressing Assistance</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DressingAssistance">https://w3id.org/timebank#DressingAssistance</seealso>
    let DressingAssistance = Prefixed_Name(tb, "DressingAssistance") |> PrefixedName
    /// <summary>
    ///   <para>tb:Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The level can be low, medium, or high.</para>
    /// labels<para>Level</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Level">https://w3id.org/timebank#Level</seealso>
    let Level = Prefixed_Name(tb, "Level") |> PrefixedName
    /// <summary>
    ///   <para>tb:StatusClosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that a request is closed and that no helper is needed anymore.</para>
    /// labels<para>Status: Closed</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StatusClosed">https://w3id.org/timebank#StatusClosed</seealso>
    let StatusClosed = Prefixed_Name(tb, "StatusClosed") |> PrefixedName
    /// <summary>
    ///   <para>tb:HairCutting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Ability to cut someone else's hair.</para>
    /// labels<para>Hair Cutting</para></remarks>
    /// <seealso href="https://w3id.org/timebank#HairCutting">https://w3id.org/timebank#HairCutting</seealso>
    let HairCutting = Prefixed_Name(tb, "HairCutting") |> PrefixedName
    /// <summary>
    ///   <para>tb:MentalDisorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Disorders that affect the mental states of a person.</para>
    /// labels<para>Mental Disorder</para></remarks>
    /// <seealso href="https://w3id.org/timebank#MentalDisorder">https://w3id.org/timebank#MentalDisorder</seealso>
    let MentalDisorder = Prefixed_Name(tb, "MentalDisorder") |> PrefixedName
    /// <summary>
    ///   <para>tb:CommonDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A collection of diseases that are common, especially for elderly people</para>
    /// labels<para>Common Disease</para></remarks>
    /// <seealso href="https://w3id.org/timebank#CommonDisease">https://w3id.org/timebank#CommonDisease</seealso>
    let CommonDisease = Prefixed_Name(tb, "CommonDisease") |> PrefixedName
    /// <summary>
    ///   <para>tb:DrivingWithTrailers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Experience in driving with trailers.</para>
    /// labels<para>Driving with Trailers</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingWithTrailers">https://w3id.org/timebank#DrivingWithTrailers</seealso>
    let DrivingWithTrailers = Prefixed_Name(tb, "DrivingWithTrailers") |> PrefixedName
    /// <summary>
    ///   <para>tb:PsychoticEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A person with psychotic episode can not tell the difference between the reality and unreality and may have difficulty with social activities in daily life.</para>
    /// labels<para>Psychotic Episode</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PsychoticEpisode">https://w3id.org/timebank#PsychoticEpisode</seealso>
    let PsychoticEpisode = Prefixed_Name(tb, "PsychoticEpisode") |> PrefixedName

    /// <summary>
    ///   <para>tb:ClimbingStairsDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The person has difficulty in climbing up stairs.</para>
    /// labels<para>Difficulty in Climbing Stairs</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ClimbingStairsDifficulty">https://w3id.org/timebank#ClimbingStairsDifficulty</seealso>
    let ClimbingStairsDifficulty =
        Prefixed_Name(tb, "ClimbingStairsDifficulty") |> PrefixedName

    /// <summary>
    ///   <para>tb:DressingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The person has difficulties dressing himself.</para>
    /// labels<para>Dressing Problem</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DressingProblem">https://w3id.org/timebank#DressingProblem</seealso>
    let DressingProblem = Prefixed_Name(tb, "DressingProblem") |> PrefixedName
    /// <summary>
    ///   <para>tb:DrugAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An allergy to drugs.</para>
    /// labels<para>Drug Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrugAllergy">https://w3id.org/timebank#DrugAllergy</seealso>
    let DrugAllergy = Prefixed_Name(tb, "DrugAllergy") |> PrefixedName
    /// <summary>
    ///   <para>tb:Mopping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist with mopping floors, etc.</para>
    /// labels<para>Mopping</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Mopping">https://w3id.org/timebank#Mopping</seealso>
    let Mopping = Prefixed_Name(tb, "Mopping") |> PrefixedName
    /// <summary>
    ///   <para>tb:WalkingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The person has difficulties walking.</para>
    /// labels<para>Walking Problem</para></remarks>
    /// <seealso href="https://w3id.org/timebank#WalkingProblem">https://w3id.org/timebank#WalkingProblem</seealso>
    let WalkingProblem = Prefixed_Name(tb, "WalkingProblem") |> PrefixedName
    /// <summary>
    ///   <para>tb:DancingCompanion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The ability to act as a dancing companion.</para>
    /// labels<para>Dancing Companion</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DancingCompanion">https://w3id.org/timebank#DancingCompanion</seealso>
    let DancingCompanion = Prefixed_Name(tb, "DancingCompanion") |> PrefixedName
    /// <summary>
    ///   <para>tb:PerformingMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to entertain others by performing music.</para>
    /// labels<para>Performing Music</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PerformingMusic">https://w3id.org/timebank#PerformingMusic</seealso>
    let PerformingMusic = Prefixed_Name(tb, "PerformingMusic") |> PrefixedName
    /// <summary>
    ///   <para>tb:TravelCompanion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The ability to act as a travel companion.</para>
    /// labels<para>Travel Companion</para></remarks>
    /// <seealso href="https://w3id.org/timebank#TravelCompanion">https://w3id.org/timebank#TravelCompanion</seealso>
    let TravelCompanion = Prefixed_Name(tb, "TravelCompanion") |> PrefixedName
    /// <summary>
    ///   <para>tb:EnvironmentalAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>An allergy to something in the environment such as dust mites, pollen, pet hair and cigarette smoke.</para>
    /// labels<para>Environmental Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#EnvironmentalAllergy">https://w3id.org/timebank#EnvironmentalAllergy</seealso>
    let EnvironmentalAllergy = Prefixed_Name(tb, "EnvironmentalAllergy") |> PrefixedName
    /// <summary>
    ///   <para>tb:DrivingCars</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Experience in driving cars.</para>
    /// labels<para>Driving Cars</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingCars">https://w3id.org/timebank#DrivingCars</seealso>
    let DrivingCars = Prefixed_Name(tb, "DrivingCars") |> PrefixedName
    /// <summary>
    ///   <para>tb:Electricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Electric outlet available.</para>
    /// labels<para>Electricity</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Electricity">https://w3id.org/timebank#Electricity</seealso>
    let Electricity = Prefixed_Name(tb, "Electricity") |> PrefixedName
    /// <summary>
    ///   <para>tb:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A user of the Timebank.</para>
    /// labels<para>User</para></remarks>
    /// <seealso href="https://w3id.org/timebank#User">https://w3id.org/timebank#User</seealso>
    let User = Prefixed_Name(tb, "User") |> PrefixedName
    /// <summary>
    ///   <para>tb:isAcceptedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the time and date when the Timebank request was accepted by the assigned helper.</para>
    /// labels<para>is accepted on</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAcceptedOn">https://w3id.org/timebank#isAcceptedOn</seealso>
    let isAcceptedOn = Prefixed_Name(tb, "isAcceptedOn") |> PrefixedName
    /// <summary>
    ///   <para>tb:isAdressPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An address part that describes the location of a specific request.</para>
    /// labels<para>is adress part of</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAdressPartOf">https://w3id.org/timebank#isAdressPartOf</seealso>
    let isAdressPartOf = Prefixed_Name(tb, "isAdressPartOf") |> PrefixedName
    /// <summary>
    ///   <para>tb:Games</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to participate in board games, card games, etc.</para>
    /// labels<para>Games</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Games">https://w3id.org/timebank#Games</seealso>
    let Games = Prefixed_Name(tb, "Games") |> PrefixedName
    /// <summary>
    ///   <para>tb:Assembling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assemble items like furniture and other things.</para>
    /// labels<para>Assembling</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Assembling">https://w3id.org/timebank#Assembling</seealso>
    let Assembling = Prefixed_Name(tb, "Assembling") |> PrefixedName

    /// <summary>
    ///   <para>tb:AccessibleByPublicTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The location is accessible by public transport.</para>
    /// labels<para>Accessible by Public Transport</para></remarks>
    /// <seealso href="https://w3id.org/timebank#AccessibleByPublicTransport">https://w3id.org/timebank#AccessibleByPublicTransport</seealso>
    let AccessibleByPublicTransport =
        Prefixed_Name(tb, "AccessibleByPublicTransport") |> PrefixedName

    /// <summary>
    ///   <para>tb:TransportationAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Transportation necessary to complete the task can be provided.</para>
    /// labels<para>Transportation Available</para></remarks>
    /// <seealso href="https://w3id.org/timebank#TransportationAvailable">https://w3id.org/timebank#TransportationAvailable</seealso>
    let TransportationAvailable =
        Prefixed_Name(tb, "TransportationAvailable") |> PrefixedName

    /// <summary>
    ///   <para>tb:WeatherConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The place is difficult to access during bad weather (e.g. snow).</para>
    /// labels<para>Weather Constraint</para></remarks>
    /// <seealso href="https://w3id.org/timebank#WeatherConstraint">https://w3id.org/timebank#WeatherConstraint</seealso>
    let WeatherConstraint = Prefixed_Name(tb, "WeatherConstraint") |> PrefixedName
    /// <summary>
    ///   <para>tb:LegalAdvice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Specialized in providing legal assistance.</para>
    /// labels<para>Legal Advice</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LegalAdvice">https://w3id.org/timebank#LegalAdvice</seealso>
    let LegalAdvice = Prefixed_Name(tb, "LegalAdvice") |> PrefixedName
    /// <summary>
    ///   <para>tb:ComputerRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to fix problems with computers.</para>
    /// labels<para>Computer Repair</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ComputerRepair">https://w3id.org/timebank#ComputerRepair</seealso>
    let ComputerRepair = Prefixed_Name(tb, "ComputerRepair") |> PrefixedName
    /// <summary>
    ///   <para>tb:Catering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist with catering requirements.</para>
    /// labels<para>Catering</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Catering">https://w3id.org/timebank#Catering</seealso>
    let Catering = Prefixed_Name(tb, "Catering") |> PrefixedName
    /// <summary>
    ///   <para>tb:Dishwashing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist with washing dishes.</para>
    /// labels<para>Dishwashing</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Dishwashing">https://w3id.org/timebank#Dishwashing</seealso>
    let Dishwashing = Prefixed_Name(tb, "Dishwashing") |> PrefixedName
    /// <summary>
    ///   <para>tb:Mowing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist with mowing the grass.</para>
    /// labels<para>Mowing</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Mowing">https://w3id.org/timebank#Mowing</seealso>
    let Mowing = Prefixed_Name(tb, "Mowing") |> PrefixedName
    /// <summary>
    ///   <para>tb:Pruning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist with pruning shrubs and twigs.</para>
    /// labels<para>Pruning</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Pruning">https://w3id.org/timebank#Pruning</seealso>
    let Pruning = Prefixed_Name(tb, "Pruning") |> PrefixedName
    /// <summary>
    ///   <para>tb:PoorHearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Having difficulties hearing voices clearly.</para>
    /// labels<para>Poor Hearing</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PoorHearing">https://w3id.org/timebank#PoorHearing</seealso>
    let PoorHearing = Prefixed_Name(tb, "PoorHearing") |> PrefixedName
    /// <summary>
    ///   <para>tb:SensitiveSkin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Skins are too sensitive to a wide variety of factors such as weather, pets, stress and dust.</para>
    /// labels<para>Sensitive Skin</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SensitiveSkin">https://w3id.org/timebank#SensitiveSkin</seealso>
    let SensitiveSkin = Prefixed_Name(tb, "SensitiveSkin") |> PrefixedName
    /// <summary>
    ///   <para>tb:ComputerProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to assist with processing data computers.</para>
    /// labels<para>Computer Processing</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ComputerProcessing">https://w3id.org/timebank#ComputerProcessing</seealso>
    let ComputerProcessing = Prefixed_Name(tb, "ComputerProcessing") |> PrefixedName
    /// <summary>
    ///   <para>tb:InventoryManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist with inventory management.</para>
    /// labels<para>Inventory Management</para></remarks>
    /// <seealso href="https://w3id.org/timebank#InventoryManagement">https://w3id.org/timebank#InventoryManagement</seealso>
    let InventoryManagement = Prefixed_Name(tb, "InventoryManagement") |> PrefixedName
    /// <summary>
    ///   <para>tb:RecordingNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to assist with recording notes and entries.</para>
    /// labels<para>Recording Notes</para></remarks>
    /// <seealso href="https://w3id.org/timebank#RecordingNotes">https://w3id.org/timebank#RecordingNotes</seealso>
    let RecordingNotes = Prefixed_Name(tb, "RecordingNotes") |> PrefixedName
    /// <summary>
    ///   <para>tb:Writing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to assist with written work, like writing or reading a letter.</para>
    /// labels<para>Writing</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Writing">https://w3id.org/timebank#Writing</seealso>
    let Writing = Prefixed_Name(tb, "Writing") |> PrefixedName
    /// <summary>
    ///   <para>tb:MentallyIllCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to provide care for the mentally ill.</para>
    /// labels<para>Care Mentally Ill People</para></remarks>
    /// <seealso href="https://w3id.org/timebank#MentallyIllCare">https://w3id.org/timebank#MentallyIllCare</seealso>
    let MentallyIllCare = Prefixed_Name(tb, "MentallyIllCare") |> PrefixedName

    /// <summary>
    ///   <para>tb:PhysicallyDisabledCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to provide care for the physically disabled.</para>
    /// labels<para>Care for Physically Disabled</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PhysicallyDisabledCare">https://w3id.org/timebank#PhysicallyDisabledCare</seealso>
    let PhysicallyDisabledCare =
        Prefixed_Name(tb, "PhysicallyDisabledCare") |> PrefixedName

    /// <summary>
    ///   <para>tb:Sewing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Specialized in sewing clothes.</para>
    /// labels<para>Sewing</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Sewing">https://w3id.org/timebank#Sewing</seealso>
    let Sewing = Prefixed_Name(tb, "Sewing") |> PrefixedName
    /// <summary>
    ///   <para>tb:Tailoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Specialized in providing tailoring services.</para>
    /// labels<para>Tailoring</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Tailoring">https://w3id.org/timebank#Tailoring</seealso>
    let Tailoring = Prefixed_Name(tb, "Tailoring") |> PrefixedName
    /// <summary>
    ///   <para>tb:MilkAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Allergy to milk.</para>
    /// labels<para>Milk Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#MilkAllergy">https://w3id.org/timebank#MilkAllergy</seealso>
    let MilkAllergy = Prefixed_Name(tb, "MilkAllergy") |> PrefixedName
    /// <summary>
    ///   <para>tb:NutsAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Allergy to nuts such as almonds, walnuts, pecans, and peanuts.</para>
    /// labels<para>Nuts Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#NutsAllergy">https://w3id.org/timebank#NutsAllergy</seealso>
    let NutsAllergy = Prefixed_Name(tb, "NutsAllergy") |> PrefixedName
    /// <summary>
    ///   <para>tb:SeafoodAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Allergy to any kind of seafood.</para>
    /// labels<para>Seafood Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SeafoodAllergy">https://w3id.org/timebank#SeafoodAllergy</seealso>
    let SeafoodAllergy = Prefixed_Name(tb, "SeafoodAllergy") |> PrefixedName
    /// <summary>
    ///   <para>tb:Accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Describes any revelant information regarding the accessibility of a location of a request.</para>
    /// labels<para>Accessibility</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Accessibility">https://w3id.org/timebank#Accessibility</seealso>
    let Accessibility = Prefixed_Name(tb, "Accessibility") |> PrefixedName
    /// <summary>
    ///   <para>tb:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The environment describes relevant environmental factors of a request.</para>
    /// labels<para>Environment</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Environment">https://w3id.org/timebank#Environment</seealso>
    let Environment = Prefixed_Name(tb, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>tb:Supplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Availability of specific supplies to complete a task.</para>
    /// labels<para>Supplies</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Supplies">https://w3id.org/timebank#Supplies</seealso>
    let Supplies = Prefixed_Name(tb, "Supplies") |> PrefixedName
    /// <summary>
    ///   <para>tb:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A request for help from a Timebank user.</para>
    /// labels<para>Request</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Request">https://w3id.org/timebank#Request</seealso>
    let Request = Prefixed_Name(tb, "Request") |> PrefixedName
    /// <summary>
    ///   <para>tb:Limitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Limitations can be anything which prevents or limits the extent to which a user can help somebody else.</para>
    /// labels<para>Limitation</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Limitation">https://w3id.org/timebank#Limitation</seealso>
    let Limitation = Prefixed_Name(tb, "Limitation") |> PrefixedName
    /// <summary>
    ///   <para>tb:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The status of a request.</para>
    /// labels<para>Status</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Status">https://w3id.org/timebank#Status</seealso>
    let Status = Prefixed_Name(tb, "Status") |> PrefixedName
    /// <summary>
    ///   <para>tb:Skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Skills define the capabilities of a user. Users and Timebank requests can be associated to a certain skill (or multiple skills) to facilitate the matching of helper and requester.</para>
    /// labels<para>Skill</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Skill">https://w3id.org/timebank#Skill</seealso>
    let Skill = Prefixed_Name(tb, "Skill") |> PrefixedName
    /// <summary>
    ///   <para>tb:Carpeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to do carpenting.</para>
    /// labels<para>Carpenting</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Carpeting">https://w3id.org/timebank#Carpeting</seealso>
    let Carpeting = Prefixed_Name(tb, "Carpeting") |> PrefixedName
    /// <summary>
    ///   <para>tb:WoodCarving</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to Carve items out of wood.</para>
    /// labels<para>Wood Carving</para></remarks>
    /// <seealso href="https://w3id.org/timebank#WoodCarving">https://w3id.org/timebank#WoodCarving</seealso>
    let WoodCarving = Prefixed_Name(tb, "WoodCarving") |> PrefixedName
    /// <summary>
    ///   <para>tb:Cats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Indicates that cats might be present.</para>
    /// labels<para>Cats</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Cats">https://w3id.org/timebank#Cats</seealso>
    let Cats = Prefixed_Name(tb, "Cats") |> PrefixedName
    /// <summary>
    ///   <para>tb:Pets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that pets might be present.</para>
    /// labels<para>Pets</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Pets">https://w3id.org/timebank#Pets</seealso>
    let Pets = Prefixed_Name(tb, "Pets") |> PrefixedName
    /// <summary>
    ///   <para>tb:ClothesWashing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist with washing clothes.</para>
    /// labels<para>Clothes Washing</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ClothesWashing">https://w3id.org/timebank#ClothesWashing</seealso>
    let ClothesWashing = Prefixed_Name(tb, "ClothesWashing") |> PrefixedName
    /// <summary>
    ///   <para>tb:Counseling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to advice people on psychological matters.</para>
    /// labels<para>Counseling</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Counseling">https://w3id.org/timebank#Counseling</seealso>
    let Counseling = Prefixed_Name(tb, "Counseling") |> PrefixedName
    /// <summary>
    ///   <para>tb:AutomobileRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to repair automobiles.</para>
    /// labels<para>Automobile Repair</para></remarks>
    /// <seealso href="https://w3id.org/timebank#AutomobileRepair">https://w3id.org/timebank#AutomobileRepair</seealso>
    let AutomobileRepair = Prefixed_Name(tb, "AutomobileRepair") |> PrefixedName
    /// <summary>
    ///   <para>tb:Plumbing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Skill to perform plumbing and repairs on pipe installation.</para>
    /// labels<para>Plumbing</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Plumbing">https://w3id.org/timebank#Plumbing</seealso>
    let Plumbing = Prefixed_Name(tb, "Plumbing") |> PrefixedName
    /// <summary>
    ///   <para>tb:Baking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to assist with baking.</para>
    /// labels<para>Baking</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Baking">https://w3id.org/timebank#Baking</seealso>
    let Baking = Prefixed_Name(tb, "Baking") |> PrefixedName
    /// <summary>
    ///   <para>tb:FoodPreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to assist with food preparation like meat cutting, washing of food, etc.</para>
    /// labels<para>Food Preparation</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FoodPreparation">https://w3id.org/timebank#FoodPreparation</seealso>
    let FoodPreparation = Prefixed_Name(tb, "FoodPreparation") |> PrefixedName
    /// <summary>
    ///   <para>tb:MobilityProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Difficulties with moving around physically such as having difficulties using toliet, dressing, walking and so on.</para>
    /// labels<para>Mobility Problem</para></remarks>
    /// <seealso href="https://w3id.org/timebank#MobilityProblem">https://w3id.org/timebank#MobilityProblem</seealso>
    let MobilityProblem = Prefixed_Name(tb, "MobilityProblem") |> PrefixedName
    /// <summary>
    ///   <para>tb:SpeakingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The person has difficulties speaking clearly due to body function problems such as injuries to the brain, mouth or throat.</para>
    /// labels<para>Speaking Problem</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SpeakingProblem">https://w3id.org/timebank#SpeakingProblem</seealso>
    let SpeakingProblem = Prefixed_Name(tb, "SpeakingProblem") |> PrefixedName
    /// <summary>
    ///   <para>tb:LevelMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Used if a Limitation has a medium severity or a Skill is on a medium level</para>
    /// labels<para>Level: Medium</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LevelMedium">https://w3id.org/timebank#LevelMedium</seealso>
    let LevelMedium = Prefixed_Name(tb, "LevelMedium") |> PrefixedName

    /// <summary>
    ///   <para>tb:LimitedAccessibilityRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The place is difficult to access during rainfall.</para>
    /// labels<para>Limited Accessibility: Rain</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LimitedAccessibilityRain">https://w3id.org/timebank#LimitedAccessibilityRain</seealso>
    let LimitedAccessibilityRain =
        Prefixed_Name(tb, "LimitedAccessibilityRain") |> PrefixedName

    /// <summary>
    ///   <para>tb:FinancialAdvice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Specialized in providing assistance with financial services. This can include helping with taxes and book keeping.</para>
    /// labels<para>Financial Advice</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FinancialAdvice">https://w3id.org/timebank#FinancialAdvice</seealso>
    let FinancialAdvice = Prefixed_Name(tb, "FinancialAdvice") |> PrefixedName

    /// <summary>
    ///   <para>tb:HouseholdEquipmentRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to repair household equipment.</para>
    /// labels<para>Houseshold Equipment Repair</para></remarks>
    /// <seealso href="https://w3id.org/timebank#HouseholdEquipmentRepair">https://w3id.org/timebank#HouseholdEquipmentRepair</seealso>
    let HouseholdEquipmentRepair =
        Prefixed_Name(tb, "HouseholdEquipmentRepair") |> PrefixedName

    /// <summary>
    ///   <para>tb:ElectronicRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to repair electronic devices.</para>
    /// labels<para>Electronic Repair</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ElectronicRepair">https://w3id.org/timebank#ElectronicRepair</seealso>
    let ElectronicRepair = Prefixed_Name(tb, "ElectronicRepair") |> PrefixedName
    /// <summary>
    ///   <para>tb:Cooking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to assist with cooking in general.</para>
    /// labels<para>Cooking</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Cooking">https://w3id.org/timebank#Cooking</seealso>
    let Cooking = Prefixed_Name(tb, "Cooking") |> PrefixedName
    /// <summary>
    ///   <para>tb:Internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Internet is available.</para>
    /// labels<para>Internet</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Internet">https://w3id.org/timebank#Internet</seealso>
    let Internet = Prefixed_Name(tb, "Internet") |> PrefixedName
    /// <summary>
    ///   <para>tb:LevelHigh</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Used if a Limitation has a high severity or a Skill is on a high level.</para>
    /// labels<para>Level: High</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LevelHigh">https://w3id.org/timebank#LevelHigh</seealso>
    let LevelHigh = Prefixed_Name(tb, "LevelHigh") |> PrefixedName
    /// <summary>
    ///   <para>tb:LevelLow</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Used if a Limitation only has a low severity or a Skill is on a low level.</para>
    /// labels<para>Level: Low</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LevelLow">https://w3id.org/timebank#LevelLow</seealso>
    let LevelLow = Prefixed_Name(tb, "LevelLow") |> PrefixedName
    /// <summary>
    ///   <para>tb:Cleaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to assist with general cleaning tasks.</para>
    /// labels<para>Cleaning</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Cleaning">https://w3id.org/timebank#Cleaning</seealso>
    let Cleaning = Prefixed_Name(tb, "Cleaning") |> PrefixedName
    /// <summary>
    ///   <para>tb:PoorEyesight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Having difficulties seeing objects clearly.</para>
    /// labels<para>Poor Eyesight</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PoorEyesight">https://w3id.org/timebank#PoorEyesight</seealso>
    let PoorEyesight = Prefixed_Name(tb, "PoorEyesight") |> PrefixedName

    /// <summary>
    ///   <para>tb:LimitedAccessibilitySnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The place is difficult to access during snowfall.</para>
    /// labels<para>Limited Accessibility: Snow</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LimitedAccessibilitySnow">https://w3id.org/timebank#LimitedAccessibilitySnow</seealso>
    let LimitedAccessibilitySnow =
        Prefixed_Name(tb, "LimitedAccessibilitySnow") |> PrefixedName

    /// <summary>
    ///   <para>tb:ElderlyCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to provide care and support for the elderly.</para>
    /// labels<para>Care for Elderly</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ElderlyCare">https://w3id.org/timebank#ElderlyCare</seealso>
    let ElderlyCare = Prefixed_Name(tb, "ElderlyCare") |> PrefixedName
    /// <summary>
    ///   <para>tb:SickCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to provide care for sick people.</para>
    /// labels<para>Care for Sick People</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SickCare">https://w3id.org/timebank#SickCare</seealso>
    let SickCare = Prefixed_Name(tb, "SickCare") |> PrefixedName
    /// <summary>
    ///   <para>tb:EggAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Allergy to eggs.</para>
    /// labels<para>Egg Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#EggAllergy">https://w3id.org/timebank#EggAllergy</seealso>
    let EggAllergy = Prefixed_Name(tb, "EggAllergy") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasAddressPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An address part that describes the location of a specific request.</para>
    /// labels<para>has address part</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasAddressPart">https://w3id.org/timebank#hasAddressPart</seealso>
    let hasAddressPart = Prefixed_Name(tb, "hasAddressPart") |> PrefixedName
    /// <summary>
    ///   <para>tb:AddressPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An address part indicates part of an address like region, city, etc. If two places share the same address part, they also share the same environmental factors.</para>
    /// labels<para>Address Part</para></remarks>
    /// <seealso href="https://w3id.org/timebank#AddressPart">https://w3id.org/timebank#AddressPart</seealso>
    let AddressPart = Prefixed_Name(tb, "AddressPart") |> PrefixedName
    /// <summary>
    ///   <para>tb:PhoneCalls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to perform phone calls.</para>
    /// labels<para>Phone Calls</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PhoneCalls">https://w3id.org/timebank#PhoneCalls</seealso>
    let PhoneCalls = Prefixed_Name(tb, "PhoneCalls") |> PrefixedName
    /// <summary>
    ///   <para>tb:ChildCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to provide care for children.</para>
    /// labels<para>Child Care</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ChildCare">https://w3id.org/timebank#ChildCare</seealso>
    let ChildCare = Prefixed_Name(tb, "ChildCare") |> PrefixedName
    /// <summary>
    ///   <para>tb:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Every request can have at most one status assigned to it.</para>
    /// labels<para>has status</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasStatus">https://w3id.org/timebank#hasStatus</seealso>
    let hasStatus = Prefixed_Name(tb, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>tb:SpecificPhobia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Fear of specific objects such as dogs, cats, heights, dark places, and so on.</para>
    /// labels<para>Specific Phobia</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SpecificPhobia">https://w3id.org/timebank#SpecificPhobia</seealso>
    let SpecificPhobia = Prefixed_Name(tb, "SpecificPhobia") |> PrefixedName
    /// <summary>
    ///   <para>tb:ToiletUsingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The person has difficulties using toilet.</para>
    /// labels<para>Toilet Using Problem</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ToiletUsingProblem">https://w3id.org/timebank#ToiletUsingProblem</seealso>
    let ToiletUsingProblem = Prefixed_Name(tb, "ToiletUsingProblem") |> PrefixedName
    /// <summary>
    ///   <para>tb:FoodAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>An allergy to food such as milk, peanuts, eggs, fish, tree nuts, and fruit.</para>
    /// labels<para>Food Allergy</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FoodAllergy">https://w3id.org/timebank#FoodAllergy</seealso>
    let FoodAllergy = Prefixed_Name(tb, "FoodAllergy") |> PrefixedName
    /// <summary>
    ///   <para>tb:EventPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to assist in planning and hosting events.</para>
    /// labels<para>Event Planning</para></remarks>
    /// <seealso href="https://w3id.org/timebank#EventPlanning">https://w3id.org/timebank#EventPlanning</seealso>
    let EventPlanning = Prefixed_Name(tb, "EventPlanning") |> PrefixedName
    /// <summary>
    ///   <para>tb:Sports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to participate in sport activities.</para>
    /// labels<para>Sports</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Sports">https://w3id.org/timebank#Sports</seealso>
    let Sports = Prefixed_Name(tb, "Sports") |> PrefixedName
    /// <summary>
    ///   <para>tb:WoodCrafting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Crafting skill with wood as base material.</para>
    /// labels<para>Wood Crafting</para></remarks>
    /// <seealso href="https://w3id.org/timebank#WoodCrafting">https://w3id.org/timebank#WoodCrafting</seealso>
    let WoodCrafting = Prefixed_Name(tb, "WoodCrafting") |> PrefixedName
    /// <summary>
    ///   <para>tb:Lift</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>A lift/elevator is available.</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/timebank#Lift">https://w3id.org/timebank#Lift</seealso>
    let Lift = Prefixed_Name(tb, "Lift") |> PrefixedName
    /// <summary>
    ///   <para>tb:UnevenTerrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The person needs equipment (e.g. shoes) suitable for uneven terrain.</para>
    /// labels<para>Uneven Terrain</para></remarks>
    /// <seealso href="https://w3id.org/timebank#UnevenTerrain">https://w3id.org/timebank#UnevenTerrain</seealso>
    let UnevenTerrain = Prefixed_Name(tb, "UnevenTerrain") |> PrefixedName
    /// <summary>
    ///   <para>tb:FearOfCats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Fear of cats.</para>
    /// labels<para>Fear of Cats</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfCats">https://w3id.org/timebank#FearOfCats</seealso>
    let FearOfCats = Prefixed_Name(tb, "FearOfCats") |> PrefixedName
    /// <summary>
    ///   <para>tb:FearOfDogs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Fear of dogs.</para>
    /// labels<para>Fear of Dogs</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfDogs">https://w3id.org/timebank#FearOfDogs</seealso>
    let FearOfDogs = Prefixed_Name(tb, "FearOfDogs") |> PrefixedName
    /// <summary>
    ///   <para>tb:Groceries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The skill to help buying groceries.</para>
    /// labels<para>Groceries</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Groceries">https://w3id.org/timebank#Groceries</seealso>
    let Groceries = Prefixed_Name(tb, "Groceries") |> PrefixedName
    /// <summary>
    ///   <para>tb:OnlineShopping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The skill to assist in buying things online.</para>
    /// labels<para>Online Shopping</para></remarks>
    /// <seealso href="https://w3id.org/timebank#OnlineShopping">https://w3id.org/timebank#OnlineShopping</seealso>
    let OnlineShopping = Prefixed_Name(tb, "OnlineShopping") |> PrefixedName
    /// <summary>
    ///   <para>tb:isRequiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The skill associated with a Timebank request.</para>
    /// labels<para>is required by</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isRequiredBy">https://w3id.org/timebank#isRequiredBy</seealso>
    let isRequiredBy = Prefixed_Name(tb, "isRequiredBy") |> PrefixedName
    /// <summary>
    ///   <para>tb:requiresSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The skill associated with a Timebank request.</para>
    /// labels<para>requires skill</para></remarks>
    /// <seealso href="https://w3id.org/timebank#requiresSkill">https://w3id.org/timebank#requiresSkill</seealso>
    let requiresSkill = Prefixed_Name(tb, "requiresSkill") |> PrefixedName
