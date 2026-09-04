#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module aml =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/i40/aml#" "aml"
    let _namespaceIri = _prefixId.prefix ""
    let AILevelSW = _prefixId.prefix "AILevelSW"
    /// <summary>
    ///   <para>skos:prefLabel : AdditionalInformation</para>
    ///   <para>skos:definition : Additional Information for CAEX File</para>
    ///   <a href="https://w3id.org/i40/aml#AdditionalInformation">aml:AdditionalInformation</a>
    /// </summary>
    let AdditionalInformation = _prefixId.prefix "AdditionalInformation"
    let AdditionalInformation1 = _prefixId.prefix "AdditionalInformation1"
    let AttValue1 = _prefixId.prefix "AttValue1"
    /// <summary>
    ///   <para>skos:prefLabel : Attribute</para>
    ///   <para>skos:definition : Property which belongs to an AML object</para>
    ///   <para>rdfs:isDefinedBy : 1417686950-AutomationML Whitepaper Part 1 - AutomationML Architecture v2_Oct2014, page 11^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/aml#Attribute">aml:Attribute</a>
    /// </summary>
    let Attribute = _prefixId.prefix "Attribute"
    /// <summary>
    ///   <para>skos:prefLabel : CAEXFile</para>
    ///   <para>skos:definition : Root-element of the CAEX schema</para>
    ///   <a href="https://w3id.org/i40/aml#CAEXFile">aml:CAEXFile</a>
    /// </summary>
    let CAEXFile = _prefixId.prefix "CAEXFile"
    let DemoArea = _prefixId.prefix "DemoArea"
    let DemoEnterprise = _prefixId.prefix "DemoEnterprise"
    let DemoSite = _prefixId.prefix "DemoSite"
    let ExampleInstanceHierarchy = _prefixId.prefix "ExampleInstanceHierarchy"
    /// <summary>
    ///   <para>skos:prefLabel : ExternalInterface</para>
    ///   <para>skos:altLabel : EI</para>
    ///   <a href="https://w3id.org/i40/aml#ExternalInterface">aml:ExternalInterface</a>
    /// </summary>
    let ExternalInterface = _prefixId.prefix "ExternalInterface"
    /// <summary>
    ///   <para>skos:prefLabel : ExternalReference</para>
    ///   <para>skos:definition : External Reference for a CAEX File</para>
    ///   <a href="https://w3id.org/i40/aml#ExternalReference">aml:ExternalReference</a>
    /// </summary>
    let ExternalReference = _prefixId.prefix "ExternalReference"
    /// <summary>
    ///   <para>skos:prefLabel : ExternalStandard</para>
    ///   <para>skos:definition : Represents an External Standard which is used to provide unique Semantic reference for AML elements, e.g., eClass</para>
    ///   <a href="https://w3id.org/i40/aml#ExternalStandard">aml:ExternalStandard</a>
    /// </summary>
    let ExternalStandard = _prefixId.prefix "ExternalStandard"
    let FlowchartNumber = _prefixId.prefix "FlowchartNumber"

    let ``GMA6.16BeispielPIDVersion2.97`` =
        _prefixId.prefix "GMA6.16BeispielPIDVersion2.97"

    /// <summary>
    ///   <para>skos:prefLabel : InstanceHierarchy</para>
    ///   <para>skos:definition : Describes the are to model the data to be exchanged. CAEX InstanceHierarchies serve for the storage of individual and project related engineering information. They form the centre of the AML top-level format and contain all individual data objects including properties, interfaces, relations and references.</para>
    ///   <para>skos:altLabel : IH</para>
    ///   <a href="https://w3id.org/i40/aml#InstanceHierarchy">aml:InstanceHierarchy</a>
    /// </summary>
    let InstanceHierarchy = _prefixId.prefix "InstanceHierarchy"
    /// <summary>
    ///   <para>skos:prefLabel : InterfaceClass</para>
    ///   <para>skos:definition : Defines the relations between AML Objects. Should be identified with its tag name</para>
    ///   <para>skos:altLabel : IC</para>
    ///   <a href="https://w3id.org/i40/aml#InterfaceClass">aml:InterfaceClass</a>
    /// </summary>
    let InterfaceClass = _prefixId.prefix "InterfaceClass"
    /// <summary>
    ///   <para>skos:prefLabel : InterfaceClassLib</para>
    ///   <para>skos:definition : Library containing AML Interface Classes</para>
    ///   <para>skos:altLabel : IC Lib</para>
    ///   <a href="https://w3id.org/i40/aml#InterfaceClassLib">aml:InterfaceClassLib</a>
    /// </summary>
    let InterfaceClassLib = _prefixId.prefix "InterfaceClassLib"
    /// <summary>
    ///   <para>skos:prefLabel : InternalElement</para>
    ///   <para>skos:definition : Shall be used in order to define nested objects inside of a SystemUnitClass or another InternalElement. Allows description of the internal structure of an CAEX object</para>
    ///   <para>skos:altLabel : IE</para>
    ///   <a href="https://w3id.org/i40/aml#InternalElement">aml:InternalElement</a>
    /// </summary>
    let InternalElement = _prefixId.prefix "InternalElement"
    /// <summary>
    ///   <para>skos:prefLabel : InternalLink</para>
    ///   <para>skos:definition : Connects two CAEX elements like InternalElements</para>
    ///   <para>skos:altLabel : IL</para>
    ///   <a href="https://w3id.org/i40/aml#InternalLink">aml:InternalLink</a>
    /// </summary>
    let InternalLink = _prefixId.prefix "InternalLink"
    let L1001 = _prefixId.prefix "L1001"
    let LIRCS1 = _prefixId.prefix "LIRCS1"
    let MaxConveyingSpeed = _prefixId.prefix "MaxConveyingSpeed"
    let MeasurementRangeEnd = _prefixId.prefix "MeasurementRangeEnd"
    let MeasurementRangeStart = _prefixId.prefix "MeasurementRangeStart"
    let NE150DemoProject = _prefixId.prefix "NE150DemoProject"
    let OldPCE = _prefixId.prefix "OldPCE"
    let PCEDescription = _prefixId.prefix "PCEDescription"
    let PCEFunction = _prefixId.prefix "PCEFunction"
    let PCEInitial = _prefixId.prefix "PCEInitial"
    /// <summary>
    ///   <para>skos:prefLabel : Project</para>
    ///   <para>skos:definition : A Project related to the header information with the CAEX File</para>
    ///   <a href="https://w3id.org/i40/aml#Project">aml:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>skos:prefLabel : RoleClass</para>
    ///   <para>skos:definition : RoleClasses are vendor independent and generic entities. They are used to assign a generic semantics to an object instance and to describe requirements of this object instance. Also, they can help in mapping data models of different engineering tools.</para>
    ///   <para>skos:altLabel : RC</para>
    ///   <a href="https://w3id.org/i40/aml#RoleClass">aml:RoleClass</a>
    /// </summary>
    let RoleClass = _prefixId.prefix "RoleClass"
    /// <summary>
    ///   <para>skos:prefLabel : RoleClassLib</para>
    ///   <para>skos:definition : Provides definitions of abstract characteristics of CAEX objects and thus serve the automatic semantic interpretation of user-defined AML objects</para>
    ///   <para>skos:altLabel : RCL</para>
    ///   <a href="https://w3id.org/i40/aml#RoleClassLib">aml:RoleClassLib</a>
    /// </summary>
    let RoleClassLib = _prefixId.prefix "RoleClassLib"
    let SoftwareSignalName = _prefixId.prefix "SoftwareSignalName"
    /// <summary>
    ///   <para>skos:prefLabel : SystemUnitClass</para>
    ///   <para>skos:definition : Describe concrete types of objects reused within engineering. Allows for different user-defined classes. Inheritance between a SystemUnitClass and an object instance is not allowed.</para>
    ///   <para>skos:altLabel : SUC</para>
    ///   <a href="https://w3id.org/i40/aml#SystemUnitClass">aml:SystemUnitClass</a>
    /// </summary>
    let SystemUnitClass = _prefixId.prefix "SystemUnitClass"
    /// <summary>
    ///   <para>skos:prefLabel : SystemUnitClassLib</para>
    ///   <para>skos:definition : Store vendor specific AML classes</para>
    ///   <para>skos:altLabel : SUC Lib</para>
    ///   <a href="https://w3id.org/i40/aml#SystemUnitClassLib">aml:SystemUnitClassLib</a>
    /// </summary>
    let SystemUnitClassLib = _prefixId.prefix "SystemUnitClassLib"
    /// <summary>
    ///   <para>skos:prefLabel : contains</para>
    ///   <para>skos:definition : Superproperty to describe the connection of the CAEX file with the main CAEX library elements, e.g., InterfaceClassLib, RoleClassLib, and SystemUnitClassLib</para>
    ///   <a href="https://w3id.org/i40/aml#contains">aml:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>skos:prefLabel : eClassSpecification</para>
    ///   <para>skos:definition : Describe the necessary links to eCl@ass Standard(e.g., version, classification and IRDI)</para>
    ///   <a href="https://w3id.org/i40/aml#eClassSpecification">aml:eClassSpecification</a>
    /// </summary>
    let eClassSpecification = _prefixId.prefix "eClassSpecification"
    /// <summary>
    ///   <para>skos:prefLabel : hasAMLVersion</para>
    ///   <a href="https://w3id.org/i40/aml#hasAMLVersion">aml:hasAMLVersion</a>
    /// </summary>
    let hasAMLVersion = _prefixId.prefix "hasAMLVersion"
    /// <summary>
    ///   <para>skos:prefLabel : hasAdditionalInformation</para>
    ///   <a href="https://w3id.org/i40/aml#hasAdditionalInformation">aml:hasAdditionalInformation</a>
    /// </summary>
    let hasAdditionalInformation = _prefixId.prefix "hasAdditionalInformation"
    /// <summary>
    ///   <para>skos:prefLabel : hasAttribute</para>
    ///   <a href="https://w3id.org/i40/aml#hasAttribute">aml:hasAttribute</a>
    /// </summary>
    let hasAttribute = _prefixId.prefix "hasAttribute"
    /// <summary>
    ///   <para>skos:prefLabel : hasDataType</para>
    ///   <a href="https://w3id.org/i40/aml#hasAttributeDataType">aml:hasAttributeDataType</a>
    /// </summary>
    let hasAttributeDataType = _prefixId.prefix "hasAttributeDataType"
    /// <summary>
    ///   <para>skos:prefLabel : hasDescription</para>
    ///   <para>skos:definition : Points to an optional description of the Attribute</para>
    ///   <a href="https://w3id.org/i40/aml#hasAttributeDescription">aml:hasAttributeDescription</a>
    /// </summary>
    let hasAttributeDescription = _prefixId.prefix "hasAttributeDescription"
    let hasAttributeIC = _prefixId.prefix "hasAttributeIC"
    let hasAttributeIE = _prefixId.prefix "hasAttributeIE"
    /// <summary>
    ///   <para>skos:prefLabel : hasAttributeName</para>
    ///   <a href="https://w3id.org/i40/aml#hasAttributeName">aml:hasAttributeName</a>
    /// </summary>
    let hasAttributeName = _prefixId.prefix "hasAttributeName"
    let hasAttributeRC = _prefixId.prefix "hasAttributeRC"
    let hasAttributeSUC = _prefixId.prefix "hasAttributeSUC"
    let hasAttributeValue = _prefixId.prefix "hasAttributeValue"
    let hasBaseSystemUnitClass = _prefixId.prefix "hasBaseSystemUnitClass"
    /// <summary>
    ///   <para>skos:prefLabel : eClassClassificationClass</para>
    ///   <para>skos:definition : Points to the eClass classification Class a given Element</para>
    ///   <a href="https://w3id.org/i40/aml#hasClassificationClass">aml:hasClassificationClass</a>
    /// </summary>
    let hasClassificationClass = _prefixId.prefix "hasClassificationClass"
    /// <summary>
    ///   <para>skos:prefLabel : hasExternalInterface</para>
    ///   <para>skos:definition : Connects the Internal Element with an External Interface</para>
    ///   <a href="https://w3id.org/i40/aml#hasExternalInterface">aml:hasExternalInterface</a>
    /// </summary>
    let hasExternalInterface = _prefixId.prefix "hasExternalInterface"
    /// <summary>
    ///   <para>skos:prefLabel : hasExternalReference</para>
    ///   <para>skos:definition : A CAEX File contains external references^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/aml#hasExternalReference">aml:hasExternalReference</a>
    /// </summary>
    let hasExternalReference = _prefixId.prefix "hasExternalReference"
    /// <summary>
    ///   <para>skos:prefLabel : externalReferenceAlias</para>
    ///   <para>skos:definition : A external Reference of a CAEX File has Alias^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/aml#hasExternalReferenceAlias">aml:hasExternalReferenceAlias</a>
    /// </summary>
    let hasExternalReferenceAlias = _prefixId.prefix "hasExternalReferenceAlias"
    /// <summary>
    ///   <para>skos:prefLabel : externalReferencePath</para>
    ///   <para>skos:definition : A external Reference of a CAEX File contains path to the file^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/aml#hasExternalReferencePath">aml:hasExternalReferencePath</a>
    /// </summary>
    let hasExternalReferencePath = _prefixId.prefix "hasExternalReferencePath"
    /// <summary>
    ///   <para>rdfs:comment : Unique ID for the Interface Class</para>
    ///   <a href="https://w3id.org/i40/aml#hasICID">aml:hasICID</a>
    /// </summary>
    let hasICID = _prefixId.prefix "hasICID"
    /// <summary>
    ///   <para>skos:prefLabel : internalElementId</para>
    ///   <para>skos:definition : Unique Id of an Internal Element</para>
    ///   <a href="https://w3id.org/i40/aml#hasIDIE">aml:hasIDIE</a>
    /// </summary>
    let hasIDIE = _prefixId.prefix "hasIDIE"
    /// <summary>
    ///   <para>skos:prefLabel : eClassIRDI</para>
    ///   <para>skos:definition : Points to the eClass unique identification(IRDI) a given Element</para>
    ///   <a href="https://w3id.org/i40/aml#hasIRDIeClass">aml:hasIRDIeClass</a>
    /// </summary>
    let hasIRDIeClass = _prefixId.prefix "hasIRDIeClass"
    /// <summary>
    ///   <para>skos:prefLabel : hasInstanceHierarchy</para>
    ///   <para>skos:definition : Points the CAEX file to the Instance Hierarchy</para>
    ///   <a href="https://w3id.org/i40/aml#hasInstanceHierarchy">aml:hasInstanceHierarchy</a>
    /// </summary>
    let hasInstanceHierarchy = _prefixId.prefix "hasInstanceHierarchy"
    let hasInterface = _prefixId.prefix "hasInterface"
    /// <summary>
    ///   <para>skos:prefLabel : hasInterfaceClass</para>
    ///   <para>skos:definition : Model the relation between Interface Class Lib and Interface Class</para>
    ///   <a href="https://w3id.org/i40/aml#hasInterfaceClass">aml:hasInterfaceClass</a>
    /// </summary>
    let hasInterfaceClass = _prefixId.prefix "hasInterfaceClass"
    /// <summary>
    ///   <para>skos:prefLabel : hasInterfaceClassLib</para>
    ///   <para>skos:definition : Points the CAEX file to the InterfaceClassLib</para>
    ///   <a href="https://w3id.org/i40/aml#hasInterfaceClassLib">aml:hasInterfaceClassLib</a>
    /// </summary>
    let hasInterfaceClassLib = _prefixId.prefix "hasInterfaceClassLib"
    let hasInterfaceIE = _prefixId.prefix "hasInterfaceIE"
    let hasInterfaceRC = _prefixId.prefix "hasInterfaceRC"
    let hasInterfaceSUC = _prefixId.prefix "hasInterfaceSUC"
    /// <summary>
    ///   <para>skos:prefLabel : hasInternalElement</para>
    ///   <para>skos:definition : Hierarchy has many internal elements</para>
    ///   <a href="https://w3id.org/i40/aml#hasInternalElement">aml:hasInternalElement</a>
    /// </summary>
    let hasInternalElement = _prefixId.prefix "hasInternalElement"
    let hasInternalLink = _prefixId.prefix "hasInternalLink"
    let hasName = _prefixId.prefix "hasName"
    let hasNameAttribute = _prefixId.prefix "hasNameAttribute"
    /// <summary>
    ///   <para>skos:prefLabel : hasNameFile^^xsd:string</para>
    ///   <para>skos:definition : The name of the main AutomationML File</para>
    ///   <a href="https://w3id.org/i40/aml#hasNameFile">aml:hasNameFile</a>
    /// </summary>
    let hasNameFile = _prefixId.prefix "hasNameFile"
    /// <summary>
    ///   <para>skos:prefLabel : hasNameIC</para>
    ///   <para>skos:definition : Name of the Interface Class</para>
    ///   <para>skos:altLabel : hasInterfaceClassName</para>
    ///   <a href="https://w3id.org/i40/aml#hasNameIC">aml:hasNameIC</a>
    /// </summary>
    let hasNameIC = _prefixId.prefix "hasNameIC"
    /// <summary>
    ///   <para>skos:prefLabel : hasNameIE</para>
    ///   <para>skos:definition : Name of an Internal Element</para>
    ///   <para>skos:altLabel : hasInternalElementName</para>
    ///   <a href="https://w3id.org/i40/aml#hasNameIE">aml:hasNameIE</a>
    /// </summary>
    let hasNameIE = _prefixId.prefix "hasNameIE"
    /// <summary>
    ///   <para>skos:prefLabel : hasNameIH</para>
    ///   <para>skos:definition : Given Name of the Instance Hierarchy</para>
    ///   <para>skos:altLabel : hasInstanceHierarchyName</para>
    ///   <a href="https://w3id.org/i40/aml#hasNameIH">aml:hasNameIH</a>
    /// </summary>
    let hasNameIH = _prefixId.prefix "hasNameIH"
    /// <summary>
    ///   <para>skos:prefLabel : hasNameRC</para>
    ///   <para>skos:definition : Name for a RoleClass</para>
    ///   <para>skos:altLabel : hasRoleClassName</para>
    ///   <a href="https://w3id.org/i40/aml#hasNameRC">aml:hasNameRC</a>
    /// </summary>
    let hasNameRC = _prefixId.prefix "hasNameRC"
    /// <summary>
    ///   <para>skos:prefLabel : hasNameSUC</para>
    ///   <para>skos:definition : Given Name of the System Unit Class</para>
    ///   <para>skos:altLabel : hasSystemUnitClassName</para>
    ///   <a href="https://w3id.org/i40/aml#hasNameSUC">aml:hasNameSUC</a>
    /// </summary>
    let hasNameSUC = _prefixId.prefix "hasNameSUC"
    /// <summary>
    ///   <para>skos:prefLabel : hasProject</para>
    ///   <para>skos:definition : Related Project for the CAEX File</para>
    ///   <a href="https://w3id.org/i40/aml#hasProject">aml:hasProject</a>
    /// </summary>
    let hasProject = _prefixId.prefix "hasProject"
    /// <summary>
    ///   <para>skos:prefLabel : hasProjectId</para>
    ///   <a href="https://w3id.org/i40/aml#hasProjectId">aml:hasProjectId</a>
    /// </summary>
    let hasProjectId = _prefixId.prefix "hasProjectId"
    /// <summary>
    ///   <para>skos:prefLabel : has Project Release^^xsd:stringskos:prefLabel : hasProjectTitle</para>
    ///   <a href="https://w3id.org/i40/aml#hasProjectTitle">aml:hasProjectTitle</a>
    /// </summary>
    let hasProjectTitle = _prefixId.prefix "hasProjectTitle"
    /// <summary>
    ///   <para>skos:prefLabel : refBaseClassPath</para>
    ///   <para>skos:definition : Stores the name of the parent class</para>
    ///   <a href="https://w3id.org/i40/aml#hasRefBaseClassPath">aml:hasRefBaseClassPath</a>
    /// </summary>
    let hasRefBaseClassPath = _prefixId.prefix "hasRefBaseClassPath"
    let hasRefBaseClassPathIC = _prefixId.prefix "hasRefBaseClassPathIC"
    let hasRefBaseClassPathRC = _prefixId.prefix "hasRefBaseClassPathRC"
    let hasRefBaseClassPathSUC = _prefixId.prefix "hasRefBaseClassPathSUC"
    let hasRefBaseRoleClassPath = _prefixId.prefix "hasRefBaseRoleClassPath"
    /// <summary>
    ///   <para>skos:prefLabel : refBaseSUPath</para>
    ///   <para>skos:altLabel : Ref Base System Unit Path</para>
    ///   <a href="https://w3id.org/i40/aml#hasRefBaseSystemUnitPath">aml:hasRefBaseSystemUnitPath</a>
    /// </summary>
    let hasRefBaseSystemUnitPath = _prefixId.prefix "hasRefBaseSystemUnitPath"
    /// <summary>
    ///   <para>skos:prefLabel : hasRefPartnerSideA</para>
    ///   <para>skos:definition : Reference an Internal Link with an element A</para>
    ///   <a href="https://w3id.org/i40/aml#hasRefPartnerSideA">aml:hasRefPartnerSideA</a>
    /// </summary>
    let hasRefPartnerSideA = _prefixId.prefix "hasRefPartnerSideA"
    /// <summary>
    ///   <para>skos:prefLabel : hasRefPartnerSideB</para>
    ///   <para>skos:definition : Reference an Internal Link with an element B</para>
    ///   <a href="https://w3id.org/i40/aml#hasRefPartnerSideB">aml:hasRefPartnerSideB</a>
    /// </summary>
    let hasRefPartnerSideB = _prefixId.prefix "hasRefPartnerSideB"
    /// <summary>
    ///   <para>skos:prefLabel : refRCPath</para>
    ///   <para>skos:altLabel : refRoleClassPath</para>
    ///   <a href="https://w3id.org/i40/aml#hasRefRoleClassPath">aml:hasRefRoleClassPath</a>
    /// </summary>
    let hasRefRoleClassPath = _prefixId.prefix "hasRefRoleClassPath"
    let hasRefSemAttribute = _prefixId.prefix "hasRefSemAttribute"
    /// <summary>
    ///   <para>skos:prefLabel : eClassRCReference^^xsd:string</para>
    ///   <para>skos:definition : A Role Class points to its ID according to eClass</para>
    ///   <para>skos:altLabel : RoleClasseClassReference</para>
    ///   <a href="https://w3id.org/i40/aml#hasRefSemRC">aml:hasRefSemRC</a>
    /// </summary>
    let hasRefSemRC = _prefixId.prefix "hasRefSemRC"
    /// <summary>
    ///   <para>skos:prefLabel : hasRoleClass</para>
    ///   <para>skos:definition : A Role Class lib contains a Role Class</para>
    ///   <a href="https://w3id.org/i40/aml#hasRoleClass">aml:hasRoleClass</a>
    /// </summary>
    let hasRoleClass = _prefixId.prefix "hasRoleClass"
    /// <summary>
    ///   <para>skos:prefLabel : hasRoleClassLib</para>
    ///   <para>skos:definition : Points the CAEX file to the RoleClassLib</para>
    ///   <a href="https://w3id.org/i40/aml#hasRoleClassLib">aml:hasRoleClassLib</a>
    /// </summary>
    let hasRoleClassLib = _prefixId.prefix "hasRoleClassLib"
    /// <summary>
    ///   <para>skos:prefLabel : hasRoleRequeriment</para>
    ///   <a href="https://w3id.org/i40/aml#hasRoleRequeriment">aml:hasRoleRequeriment</a>
    /// </summary>
    let hasRoleRequeriment = _prefixId.prefix "hasRoleRequeriment"
    let hasRoleRequirementIE = _prefixId.prefix "hasRoleRequirementIE"
    let hasRoleRequirementSUC = _prefixId.prefix "hasRoleRequirementSUC"
    /// <summary>
    ///   <para>skos:prefLabel : hasSchemaVersion^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/aml#hasSchemaVersion">aml:hasSchemaVersion</a>
    /// </summary>
    let hasSchemaVersion = _prefixId.prefix "hasSchemaVersion"
    /// <summary>
    ///   <para>skos:prefLabel : hasSemanticRef</para>
    ///   <para>skos:definition : General property which points to an external standard to provide semantic identification for a given element</para>
    ///   <a href="https://w3id.org/i40/aml#hasSemanticRef">aml:hasSemanticRef</a>
    /// </summary>
    let hasSemanticRef = _prefixId.prefix "hasSemanticRef"
    /// <summary>
    ///   <para>skos:prefLabel : supportedRoleClass</para>
    ///   <para>skos:definition : Internal elements has Supported Role Class</para>
    ///   <a href="https://w3id.org/i40/aml#hasSupportedRoleClass">aml:hasSupportedRoleClass</a>
    /// </summary>
    let hasSupportedRoleClass = _prefixId.prefix "hasSupportedRoleClass"
    let hasSupportedRoleClassIE = _prefixId.prefix "hasSupportedRoleClassIE"
    let hasSupportedRoleClassSUC = _prefixId.prefix "hasSupportedRoleClassSUC"
    /// <summary>
    ///   <para>skos:prefLabel : hasSystemUnitClass^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/aml#hasSystemUnitClass">aml:hasSystemUnitClass</a>
    /// </summary>
    let hasSystemUnitClass = _prefixId.prefix "hasSystemUnitClass"
    /// <summary>
    ///   <para>skos:prefLabel : hasInterfaceClassLib</para>
    ///   <para>skos:definition : Points the CAEX file to the SystemUnitClassLib</para>
    ///   <a href="https://w3id.org/i40/aml#hasSystemUnitClassLib">aml:hasSystemUnitClassLib</a>
    /// </summary>
    let hasSystemUnitClassLib = _prefixId.prefix "hasSystemUnitClassLib"
    let hasUnit = _prefixId.prefix "hasUnit"
    let hasUnitAttribute = _prefixId.prefix "hasUnitAttribute"
    /// <summary>
    ///   <para>skos:prefLabel : hasAttributeValue</para>
    ///   <a href="https://w3id.org/i40/aml#hasUnitValue">aml:hasUnitValue</a>
    /// </summary>
    let hasUnitValue = _prefixId.prefix "hasUnitValue"
    /// <summary>
    ///   <para>skos:prefLabel : hasVersion</para>
    ///   <a href="https://w3id.org/i40/aml#hasVersion">aml:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>skos:prefLabel : eClassVersion</para>
    ///   <para>skos:definition : Points to the eClass version for a given Element</para>
    ///   <a href="https://w3id.org/i40/aml#hasVersionEClass">aml:hasVersionEClass</a>
    /// </summary>
    let hasVersionEClass = _prefixId.prefix "hasVersionEClass"
    /// <summary>
    ///   <para>skos:prefLabel : hasVersionICL</para>
    ///   <para>skos:definition : Points to the version for a Interface Class Lib</para>
    ///   <a href="https://w3id.org/i40/aml#hasVersionICL">aml:hasVersionICL</a>
    /// </summary>
    let hasVersionICL = _prefixId.prefix "hasVersionICL"
    /// <summary>
    ///   <para>skos:prefLabel : hasVersionRCL</para>
    ///   <para>skos:definition : Points to the version for a Role Class Lib</para>
    ///   <a href="https://w3id.org/i40/aml#hasVersionRCL">aml:hasVersionRCL</a>
    /// </summary>
    let hasVersionRCL = _prefixId.prefix "hasVersionRCL"
    /// <summary>
    ///   <para>skos:prefLabel : hasVersionSUC</para>
    ///   <para>skos:definition : Points to the version for a System Unit Class</para>
    ///   <a href="https://w3id.org/i40/aml#hasVersionSUC">aml:hasVersionSUC</a>
    /// </summary>
    let hasVersionSUC = _prefixId.prefix "hasVersionSUC"
    /// <summary>
    ///   <para>skos:prefLabel : hasWriterId^^xsd:string</para>
    ///   <a href="https://w3id.org/i40/aml#hasWriterId">aml:hasWriterId</a>
    /// </summary>
    let hasWriterId = _prefixId.prefix "hasWriterId"
    /// <summary>
    ///   <para>skos:prefLabel : hasWriterName^^xsd:string</para>
    ///   <para>skos:definition : The name of the Writer, i.e., the tool that produced the file</para>
    ///   <a href="https://w3id.org/i40/aml#hasWriterName">aml:hasWriterName</a>
    /// </summary>
    let hasWriterName = _prefixId.prefix "hasWriterName"
    /// <summary>
    ///   <para>skos:prefLabel : hasWriterRelease</para>
    ///   <a href="https://w3id.org/i40/aml#hasWriterRelease">aml:hasWriterRelease</a>
    /// </summary>
    let hasWriterRelease = _prefixId.prefix "hasWriterRelease"
    /// <summary>
    ///   <para>skos:prefLabel : hasWriterVendor</para>
    ///   <a href="https://w3id.org/i40/aml#hasWriterVendor">aml:hasWriterVendor</a>
    /// </summary>
    let hasWriterVendor = _prefixId.prefix "hasWriterVendor"
    /// <summary>
    ///   <para>skos:prefLabel : hasWriterVendorURL</para>
    ///   <a href="https://w3id.org/i40/aml#hasWriterVendorURL">aml:hasWriterVendorURL</a>
    /// </summary>
    let hasWriterVendorURL = _prefixId.prefix "hasWriterVendorURL"
    /// <summary>
    ///   <para>skos:prefLabel : hasWriterVersion</para>
    ///   <a href="https://w3id.org/i40/aml#hasWriterVersion">aml:hasWriterVersion</a>
    /// </summary>
    let hasWriterVersion = _prefixId.prefix "hasWriterVersion"
    /// <summary>
    ///   <para>skos:prefLabel : eClassIsConnectedTo</para>
    ///   <para>skos:definition : Points to the eCl@ass connection for a given element</para>
    ///   <a href="https://w3id.org/i40/aml#isConnectedToEClass">aml:isConnectedToEClass</a>
    /// </summary>
    let isConnectedToEClass = _prefixId.prefix "isConnectedToEClass"
    /// <summary>
    ///   <para>skos:prefLabel : isPartOfIC</para>
    ///   <para>skos:definition : Connects the InterfaceClasses with other InterfaceClasses that are part of the given Interface Class</para>
    ///   <para>skos:altLabel : isPartOfInterfaceClass</para>
    ///   <a href="https://w3id.org/i40/aml#isPartOfIC">aml:isPartOfIC</a>
    /// </summary>
    let isPartOfIC = _prefixId.prefix "isPartOfIC"
    /// <summary>
    ///   <para>skos:prefLabel : isPartOfIE</para>
    ///   <para>skos:definition : Connects the Internal Element with other Internal Elements that are part of the given Internal Element</para>
    ///   <para>skos:altLabel : InternalElementPartOf</para>
    ///   <a href="https://w3id.org/i40/aml#isPartOfIE">aml:isPartOfIE</a>
    /// </summary>
    let isPartOfIE = _prefixId.prefix "isPartOfIE"
    /// <summary>
    ///   <para>skos:prefLabel : isPartOfSUC</para>
    ///   <para>skos:definition : Connects the System Unit Class with another System Unit Class Elements</para>
    ///   <para>skos:altLabel : SystemUnitClassPartOf</para>
    ///   <a href="https://w3id.org/i40/aml#isPartOfSUC">aml:isPartOfSUC</a>
    /// </summary>
    let isPartOfSUC = _prefixId.prefix "isPartOfSUC"
    let lastWritingDateTime = _prefixId.prefix "lastWritingDateTime"
    let milliampere = _prefixId.prefix "milliampere"
    let numerical_value = _prefixId.prefix "numerical_value"
    let refBaseSystemUnitPath = _prefixId.prefix "refBaseSystemUnitPath"
    /// <summary>
    ///   <para>skos:prefLabel : refSemanticAttribute</para>
    ///   <para>skos:definition : Reference to the eClass IRDI identification</para>
    ///   <a href="https://w3id.org/i40/aml#refSemanticAttribute">aml:refSemanticAttribute</a>
    /// </summary>
    let refSemanticAttribute = _prefixId.prefix "refSemanticAttribute"
    let speedMeasurement = _prefixId.prefix "speedMeasurement"
    let unit_of_measure = _prefixId.prefix "unit_of_measure"
