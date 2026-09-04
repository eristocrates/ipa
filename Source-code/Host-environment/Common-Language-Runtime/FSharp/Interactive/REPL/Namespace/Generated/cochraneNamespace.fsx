#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cochrane =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.cochrane.org/ontologies/core/" "cochrane"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Age</para>
    ///   <para>rdfs:comment : A Age of some defined population.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Age">cochrane:Age</a>
    /// </summary>
    let Age = _prefixId.prefix "Age"
    /// <summary>
    ///   <para>rdfs:label : AggregationMethod</para>
    ///   <para>rdfs:comment : An Aggregation method used in defining an outcome.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/AggregationMethod">cochrane:AggregationMethod</a>
    /// </summary>
    let AggregationMethod = _prefixId.prefix "AggregationMethod"
    /// <summary>
    ///   <para>rdfs:label : AppliedIntervention</para>
    ///   <para>rdfs:comment : Am applied intervention used to treat some condition</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/AppliedIntervention">cochrane:AppliedIntervention</a>
    /// </summary>
    let AppliedIntervention = _prefixId.prefix "AppliedIntervention"
    /// <summary>
    ///   <para>rdfs:label : AssessmentScale</para>
    ///   <para>rdfs:comment : An AssessmentScale that an outcome is measured against.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/AssessmentScale">cochrane:AssessmentScale</a>
    /// </summary>
    let AssessmentScale = _prefixId.prefix "AssessmentScale"
    /// <summary>
    ///   <para>rdfs:label : Concept</para>
    ///   <para>rdfs:comment : A vocabulary concept</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Concept">cochrane:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>rdfs:label : ConceptScheme</para>
    ///   <para>rdfs:comment : A scheme that a concept exists within</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/ConceptScheme">cochrane:ConceptScheme</a>
    /// </summary>
    let ConceptScheme = _prefixId.prefix "ConceptScheme"
    /// <summary>
    ///   <para>rdfs:label : Condition</para>
    ///   <para>rdfs:comment : A Condition of some defined population.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Condition">cochrane:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:label : Device</para>
    ///   <para>rdfs:comment : A Device used as intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Device">cochrane:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>rdfs:label : DeviceCategory</para>
    ///   <para>rdfs:comment : A category or class of Device</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/DeviceCategory">cochrane:DeviceCategory</a>
    /// </summary>
    let DeviceCategory = _prefixId.prefix "DeviceCategory"
    /// <summary>
    ///   <para>rdfs:label : Drug</para>
    ///   <para>rdfs:comment : A Drug used as intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Drug">cochrane:Drug</a>
    /// </summary>
    let Drug = _prefixId.prefix "Drug"
    /// <summary>
    ///   <para>rdfs:label : DrugCategory</para>
    ///   <para>rdfs:comment : A category or class of drug</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/DrugCategory">cochrane:DrugCategory</a>
    /// </summary>
    let DrugCategory = _prefixId.prefix "DrugCategory"
    /// <summary>
    ///   <para>rdfs:label : InterventionCategory</para>
    ///   <para>rdfs:comment : A category or class of applied intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/InterventionCategory">cochrane:InterventionCategory</a>
    /// </summary>
    let InterventionCategory = _prefixId.prefix "InterventionCategory"
    /// <summary>
    ///   <para>rdfs:label : InterventionClassification</para>
    ///   <para>rdfs:comment : The classification of an intervention.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/InterventionClassification">cochrane:InterventionClassification</a>
    /// </summary>
    let InterventionClassification = _prefixId.prefix "InterventionClassification"
    /// <summary>
    ///   <para>rdfs:label : InterventionProvider</para>
    ///   <para>rdfs:comment : Some agent that provides or delivers an intervention.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/InterventionProvider">cochrane:InterventionProvider</a>
    /// </summary>
    let InterventionProvider = _prefixId.prefix "InterventionProvider"
    /// <summary>
    ///   <para>rdfs:label : InterventionRationale</para>
    ///   <para>rdfs:comment : The rationale for providing an intervention.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/InterventionRationale">cochrane:InterventionRationale</a>
    /// </summary>
    let InterventionRationale = _prefixId.prefix "InterventionRationale"
    /// <summary>
    ///   <para>rdfs:label : Material</para>
    ///   <para>rdfs:comment : A material used as intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Material">cochrane:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:label : ModeOfDelivery</para>
    ///   <para>rdfs:comment : The mechanism by which an intervention is delivered.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/ModeOfDelivery">cochrane:ModeOfDelivery</a>
    /// </summary>
    let ModeOfDelivery = _prefixId.prefix "ModeOfDelivery"
    /// <summary>
    ///   <para>rdfs:label : OutcomeClassification</para>
    ///   <para>rdfs:comment : The classification of an outcome.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/OutcomeClassification">cochrane:OutcomeClassification</a>
    /// </summary>
    let OutcomeClassification = _prefixId.prefix "OutcomeClassification"
    /// <summary>
    ///   <para>rdfs:label : Procedure</para>
    ///   <para>rdfs:comment : A Procedure used as intervention</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Procedure">cochrane:Procedure</a>
    /// </summary>
    let Procedure = _prefixId.prefix "Procedure"
    /// <summary>
    ///   <para>rdfs:label : ProcedureCategory</para>
    ///   <para>rdfs:comment : A category or class of procedure</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/ProcedureCategory">cochrane:ProcedureCategory</a>
    /// </summary>
    let ProcedureCategory = _prefixId.prefix "ProcedureCategory"
    /// <summary>
    ///   <para>rdfs:label : Setting</para>
    ///   <para>rdfs:comment : The setting in which an intervention is delivered (eg clininc, hospital, at home).</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Setting">cochrane:Setting</a>
    /// </summary>
    let Setting = _prefixId.prefix "Setting"
    /// <summary>
    ///   <para>rdfs:label : Sex</para>
    ///   <para>rdfs:comment : A Sex of some defined population.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Sex">cochrane:Sex</a>
    /// </summary>
    let Sex = _prefixId.prefix "Sex"
    /// <summary>
    ///   <para>rdfs:label : SpecificMetric</para>
    ///   <para>rdfs:comment : A specific metric used in defining an outcome.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/SpecificMetric">cochrane:SpecificMetric</a>
    /// </summary>
    let SpecificMetric = _prefixId.prefix "SpecificMetric"
    /// <summary>
    ///   <para>rdfs:label : Thing</para>
    ///   <para>rdfs:comment : A Thing</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Thing">cochrane:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>rdfs:label : Treatment</para>
    ///   <para>rdfs:comment : A Treatment some population is undergoing.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/Treatment">cochrane:Treatment</a>
    /// </summary>
    let Treatment = _prefixId.prefix "Treatment"
    /// <summary>
    ///   <para>rdfs:comment : The alternate label or synonym of something.</para>
    ///   <para>rdfs:alternateLabel : alternateLabel</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/alternateLabel">cochrane:alternateLabel</a>
    /// </summary>
    let alternateLabel = _prefixId.prefix "alternateLabel"
    /// <summary>
    ///   <para>rdfs:label : broaderConcept</para>
    ///   <para>rdfs:comment : Relates a Concept to a broader one in the same concept scheme.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/broaderConcept">cochrane:broaderConcept</a>
    /// </summary>
    let broaderConcept = _prefixId.prefix "broaderConcept"
    /// <summary>
    ///   <para>rdfs:label : equivalentConcept</para>
    ///   <para>rdfs:comment : Relates a Concept to an equivalent one.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/equivalentConcept">cochrane:equivalentConcept</a>
    /// </summary>
    let equivalentConcept = _prefixId.prefix "equivalentConcept"
    /// <summary>
    ///   <para>rdfs:label : inCategory</para>
    ///   <para>rdfs:comment : Relates an intervention to an intervention category.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/inCategory">cochrane:inCategory</a>
    /// </summary>
    let inCategory = _prefixId.prefix "inCategory"
    /// <summary>
    ///   <para>rdfs:label : inConceptScheme</para>
    ///   <para>rdfs:comment : Relates a Concept to its ConceptScheme</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/inConceptScheme">cochrane:inConceptScheme</a>
    /// </summary>
    let inConceptScheme = _prefixId.prefix "inConceptScheme"
    /// <summary>
    ///   <para>rdfs:label : label</para>
    ///   <para>rdfs:comment : The label of something.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/label">cochrane:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : lastModifiedDate</para>
    ///   <para>rdfs:comment : The date/time a concept was last modified (workflow/provenance).</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/lastModifiedDate">cochrane:lastModifiedDate</a>
    /// </summary>
    let lastModifiedDate = _prefixId.prefix "lastModifiedDate"
    /// <summary>
    ///   <para>rdfs:longLabel : longLabel</para>
    ///   <para>rdfs:comment : The long label of something.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/longLabel">cochrane:longLabel</a>
    /// </summary>
    let longLabel = _prefixId.prefix "longLabel"
    /// <summary>
    ///   <para>rdfs:label : modifiedBy</para>
    ///   <para>rdfs:comment : The agent that modified the concept (workflow/provenance).</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/modifiedBy">cochrane:modifiedBy</a>
    /// </summary>
    let modifiedBy = _prefixId.prefix "modifiedBy"
    /// <summary>
    ///   <para>rdfs:label : narrowerConcept</para>
    ///   <para>rdfs:comment : Relates a Concept to a narrower one in the same concept scheme.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/narrowerConcept">cochrane:narrowerConcept</a>
    /// </summary>
    let narrowerConcept = _prefixId.prefix "narrowerConcept"
    /// <summary>
    ///   <para>rdfs:shortLabel : shortLabel</para>
    ///   <para>rdfs:comment : The short label of something.</para>
    ///   <a href="http://data.cochrane.org/ontologies/core/shortLabel">cochrane:shortLabel</a>
    /// </summary>
    let shortLabel = _prefixId.prefix "shortLabel"
