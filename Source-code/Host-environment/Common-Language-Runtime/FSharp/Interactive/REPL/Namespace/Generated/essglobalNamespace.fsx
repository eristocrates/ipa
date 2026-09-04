#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module essglobal =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/essglobal/vocab/" "essglobal"

    let _namespaceIri = _prefixId.prefix ""
    let Activities = _prefixId.prefix "Activities"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : O endereço postal de uma Localização de venda, iniciativa de ESS ou rede.  dcterms:description : The physical address of the Location of Sale, SSe Initiative or Network. </para>
    ///   <para>rdfs:label : Endereçordfs:label : Address</para>
    ///   <a href="http://purl.org/essglobal/vocab/Address">essglobal:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : O custo de um determinado produto ou serviço produzido por uma iniciativa da ESS, incluindo todos os custos. O preço terá este custo somado aos custos de entrega e as margens de venda como podem ser vistos na categoria opção-venda.dcterms:description : The cost for a particular product or service produced by an SSE initiative or network, including all costs. The price will be this cost added to delivery costs and sales margin as can be seen in the sale-option class.</para>
    ///   <para>rdfs:label : Custordfs:label : Cost</para>
    ///   <a href="http://purl.org/essglobal/vocab/Cost">essglobal:Cost</a>
    /// </summary>
    let Cost = _prefixId.prefix "Cost"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : Discriminação de todos os insumos (como impostos e matérias-primas) e custos de mão de obra que compõem o custo final do produto ou serviço. Um preço transparente é um pré-requisito para sistemas solidários de comércio justo. dcterms:description : A breakdown of all inputs (as taxes and raw materials) and labour costs that make up the product or service's final cost. An open cost is a pre-requisite for solidarity fair trade systems. </para>
    ///   <para>rdfs:label : Composição de Custosrdfs:label : Cost Composition</para>
    ///   <a href="http://purl.org/essglobal/vocab/CostComposition">essglobal:CostComposition</a>
    /// </summary>
    let CostComposition = _prefixId.prefix "CostComposition"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : Um produto, serviço ou atividade usado para fazer o produto final ou o serviço. dcterms:description : A product, service, or activity that goes into making the final product or service. </para>
    ///   <para>rdfs:label : Insumordfs:label : Input</para>
    ///   <a href="http://purl.org/essglobal/vocab/Input">essglobal:Input</a>
    /// </summary>
    let Input = _prefixId.prefix "Input"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : Trabalho realizado para tarefas específicas relacionadas com o fornecimento de bens ou serviços oferecidos pela iniciativa da ESS. Em geral pode ser humano, animal ou trabalho de máquinas, mas em ESS global é apenas o trabalho humano.dcterms:description : Work done for specific tasks related to the provision of goods or services offered by the SSE initiative. Generally it can be human, animal or machine labour, but in ESSglobal it's human labour only.</para>
    ///   <para>rdfs:label : Trabalhordfs:label : Labour</para>
    ///   <a href="http://purl.org/essglobal/vocab/Labour">essglobal:Labour</a>
    /// </summary>
    let Labour = _prefixId.prefix "Labour"
    let LegalForm = _prefixId.prefix "LegalForm"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : Local onde são fornecidos os bens ou serviços de uma iniciativa da ESS. Podem ser lojas por conta própria, mas também lugares parceiros onde os produtos ou serviços estão disponíveis entre outros de outras iniciativas. dcterms:description : Place where the goods or services of an SSE initiative are provided. It can be self owned shops, but also partner places where the products or services are available among those from other initiatives. </para>
    ///   <para>rdfs:label : Local de Vendardfs:label : Location of Sale</para>
    ///   <a href="http://purl.org/essglobal/vocab/LocationOfSale">essglobal:LocationOfSale</a>
    /// </summary>
    let LocationOfSale = _prefixId.prefix "LocationOfSale"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : Uma rede de indivíduos e/ou organizações que participam da ESS. dcterms:description : A network of individuals and/or organizations that participate in the SSE. </para>
    ///   <para>rdfs:label : Rederdfs:label : Network</para>
    ///   <a href="http://purl.org/essglobal/vocab/Network">essglobal:Network</a>
    /// </summary>
    let Network = _prefixId.prefix "Network"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : Outros custos que têm impacto no custo final de um produto ou serviço fornecido por uma iniciativa da ESS, com excepção de insumos ou mão de obra, como impostos,desaprovação de maquinaria, fundos, etc. Os custos de entrega não estão incluídos nestes custos: eles estão incluídos na categoria opções-venda. dcterms:description : Other costs which impact on the final cost of a product or service provided by an SSE initiative, other than input or labour, like taxes, deprecation of machinery, funds, etc. The delivery costs are not included in these costs: they are included in the sale-options class. </para>
    ///   <para>rdfs:label : Outros Custosrdfs:label : Other Costs</para>
    ///   <a href="http://purl.org/essglobal/vocab/OtherCosts">essglobal:OtherCosts</a>
    /// </summary>
    let OtherCosts = _prefixId.prefix "OtherCosts"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : O bem oferecido por uma iniciativa da ESS. Podem ser bens materiais ou prestação de serviços. dcterms:description : The good offered by an SSE initiative. It may be material goods or provision of services. </para>
    ///   <para>rdfs:label : Produto ou Serviçordfs:label : Product or Service</para>
    ///   <a href="http://purl.org/essglobal/vocab/ProductOrService">essglobal:ProductOrService</a>
    /// </summary>
    let ProductOrService = _prefixId.prefix "ProductOrService"
    let Qualifiers = _prefixId.prefix "Qualifiers"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : Uma organização, a prática, uma rede, ou outra iniciativa que seja reconhecida como pertencendo à economia social solidária.  dcterms:description : An organization, practice, network, or other initiative that is recognized as belonging within the social solidarity economy.  </para>
    ///   <para>rdfs:label : Iniciativa ESSrdfs:label : SSE Initiative</para>
    ///   <a href="http://purl.org/essglobal/vocab/SSEInitiative">essglobal:SSEInitiative</a>
    /// </summary>
    let SSEInitiative = _prefixId.prefix "SSEInitiative"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:isDefinedBy : http://purl.org/essglobal/vocab/^^xsd:string</para>
    ///   <para>dcterms:description : Um Produto vendido a um determinado preço, sob características especificas, num determinado Local. dcterms:description : A Product sold at a certain price, under specific properties, in a certain Location. </para>
    ///   <para>rdfs:label : Opção de Vendardfs:label : Sale Option</para>
    ///   <a href="http://purl.org/essglobal/vocab/SaleOption">essglobal:SaleOption</a>
    /// </summary>
    let SaleOption = _prefixId.prefix "SaleOption"
    let TypeOfLabour = _prefixId.prefix "TypeOfLabour"
    /// <summary>
    ///   <para>dcterms:description : O custo de insumos por unidade.dcterms:description : The cost per unit of input.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>rdfs:label : Cost per Unitrdfs:label : Custo por Unidade</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/costPerUnit">essglobal:costPerUnit</a>
    /// </summary>
    let costPerUnit = _prefixId.prefix "costPerUnit"
    /// <summary>
    ///   <para>dcterms:description : O alcance da entrega do produto ou serviço, em quilómetros ou milhas.dcterms:description : Delivery range of product or service, in kilometers or miles.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>rdfs:label : Delivery Range (distance)rdfs:label : Alcance da Entrega (distância)</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/deliveryRangeDistance">essglobal:deliveryRangeDistance</a>
    /// </summary>
    let deliveryRangeDistance = _prefixId.prefix "deliveryRangeDistance"
    /// <summary>
    ///   <para>dcterms:description : Categorização do tipo de atividades exercidas por iniciativas da ESS, dependendo da sua natureza, das matérias-primas e da metodologia.dcterms:description : A categorization of the type of activities carried on by SSE initiatives, depending of its nature, raw materials and methodology.</para>
    ///   <para>rdfs:label : Setor Económicordfs:label : Economic Sector</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-08-05^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/economicSector">essglobal:economicSector</a>
    /// </summary>
    let economicSector = _prefixId.prefix "economicSector"
    /// <summary>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>rdfs:label : Tem um endereçordfs:label : Has an address</para>
    ///   <para>dcterms:description : Object Property that links a Network, SSEInitiative or LocationOfSale to it's Address. dcterms:description : Uma propriedade objecto que liga uma Network, SSEInitiative ou LocationOfSale ao seu endereço. </para>
    ///   <a href="http://purl.org/essglobal/vocab/hasAddress">essglobal:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>dcterms:description : An object property that links the Product or Service to its cost.dcterms:description : Uma propriedade objecto que lida um produto ou serviço ao seu custo.</para>
    ///   <para>rdfs:label : Has Costrdfs:label : Tem Custo</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/hasCost">essglobal:hasCost</a>
    /// </summary>
    let hasCost = _prefixId.prefix "hasCost"
    /// <summary>
    ///   <para>rdfs:label : Tem impacto no custordfs:label : Has impact on cost</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:description : Does the input contribute to the monetary cost of the final product? Whereas many (perhaps most) inputs do contribute to the monetary price of the final product or service, some don't. For example, volunteer labour may contribute greatly to production without adding to the monetary cost of production.his property is of boolean type: Yes or No.dcterms:description : O insumo contribui para o custo monetário do produto final? Considerando que muitos (talvez a maioria) insumos contribuem para o valor monetário do produto final ou serviço, outros não. Por exemplo, o trabalho voluntário pode contribuir muito para a produção sem aumentar o valor monetário do custo de produção.Esta propriedade é do tipo Booleano. Toma os valores 'Sim' ou 'Não'.</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/hasImpactOnCost">essglobal:hasImpactOnCost</a>
    /// </summary>
    let hasImpactOnCost = _prefixId.prefix "hasImpactOnCost"
    /// <summary>
    ///   <para>dcterms:description : Propriedade objecto que liga uma composição de preço (CostComposition) a um input que pode ser um produto, serviço ou actividade, usado para fazer o produto final ou o serviço.dcterms:description : Object property that links a CostComposition to input that can be a product, service, or activity that goes into making the final product or service.</para>
    ///   <para>rdfs:label : Tem insumordfs:label : Has input</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/hasInputCost">essglobal:hasInputCost</a>
    /// </summary>
    let hasInputCost = _prefixId.prefix "hasInputCost"
    /// <summary>
    ///   <para>rdfs:label : Tem Trabalhordfs:label : Has Labour</para>
    ///   <para>dcterms:description : Object Property to link the CostComposition to the Work done for specific tasks related to the provision of goods or services offered by the SSE initiative. Generally it can be human, animal or machine labour, but in ESSglobal it's human labour only.dcterms:description : Propriedade objecto que liga a Composição do Trabalho (CostComposition) ao trabalho realizado para tarefas específicas relacionadas com o fornecimento de bens ou serviços oferecidos pela iniciativa da ESS. Em geral pode ser humano, animal ou trabalho de máquinas, mas em ESS global é apenas o trabalho humano.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/hasLabourCost">essglobal:hasLabourCost</a>
    /// </summary>
    let hasLabourCost = _prefixId.prefix "hasLabourCost"
    /// <summary>
    ///   <para>rdfs:label : Has Other Costsrdfs:label : Tem Outros Custos</para>
    ///   <para>dcterms:description : Propriedade objecto que liga uma composição de preço (CostComposition) a outros custos (OtherCosts) que têm impacto no custo final de um produto ou serviço fornecido por uma iniciativa da ESS, com excepção de insumo ou mão de obra, como impostos,desaprovação de maquinaria, fundos, etc. Os custos de entrega não estão incluídos nestes custos: eles estão incluídos na categoria opções-venda.dcterms:description : Object Property that links a CostComposition to other costs which impact on the final cost of a product or service provided by an SSE initiative, other than input or labour, like taxes, deprecation of machinery, funds, etc. The delivery costs are not included in these costs: they are included in the sale-options class.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/hasOtherCosts">essglobal:hasOtherCosts</a>
    /// </summary>
    let hasOtherCosts = _prefixId.prefix "hasOtherCosts"
    /// <summary>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:label : Tem Produto ou Serviçordfs:label : Has Product or Service</para>
    ///   <para>dcterms:description : Object Property that links to the Network or SSE Initiative' products or services.dcterms:description : Uma Rede ou Iniciativa da ESS produz produtos ou disponibiliza serviços.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/hasProductOrService">essglobal:hasProductOrService</a>
    /// </summary>
    let hasProductOrService = _prefixId.prefix "hasProductOrService"
    /// <summary>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>rdfs:label : Tem uma Opção de Vendardfs:label : Has a Sale Option</para>
    ///   <para>dcterms:description : An object property that links the Product or service to the place where the product or service is provided.dcterms:description : Uma propriedade objecto que liga o Produto ou serviço ao local onde o produto ou serviço é disponibilizado.</para>
    ///   <a href="http://purl.org/essglobal/vocab/hasSaleOption">essglobal:hasSaleOption</a>
    /// </summary>
    let hasSaleOption = _prefixId.prefix "hasSaleOption"
    /// <summary>
    ///   <para>rdfs:label : Está disponívelrdfs:label : Is available</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:description : Uma propriedade que especifica se a Opção de Venda (o produto/serviço a um determinado preço, ao abrigo de definições especificas, num Local de Venda especifico) está disponível.Esta propriedade é um booleano, toma os valores: 'Sim' ou 'Não'.dcterms:description : Property that specifies if the Sale Option (the product/service at a certain price, under specific properties, in a specific Sale Location) is available.THis property us a boolena: Yes or No.</para>
    ///   <a href="http://purl.org/essglobal/vocab/isAvailable">essglobal:isAvailable</a>
    /// </summary>
    let isAvailable = _prefixId.prefix "isAvailable"
    /// <summary>
    ///   <para>dcterms:description : Object Property tha links a Product or Service that is sold at a certain location of sale under specific definitions.dcterms:description : Uma propriedade objecto que liga um Produto ou Serviço que é vendido num determinado local de venda (LocationOfSale)) sob definições especificas.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:label : Disponível Emrdfs:label : Available At</para>
    ///   <a href="http://purl.org/essglobal/vocab/isAvailableAt">essglobal:isAvailableAt</a>
    /// </summary>
    let isAvailableAt = _prefixId.prefix "isAvailableAt"
    /// <summary>
    ///   <para>rdfs:label : Is Composed Byrdfs:label : É Composto Por</para>
    ///   <para>dcterms:description : Uma propriedade objecto que liga um custo à sua discriminação, com todos os insumos (como impostos e matérias-primas) e custos de mão de obra que compõem o custo final do produto ou serviço. Um preço transparente é um pré-requisito para sistemas solidários de comércio justo.dcterms:description : An object property that links a Cost to the breakdown of all its inputs (as taxes and raw materials) and labour costs that make up the product or service's final cost. An open cost is a pre-requisite for solidarity fair trade systems.</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/isComposedBy">essglobal:isComposedBy</a>
    /// </summary>
    let isComposedBy = _prefixId.prefix "isComposedBy"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>rdfs:label : Is Mainrdfs:label : É o Principal</para>
    ///   <para>dcterms:description : Se o Local de Venda é a sede da iniciativa de ESS?Esta propriedade é do tipo Booleano. Toma os valores 'Sim' ou 'Não'.dcterms:description : If the Location of Sale is the headquarter of the SSE initiative?This property is of boolean type: Yes or No.</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/isMain">essglobal:isMain</a>
    /// </summary>
    let isMain = _prefixId.prefix "isMain"
    /// <summary>
    ///   <para>rdfs:label : É Iniciativa da ESSrdfs:label : Is SSE Initiative</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:description : If the Location of Sale is a place belonging to the SSE.This property is of boolean type: Yes or No.dcterms:description : Se o Local de Venda é um lugar pertencente à ESS.Esta propriedade é do tipo Booleano. Toma os valores 'Sim' ou 'Não'.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/isSSE">essglobal:isSSE</a>
    /// </summary>
    let isSSE = _prefixId.prefix "isSSE"
    /// <summary>
    ///   <para>rdfs:label : Legal Formrdfs:label : Forma Jurídica</para>
    ///   <para>dcterms:modified : 2014-08-05^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:description : A forma jurídica de uma Iniciativa ESS ou Rede. Para ser descrito.dcterms:description : The legal form of a SSE Initiative or Network.To be described.</para>
    ///   <a href="http://purl.org/essglobal/vocab/legalForm">essglobal:legalForm</a>
    /// </summary>
    let legalForm = _prefixId.prefix "legalForm"
    /// <summary>
    ///   <para>dcterms:description : A visão, os valores e princípios da iniciativa.dcterms:description : The initiative's vision, values, and principles.</para>
    ///   <para>rdfs:label : Missãordfs:label : Mission</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/mission">essglobal:mission</a>
    /// </summary>
    let mission = _prefixId.prefix "mission"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:description : Etapas acionáveis ​​e mensuráveis ​​que a Iniciativa ESS está a tomar para cumprir a sua missão. dcterms:description : Actionable and measurable steps the SSE Initiative is taking to carry out its mission. </para>
    ///   <para>rdfs:label : Objetivordfs:label : Objective</para>
    ///   <a href="http://purl.org/essglobal/vocab/objective">essglobal:objective</a>
    /// </summary>
    let objective = _prefixId.prefix "objective"
    /// <summary>
    ///   <para>rdfs:label : Qualificadorrdfs:label : Qualifier</para>
    ///   <para>dcterms:modified : 2014-08-05^^xsd:date</para>
    ///   <para>dcterms:description : Aspect that differentiates the product or service of an SSE initiative which is related to the form of production, the actors involved, the use of only organic materials, etc. Examples are organic, permacultural, made with recycled raw materials, indigenous, made by women, etc.dcterms:description : Aspecto que diferencia o produto ou serviço de uma iniciativa ESS que está relacionado com a forma de produção, os atores envolvidos, o uso de apenas materiais orgânicos, etc. Exemplos são orgânicos, permacultura, feitos com matérias-primas recicladas, indígenas, feitos por mulheres, etc.</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/qualifier">essglobal:qualifier</a>
    /// </summary>
    let qualifier = _prefixId.prefix "qualifier"

    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:description : The quantity of the input that goes into providing one unit of the final product or service. dcterms:description : A quantidade de insumos que é utilizada para providenciar uma unidade do produto final ou serviço. </para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:label : Quantidade por Unidade de Produto ou Serviçordfs:label : Quantity per Product or Service Unit</para>
    ///   <a href="http://purl.org/essglobal/vocab/quantityPerProductOrServiceUnit">essglobal:quantityPerProductOrServiceUnit</a>
    /// </summary>
    let quantityPerProductOrServiceUnit =
        _prefixId.prefix "quantityPerProductOrServiceUnit"

    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:description : Margin (on sales) is the difference between selling price and cost. This difference is typically expressed either as a percentage of selling price or on a per-unit basis. This attribute is the percentage sales margin.dcterms:description : Margem (em vendas) é a diferença entre o preço de venda e o custo. Esta diferença é normalmente expressa como uma percentagem do preço de venda ou com base por unidade. Este atributo é a percentagem da margem de vendas.</para>
    ///   <para>rdfs:label : Sales Margin (percentage)rdfs:label : Margem de Vendas (percentagem)</para>
    ///   <a href="http://purl.org/essglobal/vocab/salesMarginPercentage">essglobal:salesMarginPercentage</a>
    /// </summary>
    let salesMarginPercentage = _prefixId.prefix "salesMarginPercentage"
    /// <summary>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:label : Margem de Vendas (valor)rdfs:label : Sales Margin (value)</para>
    ///   <para>dcterms:description : Margem (em vendas) é a diferença entre o preço de venda e o custo. Esta diferença é normalmente expressa como uma percentagem do preço de venda ou com base por unidade. O presente atributo é um valor absoluto para a margem de vendas em cada uma das unidades do produto ou serviço oferecido no local.dcterms:description : Margin (on sales) is the difference between selling price and cost. This difference is typically expressed either as a percentage of selling price or on a per-unit basis. The present attribute is an absolute value for sales margin on each unit of the product or service offered in the location.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/salesMarginValue">essglobal:salesMarginValue</a>
    /// </summary>
    let salesMarginValue = _prefixId.prefix "salesMarginValue"
    /// <summary>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:label : Staterdfs:label : Estado</para>
    ///   <para>dcterms:description : O Estado onde a Localização da Venda está situado.dcterms:description : The State of the Address.</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/state">essglobal:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    /// <summary>
    ///   <para>dcterms:description : O número de homens que trabalham na Iniciativa ESS.dcterms:description : The number of men that work in the SSE Initiative.</para>
    ///   <para>rdfs:label : Total of Menrdfs:label : Total de Homens</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/totalMen">essglobal:totalMen</a>
    /// </summary>
    let totalMen = _prefixId.prefix "totalMen"
    /// <summary>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:description : O número total de associados que trabalham na Iniciativa ESS.dcterms:description : The total number of members that work in the SSE Initiative.</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>rdfs:label : Total of Membersrdfs:label : Total de Associados</para>
    ///   <a href="http://purl.org/essglobal/vocab/totalOfMembers">essglobal:totalOfMembers</a>
    /// </summary>
    let totalOfMembers = _prefixId.prefix "totalOfMembers"
    /// <summary>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <para>dcterms:description : O número de mulheres que trabalham na Iniciativa ESS.dcterms:description : The number of women that work in the SSE Initiative.</para>
    ///   <para>rdfs:label : Total de Mulheresrdfs:label : Total of Women</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/totalWomen">essglobal:totalWomen</a>
    /// </summary>
    let totalWomen = _prefixId.prefix "totalWomen"
    /// <summary>
    ///   <para>dcterms:description : The human labour dedicated for providing goods or services can be of different types, depending on the established labour relations. For example, it might be associative (i.e., the worker is one of the collective owners of the SSE initiative), but it might also be subordinated work (an employee of the SSE initiative), volunteer work or externally hired work (like a freelancer or a partner initiative).dcterms:description : O trabalho humano dedicado ao fornecimento de bens ou serviços pode ser de diferentes tipos, dependendo das relações de trabalho estabelecidas. Por exemplo, pode ser associativo (i.e., o trabalhador é um dos proprietários coletivos da iniciativa ESS), mas também pode ser trabalho subordinado (um empregado da iniciativa ESS), trabalho voluntário ou trabalho contratado externamente (como um freelancer ou uma iniciativa de parceria).</para>
    ///   <para>rdfs:label : Tipo de Trabalhordfs:label : Type of Labour</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/typeOfLabour">essglobal:typeOfLabour</a>
    /// </summary>
    let typeOfLabour = _prefixId.prefix "typeOfLabour"
    /// <summary>
    ///   <para>rdfs:label : Unitrdfs:label : Unidade</para>
    ///   <para>dcterms:description : The unit that a product or service is measured in, in the Universal Unit System (e.g., kilograms, hours)dcterms:description : A unidade em que um produto ou serviço é medido, no Sistema Universal de Unidades (e.g., quilogramas, horas)</para>
    ///   <para>dcterms:modified : 2015-05-04^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-02-06^^xsd:date</para>
    ///   <a href="http://purl.org/essglobal/vocab/unit">essglobal:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
