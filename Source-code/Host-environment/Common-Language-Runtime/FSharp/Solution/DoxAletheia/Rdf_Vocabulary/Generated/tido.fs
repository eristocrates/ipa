namespace https.w3id.org.tido.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tido =
    let _namespace_iri = Namespace_Iri tido |> NamespaceIRI
    /// <summary>
    ///   <para>tido:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The tido:Agent class is directly inherited from PROV-O. Here, an agent is defined as something that bears some form of responsibility for an activity taking place, for the existence of an entity, or for another agent's activity</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="https://w3id.org/tido#Agent">https://w3id.org/tido#Agent</seealso>
    let Agent = Prefixed_Name(tido, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>tido:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The tido:Activity class is directly inherited from PROV-O. Here, an activity is defined as something that occurs over a period of time and acts upon or with pieces of information; it may include consuming, processing, transforming, modifying, relocating, using, or generating pieces of information.</para>
    /// labels<para>Activity</para></remarks>
    /// <seealso href="https://w3id.org/tido#Activity">https://w3id.org/tido#Activity</seealso>
    let Activity = Prefixed_Name(tido, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>tido:Case</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of pieces of information that were recalled, inferred, deduced or produced during an investigation. </para>
    /// labels<para>Case</para></remarks>
    /// <seealso href="https://w3id.org/tido#Case">https://w3id.org/tido#Case</seealso>
    let Case = Prefixed_Name(tido, "Case") |> PrefixedName

    /// <summary>
    ///   <para>tido:providesInsightsInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The super-property of tido:supports and tido:disputes</para>
    /// labels<para>provides insights into</para></remarks>
    /// <seealso href="https://w3id.org/tido#providesInsightsInto">https://w3id.org/tido#providesInsightsInto</seealso>
    let providesInsightsInto =
        Prefixed_Name(tido, "providesInsightsInto") |> PrefixedName

    /// <summary>
    ///   <para>tido:informs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship that indicates which options would aid answering a research question. </para>
    /// labels<para>informs</para></remarks>
    /// <seealso href="https://w3id.org/tido#informs">https://w3id.org/tido#informs</seealso>
    let informs = Prefixed_Name(tido, "informs") |> PrefixedName
    /// <summary>
    ///   <para>tido:PieceOfInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The term “piece of information” is used in this paper in its most general meaning covering other notions such as evidence, knowledge and/or data. A piece of information can be as simple as a measurement (on the scale of real numbers) but could be a fact (i.e., an observation, known to be true), an uncertain statement already modeled into a given mathematical formalism (i.e., a probability distribution), an unstructured statement in natural language</para>
    /// labels<para>Piece Of Information</para></remarks>
    /// <seealso href="https://w3id.org/tido#PieceOfInformation">https://w3id.org/tido#PieceOfInformation</seealso>
    let PieceOfInformation = Prefixed_Name(tido, "PieceOfInformation") |> PrefixedName
    /// <summary>
    ///   <para>tido:Hypothesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A possible interpretation of the availble information that forms the ground for further action. Other pieces of information could be used to either support or dispute a hypothesis.</para>
    /// labels<para>Hypothesis</para></remarks>
    /// <seealso href="https://w3id.org/tido#Hypothesis">https://w3id.org/tido#Hypothesis</seealso>
    let Hypothesis = Prefixed_Name(tido, "Hypothesis") |> PrefixedName
    /// <summary>
    ///   <para>tido:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/tido#">https://w3id.org/tido#</seealso>
    let _prefix_iri = Prefixed_Name(tido, "") |> PrefixedName
    /// <summary>
    ///   <para>tido:contributesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Every activity should contribute to one or more cases/investigations. </para>
    /// labels<para>contributes to</para></remarks>
    /// <seealso href="https://w3id.org/tido#contributesTo">https://w3id.org/tido#contributesTo</seealso>
    let contributesTo = Prefixed_Name(tido, "contributesTo") |> PrefixedName
    /// <summary>
    ///   <para>tido:RQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A question that arrises during an investigation.</para>
    /// labels<para>R Q</para></remarks>
    /// <seealso href="https://w3id.org/tido#RQ">https://w3id.org/tido#RQ</seealso>
    let RQ = Prefixed_Name(tido, "RQ") |> PrefixedName
    /// <summary>
    ///   <para>tido:Consideration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A matter weighed or taken into account when formulating an opinion or plan</para>
    /// labels<para>Consideration</para></remarks>
    /// <seealso href="https://w3id.org/tido#Consideration">https://w3id.org/tido#Consideration</seealso>
    let Consideration = Prefixed_Name(tido, "Consideration") |> PrefixedName
    /// <summary>
    ///   <para>tido:Cost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The outlay or expenditure (as of effort or sacrifice) made to achieve an object</para>
    /// labels<para>Cost</para></remarks>
    /// <seealso href="https://w3id.org/tido#Cost">https://w3id.org/tido#Cost</seealso>
    let Cost = Prefixed_Name(tido, "Cost") |> PrefixedName
    /// <summary>
    ///   <para>tido:Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A piece of information that is either a testamony, an observation, or a sensory measurement.</para>
    /// labels<para>Evidence</para></remarks>
    /// <seealso href="https://w3id.org/tido#Evidence">https://w3id.org/tido#Evidence</seealso>
    let Evidence = Prefixed_Name(tido, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>tido:Goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A clearly directed intent or purpose</para>
    /// labels<para>Goal</para></remarks>
    /// <seealso href="https://w3id.org/tido#Goal">https://w3id.org/tido#Goal</seealso>
    let Goal = Prefixed_Name(tido, "Goal") |> PrefixedName
    /// <summary>
    ///   <para>tido:investigates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An investigation, or case, investigates one or more research questions</para>
    /// labels<para>investigates</para></remarks>
    /// <seealso href="https://w3id.org/tido#investigates">https://w3id.org/tido#investigates</seealso>
    let investigates = Prefixed_Name(tido, "investigates") |> PrefixedName
    /// <summary>
    ///   <para>tido:Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A step in the decision process where opinions, evaluations and analysis are expressed. </para>
    /// labels<para>Evaluation</para></remarks>
    /// <seealso href="https://w3id.org/tido#Evaluation">https://w3id.org/tido#Evaluation</seealso>
    let Evaluation = Prefixed_Name(tido, "Evaluation") |> PrefixedName
    /// <summary>
    ///   <para>tido:Orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A step in the decision process where available information is shared, repeated, clarified or confirmed.</para>
    /// labels<para>Orientation</para></remarks>
    /// <seealso href="https://w3id.org/tido#Orientation">https://w3id.org/tido#Orientation</seealso>
    let Orientation = Prefixed_Name(tido, "Orientation") |> PrefixedName
    /// <summary>
    ///   <para>tido:Option</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something that could be chosen. In the domain of Threat Intelligence, this could mean a course of action, but also an assesment of the situation or the answer to a research question.</para>
    /// labels<para>Option</para></remarks>
    /// <seealso href="https://w3id.org/tido#Option">https://w3id.org/tido#Option</seealso>
    let Option = Prefixed_Name(tido, "Option") |> PrefixedName
    /// <summary>
    ///   <para>tido:Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A step in the decision process where a possible direction is chosen</para>
    /// labels<para>Resolution</para></remarks>
    /// <seealso href="https://w3id.org/tido#Resolution">https://w3id.org/tido#Resolution</seealso>
    let Resolution = Prefixed_Name(tido, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>tido:answers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A piece of information can be used to answer a research question. This piece of information can be anything, as long as it can be expressed in a sentence</para>
    /// labels<para>answers</para></remarks>
    /// <seealso href="https://w3id.org/tido#answers">https://w3id.org/tido#answers</seealso>
    let answers = Prefixed_Name(tido, "answers") |> PrefixedName
    /// <summary>
    ///   <para>tido:assumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship indicating how an option would take an hypothesis as granted or true</para>
    /// labels<para>assumes</para></remarks>
    /// <seealso href="https://w3id.org/tido#assumes">https://w3id.org/tido#assumes</seealso>
    let assumes = Prefixed_Name(tido, "assumes") |> PrefixedName
    /// <summary>
    ///   <para>tido:disputes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship indicating how a piece of information calls into question or casts doubt upon a hypothesis</para>
    /// labels<para>disputes</para></remarks>
    /// <seealso href="https://w3id.org/tido#disputes">https://w3id.org/tido#disputes</seealso>
    let disputes = Prefixed_Name(tido, "disputes") |> PrefixedName
    /// <summary>
    ///   <para>tido:hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship indicating how one piece of information provides relevant context to another piece of information.</para>
    /// labels<para>has context</para></remarks>
    /// <seealso href="https://w3id.org/tido#hasContext">https://w3id.org/tido#hasContext</seealso>
    let hasContext = Prefixed_Name(tido, "hasContext") |> PrefixedName
    /// <summary>
    ///   <para>tido:hasConsideration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An option can have multiple considerations that help in deciding on whether on not to select that option</para>
    /// labels<para>has consideration</para></remarks>
    /// <seealso href="https://w3id.org/tido#hasConsideration">https://w3id.org/tido#hasConsideration</seealso>
    let hasConsideration = Prefixed_Name(tido, "hasConsideration") |> PrefixedName
    /// <summary>
    ///   <para>tido:questions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A research question can be raised by a piece of information</para>
    /// labels<para>questions</para></remarks>
    /// <seealso href="https://w3id.org/tido#questions">https://w3id.org/tido#questions</seealso>
    let questions = Prefixed_Name(tido, "questions") |> PrefixedName
    /// <summary>
    ///   <para>tido:wasExecutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Once an option is selected, it could be excecuted by an activity. </para>
    /// labels<para>was executed by</para></remarks>
    /// <seealso href="https://w3id.org/tido#wasExecutedBy">https://w3id.org/tido#wasExecutedBy</seealso>
    let wasExecutedBy = Prefixed_Name(tido, "wasExecutedBy") |> PrefixedName
    /// <summary>
    ///   <para>tido:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship indicating how a piece of information provides a hypothesis with substantiation/to support with evidence or authority, making it more certain</para>
    /// labels<para>supports</para></remarks>
    /// <seealso href="https://w3id.org/tido#supports">https://w3id.org/tido#supports</seealso>
    let supports = Prefixed_Name(tido, "supports") |> PrefixedName
    /// <summary>
    ///   <para>tido:wasRecalledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>During an orientation step, no new informatoin is generated but only pre-existing information is recalled</para>
    /// labels<para>was recalled by</para></remarks>
    /// <seealso href="https://w3id.org/tido#wasRecalledBy">https://w3id.org/tido#wasRecalledBy</seealso>
    let wasRecalledBy = Prefixed_Name(tido, "wasRecalledBy") |> PrefixedName
    /// <summary>
    ///   <para>tido:wasSelectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An option can be selected during a resolution step. This selection of an option is what constitudes a decision.</para>
    /// labels<para>was selected by</para></remarks>
    /// <seealso href="https://w3id.org/tido#wasSelectedBy">https://w3id.org/tido#wasSelectedBy</seealso>
    let wasSelectedBy = Prefixed_Name(tido, "wasSelectedBy") |> PrefixedName
