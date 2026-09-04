#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-ei-ei`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/" "fibo-ind-ei-ei"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : average daily earnings^^xsd:string</para>
    ///   <para>skos:definition : measure of the average daily wage an employee makes over the reporting period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=4360^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageDailyEarnings">fibo-ind-ei-ei:AverageDailyEarnings</a>
    /// </summary>
    let AverageDailyEarnings = _prefixId.prefix "AverageDailyEarnings"
    /// <summary>
    ///   <para>rdfs:label : average earnings^^xsd:string</para>
    ///   <para>skos:definition : measure of the average wage an hourly or salaried worker makes in a given period of time^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=4360^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Average earnings are typically calculated on an hourly, daily, weekly, or monthly basis. They may be expressed as an amount of money or in terms of a percent change with respect to a prior period, depending on the jurisdiction and report.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageEarnings">fibo-ind-ei-ei:AverageEarnings</a>
    /// </summary>
    let AverageEarnings = _prefixId.prefix "AverageEarnings"
    /// <summary>
    ///   <para>rdfs:label : average hourly earnings^^xsd:string</para>
    ///   <para>skos:definition : measure of the average hourly wage an employee makes over the reporting period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=4360^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageHourlyEarnings">fibo-ind-ei-ei:AverageHourlyEarnings</a>
    /// </summary>
    let AverageHourlyEarnings = _prefixId.prefix "AverageHourlyEarnings"
    /// <summary>
    ///   <para>rdfs:label : average monthly earnings^^xsd:string</para>
    ///   <para>skos:definition : measure of the average monthly wage an employee makes over the reporting period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=4360^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageMonthlyEarnings">fibo-ind-ei-ei:AverageMonthlyEarnings</a>
    /// </summary>
    let AverageMonthlyEarnings = _prefixId.prefix "AverageMonthlyEarnings"
    /// <summary>
    ///   <para>rdfs:label : average weekly earnings^^xsd:string</para>
    ///   <para>skos:definition : measure of the average weekly wage an employee makes over the reporting period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=4360^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/AverageWeeklyEarnings">fibo-ind-ei-ei:AverageWeeklyEarnings</a>
    /// </summary>
    let AverageWeeklyEarnings = _prefixId.prefix "AverageWeeklyEarnings"

    /// <summary>
    ///   <para>rdfs:label : capital-labor-energy-materials multifactor productivity^^xsd:string</para>
    ///   <para>skos:definition : ratio of a quantity index of gross output to a quantity index of combined inputs^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : KLEMS-MFP^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.oecd.org/std/productivity-stats/2352458.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Shows the time profile of how productively combined inputs are used to generate gross output. Conceptually, the KLEMS productivity measure captures disembodied technical change. In practice, it reflects also efficiency change, economies of scale, variations in capacity utilisation and measurement errors.^^xsd:string</para>
    ///   <para>cmns-av:synonym : KLEMS multifactor productivity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborEnergyMaterialsMultifactorProductivity">fibo-ind-ei-ei:CapitalLaborEnergyMaterialsMultifactorProductivity</a>
    /// </summary>
    let CapitalLaborEnergyMaterialsMultifactorProductivity =
        _prefixId.prefix "CapitalLaborEnergyMaterialsMultifactorProductivity"

    /// <summary>
    ///   <para>rdfs:label : capital-labor multifactor productivity (MFP), based on value added^^xsd:string</para>
    ///   <para>skos:definition : ratio of a quantity index of value added to a quantity index of combined labor and capital input^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.oecd.org/std/productivity-stats/2352458.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Capital-labour MFP indices show the time profile of how productively combined labour and capital inputs are used to generate value added. Conceptually, capital-labour productivity is not, in general, an accurate measure of technical change. It is, however, an indicator of an industry's capacity to contribute to economy-wide growth of income per unit of primary input. In practice, the measure reflects the combined effects of disembodied technical change, economies of scale, efficiency change, variations in capacity utilisation and measurement errors.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalLaborMultifactorProductivityValueAdded">fibo-ind-ei-ei:CapitalLaborMultifactorProductivityValueAdded</a>
    /// </summary>
    let CapitalLaborMultifactorProductivityValueAdded =
        _prefixId.prefix "CapitalLaborMultifactorProductivityValueAdded"

    /// <summary>
    ///   <para>rdfs:label : capital productivity, based on value added^^xsd:string</para>
    ///   <para>skos:definition : ratio of a quantity index of value added to a quantity index of capital input^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.oecd.org/std/productivity-stats/2352458.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Changes in capital productivity indicate the extent to which output growth can be achieved with lower welfare costs in the form of foregone consumption.^^xsd:stringcmns-av:explanatoryNote : The capital productivity index shows the time profile of how productively capital is used to generate value added. Capital productivity reflects the joint influence of labour, intermediate inputs, technical change, efficiency change, economies of scale, capacity utilisation and measurement errors.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CapitalProductivityValueAdded">fibo-ind-ei-ei:CapitalProductivityValueAdded</a>
    /// </summary>
    let CapitalProductivityValueAdded = _prefixId.prefix "CapitalProductivityValueAdded"
    /// <summary>
    ///   <para>rdfs:label : civilian^^xsd:string</para>
    ///   <para>skos:definition : person that is not a member of the military (i.e., that is not on active duty)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Civilian">fibo-ind-ei-ei:Civilian</a>
    /// </summary>
    let Civilian = _prefixId.prefix "Civilian"
    /// <summary>
    ///   <para>rdfs:label : civilian labor force^^xsd:string</para>
    ///   <para>skos:definition : subset of the civilian, non-institutional population considered to be part of the labor force during a given reporting period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForce">fibo-ind-ei-ei:CivilianLaborForce</a>
    /// </summary>
    let CivilianLaborForce = _prefixId.prefix "CivilianLaborForce"

    /// <summary>
    ///   <para>rdfs:label : civilian labor force participation rate^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing the rate of participation the labor force of a given economy for some specified period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bls.gov/cps/definitions.htm#lfpr^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The labor force participation rate is the percentage of the population that is either employed or unemployed (that is, either working or actively seeking work).^^xsd:string</para>
    ///   <para>cmns-qtu:describesActualExpression : civilian labor force ÷ civilian non-institutional population^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianLaborForceParticipationRate">fibo-ind-ei-ei:CivilianLaborForceParticipationRate</a>
    /// </summary>
    let CivilianLaborForceParticipationRate =
        _prefixId.prefix "CivilianLaborForceParticipationRate"

    /// <summary>
    ///   <para>rdfs:label : civilian non-institutional person^^xsd:string</para>
    ///   <para>skos:definition : legal working-age person that does not live in an institution (for example, a correctional facility, long-term care hospital, or nursing home), and is not on active military duty^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The working-age population is the total population in a region, within a set range of ages, that is considered to be able and likely to work. The working-age population measure is used to give an estimate of the total number of potential workers within an economy. For example, in the U.S., it is 16, whereas in Canada it is 15.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPerson">fibo-ind-ei-ei:CivilianNonInstitutionalPerson</a>
    /// </summary>
    let CivilianNonInstitutionalPerson =
        _prefixId.prefix "CivilianNonInstitutionalPerson"

    /// <summary>
    ///   <para>rdfs:label : civilian non-institutional population^^xsd:string</para>
    ///   <para>skos:definition : statistical universe consisting of people of a certain age who reside in a given region, do not live in institutions (for example, correctional facilities, long-term care hospitals, and nursing homes), and are not on active military duty^^xsd:string</para>
    ///   <para>skos:scopeNote : The civilian non-institutional population is typically reported in thousands.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CivilianNonInstitutionalPopulation">fibo-ind-ei-ei:CivilianNonInstitutionalPopulation</a>
    /// </summary>
    let CivilianNonInstitutionalPopulation =
        _prefixId.prefix "CivilianNonInstitutionalPopulation"

    /// <summary>
    ///   <para>rdfs:label : combined statistical area^^xsd:string</para>
    ///   <para>skos:definition : combination of adjacent metropolitan and micropolitan areas with economic ties measured by commuting patterns^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CSA^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : These areas that combine retain their own designations as metropolitan or micropolitan statistical areas within the larger combined statistical area.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/CombinedStatisticalArea">fibo-ind-ei-ei:CombinedStatisticalArea</a>
    /// </summary>
    let CombinedStatisticalArea = _prefixId.prefix "CombinedStatisticalArea"
    /// <summary>
    ///   <para>rdfs:label : consumer price index^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing measure of the change over time in the prices of consumer goods and services that households consume^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CPI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://unstats.un.org/unsd/nationalaccount/docs/SNA2008.pdf^^xsd:anyURIcmns-av:adaptedFrom : http://www.ilo.org/public/english/bureau/stat/guides/cpi/^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ConsumerPriceIndex">fibo-ind-ei-ei:ConsumerPriceIndex</a>
    /// </summary>
    let ConsumerPriceIndex = _prefixId.prefix "ConsumerPriceIndex"
    let Daily = _prefixId.prefix "Daily"
    /// <summary>
    ///   <para>rdfs:label : discouraged worker population^^xsd:string</para>
    ///   <para>skos:definition : subset of the marginally attached population that have given a job-market related reason for not currently looking for work^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bls.gov/news.release/empsit.t15.htm^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/DiscouragedWorkerPopulation">fibo-ind-ei-ei:DiscouragedWorkerPopulation</a>
    /// </summary>
    let DiscouragedWorkerPopulation = _prefixId.prefix "DiscouragedWorkerPopulation"
    /// <summary>
    ///   <para>rdfs:label : economic indicator^^xsd:string</para>
    ///   <para>skos:definition : statistical measure of economic activity that is regular and comparable in the context of a statistical area (region), used for analysis of economic performance and predictions of future performance^^xsd:string</para>
    ///   <para>skos:example : Example indicators include the average work week, weekly claims for unemployment insurance, new orders, vendor performance, stock prices, and changes in the money supply.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economic Terms, Fifth Edition, 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The two main features of any indicator are the regularity with which they are measured and published, and the fact that they are comparable from one release to the next.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EconomicIndicator">fibo-ind-ei-ei:EconomicIndicator</a>
    /// </summary>
    let EconomicIndicator = _prefixId.prefix "EconomicIndicator"
    /// <summary>
    ///   <para>rdfs:label : employed population^^xsd:string</para>
    ///   <para>skos:definition : subset of the civilian labor force considered to be employed during the reporting period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : There are a number of distinctions with respect to how individuals are counted from country to country, including whether or not they are considered employed if they are on unpaid leave for some reason, and whether or not they are counted multiple times if they have more than one paying job.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulation">fibo-ind-ei-ei:EmployedPopulation</a>
    /// </summary>
    let EmployedPopulation = _prefixId.prefix "EmployedPopulation"
    /// <summary>
    ///   <para>rdfs:label : employed population part-time^^xsd:string</para>
    ///   <para>skos:definition : subset of the employed population that includes persons that are working fewer than 30 to 35 hours per week based on usual working hours^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://stats.oecd.org/Index.aspx?DatasetCode=STLABOUR^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the U.S., part-time workers are those who usually work fewer than 35 hours per week. See https://www.bls.gov/cps/definitions.htm for additional details.^^xsd:stringcmns-av:explanatoryNote : The definition of part-time varies considerably from country to country according to the OECD. Classification may be based on (1) employee perception, (2) usual working hours, which is the most reliable measure, or (3) actual working hours, which varies due to holidays, illness, etc.^^xsd:string</para>
    ///   <para>cmns-av:synonym : population employed part-time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTime">fibo-ind-ei-ei:EmployedPopulationPartTime</a>
    /// </summary>
    let EmployedPopulationPartTime = _prefixId.prefix "EmployedPopulationPartTime"

    /// <summary>
    ///   <para>rdfs:label : employed population part-time for economic reasons^^xsd:string</para>
    ///   <para>skos:definition : subset of the employed population that includes persons that are working fewer than 30 to 35 hours per week due to slack work, unfavorable business conditions, inability to find full-time work, and seasonal declines in demand^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://stats.oecd.org/Index.aspx?DatasetCode=STLABOUR^^xsd:stringcmns-av:adaptedFrom : https://www.bls.gov/cps/definitions.htm^^xsd:string</para>
    ///   <para>cmns-av:synonym : involuntary part-time population^^xsd:stringcmns-av:synonym : population employed part-time for economic reasons^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForEconomicReasons">fibo-ind-ei-ei:EmployedPopulationPartTimeForEconomicReasons</a>
    /// </summary>
    let EmployedPopulationPartTimeForEconomicReasons =
        _prefixId.prefix "EmployedPopulationPartTimeForEconomicReasons"

    /// <summary>
    ///   <para>rdfs:label : employed population part-time for non-economic reasons^^xsd:string</para>
    ///   <para>skos:definition : subset of the employed population that includes persons that are working fewer than 30 to 35 hours per week due to illness or other health or medical limitations, childcare problems, family or personal obligations, being in school or training, retirement or Social Security limits on earnings, and having a job where full-time work is less than 35 hours^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bls.gov/cps/definitions.htm^^xsd:string</para>
    ///   <para>cmns-av:synonym : population employed part-time for non-economic reasons^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationPartTimeForNonEconomicReasons">fibo-ind-ei-ei:EmployedPopulationPartTimeForNonEconomicReasons</a>
    /// </summary>
    let EmployedPopulationPartTimeForNonEconomicReasons =
        _prefixId.prefix "EmployedPopulationPartTimeForNonEconomicReasons"

    /// <summary>
    ///   <para>rdfs:label : employed population temporarily not at work^^xsd:string</para>
    ///   <para>skos:definition : subset of the employed population that includes persons that are temporarily absent from work for various reasons^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bls.gov/news.release/empsit.t15.htm^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This includes persons temporarily not at work because of illness or injury, holiday or vacation, strike or lockout, educational or training leave, maternity or parental leave, reduction in economic activity, temporary disorganisation or suspension of work due to such reasons as bad weather, mechanical or electrical breakdown, or shortage of raw materials or fuels, or other temporary absence with or without leave should be considered as in paid employment provided they had a formal job attachment.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmployedPopulationTemporarilyNotAtWork">fibo-ind-ei-ei:EmployedPopulationTemporarilyNotAtWork</a>
    /// </summary>
    let EmployedPopulationTemporarilyNotAtWork =
        _prefixId.prefix "EmployedPopulationTemporarilyNotAtWork"

    /// <summary>
    ///   <para>rdfs:label : employment-population ratio^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing the ratio of the employed population with respect to the overall civilian non-institutional population of a given economy for some specified period^^xsd:string</para>
    ///   <para>cmns-qtu:describesActualExpression : employed population ÷ civilian non-institutional population^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EmploymentPopulationRatio">fibo-ind-ei-ei:EmploymentPopulationRatio</a>
    /// </summary>
    let EmploymentPopulationRatio = _prefixId.prefix "EmploymentPopulationRatio"
    /// <summary>
    ///   <para>rdfs:label : enterprise^^xsd:string</para>
    ///   <para>skos:definition : functional business entity that produces and/or sells goods or services^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.bls.gov/opub/hom/glossary.htm#E^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An enterprise (a private firm, government, or nonprofit organization) can consist of a single establishment or multiple establishments. All establishments in an enterprise may be classified in one industry (e.g., a chain), or they may be classified in different industries (e.g., a conglomerate).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Enterprise">fibo-ind-ei-ei:Enterprise</a>
    /// </summary>
    let Enterprise = _prefixId.prefix "Enterprise"
    /// <summary>
    ///   <para>rdfs:label : enterprise population^^xsd:string</para>
    ///   <para>skos:definition : statistical universe consisting of enterprises designed for the purposes of supporting surveys such as those used as the basis for employment and producer price indices^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EnterprisePopulation">fibo-ind-ei-ei:EnterprisePopulation</a>
    /// </summary>
    let EnterprisePopulation = _prefixId.prefix "EnterprisePopulation"
    /// <summary>
    ///   <para>rdfs:label : establishment^^xsd:string</para>
    ///   <para>skos:definition : an enterprise (or part of an enterprise) that operates from a single physical location^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=857^^xsd:anyURIcmns-av:adaptedFrom : http://www.bls.gov/opub/hom/glossary.htm#E^^xsd:anyURIcmns-av:adaptedFrom : http://www.statcan.gc.ca/eng/concepts/units^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The physical location of a certain economic activity - for example, a factory, mine, store, or office. An individual establishment is generally classified by having one NAICS code associated with it for statistical purposes, whereas an enterprise may be classified by multiple NAICS codes. The statistical structure is defined based on the operating structure and the accounting data produced by that entity. A given location may only need to publish revenues, whereas an operating unit (establishment) has employment statistics, etc. An establishment is defined as a producing unit at a single geographical location at which or from which economic activity is conducted and for which, at a minimum, employment data are available. In the case of a home-based business, the actual physical location would be specified as two distinct institutional units - as a household from a personal living and consumer perspective and as an establishment / operating unit due to the statistics required of the business.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Establishment">fibo-ind-ei-ei:Establishment</a>
    /// </summary>
    let Establishment = _prefixId.prefix "Establishment"
    /// <summary>
    ///   <para>rdfs:label : establishment employment^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing the total number of persons who work in or for the establishment including working proprietors, active business partners and unpaid family workers, as well as persons working outside the establishment when paid by and under the control of the establishment, for example, sales representatives, outside service engineers and repair and maintenance personnel^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=780^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Also included are salaried managers and salaried directors of incorporated enterprises. The total should include part-time workers and seasonal workers on the payroll, persons on short-term leave (sick leave, maternity leave, annual leave or vacation) and on strike, but not persons on indefinite leave, military leave or pension.
    ///
    /// Excluded are directors of incorporated enterprises and members of shareholders committees who are paid solely for their attendance at meetings, labour made available to the establishment by other units and charged for, such as contract workers paid through contractors, persons carrying out repair and maintenance work in the establishment on behalf of other units and all homeworkers.^^xsd:string</para>
    ///   <para>cmns-av:synonym : payroll employment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentEmployment">fibo-ind-ei-ei:EstablishmentEmployment</a>
    /// </summary>
    let EstablishmentEmployment = _prefixId.prefix "EstablishmentEmployment"
    /// <summary>
    ///   <para>rdfs:label : establishment population^^xsd:string</para>
    ///   <para>skos:definition : a subset of the enterprise population focused on establishments^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/EstablishmentPopulation">fibo-ind-ei-ei:EstablishmentPopulation</a>
    /// </summary>
    let EstablishmentPopulation = _prefixId.prefix "EstablishmentPopulation"
    /// <summary>
    ///   <para>rdfs:label : fixed basket^^xsd:string</para>
    ///   <para>skos:definition : basket of goods and services whose quantity and quality are held fixed for some period of time^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.imf.org/external/pubs/ft/ppi/2010/manual/ppi.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : basket of goods^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasket">fibo-ind-ei-ei:FixedBasket</a>
    /// </summary>
    let FixedBasket = _prefixId.prefix "FixedBasket"
    /// <summary>
    ///   <para>rdfs:label : fixed basket constituent^^xsd:string</para>
    ///   <para>skos:definition : component of a fixed basket^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketConstituent">fibo-ind-ei-ei:FixedBasketConstituent</a>
    /// </summary>
    let FixedBasketConstituent = _prefixId.prefix "FixedBasketConstituent"
    /// <summary>
    ///   <para>rdfs:label : fixed basket population^^xsd:string</para>
    ///   <para>skos:definition : statistical universe consisting of specific goods and/or services designed for the purposes of supporting surveys such as those used as the basis for price indices^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.imf.org/external/pubs/ft/ppi/2010/manual/ppi.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : goods and services population^^xsd:stringcmns-av:synonym : goods and/or services population^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/FixedBasketPopulation">fibo-ind-ei-ei:FixedBasketPopulation</a>
    /// </summary>
    let FixedBasketPopulation = _prefixId.prefix "FixedBasketPopulation"

    /// <summary>
    ///   <para>rdfs:label : government-specified statistical area^^xsd:string</para>
    ///   <para>skos:definition : statistical area defined by a government agency^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GovernmentSpecifiedStatisticalArea">fibo-ind-ei-ei:GovernmentSpecifiedStatisticalArea</a>
    /// </summary>
    let GovernmentSpecifiedStatisticalArea =
        _prefixId.prefix "GovernmentSpecifiedStatisticalArea"

    /// <summary>
    ///   <para>rdfs:label : gross domestic product^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing the broadest measure of aggregate economic activity, measuring the total unduplicated market value of all final goods and services produced within a statistical area in a period^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : GDP^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : BEA's Handbook of Methods for GDP and related national accounts, available at https://www.bea.gov/methodologies/index.htm#national_meth^^xsd:stringcmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Gross_domestic_product^^xsd:anyURIcmns-av:adaptedFrom : https://home.treasury.gov/system/files/261/FSOC-2013-Annual-Report.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : GDP represents a valuation expressed in terms of the prices actually paid by the purchaser after all applicable taxes and subsidies.^^xsd:stringcmns-av:explanatoryNote : Gross domestic product (GDP) is the value of the goods and services produced by the nation's economy less the value of the goods and services used up in production. GDP is also equal to the sum of personal consumption expenditures, gross private domestic investment, net exports of goods and services, and government consumption expenditures and gross investment. Conceptually, this measure can be arrived at by three separate means: as the sum of goods and services sold to final users, as the sum of income payments and other costs incurred in the production of goods and services, and as the sum of the value added at each stage of production. Although these three ways of measuring GDP are conceptually the same, their calculation may not result in identical estimates of GDP because of differences in data sources, timing, and estimation techniques.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/GrossDomesticProduct">fibo-ind-ei-ei:GrossDomesticProduct</a>
    /// </summary>
    let GrossDomesticProduct = _prefixId.prefix "GrossDomesticProduct"
    let Hourly = _prefixId.prefix "Hourly"
    /// <summary>
    ///   <para>rdfs:label : household^^xsd:string</para>
    ///   <para>skos:definition : individual or small group of persons who occupy a housing unit (such as a house or apartment) as their usual place of residence, who pool some, or all, of their income and wealth and who consume certain types of goods and services collectively, mainly housing and food^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A household may be either (a) a one-person household, that is to say, a person who makes provision for his or her own food or other essentials for living without combining with any other person to form part of a multi-person household or (b) a multi-person household, that is to say, a group of two or more persons living together who make common provision for food or other essentials for living. The persons in the group may pool their incomes and may, to a greater or lesser extent, have a common budget; they may be related or unrelated persons or constitute a combination of persons both related and unrelated.
    ///
    /// A household may be located in a housing unit or in a set of collective living quarters such as a boarding house, a hotel or a camp, or may comprise the administrative personnel in an institution. The household may also be homeless.^^xsd:stringcmns-av:explanatoryNote : From the perspective of the U.S Census Bureau, a household includes the related family members and all the unrelated people, if any, such as lodgers, foster children, wards, or employees who share the housing unit. A person living alone in a housing unit, or a group of unrelated people sharing a housing unit such as partners or roomers, is also counted as a household. The count of households excludes group quarters [such as institutional facilities]. There are two major categories of households, 'family' and 'nonfamily'.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Household">fibo-ind-ei-ei:Household</a>
    /// </summary>
    let Household = _prefixId.prefix "Household"
    /// <summary>
    ///   <para>rdfs:label : housing unit^^xsd:string</para>
    ///   <para>skos:definition : house, an apartment, a mobile home or trailer, a group of rooms, or a single room occupied as separate living quarters, or if vacant, intended for occupancy as separate living quarters^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Separate living quarters are those in which the occupants live separately from any other individuals in the building and which have direct access from outside the building or through a common hall. For vacant units, the criteria of separateness and direct access are applied to the intended occupants whenever possible.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/HousingUnit">fibo-ind-ei-ei:HousingUnit</a>
    /// </summary>
    let HousingUnit = _prefixId.prefix "HousingUnit"
    /// <summary>
    ///   <para>rdfs:label : inflation rate^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing a change in prices of goods and services for a specified period, for a given statistical area^^xsd:string</para>
    ///   <para>skos:editorialNote : Always either includes or excludes: Energy prices; Food prices. ALL inflation rates cite whether or not they exclude energy and food prices. If nothing stated it is assumed they include them.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Inflation rate can be used to define changes, from period-to-period, in wage (wage inflation), house prices or producer inputs/outputs. It can be calculated month-over-month and quarter-over-quarter, as well as year-over-year, or on any periodic basis required by the publisher and its community of interest.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InflationRate">fibo-ind-ei-ei:InflationRate</a>
    /// </summary>
    let InflationRate = _prefixId.prefix "InflationRate"
    /// <summary>
    ///   <para>rdfs:label : input producer price index^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing measure of the rate of change over time in the prices of inputs of goods and services purchased by the producer^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : input PPI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.imf.org/external/pubs/ft/ppi/2010/manual/ppi.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InputProducerPriceIndex">fibo-ind-ei-ei:InputProducerPriceIndex</a>
    /// </summary>
    let InputProducerPriceIndex = _prefixId.prefix "InputProducerPriceIndex"
    /// <summary>
    ///   <para>rdfs:label : institutional person^^xsd:string</para>
    ///   <para>skos:definition : person that resides in an institution for some reason, due, for example, to hospitalization, rehabilitation, or incarceration^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalPerson">fibo-ind-ei-ei:InstitutionalPerson</a>
    /// </summary>
    let InstitutionalPerson = _prefixId.prefix "InstitutionalPerson"
    /// <summary>
    ///   <para>rdfs:label : institutional unit^^xsd:string</para>
    ///   <para>skos:definition : party that is capable, in its own right, of owning assets, incurring liabilities, and engaging in economic activities and in transactions with other parties^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=1415^^xsd:anyURIcmns-av:adaptedFrom : http://www.statcan.gc.ca/eng/concepts/units^^xsd:anyURIcmns-av:adaptedFrom : https://www.statcan.gc.ca/en/concepts/ccius/intro^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : There is a hierarchical relationship between institutional units and establishments. An institutional unit contains one or more entire establishment(s); an establishment belongs to one and only one institutional unit. There are two main types of units in the real world that may qualify as institutional units, namely persons or groups of persons in the form of households, and legal or social entities.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/InstitutionalUnit">fibo-ind-ei-ei:InstitutionalUnit</a>
    /// </summary>
    let InstitutionalUnit = _prefixId.prefix "InstitutionalUnit"
    /// <summary>
    ///   <para>rdfs:label : labor productivity, based on gross output^^xsd:string</para>
    ///   <para>skos:definition : ratio of a quantity index of gross output to a quantity index of labor input^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.oecd.org/std/productivity-stats/2352458.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Gross-output based labour productivity traces the labour requirements per unit of (physical) output. It reflects the change in the input coefficient of labour by industry and can help in the analysis of labour requirements by industry.^^xsd:stringcmns-av:explanatoryNote : Shows the time profile of how productively labour is used to generate gross output. Labour productivity changes reflect the joint influence of changes in capital, intermediate inputs, as well as technical, organisational and efficiency change within and between firms, the influence of economies of scale, varying degrees of capacity utilisation and measurement errors.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityGrossOutput">fibo-ind-ei-ei:LaborProductivityGrossOutput</a>
    /// </summary>
    let LaborProductivityGrossOutput = _prefixId.prefix "LaborProductivityGrossOutput"
    /// <summary>
    ///   <para>rdfs:label : labor productivity, based on value added^^xsd:string</para>
    ///   <para>skos:definition : ratio of a quantity index of value added to a quantity index of labor input^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.oecd.org/std/productivity-stats/2352458.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : At the aggregate level, value-added based labour productivity forms a direct link to a widely used measure of living standards, income per capita. Productivity translates directly into living standards, by adjusting for changing working hours, unemployment, labour force participation rates and demographic changes.^^xsd:stringcmns-av:explanatoryNote : Shows the time profile of how productively labour is used to generate value added. Labour productivity changes reflect the joint influence of changes in capital, as well as technical, organisational and efficiency change within and between firms, the influence of economies of scale, varying degrees of capacity utilisation and measurement errors.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/LaborProductivityValueAdded">fibo-ind-ei-ei:LaborProductivityValueAdded</a>
    /// </summary>
    let LaborProductivityValueAdded = _prefixId.prefix "LaborProductivityValueAdded"
    /// <summary>
    ///   <para>rdfs:label : marginally attached population^^xsd:string</para>
    ///   <para>skos:definition : subset of the population that includes people who currently are neither working nor looking for work but indicate that they want and are available for a job and have looked for work sometime in the past 12 months^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bls.gov/news.release/empsit.t15.htm^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MarginallyAttachedPopulation">fibo-ind-ei-ei:MarginallyAttachedPopulation</a>
    /// </summary>
    let MarginallyAttachedPopulation = _prefixId.prefix "MarginallyAttachedPopulation"
    /// <summary>
    ///   <para>rdfs:label : metropolitan statistical area^^xsd:string</para>
    ///   <para>skos:definition : one or more adjacent counties or county equivalents that have at least one urban core area of at least 50,000 population, plus adjacent territory that has a high degree of social and economic integration with the core as measured by commuting ties^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : MSA^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MetropolitanStatisticalArea">fibo-ind-ei-ei:MetropolitanStatisticalArea</a>
    /// </summary>
    let MetropolitanStatisticalArea = _prefixId.prefix "MetropolitanStatisticalArea"
    /// <summary>
    ///   <para>rdfs:label : micropolitan statistical area^^xsd:string</para>
    ///   <para>skos:definition : one or more adjacent counties or county equivalents that have at least one urban core area of at least 10,000 population but less than 50,000, plus adjacent territory that has a high degree of social and economic integration with the core as measured by commuting ties^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : μSA^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MicropolitanStatisticalArea">fibo-ind-ei-ei:MicropolitanStatisticalArea</a>
    /// </summary>
    let MicropolitanStatisticalArea = _prefixId.prefix "MicropolitanStatisticalArea"
    /// <summary>
    ///   <para>rdfs:label : military person^^xsd:string</para>
    ///   <para>skos:definition : person that is a member of the active duty military^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/MilitaryPerson">fibo-ind-ei-ei:MilitaryPerson</a>
    /// </summary>
    let MilitaryPerson = _prefixId.prefix "MilitaryPerson"
    let Monthly = _prefixId.prefix "Monthly"
    /// <summary>
    ///   <para>rdfs:label : output producer price index^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing measure of the rate of change over time in the prices of products sold as they leave the producer^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : output PPI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.imf.org/external/pubs/ft/ppi/2010/manual/ppi.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/OutputProducerPriceIndex">fibo-ind-ei-ei:OutputProducerPriceIndex</a>
    /// </summary>
    let OutputProducerPriceIndex = _prefixId.prefix "OutputProducerPriceIndex"

    /// <summary>
    ///   <para>rdfs:label : personal consumption expenditures^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing measure of the value of the goods and services purchased by, or on the behalf of, 'persons'^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : PCE^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bea.gov/data/consumer-spending/main^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Personal consumption expenditures consist of purchases of goods and services by households and by nonprofit institutions serving households (NPISHs). These goods and services include imputed expenditures on items such as the services of housing by a homeowner (the equivalent of rent), financial and insurance services for which there is no explicit charge, and medical care provided to individuals and financed by government or by private insurance.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PersonalConsumptionExpenditures">fibo-ind-ei-ei:PersonalConsumptionExpenditures</a>
    /// </summary>
    let PersonalConsumptionExpenditures =
        _prefixId.prefix "PersonalConsumptionExpenditures"

    /// <summary>
    ///   <para>rdfs:label : population not in the labor force^^xsd:string</para>
    ///   <para>skos:definition : subset of the civilian, noninstitutional population, that is considered neither employed nor unemployed by the reporting agency during the reporting period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : There are a number of distinctions with respect to how individuals are counted from country to country, including whether or not they are considered employed if they are on unpaid leave for some reason, and whether or not they are counted multiple times if they have more than one paying job.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/PopulationNotInLaborForce">fibo-ind-ei-ei:PopulationNotInLaborForce</a>
    /// </summary>
    let PopulationNotInLaborForce = _prefixId.prefix "PopulationNotInLaborForce"
    /// <summary>
    ///   <para>rdfs:label : producer price index^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing measure of the rate of change over time in the prices of goods and services bought and sold by producers^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : PPI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.imf.org/external/pubs/ft/ppi/2010/manual/ppi.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Statistical agencies implement the Laspeyres index by putting it into price-relative (price change from the base period) and revenue-share (from the base period) format. In this form, the Laspeyres index can be written as the sum of base-period revenue shares of the items in the index times their corresponding price relatives. Statistical agency practice has introduced some approximations to the theoretical Laspeyres target due to a number of practical problems with producing the Laspeyres index exactly. For these and other pragmatic reasons, some agencies use alternatives depending on circumstances. See the IMF publication cited for a full explanation of the most commonly used approaches and trade-offs made for determining PPI.^^xsd:stringcmns-av:explanatoryNote : The standard methodology for a typical PPI is based on a Laspeyres price index with fixed quantities from an earlier base period. The construction of this index can be thought of in terms of selecting a basket of goods and services representative of base-period revenues, valuing this at base-period prices, and then repricing the same basket at current-period prices. The target PPI in this case is defined to be the ratio of these two revenues. Practicing statisticians use this methodology because it has at least three practical advantages. It is easily explained to the public, it can use often expensive and untimely weighting information from the date of the last (or an even earlier) survey or administrative source (rather than requiring sources of data for the current month), and it need not be revised if users accept the Laspeyres premise.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ProducerPriceIndex">fibo-ind-ei-ei:ProducerPriceIndex</a>
    /// </summary>
    let ProducerPriceIndex = _prefixId.prefix "ProducerPriceIndex"
    /// <summary>
    ///   <para>rdfs:label : productivity^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing ratio of a volume measure of output to a volume measure of input use^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://stats.oecd.org/glossary/detail.asp?ID=2167^^xsd:anyURIcmns-av:adaptedFrom : http://www.oecd.org/std/productivity-stats/2352458.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The primary objectives of productivity measurement include: (a) tracing technology change, i.e., the currently known ways of converting resources into outputs desired by the economy, (b) identifying changes in efficiency, (c) understanding real cost savings, (d) benchmarking production processes, and (e) assessing standards of living. Productivity measures may also be single factor or multifactor.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/Productivity">fibo-ind-ei-ei:Productivity</a>
    /// </summary>
    let Productivity = _prefixId.prefix "Productivity"

    /// <summary>
    ///   <para>rdfs:label : statistical information publisher^^xsd:string</para>
    ///   <para>skos:definition : publisher that packages and makes analytical and statistical data available^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/StatisticalInformationPublisher">fibo-ind-ei-ei:StatisticalInformationPublisher</a>
    /// </summary>
    let StatisticalInformationPublisher =
        _prefixId.prefix "StatisticalInformationPublisher"

    /// <summary>
    ///   <para>rdfs:label : ultimate consumer^^xsd:string</para>
    ///   <para>skos:definition : person that is the ultimate user of a good, product or service^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For the purposes of the CPI and related statistics, the definition of consumer is limited to humans. In general, a consumer could include a pet, as the consumer of pet food, for example, although the pet owner would likely be the purchaser and target of advertising.^^xsd:stringcmns-av:explanatoryNote : The consumer is not always the purchaser of the product. Consumers are considered to be the users of the final product. For example, purchasers of building products are interim users of these products while constructing the finished product, which then may be purchased by the consumer.^^xsd:string</para>
    ///   <para>cmns-av:synonym : consumer as defined by the Consumer Price Index (CPI)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UltimateConsumer">fibo-ind-ei-ei:UltimateConsumer</a>
    /// </summary>
    let UltimateConsumer = _prefixId.prefix "UltimateConsumer"
    /// <summary>
    ///   <para>rdfs:label : underemployed population^^xsd:string</para>
    ///   <para>skos:definition : subset of the employed population that includes persons employed part-time for economic reasons, who want and are available for full-time work but have had to settle for a part-time schedule^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bls.gov/news.release/empsit.t15.htm^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulation">fibo-ind-ei-ei:UnderemployedPopulation</a>
    /// </summary>
    let UnderemployedPopulation = _prefixId.prefix "UnderemployedPopulation"

    /// <summary>
    ///   <para>rdfs:label : underemployed population with respect to occupation^^xsd:string</para>
    ///   <para>skos:definition : subset of the underemployed population that includes persons employed in a role that does not reflect their training and experience, excluding those that change careers^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderemployedPopulationWithRespectToOccupation">fibo-ind-ei-ei:UnderemployedPopulationWithRespectToOccupation</a>
    /// </summary>
    let UnderemployedPopulationWithRespectToOccupation =
        _prefixId.prefix "UnderemployedPopulationWithRespectToOccupation"

    /// <summary>
    ///   <para>rdfs:label : underutilized population^^xsd:string</para>
    ///   <para>skos:definition : subset of the civilian non-institutional population that includes persons employed part-time for economic reasons, persons that are marginally attached to the labor force, and persons that are identified as unemployed^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bls.gov/news.release/empsit.t15.htm^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnderutilizedPopulation">fibo-ind-ei-ei:UnderutilizedPopulation</a>
    /// </summary>
    let UnderutilizedPopulation = _prefixId.prefix "UnderutilizedPopulation"
    /// <summary>
    ///   <para>rdfs:label : unemployed population^^xsd:string</para>
    ///   <para>skos:definition : subset of the civilian labor force that is considered to have had no employment but was available for work, except for temporary illness, and had made specific efforts to find employment sometime during a specified period, during the reporting period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Persons who were waiting to be recalled to a job from which they had been laid off need not have been looking for work to be classified as unemployed.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemployedPopulation">fibo-ind-ei-ei:UnemployedPopulation</a>
    /// </summary>
    let UnemployedPopulation = _prefixId.prefix "UnemployedPopulation"
    /// <summary>
    ///   <para>rdfs:label : unemployment rate^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing the ratio of the unemployed population with respect to the civilian labor force of a given economy for some specified period^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.bls.gov/cps/faq.htm#Ques3^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Persons are classified as unemployed if they do not have a job, have actively looked for work in the prior 4 weeks, and are currently available for work. Workers expecting to be recalled from layoff are counted as unemployed, whether or not they have engaged in a specific jobseeking activity. In all other cases, the individual must have been engaged in at least one active job search activity in the 4 weeks preceding the interview and be available for work (except for temporary illness).^^xsd:string</para>
    ///   <para>cmns-qtu:describesActualExpression : unemployed population ÷ civilian labor force^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/UnemploymentRate">fibo-ind-ei-ei:UnemploymentRate</a>
    /// </summary>
    let UnemploymentRate = _prefixId.prefix "UnemploymentRate"
    /// <summary>
    ///   <para>rdfs:label : value-added producer price index^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing a weighted average of the input and output producer price indices^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : value-added PPI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.imf.org/external/pubs/ft/ppi/2010/manual/ppi.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/ValueAddedProducerPriceIndex">fibo-ind-ei-ei:ValueAddedProducerPriceIndex</a>
    /// </summary>
    let ValueAddedProducerPriceIndex = _prefixId.prefix "ValueAddedProducerPriceIndex"
    let Weekly = _prefixId.prefix "Weekly"
    /// <summary>
    ///   <para>rdfs:label : excludes energy and food^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the calculation of the index includes energy and food prices or not^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/excludesEnergyAndFood">fibo-ind-ei-ei:excludesEnergyAndFood</a>
    /// </summary>
    let excludesEnergyAndFood = _prefixId.prefix "excludesEnergyAndFood"
    /// <summary>
    ///   <para>rdfs:label : has baseline population^^xsd:string</para>
    ///   <para>skos:definition : specifies the starting point statistical universe or population used for comparison or analysis^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasBaselinePopulation">fibo-ind-ei-ei:hasBaselinePopulation</a>
    /// </summary>
    let hasBaselinePopulation = _prefixId.prefix "hasBaselinePopulation"
    /// <summary>
    ///   <para>rdfs:label : has comparison population^^xsd:string</para>
    ///   <para>skos:definition : specifies the subset of the baseline statistical universe or population used for comparison or analysis^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasComparisonPopulation">fibo-ind-ei-ei:hasComparisonPopulation</a>
    /// </summary>
    let hasComparisonPopulation = _prefixId.prefix "hasComparisonPopulation"
    /// <summary>
    ///   <para>rdfs:label : has duration of unemployment^^xsd:string</para>
    ///   <para>skos:definition : specifies the length of time, typically in weeks, that people classified as unemployed have been continuously looking for work^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasDurationOfUnemployment">fibo-ind-ei-ei:hasDurationOfUnemployment</a>
    /// </summary>
    let hasDurationOfUnemployment = _prefixId.prefix "hasDurationOfUnemployment"
    /// <summary>
    ///   <para>rdfs:label : has indicator value^^xsd:string</para>
    ///   <para>skos:definition : specifies a quantity value for a given indicator^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasIndicatorValue">fibo-ind-ei-ei:hasIndicatorValue</a>
    /// </summary>
    let hasIndicatorValue = _prefixId.prefix "hasIndicatorValue"
    /// <summary>
    ///   <para>rdfs:label : has series origin^^xsd:string</para>
    ///   <para>skos:definition : specifies the original starting date for the time series for a given economic indicator^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/hasSeriesOrigin">fibo-ind-ei-ei:hasSeriesOrigin</a>
    /// </summary>
    let hasSeriesOrigin = _prefixId.prefix "hasSeriesOrigin"
    /// <summary>
    ///   <para>rdfs:label : is seasonally adjusted^^xsd:string</para>
    ///   <para>skos:definition : a predicate indicating whether some published formal method is applied that compensates for seasonal variations in the population or index value^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Example explanation from the US Bureau of Labor Statistics: Because price data are used for different purposes by different groups, the Bureau of Labor Statistics publishes seasonally adjusted as well as unadjusted changes each month. ... Seasonal factors used in computing the seasonally adjusted indexes are derived by the X-13ARIMA-SEATS Seasonal Adjustment Method. Seasonally adjusted indexes and seasonal factors are computed annually. Each year, the last five years of seasonally adjusted data are revised.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/isSeasonallyAdjusted">fibo-ind-ei-ei:isSeasonallyAdjusted</a>
    /// </summary>
    let isSeasonallyAdjusted = _prefixId.prefix "isSeasonallyAdjusted"
