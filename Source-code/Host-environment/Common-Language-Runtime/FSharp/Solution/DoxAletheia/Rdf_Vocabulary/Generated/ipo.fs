namespace http.purl.org.ipo.core.hash

open DoxAletheia

module ipo =
    let _namespace_name = "http://purl.org/ipo/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents a person.
    /// Can be used, for example, to represent a person who works in an Organization, produces some Asset or records an IssueEntity.
    /// <see href="http://purl.org/ipo/core#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Represents an action to be performed. An Action can only be a primitive action (Task) or a set of actions (CompoundAction).
    /// An Action has a precondition that will enable the execution of the Action, and a postcondition (effect) which will be validated after running the Action.
    /// <see href="http://purl.org/ipo/core#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// A problem or issue to be resolved. For example, something that is not operating normally or a hindrance to performing some task.
    /// A Issue can be cause and/or caused, directly or indirectly, by another Issue, the same that the Issue A can depend on the Issue B, needing that the Issue B be solved before solving Issue A.
    /// The Issue can have a set of Actions (Procedures) that will fix it and also a Issue can be indicated by several Symptoms, where a set of Symptoms can identify a Issue.
    /// <see href="http://purl.org/ipo/core#Issue"></see></summary>
    let Issue = _prefix "Issue"
    /// <summary>
    /// Represents a sign or indication of one or more Issues. Something that is perceived when a problem occurs.
    ///
    /// <see href="http://purl.org/ipo/core#Symptom"></see></summary>
    let Symptom = _prefix "Symptom"
    /// <summary>
    /// Indicates a name to identify something.
    /// <see href="http://purl.org/ipo/core#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// A logical expression whose value is true or false, aiming to validate a Transition between two Steps, or serve with a pre-condition for the execution of a Action or serve as a post-condition to validate the execution of an Action.
    /// This class has a description of the expression and two possible values: true or false. For these values, two instances are designed to be reused.
    /// <see href="http://purl.org/ipo/core#BooleanExpression"></see></summary>
    let BooleanExpression = _prefix "BooleanExpression"
    /// <summary>
    /// An artifact that illustrates or records a visual perception.
    ///
    /// It can be used to illustrate a IssueEntity seeking a better understanding of it.
    /// <see href="http://purl.org/ipo/core#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// A generic class representing the three main concepts within the domain of ontology: Symptom, Problem and Action.
    /// <see href="http://purl.org/ipo/core#IssueEntity"></see></summary>
    let IssueEntity = _prefix "IssueEntity"
    /// <summary>
    /// A class representing a Person or an Organization, and it assumes a role of agent within the treated domain.
    /// <see href="http://purl.org/ipo/core#Party"></see></summary>
    let Party = _prefix "Party"
    /// <summary>
    /// A step to be performed within a CompoundAction. Every Step has an Action to be performed and a Transition to another Step to be performed after completing the execution of the Action.
    /// With Steps is possible to establish an order for the execution of Actions, as each Step has a Transition that sets the Step of origin and destination. Once a CompoundAction has an initial Step (IPO: hasFirstStep), from this Step can be run all other steps that composes the compoundAction following the Transition between them.
    /// <see href="http://purl.org/ipo/core#Step"></see></summary>
    let Step = _prefix "Step"
    /// <summary>
    /// An Transition represents a transition (passage) between two Steps. Each Transition has a Step of origin (source) and a Step of destination (target). A Transition has a guard condition that specifies a boolean condition for that the Transition to occur.
    /// Through the guard condition, can be implemented, in a simplified way, a workflow, establishing decision structures, repetition, choice, etc.
    /// <see href="http://purl.org/ipo/core#Transition"></see></summary>
    let Transition = _prefix "Transition"
    /// <summary>
    /// Indicates a precondition for the Action be executed.
    ///
    /// A precondition may represent a prerequisite for execution of the Action, without which it is not guaranteed correct execution.
    /// <see href="http://purl.org/ipo/core#hasPreCondition"></see></summary>
    let hasPreCondition = _prefix "hasPreCondition"
    /// <summary>
    /// Indicates a postcondition (effect) will be reached after executing the Action.
    /// <see href="http://purl.org/ipo/core#hasPostCondition"></see></summary>
    let hasPostCondition = _prefix "hasPostCondition"
    /// <summary>
    /// A set of steps that perform an activity, but does not aim to solve a particular Issue.
    /// Can be used to group multiple steps that are repeated in various Procedures to facilitate reuse.
    /// <see href="http://purl.org/ipo/core#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// An action composed of several other actions. A CompoundAction may have the goal of solving one or more Issues, representing a Procedure or not having an explicit goal, just be a group of Actions to be reused, behaving as an Activity. A CompoundAction has one or more execution steps that activate one Action (Task or other CompoundAction), thus allowing, that a compoundAction reuse another.
    /// A CompoundAction can be used to create a workflow structure, aimed at better structuring of actions that compose it.
    /// <see href="http://purl.org/ipo/core#CompoundAction"></see></summary>
    let CompoundAction = _prefix "CompoundAction"
    /// <summary>
    /// A sequence of steps which, after executed solve one or more Issues.
    /// A procedure has a number of steps that are executed in a specific sequence, one seeking to solve Issue.
    /// <see href="http://purl.org/ipo/core#Procedure"></see></summary>
    let Procedure = _prefix "Procedure"
    /// <summary>
    /// Any "thing" that a IssueEntity is related.
    /// For example, a problem (disease) diagnosed in a patient, can have a virus and the patient as Asset, since the virus is the causative agent of the problem and the patient is the host in which the problem manifests itself.
    /// An Asset can be a person, an object, a report, a document, etc.
    /// <see href="http://purl.org/ipo/core#Asset"></see></summary>
    let Asset = _prefix "Asset"
    /// <summary>
    /// Title (word or phrase) that briefly describes something.
    /// <see href="http://purl.org/ipo/core#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Indicates text that describes something in detail.
    /// <see href="http://purl.org/ipo/core#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// A CompoundAction has one or more steps, so this property indicates the first step should be executed.
    /// <see href="http://purl.org/ipo/core#hasFirstStep"></see></summary>
    let hasFirstStep = _prefix "hasFirstStep"
    /// <summary>
    /// Indicates a Step that composes the compoundAction.
    /// <see href="http://purl.org/ipo/core#hasStep"></see></summary>
    let hasStep = _prefix "hasStep"
    /// <summary>
    /// One elementary and single action.
    /// Being an elementary task, it can not be decomposed into simpler actions.
    /// <see href="http://purl.org/ipo/core#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// Indicates a Symptom of this Issue.
    /// <see href="http://purl.org/ipo/core#indicatedBy"></see></summary>
    let indicatedBy = _prefix "indicatedBy"
    /// <summary>
    /// Represents a group of people organized aiming at a common goal: social, commercial or political.
    /// Can be used, for example, to represent a company that manufactures an Asset.
    /// <see href="http://purl.org/ipo/core#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// Indicates a Issue that this Procedure solves.
    /// <see href="http://purl.org/ipo/core#solves"></see></summary>
    let solves = _prefix "solves"
    /// <summary>
    /// This property relates a Issue indicated by this Symptom.
    /// A Symptom may indicate many Issues, such as a Symptom of fever can indicate many diseases.
    /// <see href="http://purl.org/ipo/core#indicates"></see></summary>
    let indicates = _prefix "indicates"
    /// <summary>
    /// Indicates the Step of destination of this Transition.
    /// <see href="http://purl.org/ipo/core#hasTarget"></see></summary>
    let hasTarget = _prefix "hasTarget"
    /// <summary>
    /// Indicates the Step of origin of this Transition.
    /// <see href="http://purl.org/ipo/core#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// Indicates a BooleanExpression for that a Transition occurs.
    /// For example, a Transition can have as guardCondition that the Step of origin be executed 10 times. So while this Step does is not executes 10 times, will not be started the Step of destination. This example illustrates a repeating structure within the workflow.
    /// <see href="http://purl.org/ipo/core#hasGuardCondition"></see></summary>
    let hasGuardCondition = _prefix "hasGuardCondition"
    /// <summary>
    /// Indicates the action to be activated by a Step.
    /// <see href="http://purl.org/ipo/core#activates"></see></summary>
    let activates = _prefix "activates"
    /// <summary>
    /// Indicates a IssueEntity that is related to the Asset.
    /// This property can be used to facilitate retrieval records of problems related to the Asset.
    /// <see href="http://purl.org/ipo/core#assetOf"></see></summary>
    let assetOf = _prefix "assetOf"
    /// <summary>
    /// Indicates an Asset to IssueEntity, i.e., any "thing" which is related to IssueEntity.
    /// <see href="http://purl.org/ipo/core#hasAsset"></see></summary>
    let hasAsset = _prefix "hasAsset"
    /// <summary>
    /// The Issue can be caused by another Issue directly or indirectly.
    /// This property is transitive, i.e., if the issue "A" can be caused by the issue "B" and the issue "B" can be caused by the issue "C", then the issue "A" can be caused by the issue "C".
    /// <see href="http://purl.org/ipo/core#canBeCausedBy"></see></summary>
    let canBeCausedBy = _prefix "canBeCausedBy"
    /// <summary>
    /// Indicates that an Issue can be a dependence of another Issue directly or indirectly.
    /// This property is also transitive, i.e., if the issue "A" can be dependence of the issue "B" and the issue "B" can be dependence of the issue "C", then the issue "A" can be dependence of the issue "C".
    /// <see href="http://purl.org/ipo/core#canBeDependenceOf"></see></summary>
    let canBeDependenceOf = _prefix "canBeDependenceOf"
    /// <summary>
    /// This property indicates an Issue that can be direct dependence of another Issue.
    /// <see href="http://purl.org/ipo/core#canBeDirectDependenceOf"></see></summary>
    let canBeDirectDependenceOf = _prefix "canBeDirectDependenceOf"
    /// <summary>
    /// An Issue can be  directly caused by another Issue.
    /// <see href="http://purl.org/ipo/core#canBeDirectlyCausedBy"></see></summary>
    let canBeDirectlyCausedBy = _prefix "canBeDirectlyCausedBy"
    /// <summary>
    /// An Issue can cause another Issue directly or indirectly.
    /// This property aims to express a possible causal relationship and has the characteristic of transitivity, i.e., the Issue "A" can cause the Issue "B" and the Issue "B" can cause the Issue "C", then the Issue "A" can cause the Issue "C".
    /// <see href="http://purl.org/ipo/core#canCause"></see></summary>
    let canCause = _prefix "canCause"
    /// <summary>
    /// Indicates that an Issue can depend on another Issue directly or indirectly.
    /// This property can express a dependency relationship between Issues and has the characteristic of transitivity, i.e., the Issue "A" can depend on the Issue "B" and the Issue "B" can depend on "C", then the Issue "A" can depend on the Issue "C".
    /// <see href="http://purl.org/ipo/core#canDependOn"></see></summary>
    let canDependOn = _prefix "canDependOn"
    /// <summary>
    /// An Issue can directly cause another Issue.
    /// This property aims to express a possible causal relationship, where an Issue can be direct cause of another Issue. For example, flu disease can cause pneumonia, i.e., in some cases, flu causes pneumonia and in another cases not.
    /// <see href="http://purl.org/ipo/core#canDirectlyCause"></see></summary>
    let canDirectlyCause = _prefix "canDirectlyCause"
    /// <summary>
    /// Indicates that an Issue can directly depend on another Issue.
    /// For example, pneumonia can directly depend that the flu is cured to finally be treated.
    /// <see href="http://purl.org/ipo/core#canDirectlyDependOn"></see></summary>
    let canDirectlyDependOn = _prefix "canDirectlyDependOn"
    /// <summary>
    /// Indicates a IssueEntity classified in a skos:Concept.
    /// <see href="http://purl.org/ipo/core#categoryOf"></see></summary>
    let categoryOf = _prefix "categoryOf"
    /// <summary>
    /// Indicates a category (skos: Concept) directly or indirectly related to a IssueEntity.
    /// The Concept class of SKOS ontology has properties that allow you to create hierarchies of categories (Concepts), still allowing express transitivity between categories. This approach should be used as an alternative to classification by subclass of IssueEntity when it are not intrinsic classifications, just grouping. For example, in the field of medicine, disease can be grouped as viral diseases, bacterial diseases, etc.
    /// <see href="http://purl.org/ipo/core#hasCategory"></see></summary>
    let hasCategory = _prefix "hasCategory"
    /// <summary>
    /// This property relates a Asset with a Issue caused by this Asset. For example, a virus associated with a disease caused by it.
    /// <see href="http://purl.org/ipo/core#causativeAssetOf"></see></summary>
    let causativeAssetOf = _prefix "causativeAssetOf"
    /// <summary>
    /// Indicates an Asset that is the causer of the Issue.
    /// <see href="http://purl.org/ipo/core#hasCausativeAsset"></see></summary>
    let hasCausativeAsset = _prefix "hasCausativeAsset"
    /// <summary>
    /// Indicates that an Issue is caused by another Issue directly or indirectly.
    /// This property also has a transitive characteristic, i.e., if the Issue "A" is caused by Issue "B" and the Issue "B" is caused by Issue "C", then the Issue "A" is caused by Issue "C".
    /// <see href="http://purl.org/ipo/core#causedBy"></see></summary>
    let causedBy = _prefix "causedBy"
    /// <summary>
    /// Indicates that an Issue causes another Issue directly or indirectly.
    /// This property expresses a causal relationship between Issues and have the characteristic of transitivity, i.e., if the Issue "A" causes Issue "B" and the Issue "B" causes Issue "C", then the Issue "A" causes Issue "C".
    /// <see href="http://purl.org/ipo/core#causes"></see></summary>
    let causes = _prefix "causes"
    /// <summary>
    /// Indicates that an Issue is a dependence of another Issue directly or indirectly.
    /// This property also has a transitive characteristic, i.e. , if Issue "A" is dependence of the Issue "B", and the Issue "B" is dependence of Issue "C", then the Issue "A" is dependence of Issue "C".
    /// <see href="http://purl.org/ipo/core#dependenceOf"></see></summary>
    let dependenceOf = _prefix "dependenceOf"
    /// <summary>
    /// This property indicates that an Issue depends on another Issue directly or indirectly.
    /// This property expresses a dependence relationship between Issues and has the characteristic of transitivity, i.e. , if Issue "A" depends on the Issue "B", and the Issue "B" depends on Issue "C", then the Issue "A" depends on Issue "C".
    /// <see href="http://purl.org/ipo/core#dependsOn"></see></summary>
    let dependsOn = _prefix "dependsOn"
    /// <summary>
    /// Indicates a IssueEntity illustrated by the image.
    /// This property is functional, i.e., an Image is related by this property with only one IssueEntity.
    /// <see href="http://purl.org/ipo/core#depictionOf"></see></summary>
    let depictionOf = _prefix "depictionOf"
    /// <summary>
    /// Indicates an image that illustrates the IssueEntity.
    /// Seeking a better description of IssueEntity, one can make use of this property to relate an illustrative image. For example, an image of a software screen containing an error occurred can help describe the problem.
    /// <see href="http://purl.org/ipo/core#hasDepiction"></see></summary>
    let hasDepiction = _prefix "hasDepiction"
    /// <summary>
    /// Indicates a IssueEntity directly classified in a skos:Concept.
    /// <see href="http://purl.org/ipo/core#directCategoryOf"></see></summary>
    let directCategoryOf = _prefix "directCategoryOf"
    /// <summary>
    /// Indicates that a Issue is direct dependence of another Issue.
    /// <see href="http://purl.org/ipo/core#directDependenceOf"></see></summary>
    let directDependenceOf = _prefix "directDependenceOf"
    /// <summary>
    /// Indicates that an Issue is directly caused by another Issue.
    /// <see href="http://purl.org/ipo/core#directlyCausedBy"></see></summary>
    let directlyCausedBy = _prefix "directlyCausedBy"
    /// <summary>
    /// This property indicates that an Issue directly causes another Issue.
    /// <see href="http://purl.org/ipo/core#directlyCauses"></see></summary>
    let directlyCauses = _prefix "directlyCauses"
    /// <summary>
    /// This relation indicates that a issue directly depends on another Issue.
    /// <see href="http://purl.org/ipo/core#directlyDependsOn"></see></summary>
    let directlyDependsOn = _prefix "directlyDependsOn"
    /// <summary>
    ///   <see href="http://purl.org/ipo/core#false"></see>
    /// </summary>
    let false_ = _prefix "false"
    /// <summary>
    /// Indicates the description of the goal to be reached after the execution of Procedure.
    /// <see href="http://purl.org/ipo/core#goal"></see></summary>
    let goal = _prefix "goal"
    /// <summary>
    /// Indicates a category (skos: Concept) directly related to a IssueEntity.
    /// <see href="http://purl.org/ipo/core#hasDirectCategory"></see></summary>
    let hasDirectCategory = _prefix "hasDirectCategory"
    /// <summary>
    /// Indicates an Asset that is the host (harbourer) of the Issue.
    /// <see href="http://purl.org/ipo/core#hasHostAsset"></see></summary>
    let hasHostAsset = _prefix "hasHostAsset"
    /// <summary>
    /// Indicates the Transition that starts the execution of this Step.
    /// <see href="http://purl.org/ipo/core#hasIncoming"></see></summary>
    let hasIncoming = _prefix "hasIncoming"
    /// <summary>
    /// Indicates a Person or Organization (Party) who created or registered the IssueEntity. This property is also used by Asset class to relate to its manufacturer, developer, inventor, etc.
    /// <see href="http://purl.org/ipo/core#hasMaker"></see></summary>
    let hasMaker = _prefix "hasMaker"
    /// <summary>
    /// This property can be used to indicates an Asset created/manufactured by Party or a IssueEntity created/registered by the Party.
    /// <see href="http://purl.org/ipo/core#makerOf"></see></summary>
    let makerOf = _prefix "makerOf"
    /// <summary>
    /// Indicates a Person who is a member of this Organization or another Organization that is member of this Organization, representing here a department or business unit.
    ///
    /// <see href="http://purl.org/ipo/core#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// Indicates a organization that the Party is participant.
    /// This property can be used to indicates that an employee is a member of an organization.
    /// Another approach is to use this property to relate two organizations thus representing a department that is a member of his company.
    /// <see href="http://purl.org/ipo/core#memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// Indicates the Transition that occurs after execution of this Step and that activates the next Step to be executed.
    /// <see href="http://purl.org/ipo/core#hasOutcoming"></see></summary>
    let hasOutcoming = _prefix "hasOutcoming"
    /// <summary>
    /// Relates an Asset with a Issue that occurs in it.
    /// This property can be used to relate a person with a disease whose the person is where the disease occurs.
    /// <see href="http://purl.org/ipo/core#hostAssetOf"></see></summary>
    let hostAssetOf = _prefix "hostAssetOf"
    /// <summary>
    /// Indicates a solution (Procedure) for this Issue.
    /// <see href="http://purl.org/ipo/core#solvedBy"></see></summary>
    let solvedBy = _prefix "solvedBy"
    /// <summary>
    ///   <see href="http://purl.org/ipo/core#true"></see>
    /// </summary>
    let true_ = _prefix "true"
