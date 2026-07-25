namespace https.w3id.org.ecfo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ecfo =
    let _namespace_iri = Namespace_Iri ecfo |> NamespaceIRI
    /// <summary>
    ///   <para>ecfo:ChemicalCompound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Pure chemical substance consisting of two or more different chemical elements (source: https://www.wikidata.org/wiki/Q11173)</para>
    /// labels<para>Chemical compound</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#ChemicalCompound">https://w3id.org/ecfo#ChemicalCompound</seealso>
    let ChemicalCompound = Prefixed_Name(ecfo, "ChemicalCompound") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:Scope2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ecfo#Scope</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Scope 2 (energy indirect) emissions are those released into the atmosphere that are associated with your consumption of purchased electricity, heat, steam and cooling. These indirect emissions are a consequence of your organisation’s energy use, but occur at sources you do not own or control.</para>
    /// labels<para>scope 2</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#Scope2">https://w3id.org/ecfo#Scope2</seealso>
    let Scope2 = Prefixed_Name(ecfo, "Scope2") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic class to describe a category/tag that ecfo:EmissionFactor. Use ecfo:hasTag to link the category/tag and rdf:value to provide the name of the category. A single ecfo:EmissionFactor may refer to multiple tags. To identify individual conversion factors a union of tags should be considered.</para>
    /// labels<para>Tag</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#Tag">https://w3id.org/ecfo#Tag</seealso>
    let Tag = Prefixed_Name(ecfo, "Tag") |> PrefixedName

    /// <summary>
    ///   <para>ecfo:EmissionConversionFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concept representing the coefficient value used in greenhouse gas (GHG) emission calculations (activity data x emission conversion factor = GHG emissions)  and additional metadata (e.g., applicable location, publisher, etc.).</para>
    /// labels<para>Emission Conversion Factor</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#EmissionConversionFactor">https://w3id.org/ecfo#EmissionConversionFactor</seealso>
    let EmissionConversionFactor =
        Prefixed_Name(ecfo, "EmissionConversionFactor") |> PrefixedName

    /// <summary>
    ///   <para>ecfo:Scope3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:ecfo#Scope</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Scope 3 (other indirect) emissions are a consequence of your actions that occur at sources you do not own or control and are not classed as Scope 2 emissions. Examples of Scope 3 emissions are business travel by means not owned or controlled by your organisation, waste disposal, materials or fuels your organisation purchases. Deciding if emissions from a vehicle, office or factory that you use are Scope 1 or Scope 3 may depend on how you define your operational boundaries. Scope 3 emissions can be from activities that are upstream or downstream of your organisation. More information on Scope 3 and other aspects of reporting can be found in the Greenhouse Gas Protocol Corporate Standard.</para>
    /// labels<para>scope 3</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#Scope3">https://w3id.org/ecfo#Scope3</seealso>
    let Scope3 = Prefixed_Name(ecfo, "Scope3") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:Scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of emissions a company creates in its own operations and in its wider 'value chain'. Typically emissions fall under three categories - Scope 1, Scope 2 and Scope 3.</para>
    /// labels<para>Scope</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#Scope">https://w3id.org/ecfo#Scope</seealso>
    let Scope = Prefixed_Name(ecfo, "Scope") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:Scope1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:ecfo#Scope</para>
    ///   <para>Scope 1 (direct emissions) emissions are those from activities owned or controlled by your organisation. Examples of Scope 1 emissions include emissions from combustion in owned or controlled boilers, furnaces and vehicles; and emissions from chemical production in owned or controlled process equipment.</para>
    /// labels<para>scope 1</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#Scope1">https://w3id.org/ecfo#Scope1</seealso>
    let Scope1 = Prefixed_Name(ecfo, "Scope1") |> PrefixedName

    /// <summary>
    ///   <para>ecfo:hasAdditionalContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Conversion factors often have subtelties that contextualize the emission source. For example the emission source may be a transportation method (car), but additional context may indicate that the CF is for "large cars", or lars with more than 120 horse power.
    /// These subteltlies are captured in the "hasAdditionalContext" property</para>
    /// labels<para>has additional context</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasAdditionalContext">https://w3id.org/ecfo#hasAdditionalContext</seealso>
    let hasAdditionalContext =
        Prefixed_Name(ecfo, "hasAdditionalContext") |> PrefixedName

    /// <summary>
    ///   <para>ecfo:hasApplicablePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A time period for which the emission conversion factor is considered to be most relevant.</para>
    /// labels<para>has applicable period</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasApplicablePeriod">https://w3id.org/ecfo#hasApplicablePeriod</seealso>
    let hasApplicablePeriod = Prefixed_Name(ecfo, "hasApplicablePeriod") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:hasEmissionTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Target chemical compound of a conversion factor (e.g., CO2e). The target compund is associated with the target unit</para>
    /// labels<para>has emission target</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasEmissionTarget">https://w3id.org/ecfo#hasEmissionTarget</seealso>
    let hasEmissionTarget = Prefixed_Name(ecfo, "hasEmissionTarget") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:hasScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property linking conversion factor to the description of the emission scope.</para>
    /// labels<para>has scope</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasScope">https://w3id.org/ecfo#hasScope</seealso>
    let hasScope = Prefixed_Name(ecfo, "hasScope") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:hasTargetUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The unit corresponding to the result of multiplying input data by the ecfo:ConversionFactor</para>
    /// labels<para>has target unit</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasTargetUnit">https://w3id.org/ecfo#hasTargetUnit</seealso>
    let hasTargetUnit = Prefixed_Name(ecfo, "hasTargetUnit") |> PrefixedName

    /// <summary>
    ///   <para>ecfo:hasApplicableLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A geographic area (e.g., a country) or a physical location (e.g., a farm) to which a specific ecfo:ConversionFactor may be applied.</para>
    /// labels<para>has applicable location</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasApplicableLocation">https://w3id.org/ecfo#hasApplicableLocation</seealso>
    let hasApplicableLocation =
        Prefixed_Name(ecfo, "hasApplicableLocation") |> PrefixedName

    /// <summary>
    ///   <para>ecfo:hasEmissionSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Source of the emission in a conversion factor (e.g., butane, refrigerator, herd of animals, etc.).</para>
    /// labels<para>has emission source</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasEmissionSource">https://w3id.org/ecfo#hasEmissionSource</seealso>
    let hasEmissionSource = Prefixed_Name(ecfo, "hasEmissionSource") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:hasSourceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The unit corresponding to the source data that is multiplied by the ecfo:ConversionFactor</para>
    /// labels<para>has source unit</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasSourceUnit">https://w3id.org/ecfo#hasSourceUnit</seealso>
    let hasSourceUnit = Prefixed_Name(ecfo, "hasSourceUnit") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to assign a specific category/tag to ecfo:ConversionFactor.</para>
    /// labels<para>has tag</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasTag">https://w3id.org/ecfo#hasTag</seealso>
    let hasTag = Prefixed_Name(ecfo, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>ecfo:hasUsageNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to describe any limitations, disclaimers or usage notes associated with a CF. For example "This CF is an estimation based on local data and should be superseeded by governmental sources"</para>
    /// labels<para>has usage notes</para></remarks>
    /// <seealso href="https://w3id.org/ecfo#hasUsageNotes">https://w3id.org/ecfo#hasUsageNotes</seealso>
    let hasUsageNotes = Prefixed_Name(ecfo, "hasUsageNotes") |> PrefixedName
