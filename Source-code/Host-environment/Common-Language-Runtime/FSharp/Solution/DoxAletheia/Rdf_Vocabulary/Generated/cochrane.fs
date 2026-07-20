namespace http.data.cochrane.org.ontologies.core.slash

open DoxAletheia

module cochrane =
    let _namespace_name = "http://data.cochrane.org/ontologies/core/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Age of some defined population.
    /// <see href="http://data.cochrane.org/ontologies/core/Age"></see></summary>
    let Age = _prefix "Age"
    /// <summary>
    /// A vocabulary concept
    /// <see href="http://data.cochrane.org/ontologies/core/Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// An Aggregation method used in defining an outcome.
    /// <see href="http://data.cochrane.org/ontologies/core/AggregationMethod"></see></summary>
    let AggregationMethod = _prefix "AggregationMethod"
    /// <summary>
    /// Am applied intervention used to treat some condition
    /// <see href="http://data.cochrane.org/ontologies/core/AppliedIntervention"></see></summary>
    let AppliedIntervention = _prefix "AppliedIntervention"
    /// <summary>
    /// An AssessmentScale that an outcome is measured against.
    /// <see href="http://data.cochrane.org/ontologies/core/AssessmentScale"></see></summary>
    let AssessmentScale = _prefix "AssessmentScale"
    /// <summary>
    /// A Thing
    /// <see href="http://data.cochrane.org/ontologies/core/Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    /// A scheme that a concept exists within
    /// <see href="http://data.cochrane.org/ontologies/core/ConceptScheme"></see></summary>
    let ConceptScheme = _prefix "ConceptScheme"
    /// <summary>
    /// A Condition of some defined population.
    /// <see href="http://data.cochrane.org/ontologies/core/Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// A Device used as intervention
    /// <see href="http://data.cochrane.org/ontologies/core/Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// A material used as intervention
    /// <see href="http://data.cochrane.org/ontologies/core/Material"></see></summary>
    let Material = _prefix "Material"
    /// <summary>
    /// A category or class of Device
    /// <see href="http://data.cochrane.org/ontologies/core/DeviceCategory"></see></summary>
    let DeviceCategory = _prefix "DeviceCategory"
    /// <summary>
    /// A category or class of applied intervention
    /// <see href="http://data.cochrane.org/ontologies/core/InterventionCategory"></see></summary>
    let InterventionCategory = _prefix "InterventionCategory"
    /// <summary>
    /// A Drug used as intervention
    /// <see href="http://data.cochrane.org/ontologies/core/Drug"></see></summary>
    let Drug = _prefix "Drug"
    /// <summary>
    /// A category or class of drug
    /// <see href="http://data.cochrane.org/ontologies/core/DrugCategory"></see></summary>
    let DrugCategory = _prefix "DrugCategory"
    /// <summary>
    /// The classification of an intervention.
    /// <see href="http://data.cochrane.org/ontologies/core/InterventionClassification"></see></summary>
    let InterventionClassification = _prefix "InterventionClassification"
    /// <summary>
    /// Some agent that provides or delivers an intervention.
    /// <see href="http://data.cochrane.org/ontologies/core/InterventionProvider"></see></summary>
    let InterventionProvider = _prefix "InterventionProvider"
    /// <summary>
    /// The rationale for providing an intervention.
    /// <see href="http://data.cochrane.org/ontologies/core/InterventionRationale"></see></summary>
    let InterventionRationale = _prefix "InterventionRationale"
    /// <summary>
    /// The mechanism by which an intervention is delivered.
    /// <see href="http://data.cochrane.org/ontologies/core/ModeOfDelivery"></see></summary>
    let ModeOfDelivery = _prefix "ModeOfDelivery"
    /// <summary>
    /// The classification of an outcome.
    /// <see href="http://data.cochrane.org/ontologies/core/OutcomeClassification"></see></summary>
    let OutcomeClassification = _prefix "OutcomeClassification"
    /// <summary>
    /// A Procedure used as intervention
    /// <see href="http://data.cochrane.org/ontologies/core/Procedure"></see></summary>
    let Procedure = _prefix "Procedure"
    /// <summary>
    /// A category or class of procedure
    /// <see href="http://data.cochrane.org/ontologies/core/ProcedureCategory"></see></summary>
    let ProcedureCategory = _prefix "ProcedureCategory"
    /// <summary>
    /// The setting in which an intervention is delivered (eg clininc, hospital, at home).
    /// <see href="http://data.cochrane.org/ontologies/core/Setting"></see></summary>
    let Setting = _prefix "Setting"
    /// <summary>
    /// A Sex of some defined population.
    /// <see href="http://data.cochrane.org/ontologies/core/Sex"></see></summary>
    let Sex = _prefix "Sex"
    /// <summary>
    /// A specific metric used in defining an outcome.
    /// <see href="http://data.cochrane.org/ontologies/core/SpecificMetric"></see></summary>
    let SpecificMetric = _prefix "SpecificMetric"
    /// <summary>
    /// A Treatment some population is undergoing.
    /// <see href="http://data.cochrane.org/ontologies/core/Treatment"></see></summary>
    let Treatment = _prefix "Treatment"
    /// <summary>
    /// The alternate label or synonym of something.
    /// <see href="http://data.cochrane.org/ontologies/core/alternateLabel"></see></summary>
    let alternateLabel = _prefix "alternateLabel"
    /// <summary>
    /// Relates a Concept to a broader one in the same concept scheme.
    /// <see href="http://data.cochrane.org/ontologies/core/broaderConcept"></see></summary>
    let broaderConcept = _prefix "broaderConcept"
    /// <summary>
    /// Relates a Concept to an equivalent one.
    /// <see href="http://data.cochrane.org/ontologies/core/equivalentConcept"></see></summary>
    let equivalentConcept = _prefix "equivalentConcept"
    /// <summary>
    /// Relates an intervention to an intervention category.
    /// <see href="http://data.cochrane.org/ontologies/core/inCategory"></see></summary>
    let inCategory = _prefix "inCategory"
    /// <summary>
    /// Relates a Concept to its ConceptScheme
    /// <see href="http://data.cochrane.org/ontologies/core/inConceptScheme"></see></summary>
    let inConceptScheme = _prefix "inConceptScheme"
    /// <summary>
    /// The label of something.
    /// <see href="http://data.cochrane.org/ontologies/core/label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// The date/time a concept was last modified (workflow/provenance).
    /// <see href="http://data.cochrane.org/ontologies/core/lastModifiedDate"></see></summary>
    let lastModifiedDate = _prefix "lastModifiedDate"
    /// <summary>
    /// The long label of something.
    /// <see href="http://data.cochrane.org/ontologies/core/longLabel"></see></summary>
    let longLabel = _prefix "longLabel"
    /// <summary>
    /// The agent that modified the concept (workflow/provenance).
    /// <see href="http://data.cochrane.org/ontologies/core/modifiedBy"></see></summary>
    let modifiedBy = _prefix "modifiedBy"
    /// <summary>
    /// Relates a Concept to a narrower one in the same concept scheme.
    /// <see href="http://data.cochrane.org/ontologies/core/narrowerConcept"></see></summary>
    let narrowerConcept = _prefix "narrowerConcept"
    /// <summary>
    /// The short label of something.
    /// <see href="http://data.cochrane.org/ontologies/core/shortLabel"></see></summary>
    let shortLabel = _prefix "shortLabel"
