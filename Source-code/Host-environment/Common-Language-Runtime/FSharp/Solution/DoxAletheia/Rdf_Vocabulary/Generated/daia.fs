namespace http.purl.org.ontology.daia.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module daia =
    let _namespace_iri = Namespace_Iri daia |> NamespaceIRI
    /// <summary>
    ///   <para>daia:Service/Loan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use outside of the holding institution (by lending or online access)</para>
    /// labels<para>loan service</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service/Loan">http://purl.org/ontology/daia/Service/Loan</seealso>
    let ``Service/Loan`` = Prefixed_Name(daia, "Service/Loan") |> PrefixedName

    /// <summary>
    ///   <para>daia:Service/Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use within the holding institution (in their rooms, in their intranet etc.)</para>
    /// labels<para>presentation service</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service/Presentation">http://purl.org/ontology/daia/Service/Presentation</seealso>
    let ``Service/Presentation`` =
        Prefixed_Name(daia, "Service/Presentation") |> PrefixedName

    /// <summary>
    ///   <para>daia:unavailableFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Item to a Service which the Item is not available for. This property is disjoint with the available property; however an Item can be available and unavailable for two different Services of the same class at the same time.</para>
    /// labels<para>not available for</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/unavailableFor">http://purl.org/ontology/daia/unavailableFor</seealso>
    let unavailableFor = Prefixed_Name(daia, "unavailableFor") |> PrefixedName
    /// <summary>
    ///   <para>daia:availableOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an available Service to the Item which this Service refers to</para>
    /// labels<para>available of</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/availableOf">http://purl.org/ontology/daia/availableOf</seealso>
    let availableOf = Prefixed_Name(daia, "availableOf") |> PrefixedName
    /// <summary>
    ///   <para>daia:broaderExemplar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Document to an Item that contains an exemplar of the Document as part.</para>
    ///   <para>Relates an Item to a Document which is partly exemplified by the Item.</para>
    /// labels<para>broader exemplar of</para><para>broader exemplar</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/broaderExemplar">http://purl.org/ontology/daia/broaderExemplar</seealso>
    let broaderExemplar = Prefixed_Name(daia, "broaderExemplar") |> PrefixedName
    /// <summary>
    ///   <para>daia:collectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Document to an Institution which helds an iten of the Document.</para>
    /// labels<para>collected by</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/collectedBy">http://purl.org/ontology/daia/collectedBy</seealso>
    let collectedBy = Prefixed_Name(daia, "collectedBy") |> PrefixedName
    /// <summary>
    ///   <para>daia:narrowerExemplarOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/daia/narrowerExemplarOf">http://purl.org/ontology/daia/narrowerExemplarOf</seealso>
    let narrowerExemplarOf = Prefixed_Name(daia, "narrowerExemplarOf") |> PrefixedName
    /// <summary>
    ///   <para>daia:expected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>If this property is given on an unavailable Service, it is assumed that the Service will be available at the specified time. Applications should normalize all literal values not conforming to xsd:date or xsd:dateTime to 'unknown'</para>
    /// labels<para>expected</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/expected">http://purl.org/ontology/daia/expected</seealso>
    let expected = Prefixed_Name(daia, "expected") |> PrefixedName
    /// <summary>
    ///   <para>daia:holds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Institution to an Item which the Institution holds.</para>
    /// labels<para>holds</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/holds">http://purl.org/ontology/daia/holds</seealso>
    let holds = Prefixed_Name(daia, "holds") |> PrefixedName
    /// <summary>
    ///   <para>daia:limitedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Service to a Limitation.</para>
    /// labels<para>limited by</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/limitedBy">http://purl.org/ontology/daia/limitedBy</seealso>
    let limitedBy = Prefixed_Name(daia, "limitedBy") |> PrefixedName
    /// <summary>
    ///   <para>daia:limits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Limitation to a Service.</para>
    /// labels<para>limits</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/limits">http://purl.org/ontology/daia/limits</seealso>
    let limits = Prefixed_Name(daia, "limits") |> PrefixedName
    /// <summary>
    ///   <para>daia:perform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A link to perform, register or reserve a Service.</para>
    /// labels<para>perform</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/perform">http://purl.org/ontology/daia/perform</seealso>
    let perform = Prefixed_Name(daia, "perform") |> PrefixedName
    /// <summary>
    ///   <para>daia:providedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Service to an Institution that provides the Service.</para>
    /// labels<para>provided by</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/providedBy">http://purl.org/ontology/daia/providedBy</seealso>
    let providedBy = Prefixed_Name(daia, "providedBy") |> PrefixedName
    /// <summary>
    ///   <para>daia:timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date and time of a the validity of a Response</para>
    /// labels<para>timestamp</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/timestamp">http://purl.org/ontology/daia/timestamp</seealso>
    let timestamp = Prefixed_Name(daia, "timestamp") |> PrefixedName
    /// <summary>
    ///   <para>daia:unavailableOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a unavailable Service to the Item which this Service refers to</para>
    /// labels<para>available of</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/unavailableOf">http://purl.org/ontology/daia/unavailableOf</seealso>
    let unavailableOf = Prefixed_Name(daia, "unavailableOf") |> PrefixedName
    /// <summary>
    ///   <para>daia:Limitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Limitation is something that limits the the availability of an Item.</para>
    /// labels<para>Limitation</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Limitation">http://purl.org/ontology/daia/Limitation</seealso>
    let Limitation = Prefixed_Name(daia, "Limitation") |> PrefixedName
    /// <summary>
    ///   <para>daia:exemplarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Item to the Document that is exemplified by the Item.</para>
    /// labels<para>is examplar of</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/exemplarOf">http://purl.org/ontology/daia/exemplarOf</seealso>
    let exemplarOf = Prefixed_Name(daia, "exemplarOf") |> PrefixedName
    /// <summary>
    ///   <para>daia:narrowerExemplar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Document to an Item that is an exemplar of a part of the Document.</para>
    ///   <para>Relates an Item to a Document which is partly exemplified by the Item.</para>
    /// labels<para>narrower exemplar of</para><para>narrower exemplar</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/narrowerExemplar">http://purl.org/ontology/daia/narrowerExemplar</seealso>
    let narrowerExemplar = Prefixed_Name(daia, "narrowerExemplar") |> PrefixedName
    /// <summary>
    ///   <para>daia:heldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Item to an Institution that holds the Item.</para>
    /// labels<para>held by</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/heldBy">http://purl.org/ontology/daia/heldBy</seealso>
    let heldBy = Prefixed_Name(daia, "heldBy") |> PrefixedName
    /// <summary>
    ///   <para>daia:Storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A place where instances of frbr:Item are stored.</para>
    /// labels<para>Storage</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Storage">http://purl.org/ontology/daia/Storage</seealso>
    let Storage = Prefixed_Name(daia, "Storage") |> PrefixedName
    /// <summary>
    ///   <para>daia:availableFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Item to a Service which the Item is available for. This property is disjoint with the unavailable property; however an Item can be available and unavailable for two different Services of the same class at the same time.</para>
    /// labels<para>available for</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/availableFor">http://purl.org/ontology/daia/availableFor</seealso>
    let availableFor = Prefixed_Name(daia, "availableFor") |> PrefixedName
    /// <summary>
    ///   <para>daia:exemplar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Document to an Item that is an exemplar of the Document. This property is similar to frbr:exemplar but does not refer to the class frbr:Manifestation.</para>
    /// labels<para>has exemplar</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/exemplar">http://purl.org/ontology/daia/exemplar</seealso>
    let exemplar = Prefixed_Name(daia, "exemplar") |> PrefixedName
    /// <summary>
    ///   <para>daia:delay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A time period of estimated delay untill an available Service can be used. Applications should normalize all literal values not conforming to xsd:duration to 'unknown'</para>
    /// labels<para>delay</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/delay">http://purl.org/ontology/daia/delay</seealso>
    let delay = Prefixed_Name(daia, "delay") |> PrefixedName
    /// <summary>
    ///   <para>daia:broaderExemplarOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/daia/broaderExemplarOf">http://purl.org/ontology/daia/broaderExemplarOf</seealso>
    let broaderExemplarOf = Prefixed_Name(daia, "broaderExemplarOf") |> PrefixedName
    /// <summary>
    ///   <para>daia:inCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Institution to a Document which the Institution helds an item of.</para>
    /// labels<para>in collection</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/inCollection">http://purl.org/ontology/daia/inCollection</seealso>
    let inCollection = Prefixed_Name(daia, "inCollection") |> PrefixedName
    /// <summary>
    ///   <para>daia:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A call number, shelf mark or similar label of an item</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/label">http://purl.org/ontology/daia/label</seealso>
    let label = Prefixed_Name(daia, "label") |> PrefixedName
    /// <summary>
    ///   <para>daia:provides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an Institution to a Service that is provided by the Institution.</para>
    /// labels<para>provides</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/provides">http://purl.org/ontology/daia/provides</seealso>
    let provides = Prefixed_Name(daia, "provides") |> PrefixedName
    /// <summary>
    ///   <para>daia:queue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number number of waiting requests for this service. If this property is not given, the value zero may be assumed but applications may also distinguish zero and no value.</para>
    /// labels<para>queue</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/queue">http://purl.org/ontology/daia/queue</seealso>
    let queue = Prefixed_Name(daia, "queue") |> PrefixedName
    /// <summary>
    ///   <para>daia:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/daia/">http://purl.org/ontology/daia/</seealso>
    let _prefix_iri = Prefixed_Name(daia, "") |> PrefixedName
    /// <summary>
    ///   <para>daia:Response</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Respone contains information about document availability for a specific time and institution.</para>
    /// labels<para>Response</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Response">http://purl.org/ontology/daia/Response</seealso>
    let Response = Prefixed_Name(daia, "Response") |> PrefixedName
    /// <summary>
    ///   <para>daia:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Service is something that is provided by an Institution, typically related to an Item, for instance the service of loaning the Item.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service">http://purl.org/ontology/daia/Service</seealso>
    let Service = Prefixed_Name(daia, "Service") |> PrefixedName
    /// <summary>
    ///   <para>daia:Service/Interloan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use mediated by another institution.</para>
    /// labels<para>interloan service</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service/Interloan">http://purl.org/ontology/daia/Service/Interloan</seealso>
    let ``Service/Interloan`` = Prefixed_Name(daia, "Service/Interloan") |> PrefixedName

    /// <summary>
    ///   <para>daia:Service/Openaccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>can be accessed freely on the Web</para>
    /// labels<para>open access service</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service/Openaccess">http://purl.org/ontology/daia/Service/Openaccess</seealso>
    let ``Service/Openaccess`` =
        Prefixed_Name(daia, "Service/Openaccess") |> PrefixedName
