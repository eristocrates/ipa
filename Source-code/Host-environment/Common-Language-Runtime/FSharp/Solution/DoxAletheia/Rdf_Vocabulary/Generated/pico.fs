namespace http.data.cochrane.org.ontologies.pico.slash

open DoxAletheia

module pico =
    let _namespace_name = "http://data.cochrane.org/ontologies/pico/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The age of a population group
    /// <see href="http://data.cochrane.org/ontologies/pico/Age"></see></summary>
    let Age = _prefix "Age"
    /// <summary>
    /// Outcome aggregation method
    /// <see href="http://data.cochrane.org/ontologies/pico/AggregationMethod"></see></summary>
    let AggregationMethod = _prefix "AggregationMethod"
    /// <summary>
    /// Abstract class, the intervention applied (procedure, materials etc)
    /// <see href="http://data.cochrane.org/ontologies/pico/AppliedIntervention"></see></summary>
    let AppliedIntervention = _prefix "AppliedIntervention"
    /// <summary>
    /// Outcome assessment scale, e.g. SCTID:273249006
    /// <see href="http://data.cochrane.org/ontologies/pico/AssessmentScale"></see></summary>
    let AssessmentScale = _prefix "AssessmentScale"
    /// <summary>
    /// Conditions for example illness or disease.
    /// <see href="http://data.cochrane.org/ontologies/pico/Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// Dose in an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/Dose"></see></summary>
    let Dose = _prefix "Dose"
    /// <summary>
    /// Duration of some action
    /// <see href="http://data.cochrane.org/ontologies/pico/Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    /// An intervention in a PICO question is an action under consideration for this population.
    /// <see href="http://data.cochrane.org/ontologies/pico/Intervention"></see></summary>
    let Intervention = _prefix "Intervention"
    /// <summary>
    /// The type of intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/InterventionClassification"></see></summary>
    let InterventionClassification = _prefix "InterventionClassification"
    /// <summary>
    /// An intervention group is a group of interventions for example an arm of a trial.
    /// <see href="http://data.cochrane.org/ontologies/pico/InterventionGroup"></see></summary>
    let InterventionGroup = _prefix "InterventionGroup"
    /// <summary>
    /// The provider of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/InterventionProvider"></see></summary>
    let InterventionProvider = _prefix "InterventionProvider"
    /// <summary>
    /// The rationale of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/InterventionRationale"></see></summary>
    let InterventionRationale = _prefix "InterventionRationale"
    /// <summary>
    /// Mode of delivery for an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/ModeOfDelivery"></see></summary>
    let ModeOfDelivery = _prefix "ModeOfDelivery"
    /// <summary>
    /// The desired outcome of an intervention.
    /// <see href="http://data.cochrane.org/ontologies/pico/Outcome"></see></summary>
    let Outcome = _prefix "Outcome"
    /// <summary>
    /// Classification scheme describing the type of outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/OutcomeClassification"></see></summary>
    let OutcomeClassification = _prefix "OutcomeClassification"
    /// <summary>
    /// The outcome domain, typically a Condition.
    /// <see href="http://data.cochrane.org/ontologies/pico/OutcomeDomain"></see></summary>
    let OutcomeDomain = _prefix "OutcomeDomain"
    /// <summary>
    /// An outcome group is a group of outcomes.
    /// <see href="http://data.cochrane.org/ontologies/pico/OutcomeGroup"></see></summary>
    let OutcomeGroup = _prefix "OutcomeGroup"
    /// <summary>
    /// A PICO class represents an object that defines a research or a clinical question.
    /// <see href="http://data.cochrane.org/ontologies/pico/PICO"></see></summary>
    let PICO = _prefix "PICO"
    /// <summary>
    /// A population defines a group of people/patient in a PICO question.
    /// <see href="http://data.cochrane.org/ontologies/pico/Population"></see></summary>
    let Population = _prefix "Population"
    /// <summary>
    /// Schedule of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/Schedule"></see></summary>
    let Schedule = _prefix "Schedule"
    /// <summary>
    /// Setting of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/Setting"></see></summary>
    let Setting = _prefix "Setting"
    /// <summary>
    /// The sex of a population group
    /// <see href="http://data.cochrane.org/ontologies/pico/Sex"></see></summary>
    let Sex = _prefix "Sex"
    /// <summary>
    /// Social context of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/SocialContext"></see></summary>
    let SocialContext = _prefix "SocialContext"
    /// <summary>
    /// Specific metric of an outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/SpecificMetric"></see></summary>
    let SpecificMetric = _prefix "SpecificMetric"
    /// <summary>
    /// Some treatment of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/Treatment"></see></summary>
    let Treatment = _prefix "Treatment"
    /// <summary>
    /// The age of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/age"></see></summary>
    let age = _prefix "age"
    /// <summary>
    /// The aggregation method of an outcome.
    /// <see href="http://data.cochrane.org/ontologies/pico/aggregationMethod"></see></summary>
    let aggregationMethod = _prefix "aggregationMethod"
    /// <summary>
    /// Associates an appliedIntervention (material, procedure) with a PICO Intervention instance.
    /// <see href="http://data.cochrane.org/ontologies/pico/appliedIntervention"></see></summary>
    let appliedIntervention = _prefix "appliedIntervention"
    /// <summary>
    /// The child intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/childIntervention"></see></summary>
    let childIntervention = _prefix "childIntervention"
    /// <summary>
    /// The child outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/childOutcome"></see></summary>
    let childOutcome = _prefix "childOutcome"
    /// <summary>
    /// A comparator intervention group
    /// <see href="http://data.cochrane.org/ontologies/pico/comparatorGroup"></see></summary>
    let comparatorGroup = _prefix "comparatorGroup"
    /// <summary>
    /// A precondition of the population.
    /// <see href="http://data.cochrane.org/ontologies/pico/condition"></see></summary>
    let condition = _prefix "condition"
    /// <summary>
    /// Dose used in an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/dose"></see></summary>
    let dose = _prefix "dose"
    /// <summary>
    /// duration of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// An endpoint of an outcome group, by duration
    /// <see href="http://data.cochrane.org/ontologies/pico/endpoint"></see></summary>
    let endpoint = _prefix "endpoint"
    /// <summary>
    /// An excluded intervention.
    /// <see href="http://data.cochrane.org/ontologies/pico/excludedIntervention"></see></summary>
    let excludedIntervention = _prefix "excludedIntervention"
    /// <summary>
    /// An excluded outcome.
    /// <see href="http://data.cochrane.org/ontologies/pico/excludedOutcome"></see></summary>
    let excludedOutcome = _prefix "excludedOutcome"
    /// <summary>
    /// An excluded sub-population.
    /// <see href="http://data.cochrane.org/ontologies/pico/excludedPopulation"></see></summary>
    let excludedPopulation = _prefix "excludedPopulation"
    /// <summary>
    /// An intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/intervention"></see></summary>
    let intervention = _prefix "intervention"
    /// <summary>
    /// The type of intervention.
    /// <see href="http://data.cochrane.org/ontologies/pico/interventionClassification"></see></summary>
    let interventionClassification = _prefix "interventionClassification"
    /// <summary>
    /// An intervention group
    /// <see href="http://data.cochrane.org/ontologies/pico/interventionGroup"></see></summary>
    let interventionGroup = _prefix "interventionGroup"
    /// <summary>
    /// Intervention provider of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/interventionProvider"></see></summary>
    let interventionProvider = _prefix "interventionProvider"
    /// <summary>
    /// Rationale of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/interventionRationale"></see></summary>
    let interventionRationale = _prefix "interventionRationale"
    /// <summary>
    /// The comparator flag (Deprecated).
    /// <see href="http://data.cochrane.org/ontologies/pico/isComparator"></see></summary>
    let isComparator = _prefix "isComparator"
    /// <summary>
    /// mode of delivery
    /// <see href="http://data.cochrane.org/ontologies/pico/modeOfDelivery"></see></summary>
    let modeOfDelivery = _prefix "modeOfDelivery"
    /// <summary>
    /// The number of participants in a population an intervention is being applied to
    /// <see href="http://data.cochrane.org/ontologies/pico/numberOfParticipants"></see></summary>
    let numberOfParticipants = _prefix "numberOfParticipants"
    /// <summary>
    /// Relates a outcome group to an outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/outcome"></see></summary>
    let outcome = _prefix "outcome"
    /// <summary>
    /// The type of outcome.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeClassification"></see></summary>
    let outcomeClassification = _prefix "outcomeClassification"
    /// <summary>
    /// The domain of an outome, e.g. a side effect outcome, typically a condition.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeDomain"></see></summary>
    let outcomeDomain = _prefix "outcomeDomain"
    /// <summary>
    /// Relates a pico to an outcome group
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeGroup"></see></summary>
    let outcomeGroup = _prefix "outcomeGroup"
    /// <summary>
    /// The outcome measurement assessment scale.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeMeasurement"></see></summary>
    let outcomeMeasurement = _prefix "outcomeMeasurement"
    /// <summary>
    /// Free text associated with an Outcome.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeText"></see></summary>
    let outcomeText = _prefix "outcomeText"
    /// <summary>
    /// The outcome treatment.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeTreatment"></see></summary>
    let outcomeTreatment = _prefix "outcomeTreatment"
    /// <summary>
    /// The parent intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/parentIntervention"></see></summary>
    let parentIntervention = _prefix "parentIntervention"
    /// <summary>
    /// References the parent outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/parentOutcome"></see></summary>
    let parentOutcome = _prefix "parentOutcome"
    /// <summary>
    /// A population
    /// <see href="http://data.cochrane.org/ontologies/pico/population"></see></summary>
    let population = _prefix "population"
    /// <summary>
    /// The primary endpoint of an outcome group, by duration
    /// <see href="http://data.cochrane.org/ontologies/pico/primaryEndpoint"></see></summary>
    let primaryEndpoint = _prefix "primaryEndpoint"
    /// <summary>
    /// schedule of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/schedule"></see></summary>
    let schedule = _prefix "schedule"
    /// <summary>
    /// setting of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/setting"></see></summary>
    let setting = _prefix "setting"
    /// <summary>
    /// The sex of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/sex"></see></summary>
    let sex = _prefix "sex"
    /// <summary>
    /// The social context of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/socialContext"></see></summary>
    let socialContext = _prefix "socialContext"
    /// <summary>
    /// A treatment of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/treatment"></see></summary>
    let treatment = _prefix "treatment"
