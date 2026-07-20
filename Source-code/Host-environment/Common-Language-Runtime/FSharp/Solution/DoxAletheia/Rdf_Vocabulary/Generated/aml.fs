namespace https.w3id.org.i40.aml.hash

open DoxAletheia

module aml =
    let _namespace_name = "https://w3id.org/i40/aml#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#CAEXFile"></see>
    /// </summary>
    let CAEXFile = _prefix "CAEXFile"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#AILevelSW"></see>
    /// </summary>
    let AILevelSW = _prefix "AILevelSW"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#ExternalInterface"></see>
    /// </summary>
    let ExternalInterface = _prefix "ExternalInterface"
    /// <summary>
    /// Unique ID for the Interface Class
    /// <see href="https://w3id.org/i40/aml#hasICID"></see></summary>
    let hasICID = _prefix "hasICID"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameIC"></see>
    /// </summary>
    let hasNameIC = _prefix "hasNameIC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseClassPathIC"></see>
    /// </summary>
    let hasRefBaseClassPathIC = _prefix "hasRefBaseClassPathIC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#AdditionalInformation"></see>
    /// </summary>
    let AdditionalInformation = _prefix "AdditionalInformation"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#AdditionalInformation1"></see>
    /// </summary>
    let AdditionalInformation1 = _prefix "AdditionalInformation1"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAMLVersion"></see>
    /// </summary>
    let hasAMLVersion = _prefix "hasAMLVersion"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterId"></see>
    /// </summary>
    let hasWriterId = _prefix "hasWriterId"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterName"></see>
    /// </summary>
    let hasWriterName = _prefix "hasWriterName"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterRelease"></see>
    /// </summary>
    let hasWriterRelease = _prefix "hasWriterRelease"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterVendor"></see>
    /// </summary>
    let hasWriterVendor = _prefix "hasWriterVendor"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterVendorURL"></see>
    /// </summary>
    let hasWriterVendorURL = _prefix "hasWriterVendorURL"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterVersion"></see>
    /// </summary>
    let hasWriterVersion = _prefix "hasWriterVersion"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#lastWritingDateTime"></see>
    /// </summary>
    let lastWritingDateTime = _prefix "lastWritingDateTime"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#AttValue1"></see>
    /// </summary>
    let AttValue1 = _prefix "AttValue1"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#numerical_value"></see>
    /// </summary>
    let numerical_value = _prefix "numerical_value"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#Attribute"></see>
    /// </summary>
    let Attribute = _prefix "Attribute"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#DemoArea"></see>
    /// </summary>
    let DemoArea = _prefix "DemoArea"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InternalElement"></see>
    /// </summary>
    let InternalElement = _prefix "InternalElement"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasIDIE"></see>
    /// </summary>
    let hasIDIE = _prefix "hasIDIE"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameIE"></see>
    /// </summary>
    let hasNameIE = _prefix "hasNameIE"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#isPartOfIE"></see>
    /// </summary>
    let isPartOfIE = _prefix "isPartOfIE"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#DemoSite"></see>
    /// </summary>
    let DemoSite = _prefix "DemoSite"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#DemoEnterprise"></see>
    /// </summary>
    let DemoEnterprise = _prefix "DemoEnterprise"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#ExampleInstanceHierarchy"></see>
    /// </summary>
    let ExampleInstanceHierarchy = _prefix "ExampleInstanceHierarchy"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InterfaceClass"></see>
    /// </summary>
    let InterfaceClass = _prefix "InterfaceClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#ExternalReference"></see>
    /// </summary>
    let ExternalReference = _prefix "ExternalReference"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#ExternalStandard"></see>
    /// </summary>
    let ExternalStandard = _prefix "ExternalStandard"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#FlowchartNumber"></see>
    /// </summary>
    let FlowchartNumber = _prefix "FlowchartNumber"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeDataType"></see>
    /// </summary>
    let hasAttributeDataType = _prefix "hasAttributeDataType"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeDescription"></see>
    /// </summary>
    let hasAttributeDescription = _prefix "hasAttributeDescription"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeValue"></see>
    /// </summary>
    let hasAttributeValue = _prefix "hasAttributeValue"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameAttribute"></see>
    /// </summary>
    let hasNameAttribute = _prefix "hasNameAttribute"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#refSemanticAttribute"></see>
    /// </summary>
    let refSemanticAttribute = _prefix "refSemanticAttribute"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#GMA6.16BeispielPIDVersion2.97"></see>
    /// </summary>
    let ``GMA6.16BeispielPIDVersion2.97`` = _prefix "GMA6.16BeispielPIDVersion2.97"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAdditionalInformation"></see>
    /// </summary>
    let hasAdditionalInformation = _prefix "hasAdditionalInformation"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameFile"></see>
    /// </summary>
    let hasNameFile = _prefix "hasNameFile"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSchemaVersion"></see>
    /// </summary>
    let hasSchemaVersion = _prefix "hasSchemaVersion"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InstanceHierarchy"></see>
    /// </summary>
    let InstanceHierarchy = _prefix "InstanceHierarchy"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InterfaceClassLib"></see>
    /// </summary>
    let InterfaceClassLib = _prefix "InterfaceClassLib"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InternalLink"></see>
    /// </summary>
    let InternalLink = _prefix "InternalLink"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#L1001"></see>
    /// </summary>
    let L1001 = _prefix "L1001"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttribute"></see>
    /// </summary>
    let hasAttribute = _prefix "hasAttribute"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#PCEDescription"></see>
    /// </summary>
    let PCEDescription = _prefix "PCEDescription"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#refBaseSystemUnitPath"></see>
    /// </summary>
    let refBaseSystemUnitPath = _prefix "refBaseSystemUnitPath"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#LIRCS1"></see>
    /// </summary>
    let LIRCS1 = _prefix "LIRCS1"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeIE"></see>
    /// </summary>
    let hasAttributeIE = _prefix "hasAttributeIE"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#PCEInitial"></see>
    /// </summary>
    let PCEInitial = _prefix "PCEInitial"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#PCEFunction"></see>
    /// </summary>
    let PCEFunction = _prefix "PCEFunction"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasExternalInterface"></see>
    /// </summary>
    let hasExternalInterface = _prefix "hasExternalInterface"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#MaxConveyingSpeed"></see>
    /// </summary>
    let MaxConveyingSpeed = _prefix "MaxConveyingSpeed"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasUnitAttribute"></see>
    /// </summary>
    let hasUnitAttribute = _prefix "hasUnitAttribute"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#speedMeasurement"></see>
    /// </summary>
    let speedMeasurement = _prefix "speedMeasurement"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#MeasurementRangeEnd"></see>
    /// </summary>
    let MeasurementRangeEnd = _prefix "MeasurementRangeEnd"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#MeasurementRangeStart"></see>
    /// </summary>
    let MeasurementRangeStart = _prefix "MeasurementRangeStart"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#NE150DemoProject"></see>
    /// </summary>
    let NE150DemoProject = _prefix "NE150DemoProject"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInternalElement"></see>
    /// </summary>
    let hasInternalElement = _prefix "hasInternalElement"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameIH"></see>
    /// </summary>
    let hasNameIH = _prefix "hasNameIH"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#OldPCE"></see>
    /// </summary>
    let OldPCE = _prefix "OldPCE"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#Project"></see>
    /// </summary>
    let Project = _prefix "Project"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#RoleClass"></see>
    /// </summary>
    let RoleClass = _prefix "RoleClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#RoleClassLib"></see>
    /// </summary>
    let RoleClassLib = _prefix "RoleClassLib"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#SoftwareSignalName"></see>
    /// </summary>
    let SoftwareSignalName = _prefix "SoftwareSignalName"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeIC"></see>
    /// </summary>
    let hasAttributeIC = _prefix "hasAttributeIC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#SystemUnitClass"></see>
    /// </summary>
    let SystemUnitClass = _prefix "SystemUnitClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#SystemUnitClassLib"></see>
    /// </summary>
    let SystemUnitClassLib = _prefix "SystemUnitClassLib"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#eClassSpecification"></see>
    /// </summary>
    let eClassSpecification = _prefix "eClassSpecification"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeName"></see>
    /// </summary>
    let hasAttributeName = _prefix "hasAttributeName"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeRC"></see>
    /// </summary>
    let hasAttributeRC = _prefix "hasAttributeRC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeSUC"></see>
    /// </summary>
    let hasAttributeSUC = _prefix "hasAttributeSUC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasBaseSystemUnitClass"></see>
    /// </summary>
    let hasBaseSystemUnitClass = _prefix "hasBaseSystemUnitClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasClassificationClass"></see>
    /// </summary>
    let hasClassificationClass = _prefix "hasClassificationClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasExternalReference"></see>
    /// </summary>
    let hasExternalReference = _prefix "hasExternalReference"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasExternalReferenceAlias"></see>
    /// </summary>
    let hasExternalReferenceAlias = _prefix "hasExternalReferenceAlias"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasExternalReferencePath"></see>
    /// </summary>
    let hasExternalReferencePath = _prefix "hasExternalReferencePath"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasIRDIeClass"></see>
    /// </summary>
    let hasIRDIeClass = _prefix "hasIRDIeClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInstanceHierarchy"></see>
    /// </summary>
    let hasInstanceHierarchy = _prefix "hasInstanceHierarchy"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterface"></see>
    /// </summary>
    let hasInterface = _prefix "hasInterface"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceClass"></see>
    /// </summary>
    let hasInterfaceClass = _prefix "hasInterfaceClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceClassLib"></see>
    /// </summary>
    let hasInterfaceClassLib = _prefix "hasInterfaceClassLib"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceIE"></see>
    /// </summary>
    let hasInterfaceIE = _prefix "hasInterfaceIE"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceRC"></see>
    /// </summary>
    let hasInterfaceRC = _prefix "hasInterfaceRC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceSUC"></see>
    /// </summary>
    let hasInterfaceSUC = _prefix "hasInterfaceSUC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInternalLink"></see>
    /// </summary>
    let hasInternalLink = _prefix "hasInternalLink"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameRC"></see>
    /// </summary>
    let hasNameRC = _prefix "hasNameRC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameSUC"></see>
    /// </summary>
    let hasNameSUC = _prefix "hasNameSUC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasProject"></see>
    /// </summary>
    let hasProject = _prefix "hasProject"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasProjectId"></see>
    /// </summary>
    let hasProjectId = _prefix "hasProjectId"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasProjectTitle"></see>
    /// </summary>
    let hasProjectTitle = _prefix "hasProjectTitle"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseClassPath"></see>
    /// </summary>
    let hasRefBaseClassPath = _prefix "hasRefBaseClassPath"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseClassPathRC"></see>
    /// </summary>
    let hasRefBaseClassPathRC = _prefix "hasRefBaseClassPathRC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseClassPathSUC"></see>
    /// </summary>
    let hasRefBaseClassPathSUC = _prefix "hasRefBaseClassPathSUC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseRoleClassPath"></see>
    /// </summary>
    let hasRefBaseRoleClassPath = _prefix "hasRefBaseRoleClassPath"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseSystemUnitPath"></see>
    /// </summary>
    let hasRefBaseSystemUnitPath = _prefix "hasRefBaseSystemUnitPath"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefPartnerSideA"></see>
    /// </summary>
    let hasRefPartnerSideA = _prefix "hasRefPartnerSideA"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefPartnerSideB"></see>
    /// </summary>
    let hasRefPartnerSideB = _prefix "hasRefPartnerSideB"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefRoleClassPath"></see>
    /// </summary>
    let hasRefRoleClassPath = _prefix "hasRefRoleClassPath"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefSemAttribute"></see>
    /// </summary>
    let hasRefSemAttribute = _prefix "hasRefSemAttribute"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSemanticRef"></see>
    /// </summary>
    let hasSemanticRef = _prefix "hasSemanticRef"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefSemRC"></see>
    /// </summary>
    let hasRefSemRC = _prefix "hasRefSemRC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleClass"></see>
    /// </summary>
    let hasRoleClass = _prefix "hasRoleClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleClassLib"></see>
    /// </summary>
    let hasRoleClassLib = _prefix "hasRoleClassLib"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleRequeriment"></see>
    /// </summary>
    let hasRoleRequeriment = _prefix "hasRoleRequeriment"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleRequirementIE"></see>
    /// </summary>
    let hasRoleRequirementIE = _prefix "hasRoleRequirementIE"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleRequirementSUC"></see>
    /// </summary>
    let hasRoleRequirementSUC = _prefix "hasRoleRequirementSUC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSupportedRoleClass"></see>
    /// </summary>
    let hasSupportedRoleClass = _prefix "hasSupportedRoleClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSupportedRoleClassIE"></see>
    /// </summary>
    let hasSupportedRoleClassIE = _prefix "hasSupportedRoleClassIE"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSupportedRoleClassSUC"></see>
    /// </summary>
    let hasSupportedRoleClassSUC = _prefix "hasSupportedRoleClassSUC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSystemUnitClass"></see>
    /// </summary>
    let hasSystemUnitClass = _prefix "hasSystemUnitClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSystemUnitClassLib"></see>
    /// </summary>
    let hasSystemUnitClassLib = _prefix "hasSystemUnitClassLib"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasUnit"></see>
    /// </summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasUnitValue"></see>
    /// </summary>
    let hasUnitValue = _prefix "hasUnitValue"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersion"></see>
    /// </summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersionEClass"></see>
    /// </summary>
    let hasVersionEClass = _prefix "hasVersionEClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersionICL"></see>
    /// </summary>
    let hasVersionICL = _prefix "hasVersionICL"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersionRCL"></see>
    /// </summary>
    let hasVersionRCL = _prefix "hasVersionRCL"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersionSUC"></see>
    /// </summary>
    let hasVersionSUC = _prefix "hasVersionSUC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#isConnectedToEClass"></see>
    /// </summary>
    let isConnectedToEClass = _prefix "isConnectedToEClass"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#isPartOfIC"></see>
    /// </summary>
    let isPartOfIC = _prefix "isPartOfIC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#isPartOfSUC"></see>
    /// </summary>
    let isPartOfSUC = _prefix "isPartOfSUC"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#milliampere"></see>
    /// </summary>
    let milliampere = _prefix "milliampere"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#unit_of_measure"></see>
    /// </summary>
    let unit_of_measure = _prefix "unit_of_measure"
