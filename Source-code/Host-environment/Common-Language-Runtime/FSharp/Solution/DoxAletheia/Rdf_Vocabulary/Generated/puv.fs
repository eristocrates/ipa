namespace https.w3id.org.env.puv.hash

open DoxAletheia.Rdf_Vocabulary

module puv =
    let _namespace_name = "https://w3id.org/env/puv#"

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#AnalyticalMethod"></see>
    /// </summary>
    let AnalyticalMethod =
        Namespaced_IRI.parse _namespace_name "AnalyticalMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#Method"></see>
    /// </summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName

    /// <summary>
    /// Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)
    /// <see href="https://w3id.org/env/puv#BiologicalEntity"></see></summary>
    let BiologicalEntity =
        Namespaced_IRI.parse _namespace_name "BiologicalEntity" |> NamespacedName

    /// <summary>
    /// link to component concepts
    /// <see href="https://w3id.org/env/puv#isComposedOf"></see></summary>
    let isComposedOf =
        Namespaced_IRI.parse _namespace_name "isComposedOf" |> NamespacedName

    /// <summary>
    /// Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)
    /// <see href="https://w3id.org/env/puv#BiologicalEntityComponent"></see></summary>
    let BiologicalEntityComponent =
        Namespaced_IRI.parse _namespace_name "BiologicalEntityComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntityColour"></see>
    /// </summary>
    let BiologicalEntityColour =
        Namespaced_IRI.parse _namespace_name "BiologicalEntityColour" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntityGender"></see>
    /// </summary>
    let BiologicalEntityGender =
        Namespaced_IRI.parse _namespace_name "BiologicalEntityGender" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntityShape"></see>
    /// </summary>
    let BiologicalEntityShape =
        Namespaced_IRI.parse _namespace_name "BiologicalEntityShape" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntitySize"></see>
    /// </summary>
    let BiologicalEntitySize =
        Namespaced_IRI.parse _namespace_name "BiologicalEntitySize" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntityStage"></see>
    /// </summary>
    let BiologicalEntityStage =
        Namespaced_IRI.parse _namespace_name "BiologicalEntityStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntitySubComponent"></see>
    /// </summary>
    let BiologicalEntitySubComponent =
        Namespaced_IRI.parse _namespace_name "BiologicalEntitySubComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntitySubGroup"></see>
    /// </summary>
    let BiologicalEntitySubGroup =
        Namespaced_IRI.parse _namespace_name "BiologicalEntitySubGroup" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#ChemicalEntity"></see>
    /// </summary>
    let ChemicalEntity =
        Namespaced_IRI.parse _namespace_name "ChemicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#DataProcessingMethod"></see>
    /// </summary>
    let DataProcessingMethod =
        Namespaced_IRI.parse _namespace_name "DataProcessingMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MMRel"></see>
    /// </summary>
    let MMRel = Namespaced_IRI.parse _namespace_name "MMRel" |> NamespacedName
    /// <summary>
    /// Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)
    /// <see href="https://w3id.org/env/puv#Matrix"></see></summary>
    let Matrix = Namespaced_IRI.parse _namespace_name "Matrix" |> NamespacedName

    /// <summary>
    /// Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)
    /// <see href="https://w3id.org/env/puv#MatrixComponent"></see></summary>
    let MatrixComponent =
        Namespaced_IRI.parse _namespace_name "MatrixComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MatrixPhase"></see>
    /// </summary>
    let MatrixPhase =
        Namespaced_IRI.parse _namespace_name "MatrixPhase" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MatrixPhaseSubGroup"></see>
    /// </summary>
    let MatrixPhaseSubGroup =
        Namespaced_IRI.parse _namespace_name "MatrixPhaseSubGroup" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MatrixSphere"></see>
    /// </summary>
    let MatrixSphere =
        Namespaced_IRI.parse _namespace_name "MatrixSphere" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MatrixSphereSubGroup"></see>
    /// </summary>
    let MatrixSphereSubGroup =
        Namespaced_IRI.parse _namespace_name "MatrixSphereSubGroup" |> NamespacedName

    /// <summary>
    /// Scientific variable in databases and data files
    /// <see href="https://w3id.org/env/puv#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#ParameterDiscovery"></see>
    /// </summary>
    let ParameterDiscovery =
        Namespaced_IRI.parse _namespace_name "ParameterDiscovery" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#ParameterStatistic"></see>
    /// </summary>
    let ParameterStatistic =
        Namespaced_IRI.parse _namespace_name "ParameterStatistic" |> NamespacedName

    /// <summary>
    /// Also see S18 (name), S19 (sub-group), S20 (datum)
    /// <see href="https://w3id.org/env/puv#PhysicalEntity"></see></summary>
    let PhysicalEntity =
        Namespaced_IRI.parse _namespace_name "PhysicalEntity" |> NamespacedName

    /// <summary>
    /// Also see S18 (name), S19 (sub-group), S20 (datum)
    /// <see href="https://w3id.org/env/puv#PhysicalEntityComponent"></see></summary>
    let PhysicalEntityComponent =
        Namespaced_IRI.parse _namespace_name "PhysicalEntityComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#PhysicalEntityDatum"></see>
    /// </summary>
    let PhysicalEntityDatum =
        Namespaced_IRI.parse _namespace_name "PhysicalEntityDatum" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#PhysicalEntityName"></see>
    /// </summary>
    let PhysicalEntityName =
        Namespaced_IRI.parse _namespace_name "PhysicalEntityName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#PhysicalEntitySubGroup"></see>
    /// </summary>
    let PhysicalEntitySubGroup =
        Namespaced_IRI.parse _namespace_name "PhysicalEntitySubGroup" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#PrepMethod"></see>
    /// </summary>
    let PrepMethod = Namespaced_IRI.parse _namespace_name "PrepMethod" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#Property"></see>
    /// </summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#UnitOfMeasurement"></see>
    /// </summary>
    let UnitOfMeasurement =
        Namespaced_IRI.parse _namespace_name "UnitOfMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#analyticalMethod"></see>
    /// </summary>
    let analyticalMethod =
        Namespaced_IRI.parse _namespace_name "analyticalMethod" |> NamespacedName

    /// <summary>
    /// method used to measure the value
    /// <see href="https://w3id.org/env/puv#method"></see></summary>
    let method = Namespaced_IRI.parse _namespace_name "method" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#biologicalObject"></see>
    /// </summary>
    let biologicalObject =
        Namespaced_IRI.parse _namespace_name "biologicalObject" |> NamespacedName

    /// <summary>
    /// object of interest can be a chemical object, a biological object, a physical phenomenon, or a material object
    /// <see href="https://w3id.org/env/puv#objectOfInterest"></see></summary>
    let objectOfInterest =
        Namespaced_IRI.parse _namespace_name "objectOfInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#chemicalObject"></see>
    /// </summary>
    let chemicalObject =
        Namespaced_IRI.parse _namespace_name "chemicalObject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#dataProcessing"></see>
    /// </summary>
    let dataProcessing =
        Namespaced_IRI.parse _namespace_name "dataProcessing" |> NamespacedName

    /// <summary>
    /// environmental matrix that the measurement is in relation to
    /// <see href="https://w3id.org/env/puv#matrix"></see></summary>
    let matrix = Namespaced_IRI.parse _namespace_name "matrix" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#matrixRelationship"></see>
    /// </summary>
    let matrixRelationship =
        Namespaced_IRI.parse _namespace_name "matrixRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#physicalObject"></see>
    /// </summary>
    let physicalObject =
        Namespaced_IRI.parse _namespace_name "physicalObject" |> NamespacedName

    /// <summary>
    /// property or attribute that is being measured, which must be associated with either an object of interest or a matrix or both
    /// <see href="https://w3id.org/env/puv#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#samplePreparation"></see>
    /// </summary>
    let samplePreparation =
        Namespaced_IRI.parse _namespace_name "samplePreparation" |> NamespacedName

    /// <summary>
    /// statistical treatment
    /// <see href="https://w3id.org/env/puv#statistic"></see></summary>
    let statistic = Namespaced_IRI.parse _namespace_name "statistic" |> NamespacedName
    /// <summary>
    /// scale or unit of measurement
    /// <see href="https://w3id.org/env/puv#uom"></see></summary>
    let uom = Namespaced_IRI.parse _namespace_name "uom" |> NamespacedName
