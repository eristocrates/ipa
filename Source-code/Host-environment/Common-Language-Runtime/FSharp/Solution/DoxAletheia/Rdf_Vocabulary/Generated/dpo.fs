namespace http.purl.org.twc.dpo.ont.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dpo =
    let _namespace_iri = Namespace_Iri dpo |> NamespaceIRI
    /// <summary>
    ///   <para>dpo:1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/1.0">http://purl.org/twc/dpo/ont/1.0</seealso>
    let ``_1.0`` = Prefixed_Name(dpo, "1.0") |> PrefixedName
    /// <summary>
    ///   <para>dpo:AlcoholUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alcohol Use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/AlcoholUse">http://purl.org/twc/dpo/ont/AlcoholUse</seealso>
    let AlcoholUse = Prefixed_Name(dpo, "AlcoholUse") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Alogliptin</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Alogliptin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Alogliptin">http://purl.org/twc/dpo/ont/Alogliptin</seealso>
    let Alogliptin = Prefixed_Name(dpo, "Alogliptin") |> PrefixedName

    /// <summary>
    ///   <para>dpo:AntihyperglycemicTreatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Treatment designed to lower blood sugar levels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Antihyperglycemic Treatment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/AntihyperglycemicTreatment">http://purl.org/twc/dpo/ont/AntihyperglycemicTreatment</seealso>
    let AntihyperglycemicTreatment =
        Prefixed_Name(dpo, "AntihyperglycemicTreatment") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Arthritis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Arthritis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Arthritis">http://purl.org/twc/dpo/ont/Arthritis</seealso>
    let Arthritis = Prefixed_Name(dpo, "Arthritis") |> PrefixedName

    /// <summary>
    ///   <para>dpo:AtheroscleroticCardiovascularDiseaseRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Risk of cardiovascular disease resulting from atherosclerosis."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Atherosclerotic Cardiovascular Disease Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/AtheroscleroticCardiovascularDiseaseRisk">http://purl.org/twc/dpo/ont/AtheroscleroticCardiovascularDiseaseRisk</seealso>
    let AtheroscleroticCardiovascularDiseaseRisk =
        Prefixed_Name(dpo, "AtheroscleroticCardiovascularDiseaseRisk") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Behavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Behavior"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Behavior">http://purl.org/twc/dpo/ont/Behavior</seealso>
    let Behavior = Prefixed_Name(dpo, "Behavior") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Biguanide</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biguanide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Biguanide">http://purl.org/twc/dpo/ont/Biguanide</seealso>
    let Biguanide = Prefixed_Name(dpo, "Biguanide") |> PrefixedName

    /// <summary>
    ///   <para>dpo:BilateralLowerExtremityBurningSensation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Occasional Burning Sensation in Bilateral Lower Extremities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bilateral Lower Extremity Burning Sensation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/BilateralLowerExtremityBurningSensation">http://purl.org/twc/dpo/ont/BilateralLowerExtremityBurningSensation</seealso>
    let BilateralLowerExtremityBurningSensation =
        Prefixed_Name(dpo, "BilateralLowerExtremityBurningSensation") |> PrefixedName

    /// <summary>
    ///   <para>dpo:BloodGlucoseMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Blood Glucose Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/BloodGlucoseMeasurement">http://purl.org/twc/dpo/ont/BloodGlucoseMeasurement</seealso>
    let BloodGlucoseMeasurement =
        Prefixed_Name(dpo, "BloodGlucoseMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dpo:BlurredVision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Blurred Vision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/BlurredVision">http://purl.org/twc/dpo/ont/BlurredVision</seealso>
    let BlurredVision = Prefixed_Name(dpo, "BlurredVision") |> PrefixedName

    /// <summary>
    ///   <para>dpo:BodyMassIndexFinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Body Mass Index Finding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/BodyMassIndexFinding">http://purl.org/twc/dpo/ont/BodyMassIndexFinding</seealso>
    let BodyMassIndexFinding =
        Prefixed_Name(dpo, "BodyMassIndexFinding") |> PrefixedName

    /// <summary>
    ///   <para>dpo:BorderlineHighLDLLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Borderline High LDL Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/BorderlineHighLDLLevel">http://purl.org/twc/dpo/ont/BorderlineHighLDLLevel</seealso>
    let BorderlineHighLDLLevel =
        Prefixed_Name(dpo, "BorderlineHighLDLLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:BorderlineHighLDLRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Borderline High LDL Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/BorderlineHighLDLRange">http://purl.org/twc/dpo/ont/BorderlineHighLDLRange</seealso>
    let BorderlineHighLDLRange =
        Prefixed_Name(dpo, "BorderlineHighLDLRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:BorderlineHighTriglycerideLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Borderline High Triglyceride Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideLevel">http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideLevel</seealso>
    let BorderlineHighTriglycerideLevel =
        Prefixed_Name(dpo, "BorderlineHighTriglycerideLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:BorderlineHighTriglycerideRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Borderline High Triglyceride Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideRange">http://purl.org/twc/dpo/ont/BorderlineHighTriglycerideRange</seealso>
    let BorderlineHighTriglycerideRange =
        Prefixed_Name(dpo, "BorderlineHighTriglycerideRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Canagliflozin</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:PotentialASCVDBenefit</para>
    ///   <para>dpo:PotentialDKDBenefit</para>
    ///   <para>dpo:PotentialHeartFailureBenefit</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Canagliflozin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Canagliflozin">http://purl.org/twc/dpo/ont/Canagliflozin</seealso>
    let Canagliflozin = Prefixed_Name(dpo, "Canagliflozin") |> PrefixedName

    /// <summary>
    ///   <para>dpo:CardiovascularDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cardiovascular Disease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/CardiovascularDisease">http://purl.org/twc/dpo/ont/CardiovascularDisease</seealso>
    let CardiovascularDisease =
        Prefixed_Name(dpo, "CardiovascularDisease") |> PrefixedName

    /// <summary>
    ///   <para>dpo:CardiovascularEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A pharmacotherapy factor related to the heart or blood vessels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cardiovascular Effect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/CardiovascularEffect">http://purl.org/twc/dpo/ont/CardiovascularEffect</seealso>
    let CardiovascularEffect =
        Prefixed_Name(dpo, "CardiovascularEffect") |> PrefixedName

    /// <summary>
    ///   <para>dpo:CerebralVascularAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A stroke."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cerebral Vascular Accident"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/CerebralVascularAccident">http://purl.org/twc/dpo/ont/CerebralVascularAccident</seealso>
    let CerebralVascularAccident =
        Prefixed_Name(dpo, "CerebralVascularAccident") |> PrefixedName

    /// <summary>
    ///   <para>dpo:ChestPain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chest Pain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/ChestPain">http://purl.org/twc/dpo/ont/ChestPain</seealso>
    let ChestPain = Prefixed_Name(dpo, "ChestPain") |> PrefixedName

    /// <summary>
    ///   <para>dpo:CholesterolMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cholesterol Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/CholesterolMeasurement">http://purl.org/twc/dpo/ont/CholesterolMeasurement</seealso>
    let CholesterolMeasurement =
        Prefixed_Name(dpo, "CholesterolMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Condition">http://purl.org/twc/dpo/ont/Condition</seealso>
    let Condition = Prefixed_Name(dpo, "Condition") |> PrefixedName

    /// <summary>
    ///   <para>dpo:CoronaryArteryDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Coronary Artery Disease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/CoronaryArteryDisease">http://purl.org/twc/dpo/ont/CoronaryArteryDisease</seealso>
    let CoronaryArteryDisease =
        Prefixed_Name(dpo, "CoronaryArteryDisease") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Cost</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The expense associated with a therapy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cost"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Cost">http://purl.org/twc/dpo/ont/Cost</seealso>
    let Cost = Prefixed_Name(dpo, "Cost") |> PrefixedName
    /// <summary>
    ///   <para>dpo:DPP4Inhibitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:NeutralDKDRisk</para>
    ///   <para>dpo:NeutralWeightChange</para>
    ///   <para>dpo:NeutralASCVDRisk</para>
    ///   <para>dpo:NoKnownHypoglycemiaRisk</para>
    ///   <para>dpo:HighCost</para>
    ///   <para>dpo:IntermediateEfficacy</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DPP-4 Inhibitor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DPP4Inhibitor">http://purl.org/twc/dpo/ont/DPP4Inhibitor</seealso>
    let DPP4Inhibitor = Prefixed_Name(dpo, "DPP4Inhibitor") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Dapagliflozin</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:PotentialDKDBenefit</para>
    ///   <para>dpo:PotentialHeartFailureBenefit</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dapagliflozin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Dapagliflozin">http://purl.org/twc/dpo/ont/Dapagliflozin</seealso>
    let Dapagliflozin = Prefixed_Name(dpo, "Dapagliflozin") |> PrefixedName

    /// <summary>
    ///   <para>dpo:DiabetesFastingBloodGlucoseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diabetes Fasting Blood Glucose Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseLevel">http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseLevel</seealso>
    let DiabetesFastingBloodGlucoseLevel =
        Prefixed_Name(dpo, "DiabetesFastingBloodGlucoseLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:DiabetesFastingBloodGlucoseRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Diabetes Fasting Blood Glucose Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseRange">http://purl.org/twc/dpo/ont/DiabetesFastingBloodGlucoseRange</seealso>
    let DiabetesFastingBloodGlucoseRange =
        Prefixed_Name(dpo, "DiabetesFastingBloodGlucoseRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:DiabetesHbA1CLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diabetes HbA1C Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiabetesHbA1CLevel">http://purl.org/twc/dpo/ont/DiabetesHbA1CLevel</seealso>
    let DiabetesHbA1CLevel = Prefixed_Name(dpo, "DiabetesHbA1CLevel") |> PrefixedName
    /// <summary>
    ///   <para>dpo:DiabetesHbA1CRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Diabetes HbA1C Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiabetesHbA1CRange">http://purl.org/twc/dpo/ont/DiabetesHbA1CRange</seealso>
    let DiabetesHbA1CRange = Prefixed_Name(dpo, "DiabetesHbA1CRange") |> PrefixedName
    /// <summary>
    ///   <para>dpo:DiabetesMellitus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diabetes Mellitus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiabetesMellitus">http://purl.org/twc/dpo/ont/DiabetesMellitus</seealso>
    let DiabetesMellitus = Prefixed_Name(dpo, "DiabetesMellitus") |> PrefixedName

    /// <summary>
    ///   <para>dpo:DiabetesTwoHourBloodGlucoseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diabetes Two Hour Blood Glucose Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseLevel">http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseLevel</seealso>
    let DiabetesTwoHourBloodGlucoseLevel =
        Prefixed_Name(dpo, "DiabetesTwoHourBloodGlucoseLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:DiabetesTwoHourBloodGlucoseRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Diabetes Two Hour Blood Glucose Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseRange">http://purl.org/twc/dpo/ont/DiabetesTwoHourBloodGlucoseRange</seealso>
    let DiabetesTwoHourBloodGlucoseRange =
        Prefixed_Name(dpo, "DiabetesTwoHourBloodGlucoseRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:DiabeticKidneyDiseaseProgression</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The progression of diabetic kidney disease."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diabetic Kidney Disease Progression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiabeticKidneyDiseaseProgression">http://purl.org/twc/dpo/ont/DiabeticKidneyDiseaseProgression</seealso>
    let DiabeticKidneyDiseaseProgression =
        Prefixed_Name(dpo, "DiabeticKidneyDiseaseProgression") |> PrefixedName

    /// <summary>
    ///   <para>dpo:DiagnosticFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A circumstance influencing the dianosis of a disease."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diagnostic Factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DiagnosticFactor">http://purl.org/twc/dpo/ont/DiagnosticFactor</seealso>
    let DiagnosticFactor = Prefixed_Name(dpo, "DiagnosticFactor") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Disease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Disease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Disease">http://purl.org/twc/dpo/ont/Disease</seealso>
    let Disease = Prefixed_Name(dpo, "Disease") |> PrefixedName
    /// <summary>
    ///   <para>dpo:DrugUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Drug Use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/DrugUse">http://purl.org/twc/dpo/ont/DrugUse</seealso>
    let DrugUse = Prefixed_Name(dpo, "DrugUse") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Dulaglutide</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:PotentialDKDBenefit</para>
    ///   <para>dpo:PotentialASCVDBenefit</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dulaglutide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Dulaglutide">http://purl.org/twc/dpo/ont/Dulaglutide</seealso>
    let Dulaglutide = Prefixed_Name(dpo, "Dulaglutide") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Dysuria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dysuria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Dysuria">http://purl.org/twc/dpo/ont/Dysuria</seealso>
    let Dysuria = Prefixed_Name(dpo, "Dysuria") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Efficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Efficacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Efficacy">http://purl.org/twc/dpo/ont/Efficacy</seealso>
    let Efficacy = Prefixed_Name(dpo, "Efficacy") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Empagliflozin</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:PotentialHeartFailureBenefit</para>
    ///   <para>dpo:PotentialDKDBenefit</para>
    ///   <para>dpo:PotentialASCVDBenefit</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Empagliflozin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Empagliflozin">http://purl.org/twc/dpo/ont/Empagliflozin</seealso>
    let Empagliflozin = Prefixed_Name(dpo, "Empagliflozin") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Ertugliflozin</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:PotentialHeartFailureBenefit</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ertugliflozin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Ertugliflozin">http://purl.org/twc/dpo/ont/Ertugliflozin</seealso>
    let Ertugliflozin = Prefixed_Name(dpo, "Ertugliflozin") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Exenatide</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:NeutralASCVDRisk</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exenatide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Exenatide">http://purl.org/twc/dpo/ont/Exenatide</seealso>
    let Exenatide = Prefixed_Name(dpo, "Exenatide") |> PrefixedName
    /// <summary>
    ///   <para>dpo:ExternalClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"External Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/ExternalClass">http://purl.org/twc/dpo/ont/ExternalClass</seealso>
    let ExternalClass = Prefixed_Name(dpo, "ExternalClass") |> PrefixedName
    /// <summary>
    ///   <para>dpo:FamilyHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Family History"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/FamilyHistory">http://purl.org/twc/dpo/ont/FamilyHistory</seealso>
    let FamilyHistory = Prefixed_Name(dpo, "FamilyHistory") |> PrefixedName
    /// <summary>
    ///   <para>dpo:FamilyHistoryOfCAD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Family History of Coronary Artery Disease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/FamilyHistoryOfCAD">http://purl.org/twc/dpo/ont/FamilyHistoryOfCAD</seealso>
    let FamilyHistoryOfCAD = Prefixed_Name(dpo, "FamilyHistoryOfCAD") |> PrefixedName

    /// <summary>
    ///   <para>dpo:FamilyHistoryOfDiabetes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Family History of Diabetes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/FamilyHistoryOfDiabetes">http://purl.org/twc/dpo/ont/FamilyHistoryOfDiabetes</seealso>
    let FamilyHistoryOfDiabetes =
        Prefixed_Name(dpo, "FamilyHistoryOfDiabetes") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Fatigue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fatigue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Fatigue">http://purl.org/twc/dpo/ont/Fatigue</seealso>
    let Fatigue = Prefixed_Name(dpo, "Fatigue") |> PrefixedName
    /// <summary>
    ///   <para>dpo:FoulUrine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Foul Urine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/FoulUrine">http://purl.org/twc/dpo/ont/FoulUrine</seealso>
    let FoulUrine = Prefixed_Name(dpo, "FoulUrine") |> PrefixedName
    /// <summary>
    ///   <para>dpo:FrequentUrination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Frequent Urination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/FrequentUrination">http://purl.org/twc/dpo/ont/FrequentUrination</seealso>
    let FrequentUrination = Prefixed_Name(dpo, "FrequentUrination") |> PrefixedName
    /// <summary>
    ///   <para>dpo:GLP1RA</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:HighCost</para>
    ///   <para>dpo:HighEfficacy</para>
    ///   <para>dpo:NeutralHeartFailureRisk</para>
    ///   <para>dpo:WeightLossPotential</para>
    ///   <para>dpo:NoKnownHypoglycemiaRisk</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GLP-1 RA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/GLP1RA">http://purl.org/twc/dpo/ont/GLP1RA</seealso>
    let GLP1RA = Prefixed_Name(dpo, "GLP1RA") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Glimepiride</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glimepiride"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Glimepiride">http://purl.org/twc/dpo/ont/Glimepiride</seealso>
    let Glimepiride = Prefixed_Name(dpo, "Glimepiride") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Glipizide</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glipizide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Glipizide">http://purl.org/twc/dpo/ont/Glipizide</seealso>
    let Glipizide = Prefixed_Name(dpo, "Glipizide") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Glyburide</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Glyburide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Glyburide">http://purl.org/twc/dpo/ont/Glyburide</seealso>
    let Glyburide = Prefixed_Name(dpo, "Glyburide") |> PrefixedName
    /// <summary>
    ///   <para>dpo:HeartFailureRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Risk of heart failure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heart Failure Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HeartFailureRisk">http://purl.org/twc/dpo/ont/HeartFailureRisk</seealso>
    let HeartFailureRisk = Prefixed_Name(dpo, "HeartFailureRisk") |> PrefixedName
    /// <summary>
    ///   <para>dpo:HighCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Relatively expensive."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"High Cost"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighCost">http://purl.org/twc/dpo/ont/HighCost</seealso>
    let HighCost = Prefixed_Name(dpo, "HighCost") |> PrefixedName

    /// <summary>
    ///   <para>dpo:HighCostDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighCostDiabetesTherapy">http://purl.org/twc/dpo/ont/HighCostDiabetesTherapy</seealso>
    let HighCostDiabetesTherapy =
        Prefixed_Name(dpo, "HighCostDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:HighEfficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A high capacity to bring about a desired effect."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"High Efficacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighEfficacy">http://purl.org/twc/dpo/ont/HighEfficacy</seealso>
    let HighEfficacy = Prefixed_Name(dpo, "HighEfficacy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:HighEfficacyDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighEfficacyDiabetesTherapy">http://purl.org/twc/dpo/ont/HighEfficacyDiabetesTherapy</seealso>
    let HighEfficacyDiabetesTherapy =
        Prefixed_Name(dpo, "HighEfficacyDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:HighLDLLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"High LDL Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighLDLLevel">http://purl.org/twc/dpo/ont/HighLDLLevel</seealso>
    let HighLDLLevel = Prefixed_Name(dpo, "HighLDLLevel") |> PrefixedName
    /// <summary>
    ///   <para>dpo:HighLDLRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"High LDL Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighLDLRange">http://purl.org/twc/dpo/ont/HighLDLRange</seealso>
    let HighLDLRange = Prefixed_Name(dpo, "HighLDLRange") |> PrefixedName
    /// <summary>
    ///   <para>dpo:HighSugarDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"High Sugar Diet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighSugarDiet">http://purl.org/twc/dpo/ont/HighSugarDiet</seealso>
    let HighSugarDiet = Prefixed_Name(dpo, "HighSugarDiet") |> PrefixedName

    /// <summary>
    ///   <para>dpo:HighTriglycerideLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"High Triglyceride Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighTriglycerideLevel">http://purl.org/twc/dpo/ont/HighTriglycerideLevel</seealso>
    let HighTriglycerideLevel =
        Prefixed_Name(dpo, "HighTriglycerideLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:HighTriglycerideRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"High Triglyceride Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HighTriglycerideRange">http://purl.org/twc/dpo/ont/HighTriglycerideRange</seealso>
    let HighTriglycerideRange =
        Prefixed_Name(dpo, "HighTriglycerideRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:History</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"History"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/History">http://purl.org/twc/dpo/ont/History</seealso>
    let History = Prefixed_Name(dpo, "History") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Hyperlipidemia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hyperlipidemia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Hyperlipidemia">http://purl.org/twc/dpo/ont/Hyperlipidemia</seealso>
    let Hyperlipidemia = Prefixed_Name(dpo, "Hyperlipidemia") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Hypertension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hypertension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Hypertension">http://purl.org/twc/dpo/ont/Hypertension</seealso>
    let Hypertension = Prefixed_Name(dpo, "Hypertension") |> PrefixedName
    /// <summary>
    ///   <para>dpo:HypoglycemiaRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The possiblility of lowering blood sugar below the normal range."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hypoglycemia Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/HypoglycemiaRisk">http://purl.org/twc/dpo/ont/HypoglycemiaRisk</seealso>
    let HypoglycemiaRisk = Prefixed_Name(dpo, "HypoglycemiaRisk") |> PrefixedName
    /// <summary>
    ///   <para>dpo:IncreasedASCVDRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Potential to increase the risk of cardiovascular disease resulting from atherosclerosis."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Increased ASCVD Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/IncreasedASCVDRisk">http://purl.org/twc/dpo/ont/IncreasedASCVDRisk</seealso>
    let IncreasedASCVDRisk = Prefixed_Name(dpo, "IncreasedASCVDRisk") |> PrefixedName
    /// <summary>
    ///   <para>dpo:IncreasedDKDRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Potential to increase the risk or progression of diabetic kidney disease."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Increased Diabetic Kidney Disease Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/IncreasedDKDRisk">http://purl.org/twc/dpo/ont/IncreasedDKDRisk</seealso>
    let IncreasedDKDRisk = Prefixed_Name(dpo, "IncreasedDKDRisk") |> PrefixedName

    /// <summary>
    ///   <para>dpo:IncreasedDKDRiskDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/IncreasedDKDRiskDiabetesTherapy">http://purl.org/twc/dpo/ont/IncreasedDKDRiskDiabetesTherapy</seealso>
    let IncreasedDKDRiskDiabetesTherapy =
        Prefixed_Name(dpo, "IncreasedDKDRiskDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:IncreasedHeartFailureRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Potential to increase the risk of heart failure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Increased Heart Failure Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/IncreasedHeartFailureRisk">http://purl.org/twc/dpo/ont/IncreasedHeartFailureRisk</seealso>
    let IncreasedHeartFailureRisk =
        Prefixed_Name(dpo, "IncreasedHeartFailureRisk") |> PrefixedName

    /// <summary>
    ///   <para>dpo:InsufficientExercise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Insufficient Exercise"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/InsufficientExercise">http://purl.org/twc/dpo/ont/InsufficientExercise</seealso>
    let InsufficientExercise =
        Prefixed_Name(dpo, "InsufficientExercise") |> PrefixedName

    /// <summary>
    ///   <para>dpo:IntermediateEfficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>"An intermediate capacity to bring about a desired effect."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Intermediate Efficacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/IntermediateEfficacy">http://purl.org/twc/dpo/ont/IntermediateEfficacy</seealso>
    let IntermediateEfficacy =
        Prefixed_Name(dpo, "IntermediateEfficacy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:KnownHypoglycemiaRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A known association with the lowering of blood sugar below the normal range."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Known Hypoglycemia Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/KnownHypoglycemiaRisk">http://purl.org/twc/dpo/ont/KnownHypoglycemiaRisk</seealso>
    let KnownHypoglycemiaRisk =
        Prefixed_Name(dpo, "KnownHypoglycemiaRisk") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Linagliptin</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Linagliptin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Linagliptin">http://purl.org/twc/dpo/ont/Linagliptin</seealso>
    let Linagliptin = Prefixed_Name(dpo, "Linagliptin") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Liraglutide</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:PotentialASCVDBenefit</para>
    ///   <para>dpo:PotentialDKDBenefit</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Liraglutide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Liraglutide">http://purl.org/twc/dpo/ont/Liraglutide</seealso>
    let Liraglutide = Prefixed_Name(dpo, "Liraglutide") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Lixisenatide</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:NeutralASCVDRisk</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lixisenatide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Lixisenatide">http://purl.org/twc/dpo/ont/Lixisenatide</seealso>
    let Lixisenatide = Prefixed_Name(dpo, "Lixisenatide") |> PrefixedName
    /// <summary>
    ///   <para>dpo:LowCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Relatively inexpensive."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Low Cost"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/LowCost">http://purl.org/twc/dpo/ont/LowCost</seealso>
    let LowCost = Prefixed_Name(dpo, "LowCost") |> PrefixedName

    /// <summary>
    ///   <para>dpo:LowCostDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/LowCostDiabetesTherapy">http://purl.org/twc/dpo/ont/LowCostDiabetesTherapy</seealso>
    let LowCostDiabetesTherapy =
        Prefixed_Name(dpo, "LowCostDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:LowEfficacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A low capacity to bring about a desired effect."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Low Efficacy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/LowEfficacy">http://purl.org/twc/dpo/ont/LowEfficacy</seealso>
    let LowEfficacy = Prefixed_Name(dpo, "LowEfficacy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:LowEfficacyDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/LowEfficacyDiabetesTherapy">http://purl.org/twc/dpo/ont/LowEfficacyDiabetesTherapy</seealso>
    let LowEfficacyDiabetesTherapy =
        Prefixed_Name(dpo, "LowEfficacyDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Metformin</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:LowCost</para>
    ///   <para>dpo:NeutralWeightChange</para>
    ///   <para>dpo:NoKnownHypoglycemiaRisk</para>
    ///   <para>dpo:PotentialASCVDBenefit</para>
    ///   <para>dpo:NeutralDKDRisk</para>
    ///   <para>dpo:HighEfficacy</para>
    ///   <para>dpo:NeutralHeartFailureRisk</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metformin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Metformin">http://purl.org/twc/dpo/ont/Metformin</seealso>
    let Metformin = Prefixed_Name(dpo, "Metformin") |> PrefixedName

    /// <summary>
    ///   <para>dpo:MusculoskeletalSystemSymptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A symptom involving the musculoskeletal system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Musculoskeletal System Symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/MusculoskeletalSystemSymptom">http://purl.org/twc/dpo/ont/MusculoskeletalSystemSymptom</seealso>
    let MusculoskeletalSystemSymptom =
        Prefixed_Name(dpo, "MusculoskeletalSystemSymptom") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NearOptimalLDLLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Near Optimal LDL Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NearOptimalLDLLevel">http://purl.org/twc/dpo/ont/NearOptimalLDLLevel</seealso>
    let NearOptimalLDLLevel = Prefixed_Name(dpo, "NearOptimalLDLLevel") |> PrefixedName
    /// <summary>
    ///   <para>dpo:NearOptimalLDLRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Near Optimal LDL Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NearOptimalLDLRange">http://purl.org/twc/dpo/ont/NearOptimalLDLRange</seealso>
    let NearOptimalLDLRange = Prefixed_Name(dpo, "NearOptimalLDLRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NervousSystemSymptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nervous System Symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NervousSystemSymptom">http://purl.org/twc/dpo/ont/NervousSystemSymptom</seealso>
    let NervousSystemSymptom =
        Prefixed_Name(dpo, "NervousSystemSymptom") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NeurologicalAndPhysiologicalSymptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neurological and Physiological Symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NeurologicalAndPhysiologicalSymptom">http://purl.org/twc/dpo/ont/NeurologicalAndPhysiologicalSymptom</seealso>
    let NeurologicalAndPhysiologicalSymptom =
        Prefixed_Name(dpo, "NeurologicalAndPhysiologicalSymptom") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NeutralASCVDRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Minimal effect on reducing or increasing the risk of cardiovascular disease resulting from atherosclerosis."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neutral ASCVD Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NeutralASCVDRisk">http://purl.org/twc/dpo/ont/NeutralASCVDRisk</seealso>
    let NeutralASCVDRisk = Prefixed_Name(dpo, "NeutralASCVDRisk") |> PrefixedName
    /// <summary>
    ///   <para>dpo:NeutralDKDRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Minimal effect on reducing or increasing the risk or progression of diabetic kidney disease."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neutral Diabetic Kidney Disease Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NeutralDKDRisk">http://purl.org/twc/dpo/ont/NeutralDKDRisk</seealso>
    let NeutralDKDRisk = Prefixed_Name(dpo, "NeutralDKDRisk") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NeutralHeartFailureRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Minimal effect on reducing or increasing the risk of heart failure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neutral Heart Failure Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NeutralHeartFailureRisk">http://purl.org/twc/dpo/ont/NeutralHeartFailureRisk</seealso>
    let NeutralHeartFailureRisk =
        Prefixed_Name(dpo, "NeutralHeartFailureRisk") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NeutralWeightChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The lack of an effect on the capacity for an increase or decrease in the weight of an individual."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Neutral Weight Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NeutralWeightChange">http://purl.org/twc/dpo/ont/NeutralWeightChange</seealso>
    let NeutralWeightChange = Prefixed_Name(dpo, "NeutralWeightChange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NoKnownHypoglycemiaRisk</para>
    /// </summary>
    /// <remarks>
    ///   <para>"No known association with the lowering of blood sugar below the normal range."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"No Known Hypoglycemia Risk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NoKnownHypoglycemiaRisk">http://purl.org/twc/dpo/ont/NoKnownHypoglycemiaRisk</seealso>
    let NoKnownHypoglycemiaRisk =
        Prefixed_Name(dpo, "NoKnownHypoglycemiaRisk") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NormalTriglycerideLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Normal Triglyceride Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NormalTriglycerideLevel">http://purl.org/twc/dpo/ont/NormalTriglycerideLevel</seealso>
    let NormalTriglycerideLevel =
        Prefixed_Name(dpo, "NormalTriglycerideLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NormalTriglycerideRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Normal Triglyceride Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NormalTriglycerideRange">http://purl.org/twc/dpo/ont/NormalTriglycerideRange</seealso>
    let NormalTriglycerideRange =
        Prefixed_Name(dpo, "NormalTriglycerideRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NormalWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"18.5&lt;BMI&lt;24.9"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Normal Weight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NormalWeight">http://purl.org/twc/dpo/ont/NormalWeight</seealso>
    let NormalWeight = Prefixed_Name(dpo, "NormalWeight") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NormalWeightBMIRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Normal Weight BMI Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NormalWeightBMIRange">http://purl.org/twc/dpo/ont/NormalWeightBMIRange</seealso>
    let NormalWeightBMIRange =
        Prefixed_Name(dpo, "NormalWeightBMIRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:NutritionMetabolismAndDevelopmentSymptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A symptom involving the nutrition, metabolism, and/or development system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nutrition Metabolism and Development Symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/NutritionMetabolismAndDevelopmentSymptom">http://purl.org/twc/dpo/ont/NutritionMetabolismAndDevelopmentSymptom</seealso>
    let NutritionMetabolismAndDevelopmentSymptom =
        Prefixed_Name(dpo, "NutritionMetabolismAndDevelopmentSymptom") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Obese</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"30&lt;BMI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Obese"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Obese">http://purl.org/twc/dpo/ont/Obese</seealso>
    let Obese = Prefixed_Name(dpo, "Obese") |> PrefixedName
    /// <summary>
    ///   <para>dpo:ObeseBMIRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Obese BMI Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/ObeseBMIRange">http://purl.org/twc/dpo/ont/ObeseBMIRange</seealso>
    let ObeseBMIRange = Prefixed_Name(dpo, "ObeseBMIRange") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Occupation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Occupation">http://purl.org/twc/dpo/ont/Occupation</seealso>
    let Occupation = Prefixed_Name(dpo, "Occupation") |> PrefixedName
    /// <summary>
    ///   <para>dpo:OptimalLDLLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Optimal LDL Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/OptimalLDLLevel">http://purl.org/twc/dpo/ont/OptimalLDLLevel</seealso>
    let OptimalLDLLevel = Prefixed_Name(dpo, "OptimalLDLLevel") |> PrefixedName
    /// <summary>
    ///   <para>dpo:OptimalLDLRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Optimal LDL Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/OptimalLDLRange">http://purl.org/twc/dpo/ont/OptimalLDLRange</seealso>
    let OptimalLDLRange = Prefixed_Name(dpo, "OptimalLDLRange") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Overweight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"25&lt;BMI&lt;30"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Overweight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Overweight">http://purl.org/twc/dpo/ont/Overweight</seealso>
    let Overweight = Prefixed_Name(dpo, "Overweight") |> PrefixedName
    /// <summary>
    ///   <para>dpo:OverweightBMIRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Overweight BMI Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/OverweightBMIRange">http://purl.org/twc/dpo/ont/OverweightBMIRange</seealso>
    let OverweightBMIRange = Prefixed_Name(dpo, "OverweightBMIRange") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Pain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Pain">http://purl.org/twc/dpo/ont/Pain</seealso>
    let Pain = Prefixed_Name(dpo, "Pain") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PatientCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Patient Characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PatientCharacteristic">http://purl.org/twc/dpo/ont/PatientCharacteristic</seealso>
    let PatientCharacteristic =
        Prefixed_Name(dpo, "PatientCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PeripheralNeuropathy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Peripheral Neuropathy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PeripheralNeuropathy">http://purl.org/twc/dpo/ont/PeripheralNeuropathy</seealso>
    let PeripheralNeuropathy =
        Prefixed_Name(dpo, "PeripheralNeuropathy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PersonalHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personal History"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PersonalHistory">http://purl.org/twc/dpo/ont/PersonalHistory</seealso>
    let PersonalHistory = Prefixed_Name(dpo, "PersonalHistory") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PersonalHistoryOfFebrileStates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personal History of Febrile States"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PersonalHistoryOfFebrileStates">http://purl.org/twc/dpo/ont/PersonalHistoryOfFebrileStates</seealso>
    let PersonalHistoryOfFebrileStates =
        Prefixed_Name(dpo, "PersonalHistoryOfFebrileStates") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PersonalHistoryOfGestationalDiabetes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personal History of Gestational Diabetes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PersonalHistoryOfGestationalDiabetes">http://purl.org/twc/dpo/ont/PersonalHistoryOfGestationalDiabetes</seealso>
    let PersonalHistoryOfGestationalDiabetes =
        Prefixed_Name(dpo, "PersonalHistoryOfGestationalDiabetes") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PharmacotherapyFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A circumstance influencing the treatment of a disease through the use or recommendation of one or more drugs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pharmacotherapy Factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PharmacotherapyFactor">http://purl.org/twc/dpo/ont/PharmacotherapyFactor</seealso>
    let PharmacotherapyFactor =
        Prefixed_Name(dpo, "PharmacotherapyFactor") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Pioglitazone</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:PotentialASCVDBenefit</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pioglitazone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Pioglitazone">http://purl.org/twc/dpo/ont/Pioglitazone</seealso>
    let Pioglitazone = Prefixed_Name(dpo, "Pioglitazone") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Polydipsia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Polydipsia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Polydipsia">http://purl.org/twc/dpo/ont/Polydipsia</seealso>
    let Polydipsia = Prefixed_Name(dpo, "Polydipsia") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Polyphagia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Polyphagia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Polyphagia">http://purl.org/twc/dpo/ont/Polyphagia</seealso>
    let Polyphagia = Prefixed_Name(dpo, "Polyphagia") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Polyuria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Polyuria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Polyuria">http://purl.org/twc/dpo/ont/Polyuria</seealso>
    let Polyuria = Prefixed_Name(dpo, "Polyuria") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PotentialASCVDBenefit</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Potential to reduce the risk of cardiovascular disease resulting from atherosclerosis."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Potential ASCVD Benefit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PotentialASCVDBenefit">http://purl.org/twc/dpo/ont/PotentialASCVDBenefit</seealso>
    let PotentialASCVDBenefit =
        Prefixed_Name(dpo, "PotentialASCVDBenefit") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PotentialASCVDBenefitDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PotentialASCVDBenefitDiabetesTherapy">http://purl.org/twc/dpo/ont/PotentialASCVDBenefitDiabetesTherapy</seealso>
    let PotentialASCVDBenefitDiabetesTherapy =
        Prefixed_Name(dpo, "PotentialASCVDBenefitDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PotentialDKDBenefit</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Potential to decrease the risk or progression of diabetic kidney disease."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Potential Diabetic Kidney Disease Benefit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PotentialDKDBenefit">http://purl.org/twc/dpo/ont/PotentialDKDBenefit</seealso>
    let PotentialDKDBenefit = Prefixed_Name(dpo, "PotentialDKDBenefit") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PotentialDKDBenefitDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PotentialDKDBenefitDiabetesTherapy">http://purl.org/twc/dpo/ont/PotentialDKDBenefitDiabetesTherapy</seealso>
    let PotentialDKDBenefitDiabetesTherapy =
        Prefixed_Name(dpo, "PotentialDKDBenefitDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PotentialHeartFailureBenefit</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Potential to decrease the risk of heart failure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Potential Heart Failure Benefit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PotentialHeartFailureBenefit">http://purl.org/twc/dpo/ont/PotentialHeartFailureBenefit</seealso>
    let PotentialHeartFailureBenefit =
        Prefixed_Name(dpo, "PotentialHeartFailureBenefit") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PrediabetesFastingBloodGlucoseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" impaired fasting glucose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Prediabetes Fasting Blood Glucose Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseLevel">http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseLevel</seealso>
    let PrediabetesFastingBloodGlucoseLevel =
        Prefixed_Name(dpo, "PrediabetesFastingBloodGlucoseLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PrediabetesFastingBloodGlucoseRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Prediabetes Fasting Blood Glucose Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseRange">http://purl.org/twc/dpo/ont/PrediabetesFastingBloodGlucoseRange</seealso>
    let PrediabetesFastingBloodGlucoseRange =
        Prefixed_Name(dpo, "PrediabetesFastingBloodGlucoseRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PrediabetesHbA1CLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Prediabetes HbA1C Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PrediabetesHbA1CLevel">http://purl.org/twc/dpo/ont/PrediabetesHbA1CLevel</seealso>
    let PrediabetesHbA1CLevel =
        Prefixed_Name(dpo, "PrediabetesHbA1CLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PrediabetesHbA1CRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Prediabetes HbA1C Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PrediabetesHbA1CRange">http://purl.org/twc/dpo/ont/PrediabetesHbA1CRange</seealso>
    let PrediabetesHbA1CRange =
        Prefixed_Name(dpo, "PrediabetesHbA1CRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PrediabetesTwoHourBloodGlucoseLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"impaired glucose tolerance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Prediabetes Two Hour Blood Glucose Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseLevel">http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseLevel</seealso>
    let PrediabetesTwoHourBloodGlucoseLevel =
        Prefixed_Name(dpo, "PrediabetesTwoHourBloodGlucoseLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:PrediabetesTwoHourBloodGlucoseRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Prediabetes Two Hour Blood Glucose Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseRange">http://purl.org/twc/dpo/ont/PrediabetesTwoHourBloodGlucoseRange</seealso>
    let PrediabetesTwoHourBloodGlucoseRange =
        Prefixed_Name(dpo, "PrediabetesTwoHourBloodGlucoseRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:RenalDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Disease associated with kidneys, typically chronic kidney disease."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Renal Disease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/RenalDisease">http://purl.org/twc/dpo/ont/RenalDisease</seealso>
    let RenalDisease = Prefixed_Name(dpo, "RenalDisease") |> PrefixedName

    /// <summary>
    ///   <para>dpo:RenalDosingConsideration</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Drug dosage considerations related to the effect on the kidneys."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Renal Dosing Consideration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/RenalDosingConsideration">http://purl.org/twc/dpo/ont/RenalDosingConsideration</seealso>
    let RenalDosingConsideration =
        Prefixed_Name(dpo, "RenalDosingConsideration") |> PrefixedName

    /// <summary>
    ///   <para>dpo:RenalEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A pharmacotherapy factor related to the kidneys."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Renal Effect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/RenalEffect">http://purl.org/twc/dpo/ont/RenalEffect</seealso>
    let RenalEffect = Prefixed_Name(dpo, "RenalEffect") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Rosiglitazone</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rosiglitazone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Rosiglitazone">http://purl.org/twc/dpo/ont/Rosiglitazone</seealso>
    let Rosiglitazone = Prefixed_Name(dpo, "Rosiglitazone") |> PrefixedName
    /// <summary>
    ///   <para>dpo:SGLT2Inhibitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:HighCost</para>
    ///   <para>dpo:NoKnownHypoglycemiaRisk</para>
    ///   <para>dpo:WeightLossPotential</para>
    ///   <para>dpo:IntermediateEfficacy</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SGLT2 Inhibitor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/SGLT2Inhibitor">http://purl.org/twc/dpo/ont/SGLT2Inhibitor</seealso>
    let SGLT2Inhibitor = Prefixed_Name(dpo, "SGLT2Inhibitor") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Saxagliptin</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:IncreasedHeartFailureRisk</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Saxagliptin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Saxagliptin">http://purl.org/twc/dpo/ont/Saxagliptin</seealso>
    let Saxagliptin = Prefixed_Name(dpo, "Saxagliptin") |> PrefixedName
    /// <summary>
    ///   <para>dpo:SedentaryLifestyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sedentary Lifestyle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/SedentaryLifestyle">http://purl.org/twc/dpo/ont/SedentaryLifestyle</seealso>
    let SedentaryLifestyle = Prefixed_Name(dpo, "SedentaryLifestyle") |> PrefixedName
    /// <summary>
    ///   <para>dpo:SedentaryOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sedentary Occupation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/SedentaryOccupation">http://purl.org/twc/dpo/ont/SedentaryOccupation</seealso>
    let SedentaryOccupation = Prefixed_Name(dpo, "SedentaryOccupation") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Semaglutide</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:PotentialASCVDBenefit</para>
    ///   <para>dpo:PotentialDKDBenefit</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Semaglutide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Semaglutide">http://purl.org/twc/dpo/ont/Semaglutide</seealso>
    let Semaglutide = Prefixed_Name(dpo, "Semaglutide") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Sitagliptin</para>
    /// </summary>
    /// <remarks>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sitagliptin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Sitagliptin">http://purl.org/twc/dpo/ont/Sitagliptin</seealso>
    let Sitagliptin = Prefixed_Name(dpo, "Sitagliptin") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Sulfonylurea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:NeutralDKDRisk</para>
    ///   <para>dpo:WeightGainPotential</para>
    ///   <para>dpo:NeutralASCVDRisk</para>
    ///   <para>dpo:KnownHypoglycemiaRisk</para>
    ///   <para>dpo:NeutralHeartFailureRisk</para>
    ///   <para>dpo:HighEfficacy</para>
    ///   <para>dpo:LowCost</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sulfonylurea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Sulfonylurea">http://purl.org/twc/dpo/ont/Sulfonylurea</seealso>
    let Sulfonylurea = Prefixed_Name(dpo, "Sulfonylurea") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Symptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Symptom">http://purl.org/twc/dpo/ont/Symptom</seealso>
    let Symptom = Prefixed_Name(dpo, "Symptom") |> PrefixedName
    /// <summary>
    ///   <para>dpo:TestFinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A finding or categorization surmised from recorded measurements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Test Finding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/TestFinding">http://purl.org/twc/dpo/ont/TestFinding</seealso>
    let TestFinding = Prefixed_Name(dpo, "TestFinding") |> PrefixedName
    /// <summary>
    ///   <para>dpo:Therapy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Therapy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Therapy">http://purl.org/twc/dpo/ont/Therapy</seealso>
    let Therapy = Prefixed_Name(dpo, "Therapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:TherapyPlanningComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Therapy Planning Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/TherapyPlanningComponent">http://purl.org/twc/dpo/ont/TherapyPlanningComponent</seealso>
    let TherapyPlanningComponent =
        Prefixed_Name(dpo, "TherapyPlanningComponent") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Thiazolidinedione</para>
    /// </summary>
    /// <remarks>
    ///   <para>dpo:IncreasedHeartFailureRisk</para>
    ///   <para>dpo:HighEfficacy</para>
    ///   <para>dpo:LowCost</para>
    ///   <para>dpo:NoKnownHypoglycemiaRisk</para>
    ///   <para>dpo:WeightGainPotential</para>
    ///   <para>dpo:NeutralDKDRisk</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thiazolidinedione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Thiazolidinedione">http://purl.org/twc/dpo/ont/Thiazolidinedione</seealso>
    let Thiazolidinedione = Prefixed_Name(dpo, "Thiazolidinedione") |> PrefixedName

    /// <summary>
    ///   <para>dpo:TriglycerideMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Triglyceride Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/TriglycerideMeasurement">http://purl.org/twc/dpo/ont/TriglycerideMeasurement</seealso>
    let TriglycerideMeasurement =
        Prefixed_Name(dpo, "TriglycerideMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dpo:Underweight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"BMI&lt;18.5"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Underweight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/Underweight">http://purl.org/twc/dpo/ont/Underweight</seealso>
    let Underweight = Prefixed_Name(dpo, "Underweight") |> PrefixedName
    /// <summary>
    ///   <para>dpo:UnderweightBMIRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Underweight BMI Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/UnderweightBMIRange">http://purl.org/twc/dpo/ont/UnderweightBMIRange</seealso>
    let UnderweightBMIRange = Prefixed_Name(dpo, "UnderweightBMIRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:UrinarySystemSymptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A symptom involving the urinary system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Urinary System Symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/UrinarySystemSymptom">http://purl.org/twc/dpo/ont/UrinarySystemSymptom</seealso>
    let UrinarySystemSymptom =
        Prefixed_Name(dpo, "UrinarySystemSymptom") |> PrefixedName

    /// <summary>
    ///   <para>dpo:UrinaryTractInfection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Urinary Tract Infection (UTI)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/UrinaryTractInfection">http://purl.org/twc/dpo/ont/UrinaryTractInfection</seealso>
    let UrinaryTractInfection =
        Prefixed_Name(dpo, "UrinaryTractInfection") |> PrefixedName

    /// <summary>
    ///   <para>dpo:VeryHighHbA1CLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Very High HbA1C Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/VeryHighHbA1CLevel">http://purl.org/twc/dpo/ont/VeryHighHbA1CLevel</seealso>
    let VeryHighHbA1CLevel = Prefixed_Name(dpo, "VeryHighHbA1CLevel") |> PrefixedName
    /// <summary>
    ///   <para>dpo:VeryHighHbA1CRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Very High HbA1C Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/VeryHighHbA1CRange">http://purl.org/twc/dpo/ont/VeryHighHbA1CRange</seealso>
    let VeryHighHbA1CRange = Prefixed_Name(dpo, "VeryHighHbA1CRange") |> PrefixedName
    /// <summary>
    ///   <para>dpo:VeryHighLDLLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Very High LDL Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/VeryHighLDLLevel">http://purl.org/twc/dpo/ont/VeryHighLDLLevel</seealso>
    let VeryHighLDLLevel = Prefixed_Name(dpo, "VeryHighLDLLevel") |> PrefixedName
    /// <summary>
    ///   <para>dpo:VeryHighLDLRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Very High LDL Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/VeryHighLDLRange">http://purl.org/twc/dpo/ont/VeryHighLDLRange</seealso>
    let VeryHighLDLRange = Prefixed_Name(dpo, "VeryHighLDLRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:VeryHighTriglycerideLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Very High Triglyceride Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/VeryHighTriglycerideLevel">http://purl.org/twc/dpo/ont/VeryHighTriglycerideLevel</seealso>
    let VeryHighTriglycerideLevel =
        Prefixed_Name(dpo, "VeryHighTriglycerideLevel") |> PrefixedName

    /// <summary>
    ///   <para>dpo:VeryHighTriglycerideRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///
    /// labels<para>"Very High Triglyceride Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/VeryHighTriglycerideRange">http://purl.org/twc/dpo/ont/VeryHighTriglycerideRange</seealso>
    let VeryHighTriglycerideRange =
        Prefixed_Name(dpo, "VeryHighTriglycerideRange") |> PrefixedName

    /// <summary>
    ///   <para>dpo:VisionSymptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A symptom involving visual impairment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vision Symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/VisionSymptom">http://purl.org/twc/dpo/ont/VisionSymptom</seealso>
    let VisionSymptom = Prefixed_Name(dpo, "VisionSymptom") |> PrefixedName

    /// <summary>
    ///   <para>dpo:WeightChangePotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The capacity for an increase or decrease in the weight of an individual."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Weight Change Potential"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/WeightChangePotential">http://purl.org/twc/dpo/ont/WeightChangePotential</seealso>
    let WeightChangePotential =
        Prefixed_Name(dpo, "WeightChangePotential") |> PrefixedName

    /// <summary>
    ///   <para>dpo:WeightGainDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/WeightGainDiabetesTherapy">http://purl.org/twc/dpo/ont/WeightGainDiabetesTherapy</seealso>
    let WeightGainDiabetesTherapy =
        Prefixed_Name(dpo, "WeightGainDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:WeightGainPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The capacity for an increase in the weight of an individual."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Weight Gain Potential"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/WeightGainPotential">http://purl.org/twc/dpo/ont/WeightGainPotential</seealso>
    let WeightGainPotential = Prefixed_Name(dpo, "WeightGainPotential") |> PrefixedName

    /// <summary>
    ///   <para>dpo:WeightLossDiabetesTherapy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/WeightLossDiabetesTherapy">http://purl.org/twc/dpo/ont/WeightLossDiabetesTherapy</seealso>
    let WeightLossDiabetesTherapy =
        Prefixed_Name(dpo, "WeightLossDiabetesTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:WeightLossPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The capacity for a decrease in the weight of an individual."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Weight Loss Potential"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/WeightLossPotential">http://purl.org/twc/dpo/ont/WeightLossPotential</seealso>
    let WeightLossPotential = Prefixed_Name(dpo, "WeightLossPotential") |> PrefixedName

    /// <summary>
    ///   <para>dpo:diabetes_pharmacology_ontology.ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/diabetes_pharmacology_ontology.ttl">http://purl.org/twc/dpo/ont/diabetes_pharmacology_ontology.ttl</seealso>
    let ``diabetes_pharmacology_ontology.ttl`` =
        Prefixed_Name(dpo, "diabetes_pharmacology_ontology.ttl") |> PrefixedName

    /// <summary>
    ///   <para>dpo:hasDiagnosis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has diagnosis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/hasDiagnosis">http://purl.org/twc/dpo/ont/hasDiagnosis</seealso>
    let hasDiagnosis = Prefixed_Name(dpo, "hasDiagnosis") |> PrefixedName
    /// <summary>
    ///   <para>dpo:hasTherapy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has therapy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/hasTherapy">http://purl.org/twc/dpo/ont/hasTherapy</seealso>
    let hasTherapy = Prefixed_Name(dpo, "hasTherapy") |> PrefixedName

    /// <summary>
    ///   <para>dpo:hasTreatmentAversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has therapy aversion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/hasTreatmentAversion">http://purl.org/twc/dpo/ont/hasTreatmentAversion</seealso>
    let hasTreatmentAversion =
        Prefixed_Name(dpo, "hasTreatmentAversion") |> PrefixedName

    /// <summary>
    ///   <para>dpo:hasTreatmentPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has therapy preference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/twc/dpo/ont/hasTreatmentPreference">http://purl.org/twc/dpo/ont/hasTreatmentPreference</seealso>
    let hasTreatmentPreference =
        Prefixed_Name(dpo, "hasTreatmentPreference") |> PrefixedName
