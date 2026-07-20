namespace https.w3id.org.pko.hash

open DoxAletheia

module pko =
    let _namespace_name = "https://w3id.org/pko#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Procedure represents a sequence of actions to be executed in order to achieve a desired outcome.
    /// <see href="https://w3id.org/pko#Procedure"></see></summary>
    let Procedure = _prefix "Procedure"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its Steps.
    /// <see href="https://w3id.org/pko#hasStep"></see></summary>
    let hasStep = _prefix "hasStep"
    /// <summary>
    /// This class represents the Status of the Procedure (e.g.,draft, validated).
    /// <see href="https://w3id.org/pko#ProcedureStatus"></see></summary>
    let ProcedureStatus = _prefix "ProcedureStatus"
    /// <summary>
    ///   <see href="https://w3id.org/pko#isCurrentVersionOf"></see>
    /// </summary>
    let isCurrentVersionOf = _prefix "isCurrentVersionOf"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a version of a Procedure to its direct next version of the same Procedure.
    /// <see href="https://w3id.org/pko#nextVersion"></see></summary>
    let nextVersion = _prefix "nextVersion"
    /// <summary>
    /// A Procedure Execution is an Activity representing the execution of a certain Step of a Procedure, performed by one or more Agents, during a time interval.
    /// <see href="https://w3id.org/pko#StepExecution"></see></summary>
    let StepExecution = _prefix "StepExecution"
    /// <summary>
    /// This class represents an Action performed by a human Agent.
    /// <see href="https://w3id.org/pko#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="https://w3id.org/pko#Approval"></see>
    /// </summary>
    let Approval = _prefix "Approval"
    /// <summary>
    ///   <see href="https://w3id.org/pko#Approved"></see>
    /// </summary>
    let Approved = _prefix "Approved"
    /// <summary>
    ///   <see href="https://w3id.org/pko#Cancelled"></see>
    /// </summary>
    let Cancelled = _prefix "Cancelled"
    /// <summary>
    /// This class represents the Status of the Procedure Execution (e.g., in progress, completed, paused, cancelled).
    /// <see href="https://w3id.org/pko#ProcedureExecutionStatus"></see></summary>
    let ProcedureExecutionStatus = _prefix "ProcedureExecutionStatus"
    /// <summary>
    ///   <see href="https://w3id.org/pko#Completed"></see>
    /// </summary>
    let Completed = _prefix "Completed"
    /// <summary>
    ///   <see href="https://w3id.org/pko#Draft"></see>
    /// </summary>
    let Draft = _prefix "Draft"
    /// <summary>
    /// This class represents an Error that can be encountered while executing an activity.
    /// <see href="https://w3id.org/pko#Error"></see></summary>
    let Error = _prefix "Error"
    /// <summary>
    /// This class represents the Expertise Level of an Agent with respect to certain activities/responsibilities.
    /// <see href="https://w3id.org/pko#ExpertiseLevel"></see></summary>
    let ExpertiseLevel = _prefix "ExpertiseLevel"
    /// <summary>
    /// This class represents the Category of a Frequently Asked Question (FAQ).
    /// <see href="https://w3id.org/pko#FAQCategory"></see></summary>
    let FAQCategory = _prefix "FAQCategory"
    /// <summary>
    /// This class represents the Target of a Frequently Asked Question (FAQ).
    /// <see href="https://w3id.org/pko#FAQTarget"></see></summary>
    let FAQTarget = _prefix "FAQTarget"
    /// <summary>
    /// A Frequently Asked Question (FAQ) is a Resource representing a question that people often ask about a particular resource, and the answer to the question.
    /// <see href="https://w3id.org/pko#FrequentlyAskedQuestion"></see></summary>
    let FrequentlyAskedQuestion = _prefix "FrequentlyAskedQuestion"
    /// <summary>
    /// This class represents a Function performed by a Software Agent.
    /// <see href="https://w3id.org/pko#Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    ///   <see href="https://w3id.org/pko#InProgress"></see>
    /// </summary>
    let InProgress = _prefix "InProgress"
    /// <summary>
    /// This class represents the occurrence of an issue during an Activity.
    /// <see href="https://w3id.org/pko#IssueOccurrence"></see></summary>
    let IssueOccurrence = _prefix "IssueOccurrence"
    /// <summary>
    ///   <see href="https://w3id.org/pko#Paused"></see>
    /// </summary>
    let Paused = _prefix "Paused"
    /// <summary>
    /// A Procedure Execution is an Activity representing the execution of a certain Procedure, performed by one or more Agents, during a time interval.
    /// <see href="https://w3id.org/pko#ProcedureExecution"></see></summary>
    let ProcedureExecution = _prefix "ProcedureExecution"
    /// <summary>
    /// This class represents the Target of a Procedure, that is the object at which the actions of the Procedure are directed.
    /// <see href="https://w3id.org/pko#ProcedureTarget"></see></summary>
    let ProcedureTarget = _prefix "ProcedureTarget"
    /// <summary>
    /// This class represents the Type of a Procedure Target.
    /// <see href="https://w3id.org/pko#ProcedureTargetType"></see></summary>
    let ProcedureTargetType = _prefix "ProcedureTargetType"
    /// <summary>
    /// This class represents the Type of a Procedure.
    /// <see href="https://w3id.org/pko#ProcedureType"></see></summary>
    let ProcedureType = _prefix "ProcedureType"
    /// <summary>
    /// A Step Verification is a description of the way in which the execution of a Step can be verified.
    /// <see href="https://w3id.org/pko#StepVerification"></see></summary>
    let StepVerification = _prefix "StepVerification"
    /// <summary>
    /// This class represents the occurrence of a feedback that was provided by a user during an activity.
    /// <see href="https://w3id.org/pko#UserFeedbackOccurrence"></see></summary>
    let UserFeedbackOccurrence = _prefix "UserFeedbackOccurrence"
    /// <summary>
    /// This class represents the occurrence of a question that an Agent came up with during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#UserQuestionOccurrence"></see></summary>
    let UserQuestionOccurrence = _prefix "UserQuestionOccurrence"
    /// <summary>
    ///   <see href="https://w3id.org/pko#Validation"></see>
    /// </summary>
    let Validation = _prefix "Validation"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a (Multi)Step of a Procedure to the Error it addresses. Such (Multi)Step represents a Fallback procedure.
    /// <see href="https://w3id.org/pko#addressesError"></see></summary>
    let addressesError = _prefix "addressesError"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the answer of a Frequently Asked Question.
    /// <see href="https://w3id.org/pko#answer"></see></summary>
    let answer = _prefix "answer"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the changelog description of a Procedure, that details all updates with respect to the previous version of the same Procedure.
    /// <see href="https://w3id.org/pko#changelogDescription"></see></summary>
    let changelogDescription = _prefix "changelogDescription"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an Error that can be encountered during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#errorCause"></see></summary>
    let errorCause = _prefix "errorCause"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the code of an Error that can be encountered during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#errorCode"></see></summary>
    let errorCode = _prefix "errorCode"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to the Procedure that is being executed.
    /// <see href="https://w3id.org/pko#executesProcedure"></see></summary>
    let executesProcedure = _prefix "executesProcedure"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to the Step that is being executed.
    /// <see href="https://w3id.org/pko#executesStep"></see></summary>
    let executesStep = _prefix "executesStep"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure that was provided by an Agent during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#feedbackOnProcedure"></see></summary>
    let feedbackOnProcedure = _prefix "feedbackOnProcedure"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure execution that was provided by an Agent during the Procedure or Step Execution.
    /// <see href="https://w3id.org/pko#feedbackOnProcedureExecution"></see></summary>
    let feedbackOnProcedureExecution = _prefix "feedbackOnProcedureExecution"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step.
    /// <see href="https://w3id.org/pko#hasEncounteredError"></see></summary>
    let hasEncounteredError = _prefix "hasEncounteredError"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step.
    /// <see href="https://w3id.org/pko#hasExpectedDuration"></see></summary>
    let hasExpectedDuration = _prefix "hasExpectedDuration"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to a Category it belongs to.
    /// <see href="https://w3id.org/pko#hasFAQCategory"></see></summary>
    let hasFAQCategory = _prefix "hasFAQCategory"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to the Target of such FAQ.
    /// <see href="https://w3id.org/pko#hasFAQTarget"></see></summary>
    let hasFAQTarget = _prefix "hasFAQTarget"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to a (Multi)Step that represents a Fallback procedure for a specific Error that can be encountered during execution.
    /// <see href="https://w3id.org/pko#hasFallbackStep"></see></summary>
    let hasFallbackStep = _prefix "hasFallbackStep"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its first Step.
    /// <see href="https://w3id.org/pko#hasFirstStep"></see></summary>
    let hasFirstStep = _prefix "hasFirstStep"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to an Issue Occurrence, that is the occurrence of an issue during the execution.
    /// <see href="https://w3id.org/pko#hasIssueOccurrence"></see></summary>
    let hasIssueOccurrence = _prefix "hasIssueOccurrence"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Target(s), that is the object at which the actions of the Procedure are directed. A Procedure Target can be, for instance: a Machine, an Equipment, a Workstation.
    /// <see href="https://w3id.org/pko#hasProcedureTarget"></see></summary>
    let hasProcedureTarget = _prefix "hasProcedureTarget"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a ProcedureTarget to its Procedure Target Type.
    /// <see href="https://w3id.org/pko#hasProcedureTargetType"></see></summary>
    let hasProcedureTargetType = _prefix "hasProcedureTargetType"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Type (e.g., a LOTO Procedure).
    /// <see href="https://w3id.org/pko#hasProcedureType"></see></summary>
    let hasProcedureType = _prefix "hasProcedureType"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Step Verification, that is the way in which the execution of the step can be verified.
    /// <see href="https://w3id.org/pko#hasStepVerification"></see></summary>
    let hasStepVerification = _prefix "hasStepVerification"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Verification, that is the way in which the execution of the step can be verified, to the Step it verifies.
    /// <see href="https://w3id.org/pko#isStepVerificationOf"></see></summary>
    let isStepVerificationOf = _prefix "isStepVerificationOf"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to a User Feedback Occurrence, that is the occurrence of a feedback that the user provides during execution about wither the Procedure or the Procedure Execution.
    /// <see href="https://w3id.org/pko#hasUserFeedbackOccurrence"></see></summary>
    let hasUserFeedbackOccurrence = _prefix "hasUserFeedbackOccurrence"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to a User Question Occurrence, that is the occurrence of a question that the user came up with during execution.
    /// <see href="https://w3id.org/pko#hasUserQuestionOccurrence"></see></summary>
    let hasUserQuestionOccurrence = _prefix "hasUserQuestionOccurrence"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to an Organization which the Procedure is adopted by.
    /// <see href="https://w3id.org/pko#isAdoptedBy"></see></summary>
    let isAdoptedBy = _prefix "isAdoptedBy"
    /// <summary>
    ///   <see href="https://w3id.org/pko#isIncludedInProcedureExecution"></see>
    /// </summary>
    let isIncludedInProcedureExecution = _prefix "isIncludedInProcedureExecution"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to a Resource that addresses/answers to the question that the user came up with during the Procedure/Step Execution.
    /// <see href="https://w3id.org/pko#isQuestionAddressedBy"></see></summary>
    let isQuestionAddressedBy = _prefix "isQuestionAddressedBy"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the Expertise Level, meaning that the Step, or MultiStep, is targeted at persons with a certain level of expertise (e.g., junior, senior).
    /// <see href="https://w3id.org/pko#isStepForExpertiseLevel"></see></summary>
    let isStepForExpertiseLevel = _prefix "isStepForExpertiseLevel"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the MultiStep it is a step of.
    /// <see href="https://w3id.org/pko#isStepOfMultiStep"></see></summary>
    let isStepOfMultiStep = _prefix "isStepOfMultiStep"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent whether a Procedure is a Template or not. A Procedure is a Template if it is associated with a preset of Steps that can be used to define an Executable Procedure. Such steps are not directly executable in the form they are specified.
    /// <see href="https://w3id.org/pko#isTemplate"></see></summary>
    let isTemplate = _prefix "isTemplate"
    /// <summary>
    ///   <see href="https://w3id.org/pko#issueCauseBySoftwareAgent"></see>
    /// </summary>
    let issueCauseBySoftwareAgent = _prefix "issueCauseBySoftwareAgent"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an issue, encountered during a Procedure/Step Execution, as identified and defined by the user.
    /// <see href="https://w3id.org/pko#issueCauseByUser"></see></summary>
    let issueCauseByUser = _prefix "issueCauseByUser"
    /// <summary>
    ///   <see href="https://w3id.org/pko#issueSolutionBySoftwareAgent"></see>
    /// </summary>
    let issueSolutionBySoftwareAgent = _prefix "issueSolutionBySoftwareAgent"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the solution of an issue, encountered during a Procedure/Step Execution, as identified and applied by the user.
    /// <see href="https://w3id.org/pko#issueSolutionByUser"></see></summary>
    let issueSolutionByUser = _prefix "issueSolutionByUser"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the maxRepetitions is equal to 1, it means that the Step is not repeatable.
    /// <see href="https://w3id.org/pko#maxRepetitions"></see></summary>
    let maxRepetitions = _prefix "maxRepetitions"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the minRepetitions is equal to 1, it means that the Step is mandatory. If the minRepetitions is equal to 0, it means that the Step is optional.
    /// <see href="https://w3id.org/pko#minRepetitions"></see></summary>
    let minRepetitions = _prefix "minRepetitions"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the motivation for creating a new version of a Procedure, for which we want to manage access control.
    /// <see href="https://w3id.org/pko#newVersionMotivation"></see></summary>
    let newVersionMotivation = _prefix "newVersionMotivation"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to at least two alternative Steps, if only one of such steps should be executed.
    /// <see href="https://w3id.org/pko#nextAlternativeStep"></see></summary>
    let nextAlternativeStep = _prefix "nextAlternativeStep"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct next Step.
    /// <see href="https://w3id.org/pko#nextStep"></see></summary>
    let nextStep = _prefix "nextStep"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct previous Step.
    /// <see href="https://w3id.org/pko#previousStep"></see></summary>
    let previousStep = _prefix "previousStep"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct next Step Execution.
    /// <see href="https://w3id.org/pko#nextStepExecution"></see></summary>
    let nextStepExecution = _prefix "nextStepExecution"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct previous Step Execution.
    /// <see href="https://w3id.org/pko#previousStepExecution"></see></summary>
    let previousStepExecution = _prefix "previousStepExecution"
    /// <summary>
    ///   <see href="https://w3id.org/pko#notesBySoftwareAgent"></see>
    /// </summary>
    let notesBySoftwareAgent = _prefix "notesBySoftwareAgent"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the notes taken by the user about either a question that occurred during the Procedure/Step Execution (User Question Occurrence) or an issue that occurred during the Procedure/Step Execution (Issue Occurrence).
    /// <see href="https://w3id.org/pko#notesByUser"></see></summary>
    let notesByUser = _prefix "notesByUser"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question of a Frequently Asked Question.
    /// <see href="https://w3id.org/pko#question"></see></summary>
    let question = _prefix "question"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question that a user came up with during the Procedure/Step Execution (User Question Occurrence).
    /// <see href="https://w3id.org/pko#questionByUser"></see></summary>
    let questionByUser = _prefix "questionByUser"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to an Action that needs to be performed by a human Agent (a Person) for executing the Step.
    /// <see href="https://w3id.org/pko#requiresAction"></see></summary>
    let requiresAction = _prefix "requiresAction"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to a Function that needs to be performed by a Software Agent for executing the Step.
    /// <see href="https://w3id.org/pko#requiresFunction"></see></summary>
    let requiresFunction = _prefix "requiresFunction"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Tool required by the Step, that is an object needed to execute the Step.
    /// <see href="https://w3id.org/pko#requiresTool"></see></summary>
    let requiresTool = _prefix "requiresTool"
    /// <summary>
    ///   <see href="https://w3id.org/pko#stepNumber"></see>
    /// </summary>
    let stepNumber = _prefix "stepNumber"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the number of the version of a Procedure, for which we want to manage access control.
    /// <see href="https://w3id.org/pko#versionNumber"></see></summary>
    let versionNumber = _prefix "versionNumber"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to the Agent that asked the question during the Procedure/Step Execution.
    /// <see href="https://w3id.org/pko#wasAskedBy"></see></summary>
    let wasAskedBy = _prefix "wasAskedBy"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that confirmed the Activity.
    /// <see href="https://w3id.org/pko#wasConfirmedBy"></see></summary>
    let wasConfirmedBy = _prefix "wasConfirmedBy"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Issue Occurrence to the Agent that encountered the issue during the Procedure/Step Execution.
    /// <see href="https://w3id.org/pko#wasEncounteredBy"></see></summary>
    let wasEncounteredBy = _prefix "wasEncounteredBy"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that executed the Activity.
    /// <see href="https://w3id.org/pko#wasExecutedBy"></see></summary>
    let wasExecutedBy = _prefix "wasExecutedBy"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Resource it was extracted from.
    /// <see href="https://w3id.org/pko#wasExtractedFrom"></see></summary>
    let wasExtractedFrom = _prefix "wasExtractedFrom"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Agent that modified the Resource.
    /// <see href="https://w3id.org/pko#wasModifiedBy"></see></summary>
    let wasModifiedBy = _prefix "wasModifiedBy"
    /// <summary>
    /// In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Feedback Occurrence to the Agent that provided the feedback about either the procedure or the procedure execution during the Procedure Execution.
    /// <see href="https://w3id.org/pko#wasProvidedBy"></see></summary>
    let wasProvidedBy = _prefix "wasProvidedBy"
