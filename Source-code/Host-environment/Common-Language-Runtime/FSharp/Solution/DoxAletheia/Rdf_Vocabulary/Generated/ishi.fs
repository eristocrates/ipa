namespace https.w3id.org.ishikawa_diagram_ontology.hash

open DoxAletheia.Rdf_Vocabulary

module ishi =
    let _namespace_name = "https://w3id.org/ishikawa-diagram-ontology#"
    /// <summary>
    /// Categories are "surroundings", "suppliers", "skills", and  "systems"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#4S"></see></summary>
    let _4S = Namespaced_IRI.parse _namespace_name "4S" |> NamespacedName

    /// <summary>
    /// The class is used to record the design pattern which was applied in the course of the Ishikawa diagram creation. Instances of the class refer to best practices.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#DesignPattern"></see></summary>
    let DesignPattern =
        Namespaced_IRI.parse _namespace_name "DesignPattern" |> NamespacedName

    /// <summary>
    /// The categories are "measurement", "materials", "methods", "manpower", and "environment"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#5MandE"></see></summary>
    let _5MandE = Namespaced_IRI.parse _namespace_name "5MandE" |> NamespacedName
    /// <summary>
    /// The categories are "price", "people", "place", "procedure", "promotion", "processes", "products", and "policies"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#8P"></see></summary>
    let _8P = Namespaced_IRI.parse _namespace_name "8P" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Accountable"></see>
    /// </summary>
    let Accountable =
        Namespaced_IRI.parse _namespace_name "Accountable" |> NamespacedName

    /// <summary>
    /// A role is the function of an agent with respect to a factor. The ontology incorporates role instances adhering to the RASCI model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// A cause is a factor where its characteristics has direct influence on the characteristics of another factor.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Cause"></see></summary>
    let Cause = Namespaced_IRI.parse _namespace_name "Cause" |> NamespacedName
    /// <summary>
    /// A factor is any activity or entity with identified cause-effect relationships in the context of root-cause analysis
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Factor"></see></summary>
    let Factor = Namespaced_IRI.parse _namespace_name "Factor" |> NamespacedName

    /// <summary>
    /// CauseEffect is the capacity of a factor to have an effect on the character of another. The class is used to record qualified cause-effect relationships.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#CauseEffect"></see></summary>
    let CauseEffect =
        Namespaced_IRI.parse _namespace_name "CauseEffect" |> NamespacedName

    /// <summary>
    /// The class is used to record the type of cause-effect relationship that exists between at least one cause and at least one effect.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#CauseEffectType"></see></summary>
    let CauseEffectType =
        Namespaced_IRI.parse _namespace_name "CauseEffectType" |> NamespacedName

    /// <summary>
    /// A WeightScale where the numerical weight refers to the certainty.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#CertaintyScale"></see></summary>
    let CertaintyScale =
        Namespaced_IRI.parse _namespace_name "CertaintyScale" |> NamespacedName

    /// <summary>
    /// A class that specifies the min and max range of values for the weight of a cause-effect relationship.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#WeightScale"></see></summary>
    let WeightScale =
        Namespaced_IRI.parse _namespace_name "WeightScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Consulted"></see>
    /// </summary>
    let Consulted = Namespaced_IRI.parse _namespace_name "Consulted" |> NamespacedName
    /// <summary>
    /// A visual representation of an Ishikawa diagram model or of a portion of it.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Diagram"></see></summary>
    let Diagram = Namespaced_IRI.parse _namespace_name "Diagram" |> NamespacedName

    /// <summary>
    /// The class is used to record the type of the Ishikawa diagram
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#DiagramType"></see></summary>
    let DiagramType =
        Namespaced_IRI.parse _namespace_name "DiagramType" |> NamespacedName

    /// <summary>
    /// The categories are "uncontrollable factors", "controllable factors", "blockable nuisance factors", and "held-constant factors"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#DoE"></see></summary>
    let DoE = Namespaced_IRI.parse _namespace_name "DoE" |> NamespacedName
    /// <summary>
    /// An effect is a factor where its characteristics are directly influenced by the characteristics of another factor.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Effect"></see></summary>
    let Effect = Namespaced_IRI.parse _namespace_name "Effect" |> NamespacedName
    /// <summary>
    /// Evidence refers to all resources that (partially) validate a cause-effeect relationship.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Evidence"></see></summary>
    let Evidence = Namespaced_IRI.parse _namespace_name "Evidence" |> NamespacedName

    /// <summary>
    /// The class is used to specify Evidence resources.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#EvidenceType"></see></summary>
    let EvidenceType =
        Namespaced_IRI.parse _namespace_name "EvidenceType" |> NamespacedName

    /// <summary>
    /// A WeightScale where the numerical weight refers to an imact value. Impact describes the estimated and quantified effect an occurence of a cause-effect relationship might have.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#ImpactScale"></see></summary>
    let ImpactScale =
        Namespaced_IRI.parse _namespace_name "ImpactScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Informed"></see>
    /// </summary>
    let Informed = Namespaced_IRI.parse _namespace_name "Informed" |> NamespacedName
    /// <summary>
    /// A major cause has a direct cause-effect relationship with the root cause in the context of an Ishikawa diagram. When design patterns are used, major causes are abstract causes which are commonly referred to as categories.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#MajorCause"></see></summary>
    let MajorCause = Namespaced_IRI.parse _namespace_name "MajorCause" |> NamespacedName
    /// <summary>
    /// The Model class is used to record factors and their cause-effect relationships. It can be seen as the data model of an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName

    /// <summary>
    /// A WeightScale where the numerical weight refers to a probability value. Probability describes the likelihood of occurence of a cause-effect relationship.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#ProbabilityScale"></see></summary>
    let ProbabilityScale =
        Namespaced_IRI.parse _namespace_name "ProbabilityScale" |> NamespacedName

    /// <summary>
    /// A problem is a factor which does not influence any known factor in the context of an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Problem"></see></summary>
    let Problem = Namespaced_IRI.parse _namespace_name "Problem" |> NamespacedName

    /// <summary>
    /// A WeightScale where the numerical weight refers to a relevance value. Relevance describes the importance a cause-effect relationship has in the context of a root-cause analysis.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#RelevanceScale"></see></summary>
    let RelevanceScale =
        Namespaced_IRI.parse _namespace_name "RelevanceScale" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Responsible"></see>
    /// </summary>
    let Responsible =
        Namespaced_IRI.parse _namespace_name "Responsible" |> NamespacedName

    /// <summary>
    /// A WeightScale where the numerical weight refers to a risk value. Risk describes the estimated potential damage the occurence of a cause-effect relationship might have. Risk is often calculated as the product of probability and impact.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#RiskScale"></see></summary>
    let RiskScale = Namespaced_IRI.parse _namespace_name "RiskScale" |> NamespacedName
    /// <summary>
    /// A root cause is a factor which is not influenced by any known factor in the context of an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#RootCause"></see></summary>
    let RootCause = Namespaced_IRI.parse _namespace_name "RootCause" |> NamespacedName
    /// <summary>
    /// The categories are "site", "task", "equipment", "people", and "control"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#STEPC"></see></summary>
    let STEPC = Namespaced_IRI.parse _namespace_name "STEPC" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Supporting"></see>
    /// </summary>
    let Supporting = Namespaced_IRI.parse _namespace_name "Supporting" |> NamespacedName
    /// <summary>
    /// An established activity with the goal of peperapring or creating an Ishikawa diagram
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Technique"></see></summary>
    let Technique = Namespaced_IRI.parse _namespace_name "Technique" |> NamespacedName
    /// <summary>
    /// The weight class is used to assign values to a cause-effect relationship for priorization. The intended meaning of the weight depends on the referenced WeightScale
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Weight"></see></summary>
    let Weight = Namespaced_IRI.parse _namespace_name "Weight" |> NamespacedName

    /// <summary>
    /// The WeightRange class is used to specify and name subranges.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#WeightRange"></see></summary>
    let WeightRange =
        Namespaced_IRI.parse _namespace_name "WeightRange" |> NamespacedName

    /// <summary>
    /// A structured or guided activity to create an Ishikawa diagram
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Workshop"></see></summary>
    let Workshop = Namespaced_IRI.parse _namespace_name "Workshop" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#aggravating"></see>
    /// </summary>
    let aggravating =
        Namespaced_IRI.parse _namespace_name "aggravating" |> NamespacedName

    /// <summary>
    /// This property is used to link a Cause to CauseEffect .
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#cause"></see></summary>
    let cause = Namespaced_IRI.parse _namespace_name "cause" |> NamespacedName

    /// <summary>
    /// Property links CauseEffects to their Model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#causeEffect"></see></summary>
    let causeEffect =
        Namespaced_IRI.parse _namespace_name "causeEffect" |> NamespacedName

    /// <summary>
    /// inverse property to causeEffect
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#isCauseEffectOf"></see></summary>
    let isCauseEffectOf =
        Namespaced_IRI.parse _namespace_name "isCauseEffectOf" |> NamespacedName

    /// <summary>
    /// This property is used to link the CauseEffectType to a CauseEffect
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#causeEffectType"></see></summary>
    let causeEffectType =
        Namespaced_IRI.parse _namespace_name "causeEffectType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#causeEnumerationDiagram"></see>
    /// </summary>
    let causeEnumerationDiagram =
        Namespaced_IRI.parse _namespace_name "causeEnumerationDiagram" |> NamespacedName

    /// <summary>
    /// This property is used to directly link a Cause to an Effect without further qualification. For qualified cause-effect relationships the CauseEffect class is used.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#caused"></see></summary>
    let caused = Namespaced_IRI.parse _namespace_name "caused" |> NamespacedName

    /// <summary>
    /// This property is used to directly link an Effect to a Cause without further qualification. For qualified cause-effect relationships the CauseEffect class is used.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#wasCausedBy"></see></summary>
    let wasCausedBy =
        Namespaced_IRI.parse _namespace_name "wasCausedBy" |> NamespacedName

    /// <summary>
    /// This property is used to indicate the maximal depth of the visual representation of an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#depth"></see></summary>
    let depth = Namespaced_IRI.parse _namespace_name "depth" |> NamespacedName

    /// <summary>
    /// Property specifies which DesignPattern was used in an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#designPattern"></see></summary>
    let designPattern =
        Namespaced_IRI.parse _namespace_name "designPattern" |> NamespacedName

    /// <summary>
    /// This property is used to link the (data) model of an Ishikawa diagram to its visual representation.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#diagram"></see></summary>
    let diagram = Namespaced_IRI.parse _namespace_name "diagram" |> NamespacedName
    /// <summary>
    /// This property is used to link the visual representation of an Ishikawa diagram to its data model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#model"></see></summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName

    /// <summary>
    /// This property is used to linke the DiagramType to Diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#diagramType"></see></summary>
    let diagramType =
        Namespaced_IRI.parse _namespace_name "diagramType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#dispersionAnalysisDiagram"></see>
    /// </summary>
    let dispersionAnalysisDiagram =
        Namespaced_IRI.parse _namespace_name "dispersionAnalysisDiagram" |> NamespacedName

    /// <summary>
    /// This property is used to link an Effect to CauseEffect .
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#effect"></see></summary>
    let effect = Namespaced_IRI.parse _namespace_name "effect" |> NamespacedName
    /// <summary>
    /// This property is used to indicate, if factors were enumerated in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#enumerated"></see></summary>
    let enumerated = Namespaced_IRI.parse _namespace_name "enumerated" |> NamespacedName

    /// <summary>
    /// This property is used to link the EvidenceType to an Evidence
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#evidenceType"></see></summary>
    let evidenceType =
        Namespaced_IRI.parse _namespace_name "evidenceType" |> NamespacedName

    /// <summary>
    /// Property links Factors to their Model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#factor"></see></summary>
    let factor = Namespaced_IRI.parse _namespace_name "factor" |> NamespacedName
    /// <summary>
    /// inverse property to factor
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#isFactorOf"></see></summary>
    let isFactorOf = Namespaced_IRI.parse _namespace_name "isFactorOf" |> NamespacedName
    /// <summary>
    /// In the context of the Ishikawa ontology, this property is used to assign roles according to the RASCI model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hadRole"></see></summary>
    let hadRole = Namespaced_IRI.parse _namespace_name "hadRole" |> NamespacedName

    /// <summary>
    /// This property is used to link a CauseEffect to any Evidence.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasEvidence"></see></summary>
    let hasEvidence =
        Namespaced_IRI.parse _namespace_name "hasEvidence" |> NamespacedName

    /// <summary>
    /// This property is used to link a WeightRange to a WeightScale.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasNamedRange"></see></summary>
    let hasNamedRange =
        Namespaced_IRI.parse _namespace_name "hasNamedRange" |> NamespacedName

    /// <summary>
    /// This property is used to link a CauseEffect to any Evidence with the assumption that the evidence is qualitative..
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasQualitativeEvidence"></see></summary>
    let hasQualitativeEvidence =
        Namespaced_IRI.parse _namespace_name "hasQualitativeEvidence" |> NamespacedName

    /// <summary>
    /// This property is used to link a CauseEffect to any Evidence with the assumption that the evidence is quantitative
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasQuantitativeEvidence"></see></summary>
    let hasQuantitativeEvidence =
        Namespaced_IRI.parse _namespace_name "hasQuantitativeEvidence" |> NamespacedName

    /// <summary>
    /// This property is used to link a WeightScale to the WeightRange which defines its total range.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasWeightRange"></see></summary>
    let hasWeightRange =
        Namespaced_IRI.parse _namespace_name "hasWeightRange" |> NamespacedName

    /// <summary>
    /// This property is used to indicate, if the evidence basis was emphasized in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#illustratedEvidence"></see></summary>
    let illustratedEvidence =
        Namespaced_IRI.parse _namespace_name "illustratedEvidence" |> NamespacedName

    /// <summary>
    /// This property is used to indicate, if the factors' influence on the problem were emphasized in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#illustratedFactorInfluence"></see></summary>
    let illustratedFactorInfluence =
        Namespaced_IRI.parse _namespace_name "illustratedFactorInfluence" |> NamespacedName

    /// <summary>
    /// This property is used to indicate, if responsibilities or roles towards factors were included in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#illustratedRoles"></see></summary>
    let illustratedRoles =
        Namespaced_IRI.parse _namespace_name "illustratedRoles" |> NamespacedName

    /// <summary>
    /// This property is used to indicate, if weight differences were emphasized in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#illustratedWeight"></see></summary>
    let illustratedWeight =
        Namespaced_IRI.parse _namespace_name "illustratedWeight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#neutralizing"></see>
    /// </summary>
    let neutralizing =
        Namespaced_IRI.parse _namespace_name "neutralizing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#noEvidence"></see>
    /// </summary>
    let noEvidence = Namespaced_IRI.parse _namespace_name "noEvidence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#productProcessClassificationDiagram"></see>
    /// </summary>
    let productProcessClassificationDiagram =
        Namespaced_IRI.parse _namespace_name "productProcessClassificationDiagram" |> NamespacedName

    /// <summary>
    /// This property is used to link a qualified CauseEffect to a Factor.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffect"></see></summary>
    let qualifiedCauseEffect =
        Namespaced_IRI.parse _namespace_name "qualifiedCauseEffect" |> NamespacedName

    /// <summary>
    /// This property is used to link a qualified CauseEffect to a Factor.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffectOf"></see></summary>
    let qualifiedCauseEffectOf =
        Namespaced_IRI.parse _namespace_name "qualifiedCauseEffectOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#qualitativeEvidence"></see>
    /// </summary>
    let qualitativeEvidence =
        Namespaced_IRI.parse _namespace_name "qualitativeEvidence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#quantitativeEvidence"></see>
    /// </summary>
    let quantitativeEvidence =
        Namespaced_IRI.parse _namespace_name "quantitativeEvidence" |> NamespacedName

    /// <summary>
    /// The property is used to link the WeigthScale to a Weight.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#scale"></see></summary>
    let scale = Namespaced_IRI.parse _namespace_name "scale" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#undecided"></see>
    /// </summary>
    let undecided = Namespaced_IRI.parse _namespace_name "undecided" |> NamespacedName

    /// <summary>
    /// Property to indicate which Technique was used in the Workshop
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#usedTechnique"></see></summary>
    let usedTechnique =
        Namespaced_IRI.parse _namespace_name "usedTechnique" |> NamespacedName

    /// <summary>
    /// This property is used to link a Weight to a CauseEffect
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#weight"></see></summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName
