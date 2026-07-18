namespace http.data.cochrane.org.ontologies.core.slash

open DoxAletheia.Rdf_Vocabulary

module cochrane =
    let _namespace_name = "http://data.cochrane.org/ontologies/core/"
    /// <summary>
    /// A Age of some defined population.
    /// <see href="http://data.cochrane.org/ontologies/core/Age"></see></summary>
    let Age = Namespaced_IRI.parse _namespace_name "Age" |> NamespacedName
    /// <summary>
    /// A vocabulary concept
    /// <see href="http://data.cochrane.org/ontologies/core/Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    /// An Aggregation method used in defining an outcome.
    /// <see href="http://data.cochrane.org/ontologies/core/AggregationMethod"></see></summary>
    let AggregationMethod =
        Namespaced_IRI.parse _namespace_name "AggregationMethod" |> NamespacedName

    /// <summary>
    /// Am applied intervention used to treat some condition
    /// <see href="http://data.cochrane.org/ontologies/core/AppliedIntervention"></see></summary>
    let AppliedIntervention =
        Namespaced_IRI.parse _namespace_name "AppliedIntervention" |> NamespacedName

    /// <summary>
    /// An AssessmentScale that an outcome is measured against.
    /// <see href="http://data.cochrane.org/ontologies/core/AssessmentScale"></see></summary>
    let AssessmentScale =
        Namespaced_IRI.parse _namespace_name "AssessmentScale" |> NamespacedName

    /// <summary>
    /// A Thing
    /// <see href="http://data.cochrane.org/ontologies/core/Thing"></see></summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName

    /// <summary>
    /// A scheme that a concept exists within
    /// <see href="http://data.cochrane.org/ontologies/core/ConceptScheme"></see></summary>
    let ConceptScheme =
        Namespaced_IRI.parse _namespace_name "ConceptScheme" |> NamespacedName

    /// <summary>
    /// A Condition of some defined population.
    /// <see href="http://data.cochrane.org/ontologies/core/Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    /// A Device used as intervention
    /// <see href="http://data.cochrane.org/ontologies/core/Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    /// A material used as intervention
    /// <see href="http://data.cochrane.org/ontologies/core/Material"></see></summary>
    let Material = Namespaced_IRI.parse _namespace_name "Material" |> NamespacedName

    /// <summary>
    /// A category or class of Device
    /// <see href="http://data.cochrane.org/ontologies/core/DeviceCategory"></see></summary>
    let DeviceCategory =
        Namespaced_IRI.parse _namespace_name "DeviceCategory" |> NamespacedName

    /// <summary>
    /// A category or class of applied intervention
    /// <see href="http://data.cochrane.org/ontologies/core/InterventionCategory"></see></summary>
    let InterventionCategory =
        Namespaced_IRI.parse _namespace_name "InterventionCategory" |> NamespacedName

    /// <summary>
    /// A Drug used as intervention
    /// <see href="http://data.cochrane.org/ontologies/core/Drug"></see></summary>
    let Drug = Namespaced_IRI.parse _namespace_name "Drug" |> NamespacedName

    /// <summary>
    /// A category or class of drug
    /// <see href="http://data.cochrane.org/ontologies/core/DrugCategory"></see></summary>
    let DrugCategory =
        Namespaced_IRI.parse _namespace_name "DrugCategory" |> NamespacedName

    /// <summary>
    /// The classification of an intervention.
    /// <see href="http://data.cochrane.org/ontologies/core/InterventionClassification"></see></summary>
    let InterventionClassification =
        Namespaced_IRI.parse _namespace_name "InterventionClassification" |> NamespacedName

    /// <summary>
    /// Some agent that provides or delivers an intervention.
    /// <see href="http://data.cochrane.org/ontologies/core/InterventionProvider"></see></summary>
    let InterventionProvider =
        Namespaced_IRI.parse _namespace_name "InterventionProvider" |> NamespacedName

    /// <summary>
    /// The rationale for providing an intervention.
    /// <see href="http://data.cochrane.org/ontologies/core/InterventionRationale"></see></summary>
    let InterventionRationale =
        Namespaced_IRI.parse _namespace_name "InterventionRationale" |> NamespacedName

    /// <summary>
    /// The mechanism by which an intervention is delivered.
    /// <see href="http://data.cochrane.org/ontologies/core/ModeOfDelivery"></see></summary>
    let ModeOfDelivery =
        Namespaced_IRI.parse _namespace_name "ModeOfDelivery" |> NamespacedName

    /// <summary>
    /// The classification of an outcome.
    /// <see href="http://data.cochrane.org/ontologies/core/OutcomeClassification"></see></summary>
    let OutcomeClassification =
        Namespaced_IRI.parse _namespace_name "OutcomeClassification" |> NamespacedName

    /// <summary>
    /// A Procedure used as intervention
    /// <see href="http://data.cochrane.org/ontologies/core/Procedure"></see></summary>
    let Procedure = Namespaced_IRI.parse _namespace_name "Procedure" |> NamespacedName

    /// <summary>
    /// A category or class of procedure
    /// <see href="http://data.cochrane.org/ontologies/core/ProcedureCategory"></see></summary>
    let ProcedureCategory =
        Namespaced_IRI.parse _namespace_name "ProcedureCategory" |> NamespacedName

    /// <summary>
    /// The setting in which an intervention is delivered (eg clininc, hospital, at home).
    /// <see href="http://data.cochrane.org/ontologies/core/Setting"></see></summary>
    let Setting = Namespaced_IRI.parse _namespace_name "Setting" |> NamespacedName
    /// <summary>
    /// A Sex of some defined population.
    /// <see href="http://data.cochrane.org/ontologies/core/Sex"></see></summary>
    let Sex = Namespaced_IRI.parse _namespace_name "Sex" |> NamespacedName

    /// <summary>
    /// A specific metric used in defining an outcome.
    /// <see href="http://data.cochrane.org/ontologies/core/SpecificMetric"></see></summary>
    let SpecificMetric =
        Namespaced_IRI.parse _namespace_name "SpecificMetric" |> NamespacedName

    /// <summary>
    /// A Treatment some population is undergoing.
    /// <see href="http://data.cochrane.org/ontologies/core/Treatment"></see></summary>
    let Treatment = Namespaced_IRI.parse _namespace_name "Treatment" |> NamespacedName

    /// <summary>
    /// The alternate label or synonym of something.
    /// <see href="http://data.cochrane.org/ontologies/core/alternateLabel"></see></summary>
    let alternateLabel =
        Namespaced_IRI.parse _namespace_name "alternateLabel" |> NamespacedName

    /// <summary>
    /// Relates a Concept to a broader one in the same concept scheme.
    /// <see href="http://data.cochrane.org/ontologies/core/broaderConcept"></see></summary>
    let broaderConcept =
        Namespaced_IRI.parse _namespace_name "broaderConcept" |> NamespacedName

    /// <summary>
    /// Relates a Concept to an equivalent one.
    /// <see href="http://data.cochrane.org/ontologies/core/equivalentConcept"></see></summary>
    let equivalentConcept =
        Namespaced_IRI.parse _namespace_name "equivalentConcept" |> NamespacedName

    /// <summary>
    /// Relates an intervention to an intervention category.
    /// <see href="http://data.cochrane.org/ontologies/core/inCategory"></see></summary>
    let inCategory = Namespaced_IRI.parse _namespace_name "inCategory" |> NamespacedName

    /// <summary>
    /// Relates a Concept to its ConceptScheme
    /// <see href="http://data.cochrane.org/ontologies/core/inConceptScheme"></see></summary>
    let inConceptScheme =
        Namespaced_IRI.parse _namespace_name "inConceptScheme" |> NamespacedName

    /// <summary>
    /// The label of something.
    /// <see href="http://data.cochrane.org/ontologies/core/label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName

    /// <summary>
    /// The date/time a concept was last modified (workflow/provenance).
    /// <see href="http://data.cochrane.org/ontologies/core/lastModifiedDate"></see></summary>
    let lastModifiedDate =
        Namespaced_IRI.parse _namespace_name "lastModifiedDate" |> NamespacedName

    /// <summary>
    /// The long label of something.
    /// <see href="http://data.cochrane.org/ontologies/core/longLabel"></see></summary>
    let longLabel = Namespaced_IRI.parse _namespace_name "longLabel" |> NamespacedName
    /// <summary>
    /// The agent that modified the concept (workflow/provenance).
    /// <see href="http://data.cochrane.org/ontologies/core/modifiedBy"></see></summary>
    let modifiedBy = Namespaced_IRI.parse _namespace_name "modifiedBy" |> NamespacedName

    /// <summary>
    /// Relates a Concept to a narrower one in the same concept scheme.
    /// <see href="http://data.cochrane.org/ontologies/core/narrowerConcept"></see></summary>
    let narrowerConcept =
        Namespaced_IRI.parse _namespace_name "narrowerConcept" |> NamespacedName

    /// <summary>
    /// The short label of something.
    /// <see href="http://data.cochrane.org/ontologies/core/shortLabel"></see></summary>
    let shortLabel = Namespaced_IRI.parse _namespace_name "shortLabel" |> NamespacedName
