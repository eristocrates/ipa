namespace http.eulersharp.sourceforge.net._2003._03swap.quantities.hash

open DoxAletheia

module swap_quantities =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/quantities#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The higher an accuracy, the more test results are true.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Accuracy"></see></summary>
    let Accuracy = _prefix "Accuracy"
    /// <summary>
    /// E.g. 1 g sugar/20 mL water = 0,05 g sugar/mL water
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Ratio"></see></summary>
    let Ratio = _prefix "Ratio"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AmountOfSubstance"></see>
    /// </summary>
    let AmountOfSubstance = _prefix "AmountOfSubstance"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#PhysicalQuantity"></see>
    /// </summary>
    let PhysicalQuantity = _prefix "PhysicalQuantity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AmountOfSubstanceConcentration"></see>
    /// </summary>
    let AmountOfSubstanceConcentration = _prefix "AmountOfSubstanceConcentration"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Quantity"></see>
    /// </summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Area"></see>
    /// </summary>
    let Area = _prefix "Area"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AreaMeasurement"></see>
    /// </summary>
    let AreaMeasurement = _prefix "AreaMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measurement"></see>
    /// </summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measurementOf"></see>
    /// </summary>
    let measurementOf = _prefix "measurementOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasUnit"></see>
    /// </summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#unitOf"></see>
    /// </summary>
    let unitOf = _prefix "unitOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArealDensity"></see>
    /// </summary>
    let ArealDensity = _prefix "ArealDensity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArealDensityMeasurement"></see>
    /// </summary>
    let ArealDensityMeasurement = _prefix "ArealDensityMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArithmeticMean"></see>
    /// </summary>
    let ArithmeticMean = _prefix "ArithmeticMean"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Average"></see>
    /// </summary>
    let Average = _prefix "Average"
    /// <summary>
    /// The higher an aspecificity, the more false positive cases are detected, e.g. the more healthy people are considered sick.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Aspecificity"></see></summary>
    let Aspecificity = _prefix "Aspecificity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Circularity"></see>
    /// </summary>
    let Circularity = _prefix "Circularity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Concentration"></see>
    /// </summary>
    let Concentration = _prefix "Concentration"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ConcentrationMeasurement"></see>
    /// </summary>
    let ConcentrationMeasurement = _prefix "ConcentrationMeasurement"
    /// <summary>
    /// Quantity having a smaller measurement value than a reference.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Decreased"></see></summary>
    let Decreased = _prefix "Decreased"
    /// <summary>
    /// Quantity having a smaller measurement value than a normative reference value range.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Deficient"></see></summary>
    let Deficient = _prefix "Deficient"
    /// <summary>
    /// E.g. 20 mL water in 1 g sugar/20 mL water
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Denominator"></see></summary>
    let Denominator = _prefix "Denominator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#DigitalSize"></see>
    /// </summary>
    let DigitalSize = _prefix "DigitalSize"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#DigitalSizeMeasurement"></see>
    /// </summary>
    let DigitalSizeMeasurement = _prefix "DigitalSizeMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ElectricalResistance"></see>
    /// </summary>
    let ElectricalResistance = _prefix "ElectricalResistance"
    /// <summary>
    /// Quantity having a bigger measurement value than a normative reference value range.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Excessive"></see></summary>
    let Excessive = _prefix "Excessive"
    /// <summary>
    /// E.g. quantity 'percentage', its measurement having factor 'percent' or '0.01'.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Factor"></see></summary>
    let Factor = _prefix "Factor"
    /// <summary>
    /// The higher a false discovery rate, the more positive test results are false.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FalseDiscoveryRate"></see></summary>
    let FalseDiscoveryRate = _prefix "FalseDiscoveryRate"
    /// <summary>
    /// The higher a false negative rate, the more true positive cases go undetected, e.g. the more sick people are considered healthy.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FalseNegativeRate"></see></summary>
    let FalseNegativeRate = _prefix "FalseNegativeRate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Frequency"></see>
    /// </summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasNumerator"></see>
    /// </summary>
    let hasNumerator = _prefix "hasNumerator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NumberOfEvents"></see>
    /// </summary>
    let NumberOfEvents = _prefix "NumberOfEvents"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FrequencyMeasurement"></see>
    /// </summary>
    let FrequencyMeasurement = _prefix "FrequencyMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#GrayLevel"></see>
    /// </summary>
    let GrayLevel = _prefix "GrayLevel"
    /// <summary>
    /// Quantity having a bigger measurement value than a reference.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Increased"></see></summary>
    let Increased = _prefix "Increased"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Length"></see>
    /// </summary>
    let Length = _prefix "Length"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#LengthMeasurement"></see>
    /// </summary>
    let LengthMeasurement = _prefix "LengthMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Mass"></see>
    /// </summary>
    let Mass = _prefix "Mass"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassConcentration"></see>
    /// </summary>
    let MassConcentration = _prefix "MassConcentration"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassConcentrationMeasurement"></see>
    /// </summary>
    let MassConcentrationMeasurement = _prefix "MassConcentrationMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassMeasurement"></see>
    /// </summary>
    let MassMeasurement = _prefix "MassMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Maximum"></see>
    /// </summary>
    let Maximum = _prefix "Maximum"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Number"></see>
    /// </summary>
    let Number = _prefix "Number"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measuring"></see>
    /// </summary>
    let Measuring = _prefix "Measuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measurer"></see>
    /// </summary>
    let Measurer = _prefix "Measurer"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Median"></see>
    /// </summary>
    let Median = _prefix "Median"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Minimum"></see>
    /// </summary>
    let Minimum = _prefix "Minimum"
    /// <summary>
    /// The higher a negative predictive value, the more negative test results are true.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NegativePredictiveValue"></see></summary>
    let NegativePredictiveValue = _prefix "NegativePredictiveValue"
    /// <summary>
    /// Quantity having a measurement value within a normative reference value range.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Normal"></see></summary>
    let Normal = _prefix "Normal"
    /// <summary>
    /// Quantity having a not a bigger measurement value than a normative reference value range.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NotExcessive"></see></summary>
    let NotExcessive = _prefix "NotExcessive"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NotShort"></see>
    /// </summary>
    let NotShort = _prefix "NotShort"
    /// <summary>
    /// E.g. 1 g sugar in 1 g sugar/20 mL water
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Numerator"></see></summary>
    let Numerator = _prefix "Numerator"
    /// <summary>
    /// E.g. frequency of drug intake
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#OnceADay"></see></summary>
    let OnceADay = _prefix "OnceADay"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Part"></see>
    /// </summary>
    let Part = _prefix "Part"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Percentage"></see>
    /// </summary>
    let Percentage = _prefix "Percentage"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#PercentageMeasurement"></see>
    /// </summary>
    let PercentageMeasurement = _prefix "PercentageMeasurement"
    /// <summary>
    /// E.g. 'per cent' is factor of 'percentage measurement'.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasFactor"></see></summary>
    let hasFactor = _prefix "hasFactor"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percent"></see>
    /// </summary>
    let percent = _prefix "percent"
    /// <summary>
    /// The higher a precision, the more positive test results are true.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Precision"></see></summary>
    let Precision = _prefix "Precision"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Pressure"></see>
    /// </summary>
    let Pressure = _prefix "Pressure"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Probability"></see>
    /// </summary>
    let Probability = _prefix "Probability"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Sample"></see>
    /// </summary>
    let Sample = _prefix "Sample"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#SampleSize"></see>
    /// </summary>
    let SampleSize = _prefix "SampleSize"
    /// <summary>
    /// The higher a sensitivity, the fewer true positive cases go undetected, e.g. the fewer sick people are considered healthy.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Sensitivity"></see></summary>
    let Sensitivity = _prefix "Sensitivity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Short"></see>
    /// </summary>
    let Short = _prefix "Short"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#SolutionConcentration"></see>
    /// </summary>
    let SolutionConcentration = _prefix "SolutionConcentration"
    /// <summary>
    /// The higher a specificity, the more true negative cases are detected, e.g. the fewer healthy people are considered sick.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Specificity"></see></summary>
    let Specificity = _prefix "Specificity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Speed"></see>
    /// </summary>
    let Speed = _prefix "Speed"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Temperature"></see>
    /// </summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#TemperatureMeasurement"></see>
    /// </summary>
    let TemperatureMeasurement = _prefix "TemperatureMeasurement"
    /// <summary>
    /// E.g. frequency of drug intake
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ThriceADay"></see></summary>
    let ThriceADay = _prefix "ThriceADay"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Time"></see>
    /// </summary>
    let Time = _prefix "Time"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Total"></see>
    /// </summary>
    let Total = _prefix "Total"
    /// <summary>
    /// E.g. frequency of drug intake
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#TwiceADay"></see></summary>
    let TwiceADay = _prefix "TwiceADay"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Velocity"></see>
    /// </summary>
    let Velocity = _prefix "Velocity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Volume"></see>
    /// </summary>
    let Volume = _prefix "Volume"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeFLowRate"></see>
    /// </summary>
    let VolumeFLowRate = _prefix "VolumeFLowRate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeFLowRateMeasurement"></see>
    /// </summary>
    let VolumeFLowRateMeasurement = _prefix "VolumeFLowRateMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeMeasurement"></see>
    /// </summary>
    let VolumeMeasurement = _prefix "VolumeMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#areaOf"></see>
    /// </summary>
    let areaOf = _prefix "areaOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#physicalQuantityOf"></see>
    /// </summary>
    let physicalQuantityOf = _prefix "physicalQuantityOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#averageOf"></see>
    /// </summary>
    let averageOf = _prefix "averageOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#quantityOf"></see>
    /// </summary>
    let quantityOf = _prefix "quantityOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasAverage"></see>
    /// </summary>
    let hasAverage = _prefix "hasAverage"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#convertedFrom"></see>
    /// </summary>
    let convertedFrom = _prefix "convertedFrom"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#convertedTo"></see>
    /// </summary>
    let convertedTo = _prefix "convertedTo"
    /// <summary>
    /// Used in conclusion of a rule with in its antecedent a calculation of a value with a built-in.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#counts"></see></summary>
    let counts = _prefix "counts"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasNumber"></see>
    /// </summary>
    let hasNumber = _prefix "hasNumber"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMeasurement"></see>
    /// </summary>
    let hasMeasurement = _prefix "hasMeasurement"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#denominatorOf"></see>
    /// </summary>
    let denominatorOf = _prefix "denominatorOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasDenominator"></see>
    /// </summary>
    let hasDenominator = _prefix "hasDenominator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#frequencyOf"></see>
    /// </summary>
    let frequencyOf = _prefix "frequencyOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasFrequency"></see>
    /// </summary>
    let hasFrequency = _prefix "hasFrequency"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasArea"></see>
    /// </summary>
    let hasArea = _prefix "hasArea"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasPhysicalQuantity"></see>
    /// </summary>
    let hasPhysicalQuantity = _prefix "hasPhysicalQuantity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasQuantity"></see>
    /// </summary>
    let hasQuantity = _prefix "hasQuantity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasCircularity"></see>
    /// </summary>
    let hasCircularity = _prefix "hasCircularity"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasGrayLevel"></see>
    /// </summary>
    let hasGrayLevel = _prefix "hasGrayLevel"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasLength"></see>
    /// </summary>
    let hasLength = _prefix "hasLength"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasLowerValue"></see>
    /// </summary>
    let hasLowerValue = _prefix "hasLowerValue"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMass"></see>
    /// </summary>
    let hasMass = _prefix "hasMass"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMaximum"></see>
    /// </summary>
    let hasMaximum = _prefix "hasMaximum"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMeasuring"></see>
    /// </summary>
    let hasMeasuring = _prefix "hasMeasuring"
    /// <summary>
    /// A triple of the form '?list quant:hasMedian ?median' triggers in an N3 rule backward rules to calculate a median.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMedian"></see></summary>
    let hasMedian = _prefix "hasMedian"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMinimum"></see>
    /// </summary>
    let hasMinimum = _prefix "hasMinimum"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasPart"></see>
    /// </summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasTotal"></see>
    /// </summary>
    let hasTotal = _prefix "hasTotal"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasUpperValue"></see>
    /// </summary>
    let hasUpperValue = _prefix "hasUpperValue"
    /// <summary>
    /// Used in an N3 rule to calculate a value decrease.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueDecrease"></see></summary>
    let hasValueDecrease = _prefix "hasValueDecrease"
    /// <summary>
    /// Used in an N3 rule to calculate a value deficit.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueDeficit"></see></summary>
    let hasValueDeficit = _prefix "hasValueDeficit"
    /// <summary>
    /// Used in an N3 rule to calculate a value excess.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueExcess"></see></summary>
    let hasValueExcess = _prefix "hasValueExcess"
    /// <summary>
    /// Used in an N3 rule to calculate a value increase.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueIncrease"></see></summary>
    let hasValueIncrease = _prefix "hasValueIncrease"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasVolume"></see>
    /// </summary>
    let hasVolume = _prefix "hasVolume"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#lengthOf"></see>
    /// </summary>
    let lengthOf = _prefix "lengthOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#massOf"></see>
    /// </summary>
    let massOf = _prefix "massOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#maximumOf"></see>
    /// </summary>
    let maximumOf = _prefix "maximumOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measuredBy"></see>
    /// </summary>
    let measuredBy = _prefix "measuredBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measuringOf"></see>
    /// </summary>
    let measuringOf = _prefix "measuringOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#medianOf"></see>
    /// </summary>
    let medianOf = _prefix "medianOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#minimumOf"></see>
    /// </summary>
    let minimumOf = _prefix "minimumOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#numberOf"></see>
    /// </summary>
    let numberOf = _prefix "numberOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#numeratorOf"></see>
    /// </summary>
    let numeratorOf = _prefix "numeratorOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#partOf"></see>
    /// </summary>
    let partOf = _prefix "partOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percentageOf"></see>
    /// </summary>
    let percentageOf = _prefix "percentageOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percentageThat"></see>
    /// </summary>
    let percentageThat = _prefix "percentageThat"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#totalOf"></see>
    /// </summary>
    let totalOf = _prefix "totalOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#valueOf"></see>
    /// </summary>
    let valueOf = _prefix "valueOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/quantities#volumeOf"></see>
    /// </summary>
    let volumeOf = _prefix "volumeOf"
