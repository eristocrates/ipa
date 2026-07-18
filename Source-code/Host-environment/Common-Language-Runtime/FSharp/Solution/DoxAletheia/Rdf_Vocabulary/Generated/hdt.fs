namespace http.purl.org.HDT.hdt.hash

open DoxAletheia.Rdf_Vocabulary

module hdt =
    let _namespace_name = "http://purl.org/HDT/hdt#"
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#Dataset"></see>
    /// </summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#IDCodification"></see>
    /// </summary>
    let IDCodification =
        Namespaced_IRI.parse _namespace_name "IDCodification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamItem"></see>
    /// </summary>
    let streamItem = Namespaced_IRI.parse _namespace_name "streamItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#additionalInformation"></see>
    /// </summary>
    let additionalInformation =
        Namespaced_IRI.parse _namespace_name "additionalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#additionalItemCollection"></see>
    /// </summary>
    let additionalItemCollection =
        Namespaced_IRI.parse _namespace_name "additionalItemCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#bitmapItem"></see>
    /// </summary>
    let bitmapItem = Namespaced_IRI.parse _namespace_name "bitmapItem" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionary"></see>
    /// </summary>
    let dictionary = Namespaced_IRI.parse _namespace_name "dictionary" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#formatInformation"></see>
    /// </summary>
    let formatInformation =
        Namespaced_IRI.parse _namespace_name "formatInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryItemCollection"></see>
    /// </summary>
    let dictionaryItemCollection =
        Namespaced_IRI.parse _namespace_name "dictionaryItemCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryEncoding"></see>
    /// </summary>
    let dictionaryEncoding =
        Namespaced_IRI.parse _namespace_name "dictionaryEncoding" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryNamespaces"></see>
    /// </summary>
    let dictionaryNamespaces =
        Namespaced_IRI.parse _namespace_name "dictionaryNamespaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryNamespacesCollection"></see>
    /// </summary>
    let dictionaryNamespacesCollection =
        Namespaced_IRI.parse _namespace_name "dictionaryNamespacesCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionaryOrder"></see>
    /// </summary>
    let dictionaryOrder =
        Namespaced_IRI.parse _namespace_name "dictionaryOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#dictionarySeparator"></see>
    /// </summary>
    let dictionarySeparator =
        Namespaced_IRI.parse _namespace_name "dictionarySeparator" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#fileLocation"></see>
    /// </summary>
    let fileLocation =
        Namespaced_IRI.parse _namespace_name "fileLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#formatItemCollection"></see>
    /// </summary>
    let formatItemCollection =
        Namespaced_IRI.parse _namespace_name "formatItemCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#logBits"></see>
    /// </summary>
    let logBits = Namespaced_IRI.parse _namespace_name "logBits" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#namespace"></see>
    /// </summary>
    let namespace_ = Namespaced_IRI.parse _namespace_name "namespace" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#namespaceItem"></see>
    /// </summary>
    let namespaceItem =
        Namespaced_IRI.parse _namespace_name "namespaceItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#numberOfCommonSubjectObjects"></see>
    /// </summary>
    let numberOfCommonSubjectObjects =
        Namespaced_IRI.parse _namespace_name "numberOfCommonSubjectObjects" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#numberOfPredicates"></see>
    /// </summary>
    let numberOfPredicates =
        Namespaced_IRI.parse _namespace_name "numberOfPredicates" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#objectBitmap"></see>
    /// </summary>
    let objectBitmap =
        Namespaced_IRI.parse _namespace_name "objectBitmap" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triplesItemCollection"></see>
    /// </summary>
    let triplesItemCollection =
        Namespaced_IRI.parse _namespace_name "triplesItemCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#objectCodification"></see>
    /// </summary>
    let objectCodification =
        Namespaced_IRI.parse _namespace_name "objectCodification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#objectStream"></see>
    /// </summary>
    let objectStream =
        Namespaced_IRI.parse _namespace_name "objectStream" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#predicateBitmap"></see>
    /// </summary>
    let predicateBitmap =
        Namespaced_IRI.parse _namespace_name "predicateBitmap" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#predicateCodification"></see>
    /// </summary>
    let predicateCodification =
        Namespaced_IRI.parse _namespace_name "predicateCodification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#predicateStream"></see>
    /// </summary>
    let predicateStream =
        Namespaced_IRI.parse _namespace_name "predicateStream" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#prefixLabel"></see>
    /// </summary>
    let prefixLabel =
        Namespaced_IRI.parse _namespace_name "prefixLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#prefixURI"></see>
    /// </summary>
    let prefixURI = Namespaced_IRI.parse _namespace_name "prefixURI" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#publicationInformation"></see>
    /// </summary>
    let publicationInformation =
        Namespaced_IRI.parse _namespace_name "publicationInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#publicationItemCollection"></see>
    /// </summary>
    let publicationItemCollection =
        Namespaced_IRI.parse _namespace_name "publicationItemCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#statisticalInformation"></see>
    /// </summary>
    let statisticalInformation =
        Namespaced_IRI.parse _namespace_name "statisticalInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#statisticalItemCollection"></see>
    /// </summary>
    let statisticalItemCollection =
        Namespaced_IRI.parse _namespace_name "statisticalItemCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder"></see>
    /// </summary>
    let streamsOrder =
        Namespaced_IRI.parse _namespace_name "streamsOrder" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrders"></see>
    /// </summary>
    let streamsOrders =
        Namespaced_IRI.parse _namespace_name "streamsOrders" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_OPS"></see>
    /// </summary>
    let streamsOrder_OPS =
        Namespaced_IRI.parse _namespace_name "streamsOrder_OPS" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_OSP"></see>
    /// </summary>
    let streamsOrder_OSP =
        Namespaced_IRI.parse _namespace_name "streamsOrder_OSP" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_POS"></see>
    /// </summary>
    let streamsOrder_POS =
        Namespaced_IRI.parse _namespace_name "streamsOrder_POS" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_PSO"></see>
    /// </summary>
    let streamsOrder_PSO =
        Namespaced_IRI.parse _namespace_name "streamsOrder_PSO" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_SOP"></see>
    /// </summary>
    let streamsOrder_SOP =
        Namespaced_IRI.parse _namespace_name "streamsOrder_SOP" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#streamsOrder_SPO"></see>
    /// </summary>
    let streamsOrder_SPO =
        Namespaced_IRI.parse _namespace_name "streamsOrder_SPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#subjectBitmap"></see>
    /// </summary>
    let subjectBitmap =
        Namespaced_IRI.parse _namespace_name "subjectBitmap" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#subjectCodification"></see>
    /// </summary>
    let subjectCodification =
        Namespaced_IRI.parse _namespace_name "subjectCodification" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#subjectObjectRatio"></see>
    /// </summary>
    let subjectObjectRatio =
        Namespaced_IRI.parse _namespace_name "subjectObjectRatio" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#subjectStream"></see>
    /// </summary>
    let subjectStream =
        Namespaced_IRI.parse _namespace_name "subjectStream" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triples"></see>
    /// </summary>
    let triples = Namespaced_IRI.parse _namespace_name "triples" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triplesBitmap"></see>
    /// </summary>
    let triplesBitmap =
        Namespaced_IRI.parse _namespace_name "triplesBitmap" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triplesCompact"></see>
    /// </summary>
    let triplesCompact =
        Namespaced_IRI.parse _namespace_name "triplesCompact" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/HDT/hdt#triplesPlain"></see>
    /// </summary>
    let triplesPlain =
        Namespaced_IRI.parse _namespace_name "triplesPlain" |> NamespacedName
