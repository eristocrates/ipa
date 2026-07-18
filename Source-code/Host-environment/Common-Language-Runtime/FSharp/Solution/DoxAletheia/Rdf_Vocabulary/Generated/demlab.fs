namespace http.www.demcare.eu.ontologies.demlab.owl.hash

open DoxAletheia.Rdf_Vocabulary

module demlab =
    let _namespace_name = "http://www.demcare.eu/ontologies/demlab.owl#"

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#ActivityStatusType"></see>
    /// </summary>
    let ActivityStatusType =
        Namespaced_IRI.parse _namespace_name "ActivityStatusType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#completed"></see>
    /// </summary>
    let completed = Namespaced_IRI.parse _namespace_name "completed" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#incomplete"></see>
    /// </summary>
    let incomplete = Namespaced_IRI.parse _namespace_name "incomplete" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#omitted"></see>
    /// </summary>
    let omitted = Namespaced_IRI.parse _namespace_name "omitted" |> NamespacedName

    /// <summary>
    /// - The phone is scheduled to ring 10 minutes after the entering of the participant inside the room.
    /// - During this task, the clinician explains that there is a mistake on the phone bill: the amount was wrong. Consequently, it is expected that the participant corrects his/her phone check and corrects the account balance (tasks normally established before the phone call according to the constraint).
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#AnswerPhoneTask"></see></summary>
    let AnswerPhoneTask =
        Namespaced_IRI.parse _namespace_name "AnswerPhoneTask" |> NamespacedName

    /// <summary>
    /// In this Task the participant has to organize himself/herself and correctly perform a list of Instrumental Activities of Daily Living (e.g., managing finance, using phone, preparing tea) within a timeframe of 15minutes.
    ///
    /// The relevant tasks are used for assessing:
    /// - Cognitive abilities through activity repetitions, missed activities, order of activities
    /// - Functional abilities for the completion of specific activities: e.g. hand trajectories
    /// - Stress level
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#SemiDirectedTask"></see></summary>
    let SemiDirectedTask =
        Namespaced_IRI.parse _namespace_name "SemiDirectedTask" |> NamespacedName

    /// <summary>
    /// The participant is asked to pronounce repeatedly a predefined diadochokinetic “Pataka” token as rapid as possible stopping this action upon a sign by the clinician. The clinician will stop the action in 10 sec.
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech rate, pause rate etc.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#ArticulationControlTask"></see></summary>
    let ArticulationControlTask =
        Namespaced_IRI.parse _namespace_name "ArticulationControlTask" |> NamespacedName

    /// <summary>
    /// Explore the time of latency [stimulation, response] during the DirectedActivitiesTask (Explore sensitivity of this measure for assessing the apathy)
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#LatencyData"></see></summary>
    let LatencyData =
        Namespaced_IRI.parse _namespace_name "LatencyData" |> NamespacedName

    /// <summary>
    /// Explore stress level
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#StressData"></see></summary>
    let StressData = Namespaced_IRI.parse _namespace_name "StressData" |> NamespacedName
    /// <summary>
    /// - Vocal biomarkers extraction for cognitive load assessment
    /// - Assessment of mutual influence of cognitive activities an motor activities
    /// - Assessment of the verbal reaction time and the impact of cognitive load imposed by the sentence recall task on speech fluency
    /// - Assessment of the level of the participants’ control over the neuromuscular mechanism of speech production
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#VoiceData"></see></summary>
    let VoiceData = Namespaced_IRI.parse _namespace_name "VoiceData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#measuredData"></see>
    /// </summary>
    let measuredData =
        Namespaced_IRI.parse _namespace_name "measuredData" |> NamespacedName

    /// <summary>
    /// Root concept for grouping the Tasks relevant to the DirectedActivitiesStep
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#DirectedTask"></see></summary>
    let DirectedTask =
        Namespaced_IRI.parse _namespace_name "DirectedTask" |> NamespacedName

    /// <summary>
    /// Autonomy is assessed based on the performance of the participant during the SemiDirectedActivitiesStep. The property iadl_e (Instrumental Activities of Daily Living for Elderly) can be used to quantify autonomy
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#AutonomyAssessment"></see></summary>
    let AutonomyAssessment =
        Namespaced_IRI.parse _namespace_name "AutonomyAssessment" |> NamespacedName

    /// <summary>
    /// Allows the quantification of autonomy
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#iadl_e"></see></summary>
    let iadl_e = Namespaced_IRI.parse _namespace_name "iadl_e" |> NamespacedName

    /// <summary>
    /// This ProtocolStep consists of assessing the autonomy of the participant. The participant has to organize himself/herself and correctly perform a list of Instrumental Activities of Daily Living (e.g., managing finance, using phone, preparing tea) within a timeframe of 15minutes. For this step, the participant is alone in the experimental setting and can refer to the instruction sheet of paper with the IADLs to perform at any time.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#SemiDirectedActivitiesStep"></see></summary>
    let SemiDirectedActivitiesStep =
        Namespaced_IRI.parse _namespace_name "SemiDirectedActivitiesStep" |> NamespacedName

    /// <summary>
    /// Root concept for the five types of clinical assessment
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#ClinicalAssessment"></see></summary>
    let ClinicalAssessment =
        Namespaced_IRI.parse _namespace_name "ClinicalAssessment" |> NamespacedName

    /// <summary>
    /// - The participant has to call the psychologist. Two phone numbers are proposed to the participant (1 visit card of the hair dressing,+ 1 visit card of the CHUN with phone number of a psychologist).
    /// - According the constraint, the participant has to call the psychologist within the 5 first minutes.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#CallPsychologistTask"></see></summary>
    let CallPsychologistTask =
        Namespaced_IRI.parse _namespace_name "CallPsychologistTask" |> NamespacedName

    /// <summary>
    /// Neuropsychiatric/Mood assessments:
    /// - NPI
    /// - DSM-IV Criteria for depression
    /// - Apathy Inventory (AI) and diagnostic criteria for apathy.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#NeuropsychiatricAndMoodAssessment"></see></summary>
    let NeuropsychiatricAndMoodAssessment =
        Namespaced_IRI.parse _namespace_name "NeuropsychiatricAndMoodAssessment" |> NamespacedName

    /// <summary>
    /// Motricity abilities assessment:
    /// - Part III of the Unified Parkinson’s Disease Rating Scale (UPDRS) .
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#MotricityAbilitiesAssessment"></see></summary>
    let MotricityAbilitiesAssessment =
        Namespaced_IRI.parse _namespace_name "MotricityAbilitiesAssessment" |> NamespacedName

    /// <summary>
    /// Diagnosis established the day of the recording session. Participant is assigned to one of this 3 categories: Healthy Control participants, Alzheimer’s disease at pre-dementia stage, Alzheimer ’s disease at dementia stage
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#DiagnosisAssessment"></see></summary>
    let DiagnosisAssessment =
        Namespaced_IRI.parse _namespace_name "DiagnosisAssessment" |> NamespacedName

    /// <summary>
    /// The Cognitive abilities assessment is performed in terms of five scores:
    /// - Mini-Mental State Exam (MMSE).
    /// - Frontal Assessment Battery (FAB).
    /// - Trail making test A and B.
    /// - Short Cognitive Battery.
    /// - The Free and Cued Selective Reminding Test
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#CognitiveAbilitiesAssessment"></see></summary>
    let CognitiveAbilitiesAssessment =
        Namespaced_IRI.parse _namespace_name "CognitiveAbilitiesAssessment" |> NamespacedName

    /// <summary>
    /// A ClinicalRecord contains information about the five types of clinical assessment
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#ClinicalRecord"></see></summary>
    let ClinicalRecord =
        Namespaced_IRI.parse _namespace_name "ClinicalRecord" |> NamespacedName

    /// <summary>
    /// A ClinicalRecord contains a ClinicalAssessment
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#containsAssessment"></see></summary>
    let containsAssessment =
        Namespaced_IRI.parse _namespace_name "containsAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#Participant"></see>
    /// </summary>
    let Participant =
        Namespaced_IRI.parse _namespace_name "Participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#isClinicalRecordOf"></see>
    /// </summary>
    let isClinicalRecordOf =
        Namespaced_IRI.parse _namespace_name "isClinicalRecordOf" |> NamespacedName

    /// <summary>
    /// Mini-Mental State Exam score
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#hasMMSEScore"></see></summary>
    let hasMMSEScore =
        Namespaced_IRI.parse _namespace_name "hasMMSEScore" |> NamespacedName

    /// <summary>
    /// Trail making test A and B
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#trailMakingTest"></see></summary>
    let trailMakingTest =
        Namespaced_IRI.parse _namespace_name "trailMakingTest" |> NamespacedName

    /// <summary>
    /// Frontal Assessment Battery score
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#fabScore"></see></summary>
    let fabScore = Namespaced_IRI.parse _namespace_name "fabScore" |> NamespacedName

    /// <summary>
    /// The Free and Cued Selective Reminding Test
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#freeAndCuedRemindingAssessment"></see></summary>
    let freeAndCuedRemindingAssessment =
        Namespaced_IRI.parse _namespace_name "freeAndCuedRemindingAssessment" |> NamespacedName

    /// <summary>
    /// Short Cognitive Battery
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#shortCognitiveBatteryAssessment"></see></summary>
    let shortCognitiveBatteryAssessment =
        Namespaced_IRI.parse _namespace_name "shortCognitiveBatteryAssessment" |> NamespacedName

    /// <summary>
    /// Explore functional abilities for the completion of specific activities
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#CognitiveAbilitiesData"></see></summary>
    let CognitiveAbilitiesData =
        Namespaced_IRI.parse _namespace_name "CognitiveAbilitiesData" |> NamespacedName

    /// <summary>
    /// The status of a semi-directed activity
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#activityStatus"></see></summary>
    let activityStatus =
        Namespaced_IRI.parse _namespace_name "activityStatus" |> NamespacedName

    /// <summary>
    /// Number of repetitions during semi-directed activities
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#repetitions"></see></summary>
    let repetitions =
        Namespaced_IRI.parse _namespace_name "repetitions" |> NamespacedName

    /// <summary>
    /// Whether the participant followed the activity order suggested by the instructions sheet
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#compliantInstructionsOrder"></see></summary>
    let compliantInstructionsOrder =
        Namespaced_IRI.parse _namespace_name "compliantInstructionsOrder" |> NamespacedName

    /// <summary>
    /// MeasuredData is the root concept that groups the measurement types that are collected during the Tasks.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#MeasuredData"></see></summary>
    let MeasuredData =
        Namespaced_IRI.parse _namespace_name "MeasuredData" |> NamespacedName

    /// <summary>
    /// (MonoTask) The participant is standing and the clinician asks him/her to count aloud backwards:
    /// - From 305 to 285 (to change tens and hundreds) one by one; or
    /// - From 20 to 0 if they make counting mistakes after 2 attempts of the previous backwards counting
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech fluency and articulation
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#CountingBackwardsTask"></see></summary>
    let CountingBackwardsTask =
        Namespaced_IRI.parse _namespace_name "CountingBackwardsTask" |> NamespacedName

    /// <summary>
    /// A Person with Predementia is defined as the participant whose clinical record contains a predementia clinical diagnosis
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#PersonWithPredementia"></see></summary>
    let PersonWithPredementia =
        Namespaced_IRI.parse _namespace_name "PersonWithPredementia" |> NamespacedName

    /// <summary>
    /// A Person with Dementia is defined as the participant whose clinical record contains a dementia clinical diagnosis
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#PersonWithDementia"></see></summary>
    let PersonWithDementia =
        Namespaced_IRI.parse _namespace_name "PersonWithDementia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#DiagnosisType"></see>
    /// </summary>
    let DiagnosisType =
        Namespaced_IRI.parse _namespace_name "DiagnosisType" |> NamespacedName

    /// <summary>
    /// A Healthy Control Participant is defined as the participant whose clinical record contains a healthy clinical diagnosis
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#HealthyControlParticipant"></see></summary>
    let HealthyControlParticipant =
        Namespaced_IRI.parse _namespace_name "HealthyControlParticipant" |> NamespacedName

    /// <summary>
    /// The value of the DiagnosisAssessment
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#hasClinicalDiagnosis"></see></summary>
    let hasClinicalDiagnosis =
        Namespaced_IRI.parse _namespace_name "hasClinicalDiagnosis" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#healthy"></see>
    /// </summary>
    let healthy = Namespaced_IRI.parse _namespace_name "healthy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#dementia"></see>
    /// </summary>
    let dementia = Namespaced_IRI.parse _namespace_name "dementia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#predementia"></see>
    /// </summary>
    let predementia =
        Namespaced_IRI.parse _namespace_name "predementia" |> NamespacedName

    /// <summary>
    /// This ProtocolStep is conducted by a clinician, who details step by step the different activities to do by the participant. This step involves five Tasks. The tasks Walking, CountingBackwards and WalkingAndCountingBackwards are used for characterizing participants’ gait in mono and dual tasks, and the impact of cognitive activity on gait (e.g., walking speed, step length, stops during the walking exercise done in dual task). The tasks SentenceRepeating and ArticulationControl are vocally-directed tasks: one task consists of repeating a sentence after the clinician (this task is repeated with three sentences), and the other is an articulation control exercise done to evaluate the neuromuscular mechanism of speech production.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#DirectedActivitiesStep"></see></summary>
    let DirectedActivitiesStep =
        Namespaced_IRI.parse _namespace_name "DirectedActivitiesStep" |> NamespacedName

    /// <summary>
    /// - The participant is asked to repeat a short sentence after the assessor.
    /// - The assessor reads aloud a sentence. The participant repeats the sentence. The action is done once by sentence. Three sentences must be repeated.
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. verbal reaction time
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#SentenceRepeatingTask"></see></summary>
    let SentenceRepeatingTask =
        Namespaced_IRI.parse _namespace_name "SentenceRepeatingTask" |> NamespacedName

    /// <summary>
    /// Each Task involves the collection of one or more measurements (MeasuredData instances).
    ///
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName

    /// <summary>
    /// (DualTask) The clinician asks the participant to walk and count aloud backwards simultaneously:
    /// - From 305 until the end of the walking tasks; or
    /// - From 20 to 0 for participants who don’t manage to count backwards from 305 to 285 during the CountingBackwardsTask
    ///
    /// This task is used for assessing:
    /// - Gait: walking speed, step length, etc.
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech fluency and articulation
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#WalkingCountingBackwardsTask"></see></summary>
    let WalkingCountingBackwardsTask =
        Namespaced_IRI.parse _namespace_name "WalkingCountingBackwardsTask" |> NamespacedName

    /// <summary>
    /// (MonoTask) The clinician asks the participant to walk 4 meters across the room, to turn and then to come back (total walking distance: 8m).
    ///
    /// This task is used for assessing:
    /// - Gait: walking speed, step length, etc.
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#WalkingTask"></see></summary>
    let WalkingTask =
        Namespaced_IRI.parse _namespace_name "WalkingTask" |> NamespacedName

    /// <summary>
    /// Each ProtocolStep involves one or more Tasks
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#involvesTask"></see></summary>
    let involvesTask =
        Namespaced_IRI.parse _namespace_name "involvesTask" |> NamespacedName

    /// <summary>
    /// A ProtocolStep defines the Tasks of interest. Three ProtocolStep types are currently defined in Dem@Care: DirectedActivities, SemiDirectedActivities and DiscussionWithTheClinician
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#ProtocolStep"></see></summary>
    let ProtocolStep =
        Namespaced_IRI.parse _namespace_name "ProtocolStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#DirectedDiscussionTask"></see>
    /// </summary>
    let DirectedDiscussionTask =
        Namespaced_IRI.parse _namespace_name "DirectedDiscussionTask" |> NamespacedName

    /// <summary>
    /// Root concept for grouping the Tasks relevant to the DiscussionWithClinicianStep
    ///
    /// The relevant tasks are used for assessing:
    /// - Stress level
    /// - Voice: e.g. speech rate, pause rate etc.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionTask"></see></summary>
    let DiscussionTask =
        Namespaced_IRI.parse _namespace_name "DiscussionTask" |> NamespacedName

    /// <summary>
    /// The clinician asks the same questions than the ones asked on the read article, e.g. What is the topic of the article?
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#DirectedExpressionTask"></see></summary>
    let DirectedExpressionTask =
        Namespaced_IRI.parse _namespace_name "DirectedExpressionTask" |> NamespacedName

    /// <summary>
    /// - Assessment of the impact of cognitive load imposed by the picture description task on speech fluency
    /// - Memory and self-appraisal assessment
    /// - Verbal fluency and mood (Apathy) assessment
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionInvolvementData"></see></summary>
    let DiscussionInvolvementData =
        Namespaced_IRI.parse _namespace_name "DiscussionInvolvementData" |> NamespacedName

    /// <summary>
    /// Time between the end of assessor’s speech and the beginning of participant’s speech (Discussion Task)
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#verbalReactionSpontaneity"></see></summary>
    let verbalReactionSpontaneity =
        Namespaced_IRI.parse _namespace_name "verbalReactionSpontaneity" |> NamespacedName

    /// <summary>
    /// This ProtocolStep involves two Tasks. The first task (DirectedExpressionTask) is a directed discussion during which the clinician assesses the episodic memory of participant through questions related to events and activities of SemiDirectedActivitiesStep. The second task (PictureDescriptionTask) assesses the verbal fluency and mood of participant using a picture that the participant has to describe (with the picture in the eyes) and then to involve a discussion about their interests for the activity represented. This part is done with two different pictures.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionWithClinicianStep"></see></summary>
    let DiscussionWithClinicianStep =
        Namespaced_IRI.parse _namespace_name "DiscussionWithClinicianStep" |> NamespacedName

    /// <summary>
    /// The clinician shows to the participant one picture representing daily activity and asks the participants to give a verbal description of the picture in a few sentences
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#PictureDescriptionTask"></see></summary>
    let PictureDescriptionTask =
        Namespaced_IRI.parse _namespace_name "PictureDescriptionTask" |> NamespacedName

    /// <summary>
    /// The clinician asks if the participant likes doing this activity and why
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#PictureDiscussionTask"></see></summary>
    let PictureDiscussionTask =
        Namespaced_IRI.parse _namespace_name "PictureDiscussionTask" |> NamespacedName

    /// <summary>
    /// - Three bills (Electricity/Gaz/Phone) are proposed. The account balance is given.
    /// - The participant has to establish the amount balance after having taken into account the three bills.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#EstablishAccountBalanceTask"></see></summary>
    let EstablishAccountBalanceTask =
        Namespaced_IRI.parse _namespace_name "EstablishAccountBalanceTask" |> NamespacedName

    /// <summary>
    /// - A real bus map is showed to the participant with the indication of the current location of the participant.
    /// - The participant has to write on a sheet of paper located next to the bus map the bus lines to take for the itinerary (From Hospital to Station train). Two itineraries are accepted.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#FindBusLineOnMapTask"></see></summary>
    let FindBusLineOnMapTask =
        Namespaced_IRI.parse _namespace_name "FindBusLineOnMapTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#FreeDiscussionTask"></see>
    /// </summary>
    let FreeDiscussionTask =
        Namespaced_IRI.parse _namespace_name "FreeDiscussionTask" |> NamespacedName

    /// <summary>
    /// Explore functional abilities for the completion of specific activities
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#FunctionalAbilitiesData"></see></summary>
    let FunctionalAbilitiesData =
        Namespaced_IRI.parse _namespace_name "FunctionalAbilitiesData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#HandTrajectoryType"></see>
    /// </summary>
    let HandTrajectoryType =
        Namespaced_IRI.parse _namespace_name "HandTrajectoryType" |> NamespacedName

    /// <summary>
    /// Associates an instance of FunctionalAbilitiesData with a hand trajectory type
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#handTrajectory"></see></summary>
    let handTrajectory =
        Namespaced_IRI.parse _namespace_name "handTrajectory" |> NamespacedName

    /// <summary>
    /// Gait assessment and impact of a cognitive activity on gait performance
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#GaitData"></see></summary>
    let GaitData = Namespaced_IRI.parse _namespace_name "GaitData" |> NamespacedName

    /// <summary>
    /// Walking speed instantaneous (mono task walking activity/dual task)
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#walkingSpeedInstantaneous"></see></summary>
    let walkingSpeedInstantaneous =
        Namespaced_IRI.parse _namespace_name "walkingSpeedInstantaneous" |> NamespacedName

    /// <summary>
    /// Walking speed
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#walkingSpeed"></see></summary>
    let walkingSpeed =
        Namespaced_IRI.parse _namespace_name "walkingSpeed" |> NamespacedName

    /// <summary>
    /// Stopping displacement during walking
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#stoppingDisplacement"></see></summary>
    let stoppingDisplacement =
        Namespaced_IRI.parse _namespace_name "stoppingDisplacement" |> NamespacedName

    /// <summary>
    /// Dynamical balance during the walking (e.g., people trajectory study)
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#dynamicBalance"></see></summary>
    let dynamicBalance =
        Namespaced_IRI.parse _namespace_name "dynamicBalance" |> NamespacedName

    /// <summary>
    /// Step length
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#stepLength"></see></summary>
    let stepLength = Namespaced_IRI.parse _namespace_name "stepLength" |> NamespacedName

    /// <summary>
    /// Each participant is associated with a clinical record
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#hasClinicalRecord"></see></summary>
    let hasClinicalRecord =
        Namespaced_IRI.parse _namespace_name "hasClinicalRecord" |> NamespacedName

    /// <summary>
    /// Time of latency between the end of instructions (stimulation) and the beginning of the task
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#latency"></see></summary>
    let latency = Namespaced_IRI.parse _namespace_name "latency" |> NamespacedName

    /// <summary>
    /// The participant has to leave the room when he/she feels that all activities are performed and achieved
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#LeaveRoomTask"></see></summary>
    let LeaveRoomTask =
        Namespaced_IRI.parse _namespace_name "LeaveRoomTask" |> NamespacedName

    /// <summary>
    /// Part III of the Unified Parkinson’s Disease Rating Scale
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#hasUPDRSScore"></see></summary>
    let hasUPDRSScore =
        Namespaced_IRI.parse _namespace_name "hasUPDRSScore" |> NamespacedName

    /// <summary>
    /// Neuropsychiatric Inventory
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#npi"></see></summary>
    let npi = Namespaced_IRI.parse _namespace_name "npi" |> NamespacedName

    /// <summary>
    /// DSM-IV Criteria for depression
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#dsm_ivDepressionCriteria"></see></summary>
    let dsm_ivDepressionCriteria =
        Namespaced_IRI.parse _namespace_name "dsm_ivDepressionCriteria" |> NamespacedName

    /// <summary>
    /// Apathy Inventory (AI) and diagnostic criteria for apathy
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#apathyInventory"></see></summary>
    let apathyInventory =
        Namespaced_IRI.parse _namespace_name "apathyInventory" |> NamespacedName

    /// <summary>
    /// Explore ability to organize with efficiency the different activities
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#OrganisationEfficiencyData"></see></summary>
    let OrganisationEfficiencyData =
        Namespaced_IRI.parse _namespace_name "OrganisationEfficiencyData" |> NamespacedName

    /// <summary>
    /// Total distance walked
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#distanceWalked"></see></summary>
    let distanceWalked =
        Namespaced_IRI.parse _namespace_name "distanceWalked" |> NamespacedName

    /// <summary>
    /// Allows the definition of zones (areas) of interest, e.g. phone zone
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#Zone"></see></summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName

    /// <summary>
    /// Zones of no interest
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#areasOfInterestExplored"></see></summary>
    let areasOfInterestExplored =
        Namespaced_IRI.parse _namespace_name "areasOfInterestExplored" |> NamespacedName

    /// <summary>
    /// Zones of interest
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#areasOfNoInterestExplored"></see></summary>
    let areasOfNoInterestExplored =
        Namespaced_IRI.parse _namespace_name "areasOfNoInterestExplored" |> NamespacedName

    /// <summary>
    /// A Protocol instance contains information regarding the participant and the duration of the protocol session. It can be also associated with one or more ProtocolSteps that define the Tasks and the corresponding MeasuredData.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#Protocol"></see></summary>
    let Protocol = Namespaced_IRI.parse _namespace_name "Protocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#participates"></see>
    /// </summary>
    let participates =
        Namespaced_IRI.parse _namespace_name "participates" |> NamespacedName

    /// <summary>
    /// - Three bills (Electricity/Gaz/Phone) are proposed. The participant has to pay the phone bill by check.
    /// - The check is well completed if the amount, order (i.e. Phone Company), date and signature are right.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#PayBillTask"></see></summary>
    let PayBillTask =
        Namespaced_IRI.parse _namespace_name "PayBillTask" |> NamespacedName

    /// <summary>
    /// - 4 types of drugs are proposed to the participant.
    /// - The participant has to respect the posology prescribed (2 types of drugs at different moment of the day) and the date (day and moment of the day).
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#PrepareDrugBoxTask"></see></summary>
    let PrepareDrugBoxTask =
        Namespaced_IRI.parse _namespace_name "PrepareDrugBoxTask" |> NamespacedName

    /// <summary>
    /// - The participant has to switch on the electric kettle.
    /// - The participant has to pour the hot water on the glass containing the tea bag.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#PrepareHotTeaTask"></see></summary>
    let PrepareHotTeaTask =
        Namespaced_IRI.parse _namespace_name "PrepareHotTeaTask" |> NamespacedName

    /// <summary>
    /// Each Protocol consists of one or more ProtocolSteps
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#hasProtocolStep"></see></summary>
    let hasProtocolStep =
        Namespaced_IRI.parse _namespace_name "hasProtocolStep" |> NamespacedName

    /// <summary>
    /// The participant of the protocol
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#hasParticipant"></see></summary>
    let hasParticipant =
        Namespaced_IRI.parse _namespace_name "hasParticipant" |> NamespacedName

    /// <summary>
    /// Three articles are proposed to the participant (Topics: Collection Cars; Cooking; Sightseeing). The three articles have the same words number and level of difficulty. Below each articles, the 3 following questions are asked
    /// - Q1/ What is the topic of the article?
    /// - Q2/ What is the percentage of French interested in the … (Collection Car / Cooking / Sightseeing, text adapted to the article topic)?
    /// - Q3/ Who is interviewed?
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#ReadArticleTask"></see></summary>
    let ReadArticleTask =
        Namespaced_IRI.parse _namespace_name "ReadArticleTask" |> NamespacedName

    /// <summary>
    /// The TV is turn off. The participant has to take the remote control and turns on the TV
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#TurnOnTVTask"></see></summary>
    let TurnOnTVTask =
        Namespaced_IRI.parse _namespace_name "TurnOnTVTask" |> NamespacedName

    /// <summary>
    /// The participant has to take the water can, and water the plant nearby.
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#WaterPlantTask"></see></summary>
    let WaterPlantTask =
        Namespaced_IRI.parse _namespace_name "WaterPlantTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#stressLevel"></see>
    /// </summary>
    let stressLevel =
        Namespaced_IRI.parse _namespace_name "stressLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#vowelDuration"></see>
    /// </summary>
    let vowelDuration =
        Namespaced_IRI.parse _namespace_name "vowelDuration" |> NamespacedName

    /// <summary>
    /// Pause rate during sentence repetition and mono/dual tasks
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#pauseRate"></see></summary>
    let pauseRate = Namespaced_IRI.parse _namespace_name "pauseRate" |> NamespacedName
    /// <summary>
    /// Speech fluency during sentence repetition and picture description tasks
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#speechRate"></see></summary>
    let speechRate = Namespaced_IRI.parse _namespace_name "speechRate" |> NamespacedName

    /// <summary>
    /// Time interval between the end of assessor’s speech and the beginning of participant’s speech (Sentence Repetition Task)
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#verbalReactionTime"></see></summary>
    let verbalReactionTime =
        Namespaced_IRI.parse _namespace_name "verbalReactionTime" |> NamespacedName

    /// <summary>
    /// Speech fluency during sentence repetition and picture description tasks
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#speechFluency"></see></summary>
    let speechFluency =
        Namespaced_IRI.parse _namespace_name "speechFluency" |> NamespacedName

    /// <summary>
    /// Measures the articulation control of the participant
    /// <see href="http://www.demcare.eu/ontologies/demlab.owl#articulation"></see></summary>
    let articulation =
        Namespaced_IRI.parse _namespace_name "articulation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/demlab.owl#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
