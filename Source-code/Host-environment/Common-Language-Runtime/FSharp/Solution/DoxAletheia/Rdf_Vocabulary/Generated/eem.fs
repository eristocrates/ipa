namespace http.purl.org.eem.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eem =
    let _namespace_iri = Namespace_Iri eem |> NamespaceIRI
    /// <summary>
    ///   <para>eem:hasBusinessLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasBusinessLocation">http://purl.org/eem#hasBusinessLocation</seealso>
    let hasBusinessLocation = Prefixed_Name(eem, "hasBusinessLocation") |> PrefixedName

    /// <summary>
    ///   <para>eem:hasReadPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasReadPointLocation">http://purl.org/eem#hasReadPointLocation</seealso>
    let hasReadPointLocation =
        Prefixed_Name(eem, "hasReadPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>eem:SetofEPCs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#SetofEPCs">http://purl.org/eem#SetofEPCs</seealso>
    let SetofEPCs = Prefixed_Name(eem, "SetofEPCs") |> PrefixedName
    /// <summary>
    ///   <para>eem:DestinationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Added in version 1.1</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#DestinationLocation">http://purl.org/eem#DestinationLocation</seealso>
    let DestinationLocation = Prefixed_Name(eem, "DestinationLocation") |> PrefixedName
    /// <summary>
    ///   <para>eem:EPCReader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#EPCReader">http://purl.org/eem#EPCReader</seealso>
    let EPCReader = Prefixed_Name(eem, "EPCReader") |> PrefixedName
    /// <summary>
    ///   <para>eem:logicalReaderID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#logicalReaderID">http://purl.org/eem#logicalReaderID</seealso>
    let logicalReaderID = Prefixed_Name(eem, "logicalReaderID") |> PrefixedName
    /// <summary>
    ///   <para>eem:OBSERVE</para>
    /// </summary>
    /// <remarks>
    ///   <para>eem:Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The entity in question has not been changed: it has neither been created, added to, destroyed, or removed from.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#OBSERVE">http://purl.org/eem#OBSERVE</seealso>
    let OBSERVE = Prefixed_Name(eem, "OBSERVE") |> PrefixedName
    /// <summary>
    ///   <para>eem:OutputQuantityList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Added in version 1.1</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#OutputQuantityList">http://purl.org/eem#OutputQuantityList</seealso>
    let OutputQuantityList = Prefixed_Name(eem, "OutputQuantityList") |> PrefixedName
    /// <summary>
    ///   <para>eem:hasEPCClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasEPCClass">http://purl.org/eem#hasEPCClass</seealso>
    let hasEPCClass = Prefixed_Name(eem, "hasEPCClass") |> PrefixedName
    /// <summary>
    ///   <para>eem:quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#quantity">http://purl.org/eem#quantity</seealso>
    let quantity = Prefixed_Name(eem, "quantity") |> PrefixedName
    /// <summary>
    ///   <para>eem:SetOfTransactions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#SetOfTransactions">http://purl.org/eem#SetOfTransactions</seealso>
    let SetOfTransactions = Prefixed_Name(eem, "SetOfTransactions") |> PrefixedName
    /// <summary>
    ///   <para>eem:Transaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#Transaction">http://purl.org/eem#Transaction</seealso>
    let Transaction = Prefixed_Name(eem, "Transaction") |> PrefixedName
    /// <summary>
    ///   <para>eem:SourceLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Added in version 1.1</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#SourceLocation">http://purl.org/eem#SourceLocation</seealso>
    let SourceLocation = Prefixed_Name(eem, "SourceLocation") |> PrefixedName
    /// <summary>
    ///   <para>eem:transactionID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#transactionID">http://purl.org/eem#transactionID</seealso>
    let transactionID = Prefixed_Name(eem, "transactionID") |> PrefixedName
    /// <summary>
    ///   <para>eem:TransformationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Added in version 1.1. Represents an event in which input
    /// objects are fully or partially consumed and output objects are produced, such that any of the input objects may have contributed to all of the output objects.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#TransformationEvent">http://purl.org/eem#TransformationEvent</seealso>
    let TransformationEvent = Prefixed_Name(eem, "TransformationEvent") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedWithInputEPCList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedWithInputEPCList">http://purl.org/eem#associatedWithInputEPCList</seealso>
    let associatedWithInputEPCList =
        Prefixed_Name(eem, "associatedWithInputEPCList") |> PrefixedName

    /// <summary>
    ///   <para>eem:hasInputQuantityList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasInputQuantityList">http://purl.org/eem#hasInputQuantityList</seealso>
    let hasInputQuantityList =
        Prefixed_Name(eem, "hasInputQuantityList") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedWithTransformationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedWithTransformationEvent">http://purl.org/eem#associatedWithTransformationEvent</seealso>
    let associatedWithTransformationEvent =
        Prefixed_Name(eem, "associatedWithTransformationEvent") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedWithEPC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A product is associated with an EPC</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedWithEPC">http://purl.org/eem#associatedWithEPC</seealso>
    let associatedWithEPC = Prefixed_Name(eem, "associatedWithEPC") |> PrefixedName

    /// <summary>
    ///   <para>eem:directlyFollowsEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#directlyFollowsEvent">http://purl.org/eem#directlyFollowsEvent</seealso>
    let directlyFollowsEvent =
        Prefixed_Name(eem, "directlyFollowsEvent") |> PrefixedName

    /// <summary>
    ///   <para>eem:directlyPrecedesEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#directlyPrecedesEvent">http://purl.org/eem#directlyPrecedesEvent</seealso>
    let directlyPrecedesEvent =
        Prefixed_Name(eem, "directlyPrecedesEvent") |> PrefixedName

    /// <summary>
    ///   <para>eem:hasChildAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasChildAddress">http://purl.org/eem#hasChildAddress</seealso>
    let hasChildAddress = Prefixed_Name(eem, "hasChildAddress") |> PrefixedName

    /// <summary>
    ///   <para>eem:hasClassLevelMasterData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasClassLevelMasterData">http://purl.org/eem#hasClassLevelMasterData</seealso>
    let hasClassLevelMasterData =
        Prefixed_Name(eem, "hasClassLevelMasterData") |> PrefixedName

    /// <summary>
    ///   <para>eem:hasDispositionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasDispositionType">http://purl.org/eem#hasDispositionType</seealso>
    let hasDispositionType = Prefixed_Name(eem, "hasDispositionType") |> PrefixedName
    /// <summary>
    ///   <para>eem:hasEPCID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasEPCID">http://purl.org/eem#hasEPCID</seealso>
    let hasEPCID = Prefixed_Name(eem, "hasEPCID") |> PrefixedName

    /// <summary>
    ///   <para>eem:hasTransactionReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasTransactionReference">http://purl.org/eem#hasTransactionReference</seealso>
    let hasTransactionReference =
        Prefixed_Name(eem, "hasTransactionReference") |> PrefixedName

    /// <summary>
    ///   <para>eem:locationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#locationType">http://purl.org/eem#locationType</seealso>
    let locationType = Prefixed_Name(eem, "locationType") |> PrefixedName
    /// <summary>
    ///   <para>eem:recordedByReader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#recordedByReader">http://purl.org/eem#recordedByReader</seealso>
    let recordedByReader = Prefixed_Name(eem, "recordedByReader") |> PrefixedName
    /// <summary>
    ///   <para>eem:EPCISEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#EPCISEvent">http://purl.org/eem#EPCISEvent</seealso>
    let EPCISEvent = Prefixed_Name(eem, "EPCISEvent") |> PrefixedName
    /// <summary>
    ///   <para>eem:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#action">http://purl.org/eem#action</seealso>
    let action = Prefixed_Name(eem, "action") |> PrefixedName
    /// <summary>
    ///   <para>eem:ADD</para>
    /// </summary>
    /// <remarks>
    ///   <para>eem:Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The entity in question has been created or added to</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#ADD">http://purl.org/eem#ADD</seealso>
    let ADD = Prefixed_Name(eem, "ADD") |> PrefixedName
    /// <summary>
    ///   <para>eem:EPCClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class-level identifier for the class to which the specified quantity of objects belongs.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#EPCClass">http://purl.org/eem#EPCClass</seealso>
    let EPCClass = Prefixed_Name(eem, "EPCClass") |> PrefixedName
    /// <summary>
    ///   <para>eem:eventOccurredAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#eventOccurredAt">http://purl.org/eem#eventOccurredAt</seealso>
    let eventOccurredAt = Prefixed_Name(eem, "eventOccurredAt") |> PrefixedName
    /// <summary>
    ///   <para>eem:eventTimeZoneOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#eventTimeZoneOffset">http://purl.org/eem#eventTimeZoneOffset</seealso>
    let eventTimeZoneOffset = Prefixed_Name(eem, "eventTimeZoneOffset") |> PrefixedName
    /// <summary>
    ///   <para>eem:InputQuantityList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Added in version 1.1</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#InputQuantityList">http://purl.org/eem#InputQuantityList</seealso>
    let InputQuantityList = Prefixed_Name(eem, "InputQuantityList") |> PrefixedName
    /// <summary>
    ///   <para>eem:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Action type says how an event relates to the lifecycle of the entity being described.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#Action">http://purl.org/eem#Action</seealso>
    let Action = Prefixed_Name(eem, "Action") |> PrefixedName
    /// <summary>
    ///   <para>eem:AggregationID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concept represent the aggregation identifier of a packagaing unit</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#AggregationID">http://purl.org/eem#AggregationID</seealso>
    let AggregationID = Prefixed_Name(eem, "AggregationID") |> PrefixedName
    /// <summary>
    ///   <para>eem:EPC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class for encapsulating the EPC for a physical thing through the datatype property
    /// hasEPCValue. </para>
    /// labels<para>Electronic Product Code</para></remarks>
    /// <seealso href="http://purl.org/eem#EPC">http://purl.org/eem#EPC</seealso>
    let EPC = Prefixed_Name(eem, "EPC") |> PrefixedName
    /// <summary>
    ///   <para>eem:BusinessLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#BusinessLocation">http://purl.org/eem#BusinessLocation</seealso>
    let BusinessLocation = Prefixed_Name(eem, "BusinessLocation") |> PrefixedName
    /// <summary>
    ///   <para>eem:ObjectEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ObjectEvent captures information about an event pertaining to one or more
    /// physical objects identified by EPCs. </para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#ObjectEvent">http://purl.org/eem#ObjectEvent</seealso>
    let ObjectEvent = Prefixed_Name(eem, "ObjectEvent") |> PrefixedName
    /// <summary>
    ///   <para>eem:eventRecordedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#eventRecordedAt">http://purl.org/eem#eventRecordedAt</seealso>
    let eventRecordedAt = Prefixed_Name(eem, "eventRecordedAt") |> PrefixedName
    /// <summary>
    ///   <para>eem:physicalReaderID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#physicalReaderID">http://purl.org/eem#physicalReaderID</seealso>
    let physicalReaderID = Prefixed_Name(eem, "physicalReaderID") |> PrefixedName
    /// <summary>
    ///   <para>eem:QuantityElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Added in version 1.1</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#QuantityElement">http://purl.org/eem#QuantityElement</seealso>
    let QuantityElement = Prefixed_Name(eem, "QuantityElement") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedWithEPCList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedWithEPCList">http://purl.org/eem#associatedWithEPCList</seealso>
    let associatedWithEPCList =
        Prefixed_Name(eem, "associatedWithEPCList") |> PrefixedName

    /// <summary>
    ///   <para>eem:commissioned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#commissioned">http://purl.org/eem#commissioned</seealso>
    let commissioned = Prefixed_Name(eem, "commissioned") |> PrefixedName
    /// <summary>
    ///   <para>eem:ReadPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#ReadPointLocation">http://purl.org/eem#ReadPointLocation</seealso>
    let ReadPointLocation = Prefixed_Name(eem, "ReadPointLocation") |> PrefixedName
    /// <summary>
    ///   <para>eem:SetOfEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#SetOfEvents">http://purl.org/eem#SetOfEvents</seealso>
    let SetOfEvents = Prefixed_Name(eem, "SetOfEvents") |> PrefixedName
    /// <summary>
    ///   <para>eem:hasTransactionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasTransactionType">http://purl.org/eem#hasTransactionType</seealso>
    let hasTransactionType = Prefixed_Name(eem, "hasTransactionType") |> PrefixedName
    /// <summary>
    ///   <para>eem:hasBusinessStepType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasBusinessStepType">http://purl.org/eem#hasBusinessStepType</seealso>
    let hasBusinessStepType = Prefixed_Name(eem, "hasBusinessStepType") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedWithOutputEPCList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedWithOutputEPCList">http://purl.org/eem#associatedWithOutputEPCList</seealso>
    let associatedWithOutputEPCList =
        Prefixed_Name(eem, "associatedWithOutputEPCList") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedWithItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedWithItem">http://purl.org/eem#associatedWithItem</seealso>
    let associatedWithItem = Prefixed_Name(eem, "associatedWithItem") |> PrefixedName

    /// <summary>
    ///   <para>eem:hasOutputQuantityList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#hasOutputQuantityList">http://purl.org/eem#hasOutputQuantityList</seealso>
    let hasOutputQuantityList =
        Prefixed_Name(eem, "hasOutputQuantityList") |> PrefixedName

    /// <summary>
    ///   <para>eem:disassociatedWithAggregationID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#disassociatedWithAggregationID">http://purl.org/eem#disassociatedWithAggregationID</seealso>
    let disassociatedWithAggregationID =
        Prefixed_Name(eem, "disassociatedWithAggregationID") |> PrefixedName

    /// <summary>
    ///   <para>eem:DELETE</para>
    /// </summary>
    /// <remarks>
    ///   <para>eem:Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The entity in question has been removed from or destroyed
    /// altogether. </para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#DELETE">http://purl.org/eem#DELETE</seealso>
    let DELETE = Prefixed_Name(eem, "DELETE") |> PrefixedName
    /// <summary>
    ///   <para>eem:decommissioned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The EPC(s) named in the event have been decommissioned as part of this event; that is, the EPC(s) do not exist subsequent to the event and should not be observed again</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#decommissioned">http://purl.org/eem#decommissioned</seealso>
    let decommissioned = Prefixed_Name(eem, "decommissioned") |> PrefixedName
    /// <summary>
    ///   <para>eem:AggregationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents an event that happened to one or more entities denoted by EPCs that are phys
    /// ically aggregated together (physically constrained to be in the same place at the same time, as when cases are aggregated to a pallet). </para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#AggregationEvent">http://purl.org/eem#AggregationEvent</seealso>
    let AggregationEvent = Prefixed_Name(eem, "AggregationEvent") |> PrefixedName
    /// <summary>
    ///   <para>eem:aggregationID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#aggregationID">http://purl.org/eem#aggregationID</seealso>
    let aggregationID = Prefixed_Name(eem, "aggregationID") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedEPCAndTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedEPCAndTransaction">http://purl.org/eem#associatedEPCAndTransaction</seealso>
    let associatedEPCAndTransaction =
        Prefixed_Name(eem, "associatedEPCAndTransaction") |> PrefixedName

    /// <summary>
    ///   <para>eem:QuantityEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents an event concerned with a specific
    /// quantity of entities sharing a common EPC class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#QuantityEvent">http://purl.org/eem#QuantityEvent</seealso>
    let QuantityEvent = Prefixed_Name(eem, "QuantityEvent") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedWithAggregationID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedWithAggregationID">http://purl.org/eem#associatedWithAggregationID</seealso>
    let associatedWithAggregationID =
        Prefixed_Name(eem, "associatedWithAggregationID") |> PrefixedName

    /// <summary>
    ///   <para>eem:TransactionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>represents an event in which one or more entities
    /// denoted by EPCs become associated
    /// or disassociated with one or more
    /// identified business transactions. </para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#TransactionEvent">http://purl.org/eem#TransactionEvent</seealso>
    let TransactionEvent = Prefixed_Name(eem, "TransactionEvent") |> PrefixedName

    /// <summary>
    ///   <para>eem:associatedWithTransactionList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/eem#associatedWithTransactionList">http://purl.org/eem#associatedWithTransactionList</seealso>
    let associatedWithTransactionList =
        Prefixed_Name(eem, "associatedWithTransactionList") |> PrefixedName
