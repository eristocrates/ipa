namespace https.w3id.org.env.puv.hash

open DoxAletheia

module puv =
    let _namespace_name = "https://w3id.org/env/puv#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/env/puv#AnalyticalMethod"></see>
    /// </summary>
    let AnalyticalMethod = _prefix "AnalyticalMethod"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#Method"></see>
    /// </summary>
    let Method = _prefix "Method"
    /// <summary>
    /// Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)
    /// <see href="https://w3id.org/env/puv#BiologicalEntity"></see></summary>
    let BiologicalEntity = _prefix "BiologicalEntity"
    /// <summary>
    /// link to component concepts
    /// <see href="https://w3id.org/env/puv#isComposedOf"></see></summary>
    let isComposedOf = _prefix "isComposedOf"
    /// <summary>
    /// Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)
    /// <see href="https://w3id.org/env/puv#BiologicalEntityComponent"></see></summary>
    let BiologicalEntityComponent = _prefix "BiologicalEntityComponent"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntityColour"></see>
    /// </summary>
    let BiologicalEntityColour = _prefix "BiologicalEntityColour"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntityGender"></see>
    /// </summary>
    let BiologicalEntityGender = _prefix "BiologicalEntityGender"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntityShape"></see>
    /// </summary>
    let BiologicalEntityShape = _prefix "BiologicalEntityShape"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntitySize"></see>
    /// </summary>
    let BiologicalEntitySize = _prefix "BiologicalEntitySize"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntityStage"></see>
    /// </summary>
    let BiologicalEntityStage = _prefix "BiologicalEntityStage"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntitySubComponent"></see>
    /// </summary>
    let BiologicalEntitySubComponent = _prefix "BiologicalEntitySubComponent"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#BiologicalEntitySubGroup"></see>
    /// </summary>
    let BiologicalEntitySubGroup = _prefix "BiologicalEntitySubGroup"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#ChemicalEntity"></see>
    /// </summary>
    let ChemicalEntity = _prefix "ChemicalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#DataProcessingMethod"></see>
    /// </summary>
    let DataProcessingMethod = _prefix "DataProcessingMethod"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MMRel"></see>
    /// </summary>
    let MMRel = _prefix "MMRel"
    /// <summary>
    /// Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)
    /// <see href="https://w3id.org/env/puv#Matrix"></see></summary>
    let Matrix = _prefix "Matrix"
    /// <summary>
    /// Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)
    /// <see href="https://w3id.org/env/puv#MatrixComponent"></see></summary>
    let MatrixComponent = _prefix "MatrixComponent"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MatrixPhase"></see>
    /// </summary>
    let MatrixPhase = _prefix "MatrixPhase"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MatrixPhaseSubGroup"></see>
    /// </summary>
    let MatrixPhaseSubGroup = _prefix "MatrixPhaseSubGroup"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MatrixSphere"></see>
    /// </summary>
    let MatrixSphere = _prefix "MatrixSphere"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#MatrixSphereSubGroup"></see>
    /// </summary>
    let MatrixSphereSubGroup = _prefix "MatrixSphereSubGroup"
    /// <summary>
    /// Scientific variable in databases and data files
    /// <see href="https://w3id.org/env/puv#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#ParameterDiscovery"></see>
    /// </summary>
    let ParameterDiscovery = _prefix "ParameterDiscovery"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#ParameterStatistic"></see>
    /// </summary>
    let ParameterStatistic = _prefix "ParameterStatistic"
    /// <summary>
    /// Also see S18 (name), S19 (sub-group), S20 (datum)
    /// <see href="https://w3id.org/env/puv#PhysicalEntity"></see></summary>
    let PhysicalEntity = _prefix "PhysicalEntity"
    /// <summary>
    /// Also see S18 (name), S19 (sub-group), S20 (datum)
    /// <see href="https://w3id.org/env/puv#PhysicalEntityComponent"></see></summary>
    let PhysicalEntityComponent = _prefix "PhysicalEntityComponent"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#PhysicalEntityDatum"></see>
    /// </summary>
    let PhysicalEntityDatum = _prefix "PhysicalEntityDatum"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#PhysicalEntityName"></see>
    /// </summary>
    let PhysicalEntityName = _prefix "PhysicalEntityName"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#PhysicalEntitySubGroup"></see>
    /// </summary>
    let PhysicalEntitySubGroup = _prefix "PhysicalEntitySubGroup"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#PrepMethod"></see>
    /// </summary>
    let PrepMethod = _prefix "PrepMethod"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#Property"></see>
    /// </summary>
    let Property = _prefix "Property"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#UnitOfMeasurement"></see>
    /// </summary>
    let UnitOfMeasurement = _prefix "UnitOfMeasurement"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#analyticalMethod"></see>
    /// </summary>
    let analyticalMethod = _prefix "analyticalMethod"
    /// <summary>
    /// method used to measure the value
    /// <see href="https://w3id.org/env/puv#method"></see></summary>
    let method = _prefix "method"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#biologicalObject"></see>
    /// </summary>
    let biologicalObject = _prefix "biologicalObject"
    /// <summary>
    /// object of interest can be a chemical object, a biological object, a physical phenomenon, or a material object
    /// <see href="https://w3id.org/env/puv#objectOfInterest"></see></summary>
    let objectOfInterest = _prefix "objectOfInterest"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#chemicalObject"></see>
    /// </summary>
    let chemicalObject = _prefix "chemicalObject"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#dataProcessing"></see>
    /// </summary>
    let dataProcessing = _prefix "dataProcessing"
    /// <summary>
    /// environmental matrix that the measurement is in relation to
    /// <see href="https://w3id.org/env/puv#matrix"></see></summary>
    let matrix = _prefix "matrix"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#matrixRelationship"></see>
    /// </summary>
    let matrixRelationship = _prefix "matrixRelationship"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#physicalObject"></see>
    /// </summary>
    let physicalObject = _prefix "physicalObject"
    /// <summary>
    /// property or attribute that is being measured, which must be associated with either an object of interest or a matrix or both
    /// <see href="https://w3id.org/env/puv#property"></see></summary>
    let property = _prefix "property"
    /// <summary>
    ///   <see href="https://w3id.org/env/puv#samplePreparation"></see>
    /// </summary>
    let samplePreparation = _prefix "samplePreparation"
    /// <summary>
    /// statistical treatment
    /// <see href="https://w3id.org/env/puv#statistic"></see></summary>
    let statistic = _prefix "statistic"
    /// <summary>
    /// scale or unit of measurement
    /// <see href="https://w3id.org/env/puv#uom"></see></summary>
    let uom = _prefix "uom"
