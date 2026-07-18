namespace http.data.cochrane.org.ontologies.pico.slash

open DoxAletheia.Rdf_Vocabulary

module pico =
    let _namespace_name = "http://data.cochrane.org/ontologies/pico/"
    /// <summary>
    /// The age of a population group
    /// <see href="http://data.cochrane.org/ontologies/pico/Age"></see></summary>
    let Age = Namespaced_IRI.parse _namespace_name "Age" |> NamespacedName

    /// <summary>
    /// Outcome aggregation method
    /// <see href="http://data.cochrane.org/ontologies/pico/AggregationMethod"></see></summary>
    let AggregationMethod =
        Namespaced_IRI.parse _namespace_name "AggregationMethod" |> NamespacedName

    /// <summary>
    /// Abstract class, the intervention applied (procedure, materials etc)
    /// <see href="http://data.cochrane.org/ontologies/pico/AppliedIntervention"></see></summary>
    let AppliedIntervention =
        Namespaced_IRI.parse _namespace_name "AppliedIntervention" |> NamespacedName

    /// <summary>
    /// Outcome assessment scale, e.g. SCTID:273249006
    /// <see href="http://data.cochrane.org/ontologies/pico/AssessmentScale"></see></summary>
    let AssessmentScale =
        Namespaced_IRI.parse _namespace_name "AssessmentScale" |> NamespacedName

    /// <summary>
    /// Conditions for example illness or disease.
    /// <see href="http://data.cochrane.org/ontologies/pico/Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    /// Dose in an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/Dose"></see></summary>
    let Dose = Namespaced_IRI.parse _namespace_name "Dose" |> NamespacedName
    /// <summary>
    /// Duration of some action
    /// <see href="http://data.cochrane.org/ontologies/pico/Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName

    /// <summary>
    /// An intervention in a PICO question is an action under consideration for this population.
    /// <see href="http://data.cochrane.org/ontologies/pico/Intervention"></see></summary>
    let Intervention =
        Namespaced_IRI.parse _namespace_name "Intervention" |> NamespacedName

    /// <summary>
    /// The type of intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/InterventionClassification"></see></summary>
    let InterventionClassification =
        Namespaced_IRI.parse _namespace_name "InterventionClassification" |> NamespacedName

    /// <summary>
    /// An intervention group is a group of interventions for example an arm of a trial.
    /// <see href="http://data.cochrane.org/ontologies/pico/InterventionGroup"></see></summary>
    let InterventionGroup =
        Namespaced_IRI.parse _namespace_name "InterventionGroup" |> NamespacedName

    /// <summary>
    /// The provider of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/InterventionProvider"></see></summary>
    let InterventionProvider =
        Namespaced_IRI.parse _namespace_name "InterventionProvider" |> NamespacedName

    /// <summary>
    /// The rationale of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/InterventionRationale"></see></summary>
    let InterventionRationale =
        Namespaced_IRI.parse _namespace_name "InterventionRationale" |> NamespacedName

    /// <summary>
    /// Mode of delivery for an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/ModeOfDelivery"></see></summary>
    let ModeOfDelivery =
        Namespaced_IRI.parse _namespace_name "ModeOfDelivery" |> NamespacedName

    /// <summary>
    /// The desired outcome of an intervention.
    /// <see href="http://data.cochrane.org/ontologies/pico/Outcome"></see></summary>
    let Outcome = Namespaced_IRI.parse _namespace_name "Outcome" |> NamespacedName

    /// <summary>
    /// Classification scheme describing the type of outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/OutcomeClassification"></see></summary>
    let OutcomeClassification =
        Namespaced_IRI.parse _namespace_name "OutcomeClassification" |> NamespacedName

    /// <summary>
    /// The outcome domain, typically a Condition.
    /// <see href="http://data.cochrane.org/ontologies/pico/OutcomeDomain"></see></summary>
    let OutcomeDomain =
        Namespaced_IRI.parse _namespace_name "OutcomeDomain" |> NamespacedName

    /// <summary>
    /// An outcome group is a group of outcomes.
    /// <see href="http://data.cochrane.org/ontologies/pico/OutcomeGroup"></see></summary>
    let OutcomeGroup =
        Namespaced_IRI.parse _namespace_name "OutcomeGroup" |> NamespacedName

    /// <summary>
    /// A PICO class represents an object that defines a research or a clinical question.
    /// <see href="http://data.cochrane.org/ontologies/pico/PICO"></see></summary>
    let PICO = Namespaced_IRI.parse _namespace_name "PICO" |> NamespacedName
    /// <summary>
    /// A population defines a group of people/patient in a PICO question.
    /// <see href="http://data.cochrane.org/ontologies/pico/Population"></see></summary>
    let Population = Namespaced_IRI.parse _namespace_name "Population" |> NamespacedName
    /// <summary>
    /// Schedule of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/Schedule"></see></summary>
    let Schedule = Namespaced_IRI.parse _namespace_name "Schedule" |> NamespacedName
    /// <summary>
    /// Setting of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/Setting"></see></summary>
    let Setting = Namespaced_IRI.parse _namespace_name "Setting" |> NamespacedName
    /// <summary>
    /// The sex of a population group
    /// <see href="http://data.cochrane.org/ontologies/pico/Sex"></see></summary>
    let Sex = Namespaced_IRI.parse _namespace_name "Sex" |> NamespacedName

    /// <summary>
    /// Social context of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/SocialContext"></see></summary>
    let SocialContext =
        Namespaced_IRI.parse _namespace_name "SocialContext" |> NamespacedName

    /// <summary>
    /// Specific metric of an outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/SpecificMetric"></see></summary>
    let SpecificMetric =
        Namespaced_IRI.parse _namespace_name "SpecificMetric" |> NamespacedName

    /// <summary>
    /// Some treatment of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/Treatment"></see></summary>
    let Treatment = Namespaced_IRI.parse _namespace_name "Treatment" |> NamespacedName
    /// <summary>
    /// The age of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/age"></see></summary>
    let age = Namespaced_IRI.parse _namespace_name "age" |> NamespacedName

    /// <summary>
    /// The aggregation method of an outcome.
    /// <see href="http://data.cochrane.org/ontologies/pico/aggregationMethod"></see></summary>
    let aggregationMethod =
        Namespaced_IRI.parse _namespace_name "aggregationMethod" |> NamespacedName

    /// <summary>
    /// Associates an appliedIntervention (material, procedure) with a PICO Intervention instance.
    /// <see href="http://data.cochrane.org/ontologies/pico/appliedIntervention"></see></summary>
    let appliedIntervention =
        Namespaced_IRI.parse _namespace_name "appliedIntervention" |> NamespacedName

    /// <summary>
    /// The child intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/childIntervention"></see></summary>
    let childIntervention =
        Namespaced_IRI.parse _namespace_name "childIntervention" |> NamespacedName

    /// <summary>
    /// The child outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/childOutcome"></see></summary>
    let childOutcome =
        Namespaced_IRI.parse _namespace_name "childOutcome" |> NamespacedName

    /// <summary>
    /// A comparator intervention group
    /// <see href="http://data.cochrane.org/ontologies/pico/comparatorGroup"></see></summary>
    let comparatorGroup =
        Namespaced_IRI.parse _namespace_name "comparatorGroup" |> NamespacedName

    /// <summary>
    /// A precondition of the population.
    /// <see href="http://data.cochrane.org/ontologies/pico/condition"></see></summary>
    let condition = Namespaced_IRI.parse _namespace_name "condition" |> NamespacedName
    /// <summary>
    /// Dose used in an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/dose"></see></summary>
    let dose = Namespaced_IRI.parse _namespace_name "dose" |> NamespacedName
    /// <summary>
    /// duration of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// An endpoint of an outcome group, by duration
    /// <see href="http://data.cochrane.org/ontologies/pico/endpoint"></see></summary>
    let endpoint = Namespaced_IRI.parse _namespace_name "endpoint" |> NamespacedName

    /// <summary>
    /// An excluded intervention.
    /// <see href="http://data.cochrane.org/ontologies/pico/excludedIntervention"></see></summary>
    let excludedIntervention =
        Namespaced_IRI.parse _namespace_name "excludedIntervention" |> NamespacedName

    /// <summary>
    /// An excluded outcome.
    /// <see href="http://data.cochrane.org/ontologies/pico/excludedOutcome"></see></summary>
    let excludedOutcome =
        Namespaced_IRI.parse _namespace_name "excludedOutcome" |> NamespacedName

    /// <summary>
    /// An excluded sub-population.
    /// <see href="http://data.cochrane.org/ontologies/pico/excludedPopulation"></see></summary>
    let excludedPopulation =
        Namespaced_IRI.parse _namespace_name "excludedPopulation" |> NamespacedName

    /// <summary>
    /// An intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/intervention"></see></summary>
    let intervention =
        Namespaced_IRI.parse _namespace_name "intervention" |> NamespacedName

    /// <summary>
    /// The type of intervention.
    /// <see href="http://data.cochrane.org/ontologies/pico/interventionClassification"></see></summary>
    let interventionClassification =
        Namespaced_IRI.parse _namespace_name "interventionClassification" |> NamespacedName

    /// <summary>
    /// An intervention group
    /// <see href="http://data.cochrane.org/ontologies/pico/interventionGroup"></see></summary>
    let interventionGroup =
        Namespaced_IRI.parse _namespace_name "interventionGroup" |> NamespacedName

    /// <summary>
    /// Intervention provider of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/interventionProvider"></see></summary>
    let interventionProvider =
        Namespaced_IRI.parse _namespace_name "interventionProvider" |> NamespacedName

    /// <summary>
    /// Rationale of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/interventionRationale"></see></summary>
    let interventionRationale =
        Namespaced_IRI.parse _namespace_name "interventionRationale" |> NamespacedName

    /// <summary>
    /// The comparator flag (Deprecated).
    /// <see href="http://data.cochrane.org/ontologies/pico/isComparator"></see></summary>
    let isComparator =
        Namespaced_IRI.parse _namespace_name "isComparator" |> NamespacedName

    /// <summary>
    /// mode of delivery
    /// <see href="http://data.cochrane.org/ontologies/pico/modeOfDelivery"></see></summary>
    let modeOfDelivery =
        Namespaced_IRI.parse _namespace_name "modeOfDelivery" |> NamespacedName

    /// <summary>
    /// The number of participants in a population an intervention is being applied to
    /// <see href="http://data.cochrane.org/ontologies/pico/numberOfParticipants"></see></summary>
    let numberOfParticipants =
        Namespaced_IRI.parse _namespace_name "numberOfParticipants" |> NamespacedName

    /// <summary>
    /// Relates a outcome group to an outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/outcome"></see></summary>
    let outcome = Namespaced_IRI.parse _namespace_name "outcome" |> NamespacedName

    /// <summary>
    /// The type of outcome.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeClassification"></see></summary>
    let outcomeClassification =
        Namespaced_IRI.parse _namespace_name "outcomeClassification" |> NamespacedName

    /// <summary>
    /// The domain of an outome, e.g. a side effect outcome, typically a condition.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeDomain"></see></summary>
    let outcomeDomain =
        Namespaced_IRI.parse _namespace_name "outcomeDomain" |> NamespacedName

    /// <summary>
    /// Relates a pico to an outcome group
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeGroup"></see></summary>
    let outcomeGroup =
        Namespaced_IRI.parse _namespace_name "outcomeGroup" |> NamespacedName

    /// <summary>
    /// The outcome measurement assessment scale.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeMeasurement"></see></summary>
    let outcomeMeasurement =
        Namespaced_IRI.parse _namespace_name "outcomeMeasurement" |> NamespacedName

    /// <summary>
    /// Free text associated with an Outcome.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeText"></see></summary>
    let outcomeText =
        Namespaced_IRI.parse _namespace_name "outcomeText" |> NamespacedName

    /// <summary>
    /// The outcome treatment.
    /// <see href="http://data.cochrane.org/ontologies/pico/outcomeTreatment"></see></summary>
    let outcomeTreatment =
        Namespaced_IRI.parse _namespace_name "outcomeTreatment" |> NamespacedName

    /// <summary>
    /// The parent intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/parentIntervention"></see></summary>
    let parentIntervention =
        Namespaced_IRI.parse _namespace_name "parentIntervention" |> NamespacedName

    /// <summary>
    /// References the parent outcome
    /// <see href="http://data.cochrane.org/ontologies/pico/parentOutcome"></see></summary>
    let parentOutcome =
        Namespaced_IRI.parse _namespace_name "parentOutcome" |> NamespacedName

    /// <summary>
    /// A population
    /// <see href="http://data.cochrane.org/ontologies/pico/population"></see></summary>
    let population = Namespaced_IRI.parse _namespace_name "population" |> NamespacedName

    /// <summary>
    /// The primary endpoint of an outcome group, by duration
    /// <see href="http://data.cochrane.org/ontologies/pico/primaryEndpoint"></see></summary>
    let primaryEndpoint =
        Namespaced_IRI.parse _namespace_name "primaryEndpoint" |> NamespacedName

    /// <summary>
    /// schedule of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/schedule"></see></summary>
    let schedule = Namespaced_IRI.parse _namespace_name "schedule" |> NamespacedName
    /// <summary>
    /// setting of an intervention
    /// <see href="http://data.cochrane.org/ontologies/pico/setting"></see></summary>
    let setting = Namespaced_IRI.parse _namespace_name "setting" |> NamespacedName
    /// <summary>
    /// The sex of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/sex"></see></summary>
    let sex = Namespaced_IRI.parse _namespace_name "sex" |> NamespacedName

    /// <summary>
    /// The social context of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/socialContext"></see></summary>
    let socialContext =
        Namespaced_IRI.parse _namespace_name "socialContext" |> NamespacedName

    /// <summary>
    /// A treatment of a population
    /// <see href="http://data.cochrane.org/ontologies/pico/treatment"></see></summary>
    let treatment = Namespaced_IRI.parse _namespace_name "treatment" |> NamespacedName
