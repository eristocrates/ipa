namespace https.w3id.org.tido.hash

open DoxAletheia

module tido =
    let _namespace_name = "https://w3id.org/tido#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The tido:Activity class is directly inherited from PROV-O. Here, an activity is defined as something that occurs over a period of time and acts upon or with pieces of information; it may include consuming, processing, transforming, modifying, relocating, using, or generating pieces of information.
    /// <see href="https://w3id.org/tido#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// A collection of pieces of information that were recalled, inferred, deduced or produced during an investigation.
    /// <see href="https://w3id.org/tido#Case"></see></summary>
    let Case = _prefix "Case"
    /// <summary>
    /// Every activity should contribute to one or more cases/investigations.
    /// <see href="https://w3id.org/tido#contributesTo"></see></summary>
    let contributesTo = _prefix "contributesTo"
    /// <summary>
    /// The tido:Agent class is directly inherited from PROV-O. Here, an agent is defined as something that bears some form of responsibility for an activity taking place, for the existence of an entity, or for another agent's activity
    /// <see href="https://w3id.org/tido#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// A question that arrises during an investigation.
    /// <see href="https://w3id.org/tido#RQ"></see></summary>
    let RQ = _prefix "RQ"
    /// <summary>
    /// An investigation, or case, investigates one or more research questions
    /// <see href="https://w3id.org/tido#investigates"></see></summary>
    let investigates = _prefix "investigates"
    /// <summary>
    /// A matter weighed or taken into account when formulating an opinion or plan
    /// <see href="https://w3id.org/tido#Consideration"></see></summary>
    let Consideration = _prefix "Consideration"
    /// <summary>
    /// A step in the decision process where opinions, evaluations and analysis are expressed.
    /// <see href="https://w3id.org/tido#Evaluation"></see></summary>
    let Evaluation = _prefix "Evaluation"
    /// <summary>
    /// The term “piece of information” is used in this paper in its most general meaning covering other notions such as evidence, knowledge and/or data. A piece of information can be as simple as a measurement (on the scale of real numbers) but could be a fact (i.e., an observation, known to be true), an uncertain statement already modeled into a given mathematical formalism (i.e., a probability distribution), an unstructured statement in natural language
    /// <see href="https://w3id.org/tido#PieceOfInformation"></see></summary>
    let PieceOfInformation = _prefix "PieceOfInformation"
    /// <summary>
    /// The outlay or expenditure (as of effort or sacrifice) made to achieve an object
    /// <see href="https://w3id.org/tido#Cost"></see></summary>
    let Cost = _prefix "Cost"
    /// <summary>
    /// A piece of information that is either a testamony, an observation, or a sensory measurement.
    /// <see href="https://w3id.org/tido#Evidence"></see></summary>
    let Evidence = _prefix "Evidence"
    /// <summary>
    /// A possible interpretation of the availble information that forms the ground for further action. Other pieces of information could be used to either support or dispute a hypothesis.
    /// <see href="https://w3id.org/tido#Hypothesis"></see></summary>
    let Hypothesis = _prefix "Hypothesis"
    /// <summary>
    /// A clearly directed intent or purpose
    /// <see href="https://w3id.org/tido#Goal"></see></summary>
    let Goal = _prefix "Goal"
    /// <summary>
    /// Something that could be chosen. In the domain of Threat Intelligence, this could mean a course of action, but also an assesment of the situation or the answer to a research question.
    /// <see href="https://w3id.org/tido#Option"></see></summary>
    let Option = _prefix "Option"
    /// <summary>
    /// A step in the decision process where available information is shared, repeated, clarified or confirmed.
    /// <see href="https://w3id.org/tido#Orientation"></see></summary>
    let Orientation = _prefix "Orientation"
    /// <summary>
    /// A step in the decision process where a possible direction is chosen
    /// <see href="https://w3id.org/tido#Resolution"></see></summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    /// A piece of information can be used to answer a research question. This piece of information can be anything, as long as it can be expressed in a sentence
    /// <see href="https://w3id.org/tido#answers"></see></summary>
    let answers = _prefix "answers"
    /// <summary>
    /// A relationship indicating how an option would take an hypothesis as granted or true
    /// <see href="https://w3id.org/tido#assumes"></see></summary>
    let assumes = _prefix "assumes"
    /// <summary>
    /// A relationship indicating how a piece of information calls into question or casts doubt upon a hypothesis
    /// <see href="https://w3id.org/tido#disputes"></see></summary>
    let disputes = _prefix "disputes"
    /// <summary>
    /// The super-property of tido:supports and tido:disputes
    /// <see href="https://w3id.org/tido#providesInsightsInto"></see></summary>
    let providesInsightsInto = _prefix "providesInsightsInto"
    /// <summary>
    /// An option can have multiple considerations that help in deciding on whether on not to select that option
    /// <see href="https://w3id.org/tido#hasConsideration"></see></summary>
    let hasConsideration = _prefix "hasConsideration"
    /// <summary>
    /// A relationship indicating how one piece of information provides relevant context to another piece of information.
    /// <see href="https://w3id.org/tido#hasContext"></see></summary>
    let hasContext = _prefix "hasContext"
    /// <summary>
    /// A relationship that indicates which options would aid answering a research question.
    /// <see href="https://w3id.org/tido#informs"></see></summary>
    let informs = _prefix "informs"
    /// <summary>
    /// A research question can be raised by a piece of information
    /// <see href="https://w3id.org/tido#questions"></see></summary>
    let questions = _prefix "questions"
    /// <summary>
    /// A relationship indicating how a piece of information provides a hypothesis with substantiation/to support with evidence or authority, making it more certain
    /// <see href="https://w3id.org/tido#supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// Once an option is selected, it could be excecuted by an activity.
    /// <see href="https://w3id.org/tido#wasExecutedBy"></see></summary>
    let wasExecutedBy = _prefix "wasExecutedBy"
    /// <summary>
    /// During an orientation step, no new informatoin is generated but only pre-existing information is recalled
    /// <see href="https://w3id.org/tido#wasRecalledBy"></see></summary>
    let wasRecalledBy = _prefix "wasRecalledBy"
    /// <summary>
    /// An option can be selected during a resolution step. This selection of an option is what constitudes a decision.
    /// <see href="https://w3id.org/tido#wasSelectedBy"></see></summary>
    let wasSelectedBy = _prefix "wasSelectedBy"
