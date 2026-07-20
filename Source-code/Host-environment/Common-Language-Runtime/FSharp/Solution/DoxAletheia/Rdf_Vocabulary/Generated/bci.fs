namespace https.w3id.org.BCI_ontology.hash

open DoxAletheia

module bci =
    let _namespace_name = "https://w3id.org/BCI-ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod"></see>
    /// </summary>
    let AccessMethod = _prefix "AccessMethod"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLocator"></see>
    /// </summary>
    let hasLocator = _prefix "hasLocator"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasType"></see>
    /// </summary>
    let hasType = _prefix "hasType"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.POWDER"></see>
    /// </summary>
    let ``AccessMethod.POWDER`` = _prefix "AccessMethod.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.CoAP"></see>
    /// </summary>
    let ``AccessMethod.CoAP`` = _prefix "AccessMethod.CoAP"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.CoAP.POWDER"></see>
    /// </summary>
    let ``AccessMethod.CoAP.POWDER`` = _prefix "AccessMethod.CoAP.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.MQTT"></see>
    /// </summary>
    let ``AccessMethod.MQTT`` = _prefix "AccessMethod.MQTT"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.Broker"></see>
    /// </summary>
    let ``hasMQTT.Broker`` = _prefix "hasMQTT.Broker"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.ID"></see>
    /// </summary>
    let ``hasMQTT.ID`` = _prefix "hasMQTT.ID"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.Topic"></see>
    /// </summary>
    let ``hasMQTT.Topic`` = _prefix "hasMQTT.Topic"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.MQTT.POWDER"></see>
    /// </summary>
    let ``AccessMethod.MQTT.POWDER`` = _prefix "AccessMethod.MQTT.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON"></see>
    /// </summary>
    let ``AccessMethod.RESTful-JSON`` = _prefix "AccessMethod.RESTful-JSON"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON.POWDER"></see>
    /// </summary>
    let ``AccessMethod.RESTful-JSON.POWDER`` =
        _prefix "AccessMethod.RESTful-JSON.POWDER"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPlayoutInstant"></see>
    /// </summary>
    let hasPlayoutInstant = _prefix "hasPlayoutInstant"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction"></see>
    /// </summary>
    let ``PlayoutInstant.SubjectAction`` = _prefix "PlayoutInstant.SubjectAction"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Action.POWDER"></see>
    /// </summary>
    let ``Action.POWDER`` = _prefix "Action.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Activity"></see>
    /// </summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDescriptor"></see>
    /// </summary>
    let hasDescriptor = _prefix "hasDescriptor"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Descriptor"></see>
    /// </summary>
    let Descriptor = _prefix "Descriptor"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasAction"></see>
    /// </summary>
    let hasAction = _prefix "hasAction"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Activity.POWDER"></see>
    /// </summary>
    let ``Activity.POWDER`` = _prefix "Activity.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Aspect"></see>
    /// </summary>
    let Aspect = _prefix "Aspect"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Modality"></see>
    /// </summary>
    let Modality = _prefix "Modality"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModality"></see>
    /// </summary>
    let hasModality = _prefix "hasModality"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasIntensityLevel"></see>
    /// </summary>
    let hasIntensityLevel = _prefix "hasIntensityLevel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Aspect.POWDER"></see>
    /// </summary>
    let ``Aspect.POWDER`` = _prefix "Aspect.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Channel"></see>
    /// </summary>
    let Channel = _prefix "Channel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLabel"></see>
    /// </summary>
    let hasLabel = _prefix "hasLabel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#forModality"></see>
    /// </summary>
    let forModality = _prefix "forModality"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ofAspect"></see>
    /// </summary>
    let ofAspect = _prefix "ofAspect"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DeviceChannelingSpec"></see>
    /// </summary>
    let DeviceChannelingSpec = _prefix "DeviceChannelingSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isChannelDataOf"></see>
    /// </summary>
    let isChannelDataOf = _prefix "isChannelDataOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Channel.POWDER"></see>
    /// </summary>
    let ``Channel.POWDER`` = _prefix "Channel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ChannelingSpec"></see>
    /// </summary>
    let ChannelingSpec = _prefix "ChannelingSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ChannelingSpec.POWDER"></see>
    /// </summary>
    let ``ChannelingSpec.POWDER`` = _prefix "ChannelingSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#CognitiveAspect"></see>
    /// </summary>
    let CognitiveAspect = _prefix "CognitiveAspect"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#CognitiveAspect.POWDER"></see>
    /// </summary>
    let ``CognitiveAspect.POWDER`` = _prefix "CognitiveAspect.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Collection"></see>
    /// </summary>
    let Collection = _prefix "Collection"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSituation"></see>
    /// </summary>
    let hasSituation = _prefix "hasSituation"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Interaction"></see>
    /// </summary>
    let Interaction = _prefix "Interaction"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasTitle"></see>
    /// </summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Session"></see>
    /// </summary>
    let Session = _prefix "Session"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Collection.POWDER"></see>
    /// </summary>
    let ``Collection.POWDER`` = _prefix "Collection.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context"></see>
    /// </summary>
    let Context = _prefix "Context"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSession"></see>
    /// </summary>
    let hasSession = _prefix "hasSession"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasScene"></see>
    /// </summary>
    let hasScene = _prefix "hasScene"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Scene"></see>
    /// </summary>
    let ``Context.Scene`` = _prefix "Context.Scene"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPlayout"></see>
    /// </summary>
    let hasPlayout = _prefix "hasPlayout"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Playout"></see>
    /// </summary>
    let Playout = _prefix "Playout"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLocation"></see>
    /// </summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.POWDER"></see>
    /// </summary>
    let ``Context.POWDER`` = _prefix "Context.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Object"></see>
    /// </summary>
    let ``Context.Object`` = _prefix "Context.Object"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasObject"></see>
    /// </summary>
    let hasObject = _prefix "hasObject"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasObjectComponent"></see>
    /// </summary>
    let hasObjectComponent = _prefix "hasObjectComponent"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.ObjectComponent"></see>
    /// </summary>
    let ``Context.ObjectComponent`` = _prefix "Context.ObjectComponent"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRole"></see>
    /// </summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Role"></see>
    /// </summary>
    let ``Context.Role`` = _prefix "Context.Role"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Object.POWDER"></see>
    /// </summary>
    let ``Context.Object.POWDER`` = _prefix "Context.Object.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.ObjectComponent.POWDER"></see>
    /// </summary>
    let ``Context.ObjectComponent.POWDER`` = _prefix "Context.ObjectComponent.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.ObjectComponent.Event"></see>
    /// </summary>
    let ``Context.ObjectComponent.Event`` = _prefix "Context.ObjectComponent.Event"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#causes"></see>
    /// </summary>
    let causes = _prefix "causes"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent"></see>
    /// </summary>
    let ``PlayoutInstant.ContextEvent`` = _prefix "PlayoutInstant.ContextEvent"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.ObjectComponent.Event.POWDER"></see>
    /// </summary>
    let ``Context.ObjectComponent.Event.POWDER`` =
        _prefix "Context.ObjectComponent.Event.POWDER"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Role.POWDER"></see>
    /// </summary>
    let ``Context.Role.POWDER`` = _prefix "Context.Role.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPrevious"></see>
    /// </summary>
    let hasPrevious = _prefix "hasPrevious"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNext"></see>
    /// </summary>
    let hasNext = _prefix "hasNext"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Context.Scene.POWDER"></see>
    /// </summary>
    let ``Context.Scene.POWDER`` = _prefix "Context.Scene.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataBlock"></see>
    /// </summary>
    let DataBlock = _prefix "DataBlock"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasTimeStamp"></see>
    /// </summary>
    let hasTimeStamp = _prefix "hasTimeStamp"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasOrdinalPosition"></see>
    /// </summary>
    let hasOrdinalPosition = _prefix "hasOrdinalPosition"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isValueOf"></see>
    /// </summary>
    let isValueOf = _prefix "isValueOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordedData"></see>
    /// </summary>
    let RecordedData = _prefix "RecordedData"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasOffset"></see>
    /// </summary>
    let hasOffset = _prefix "hasOffset"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataBlock.POWDER"></see>
    /// </summary>
    let ``DataBlock.POWDER`` = _prefix "DataBlock.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataFormat"></see>
    /// </summary>
    let DataFormat = _prefix "DataFormat"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataFormat.POWDER"></see>
    /// </summary>
    let ``DataFormat.POWDER`` = _prefix "DataFormat.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataSegment"></see>
    /// </summary>
    let DataSegment = _prefix "DataSegment"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDataBlock"></see>
    /// </summary>
    let hasDataBlock = _prefix "hasDataBlock"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isReferencedBy"></see>
    /// </summary>
    let isReferencedBy = _prefix "isReferencedBy"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Marker"></see>
    /// </summary>
    let Marker = _prefix "Marker"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DataSegment.POWDER"></see>
    /// </summary>
    let ``DataSegment.POWDER`` = _prefix "DataSegment.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDateTime"></see>
    /// </summary>
    let hasDateTime = _prefix "hasDateTime"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Descriptor.POWDER"></see>
    /// </summary>
    let ``Descriptor.POWDER`` = _prefix "Descriptor.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Device"></see>
    /// </summary>
    let Device = _prefix "Device"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#madeRecord"></see>
    /// </summary>
    let madeRecord = _prefix "madeRecord"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Record"></see>
    /// </summary>
    let Record = _prefix "Record"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDeviceSpec"></see>
    /// </summary>
    let hasDeviceSpec = _prefix "hasDeviceSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DeviceSpec"></see>
    /// </summary>
    let DeviceSpec = _prefix "DeviceSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDeviceChannelingSpec"></see>
    /// </summary>
    let hasDeviceChannelingSpec = _prefix "hasDeviceChannelingSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observes"></see>
    /// </summary>
    let observes = _prefix "observes"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNonChannelData"></see>
    /// </summary>
    let hasNonChannelData = _prefix "hasNonChannelData"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#NonChannel"></see>
    /// </summary>
    let NonChannel = _prefix "NonChannel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#StimulusEvent"></see>
    /// </summary>
    let StimulusEvent = _prefix "StimulusEvent"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#detects"></see>
    /// </summary>
    let detects = _prefix "detects"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Device.POWDER"></see>
    /// </summary>
    let ``Device.POWDER`` = _prefix "Device.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extendsChannelingSpec"></see>
    /// </summary>
    let extendsChannelingSpec = _prefix "extendsChannelingSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNumberOfChannels"></see>
    /// </summary>
    let hasNumberOfChannels = _prefix "hasNumberOfChannels"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasChannelData"></see>
    /// </summary>
    let hasChannelData = _prefix "hasChannelData"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DeviceChannelingSpec.POWDER"></see>
    /// </summary>
    let ``DeviceChannelingSpec.POWDER`` = _prefix "DeviceChannelingSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#DeviceSpec.POWDER"></see>
    /// </summary>
    let ``DeviceSpec.POWDER`` = _prefix "DeviceSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegChannel"></see>
    /// </summary>
    let EegChannel = _prefix "EegChannel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegChannel.POWDER"></see>
    /// </summary>
    let ``EegChannel.POWDER`` = _prefix "EegChannel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegDevice"></see>
    /// </summary>
    let EegDevice = _prefix "EegDevice"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEegNonChannelData"></see>
    /// </summary>
    let hasEegNonChannelData = _prefix "hasEegNonChannelData"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegNonChannel"></see>
    /// </summary>
    let EegNonChannel = _prefix "EegNonChannel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#madeEegRecord"></see>
    /// </summary>
    let madeEegRecord = _prefix "madeEegRecord"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegRecord"></see>
    /// </summary>
    let EegRecord = _prefix "EegRecord"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegDevice.POWDER"></see>
    /// </summary>
    let ``EegDevice.POWDER`` = _prefix "EegDevice.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegModality"></see>
    /// </summary>
    let EegModality = _prefix "EegModality"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegModality.POWDER"></see>
    /// </summary>
    let ``EegModality.POWDER`` = _prefix "EegModality.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegNonChannel.POWDER"></see>
    /// </summary>
    let ``EegNonChannel.POWDER`` = _prefix "EegNonChannel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedByEegDevice"></see>
    /// </summary>
    let observedByEegDevice = _prefix "observedByEegDevice"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EegRecord.POWDER"></see>
    /// </summary>
    let ``EegRecord.POWDER`` = _prefix "EegRecord.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EmotionalAspect"></see>
    /// </summary>
    let EmotionalAspect = _prefix "EmotionalAspect"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#EmotionalAspect.POWDER"></see>
    /// </summary>
    let ``EmotionalAspect.POWDER`` = _prefix "EmotionalAspect.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSituationOf"></see>
    /// </summary>
    let isSituationOf = _prefix "isSituationOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSubject"></see>
    /// </summary>
    let hasSubject = _prefix "hasSubject"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Subject"></see>
    /// </summary>
    let Subject = _prefix "Subject"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Interaction.POWDER"></see>
    /// </summary>
    let ``Interaction.POWDER`` = _prefix "Interaction.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#pointsTo"></see>
    /// </summary>
    let pointsTo = _prefix "pointsTo"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Marker.POWDER"></see>
    /// </summary>
    let ``Marker.POWDER`` = _prefix "Marker.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isModalityOf"></see>
    /// </summary>
    let isModalityOf = _prefix "isModalityOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasChannelingSpec"></see>
    /// </summary>
    let hasChannelingSpec = _prefix "hasChannelingSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Modality.POWDER"></see>
    /// </summary>
    let ``Modality.POWDER`` = _prefix "Modality.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Model"></see>
    /// </summary>
    let Model = _prefix "Model"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModelIRI"></see>
    /// </summary>
    let hasModelIRI = _prefix "hasModelIRI"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isModelOf"></see>
    /// </summary>
    let isModelOf = _prefix "isModelOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ResponseTag"></see>
    /// </summary>
    let ResponseTag = _prefix "ResponseTag"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#analizes"></see>
    /// </summary>
    let analizes = _prefix "analizes"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Model.POWDER"></see>
    /// </summary>
    let ``Model.POWDER`` = _prefix "Model.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#NeurologicalAspect"></see>
    /// </summary>
    let NeurologicalAspect = _prefix "NeurologicalAspect"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#NeurologicalAspect.POWDER"></see>
    /// </summary>
    let ``NeurologicalAspect.POWDER`` = _prefix "NeurologicalAspect.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#NonChannel.POWDER"></see>
    /// </summary>
    let ``NonChannel.POWDER`` = _prefix "NonChannel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStartTime"></see>
    /// </summary>
    let hasStartTime = _prefix "hasStartTime"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant"></see>
    /// </summary>
    let PlayoutInstant = _prefix "PlayoutInstant"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEndTime"></see>
    /// </summary>
    let hasEndTime = _prefix "hasEndTime"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isPlayoutOf"></see>
    /// </summary>
    let isPlayoutOf = _prefix "isPlayoutOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Playout.POWDER"></see>
    /// </summary>
    let ``Playout.POWDER`` = _prefix "Playout.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.POWDER"></see>
    /// </summary>
    let ``PlayoutInstant.POWDER`` = _prefix "PlayoutInstant.POWDER"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent.POWDER"></see>
    /// </summary>
    let ``PlayoutInstant.ContextEvent.POWDER`` =
        _prefix "PlayoutInstant.ContextEvent.POWDER"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction.POWDER"></see>
    /// </summary>
    let ``PlayoutInstant.SubjectAction.POWDER`` =
        _prefix "PlayoutInstant.SubjectAction.POWDER"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat"></see>
    /// </summary>
    let ProtocolBuffersDataFormat = _prefix "ProtocolBuffersDataFormat"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat.POWDER"></see>
    /// </summary>
    let ``ProtocolBuffersDataFormat.POWDER`` =
        _prefix "ProtocolBuffersDataFormat.POWDER"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isRecordOf"></see>
    /// </summary>
    let isRecordOf = _prefix "isRecordOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSampleCount"></see>
    /// </summary>
    let hasSampleCount = _prefix "hasSampleCount"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecordChannelingSpec"></see>
    /// </summary>
    let hasRecordChannelingSpec = _prefix "hasRecordChannelingSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordChannelingSpec"></see>
    /// </summary>
    let RecordChannelingSpec = _prefix "RecordChannelingSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedModality"></see>
    /// </summary>
    let observedModality = _prefix "observedModality"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSamplingRate"></see>
    /// </summary>
    let hasSamplingRate = _prefix "hasSamplingRate"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecordSpec"></see>
    /// </summary>
    let hasRecordSpec = _prefix "hasRecordSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordSpec"></see>
    /// </summary>
    let RecordSpec = _prefix "RecordSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#aspectOfInterest"></see>
    /// </summary>
    let aspectOfInterest = _prefix "aspectOfInterest"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observationResult"></see>
    /// </summary>
    let observationResult = _prefix "observationResult"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMeasurementProperty"></see>
    /// </summary>
    let hasMeasurementProperty = _prefix "hasMeasurementProperty"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedByDevice"></see>
    /// </summary>
    let observedByDevice = _prefix "observedByDevice"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#includesEvent"></see>
    /// </summary>
    let includesEvent = _prefix "includesEvent"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Record.POWDER"></see>
    /// </summary>
    let ``Record.POWDER`` = _prefix "Record.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec"></see>
    /// </summary>
    let extendsDeviceChannelingSpec = _prefix "extendsDeviceChannelingSpec"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEndChannel"></see>
    /// </summary>
    let hasEndChannel = _prefix "hasEndChannel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStartChannel"></see>
    /// </summary>
    let hasStartChannel = _prefix "hasStartChannel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extends"></see>
    /// </summary>
    let extends = _prefix "extends"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordChannelingSpec.POWDER"></see>
    /// </summary>
    let ``RecordChannelingSpec.POWDER`` = _prefix "RecordChannelingSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordSpec.POWDER"></see>
    /// </summary>
    let ``RecordSpec.POWDER`` = _prefix "RecordSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isObservationResultOf"></see>
    /// </summary>
    let isObservationResultOf = _prefix "isObservationResultOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isProducedByDevice"></see>
    /// </summary>
    let isProducedByDevice = _prefix "isProducedByDevice"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDataFormat"></see>
    /// </summary>
    let hasDataFormat = _prefix "hasDataFormat"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasAccessMethod"></see>
    /// </summary>
    let hasAccessMethod = _prefix "hasAccessMethod"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#RecordedData.POWDER"></see>
    /// </summary>
    let ``RecordedData.POWDER`` = _prefix "RecordedData.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasConfidence"></see>
    /// </summary>
    let hasConfidence = _prefix "hasConfidence"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModel"></see>
    /// </summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasState"></see>
    /// </summary>
    let hasState = _prefix "hasState"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ResponseTag.POWDER"></see>
    /// </summary>
    let ``ResponseTag.POWDER`` = _prefix "ResponseTag.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#SamplingRate"></see>
    /// </summary>
    let SamplingRate = _prefix "SamplingRate"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#SamplingRate.POWDER"></see>
    /// </summary>
    let ``SamplingRate.POWDER`` = _prefix "SamplingRate.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSessionOf"></see>
    /// </summary>
    let isSessionOf = _prefix "isSessionOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecord"></see>
    /// </summary>
    let hasRecord = _prefix "hasRecord"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSubjectState"></see>
    /// </summary>
    let hasSubjectState = _prefix "hasSubjectState"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#SubjectState"></see>
    /// </summary>
    let SubjectState = _prefix "SubjectState"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasActivity"></see>
    /// </summary>
    let hasActivity = _prefix "hasActivity"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Session.POWDER"></see>
    /// </summary>
    let ``Session.POWDER`` = _prefix "Session.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isStimulusEventOf"></see>
    /// </summary>
    let isStimulusEventOf = _prefix "isStimulusEventOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#StimulusTag"></see>
    /// </summary>
    let StimulusTag = _prefix "StimulusTag"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isProxyFor"></see>
    /// </summary>
    let isProxyFor = _prefix "isProxyFor"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#StimulusEvent.POWDER"></see>
    /// </summary>
    let ``StimulusEvent.POWDER`` = _prefix "StimulusEvent.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStimulusEvent"></see>
    /// </summary>
    let hasStimulusEvent = _prefix "hasStimulusEvent"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#StimulusTag.POWDER"></see>
    /// </summary>
    let ``StimulusTag.POWDER`` = _prefix "StimulusTag.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSubjectOf"></see>
    /// </summary>
    let isSubjectOf = _prefix "isSubjectOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#Subject.POWDER"></see>
    /// </summary>
    let ``Subject.POWDER`` = _prefix "Subject.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#SubjectState.POWDER"></see>
    /// </summary>
    let ``SubjectState.POWDER`` = _prefix "SubjectState.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#XdfDataFormat"></see>
    /// </summary>
    let XdfDataFormat = _prefix "XdfDataFormat"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#XdfDataFormat.POWDER"></see>
    /// </summary>
    let ``XdfDataFormat.POWDER`` = _prefix "XdfDataFormat.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#analizes.POWDER"></see>
    /// </summary>
    let ``analizes.POWDER`` = _prefix "analizes.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#aspectOfInterest.POWDER"></see>
    /// </summary>
    let ``aspectOfInterest.POWDER`` = _prefix "aspectOfInterest.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#causes.POWDER"></see>
    /// </summary>
    let ``causes.POWDER`` = _prefix "causes.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#detects.POWDER"></see>
    /// </summary>
    let ``detects.POWDER`` = _prefix "detects.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extends.POWDER"></see>
    /// </summary>
    let ``extends.POWDER`` = _prefix "extends.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extendsChannelingSpec.POWDER"></see>
    /// </summary>
    let ``extendsChannelingSpec.POWDER`` = _prefix "extendsChannelingSpec.POWDER"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec.POWDER"></see>
    /// </summary>
    let ``extendsDeviceChannelingSpec.POWDER`` =
        _prefix "extendsDeviceChannelingSpec.POWDER"

    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#forModality.POWDER"></see>
    /// </summary>
    let ``forModality.POWDER`` = _prefix "forModality.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasAccessMethod.POWDER"></see>
    /// </summary>
    let ``hasAccessMethod.POWDER`` = _prefix "hasAccessMethod.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasAction.POWDER"></see>
    /// </summary>
    let ``hasAction.POWDER`` = _prefix "hasAction.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasActivity.POWDER"></see>
    /// </summary>
    let ``hasActivity.POWDER`` = _prefix "hasActivity.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasChannelData.POWDER"></see>
    /// </summary>
    let ``hasChannelData.POWDER`` = _prefix "hasChannelData.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasChannelingSpec.POWDER"></see>
    /// </summary>
    let ``hasChannelingSpec.POWDER`` = _prefix "hasChannelingSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasConfidence.POWDER"></see>
    /// </summary>
    let ``hasConfidence.POWDER`` = _prefix "hasConfidence.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDataBlock.POWDER"></see>
    /// </summary>
    let ``hasDataBlock.POWDER`` = _prefix "hasDataBlock.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDataFormat.POWDER"></see>
    /// </summary>
    let ``hasDataFormat.POWDER`` = _prefix "hasDataFormat.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDateTime.POWDER"></see>
    /// </summary>
    let ``hasDateTime.POWDER`` = _prefix "hasDateTime.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDescriptor.POWDER"></see>
    /// </summary>
    let ``hasDescriptor.POWDER`` = _prefix "hasDescriptor.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDeviceChannelingSpec.POWDER"></see>
    /// </summary>
    let ``hasDeviceChannelingSpec.POWDER`` = _prefix "hasDeviceChannelingSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasDeviceSpec.POWDER"></see>
    /// </summary>
    let ``hasDeviceSpec.POWDER`` = _prefix "hasDeviceSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEegChannelData"></see>
    /// </summary>
    let hasEegChannelData = _prefix "hasEegChannelData"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEegChannelData.POWDER"></see>
    /// </summary>
    let ``hasEegChannelData.POWDER`` = _prefix "hasEegChannelData.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEegNonChannelData.POWDER"></see>
    /// </summary>
    let ``hasEegNonChannelData.POWDER`` = _prefix "hasEegNonChannelData.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEndChannel.POWDER"></see>
    /// </summary>
    let ``hasEndChannel.POWDER`` = _prefix "hasEndChannel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasEndTime.POWDER"></see>
    /// </summary>
    let ``hasEndTime.POWDER`` = _prefix "hasEndTime.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasIntensityLevel.POWDER"></see>
    /// </summary>
    let ``hasIntensityLevel.POWDER`` = _prefix "hasIntensityLevel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLabel.POWDER"></see>
    /// </summary>
    let ``hasLabel.POWDER`` = _prefix "hasLabel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLocation.POWDER"></see>
    /// </summary>
    let ``hasLocation.POWDER`` = _prefix "hasLocation.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasLocator.POWDER"></see>
    /// </summary>
    let ``hasLocator.POWDER`` = _prefix "hasLocator.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.Broker.POWDER"></see>
    /// </summary>
    let ``hasMQTT.Broker.POWDER`` = _prefix "hasMQTT.Broker.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.ID.POWDER"></see>
    /// </summary>
    let ``hasMQTT.ID.POWDER`` = _prefix "hasMQTT.ID.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMQTT.Topic.POWDER"></see>
    /// </summary>
    let ``hasMQTT.Topic.POWDER`` = _prefix "hasMQTT.Topic.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasMeasurementProperty.POWDER"></see>
    /// </summary>
    let ``hasMeasurementProperty.POWDER`` = _prefix "hasMeasurementProperty.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModality.POWDER"></see>
    /// </summary>
    let ``hasModality.POWDER`` = _prefix "hasModality.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModel.POWDER"></see>
    /// </summary>
    let ``hasModel.POWDER`` = _prefix "hasModel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasModelIRI.POWDER"></see>
    /// </summary>
    let ``hasModelIRI.POWDER`` = _prefix "hasModelIRI.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNext.POWDER"></see>
    /// </summary>
    let ``hasNext.POWDER`` = _prefix "hasNext.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNonChannelData.POWDER"></see>
    /// </summary>
    let ``hasNonChannelData.POWDER`` = _prefix "hasNonChannelData.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasNumberOfChannels.POWDER"></see>
    /// </summary>
    let ``hasNumberOfChannels.POWDER`` = _prefix "hasNumberOfChannels.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasObject.POWDER"></see>
    /// </summary>
    let ``hasObject.POWDER`` = _prefix "hasObject.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasObjectComponent.POWDER"></see>
    /// </summary>
    let ``hasObjectComponent.POWDER`` = _prefix "hasObjectComponent.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasOffset.POWDER"></see>
    /// </summary>
    let ``hasOffset.POWDER`` = _prefix "hasOffset.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasOrdinalPosition.POWDER"></see>
    /// </summary>
    let ``hasOrdinalPosition.POWDER`` = _prefix "hasOrdinalPosition.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPlayout.POWDER"></see>
    /// </summary>
    let ``hasPlayout.POWDER`` = _prefix "hasPlayout.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPlayoutInstant.POWDER"></see>
    /// </summary>
    let ``hasPlayoutInstant.POWDER`` = _prefix "hasPlayoutInstant.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasPrevious.POWDER"></see>
    /// </summary>
    let ``hasPrevious.POWDER`` = _prefix "hasPrevious.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecord.POWDER"></see>
    /// </summary>
    let ``hasRecord.POWDER`` = _prefix "hasRecord.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecordChannelingSpec.POWDER"></see>
    /// </summary>
    let ``hasRecordChannelingSpec.POWDER`` = _prefix "hasRecordChannelingSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRecordSpec.POWDER"></see>
    /// </summary>
    let ``hasRecordSpec.POWDER`` = _prefix "hasRecordSpec.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasRole.POWDER"></see>
    /// </summary>
    let ``hasRole.POWDER`` = _prefix "hasRole.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSampleCount.POWDER"></see>
    /// </summary>
    let ``hasSampleCount.POWDER`` = _prefix "hasSampleCount.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSamplingRate.POWDER"></see>
    /// </summary>
    let ``hasSamplingRate.POWDER`` = _prefix "hasSamplingRate.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasScene.POWDER"></see>
    /// </summary>
    let ``hasScene.POWDER`` = _prefix "hasScene.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSession.POWDER"></see>
    /// </summary>
    let ``hasSession.POWDER`` = _prefix "hasSession.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSituation.POWDER"></see>
    /// </summary>
    let ``hasSituation.POWDER`` = _prefix "hasSituation.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStartChannel.POWDER"></see>
    /// </summary>
    let ``hasStartChannel.POWDER`` = _prefix "hasStartChannel.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStartTime.POWDER"></see>
    /// </summary>
    let ``hasStartTime.POWDER`` = _prefix "hasStartTime.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasState.POWDER"></see>
    /// </summary>
    let ``hasState.POWDER`` = _prefix "hasState.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasStimulusEvent.POWDER"></see>
    /// </summary>
    let ``hasStimulusEvent.POWDER`` = _prefix "hasStimulusEvent.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSubject.POWDER"></see>
    /// </summary>
    let ``hasSubject.POWDER`` = _prefix "hasSubject.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasSubjectState.POWDER"></see>
    /// </summary>
    let ``hasSubjectState.POWDER`` = _prefix "hasSubjectState.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasTimeStamp.POWDER"></see>
    /// </summary>
    let ``hasTimeStamp.POWDER`` = _prefix "hasTimeStamp.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasTitle.POWDER"></see>
    /// </summary>
    let ``hasTitle.POWDER`` = _prefix "hasTitle.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasType.POWDER"></see>
    /// </summary>
    let ``hasType.POWDER`` = _prefix "hasType.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#hasValue.POWDER"></see>
    /// </summary>
    let ``hasValue.POWDER`` = _prefix "hasValue.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#includesEvent.POWDER"></see>
    /// </summary>
    let ``includesEvent.POWDER`` = _prefix "includesEvent.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isChannelDataOf.POWDER"></see>
    /// </summary>
    let ``isChannelDataOf.POWDER`` = _prefix "isChannelDataOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isEegChannelDataOf"></see>
    /// </summary>
    let isEegChannelDataOf = _prefix "isEegChannelDataOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isEegChannelDataOf.POWDER"></see>
    /// </summary>
    let ``isEegChannelDataOf.POWDER`` = _prefix "isEegChannelDataOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isModalityOf.POWDER"></see>
    /// </summary>
    let ``isModalityOf.POWDER`` = _prefix "isModalityOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isModelOf.POWDER"></see>
    /// </summary>
    let ``isModelOf.POWDER`` = _prefix "isModelOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isObservationResultOf.POWDER"></see>
    /// </summary>
    let ``isObservationResultOf.POWDER`` = _prefix "isObservationResultOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isPlayoutInstantOf"></see>
    /// </summary>
    let isPlayoutInstantOf = _prefix "isPlayoutInstantOf"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isPlayoutInstantOf.POWDER"></see>
    /// </summary>
    let ``isPlayoutInstantOf.POWDER`` = _prefix "isPlayoutInstantOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isPlayoutOf.POWDER"></see>
    /// </summary>
    let ``isPlayoutOf.POWDER`` = _prefix "isPlayoutOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isProducedByDevice.POWDER"></see>
    /// </summary>
    let ``isProducedByDevice.POWDER`` = _prefix "isProducedByDevice.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isProxyFor.POWDER"></see>
    /// </summary>
    let ``isProxyFor.POWDER`` = _prefix "isProxyFor.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isRecordOf.POWDER"></see>
    /// </summary>
    let ``isRecordOf.POWDER`` = _prefix "isRecordOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isReferencedBy.POWDER"></see>
    /// </summary>
    let ``isReferencedBy.POWDER`` = _prefix "isReferencedBy.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSessionOf.POWDER"></see>
    /// </summary>
    let ``isSessionOf.POWDER`` = _prefix "isSessionOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSituationOf.POWDER"></see>
    /// </summary>
    let ``isSituationOf.POWDER`` = _prefix "isSituationOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isStimulusEventOf.POWDER"></see>
    /// </summary>
    let ``isStimulusEventOf.POWDER`` = _prefix "isStimulusEventOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isSubjectOf.POWDER"></see>
    /// </summary>
    let ``isSubjectOf.POWDER`` = _prefix "isSubjectOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#isValueOf.POWDER"></see>
    /// </summary>
    let ``isValueOf.POWDER`` = _prefix "isValueOf.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#madeEegRecord.POWDER"></see>
    /// </summary>
    let ``madeEegRecord.POWDER`` = _prefix "madeEegRecord.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#madeRecord.POWDER"></see>
    /// </summary>
    let ``madeRecord.POWDER`` = _prefix "madeRecord.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observationResult.POWDER"></see>
    /// </summary>
    let ``observationResult.POWDER`` = _prefix "observationResult.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedByDevice.POWDER"></see>
    /// </summary>
    let ``observedByDevice.POWDER`` = _prefix "observedByDevice.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedByEegDevice.POWDER"></see>
    /// </summary>
    let ``observedByEegDevice.POWDER`` = _prefix "observedByEegDevice.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observedModality.POWDER"></see>
    /// </summary>
    let ``observedModality.POWDER`` = _prefix "observedModality.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#observes.POWDER"></see>
    /// </summary>
    let ``observes.POWDER`` = _prefix "observes.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#ofAspect.POWDER"></see>
    /// </summary>
    let ``ofAspect.POWDER`` = _prefix "ofAspect.POWDER"
    /// <summary>
    ///   <see href="https://w3id.org/BCI-ontology#pointsTo.POWDER"></see>
    /// </summary>
    let ``pointsTo.POWDER`` = _prefix "pointsTo.POWDER"
