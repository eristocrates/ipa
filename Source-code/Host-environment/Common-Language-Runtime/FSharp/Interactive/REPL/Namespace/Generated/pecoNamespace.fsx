#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module peco =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/peco#" "peco"
    /// <summary>
    ///   <para>rdfs:label : Emission Calculation Activity^^xsd:string</para>
    ///   <para>rdfs:comment : An activity representing a whole or a part of the carbon emission calculation process.^^xsd:string</para>
    ///   <a href="https://w3id.org/peco#EmissionCalculationActivity">peco:EmissionCalculationActivity</a>
    /// </summary>
    let EmissionCalculationActivity = _prefixId.prefix "EmissionCalculationActivity"
    /// <summary>
    ///   <para>rdfs:label : Emission Calculation Entity^^xsd:string</para>
    ///   <para>rdfs:comment : A prov:Entitiy representing quantifieble input and output data described as qudt:Quantity that influenced emission calculation process. If this data is produced as a result of some sensor observation it would be also of type sosa:Result.^^xsd:string</para>
    ///   <a href="https://w3id.org/peco#EmissionCalculationEntity">peco:EmissionCalculationEntity</a>
    /// </summary>
    let EmissionCalculationEntity = _prefixId.prefix "EmissionCalculationEntity"
    /// <summary>
    ///   <para>rdfs:label : Emission Generation Activity^^xsd:string</para>
    ///   <para>rdfs:comment : An activity that produces emissions. For example, training of ML models, driving a car, farming operation, etc. This activity can be represented at differentl levels of abstraction, for example, as a single overarching activity (e.g., factory producion for year 2022) or as a number of smaller activities (e.g., production of a single batch of products).^^xsd:string</para>
    ///   <a href="https://w3id.org/peco#EmissionGenerationActivity">peco:EmissionGenerationActivity</a>
    /// </summary>
    let EmissionGenerationActivity = _prefixId.prefix "EmissionGenerationActivity"
    /// <summary>
    ///   <para>rdfs:label : Emission Score^^xsd:string</para>
    ///   <para>rdfs:comment : The result of the peco:EmissionCalculationActivity representing the carbon emissions produced by the linked peco:EmissionGenerationActivity.^^xsd:string</para>
    ///   <a href="https://w3id.org/peco#EmissionScore">peco:EmissionScore</a>
    /// </summary>
    let EmissionScore = _prefixId.prefix "EmissionScore"
    /// <summary>
    ///   <para>rdfs:label : has emission score^^xsd:string</para>
    ///   <para>rdfs:comment : A property linking peco:EmissionGenerationActivity with a quantifiable representation of the amount of emissions prodcued by this activity.^^xsd:string</para>
    ///   <a href="https://w3id.org/peco#hasEmissionScore">peco:hasEmissionScore</a>
    /// </summary>
    let hasEmissionScore = _prefixId.prefix "hasEmissionScore"
    /// <summary>
    ///   <para>rdfs:label : in emission activity context^^xsd:string</para>
    ///   <para>rdfs:comment : A property linking peco:EmissionGenerationActivity to sosa:Observation. For example, a machine learning training activity (peco:EmissionGenerationActivity) is linked to electricity monitoring activity (sosa:Observation) that monitors electricity consumption of a GPU (sosa:FeatureOfInterest) used to train the ML model.^^xsd:string</para>
    ///   <a href="https://w3id.org/peco#inEmissionActivityContext">peco:inEmissionActivityContext</a>
    /// </summary>
    let inEmissionActivityContext = _prefixId.prefix "inEmissionActivityContext"
