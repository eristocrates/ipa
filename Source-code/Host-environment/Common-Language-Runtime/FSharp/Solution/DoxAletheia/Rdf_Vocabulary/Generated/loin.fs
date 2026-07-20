namespace https.w3id.org.loin.hash

open DoxAletheia

module loin =
    let _namespace_name = "https://w3id.org/loin#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/loin#hasDataTemplate"></see>
    /// </summary>
    let hasDataTemplate = _prefix "hasDataTemplate"
    /// <summary>
    /// Actor is a contextual aspect according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    /// Alphanumerical information is a term for specifying the information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#AlphanumericalInformation"></see></summary>
    let AlphanumericalInformation = _prefix "AlphanumericalInformation"
    /// <summary>
    ///   <see href="https://w3id.org/loin#requested"></see>
    /// </summary>
    let requested = _prefix "requested"
    /// <summary>
    /// Proxy class for the three information specifications Alphanumerical Information, Geometrical Information, and Documentation
    /// <see href="https://w3id.org/loin#Information"></see></summary>
    let Information = _prefix "Information"
    /// <summary>
    /// Appearance as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Appearance"></see></summary>
    let Appearance = _prefix "Appearance"
    /// <summary>
    /// Additional specification of geometrical information for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#GeometrySpecification"></see></summary>
    let GeometrySpecification = _prefix "GeometrySpecification"
    /// <summary>
    /// Bounds restriction specifies that the value is a number and has to fall within a range of values. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#Bounds"></see></summary>
    let Bounds = _prefix "Bounds"
    /// <summary>
    /// Breakdown structure is a term for positioning the object in a structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#BreakdownStructure"></see></summary>
    let BreakdownStructure = _prefix "BreakdownStructure"
    /// <summary>
    /// The object property relates a breakdown structure with its identifier according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasIdentifier"></see></summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    /// Breakdown structure type is a term to specify the structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#BreakdownStructureType"></see></summary>
    let BreakdownStructureType = _prefix "BreakdownStructureType"
    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#ClassificationSystem"></see></summary>
    let ClassificationSystem = _prefix "ClassificationSystem"
    /// <summary>
    /// An example of identifier type from a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Codification"></see></summary>
    let Codification = _prefix "Codification"
    /// <summary>
    /// Identifier type is used to specify the identifier in a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#IdentifierType"></see></summary>
    let IdentifierType = _prefix "IdentifierType"
    /// <summary>
    /// Detail as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Detail"></see></summary>
    let Detail = _prefix "Detail"
    /// <summary>
    /// Dimensionality as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Dimensionality"></see></summary>
    let Dimensionality = _prefix "Dimensionality"
    /// <summary>
    /// Document specification for content for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#DocumentContent"></see></summary>
    let DocumentContent = _prefix "DocumentContent"
    /// <summary>
    /// Additional specification of document for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#DocumentSpecification"></see></summary>
    let DocumentSpecification = _prefix "DocumentSpecification"
    /// <summary>
    /// Document specification for format for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#DocumentFormat"></see></summary>
    let DocumentFormat = _prefix "DocumentFormat"
    /// <summary>
    /// Document purpose is a extension according to BS EN 17412-1 (2020) 6.4 Document - Example 1. It specifies the use of document
    /// <see href="https://w3id.org/loin#DocumentPurpose"></see></summary>
    let DocumentPurpose = _prefix "DocumentPurpose"
    /// <summary>
    /// Documentation is a term for specifying the information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Documentation"></see></summary>
    let Documentation = _prefix "Documentation"
    /// <summary>
    /// Document is a term for specifying the documentation of information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#RequiredDocument"></see></summary>
    let RequiredDocument = _prefix "RequiredDocument"
    /// <summary>
    /// The object property relates a set of documents with documentation according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasDocument"></see></summary>
    let hasDocument = _prefix "hasDocument"
    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#EngineeringPrinciple"></see></summary>
    let EngineeringPrinciple = _prefix "EngineeringPrinciple"
    /// <summary>
    /// Enumeration restriction specifies that the value must be one of a list of allowed values. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#Enumeration"></see></summary>
    let Enumeration = _prefix "Enumeration"
    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#FederationStrategy"></see></summary>
    let FederationStrategy = _prefix "FederationStrategy"
    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Functional"></see></summary>
    let Functional = _prefix "Functional"
    /// <summary>
    /// Geometrical information is a term for specifying the information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#GeometricalInformation"></see></summary>
    let GeometricalInformation = _prefix "GeometricalInformation"
    /// <summary>
    /// Parametric behaviour as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#ParametricBehaviour"></see></summary>
    let ParametricBehaviour = _prefix "ParametricBehaviour"
    /// <summary>
    /// The object property relates the specific aspects with geometrical information according to BS EN 17412-1 (2020)
    /// ["Appearance",
    /// "Detail",
    /// "Dimensionality",
    /// "Location",
    /// "ParametricBehaviour"]
    /// <see href="https://w3id.org/loin#hasGeometrySpecification"></see></summary>
    let hasGeometrySpecification = _prefix "hasGeometrySpecification"
    /// <summary>
    /// Location as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Documents such as such as initial sketches, site plans according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Handdrawn_Sketches"></see></summary>
    let Handdrawn_Sketches = _prefix "Handdrawn_Sketches"
    /// <summary>
    /// Documents of geometrical information or alphanumerical information can also be considered as documents according to notes of BS EN 17412-1 (2020).
    /// <see href="https://w3id.org/loin#Hard_Copy"></see></summary>
    let Hard_Copy = _prefix "Hard_Copy"
    /// <summary>
    /// Identification is a term for positioning the object in a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Identification"></see></summary>
    let Identification = _prefix "Identification"
    /// <summary>
    /// The object property relates the identification with a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasBreakdownStructure"></see></summary>
    let hasBreakdownStructure = _prefix "hasBreakdownStructure"
    /// <summary>
    /// Identifier is used to assiging a vaule for positioning the object in a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// The object property relates an identifier of breakdown structure with a specific type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasIdentifierType"></see></summary>
    let hasIdentifierType = _prefix "hasIdentifierType"
    /// <summary>
    /// value for general definition
    /// <see href="https://w3id.org/loin#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Index, an identifier type according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Index"></see></summary>
    let Index = _prefix "Index"
    /// <summary>
    /// Alphanumerical information content is a term for specifying the alphanumerical information according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#InformationContent"></see></summary>
    let InformationContent = _prefix "InformationContent"
    /// <summary>
    /// Information delivery milestone is a contextual aspect according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#InformationDeliveryMilestone"></see></summary>
    let InformationDeliveryMilestone = _prefix "InformationDeliveryMilestone"
    /// <summary>
    /// The object property relates the purpose with the information delivery milestone according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasPurpose"></see></summary>
    let hasPurpose = _prefix "hasPurpose"
    /// <summary>
    /// The object property relates the receiver actor with the information delivery milestone according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasReceivingActor"></see></summary>
    let hasReceivingActor = _prefix "hasReceivingActor"
    /// <summary>
    /// The object property relates the sending actor with the information delivery milestone according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasSendingActor"></see></summary>
    let hasSendingActor = _prefix "hasSendingActor"
    /// <summary>
    /// The specification per object type property relates the object type specifications with the information delivery milestone according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasSpecificationPerObjectType"></see></summary>
    let hasSpecificationPerObjectType = _prefix "hasSpecificationPerObjectType"
    /// <summary>
    /// Length restriction specifies the exact number of characters allowed in a value. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#Length"></see></summary>
    let Length = _prefix "Length"
    /// <summary>
    /// Documents such as maintenance and user manuals according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Manual"></see></summary>
    let Manual = _prefix "Manual"
    /// <summary>
    /// Name, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// Geometry information is not requested
    /// <see href="https://w3id.org/loin#NotRequested"></see></summary>
    let NotRequested = _prefix "NotRequested"
    /// <summary>
    /// Numbering, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Numbering"></see></summary>
    let Numbering = _prefix "Numbering"
    /// <summary>
    /// Ontology data definition is an extension of BS EN 17412-1 (2020). It is used to specify the alphanumerical information according to a published or customized ontology
    /// <see href="https://w3id.org/loin#OntologyDataDefinition"></see></summary>
    let OntologyDataDefinition = _prefix "OntologyDataDefinition"
    /// <summary>
    ///   <see href="https://w3id.org/loin#specifiedByIdentifier"></see>
    /// </summary>
    let specifiedByIdentifier = _prefix "specifiedByIdentifier"
    /// <summary>
    /// Pattern restriction with regex method specifies advanced pattern matching. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#Pattern"></see></summary>
    let Pattern = _prefix "Pattern"
    /// <summary>
    /// Documents such as records of work done, records of existing conditions according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Photograph"></see></summary>
    let Photograph = _prefix "Photograph"
    /// <summary>
    /// The document delivered by Inquirer as percondition or information
    /// <see href="https://w3id.org/loin#Provided_As_Information"></see></summary>
    let Provided_As_Information = _prefix "Provided_As_Information"
    /// <summary>
    /// Purpose is a contextual aspect according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Purpose"></see></summary>
    let Purpose = _prefix "Purpose"
    /// <summary>
    /// Description provide detail and extend of information derived by Information Delivery Specification (IDS)
    /// <see href="https://w3id.org/loin#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Receiving actor is a party for information delivery according to ISO 19650-1 (2018)
    /// <see href="https://w3id.org/loin#ReceivingActor"></see></summary>
    let ReceivingActor = _prefix "ReceivingActor"
    /// <summary>
    /// Reference, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#ReferenceOfStructure"></see></summary>
    let ReferenceOfStructure = _prefix "ReferenceOfStructure"
    /// <summary>
    /// Documents such as geotechnical reports, reports of existing building conditions, soil surveys, pre calculations according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// The object property relates the document specifications with a document according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasDocumentSpecification"></see></summary>
    let hasDocumentSpecification = _prefix "hasDocumentSpecification"
    /// <summary>
    /// Specification of document, that relates with a respective person
    /// <see href="https://w3id.org/loin#belongsToInformationContent"></see></summary>
    let belongsToInformationContent = _prefix "belongsToInformationContent"
    /// <summary>
    /// The document required by deliverer is for getting approval
    /// <see href="https://w3id.org/loin#Required_For_Approval"></see></summary>
    let Required_For_Approval = _prefix "Required_For_Approval"
    /// <summary>
    /// The document required by deliverer with supplement of information
    /// <see href="https://w3id.org/loin#Required_with_Supplement"></see></summary>
    let Required_with_Supplement = _prefix "Required_with_Supplement"
    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Semantic"></see></summary>
    let Semantic = _prefix "Semantic"
    /// <summary>
    /// Sending actor is a party for information delivery according to ISO 19650-1 (2018)
    /// <see href="https://w3id.org/loin#SendingActor"></see></summary>
    let SendingActor = _prefix "SendingActor"
    /// <summary>
    /// Documents such as test certificates, insurance policies, delivery notes according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Signed_Document"></see></summary>
    let Signed_Document = _prefix "Signed_Document"
    /// <summary>
    /// Simple value restriction specifies the exact allowed value. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#SimpleValue"></see></summary>
    let SimpleValue = _prefix "SimpleValue"
    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Spatial"></see></summary>
    let Spatial = _prefix "Spatial"
    /// <summary>
    /// Documents such as technical specifications according to notes according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Specification"></see></summary>
    let Specification = _prefix "Specification"
    /// <summary>
    /// SpecificationPerObjectType is a contextual aspect according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#SpecificationPerObjectType"></see></summary>
    let SpecificationPerObjectType = _prefix "SpecificationPerObjectType"
    /// <summary>
    /// The object property relates the documentation with a LOIN object according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasDocumentation"></see></summary>
    let hasDocumentation = _prefix "hasDocumentation"
    /// <summary>
    /// The object property relates the geometrical information with a LOIN object according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasGeometricalInformation"></see></summary>
    let hasGeometricalInformation = _prefix "hasGeometricalInformation"
    /// <summary>
    ///   <see href="https://w3id.org/loin#hasObjectType"></see>
    /// </summary>
    let hasObjectType = _prefix "hasObjectType"
    /// <summary>
    /// The object property relates an alphanumerical information with a LOIN object according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasAlphanumericalInformation"></see></summary>
    let hasAlphanumericalInformation = _prefix "hasAlphanumericalInformation"
    /// <summary>
    /// Type name, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#TypeName"></see></summary>
    let TypeName = _prefix "TypeName"
    /// <summary>
    /// The document required by deliverer should be used as template
    /// <see href="https://w3id.org/loin#Used_As_Template"></see></summary>
    let Used_As_Template = _prefix "Used_As_Template"
    /// <summary>
    /// An example of location according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#absolute"></see></summary>
    let absolute = _prefix "absolute"
    /// <summary>
    /// An example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#constructive"></see></summary>
    let constructive = _prefix "constructive"
    /// <summary>
    /// coordination, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#coordination"></see></summary>
    let coordination = _prefix "coordination"
    /// <summary>
    /// Cost estimation, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#costEstimation"></see></summary>
    let costEstimation = _prefix "costEstimation"
    /// <summary>
    /// Detail, an example of detail aspect according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#detailed"></see></summary>
    let detailed = _prefix "detailed"
    /// <summary>
    /// Detailed design, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#detailedDesign"></see></summary>
    let detailedDesign = _prefix "detailedDesign"
    /// <summary>
    /// Explicit, an example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#explicit"></see></summary>
    let explicit = _prefix "explicit"
    /// <summary>
    /// Final design, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#finalDesign"></see></summary>
    let finalDesign = _prefix "finalDesign"
    /// <summary>
    /// Fire and smoke simulation, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#fireSmokeSimulation"></see></summary>
    let fireSmokeSimulation = _prefix "fireSmokeSimulation"
    /// <summary>
    /// Information of the information delivery actor defined by foaf ontology mit class foaf:Agent
    /// <see href="https://w3id.org/loin#hasAgent"></see></summary>
    let hasAgent = _prefix "hasAgent"
    /// <summary>
    /// Proxy property for the three information specification relationships
    /// <see href="https://w3id.org/loin#hasInformation"></see></summary>
    let hasInformation = _prefix "hasInformation"
    /// <summary>
    /// The object property relates a specific type with the breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasBreakdownStructureType"></see></summary>
    let hasBreakdownStructureType = _prefix "hasBreakdownStructureType"
    /// <summary>
    /// The object property relates the identification of a breakdown structure with an alphanumerical information according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasIdentification"></see></summary>
    let hasIdentification = _prefix "hasIdentification"
    /// <summary>
    /// The object property relates the detailed content with alphanumerical information according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasInformationContent"></see></summary>
    let hasInformationContent = _prefix "hasInformationContent"
    /// <summary>
    ///   <see href="https://w3id.org/loin#hasReferenceSource"></see>
    /// </summary>
    let hasReferenceSource = _prefix "hasReferenceSource"
    /// <summary>
    /// relates the requirement type with the defined requirements in IDS data definition
    /// <see href="https://w3id.org/loin#hasRequirementType"></see></summary>
    let hasRequirementType = _prefix "hasRequirementType"
    /// <summary>
    /// The object property relates the alphanumerical information content with document according to BS EN 17412-1(2020)
    /// <see href="https://w3id.org/loin#isRelatedToLoinDocument"></see></summary>
    let isRelatedToLoinDocument = _prefix "isRelatedToLoinDocument"
    /// <summary>
    /// one-dimensional, an example of dimensionality according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#one-dimensional"></see></summary>
    let ``one-dimensional`` = _prefix "one-dimensional"
    /// <summary>
    /// Parametric, an example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#parametric"></see></summary>
    let parametric = _prefix "parametric"
    /// <summary>
    /// Preliminary design, an example of IDM information delivery milestone from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#preliminaryDesign"></see></summary>
    let preliminaryDesign = _prefix "preliminaryDesign"
    /// <summary>
    /// Real-world, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#real-world"></see></summary>
    let ``real-world`` = _prefix "real-world"
    /// <summary>
    /// realistic, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#realistic"></see></summary>
    let realistic = _prefix "realistic"
    /// <summary>
    /// Relative, an example of location according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#relative"></see></summary>
    let relative = _prefix "relative"
    /// <summary>
    /// simplified, an example of detail according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#simplified"></see></summary>
    let simplified = _prefix "simplified"
    /// <summary>
    /// Structural analysis, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#structuralAnalysis"></see></summary>
    let structuralAnalysis = _prefix "structuralAnalysis"
    /// <summary>
    /// symbolic, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#symbolic"></see></summary>
    let symbolic = _prefix "symbolic"
    /// <summary>
    /// Three-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#three-dimensional"></see></summary>
    let ``three-dimensional`` = _prefix "three-dimensional"
    /// <summary>
    /// Two-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#two-dimensional"></see></summary>
    let ``two-dimensional`` = _prefix "two-dimensional"
    /// <summary>
    /// Visualization, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#visualization"></see></summary>
    let visualization = _prefix "visualization"
    /// <summary>
    /// zero-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#zero-dimensional"></see></summary>
    let ``zero-dimensional`` = _prefix "zero-dimensional"
