namespace http.data.cochrane.org.ontologies.pico.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pico =
    let _namespace_iri = Namespace_Iri pico |> NamespaceIRI
    /// <summary>
    ///   <para>pico:Age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The age of a population group</para>
    /// labels<para>Age</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Age">http://data.cochrane.org/ontologies/pico/Age</seealso>
    let Age = Prefixed_Name(pico, "Age") |> PrefixedName
    /// <summary>
    ///   <para>pico:SocialContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Social context of a population</para>
    /// labels<para>SocialContext</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/SocialContext">http://data.cochrane.org/ontologies/pico/SocialContext</seealso>
    let SocialContext = Prefixed_Name(pico, "SocialContext") |> PrefixedName
    /// <summary>
    ///   <para>pico:age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The age of a population</para>
    /// labels<para>age</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/age">http://data.cochrane.org/ontologies/pico/age</seealso>
    let age = Prefixed_Name(pico, "age") |> PrefixedName
    /// <summary>
    ///   <para>pico:aggregationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The aggregation method of an outcome.</para>
    /// labels<para>aggregationMethod</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/aggregationMethod">http://data.cochrane.org/ontologies/pico/aggregationMethod</seealso>
    let aggregationMethod = Prefixed_Name(pico, "aggregationMethod") |> PrefixedName
    /// <summary>
    ///   <para>pico:appliedIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an appliedIntervention (material, procedure) with a PICO Intervention instance.</para>
    /// labels<para>appliedIntervention</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/appliedIntervention">http://data.cochrane.org/ontologies/pico/appliedIntervention</seealso>
    let appliedIntervention = Prefixed_Name(pico, "appliedIntervention") |> PrefixedName
    /// <summary>
    ///   <para>pico:childOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The child outcome</para>
    /// labels<para>childOutcome</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/childOutcome">http://data.cochrane.org/ontologies/pico/childOutcome</seealso>
    let childOutcome = Prefixed_Name(pico, "childOutcome") |> PrefixedName
    /// <summary>
    ///   <para>pico:dose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Dose used in an intervention</para>
    /// labels<para>dose</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/dose">http://data.cochrane.org/ontologies/pico/dose</seealso>
    let dose = Prefixed_Name(pico, "dose") |> PrefixedName

    /// <summary>
    ///   <para>pico:excludedIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An excluded intervention.</para>
    /// labels<para>excludedIntervention</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/excludedIntervention">http://data.cochrane.org/ontologies/pico/excludedIntervention</seealso>
    let excludedIntervention =
        Prefixed_Name(pico, "excludedIntervention") |> PrefixedName

    /// <summary>
    ///   <para>pico:AppliedIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class, the intervention applied (procedure, materials etc)</para>
    /// labels<para>AppliedIntervention</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/AppliedIntervention">http://data.cochrane.org/ontologies/pico/AppliedIntervention</seealso>
    let AppliedIntervention = Prefixed_Name(pico, "AppliedIntervention") |> PrefixedName
    /// <summary>
    ///   <para>pico:Dose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dose in an intervention</para>
    /// labels<para>Dose</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Dose">http://data.cochrane.org/ontologies/pico/Dose</seealso>
    let Dose = Prefixed_Name(pico, "Dose") |> PrefixedName
    /// <summary>
    ///   <para>pico:Intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An intervention in a PICO question is an action under consideration for this population.</para>
    /// labels<para>Intervention</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Intervention">http://data.cochrane.org/ontologies/pico/Intervention</seealso>
    let Intervention = Prefixed_Name(pico, "Intervention") |> PrefixedName
    /// <summary>
    ///   <para>pico:AssessmentScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Outcome assessment scale, e.g. SCTID:273249006</para>
    /// labels<para>AssessmentScale</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/AssessmentScale">http://data.cochrane.org/ontologies/pico/AssessmentScale</seealso>
    let AssessmentScale = Prefixed_Name(pico, "AssessmentScale") |> PrefixedName
    /// <summary>
    ///   <para>pico:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Duration of some action</para>
    /// labels<para>Duration</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Duration">http://data.cochrane.org/ontologies/pico/Duration</seealso>
    let Duration = Prefixed_Name(pico, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>pico:InterventionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An intervention group is a group of interventions for example an arm of a trial.</para>
    /// labels<para>InterventionGroup</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/InterventionGroup">http://data.cochrane.org/ontologies/pico/InterventionGroup</seealso>
    let InterventionGroup = Prefixed_Name(pico, "InterventionGroup") |> PrefixedName

    /// <summary>
    ///   <para>pico:InterventionRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The rationale of an intervention</para>
    /// labels<para>InterventionRationale</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/InterventionRationale">http://data.cochrane.org/ontologies/pico/InterventionRationale</seealso>
    let InterventionRationale =
        Prefixed_Name(pico, "InterventionRationale") |> PrefixedName

    /// <summary>
    ///   <para>pico:ModeOfDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mode of delivery for an intervention</para>
    /// labels<para>ModeOfDelivery</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/ModeOfDelivery">http://data.cochrane.org/ontologies/pico/ModeOfDelivery</seealso>
    let ModeOfDelivery = Prefixed_Name(pico, "ModeOfDelivery") |> PrefixedName

    /// <summary>
    ///   <para>pico:OutcomeClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classification scheme describing the type of outcome</para>
    /// labels<para>OutcomeClassification</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/OutcomeClassification">http://data.cochrane.org/ontologies/pico/OutcomeClassification</seealso>
    let OutcomeClassification =
        Prefixed_Name(pico, "OutcomeClassification") |> PrefixedName

    /// <summary>
    ///   <para>pico:OutcomeGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An outcome group is a group of outcomes.</para>
    /// labels<para>OutcomeGroup</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/OutcomeGroup">http://data.cochrane.org/ontologies/pico/OutcomeGroup</seealso>
    let OutcomeGroup = Prefixed_Name(pico, "OutcomeGroup") |> PrefixedName
    /// <summary>
    ///   <para>pico:Setting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Setting of an intervention</para>
    /// labels<para>Setting</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Setting">http://data.cochrane.org/ontologies/pico/Setting</seealso>
    let Setting = Prefixed_Name(pico, "Setting") |> PrefixedName
    /// <summary>
    ///   <para>pico:Outcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The desired outcome of an intervention.</para>
    /// labels<para>Outcome</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Outcome">http://data.cochrane.org/ontologies/pico/Outcome</seealso>
    let Outcome = Prefixed_Name(pico, "Outcome") |> PrefixedName
    /// <summary>
    ///   <para>pico:Schedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Schedule of an intervention</para>
    /// labels<para>Schedule</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Schedule">http://data.cochrane.org/ontologies/pico/Schedule</seealso>
    let Schedule = Prefixed_Name(pico, "Schedule") |> PrefixedName
    /// <summary>
    ///   <para>pico:OutcomeDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The outcome domain, typically a Condition.</para>
    /// labels<para>OutcomeDomain</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/OutcomeDomain">http://data.cochrane.org/ontologies/pico/OutcomeDomain</seealso>
    let OutcomeDomain = Prefixed_Name(pico, "OutcomeDomain") |> PrefixedName
    /// <summary>
    ///   <para>pico:Population</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A population defines a group of people/patient in a PICO question.</para>
    /// labels<para>Population</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Population">http://data.cochrane.org/ontologies/pico/Population</seealso>
    let Population = Prefixed_Name(pico, "Population") |> PrefixedName
    /// <summary>
    ///   <para>pico:PICO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A PICO class represents an object that defines a research or a clinical question.</para>
    /// labels<para>PICO</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/PICO">http://data.cochrane.org/ontologies/pico/PICO</seealso>
    let PICO = Prefixed_Name(pico, "PICO") |> PrefixedName
    /// <summary>
    ///   <para>pico:SpecificMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specific metric of an outcome</para>
    /// labels<para>SpecificMetric</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/SpecificMetric">http://data.cochrane.org/ontologies/pico/SpecificMetric</seealso>
    let SpecificMetric = Prefixed_Name(pico, "SpecificMetric") |> PrefixedName
    /// <summary>
    ///   <para>pico:Treatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Some treatment of a population</para>
    /// labels<para>Treatment</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Treatment">http://data.cochrane.org/ontologies/pico/Treatment</seealso>
    let Treatment = Prefixed_Name(pico, "Treatment") |> PrefixedName
    /// <summary>
    ///   <para>pico:Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The sex of a population group</para>
    /// labels<para>Sex</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Sex">http://data.cochrane.org/ontologies/pico/Sex</seealso>
    let Sex = Prefixed_Name(pico, "Sex") |> PrefixedName
    /// <summary>
    ///   <para>pico:childIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The child intervention</para>
    /// labels<para>childIntervention</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/childIntervention">http://data.cochrane.org/ontologies/pico/childIntervention</seealso>
    let childIntervention = Prefixed_Name(pico, "childIntervention") |> PrefixedName
    /// <summary>
    ///   <para>pico:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A precondition of the population.</para>
    /// labels<para>condition</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/condition">http://data.cochrane.org/ontologies/pico/condition</seealso>
    let condition = Prefixed_Name(pico, "condition") |> PrefixedName
    /// <summary>
    ///   <para>pico:endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An endpoint of an outcome group, by duration</para>
    /// labels<para>endpoint</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/endpoint">http://data.cochrane.org/ontologies/pico/endpoint</seealso>
    let endpoint = Prefixed_Name(pico, "endpoint") |> PrefixedName
    /// <summary>
    ///   <para>pico:excludedOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An excluded outcome.</para>
    /// labels<para>excludedOutcome</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/excludedOutcome">http://data.cochrane.org/ontologies/pico/excludedOutcome</seealso>
    let excludedOutcome = Prefixed_Name(pico, "excludedOutcome") |> PrefixedName
    /// <summary>
    ///   <para>pico:excludedPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An excluded sub-population.</para>
    /// labels<para>excludedPopulation</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/excludedPopulation">http://data.cochrane.org/ontologies/pico/excludedPopulation</seealso>
    let excludedPopulation = Prefixed_Name(pico, "excludedPopulation") |> PrefixedName

    /// <summary>
    ///   <para>pico:interventionClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of intervention.</para>
    /// labels<para>interventionClassification</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/interventionClassification">http://data.cochrane.org/ontologies/pico/interventionClassification</seealso>
    let interventionClassification =
        Prefixed_Name(pico, "interventionClassification") |> PrefixedName

    /// <summary>
    ///   <para>pico:interventionRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Rationale of an intervention</para>
    /// labels<para>interventionRationale</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/interventionRationale">http://data.cochrane.org/ontologies/pico/interventionRationale</seealso>
    let interventionRationale =
        Prefixed_Name(pico, "interventionRationale") |> PrefixedName

    /// <summary>
    ///   <para>pico:isComparator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The comparator flag (Deprecated).</para>
    /// labels<para>isComparator</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/isComparator">http://data.cochrane.org/ontologies/pico/isComparator</seealso>
    let isComparator = Prefixed_Name(pico, "isComparator") |> PrefixedName

    /// <summary>
    ///   <para>pico:numberOfParticipants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of participants in a population an intervention is being applied to</para>
    /// labels<para>numberOfParticipants</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/numberOfParticipants">http://data.cochrane.org/ontologies/pico/numberOfParticipants</seealso>
    let numberOfParticipants =
        Prefixed_Name(pico, "numberOfParticipants") |> PrefixedName

    /// <summary>
    ///   <para>pico:outcomeClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of outcome.</para>
    /// labels<para>outcomeClassification</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/outcomeClassification">http://data.cochrane.org/ontologies/pico/outcomeClassification</seealso>
    let outcomeClassification =
        Prefixed_Name(pico, "outcomeClassification") |> PrefixedName

    /// <summary>
    ///   <para>pico:outcomeMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The outcome measurement assessment scale.</para>
    /// labels<para>outcomeMeasurement</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/outcomeMeasurement">http://data.cochrane.org/ontologies/pico/outcomeMeasurement</seealso>
    let outcomeMeasurement = Prefixed_Name(pico, "outcomeMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>pico:parentIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The parent intervention</para>
    /// labels<para>parentIntervention</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/parentIntervention">http://data.cochrane.org/ontologies/pico/parentIntervention</seealso>
    let parentIntervention = Prefixed_Name(pico, "parentIntervention") |> PrefixedName
    /// <summary>
    ///   <para>pico:schedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>schedule of an intervention</para>
    /// labels<para>schedule</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/schedule">http://data.cochrane.org/ontologies/pico/schedule</seealso>
    let schedule = Prefixed_Name(pico, "schedule") |> PrefixedName
    /// <summary>
    ///   <para>pico:sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The sex of a population</para>
    /// labels<para>sex</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/sex">http://data.cochrane.org/ontologies/pico/sex</seealso>
    let sex = Prefixed_Name(pico, "sex") |> PrefixedName
    /// <summary>
    ///   <para>pico:socialContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The social context of a population</para>
    /// labels<para>socialContext</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/socialContext">http://data.cochrane.org/ontologies/pico/socialContext</seealso>
    let socialContext = Prefixed_Name(pico, "socialContext") |> PrefixedName
    /// <summary>
    ///   <para>pico:comparatorGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A comparator intervention group</para>
    /// labels<para>comparatorGroup</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/comparatorGroup">http://data.cochrane.org/ontologies/pico/comparatorGroup</seealso>
    let comparatorGroup = Prefixed_Name(pico, "comparatorGroup") |> PrefixedName
    /// <summary>
    ///   <para>pico:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>duration of an intervention</para>
    /// labels<para>duration</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/duration">http://data.cochrane.org/ontologies/pico/duration</seealso>
    let duration = Prefixed_Name(pico, "duration") |> PrefixedName
    /// <summary>
    ///   <para>pico:intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An intervention</para>
    /// labels<para>intervention</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/intervention">http://data.cochrane.org/ontologies/pico/intervention</seealso>
    let intervention = Prefixed_Name(pico, "intervention") |> PrefixedName
    /// <summary>
    ///   <para>pico:interventionGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An intervention group</para>
    /// labels<para>interventionGroup</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/interventionGroup">http://data.cochrane.org/ontologies/pico/interventionGroup</seealso>
    let interventionGroup = Prefixed_Name(pico, "interventionGroup") |> PrefixedName

    /// <summary>
    ///   <para>pico:interventionProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Intervention provider of an intervention</para>
    /// labels<para>interventionProvider</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/interventionProvider">http://data.cochrane.org/ontologies/pico/interventionProvider</seealso>
    let interventionProvider =
        Prefixed_Name(pico, "interventionProvider") |> PrefixedName

    /// <summary>
    ///   <para>pico:modeOfDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>mode of delivery</para>
    /// labels<para>modeOfDelivery</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/modeOfDelivery">http://data.cochrane.org/ontologies/pico/modeOfDelivery</seealso>
    let modeOfDelivery = Prefixed_Name(pico, "modeOfDelivery") |> PrefixedName
    /// <summary>
    ///   <para>pico:outcomeText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Free text associated with an Outcome.</para>
    /// labels<para>outcomeText</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/outcomeText">http://data.cochrane.org/ontologies/pico/outcomeText</seealso>
    let outcomeText = Prefixed_Name(pico, "outcomeText") |> PrefixedName
    /// <summary>
    ///   <para>pico:outcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a outcome group to an outcome</para>
    /// labels<para>outcome</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/outcome">http://data.cochrane.org/ontologies/pico/outcome</seealso>
    let outcome = Prefixed_Name(pico, "outcome") |> PrefixedName
    /// <summary>
    ///   <para>pico:outcomeGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a pico to an outcome group</para>
    /// labels<para>outcomeGroup</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/outcomeGroup">http://data.cochrane.org/ontologies/pico/outcomeGroup</seealso>
    let outcomeGroup = Prefixed_Name(pico, "outcomeGroup") |> PrefixedName
    /// <summary>
    ///   <para>pico:outcomeTreatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The outcome treatment.</para>
    /// labels<para>outcomeTreatment</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/outcomeTreatment">http://data.cochrane.org/ontologies/pico/outcomeTreatment</seealso>
    let outcomeTreatment = Prefixed_Name(pico, "outcomeTreatment") |> PrefixedName
    /// <summary>
    ///   <para>pico:parentOutcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>References the parent outcome</para>
    /// labels<para>parentOutcome</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/parentOutcome">http://data.cochrane.org/ontologies/pico/parentOutcome</seealso>
    let parentOutcome = Prefixed_Name(pico, "parentOutcome") |> PrefixedName
    /// <summary>
    ///   <para>pico:population</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A population</para>
    /// labels<para>population</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/population">http://data.cochrane.org/ontologies/pico/population</seealso>
    let population = Prefixed_Name(pico, "population") |> PrefixedName
    /// <summary>
    ///   <para>pico:setting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>setting of an intervention</para>
    /// labels<para>setting</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/setting">http://data.cochrane.org/ontologies/pico/setting</seealso>
    let setting = Prefixed_Name(pico, "setting") |> PrefixedName
    /// <summary>
    ///   <para>pico:treatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A treatment of a population</para>
    /// labels<para>treatment</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/treatment">http://data.cochrane.org/ontologies/pico/treatment</seealso>
    let treatment = Prefixed_Name(pico, "treatment") |> PrefixedName
    /// <summary>
    ///   <para>pico:outcomeDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The domain of an outome, e.g. a side effect outcome, typically a condition.</para>
    /// labels<para>outcomeDomain</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/outcomeDomain">http://data.cochrane.org/ontologies/pico/outcomeDomain</seealso>
    let outcomeDomain = Prefixed_Name(pico, "outcomeDomain") |> PrefixedName
    /// <summary>
    ///   <para>pico:primaryEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The primary endpoint of an outcome group, by duration</para>
    /// labels<para>primaryEndpoint</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/primaryEndpoint">http://data.cochrane.org/ontologies/pico/primaryEndpoint</seealso>
    let primaryEndpoint = Prefixed_Name(pico, "primaryEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>pico:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The PICO ontology describes questions in evidence based healthcare with the intention of supporting the publishing of evidence as linked data.</para>
    /// </remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/">http://data.cochrane.org/ontologies/pico/</seealso>
    let _prefix_iri = Prefixed_Name(pico, "") |> PrefixedName
    /// <summary>
    ///   <para>pico:AggregationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Outcome aggregation method</para>
    /// labels<para>AggregationMethod</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/AggregationMethod">http://data.cochrane.org/ontologies/pico/AggregationMethod</seealso>
    let AggregationMethod = Prefixed_Name(pico, "AggregationMethod") |> PrefixedName
    /// <summary>
    ///   <para>pico:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conditions for example illness or disease.</para>
    /// labels<para>Condition</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/Condition">http://data.cochrane.org/ontologies/pico/Condition</seealso>
    let Condition = Prefixed_Name(pico, "Condition") |> PrefixedName

    /// <summary>
    ///   <para>pico:InterventionClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The type of intervention</para>
    /// labels<para>Intervention Classification</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/InterventionClassification">http://data.cochrane.org/ontologies/pico/InterventionClassification</seealso>
    let InterventionClassification =
        Prefixed_Name(pico, "InterventionClassification") |> PrefixedName

    /// <summary>
    ///   <para>pico:InterventionProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The provider of an intervention</para>
    /// labels<para>InterventionProvider</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/pico/InterventionProvider">http://data.cochrane.org/ontologies/pico/InterventionProvider</seealso>
    let InterventionProvider =
        Prefixed_Name(pico, "InterventionProvider") |> PrefixedName
