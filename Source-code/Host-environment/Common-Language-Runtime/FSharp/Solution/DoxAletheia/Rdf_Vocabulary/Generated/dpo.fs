namespace http.purl.org.twc.dpo.ont.slash

open DoxAletheia

module dpo =
    let _namespace_name = "http://purl.org/twc/dpo/ont/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/ExternalClass"></see>
    /// </summary>
    let ExternalClass = _prefix "ExternalClass"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighCostDiabetesTherapy"></see>
    /// </summary>
    let HighCostDiabetesTherapy = _prefix "HighCostDiabetesTherapy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighEfficacyDiabetesTherapy"></see>
    /// </summary>
    let HighEfficacyDiabetesTherapy = _prefix "HighEfficacyDiabetesTherapy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/IncreasedDKDRiskDiabetesTherapy"></see>
    /// </summary>
    let IncreasedDKDRiskDiabetesTherapy = _prefix "IncreasedDKDRiskDiabetesTherapy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/LowCostDiabetesTherapy"></see>
    /// </summary>
    let LowCostDiabetesTherapy = _prefix "LowCostDiabetesTherapy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/LowEfficacyDiabetesTherapy"></see>
    /// </summary>
    let LowEfficacyDiabetesTherapy = _prefix "LowEfficacyDiabetesTherapy"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PotentialASCVDBenefitDiabetesTherapy"></see>
    /// </summary>
    let PotentialASCVDBenefitDiabetesTherapy =
        _prefix "PotentialASCVDBenefitDiabetesTherapy"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PotentialDKDBenefitDiabetesTherapy"></see>
    /// </summary>
    let PotentialDKDBenefitDiabetesTherapy =
        _prefix "PotentialDKDBenefitDiabetesTherapy"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/WeightGainDiabetesTherapy"></see>
    /// </summary>
    let WeightGainDiabetesTherapy = _prefix "WeightGainDiabetesTherapy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/WeightLossDiabetesTherapy"></see>
    /// </summary>
    let WeightLossDiabetesTherapy = _prefix "WeightLossDiabetesTherapy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/AlcoholUse"></see>
    /// </summary>
    let AlcoholUse = _prefix "AlcoholUse"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Behavior"></see>
    /// </summary>
    let Behavior = _prefix "Behavior"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Alogliptin"></see>
    /// </summary>
    let Alogliptin = _prefix "Alogliptin"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DPP4Inhibitor"></see>
    /// </summary>
    let DPP4Inhibitor = _prefix "DPP4Inhibitor"
    /// <summary>
    /// Treatment designed to lower blood sugar levels.
    /// <see href="http://purl.org/twc/dpo/ont/AntihyperglycemicTreatment"></see></summary>
    let AntihyperglycemicTreatment = _prefix "AntihyperglycemicTreatment"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Therapy"></see>
    /// </summary>
    let Therapy = _prefix "Therapy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Arthritis"></see>
    /// </summary>
    let Arthritis = _prefix "Arthritis"
    /// <summary>
    /// A symptom involving the musculoskeletal system.
    /// <see href="http://purl.org/twc/dpo/ont/MusculoskeletalSystemSymptom"></see></summary>
    let MusculoskeletalSystemSymptom = _prefix "MusculoskeletalSystemSymptom"

    /// <summary>
    /// Risk of cardiovascular disease resulting from atherosclerosis.
    /// <see href="http://purl.org/twc/dpo/ont/AtheroscleroticCardiovascularDiseaseRisk"></see></summary>
    let AtheroscleroticCardiovascularDiseaseRisk =
        _prefix "AtheroscleroticCardiovascularDiseaseRisk"

    /// <summary>
    /// A pharmacotherapy factor related to the heart or blood vessels.
    /// <see href="http://purl.org/twc/dpo/ont/CardiovascularEffect"></see></summary>
    let CardiovascularEffect = _prefix "CardiovascularEffect"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PatientCharacteristic"></see>
    /// </summary>
    let PatientCharacteristic = _prefix "PatientCharacteristic"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Biguanide"></see>
    /// </summary>
    let Biguanide = _prefix "Biguanide"

    /// <summary>
    /// Occasional Burning Sensation in Bilateral Lower Extremities
    /// <see href="http://purl.org/twc/dpo/ont/BilateralLowerExtremityBurningSensation"></see></summary>
    let BilateralLowerExtremityBurningSensation =
        _prefix "BilateralLowerExtremityBurningSensation"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NervousSystemSymptom"></see>
    /// </summary>
    let NervousSystemSymptom = _prefix "NervousSystemSymptom"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BloodGlucoseMeasurement"></see>
    /// </summary>
    let BloodGlucoseMeasurement = _prefix "BloodGlucoseMeasurement"
    /// <summary>
    /// A finding or categorization surmised from recorded measurements.
    /// <see href="http://purl.org/twc/dpo/ont/TestFinding"></see></summary>
    let TestFinding = _prefix "TestFinding"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BlurredVision"></see>
    /// </summary>
    let BlurredVision = _prefix "BlurredVision"
    /// <summary>
    /// A symptom involving visual impairment.
    /// <see href="http://purl.org/twc/dpo/ont/VisionSymptom"></see></summary>
    let VisionSymptom = _prefix "VisionSymptom"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BodyMassIndexFinding"></see>
    /// </summary>
    let BodyMassIndexFinding = _prefix "BodyMassIndexFinding"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BorderlineHighLDLLevel"></see>
    /// </summary>
    let BorderlineHighLDLLevel = _prefix "BorderlineHighLDLLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/CholesterolMeasurement"></see>
    /// </summary>
    let CholesterolMeasurement = _prefix "CholesterolMeasurement"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BorderlineHighLDLRange"></see>
    /// </summary>
    let BorderlineHighLDLRange = _prefix "BorderlineHighLDLRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideLevel"></see>
    /// </summary>
    let BorderlineHighTriglycerideLevel = _prefix "BorderlineHighTriglycerideLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/TriglycerideMeasurement"></see>
    /// </summary>
    let TriglycerideMeasurement = _prefix "TriglycerideMeasurement"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideRange"></see>
    /// </summary>
    let BorderlineHighTriglycerideRange = _prefix "BorderlineHighTriglycerideRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Canagliflozin"></see>
    /// </summary>
    let Canagliflozin = _prefix "Canagliflozin"
    /// <summary>
    /// Potential to reduce the risk of cardiovascular disease resulting from atherosclerosis.
    /// <see href="http://purl.org/twc/dpo/ont/PotentialASCVDBenefit"></see></summary>
    let PotentialASCVDBenefit = _prefix "PotentialASCVDBenefit"
    /// <summary>
    /// Potential to decrease the risk of heart failure.
    /// <see href="http://purl.org/twc/dpo/ont/PotentialHeartFailureBenefit"></see></summary>
    let PotentialHeartFailureBenefit = _prefix "PotentialHeartFailureBenefit"
    /// <summary>
    /// Potential to decrease the risk or progression of diabetic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/PotentialDKDBenefit"></see></summary>
    let PotentialDKDBenefit = _prefix "PotentialDKDBenefit"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/SGLT2Inhibitor"></see>
    /// </summary>
    let SGLT2Inhibitor = _prefix "SGLT2Inhibitor"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/CardiovascularDisease"></see>
    /// </summary>
    let CardiovascularDisease = _prefix "CardiovascularDisease"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Disease"></see>
    /// </summary>
    let Disease = _prefix "Disease"
    /// <summary>
    /// A circumstance influencing the treatment of a disease through the use or recommendation of one or more drugs.
    /// <see href="http://purl.org/twc/dpo/ont/PharmacotherapyFactor"></see></summary>
    let PharmacotherapyFactor = _prefix "PharmacotherapyFactor"
    /// <summary>
    /// A stroke.
    /// <see href="http://purl.org/twc/dpo/ont/CerebralVascularAccident"></see></summary>
    let CerebralVascularAccident = _prefix "CerebralVascularAccident"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/ChestPain"></see>
    /// </summary>
    let ChestPain = _prefix "ChestPain"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Pain"></see>
    /// </summary>
    let Pain = _prefix "Pain"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Condition"></see>
    /// </summary>
    let Condition = _prefix "Condition"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/CoronaryArteryDisease"></see>
    /// </summary>
    let CoronaryArteryDisease = _prefix "CoronaryArteryDisease"
    /// <summary>
    /// The expense associated with a therapy.
    /// <see href="http://purl.org/twc/dpo/ont/Cost"></see></summary>
    let Cost = _prefix "Cost"
    /// <summary>
    /// No known association with the lowering of blood sugar below the normal range.
    /// <see href="http://purl.org/twc/dpo/ont/NoKnownHypoglycemiaRisk"></see></summary>
    let NoKnownHypoglycemiaRisk = _prefix "NoKnownHypoglycemiaRisk"
    /// <summary>
    /// An intermediate capacity to bring about a desired effect.
    /// <see href="http://purl.org/twc/dpo/ont/IntermediateEfficacy"></see></summary>
    let IntermediateEfficacy = _prefix "IntermediateEfficacy"
    /// <summary>
    /// Relatively expensive.
    /// <see href="http://purl.org/twc/dpo/ont/HighCost"></see></summary>
    let HighCost = _prefix "HighCost"
    /// <summary>
    /// Minimal effect on reducing or increasing the risk or progression of diabetic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/NeutralDKDRisk"></see></summary>
    let NeutralDKDRisk = _prefix "NeutralDKDRisk"
    /// <summary>
    /// Minimal effect on reducing or increasing the risk of cardiovascular disease resulting from atherosclerosis.
    /// <see href="http://purl.org/twc/dpo/ont/NeutralASCVDRisk"></see></summary>
    let NeutralASCVDRisk = _prefix "NeutralASCVDRisk"
    /// <summary>
    /// The lack of an effect on the capacity for an increase or decrease in the weight of an individual.
    /// <see href="http://purl.org/twc/dpo/ont/NeutralWeightChange"></see></summary>
    let NeutralWeightChange = _prefix "NeutralWeightChange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Dapagliflozin"></see>
    /// </summary>
    let Dapagliflozin = _prefix "Dapagliflozin"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseLevel"></see>
    /// </summary>
    let DiabetesFastingBloodGlucoseLevel = _prefix "DiabetesFastingBloodGlucoseLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseRange"></see>
    /// </summary>
    let DiabetesFastingBloodGlucoseRange = _prefix "DiabetesFastingBloodGlucoseRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesHbA1CLevel"></see>
    /// </summary>
    let DiabetesHbA1CLevel = _prefix "DiabetesHbA1CLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesHbA1CRange"></see>
    /// </summary>
    let DiabetesHbA1CRange = _prefix "DiabetesHbA1CRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesMellitus"></see>
    /// </summary>
    let DiabetesMellitus = _prefix "DiabetesMellitus"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseLevel"></see>
    /// </summary>
    let DiabetesTwoHourBloodGlucoseLevel = _prefix "DiabetesTwoHourBloodGlucoseLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseRange"></see>
    /// </summary>
    let DiabetesTwoHourBloodGlucoseRange = _prefix "DiabetesTwoHourBloodGlucoseRange"
    /// <summary>
    /// The progression of diabetic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/DiabeticKidneyDiseaseProgression"></see></summary>
    let DiabeticKidneyDiseaseProgression = _prefix "DiabeticKidneyDiseaseProgression"
    /// <summary>
    /// A pharmacotherapy factor related to the kidneys.
    /// <see href="http://purl.org/twc/dpo/ont/RenalEffect"></see></summary>
    let RenalEffect = _prefix "RenalEffect"
    /// <summary>
    /// A circumstance influencing the dianosis of a disease.
    /// <see href="http://purl.org/twc/dpo/ont/DiagnosticFactor"></see></summary>
    let DiagnosticFactor = _prefix "DiagnosticFactor"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/TherapyPlanningComponent"></see>
    /// </summary>
    let TherapyPlanningComponent = _prefix "TherapyPlanningComponent"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DrugUse"></see>
    /// </summary>
    let DrugUse = _prefix "DrugUse"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Dulaglutide"></see>
    /// </summary>
    let Dulaglutide = _prefix "Dulaglutide"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/GLP1RA"></see>
    /// </summary>
    let GLP1RA = _prefix "GLP1RA"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Dysuria"></see>
    /// </summary>
    let Dysuria = _prefix "Dysuria"
    /// <summary>
    /// A symptom involving the urinary system.
    /// <see href="http://purl.org/twc/dpo/ont/UrinarySystemSymptom"></see></summary>
    let UrinarySystemSymptom = _prefix "UrinarySystemSymptom"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Efficacy"></see>
    /// </summary>
    let Efficacy = _prefix "Efficacy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Empagliflozin"></see>
    /// </summary>
    let Empagliflozin = _prefix "Empagliflozin"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Ertugliflozin"></see>
    /// </summary>
    let Ertugliflozin = _prefix "Ertugliflozin"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Exenatide"></see>
    /// </summary>
    let Exenatide = _prefix "Exenatide"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FamilyHistory"></see>
    /// </summary>
    let FamilyHistory = _prefix "FamilyHistory"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/History"></see>
    /// </summary>
    let History = _prefix "History"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FamilyHistoryOfCAD"></see>
    /// </summary>
    let FamilyHistoryOfCAD = _prefix "FamilyHistoryOfCAD"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FamilyHistoryOfDiabetes"></see>
    /// </summary>
    let FamilyHistoryOfDiabetes = _prefix "FamilyHistoryOfDiabetes"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Fatigue"></see>
    /// </summary>
    let Fatigue = _prefix "Fatigue"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NeurologicalAndPhysiologicalSymptom"></see>
    /// </summary>
    let NeurologicalAndPhysiologicalSymptom =
        _prefix "NeurologicalAndPhysiologicalSymptom"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FoulUrine"></see>
    /// </summary>
    let FoulUrine = _prefix "FoulUrine"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FrequentUrination"></see>
    /// </summary>
    let FrequentUrination = _prefix "FrequentUrination"
    /// <summary>
    /// A high capacity to bring about a desired effect.
    /// <see href="http://purl.org/twc/dpo/ont/HighEfficacy"></see></summary>
    let HighEfficacy = _prefix "HighEfficacy"
    /// <summary>
    /// Minimal effect on reducing or increasing the risk of heart failure.
    /// <see href="http://purl.org/twc/dpo/ont/NeutralHeartFailureRisk"></see></summary>
    let NeutralHeartFailureRisk = _prefix "NeutralHeartFailureRisk"
    /// <summary>
    /// The capacity for a decrease in the weight of an individual.
    /// <see href="http://purl.org/twc/dpo/ont/WeightLossPotential"></see></summary>
    let WeightLossPotential = _prefix "WeightLossPotential"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Glimepiride"></see>
    /// </summary>
    let Glimepiride = _prefix "Glimepiride"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Sulfonylurea"></see>
    /// </summary>
    let Sulfonylurea = _prefix "Sulfonylurea"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Glipizide"></see>
    /// </summary>
    let Glipizide = _prefix "Glipizide"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Glyburide"></see>
    /// </summary>
    let Glyburide = _prefix "Glyburide"
    /// <summary>
    /// Risk of heart failure.
    /// <see href="http://purl.org/twc/dpo/ont/HeartFailureRisk"></see></summary>
    let HeartFailureRisk = _prefix "HeartFailureRisk"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighLDLLevel"></see>
    /// </summary>
    let HighLDLLevel = _prefix "HighLDLLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighLDLRange"></see>
    /// </summary>
    let HighLDLRange = _prefix "HighLDLRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighSugarDiet"></see>
    /// </summary>
    let HighSugarDiet = _prefix "HighSugarDiet"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/SedentaryLifestyle"></see>
    /// </summary>
    let SedentaryLifestyle = _prefix "SedentaryLifestyle"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighTriglycerideLevel"></see>
    /// </summary>
    let HighTriglycerideLevel = _prefix "HighTriglycerideLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighTriglycerideRange"></see>
    /// </summary>
    let HighTriglycerideRange = _prefix "HighTriglycerideRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Hyperlipidemia"></see>
    /// </summary>
    let Hyperlipidemia = _prefix "Hyperlipidemia"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Hypertension"></see>
    /// </summary>
    let Hypertension = _prefix "Hypertension"
    /// <summary>
    /// The possiblility of lowering blood sugar below the normal range.
    /// <see href="http://purl.org/twc/dpo/ont/HypoglycemiaRisk"></see></summary>
    let HypoglycemiaRisk = _prefix "HypoglycemiaRisk"
    /// <summary>
    /// Potential to increase the risk of cardiovascular disease resulting from atherosclerosis.
    /// <see href="http://purl.org/twc/dpo/ont/IncreasedASCVDRisk"></see></summary>
    let IncreasedASCVDRisk = _prefix "IncreasedASCVDRisk"
    /// <summary>
    /// Potential to increase the risk or progression of diabetic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/IncreasedDKDRisk"></see></summary>
    let IncreasedDKDRisk = _prefix "IncreasedDKDRisk"
    /// <summary>
    /// Potential to increase the risk of heart failure.
    /// <see href="http://purl.org/twc/dpo/ont/IncreasedHeartFailureRisk"></see></summary>
    let IncreasedHeartFailureRisk = _prefix "IncreasedHeartFailureRisk"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/InsufficientExercise"></see>
    /// </summary>
    let InsufficientExercise = _prefix "InsufficientExercise"
    /// <summary>
    /// A known association with the lowering of blood sugar below the normal range.
    /// <see href="http://purl.org/twc/dpo/ont/KnownHypoglycemiaRisk"></see></summary>
    let KnownHypoglycemiaRisk = _prefix "KnownHypoglycemiaRisk"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Linagliptin"></see>
    /// </summary>
    let Linagliptin = _prefix "Linagliptin"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Liraglutide"></see>
    /// </summary>
    let Liraglutide = _prefix "Liraglutide"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Lixisenatide"></see>
    /// </summary>
    let Lixisenatide = _prefix "Lixisenatide"
    /// <summary>
    /// Relatively inexpensive.
    /// <see href="http://purl.org/twc/dpo/ont/LowCost"></see></summary>
    let LowCost = _prefix "LowCost"
    /// <summary>
    /// A low capacity to bring about a desired effect.
    /// <see href="http://purl.org/twc/dpo/ont/LowEfficacy"></see></summary>
    let LowEfficacy = _prefix "LowEfficacy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Metformin"></see>
    /// </summary>
    let Metformin = _prefix "Metformin"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Symptom"></see>
    /// </summary>
    let Symptom = _prefix "Symptom"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NearOptimalLDLLevel"></see>
    /// </summary>
    let NearOptimalLDLLevel = _prefix "NearOptimalLDLLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NearOptimalLDLRange"></see>
    /// </summary>
    let NearOptimalLDLRange = _prefix "NearOptimalLDLRange"
    /// <summary>
    /// The capacity for an increase or decrease in the weight of an individual.
    /// <see href="http://purl.org/twc/dpo/ont/WeightChangePotential"></see></summary>
    let WeightChangePotential = _prefix "WeightChangePotential"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NormalTriglycerideLevel"></see>
    /// </summary>
    let NormalTriglycerideLevel = _prefix "NormalTriglycerideLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NormalTriglycerideRange"></see>
    /// </summary>
    let NormalTriglycerideRange = _prefix "NormalTriglycerideRange"
    /// <summary>
    /// 18.5&lt;BMI&lt;24.9
    /// <see href="http://purl.org/twc/dpo/ont/NormalWeight"></see></summary>
    let NormalWeight = _prefix "NormalWeight"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NormalWeightBMIRange"></see>
    /// </summary>
    let NormalWeightBMIRange = _prefix "NormalWeightBMIRange"

    /// <summary>
    /// A symptom involving the nutrition, metabolism, and/or development system.
    /// <see href="http://purl.org/twc/dpo/ont/NutritionMetabolismAndDevelopmentSymptom"></see></summary>
    let NutritionMetabolismAndDevelopmentSymptom =
        _prefix "NutritionMetabolismAndDevelopmentSymptom"

    /// <summary>
    /// 30&lt;BMI
    /// <see href="http://purl.org/twc/dpo/ont/Obese"></see></summary>
    let Obese = _prefix "Obese"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/ObeseBMIRange"></see>
    /// </summary>
    let ObeseBMIRange = _prefix "ObeseBMIRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Occupation"></see>
    /// </summary>
    let Occupation = _prefix "Occupation"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/OptimalLDLLevel"></see>
    /// </summary>
    let OptimalLDLLevel = _prefix "OptimalLDLLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/OptimalLDLRange"></see>
    /// </summary>
    let OptimalLDLRange = _prefix "OptimalLDLRange"
    /// <summary>
    /// 25&lt;BMI&lt;30
    /// <see href="http://purl.org/twc/dpo/ont/Overweight"></see></summary>
    let Overweight = _prefix "Overweight"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/OverweightBMIRange"></see>
    /// </summary>
    let OverweightBMIRange = _prefix "OverweightBMIRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PeripheralNeuropathy"></see>
    /// </summary>
    let PeripheralNeuropathy = _prefix "PeripheralNeuropathy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PersonalHistory"></see>
    /// </summary>
    let PersonalHistory = _prefix "PersonalHistory"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PersonalHistoryOfFebrileStates"></see>
    /// </summary>
    let PersonalHistoryOfFebrileStates = _prefix "PersonalHistoryOfFebrileStates"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PersonalHistoryOfGestationalDiabetes"></see>
    /// </summary>
    let PersonalHistoryOfGestationalDiabetes =
        _prefix "PersonalHistoryOfGestationalDiabetes"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Pioglitazone"></see>
    /// </summary>
    let Pioglitazone = _prefix "Pioglitazone"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Thiazolidinedione"></see>
    /// </summary>
    let Thiazolidinedione = _prefix "Thiazolidinedione"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Polydipsia"></see>
    /// </summary>
    let Polydipsia = _prefix "Polydipsia"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Polyphagia"></see>
    /// </summary>
    let Polyphagia = _prefix "Polyphagia"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Polyuria"></see>
    /// </summary>
    let Polyuria = _prefix "Polyuria"

    /// <summary>
    ///  impaired fasting glucose
    /// <see href="http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseLevel"></see></summary>
    let PrediabetesFastingBloodGlucoseLevel =
        _prefix "PrediabetesFastingBloodGlucoseLevel"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseRange"></see>
    /// </summary>
    let PrediabetesFastingBloodGlucoseRange =
        _prefix "PrediabetesFastingBloodGlucoseRange"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PrediabetesHbA1CLevel"></see>
    /// </summary>
    let PrediabetesHbA1CLevel = _prefix "PrediabetesHbA1CLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PrediabetesHbA1CRange"></see>
    /// </summary>
    let PrediabetesHbA1CRange = _prefix "PrediabetesHbA1CRange"

    /// <summary>
    /// impaired glucose tolerance
    /// <see href="http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseLevel"></see></summary>
    let PrediabetesTwoHourBloodGlucoseLevel =
        _prefix "PrediabetesTwoHourBloodGlucoseLevel"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseRange"></see>
    /// </summary>
    let PrediabetesTwoHourBloodGlucoseRange =
        _prefix "PrediabetesTwoHourBloodGlucoseRange"

    /// <summary>
    /// Disease associated with kidneys, typically chronic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/RenalDisease"></see></summary>
    let RenalDisease = _prefix "RenalDisease"
    /// <summary>
    /// Drug dosage considerations related to the effect on the kidneys.
    /// <see href="http://purl.org/twc/dpo/ont/RenalDosingConsideration"></see></summary>
    let RenalDosingConsideration = _prefix "RenalDosingConsideration"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Rosiglitazone"></see>
    /// </summary>
    let Rosiglitazone = _prefix "Rosiglitazone"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Saxagliptin"></see>
    /// </summary>
    let Saxagliptin = _prefix "Saxagliptin"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/SedentaryOccupation"></see>
    /// </summary>
    let SedentaryOccupation = _prefix "SedentaryOccupation"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Semaglutide"></see>
    /// </summary>
    let Semaglutide = _prefix "Semaglutide"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Sitagliptin"></see>
    /// </summary>
    let Sitagliptin = _prefix "Sitagliptin"
    /// <summary>
    /// The capacity for an increase in the weight of an individual.
    /// <see href="http://purl.org/twc/dpo/ont/WeightGainPotential"></see></summary>
    let WeightGainPotential = _prefix "WeightGainPotential"
    /// <summary>
    /// BMI&lt;18.5
    /// <see href="http://purl.org/twc/dpo/ont/Underweight"></see></summary>
    let Underweight = _prefix "Underweight"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/UnderweightBMIRange"></see>
    /// </summary>
    let UnderweightBMIRange = _prefix "UnderweightBMIRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/UrinaryTractInfection"></see>
    /// </summary>
    let UrinaryTractInfection = _prefix "UrinaryTractInfection"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighHbA1CLevel"></see>
    /// </summary>
    let VeryHighHbA1CLevel = _prefix "VeryHighHbA1CLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighHbA1CRange"></see>
    /// </summary>
    let VeryHighHbA1CRange = _prefix "VeryHighHbA1CRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighLDLLevel"></see>
    /// </summary>
    let VeryHighLDLLevel = _prefix "VeryHighLDLLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighLDLRange"></see>
    /// </summary>
    let VeryHighLDLRange = _prefix "VeryHighLDLRange"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighTriglycerideLevel"></see>
    /// </summary>
    let VeryHighTriglycerideLevel = _prefix "VeryHighTriglycerideLevel"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighTriglycerideRange"></see>
    /// </summary>
    let VeryHighTriglycerideRange = _prefix "VeryHighTriglycerideRange"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/diabetes_pharmacology_ontology.ttl"></see>
    /// </summary>
    let ``diabetes_pharmacology_ontology.ttl`` =
        _prefix "diabetes_pharmacology_ontology.ttl"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/1.0"></see>
    /// </summary>
    let ``_1.0`` = _prefix "1.0"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/hasDiagnosis"></see>
    /// </summary>
    let hasDiagnosis = _prefix "hasDiagnosis"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/hasTherapy"></see>
    /// </summary>
    let hasTherapy = _prefix "hasTherapy"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/hasTreatmentAversion"></see>
    /// </summary>
    let hasTreatmentAversion = _prefix "hasTreatmentAversion"
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/hasTreatmentPreference"></see>
    /// </summary>
    let hasTreatmentPreference = _prefix "hasTreatmentPreference"
