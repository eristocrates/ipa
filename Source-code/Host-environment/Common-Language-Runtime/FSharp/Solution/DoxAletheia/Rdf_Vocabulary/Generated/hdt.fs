namespace http.purl.org.HDT.hdt.hash

open DoxAletheia

module hdt =
    let _namespace_name = "http://purl.org/HDT/hdt#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#Dataset"></see>
    /// </summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#IDCodification"></see>
    /// </summary>
    let IDCodification = _prefix "IDCodification"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamItem"></see>
    /// </summary>
    let streamItem = _prefix "streamItem"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#additionalInformation"></see>
    /// </summary>
    let additionalInformation = _prefix "additionalInformation"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#additionalItemCollection"></see>
    /// </summary>
    let additionalItemCollection = _prefix "additionalItemCollection"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#bitmapItem"></see>
    /// </summary>
    let bitmapItem = _prefix "bitmapItem"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionary"></see>
    /// </summary>
    let dictionary = _prefix "dictionary"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#formatInformation"></see>
    /// </summary>
    let formatInformation = _prefix "formatInformation"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryItemCollection"></see>
    /// </summary>
    let dictionaryItemCollection = _prefix "dictionaryItemCollection"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryEncoding"></see>
    /// </summary>
    let dictionaryEncoding = _prefix "dictionaryEncoding"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryNamespaces"></see>
    /// </summary>
    let dictionaryNamespaces = _prefix "dictionaryNamespaces"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryNamespacesCollection"></see>
    /// </summary>
    let dictionaryNamespacesCollection = _prefix "dictionaryNamespacesCollection"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryOrder"></see>
    /// </summary>
    let dictionaryOrder = _prefix "dictionaryOrder"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionarySeparator"></see>
    /// </summary>
    let dictionarySeparator = _prefix "dictionarySeparator"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#fileLocation"></see>
    /// </summary>
    let fileLocation = _prefix "fileLocation"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#formatItemCollection"></see>
    /// </summary>
    let formatItemCollection = _prefix "formatItemCollection"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#logBits"></see>
    /// </summary>
    let logBits = _prefix "logBits"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#namespace"></see>
    /// </summary>
    let namespace_ = _prefix "namespace"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#namespaceItem"></see>
    /// </summary>
    let namespaceItem = _prefix "namespaceItem"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#numberOfCommonSubjectObjects"></see>
    /// </summary>
    let numberOfCommonSubjectObjects = _prefix "numberOfCommonSubjectObjects"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#numberOfPredicates"></see>
    /// </summary>
    let numberOfPredicates = _prefix "numberOfPredicates"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#objectBitmap"></see>
    /// </summary>
    let objectBitmap = _prefix "objectBitmap"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triplesItemCollection"></see>
    /// </summary>
    let triplesItemCollection = _prefix "triplesItemCollection"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#objectCodification"></see>
    /// </summary>
    let objectCodification = _prefix "objectCodification"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#objectStream"></see>
    /// </summary>
    let objectStream = _prefix "objectStream"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#predicateBitmap"></see>
    /// </summary>
    let predicateBitmap = _prefix "predicateBitmap"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#predicateCodification"></see>
    /// </summary>
    let predicateCodification = _prefix "predicateCodification"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#predicateStream"></see>
    /// </summary>
    let predicateStream = _prefix "predicateStream"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#prefixLabel"></see>
    /// </summary>
    let prefixLabel = _prefix "prefixLabel"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#prefixURI"></see>
    /// </summary>
    let prefixURI = _prefix "prefixURI"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#publicationInformation"></see>
    /// </summary>
    let publicationInformation = _prefix "publicationInformation"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#publicationItemCollection"></see>
    /// </summary>
    let publicationItemCollection = _prefix "publicationItemCollection"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#statisticalInformation"></see>
    /// </summary>
    let statisticalInformation = _prefix "statisticalInformation"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#statisticalItemCollection"></see>
    /// </summary>
    let statisticalItemCollection = _prefix "statisticalItemCollection"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder"></see>
    /// </summary>
    let streamsOrder = _prefix "streamsOrder"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrders"></see>
    /// </summary>
    let streamsOrders = _prefix "streamsOrders"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_OPS"></see>
    /// </summary>
    let streamsOrder_OPS = _prefix "streamsOrder_OPS"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_OSP"></see>
    /// </summary>
    let streamsOrder_OSP = _prefix "streamsOrder_OSP"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_POS"></see>
    /// </summary>
    let streamsOrder_POS = _prefix "streamsOrder_POS"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_PSO"></see>
    /// </summary>
    let streamsOrder_PSO = _prefix "streamsOrder_PSO"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_SOP"></see>
    /// </summary>
    let streamsOrder_SOP = _prefix "streamsOrder_SOP"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_SPO"></see>
    /// </summary>
    let streamsOrder_SPO = _prefix "streamsOrder_SPO"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#subjectBitmap"></see>
    /// </summary>
    let subjectBitmap = _prefix "subjectBitmap"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#subjectCodification"></see>
    /// </summary>
    let subjectCodification = _prefix "subjectCodification"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#subjectObjectRatio"></see>
    /// </summary>
    let subjectObjectRatio = _prefix "subjectObjectRatio"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#subjectStream"></see>
    /// </summary>
    let subjectStream = _prefix "subjectStream"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triples"></see>
    /// </summary>
    let triples = _prefix "triples"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triplesBitmap"></see>
    /// </summary>
    let triplesBitmap = _prefix "triplesBitmap"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triplesCompact"></see>
    /// </summary>
    let triplesCompact = _prefix "triplesCompact"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triplesPlain"></see>
    /// </summary>
    let triplesPlain = _prefix "triplesPlain"
