namespace http.purl.org.essglobal.vocab.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module essglobal =
    let _namespace_iri = Namespace_Iri essglobal |> NamespaceIRI

    /// <summary>
    ///   <para>essglobal:quantityPerProductOrServiceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Quantidade por Unidade de Produto ou Serviço</para><para>Quantity per Product or Service Unit</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/quantityPerProductOrServiceUnit">http://purl.org/essglobal/vocab/quantityPerProductOrServiceUnit</seealso>
    let quantityPerProductOrServiceUnit =
        Prefixed_Name(essglobal, "quantityPerProductOrServiceUnit") |> PrefixedName

    /// <summary>
    ///   <para>essglobal:salesMarginPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Margem de Vendas (percentagem)</para><para>Sales Margin (percentage)</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/salesMarginPercentage">http://purl.org/essglobal/vocab/salesMarginPercentage</seealso>
    let salesMarginPercentage =
        Prefixed_Name(essglobal, "salesMarginPercentage") |> PrefixedName

    /// <summary>
    ///   <para>essglobal:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Estado</para><para>State</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/state">http://purl.org/essglobal/vocab/state</seealso>
    let state = Prefixed_Name(essglobal, "state") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:totalOfMembers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Total de Associados</para><para>Total of Members</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/totalOfMembers">http://purl.org/essglobal/vocab/totalOfMembers</seealso>
    let totalOfMembers = Prefixed_Name(essglobal, "totalOfMembers") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:totalWomen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Total de Mulheres</para><para>Total of Women</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/totalWomen">http://purl.org/essglobal/vocab/totalWomen</seealso>
    let totalWomen = Prefixed_Name(essglobal, "totalWomen") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Unidade</para><para>Unit</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/unit">http://purl.org/essglobal/vocab/unit</seealso>
    let unit = Prefixed_Name(essglobal, "unit") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:SSEInitiative</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>SSE Initiative</para><para>Iniciativa ESS</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/SSEInitiative">http://purl.org/essglobal/vocab/SSEInitiative</seealso>
    let SSEInitiative = Prefixed_Name(essglobal, "SSEInitiative") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:SaleOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Opção de Venda</para><para>Sale Option</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/SaleOption">http://purl.org/essglobal/vocab/SaleOption</seealso>
    let SaleOption = Prefixed_Name(essglobal, "SaleOption") |> PrefixedName

    /// <summary>
    ///   <para>essglobal:deliveryRangeDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Alcance da Entrega (distância)</para><para>Delivery Range (distance)</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/deliveryRangeDistance">http://purl.org/essglobal/vocab/deliveryRangeDistance</seealso>
    let deliveryRangeDistance =
        Prefixed_Name(essglobal, "deliveryRangeDistance") |> PrefixedName

    /// <summary>
    ///   <para>essglobal:economicSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Setor Económico</para><para>Economic Sector</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/economicSector">http://purl.org/essglobal/vocab/economicSector</seealso>
    let economicSector = Prefixed_Name(essglobal, "economicSector") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:hasCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Tem Custo</para><para>Has Cost</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/hasCost">http://purl.org/essglobal/vocab/hasCost</seealso>
    let hasCost = Prefixed_Name(essglobal, "hasCost") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:Activities</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Actividades VES</para><para>Activities VES</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/Activities">http://purl.org/essglobal/vocab/Activities</seealso>
    let Activities = Prefixed_Name(essglobal, "Activities") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Endereço</para><para>Address</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/Address">http://purl.org/essglobal/vocab/Address</seealso>
    let Address = Prefixed_Name(essglobal, "Address") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:Cost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Custo</para><para>Cost</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/Cost">http://purl.org/essglobal/vocab/Cost</seealso>
    let Cost = Prefixed_Name(essglobal, "Cost") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Insumo</para><para>Input</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/Input">http://purl.org/essglobal/vocab/Input</seealso>
    let Input = Prefixed_Name(essglobal, "Input") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:Labour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Trabalho</para><para>Labour</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/Labour">http://purl.org/essglobal/vocab/Labour</seealso>
    let Labour = Prefixed_Name(essglobal, "Labour") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:CostComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Composição de Custos</para><para>Cost Composition</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/CostComposition">http://purl.org/essglobal/vocab/CostComposition</seealso>
    let CostComposition = Prefixed_Name(essglobal, "CostComposition") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:LegalForm</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Forma Jurídica VES</para><para>Legal Form VES</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/LegalForm">http://purl.org/essglobal/vocab/LegalForm</seealso>
    let LegalForm = Prefixed_Name(essglobal, "LegalForm") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Network</para><para>Rede</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/Network">http://purl.org/essglobal/vocab/Network</seealso>
    let Network = Prefixed_Name(essglobal, "Network") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:OtherCosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Outros Custos</para><para>Other Costs</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/OtherCosts">http://purl.org/essglobal/vocab/OtherCosts</seealso>
    let OtherCosts = Prefixed_Name(essglobal, "OtherCosts") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:Qualifiers</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Qualificadores VES</para><para>Qualifiers VES</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/Qualifiers">http://purl.org/essglobal/vocab/Qualifiers</seealso>
    let Qualifiers = Prefixed_Name(essglobal, "Qualifiers") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:LocationOfSale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Location of Sale</para><para>Local de Venda</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/LocationOfSale">http://purl.org/essglobal/vocab/LocationOfSale</seealso>
    let LocationOfSale = Prefixed_Name(essglobal, "LocationOfSale") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:ProductOrService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Product or Service</para><para>Produto ou Serviço</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/ProductOrService">http://purl.org/essglobal/vocab/ProductOrService</seealso>
    let ProductOrService = Prefixed_Name(essglobal, "ProductOrService") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:TypeOfLabour</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Tipo de Trabalho VES</para><para>Type of Labour VES</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/TypeOfLabour">http://purl.org/essglobal/vocab/TypeOfLabour</seealso>
    let TypeOfLabour = Prefixed_Name(essglobal, "TypeOfLabour") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:costPerUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Custo por Unidade</para><para>Cost per Unit</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/costPerUnit">http://purl.org/essglobal/vocab/costPerUnit</seealso>
    let costPerUnit = Prefixed_Name(essglobal, "costPerUnit") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Tem um endereço</para><para>Has an address</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/hasAddress">http://purl.org/essglobal/vocab/hasAddress</seealso>
    let hasAddress = Prefixed_Name(essglobal, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:hasImpactOnCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Tem impacto no custo</para><para>Has impact on cost</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/hasImpactOnCost">http://purl.org/essglobal/vocab/hasImpactOnCost</seealso>
    let hasImpactOnCost = Prefixed_Name(essglobal, "hasImpactOnCost") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:hasLabourCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Tem Trabalho</para><para>Has Labour</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/hasLabourCost">http://purl.org/essglobal/vocab/hasLabourCost</seealso>
    let hasLabourCost = Prefixed_Name(essglobal, "hasLabourCost") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:hasInputCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Tem insumo</para><para>Has input</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/hasInputCost">http://purl.org/essglobal/vocab/hasInputCost</seealso>
    let hasInputCost = Prefixed_Name(essglobal, "hasInputCost") |> PrefixedName

    /// <summary>
    ///   <para>essglobal:hasProductOrService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Product or Service</para><para>Tem Produto ou Serviço</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/hasProductOrService">http://purl.org/essglobal/vocab/hasProductOrService</seealso>
    let hasProductOrService =
        Prefixed_Name(essglobal, "hasProductOrService") |> PrefixedName

    /// <summary>
    ///   <para>essglobal:hasSaleOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Tem uma Opção de Venda</para><para>Has a Sale Option</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/hasSaleOption">http://purl.org/essglobal/vocab/hasSaleOption</seealso>
    let hasSaleOption = Prefixed_Name(essglobal, "hasSaleOption") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:isAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Está disponível</para><para>Is available</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/isAvailable">http://purl.org/essglobal/vocab/isAvailable</seealso>
    let isAvailable = Prefixed_Name(essglobal, "isAvailable") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:isAvailableAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Disponível Em</para><para>Available At</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/isAvailableAt">http://purl.org/essglobal/vocab/isAvailableAt</seealso>
    let isAvailableAt = Prefixed_Name(essglobal, "isAvailableAt") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:isComposedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>É Composto Por</para><para>Is Composed By</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/isComposedBy">http://purl.org/essglobal/vocab/isComposedBy</seealso>
    let isComposedBy = Prefixed_Name(essglobal, "isComposedBy") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:isMain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>É o Principal</para><para>Is Main</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/isMain">http://purl.org/essglobal/vocab/isMain</seealso>
    let isMain = Prefixed_Name(essglobal, "isMain") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:legalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Forma Jurídica</para><para>Legal Form</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/legalForm">http://purl.org/essglobal/vocab/legalForm</seealso>
    let legalForm = Prefixed_Name(essglobal, "legalForm") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:isSSE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>É Iniciativa da ESS</para><para>Is SSE Initiative</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/isSSE">http://purl.org/essglobal/vocab/isSSE</seealso>
    let isSSE = Prefixed_Name(essglobal, "isSSE") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:mission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Mission</para><para>Missão</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/mission">http://purl.org/essglobal/vocab/mission</seealso>
    let mission = Prefixed_Name(essglobal, "mission") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:hasOtherCosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Tem Outros Custos</para><para>Has Other Costs</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/hasOtherCosts">http://purl.org/essglobal/vocab/hasOtherCosts</seealso>
    let hasOtherCosts = Prefixed_Name(essglobal, "hasOtherCosts") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:objective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Objective</para><para>Objetivo</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/objective">http://purl.org/essglobal/vocab/objective</seealso>
    let objective = Prefixed_Name(essglobal, "objective") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:qualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Qualificador</para><para>Qualifier</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/qualifier">http://purl.org/essglobal/vocab/qualifier</seealso>
    let qualifier = Prefixed_Name(essglobal, "qualifier") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:salesMarginValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Margem de Vendas (valor)</para><para>Sales Margin (value)</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/salesMarginValue">http://purl.org/essglobal/vocab/salesMarginValue</seealso>
    let salesMarginValue = Prefixed_Name(essglobal, "salesMarginValue") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:totalMen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Total de Homens</para><para>Total of Men</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/totalMen">http://purl.org/essglobal/vocab/totalMen</seealso>
    let totalMen = Prefixed_Name(essglobal, "totalMen") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:typeOfLabour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Tipo de Trabalho</para><para>Type of Labour</para></remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/typeOfLabour">http://purl.org/essglobal/vocab/typeOfLabour</seealso>
    let typeOfLabour = Prefixed_Name(essglobal, "typeOfLabour") |> PrefixedName
    /// <summary>
    ///   <para>essglobal:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/essglobal/vocab/">http://purl.org/essglobal/vocab/</seealso>
    let _prefix_iri = Prefixed_Name(essglobal, "") |> PrefixedName
