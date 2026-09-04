#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module loin =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/loin#" "loin"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Actor^^xsd:string</para>
    ///   <para>rdfs:comment : Actor is a contextual aspect according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Actor">loin:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Alphanumerical information</para>
    ///   <para>rdfs:comment : Alphanumerical information is a term for specifying the information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#AlphanumericalInformation">loin:AlphanumericalInformation</a>
    /// </summary>
    let AlphanumericalInformation = _prefixId.prefix "AlphanumericalInformation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Appearance</para>
    ///   <para>rdfs:comment : Appearance as a geometrical information specification for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Appearance">loin:Appearance</a>
    /// </summary>
    let Appearance = _prefixId.prefix "Appearance"
    let Bounds = _prefixId.prefix "Bounds"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Breakdown structure</para>
    ///   <para>rdfs:comment : Breakdown structure is a term for positioning the object in a structure according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#BreakdownStructure">loin:BreakdownStructure</a>
    /// </summary>
    let BreakdownStructure = _prefixId.prefix "BreakdownStructure"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Breakdown structure type</para>
    ///   <para>rdfs:comment : Breakdown structure type is a term to specify the structure according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#BreakdownStructureType">loin:BreakdownStructureType</a>
    /// </summary>
    let BreakdownStructureType = _prefixId.prefix "BreakdownStructureType"
    let ClassificationSystem = _prefixId.prefix "ClassificationSystem"
    let Codification = _prefixId.prefix "Codification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Detail</para>
    ///   <para>rdfs:comment : Detail as a geometrical information specification for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Detail">loin:Detail</a>
    /// </summary>
    let Detail = _prefixId.prefix "Detail"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Dimensionality</para>
    ///   <para>rdfs:comment : Dimensionality as a geometrical information specification for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Dimensionality">loin:Dimensionality</a>
    /// </summary>
    let Dimensionality = _prefixId.prefix "Dimensionality"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Document content</para>
    ///   <para>rdfs:comment : Document specification for content for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#DocumentContent">loin:DocumentContent</a>
    /// </summary>
    let DocumentContent = _prefixId.prefix "DocumentContent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Document format</para>
    ///   <para>rdfs:comment : Document specification for format for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#DocumentFormat">loin:DocumentFormat</a>
    /// </summary>
    let DocumentFormat = _prefixId.prefix "DocumentFormat"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Document purpose</para>
    ///   <para>rdfs:comment : Document purpose is a extension according to BS EN 17412-1 (2020) 6.4 Document - Example 1. It specifies the use of document</para>
    ///   <a href="https://w3id.org/loin#DocumentPurpose">loin:DocumentPurpose</a>
    /// </summary>
    let DocumentPurpose = _prefixId.prefix "DocumentPurpose"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Document specification</para>
    ///   <para>rdfs:comment : Additional specification of document for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#DocumentSpecification">loin:DocumentSpecification</a>
    /// </summary>
    let DocumentSpecification = _prefixId.prefix "DocumentSpecification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Documentation</para>
    ///   <para>rdfs:comment : Documentation is a term for specifying the information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Documentation">loin:Documentation</a>
    /// </summary>
    let Documentation = _prefixId.prefix "Documentation"
    let EngineeringPrinciple = _prefixId.prefix "EngineeringPrinciple"
    let Enumeration = _prefixId.prefix "Enumeration"
    let FederationStrategy = _prefixId.prefix "FederationStrategy"
    let Functional = _prefixId.prefix "Functional"
    /// <summary>
    ///   <para>rdfs:comment : Geometrical information is a term for specifying the information need according to BS EN 17412-1 (2020)</para>
    ///   <para>rdfs:label : Geometrical information</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://w3id.org/loin#GeometricalInformation">loin:GeometricalInformation</a>
    /// </summary>
    let GeometricalInformation = _prefixId.prefix "GeometricalInformation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Geometrical information specification</para>
    ///   <para>rdfs:comment : Additional specification of geometrical information for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#GeometrySpecification">loin:GeometrySpecification</a>
    /// </summary>
    let GeometrySpecification = _prefixId.prefix "GeometrySpecification"
    let Handdrawn_Sketches = _prefixId.prefix "Handdrawn_Sketches"
    let Hard_Copy = _prefixId.prefix "Hard_Copy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Identification</para>
    ///   <para>rdfs:comment : Identification is a term for positioning the object in a breakdown structure according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Identification">loin:Identification</a>
    /// </summary>
    let Identification = _prefixId.prefix "Identification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Identifier</para>
    ///   <para>rdfs:comment : Identifier is used to assiging a vaule for positioning the object in a breakdown structure according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Identifier">loin:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Identifier type</para>
    ///   <para>rdfs:comment : Identifier type is used to specify the identifier in a breakdown structure according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#IdentifierType">loin:IdentifierType</a>
    /// </summary>
    let IdentifierType = _prefixId.prefix "IdentifierType"
    let Index = _prefixId.prefix "Index"
    /// <summary>
    ///   <para>rdfs:label : Information</para>
    ///   <para>rdfs:comment : Proxy class for the three information specifications Alphanumerical Information, Geometrical Information, and Documentation</para>
    ///   <a href="https://w3id.org/loin#Information">loin:Information</a>
    /// </summary>
    let Information = _prefixId.prefix "Information"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Alphanumerical information content</para>
    ///   <para>rdfs:comment : Alphanumerical information content is a term for specifying the alphanumerical information according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#InformationContent">loin:InformationContent</a>
    /// </summary>
    let InformationContent = _prefixId.prefix "InformationContent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Information delivery milestone</para>
    ///   <para>rdfs:comment : Information delivery milestone is a contextual aspect according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#InformationDeliveryMilestone">loin:InformationDeliveryMilestone</a>
    /// </summary>
    let InformationDeliveryMilestone = _prefixId.prefix "InformationDeliveryMilestone"
    let Length = _prefixId.prefix "Length"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : Location as a geometrical information specification for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Location">loin:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    let Manual = _prefixId.prefix "Manual"
    let Name = _prefixId.prefix "Name"
    let NotRequested = _prefixId.prefix "NotRequested"
    let Numbering = _prefixId.prefix "Numbering"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ontology data definition</para>
    ///   <para>rdfs:comment : Ontology data definition is an extension of BS EN 17412-1 (2020). It is used to specify the alphanumerical information according to a published or customized ontology</para>
    ///   <a href="https://w3id.org/loin#OntologyDataDefinition">loin:OntologyDataDefinition</a>
    /// </summary>
    let OntologyDataDefinition = _prefixId.prefix "OntologyDataDefinition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Parametric behaviour</para>
    ///   <para>rdfs:comment : Parametric behaviour as a geometrical information specification for information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#ParametricBehaviour">loin:ParametricBehaviour</a>
    /// </summary>
    let ParametricBehaviour = _prefixId.prefix "ParametricBehaviour"
    let Pattern = _prefixId.prefix "Pattern"
    let Photograph = _prefixId.prefix "Photograph"
    let Provided_As_Information = _prefixId.prefix "Provided_As_Information"
    /// <summary>
    ///   <para>rdfs:label : Purpose^^xsd:string</para>
    ///   <para>rdfs:comment : Purpose is a contextual aspect according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#Purpose">loin:Purpose</a>
    /// </summary>
    let Purpose = _prefixId.prefix "Purpose"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Receiving actor</para>
    ///   <para>rdfs:comment : Receiving actor is a party for information delivery according to ISO 19650-1 (2018)</para>
    ///   <a href="https://w3id.org/loin#ReceivingActor">loin:ReceivingActor</a>
    /// </summary>
    let ReceivingActor = _prefixId.prefix "ReceivingActor"
    let ReferenceOfStructure = _prefixId.prefix "ReferenceOfStructure"
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : Document</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Document is a term for specifying the documentation of information need according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#RequiredDocument">loin:RequiredDocument</a>
    /// </summary>
    let RequiredDocument = _prefixId.prefix "RequiredDocument"
    let Required_For_Approval = _prefixId.prefix "Required_For_Approval"
    let Required_with_Supplement = _prefixId.prefix "Required_with_Supplement"
    let Semantic = _prefixId.prefix "Semantic"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Sending actor</para>
    ///   <para>rdfs:comment : Sending actor is a party for information delivery according to ISO 19650-1 (2018)</para>
    ///   <a href="https://w3id.org/loin#SendingActor">loin:SendingActor</a>
    /// </summary>
    let SendingActor = _prefixId.prefix "SendingActor"
    let Signed_Document = _prefixId.prefix "Signed_Document"
    let SimpleValue = _prefixId.prefix "SimpleValue"
    let Spatial = _prefixId.prefix "Spatial"
    let Specification = _prefixId.prefix "Specification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Specification per Object Type</para>
    ///   <para>rdfs:comment : SpecificationPerObjectType is a contextual aspect according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#SpecificationPerObjectType">loin:SpecificationPerObjectType</a>
    /// </summary>
    let SpecificationPerObjectType = _prefixId.prefix "SpecificationPerObjectType"
    let TypeName = _prefixId.prefix "TypeName"
    let Used_As_Template = _prefixId.prefix "Used_As_Template"
    let absolute = _prefixId.prefix "absolute"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : belongs to information content</para>
    ///   <para>rdfs:comment : Specification of document, that relates with a respective person</para>
    ///   <a href="https://w3id.org/loin#belongsToInformationContent">loin:belongsToInformationContent</a>
    /// </summary>
    let belongsToInformationContent = _prefixId.prefix "belongsToInformationContent"
    let constructive = _prefixId.prefix "constructive"
    let coordination = _prefixId.prefix "coordination"
    let costEstimation = _prefixId.prefix "costEstimation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : Description provide detail and extend of information derived by Information Delivery Specification (IDS)</para>
    ///   <a href="https://w3id.org/loin#description">loin:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    let detailed = _prefixId.prefix "detailed"
    let detailedDesign = _prefixId.prefix "detailedDesign"
    let explicit = _prefixId.prefix "explicit"
    let finalDesign = _prefixId.prefix "finalDesign"
    let fireSmokeSimulation = _prefixId.prefix "fireSmokeSimulation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has agent</para>
    ///   <para>rdfs:comment : Information of the information delivery actor defined by foaf ontology mit class foaf:Agent</para>
    ///   <a href="https://w3id.org/loin#hasAgent">loin:hasAgent</a>
    /// </summary>
    let hasAgent = _prefixId.prefix "hasAgent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has alphanumerical information</para>
    ///   <para>rdfs:comment : The object property relates an alphanumerical information with a LOIN object according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasAlphanumericalInformation">loin:hasAlphanumericalInformation</a>
    /// </summary>
    let hasAlphanumericalInformation = _prefixId.prefix "hasAlphanumericalInformation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has breakdown structure</para>
    ///   <para>rdfs:comment : The object property relates the identification with a breakdown structure according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasBreakdownStructure">loin:hasBreakdownStructure</a>
    /// </summary>
    let hasBreakdownStructure = _prefixId.prefix "hasBreakdownStructure"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has breakdown structure type</para>
    ///   <para>rdfs:comment : The object property relates a specific type with the breakdown structure according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasBreakdownStructureType">loin:hasBreakdownStructureType</a>
    /// </summary>
    let hasBreakdownStructureType = _prefixId.prefix "hasBreakdownStructureType"
    /// <summary>
    ///   <para>rdfs:label : has data template^^xsd:string</para>
    ///   <a href="https://w3id.org/loin#hasDataTemplate">loin:hasDataTemplate</a>
    /// </summary>
    let hasDataTemplate = _prefixId.prefix "hasDataTemplate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has document</para>
    ///   <para>rdfs:comment : The object property relates a set of documents with documentation according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasDocument">loin:hasDocument</a>
    /// </summary>
    let hasDocument = _prefixId.prefix "hasDocument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has documentaton specification</para>
    ///   <para>rdfs:comment : The object property relates the document specifications with a document according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasDocumentSpecification">loin:hasDocumentSpecification</a>
    /// </summary>
    let hasDocumentSpecification = _prefixId.prefix "hasDocumentSpecification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has documentation</para>
    ///   <para>rdfs:comment : The object property relates the documentation with a LOIN object according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasDocumentation">loin:hasDocumentation</a>
    /// </summary>
    let hasDocumentation = _prefixId.prefix "hasDocumentation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has geometrical information</para>
    ///   <para>rdfs:comment : The object property relates the geometrical information with a LOIN object according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasGeometricalInformation">loin:hasGeometricalInformation</a>
    /// </summary>
    let hasGeometricalInformation = _prefixId.prefix "hasGeometricalInformation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has geometrical information specification</para>
    ///   <para>rdfs:comment : The object property relates the specific aspects with geometrical information according to BS EN 17412-1 (2020)rdfs:comment : ["Appearance",
    /// "Detail",
    /// "Dimensionality",
    /// "Location",
    /// "ParametricBehaviour"]^^xsd:string</para>
    ///   <a href="https://w3id.org/loin#hasGeometrySpecification">loin:hasGeometrySpecification</a>
    /// </summary>
    let hasGeometrySpecification = _prefixId.prefix "hasGeometrySpecification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has identification</para>
    ///   <para>rdfs:comment : The object property relates the identification of a breakdown structure with an alphanumerical information according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasIdentification">loin:hasIdentification</a>
    /// </summary>
    let hasIdentification = _prefixId.prefix "hasIdentification"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has identifier</para>
    ///   <para>rdfs:comment : The object property relates a breakdown structure with its identifier according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasIdentifier">loin:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has identifier type</para>
    ///   <para>rdfs:comment : The object property relates an identifier of breakdown structure with a specific type according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasIdentifierType">loin:hasIdentifierType</a>
    /// </summary>
    let hasIdentifierType = _prefixId.prefix "hasIdentifierType"
    /// <summary>
    ///   <para>rdfs:label : has information</para>
    ///   <para>rdfs:comment : Proxy property for the three information specification relationships</para>
    ///   <a href="https://w3id.org/loin#hasInformation">loin:hasInformation</a>
    /// </summary>
    let hasInformation = _prefixId.prefix "hasInformation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has alphanumerical informaton content</para>
    ///   <para>rdfs:comment : The object property relates the detailed content with alphanumerical information according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasInformationContent">loin:hasInformationContent</a>
    /// </summary>
    let hasInformationContent = _prefixId.prefix "hasInformationContent"
    /// <summary>
    ///   <para>rdfs:label : has object type^^xsd:string</para>
    ///   <a href="https://w3id.org/loin#hasObjectType">loin:hasObjectType</a>
    /// </summary>
    let hasObjectType = _prefixId.prefix "hasObjectType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has purpose</para>
    ///   <para>rdfs:comment : The object property relates the purpose with the information delivery milestone according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasPurpose">loin:hasPurpose</a>
    /// </summary>
    let hasPurpose = _prefixId.prefix "hasPurpose"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has receiving actor</para>
    ///   <para>rdfs:comment : The object property relates the receiver actor with the information delivery milestone according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasReceivingActor">loin:hasReceivingActor</a>
    /// </summary>
    let hasReceivingActor = _prefixId.prefix "hasReceivingActor"
    /// <summary>
    ///   <para>rdfs:label : has reference source</para>
    ///   <a href="https://w3id.org/loin#hasReferenceSource">loin:hasReferenceSource</a>
    /// </summary>
    let hasReferenceSource = _prefixId.prefix "hasReferenceSource"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has requirement type</para>
    ///   <para>rdfs:comment : relates the requirement type with the defined requirements in IDS data definition</para>
    ///   <a href="https://w3id.org/loin#hasRequirementType">loin:hasRequirementType</a>
    /// </summary>
    let hasRequirementType = _prefixId.prefix "hasRequirementType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has has Sending Actor</para>
    ///   <para>rdfs:comment : The object property relates the sending actor with the information delivery milestone according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasSendingActor">loin:hasSendingActor</a>
    /// </summary>
    let hasSendingActor = _prefixId.prefix "hasSendingActor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has specification per object type</para>
    ///   <para>rdfs:comment : The specification per object type property relates the object type specifications with the information delivery milestone according to BS EN 17412-1 (2020)</para>
    ///   <a href="https://w3id.org/loin#hasSpecificationPerObjectType">loin:hasSpecificationPerObjectType</a>
    /// </summary>
    let hasSpecificationPerObjectType = _prefixId.prefix "hasSpecificationPerObjectType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : is related to Loin document^^xsd:string</para>
    ///   <para>rdfs:comment : The object property relates the alphanumerical information content with document according to BS EN 17412-1(2020)</para>
    ///   <a href="https://w3id.org/loin#isRelatedToLoinDocument">loin:isRelatedToLoinDocument</a>
    /// </summary>
    let isRelatedToLoinDocument = _prefixId.prefix "isRelatedToLoinDocument"
    let one_dimensional = _prefixId.prefix "one-dimensional"
    let parametric = _prefixId.prefix "parametric"
    let preliminaryDesign = _prefixId.prefix "preliminaryDesign"
    let real_world = _prefixId.prefix "real-world"
    let realistic = _prefixId.prefix "realistic"
    let relative = _prefixId.prefix "relative"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : requested as boolean, specifys if Geometrical information is needed according to BS EN 17412-1 (2020)rdfs:label : requested^^xsd:string</para>
    ///   <a href="https://w3id.org/loin#requested">loin:requested</a>
    /// </summary>
    let requested = _prefixId.prefix "requested"
    let simplified = _prefixId.prefix "simplified"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : specified by identifier^^xsd:string</para>
    ///   <a href="https://w3id.org/loin#specifiedByIdentifier">loin:specifiedByIdentifier</a>
    /// </summary>
    let specifiedByIdentifier = _prefixId.prefix "specifiedByIdentifier"
    let structuralAnalysis = _prefixId.prefix "structuralAnalysis"
    let symbolic = _prefixId.prefix "symbolic"
    let three_dimensional = _prefixId.prefix "three-dimensional"
    let two_dimensional = _prefixId.prefix "two-dimensional"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : value</para>
    ///   <para>rdfs:comment : value for general definition</para>
    ///   <a href="https://w3id.org/loin#value">loin:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    let visualization = _prefixId.prefix "visualization"
    let zero_dimensional = _prefixId.prefix "zero-dimensional"
