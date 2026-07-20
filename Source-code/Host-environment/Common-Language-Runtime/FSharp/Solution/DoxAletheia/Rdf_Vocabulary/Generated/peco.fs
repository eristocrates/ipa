namespace https.w3id.org.peco.hash

open DoxAletheia

module peco =
    let _namespace_name = "https://w3id.org/peco#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An activity representing a whole or a part of the carbon emission calculation process.
    /// <see href="https://w3id.org/peco#EmissionCalculationActivity"></see></summary>
    let EmissionCalculationActivity = _prefix "EmissionCalculationActivity"
    /// <summary>
    /// A prov:Entitiy representing quantifieble input and output data described as qudt:Quantity that influenced emission calculation process. If this data is produced as a result of some sensor observation it would be also of type sosa:Result.
    /// <see href="https://w3id.org/peco#EmissionCalculationEntity"></see></summary>
    let EmissionCalculationEntity = _prefix "EmissionCalculationEntity"
    /// <summary>
    /// An activity that produces emissions. For example, training of ML models, driving a car, farming operation, etc. This activity can be represented at differentl levels of abstraction, for example, as a single overarching activity (e.g., factory producion for year 2022) or as a number of smaller activities (e.g., production of a single batch of products).
    /// <see href="https://w3id.org/peco#EmissionGenerationActivity"></see></summary>
    let EmissionGenerationActivity = _prefix "EmissionGenerationActivity"
    /// <summary>
    /// The result of the peco:EmissionCalculationActivity representing the carbon emissions produced by the linked peco:EmissionGenerationActivity.
    /// <see href="https://w3id.org/peco#EmissionScore"></see></summary>
    let EmissionScore = _prefix "EmissionScore"
    /// <summary>
    /// A property linking peco:EmissionGenerationActivity with a quantifiable representation of the amount of emissions prodcued by this activity.
    /// <see href="https://w3id.org/peco#hasEmissionScore"></see></summary>
    let hasEmissionScore = _prefix "hasEmissionScore"
    /// <summary>
    /// A property linking peco:EmissionGenerationActivity to sosa:Observation. For example, a machine learning training activity (peco:EmissionGenerationActivity) is linked to electricity monitoring activity (sosa:Observation) that monitors electricity consumption of a GPU (sosa:FeatureOfInterest) used to train the ML model.
    /// <see href="https://w3id.org/peco#inEmissionActivityContext"></see></summary>
    let inEmissionActivityContext = _prefix "inEmissionActivityContext"
