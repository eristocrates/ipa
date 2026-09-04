#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ecfo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/ecfo#" "ecfo"
    /// <summary>
    ///   <para>rdfs:label : Chemical compound</para>
    ///   <para>rdfs:comment : Pure chemical substance consisting of two or more different chemical elements (source: https://www.wikidata.org/wiki/Q11173)</para>
    ///   <a href="https://w3id.org/ecfo#ChemicalCompound">ecfo:ChemicalCompound</a>
    /// </summary>
    let ChemicalCompound = _prefixId.prefix "ChemicalCompound"
    /// <summary>
    ///   <para>rdfs:label : Emission Conversion Factor^^xsd:string</para>
    ///   <para>rdfs:comment : A concept representing the coefficient value used in greenhouse gas (GHG) emission calculations (activity data x emission conversion factor = GHG emissions)  and additional metadata (e.g., applicable location, publisher, etc.).^^xsd:string</para>
    ///   <a href="https://w3id.org/ecfo#EmissionConversionFactor">ecfo:EmissionConversionFactor</a>
    /// </summary>
    let EmissionConversionFactor = _prefixId.prefix "EmissionConversionFactor"
    /// <summary>
    ///   <para>rdfs:label : Scope^^xsd:string</para>
    ///   <para>rdfs:comment : Type of emissions a company creates in its own operations and in its wider 'value chain'. Typically emissions fall under three categories - Scope 1, Scope 2 and Scope 3.^^xsd:string</para>
    ///   <a href="https://w3id.org/ecfo#Scope">ecfo:Scope</a>
    /// </summary>
    let Scope = _prefixId.prefix "Scope"
    let Scope1 = _prefixId.prefix "Scope1"
    let Scope2 = _prefixId.prefix "Scope2"
    let Scope3 = _prefixId.prefix "Scope3"
    /// <summary>
    ///   <para>rdfs:label : Tag^^xsd:string</para>
    ///   <para>rdfs:comment : A generic class to describe a category/tag that ecfo:EmissionFactor. Use ecfo:hasTag to link the category/tag and rdf:value to provide the name of the category. A single ecfo:EmissionFactor may refer to multiple tags. To identify individual conversion factors a union of tags should be considered.^^xsd:string</para>
    ///   <a href="https://w3id.org/ecfo#Tag">ecfo:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:label : has additional context</para>
    ///   <para>rdfs:comment : Conversion factors often have subtelties that contextualize the emission source. For example the emission source may be a transportation method (car), but additional context may indicate that the CF is for "large cars", or lars with more than 120 horse power.
    /// These subteltlies are captured in the "hasAdditionalContext" property</para>
    ///   <a href="https://w3id.org/ecfo#hasAdditionalContext">ecfo:hasAdditionalContext</a>
    /// </summary>
    let hasAdditionalContext = _prefixId.prefix "hasAdditionalContext"
    /// <summary>
    ///   <para>rdfs:label : has applicable location</para>
    ///   <para>rdfs:comment : A geographic area (e.g., a country) or a physical location (e.g., a farm) to which a specific ecfo:ConversionFactor may be applied.</para>
    ///   <a href="https://w3id.org/ecfo#hasApplicableLocation">ecfo:hasApplicableLocation</a>
    /// </summary>
    let hasApplicableLocation = _prefixId.prefix "hasApplicableLocation"
    /// <summary>
    ///   <para>rdfs:label : has applicable period</para>
    ///   <para>rdfs:comment : A time period for which the emission conversion factor is considered to be most relevant.</para>
    ///   <a href="https://w3id.org/ecfo#hasApplicablePeriod">ecfo:hasApplicablePeriod</a>
    /// </summary>
    let hasApplicablePeriod = _prefixId.prefix "hasApplicablePeriod"
    /// <summary>
    ///   <para>rdfs:label : has emission source</para>
    ///   <para>rdfs:comment : Source of the emission in a conversion factor (e.g., butane, refrigerator, herd of animals, etc.).</para>
    ///   <a href="https://w3id.org/ecfo#hasEmissionSource">ecfo:hasEmissionSource</a>
    /// </summary>
    let hasEmissionSource = _prefixId.prefix "hasEmissionSource"
    /// <summary>
    ///   <para>rdfs:label : has emission target</para>
    ///   <para>rdfs:comment : Target chemical compound of a conversion factor (e.g., CO2e). The target compund is associated with the target unit</para>
    ///   <a href="https://w3id.org/ecfo#hasEmissionTarget">ecfo:hasEmissionTarget</a>
    /// </summary>
    let hasEmissionTarget = _prefixId.prefix "hasEmissionTarget"
    /// <summary>
    ///   <para>rdfs:label : has scope</para>
    ///   <para>rdfs:comment : A property linking conversion factor to the description of the emission scope.</para>
    ///   <a href="https://w3id.org/ecfo#hasScope">ecfo:hasScope</a>
    /// </summary>
    let hasScope = _prefixId.prefix "hasScope"
    /// <summary>
    ///   <para>rdfs:label : has source unit</para>
    ///   <para>rdfs:comment : The unit corresponding to the source data that is multiplied by the ecfo:ConversionFactor</para>
    ///   <a href="https://w3id.org/ecfo#hasSourceUnit">ecfo:hasSourceUnit</a>
    /// </summary>
    let hasSourceUnit = _prefixId.prefix "hasSourceUnit"
    /// <summary>
    ///   <para>rdfs:label : has tag</para>
    ///   <para>rdfs:comment : A property to assign a specific category/tag to ecfo:ConversionFactor.</para>
    ///   <a href="https://w3id.org/ecfo#hasTag">ecfo:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>rdfs:label : has target unit</para>
    ///   <para>rdfs:comment : The unit corresponding to the result of multiplying input data by the ecfo:ConversionFactor</para>
    ///   <a href="https://w3id.org/ecfo#hasTargetUnit">ecfo:hasTargetUnit</a>
    /// </summary>
    let hasTargetUnit = _prefixId.prefix "hasTargetUnit"
    /// <summary>
    ///   <para>rdfs:label : has usage notes</para>
    ///   <para>rdfs:comment : Property used to describe any limitations, disclaimers or usage notes associated with a CF. For example "This CF is an estimation based on local data and should be superseeded by governmental sources"</para>
    ///   <a href="https://w3id.org/ecfo#hasUsageNotes">ecfo:hasUsageNotes</a>
    /// </summary>
    let hasUsageNotes = _prefixId.prefix "hasUsageNotes"
