#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-utl-alx`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/" "fibo-fnd-utl-alx"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : annualized standard deviation^^xsd:string</para>
    ///   <para>skos:definition : standard deviation for some measure over a specific reference period^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Standard deviation applied to the annual rate of return of an investment provides insights on the historical volatility of that investment. The greater the standard deviation of the price of a security, the greater the volatility. Multiplying monthly standard deviation by the square root of twelve (12) is an industry standard method of approximating annualized standard deviations of monthly returns.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AnnualizedStandardDeviation">fibo-fnd-utl-alx:AnnualizedStandardDeviation</a>
    /// </summary>
    let AnnualizedStandardDeviation = _prefixId.prefix "AnnualizedStandardDeviation"
    /// <summary>
    ///   <para>rdfs:label : arithmetic mean^^xsd:string</para>
    ///   <para>skos:definition : sum of a collection of numbers divided by the number of numbers in the collection^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : While the arithmetic mean is often used to report central tendencies, it is not a robust statistic, meaning that it is greatly influenced by outliers (values that are very much larger or smaller than most of the values). Notably, for skewed distributions, such as the distribution of income for which a few people's incomes are substantially greater than most people's, the arithmetic mean may not accord with one's notion of 'middle', and robust statistics, such as the median, may be a better description of central tendency.^^xsd:string</para>
    ///   <para>cmns-av:synonym : average^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ArithmeticMean">fibo-fnd-utl-alx:ArithmeticMean</a>
    /// </summary>
    let ArithmeticMean = _prefixId.prefix "ArithmeticMean"
    /// <summary>
    ///   <para>rdfs:label : average absolute deviation^^xsd:string</para>
    ///   <para>skos:definition : average of the absolute deviations from a central point^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The central point can be the mean, median, mode, or the result of another measure of central tendency. Absolute deviation is the distance between each value in the data set and that data set's mean or median.^^xsd:string</para>
    ///   <para>cmns-av:synonym : mean absolute deviation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/AverageAbsoluteDeviation">fibo-fnd-utl-alx:AverageAbsoluteDeviation</a>
    /// </summary>
    let AverageAbsoluteDeviation = _prefixId.prefix "AverageAbsoluteDeviation"
    /// <summary>
    ///   <para>rdfs:label : difference^^xsd:string</para>
    ///   <para>skos:definition : quantity by which amounts differ; the remainder left after subtraction of one value from another^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Difference">fibo-fnd-utl-alx:Difference</a>
    /// </summary>
    let Difference = _prefixId.prefix "Difference"
    /// <summary>
    ///   <para>rdfs:label : dispersion^^xsd:string</para>
    ///   <para>skos:definition : degree of scatter or variability shown by observations^^xsd:string</para>
    ///   <para>skos:example : Common examples of measures of statistical dispersion are the variance, standard deviation, and interquartile range. The collection size argument, above, represents the number of elements in the set, if known. The collection of values under consideration is represented as a structured collection in FIBO, typically a sample set derived from a finite population.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=3637^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A measure of statistical dispersion is a nonnegative real number that is zero if all the data are the same and increases as the data become more diverse.^^xsd:stringcmns-av:explanatoryNote : It is usually measured as an average deviation about some central value (e.g. mean deviation, standard deviation) or by an order statistic (e.g. quartile deviation, range) but may also be a mean of deviations of values among themselves (e.g. Gini's mean difference and also standard deviation).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Dispersion">fibo-fnd-utl-alx:Dispersion</a>
    /// </summary>
    let Dispersion = _prefixId.prefix "Dispersion"
    /// <summary>
    ///   <para>rdfs:label : finite population^^xsd:string</para>
    ///   <para>skos:definition : population for which it is possible to count its units^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=3649^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : In statistics, a population is a set of similar items or events of interest for some question or experiment. In other words, a population is the complete group of units to which survey results are to apply. (These units may be persons, animals, objects, businesses, trips, etc.). See http://www.statcan.gc.ca/edu/power-pouvoir/glossary-glossaire/5214842-eng.htm#p.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/FinitePopulation">fibo-fnd-utl-alx:FinitePopulation</a>
    /// </summary>
    let FinitePopulation = _prefixId.prefix "FinitePopulation"
    /// <summary>
    ///   <para>rdfs:label : formula^^xsd:string</para>
    ///   <para>skos:definition : rule expressed in letters and symbols that consists of at least one expression^^xsd:string</para>
    ///   <para>cmns-av:synonym : complex expression^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Formula">fibo-fnd-utl-alx:Formula</a>
    /// </summary>
    let Formula = _prefixId.prefix "Formula"
    /// <summary>
    ///   <para>rdfs:label : geometric mean^^xsd:string</para>
    ///   <para>skos:definition : mean that indicates the central tendency or typical value of a set of numbers by using the product of their values (as opposed to the arithmetic mean which uses their sum)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The geometric mean is defined as the nth root of the product of n numbers. A geometric mean is often used when comparing different items - finding a single 'figure of merit' for these items - when each item has multiple properties that have different numeric ranges. For example, the geometric mean can give a meaningful 'average' to compare two companies which are each rated at 0 to 5 for their environmental sustainability, and are rated at 0 to 100 for their financial viability. If an arithmetic mean were used instead of a geometric mean, the financial viability is given more weight because its numeric range is larger - so a small percentage change in the financial rating (e.g. going from 80 to 90) makes a much larger difference in the arithmetic mean than a large percentage change in environmental sustainability (e.g. going from 2 to 5).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/GeometricMean">fibo-fnd-utl-alx:GeometricMean</a>
    /// </summary>
    let GeometricMean = _prefixId.prefix "GeometricMean"
    /// <summary>
    ///   <para>rdfs:label : key performance indicator^^xsd:string</para>
    ///   <para>skos:definition : measurable target that indicates how an individual or business is performing in terms of meeting its goals^^xsd:string</para>
    ///   <para>skos:example : Examples include profits, sales numbers, employee turnover and average annual expenses.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : KPI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.forbes.com/advisor/business/what-is-a-kpi-definition-examples/^^xsd:anyURIcmns-av:adaptedFrom : https://www.kpi.org/KPI-Basics/^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Although they are both designed to measure performance, KPIs and metrics have different characteristics and are used by businesses in different ways. Metrics are measures used to track progress and evaluate success, while KPIs are metrics tied to specific goals during a certain period of time. KPIs are designed to align with business goals and targets, while metrics evaluate the performance of particular processes.^^xsd:stringcmns-av:explanatoryNote : Key Performance Indicators (KPIs) are the critical (key) quantifiable indicators of progress toward an intended result. KPIs provide a focus for strategic and operational improvement, create an analytical basis for decision making and help focus attention on what matters most. Managing with the use of KPIs includes setting targets (the desired level of performance) and tracking progress against those targets.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/KeyPerformanceIndicator">fibo-fnd-utl-alx:KeyPerformanceIndicator</a>
    /// </summary>
    let KeyPerformanceIndicator = _prefixId.prefix "KeyPerformanceIndicator"
    /// <summary>
    ///   <para>rdfs:label : mean^^xsd:string</para>
    ///   <para>skos:definition : most common measure of central tendency; the average of a set of numbers^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.statcan.gc.ca/edu/power-pouvoir/glossary-glossaire/5214842-eng.htm#m^^xsd:anyURIcmns-av:adaptedFrom : https://stats.oecd.org/glossary/detail.asp?ID=3762^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : When unqualified, the mean usually refers to the expectation of a variate, or to the arithmetic mean of a sample used as an estimate of the expectation.^^xsd:string</para>
    ///   <para>cmns-av:symbol : μ^^xsd:string</para>
    ///   <para>cmns-av:synonym : expected value^^xsd:stringcmns-av:synonym : first (raw) moment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Mean">fibo-fnd-utl-alx:Mean</a>
    /// </summary>
    let Mean = _prefixId.prefix "Mean"
    /// <summary>
    ///   <para>rdfs:label : median^^xsd:string</para>
    ///   <para>skos:definition : value of the variate dividing the total frequency of a data sample, population, or probability distribution, into two halves^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://stats.oecd.org/glossary/detail.asp?ID=3717^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The basic advantage of the median in describing data compared to the mean is that it is not skewed by extremely large or small values, and may provide a better idea of a 'typical' value.^^xsd:stringcmns-av:explanatoryNote : This measure represents the middle value (if n is odd) or the average of the two middle values (if n is even) in an ordered list of data values. The median divides the total frequency distribution into two equal parts: one-half of the cases fall below the median and one-half of the cases exceed the median.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Median">fibo-fnd-utl-alx:Median</a>
    /// </summary>
    let Median = _prefixId.prefix "Median"
    /// <summary>
    ///   <para>rdfs:label : median absolute deviation^^xsd:string</para>
    ///   <para>skos:definition : median of the absolute deviations of observations from the average which may be the arithmetic mean, the median or the mode^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/MedianAbsoluteDeviation">fibo-fnd-utl-alx:MedianAbsoluteDeviation</a>
    /// </summary>
    let MedianAbsoluteDeviation = _prefixId.prefix "MedianAbsoluteDeviation"
    /// <summary>
    ///   <para>rdfs:label : numeric index value^^xsd:string</para>
    ///   <para>skos:definition : numeric value of some aggregate relative to the value of that aggregate as of some date^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.statcan.gc.ca/edu/power-pouvoir/glossary-glossaire/5214842-eng.htm#i^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A mathematical device or number which is used to express the observation (e.g., price level, volume of trade, relative amount etc.) of a given period, in comparison with that of a prior period.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/NumericIndexValue">fibo-fnd-utl-alx:NumericIndexValue</a>
    /// </summary>
    let NumericIndexValue = _prefixId.prefix "NumericIndexValue"
    /// <summary>
    ///   <para>rdfs:label : qualified measure^^xsd:string</para>
    ///   <para>skos:definition : statistical measure that is constrained by features, quantity kinds or units that refine how it is calculated^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/QualifiedMeasure">fibo-fnd-utl-alx:QualifiedMeasure</a>
    /// </summary>
    let QualifiedMeasure = _prefixId.prefix "QualifiedMeasure"
    /// <summary>
    ///   <para>rdfs:label : sampling variance^^xsd:string</para>
    ///   <para>skos:definition : measure of the extent to which the estimate of a characteristic from different possible samples of the same size and the same design differ from one another^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.statcan.gc.ca/pub/12-587-x/12-587-x2003001-eng.pdf^^xsd:anyURIcmns-av:adaptedFrom : https://stats.oecd.org/glossary/detail.asp?ID=3834^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The word 'sampling' can usually be omitted, as being defined by the context or otherwise understood. The sampling variance of a statistic is the square of its standard error.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/SamplingVariance">fibo-fnd-utl-alx:SamplingVariance</a>
    /// </summary>
    let SamplingVariance = _prefixId.prefix "SamplingVariance"
    /// <summary>
    ///   <para>rdfs:label : scoped measure^^xsd:string</para>
    ///   <para>skos:definition : qualified measure that is constrained by filters on the statistical population to which it applies^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that (1) the anchor date reflects the start of the current series, such as 1982-1984 for the CPI, (2) the fixed comparative date might be something like March 2009, if one is comparing a current index against its value at the end of the great recession, (3) the relative comparative date might be something like a month or year ago, depending on the analysis requirements, and (4) the relative comparative period might be a 3 month average prior value, again depending on the analysis requirements.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/ScopedMeasure">fibo-fnd-utl-alx:ScopedMeasure</a>
    /// </summary>
    let ScopedMeasure = _prefixId.prefix "ScopedMeasure"
    /// <summary>
    ///   <para>rdfs:label : standard deviation^^xsd:string</para>
    ///   <para>skos:definition : square root of variance that measures the spread or dispersion around the mean of a data set^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SD^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.statcan.gc.ca/edu/power-pouvoir/glossary-glossaire/5214842-eng.htm#s^^xsd:anyURIcmns-av:adaptedFrom : https://stats.oecd.org/glossary/detail.asp?ID=3845^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The most widely used measure of dispersion of a frequency distribution introduced by K. Pearson (1893). It is equal to the positive square root of the variance. The standard deviation should not be confused with the root mean square deviation.^^xsd:stringcmns-av:explanatoryNote : While standard deviation is the most widely-used measure of spread, using squared deviations, it may not be the most robust.^^xsd:string</para>
    ///   <para>cmns-av:symbol : σ^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StandardDeviation">fibo-fnd-utl-alx:StandardDeviation</a>
    /// </summary>
    let StandardDeviation = _prefixId.prefix "StandardDeviation"
    /// <summary>
    ///   <para>rdfs:label : statistical area^^xsd:string</para>
    ///   <para>skos:definition : physical location that is defined per some program for designating geographic regions for the purposes of tabulating and presenting statistical data^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/display/IND/Statistics+Canada+Census+Information^^xsd:stringcmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalArea">fibo-fnd-utl-alx:StatisticalArea</a>
    /// </summary>
    let StatisticalArea = _prefixId.prefix "StatisticalArea"
    /// <summary>
    ///   <para>rdfs:label : statistical area identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier for a physical location that is defined per a nationally consistent program for designating geographic regions for the purposes of tabulating and presenting statistical data^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/display/IND/Statistics+Canada+Census+Information^^xsd:stringcmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalAreaIdentifier">fibo-fnd-utl-alx:StatisticalAreaIdentifier</a>
    /// </summary>
    let StatisticalAreaIdentifier = _prefixId.prefix "StatisticalAreaIdentifier"
    /// <summary>
    ///   <para>rdfs:label : statistical measure^^xsd:string</para>
    ///   <para>skos:definition : summary (means, mode, total, index, etc.) of the individual quantitative variable values for the statistical units in a specific group (study domain)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=5068^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Statistical measures may consist of several orthogonal characteristics, including (a) whether they reflect an estimate or variable, (b) the datatype, or from a FIBO perspective, nature of the measure (e.g., index, total, ratio, percent, percent change, mean, others), (c) the population (or the universe that applies to the highest level if defined in general) to which the measure applies, and (d) any relevant aspects used to subset or stratify a measure, (i.e., make them apply to a smaller universe).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalMeasure">fibo-fnd-utl-alx:StatisticalMeasure</a>
    /// </summary>
    let StatisticalMeasure = _prefixId.prefix "StatisticalMeasure"
    /// <summary>
    ///   <para>rdfs:label : statistical population^^xsd:string</para>
    ///   <para>skos:definition : statistical universe filtered by time and region^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A common aim of statistical analysis is to produce information about some chosen population. In statistical inference, a subset of the population (a statistical sample) is chosen to represent the population in a statistical analysis. If a sample is chosen properly, characteristics of the entire population that the sample is drawn from can be estimated from corresponding characteristics of the sample.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalPopulation">fibo-fnd-utl-alx:StatisticalPopulation</a>
    /// </summary>
    let StatisticalPopulation = _prefixId.prefix "StatisticalPopulation"
    /// <summary>
    ///   <para>rdfs:label : statistical program^^xsd:string</para>
    ///   <para>skos:definition : program that presents a detailed investigation and analysis of a subject or situation involving one or more studies or surveys^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalProgram">fibo-fnd-utl-alx:StatisticalProgram</a>
    /// </summary>
    let StatisticalProgram = _prefixId.prefix "StatisticalProgram"
    /// <summary>
    ///   <para>rdfs:label : statistical universe^^xsd:string</para>
    ///   <para>skos:definition : collection representing the total membership, or 'universe', of people, resources, products, services, events, or entities of interest for some question, experiment, survey or statistical program^^xsd:string</para>
    ///   <para>skos:example : A statistical universe can be a group of actually existing objects (e.g. the set of all stars within the Milky Way galaxy) or a hypothetical and potentially infinite group of objects conceived as a generalization from experience (e.g. the set of all possible hands in a game of poker).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/StatisticalUniverse">fibo-fnd-utl-alx:StatisticalUniverse</a>
    /// </summary>
    let StatisticalUniverse = _prefixId.prefix "StatisticalUniverse"
    /// <summary>
    ///   <para>rdfs:label : variance^^xsd:string</para>
    ///   <para>skos:definition : measure of spread, calculated as the average squared deviation of each number from the mean of a data set^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.statcan.gc.ca/edu/power-pouvoir/glossary-glossaire/5214842-eng.htm#v^^xsd:anyURI</para>
    ///   <para>cmns-av:symbol : μ2^^xsd:stringcmns-av:symbol : σ2^^xsd:string</para>
    ///   <para>cmns-av:synonym : second moment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/Variance">fibo-fnd-utl-alx:Variance</a>
    /// </summary>
    let Variance = _prefixId.prefix "Variance"
    /// <summary>
    ///   <para>rdfs:label : weighting function^^xsd:string</para>
    ///   <para>skos:definition : expression or function that determines the relative importance or influence of a given element of a set with respect to the whole^^xsd:string</para>
    ///   <para>skos:example : Given a sample size of 1000, and a population of 300M, then the chance that any individual is selected is 1 in 300K. In that case, 300K is the weight assigned to each of the elements in the sample.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For certain indices, one of the most common weighting factor is by market capitalization. In that case, each of the elements in the basket is multiplied by its market cap to determine its relative importance to the basket overall.^^xsd:stringcmns-av:explanatoryNote : With respect to discrete calculations, weighting functions are positive functions defined on discrete sets, such as weighted sums and weighted averages.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/WeightingFunction">fibo-fnd-utl-alx:WeightingFunction</a>
    /// </summary>
    let WeightingFunction = _prefixId.prefix "WeightingFunction"
    /// <summary>
    ///   <para>rdfs:label : has fixed comparative date^^xsd:string</para>
    ///   <para>skos:definition : specifies the a specific date, such as the end of the last recession (e.g., March 2009) against which the scoped measure is compared^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFixedComparativeDate">fibo-fnd-utl-alx:hasFixedComparativeDate</a>
    /// </summary>
    let hasFixedComparativeDate = _prefixId.prefix "hasFixedComparativeDate"
    /// <summary>
    ///   <para>rdfs:label : has formula^^xsd:string</para>
    ///   <para>skos:definition : specifies a concise way of expressing information symbolically, as in a mathematical or chemical formula^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasFormula">fibo-fnd-utl-alx:hasFormula</a>
    /// </summary>
    let hasFormula = _prefixId.prefix "hasFormula"
    /// <summary>
    ///   <para>rdfs:label : has measurement date time^^xsd:string</para>
    ///   <para>skos:definition : indicates the date and time that the measurement was taken^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementDateTime">fibo-fnd-utl-alx:hasMeasurementDateTime</a>
    /// </summary>
    let hasMeasurementDateTime = _prefixId.prefix "hasMeasurementDateTime"
    /// <summary>
    ///   <para>rdfs:label : has measurement period in months^^xsd:string</para>
    ///   <para>skos:definition : indicates the coverage period for which the measure is applicable expressed in months^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMeasurementPeriodInMonths">fibo-fnd-utl-alx:hasMeasurementPeriodInMonths</a>
    /// </summary>
    let hasMeasurementPeriodInMonths = _prefixId.prefix "hasMeasurementPeriodInMonths"
    /// <summary>
    ///   <para>rdfs:label : has minuend^^xsd:string</para>
    ///   <para>skos:definition : specifies the quantity value from which something is subtracted; the value that is diminished^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasMinuend">fibo-fnd-utl-alx:hasMinuend</a>
    /// </summary>
    let hasMinuend = _prefixId.prefix "hasMinuend"
    /// <summary>
    ///   <para>rdfs:label : has number of entries^^xsd:string</para>
    ///   <para>skos:definition : indicates the number of elements in some document, table, or other resource (e.g., in a report, table)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasNumberOfEntries">fibo-fnd-utl-alx:hasNumberOfEntries</a>
    /// </summary>
    let hasNumberOfEntries = _prefixId.prefix "hasNumberOfEntries"
    /// <summary>
    ///   <para>rdfs:label : has observed value^^xsd:string</para>
    ///   <para>skos:definition : specifies a collection of values over which some analysis is performed^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For certain calculations, such as certain measures of dispersion, date value pairs are expected as input, in other words, a dated structured collection.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasObservedValue">fibo-fnd-utl-alx:hasObservedValue</a>
    /// </summary>
    let hasObservedValue = _prefixId.prefix "hasObservedValue"
    /// <summary>
    ///   <para>rdfs:label : has periodicity^^xsd:string</para>
    ///   <para>skos:definition : specifies a recurrence interval (monthly, quarterly, annual) that a statistical measure reflects^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPeriodicity">fibo-fnd-utl-alx:hasPeriodicity</a>
    /// </summary>
    let hasPeriodicity = _prefixId.prefix "hasPeriodicity"
    /// <summary>
    ///   <para>rdfs:label : has population size^^xsd:string</para>
    ///   <para>skos:definition : indicates the number of elements in a given population^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasPopulationSize">fibo-fnd-utl-alx:hasPopulationSize</a>
    /// </summary>
    let hasPopulationSize = _prefixId.prefix "hasPopulationSize"
    /// <summary>
    ///   <para>rdfs:label : has reference period^^xsd:string</para>
    ///   <para>skos:definition : specifies a reference (baseline) recurrence interval for which a given measure applies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReferencePeriod">fibo-fnd-utl-alx:hasReferencePeriod</a>
    /// </summary>
    let hasReferencePeriod = _prefixId.prefix "hasReferencePeriod"
    /// <summary>
    ///   <para>rdfs:label : has relative comparative date^^xsd:string</para>
    ///   <para>skos:definition : specifies a date against which the value of a scoped measure is compared (e.g., one month prior, three months prior, etc., and typically against a prior release or average over prior releases)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativeDate">fibo-fnd-utl-alx:hasRelativeComparativeDate</a>
    /// </summary>
    let hasRelativeComparativeDate = _prefixId.prefix "hasRelativeComparativeDate"
    /// <summary>
    ///   <para>rdfs:label : has relative comparative period^^xsd:string</para>
    ///   <para>skos:definition : specifies a period (typically a prior period) against which the scoped measure is compared, such as an average set of values for some period of time compared with a more recent or projected average for a forward looking period of time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasRelativeComparativePeriod">fibo-fnd-utl-alx:hasRelativeComparativePeriod</a>
    /// </summary>
    let hasRelativeComparativePeriod = _prefixId.prefix "hasRelativeComparativePeriod"
    /// <summary>
    ///   <para>rdfs:label : has release date^^xsd:string</para>
    ///   <para>skos:definition : specifies the date on which something is published^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A release date is typically a date fixed in advance for the release of a film, recording, document, report, or product or publication.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDate">fibo-fnd-utl-alx:hasReleaseDate</a>
    /// </summary>
    let hasReleaseDate = _prefixId.prefix "hasReleaseDate"
    /// <summary>
    ///   <para>rdfs:label : has release date and time^^xsd:string</para>
    ///   <para>skos:definition : specifies the date and time on which something is published^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasReleaseDateTime">fibo-fnd-utl-alx:hasReleaseDateTime</a>
    /// </summary>
    let hasReleaseDateTime = _prefixId.prefix "hasReleaseDateTime"
    /// <summary>
    ///   <para>rdfs:label : has subtrahend^^xsd:string</para>
    ///   <para>skos:definition : specifies the quantity value that is subtracted from something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasSubtrahend">fibo-fnd-utl-alx:hasSubtrahend</a>
    /// </summary>
    let hasSubtrahend = _prefixId.prefix "hasSubtrahend"
    /// <summary>
    ///   <para>rdfs:label : has target value^^xsd:string</para>
    ///   <para>skos:definition : specifies a collection of values that represent planned or projected goals or objectives for some something over time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasTargetValue">fibo-fnd-utl-alx:hasTargetValue</a>
    /// </summary>
    let hasTargetValue = _prefixId.prefix "hasTargetValue"
    /// <summary>
    ///   <para>rdfs:label : has universe size^^xsd:string</para>
    ///   <para>skos:definition : indicates the number of elements in a given universe^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasUniverseSize">fibo-fnd-utl-alx:hasUniverseSize</a>
    /// </summary>
    let hasUniverseSize = _prefixId.prefix "hasUniverseSize"
    /// <summary>
    ///   <para>rdfs:label : has weight^^xsd:string</para>
    ///   <para>skos:definition : indicates an amount given to increase or decrease the importance of an item^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/hasWeight">fibo-fnd-utl-alx:hasWeight</a>
    /// </summary>
    let hasWeight = _prefixId.prefix "hasWeight"
    /// <summary>
    ///   <para>rdfs:label : is calculated via methodology^^xsd:string</para>
    ///   <para>skos:definition : high-level description of the approach taken to obtain the result^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isCalculatedViaMethodology">fibo-fnd-utl-alx:isCalculatedViaMethodology</a>
    /// </summary>
    let isCalculatedViaMethodology = _prefixId.prefix "isCalculatedViaMethodology"
    /// <summary>
    ///   <para>rdfs:label : is estimate^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the measure reflects an estimate (approximation) or not^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/isEstimate">fibo-fnd-utl-alx:isEstimate</a>
    /// </summary>
    let isEstimate = _prefixId.prefix "isEstimate"
