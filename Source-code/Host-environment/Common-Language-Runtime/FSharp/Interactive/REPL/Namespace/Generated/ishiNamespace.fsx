#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ishi =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/ishikawa-diagram-ontology#" "ishi"

    let _4S = _prefixId.prefix "4S"
    let _5MandE = _prefixId.prefix "5MandE"
    let _8P = _prefixId.prefix "8P"
    let Accountable = _prefixId.prefix "Accountable"
    /// <summary>
    ///   <para>rdfs:label : Cause^^xsd:string</para>
    ///   <para>rdfs:comment : A cause is a factor where its characteristics has direct influence on the characteristics of another factor.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Cause">ishi:Cause</a>
    /// </summary>
    let Cause = _prefixId.prefix "Cause"
    /// <summary>
    ///   <para>rdfs:label : CauseEffect^^xsd:string</para>
    ///   <para>rdfs:comment : CauseEffect is the capacity of a factor to have an effect on the character of another. The class is used to record qualified cause-effect relationships.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#CauseEffect">ishi:CauseEffect</a>
    /// </summary>
    let CauseEffect = _prefixId.prefix "CauseEffect"
    /// <summary>
    ///   <para>rdfs:label : CauseEffectType^^xsd:string</para>
    ///   <para>rdfs:comment : The class is used to record the type of cause-effect relationship that exists between at least one cause and at least one effect.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#CauseEffectType">ishi:CauseEffectType</a>
    /// </summary>
    let CauseEffectType = _prefixId.prefix "CauseEffectType"
    /// <summary>
    ///   <para>rdfs:label : CertaintyScale^^xsd:string</para>
    ///   <para>rdfs:comment : A WeightScale where the numerical weight refers to the certainty.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#CertaintyScale">ishi:CertaintyScale</a>
    /// </summary>
    let CertaintyScale = _prefixId.prefix "CertaintyScale"
    let Consulted = _prefixId.prefix "Consulted"
    /// <summary>
    ///   <para>rdfs:label : DesignPattern^^xsd:string</para>
    ///   <para>rdfs:comment : The class is used to record the design pattern which was applied in the course of the Ishikawa diagram creation. Instances of the class refer to best practices.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#DesignPattern">ishi:DesignPattern</a>
    /// </summary>
    let DesignPattern = _prefixId.prefix "DesignPattern"
    /// <summary>
    ///   <para>rdfs:label : Diagram^^xsd:string</para>
    ///   <para>rdfs:comment : A visual representation of an Ishikawa diagram model or of a portion of it.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Diagram">ishi:Diagram</a>
    /// </summary>
    let Diagram = _prefixId.prefix "Diagram"
    /// <summary>
    ///   <para>rdfs:label : DiagramType^^xsd:string</para>
    ///   <para>rdfs:comment : The class is used to record the type of the Ishikawa diagram^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#DiagramType">ishi:DiagramType</a>
    /// </summary>
    let DiagramType = _prefixId.prefix "DiagramType"
    let DoE = _prefixId.prefix "DoE"
    /// <summary>
    ///   <para>rdfs:label : Effect^^xsd:string</para>
    ///   <para>rdfs:comment : An effect is a factor where its characteristics are directly influenced by the characteristics of another factor.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Effect">ishi:Effect</a>
    /// </summary>
    let Effect = _prefixId.prefix "Effect"
    /// <summary>
    ///   <para>rdfs:label : Evidence^^xsd:string</para>
    ///   <para>rdfs:comment : Evidence refers to all resources that (partially) validate a cause-effeect relationship.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Evidence">ishi:Evidence</a>
    /// </summary>
    let Evidence = _prefixId.prefix "Evidence"
    /// <summary>
    ///   <para>rdfs:label : EvidenceType^^xsd:string</para>
    ///   <para>rdfs:comment : The class is used to specify Evidence resources.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#EvidenceType">ishi:EvidenceType</a>
    /// </summary>
    let EvidenceType = _prefixId.prefix "EvidenceType"
    /// <summary>
    ///   <para>rdfs:label : Factor^^xsd:string</para>
    ///   <para>rdfs:comment : A factor is any activity or entity with identified cause-effect relationships in the context of root-cause analysis^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Factor">ishi:Factor</a>
    /// </summary>
    let Factor = _prefixId.prefix "Factor"
    /// <summary>
    ///   <para>rdfs:label : ImpactScale^^xsd:string</para>
    ///   <para>rdfs:comment : A WeightScale where the numerical weight refers to an imact value. Impact describes the estimated and quantified effect an occurence of a cause-effect relationship might have.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#ImpactScale">ishi:ImpactScale</a>
    /// </summary>
    let ImpactScale = _prefixId.prefix "ImpactScale"
    let Informed = _prefixId.prefix "Informed"
    /// <summary>
    ///   <para>rdfs:label : MajorCause^^xsd:string</para>
    ///   <para>rdfs:comment : A major cause has a direct cause-effect relationship with the root cause in the context of an Ishikawa diagram. When design patterns are used, major causes are abstract causes which are commonly referred to as categories.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#MajorCause">ishi:MajorCause</a>
    /// </summary>
    let MajorCause = _prefixId.prefix "MajorCause"
    /// <summary>
    ///   <para>rdfs:label : Model^^xsd:string</para>
    ///   <para>rdfs:comment : The Model class is used to record factors and their cause-effect relationships. It can be seen as the data model of an Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Model">ishi:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:label : ProbabilityScale^^xsd:string</para>
    ///   <para>rdfs:comment : A WeightScale where the numerical weight refers to a probability value. Probability describes the likelihood of occurence of a cause-effect relationship.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#ProbabilityScale">ishi:ProbabilityScale</a>
    /// </summary>
    let ProbabilityScale = _prefixId.prefix "ProbabilityScale"
    /// <summary>
    ///   <para>rdfs:label : Problem^^xsd:string</para>
    ///   <para>rdfs:comment : A problem is a factor which does not influence any known factor in the context of an Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Problem">ishi:Problem</a>
    /// </summary>
    let Problem = _prefixId.prefix "Problem"
    /// <summary>
    ///   <para>rdfs:label : RelevanceScale^^xsd:string</para>
    ///   <para>rdfs:comment : A WeightScale where the numerical weight refers to a relevance value. Relevance describes the importance a cause-effect relationship has in the context of a root-cause analysis.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#RelevanceScale">ishi:RelevanceScale</a>
    /// </summary>
    let RelevanceScale = _prefixId.prefix "RelevanceScale"
    let Responsible = _prefixId.prefix "Responsible"
    /// <summary>
    ///   <para>rdfs:label : RiskScale^^xsd:string</para>
    ///   <para>rdfs:comment : A WeightScale where the numerical weight refers to a risk value. Risk describes the estimated potential damage the occurence of a cause-effect relationship might have. Risk is often calculated as the product of probability and impact.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#RiskScale">ishi:RiskScale</a>
    /// </summary>
    let RiskScale = _prefixId.prefix "RiskScale"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>rdfs:comment : A role is the function of an agent with respect to a factor. The ontology incorporates role instances adhering to the RASCI model.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Role">ishi:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : RootCause^^xsd:string</para>
    ///   <para>rdfs:comment : A root cause is a factor which is not influenced by any known factor in the context of an Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#RootCause">ishi:RootCause</a>
    /// </summary>
    let RootCause = _prefixId.prefix "RootCause"
    let STEPC = _prefixId.prefix "STEPC"
    let Supporting = _prefixId.prefix "Supporting"
    /// <summary>
    ///   <para>rdfs:label : Technique^^xsd:string</para>
    ///   <para>rdfs:comment : An established activity with the goal of peperapring or creating an Ishikawa diagram^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Technique">ishi:Technique</a>
    /// </summary>
    let Technique = _prefixId.prefix "Technique"
    /// <summary>
    ///   <para>rdfs:label : Weight^^xsd:string</para>
    ///   <para>rdfs:comment : The weight class is used to assign values to a cause-effect relationship for priorization. The intended meaning of the weight depends on the referenced WeightScale^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Weight">ishi:Weight</a>
    /// </summary>
    let Weight = _prefixId.prefix "Weight"
    /// <summary>
    ///   <para>rdfs:label : WeightRange^^xsd:string</para>
    ///   <para>rdfs:comment : The WeightRange class is used to specify and name subranges.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#WeightRange">ishi:WeightRange</a>
    /// </summary>
    let WeightRange = _prefixId.prefix "WeightRange"
    /// <summary>
    ///   <para>rdfs:label : WeightScale^^xsd:string</para>
    ///   <para>rdfs:comment : A class that specifies the min and max range of values for the weight of a cause-effect relationship.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#WeightScale">ishi:WeightScale</a>
    /// </summary>
    let WeightScale = _prefixId.prefix "WeightScale"
    /// <summary>
    ///   <para>rdfs:label : Workshop^^xsd:string</para>
    ///   <para>rdfs:comment : A structured or guided activity to create an Ishikawa diagram^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#Workshop">ishi:Workshop</a>
    /// </summary>
    let Workshop = _prefixId.prefix "Workshop"
    let aggravating = _prefixId.prefix "aggravating"
    /// <summary>
    ///   <para>rdfs:label : cause^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a Cause to CauseEffect .^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#cause">ishi:cause</a>
    /// </summary>
    let cause = _prefixId.prefix "cause"
    /// <summary>
    ///   <para>rdfs:label : causeEffect^^xsd:string</para>
    ///   <para>rdfs:comment : Property links CauseEffects to their Model.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#causeEffect">ishi:causeEffect</a>
    /// </summary>
    let causeEffect = _prefixId.prefix "causeEffect"
    /// <summary>
    ///   <para>rdfs:label : causeEffectType^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link the CauseEffectType to a CauseEffect^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#causeEffectType">ishi:causeEffectType</a>
    /// </summary>
    let causeEffectType = _prefixId.prefix "causeEffectType"
    let causeEnumerationDiagram = _prefixId.prefix "causeEnumerationDiagram"
    /// <summary>
    ///   <para>rdfs:label : caused^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to directly link a Cause to an Effect without further qualification. For qualified cause-effect relationships the CauseEffect class is used.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#caused">ishi:caused</a>
    /// </summary>
    let caused = _prefixId.prefix "caused"
    /// <summary>
    ///   <para>rdfs:label : depth^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to indicate the maximal depth of the visual representation of an Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#depth">ishi:depth</a>
    /// </summary>
    let depth = _prefixId.prefix "depth"
    /// <summary>
    ///   <para>rdfs:label : designPattern^^xsd:string</para>
    ///   <para>rdfs:comment : Property specifies which DesignPattern was used in an Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#designPattern">ishi:designPattern</a>
    /// </summary>
    let designPattern = _prefixId.prefix "designPattern"
    /// <summary>
    ///   <para>rdfs:label : diagram^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link the (data) model of an Ishikawa diagram to its visual representation.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#diagram">ishi:diagram</a>
    /// </summary>
    let diagram = _prefixId.prefix "diagram"
    /// <summary>
    ///   <para>rdfs:label : diagramType^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to linke the DiagramType to Diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#diagramType">ishi:diagramType</a>
    /// </summary>
    let diagramType = _prefixId.prefix "diagramType"
    let dispersionAnalysisDiagram = _prefixId.prefix "dispersionAnalysisDiagram"
    /// <summary>
    ///   <para>rdfs:label : effect^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link an Effect to CauseEffect .^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#effect">ishi:effect</a>
    /// </summary>
    let effect = _prefixId.prefix "effect"
    /// <summary>
    ///   <para>rdfs:label : enumerated^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to indicate, if factors were enumerated in the visual representation of the Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#enumerated">ishi:enumerated</a>
    /// </summary>
    let enumerated = _prefixId.prefix "enumerated"
    /// <summary>
    ///   <para>rdfs:label : evidenceType^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link the EvidenceType to an Evidence^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#evidenceType">ishi:evidenceType</a>
    /// </summary>
    let evidenceType = _prefixId.prefix "evidenceType"
    /// <summary>
    ///   <para>rdfs:label : factor^^xsd:string</para>
    ///   <para>rdfs:comment : Property links Factors to their Model.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#factor">ishi:factor</a>
    /// </summary>
    let factor = _prefixId.prefix "factor"
    /// <summary>
    ///   <para>rdfs:label : hadRole^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Ishikawa ontology, this property is used to assign roles according to the RASCI model.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#hadRole">ishi:hadRole</a>
    /// </summary>
    let hadRole = _prefixId.prefix "hadRole"
    /// <summary>
    ///   <para>rdfs:label : hasEvidence^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a CauseEffect to any Evidence.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#hasEvidence">ishi:hasEvidence</a>
    /// </summary>
    let hasEvidence = _prefixId.prefix "hasEvidence"
    /// <summary>
    ///   <para>rdfs:label : hasNamedRange^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a WeightRange to a WeightScale.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#hasNamedRange">ishi:hasNamedRange</a>
    /// </summary>
    let hasNamedRange = _prefixId.prefix "hasNamedRange"
    /// <summary>
    ///   <para>rdfs:label : hasQualitativeEvidence^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a CauseEffect to any Evidence with the assumption that the evidence is qualitative..^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#hasQualitativeEvidence">ishi:hasQualitativeEvidence</a>
    /// </summary>
    let hasQualitativeEvidence = _prefixId.prefix "hasQualitativeEvidence"
    /// <summary>
    ///   <para>rdfs:label : hasQuantitativeEvidence^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a CauseEffect to any Evidence with the assumption that the evidence is quantitative^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#hasQuantitativeEvidence">ishi:hasQuantitativeEvidence</a>
    /// </summary>
    let hasQuantitativeEvidence = _prefixId.prefix "hasQuantitativeEvidence"
    /// <summary>
    ///   <para>rdfs:label : hasWeightRange^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a WeightScale to the WeightRange which defines its total range.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#hasWeightRange">ishi:hasWeightRange</a>
    /// </summary>
    let hasWeightRange = _prefixId.prefix "hasWeightRange"
    /// <summary>
    ///   <para>rdfs:label : illustratedEvidence^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to indicate, if the evidence basis was emphasized in the visual representation of the Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#illustratedEvidence">ishi:illustratedEvidence</a>
    /// </summary>
    let illustratedEvidence = _prefixId.prefix "illustratedEvidence"
    /// <summary>
    ///   <para>rdfs:label : illustratedFactorInfluence^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to indicate, if the factors' influence on the problem were emphasized in the visual representation of the Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#illustratedFactorInfluence">ishi:illustratedFactorInfluence</a>
    /// </summary>
    let illustratedFactorInfluence = _prefixId.prefix "illustratedFactorInfluence"
    /// <summary>
    ///   <para>rdfs:label : illustratedRoles^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to indicate, if responsibilities or roles towards factors were included in the visual representation of the Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#illustratedRoles">ishi:illustratedRoles</a>
    /// </summary>
    let illustratedRoles = _prefixId.prefix "illustratedRoles"
    /// <summary>
    ///   <para>rdfs:label : illustratedWeight^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to indicate, if weight differences were emphasized in the visual representation of the Ishikawa diagram.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#illustratedWeight">ishi:illustratedWeight</a>
    /// </summary>
    let illustratedWeight = _prefixId.prefix "illustratedWeight"
    /// <summary>
    ///   <para>rdfs:label : isCauseEffectOf^^xsd:string</para>
    ///   <para>rdfs:comment : inverse property to causeEffect^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#isCauseEffectOf">ishi:isCauseEffectOf</a>
    /// </summary>
    let isCauseEffectOf = _prefixId.prefix "isCauseEffectOf"
    /// <summary>
    ///   <para>rdfs:label : isFactorOf^^xsd:string</para>
    ///   <para>rdfs:comment : inverse property to factor^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#isFactorOf">ishi:isFactorOf</a>
    /// </summary>
    let isFactorOf = _prefixId.prefix "isFactorOf"
    /// <summary>
    ///   <para>rdfs:label : model^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link the visual representation of an Ishikawa diagram to its data model.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#model">ishi:model</a>
    /// </summary>
    let model = _prefixId.prefix "model"
    let neutralizing = _prefixId.prefix "neutralizing"
    let noEvidence = _prefixId.prefix "noEvidence"

    let productProcessClassificationDiagram =
        _prefixId.prefix "productProcessClassificationDiagram"

    /// <summary>
    ///   <para>rdfs:label : qualifiedCauseEffect^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a qualified CauseEffect to a Factor.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffect">ishi:qualifiedCauseEffect</a>
    /// </summary>
    let qualifiedCauseEffect = _prefixId.prefix "qualifiedCauseEffect"
    /// <summary>
    ///   <para>rdfs:label : qualifiedCauseEffectOf^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a qualified CauseEffect to a Factor.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#qualifiedCauseEffectOf">ishi:qualifiedCauseEffectOf</a>
    /// </summary>
    let qualifiedCauseEffectOf = _prefixId.prefix "qualifiedCauseEffectOf"
    let qualitativeEvidence = _prefixId.prefix "qualitativeEvidence"
    let quantitativeEvidence = _prefixId.prefix "quantitativeEvidence"
    /// <summary>
    ///   <para>rdfs:label : scale^^xsd:string</para>
    ///   <para>rdfs:comment : The property is used to link the WeigthScale to a Weight.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#scale">ishi:scale</a>
    /// </summary>
    let scale = _prefixId.prefix "scale"
    let undecided = _prefixId.prefix "undecided"
    /// <summary>
    ///   <para>rdfs:label : usedTechnique^^xsd:string</para>
    ///   <para>rdfs:comment : Property to indicate which Technique was used in the Workshop^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#usedTechnique">ishi:usedTechnique</a>
    /// </summary>
    let usedTechnique = _prefixId.prefix "usedTechnique"
    /// <summary>
    ///   <para>rdfs:label : wasCausedBy^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to directly link an Effect to a Cause without further qualification. For qualified cause-effect relationships the CauseEffect class is used.^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#wasCausedBy">ishi:wasCausedBy</a>
    /// </summary>
    let wasCausedBy = _prefixId.prefix "wasCausedBy"
    /// <summary>
    ///   <para>rdfs:label : weight^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link a Weight to a CauseEffect^^xsd:string</para>
    ///   <a href="https://w3id.org/ishikawa-diagram-ontology#weight">ishi:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"
