#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dpo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/twc/dpo/ont/" "dpo"
    let ``_1.0`` = _prefixId.prefix "1.0"
    /// <summary>
    ///   <para>skos:definition : A description of an individual's current and past experience with alcoholic beverage consumption. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Alcohol Use^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/AlcoholUse">dpo:AlcoholUse</a>
    /// </summary>
    let AlcoholUse = _prefixId.prefix "AlcoholUse"
    let Alogliptin = _prefixId.prefix "Alogliptin"
    let AntihyperglycemicTreatment = _prefixId.prefix "AntihyperglycemicTreatment"
    /// <summary>
    ///   <para>skos:definition : Arthritis is a musculoskeletal system symptom characterized as an inflammation of joints due to infectious, metabolic, or constitutional causes. [ url:http://www2.merriam-webster.com/cgi-bin/mwmednlm?book=Medical&amp;va=arthritis ][Definition Source: SYMP:0019169]^^xsd:string</para>
    ///   <para>rdfs:label : Arthritis^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Arthritis">dpo:Arthritis</a>
    /// </summary>
    let Arthritis = _prefixId.prefix "Arthritis"

    let AtheroscleroticCardiovascularDiseaseRisk =
        _prefixId.prefix "AtheroscleroticCardiovascularDiseaseRisk"

    /// <summary>
    ///   <para>skos:definition : The actions or reactions of an object or organism, usually in relation to the environment or surrounding world of stimuli. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Behavior^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Behavior">dpo:Behavior</a>
    /// </summary>
    let Behavior = _prefixId.prefix "Behavior"
    let Biguanide = _prefixId.prefix "Biguanide"

    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Bilateral Lower Extremity Burning Sensation^^xsd:string</para>
    ///   <para>rdfs:comment : Occasional Burning Sensation in Bilateral Lower Extremities^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/BilateralLowerExtremityBurningSensation">dpo:BilateralLowerExtremityBurningSensation</a>
    /// </summary>
    let BilateralLowerExtremityBurningSensation =
        _prefixId.prefix "BilateralLowerExtremityBurningSensation"

    /// <summary>
    ///   <para>skos:definition : A quantitative measurement for assessing the amount of glucose present in a blood sample. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Blood Glucose Measurement^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/BloodGlucoseMeasurement">dpo:BloodGlucoseMeasurement</a>
    /// </summary>
    let BloodGlucoseMeasurement = _prefixId.prefix "BloodGlucoseMeasurement"
    /// <summary>
    ///   <para>skos:definition : A vision symptom that is characterized by a decreased clarity or sharpness in vision, which can be caused by eye conditions myopia or hyperopia. [Definition Source: SYMP:0000012]^^xsd:string</para>
    ///   <para>rdfs:label : Blurred Vision^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/BlurredVision">dpo:BlurredVision</a>
    /// </summary>
    let BlurredVision = _prefixId.prefix "BlurredVision"
    /// <summary>
    ///   <para>skos:definition : The result of a body mass index measurement. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Body Mass Index Finding^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/BodyMassIndexFinding">dpo:BodyMassIndexFinding</a>
    /// </summary>
    let BodyMassIndexFinding = _prefixId.prefix "BodyMassIndexFinding"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Borderline High LDL Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/BorderlineHighLDLLevel">dpo:BorderlineHighLDLLevel</a>
    /// </summary>
    let BorderlineHighLDLLevel = _prefixId.prefix "BorderlineHighLDLLevel"
    let BorderlineHighLDLRange = _prefixId.prefix "BorderlineHighLDLRange"

    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Borderline High Triglyceride Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideLevel">dpo:BorderlineHighTriglycerideLevel</a>
    /// </summary>
    let BorderlineHighTriglycerideLevel =
        _prefixId.prefix "BorderlineHighTriglycerideLevel"

    let BorderlineHighTriglycerideRange =
        _prefixId.prefix "BorderlineHighTriglycerideRange"

    let Canagliflozin = _prefixId.prefix "Canagliflozin"
    /// <summary>
    ///   <para>skos:definition : A non-neoplastic or neoplastic disorder affecting the heart or the vessels (arteries, veins and lymph vessels). Representative examples of non-neoplastic cardiovascular disorders are endocarditis and hypertension. Representative examples of neoplastic cardiovascular disorders are endocardial myxoma and angiosarcoma. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Cardiovascular Disease^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/CardiovascularDisease">dpo:CardiovascularDisease</a>
    /// </summary>
    let CardiovascularDisease = _prefixId.prefix "CardiovascularDisease"
    let CardiovascularEffect = _prefixId.prefix "CardiovascularEffect"
    /// <summary>
    ///   <para>skos:definition : A sudden loss of neurological function secondary to hemorrhage or ischemia in the brain parenchyma due to a vascular event. [Definition Source: NCI]^^xsd:stringskos:definition : Stroke is a nervous system symptom characterized by a sudden diminution or loss of consciousness, sensation, and voluntary motion caused by rupture or obstruction (as by a clot) of a blood vessel of the brain. [ url:http://www2.merriam-webster.com/cgi-bin/mwmednlm?book=Medical&amp;va=stroke ][Definition Source: SYMP:0000734]^^xsd:string</para>
    ///   <para>rdfs:label : Cerebral Vascular Accident^^xsd:string</para>
    ///   <para>rdfs:comment : A stroke.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/CerebralVascularAccident">dpo:CerebralVascularAccident</a>
    /// </summary>
    let CerebralVascularAccident = _prefixId.prefix "CerebralVascularAccident"
    /// <summary>
    ///   <para>skos:definition : An unpleasant sensation characterized by physical discomfort (such as pricking, throbbing, or aching) localized to the chest. [Definition Source: HP:0100749]^^xsd:string</para>
    ///   <para>rdfs:label : Chest Pain^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/ChestPain">dpo:ChestPain</a>
    /// </summary>
    let ChestPain = _prefixId.prefix "ChestPain"
    /// <summary>
    ///   <para>skos:definition : The determination of the amount of total cholesterol present in a sample. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Cholesterol Measurement^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/CholesterolMeasurement">dpo:CholesterolMeasurement</a>
    /// </summary>
    let CholesterolMeasurement = _prefixId.prefix "CholesterolMeasurement"
    /// <summary>
    ///   <para>skos:definition : A state of being, such as a state of health. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Condition^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Condition">dpo:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>skos:definition : Narrowing of the coronary arteries due to fatty deposits inside the arterial walls. The diagnostic criteria may include documented history of any of the following: documented coronary artery stenosis greater than or equal to 50% (by cardiac catheterization or other modality of direct imaging of the coronary arteries); previous coronary artery bypass surgery (CABG); previous percutaneous coronary intervention (PCI); previous myocardial infarction. (ACC) [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Coronary Artery Disease^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/CoronaryArteryDisease">dpo:CoronaryArteryDisease</a>
    /// </summary>
    let CoronaryArteryDisease = _prefixId.prefix "CoronaryArteryDisease"
    let Cost = _prefixId.prefix "Cost"
    let DPP4Inhibitor = _prefixId.prefix "DPP4Inhibitor"
    let Dapagliflozin = _prefixId.prefix "Dapagliflozin"

    /// <summary>
    ///   <para>skos:definition : FPG ≥126 mg/dL (7.0 mmol/L). [Definition Source: url:https://doi.org/10.2337/dc22-S002 ]^^xsd:string</para>
    ///   <para>rdfs:label : Diabetes Fasting Blood Glucose Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseLevel">dpo:DiabetesFastingBloodGlucoseLevel</a>
    /// </summary>
    let DiabetesFastingBloodGlucoseLevel =
        _prefixId.prefix "DiabetesFastingBloodGlucoseLevel"

    let DiabetesFastingBloodGlucoseRange =
        _prefixId.prefix "DiabetesFastingBloodGlucoseRange"

    /// <summary>
    ///   <para>skos:definition : A1C ≥6.5% (48 mmol/mol). [Definition Source: url:https://doi.org/10.2337/dc22-S002 ]^^xsd:string</para>
    ///   <para>rdfs:label : Diabetes HbA1C Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/DiabetesHbA1CLevel">dpo:DiabetesHbA1CLevel</a>
    /// </summary>
    let DiabetesHbA1CLevel = _prefixId.prefix "DiabetesHbA1CLevel"
    let DiabetesHbA1CRange = _prefixId.prefix "DiabetesHbA1CRange"
    /// <summary>
    ///   <para>skos:definition : A metabolic disorder characterized by abnormally high blood sugar levels due to diminished production of insulin or insulin resistance/desensitization. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Diabetes Mellitus^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/DiabetesMellitus">dpo:DiabetesMellitus</a>
    /// </summary>
    let DiabetesMellitus = _prefixId.prefix "DiabetesMellitus"

    /// <summary>
    ///   <para>skos:definition : 2-h PG ≥200 mg/dL (11.1 mmol/L) during OGTT. [Definition Source: url:https://doi.org/10.2337/dc22-S002 ]^^xsd:string</para>
    ///   <para>rdfs:label : Diabetes Two Hour Blood Glucose Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseLevel">dpo:DiabetesTwoHourBloodGlucoseLevel</a>
    /// </summary>
    let DiabetesTwoHourBloodGlucoseLevel =
        _prefixId.prefix "DiabetesTwoHourBloodGlucoseLevel"

    let DiabetesTwoHourBloodGlucoseRange =
        _prefixId.prefix "DiabetesTwoHourBloodGlucoseRange"

    let DiabeticKidneyDiseaseProgression =
        _prefixId.prefix "DiabeticKidneyDiseaseProgression"

    /// <summary>
    ///   <para>skos:definition : A biological, physiological, behavioral, or molecular indicator of the presence or predisposition towards development of a specific disease. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Diagnostic Factor^^xsd:string</para>
    ///   <para>rdfs:comment : A circumstance influencing the dianosis of a disease.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/DiagnosticFactor">dpo:DiagnosticFactor</a>
    /// </summary>
    let DiagnosticFactor = _prefixId.prefix "DiagnosticFactor"
    /// <summary>
    ///   <para>skos:definition : Any abnormal condition of the body or mind that causes discomfort, dysfunction, or distress to the person affected or those in contact with the person. The term is often used broadly to include injuries, disabilities, syndromes, symptoms, deviant behaviors, and atypical variations of structure and function. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Disease^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Disease">dpo:Disease</a>
    /// </summary>
    let Disease = _prefixId.prefix "Disease"
    /// <summary>
    ///   <para>skos:definition : A description of an individual's current and past use and/or abuse of drugs and chemicals. This includes prescription medication, illicit drugs and recreational substances. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Drug Use^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/DrugUse">dpo:DrugUse</a>
    /// </summary>
    let DrugUse = _prefixId.prefix "DrugUse"
    let Dulaglutide = _prefixId.prefix "Dulaglutide"
    /// <summary>
    ///   <para>skos:definition : A urinary system symptom that is characterized by the difficult, or painful, discharge of urine. [ url:http://www2.merriam-webster.com/cgi-bin/mwmednlm?book=Medical&amp;va=dysuria ][Definition Source: SYMP:0000485]^^xsd:string</para>
    ///   <para>rdfs:label : Dysuria^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Dysuria">dpo:Dysuria</a>
    /// </summary>
    let Dysuria = _prefixId.prefix "Dysuria"
    let Efficacy = _prefixId.prefix "Efficacy"
    let Empagliflozin = _prefixId.prefix "Empagliflozin"
    let Ertugliflozin = _prefixId.prefix "Ertugliflozin"
    let Exenatide = _prefixId.prefix "Exenatide"
    /// <summary>
    ///   <para>rdfs:label : External Class^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/ExternalClass">dpo:ExternalClass</a>
    /// </summary>
    let ExternalClass = _prefixId.prefix "ExternalClass"
    /// <summary>
    ///   <para>skos:definition : A record of a patient's background regarding health and disease events of blood relatives. A patient's family medical history may be important in diagnosing existing conditions. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Family History^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/FamilyHistory">dpo:FamilyHistory</a>
    /// </summary>
    let FamilyHistory = _prefixId.prefix "FamilyHistory"
    /// <summary>
    ///   <para>skos:definition : History of a first-degree relative (less than 55 years for male relatives or less than 65 years for female relatives) having had any of the following: coronary artery disease, myocardial infarction, coronary artery bypass graft surgery, percutaneous coronary intervention, or sudden cardiac death without obvious cause. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Family History of Coronary Artery Disease^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/FamilyHistoryOfCAD">dpo:FamilyHistoryOfCAD</a>
    /// </summary>
    let FamilyHistoryOfCAD = _prefixId.prefix "FamilyHistoryOfCAD"
    /// <summary>
    ///   <para>skos:definition : Having at least one-first-degree relative with diabetes. [Definition Source: url:https://doi.org/10.1111/jdi.12033 ]^^xsd:string</para>
    ///   <para>rdfs:label : Family History of Diabetes^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/FamilyHistoryOfDiabetes">dpo:FamilyHistoryOfDiabetes</a>
    /// </summary>
    let FamilyHistoryOfDiabetes = _prefixId.prefix "FamilyHistoryOfDiabetes"
    /// <summary>
    ///   <para>skos:definition : Fatigue is a neurological and physiological symptom characterized by a weariness or exhaustion from labor, exertion, or stress. [ url:http://www2.merriam-webster.com/cgi-bin/mwmednlm?book=Medical&amp;va=fatigue ][Definition Source: SYMP:0019177]^^xsd:string</para>
    ///   <para>rdfs:label : Fatigue^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Fatigue">dpo:Fatigue</a>
    /// </summary>
    let Fatigue = _prefixId.prefix "Fatigue"
    /// <summary>
    ///   <para>skos:definition : A deviation from the normal odor of the urine. [Definition Source: HP:0012088]^^xsd:string</para>
    ///   <para>rdfs:label : Foul Urine^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/FoulUrine">dpo:FoulUrine</a>
    /// </summary>
    let FoulUrine = _prefixId.prefix "FoulUrine"
    /// <summary>
    ///   <para>skos:definition : Increased frequency of urination. [Definition Source: HP:0100515]^^xsd:string</para>
    ///   <para>rdfs:label : Frequent Urination^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/FrequentUrination">dpo:FrequentUrination</a>
    /// </summary>
    let FrequentUrination = _prefixId.prefix "FrequentUrination"
    let GLP1RA = _prefixId.prefix "GLP1RA"
    let Glimepiride = _prefixId.prefix "Glimepiride"
    let Glipizide = _prefixId.prefix "Glipizide"
    let Glyburide = _prefixId.prefix "Glyburide"
    let HeartFailureRisk = _prefixId.prefix "HeartFailureRisk"
    let HighCost = _prefixId.prefix "HighCost"
    let HighCostDiabetesTherapy = _prefixId.prefix "HighCostDiabetesTherapy"
    let HighEfficacy = _prefixId.prefix "HighEfficacy"
    let HighEfficacyDiabetesTherapy = _prefixId.prefix "HighEfficacyDiabetesTherapy"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : High LDL Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/HighLDLLevel">dpo:HighLDLLevel</a>
    /// </summary>
    let HighLDLLevel = _prefixId.prefix "HighLDLLevel"
    let HighLDLRange = _prefixId.prefix "HighLDLRange"
    /// <summary>
    ///   <para>rdfs:label : High Sugar Diet^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/HighSugarDiet">dpo:HighSugarDiet</a>
    /// </summary>
    let HighSugarDiet = _prefixId.prefix "HighSugarDiet"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : High Triglyceride Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/HighTriglycerideLevel">dpo:HighTriglycerideLevel</a>
    /// </summary>
    let HighTriglycerideLevel = _prefixId.prefix "HighTriglycerideLevel"
    let HighTriglycerideRange = _prefixId.prefix "HighTriglycerideRange"
    /// <summary>
    ///   <para>skos:definition : The aggregate of past events; the continuum of events occurring in succession leading from the past to the present; a record or narrative description of past events. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : History^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/History">dpo:History</a>
    /// </summary>
    let History = _prefixId.prefix "History"
    /// <summary>
    ///   <para>skos:definition : Elevated levels of lipids in the blood. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Hyperlipidemia^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Hyperlipidemia">dpo:Hyperlipidemia</a>
    /// </summary>
    let Hyperlipidemia = _prefixId.prefix "Hyperlipidemia"
    /// <summary>
    ///   <para>skos:definition : Blood pressure that is abnormally high. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Hypertension^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Hypertension">dpo:Hypertension</a>
    /// </summary>
    let Hypertension = _prefixId.prefix "Hypertension"
    let HypoglycemiaRisk = _prefixId.prefix "HypoglycemiaRisk"
    let IncreasedASCVDRisk = _prefixId.prefix "IncreasedASCVDRisk"
    let IncreasedDKDRisk = _prefixId.prefix "IncreasedDKDRisk"

    let IncreasedDKDRiskDiabetesTherapy =
        _prefixId.prefix "IncreasedDKDRiskDiabetesTherapy"

    let IncreasedHeartFailureRisk = _prefixId.prefix "IncreasedHeartFailureRisk"
    /// <summary>
    ///   <para>rdfs:label : Insufficient Exercise^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/InsufficientExercise">dpo:InsufficientExercise</a>
    /// </summary>
    let InsufficientExercise = _prefixId.prefix "InsufficientExercise"
    let IntermediateEfficacy = _prefixId.prefix "IntermediateEfficacy"
    let KnownHypoglycemiaRisk = _prefixId.prefix "KnownHypoglycemiaRisk"
    let Linagliptin = _prefixId.prefix "Linagliptin"
    let Liraglutide = _prefixId.prefix "Liraglutide"
    let Lixisenatide = _prefixId.prefix "Lixisenatide"
    let LowCost = _prefixId.prefix "LowCost"
    let LowCostDiabetesTherapy = _prefixId.prefix "LowCostDiabetesTherapy"
    let LowEfficacy = _prefixId.prefix "LowEfficacy"
    let LowEfficacyDiabetesTherapy = _prefixId.prefix "LowEfficacyDiabetesTherapy"
    let Metformin = _prefixId.prefix "Metformin"
    /// <summary>
    ///   <para>skos:definition : Musculoskeletal symptoms are defined as pain in the muscles, tendons, and nerves arising from repetitive, continuous, and unnatural movements. These symptoms can be expressed in various areas of the body and affect the quality of life by causing difficulties in performing occupational tasks and activities of daily living (ADL). [Definition Source: url:https://www.ncbi.nlm.nih.gov/pmc/articles/PMC3567324/ ]^^xsd:string</para>
    ///   <para>rdfs:label : Musculoskeletal System Symptom^^xsd:string</para>
    ///   <para>rdfs:comment : A symptom involving the musculoskeletal system.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/MusculoskeletalSystemSymptom">dpo:MusculoskeletalSystemSymptom</a>
    /// </summary>
    let MusculoskeletalSystemSymptom = _prefixId.prefix "MusculoskeletalSystemSymptom"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Near Optimal LDL Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/NearOptimalLDLLevel">dpo:NearOptimalLDLLevel</a>
    /// </summary>
    let NearOptimalLDLLevel = _prefixId.prefix "NearOptimalLDLLevel"
    let NearOptimalLDLRange = _prefixId.prefix "NearOptimalLDLRange"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Nervous System Symptom^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/NervousSystemSymptom">dpo:NervousSystemSymptom</a>
    /// </summary>
    let NervousSystemSymptom = _prefixId.prefix "NervousSystemSymptom"

    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Neurological and Physiological Symptom^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/NeurologicalAndPhysiologicalSymptom">dpo:NeurologicalAndPhysiologicalSymptom</a>
    /// </summary>
    let NeurologicalAndPhysiologicalSymptom =
        _prefixId.prefix "NeurologicalAndPhysiologicalSymptom"

    let NeutralASCVDRisk = _prefixId.prefix "NeutralASCVDRisk"
    let NeutralDKDRisk = _prefixId.prefix "NeutralDKDRisk"
    let NeutralHeartFailureRisk = _prefixId.prefix "NeutralHeartFailureRisk"
    let NeutralWeightChange = _prefixId.prefix "NeutralWeightChange"
    let NoKnownHypoglycemiaRisk = _prefixId.prefix "NoKnownHypoglycemiaRisk"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Normal Triglyceride Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/NormalTriglycerideLevel">dpo:NormalTriglycerideLevel</a>
    /// </summary>
    let NormalTriglycerideLevel = _prefixId.prefix "NormalTriglycerideLevel"
    let NormalTriglycerideRange = _prefixId.prefix "NormalTriglycerideRange"
    /// <summary>
    ///   <para>skos:definition : BMI greater than or equal to 18.5 to 24.9 kg/m^2 [Definition Source: url:https://www.ncbi.nlm.nih.gov/books/NBK541070/ ]^^xsd:string</para>
    ///   <para>rdfs:label : Normal Weight^^xsd:string</para>
    ///   <para>rdfs:comment : 18.5&lt;BMI&lt;24.9^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/NormalWeight">dpo:NormalWeight</a>
    /// </summary>
    let NormalWeight = _prefixId.prefix "NormalWeight"
    let NormalWeightBMIRange = _prefixId.prefix "NormalWeightBMIRange"

    /// <summary>
    ///   <para>skos:definition : Symptoms concerning nutrition metabolism and development [include:] A disorder characterized by a loss of appetite; An abnormal loss of the appetite for food. Anorexia can be caused by cancer, aids, a mental disorder (i.e., anorexia nervosa), or other diseases; Clinical manifestation consisting of a physiopathological lack or loss of appetite accompanied by an aversion to food and the inability to eat; Loss of appetite; The lack or loss of appetite accompanied by an aversion to food and the inability to eat. It is the defining characteristic of the disorder anorexia nervosa. [Definition Source: url:http://www.icd9data.com/2013/Volume1/780-799/780-789/783/default.htm ]^^xsd:string</para>
    ///   <para>rdfs:label : Nutrition Metabolism and Development Symptom^^xsd:string</para>
    ///   <para>rdfs:comment : A symptom involving the nutrition, metabolism, and/or development system.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/NutritionMetabolismAndDevelopmentSymptom">dpo:NutritionMetabolismAndDevelopmentSymptom</a>
    /// </summary>
    let NutritionMetabolismAndDevelopmentSymptom =
        _prefixId.prefix "NutritionMetabolismAndDevelopmentSymptom"

    /// <summary>
    ///   <para>skos:definition : Having a high amount of body fat (body mass index [BMI] of 30 or more). [Definition Source: NCI]^^xsd:stringskos:definition : The quantification of weight/height relationships above a certain threshold that classes an individual as overweight. This threshold may vary based on an individual's ethnicity but is commonly considered to correspond in European populations to a BMI &gt; 30. [Definition Source: EFO:0007041]^^xsd:string</para>
    ///   <para>rdfs:label : Obese^^xsd:string</para>
    ///   <para>rdfs:comment : 30&lt;BMI^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Obese">dpo:Obese</a>
    /// </summary>
    let Obese = _prefixId.prefix "Obese"
    let ObeseBMIRange = _prefixId.prefix "ObeseBMIRange"
    /// <summary>
    ///   <para>skos:definition : The principal activity that a person does to earn money. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Occupation^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Occupation">dpo:Occupation</a>
    /// </summary>
    let Occupation = _prefixId.prefix "Occupation"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Optimal LDL Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/OptimalLDLLevel">dpo:OptimalLDLLevel</a>
    /// </summary>
    let OptimalLDLLevel = _prefixId.prefix "OptimalLDLLevel"
    let OptimalLDLRange = _prefixId.prefix "OptimalLDLRange"
    /// <summary>
    ///   <para>skos:definition : The quantification of weight/height relationships above a certain threshold that classes an individual as overweight. This threshold may vary based on an individual's ethnicity but is commonly considered to correspond in European populations to a 25&lt;BMI&lt;30. [Definition Source: EFO:0005935]^^xsd:string</para>
    ///   <para>rdfs:label : Overweight^^xsd:string</para>
    ///   <para>rdfs:comment : 25&lt;BMI&lt;30^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Overweight">dpo:Overweight</a>
    /// </summary>
    let Overweight = _prefixId.prefix "Overweight"
    let OverweightBMIRange = _prefixId.prefix "OverweightBMIRange"
    /// <summary>
    ///   <para>skos:definition : A sensation perception where there is an unpleasant sensation that usually indicates the body is threatened or damaged. The sensation may be sharp or dull, short-lived or chronic, intermittent or continual, confined to one area or spread over the entire body. [ url:http://www.nationalpainfoundation.org/MyTreatment/articles/Cancer_PainDefinitions.asp ][Definition Source: SYMP:0000576]^^xsd:string</para>
    ///   <para>rdfs:label : Pain^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Pain">dpo:Pain</a>
    /// </summary>
    let Pain = _prefixId.prefix "Pain"
    /// <summary>
    ///   <para>skos:definition : The distinguishing qualities or prominent aspect of a person. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Patient Characteristic^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PatientCharacteristic">dpo:PatientCharacteristic</a>
    /// </summary>
    let PatientCharacteristic = _prefixId.prefix "PatientCharacteristic"
    /// <summary>
    ///   <para>skos:definition : Peripheral neuropathy refers to the many conditions that involve damage to the peripheral nervous system, the vast communication network that sends signals between the central nervous system (the brain and spinal cord) and all other parts of the body. [Definition Source: url:https://www.ninds.nih.gov/peripheral-neuropathy-fact-sheet ]^^xsd:string</para>
    ///   <para>rdfs:label : Peripheral Neuropathy^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PeripheralNeuropathy">dpo:PeripheralNeuropathy</a>
    /// </summary>
    let PeripheralNeuropathy = _prefixId.prefix "PeripheralNeuropathy"
    /// <summary>
    ///   <para>skos:definition : A record of a patient's background regarding health and the occurrence of disease events of the individual. In addition, personal medical history may be a variable in epidemiologic studies. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Personal History^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PersonalHistory">dpo:PersonalHistory</a>
    /// </summary>
    let PersonalHistory = _prefixId.prefix "PersonalHistory"

    /// <summary>
    ///   <para>skos:definition : Febrile seizures are defined as events in infancy or childhood that usually occur between three months and five years of age and are associated with a fever, but without evidence of intracranial infection or a defined cause for the seizure. [Definition Source: url:https://www.aafp.org/pubs/afp/issues/2008/1115/p1199.html ]^^xsd:string</para>
    ///   <para>rdfs:label : Personal History of Febrile States^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PersonalHistoryOfFebrileStates">dpo:PersonalHistoryOfFebrileStates</a>
    /// </summary>
    let PersonalHistoryOfFebrileStates =
        _prefixId.prefix "PersonalHistoryOfFebrileStates"

    /// <summary>
    ///   <para>skos:definition : Gestational diabetes mellitus (GDM), defined as glucose intolerance that is first recognized during pregnancy, is associated with maternal obesity and confers a 4‐ to 7‐fold greater risk of incident type 2 diabetes (DM), and increased risk of developing the metabolic syndrome (MetS) in midlife. In addition, a history of GDM among nondiabetic women is characterized by elevations in fasting glucose and insulin concentrations, as well as dyslipidemia and greater inflammation in the absence of the MetS. [Definition Source: url:https://www.ncbi.nlm.nih.gov/pmc/articles/PMC4187501/ ]^^xsd:string</para>
    ///   <para>rdfs:label : Personal History of Gestational Diabetes^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PersonalHistoryOfGestationalDiabetes">dpo:PersonalHistoryOfGestationalDiabetes</a>
    /// </summary>
    let PersonalHistoryOfGestationalDiabetes =
        _prefixId.prefix "PersonalHistoryOfGestationalDiabetes"

    /// <summary>
    ///   <para>skos:definition : Therapy-related factors identified include: route of administration, treatment complexity, duration of treatment period, medication side effects, degree of behavioral change required, taste of medication and requirement for drug storage. [Definition Source: url:https://www.ncbi.nlm.nih.gov/pmc/articles/PMC2503662/ ]^^xsd:string</para>
    ///   <para>rdfs:label : Pharmacotherapy Factor^^xsd:string</para>
    ///   <para>rdfs:comment : A circumstance influencing the treatment of a disease through the use or recommendation of one or more drugs.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PharmacotherapyFactor">dpo:PharmacotherapyFactor</a>
    /// </summary>
    let PharmacotherapyFactor = _prefixId.prefix "PharmacotherapyFactor"
    let Pioglitazone = _prefixId.prefix "Pioglitazone"
    /// <summary>
    ///   <para>skos:definition : Polydipsia is a nutrition, metabolism, and development symptom characterized by an excessive or abnormal thirst. [ url:http://www2.merriam-webster.com/cgi-bin/mwmednlm?book=Medical&amp;va=polydipsia ][Definition Source: SYMP:0000560]^^xsd:string</para>
    ///   <para>rdfs:label : Polydipsia^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Polydipsia">dpo:Polydipsia</a>
    /// </summary>
    let Polydipsia = _prefixId.prefix "Polydipsia"
    /// <summary>
    ///   <para>skos:definition : Polyphagia is a nutrition, metabolism, and development symptom characterized by an excessive appetite or eating. [ url:http://www2.merriam-webster.com/cgi-bin/mwmednlm?book=Medical&amp;va=polyphagia ][Definition Source: SYMP:0000524]^^xsd:string</para>
    ///   <para>rdfs:label : Polyphagia^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Polyphagia">dpo:Polyphagia</a>
    /// </summary>
    let Polyphagia = _prefixId.prefix "Polyphagia"
    /// <summary>
    ///   <para>skos:definition : A urinary system symptom that is characterized by the excessive secretion of urine. [ url:http://www2.merriam-webster.com/cgi-bin/mwmednlm?book=Medical&amp;va=polyuria ][Definition Source: SYMP:0000565]^^xsd:string</para>
    ///   <para>rdfs:label : Polyuria^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Polyuria">dpo:Polyuria</a>
    /// </summary>
    let Polyuria = _prefixId.prefix "Polyuria"
    let PotentialASCVDBenefit = _prefixId.prefix "PotentialASCVDBenefit"

    let PotentialASCVDBenefitDiabetesTherapy =
        _prefixId.prefix "PotentialASCVDBenefitDiabetesTherapy"

    let PotentialDKDBenefit = _prefixId.prefix "PotentialDKDBenefit"

    let PotentialDKDBenefitDiabetesTherapy =
        _prefixId.prefix "PotentialDKDBenefitDiabetesTherapy"

    let PotentialHeartFailureBenefit = _prefixId.prefix "PotentialHeartFailureBenefit"

    /// <summary>
    ///   <para>skos:definition : FPG 100 mg/dL (5.6 mmol/L) to 125 mg/dL (6.9 mmol/L). [Definition Source: url:https://doi.org/10.2337/dc22-S002 ]^^xsd:string</para>
    ///   <para>rdfs:label : Prediabetes Fasting Blood Glucose Level^^xsd:string</para>
    ///   <para>rdfs:comment :  impaired fasting glucose^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseLevel">dpo:PrediabetesFastingBloodGlucoseLevel</a>
    /// </summary>
    let PrediabetesFastingBloodGlucoseLevel =
        _prefixId.prefix "PrediabetesFastingBloodGlucoseLevel"

    let PrediabetesFastingBloodGlucoseRange =
        _prefixId.prefix "PrediabetesFastingBloodGlucoseRange"

    /// <summary>
    ///   <para>skos:definition : A1C 5.7–6.4% (39–47 mmol/mol). [Definition Source: url:https://doi.org/10.2337/dc22-S002 ]^^xsd:string</para>
    ///   <para>rdfs:label : Prediabetes HbA1C Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PrediabetesHbA1CLevel">dpo:PrediabetesHbA1CLevel</a>
    /// </summary>
    let PrediabetesHbA1CLevel = _prefixId.prefix "PrediabetesHbA1CLevel"
    let PrediabetesHbA1CRange = _prefixId.prefix "PrediabetesHbA1CRange"

    /// <summary>
    ///   <para>skos:definition : 2-h PG during 75-g OGTT 140 mg/dL (7.8 mmol/L) to 199 mg/dL (11.0 mmol/L). [Definition Source: url:https://doi.org/10.2337/dc22-S002 ]^^xsd:string</para>
    ///   <para>rdfs:label : Prediabetes Two Hour Blood Glucose Level^^xsd:string</para>
    ///   <para>rdfs:comment : impaired glucose tolerance^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseLevel">dpo:PrediabetesTwoHourBloodGlucoseLevel</a>
    /// </summary>
    let PrediabetesTwoHourBloodGlucoseLevel =
        _prefixId.prefix "PrediabetesTwoHourBloodGlucoseLevel"

    let PrediabetesTwoHourBloodGlucoseRange =
        _prefixId.prefix "PrediabetesTwoHourBloodGlucoseRange"

    /// <summary>
    ///   <para>skos:definition : A neoplastic or non-neoplastic condition affecting the kidney. Representative examples of non-neoplastic conditions include glomerulonephritis and nephrotic syndrome. Representative examples of neoplastic conditions include benign processes (e.g., renal lipoma and renal fibroma) and malignant processes (e.g., renal cell carcinoma and renal lymphoma). [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Renal Disease^^xsd:string</para>
    ///   <para>rdfs:comment : Disease associated with kidneys, typically chronic kidney disease.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/RenalDisease">dpo:RenalDisease</a>
    /// </summary>
    let RenalDisease = _prefixId.prefix "RenalDisease"
    let RenalDosingConsideration = _prefixId.prefix "RenalDosingConsideration"
    let RenalEffect = _prefixId.prefix "RenalEffect"
    let Rosiglitazone = _prefixId.prefix "Rosiglitazone"
    let SGLT2Inhibitor = _prefixId.prefix "SGLT2Inhibitor"
    let Saxagliptin = _prefixId.prefix "Saxagliptin"
    /// <summary>
    ///   <para>skos:definition : A type of lifestyle that lacks physical exercise, characterized by sitting, reading, watching television or using a computer for much of the day without vigorous physical exertion. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Sedentary Lifestyle^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/SedentaryLifestyle">dpo:SedentaryLifestyle</a>
    /// </summary>
    let SedentaryLifestyle = _prefixId.prefix "SedentaryLifestyle"
    /// <summary>
    ///   <para>skos:definition : A physical demand level described as the exertion of up to 10 pounds of force occasionally, negligible amount of work frequently, and a negligible amount of force constantly to move objects. [Definition Source: url:https://medical-dictionary.thefreedictionary.com/sedentary+work ]^^xsd:string</para>
    ///   <para>rdfs:label : Sedentary Occupation^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/SedentaryOccupation">dpo:SedentaryOccupation</a>
    /// </summary>
    let SedentaryOccupation = _prefixId.prefix "SedentaryOccupation"
    let Semaglutide = _prefixId.prefix "Semaglutide"
    let Sitagliptin = _prefixId.prefix "Sitagliptin"
    let Sulfonylurea = _prefixId.prefix "Sulfonylurea"
    /// <summary>
    ///   <para>skos:definition : A symptom is a perceived change in function, sensation, loss, disturbance or appearance reported by a patient indicative of a disease. [ url:https://link.springer.com/chapter/10.1007/978-1-4615-4789-1_5 url:https://www.nature.com/subjects/signs-and-symptoms url:https://www.merriam-webster.com/dictionary/symptom ][Definition Source: SYMP:0000462]^^xsd:string</para>
    ///   <para>rdfs:label : Symptom^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Symptom">dpo:Symptom</a>
    /// </summary>
    let Symptom = _prefixId.prefix "Symptom"
    /// <summary>
    ///   <para>skos:definition : Annotation used to indicate the size or magnitude of something that was determined by comparison to a standard. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Test Finding^^xsd:string</para>
    ///   <para>rdfs:comment : A finding or categorization surmised from recorded measurements.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/TestFinding">dpo:TestFinding</a>
    /// </summary>
    let TestFinding = _prefixId.prefix "TestFinding"
    /// <summary>
    ///   <para>skos:definition : An action or administration of therapeutic agents to produce an effect that is intended to alter or stop a pathologic process. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Therapy^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Therapy">dpo:Therapy</a>
    /// </summary>
    let Therapy = _prefixId.prefix "Therapy"
    /// <summary>
    ///   <para>rdfs:label : Therapy Planning Component^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/TherapyPlanningComponent">dpo:TherapyPlanningComponent</a>
    /// </summary>
    let TherapyPlanningComponent = _prefixId.prefix "TherapyPlanningComponent"
    let Thiazolidinedione = _prefixId.prefix "Thiazolidinedione"
    /// <summary>
    ///   <para>skos:definition : A quantitative measurement of the amount of triglyceride present in a sample. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Triglyceride Measurement^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/TriglycerideMeasurement">dpo:TriglycerideMeasurement</a>
    /// </summary>
    let TriglycerideMeasurement = _prefixId.prefix "TriglycerideMeasurement"
    /// <summary>
    ///   <para>skos:definition : The quantification of weight/height relationships below a certain threshold that classes an individual as underweight. This threshold may vary based on an individual's ethnicity but is commonly considered in European populations to correspond to a BMI &lt; 18. [Definition Source: EFO:0005936]^^xsd:string</para>
    ///   <para>rdfs:label : Underweight^^xsd:string</para>
    ///   <para>rdfs:comment : BMI&lt;18.5^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/Underweight">dpo:Underweight</a>
    /// </summary>
    let Underweight = _prefixId.prefix "Underweight"
    let UnderweightBMIRange = _prefixId.prefix "UnderweightBMIRange"
    /// <summary>
    ///   <para>skos:definition : Symptoms of urinary disorders vary from person to person and based on the cause of the disorders. Common urinary symptoms include: Abdominal cramping; Abdominal, pelvic or back pain that can be severe; Bloody or pink-colored urine (hematuria); Cloudy urine; Fever and chills; Foul-smelling urine; Frequent urination; General ill feeling; Leaking of urine; Pain during sexual intercourse; Pain or burning with urination (dysuria); Unexplained weight loss; Urgent need to urinate. [Definition Source: url:https://www.healthgrades.com/right-care/kidneys-and-the-urinary-system/urinary-disorders ]^^xsd:string</para>
    ///   <para>rdfs:label : Urinary System Symptom^^xsd:string</para>
    ///   <para>rdfs:comment : A symptom involving the urinary system.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/UrinarySystemSymptom">dpo:UrinarySystemSymptom</a>
    /// </summary>
    let UrinarySystemSymptom = _prefixId.prefix "UrinarySystemSymptom"
    /// <summary>
    ///   <para>skos:definition : A bacterial infectious process affecting any part of the urinary tract, most commonly the bladder and the urethra. Symptoms include urinary urgency and frequency, burning sensation during urination, lower abdominal discomfort, and cloudy urine. [Definition Source: NCI]^^xsd:string</para>
    ///   <para>rdfs:label : Urinary Tract Infection (UTI)^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/UrinaryTractInfection">dpo:UrinaryTractInfection</a>
    /// </summary>
    let UrinaryTractInfection = _prefixId.prefix "UrinaryTractInfection"
    /// <summary>
    ///   <para>skos:definition : A1C ≥ 9%^^xsd:string</para>
    ///   <para>rdfs:label : Very High HbA1C Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/VeryHighHbA1CLevel">dpo:VeryHighHbA1CLevel</a>
    /// </summary>
    let VeryHighHbA1CLevel = _prefixId.prefix "VeryHighHbA1CLevel"
    let VeryHighHbA1CRange = _prefixId.prefix "VeryHighHbA1CRange"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Very High LDL Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/VeryHighLDLLevel">dpo:VeryHighLDLLevel</a>
    /// </summary>
    let VeryHighLDLLevel = _prefixId.prefix "VeryHighLDLLevel"
    let VeryHighLDLRange = _prefixId.prefix "VeryHighLDLRange"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Very High Triglyceride Level^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/VeryHighTriglycerideLevel">dpo:VeryHighTriglycerideLevel</a>
    /// </summary>
    let VeryHighTriglycerideLevel = _prefixId.prefix "VeryHighTriglycerideLevel"
    let VeryHighTriglycerideRange = _prefixId.prefix "VeryHighTriglycerideRange"
    /// <summary>
    ///   <para>skos:definition : ^^xsd:string</para>
    ///   <para>rdfs:label : Vision Symptom^^xsd:string</para>
    ///   <para>rdfs:comment : A symptom involving visual impairment.^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/VisionSymptom">dpo:VisionSymptom</a>
    /// </summary>
    let VisionSymptom = _prefixId.prefix "VisionSymptom"
    let WeightChangePotential = _prefixId.prefix "WeightChangePotential"
    let WeightGainDiabetesTherapy = _prefixId.prefix "WeightGainDiabetesTherapy"
    let WeightGainPotential = _prefixId.prefix "WeightGainPotential"
    let WeightLossDiabetesTherapy = _prefixId.prefix "WeightLossDiabetesTherapy"
    let WeightLossPotential = _prefixId.prefix "WeightLossPotential"

    let ``diabetes_pharmacology_ontology.ttl`` =
        _prefixId.prefix "diabetes_pharmacology_ontology.ttl"

    /// <summary>
    ///   <para>rdfs:label : has diagnosis^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/hasDiagnosis">dpo:hasDiagnosis</a>
    /// </summary>
    let hasDiagnosis = _prefixId.prefix "hasDiagnosis"
    /// <summary>
    ///   <para>rdfs:label : has therapy^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/hasTherapy">dpo:hasTherapy</a>
    /// </summary>
    let hasTherapy = _prefixId.prefix "hasTherapy"
    /// <summary>
    ///   <para>rdfs:label : has therapy aversion^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/hasTreatmentAversion">dpo:hasTreatmentAversion</a>
    /// </summary>
    let hasTreatmentAversion = _prefixId.prefix "hasTreatmentAversion"
    /// <summary>
    ///   <para>rdfs:label : has therapy preference^^xsd:string</para>
    ///   <a href="http://purl.org/twc/dpo/ont/hasTreatmentPreference">dpo:hasTreatmentPreference</a>
    /// </summary>
    let hasTreatmentPreference = _prefixId.prefix "hasTreatmentPreference"
