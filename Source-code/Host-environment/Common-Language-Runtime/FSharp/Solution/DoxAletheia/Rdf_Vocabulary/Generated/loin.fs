namespace https.w3id.org.loin.hash

open DoxAletheia.Rdf_Vocabulary

module loin =
    let _namespace_name = "https://w3id.org/loin#"

    /// <summary>
    ///   <see href="https://w3id.org/loin#hasDataTemplate"></see>
    /// </summary>
    let hasDataTemplate =
        Namespaced_IRI.parse _namespace_name "hasDataTemplate" |> NamespacedName

    /// <summary>
    /// Actor is a contextual aspect according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName

    /// <summary>
    /// Alphanumerical information is a term for specifying the information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#AlphanumericalInformation"></see></summary>
    let AlphanumericalInformation =
        Namespaced_IRI.parse _namespace_name "AlphanumericalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/loin#requested"></see>
    /// </summary>
    let requested = Namespaced_IRI.parse _namespace_name "requested" |> NamespacedName

    /// <summary>
    /// Proxy class for the three information specifications Alphanumerical Information, Geometrical Information, and Documentation
    /// <see href="https://w3id.org/loin#Information"></see></summary>
    let Information =
        Namespaced_IRI.parse _namespace_name "Information" |> NamespacedName

    /// <summary>
    /// Appearance as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Appearance"></see></summary>
    let Appearance = Namespaced_IRI.parse _namespace_name "Appearance" |> NamespacedName

    /// <summary>
    /// Additional specification of geometrical information for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#GeometrySpecification"></see></summary>
    let GeometrySpecification =
        Namespaced_IRI.parse _namespace_name "GeometrySpecification" |> NamespacedName

    /// <summary>
    /// Bounds restriction specifies that the value is a number and has to fall within a range of values. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#Bounds"></see></summary>
    let Bounds = Namespaced_IRI.parse _namespace_name "Bounds" |> NamespacedName

    /// <summary>
    /// Breakdown structure is a term for positioning the object in a structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#BreakdownStructure"></see></summary>
    let BreakdownStructure =
        Namespaced_IRI.parse _namespace_name "BreakdownStructure" |> NamespacedName

    /// <summary>
    /// The object property relates a breakdown structure with its identifier according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasIdentifier"></see></summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    /// Breakdown structure type is a term to specify the structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#BreakdownStructureType"></see></summary>
    let BreakdownStructureType =
        Namespaced_IRI.parse _namespace_name "BreakdownStructureType" |> NamespacedName

    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#ClassificationSystem"></see></summary>
    let ClassificationSystem =
        Namespaced_IRI.parse _namespace_name "ClassificationSystem" |> NamespacedName

    /// <summary>
    /// An example of identifier type from a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Codification"></see></summary>
    let Codification =
        Namespaced_IRI.parse _namespace_name "Codification" |> NamespacedName

    /// <summary>
    /// Identifier type is used to specify the identifier in a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#IdentifierType"></see></summary>
    let IdentifierType =
        Namespaced_IRI.parse _namespace_name "IdentifierType" |> NamespacedName

    /// <summary>
    /// Detail as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Detail"></see></summary>
    let Detail = Namespaced_IRI.parse _namespace_name "Detail" |> NamespacedName

    /// <summary>
    /// Dimensionality as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Dimensionality"></see></summary>
    let Dimensionality =
        Namespaced_IRI.parse _namespace_name "Dimensionality" |> NamespacedName

    /// <summary>
    /// Document specification for content for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#DocumentContent"></see></summary>
    let DocumentContent =
        Namespaced_IRI.parse _namespace_name "DocumentContent" |> NamespacedName

    /// <summary>
    /// Additional specification of document for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#DocumentSpecification"></see></summary>
    let DocumentSpecification =
        Namespaced_IRI.parse _namespace_name "DocumentSpecification" |> NamespacedName

    /// <summary>
    /// Document specification for format for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#DocumentFormat"></see></summary>
    let DocumentFormat =
        Namespaced_IRI.parse _namespace_name "DocumentFormat" |> NamespacedName

    /// <summary>
    /// Document purpose is a extension according to BS EN 17412-1 (2020) 6.4 Document - Example 1. It specifies the use of document
    /// <see href="https://w3id.org/loin#DocumentPurpose"></see></summary>
    let DocumentPurpose =
        Namespaced_IRI.parse _namespace_name "DocumentPurpose" |> NamespacedName

    /// <summary>
    /// Documentation is a term for specifying the information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Documentation"></see></summary>
    let Documentation =
        Namespaced_IRI.parse _namespace_name "Documentation" |> NamespacedName

    /// <summary>
    /// Document is a term for specifying the documentation of information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#RequiredDocument"></see></summary>
    let RequiredDocument =
        Namespaced_IRI.parse _namespace_name "RequiredDocument" |> NamespacedName

    /// <summary>
    /// The object property relates a set of documents with documentation according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasDocument"></see></summary>
    let hasDocument =
        Namespaced_IRI.parse _namespace_name "hasDocument" |> NamespacedName

    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#EngineeringPrinciple"></see></summary>
    let EngineeringPrinciple =
        Namespaced_IRI.parse _namespace_name "EngineeringPrinciple" |> NamespacedName

    /// <summary>
    /// Enumeration restriction specifies that the value must be one of a list of allowed values. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#Enumeration"></see></summary>
    let Enumeration =
        Namespaced_IRI.parse _namespace_name "Enumeration" |> NamespacedName

    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#FederationStrategy"></see></summary>
    let FederationStrategy =
        Namespaced_IRI.parse _namespace_name "FederationStrategy" |> NamespacedName

    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Functional"></see></summary>
    let Functional = Namespaced_IRI.parse _namespace_name "Functional" |> NamespacedName

    /// <summary>
    /// Geometrical information is a term for specifying the information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#GeometricalInformation"></see></summary>
    let GeometricalInformation =
        Namespaced_IRI.parse _namespace_name "GeometricalInformation" |> NamespacedName

    /// <summary>
    /// Parametric behaviour as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#ParametricBehaviour"></see></summary>
    let ParametricBehaviour =
        Namespaced_IRI.parse _namespace_name "ParametricBehaviour" |> NamespacedName

    /// <summary>
    /// The object property relates the specific aspects with geometrical information according to BS EN 17412-1 (2020)
    /// ["Appearance",
    /// "Detail",
    /// "Dimensionality",
    /// "Location",
    /// "ParametricBehaviour"]
    /// <see href="https://w3id.org/loin#hasGeometrySpecification"></see></summary>
    let hasGeometrySpecification =
        Namespaced_IRI.parse _namespace_name "hasGeometrySpecification" |> NamespacedName

    /// <summary>
    /// Location as a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// Documents such as such as initial sketches, site plans according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Handdrawn_Sketches"></see></summary>
    let Handdrawn_Sketches =
        Namespaced_IRI.parse _namespace_name "Handdrawn_Sketches" |> NamespacedName

    /// <summary>
    /// Documents of geometrical information or alphanumerical information can also be considered as documents according to notes of BS EN 17412-1 (2020).
    /// <see href="https://w3id.org/loin#Hard_Copy"></see></summary>
    let Hard_Copy = Namespaced_IRI.parse _namespace_name "Hard_Copy" |> NamespacedName

    /// <summary>
    /// Identification is a term for positioning the object in a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Identification"></see></summary>
    let Identification =
        Namespaced_IRI.parse _namespace_name "Identification" |> NamespacedName

    /// <summary>
    /// The object property relates the identification with a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasBreakdownStructure"></see></summary>
    let hasBreakdownStructure =
        Namespaced_IRI.parse _namespace_name "hasBreakdownStructure" |> NamespacedName

    /// <summary>
    /// Identifier is used to assiging a vaule for positioning the object in a breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Identifier"></see></summary>
    let Identifier = Namespaced_IRI.parse _namespace_name "Identifier" |> NamespacedName

    /// <summary>
    /// The object property relates an identifier of breakdown structure with a specific type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasIdentifierType"></see></summary>
    let hasIdentifierType =
        Namespaced_IRI.parse _namespace_name "hasIdentifierType" |> NamespacedName

    /// <summary>
    /// value for general definition
    /// <see href="https://w3id.org/loin#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// Index, an identifier type according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Index"></see></summary>
    let Index = Namespaced_IRI.parse _namespace_name "Index" |> NamespacedName

    /// <summary>
    /// Alphanumerical information content is a term for specifying the alphanumerical information according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#InformationContent"></see></summary>
    let InformationContent =
        Namespaced_IRI.parse _namespace_name "InformationContent" |> NamespacedName

    /// <summary>
    /// Information delivery milestone is a contextual aspect according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#InformationDeliveryMilestone"></see></summary>
    let InformationDeliveryMilestone =
        Namespaced_IRI.parse _namespace_name "InformationDeliveryMilestone" |> NamespacedName

    /// <summary>
    /// The object property relates the purpose with the information delivery milestone according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasPurpose"></see></summary>
    let hasPurpose = Namespaced_IRI.parse _namespace_name "hasPurpose" |> NamespacedName

    /// <summary>
    /// The object property relates the receiver actor with the information delivery milestone according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasReceivingActor"></see></summary>
    let hasReceivingActor =
        Namespaced_IRI.parse _namespace_name "hasReceivingActor" |> NamespacedName

    /// <summary>
    /// The object property relates the sending actor with the information delivery milestone according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasSendingActor"></see></summary>
    let hasSendingActor =
        Namespaced_IRI.parse _namespace_name "hasSendingActor" |> NamespacedName

    /// <summary>
    /// The specification per object type property relates the object type specifications with the information delivery milestone according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasSpecificationPerObjectType"></see></summary>
    let hasSpecificationPerObjectType =
        Namespaced_IRI.parse _namespace_name "hasSpecificationPerObjectType" |> NamespacedName

    /// <summary>
    /// Length restriction specifies the exact number of characters allowed in a value. It is defined by complex restriction of IDS. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#Length"></see></summary>
    let Length = Namespaced_IRI.parse _namespace_name "Length" |> NamespacedName
    /// <summary>
    /// Documents such as maintenance and user manuals according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Manual"></see></summary>
    let Manual = Namespaced_IRI.parse _namespace_name "Manual" |> NamespacedName
    /// <summary>
    /// Name, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName

    /// <summary>
    /// Geometry information is not requested
    /// <see href="https://w3id.org/loin#NotRequested"></see></summary>
    let NotRequested =
        Namespaced_IRI.parse _namespace_name "NotRequested" |> NamespacedName

    /// <summary>
    /// Numbering, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Numbering"></see></summary>
    let Numbering = Namespaced_IRI.parse _namespace_name "Numbering" |> NamespacedName

    /// <summary>
    /// Ontology data definition is an extension of BS EN 17412-1 (2020). It is used to specify the alphanumerical information according to a published or customized ontology
    /// <see href="https://w3id.org/loin#OntologyDataDefinition"></see></summary>
    let OntologyDataDefinition =
        Namespaced_IRI.parse _namespace_name "OntologyDataDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/loin#specifiedByIdentifier"></see>
    /// </summary>
    let specifiedByIdentifier =
        Namespaced_IRI.parse _namespace_name "specifiedByIdentifier" |> NamespacedName

    /// <summary>
    /// Pattern restriction with regex method specifies advanced pattern matching. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#Pattern"></see></summary>
    let Pattern = Namespaced_IRI.parse _namespace_name "Pattern" |> NamespacedName
    /// <summary>
    /// Documents such as records of work done, records of existing conditions according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Photograph"></see></summary>
    let Photograph = Namespaced_IRI.parse _namespace_name "Photograph" |> NamespacedName

    /// <summary>
    /// The document delivered by Inquirer as percondition or information
    /// <see href="https://w3id.org/loin#Provided_As_Information"></see></summary>
    let Provided_As_Information =
        Namespaced_IRI.parse _namespace_name "Provided_As_Information" |> NamespacedName

    /// <summary>
    /// Purpose is a contextual aspect according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Purpose"></see></summary>
    let Purpose = Namespaced_IRI.parse _namespace_name "Purpose" |> NamespacedName

    /// <summary>
    /// Description provide detail and extend of information derived by Information Delivery Specification (IDS)
    /// <see href="https://w3id.org/loin#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Receiving actor is a party for information delivery according to ISO 19650-1 (2018)
    /// <see href="https://w3id.org/loin#ReceivingActor"></see></summary>
    let ReceivingActor =
        Namespaced_IRI.parse _namespace_name "ReceivingActor" |> NamespacedName

    /// <summary>
    /// Reference, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#ReferenceOfStructure"></see></summary>
    let ReferenceOfStructure =
        Namespaced_IRI.parse _namespace_name "ReferenceOfStructure" |> NamespacedName

    /// <summary>
    /// Documents such as geotechnical reports, reports of existing building conditions, soil surveys, pre calculations according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName

    /// <summary>
    /// The object property relates the document specifications with a document according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasDocumentSpecification"></see></summary>
    let hasDocumentSpecification =
        Namespaced_IRI.parse _namespace_name "hasDocumentSpecification" |> NamespacedName

    /// <summary>
    /// Specification of document, that relates with a respective person
    /// <see href="https://w3id.org/loin#belongsToInformationContent"></see></summary>
    let belongsToInformationContent =
        Namespaced_IRI.parse _namespace_name "belongsToInformationContent" |> NamespacedName

    /// <summary>
    /// The document required by deliverer is for getting approval
    /// <see href="https://w3id.org/loin#Required_For_Approval"></see></summary>
    let Required_For_Approval =
        Namespaced_IRI.parse _namespace_name "Required_For_Approval" |> NamespacedName

    /// <summary>
    /// The document required by deliverer with supplement of information
    /// <see href="https://w3id.org/loin#Required_with_Supplement"></see></summary>
    let Required_with_Supplement =
        Namespaced_IRI.parse _namespace_name "Required_with_Supplement" |> NamespacedName

    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Semantic"></see></summary>
    let Semantic = Namespaced_IRI.parse _namespace_name "Semantic" |> NamespacedName

    /// <summary>
    /// Sending actor is a party for information delivery according to ISO 19650-1 (2018)
    /// <see href="https://w3id.org/loin#SendingActor"></see></summary>
    let SendingActor =
        Namespaced_IRI.parse _namespace_name "SendingActor" |> NamespacedName

    /// <summary>
    /// Documents such as test certificates, insurance policies, delivery notes according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Signed_Document"></see></summary>
    let Signed_Document =
        Namespaced_IRI.parse _namespace_name "Signed_Document" |> NamespacedName

    /// <summary>
    /// Simple value restriction specifies the exact allowed value. In this ontology, it is defined as a restriction type, which specifies the restriction formulation.
    /// <see href="https://w3id.org/loin#SimpleValue"></see></summary>
    let SimpleValue =
        Namespaced_IRI.parse _namespace_name "SimpleValue" |> NamespacedName

    /// <summary>
    /// An example of breakdown structure type according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Spatial"></see></summary>
    let Spatial = Namespaced_IRI.parse _namespace_name "Spatial" |> NamespacedName

    /// <summary>
    /// Documents such as technical specifications according to notes according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#Specification"></see></summary>
    let Specification =
        Namespaced_IRI.parse _namespace_name "Specification" |> NamespacedName

    /// <summary>
    /// SpecificationPerObjectType is a contextual aspect according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#SpecificationPerObjectType"></see></summary>
    let SpecificationPerObjectType =
        Namespaced_IRI.parse _namespace_name "SpecificationPerObjectType" |> NamespacedName

    /// <summary>
    /// The object property relates the documentation with a LOIN object according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasDocumentation"></see></summary>
    let hasDocumentation =
        Namespaced_IRI.parse _namespace_name "hasDocumentation" |> NamespacedName

    /// <summary>
    /// The object property relates the geometrical information with a LOIN object according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasGeometricalInformation"></see></summary>
    let hasGeometricalInformation =
        Namespaced_IRI.parse _namespace_name "hasGeometricalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/loin#hasObjectType"></see>
    /// </summary>
    let hasObjectType =
        Namespaced_IRI.parse _namespace_name "hasObjectType" |> NamespacedName

    /// <summary>
    /// The object property relates an alphanumerical information with a LOIN object according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasAlphanumericalInformation"></see></summary>
    let hasAlphanumericalInformation =
        Namespaced_IRI.parse _namespace_name "hasAlphanumericalInformation" |> NamespacedName

    /// <summary>
    /// Type name, an identifier type in a breakdown structure according to notes of BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#TypeName"></see></summary>
    let TypeName = Namespaced_IRI.parse _namespace_name "TypeName" |> NamespacedName

    /// <summary>
    /// The document required by deliverer should be used as template
    /// <see href="https://w3id.org/loin#Used_As_Template"></see></summary>
    let Used_As_Template =
        Namespaced_IRI.parse _namespace_name "Used_As_Template" |> NamespacedName

    /// <summary>
    /// An example of location according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#absolute"></see></summary>
    let absolute = Namespaced_IRI.parse _namespace_name "absolute" |> NamespacedName

    /// <summary>
    /// An example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#constructive"></see></summary>
    let constructive =
        Namespaced_IRI.parse _namespace_name "constructive" |> NamespacedName

    /// <summary>
    /// coordination, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#coordination"></see></summary>
    let coordination =
        Namespaced_IRI.parse _namespace_name "coordination" |> NamespacedName

    /// <summary>
    /// Cost estimation, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#costEstimation"></see></summary>
    let costEstimation =
        Namespaced_IRI.parse _namespace_name "costEstimation" |> NamespacedName

    /// <summary>
    /// Detail, an example of detail aspect according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#detailed"></see></summary>
    let detailed = Namespaced_IRI.parse _namespace_name "detailed" |> NamespacedName

    /// <summary>
    /// Detailed design, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#detailedDesign"></see></summary>
    let detailedDesign =
        Namespaced_IRI.parse _namespace_name "detailedDesign" |> NamespacedName

    /// <summary>
    /// Explicit, an example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#explicit"></see></summary>
    let explicit = Namespaced_IRI.parse _namespace_name "explicit" |> NamespacedName

    /// <summary>
    /// Final design, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#finalDesign"></see></summary>
    let finalDesign =
        Namespaced_IRI.parse _namespace_name "finalDesign" |> NamespacedName

    /// <summary>
    /// Fire and smoke simulation, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#fireSmokeSimulation"></see></summary>
    let fireSmokeSimulation =
        Namespaced_IRI.parse _namespace_name "fireSmokeSimulation" |> NamespacedName

    /// <summary>
    /// Information of the information delivery actor defined by foaf ontology mit class foaf:Agent
    /// <see href="https://w3id.org/loin#hasAgent"></see></summary>
    let hasAgent = Namespaced_IRI.parse _namespace_name "hasAgent" |> NamespacedName

    /// <summary>
    /// Proxy property for the three information specification relationships
    /// <see href="https://w3id.org/loin#hasInformation"></see></summary>
    let hasInformation =
        Namespaced_IRI.parse _namespace_name "hasInformation" |> NamespacedName

    /// <summary>
    /// The object property relates a specific type with the breakdown structure according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasBreakdownStructureType"></see></summary>
    let hasBreakdownStructureType =
        Namespaced_IRI.parse _namespace_name "hasBreakdownStructureType" |> NamespacedName

    /// <summary>
    /// The object property relates the identification of a breakdown structure with an alphanumerical information according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasIdentification"></see></summary>
    let hasIdentification =
        Namespaced_IRI.parse _namespace_name "hasIdentification" |> NamespacedName

    /// <summary>
    /// The object property relates the detailed content with alphanumerical information according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#hasInformationContent"></see></summary>
    let hasInformationContent =
        Namespaced_IRI.parse _namespace_name "hasInformationContent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/loin#hasReferenceSource"></see>
    /// </summary>
    let hasReferenceSource =
        Namespaced_IRI.parse _namespace_name "hasReferenceSource" |> NamespacedName

    /// <summary>
    /// relates the requirement type with the defined requirements in IDS data definition
    /// <see href="https://w3id.org/loin#hasRequirementType"></see></summary>
    let hasRequirementType =
        Namespaced_IRI.parse _namespace_name "hasRequirementType" |> NamespacedName

    /// <summary>
    /// The object property relates the alphanumerical information content with document according to BS EN 17412-1(2020)
    /// <see href="https://w3id.org/loin#isRelatedToLoinDocument"></see></summary>
    let isRelatedToLoinDocument =
        Namespaced_IRI.parse _namespace_name "isRelatedToLoinDocument" |> NamespacedName

    /// <summary>
    /// one-dimensional, an example of dimensionality according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#one-dimensional"></see></summary>
    let ``one-dimensional`` =
        Namespaced_IRI.parse _namespace_name "one-dimensional" |> NamespacedName

    /// <summary>
    /// Parametric, an example of parametric behaviour according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#parametric"></see></summary>
    let parametric = Namespaced_IRI.parse _namespace_name "parametric" |> NamespacedName

    /// <summary>
    /// Preliminary design, an example of IDM information delivery milestone from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#preliminaryDesign"></see></summary>
    let preliminaryDesign =
        Namespaced_IRI.parse _namespace_name "preliminaryDesign" |> NamespacedName

    /// <summary>
    /// Real-world, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#real-world"></see></summary>
    let ``real-world`` =
        Namespaced_IRI.parse _namespace_name "real-world" |> NamespacedName

    /// <summary>
    /// realistic, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#realistic"></see></summary>
    let realistic = Namespaced_IRI.parse _namespace_name "realistic" |> NamespacedName
    /// <summary>
    /// Relative, an example of location according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#relative"></see></summary>
    let relative = Namespaced_IRI.parse _namespace_name "relative" |> NamespacedName
    /// <summary>
    /// simplified, an example of detail according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#simplified"></see></summary>
    let simplified = Namespaced_IRI.parse _namespace_name "simplified" |> NamespacedName

    /// <summary>
    /// Structural analysis, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#structuralAnalysis"></see></summary>
    let structuralAnalysis =
        Namespaced_IRI.parse _namespace_name "structuralAnalysis" |> NamespacedName

    /// <summary>
    /// symbolic, an example of appearance according to notes of geometrical information specification for information need in BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#symbolic"></see></summary>
    let symbolic = Namespaced_IRI.parse _namespace_name "symbolic" |> NamespacedName

    /// <summary>
    /// Three-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#three-dimensional"></see></summary>
    let ``three-dimensional`` =
        Namespaced_IRI.parse _namespace_name "three-dimensional" |> NamespacedName

    /// <summary>
    /// Two-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#two-dimensional"></see></summary>
    let ``two-dimensional`` =
        Namespaced_IRI.parse _namespace_name "two-dimensional" |> NamespacedName

    /// <summary>
    /// Visualization, an example of IDM purpose from BS EN 17412-1 (2020) - Annex B
    /// <see href="https://w3id.org/loin#visualization"></see></summary>
    let visualization =
        Namespaced_IRI.parse _namespace_name "visualization" |> NamespacedName

    /// <summary>
    /// zero-dimensional, an example of dimensionality from a geometrical information specification for information need according to BS EN 17412-1 (2020)
    /// <see href="https://w3id.org/loin#zero-dimensional"></see></summary>
    let ``zero-dimensional`` =
        Namespaced_IRI.parse _namespace_name "zero-dimensional" |> NamespacedName
