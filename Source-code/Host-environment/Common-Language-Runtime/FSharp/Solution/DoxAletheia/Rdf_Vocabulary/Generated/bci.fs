namespace https.w3id.org.BCI_ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bci =
    let _namespace_iri = Namespace_Iri bci |> NamespaceIRI
    /// <summary>
    ///   <para>bci:hasDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDescriptor">https://w3id.org/BCI-ontology#hasDescriptor</seealso>
    let hasDescriptor = Prefixed_Name(bci, "hasDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>bci:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Subject">https://w3id.org/BCI-ontology#Subject</seealso>
    let Subject = Prefixed_Name(bci, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>bci:isPlayoutInstantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isPlayoutInstantOf">https://w3id.org/BCI-ontology#isPlayoutInstantOf</seealso>
    let isPlayoutInstantOf = Prefixed_Name(bci, "isPlayoutInstantOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:Action.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Action.POWDER">https://w3id.org/BCI-ontology#Action.POWDER</seealso>
    let ``Action.POWDER`` = Prefixed_Name(bci, "Action.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:Descriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Descriptor">https://w3id.org/BCI-ontology#Descriptor</seealso>
    let Descriptor = Prefixed_Name(bci, "Descriptor") |> PrefixedName
    /// <summary>
    ///   <para>bci:isProxyFor.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isProxyFor.POWDER">https://w3id.org/BCI-ontology#isProxyFor.POWDER</seealso>
    let ``isProxyFor.POWDER`` = Prefixed_Name(bci, "isProxyFor.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:DeviceChannelingSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DeviceChannelingSpec.POWDER">https://w3id.org/BCI-ontology#DeviceChannelingSpec.POWDER</seealso>
    let ``DeviceChannelingSpec.POWDER`` =
        Prefixed_Name(bci, "DeviceChannelingSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:DeviceSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DeviceSpec.POWDER">https://w3id.org/BCI-ontology#DeviceSpec.POWDER</seealso>
    let ``DeviceSpec.POWDER`` = Prefixed_Name(bci, "DeviceSpec.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasTitle">https://w3id.org/BCI-ontology#hasTitle</seealso>
    let hasTitle = Prefixed_Name(bci, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>bci:Collection.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Collection.POWDER">https://w3id.org/BCI-ontology#Collection.POWDER</seealso>
    let ``Collection.POWDER`` = Prefixed_Name(bci, "Collection.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context">https://w3id.org/BCI-ontology#Context</seealso>
    let Context = Prefixed_Name(bci, "Context") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasScene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasScene">https://w3id.org/BCI-ontology#hasScene</seealso>
    let hasScene = Prefixed_Name(bci, "hasScene") |> PrefixedName
    /// <summary>
    ///   <para>bci:Context.Scene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.Scene">https://w3id.org/BCI-ontology#Context.Scene</seealso>
    let ``Context.Scene`` = Prefixed_Name(bci, "Context.Scene") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasLocation">https://w3id.org/BCI-ontology#hasLocation</seealso>
    let hasLocation = Prefixed_Name(bci, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasObject">https://w3id.org/BCI-ontology#hasObject</seealso>
    let hasObject = Prefixed_Name(bci, "hasObject") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasRole">https://w3id.org/BCI-ontology#hasRole</seealso>
    let hasRole = Prefixed_Name(bci, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>bci:Context.Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.Role">https://w3id.org/BCI-ontology#Context.Role</seealso>
    let ``Context.Role`` = Prefixed_Name(bci, "Context.Role") |> PrefixedName
    /// <summary>
    ///   <para>bci:Record.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Record.POWDER">https://w3id.org/BCI-ontology#Record.POWDER</seealso>
    let ``Record.POWDER`` = Prefixed_Name(bci, "Record.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:extendsDeviceChannelingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec">https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec</seealso>
    let extendsDeviceChannelingSpec =
        Prefixed_Name(bci, "extendsDeviceChannelingSpec") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasEndChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasEndChannel">https://w3id.org/BCI-ontology#hasEndChannel</seealso>
    let hasEndChannel = Prefixed_Name(bci, "hasEndChannel") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasNext.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasNext.POWDER">https://w3id.org/BCI-ontology#hasNext.POWDER</seealso>
    let ``hasNext.POWDER`` = Prefixed_Name(bci, "hasNext.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:isValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isValueOf">https://w3id.org/BCI-ontology#isValueOf</seealso>
    let isValueOf = Prefixed_Name(bci, "isValueOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:RecordedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#RecordedData">https://w3id.org/BCI-ontology#RecordedData</seealso>
    let RecordedData = Prefixed_Name(bci, "RecordedData") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasOffset">https://w3id.org/BCI-ontology#hasOffset</seealso>
    let hasOffset = Prefixed_Name(bci, "hasOffset") |> PrefixedName
    /// <summary>
    ///   <para>bci:DataBlock.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DataBlock.POWDER">https://w3id.org/BCI-ontology#DataBlock.POWDER</seealso>
    let ``DataBlock.POWDER`` = Prefixed_Name(bci, "DataBlock.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:DataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DataFormat">https://w3id.org/BCI-ontology#DataFormat</seealso>
    let DataFormat = Prefixed_Name(bci, "DataFormat") |> PrefixedName
    /// <summary>
    ///   <para>bci:DataFormat.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DataFormat.POWDER">https://w3id.org/BCI-ontology#DataFormat.POWDER</seealso>
    let ``DataFormat.POWDER`` = Prefixed_Name(bci, "DataFormat.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasDataBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDataBlock">https://w3id.org/BCI-ontology#hasDataBlock</seealso>
    let hasDataBlock = Prefixed_Name(bci, "hasDataBlock") |> PrefixedName
    /// <summary>
    ///   <para>bci:isReferencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isReferencedBy">https://w3id.org/BCI-ontology#isReferencedBy</seealso>
    let isReferencedBy = Prefixed_Name(bci, "isReferencedBy") |> PrefixedName
    /// <summary>
    ///   <para>bci:Marker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Marker">https://w3id.org/BCI-ontology#Marker</seealso>
    let Marker = Prefixed_Name(bci, "Marker") |> PrefixedName

    /// <summary>
    ///   <para>bci:DataSegment.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DataSegment.POWDER">https://w3id.org/BCI-ontology#DataSegment.POWDER</seealso>
    let ``DataSegment.POWDER`` =
        Prefixed_Name(bci, "DataSegment.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Descriptor.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Descriptor.POWDER">https://w3id.org/BCI-ontology#Descriptor.POWDER</seealso>
    let ``Descriptor.POWDER`` = Prefixed_Name(bci, "Descriptor.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Device">https://w3id.org/BCI-ontology#Device</seealso>
    let Device = Prefixed_Name(bci, "Device") |> PrefixedName
    /// <summary>
    ///   <para>bci:madeRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#madeRecord">https://w3id.org/BCI-ontology#madeRecord</seealso>
    let madeRecord = Prefixed_Name(bci, "madeRecord") |> PrefixedName
    /// <summary>
    ///   <para>bci:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Record">https://w3id.org/BCI-ontology#Record</seealso>
    let Record = Prefixed_Name(bci, "Record") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasDeviceSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDeviceSpec">https://w3id.org/BCI-ontology#hasDeviceSpec</seealso>
    let hasDeviceSpec = Prefixed_Name(bci, "hasDeviceSpec") |> PrefixedName
    /// <summary>
    ///   <para>bci:observes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observes">https://w3id.org/BCI-ontology#observes</seealso>
    let observes = Prefixed_Name(bci, "observes") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasNonChannelData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasNonChannelData">https://w3id.org/BCI-ontology#hasNonChannelData</seealso>
    let hasNonChannelData = Prefixed_Name(bci, "hasNonChannelData") |> PrefixedName
    /// <summary>
    ///   <para>bci:detects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#detects">https://w3id.org/BCI-ontology#detects</seealso>
    let detects = Prefixed_Name(bci, "detects") |> PrefixedName
    /// <summary>
    ///   <para>bci:Device.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Device.POWDER">https://w3id.org/BCI-ontology#Device.POWDER</seealso>
    let ``Device.POWDER`` = Prefixed_Name(bci, "Device.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:extendsChannelingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#extendsChannelingSpec">https://w3id.org/BCI-ontology#extendsChannelingSpec</seealso>
    let extendsChannelingSpec =
        Prefixed_Name(bci, "extendsChannelingSpec") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasNumberOfChannels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasNumberOfChannels">https://w3id.org/BCI-ontology#hasNumberOfChannels</seealso>
    let hasNumberOfChannels = Prefixed_Name(bci, "hasNumberOfChannels") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasChannelData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasChannelData">https://w3id.org/BCI-ontology#hasChannelData</seealso>
    let hasChannelData = Prefixed_Name(bci, "hasChannelData") |> PrefixedName
    /// <summary>
    ///   <para>bci:EegChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegChannel">https://w3id.org/BCI-ontology#EegChannel</seealso>
    let EegChannel = Prefixed_Name(bci, "EegChannel") |> PrefixedName
    /// <summary>
    ///   <para>bci:EegChannel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegChannel.POWDER">https://w3id.org/BCI-ontology#EegChannel.POWDER</seealso>
    let ``EegChannel.POWDER`` = Prefixed_Name(bci, "EegChannel.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:EegDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegDevice">https://w3id.org/BCI-ontology#EegDevice</seealso>
    let EegDevice = Prefixed_Name(bci, "EegDevice") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasEegNonChannelData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasEegNonChannelData">https://w3id.org/BCI-ontology#hasEegNonChannelData</seealso>
    let hasEegNonChannelData =
        Prefixed_Name(bci, "hasEegNonChannelData") |> PrefixedName

    /// <summary>
    ///   <para>bci:EegNonChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegNonChannel">https://w3id.org/BCI-ontology#EegNonChannel</seealso>
    let EegNonChannel = Prefixed_Name(bci, "EegNonChannel") |> PrefixedName
    /// <summary>
    ///   <para>bci:EegRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegRecord">https://w3id.org/BCI-ontology#EegRecord</seealso>
    let EegRecord = Prefixed_Name(bci, "EegRecord") |> PrefixedName
    /// <summary>
    ///   <para>bci:EegDevice.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegDevice.POWDER">https://w3id.org/BCI-ontology#EegDevice.POWDER</seealso>
    let ``EegDevice.POWDER`` = Prefixed_Name(bci, "EegDevice.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:EegModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegModality">https://w3id.org/BCI-ontology#EegModality</seealso>
    let EegModality = Prefixed_Name(bci, "EegModality") |> PrefixedName

    /// <summary>
    ///   <para>bci:EegModality.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegModality.POWDER">https://w3id.org/BCI-ontology#EegModality.POWDER</seealso>
    let ``EegModality.POWDER`` =
        Prefixed_Name(bci, "EegModality.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:EegNonChannel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegNonChannel.POWDER">https://w3id.org/BCI-ontology#EegNonChannel.POWDER</seealso>
    let ``EegNonChannel.POWDER`` =
        Prefixed_Name(bci, "EegNonChannel.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasDataBlock.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDataBlock.POWDER">https://w3id.org/BCI-ontology#hasDataBlock.POWDER</seealso>
    let ``hasDataBlock.POWDER`` =
        Prefixed_Name(bci, "hasDataBlock.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasDataFormat.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDataFormat.POWDER">https://w3id.org/BCI-ontology#hasDataFormat.POWDER</seealso>
    let ``hasDataFormat.POWDER`` =
        Prefixed_Name(bci, "hasDataFormat.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasDateTime.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDateTime.POWDER">https://w3id.org/BCI-ontology#hasDateTime.POWDER</seealso>
    let ``hasDateTime.POWDER`` =
        Prefixed_Name(bci, "hasDateTime.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasDescriptor.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDescriptor.POWDER">https://w3id.org/BCI-ontology#hasDescriptor.POWDER</seealso>
    let ``hasDescriptor.POWDER`` =
        Prefixed_Name(bci, "hasDescriptor.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasDeviceChannelingSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDeviceChannelingSpec.POWDER">https://w3id.org/BCI-ontology#hasDeviceChannelingSpec.POWDER</seealso>
    let ``hasDeviceChannelingSpec.POWDER`` =
        Prefixed_Name(bci, "hasDeviceChannelingSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasDeviceSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDeviceSpec.POWDER">https://w3id.org/BCI-ontology#hasDeviceSpec.POWDER</seealso>
    let ``hasDeviceSpec.POWDER`` =
        Prefixed_Name(bci, "hasDeviceSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasEegChannelData.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasEegChannelData.POWDER">https://w3id.org/BCI-ontology#hasEegChannelData.POWDER</seealso>
    let ``hasEegChannelData.POWDER`` =
        Prefixed_Name(bci, "hasEegChannelData.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasEegNonChannelData.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasEegNonChannelData.POWDER">https://w3id.org/BCI-ontology#hasEegNonChannelData.POWDER</seealso>
    let ``hasEegNonChannelData.POWDER`` =
        Prefixed_Name(bci, "hasEegNonChannelData.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasEndChannel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasEndChannel.POWDER">https://w3id.org/BCI-ontology#hasEndChannel.POWDER</seealso>
    let ``hasEndChannel.POWDER`` =
        Prefixed_Name(bci, "hasEndChannel.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:observationResult.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observationResult.POWDER">https://w3id.org/BCI-ontology#observationResult.POWDER</seealso>
    let ``observationResult.POWDER`` =
        Prefixed_Name(bci, "observationResult.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:observedByDevice.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observedByDevice.POWDER">https://w3id.org/BCI-ontology#observedByDevice.POWDER</seealso>
    let ``observedByDevice.POWDER`` =
        Prefixed_Name(bci, "observedByDevice.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:observedByEegDevice.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observedByEegDevice.POWDER">https://w3id.org/BCI-ontology#observedByEegDevice.POWDER</seealso>
    let ``observedByEegDevice.POWDER`` =
        Prefixed_Name(bci, "observedByEegDevice.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:AccessMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#AccessMethod">https://w3id.org/BCI-ontology#AccessMethod</seealso>
    let AccessMethod = Prefixed_Name(bci, "AccessMethod") |> PrefixedName

    /// <summary>
    ///   <para>bci:AccessMethod.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#AccessMethod.POWDER">https://w3id.org/BCI-ontology#AccessMethod.POWDER</seealso>
    let ``AccessMethod.POWDER`` =
        Prefixed_Name(bci, "AccessMethod.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:AccessMethod.CoAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#AccessMethod.CoAP">https://w3id.org/BCI-ontology#AccessMethod.CoAP</seealso>
    let ``AccessMethod.CoAP`` = Prefixed_Name(bci, "AccessMethod.CoAP") |> PrefixedName

    /// <summary>
    ///   <para>bci:AccessMethod.CoAP.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#AccessMethod.CoAP.POWDER">https://w3id.org/BCI-ontology#AccessMethod.CoAP.POWDER</seealso>
    let ``AccessMethod.CoAP.POWDER`` =
        Prefixed_Name(bci, "AccessMethod.CoAP.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:DataSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DataSegment">https://w3id.org/BCI-ontology#DataSegment</seealso>
    let DataSegment = Prefixed_Name(bci, "DataSegment") |> PrefixedName
    /// <summary>
    ///   <para>bci:Modality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Modality">https://w3id.org/BCI-ontology#Modality</seealso>
    let Modality = Prefixed_Name(bci, "Modality") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasEndTime">https://w3id.org/BCI-ontology#hasEndTime</seealso>
    let hasEndTime = Prefixed_Name(bci, "hasEndTime") |> PrefixedName
    /// <summary>
    ///   <para>bci:isPlayoutOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isPlayoutOf">https://w3id.org/BCI-ontology#isPlayoutOf</seealso>
    let isPlayoutOf = Prefixed_Name(bci, "isPlayoutOf") |> PrefixedName

    /// <summary>
    ///   <para>bci:observedModality.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observedModality.POWDER">https://w3id.org/BCI-ontology#observedModality.POWDER</seealso>
    let ``observedModality.POWDER`` =
        Prefixed_Name(bci, "observedModality.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:observes.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observes.POWDER">https://w3id.org/BCI-ontology#observes.POWDER</seealso>
    let ``observes.POWDER`` = Prefixed_Name(bci, "observes.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:PlayoutInstant.ContextEvent.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent.POWDER">https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent.POWDER</seealso>
    let ``PlayoutInstant.ContextEvent.POWDER`` =
        Prefixed_Name(bci, "PlayoutInstant.ContextEvent.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#">https://w3id.org/BCI-ontology#</seealso>
    let _prefix_iri = Prefixed_Name(bci, "") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasPlayout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasPlayout">https://w3id.org/BCI-ontology#hasPlayout</seealso>
    let hasPlayout = Prefixed_Name(bci, "hasPlayout") |> PrefixedName
    /// <summary>
    ///   <para>bci:Context.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.POWDER">https://w3id.org/BCI-ontology#Context.POWDER</seealso>
    let ``Context.POWDER`` = Prefixed_Name(bci, "Context.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasType">https://w3id.org/BCI-ontology#hasType</seealso>
    let hasType = Prefixed_Name(bci, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasLocator">https://w3id.org/BCI-ontology#hasLocator</seealso>
    let hasLocator = Prefixed_Name(bci, "hasLocator") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasTimeStamp">https://w3id.org/BCI-ontology#hasTimeStamp</seealso>
    let hasTimeStamp = Prefixed_Name(bci, "hasTimeStamp") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasOrdinalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasOrdinalPosition">https://w3id.org/BCI-ontology#hasOrdinalPosition</seealso>
    let hasOrdinalPosition = Prefixed_Name(bci, "hasOrdinalPosition") |> PrefixedName

    /// <summary>
    ///   <para>bci:SamplingRate.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#SamplingRate.POWDER">https://w3id.org/BCI-ontology#SamplingRate.POWDER</seealso>
    let ``SamplingRate.POWDER`` =
        Prefixed_Name(bci, "SamplingRate.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:PlayoutInstant.ContextEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent">https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent</seealso>
    let ``PlayoutInstant.ContextEvent`` =
        Prefixed_Name(bci, "PlayoutInstant.ContextEvent") |> PrefixedName

    /// <summary>
    ///   <para>bci:Context.Role.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.Role.POWDER">https://w3id.org/BCI-ontology#Context.Role.POWDER</seealso>
    let ``Context.Role.POWDER`` =
        Prefixed_Name(bci, "Context.Role.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:AccessMethod.MQTT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#AccessMethod.MQTT">https://w3id.org/BCI-ontology#AccessMethod.MQTT</seealso>
    let ``AccessMethod.MQTT`` = Prefixed_Name(bci, "AccessMethod.MQTT") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDateTime">https://w3id.org/BCI-ontology#hasDateTime</seealso>
    let hasDateTime = Prefixed_Name(bci, "hasDateTime") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasDeviceChannelingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDeviceChannelingSpec">https://w3id.org/BCI-ontology#hasDeviceChannelingSpec</seealso>
    let hasDeviceChannelingSpec =
        Prefixed_Name(bci, "hasDeviceChannelingSpec") |> PrefixedName

    /// <summary>
    ///   <para>bci:StimulusEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#StimulusEvent">https://w3id.org/BCI-ontology#StimulusEvent</seealso>
    let StimulusEvent = Prefixed_Name(bci, "StimulusEvent") |> PrefixedName

    /// <summary>
    ///   <para>bci:StimulusEvent.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#StimulusEvent.POWDER">https://w3id.org/BCI-ontology#StimulusEvent.POWDER</seealso>
    let ``StimulusEvent.POWDER`` =
        Prefixed_Name(bci, "StimulusEvent.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:DeviceSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DeviceSpec">https://w3id.org/BCI-ontology#DeviceSpec</seealso>
    let DeviceSpec = Prefixed_Name(bci, "DeviceSpec") |> PrefixedName
    /// <summary>
    ///   <para>bci:NonChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#NonChannel">https://w3id.org/BCI-ontology#NonChannel</seealso>
    let NonChannel = Prefixed_Name(bci, "NonChannel") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasMQTT.ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasMQTT.ID">https://w3id.org/BCI-ontology#hasMQTT.ID</seealso>
    let ``hasMQTT.ID`` = Prefixed_Name(bci, "hasMQTT.ID") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasMQTT.Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasMQTT.Topic">https://w3id.org/BCI-ontology#hasMQTT.Topic</seealso>
    let ``hasMQTT.Topic`` = Prefixed_Name(bci, "hasMQTT.Topic") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasPlayoutInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasPlayoutInstant">https://w3id.org/BCI-ontology#hasPlayoutInstant</seealso>
    let hasPlayoutInstant = Prefixed_Name(bci, "hasPlayoutInstant") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasConfidence.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasConfidence.POWDER">https://w3id.org/BCI-ontology#hasConfidence.POWDER</seealso>
    let ``hasConfidence.POWDER`` =
        Prefixed_Name(bci, "hasConfidence.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:AccessMethod.RESTful-JSON</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON">https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON</seealso>
    let ``AccessMethod.RESTful_JSON`` =
        Prefixed_Name(bci, "AccessMethod.RESTful-JSON") |> PrefixedName

    /// <summary>
    ///   <para>bci:madeEegRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#madeEegRecord">https://w3id.org/BCI-ontology#madeEegRecord</seealso>
    let madeEegRecord = Prefixed_Name(bci, "madeEegRecord") |> PrefixedName

    /// <summary>
    ///   <para>bci:aspectOfInterest.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#aspectOfInterest.POWDER">https://w3id.org/BCI-ontology#aspectOfInterest.POWDER</seealso>
    let ``aspectOfInterest.POWDER`` =
        Prefixed_Name(bci, "aspectOfInterest.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:AccessMethod.RESTful-JSON.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON.POWDER">https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON.POWDER</seealso>
    let ``AccessMethod.RESTful_JSON.POWDER`` =
        Prefixed_Name(bci, "AccessMethod.RESTful-JSON.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Activity">https://w3id.org/BCI-ontology#Activity</seealso>
    let Activity = Prefixed_Name(bci, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>bci:Activity.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Activity.POWDER">https://w3id.org/BCI-ontology#Activity.POWDER</seealso>
    let ``Activity.POWDER`` = Prefixed_Name(bci, "Activity.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasIntensityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasIntensityLevel">https://w3id.org/BCI-ontology#hasIntensityLevel</seealso>
    let hasIntensityLevel = Prefixed_Name(bci, "hasIntensityLevel") |> PrefixedName
    /// <summary>
    ///   <para>bci:Aspect.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Aspect.POWDER">https://w3id.org/BCI-ontology#Aspect.POWDER</seealso>
    let ``Aspect.POWDER`` = Prefixed_Name(bci, "Aspect.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasLabel">https://w3id.org/BCI-ontology#hasLabel</seealso>
    let hasLabel = Prefixed_Name(bci, "hasLabel") |> PrefixedName
    /// <summary>
    ///   <para>bci:forModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#forModality">https://w3id.org/BCI-ontology#forModality</seealso>
    let forModality = Prefixed_Name(bci, "forModality") |> PrefixedName
    /// <summary>
    ///   <para>bci:isChannelDataOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isChannelDataOf">https://w3id.org/BCI-ontology#isChannelDataOf</seealso>
    let isChannelDataOf = Prefixed_Name(bci, "isChannelDataOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:ChannelingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#ChannelingSpec">https://w3id.org/BCI-ontology#ChannelingSpec</seealso>
    let ChannelingSpec = Prefixed_Name(bci, "ChannelingSpec") |> PrefixedName
    /// <summary>
    ///   <para>bci:CognitiveAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#CognitiveAspect">https://w3id.org/BCI-ontology#CognitiveAspect</seealso>
    let CognitiveAspect = Prefixed_Name(bci, "CognitiveAspect") |> PrefixedName

    /// <summary>
    ///   <para>bci:CognitiveAspect.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#CognitiveAspect.POWDER">https://w3id.org/BCI-ontology#CognitiveAspect.POWDER</seealso>
    let ``CognitiveAspect.POWDER`` =
        Prefixed_Name(bci, "CognitiveAspect.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Collection">https://w3id.org/BCI-ontology#Collection</seealso>
    let Collection = Prefixed_Name(bci, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasSamplingRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSamplingRate">https://w3id.org/BCI-ontology#hasSamplingRate</seealso>
    let hasSamplingRate = Prefixed_Name(bci, "hasSamplingRate") |> PrefixedName
    /// <summary>
    ///   <para>bci:EmotionalAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EmotionalAspect">https://w3id.org/BCI-ontology#EmotionalAspect</seealso>
    let EmotionalAspect = Prefixed_Name(bci, "EmotionalAspect") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSubject">https://w3id.org/BCI-ontology#hasSubject</seealso>
    let hasSubject = Prefixed_Name(bci, "hasSubject") |> PrefixedName
    /// <summary>
    ///   <para>bci:pointsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#pointsTo">https://w3id.org/BCI-ontology#pointsTo</seealso>
    let pointsTo = Prefixed_Name(bci, "pointsTo") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasAction">https://w3id.org/BCI-ontology#hasAction</seealso>
    let hasAction = Prefixed_Name(bci, "hasAction") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasEegChannelData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasEegChannelData">https://w3id.org/BCI-ontology#hasEegChannelData</seealso>
    let hasEegChannelData = Prefixed_Name(bci, "hasEegChannelData") |> PrefixedName
    /// <summary>
    ///   <para>bci:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Aspect">https://w3id.org/BCI-ontology#Aspect</seealso>
    let Aspect = Prefixed_Name(bci, "Aspect") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasModality">https://w3id.org/BCI-ontology#hasModality</seealso>
    let hasModality = Prefixed_Name(bci, "hasModality") |> PrefixedName

    /// <summary>
    ///   <para>bci:isSituationOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isSituationOf.POWDER">https://w3id.org/BCI-ontology#isSituationOf.POWDER</seealso>
    let ``isSituationOf.POWDER`` =
        Prefixed_Name(bci, "isSituationOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Channel">https://w3id.org/BCI-ontology#Channel</seealso>
    let Channel = Prefixed_Name(bci, "Channel") |> PrefixedName
    /// <summary>
    ///   <para>bci:ofAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#ofAspect">https://w3id.org/BCI-ontology#ofAspect</seealso>
    let ofAspect = Prefixed_Name(bci, "ofAspect") |> PrefixedName

    /// <summary>
    ///   <para>bci:DeviceChannelingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DeviceChannelingSpec">https://w3id.org/BCI-ontology#DeviceChannelingSpec</seealso>
    let DeviceChannelingSpec =
        Prefixed_Name(bci, "DeviceChannelingSpec") |> PrefixedName

    /// <summary>
    ///   <para>bci:ofAspect.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#ofAspect.POWDER">https://w3id.org/BCI-ontology#ofAspect.POWDER</seealso>
    let ``ofAspect.POWDER`` = Prefixed_Name(bci, "ofAspect.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:pointsTo.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#pointsTo.POWDER">https://w3id.org/BCI-ontology#pointsTo.POWDER</seealso>
    let ``pointsTo.POWDER`` = Prefixed_Name(bci, "pointsTo.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasEndTime.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasEndTime.POWDER">https://w3id.org/BCI-ontology#hasEndTime.POWDER</seealso>
    let ``hasEndTime.POWDER`` = Prefixed_Name(bci, "hasEndTime.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasIntensityLevel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasIntensityLevel.POWDER">https://w3id.org/BCI-ontology#hasIntensityLevel.POWDER</seealso>
    let ``hasIntensityLevel.POWDER`` =
        Prefixed_Name(bci, "hasIntensityLevel.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasLabel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasLabel.POWDER">https://w3id.org/BCI-ontology#hasLabel.POWDER</seealso>
    let ``hasLabel.POWDER`` = Prefixed_Name(bci, "hasLabel.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasLocation.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasLocation.POWDER">https://w3id.org/BCI-ontology#hasLocation.POWDER</seealso>
    let ``hasLocation.POWDER`` =
        Prefixed_Name(bci, "hasLocation.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasLocator.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasLocator.POWDER">https://w3id.org/BCI-ontology#hasLocator.POWDER</seealso>
    let ``hasLocator.POWDER`` = Prefixed_Name(bci, "hasLocator.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasMQTT.Broker.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasMQTT.Broker.POWDER">https://w3id.org/BCI-ontology#hasMQTT.Broker.POWDER</seealso>
    let ``hasMQTT.Broker.POWDER`` =
        Prefixed_Name(bci, "hasMQTT.Broker.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasMQTT.ID.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasMQTT.ID.POWDER">https://w3id.org/BCI-ontology#hasMQTT.ID.POWDER</seealso>
    let ``hasMQTT.ID.POWDER`` = Prefixed_Name(bci, "hasMQTT.ID.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasMQTT.Topic.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasMQTT.Topic.POWDER">https://w3id.org/BCI-ontology#hasMQTT.Topic.POWDER</seealso>
    let ``hasMQTT.Topic.POWDER`` =
        Prefixed_Name(bci, "hasMQTT.Topic.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasMeasurementProperty.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasMeasurementProperty.POWDER">https://w3id.org/BCI-ontology#hasMeasurementProperty.POWDER</seealso>
    let ``hasMeasurementProperty.POWDER`` =
        Prefixed_Name(bci, "hasMeasurementProperty.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasModality.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasModality.POWDER">https://w3id.org/BCI-ontology#hasModality.POWDER</seealso>
    let ``hasModality.POWDER`` =
        Prefixed_Name(bci, "hasModality.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasModel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasModel.POWDER">https://w3id.org/BCI-ontology#hasModel.POWDER</seealso>
    let ``hasModel.POWDER`` = Prefixed_Name(bci, "hasModel.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasModelIRI.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasModelIRI.POWDER">https://w3id.org/BCI-ontology#hasModelIRI.POWDER</seealso>
    let ``hasModelIRI.POWDER`` =
        Prefixed_Name(bci, "hasModelIRI.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Channel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Channel.POWDER">https://w3id.org/BCI-ontology#Channel.POWDER</seealso>
    let ``Channel.POWDER`` = Prefixed_Name(bci, "Channel.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:ChannelingSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#ChannelingSpec.POWDER">https://w3id.org/BCI-ontology#ChannelingSpec.POWDER</seealso>
    let ``ChannelingSpec.POWDER`` =
        Prefixed_Name(bci, "ChannelingSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSituation">https://w3id.org/BCI-ontology#hasSituation</seealso>
    let hasSituation = Prefixed_Name(bci, "hasSituation") |> PrefixedName
    /// <summary>
    ///   <para>bci:Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Interaction">https://w3id.org/BCI-ontology#Interaction</seealso>
    let Interaction = Prefixed_Name(bci, "Interaction") |> PrefixedName
    /// <summary>
    ///   <para>bci:Session</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Session">https://w3id.org/BCI-ontology#Session</seealso>
    let Session = Prefixed_Name(bci, "Session") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSession">https://w3id.org/BCI-ontology#hasSession</seealso>
    let hasSession = Prefixed_Name(bci, "hasSession") |> PrefixedName
    /// <summary>
    ///   <para>bci:Playout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Playout">https://w3id.org/BCI-ontology#Playout</seealso>
    let Playout = Prefixed_Name(bci, "Playout") |> PrefixedName
    /// <summary>
    ///   <para>bci:Context.Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.Object">https://w3id.org/BCI-ontology#Context.Object</seealso>
    let ``Context.Object`` = Prefixed_Name(bci, "Context.Object") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasObjectComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasObjectComponent">https://w3id.org/BCI-ontology#hasObjectComponent</seealso>
    let hasObjectComponent = Prefixed_Name(bci, "hasObjectComponent") |> PrefixedName

    /// <summary>
    ///   <para>bci:Context.ObjectComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.ObjectComponent">https://w3id.org/BCI-ontology#Context.ObjectComponent</seealso>
    let ``Context.ObjectComponent`` =
        Prefixed_Name(bci, "Context.ObjectComponent") |> PrefixedName

    /// <summary>
    ///   <para>bci:Context.Object.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.Object.POWDER">https://w3id.org/BCI-ontology#Context.Object.POWDER</seealso>
    let ``Context.Object.POWDER`` =
        Prefixed_Name(bci, "Context.Object.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Context.ObjectComponent.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.ObjectComponent.POWDER">https://w3id.org/BCI-ontology#Context.ObjectComponent.POWDER</seealso>
    let ``Context.ObjectComponent.POWDER`` =
        Prefixed_Name(bci, "Context.ObjectComponent.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Context.ObjectComponent.Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.ObjectComponent.Event">https://w3id.org/BCI-ontology#Context.ObjectComponent.Event</seealso>
    let ``Context.ObjectComponent.Event`` =
        Prefixed_Name(bci, "Context.ObjectComponent.Event") |> PrefixedName

    /// <summary>
    ///   <para>bci:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#causes">https://w3id.org/BCI-ontology#causes</seealso>
    let causes = Prefixed_Name(bci, "causes") |> PrefixedName

    /// <summary>
    ///   <para>bci:Context.ObjectComponent.Event.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.ObjectComponent.Event.POWDER">https://w3id.org/BCI-ontology#Context.ObjectComponent.Event.POWDER</seealso>
    let ``Context.ObjectComponent.Event.POWDER`` =
        Prefixed_Name(bci, "Context.ObjectComponent.Event.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasPrevious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasPrevious">https://w3id.org/BCI-ontology#hasPrevious</seealso>
    let hasPrevious = Prefixed_Name(bci, "hasPrevious") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasNext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasNext">https://w3id.org/BCI-ontology#hasNext</seealso>
    let hasNext = Prefixed_Name(bci, "hasNext") |> PrefixedName

    /// <summary>
    ///   <para>bci:Context.Scene.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Context.Scene.POWDER">https://w3id.org/BCI-ontology#Context.Scene.POWDER</seealso>
    let ``Context.Scene.POWDER`` =
        Prefixed_Name(bci, "Context.Scene.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:DataBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#DataBlock">https://w3id.org/BCI-ontology#DataBlock</seealso>
    let DataBlock = Prefixed_Name(bci, "DataBlock") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasAccessMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasAccessMethod">https://w3id.org/BCI-ontology#hasAccessMethod</seealso>
    let hasAccessMethod = Prefixed_Name(bci, "hasAccessMethod") |> PrefixedName

    /// <summary>
    ///   <para>bci:RecordedData.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#RecordedData.POWDER">https://w3id.org/BCI-ontology#RecordedData.POWDER</seealso>
    let ``RecordedData.POWDER`` =
        Prefixed_Name(bci, "RecordedData.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasNonChannelData.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasNonChannelData.POWDER">https://w3id.org/BCI-ontology#hasNonChannelData.POWDER</seealso>
    let ``hasNonChannelData.POWDER`` =
        Prefixed_Name(bci, "hasNonChannelData.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasNumberOfChannels.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasNumberOfChannels.POWDER">https://w3id.org/BCI-ontology#hasNumberOfChannels.POWDER</seealso>
    let ``hasNumberOfChannels.POWDER`` =
        Prefixed_Name(bci, "hasNumberOfChannels.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasObject.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasObject.POWDER">https://w3id.org/BCI-ontology#hasObject.POWDER</seealso>
    let ``hasObject.POWDER`` = Prefixed_Name(bci, "hasObject.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasObjectComponent.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasObjectComponent.POWDER">https://w3id.org/BCI-ontology#hasObjectComponent.POWDER</seealso>
    let ``hasObjectComponent.POWDER`` =
        Prefixed_Name(bci, "hasObjectComponent.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasOffset.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasOffset.POWDER">https://w3id.org/BCI-ontology#hasOffset.POWDER</seealso>
    let ``hasOffset.POWDER`` = Prefixed_Name(bci, "hasOffset.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasOrdinalPosition.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasOrdinalPosition.POWDER">https://w3id.org/BCI-ontology#hasOrdinalPosition.POWDER</seealso>
    let ``hasOrdinalPosition.POWDER`` =
        Prefixed_Name(bci, "hasOrdinalPosition.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasPlayout.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasPlayout.POWDER">https://w3id.org/BCI-ontology#hasPlayout.POWDER</seealso>
    let ``hasPlayout.POWDER`` = Prefixed_Name(bci, "hasPlayout.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasPlayoutInstant.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasPlayoutInstant.POWDER">https://w3id.org/BCI-ontology#hasPlayoutInstant.POWDER</seealso>
    let ``hasPlayoutInstant.POWDER`` =
        Prefixed_Name(bci, "hasPlayoutInstant.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasPrevious.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasPrevious.POWDER">https://w3id.org/BCI-ontology#hasPrevious.POWDER</seealso>
    let ``hasPrevious.POWDER`` =
        Prefixed_Name(bci, "hasPrevious.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasRecord.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasRecord.POWDER">https://w3id.org/BCI-ontology#hasRecord.POWDER</seealso>
    let ``hasRecord.POWDER`` = Prefixed_Name(bci, "hasRecord.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasRecordChannelingSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasRecordChannelingSpec.POWDER">https://w3id.org/BCI-ontology#hasRecordChannelingSpec.POWDER</seealso>
    let ``hasRecordChannelingSpec.POWDER`` =
        Prefixed_Name(bci, "hasRecordChannelingSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasRecordSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasRecordSpec.POWDER">https://w3id.org/BCI-ontology#hasRecordSpec.POWDER</seealso>
    let ``hasRecordSpec.POWDER`` =
        Prefixed_Name(bci, "hasRecordSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasRole.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasRole.POWDER">https://w3id.org/BCI-ontology#hasRole.POWDER</seealso>
    let ``hasRole.POWDER`` = Prefixed_Name(bci, "hasRole.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasSampleCount.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSampleCount.POWDER">https://w3id.org/BCI-ontology#hasSampleCount.POWDER</seealso>
    let ``hasSampleCount.POWDER`` =
        Prefixed_Name(bci, "hasSampleCount.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasSamplingRate.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSamplingRate.POWDER">https://w3id.org/BCI-ontology#hasSamplingRate.POWDER</seealso>
    let ``hasSamplingRate.POWDER`` =
        Prefixed_Name(bci, "hasSamplingRate.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasScene.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasScene.POWDER">https://w3id.org/BCI-ontology#hasScene.POWDER</seealso>
    let ``hasScene.POWDER`` = Prefixed_Name(bci, "hasScene.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasSession.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSession.POWDER">https://w3id.org/BCI-ontology#hasSession.POWDER</seealso>
    let ``hasSession.POWDER`` = Prefixed_Name(bci, "hasSession.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasSituation.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSituation.POWDER">https://w3id.org/BCI-ontology#hasSituation.POWDER</seealso>
    let ``hasSituation.POWDER`` =
        Prefixed_Name(bci, "hasSituation.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasStartChannel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasStartChannel.POWDER">https://w3id.org/BCI-ontology#hasStartChannel.POWDER</seealso>
    let ``hasStartChannel.POWDER`` =
        Prefixed_Name(bci, "hasStartChannel.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasStartTime.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasStartTime.POWDER">https://w3id.org/BCI-ontology#hasStartTime.POWDER</seealso>
    let ``hasStartTime.POWDER`` =
        Prefixed_Name(bci, "hasStartTime.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasState.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasState.POWDER">https://w3id.org/BCI-ontology#hasState.POWDER</seealso>
    let ``hasState.POWDER`` = Prefixed_Name(bci, "hasState.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasStimulusEvent.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasStimulusEvent.POWDER">https://w3id.org/BCI-ontology#hasStimulusEvent.POWDER</seealso>
    let ``hasStimulusEvent.POWDER`` =
        Prefixed_Name(bci, "hasStimulusEvent.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasSubject.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSubject.POWDER">https://w3id.org/BCI-ontology#hasSubject.POWDER</seealso>
    let ``hasSubject.POWDER`` = Prefixed_Name(bci, "hasSubject.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasSubjectState.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSubjectState.POWDER">https://w3id.org/BCI-ontology#hasSubjectState.POWDER</seealso>
    let ``hasSubjectState.POWDER`` =
        Prefixed_Name(bci, "hasSubjectState.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasTimeStamp.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasTimeStamp.POWDER">https://w3id.org/BCI-ontology#hasTimeStamp.POWDER</seealso>
    let ``hasTimeStamp.POWDER`` =
        Prefixed_Name(bci, "hasTimeStamp.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasTitle.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasTitle.POWDER">https://w3id.org/BCI-ontology#hasTitle.POWDER</seealso>
    let ``hasTitle.POWDER`` = Prefixed_Name(bci, "hasTitle.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasMQTT.Broker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasMQTT.Broker">https://w3id.org/BCI-ontology#hasMQTT.Broker</seealso>
    let ``hasMQTT.Broker`` = Prefixed_Name(bci, "hasMQTT.Broker") |> PrefixedName

    /// <summary>
    ///   <para>bci:AccessMethod.MQTT.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#AccessMethod.MQTT.POWDER">https://w3id.org/BCI-ontology#AccessMethod.MQTT.POWDER</seealso>
    let ``AccessMethod.MQTT.POWDER`` =
        Prefixed_Name(bci, "AccessMethod.MQTT.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Action">https://w3id.org/BCI-ontology#Action</seealso>
    let Action = Prefixed_Name(bci, "Action") |> PrefixedName

    /// <summary>
    ///   <para>bci:PlayoutInstant.SubjectAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction">https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction</seealso>
    let ``PlayoutInstant.SubjectAction`` =
        Prefixed_Name(bci, "PlayoutInstant.SubjectAction") |> PrefixedName

    /// <summary>
    ///   <para>bci:observedByEegDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observedByEegDevice">https://w3id.org/BCI-ontology#observedByEegDevice</seealso>
    let observedByEegDevice = Prefixed_Name(bci, "observedByEegDevice") |> PrefixedName
    /// <summary>
    ///   <para>bci:EegRecord.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EegRecord.POWDER">https://w3id.org/BCI-ontology#EegRecord.POWDER</seealso>
    let ``EegRecord.POWDER`` = Prefixed_Name(bci, "EegRecord.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:EmotionalAspect.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#EmotionalAspect.POWDER">https://w3id.org/BCI-ontology#EmotionalAspect.POWDER</seealso>
    let ``EmotionalAspect.POWDER`` =
        Prefixed_Name(bci, "EmotionalAspect.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isSituationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isSituationOf">https://w3id.org/BCI-ontology#isSituationOf</seealso>
    let isSituationOf = Prefixed_Name(bci, "isSituationOf") |> PrefixedName

    /// <summary>
    ///   <para>bci:Interaction.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Interaction.POWDER">https://w3id.org/BCI-ontology#Interaction.POWDER</seealso>
    let ``Interaction.POWDER`` =
        Prefixed_Name(bci, "Interaction.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:Marker.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Marker.POWDER">https://w3id.org/BCI-ontology#Marker.POWDER</seealso>
    let ``Marker.POWDER`` = Prefixed_Name(bci, "Marker.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:isModalityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isModalityOf">https://w3id.org/BCI-ontology#isModalityOf</seealso>
    let isModalityOf = Prefixed_Name(bci, "isModalityOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasChannelingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasChannelingSpec">https://w3id.org/BCI-ontology#hasChannelingSpec</seealso>
    let hasChannelingSpec = Prefixed_Name(bci, "hasChannelingSpec") |> PrefixedName
    /// <summary>
    ///   <para>bci:Modality.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Modality.POWDER">https://w3id.org/BCI-ontology#Modality.POWDER</seealso>
    let ``Modality.POWDER`` = Prefixed_Name(bci, "Modality.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Model">https://w3id.org/BCI-ontology#Model</seealso>
    let Model = Prefixed_Name(bci, "Model") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasModelIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasModelIRI">https://w3id.org/BCI-ontology#hasModelIRI</seealso>
    let hasModelIRI = Prefixed_Name(bci, "hasModelIRI") |> PrefixedName
    /// <summary>
    ///   <para>bci:isModelOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isModelOf">https://w3id.org/BCI-ontology#isModelOf</seealso>
    let isModelOf = Prefixed_Name(bci, "isModelOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:ResponseTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#ResponseTag">https://w3id.org/BCI-ontology#ResponseTag</seealso>
    let ResponseTag = Prefixed_Name(bci, "ResponseTag") |> PrefixedName
    /// <summary>
    ///   <para>bci:analizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#analizes">https://w3id.org/BCI-ontology#analizes</seealso>
    let analizes = Prefixed_Name(bci, "analizes") |> PrefixedName
    /// <summary>
    ///   <para>bci:Model.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Model.POWDER">https://w3id.org/BCI-ontology#Model.POWDER</seealso>
    let ``Model.POWDER`` = Prefixed_Name(bci, "Model.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:NeurologicalAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#NeurologicalAspect">https://w3id.org/BCI-ontology#NeurologicalAspect</seealso>
    let NeurologicalAspect = Prefixed_Name(bci, "NeurologicalAspect") |> PrefixedName

    /// <summary>
    ///   <para>bci:NeurologicalAspect.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#NeurologicalAspect.POWDER">https://w3id.org/BCI-ontology#NeurologicalAspect.POWDER</seealso>
    let ``NeurologicalAspect.POWDER`` =
        Prefixed_Name(bci, "NeurologicalAspect.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:NonChannel.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#NonChannel.POWDER">https://w3id.org/BCI-ontology#NonChannel.POWDER</seealso>
    let ``NonChannel.POWDER`` = Prefixed_Name(bci, "NonChannel.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasStartTime">https://w3id.org/BCI-ontology#hasStartTime</seealso>
    let hasStartTime = Prefixed_Name(bci, "hasStartTime") |> PrefixedName
    /// <summary>
    ///   <para>bci:PlayoutInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#PlayoutInstant">https://w3id.org/BCI-ontology#PlayoutInstant</seealso>
    let PlayoutInstant = Prefixed_Name(bci, "PlayoutInstant") |> PrefixedName
    /// <summary>
    ///   <para>bci:Playout.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Playout.POWDER">https://w3id.org/BCI-ontology#Playout.POWDER</seealso>
    let ``Playout.POWDER`` = Prefixed_Name(bci, "Playout.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:PlayoutInstant.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#PlayoutInstant.POWDER">https://w3id.org/BCI-ontology#PlayoutInstant.POWDER</seealso>
    let ``PlayoutInstant.POWDER`` =
        Prefixed_Name(bci, "PlayoutInstant.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:PlayoutInstant.SubjectAction.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction.POWDER">https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction.POWDER</seealso>
    let ``PlayoutInstant.SubjectAction.POWDER`` =
        Prefixed_Name(bci, "PlayoutInstant.SubjectAction.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:ProtocolBuffersDataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat">https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat</seealso>
    let ProtocolBuffersDataFormat =
        Prefixed_Name(bci, "ProtocolBuffersDataFormat") |> PrefixedName

    /// <summary>
    ///   <para>bci:ProtocolBuffersDataFormat.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat.POWDER">https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat.POWDER</seealso>
    let ``ProtocolBuffersDataFormat.POWDER`` =
        Prefixed_Name(bci, "ProtocolBuffersDataFormat.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isRecordOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isRecordOf">https://w3id.org/BCI-ontology#isRecordOf</seealso>
    let isRecordOf = Prefixed_Name(bci, "isRecordOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasSampleCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSampleCount">https://w3id.org/BCI-ontology#hasSampleCount</seealso>
    let hasSampleCount = Prefixed_Name(bci, "hasSampleCount") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasRecordChannelingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasRecordChannelingSpec">https://w3id.org/BCI-ontology#hasRecordChannelingSpec</seealso>
    let hasRecordChannelingSpec =
        Prefixed_Name(bci, "hasRecordChannelingSpec") |> PrefixedName

    /// <summary>
    ///   <para>bci:RecordChannelingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#RecordChannelingSpec">https://w3id.org/BCI-ontology#RecordChannelingSpec</seealso>
    let RecordChannelingSpec =
        Prefixed_Name(bci, "RecordChannelingSpec") |> PrefixedName

    /// <summary>
    ///   <para>bci:observedModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observedModality">https://w3id.org/BCI-ontology#observedModality</seealso>
    let observedModality = Prefixed_Name(bci, "observedModality") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasRecordSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasRecordSpec">https://w3id.org/BCI-ontology#hasRecordSpec</seealso>
    let hasRecordSpec = Prefixed_Name(bci, "hasRecordSpec") |> PrefixedName
    /// <summary>
    ///   <para>bci:RecordSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#RecordSpec">https://w3id.org/BCI-ontology#RecordSpec</seealso>
    let RecordSpec = Prefixed_Name(bci, "RecordSpec") |> PrefixedName
    /// <summary>
    ///   <para>bci:aspectOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#aspectOfInterest">https://w3id.org/BCI-ontology#aspectOfInterest</seealso>
    let aspectOfInterest = Prefixed_Name(bci, "aspectOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>bci:observationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observationResult">https://w3id.org/BCI-ontology#observationResult</seealso>
    let observationResult = Prefixed_Name(bci, "observationResult") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasMeasurementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasMeasurementProperty">https://w3id.org/BCI-ontology#hasMeasurementProperty</seealso>
    let hasMeasurementProperty =
        Prefixed_Name(bci, "hasMeasurementProperty") |> PrefixedName

    /// <summary>
    ///   <para>bci:observedByDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#observedByDevice">https://w3id.org/BCI-ontology#observedByDevice</seealso>
    let observedByDevice = Prefixed_Name(bci, "observedByDevice") |> PrefixedName
    /// <summary>
    ///   <para>bci:includesEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#includesEvent">https://w3id.org/BCI-ontology#includesEvent</seealso>
    let includesEvent = Prefixed_Name(bci, "includesEvent") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasStartChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasStartChannel">https://w3id.org/BCI-ontology#hasStartChannel</seealso>
    let hasStartChannel = Prefixed_Name(bci, "hasStartChannel") |> PrefixedName
    /// <summary>
    ///   <para>bci:extends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#extends">https://w3id.org/BCI-ontology#extends</seealso>
    let extends = Prefixed_Name(bci, "extends") |> PrefixedName

    /// <summary>
    ///   <para>bci:RecordChannelingSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#RecordChannelingSpec.POWDER">https://w3id.org/BCI-ontology#RecordChannelingSpec.POWDER</seealso>
    let ``RecordChannelingSpec.POWDER`` =
        Prefixed_Name(bci, "RecordChannelingSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:RecordSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#RecordSpec.POWDER">https://w3id.org/BCI-ontology#RecordSpec.POWDER</seealso>
    let ``RecordSpec.POWDER`` = Prefixed_Name(bci, "RecordSpec.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasValue">https://w3id.org/BCI-ontology#hasValue</seealso>
    let hasValue = Prefixed_Name(bci, "hasValue") |> PrefixedName

    /// <summary>
    ///   <para>bci:isObservationResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isObservationResultOf">https://w3id.org/BCI-ontology#isObservationResultOf</seealso>
    let isObservationResultOf =
        Prefixed_Name(bci, "isObservationResultOf") |> PrefixedName

    /// <summary>
    ///   <para>bci:isProducedByDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isProducedByDevice">https://w3id.org/BCI-ontology#isProducedByDevice</seealso>
    let isProducedByDevice = Prefixed_Name(bci, "isProducedByDevice") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasDataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasDataFormat">https://w3id.org/BCI-ontology#hasDataFormat</seealso>
    let hasDataFormat = Prefixed_Name(bci, "hasDataFormat") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasConfidence">https://w3id.org/BCI-ontology#hasConfidence</seealso>
    let hasConfidence = Prefixed_Name(bci, "hasConfidence") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasModel">https://w3id.org/BCI-ontology#hasModel</seealso>
    let hasModel = Prefixed_Name(bci, "hasModel") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasState">https://w3id.org/BCI-ontology#hasState</seealso>
    let hasState = Prefixed_Name(bci, "hasState") |> PrefixedName

    /// <summary>
    ///   <para>bci:ResponseTag.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#ResponseTag.POWDER">https://w3id.org/BCI-ontology#ResponseTag.POWDER</seealso>
    let ``ResponseTag.POWDER`` =
        Prefixed_Name(bci, "ResponseTag.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:SamplingRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#SamplingRate">https://w3id.org/BCI-ontology#SamplingRate</seealso>
    let SamplingRate = Prefixed_Name(bci, "SamplingRate") |> PrefixedName
    /// <summary>
    ///   <para>bci:isSessionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isSessionOf">https://w3id.org/BCI-ontology#isSessionOf</seealso>
    let isSessionOf = Prefixed_Name(bci, "isSessionOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasRecord">https://w3id.org/BCI-ontology#hasRecord</seealso>
    let hasRecord = Prefixed_Name(bci, "hasRecord") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasSubjectState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasSubjectState">https://w3id.org/BCI-ontology#hasSubjectState</seealso>
    let hasSubjectState = Prefixed_Name(bci, "hasSubjectState") |> PrefixedName
    /// <summary>
    ///   <para>bci:SubjectState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#SubjectState">https://w3id.org/BCI-ontology#SubjectState</seealso>
    let SubjectState = Prefixed_Name(bci, "SubjectState") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasActivity">https://w3id.org/BCI-ontology#hasActivity</seealso>
    let hasActivity = Prefixed_Name(bci, "hasActivity") |> PrefixedName
    /// <summary>
    ///   <para>bci:Session.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Session.POWDER">https://w3id.org/BCI-ontology#Session.POWDER</seealso>
    let ``Session.POWDER`` = Prefixed_Name(bci, "Session.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:isStimulusEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isStimulusEventOf">https://w3id.org/BCI-ontology#isStimulusEventOf</seealso>
    let isStimulusEventOf = Prefixed_Name(bci, "isStimulusEventOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:StimulusTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#StimulusTag">https://w3id.org/BCI-ontology#StimulusTag</seealso>
    let StimulusTag = Prefixed_Name(bci, "StimulusTag") |> PrefixedName
    /// <summary>
    ///   <para>bci:isProxyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isProxyFor">https://w3id.org/BCI-ontology#isProxyFor</seealso>
    let isProxyFor = Prefixed_Name(bci, "isProxyFor") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasStimulusEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasStimulusEvent">https://w3id.org/BCI-ontology#hasStimulusEvent</seealso>
    let hasStimulusEvent = Prefixed_Name(bci, "hasStimulusEvent") |> PrefixedName

    /// <summary>
    ///   <para>bci:StimulusTag.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#StimulusTag.POWDER">https://w3id.org/BCI-ontology#StimulusTag.POWDER</seealso>
    let ``StimulusTag.POWDER`` =
        Prefixed_Name(bci, "StimulusTag.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isSubjectOf">https://w3id.org/BCI-ontology#isSubjectOf</seealso>
    let isSubjectOf = Prefixed_Name(bci, "isSubjectOf") |> PrefixedName
    /// <summary>
    ///   <para>bci:Subject.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#Subject.POWDER">https://w3id.org/BCI-ontology#Subject.POWDER</seealso>
    let ``Subject.POWDER`` = Prefixed_Name(bci, "Subject.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:SubjectState.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#SubjectState.POWDER">https://w3id.org/BCI-ontology#SubjectState.POWDER</seealso>
    let ``SubjectState.POWDER`` =
        Prefixed_Name(bci, "SubjectState.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:XdfDataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#XdfDataFormat">https://w3id.org/BCI-ontology#XdfDataFormat</seealso>
    let XdfDataFormat = Prefixed_Name(bci, "XdfDataFormat") |> PrefixedName

    /// <summary>
    ///   <para>bci:XdfDataFormat.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#XdfDataFormat.POWDER">https://w3id.org/BCI-ontology#XdfDataFormat.POWDER</seealso>
    let ``XdfDataFormat.POWDER`` =
        Prefixed_Name(bci, "XdfDataFormat.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:analizes.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#analizes.POWDER">https://w3id.org/BCI-ontology#analizes.POWDER</seealso>
    let ``analizes.POWDER`` = Prefixed_Name(bci, "analizes.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:causes.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#causes.POWDER">https://w3id.org/BCI-ontology#causes.POWDER</seealso>
    let ``causes.POWDER`` = Prefixed_Name(bci, "causes.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:detects.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#detects.POWDER">https://w3id.org/BCI-ontology#detects.POWDER</seealso>
    let ``detects.POWDER`` = Prefixed_Name(bci, "detects.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:extends.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#extends.POWDER">https://w3id.org/BCI-ontology#extends.POWDER</seealso>
    let ``extends.POWDER`` = Prefixed_Name(bci, "extends.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:extendsChannelingSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#extendsChannelingSpec.POWDER">https://w3id.org/BCI-ontology#extendsChannelingSpec.POWDER</seealso>
    let ``extendsChannelingSpec.POWDER`` =
        Prefixed_Name(bci, "extendsChannelingSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:extendsDeviceChannelingSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec.POWDER">https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec.POWDER</seealso>
    let ``extendsDeviceChannelingSpec.POWDER`` =
        Prefixed_Name(bci, "extendsDeviceChannelingSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:forModality.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#forModality.POWDER">https://w3id.org/BCI-ontology#forModality.POWDER</seealso>
    let ``forModality.POWDER`` =
        Prefixed_Name(bci, "forModality.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasAccessMethod.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasAccessMethod.POWDER">https://w3id.org/BCI-ontology#hasAccessMethod.POWDER</seealso>
    let ``hasAccessMethod.POWDER`` =
        Prefixed_Name(bci, "hasAccessMethod.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasAction.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasAction.POWDER">https://w3id.org/BCI-ontology#hasAction.POWDER</seealso>
    let ``hasAction.POWDER`` = Prefixed_Name(bci, "hasAction.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasActivity.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasActivity.POWDER">https://w3id.org/BCI-ontology#hasActivity.POWDER</seealso>
    let ``hasActivity.POWDER`` =
        Prefixed_Name(bci, "hasActivity.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasChannelData.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasChannelData.POWDER">https://w3id.org/BCI-ontology#hasChannelData.POWDER</seealso>
    let ``hasChannelData.POWDER`` =
        Prefixed_Name(bci, "hasChannelData.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasChannelingSpec.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasChannelingSpec.POWDER">https://w3id.org/BCI-ontology#hasChannelingSpec.POWDER</seealso>
    let ``hasChannelingSpec.POWDER`` =
        Prefixed_Name(bci, "hasChannelingSpec.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:hasType.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasType.POWDER">https://w3id.org/BCI-ontology#hasType.POWDER</seealso>
    let ``hasType.POWDER`` = Prefixed_Name(bci, "hasType.POWDER") |> PrefixedName
    /// <summary>
    ///   <para>bci:hasValue.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#hasValue.POWDER">https://w3id.org/BCI-ontology#hasValue.POWDER</seealso>
    let ``hasValue.POWDER`` = Prefixed_Name(bci, "hasValue.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:includesEvent.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#includesEvent.POWDER">https://w3id.org/BCI-ontology#includesEvent.POWDER</seealso>
    let ``includesEvent.POWDER`` =
        Prefixed_Name(bci, "includesEvent.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isChannelDataOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isChannelDataOf.POWDER">https://w3id.org/BCI-ontology#isChannelDataOf.POWDER</seealso>
    let ``isChannelDataOf.POWDER`` =
        Prefixed_Name(bci, "isChannelDataOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isEegChannelDataOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isEegChannelDataOf">https://w3id.org/BCI-ontology#isEegChannelDataOf</seealso>
    let isEegChannelDataOf = Prefixed_Name(bci, "isEegChannelDataOf") |> PrefixedName

    /// <summary>
    ///   <para>bci:isEegChannelDataOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isEegChannelDataOf.POWDER">https://w3id.org/BCI-ontology#isEegChannelDataOf.POWDER</seealso>
    let ``isEegChannelDataOf.POWDER`` =
        Prefixed_Name(bci, "isEegChannelDataOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isModalityOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isModalityOf.POWDER">https://w3id.org/BCI-ontology#isModalityOf.POWDER</seealso>
    let ``isModalityOf.POWDER`` =
        Prefixed_Name(bci, "isModalityOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isModelOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isModelOf.POWDER">https://w3id.org/BCI-ontology#isModelOf.POWDER</seealso>
    let ``isModelOf.POWDER`` = Prefixed_Name(bci, "isModelOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isObservationResultOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isObservationResultOf.POWDER">https://w3id.org/BCI-ontology#isObservationResultOf.POWDER</seealso>
    let ``isObservationResultOf.POWDER`` =
        Prefixed_Name(bci, "isObservationResultOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isPlayoutInstantOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isPlayoutInstantOf.POWDER">https://w3id.org/BCI-ontology#isPlayoutInstantOf.POWDER</seealso>
    let ``isPlayoutInstantOf.POWDER`` =
        Prefixed_Name(bci, "isPlayoutInstantOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isPlayoutOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isPlayoutOf.POWDER">https://w3id.org/BCI-ontology#isPlayoutOf.POWDER</seealso>
    let ``isPlayoutOf.POWDER`` =
        Prefixed_Name(bci, "isPlayoutOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isProducedByDevice.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isProducedByDevice.POWDER">https://w3id.org/BCI-ontology#isProducedByDevice.POWDER</seealso>
    let ``isProducedByDevice.POWDER`` =
        Prefixed_Name(bci, "isProducedByDevice.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isRecordOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isRecordOf.POWDER">https://w3id.org/BCI-ontology#isRecordOf.POWDER</seealso>
    let ``isRecordOf.POWDER`` = Prefixed_Name(bci, "isRecordOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isReferencedBy.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isReferencedBy.POWDER">https://w3id.org/BCI-ontology#isReferencedBy.POWDER</seealso>
    let ``isReferencedBy.POWDER`` =
        Prefixed_Name(bci, "isReferencedBy.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isSessionOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isSessionOf.POWDER">https://w3id.org/BCI-ontology#isSessionOf.POWDER</seealso>
    let ``isSessionOf.POWDER`` =
        Prefixed_Name(bci, "isSessionOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isStimulusEventOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isStimulusEventOf.POWDER">https://w3id.org/BCI-ontology#isStimulusEventOf.POWDER</seealso>
    let ``isStimulusEventOf.POWDER`` =
        Prefixed_Name(bci, "isStimulusEventOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isSubjectOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isSubjectOf.POWDER">https://w3id.org/BCI-ontology#isSubjectOf.POWDER</seealso>
    let ``isSubjectOf.POWDER`` =
        Prefixed_Name(bci, "isSubjectOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:isValueOf.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#isValueOf.POWDER">https://w3id.org/BCI-ontology#isValueOf.POWDER</seealso>
    let ``isValueOf.POWDER`` = Prefixed_Name(bci, "isValueOf.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:madeEegRecord.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#madeEegRecord.POWDER">https://w3id.org/BCI-ontology#madeEegRecord.POWDER</seealso>
    let ``madeEegRecord.POWDER`` =
        Prefixed_Name(bci, "madeEegRecord.POWDER") |> PrefixedName

    /// <summary>
    ///   <para>bci:madeRecord.POWDER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/BCI-ontology#madeRecord.POWDER">https://w3id.org/BCI-ontology#madeRecord.POWDER</seealso>
    let ``madeRecord.POWDER`` = Prefixed_Name(bci, "madeRecord.POWDER") |> PrefixedName
