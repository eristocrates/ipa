#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ipo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ipo/core#" "ipo"
    /// <summary>
    ///   <para>rdfs:comment : Represents an action to be performed. An Action can only be a primitive action (Task) or a set of actions (CompoundAction).
    /// An Action has a precondition that will enable the execution of the Action, and a postcondition (effect) which will be validated after running the Action.</para>
    ///   <para>rdfs:label : Action</para>
    ///   <a href="http://purl.org/ipo/core#Action">ipo:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:comment : A set of steps that perform an activity, but does not aim to solve a particular Issue.
    /// Can be used to group multiple steps that are repeated in various Procedures to facilitate reuse.</para>
    ///   <para>rdfs:label : Activity</para>
    ///   <a href="http://purl.org/ipo/core#Activity">ipo:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:comment : Any "thing" that a IssueEntity is related.
    /// For example, a problem (disease) diagnosed in a patient, can have a virus and the patient as Asset, since the virus is the causative agent of the problem and the patient is the host in which the problem manifests itself.
    /// An Asset can be a person, an object, a report, a document, etc.</para>
    ///   <para>rdfs:label : Asset</para>
    ///   <a href="http://purl.org/ipo/core#Asset">ipo:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>rdfs:comment : A logical expression whose value is true or false, aiming to validate a Transition between two Steps, or serve with a pre-condition for the execution of a Action or serve as a post-condition to validate the execution of an Action.
    /// This class has a description of the expression and two possible values: true or false. For these values, two instances are designed to be reused.</para>
    ///   <para>rdfs:label : BooleanExpression</para>
    ///   <a href="http://purl.org/ipo/core#BooleanExpression">ipo:BooleanExpression</a>
    /// </summary>
    let BooleanExpression = _prefixId.prefix "BooleanExpression"
    /// <summary>
    ///   <para>rdfs:comment : An action composed of several other actions. A CompoundAction may have the goal of solving one or more Issues, representing a Procedure or not having an explicit goal, just be a group of Actions to be reused, behaving as an Activity. A CompoundAction has one or more execution steps that activate one Action (Task or other CompoundAction), thus allowing, that a compoundAction reuse another.
    /// A CompoundAction can be used to create a workflow structure, aimed at better structuring of actions that compose it.</para>
    ///   <para>rdfs:label : CompoundAction</para>
    ///   <a href="http://purl.org/ipo/core#CompoundAction">ipo:CompoundAction</a>
    /// </summary>
    let CompoundAction = _prefixId.prefix "CompoundAction"
    /// <summary>
    ///   <para>rdfs:comment : An artifact that illustrates or records a visual perception.
    ///
    /// It can be used to illustrate a IssueEntity seeking a better understanding of it.</para>
    ///   <para>rdfs:label : Image</para>
    ///   <a href="http://purl.org/ipo/core#Image">ipo:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:comment : A problem or issue to be resolved. For example, something that is not operating normally or a hindrance to performing some task.
    /// A Issue can be cause and/or caused, directly or indirectly, by another Issue, the same that the Issue A can depend on the Issue B, needing that the Issue B be solved before solving Issue A.
    /// The Issue can have a set of Actions (Procedures) that will fix it and also a Issue can be indicated by several Symptoms, where a set of Symptoms can identify a Issue.</para>
    ///   <para>rdfs:label : Issue</para>
    ///   <a href="http://purl.org/ipo/core#Issue">ipo:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    /// <summary>
    ///   <para>rdfs:comment : A generic class representing the three main concepts within the domain of ontology: Symptom, Problem and Action.</para>
    ///   <para>rdfs:label : IssueEntity</para>
    ///   <a href="http://purl.org/ipo/core#IssueEntity">ipo:IssueEntity</a>
    /// </summary>
    let IssueEntity = _prefixId.prefix "IssueEntity"
    /// <summary>
    ///   <para>rdfs:comment : Represents a group of people organized aiming at a common goal: social, commercial or political.
    /// Can be used, for example, to represent a company that manufactures an Asset.</para>
    ///   <para>rdfs:label : Organization</para>
    ///   <a href="http://purl.org/ipo/core#Organization">ipo:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:comment : A class representing a Person or an Organization, and it assumes a role of agent within the treated domain.</para>
    ///   <para>rdfs:label : Party</para>
    ///   <a href="http://purl.org/ipo/core#Party">ipo:Party</a>
    /// </summary>
    let Party = _prefixId.prefix "Party"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a person.
    /// Can be used, for example, to represent a person who works in an Organization, produces some Asset or records an IssueEntity.</para>
    ///   <para>rdfs:label : Person</para>
    ///   <a href="http://purl.org/ipo/core#Person">ipo:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:comment : A sequence of steps which, after executed solve one or more Issues.
    /// A procedure has a number of steps that are executed in a specific sequence, one seeking to solve Issue.</para>
    ///   <para>rdfs:label : Procedure</para>
    ///   <a href="http://purl.org/ipo/core#Procedure">ipo:Procedure</a>
    /// </summary>
    let Procedure = _prefixId.prefix "Procedure"
    /// <summary>
    ///   <para>rdfs:comment : A step to be performed within a CompoundAction. Every Step has an Action to be performed and a Transition to another Step to be performed after completing the execution of the Action.
    /// With Steps is possible to establish an order for the execution of Actions, as each Step has a Transition that sets the Step of origin and destination. Once a CompoundAction has an initial Step (IPO: hasFirstStep), from this Step can be run all other steps that composes the compoundAction following the Transition between them.</para>
    ///   <para>rdfs:label : Step</para>
    ///   <a href="http://purl.org/ipo/core#Step">ipo:Step</a>
    /// </summary>
    let Step = _prefixId.prefix "Step"
    /// <summary>
    ///   <para>rdfs:comment : Represents a sign or indication of one or more Issues. Something that is perceived when a problem occurs.
    /// </para>
    ///   <para>rdfs:label : Symptom</para>
    ///   <a href="http://purl.org/ipo/core#Symptom">ipo:Symptom</a>
    /// </summary>
    let Symptom = _prefixId.prefix "Symptom"
    /// <summary>
    ///   <para>rdfs:comment : One elementary and single action.
    /// Being an elementary task, it can not be decomposed into simpler actions.</para>
    ///   <para>rdfs:label : Task</para>
    ///   <a href="http://purl.org/ipo/core#Task">ipo:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:comment : An Transition represents a transition (passage) between two Steps. Each Transition has a Step of origin (source) and a Step of destination (target). A Transition has a guard condition that specifies a boolean condition for that the Transition to occur.
    /// Through the guard condition, can be implemented, in a simplified way, a workflow, establishing decision structures, repetition, choice, etc.</para>
    ///   <para>rdfs:label : Transition</para>
    ///   <a href="http://purl.org/ipo/core#Transition">ipo:Transition</a>
    /// </summary>
    let Transition = _prefixId.prefix "Transition"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the action to be activated by a Step.</para>
    ///   <para>rdfs:label : activates</para>
    ///   <a href="http://purl.org/ipo/core#activates">ipo:activates</a>
    /// </summary>
    let activates = _prefixId.prefix "activates"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a IssueEntity that is related to the Asset.
    /// This property can be used to facilitate retrieval records of problems related to the Asset.</para>
    ///   <para>rdfs:label : assetOf</para>
    ///   <a href="http://purl.org/ipo/core#assetOf">ipo:assetOf</a>
    /// </summary>
    let assetOf = _prefixId.prefix "assetOf"
    /// <summary>
    ///   <para>rdfs:comment : The Issue can be caused by another Issue directly or indirectly.
    /// This property is transitive, i.e., if the issue "A" can be caused by the issue "B" and the issue "B" can be caused by the issue "C", then the issue "A" can be caused by the issue "C".</para>
    ///   <para>rdfs:label : canBeCausedBy</para>
    ///   <a href="http://purl.org/ipo/core#canBeCausedBy">ipo:canBeCausedBy</a>
    /// </summary>
    let canBeCausedBy = _prefixId.prefix "canBeCausedBy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an Issue can be a dependence of another Issue directly or indirectly.
    /// This property is also transitive, i.e., if the issue "A" can be dependence of the issue "B" and the issue "B" can be dependence of the issue "C", then the issue "A" can be dependence of the issue "C".</para>
    ///   <para>rdfs:label : canBeDependenceOf</para>
    ///   <a href="http://purl.org/ipo/core#canBeDependenceOf">ipo:canBeDependenceOf</a>
    /// </summary>
    let canBeDependenceOf = _prefixId.prefix "canBeDependenceOf"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates an Issue that can be direct dependence of another Issue.</para>
    ///   <para>rdfs:label : canBeDirectDependenceOf</para>
    ///   <a href="http://purl.org/ipo/core#canBeDirectDependenceOf">ipo:canBeDirectDependenceOf</a>
    /// </summary>
    let canBeDirectDependenceOf = _prefixId.prefix "canBeDirectDependenceOf"
    /// <summary>
    ///   <para>rdfs:comment : An Issue can be  directly caused by another Issue.</para>
    ///   <para>rdfs:label : canBeDirectlyCausedBy</para>
    ///   <a href="http://purl.org/ipo/core#canBeDirectlyCausedBy">ipo:canBeDirectlyCausedBy</a>
    /// </summary>
    let canBeDirectlyCausedBy = _prefixId.prefix "canBeDirectlyCausedBy"
    /// <summary>
    ///   <para>rdfs:comment : An Issue can cause another Issue directly or indirectly.
    /// This property aims to express a possible causal relationship and has the characteristic of transitivity, i.e., the Issue "A" can cause the Issue "B" and the Issue "B" can cause the Issue "C", then the Issue "A" can cause the Issue "C".</para>
    ///   <para>rdfs:label : canCause</para>
    ///   <a href="http://purl.org/ipo/core#canCause">ipo:canCause</a>
    /// </summary>
    let canCause = _prefixId.prefix "canCause"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an Issue can depend on another Issue directly or indirectly.
    /// This property can express a dependency relationship between Issues and has the characteristic of transitivity, i.e., the Issue "A" can depend on the Issue "B" and the Issue "B" can depend on "C", then the Issue "A" can depend on the Issue "C".</para>
    ///   <para>rdfs:label : canDependOn</para>
    ///   <a href="http://purl.org/ipo/core#canDependOn">ipo:canDependOn</a>
    /// </summary>
    let canDependOn = _prefixId.prefix "canDependOn"
    /// <summary>
    ///   <para>rdfs:comment : An Issue can directly cause another Issue.
    /// This property aims to express a possible causal relationship, where an Issue can be direct cause of another Issue. For example, flu disease can cause pneumonia, i.e., in some cases, flu causes pneumonia and in another cases not.</para>
    ///   <para>rdfs:label : canDirectlyCause</para>
    ///   <a href="http://purl.org/ipo/core#canDirectlyCause">ipo:canDirectlyCause</a>
    /// </summary>
    let canDirectlyCause = _prefixId.prefix "canDirectlyCause"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an Issue can directly depend on another Issue.
    /// For example, pneumonia can directly depend that the flu is cured to finally be treated.</para>
    ///   <para>rdfs:label : canDirectlyDependOn</para>
    ///   <a href="http://purl.org/ipo/core#canDirectlyDependOn">ipo:canDirectlyDependOn</a>
    /// </summary>
    let canDirectlyDependOn = _prefixId.prefix "canDirectlyDependOn"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a IssueEntity classified in a skos:Concept.</para>
    ///   <para>rdfs:label : categoryOf</para>
    ///   <a href="http://purl.org/ipo/core#categoryOf">ipo:categoryOf</a>
    /// </summary>
    let categoryOf = _prefixId.prefix "categoryOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a Asset with a Issue caused by this Asset. For example, a virus associated with a disease caused by it.</para>
    ///   <para>rdfs:label : causativeAssetOf</para>
    ///   <a href="http://purl.org/ipo/core#causativeAssetOf">ipo:causativeAssetOf</a>
    /// </summary>
    let causativeAssetOf = _prefixId.prefix "causativeAssetOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an Issue is caused by another Issue directly or indirectly.
    /// This property also has a transitive characteristic, i.e., if the Issue "A" is caused by Issue "B" and the Issue "B" is caused by Issue "C", then the Issue "A" is caused by Issue "C".</para>
    ///   <para>rdfs:label : causedBy</para>
    ///   <a href="http://purl.org/ipo/core#causedBy">ipo:causedBy</a>
    /// </summary>
    let causedBy = _prefixId.prefix "causedBy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an Issue causes another Issue directly or indirectly.
    /// This property expresses a causal relationship between Issues and have the characteristic of transitivity, i.e., if the Issue "A" causes Issue "B" and the Issue "B" causes Issue "C", then the Issue "A" causes Issue "C".</para>
    ///   <para>rdfs:label : causes</para>
    ///   <a href="http://purl.org/ipo/core#causes">ipo:causes</a>
    /// </summary>
    let causes = _prefixId.prefix "causes"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an Issue is a dependence of another Issue directly or indirectly.
    /// This property also has a transitive characteristic, i.e. , if Issue "A" is dependence of the Issue "B", and the Issue "B" is dependence of Issue "C", then the Issue "A" is dependence of Issue "C".</para>
    ///   <para>rdfs:label : dependenceOf</para>
    ///   <a href="http://purl.org/ipo/core#dependenceOf">ipo:dependenceOf</a>
    /// </summary>
    let dependenceOf = _prefixId.prefix "dependenceOf"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that an Issue depends on another Issue directly or indirectly.
    /// This property expresses a dependence relationship between Issues and has the characteristic of transitivity, i.e. , if Issue "A" depends on the Issue "B", and the Issue "B" depends on Issue "C", then the Issue "A" depends on Issue "C".</para>
    ///   <para>rdfs:label : dependsOn</para>
    ///   <a href="http://purl.org/ipo/core#dependsOn">ipo:dependsOn</a>
    /// </summary>
    let dependsOn = _prefixId.prefix "dependsOn"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a IssueEntity illustrated by the image.
    /// This property is functional, i.e., an Image is related by this property with only one IssueEntity.</para>
    ///   <para>rdfs:label : depictionOf</para>
    ///   <a href="http://purl.org/ipo/core#depictionOf">ipo:depictionOf</a>
    /// </summary>
    let depictionOf = _prefixId.prefix "depictionOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates text that describes something in detail.</para>
    ///   <para>rdfs:label : description</para>
    ///   <a href="http://purl.org/ipo/core#description">ipo:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a IssueEntity directly classified in a skos:Concept.</para>
    ///   <para>rdfs:label : directCategoryOf</para>
    ///   <a href="http://purl.org/ipo/core#directCategoryOf">ipo:directCategoryOf</a>
    /// </summary>
    let directCategoryOf = _prefixId.prefix "directCategoryOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a Issue is direct dependence of another Issue.</para>
    ///   <para>rdfs:label : directDependenceOf</para>
    ///   <a href="http://purl.org/ipo/core#directDependenceOf">ipo:directDependenceOf</a>
    /// </summary>
    let directDependenceOf = _prefixId.prefix "directDependenceOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that an Issue is directly caused by another Issue.</para>
    ///   <para>rdfs:label : directlyCausedBy</para>
    ///   <a href="http://purl.org/ipo/core#directlyCausedBy">ipo:directlyCausedBy</a>
    /// </summary>
    let directlyCausedBy = _prefixId.prefix "directlyCausedBy"
    /// <summary>
    ///   <para>rdfs:comment : This property indicates that an Issue directly causes another Issue.</para>
    ///   <para>rdfs:label : directlyCauses</para>
    ///   <a href="http://purl.org/ipo/core#directlyCauses">ipo:directlyCauses</a>
    /// </summary>
    let directlyCauses = _prefixId.prefix "directlyCauses"
    /// <summary>
    ///   <para>rdfs:comment : This relation indicates that a issue directly depends on another Issue.</para>
    ///   <para>rdfs:label : directlyDependsOn</para>
    ///   <a href="http://purl.org/ipo/core#directlyDependsOn">ipo:directlyDependsOn</a>
    /// </summary>
    let directlyDependsOn = _prefixId.prefix "directlyDependsOn"
    let false_ = _prefixId.prefix "false"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the description of the goal to be reached after the execution of Procedure.</para>
    ///   <para>rdfs:label : goal</para>
    ///   <a href="http://purl.org/ipo/core#goal">ipo:goal</a>
    /// </summary>
    let goal = _prefixId.prefix "goal"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an Asset to IssueEntity, i.e., any "thing" which is related to IssueEntity.</para>
    ///   <para>rdfs:label : hasAsset</para>
    ///   <a href="http://purl.org/ipo/core#hasAsset">ipo:hasAsset</a>
    /// </summary>
    let hasAsset = _prefixId.prefix "hasAsset"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a category (skos: Concept) directly or indirectly related to a IssueEntity.
    /// The Concept class of SKOS ontology has properties that allow you to create hierarchies of categories (Concepts), still allowing express transitivity between categories. This approach should be used as an alternative to classification by subclass of IssueEntity when it are not intrinsic classifications, just grouping. For example, in the field of medicine, disease can be grouped as viral diseases, bacterial diseases, etc.</para>
    ///   <para>rdfs:label : hasCategory</para>
    ///   <a href="http://purl.org/ipo/core#hasCategory">ipo:hasCategory</a>
    /// </summary>
    let hasCategory = _prefixId.prefix "hasCategory"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an Asset that is the causer of the Issue.</para>
    ///   <para>rdfs:label : hasCausativeAsset</para>
    ///   <a href="http://purl.org/ipo/core#hasCausativeAsset">ipo:hasCausativeAsset</a>
    /// </summary>
    let hasCausativeAsset = _prefixId.prefix "hasCausativeAsset"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an image that illustrates the IssueEntity.
    /// Seeking a better description of IssueEntity, one can make use of this property to relate an illustrative image. For example, an image of a software screen containing an error occurred can help describe the problem.</para>
    ///   <para>rdfs:label : hasDepiction</para>
    ///   <a href="http://purl.org/ipo/core#hasDepiction">ipo:hasDepiction</a>
    /// </summary>
    let hasDepiction = _prefixId.prefix "hasDepiction"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a category (skos: Concept) directly related to a IssueEntity.</para>
    ///   <para>rdfs:label : hasDirectCategory</para>
    ///   <a href="http://purl.org/ipo/core#hasDirectCategory">ipo:hasDirectCategory</a>
    /// </summary>
    let hasDirectCategory = _prefixId.prefix "hasDirectCategory"
    /// <summary>
    ///   <para>rdfs:comment : A CompoundAction has one or more steps, so this property indicates the first step should be executed.</para>
    ///   <para>rdfs:label : hasFirstStep</para>
    ///   <a href="http://purl.org/ipo/core#hasFirstStep">ipo:hasFirstStep</a>
    /// </summary>
    let hasFirstStep = _prefixId.prefix "hasFirstStep"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a BooleanExpression for that a Transition occurs.
    /// For example, a Transition can have as guardCondition that the Step of origin be executed 10 times. So while this Step does is not executes 10 times, will not be started the Step of destination. This example illustrates a repeating structure within the workflow.</para>
    ///   <para>rdfs:label : hasGuardCondition</para>
    ///   <a href="http://purl.org/ipo/core#hasGuardCondition">ipo:hasGuardCondition</a>
    /// </summary>
    let hasGuardCondition = _prefixId.prefix "hasGuardCondition"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an Asset that is the host (harbourer) of the Issue.</para>
    ///   <para>rdfs:label : hasHostAsset</para>
    ///   <a href="http://purl.org/ipo/core#hasHostAsset">ipo:hasHostAsset</a>
    /// </summary>
    let hasHostAsset = _prefixId.prefix "hasHostAsset"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Transition that starts the execution of this Step.</para>
    ///   <para>rdfs:label : hasIncoming</para>
    ///   <a href="http://purl.org/ipo/core#hasIncoming">ipo:hasIncoming</a>
    /// </summary>
    let hasIncoming = _prefixId.prefix "hasIncoming"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a Person or Organization (Party) who created or registered the IssueEntity. This property is also used by Asset class to relate to its manufacturer, developer, inventor, etc.</para>
    ///   <para>rdfs:label : hasMaker</para>
    ///   <a href="http://purl.org/ipo/core#hasMaker">ipo:hasMaker</a>
    /// </summary>
    let hasMaker = _prefixId.prefix "hasMaker"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a Person who is a member of this Organization or another Organization that is member of this Organization, representing here a department or business unit.
    /// </para>
    ///   <para>rdfs:label : hasMember</para>
    ///   <a href="http://purl.org/ipo/core#hasMember">ipo:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Transition that occurs after execution of this Step and that activates the next Step to be executed.</para>
    ///   <para>rdfs:label : hasOutcoming</para>
    ///   <a href="http://purl.org/ipo/core#hasOutcoming">ipo:hasOutcoming</a>
    /// </summary>
    let hasOutcoming = _prefixId.prefix "hasOutcoming"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a postcondition (effect) will be reached after executing the Action.</para>
    ///   <para>rdfs:label : hasPostCondition</para>
    ///   <a href="http://purl.org/ipo/core#hasPostCondition">ipo:hasPostCondition</a>
    /// </summary>
    let hasPostCondition = _prefixId.prefix "hasPostCondition"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a precondition for the Action be executed.
    ///
    /// A precondition may represent a prerequisite for execution of the Action, without which it is not guaranteed correct execution.</para>
    ///   <para>rdfs:label : hasPreCondition</para>
    ///   <a href="http://purl.org/ipo/core#hasPreCondition">ipo:hasPreCondition</a>
    /// </summary>
    let hasPreCondition = _prefixId.prefix "hasPreCondition"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Step of origin of this Transition.</para>
    ///   <para>rdfs:label : hasSource</para>
    ///   <a href="http://purl.org/ipo/core#hasSource">ipo:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a Step that composes the compoundAction.</para>
    ///   <para>rdfs:label : hasStep</para>
    ///   <a href="http://purl.org/ipo/core#hasStep">ipo:hasStep</a>
    /// </summary>
    let hasStep = _prefixId.prefix "hasStep"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the Step of destination of this Transition.</para>
    ///   <para>rdfs:label : hasTarget</para>
    ///   <a href="http://purl.org/ipo/core#hasTarget">ipo:hasTarget</a>
    /// </summary>
    let hasTarget = _prefixId.prefix "hasTarget"
    /// <summary>
    ///   <para>rdfs:comment : Relates an Asset with a Issue that occurs in it.
    /// This property can be used to relate a person with a disease whose the person is where the disease occurs.</para>
    ///   <para>rdfs:label : hostAssetOf</para>
    ///   <a href="http://purl.org/ipo/core#hostAssetOf">ipo:hostAssetOf</a>
    /// </summary>
    let hostAssetOf = _prefixId.prefix "hostAssetOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a Symptom of this Issue.</para>
    ///   <para>rdfs:label : indicatedBy</para>
    ///   <a href="http://purl.org/ipo/core#indicatedBy">ipo:indicatedBy</a>
    /// </summary>
    let indicatedBy = _prefixId.prefix "indicatedBy"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a Issue indicated by this Symptom.
    /// A Symptom may indicate many Issues, such as a Symptom of fever can indicate many diseases.</para>
    ///   <para>rdfs:label : indicates</para>
    ///   <a href="http://purl.org/ipo/core#indicates">ipo:indicates</a>
    /// </summary>
    let indicates = _prefixId.prefix "indicates"
    /// <summary>
    ///   <para>rdfs:comment : This property can be used to indicates an Asset created/manufactured by Party or a IssueEntity created/registered by the Party.</para>
    ///   <para>rdfs:label : makerOf</para>
    ///   <a href="http://purl.org/ipo/core#makerOf">ipo:makerOf</a>
    /// </summary>
    let makerOf = _prefixId.prefix "makerOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a organization that the Party is participant.
    /// This property can be used to indicates that an employee is a member of an organization.
    /// Another approach is to use this property to relate two organizations thus representing a department that is a member of his company.</para>
    ///   <para>rdfs:label : memberOf</para>
    ///   <a href="http://purl.org/ipo/core#memberOf">ipo:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a name to identify something.</para>
    ///   <para>rdfs:label : name</para>
    ///   <a href="http://purl.org/ipo/core#name">ipo:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a solution (Procedure) for this Issue.</para>
    ///   <para>rdfs:label : solvedBy</para>
    ///   <a href="http://purl.org/ipo/core#solvedBy">ipo:solvedBy</a>
    /// </summary>
    let solvedBy = _prefixId.prefix "solvedBy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a Issue that this Procedure solves.</para>
    ///   <para>rdfs:label : solves</para>
    ///   <a href="http://purl.org/ipo/core#solves">ipo:solves</a>
    /// </summary>
    let solves = _prefixId.prefix "solves"
    /// <summary>
    ///   <para>rdfs:comment : Title (word or phrase) that briefly describes something.</para>
    ///   <para>rdfs:label : title</para>
    ///   <a href="http://purl.org/ipo/core#title">ipo:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    let true_ = _prefixId.prefix "true"
