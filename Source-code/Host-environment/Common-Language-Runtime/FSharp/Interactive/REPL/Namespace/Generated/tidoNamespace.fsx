#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tido =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/tido#" "tido"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Activity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://www.w3.org/TR/2013/REC-prov-o-20130430/#Action^^xsd:string</para>
    ///   <para>rdfs:comment : The tido:Activity class is directly inherited from PROV-O. Here, an activity is defined as something that occurs over a period of time and acts upon or with pieces of information; it may include consuming, processing, transforming, modifying, relocating, using, or generating pieces of information.^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Activity">tido:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://www.w3.org/TR/2013/REC-prov-o-20130430/#Agent^^xsd:string</para>
    ///   <para>rdfs:comment : The tido:Agent class is directly inherited from PROV-O. Here, an agent is defined as something that bears some form of responsibility for an activity taking place, for the existence of an entity, or for another agent's activity^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Agent">tido:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>skos:altLabel : Investigation^^xsd:string</para>
    ///   <para>rdfs:label : Case^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of pieces of information that were recalled, inferred, deduced or produced during an investigation. ^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Case">tido:Case</a>
    /// </summary>
    let Case = _prefixId.prefix "Case"
    /// <summary>
    ///   <para>rdfs:label : Consideration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://www.merriam-webster.com/dictionary/consideration^^xsd:string</para>
    ///   <para>rdfs:comment : A matter weighed or taken into account when formulating an opinion or plan^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Consideration">tido:Consideration</a>
    /// </summary>
    let Consideration = _prefixId.prefix "Consideration"
    /// <summary>
    ///   <para>rdfs:label : Cost^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://www.merriam-webster.com/dictionary/cost^^xsd:string</para>
    ///   <para>rdfs:comment : The outlay or expenditure (as of effort or sacrifice) made to achieve an object^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Cost">tido:Cost</a>
    /// </summary>
    let Cost = _prefixId.prefix "Cost"
    /// <summary>
    ///   <para>skos:altLabel : Evaluation step^^xsd:string</para>
    ///   <para>rdfs:label : Evaluation^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : Bales' 2nd phase of group-decision making^^xsd:string</para>
    ///   <para>rdfs:comment : A step in the decision process where opinions, evaluations and analysis are expressed. ^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Evaluation">tido:Evaluation</a>
    /// </summary>
    let Evaluation = _prefixId.prefix "Evaluation"
    /// <summary>
    ///   <para>rdfs:label : Evidence^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : http://eturwg.c4i.gmu.edu/files/ontologies/URREF#SingularEvidence^^xsd:string</para>
    ///   <para>rdfs:comment : A piece of information that is either a testamony, an observation, or a sensory measurement.^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Evidence">tido:Evidence</a>
    /// </summary>
    let Evidence = _prefixId.prefix "Evidence"
    /// <summary>
    ///   <para>rdfs:label : Goal^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://www.merriam-webster.com/dictionary/aim^^xsd:string</para>
    ///   <para>rdfs:comment : A clearly directed intent or purpose^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Goal">tido:Goal</a>
    /// </summary>
    let Goal = _prefixId.prefix "Goal"
    /// <summary>
    ///   <para>rdfs:label : Hypothesis^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://www.merriam-webster.com/dictionary/hypothesis^^xsd:string</para>
    ///   <para>rdfs:comment : A possible interpretation of the availble information that forms the ground for further action. Other pieces of information could be used to either support or dispute a hypothesis.^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Hypothesis">tido:Hypothesis</a>
    /// </summary>
    let Hypothesis = _prefixId.prefix "Hypothesis"
    /// <summary>
    ///   <para>rdfs:label : Option^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://www.merriam-webster.com/dictionary/option^^xsd:string</para>
    ///   <para>rdfs:comment : Something that could be chosen. In the domain of Threat Intelligence, this could mean a course of action, but also an assesment of the situation or the answer to a research question.^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Option">tido:Option</a>
    /// </summary>
    let Option = _prefixId.prefix "Option"
    /// <summary>
    ///   <para>skos:altLabel : Orientation step^^xsd:string</para>
    ///   <para>rdfs:label : Orientation^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : Bales' 1st phase of group-decision making^^xsd:string</para>
    ///   <para>rdfs:comment : A step in the decision process where available information is shared, repeated, clarified or confirmed.^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Orientation">tido:Orientation</a>
    /// </summary>
    let Orientation = _prefixId.prefix "Orientation"
    /// <summary>
    ///   <para>skos:altLabel : Sentence^^xsd:stringskos:altLabel : Piece of information^^xsd:stringskos:altLabel : PoI^^xsd:string</para>
    ///   <para>rdfs:label : Piece Of Information^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : URREF (Costa et al. 2018)^^xsd:string</para>
    ///   <para>rdfs:comment : The term “piece of information” is used in this paper in its most general meaning covering other notions such as evidence, knowledge and/or data. A piece of information can be as simple as a measurement (on the scale of real numbers) but could be a fact (i.e., an observation, known to be true), an uncertain statement already modeled into a given mathematical formalism (i.e., a probability distribution), an unstructured statement in natural language^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#PieceOfInformation">tido:PieceOfInformation</a>
    /// </summary>
    let PieceOfInformation = _prefixId.prefix "PieceOfInformation"
    /// <summary>
    ///   <para>skos:altLabel : Research question^^xsd:stringskos:altLabel : RQ^^xsd:string</para>
    ///   <para>rdfs:label : R Q^^xsd:string</para>
    ///   <para>rdfs:comment : A question that arrises during an investigation.^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#RQ">tido:RQ</a>
    /// </summary>
    let RQ = _prefixId.prefix "RQ"
    /// <summary>
    ///   <para>skos:altLabel : Resolution step^^xsd:string</para>
    ///   <para>rdfs:label : Resolution^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : Bales' 3rd phase of group decision making^^xsd:string</para>
    ///   <para>rdfs:comment : A step in the decision process where a possible direction is chosen^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#Resolution">tido:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>rdfs:label : answers^^xsd:string</para>
    ///   <para>rdfs:comment : A piece of information can be used to answer a research question. This piece of information can be anything, as long as it can be expressed in a sentence^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#answers">tido:answers</a>
    /// </summary>
    let answers = _prefixId.prefix "answers"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.merriam-webster.com/dictionary/assume^^xsd:string</para>
    ///   <para>rdfs:label : assumes^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship indicating how an option would take an hypothesis as granted or true^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#assumes">tido:assumes</a>
    /// </summary>
    let assumes = _prefixId.prefix "assumes"
    /// <summary>
    ///   <para>rdfs:label : contributes to^^xsd:string</para>
    ///   <para>rdfs:comment : Every activity should contribute to one or more cases/investigations. ^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#contributesTo">tido:contributesTo</a>
    /// </summary>
    let contributesTo = _prefixId.prefix "contributesTo"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.merriam-webster.com/dictionary/dispute^^xsd:string</para>
    ///   <para>rdfs:label : disputes^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship indicating how a piece of information calls into question or casts doubt upon a hypothesis^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#disputes">tido:disputes</a>
    /// </summary>
    let disputes = _prefixId.prefix "disputes"
    /// <summary>
    ///   <para>rdfs:label : has consideration^^xsd:string</para>
    ///   <para>rdfs:comment : An option can have multiple considerations that help in deciding on whether on not to select that option^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#hasConsideration">tido:hasConsideration</a>
    /// </summary>
    let hasConsideration = _prefixId.prefix "hasConsideration"
    /// <summary>
    ///   <para>rdfs:label : has context^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship indicating how one piece of information provides relevant context to another piece of information.^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#hasContext">tido:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>rdfs:label : informs^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship that indicates which options would aid answering a research question. ^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#informs">tido:informs</a>
    /// </summary>
    let informs = _prefixId.prefix "informs"
    /// <summary>
    ///   <para>rdfs:label : investigates^^xsd:string</para>
    ///   <para>rdfs:comment : An investigation, or case, investigates one or more research questions^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#investigates">tido:investigates</a>
    /// </summary>
    let investigates = _prefixId.prefix "investigates"
    /// <summary>
    ///   <para>skos:altLabel : provides insight into^^xsd:string</para>
    ///   <para>rdfs:label : provides insights into^^xsd:string</para>
    ///   <para>rdfs:comment : The super-property of tido:supports and tido:disputes^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#providesInsightsInto">tido:providesInsightsInto</a>
    /// </summary>
    let providesInsightsInto = _prefixId.prefix "providesInsightsInto"
    /// <summary>
    ///   <para>rdfs:label : questions^^xsd:string</para>
    ///   <para>rdfs:comment : A research question can be raised by a piece of information^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#questions">tido:questions</a>
    /// </summary>
    let questions = _prefixId.prefix "questions"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://www.merriam-webster.com/dictionary/supports and https://www.merriam-webster.com/dictionary/corroborate^^xsd:string</para>
    ///   <para>rdfs:label : supports^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship indicating how a piece of information provides a hypothesis with substantiation/to support with evidence or authority, making it more certain^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#supports">tido:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : was executed by^^xsd:string</para>
    ///   <para>rdfs:comment : Once an option is selected, it could be excecuted by an activity. ^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#wasExecutedBy">tido:wasExecutedBy</a>
    /// </summary>
    let wasExecutedBy = _prefixId.prefix "wasExecutedBy"
    /// <summary>
    ///   <para>rdfs:label : was recalled by^^xsd:string</para>
    ///   <para>rdfs:comment : During an orientation step, no new informatoin is generated but only pre-existing information is recalled^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#wasRecalledBy">tido:wasRecalledBy</a>
    /// </summary>
    let wasRecalledBy = _prefixId.prefix "wasRecalledBy"
    /// <summary>
    ///   <para>rdfs:label : was selected by^^xsd:string</para>
    ///   <para>rdfs:comment : An option can be selected during a resolution step. This selection of an option is what constitudes a decision.^^xsd:string</para>
    ///   <a href="https://w3id.org/tido#wasSelectedBy">tido:wasSelectedBy</a>
    /// </summary>
    let wasSelectedBy = _prefixId.prefix "wasSelectedBy"
