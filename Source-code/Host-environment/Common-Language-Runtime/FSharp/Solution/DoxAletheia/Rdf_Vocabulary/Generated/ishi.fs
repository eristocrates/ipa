namespace https.w3id.org.ishikawa_diagram_ontology.hash

open DoxAletheia

module ishi =
    let _namespace_name = "https://w3id.org/ishikawa-diagram-ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Categories are "surroundings", "suppliers", "skills", and  "systems"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#4S"></see></summary>
    let _4S = _prefix "4S"
    /// <summary>
    /// The class is used to record the design pattern which was applied in the course of the Ishikawa diagram creation. Instances of the class refer to best practices.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#DesignPattern"></see></summary>
    let DesignPattern = _prefix "DesignPattern"
    /// <summary>
    /// The categories are "measurement", "materials", "methods", "manpower", and "environment"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#5MandE"></see></summary>
    let _5MandE = _prefix "5MandE"
    /// <summary>
    /// The categories are "price", "people", "place", "procedure", "promotion", "processes", "products", and "policies"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#8P"></see></summary>
    let _8P = _prefix "8P"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Accountable"></see>
    /// </summary>
    let Accountable = _prefix "Accountable"
    /// <summary>
    /// A role is the function of an agent with respect to a factor. The ontology incorporates role instances adhering to the RASCI model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A cause is a factor where its characteristics has direct influence on the characteristics of another factor.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Cause"></see></summary>
    let Cause = _prefix "Cause"
    /// <summary>
    /// A factor is any activity or entity with identified cause-effect relationships in the context of root-cause analysis
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Factor"></see></summary>
    let Factor = _prefix "Factor"
    /// <summary>
    /// CauseEffect is the capacity of a factor to have an effect on the character of another. The class is used to record qualified cause-effect relationships.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#CauseEffect"></see></summary>
    let CauseEffect = _prefix "CauseEffect"
    /// <summary>
    /// The class is used to record the type of cause-effect relationship that exists between at least one cause and at least one effect.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#CauseEffectType"></see></summary>
    let CauseEffectType = _prefix "CauseEffectType"
    /// <summary>
    /// A WeightScale where the numerical weight refers to the certainty.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#CertaintyScale"></see></summary>
    let CertaintyScale = _prefix "CertaintyScale"
    /// <summary>
    /// A class that specifies the min and max range of values for the weight of a cause-effect relationship.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#WeightScale"></see></summary>
    let WeightScale = _prefix "WeightScale"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Consulted"></see>
    /// </summary>
    let Consulted = _prefix "Consulted"
    /// <summary>
    /// A visual representation of an Ishikawa diagram model or of a portion of it.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Diagram"></see></summary>
    let Diagram = _prefix "Diagram"
    /// <summary>
    /// The class is used to record the type of the Ishikawa diagram
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#DiagramType"></see></summary>
    let DiagramType = _prefix "DiagramType"
    /// <summary>
    /// The categories are "uncontrollable factors", "controllable factors", "blockable nuisance factors", and "held-constant factors"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#DoE"></see></summary>
    let DoE = _prefix "DoE"
    /// <summary>
    /// An effect is a factor where its characteristics are directly influenced by the characteristics of another factor.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Effect"></see></summary>
    let Effect = _prefix "Effect"
    /// <summary>
    /// Evidence refers to all resources that (partially) validate a cause-effeect relationship.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Evidence"></see></summary>
    let Evidence = _prefix "Evidence"
    /// <summary>
    /// The class is used to specify Evidence resources.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#EvidenceType"></see></summary>
    let EvidenceType = _prefix "EvidenceType"
    /// <summary>
    /// A WeightScale where the numerical weight refers to an imact value. Impact describes the estimated and quantified effect an occurence of a cause-effect relationship might have.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#ImpactScale"></see></summary>
    let ImpactScale = _prefix "ImpactScale"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Informed"></see>
    /// </summary>
    let Informed = _prefix "Informed"
    /// <summary>
    /// A major cause has a direct cause-effect relationship with the root cause in the context of an Ishikawa diagram. When design patterns are used, major causes are abstract causes which are commonly referred to as categories.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#MajorCause"></see></summary>
    let MajorCause = _prefix "MajorCause"
    /// <summary>
    /// The Model class is used to record factors and their cause-effect relationships. It can be seen as the data model of an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// A WeightScale where the numerical weight refers to a probability value. Probability describes the likelihood of occurence of a cause-effect relationship.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#ProbabilityScale"></see></summary>
    let ProbabilityScale = _prefix "ProbabilityScale"
    /// <summary>
    /// A problem is a factor which does not influence any known factor in the context of an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Problem"></see></summary>
    let Problem = _prefix "Problem"
    /// <summary>
    /// A WeightScale where the numerical weight refers to a relevance value. Relevance describes the importance a cause-effect relationship has in the context of a root-cause analysis.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#RelevanceScale"></see></summary>
    let RelevanceScale = _prefix "RelevanceScale"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Responsible"></see>
    /// </summary>
    let Responsible = _prefix "Responsible"
    /// <summary>
    /// A WeightScale where the numerical weight refers to a risk value. Risk describes the estimated potential damage the occurence of a cause-effect relationship might have. Risk is often calculated as the product of probability and impact.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#RiskScale"></see></summary>
    let RiskScale = _prefix "RiskScale"
    /// <summary>
    /// A root cause is a factor which is not influenced by any known factor in the context of an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#RootCause"></see></summary>
    let RootCause = _prefix "RootCause"
    /// <summary>
    /// The categories are "site", "task", "equipment", "people", and "control"
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#STEPC"></see></summary>
    let STEPC = _prefix "STEPC"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#Supporting"></see>
    /// </summary>
    let Supporting = _prefix "Supporting"
    /// <summary>
    /// An established activity with the goal of peperapring or creating an Ishikawa diagram
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Technique"></see></summary>
    let Technique = _prefix "Technique"
    /// <summary>
    /// The weight class is used to assign values to a cause-effect relationship for priorization. The intended meaning of the weight depends on the referenced WeightScale
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Weight"></see></summary>
    let Weight = _prefix "Weight"
    /// <summary>
    /// The WeightRange class is used to specify and name subranges.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#WeightRange"></see></summary>
    let WeightRange = _prefix "WeightRange"
    /// <summary>
    /// A structured or guided activity to create an Ishikawa diagram
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#Workshop"></see></summary>
    let Workshop = _prefix "Workshop"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#aggravating"></see>
    /// </summary>
    let aggravating = _prefix "aggravating"
    /// <summary>
    /// This property is used to link a Cause to CauseEffect .
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#cause"></see></summary>
    let cause = _prefix "cause"
    /// <summary>
    /// Property links CauseEffects to their Model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#causeEffect"></see></summary>
    let causeEffect = _prefix "causeEffect"
    /// <summary>
    /// inverse property to causeEffect
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#isCauseEffectOf"></see></summary>
    let isCauseEffectOf = _prefix "isCauseEffectOf"
    /// <summary>
    /// This property is used to link the CauseEffectType to a CauseEffect
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#causeEffectType"></see></summary>
    let causeEffectType = _prefix "causeEffectType"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#causeEnumerationDiagram"></see>
    /// </summary>
    let causeEnumerationDiagram = _prefix "causeEnumerationDiagram"
    /// <summary>
    /// This property is used to directly link a Cause to an Effect without further qualification. For qualified cause-effect relationships the CauseEffect class is used.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#caused"></see></summary>
    let caused = _prefix "caused"
    /// <summary>
    /// This property is used to directly link an Effect to a Cause without further qualification. For qualified cause-effect relationships the CauseEffect class is used.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#wasCausedBy"></see></summary>
    let wasCausedBy = _prefix "wasCausedBy"
    /// <summary>
    /// This property is used to indicate the maximal depth of the visual representation of an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#depth"></see></summary>
    let depth = _prefix "depth"
    /// <summary>
    /// Property specifies which DesignPattern was used in an Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#designPattern"></see></summary>
    let designPattern = _prefix "designPattern"
    /// <summary>
    /// This property is used to link the (data) model of an Ishikawa diagram to its visual representation.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#diagram"></see></summary>
    let diagram = _prefix "diagram"
    /// <summary>
    /// This property is used to link the visual representation of an Ishikawa diagram to its data model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#model"></see></summary>
    let model = _prefix "model"
    /// <summary>
    /// This property is used to linke the DiagramType to Diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#diagramType"></see></summary>
    let diagramType = _prefix "diagramType"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#dispersionAnalysisDiagram"></see>
    /// </summary>
    let dispersionAnalysisDiagram = _prefix "dispersionAnalysisDiagram"
    /// <summary>
    /// This property is used to link an Effect to CauseEffect .
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#effect"></see></summary>
    let effect = _prefix "effect"
    /// <summary>
    /// This property is used to indicate, if factors were enumerated in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#enumerated"></see></summary>
    let enumerated = _prefix "enumerated"
    /// <summary>
    /// This property is used to link the EvidenceType to an Evidence
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#evidenceType"></see></summary>
    let evidenceType = _prefix "evidenceType"
    /// <summary>
    /// Property links Factors to their Model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#factor"></see></summary>
    let factor = _prefix "factor"
    /// <summary>
    /// inverse property to factor
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#isFactorOf"></see></summary>
    let isFactorOf = _prefix "isFactorOf"
    /// <summary>
    /// In the context of the Ishikawa ontology, this property is used to assign roles according to the RASCI model.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hadRole"></see></summary>
    let hadRole = _prefix "hadRole"
    /// <summary>
    /// This property is used to link a CauseEffect to any Evidence.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasEvidence"></see></summary>
    let hasEvidence = _prefix "hasEvidence"
    /// <summary>
    /// This property is used to link a WeightRange to a WeightScale.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasNamedRange"></see></summary>
    let hasNamedRange = _prefix "hasNamedRange"
    /// <summary>
    /// This property is used to link a CauseEffect to any Evidence with the assumption that the evidence is qualitative..
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasQualitativeEvidence"></see></summary>
    let hasQualitativeEvidence = _prefix "hasQualitativeEvidence"
    /// <summary>
    /// This property is used to link a CauseEffect to any Evidence with the assumption that the evidence is quantitative
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasQuantitativeEvidence"></see></summary>
    let hasQuantitativeEvidence = _prefix "hasQuantitativeEvidence"
    /// <summary>
    /// This property is used to link a WeightScale to the WeightRange which defines its total range.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#hasWeightRange"></see></summary>
    let hasWeightRange = _prefix "hasWeightRange"
    /// <summary>
    /// This property is used to indicate, if the evidence basis was emphasized in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#illustratedEvidence"></see></summary>
    let illustratedEvidence = _prefix "illustratedEvidence"
    /// <summary>
    /// This property is used to indicate, if the factors' influence on the problem were emphasized in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#illustratedFactorInfluence"></see></summary>
    let illustratedFactorInfluence = _prefix "illustratedFactorInfluence"
    /// <summary>
    /// This property is used to indicate, if responsibilities or roles towards factors were included in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#illustratedRoles"></see></summary>
    let illustratedRoles = _prefix "illustratedRoles"
    /// <summary>
    /// This property is used to indicate, if weight differences were emphasized in the visual representation of the Ishikawa diagram.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#illustratedWeight"></see></summary>
    let illustratedWeight = _prefix "illustratedWeight"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#neutralizing"></see>
    /// </summary>
    let neutralizing = _prefix "neutralizing"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#noEvidence"></see>
    /// </summary>
    let noEvidence = _prefix "noEvidence"

    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#productProcessClassificationDiagram"></see>
    /// </summary>
    let productProcessClassificationDiagram =
        _prefix "productProcessClassificationDiagram"

    /// <summary>
    /// This property is used to link a qualified CauseEffect to a Factor.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffect"></see></summary>
    let qualifiedCauseEffect = _prefix "qualifiedCauseEffect"
    /// <summary>
    /// This property is used to link a qualified CauseEffect to a Factor.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffectOf"></see></summary>
    let qualifiedCauseEffectOf = _prefix "qualifiedCauseEffectOf"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#qualitativeEvidence"></see>
    /// </summary>
    let qualitativeEvidence = _prefix "qualitativeEvidence"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#quantitativeEvidence"></see>
    /// </summary>
    let quantitativeEvidence = _prefix "quantitativeEvidence"
    /// <summary>
    /// The property is used to link the WeigthScale to a Weight.
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#scale"></see></summary>
    let scale = _prefix "scale"
    /// <summary>
    ///   <see href="https://w3id.org/ishikawa-diagram-ontology#undecided"></see>
    /// </summary>
    let undecided = _prefix "undecided"
    /// <summary>
    /// Property to indicate which Technique was used in the Workshop
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#usedTechnique"></see></summary>
    let usedTechnique = _prefix "usedTechnique"
    /// <summary>
    /// This property is used to link a Weight to a CauseEffect
    /// <see href="https://w3id.org/ishikawa-diagram-ontology#weight"></see></summary>
    let weight = _prefix "weight"
