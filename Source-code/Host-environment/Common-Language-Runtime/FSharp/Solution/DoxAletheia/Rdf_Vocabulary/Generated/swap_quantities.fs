namespace http.eulersharp.sourceforge.net._2003._03swap.quantities.hash

open DoxAletheia.Rdf_Vocabulary

module swap_quantities =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/quantities#"
    /// <summary>
    /// The higher an accuracy, the more test results are true.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Accuracy"></see></summary>
    let Accuracy = Namespaced_IRI.parse _namespace_name "Accuracy" |> NamespacedName
    /// <summary>
    /// E.g. 1 g sugar/20 mL water = 0,05 g sugar/mL water
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Ratio"></see></summary>
    let Ratio = Namespaced_IRI.parse _namespace_name "Ratio" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AmountOfSubstance"></see>
    /// </summary>
    let AmountOfSubstance =
        Namespaced_IRI.parse _namespace_name "AmountOfSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#PhysicalQuantity"></see>
    /// </summary>
    let PhysicalQuantity =
        Namespaced_IRI.parse _namespace_name "PhysicalQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AmountOfSubstanceConcentration"></see>
    /// </summary>
    let AmountOfSubstanceConcentration =
        Namespaced_IRI.parse _namespace_name "AmountOfSubstanceConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Quantity"></see>
    /// </summary>
    let Quantity = Namespaced_IRI.parse _namespace_name "Quantity" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Area"></see>
    /// </summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AreaMeasurement"></see>
    /// </summary>
    let AreaMeasurement =
        Namespaced_IRI.parse _namespace_name "AreaMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measurement"></see>
    /// </summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measurementOf"></see>
    /// </summary>
    let measurementOf =
        Namespaced_IRI.parse _namespace_name "measurementOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasUnit"></see>
    /// </summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#unitOf"></see>
    /// </summary>
    let unitOf = Namespaced_IRI.parse _namespace_name "unitOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArealDensity"></see>
    /// </summary>
    let ArealDensity =
        Namespaced_IRI.parse _namespace_name "ArealDensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArealDensityMeasurement"></see>
    /// </summary>
    let ArealDensityMeasurement =
        Namespaced_IRI.parse _namespace_name "ArealDensityMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArithmeticMean"></see>
    /// </summary>
    let ArithmeticMean =
        Namespaced_IRI.parse _namespace_name "ArithmeticMean" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Average"></see>
    /// </summary>
    let Average = Namespaced_IRI.parse _namespace_name "Average" |> NamespacedName

    /// <summary>
    /// The higher an aspecificity, the more false positive cases are detected, e.g. the more healthy people are considered sick.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Aspecificity"></see></summary>
    let Aspecificity =
        Namespaced_IRI.parse _namespace_name "Aspecificity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Circularity"></see>
    /// </summary>
    let Circularity =
        Namespaced_IRI.parse _namespace_name "Circularity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Concentration"></see>
    /// </summary>
    let Concentration =
        Namespaced_IRI.parse _namespace_name "Concentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ConcentrationMeasurement"></see>
    /// </summary>
    let ConcentrationMeasurement =
        Namespaced_IRI.parse _namespace_name "ConcentrationMeasurement" |> NamespacedName

    /// <summary>
    /// Quantity having a smaller measurement value than a reference.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Decreased"></see></summary>
    let Decreased = Namespaced_IRI.parse _namespace_name "Decreased" |> NamespacedName
    /// <summary>
    /// Quantity having a smaller measurement value than a normative reference value range.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Deficient"></see></summary>
    let Deficient = Namespaced_IRI.parse _namespace_name "Deficient" |> NamespacedName

    /// <summary>
    /// E.g. 20 mL water in 1 g sugar/20 mL water
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Denominator"></see></summary>
    let Denominator =
        Namespaced_IRI.parse _namespace_name "Denominator" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#DigitalSize"></see>
    /// </summary>
    let DigitalSize =
        Namespaced_IRI.parse _namespace_name "DigitalSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#DigitalSizeMeasurement"></see>
    /// </summary>
    let DigitalSizeMeasurement =
        Namespaced_IRI.parse _namespace_name "DigitalSizeMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ElectricalResistance"></see>
    /// </summary>
    let ElectricalResistance =
        Namespaced_IRI.parse _namespace_name "ElectricalResistance" |> NamespacedName

    /// <summary>
    /// Quantity having a bigger measurement value than a normative reference value range.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Excessive"></see></summary>
    let Excessive = Namespaced_IRI.parse _namespace_name "Excessive" |> NamespacedName
    /// <summary>
    /// E.g. quantity 'percentage', its measurement having factor 'percent' or '0.01'.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Factor"></see></summary>
    let Factor = Namespaced_IRI.parse _namespace_name "Factor" |> NamespacedName

    /// <summary>
    /// The higher a false discovery rate, the more positive test results are false.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FalseDiscoveryRate"></see></summary>
    let FalseDiscoveryRate =
        Namespaced_IRI.parse _namespace_name "FalseDiscoveryRate" |> NamespacedName

    /// <summary>
    /// The higher a false negative rate, the more true positive cases go undetected, e.g. the more sick people are considered healthy.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FalseNegativeRate"></see></summary>
    let FalseNegativeRate =
        Namespaced_IRI.parse _namespace_name "FalseNegativeRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Frequency"></see>
    /// </summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasNumerator"></see>
    /// </summary>
    let hasNumerator =
        Namespaced_IRI.parse _namespace_name "hasNumerator" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NumberOfEvents"></see>
    /// </summary>
    let NumberOfEvents =
        Namespaced_IRI.parse _namespace_name "NumberOfEvents" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FrequencyMeasurement"></see>
    /// </summary>
    let FrequencyMeasurement =
        Namespaced_IRI.parse _namespace_name "FrequencyMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#GrayLevel"></see>
    /// </summary>
    let GrayLevel = Namespaced_IRI.parse _namespace_name "GrayLevel" |> NamespacedName
    /// <summary>
    /// Quantity having a bigger measurement value than a reference.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Increased"></see></summary>
    let Increased = Namespaced_IRI.parse _namespace_name "Increased" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Length"></see>
    /// </summary>
    let Length = Namespaced_IRI.parse _namespace_name "Length" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#LengthMeasurement"></see>
    /// </summary>
    let LengthMeasurement =
        Namespaced_IRI.parse _namespace_name "LengthMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Mass"></see>
    /// </summary>
    let Mass = Namespaced_IRI.parse _namespace_name "Mass" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassConcentration"></see>
    /// </summary>
    let MassConcentration =
        Namespaced_IRI.parse _namespace_name "MassConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassConcentrationMeasurement"></see>
    /// </summary>
    let MassConcentrationMeasurement =
        Namespaced_IRI.parse _namespace_name "MassConcentrationMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassMeasurement"></see>
    /// </summary>
    let MassMeasurement =
        Namespaced_IRI.parse _namespace_name "MassMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Maximum"></see>
    /// </summary>
    let Maximum = Namespaced_IRI.parse _namespace_name "Maximum" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Number"></see>
    /// </summary>
    let Number = Namespaced_IRI.parse _namespace_name "Number" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measuring"></see>
    /// </summary>
    let Measuring = Namespaced_IRI.parse _namespace_name "Measuring" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measurer"></see>
    /// </summary>
    let Measurer = Namespaced_IRI.parse _namespace_name "Measurer" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Median"></see>
    /// </summary>
    let Median = Namespaced_IRI.parse _namespace_name "Median" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Minimum"></see>
    /// </summary>
    let Minimum = Namespaced_IRI.parse _namespace_name "Minimum" |> NamespacedName

    /// <summary>
    /// The higher a negative predictive value, the more negative test results are true.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NegativePredictiveValue"></see></summary>
    let NegativePredictiveValue =
        Namespaced_IRI.parse _namespace_name "NegativePredictiveValue" |> NamespacedName

    /// <summary>
    /// Quantity having a measurement value within a normative reference value range.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Normal"></see></summary>
    let Normal = Namespaced_IRI.parse _namespace_name "Normal" |> NamespacedName

    /// <summary>
    /// Quantity having a not a bigger measurement value than a normative reference value range.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NotExcessive"></see></summary>
    let NotExcessive =
        Namespaced_IRI.parse _namespace_name "NotExcessive" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NotShort"></see>
    /// </summary>
    let NotShort = Namespaced_IRI.parse _namespace_name "NotShort" |> NamespacedName
    /// <summary>
    /// E.g. 1 g sugar in 1 g sugar/20 mL water
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Numerator"></see></summary>
    let Numerator = Namespaced_IRI.parse _namespace_name "Numerator" |> NamespacedName
    /// <summary>
    /// E.g. frequency of drug intake
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#OnceADay"></see></summary>
    let OnceADay = Namespaced_IRI.parse _namespace_name "OnceADay" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Part"></see>
    /// </summary>
    let Part = Namespaced_IRI.parse _namespace_name "Part" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Percentage"></see>
    /// </summary>
    let Percentage = Namespaced_IRI.parse _namespace_name "Percentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#PercentageMeasurement"></see>
    /// </summary>
    let PercentageMeasurement =
        Namespaced_IRI.parse _namespace_name "PercentageMeasurement" |> NamespacedName

    /// <summary>
    /// E.g. 'per cent' is factor of 'percentage measurement'.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasFactor"></see></summary>
    let hasFactor = Namespaced_IRI.parse _namespace_name "hasFactor" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percent"></see>
    /// </summary>
    let percent = Namespaced_IRI.parse _namespace_name "percent" |> NamespacedName
    /// <summary>
    /// The higher a precision, the more positive test results are true.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Precision"></see></summary>
    let Precision = Namespaced_IRI.parse _namespace_name "Precision" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Pressure"></see>
    /// </summary>
    let Pressure = Namespaced_IRI.parse _namespace_name "Pressure" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Probability"></see>
    /// </summary>
    let Probability =
        Namespaced_IRI.parse _namespace_name "Probability" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Sample"></see>
    /// </summary>
    let Sample = Namespaced_IRI.parse _namespace_name "Sample" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#SampleSize"></see>
    /// </summary>
    let SampleSize = Namespaced_IRI.parse _namespace_name "SampleSize" |> NamespacedName

    /// <summary>
    /// The higher a sensitivity, the fewer true positive cases go undetected, e.g. the fewer sick people are considered healthy.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Sensitivity"></see></summary>
    let Sensitivity =
        Namespaced_IRI.parse _namespace_name "Sensitivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Short"></see>
    /// </summary>
    let Short = Namespaced_IRI.parse _namespace_name "Short" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#SolutionConcentration"></see>
    /// </summary>
    let SolutionConcentration =
        Namespaced_IRI.parse _namespace_name "SolutionConcentration" |> NamespacedName

    /// <summary>
    /// The higher a specificity, the more true negative cases are detected, e.g. the fewer healthy people are considered sick.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Specificity"></see></summary>
    let Specificity =
        Namespaced_IRI.parse _namespace_name "Specificity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Speed"></see>
    /// </summary>
    let Speed = Namespaced_IRI.parse _namespace_name "Speed" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Temperature"></see>
    /// </summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#TemperatureMeasurement"></see>
    /// </summary>
    let TemperatureMeasurement =
        Namespaced_IRI.parse _namespace_name "TemperatureMeasurement" |> NamespacedName

    /// <summary>
    /// E.g. frequency of drug intake
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ThriceADay"></see></summary>
    let ThriceADay = Namespaced_IRI.parse _namespace_name "ThriceADay" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Time"></see>
    /// </summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Total"></see>
    /// </summary>
    let Total = Namespaced_IRI.parse _namespace_name "Total" |> NamespacedName
    /// <summary>
    /// E.g. frequency of drug intake
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#TwiceADay"></see></summary>
    let TwiceADay = Namespaced_IRI.parse _namespace_name "TwiceADay" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Velocity"></see>
    /// </summary>
    let Velocity = Namespaced_IRI.parse _namespace_name "Velocity" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Volume"></see>
    /// </summary>
    let Volume = Namespaced_IRI.parse _namespace_name "Volume" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeFLowRate"></see>
    /// </summary>
    let VolumeFLowRate =
        Namespaced_IRI.parse _namespace_name "VolumeFLowRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeFLowRateMeasurement"></see>
    /// </summary>
    let VolumeFLowRateMeasurement =
        Namespaced_IRI.parse _namespace_name "VolumeFLowRateMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeMeasurement"></see>
    /// </summary>
    let VolumeMeasurement =
        Namespaced_IRI.parse _namespace_name "VolumeMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#areaOf"></see>
    /// </summary>
    let areaOf = Namespaced_IRI.parse _namespace_name "areaOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#physicalQuantityOf"></see>
    /// </summary>
    let physicalQuantityOf =
        Namespaced_IRI.parse _namespace_name "physicalQuantityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#averageOf"></see>
    /// </summary>
    let averageOf = Namespaced_IRI.parse _namespace_name "averageOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#quantityOf"></see>
    /// </summary>
    let quantityOf = Namespaced_IRI.parse _namespace_name "quantityOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasAverage"></see>
    /// </summary>
    let hasAverage = Namespaced_IRI.parse _namespace_name "hasAverage" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#convertedFrom"></see>
    /// </summary>
    let convertedFrom =
        Namespaced_IRI.parse _namespace_name "convertedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#convertedTo"></see>
    /// </summary>
    let convertedTo =
        Namespaced_IRI.parse _namespace_name "convertedTo" |> NamespacedName

    /// <summary>
    /// Used in conclusion of a rule with in its antecedent a calculation of a value with a built-in.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#counts"></see></summary>
    let counts = Namespaced_IRI.parse _namespace_name "counts" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasNumber"></see>
    /// </summary>
    let hasNumber = Namespaced_IRI.parse _namespace_name "hasNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMeasurement"></see>
    /// </summary>
    let hasMeasurement =
        Namespaced_IRI.parse _namespace_name "hasMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#denominatorOf"></see>
    /// </summary>
    let denominatorOf =
        Namespaced_IRI.parse _namespace_name "denominatorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasDenominator"></see>
    /// </summary>
    let hasDenominator =
        Namespaced_IRI.parse _namespace_name "hasDenominator" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#frequencyOf"></see>
    /// </summary>
    let frequencyOf =
        Namespaced_IRI.parse _namespace_name "frequencyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasFrequency"></see>
    /// </summary>
    let hasFrequency =
        Namespaced_IRI.parse _namespace_name "hasFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasArea"></see>
    /// </summary>
    let hasArea = Namespaced_IRI.parse _namespace_name "hasArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasPhysicalQuantity"></see>
    /// </summary>
    let hasPhysicalQuantity =
        Namespaced_IRI.parse _namespace_name "hasPhysicalQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasQuantity"></see>
    /// </summary>
    let hasQuantity =
        Namespaced_IRI.parse _namespace_name "hasQuantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasCircularity"></see>
    /// </summary>
    let hasCircularity =
        Namespaced_IRI.parse _namespace_name "hasCircularity" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasGrayLevel"></see>
    /// </summary>
    let hasGrayLevel =
        Namespaced_IRI.parse _namespace_name "hasGrayLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasLength"></see>
    /// </summary>
    let hasLength = Namespaced_IRI.parse _namespace_name "hasLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasLowerValue"></see>
    /// </summary>
    let hasLowerValue =
        Namespaced_IRI.parse _namespace_name "hasLowerValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMass"></see>
    /// </summary>
    let hasMass = Namespaced_IRI.parse _namespace_name "hasMass" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMaximum"></see>
    /// </summary>
    let hasMaximum = Namespaced_IRI.parse _namespace_name "hasMaximum" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMeasuring"></see>
    /// </summary>
    let hasMeasuring =
        Namespaced_IRI.parse _namespace_name "hasMeasuring" |> NamespacedName

    /// <summary>
    /// A triple of the form '?list quant:hasMedian ?median' triggers in an N3 rule backward rules to calculate a median.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMedian"></see></summary>
    let hasMedian = Namespaced_IRI.parse _namespace_name "hasMedian" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMinimum"></see>
    /// </summary>
    let hasMinimum = Namespaced_IRI.parse _namespace_name "hasMinimum" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasPart"></see>
    /// </summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasTotal"></see>
    /// </summary>
    let hasTotal = Namespaced_IRI.parse _namespace_name "hasTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasUpperValue"></see>
    /// </summary>
    let hasUpperValue =
        Namespaced_IRI.parse _namespace_name "hasUpperValue" |> NamespacedName

    /// <summary>
    /// Used in an N3 rule to calculate a value decrease.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueDecrease"></see></summary>
    let hasValueDecrease =
        Namespaced_IRI.parse _namespace_name "hasValueDecrease" |> NamespacedName

    /// <summary>
    /// Used in an N3 rule to calculate a value deficit.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueDeficit"></see></summary>
    let hasValueDeficit =
        Namespaced_IRI.parse _namespace_name "hasValueDeficit" |> NamespacedName

    /// <summary>
    /// Used in an N3 rule to calculate a value excess.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueExcess"></see></summary>
    let hasValueExcess =
        Namespaced_IRI.parse _namespace_name "hasValueExcess" |> NamespacedName

    /// <summary>
    /// Used in an N3 rule to calculate a value increase.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueIncrease"></see></summary>
    let hasValueIncrease =
        Namespaced_IRI.parse _namespace_name "hasValueIncrease" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasVolume"></see>
    /// </summary>
    let hasVolume = Namespaced_IRI.parse _namespace_name "hasVolume" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#lengthOf"></see>
    /// </summary>
    let lengthOf = Namespaced_IRI.parse _namespace_name "lengthOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#massOf"></see>
    /// </summary>
    let massOf = Namespaced_IRI.parse _namespace_name "massOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#maximumOf"></see>
    /// </summary>
    let maximumOf = Namespaced_IRI.parse _namespace_name "maximumOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measuredBy"></see>
    /// </summary>
    let measuredBy = Namespaced_IRI.parse _namespace_name "measuredBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measuringOf"></see>
    /// </summary>
    let measuringOf =
        Namespaced_IRI.parse _namespace_name "measuringOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#medianOf"></see>
    /// </summary>
    let medianOf = Namespaced_IRI.parse _namespace_name "medianOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#minimumOf"></see>
    /// </summary>
    let minimumOf = Namespaced_IRI.parse _namespace_name "minimumOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#numberOf"></see>
    /// </summary>
    let numberOf = Namespaced_IRI.parse _namespace_name "numberOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#numeratorOf"></see>
    /// </summary>
    let numeratorOf =
        Namespaced_IRI.parse _namespace_name "numeratorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#partOf"></see>
    /// </summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percentageOf"></see>
    /// </summary>
    let percentageOf =
        Namespaced_IRI.parse _namespace_name "percentageOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percentageThat"></see>
    /// </summary>
    let percentageThat =
        Namespaced_IRI.parse _namespace_name "percentageThat" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#totalOf"></see>
    /// </summary>
    let totalOf = Namespaced_IRI.parse _namespace_name "totalOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#valueOf"></see>
    /// </summary>
    let valueOf = Namespaced_IRI.parse _namespace_name "valueOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#volumeOf"></see>
    /// </summary>
    let volumeOf = Namespaced_IRI.parse _namespace_name "volumeOf" |> NamespacedName
