namespace http.purl.org.HDT.hdt.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hdt =
    let _namespace_iri = Namespace_Iri hdt |> NamespaceIRI
    /// <summary>
    ///   <para>hdt:IDCodification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#IDCodification">http://purl.org/HDT/hdt#IDCodification</seealso>
    let IDCodification = Prefixed_Name(hdt, "IDCodification") |> PrefixedName

    /// <summary>
    ///   <para>hdt:additionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#additionalInformation">http://purl.org/HDT/hdt#additionalInformation</seealso>
    let additionalInformation =
        Prefixed_Name(hdt, "additionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>hdt:streamItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamItem">http://purl.org/HDT/hdt#streamItem</seealso>
    let streamItem = Prefixed_Name(hdt, "streamItem") |> PrefixedName
    /// <summary>
    ///   <para>hdt:bitmapItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#bitmapItem">http://purl.org/HDT/hdt#bitmapItem</seealso>
    let bitmapItem = Prefixed_Name(hdt, "bitmapItem") |> PrefixedName
    /// <summary>
    ///   <para>hdt:formatInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#formatInformation">http://purl.org/HDT/hdt#formatInformation</seealso>
    let formatInformation = Prefixed_Name(hdt, "formatInformation") |> PrefixedName

    /// <summary>
    ///   <para>hdt:dictionaryNamespaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#dictionaryNamespaces">http://purl.org/HDT/hdt#dictionaryNamespaces</seealso>
    let dictionaryNamespaces =
        Prefixed_Name(hdt, "dictionaryNamespaces") |> PrefixedName

    /// <summary>
    ///   <para>hdt:dictionaryOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#dictionaryOrder">http://purl.org/HDT/hdt#dictionaryOrder</seealso>
    let dictionaryOrder = Prefixed_Name(hdt, "dictionaryOrder") |> PrefixedName

    /// <summary>
    ///   <para>hdt:additionalItemCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#additionalItemCollection">http://purl.org/HDT/hdt#additionalItemCollection</seealso>
    let additionalItemCollection =
        Prefixed_Name(hdt, "additionalItemCollection") |> PrefixedName

    /// <summary>
    ///   <para>hdt:dictionaryItemCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#dictionaryItemCollection">http://purl.org/HDT/hdt#dictionaryItemCollection</seealso>
    let dictionaryItemCollection =
        Prefixed_Name(hdt, "dictionaryItemCollection") |> PrefixedName

    /// <summary>
    ///   <para>hdt:dictionary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#dictionary">http://purl.org/HDT/hdt#dictionary</seealso>
    let dictionary = Prefixed_Name(hdt, "dictionary") |> PrefixedName
    /// <summary>
    ///   <para>hdt:dictionaryEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#dictionaryEncoding">http://purl.org/HDT/hdt#dictionaryEncoding</seealso>
    let dictionaryEncoding = Prefixed_Name(hdt, "dictionaryEncoding") |> PrefixedName
    /// <summary>
    ///   <para>hdt:dictionarySeparator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#dictionarySeparator">http://purl.org/HDT/hdt#dictionarySeparator</seealso>
    let dictionarySeparator = Prefixed_Name(hdt, "dictionarySeparator") |> PrefixedName

    /// <summary>
    ///   <para>hdt:formatItemCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#formatItemCollection">http://purl.org/HDT/hdt#formatItemCollection</seealso>
    let formatItemCollection =
        Prefixed_Name(hdt, "formatItemCollection") |> PrefixedName

    /// <summary>
    ///   <para>hdt:namespaceItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#namespaceItem">http://purl.org/HDT/hdt#namespaceItem</seealso>
    let namespaceItem = Prefixed_Name(hdt, "namespaceItem") |> PrefixedName
    /// <summary>
    ///   <para>hdt:numberOfPredicates</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/HDT/hdt#numberOfPredicates">http://purl.org/HDT/hdt#numberOfPredicates</seealso>
    let numberOfPredicates = Prefixed_Name(hdt, "numberOfPredicates") |> PrefixedName
    /// <summary>
    ///   <para>hdt:objectCodification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#objectCodification">http://purl.org/HDT/hdt#objectCodification</seealso>
    let objectCodification = Prefixed_Name(hdt, "objectCodification") |> PrefixedName

    /// <summary>
    ///   <para>hdt:dictionaryNamespacesCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#dictionaryNamespacesCollection">http://purl.org/HDT/hdt#dictionaryNamespacesCollection</seealso>
    let dictionaryNamespacesCollection =
        Prefixed_Name(hdt, "dictionaryNamespacesCollection") |> PrefixedName

    /// <summary>
    ///   <para>hdt:fileLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#fileLocation">http://purl.org/HDT/hdt#fileLocation</seealso>
    let fileLocation = Prefixed_Name(hdt, "fileLocation") |> PrefixedName
    /// <summary>
    ///   <para>hdt:logBits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#logBits">http://purl.org/HDT/hdt#logBits</seealso>
    let logBits = Prefixed_Name(hdt, "logBits") |> PrefixedName
    /// <summary>
    ///   <para>hdt:namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#namespace">http://purl.org/HDT/hdt#namespace</seealso>
    let namespace_ = Prefixed_Name(hdt, "namespace") |> PrefixedName

    /// <summary>
    ///   <para>hdt:numberOfCommonSubjectObjects</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/HDT/hdt#numberOfCommonSubjectObjects">http://purl.org/HDT/hdt#numberOfCommonSubjectObjects</seealso>
    let numberOfCommonSubjectObjects =
        Prefixed_Name(hdt, "numberOfCommonSubjectObjects") |> PrefixedName

    /// <summary>
    ///   <para>hdt:objectBitmap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#objectBitmap">http://purl.org/HDT/hdt#objectBitmap</seealso>
    let objectBitmap = Prefixed_Name(hdt, "objectBitmap") |> PrefixedName

    /// <summary>
    ///   <para>hdt:triplesItemCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#triplesItemCollection">http://purl.org/HDT/hdt#triplesItemCollection</seealso>
    let triplesItemCollection =
        Prefixed_Name(hdt, "triplesItemCollection") |> PrefixedName

    /// <summary>
    ///   <para>hdt:predicateBitmap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#predicateBitmap">http://purl.org/HDT/hdt#predicateBitmap</seealso>
    let predicateBitmap = Prefixed_Name(hdt, "predicateBitmap") |> PrefixedName
    /// <summary>
    ///   <para>hdt:predicateStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#predicateStream">http://purl.org/HDT/hdt#predicateStream</seealso>
    let predicateStream = Prefixed_Name(hdt, "predicateStream") |> PrefixedName
    /// <summary>
    ///   <para>hdt:prefixURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#prefixURI">http://purl.org/HDT/hdt#prefixURI</seealso>
    let prefixURI = Prefixed_Name(hdt, "prefixURI") |> PrefixedName

    /// <summary>
    ///   <para>hdt:publicationItemCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#publicationItemCollection">http://purl.org/HDT/hdt#publicationItemCollection</seealso>
    let publicationItemCollection =
        Prefixed_Name(hdt, "publicationItemCollection") |> PrefixedName

    /// <summary>
    ///   <para>hdt:streamsOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamsOrder">http://purl.org/HDT/hdt#streamsOrder</seealso>
    let streamsOrder = Prefixed_Name(hdt, "streamsOrder") |> PrefixedName
    /// <summary>
    ///   <para>hdt:streamsOrder_OPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>hdt:streamsOrders</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamsOrder_OPS">http://purl.org/HDT/hdt#streamsOrder_OPS</seealso>
    let streamsOrder_OPS = Prefixed_Name(hdt, "streamsOrder_OPS") |> PrefixedName
    /// <summary>
    ///   <para>hdt:streamsOrder_POS</para>
    /// </summary>
    /// <remarks>
    ///   <para>hdt:streamsOrders</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamsOrder_POS">http://purl.org/HDT/hdt#streamsOrder_POS</seealso>
    let streamsOrder_POS = Prefixed_Name(hdt, "streamsOrder_POS") |> PrefixedName
    /// <summary>
    ///   <para>hdt:streamsOrder_SOP</para>
    /// </summary>
    /// <remarks>
    ///   <para>hdt:streamsOrders</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamsOrder_SOP">http://purl.org/HDT/hdt#streamsOrder_SOP</seealso>
    let streamsOrder_SOP = Prefixed_Name(hdt, "streamsOrder_SOP") |> PrefixedName
    /// <summary>
    ///   <para>hdt:objectStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#objectStream">http://purl.org/HDT/hdt#objectStream</seealso>
    let objectStream = Prefixed_Name(hdt, "objectStream") |> PrefixedName

    /// <summary>
    ///   <para>hdt:predicateCodification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#predicateCodification">http://purl.org/HDT/hdt#predicateCodification</seealso>
    let predicateCodification =
        Prefixed_Name(hdt, "predicateCodification") |> PrefixedName

    /// <summary>
    ///   <para>hdt:prefixLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#prefixLabel">http://purl.org/HDT/hdt#prefixLabel</seealso>
    let prefixLabel = Prefixed_Name(hdt, "prefixLabel") |> PrefixedName

    /// <summary>
    ///   <para>hdt:publicationInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#publicationInformation">http://purl.org/HDT/hdt#publicationInformation</seealso>
    let publicationInformation =
        Prefixed_Name(hdt, "publicationInformation") |> PrefixedName

    /// <summary>
    ///   <para>hdt:statisticalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#statisticalInformation">http://purl.org/HDT/hdt#statisticalInformation</seealso>
    let statisticalInformation =
        Prefixed_Name(hdt, "statisticalInformation") |> PrefixedName

    /// <summary>
    ///   <para>hdt:statisticalItemCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#statisticalItemCollection">http://purl.org/HDT/hdt#statisticalItemCollection</seealso>
    let statisticalItemCollection =
        Prefixed_Name(hdt, "statisticalItemCollection") |> PrefixedName

    /// <summary>
    ///   <para>hdt:streamsOrders</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamsOrders">http://purl.org/HDT/hdt#streamsOrders</seealso>
    let streamsOrders = Prefixed_Name(hdt, "streamsOrders") |> PrefixedName
    /// <summary>
    ///   <para>hdt:streamsOrder_OSP</para>
    /// </summary>
    /// <remarks>
    ///   <para>hdt:streamsOrders</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamsOrder_OSP">http://purl.org/HDT/hdt#streamsOrder_OSP</seealso>
    let streamsOrder_OSP = Prefixed_Name(hdt, "streamsOrder_OSP") |> PrefixedName
    /// <summary>
    ///   <para>hdt:streamsOrder_PSO</para>
    /// </summary>
    /// <remarks>
    ///   <para>hdt:streamsOrders</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamsOrder_PSO">http://purl.org/HDT/hdt#streamsOrder_PSO</seealso>
    let streamsOrder_PSO = Prefixed_Name(hdt, "streamsOrder_PSO") |> PrefixedName
    /// <summary>
    ///   <para>hdt:subjectBitmap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#subjectBitmap">http://purl.org/HDT/hdt#subjectBitmap</seealso>
    let subjectBitmap = Prefixed_Name(hdt, "subjectBitmap") |> PrefixedName
    /// <summary>
    ///   <para>hdt:subjectObjectRatio</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/HDT/hdt#subjectObjectRatio">http://purl.org/HDT/hdt#subjectObjectRatio</seealso>
    let subjectObjectRatio = Prefixed_Name(hdt, "subjectObjectRatio") |> PrefixedName
    /// <summary>
    ///   <para>hdt:triples</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#triples">http://purl.org/HDT/hdt#triples</seealso>
    let triples = Prefixed_Name(hdt, "triples") |> PrefixedName
    /// <summary>
    ///   <para>hdt:streamsOrder_SPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>hdt:streamsOrders</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#streamsOrder_SPO">http://purl.org/HDT/hdt#streamsOrder_SPO</seealso>
    let streamsOrder_SPO = Prefixed_Name(hdt, "streamsOrder_SPO") |> PrefixedName
    /// <summary>
    ///   <para>hdt:subjectCodification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#subjectCodification">http://purl.org/HDT/hdt#subjectCodification</seealso>
    let subjectCodification = Prefixed_Name(hdt, "subjectCodification") |> PrefixedName
    /// <summary>
    ///   <para>hdt:subjectStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#subjectStream">http://purl.org/HDT/hdt#subjectStream</seealso>
    let subjectStream = Prefixed_Name(hdt, "subjectStream") |> PrefixedName
    /// <summary>
    ///   <para>hdt:triplesBitmap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#triplesBitmap">http://purl.org/HDT/hdt#triplesBitmap</seealso>
    let triplesBitmap = Prefixed_Name(hdt, "triplesBitmap") |> PrefixedName
    /// <summary>
    ///   <para>hdt:triplesCompact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#triplesCompact">http://purl.org/HDT/hdt#triplesCompact</seealso>
    let triplesCompact = Prefixed_Name(hdt, "triplesCompact") |> PrefixedName
    /// <summary>
    ///   <para>hdt:triplesPlain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#triplesPlain">http://purl.org/HDT/hdt#triplesPlain</seealso>
    let triplesPlain = Prefixed_Name(hdt, "triplesPlain") |> PrefixedName
    /// <summary>
    ///   <para>hdt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>To comment on this schema, please contact rdfhdt@gmail.com.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#">http://purl.org/HDT/hdt#</seealso>
    let _prefix_iri = Prefixed_Name(hdt, "") |> PrefixedName
    /// <summary>
    ///   <para>hdt:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/HDT/hdt#Dataset">http://purl.org/HDT/hdt#Dataset</seealso>
    let Dataset = Prefixed_Name(hdt, "Dataset") |> PrefixedName
