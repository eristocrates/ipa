namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.Analytics.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_utl_alx =
    let _namespace_iri = Namespace_Iri fibo_fnd_utl_alx |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-utl-alx:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Analytics Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_utl_alx, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:AnnualizedStandardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"annualized standard deviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AnnualizedStandardDeviation">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AnnualizedStandardDeviation</seealso>
    let AnnualizedStandardDeviation =
        Prefixed_Name(fibo_fnd_utl_alx, "AnnualizedStandardDeviation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:ArithmeticMean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"arithmetic mean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ArithmeticMean">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ArithmeticMean</seealso>
    let ArithmeticMean =
        Prefixed_Name(fibo_fnd_utl_alx, "ArithmeticMean") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:AverageAbsoluteDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"average absolute deviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AverageAbsoluteDeviation">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AverageAbsoluteDeviation</seealso>
    let AverageAbsoluteDeviation =
        Prefixed_Name(fibo_fnd_utl_alx, "AverageAbsoluteDeviation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:Difference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"difference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Difference">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Difference</seealso>
    let Difference = Prefixed_Name(fibo_fnd_utl_alx, "Difference") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-utl-alx:Dispersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dispersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Dispersion">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Dispersion</seealso>
    let Dispersion = Prefixed_Name(fibo_fnd_utl_alx, "Dispersion") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:FinitePopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"finite population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/FinitePopulation">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/FinitePopulation</seealso>
    let FinitePopulation =
        Prefixed_Name(fibo_fnd_utl_alx, "FinitePopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:Formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Formula">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Formula</seealso>
    let Formula = Prefixed_Name(fibo_fnd_utl_alx, "Formula") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-utl-alx:GeometricMean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"geometric mean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/GeometricMean">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/GeometricMean</seealso>
    let GeometricMean = Prefixed_Name(fibo_fnd_utl_alx, "GeometricMean") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:KeyPerformanceIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"key performance indicator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/KeyPerformanceIndicator">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/KeyPerformanceIndicator</seealso>
    let KeyPerformanceIndicator =
        Prefixed_Name(fibo_fnd_utl_alx, "KeyPerformanceIndicator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:Mean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Mean">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Mean</seealso>
    let Mean = Prefixed_Name(fibo_fnd_utl_alx, "Mean") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-utl-alx:Median</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"median"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Median">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Median</seealso>
    let Median = Prefixed_Name(fibo_fnd_utl_alx, "Median") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:MedianAbsoluteDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"median absolute deviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/MedianAbsoluteDeviation">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/MedianAbsoluteDeviation</seealso>
    let MedianAbsoluteDeviation =
        Prefixed_Name(fibo_fnd_utl_alx, "MedianAbsoluteDeviation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:NumericIndexValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"numeric index value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/NumericIndexValue">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/NumericIndexValue</seealso>
    let NumericIndexValue =
        Prefixed_Name(fibo_fnd_utl_alx, "NumericIndexValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:QualifiedMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"qualified measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/QualifiedMeasure">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/QualifiedMeasure</seealso>
    let QualifiedMeasure =
        Prefixed_Name(fibo_fnd_utl_alx, "QualifiedMeasure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:SamplingVariance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sampling variance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/SamplingVariance">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/SamplingVariance</seealso>
    let SamplingVariance =
        Prefixed_Name(fibo_fnd_utl_alx, "SamplingVariance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:ScopedMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scoped measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ScopedMeasure">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ScopedMeasure</seealso>
    let ScopedMeasure = Prefixed_Name(fibo_fnd_utl_alx, "ScopedMeasure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:StandardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"standard deviation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StandardDeviation">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StandardDeviation</seealso>
    let StandardDeviation =
        Prefixed_Name(fibo_fnd_utl_alx, "StandardDeviation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:StatisticalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalArea">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalArea</seealso>
    let StatisticalArea =
        Prefixed_Name(fibo_fnd_utl_alx, "StatisticalArea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:StatisticalAreaIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical area identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalAreaIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalAreaIdentifier</seealso>
    let StatisticalAreaIdentifier =
        Prefixed_Name(fibo_fnd_utl_alx, "StatisticalAreaIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:StatisticalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalMeasure">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalMeasure</seealso>
    let StatisticalMeasure =
        Prefixed_Name(fibo_fnd_utl_alx, "StatisticalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:StatisticalPopulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalPopulation">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalPopulation</seealso>
    let StatisticalPopulation =
        Prefixed_Name(fibo_fnd_utl_alx, "StatisticalPopulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:StatisticalProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalProgram">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalProgram</seealso>
    let StatisticalProgram =
        Prefixed_Name(fibo_fnd_utl_alx, "StatisticalProgram") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:StatisticalUniverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical universe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalUniverse">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalUniverse</seealso>
    let StatisticalUniverse =
        Prefixed_Name(fibo_fnd_utl_alx, "StatisticalUniverse") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:Variance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"variance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Variance">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Variance</seealso>
    let Variance = Prefixed_Name(fibo_fnd_utl_alx, "Variance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:WeightingFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weighting function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/WeightingFunction">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/WeightingFunction</seealso>
    let WeightingFunction =
        Prefixed_Name(fibo_fnd_utl_alx, "WeightingFunction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasFixedComparativeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has fixed comparative date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFixedComparativeDate">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFixedComparativeDate</seealso>
    let hasFixedComparativeDate =
        Prefixed_Name(fibo_fnd_utl_alx, "hasFixedComparativeDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFormula">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFormula</seealso>
    let hasFormula = Prefixed_Name(fibo_fnd_utl_alx, "hasFormula") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasMeasurementDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has measurement date time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementDateTime">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementDateTime</seealso>
    let hasMeasurementDateTime =
        Prefixed_Name(fibo_fnd_utl_alx, "hasMeasurementDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasMeasurementPeriodInMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has measurement period in months"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementPeriodInMonths">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementPeriodInMonths</seealso>
    let hasMeasurementPeriodInMonths =
        Prefixed_Name(fibo_fnd_utl_alx, "hasMeasurementPeriodInMonths") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasMinuend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has minuend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMinuend">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMinuend</seealso>
    let hasMinuend = Prefixed_Name(fibo_fnd_utl_alx, "hasMinuend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasNumberOfEntries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has number of entries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasNumberOfEntries">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasNumberOfEntries</seealso>
    let hasNumberOfEntries =
        Prefixed_Name(fibo_fnd_utl_alx, "hasNumberOfEntries") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasObservedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has observed value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasObservedValue">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasObservedValue</seealso>
    let hasObservedValue =
        Prefixed_Name(fibo_fnd_utl_alx, "hasObservedValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasPeriodicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has periodicity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPeriodicity">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPeriodicity</seealso>
    let hasPeriodicity =
        Prefixed_Name(fibo_fnd_utl_alx, "hasPeriodicity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasPopulationSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has population size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPopulationSize">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPopulationSize</seealso>
    let hasPopulationSize =
        Prefixed_Name(fibo_fnd_utl_alx, "hasPopulationSize") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasReferencePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has reference period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReferencePeriod">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReferencePeriod</seealso>
    let hasReferencePeriod =
        Prefixed_Name(fibo_fnd_utl_alx, "hasReferencePeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasRelativeComparativeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relative comparative date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativeDate">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativeDate</seealso>
    let hasRelativeComparativeDate =
        Prefixed_Name(fibo_fnd_utl_alx, "hasRelativeComparativeDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasRelativeComparativePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has relative comparative period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativePeriod">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativePeriod</seealso>
    let hasRelativeComparativePeriod =
        Prefixed_Name(fibo_fnd_utl_alx, "hasRelativeComparativePeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasReleaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has release date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDate">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDate</seealso>
    let hasReleaseDate =
        Prefixed_Name(fibo_fnd_utl_alx, "hasReleaseDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasReleaseDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has release date and time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDateTime">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDateTime</seealso>
    let hasReleaseDateTime =
        Prefixed_Name(fibo_fnd_utl_alx, "hasReleaseDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasSubtrahend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has subtrahend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasSubtrahend">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasSubtrahend</seealso>
    let hasSubtrahend = Prefixed_Name(fibo_fnd_utl_alx, "hasSubtrahend") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasTargetValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has target value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasTargetValue">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasTargetValue</seealso>
    let hasTargetValue =
        Prefixed_Name(fibo_fnd_utl_alx, "hasTargetValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasUniverseSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has universe size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasUniverseSize">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasUniverseSize</seealso>
    let hasUniverseSize =
        Prefixed_Name(fibo_fnd_utl_alx, "hasUniverseSize") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:hasWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has weight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasWeight">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasWeight</seealso>
    let hasWeight = Prefixed_Name(fibo_fnd_utl_alx, "hasWeight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:isCalculatedViaMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is calculated via methodology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isCalculatedViaMethodology">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isCalculatedViaMethodology</seealso>
    let isCalculatedViaMethodology =
        Prefixed_Name(fibo_fnd_utl_alx, "isCalculatedViaMethodology") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-alx:isEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is estimate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isEstimate">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isEstimate</seealso>
    let isEstimate = Prefixed_Name(fibo_fnd_utl_alx, "isEstimate") |> PrefixedName
