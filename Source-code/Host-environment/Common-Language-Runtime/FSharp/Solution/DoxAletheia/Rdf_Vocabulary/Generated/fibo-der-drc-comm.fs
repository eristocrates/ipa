namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.CommoditiesContracts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_comm =
    let _namespace_iri = Namespace_Iri fibo_der_drc_comm |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-comm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Commodities Contracts Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_comm, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:AgriculturalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"agricultural resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/AgriculturalResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/AgriculturalResource</seealso>
    let AgriculturalResource =
        Prefixed_Name(fibo_der_drc_comm, "AgriculturalResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:BaseMetal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"base metal"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BaseMetal">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BaseMetal</seealso>
    let BaseMetal = Prefixed_Name(fibo_der_drc_comm, "BaseMetal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:BasketOfCommodities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basket of commodities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BasketOfCommodities">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/BasketOfCommodities</seealso>
    let BasketOfCommodities =
        Prefixed_Name(fibo_der_drc_comm, "BasketOfCommodities") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:Bullion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bullion"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Bullion">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Bullion</seealso>
    let Bullion = Prefixed_Name(fibo_der_drc_comm, "Bullion") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommodityBasketConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity basket constituent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityBasketConstituent">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityBasketConstituent</seealso>
    let CommodityBasketConstituent =
        Prefixed_Name(fibo_der_drc_comm, "CommodityBasketConstituent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommodityDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity derivative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivative</seealso>
    let CommodityDerivative =
        Prefixed_Name(fibo_der_drc_comm, "CommodityDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommodityDerivativeUnderlier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity derivative underlier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivativeUnderlier">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityDerivativeUnderlier</seealso>
    let CommodityDerivativeUnderlier =
        Prefixed_Name(fibo_der_drc_comm, "CommodityDerivativeUnderlier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommodityForward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity forward"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityForward">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityForward</seealso>
    let CommodityForward =
        Prefixed_Name(fibo_der_drc_comm, "CommodityForward") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommodityFuture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity future"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityFuture">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityFuture</seealso>
    let CommodityFuture =
        Prefixed_Name(fibo_der_drc_comm, "CommodityFuture") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommodityIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity index"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityIndex">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityIndex</seealso>
    let CommodityIndex =
        Prefixed_Name(fibo_der_drc_comm, "CommodityIndex") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommodityOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityOption</seealso>
    let CommodityOption =
        Prefixed_Name(fibo_der_drc_comm, "CommodityOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommodityReturnLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity return leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityReturnLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommodityReturnLeg</seealso>
    let CommodityReturnLeg =
        Prefixed_Name(fibo_der_drc_comm, "CommodityReturnLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommoditySpotContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity spot contract"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySpotContract">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySpotContract</seealso>
    let CommoditySpotContract =
        Prefixed_Name(fibo_der_drc_comm, "CommoditySpotContract") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:CommoditySwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodity swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/CommoditySwap</seealso>
    let CommoditySwap =
        Prefixed_Name(fibo_der_drc_comm, "CommoditySwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:EnergyResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"energy resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyResource</seealso>
    let EnergyResource =
        Prefixed_Name(fibo_der_drc_comm, "EnergyResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:EnergyTransmissionRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"energy transmission rights"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyTransmissionRights">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnergyTransmissionRights</seealso>
    let EnergyTransmissionRights =
        Prefixed_Name(fibo_der_drc_comm, "EnergyTransmissionRights") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:EnvironmentalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"environmental resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnvironmentalResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/EnvironmentalResource</seealso>
    let EnvironmentalResource =
        Prefixed_Name(fibo_der_drc_comm, "EnvironmentalResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:ExtractionResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"extraction resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ExtractionResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ExtractionResource</seealso>
    let ExtractionResource =
        Prefixed_Name(fibo_der_drc_comm, "ExtractionResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:FertilizerResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fertilizer resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FertilizerResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FertilizerResource</seealso>
    let FertilizerResource =
        Prefixed_Name(fibo_der_drc_comm, "FertilizerResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:FreightResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"freight resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FreightResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/FreightResource</seealso>
    let FreightResource =
        Prefixed_Name(fibo_der_drc_comm, "FreightResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:GasCommodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"gas commodity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GasCommodity">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GasCommodity</seealso>
    let GasCommodity = Prefixed_Name(fibo_der_drc_comm, "GasCommodity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:GeneratedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"generated resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GeneratedResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GeneratedResource</seealso>
    let GeneratedResource =
        Prefixed_Name(fibo_der_drc_comm, "GeneratedResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:GrainCommodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"grain commodity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GrainCommodity">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/GrainCommodity</seealso>
    let GrainCommodity =
        Prefixed_Name(fibo_der_drc_comm, "GrainCommodity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:IndustrialResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"industrial resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/IndustrialResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/IndustrialResource</seealso>
    let IndustrialResource =
        Prefixed_Name(fibo_der_drc_comm, "IndustrialResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:MeatCommodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"meat commodity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/MeatCommodity">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/MeatCommodity</seealso>
    let MeatCommodity =
        Prefixed_Name(fibo_der_drc_comm, "MeatCommodity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:Metal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"metal"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Metal">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/Metal</seealso>
    let Metal = Prefixed_Name(fibo_der_drc_comm, "Metal") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-comm:OilCommodity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"oil commodity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilCommodity">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilCommodity</seealso>
    let OilCommodity = Prefixed_Name(fibo_der_drc_comm, "OilCommodity") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-comm:OilGrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"oil grade"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilGrade">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/OilGrade</seealso>
    let OilGrade = Prefixed_Name(fibo_der_drc_comm, "OilGrade") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:PaperResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"paper resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PaperResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PaperResource</seealso>
    let PaperResource =
        Prefixed_Name(fibo_der_drc_comm, "PaperResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:PolypropyleneResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polypropylene resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PolypropyleneResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/PolypropyleneResource</seealso>
    let PolypropyleneResource =
        Prefixed_Name(fibo_der_drc_comm, "PolypropyleneResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:ServiceResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"service resource"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ServiceResource">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/ServiceResource</seealso>
    let ServiceResource =
        Prefixed_Name(fibo_der_drc_comm, "ServiceResource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:WeatherDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weather derivative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/WeatherDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/WeatherDerivative</seealso>
    let WeatherDerivative =
        Prefixed_Name(fibo_der_drc_comm, "WeatherDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:hasCommodityValueAsOfDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has commodity value as of date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasCommodityValueAsOfDate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasCommodityValueAsOfDate</seealso>
    let hasCommodityValueAsOfDate =
        Prefixed_Name(fibo_der_drc_comm, "hasCommodityValueAsOfDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-comm:hasGrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has grade"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasGrade">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/hasGrade</seealso>
    let hasGrade = Prefixed_Name(fibo_der_drc_comm, "hasGrade") |> PrefixedName
