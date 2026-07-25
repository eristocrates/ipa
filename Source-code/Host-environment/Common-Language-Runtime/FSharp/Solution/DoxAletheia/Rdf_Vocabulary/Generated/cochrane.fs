namespace http.data.cochrane.org.ontologies.core.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cochrane =
    let _namespace_iri = Namespace_Iri cochrane |> NamespaceIRI
    /// <summary>
    ///   <para>cochrane:Age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Age of some defined population.</para>
    /// labels<para>Age</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Age">http://data.cochrane.org/ontologies/core/Age</seealso>
    let Age = Prefixed_Name(cochrane, "Age") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:AppliedIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Am applied intervention used to treat some condition</para>
    /// labels<para>AppliedIntervention</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/AppliedIntervention">http://data.cochrane.org/ontologies/core/AppliedIntervention</seealso>
    let AppliedIntervention =
        Prefixed_Name(cochrane, "AppliedIntervention") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Thing</para>
    /// labels<para>Thing</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Thing">http://data.cochrane.org/ontologies/core/Thing</seealso>
    let Thing = Prefixed_Name(cochrane, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Condition of some defined population.</para>
    /// labels<para>Condition</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Condition">http://data.cochrane.org/ontologies/core/Condition</seealso>
    let Condition = Prefixed_Name(cochrane, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A material used as intervention</para>
    /// labels<para>Material</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Material">http://data.cochrane.org/ontologies/core/Material</seealso>
    let Material = Prefixed_Name(cochrane, "Material") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:DeviceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A category or class of Device</para>
    /// labels<para>DeviceCategory</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/DeviceCategory">http://data.cochrane.org/ontologies/core/DeviceCategory</seealso>
    let DeviceCategory = Prefixed_Name(cochrane, "DeviceCategory") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:DrugCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A category or class of drug</para>
    /// labels<para>DrugCategory</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/DrugCategory">http://data.cochrane.org/ontologies/core/DrugCategory</seealso>
    let DrugCategory = Prefixed_Name(cochrane, "DrugCategory") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:InterventionProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Some agent that provides or delivers an intervention.</para>
    /// labels<para>InterventionProvider</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/InterventionProvider">http://data.cochrane.org/ontologies/core/InterventionProvider</seealso>
    let InterventionProvider =
        Prefixed_Name(cochrane, "InterventionProvider") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:ModeOfDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The mechanism by which an intervention is delivered.</para>
    /// labels<para>ModeOfDelivery</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/ModeOfDelivery">http://data.cochrane.org/ontologies/core/ModeOfDelivery</seealso>
    let ModeOfDelivery = Prefixed_Name(cochrane, "ModeOfDelivery") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:OutcomeClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The classification of an outcome.</para>
    /// labels<para>OutcomeClassification</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/OutcomeClassification">http://data.cochrane.org/ontologies/core/OutcomeClassification</seealso>
    let OutcomeClassification =
        Prefixed_Name(cochrane, "OutcomeClassification") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Procedure used as intervention</para>
    /// labels<para>Procedure</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Procedure">http://data.cochrane.org/ontologies/core/Procedure</seealso>
    let Procedure = Prefixed_Name(cochrane, "Procedure") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Sex of some defined population.</para>
    /// labels<para>Sex</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Sex">http://data.cochrane.org/ontologies/core/Sex</seealso>
    let Sex = Prefixed_Name(cochrane, "Sex") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:SpecificMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specific metric used in defining an outcome.</para>
    /// labels<para>SpecificMetric</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/SpecificMetric">http://data.cochrane.org/ontologies/core/SpecificMetric</seealso>
    let SpecificMetric = Prefixed_Name(cochrane, "SpecificMetric") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:broaderConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Concept to a broader one in the same concept scheme.</para>
    /// labels<para>broaderConcept</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/broaderConcept">http://data.cochrane.org/ontologies/core/broaderConcept</seealso>
    let broaderConcept = Prefixed_Name(cochrane, "broaderConcept") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:inCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an intervention to an intervention category.</para>
    /// labels<para>inCategory</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/inCategory">http://data.cochrane.org/ontologies/core/inCategory</seealso>
    let inCategory = Prefixed_Name(cochrane, "inCategory") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:inConceptScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Concept to its ConceptScheme</para>
    /// labels<para>inConceptScheme</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/inConceptScheme">http://data.cochrane.org/ontologies/core/inConceptScheme</seealso>
    let inConceptScheme = Prefixed_Name(cochrane, "inConceptScheme") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:longLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The long label of something.</para>
    /// </remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/longLabel">http://data.cochrane.org/ontologies/core/longLabel</seealso>
    let longLabel = Prefixed_Name(cochrane, "longLabel") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:modifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The agent that modified the concept (workflow/provenance).</para>
    /// labels<para>modifiedBy</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/modifiedBy">http://data.cochrane.org/ontologies/core/modifiedBy</seealso>
    let modifiedBy = Prefixed_Name(cochrane, "modifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:shortLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The short label of something.</para>
    /// </remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/shortLabel">http://data.cochrane.org/ontologies/core/shortLabel</seealso>
    let shortLabel = Prefixed_Name(cochrane, "shortLabel") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The Cochrane Core ontology describes the entities and concepts that exist in the domain of evidence based healthcare.</para>
    /// </remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/">http://data.cochrane.org/ontologies/core/</seealso>
    let _prefix_iri = Prefixed_Name(cochrane, "") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A vocabulary concept</para>
    /// labels<para>Concept</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Concept">http://data.cochrane.org/ontologies/core/Concept</seealso>
    let Concept = Prefixed_Name(cochrane, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:AggregationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Aggregation method used in defining an outcome.</para>
    /// labels<para>AggregationMethod</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/AggregationMethod">http://data.cochrane.org/ontologies/core/AggregationMethod</seealso>
    let AggregationMethod = Prefixed_Name(cochrane, "AggregationMethod") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:AssessmentScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An AssessmentScale that an outcome is measured against.</para>
    /// labels<para>AssessmentScale</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/AssessmentScale">http://data.cochrane.org/ontologies/core/AssessmentScale</seealso>
    let AssessmentScale = Prefixed_Name(cochrane, "AssessmentScale") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:ConceptScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A scheme that a concept exists within</para>
    /// labels<para>ConceptScheme</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/ConceptScheme">http://data.cochrane.org/ontologies/core/ConceptScheme</seealso>
    let ConceptScheme = Prefixed_Name(cochrane, "ConceptScheme") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Device used as intervention</para>
    /// labels<para>Device</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Device">http://data.cochrane.org/ontologies/core/Device</seealso>
    let Device = Prefixed_Name(cochrane, "Device") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:InterventionCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A category or class of applied intervention</para>
    /// labels<para>InterventionCategory</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/InterventionCategory">http://data.cochrane.org/ontologies/core/InterventionCategory</seealso>
    let InterventionCategory =
        Prefixed_Name(cochrane, "InterventionCategory") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:Drug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Drug used as intervention</para>
    /// labels<para>Drug</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Drug">http://data.cochrane.org/ontologies/core/Drug</seealso>
    let Drug = Prefixed_Name(cochrane, "Drug") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:InterventionClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The classification of an intervention.</para>
    /// labels<para>InterventionClassification</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/InterventionClassification">http://data.cochrane.org/ontologies/core/InterventionClassification</seealso>
    let InterventionClassification =
        Prefixed_Name(cochrane, "InterventionClassification") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:InterventionRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The rationale for providing an intervention.</para>
    /// labels<para>InterventionRationale</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/InterventionRationale">http://data.cochrane.org/ontologies/core/InterventionRationale</seealso>
    let InterventionRationale =
        Prefixed_Name(cochrane, "InterventionRationale") |> PrefixedName

    /// <summary>
    ///   <para>cochrane:ProcedureCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A category or class of procedure</para>
    /// labels<para>ProcedureCategory</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/ProcedureCategory">http://data.cochrane.org/ontologies/core/ProcedureCategory</seealso>
    let ProcedureCategory = Prefixed_Name(cochrane, "ProcedureCategory") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:Setting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The setting in which an intervention is delivered (eg clininc, hospital, at home).</para>
    /// labels<para>Setting</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Setting">http://data.cochrane.org/ontologies/core/Setting</seealso>
    let Setting = Prefixed_Name(cochrane, "Setting") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:Treatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Treatment some population is undergoing.</para>
    /// labels<para>Treatment</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/Treatment">http://data.cochrane.org/ontologies/core/Treatment</seealso>
    let Treatment = Prefixed_Name(cochrane, "Treatment") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:alternateLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The alternate label or synonym of something.</para>
    /// </remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/alternateLabel">http://data.cochrane.org/ontologies/core/alternateLabel</seealso>
    let alternateLabel = Prefixed_Name(cochrane, "alternateLabel") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:equivalentConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Concept to an equivalent one.</para>
    /// labels<para>equivalentConcept</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/equivalentConcept">http://data.cochrane.org/ontologies/core/equivalentConcept</seealso>
    let equivalentConcept = Prefixed_Name(cochrane, "equivalentConcept") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The label of something.</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/label">http://data.cochrane.org/ontologies/core/label</seealso>
    let label = Prefixed_Name(cochrane, "label") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:lastModifiedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date/time a concept was last modified (workflow/provenance).</para>
    /// labels<para>lastModifiedDate</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/lastModifiedDate">http://data.cochrane.org/ontologies/core/lastModifiedDate</seealso>
    let lastModifiedDate = Prefixed_Name(cochrane, "lastModifiedDate") |> PrefixedName
    /// <summary>
    ///   <para>cochrane:narrowerConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Concept to a narrower one in the same concept scheme.</para>
    /// labels<para>narrowerConcept</para></remarks>
    /// <seealso href="http://data.cochrane.org/ontologies/core/narrowerConcept">http://data.cochrane.org/ontologies/core/narrowerConcept</seealso>
    let narrowerConcept = Prefixed_Name(cochrane, "narrowerConcept") |> PrefixedName
