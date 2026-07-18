namespace https.w3id.org.i40.aml.hash

open DoxAletheia.Rdf_Vocabulary

module aml =
    let _namespace_name = "https://w3id.org/i40/aml#"
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#CAEXFile"></see>
    /// </summary>
    let CAEXFile = Namespaced_IRI.parse _namespace_name "CAEXFile" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#AILevelSW"></see>
    /// </summary>
    let AILevelSW = Namespaced_IRI.parse _namespace_name "AILevelSW" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#ExternalInterface"></see>
    /// </summary>
    let ExternalInterface =
        Namespaced_IRI.parse _namespace_name "ExternalInterface" |> NamespacedName

    /// <summary>
    /// Unique ID for the Interface Class
    /// <see href="https://w3id.org/i40/aml#hasICID"></see></summary>
    let hasICID = Namespaced_IRI.parse _namespace_name "hasICID" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameIC"></see>
    /// </summary>
    let hasNameIC = Namespaced_IRI.parse _namespace_name "hasNameIC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseClassPathIC"></see>
    /// </summary>
    let hasRefBaseClassPathIC =
        Namespaced_IRI.parse _namespace_name "hasRefBaseClassPathIC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#AdditionalInformation"></see>
    /// </summary>
    let AdditionalInformation =
        Namespaced_IRI.parse _namespace_name "AdditionalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#AdditionalInformation1"></see>
    /// </summary>
    let AdditionalInformation1 =
        Namespaced_IRI.parse _namespace_name "AdditionalInformation1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAMLVersion"></see>
    /// </summary>
    let hasAMLVersion =
        Namespaced_IRI.parse _namespace_name "hasAMLVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterId"></see>
    /// </summary>
    let hasWriterId =
        Namespaced_IRI.parse _namespace_name "hasWriterId" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterName"></see>
    /// </summary>
    let hasWriterName =
        Namespaced_IRI.parse _namespace_name "hasWriterName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterRelease"></see>
    /// </summary>
    let hasWriterRelease =
        Namespaced_IRI.parse _namespace_name "hasWriterRelease" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterVendor"></see>
    /// </summary>
    let hasWriterVendor =
        Namespaced_IRI.parse _namespace_name "hasWriterVendor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterVendorURL"></see>
    /// </summary>
    let hasWriterVendorURL =
        Namespaced_IRI.parse _namespace_name "hasWriterVendorURL" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasWriterVersion"></see>
    /// </summary>
    let hasWriterVersion =
        Namespaced_IRI.parse _namespace_name "hasWriterVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#lastWritingDateTime"></see>
    /// </summary>
    let lastWritingDateTime =
        Namespaced_IRI.parse _namespace_name "lastWritingDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#AttValue1"></see>
    /// </summary>
    let AttValue1 = Namespaced_IRI.parse _namespace_name "AttValue1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#numerical_value"></see>
    /// </summary>
    let numerical_value =
        Namespaced_IRI.parse _namespace_name "numerical_value" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#Attribute"></see>
    /// </summary>
    let Attribute = Namespaced_IRI.parse _namespace_name "Attribute" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#DemoArea"></see>
    /// </summary>
    let DemoArea = Namespaced_IRI.parse _namespace_name "DemoArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InternalElement"></see>
    /// </summary>
    let InternalElement =
        Namespaced_IRI.parse _namespace_name "InternalElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasIDIE"></see>
    /// </summary>
    let hasIDIE = Namespaced_IRI.parse _namespace_name "hasIDIE" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameIE"></see>
    /// </summary>
    let hasNameIE = Namespaced_IRI.parse _namespace_name "hasNameIE" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#isPartOfIE"></see>
    /// </summary>
    let isPartOfIE = Namespaced_IRI.parse _namespace_name "isPartOfIE" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#DemoSite"></see>
    /// </summary>
    let DemoSite = Namespaced_IRI.parse _namespace_name "DemoSite" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#DemoEnterprise"></see>
    /// </summary>
    let DemoEnterprise =
        Namespaced_IRI.parse _namespace_name "DemoEnterprise" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#ExampleInstanceHierarchy"></see>
    /// </summary>
    let ExampleInstanceHierarchy =
        Namespaced_IRI.parse _namespace_name "ExampleInstanceHierarchy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InterfaceClass"></see>
    /// </summary>
    let InterfaceClass =
        Namespaced_IRI.parse _namespace_name "InterfaceClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#ExternalReference"></see>
    /// </summary>
    let ExternalReference =
        Namespaced_IRI.parse _namespace_name "ExternalReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#ExternalStandard"></see>
    /// </summary>
    let ExternalStandard =
        Namespaced_IRI.parse _namespace_name "ExternalStandard" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#FlowchartNumber"></see>
    /// </summary>
    let FlowchartNumber =
        Namespaced_IRI.parse _namespace_name "FlowchartNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeDataType"></see>
    /// </summary>
    let hasAttributeDataType =
        Namespaced_IRI.parse _namespace_name "hasAttributeDataType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeDescription"></see>
    /// </summary>
    let hasAttributeDescription =
        Namespaced_IRI.parse _namespace_name "hasAttributeDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeValue"></see>
    /// </summary>
    let hasAttributeValue =
        Namespaced_IRI.parse _namespace_name "hasAttributeValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameAttribute"></see>
    /// </summary>
    let hasNameAttribute =
        Namespaced_IRI.parse _namespace_name "hasNameAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#refSemanticAttribute"></see>
    /// </summary>
    let refSemanticAttribute =
        Namespaced_IRI.parse _namespace_name "refSemanticAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#GMA6.16BeispielPIDVersion2.97"></see>
    /// </summary>
    let ``GMA6.16BeispielPIDVersion2.97`` =
        Namespaced_IRI.parse _namespace_name "GMA6.16BeispielPIDVersion2.97" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAdditionalInformation"></see>
    /// </summary>
    let hasAdditionalInformation =
        Namespaced_IRI.parse _namespace_name "hasAdditionalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameFile"></see>
    /// </summary>
    let hasNameFile =
        Namespaced_IRI.parse _namespace_name "hasNameFile" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSchemaVersion"></see>
    /// </summary>
    let hasSchemaVersion =
        Namespaced_IRI.parse _namespace_name "hasSchemaVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InstanceHierarchy"></see>
    /// </summary>
    let InstanceHierarchy =
        Namespaced_IRI.parse _namespace_name "InstanceHierarchy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InterfaceClassLib"></see>
    /// </summary>
    let InterfaceClassLib =
        Namespaced_IRI.parse _namespace_name "InterfaceClassLib" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#InternalLink"></see>
    /// </summary>
    let InternalLink =
        Namespaced_IRI.parse _namespace_name "InternalLink" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#L1001"></see>
    /// </summary>
    let L1001 = Namespaced_IRI.parse _namespace_name "L1001" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttribute"></see>
    /// </summary>
    let hasAttribute =
        Namespaced_IRI.parse _namespace_name "hasAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#PCEDescription"></see>
    /// </summary>
    let PCEDescription =
        Namespaced_IRI.parse _namespace_name "PCEDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#refBaseSystemUnitPath"></see>
    /// </summary>
    let refBaseSystemUnitPath =
        Namespaced_IRI.parse _namespace_name "refBaseSystemUnitPath" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#LIRCS1"></see>
    /// </summary>
    let LIRCS1 = Namespaced_IRI.parse _namespace_name "LIRCS1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeIE"></see>
    /// </summary>
    let hasAttributeIE =
        Namespaced_IRI.parse _namespace_name "hasAttributeIE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#PCEInitial"></see>
    /// </summary>
    let PCEInitial = Namespaced_IRI.parse _namespace_name "PCEInitial" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#PCEFunction"></see>
    /// </summary>
    let PCEFunction =
        Namespaced_IRI.parse _namespace_name "PCEFunction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasExternalInterface"></see>
    /// </summary>
    let hasExternalInterface =
        Namespaced_IRI.parse _namespace_name "hasExternalInterface" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#MaxConveyingSpeed"></see>
    /// </summary>
    let MaxConveyingSpeed =
        Namespaced_IRI.parse _namespace_name "MaxConveyingSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasUnitAttribute"></see>
    /// </summary>
    let hasUnitAttribute =
        Namespaced_IRI.parse _namespace_name "hasUnitAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#speedMeasurement"></see>
    /// </summary>
    let speedMeasurement =
        Namespaced_IRI.parse _namespace_name "speedMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#MeasurementRangeEnd"></see>
    /// </summary>
    let MeasurementRangeEnd =
        Namespaced_IRI.parse _namespace_name "MeasurementRangeEnd" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#MeasurementRangeStart"></see>
    /// </summary>
    let MeasurementRangeStart =
        Namespaced_IRI.parse _namespace_name "MeasurementRangeStart" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#NE150DemoProject"></see>
    /// </summary>
    let NE150DemoProject =
        Namespaced_IRI.parse _namespace_name "NE150DemoProject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInternalElement"></see>
    /// </summary>
    let hasInternalElement =
        Namespaced_IRI.parse _namespace_name "hasInternalElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameIH"></see>
    /// </summary>
    let hasNameIH = Namespaced_IRI.parse _namespace_name "hasNameIH" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#OldPCE"></see>
    /// </summary>
    let OldPCE = Namespaced_IRI.parse _namespace_name "OldPCE" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#Project"></see>
    /// </summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#RoleClass"></see>
    /// </summary>
    let RoleClass = Namespaced_IRI.parse _namespace_name "RoleClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#RoleClassLib"></see>
    /// </summary>
    let RoleClassLib =
        Namespaced_IRI.parse _namespace_name "RoleClassLib" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#SoftwareSignalName"></see>
    /// </summary>
    let SoftwareSignalName =
        Namespaced_IRI.parse _namespace_name "SoftwareSignalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeIC"></see>
    /// </summary>
    let hasAttributeIC =
        Namespaced_IRI.parse _namespace_name "hasAttributeIC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#SystemUnitClass"></see>
    /// </summary>
    let SystemUnitClass =
        Namespaced_IRI.parse _namespace_name "SystemUnitClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#SystemUnitClassLib"></see>
    /// </summary>
    let SystemUnitClassLib =
        Namespaced_IRI.parse _namespace_name "SystemUnitClassLib" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#contains"></see>
    /// </summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#eClassSpecification"></see>
    /// </summary>
    let eClassSpecification =
        Namespaced_IRI.parse _namespace_name "eClassSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeName"></see>
    /// </summary>
    let hasAttributeName =
        Namespaced_IRI.parse _namespace_name "hasAttributeName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeRC"></see>
    /// </summary>
    let hasAttributeRC =
        Namespaced_IRI.parse _namespace_name "hasAttributeRC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasAttributeSUC"></see>
    /// </summary>
    let hasAttributeSUC =
        Namespaced_IRI.parse _namespace_name "hasAttributeSUC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasBaseSystemUnitClass"></see>
    /// </summary>
    let hasBaseSystemUnitClass =
        Namespaced_IRI.parse _namespace_name "hasBaseSystemUnitClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasClassificationClass"></see>
    /// </summary>
    let hasClassificationClass =
        Namespaced_IRI.parse _namespace_name "hasClassificationClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasExternalReference"></see>
    /// </summary>
    let hasExternalReference =
        Namespaced_IRI.parse _namespace_name "hasExternalReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasExternalReferenceAlias"></see>
    /// </summary>
    let hasExternalReferenceAlias =
        Namespaced_IRI.parse _namespace_name "hasExternalReferenceAlias" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasExternalReferencePath"></see>
    /// </summary>
    let hasExternalReferencePath =
        Namespaced_IRI.parse _namespace_name "hasExternalReferencePath" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasIRDIeClass"></see>
    /// </summary>
    let hasIRDIeClass =
        Namespaced_IRI.parse _namespace_name "hasIRDIeClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInstanceHierarchy"></see>
    /// </summary>
    let hasInstanceHierarchy =
        Namespaced_IRI.parse _namespace_name "hasInstanceHierarchy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterface"></see>
    /// </summary>
    let hasInterface =
        Namespaced_IRI.parse _namespace_name "hasInterface" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceClass"></see>
    /// </summary>
    let hasInterfaceClass =
        Namespaced_IRI.parse _namespace_name "hasInterfaceClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceClassLib"></see>
    /// </summary>
    let hasInterfaceClassLib =
        Namespaced_IRI.parse _namespace_name "hasInterfaceClassLib" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceIE"></see>
    /// </summary>
    let hasInterfaceIE =
        Namespaced_IRI.parse _namespace_name "hasInterfaceIE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceRC"></see>
    /// </summary>
    let hasInterfaceRC =
        Namespaced_IRI.parse _namespace_name "hasInterfaceRC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInterfaceSUC"></see>
    /// </summary>
    let hasInterfaceSUC =
        Namespaced_IRI.parse _namespace_name "hasInterfaceSUC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasInternalLink"></see>
    /// </summary>
    let hasInternalLink =
        Namespaced_IRI.parse _namespace_name "hasInternalLink" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameRC"></see>
    /// </summary>
    let hasNameRC = Namespaced_IRI.parse _namespace_name "hasNameRC" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasNameSUC"></see>
    /// </summary>
    let hasNameSUC = Namespaced_IRI.parse _namespace_name "hasNameSUC" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasProject"></see>
    /// </summary>
    let hasProject = Namespaced_IRI.parse _namespace_name "hasProject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasProjectId"></see>
    /// </summary>
    let hasProjectId =
        Namespaced_IRI.parse _namespace_name "hasProjectId" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasProjectTitle"></see>
    /// </summary>
    let hasProjectTitle =
        Namespaced_IRI.parse _namespace_name "hasProjectTitle" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseClassPath"></see>
    /// </summary>
    let hasRefBaseClassPath =
        Namespaced_IRI.parse _namespace_name "hasRefBaseClassPath" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseClassPathRC"></see>
    /// </summary>
    let hasRefBaseClassPathRC =
        Namespaced_IRI.parse _namespace_name "hasRefBaseClassPathRC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseClassPathSUC"></see>
    /// </summary>
    let hasRefBaseClassPathSUC =
        Namespaced_IRI.parse _namespace_name "hasRefBaseClassPathSUC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseRoleClassPath"></see>
    /// </summary>
    let hasRefBaseRoleClassPath =
        Namespaced_IRI.parse _namespace_name "hasRefBaseRoleClassPath" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefBaseSystemUnitPath"></see>
    /// </summary>
    let hasRefBaseSystemUnitPath =
        Namespaced_IRI.parse _namespace_name "hasRefBaseSystemUnitPath" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefPartnerSideA"></see>
    /// </summary>
    let hasRefPartnerSideA =
        Namespaced_IRI.parse _namespace_name "hasRefPartnerSideA" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefPartnerSideB"></see>
    /// </summary>
    let hasRefPartnerSideB =
        Namespaced_IRI.parse _namespace_name "hasRefPartnerSideB" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefRoleClassPath"></see>
    /// </summary>
    let hasRefRoleClassPath =
        Namespaced_IRI.parse _namespace_name "hasRefRoleClassPath" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefSemAttribute"></see>
    /// </summary>
    let hasRefSemAttribute =
        Namespaced_IRI.parse _namespace_name "hasRefSemAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSemanticRef"></see>
    /// </summary>
    let hasSemanticRef =
        Namespaced_IRI.parse _namespace_name "hasSemanticRef" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRefSemRC"></see>
    /// </summary>
    let hasRefSemRC =
        Namespaced_IRI.parse _namespace_name "hasRefSemRC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleClass"></see>
    /// </summary>
    let hasRoleClass =
        Namespaced_IRI.parse _namespace_name "hasRoleClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleClassLib"></see>
    /// </summary>
    let hasRoleClassLib =
        Namespaced_IRI.parse _namespace_name "hasRoleClassLib" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleRequeriment"></see>
    /// </summary>
    let hasRoleRequeriment =
        Namespaced_IRI.parse _namespace_name "hasRoleRequeriment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleRequirementIE"></see>
    /// </summary>
    let hasRoleRequirementIE =
        Namespaced_IRI.parse _namespace_name "hasRoleRequirementIE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasRoleRequirementSUC"></see>
    /// </summary>
    let hasRoleRequirementSUC =
        Namespaced_IRI.parse _namespace_name "hasRoleRequirementSUC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSupportedRoleClass"></see>
    /// </summary>
    let hasSupportedRoleClass =
        Namespaced_IRI.parse _namespace_name "hasSupportedRoleClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSupportedRoleClassIE"></see>
    /// </summary>
    let hasSupportedRoleClassIE =
        Namespaced_IRI.parse _namespace_name "hasSupportedRoleClassIE" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSupportedRoleClassSUC"></see>
    /// </summary>
    let hasSupportedRoleClassSUC =
        Namespaced_IRI.parse _namespace_name "hasSupportedRoleClassSUC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSystemUnitClass"></see>
    /// </summary>
    let hasSystemUnitClass =
        Namespaced_IRI.parse _namespace_name "hasSystemUnitClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasSystemUnitClassLib"></see>
    /// </summary>
    let hasSystemUnitClassLib =
        Namespaced_IRI.parse _namespace_name "hasSystemUnitClassLib" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasUnit"></see>
    /// </summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasUnitValue"></see>
    /// </summary>
    let hasUnitValue =
        Namespaced_IRI.parse _namespace_name "hasUnitValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersion"></see>
    /// </summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersionEClass"></see>
    /// </summary>
    let hasVersionEClass =
        Namespaced_IRI.parse _namespace_name "hasVersionEClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersionICL"></see>
    /// </summary>
    let hasVersionICL =
        Namespaced_IRI.parse _namespace_name "hasVersionICL" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersionRCL"></see>
    /// </summary>
    let hasVersionRCL =
        Namespaced_IRI.parse _namespace_name "hasVersionRCL" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#hasVersionSUC"></see>
    /// </summary>
    let hasVersionSUC =
        Namespaced_IRI.parse _namespace_name "hasVersionSUC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#isConnectedToEClass"></see>
    /// </summary>
    let isConnectedToEClass =
        Namespaced_IRI.parse _namespace_name "isConnectedToEClass" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#isPartOfIC"></see>
    /// </summary>
    let isPartOfIC = Namespaced_IRI.parse _namespace_name "isPartOfIC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#isPartOfSUC"></see>
    /// </summary>
    let isPartOfSUC =
        Namespaced_IRI.parse _namespace_name "isPartOfSUC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#milliampere"></see>
    /// </summary>
    let milliampere =
        Namespaced_IRI.parse _namespace_name "milliampere" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/i40/aml#unit_of_measure"></see>
    /// </summary>
    let unit_of_measure =
        Namespaced_IRI.parse _namespace_name "unit_of_measure" |> NamespacedName
