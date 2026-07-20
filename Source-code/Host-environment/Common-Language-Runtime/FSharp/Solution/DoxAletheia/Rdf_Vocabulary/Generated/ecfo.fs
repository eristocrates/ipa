namespace https.w3id.org.ecfo.hash

open DoxAletheia

module ecfo =
    let _namespace_name = "https://w3id.org/ecfo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Pure chemical substance consisting of two or more different chemical elements (source: https://www.wikidata.org/wiki/Q11173)
    /// <see href="https://w3id.org/ecfo#ChemicalCompound"></see></summary>
    let ChemicalCompound = _prefix "ChemicalCompound"
    /// <summary>
    /// A concept representing the coefficient value used in greenhouse gas (GHG) emission calculations (activity data x emission conversion factor = GHG emissions)  and additional metadata (e.g., applicable location, publisher, etc.).
    /// <see href="https://w3id.org/ecfo#EmissionConversionFactor"></see></summary>
    let EmissionConversionFactor = _prefix "EmissionConversionFactor"
    /// <summary>
    /// Type of emissions a company creates in its own operations and in its wider 'value chain'. Typically emissions fall under three categories - Scope 1, Scope 2 and Scope 3.
    /// <see href="https://w3id.org/ecfo#Scope"></see></summary>
    let Scope = _prefix "Scope"
    /// <summary>
    /// Scope 1 (direct emissions) emissions are those from activities owned or controlled by your organisation. Examples of Scope 1 emissions include emissions from combustion in owned or controlled boilers, furnaces and vehicles; and emissions from chemical production in owned or controlled process equipment.
    /// <see href="https://w3id.org/ecfo#Scope1"></see></summary>
    let Scope1 = _prefix "Scope1"
    /// <summary>
    /// Scope 2 (energy indirect) emissions are those released into the atmosphere that are associated with your consumption of purchased electricity, heat, steam and cooling. These indirect emissions are a consequence of your organisation’s energy use, but occur at sources you do not own or control.
    /// <see href="https://w3id.org/ecfo#Scope2"></see></summary>
    let Scope2 = _prefix "Scope2"
    /// <summary>
    /// Scope 3 (other indirect) emissions are a consequence of your actions that occur at sources you do not own or control and are not classed as Scope 2 emissions. Examples of Scope 3 emissions are business travel by means not owned or controlled by your organisation, waste disposal, materials or fuels your organisation purchases. Deciding if emissions from a vehicle, office or factory that you use are Scope 1 or Scope 3 may depend on how you define your operational boundaries. Scope 3 emissions can be from activities that are upstream or downstream of your organisation. More information on Scope 3 and other aspects of reporting can be found in the Greenhouse Gas Protocol Corporate Standard.
    /// <see href="https://w3id.org/ecfo#Scope3"></see></summary>
    let Scope3 = _prefix "Scope3"
    /// <summary>
    /// A generic class to describe a category/tag that ecfo:EmissionFactor. Use ecfo:hasTag to link the category/tag and rdf:value to provide the name of the category. A single ecfo:EmissionFactor may refer to multiple tags. To identify individual conversion factors a union of tags should be considered.
    /// <see href="https://w3id.org/ecfo#Tag"></see></summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// Conversion factors often have subtelties that contextualize the emission source. For example the emission source may be a transportation method (car), but additional context may indicate that the CF is for "large cars", or lars with more than 120 horse power.
    /// These subteltlies are captured in the "hasAdditionalContext" property
    /// <see href="https://w3id.org/ecfo#hasAdditionalContext"></see></summary>
    let hasAdditionalContext = _prefix "hasAdditionalContext"
    /// <summary>
    /// A geographic area (e.g., a country) or a physical location (e.g., a farm) to which a specific ecfo:ConversionFactor may be applied.
    /// <see href="https://w3id.org/ecfo#hasApplicableLocation"></see></summary>
    let hasApplicableLocation = _prefix "hasApplicableLocation"
    /// <summary>
    /// A time period for which the emission conversion factor is considered to be most relevant.
    /// <see href="https://w3id.org/ecfo#hasApplicablePeriod"></see></summary>
    let hasApplicablePeriod = _prefix "hasApplicablePeriod"
    /// <summary>
    /// Source of the emission in a conversion factor (e.g., butane, refrigerator, herd of animals, etc.).
    /// <see href="https://w3id.org/ecfo#hasEmissionSource"></see></summary>
    let hasEmissionSource = _prefix "hasEmissionSource"
    /// <summary>
    /// Target chemical compound of a conversion factor (e.g., CO2e). The target compund is associated with the target unit
    /// <see href="https://w3id.org/ecfo#hasEmissionTarget"></see></summary>
    let hasEmissionTarget = _prefix "hasEmissionTarget"
    /// <summary>
    /// A property linking conversion factor to the description of the emission scope.
    /// <see href="https://w3id.org/ecfo#hasScope"></see></summary>
    let hasScope = _prefix "hasScope"
    /// <summary>
    /// The unit corresponding to the source data that is multiplied by the ecfo:ConversionFactor
    /// <see href="https://w3id.org/ecfo#hasSourceUnit"></see></summary>
    let hasSourceUnit = _prefix "hasSourceUnit"
    /// <summary>
    /// A property to assign a specific category/tag to ecfo:ConversionFactor.
    /// <see href="https://w3id.org/ecfo#hasTag"></see></summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    /// The unit corresponding to the result of multiplying input data by the ecfo:ConversionFactor
    /// <see href="https://w3id.org/ecfo#hasTargetUnit"></see></summary>
    let hasTargetUnit = _prefix "hasTargetUnit"
    /// <summary>
    /// Property used to describe any limitations, disclaimers or usage notes associated with a CF. For example "This CF is an estimation based on local data and should be superseeded by governmental sources"
    /// <see href="https://w3id.org/ecfo#hasUsageNotes"></see></summary>
    let hasUsageNotes = _prefix "hasUsageNotes"
