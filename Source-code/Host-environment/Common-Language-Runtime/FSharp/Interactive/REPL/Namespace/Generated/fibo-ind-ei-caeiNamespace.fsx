#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-ei-caei`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/" "fibo-ind-ei-caei"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Canadian consumer price index^^xsd:string</para>
    ///   <para>skos:definition : economic indicator representing a measure of changes over time in the prices of a fixed basket of consumer goods and services that Canadian private households consume^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CPI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.statcan.gc.ca/eng/start^^xsd:anyURIcmns-av:adaptedFrom : https://www.statcan.gc.ca/en/subjects-start/prices_and_price_indexes/consumer_price_indexes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianConsumerPriceIndex">fibo-ind-ei-caei:CanadianConsumerPriceIndex</a>
    /// </summary>
    let CanadianConsumerPriceIndex = _prefixId.prefix "CanadianConsumerPriceIndex"

    /// <summary>
    ///   <para>rdfs:label : Canadian households consumers universe^^xsd:string</para>
    ///   <para>skos:definition : a statistical universe consisting of all private households in Canada, with the exception of soldiers on military bases, people living on First Nations reserves, institutionalized persons, and households living in the rural areas of the three northern territories^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.statcan.gc.ca/pub/62-553-x/62-553-x2015001-eng.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianHouseholdsConsumersUniverse">fibo-ind-ei-caei:CanadianHouseholdsConsumersUniverse</a>
    /// </summary>
    let CanadianHouseholdsConsumersUniverse =
        _prefixId.prefix "CanadianHouseholdsConsumersUniverse"

    /// <summary>
    ///   <para>rdfs:label : Canadian producer price index^^xsd:string</para>
    ///   <para>skos:definition : an economic indicator representing a measure of the change over time in the prices of a fixed-basket of domestic producer goods and services^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www23.statcan.gc.ca/imdb-bmdi/pub/indexth-eng.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Note that Canada does not produce a high level, cross industry PPI per se. Canadian PPIs are published by industry sector. Three of the most important are captured in the union defined herein, which may be expanded over time to integrate others, as needed.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianProducerPriceIndex">fibo-ind-ei-caei:CanadianProducerPriceIndex</a>
    /// </summary>
    let CanadianProducerPriceIndex = _prefixId.prefix "CanadianProducerPriceIndex"
    let CanadianStatisticsPublisher = _prefixId.prefix "CanadianStatisticsPublisher"
    /// <summary>
    ///   <para>rdfs:label : industrial products sector^^xsd:string</para>
    ///   <para>skos:definition : a classifier for a sector of the economy used for price indices focused on major commodities sold by manufacturers in Canada^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www23.statcan.gc.ca/imdb/p2SV.pl?Function=getSurvey&amp;SDDS=2318^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/IndustrialProductsSector">fibo-ind-ei-caei:IndustrialProductsSector</a>
    /// </summary>
    let IndustrialProductsSector = _prefixId.prefix "IndustrialProductsSector"
    /// <summary>
    ///   <para>rdfs:label : new housing sector^^xsd:string</para>
    ///   <para>skos:definition : a classifier for a sector of the economy used for price indices focused on contractors' selling prices of new residential houses, where detailed specifications pertaining to each house remain the same between two consecutive periods^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www23.statcan.gc.ca/imdb/p2SV.pl?Function=getSurvey&amp;SDDS=2310^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/NewHousingSector">fibo-ind-ei-caei:NewHousingSector</a>
    /// </summary>
    let NewHousingSector = _prefixId.prefix "NewHousingSector"
    /// <summary>
    ///   <para>rdfs:label : raw materials sector^^xsd:string</para>
    ///   <para>skos:definition : a classifier used for price indices related to raw materials purchased by industries in Canada for further processing^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www23.statcan.gc.ca/imdb/p2SV.pl?Function=getSurvey&amp;SDDS=2306^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/RawMaterialsSector">fibo-ind-ei-caei:RawMaterialsSector</a>
    /// </summary>
    let RawMaterialsSector = _prefixId.prefix "RawMaterialsSector"
    let StatisticsCanada = _prefixId.prefix "StatisticsCanada"
