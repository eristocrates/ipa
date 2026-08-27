namespace https.w3id.org.peco.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module peco =
    let _namespace_iri = Namespace_Iri peco |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:peco#EmissionCalculationActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity representing a whole or a part of the carbon emission calculation process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Emission Calculation Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/peco#EmissionCalculationActivity">https://w3id.org/peco#EmissionCalculationActivity</seealso>
    let EmissionCalculationActivity =
        Prefixed_Name(peco, "EmissionCalculationActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:peco#EmissionCalculationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A prov:Entitiy representing quantifieble input and output data described as qudt:Quantity that influenced emission calculation process. If this data is produced as a result of some sensor observation it would be also of type sosa:Result."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Emission Calculation Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/peco#EmissionCalculationEntity">https://w3id.org/peco#EmissionCalculationEntity</seealso>
    let EmissionCalculationEntity =
        Prefixed_Name(peco, "EmissionCalculationEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:peco#EmissionGenerationActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity that produces emissions. For example, training of ML models, driving a car, farming operation, etc. This activity can be represented at differentl levels of abstraction, for example, as a single overarching activity (e.g., factory producion for year 2022) or as a number of smaller activities (e.g., production of a single batch of products)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Emission Generation Activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/peco#EmissionGenerationActivity">https://w3id.org/peco#EmissionGenerationActivity</seealso>
    let EmissionGenerationActivity =
        Prefixed_Name(peco, "EmissionGenerationActivity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:peco#EmissionScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The result of the peco:EmissionCalculationActivity representing the carbon emissions produced by the linked peco:EmissionGenerationActivity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Emission Score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/peco#EmissionScore">https://w3id.org/peco#EmissionScore</seealso>
    let EmissionScore = Prefixed_Name(peco, "EmissionScore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:peco#hasEmissionScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking peco:EmissionGenerationActivity with a quantifiable representation of the amount of emissions prodcued by this activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has emission score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/peco#hasEmissionScore">https://w3id.org/peco#hasEmissionScore</seealso>
    let hasEmissionScore = Prefixed_Name(peco, "hasEmissionScore") |> PrefixedName

    /// <summary>
    ///   <para>w3id:peco#inEmissionActivityContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking peco:EmissionGenerationActivity to sosa:Observation. For example, a machine learning training activity (peco:EmissionGenerationActivity) is linked to electricity monitoring activity (sosa:Observation) that monitors electricity consumption of a GPU (sosa:FeatureOfInterest) used to train the ML model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"in emission activity context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/peco#inEmissionActivityContext">https://w3id.org/peco#inEmissionActivityContext</seealso>
    let inEmissionActivityContext =
        Prefixed_Name(peco, "inEmissionActivityContext") |> PrefixedName
