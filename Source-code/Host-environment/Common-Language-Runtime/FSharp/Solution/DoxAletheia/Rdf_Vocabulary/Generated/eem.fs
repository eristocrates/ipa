namespace http.purl.org.eem.hash

open DoxAletheia

module eem =
    let _namespace_name = "http://purl.org/eem#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#EPCISEvent"></see>
    /// </summary>
    let EPCISEvent = _prefix "EPCISEvent"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasBusinessLocation"></see>
    /// </summary>
    let hasBusinessLocation = _prefix "hasBusinessLocation"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasReadPointLocation"></see>
    /// </summary>
    let hasReadPointLocation = _prefix "hasReadPointLocation"
    /// <summary>
    /// An ObjectEvent captures information about an event pertaining to one or more
    /// physical objects identified by EPCs.
    /// <see href="http://purl.org/eem#ObjectEvent"></see></summary>
    let ObjectEvent = _prefix "ObjectEvent"
    /// <summary>
    ///   <see href="http://purl.org/eem#action"></see>
    /// </summary>
    let action = _prefix "action"
    /// <summary>
    /// The entity in question has been created or added to
    /// <see href="http://purl.org/eem#ADD"></see></summary>
    let ADD = _prefix "ADD"
    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithEPCList"></see>
    /// </summary>
    let associatedWithEPCList = _prefix "associatedWithEPCList"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasBusinessStepType"></see>
    /// </summary>
    let hasBusinessStepType = _prefix "hasBusinessStepType"
    /// <summary>
    ///   <see href="http://purl.org/eem#commissioned"></see>
    /// </summary>
    let commissioned = _prefix "commissioned"
    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithItem"></see>
    /// </summary>
    let associatedWithItem = _prefix "associatedWithItem"
    /// <summary>
    /// represents an event in which one or more entities
    /// denoted by EPCs become associated
    /// or disassociated with one or more
    /// identified business transactions.
    /// <see href="http://purl.org/eem#TransactionEvent"></see></summary>
    let TransactionEvent = _prefix "TransactionEvent"
    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithTransactionList"></see>
    /// </summary>
    let associatedWithTransactionList = _prefix "associatedWithTransactionList"
    /// <summary>
    ///   <see href="http://purl.org/eem#disassociatedWithAggregationID"></see>
    /// </summary>
    let disassociatedWithAggregationID = _prefix "disassociatedWithAggregationID"
    /// <summary>
    /// The entity in question has been removed from or destroyed
    /// altogether.
    /// <see href="http://purl.org/eem#DELETE"></see></summary>
    let DELETE = _prefix "DELETE"
    /// <summary>
    /// The EPC(s) named in the event have been decommissioned as part of this event; that is, the EPC(s) do not exist subsequent to the event and should not be observed again
    /// <see href="http://purl.org/eem#decommissioned"></see></summary>
    let decommissioned = _prefix "decommissioned"
    /// <summary>
    /// Represents an event that happened to one or more entities denoted by EPCs that are phys
    /// ically aggregated together (physically constrained to be in the same place at the same time, as when cases are aggregated to a pallet).
    /// <see href="http://purl.org/eem#AggregationEvent"></see></summary>
    let AggregationEvent = _prefix "AggregationEvent"
    /// <summary>
    ///   <see href="http://purl.org/eem#aggregationID"></see>
    /// </summary>
    let aggregationID = _prefix "aggregationID"
    /// <summary>
    ///   <see href="http://purl.org/eem#associatedEPCAndTransaction"></see>
    /// </summary>
    let associatedEPCAndTransaction = _prefix "associatedEPCAndTransaction"
    /// <summary>
    /// represents an event concerned with a specific
    /// quantity of entities sharing a common EPC class
    /// <see href="http://purl.org/eem#QuantityEvent"></see></summary>
    let QuantityEvent = _prefix "QuantityEvent"
    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithAggregationID"></see>
    /// </summary>
    let associatedWithAggregationID = _prefix "associatedWithAggregationID"
    /// <summary>
    /// The Action type says how an event relates to the lifecycle of the entity being described.
    /// <see href="http://purl.org/eem#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://purl.org/eem#SetofEPCs"></see>
    /// </summary>
    let SetofEPCs = _prefix "SetofEPCs"
    /// <summary>
    /// A concept represent the aggregation identifier of a packagaing unit
    /// <see href="http://purl.org/eem#AggregationID"></see></summary>
    let AggregationID = _prefix "AggregationID"
    /// <summary>
    /// A class for encapsulating the EPC for a physical thing through the datatype property
    /// hasEPCValue.
    /// <see href="http://purl.org/eem#EPC"></see></summary>
    let EPC = _prefix "EPC"
    /// <summary>
    ///   <see href="http://purl.org/eem#BusinessLocation"></see>
    /// </summary>
    let BusinessLocation = _prefix "BusinessLocation"
    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#DestinationLocation"></see></summary>
    let DestinationLocation = _prefix "DestinationLocation"
    /// <summary>
    /// A class-level identifier for the class to which the specified quantity of objects belongs.
    /// <see href="http://purl.org/eem#EPCClass"></see></summary>
    let EPCClass = _prefix "EPCClass"
    /// <summary>
    ///   <see href="http://purl.org/eem#eventOccurredAt"></see>
    /// </summary>
    let eventOccurredAt = _prefix "eventOccurredAt"
    /// <summary>
    ///   <see href="http://purl.org/eem#eventTimeZoneOffset"></see>
    /// </summary>
    let eventTimeZoneOffset = _prefix "eventTimeZoneOffset"
    /// <summary>
    ///   <see href="http://purl.org/eem#eventRecordedAt"></see>
    /// </summary>
    let eventRecordedAt = _prefix "eventRecordedAt"
    /// <summary>
    ///   <see href="http://purl.org/eem#EPCReader"></see>
    /// </summary>
    let EPCReader = _prefix "EPCReader"
    /// <summary>
    ///   <see href="http://purl.org/eem#logicalReaderID"></see>
    /// </summary>
    let logicalReaderID = _prefix "logicalReaderID"
    /// <summary>
    ///   <see href="http://purl.org/eem#physicalReaderID"></see>
    /// </summary>
    let physicalReaderID = _prefix "physicalReaderID"
    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#InputQuantityList"></see></summary>
    let InputQuantityList = _prefix "InputQuantityList"
    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#QuantityElement"></see></summary>
    let QuantityElement = _prefix "QuantityElement"
    /// <summary>
    /// The entity in question has not been changed: it has neither been created, added to, destroyed, or removed from.
    /// <see href="http://purl.org/eem#OBSERVE"></see></summary>
    let OBSERVE = _prefix "OBSERVE"
    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#OutputQuantityList"></see></summary>
    let OutputQuantityList = _prefix "OutputQuantityList"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasEPCClass"></see>
    /// </summary>
    let hasEPCClass = _prefix "hasEPCClass"
    /// <summary>
    ///   <see href="http://purl.org/eem#quantity"></see>
    /// </summary>
    let quantity = _prefix "quantity"
    /// <summary>
    ///   <see href="http://purl.org/eem#ReadPointLocation"></see>
    /// </summary>
    let ReadPointLocation = _prefix "ReadPointLocation"
    /// <summary>
    ///   <see href="http://purl.org/eem#SetOfEvents"></see>
    /// </summary>
    let SetOfEvents = _prefix "SetOfEvents"
    /// <summary>
    ///   <see href="http://purl.org/eem#SetOfTransactions"></see>
    /// </summary>
    let SetOfTransactions = _prefix "SetOfTransactions"
    /// <summary>
    ///   <see href="http://purl.org/eem#Transaction"></see>
    /// </summary>
    let Transaction = _prefix "Transaction"
    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#SourceLocation"></see></summary>
    let SourceLocation = _prefix "SourceLocation"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasTransactionType"></see>
    /// </summary>
    let hasTransactionType = _prefix "hasTransactionType"
    /// <summary>
    ///   <see href="http://purl.org/eem#transactionID"></see>
    /// </summary>
    let transactionID = _prefix "transactionID"
    /// <summary>
    /// Added in version 1.1. Represents an event in which input
    /// objects are fully or partially consumed and output objects are produced, such that any of the input objects may have contributed to all of the output objects.
    /// <see href="http://purl.org/eem#TransformationEvent"></see></summary>
    let TransformationEvent = _prefix "TransformationEvent"
    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithInputEPCList"></see>
    /// </summary>
    let associatedWithInputEPCList = _prefix "associatedWithInputEPCList"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasInputQuantityList"></see>
    /// </summary>
    let hasInputQuantityList = _prefix "hasInputQuantityList"
    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithOutputEPCList"></see>
    /// </summary>
    let associatedWithOutputEPCList = _prefix "associatedWithOutputEPCList"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasOutputQuantityList"></see>
    /// </summary>
    let hasOutputQuantityList = _prefix "hasOutputQuantityList"
    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithTransformationEvent"></see>
    /// </summary>
    let associatedWithTransformationEvent = _prefix "associatedWithTransformationEvent"
    /// <summary>
    /// A product is associated with an EPC
    /// <see href="http://purl.org/eem#associatedWithEPC"></see></summary>
    let associatedWithEPC = _prefix "associatedWithEPC"
    /// <summary>
    ///   <see href="http://purl.org/eem#directlyFollowsEvent"></see>
    /// </summary>
    let directlyFollowsEvent = _prefix "directlyFollowsEvent"
    /// <summary>
    ///   <see href="http://purl.org/eem#directlyPrecedesEvent"></see>
    /// </summary>
    let directlyPrecedesEvent = _prefix "directlyPrecedesEvent"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasChildAddress"></see>
    /// </summary>
    let hasChildAddress = _prefix "hasChildAddress"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasClassLevelMasterData"></see>
    /// </summary>
    let hasClassLevelMasterData = _prefix "hasClassLevelMasterData"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasDispositionType"></see>
    /// </summary>
    let hasDispositionType = _prefix "hasDispositionType"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasEPCID"></see>
    /// </summary>
    let hasEPCID = _prefix "hasEPCID"
    /// <summary>
    ///   <see href="http://purl.org/eem#hasTransactionReference"></see>
    /// </summary>
    let hasTransactionReference = _prefix "hasTransactionReference"
    /// <summary>
    ///   <see href="http://purl.org/eem#locationType"></see>
    /// </summary>
    let locationType = _prefix "locationType"
    /// <summary>
    ///   <see href="http://purl.org/eem#recordedByReader"></see>
    /// </summary>
    let recordedByReader = _prefix "recordedByReader"
