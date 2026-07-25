namespace https.w3id.org.env.puv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module envpuv =
    let _namespace_iri = Namespace_Iri envpuv |> NamespaceIRI
    /// <summary>
    ///   <para>envpuv:isComposedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>link to component concepts</para>
    /// labels<para>is composed of</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#isComposedOf">https://w3id.org/env/puv#isComposedOf</seealso>
    let isComposedOf = Prefixed_Name(envpuv, "isComposedOf") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:BiologicalEntityShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Biological entity shape (S14)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityShape">https://w3id.org/env/puv#BiologicalEntityShape</seealso>
    let BiologicalEntityShape =
        Prefixed_Name(envpuv, "BiologicalEntityShape") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:BiologicalEntitySubComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Biological entity sub-component (S12)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntitySubComponent">https://w3id.org/env/puv#BiologicalEntitySubComponent</seealso>
    let BiologicalEntitySubComponent =
        Prefixed_Name(envpuv, "BiologicalEntitySubComponent") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:ChemicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Chemical substance (S27)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#ChemicalEntity">https://w3id.org/env/puv#ChemicalEntity</seealso>
    let ChemicalEntity = Prefixed_Name(envpuv, "ChemicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:DataProcessingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Data processing method (S05)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#DataProcessingMethod">https://w3id.org/env/puv#DataProcessingMethod</seealso>
    let DataProcessingMethod =
        Prefixed_Name(envpuv, "DataProcessingMethod") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:uom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>scale or unit of measurement</para>
    /// labels<para>unit-of-measurement </para></remarks>
    /// <seealso href="https://w3id.org/env/puv#uom">https://w3id.org/env/puv#uom</seealso>
    let uom = Prefixed_Name(envpuv, "uom") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:AnalyticalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Analytical method (S04)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#AnalyticalMethod">https://w3id.org/env/puv#AnalyticalMethod</seealso>
    let AnalyticalMethod = Prefixed_Name(envpuv, "AnalyticalMethod") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Method used</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Method">https://w3id.org/env/puv#Method</seealso>
    let Method = Prefixed_Name(envpuv, "Method") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:BiologicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)</para>
    /// labels<para>Biological entity (S25)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntity">https://w3id.org/env/puv#BiologicalEntity</seealso>
    let BiologicalEntity = Prefixed_Name(envpuv, "BiologicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:BiologicalEntityColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Biological entity colour (S15)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityColour">https://w3id.org/env/puv#BiologicalEntityColour</seealso>
    let BiologicalEntityColour =
        Prefixed_Name(envpuv, "BiologicalEntityColour") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Entity that bears the parameter</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Entity">https://w3id.org/env/puv#Entity</seealso>
    let Entity = Prefixed_Name(envpuv, "Entity") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:BiologicalEntityComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)</para>
    /// labels<para>Biological entity component</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityComponent">https://w3id.org/env/puv#BiologicalEntityComponent</seealso>
    let BiologicalEntityComponent =
        Prefixed_Name(envpuv, "BiologicalEntityComponent") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:BiologicalEntityGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Biological entity gender (S10)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityGender">https://w3id.org/env/puv#BiologicalEntityGender</seealso>
    let BiologicalEntityGender =
        Prefixed_Name(envpuv, "BiologicalEntityGender") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:BiologicalEntitySize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Biological entity size (S09)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntitySize">https://w3id.org/env/puv#BiologicalEntitySize</seealso>
    let BiologicalEntitySize =
        Prefixed_Name(envpuv, "BiologicalEntitySize") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:MMRel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Measurement-matrix relationship (S02)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MMRel">https://w3id.org/env/puv#MMRel</seealso>
    let MMRel = Prefixed_Name(envpuv, "MMRel") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:MatrixPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sphere phase (S23)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixPhase">https://w3id.org/env/puv#MatrixPhase</seealso>
    let MatrixPhase = Prefixed_Name(envpuv, "MatrixPhase") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:MatrixSphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Matrix sphere (S21)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixSphere">https://w3id.org/env/puv#MatrixSphere</seealso>
    let MatrixSphere = Prefixed_Name(envpuv, "MatrixSphere") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:ParameterDiscovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>SeaDataNet Parameter Discovery (P02)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#ParameterDiscovery">https://w3id.org/env/puv#ParameterDiscovery</seealso>
    let ParameterDiscovery = Prefixed_Name(envpuv, "ParameterDiscovery") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:ParameterStatistic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Parameter statistic (S07)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#ParameterStatistic">https://w3id.org/env/puv#ParameterStatistic</seealso>
    let ParameterStatistic = Prefixed_Name(envpuv, "ParameterStatistic") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:PhysicalEntityComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Also see S18 (name), S19 (sub-group), S20 (datum)</para>
    /// labels<para>Physical entity component</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntityComponent">https://w3id.org/env/puv#PhysicalEntityComponent</seealso>
    let PhysicalEntityComponent =
        Prefixed_Name(envpuv, "PhysicalEntityComponent") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:PhysicalEntityDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Physical entity datum (S20)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntityDatum">https://w3id.org/env/puv#PhysicalEntityDatum</seealso>
    let PhysicalEntityDatum =
        Prefixed_Name(envpuv, "PhysicalEntityDatum") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:PhysicalEntitySubGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Physical entity sub-group (S19)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntitySubGroup">https://w3id.org/env/puv#PhysicalEntitySubGroup</seealso>
    let PhysicalEntitySubGroup =
        Prefixed_Name(envpuv, "PhysicalEntitySubGroup") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Property (S06) </para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Property">https://w3id.org/env/puv#Property</seealso>
    let Property = Prefixed_Name(envpuv, "Property") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:analyticalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>analytical method</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#analyticalMethod">https://w3id.org/env/puv#analyticalMethod</seealso>
    let analyticalMethod = Prefixed_Name(envpuv, "analyticalMethod") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:BiologicalEntityStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Biological entity stage (S11)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityStage">https://w3id.org/env/puv#BiologicalEntityStage</seealso>
    let BiologicalEntityStage =
        Prefixed_Name(envpuv, "BiologicalEntityStage") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:BiologicalEntitySubGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Biological entity sub-group (S13)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntitySubGroup">https://w3id.org/env/puv#BiologicalEntitySubGroup</seealso>
    let BiologicalEntitySubGroup =
        Prefixed_Name(envpuv, "BiologicalEntitySubGroup") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:Matrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)</para>
    /// labels<para>Matrix (S26)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Matrix">https://w3id.org/env/puv#Matrix</seealso>
    let Matrix = Prefixed_Name(envpuv, "Matrix") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:MatrixComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)</para>
    /// labels<para>Matrix component</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixComponent">https://w3id.org/env/puv#MatrixComponent</seealso>
    let MatrixComponent = Prefixed_Name(envpuv, "MatrixComponent") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:MatrixPhaseSubGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sphere phase sub-group (S24)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixPhaseSubGroup">https://w3id.org/env/puv#MatrixPhaseSubGroup</seealso>
    let MatrixPhaseSubGroup =
        Prefixed_Name(envpuv, "MatrixPhaseSubGroup") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:MatrixSphereSubGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Matrix sphere sub-group (S22)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixSphereSubGroup">https://w3id.org/env/puv#MatrixSphereSubGroup</seealso>
    let MatrixSphereSubGroup =
        Prefixed_Name(envpuv, "MatrixSphereSubGroup") |> PrefixedName

    /// <summary>
    ///   <para>envpuv:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scientific variable in databases and data files</para>
    /// labels<para>Parameter (P01)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Parameter">https://w3id.org/env/puv#Parameter</seealso>
    let Parameter = Prefixed_Name(envpuv, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:PhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Also see S18 (name), S19 (sub-group), S20 (datum)</para>
    /// labels<para>Physical entity (S29)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntity">https://w3id.org/env/puv#PhysicalEntity</seealso>
    let PhysicalEntity = Prefixed_Name(envpuv, "PhysicalEntity") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:PhysicalEntityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Physical entity name (S18)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntityName">https://w3id.org/env/puv#PhysicalEntityName</seealso>
    let PhysicalEntityName = Prefixed_Name(envpuv, "PhysicalEntityName") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:PrepMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sample preparation method (S03)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PrepMethod">https://w3id.org/env/puv#PrepMethod</seealso>
    let PrepMethod = Prefixed_Name(envpuv, "PrepMethod") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:biologicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>biological object of interest</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#biologicalObject">https://w3id.org/env/puv#biologicalObject</seealso>
    let biologicalObject = Prefixed_Name(envpuv, "biologicalObject") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:matrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>environmental matrix that the measurement is in relation to </para>
    /// labels<para>matrix </para></remarks>
    /// <seealso href="https://w3id.org/env/puv#matrix">https://w3id.org/env/puv#matrix</seealso>
    let matrix = Prefixed_Name(envpuv, "matrix") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:matrixRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>measurement-matrix relationship</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#matrixRelationship">https://w3id.org/env/puv#matrixRelationship</seealso>
    let matrixRelationship = Prefixed_Name(envpuv, "matrixRelationship") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:UnitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unit of Measurement (P06)</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#UnitOfMeasurement">https://w3id.org/env/puv#UnitOfMeasurement</seealso>
    let UnitOfMeasurement = Prefixed_Name(envpuv, "UnitOfMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>method used to measure the value</para>
    /// labels<para>method</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#method">https://w3id.org/env/puv#method</seealso>
    let method = Prefixed_Name(envpuv, "method") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:chemicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>chemical object of interest</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#chemicalObject">https://w3id.org/env/puv#chemicalObject</seealso>
    let chemicalObject = Prefixed_Name(envpuv, "chemicalObject") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:objectOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>object of interest can be a chemical object, a biological object, a physical phenomenon, or a material object</para>
    /// labels<para>object of interest </para></remarks>
    /// <seealso href="https://w3id.org/env/puv#objectOfInterest">https://w3id.org/env/puv#objectOfInterest</seealso>
    let objectOfInterest = Prefixed_Name(envpuv, "objectOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:dataProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>data processing method</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#dataProcessing">https://w3id.org/env/puv#dataProcessing</seealso>
    let dataProcessing = Prefixed_Name(envpuv, "dataProcessing") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:physicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>physical object of interest</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#physicalObject">https://w3id.org/env/puv#physicalObject</seealso>
    let physicalObject = Prefixed_Name(envpuv, "physicalObject") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:statistic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>statistical treatment</para>
    /// labels<para>statistic </para></remarks>
    /// <seealso href="https://w3id.org/env/puv#statistic">https://w3id.org/env/puv#statistic</seealso>
    let statistic = Prefixed_Name(envpuv, "statistic") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>property or attribute that is being measured, which must be associated with either an object of interest or a matrix or both</para>
    /// labels<para>property</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#property">https://w3id.org/env/puv#property</seealso>
    let property = Prefixed_Name(envpuv, "property") |> PrefixedName
    /// <summary>
    ///   <para>envpuv:samplePreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sample-preparation method</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#samplePreparation">https://w3id.org/env/puv#samplePreparation</seealso>
    let samplePreparation = Prefixed_Name(envpuv, "samplePreparation") |> PrefixedName
