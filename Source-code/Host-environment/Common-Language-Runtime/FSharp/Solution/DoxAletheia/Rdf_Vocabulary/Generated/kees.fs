namespace http.linkeddata.center.kees.v1.hash

open DoxAletheia.Rdf_Vocabulary

module kees =
    let _namespace_name = "http://linkeddata.center/kees/v1#"

    /// <summary>
    /// Indexing of a web RDF resource using INSERT DATA sparql update construct. This activity is pretty flexible but requires an extra loading and parsing of resources. It recognize LDPRS accual policies.
    /// <see href="http://linkeddata.center/kees/v1#IngestionFromLDPRS"></see></summary>
    let IngestionFromLDPRS =
        Namespaced_IRI.parse _namespace_name "IngestionFromLDPRS" |> NamespacedName

    /// <summary>
    /// An activity to index a streamed RDF resouce provided by a LOD Laundromat service.
    /// <see href="http://linkeddata.center/kees/v1#IngestionFromLodLaundromat"></see></summary>
    let IngestionFromLodLaundromat =
        Namespaced_IRI.parse _namespace_name "IngestionFromLodLaundromat" |> NamespacedName

    /// <summary>
    /// An activity to index  RDF triples extracted from a sparql service.
    /// <see href="http://linkeddata.center/kees/v1#IngestionFromSparqlService"></see></summary>
    let IngestionFromSparqlService =
        Namespaced_IRI.parse _namespace_name "IngestionFromSparqlService" |> NamespacedName

    /// <summary>
    /// Indexing of a web resource useing the LOAD construct in sparql update. This Ingestion activity doe not supports content negotiation, http chahcing, LDP paging and depends from baking quadstore server inplementation. Should be used when possible because it is portable and fast. It recognize LDPRS accual policies.
    /// <see href="http://linkeddata.center/kees/v1#SimplifiedResourceIngestion"></see></summary>
    let SimplifiedResourceIngestion =
        Namespaced_IRI.parse _namespace_name "SimplifiedResourceIngestion" |> NamespacedName

    /// <summary>
    /// An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating knowledge base entities. It is a subclass of prov:Activity class.
    /// <see href="http://linkeddata.center/kees/v1#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    /// A software agent running kees compliant software. It is a subclass of prov:SoftwareAgent
    /// <see href="http://linkeddata.center/kees/v1#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// An kees entity is a something about the  Knowledge Base.   It is a subclass of prov:Entity Class
    /// <see href="http://linkeddata.center/kees/v1#Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName

    /// <summary>
    /// A plan that describe the objective  for a data ingestion activity.
    /// <see href="http://linkeddata.center/kees/v1#IngestionPlan"></see></summary>
    let IngestionPlan =
        Namespaced_IRI.parse _namespace_name "IngestionPlan" |> NamespacedName

    /// <summary>
    /// A  plan for a reasoning activity  that concens the creation or the destruction of   facts from a production rule.
    /// <see href="http://linkeddata.center/kees/v1#ReasoningPlan"></see></summary>
    let ReasoningPlan =
        Namespaced_IRI.parse _namespace_name "ReasoningPlan" |> NamespacedName

    /// <summary>
    /// A plan for a kees Cycle processing.
    /// <see href="http://linkeddata.center/kees/v1#Workflow"></see></summary>
    let Workflow = Namespaced_IRI.parse _namespace_name "Workflow" |> NamespacedName

    /// <summary>
    /// A  report  that states a processing error.
    /// <see href="http://linkeddata.center/kees/v1#FailureReport"></see></summary>
    let FailureReport =
        Namespaced_IRI.parse _namespace_name "FailureReport" |> NamespacedName

    /// <summary>
    /// A report that states that the knowledge base was not changed by the processing activity.
    /// <see href="http://linkeddata.center/kees/v1#NoChangeReport"></see></summary>
    let NoChangeReport =
        Namespaced_IRI.parse _namespace_name "NoChangeReport" |> NamespacedName

    /// <summary>
    /// A report that states a succesful processing result.
    /// <see href="http://linkeddata.center/kees/v1#SuccessReport"></see></summary>
    let SuccessReport =
        Namespaced_IRI.parse _namespace_name "SuccessReport" |> NamespacedName

    /// <summary>
    /// A query that returns a boolean value (true or false). Realized by a SPARQL ASK construct.
    /// <see href="http://linkeddata.center/kees/v1#Answer"></see></summary>
    let Answer = Namespaced_IRI.parse _namespace_name "Answer" |> NamespacedName
    /// <summary>
    /// A query that returns an RDF graph. Realized by a SPARQL CONSTRUCT.
    /// <see href="http://linkeddata.center/kees/v1#Graph"></see></summary>
    let Graph = Namespaced_IRI.parse _namespace_name "Graph" |> NamespacedName
    /// <summary>
    /// A query that returns a table of data. Realized by a SPARQL SELECT construct.
    /// <see href="http://linkeddata.center/kees/v1#Table"></see></summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName

    /// <summary>
    /// A processor that processes bulk accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#BulkIngestor"></see></summary>
    let BulkIngestor =
        Namespaced_IRI.parse _namespace_name "BulkIngestor" |> NamespacedName

    /// <summary>
    /// A processor that processes config accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#ConfigImporter"></see></summary>
    let ConfigImporter =
        Namespaced_IRI.parse _namespace_name "ConfigImporter" |> NamespacedName

    /// <summary>
    /// A processor that processes TBox accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#TBoxIngestor"></see></summary>
    let TBoxIngestor =
        Namespaced_IRI.parse _namespace_name "TBoxIngestor" |> NamespacedName

    /// <summary>
    /// A RDF graph database composed by ABox and TBox statements organized in named graph.
    /// <see href="http://linkeddata.center/kees/v1#KnowledgeBase"></see></summary>
    let KnowledgeBase =
        Namespaced_IRI.parse _namespace_name "KnowledgeBase" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.center/kees/v1#KnowledgeGraph"></see>
    /// </summary>
    let KnowledgeGraph =
        Namespaced_IRI.parse _namespace_name "KnowledgeGraph" |> NamespacedName

    /// <summary>
    /// A paged resource,  a subclass of http://www.w3.org/ns/ldp#Page.
    /// <see href="http://linkeddata.center/kees/v1#Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName
    /// <summary>
    /// Page sequence info
    /// <see href="http://linkeddata.center/kees/v1#PagingData"></see></summary>
    let PagingData = Namespaced_IRI.parse _namespace_name "PagingData" |> NamespacedName
    /// <summary>
    /// An entity that represents a set of actions or steps intended by one or more processor  to achieve some goals. It is equivalent to prov:Plan.
    /// <see href="http://linkeddata.center/kees/v1#Plan"></see></summary>
    let Plan = Namespaced_IRI.parse _namespace_name "Plan" |> NamespacedName
    /// <summary>
    /// A plan or course of action by an authority, intended to influence and determine  actions, and other matters. Can be considered a subclass of dct:Plan Class.
    /// <see href="http://linkeddata.center/kees/v1#Policy"></see></summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    /// The report about the result of a processing activity.
    /// <see href="http://linkeddata.center/kees/v1#ProcessingReport"></see></summary>
    let ProcessingReport =
        Namespaced_IRI.parse _namespace_name "ProcessingReport" |> NamespacedName

    /// <summary>
    /// A generic query expressed by a SPARQL construct.
    /// <see href="http://linkeddata.center/kees/v1#Query"></see></summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName

    /// <summary>
    /// An accrual policy that creates a knowledge graph in the knowlegde base  from a  web resource exposing  RDF data. Implies that the described resource kees:generatesGraphType  kees:LinkedDataGraph.
    /// Linked data platform  Rdf Resource accrual policy
    /// <see href="http://linkeddata.center/kees/v1#BulkAccrualPolicy"></see></summary>
    let BulkAccrualPolicy =
        Namespaced_IRI.parse _namespace_name "BulkAccrualPolicy" |> NamespacedName

    /// <summary>
    /// An accrual policy that creates a knowledge graph in the knowlegde base  from a resource exposing KEES ontology RDF data. Implies that the described resource kees:generatesGraphType  keesConfigDataGraph.
    /// <see href="http://linkeddata.center/kees/v1#ConfigAccrualPolicy"></see></summary>
    let ConfigAccrualPolicy =
        Namespaced_IRI.parse _namespace_name "ConfigAccrualPolicy" |> NamespacedName

    /// <summary>
    /// An accrual policy that creates a knowledge graph in the knowlegde base  from a resource exposing ontologies in RDF (owl, rdfs, skos). Implies that the described resource kees:generatesGraphType  kees:TBoxGraph.
    /// <see href="http://linkeddata.center/kees/v1#TBoxAccrualPolicy"></see></summary>
    let TBoxAccrualPolicy =
        Namespaced_IRI.parse _namespace_name "TBoxAccrualPolicy" |> NamespacedName

    /// <summary>
    /// The URL of a web resource exposing a Kees configuration data.
    /// <see href="http://linkeddata.center/kees/v1#includes"></see></summary>
    let includes = Namespaced_IRI.parse _namespace_name "includes" |> NamespacedName

    /// <summary>
    /// An url of a resource stored in the  lod laundromat wardrobe. similar to llo:url.
    /// <see href="http://linkeddata.center/kees/v1#lodLaundromatUrl"></see></summary>
    let lodLaundromatUrl =
        Namespaced_IRI.parse _namespace_name "lodLaundromatUrl" |> NamespacedName

    /// <summary>
    /// The URL of a web resource exposing RDF data facts.
    /// <see href="http://linkeddata.center/kees/v1#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    /// An url of a sparql service endpoint. similar to sd:endpoint
    /// <see href="http://linkeddata.center/kees/v1#sparqlEndpoint"></see></summary>
    let sparqlEndpoint =
        Namespaced_IRI.parse _namespace_name "sparqlEndpoint" |> NamespacedName

    /// <summary>
    /// It's datasource for a resource that contains TBox statements.
    /// <see href="http://linkeddata.center/kees/v1#vocabulary"></see></summary>
    let vocabulary = Namespaced_IRI.parse _namespace_name "vocabulary" |> NamespacedName

    /// <summary>
    /// An authentication method used to access a resource
    /// <see href="http://linkeddata.center/kees/v1#AuthenticationPolicy"></see></summary>
    let AuthenticationPolicy =
        Namespaced_IRI.parse _namespace_name "AuthenticationPolicy" |> NamespacedName

    /// <summary>
    /// The superclass for all the policies that describe how to learn facts from the web. The Accrual policy describes how to create and maintain ABox and TBox statements in a knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#KnowledgeAccrualPolicy"></see></summary>
    let KnowledgeAccrualPolicy =
        Namespaced_IRI.parse _namespace_name "KnowledgeAccrualPolicy" |> NamespacedName

    /// <summary>
    /// A construction rule according a legacy syntax derived from stardog DL entilement rules
    /// <see href="http://linkeddata.center/kees/v1#ReasoningPolicy"></see></summary>
    let ReasoningPolicy =
        Namespaced_IRI.parse _namespace_name "ReasoningPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://linkeddata.center/kees/v1#RetentionPolicy"></see>
    /// </summary>
    let RetentionPolicy =
        Namespaced_IRI.parse _namespace_name "RetentionPolicy" |> NamespacedName

    /// <summary>
    /// A forecasted  rate at which change recurs in an ABox Graph .
    /// <see href="http://linkeddata.center/kees/v1#UpdatePolicy"></see></summary>
    let UpdatePolicy =
        Namespaced_IRI.parse _namespace_name "UpdatePolicy" |> NamespacedName

    /// <summary>
    /// A special graph that can include boot directive that are copiet to config graph.
    /// <see href="http://linkeddata.center/kees/v1#BootGraph"></see></summary>
    let BootGraph = Namespaced_IRI.parse _namespace_name "BootGraph" |> NamespacedName

    /// <summary>
    /// A named graph containing inferred facts (by axioms or rules)
    /// <see href="http://linkeddata.center/kees/v1#InferredKnowledgeGraph"></see></summary>
    let InferredKnowledgeGraph =
        Namespaced_IRI.parse _namespace_name "InferredKnowledgeGraph" |> NamespacedName

    /// <summary>
    /// A named graph that stores statements about an ingestion activity.  By default all report about completed activities older than 24 hours are purged away.
    /// <see href="http://linkeddata.center/kees/v1#IngestionActivityReportGraph"></see></summary>
    let IngestionActivityReportGraph =
        Namespaced_IRI.parse _namespace_name "IngestionActivityReportGraph" |> NamespacedName

    /// <summary>
    /// A named graph that contains knowlege base configuration data. Data consist in instances of Accrual Policies.
    /// <see href="http://linkeddata.center/kees/v1#KBConfigGraph"></see></summary>
    let KBConfigGraph =
        Namespaced_IRI.parse _namespace_name "KBConfigGraph" |> NamespacedName

    /// <summary>
    /// An ABox named graph that stores facts from  linked data learned from web 3.0 resources.
    /// <see href="http://linkeddata.center/kees/v1#LinkedDataGraph"></see></summary>
    let LinkedDataGraph =
        Namespaced_IRI.parse _namespace_name "LinkedDataGraph" |> NamespacedName

    /// <summary>
    /// The abstract superclass for processors that manage  LDPRS accual policies.
    /// <see href="http://linkeddata.center/kees/v1#LDPRSAccrualPolicyProcessor"></see></summary>
    let LDPRSAccrualPolicyProcessor =
        Namespaced_IRI.parse _namespace_name "LDPRSAccrualPolicyProcessor" |> NamespacedName

    /// <summary>
    /// A client for lod laundromat web service. A processor that processes lod laundromat  accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#LodLaundromatAgent"></see></summary>
    let LodLaundromatAgent =
        Namespaced_IRI.parse _namespace_name "LodLaundromatAgent" |> NamespacedName

    /// <summary>
    /// a processor that manages sparql service accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#SparqlIngestor"></see></summary>
    let SparqlIngestor =
        Namespaced_IRI.parse _namespace_name "SparqlIngestor" |> NamespacedName

    /// <summary>
    /// An accrual policy to  create a  named  graph in the graph database from a Linked Data Platform Rdf Source , using eTag and lastUpdate http caching info. It recognizes LDP paging protocol.  Standard RDF resource loading  policy for  any  web resource exposing RDF data.
    /// <see href="http://linkeddata.center/kees/v1#LDPRSAccrualPolicy"></see></summary>
    let LDPRSAccrualPolicy =
        Namespaced_IRI.parse _namespace_name "LDPRSAccrualPolicy" |> NamespacedName

    /// <summary>
    /// An accrual policy that creates a knowledge graph in the knowlegde base  from a resource contained in lod laundromatic service.
    /// <see href="http://linkeddata.center/kees/v1#LodLaundromatAccrualPolicy"></see></summary>
    let LodLaundromatAccrualPolicy =
        Namespaced_IRI.parse _namespace_name "LodLaundromatAccrualPolicy" |> NamespacedName

    /// <summary>
    /// Load RDF resource executing a sparql query to a sparql endpoint (using POST).
    /// The query must be contained (unencoded) in accrualOption propery
    /// <see href="http://linkeddata.center/kees/v1#SparqlServiceAccrualPolicy"></see></summary>
    let SparqlServiceAccrualPolicy =
        Namespaced_IRI.parse _namespace_name "SparqlServiceAccrualPolicy" |> NamespacedName

    /// <summary>
    /// A named graph containing only facts.
    /// <see href="http://linkeddata.center/kees/v1#ABoxGraph"></see></summary>
    let ABoxGraph = Namespaced_IRI.parse _namespace_name "ABoxGraph" |> NamespacedName
    /// <summary>
    /// A named graph that contains vocabularies and taxonomies.
    /// <see href="http://linkeddata.center/kees/v1#TBoxGraph"></see></summary>
    let TBoxGraph = Namespaced_IRI.parse _namespace_name "TBoxGraph" |> NamespacedName

    /// <summary>
    /// The  described accrual policy has the objective to generate/maintain a knowledge graph of the related type. If the property is not specified, nor explicitely nor implicitely (by axioms), kees:LinkedDataGraph is inferred.
    /// <see href="http://linkeddata.center/kees/v1#generatesGraphType"></see></summary>
    let generatesGraphType =
        Namespaced_IRI.parse _namespace_name "generatesGraphType" |> NamespacedName

    /// <summary>
    /// A rule that create new facts in a Knowledge base
    /// <see href="http://linkeddata.center/kees/v1#ConstructRule"></see></summary>
    let ConstructRule =
        Namespaced_IRI.parse _namespace_name "ConstructRule" |> NamespacedName

    /// <summary>
    /// A rule that destroy (invalidated) facts in a knowledge base
    /// <see href="http://linkeddata.center/kees/v1#DestructRule"></see></summary>
    let DestructRule =
        Namespaced_IRI.parse _namespace_name "DestructRule" |> NamespacedName

    /// <summary>
    /// is the number of triples ingested by an accrual activity.
    /// triple count
    /// <see href="http://linkeddata.center/kees/v1#tripleCount"></see></summary>
    let tripleCount =
        Namespaced_IRI.parse _namespace_name "tripleCount" |> NamespacedName

    /// <summary>
    /// is the number of bytes processed by an ingestion activity.
    /// <see href="http://linkeddata.center/kees/v1#byteCount"></see></summary>
    let byteCount = Namespaced_IRI.parse _namespace_name "byteCount" |> NamespacedName

    /// <summary>
    /// http basic autentication method as described in RFC 2617
    /// <see href="http://linkeddata.center/kees/v1#HttpBasicAuthentication"></see></summary>
    let HttpBasicAuthentication =
        Namespaced_IRI.parse _namespace_name "HttpBasicAuthentication" |> NamespacedName

    /// <summary>
    /// Password in basic autentication method
    /// <see href="http://linkeddata.center/kees/v1#password"></see></summary>
    let password = Namespaced_IRI.parse _namespace_name "password" |> NamespacedName
    /// <summary>
    /// Username in basic http autentication method
    /// <see href="http://linkeddata.center/kees/v1#username"></see></summary>
    let username = Namespaced_IRI.parse _namespace_name "username" |> NamespacedName

    /// <summary>
    /// The kees cycle window processing activity ( ie.  Booting, Learning, reasoning)
    /// <see href="http://linkeddata.center/kees/v1#IngestionCycle"></see></summary>
    let IngestionCycle =
        Namespaced_IRI.parse _namespace_name "IngestionCycle" |> NamespacedName

    /// <summary>
    /// The abstract superclass for activities that builds knowledge graphs.
    /// <see href="http://linkeddata.center/kees/v1#KnowledgeAccrual"></see></summary>
    let KnowledgeAccrual =
        Namespaced_IRI.parse _namespace_name "KnowledgeAccrual" |> NamespacedName

    /// <summary>
    /// A super class for all activities that get data from a web resource.
    /// <see href="http://linkeddata.center/kees/v1#ResourceIngestion"></see></summary>
    let ResourceIngestion =
        Namespaced_IRI.parse _namespace_name "ResourceIngestion" |> NamespacedName

    /// <summary>
    /// the number of expected resource partitions (i.e pages).
    /// <see href="http://linkeddata.center/kees/v1#expectedParts"></see></summary>
    let expectedParts =
        Namespaced_IRI.parse _namespace_name "expectedParts" |> NamespacedName

    /// <summary>
    /// States that the described ingestion plan is about the creation/maintenance of a graph named as the referenced object.
    /// <see href="http://linkeddata.center/kees/v1#havingTargetGraphName"></see></summary>
    let havingTargetGraphName =
        Namespaced_IRI.parse _namespace_name "havingTargetGraphName" |> NamespacedName

    /// <summary>
    /// the expected maximum number of triple to be indexed by an activity.
    /// <see href="http://linkeddata.center/kees/v1#expectedTriples"></see></summary>
    let expectedTriples =
        Namespaced_IRI.parse _namespace_name "expectedTriples" |> NamespacedName

    /// <summary>
    /// The related resource is an authentication method to be used to access dataset during the execution of the described accrual policy. If not present, no authentication required.
    /// <see href="http://linkeddata.center/kees/v1#requiresAuthentication"></see></summary>
    let requiresAuthentication =
        Namespaced_IRI.parse _namespace_name "requiresAuthentication" |> NamespacedName

    /// <summary>
    /// An url
    /// <see href="http://linkeddata.center/kees/v1#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName

    /// <summary>
    /// The related resource declares the policy to adopt when an error occurs during the execution of the described accrual policy. If not present any error in data loading removes the related graph the in knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#onFetchingError"></see></summary>
    let onFetchingError =
        Namespaced_IRI.parse _namespace_name "onFetchingError" |> NamespacedName

    /// <summary>
    /// The related resource is a policy that suggest a time frame, expressed in seconds after witch the described accrual policy should check data for update.  If not specified , a period of one hour is guessed . A policy that specify a long interval greatly improves ingestion engines performances.
    /// <see href="http://linkeddata.center/kees/v1#hasUpdatePolicy"></see></summary>
    let hasUpdatePolicy =
        Namespaced_IRI.parse _namespace_name "hasUpdatePolicy" |> NamespacedName

    /// <summary>
    /// Define specified http accept header in requesting source. The sintax must be complain to RFC 2616 for HTTP 1.1. accept header. If not specified 'application/n-triples,application/ld+json,application/rdf+xml,text/turtle,*/*;q=0.4' it is used.
    /// <see href="http://linkeddata.center/kees/v1#forceAccept"></see></summary>
    let forceAccept =
        Namespaced_IRI.parse _namespace_name "forceAccept" |> NamespacedName

    /// <summary>
    /// The related uri is used as as the name of the graph produced according the described accrual policy. If not specified the same value of kees:url is inferred.
    /// <see href="http://linkeddata.center/kees/v1#createsGraphName"></see></summary>
    let createsGraphName =
        Namespaced_IRI.parse _namespace_name "createsGraphName" |> NamespacedName

    /// <summary>
    /// The related resource is one of the configuration graph that caracterize the described knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#hasConfigGraph"></see></summary>
    let hasConfigGraph =
        Namespaced_IRI.parse _namespace_name "hasConfigGraph" |> NamespacedName

    /// <summary>
    /// The related resource is the graph where reasoners places all materialized triples.
    /// <see href="http://linkeddata.center/kees/v1#hasInferenceGraph"></see></summary>
    let hasInferenceGraph =
        Namespaced_IRI.parse _namespace_name "hasInferenceGraph" |> NamespacedName

    /// <summary>
    /// This property states that annotated knowledge base as a referened boot graph.
    /// <see href="http://linkeddata.center/kees/v1#hasBootGraph"></see></summary>
    let hasBootGraph =
        Namespaced_IRI.parse _namespace_name "hasBootGraph" |> NamespacedName

    /// <summary>
    /// The described accrual  policy supports the Linked Data Platform Paging Protocol following link=next in http headers. If not specified false is inferred false.
    /// <see href="http://linkeddata.center/kees/v1#supportsLDPPP"></see></summary>
    let supportsLDPPP =
        Namespaced_IRI.parse _namespace_name "supportsLDPPP" |> NamespacedName

    /// <summary>
    /// Support http caching specification (RFC 2616 ) in sending HTTP requests. If not present, true is inferred.
    /// <see href="http://linkeddata.center/kees/v1#supportsHttpCaching"></see></summary>
    let supportsHttpCaching =
        Namespaced_IRI.parse _namespace_name "supportsHttpCaching" |> NamespacedName

    /// <summary>
    /// The related resource is a dataset that contains the page info about the annotated paged resource.
    /// <see href="http://linkeddata.center/kees/v1#hasPagingData"></see></summary>
    let hasPagingData =
        Namespaced_IRI.parse _namespace_name "hasPagingData" |> NamespacedName

    /// <summary>
    /// first record ofset of a page.
    /// <see href="http://linkeddata.center/kees/v1#hasOffset"></see></summary>
    let hasOffset = Namespaced_IRI.parse _namespace_name "hasOffset" |> NamespacedName
    /// <summary>
    /// states that referred Page has a previous page
    /// <see href="http://linkeddata.center/kees/v1#prevPage"></see></summary>
    let prevPage = Namespaced_IRI.parse _namespace_name "prevPage" |> NamespacedName
    /// <summary>
    /// States that referred Page has a next page.
    /// <see href="http://linkeddata.center/kees/v1#nextPage"></see></summary>
    let nextPage = Namespaced_IRI.parse _namespace_name "nextPage" |> NamespacedName
    /// <summary>
    /// states that the referenced page is the last one. If not present defautlt is false.
    /// <see href="http://linkeddata.center/kees/v1#isLastPage"></see></summary>
    let isLastPage = Namespaced_IRI.parse _namespace_name "isLastPage" |> NamespacedName
    /// <summary>
    /// A page sequence number .
    /// <see href="http://linkeddata.center/kees/v1#pageNum"></see></summary>
    let pageNum = Namespaced_IRI.parse _namespace_name "pageNum" |> NamespacedName
    /// <summary>
    /// a conventional name for a Policy. Should be univoque inside the knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#policyName"></see></summary>
    let policyName = Namespaced_IRI.parse _namespace_name "policyName" |> NamespacedName
    /// <summary>
    /// the text of a sparql query. In the query text you can inject variables with the form %varname=default value% where varname is a word a default value a string.
    /// <see href="http://linkeddata.center/kees/v1#queryText"></see></summary>
    let queryText = Namespaced_IRI.parse _namespace_name "queryText" |> NamespacedName
    /// <summary>
    /// A processor that create new facts using inference, rules and axioms.
    /// <see href="http://linkeddata.center/kees/v1#Reasoner"></see></summary>
    let Reasoner = Namespaced_IRI.parse _namespace_name "Reasoner" |> NamespacedName
    /// <summary>
    /// The activity of materializing RDF statements from rules and axioms.
    /// <see href="http://linkeddata.center/kees/v1#Reasoning"></see></summary>
    let Reasoning = Namespaced_IRI.parse _namespace_name "Reasoning" |> NamespacedName
    /// <summary>
    /// The rule text body in the form:
    /// prefixes declaration
    /// IF { sparql where clause }
    /// THEN { sparql insert(delete clause }.
    ///
    /// Example:
    /// PREFIX xsd: &lt;http://www.w3.org/2001/XMLSchema#&gt;
    /// PREFIX gr: &lt;http://purl.org/goodrelations/v1#&gt;
    /// PREFIX :&lt;urn:test:&gt;
    /// IF {
    ///            ?offering gr:hasPriceSpecification ?ps .
    ///            ?ps gr:hasCurrencyValue ?price .
    ///            FILTER (?price &gt;= 200.00).
    /// }
    /// THEN {
    ///            ?offering a :ExpensiveProduct .
    /// }
    ///
    ///
    /// <see href="http://linkeddata.center/kees/v1#ruleText"></see></summary>
    let ruleText = Namespaced_IRI.parse _namespace_name "ruleText" |> NamespacedName

    /// <summary>
    /// An optional integer that determine the ordere of execution of a rule ( ascending).
    /// <see href="http://linkeddata.center/kees/v1#executionPriority"></see></summary>
    let executionPriority =
        Namespaced_IRI.parse _namespace_name "executionPriority" |> NamespacedName

    /// <summary>
    /// a conventional name for a Reasoning Policy. Should be univoque inside the knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#ruleName"></see></summary>
    let ruleName = Namespaced_IRI.parse _namespace_name "ruleName" |> NamespacedName

    /// <summary>
    /// The number of times  ABOX graph is retained in storage after a failure in fetchin it. The default is 0 that means that when a graph fails to load it is removed from the knowledge base. If the value of this attribute is, for instance 3, this means that the Graph will be keept in the knowledge base untill its loading fails for three consecutive  times (the fourth error drives a graph drop). A succesfull loading reset the fail counter.N.B. a "not modified" message does not reset the fail counter.
    /// <see href="http://linkeddata.center/kees/v1#hasResilience"></see></summary>
    let hasResilience =
        Namespaced_IRI.parse _namespace_name "hasResilience" |> NamespacedName

    /// <summary>
    /// The last page returned by a SPARQL query. If not present defaults to 1.
    /// <see href="http://linkeddata.center/kees/v1#toPage"></see></summary>
    let toPage = Namespaced_IRI.parse _namespace_name "toPage" |> NamespacedName

    /// <summary>
    /// The SPARQL 1.1.  query to extract data from a SPARQL endpoint. No paging constructs allowed ( OFSET and LIMIT ), use pageSize, fromPage and toPage instead. If not specified "CONSTRUCT { ?s ?p ?o }  WHERE { ?s ?p ?o }" apply
    /// <see href="http://linkeddata.center/kees/v1#constructQuery"></see></summary>
    let constructQuery =
        Namespaced_IRI.parse _namespace_name "constructQuery" |> NamespacedName

    /// <summary>
    /// The http request method used in a SPARQL query. Accepted metods: "POST"  and "GET". Defaults to "POST" if not specified.
    /// <see href="http://linkeddata.center/kees/v1#queryMethod"></see></summary>
    let queryMethod =
        Namespaced_IRI.parse _namespace_name "queryMethod" |> NamespacedName

    /// <summary>
    /// The name of the graph that will contain a sparql query result. If not specfied hinerit the sparql service endpoint url.
    /// <see href="http://linkeddata.center/kees/v1#queryName"></see></summary>
    let queryName = Namespaced_IRI.parse _namespace_name "queryName" |> NamespacedName
    /// <summary>
    /// The first page returned by a SPARQL in a query iteration. Defaults to 1 if not present.
    /// <see href="http://linkeddata.center/kees/v1#fromPage"></see></summary>
    let fromPage = Namespaced_IRI.parse _namespace_name "fromPage" |> NamespacedName
    /// <summary>
    /// The size for a SPARQL query page. Equivalent  with LIMIT clause. Defaults to 1000 if not defined
    /// <see href="http://linkeddata.center/kees/v1#pageSize"></see></summary>
    let pageSize = Namespaced_IRI.parse _namespace_name "pageSize" |> NamespacedName

    /// <summary>
    /// is the number of SPARQL uopdate transaction performed to complete a knowledge accrual activity.
    /// transaction count
    /// <see href="http://linkeddata.center/kees/v1#transactionCount"></see></summary>
    let transactionCount =
        Namespaced_IRI.parse _namespace_name "transactionCount" |> NamespacedName

    /// <summary>
    /// Frequency period in seconds.
    /// <see href="http://linkeddata.center/kees/v1#hasFrequencyPeriod"></see></summary>
    let hasFrequencyPeriod =
        Namespaced_IRI.parse _namespace_name "hasFrequencyPeriod" |> NamespacedName

    /// <summary>
    /// A kees cycle description  in the form "booting =&gt; learning =&gt; reasoning " with some phases that can be omitted (i.e.  "learning =&gt; reasoning ")
    /// <see href="http://linkeddata.center/kees/v1#workflowStructure"></see></summary>
    let workflowStructure =
        Namespaced_IRI.parse _namespace_name "workflowStructure" |> NamespacedName

    /// <summary>
    /// The related resource is one of the ABox graphs that contain linked data facts in the described  knowlege base.
    /// <see href="http://linkeddata.center/kees/v1#hasABoxGraph"></see></summary>
    let hasABoxGraph =
        Namespaced_IRI.parse _namespace_name "hasABoxGraph" |> NamespacedName

    /// <summary>
    /// The related resource is a policy governing the addition of a named graph to the described knowledge base. Very similar to the dct:accrualPolicy property.
    /// <see href="http://linkeddata.center/kees/v1#hasAccrualPolicy"></see></summary>
    let hasAccrualPolicy =
        Namespaced_IRI.parse _namespace_name "hasAccrualPolicy" |> NamespacedName

    /// <summary>
    /// The related resource is a graph used to store logs  about a kees cycle executions.
    /// <see href="http://linkeddata.center/kees/v1#hasIngestionActivityReportGraph"></see></summary>
    let hasIngestionActivityReportGraph =
        Namespaced_IRI.parse _namespace_name "hasIngestionActivityReportGraph" |> NamespacedName

    /// <summary>
    /// the max size in RDF triple of a paged resource
    /// <see href="http://linkeddata.center/kees/v1#hasLimit"></see></summary>
    let hasLimit = Namespaced_IRI.parse _namespace_name "hasLimit" |> NamespacedName

    /// <summary>
    /// this property states that the annotated Knowledge Accrual has a reasoning policy.
    /// <see href="http://linkeddata.center/kees/v1#hasReasoningRule"></see></summary>
    let hasReasoningRule =
        Namespaced_IRI.parse _namespace_name "hasReasoningRule" |> NamespacedName

    /// <summary>
    /// The related resource is one of the ABox graphs that contain vocabularies and taxonomies used in the described  knowlege base.
    /// <see href="http://linkeddata.center/kees/v1#hasTBoxGraph"></see></summary>
    let hasTBoxGraph =
        Namespaced_IRI.parse _namespace_name "hasTBoxGraph" |> NamespacedName

    /// <summary>
    /// Extimated RAM bytes used by activity processing.
    /// <see href="http://linkeddata.center/kees/v1#usedMemory"></see></summary>
    let usedMemory = Namespaced_IRI.parse _namespace_name "usedMemory" |> NamespacedName
