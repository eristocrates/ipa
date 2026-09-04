#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module demlab =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.demcare.eu/ontologies/demlab.owl#" "demlab"

    let ActivityStatusType = _prefixId.prefix "ActivityStatusType"
    /// <summary>
    ///   <para>rdfs:comment : - The phone is scheduled to ring 10 minutes after the entering of the participant inside the room.
    /// - During this task, the clinician explains that there is a mistake on the phone bill: the amount was wrong. Consequently, it is expected that the participant corrects his/her phone check and corrects the account balance (tasks normally established before the phone call according to the constraint).</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#AnswerPhoneTask">demlab:AnswerPhoneTask</a>
    /// </summary>
    let AnswerPhoneTask = _prefixId.prefix "AnswerPhoneTask"
    /// <summary>
    ///   <para>rdfs:comment : The participant is asked to pronounce repeatedly a predefined diadochokinetic “Pataka” token as rapid as possible stopping this action upon a sign by the clinician. The clinician will stop the action in 10 sec.
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech rate, pause rate etc.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#ArticulationControlTask">demlab:ArticulationControlTask</a>
    /// </summary>
    let ArticulationControlTask = _prefixId.prefix "ArticulationControlTask"
    /// <summary>
    ///   <para>rdfs:comment : Autonomy is assessed based on the performance of the participant during the SemiDirectedActivitiesStep. The property iadl_e (Instrumental Activities of Daily Living for Elderly) can be used to quantify autonomy</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#AutonomyAssessment">demlab:AutonomyAssessment</a>
    /// </summary>
    let AutonomyAssessment = _prefixId.prefix "AutonomyAssessment"
    /// <summary>
    ///   <para>rdfs:comment : - The participant has to call the psychologist. Two phone numbers are proposed to the participant (1 visit card of the hair dressing,+ 1 visit card of the CHUN with phone number of a psychologist).
    /// - According the constraint, the participant has to call the psychologist within the 5 first minutes.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#CallPsychologistTask">demlab:CallPsychologistTask</a>
    /// </summary>
    let CallPsychologistTask = _prefixId.prefix "CallPsychologistTask"
    /// <summary>
    ///   <para>rdfs:comment : Root concept for the five types of clinical assessment</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#ClinicalAssessment">demlab:ClinicalAssessment</a>
    /// </summary>
    let ClinicalAssessment = _prefixId.prefix "ClinicalAssessment"
    /// <summary>
    ///   <para>rdfs:comment : A ClinicalRecord contains information about the five types of clinical assessment</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#ClinicalRecord">demlab:ClinicalRecord</a>
    /// </summary>
    let ClinicalRecord = _prefixId.prefix "ClinicalRecord"
    /// <summary>
    ///   <para>rdfs:comment : The Cognitive abilities assessment is performed in terms of five scores:
    /// - Mini-Mental State Exam (MMSE).
    /// - Frontal Assessment Battery (FAB).
    /// - Trail making test A and B.
    /// - Short Cognitive Battery.
    /// - The Free and Cued Selective Reminding Test</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#CognitiveAbilitiesAssessment">demlab:CognitiveAbilitiesAssessment</a>
    /// </summary>
    let CognitiveAbilitiesAssessment = _prefixId.prefix "CognitiveAbilitiesAssessment"
    /// <summary>
    ///   <para>rdfs:comment : Explore functional abilities for the completion of specific activities</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#CognitiveAbilitiesData">demlab:CognitiveAbilitiesData</a>
    /// </summary>
    let CognitiveAbilitiesData = _prefixId.prefix "CognitiveAbilitiesData"
    /// <summary>
    ///   <para>rdfs:comment : (MonoTask) The participant is standing and the clinician asks him/her to count aloud backwards:
    /// - From 305 to 285 (to change tens and hundreds) one by one; or
    /// - From 20 to 0 if they make counting mistakes after 2 attempts of the previous backwards counting
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech fluency and articulation</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#CountingBackwardsTask">demlab:CountingBackwardsTask</a>
    /// </summary>
    let CountingBackwardsTask = _prefixId.prefix "CountingBackwardsTask"
    /// <summary>
    ///   <para>rdfs:comment : Diagnosis established the day of the recording session. Participant is assigned to one of this 3 categories: Healthy Control participants, Alzheimer’s disease at pre-dementia stage, Alzheimer ’s disease at dementia stage</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#DiagnosisAssessment">demlab:DiagnosisAssessment</a>
    /// </summary>
    let DiagnosisAssessment = _prefixId.prefix "DiagnosisAssessment"
    let DiagnosisType = _prefixId.prefix "DiagnosisType"
    /// <summary>
    ///   <para>rdfs:comment : This ProtocolStep is conducted by a clinician, who details step by step the different activities to do by the participant. This step involves five Tasks. The tasks Walking, CountingBackwards and WalkingAndCountingBackwards are used for characterizing participants’ gait in mono and dual tasks, and the impact of cognitive activity on gait (e.g., walking speed, step length, stops during the walking exercise done in dual task). The tasks SentenceRepeating and ArticulationControl are vocally-directed tasks: one task consists of repeating a sentence after the clinician (this task is repeated with three sentences), and the other is an articulation control exercise done to evaluate the neuromuscular mechanism of speech production.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#DirectedActivitiesStep">demlab:DirectedActivitiesStep</a>
    /// </summary>
    let DirectedActivitiesStep = _prefixId.prefix "DirectedActivitiesStep"
    let DirectedDiscussionTask = _prefixId.prefix "DirectedDiscussionTask"
    /// <summary>
    ///   <para>rdfs:comment : The clinician asks the same questions than the ones asked on the read article, e.g. What is the topic of the article?</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#DirectedExpressionTask">demlab:DirectedExpressionTask</a>
    /// </summary>
    let DirectedExpressionTask = _prefixId.prefix "DirectedExpressionTask"
    /// <summary>
    ///   <para>rdfs:comment : Root concept for grouping the Tasks relevant to the DirectedActivitiesStep</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#DirectedTask">demlab:DirectedTask</a>
    /// </summary>
    let DirectedTask = _prefixId.prefix "DirectedTask"
    /// <summary>
    ///   <para>rdfs:comment : - Assessment of the impact of cognitive load imposed by the picture description task on speech fluency
    /// - Memory and self-appraisal assessment
    /// - Verbal fluency and mood (Apathy) assessment</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionInvolvementData">demlab:DiscussionInvolvementData</a>
    /// </summary>
    let DiscussionInvolvementData = _prefixId.prefix "DiscussionInvolvementData"
    /// <summary>
    ///   <para>rdfs:comment : Root concept for grouping the Tasks relevant to the DiscussionWithClinicianStep
    ///
    /// The relevant tasks are used for assessing:
    /// - Stress level
    /// - Voice: e.g. speech rate, pause rate etc.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionTask">demlab:DiscussionTask</a>
    /// </summary>
    let DiscussionTask = _prefixId.prefix "DiscussionTask"
    /// <summary>
    ///   <para>rdfs:comment : This ProtocolStep involves two Tasks. The first task (DirectedExpressionTask) is a directed discussion during which the clinician assesses the episodic memory of participant through questions related to events and activities of SemiDirectedActivitiesStep. The second task (PictureDescriptionTask) assesses the verbal fluency and mood of participant using a picture that the participant has to describe (with the picture in the eyes) and then to involve a discussion about their interests for the activity represented. This part is done with two different pictures.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionWithClinicianStep">demlab:DiscussionWithClinicianStep</a>
    /// </summary>
    let DiscussionWithClinicianStep = _prefixId.prefix "DiscussionWithClinicianStep"
    /// <summary>
    ///   <para>rdfs:comment : - Three bills (Electricity/Gaz/Phone) are proposed. The account balance is given.
    /// - The participant has to establish the amount balance after having taken into account the three bills.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#EstablishAccountBalanceTask">demlab:EstablishAccountBalanceTask</a>
    /// </summary>
    let EstablishAccountBalanceTask = _prefixId.prefix "EstablishAccountBalanceTask"
    /// <summary>
    ///   <para>rdfs:comment : - A real bus map is showed to the participant with the indication of the current location of the participant.
    /// - The participant has to write on a sheet of paper located next to the bus map the bus lines to take for the itinerary (From Hospital to Station train). Two itineraries are accepted.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#FindBusLineOnMapTask">demlab:FindBusLineOnMapTask</a>
    /// </summary>
    let FindBusLineOnMapTask = _prefixId.prefix "FindBusLineOnMapTask"
    let FreeDiscussionTask = _prefixId.prefix "FreeDiscussionTask"
    /// <summary>
    ///   <para>rdfs:comment : Explore functional abilities for the completion of specific activities</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#FunctionalAbilitiesData">demlab:FunctionalAbilitiesData</a>
    /// </summary>
    let FunctionalAbilitiesData = _prefixId.prefix "FunctionalAbilitiesData"
    /// <summary>
    ///   <para>rdfs:comment : Gait assessment and impact of a cognitive activity on gait performance</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#GaitData">demlab:GaitData</a>
    /// </summary>
    let GaitData = _prefixId.prefix "GaitData"
    let HandTrajectoryType = _prefixId.prefix "HandTrajectoryType"
    /// <summary>
    ///   <para>rdfs:comment : A Healthy Control Participant is defined as the participant whose clinical record contains a healthy clinical diagnosis</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#HealthyControlParticipant">demlab:HealthyControlParticipant</a>
    /// </summary>
    let HealthyControlParticipant = _prefixId.prefix "HealthyControlParticipant"
    /// <summary>
    ///   <para>rdfs:comment : Explore the time of latency [stimulation, response] during the DirectedActivitiesTask (Explore sensitivity of this measure for assessing the apathy)</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#LatencyData">demlab:LatencyData</a>
    /// </summary>
    let LatencyData = _prefixId.prefix "LatencyData"
    /// <summary>
    ///   <para>rdfs:comment : The participant has to leave the room when he/she feels that all activities are performed and achieved</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#LeaveRoomTask">demlab:LeaveRoomTask</a>
    /// </summary>
    let LeaveRoomTask = _prefixId.prefix "LeaveRoomTask"
    /// <summary>
    ///   <para>rdfs:comment : MeasuredData is the root concept that groups the measurement types that are collected during the Tasks.^^xsd:string</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#MeasuredData">demlab:MeasuredData</a>
    /// </summary>
    let MeasuredData = _prefixId.prefix "MeasuredData"
    /// <summary>
    ///   <para>rdfs:comment : Motricity abilities assessment:
    /// - Part III of the Unified Parkinson’s Disease Rating Scale (UPDRS) .</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#MotricityAbilitiesAssessment">demlab:MotricityAbilitiesAssessment</a>
    /// </summary>
    let MotricityAbilitiesAssessment = _prefixId.prefix "MotricityAbilitiesAssessment"

    /// <summary>
    ///   <para>rdfs:comment : Neuropsychiatric/Mood assessments:
    /// - NPI
    /// - DSM-IV Criteria for depression
    /// - Apathy Inventory (AI) and diagnostic criteria for apathy.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#NeuropsychiatricAndMoodAssessment">demlab:NeuropsychiatricAndMoodAssessment</a>
    /// </summary>
    let NeuropsychiatricAndMoodAssessment =
        _prefixId.prefix "NeuropsychiatricAndMoodAssessment"

    /// <summary>
    ///   <para>rdfs:comment : Explore ability to organize with efficiency the different activities</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#OrganisationEfficiencyData">demlab:OrganisationEfficiencyData</a>
    /// </summary>
    let OrganisationEfficiencyData = _prefixId.prefix "OrganisationEfficiencyData"
    let Participant = _prefixId.prefix "Participant"
    /// <summary>
    ///   <para>rdfs:comment : - Three bills (Electricity/Gaz/Phone) are proposed. The participant has to pay the phone bill by check.
    /// - The check is well completed if the amount, order (i.e. Phone Company), date and signature are right.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#PayBillTask">demlab:PayBillTask</a>
    /// </summary>
    let PayBillTask = _prefixId.prefix "PayBillTask"
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:comment : A Person with Dementia is defined as the participant whose clinical record contains a dementia clinical diagnosis</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#PersonWithDementia">demlab:PersonWithDementia</a>
    /// </summary>
    let PersonWithDementia = _prefixId.prefix "PersonWithDementia"
    /// <summary>
    ///   <para>rdfs:comment : A Person with Predementia is defined as the participant whose clinical record contains a predementia clinical diagnosis</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#PersonWithPredementia">demlab:PersonWithPredementia</a>
    /// </summary>
    let PersonWithPredementia = _prefixId.prefix "PersonWithPredementia"
    /// <summary>
    ///   <para>rdfs:comment : The clinician shows to the participant one picture representing daily activity and asks the participants to give a verbal description of the picture in a few sentences</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#PictureDescriptionTask">demlab:PictureDescriptionTask</a>
    /// </summary>
    let PictureDescriptionTask = _prefixId.prefix "PictureDescriptionTask"
    /// <summary>
    ///   <para>rdfs:comment : The clinician asks if the participant likes doing this activity and why</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#PictureDiscussionTask">demlab:PictureDiscussionTask</a>
    /// </summary>
    let PictureDiscussionTask = _prefixId.prefix "PictureDiscussionTask"
    /// <summary>
    ///   <para>rdfs:comment : - 4 types of drugs are proposed to the participant.
    /// - The participant has to respect the posology prescribed (2 types of drugs at different moment of the day) and the date (day and moment of the day).</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#PrepareDrugBoxTask">demlab:PrepareDrugBoxTask</a>
    /// </summary>
    let PrepareDrugBoxTask = _prefixId.prefix "PrepareDrugBoxTask"
    /// <summary>
    ///   <para>rdfs:comment : - The participant has to switch on the electric kettle.
    /// - The participant has to pour the hot water on the glass containing the tea bag.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#PrepareHotTeaTask">demlab:PrepareHotTeaTask</a>
    /// </summary>
    let PrepareHotTeaTask = _prefixId.prefix "PrepareHotTeaTask"
    /// <summary>
    ///   <para>rdfs:comment : A Protocol instance contains information regarding the participant and the duration of the protocol session. It can be also associated with one or more ProtocolSteps that define the Tasks and the corresponding MeasuredData.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#Protocol">demlab:Protocol</a>
    /// </summary>
    let Protocol = _prefixId.prefix "Protocol"
    /// <summary>
    ///   <para>rdfs:comment : A ProtocolStep defines the Tasks of interest. Three ProtocolStep types are currently defined in Dem@Care: DirectedActivities, SemiDirectedActivities and DiscussionWithTheClinician</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#ProtocolStep">demlab:ProtocolStep</a>
    /// </summary>
    let ProtocolStep = _prefixId.prefix "ProtocolStep"
    /// <summary>
    ///   <para>rdfs:comment : Three articles are proposed to the participant (Topics: Collection Cars; Cooking; Sightseeing). The three articles have the same words number and level of difficulty. Below each articles, the 3 following questions are asked
    /// - Q1/ What is the topic of the article?
    /// - Q2/ What is the percentage of French interested in the … (Collection Car / Cooking / Sightseeing, text adapted to the article topic)?
    /// - Q3/ Who is interviewed?</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#ReadArticleTask">demlab:ReadArticleTask</a>
    /// </summary>
    let ReadArticleTask = _prefixId.prefix "ReadArticleTask"
    /// <summary>
    ///   <para>rdfs:comment : This ProtocolStep consists of assessing the autonomy of the participant. The participant has to organize himself/herself and correctly perform a list of Instrumental Activities of Daily Living (e.g., managing finance, using phone, preparing tea) within a timeframe of 15minutes. For this step, the participant is alone in the experimental setting and can refer to the instruction sheet of paper with the IADLs to perform at any time.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#SemiDirectedActivitiesStep">demlab:SemiDirectedActivitiesStep</a>
    /// </summary>
    let SemiDirectedActivitiesStep = _prefixId.prefix "SemiDirectedActivitiesStep"
    /// <summary>
    ///   <para>rdfs:comment : In this Task the participant has to organize himself/herself and correctly perform a list of Instrumental Activities of Daily Living (e.g., managing finance, using phone, preparing tea) within a timeframe of 15minutes.
    ///
    /// The relevant tasks are used for assessing:
    /// - Cognitive abilities through activity repetitions, missed activities, order of activities
    /// - Functional abilities for the completion of specific activities: e.g. hand trajectories
    /// - Stress level</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#SemiDirectedTask">demlab:SemiDirectedTask</a>
    /// </summary>
    let SemiDirectedTask = _prefixId.prefix "SemiDirectedTask"
    /// <summary>
    ///   <para>rdfs:comment : - The participant is asked to repeat a short sentence after the assessor.
    /// - The assessor reads aloud a sentence. The participant repeats the sentence. The action is done once by sentence. Three sentences must be repeated.
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. verbal reaction time</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#SentenceRepeatingTask">demlab:SentenceRepeatingTask</a>
    /// </summary>
    let SentenceRepeatingTask = _prefixId.prefix "SentenceRepeatingTask"
    /// <summary>
    ///   <para>rdfs:comment : Explore stress level</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#StressData">demlab:StressData</a>
    /// </summary>
    let StressData = _prefixId.prefix "StressData"
    /// <summary>
    ///   <para>rdfs:comment : Each Task involves the collection of one or more measurements (MeasuredData instances).rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#Task">demlab:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:comment : The TV is turn off. The participant has to take the remote control and turns on the TV</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#TurnOnTVTask">demlab:TurnOnTVTask</a>
    /// </summary>
    let TurnOnTVTask = _prefixId.prefix "TurnOnTVTask"
    /// <summary>
    ///   <para>rdfs:comment : - Vocal biomarkers extraction for cognitive load assessment
    /// - Assessment of mutual influence of cognitive activities an motor activities
    /// - Assessment of the verbal reaction time and the impact of cognitive load imposed by the sentence recall task on speech fluency
    /// - Assessment of the level of the participants’ control over the neuromuscular mechanism of speech production</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#VoiceData">demlab:VoiceData</a>
    /// </summary>
    let VoiceData = _prefixId.prefix "VoiceData"
    /// <summary>
    ///   <para>rdfs:comment : (DualTask) The clinician asks the participant to walk and count aloud backwards simultaneously:
    /// - From 305 until the end of the walking tasks; or
    /// - From 20 to 0 for participants who don’t manage to count backwards from 305 to 285 during the CountingBackwardsTask
    ///
    /// This task is used for assessing:
    /// - Gait: walking speed, step length, etc.
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech fluency and articulation</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#WalkingCountingBackwardsTask">demlab:WalkingCountingBackwardsTask</a>
    /// </summary>
    let WalkingCountingBackwardsTask = _prefixId.prefix "WalkingCountingBackwardsTask"
    /// <summary>
    ///   <para>rdfs:comment : (MonoTask) The clinician asks the participant to walk 4 meters across the room, to turn and then to come back (total walking distance: 8m).
    ///
    /// This task is used for assessing:
    /// - Gait: walking speed, step length, etc.
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#WalkingTask">demlab:WalkingTask</a>
    /// </summary>
    let WalkingTask = _prefixId.prefix "WalkingTask"
    /// <summary>
    ///   <para>rdfs:comment : The participant has to take the water can, and water the plant nearby.</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#WaterPlantTask">demlab:WaterPlantTask</a>
    /// </summary>
    let WaterPlantTask = _prefixId.prefix "WaterPlantTask"
    /// <summary>
    ///   <para>rdfs:comment : Allows the definition of zones (areas) of interest, e.g. phone zone</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#Zone">demlab:Zone</a>
    /// </summary>
    let Zone = _prefixId.prefix "Zone"
    /// <summary>
    ///   <para>rdfs:comment : The status of a semi-directed activity^^xsd:string</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#activityStatus">demlab:activityStatus</a>
    /// </summary>
    let activityStatus = _prefixId.prefix "activityStatus"
    /// <summary>
    ///   <para>rdfs:comment : Apathy Inventory (AI) and diagnostic criteria for apathy</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#apathyInventory">demlab:apathyInventory</a>
    /// </summary>
    let apathyInventory = _prefixId.prefix "apathyInventory"
    /// <summary>
    ///   <para>rdfs:comment : Zones of no interest</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#areasOfInterestExplored">demlab:areasOfInterestExplored</a>
    /// </summary>
    let areasOfInterestExplored = _prefixId.prefix "areasOfInterestExplored"
    /// <summary>
    ///   <para>rdfs:comment : Zones of interest</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#areasOfNoInterestExplored">demlab:areasOfNoInterestExplored</a>
    /// </summary>
    let areasOfNoInterestExplored = _prefixId.prefix "areasOfNoInterestExplored"
    /// <summary>
    ///   <para>rdfs:comment : Measures the articulation control of the participant</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#articulation">demlab:articulation</a>
    /// </summary>
    let articulation = _prefixId.prefix "articulation"
    let completed = _prefixId.prefix "completed"
    /// <summary>
    ///   <para>rdfs:comment : Whether the participant followed the activity order suggested by the instructions sheet</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#compliantInstructionsOrder">demlab:compliantInstructionsOrder</a>
    /// </summary>
    let compliantInstructionsOrder = _prefixId.prefix "compliantInstructionsOrder"
    /// <summary>
    ///   <para>rdfs:comment : A ClinicalRecord contains a ClinicalAssessment^^xsd:string</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#containsAssessment">demlab:containsAssessment</a>
    /// </summary>
    let containsAssessment = _prefixId.prefix "containsAssessment"
    let dementia = _prefixId.prefix "dementia"
    /// <summary>
    ///   <para>rdfs:comment : Total distance walked</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#distanceWalked">demlab:distanceWalked</a>
    /// </summary>
    let distanceWalked = _prefixId.prefix "distanceWalked"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://en.wikipedia.org/wiki/Diagnostic_and_Statistical_Manual_of_Mental_Disorders</para>
    ///   <para>rdfs:comment : DSM-IV Criteria for depression</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#dsm_ivDepressionCriteria">demlab:dsm_ivDepressionCriteria</a>
    /// </summary>
    let dsm_ivDepressionCriteria = _prefixId.prefix "dsm_ivDepressionCriteria"
    /// <summary>
    ///   <para>rdfs:comment : Dynamical balance during the walking (e.g., people trajectory study)</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#dynamicBalance">demlab:dynamicBalance</a>
    /// </summary>
    let dynamicBalance = _prefixId.prefix "dynamicBalance"
    /// <summary>
    ///   <para>rdfs:comment : Frontal Assessment Battery score</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#fabScore">demlab:fabScore</a>
    /// </summary>
    let fabScore = _prefixId.prefix "fabScore"

    /// <summary>
    ///   <para>rdfs:comment : The Free and Cued Selective Reminding Test</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#freeAndCuedRemindingAssessment">demlab:freeAndCuedRemindingAssessment</a>
    /// </summary>
    let freeAndCuedRemindingAssessment =
        _prefixId.prefix "freeAndCuedRemindingAssessment"

    /// <summary>
    ///   <para>rdfs:comment : Associates an instance of FunctionalAbilitiesData with a hand trajectory type</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#handTrajectory">demlab:handTrajectory</a>
    /// </summary>
    let handTrajectory = _prefixId.prefix "handTrajectory"
    /// <summary>
    ///   <para>rdfs:comment : The value of the DiagnosisAssessment</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#hasClinicalDiagnosis">demlab:hasClinicalDiagnosis</a>
    /// </summary>
    let hasClinicalDiagnosis = _prefixId.prefix "hasClinicalDiagnosis"
    /// <summary>
    ///   <para>rdfs:comment : Each participant is associated with a clinical record</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#hasClinicalRecord">demlab:hasClinicalRecord</a>
    /// </summary>
    let hasClinicalRecord = _prefixId.prefix "hasClinicalRecord"
    /// <summary>
    ///   <para>rdfs:comment : Mini-Mental State Exam score</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#hasMMSEScore">demlab:hasMMSEScore</a>
    /// </summary>
    let hasMMSEScore = _prefixId.prefix "hasMMSEScore"
    /// <summary>
    ///   <para>rdfs:comment : The participant of the protocol</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#hasParticipant">demlab:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:comment : Each Protocol consists of one or more ProtocolSteps</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#hasProtocolStep">demlab:hasProtocolStep</a>
    /// </summary>
    let hasProtocolStep = _prefixId.prefix "hasProtocolStep"
    /// <summary>
    ///   <para>rdfs:comment : Part III of the Unified Parkinson’s Disease Rating Scale</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#hasUPDRSScore">demlab:hasUPDRSScore</a>
    /// </summary>
    let hasUPDRSScore = _prefixId.prefix "hasUPDRSScore"
    let healthy = _prefixId.prefix "healthy"
    /// <summary>
    ///   <para>rdfs:comment : Allows the quantification of autonomy</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#iadl_e">demlab:iadl_e</a>
    /// </summary>
    let iadl_e = _prefixId.prefix "iadl_e"
    let incomplete = _prefixId.prefix "incomplete"
    /// <summary>
    ///   <para>rdfs:comment : Each ProtocolStep involves one or more Tasks</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#involvesTask">demlab:involvesTask</a>
    /// </summary>
    let involvesTask = _prefixId.prefix "involvesTask"
    let isClinicalRecordOf = _prefixId.prefix "isClinicalRecordOf"
    /// <summary>
    ///   <para>rdfs:comment : Time of latency between the end of instructions (stimulation) and the beginning of the task</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#latency">demlab:latency</a>
    /// </summary>
    let latency = _prefixId.prefix "latency"
    /// <summary>
    ///   <para>rdfs:seeAlso : Associates a Task with a MeasuredData instance</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#measuredData">demlab:measuredData</a>
    /// </summary>
    let measuredData = _prefixId.prefix "measuredData"
    /// <summary>
    ///   <para>rdfs:comment : Neuropsychiatric Inventory</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#npi">demlab:npi</a>
    /// </summary>
    let npi = _prefixId.prefix "npi"
    let omitted = _prefixId.prefix "omitted"
    let participates = _prefixId.prefix "participates"
    /// <summary>
    ///   <para>rdfs:comment : Pause rate during sentence repetition and mono/dual tasks</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#pauseRate">demlab:pauseRate</a>
    /// </summary>
    let pauseRate = _prefixId.prefix "pauseRate"
    let predementia = _prefixId.prefix "predementia"
    /// <summary>
    ///   <para>rdfs:comment : Number of repetitions during semi-directed activities</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#repetitions">demlab:repetitions</a>
    /// </summary>
    let repetitions = _prefixId.prefix "repetitions"

    /// <summary>
    ///   <para>rdfs:comment : Short Cognitive Battery</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#shortCognitiveBatteryAssessment">demlab:shortCognitiveBatteryAssessment</a>
    /// </summary>
    let shortCognitiveBatteryAssessment =
        _prefixId.prefix "shortCognitiveBatteryAssessment"

    /// <summary>
    ///   <para>rdfs:comment : Speech fluency during sentence repetition and picture description tasks</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#speechFluency">demlab:speechFluency</a>
    /// </summary>
    let speechFluency = _prefixId.prefix "speechFluency"
    /// <summary>
    ///   <para>rdfs:comment : Speech fluency during sentence repetition and picture description tasks</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#speechRate">demlab:speechRate</a>
    /// </summary>
    let speechRate = _prefixId.prefix "speechRate"
    /// <summary>
    ///   <para>rdfs:comment : Step length</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#stepLength">demlab:stepLength</a>
    /// </summary>
    let stepLength = _prefixId.prefix "stepLength"
    /// <summary>
    ///   <para>rdfs:comment : Stopping displacement during walking</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#stoppingDisplacement">demlab:stoppingDisplacement</a>
    /// </summary>
    let stoppingDisplacement = _prefixId.prefix "stoppingDisplacement"
    /// <summary>
    ///   <para>rdfs:seeAlso : Stress level</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#stressLevel">demlab:stressLevel</a>
    /// </summary>
    let stressLevel = _prefixId.prefix "stressLevel"
    /// <summary>
    ///   <para>rdfs:comment : Trail making test A and B</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#trailMakingTest">demlab:trailMakingTest</a>
    /// </summary>
    let trailMakingTest = _prefixId.prefix "trailMakingTest"
    /// <summary>
    ///   <para>rdfs:comment : Time between the end of assessor’s speech and the beginning of participant’s speech (Discussion Task)</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#verbalReactionSpontaneity">demlab:verbalReactionSpontaneity</a>
    /// </summary>
    let verbalReactionSpontaneity = _prefixId.prefix "verbalReactionSpontaneity"
    /// <summary>
    ///   <para>rdfs:comment : Time interval between the end of assessor’s speech and the beginning of participant’s speech (Sentence Repetition Task)</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#verbalReactionTime">demlab:verbalReactionTime</a>
    /// </summary>
    let verbalReactionTime = _prefixId.prefix "verbalReactionTime"
    /// <summary>
    ///   <para>rdfs:seeAlso : Vowel duration</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#vowelDuration">demlab:vowelDuration</a>
    /// </summary>
    let vowelDuration = _prefixId.prefix "vowelDuration"
    /// <summary>
    ///   <para>rdfs:comment : Walking speed</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#walkingSpeed">demlab:walkingSpeed</a>
    /// </summary>
    let walkingSpeed = _prefixId.prefix "walkingSpeed"
    /// <summary>
    ///   <para>rdfs:comment : Walking speed instantaneous (mono task walking activity/dual task)</para>
    ///   <a href="http://www.demcare.eu/ontologies/demlab.owl#walkingSpeedInstantaneous">demlab:walkingSpeedInstantaneous</a>
    /// </summary>
    let walkingSpeedInstantaneous = _prefixId.prefix "walkingSpeedInstantaneous"
