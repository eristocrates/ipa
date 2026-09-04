#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module eem =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/eem#" "eem"
    let ADD = _prefixId.prefix "ADD"
    /// <summary>
    ///   <para>rdfs:comment : The Action type says how an event relates to the lifecycle of the entity being described.^^xsd:string</para>
    ///   <a href="http://purl.org/eem#Action">eem:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:comment : Represents an event that happened to one or more entities denoted by EPCs that are phys
    /// ically aggregated together (physically constrained to be in the same place at the same time, as when cases are aggregated to a pallet). ^^xsd:string</para>
    ///   <a href="http://purl.org/eem#AggregationEvent">eem:AggregationEvent</a>
    /// </summary>
    let AggregationEvent = _prefixId.prefix "AggregationEvent"
    /// <summary>
    ///   <para>rdfs:comment : A concept represent the aggregation identifier of a packagaing unit^^xsd:string</para>
    ///   <a href="http://purl.org/eem#AggregationID">eem:AggregationID</a>
    /// </summary>
    let AggregationID = _prefixId.prefix "AggregationID"
    let BusinessLocation = _prefixId.prefix "BusinessLocation"
    let DELETE = _prefixId.prefix "DELETE"
    /// <summary>
    ///   <para>rdfs:comment : Added in version 1.1^^xsd:string</para>
    ///   <a href="http://purl.org/eem#DestinationLocation">eem:DestinationLocation</a>
    /// </summary>
    let DestinationLocation = _prefixId.prefix "DestinationLocation"
    /// <summary>
    ///   <para>rdfs:label : Electronic Product Code^^xsd:string</para>
    ///   <para>rdfs:comment : A class for encapsulating the EPC for a physical thing through the datatype property
    /// hasEPCValue. ^^xsd:string</para>
    ///   <a href="http://purl.org/eem#EPC">eem:EPC</a>
    /// </summary>
    let EPC = _prefixId.prefix "EPC"
    /// <summary>
    ///   <para>rdfs:comment : A class-level identifier for the class to which the specified quantity of objects belongs.^^xsd:string</para>
    ///   <a href="http://purl.org/eem#EPCClass">eem:EPCClass</a>
    /// </summary>
    let EPCClass = _prefixId.prefix "EPCClass"
    let EPCISEvent = _prefixId.prefix "EPCISEvent"
    let EPCReader = _prefixId.prefix "EPCReader"
    /// <summary>
    ///   <para>rdfs:comment : Added in version 1.1^^xsd:string</para>
    ///   <a href="http://purl.org/eem#InputQuantityList">eem:InputQuantityList</a>
    /// </summary>
    let InputQuantityList = _prefixId.prefix "InputQuantityList"
    let OBSERVE = _prefixId.prefix "OBSERVE"
    /// <summary>
    ///   <para>rdfs:comment : An ObjectEvent captures information about an event pertaining to one or more
    /// physical objects identified by EPCs. ^^xsd:string</para>
    ///   <a href="http://purl.org/eem#ObjectEvent">eem:ObjectEvent</a>
    /// </summary>
    let ObjectEvent = _prefixId.prefix "ObjectEvent"
    /// <summary>
    ///   <para>rdfs:comment : Added in version 1.1^^xsd:string</para>
    ///   <a href="http://purl.org/eem#OutputQuantityList">eem:OutputQuantityList</a>
    /// </summary>
    let OutputQuantityList = _prefixId.prefix "OutputQuantityList"
    /// <summary>
    ///   <para>rdfs:comment : Added in version 1.1^^xsd:string</para>
    ///   <a href="http://purl.org/eem#QuantityElement">eem:QuantityElement</a>
    /// </summary>
    let QuantityElement = _prefixId.prefix "QuantityElement"
    /// <summary>
    ///   <para>rdfs:comment : represents an event concerned with a specific
    /// quantity of entities sharing a common EPC class^^xsd:string</para>
    ///   <a href="http://purl.org/eem#QuantityEvent">eem:QuantityEvent</a>
    /// </summary>
    let QuantityEvent = _prefixId.prefix "QuantityEvent"
    let ReadPointLocation = _prefixId.prefix "ReadPointLocation"
    let SetOfEvents = _prefixId.prefix "SetOfEvents"
    let SetOfTransactions = _prefixId.prefix "SetOfTransactions"
    let SetofEPCs = _prefixId.prefix "SetofEPCs"
    /// <summary>
    ///   <para>rdfs:comment : Added in version 1.1^^xsd:string</para>
    ///   <a href="http://purl.org/eem#SourceLocation">eem:SourceLocation</a>
    /// </summary>
    let SourceLocation = _prefixId.prefix "SourceLocation"
    let Transaction = _prefixId.prefix "Transaction"
    /// <summary>
    ///   <para>rdfs:comment : represents an event in which one or more entities
    /// denoted by EPCs become associated
    /// or disassociated with one or more
    /// identified business transactions. ^^xsd:string</para>
    ///   <a href="http://purl.org/eem#TransactionEvent">eem:TransactionEvent</a>
    /// </summary>
    let TransactionEvent = _prefixId.prefix "TransactionEvent"
    /// <summary>
    ///   <para>rdfs:comment : Added in version 1.1. Represents an event in which input
    /// objects are fully or partially consumed and output objects are produced, such that any of the input objects may have contributed to all of the output objects.^^xsd:string</para>
    ///   <a href="http://purl.org/eem#TransformationEvent">eem:TransformationEvent</a>
    /// </summary>
    let TransformationEvent = _prefixId.prefix "TransformationEvent"
    let action = _prefixId.prefix "action"
    let aggregationID = _prefixId.prefix "aggregationID"
    let associatedEPCAndTransaction = _prefixId.prefix "associatedEPCAndTransaction"
    let associatedWithAggregationID = _prefixId.prefix "associatedWithAggregationID"
    /// <summary>
    ///   <para>rdfs:comment : A product is associated with an EPC^^xsd:string</para>
    ///   <a href="http://purl.org/eem#associatedWithEPC">eem:associatedWithEPC</a>
    /// </summary>
    let associatedWithEPC = _prefixId.prefix "associatedWithEPC"
    let associatedWithEPCList = _prefixId.prefix "associatedWithEPCList"
    let associatedWithInputEPCList = _prefixId.prefix "associatedWithInputEPCList"
    let associatedWithItem = _prefixId.prefix "associatedWithItem"
    let associatedWithOutputEPCList = _prefixId.prefix "associatedWithOutputEPCList"
    let associatedWithTransactionList = _prefixId.prefix "associatedWithTransactionList"

    let associatedWithTransformationEvent =
        _prefixId.prefix "associatedWithTransformationEvent"

    let commissioned = _prefixId.prefix "commissioned"
    /// <summary>
    ///   <para>rdfs:comment : The EPC(s) named in the event have been decommissioned as part of this event; that is, the EPC(s) do not exist subsequent to the event and should not be observed again^^xsd:string</para>
    ///   <a href="http://purl.org/eem#decommissioned">eem:decommissioned</a>
    /// </summary>
    let decommissioned = _prefixId.prefix "decommissioned"
    let directlyFollowsEvent = _prefixId.prefix "directlyFollowsEvent"
    let directlyPrecedesEvent = _prefixId.prefix "directlyPrecedesEvent"

    let disassociatedWithAggregationID =
        _prefixId.prefix "disassociatedWithAggregationID"

    let eventOccurredAt = _prefixId.prefix "eventOccurredAt"
    let eventRecordedAt = _prefixId.prefix "eventRecordedAt"
    let eventTimeZoneOffset = _prefixId.prefix "eventTimeZoneOffset"
    let hasBusinessLocation = _prefixId.prefix "hasBusinessLocation"
    let hasBusinessStepType = _prefixId.prefix "hasBusinessStepType"
    let hasChildAddress = _prefixId.prefix "hasChildAddress"
    let hasClassLevelMasterData = _prefixId.prefix "hasClassLevelMasterData"
    let hasDispositionType = _prefixId.prefix "hasDispositionType"
    let hasEPCClass = _prefixId.prefix "hasEPCClass"
    let hasEPCID = _prefixId.prefix "hasEPCID"
    let hasInputQuantityList = _prefixId.prefix "hasInputQuantityList"
    let hasOutputQuantityList = _prefixId.prefix "hasOutputQuantityList"
    let hasReadPointLocation = _prefixId.prefix "hasReadPointLocation"
    let hasTransactionReference = _prefixId.prefix "hasTransactionReference"
    let hasTransactionType = _prefixId.prefix "hasTransactionType"
    let locationType = _prefixId.prefix "locationType"
    let logicalReaderID = _prefixId.prefix "logicalReaderID"
    let physicalReaderID = _prefixId.prefix "physicalReaderID"
    let quantity = _prefixId.prefix "quantity"
    let recordedByReader = _prefixId.prefix "recordedByReader"
    let transactionID = _prefixId.prefix "transactionID"
