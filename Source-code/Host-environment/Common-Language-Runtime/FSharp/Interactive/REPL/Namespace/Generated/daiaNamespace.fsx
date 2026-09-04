#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module daia =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/daia/" "daia"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>http://www.w3.org/2008/05/skos#scopeNote : A link to a page with more information can be added with foaf:page and with foaf:primaryTopicOfhttp://www.w3.org/2008/05/skos#scopeNote : A description of the limitation can be added with dct:description.</para>
    ///   <para>rdfs:comment : A Limitation is something that limits the the availability of an Item.</para>
    ///   <para>rdfs:label : Limitation</para>
    ///   <a href="http://purl.org/ontology/daia/Limitation">daia:Limitation</a>
    /// </summary>
    let Limitation = _prefixId.prefix "Limitation"
    /// <summary>
    ///   <para>http://www.w3.org/2008/05/skos#scopeNote : rdfs:seeAlso is used to link to documents and institutions.http://www.w3.org/2008/05/skos#scopeNote : Messages can be added with dct:description.</para>
    ///   <para>rdfs:comment : A Respone contains information about document availability for a specific time and institution.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Response</para>
    ///   <a href="http://purl.org/ontology/daia/Response">daia:Response</a>
    /// </summary>
    let Response = _prefixId.prefix "Response"
    /// <summary>
    ///   <para>http://www.w3.org/2008/05/skos#scopeNote : Messages can be added with dct:description.http://www.w3.org/2008/05/skos#scopeNote : Do not mix types of services (like 'loaning'), which are subclasses of Service, and specific instances of services (like loaning a particular book)!http://www.w3.org/2008/05/skos#scopeNote : The property dct:coverage may be used to refer to a scope of this service - but this is outside of the core purpose of DAIA</para>
    ///   <para>rdfs:comment : A Service is something that is provided by an Institution, typically related to an Item, for instance the service of loaning the Item.</para>
    ///   <para>rdfs:label : Service</para>
    ///   <a href="http://purl.org/ontology/daia/Service">daia:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>http://www.w3.org/2008/05/skos#scopeNote : The name or title of this location can be expressed with foaf:name and dct:titlehttp://www.w3.org/2008/05/skos#scopeNote : A link to a page with more information about the storage can be added with foaf:page and foaf:primaryTopicOf. However there should be another property to express a link to a specific item at a specific storage.http://www.w3.org/2008/05/skos#scopeNote : Physical items can be related to storages with geo:location. Most non-physical items have no locations but access services.</para>
    ///   <para>rdfs:label : Storage</para>
    ///   <para>http://www.w3.org/2008/05/skos#ScopeNote : Most instances of this class are also dct:Location and geo:SpatialThing^^xsd:string</para>
    ///   <para>rdfs:comment : A place where instances of frbr:Item are stored.</para>
    ///   <a href="http://purl.org/ontology/daia/Storage">daia:Storage</a>
    /// </summary>
    let Storage = _prefixId.prefix "Storage"
    /// <summary>
    ///   <para>rdfs:comment : Relates an Item to a Service which the Item is available for. This property is disjoint with the unavailable property; however an Item can be available and unavailable for two different Services of the same class at the same time.</para>
    ///   <para>rdfs:label : available for</para>
    ///   <a href="http://purl.org/ontology/daia/availableFor">daia:availableFor</a>
    /// </summary>
    let availableFor = _prefixId.prefix "availableFor"
    /// <summary>
    ///   <para>rdfs:comment : Relates an available Service to the Item which this Service refers to</para>
    ///   <para>rdfs:label : available of</para>
    ///   <a href="http://purl.org/ontology/daia/availableOf">daia:availableOf</a>
    /// </summary>
    let availableOf = _prefixId.prefix "availableOf"
    /// <summary>
    ///   <para>rdfs:comment : Relates a Document to an Item that contains an exemplar of the Document as part.rdfs:comment : Relates an Item to a Document which is partly exemplified by the Item.</para>
    ///   <para>http://www.w3.org/2008/05/skos#scopeNote : { ?i daia:broaderExemplarOf ?d } =&gt; { ?i dct:hasPart [ daia:exemplarOf ?d ] }^^xsd:stringhttp://www.w3.org/2008/05/skos#scopeNote : { ?d daia:broaderExemplar ?i } =&gt; { ?i dct:hasPart [ daia:exemplarOf ?d ] }^^xsd:string</para>
    ///   <para>rdfs:label : broader exemplar ofrdfs:label : broader exemplar</para>
    ///   <a href="http://purl.org/ontology/daia/broaderExemplar">daia:broaderExemplar</a>
    /// </summary>
    let broaderExemplar = _prefixId.prefix "broaderExemplar"
    let broaderExemplarOf = _prefixId.prefix "broaderExemplarOf"
    /// <summary>
    ///   <para>http://www.w3.org/2008/05/skos#scopeNote : This property implies the existence of a dcmitype:Collection and a cdtype:CatalogueOrIndex that need not to be modeled explicitly.</para>
    ///   <para>rdfs:comment : Relates a Document to an Institution which helds an iten of the Document.</para>
    ///   <para>rdfs:label : collected by</para>
    ///   <a href="http://purl.org/ontology/daia/collectedBy">daia:collectedBy</a>
    /// </summary>
    let collectedBy = _prefixId.prefix "collectedBy"
    /// <summary>
    ///   <para>rdfs:comment : A time period of estimated delay untill an available Service can be used. Applications should normalize all literal values not conforming to xsd:duration to 'unknown'</para>
    ///   <para>rdfs:label : delay</para>
    ///   <a href="http://purl.org/ontology/daia/delay">daia:delay</a>
    /// </summary>
    let delay = _prefixId.prefix "delay"
    /// <summary>
    ///   <para>rdfs:label : has exemplar</para>
    ///   <para>rdfs:comment : Relates a Document to an Item that is an exemplar of the Document. This property is similar to frbr:exemplar but does not refer to the class frbr:Manifestation.</para>
    ///   <a href="http://purl.org/ontology/daia/exemplar">daia:exemplar</a>
    /// </summary>
    let exemplar = _prefixId.prefix "exemplar"
    /// <summary>
    ///   <para>rdfs:label : is examplar of</para>
    ///   <para>rdfs:comment : Relates an Item to the Document that is exemplified by the Item.</para>
    ///   <a href="http://purl.org/ontology/daia/exemplarOf">daia:exemplarOf</a>
    /// </summary>
    let exemplarOf = _prefixId.prefix "exemplarOf"
    /// <summary>
    ///   <para>rdfs:comment : If this property is given on an unavailable Service, it is assumed that the Service will be available at the specified time. Applications should normalize all literal values not conforming to xsd:date or xsd:dateTime to 'unknown'</para>
    ///   <para>rdfs:label : expected</para>
    ///   <a href="http://purl.org/ontology/daia/expected">daia:expected</a>
    /// </summary>
    let expected = _prefixId.prefix "expected"
    /// <summary>
    ///   <para>rdfs:comment : Relates an Item to an Institution that holds the Item.</para>
    ///   <para>rdfs:label : held by</para>
    ///   <a href="http://purl.org/ontology/daia/heldBy">daia:heldBy</a>
    /// </summary>
    let heldBy = _prefixId.prefix "heldBy"
    /// <summary>
    ///   <para>rdfs:comment : Relates an Institution to an Item which the Institution holds.</para>
    ///   <para>rdfs:label : holds</para>
    ///   <a href="http://purl.org/ontology/daia/holds">daia:holds</a>
    /// </summary>
    let holds = _prefixId.prefix "holds"
    /// <summary>
    ///   <para>http://www.w3.org/2008/05/skos#scopeNote : This property implies the existence of a dcmitype:Collection and a cdtype:CatalogueOrIndex that need not to be modeled explicitly.</para>
    ///   <para>rdfs:comment : Relates an Institution to a Document which the Institution helds an item of.</para>
    ///   <para>rdfs:label : in collection</para>
    ///   <a href="http://purl.org/ontology/daia/inCollection">daia:inCollection</a>
    /// </summary>
    let inCollection = _prefixId.prefix "inCollection"
    /// <summary>
    ///   <para>rdfs:comment : A call number, shelf mark or similar label of an item</para>
    ///   <para>rdfs:label : label</para>
    ///   <a href="http://purl.org/ontology/daia/label">daia:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:comment : Relates an Service to a Limitation.</para>
    ///   <para>rdfs:label : limited by</para>
    ///   <a href="http://purl.org/ontology/daia/limitedBy">daia:limitedBy</a>
    /// </summary>
    let limitedBy = _prefixId.prefix "limitedBy"
    /// <summary>
    ///   <para>rdfs:comment : Relates a Limitation to a Service.</para>
    ///   <para>rdfs:label : limits</para>
    ///   <a href="http://purl.org/ontology/daia/limits">daia:limits</a>
    /// </summary>
    let limits = _prefixId.prefix "limits"
    /// <summary>
    ///   <para>rdfs:label : narrower exemplarrdfs:label : narrower exemplar of</para>
    ///   <para>rdfs:comment : Relates an Item to a Document which is partly exemplified by the Item.rdfs:comment : Relates a Document to an Item that is an exemplar of a part of the Document.</para>
    ///   <para>http://www.w3.org/2008/05/skos#scopeNote : { ?i daia:narrowerExemplarOf ?d } =&gt; { ?i daia:exemplarOf [ dct:isPartOf ?d ] }^^xsd:stringhttp://www.w3.org/2008/05/skos#scopeNote : { ?d daia:narrowerExemplar ?i } =&gt; { ?d dct:hasPart [ daia:exemplar ?i ] }^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/daia/narrowerExemplar">daia:narrowerExemplar</a>
    /// </summary>
    let narrowerExemplar = _prefixId.prefix "narrowerExemplar"
    let narrowerExemplarOf = _prefixId.prefix "narrowerExemplarOf"
    /// <summary>
    ///   <para>rdfs:comment : A link to perform, register or reserve a Service.</para>
    ///   <para>rdfs:label : perform</para>
    ///   <a href="http://purl.org/ontology/daia/perform">daia:perform</a>
    /// </summary>
    let perform = _prefixId.prefix "perform"
    /// <summary>
    ///   <para>rdfs:comment : Relates a Service to an Institution that provides the Service.</para>
    ///   <para>rdfs:label : provided by</para>
    ///   <a href="http://purl.org/ontology/daia/providedBy">daia:providedBy</a>
    /// </summary>
    let providedBy = _prefixId.prefix "providedBy"
    /// <summary>
    ///   <para>rdfs:comment : Relates an Institution to a Service that is provided by the Institution.</para>
    ///   <para>rdfs:label : provides</para>
    ///   <a href="http://purl.org/ontology/daia/provides">daia:provides</a>
    /// </summary>
    let provides = _prefixId.prefix "provides"
    /// <summary>
    ///   <para>rdfs:comment : The number number of waiting requests for this service. If this property is not given, the value zero may be assumed but applications may also distinguish zero and no value.</para>
    ///   <para>rdfs:label : queue</para>
    ///   <a href="http://purl.org/ontology/daia/queue">daia:queue</a>
    /// </summary>
    let queue = _prefixId.prefix "queue"
    /// <summary>
    ///   <para>rdfs:comment : Date and time of a the validity of a Response</para>
    ///   <para>rdfs:label : timestamp</para>
    ///   <a href="http://purl.org/ontology/daia/timestamp">daia:timestamp</a>
    /// </summary>
    let timestamp = _prefixId.prefix "timestamp"
    /// <summary>
    ///   <para>rdfs:comment : Relates an Item to a Service which the Item is not available for. This property is disjoint with the available property; however an Item can be available and unavailable for two different Services of the same class at the same time.</para>
    ///   <para>rdfs:label : not available for</para>
    ///   <a href="http://purl.org/ontology/daia/unavailableFor">daia:unavailableFor</a>
    /// </summary>
    let unavailableFor = _prefixId.prefix "unavailableFor"
    /// <summary>
    ///   <para>rdfs:comment : Relates a unavailable Service to the Item which this Service refers to</para>
    ///   <para>rdfs:label : available of</para>
    ///   <a href="http://purl.org/ontology/daia/unavailableOf">daia:unavailableOf</a>
    /// </summary>
    let unavailableOf = _prefixId.prefix "unavailableOf"
