namespace http.purl.org.twc.dpo.ont.slash

open DoxAletheia.Rdf_Vocabulary

module dpo =
    let _namespace_name = "http://purl.org/twc/dpo/ont/"

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/ExternalClass"></see>
    /// </summary>
    let ExternalClass =
        Namespaced_IRI.parse _namespace_name "ExternalClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighCostDiabetesTherapy"></see>
    /// </summary>
    let HighCostDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "HighCostDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighEfficacyDiabetesTherapy"></see>
    /// </summary>
    let HighEfficacyDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "HighEfficacyDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/IncreasedDKDRiskDiabetesTherapy"></see>
    /// </summary>
    let IncreasedDKDRiskDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "IncreasedDKDRiskDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/LowCostDiabetesTherapy"></see>
    /// </summary>
    let LowCostDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "LowCostDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/LowEfficacyDiabetesTherapy"></see>
    /// </summary>
    let LowEfficacyDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "LowEfficacyDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PotentialASCVDBenefitDiabetesTherapy"></see>
    /// </summary>
    let PotentialASCVDBenefitDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "PotentialASCVDBenefitDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PotentialDKDBenefitDiabetesTherapy"></see>
    /// </summary>
    let PotentialDKDBenefitDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "PotentialDKDBenefitDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/WeightGainDiabetesTherapy"></see>
    /// </summary>
    let WeightGainDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "WeightGainDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/WeightLossDiabetesTherapy"></see>
    /// </summary>
    let WeightLossDiabetesTherapy =
        Namespaced_IRI.parse _namespace_name "WeightLossDiabetesTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/AlcoholUse"></see>
    /// </summary>
    let AlcoholUse = Namespaced_IRI.parse _namespace_name "AlcoholUse" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Behavior"></see>
    /// </summary>
    let Behavior = Namespaced_IRI.parse _namespace_name "Behavior" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Alogliptin"></see>
    /// </summary>
    let Alogliptin = Namespaced_IRI.parse _namespace_name "Alogliptin" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DPP4Inhibitor"></see>
    /// </summary>
    let DPP4Inhibitor =
        Namespaced_IRI.parse _namespace_name "DPP4Inhibitor" |> NamespacedName

    /// <summary>
    /// Treatment designed to lower blood sugar levels.
    /// <see href="http://purl.org/twc/dpo/ont/AntihyperglycemicTreatment"></see></summary>
    let AntihyperglycemicTreatment =
        Namespaced_IRI.parse _namespace_name "AntihyperglycemicTreatment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Therapy"></see>
    /// </summary>
    let Therapy = Namespaced_IRI.parse _namespace_name "Therapy" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Arthritis"></see>
    /// </summary>
    let Arthritis = Namespaced_IRI.parse _namespace_name "Arthritis" |> NamespacedName

    /// <summary>
    /// A symptom involving the musculoskeletal system.
    /// <see href="http://purl.org/twc/dpo/ont/MusculoskeletalSystemSymptom"></see></summary>
    let MusculoskeletalSystemSymptom =
        Namespaced_IRI.parse _namespace_name "MusculoskeletalSystemSymptom" |> NamespacedName

    /// <summary>
    /// Risk of cardiovascular disease resulting from atherosclerosis.
    /// <see href="http://purl.org/twc/dpo/ont/AtheroscleroticCardiovascularDiseaseRisk"></see></summary>
    let AtheroscleroticCardiovascularDiseaseRisk =
        Namespaced_IRI.parse _namespace_name "AtheroscleroticCardiovascularDiseaseRisk" |> NamespacedName

    /// <summary>
    /// A pharmacotherapy factor related to the heart or blood vessels.
    /// <see href="http://purl.org/twc/dpo/ont/CardiovascularEffect"></see></summary>
    let CardiovascularEffect =
        Namespaced_IRI.parse _namespace_name "CardiovascularEffect" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PatientCharacteristic"></see>
    /// </summary>
    let PatientCharacteristic =
        Namespaced_IRI.parse _namespace_name "PatientCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Biguanide"></see>
    /// </summary>
    let Biguanide = Namespaced_IRI.parse _namespace_name "Biguanide" |> NamespacedName

    /// <summary>
    /// Occasional Burning Sensation in Bilateral Lower Extremities
    /// <see href="http://purl.org/twc/dpo/ont/BilateralLowerExtremityBurningSensation"></see></summary>
    let BilateralLowerExtremityBurningSensation =
        Namespaced_IRI.parse _namespace_name "BilateralLowerExtremityBurningSensation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NervousSystemSymptom"></see>
    /// </summary>
    let NervousSystemSymptom =
        Namespaced_IRI.parse _namespace_name "NervousSystemSymptom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BloodGlucoseMeasurement"></see>
    /// </summary>
    let BloodGlucoseMeasurement =
        Namespaced_IRI.parse _namespace_name "BloodGlucoseMeasurement" |> NamespacedName

    /// <summary>
    /// A finding or categorization surmised from recorded measurements.
    /// <see href="http://purl.org/twc/dpo/ont/TestFinding"></see></summary>
    let TestFinding =
        Namespaced_IRI.parse _namespace_name "TestFinding" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BlurredVision"></see>
    /// </summary>
    let BlurredVision =
        Namespaced_IRI.parse _namespace_name "BlurredVision" |> NamespacedName

    /// <summary>
    /// A symptom involving visual impairment.
    /// <see href="http://purl.org/twc/dpo/ont/VisionSymptom"></see></summary>
    let VisionSymptom =
        Namespaced_IRI.parse _namespace_name "VisionSymptom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BodyMassIndexFinding"></see>
    /// </summary>
    let BodyMassIndexFinding =
        Namespaced_IRI.parse _namespace_name "BodyMassIndexFinding" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BorderlineHighLDLLevel"></see>
    /// </summary>
    let BorderlineHighLDLLevel =
        Namespaced_IRI.parse _namespace_name "BorderlineHighLDLLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/CholesterolMeasurement"></see>
    /// </summary>
    let CholesterolMeasurement =
        Namespaced_IRI.parse _namespace_name "CholesterolMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BorderlineHighLDLRange"></see>
    /// </summary>
    let BorderlineHighLDLRange =
        Namespaced_IRI.parse _namespace_name "BorderlineHighLDLRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideLevel"></see>
    /// </summary>
    let BorderlineHighTriglycerideLevel =
        Namespaced_IRI.parse _namespace_name "BorderlineHighTriglycerideLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/TriglycerideMeasurement"></see>
    /// </summary>
    let TriglycerideMeasurement =
        Namespaced_IRI.parse _namespace_name "TriglycerideMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideRange"></see>
    /// </summary>
    let BorderlineHighTriglycerideRange =
        Namespaced_IRI.parse _namespace_name "BorderlineHighTriglycerideRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Canagliflozin"></see>
    /// </summary>
    let Canagliflozin =
        Namespaced_IRI.parse _namespace_name "Canagliflozin" |> NamespacedName

    /// <summary>
    /// Potential to reduce the risk of cardiovascular disease resulting from atherosclerosis.
    /// <see href="http://purl.org/twc/dpo/ont/PotentialASCVDBenefit"></see></summary>
    let PotentialASCVDBenefit =
        Namespaced_IRI.parse _namespace_name "PotentialASCVDBenefit" |> NamespacedName

    /// <summary>
    /// Potential to decrease the risk of heart failure.
    /// <see href="http://purl.org/twc/dpo/ont/PotentialHeartFailureBenefit"></see></summary>
    let PotentialHeartFailureBenefit =
        Namespaced_IRI.parse _namespace_name "PotentialHeartFailureBenefit" |> NamespacedName

    /// <summary>
    /// Potential to decrease the risk or progression of diabetic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/PotentialDKDBenefit"></see></summary>
    let PotentialDKDBenefit =
        Namespaced_IRI.parse _namespace_name "PotentialDKDBenefit" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/SGLT2Inhibitor"></see>
    /// </summary>
    let SGLT2Inhibitor =
        Namespaced_IRI.parse _namespace_name "SGLT2Inhibitor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/CardiovascularDisease"></see>
    /// </summary>
    let CardiovascularDisease =
        Namespaced_IRI.parse _namespace_name "CardiovascularDisease" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Disease"></see>
    /// </summary>
    let Disease = Namespaced_IRI.parse _namespace_name "Disease" |> NamespacedName

    /// <summary>
    /// A circumstance influencing the treatment of a disease through the use or recommendation of one or more drugs.
    /// <see href="http://purl.org/twc/dpo/ont/PharmacotherapyFactor"></see></summary>
    let PharmacotherapyFactor =
        Namespaced_IRI.parse _namespace_name "PharmacotherapyFactor" |> NamespacedName

    /// <summary>
    /// A stroke.
    /// <see href="http://purl.org/twc/dpo/ont/CerebralVascularAccident"></see></summary>
    let CerebralVascularAccident =
        Namespaced_IRI.parse _namespace_name "CerebralVascularAccident" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/ChestPain"></see>
    /// </summary>
    let ChestPain = Namespaced_IRI.parse _namespace_name "ChestPain" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Pain"></see>
    /// </summary>
    let Pain = Namespaced_IRI.parse _namespace_name "Pain" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Condition"></see>
    /// </summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/CoronaryArteryDisease"></see>
    /// </summary>
    let CoronaryArteryDisease =
        Namespaced_IRI.parse _namespace_name "CoronaryArteryDisease" |> NamespacedName

    /// <summary>
    /// The expense associated with a therapy.
    /// <see href="http://purl.org/twc/dpo/ont/Cost"></see></summary>
    let Cost = Namespaced_IRI.parse _namespace_name "Cost" |> NamespacedName

    /// <summary>
    /// No known association with the lowering of blood sugar below the normal range.
    /// <see href="http://purl.org/twc/dpo/ont/NoKnownHypoglycemiaRisk"></see></summary>
    let NoKnownHypoglycemiaRisk =
        Namespaced_IRI.parse _namespace_name "NoKnownHypoglycemiaRisk" |> NamespacedName

    /// <summary>
    /// An intermediate capacity to bring about a desired effect.
    /// <see href="http://purl.org/twc/dpo/ont/IntermediateEfficacy"></see></summary>
    let IntermediateEfficacy =
        Namespaced_IRI.parse _namespace_name "IntermediateEfficacy" |> NamespacedName

    /// <summary>
    /// Relatively expensive.
    /// <see href="http://purl.org/twc/dpo/ont/HighCost"></see></summary>
    let HighCost = Namespaced_IRI.parse _namespace_name "HighCost" |> NamespacedName

    /// <summary>
    /// Minimal effect on reducing or increasing the risk or progression of diabetic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/NeutralDKDRisk"></see></summary>
    let NeutralDKDRisk =
        Namespaced_IRI.parse _namespace_name "NeutralDKDRisk" |> NamespacedName

    /// <summary>
    /// Minimal effect on reducing or increasing the risk of cardiovascular disease resulting from atherosclerosis.
    /// <see href="http://purl.org/twc/dpo/ont/NeutralASCVDRisk"></see></summary>
    let NeutralASCVDRisk =
        Namespaced_IRI.parse _namespace_name "NeutralASCVDRisk" |> NamespacedName

    /// <summary>
    /// The lack of an effect on the capacity for an increase or decrease in the weight of an individual.
    /// <see href="http://purl.org/twc/dpo/ont/NeutralWeightChange"></see></summary>
    let NeutralWeightChange =
        Namespaced_IRI.parse _namespace_name "NeutralWeightChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Dapagliflozin"></see>
    /// </summary>
    let Dapagliflozin =
        Namespaced_IRI.parse _namespace_name "Dapagliflozin" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseLevel"></see>
    /// </summary>
    let DiabetesFastingBloodGlucoseLevel =
        Namespaced_IRI.parse _namespace_name "DiabetesFastingBloodGlucoseLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseRange"></see>
    /// </summary>
    let DiabetesFastingBloodGlucoseRange =
        Namespaced_IRI.parse _namespace_name "DiabetesFastingBloodGlucoseRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesHbA1CLevel"></see>
    /// </summary>
    let DiabetesHbA1CLevel =
        Namespaced_IRI.parse _namespace_name "DiabetesHbA1CLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesHbA1CRange"></see>
    /// </summary>
    let DiabetesHbA1CRange =
        Namespaced_IRI.parse _namespace_name "DiabetesHbA1CRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesMellitus"></see>
    /// </summary>
    let DiabetesMellitus =
        Namespaced_IRI.parse _namespace_name "DiabetesMellitus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseLevel"></see>
    /// </summary>
    let DiabetesTwoHourBloodGlucoseLevel =
        Namespaced_IRI.parse _namespace_name "DiabetesTwoHourBloodGlucoseLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseRange"></see>
    /// </summary>
    let DiabetesTwoHourBloodGlucoseRange =
        Namespaced_IRI.parse _namespace_name "DiabetesTwoHourBloodGlucoseRange" |> NamespacedName

    /// <summary>
    /// The progression of diabetic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/DiabeticKidneyDiseaseProgression"></see></summary>
    let DiabeticKidneyDiseaseProgression =
        Namespaced_IRI.parse _namespace_name "DiabeticKidneyDiseaseProgression" |> NamespacedName

    /// <summary>
    /// A pharmacotherapy factor related to the kidneys.
    /// <see href="http://purl.org/twc/dpo/ont/RenalEffect"></see></summary>
    let RenalEffect =
        Namespaced_IRI.parse _namespace_name "RenalEffect" |> NamespacedName

    /// <summary>
    /// A circumstance influencing the dianosis of a disease.
    /// <see href="http://purl.org/twc/dpo/ont/DiagnosticFactor"></see></summary>
    let DiagnosticFactor =
        Namespaced_IRI.parse _namespace_name "DiagnosticFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/TherapyPlanningComponent"></see>
    /// </summary>
    let TherapyPlanningComponent =
        Namespaced_IRI.parse _namespace_name "TherapyPlanningComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/DrugUse"></see>
    /// </summary>
    let DrugUse = Namespaced_IRI.parse _namespace_name "DrugUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Dulaglutide"></see>
    /// </summary>
    let Dulaglutide =
        Namespaced_IRI.parse _namespace_name "Dulaglutide" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/GLP1RA"></see>
    /// </summary>
    let GLP1RA = Namespaced_IRI.parse _namespace_name "GLP1RA" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Dysuria"></see>
    /// </summary>
    let Dysuria = Namespaced_IRI.parse _namespace_name "Dysuria" |> NamespacedName

    /// <summary>
    /// A symptom involving the urinary system.
    /// <see href="http://purl.org/twc/dpo/ont/UrinarySystemSymptom"></see></summary>
    let UrinarySystemSymptom =
        Namespaced_IRI.parse _namespace_name "UrinarySystemSymptom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Efficacy"></see>
    /// </summary>
    let Efficacy = Namespaced_IRI.parse _namespace_name "Efficacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Empagliflozin"></see>
    /// </summary>
    let Empagliflozin =
        Namespaced_IRI.parse _namespace_name "Empagliflozin" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Ertugliflozin"></see>
    /// </summary>
    let Ertugliflozin =
        Namespaced_IRI.parse _namespace_name "Ertugliflozin" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Exenatide"></see>
    /// </summary>
    let Exenatide = Namespaced_IRI.parse _namespace_name "Exenatide" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FamilyHistory"></see>
    /// </summary>
    let FamilyHistory =
        Namespaced_IRI.parse _namespace_name "FamilyHistory" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/History"></see>
    /// </summary>
    let History = Namespaced_IRI.parse _namespace_name "History" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FamilyHistoryOfCAD"></see>
    /// </summary>
    let FamilyHistoryOfCAD =
        Namespaced_IRI.parse _namespace_name "FamilyHistoryOfCAD" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FamilyHistoryOfDiabetes"></see>
    /// </summary>
    let FamilyHistoryOfDiabetes =
        Namespaced_IRI.parse _namespace_name "FamilyHistoryOfDiabetes" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Fatigue"></see>
    /// </summary>
    let Fatigue = Namespaced_IRI.parse _namespace_name "Fatigue" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NeurologicalAndPhysiologicalSymptom"></see>
    /// </summary>
    let NeurologicalAndPhysiologicalSymptom =
        Namespaced_IRI.parse _namespace_name "NeurologicalAndPhysiologicalSymptom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FoulUrine"></see>
    /// </summary>
    let FoulUrine = Namespaced_IRI.parse _namespace_name "FoulUrine" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/FrequentUrination"></see>
    /// </summary>
    let FrequentUrination =
        Namespaced_IRI.parse _namespace_name "FrequentUrination" |> NamespacedName

    /// <summary>
    /// A high capacity to bring about a desired effect.
    /// <see href="http://purl.org/twc/dpo/ont/HighEfficacy"></see></summary>
    let HighEfficacy =
        Namespaced_IRI.parse _namespace_name "HighEfficacy" |> NamespacedName

    /// <summary>
    /// Minimal effect on reducing or increasing the risk of heart failure.
    /// <see href="http://purl.org/twc/dpo/ont/NeutralHeartFailureRisk"></see></summary>
    let NeutralHeartFailureRisk =
        Namespaced_IRI.parse _namespace_name "NeutralHeartFailureRisk" |> NamespacedName

    /// <summary>
    /// The capacity for a decrease in the weight of an individual.
    /// <see href="http://purl.org/twc/dpo/ont/WeightLossPotential"></see></summary>
    let WeightLossPotential =
        Namespaced_IRI.parse _namespace_name "WeightLossPotential" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Glimepiride"></see>
    /// </summary>
    let Glimepiride =
        Namespaced_IRI.parse _namespace_name "Glimepiride" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Sulfonylurea"></see>
    /// </summary>
    let Sulfonylurea =
        Namespaced_IRI.parse _namespace_name "Sulfonylurea" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Glipizide"></see>
    /// </summary>
    let Glipizide = Namespaced_IRI.parse _namespace_name "Glipizide" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Glyburide"></see>
    /// </summary>
    let Glyburide = Namespaced_IRI.parse _namespace_name "Glyburide" |> NamespacedName

    /// <summary>
    /// Risk of heart failure.
    /// <see href="http://purl.org/twc/dpo/ont/HeartFailureRisk"></see></summary>
    let HeartFailureRisk =
        Namespaced_IRI.parse _namespace_name "HeartFailureRisk" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighLDLLevel"></see>
    /// </summary>
    let HighLDLLevel =
        Namespaced_IRI.parse _namespace_name "HighLDLLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighLDLRange"></see>
    /// </summary>
    let HighLDLRange =
        Namespaced_IRI.parse _namespace_name "HighLDLRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighSugarDiet"></see>
    /// </summary>
    let HighSugarDiet =
        Namespaced_IRI.parse _namespace_name "HighSugarDiet" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/SedentaryLifestyle"></see>
    /// </summary>
    let SedentaryLifestyle =
        Namespaced_IRI.parse _namespace_name "SedentaryLifestyle" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighTriglycerideLevel"></see>
    /// </summary>
    let HighTriglycerideLevel =
        Namespaced_IRI.parse _namespace_name "HighTriglycerideLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/HighTriglycerideRange"></see>
    /// </summary>
    let HighTriglycerideRange =
        Namespaced_IRI.parse _namespace_name "HighTriglycerideRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Hyperlipidemia"></see>
    /// </summary>
    let Hyperlipidemia =
        Namespaced_IRI.parse _namespace_name "Hyperlipidemia" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Hypertension"></see>
    /// </summary>
    let Hypertension =
        Namespaced_IRI.parse _namespace_name "Hypertension" |> NamespacedName

    /// <summary>
    /// The possiblility of lowering blood sugar below the normal range.
    /// <see href="http://purl.org/twc/dpo/ont/HypoglycemiaRisk"></see></summary>
    let HypoglycemiaRisk =
        Namespaced_IRI.parse _namespace_name "HypoglycemiaRisk" |> NamespacedName

    /// <summary>
    /// Potential to increase the risk of cardiovascular disease resulting from atherosclerosis.
    /// <see href="http://purl.org/twc/dpo/ont/IncreasedASCVDRisk"></see></summary>
    let IncreasedASCVDRisk =
        Namespaced_IRI.parse _namespace_name "IncreasedASCVDRisk" |> NamespacedName

    /// <summary>
    /// Potential to increase the risk or progression of diabetic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/IncreasedDKDRisk"></see></summary>
    let IncreasedDKDRisk =
        Namespaced_IRI.parse _namespace_name "IncreasedDKDRisk" |> NamespacedName

    /// <summary>
    /// Potential to increase the risk of heart failure.
    /// <see href="http://purl.org/twc/dpo/ont/IncreasedHeartFailureRisk"></see></summary>
    let IncreasedHeartFailureRisk =
        Namespaced_IRI.parse _namespace_name "IncreasedHeartFailureRisk" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/InsufficientExercise"></see>
    /// </summary>
    let InsufficientExercise =
        Namespaced_IRI.parse _namespace_name "InsufficientExercise" |> NamespacedName

    /// <summary>
    /// A known association with the lowering of blood sugar below the normal range.
    /// <see href="http://purl.org/twc/dpo/ont/KnownHypoglycemiaRisk"></see></summary>
    let KnownHypoglycemiaRisk =
        Namespaced_IRI.parse _namespace_name "KnownHypoglycemiaRisk" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Linagliptin"></see>
    /// </summary>
    let Linagliptin =
        Namespaced_IRI.parse _namespace_name "Linagliptin" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Liraglutide"></see>
    /// </summary>
    let Liraglutide =
        Namespaced_IRI.parse _namespace_name "Liraglutide" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Lixisenatide"></see>
    /// </summary>
    let Lixisenatide =
        Namespaced_IRI.parse _namespace_name "Lixisenatide" |> NamespacedName

    /// <summary>
    /// Relatively inexpensive.
    /// <see href="http://purl.org/twc/dpo/ont/LowCost"></see></summary>
    let LowCost = Namespaced_IRI.parse _namespace_name "LowCost" |> NamespacedName

    /// <summary>
    /// A low capacity to bring about a desired effect.
    /// <see href="http://purl.org/twc/dpo/ont/LowEfficacy"></see></summary>
    let LowEfficacy =
        Namespaced_IRI.parse _namespace_name "LowEfficacy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Metformin"></see>
    /// </summary>
    let Metformin = Namespaced_IRI.parse _namespace_name "Metformin" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Symptom"></see>
    /// </summary>
    let Symptom = Namespaced_IRI.parse _namespace_name "Symptom" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NearOptimalLDLLevel"></see>
    /// </summary>
    let NearOptimalLDLLevel =
        Namespaced_IRI.parse _namespace_name "NearOptimalLDLLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NearOptimalLDLRange"></see>
    /// </summary>
    let NearOptimalLDLRange =
        Namespaced_IRI.parse _namespace_name "NearOptimalLDLRange" |> NamespacedName

    /// <summary>
    /// The capacity for an increase or decrease in the weight of an individual.
    /// <see href="http://purl.org/twc/dpo/ont/WeightChangePotential"></see></summary>
    let WeightChangePotential =
        Namespaced_IRI.parse _namespace_name "WeightChangePotential" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NormalTriglycerideLevel"></see>
    /// </summary>
    let NormalTriglycerideLevel =
        Namespaced_IRI.parse _namespace_name "NormalTriglycerideLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NormalTriglycerideRange"></see>
    /// </summary>
    let NormalTriglycerideRange =
        Namespaced_IRI.parse _namespace_name "NormalTriglycerideRange" |> NamespacedName

    /// <summary>
    /// 18.5&lt;BMI&lt;24.9
    /// <see href="http://purl.org/twc/dpo/ont/NormalWeight"></see></summary>
    let NormalWeight =
        Namespaced_IRI.parse _namespace_name "NormalWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/NormalWeightBMIRange"></see>
    /// </summary>
    let NormalWeightBMIRange =
        Namespaced_IRI.parse _namespace_name "NormalWeightBMIRange" |> NamespacedName

    /// <summary>
    /// A symptom involving the nutrition, metabolism, and/or development system.
    /// <see href="http://purl.org/twc/dpo/ont/NutritionMetabolismAndDevelopmentSymptom"></see></summary>
    let NutritionMetabolismAndDevelopmentSymptom =
        Namespaced_IRI.parse _namespace_name "NutritionMetabolismAndDevelopmentSymptom" |> NamespacedName

    /// <summary>
    /// 30&lt;BMI
    /// <see href="http://purl.org/twc/dpo/ont/Obese"></see></summary>
    let Obese = Namespaced_IRI.parse _namespace_name "Obese" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/ObeseBMIRange"></see>
    /// </summary>
    let ObeseBMIRange =
        Namespaced_IRI.parse _namespace_name "ObeseBMIRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Occupation"></see>
    /// </summary>
    let Occupation = Namespaced_IRI.parse _namespace_name "Occupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/OptimalLDLLevel"></see>
    /// </summary>
    let OptimalLDLLevel =
        Namespaced_IRI.parse _namespace_name "OptimalLDLLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/OptimalLDLRange"></see>
    /// </summary>
    let OptimalLDLRange =
        Namespaced_IRI.parse _namespace_name "OptimalLDLRange" |> NamespacedName

    /// <summary>
    /// 25&lt;BMI&lt;30
    /// <see href="http://purl.org/twc/dpo/ont/Overweight"></see></summary>
    let Overweight = Namespaced_IRI.parse _namespace_name "Overweight" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/OverweightBMIRange"></see>
    /// </summary>
    let OverweightBMIRange =
        Namespaced_IRI.parse _namespace_name "OverweightBMIRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PeripheralNeuropathy"></see>
    /// </summary>
    let PeripheralNeuropathy =
        Namespaced_IRI.parse _namespace_name "PeripheralNeuropathy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PersonalHistory"></see>
    /// </summary>
    let PersonalHistory =
        Namespaced_IRI.parse _namespace_name "PersonalHistory" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PersonalHistoryOfFebrileStates"></see>
    /// </summary>
    let PersonalHistoryOfFebrileStates =
        Namespaced_IRI.parse _namespace_name "PersonalHistoryOfFebrileStates" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PersonalHistoryOfGestationalDiabetes"></see>
    /// </summary>
    let PersonalHistoryOfGestationalDiabetes =
        Namespaced_IRI.parse _namespace_name "PersonalHistoryOfGestationalDiabetes" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Pioglitazone"></see>
    /// </summary>
    let Pioglitazone =
        Namespaced_IRI.parse _namespace_name "Pioglitazone" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Thiazolidinedione"></see>
    /// </summary>
    let Thiazolidinedione =
        Namespaced_IRI.parse _namespace_name "Thiazolidinedione" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Polydipsia"></see>
    /// </summary>
    let Polydipsia = Namespaced_IRI.parse _namespace_name "Polydipsia" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Polyphagia"></see>
    /// </summary>
    let Polyphagia = Namespaced_IRI.parse _namespace_name "Polyphagia" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Polyuria"></see>
    /// </summary>
    let Polyuria = Namespaced_IRI.parse _namespace_name "Polyuria" |> NamespacedName

    /// <summary>
    ///  impaired fasting glucose
    /// <see href="http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseLevel"></see></summary>
    let PrediabetesFastingBloodGlucoseLevel =
        Namespaced_IRI.parse _namespace_name "PrediabetesFastingBloodGlucoseLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseRange"></see>
    /// </summary>
    let PrediabetesFastingBloodGlucoseRange =
        Namespaced_IRI.parse _namespace_name "PrediabetesFastingBloodGlucoseRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PrediabetesHbA1CLevel"></see>
    /// </summary>
    let PrediabetesHbA1CLevel =
        Namespaced_IRI.parse _namespace_name "PrediabetesHbA1CLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PrediabetesHbA1CRange"></see>
    /// </summary>
    let PrediabetesHbA1CRange =
        Namespaced_IRI.parse _namespace_name "PrediabetesHbA1CRange" |> NamespacedName

    /// <summary>
    /// impaired glucose tolerance
    /// <see href="http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseLevel"></see></summary>
    let PrediabetesTwoHourBloodGlucoseLevel =
        Namespaced_IRI.parse _namespace_name "PrediabetesTwoHourBloodGlucoseLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseRange"></see>
    /// </summary>
    let PrediabetesTwoHourBloodGlucoseRange =
        Namespaced_IRI.parse _namespace_name "PrediabetesTwoHourBloodGlucoseRange" |> NamespacedName

    /// <summary>
    /// Disease associated with kidneys, typically chronic kidney disease.
    /// <see href="http://purl.org/twc/dpo/ont/RenalDisease"></see></summary>
    let RenalDisease =
        Namespaced_IRI.parse _namespace_name "RenalDisease" |> NamespacedName

    /// <summary>
    /// Drug dosage considerations related to the effect on the kidneys.
    /// <see href="http://purl.org/twc/dpo/ont/RenalDosingConsideration"></see></summary>
    let RenalDosingConsideration =
        Namespaced_IRI.parse _namespace_name "RenalDosingConsideration" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Rosiglitazone"></see>
    /// </summary>
    let Rosiglitazone =
        Namespaced_IRI.parse _namespace_name "Rosiglitazone" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Saxagliptin"></see>
    /// </summary>
    let Saxagliptin =
        Namespaced_IRI.parse _namespace_name "Saxagliptin" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/SedentaryOccupation"></see>
    /// </summary>
    let SedentaryOccupation =
        Namespaced_IRI.parse _namespace_name "SedentaryOccupation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Semaglutide"></see>
    /// </summary>
    let Semaglutide =
        Namespaced_IRI.parse _namespace_name "Semaglutide" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/Sitagliptin"></see>
    /// </summary>
    let Sitagliptin =
        Namespaced_IRI.parse _namespace_name "Sitagliptin" |> NamespacedName

    /// <summary>
    /// The capacity for an increase in the weight of an individual.
    /// <see href="http://purl.org/twc/dpo/ont/WeightGainPotential"></see></summary>
    let WeightGainPotential =
        Namespaced_IRI.parse _namespace_name "WeightGainPotential" |> NamespacedName

    /// <summary>
    /// BMI&lt;18.5
    /// <see href="http://purl.org/twc/dpo/ont/Underweight"></see></summary>
    let Underweight =
        Namespaced_IRI.parse _namespace_name "Underweight" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/UnderweightBMIRange"></see>
    /// </summary>
    let UnderweightBMIRange =
        Namespaced_IRI.parse _namespace_name "UnderweightBMIRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/UrinaryTractInfection"></see>
    /// </summary>
    let UrinaryTractInfection =
        Namespaced_IRI.parse _namespace_name "UrinaryTractInfection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighHbA1CLevel"></see>
    /// </summary>
    let VeryHighHbA1CLevel =
        Namespaced_IRI.parse _namespace_name "VeryHighHbA1CLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighHbA1CRange"></see>
    /// </summary>
    let VeryHighHbA1CRange =
        Namespaced_IRI.parse _namespace_name "VeryHighHbA1CRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighLDLLevel"></see>
    /// </summary>
    let VeryHighLDLLevel =
        Namespaced_IRI.parse _namespace_name "VeryHighLDLLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighLDLRange"></see>
    /// </summary>
    let VeryHighLDLRange =
        Namespaced_IRI.parse _namespace_name "VeryHighLDLRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighTriglycerideLevel"></see>
    /// </summary>
    let VeryHighTriglycerideLevel =
        Namespaced_IRI.parse _namespace_name "VeryHighTriglycerideLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/VeryHighTriglycerideRange"></see>
    /// </summary>
    let VeryHighTriglycerideRange =
        Namespaced_IRI.parse _namespace_name "VeryHighTriglycerideRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/diabetes_pharmacology_ontology.ttl"></see>
    /// </summary>
    let ``diabetes_pharmacology_ontology.ttl`` =
        Namespaced_IRI.parse _namespace_name "diabetes_pharmacology_ontology.ttl" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/1.0"></see>
    /// </summary>
    let ``_1.0`` = Namespaced_IRI.parse _namespace_name "1.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/hasDiagnosis"></see>
    /// </summary>
    let hasDiagnosis =
        Namespaced_IRI.parse _namespace_name "hasDiagnosis" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/hasTherapy"></see>
    /// </summary>
    let hasTherapy = Namespaced_IRI.parse _namespace_name "hasTherapy" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/hasTreatmentAversion"></see>
    /// </summary>
    let hasTreatmentAversion =
        Namespaced_IRI.parse _namespace_name "hasTreatmentAversion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/twc/dpo/ont/hasTreatmentPreference"></see>
    /// </summary>
    let hasTreatmentPreference =
        Namespaced_IRI.parse _namespace_name "hasTreatmentPreference" |> NamespacedName
