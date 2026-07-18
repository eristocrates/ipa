namespace https.w3id.org.BCI_ontology.hash

open DoxAletheia.Rdf_Vocabulary

module bci =
    let _namespace_name = "https://w3id.org/BCI-ontology#"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod"></see>
    /// </summary>
    let AccessMethod =
        Namespaced_IRI.parse _namespace_name "AccessMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLocator"></see>
    /// </summary>
    let hasLocator = Namespaced_IRI.parse _namespace_name "hasLocator" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasType"></see>
    /// </summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.POWDER"></see>
    /// </summary>
    let ``AccessMethod.POWDER`` =
        Namespaced_IRI.parse _namespace_name "AccessMethod.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.CoAP"></see>
    /// </summary>
    let ``AccessMethod.CoAP`` =
        Namespaced_IRI.parse _namespace_name "AccessMethod.CoAP" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.CoAP.POWDER"></see>
    /// </summary>
    let ``AccessMethod.CoAP.POWDER`` =
        Namespaced_IRI.parse _namespace_name "AccessMethod.CoAP.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.MQTT"></see>
    /// </summary>
    let ``AccessMethod.MQTT`` =
        Namespaced_IRI.parse _namespace_name "AccessMethod.MQTT" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.Broker"></see>
    /// </summary>
    let ``hasMQTT.Broker`` =
        Namespaced_IRI.parse _namespace_name "hasMQTT.Broker" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.ID"></see>
    /// </summary>
    let ``hasMQTT.ID`` =
        Namespaced_IRI.parse _namespace_name "hasMQTT.ID" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.Topic"></see>
    /// </summary>
    let ``hasMQTT.Topic`` =
        Namespaced_IRI.parse _namespace_name "hasMQTT.Topic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.MQTT.POWDER"></see>
    /// </summary>
    let ``AccessMethod.MQTT.POWDER`` =
        Namespaced_IRI.parse _namespace_name "AccessMethod.MQTT.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON"></see>
    /// </summary>
    let ``AccessMethod.RESTful-JSON`` =
        Namespaced_IRI.parse _namespace_name "AccessMethod.RESTful-JSON" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON.POWDER"></see>
    /// </summary>
    let ``AccessMethod.RESTful-JSON.POWDER`` =
        Namespaced_IRI.parse _namespace_name "AccessMethod.RESTful-JSON.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPlayoutInstant"></see>
    /// </summary>
    let hasPlayoutInstant =
        Namespaced_IRI.parse _namespace_name "hasPlayoutInstant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction"></see>
    /// </summary>
    let ``PlayoutInstant.SubjectAction`` =
        Namespaced_IRI.parse _namespace_name "PlayoutInstant.SubjectAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Action.POWDER"></see>
    /// </summary>
    let ``Action.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Action.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Activity"></see>
    /// </summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDescriptor"></see>
    /// </summary>
    let hasDescriptor =
        Namespaced_IRI.parse _namespace_name "hasDescriptor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Descriptor"></see>
    /// </summary>
    let Descriptor = Namespaced_IRI.parse _namespace_name "Descriptor" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasAction"></see>
    /// </summary>
    let hasAction = Namespaced_IRI.parse _namespace_name "hasAction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Activity.POWDER"></see>
    /// </summary>
    let ``Activity.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Activity.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Aspect"></see>
    /// </summary>
    let Aspect = Namespaced_IRI.parse _namespace_name "Aspect" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Modality"></see>
    /// </summary>
    let Modality = Namespaced_IRI.parse _namespace_name "Modality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModality"></see>
    /// </summary>
    let hasModality =
        Namespaced_IRI.parse _namespace_name "hasModality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasIntensityLevel"></see>
    /// </summary>
    let hasIntensityLevel =
        Namespaced_IRI.parse _namespace_name "hasIntensityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Aspect.POWDER"></see>
    /// </summary>
    let ``Aspect.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Aspect.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Channel"></see>
    /// </summary>
    let Channel = Namespaced_IRI.parse _namespace_name "Channel" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLabel"></see>
    /// </summary>
    let hasLabel = Namespaced_IRI.parse _namespace_name "hasLabel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#forModality"></see>
    /// </summary>
    let forModality =
        Namespaced_IRI.parse _namespace_name "forModality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ofAspect"></see>
    /// </summary>
    let ofAspect = Namespaced_IRI.parse _namespace_name "ofAspect" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DeviceChannelingSpec"></see>
    /// </summary>
    let DeviceChannelingSpec =
        Namespaced_IRI.parse _namespace_name "DeviceChannelingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isChannelDataOf"></see>
    /// </summary>
    let isChannelDataOf =
        Namespaced_IRI.parse _namespace_name "isChannelDataOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Channel.POWDER"></see>
    /// </summary>
    let ``Channel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Channel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ChannelingSpec"></see>
    /// </summary>
    let ChannelingSpec =
        Namespaced_IRI.parse _namespace_name "ChannelingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ChannelingSpec.POWDER"></see>
    /// </summary>
    let ``ChannelingSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "ChannelingSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#CognitiveAspect"></see>
    /// </summary>
    let CognitiveAspect =
        Namespaced_IRI.parse _namespace_name "CognitiveAspect" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#CognitiveAspect.POWDER"></see>
    /// </summary>
    let ``CognitiveAspect.POWDER`` =
        Namespaced_IRI.parse _namespace_name "CognitiveAspect.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Collection"></see>
    /// </summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSituation"></see>
    /// </summary>
    let hasSituation =
        Namespaced_IRI.parse _namespace_name "hasSituation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Interaction"></see>
    /// </summary>
    let Interaction =
        Namespaced_IRI.parse _namespace_name "Interaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasTitle"></see>
    /// </summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Session"></see>
    /// </summary>
    let Session = Namespaced_IRI.parse _namespace_name "Session" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Collection.POWDER"></see>
    /// </summary>
    let ``Collection.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Collection.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context"></see>
    /// </summary>
    let Context = Namespaced_IRI.parse _namespace_name "Context" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSession"></see>
    /// </summary>
    let hasSession = Namespaced_IRI.parse _namespace_name "hasSession" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasScene"></see>
    /// </summary>
    let hasScene = Namespaced_IRI.parse _namespace_name "hasScene" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Scene"></see>
    /// </summary>
    let ``Context.Scene`` =
        Namespaced_IRI.parse _namespace_name "Context.Scene" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPlayout"></see>
    /// </summary>
    let hasPlayout = Namespaced_IRI.parse _namespace_name "hasPlayout" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Playout"></see>
    /// </summary>
    let Playout = Namespaced_IRI.parse _namespace_name "Playout" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLocation"></see>
    /// </summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.POWDER"></see>
    /// </summary>
    let ``Context.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Context.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Object"></see>
    /// </summary>
    let ``Context.Object`` =
        Namespaced_IRI.parse _namespace_name "Context.Object" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasObject"></see>
    /// </summary>
    let hasObject = Namespaced_IRI.parse _namespace_name "hasObject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasObjectComponent"></see>
    /// </summary>
    let hasObjectComponent =
        Namespaced_IRI.parse _namespace_name "hasObjectComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.ObjectComponent"></see>
    /// </summary>
    let ``Context.ObjectComponent`` =
        Namespaced_IRI.parse _namespace_name "Context.ObjectComponent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRole"></see>
    /// </summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Role"></see>
    /// </summary>
    let ``Context.Role`` =
        Namespaced_IRI.parse _namespace_name "Context.Role" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Object.POWDER"></see>
    /// </summary>
    let ``Context.Object.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Context.Object.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.ObjectComponent.POWDER"></see>
    /// </summary>
    let ``Context.ObjectComponent.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Context.ObjectComponent.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.ObjectComponent.Event"></see>
    /// </summary>
    let ``Context.ObjectComponent.Event`` =
        Namespaced_IRI.parse _namespace_name "Context.ObjectComponent.Event" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#causes"></see>
    /// </summary>
    let causes = Namespaced_IRI.parse _namespace_name "causes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent"></see>
    /// </summary>
    let ``PlayoutInstant.ContextEvent`` =
        Namespaced_IRI.parse _namespace_name "PlayoutInstant.ContextEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.ObjectComponent.Event.POWDER"></see>
    /// </summary>
    let ``Context.ObjectComponent.Event.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Context.ObjectComponent.Event.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Role.POWDER"></see>
    /// </summary>
    let ``Context.Role.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Context.Role.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPrevious"></see>
    /// </summary>
    let hasPrevious =
        Namespaced_IRI.parse _namespace_name "hasPrevious" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNext"></see>
    /// </summary>
    let hasNext = Namespaced_IRI.parse _namespace_name "hasNext" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Scene.POWDER"></see>
    /// </summary>
    let ``Context.Scene.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Context.Scene.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataBlock"></see>
    /// </summary>
    let DataBlock = Namespaced_IRI.parse _namespace_name "DataBlock" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasTimeStamp"></see>
    /// </summary>
    let hasTimeStamp =
        Namespaced_IRI.parse _namespace_name "hasTimeStamp" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasOrdinalPosition"></see>
    /// </summary>
    let hasOrdinalPosition =
        Namespaced_IRI.parse _namespace_name "hasOrdinalPosition" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isValueOf"></see>
    /// </summary>
    let isValueOf = Namespaced_IRI.parse _namespace_name "isValueOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordedData"></see>
    /// </summary>
    let RecordedData =
        Namespaced_IRI.parse _namespace_name "RecordedData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasOffset"></see>
    /// </summary>
    let hasOffset = Namespaced_IRI.parse _namespace_name "hasOffset" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataBlock.POWDER"></see>
    /// </summary>
    let ``DataBlock.POWDER`` =
        Namespaced_IRI.parse _namespace_name "DataBlock.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataFormat"></see>
    /// </summary>
    let DataFormat = Namespaced_IRI.parse _namespace_name "DataFormat" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataFormat.POWDER"></see>
    /// </summary>
    let ``DataFormat.POWDER`` =
        Namespaced_IRI.parse _namespace_name "DataFormat.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataSegment"></see>
    /// </summary>
    let DataSegment =
        Namespaced_IRI.parse _namespace_name "DataSegment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDataBlock"></see>
    /// </summary>
    let hasDataBlock =
        Namespaced_IRI.parse _namespace_name "hasDataBlock" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isReferencedBy"></see>
    /// </summary>
    let isReferencedBy =
        Namespaced_IRI.parse _namespace_name "isReferencedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Marker"></see>
    /// </summary>
    let Marker = Namespaced_IRI.parse _namespace_name "Marker" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataSegment.POWDER"></see>
    /// </summary>
    let ``DataSegment.POWDER`` =
        Namespaced_IRI.parse _namespace_name "DataSegment.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDateTime"></see>
    /// </summary>
    let hasDateTime =
        Namespaced_IRI.parse _namespace_name "hasDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Descriptor.POWDER"></see>
    /// </summary>
    let ``Descriptor.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Descriptor.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Device"></see>
    /// </summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#madeRecord"></see>
    /// </summary>
    let madeRecord = Namespaced_IRI.parse _namespace_name "madeRecord" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Record"></see>
    /// </summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDeviceSpec"></see>
    /// </summary>
    let hasDeviceSpec =
        Namespaced_IRI.parse _namespace_name "hasDeviceSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DeviceSpec"></see>
    /// </summary>
    let DeviceSpec = Namespaced_IRI.parse _namespace_name "DeviceSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDeviceChannelingSpec"></see>
    /// </summary>
    let hasDeviceChannelingSpec =
        Namespaced_IRI.parse _namespace_name "hasDeviceChannelingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observes"></see>
    /// </summary>
    let observes = Namespaced_IRI.parse _namespace_name "observes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNonChannelData"></see>
    /// </summary>
    let hasNonChannelData =
        Namespaced_IRI.parse _namespace_name "hasNonChannelData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#NonChannel"></see>
    /// </summary>
    let NonChannel = Namespaced_IRI.parse _namespace_name "NonChannel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#StimulusEvent"></see>
    /// </summary>
    let StimulusEvent =
        Namespaced_IRI.parse _namespace_name "StimulusEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#detects"></see>
    /// </summary>
    let detects = Namespaced_IRI.parse _namespace_name "detects" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Device.POWDER"></see>
    /// </summary>
    let ``Device.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Device.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extendsChannelingSpec"></see>
    /// </summary>
    let extendsChannelingSpec =
        Namespaced_IRI.parse _namespace_name "extendsChannelingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNumberOfChannels"></see>
    /// </summary>
    let hasNumberOfChannels =
        Namespaced_IRI.parse _namespace_name "hasNumberOfChannels" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasChannelData"></see>
    /// </summary>
    let hasChannelData =
        Namespaced_IRI.parse _namespace_name "hasChannelData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DeviceChannelingSpec.POWDER"></see>
    /// </summary>
    let ``DeviceChannelingSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "DeviceChannelingSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DeviceSpec.POWDER"></see>
    /// </summary>
    let ``DeviceSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "DeviceSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegChannel"></see>
    /// </summary>
    let EegChannel = Namespaced_IRI.parse _namespace_name "EegChannel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegChannel.POWDER"></see>
    /// </summary>
    let ``EegChannel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "EegChannel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegDevice"></see>
    /// </summary>
    let EegDevice = Namespaced_IRI.parse _namespace_name "EegDevice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEegNonChannelData"></see>
    /// </summary>
    let hasEegNonChannelData =
        Namespaced_IRI.parse _namespace_name "hasEegNonChannelData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegNonChannel"></see>
    /// </summary>
    let EegNonChannel =
        Namespaced_IRI.parse _namespace_name "EegNonChannel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#madeEegRecord"></see>
    /// </summary>
    let madeEegRecord =
        Namespaced_IRI.parse _namespace_name "madeEegRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegRecord"></see>
    /// </summary>
    let EegRecord = Namespaced_IRI.parse _namespace_name "EegRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegDevice.POWDER"></see>
    /// </summary>
    let ``EegDevice.POWDER`` =
        Namespaced_IRI.parse _namespace_name "EegDevice.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegModality"></see>
    /// </summary>
    let EegModality =
        Namespaced_IRI.parse _namespace_name "EegModality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegModality.POWDER"></see>
    /// </summary>
    let ``EegModality.POWDER`` =
        Namespaced_IRI.parse _namespace_name "EegModality.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegNonChannel.POWDER"></see>
    /// </summary>
    let ``EegNonChannel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "EegNonChannel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedByEegDevice"></see>
    /// </summary>
    let observedByEegDevice =
        Namespaced_IRI.parse _namespace_name "observedByEegDevice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegRecord.POWDER"></see>
    /// </summary>
    let ``EegRecord.POWDER`` =
        Namespaced_IRI.parse _namespace_name "EegRecord.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EmotionalAspect"></see>
    /// </summary>
    let EmotionalAspect =
        Namespaced_IRI.parse _namespace_name "EmotionalAspect" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EmotionalAspect.POWDER"></see>
    /// </summary>
    let ``EmotionalAspect.POWDER`` =
        Namespaced_IRI.parse _namespace_name "EmotionalAspect.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSituationOf"></see>
    /// </summary>
    let isSituationOf =
        Namespaced_IRI.parse _namespace_name "isSituationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSubject"></see>
    /// </summary>
    let hasSubject = Namespaced_IRI.parse _namespace_name "hasSubject" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Subject"></see>
    /// </summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Interaction.POWDER"></see>
    /// </summary>
    let ``Interaction.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Interaction.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#pointsTo"></see>
    /// </summary>
    let pointsTo = Namespaced_IRI.parse _namespace_name "pointsTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Marker.POWDER"></see>
    /// </summary>
    let ``Marker.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Marker.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isModalityOf"></see>
    /// </summary>
    let isModalityOf =
        Namespaced_IRI.parse _namespace_name "isModalityOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasChannelingSpec"></see>
    /// </summary>
    let hasChannelingSpec =
        Namespaced_IRI.parse _namespace_name "hasChannelingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Modality.POWDER"></see>
    /// </summary>
    let ``Modality.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Modality.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Model"></see>
    /// </summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModelIRI"></see>
    /// </summary>
    let hasModelIRI =
        Namespaced_IRI.parse _namespace_name "hasModelIRI" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isModelOf"></see>
    /// </summary>
    let isModelOf = Namespaced_IRI.parse _namespace_name "isModelOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ResponseTag"></see>
    /// </summary>
    let ResponseTag =
        Namespaced_IRI.parse _namespace_name "ResponseTag" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#analizes"></see>
    /// </summary>
    let analizes = Namespaced_IRI.parse _namespace_name "analizes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Model.POWDER"></see>
    /// </summary>
    let ``Model.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Model.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#NeurologicalAspect"></see>
    /// </summary>
    let NeurologicalAspect =
        Namespaced_IRI.parse _namespace_name "NeurologicalAspect" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#NeurologicalAspect.POWDER"></see>
    /// </summary>
    let ``NeurologicalAspect.POWDER`` =
        Namespaced_IRI.parse _namespace_name "NeurologicalAspect.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#NonChannel.POWDER"></see>
    /// </summary>
    let ``NonChannel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "NonChannel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStartTime"></see>
    /// </summary>
    let hasStartTime =
        Namespaced_IRI.parse _namespace_name "hasStartTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant"></see>
    /// </summary>
    let PlayoutInstant =
        Namespaced_IRI.parse _namespace_name "PlayoutInstant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEndTime"></see>
    /// </summary>
    let hasEndTime = Namespaced_IRI.parse _namespace_name "hasEndTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isPlayoutOf"></see>
    /// </summary>
    let isPlayoutOf =
        Namespaced_IRI.parse _namespace_name "isPlayoutOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Playout.POWDER"></see>
    /// </summary>
    let ``Playout.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Playout.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.POWDER"></see>
    /// </summary>
    let ``PlayoutInstant.POWDER`` =
        Namespaced_IRI.parse _namespace_name "PlayoutInstant.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent.POWDER"></see>
    /// </summary>
    let ``PlayoutInstant.ContextEvent.POWDER`` =
        Namespaced_IRI.parse _namespace_name "PlayoutInstant.ContextEvent.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction.POWDER"></see>
    /// </summary>
    let ``PlayoutInstant.SubjectAction.POWDER`` =
        Namespaced_IRI.parse _namespace_name "PlayoutInstant.SubjectAction.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat"></see>
    /// </summary>
    let ProtocolBuffersDataFormat =
        Namespaced_IRI.parse _namespace_name "ProtocolBuffersDataFormat" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat.POWDER"></see>
    /// </summary>
    let ``ProtocolBuffersDataFormat.POWDER`` =
        Namespaced_IRI.parse _namespace_name "ProtocolBuffersDataFormat.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isRecordOf"></see>
    /// </summary>
    let isRecordOf = Namespaced_IRI.parse _namespace_name "isRecordOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSampleCount"></see>
    /// </summary>
    let hasSampleCount =
        Namespaced_IRI.parse _namespace_name "hasSampleCount" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecordChannelingSpec"></see>
    /// </summary>
    let hasRecordChannelingSpec =
        Namespaced_IRI.parse _namespace_name "hasRecordChannelingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordChannelingSpec"></see>
    /// </summary>
    let RecordChannelingSpec =
        Namespaced_IRI.parse _namespace_name "RecordChannelingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedModality"></see>
    /// </summary>
    let observedModality =
        Namespaced_IRI.parse _namespace_name "observedModality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSamplingRate"></see>
    /// </summary>
    let hasSamplingRate =
        Namespaced_IRI.parse _namespace_name "hasSamplingRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecordSpec"></see>
    /// </summary>
    let hasRecordSpec =
        Namespaced_IRI.parse _namespace_name "hasRecordSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordSpec"></see>
    /// </summary>
    let RecordSpec = Namespaced_IRI.parse _namespace_name "RecordSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#aspectOfInterest"></see>
    /// </summary>
    let aspectOfInterest =
        Namespaced_IRI.parse _namespace_name "aspectOfInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observationResult"></see>
    /// </summary>
    let observationResult =
        Namespaced_IRI.parse _namespace_name "observationResult" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMeasurementProperty"></see>
    /// </summary>
    let hasMeasurementProperty =
        Namespaced_IRI.parse _namespace_name "hasMeasurementProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedByDevice"></see>
    /// </summary>
    let observedByDevice =
        Namespaced_IRI.parse _namespace_name "observedByDevice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#includesEvent"></see>
    /// </summary>
    let includesEvent =
        Namespaced_IRI.parse _namespace_name "includesEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Record.POWDER"></see>
    /// </summary>
    let ``Record.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Record.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec"></see>
    /// </summary>
    let extendsDeviceChannelingSpec =
        Namespaced_IRI.parse _namespace_name "extendsDeviceChannelingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEndChannel"></see>
    /// </summary>
    let hasEndChannel =
        Namespaced_IRI.parse _namespace_name "hasEndChannel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStartChannel"></see>
    /// </summary>
    let hasStartChannel =
        Namespaced_IRI.parse _namespace_name "hasStartChannel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extends"></see>
    /// </summary>
    let extends = Namespaced_IRI.parse _namespace_name "extends" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordChannelingSpec.POWDER"></see>
    /// </summary>
    let ``RecordChannelingSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "RecordChannelingSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordSpec.POWDER"></see>
    /// </summary>
    let ``RecordSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "RecordSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isObservationResultOf"></see>
    /// </summary>
    let isObservationResultOf =
        Namespaced_IRI.parse _namespace_name "isObservationResultOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isProducedByDevice"></see>
    /// </summary>
    let isProducedByDevice =
        Namespaced_IRI.parse _namespace_name "isProducedByDevice" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDataFormat"></see>
    /// </summary>
    let hasDataFormat =
        Namespaced_IRI.parse _namespace_name "hasDataFormat" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasAccessMethod"></see>
    /// </summary>
    let hasAccessMethod =
        Namespaced_IRI.parse _namespace_name "hasAccessMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordedData.POWDER"></see>
    /// </summary>
    let ``RecordedData.POWDER`` =
        Namespaced_IRI.parse _namespace_name "RecordedData.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasConfidence"></see>
    /// </summary>
    let hasConfidence =
        Namespaced_IRI.parse _namespace_name "hasConfidence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModel"></see>
    /// </summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasState"></see>
    /// </summary>
    let hasState = Namespaced_IRI.parse _namespace_name "hasState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ResponseTag.POWDER"></see>
    /// </summary>
    let ``ResponseTag.POWDER`` =
        Namespaced_IRI.parse _namespace_name "ResponseTag.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#SamplingRate"></see>
    /// </summary>
    let SamplingRate =
        Namespaced_IRI.parse _namespace_name "SamplingRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#SamplingRate.POWDER"></see>
    /// </summary>
    let ``SamplingRate.POWDER`` =
        Namespaced_IRI.parse _namespace_name "SamplingRate.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSessionOf"></see>
    /// </summary>
    let isSessionOf =
        Namespaced_IRI.parse _namespace_name "isSessionOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecord"></see>
    /// </summary>
    let hasRecord = Namespaced_IRI.parse _namespace_name "hasRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSubjectState"></see>
    /// </summary>
    let hasSubjectState =
        Namespaced_IRI.parse _namespace_name "hasSubjectState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#SubjectState"></see>
    /// </summary>
    let SubjectState =
        Namespaced_IRI.parse _namespace_name "SubjectState" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasActivity"></see>
    /// </summary>
    let hasActivity =
        Namespaced_IRI.parse _namespace_name "hasActivity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Session.POWDER"></see>
    /// </summary>
    let ``Session.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Session.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isStimulusEventOf"></see>
    /// </summary>
    let isStimulusEventOf =
        Namespaced_IRI.parse _namespace_name "isStimulusEventOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#StimulusTag"></see>
    /// </summary>
    let StimulusTag =
        Namespaced_IRI.parse _namespace_name "StimulusTag" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isProxyFor"></see>
    /// </summary>
    let isProxyFor = Namespaced_IRI.parse _namespace_name "isProxyFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#StimulusEvent.POWDER"></see>
    /// </summary>
    let ``StimulusEvent.POWDER`` =
        Namespaced_IRI.parse _namespace_name "StimulusEvent.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStimulusEvent"></see>
    /// </summary>
    let hasStimulusEvent =
        Namespaced_IRI.parse _namespace_name "hasStimulusEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#StimulusTag.POWDER"></see>
    /// </summary>
    let ``StimulusTag.POWDER`` =
        Namespaced_IRI.parse _namespace_name "StimulusTag.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSubjectOf"></see>
    /// </summary>
    let isSubjectOf =
        Namespaced_IRI.parse _namespace_name "isSubjectOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Subject.POWDER"></see>
    /// </summary>
    let ``Subject.POWDER`` =
        Namespaced_IRI.parse _namespace_name "Subject.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#SubjectState.POWDER"></see>
    /// </summary>
    let ``SubjectState.POWDER`` =
        Namespaced_IRI.parse _namespace_name "SubjectState.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#XdfDataFormat"></see>
    /// </summary>
    let XdfDataFormat =
        Namespaced_IRI.parse _namespace_name "XdfDataFormat" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#XdfDataFormat.POWDER"></see>
    /// </summary>
    let ``XdfDataFormat.POWDER`` =
        Namespaced_IRI.parse _namespace_name "XdfDataFormat.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#analizes.POWDER"></see>
    /// </summary>
    let ``analizes.POWDER`` =
        Namespaced_IRI.parse _namespace_name "analizes.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#aspectOfInterest.POWDER"></see>
    /// </summary>
    let ``aspectOfInterest.POWDER`` =
        Namespaced_IRI.parse _namespace_name "aspectOfInterest.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#causes.POWDER"></see>
    /// </summary>
    let ``causes.POWDER`` =
        Namespaced_IRI.parse _namespace_name "causes.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#detects.POWDER"></see>
    /// </summary>
    let ``detects.POWDER`` =
        Namespaced_IRI.parse _namespace_name "detects.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extends.POWDER"></see>
    /// </summary>
    let ``extends.POWDER`` =
        Namespaced_IRI.parse _namespace_name "extends.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extendsChannelingSpec.POWDER"></see>
    /// </summary>
    let ``extendsChannelingSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "extendsChannelingSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec.POWDER"></see>
    /// </summary>
    let ``extendsDeviceChannelingSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "extendsDeviceChannelingSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#forModality.POWDER"></see>
    /// </summary>
    let ``forModality.POWDER`` =
        Namespaced_IRI.parse _namespace_name "forModality.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasAccessMethod.POWDER"></see>
    /// </summary>
    let ``hasAccessMethod.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasAccessMethod.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasAction.POWDER"></see>
    /// </summary>
    let ``hasAction.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasAction.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasActivity.POWDER"></see>
    /// </summary>
    let ``hasActivity.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasActivity.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasChannelData.POWDER"></see>
    /// </summary>
    let ``hasChannelData.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasChannelData.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasChannelingSpec.POWDER"></see>
    /// </summary>
    let ``hasChannelingSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasChannelingSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasConfidence.POWDER"></see>
    /// </summary>
    let ``hasConfidence.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasConfidence.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDataBlock.POWDER"></see>
    /// </summary>
    let ``hasDataBlock.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasDataBlock.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDataFormat.POWDER"></see>
    /// </summary>
    let ``hasDataFormat.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasDataFormat.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDateTime.POWDER"></see>
    /// </summary>
    let ``hasDateTime.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasDateTime.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDescriptor.POWDER"></see>
    /// </summary>
    let ``hasDescriptor.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasDescriptor.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDeviceChannelingSpec.POWDER"></see>
    /// </summary>
    let ``hasDeviceChannelingSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasDeviceChannelingSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDeviceSpec.POWDER"></see>
    /// </summary>
    let ``hasDeviceSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasDeviceSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEegChannelData"></see>
    /// </summary>
    let hasEegChannelData =
        Namespaced_IRI.parse _namespace_name "hasEegChannelData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEegChannelData.POWDER"></see>
    /// </summary>
    let ``hasEegChannelData.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasEegChannelData.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEegNonChannelData.POWDER"></see>
    /// </summary>
    let ``hasEegNonChannelData.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasEegNonChannelData.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEndChannel.POWDER"></see>
    /// </summary>
    let ``hasEndChannel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasEndChannel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEndTime.POWDER"></see>
    /// </summary>
    let ``hasEndTime.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasEndTime.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasIntensityLevel.POWDER"></see>
    /// </summary>
    let ``hasIntensityLevel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasIntensityLevel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLabel.POWDER"></see>
    /// </summary>
    let ``hasLabel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasLabel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLocation.POWDER"></see>
    /// </summary>
    let ``hasLocation.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasLocation.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLocator.POWDER"></see>
    /// </summary>
    let ``hasLocator.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasLocator.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.Broker.POWDER"></see>
    /// </summary>
    let ``hasMQTT.Broker.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasMQTT.Broker.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.ID.POWDER"></see>
    /// </summary>
    let ``hasMQTT.ID.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasMQTT.ID.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.Topic.POWDER"></see>
    /// </summary>
    let ``hasMQTT.Topic.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasMQTT.Topic.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMeasurementProperty.POWDER"></see>
    /// </summary>
    let ``hasMeasurementProperty.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasMeasurementProperty.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModality.POWDER"></see>
    /// </summary>
    let ``hasModality.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasModality.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModel.POWDER"></see>
    /// </summary>
    let ``hasModel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasModel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModelIRI.POWDER"></see>
    /// </summary>
    let ``hasModelIRI.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasModelIRI.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNext.POWDER"></see>
    /// </summary>
    let ``hasNext.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasNext.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNonChannelData.POWDER"></see>
    /// </summary>
    let ``hasNonChannelData.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasNonChannelData.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNumberOfChannels.POWDER"></see>
    /// </summary>
    let ``hasNumberOfChannels.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasNumberOfChannels.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasObject.POWDER"></see>
    /// </summary>
    let ``hasObject.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasObject.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasObjectComponent.POWDER"></see>
    /// </summary>
    let ``hasObjectComponent.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasObjectComponent.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasOffset.POWDER"></see>
    /// </summary>
    let ``hasOffset.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasOffset.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasOrdinalPosition.POWDER"></see>
    /// </summary>
    let ``hasOrdinalPosition.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasOrdinalPosition.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPlayout.POWDER"></see>
    /// </summary>
    let ``hasPlayout.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasPlayout.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPlayoutInstant.POWDER"></see>
    /// </summary>
    let ``hasPlayoutInstant.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasPlayoutInstant.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPrevious.POWDER"></see>
    /// </summary>
    let ``hasPrevious.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasPrevious.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecord.POWDER"></see>
    /// </summary>
    let ``hasRecord.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasRecord.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecordChannelingSpec.POWDER"></see>
    /// </summary>
    let ``hasRecordChannelingSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasRecordChannelingSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecordSpec.POWDER"></see>
    /// </summary>
    let ``hasRecordSpec.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasRecordSpec.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRole.POWDER"></see>
    /// </summary>
    let ``hasRole.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasRole.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSampleCount.POWDER"></see>
    /// </summary>
    let ``hasSampleCount.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasSampleCount.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSamplingRate.POWDER"></see>
    /// </summary>
    let ``hasSamplingRate.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasSamplingRate.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasScene.POWDER"></see>
    /// </summary>
    let ``hasScene.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasScene.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSession.POWDER"></see>
    /// </summary>
    let ``hasSession.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasSession.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSituation.POWDER"></see>
    /// </summary>
    let ``hasSituation.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasSituation.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStartChannel.POWDER"></see>
    /// </summary>
    let ``hasStartChannel.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasStartChannel.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStartTime.POWDER"></see>
    /// </summary>
    let ``hasStartTime.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasStartTime.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasState.POWDER"></see>
    /// </summary>
    let ``hasState.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasState.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStimulusEvent.POWDER"></see>
    /// </summary>
    let ``hasStimulusEvent.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasStimulusEvent.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSubject.POWDER"></see>
    /// </summary>
    let ``hasSubject.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasSubject.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSubjectState.POWDER"></see>
    /// </summary>
    let ``hasSubjectState.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasSubjectState.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasTimeStamp.POWDER"></see>
    /// </summary>
    let ``hasTimeStamp.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasTimeStamp.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasTitle.POWDER"></see>
    /// </summary>
    let ``hasTitle.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasTitle.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasType.POWDER"></see>
    /// </summary>
    let ``hasType.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasType.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasValue.POWDER"></see>
    /// </summary>
    let ``hasValue.POWDER`` =
        Namespaced_IRI.parse _namespace_name "hasValue.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#includesEvent.POWDER"></see>
    /// </summary>
    let ``includesEvent.POWDER`` =
        Namespaced_IRI.parse _namespace_name "includesEvent.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isChannelDataOf.POWDER"></see>
    /// </summary>
    let ``isChannelDataOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isChannelDataOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isEegChannelDataOf"></see>
    /// </summary>
    let isEegChannelDataOf =
        Namespaced_IRI.parse _namespace_name "isEegChannelDataOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isEegChannelDataOf.POWDER"></see>
    /// </summary>
    let ``isEegChannelDataOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isEegChannelDataOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isModalityOf.POWDER"></see>
    /// </summary>
    let ``isModalityOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isModalityOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isModelOf.POWDER"></see>
    /// </summary>
    let ``isModelOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isModelOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isObservationResultOf.POWDER"></see>
    /// </summary>
    let ``isObservationResultOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isObservationResultOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isPlayoutInstantOf"></see>
    /// </summary>
    let isPlayoutInstantOf =
        Namespaced_IRI.parse _namespace_name "isPlayoutInstantOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isPlayoutInstantOf.POWDER"></see>
    /// </summary>
    let ``isPlayoutInstantOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isPlayoutInstantOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isPlayoutOf.POWDER"></see>
    /// </summary>
    let ``isPlayoutOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isPlayoutOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isProducedByDevice.POWDER"></see>
    /// </summary>
    let ``isProducedByDevice.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isProducedByDevice.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isProxyFor.POWDER"></see>
    /// </summary>
    let ``isProxyFor.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isProxyFor.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isRecordOf.POWDER"></see>
    /// </summary>
    let ``isRecordOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isRecordOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isReferencedBy.POWDER"></see>
    /// </summary>
    let ``isReferencedBy.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isReferencedBy.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSessionOf.POWDER"></see>
    /// </summary>
    let ``isSessionOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isSessionOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSituationOf.POWDER"></see>
    /// </summary>
    let ``isSituationOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isSituationOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isStimulusEventOf.POWDER"></see>
    /// </summary>
    let ``isStimulusEventOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isStimulusEventOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSubjectOf.POWDER"></see>
    /// </summary>
    let ``isSubjectOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isSubjectOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isValueOf.POWDER"></see>
    /// </summary>
    let ``isValueOf.POWDER`` =
        Namespaced_IRI.parse _namespace_name "isValueOf.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#madeEegRecord.POWDER"></see>
    /// </summary>
    let ``madeEegRecord.POWDER`` =
        Namespaced_IRI.parse _namespace_name "madeEegRecord.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#madeRecord.POWDER"></see>
    /// </summary>
    let ``madeRecord.POWDER`` =
        Namespaced_IRI.parse _namespace_name "madeRecord.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observationResult.POWDER"></see>
    /// </summary>
    let ``observationResult.POWDER`` =
        Namespaced_IRI.parse _namespace_name "observationResult.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedByDevice.POWDER"></see>
    /// </summary>
    let ``observedByDevice.POWDER`` =
        Namespaced_IRI.parse _namespace_name "observedByDevice.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedByEegDevice.POWDER"></see>
    /// </summary>
    let ``observedByEegDevice.POWDER`` =
        Namespaced_IRI.parse _namespace_name "observedByEegDevice.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedModality.POWDER"></see>
    /// </summary>
    let ``observedModality.POWDER`` =
        Namespaced_IRI.parse _namespace_name "observedModality.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observes.POWDER"></see>
    /// </summary>
    let ``observes.POWDER`` =
        Namespaced_IRI.parse _namespace_name "observes.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ofAspect.POWDER"></see>
    /// </summary>
    let ``ofAspect.POWDER`` =
        Namespaced_IRI.parse _namespace_name "ofAspect.POWDER" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#pointsTo.POWDER"></see>
    /// </summary>
    let ``pointsTo.POWDER`` =
        Namespaced_IRI.parse _namespace_name "pointsTo.POWDER" |> NamespacedName
