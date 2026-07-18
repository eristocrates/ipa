namespace https.w3id.org.pko.hash

open DoxAletheia.Rdf_Vocabulary

module pko =
    let _namespace_name = "https://w3id.org/pko#"
    /// <summary>
    /// A Procedure represents a sequence of actions to be executed in order to achieve a desired outcome.
    /// <see href="https://w3id.org/pko#Procedure"></see></summary>
    let Procedure = Namespaced_IRI.parse _namespace_name "Procedure" |> NamespacedName
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its Steps.
    /// <see href="https://w3id.org/pko#hasStep"></see></summary>
    let hasStep = Namespaced_IRI.parse _namespace_name "hasStep" |> NamespacedName

    /// <summary>
    /// This class represents the Status of the Procedure (e.g.,draft, validated).
    /// <see href="https://w3id.org/pko#ProcedureStatus"></see></summary>
    let ProcedureStatus =
        Namespaced_IRI.parse _namespace_name "ProcedureStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#isCurrentVersionOf"></see>
    /// </summary>
    let isCurrentVersionOf =
        Namespaced_IRI.parse _namespace_name "isCurrentVersionOf" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a version of a Procedure to its direct next version of the same Procedure.
    /// <see href="https://w3id.org/pko#nextVersion"></see></summary>
    let nextVersion =
        Namespaced_IRI.parse _namespace_name "nextVersion" |> NamespacedName

    /// <summary>
    /// A Procedure Execution is an Activity representing the execution of a certain Step of a Procedure, performed by one or more Agents, during a time interval.
    /// <see href="https://w3id.org/pko#StepExecution"></see></summary>
    let StepExecution =
        Namespaced_IRI.parse _namespace_name "StepExecution" |> NamespacedName

    /// <summary>
    /// This class represents an Action performed by a human Agent.
    /// <see href="https://w3id.org/pko#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pko#Approval"></see>
    /// </summary>
    let Approval = Namespaced_IRI.parse _namespace_name "Approval" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pko#Approved"></see>
    /// </summary>
    let Approved = Namespaced_IRI.parse _namespace_name "Approved" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pko#Cancelled"></see>
    /// </summary>
    let Cancelled = Namespaced_IRI.parse _namespace_name "Cancelled" |> NamespacedName

    /// <summary>
    /// This class represents the Status of the Procedure Execution (e.g., in progress, completed, paused, cancelled).
    /// <see href="https://w3id.org/pko#ProcedureExecutionStatus"></see></summary>
    let ProcedureExecutionStatus =
        Namespaced_IRI.parse _namespace_name "ProcedureExecutionStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#Completed"></see>
    /// </summary>
    let Completed = Namespaced_IRI.parse _namespace_name "Completed" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pko#Draft"></see>
    /// </summary>
    let Draft = Namespaced_IRI.parse _namespace_name "Draft" |> NamespacedName
    /// <summary>
    /// This class represents an Error that can be encountered while executing an activity.
    /// <see href="https://w3id.org/pko#Error"></see></summary>
    let Error = Namespaced_IRI.parse _namespace_name "Error" |> NamespacedName

    /// <summary>
    /// This class represents the Expertise Level of an Agent with respect to certain activities/responsibilities.
    /// <see href="https://w3id.org/pko#ExpertiseLevel"></see></summary>
    let ExpertiseLevel =
        Namespaced_IRI.parse _namespace_name "ExpertiseLevel" |> NamespacedName

    /// <summary>
    /// This class represents the Category of a Frequently Asked Question (FAQ).
    /// <see href="https://w3id.org/pko#FAQCategory"></see></summary>
    let FAQCategory =
        Namespaced_IRI.parse _namespace_name "FAQCategory" |> NamespacedName

    /// <summary>
    /// This class represents the Target of a Frequently Asked Question (FAQ).
    /// <see href="https://w3id.org/pko#FAQTarget"></see></summary>
    let FAQTarget = Namespaced_IRI.parse _namespace_name "FAQTarget" |> NamespacedName

    /// <summary>
    /// A Frequently Asked Question (FAQ) is a Resource representing a question that people often ask about a particular resource, and the answer to the question.
    /// <see href="https://w3id.org/pko#FrequentlyAskedQuestion"></see></summary>
    let FrequentlyAskedQuestion =
        Namespaced_IRI.parse _namespace_name "FrequentlyAskedQuestion" |> NamespacedName

    /// <summary>
    /// This class represents a Function performed by a Software Agent.
    /// <see href="https://w3id.org/pko#Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/pko#InProgress"></see>
    /// </summary>
    let InProgress = Namespaced_IRI.parse _namespace_name "InProgress" |> NamespacedName

    /// <summary>
    /// This class represents the occurrence of an issue during an Activity.
    /// <see href="https://w3id.org/pko#IssueOccurrence"></see></summary>
    let IssueOccurrence =
        Namespaced_IRI.parse _namespace_name "IssueOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#Paused"></see>
    /// </summary>
    let Paused = Namespaced_IRI.parse _namespace_name "Paused" |> NamespacedName

    /// <summary>
    /// A Procedure Execution is an Activity representing the execution of a certain Procedure, performed by one or more Agents, during a time interval.
    /// <see href="https://w3id.org/pko#ProcedureExecution"></see></summary>
    let ProcedureExecution =
        Namespaced_IRI.parse _namespace_name "ProcedureExecution" |> NamespacedName

    /// <summary>
    /// This class represents the Target of a Procedure, that is the object at which the actions of the Procedure are directed.
    /// <see href="https://w3id.org/pko#ProcedureTarget"></see></summary>
    let ProcedureTarget =
        Namespaced_IRI.parse _namespace_name "ProcedureTarget" |> NamespacedName

    /// <summary>
    /// This class represents the Type of a Procedure Target.
    /// <see href="https://w3id.org/pko#ProcedureTargetType"></see></summary>
    let ProcedureTargetType =
        Namespaced_IRI.parse _namespace_name "ProcedureTargetType" |> NamespacedName

    /// <summary>
    /// This class represents the Type of a Procedure.
    /// <see href="https://w3id.org/pko#ProcedureType"></see></summary>
    let ProcedureType =
        Namespaced_IRI.parse _namespace_name "ProcedureType" |> NamespacedName

    /// <summary>
    /// A Step Verification is a description of the way in which the execution of a Step can be verified.
    /// <see href="https://w3id.org/pko#StepVerification"></see></summary>
    let StepVerification =
        Namespaced_IRI.parse _namespace_name "StepVerification" |> NamespacedName

    /// <summary>
    /// This class represents the occurrence of a feedback that was provided by a user during an activity.
    /// <see href="https://w3id.org/pko#UserFeedbackOccurrence"></see></summary>
    let UserFeedbackOccurrence =
        Namespaced_IRI.parse _namespace_name "UserFeedbackOccurrence" |> NamespacedName

    /// <summary>
    /// This class represents the occurrence of a question that an Agent came up with during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#UserQuestionOccurrence"></see></summary>
    let UserQuestionOccurrence =
        Namespaced_IRI.parse _namespace_name "UserQuestionOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#Validation"></see>
    /// </summary>
    let Validation = Namespaced_IRI.parse _namespace_name "Validation" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a (Multi)Step of a Procedure to the Error it addresses. Such (Multi)Step represents a Fallback procedure.
    /// <see href="https://w3id.org/pko#addressesError"></see></summary>
    let addressesError =
        Namespaced_IRI.parse _namespace_name "addressesError" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the answer of a Frequently Asked Question.
    /// <see href="https://w3id.org/pko#answer"></see></summary>
    let answer = Namespaced_IRI.parse _namespace_name "answer" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the changelog description of a Procedure, that details all updates with respect to the previous version of the same Procedure.
    /// <see href="https://w3id.org/pko#changelogDescription"></see></summary>
    let changelogDescription =
        Namespaced_IRI.parse _namespace_name "changelogDescription" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an Error that can be encountered during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#errorCause"></see></summary>
    let errorCause = Namespaced_IRI.parse _namespace_name "errorCause" |> NamespacedName
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the code of an Error that can be encountered during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#errorCode"></see></summary>
    let errorCode = Namespaced_IRI.parse _namespace_name "errorCode" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to the Procedure that is being executed.
    /// <see href="https://w3id.org/pko#executesProcedure"></see></summary>
    let executesProcedure =
        Namespaced_IRI.parse _namespace_name "executesProcedure" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to the Step that is being executed.
    /// <see href="https://w3id.org/pko#executesStep"></see></summary>
    let executesStep =
        Namespaced_IRI.parse _namespace_name "executesStep" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure that was provided by an Agent during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#feedbackOnProcedure"></see></summary>
    let feedbackOnProcedure =
        Namespaced_IRI.parse _namespace_name "feedbackOnProcedure" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure execution that was provided by an Agent during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#feedbackOnProcedureExecution"></see></summary>
    let feedbackOnProcedureExecution =
        Namespaced_IRI.parse _namespace_name "feedbackOnProcedureExecution" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step.
    /// <see href="https://w3id.org/pko#hasEncounteredError"></see></summary>
    let hasEncounteredError =
        Namespaced_IRI.parse _namespace_name "hasEncounteredError" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step.
    /// <see href="https://w3id.org/pko#hasExpectedDuration"></see></summary>
    let hasExpectedDuration =
        Namespaced_IRI.parse _namespace_name "hasExpectedDuration" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to a Category it belongs to.
    /// <see href="https://w3id.org/pko#hasFAQCategory"></see></summary>
    let hasFAQCategory =
        Namespaced_IRI.parse _namespace_name "hasFAQCategory" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to the Target of such FAQ.
    /// <see href="https://w3id.org/pko#hasFAQTarget"></see></summary>
    let hasFAQTarget =
        Namespaced_IRI.parse _namespace_name "hasFAQTarget" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to a (Multi)Step that represents a Fallback procedure for a specific Error that can be encountered during execution.
    /// <see href="https://w3id.org/pko#hasFallbackStep"></see></summary>
    let hasFallbackStep =
        Namespaced_IRI.parse _namespace_name "hasFallbackStep" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its first Step.
    /// <see href="https://w3id.org/pko#hasFirstStep"></see></summary>
    let hasFirstStep =
        Namespaced_IRI.parse _namespace_name "hasFirstStep" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to an Issue Occurrence, that is the occurrence of an issue during the execution.
    /// <see href="https://w3id.org/pko#hasIssueOccurrence"></see></summary>
    let hasIssueOccurrence =
        Namespaced_IRI.parse _namespace_name "hasIssueOccurrence" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Target(s), that is the object at which the actions of the Procedure are directed. A Procedure Target can be, for instance: a Machine, an Equipment, a Workstation.
    /// <see href="https://w3id.org/pko#hasProcedureTarget"></see></summary>
    let hasProcedureTarget =
        Namespaced_IRI.parse _namespace_name "hasProcedureTarget" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a ProcedureTarget to its Procedure Target Type.
    /// <see href="https://w3id.org/pko#hasProcedureTargetType"></see></summary>
    let hasProcedureTargetType =
        Namespaced_IRI.parse _namespace_name "hasProcedureTargetType" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Type (e.g., a LOTO Procedure).
    /// <see href="https://w3id.org/pko#hasProcedureType"></see></summary>
    let hasProcedureType =
        Namespaced_IRI.parse _namespace_name "hasProcedureType" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Step Verification, that is the way in which the execution of the step can be verified.
    /// <see href="https://w3id.org/pko#hasStepVerification"></see></summary>
    let hasStepVerification =
        Namespaced_IRI.parse _namespace_name "hasStepVerification" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Verification, that is the way in which the execution of the step can be verified, to the Step it verifies.
    /// <see href="https://w3id.org/pko#isStepVerificationOf"></see></summary>
    let isStepVerificationOf =
        Namespaced_IRI.parse _namespace_name "isStepVerificationOf" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to a User Feedback Occurrence, that is the occurrence of a feedback that the user provides during execution about wither the Procedure or the Procedure Execution.
    /// <see href="https://w3id.org/pko#hasUserFeedbackOccurrence"></see></summary>
    let hasUserFeedbackOccurrence =
        Namespaced_IRI.parse _namespace_name "hasUserFeedbackOccurrence" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to a User Question Occurrence, that is the occurrence of a question that the user came up with during execution.
    /// <see href="https://w3id.org/pko#hasUserQuestionOccurrence"></see></summary>
    let hasUserQuestionOccurrence =
        Namespaced_IRI.parse _namespace_name "hasUserQuestionOccurrence" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to an Organization which the Procedure is adopted by.
    /// <see href="https://w3id.org/pko#isAdoptedBy"></see></summary>
    let isAdoptedBy =
        Namespaced_IRI.parse _namespace_name "isAdoptedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#isIncludedInProcedureExecution"></see>
    /// </summary>
    let isIncludedInProcedureExecution =
        Namespaced_IRI.parse _namespace_name "isIncludedInProcedureExecution" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to a Resource that addresses/answers to the question that the user came up with during the Procedure/Step Execution.
    /// <see href="https://w3id.org/pko#isQuestionAddressedBy"></see></summary>
    let isQuestionAddressedBy =
        Namespaced_IRI.parse _namespace_name "isQuestionAddressedBy" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the Expertise Level, meaning that the Step, or MultiStep, is targeted at persons with a certain level of expertise (e.g., junior, senior).
    /// <see href="https://w3id.org/pko#isStepForExpertiseLevel"></see></summary>
    let isStepForExpertiseLevel =
        Namespaced_IRI.parse _namespace_name "isStepForExpertiseLevel" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the MultiStep it is a step of.
    /// <see href="https://w3id.org/pko#isStepOfMultiStep"></see></summary>
    let isStepOfMultiStep =
        Namespaced_IRI.parse _namespace_name "isStepOfMultiStep" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent whether a Procedure is a Template or not. A Procedure is a Template if it is associated with a preset of Steps that can be used to define an Executable Procedure. Such steps are not directly executable in the form they are specified.
    /// <see href="https://w3id.org/pko#isTemplate"></see></summary>
    let isTemplate = Namespaced_IRI.parse _namespace_name "isTemplate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#issueCauseBySoftwareAgent"></see>
    /// </summary>
    let issueCauseBySoftwareAgent =
        Namespaced_IRI.parse _namespace_name "issueCauseBySoftwareAgent" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an issue, encountered during a Procedure/Step Execution, as identified and defined by the user.
    /// <see href="https://w3id.org/pko#issueCauseByUser"></see></summary>
    let issueCauseByUser =
        Namespaced_IRI.parse _namespace_name "issueCauseByUser" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#issueSolutionBySoftwareAgent"></see>
    /// </summary>
    let issueSolutionBySoftwareAgent =
        Namespaced_IRI.parse _namespace_name "issueSolutionBySoftwareAgent" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the solution of an issue, encountered during a Procedure/Step Execution, as identified and applied by the user.
    /// <see href="https://w3id.org/pko#issueSolutionByUser"></see></summary>
    let issueSolutionByUser =
        Namespaced_IRI.parse _namespace_name "issueSolutionByUser" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the maxRepetitions is equal to 1, it means that the Step is not repeatable.
    /// <see href="https://w3id.org/pko#maxRepetitions"></see></summary>
    let maxRepetitions =
        Namespaced_IRI.parse _namespace_name "maxRepetitions" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the minRepetitions is equal to 1, it means that the Step is mandatory. If the minRepetitions is equal to 0, it means that the Step is optional.
    /// <see href="https://w3id.org/pko#minRepetitions"></see></summary>
    let minRepetitions =
        Namespaced_IRI.parse _namespace_name "minRepetitions" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the motivation for creating a new version of a Procedure, for which we want to manage access control.
    /// <see href="https://w3id.org/pko#newVersionMotivation"></see></summary>
    let newVersionMotivation =
        Namespaced_IRI.parse _namespace_name "newVersionMotivation" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to at least two alternative Steps, if only one of such steps should be executed.
    /// <see href="https://w3id.org/pko#nextAlternativeStep"></see></summary>
    let nextAlternativeStep =
        Namespaced_IRI.parse _namespace_name "nextAlternativeStep" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct next Step.
    /// <see href="https://w3id.org/pko#nextStep"></see></summary>
    let nextStep = Namespaced_IRI.parse _namespace_name "nextStep" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct previous Step.
    /// <see href="https://w3id.org/pko#previousStep"></see></summary>
    let previousStep =
        Namespaced_IRI.parse _namespace_name "previousStep" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct next Step Execution.
    /// <see href="https://w3id.org/pko#nextStepExecution"></see></summary>
    let nextStepExecution =
        Namespaced_IRI.parse _namespace_name "nextStepExecution" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct previous Step Execution.
    /// <see href="https://w3id.org/pko#previousStepExecution"></see></summary>
    let previousStepExecution =
        Namespaced_IRI.parse _namespace_name "previousStepExecution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#notesBySoftwareAgent"></see>
    /// </summary>
    let notesBySoftwareAgent =
        Namespaced_IRI.parse _namespace_name "notesBySoftwareAgent" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the notes taken by the user about either a question that occurred during the Procedure/Step Execution (User Question Occurrence) or an issue that occurred during the Procedure/Step Execution (Issue Occurrence).
    /// <see href="https://w3id.org/pko#notesByUser"></see></summary>
    let notesByUser =
        Namespaced_IRI.parse _namespace_name "notesByUser" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question of a Frequently Asked Question.
    /// <see href="https://w3id.org/pko#question"></see></summary>
    let question = Namespaced_IRI.parse _namespace_name "question" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question that a user came up with during the Procedure/Step Execution (User Question Occurrence).
    /// <see href="https://w3id.org/pko#questionByUser"></see></summary>
    let questionByUser =
        Namespaced_IRI.parse _namespace_name "questionByUser" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to an Action that needs to be performed by a human Agent (a Person) for executing the Step.
    /// <see href="https://w3id.org/pko#requiresAction"></see></summary>
    let requiresAction =
        Namespaced_IRI.parse _namespace_name "requiresAction" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to a Function that needs to be performed by a Software Agent for executing the Step.
    /// <see href="https://w3id.org/pko#requiresFunction"></see></summary>
    let requiresFunction =
        Namespaced_IRI.parse _namespace_name "requiresFunction" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Tool required by the Step, that is an object needed to execute the Step.
    /// <see href="https://w3id.org/pko#requiresTool"></see></summary>
    let requiresTool =
        Namespaced_IRI.parse _namespace_name "requiresTool" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/pko#stepNumber"></see>
    /// </summary>
    let stepNumber = Namespaced_IRI.parse _namespace_name "stepNumber" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the number of the version of a Procedure, for which we want to manage access control.
    /// <see href="https://w3id.org/pko#versionNumber"></see></summary>
    let versionNumber =
        Namespaced_IRI.parse _namespace_name "versionNumber" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to the Agent that asked the question during the Procedure/Step Execution.
    /// <see href="https://w3id.org/pko#wasAskedBy"></see></summary>
    let wasAskedBy = Namespaced_IRI.parse _namespace_name "wasAskedBy" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that confirmed the Activity.
    /// <see href="https://w3id.org/pko#wasConfirmedBy"></see></summary>
    let wasConfirmedBy =
        Namespaced_IRI.parse _namespace_name "wasConfirmedBy" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Issue Occurrence to the Agent that encountered the issue during the Procedure/Step Execution.
    /// <see href="https://w3id.org/pko#wasEncounteredBy"></see></summary>
    let wasEncounteredBy =
        Namespaced_IRI.parse _namespace_name "wasEncounteredBy" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that executed the Activity.
    /// <see href="https://w3id.org/pko#wasExecutedBy"></see></summary>
    let wasExecutedBy =
        Namespaced_IRI.parse _namespace_name "wasExecutedBy" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Resource it was extracted from.
    /// <see href="https://w3id.org/pko#wasExtractedFrom"></see></summary>
    let wasExtractedFrom =
        Namespaced_IRI.parse _namespace_name "wasExtractedFrom" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Agent that modified the Resource.
    /// <see href="https://w3id.org/pko#wasModifiedBy"></see></summary>
    let wasModifiedBy =
        Namespaced_IRI.parse _namespace_name "wasModifiedBy" |> NamespacedName

    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Feedback Occurrence to the Agent that provided the feedback about either the procedure or the procedure execution during the Procedure Execution.
    /// <see href="https://w3id.org/pko#wasProvidedBy"></see></summary>
    let wasProvidedBy =
        Namespaced_IRI.parse _namespace_name "wasProvidedBy" |> NamespacedName
