#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-comm`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/" "fibo-der-drc-comm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : agricultural resource</para>
    ///   <para>skos:definition : negotiable commodity that is obtained via some agricultural process, including forestry, fishing, livestock, grain, dairy, corn, cocoa, soybeans, sugar, coffee</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/AgriculturalResource">fibo-der-drc-comm:AgriculturalResource</a>
    /// </summary>
    let AgriculturalResource = _prefixId.prefix "AgriculturalResource"
    /// <summary>
    ///   <para>rdfs:label : base metal</para>
    ///   <para>skos:definition : common metal that tarnishes, oxidizes, or corrodes relatively quickly when exposed to air or moisture, that is widely used in commercial and industrial applications, such as construction and manufacturing</para>
    ///   <para>cmns-av:explanatoryNote : Base metals or alloys include metals other than precious metals, such as copper, lead, zinc, tin, iron, steel, or brass. Note that iron and steel are included under metal and metal products in some classification schemes - see https://fred.stlouisfed.org/series/WPU101 for example.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BaseMetal">fibo-der-drc-comm:BaseMetal</a>
    /// </summary>
    let BaseMetal = _prefixId.prefix "BaseMetal"
    /// <summary>
    ///   <para>rdfs:label : basket of commodities^^xsd:string</para>
    ///   <para>skos:definition : custom basket whose constituents consist of one or more negotiable commodities^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <para>cmns-av:explanatoryNote : A commodity basket may contain constituents from one of the potential underlying assets or from multiple underlying assets.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BasketOfCommodities">fibo-der-drc-comm:BasketOfCommodities</a>
    /// </summary>
    let BasketOfCommodities = _prefixId.prefix "BasketOfCommodities"
    /// <summary>
    ///   <para>rdfs:label : bullion</para>
    ///   <para>skos:definition : physical precious metal that is officially recognized as being at least 99.5 percent pure</para>
    ///   <para>skos:example : In the United States, bullion that is eligible for reference in a commodities contract may include U.S. gold Buffalo coins minted by the U.S. Mint that are 1 troy ounce, 0.5 ounce, 0.25 ounce, or 0.10 ounce; 1 ounce silver coins; certain platinum coins; and gold, silver, palladium, and platinum bullion that meet or exceed the fineness requirements of a regulated futures contract. Bullion must also be certified by an approved certifier, typically identified by an exchange, including but not limited to the U.S. Mint.</para>
    ///   <para>cmns-av:explanatoryNote : Physical metals fall into two categories: (1) bullion, which are coins, ingots or bars of a specific weight and purity; and (2) "numismatic" or collectible coins, which can be rare or old coins, or special proofs that are newly minted as collectibles. If a particular asset is identified as "numismatic" or "collectible", it is, by definition, not considered bullion aside from its melt value.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Bullion">fibo-der-drc-comm:Bullion</a>
    /// </summary>
    let Bullion = _prefixId.prefix "Bullion"
    /// <summary>
    ///   <para>rdfs:label : commodity basket constituent^^xsd:string</para>
    ///   <para>skos:definition : component of a custom commodity basket whose relative importance with respect to other basket constituents is known^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityBasketConstituent">fibo-der-drc-comm:CommodityBasketConstituent</a>
    /// </summary>
    let CommodityBasketConstituent = _prefixId.prefix "CommodityBasketConstituent"
    /// <summary>
    ///   <para>rdfs:label : commodity derivative^^xsd:string</para>
    ///   <para>skos:definition : derivative instrument whose primary underlying item is a physical commodity, or the price, or related index, or any other aspect related to a physical commodity</para>
    ///   <para>cmns-av:explanatoryNote : The price of any commodity used as the basis for a commodity derivative may vary according to supply and demand as of the execution date of the contract and at various other times during the lifetime of the contract depending on contract terms. Valuation of a commodity derivative may depend on the spot price for the underlying commodity, futures price, supply and demand, convenience yield, cost of money and/or interest rates, volatility, which models were used to predict future pricing, and so forth.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivative">fibo-der-drc-comm:CommodityDerivative</a>
    /// </summary>
    let CommodityDerivative = _prefixId.prefix "CommodityDerivative"
    /// <summary>
    ///   <para>rdfs:label : commodity derivative underlier^^xsd:string</para>
    ///   <para>skos:definition : underlier of a commodity derivative, including, but not limited to, the negotiable commodity itself</para>
    ///   <para>cmns-av:explanatoryNote : The underlying of a commodity swap may include a physical commodity, or the price, or behavior of the price, or any other aspect of a physical commodity.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivativeUnderlier">fibo-der-drc-comm:CommodityDerivativeUnderlier</a>
    /// </summary>
    let CommodityDerivativeUnderlier = _prefixId.prefix "CommodityDerivativeUnderlier"
    /// <summary>
    ///   <para>rdfs:label : commodity forward</para>
    ///   <para>skos:definition : forward contract in which a buyer and seller agree upon delivery of a specified quality and quantity of goods at a specified future date</para>
    ///   <para>cmns-av:adaptedFrom : CFTC glossarycmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <para>cmns-av:explanatoryNote : Commodity forwards are often settled via cash transactions in many industries, including for the purposes of commodity merchandising. Terms may be more "personalized" than is the case with standardized futures contracts (i.e., delivery time and amount are as determined between seller and buyer). A price may be agreed upon in advance, or there may be agreement that the price will be determined at the time of delivery. A forward contract is a private and customizable agreement that settles at the end of the agreement and is traded over-the-counter.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityForward">fibo-der-drc-comm:CommodityForward</a>
    /// </summary>
    let CommodityForward = _prefixId.prefix "CommodityForward"
    /// <summary>
    ///   <para>rdfs:label : commodity future</para>
    ///   <para>skos:definition : futures contract to buy or sell a predetermined amount of a commodity at a specific price on a specific date in the future</para>
    ///   <para>cmns-av:adaptedFrom : CFTC glossarycmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <para>cmns-av:explanatoryNote : A commodity future is an agreement to purchase or sell a commodity for delivery in the future: (1) at a price that is determined at initiation of the contract; (2) that obligates each party to the contract to fulfill the contract at the specified price; (3) that is used to assume or shift price risk; and (4) that may be satisfied by delivery or offset.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityFuture">fibo-der-drc-comm:CommodityFuture</a>
    /// </summary>
    let CommodityFuture = _prefixId.prefix "CommodityFuture"
    /// <summary>
    ///   <para>rdfs:label : commodity index</para>
    ///   <para>skos:definition : investment vehicle that tracks a basket of commodities to measure their price and investment return performance</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityIndex">fibo-der-drc-comm:CommodityIndex</a>
    /// </summary>
    let CommodityIndex = _prefixId.prefix "CommodityIndex"
    /// <summary>
    ///   <para>rdfs:label : commodity option</para>
    ///   <para>skos:definition : option where the option buyer has the right to buy or sell specified commodities or commodity related index at a fixed price or formula, on or before a specified date</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityOption">fibo-der-drc-comm:CommodityOption</a>
    /// </summary>
    let CommodityOption = _prefixId.prefix "CommodityOption"
    /// <summary>
    ///   <para>rdfs:label : commodity return leg</para>
    ///   <para>skos:definition : leg of a commodity return swap in which the return is based on a physical commodity, or the price, or behavior of the price, or any other aspect related to a physical commodity</para>
    ///   <para>cmns-av:explanatoryNote : The cash flows from a commodity may be negative as you have a cost from holding the commodity but there are no interim cash flows, so it equates to a negative interest rate. So a commodity swap is like a TRS in that it is based on the return on the increase in value.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityReturnLeg">fibo-der-drc-comm:CommodityReturnLeg</a>
    /// </summary>
    let CommodityReturnLeg = _prefixId.prefix "CommodityReturnLeg"
    /// <summary>
    ///   <para>rdfs:label : commodity spot contract</para>
    ///   <para>skos:definition : contract that involves physical delivery of the commodity asset at settlement</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySpotContract">fibo-der-drc-comm:CommoditySpotContract</a>
    /// </summary>
    let CommoditySpotContract = _prefixId.prefix "CommoditySpotContract"
    /// <summary>
    ///   <para>rdfs:label : commodity swap</para>
    ///   <para>skos:definition : commodity derivative that includes, without limitation, any swap for which the primary underlying notional item is a physical commodity, or the price, or behavior of the price, or the level of a commodity index, or other aspect related to a physical commodity</para>
    ///   <para>cmns-av:adaptedFrom : CFTC glossarycmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <para>cmns-av:explanatoryNote : Commodities that can be swapped include: energy. metal, agriculture, environmental, freight, polypropylene products, fertilizer, paper, single and multiple commodity indexes and baskets, and multi-commodity assets where each leg references a different commodity.cmns-av:explanatoryNote : Commodity swaps typically involve the exchange of a floating commodity price for a set price over an agreed-upon period.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySwap">fibo-der-drc-comm:CommoditySwap</a>
    /// </summary>
    let CommoditySwap = _prefixId.prefix "CommoditySwap"
    /// <summary>
    ///   <para>rdfs:label : energy resource</para>
    ///   <para>skos:definition : negotiable commodity that is an energy-related product, or a derivative of an energy-related product, including electricity, renewable energy, or any power/energy delivered through a utility network of provider; diesel fuel, fuel oil, gas oil, gasoline, heating oil, jet fuel, kerosene, natural gas, oil (Brent, Tapis, Dubai, WTI)</para>
    ///   <para>skos:scopeNote : Note that the concept of an energy resource overlaps with generated resource and extraction resource but is not identical to either.</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyResource">fibo-der-drc-comm:EnergyResource</a>
    /// </summary>
    let EnergyResource = _prefixId.prefix "EnergyResource"
    /// <summary>
    ///   <para>rdfs:label : energy transmission rights</para>
    ///   <para>skos:definition : rights to the transmission of power across an electricity distribution network</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyTransmissionRights">fibo-der-drc-comm:EnergyTransmissionRights</a>
    /// </summary>
    let EnergyTransmissionRights = _prefixId.prefix "EnergyTransmissionRights"
    /// <summary>
    ///   <para>rdfs:label : environmental resource</para>
    ///   <para>skos:definition : negotiable commodity including offset credits</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnvironmentalResource">fibo-der-drc-comm:EnvironmentalResource</a>
    /// </summary>
    let EnvironmentalResource = _prefixId.prefix "EnvironmentalResource"
    /// <summary>
    ///   <para>rdfs:label : extraction resource</para>
    ///   <para>skos:definition : negotiable commodity that is a mineral resource obtained via withdrawal from the natural environment</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <para>cmns-av:explanatoryNote : These resources include ores, which contain commercially valuable amounts of metals, such as iron and aluminum, as well as precious metals, such as silver, gold, and platinum; precious stones, such as diamonds; building stones, such as granite; and solid fuels, such as coal and oil shale.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ExtractionResource">fibo-der-drc-comm:ExtractionResource</a>
    /// </summary>
    let ExtractionResource = _prefixId.prefix "ExtractionResource"
    /// <summary>
    ///   <para>rdfs:label : fertilizer resource</para>
    ///   <para>skos:definition : negotiable commodity that includes ammonia, diammonium phosphate (DAP), potash, sulphur, urea, urea and ammonium nitrate (UAN)</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FertilizerResource">fibo-der-drc-comm:FertilizerResource</a>
    /// </summary>
    let FertilizerResource = _prefixId.prefix "FertilizerResource"
    /// <summary>
    ///   <para>rdfs:label : freight resource</para>
    ///   <para>skos:definition : negotiable commodity that is a freight index route</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FreightResource">fibo-der-drc-comm:FreightResource</a>
    /// </summary>
    let FreightResource = _prefixId.prefix "FreightResource"
    /// <summary>
    ///   <para>rdfs:label : gas commodity</para>
    ///   <para>skos:definition : extraction resource that is natural gas</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GasCommodity">fibo-der-drc-comm:GasCommodity</a>
    /// </summary>
    let GasCommodity = _prefixId.prefix "GasCommodity"
    /// <summary>
    ///   <para>rdfs:label : generated resource</para>
    ///   <para>skos:definition : negotiable commodity obtained via some generation process, including electricity, renewable energy, or any power/energy delivered through a utility network or provider</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GeneratedResource">fibo-der-drc-comm:GeneratedResource</a>
    /// </summary>
    let GeneratedResource = _prefixId.prefix "GeneratedResource"
    /// <summary>
    ///   <para>rdfs:label : grain commodity</para>
    ///   <para>skos:definition : agricultural resource that is a small, hard seed, of a food plant, especially of a cereal plant, such as wheat, corn, rye, oats, rice, and millet</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GrainCommodity">fibo-der-drc-comm:GrainCommodity</a>
    /// </summary>
    let GrainCommodity = _prefixId.prefix "GrainCommodity"
    /// <summary>
    ///   <para>rdfs:label : industrial resource</para>
    ///   <para>skos:definition : negotiable commodity that is obtained via some industrial process, including construction and manufacturing</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/IndustrialResource">fibo-der-drc-comm:IndustrialResource</a>
    /// </summary>
    let IndustrialResource = _prefixId.prefix "IndustrialResource"
    /// <summary>
    ///   <para>rdfs:label : meat commodity</para>
    ///   <para>skos:definition : agricultural resource derived from the flesh of an animal (especially a mammal), such as pork bellies</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/MeatCommodity">fibo-der-drc-comm:MeatCommodity</a>
    /// </summary>
    let MeatCommodity = _prefixId.prefix "MeatCommodity"
    /// <summary>
    ///   <para>rdfs:label : metal</para>
    ///   <para>skos:definition : material that, when freshly prepared, polished, or fractured, shows a lustrous appearance, and conducts electricity and heat relatively well</para>
    ///   <para>skos:example : Examples include precious or industrial metal, such as aluminium, copper, gold, lead, nickel, platinum, silver, tin, zinc.</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10cmns-av:adaptedFrom : https://en.wikipedia.org/wiki/Metal</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Metal">fibo-der-drc-comm:Metal</a>
    /// </summary>
    let Metal = _prefixId.prefix "Metal"
    /// <summary>
    ///   <para>rdfs:label : oil commodity</para>
    ///   <para>skos:definition : generated resource that is a viscous liquid derived from petroleum, including for use as fuel, or as a lubricant, and the manufacture of many types of paints, plastics, and other materials</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilCommodity">fibo-der-drc-comm:OilCommodity</a>
    /// </summary>
    let OilCommodity = _prefixId.prefix "OilCommodity"
    /// <summary>
    ///   <para>rdfs:label : oil grade</para>
    ///   <para>skos:definition : measure of the viscosity of oil during operation</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilGrade">fibo-der-drc-comm:OilGrade</a>
    /// </summary>
    let OilGrade = _prefixId.prefix "OilGrade"
    /// <summary>
    ///   <para>rdfs:label : paper resource</para>
    ///   <para>skos:definition : negotiable commodity that is a paper product, including containerboard, newsprint, pulp, recovered paper</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PaperResource">fibo-der-drc-comm:PaperResource</a>
    /// </summary>
    let PaperResource = _prefixId.prefix "PaperResource"
    /// <summary>
    ///   <para>rdfs:label : polypropylene resource</para>
    ///   <para>skos:definition : negotiable commodity including plastics</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PolypropyleneResource">fibo-der-drc-comm:PolypropyleneResource</a>
    /// </summary>
    let PolypropyleneResource = _prefixId.prefix "PolypropyleneResource"
    /// <summary>
    ///   <para>rdfs:label : service resource</para>
    ///   <para>skos:definition : negotiable commodity involving services such as transportation, communications, and trade</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ServiceResource">fibo-der-drc-comm:ServiceResource</a>
    /// </summary>
    let ServiceResource = _prefixId.prefix "ServiceResource"
    /// <summary>
    ///   <para>rdfs:label : weather derivative^^xsd:string</para>
    ///   <para>skos:definition : derivative instrument whose primary underlying notional item is based on something related to the weather, for example, the average temperature in Chicago in January</para>
    ///   <para>cmns-av:adaptedFrom : CFTC glossary, https://www.cftc.gov/LearnAndProtect/EducationCenter/CFTCGlossary/glossary_wxyz.html</para>
    ///   <para>cmns-av:explanatoryNote : In the CFI standard, weather is classified as an environmental resource.cmns-av:explanatoryNote : Such a derivative can be used to hedge risks related to the demand for heating fuel or electricity. The underlying 'asset' is not a negotiable commodity per se, but because the weather can impact the prices and other things related to other commodities, weather derivatives are treated as commodity derivatives for regulatory purposes.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/WeatherDerivative">fibo-der-drc-comm:WeatherDerivative</a>
    /// </summary>
    let WeatherDerivative = _prefixId.prefix "WeatherDerivative"
    /// <summary>
    ///   <para>rdfs:label : has commodity value as of date^^xsd:string</para>
    ///   <para>skos:definition : indicates the per unit value of a given commodity as of some specified date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasCommodityValueAsOfDate">fibo-der-drc-comm:hasCommodityValueAsOfDate</a>
    /// </summary>
    let hasCommodityValueAsOfDate = _prefixId.prefix "hasCommodityValueAsOfDate"
    /// <summary>
    ///   <para>rdfs:label : has grade</para>
    ///   <para>skos:definition : The grade of oil e.g. Brent Crude.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasGrade">fibo-der-drc-comm:hasGrade</a>
    /// </summary>
    let hasGrade = _prefixId.prefix "hasGrade"
