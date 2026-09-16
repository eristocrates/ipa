#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module event =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/event#" "event"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : absolute contraindication</para>
    ///   <para>skos:definition : Compelling reason for not performing an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteContraindication">event:AbsoluteContraindication</a>
    /// </summary>
    let AbsoluteContraindication = _prefixId.prefix "AbsoluteContraindication"
    /// <summary>
    ///   <para>rdfs:label : absolute indication</para>
    ///   <para>skos:definition : Compelling reason for an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteIndication">event:AbsoluteIndication</a>
    /// </summary>
    let AbsoluteIndication = _prefixId.prefix "AbsoluteIndication"
    /// <summary>
    ///   <para>rdfs:label : action</para>
    ///   <para>skos:definition : A process involving one or more agents in a certain role.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Action">event:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : adverse output</para>
    ///   <para>skos:definition : Unwanted output of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#AdverseOutput">event:AdverseOutput</a>
    /// </summary>
    let AdverseOutput = _prefixId.prefix "AdverseOutput"
    /// <summary>
    ///   <para>rdfs:label : adverse process</para>
    ///   <para>skos:definition : Unwanted process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#AdverseProcess">event:AdverseProcess</a>
    /// </summary>
    let AdverseProcess = _prefixId.prefix "AdverseProcess"
    /// <summary>
    ///   <para>rdfs:label : authenticating</para>
    ///   <para>skos:definition : Making authoritative or valid.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Authenticating">event:Authenticating</a>
    /// </summary>
    let Authenticating = _prefixId.prefix "Authenticating"
    /// <summary>
    ///   <para>rdfs:label : authentication</para>
    ///   <para>skos:definition : Proof of being authoritative or valid, as output of authenticating.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Authentication">event:Authentication</a>
    /// </summary>
    let Authentication = _prefixId.prefix "Authentication"
    /// <summary>
    ///   <para>rdfs:label : availability</para>
    ///   <para>skos:definition : Event of being available.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Availability">event:Availability</a>
    /// </summary>
    let Availability = _prefixId.prefix "Availability"
    /// <summary>
    ///   <para>rdfs:label : availability state</para>
    ///   <para>skos:definition : State of being available or not.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#AvailabilityState">event:AvailabilityState</a>
    /// </summary>
    let AvailabilityState = _prefixId.prefix "AvailabilityState"
    /// <summary>
    ///   <para>rdfs:label : available</para>
    ///   <para>skos:definition : Being suitable or ready for use.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Available">event:Available</a>
    /// </summary>
    let Available = _prefixId.prefix "Available"
    /// <summary>
    ///   <para>rdfs:label : biphasic</para>
    ///   <para>skos:definition : Existing in 2 phases.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Biphasic">event:Biphasic</a>
    /// </summary>
    let Biphasic = _prefixId.prefix "Biphasic"
    /// <summary>
    ///   <para>rdfs:label : cause</para>
    ///   <para>skos:definition : Source of entailment.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Cause">event:Cause</a>
    /// </summary>
    let Cause = _prefixId.prefix "Cause"
    /// <summary>
    ///   <para>rdfs:label : causing</para>
    ///   <para>skos:definition : Being a source of entailment.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Causing">event:Causing</a>
    /// </summary>
    let Causing = _prefixId.prefix "Causing"
    /// <summary>
    ///   <para>rdfs:label : certain</para>
    ///   <para>skos:definition : Probability of an output of a process being highest.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Certain">event:Certain</a>
    /// </summary>
    let Certain = _prefixId.prefix "Certain"
    /// <summary>
    ///   <para>rdfs:label : completed</para>
    ///   <para>skos:definition : State of being completed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Completed">event:Completed</a>
    /// </summary>
    let Completed = _prefixId.prefix "Completed"
    /// <summary>
    ///   <para>rdfs:label : completing</para>
    ///   <para>skos:definition : .</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Completing">event:Completing</a>
    /// </summary>
    let Completing = _prefixId.prefix "Completing"
    /// <summary>
    ///   <para>rdfs:label : completion</para>
    ///   <para>skos:definition : Output of completing.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Completion">event:Completion</a>
    /// </summary>
    let Completion = _prefixId.prefix "Completion"
    /// <summary>
    ///   <para>rdfs:label : completion state</para>
    ///   <para>skos:definition : State of being completed or not.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#CompletionState">event:CompletionState</a>
    /// </summary>
    let CompletionState = _prefixId.prefix "CompletionState"
    /// <summary>
    ///   <para>rdfs:label : condition</para>
    ///   <para>skos:definition : Something that must exist if something else is to take place.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Condition">event:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>rdfs:label : contraindication</para>
    ///   <para>skos:definition : A reason for not performing an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Contraindication">event:Contraindication</a>
    /// </summary>
    let Contraindication = _prefixId.prefix "Contraindication"
    /// <summary>
    ///   <para>rdfs:label : course mode</para>
    ///   <para>skos:definition : Mode of relating to time of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#CourseMode">event:CourseMode</a>
    /// </summary>
    let CourseMode = _prefixId.prefix "CourseMode"
    /// <summary>
    ///   <para>rdfs:label : created</para>
    ///   <para>skos:definition : State of being brought into existance.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Created">event:Created</a>
    /// </summary>
    let Created = _prefixId.prefix "Created"
    /// <summary>
    ///   <para>rdfs:label : creating</para>
    ///   <para>skos:definition : Bringing into existence.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Creating">event:Creating</a>
    /// </summary>
    let Creating = _prefixId.prefix "Creating"
    /// <summary>
    ///   <para>rdfs:label : creation</para>
    ///   <para>skos:definition : Output of creating.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Creation">event:Creation</a>
    /// </summary>
    let Creation = _prefixId.prefix "Creation"
    /// <summary>
    ///   <para>rdfs:label : cyclic</para>
    ///   <para>skos:definition : Existing in a cycle.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Cyclic">event:Cyclic</a>
    /// </summary>
    let Cyclic = _prefixId.prefix "Cyclic"
    /// <summary>
    ///   <para>rdfs:label : day</para>
    ///   <para>skos:definition : Event of 1 rotation of the Earth around its axis.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Day">event:Day</a>
    /// </summary>
    let Day = _prefixId.prefix "Day"
    /// <summary>
    ///   <para>rdfs:label : delivering</para>
    ///   <para>skos:definition : Handing over to another agent.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Delivering">event:Delivering</a>
    /// </summary>
    let Delivering = _prefixId.prefix "Delivering"
    /// <summary>
    ///   <para>rdfs:label : delivery</para>
    ///   <para>skos:definition : Handed over to another agent.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Delivery">event:Delivery</a>
    /// </summary>
    let Delivery = _prefixId.prefix "Delivery"
    /// <summary>
    ///   <para>rdfs:label : demand state</para>
    ///   <para>skos:definition : State of being demanded or not.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#DemandState">event:DemandState</a>
    /// </summary>
    let DemandState = _prefixId.prefix "DemandState"
    /// <summary>
    ///   <para>rdfs:label : demanded</para>
    ///   <para>skos:definition : Being requested out of a need.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Demanded">event:Demanded</a>
    /// </summary>
    let Demanded = _prefixId.prefix "Demanded"
    /// <summary>
    ///   <para>rdfs:label : diagnosing</para>
    ///   <para>skos:definition : Identifying the nature of something, either by process of elimination or other analytical method, and applying logic and experience to determine cause and effect relationships.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosing">event:Diagnosing</a>
    /// </summary>
    let Diagnosing = _prefixId.prefix "Diagnosing"
    /// <summary>
    ///   <para>rdfs:label : diagnosis</para>
    ///   <para>skos:definition : The result of a diagnosing procedure.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosis">event:Diagnosis</a>
    /// </summary>
    let Diagnosis = _prefixId.prefix "Diagnosis"
    /// <summary>
    ///   <para>rdfs:label : diagnosis state</para>
    ///   <para>skos:definition : State of a diagnosis of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#DiagnosisState">event:DiagnosisState</a>
    /// </summary>
    let DiagnosisState = _prefixId.prefix "DiagnosisState"
    /// <summary>
    ///   <para>rdfs:label : educating</para>
    ///   <para>skos:definition : Instructing a human with the aim of changing his or her knowledge and/or behavior.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Educating">event:Educating</a>
    /// </summary>
    let Educating = _prefixId.prefix "Educating"
    /// <summary>
    ///   <para>rdfs:label : education</para>
    ///   <para>skos:definition : Change of knowledge and/or behaviour as output of educating</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Education">event:Education</a>
    /// </summary>
    let Education = _prefixId.prefix "Education"
    /// <summary>
    ///   <para>rdfs:label : effect</para>
    ///   <para>skos:definition : Output related to a cause.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Effect">event:Effect</a>
    /// </summary>
    let Effect = _prefixId.prefix "Effect"
    /// <summary>
    ///   <para>rdfs:label : ending mode</para>
    ///   <para>skos:definition : Mode of going out of existence.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#EndingMode">event:EndingMode</a>
    /// </summary>
    let EndingMode = _prefixId.prefix "EndingMode"
    /// <summary>
    ///   <para>rdfs:label : evaluated</para>
    ///   <para>skos:definition : State of being examined with judgement.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluated">event:Evaluated</a>
    /// </summary>
    let Evaluated = _prefixId.prefix "Evaluated"
    /// <summary>
    ///   <para>rdfs:label : evaluating</para>
    ///   <para>skos:definition : Examining with judging.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluating">event:Evaluating</a>
    /// </summary>
    let Evaluating = _prefixId.prefix "Evaluating"
    /// <summary>
    ///   <para>rdfs:label : evaluation</para>
    ///   <para>skos:definition : Examination with judgement of any kind, as output of evaluating.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluation">event:Evaluation</a>
    /// </summary>
    let Evaluation = _prefixId.prefix "Evaluation"
    /// <summary>
    ///   <para>rdfs:label : event</para>
    ///   <para>skos:definition : An occurrence as a space-time thing.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Event">event:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : examination</para>
    ///   <para>skos:definition : Examination of something, as output of examining.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Examination">event:Examination</a>
    /// </summary>
    let Examination = _prefixId.prefix "Examination"
    /// <summary>
    ///   <para>rdfs:label : examined</para>
    ///   <para>skos:definition : State of being examined.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Examined">event:Examined</a>
    /// </summary>
    let Examined = _prefixId.prefix "Examined"
    /// <summary>
    ///   <para>rdfs:label : examining</para>
    ///   <para>skos:definition : Collecting information about something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Examining">event:Examining</a>
    /// </summary>
    let Examining = _prefixId.prefix "Examining"
    /// <summary>
    ///   <para>rdfs:label : existence</para>
    ///   <para>skos:definition : Event of being.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Existence">event:Existence</a>
    /// </summary>
    let Existence = _prefixId.prefix "Existence"
    /// <summary>
    ///   <para>rdfs:label : experimental</para>
    ///   <para>skos:definition : Being object of experimenting.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Experimental">event:Experimental</a>
    /// </summary>
    let Experimental = _prefixId.prefix "Experimental"
    /// <summary>
    ///   <para>rdfs:label : fast</para>
    ///   <para>skos:definition : Evolve in a short period of time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Fast">event:Fast</a>
    /// </summary>
    let Fast = _prefixId.prefix "Fast"
    /// <summary>
    ///   <para>rdfs:label : final output</para>
    ///   <para>skos:definition : Output at the end of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#FinalOutput">event:FinalOutput</a>
    /// </summary>
    let FinalOutput = _prefixId.prefix "FinalOutput"
    /// <summary>
    ///   <para>rdfs:label : finding</para>
    ///   <para>skos:definition : Something that is observed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Finding">event:Finding</a>
    /// </summary>
    let Finding = _prefixId.prefix "Finding"
    /// <summary>
    ///   <para>rdfs:label : Friday</para>
    ///   <para>skos:definition : Fifth day of a week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Friday">event:Friday</a>
    /// </summary>
    let Friday = _prefixId.prefix "Friday"
    /// <summary>
    ///   <para>rdfs:label : future</para>
    ///   <para>skos:definition : State of being in the future.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Future">event:Future</a>
    /// </summary>
    let Future = _prefixId.prefix "Future"
    /// <summary>
    ///   <para>rdfs:label : gradual</para>
    ///   <para>skos:definition : Coming into or going out of existence, or evolve gradually.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Gradual">event:Gradual</a>
    /// </summary>
    let Gradual = _prefixId.prefix "Gradual"
    /// <summary>
    ///   <para>rdfs:label : guideline</para>
    ///   <para>skos:definition : Detailed plan guiding in determining a course of action (e.g. clinical).</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Guideline">event:Guideline</a>
    /// </summary>
    let Guideline = _prefixId.prefix "Guideline"
    /// <summary>
    ///   <para>rdfs:label : high priority</para>
    ///   <para>skos:definition : High precedence rank of an action to be performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#HighPriority">event:HighPriority</a>
    /// </summary>
    let HighPriority = _prefixId.prefix "HighPriority"
    /// <summary>
    ///   <para>rdfs:label : indication</para>
    ///   <para>skos:definition : Reason for an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Indication">event:Indication</a>
    /// </summary>
    let Indication = _prefixId.prefix "Indication"
    /// <summary>
    ///   <para>rdfs:label : input</para>
    ///   <para>skos:definition : Precondition to a change in a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Input">event:Input</a>
    /// </summary>
    let Input = _prefixId.prefix "Input"
    /// <summary>
    ///   <para>rdfs:label : intent</para>
    ///   <para>skos:definition : Purpose of an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Intent">event:Intent</a>
    /// </summary>
    let Intent = _prefixId.prefix "Intent"
    /// <summary>
    ///   <para>rdfs:label : intention state</para>
    ///   <para>skos:definition : State of being intentional or not.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#IntentionState">event:IntentionState</a>
    /// </summary>
    let IntentionState = _prefixId.prefix "IntentionState"
    /// <summary>
    ///   <para>rdfs:label : intentional</para>
    ///   <para>skos:definition : State of an action being consciously and voluntary performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Intentional">event:Intentional</a>
    /// </summary>
    let Intentional = _prefixId.prefix "Intentional"
    /// <summary>
    ///   <para>rdfs:label : interacting</para>
    ///   <para>skos:definition : An action involving 2 or more agents in which an agent changes the output compared to an action without this agent.</para>
    ///   <para>skos:note : Not limited to direct interaction between agents.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Interacting">event:Interacting</a>
    /// </summary>
    let Interacting = _prefixId.prefix "Interacting"
    /// <summary>
    ///   <para>rdfs:label : interaction</para>
    ///   <para>skos:definition : Outcome of interacting.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Interaction">event:Interaction</a>
    /// </summary>
    let Interaction = _prefixId.prefix "Interaction"
    /// <summary>
    ///   <para>rdfs:label : intermediate output</para>
    ///   <para>skos:definition : Output during a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#IntermediateOutput">event:IntermediateOutput</a>
    /// </summary>
    let IntermediateOutput = _prefixId.prefix "IntermediateOutput"
    /// <summary>
    ///   <para>rdfs:label : intermediately susceptible</para>
    ///   <para>skos:definition : Being susceptible to an intermediate degree.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#IntermediatelySusceptible">event:IntermediatelySusceptible</a>
    /// </summary>
    let IntermediatelySusceptible = _prefixId.prefix "IntermediatelySusceptible"
    /// <summary>
    ///   <para>rdfs:label : intermittent</para>
    ///   <para>skos:definition : Come and go in and out of existence.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Intermittent">event:Intermittent</a>
    /// </summary>
    let Intermittent = _prefixId.prefix "Intermittent"
    /// <summary>
    ///   <para>rdfs:label : invalid</para>
    ///   <para>skos:definition : State of not being valid.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Invalid">event:Invalid</a>
    /// </summary>
    let Invalid = _prefixId.prefix "Invalid"
    /// <summary>
    ///   <para>rdfs:label : legal authenticating</para>
    ///   <para>skos:definition : Making legally authoritative or valid.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthenticating">event:LegalAuthenticating</a>
    /// </summary>
    let LegalAuthenticating = _prefixId.prefix "LegalAuthenticating"
    /// <summary>
    ///   <para>rdfs:label : legal authentication</para>
    ///   <para>skos:definition : Proof of being legally authoritative or valid, as output of legal authenticating.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthentication">event:LegalAuthentication</a>
    /// </summary>
    let LegalAuthentication = _prefixId.prefix "LegalAuthentication"
    /// <summary>
    ///   <para>rdfs:label : likelihood</para>
    ///   <para>skos:definition : State of being probable.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Likelihood">event:Likelihood</a>
    /// </summary>
    let Likelihood = _prefixId.prefix "Likelihood"
    /// <summary>
    ///   <para>rdfs:label : likely</para>
    ///   <para>skos:definition : Probability of an output of a process being high.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Likely">event:Likely</a>
    /// </summary>
    let Likely = _prefixId.prefix "Likely"
    /// <summary>
    ///   <para>rdfs:label : low priority</para>
    ///   <para>skos:definition : Low precedence rank of an action to be performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#LowPriority">event:LowPriority</a>
    /// </summary>
    let LowPriority = _prefixId.prefix "LowPriority"
    /// <summary>
    ///   <para>rdfs:label : method</para>
    ///   <para>skos:definition : Way an action can be performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Method">event:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:label : modification</para>
    ///   <para>skos:definition : Change of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Modification">event:Modification</a>
    /// </summary>
    let Modification = _prefixId.prefix "Modification"
    /// <summary>
    ///   <para>rdfs:label : modified</para>
    ///   <para>skos:definition : State of being changed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Modified">event:Modified</a>
    /// </summary>
    let Modified = _prefixId.prefix "Modified"
    /// <summary>
    ///   <para>rdfs:label : modifying</para>
    ///   <para>skos:definition : Changing something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Modifying">event:Modifying</a>
    /// </summary>
    let Modifying = _prefixId.prefix "Modifying"
    /// <summary>
    ///   <para>rdfs:label : Monday</para>
    ///   <para>skos:definition : First day of a week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Monday">event:Monday</a>
    /// </summary>
    let Monday = _prefixId.prefix "Monday"
    /// <summary>
    ///   <para>rdfs:label : most likely</para>
    ///   <para>skos:definition : Probability of an output of a process being very high.</para>
    ///   <para>rdfs:comment : Near sure.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#MostLikely">event:MostLikely</a>
    /// </summary>
    let MostLikely = _prefixId.prefix "MostLikely"
    /// <summary>
    ///   <para>rdfs:label : most unlikely</para>
    ///   <para>skos:definition : Probability of an output of a process being lowest.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#MostUnlikely">event:MostUnlikely</a>
    /// </summary>
    let MostUnlikely = _prefixId.prefix "MostUnlikely"
    /// <summary>
    ///   <para>rdfs:label : observable</para>
    ///   <para>skos:definition : Something that can be observed, e.g. length.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Observable">event:Observable</a>
    /// </summary>
    let Observable = _prefixId.prefix "Observable"
    /// <summary>
    ///   <para>rdfs:label : onset mode</para>
    ///   <para>skos:definition : Mode of coming into existence.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#OnsetMode">event:OnsetMode</a>
    /// </summary>
    let OnsetMode = _prefixId.prefix "OnsetMode"
    /// <summary>
    ///   <para>rdfs:label : order</para>
    ///   <para>skos:definition : Direction or commission to make, provide, or furnish something, as output of ordering.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Order">event:Order</a>
    /// </summary>
    let Order = _prefixId.prefix "Order"
    /// <summary>
    ///   <para>rdfs:label : ordering</para>
    ///   <para>skos:definition : Directing or commissioning to make, provide, or furnish something</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Ordering">event:Ordering</a>
    /// </summary>
    let Ordering = _prefixId.prefix "Ordering"
    /// <summary>
    ///   <para>rdfs:label : output</para>
    ///   <para>skos:definition : Consequence of a change in a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Output">event:Output</a>
    /// </summary>
    let Output = _prefixId.prefix "Output"
    /// <summary>
    ///   <para>rdfs:label : output likelihood</para>
    ///   <para>skos:definition : Likelihood of an output of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#OutputLikelihood">event:OutputLikelihood</a>
    /// </summary>
    let OutputLikelihood = _prefixId.prefix "OutputLikelihood"
    /// <summary>
    ///   <para>rdfs:label : past</para>
    ///   <para>skos:definition : State of being in the past.</para>
    ///   <para>rdfs:comment : E.g. past 3 months: before now.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Past">event:Past</a>
    /// </summary>
    let Past = _prefixId.prefix "Past"
    /// <summary>
    ///   <para>rdfs:label : pathway</para>
    ///   <para>skos:definition : Binding instructions for an action.</para>
    ///   <para>skos:note : Organization dependent, different from guideline.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Pathway">event:Pathway</a>
    /// </summary>
    let Pathway = _prefixId.prefix "Pathway"
    /// <summary>
    ///   <para>rdfs:label : persistent</para>
    ///   <para>skos:definition : Staying in existence.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Persistent">event:Persistent</a>
    /// </summary>
    let Persistent = _prefixId.prefix "Persistent"
    /// <summary>
    ///   <para>rdfs:label : phasic</para>
    ///   <para>skos:definition : Existing in phases.</para>
    ///   <para>rdfs:comment : Human prenatal existence comprising embryonic and foetal phase.^^xsd:string</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Phasic">event:Phasic</a>
    /// </summary>
    let Phasic = _prefixId.prefix "Phasic"
    /// <summary>
    ///   <para>rdfs:label : plan</para>
    ///   <para>skos:definition : Predefined way to perform an action in order to achieve a goal.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Plan">event:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>rdfs:label : planning</para>
    ///   <para>skos:definition : Predefining a way to perform an action in order to achieve a goal.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Planning">event:Planning</a>
    /// </summary>
    let Planning = _prefixId.prefix "Planning"
    /// <summary>
    ///   <para>rdfs:label : previous</para>
    ///   <para>skos:definition : State of something being before something alike.</para>
    ///   <para>rdfs:comment : E.g. previous 3 months: before current month.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Previous">event:Previous</a>
    /// </summary>
    let Previous = _prefixId.prefix "Previous"
    /// <summary>
    ///   <para>rdfs:label : priority state</para>
    ///   <para>skos:definition : State of precedence rank of an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#PriorityState">event:PriorityState</a>
    /// </summary>
    let PriorityState = _prefixId.prefix "PriorityState"
    /// <summary>
    ///   <para>rdfs:label : procedure</para>
    ///   <para>skos:definition : Action executed in one or more steps, in a certain manner to obtain a certain output under certain circumstances.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Procedure">event:Procedure</a>
    /// </summary>
    let Procedure = _prefixId.prefix "Procedure"
    /// <summary>
    ///   <para>rdfs:label : process</para>
    ///   <para>skos:definition : An event implying change, from an input to an output, in one or more steps.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Process">event:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:label : reason</para>
    ///   <para>skos:definition : Argument to justify an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Reason">event:Reason</a>
    /// </summary>
    let Reason = _prefixId.prefix "Reason"
    /// <summary>
    ///   <para>rdfs:label : relative contraindication</para>
    ///   <para>skos:definition : Possible reason for not performing an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#RelativeContraindication">event:RelativeContraindication</a>
    /// </summary>
    let RelativeContraindication = _prefixId.prefix "RelativeContraindication"
    /// <summary>
    ///   <para>rdfs:label : relative indication</para>
    ///   <para>skos:definition : Possible reason for an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#RelativeIndication">event:RelativeIndication</a>
    /// </summary>
    let RelativeIndication = _prefixId.prefix "RelativeIndication"
    /// <summary>
    ///   <para>rdfs:label : request</para>
    ///   <para>skos:definition : Output of requesting.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Request">event:Request</a>
    /// </summary>
    let Request = _prefixId.prefix "Request"
    /// <summary>
    ///   <para>rdfs:label : requesting</para>
    ///   <para>skos:definition : Asking for something to be done.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Requesting">event:Requesting</a>
    /// </summary>
    let Requesting = _prefixId.prefix "Requesting"
    /// <summary>
    ///   <para>rdfs:label : resistant</para>
    ///   <para>skos:definition : Not being susceptible.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Resistant">event:Resistant</a>
    /// </summary>
    let Resistant = _prefixId.prefix "Resistant"
    /// <summary>
    ///   <para>rdfs:label : risk</para>
    ///   <para>skos:definition : Probability of an adverse process or output.</para>
    ///   <para>skos:note : Mapped to the range of e:conditional in rules</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Risk">event:Risk</a>
    /// </summary>
    let Risk = _prefixId.prefix "Risk"
    /// <summary>
    ///   <para>rdfs:label : risk factor</para>
    ///   <para>skos:definition : Contributing to a risk of an adverse process or output.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#RiskFactor">event:RiskFactor</a>
    /// </summary>
    let RiskFactor = _prefixId.prefix "RiskFactor"
    /// <summary>
    ///   <para>rdfs:label : routine</para>
    ///   <para>skos:definition : Lowest precedence rank of an action to be performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Routine">event:Routine</a>
    /// </summary>
    let Routine = _prefixId.prefix "Routine"
    /// <summary>
    ///   <para>rdfs:label : Saturday</para>
    ///   <para>skos:definition : Sixth day of a week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Saturday">event:Saturday</a>
    /// </summary>
    let Saturday = _prefixId.prefix "Saturday"
    /// <summary>
    ///   <para>rdfs:label : slow</para>
    ///   <para>skos:definition : Coming into or going out of existence, or evolve in a long period of time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Slow">event:Slow</a>
    /// </summary>
    let Slow = _prefixId.prefix "Slow"
    /// <summary>
    ///   <para>rdfs:label : sponsoring</para>
    ///   <para>skos:definition : Financing something in supporting a person or group.</para>
    ///   <para>rdfs:comment : E.g. a business enterprise paying for radio or television programming in return for advertising time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Sponsoring">event:Sponsoring</a>
    /// </summary>
    let Sponsoring = _prefixId.prefix "Sponsoring"
    /// <summary>
    ///   <para>rdfs:label : stage</para>
    ///   <para>skos:definition : Degree of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Stage">event:Stage</a>
    /// </summary>
    let Stage = _prefixId.prefix "Stage"
    /// <summary>
    ///   <para>rdfs:label : staging</para>
    ///   <para>skos:definition : Determining a degree of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Staging">event:Staging</a>
    /// </summary>
    let Staging = _prefixId.prefix "Staging"
    /// <summary>
    ///   <para>rdfs:label : state</para>
    ///   <para>skos:definition : Mode of being.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#State">event:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : strategy</para>
    ///   <para>skos:definition : A method for obtaining a specific result.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Strategy">event:Strategy</a>
    /// </summary>
    let Strategy = _prefixId.prefix "Strategy"
    /// <summary>
    ///   <para>rdfs:label : subacute</para>
    ///   <para>skos:definition : Coming into or going out of existence in a moderate short period of time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Subacute">event:Subacute</a>
    /// </summary>
    let Subacute = _prefixId.prefix "Subacute"
    /// <summary>
    ///   <para>rdfs:label : submission</para>
    ///   <para>skos:definition : Output of submitting.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Submission">event:Submission</a>
    /// </summary>
    let Submission = _prefixId.prefix "Submission"
    /// <summary>
    ///   <para>rdfs:label : submission state</para>
    ///   <para>skos:definition : State of being submitted or not.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#SubmissionState">event:SubmissionState</a>
    /// </summary>
    let SubmissionState = _prefixId.prefix "SubmissionState"
    /// <summary>
    ///   <para>rdfs:label : submitted</para>
    ///   <para>skos:definition : State of being submitted.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Submitted">event:Submitted</a>
    /// </summary>
    let Submitted = _prefixId.prefix "Submitted"
    /// <summary>
    ///   <para>rdfs:label : submitting</para>
    ///   <para>skos:definition : .</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Submitting">event:Submitting</a>
    /// </summary>
    let Submitting = _prefixId.prefix "Submitting"
    /// <summary>
    ///   <para>rdfs:label : sudden</para>
    ///   <para>skos:definition : Coming into or going out of existence in a very short period of time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Sudden">event:Sudden</a>
    /// </summary>
    let Sudden = _prefixId.prefix "Sudden"
    /// <summary>
    ///   <para>rdfs:label : Sunday</para>
    ///   <para>skos:definition : Seventh day of a week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Sunday">event:Sunday</a>
    /// </summary>
    let Sunday = _prefixId.prefix "Sunday"
    /// <summary>
    ///   <para>rdfs:label : susceptibility state</para>
    ///   <para>skos:definition : State of being susceptible to something to a degree.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#SusceptibilityState">event:SusceptibilityState</a>
    /// </summary>
    let SusceptibilityState = _prefixId.prefix "SusceptibilityState"
    /// <summary>
    ///   <para>rdfs:label : susceptible</para>
    ///   <para>skos:definition : Prone to an effect of a cause.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Susceptible">event:Susceptible</a>
    /// </summary>
    let Susceptible = _prefixId.prefix "Susceptible"
    /// <summary>
    ///   <para>rdfs:label : suspected</para>
    ///   <para>skos:definition : State of something being probable without proof.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Suspected">event:Suspected</a>
    /// </summary>
    let Suspected = _prefixId.prefix "Suspected"
    /// <summary>
    ///   <para>rdfs:label : Thursday</para>
    ///   <para>skos:definition : Fourth day of a week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Thursday">event:Thursday</a>
    /// </summary>
    let Thursday = _prefixId.prefix "Thursday"
    let Transfer = _prefixId.prefix "Transfer"
    let Transferring = _prefixId.prefix "Transferring"
    /// <summary>
    ///   <para>rdfs:label : Tuesday</para>
    ///   <para>skos:definition : Second day of a week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Tuesday">event:Tuesday</a>
    /// </summary>
    let Tuesday = _prefixId.prefix "Tuesday"
    /// <summary>
    ///   <para>rdfs:label : uncompleted</para>
    ///   <para>skos:definition : State of being uncompleted.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#UnCompleted">event:UnCompleted</a>
    /// </summary>
    let UnCompleted = _prefixId.prefix "UnCompleted"
    /// <summary>
    ///   <para>rdfs:label : unsubmitted</para>
    ///   <para>skos:definition : State of not being submitted.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#UnSubmitted">event:UnSubmitted</a>
    /// </summary>
    let UnSubmitted = _prefixId.prefix "UnSubmitted"
    /// <summary>
    ///   <para>rdfs:label : unsuspected</para>
    ///   <para>skos:definition : State of something being improbable without proof.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#UnSuspected">event:UnSuspected</a>
    /// </summary>
    let UnSuspected = _prefixId.prefix "UnSuspected"
    /// <summary>
    ///   <para>rdfs:label : unverified</para>
    ///   <para>skos:definition : State of being without proof.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#UnVerified">event:UnVerified</a>
    /// </summary>
    let UnVerified = _prefixId.prefix "UnVerified"
    /// <summary>
    ///   <para>rdfs:label : unavailability</para>
    ///   <para>skos:definition : Event of being unavailable.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Unavailability">event:Unavailability</a>
    /// </summary>
    let Unavailability = _prefixId.prefix "Unavailability"
    /// <summary>
    ///   <para>rdfs:label : unavailable</para>
    ///   <para>skos:definition : Not being suitable or ready for use.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Unavailable">event:Unavailable</a>
    /// </summary>
    let Unavailable = _prefixId.prefix "Unavailable"
    /// <summary>
    ///   <para>rdfs:label : undemanded</para>
    ///   <para>skos:definition : Being not requested out of a need.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Undemanded">event:Undemanded</a>
    /// </summary>
    let Undemanded = _prefixId.prefix "Undemanded"
    /// <summary>
    ///   <para>rdfs:label : unintentional</para>
    ///   <para>skos:definition : State of an action being not consciously and voluntary performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Unintentional">event:Unintentional</a>
    /// </summary>
    let Unintentional = _prefixId.prefix "Unintentional"
    /// <summary>
    ///   <para>rdfs:label : unlikely</para>
    ///   <para>skos:definition : Probability of an output of a process being low.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Unlikely">event:Unlikely</a>
    /// </summary>
    let Unlikely = _prefixId.prefix "Unlikely"
    /// <summary>
    ///   <para>rdfs:label : urgent</para>
    ///   <para>skos:definition : Highest precedence rank of an action to be performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Urgent">event:Urgent</a>
    /// </summary>
    let Urgent = _prefixId.prefix "Urgent"
    /// <summary>
    ///   <para>rdfs:label : valid</para>
    ///   <para>skos:definition : State of being valid.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Valid">event:Valid</a>
    /// </summary>
    let Valid = _prefixId.prefix "Valid"
    /// <summary>
    ///   <para>rdfs:label : validating</para>
    ///   <para>skos:definition : Approve something or not along a value.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Validating">event:Validating</a>
    /// </summary>
    let Validating = _prefixId.prefix "Validating"
    /// <summary>
    ///   <para>rdfs:label : validation</para>
    ///   <para>skos:definition : Output of validating.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Validation">event:Validation</a>
    /// </summary>
    let Validation = _prefixId.prefix "Validation"
    /// <summary>
    ///   <para>rdfs:label : validity state</para>
    ///   <para>skos:definition : State of being valid or not.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#ValidityState">event:ValidityState</a>
    /// </summary>
    let ValidityState = _prefixId.prefix "ValidityState"
    /// <summary>
    ///   <para>rdfs:label : verified</para>
    ///   <para>skos:definition : State of being with proof.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Verified">event:Verified</a>
    /// </summary>
    let Verified = _prefixId.prefix "Verified"
    /// <summary>
    ///   <para>rdfs:label : Wednesday</para>
    ///   <para>skos:definition : Third day of a week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Wednesday">event:Wednesday</a>
    /// </summary>
    let Wednesday = _prefixId.prefix "Wednesday"
    /// <summary>
    ///   <para>rdfs:label : week</para>
    ///   <para>skos:definition : Event of 7 days in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Week">event:Week</a>
    /// </summary>
    let Week = _prefixId.prefix "Week"
    /// <summary>
    ///   <para>rdfs:label : weekday</para>
    ///   <para>skos:definition : One of the 7 days of the week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#Weekday">event:Weekday</a>
    /// </summary>
    let Weekday = _prefixId.prefix "Weekday"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Linking a later to an earlier event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#after">event:after</a>
    /// </summary>
    let after = _prefixId.prefix "after"
    /// <summary>
    ///   <para>rdfs:label : based on</para>
    ///   <para>skos:definition : Specifying something being a basis for something else.</para>
    ///   <para>rdfs:comment : E.g. a diagnosis, e.g. infection, based on an evaluation, e.g. fever, in turn based on an examination, e.g. body temperature measurement.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#basedOn">event:basedOn</a>
    /// </summary>
    let basedOn = _prefixId.prefix "basedOn"
    /// <summary>
    ///   <para>skos:definition : Specifying something based on something else.</para>
    ///   <para>rdfs:comment : E.g. an examination, e.g. body temperature measurement, as basis for an evaluation, e.g. fever, in turn basis for a diagnosis, e.g. infection.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#basisFor">event:basisFor</a>
    /// </summary>
    let basisFor = _prefixId.prefix "basisFor"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Linking an earlier to a later event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#before">event:before</a>
    /// </summary>
    let before = _prefixId.prefix "before"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Specifying a begin point in time of an event as date.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#beginDate">event:beginDate</a>
    /// </summary>
    let beginDate = _prefixId.prefix "beginDate"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Specifying a begin point in time of an event.</para>
    ///   <para>rdfs:comment : Using the Unix Epoch time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#begins">event:begins</a>
    /// </summary>
    let begins = _prefixId.prefix "begins"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Linking a later beginning to an earlier beginning event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsAfter">event:beginsAfter</a>
    /// </summary>
    let beginsAfter = _prefixId.prefix "beginsAfter"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Linking an earlier beginning to a later beginning event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsBefore">event:beginsBefore</a>
    /// </summary>
    let beginsBefore = _prefixId.prefix "beginsBefore"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Specifying an event during which another event begins.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsDuring">event:beginsDuring</a>
    /// </summary>
    let beginsDuring = _prefixId.prefix "beginsDuring"
    /// <summary>
    ///   <para>skos:definition : Specifying a cause of an event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#causedBy">event:causedBy</a>
    /// </summary>
    let causedBy = _prefixId.prefix "causedBy"
    /// <summary>
    ///   <para>skos:definition : Specifying an event having a cause.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#causes">event:causes</a>
    /// </summary>
    let causes = _prefixId.prefix "causes"
    /// <summary>
    ///   <para>rdfs:label : complies with</para>
    ///   <para>skos:definition : Specifying something something else complies with.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#compliesWith">event:compliesWith</a>
    /// </summary>
    let compliesWith = _prefixId.prefix "compliesWith"
    /// <summary>
    ///   <para>rdfs:label : confirmed by</para>
    ///   <para>skos:definition : Specifying something confirming something else.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#confirmedBy">event:confirmedBy</a>
    /// </summary>
    let confirmedBy = _prefixId.prefix "confirmedBy"
    /// <summary>
    ///   <para>rdfs:label : confirms</para>
    ///   <para>skos:definition : Specifying something confirmed by something else.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#confirms">event:confirms</a>
    /// </summary>
    let confirms = _prefixId.prefix "confirms"
    /// <summary>
    ///   <para>skos:definition : Specifying an indication for not performing an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#contraindicatedBy">event:contraindicatedBy</a>
    /// </summary>
    let contraindicatedBy = _prefixId.prefix "contraindicatedBy"
    /// <summary>
    ///   <para>skos:definition : Specifying an action having a contraindication.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#contraindicates">event:contraindicates</a>
    /// </summary>
    let contraindicates = _prefixId.prefix "contraindicates"
    /// <summary>
    ///   <para>skos:definition : Specifying a creator of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#createdBy">event:createdBy</a>
    /// </summary>
    let createdBy = _prefixId.prefix "createdBy"
    /// <summary>
    ///   <para>skos:definition : Specifying a creating wherein something is created.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#createdIn">event:createdIn</a>
    /// </summary>
    let createdIn = _prefixId.prefix "createdIn"
    /// <summary>
    ///   <para>skos:definition : Specifying something created.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#creationOf">event:creationOf</a>
    /// </summary>
    let creationOf = _prefixId.prefix "creationOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a delivering wherein something is delivered.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveredIn">event:deliveredIn</a>
    /// </summary>
    let deliveredIn = _prefixId.prefix "deliveredIn"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent something is delivered to.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveredTo">event:deliveredTo</a>
    /// </summary>
    let deliveredTo = _prefixId.prefix "deliveredTo"
    /// <summary>
    ///   <para>skos:definition : Specifying something delivered.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveryOf">event:deliveryOf</a>
    /// </summary>
    let deliveryOf = _prefixId.prefix "deliveryOf"
    let diagnosedDuring = _prefixId.prefix "diagnosedDuring"
    let diagnosedIn = _prefixId.prefix "diagnosedIn"
    let diagnosisOf = _prefixId.prefix "diagnosisOf"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Specifying an event during which another event happens.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#during">event:during</a>
    /// </summary>
    let during = _prefixId.prefix "during"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Specifying the end point in time of an event as date.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#endDate">event:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>skos:definition : Specifying a procedure as last subprocedure of a another procedure.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#endProcedureOf">event:endProcedureOf</a>
    /// </summary>
    let endProcedureOf = _prefixId.prefix "endProcedureOf"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Specifying the end point in time of an event.</para>
    ///   <para>rdfs:comment : Using the Unix Epoch time; related to event:hasDateTime.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#ends">event:ends</a>
    /// </summary>
    let ends = _prefixId.prefix "ends"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Linking a later ending to an earlier ending event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#endsAfter">event:endsAfter</a>
    /// </summary>
    let endsAfter = _prefixId.prefix "endsAfter"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Linking an earlier ending to a later ending event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#endsBefore">event:endsBefore</a>
    /// </summary>
    let endsBefore = _prefixId.prefix "endsBefore"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Specifying an event during which another event ends.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#endsDuring">event:endsDuring</a>
    /// </summary>
    let endsDuring = _prefixId.prefix "endsDuring"
    let evaluatedBy = _prefixId.prefix "evaluatedBy"
    let evaluatedDuring = _prefixId.prefix "evaluatedDuring"
    let evaluatedIn = _prefixId.prefix "evaluatedIn"
    let evaluationOf = _prefixId.prefix "evaluationOf"
    /// <summary>
    ///   <para>rdfs:label : examination of</para>
    ///   <para>skos:definition : Specifying something examined.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#examinationOf">event:examinationOf</a>
    /// </summary>
    let examinationOf = _prefixId.prefix "examinationOf"
    /// <summary>
    ///   <para>skos:definition : Specifying an examinator of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#examinedBy">event:examinedBy</a>
    /// </summary>
    let examinedBy = _prefixId.prefix "examinedBy"
    /// <summary>
    ///   <para>skos:definition : Specifying a period wherein something is examined.</para>
    ///   <para>rdfs:comment : The longer ago, the broader a timescope; e.g. examined in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; examined in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; examined last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; examined Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#examinedDuring">event:examinedDuring</a>
    /// </summary>
    let examinedDuring = _prefixId.prefix "examinedDuring"
    /// <summary>
    ///   <para>rdfs:label : examining of</para>
    ///   <para>skos:definition : Specifying something being examined.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#examiningOf">event:examiningOf</a>
    /// </summary>
    let examiningOf = _prefixId.prefix "examiningOf"
    /// <summary>
    ///   <para>skos:definition : Specifying an existence of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#exists">event:exists</a>
    /// </summary>
    let exists = _prefixId.prefix "exists"
    /// <summary>
    ///   <para>skos:definition : Specifying a date time on which something exists.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#existsOn">event:existsOn</a>
    /// </summary>
    let existsOn = _prefixId.prefix "existsOn"
    /// <summary>
    ///   <para>skos:definition : Specifying an end of a state of something, e.g. of eadibility of food, of validity of a license.skos:definition : Specifying an end of a state of something, e.g. of the eadibility of food, validity of a license.</para>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#expires">event:expires</a>
    /// </summary>
    let expires = _prefixId.prefix "expires"
    /// <summary>
    ///   <para>skos:definition : Specifying something an agent got delivered.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#gotDelivered">event:gotDelivered</a>
    /// </summary>
    let gotDelivered = _prefixId.prefix "gotDelivered"
    /// <summary>
    ///   <para>skos:definition : Specifying something an agent got examined.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#gotExamined">event:gotExamined</a>
    /// </summary>
    let gotExamined = _prefixId.prefix "gotExamined"
    /// <summary>
    ///   <para>skos:definition : Specifying something an agent got ordered.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#gotOrdered">event:gotOrdered</a>
    /// </summary>
    let gotOrdered = _prefixId.prefix "gotOrdered"
    /// <summary>
    ///   <para>skos:definition : Specifying an unwanted output of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAdverseOutput">event:hasAdverseOutput</a>
    /// </summary>
    let hasAdverseOutput = _prefixId.prefix "hasAdverseOutput"
    /// <summary>
    ///   <para>skos:definition : Specifying a duration of existence of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAge">event:hasAge</a>
    /// </summary>
    let hasAge = _prefixId.prefix "hasAge"
    /// <summary>
    ///   <para>skos:definition : Specifying whether something is available or not.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAvailabilityState">event:hasAvailabilityState</a>
    /// </summary>
    let hasAvailabilityState = _prefixId.prefix "hasAvailabilityState"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time of completion of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionDateTime">event:hasCompletionDateTime</a>
    /// </summary>
    let hasCompletionDateTime = _prefixId.prefix "hasCompletionDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a completion state of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionState">event:hasCompletionState</a>
    /// </summary>
    let hasCompletionState = _prefixId.prefix "hasCompletionState"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time on which something is contraindicated.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasContraindicationDateTime">event:hasContraindicationDateTime</a>
    /// </summary>
    let hasContraindicationDateTime = _prefixId.prefix "hasContraindicationDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a way a process relates to time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCourseMode">event:hasCourseMode</a>
    /// </summary>
    let hasCourseMode = _prefixId.prefix "hasCourseMode"
    /// <summary>
    ///   <para>skos:definition : Specifying something a creator has created.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreated">event:hasCreated</a>
    /// </summary>
    let hasCreated = _prefixId.prefix "hasCreated"
    /// <summary>
    ///   <para>skos:definition : Specifying a creation output of a creating.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreation">event:hasCreation</a>
    /// </summary>
    let hasCreation = _prefixId.prefix "hasCreation"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time as date on which something is created.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDate">event:hasCreationDate</a>
    /// </summary>
    let hasCreationDate = _prefixId.prefix "hasCreationDate"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time on which something is created.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDateTime">event:hasCreationDateTime</a>
    /// </summary>
    let hasCreationDateTime = _prefixId.prefix "hasCreationDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a creator acting in creating.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreator">event:hasCreator</a>
    /// </summary>
    let hasCreator = _prefixId.prefix "hasCreator"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Specifying a date of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDate">event:hasDate</a>
    /// </summary>
    let hasDate = _prefixId.prefix "hasDate"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Specifying a date time of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDateTime">event:hasDateTime</a>
    /// </summary>
    let hasDateTime = _prefixId.prefix "hasDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time of a delivery of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDateTime">event:hasDeliveryDateTime</a>
    /// </summary>
    let hasDeliveryDateTime = _prefixId.prefix "hasDeliveryDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a delay of a delivery of something expressed in days.</para>
    ///   <para>skos:note : Can be calculated in N3 rule.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDelay">event:hasDeliveryDelay</a>
    /// </summary>
    let hasDeliveryDelay = _prefixId.prefix "hasDeliveryDelay"
    /// <summary>
    ///   <para>skos:definition : Specifying whether something is demanded or not.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDemandState">event:hasDemandState</a>
    /// </summary>
    let hasDemandState = _prefixId.prefix "hasDemandState"
    let hasDiagnosis = _prefixId.prefix "hasDiagnosis"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://www.agfa.com/w3c/2009/clinicalEvaluation#&gt;.</para>
    ///   <para>skos:definition : Specifying a point in time of the dignosis of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisDateTime">event:hasDiagnosisDateTime</a>
    /// </summary>
    let hasDiagnosisDateTime = _prefixId.prefix "hasDiagnosisDateTime"
    let hasDiagnosisState = _prefixId.prefix "hasDiagnosisState"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent playing the role of donor in delivering something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDonor">event:hasDonor</a>
    /// </summary>
    let hasDonor = _prefixId.prefix "hasDonor"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalization in a rule enabling reasoning with duration values.</para>
    ///   <para>skos:definition : Specifying a duration of an event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDuration">event:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>skos:definition : Specifying a procedure as last subprocedure of a another procedure.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEndProcedure">event:hasEndProcedure</a>
    /// </summary>
    let hasEndProcedure = _prefixId.prefix "hasEndProcedure"
    /// <summary>
    ///   <para>skos:definition : Specifying a way a process goes out of existence.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEndingMode">event:hasEndingMode</a>
    /// </summary>
    let hasEndingMode = _prefixId.prefix "hasEndingMode"
    let hasEvaluated = _prefixId.prefix "hasEvaluated"
    let hasEvaluation = _prefixId.prefix "hasEvaluation"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://www.agfa.com/w3c/2009/clinicalEvaluation#&gt;.</para>
    ///   <para>skos:definition : Specifying a point in time of an evaluation of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluationDateTime">event:hasEvaluationDateTime</a>
    /// </summary>
    let hasEvaluationDateTime = _prefixId.prefix "hasEvaluationDateTime"
    /// <summary>
    ///   <para>rdfs:label : has event</para>
    ///   <para>skos:definition : Specifying someone or something (eg. organisation, procedure, event, activity, etc) having an event).</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvent">event:hasEvent</a>
    /// </summary>
    let hasEvent = _prefixId.prefix "hasEvent"
    /// <summary>
    ///   <para>skos:definition : Specifying something examined by an examinator.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasExamined">event:hasExamined</a>
    /// </summary>
    let hasExamined = _prefixId.prefix "hasExamined"
    /// <summary>
    ///   <para>rdfs:label : has examining</para>
    ///   <para>skos:definition : Specifying an examining of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasExamining">event:hasExamining</a>
    /// </summary>
    let hasExamining = _prefixId.prefix "hasExamining"
    let hasFindingDateTime = _prefixId.prefix "hasFindingDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time on which something is indicated.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIndicationDateTime">event:hasIndicationDateTime</a>
    /// </summary>
    let hasIndicationDateTime = _prefixId.prefix "hasIndicationDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying an input of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasInput">event:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    let hasIntent = _prefixId.prefix "hasIntent"
    let hasIntentionState = _prefixId.prefix "hasIntentionState"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time of the last update of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLastUpdateDateTime">event:hasLastUpdateDateTime</a>
    /// </summary>
    let hasLastUpdateDateTime = _prefixId.prefix "hasLastUpdateDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time of a latest submission of something.</para>
    ///   <para>rdfs:comment : As used in an N3 rule.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionDateTime">event:hasLatestSubmissionDateTime</a>
    /// </summary>
    let hasLatestSubmissionDateTime = _prefixId.prefix "hasLatestSubmissionDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a latest submission state of something.</para>
    ///   <para>rdfs:comment : As used in an N3 rule.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionState">event:hasLatestSubmissionState</a>
    /// </summary>
    let hasLatestSubmissionState = _prefixId.prefix "hasLatestSubmissionState"
    /// <summary>
    ///   <para>skos:definition : Specifying a modification as output of a modifying.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModification">event:hasModification</a>
    /// </summary>
    let hasModification = _prefixId.prefix "hasModification"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time on which something is modified.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModificationDateTime">event:hasModificationDateTime</a>
    /// </summary>
    let hasModificationDateTime = _prefixId.prefix "hasModificationDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying something a modifier has modified.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModified">event:hasModified</a>
    /// </summary>
    let hasModified = _prefixId.prefix "hasModified"
    /// <summary>
    ///   <para>skos:definition : Specifying a modifier acting in modifying.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModifier">event:hasModifier</a>
    /// </summary>
    let hasModifier = _prefixId.prefix "hasModifier"
    /// <summary>
    ///   <para>skos:definition : Specifying a current moment's date and time.</para>
    ///   <para>rdfs:comment : Using the Unix Epoch time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasNow">event:hasNow</a>
    /// </summary>
    let hasNow = _prefixId.prefix "hasNow"
    /// <summary>
    ///   <para>skos:definition : Specifying a current moment's date.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasNowDate">event:hasNowDate</a>
    /// </summary>
    let hasNowDate = _prefixId.prefix "hasNowDate"
    /// <summary>
    ///   <para>skos:definition : Specifying an object of something.</para>
    ///   <para>rdfs:comment : E.g. a clinical finding, e.g. fever, as object of a clinical evaluation of a body temperature measurement; a disease as object of a diagnosis; a drug product as object of a prescription.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasObject">event:hasObject</a>
    /// </summary>
    let hasObject = _prefixId.prefix "hasObject"
    /// <summary>
    ///   <para>skos:definition : Specifying a way a process comes into existence.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOnsetMode">event:hasOnsetMode</a>
    /// </summary>
    let hasOnsetMode = _prefixId.prefix "hasOnsetMode"
    /// <summary>
    ///   <para>skos:definition : Specifying date time of an order of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOrderDateTime">event:hasOrderDateTime</a>
    /// </summary>
    let hasOrderDateTime = _prefixId.prefix "hasOrderDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a snapshot event's date on which something originates.</para>
    ///   <para>skos:note : The time part is implicitly zero and when the date is converted to date time the time part will be T00:00:00Z.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDate">event:hasOriginationDate</a>
    /// </summary>
    let hasOriginationDate = _prefixId.prefix "hasOriginationDate"
    /// <summary>
    ///   <para>skos:definition : Specifying a snapshot event's date and time on which something originates.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDateTime">event:hasOriginationDateTime</a>
    /// </summary>
    let hasOriginationDateTime = _prefixId.prefix "hasOriginationDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying an output of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutput">event:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>skos:definition : Specifying a date time of a process having an output.</para>
    ///   <para>rdfs:comment : Related to event:ends</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputDateTime">event:hasOutputDateTime</a>
    /// </summary>
    let hasOutputDateTime = _prefixId.prefix "hasOutputDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a likelihood of an output of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputLikelihood">event:hasOutputLikelihood</a>
    /// </summary>
    let hasOutputLikelihood = _prefixId.prefix "hasOutputLikelihood"
    /// <summary>
    ///   <para>skos:definition : Specifying an object of an output of a process.</para>
    ///   <para>rdfs:comment : E.g. a clinical finding, e.g. fever, as object of output of clinical evaluating of a body temperature measurement; a disease as object of a diagnosing; a drug product as object of a prescribing.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputObject">event:hasOutputObject</a>
    /// </summary>
    let hasOutputObject = _prefixId.prefix "hasOutputObject"
    let hasPathway = _prefixId.prefix "hasPathway"
    /// <summary>
    ///   <para>skos:definition : Specifying a priority state of an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasPriorityState">event:hasPriorityState</a>
    /// </summary>
    let hasPriorityState = _prefixId.prefix "hasPriorityState"
    /// <summary>
    ///   <para>skos:definition : Specifying a reason for an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasReason">event:hasReason</a>
    /// </summary>
    let hasReason = _prefixId.prefix "hasReason"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent playing the role of recipient in delivering something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasRecipient">event:hasRecipient</a>
    /// </summary>
    let hasRecipient = _prefixId.prefix "hasRecipient"
    /// <summary>
    ///   <para>skos:definition : Specifying a risk factor of an adverse process or output.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasRiskFactor">event:hasRiskFactor</a>
    /// </summary>
    let hasRiskFactor = _prefixId.prefix "hasRiskFactor"
    let hasSameBeginningAs = _prefixId.prefix "hasSameBeginningAs"
    let hasSameDurationAs = _prefixId.prefix "hasSameDurationAs"
    let hasSameEndAs = _prefixId.prefix "hasSameEndAs"
    let hasSameTimeAs = _prefixId.prefix "hasSameTimeAs"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Used in N3 rules calculating with date and duration using Unix Epoch time.</para>
    ///   <para>skos:definition : Specifying a snapshot event's date.</para>
    ///   <para>rdfs:comment : A snapshot is an event with coinciding beginning and end.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDate">event:hasSnapshotDate</a>
    /// </summary>
    let hasSnapshotDate = _prefixId.prefix "hasSnapshotDate"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Used in N3 rules calculating with date time and duration using Unix Epoch time.</para>
    ///   <para>skos:definition : Specifying a snapshot event's date and time.</para>
    ///   <para>rdfs:comment : A snapshot is an event with coinciding beginning and end.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDateTime">event:hasSnapshotDateTime</a>
    /// </summary>
    let hasSnapshotDateTime = _prefixId.prefix "hasSnapshotDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a sponsor of an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSponsor">event:hasSponsor</a>
    /// </summary>
    let hasSponsor = _prefixId.prefix "hasSponsor"
    /// <summary>
    ///   <para>skos:definition : Specifying a stage of a process.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasStage">event:hasStage</a>
    /// </summary>
    let hasStage = _prefixId.prefix "hasStage"
    /// <summary>
    ///   <para>skos:definition : Specifying a procedure as first subprocedure of a another procedure.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasStartProcedure">event:hasStartProcedure</a>
    /// </summary>
    let hasStartProcedure = _prefixId.prefix "hasStartProcedure"
    /// <summary>
    ///   <para>skos:definition : Specifying a state of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasState">event:hasState</a>
    /// </summary>
    let hasState = _prefixId.prefix "hasState"
    /// <summary>
    ///   <para>skos:definition : Specifying an action as part of a another action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubAction">event:hasSubAction</a>
    /// </summary>
    let hasSubAction = _prefixId.prefix "hasSubAction"
    /// <summary>
    ///   <para>rdfs:label : has sub output</para>
    ///   <para>skos:definition : Specifying an output as part of another output.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubOutput">event:hasSubOutput</a>
    /// </summary>
    let hasSubOutput = _prefixId.prefix "hasSubOutput"
    /// <summary>
    ///   <para>skos:definition : Specifying a procedure as part of a another procedure.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubProcedure">event:hasSubProcedure</a>
    /// </summary>
    let hasSubProcedure = _prefixId.prefix "hasSubProcedure"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time of submission of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionDateTime">event:hasSubmissionDateTime</a>
    /// </summary>
    let hasSubmissionDateTime = _prefixId.prefix "hasSubmissionDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a submission state of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionState">event:hasSubmissionState</a>
    /// </summary>
    let hasSubmissionState = _prefixId.prefix "hasSubmissionState"
    /// <summary>
    ///   <para>skos:definition : Specifying a susceptibility state of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityState">event:hasSusceptibilityState</a>
    /// </summary>
    let hasSusceptibilityState = _prefixId.prefix "hasSusceptibilityState"
    /// <summary>
    ///   <para>skos:definition : Specifying something for which something else has a susceptibility state.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityStateFor">event:hasSusceptibilityStateFor</a>
    /// </summary>
    let hasSusceptibilityStateFor = _prefixId.prefix "hasSusceptibilityStateFor"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time of validation of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasValidationDateTime">event:hasValidationDateTime</a>
    /// </summary>
    let hasValidationDateTime = _prefixId.prefix "hasValidationDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a validity state of something validated.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasValidityState">event:hasValidityState</a>
    /// </summary>
    let hasValidityState = _prefixId.prefix "hasValidityState"
    /// <summary>
    ///   <para>skos:definition : Specifying a snapshot event's date and time on which something stops to exist.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasVanishingDateTime">event:hasVanishingDateTime</a>
    /// </summary>
    let hasVanishingDateTime = _prefixId.prefix "hasVanishingDateTime"
    /// <summary>
    ///   <para>skos:definition : Specifying a warning message for something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasWarning">event:hasWarning</a>
    /// </summary>
    let hasWarning = _prefixId.prefix "hasWarning"
    /// <summary>
    ///   <para>skos:definition : Specifying for an event one of the 7 days of the week in the Gregorian calendar.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#hasWeekday">event:hasWeekday</a>
    /// </summary>
    let hasWeekday = _prefixId.prefix "hasWeekday"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Specifying an event happening during another event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#includes">event:includes</a>
    /// </summary>
    let includes = _prefixId.prefix "includes"
    /// <summary>
    ///   <para>skos:definition : Specifying an indication for an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#indicatedBy">event:indicatedBy</a>
    /// </summary>
    let indicatedBy = _prefixId.prefix "indicatedBy"
    /// <summary>
    ///   <para>skos:definition : Specifying an action having an indication.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#indicates">event:indicates</a>
    /// </summary>
    let indicates = _prefixId.prefix "indicates"
    /// <summary>
    ///   <para>skos:definition : Specifying a process having an input.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#inputOf">event:inputOf</a>
    /// </summary>
    let inputOf = _prefixId.prefix "inputOf"
    /// <summary>
    ///   <para>skos:definition : Specifying something something else is intermediately susceptible to.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#intermediatelySusceptibleTo">event:intermediatelySusceptibleTo</a>
    /// </summary>
    let intermediatelySusceptibleTo = _prefixId.prefix "intermediatelySusceptibleTo"
    /// <summary>
    ///   <para>rdfs:label : is associated with</para>
    ///   <para>skos:definition : Specifying something (eg. event, activity, etc) wich is associated with something else (eg. event, activity, etc).</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#isAssociatedWith">event:isAssociatedWith</a>
    /// </summary>
    let isAssociatedWith = _prefixId.prefix "isAssociatedWith"
    /// <summary>
    ///   <para>skos:definition : Specifying an action having a reason.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#isReasonFor">event:isReasonFor</a>
    /// </summary>
    let isReasonFor = _prefixId.prefix "isReasonFor"
    /// <summary>
    ///   <para>skos:definition : Specifying something modified.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#modificationOf">event:modificationOf</a>
    /// </summary>
    let modificationOf = _prefixId.prefix "modificationOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a modifier of something modified.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#modifiedBy">event:modifiedBy</a>
    /// </summary>
    let modifiedBy = _prefixId.prefix "modifiedBy"
    /// <summary>
    ///   <para>skos:definition : Specifying a modifying wherein something is modified.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#modifiedIn">event:modifiedIn</a>
    /// </summary>
    let modifiedIn = _prefixId.prefix "modifiedIn"
    /// <summary>
    ///   <para>rdfs:label : non-compliant with</para>
    ///   <para>skos:definition : Specifying something something else does not comply with.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#nonCompliantWith">event:nonCompliantWith</a>
    /// </summary>
    let nonCompliantWith = _prefixId.prefix "nonCompliantWith"
    /// <summary>
    ///   <para>skos:definition : Specifying a period during which an action is not performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#notPerformedDuring">event:notPerformedDuring</a>
    /// </summary>
    let notPerformedDuring = _prefixId.prefix "notPerformedDuring"
    /// <summary>
    ///   <para>skos:definition : Specifying something having an object.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#objectOf">event:objectOf</a>
    /// </summary>
    let objectOf = _prefixId.prefix "objectOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a period during which something is observed.</para>
    ///   <para>rdfs:comment : The longer ago, the broader a timescope; e.g. observed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; observed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; observed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; observed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#observedDuring">event:observedDuring</a>
    /// </summary>
    let observedDuring = _prefixId.prefix "observedDuring"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent obtaining something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#obtainedBy">event:obtainedBy</a>
    /// </summary>
    let obtainedBy = _prefixId.prefix "obtainedBy"
    /// <summary>
    ///   <para>skos:definition : Specifying a period wherein something is obtained.</para>
    ///   <para>rdfs:comment : The longer ago, the broader a timescope; e.g. obtained in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; obtained in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; obtained last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; obtained Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#obtainedDuring">event:obtainedDuring</a>
    /// </summary>
    let obtainedDuring = _prefixId.prefix "obtainedDuring"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time of .</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#openFrom">event:openFrom</a>
    /// </summary>
    let openFrom = _prefixId.prefix "openFrom"
    /// <summary>
    ///   <para>skos:definition : Specifying a point in time of .</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#openUntil">event:openUntil</a>
    /// </summary>
    let openUntil = _prefixId.prefix "openUntil"
    /// <summary>
    ///   <para>skos:definition : Specifying something ordered, i.e. the object of an order.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#orderOf">event:orderOf</a>
    /// </summary>
    let orderOf = _prefixId.prefix "orderOf"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent something is ordered for.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#orderedFor">event:orderedFor</a>
    /// </summary>
    let orderedFor = _prefixId.prefix "orderedFor"
    /// <summary>
    ///   <para>skos:definition : Specifying an agent an order is directed to.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#orderedTo">event:orderedTo</a>
    /// </summary>
    let orderedTo = _prefixId.prefix "orderedTo"
    /// <summary>
    ///   <para>skos:definition : Specifying an environment wherein something originated.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#originatedIn">event:originatedIn</a>
    /// </summary>
    let originatedIn = _prefixId.prefix "originatedIn"
    /// <summary>
    ///   <para>skos:definition : Specifying a process having an object of its output.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#outputObjectOf">event:outputObjectOf</a>
    /// </summary>
    let outputObjectOf = _prefixId.prefix "outputObjectOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a process having an output.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#outputOf">event:outputOf</a>
    /// </summary>
    let outputOf = _prefixId.prefix "outputOf"
    let overlaps = _prefixId.prefix "overlaps"
    /// <summary>
    ///   <para>skos:definition : Specifying a period during which an action is performed.</para>
    ///   <para>rdfs:comment : The longer ago, the broader a timescope; e.g. performed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; performed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; performed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; performed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#performedDuring">event:performedDuring</a>
    /// </summary>
    let performedDuring = _prefixId.prefix "performedDuring"
    /// <summary>
    ///   <para>skos:definition : Specifying an environment wherein an action is performed.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#performedIn">event:performedIn</a>
    /// </summary>
    let performedIn = _prefixId.prefix "performedIn"
    /// <summary>
    ///   <para>skos:definition : Specifying an action described in a plan.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#planOf">event:planOf</a>
    /// </summary>
    let planOf = _prefixId.prefix "planOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a planning of an action.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#plannedIn">event:plannedIn</a>
    /// </summary>
    let plannedIn = _prefixId.prefix "plannedIn"
    /// <summary>
    ///   <para>skos:definition : Specifying something something else is resistant to.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#resistantTo">event:resistantTo</a>
    /// </summary>
    let resistantTo = _prefixId.prefix "resistantTo"
    /// <summary>
    ///   <para>skos:definition : Specifying an adverse process or output having a risk factor.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#riskFactorOf">event:riskFactorOf</a>
    /// </summary>
    let riskFactorOf = _prefixId.prefix "riskFactorOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a process having a stage.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#stageOf">event:stageOf</a>
    /// </summary>
    let stageOf = _prefixId.prefix "stageOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a period wherein a process is staged.</para>
    ///   <para>rdfs:comment : The longer ago, the broader a timescope; e.g. staged in 1986: formally stating a period 01/01/1986-31/12/1986; staged last year in May: stating a period 01/05/2010-31/05/2010; staged last week: stating a day 01/01/2012; staged yesterday: stating a moment 20/01/2012, 02PM.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#stagedDuring">event:stagedDuring</a>
    /// </summary>
    let stagedDuring = _prefixId.prefix "stagedDuring"
    /// <summary>
    ///   <para>skos:definition : Specifying a procedure another procedure is the first subprocedure of.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#startProcedureOf">event:startProcedureOf</a>
    /// </summary>
    let startProcedureOf = _prefixId.prefix "startProcedureOf"
    /// <summary>
    ///   <para>skos:definition : Specifying something having a state.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#stateOf">event:stateOf</a>
    /// </summary>
    let stateOf = _prefixId.prefix "stateOf"
    /// <summary>
    ///   <para>skos:definition : Specifying an action having another action as part.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#subActionOf">event:subActionOf</a>
    /// </summary>
    let subActionOf = _prefixId.prefix "subActionOf"
    /// <summary>
    ///   <para>skos:definition : Specifying an output having as part another output.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#subOutputOf">event:subOutputOf</a>
    /// </summary>
    let subOutputOf = _prefixId.prefix "subOutputOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a procedure having as part another procedure.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#subProcedureOf">event:subProcedureOf</a>
    /// </summary>
    let subProcedureOf = _prefixId.prefix "subProcedureOf"
    /// <summary>
    ///   <para>skos:definition : Specifying something for which there is a susceptibility state.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#susceptibilityStateFor">event:susceptibilityStateFor</a>
    /// </summary>
    let susceptibilityStateFor = _prefixId.prefix "susceptibilityStateFor"
    /// <summary>
    ///   <para>skos:definition : Specifying something something else is susceptible to.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#susceptibleTo">event:susceptibleTo</a>
    /// </summary>
    let susceptibleTo = _prefixId.prefix "susceptibleTo"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Linking a shorter to a longer event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#takesLessLongThan">event:takesLessLongThan</a>
    /// </summary>
    let takesLessLongThan = _prefixId.prefix "takesLessLongThan"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.skos:note : Further formalized in an N3 rule by calculation in http://eulersharp.sourceforge.net/2003/03swap/eventTime_rules.n3, enabling reasoning with date/time values.</para>
    ///   <para>skos:definition : Linking a longer to a shorter event.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#takesLongerThan">event:takesLongerThan</a>
    /// </summary>
    let takesLongerThan = _prefixId.prefix "takesLongerThan"
    /// <summary>
    ///   <para>skos:note : Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/time#&gt;.</para>
    ///   <para>skos:definition : Relating 2 events in time.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#timeRelatedTo">event:timeRelatedTo</a>
    /// </summary>
    let timeRelatedTo = _prefixId.prefix "timeRelatedTo"
    let transferOf = _prefixId.prefix "transferOf"
    /// <summary>
    ///   <para>skos:definition : Specifying a validity state of something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#validationOf">event:validationOf</a>
    /// </summary>
    let validationOf = _prefixId.prefix "validationOf"
    /// <summary>
    ///   <para>skos:definition : Specifying something created in a creating.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinCreated">event:whereinCreated</a>
    /// </summary>
    let whereinCreated = _prefixId.prefix "whereinCreated"
    /// <summary>
    ///   <para>skos:definition : Specifying a delivering wherein something is delivered.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinDelivered">event:whereinDelivered</a>
    /// </summary>
    let whereinDelivered = _prefixId.prefix "whereinDelivered"
    let whereinDiagnosed = _prefixId.prefix "whereinDiagnosed"
    let whereinEvaluated = _prefixId.prefix "whereinEvaluated"
    /// <summary>
    ///   <para>skos:definition : Specifying something modified in a modifying.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinModified">event:whereinModified</a>
    /// </summary>
    let whereinModified = _prefixId.prefix "whereinModified"
    let whereinTransferred = _prefixId.prefix "whereinTransferred"
    /// <summary>
    ///   <para>skos:definition : Specifying a susceptibility state for something.</para>
    ///   <a href="http://eulersharp.sourceforge.net/2003/03swap/event#wheretoSusceptibilityState">event:wheretoSusceptibilityState</a>
    /// </summary>
    let wheretoSusceptibilityState = _prefixId.prefix "wheretoSusceptibilityState"
