namespace http.purl.org.ipo.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ipo =
    let _namespace_iri = Namespace_Iri ipo |> NamespaceIRI
    /// <summary>
    ///   <para>ipo:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents an action to be performed. An Action can only be a primitive action (Task) or a set of actions (CompoundAction).
    /// An Action has a precondition that will enable the execution of the Action, and a postcondition (effect) which will be validated after running the Action.</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Action">http://purl.org/ipo/core#Action</seealso>
    let Action = Prefixed_Name(ipo, "Action") |> PrefixedName
    /// <summary>
    ///   <para>ipo:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates a name to identify something.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#name">http://purl.org/ipo/core#name</seealso>
    let name = Prefixed_Name(ipo, "name") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An artifact that illustrates or records a visual perception.
    ///
    /// It can be used to illustrate a IssueEntity seeking a better understanding of it.</para>
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Image">http://purl.org/ipo/core#Image</seealso>
    let Image = Prefixed_Name(ipo, "Image") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Symptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a sign or indication of one or more Issues. Something that is perceived when a problem occurs.
    /// </para>
    /// labels<para>Symptom</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Symptom">http://purl.org/ipo/core#Symptom</seealso>
    let Symptom = Prefixed_Name(ipo, "Symptom") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Party</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class representing a Person or an Organization, and it assumes a role of agent within the treated domain.</para>
    /// labels<para>Party</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Party">http://purl.org/ipo/core#Party</seealso>
    let Party = Prefixed_Name(ipo, "Party") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasOutcoming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the Transition that occurs after execution of this Step and that activates the next Step to be executed.</para>
    /// labels<para>hasOutcoming</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasOutcoming">http://purl.org/ipo/core#hasOutcoming</seealso>
    let hasOutcoming = Prefixed_Name(ipo, "hasOutcoming") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hostAssetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Asset with a Issue that occurs in it.
    /// This property can be used to relate a person with a disease whose the person is where the disease occurs.</para>
    /// labels<para>hostAssetOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hostAssetOf">http://purl.org/ipo/core#hostAssetOf</seealso>
    let hostAssetOf = Prefixed_Name(ipo, "hostAssetOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasDirectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a category (skos: Concept) directly related to a IssueEntity.</para>
    /// labels<para>hasDirectCategory</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasDirectCategory">http://purl.org/ipo/core#hasDirectCategory</seealso>
    let hasDirectCategory = Prefixed_Name(ipo, "hasDirectCategory") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasHostAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an Asset that is the host (harbourer) of the Issue.</para>
    /// labels<para>hasHostAsset</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasHostAsset">http://purl.org/ipo/core#hasHostAsset</seealso>
    let hasHostAsset = Prefixed_Name(ipo, "hasHostAsset") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasMaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a Person or Organization (Party) who created or registered the IssueEntity. This property is also used by Asset class to relate to its manufacturer, developer, inventor, etc.</para>
    /// labels<para>hasMaker</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasMaker">http://purl.org/ipo/core#hasMaker</seealso>
    let hasMaker = Prefixed_Name(ipo, "hasMaker") |> PrefixedName
    /// <summary>
    ///   <para>ipo:makerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property can be used to indicates an Asset created/manufactured by Party or a IssueEntity created/registered by the Party.</para>
    /// labels<para>makerOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#makerOf">http://purl.org/ipo/core#makerOf</seealso>
    let makerOf = Prefixed_Name(ipo, "makerOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of steps that perform an activity, but does not aim to solve a particular Issue.
    /// Can be used to group multiple steps that are repeated in various Procedures to facilitate reuse.</para>
    /// labels<para>Activity</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Activity">http://purl.org/ipo/core#Activity</seealso>
    let Activity = Prefixed_Name(ipo, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasPostCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates a postcondition (effect) will be reached after executing the Action.</para>
    /// labels<para>hasPostCondition</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasPostCondition">http://purl.org/ipo/core#hasPostCondition</seealso>
    let hasPostCondition = Prefixed_Name(ipo, "hasPostCondition") |> PrefixedName
    /// <summary>
    ///   <para>ipo:CompoundAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An action composed of several other actions. A CompoundAction may have the goal of solving one or more Issues, representing a Procedure or not having an explicit goal, just be a group of Actions to be reused, behaving as an Activity. A CompoundAction has one or more execution steps that activate one Action (Task or other CompoundAction), thus allowing, that a compoundAction reuse another.
    /// A CompoundAction can be used to create a workflow structure, aimed at better structuring of actions that compose it.</para>
    /// labels<para>CompoundAction</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#CompoundAction">http://purl.org/ipo/core#CompoundAction</seealso>
    let CompoundAction = Prefixed_Name(ipo, "CompoundAction") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any "thing" that a IssueEntity is related.
    /// For example, a problem (disease) diagnosed in a patient, can have a virus and the patient as Asset, since the virus is the causative agent of the problem and the patient is the host in which the problem manifests itself.
    /// An Asset can be a person, an object, a report, a document, etc.</para>
    /// labels<para>Asset</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Asset">http://purl.org/ipo/core#Asset</seealso>
    let Asset = Prefixed_Name(ipo, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>ipo:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Title (word or phrase) that briefly describes something.</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#title">http://purl.org/ipo/core#title</seealso>
    let title = Prefixed_Name(ipo, "title") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasFirstStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A CompoundAction has one or more steps, so this property indicates the first step should be executed.</para>
    /// labels<para>hasFirstStep</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasFirstStep">http://purl.org/ipo/core#hasFirstStep</seealso>
    let hasFirstStep = Prefixed_Name(ipo, "hasFirstStep") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sequence of steps which, after executed solve one or more Issues.
    /// A procedure has a number of steps that are executed in a specific sequence, one seeking to solve Issue.</para>
    /// labels<para>Procedure</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Procedure">http://purl.org/ipo/core#Procedure</seealso>
    let Procedure = Prefixed_Name(ipo, "Procedure") |> PrefixedName
    /// <summary>
    ///   <para>ipo:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Indicates text that describes something in detail.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#description">http://purl.org/ipo/core#description</seealso>
    let description = Prefixed_Name(ipo, "description") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One elementary and single action.
    /// Being an elementary task, it can not be decomposed into simpler actions.</para>
    /// labels<para>Task</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Task">http://purl.org/ipo/core#Task</seealso>
    let Task = Prefixed_Name(ipo, "Task") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a group of people organized aiming at a common goal: social, commercial or political.
    /// Can be used, for example, to represent a company that manufactures an Asset.</para>
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Organization">http://purl.org/ipo/core#Organization</seealso>
    let Organization = Prefixed_Name(ipo, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>ipo:solves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a Issue that this Procedure solves.</para>
    /// labels<para>solves</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#solves">http://purl.org/ipo/core#solves</seealso>
    let solves = Prefixed_Name(ipo, "solves") |> PrefixedName
    /// <summary>
    ///   <para>ipo:indicates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a Issue indicated by this Symptom.
    /// A Symptom may indicate many Issues, such as a Symptom of fever can indicate many diseases.</para>
    /// labels<para>indicates</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#indicates">http://purl.org/ipo/core#indicates</seealso>
    let indicates = Prefixed_Name(ipo, "indicates") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a Step that composes the compoundAction.</para>
    /// labels<para>hasStep</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasStep">http://purl.org/ipo/core#hasStep</seealso>
    let hasStep = Prefixed_Name(ipo, "hasStep") |> PrefixedName
    /// <summary>
    ///   <para>ipo:indicatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a Symptom of this Issue.</para>
    /// labels<para>indicatedBy</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#indicatedBy">http://purl.org/ipo/core#indicatedBy</seealso>
    let indicatedBy = Prefixed_Name(ipo, "indicatedBy") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates the Step of destination of this Transition.</para>
    /// labels<para>hasTarget</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasTarget">http://purl.org/ipo/core#hasTarget</seealso>
    let hasTarget = Prefixed_Name(ipo, "hasTarget") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasGuardCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates a BooleanExpression for that a Transition occurs.
    /// For example, a Transition can have as guardCondition that the Step of origin be executed 10 times. So while this Step does is not executes 10 times, will not be started the Step of destination. This example illustrates a repeating structure within the workflow.</para>
    /// labels<para>hasGuardCondition</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasGuardCondition">http://purl.org/ipo/core#hasGuardCondition</seealso>
    let hasGuardCondition = Prefixed_Name(ipo, "hasGuardCondition") |> PrefixedName
    /// <summary>
    ///   <para>ipo:activates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the action to be activated by a Step.</para>
    /// labels<para>activates</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#activates">http://purl.org/ipo/core#activates</seealso>
    let activates = Prefixed_Name(ipo, "activates") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates the Step of origin of this Transition.</para>
    /// labels<para>hasSource</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasSource">http://purl.org/ipo/core#hasSource</seealso>
    let hasSource = Prefixed_Name(ipo, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an Asset to IssueEntity, i.e., any "thing" which is related to IssueEntity.</para>
    /// labels<para>hasAsset</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasAsset">http://purl.org/ipo/core#hasAsset</seealso>
    let hasAsset = Prefixed_Name(ipo, "hasAsset") |> PrefixedName
    /// <summary>
    ///   <para>ipo:canBeCausedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Issue can be caused by another Issue directly or indirectly.
    /// This property is transitive, i.e., if the issue "A" can be caused by the issue "B" and the issue "B" can be caused by the issue "C", then the issue "A" can be caused by the issue "C".</para>
    /// labels<para>canBeCausedBy</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#canBeCausedBy">http://purl.org/ipo/core#canBeCausedBy</seealso>
    let canBeCausedBy = Prefixed_Name(ipo, "canBeCausedBy") |> PrefixedName
    /// <summary>
    ///   <para>ipo:canBeDependenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that an Issue can be a dependence of another Issue directly or indirectly.
    /// This property is also transitive, i.e., if the issue "A" can be dependence of the issue "B" and the issue "B" can be dependence of the issue "C", then the issue "A" can be dependence of the issue "C".</para>
    /// labels<para>canBeDependenceOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#canBeDependenceOf">http://purl.org/ipo/core#canBeDependenceOf</seealso>
    let canBeDependenceOf = Prefixed_Name(ipo, "canBeDependenceOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:assetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a IssueEntity that is related to the Asset.
    /// This property can be used to facilitate retrieval records of problems related to the Asset.</para>
    /// labels<para>assetOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#assetOf">http://purl.org/ipo/core#assetOf</seealso>
    let assetOf = Prefixed_Name(ipo, "assetOf") |> PrefixedName

    /// <summary>
    ///   <para>ipo:canBeDirectDependenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property indicates an Issue that can be direct dependence of another Issue.</para>
    /// labels<para>canBeDirectDependenceOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#canBeDirectDependenceOf">http://purl.org/ipo/core#canBeDirectDependenceOf</seealso>
    let canBeDirectDependenceOf =
        Prefixed_Name(ipo, "canBeDirectDependenceOf") |> PrefixedName

    /// <summary>
    ///   <para>ipo:canBeDirectlyCausedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Issue can be  directly caused by another Issue.</para>
    /// labels<para>canBeDirectlyCausedBy</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#canBeDirectlyCausedBy">http://purl.org/ipo/core#canBeDirectlyCausedBy</seealso>
    let canBeDirectlyCausedBy =
        Prefixed_Name(ipo, "canBeDirectlyCausedBy") |> PrefixedName

    /// <summary>
    ///   <para>ipo:canDependOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that an Issue can depend on another Issue directly or indirectly.
    /// This property can express a dependency relationship between Issues and has the characteristic of transitivity, i.e., the Issue "A" can depend on the Issue "B" and the Issue "B" can depend on "C", then the Issue "A" can depend on the Issue "C".</para>
    /// labels<para>canDependOn</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#canDependOn">http://purl.org/ipo/core#canDependOn</seealso>
    let canDependOn = Prefixed_Name(ipo, "canDependOn") |> PrefixedName
    /// <summary>
    ///   <para>ipo:canDirectlyDependOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an Issue can directly depend on another Issue.
    /// For example, pneumonia can directly depend that the flu is cured to finally be treated.</para>
    /// labels<para>canDirectlyDependOn</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#canDirectlyDependOn">http://purl.org/ipo/core#canDirectlyDependOn</seealso>
    let canDirectlyDependOn = Prefixed_Name(ipo, "canDirectlyDependOn") |> PrefixedName
    /// <summary>
    ///   <para>ipo:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that an Issue causes another Issue directly or indirectly.
    /// This property expresses a causal relationship between Issues and have the characteristic of transitivity, i.e., if the Issue "A" causes Issue "B" and the Issue "B" causes Issue "C", then the Issue "A" causes Issue "C".</para>
    /// labels<para>causes</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#causes">http://purl.org/ipo/core#causes</seealso>
    let causes = Prefixed_Name(ipo, "causes") |> PrefixedName
    /// <summary>
    ///   <para>ipo:canCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>An Issue can cause another Issue directly or indirectly.
    /// This property aims to express a possible causal relationship and has the characteristic of transitivity, i.e., the Issue "A" can cause the Issue "B" and the Issue "B" can cause the Issue "C", then the Issue "A" can cause the Issue "C".</para>
    /// labels<para>canCause</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#canCause">http://purl.org/ipo/core#canCause</seealso>
    let canCause = Prefixed_Name(ipo, "canCause") |> PrefixedName
    /// <summary>
    ///   <para>ipo:canDirectlyCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Issue can directly cause another Issue.
    /// This property aims to express a possible causal relationship, where an Issue can be direct cause of another Issue. For example, flu disease can cause pneumonia, i.e., in some cases, flu causes pneumonia and in another cases not.</para>
    /// labels<para>canDirectlyCause</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#canDirectlyCause">http://purl.org/ipo/core#canDirectlyCause</seealso>
    let canDirectlyCause = Prefixed_Name(ipo, "canDirectlyCause") |> PrefixedName
    /// <summary>
    ///   <para>ipo:categoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a IssueEntity classified in a skos:Concept.</para>
    /// labels<para>categoryOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#categoryOf">http://purl.org/ipo/core#categoryOf</seealso>
    let categoryOf = Prefixed_Name(ipo, "categoryOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:causativeAssetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a Asset with a Issue caused by this Asset. For example, a virus associated with a disease caused by it.</para>
    /// labels<para>causativeAssetOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#causativeAssetOf">http://purl.org/ipo/core#causativeAssetOf</seealso>
    let causativeAssetOf = Prefixed_Name(ipo, "causativeAssetOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a category (skos: Concept) directly or indirectly related to a IssueEntity.
    /// The Concept class of SKOS ontology has properties that allow you to create hierarchies of categories (Concepts), still allowing express transitivity between categories. This approach should be used as an alternative to classification by subclass of IssueEntity when it are not intrinsic classifications, just grouping. For example, in the field of medicine, disease can be grouped as viral diseases, bacterial diseases, etc.</para>
    /// labels<para>hasCategory</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasCategory">http://purl.org/ipo/core#hasCategory</seealso>
    let hasCategory = Prefixed_Name(ipo, "hasCategory") |> PrefixedName
    /// <summary>
    ///   <para>ipo:dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>This property indicates that an Issue depends on another Issue directly or indirectly.
    /// This property expresses a dependence relationship between Issues and has the characteristic of transitivity, i.e. , if Issue "A" depends on the Issue "B", and the Issue "B" depends on Issue "C", then the Issue "A" depends on Issue "C".</para>
    /// labels<para>dependsOn</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#dependsOn">http://purl.org/ipo/core#dependsOn</seealso>
    let dependsOn = Prefixed_Name(ipo, "dependsOn") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasDepiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an image that illustrates the IssueEntity.
    /// Seeking a better description of IssueEntity, one can make use of this property to relate an illustrative image. For example, an image of a software screen containing an error occurred can help describe the problem.</para>
    /// labels<para>hasDepiction</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasDepiction">http://purl.org/ipo/core#hasDepiction</seealso>
    let hasDepiction = Prefixed_Name(ipo, "hasDepiction") |> PrefixedName
    /// <summary>
    ///   <para>ipo:directCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a IssueEntity directly classified in a skos:Concept.</para>
    /// labels<para>directCategoryOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#directCategoryOf">http://purl.org/ipo/core#directCategoryOf</seealso>
    let directCategoryOf = Prefixed_Name(ipo, "directCategoryOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:directDependenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a Issue is direct dependence of another Issue.</para>
    /// labels<para>directDependenceOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#directDependenceOf">http://purl.org/ipo/core#directDependenceOf</seealso>
    let directDependenceOf = Prefixed_Name(ipo, "directDependenceOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:causedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that an Issue is caused by another Issue directly or indirectly.
    /// This property also has a transitive characteristic, i.e., if the Issue "A" is caused by Issue "B" and the Issue "B" is caused by Issue "C", then the Issue "A" is caused by Issue "C".</para>
    /// labels<para>causedBy</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#causedBy">http://purl.org/ipo/core#causedBy</seealso>
    let causedBy = Prefixed_Name(ipo, "causedBy") |> PrefixedName
    /// <summary>
    ///   <para>ipo:dependenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that an Issue is a dependence of another Issue directly or indirectly.
    /// This property also has a transitive characteristic, i.e. , if Issue "A" is dependence of the Issue "B", and the Issue "B" is dependence of Issue "C", then the Issue "A" is dependence of Issue "C".</para>
    /// labels<para>dependenceOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#dependenceOf">http://purl.org/ipo/core#dependenceOf</seealso>
    let dependenceOf = Prefixed_Name(ipo, "dependenceOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:depictionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a IssueEntity illustrated by the image.
    /// This property is functional, i.e., an Image is related by this property with only one IssueEntity.</para>
    /// labels<para>depictionOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#depictionOf">http://purl.org/ipo/core#depictionOf</seealso>
    let depictionOf = Prefixed_Name(ipo, "depictionOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:directlyCauses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property indicates that an Issue directly causes another Issue.</para>
    /// labels<para>directlyCauses</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#directlyCauses">http://purl.org/ipo/core#directlyCauses</seealso>
    let directlyCauses = Prefixed_Name(ipo, "directlyCauses") |> PrefixedName
    /// <summary>
    ///   <para>ipo:false</para>
    /// </summary>
    /// <remarks>
    ///   <para>ipo:BooleanExpression</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ipo/core#false">http://purl.org/ipo/core#false</seealso>
    let false_ = Prefixed_Name(ipo, "false") |> PrefixedName
    /// <summary>
    ///   <para>ipo:goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the description of the goal to be reached after the execution of Procedure.</para>
    /// labels<para>goal</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#goal">http://purl.org/ipo/core#goal</seealso>
    let goal = Prefixed_Name(ipo, "goal") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasCausativeAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an Asset that is the causer of the Issue.</para>
    /// labels<para>hasCausativeAsset</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasCausativeAsset">http://purl.org/ipo/core#hasCausativeAsset</seealso>
    let hasCausativeAsset = Prefixed_Name(ipo, "hasCausativeAsset") |> PrefixedName
    /// <summary>
    ///   <para>ipo:directlyCausedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an Issue is directly caused by another Issue.</para>
    /// labels<para>directlyCausedBy</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#directlyCausedBy">http://purl.org/ipo/core#directlyCausedBy</seealso>
    let directlyCausedBy = Prefixed_Name(ipo, "directlyCausedBy") |> PrefixedName
    /// <summary>
    ///   <para>ipo:directlyDependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relation indicates that a issue directly depends on another Issue.</para>
    /// labels<para>directlyDependsOn</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#directlyDependsOn">http://purl.org/ipo/core#directlyDependsOn</seealso>
    let directlyDependsOn = Prefixed_Name(ipo, "directlyDependsOn") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasIncoming</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Indicates the Transition that starts the execution of this Step.</para>
    /// labels<para>hasIncoming</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasIncoming">http://purl.org/ipo/core#hasIncoming</seealso>
    let hasIncoming = Prefixed_Name(ipo, "hasIncoming") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a Person who is a member of this Organization or another Organization that is member of this Organization, representing here a department or business unit.
    /// </para>
    /// labels<para>hasMember</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasMember">http://purl.org/ipo/core#hasMember</seealso>
    let hasMember = Prefixed_Name(ipo, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>ipo:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a organization that the Party is participant.
    /// This property can be used to indicates that an employee is a member of an organization.
    /// Another approach is to use this property to relate two organizations thus representing a department that is a member of his company.</para>
    /// labels<para>memberOf</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#memberOf">http://purl.org/ipo/core#memberOf</seealso>
    let memberOf = Prefixed_Name(ipo, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a person.
    /// Can be used, for example, to represent a person who works in an Organization, produces some Asset or records an IssueEntity.</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Person">http://purl.org/ipo/core#Person</seealso>
    let Person = Prefixed_Name(ipo, "Person") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A problem or issue to be resolved. For example, something that is not operating normally or a hindrance to performing some task.
    /// A Issue can be cause and/or caused, directly or indirectly, by another Issue, the same that the Issue A can depend on the Issue B, needing that the Issue B be solved before solving Issue A.
    /// The Issue can have a set of Actions (Procedures) that will fix it and also a Issue can be indicated by several Symptoms, where a set of Symptoms can identify a Issue.</para>
    /// labels<para>Issue</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Issue">http://purl.org/ipo/core#Issue</seealso>
    let Issue = Prefixed_Name(ipo, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>ipo:BooleanExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A logical expression whose value is true or false, aiming to validate a Transition between two Steps, or serve with a pre-condition for the execution of a Action or serve as a post-condition to validate the execution of an Action.
    /// This class has a description of the expression and two possible values: true or false. For these values, two instances are designed to be reused.</para>
    /// labels<para>BooleanExpression</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#BooleanExpression">http://purl.org/ipo/core#BooleanExpression</seealso>
    let BooleanExpression = Prefixed_Name(ipo, "BooleanExpression") |> PrefixedName
    /// <summary>
    ///   <para>ipo:IssueEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic class representing the three main concepts within the domain of ontology: Symptom, Problem and Action.</para>
    /// labels<para>IssueEntity</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#IssueEntity">http://purl.org/ipo/core#IssueEntity</seealso>
    let IssueEntity = Prefixed_Name(ipo, "IssueEntity") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A step to be performed within a CompoundAction. Every Step has an Action to be performed and a Transition to another Step to be performed after completing the execution of the Action.
    /// With Steps is possible to establish an order for the execution of Actions, as each Step has a Transition that sets the Step of origin and destination. Once a CompoundAction has an initial Step (IPO: hasFirstStep), from this Step can be run all other steps that composes the compoundAction following the Transition between them.</para>
    /// labels<para>Step</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Step">http://purl.org/ipo/core#Step</seealso>
    let Step = Prefixed_Name(ipo, "Step") |> PrefixedName
    /// <summary>
    ///   <para>ipo:Transition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Transition represents a transition (passage) between two Steps. Each Transition has a Step of origin (source) and a Step of destination (target). A Transition has a guard condition that specifies a boolean condition for that the Transition to occur.
    /// Through the guard condition, can be implemented, in a simplified way, a workflow, establishing decision structures, repetition, choice, etc.</para>
    /// labels<para>Transition</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#Transition">http://purl.org/ipo/core#Transition</seealso>
    let Transition = Prefixed_Name(ipo, "Transition") |> PrefixedName
    /// <summary>
    ///   <para>ipo:hasPreCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a precondition for the Action be executed.
    ///
    /// A precondition may represent a prerequisite for execution of the Action, without which it is not guaranteed correct execution.</para>
    /// labels<para>hasPreCondition</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#hasPreCondition">http://purl.org/ipo/core#hasPreCondition</seealso>
    let hasPreCondition = Prefixed_Name(ipo, "hasPreCondition") |> PrefixedName
    /// <summary>
    ///   <para>ipo:solvedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a solution (Procedure) for this Issue.</para>
    /// labels<para>solvedBy</para></remarks>
    /// <seealso href="http://purl.org/ipo/core#solvedBy">http://purl.org/ipo/core#solvedBy</seealso>
    let solvedBy = Prefixed_Name(ipo, "solvedBy") |> PrefixedName
    /// <summary>
    ///   <para>ipo:true</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ipo:BooleanExpression</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ipo/core#true">http://purl.org/ipo/core#true</seealso>
    let true_ = Prefixed_Name(ipo, "true") |> PrefixedName
