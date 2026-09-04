#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pico =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.cochrane.org/ontologies/pico/" "pico"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Age</para>
    ///   <para>rdfs:comment : The age of a population group</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Age">pico:Age</a>
    /// </summary>
    let Age = _prefixId.prefix "Age"
    /// <summary>
    ///   <para>rdfs:label : AggregationMethod</para>
    ///   <para>rdfs:comment : Outcome aggregation method^^xsd:string</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/AggregationMethod">pico:AggregationMethod</a>
    /// </summary>
    let AggregationMethod = _prefixId.prefix "AggregationMethod"
    /// <summary>
    ///   <para>rdfs:label : AppliedIntervention</para>
    ///   <para>rdfs:comment : Abstract class, the intervention applied (procedure, materials etc)</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/AppliedIntervention">pico:AppliedIntervention</a>
    /// </summary>
    let AppliedIntervention = _prefixId.prefix "AppliedIntervention"
    /// <summary>
    ///   <para>rdfs:label : AssessmentScale</para>
    ///   <para>rdfs:comment : Outcome assessment scale, e.g. SCTID:273249006</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/AssessmentScale">pico:AssessmentScale</a>
    /// </summary>
    let AssessmentScale = _prefixId.prefix "AssessmentScale"
    /// <summary>
    ///   <para>rdfs:label : Condition</para>
    ///   <para>rdfs:comment : Conditions for example illness or disease.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Condition">pico:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:label : Dose</para>
    ///   <para>rdfs:comment : Dose in an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Dose">pico:Dose</a>
    /// </summary>
    let Dose = _prefixId.prefix "Dose"
    /// <summary>
    ///   <para>rdfs:label : Duration</para>
    ///   <para>rdfs:comment : Duration of some action</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Duration">pico:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>rdfs:label : Intervention</para>
    ///   <para>rdfs:comment : An intervention in a PICO question is an action under consideration for this population.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Intervention">pico:Intervention</a>
    /// </summary>
    let Intervention = _prefixId.prefix "Intervention"
    /// <summary>
    ///   <para>rdfs:label : Intervention Classification</para>
    ///   <para>rdfs:comment : The type of intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/InterventionClassification">pico:InterventionClassification</a>
    /// </summary>
    let InterventionClassification = _prefixId.prefix "InterventionClassification"
    /// <summary>
    ///   <para>rdfs:label : InterventionGroup</para>
    ///   <para>rdfs:comment : An intervention group is a group of interventions for example an arm of a trial.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/InterventionGroup">pico:InterventionGroup</a>
    /// </summary>
    let InterventionGroup = _prefixId.prefix "InterventionGroup"
    /// <summary>
    ///   <para>rdfs:label : InterventionProvider</para>
    ///   <para>rdfs:comment : The provider of an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/InterventionProvider">pico:InterventionProvider</a>
    /// </summary>
    let InterventionProvider = _prefixId.prefix "InterventionProvider"
    /// <summary>
    ///   <para>rdfs:label : InterventionRationale</para>
    ///   <para>rdfs:comment : The rationale of an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/InterventionRationale">pico:InterventionRationale</a>
    /// </summary>
    let InterventionRationale = _prefixId.prefix "InterventionRationale"
    /// <summary>
    ///   <para>rdfs:label : ModeOfDelivery</para>
    ///   <para>rdfs:comment : Mode of delivery for an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/ModeOfDelivery">pico:ModeOfDelivery</a>
    /// </summary>
    let ModeOfDelivery = _prefixId.prefix "ModeOfDelivery"
    /// <summary>
    ///   <para>rdfs:label : Outcome</para>
    ///   <para>rdfs:comment : The desired outcome of an intervention.^^xsd:string</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Outcome">pico:Outcome</a>
    /// </summary>
    let Outcome = _prefixId.prefix "Outcome"
    /// <summary>
    ///   <para>rdfs:label : OutcomeClassification</para>
    ///   <para>rdfs:comment : Classification scheme describing the type of outcome^^xsd:string</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/OutcomeClassification">pico:OutcomeClassification</a>
    /// </summary>
    let OutcomeClassification = _prefixId.prefix "OutcomeClassification"
    /// <summary>
    ///   <para>rdfs:label : OutcomeDomain</para>
    ///   <para>rdfs:comment : The outcome domain, typically a Condition.^^xsd:string</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/OutcomeDomain">pico:OutcomeDomain</a>
    /// </summary>
    let OutcomeDomain = _prefixId.prefix "OutcomeDomain"
    /// <summary>
    ///   <para>rdfs:label : OutcomeGroup</para>
    ///   <para>rdfs:comment : An outcome group is a group of outcomes.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/OutcomeGroup">pico:OutcomeGroup</a>
    /// </summary>
    let OutcomeGroup = _prefixId.prefix "OutcomeGroup"
    /// <summary>
    ///   <para>rdfs:label : PICO</para>
    ///   <para>rdfs:comment : A PICO class represents an object that defines a research or a clinical question.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/PICO">pico:PICO</a>
    /// </summary>
    let PICO = _prefixId.prefix "PICO"
    /// <summary>
    ///   <para>rdfs:label : Population</para>
    ///   <para>rdfs:comment : A population defines a group of people/patient in a PICO question.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Population">pico:Population</a>
    /// </summary>
    let Population = _prefixId.prefix "Population"
    /// <summary>
    ///   <para>rdfs:label : Schedule</para>
    ///   <para>rdfs:comment : Schedule of an intervention^^xsd:string</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Schedule">pico:Schedule</a>
    /// </summary>
    let Schedule = _prefixId.prefix "Schedule"
    /// <summary>
    ///   <para>rdfs:label : Setting</para>
    ///   <para>rdfs:comment : Setting of an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Setting">pico:Setting</a>
    /// </summary>
    let Setting = _prefixId.prefix "Setting"
    /// <summary>
    ///   <para>rdfs:label : Sex</para>
    ///   <para>rdfs:comment : The sex of a population group</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Sex">pico:Sex</a>
    /// </summary>
    let Sex = _prefixId.prefix "Sex"
    /// <summary>
    ///   <para>rdfs:label : SocialContext</para>
    ///   <para>rdfs:comment : Social context of a population^^xsd:string</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/SocialContext">pico:SocialContext</a>
    /// </summary>
    let SocialContext = _prefixId.prefix "SocialContext"
    /// <summary>
    ///   <para>rdfs:label : SpecificMetric</para>
    ///   <para>rdfs:comment : Specific metric of an outcome^^xsd:string</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/SpecificMetric">pico:SpecificMetric</a>
    /// </summary>
    let SpecificMetric = _prefixId.prefix "SpecificMetric"
    /// <summary>
    ///   <para>rdfs:label : Treatment</para>
    ///   <para>rdfs:comment : Some treatment of a population^^xsd:string</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/Treatment">pico:Treatment</a>
    /// </summary>
    let Treatment = _prefixId.prefix "Treatment"
    /// <summary>
    ///   <para>rdfs:label : age</para>
    ///   <para>rdfs:comment : The age of a population</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/age">pico:age</a>
    /// </summary>
    let age = _prefixId.prefix "age"
    /// <summary>
    ///   <para>rdfs:label : aggregationMethod</para>
    ///   <para>rdfs:comment : The aggregation method of an outcome.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/aggregationMethod">pico:aggregationMethod</a>
    /// </summary>
    let aggregationMethod = _prefixId.prefix "aggregationMethod"
    /// <summary>
    ///   <para>rdfs:label : appliedIntervention</para>
    ///   <para>rdfs:comment : Associates an appliedIntervention (material, procedure) with a PICO Intervention instance.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/appliedIntervention">pico:appliedIntervention</a>
    /// </summary>
    let appliedIntervention = _prefixId.prefix "appliedIntervention"
    /// <summary>
    ///   <para>rdfs:label : childIntervention</para>
    ///   <para>rdfs:comment : The child intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/childIntervention">pico:childIntervention</a>
    /// </summary>
    let childIntervention = _prefixId.prefix "childIntervention"
    /// <summary>
    ///   <para>rdfs:label : childOutcome</para>
    ///   <para>rdfs:comment : The child outcome</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/childOutcome">pico:childOutcome</a>
    /// </summary>
    let childOutcome = _prefixId.prefix "childOutcome"
    /// <summary>
    ///   <para>rdfs:label : comparatorGroup</para>
    ///   <para>rdfs:comment : A comparator intervention group</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/comparatorGroup">pico:comparatorGroup</a>
    /// </summary>
    let comparatorGroup = _prefixId.prefix "comparatorGroup"
    /// <summary>
    ///   <para>rdfs:label : condition</para>
    ///   <para>rdfs:comment : A precondition of the population.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/condition">pico:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:label : dose</para>
    ///   <para>rdfs:comment : Dose used in an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/dose">pico:dose</a>
    /// </summary>
    let dose = _prefixId.prefix "dose"
    /// <summary>
    ///   <para>rdfs:label : duration</para>
    ///   <para>rdfs:comment : duration of an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/duration">pico:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:label : endpoint</para>
    ///   <para>rdfs:comment : An endpoint of an outcome group, by duration</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/endpoint">pico:endpoint</a>
    /// </summary>
    let endpoint = _prefixId.prefix "endpoint"
    /// <summary>
    ///   <para>rdfs:label : excludedIntervention</para>
    ///   <para>rdfs:comment : An excluded intervention.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/excludedIntervention">pico:excludedIntervention</a>
    /// </summary>
    let excludedIntervention = _prefixId.prefix "excludedIntervention"
    /// <summary>
    ///   <para>rdfs:label : excludedOutcome</para>
    ///   <para>rdfs:comment : An excluded outcome.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/excludedOutcome">pico:excludedOutcome</a>
    /// </summary>
    let excludedOutcome = _prefixId.prefix "excludedOutcome"
    /// <summary>
    ///   <para>rdfs:label : excludedPopulation</para>
    ///   <para>rdfs:comment : An excluded sub-population.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/excludedPopulation">pico:excludedPopulation</a>
    /// </summary>
    let excludedPopulation = _prefixId.prefix "excludedPopulation"
    /// <summary>
    ///   <para>rdfs:label : intervention</para>
    ///   <para>rdfs:comment : An intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/intervention">pico:intervention</a>
    /// </summary>
    let intervention = _prefixId.prefix "intervention"
    /// <summary>
    ///   <para>rdfs:label : interventionClassification</para>
    ///   <para>rdfs:comment : The type of intervention.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/interventionClassification">pico:interventionClassification</a>
    /// </summary>
    let interventionClassification = _prefixId.prefix "interventionClassification"
    /// <summary>
    ///   <para>rdfs:label : interventionGroup</para>
    ///   <para>rdfs:comment : An intervention group</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/interventionGroup">pico:interventionGroup</a>
    /// </summary>
    let interventionGroup = _prefixId.prefix "interventionGroup"
    /// <summary>
    ///   <para>rdfs:label : interventionProvider</para>
    ///   <para>rdfs:comment : Intervention provider of an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/interventionProvider">pico:interventionProvider</a>
    /// </summary>
    let interventionProvider = _prefixId.prefix "interventionProvider"
    /// <summary>
    ///   <para>rdfs:label : interventionRationale</para>
    ///   <para>rdfs:comment : Rationale of an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/interventionRationale">pico:interventionRationale</a>
    /// </summary>
    let interventionRationale = _prefixId.prefix "interventionRationale"
    /// <summary>
    ///   <para>rdfs:label : isComparator</para>
    ///   <para>rdfs:comment : The comparator flag (Deprecated).</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/isComparator">pico:isComparator</a>
    /// </summary>
    let isComparator = _prefixId.prefix "isComparator"
    /// <summary>
    ///   <para>rdfs:label : modeOfDelivery</para>
    ///   <para>rdfs:comment : mode of delivery</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/modeOfDelivery">pico:modeOfDelivery</a>
    /// </summary>
    let modeOfDelivery = _prefixId.prefix "modeOfDelivery"
    /// <summary>
    ///   <para>rdfs:label : numberOfParticipants</para>
    ///   <para>rdfs:comment : The number of participants in a population an intervention is being applied to</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/numberOfParticipants">pico:numberOfParticipants</a>
    /// </summary>
    let numberOfParticipants = _prefixId.prefix "numberOfParticipants"
    /// <summary>
    ///   <para>rdfs:label : outcome</para>
    ///   <para>rdfs:comment : Relates a outcome group to an outcome</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/outcome">pico:outcome</a>
    /// </summary>
    let outcome = _prefixId.prefix "outcome"
    /// <summary>
    ///   <para>rdfs:label : outcomeClassification</para>
    ///   <para>rdfs:comment : The type of outcome.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/outcomeClassification">pico:outcomeClassification</a>
    /// </summary>
    let outcomeClassification = _prefixId.prefix "outcomeClassification"
    /// <summary>
    ///   <para>rdfs:label : outcomeDomain</para>
    ///   <para>rdfs:comment : The domain of an outome, e.g. a side effect outcome, typically a condition.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/outcomeDomain">pico:outcomeDomain</a>
    /// </summary>
    let outcomeDomain = _prefixId.prefix "outcomeDomain"
    /// <summary>
    ///   <para>rdfs:label : outcomeGroup</para>
    ///   <para>rdfs:comment : Relates a pico to an outcome group</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/outcomeGroup">pico:outcomeGroup</a>
    /// </summary>
    let outcomeGroup = _prefixId.prefix "outcomeGroup"
    /// <summary>
    ///   <para>rdfs:label : outcomeMeasurement</para>
    ///   <para>rdfs:comment : The outcome measurement assessment scale.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/outcomeMeasurement">pico:outcomeMeasurement</a>
    /// </summary>
    let outcomeMeasurement = _prefixId.prefix "outcomeMeasurement"
    /// <summary>
    ///   <para>rdfs:label : outcomeText</para>
    ///   <para>rdfs:comment : Free text associated with an Outcome.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/outcomeText">pico:outcomeText</a>
    /// </summary>
    let outcomeText = _prefixId.prefix "outcomeText"
    /// <summary>
    ///   <para>rdfs:label : outcomeTreatment</para>
    ///   <para>rdfs:comment : The outcome treatment.</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/outcomeTreatment">pico:outcomeTreatment</a>
    /// </summary>
    let outcomeTreatment = _prefixId.prefix "outcomeTreatment"
    /// <summary>
    ///   <para>rdfs:label : parentIntervention</para>
    ///   <para>rdfs:comment : The parent intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/parentIntervention">pico:parentIntervention</a>
    /// </summary>
    let parentIntervention = _prefixId.prefix "parentIntervention"
    /// <summary>
    ///   <para>rdfs:label : parentOutcome</para>
    ///   <para>rdfs:comment : References the parent outcome</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/parentOutcome">pico:parentOutcome</a>
    /// </summary>
    let parentOutcome = _prefixId.prefix "parentOutcome"
    /// <summary>
    ///   <para>rdfs:label : population</para>
    ///   <para>rdfs:comment : A population</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/population">pico:population</a>
    /// </summary>
    let population = _prefixId.prefix "population"
    /// <summary>
    ///   <para>rdfs:label : primaryEndpoint</para>
    ///   <para>rdfs:comment : The primary endpoint of an outcome group, by duration</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/primaryEndpoint">pico:primaryEndpoint</a>
    /// </summary>
    let primaryEndpoint = _prefixId.prefix "primaryEndpoint"
    /// <summary>
    ///   <para>rdfs:label : schedule</para>
    ///   <para>rdfs:comment : schedule of an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/schedule">pico:schedule</a>
    /// </summary>
    let schedule = _prefixId.prefix "schedule"
    /// <summary>
    ///   <para>rdfs:label : setting</para>
    ///   <para>rdfs:comment : setting of an intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/setting">pico:setting</a>
    /// </summary>
    let setting = _prefixId.prefix "setting"
    /// <summary>
    ///   <para>rdfs:label : sex</para>
    ///   <para>rdfs:comment : The sex of a population</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/sex">pico:sex</a>
    /// </summary>
    let sex = _prefixId.prefix "sex"
    /// <summary>
    ///   <para>rdfs:label : socialContext</para>
    ///   <para>rdfs:comment : The social context of a population</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/socialContext">pico:socialContext</a>
    /// </summary>
    let socialContext = _prefixId.prefix "socialContext"
    /// <summary>
    ///   <para>rdfs:label : treatment</para>
    ///   <para>rdfs:comment : A treatment of a population</para>
    ///   <a href="http://data.cochrane.org/ontologies/pico/treatment">pico:treatment</a>
    /// </summary>
    let treatment = _prefixId.prefix "treatment"
