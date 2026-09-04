#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module puv =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/env/puv#" "puv"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for an analytical method entity (part of the how theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Analytical method (S04)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#AnalyticalMethod">puv:AnalyticalMethod</a>
    /// </summary>
    let AnalyticalMethod = _prefixId.prefix "AnalyticalMethod"
    /// <summary>
    ///   <para>dcterms:description : Terms used to describe biological entities (organisms or parts thereof) in the BODC Parameter Usage Vocabulary^^xsd:string</para>
    ///   <para>rdfs:label : Biological entity (S25)^^xsd:string</para>
    ///   <para>rdfs:comment : Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntity">puv:BiologicalEntity</a>
    /// </summary>
    let BiologicalEntity = _prefixId.prefix "BiologicalEntity"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for colour or optical appearance of a biological entity (component of the what theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Biological entity colour (S15)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntityColour">puv:BiologicalEntityColour</a>
    /// </summary>
    let BiologicalEntityColour = _prefixId.prefix "BiologicalEntityColour"
    /// <summary>
    ///   <para>rdfs:label : Biological entity component^^xsd:string</para>
    ///   <para>rdfs:comment : Also see S09 (size), S10 (gender), S11 (stage), S12 (sub-component), S13 (sub-group), S14 (shape), S15 (colour)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntityComponent">puv:BiologicalEntityComponent</a>
    /// </summary>
    let BiologicalEntityComponent = _prefixId.prefix "BiologicalEntityComponent"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining terms used to refer to a biological entity sex category (part of the what theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Biological entity gender (S10)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntityGender">puv:BiologicalEntityGender</a>
    /// </summary>
    let BiologicalEntityGender = _prefixId.prefix "BiologicalEntityGender"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for morphology of a biological entity (component of the what theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Biological entity shape (S14)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntityShape">puv:BiologicalEntityShape</a>
    /// </summary>
    let BiologicalEntityShape = _prefixId.prefix "BiologicalEntityShape"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for biological entity size (part of the what theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Biological entity size (S09)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntitySize">puv:BiologicalEntitySize</a>
    /// </summary>
    let BiologicalEntitySize = _prefixId.prefix "BiologicalEntitySize"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used to specify the development or life cycle stage of a biological entity (part of the 'what' theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Biological entity stage (S11)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntityStage">puv:BiologicalEntityStage</a>
    /// </summary>
    let BiologicalEntityStage = _prefixId.prefix "BiologicalEntityStage"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for biological entity (component of the what theme) plant or animal parts in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Biological entity sub-component (S12)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntitySubComponent">puv:BiologicalEntitySubComponent</a>
    /// </summary>
    let BiologicalEntitySubComponent = _prefixId.prefix "BiologicalEntitySubComponent"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for ad-hoc qualification of a biological entity (component of the what theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Biological entity sub-group (S13)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#BiologicalEntitySubGroup">puv:BiologicalEntitySubGroup</a>
    /// </summary>
    let BiologicalEntitySubGroup = _prefixId.prefix "BiologicalEntitySubGroup"
    /// <summary>
    ///   <para>dcterms:description : Terms for chemicals whose quantity in a matrix is determined to generate measurements in the BODC parameter usage vocabulary semantic model. Includes elements, compounds, isotopes and mixtures^^xsd:string</para>
    ///   <para>rdfs:label : Chemical substance (S27)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#ChemicalEntity">puv:ChemicalEntity</a>
    /// </summary>
    let ChemicalEntity = _prefixId.prefix "ChemicalEntity"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for data processing description (part of the how theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Data processing method (S05)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#DataProcessingMethod">puv:DataProcessingMethod</a>
    /// </summary>
    let DataProcessingMethod = _prefixId.prefix "DataProcessingMethod"
    /// <summary>
    ///   <para>rdfs:label : Entity that bears the parameter^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#Entity">puv:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>dcterms:description : Terms used to describe the relationship between the 'where theme' and the 'what theme' in the BODC semantic model for measured phenomena descriptions^^xsd:string</para>
    ///   <para>rdfs:label : Measurement-matrix relationship (S02)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#MMRel">puv:MMRel</a>
    /// </summary>
    let MMRel = _prefixId.prefix "MMRel"
    /// <summary>
    ///   <para>dcterms:description : Terms used to describe the medium in which a measurement was made in the semantic model that underpins the BODC parameter discovery vocabulary^^xsd:string</para>
    ///   <para>rdfs:label : Matrix (S26)^^xsd:string</para>
    ///   <para>rdfs:comment : Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#Matrix">puv:Matrix</a>
    /// </summary>
    let Matrix = _prefixId.prefix "Matrix"
    /// <summary>
    ///   <para>rdfs:label : Matrix component^^xsd:string</para>
    ///   <para>rdfs:comment : Also see S21 (sphere), S22 (sphere sub-group), S23 (phase), S24 (phase sub-group)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#MatrixComponent">puv:MatrixComponent</a>
    /// </summary>
    let MatrixComponent = _prefixId.prefix "MatrixComponent"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms for phase (dissolved, particulate etc.) within a sphere (SWEET EarthRealm) in the BODC parameter semantic model. Part of the where theme^^xsd:string</para>
    ///   <para>rdfs:label : Sphere phase (S23)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#MatrixPhase">puv:MatrixPhase</a>
    /// </summary>
    let MatrixPhase = _prefixId.prefix "MatrixPhase"
    /// <summary>
    ///   <para>dcterms:description : Concepts describing physical or logical (i.e. categories) subdivisions of a phase (i.e. subcomponent) of a sphere (SWEET EarthRealm) in the BODC parameter semantic model. Part of the where theme^^xsd:string</para>
    ///   <para>rdfs:label : Sphere phase sub-group (S24)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#MatrixPhaseSubGroup">puv:MatrixPhaseSubGroup</a>
    /// </summary>
    let MatrixPhaseSubGroup = _prefixId.prefix "MatrixPhaseSubGroup"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used to describe the sphere (SWEET EarthRealm) in the BODC parameter semantic model. Part of the where theme^^xsd:string</para>
    ///   <para>rdfs:label : Matrix sphere (S21)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#MatrixSphere">puv:MatrixSphere</a>
    /// </summary>
    let MatrixSphere = _prefixId.prefix "MatrixSphere"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used to describe subgroupings of the sphere (SWEET EarthRealm) in the BODC parameter semantic model. Part of the where theme^^xsd:string</para>
    ///   <para>rdfs:label : Matrix sphere sub-group (S22)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#MatrixSphereSubGroup">puv:MatrixSphereSubGroup</a>
    /// </summary>
    let MatrixSphereSubGroup = _prefixId.prefix "MatrixSphereSubGroup"
    /// <summary>
    ///   <para>rdfs:label : Method used^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#Method">puv:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>skos:scopeNote : Remember that a P01 label is always constructed from the following association of concepts:
    ///
    /// The property or attribute	'of'	an object of interest	in relation to	an environmental matrix	'by'	a method (optional)
    /// All fields apart from 'of' and 'by' are populated from NVS controlled vocabularies (see this diagram for simple visualisation or download it to use as a tool for quick access to the semantic components of a P01 concept).^^xsd:string</para>
    ///   <para>dcterms:description : Terms built using the BODC parameter semantic model designed to describe individual measured phenomena. May be used to mark up sets of data such as a NetCDF array or spreadsheet column^^xsd:string</para>
    ///   <para>rdfs:label : Parameter (P01)^^xsd:string</para>
    ///   <para>rdfs:comment : Scientific variable in databases and data files^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#Parameter">puv:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>dcterms:description : Terms describing fine-grained related groups of measurement phenomena designed to be used in dataset discovery interfaces^^xsd:string</para>
    ///   <para>rdfs:label : SeaDataNet Parameter Discovery (P02)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#ParameterDiscovery">puv:ParameterDiscovery</a>
    /// </summary>
    let ParameterDiscovery = _prefixId.prefix "ParameterDiscovery"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for a parameter statistic (part of the what theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Parameter statistic (S07)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#ParameterStatistic">puv:ParameterStatistic</a>
    /// </summary>
    let ParameterStatistic = _prefixId.prefix "ParameterStatistic"
    /// <summary>
    ///   <para>dcterms:description : Terms used to describe physical entities in the BODC Parameter Usage Vocabulary^^xsd:string</para>
    ///   <para>rdfs:label : Physical entity (S29)^^xsd:string</para>
    ///   <para>rdfs:comment : Also see S18 (name), S19 (sub-group), S20 (datum)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#PhysicalEntity">puv:PhysicalEntity</a>
    /// </summary>
    let PhysicalEntity = _prefixId.prefix "PhysicalEntity"
    /// <summary>
    ///   <para>rdfs:label : Physical entity component^^xsd:string</para>
    ///   <para>rdfs:comment : Also see S18 (name), S19 (sub-group), S20 (datum)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#PhysicalEntityComponent">puv:PhysicalEntityComponent</a>
    /// </summary>
    let PhysicalEntityComponent = _prefixId.prefix "PhysicalEntityComponent"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used to describe the reference with respect to which a physical entity (part of the what theme) in the BODC parameter. semantic model is specified^^xsd:string</para>
    ///   <para>rdfs:label : Physical entity datum (S20)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#PhysicalEntityDatum">puv:PhysicalEntityDatum</a>
    /// </summary>
    let PhysicalEntityDatum = _prefixId.prefix "PhysicalEntityDatum"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for a physical entity (part of the what theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Physical entity name (S18)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#PhysicalEntityName">puv:PhysicalEntityName</a>
    /// </summary>
    let PhysicalEntityName = _prefixId.prefix "PhysicalEntityName"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used to qualify a generic physical entity (part of the what theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Physical entity sub-group (S19)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#PhysicalEntitySubGroup">puv:PhysicalEntitySubGroup</a>
    /// </summary>
    let PhysicalEntitySubGroup = _prefixId.prefix "PhysicalEntitySubGroup"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used for a sample preparation entity (part of the how theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Sample preparation method (S03)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#PrepMethod">puv:PrepMethod</a>
    /// </summary>
    let PrepMethod = _prefixId.prefix "PrepMethod"
    /// <summary>
    ///   <para>dcterms:description : Controlled vocabulary defining the terms that may be used to specify the property element of a parameter (part of the 'what' theme) in the BODC parameter semantic model^^xsd:string</para>
    ///   <para>rdfs:label : Property (S06) ^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#Property">puv:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>dcterms:description : Terms approved for use by BODC to describe the measurement units for data held in its repositories^^xsd:string</para>
    ///   <para>rdfs:label : Unit of Measurement (P06)^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#UnitOfMeasurement">puv:UnitOfMeasurement</a>
    /// </summary>
    let UnitOfMeasurement = _prefixId.prefix "UnitOfMeasurement"
    /// <summary>
    ///   <para>rdfs:label : analytical method^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#analyticalMethod">puv:analyticalMethod</a>
    /// </summary>
    let analyticalMethod = _prefixId.prefix "analyticalMethod"
    /// <summary>
    ///   <para>rdfs:label : biological object of interest^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#biologicalObject">puv:biologicalObject</a>
    /// </summary>
    let biologicalObject = _prefixId.prefix "biologicalObject"
    /// <summary>
    ///   <para>rdfs:label : chemical object of interest^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#chemicalObject">puv:chemicalObject</a>
    /// </summary>
    let chemicalObject = _prefixId.prefix "chemicalObject"
    /// <summary>
    ///   <para>rdfs:label : data processing method^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#dataProcessing">puv:dataProcessing</a>
    /// </summary>
    let dataProcessing = _prefixId.prefix "dataProcessing"
    /// <summary>
    ///   <para>rdfs:label : is composed of^^xsd:string</para>
    ///   <para>rdfs:comment : link to component concepts^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#isComposedOf">puv:isComposedOf</a>
    /// </summary>
    let isComposedOf = _prefixId.prefix "isComposedOf"
    /// <summary>
    ///   <para>skos:scopeNote : What is the environmental matrix?
    ///
    /// - Do I need one? You will for most environmental measurements.
    /// - Why? This is to remove any ambiguity about what the value reported relates to.
    /// - Take for example "Concentration of cadmium" - This is an ambiguous label if used to define a variable because it does not say concentration of cadmium in what? In the sediment? a water body? the atmosphere? a biological organism? If the former was it in the liquid phase or attached to particles? If the latter was it in the whole organism or one of its organs?
    /// - If the measurement relates to a water body or the atmosphere one needs to ask: Was the sample filtered? If it were, then the filter type or filter size is an important information to be stored close to the measurement value. In the P01 semantic model this is captured as part of the matrix definition.
    ///
    /// For example, when a dissolved quantity is measured in a water body, we apply the following rules
    ///
    /// - Use "water body [dissolved plus reactive particulate phase]" if the sample was not filtered
    /// - Use "water body [dissolved plus reactive particulate &lt;GF/F phase]" if the sample was filtered through GF/F filter
    /// - Use "water body [dissolved plus reactive particulate &lt;0.4/0.45um phase]" if the sample was filtered through a 0.4/0.45 um membrane
    /// - Use "water body [dissolved plus reactive particulate &lt;unknown phase]" if the sample was filtered but the filter type is unknown.^^xsd:string</para>
    ///   <para>rdfs:label : matrix ^^xsd:string</para>
    ///   <para>rdfs:comment : environmental matrix that the measurement is in relation to ^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#matrix">puv:matrix</a>
    /// </summary>
    let matrix = _prefixId.prefix "matrix"
    /// <summary>
    ///   <para>rdfs:label : measurement-matrix relationship^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#matrixRelationship">puv:matrixRelationship</a>
    /// </summary>
    let matrixRelationship = _prefixId.prefix "matrixRelationship"
    /// <summary>
    ///   <para>skos:scopeNote : Do I need to specify the method?
    ///
    /// - This can be important for some measurements or if one wants to distinguish between quantities measured using different methods
    /// - The method is specified to avoid ambiguity and minimise the need to refer to free-text documentation
    /// - It can help with automated data compilation and aggregation and decrease the risk of data being misinterpreted
    ///
    /// Take for example, chlorophyll-a. The output from an in situ fluorometer is often labelled as "Concentration of chlorophyll-a". However the values cannot be guaranteed to be an accurate representation of the real amount of chlorophyll-a in a water body without access to textual information about the method and knowing whether the data have been validated against chlorophyll-a measured by filtration, extracted in a solvent and analysed using either HPLC, fluorometry or photometric methods. Most users would require that an automated search of chlorophyll-a data be able to distinguish between these different methods. The P01 semantic model is built so that this information can be captured in the parameter code.^^xsd:string</para>
    ///   <para>rdfs:label : method^^xsd:string</para>
    ///   <para>rdfs:comment : method used to measure the value^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#method">puv:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    /// <summary>
    ///   <para>skos:scopeNote : What are the objects of interest? Are they chemical substances? biological organisms? material objects? physical phenomena? none of these?
    ///
    /// Note that if the property is the property of the environment under study (e.g. "pH of the water body" or "Temperature of the atmosphere") then the object of interest is the environmental matrix and the field "object of interest" can be ignored.^^xsd:string</para>
    ///   <para>rdfs:label : object of interest ^^xsd:string</para>
    ///   <para>rdfs:comment : object of interest can be a chemical object, a biological object, a physical phenomenon, or a material object^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#objectOfInterest">puv:objectOfInterest</a>
    /// </summary>
    let objectOfInterest = _prefixId.prefix "objectOfInterest"
    /// <summary>
    ///   <para>rdfs:label : physical object of interest^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#physicalObject">puv:physicalObject</a>
    /// </summary>
    let physicalObject = _prefixId.prefix "physicalObject"
    /// <summary>
    ///   <para>skos:scopeNote : What are the properties measured or observed? What kind of properties are they? Concentrations? Abundances? Temperature? Uptake rates? pH?^^xsd:string</para>
    ///   <para>rdfs:label : property^^xsd:string</para>
    ///   <para>rdfs:comment : property or attribute that is being measured, which must be associated with either an object of interest or a matrix or both^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#property">puv:property</a>
    /// </summary>
    let property = _prefixId.prefix "property"
    /// <summary>
    ///   <para>rdfs:label : sample-preparation method^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#samplePreparation">puv:samplePreparation</a>
    /// </summary>
    let samplePreparation = _prefixId.prefix "samplePreparation"
    /// <summary>
    ///   <para>rdfs:label : statistic ^^xsd:string</para>
    ///   <para>rdfs:comment : statistical treatment^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#statistic">puv:statistic</a>
    /// </summary>
    let statistic = _prefixId.prefix "statistic"
    /// <summary>
    ///   <para>rdfs:label : unit-of-measurement ^^xsd:string</para>
    ///   <para>rdfs:comment : scale or unit of measurement^^xsd:string</para>
    ///   <a href="https://w3id.org/env/puv#uom">puv:uom</a>
    /// </summary>
    let uom = _prefixId.prefix "uom"
