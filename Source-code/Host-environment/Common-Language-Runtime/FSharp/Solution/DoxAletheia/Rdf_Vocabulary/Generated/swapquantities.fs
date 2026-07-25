namespace http.eulersharp.sourceforge.net._2003._03swap.quantities.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapquantities =
    let _namespace_iri = Namespace_Iri swapquantities |> NamespaceIRI
    /// <summary>
    ///   <para>swapquantities:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#">http://eulersharp.sourceforge.net/2003/03swap/quantities#</seealso>
    let _prefix_iri = Prefixed_Name(swapquantities, "") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:AmountOfSubstanceConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>amount-of-substance concentration</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AmountOfSubstanceConcentration">http://eulersharp.sourceforge.net/2003/03swap/quantities#AmountOfSubstanceConcentration</seealso>
    let AmountOfSubstanceConcentration =
        Prefixed_Name(swapquantities, "AmountOfSubstanceConcentration") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>area</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Area">http://eulersharp.sourceforge.net/2003/03swap/quantities#Area</seealso>
    let Area = Prefixed_Name(swapquantities, "Area") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#Measurement</seealso>
    let Measurement = Prefixed_Name(swapquantities, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:measurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>measurement of</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measurementOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#measurementOf</seealso>
    let measurementOf = Prefixed_Name(swapquantities, "measurementOf") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:AmountOfSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>amount of substance</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AmountOfSubstance">http://eulersharp.sourceforge.net/2003/03swap/quantities#AmountOfSubstance</seealso>
    let AmountOfSubstance =
        Prefixed_Name(swapquantities, "AmountOfSubstance") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:massOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#massOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#massOf</seealso>
    let massOf = Prefixed_Name(swapquantities, "massOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Ratio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. 1 g sugar/20 mL water = 0,05 g sugar/mL water</para>
    /// labels<para>ratio</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Ratio">http://eulersharp.sourceforge.net/2003/03swap/quantities#Ratio</seealso>
    let Ratio = Prefixed_Name(swapquantities, "Ratio") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>quantity</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Quantity">http://eulersharp.sourceforge.net/2003/03swap/quantities#Quantity</seealso>
    let Quantity = Prefixed_Name(swapquantities, "Quantity") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasUnit">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasUnit</seealso>
    let hasUnit = Prefixed_Name(swapquantities, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Average</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>average</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Average">http://eulersharp.sourceforge.net/2003/03swap/quantities#Average</seealso>
    let Average = Prefixed_Name(swapquantities, "Average") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Specificity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The higher a specificity, the more true negative cases are detected, e.g. the fewer healthy people are considered sick.</para>
    /// labels<para>specificity</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Specificity">http://eulersharp.sourceforge.net/2003/03swap/quantities#Specificity</seealso>
    let Specificity = Prefixed_Name(swapquantities, "Specificity") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:PhysicalQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>physical quantity</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#PhysicalQuantity">http://eulersharp.sourceforge.net/2003/03swap/quantities#PhysicalQuantity</seealso>
    let PhysicalQuantity =
        Prefixed_Name(swapquantities, "PhysicalQuantity") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:AreaMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>area measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#AreaMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#AreaMeasurement</seealso>
    let AreaMeasurement =
        Prefixed_Name(swapquantities, "AreaMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:unitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#unitOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#unitOf</seealso>
    let unitOf = Prefixed_Name(swapquantities, "unitOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Numerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. 1 g sugar in 1 g sugar/20 mL water</para>
    /// labels<para>numerator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Numerator">http://eulersharp.sourceforge.net/2003/03swap/quantities#Numerator</seealso>
    let Numerator = Prefixed_Name(swapquantities, "Numerator") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:OnceADay</para>
    /// </summary>
    /// <remarks>
    ///   <para>swapquantities:Frequency</para>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. frequency of drug intake</para>
    /// labels<para>once a day</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#OnceADay">http://eulersharp.sourceforge.net/2003/03swap/quantities#OnceADay</seealso>
    let OnceADay = Prefixed_Name(swapquantities, "OnceADay") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>percentage</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Percentage">http://eulersharp.sourceforge.net/2003/03swap/quantities#Percentage</seealso>
    let Percentage = Prefixed_Name(swapquantities, "Percentage") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>E.g. 'per cent' is factor of 'percentage measurement'.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasFactor">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasFactor</seealso>
    let hasFactor = Prefixed_Name(swapquantities, "hasFactor") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>pressure</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Pressure">http://eulersharp.sourceforge.net/2003/03swap/quantities#Pressure</seealso>
    let Pressure = Prefixed_Name(swapquantities, "Pressure") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Maximum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>maximum</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Maximum">http://eulersharp.sourceforge.net/2003/03swap/quantities#Maximum</seealso>
    let Maximum = Prefixed_Name(swapquantities, "Maximum") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Measurer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>measurer</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measurer">http://eulersharp.sourceforge.net/2003/03swap/quantities#Measurer</seealso>
    let Measurer = Prefixed_Name(swapquantities, "Measurer") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Minimum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>minimum</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Minimum">http://eulersharp.sourceforge.net/2003/03swap/quantities#Minimum</seealso>
    let Minimum = Prefixed_Name(swapquantities, "Minimum") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:ArealDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>areal density</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArealDensity">http://eulersharp.sourceforge.net/2003/03swap/quantities#ArealDensity</seealso>
    let ArealDensity = Prefixed_Name(swapquantities, "ArealDensity") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:ArealDensityMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>areal density measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArealDensityMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#ArealDensityMeasurement</seealso>
    let ArealDensityMeasurement =
        Prefixed_Name(swapquantities, "ArealDensityMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:percent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>swapquantities:Factor</para>
    ///
    /// labels<para>percent</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percent">http://eulersharp.sourceforge.net/2003/03swap/quantities#percent</seealso>
    let percent = Prefixed_Name(swapquantities, "percent") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Probability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>probability</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Probability">http://eulersharp.sourceforge.net/2003/03swap/quantities#Probability</seealso>
    let Probability = Prefixed_Name(swapquantities, "Probability") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:SampleSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>sample size</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#SampleSize">http://eulersharp.sourceforge.net/2003/03swap/quantities#SampleSize</seealso>
    let SampleSize = Prefixed_Name(swapquantities, "SampleSize") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Short</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>short</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Short">http://eulersharp.sourceforge.net/2003/03swap/quantities#Short</seealso>
    let Short = Prefixed_Name(swapquantities, "Short") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>speed</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Speed">http://eulersharp.sourceforge.net/2003/03swap/quantities#Speed</seealso>
    let Speed = Prefixed_Name(swapquantities, "Speed") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:TemperatureMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>thermodynamic temperature measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#TemperatureMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#TemperatureMeasurement</seealso>
    let TemperatureMeasurement =
        Prefixed_Name(swapquantities, "TemperatureMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Aspecificity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The higher an aspecificity, the more false positive cases are detected, e.g. the more healthy people are considered sick.</para>
    /// labels<para>aspecificity</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Aspecificity">http://eulersharp.sourceforge.net/2003/03swap/quantities#Aspecificity</seealso>
    let Aspecificity = Prefixed_Name(swapquantities, "Aspecificity") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Concentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>concentration</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Concentration">http://eulersharp.sourceforge.net/2003/03swap/quantities#Concentration</seealso>
    let Concentration = Prefixed_Name(swapquantities, "Concentration") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:VolumeMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>volume measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeMeasurement</seealso>
    let VolumeMeasurement =
        Prefixed_Name(swapquantities, "VolumeMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:convertedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#convertedTo">http://eulersharp.sourceforge.net/2003/03swap/quantities#convertedTo</seealso>
    let convertedTo = Prefixed_Name(swapquantities, "convertedTo") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:frequencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#frequencyOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#frequencyOf</seealso>
    let frequencyOf = Prefixed_Name(swapquantities, "frequencyOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:ArithmeticMean</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>arithmetic mean</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ArithmeticMean">http://eulersharp.sourceforge.net/2003/03swap/quantities#ArithmeticMean</seealso>
    let ArithmeticMean = Prefixed_Name(swapquantities, "ArithmeticMean") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Circularity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>circularity</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Circularity">http://eulersharp.sourceforge.net/2003/03swap/quantities#Circularity</seealso>
    let Circularity = Prefixed_Name(swapquantities, "Circularity") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Deficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///   <para>Quantity having a smaller measurement value than a normative reference value range.</para>
    /// labels<para>deficient</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Deficient">http://eulersharp.sourceforge.net/2003/03swap/quantities#Deficient</seealso>
    let Deficient = Prefixed_Name(swapquantities, "Deficient") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:convertedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#convertedFrom">http://eulersharp.sourceforge.net/2003/03swap/quantities#convertedFrom</seealso>
    let convertedFrom = Prefixed_Name(swapquantities, "convertedFrom") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:counts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used in conclusion of a rule with in its antecedent a calculation of a value with a built-in.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#counts">http://eulersharp.sourceforge.net/2003/03swap/quantities#counts</seealso>
    let counts = Prefixed_Name(swapquantities, "counts") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:denominatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#denominatorOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#denominatorOf</seealso>
    let denominatorOf = Prefixed_Name(swapquantities, "denominatorOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasDenominator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasDenominator">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasDenominator</seealso>
    let hasDenominator = Prefixed_Name(swapquantities, "hasDenominator") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:ConcentrationMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>concentration measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ConcentrationMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#ConcentrationMeasurement</seealso>
    let ConcentrationMeasurement =
        Prefixed_Name(swapquantities, "ConcentrationMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Decreased</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Quantity having a smaller measurement value than a reference.</para>
    /// labels<para>decreased</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Decreased">http://eulersharp.sourceforge.net/2003/03swap/quantities#Decreased</seealso>
    let Decreased = Prefixed_Name(swapquantities, "Decreased") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Denominator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. 20 mL water in 1 g sugar/20 mL water</para>
    /// labels<para>denominator</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Denominator">http://eulersharp.sourceforge.net/2003/03swap/quantities#Denominator</seealso>
    let Denominator = Prefixed_Name(swapquantities, "Denominator") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:DigitalSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital size</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#DigitalSize">http://eulersharp.sourceforge.net/2003/03swap/quantities#DigitalSize</seealso>
    let DigitalSize = Prefixed_Name(swapquantities, "DigitalSize") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasCircularity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasCircularity">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasCircularity</seealso>
    let hasCircularity = Prefixed_Name(swapquantities, "hasCircularity") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasGrayLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasGrayLevel">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasGrayLevel</seealso>
    let hasGrayLevel = Prefixed_Name(swapquantities, "hasGrayLevel") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasLowerValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasLowerValue">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasLowerValue</seealso>
    let hasLowerValue = Prefixed_Name(swapquantities, "hasLowerValue") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMass">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMass</seealso>
    let hasMass = Prefixed_Name(swapquantities, "hasMass") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasMaximum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMaximum">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMaximum</seealso>
    let hasMaximum = Prefixed_Name(swapquantities, "hasMaximum") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasMinimum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMinimum">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMinimum</seealso>
    let hasMinimum = Prefixed_Name(swapquantities, "hasMinimum") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Total</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>total</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Total">http://eulersharp.sourceforge.net/2003/03swap/quantities#Total</seealso>
    let Total = Prefixed_Name(swapquantities, "Total") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>volume</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Volume">http://eulersharp.sourceforge.net/2003/03swap/quantities#Volume</seealso>
    let Volume = Prefixed_Name(swapquantities, "Volume") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:VolumeFLowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>volume fLow rate</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeFLowRate">http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeFLowRate</seealso>
    let VolumeFLowRate = Prefixed_Name(swapquantities, "VolumeFLowRate") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:ElectricalResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>electrical resistance</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ElectricalResistance">http://eulersharp.sourceforge.net/2003/03swap/quantities#ElectricalResistance</seealso>
    let ElectricalResistance =
        Prefixed_Name(swapquantities, "ElectricalResistance") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasLength">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasLength</seealso>
    let hasLength = Prefixed_Name(swapquantities, "hasLength") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasMeasuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMeasuring">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMeasuring</seealso>
    let hasMeasuring = Prefixed_Name(swapquantities, "hasMeasuring") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has part</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasPart">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasPart</seealso>
    let hasPart = Prefixed_Name(swapquantities, "hasPart") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:DigitalSizeMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital size measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#DigitalSizeMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#DigitalSizeMeasurement</seealso>
    let DigitalSizeMeasurement =
        Prefixed_Name(swapquantities, "DigitalSizeMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Excessive</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Quantity having a bigger measurement value than a normative reference value range.</para>
    /// labels<para>excessive</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Excessive">http://eulersharp.sourceforge.net/2003/03swap/quantities#Excessive</seealso>
    let Excessive = Prefixed_Name(swapquantities, "Excessive") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. quantity 'percentage', its measurement having factor 'percent' or '0.01'.</para>
    /// labels<para>factor</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Factor">http://eulersharp.sourceforge.net/2003/03swap/quantities#Factor</seealso>
    let Factor = Prefixed_Name(swapquantities, "Factor") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:FalseDiscoveryRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The higher a false discovery rate, the more positive test results are false.</para>
    /// labels<para>false discovery rate</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FalseDiscoveryRate">http://eulersharp.sourceforge.net/2003/03swap/quantities#FalseDiscoveryRate</seealso>
    let FalseDiscoveryRate =
        Prefixed_Name(swapquantities, "FalseDiscoveryRate") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasUpperValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasUpperValue">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasUpperValue</seealso>
    let hasUpperValue = Prefixed_Name(swapquantities, "hasUpperValue") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasValueDeficit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Used in an N3 rule to calculate a value deficit.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueDeficit">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueDeficit</seealso>
    let hasValueDeficit =
        Prefixed_Name(swapquantities, "hasValueDeficit") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasVolume">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasVolume</seealso>
    let hasVolume = Prefixed_Name(swapquantities, "hasVolume") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:maximumOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#maximumOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#maximumOf</seealso>
    let maximumOf = Prefixed_Name(swapquantities, "maximumOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:measuringOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measuringOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#measuringOf</seealso>
    let measuringOf = Prefixed_Name(swapquantities, "measuringOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:minimumOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#minimumOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#minimumOf</seealso>
    let minimumOf = Prefixed_Name(swapquantities, "minimumOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:numberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>number of</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#numberOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#numberOf</seealso>
    let numberOf = Prefixed_Name(swapquantities, "numberOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:percentageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>percentage of</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percentageOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#percentageOf</seealso>
    let percentageOf = Prefixed_Name(swapquantities, "percentageOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:totalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>total of</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#totalOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#totalOf</seealso>
    let totalOf = Prefixed_Name(swapquantities, "totalOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:volumeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#volumeOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#volumeOf</seealso>
    let volumeOf = Prefixed_Name(swapquantities, "volumeOf") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:FalseNegativeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The higher a false negative rate, the more true positive cases go undetected, e.g. the more sick people are considered healthy.</para>
    /// labels<para>false negative rate</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FalseNegativeRate">http://eulersharp.sourceforge.net/2003/03swap/quantities#FalseNegativeRate</seealso>
    let FalseNegativeRate =
        Prefixed_Name(swapquantities, "FalseNegativeRate") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>frequency</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Frequency">http://eulersharp.sourceforge.net/2003/03swap/quantities#Frequency</seealso>
    let Frequency = Prefixed_Name(swapquantities, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasNumerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasNumerator">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasNumerator</seealso>
    let hasNumerator = Prefixed_Name(swapquantities, "hasNumerator") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:FrequencyMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>frequency measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#FrequencyMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#FrequencyMeasurement</seealso>
    let FrequencyMeasurement =
        Prefixed_Name(swapquantities, "FrequencyMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValue">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValue</seealso>
    let hasValue = Prefixed_Name(swapquantities, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasMedian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A triple of the form '?list quant:hasMedian ?median' triggers in an N3 rule backward rules to calculate a median.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMedian">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMedian</seealso>
    let hasMedian = Prefixed_Name(swapquantities, "hasMedian") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has total</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasTotal">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasTotal</seealso>
    let hasTotal = Prefixed_Name(swapquantities, "hasTotal") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasValueDecrease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used in an N3 rule to calculate a value decrease.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueDecrease">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueDecrease</seealso>
    let hasValueDecrease =
        Prefixed_Name(swapquantities, "hasValueDecrease") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasValueExcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Used in an N3 rule to calculate a value excess.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueExcess">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueExcess</seealso>
    let hasValueExcess = Prefixed_Name(swapquantities, "hasValueExcess") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasValueIncrease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Used in an N3 rule to calculate a value increase.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueIncrease">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasValueIncrease</seealso>
    let hasValueIncrease =
        Prefixed_Name(swapquantities, "hasValueIncrease") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:lengthOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#lengthOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#lengthOf</seealso>
    let lengthOf = Prefixed_Name(swapquantities, "lengthOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:measuredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>measured by</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#measuredBy">http://eulersharp.sourceforge.net/2003/03swap/quantities#measuredBy</seealso>
    let measuredBy = Prefixed_Name(swapquantities, "measuredBy") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:medianOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#medianOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#medianOf</seealso>
    let medianOf = Prefixed_Name(swapquantities, "medianOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:numeratorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#numeratorOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#numeratorOf</seealso>
    let numeratorOf = Prefixed_Name(swapquantities, "numeratorOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>part of</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#partOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#partOf</seealso>
    let partOf = Prefixed_Name(swapquantities, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:percentageThat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>percentage that</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#percentageThat">http://eulersharp.sourceforge.net/2003/03swap/quantities#percentageThat</seealso>
    let percentageThat = Prefixed_Name(swapquantities, "percentageThat") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:valueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#valueOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#valueOf</seealso>
    let valueOf = Prefixed_Name(swapquantities, "valueOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:NumberOfEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>number of recurrent events</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NumberOfEvents">http://eulersharp.sourceforge.net/2003/03swap/quantities#NumberOfEvents</seealso>
    let NumberOfEvents = Prefixed_Name(swapquantities, "NumberOfEvents") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:GrayLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>gray level</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#GrayLevel">http://eulersharp.sourceforge.net/2003/03swap/quantities#GrayLevel</seealso>
    let GrayLevel = Prefixed_Name(swapquantities, "GrayLevel") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>length</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Length">http://eulersharp.sourceforge.net/2003/03swap/quantities#Length</seealso>
    let Length = Prefixed_Name(swapquantities, "Length") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Increased</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///   <para>Quantity having a bigger measurement value than a reference.</para>
    /// labels<para>increased</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Increased">http://eulersharp.sourceforge.net/2003/03swap/quantities#Increased</seealso>
    let Increased = Prefixed_Name(swapquantities, "Increased") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:LengthMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>length measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#LengthMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#LengthMeasurement</seealso>
    let LengthMeasurement =
        Prefixed_Name(swapquantities, "LengthMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>mass</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Mass">http://eulersharp.sourceforge.net/2003/03swap/quantities#Mass</seealso>
    let Mass = Prefixed_Name(swapquantities, "Mass") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:MassConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>mass concentration</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassConcentration">http://eulersharp.sourceforge.net/2003/03swap/quantities#MassConcentration</seealso>
    let MassConcentration =
        Prefixed_Name(swapquantities, "MassConcentration") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:MassConcentrationMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>mass concentration measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassConcentrationMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#MassConcentrationMeasurement</seealso>
    let MassConcentrationMeasurement =
        Prefixed_Name(swapquantities, "MassConcentrationMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:MassMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>mass measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#MassMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#MassMeasurement</seealso>
    let MassMeasurement =
        Prefixed_Name(swapquantities, "MassMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>number</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Number">http://eulersharp.sourceforge.net/2003/03swap/quantities#Number</seealso>
    let Number = Prefixed_Name(swapquantities, "Number") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Measuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>measuring</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Measuring">http://eulersharp.sourceforge.net/2003/03swap/quantities#Measuring</seealso>
    let Measuring = Prefixed_Name(swapquantities, "Measuring") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:NegativePredictiveValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The higher a negative predictive value, the more negative test results are true.</para>
    /// labels<para>negative predictive value</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NegativePredictiveValue">http://eulersharp.sourceforge.net/2003/03swap/quantities#NegativePredictiveValue</seealso>
    let NegativePredictiveValue =
        Prefixed_Name(swapquantities, "NegativePredictiveValue") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:NotShort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///
    /// labels<para>not short</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NotShort">http://eulersharp.sourceforge.net/2003/03swap/quantities#NotShort</seealso>
    let NotShort = Prefixed_Name(swapquantities, "NotShort") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Part</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>part</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Part">http://eulersharp.sourceforge.net/2003/03swap/quantities#Part</seealso>
    let Part = Prefixed_Name(swapquantities, "Part") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:PercentageMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>percentage measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#PercentageMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#PercentageMeasurement</seealso>
    let PercentageMeasurement =
        Prefixed_Name(swapquantities, "PercentageMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The higher a precision, the more positive test results are true.</para>
    /// labels<para>precision</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Precision">http://eulersharp.sourceforge.net/2003/03swap/quantities#Precision</seealso>
    let Precision = Prefixed_Name(swapquantities, "Precision") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>sample</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Sample">http://eulersharp.sourceforge.net/2003/03swap/quantities#Sample</seealso>
    let Sample = Prefixed_Name(swapquantities, "Sample") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Sensitivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The higher a sensitivity, the fewer true positive cases go undetected, e.g. the fewer sick people are considered healthy.</para>
    /// labels<para>sensitivity</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Sensitivity">http://eulersharp.sourceforge.net/2003/03swap/quantities#Sensitivity</seealso>
    let Sensitivity = Prefixed_Name(swapquantities, "Sensitivity") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:SolutionConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>solution concentration</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#SolutionConcentration">http://eulersharp.sourceforge.net/2003/03swap/quantities#SolutionConcentration</seealso>
    let SolutionConcentration =
        Prefixed_Name(swapquantities, "SolutionConcentration") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>thermodynamic temperature</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Temperature">http://eulersharp.sourceforge.net/2003/03swap/quantities#Temperature</seealso>
    let Temperature = Prefixed_Name(swapquantities, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:ThriceADay</para>
    /// </summary>
    /// <remarks>
    ///   <para>swapquantities:Frequency</para>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. frequency of drug intake</para>
    /// labels<para>thrice a day</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#ThriceADay">http://eulersharp.sourceforge.net/2003/03swap/quantities#ThriceADay</seealso>
    let ThriceADay = Prefixed_Name(swapquantities, "ThriceADay") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>time</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Time">http://eulersharp.sourceforge.net/2003/03swap/quantities#Time</seealso>
    let Time = Prefixed_Name(swapquantities, "Time") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:TwiceADay</para>
    /// </summary>
    /// <remarks>
    ///   <para>swapquantities:Frequency</para>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. frequency of drug intake</para>
    /// labels<para>twice a day</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#TwiceADay">http://eulersharp.sourceforge.net/2003/03swap/quantities#TwiceADay</seealso>
    let TwiceADay = Prefixed_Name(swapquantities, "TwiceADay") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Velocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>velocity</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Velocity">http://eulersharp.sourceforge.net/2003/03swap/quantities#Velocity</seealso>
    let Velocity = Prefixed_Name(swapquantities, "Velocity") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:VolumeFLowRateMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>volume fLow rate measurement</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeFLowRateMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#VolumeFLowRateMeasurement</seealso>
    let VolumeFLowRateMeasurement =
        Prefixed_Name(swapquantities, "VolumeFLowRateMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:areaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#areaOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#areaOf</seealso>
    let areaOf = Prefixed_Name(swapquantities, "areaOf") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:physicalQuantityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#physicalQuantityOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#physicalQuantityOf</seealso>
    let physicalQuantityOf =
        Prefixed_Name(swapquantities, "physicalQuantityOf") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:averageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#averageOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#averageOf</seealso>
    let averageOf = Prefixed_Name(swapquantities, "averageOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:quantityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#quantityOf">http://eulersharp.sourceforge.net/2003/03swap/quantities#quantityOf</seealso>
    let quantityOf = Prefixed_Name(swapquantities, "quantityOf") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasAverage">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasAverage</seealso>
    let hasAverage = Prefixed_Name(swapquantities, "hasAverage") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has number</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasNumber">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasNumber</seealso>
    let hasNumber = Prefixed_Name(swapquantities, "hasNumber") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMeasurement">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasMeasurement</seealso>
    let hasMeasurement = Prefixed_Name(swapquantities, "hasMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasFrequency">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasFrequency</seealso>
    let hasFrequency = Prefixed_Name(swapquantities, "hasFrequency") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:hasArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasArea">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasArea</seealso>
    let hasArea = Prefixed_Name(swapquantities, "hasArea") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasPhysicalQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasPhysicalQuantity">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasPhysicalQuantity</seealso>
    let hasPhysicalQuantity =
        Prefixed_Name(swapquantities, "hasPhysicalQuantity") |> PrefixedName

    /// <summary>
    ///   <para>swapquantities:hasQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#hasQuantity">http://eulersharp.sourceforge.net/2003/03swap/quantities#hasQuantity</seealso>
    let hasQuantity = Prefixed_Name(swapquantities, "hasQuantity") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Median</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>median</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Median">http://eulersharp.sourceforge.net/2003/03swap/quantities#Median</seealso>
    let Median = Prefixed_Name(swapquantities, "Median") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Normal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///   <para>Quantity having a measurement value within a normative reference value range.</para>
    /// labels<para>normal</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Normal">http://eulersharp.sourceforge.net/2003/03swap/quantities#Normal</seealso>
    let Normal = Prefixed_Name(swapquantities, "Normal") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:NotExcessive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///   <para>Quantity having a not a bigger measurement value than a normative reference value range.</para>
    /// labels<para>not excessive</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#NotExcessive">http://eulersharp.sourceforge.net/2003/03swap/quantities#NotExcessive</seealso>
    let NotExcessive = Prefixed_Name(swapquantities, "NotExcessive") |> PrefixedName
    /// <summary>
    ///   <para>swapquantities:Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The higher an accuracy, the more test results are true.</para>
    /// labels<para>accuracy</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/quantities#Accuracy">http://eulersharp.sourceforge.net/2003/03swap/quantities#Accuracy</seealso>
    let Accuracy = Prefixed_Name(swapquantities, "Accuracy") |> PrefixedName
