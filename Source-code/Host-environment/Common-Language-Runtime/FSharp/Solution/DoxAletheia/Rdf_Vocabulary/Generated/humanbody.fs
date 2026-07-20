namespace http.eulersharp.sourceforge.net._2003._03swap.humanBody.hash

open DoxAletheia

module humanbody =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/humanBody#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AcquiredStructure"></see>
    /// </summary>
    let AcquiredStructure = _prefix "AcquiredStructure"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Structure"></see>
    /// </summary>
    let Structure = _prefix "Structure"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AnatomicalStructure"></see>
    /// </summary>
    let AnatomicalStructure = _prefix "AnatomicalStructure"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndex"></see>
    /// </summary>
    let AdultBodyMassIndex = _prefix "AdultBodyMassIndex"
    /// <summary>
    /// May overestimate body fat in athletes and others who have a muscular build; may underestimate body fat in older persons and others who have lost muscle mass.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndexMeasurement"></see></summary>
    let AdultBodyMassIndexMeasurement = _prefix "AdultBodyMassIndexMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeight"></see>
    /// </summary>
    let BirthWeight = _prefix "BirthWeight"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weight"></see>
    /// </summary>
    let Weight = _prefix "Weight"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeightMeasurement"></see>
    /// </summary>
    let BirthWeightMeasurement = _prefix "BirthWeightMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightMeasurement"></see>
    /// </summary>
    let WeightMeasurement = _prefix "WeightMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weighing"></see>
    /// </summary>
    let Weighing = _prefix "Weighing"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Body"></see>
    /// </summary>
    let Body = _prefix "Body"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#DeadBody"></see>
    /// </summary>
    let DeadBody = _prefix "DeadBody"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Death"></see>
    /// </summary>
    let Death = _prefix "Death"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Length"></see>
    /// </summary>
    let Length = _prefix "Length"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasurement"></see>
    /// </summary>
    let LengthMeasurement = _prefix "LengthMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasuring"></see>
    /// </summary>
    let LengthMeasuring = _prefix "LengthMeasuring"
    /// <summary>
    /// Body mass index ranging 35-44.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#MorbidlyObese"></see></summary>
    let MorbidlyObese = _prefix "MorbidlyObese"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightStatus"></see>
    /// </summary>
    let WeightStatus = _prefix "WeightStatus"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Newborn"></see>
    /// </summary>
    let Newborn = _prefix "Newborn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeight"></see>
    /// </summary>
    let hasWeight = _prefix "hasWeight"
    /// <summary>
    /// Body mass index ranging 18.5-24.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#NormalWeight"></see></summary>
    let NormalWeight = _prefix "NormalWeight"
    /// <summary>
    /// Body mass index ranging 30-34.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Obese"></see></summary>
    let Obese = _prefix "Obese"
    /// <summary>
    /// Body mass index ranging 25-29.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Overweight"></see></summary>
    let Overweight = _prefix "Overweight"
    /// <summary>
    /// Body mass index lower than 16 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SeverelyUnderweight"></see></summary>
    let SeverelyUnderweight = _prefix "SeverelyUnderweight"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Substance"></see>
    /// </summary>
    let Substance = _prefix "Substance"
    /// <summary>
    /// Body mass index over 44.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SuperObese"></see></summary>
    let SuperObese = _prefix "SuperObese"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Surface"></see>
    /// </summary>
    let Surface = _prefix "Surface"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceArea"></see>
    /// </summary>
    let SurfaceArea = _prefix "SurfaceArea"
    /// <summary>
    /// Approximative calculation, e.g. in an N3 rule with formula of Mosteller, see http://eulersharp.sourceforge.net/2003/03swap/bodySurfaceArea_rules.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceAreaMeasurement"></see></summary>
    let SurfaceAreaMeasurement = _prefix "SurfaceAreaMeasurement"
    /// <summary>
    /// Body mass index ranging 16-18.4 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Underweight"></see></summary>
    let Underweight = _prefix "Underweight"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeighingDevice"></see>
    /// </summary>
    let WeighingDevice = _prefix "WeighingDevice"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBirthWeight"></see>
    /// </summary>
    let hasBirthWeight = _prefix "hasBirthWeight"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBodyMassIndex"></see>
    /// </summary>
    let hasBodyMassIndex = _prefix "hasBodyMassIndex"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasLength"></see>
    /// </summary>
    let hasLength = _prefix "hasLength"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasSurfaceArea"></see>
    /// </summary>
    let hasSurfaceArea = _prefix "hasSurfaceArea"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeightStatus"></see>
    /// </summary>
    let hasWeightStatus = _prefix "hasWeightStatus"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#weightOf"></see>
    /// </summary>
    let weightOf = _prefix "weightOf"
