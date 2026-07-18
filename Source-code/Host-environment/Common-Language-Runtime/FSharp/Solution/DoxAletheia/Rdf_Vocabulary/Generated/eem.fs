namespace http.purl.org.eem.hash

open DoxAletheia.Rdf_Vocabulary

module eem =
    let _namespace_name = "http://purl.org/eem#"
    /// <summary>
    ///   <see href="http://purl.org/eem#EPCISEvent"></see>
    /// </summary>
    let EPCISEvent = Namespaced_IRI.parse _namespace_name "EPCISEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasBusinessLocation"></see>
    /// </summary>
    let hasBusinessLocation =
        Namespaced_IRI.parse _namespace_name "hasBusinessLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasReadPointLocation"></see>
    /// </summary>
    let hasReadPointLocation =
        Namespaced_IRI.parse _namespace_name "hasReadPointLocation" |> NamespacedName

    /// <summary>
    /// An ObjectEvent captures information about an event pertaining to one or more
    /// physical objects identified by EPCs.
    /// <see href="http://purl.org/eem#ObjectEvent"></see></summary>
    let ObjectEvent =
        Namespaced_IRI.parse _namespace_name "ObjectEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#action"></see>
    /// </summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName
    /// <summary>
    /// The entity in question has been created or added to
    /// <see href="http://purl.org/eem#ADD"></see></summary>
    let ADD = Namespaced_IRI.parse _namespace_name "ADD" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithEPCList"></see>
    /// </summary>
    let associatedWithEPCList =
        Namespaced_IRI.parse _namespace_name "associatedWithEPCList" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasBusinessStepType"></see>
    /// </summary>
    let hasBusinessStepType =
        Namespaced_IRI.parse _namespace_name "hasBusinessStepType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#commissioned"></see>
    /// </summary>
    let commissioned =
        Namespaced_IRI.parse _namespace_name "commissioned" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithItem"></see>
    /// </summary>
    let associatedWithItem =
        Namespaced_IRI.parse _namespace_name "associatedWithItem" |> NamespacedName

    /// <summary>
    /// represents an event in which one or more entities
    /// denoted by EPCs become associated
    /// or disassociated with one or more
    /// identified business transactions.
    /// <see href="http://purl.org/eem#TransactionEvent"></see></summary>
    let TransactionEvent =
        Namespaced_IRI.parse _namespace_name "TransactionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithTransactionList"></see>
    /// </summary>
    let associatedWithTransactionList =
        Namespaced_IRI.parse _namespace_name "associatedWithTransactionList" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#disassociatedWithAggregationID"></see>
    /// </summary>
    let disassociatedWithAggregationID =
        Namespaced_IRI.parse _namespace_name "disassociatedWithAggregationID" |> NamespacedName

    /// <summary>
    /// The entity in question has been removed from or destroyed
    /// altogether.
    /// <see href="http://purl.org/eem#DELETE"></see></summary>
    let DELETE = Namespaced_IRI.parse _namespace_name "DELETE" |> NamespacedName

    /// <summary>
    /// The EPC(s) named in the event have been decommissioned as part of this event; that is, the EPC(s) do not exist subsequent to the event and should not be observed again
    /// <see href="http://purl.org/eem#decommissioned"></see></summary>
    let decommissioned =
        Namespaced_IRI.parse _namespace_name "decommissioned" |> NamespacedName

    /// <summary>
    /// Represents an event that happened to one or more entities denoted by EPCs that are phys
    /// ically aggregated together (physically constrained to be in the same place at the same time, as when cases are aggregated to a pallet).
    /// <see href="http://purl.org/eem#AggregationEvent"></see></summary>
    let AggregationEvent =
        Namespaced_IRI.parse _namespace_name "AggregationEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#aggregationID"></see>
    /// </summary>
    let aggregationID =
        Namespaced_IRI.parse _namespace_name "aggregationID" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#associatedEPCAndTransaction"></see>
    /// </summary>
    let associatedEPCAndTransaction =
        Namespaced_IRI.parse _namespace_name "associatedEPCAndTransaction" |> NamespacedName

    /// <summary>
    /// represents an event concerned with a specific
    /// quantity of entities sharing a common EPC class
    /// <see href="http://purl.org/eem#QuantityEvent"></see></summary>
    let QuantityEvent =
        Namespaced_IRI.parse _namespace_name "QuantityEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithAggregationID"></see>
    /// </summary>
    let associatedWithAggregationID =
        Namespaced_IRI.parse _namespace_name "associatedWithAggregationID" |> NamespacedName

    /// <summary>
    /// The Action type says how an event relates to the lifecycle of the entity being described.
    /// <see href="http://purl.org/eem#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/eem#SetofEPCs"></see>
    /// </summary>
    let SetofEPCs = Namespaced_IRI.parse _namespace_name "SetofEPCs" |> NamespacedName

    /// <summary>
    /// A concept represent the aggregation identifier of a packagaing unit
    /// <see href="http://purl.org/eem#AggregationID"></see></summary>
    let AggregationID =
        Namespaced_IRI.parse _namespace_name "AggregationID" |> NamespacedName

    /// <summary>
    /// A class for encapsulating the EPC for a physical thing through the datatype property
    /// hasEPCValue.
    /// <see href="http://purl.org/eem#EPC"></see></summary>
    let EPC = Namespaced_IRI.parse _namespace_name "EPC" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#BusinessLocation"></see>
    /// </summary>
    let BusinessLocation =
        Namespaced_IRI.parse _namespace_name "BusinessLocation" |> NamespacedName

    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#DestinationLocation"></see></summary>
    let DestinationLocation =
        Namespaced_IRI.parse _namespace_name "DestinationLocation" |> NamespacedName

    /// <summary>
    /// A class-level identifier for the class to which the specified quantity of objects belongs.
    /// <see href="http://purl.org/eem#EPCClass"></see></summary>
    let EPCClass = Namespaced_IRI.parse _namespace_name "EPCClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#eventOccurredAt"></see>
    /// </summary>
    let eventOccurredAt =
        Namespaced_IRI.parse _namespace_name "eventOccurredAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#eventTimeZoneOffset"></see>
    /// </summary>
    let eventTimeZoneOffset =
        Namespaced_IRI.parse _namespace_name "eventTimeZoneOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#eventRecordedAt"></see>
    /// </summary>
    let eventRecordedAt =
        Namespaced_IRI.parse _namespace_name "eventRecordedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#EPCReader"></see>
    /// </summary>
    let EPCReader = Namespaced_IRI.parse _namespace_name "EPCReader" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#logicalReaderID"></see>
    /// </summary>
    let logicalReaderID =
        Namespaced_IRI.parse _namespace_name "logicalReaderID" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#physicalReaderID"></see>
    /// </summary>
    let physicalReaderID =
        Namespaced_IRI.parse _namespace_name "physicalReaderID" |> NamespacedName

    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#InputQuantityList"></see></summary>
    let InputQuantityList =
        Namespaced_IRI.parse _namespace_name "InputQuantityList" |> NamespacedName

    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#QuantityElement"></see></summary>
    let QuantityElement =
        Namespaced_IRI.parse _namespace_name "QuantityElement" |> NamespacedName

    /// <summary>
    /// The entity in question has not been changed: it has neither been created, added to, destroyed, or removed from.
    /// <see href="http://purl.org/eem#OBSERVE"></see></summary>
    let OBSERVE = Namespaced_IRI.parse _namespace_name "OBSERVE" |> NamespacedName

    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#OutputQuantityList"></see></summary>
    let OutputQuantityList =
        Namespaced_IRI.parse _namespace_name "OutputQuantityList" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasEPCClass"></see>
    /// </summary>
    let hasEPCClass =
        Namespaced_IRI.parse _namespace_name "hasEPCClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#quantity"></see>
    /// </summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#ReadPointLocation"></see>
    /// </summary>
    let ReadPointLocation =
        Namespaced_IRI.parse _namespace_name "ReadPointLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#SetOfEvents"></see>
    /// </summary>
    let SetOfEvents =
        Namespaced_IRI.parse _namespace_name "SetOfEvents" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#SetOfTransactions"></see>
    /// </summary>
    let SetOfTransactions =
        Namespaced_IRI.parse _namespace_name "SetOfTransactions" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#Transaction"></see>
    /// </summary>
    let Transaction =
        Namespaced_IRI.parse _namespace_name "Transaction" |> NamespacedName

    /// <summary>
    /// Added in version 1.1
    /// <see href="http://purl.org/eem#SourceLocation"></see></summary>
    let SourceLocation =
        Namespaced_IRI.parse _namespace_name "SourceLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasTransactionType"></see>
    /// </summary>
    let hasTransactionType =
        Namespaced_IRI.parse _namespace_name "hasTransactionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#transactionID"></see>
    /// </summary>
    let transactionID =
        Namespaced_IRI.parse _namespace_name "transactionID" |> NamespacedName

    /// <summary>
    /// Added in version 1.1. Represents an event in which input
    /// objects are fully or partially consumed and output objects are produced, such that any of the input objects may have contributed to all of the output objects.
    /// <see href="http://purl.org/eem#TransformationEvent"></see></summary>
    let TransformationEvent =
        Namespaced_IRI.parse _namespace_name "TransformationEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithInputEPCList"></see>
    /// </summary>
    let associatedWithInputEPCList =
        Namespaced_IRI.parse _namespace_name "associatedWithInputEPCList" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasInputQuantityList"></see>
    /// </summary>
    let hasInputQuantityList =
        Namespaced_IRI.parse _namespace_name "hasInputQuantityList" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithOutputEPCList"></see>
    /// </summary>
    let associatedWithOutputEPCList =
        Namespaced_IRI.parse _namespace_name "associatedWithOutputEPCList" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasOutputQuantityList"></see>
    /// </summary>
    let hasOutputQuantityList =
        Namespaced_IRI.parse _namespace_name "hasOutputQuantityList" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#associatedWithTransformationEvent"></see>
    /// </summary>
    let associatedWithTransformationEvent =
        Namespaced_IRI.parse _namespace_name "associatedWithTransformationEvent" |> NamespacedName

    /// <summary>
    /// A product is associated with an EPC
    /// <see href="http://purl.org/eem#associatedWithEPC"></see></summary>
    let associatedWithEPC =
        Namespaced_IRI.parse _namespace_name "associatedWithEPC" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#directlyFollowsEvent"></see>
    /// </summary>
    let directlyFollowsEvent =
        Namespaced_IRI.parse _namespace_name "directlyFollowsEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#directlyPrecedesEvent"></see>
    /// </summary>
    let directlyPrecedesEvent =
        Namespaced_IRI.parse _namespace_name "directlyPrecedesEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasChildAddress"></see>
    /// </summary>
    let hasChildAddress =
        Namespaced_IRI.parse _namespace_name "hasChildAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasClassLevelMasterData"></see>
    /// </summary>
    let hasClassLevelMasterData =
        Namespaced_IRI.parse _namespace_name "hasClassLevelMasterData" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasDispositionType"></see>
    /// </summary>
    let hasDispositionType =
        Namespaced_IRI.parse _namespace_name "hasDispositionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasEPCID"></see>
    /// </summary>
    let hasEPCID = Namespaced_IRI.parse _namespace_name "hasEPCID" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#hasTransactionReference"></see>
    /// </summary>
    let hasTransactionReference =
        Namespaced_IRI.parse _namespace_name "hasTransactionReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#locationType"></see>
    /// </summary>
    let locationType =
        Namespaced_IRI.parse _namespace_name "locationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/eem#recordedByReader"></see>
    /// </summary>
    let recordedByReader =
        Namespaced_IRI.parse _namespace_name "recordedByReader" |> NamespacedName
