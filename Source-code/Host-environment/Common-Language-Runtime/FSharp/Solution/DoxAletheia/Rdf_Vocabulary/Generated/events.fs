namespace http.eulersharp.sourceforge.net._2003._03swap._event.hash

open DoxAletheia.Rdf_Vocabulary

module events =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/event#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteContraindication"></see>
    /// </summary>
    let AbsoluteContraindication =
        Namespaced_IRI.parse _namespace_name "AbsoluteContraindication" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Contraindication"></see>
    /// </summary>
    let Contraindication =
        Namespaced_IRI.parse _namespace_name "Contraindication" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteIndication"></see>
    /// </summary>
    let AbsoluteIndication =
        Namespaced_IRI.parse _namespace_name "AbsoluteIndication" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Indication"></see>
    /// </summary>
    let Indication = Namespaced_IRI.parse _namespace_name "Indication" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Process"></see>
    /// </summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AdverseOutput"></see>
    /// </summary>
    let AdverseOutput =
        Namespaced_IRI.parse _namespace_name "AdverseOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Output"></see>
    /// </summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDemandState"></see>
    /// </summary>
    let hasDemandState =
        Namespaced_IRI.parse _namespace_name "hasDemandState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Undemanded"></see>
    /// </summary>
    let Undemanded = Namespaced_IRI.parse _namespace_name "Undemanded" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AdverseProcess"></see>
    /// </summary>
    let AdverseProcess =
        Namespaced_IRI.parse _namespace_name "AdverseProcess" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Authenticating"></see>
    /// </summary>
    let Authenticating =
        Namespaced_IRI.parse _namespace_name "Authenticating" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutput"></see>
    /// </summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Authentication"></see>
    /// </summary>
    let Authentication =
        Namespaced_IRI.parse _namespace_name "Authentication" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Availability"></see>
    /// </summary>
    let Availability =
        Namespaced_IRI.parse _namespace_name "Availability" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAvailabilityState"></see>
    /// </summary>
    let hasAvailabilityState =
        Namespaced_IRI.parse _namespace_name "hasAvailabilityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Available"></see>
    /// </summary>
    let Available = Namespaced_IRI.parse _namespace_name "Available" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#AvailabilityState"></see>
    /// </summary>
    let AvailabilityState =
        Namespaced_IRI.parse _namespace_name "AvailabilityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Unavailable"></see>
    /// </summary>
    let Unavailable =
        Namespaced_IRI.parse _namespace_name "Unavailable" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Biphasic"></see>
    /// </summary>
    let Biphasic = Namespaced_IRI.parse _namespace_name "Biphasic" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#CourseMode"></see>
    /// </summary>
    let CourseMode = Namespaced_IRI.parse _namespace_name "CourseMode" |> NamespacedName
    /// <summary>
    /// Human prenatal existence comprising embryonic and foetal phase.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Phasic"></see></summary>
    let Phasic = Namespaced_IRI.parse _namespace_name "Phasic" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Cause"></see>
    /// </summary>
    let Cause = Namespaced_IRI.parse _namespace_name "Cause" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Causing"></see>
    /// </summary>
    let Causing = Namespaced_IRI.parse _namespace_name "Causing" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasInput"></see>
    /// </summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Effect"></see>
    /// </summary>
    let Effect = Namespaced_IRI.parse _namespace_name "Effect" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Certain"></see>
    /// </summary>
    let Certain = Namespaced_IRI.parse _namespace_name "Certain" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#OutputLikelihood"></see>
    /// </summary>
    let OutputLikelihood =
        Namespaced_IRI.parse _namespace_name "OutputLikelihood" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Completed"></see>
    /// </summary>
    let Completed = Namespaced_IRI.parse _namespace_name "Completed" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#CompletionState"></see>
    /// </summary>
    let CompletionState =
        Namespaced_IRI.parse _namespace_name "CompletionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Completing"></see>
    /// </summary>
    let Completing = Namespaced_IRI.parse _namespace_name "Completing" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Completion"></see>
    /// </summary>
    let Completion = Namespaced_IRI.parse _namespace_name "Completion" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#outputOf"></see>
    /// </summary>
    let outputOf = Namespaced_IRI.parse _namespace_name "outputOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#UnCompleted"></see>
    /// </summary>
    let UnCompleted =
        Namespaced_IRI.parse _namespace_name "UnCompleted" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Condition"></see>
    /// </summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Reason"></see>
    /// </summary>
    let Reason = Namespaced_IRI.parse _namespace_name "Reason" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Created"></see>
    /// </summary>
    let Created = Namespaced_IRI.parse _namespace_name "Created" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Creating"></see>
    /// </summary>
    let Creating = Namespaced_IRI.parse _namespace_name "Creating" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Creation"></see>
    /// </summary>
    let Creation = Namespaced_IRI.parse _namespace_name "Creation" |> NamespacedName
    /// <summary>
    /// E.g. a clinical finding, e.g. fever, as object of a clinical evaluation of a body temperature measurement; a disease as object of a diagnosis; a drug product as object of a prescription.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasObject"></see></summary>
    let hasObject = Namespaced_IRI.parse _namespace_name "hasObject" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasState"></see>
    /// </summary>
    let hasState = Namespaced_IRI.parse _namespace_name "hasState" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Cyclic"></see>
    /// </summary>
    let Cyclic = Namespaced_IRI.parse _namespace_name "Cyclic" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Day"></see>
    /// </summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDuration"></see>
    /// </summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Delivering"></see>
    /// </summary>
    let Delivering = Namespaced_IRI.parse _namespace_name "Delivering" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Delivery"></see>
    /// </summary>
    let Delivery = Namespaced_IRI.parse _namespace_name "Delivery" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#DemandState"></see>
    /// </summary>
    let DemandState =
        Namespaced_IRI.parse _namespace_name "DemandState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Demanded"></see>
    /// </summary>
    let Demanded = Namespaced_IRI.parse _namespace_name "Demanded" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosing"></see>
    /// </summary>
    let Diagnosing = Namespaced_IRI.parse _namespace_name "Diagnosing" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosis"></see>
    /// </summary>
    let Diagnosis = Namespaced_IRI.parse _namespace_name "Diagnosis" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#DiagnosisState"></see>
    /// </summary>
    let DiagnosisState =
        Namespaced_IRI.parse _namespace_name "DiagnosisState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Suspected"></see>
    /// </summary>
    let Suspected = Namespaced_IRI.parse _namespace_name "Suspected" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#UnSuspected"></see>
    /// </summary>
    let UnSuspected =
        Namespaced_IRI.parse _namespace_name "UnSuspected" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Verified"></see>
    /// </summary>
    let Verified = Namespaced_IRI.parse _namespace_name "Verified" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#UnVerified"></see>
    /// </summary>
    let UnVerified = Namespaced_IRI.parse _namespace_name "UnVerified" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Educating"></see>
    /// </summary>
    let Educating = Namespaced_IRI.parse _namespace_name "Educating" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Procedure"></see>
    /// </summary>
    let Procedure = Namespaced_IRI.parse _namespace_name "Procedure" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Education"></see>
    /// </summary>
    let Education = Namespaced_IRI.parse _namespace_name "Education" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#EndingMode"></see>
    /// </summary>
    let EndingMode = Namespaced_IRI.parse _namespace_name "EndingMode" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluated"></see>
    /// </summary>
    let Evaluated = Namespaced_IRI.parse _namespace_name "Evaluated" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluating"></see>
    /// </summary>
    let Evaluating = Namespaced_IRI.parse _namespace_name "Evaluating" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluation"></see>
    /// </summary>
    let Evaluation = Namespaced_IRI.parse _namespace_name "Evaluation" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Examination"></see>
    /// </summary>
    let Examination =
        Namespaced_IRI.parse _namespace_name "Examination" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Examining"></see>
    /// </summary>
    let Examining = Namespaced_IRI.parse _namespace_name "Examining" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Examined"></see>
    /// </summary>
    let Examined = Namespaced_IRI.parse _namespace_name "Examined" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Existence"></see>
    /// </summary>
    let Existence = Namespaced_IRI.parse _namespace_name "Existence" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Experimental"></see>
    /// </summary>
    let Experimental =
        Namespaced_IRI.parse _namespace_name "Experimental" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Fast"></see>
    /// </summary>
    let Fast = Namespaced_IRI.parse _namespace_name "Fast" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#FinalOutput"></see>
    /// </summary>
    let FinalOutput =
        Namespaced_IRI.parse _namespace_name "FinalOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Finding"></see>
    /// </summary>
    let Finding = Namespaced_IRI.parse _namespace_name "Finding" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Friday"></see>
    /// </summary>
    let Friday = Namespaced_IRI.parse _namespace_name "Friday" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Weekday"></see>
    /// </summary>
    let Weekday = Namespaced_IRI.parse _namespace_name "Weekday" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Future"></see>
    /// </summary>
    let Future = Namespaced_IRI.parse _namespace_name "Future" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Gradual"></see>
    /// </summary>
    let Gradual = Namespaced_IRI.parse _namespace_name "Gradual" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#OnsetMode"></see>
    /// </summary>
    let OnsetMode = Namespaced_IRI.parse _namespace_name "OnsetMode" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Guideline"></see>
    /// </summary>
    let Guideline = Namespaced_IRI.parse _namespace_name "Guideline" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#HighPriority"></see>
    /// </summary>
    let HighPriority =
        Namespaced_IRI.parse _namespace_name "HighPriority" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#PriorityState"></see>
    /// </summary>
    let PriorityState =
        Namespaced_IRI.parse _namespace_name "PriorityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Input"></see>
    /// </summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Intent"></see>
    /// </summary>
    let Intent = Namespaced_IRI.parse _namespace_name "Intent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#IntentionState"></see>
    /// </summary>
    let IntentionState =
        Namespaced_IRI.parse _namespace_name "IntentionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Intentional"></see>
    /// </summary>
    let Intentional =
        Namespaced_IRI.parse _namespace_name "Intentional" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Unintentional"></see>
    /// </summary>
    let Unintentional =
        Namespaced_IRI.parse _namespace_name "Unintentional" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Interacting"></see>
    /// </summary>
    let Interacting =
        Namespaced_IRI.parse _namespace_name "Interacting" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Interaction"></see>
    /// </summary>
    let Interaction =
        Namespaced_IRI.parse _namespace_name "Interaction" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#IntermediateOutput"></see>
    /// </summary>
    let IntermediateOutput =
        Namespaced_IRI.parse _namespace_name "IntermediateOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#IntermediatelySusceptible"></see>
    /// </summary>
    let IntermediatelySusceptible =
        Namespaced_IRI.parse _namespace_name "IntermediatelySusceptible" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#SusceptibilityState"></see>
    /// </summary>
    let SusceptibilityState =
        Namespaced_IRI.parse _namespace_name "SusceptibilityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Intermittent"></see>
    /// </summary>
    let Intermittent =
        Namespaced_IRI.parse _namespace_name "Intermittent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Invalid"></see>
    /// </summary>
    let Invalid = Namespaced_IRI.parse _namespace_name "Invalid" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#ValidityState"></see>
    /// </summary>
    let ValidityState =
        Namespaced_IRI.parse _namespace_name "ValidityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthenticating"></see>
    /// </summary>
    let LegalAuthenticating =
        Namespaced_IRI.parse _namespace_name "LegalAuthenticating" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthentication"></see>
    /// </summary>
    let LegalAuthentication =
        Namespaced_IRI.parse _namespace_name "LegalAuthentication" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Likelihood"></see>
    /// </summary>
    let Likelihood = Namespaced_IRI.parse _namespace_name "Likelihood" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Likely"></see>
    /// </summary>
    let Likely = Namespaced_IRI.parse _namespace_name "Likely" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#LowPriority"></see>
    /// </summary>
    let LowPriority =
        Namespaced_IRI.parse _namespace_name "LowPriority" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Method"></see>
    /// </summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Modification"></see>
    /// </summary>
    let Modification =
        Namespaced_IRI.parse _namespace_name "Modification" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Modifying"></see>
    /// </summary>
    let Modifying = Namespaced_IRI.parse _namespace_name "Modifying" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Modified"></see>
    /// </summary>
    let Modified = Namespaced_IRI.parse _namespace_name "Modified" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Monday"></see>
    /// </summary>
    let Monday = Namespaced_IRI.parse _namespace_name "Monday" |> NamespacedName
    /// <summary>
    /// Near sure.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#MostLikely"></see></summary>
    let MostLikely = Namespaced_IRI.parse _namespace_name "MostLikely" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#MostUnlikely"></see>
    /// </summary>
    let MostUnlikely =
        Namespaced_IRI.parse _namespace_name "MostUnlikely" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Observable"></see>
    /// </summary>
    let Observable = Namespaced_IRI.parse _namespace_name "Observable" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Order"></see>
    /// </summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Ordering"></see>
    /// </summary>
    let Ordering = Namespaced_IRI.parse _namespace_name "Ordering" |> NamespacedName
    /// <summary>
    /// E.g. past 3 months: before now.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Past"></see></summary>
    let Past = Namespaced_IRI.parse _namespace_name "Past" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Pathway"></see>
    /// </summary>
    let Pathway = Namespaced_IRI.parse _namespace_name "Pathway" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Persistent"></see>
    /// </summary>
    let Persistent = Namespaced_IRI.parse _namespace_name "Persistent" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Plan"></see>
    /// </summary>
    let Plan = Namespaced_IRI.parse _namespace_name "Plan" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Planning"></see>
    /// </summary>
    let Planning = Namespaced_IRI.parse _namespace_name "Planning" |> NamespacedName
    /// <summary>
    /// E.g. previous 3 months: before current month.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Previous"></see></summary>
    let Previous = Namespaced_IRI.parse _namespace_name "Previous" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#RelativeContraindication"></see>
    /// </summary>
    let RelativeContraindication =
        Namespaced_IRI.parse _namespace_name "RelativeContraindication" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#RelativeIndication"></see>
    /// </summary>
    let RelativeIndication =
        Namespaced_IRI.parse _namespace_name "RelativeIndication" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Request"></see>
    /// </summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Requesting"></see>
    /// </summary>
    let Requesting = Namespaced_IRI.parse _namespace_name "Requesting" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Resistant"></see>
    /// </summary>
    let Resistant = Namespaced_IRI.parse _namespace_name "Resistant" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Risk"></see>
    /// </summary>
    let Risk = Namespaced_IRI.parse _namespace_name "Risk" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#RiskFactor"></see>
    /// </summary>
    let RiskFactor = Namespaced_IRI.parse _namespace_name "RiskFactor" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Routine"></see>
    /// </summary>
    let Routine = Namespaced_IRI.parse _namespace_name "Routine" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Saturday"></see>
    /// </summary>
    let Saturday = Namespaced_IRI.parse _namespace_name "Saturday" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Slow"></see>
    /// </summary>
    let Slow = Namespaced_IRI.parse _namespace_name "Slow" |> NamespacedName
    /// <summary>
    /// E.g. a business enterprise paying for radio or television programming in return for advertising time.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Sponsoring"></see></summary>
    let Sponsoring = Namespaced_IRI.parse _namespace_name "Sponsoring" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Stage"></see>
    /// </summary>
    let Stage = Namespaced_IRI.parse _namespace_name "Stage" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Staging"></see>
    /// </summary>
    let Staging = Namespaced_IRI.parse _namespace_name "Staging" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Strategy"></see>
    /// </summary>
    let Strategy = Namespaced_IRI.parse _namespace_name "Strategy" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Subacute"></see>
    /// </summary>
    let Subacute = Namespaced_IRI.parse _namespace_name "Subacute" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Submission"></see>
    /// </summary>
    let Submission = Namespaced_IRI.parse _namespace_name "Submission" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Submitting"></see>
    /// </summary>
    let Submitting = Namespaced_IRI.parse _namespace_name "Submitting" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#SubmissionState"></see>
    /// </summary>
    let SubmissionState =
        Namespaced_IRI.parse _namespace_name "SubmissionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Submitted"></see>
    /// </summary>
    let Submitted = Namespaced_IRI.parse _namespace_name "Submitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#UnSubmitted"></see>
    /// </summary>
    let UnSubmitted =
        Namespaced_IRI.parse _namespace_name "UnSubmitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Sudden"></see>
    /// </summary>
    let Sudden = Namespaced_IRI.parse _namespace_name "Sudden" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Sunday"></see>
    /// </summary>
    let Sunday = Namespaced_IRI.parse _namespace_name "Sunday" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Susceptible"></see>
    /// </summary>
    let Susceptible =
        Namespaced_IRI.parse _namespace_name "Susceptible" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Thursday"></see>
    /// </summary>
    let Thursday = Namespaced_IRI.parse _namespace_name "Thursday" |> NamespacedName
    /// <summary>
    /// Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Transfer"></see></summary>
    let Transfer = Namespaced_IRI.parse _namespace_name "Transfer" |> NamespacedName

    /// <summary>
    /// Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Transferring"></see></summary>
    let Transferring =
        Namespaced_IRI.parse _namespace_name "Transferring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Tuesday"></see>
    /// </summary>
    let Tuesday = Namespaced_IRI.parse _namespace_name "Tuesday" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Unavailability"></see>
    /// </summary>
    let Unavailability =
        Namespaced_IRI.parse _namespace_name "Unavailability" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Unlikely"></see>
    /// </summary>
    let Unlikely = Namespaced_IRI.parse _namespace_name "Unlikely" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Urgent"></see>
    /// </summary>
    let Urgent = Namespaced_IRI.parse _namespace_name "Urgent" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Valid"></see>
    /// </summary>
    let Valid = Namespaced_IRI.parse _namespace_name "Valid" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Validating"></see>
    /// </summary>
    let Validating = Namespaced_IRI.parse _namespace_name "Validating" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Validation"></see>
    /// </summary>
    let Validation = Namespaced_IRI.parse _namespace_name "Validation" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Wednesday"></see>
    /// </summary>
    let Wednesday = Namespaced_IRI.parse _namespace_name "Wednesday" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#Week"></see>
    /// </summary>
    let Week = Namespaced_IRI.parse _namespace_name "Week" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#after"></see>
    /// </summary>
    let after = Namespaced_IRI.parse _namespace_name "after" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#timeRelatedTo"></see>
    /// </summary>
    let timeRelatedTo =
        Namespaced_IRI.parse _namespace_name "timeRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#before"></see>
    /// </summary>
    let before = Namespaced_IRI.parse _namespace_name "before" |> NamespacedName
    /// <summary>
    /// E.g. a diagnosis, e.g. infection, based on an evaluation, e.g. fever, in turn based on an examination, e.g. body temperature measurement.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#basedOn"></see></summary>
    let basedOn = Namespaced_IRI.parse _namespace_name "basedOn" |> NamespacedName
    /// <summary>
    /// E.g. an examination, e.g. body temperature measurement, as basis for an evaluation, e.g. fever, in turn basis for a diagnosis, e.g. infection.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#basisFor"></see></summary>
    let basisFor = Namespaced_IRI.parse _namespace_name "basisFor" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#beginDate"></see>
    /// </summary>
    let beginDate = Namespaced_IRI.parse _namespace_name "beginDate" |> NamespacedName
    /// <summary>
    /// Using the Unix Epoch time.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#begins"></see></summary>
    let begins = Namespaced_IRI.parse _namespace_name "begins" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsAfter"></see>
    /// </summary>
    let beginsAfter =
        Namespaced_IRI.parse _namespace_name "beginsAfter" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsBefore"></see>
    /// </summary>
    let beginsBefore =
        Namespaced_IRI.parse _namespace_name "beginsBefore" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsDuring"></see>
    /// </summary>
    let beginsDuring =
        Namespaced_IRI.parse _namespace_name "beginsDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#causedBy"></see>
    /// </summary>
    let causedBy = Namespaced_IRI.parse _namespace_name "causedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#causes"></see>
    /// </summary>
    let causes = Namespaced_IRI.parse _namespace_name "causes" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#compliesWith"></see>
    /// </summary>
    let compliesWith =
        Namespaced_IRI.parse _namespace_name "compliesWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#confirmedBy"></see>
    /// </summary>
    let confirmedBy =
        Namespaced_IRI.parse _namespace_name "confirmedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#confirms"></see>
    /// </summary>
    let confirms = Namespaced_IRI.parse _namespace_name "confirms" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#contraindicatedBy"></see>
    /// </summary>
    let contraindicatedBy =
        Namespaced_IRI.parse _namespace_name "contraindicatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#contraindicates"></see>
    /// </summary>
    let contraindicates =
        Namespaced_IRI.parse _namespace_name "contraindicates" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#createdBy"></see>
    /// </summary>
    let createdBy = Namespaced_IRI.parse _namespace_name "createdBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreated"></see>
    /// </summary>
    let hasCreated = Namespaced_IRI.parse _namespace_name "hasCreated" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#objectOf"></see>
    /// </summary>
    let objectOf = Namespaced_IRI.parse _namespace_name "objectOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#createdIn"></see>
    /// </summary>
    let createdIn = Namespaced_IRI.parse _namespace_name "createdIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#outputObjectOf"></see>
    /// </summary>
    let outputObjectOf =
        Namespaced_IRI.parse _namespace_name "outputObjectOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinCreated"></see>
    /// </summary>
    let whereinCreated =
        Namespaced_IRI.parse _namespace_name "whereinCreated" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#creationOf"></see>
    /// </summary>
    let creationOf = Namespaced_IRI.parse _namespace_name "creationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveredIn"></see>
    /// </summary>
    let deliveredIn =
        Namespaced_IRI.parse _namespace_name "deliveredIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinDelivered"></see>
    /// </summary>
    let whereinDelivered =
        Namespaced_IRI.parse _namespace_name "whereinDelivered" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveredTo"></see>
    /// </summary>
    let deliveredTo =
        Namespaced_IRI.parse _namespace_name "deliveredTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveryOf"></see>
    /// </summary>
    let deliveryOf = Namespaced_IRI.parse _namespace_name "deliveryOf" |> NamespacedName

    /// <summary>
    /// The longer ago, the broader a timescope; e.g. diagnosed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; diagnosed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; diagnosed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; diagnosed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosedDuring"></see></summary>
    let diagnosedDuring =
        Namespaced_IRI.parse _namespace_name "diagnosedDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosedIn"></see>
    /// </summary>
    let diagnosedIn =
        Namespaced_IRI.parse _namespace_name "diagnosedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#during"></see>
    /// </summary>
    let during = Namespaced_IRI.parse _namespace_name "during" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosisOf"></see>
    /// </summary>
    let diagnosisOf =
        Namespaced_IRI.parse _namespace_name "diagnosisOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endProcedureOf"></see>
    /// </summary>
    let endProcedureOf =
        Namespaced_IRI.parse _namespace_name "endProcedureOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#subProcedureOf"></see>
    /// </summary>
    let subProcedureOf =
        Namespaced_IRI.parse _namespace_name "subProcedureOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEndProcedure"></see>
    /// </summary>
    let hasEndProcedure =
        Namespaced_IRI.parse _namespace_name "hasEndProcedure" |> NamespacedName

    /// <summary>
    /// Using the Unix Epoch time; related to event:hasDateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#ends"></see></summary>
    let ends = Namespaced_IRI.parse _namespace_name "ends" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endsAfter"></see>
    /// </summary>
    let endsAfter = Namespaced_IRI.parse _namespace_name "endsAfter" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endsBefore"></see>
    /// </summary>
    let endsBefore = Namespaced_IRI.parse _namespace_name "endsBefore" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#endsDuring"></see>
    /// </summary>
    let endsDuring = Namespaced_IRI.parse _namespace_name "endsDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedBy"></see>
    /// </summary>
    let evaluatedBy =
        Namespaced_IRI.parse _namespace_name "evaluatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluated"></see>
    /// </summary>
    let hasEvaluated =
        Namespaced_IRI.parse _namespace_name "hasEvaluated" |> NamespacedName

    /// <summary>
    /// The longer ago, the broader a timescope; e.g. evaluated in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; evaluated in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; evaluated last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; evaluated Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedDuring"></see></summary>
    let evaluatedDuring =
        Namespaced_IRI.parse _namespace_name "evaluatedDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedIn"></see>
    /// </summary>
    let evaluatedIn =
        Namespaced_IRI.parse _namespace_name "evaluatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#inputOf"></see>
    /// </summary>
    let inputOf = Namespaced_IRI.parse _namespace_name "inputOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluationOf"></see>
    /// </summary>
    let evaluationOf =
        Namespaced_IRI.parse _namespace_name "evaluationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#examinationOf"></see>
    /// </summary>
    let examinationOf =
        Namespaced_IRI.parse _namespace_name "examinationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#examinedBy"></see>
    /// </summary>
    let examinedBy = Namespaced_IRI.parse _namespace_name "examinedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasExamining"></see>
    /// </summary>
    let hasExamining =
        Namespaced_IRI.parse _namespace_name "hasExamining" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasExamined"></see>
    /// </summary>
    let hasExamined =
        Namespaced_IRI.parse _namespace_name "hasExamined" |> NamespacedName

    /// <summary>
    /// The longer ago, the broader a timescope; e.g. examined in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; examined in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; examined last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; examined Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#examinedDuring"></see></summary>
    let examinedDuring =
        Namespaced_IRI.parse _namespace_name "examinedDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#examiningOf"></see>
    /// </summary>
    let examiningOf =
        Namespaced_IRI.parse _namespace_name "examiningOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#exists"></see>
    /// </summary>
    let exists = Namespaced_IRI.parse _namespace_name "exists" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#existsOn"></see>
    /// </summary>
    let existsOn = Namespaced_IRI.parse _namespace_name "existsOn" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#expires"></see>
    /// </summary>
    let expires = Namespaced_IRI.parse _namespace_name "expires" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#gotDelivered"></see>
    /// </summary>
    let gotDelivered =
        Namespaced_IRI.parse _namespace_name "gotDelivered" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#gotExamined"></see>
    /// </summary>
    let gotExamined =
        Namespaced_IRI.parse _namespace_name "gotExamined" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#gotOrdered"></see>
    /// </summary>
    let gotOrdered = Namespaced_IRI.parse _namespace_name "gotOrdered" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#orderedFor"></see>
    /// </summary>
    let orderedFor = Namespaced_IRI.parse _namespace_name "orderedFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAdverseOutput"></see>
    /// </summary>
    let hasAdverseOutput =
        Namespaced_IRI.parse _namespace_name "hasAdverseOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAge"></see>
    /// </summary>
    let hasAge = Namespaced_IRI.parse _namespace_name "hasAge" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionDateTime"></see>
    /// </summary>
    let hasCompletionDateTime =
        Namespaced_IRI.parse _namespace_name "hasCompletionDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionState"></see>
    /// </summary>
    let hasCompletionState =
        Namespaced_IRI.parse _namespace_name "hasCompletionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasContraindicationDateTime"></see>
    /// </summary>
    let hasContraindicationDateTime =
        Namespaced_IRI.parse _namespace_name "hasContraindicationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDateTime"></see>
    /// </summary>
    let hasDateTime =
        Namespaced_IRI.parse _namespace_name "hasDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCourseMode"></see>
    /// </summary>
    let hasCourseMode =
        Namespaced_IRI.parse _namespace_name "hasCourseMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreation"></see>
    /// </summary>
    let hasCreation =
        Namespaced_IRI.parse _namespace_name "hasCreation" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDate"></see>
    /// </summary>
    let hasCreationDate =
        Namespaced_IRI.parse _namespace_name "hasCreationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDateTime"></see>
    /// </summary>
    let hasCreationDateTime =
        Namespaced_IRI.parse _namespace_name "hasCreationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreator"></see>
    /// </summary>
    let hasCreator = Namespaced_IRI.parse _namespace_name "hasCreator" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDate"></see>
    /// </summary>
    let hasDate = Namespaced_IRI.parse _namespace_name "hasDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDateTime"></see>
    /// </summary>
    let hasDeliveryDateTime =
        Namespaced_IRI.parse _namespace_name "hasDeliveryDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDelay"></see>
    /// </summary>
    let hasDeliveryDelay =
        Namespaced_IRI.parse _namespace_name "hasDeliveryDelay" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosis"></see>
    /// </summary>
    let hasDiagnosis =
        Namespaced_IRI.parse _namespace_name "hasDiagnosis" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisDateTime"></see>
    /// </summary>
    let hasDiagnosisDateTime =
        Namespaced_IRI.parse _namespace_name "hasDiagnosisDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisState"></see>
    /// </summary>
    let hasDiagnosisState =
        Namespaced_IRI.parse _namespace_name "hasDiagnosisState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDonor"></see>
    /// </summary>
    let hasDonor = Namespaced_IRI.parse _namespace_name "hasDonor" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubProcedure"></see>
    /// </summary>
    let hasSubProcedure =
        Namespaced_IRI.parse _namespace_name "hasSubProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEndingMode"></see>
    /// </summary>
    let hasEndingMode =
        Namespaced_IRI.parse _namespace_name "hasEndingMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluation"></see>
    /// </summary>
    let hasEvaluation =
        Namespaced_IRI.parse _namespace_name "hasEvaluation" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluationDateTime"></see>
    /// </summary>
    let hasEvaluationDateTime =
        Namespaced_IRI.parse _namespace_name "hasEvaluationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvent"></see>
    /// </summary>
    let hasEvent = Namespaced_IRI.parse _namespace_name "hasEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasFindingDateTime"></see>
    /// </summary>
    let hasFindingDateTime =
        Namespaced_IRI.parse _namespace_name "hasFindingDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIndicationDateTime"></see>
    /// </summary>
    let hasIndicationDateTime =
        Namespaced_IRI.parse _namespace_name "hasIndicationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#indicatedBy"></see>
    /// </summary>
    let indicatedBy =
        Namespaced_IRI.parse _namespace_name "indicatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIntent"></see>
    /// </summary>
    let hasIntent = Namespaced_IRI.parse _namespace_name "hasIntent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIntentionState"></see>
    /// </summary>
    let hasIntentionState =
        Namespaced_IRI.parse _namespace_name "hasIntentionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLastUpdateDateTime"></see>
    /// </summary>
    let hasLastUpdateDateTime =
        Namespaced_IRI.parse _namespace_name "hasLastUpdateDateTime" |> NamespacedName

    /// <summary>
    /// As used in an N3 rule.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionDateTime"></see></summary>
    let hasLatestSubmissionDateTime =
        Namespaced_IRI.parse _namespace_name "hasLatestSubmissionDateTime" |> NamespacedName

    /// <summary>
    /// As used in an N3 rule.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionState"></see></summary>
    let hasLatestSubmissionState =
        Namespaced_IRI.parse _namespace_name "hasLatestSubmissionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionState"></see>
    /// </summary>
    let hasSubmissionState =
        Namespaced_IRI.parse _namespace_name "hasSubmissionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModification"></see>
    /// </summary>
    let hasModification =
        Namespaced_IRI.parse _namespace_name "hasModification" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModificationDateTime"></see>
    /// </summary>
    let hasModificationDateTime =
        Namespaced_IRI.parse _namespace_name "hasModificationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModified"></see>
    /// </summary>
    let hasModified =
        Namespaced_IRI.parse _namespace_name "hasModified" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModifier"></see>
    /// </summary>
    let hasModifier =
        Namespaced_IRI.parse _namespace_name "hasModifier" |> NamespacedName

    /// <summary>
    /// Using the Unix Epoch time.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasNow"></see></summary>
    let hasNow = Namespaced_IRI.parse _namespace_name "hasNow" |> NamespacedName

    /// <summary>
    /// A snapshot is an event with coinciding beginning and end.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDateTime"></see></summary>
    let hasSnapshotDateTime =
        Namespaced_IRI.parse _namespace_name "hasSnapshotDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasNowDate"></see>
    /// </summary>
    let hasNowDate = Namespaced_IRI.parse _namespace_name "hasNowDate" |> NamespacedName

    /// <summary>
    /// A snapshot is an event with coinciding beginning and end.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDate"></see></summary>
    let hasSnapshotDate =
        Namespaced_IRI.parse _namespace_name "hasSnapshotDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOnsetMode"></see>
    /// </summary>
    let hasOnsetMode =
        Namespaced_IRI.parse _namespace_name "hasOnsetMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOrderDateTime"></see>
    /// </summary>
    let hasOrderDateTime =
        Namespaced_IRI.parse _namespace_name "hasOrderDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDate"></see>
    /// </summary>
    let hasOriginationDate =
        Namespaced_IRI.parse _namespace_name "hasOriginationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDateTime"></see>
    /// </summary>
    let hasOriginationDateTime =
        Namespaced_IRI.parse _namespace_name "hasOriginationDateTime" |> NamespacedName

    /// <summary>
    /// Related to event:ends
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputDateTime"></see></summary>
    let hasOutputDateTime =
        Namespaced_IRI.parse _namespace_name "hasOutputDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputLikelihood"></see>
    /// </summary>
    let hasOutputLikelihood =
        Namespaced_IRI.parse _namespace_name "hasOutputLikelihood" |> NamespacedName

    /// <summary>
    /// E.g. a clinical finding, e.g. fever, as object of output of clinical evaluating of a body temperature measurement; a disease as object of a diagnosing; a drug product as object of a prescribing.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputObject"></see></summary>
    let hasOutputObject =
        Namespaced_IRI.parse _namespace_name "hasOutputObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasPathway"></see>
    /// </summary>
    let hasPathway = Namespaced_IRI.parse _namespace_name "hasPathway" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasPriorityState"></see>
    /// </summary>
    let hasPriorityState =
        Namespaced_IRI.parse _namespace_name "hasPriorityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasReason"></see>
    /// </summary>
    let hasReason = Namespaced_IRI.parse _namespace_name "hasReason" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasRecipient"></see>
    /// </summary>
    let hasRecipient =
        Namespaced_IRI.parse _namespace_name "hasRecipient" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasRiskFactor"></see>
    /// </summary>
    let hasRiskFactor =
        Namespaced_IRI.parse _namespace_name "hasRiskFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameBeginningAs"></see>
    /// </summary>
    let hasSameBeginningAs =
        Namespaced_IRI.parse _namespace_name "hasSameBeginningAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameDurationAs"></see>
    /// </summary>
    let hasSameDurationAs =
        Namespaced_IRI.parse _namespace_name "hasSameDurationAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameEndAs"></see>
    /// </summary>
    let hasSameEndAs =
        Namespaced_IRI.parse _namespace_name "hasSameEndAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameTimeAs"></see>
    /// </summary>
    let hasSameTimeAs =
        Namespaced_IRI.parse _namespace_name "hasSameTimeAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSponsor"></see>
    /// </summary>
    let hasSponsor = Namespaced_IRI.parse _namespace_name "hasSponsor" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasStage"></see>
    /// </summary>
    let hasStage = Namespaced_IRI.parse _namespace_name "hasStage" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasStartProcedure"></see>
    /// </summary>
    let hasStartProcedure =
        Namespaced_IRI.parse _namespace_name "hasStartProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubAction"></see>
    /// </summary>
    let hasSubAction =
        Namespaced_IRI.parse _namespace_name "hasSubAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#includes"></see>
    /// </summary>
    let includes = Namespaced_IRI.parse _namespace_name "includes" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubOutput"></see>
    /// </summary>
    let hasSubOutput =
        Namespaced_IRI.parse _namespace_name "hasSubOutput" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionDateTime"></see>
    /// </summary>
    let hasSubmissionDateTime =
        Namespaced_IRI.parse _namespace_name "hasSubmissionDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityState"></see>
    /// </summary>
    let hasSusceptibilityState =
        Namespaced_IRI.parse _namespace_name "hasSusceptibilityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityStateFor"></see>
    /// </summary>
    let hasSusceptibilityStateFor =
        Namespaced_IRI.parse _namespace_name "hasSusceptibilityStateFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#susceptibilityStateFor"></see>
    /// </summary>
    let susceptibilityStateFor =
        Namespaced_IRI.parse _namespace_name "susceptibilityStateFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasValidationDateTime"></see>
    /// </summary>
    let hasValidationDateTime =
        Namespaced_IRI.parse _namespace_name "hasValidationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasValidityState"></see>
    /// </summary>
    let hasValidityState =
        Namespaced_IRI.parse _namespace_name "hasValidityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasVanishingDateTime"></see>
    /// </summary>
    let hasVanishingDateTime =
        Namespaced_IRI.parse _namespace_name "hasVanishingDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasWarning"></see>
    /// </summary>
    let hasWarning = Namespaced_IRI.parse _namespace_name "hasWarning" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#hasWeekday"></see>
    /// </summary>
    let hasWeekday = Namespaced_IRI.parse _namespace_name "hasWeekday" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#indicates"></see>
    /// </summary>
    let indicates = Namespaced_IRI.parse _namespace_name "indicates" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#intermediatelySusceptibleTo"></see>
    /// </summary>
    let intermediatelySusceptibleTo =
        Namespaced_IRI.parse _namespace_name "intermediatelySusceptibleTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#wheretoSusceptibilityState"></see>
    /// </summary>
    let wheretoSusceptibilityState =
        Namespaced_IRI.parse _namespace_name "wheretoSusceptibilityState" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#isAssociatedWith"></see>
    /// </summary>
    let isAssociatedWith =
        Namespaced_IRI.parse _namespace_name "isAssociatedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#isReasonFor"></see>
    /// </summary>
    let isReasonFor =
        Namespaced_IRI.parse _namespace_name "isReasonFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#modificationOf"></see>
    /// </summary>
    let modificationOf =
        Namespaced_IRI.parse _namespace_name "modificationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#modifiedBy"></see>
    /// </summary>
    let modifiedBy = Namespaced_IRI.parse _namespace_name "modifiedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#modifiedIn"></see>
    /// </summary>
    let modifiedIn = Namespaced_IRI.parse _namespace_name "modifiedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinModified"></see>
    /// </summary>
    let whereinModified =
        Namespaced_IRI.parse _namespace_name "whereinModified" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#nonCompliantWith"></see>
    /// </summary>
    let nonCompliantWith =
        Namespaced_IRI.parse _namespace_name "nonCompliantWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#notPerformedDuring"></see>
    /// </summary>
    let notPerformedDuring =
        Namespaced_IRI.parse _namespace_name "notPerformedDuring" |> NamespacedName

    /// <summary>
    /// The longer ago, the broader a timescope; e.g. observed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; observed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; observed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; observed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#observedDuring"></see></summary>
    let observedDuring =
        Namespaced_IRI.parse _namespace_name "observedDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#obtainedBy"></see>
    /// </summary>
    let obtainedBy = Namespaced_IRI.parse _namespace_name "obtainedBy" |> NamespacedName

    /// <summary>
    /// The longer ago, the broader a timescope; e.g. obtained in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; obtained in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; obtained last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; obtained Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#obtainedDuring"></see></summary>
    let obtainedDuring =
        Namespaced_IRI.parse _namespace_name "obtainedDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#openFrom"></see>
    /// </summary>
    let openFrom = Namespaced_IRI.parse _namespace_name "openFrom" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#openUntil"></see>
    /// </summary>
    let openUntil = Namespaced_IRI.parse _namespace_name "openUntil" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#orderOf"></see>
    /// </summary>
    let orderOf = Namespaced_IRI.parse _namespace_name "orderOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#orderedTo"></see>
    /// </summary>
    let orderedTo = Namespaced_IRI.parse _namespace_name "orderedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#originatedIn"></see>
    /// </summary>
    let originatedIn =
        Namespaced_IRI.parse _namespace_name "originatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#overlaps"></see>
    /// </summary>
    let overlaps = Namespaced_IRI.parse _namespace_name "overlaps" |> NamespacedName

    /// <summary>
    /// The longer ago, the broader a timescope; e.g. performed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; performed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; performed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; performed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#performedDuring"></see></summary>
    let performedDuring =
        Namespaced_IRI.parse _namespace_name "performedDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#performedIn"></see>
    /// </summary>
    let performedIn =
        Namespaced_IRI.parse _namespace_name "performedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#planOf"></see>
    /// </summary>
    let planOf = Namespaced_IRI.parse _namespace_name "planOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#plannedIn"></see>
    /// </summary>
    let plannedIn = Namespaced_IRI.parse _namespace_name "plannedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#resistantTo"></see>
    /// </summary>
    let resistantTo =
        Namespaced_IRI.parse _namespace_name "resistantTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#riskFactorOf"></see>
    /// </summary>
    let riskFactorOf =
        Namespaced_IRI.parse _namespace_name "riskFactorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#stageOf"></see>
    /// </summary>
    let stageOf = Namespaced_IRI.parse _namespace_name "stageOf" |> NamespacedName

    /// <summary>
    /// The longer ago, the broader a timescope; e.g. staged in 1986: formally stating a period 01/01/1986-31/12/1986; staged last year in May: stating a period 01/05/2010-31/05/2010; staged last week: stating a day 01/01/2012; staged yesterday: stating a moment 20/01/2012, 02PM.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#stagedDuring"></see></summary>
    let stagedDuring =
        Namespaced_IRI.parse _namespace_name "stagedDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#startProcedureOf"></see>
    /// </summary>
    let startProcedureOf =
        Namespaced_IRI.parse _namespace_name "startProcedureOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#stateOf"></see>
    /// </summary>
    let stateOf = Namespaced_IRI.parse _namespace_name "stateOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#subActionOf"></see>
    /// </summary>
    let subActionOf =
        Namespaced_IRI.parse _namespace_name "subActionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#subOutputOf"></see>
    /// </summary>
    let subOutputOf =
        Namespaced_IRI.parse _namespace_name "subOutputOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#susceptibleTo"></see>
    /// </summary>
    let susceptibleTo =
        Namespaced_IRI.parse _namespace_name "susceptibleTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#takesLessLongThan"></see>
    /// </summary>
    let takesLessLongThan =
        Namespaced_IRI.parse _namespace_name "takesLessLongThan" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#takesLongerThan"></see>
    /// </summary>
    let takesLongerThan =
        Namespaced_IRI.parse _namespace_name "takesLongerThan" |> NamespacedName

    /// <summary>
    /// Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#transferOf"></see></summary>
    let transferOf = Namespaced_IRI.parse _namespace_name "transferOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#validationOf"></see>
    /// </summary>
    let validationOf =
        Namespaced_IRI.parse _namespace_name "validationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinDiagnosed"></see>
    /// </summary>
    let whereinDiagnosed =
        Namespaced_IRI.parse _namespace_name "whereinDiagnosed" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinEvaluated"></see>
    /// </summary>
    let whereinEvaluated =
        Namespaced_IRI.parse _namespace_name "whereinEvaluated" |> NamespacedName

    /// <summary>
    /// Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinTransferred"></see></summary>
    let whereinTransferred =
        Namespaced_IRI.parse _namespace_name "whereinTransferred" |> NamespacedName
