namespace http.linkeddata.center.kees.v1.hash

open DoxAletheia

module kees =
    let _namespace_name = "http://linkeddata.center/kees/v1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Indexing of a web RDF resource using INSERT DATA sparql update construct. This activity is pretty flexible but requires an extra loading and parsing of resources. It recognize LDPRS accual policies.
    /// <see href="http://linkeddata.center/kees/v1#IngestionFromLDPRS"></see></summary>
    let IngestionFromLDPRS = _prefix "IngestionFromLDPRS"
    /// <summary>
    /// An activity to index a streamed RDF resouce provided by a LOD Laundromat service.
    /// <see href="http://linkeddata.center/kees/v1#IngestionFromLodLaundromat"></see></summary>
    let IngestionFromLodLaundromat = _prefix "IngestionFromLodLaundromat"
    /// <summary>
    /// An activity to index  RDF triples extracted from a sparql service.
    /// <see href="http://linkeddata.center/kees/v1#IngestionFromSparqlService"></see></summary>
    let IngestionFromSparqlService = _prefix "IngestionFromSparqlService"
    /// <summary>
    /// Indexing of a web resource useing the LOAD construct in sparql update. This Ingestion activity doe not supports content negotiation, http chahcing, LDP paging and depends from baking quadstore server inplementation. Should be used when possible because it is portable and fast. It recognize LDPRS accual policies.
    /// <see href="http://linkeddata.center/kees/v1#SimplifiedResourceIngestion"></see></summary>
    let SimplifiedResourceIngestion = _prefix "SimplifiedResourceIngestion"
    /// <summary>
    /// An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating knowledge base entities. It is a subclass of prov:Activity class.
    /// <see href="http://linkeddata.center/kees/v1#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// A software agent running kees compliant software. It is a subclass of prov:SoftwareAgent
    /// <see href="http://linkeddata.center/kees/v1#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// An kees entity is a something about the  Knowledge Base.   It is a subclass of prov:Entity Class
    /// <see href="http://linkeddata.center/kees/v1#Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// A plan that describe the objective  for a data ingestion activity.
    /// <see href="http://linkeddata.center/kees/v1#IngestionPlan"></see></summary>
    let IngestionPlan = _prefix "IngestionPlan"
    /// <summary>
    /// A  plan for a reasoning activity  that concens the creation or the destruction of   facts from a production rule.
    /// <see href="http://linkeddata.center/kees/v1#ReasoningPlan"></see></summary>
    let ReasoningPlan = _prefix "ReasoningPlan"
    /// <summary>
    /// A plan for a kees Cycle processing.
    /// <see href="http://linkeddata.center/kees/v1#Workflow"></see></summary>
    let Workflow = _prefix "Workflow"
    /// <summary>
    /// A  report  that states a processing error.
    /// <see href="http://linkeddata.center/kees/v1#FailureReport"></see></summary>
    let FailureReport = _prefix "FailureReport"
    /// <summary>
    /// A report that states that the knowledge base was not changed by the processing activity.
    /// <see href="http://linkeddata.center/kees/v1#NoChangeReport"></see></summary>
    let NoChangeReport = _prefix "NoChangeReport"
    /// <summary>
    /// A report that states a succesful processing result.
    /// <see href="http://linkeddata.center/kees/v1#SuccessReport"></see></summary>
    let SuccessReport = _prefix "SuccessReport"
    /// <summary>
    /// A query that returns a boolean value (true or false). Realized by a SPARQL ASK construct.
    /// <see href="http://linkeddata.center/kees/v1#Answer"></see></summary>
    let Answer = _prefix "Answer"
    /// <summary>
    /// A query that returns an RDF graph. Realized by a SPARQL CONSTRUCT.
    /// <see href="http://linkeddata.center/kees/v1#Graph"></see></summary>
    let Graph = _prefix "Graph"
    /// <summary>
    /// A query that returns a table of data. Realized by a SPARQL SELECT construct.
    /// <see href="http://linkeddata.center/kees/v1#Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// A processor that processes bulk accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#BulkIngestor"></see></summary>
    let BulkIngestor = _prefix "BulkIngestor"
    /// <summary>
    /// A processor that processes config accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#ConfigImporter"></see></summary>
    let ConfigImporter = _prefix "ConfigImporter"
    /// <summary>
    /// A processor that processes TBox accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#TBoxIngestor"></see></summary>
    let TBoxIngestor = _prefix "TBoxIngestor"
    /// <summary>
    /// A RDF graph database composed by ABox and TBox statements organized in named graph.
    /// <see href="http://linkeddata.center/kees/v1#KnowledgeBase"></see></summary>
    let KnowledgeBase = _prefix "KnowledgeBase"
    /// <summary>
    ///   <see href="http://linkeddata.center/kees/v1#KnowledgeGraph"></see>
    /// </summary>
    let KnowledgeGraph = _prefix "KnowledgeGraph"
    /// <summary>
    /// A paged resource,  a subclass of http://www.w3.org/ns/ldp#Page.
    /// <see href="http://linkeddata.center/kees/v1#Page"></see></summary>
    let Page = _prefix "Page"
    /// <summary>
    /// Page sequence info
    /// <see href="http://linkeddata.center/kees/v1#PagingData"></see></summary>
    let PagingData = _prefix "PagingData"
    /// <summary>
    /// An entity that represents a set of actions or steps intended by one or more processor  to achieve some goals. It is equivalent to prov:Plan.
    /// <see href="http://linkeddata.center/kees/v1#Plan"></see></summary>
    let Plan = _prefix "Plan"
    /// <summary>
    /// A plan or course of action by an authority, intended to influence and determine  actions, and other matters. Can be considered a subclass of dct:Plan Class.
    /// <see href="http://linkeddata.center/kees/v1#Policy"></see></summary>
    let Policy = _prefix "Policy"
    /// <summary>
    /// The report about the result of a processing activity.
    /// <see href="http://linkeddata.center/kees/v1#ProcessingReport"></see></summary>
    let ProcessingReport = _prefix "ProcessingReport"
    /// <summary>
    /// A generic query expressed by a SPARQL construct.
    /// <see href="http://linkeddata.center/kees/v1#Query"></see></summary>
    let Query = _prefix "Query"
    /// <summary>
    /// An accrual policy that creates a knowledge graph in the knowlegde base  from a  web resource exposing  RDF data. Implies that the described resource kees:generatesGraphType  kees:LinkedDataGraph.
    /// Linked data platform  Rdf Resource accrual policy
    /// <see href="http://linkeddata.center/kees/v1#BulkAccrualPolicy"></see></summary>
    let BulkAccrualPolicy = _prefix "BulkAccrualPolicy"
    /// <summary>
    /// An accrual policy that creates a knowledge graph in the knowlegde base  from a resource exposing KEES ontology RDF data. Implies that the described resource kees:generatesGraphType  keesConfigDataGraph.
    /// <see href="http://linkeddata.center/kees/v1#ConfigAccrualPolicy"></see></summary>
    let ConfigAccrualPolicy = _prefix "ConfigAccrualPolicy"
    /// <summary>
    /// An accrual policy that creates a knowledge graph in the knowlegde base  from a resource exposing ontologies in RDF (owl, rdfs, skos). Implies that the described resource kees:generatesGraphType  kees:TBoxGraph.
    /// <see href="http://linkeddata.center/kees/v1#TBoxAccrualPolicy"></see></summary>
    let TBoxAccrualPolicy = _prefix "TBoxAccrualPolicy"
    /// <summary>
    /// The URL of a web resource exposing a Kees configuration data.
    /// <see href="http://linkeddata.center/kees/v1#includes"></see></summary>
    let includes = _prefix "includes"
    /// <summary>
    /// An url of a resource stored in the  lod laundromat wardrobe. similar to llo:url.
    /// <see href="http://linkeddata.center/kees/v1#lodLaundromatUrl"></see></summary>
    let lodLaundromatUrl = _prefix "lodLaundromatUrl"
    /// <summary>
    /// The URL of a web resource exposing RDF data facts.
    /// <see href="http://linkeddata.center/kees/v1#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// An url of a sparql service endpoint. similar to sd:endpoint
    /// <see href="http://linkeddata.center/kees/v1#sparqlEndpoint"></see></summary>
    let sparqlEndpoint = _prefix "sparqlEndpoint"
    /// <summary>
    /// It's datasource for a resource that contains TBox statements.
    /// <see href="http://linkeddata.center/kees/v1#vocabulary"></see></summary>
    let vocabulary = _prefix "vocabulary"
    /// <summary>
    /// An authentication method used to access a resource
    /// <see href="http://linkeddata.center/kees/v1#AuthenticationPolicy"></see></summary>
    let AuthenticationPolicy = _prefix "AuthenticationPolicy"
    /// <summary>
    /// The superclass for all the policies that describe how to learn facts from the web. The Accrual policy describes how to create and maintain ABox and TBox statements in a knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#KnowledgeAccrualPolicy"></see></summary>
    let KnowledgeAccrualPolicy = _prefix "KnowledgeAccrualPolicy"
    /// <summary>
    /// A construction rule according a legacy syntax derived from stardog DL entilement rules
    /// <see href="http://linkeddata.center/kees/v1#ReasoningPolicy"></see></summary>
    let ReasoningPolicy = _prefix "ReasoningPolicy"
    /// <summary>
    ///   <see href="http://linkeddata.center/kees/v1#RetentionPolicy"></see>
    /// </summary>
    let RetentionPolicy = _prefix "RetentionPolicy"
    /// <summary>
    /// A forecasted  rate at which change recurs in an ABox Graph .
    /// <see href="http://linkeddata.center/kees/v1#UpdatePolicy"></see></summary>
    let UpdatePolicy = _prefix "UpdatePolicy"
    /// <summary>
    /// A special graph that can include boot directive that are copiet to config graph.
    /// <see href="http://linkeddata.center/kees/v1#BootGraph"></see></summary>
    let BootGraph = _prefix "BootGraph"
    /// <summary>
    /// A named graph containing inferred facts (by axioms or rules)
    /// <see href="http://linkeddata.center/kees/v1#InferredKnowledgeGraph"></see></summary>
    let InferredKnowledgeGraph = _prefix "InferredKnowledgeGraph"
    /// <summary>
    /// A named graph that stores statements about an ingestion activity.  By default all report about completed activities older than 24 hours are purged away.
    /// <see href="http://linkeddata.center/kees/v1#IngestionActivityReportGraph"></see></summary>
    let IngestionActivityReportGraph = _prefix "IngestionActivityReportGraph"
    /// <summary>
    /// A named graph that contains knowlege base configuration data. Data consist in instances of Accrual Policies.
    /// <see href="http://linkeddata.center/kees/v1#KBConfigGraph"></see></summary>
    let KBConfigGraph = _prefix "KBConfigGraph"
    /// <summary>
    /// An ABox named graph that stores facts from  linked data learned from web 3.0 resources.
    /// <see href="http://linkeddata.center/kees/v1#LinkedDataGraph"></see></summary>
    let LinkedDataGraph = _prefix "LinkedDataGraph"
    /// <summary>
    /// The abstract superclass for processors that manage  LDPRS accual policies.
    /// <see href="http://linkeddata.center/kees/v1#LDPRSAccrualPolicyProcessor"></see></summary>
    let LDPRSAccrualPolicyProcessor = _prefix "LDPRSAccrualPolicyProcessor"
    /// <summary>
    /// A client for lod laundromat web service. A processor that processes lod laundromat  accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#LodLaundromatAgent"></see></summary>
    let LodLaundromatAgent = _prefix "LodLaundromatAgent"
    /// <summary>
    /// a processor that manages sparql service accrual policies.
    /// <see href="http://linkeddata.center/kees/v1#SparqlIngestor"></see></summary>
    let SparqlIngestor = _prefix "SparqlIngestor"
    /// <summary>
    /// An accrual policy to  create a  named  graph in the graph database from a Linked Data Platform Rdf Source , using eTag and lastUpdate http caching info. It recognizes LDP paging protocol.  Standard RDF resource loading  policy for  any  web resource exposing RDF data.
    /// <see href="http://linkeddata.center/kees/v1#LDPRSAccrualPolicy"></see></summary>
    let LDPRSAccrualPolicy = _prefix "LDPRSAccrualPolicy"
    /// <summary>
    /// An accrual policy that creates a knowledge graph in the knowlegde base  from a resource contained in lod laundromatic service.
    /// <see href="http://linkeddata.center/kees/v1#LodLaundromatAccrualPolicy"></see></summary>
    let LodLaundromatAccrualPolicy = _prefix "LodLaundromatAccrualPolicy"
    /// <summary>
    /// Load RDF resource executing a sparql query to a sparql endpoint (using POST).
    /// The query must be contained (unencoded) in accrualOption propery
    /// <see href="http://linkeddata.center/kees/v1#SparqlServiceAccrualPolicy"></see></summary>
    let SparqlServiceAccrualPolicy = _prefix "SparqlServiceAccrualPolicy"
    /// <summary>
    /// A named graph containing only facts.
    /// <see href="http://linkeddata.center/kees/v1#ABoxGraph"></see></summary>
    let ABoxGraph = _prefix "ABoxGraph"
    /// <summary>
    /// A named graph that contains vocabularies and taxonomies.
    /// <see href="http://linkeddata.center/kees/v1#TBoxGraph"></see></summary>
    let TBoxGraph = _prefix "TBoxGraph"
    /// <summary>
    /// The  described accrual policy has the objective to generate/maintain a knowledge graph of the related type. If the property is not specified, nor explicitely nor implicitely (by axioms), kees:LinkedDataGraph is inferred.
    /// <see href="http://linkeddata.center/kees/v1#generatesGraphType"></see></summary>
    let generatesGraphType = _prefix "generatesGraphType"
    /// <summary>
    /// A rule that create new facts in a Knowledge base
    /// <see href="http://linkeddata.center/kees/v1#ConstructRule"></see></summary>
    let ConstructRule = _prefix "ConstructRule"
    /// <summary>
    /// A rule that destroy (invalidated) facts in a knowledge base
    /// <see href="http://linkeddata.center/kees/v1#DestructRule"></see></summary>
    let DestructRule = _prefix "DestructRule"
    /// <summary>
    /// is the number of triples ingested by an accrual activity.
    /// triple count
    /// <see href="http://linkeddata.center/kees/v1#tripleCount"></see></summary>
    let tripleCount = _prefix "tripleCount"
    /// <summary>
    /// is the number of bytes processed by an ingestion activity.
    /// <see href="http://linkeddata.center/kees/v1#byteCount"></see></summary>
    let byteCount = _prefix "byteCount"
    /// <summary>
    /// http basic autentication method as described in RFC 2617
    /// <see href="http://linkeddata.center/kees/v1#HttpBasicAuthentication"></see></summary>
    let HttpBasicAuthentication = _prefix "HttpBasicAuthentication"
    /// <summary>
    /// Password in basic autentication method
    /// <see href="http://linkeddata.center/kees/v1#password"></see></summary>
    let password = _prefix "password"
    /// <summary>
    /// Username in basic http autentication method
    /// <see href="http://linkeddata.center/kees/v1#username"></see></summary>
    let username = _prefix "username"
    /// <summary>
    /// The kees cycle window processing activity ( ie.  Booting, Learning, reasoning)
    /// <see href="http://linkeddata.center/kees/v1#IngestionCycle"></see></summary>
    let IngestionCycle = _prefix "IngestionCycle"
    /// <summary>
    /// The abstract superclass for activities that builds knowledge graphs.
    /// <see href="http://linkeddata.center/kees/v1#KnowledgeAccrual"></see></summary>
    let KnowledgeAccrual = _prefix "KnowledgeAccrual"
    /// <summary>
    /// A super class for all activities that get data from a web resource.
    /// <see href="http://linkeddata.center/kees/v1#ResourceIngestion"></see></summary>
    let ResourceIngestion = _prefix "ResourceIngestion"
    /// <summary>
    /// the number of expected resource partitions (i.e pages).
    /// <see href="http://linkeddata.center/kees/v1#expectedParts"></see></summary>
    let expectedParts = _prefix "expectedParts"
    /// <summary>
    /// States that the described ingestion plan is about the creation/maintenance of a graph named as the referenced object.
    /// <see href="http://linkeddata.center/kees/v1#havingTargetGraphName"></see></summary>
    let havingTargetGraphName = _prefix "havingTargetGraphName"
    /// <summary>
    /// the expected maximum number of triple to be indexed by an activity.
    /// <see href="http://linkeddata.center/kees/v1#expectedTriples"></see></summary>
    let expectedTriples = _prefix "expectedTriples"
    /// <summary>
    /// The related resource is an authentication method to be used to access dataset during the execution of the described accrual policy. If not present, no authentication required.
    /// <see href="http://linkeddata.center/kees/v1#requiresAuthentication"></see></summary>
    let requiresAuthentication = _prefix "requiresAuthentication"
    /// <summary>
    /// An url
    /// <see href="http://linkeddata.center/kees/v1#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// The related resource declares the policy to adopt when an error occurs during the execution of the described accrual policy. If not present any error in data loading removes the related graph the in knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#onFetchingError"></see></summary>
    let onFetchingError = _prefix "onFetchingError"
    /// <summary>
    /// The related resource is a policy that suggest a time frame, expressed in seconds after witch the described accrual policy should check data for update.  If not specified , a period of one hour is guessed . A policy that specify a long interval greatly improves ingestion engines performances.
    /// <see href="http://linkeddata.center/kees/v1#hasUpdatePolicy"></see></summary>
    let hasUpdatePolicy = _prefix "hasUpdatePolicy"
    /// <summary>
    /// Define specified http accept header in requesting source. The sintax must be complain to RFC 2616 for HTTP 1.1. accept header. If not specified 'application/n-triples,application/ld+json,application/rdf+xml,text/turtle,*/*;q=0.4' it is used.
    /// <see href="http://linkeddata.center/kees/v1#forceAccept"></see></summary>
    let forceAccept = _prefix "forceAccept"
    /// <summary>
    /// The related uri is used as as the name of the graph produced according the described accrual policy. If not specified the same value of kees:url is inferred.
    /// <see href="http://linkeddata.center/kees/v1#createsGraphName"></see></summary>
    let createsGraphName = _prefix "createsGraphName"
    /// <summary>
    /// The related resource is one of the configuration graph that caracterize the described knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#hasConfigGraph"></see></summary>
    let hasConfigGraph = _prefix "hasConfigGraph"
    /// <summary>
    /// The related resource is the graph where reasoners places all materialized triples.
    /// <see href="http://linkeddata.center/kees/v1#hasInferenceGraph"></see></summary>
    let hasInferenceGraph = _prefix "hasInferenceGraph"
    /// <summary>
    /// This property states that annotated knowledge base as a referened boot graph.
    /// <see href="http://linkeddata.center/kees/v1#hasBootGraph"></see></summary>
    let hasBootGraph = _prefix "hasBootGraph"
    /// <summary>
    /// The described accrual  policy supports the Linked Data Platform Paging Protocol following link=next in http headers. If not specified false is inferred false.
    /// <see href="http://linkeddata.center/kees/v1#supportsLDPPP"></see></summary>
    let supportsLDPPP = _prefix "supportsLDPPP"
    /// <summary>
    /// Support http caching specification (RFC 2616 ) in sending HTTP requests. If not present, true is inferred.
    /// <see href="http://linkeddata.center/kees/v1#supportsHttpCaching"></see></summary>
    let supportsHttpCaching = _prefix "supportsHttpCaching"
    /// <summary>
    /// The related resource is a dataset that contains the page info about the annotated paged resource.
    /// <see href="http://linkeddata.center/kees/v1#hasPagingData"></see></summary>
    let hasPagingData = _prefix "hasPagingData"
    /// <summary>
    /// first record ofset of a page.
    /// <see href="http://linkeddata.center/kees/v1#hasOffset"></see></summary>
    let hasOffset = _prefix "hasOffset"
    /// <summary>
    /// states that referred Page has a previous page
    /// <see href="http://linkeddata.center/kees/v1#prevPage"></see></summary>
    let prevPage = _prefix "prevPage"
    /// <summary>
    /// States that referred Page has a next page.
    /// <see href="http://linkeddata.center/kees/v1#nextPage"></see></summary>
    let nextPage = _prefix "nextPage"
    /// <summary>
    /// states that the referenced page is the last one. If not present defautlt is false.
    /// <see href="http://linkeddata.center/kees/v1#isLastPage"></see></summary>
    let isLastPage = _prefix "isLastPage"
    /// <summary>
    /// A page sequence number .
    /// <see href="http://linkeddata.center/kees/v1#pageNum"></see></summary>
    let pageNum = _prefix "pageNum"
    /// <summary>
    /// a conventional name for a Policy. Should be univoque inside the knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#policyName"></see></summary>
    let policyName = _prefix "policyName"
    /// <summary>
    /// the text of a sparql query. In the query text you can inject variables with the form %varname=default value% where varname is a word a default value a string.
    /// <see href="http://linkeddata.center/kees/v1#queryText"></see></summary>
    let queryText = _prefix "queryText"
    /// <summary>
    /// A processor that create new facts using inference, rules and axioms.
    /// <see href="http://linkeddata.center/kees/v1#Reasoner"></see></summary>
    let Reasoner = _prefix "Reasoner"
    /// <summary>
    /// The activity of materializing RDF statements from rules and axioms.
    /// <see href="http://linkeddata.center/kees/v1#Reasoning"></see></summary>
    let Reasoning = _prefix "Reasoning"
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
    let ruleText = _prefix "ruleText"
    /// <summary>
    /// An optional integer that determine the ordere of execution of a rule ( ascending).
    /// <see href="http://linkeddata.center/kees/v1#executionPriority"></see></summary>
    let executionPriority = _prefix "executionPriority"
    /// <summary>
    /// a conventional name for a Reasoning Policy. Should be univoque inside the knowledge base.
    /// <see href="http://linkeddata.center/kees/v1#ruleName"></see></summary>
    let ruleName = _prefix "ruleName"
    /// <summary>
    /// The number of times  ABOX graph is retained in storage after a failure in fetchin it. The default is 0 that means that when a graph fails to load it is removed from the knowledge base. If the value of this attribute is, for instance 3, this means that the Graph will be keept in the knowledge base untill its loading fails for three consecutive  times (the fourth error drives a graph drop). A succesfull loading reset the fail counter.N.B. a "not modified" message does not reset the fail counter.
    /// <see href="http://linkeddata.center/kees/v1#hasResilience"></see></summary>
    let hasResilience = _prefix "hasResilience"
    /// <summary>
    /// The last page returned by a SPARQL query. If not present defaults to 1.
    /// <see href="http://linkeddata.center/kees/v1#toPage"></see></summary>
    let toPage = _prefix "toPage"
    /// <summary>
    /// The SPARQL 1.1.  query to extract data from a SPARQL endpoint. No paging constructs allowed ( OFSET and LIMIT ), use pageSize, fromPage and toPage instead. If not specified "CONSTRUCT { ?s ?p ?o }  WHERE { ?s ?p ?o }" apply
    /// <see href="http://linkeddata.center/kees/v1#constructQuery"></see></summary>
    let constructQuery = _prefix "constructQuery"
    /// <summary>
    /// The http request method used in a SPARQL query. Accepted metods: "POST"  and "GET". Defaults to "POST" if not specified.
    /// <see href="http://linkeddata.center/kees/v1#queryMethod"></see></summary>
    let queryMethod = _prefix "queryMethod"
    /// <summary>
    /// The name of the graph that will contain a sparql query result. If not specfied hinerit the sparql service endpoint url.
    /// <see href="http://linkeddata.center/kees/v1#queryName"></see></summary>
    let queryName = _prefix "queryName"
    /// <summary>
    /// The first page returned by a SPARQL in a query iteration. Defaults to 1 if not present.
    /// <see href="http://linkeddata.center/kees/v1#fromPage"></see></summary>
    let fromPage = _prefix "fromPage"
    /// <summary>
    /// The size for a SPARQL query page. Equivalent  with LIMIT clause. Defaults to 1000 if not defined
    /// <see href="http://linkeddata.center/kees/v1#pageSize"></see></summary>
    let pageSize = _prefix "pageSize"
    /// <summary>
    /// is the number of SPARQL uopdate transaction performed to complete a knowledge accrual activity.
    /// transaction count
    /// <see href="http://linkeddata.center/kees/v1#transactionCount"></see></summary>
    let transactionCount = _prefix "transactionCount"
    /// <summary>
    /// Frequency period in seconds.
    /// <see href="http://linkeddata.center/kees/v1#hasFrequencyPeriod"></see></summary>
    let hasFrequencyPeriod = _prefix "hasFrequencyPeriod"
    /// <summary>
    /// A kees cycle description  in the form "booting =&gt; learning =&gt; reasoning " with some phases that can be omitted (i.e.  "learning =&gt; reasoning ")
    /// <see href="http://linkeddata.center/kees/v1#workflowStructure"></see></summary>
    let workflowStructure = _prefix "workflowStructure"
    /// <summary>
    /// The related resource is one of the ABox graphs that contain linked data facts in the described  knowlege base.
    /// <see href="http://linkeddata.center/kees/v1#hasABoxGraph"></see></summary>
    let hasABoxGraph = _prefix "hasABoxGraph"
    /// <summary>
    /// The related resource is a policy governing the addition of a named graph to the described knowledge base. Very similar to the dct:accrualPolicy property.
    /// <see href="http://linkeddata.center/kees/v1#hasAccrualPolicy"></see></summary>
    let hasAccrualPolicy = _prefix "hasAccrualPolicy"
    /// <summary>
    /// The related resource is a graph used to store logs  about a kees cycle executions.
    /// <see href="http://linkeddata.center/kees/v1#hasIngestionActivityReportGraph"></see></summary>
    let hasIngestionActivityReportGraph = _prefix "hasIngestionActivityReportGraph"
    /// <summary>
    /// the max size in RDF triple of a paged resource
    /// <see href="http://linkeddata.center/kees/v1#hasLimit"></see></summary>
    let hasLimit = _prefix "hasLimit"
    /// <summary>
    /// this property states that the annotated Knowledge Accrual has a reasoning policy.
    /// <see href="http://linkeddata.center/kees/v1#hasReasoningRule"></see></summary>
    let hasReasoningRule = _prefix "hasReasoningRule"
    /// <summary>
    /// The related resource is one of the ABox graphs that contain vocabularies and taxonomies used in the described  knowlege base.
    /// <see href="http://linkeddata.center/kees/v1#hasTBoxGraph"></see></summary>
    let hasTBoxGraph = _prefix "hasTBoxGraph"
    /// <summary>
    /// Extimated RAM bytes used by activity processing.
    /// <see href="http://linkeddata.center/kees/v1#usedMemory"></see></summary>
    let usedMemory = _prefix "usedMemory"
