namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.NorthAmericanIndicators.CAEconomicIndicators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ei_caei =
    let _namespace_iri = Namespace_Iri fibo_ind_ei_caei |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ei-caei:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Canadian Economic Indicators Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ei_caei, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-caei:CanadianConsumerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Canadian consumer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianConsumerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianConsumerPriceIndex</seealso>
    let CanadianConsumerPriceIndex =
        Prefixed_Name(fibo_ind_ei_caei, "CanadianConsumerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-caei:CanadianHouseholdsConsumersUniverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Canadian households consumers universe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianHouseholdsConsumersUniverse">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianHouseholdsConsumersUniverse</seealso>
    let CanadianHouseholdsConsumersUniverse =
        Prefixed_Name(fibo_ind_ei_caei, "CanadianHouseholdsConsumersUniverse") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-caei:CanadianProducerPriceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Canadian producer price index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianProducerPriceIndex">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianProducerPriceIndex</seealso>
    let CanadianProducerPriceIndex =
        Prefixed_Name(fibo_ind_ei_caei, "CanadianProducerPriceIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-caei:CanadianStatisticsPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ei-ei:StatisticalInformationPublisher</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canadian statistics publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianStatisticsPublisher">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/CanadianStatisticsPublisher</seealso>
    let CanadianStatisticsPublisher =
        Prefixed_Name(fibo_ind_ei_caei, "CanadianStatisticsPublisher") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-caei:IndustrialProductsSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"industrial products sector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/IndustrialProductsSector">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/IndustrialProductsSector</seealso>
    let IndustrialProductsSector =
        Prefixed_Name(fibo_ind_ei_caei, "IndustrialProductsSector") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-caei:NewHousingSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"new housing sector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/NewHousingSector">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/NewHousingSector</seealso>
    let NewHousingSector =
        Prefixed_Name(fibo_ind_ei_caei, "NewHousingSector") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-caei:RawMaterialsSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"raw materials sector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/RawMaterialsSector">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/RawMaterialsSector</seealso>
    let RawMaterialsSector =
        Prefixed_Name(fibo_ind_ei_caei, "RawMaterialsSector") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-caei:StatisticsCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"Statistics Canada"</para><para>"Statistique Canada"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/StatisticsCanada">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/StatisticsCanada</seealso>
    let StatisticsCanada =
        Prefixed_Name(fibo_ind_ei_caei, "StatisticsCanada") |> PrefixedName
