#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-ei-usei`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/" "fibo-ind-ei-usei"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : American statistics publisher^^xsd:string</para>
    ///   <para>skos:definition : statistical information publisher comprised of the government agencies and departments that publish statistical information on behalf of the U.S. Federal Government^^xsd:string</para>
    ///   <para>skos:example : Examples of American statistical information publishers include the Department of Commerce, Bureau of Economic Analysis (Commerce), Census Bureau (Commerce), Bureau of Labor Statistics (Labor), Department of the Treasury, and the Federal Reserve Board, among others.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/AmericanStatisticsPublisher">fibo-ind-ei-usei:AmericanStatisticsPublisher</a>
    /// </summary>
    let AmericanStatisticsPublisher = _prefixId.prefix "AmericanStatisticsPublisher"
    let BureauOfLaborStatistics = _prefixId.prefix "BureauOfLaborStatistics"
    /// <summary>
    ///   <para>rdfs:label : consumer expenditure survey^^xsd:string</para>
    ///   <para>skos:definition : statistical program conducted on a regular basis that provides information on the buying habits of consumers, including data on their expenditures, income, and consumer unit (families and single consumers) characteristics^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/ConsumerExpenditureSurvey">fibo-ind-ei-usei:ConsumerExpenditureSurvey</a>
    /// </summary>
    let ConsumerExpenditureSurvey = _prefixId.prefix "ConsumerExpenditureSurvey"
    /// <summary>
    ///   <para>rdfs:label : current employment statistics^^xsd:string</para>
    ///   <para>skos:definition : survey conducted on a regular basis that presents analytical information related to businesses and government agencies, in order to provide detailed industry data on employment, hours, and earnings of workers^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/CurrentEmploymentStatistics">fibo-ind-ei-usei:CurrentEmploymentStatistics</a>
    /// </summary>
    let CurrentEmploymentStatistics = _prefixId.prefix "CurrentEmploymentStatistics"
    /// <summary>
    ///   <para>rdfs:label : current population survey^^xsd:string</para>
    ///   <para>skos:definition : survey conducted on a regular basis that presents analytical information related to the general population of a given statistical area with respect to labor force, employment, unemployment, persons not in the labor force, hours of work, earnings, and other demographic and labor force characteristics^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/CurrentPopulationSurvey">fibo-ind-ei-usei:CurrentPopulationSurvey</a>
    /// </summary>
    let CurrentPopulationSurvey = _prefixId.prefix "CurrentPopulationSurvey"

    /// <summary>
    ///   <para>rdfs:label : employment situation establishment survey^^xsd:string</para>
    ///   <para>skos:definition : survey conducted on a regular basis that presents analytical information related to the labor force of a given statistical area, surveyed with respect to businesses, and is, for the most part, seasonally adjusted^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationEstablishmentSurvey">fibo-ind-ei-usei:EmploymentSituationEstablishmentSurvey</a>
    /// </summary>
    let EmploymentSituationEstablishmentSurvey =
        _prefixId.prefix "EmploymentSituationEstablishmentSurvey"

    /// <summary>
    ///   <para>rdfs:label : employment situation household survey^^xsd:string</para>
    ///   <para>skos:definition : a survey conducted on a regular basis that presents analytical information related to the labor force of a given statistical area, surveyed with respect to households, and is, for the most part, seasonally adjusted^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics and Statistics Canada reference definitions - https://wiki.edmcouncil.org/pages/viewpage.action?pageId=6358041^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationHouseholdSurvey">fibo-ind-ei-usei:EmploymentSituationHouseholdSurvey</a>
    /// </summary>
    let EmploymentSituationHouseholdSurvey =
        _prefixId.prefix "EmploymentSituationHouseholdSurvey"

    /// <summary>
    ///   <para>rdfs:label : employment situation survey^^xsd:string</para>
    ///   <para>skos:definition : a survey conducted on a regular basis that presents analytical information focused on the employment characteristics of a given statistical area^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/EmploymentSituationSurvey">fibo-ind-ei-usei:EmploymentSituationSurvey</a>
    /// </summary>
    let EmploymentSituationSurvey = _prefixId.prefix "EmploymentSituationSurvey"
    /// <summary>
    ///   <para>rdfs:label : point of purchase survey^^xsd:string</para>
    ///   <para>skos:definition : a program conducted on a regular basis that provides information on purchases of various items and services by consumers^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/PointOfPurchaseSurvey">fibo-ind-ei-usei:PointOfPurchaseSurvey</a>
    /// </summary>
    let PointOfPurchaseSurvey = _prefixId.prefix "PointOfPurchaseSurvey"
    /// <summary>
    ///   <para>rdfs:label : U.S. producer price index^^xsd:string</para>
    ///   <para>skos:definition : an economic indicator representing a measure of the change over time in the selling prices received by domestic producers for their output^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.bls.gov/ppi/^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/USProducerPriceIndex">fibo-ind-ei-usei:USProducerPriceIndex</a>
    /// </summary>
    let USProducerPriceIndex = _prefixId.prefix "USProducerPriceIndex"
    let UnitedStatesDepartmentOfLabor = _prefixId.prefix "UnitedStatesDepartmentOfLabor"
    /// <summary>
    ///   <para>rdfs:label : urban consumer price index^^xsd:string</para>
    ///   <para>skos:definition : an economic indicator representing a measure of the average change over time in the prices paid by urban consumers for a market basket of consumer goods and services^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CPI-U^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.bls.gov/cpi/^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/UrbanConsumerPriceIndex">fibo-ind-ei-usei:UrbanConsumerPriceIndex</a>
    /// </summary>
    let UrbanConsumerPriceIndex = _prefixId.prefix "UrbanConsumerPriceIndex"
    /// <summary>
    ///   <para>rdfs:label : urban consumers universe^^xsd:string</para>
    ///   <para>skos:definition : a statistical universe for consumer expenditure surveys consisting of people within a household that make joint expenditure decisions^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : U.S. Bureau of Labor Statistics, http://www.bls.gov/cpi/^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the United States, the CPI-U population, which covers about 88 percent of the U.S. population, covers households in all areas of the United States except people living in rural nonmetropolitan areas, in farm households, on military installations, in religious communities, and in institutions such as prisons and mental hospitals.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/UrbanConsumersUniverse">fibo-ind-ei-usei:UrbanConsumersUniverse</a>
    /// </summary>
    let UrbanConsumersUniverse = _prefixId.prefix "UrbanConsumersUniverse"
