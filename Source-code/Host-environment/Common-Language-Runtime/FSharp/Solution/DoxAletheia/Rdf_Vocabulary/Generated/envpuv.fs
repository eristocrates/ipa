namespace https.w3id.org.env.puv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module envpuv =
    let _namespace_iri = Namespace_Iri envpuv |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:env/puv#AnalyticalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Analytical method (S04)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#AnalyticalMethod">https://w3id.org/env/puv#AnalyticalMethod</seealso>
    let AnalyticalMethod = Prefixed_Name(envpuv, "AnalyticalMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biological entity (S25)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntity">https://w3id.org/env/puv#BiologicalEntity</seealso>
    let BiologicalEntity = Prefixed_Name(envpuv, "BiologicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntityColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological entity colour (S15)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityColour">https://w3id.org/env/puv#BiologicalEntityColour</seealso>
    let BiologicalEntityColour =
        Prefixed_Name(envpuv, "BiologicalEntityColour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntityComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biological entity component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityComponent">https://w3id.org/env/puv#BiologicalEntityComponent</seealso>
    let BiologicalEntityComponent =
        Prefixed_Name(envpuv, "BiologicalEntityComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntityGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological entity gender (S10)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityGender">https://w3id.org/env/puv#BiologicalEntityGender</seealso>
    let BiologicalEntityGender =
        Prefixed_Name(envpuv, "BiologicalEntityGender") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntityShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological entity shape (S14)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityShape">https://w3id.org/env/puv#BiologicalEntityShape</seealso>
    let BiologicalEntityShape =
        Prefixed_Name(envpuv, "BiologicalEntityShape") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntitySize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological entity size (S09)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntitySize">https://w3id.org/env/puv#BiologicalEntitySize</seealso>
    let BiologicalEntitySize =
        Prefixed_Name(envpuv, "BiologicalEntitySize") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntityStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological entity stage (S11)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntityStage">https://w3id.org/env/puv#BiologicalEntityStage</seealso>
    let BiologicalEntityStage =
        Prefixed_Name(envpuv, "BiologicalEntityStage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntitySubComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological entity sub-component (S12)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntitySubComponent">https://w3id.org/env/puv#BiologicalEntitySubComponent</seealso>
    let BiologicalEntitySubComponent =
        Prefixed_Name(envpuv, "BiologicalEntitySubComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#BiologicalEntitySubGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological entity sub-group (S13)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#BiologicalEntitySubGroup">https://w3id.org/env/puv#BiologicalEntitySubGroup</seealso>
    let BiologicalEntitySubGroup =
        Prefixed_Name(envpuv, "BiologicalEntitySubGroup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#ChemicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chemical substance (S27)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#ChemicalEntity">https://w3id.org/env/puv#ChemicalEntity</seealso>
    let ChemicalEntity = Prefixed_Name(envpuv, "ChemicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#DataProcessingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data processing method (S05)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#DataProcessingMethod">https://w3id.org/env/puv#DataProcessingMethod</seealso>
    let DataProcessingMethod =
        Prefixed_Name(envpuv, "DataProcessingMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Entity that bears the parameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Entity">https://w3id.org/env/puv#Entity</seealso>
    let Entity = Prefixed_Name(envpuv, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#MMRel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement-matrix relationship (S02)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MMRel">https://w3id.org/env/puv#MMRel</seealso>
    let MMRel = Prefixed_Name(envpuv, "MMRel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#Matrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Matrix (S26)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Matrix">https://w3id.org/env/puv#Matrix</seealso>
    let Matrix = Prefixed_Name(envpuv, "Matrix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#MatrixComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Matrix component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixComponent">https://w3id.org/env/puv#MatrixComponent</seealso>
    let MatrixComponent = Prefixed_Name(envpuv, "MatrixComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#MatrixPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sphere phase (S23)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixPhase">https://w3id.org/env/puv#MatrixPhase</seealso>
    let MatrixPhase = Prefixed_Name(envpuv, "MatrixPhase") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#MatrixPhaseSubGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sphere phase sub-group (S24)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixPhaseSubGroup">https://w3id.org/env/puv#MatrixPhaseSubGroup</seealso>
    let MatrixPhaseSubGroup =
        Prefixed_Name(envpuv, "MatrixPhaseSubGroup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#MatrixSphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Matrix sphere (S21)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixSphere">https://w3id.org/env/puv#MatrixSphere</seealso>
    let MatrixSphere = Prefixed_Name(envpuv, "MatrixSphere") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#MatrixSphereSubGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Matrix sphere sub-group (S22)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#MatrixSphereSubGroup">https://w3id.org/env/puv#MatrixSphereSubGroup</seealso>
    let MatrixSphereSubGroup =
        Prefixed_Name(envpuv, "MatrixSphereSubGroup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Method used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Method">https://w3id.org/env/puv#Method</seealso>
    let Method = Prefixed_Name(envpuv, "Method") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Scientific variable in databases and data files"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parameter (P01)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Parameter">https://w3id.org/env/puv#Parameter</seealso>
    let Parameter = Prefixed_Name(envpuv, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#ParameterDiscovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SeaDataNet Parameter Discovery (P02)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#ParameterDiscovery">https://w3id.org/env/puv#ParameterDiscovery</seealso>
    let ParameterDiscovery = Prefixed_Name(envpuv, "ParameterDiscovery") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#ParameterStatistic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Parameter statistic (S07)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#ParameterStatistic">https://w3id.org/env/puv#ParameterStatistic</seealso>
    let ParameterStatistic = Prefixed_Name(envpuv, "ParameterStatistic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#PhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also see S18 (name), S19 (sub-group), S20 (datum)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical entity (S29)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntity">https://w3id.org/env/puv#PhysicalEntity</seealso>
    let PhysicalEntity = Prefixed_Name(envpuv, "PhysicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#PhysicalEntityComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Also see S18 (name), S19 (sub-group), S20 (datum)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical entity component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntityComponent">https://w3id.org/env/puv#PhysicalEntityComponent</seealso>
    let PhysicalEntityComponent =
        Prefixed_Name(envpuv, "PhysicalEntityComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#PhysicalEntityDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Physical entity datum (S20)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntityDatum">https://w3id.org/env/puv#PhysicalEntityDatum</seealso>
    let PhysicalEntityDatum =
        Prefixed_Name(envpuv, "PhysicalEntityDatum") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#PhysicalEntityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Physical entity name (S18)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntityName">https://w3id.org/env/puv#PhysicalEntityName</seealso>
    let PhysicalEntityName = Prefixed_Name(envpuv, "PhysicalEntityName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#PhysicalEntitySubGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Physical entity sub-group (S19)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PhysicalEntitySubGroup">https://w3id.org/env/puv#PhysicalEntitySubGroup</seealso>
    let PhysicalEntitySubGroup =
        Prefixed_Name(envpuv, "PhysicalEntitySubGroup") |> PrefixedName

    /// <summary>
    ///   <para>w3id:env/puv#PrepMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sample preparation method (S03)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#PrepMethod">https://w3id.org/env/puv#PrepMethod</seealso>
    let PrepMethod = Prefixed_Name(envpuv, "PrepMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Property (S06) "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#Property">https://w3id.org/env/puv#Property</seealso>
    let Property = Prefixed_Name(envpuv, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#UnitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unit of Measurement (P06)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#UnitOfMeasurement">https://w3id.org/env/puv#UnitOfMeasurement</seealso>
    let UnitOfMeasurement = Prefixed_Name(envpuv, "UnitOfMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#analyticalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"analytical method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#analyticalMethod">https://w3id.org/env/puv#analyticalMethod</seealso>
    let analyticalMethod = Prefixed_Name(envpuv, "analyticalMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#biologicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"biological object of interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#biologicalObject">https://w3id.org/env/puv#biologicalObject</seealso>
    let biologicalObject = Prefixed_Name(envpuv, "biologicalObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#chemicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"chemical object of interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#chemicalObject">https://w3id.org/env/puv#chemicalObject</seealso>
    let chemicalObject = Prefixed_Name(envpuv, "chemicalObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#dataProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"data processing method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#dataProcessing">https://w3id.org/env/puv#dataProcessing</seealso>
    let dataProcessing = Prefixed_Name(envpuv, "dataProcessing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#isComposedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"link to component concepts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is composed of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#isComposedOf">https://w3id.org/env/puv#isComposedOf</seealso>
    let isComposedOf = Prefixed_Name(envpuv, "isComposedOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#matrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"environmental matrix that the measurement is in relation to "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"matrix "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#matrix">https://w3id.org/env/puv#matrix</seealso>
    let matrix = Prefixed_Name(envpuv, "matrix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#matrixRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"measurement-matrix relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#matrixRelationship">https://w3id.org/env/puv#matrixRelationship</seealso>
    let matrixRelationship = Prefixed_Name(envpuv, "matrixRelationship") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"method used to measure the value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#method">https://w3id.org/env/puv#method</seealso>
    let method = Prefixed_Name(envpuv, "method") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#objectOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"object of interest can be a chemical object, a biological object, a physical phenomenon, or a material object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"object of interest "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#objectOfInterest">https://w3id.org/env/puv#objectOfInterest</seealso>
    let objectOfInterest = Prefixed_Name(envpuv, "objectOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#physicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"physical object of interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#physicalObject">https://w3id.org/env/puv#physicalObject</seealso>
    let physicalObject = Prefixed_Name(envpuv, "physicalObject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"property or attribute that is being measured, which must be associated with either an object of interest or a matrix or both"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#property">https://w3id.org/env/puv#property</seealso>
    let property = Prefixed_Name(envpuv, "property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#samplePreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"sample-preparation method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#samplePreparation">https://w3id.org/env/puv#samplePreparation</seealso>
    let samplePreparation = Prefixed_Name(envpuv, "samplePreparation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#statistic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"statistical treatment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"statistic "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#statistic">https://w3id.org/env/puv#statistic</seealso>
    let statistic = Prefixed_Name(envpuv, "statistic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:env/puv#uom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"scale or unit of measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unit-of-measurement "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/env/puv#uom">https://w3id.org/env/puv#uom</seealso>
    let uom = Prefixed_Name(envpuv, "uom") |> PrefixedName
