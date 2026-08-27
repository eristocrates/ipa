namespace https.w3id.org.pko.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pko =
    let _namespace_iri = Namespace_Iri pko |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:pko#Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an Action performed by a human Agent."</para>
    /// labels<para>"Action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#Action">https://w3id.org/pko#Action</seealso>
    let Action = Prefixed_Name(pko, "Action") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#Approval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pko#ProcedureStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#Approval">https://w3id.org/pko#Approval</seealso>
    let Approval = Prefixed_Name(pko, "Approval") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#Approved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pko#ProcedureStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#Approved">https://w3id.org/pko#Approved</seealso>
    let Approved = Prefixed_Name(pko, "Approved") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#Cancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pko#ProcedureExecutionStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#Cancelled">https://w3id.org/pko#Cancelled</seealso>
    let Cancelled = Prefixed_Name(pko, "Cancelled") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#Completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pko#ProcedureExecutionStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#Completed">https://w3id.org/pko#Completed</seealso>
    let Completed = Prefixed_Name(pko, "Completed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#Draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pko#ProcedureStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#Draft">https://w3id.org/pko#Draft</seealso>
    let Draft = Prefixed_Name(pko, "Draft") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#Error</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an Error that can be encountered while executing an activity."</para>
    /// labels<para>"Error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#Error">https://w3id.org/pko#Error</seealso>
    let Error = Prefixed_Name(pko, "Error") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#ExpertiseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the Expertise Level of an Agent with respect to certain activities/responsibilities."</para>
    /// labels<para>"Expertise Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#ExpertiseLevel">https://w3id.org/pko#ExpertiseLevel</seealso>
    let ExpertiseLevel = Prefixed_Name(pko, "ExpertiseLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#FAQCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the Category of a Frequently Asked Question (FAQ)."</para>
    /// labels<para>"F A Q Category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#FAQCategory">https://w3id.org/pko#FAQCategory</seealso>
    let FAQCategory = Prefixed_Name(pko, "FAQCategory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#FAQTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the Target of a Frequently Asked Question (FAQ)."</para>
    /// labels<para>"F A Q Target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#FAQTarget">https://w3id.org/pko#FAQTarget</seealso>
    let FAQTarget = Prefixed_Name(pko, "FAQTarget") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#FrequentlyAskedQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Frequently Asked Question (FAQ) is a Resource representing a question that people often ask about a particular resource, and the answer to the question."</para>
    /// labels<para>"Frequently Asked Question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#FrequentlyAskedQuestion">https://w3id.org/pko#FrequentlyAskedQuestion</seealso>
    let FrequentlyAskedQuestion =
        Prefixed_Name(pko, "FrequentlyAskedQuestion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a Function performed by a Software Agent."</para>
    /// labels<para>"Function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#Function">https://w3id.org/pko#Function</seealso>
    let Function = Prefixed_Name(pko, "Function") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#InProgress</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pko#ProcedureExecutionStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#InProgress">https://w3id.org/pko#InProgress</seealso>
    let InProgress = Prefixed_Name(pko, "InProgress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#IssueOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the occurrence of an issue during an Activity."</para>
    /// labels<para>"Issue Occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#IssueOccurrence">https://w3id.org/pko#IssueOccurrence</seealso>
    let IssueOccurrence = Prefixed_Name(pko, "IssueOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#Paused</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:pko#ProcedureExecutionStatus</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#Paused">https://w3id.org/pko#Paused</seealso>
    let Paused = Prefixed_Name(pko, "Paused") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Procedure represents a sequence of actions to be executed in order to achieve a desired outcome."</para>
    ///   <para>"A Procedure represents a sequence of actions to be executed in order to achieve a desired outcome."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#Procedure">https://w3id.org/pko#Procedure</seealso>
    let Procedure = Prefixed_Name(pko, "Procedure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#ProcedureExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Procedure Execution is an Activity representing the execution of a certain Procedure, performed by one or more Agents, during a time interval."</para>
    ///   <para>"A Procedure Execution is an Activity representing the execution of a certain Procedure, performed by one or more Agents, during a time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Procedure Execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"ProcedureExecution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#ProcedureExecution">https://w3id.org/pko#ProcedureExecution</seealso>
    let ProcedureExecution = Prefixed_Name(pko, "ProcedureExecution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#ProcedureExecutionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the Status of the Procedure Execution (e.g., in progress, completed, paused, cancelled)."</para>
    /// labels<para>"Procedure Execution Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#ProcedureExecutionStatus">https://w3id.org/pko#ProcedureExecutionStatus</seealso>
    let ProcedureExecutionStatus =
        Prefixed_Name(pko, "ProcedureExecutionStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#ProcedureStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the Status of the Procedure (e.g.,draft, validated)."</para>
    /// labels<para>"Procedure Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#ProcedureStatus">https://w3id.org/pko#ProcedureStatus</seealso>
    let ProcedureStatus = Prefixed_Name(pko, "ProcedureStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#ProcedureTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>"This class represents the Target of a Procedure, that is the object at which the actions of the Procedure are directed."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#ProcedureTarget">https://w3id.org/pko#ProcedureTarget</seealso>
    let ProcedureTarget = Prefixed_Name(pko, "ProcedureTarget") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#ProcedureTargetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"This class represents the Type of a Procedure Target."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#ProcedureTargetType">https://w3id.org/pko#ProcedureTargetType</seealso>
    let ProcedureTargetType = Prefixed_Name(pko, "ProcedureTargetType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#ProcedureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the Type of a Procedure."</para>
    /// labels<para>"Procedure Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#ProcedureType">https://w3id.org/pko#ProcedureType</seealso>
    let ProcedureType = Prefixed_Name(pko, "ProcedureType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#StepExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Procedure Execution is an Activity representing the execution of a certain Step of a Procedure, performed by one or more Agents, during a time interval."</para>
    /// labels<para>"Step Execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#StepExecution">https://w3id.org/pko#StepExecution</seealso>
    let StepExecution = Prefixed_Name(pko, "StepExecution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#StepVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Step Verification is a description of the way in which the execution of a Step can be verified."</para>
    /// labels<para>"Step Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#StepVerification">https://w3id.org/pko#StepVerification</seealso>
    let StepVerification = Prefixed_Name(pko, "StepVerification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#UserFeedbackOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the occurrence of a feedback that was provided by a user during an activity."</para>
    /// labels<para>"User Feedback Occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#UserFeedbackOccurrence">https://w3id.org/pko#UserFeedbackOccurrence</seealso>
    let UserFeedbackOccurrence =
        Prefixed_Name(pko, "UserFeedbackOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#UserQuestionOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the occurrence of a question that an Agent came up with during the Procedure or Step Execution."</para>
    /// labels<para>"User Question Occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#UserQuestionOccurrence">https://w3id.org/pko#UserQuestionOccurrence</seealso>
    let UserQuestionOccurrence =
        Prefixed_Name(pko, "UserQuestionOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:pko#ProcedureStatus</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#Validation">https://w3id.org/pko#Validation</seealso>
    let Validation = Prefixed_Name(pko, "Validation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#addressesError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a (Multi)Step of a Procedure to the Error it addresses. Such (Multi)Step represents a Fallback procedure."</para>
    /// labels<para>"addresses error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#addressesError">https://w3id.org/pko#addressesError</seealso>
    let addressesError = Prefixed_Name(pko, "addressesError") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#answer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the answer of a Frequently Asked Question."</para>
    /// labels<para>"answer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#answer">https://w3id.org/pko#answer</seealso>
    let answer = Prefixed_Name(pko, "answer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#changelogDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the changelog description of a Procedure, that details all updates with respect to the previous version of the same Procedure."</para>
    /// labels<para>"changelog description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#changelogDescription">https://w3id.org/pko#changelogDescription</seealso>
    let changelogDescription =
        Prefixed_Name(pko, "changelogDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#errorCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an Error that can be encountered during the Procedure or Step Execution."</para>
    /// labels<para>"error cause"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#errorCause">https://w3id.org/pko#errorCause</seealso>
    let errorCause = Prefixed_Name(pko, "errorCause") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#errorCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the code of an Error that can be encountered during the Procedure or Step Execution."</para>
    /// labels<para>"error code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#errorCode">https://w3id.org/pko#errorCode</seealso>
    let errorCode = Prefixed_Name(pko, "errorCode") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#executesProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to the Procedure that is being executed."</para>
    /// labels<para>"executes procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#executesProcedure">https://w3id.org/pko#executesProcedure</seealso>
    let executesProcedure = Prefixed_Name(pko, "executesProcedure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#executesStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to the Step that is being executed."</para>
    /// labels<para>"executes step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#executesStep">https://w3id.org/pko#executesStep</seealso>
    let executesStep = Prefixed_Name(pko, "executesStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#feedbackOnProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure that was provided by an Agent during the Procedure or Step Execution."</para>
    /// labels<para>"feedback on procedure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#feedbackOnProcedure">https://w3id.org/pko#feedbackOnProcedure</seealso>
    let feedbackOnProcedure = Prefixed_Name(pko, "feedbackOnProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#feedbackOnProcedureExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the feedback on the procedure execution that was provided by an Agent during the Procedure or Step Execution."</para>
    /// labels<para>"feedback on procedure execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#feedbackOnProcedureExecution">https://w3id.org/pko#feedbackOnProcedureExecution</seealso>
    let feedbackOnProcedureExecution =
        Prefixed_Name(pko, "feedbackOnProcedureExecution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#hasEncounteredError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step."</para>
    /// labels<para>"has encountered error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasEncounteredError">https://w3id.org/pko#hasEncounteredError</seealso>
    let hasEncounteredError = Prefixed_Name(pko, "hasEncounteredError") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasExpectedDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link the Occurrence of an Issue to the Error that is being encountered by the Agent executing a Procedure or Step."</para>
    /// labels<para>"has expected duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasExpectedDuration">https://w3id.org/pko#hasExpectedDuration</seealso>
    let hasExpectedDuration = Prefixed_Name(pko, "hasExpectedDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasFAQCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to a Category it belongs to."</para>
    /// labels<para>"has f a q category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasFAQCategory">https://w3id.org/pko#hasFAQCategory</seealso>
    let hasFAQCategory = Prefixed_Name(pko, "hasFAQCategory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasFAQTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Frequently Asked Question to the Target of such FAQ."</para>
    /// labels<para>"has f a q target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasFAQTarget">https://w3id.org/pko#hasFAQTarget</seealso>
    let hasFAQTarget = Prefixed_Name(pko, "hasFAQTarget") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasFallbackStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to a (Multi)Step that represents a Fallback procedure for a specific Error that can be encountered during execution."</para>
    /// labels<para>"has fallback step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasFallbackStep">https://w3id.org/pko#hasFallbackStep</seealso>
    let hasFallbackStep = Prefixed_Name(pko, "hasFallbackStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasFirstStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its first Step."</para>
    /// labels<para>"has first step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasFirstStep">https://w3id.org/pko#hasFirstStep</seealso>
    let hasFirstStep = Prefixed_Name(pko, "hasFirstStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasIssueOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to an Issue Occurrence, that is the occurrence of an issue during the execution."</para>
    /// labels<para>"has issue occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasIssueOccurrence">https://w3id.org/pko#hasIssueOccurrence</seealso>
    let hasIssueOccurrence = Prefixed_Name(pko, "hasIssueOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasProcedureTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Target(s), that is the object at which the actions of the Procedure are directed. A Procedure Target can be, for instance: a Machine, an Equipment, a Workstation."</para>
    /// labels<para>"has procedure target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasProcedureTarget">https://w3id.org/pko#hasProcedureTarget</seealso>
    let hasProcedureTarget = Prefixed_Name(pko, "hasProcedureTarget") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#hasProcedureTargetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a ProcedureTarget to its Procedure Target Type."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/pko#hasProcedureTargetType">https://w3id.org/pko#hasProcedureTargetType</seealso>
    let hasProcedureTargetType =
        Prefixed_Name(pko, "hasProcedureTargetType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#hasProcedureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to its Procedure Type (e.g., a LOTO Procedure)."</para>
    /// labels<para>"has procedure type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasProcedureType">https://w3id.org/pko#hasProcedureType</seealso>
    let hasProcedureType = Prefixed_Name(pko, "hasProcedureType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure or a MultiStep to its Steps."</para>
    /// labels<para>"has step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasStep">https://w3id.org/pko#hasStep</seealso>
    let hasStep = Prefixed_Name(pko, "hasStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#hasStepVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Step Verification, that is the way in which the execution of the step can be verified."</para>
    /// labels<para>"has step verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasStepVerification">https://w3id.org/pko#hasStepVerification</seealso>
    let hasStepVerification = Prefixed_Name(pko, "hasStepVerification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#hasUserFeedbackOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution to a User Feedback Occurrence, that is the occurrence of a feedback that the user provides during execution about wither the Procedure or the Procedure Execution."</para>
    /// labels<para>"has user feedback occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasUserFeedbackOccurrence">https://w3id.org/pko#hasUserFeedbackOccurrence</seealso>
    let hasUserFeedbackOccurrence =
        Prefixed_Name(pko, "hasUserFeedbackOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#hasUserQuestionOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure Execution or Step Execution to a User Question Occurrence, that is the occurrence of a question that the user came up with during execution."</para>
    /// labels<para>"has user question occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#hasUserQuestionOccurrence">https://w3id.org/pko#hasUserQuestionOccurrence</seealso>
    let hasUserQuestionOccurrence =
        Prefixed_Name(pko, "hasUserQuestionOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#isAdoptedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Procedure to an Organization which the Procedure is adopted by."</para>
    /// labels<para>"is adopted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#isAdoptedBy">https://w3id.org/pko#isAdoptedBy</seealso>
    let isAdoptedBy = Prefixed_Name(pko, "isAdoptedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#isCurrentVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is current version of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#isCurrentVersionOf">https://w3id.org/pko#isCurrentVersionOf</seealso>
    let isCurrentVersionOf = Prefixed_Name(pko, "isCurrentVersionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#isIncludedInProcedureExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is included in procedure execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#isIncludedInProcedureExecution">https://w3id.org/pko#isIncludedInProcedureExecution</seealso>
    let isIncludedInProcedureExecution =
        Prefixed_Name(pko, "isIncludedInProcedureExecution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#isQuestionAddressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to a Resource that addresses/answers to the question that the user came up with during the Procedure/Step Execution."</para>
    /// labels<para>"is question addressed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#isQuestionAddressedBy">https://w3id.org/pko#isQuestionAddressedBy</seealso>
    let isQuestionAddressedBy =
        Prefixed_Name(pko, "isQuestionAddressedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#isStepForExpertiseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the Expertise Level, meaning that the Step, or MultiStep, is targeted at persons with a certain level of expertise (e.g., junior, senior)."</para>
    /// labels<para>"is step for expertise level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#isStepForExpertiseLevel">https://w3id.org/pko#isStepForExpertiseLevel</seealso>
    let isStepForExpertiseLevel =
        Prefixed_Name(pko, "isStepForExpertiseLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#isStepOfMultiStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to the MultiStep it is a step of."</para>
    /// labels<para>"is step of multi step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#isStepOfMultiStep">https://w3id.org/pko#isStepOfMultiStep</seealso>
    let isStepOfMultiStep = Prefixed_Name(pko, "isStepOfMultiStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#isStepVerificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Verification, that is the way in which the execution of the step can be verified, to the Step it verifies."</para>
    /// labels<para>"is step verification of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#isStepVerificationOf">https://w3id.org/pko#isStepVerificationOf</seealso>
    let isStepVerificationOf =
        Prefixed_Name(pko, "isStepVerificationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#isTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent whether a Procedure is a Template or not. A Procedure is a Template if it is associated with a preset of Steps that can be used to define an Executable Procedure. Such steps are not directly executable in the form they are specified."</para>
    /// labels<para>"is template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#isTemplate">https://w3id.org/pko#isTemplate</seealso>
    let isTemplate = Prefixed_Name(pko, "isTemplate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#issueCauseBySoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"issue cause by software agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#issueCauseBySoftwareAgent">https://w3id.org/pko#issueCauseBySoftwareAgent</seealso>
    let issueCauseBySoftwareAgent =
        Prefixed_Name(pko, "issueCauseBySoftwareAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#issueCauseByUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the cause of an issue, encountered during a Procedure/Step Execution, as identified and defined by the user."</para>
    /// labels<para>"issue cause by user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#issueCauseByUser">https://w3id.org/pko#issueCauseByUser</seealso>
    let issueCauseByUser = Prefixed_Name(pko, "issueCauseByUser") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#issueSolutionBySoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"issue solution by software agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#issueSolutionBySoftwareAgent">https://w3id.org/pko#issueSolutionBySoftwareAgent</seealso>
    let issueSolutionBySoftwareAgent =
        Prefixed_Name(pko, "issueSolutionBySoftwareAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#issueSolutionByUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the solution of an issue, encountered during a Procedure/Step Execution, as identified and applied by the user."</para>
    /// labels<para>"issue solution by user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#issueSolutionByUser">https://w3id.org/pko#issueSolutionByUser</seealso>
    let issueSolutionByUser = Prefixed_Name(pko, "issueSolutionByUser") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#maxRepetitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the maxRepetitions is equal to 1, it means that the Step is not repeatable."</para>
    /// labels<para>"max repetitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#maxRepetitions">https://w3id.org/pko#maxRepetitions</seealso>
    let maxRepetitions = Prefixed_Name(pko, "maxRepetitions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#minRepetitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the maximum number of repetitions for a Step. If the minRepetitions is equal to 1, it means that the Step is mandatory. If the minRepetitions is equal to 0, it means that the Step is optional."</para>
    /// labels<para>"min repetitions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#minRepetitions">https://w3id.org/pko#minRepetitions</seealso>
    let minRepetitions = Prefixed_Name(pko, "minRepetitions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#newVersionMotivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the motivation for creating a new version of a Procedure, for which we want to manage access control."</para>
    /// labels<para>"new version motivation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#newVersionMotivation">https://w3id.org/pko#newVersionMotivation</seealso>
    let newVersionMotivation =
        Prefixed_Name(pko, "newVersionMotivation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#nextAlternativeStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to at least two alternative Steps, if only one of such steps should be executed."</para>
    /// labels<para>"next alternative step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#nextAlternativeStep">https://w3id.org/pko#nextAlternativeStep</seealso>
    let nextAlternativeStep = Prefixed_Name(pko, "nextAlternativeStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#nextStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct next Step."</para>
    /// labels<para>"next step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#nextStep">https://w3id.org/pko#nextStep</seealso>
    let nextStep = Prefixed_Name(pko, "nextStep") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#nextStepExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct next Step Execution."</para>
    /// labels<para>"next step execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#nextStepExecution">https://w3id.org/pko#nextStepExecution</seealso>
    let nextStepExecution = Prefixed_Name(pko, "nextStepExecution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#nextVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a version of a Procedure to its direct next version of the same Procedure."</para>
    /// labels<para>"next version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#nextVersion">https://w3id.org/pko#nextVersion</seealso>
    let nextVersion = Prefixed_Name(pko, "nextVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#notesBySoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"notes by software agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#notesBySoftwareAgent">https://w3id.org/pko#notesBySoftwareAgent</seealso>
    let notesBySoftwareAgent =
        Prefixed_Name(pko, "notesBySoftwareAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#notesByUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the notes taken by the user about either a question that occurred during the Procedure/Step Execution (User Question Occurrence) or an issue that occurred during the Procedure/Step Execution (Issue Occurrence)."</para>
    /// labels<para>"notes by user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#notesByUser">https://w3id.org/pko#notesByUser</seealso>
    let notesByUser = Prefixed_Name(pko, "notesByUser") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#previousStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to its direct previous Step."</para>
    /// labels<para>"previous step"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#previousStep">https://w3id.org/pko#previousStep</seealso>
    let previousStep = Prefixed_Name(pko, "previousStep") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#previousStepExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step Execution to its direct previous Step Execution."</para>
    /// labels<para>"previous step execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#previousStepExecution">https://w3id.org/pko#previousStepExecution</seealso>
    let previousStepExecution =
        Prefixed_Name(pko, "previousStepExecution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:pko#question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question of a Frequently Asked Question."</para>
    /// labels<para>"question"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#question">https://w3id.org/pko#question</seealso>
    let question = Prefixed_Name(pko, "question") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#questionByUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the question that a user came up with during the Procedure/Step Execution (User Question Occurrence)."</para>
    /// labels<para>"question by user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#questionByUser">https://w3id.org/pko#questionByUser</seealso>
    let questionByUser = Prefixed_Name(pko, "questionByUser") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#requiresAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to an Action that needs to be performed by a human Agent (a Person) for executing the Step."</para>
    /// labels<para>"requires action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#requiresAction">https://w3id.org/pko#requiresAction</seealso>
    let requiresAction = Prefixed_Name(pko, "requiresAction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#requiresFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step to a Function that needs to be performed by a Software Agent for executing the Step."</para>
    /// labels<para>"requires function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#requiresFunction">https://w3id.org/pko#requiresFunction</seealso>
    let requiresFunction = Prefixed_Name(pko, "requiresFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#requiresTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Step of a Procedure to a Tool required by the Step, that is an object needed to execute the Step."</para>
    /// labels<para>"requires tool"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#requiresTool">https://w3id.org/pko#requiresTool</seealso>
    let requiresTool = Prefixed_Name(pko, "requiresTool") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#stepNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"step number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#stepNumber">https://w3id.org/pko#stepNumber</seealso>
    let stepNumber = Prefixed_Name(pko, "stepNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#versionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to represent the number of the version of a Procedure, for which we want to manage access control."</para>
    /// labels<para>"version number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#versionNumber">https://w3id.org/pko#versionNumber</seealso>
    let versionNumber = Prefixed_Name(pko, "versionNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#wasAskedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Question Occurrence to the Agent that asked the question during the Procedure/Step Execution."</para>
    /// labels<para>"was asked by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#wasAskedBy">https://w3id.org/pko#wasAskedBy</seealso>
    let wasAskedBy = Prefixed_Name(pko, "wasAskedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#wasConfirmedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that confirmed the Activity."</para>
    /// labels<para>"was confirmed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#wasConfirmedBy">https://w3id.org/pko#wasConfirmedBy</seealso>
    let wasConfirmedBy = Prefixed_Name(pko, "wasConfirmedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#wasEncounteredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Issue Occurrence to the Agent that encountered the issue during the Procedure/Step Execution."</para>
    /// labels<para>"was encountered by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#wasEncounteredBy">https://w3id.org/pko#wasEncounteredBy</seealso>
    let wasEncounteredBy = Prefixed_Name(pko, "wasEncounteredBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#wasExecutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link an Activity (e.g., a Step Execution) to the Agent that executed the Activity."</para>
    /// labels<para>"was executed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#wasExecutedBy">https://w3id.org/pko#wasExecutedBy</seealso>
    let wasExecutedBy = Prefixed_Name(pko, "wasExecutedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#wasExtractedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Resource it was extracted from."</para>
    /// labels<para>"was extracted from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#wasExtractedFrom">https://w3id.org/pko#wasExtractedFrom</seealso>
    let wasExtractedFrom = Prefixed_Name(pko, "wasExtractedFrom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#wasModifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a Resource (e.g., a Procedure) to the Agent that modified the Resource."</para>
    /// labels<para>"was modified by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#wasModifiedBy">https://w3id.org/pko#wasModifiedBy</seealso>
    let wasModifiedBy = Prefixed_Name(pko, "wasModifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:pko#wasProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In the context of the Procedural Knowledge Ontology (PKO), this property is used to link a User Feedback Occurrence to the Agent that provided the feedback about either the procedure or the procedure execution during the Procedure Execution."</para>
    /// labels<para>"was provided by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/pko#wasProvidedBy">https://w3id.org/pko#wasProvidedBy</seealso>
    let wasProvidedBy = Prefixed_Name(pko, "wasProvidedBy") |> PrefixedName
