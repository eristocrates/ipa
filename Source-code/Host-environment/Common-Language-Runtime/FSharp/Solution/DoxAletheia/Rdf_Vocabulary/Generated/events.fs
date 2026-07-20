namespace http.eulersharp.sourceforge.net._2003._03swap._event.hash

open DoxAletheia

module events =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/event#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteContraindication"></see>
    /// </summary>
    let AbsoluteContraindication = _prefix "AbsoluteContraindication"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Contraindication"></see>
    /// </summary>
    let Contraindication = _prefix "Contraindication"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteIndication"></see>
    /// </summary>
    let AbsoluteIndication = _prefix "AbsoluteIndication"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Indication"></see>
    /// </summary>
    let Indication = _prefix "Indication"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Process"></see>
    /// </summary>
    let Process = _prefix "Process"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AdverseOutput"></see>
    /// </summary>
    let AdverseOutput = _prefix "AdverseOutput"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Output"></see>
    /// </summary>
    let Output = _prefix "Output"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDemandState"></see>
    /// </summary>
    let hasDemandState = _prefix "hasDemandState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Undemanded"></see>
    /// </summary>
    let Undemanded = _prefix "Undemanded"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AdverseProcess"></see>
    /// </summary>
    let AdverseProcess = _prefix "AdverseProcess"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Authenticating"></see>
    /// </summary>
    let Authenticating = _prefix "Authenticating"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutput"></see>
    /// </summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Authentication"></see>
    /// </summary>
    let Authentication = _prefix "Authentication"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Availability"></see>
    /// </summary>
    let Availability = _prefix "Availability"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAvailabilityState"></see>
    /// </summary>
    let hasAvailabilityState = _prefix "hasAvailabilityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Available"></see>
    /// </summary>
    let Available = _prefix "Available"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AvailabilityState"></see>
    /// </summary>
    let AvailabilityState = _prefix "AvailabilityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Unavailable"></see>
    /// </summary>
    let Unavailable = _prefix "Unavailable"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Biphasic"></see>
    /// </summary>
    let Biphasic = _prefix "Biphasic"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#CourseMode"></see>
    /// </summary>
    let CourseMode = _prefix "CourseMode"
    /// <summary>
    /// Human prenatal existence comprising embryonic and foetal phase.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Phasic"></see></summary>
    let Phasic = _prefix "Phasic"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Cause"></see>
    /// </summary>
    let Cause = _prefix "Cause"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Causing"></see>
    /// </summary>
    let Causing = _prefix "Causing"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasInput"></see>
    /// </summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Effect"></see>
    /// </summary>
    let Effect = _prefix "Effect"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Certain"></see>
    /// </summary>
    let Certain = _prefix "Certain"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#OutputLikelihood"></see>
    /// </summary>
    let OutputLikelihood = _prefix "OutputLikelihood"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Completed"></see>
    /// </summary>
    let Completed = _prefix "Completed"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#CompletionState"></see>
    /// </summary>
    let CompletionState = _prefix "CompletionState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Completing"></see>
    /// </summary>
    let Completing = _prefix "Completing"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Completion"></see>
    /// </summary>
    let Completion = _prefix "Completion"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#outputOf"></see>
    /// </summary>
    let outputOf = _prefix "outputOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#UnCompleted"></see>
    /// </summary>
    let UnCompleted = _prefix "UnCompleted"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Condition"></see>
    /// </summary>
    let Condition = _prefix "Condition"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Reason"></see>
    /// </summary>
    let Reason = _prefix "Reason"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Created"></see>
    /// </summary>
    let Created = _prefix "Created"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Creating"></see>
    /// </summary>
    let Creating = _prefix "Creating"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Creation"></see>
    /// </summary>
    let Creation = _prefix "Creation"
    /// <summary>
    /// E.g. a clinical finding, e.g. fever, as object of a clinical evaluation of a body temperature measurement; a disease as object of a diagnosis; a drug product as object of a prescription.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasObject"></see></summary>
    let hasObject = _prefix "hasObject"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasState"></see>
    /// </summary>
    let hasState = _prefix "hasState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Cyclic"></see>
    /// </summary>
    let Cyclic = _prefix "Cyclic"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Day"></see>
    /// </summary>
    let Day = _prefix "Day"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDuration"></see>
    /// </summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Delivering"></see>
    /// </summary>
    let Delivering = _prefix "Delivering"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Delivery"></see>
    /// </summary>
    let Delivery = _prefix "Delivery"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#DemandState"></see>
    /// </summary>
    let DemandState = _prefix "DemandState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Demanded"></see>
    /// </summary>
    let Demanded = _prefix "Demanded"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosing"></see>
    /// </summary>
    let Diagnosing = _prefix "Diagnosing"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosis"></see>
    /// </summary>
    let Diagnosis = _prefix "Diagnosis"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#DiagnosisState"></see>
    /// </summary>
    let DiagnosisState = _prefix "DiagnosisState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Suspected"></see>
    /// </summary>
    let Suspected = _prefix "Suspected"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#UnSuspected"></see>
    /// </summary>
    let UnSuspected = _prefix "UnSuspected"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Verified"></see>
    /// </summary>
    let Verified = _prefix "Verified"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#UnVerified"></see>
    /// </summary>
    let UnVerified = _prefix "UnVerified"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Educating"></see>
    /// </summary>
    let Educating = _prefix "Educating"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Procedure"></see>
    /// </summary>
    let Procedure = _prefix "Procedure"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Education"></see>
    /// </summary>
    let Education = _prefix "Education"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#EndingMode"></see>
    /// </summary>
    let EndingMode = _prefix "EndingMode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluated"></see>
    /// </summary>
    let Evaluated = _prefix "Evaluated"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluating"></see>
    /// </summary>
    let Evaluating = _prefix "Evaluating"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluation"></see>
    /// </summary>
    let Evaluation = _prefix "Evaluation"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Examination"></see>
    /// </summary>
    let Examination = _prefix "Examination"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Examining"></see>
    /// </summary>
    let Examining = _prefix "Examining"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Examined"></see>
    /// </summary>
    let Examined = _prefix "Examined"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Existence"></see>
    /// </summary>
    let Existence = _prefix "Existence"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Experimental"></see>
    /// </summary>
    let Experimental = _prefix "Experimental"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Fast"></see>
    /// </summary>
    let Fast = _prefix "Fast"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#FinalOutput"></see>
    /// </summary>
    let FinalOutput = _prefix "FinalOutput"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Finding"></see>
    /// </summary>
    let Finding = _prefix "Finding"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Friday"></see>
    /// </summary>
    let Friday = _prefix "Friday"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Weekday"></see>
    /// </summary>
    let Weekday = _prefix "Weekday"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Future"></see>
    /// </summary>
    let Future = _prefix "Future"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Gradual"></see>
    /// </summary>
    let Gradual = _prefix "Gradual"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#OnsetMode"></see>
    /// </summary>
    let OnsetMode = _prefix "OnsetMode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Guideline"></see>
    /// </summary>
    let Guideline = _prefix "Guideline"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#HighPriority"></see>
    /// </summary>
    let HighPriority = _prefix "HighPriority"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#PriorityState"></see>
    /// </summary>
    let PriorityState = _prefix "PriorityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Input"></see>
    /// </summary>
    let Input = _prefix "Input"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Intent"></see>
    /// </summary>
    let Intent = _prefix "Intent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#IntentionState"></see>
    /// </summary>
    let IntentionState = _prefix "IntentionState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Intentional"></see>
    /// </summary>
    let Intentional = _prefix "Intentional"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Unintentional"></see>
    /// </summary>
    let Unintentional = _prefix "Unintentional"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Interacting"></see>
    /// </summary>
    let Interacting = _prefix "Interacting"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Interaction"></see>
    /// </summary>
    let Interaction = _prefix "Interaction"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#IntermediateOutput"></see>
    /// </summary>
    let IntermediateOutput = _prefix "IntermediateOutput"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#IntermediatelySusceptible"></see>
    /// </summary>
    let IntermediatelySusceptible = _prefix "IntermediatelySusceptible"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#SusceptibilityState"></see>
    /// </summary>
    let SusceptibilityState = _prefix "SusceptibilityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Intermittent"></see>
    /// </summary>
    let Intermittent = _prefix "Intermittent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Invalid"></see>
    /// </summary>
    let Invalid = _prefix "Invalid"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#ValidityState"></see>
    /// </summary>
    let ValidityState = _prefix "ValidityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthenticating"></see>
    /// </summary>
    let LegalAuthenticating = _prefix "LegalAuthenticating"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthentication"></see>
    /// </summary>
    let LegalAuthentication = _prefix "LegalAuthentication"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Likelihood"></see>
    /// </summary>
    let Likelihood = _prefix "Likelihood"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Likely"></see>
    /// </summary>
    let Likely = _prefix "Likely"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#LowPriority"></see>
    /// </summary>
    let LowPriority = _prefix "LowPriority"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Method"></see>
    /// </summary>
    let Method = _prefix "Method"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Modification"></see>
    /// </summary>
    let Modification = _prefix "Modification"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Modifying"></see>
    /// </summary>
    let Modifying = _prefix "Modifying"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Modified"></see>
    /// </summary>
    let Modified = _prefix "Modified"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Monday"></see>
    /// </summary>
    let Monday = _prefix "Monday"
    /// <summary>
    /// Near sure.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#MostLikely"></see></summary>
    let MostLikely = _prefix "MostLikely"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#MostUnlikely"></see>
    /// </summary>
    let MostUnlikely = _prefix "MostUnlikely"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Observable"></see>
    /// </summary>
    let Observable = _prefix "Observable"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Order"></see>
    /// </summary>
    let Order = _prefix "Order"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Ordering"></see>
    /// </summary>
    let Ordering = _prefix "Ordering"
    /// <summary>
    /// E.g. past 3 months: before now.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Past"></see></summary>
    let Past = _prefix "Past"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Pathway"></see>
    /// </summary>
    let Pathway = _prefix "Pathway"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Persistent"></see>
    /// </summary>
    let Persistent = _prefix "Persistent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Plan"></see>
    /// </summary>
    let Plan = _prefix "Plan"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Planning"></see>
    /// </summary>
    let Planning = _prefix "Planning"
    /// <summary>
    /// E.g. previous 3 months: before current month.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Previous"></see></summary>
    let Previous = _prefix "Previous"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#RelativeContraindication"></see>
    /// </summary>
    let RelativeContraindication = _prefix "RelativeContraindication"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#RelativeIndication"></see>
    /// </summary>
    let RelativeIndication = _prefix "RelativeIndication"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Request"></see>
    /// </summary>
    let Request = _prefix "Request"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Requesting"></see>
    /// </summary>
    let Requesting = _prefix "Requesting"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Resistant"></see>
    /// </summary>
    let Resistant = _prefix "Resistant"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Risk"></see>
    /// </summary>
    let Risk = _prefix "Risk"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#RiskFactor"></see>
    /// </summary>
    let RiskFactor = _prefix "RiskFactor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Routine"></see>
    /// </summary>
    let Routine = _prefix "Routine"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Saturday"></see>
    /// </summary>
    let Saturday = _prefix "Saturday"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Slow"></see>
    /// </summary>
    let Slow = _prefix "Slow"
    /// <summary>
    /// E.g. a business enterprise paying for radio or television programming in return for advertising time.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Sponsoring"></see></summary>
    let Sponsoring = _prefix "Sponsoring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Stage"></see>
    /// </summary>
    let Stage = _prefix "Stage"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Staging"></see>
    /// </summary>
    let Staging = _prefix "Staging"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Strategy"></see>
    /// </summary>
    let Strategy = _prefix "Strategy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Subacute"></see>
    /// </summary>
    let Subacute = _prefix "Subacute"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Submission"></see>
    /// </summary>
    let Submission = _prefix "Submission"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Submitting"></see>
    /// </summary>
    let Submitting = _prefix "Submitting"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#SubmissionState"></see>
    /// </summary>
    let SubmissionState = _prefix "SubmissionState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Submitted"></see>
    /// </summary>
    let Submitted = _prefix "Submitted"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#UnSubmitted"></see>
    /// </summary>
    let UnSubmitted = _prefix "UnSubmitted"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Sudden"></see>
    /// </summary>
    let Sudden = _prefix "Sudden"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Sunday"></see>
    /// </summary>
    let Sunday = _prefix "Sunday"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Susceptible"></see>
    /// </summary>
    let Susceptible = _prefix "Susceptible"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Thursday"></see>
    /// </summary>
    let Thursday = _prefix "Thursday"
    /// <summary>
    /// Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Transfer"></see></summary>
    let Transfer = _prefix "Transfer"
    /// <summary>
    /// Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Transferring"></see></summary>
    let Transferring = _prefix "Transferring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Tuesday"></see>
    /// </summary>
    let Tuesday = _prefix "Tuesday"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Unavailability"></see>
    /// </summary>
    let Unavailability = _prefix "Unavailability"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Unlikely"></see>
    /// </summary>
    let Unlikely = _prefix "Unlikely"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Urgent"></see>
    /// </summary>
    let Urgent = _prefix "Urgent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Valid"></see>
    /// </summary>
    let Valid = _prefix "Valid"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Validating"></see>
    /// </summary>
    let Validating = _prefix "Validating"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Validation"></see>
    /// </summary>
    let Validation = _prefix "Validation"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Wednesday"></see>
    /// </summary>
    let Wednesday = _prefix "Wednesday"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Week"></see>
    /// </summary>
    let Week = _prefix "Week"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#after"></see>
    /// </summary>
    let after = _prefix "after"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#timeRelatedTo"></see>
    /// </summary>
    let timeRelatedTo = _prefix "timeRelatedTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#before"></see>
    /// </summary>
    let before = _prefix "before"
    /// <summary>
    /// E.g. a diagnosis, e.g. infection, based on an evaluation, e.g. fever, in turn based on an examination, e.g. body temperature measurement.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#basedOn"></see></summary>
    let basedOn = _prefix "basedOn"
    /// <summary>
    /// E.g. an examination, e.g. body temperature measurement, as basis for an evaluation, e.g. fever, in turn basis for a diagnosis, e.g. infection.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#basisFor"></see></summary>
    let basisFor = _prefix "basisFor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#beginDate"></see>
    /// </summary>
    let beginDate = _prefix "beginDate"
    /// <summary>
    /// Using the Unix Epoch time.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#begins"></see></summary>
    let begins = _prefix "begins"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsAfter"></see>
    /// </summary>
    let beginsAfter = _prefix "beginsAfter"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsBefore"></see>
    /// </summary>
    let beginsBefore = _prefix "beginsBefore"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsDuring"></see>
    /// </summary>
    let beginsDuring = _prefix "beginsDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#causedBy"></see>
    /// </summary>
    let causedBy = _prefix "causedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#causes"></see>
    /// </summary>
    let causes = _prefix "causes"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#compliesWith"></see>
    /// </summary>
    let compliesWith = _prefix "compliesWith"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#confirmedBy"></see>
    /// </summary>
    let confirmedBy = _prefix "confirmedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#confirms"></see>
    /// </summary>
    let confirms = _prefix "confirms"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#contraindicatedBy"></see>
    /// </summary>
    let contraindicatedBy = _prefix "contraindicatedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#contraindicates"></see>
    /// </summary>
    let contraindicates = _prefix "contraindicates"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#createdBy"></see>
    /// </summary>
    let createdBy = _prefix "createdBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreated"></see>
    /// </summary>
    let hasCreated = _prefix "hasCreated"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#objectOf"></see>
    /// </summary>
    let objectOf = _prefix "objectOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#createdIn"></see>
    /// </summary>
    let createdIn = _prefix "createdIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#outputObjectOf"></see>
    /// </summary>
    let outputObjectOf = _prefix "outputObjectOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinCreated"></see>
    /// </summary>
    let whereinCreated = _prefix "whereinCreated"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#creationOf"></see>
    /// </summary>
    let creationOf = _prefix "creationOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveredIn"></see>
    /// </summary>
    let deliveredIn = _prefix "deliveredIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinDelivered"></see>
    /// </summary>
    let whereinDelivered = _prefix "whereinDelivered"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveredTo"></see>
    /// </summary>
    let deliveredTo = _prefix "deliveredTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveryOf"></see>
    /// </summary>
    let deliveryOf = _prefix "deliveryOf"
    /// <summary>
    /// The longer ago, the broader a timescope; e.g. diagnosed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; diagnosed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; diagnosed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; diagnosed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosedDuring"></see></summary>
    let diagnosedDuring = _prefix "diagnosedDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosedIn"></see>
    /// </summary>
    let diagnosedIn = _prefix "diagnosedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#during"></see>
    /// </summary>
    let during = _prefix "during"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosisOf"></see>
    /// </summary>
    let diagnosisOf = _prefix "diagnosisOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endProcedureOf"></see>
    /// </summary>
    let endProcedureOf = _prefix "endProcedureOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#subProcedureOf"></see>
    /// </summary>
    let subProcedureOf = _prefix "subProcedureOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEndProcedure"></see>
    /// </summary>
    let hasEndProcedure = _prefix "hasEndProcedure"
    /// <summary>
    /// Using the Unix Epoch time; related to event:hasDateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#ends"></see></summary>
    let ends = _prefix "ends"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endsAfter"></see>
    /// </summary>
    let endsAfter = _prefix "endsAfter"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endsBefore"></see>
    /// </summary>
    let endsBefore = _prefix "endsBefore"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endsDuring"></see>
    /// </summary>
    let endsDuring = _prefix "endsDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedBy"></see>
    /// </summary>
    let evaluatedBy = _prefix "evaluatedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluated"></see>
    /// </summary>
    let hasEvaluated = _prefix "hasEvaluated"
    /// <summary>
    /// The longer ago, the broader a timescope; e.g. evaluated in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; evaluated in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; evaluated last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; evaluated Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedDuring"></see></summary>
    let evaluatedDuring = _prefix "evaluatedDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedIn"></see>
    /// </summary>
    let evaluatedIn = _prefix "evaluatedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#inputOf"></see>
    /// </summary>
    let inputOf = _prefix "inputOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluationOf"></see>
    /// </summary>
    let evaluationOf = _prefix "evaluationOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#examinationOf"></see>
    /// </summary>
    let examinationOf = _prefix "examinationOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#examinedBy"></see>
    /// </summary>
    let examinedBy = _prefix "examinedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasExamining"></see>
    /// </summary>
    let hasExamining = _prefix "hasExamining"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasExamined"></see>
    /// </summary>
    let hasExamined = _prefix "hasExamined"
    /// <summary>
    /// The longer ago, the broader a timescope; e.g. examined in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; examined in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; examined last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; examined Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#examinedDuring"></see></summary>
    let examinedDuring = _prefix "examinedDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#examiningOf"></see>
    /// </summary>
    let examiningOf = _prefix "examiningOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#exists"></see>
    /// </summary>
    let exists = _prefix "exists"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#existsOn"></see>
    /// </summary>
    let existsOn = _prefix "existsOn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#expires"></see>
    /// </summary>
    let expires = _prefix "expires"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#gotDelivered"></see>
    /// </summary>
    let gotDelivered = _prefix "gotDelivered"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#gotExamined"></see>
    /// </summary>
    let gotExamined = _prefix "gotExamined"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#gotOrdered"></see>
    /// </summary>
    let gotOrdered = _prefix "gotOrdered"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#orderedFor"></see>
    /// </summary>
    let orderedFor = _prefix "orderedFor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAdverseOutput"></see>
    /// </summary>
    let hasAdverseOutput = _prefix "hasAdverseOutput"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAge"></see>
    /// </summary>
    let hasAge = _prefix "hasAge"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionDateTime"></see>
    /// </summary>
    let hasCompletionDateTime = _prefix "hasCompletionDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionState"></see>
    /// </summary>
    let hasCompletionState = _prefix "hasCompletionState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasContraindicationDateTime"></see>
    /// </summary>
    let hasContraindicationDateTime = _prefix "hasContraindicationDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDateTime"></see>
    /// </summary>
    let hasDateTime = _prefix "hasDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCourseMode"></see>
    /// </summary>
    let hasCourseMode = _prefix "hasCourseMode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreation"></see>
    /// </summary>
    let hasCreation = _prefix "hasCreation"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDate"></see>
    /// </summary>
    let hasCreationDate = _prefix "hasCreationDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDateTime"></see>
    /// </summary>
    let hasCreationDateTime = _prefix "hasCreationDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreator"></see>
    /// </summary>
    let hasCreator = _prefix "hasCreator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDate"></see>
    /// </summary>
    let hasDate = _prefix "hasDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDateTime"></see>
    /// </summary>
    let hasDeliveryDateTime = _prefix "hasDeliveryDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDelay"></see>
    /// </summary>
    let hasDeliveryDelay = _prefix "hasDeliveryDelay"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosis"></see>
    /// </summary>
    let hasDiagnosis = _prefix "hasDiagnosis"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisDateTime"></see>
    /// </summary>
    let hasDiagnosisDateTime = _prefix "hasDiagnosisDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisState"></see>
    /// </summary>
    let hasDiagnosisState = _prefix "hasDiagnosisState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDonor"></see>
    /// </summary>
    let hasDonor = _prefix "hasDonor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubProcedure"></see>
    /// </summary>
    let hasSubProcedure = _prefix "hasSubProcedure"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEndingMode"></see>
    /// </summary>
    let hasEndingMode = _prefix "hasEndingMode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluation"></see>
    /// </summary>
    let hasEvaluation = _prefix "hasEvaluation"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluationDateTime"></see>
    /// </summary>
    let hasEvaluationDateTime = _prefix "hasEvaluationDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvent"></see>
    /// </summary>
    let hasEvent = _prefix "hasEvent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasFindingDateTime"></see>
    /// </summary>
    let hasFindingDateTime = _prefix "hasFindingDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIndicationDateTime"></see>
    /// </summary>
    let hasIndicationDateTime = _prefix "hasIndicationDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#indicatedBy"></see>
    /// </summary>
    let indicatedBy = _prefix "indicatedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIntent"></see>
    /// </summary>
    let hasIntent = _prefix "hasIntent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIntentionState"></see>
    /// </summary>
    let hasIntentionState = _prefix "hasIntentionState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLastUpdateDateTime"></see>
    /// </summary>
    let hasLastUpdateDateTime = _prefix "hasLastUpdateDateTime"
    /// <summary>
    /// As used in an N3 rule.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionDateTime"></see></summary>
    let hasLatestSubmissionDateTime = _prefix "hasLatestSubmissionDateTime"
    /// <summary>
    /// As used in an N3 rule.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionState"></see></summary>
    let hasLatestSubmissionState = _prefix "hasLatestSubmissionState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionState"></see>
    /// </summary>
    let hasSubmissionState = _prefix "hasSubmissionState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModification"></see>
    /// </summary>
    let hasModification = _prefix "hasModification"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModificationDateTime"></see>
    /// </summary>
    let hasModificationDateTime = _prefix "hasModificationDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModified"></see>
    /// </summary>
    let hasModified = _prefix "hasModified"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModifier"></see>
    /// </summary>
    let hasModifier = _prefix "hasModifier"
    /// <summary>
    /// Using the Unix Epoch time.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasNow"></see></summary>
    let hasNow = _prefix "hasNow"
    /// <summary>
    /// A snapshot is an event with coinciding beginning and end.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDateTime"></see></summary>
    let hasSnapshotDateTime = _prefix "hasSnapshotDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasNowDate"></see>
    /// </summary>
    let hasNowDate = _prefix "hasNowDate"
    /// <summary>
    /// A snapshot is an event with coinciding beginning and end.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDate"></see></summary>
    let hasSnapshotDate = _prefix "hasSnapshotDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOnsetMode"></see>
    /// </summary>
    let hasOnsetMode = _prefix "hasOnsetMode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOrderDateTime"></see>
    /// </summary>
    let hasOrderDateTime = _prefix "hasOrderDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDate"></see>
    /// </summary>
    let hasOriginationDate = _prefix "hasOriginationDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDateTime"></see>
    /// </summary>
    let hasOriginationDateTime = _prefix "hasOriginationDateTime"
    /// <summary>
    /// Related to event:ends
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputDateTime"></see></summary>
    let hasOutputDateTime = _prefix "hasOutputDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputLikelihood"></see>
    /// </summary>
    let hasOutputLikelihood = _prefix "hasOutputLikelihood"
    /// <summary>
    /// E.g. a clinical finding, e.g. fever, as object of output of clinical evaluating of a body temperature measurement; a disease as object of a diagnosing; a drug product as object of a prescribing.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputObject"></see></summary>
    let hasOutputObject = _prefix "hasOutputObject"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasPathway"></see>
    /// </summary>
    let hasPathway = _prefix "hasPathway"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasPriorityState"></see>
    /// </summary>
    let hasPriorityState = _prefix "hasPriorityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasReason"></see>
    /// </summary>
    let hasReason = _prefix "hasReason"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasRecipient"></see>
    /// </summary>
    let hasRecipient = _prefix "hasRecipient"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasRiskFactor"></see>
    /// </summary>
    let hasRiskFactor = _prefix "hasRiskFactor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameBeginningAs"></see>
    /// </summary>
    let hasSameBeginningAs = _prefix "hasSameBeginningAs"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameDurationAs"></see>
    /// </summary>
    let hasSameDurationAs = _prefix "hasSameDurationAs"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameEndAs"></see>
    /// </summary>
    let hasSameEndAs = _prefix "hasSameEndAs"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameTimeAs"></see>
    /// </summary>
    let hasSameTimeAs = _prefix "hasSameTimeAs"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSponsor"></see>
    /// </summary>
    let hasSponsor = _prefix "hasSponsor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasStage"></see>
    /// </summary>
    let hasStage = _prefix "hasStage"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasStartProcedure"></see>
    /// </summary>
    let hasStartProcedure = _prefix "hasStartProcedure"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubAction"></see>
    /// </summary>
    let hasSubAction = _prefix "hasSubAction"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#includes"></see>
    /// </summary>
    let includes = _prefix "includes"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubOutput"></see>
    /// </summary>
    let hasSubOutput = _prefix "hasSubOutput"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionDateTime"></see>
    /// </summary>
    let hasSubmissionDateTime = _prefix "hasSubmissionDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityState"></see>
    /// </summary>
    let hasSusceptibilityState = _prefix "hasSusceptibilityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityStateFor"></see>
    /// </summary>
    let hasSusceptibilityStateFor = _prefix "hasSusceptibilityStateFor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#susceptibilityStateFor"></see>
    /// </summary>
    let susceptibilityStateFor = _prefix "susceptibilityStateFor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasValidationDateTime"></see>
    /// </summary>
    let hasValidationDateTime = _prefix "hasValidationDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasValidityState"></see>
    /// </summary>
    let hasValidityState = _prefix "hasValidityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasVanishingDateTime"></see>
    /// </summary>
    let hasVanishingDateTime = _prefix "hasVanishingDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasWarning"></see>
    /// </summary>
    let hasWarning = _prefix "hasWarning"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasWeekday"></see>
    /// </summary>
    let hasWeekday = _prefix "hasWeekday"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#indicates"></see>
    /// </summary>
    let indicates = _prefix "indicates"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#intermediatelySusceptibleTo"></see>
    /// </summary>
    let intermediatelySusceptibleTo = _prefix "intermediatelySusceptibleTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#wheretoSusceptibilityState"></see>
    /// </summary>
    let wheretoSusceptibilityState = _prefix "wheretoSusceptibilityState"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#isAssociatedWith"></see>
    /// </summary>
    let isAssociatedWith = _prefix "isAssociatedWith"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#isReasonFor"></see>
    /// </summary>
    let isReasonFor = _prefix "isReasonFor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#modificationOf"></see>
    /// </summary>
    let modificationOf = _prefix "modificationOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#modifiedBy"></see>
    /// </summary>
    let modifiedBy = _prefix "modifiedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#modifiedIn"></see>
    /// </summary>
    let modifiedIn = _prefix "modifiedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinModified"></see>
    /// </summary>
    let whereinModified = _prefix "whereinModified"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#nonCompliantWith"></see>
    /// </summary>
    let nonCompliantWith = _prefix "nonCompliantWith"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#notPerformedDuring"></see>
    /// </summary>
    let notPerformedDuring = _prefix "notPerformedDuring"
    /// <summary>
    /// The longer ago, the broader a timescope; e.g. observed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; observed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; observed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; observed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#observedDuring"></see></summary>
    let observedDuring = _prefix "observedDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#obtainedBy"></see>
    /// </summary>
    let obtainedBy = _prefix "obtainedBy"
    /// <summary>
    /// The longer ago, the broader a timescope; e.g. obtained in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; obtained in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; obtained last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; obtained Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#obtainedDuring"></see></summary>
    let obtainedDuring = _prefix "obtainedDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#openFrom"></see>
    /// </summary>
    let openFrom = _prefix "openFrom"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#openUntil"></see>
    /// </summary>
    let openUntil = _prefix "openUntil"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#orderOf"></see>
    /// </summary>
    let orderOf = _prefix "orderOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#orderedTo"></see>
    /// </summary>
    let orderedTo = _prefix "orderedTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#originatedIn"></see>
    /// </summary>
    let originatedIn = _prefix "originatedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#overlaps"></see>
    /// </summary>
    let overlaps = _prefix "overlaps"
    /// <summary>
    /// The longer ago, the broader a timescope; e.g. performed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; performed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; performed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; performed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#performedDuring"></see></summary>
    let performedDuring = _prefix "performedDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#performedIn"></see>
    /// </summary>
    let performedIn = _prefix "performedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#planOf"></see>
    /// </summary>
    let planOf = _prefix "planOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#plannedIn"></see>
    /// </summary>
    let plannedIn = _prefix "plannedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#resistantTo"></see>
    /// </summary>
    let resistantTo = _prefix "resistantTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#riskFactorOf"></see>
    /// </summary>
    let riskFactorOf = _prefix "riskFactorOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#stageOf"></see>
    /// </summary>
    let stageOf = _prefix "stageOf"
    /// <summary>
    /// The longer ago, the broader a timescope; e.g. staged in 1986: formally stating a period 01/01/1986-31/12/1986; staged last year in May: stating a period 01/05/2010-31/05/2010; staged last week: stating a day 01/01/2012; staged yesterday: stating a moment 20/01/2012, 02PM.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#stagedDuring"></see></summary>
    let stagedDuring = _prefix "stagedDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#startProcedureOf"></see>
    /// </summary>
    let startProcedureOf = _prefix "startProcedureOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#stateOf"></see>
    /// </summary>
    let stateOf = _prefix "stateOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#subActionOf"></see>
    /// </summary>
    let subActionOf = _prefix "subActionOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#subOutputOf"></see>
    /// </summary>
    let subOutputOf = _prefix "subOutputOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#susceptibleTo"></see>
    /// </summary>
    let susceptibleTo = _prefix "susceptibleTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#takesLessLongThan"></see>
    /// </summary>
    let takesLessLongThan = _prefix "takesLessLongThan"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#takesLongerThan"></see>
    /// </summary>
    let takesLongerThan = _prefix "takesLongerThan"
    /// <summary>
    /// Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#transferOf"></see></summary>
    let transferOf = _prefix "transferOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#validationOf"></see>
    /// </summary>
    let validationOf = _prefix "validationOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinDiagnosed"></see>
    /// </summary>
    let whereinDiagnosed = _prefix "whereinDiagnosed"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinEvaluated"></see>
    /// </summary>
    let whereinEvaluated = _prefix "whereinEvaluated"
    /// <summary>
    /// Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinTransferred"></see></summary>
    let whereinTransferred = _prefix "whereinTransferred"
