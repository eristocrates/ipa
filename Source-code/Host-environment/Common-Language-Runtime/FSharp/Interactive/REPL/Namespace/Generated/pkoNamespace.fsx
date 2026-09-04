#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pko =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/pko#" "pko"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this class represents an action that needs to be performed by a human Agent (a Person) for executing a Step of a Procedure.</para>
    ///   <para>rdfs:label : Action^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an Action performed by a human Agent.</para>
    ///   <a href="https://w3id.org/pko#Action">pko:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    let Approval = _prefixId.prefix "Approval"
    let Approved = _prefixId.prefix "Approved"
    let Cancelled = _prefixId.prefix "Cancelled"
    let Completed = _prefixId.prefix "Completed"
    let Draft = _prefixId.prefix "Draft"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this class represents an error that an Agent can encounter during a Procedure or Step Execution. An Error can be associated with a description, an error code, and an error cause. The Procedure may contain a (fallback) step to address such error.</para>
    ///   <para>rdfs:label : Error^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an Error that can be encountered while executing an activity.</para>
    ///   <a href="https://w3id.org/pko#Error">pko:Error</a>
    /// </summary>
    let Error = _prefixId.prefix "Error"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this class represents the expertise level linked to a Step, or MultiStep, of a Procedure, meaning that the Step, or MultiStep, is targeted at persons with a certain level of expertise (e.g., junior, senior).</para>
    ///   <para>rdfs:label : Expertise Level^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the Expertise Level of an Agent with respect to certain activities/responsibilities.</para>
    ///   <a href="https://w3id.org/pko#ExpertiseLevel">pko:ExpertiseLevel</a>
    /// </summary>
    let ExpertiseLevel = _prefixId.prefix "ExpertiseLevel"
    /// <summary>
    ///   <para>rdfs:label : F A Q Category^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the Category of a Frequently Asked Question (FAQ).</para>
    ///   <a href="https://w3id.org/pko#FAQCategory">pko:FAQCategory</a>
    /// </summary>
    let FAQCategory = _prefixId.prefix "FAQCategory"
    /// <summary>
    ///   <para>rdfs:label : F A Q Target^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the Target of a Frequently Asked Question (FAQ).</para>
    ///   <a href="https://w3id.org/pko#FAQTarget">pko:FAQTarget</a>
    /// </summary>
    let FAQTarget = _prefixId.prefix "FAQTarget"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this class represents a Frequently Asked Question (FAQ) of a Procedure, and is described with an identifier, a question, an answer, and is linked to a FAQ Category and a FAQ Target.</para>
    ///   <para>rdfs:label : Frequently Asked Question^^xsd:string</para>
    ///   <para>rdfs:comment : A Frequently Asked Question (FAQ) is a Resource representing a question that people often ask about a particular resource, and the answer to the question.</para>
    ///   <a href="https://w3id.org/pko#FrequentlyAskedQuestion">pko:FrequentlyAskedQuestion</a>
    /// </summary>
    let FrequentlyAskedQuestion = _prefixId.prefix "FrequentlyAskedQuestion"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this class represents a function that needs to be performed by a Software Agent for executing a Step of a Procedure.</para>
    ///   <para>rdfs:label : Function^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a Function performed by a Software Agent.</para>
    ///   <a href="https://w3id.org/pko#Function">pko:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    let InProgress = _prefixId.prefix "InProgress"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this class represents the occurrence of an issue during the Procedure or Step Execution. The Issue Occurrence is associated with the cause as identified and defined by the Agent, the solution as identified and applied by the Agent, and is linked to the Agent that encountered the issue.</para>
    ///   <para>rdfs:label : Issue Occurrence^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the occurrence of an issue during an Activity.</para>
    ///   <a href="https://w3id.org/pko#IssueOccurrence">pko:IssueOccurrence</a>
    /// </summary>
    let IssueOccurrence = _prefixId.prefix "IssueOccurrence"
    let Paused = _prefixId.prefix "Paused"
    /// <summary>
    ///   <para>rdfs:label : Procedure^^xsd:string</para>
    ///   <para>rdfs:comment : A Procedure represents a sequence of actions to be executed in order to achieve a desired outcome.</para>
    ///   <a href="https://w3id.org/pko#Procedure">pko:Procedure</a>
    /// </summary>
    let Procedure = _prefixId.prefix "Procedure"
    /// <summary>
    ///   <para>rdfs:label : Procedure Execution^^xsd:string</para>
    ///   <para>rdfs:comment : A Procedure Execution is an Activity representing the execution of a certain Procedure, performed by one or more Agents, during a time interval.</para>
    ///   <a href="https://w3id.org/pko#ProcedureExecution">pko:ProcedureExecution</a>
    /// </summary>
    let ProcedureExecution = _prefixId.prefix "ProcedureExecution"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), a Procedure Execution is linked to its Procedure Execution Status with the property adms:status.</para>
    ///   <para>rdfs:label : Procedure Execution Status^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the Status of the Procedure Execution (e.g., in progress, completed, paused, cancelled).</para>
    ///   <a href="https://w3id.org/pko#ProcedureExecutionStatus">pko:ProcedureExecutionStatus</a>
    /// </summary>
    let ProcedureExecutionStatus = _prefixId.prefix "ProcedureExecutionStatus"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), a Procedure  is linked to its Procedure Status with the property adms:status.</para>
    ///   <para>rdfs:label : Procedure Status^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the Status of the Procedure (e.g.,draft, validated).</para>
    ///   <a href="https://w3id.org/pko#ProcedureStatus">pko:ProcedureStatus</a>
    /// </summary>
    let ProcedureStatus = _prefixId.prefix "ProcedureStatus"
    let ProcedureTarget = _prefixId.prefix "ProcedureTarget"
    let ProcedureTargetType = _prefixId.prefix "ProcedureTargetType"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), an example of Procedure Type is LOTO Procedure.</para>
    ///   <para>rdfs:label : Procedure Type^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the Type of a Procedure.</para>
    ///   <a href="https://w3id.org/pko#ProcedureType">pko:ProcedureType</a>
    /// </summary>
    let ProcedureType = _prefixId.prefix "ProcedureType"
    /// <summary>
    ///   <para>rdfs:label : Step Execution^^xsd:string</para>
    ///   <para>rdfs:comment : A Procedure Execution is an Activity representing the execution of a certain Step of a Procedure, performed by one or more Agents, during a time interval.</para>
    ///   <a href="https://w3id.org/pko#StepExecution">pko:StepExecution</a>
    /// </summary>
    let StepExecution = _prefixId.prefix "StepExecution"
    /// <summary>
    ///   <para>rdfs:label : Step Verification^^xsd:string</para>
    ///   <para>rdfs:comment : A Step Verification is a description of the way in which the execution of a Step can be verified.</para>
    ///   <a href="https://w3id.org/pko#StepVerification">pko:StepVerification</a>
    /// </summary>
    let StepVerification = _prefixId.prefix "StepVerification"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this class represents the occurrence of a feedback provided by an Agent during the Procedure or Step Execution. The User Feedback Occurrence is associated with the feedback, that is about either the Procedure or the Procedure Execution, and is linked to the Agent providing the feedback.</para>
    ///   <para>rdfs:label : User Feedback Occurrence^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the occurrence of a feedback that was provided by a user during an activity.</para>
    ///   <a href="https://w3id.org/pko#UserFeedbackOccurrence">pko:UserFeedbackOccurrence</a>
    /// </summary>
    let UserFeedbackOccurrence = _prefixId.prefix "UserFeedbackOccurrence"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this class represents the occurrence of a question that an Agent came up with during the Procedure or Step Execution. The User Question Occurrence is associated with the question, and is linked to the Agent asking the question. Also, it can be linked to a Resource addressing the question.</para>
    ///   <para>rdfs:label : User Question Occurrence^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the occurrence of a question that an Agent came up with during the Procedure or Step Execution.</para>
    ///   <a href="https://w3id.org/pko#UserQuestionOccurrence">pko:UserQuestionOccurrence</a>
    /// </summary>
    let UserQuestionOccurrence = _prefixId.prefix "UserQuestionOccurrence"
    let Validation = _prefixId.prefix "Validation"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a (Multi)Step of a Procedure to the Error it addresses. Such (Multi)Step represents a Fallback procedure.</para>
    ///   <para>rdfs:label : addresses error^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a (Multi)Step of a Procedure to the Error it addresses. Such (Multi)Step represents a Fallback procedure.</para>
    ///   <a href="https://w3id.org/pko#addressesError">pko:addressesError</a>
    /// </summary>
    let addressesError = _prefixId.prefix "addressesError"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the answer of a Frequently Asked Question.</para>
    ///   <para>rdfs:label : answer^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the answer of a Frequently Asked Question.</para>
    ///   <a href="https://w3id.org/pko#answer">pko:answer</a>
    /// </summary>
    let answer = _prefixId.prefix "answer"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the changelog description of a Procedure, that details all updates with respect to the previous version of the same Procedure.</para>
    ///   <para>rdfs:label : changelog description^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the changelog description of a Procedure, that details all updates with respect to the previous version of the same Procedure.</para>
    ///   <a href="https://w3id.org/pko#changelogDescription">pko:changelogDescription</a>
    /// </summary>
    let changelogDescription = _prefixId.prefix "changelogDescription"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an Error that can be encountered during the Procedure or Step Execution.</para>
    ///   <para>rdfs:label : error cause^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an Error that can be encountered during the Procedure or Step Execution.</para>
    ///   <a href="https://w3id.org/pko#errorCause">pko:errorCause</a>
    /// </summary>
    let errorCause = _prefixId.prefix "errorCause"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the code of an Error that can be encountered during the Procedure or Step Execution.</para>
    ///   <para>rdfs:label : error code^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the code of an Error that can be encountered during the Procedure or Step Execution.</para>
    ///   <a href="https://w3id.org/pko#errorCode">pko:errorCode</a>
    /// </summary>
    let errorCode = _prefixId.prefix "errorCode"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to the Procedure that is being executed.</para>
    ///   <para>rdfs:label : executes procedure^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to the Procedure that is being executed.</para>
    ///   <a href="https://w3id.org/pko#executesProcedure">pko:executesProcedure</a>
    /// </summary>
    let executesProcedure = _prefixId.prefix "executesProcedure"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to the Step that is being executed.</para>
    ///   <para>rdfs:label : executes step^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to the Step that is being executed.</para>
    ///   <a href="https://w3id.org/pko#executesStep">pko:executesStep</a>
    /// </summary>
    let executesStep = _prefixId.prefix "executesStep"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure that was provided by an Agent during the Procedure or Step Execution.</para>
    ///   <para>rdfs:label : feedback on procedure^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure that was provided by an Agent during the Procedure or Step Execution.</para>
    ///   <a href="https://w3id.org/pko#feedbackOnProcedure">pko:feedbackOnProcedure</a>
    /// </summary>
    let feedbackOnProcedure = _prefixId.prefix "feedbackOnProcedure"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure execution that was provided by an Agent during the Procedure or Step Execution.</para>
    ///   <para>rdfs:label : feedback on procedure execution^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure execution that was provided by an Agent during the Procedure or Step Execution.</para>
    ///   <a href="https://w3id.org/pko#feedbackOnProcedureExecution">pko:feedbackOnProcedureExecution</a>
    /// </summary>
    let feedbackOnProcedureExecution = _prefixId.prefix "feedbackOnProcedureExecution"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step.</para>
    ///   <para>rdfs:label : has encountered error^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step.</para>
    ///   <a href="https://w3id.org/pko#hasEncounteredError">pko:hasEncounteredError</a>
    /// </summary>
    let hasEncounteredError = _prefixId.prefix "hasEncounteredError"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link either a Procedure or a Step to the Duration that is expected for the execution of that Procedure/Step.</para>
    ///   <para>rdfs:label : has expected duration^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step.</para>
    ///   <a href="https://w3id.org/pko#hasExpectedDuration">pko:hasExpectedDuration</a>
    /// </summary>
    let hasExpectedDuration = _prefixId.prefix "hasExpectedDuration"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to a Category it belongs to.</para>
    ///   <para>rdfs:label : has f a q category^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to a Category it belongs to.</para>
    ///   <a href="https://w3id.org/pko#hasFAQCategory">pko:hasFAQCategory</a>
    /// </summary>
    let hasFAQCategory = _prefixId.prefix "hasFAQCategory"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to the Target of such FAQ.</para>
    ///   <para>rdfs:label : has f a q target^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to the Target of such FAQ.</para>
    ///   <a href="https://w3id.org/pko#hasFAQTarget">pko:hasFAQTarget</a>
    /// </summary>
    let hasFAQTarget = _prefixId.prefix "hasFAQTarget"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to a (Multi)Step that represents a Fallback procedure for a specific Error that can be encountered during execution.</para>
    ///   <para>rdfs:label : has fallback step^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to a (Multi)Step that represents a Fallback procedure for a specific Error that can be encountered during execution.</para>
    ///   <a href="https://w3id.org/pko#hasFallbackStep">pko:hasFallbackStep</a>
    /// </summary>
    let hasFallbackStep = _prefixId.prefix "hasFallbackStep"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its first Step.</para>
    ///   <para>rdfs:label : has first step^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its first Step.</para>
    ///   <a href="https://w3id.org/pko#hasFirstStep">pko:hasFirstStep</a>
    /// </summary>
    let hasFirstStep = _prefixId.prefix "hasFirstStep"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to an Issue Occurrence, that is the occurrence of an issue during the execution.</para>
    ///   <para>rdfs:label : has issue occurrence^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to an Issue Occurrence, that is the occurrence of an issue during the execution.</para>
    ///   <a href="https://w3id.org/pko#hasIssueOccurrence">pko:hasIssueOccurrence</a>
    /// </summary>
    let hasIssueOccurrence = _prefixId.prefix "hasIssueOccurrence"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Target(s), that is the object at which the actions of the Procedure are directed. A Procedure Target can be, for instance: a Machine, an Equipment, a Workstation.</para>
    ///   <para>rdfs:label : has procedure target^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Target(s), that is the object at which the actions of the Procedure are directed. A Procedure Target can be, for instance: a Machine, an Equipment, a Workstation.</para>
    ///   <a href="https://w3id.org/pko#hasProcedureTarget">pko:hasProcedureTarget</a>
    /// </summary>
    let hasProcedureTarget = _prefixId.prefix "hasProcedureTarget"
    let hasProcedureTargetType = _prefixId.prefix "hasProcedureTargetType"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Type (e.g., a LOTO Procedure).</para>
    ///   <para>rdfs:label : has procedure type^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Type (e.g., a LOTO Procedure).</para>
    ///   <a href="https://w3id.org/pko#hasProcedureType">pko:hasProcedureType</a>
    /// </summary>
    let hasProcedureType = _prefixId.prefix "hasProcedureType"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its Steps.</para>
    ///   <para>rdfs:label : has step^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its Steps.</para>
    ///   <a href="https://w3id.org/pko#hasStep">pko:hasStep</a>
    /// </summary>
    let hasStep = _prefixId.prefix "hasStep"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Step Verification, that is the way in which the execution of the step can be verified.</para>
    ///   <para>rdfs:label : has step verification^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Step Verification, that is the way in which the execution of the step can be verified.</para>
    ///   <a href="https://w3id.org/pko#hasStepVerification">pko:hasStepVerification</a>
    /// </summary>
    let hasStepVerification = _prefixId.prefix "hasStepVerification"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to a User Feedback Occurrence, that is the occurrence of a feedback that the user provides during execution about wither the Procedure or the Procedure Execution.</para>
    ///   <para>rdfs:label : has user feedback occurrence^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to a User Feedback Occurrence, that is the occurrence of a feedback that the user provides during execution about wither the Procedure or the Procedure Execution.</para>
    ///   <a href="https://w3id.org/pko#hasUserFeedbackOccurrence">pko:hasUserFeedbackOccurrence</a>
    /// </summary>
    let hasUserFeedbackOccurrence = _prefixId.prefix "hasUserFeedbackOccurrence"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to a User Question Occurrence, that is the occurrence of a question that the user came up with during execution.</para>
    ///   <para>rdfs:label : has user question occurrence^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to a User Question Occurrence, that is the occurrence of a question that the user came up with during execution.</para>
    ///   <a href="https://w3id.org/pko#hasUserQuestionOccurrence">pko:hasUserQuestionOccurrence</a>
    /// </summary>
    let hasUserQuestionOccurrence = _prefixId.prefix "hasUserQuestionOccurrence"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to an Organization which the Procedure is adopted by.</para>
    ///   <para>rdfs:label : is adopted by^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to an Organization which the Procedure is adopted by.</para>
    ///   <a href="https://w3id.org/pko#isAdoptedBy">pko:isAdoptedBy</a>
    /// </summary>
    let isAdoptedBy = _prefixId.prefix "isAdoptedBy"
    /// <summary>
    ///   <para>rdfs:label : is current version of^^xsd:string</para>
    ///   <a href="https://w3id.org/pko#isCurrentVersionOf">pko:isCurrentVersionOf</a>
    /// </summary>
    let isCurrentVersionOf = _prefixId.prefix "isCurrentVersionOf"

    /// <summary>
    ///   <para>rdfs:label : is included in procedure execution^^xsd:string</para>
    ///   <a href="https://w3id.org/pko#isIncludedInProcedureExecution">pko:isIncludedInProcedureExecution</a>
    /// </summary>
    let isIncludedInProcedureExecution =
        _prefixId.prefix "isIncludedInProcedureExecution"

    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to a Resource that addresses/answers to the question that the user came up with during the Procedure/Step Execution.</para>
    ///   <para>rdfs:label : is question addressed by^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to a Resource that addresses/answers to the question that the user came up with during the Procedure/Step Execution.</para>
    ///   <a href="https://w3id.org/pko#isQuestionAddressedBy">pko:isQuestionAddressedBy</a>
    /// </summary>
    let isQuestionAddressedBy = _prefixId.prefix "isQuestionAddressedBy"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the Expertise Level, meaning that the Step, or MultiStep, is targeted at persons with a certain level of expertise (e.g., junior, senior).</para>
    ///   <para>rdfs:label : is step for expertise level^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the Expertise Level, meaning that the Step, or MultiStep, is targeted at persons with a certain level of expertise (e.g., junior, senior).</para>
    ///   <a href="https://w3id.org/pko#isStepForExpertiseLevel">pko:isStepForExpertiseLevel</a>
    /// </summary>
    let isStepForExpertiseLevel = _prefixId.prefix "isStepForExpertiseLevel"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the MultiStep it is a step of.</para>
    ///   <para>rdfs:label : is step of multi step^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the MultiStep it is a step of.</para>
    ///   <a href="https://w3id.org/pko#isStepOfMultiStep">pko:isStepOfMultiStep</a>
    /// </summary>
    let isStepOfMultiStep = _prefixId.prefix "isStepOfMultiStep"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Verification, that is the way in which the execution of the step can be verified, to the Step it verifies.</para>
    ///   <para>rdfs:label : is step verification of^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Verification, that is the way in which the execution of the step can be verified, to the Step it verifies.</para>
    ///   <a href="https://w3id.org/pko#isStepVerificationOf">pko:isStepVerificationOf</a>
    /// </summary>
    let isStepVerificationOf = _prefixId.prefix "isStepVerificationOf"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent whether a Procedure is a Template or not. A Procedure is a Template if it is associated with a preset of Steps that can be used to define an Executable Procedure. Such steps are not directly executable in the form they are specified.</para>
    ///   <para>rdfs:label : is template^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent whether a Procedure is a Template or not. A Procedure is a Template if it is associated with a preset of Steps that can be used to define an Executable Procedure. Such steps are not directly executable in the form they are specified.</para>
    ///   <a href="https://w3id.org/pko#isTemplate">pko:isTemplate</a>
    /// </summary>
    let isTemplate = _prefixId.prefix "isTemplate"
    /// <summary>
    ///   <para>rdfs:label : issue cause by software agent^^xsd:string</para>
    ///   <a href="https://w3id.org/pko#issueCauseBySoftwareAgent">pko:issueCauseBySoftwareAgent</a>
    /// </summary>
    let issueCauseBySoftwareAgent = _prefixId.prefix "issueCauseBySoftwareAgent"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an issue, encountered during a Procedure/Step Execution, as identified and defined by the user.</para>
    ///   <para>rdfs:label : issue cause by user^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an issue, encountered during a Procedure/Step Execution, as identified and defined by the user.</para>
    ///   <a href="https://w3id.org/pko#issueCauseByUser">pko:issueCauseByUser</a>
    /// </summary>
    let issueCauseByUser = _prefixId.prefix "issueCauseByUser"
    /// <summary>
    ///   <para>rdfs:label : issue solution by software agent^^xsd:string</para>
    ///   <a href="https://w3id.org/pko#issueSolutionBySoftwareAgent">pko:issueSolutionBySoftwareAgent</a>
    /// </summary>
    let issueSolutionBySoftwareAgent = _prefixId.prefix "issueSolutionBySoftwareAgent"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the solution of an issue, encountered during a Procedure/Step Execution, as identified and applied by the user.</para>
    ///   <para>rdfs:label : issue solution by user^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the solution of an issue, encountered during a Procedure/Step Execution, as identified and applied by the user.</para>
    ///   <a href="https://w3id.org/pko#issueSolutionByUser">pko:issueSolutionByUser</a>
    /// </summary>
    let issueSolutionByUser = _prefixId.prefix "issueSolutionByUser"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the maxRepetitions is equal to 1, it means that the Step is not repeatable.</para>
    ///   <para>rdfs:label : max repetitions^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the maxRepetitions is equal to 1, it means that the Step is not repeatable.</para>
    ///   <a href="https://w3id.org/pko#maxRepetitions">pko:maxRepetitions</a>
    /// </summary>
    let maxRepetitions = _prefixId.prefix "maxRepetitions"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the minRepetitions is equal to 1, it means that the Step is mandatory. If the minRepetitions is equal to 0, it means that the Step is optional.</para>
    ///   <para>rdfs:label : min repetitions^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the minRepetitions is equal to 1, it means that the Step is mandatory. If the minRepetitions is equal to 0, it means that the Step is optional.</para>
    ///   <a href="https://w3id.org/pko#minRepetitions">pko:minRepetitions</a>
    /// </summary>
    let minRepetitions = _prefixId.prefix "minRepetitions"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the motivation for creating a new version of a Procedure, for which we want to manage access control.</para>
    ///   <para>rdfs:label : new version motivation^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the motivation for creating a new version of a Procedure, for which we want to manage access control.</para>
    ///   <a href="https://w3id.org/pko#newVersionMotivation">pko:newVersionMotivation</a>
    /// </summary>
    let newVersionMotivation = _prefixId.prefix "newVersionMotivation"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to at least two alternative Steps, if only one of such steps should be executed.</para>
    ///   <para>rdfs:label : next alternative step^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to at least two alternative Steps, if only one of such steps should be executed.</para>
    ///   <a href="https://w3id.org/pko#nextAlternativeStep">pko:nextAlternativeStep</a>
    /// </summary>
    let nextAlternativeStep = _prefixId.prefix "nextAlternativeStep"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct next Step.</para>
    ///   <para>rdfs:label : next step^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct next Step.</para>
    ///   <a href="https://w3id.org/pko#nextStep">pko:nextStep</a>
    /// </summary>
    let nextStep = _prefixId.prefix "nextStep"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct next Step Execution.</para>
    ///   <para>rdfs:label : next step execution^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct next Step Execution.</para>
    ///   <a href="https://w3id.org/pko#nextStepExecution">pko:nextStepExecution</a>
    /// </summary>
    let nextStepExecution = _prefixId.prefix "nextStepExecution"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a version of a Procedure to its direct next version of the same Procedure.</para>
    ///   <para>rdfs:label : next version^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a version of a Procedure to its direct next version of the same Procedure.</para>
    ///   <a href="https://w3id.org/pko#nextVersion">pko:nextVersion</a>
    /// </summary>
    let nextVersion = _prefixId.prefix "nextVersion"
    /// <summary>
    ///   <para>rdfs:label : notes by software agent^^xsd:string</para>
    ///   <a href="https://w3id.org/pko#notesBySoftwareAgent">pko:notesBySoftwareAgent</a>
    /// </summary>
    let notesBySoftwareAgent = _prefixId.prefix "notesBySoftwareAgent"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the notes taken by the user about either a question that occurred during the Procedure/Step Execution (User Question Occurrence) or an issue that occurred during the Procedure/Step Execution (Issue Occurrence).</para>
    ///   <para>rdfs:label : notes by user^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the notes taken by the user about either a question that occurred during the Procedure/Step Execution (User Question Occurrence) or an issue that occurred during the Procedure/Step Execution (Issue Occurrence).</para>
    ///   <a href="https://w3id.org/pko#notesByUser">pko:notesByUser</a>
    /// </summary>
    let notesByUser = _prefixId.prefix "notesByUser"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct previous Step.</para>
    ///   <para>rdfs:label : previous step^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct previous Step.</para>
    ///   <a href="https://w3id.org/pko#previousStep">pko:previousStep</a>
    /// </summary>
    let previousStep = _prefixId.prefix "previousStep"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct previous Step Execution.</para>
    ///   <para>rdfs:label : previous step execution^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct previous Step Execution.</para>
    ///   <a href="https://w3id.org/pko#previousStepExecution">pko:previousStepExecution</a>
    /// </summary>
    let previousStepExecution = _prefixId.prefix "previousStepExecution"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question of a Frequently Asked Question.</para>
    ///   <para>rdfs:label : question^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question of a Frequently Asked Question.</para>
    ///   <a href="https://w3id.org/pko#question">pko:question</a>
    /// </summary>
    let question = _prefixId.prefix "question"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question that a user came up with during the Procedure/Step Execution (User Question Occurrence).</para>
    ///   <para>rdfs:label : question by user^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question that a user came up with during the Procedure/Step Execution (User Question Occurrence).</para>
    ///   <a href="https://w3id.org/pko#questionByUser">pko:questionByUser</a>
    /// </summary>
    let questionByUser = _prefixId.prefix "questionByUser"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to an Action that needs to be performed by a human Agent (a Person) for executing the Step.</para>
    ///   <para>rdfs:label : requires action^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to an Action that needs to be performed by a human Agent (a Person) for executing the Step.</para>
    ///   <a href="https://w3id.org/pko#requiresAction">pko:requiresAction</a>
    /// </summary>
    let requiresAction = _prefixId.prefix "requiresAction"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to a Function that needs to be performed by a Software Agent for executing the Step.</para>
    ///   <para>rdfs:label : requires function^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to a Function that needs to be performed by a Software Agent for executing the Step.</para>
    ///   <a href="https://w3id.org/pko#requiresFunction">pko:requiresFunction</a>
    /// </summary>
    let requiresFunction = _prefixId.prefix "requiresFunction"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Tool required by the Step, that is an object needed to execute the Step.</para>
    ///   <para>rdfs:label : requires tool^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Tool required by the Step, that is an object needed to execute the Step.</para>
    ///   <a href="https://w3id.org/pko#requiresTool">pko:requiresTool</a>
    /// </summary>
    let requiresTool = _prefixId.prefix "requiresTool"
    /// <summary>
    ///   <para>rdfs:label : step number^^xsd:string</para>
    ///   <a href="https://w3id.org/pko#stepNumber">pko:stepNumber</a>
    /// </summary>
    let stepNumber = _prefixId.prefix "stepNumber"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the number of the version of a Procedure, for which we want to manage access control.</para>
    ///   <para>rdfs:label : version number^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the number of the version of a Procedure, for which we want to manage access control.</para>
    ///   <a href="https://w3id.org/pko#versionNumber">pko:versionNumber</a>
    /// </summary>
    let versionNumber = _prefixId.prefix "versionNumber"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to the Agent that asked the question during the Procedure/Step Execution.</para>
    ///   <para>rdfs:label : was asked by^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to the Agent that asked the question during the Procedure/Step Execution.</para>
    ///   <a href="https://w3id.org/pko#wasAskedBy">pko:wasAskedBy</a>
    /// </summary>
    let wasAskedBy = _prefixId.prefix "wasAskedBy"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that confirmed the Activity.</para>
    ///   <para>rdfs:label : was confirmed by^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that confirmed the Activity.</para>
    ///   <a href="https://w3id.org/pko#wasConfirmedBy">pko:wasConfirmedBy</a>
    /// </summary>
    let wasConfirmedBy = _prefixId.prefix "wasConfirmedBy"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Issue Occurrence to the Agent that encountered the issue during the Procedure/Step Execution.</para>
    ///   <para>rdfs:label : was encountered by^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Issue Occurrence to the Agent that encountered the issue during the Procedure/Step Execution.</para>
    ///   <a href="https://w3id.org/pko#wasEncounteredBy">pko:wasEncounteredBy</a>
    /// </summary>
    let wasEncounteredBy = _prefixId.prefix "wasEncounteredBy"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that executed the Activity.</para>
    ///   <para>rdfs:label : was executed by^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that executed the Activity.</para>
    ///   <a href="https://w3id.org/pko#wasExecutedBy">pko:wasExecutedBy</a>
    /// </summary>
    let wasExecutedBy = _prefixId.prefix "wasExecutedBy"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Resource it was extracted from.</para>
    ///   <para>rdfs:label : was extracted from^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Resource it was extracted from.</para>
    ///   <a href="https://w3id.org/pko#wasExtractedFrom">pko:wasExtractedFrom</a>
    /// </summary>
    let wasExtractedFrom = _prefixId.prefix "wasExtractedFrom"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Agent that modified the Resource.</para>
    ///   <para>rdfs:label : was modified by^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Agent that modified the Resource.</para>
    ///   <a href="https://w3id.org/pko#wasModifiedBy">pko:wasModifiedBy</a>
    /// </summary>
    let wasModifiedBy = _prefixId.prefix "wasModifiedBy"
    /// <summary>
    ///   <para>skos:scopeNote : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Feedback Occurrence to the Agent that provided the feedback about either the procedure or the procedure execution during the Procedure Execution.</para>
    ///   <para>rdfs:label : was provided by^^xsd:string</para>
    ///   <para>rdfs:comment : In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Feedback Occurrence to the Agent that provided the feedback about either the procedure or the procedure execution during the Procedure Execution.</para>
    ///   <a href="https://w3id.org/pko#wasProvidedBy">pko:wasProvidedBy</a>
    /// </summary>
    let wasProvidedBy = _prefixId.prefix "wasProvidedBy"
