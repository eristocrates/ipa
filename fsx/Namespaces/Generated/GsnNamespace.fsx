#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gsn =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/OntoGSN/ontology#" "gsn"

    let A = _prefixId.prefix "A"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : A body of information presented with the intention to establish one or more claims through the presentation of related supporting claims, evidence and contextual information.skos:definition : A connected series of claims intended to establish an overall claim.</para>
    ///   <para>rdfs:label : Argument</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Argument">gsn:Argument</a>
    /// </summary>
    let Argument = _prefixId.prefix "Argument"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:altLabel : Evidence</para>
    ///   <para>rdfs:label : Artefact</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Artefact">gsn:Artefact</a>
    /// </summary>
    let Artefact = _prefixId.prefix "Artefact"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : Artefact Reference</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#ArtefactReference">gsn:ArtefactReference</a>
    /// </summary>
    let ArtefactReference = _prefixId.prefix "ArtefactReference"
    /// <summary>
    ///   <para>gsn:renderedAs : oval</para>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : An assumption, rendered as an oval with the letter 'A' at the top- or bottom-right, presents an intentionally unsubstantiated statement.</para>
    ///   <para>rdfs:label : Assumption</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Assumption">gsn:Assumption</a>
    /// </summary>
    let Assumption = _prefixId.prefix "Assumption"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : A reasoned and compelling argument, supported by a body of evidence, that a system, service or organisation will operate as intended for a defined application in a defined environment.skos:definition : Arguments and evidence intended to demonstrate that a system meets its assurance requirements.</para>
    ///   <para>rdfs:label : Assurance Case</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#AssuranceCase">gsn:AssuranceCase</a>
    /// </summary>
    let AssuranceCase = _prefixId.prefix "AssuranceCase"
    let B = _prefixId.prefix "B"
    let C = _prefixId.prefix "C"
    let C1 = _prefixId.prefix "C1"
    let C2 = _prefixId.prefix "C2"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : A pattern catalogue may be created to collate a series of patterns; where such a catalogue is created the structure and format of the definition should be consistent and each pattern’s definition should have a unique {pattern identifier}.</para>
    ///   <para>rdfs:label : Catalogue</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Catalogue">gsn:Catalogue</a>
    /// </summary>
    let Catalogue = _prefixId.prefix "Catalogue"
    /// <summary>
    ///   <para>gsn:renderedAs : rounded rectangle</para>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : A context, rendered as shown left, presents a contextual artefact. This can be a reference to contextual information, or a statement.</para>
    ///   <para>rdfs:label : Context</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Context">gsn:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    let D = _prefixId.prefix "D"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Dialectic Extension</para>
    ///   <para>skos:note : Membership of this class is only meant to be inferred, not asserted! Please do not add individuals to this class manually (i.e., assertions).skos:note : The goal and solution statements should be clearly expressed such that the crux of the challenge is unequivocally communicated. Thus, the link between the part of the argument that is being challenged (target) and the dialectic element (source) is self-evident.</para>
    ///   <para>skos:definition : The source of challenge being applied; can be directed at any part of an argument. A defeater (goal or solution) can challenge any element in a goal structure, e.g. goal, solution, strategy, context, assumption, justification.^^xsd:string</para>
    ///   <para>skos:altLabel : Dialectic Element</para>
    ///   <para>rdfs:label : Defeater</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Defeater">gsn:Defeater</a>
    /// </summary>
    let Defeater = _prefixId.prefix "Defeater"
    let E = _prefixId.prefix "E"
    let E1 = _prefixId.prefix "E1"
    let E2 = _prefixId.prefix "E2"
    let G = _prefixId.prefix "G"
    let G1 = _prefixId.prefix "G1"
    let G2 = _prefixId.prefix "G2"
    let G3 = _prefixId.prefix "G3"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : GSN Element</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#GSNElement">gsn:GSNElement</a>
    /// </summary>
    let GSNElement = _prefixId.prefix "GSNElement"
    /// <summary>
    ///   <para>skos:definition : (Claim is) A proposition being asserted by the author that is a true or false statement.skos:definition : A goal, rendered as a rectangle, presents a claim forming part of the argument.</para>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:altLabel : Claim</para>
    ///   <para>rdfs:label : Goal</para>
    ///   <para>gsn:renderedAs : rectangle</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Goal">gsn:Goal</a>
    /// </summary>
    let Goal = _prefixId.prefix "Goal"
    let ID = _prefixId.prefix "ID"
    /// <summary>
    ///   <para>gsn:renderedAs : hollow triangle^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : This symbol indicates that the GSN argument below the attached element is to be instantiated as a template argument. It provides a reference to the information used to instantiate the template argument.^^xsd:string</para>
    ///   <para>rdfs:label : Instantiation Data Reference</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#InstantiationDataReference">gsn:InstantiationDataReference</a>
    /// </summary>
    let InstantiationDataReference = _prefixId.prefix "InstantiationDataReference"
    let J = _prefixId.prefix "J"
    /// <summary>
    ///   <para>gsn:renderedAs : oval</para>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : A justification, rendered as an oval with the letter 'J' at the top- or bottom-right, presents a statement of rationale.</para>
    ///   <para>rdfs:label : Justification</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Justification">gsn:Justification</a>
    /// </summary>
    let Justification = _prefixId.prefix "Justification"
    let M = _prefixId.prefix "M"
    let M1 = _prefixId.prefix "M1"
    let M2 = _prefixId.prefix "M2"
    let M3 = _prefixId.prefix "M3"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>rdfs:label : Module</para>
    ///   <para>skos:definition : Goal structures can be partitioned into separate, but interrelated, modules. This can allow the division of an overall goal structure into separate goal structures focusing on particular aspects of the overall argument. A module may contain one or more arguments and may contain other modules.</para>
    ///   <para>gsn:renderedAs : a rectangle with a second smaller rectangle adjoining at the top left^^xsd:string</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Module">gsn:Module</a>
    /// </summary>
    let Module = _prefixId.prefix "Module"
    let N = _prefixId.prefix "N"
    let P = _prefixId.prefix "P"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : Pattern</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Pattern">gsn:Pattern</a>
    /// </summary>
    let Pattern = _prefixId.prefix "Pattern"
    let R = _prefixId.prefix "R"
    let R1 = _prefixId.prefix "R1"
    let R2 = _prefixId.prefix "R2"
    let R3 = _prefixId.prefix "R3"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : Relationship</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Relationship">gsn:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>skos:note : The corresponding argument could be located in a paragraph of accompanying text, a goal in the local argument, or a goal in a separate module.</para>
    ///   <para>gsn:coreOrExtension : Confidence Argument Extension</para>
    ///   <para>rdfs:label : Relationship with Confidence</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#RelationshipWithConfidence">gsn:RelationshipWithConfidence</a>
    /// </summary>
    let RelationshipWithConfidence = _prefixId.prefix "RelationshipWithConfidence"
    let S = _prefixId.prefix "S"
    let S1 = _prefixId.prefix "S1"
    let S2 = _prefixId.prefix "S2"
    /// <summary>
    ///   <para>gsn:renderedAs : circle</para>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : A solution, rendered as a circle, presents a reference to an evidence item.</para>
    ///   <para>rdfs:label : Solution</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Solution">gsn:Solution</a>
    /// </summary>
    let Solution = _prefixId.prefix "Solution"
    /// <summary>
    ///   <para>gsn:renderedAs : parallelogram</para>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : A strategy, rendered as a parallelogram, describes the inference that exists between a goal and its supporting goal(s).</para>
    ///   <para>rdfs:label : Strategy</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Strategy">gsn:Strategy</a>
    /// </summary>
    let Strategy = _prefixId.prefix "Strategy"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : A template argument is a special case of a pattern argument. It uses the core GSN and argument pattern extension to construct an argument structure which requires no further development.</para>
    ///   <para>rdfs:label : Template</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#Template">gsn:Template</a>
    /// </summary>
    let Template = _prefixId.prefix "Template"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>skos:definition : The argument view depicts the argument inside an individual module.</para>
    ///   <para>rdfs:label : View</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#View">gsn:View</a>
    /// </summary>
    let View = _prefixId.prefix "View"
    let X = _prefixId.prefix "X"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : The applicability section should state under what circumstances the pattern can be applied, making clear the assumptions and principles underlying the pattern to avoid inappropriate application in a mismatched context. This section should record what contextual information is required in order to apply the pattern.</para>
    ///   <para>rdfs:label : applicability</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#applicability">gsn:applicability</a>
    /// </summary>
    let applicability = _prefixId.prefix "applicability"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Confidence Argument Extension</para>
    ///   <para>rdfs:label : argument type</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#argumentType">gsn:argumentType</a>
    /// </summary>
    let argumentType = _prefixId.prefix "argumentType"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Confidence Argument Extension</para>
    ///   <para>rdfs:label : associated with</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#associatedWith">gsn:associatedWith</a>
    /// </summary>
    let associatedWith = _prefixId.prefix "associatedWith"
    /// <summary>
    ///   <para>gsn:renderedAs : solid square^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Confidence Argument Extension</para>
    ///   <para>skos:definition : An Assurance Claim Point (ACP) can be used in GSN to indicate that a confidence argument is associated with an assertion in a risk argument.</para>
    ///   <para>rdfs:label : assurance claim point</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#assuranceClaimPoint">gsn:assuranceClaimPoint</a>
    /// </summary>
    let assuranceClaimPoint = _prefixId.prefix "assuranceClaimPoint"
    /// <summary>
    ///   <para>gsn:renderedAs : dotted line^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : attached to</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#attachedTo">gsn:attachedTo</a>
    /// </summary>
    let attachedTo = _prefixId.prefix "attachedTo"
    /// <summary>
    ///   <para>gsn:renderedAs : bisecting line in the lower half^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>skos:definition : An away element reference repeats a claim or evidence presented in another argument module.</para>
    ///   <para>schema:description : An away assumption repeats an assumption presented in another argument module and is typically used only in Contract Modules. An away context repeats a reference to context presented in another argument module. An away goal reference repeats a claim presented in another argument module. An away justification repeats a justification presented in another argument module and is typically used only in Contract Modules. An away solution repeats a reference to evidence items presented in another argument module.</para>
    ///   <para>rdfs:label : away</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#away">gsn:away</a>
    /// </summary>
    let away = _prefixId.prefix "away"
    /// <summary>
    ///   <para>gsn:renderedAs : dashed line with an open arrowhead^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Dialectic Extension</para>
    ///   <para>skos:note : A challenge must be levied against the appropriate aspect of the goal structure.</para>
    ///   <para>skos:definition : Allows a Challenge to any GSN entity to be documented. A goal, (core element) can be used in a dialectic context to assert a challenge to part of the argument. A solution, (core element) can be used to present a reference to an evidence item that asserts a challenge to part of the argument.</para>
    ///   <para>rdfs:label : challenges</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#challenges">gsn:challenges</a>
    /// </summary>
    let challenges = _prefixId.prefix "challenges"
    /// <summary>
    ///   <para>gsn:renderedAs : solid diamond^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : A GSN choice can be used to denote possible alternatives in satisfying a relationship.</para>
    ///   <para>rdfs:label : choice</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#choice">gsn:choice</a>
    /// </summary>
    let choice = _prefixId.prefix "choice"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : The collaboration section should describe how elements of the pattern work together to achieve the desired effect, particularly where there are links that are not readily apparent from the argument structure.</para>
    ///   <para>rdfs:label : collaboration</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#collaboration">gsn:collaboration</a>
    /// </summary>
    let collaboration = _prefixId.prefix "collaboration"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : The consequences section should make clear what work remains after the pattern has been applied. This should highlight where further support to the argument is required, and assumptions that need to be discharged.</para>
    ///   <para>rdfs:label : consequences</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#consequences">gsn:consequences</a>
    /// </summary>
    let consequences = _prefixId.prefix "consequences"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>skos:definition : By making the relationship to the away goal the author is asserting not only the inference of support for the parent goal, but also that the context in which the away goal is declared is consistent with the context and assumptions in scope for the parent goal.^^xsd:string</para>
    ///   <para>rdfs:label : consistent with</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#consistentWith">gsn:consistentWith</a>
    /// </summary>
    let consistentWith = _prefixId.prefix "consistentWith"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : contains</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#contains">gsn:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>skos:definition : A contract module is a special type of module that controls the relationship between argument module interfaces using arguments to define how a goal in one module is supported by one or more goals in one or more other modules.</para>
    ///   <para>gsn:renderedAs : a rectangle with two smaller rectangles (of equal size to each other) adjoining at the top left and bottom right^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>skos:note : A contract may be described in textual form (e.g. as a table) or for more complex relationships may be described within a contract module using GSN.skos:note : Contract modules can be used in the support relationship between modules to aid decoupling. The de-coupling by use of a contract permits argument module construction in cases where the eventual source of support for an argument is unknown at the time of authoring or can be changed for example through re-use or planned product improvement or reconfiguration.</para>
    ///   <para>rdfs:label : contract</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#contract">gsn:contract</a>
    /// </summary>
    let contract = _prefixId.prefix "contract"
    /// <summary>
    ///   <para>skos:definition : Indicator of the sourcing section in the GSN Community Standard v3.</para>
    ///   <para>rdfs:label : core or extension</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#coreOrExtension">gsn:coreOrExtension</a>
    /// </summary>
    let coreOrExtension = _prefixId.prefix "coreOrExtension"
    /// <summary>
    ///   <para>gsn:renderedAs : cross (‘X’) superimposed on a GSN element or relationship^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Dialectic Extension</para>
    ///   <para>skos:definition : This decorator symbol indicates that the element is defeated. The Defeated decorator can be applied to any of the GSN elements.</para>
    ///   <para>schema:description : Defeated Relationship indicates that the relationship is defeated. The Defeated decorator can be applied to any of the GSN relationships.</para>
    ///   <para>rdfs:label : defeated</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#defeated">gsn:defeated</a>
    /// </summary>
    let defeated = _prefixId.prefix "defeated"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : It may be useful to provide example illustrations of the application of the pattern, particularly for more abstract patterns. Illustrations should include a typical case and can be supplemented with atypical cases where more than one example is provided.</para>
    ///   <para>rdfs:label : examples</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#examples">gsn:examples</a>
    /// </summary>
    let examples = _prefixId.prefix "examples"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : final</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#final">gsn:final</a>
    /// </summary>
    let final = _prefixId.prefix "final"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : The implementation section should communicate how the application of the pattern is carried out e.g. the order in which elements should be developed; communicate hints or techniques that may ease successful application; highlight common or recognised pitfalls with the application of the pattern; and record potential misinterpretation of the terms or concepts in the pattern.</para>
    ///   <para>rdfs:label : implementation</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#implementation">gsn:implementation</a>
    /// </summary>
    let implementation = _prefixId.prefix "implementation"
    /// <summary>
    ///   <para>gsn:renderedAs : line with a hollow arrowhead^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : InContextOf, rendered as a line with a hollow arrowhead, declares a contextual relationship.</para>
    ///   <para>rdfs:label : in context of</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#inContextOf">gsn:inContextOf</a>
    /// </summary>
    let inContextOf = _prefixId.prefix "inContextOf"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Dialectic Extension</para>
    ///   <para>skos:definition : The dialectic challenge within this structure asserts that if the claim presented in Goal CG1 is true then this is sufficient to establish that the claim in Goal G1 in the original structure is in doubt.</para>
    ///   <para>rdfs:label : in doubt</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#inDoubt">gsn:inDoubt</a>
    /// </summary>
    let inDoubt = _prefixId.prefix "inDoubt"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : instantiation of</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#instantiationOf">gsn:instantiationOf</a>
    /// </summary>
    let instantiationOf = _prefixId.prefix "instantiationOf"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : The intent statement should state clearly what the pattern aims to achieve.</para>
    ///   <para>rdfs:label : intent</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#intent">gsn:intent</a>
    /// </summary>
    let intent = _prefixId.prefix "intent"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : It may be useful to provide references to known applications of the pattern. These can serve as additional examples.</para>
    ///   <para>rdfs:label : known uses</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#knownUses">gsn:knownUses</a>
    /// </summary>
    let knownUses = _prefixId.prefix "knownUses"
    /// <summary>
    ///   <para>gsn:renderedAs : text^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : maximum cardinality</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#maxCardinality">gsn:maxCardinality</a>
    /// </summary>
    let maxCardinality = _prefixId.prefix "maxCardinality"
    /// <summary>
    ///   <para>gsn:renderedAs : text^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : minimum cardinality</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#minCardinality">gsn:minCardinality</a>
    /// </summary>
    let minCardinality = _prefixId.prefix "minCardinality"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : The motivation statement can be used to state why the pattern was created. It could be expressed in terms of previous experiences e.g. as the abstraction of a successfully presented argument, or challenges addressed e.g. argument topics that are often incompletely or poorly addressed.</para>
    ///   <para>rdfs:label : motivation</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#motivation">gsn:motivation</a>
    /// </summary>
    let motivation = _prefixId.prefix "motivation"
    /// <summary>
    ///   <para>gsn:renderedAs : solid ball^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : multiple</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#multiple">gsn:multiple</a>
    /// </summary>
    let multiple = _prefixId.prefix "multiple"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : off-diagram</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#offDiagram">gsn:offDiagram</a>
    /// </summary>
    let offDiagram = _prefixId.prefix "offDiagram"
    /// <summary>
    ///   <para>gsn:renderedAs : hollow ball</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : Optional instantiation means that the relationship and the argument below may or may not be instantiated.</para>
    ///   <para>rdfs:label : optional</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#optional">gsn:optional</a>
    /// </summary>
    let optional = _prefixId.prefix "optional"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : The participants section augments the structure by providing a description of each element. This can provide more complete descriptions, clarify the role of the element in the overall argument and emphasise the aspects that require development or instantiation.</para>
    ///   <para>rdfs:label : participants</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#participants">gsn:participants</a>
    /// </summary>
    let participants = _prefixId.prefix "participants"
    /// <summary>
    ///   <para>gsn:renderedAs : miniature module symbol superimposed on an element at the top right^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>skos:definition : This indicates that the element is publicly visible in one or more interfaces of the module and can be referenced as an away element.</para>
    ///   <para>rdfs:label : public</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#public">gsn:public</a>
    /// </summary>
    let public_ = _prefixId.prefix "public"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : published</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#published">gsn:published</a>
    /// </summary>
    let published = _prefixId.prefix "published"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : refers to</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#refersTo">gsn:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : This section can be used to reference patterns that are related e.g. addressing the same intent in a different context.</para>
    ///   <para>rdfs:label : related to</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#relatedTo">gsn:relatedTo</a>
    /// </summary>
    let relatedTo = _prefixId.prefix "relatedTo"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : An evidential relationship is a declared relationship between a claim and an evidence item by which the claim is substantiated. An inferential relationship is a declared inference between claims in the argument. A contextual relationship draws attention to explanatory contextual information.skos:definition : SupportedBy relationships – represented by lines with solid arrowheads – indicate inferential or evidential relationships between elements. InContextOf relationships – represented as lines with hollow arrowheads – declare contextual relationships.</para>
    ///   <para>rdfs:label : relationship type</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#relationshipType">gsn:relationshipType</a>
    /// </summary>
    let relationshipType = _prefixId.prefix "relationshipType"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : rendered as</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#renderedAs">gsn:renderedAs</a>
    /// </summary>
    let renderedAs = _prefixId.prefix "renderedAs"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : statement</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#statement">gsn:statement</a>
    /// </summary>
    let statement = _prefixId.prefix "statement"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : The structure uses the structural and element abstraction notations to present the pattern, clearly indicating where the argument needs to be further developed or populated with details to instantiate the pattern for a specific case.</para>
    ///   <para>rdfs:label : structure</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#structure">gsn:structure</a>
    /// </summary>
    let structure = _prefixId.prefix "structure"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : A particular kind of argument where the relationships between the asserted claims, and from the evidence to the claims, are explicitly represented.</para>
    ///   <para>rdfs:label : structured</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#structured">gsn:structured</a>
    /// </summary>
    let structured = _prefixId.prefix "structured"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>skos:definition : There may be occasions when a goal or strategy requires fuller justification than can be provided within the confines of a GSN justification element. In such cases, an away goal can be substituted for the justification.</para>
    ///   <para>rdfs:label : substituted by</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#substitutedBy">gsn:substitutedBy</a>
    /// </summary>
    let substitutedBy = _prefixId.prefix "substitutedBy"
    /// <summary>
    ///   <para>gsn:renderedAs : line with a solid arrowhead^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : SupportedBy, rendered as a line with a solid arrowhead, allows support relationships between elements to be documented.</para>
    ///   <para>rdfs:label : supported by</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#supportedBy">gsn:supportedBy</a>
    /// </summary>
    let supportedBy = _prefixId.prefix "supportedBy"
    /// <summary>
    ///   <para>gsn:renderedAs : attached centrally immediately below the goal to which it relates^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>rdfs:label : to be supported by contract</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#toBeSupportedByContract">gsn:toBeSupportedByContract</a>
    /// </summary>
    let toBeSupportedByContract = _prefixId.prefix "toBeSupportedByContract"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>skos:definition : A GSN Goal that presents the pinnacle claim in an argument. It is ‘top’ in terms of the argument hierarchy, rather than necessarily its physical layout. There may be more than one top goal in a GSN structure.skos:definition : The top goal presents the overall claim asserted by the author and it is up to the reader to determine their belief that it is adequately supported.</para>
    ///   <para>rdfs:label : top (goal)</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#top">gsn:top</a>
    /// </summary>
    let top = _prefixId.prefix "top"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : true</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#true">gsn:true</a>
    /// </summary>
    let true_ = _prefixId.prefix "true"
    /// <summary>
    ///   <para>gsn:renderedAs : hollow diamond^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>skos:definition : Undeveloped element decorator, rendered as a hollow diamond applied to the bottom centre of an element, indicates that a line of argument has not been developed.</para>
    ///   <para>rdfs:label : undeveloped</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#undeveloped">gsn:undeveloped</a>
    /// </summary>
    let undeveloped = _prefixId.prefix "undeveloped"
    /// <summary>
    ///   <para>gsn:renderedAs : hollow triangle^^xsd:string</para>
    ///   <para>gsn:coreOrExtension : Argument Pattern Extension</para>
    ///   <para>rdfs:label : uninstantiated</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#uninstantiated">gsn:uninstantiated</a>
    /// </summary>
    let uninstantiated = _prefixId.prefix "uninstantiated"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Core GSN</para>
    ///   <para>rdfs:label : valid</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#valid">gsn:valid</a>
    /// </summary>
    let valid = _prefixId.prefix "valid"
    /// <summary>
    ///   <para>gsn:coreOrExtension : Modular Extension</para>
    ///   <para>rdfs:label : view type</para>
    ///   <a href="https://w3id.org/OntoGSN/ontology#viewType">gsn:viewType</a>
    /// </summary>
    let viewType = _prefixId.prefix "viewType"
