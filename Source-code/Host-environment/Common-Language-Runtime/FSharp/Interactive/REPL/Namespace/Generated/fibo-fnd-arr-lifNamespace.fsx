#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-arr-lif`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/" "fibo-fnd-arr-lif"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : lifecycle^^xsd:string</para>
    ///   <para>skos:definition : arrangement that compares the cyclical nature of families, organizations, processes, products, marketing, and order management, portfolio management or other systems with the cradle to grave life stages (birth, growth, maturity, decay, and death) of living organisms^^xsd:string</para>
    ///   <para>skos:example : The product life cycle describes the period of time over which an item is developed, brought to market and eventually removed from the market. The cycle is broken into four stages: introduction, growth, maturity and decline. The idea of the product life cycle is used in marketing to decide when it is appropriate to advertise, reduce prices, explore new markets or create new packaging.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/Lifecycle">fibo-fnd-arr-lif:Lifecycle</a>
    /// </summary>
    let Lifecycle = _prefixId.prefix "Lifecycle"
    /// <summary>
    ///   <para>rdfs:label : lifecycle event^^xsd:string</para>
    ///   <para>skos:definition : kind of event that occurs during one or more stages of a lifecycle^^xsd:string</para>
    ///   <para>skos:example : a call notification or coupon payment as a part of a bond lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEvent">fibo-fnd-arr-lif:LifecycleEvent</a>
    /// </summary>
    let LifecycleEvent = _prefixId.prefix "LifecycleEvent"
    /// <summary>
    ///   <para>rdfs:label : lifecycle event occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of an event in a stage of a lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEventOccurrence">fibo-fnd-arr-lif:LifecycleEventOccurrence</a>
    /// </summary>
    let LifecycleEventOccurrence = _prefixId.prefix "LifecycleEventOccurrence"
    /// <summary>
    ///   <para>rdfs:label : lifecycle occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of a lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleOccurrence">fibo-fnd-arr-lif:LifecycleOccurrence</a>
    /// </summary>
    let LifecycleOccurrence = _prefixId.prefix "LifecycleOccurrence"
    /// <summary>
    ///   <para>rdfs:label : lifecycle stage^^xsd:string</para>
    ///   <para>skos:definition : phase in a lifecycle^^xsd:string</para>
    ///   <para>skos:example : a research and development phase of a product lifecycle, the introduction phase in a marketing lifecycle, a growth stage in an economic lifecycle, or the origination phase in the lifecycle of a loan^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStage">fibo-fnd-arr-lif:LifecycleStage</a>
    /// </summary>
    let LifecycleStage = _prefixId.prefix "LifecycleStage"
    /// <summary>
    ///   <para>rdfs:label : lifecycle stage occurrence^^xsd:string</para>
    ///   <para>skos:definition : realization of a phase in a given lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStageOccurrence">fibo-fnd-arr-lif:LifecycleStageOccurrence</a>
    /// </summary>
    let LifecycleStageOccurrence = _prefixId.prefix "LifecycleStageOccurrence"
    /// <summary>
    ///   <para>rdfs:label : lifecycle status^^xsd:string</para>
    ///   <para>skos:definition : classifier indicating the position or state of something at a particular point in its life-cycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStatus">fibo-fnd-arr-lif:LifecycleStatus</a>
    /// </summary>
    let LifecycleStatus = _prefixId.prefix "LifecycleStatus"
    /// <summary>
    ///   <para>rdfs:label : has lifecycle^^xsd:string</para>
    ///   <para>skos:definition : relates something, such as a product, trade, or related process, to a lifecycle that characterizes it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasLifecycle">fibo-fnd-arr-lif:hasLifecycle</a>
    /// </summary>
    let hasLifecycle = _prefixId.prefix "hasLifecycle"
    /// <summary>
    ///   <para>rdfs:label : has stage^^xsd:string</para>
    ///   <para>skos:definition : relates something, such as a product or trade lifecycle or related process, to a phase or stage in that lifecycle^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasStage">fibo-fnd-arr-lif:hasStage</a>
    /// </summary>
    let hasStage = _prefixId.prefix "hasStage"
    /// <summary>
    ///   <para>rdfs:label : is lifecycle of^^xsd:string</para>
    ///   <para>skos:definition : relates a lifecycle to something it characterizes^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isLifecycleOf">fibo-fnd-arr-lif:isLifecycleOf</a>
    /// </summary>
    let isLifecycleOf = _prefixId.prefix "isLifecycleOf"
    /// <summary>
    ///   <para>rdfs:label : is stage of^^xsd:string</para>
    ///   <para>skos:definition : relates a stage in a product or trade lifecycle or process to the lifecycle or process that it is a stage of^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isStageOf">fibo-fnd-arr-lif:isStageOf</a>
    /// </summary>
    let isStageOf = _prefixId.prefix "isStageOf"
