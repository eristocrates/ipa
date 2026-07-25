namespace https.w3id.org.i40.aml.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aml =
    let _namespace_iri = Namespace_Iri aml |> NamespaceIRI
    /// <summary>
    ///   <para>aml:CAEXFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#CAEXFile">https://w3id.org/i40/aml#CAEXFile</seealso>
    let CAEXFile = Prefixed_Name(aml, "CAEXFile") |> PrefixedName
    /// <summary>
    ///   <para>aml:L1001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#InternalElement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#L1001">https://w3id.org/i40/aml#L1001</seealso>
    let L1001 = Prefixed_Name(aml, "L1001") |> PrefixedName
    /// <summary>
    ///   <para>aml:LIRCS1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#InternalElement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#LIRCS1">https://w3id.org/i40/aml#LIRCS1</seealso>
    let LIRCS1 = Prefixed_Name(aml, "LIRCS1") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasAttributeIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttributeIE">https://w3id.org/i40/aml#hasAttributeIE</seealso>
    let hasAttributeIE = Prefixed_Name(aml, "hasAttributeIE") |> PrefixedName
    /// <summary>
    ///   <para>aml:PCEInitial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#Attribute</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#PCEInitial">https://w3id.org/i40/aml#PCEInitial</seealso>
    let PCEInitial = Prefixed_Name(aml, "PCEInitial") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasUnitAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasUnitAttribute">https://w3id.org/i40/aml#hasUnitAttribute</seealso>
    let hasUnitAttribute = Prefixed_Name(aml, "hasUnitAttribute") |> PrefixedName
    /// <summary>
    ///   <para>aml:speedMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://www.wurvoc.org/vocabularies/om-1.8/Measure&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#speedMeasurement">https://w3id.org/i40/aml#speedMeasurement</seealso>
    let speedMeasurement = Prefixed_Name(aml, "speedMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>aml:MeasurementRangeEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#Attribute</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#MeasurementRangeEnd">https://w3id.org/i40/aml#MeasurementRangeEnd</seealso>
    let MeasurementRangeEnd = Prefixed_Name(aml, "MeasurementRangeEnd") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasInternalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInternalElement">https://w3id.org/i40/aml#hasInternalElement</seealso>
    let hasInternalElement = Prefixed_Name(aml, "hasInternalElement") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasNameIH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasNameIH">https://w3id.org/i40/aml#hasNameIH</seealso>
    let hasNameIH = Prefixed_Name(aml, "hasNameIH") |> PrefixedName
    /// <summary>
    ///   <para>aml:OldPCE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:i40/aml#Attribute</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#OldPCE">https://w3id.org/i40/aml#OldPCE</seealso>
    let OldPCE = Prefixed_Name(aml, "OldPCE") |> PrefixedName
    /// <summary>
    ///   <para>aml:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#Project">https://w3id.org/i40/aml#Project</seealso>
    let Project = Prefixed_Name(aml, "Project") |> PrefixedName
    /// <summary>
    ///   <para>aml:RoleClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#RoleClass">https://w3id.org/i40/aml#RoleClass</seealso>
    let RoleClass = Prefixed_Name(aml, "RoleClass") |> PrefixedName
    /// <summary>
    ///   <para>aml:RoleClassLib</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#RoleClassLib">https://w3id.org/i40/aml#RoleClassLib</seealso>
    let RoleClassLib = Prefixed_Name(aml, "RoleClassLib") |> PrefixedName
    /// <summary>
    ///   <para>aml:FlowchartNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#Attribute</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#FlowchartNumber">https://w3id.org/i40/aml#FlowchartNumber</seealso>
    let FlowchartNumber = Prefixed_Name(aml, "FlowchartNumber") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasName">https://w3id.org/i40/aml#hasName</seealso>
    let hasName = Prefixed_Name(aml, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasNameRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasNameRC">https://w3id.org/i40/aml#hasNameRC</seealso>
    let hasNameRC = Prefixed_Name(aml, "hasNameRC") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasNameSUC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasNameSUC">https://w3id.org/i40/aml#hasNameSUC</seealso>
    let hasNameSUC = Prefixed_Name(aml, "hasNameSUC") |> PrefixedName
    /// <summary>
    ///   <para>aml:ExternalStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#ExternalStandard">https://w3id.org/i40/aml#ExternalStandard</seealso>
    let ExternalStandard = Prefixed_Name(aml, "ExternalStandard") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasAdditionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAdditionalInformation">https://w3id.org/i40/aml#hasAdditionalInformation</seealso>
    let hasAdditionalInformation =
        Prefixed_Name(aml, "hasAdditionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasSupportedRoleClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasSupportedRoleClass">https://w3id.org/i40/aml#hasSupportedRoleClass</seealso>
    let hasSupportedRoleClass =
        Prefixed_Name(aml, "hasSupportedRoleClass") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasSupportedRoleClassIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasSupportedRoleClassIE">https://w3id.org/i40/aml#hasSupportedRoleClassIE</seealso>
    let hasSupportedRoleClassIE =
        Prefixed_Name(aml, "hasSupportedRoleClassIE") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasSystemUnitClassLib</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasSystemUnitClassLib">https://w3id.org/i40/aml#hasSystemUnitClassLib</seealso>
    let hasSystemUnitClassLib =
        Prefixed_Name(aml, "hasSystemUnitClassLib") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasUnit">https://w3id.org/i40/aml#hasUnit</seealso>
    let hasUnit = Prefixed_Name(aml, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasUnitValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasUnitValue">https://w3id.org/i40/aml#hasUnitValue</seealso>
    let hasUnitValue = Prefixed_Name(aml, "hasUnitValue") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasVersionEClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasVersionEClass">https://w3id.org/i40/aml#hasVersionEClass</seealso>
    let hasVersionEClass = Prefixed_Name(aml, "hasVersionEClass") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasVersionICL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasVersionICL">https://w3id.org/i40/aml#hasVersionICL</seealso>
    let hasVersionICL = Prefixed_Name(aml, "hasVersionICL") |> PrefixedName
    /// <summary>
    ///   <para>aml:isConnectedToEClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#isConnectedToEClass">https://w3id.org/i40/aml#isConnectedToEClass</seealso>
    let isConnectedToEClass = Prefixed_Name(aml, "isConnectedToEClass") |> PrefixedName
    /// <summary>
    ///   <para>aml:milliampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://www.wurvoc.org/vocabularies/om-1.8/Unit_of_measure&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#milliampere">https://w3id.org/i40/aml#milliampere</seealso>
    let milliampere = Prefixed_Name(aml, "milliampere") |> PrefixedName
    /// <summary>
    ///   <para>aml:unit_of_measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#unit_of_measure">https://w3id.org/i40/aml#unit_of_measure</seealso>
    let unit_of_measure = Prefixed_Name(aml, "unit_of_measure") |> PrefixedName
    /// <summary>
    ///   <para>aml:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>A vocabulary to represents the AutomationML Standard - IEC 62714</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#">https://w3id.org/i40/aml#</seealso>
    let _prefix_iri = Prefixed_Name(aml, "") |> PrefixedName
    /// <summary>
    ///   <para>aml:AILevelSW</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:i40/aml#ExternalInterface</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#AILevelSW">https://w3id.org/i40/aml#AILevelSW</seealso>
    let AILevelSW = Prefixed_Name(aml, "AILevelSW") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasNameIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasNameIC">https://w3id.org/i40/aml#hasNameIC</seealso>
    let hasNameIC = Prefixed_Name(aml, "hasNameIC") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRefBaseClassPathIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefBaseClassPathIC">https://w3id.org/i40/aml#hasRefBaseClassPathIC</seealso>
    let hasRefBaseClassPathIC =
        Prefixed_Name(aml, "hasRefBaseClassPathIC") |> PrefixedName

    /// <summary>
    ///   <para>aml:AdditionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#AdditionalInformation">https://w3id.org/i40/aml#AdditionalInformation</seealso>
    let AdditionalInformation =
        Prefixed_Name(aml, "AdditionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasWriterName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasWriterName">https://w3id.org/i40/aml#hasWriterName</seealso>
    let hasWriterName = Prefixed_Name(aml, "hasWriterName") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasWriterRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasWriterRelease">https://w3id.org/i40/aml#hasWriterRelease</seealso>
    let hasWriterRelease = Prefixed_Name(aml, "hasWriterRelease") |> PrefixedName
    /// <summary>
    ///   <para>aml:Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#Attribute">https://w3id.org/i40/aml#Attribute</seealso>
    let Attribute = Prefixed_Name(aml, "Attribute") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasNameIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasNameIE">https://w3id.org/i40/aml#hasNameIE</seealso>
    let hasNameIE = Prefixed_Name(aml, "hasNameIE") |> PrefixedName
    /// <summary>
    ///   <para>aml:isPartOfIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#isPartOfIE">https://w3id.org/i40/aml#isPartOfIE</seealso>
    let isPartOfIE = Prefixed_Name(aml, "isPartOfIE") |> PrefixedName
    /// <summary>
    ///   <para>aml:DemoSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:i40/aml#InternalElement</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#DemoSite">https://w3id.org/i40/aml#DemoSite</seealso>
    let DemoSite = Prefixed_Name(aml, "DemoSite") |> PrefixedName

    /// <summary>
    ///   <para>aml:ExampleInstanceHierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#CAEXFile</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#ExampleInstanceHierarchy">https://w3id.org/i40/aml#ExampleInstanceHierarchy</seealso>
    let ExampleInstanceHierarchy =
        Prefixed_Name(aml, "ExampleInstanceHierarchy") |> PrefixedName

    /// <summary>
    ///   <para>aml:InterfaceClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#InterfaceClass">https://w3id.org/i40/aml#InterfaceClass</seealso>
    let InterfaceClass = Prefixed_Name(aml, "InterfaceClass") |> PrefixedName

    /// <summary>
    ///   <para>aml:refSemanticAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#refSemanticAttribute">https://w3id.org/i40/aml#refSemanticAttribute</seealso>
    let refSemanticAttribute =
        Prefixed_Name(aml, "refSemanticAttribute") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRefPartnerSideA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefPartnerSideA">https://w3id.org/i40/aml#hasRefPartnerSideA</seealso>
    let hasRefPartnerSideA = Prefixed_Name(aml, "hasRefPartnerSideA") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasRefPartnerSideB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefPartnerSideB">https://w3id.org/i40/aml#hasRefPartnerSideB</seealso>
    let hasRefPartnerSideB = Prefixed_Name(aml, "hasRefPartnerSideB") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasRefRoleClassPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefRoleClassPath">https://w3id.org/i40/aml#hasRefRoleClassPath</seealso>
    let hasRefRoleClassPath = Prefixed_Name(aml, "hasRefRoleClassPath") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasRefSemRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefSemRC">https://w3id.org/i40/aml#hasRefSemRC</seealso>
    let hasRefSemRC = Prefixed_Name(aml, "hasRefSemRC") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasRoleClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRoleClass">https://w3id.org/i40/aml#hasRoleClass</seealso>
    let hasRoleClass = Prefixed_Name(aml, "hasRoleClass") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasProject">https://w3id.org/i40/aml#hasProject</seealso>
    let hasProject = Prefixed_Name(aml, "hasProject") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasProjectTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasProjectTitle">https://w3id.org/i40/aml#hasProjectTitle</seealso>
    let hasProjectTitle = Prefixed_Name(aml, "hasProjectTitle") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRefBaseClassPathRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefBaseClassPathRC">https://w3id.org/i40/aml#hasRefBaseClassPathRC</seealso>
    let hasRefBaseClassPathRC =
        Prefixed_Name(aml, "hasRefBaseClassPathRC") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRefBaseClassPathSUC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefBaseClassPathSUC">https://w3id.org/i40/aml#hasRefBaseClassPathSUC</seealso>
    let hasRefBaseClassPathSUC =
        Prefixed_Name(aml, "hasRefBaseClassPathSUC") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasICID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique ID for the Interface Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasICID">https://w3id.org/i40/aml#hasICID</seealso>
    let hasICID = Prefixed_Name(aml, "hasICID") |> PrefixedName
    /// <summary>
    ///   <para>aml:lastWritingDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#lastWritingDateTime">https://w3id.org/i40/aml#lastWritingDateTime</seealso>
    let lastWritingDateTime = Prefixed_Name(aml, "lastWritingDateTime") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasIDIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasIDIE">https://w3id.org/i40/aml#hasIDIE</seealso>
    let hasIDIE = Prefixed_Name(aml, "hasIDIE") |> PrefixedName
    /// <summary>
    ///   <para>aml:ExternalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#ExternalReference">https://w3id.org/i40/aml#ExternalReference</seealso>
    let ExternalReference = Prefixed_Name(aml, "ExternalReference") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasAttributeRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttributeRC">https://w3id.org/i40/aml#hasAttributeRC</seealso>
    let hasAttributeRC = Prefixed_Name(aml, "hasAttributeRC") |> PrefixedName
    /// <summary>
    ///   <para>aml:ExternalInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#ExternalInterface">https://w3id.org/i40/aml#ExternalInterface</seealso>
    let ExternalInterface = Prefixed_Name(aml, "ExternalInterface") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasAMLVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAMLVersion">https://w3id.org/i40/aml#hasAMLVersion</seealso>
    let hasAMLVersion = Prefixed_Name(aml, "hasAMLVersion") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasWriterVendorURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasWriterVendorURL">https://w3id.org/i40/aml#hasWriterVendorURL</seealso>
    let hasWriterVendorURL = Prefixed_Name(aml, "hasWriterVendorURL") |> PrefixedName
    /// <summary>
    ///   <para>aml:numerical_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#numerical_value">https://w3id.org/i40/aml#numerical_value</seealso>
    let numerical_value = Prefixed_Name(aml, "numerical_value") |> PrefixedName
    /// <summary>
    ///   <para>aml:DemoArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#InternalElement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#DemoArea">https://w3id.org/i40/aml#DemoArea</seealso>
    let DemoArea = Prefixed_Name(aml, "DemoArea") |> PrefixedName
    /// <summary>
    ///   <para>aml:InternalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#InternalElement">https://w3id.org/i40/aml#InternalElement</seealso>
    let InternalElement = Prefixed_Name(aml, "InternalElement") |> PrefixedName

    /// <summary>
    ///   <para>aml:AdditionalInformation1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:i40/aml#AdditionalInformation</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#AdditionalInformation1">https://w3id.org/i40/aml#AdditionalInformation1</seealso>
    let AdditionalInformation1 =
        Prefixed_Name(aml, "AdditionalInformation1") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasWriterVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasWriterVersion">https://w3id.org/i40/aml#hasWriterVersion</seealso>
    let hasWriterVersion = Prefixed_Name(aml, "hasWriterVersion") |> PrefixedName
    /// <summary>
    ///   <para>aml:NE150DemoProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:i40/aml#InstanceHierarchy</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#NE150DemoProject">https://w3id.org/i40/aml#NE150DemoProject</seealso>
    let NE150DemoProject = Prefixed_Name(aml, "NE150DemoProject") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasWriterId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasWriterId">https://w3id.org/i40/aml#hasWriterId</seealso>
    let hasWriterId = Prefixed_Name(aml, "hasWriterId") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasVersionSUC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasVersionSUC">https://w3id.org/i40/aml#hasVersionSUC</seealso>
    let hasVersionSUC = Prefixed_Name(aml, "hasVersionSUC") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasAttributeDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttributeDataType">https://w3id.org/i40/aml#hasAttributeDataType</seealso>
    let hasAttributeDataType =
        Prefixed_Name(aml, "hasAttributeDataType") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasNameFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasNameFile">https://w3id.org/i40/aml#hasNameFile</seealso>
    let hasNameFile = Prefixed_Name(aml, "hasNameFile") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasSupportedRoleClassSUC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasSupportedRoleClassSUC">https://w3id.org/i40/aml#hasSupportedRoleClassSUC</seealso>
    let hasSupportedRoleClassSUC =
        Prefixed_Name(aml, "hasSupportedRoleClassSUC") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasAttributeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttributeDescription">https://w3id.org/i40/aml#hasAttributeDescription</seealso>
    let hasAttributeDescription =
        Prefixed_Name(aml, "hasAttributeDescription") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasNameAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasNameAttribute">https://w3id.org/i40/aml#hasNameAttribute</seealso>
    let hasNameAttribute = Prefixed_Name(aml, "hasNameAttribute") |> PrefixedName

    /// <summary>
    ///   <para>aml:GMA6.16BeispielPIDVersion2.97</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:i40/aml#CAEXFile</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#GMA6.16BeispielPIDVersion2.97">https://w3id.org/i40/aml#GMA6.16BeispielPIDVersion2.97</seealso>
    let ``GMA6.16BeispielPIDVersion2.97`` =
        Prefixed_Name(aml, "GMA6.16BeispielPIDVersion2.97") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasSchemaVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasSchemaVersion">https://w3id.org/i40/aml#hasSchemaVersion</seealso>
    let hasSchemaVersion = Prefixed_Name(aml, "hasSchemaVersion") |> PrefixedName
    /// <summary>
    ///   <para>aml:InstanceHierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#InstanceHierarchy">https://w3id.org/i40/aml#InstanceHierarchy</seealso>
    let InstanceHierarchy = Prefixed_Name(aml, "InstanceHierarchy") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRoleRequirementIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRoleRequirementIE">https://w3id.org/i40/aml#hasRoleRequirementIE</seealso>
    let hasRoleRequirementIE =
        Prefixed_Name(aml, "hasRoleRequirementIE") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRoleRequirementSUC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRoleRequirementSUC">https://w3id.org/i40/aml#hasRoleRequirementSUC</seealso>
    let hasRoleRequirementSUC =
        Prefixed_Name(aml, "hasRoleRequirementSUC") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasAttributeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttributeValue">https://w3id.org/i40/aml#hasAttributeValue</seealso>
    let hasAttributeValue = Prefixed_Name(aml, "hasAttributeValue") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasProjectId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasProjectId">https://w3id.org/i40/aml#hasProjectId</seealso>
    let hasProjectId = Prefixed_Name(aml, "hasProjectId") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasRefBaseClassPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefBaseClassPath">https://w3id.org/i40/aml#hasRefBaseClassPath</seealso>
    let hasRefBaseClassPath = Prefixed_Name(aml, "hasRefBaseClassPath") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRefBaseRoleClassPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefBaseRoleClassPath">https://w3id.org/i40/aml#hasRefBaseRoleClassPath</seealso>
    let hasRefBaseRoleClassPath =
        Prefixed_Name(aml, "hasRefBaseRoleClassPath") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRefBaseSystemUnitPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefBaseSystemUnitPath">https://w3id.org/i40/aml#hasRefBaseSystemUnitPath</seealso>
    let hasRefBaseSystemUnitPath =
        Prefixed_Name(aml, "hasRefBaseSystemUnitPath") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasRefSemAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRefSemAttribute">https://w3id.org/i40/aml#hasRefSemAttribute</seealso>
    let hasRefSemAttribute = Prefixed_Name(aml, "hasRefSemAttribute") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasSemanticRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasSemanticRef">https://w3id.org/i40/aml#hasSemanticRef</seealso>
    let hasSemanticRef = Prefixed_Name(aml, "hasSemanticRef") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasRoleClassLib</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRoleClassLib">https://w3id.org/i40/aml#hasRoleClassLib</seealso>
    let hasRoleClassLib = Prefixed_Name(aml, "hasRoleClassLib") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasRoleRequeriment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasRoleRequeriment">https://w3id.org/i40/aml#hasRoleRequeriment</seealso>
    let hasRoleRequeriment = Prefixed_Name(aml, "hasRoleRequeriment") |> PrefixedName
    /// <summary>
    ///   <para>aml:InterfaceClassLib</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#InterfaceClassLib">https://w3id.org/i40/aml#InterfaceClassLib</seealso>
    let InterfaceClassLib = Prefixed_Name(aml, "InterfaceClassLib") |> PrefixedName
    /// <summary>
    ///   <para>aml:InternalLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#InternalLink">https://w3id.org/i40/aml#InternalLink</seealso>
    let InternalLink = Prefixed_Name(aml, "InternalLink") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttribute">https://w3id.org/i40/aml#hasAttribute</seealso>
    let hasAttribute = Prefixed_Name(aml, "hasAttribute") |> PrefixedName
    /// <summary>
    ///   <para>aml:PCEDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#Attribute</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#PCEDescription">https://w3id.org/i40/aml#PCEDescription</seealso>
    let PCEDescription = Prefixed_Name(aml, "PCEDescription") |> PrefixedName

    /// <summary>
    ///   <para>aml:refBaseSystemUnitPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#refBaseSystemUnitPath">https://w3id.org/i40/aml#refBaseSystemUnitPath</seealso>
    let refBaseSystemUnitPath =
        Prefixed_Name(aml, "refBaseSystemUnitPath") |> PrefixedName

    /// <summary>
    ///   <para>aml:PCEFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#Attribute</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#PCEFunction">https://w3id.org/i40/aml#PCEFunction</seealso>
    let PCEFunction = Prefixed_Name(aml, "PCEFunction") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasExternalInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasExternalInterface">https://w3id.org/i40/aml#hasExternalInterface</seealso>
    let hasExternalInterface =
        Prefixed_Name(aml, "hasExternalInterface") |> PrefixedName

    /// <summary>
    ///   <para>aml:MaxConveyingSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#Attribute</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#MaxConveyingSpeed">https://w3id.org/i40/aml#MaxConveyingSpeed</seealso>
    let MaxConveyingSpeed = Prefixed_Name(aml, "MaxConveyingSpeed") |> PrefixedName

    /// <summary>
    ///   <para>aml:MeasurementRangeStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#Attribute</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#MeasurementRangeStart">https://w3id.org/i40/aml#MeasurementRangeStart</seealso>
    let MeasurementRangeStart =
        Prefixed_Name(aml, "MeasurementRangeStart") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasSystemUnitClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasSystemUnitClass">https://w3id.org/i40/aml#hasSystemUnitClass</seealso>
    let hasSystemUnitClass = Prefixed_Name(aml, "hasSystemUnitClass") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasVersion">https://w3id.org/i40/aml#hasVersion</seealso>
    let hasVersion = Prefixed_Name(aml, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasVersionRCL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasVersionRCL">https://w3id.org/i40/aml#hasVersionRCL</seealso>
    let hasVersionRCL = Prefixed_Name(aml, "hasVersionRCL") |> PrefixedName
    /// <summary>
    ///   <para>aml:isPartOfIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#isPartOfIC">https://w3id.org/i40/aml#isPartOfIC</seealso>
    let isPartOfIC = Prefixed_Name(aml, "isPartOfIC") |> PrefixedName
    /// <summary>
    ///   <para>aml:isPartOfSUC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#isPartOfSUC">https://w3id.org/i40/aml#isPartOfSUC</seealso>
    let isPartOfSUC = Prefixed_Name(aml, "isPartOfSUC") |> PrefixedName
    /// <summary>
    ///   <para>aml:SoftwareSignalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#Attribute</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#SoftwareSignalName">https://w3id.org/i40/aml#SoftwareSignalName</seealso>
    let SoftwareSignalName = Prefixed_Name(aml, "SoftwareSignalName") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasAttributeIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttributeIC">https://w3id.org/i40/aml#hasAttributeIC</seealso>
    let hasAttributeIC = Prefixed_Name(aml, "hasAttributeIC") |> PrefixedName
    /// <summary>
    ///   <para>aml:SystemUnitClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#SystemUnitClass">https://w3id.org/i40/aml#SystemUnitClass</seealso>
    let SystemUnitClass = Prefixed_Name(aml, "SystemUnitClass") |> PrefixedName
    /// <summary>
    ///   <para>aml:SystemUnitClassLib</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#SystemUnitClassLib">https://w3id.org/i40/aml#SystemUnitClassLib</seealso>
    let SystemUnitClassLib = Prefixed_Name(aml, "SystemUnitClassLib") |> PrefixedName
    /// <summary>
    ///   <para>aml:eClassSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#eClassSpecification">https://w3id.org/i40/aml#eClassSpecification</seealso>
    let eClassSpecification = Prefixed_Name(aml, "eClassSpecification") |> PrefixedName
    /// <summary>
    ///   <para>aml:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#contains">https://w3id.org/i40/aml#contains</seealso>
    let contains = Prefixed_Name(aml, "contains") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasAttributeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttributeName">https://w3id.org/i40/aml#hasAttributeName</seealso>
    let hasAttributeName = Prefixed_Name(aml, "hasAttributeName") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasAttributeSUC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasAttributeSUC">https://w3id.org/i40/aml#hasAttributeSUC</seealso>
    let hasAttributeSUC = Prefixed_Name(aml, "hasAttributeSUC") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasClassificationClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasClassificationClass">https://w3id.org/i40/aml#hasClassificationClass</seealso>
    let hasClassificationClass =
        Prefixed_Name(aml, "hasClassificationClass") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasBaseSystemUnitClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasBaseSystemUnitClass">https://w3id.org/i40/aml#hasBaseSystemUnitClass</seealso>
    let hasBaseSystemUnitClass =
        Prefixed_Name(aml, "hasBaseSystemUnitClass") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasExternalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasExternalReference">https://w3id.org/i40/aml#hasExternalReference</seealso>
    let hasExternalReference =
        Prefixed_Name(aml, "hasExternalReference") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasExternalReferenceAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasExternalReferenceAlias">https://w3id.org/i40/aml#hasExternalReferenceAlias</seealso>
    let hasExternalReferenceAlias =
        Prefixed_Name(aml, "hasExternalReferenceAlias") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasIRDIeClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasIRDIeClass">https://w3id.org/i40/aml#hasIRDIeClass</seealso>
    let hasIRDIeClass = Prefixed_Name(aml, "hasIRDIeClass") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInterface">https://w3id.org/i40/aml#hasInterface</seealso>
    let hasInterface = Prefixed_Name(aml, "hasInterface") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasInterfaceClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInterfaceClass">https://w3id.org/i40/aml#hasInterfaceClass</seealso>
    let hasInterfaceClass = Prefixed_Name(aml, "hasInterfaceClass") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasInterfaceSUC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInterfaceSUC">https://w3id.org/i40/aml#hasInterfaceSUC</seealso>
    let hasInterfaceSUC = Prefixed_Name(aml, "hasInterfaceSUC") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasExternalReferencePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasExternalReferencePath">https://w3id.org/i40/aml#hasExternalReferencePath</seealso>
    let hasExternalReferencePath =
        Prefixed_Name(aml, "hasExternalReferencePath") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasInstanceHierarchy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInstanceHierarchy">https://w3id.org/i40/aml#hasInstanceHierarchy</seealso>
    let hasInstanceHierarchy =
        Prefixed_Name(aml, "hasInstanceHierarchy") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasInterfaceClassLib</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInterfaceClassLib">https://w3id.org/i40/aml#hasInterfaceClassLib</seealso>
    let hasInterfaceClassLib =
        Prefixed_Name(aml, "hasInterfaceClassLib") |> PrefixedName

    /// <summary>
    ///   <para>aml:hasInterfaceIE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInterfaceIE">https://w3id.org/i40/aml#hasInterfaceIE</seealso>
    let hasInterfaceIE = Prefixed_Name(aml, "hasInterfaceIE") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasInterfaceRC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInterfaceRC">https://w3id.org/i40/aml#hasInterfaceRC</seealso>
    let hasInterfaceRC = Prefixed_Name(aml, "hasInterfaceRC") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasInternalLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasInternalLink">https://w3id.org/i40/aml#hasInternalLink</seealso>
    let hasInternalLink = Prefixed_Name(aml, "hasInternalLink") |> PrefixedName
    /// <summary>
    ///   <para>aml:hasWriterVendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#hasWriterVendor">https://w3id.org/i40/aml#hasWriterVendor</seealso>
    let hasWriterVendor = Prefixed_Name(aml, "hasWriterVendor") |> PrefixedName
    /// <summary>
    ///   <para>aml:AttValue1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#AttValue1">https://w3id.org/i40/aml#AttValue1</seealso>
    let AttValue1 = Prefixed_Name(aml, "AttValue1") |> PrefixedName
    /// <summary>
    ///   <para>aml:DemoEnterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:i40/aml#InternalElement</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/i40/aml#DemoEnterprise">https://w3id.org/i40/aml#DemoEnterprise</seealso>
    let DemoEnterprise = Prefixed_Name(aml, "DemoEnterprise") |> PrefixedName
