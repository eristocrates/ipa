#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sri =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/sri#" "sri"
    /// <summary>
    ///   <para>rdfs:label : Building</para>
    ///   <para>rdfs:comment : This represents a building which is assessed.</para>
    ///   <a href="https://w3id.org/sri#Building">sri:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:label : Domain</para>
    ///   <para>rdfs:comment : Class of technical domains.</para>
    ///   <a href="https://w3id.org/sri#Domain">sri:Domain</a>
    /// </summary>
    let Domain = _prefixId.prefix "Domain"
    /// <summary>
    ///   <para>rdfs:label : FunctionalThing</para>
    ///   <para>rdfs:comment : Class of instances in the functional hierarchy, this includes Domains and Services.</para>
    ///   <a href="https://w3id.org/sri#FunctionalThing">sri:FunctionalThing</a>
    /// </summary>
    let FunctionalThing = _prefixId.prefix "FunctionalThing"
    /// <summary>
    ///   <para>rdfs:label : Impact</para>
    ///   <para>rdfs:comment : Class of Impacts.</para>
    ///   <a href="https://w3id.org/sri#Impact">sri:Impact</a>
    /// </summary>
    let Impact = _prefixId.prefix "Impact"
    /// <summary>
    ///   <para>rdfs:label : ImpactThing</para>
    ///   <para>rdfs:comment : Class of all instances in the impact hierarchy, this includes Impacts and Key Capabilities.</para>
    ///   <a href="https://w3id.org/sri#ImpactThing">sri:ImpactThing</a>
    /// </summary>
    let ImpactThing = _prefixId.prefix "ImpactThing"
    /// <summary>
    ///   <para>rdfs:label : KeyCapability</para>
    ///   <para>rdfs:comment : Class of all Key Capabilities, aggregation of Impacts.</para>
    ///   <a href="https://w3id.org/sri#KeyCapability">sri:KeyCapability</a>
    /// </summary>
    let KeyCapability = _prefixId.prefix "KeyCapability"
    /// <summary>
    ///   <para>rdfs:label : Level</para>
    ///   <para>rdfs:comment : Class of service levels.</para>
    ///   <a href="https://w3id.org/sri#Level">sri:Level</a>
    /// </summary>
    let Level = _prefixId.prefix "Level"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : Class for Services.</para>
    ///   <a href="https://w3id.org/sri#Service">sri:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Service catalogue</para>
    ///   <para>rdfs:comment : A Service Catalogue is a collection of services used in an assessment.</para>
    ///   <a href="https://w3id.org/sri#ServiceCatalogue">sri:ServiceCatalogue</a>
    /// </summary>
    let ServiceCatalogue = _prefixId.prefix "ServiceCatalogue"
    /// <summary>
    ///   <para>rdfs:label : Service level</para>
    ///   <para>rdfs:comment : Class for all ServiceLevel instances, which are all allowed/defined combinations of Services and Levels.</para>
    ///   <a href="https://w3id.org/sri#ServiceLevel">sri:ServiceLevel</a>
    /// </summary>
    let ServiceLevel = _prefixId.prefix "ServiceLevel"

    let adaptTheirOperationToTheNeedsOfTheOccupant =
        _prefixId.prefix "adaptTheirOperationToTheNeedsOfTheOccupant"

    let adaptToSignalsFromTheGrid = _prefixId.prefix "adaptToSignalsFromTheGrid"
    /// <summary>
    ///   <para>rdfs:label : additional level</para>
    ///   <para>rdfs:comment : Additional Level if share is &lt; 100%.</para>
    ///   <a href="https://w3id.org/sri#additionalLevel">sri:additionalLevel</a>
    /// </summary>
    let additionalLevel = _prefixId.prefix "additionalLevel"
    /// <summary>
    ///   <para>rdfs:label : assessment</para>
    ///   <para>rdfs:comment : Relates something to an assessment dataset.</para>
    ///   <a href="https://w3id.org/sri#assessment">sri:assessment</a>
    /// </summary>
    let assessment = _prefixId.prefix "assessment"
    /// <summary>
    ///   <para>rdfs:label : building</para>
    ///   <para>rdfs:comment : Relates something to a Building.</para>
    ///   <a href="https://w3id.org/sri#building">sri:building</a>
    /// </summary>
    let building = _prefixId.prefix "building"
    let comfort = _prefixId.prefix "comfort"
    let convenience = _prefixId.prefix "convenience"
    let cooling = _prefixId.prefix "cooling"
    let dE = _prefixId.prefix "dE"
    let dHW = _prefixId.prefix "dHW"
    let dsd_assessment = _prefixId.prefix "dsd-assessment"
    let dsd_scores = _prefixId.prefix "dsd-scores"
    let dsd_sriscores = _prefixId.prefix "dsd-sriscores"
    let dsd_weights = _prefixId.prefix "dsd-weights"
    let eV = _prefixId.prefix "eV"
    let electricity = _prefixId.prefix "electricity"
    let energy_efficiency = _prefixId.prefix "energy_efficiency"

    let energy_flexibility_and_storage =
        _prefixId.prefix "energy_flexibility_and_storage"

    /// <summary>
    ///   <para>rdfs:label : function</para>
    ///   <para>rdfs:comment : Relates something to a FunctionalThing.</para>
    ///   <a href="https://w3id.org/sri#function">sri:function</a>
    /// </summary>
    let function_ = _prefixId.prefix "function"

    let health_well_being_and_accessibility =
        _prefixId.prefix "health_well_being_and_accessibility"

    let heating = _prefixId.prefix "heating"
    /// <summary>
    ///   <para>rdfs:label : impact criterion score</para>
    ///   <para>rdfs:comment : The impact criterion score is defined for Services and calculated for Domains in Step 3.</para>
    ///   <a href="https://w3id.org/sri#icscore">sri:icscore</a>
    /// </summary>
    let icscore = _prefixId.prefix "icscore"
    /// <summary>
    ///   <para>rdfs:label : impact</para>
    ///   <para>rdfs:comment : Relates something to an ImpactThing.</para>
    ///   <a href="https://w3id.org/sri#impact">sri:impact</a>
    /// </summary>
    let impact = _prefixId.prefix "impact"
    let information_to_occupants = _prefixId.prefix "information_to_occupants"
    /// <summary>
    ///   <para>rdfs:label : level</para>
    ///   <para>rdfs:comment : Relates something to a Level.</para>
    ///   <a href="https://w3id.org/sri#level">sri:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    let level0 = _prefixId.prefix "level0"
    let level1 = _prefixId.prefix "level1"
    let level2 = _prefixId.prefix "level2"
    let level3 = _prefixId.prefix "level3"
    let level4 = _prefixId.prefix "level4"
    let lighting = _prefixId.prefix "lighting"
    let mC = _prefixId.prefix "mC"

    let maintenance_and_fault_prediction =
        _prefixId.prefix "maintenance_and_fault_prediction"

    /// <summary>
    ///   <para>rdfs:label : maximum impact criterion score</para>
    ///   <para>rdfs:comment : Maximum impact criterion score. This is defined for Domains and calculated in Step 4.</para>
    ///   <a href="https://w3id.org/sri#max">sri:max</a>
    /// </summary>
    let max = _prefixId.prefix "max"

    let optimiseEnergyEfficiencyAndOverallIn_UsePerformance =
        _prefixId.prefix "optimiseEnergyEfficiencyAndOverallIn-UsePerformance"

    /// <summary>
    ///   <para>rdfs:label : smart-readiness score</para>
    ///   <para>rdfs:comment : The smart-readiness score is defined for ImpactThings on all levels from Impacts to the complete Building (Steps 5, 6, and 7) and optionally for Domains (Step 8)</para>
    ///   <a href="https://w3id.org/sri#score">sri:score</a>
    /// </summary>
    let score = _prefixId.prefix "score"
    /// <summary>
    ///   <para>rdfs:label : service catalogue</para>
    ///   <para>rdfs:comment : Relates something to a ServiceCatalogue.</para>
    ///   <a href="https://w3id.org/sri#serviceCatalogue">sri:serviceCatalogue</a>
    /// </summary>
    let serviceCatalogue = _prefixId.prefix "serviceCatalogue"
    /// <summary>
    ///   <para>rdfs:label : share</para>
    ///   <para>rdfs:comment : A percentage (value between 0.0 and 1.0) which expresses that parts of a building are assessed with different levels wrt. a Service. If share is &lt; 100% then additionalLevel has to be defined.</para>
    ///   <a href="https://w3id.org/sri#share">sri:share</a>
    /// </summary>
    let share = _prefixId.prefix "share"
    let topDomain = _prefixId.prefix "topDomain"
    let topImpact = _prefixId.prefix "topImpact"
    let ventilation = _prefixId.prefix "ventilation"
    /// <summary>
    ///   <para>rdfs:label : weight</para>
    ///   <para>rdfs:comment : A weight of the weight matrix used for weighing the smart-readiness scores before aggregation.</para>
    ///   <a href="https://w3id.org/sri#weight">sri:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"
