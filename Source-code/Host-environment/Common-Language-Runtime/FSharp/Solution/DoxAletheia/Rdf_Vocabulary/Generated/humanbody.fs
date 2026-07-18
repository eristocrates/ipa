namespace http.eulersharp.sourceforge.net._2003._03swap.humanBody.hash

open DoxAletheia.Rdf_Vocabulary

module humanbody =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/humanBody#"

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AcquiredStructure"></see>
    /// </summary>
    let AcquiredStructure =
        Namespaced_IRI.parse _namespace_name "AcquiredStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Structure"></see>
    /// </summary>
    let Structure = Namespaced_IRI.parse _namespace_name "Structure" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AnatomicalStructure"></see>
    /// </summary>
    let AnatomicalStructure =
        Namespaced_IRI.parse _namespace_name "AnatomicalStructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndex"></see>
    /// </summary>
    let AdultBodyMassIndex =
        Namespaced_IRI.parse _namespace_name "AdultBodyMassIndex" |> NamespacedName

    /// <summary>
    /// May overestimate body fat in athletes and others who have a muscular build; may underestimate body fat in older persons and others who have lost muscle mass.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#AdultBodyMassIndexMeasurement"></see></summary>
    let AdultBodyMassIndexMeasurement =
        Namespaced_IRI.parse _namespace_name "AdultBodyMassIndexMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeight"></see>
    /// </summary>
    let BirthWeight =
        Namespaced_IRI.parse _namespace_name "BirthWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weight"></see>
    /// </summary>
    let Weight = Namespaced_IRI.parse _namespace_name "Weight" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#BirthWeightMeasurement"></see>
    /// </summary>
    let BirthWeightMeasurement =
        Namespaced_IRI.parse _namespace_name "BirthWeightMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightMeasurement"></see>
    /// </summary>
    let WeightMeasurement =
        Namespaced_IRI.parse _namespace_name "WeightMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Weighing"></see>
    /// </summary>
    let Weighing = Namespaced_IRI.parse _namespace_name "Weighing" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Body"></see>
    /// </summary>
    let Body = Namespaced_IRI.parse _namespace_name "Body" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#DeadBody"></see>
    /// </summary>
    let DeadBody = Namespaced_IRI.parse _namespace_name "DeadBody" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Death"></see>
    /// </summary>
    let Death = Namespaced_IRI.parse _namespace_name "Death" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Length"></see>
    /// </summary>
    let Length = Namespaced_IRI.parse _namespace_name "Length" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasurement"></see>
    /// </summary>
    let LengthMeasurement =
        Namespaced_IRI.parse _namespace_name "LengthMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#LengthMeasuring"></see>
    /// </summary>
    let LengthMeasuring =
        Namespaced_IRI.parse _namespace_name "LengthMeasuring" |> NamespacedName

    /// <summary>
    /// Body mass index ranging 35-44.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#MorbidlyObese"></see></summary>
    let MorbidlyObese =
        Namespaced_IRI.parse _namespace_name "MorbidlyObese" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeightStatus"></see>
    /// </summary>
    let WeightStatus =
        Namespaced_IRI.parse _namespace_name "WeightStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Newborn"></see>
    /// </summary>
    let Newborn = Namespaced_IRI.parse _namespace_name "Newborn" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeight"></see>
    /// </summary>
    let hasWeight = Namespaced_IRI.parse _namespace_name "hasWeight" |> NamespacedName

    /// <summary>
    /// Body mass index ranging 18.5-24.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#NormalWeight"></see></summary>
    let NormalWeight =
        Namespaced_IRI.parse _namespace_name "NormalWeight" |> NamespacedName

    /// <summary>
    /// Body mass index ranging 30-34.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Obese"></see></summary>
    let Obese = Namespaced_IRI.parse _namespace_name "Obese" |> NamespacedName
    /// <summary>
    /// Body mass index ranging 25-29.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Overweight"></see></summary>
    let Overweight = Namespaced_IRI.parse _namespace_name "Overweight" |> NamespacedName

    /// <summary>
    /// Body mass index lower than 16 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SeverelyUnderweight"></see></summary>
    let SeverelyUnderweight =
        Namespaced_IRI.parse _namespace_name "SeverelyUnderweight" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Substance"></see>
    /// </summary>
    let Substance = Namespaced_IRI.parse _namespace_name "Substance" |> NamespacedName
    /// <summary>
    /// Body mass index over 44.9 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SuperObese"></see></summary>
    let SuperObese = Namespaced_IRI.parse _namespace_name "SuperObese" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Surface"></see>
    /// </summary>
    let Surface = Namespaced_IRI.parse _namespace_name "Surface" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceArea"></see>
    /// </summary>
    let SurfaceArea =
        Namespaced_IRI.parse _namespace_name "SurfaceArea" |> NamespacedName

    /// <summary>
    /// Approximative calculation, e.g. in an N3 rule with formula of Mosteller, see http://eulersharp.sourceforge.net/2003/03swap/bodySurfaceArea_rules.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#SurfaceAreaMeasurement"></see></summary>
    let SurfaceAreaMeasurement =
        Namespaced_IRI.parse _namespace_name "SurfaceAreaMeasurement" |> NamespacedName

    /// <summary>
    /// Body mass index ranging 16-18.4 kg/m2.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#Underweight"></see></summary>
    let Underweight =
        Namespaced_IRI.parse _namespace_name "Underweight" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#WeighingDevice"></see>
    /// </summary>
    let WeighingDevice =
        Namespaced_IRI.parse _namespace_name "WeighingDevice" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBirthWeight"></see>
    /// </summary>
    let hasBirthWeight =
        Namespaced_IRI.parse _namespace_name "hasBirthWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasBodyMassIndex"></see>
    /// </summary>
    let hasBodyMassIndex =
        Namespaced_IRI.parse _namespace_name "hasBodyMassIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasLength"></see>
    /// </summary>
    let hasLength = Namespaced_IRI.parse _namespace_name "hasLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasSurfaceArea"></see>
    /// </summary>
    let hasSurfaceArea =
        Namespaced_IRI.parse _namespace_name "hasSurfaceArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#hasWeightStatus"></see>
    /// </summary>
    let hasWeightStatus =
        Namespaced_IRI.parse _namespace_name "hasWeightStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/humanBody#weightOf"></see>
    /// </summary>
    let weightOf = Namespaced_IRI.parse _namespace_name "weightOf" |> NamespacedName
