namespace http.www.demcare.eu.ontologies.demlab.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module demlab =
    let _namespace_iri = Namespace_Iri demlab |> NamespaceIRI
    /// <summary>
    ///   <para>demlab:ActivityStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#ActivityStatusType">http://www.demcare.eu/ontologies/demlab.owl#ActivityStatusType</seealso>
    let ActivityStatusType = Prefixed_Name(demlab, "ActivityStatusType") |> PrefixedName
    /// <summary>
    ///   <para>demlab:AnswerPhoneTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- The phone is scheduled to ring 10 minutes after the entering of the participant inside the room.
    /// - During this task, the clinician explains that there is a mistake on the phone bill: the amount was wrong. Consequently, it is expected that the participant corrects his/her phone check and corrects the account balance (tasks normally established before the phone call according to the constraint)."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#AnswerPhoneTask">http://www.demcare.eu/ontologies/demlab.owl#AnswerPhoneTask</seealso>
    let AnswerPhoneTask = Prefixed_Name(demlab, "AnswerPhoneTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:ArticulationControlTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The participant is asked to pronounce repeatedly a predefined diadochokinetic “Pataka” token as rapid as possible stopping this action upon a sign by the clinician. The clinician will stop the action in 10 sec.
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech rate, pause rate etc."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#ArticulationControlTask">http://www.demcare.eu/ontologies/demlab.owl#ArticulationControlTask</seealso>
    let ArticulationControlTask =
        Prefixed_Name(demlab, "ArticulationControlTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:AutonomyAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Autonomy is assessed based on the performance of the participant during the SemiDirectedActivitiesStep. The property iadl_e (Instrumental Activities of Daily Living for Elderly) can be used to quantify autonomy"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#AutonomyAssessment">http://www.demcare.eu/ontologies/demlab.owl#AutonomyAssessment</seealso>
    let AutonomyAssessment = Prefixed_Name(demlab, "AutonomyAssessment") |> PrefixedName

    /// <summary>
    ///   <para>demlab:CallPsychologistTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- The participant has to call the psychologist. Two phone numbers are proposed to the participant (1 visit card of the hair dressing,+ 1 visit card of the CHUN with phone number of a psychologist).
    /// - According the constraint, the participant has to call the psychologist within the 5 first minutes."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#CallPsychologistTask">http://www.demcare.eu/ontologies/demlab.owl#CallPsychologistTask</seealso>
    let CallPsychologistTask =
        Prefixed_Name(demlab, "CallPsychologistTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:ClinicalAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Root concept for the five types of clinical assessment"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#ClinicalAssessment">http://www.demcare.eu/ontologies/demlab.owl#ClinicalAssessment</seealso>
    let ClinicalAssessment = Prefixed_Name(demlab, "ClinicalAssessment") |> PrefixedName
    /// <summary>
    ///   <para>demlab:ClinicalRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ClinicalRecord contains information about the five types of clinical assessment"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#ClinicalRecord">http://www.demcare.eu/ontologies/demlab.owl#ClinicalRecord</seealso>
    let ClinicalRecord = Prefixed_Name(demlab, "ClinicalRecord") |> PrefixedName

    /// <summary>
    ///   <para>demlab:CognitiveAbilitiesAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Cognitive abilities assessment is performed in terms of five scores:
    /// - Mini-Mental State Exam (MMSE).
    /// - Frontal Assessment Battery (FAB).
    /// - Trail making test A and B.
    /// - Short Cognitive Battery.
    /// - The Free and Cued Selective Reminding Test"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#CognitiveAbilitiesAssessment">http://www.demcare.eu/ontologies/demlab.owl#CognitiveAbilitiesAssessment</seealso>
    let CognitiveAbilitiesAssessment =
        Prefixed_Name(demlab, "CognitiveAbilitiesAssessment") |> PrefixedName

    /// <summary>
    ///   <para>demlab:CognitiveAbilitiesData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Explore functional abilities for the completion of specific activities"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#CognitiveAbilitiesData">http://www.demcare.eu/ontologies/demlab.owl#CognitiveAbilitiesData</seealso>
    let CognitiveAbilitiesData =
        Prefixed_Name(demlab, "CognitiveAbilitiesData") |> PrefixedName

    /// <summary>
    ///   <para>demlab:CountingBackwardsTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(MonoTask) The participant is standing and the clinician asks him/her to count aloud backwards:
    /// - From 305 to 285 (to change tens and hundreds) one by one; or
    /// - From 20 to 0 if they make counting mistakes after 2 attempts of the previous backwards counting
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech fluency and articulation"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#CountingBackwardsTask">http://www.demcare.eu/ontologies/demlab.owl#CountingBackwardsTask</seealso>
    let CountingBackwardsTask =
        Prefixed_Name(demlab, "CountingBackwardsTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DiagnosisAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Diagnosis established the day of the recording session. Participant is assigned to one of this 3 categories: Healthy Control participants, Alzheimer’s disease at pre-dementia stage, Alzheimer ’s disease at dementia stage"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DiagnosisAssessment">http://www.demcare.eu/ontologies/demlab.owl#DiagnosisAssessment</seealso>
    let DiagnosisAssessment =
        Prefixed_Name(demlab, "DiagnosisAssessment") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DiagnosisType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DiagnosisType">http://www.demcare.eu/ontologies/demlab.owl#DiagnosisType</seealso>
    let DiagnosisType = Prefixed_Name(demlab, "DiagnosisType") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DirectedActivitiesStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This ProtocolStep is conducted by a clinician, who details step by step the different activities to do by the participant. This step involves five Tasks. The tasks Walking, CountingBackwards and WalkingAndCountingBackwards are used for characterizing participants’ gait in mono and dual tasks, and the impact of cognitive activity on gait (e.g., walking speed, step length, stops during the walking exercise done in dual task). The tasks SentenceRepeating and ArticulationControl are vocally-directed tasks: one task consists of repeating a sentence after the clinician (this task is repeated with three sentences), and the other is an articulation control exercise done to evaluate the neuromuscular mechanism of speech production."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DirectedActivitiesStep">http://www.demcare.eu/ontologies/demlab.owl#DirectedActivitiesStep</seealso>
    let DirectedActivitiesStep =
        Prefixed_Name(demlab, "DirectedActivitiesStep") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DirectedDiscussionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DirectedDiscussionTask">http://www.demcare.eu/ontologies/demlab.owl#DirectedDiscussionTask</seealso>
    let DirectedDiscussionTask =
        Prefixed_Name(demlab, "DirectedDiscussionTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DirectedExpressionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The clinician asks the same questions than the ones asked on the read article, e.g. What is the topic of the article?"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DirectedExpressionTask">http://www.demcare.eu/ontologies/demlab.owl#DirectedExpressionTask</seealso>
    let DirectedExpressionTask =
        Prefixed_Name(demlab, "DirectedExpressionTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DirectedTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Root concept for grouping the Tasks relevant to the DirectedActivitiesStep"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DirectedTask">http://www.demcare.eu/ontologies/demlab.owl#DirectedTask</seealso>
    let DirectedTask = Prefixed_Name(demlab, "DirectedTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DiscussionInvolvementData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- Assessment of the impact of cognitive load imposed by the picture description task on speech fluency
    /// - Memory and self-appraisal assessment
    /// - Verbal fluency and mood (Apathy) assessment"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionInvolvementData">http://www.demcare.eu/ontologies/demlab.owl#DiscussionInvolvementData</seealso>
    let DiscussionInvolvementData =
        Prefixed_Name(demlab, "DiscussionInvolvementData") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DiscussionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Root concept for grouping the Tasks relevant to the DiscussionWithClinicianStep
    ///
    /// The relevant tasks are used for assessing:
    /// - Stress level
    /// - Voice: e.g. speech rate, pause rate etc."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionTask">http://www.demcare.eu/ontologies/demlab.owl#DiscussionTask</seealso>
    let DiscussionTask = Prefixed_Name(demlab, "DiscussionTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:DiscussionWithClinicianStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This ProtocolStep involves two Tasks. The first task (DirectedExpressionTask) is a directed discussion during which the clinician assesses the episodic memory of participant through questions related to events and activities of SemiDirectedActivitiesStep. The second task (PictureDescriptionTask) assesses the verbal fluency and mood of participant using a picture that the participant has to describe (with the picture in the eyes) and then to involve a discussion about their interests for the activity represented. This part is done with two different pictures."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#DiscussionWithClinicianStep">http://www.demcare.eu/ontologies/demlab.owl#DiscussionWithClinicianStep</seealso>
    let DiscussionWithClinicianStep =
        Prefixed_Name(demlab, "DiscussionWithClinicianStep") |> PrefixedName

    /// <summary>
    ///   <para>demlab:EstablishAccountBalanceTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- Three bills (Electricity/Gaz/Phone) are proposed. The account balance is given.
    /// - The participant has to establish the amount balance after having taken into account the three bills."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#EstablishAccountBalanceTask">http://www.demcare.eu/ontologies/demlab.owl#EstablishAccountBalanceTask</seealso>
    let EstablishAccountBalanceTask =
        Prefixed_Name(demlab, "EstablishAccountBalanceTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:FindBusLineOnMapTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- A real bus map is showed to the participant with the indication of the current location of the participant.
    /// - The participant has to write on a sheet of paper located next to the bus map the bus lines to take for the itinerary (From Hospital to Station train). Two itineraries are accepted."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#FindBusLineOnMapTask">http://www.demcare.eu/ontologies/demlab.owl#FindBusLineOnMapTask</seealso>
    let FindBusLineOnMapTask =
        Prefixed_Name(demlab, "FindBusLineOnMapTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:FreeDiscussionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#FreeDiscussionTask">http://www.demcare.eu/ontologies/demlab.owl#FreeDiscussionTask</seealso>
    let FreeDiscussionTask = Prefixed_Name(demlab, "FreeDiscussionTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:FunctionalAbilitiesData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Explore functional abilities for the completion of specific activities"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#FunctionalAbilitiesData">http://www.demcare.eu/ontologies/demlab.owl#FunctionalAbilitiesData</seealso>
    let FunctionalAbilitiesData =
        Prefixed_Name(demlab, "FunctionalAbilitiesData") |> PrefixedName

    /// <summary>
    ///   <para>demlab:GaitData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Gait assessment and impact of a cognitive activity on gait performance"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#GaitData">http://www.demcare.eu/ontologies/demlab.owl#GaitData</seealso>
    let GaitData = Prefixed_Name(demlab, "GaitData") |> PrefixedName
    /// <summary>
    ///   <para>demlab:HandTrajectoryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#HandTrajectoryType">http://www.demcare.eu/ontologies/demlab.owl#HandTrajectoryType</seealso>
    let HandTrajectoryType = Prefixed_Name(demlab, "HandTrajectoryType") |> PrefixedName

    /// <summary>
    ///   <para>demlab:HealthyControlParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Healthy Control Participant is defined as the participant whose clinical record contains a healthy clinical diagnosis"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#HealthyControlParticipant">http://www.demcare.eu/ontologies/demlab.owl#HealthyControlParticipant</seealso>
    let HealthyControlParticipant =
        Prefixed_Name(demlab, "HealthyControlParticipant") |> PrefixedName

    /// <summary>
    ///   <para>demlab:LatencyData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Explore the time of latency [stimulation, response] during the DirectedActivitiesTask (Explore sensitivity of this measure for assessing the apathy)"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#LatencyData">http://www.demcare.eu/ontologies/demlab.owl#LatencyData</seealso>
    let LatencyData = Prefixed_Name(demlab, "LatencyData") |> PrefixedName
    /// <summary>
    ///   <para>demlab:LeaveRoomTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The participant has to leave the room when he/she feels that all activities are performed and achieved"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#LeaveRoomTask">http://www.demcare.eu/ontologies/demlab.owl#LeaveRoomTask</seealso>
    let LeaveRoomTask = Prefixed_Name(demlab, "LeaveRoomTask") |> PrefixedName
    /// <summary>
    ///   <para>demlab:MeasuredData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MeasuredData is the root concept that groups the measurement types that are collected during the Tasks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#MeasuredData">http://www.demcare.eu/ontologies/demlab.owl#MeasuredData</seealso>
    let MeasuredData = Prefixed_Name(demlab, "MeasuredData") |> PrefixedName

    /// <summary>
    ///   <para>demlab:MotricityAbilitiesAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Motricity abilities assessment:
    /// - Part III of the Unified Parkinson’s Disease Rating Scale (UPDRS) ."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#MotricityAbilitiesAssessment">http://www.demcare.eu/ontologies/demlab.owl#MotricityAbilitiesAssessment</seealso>
    let MotricityAbilitiesAssessment =
        Prefixed_Name(demlab, "MotricityAbilitiesAssessment") |> PrefixedName

    /// <summary>
    ///   <para>demlab:NeuropsychiatricAndMoodAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Neuropsychiatric/Mood assessments:
    /// - NPI
    /// - DSM-IV Criteria for depression
    /// - Apathy Inventory (AI) and diagnostic criteria for apathy."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#NeuropsychiatricAndMoodAssessment">http://www.demcare.eu/ontologies/demlab.owl#NeuropsychiatricAndMoodAssessment</seealso>
    let NeuropsychiatricAndMoodAssessment =
        Prefixed_Name(demlab, "NeuropsychiatricAndMoodAssessment") |> PrefixedName

    /// <summary>
    ///   <para>demlab:OrganisationEfficiencyData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Explore ability to organize with efficiency the different activities"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#OrganisationEfficiencyData">http://www.demcare.eu/ontologies/demlab.owl#OrganisationEfficiencyData</seealso>
    let OrganisationEfficiencyData =
        Prefixed_Name(demlab, "OrganisationEfficiencyData") |> PrefixedName

    /// <summary>
    ///   <para>demlab:Participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#Participant">http://www.demcare.eu/ontologies/demlab.owl#Participant</seealso>
    let Participant = Prefixed_Name(demlab, "Participant") |> PrefixedName
    /// <summary>
    ///   <para>demlab:PayBillTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- Three bills (Electricity/Gaz/Phone) are proposed. The participant has to pay the phone bill by check.
    /// - The check is well completed if the amount, order (i.e. Phone Company), date and signature are right."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#PayBillTask">http://www.demcare.eu/ontologies/demlab.owl#PayBillTask</seealso>
    let PayBillTask = Prefixed_Name(demlab, "PayBillTask") |> PrefixedName
    /// <summary>
    ///   <para>demlab:Person</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#Person">http://www.demcare.eu/ontologies/demlab.owl#Person</seealso>
    let Person = Prefixed_Name(demlab, "Person") |> PrefixedName
    /// <summary>
    ///   <para>demlab:PersonWithDementia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Person with Dementia is defined as the participant whose clinical record contains a dementia clinical diagnosis"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#PersonWithDementia">http://www.demcare.eu/ontologies/demlab.owl#PersonWithDementia</seealso>
    let PersonWithDementia = Prefixed_Name(demlab, "PersonWithDementia") |> PrefixedName

    /// <summary>
    ///   <para>demlab:PersonWithPredementia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Person with Predementia is defined as the participant whose clinical record contains a predementia clinical diagnosis"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#PersonWithPredementia">http://www.demcare.eu/ontologies/demlab.owl#PersonWithPredementia</seealso>
    let PersonWithPredementia =
        Prefixed_Name(demlab, "PersonWithPredementia") |> PrefixedName

    /// <summary>
    ///   <para>demlab:PictureDescriptionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The clinician shows to the participant one picture representing daily activity and asks the participants to give a verbal description of the picture in a few sentences"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#PictureDescriptionTask">http://www.demcare.eu/ontologies/demlab.owl#PictureDescriptionTask</seealso>
    let PictureDescriptionTask =
        Prefixed_Name(demlab, "PictureDescriptionTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:PictureDiscussionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The clinician asks if the participant likes doing this activity and why"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#PictureDiscussionTask">http://www.demcare.eu/ontologies/demlab.owl#PictureDiscussionTask</seealso>
    let PictureDiscussionTask =
        Prefixed_Name(demlab, "PictureDiscussionTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:PrepareDrugBoxTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- 4 types of drugs are proposed to the participant.
    /// - The participant has to respect the posology prescribed (2 types of drugs at different moment of the day) and the date (day and moment of the day)."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#PrepareDrugBoxTask">http://www.demcare.eu/ontologies/demlab.owl#PrepareDrugBoxTask</seealso>
    let PrepareDrugBoxTask = Prefixed_Name(demlab, "PrepareDrugBoxTask") |> PrefixedName
    /// <summary>
    ///   <para>demlab:PrepareHotTeaTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- The participant has to switch on the electric kettle.
    /// - The participant has to pour the hot water on the glass containing the tea bag."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#PrepareHotTeaTask">http://www.demcare.eu/ontologies/demlab.owl#PrepareHotTeaTask</seealso>
    let PrepareHotTeaTask = Prefixed_Name(demlab, "PrepareHotTeaTask") |> PrefixedName
    /// <summary>
    ///   <para>demlab:Protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Protocol instance contains information regarding the participant and the duration of the protocol session. It can be also associated with one or more ProtocolSteps that define the Tasks and the corresponding MeasuredData."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#Protocol">http://www.demcare.eu/ontologies/demlab.owl#Protocol</seealso>
    let Protocol = Prefixed_Name(demlab, "Protocol") |> PrefixedName
    /// <summary>
    ///   <para>demlab:ProtocolStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ProtocolStep defines the Tasks of interest. Three ProtocolStep types are currently defined in Dem@Care: DirectedActivities, SemiDirectedActivities and DiscussionWithTheClinician"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#ProtocolStep">http://www.demcare.eu/ontologies/demlab.owl#ProtocolStep</seealso>
    let ProtocolStep = Prefixed_Name(demlab, "ProtocolStep") |> PrefixedName
    /// <summary>
    ///   <para>demlab:ReadArticleTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Three articles are proposed to the participant (Topics: Collection Cars; Cooking; Sightseeing). The three articles have the same words number and level of difficulty. Below each articles, the 3 following questions are asked
    /// - Q1/ What is the topic of the article?
    /// - Q2/ What is the percentage of French interested in the … (Collection Car / Cooking / Sightseeing, text adapted to the article topic)?
    /// - Q3/ Who is interviewed?"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#ReadArticleTask">http://www.demcare.eu/ontologies/demlab.owl#ReadArticleTask</seealso>
    let ReadArticleTask = Prefixed_Name(demlab, "ReadArticleTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:SemiDirectedActivitiesStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This ProtocolStep consists of assessing the autonomy of the participant. The participant has to organize himself/herself and correctly perform a list of Instrumental Activities of Daily Living (e.g., managing finance, using phone, preparing tea) within a timeframe of 15minutes. For this step, the participant is alone in the experimental setting and can refer to the instruction sheet of paper with the IADLs to perform at any time."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#SemiDirectedActivitiesStep">http://www.demcare.eu/ontologies/demlab.owl#SemiDirectedActivitiesStep</seealso>
    let SemiDirectedActivitiesStep =
        Prefixed_Name(demlab, "SemiDirectedActivitiesStep") |> PrefixedName

    /// <summary>
    ///   <para>demlab:SemiDirectedTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In this Task the participant has to organize himself/herself and correctly perform a list of Instrumental Activities of Daily Living (e.g., managing finance, using phone, preparing tea) within a timeframe of 15minutes.
    ///
    /// The relevant tasks are used for assessing:
    /// - Cognitive abilities through activity repetitions, missed activities, order of activities
    /// - Functional abilities for the completion of specific activities: e.g. hand trajectories
    /// - Stress level"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#SemiDirectedTask">http://www.demcare.eu/ontologies/demlab.owl#SemiDirectedTask</seealso>
    let SemiDirectedTask = Prefixed_Name(demlab, "SemiDirectedTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:SentenceRepeatingTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- The participant is asked to repeat a short sentence after the assessor.
    /// - The assessor reads aloud a sentence. The participant repeats the sentence. The action is done once by sentence. Three sentences must be repeated.
    ///
    /// This task is used for assessing:
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. verbal reaction time"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#SentenceRepeatingTask">http://www.demcare.eu/ontologies/demlab.owl#SentenceRepeatingTask</seealso>
    let SentenceRepeatingTask =
        Prefixed_Name(demlab, "SentenceRepeatingTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:StressData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Explore stress level"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#StressData">http://www.demcare.eu/ontologies/demlab.owl#StressData</seealso>
    let StressData = Prefixed_Name(demlab, "StressData") |> PrefixedName
    /// <summary>
    ///   <para>demlab:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Each Task involves the collection of one or more measurements (MeasuredData instances)."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#Task">http://www.demcare.eu/ontologies/demlab.owl#Task</seealso>
    let Task = Prefixed_Name(demlab, "Task") |> PrefixedName
    /// <summary>
    ///   <para>demlab:TurnOnTVTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The TV is turn off. The participant has to take the remote control and turns on the TV"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#TurnOnTVTask">http://www.demcare.eu/ontologies/demlab.owl#TurnOnTVTask</seealso>
    let TurnOnTVTask = Prefixed_Name(demlab, "TurnOnTVTask") |> PrefixedName
    /// <summary>
    ///   <para>demlab:VoiceData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"- Vocal biomarkers extraction for cognitive load assessment
    /// - Assessment of mutual influence of cognitive activities an motor activities
    /// - Assessment of the verbal reaction time and the impact of cognitive load imposed by the sentence recall task on speech fluency
    /// - Assessment of the level of the participants’ control over the neuromuscular mechanism of speech production"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#VoiceData">http://www.demcare.eu/ontologies/demlab.owl#VoiceData</seealso>
    let VoiceData = Prefixed_Name(demlab, "VoiceData") |> PrefixedName

    /// <summary>
    ///   <para>demlab:WalkingCountingBackwardsTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(DualTask) The clinician asks the participant to walk and count aloud backwards simultaneously:
    /// - From 305 until the end of the walking tasks; or
    /// - From 20 to 0 for participants who don’t manage to count backwards from 305 to 285 during the CountingBackwardsTask
    ///
    /// This task is used for assessing:
    /// - Gait: walking speed, step length, etc.
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level
    /// - Voice: e.g. speech fluency and articulation"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#WalkingCountingBackwardsTask">http://www.demcare.eu/ontologies/demlab.owl#WalkingCountingBackwardsTask</seealso>
    let WalkingCountingBackwardsTask =
        Prefixed_Name(demlab, "WalkingCountingBackwardsTask") |> PrefixedName

    /// <summary>
    ///   <para>demlab:WalkingTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(MonoTask) The clinician asks the participant to walk 4 meters across the room, to turn and then to come back (total walking distance: 8m).
    ///
    /// This task is used for assessing:
    /// - Gait: walking speed, step length, etc.
    /// - Latency: time of latency between the end of instructions (stimulation) and the beginning of the task
    /// - Stress level"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#WalkingTask">http://www.demcare.eu/ontologies/demlab.owl#WalkingTask</seealso>
    let WalkingTask = Prefixed_Name(demlab, "WalkingTask") |> PrefixedName
    /// <summary>
    ///   <para>demlab:WaterPlantTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The participant has to take the water can, and water the plant nearby."</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#WaterPlantTask">http://www.demcare.eu/ontologies/demlab.owl#WaterPlantTask</seealso>
    let WaterPlantTask = Prefixed_Name(demlab, "WaterPlantTask") |> PrefixedName
    /// <summary>
    ///   <para>demlab:Zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Allows the definition of zones (areas) of interest, e.g. phone zone"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#Zone">http://www.demcare.eu/ontologies/demlab.owl#Zone</seealso>
    let Zone = Prefixed_Name(demlab, "Zone") |> PrefixedName
    /// <summary>
    ///   <para>demlab:activityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The status of a semi-directed activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#activityStatus">http://www.demcare.eu/ontologies/demlab.owl#activityStatus</seealso>
    let activityStatus = Prefixed_Name(demlab, "activityStatus") |> PrefixedName
    /// <summary>
    ///   <para>demlab:apathyInventory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Apathy Inventory (AI) and diagnostic criteria for apathy"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#apathyInventory">http://www.demcare.eu/ontologies/demlab.owl#apathyInventory</seealso>
    let apathyInventory = Prefixed_Name(demlab, "apathyInventory") |> PrefixedName

    /// <summary>
    ///   <para>demlab:areasOfInterestExplored</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Zones of no interest"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#areasOfInterestExplored">http://www.demcare.eu/ontologies/demlab.owl#areasOfInterestExplored</seealso>
    let areasOfInterestExplored =
        Prefixed_Name(demlab, "areasOfInterestExplored") |> PrefixedName

    /// <summary>
    ///   <para>demlab:areasOfNoInterestExplored</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Zones of interest"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#areasOfNoInterestExplored">http://www.demcare.eu/ontologies/demlab.owl#areasOfNoInterestExplored</seealso>
    let areasOfNoInterestExplored =
        Prefixed_Name(demlab, "areasOfNoInterestExplored") |> PrefixedName

    /// <summary>
    ///   <para>demlab:articulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Measures the articulation control of the participant"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#articulation">http://www.demcare.eu/ontologies/demlab.owl#articulation</seealso>
    let articulation = Prefixed_Name(demlab, "articulation") |> PrefixedName
    /// <summary>
    ///   <para>demlab:completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>demlab:ActivityStatusType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#completed">http://www.demcare.eu/ontologies/demlab.owl#completed</seealso>
    let completed = Prefixed_Name(demlab, "completed") |> PrefixedName

    /// <summary>
    ///   <para>demlab:compliantInstructionsOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the participant followed the activity order suggested by the instructions sheet"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#compliantInstructionsOrder">http://www.demcare.eu/ontologies/demlab.owl#compliantInstructionsOrder</seealso>
    let compliantInstructionsOrder =
        Prefixed_Name(demlab, "compliantInstructionsOrder") |> PrefixedName

    /// <summary>
    ///   <para>demlab:containsAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A ClinicalRecord contains a ClinicalAssessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#containsAssessment">http://www.demcare.eu/ontologies/demlab.owl#containsAssessment</seealso>
    let containsAssessment = Prefixed_Name(demlab, "containsAssessment") |> PrefixedName
    /// <summary>
    ///   <para>demlab:dementia</para>
    /// </summary>
    /// <remarks>
    ///   <para>demlab:DiagnosisType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#dementia">http://www.demcare.eu/ontologies/demlab.owl#dementia</seealso>
    let dementia = Prefixed_Name(demlab, "dementia") |> PrefixedName
    /// <summary>
    ///   <para>demlab:distanceWalked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Total distance walked"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#distanceWalked">http://www.demcare.eu/ontologies/demlab.owl#distanceWalked</seealso>
    let distanceWalked = Prefixed_Name(demlab, "distanceWalked") |> PrefixedName

    /// <summary>
    ///   <para>demlab:dsm_ivDepressionCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"DSM-IV Criteria for depression"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#dsm_ivDepressionCriteria">http://www.demcare.eu/ontologies/demlab.owl#dsm_ivDepressionCriteria</seealso>
    let dsm_ivDepressionCriteria =
        Prefixed_Name(demlab, "dsm_ivDepressionCriteria") |> PrefixedName

    /// <summary>
    ///   <para>demlab:dynamicBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Dynamical balance during the walking (e.g., people trajectory study)"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#dynamicBalance">http://www.demcare.eu/ontologies/demlab.owl#dynamicBalance</seealso>
    let dynamicBalance = Prefixed_Name(demlab, "dynamicBalance") |> PrefixedName
    /// <summary>
    ///   <para>demlab:fabScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Frontal Assessment Battery score"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#fabScore">http://www.demcare.eu/ontologies/demlab.owl#fabScore</seealso>
    let fabScore = Prefixed_Name(demlab, "fabScore") |> PrefixedName

    /// <summary>
    ///   <para>demlab:freeAndCuedRemindingAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Free and Cued Selective Reminding Test"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#freeAndCuedRemindingAssessment">http://www.demcare.eu/ontologies/demlab.owl#freeAndCuedRemindingAssessment</seealso>
    let freeAndCuedRemindingAssessment =
        Prefixed_Name(demlab, "freeAndCuedRemindingAssessment") |> PrefixedName

    /// <summary>
    ///   <para>demlab:handTrajectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates an instance of FunctionalAbilitiesData with a hand trajectory type"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#handTrajectory">http://www.demcare.eu/ontologies/demlab.owl#handTrajectory</seealso>
    let handTrajectory = Prefixed_Name(demlab, "handTrajectory") |> PrefixedName

    /// <summary>
    ///   <para>demlab:hasClinicalDiagnosis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The value of the DiagnosisAssessment"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#hasClinicalDiagnosis">http://www.demcare.eu/ontologies/demlab.owl#hasClinicalDiagnosis</seealso>
    let hasClinicalDiagnosis =
        Prefixed_Name(demlab, "hasClinicalDiagnosis") |> PrefixedName

    /// <summary>
    ///   <para>demlab:hasClinicalRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Each participant is associated with a clinical record"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#hasClinicalRecord">http://www.demcare.eu/ontologies/demlab.owl#hasClinicalRecord</seealso>
    let hasClinicalRecord = Prefixed_Name(demlab, "hasClinicalRecord") |> PrefixedName
    /// <summary>
    ///   <para>demlab:hasMMSEScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Mini-Mental State Exam score"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#hasMMSEScore">http://www.demcare.eu/ontologies/demlab.owl#hasMMSEScore</seealso>
    let hasMMSEScore = Prefixed_Name(demlab, "hasMMSEScore") |> PrefixedName
    /// <summary>
    ///   <para>demlab:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The participant of the protocol"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#hasParticipant">http://www.demcare.eu/ontologies/demlab.owl#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(demlab, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>demlab:hasProtocolStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Each Protocol consists of one or more ProtocolSteps"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#hasProtocolStep">http://www.demcare.eu/ontologies/demlab.owl#hasProtocolStep</seealso>
    let hasProtocolStep = Prefixed_Name(demlab, "hasProtocolStep") |> PrefixedName
    /// <summary>
    ///   <para>demlab:hasUPDRSScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Part III of the Unified Parkinson’s Disease Rating Scale"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#hasUPDRSScore">http://www.demcare.eu/ontologies/demlab.owl#hasUPDRSScore</seealso>
    let hasUPDRSScore = Prefixed_Name(demlab, "hasUPDRSScore") |> PrefixedName
    /// <summary>
    ///   <para>demlab:healthy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>demlab:DiagnosisType</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#healthy">http://www.demcare.eu/ontologies/demlab.owl#healthy</seealso>
    let healthy = Prefixed_Name(demlab, "healthy") |> PrefixedName
    /// <summary>
    ///   <para>demlab:iadl_e</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Allows the quantification of autonomy"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#iadl_e">http://www.demcare.eu/ontologies/demlab.owl#iadl_e</seealso>
    let iadl_e = Prefixed_Name(demlab, "iadl_e") |> PrefixedName
    /// <summary>
    ///   <para>demlab:incomplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>demlab:ActivityStatusType</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#incomplete">http://www.demcare.eu/ontologies/demlab.owl#incomplete</seealso>
    let incomplete = Prefixed_Name(demlab, "incomplete") |> PrefixedName
    /// <summary>
    ///   <para>demlab:involvesTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Each ProtocolStep involves one or more Tasks"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#involvesTask">http://www.demcare.eu/ontologies/demlab.owl#involvesTask</seealso>
    let involvesTask = Prefixed_Name(demlab, "involvesTask") |> PrefixedName
    /// <summary>
    ///   <para>demlab:isClinicalRecordOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#isClinicalRecordOf">http://www.demcare.eu/ontologies/demlab.owl#isClinicalRecordOf</seealso>
    let isClinicalRecordOf = Prefixed_Name(demlab, "isClinicalRecordOf") |> PrefixedName
    /// <summary>
    ///   <para>demlab:latency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time of latency between the end of instructions (stimulation) and the beginning of the task"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#latency">http://www.demcare.eu/ontologies/demlab.owl#latency</seealso>
    let latency = Prefixed_Name(demlab, "latency") |> PrefixedName
    /// <summary>
    ///   <para>demlab:measuredData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#measuredData">http://www.demcare.eu/ontologies/demlab.owl#measuredData</seealso>
    let measuredData = Prefixed_Name(demlab, "measuredData") |> PrefixedName
    /// <summary>
    ///   <para>demlab:npi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Neuropsychiatric Inventory"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#npi">http://www.demcare.eu/ontologies/demlab.owl#npi</seealso>
    let npi = Prefixed_Name(demlab, "npi") |> PrefixedName
    /// <summary>
    ///   <para>demlab:omitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>demlab:ActivityStatusType</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#omitted">http://www.demcare.eu/ontologies/demlab.owl#omitted</seealso>
    let omitted = Prefixed_Name(demlab, "omitted") |> PrefixedName
    /// <summary>
    ///   <para>demlab:participates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#participates">http://www.demcare.eu/ontologies/demlab.owl#participates</seealso>
    let participates = Prefixed_Name(demlab, "participates") |> PrefixedName
    /// <summary>
    ///   <para>demlab:pauseRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Pause rate during sentence repetition and mono/dual tasks"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#pauseRate">http://www.demcare.eu/ontologies/demlab.owl#pauseRate</seealso>
    let pauseRate = Prefixed_Name(demlab, "pauseRate") |> PrefixedName
    /// <summary>
    ///   <para>demlab:predementia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>demlab:DiagnosisType</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#predementia">http://www.demcare.eu/ontologies/demlab.owl#predementia</seealso>
    let predementia = Prefixed_Name(demlab, "predementia") |> PrefixedName
    /// <summary>
    ///   <para>demlab:repetitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of repetitions during semi-directed activities"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#repetitions">http://www.demcare.eu/ontologies/demlab.owl#repetitions</seealso>
    let repetitions = Prefixed_Name(demlab, "repetitions") |> PrefixedName

    /// <summary>
    ///   <para>demlab:shortCognitiveBatteryAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Short Cognitive Battery"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#shortCognitiveBatteryAssessment">http://www.demcare.eu/ontologies/demlab.owl#shortCognitiveBatteryAssessment</seealso>
    let shortCognitiveBatteryAssessment =
        Prefixed_Name(demlab, "shortCognitiveBatteryAssessment") |> PrefixedName

    /// <summary>
    ///   <para>demlab:speechFluency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Speech fluency during sentence repetition and picture description tasks"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#speechFluency">http://www.demcare.eu/ontologies/demlab.owl#speechFluency</seealso>
    let speechFluency = Prefixed_Name(demlab, "speechFluency") |> PrefixedName
    /// <summary>
    ///   <para>demlab:speechRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Speech fluency during sentence repetition and picture description tasks"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#speechRate">http://www.demcare.eu/ontologies/demlab.owl#speechRate</seealso>
    let speechRate = Prefixed_Name(demlab, "speechRate") |> PrefixedName
    /// <summary>
    ///   <para>demlab:stepLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Step length"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#stepLength">http://www.demcare.eu/ontologies/demlab.owl#stepLength</seealso>
    let stepLength = Prefixed_Name(demlab, "stepLength") |> PrefixedName

    /// <summary>
    ///   <para>demlab:stoppingDisplacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Stopping displacement during walking"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#stoppingDisplacement">http://www.demcare.eu/ontologies/demlab.owl#stoppingDisplacement</seealso>
    let stoppingDisplacement =
        Prefixed_Name(demlab, "stoppingDisplacement") |> PrefixedName

    /// <summary>
    ///   <para>demlab:stressLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#stressLevel">http://www.demcare.eu/ontologies/demlab.owl#stressLevel</seealso>
    let stressLevel = Prefixed_Name(demlab, "stressLevel") |> PrefixedName
    /// <summary>
    ///   <para>demlab:trailMakingTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Trail making test A and B"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#trailMakingTest">http://www.demcare.eu/ontologies/demlab.owl#trailMakingTest</seealso>
    let trailMakingTest = Prefixed_Name(demlab, "trailMakingTest") |> PrefixedName

    /// <summary>
    ///   <para>demlab:verbalReactionSpontaneity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time between the end of assessor’s speech and the beginning of participant’s speech (Discussion Task)"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#verbalReactionSpontaneity">http://www.demcare.eu/ontologies/demlab.owl#verbalReactionSpontaneity</seealso>
    let verbalReactionSpontaneity =
        Prefixed_Name(demlab, "verbalReactionSpontaneity") |> PrefixedName

    /// <summary>
    ///   <para>demlab:verbalReactionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time interval between the end of assessor’s speech and the beginning of participant’s speech (Sentence Repetition Task)"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#verbalReactionTime">http://www.demcare.eu/ontologies/demlab.owl#verbalReactionTime</seealso>
    let verbalReactionTime = Prefixed_Name(demlab, "verbalReactionTime") |> PrefixedName
    /// <summary>
    ///   <para>demlab:vowelDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#vowelDuration">http://www.demcare.eu/ontologies/demlab.owl#vowelDuration</seealso>
    let vowelDuration = Prefixed_Name(demlab, "vowelDuration") |> PrefixedName
    /// <summary>
    ///   <para>demlab:walkingSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Walking speed"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#walkingSpeed">http://www.demcare.eu/ontologies/demlab.owl#walkingSpeed</seealso>
    let walkingSpeed = Prefixed_Name(demlab, "walkingSpeed") |> PrefixedName

    /// <summary>
    ///   <para>demlab:walkingSpeedInstantaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Walking speed instantaneous (mono task walking activity/dual task)"</para>
    /// </remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/demlab.owl#walkingSpeedInstantaneous">http://www.demcare.eu/ontologies/demlab.owl#walkingSpeedInstantaneous</seealso>
    let walkingSpeedInstantaneous =
        Prefixed_Name(demlab, "walkingSpeedInstantaneous") |> PrefixedName
