#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module kees =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://linkeddata.center/kees/v1#" "kees"

    /// <summary>
    ///   <para>rdfs:label : ABox Graph</para>
    ///   <para>rdfs:comment : A named graph containing only facts.</para>
    ///   <a href="http://linkeddata.center/kees/v1#ABoxGraph">kees:ABoxGraph</a>
    /// </summary>
    let ABoxGraph = _prefixId.prefix "ABoxGraph"
    /// <summary>
    ///   <para>rdfs:label : Activity</para>
    ///   <para>rdfs:comment : An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating knowledge base entities. It is a subclass of prov:Activity class.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Activity">kees:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : A software agent running kees compliant software. It is a subclass of prov:SoftwareAgent</para>
    ///   <a href="http://linkeddata.center/kees/v1#Agent">kees:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Answer</para>
    ///   <para>rdfs:comment : A query that returns a boolean value (true or false). Realized by a SPARQL ASK construct.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Answer">kees:Answer</a>
    /// </summary>
    let Answer = _prefixId.prefix "Answer"
    /// <summary>
    ///   <para>rdfs:label : Authentication Method</para>
    ///   <para>rdfs:comment : An authentication method used to access a resource</para>
    ///   <a href="http://linkeddata.center/kees/v1#AuthenticationPolicy">kees:AuthenticationPolicy</a>
    /// </summary>
    let AuthenticationPolicy = _prefixId.prefix "AuthenticationPolicy"
    /// <summary>
    ///   <para>rdfs:label : Boot Graph</para>
    ///   <para>rdfs:comment : A special graph that can include boot directive that are copiet to config graph.</para>
    ///   <a href="http://linkeddata.center/kees/v1#BootGraph">kees:BootGraph</a>
    /// </summary>
    let BootGraph = _prefixId.prefix "BootGraph"
    /// <summary>
    ///   <para>rdfs:label : Bulk Accrual Policy</para>
    ///   <para>rdfs:comment : An accrual policy that creates a knowledge graph in the knowlegde base  from a  web resource exposing  RDF data. Implies that the described resource kees:generatesGraphType  kees:LinkedDataGraph.rdfs:comment : Linked data platform  Rdf Resource accrual policy</para>
    ///   <a href="http://linkeddata.center/kees/v1#BulkAccrualPolicy">kees:BulkAccrualPolicy</a>
    /// </summary>
    let BulkAccrualPolicy = _prefixId.prefix "BulkAccrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : Bulk Ingestor</para>
    ///   <para>rdfs:comment : A processor that processes bulk accrual policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#BulkIngestor">kees:BulkIngestor</a>
    /// </summary>
    let BulkIngestor = _prefixId.prefix "BulkIngestor"
    /// <summary>
    ///   <para>rdfs:label : Config Accrual Policy</para>
    ///   <para>rdfs:comment : An accrual policy that creates a knowledge graph in the knowlegde base  from a resource exposing KEES ontology RDF data. Implies that the described resource kees:generatesGraphType  keesConfigDataGraph.</para>
    ///   <a href="http://linkeddata.center/kees/v1#ConfigAccrualPolicy">kees:ConfigAccrualPolicy</a>
    /// </summary>
    let ConfigAccrualPolicy = _prefixId.prefix "ConfigAccrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : Config Importer</para>
    ///   <para>rdfs:comment : A processor that processes config accrual policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#ConfigImporter">kees:ConfigImporter</a>
    /// </summary>
    let ConfigImporter = _prefixId.prefix "ConfigImporter"
    /// <summary>
    ///   <para>rdfs:label : Construct Rule</para>
    ///   <para>rdfs:comment : A rule that create new facts in a Knowledge base</para>
    ///   <a href="http://linkeddata.center/kees/v1#ConstructRule">kees:ConstructRule</a>
    /// </summary>
    let ConstructRule = _prefixId.prefix "ConstructRule"
    /// <summary>
    ///   <para>rdfs:label : Destruct Rule</para>
    ///   <para>rdfs:comment : A rule that destroy (invalidated) facts in a knowledge base</para>
    ///   <a href="http://linkeddata.center/kees/v1#DestructRule">kees:DestructRule</a>
    /// </summary>
    let DestructRule = _prefixId.prefix "DestructRule"
    /// <summary>
    ///   <para>rdfs:label : Entity</para>
    ///   <para>rdfs:comment : An kees entity is a something about the  Knowledge Base.   It is a subclass of prov:Entity Class</para>
    ///   <a href="http://linkeddata.center/kees/v1#Entity">kees:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Failure Report</para>
    ///   <para>rdfs:comment : A  report  that states a processing error.</para>
    ///   <a href="http://linkeddata.center/kees/v1#FailureReport">kees:FailureReport</a>
    /// </summary>
    let FailureReport = _prefixId.prefix "FailureReport"
    /// <summary>
    ///   <para>rdfs:label : Graph</para>
    ///   <para>rdfs:comment : A query that returns an RDF graph. Realized by a SPARQL CONSTRUCT.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Graph">kees:Graph</a>
    /// </summary>
    let Graph = _prefixId.prefix "Graph"
    /// <summary>
    ///   <para>rdfs:label : Http Basic Autentication Method</para>
    ///   <para>rdfs:comment : http basic autentication method as described in RFC 2617</para>
    ///   <a href="http://linkeddata.center/kees/v1#HttpBasicAuthentication">kees:HttpBasicAuthentication</a>
    /// </summary>
    let HttpBasicAuthentication = _prefixId.prefix "HttpBasicAuthentication"
    /// <summary>
    ///   <para>rdfs:label : Inferred Knowledge Graph</para>
    ///   <para>rdfs:comment : A named graph containing inferred facts (by axioms or rules)</para>
    ///   <a href="http://linkeddata.center/kees/v1#InferredKnowledgeGraph">kees:InferredKnowledgeGraph</a>
    /// </summary>
    let InferredKnowledgeGraph = _prefixId.prefix "InferredKnowledgeGraph"
    /// <summary>
    ///   <para>rdfs:label : Ingestion Activity Report Graph</para>
    ///   <para>rdfs:comment : A named graph that stores statements about an ingestion activity.  By default all report about completed activities older than 24 hours are purged away.</para>
    ///   <a href="http://linkeddata.center/kees/v1#IngestionActivityReportGraph">kees:IngestionActivityReportGraph</a>
    /// </summary>
    let IngestionActivityReportGraph = _prefixId.prefix "IngestionActivityReportGraph"
    /// <summary>
    ///   <para>rdfs:label : Ingestion Cycle</para>
    ///   <para>rdfs:comment : The kees cycle window processing activity ( ie.  Booting, Learning, reasoning)</para>
    ///   <a href="http://linkeddata.center/kees/v1#IngestionCycle">kees:IngestionCycle</a>
    /// </summary>
    let IngestionCycle = _prefixId.prefix "IngestionCycle"
    /// <summary>
    ///   <para>rdfs:label : Ingestion From LDPRS</para>
    ///   <para>rdfs:comment : Indexing of a web RDF resource using INSERT DATA sparql update construct. This activity is pretty flexible but requires an extra loading and parsing of resources. It recognize LDPRS accual policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#IngestionFromLDPRS">kees:IngestionFromLDPRS</a>
    /// </summary>
    let IngestionFromLDPRS = _prefixId.prefix "IngestionFromLDPRS"
    /// <summary>
    ///   <para>rdfs:label : Ingestion From a Lod Laundromat</para>
    ///   <para>rdfs:comment : An activity to index a streamed RDF resouce provided by a LOD Laundromat service.</para>
    ///   <a href="http://linkeddata.center/kees/v1#IngestionFromLodLaundromat">kees:IngestionFromLodLaundromat</a>
    /// </summary>
    let IngestionFromLodLaundromat = _prefixId.prefix "IngestionFromLodLaundromat"
    /// <summary>
    ///   <para>rdfs:label : Ingestion From Sparql Service</para>
    ///   <para>rdfs:comment : An activity to index  RDF triples extracted from a sparql service.</para>
    ///   <a href="http://linkeddata.center/kees/v1#IngestionFromSparqlService">kees:IngestionFromSparqlService</a>
    /// </summary>
    let IngestionFromSparqlService = _prefixId.prefix "IngestionFromSparqlService"
    /// <summary>
    ///   <para>rdfs:label : Ingestion Plan</para>
    ///   <para>rdfs:comment : A plan that describe the objective  for a data ingestion activity.</para>
    ///   <a href="http://linkeddata.center/kees/v1#IngestionPlan">kees:IngestionPlan</a>
    /// </summary>
    let IngestionPlan = _prefixId.prefix "IngestionPlan"
    /// <summary>
    ///   <para>rdfs:label : Knowledge Base Config Graph</para>
    ///   <para>rdfs:comment : A named graph that contains knowlege base configuration data. Data consist in instances of Accrual Policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#KBConfigGraph">kees:KBConfigGraph</a>
    /// </summary>
    let KBConfigGraph = _prefixId.prefix "KBConfigGraph"
    /// <summary>
    ///   <para>rdfs:label : Knowledge Accrual</para>
    ///   <para>rdfs:comment : The abstract superclass for activities that builds knowledge graphs.</para>
    ///   <a href="http://linkeddata.center/kees/v1#KnowledgeAccrual">kees:KnowledgeAccrual</a>
    /// </summary>
    let KnowledgeAccrual = _prefixId.prefix "KnowledgeAccrual"
    /// <summary>
    ///   <para>rdfs:comment : The superclass for all the policies that describe how to learn facts from the web. The Accrual policy describes how to create and maintain ABox and TBox statements in a knowledge base.</para>
    ///   <para>rdfs:label : Knowledge Accrual Policy</para>
    ///   <a href="http://linkeddata.center/kees/v1#KnowledgeAccrualPolicy">kees:KnowledgeAccrualPolicy</a>
    /// </summary>
    let KnowledgeAccrualPolicy = _prefixId.prefix "KnowledgeAccrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : Knowledge Base</para>
    ///   <para>rdfs:comment : A RDF graph database composed by ABox and TBox statements organized in named graph.</para>
    ///   <a href="http://linkeddata.center/kees/v1#KnowledgeBase">kees:KnowledgeBase</a>
    /// </summary>
    let KnowledgeBase = _prefixId.prefix "KnowledgeBase"
    let KnowledgeGraph = _prefixId.prefix "KnowledgeGraph"
    /// <summary>
    ///   <para>rdfs:label : LDPRS Accrual Policy</para>
    ///   <para>rdfs:comment : An accrual policy to  create a  named  graph in the graph database from a Linked Data Platform Rdf Source , using eTag and lastUpdate http caching info. It recognizes LDP paging protocol.  Standard RDF resource loading  policy for  any  web resource exposing RDF data.</para>
    ///   <a href="http://linkeddata.center/kees/v1#LDPRSAccrualPolicy">kees:LDPRSAccrualPolicy</a>
    /// </summary>
    let LDPRSAccrualPolicy = _prefixId.prefix "LDPRSAccrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : LDPRS Accrual Policy Processor</para>
    ///   <para>rdfs:comment : The abstract superclass for processors that manage  LDPRS accual policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#LDPRSAccrualPolicyProcessor">kees:LDPRSAccrualPolicyProcessor</a>
    /// </summary>
    let LDPRSAccrualPolicyProcessor = _prefixId.prefix "LDPRSAccrualPolicyProcessor"
    /// <summary>
    ///   <para>rdfs:label : Linked Data Graph</para>
    ///   <para>rdfs:comment : An ABox named graph that stores facts from  linked data learned from web 3.0 resources.</para>
    ///   <a href="http://linkeddata.center/kees/v1#LinkedDataGraph">kees:LinkedDataGraph</a>
    /// </summary>
    let LinkedDataGraph = _prefixId.prefix "LinkedDataGraph"
    /// <summary>
    ///   <para>rdfs:label : Lod Laundromat Accrual Policy</para>
    ///   <para>rdfs:comment : An accrual policy that creates a knowledge graph in the knowlegde base  from a resource contained in lod laundromatic service.</para>
    ///   <a href="http://linkeddata.center/kees/v1#LodLaundromatAccrualPolicy">kees:LodLaundromatAccrualPolicy</a>
    /// </summary>
    let LodLaundromatAccrualPolicy = _prefixId.prefix "LodLaundromatAccrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : Lod Laundromat Agent</para>
    ///   <para>rdfs:comment : A client for lod laundromat web service. A processor that processes lod laundromat  accrual policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#LodLaundromatAgent">kees:LodLaundromatAgent</a>
    /// </summary>
    let LodLaundromatAgent = _prefixId.prefix "LodLaundromatAgent"
    /// <summary>
    ///   <para>rdfs:label : No Change Report</para>
    ///   <para>rdfs:comment : A report that states that the knowledge base was not changed by the processing activity.</para>
    ///   <a href="http://linkeddata.center/kees/v1#NoChangeReport">kees:NoChangeReport</a>
    /// </summary>
    let NoChangeReport = _prefixId.prefix "NoChangeReport"
    /// <summary>
    ///   <para>rdfs:label : Page</para>
    ///   <para>rdfs:comment : A paged resource,  a subclass of http://www.w3.org/ns/ldp#Page.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Page">kees:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>rdfs:label : Paging Data</para>
    ///   <para>rdfs:comment : Page sequence info</para>
    ///   <a href="http://linkeddata.center/kees/v1#PagingData">kees:PagingData</a>
    /// </summary>
    let PagingData = _prefixId.prefix "PagingData"
    /// <summary>
    ///   <para>rdfs:label : Plan</para>
    ///   <para>rdfs:comment : An entity that represents a set of actions or steps intended by one or more processor  to achieve some goals. It is equivalent to prov:Plan.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Plan">kees:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>rdfs:label : Policy</para>
    ///   <para>rdfs:comment : A plan or course of action by an authority, intended to influence and determine  actions, and other matters. Can be considered a subclass of dct:Plan Class.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Policy">kees:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>rdfs:label : Processing Report</para>
    ///   <para>rdfs:comment : The report about the result of a processing activity.</para>
    ///   <a href="http://linkeddata.center/kees/v1#ProcessingReport">kees:ProcessingReport</a>
    /// </summary>
    let ProcessingReport = _prefixId.prefix "ProcessingReport"
    /// <summary>
    ///   <para>rdfs:label : Query</para>
    ///   <para>rdfs:comment : A generic query expressed by a SPARQL construct.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Query">kees:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : reasoner</para>
    ///   <para>rdfs:comment : A processor that create new facts using inference, rules and axioms.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Reasoner">kees:Reasoner</a>
    /// </summary>
    let Reasoner = _prefixId.prefix "Reasoner"
    /// <summary>
    ///   <para>rdfs:label : Reasoning</para>
    ///   <para>rdfs:comment : The activity of materializing RDF statements from rules and axioms.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Reasoning">kees:Reasoning</a>
    /// </summary>
    let Reasoning = _prefixId.prefix "Reasoning"
    /// <summary>
    ///   <para>rdfs:label : Reasoning Plan</para>
    ///   <para>rdfs:comment : A  plan for a reasoning activity  that concens the creation or the destruction of   facts from a production rule.</para>
    ///   <a href="http://linkeddata.center/kees/v1#ReasoningPlan">kees:ReasoningPlan</a>
    /// </summary>
    let ReasoningPlan = _prefixId.prefix "ReasoningPlan"
    /// <summary>
    ///   <para>rdfs:label : Reasoning Policy</para>
    ///   <para>rdfs:comment : A construction rule according a legacy syntax derived from stardog DL entilement rules</para>
    ///   <a href="http://linkeddata.center/kees/v1#ReasoningPolicy">kees:ReasoningPolicy</a>
    /// </summary>
    let ReasoningPolicy = _prefixId.prefix "ReasoningPolicy"
    /// <summary>
    ///   <para>rdfs:label : Resource Ingestion</para>
    ///   <para>rdfs:comment : A super class for all activities that get data from a web resource.</para>
    ///   <a href="http://linkeddata.center/kees/v1#ResourceIngestion">kees:ResourceIngestion</a>
    /// </summary>
    let ResourceIngestion = _prefixId.prefix "ResourceIngestion"
    /// <summary>
    ///   <para>dce:description : How to manage errors during learning phase: is default  dropDataset </para>
    ///   <para>rdfs:label : Retention Policy</para>
    ///   <a href="http://linkeddata.center/kees/v1#RetentionPolicy">kees:RetentionPolicy</a>
    /// </summary>
    let RetentionPolicy = _prefixId.prefix "RetentionPolicy"
    /// <summary>
    ///   <para>rdfs:label : Simplified Resource Ingestion</para>
    ///   <para>rdfs:comment : Indexing of a web resource useing the LOAD construct in sparql update. This Ingestion activity doe not supports content negotiation, http chahcing, LDP paging and depends from baking quadstore server inplementation. Should be used when possible because it is portable and fast. It recognize LDPRS accual policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#SimplifiedResourceIngestion">kees:SimplifiedResourceIngestion</a>
    /// </summary>
    let SimplifiedResourceIngestion = _prefixId.prefix "SimplifiedResourceIngestion"
    /// <summary>
    ///   <para>rdfs:label : Sparql Ingestor</para>
    ///   <para>rdfs:comment : a processor that manages sparql service accrual policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#SparqlIngestor">kees:SparqlIngestor</a>
    /// </summary>
    let SparqlIngestor = _prefixId.prefix "SparqlIngestor"
    /// <summary>
    ///   <para>rdfs:label : SPARQL Ingestion Accrual Policy</para>
    ///   <para>rdfs:comment : Load RDF resource executing a sparql query to a sparql endpoint (using POST).
    /// The query must be contained (unencoded) in accrualOption propery</para>
    ///   <a href="http://linkeddata.center/kees/v1#SparqlServiceAccrualPolicy">kees:SparqlServiceAccrualPolicy</a>
    /// </summary>
    let SparqlServiceAccrualPolicy = _prefixId.prefix "SparqlServiceAccrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : Success Report</para>
    ///   <para>rdfs:comment : A report that states a succesful processing result.</para>
    ///   <a href="http://linkeddata.center/kees/v1#SuccessReport">kees:SuccessReport</a>
    /// </summary>
    let SuccessReport = _prefixId.prefix "SuccessReport"
    /// <summary>
    ///   <para>rdfs:label : TBox Accrual Policy</para>
    ///   <para>rdfs:comment : An accrual policy that creates a knowledge graph in the knowlegde base  from a resource exposing ontologies in RDF (owl, rdfs, skos). Implies that the described resource kees:generatesGraphType  kees:TBoxGraph.</para>
    ///   <a href="http://linkeddata.center/kees/v1#TBoxAccrualPolicy">kees:TBoxAccrualPolicy</a>
    /// </summary>
    let TBoxAccrualPolicy = _prefixId.prefix "TBoxAccrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : TBox Graph</para>
    ///   <para>rdfs:comment : A named graph that contains vocabularies and taxonomies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#TBoxGraph">kees:TBoxGraph</a>
    /// </summary>
    let TBoxGraph = _prefixId.prefix "TBoxGraph"
    /// <summary>
    ///   <para>rdfs:label : TBox Ingestor</para>
    ///   <para>rdfs:comment : A processor that processes TBox accrual policies.</para>
    ///   <a href="http://linkeddata.center/kees/v1#TBoxIngestor">kees:TBoxIngestor</a>
    /// </summary>
    let TBoxIngestor = _prefixId.prefix "TBoxIngestor"
    /// <summary>
    ///   <para>rdfs:label : Table</para>
    ///   <para>rdfs:comment : A query that returns a table of data. Realized by a SPARQL SELECT construct.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Table">kees:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : Update Policy</para>
    ///   <para>rdfs:comment : A forecasted  rate at which change recurs in an ABox Graph .</para>
    ///   <a href="http://linkeddata.center/kees/v1#UpdatePolicy">kees:UpdatePolicy</a>
    /// </summary>
    let UpdatePolicy = _prefixId.prefix "UpdatePolicy"
    /// <summary>
    ///   <para>rdfs:label : Workflow</para>
    ///   <para>rdfs:comment : A plan for a kees Cycle processing.</para>
    ///   <a href="http://linkeddata.center/kees/v1#Workflow">kees:Workflow</a>
    /// </summary>
    let Workflow = _prefixId.prefix "Workflow"
    /// <summary>
    ///   <para>rdfs:label : byte count</para>
    ///   <para>rdfs:comment : is the number of bytes processed by an ingestion activity.</para>
    ///   <a href="http://linkeddata.center/kees/v1#byteCount">kees:byteCount</a>
    /// </summary>
    let byteCount = _prefixId.prefix "byteCount"
    /// <summary>
    ///   <para>rdfs:label : construct query</para>
    ///   <para>rdfs:comment : The SPARQL 1.1.  query to extract data from a SPARQL endpoint. No paging constructs allowed ( OFSET and LIMIT ), use pageSize, fromPage and toPage instead. If not specified "CONSTRUCT { ?s ?p ?o }  WHERE { ?s ?p ?o }" apply</para>
    ///   <a href="http://linkeddata.center/kees/v1#constructQuery">kees:constructQuery</a>
    /// </summary>
    let constructQuery = _prefixId.prefix "constructQuery"
    /// <summary>
    ///   <para>rdfs:label : creates graph name^^xsd:string</para>
    ///   <para>rdfs:comment : The related uri is used as as the name of the graph produced according the described accrual policy. If not specified the same value of kees:url is inferred.</para>
    ///   <a href="http://linkeddata.center/kees/v1#createsGraphName">kees:createsGraphName</a>
    /// </summary>
    let createsGraphName = _prefixId.prefix "createsGraphName"
    /// <summary>
    ///   <para>rdfs:label : execution priority</para>
    ///   <para>rdfs:comment : An optional integer that determine the ordere of execution of a rule ( ascending).</para>
    ///   <a href="http://linkeddata.center/kees/v1#executionPriority">kees:executionPriority</a>
    /// </summary>
    let executionPriority = _prefixId.prefix "executionPriority"
    /// <summary>
    ///   <para>rdfs:label : expected parts</para>
    ///   <para>rdfs:comment : the number of expected resource partitions (i.e pages).</para>
    ///   <a href="http://linkeddata.center/kees/v1#expectedParts">kees:expectedParts</a>
    /// </summary>
    let expectedParts = _prefixId.prefix "expectedParts"
    /// <summary>
    ///   <para>rdfs:label : expected triples</para>
    ///   <para>rdfs:comment : the expected maximum number of triple to be indexed by an activity.</para>
    ///   <a href="http://linkeddata.center/kees/v1#expectedTriples">kees:expectedTriples</a>
    /// </summary>
    let expectedTriples = _prefixId.prefix "expectedTriples"
    /// <summary>
    ///   <para>rdfs:label : force accept</para>
    ///   <para>rdfs:comment : Define specified http accept header in requesting source. The sintax must be complain to RFC 2616 for HTTP 1.1. accept header. If not specified 'application/n-triples,application/ld+json,application/rdf+xml,text/turtle,*/*;q=0.4' it is used.</para>
    ///   <a href="http://linkeddata.center/kees/v1#forceAccept">kees:forceAccept</a>
    /// </summary>
    let forceAccept = _prefixId.prefix "forceAccept"
    /// <summary>
    ///   <para>rdfs:label : from page</para>
    ///   <para>rdfs:comment : The first page returned by a SPARQL in a query iteration. Defaults to 1 if not present.</para>
    ///   <a href="http://linkeddata.center/kees/v1#fromPage">kees:fromPage</a>
    /// </summary>
    let fromPage = _prefixId.prefix "fromPage"
    /// <summary>
    ///   <para>rdfs:label : generates  graph type</para>
    ///   <para>rdfs:comment : The  described accrual policy has the objective to generate/maintain a knowledge graph of the related type. If the property is not specified, nor explicitely nor implicitely (by axioms), kees:LinkedDataGraph is inferred.</para>
    ///   <a href="http://linkeddata.center/kees/v1#generatesGraphType">kees:generatesGraphType</a>
    /// </summary>
    let generatesGraphType = _prefixId.prefix "generatesGraphType"
    /// <summary>
    ///   <para>rdfs:label : has ABox graph</para>
    ///   <para>rdfs:comment : The related resource is one of the ABox graphs that contain linked data facts in the described  knowlege base.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasABoxGraph">kees:hasABoxGraph</a>
    /// </summary>
    let hasABoxGraph = _prefixId.prefix "hasABoxGraph"
    /// <summary>
    ///   <para>rdfs:label : has accrual policy</para>
    ///   <para>rdfs:comment : The related resource is a policy governing the addition of a named graph to the described knowledge base. Very similar to the dct:accrualPolicy property.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasAccrualPolicy">kees:hasAccrualPolicy</a>
    /// </summary>
    let hasAccrualPolicy = _prefixId.prefix "hasAccrualPolicy"
    /// <summary>
    ///   <para>rdfs:label : has boot graph</para>
    ///   <para>rdfs:comment : This property states that annotated knowledge base as a referened boot graph.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasBootGraph">kees:hasBootGraph</a>
    /// </summary>
    let hasBootGraph = _prefixId.prefix "hasBootGraph"
    /// <summary>
    ///   <para>rdfs:label : has config graph</para>
    ///   <para>rdfs:comment : The related resource is one of the configuration graph that caracterize the described knowledge base.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasConfigGraph">kees:hasConfigGraph</a>
    /// </summary>
    let hasConfigGraph = _prefixId.prefix "hasConfigGraph"
    /// <summary>
    ///   <para>rdfs:label : has frequency period</para>
    ///   <para>rdfs:comment : Frequency period in seconds.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasFrequencyPeriod">kees:hasFrequencyPeriod</a>
    /// </summary>
    let hasFrequencyPeriod = _prefixId.prefix "hasFrequencyPeriod"
    /// <summary>
    ///   <para>rdfs:label : has inference graph</para>
    ///   <para>rdfs:comment : The related resource is the graph where reasoners places all materialized triples.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasInferenceGraph">kees:hasInferenceGraph</a>
    /// </summary>
    let hasInferenceGraph = _prefixId.prefix "hasInferenceGraph"

    /// <summary>
    ///   <para>rdfs:label : has ingestion activity report graph</para>
    ///   <para>rdfs:comment : The related resource is a graph used to store logs  about a kees cycle executions.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasIngestionActivityReportGraph">kees:hasIngestionActivityReportGraph</a>
    /// </summary>
    let hasIngestionActivityReportGraph =
        _prefixId.prefix "hasIngestionActivityReportGraph"

    /// <summary>
    ///   <para>rdfs:label : has limit</para>
    ///   <para>rdfs:comment : the max size in RDF triple of a paged resource</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasLimit">kees:hasLimit</a>
    /// </summary>
    let hasLimit = _prefixId.prefix "hasLimit"
    /// <summary>
    ///   <para>rdfs:label : has offset</para>
    ///   <para>rdfs:comment : first record ofset of a page.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasOffset">kees:hasOffset</a>
    /// </summary>
    let hasOffset = _prefixId.prefix "hasOffset"
    /// <summary>
    ///   <para>rdfs:label : has Paging Data</para>
    ///   <para>rdfs:comment : The related resource is a dataset that contains the page info about the annotated paged resource.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasPagingData">kees:hasPagingData</a>
    /// </summary>
    let hasPagingData = _prefixId.prefix "hasPagingData"
    /// <summary>
    ///   <para>rdfs:label : hasReasoningPolicy</para>
    ///   <para>rdfs:comment : this property states that the annotated Knowledge Accrual has a reasoning policy.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasReasoningRule">kees:hasReasoningRule</a>
    /// </summary>
    let hasReasoningRule = _prefixId.prefix "hasReasoningRule"
    /// <summary>
    ///   <para>rdfs:label : has resilience</para>
    ///   <para>rdfs:comment : The number of times  ABOX graph is retained in storage after a failure in fetchin it. The default is 0 that means that when a graph fails to load it is removed from the knowledge base. If the value of this attribute is, for instance 3, this means that the Graph will be keept in the knowledge base untill its loading fails for three consecutive  times (the fourth error drives a graph drop). A succesfull loading reset the fail counter.N.B. a "not modified" message does not reset the fail counter.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasResilience">kees:hasResilience</a>
    /// </summary>
    let hasResilience = _prefixId.prefix "hasResilience"
    /// <summary>
    ///   <para>rdfs:label : has TBox graph</para>
    ///   <para>rdfs:comment : The related resource is one of the ABox graphs that contain vocabularies and taxonomies used in the described  knowlege base.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasTBoxGraph">kees:hasTBoxGraph</a>
    /// </summary>
    let hasTBoxGraph = _prefixId.prefix "hasTBoxGraph"
    /// <summary>
    ///   <para>rdfs:label : has update policy</para>
    ///   <para>rdfs:comment : The related resource is a policy that suggest a time frame, expressed in seconds after witch the described accrual policy should check data for update.  If not specified , a period of one hour is guessed . A policy that specify a long interval greatly improves ingestion engines performances.</para>
    ///   <a href="http://linkeddata.center/kees/v1#hasUpdatePolicy">kees:hasUpdatePolicy</a>
    /// </summary>
    let hasUpdatePolicy = _prefixId.prefix "hasUpdatePolicy"
    /// <summary>
    ///   <para>rdfs:label : having target graph name</para>
    ///   <para>rdfs:comment : States that the described ingestion plan is about the creation/maintenance of a graph named as the referenced object.</para>
    ///   <a href="http://linkeddata.center/kees/v1#havingTargetGraphName">kees:havingTargetGraphName</a>
    /// </summary>
    let havingTargetGraphName = _prefixId.prefix "havingTargetGraphName"
    /// <summary>
    ///   <para>rdfs:label : include</para>
    ///   <para>rdfs:comment : The URL of a web resource exposing a Kees configuration data.</para>
    ///   <a href="http://linkeddata.center/kees/v1#includes">kees:includes</a>
    /// </summary>
    let includes = _prefixId.prefix "includes"
    /// <summary>
    ///   <para>rdfs:label : is the last page</para>
    ///   <para>rdfs:comment : states that the referenced page is the last one. If not present defautlt is false.</para>
    ///   <a href="http://linkeddata.center/kees/v1#isLastPage">kees:isLastPage</a>
    /// </summary>
    let isLastPage = _prefixId.prefix "isLastPage"
    /// <summary>
    ///   <para>rdfs:label : lod laundromat url</para>
    ///   <para>rdfs:comment : An url of a resource stored in the  lod laundromat wardrobe. similar to llo:url.</para>
    ///   <a href="http://linkeddata.center/kees/v1#lodLaundromatUrl">kees:lodLaundromatUrl</a>
    /// </summary>
    let lodLaundromatUrl = _prefixId.prefix "lodLaundromatUrl"
    /// <summary>
    ///   <para>rdfs:label : next page</para>
    ///   <para>rdfs:comment : States that referred Page has a next page.</para>
    ///   <a href="http://linkeddata.center/kees/v1#nextPage">kees:nextPage</a>
    /// </summary>
    let nextPage = _prefixId.prefix "nextPage"
    /// <summary>
    ///   <para>rdfs:label : on fetching error</para>
    ///   <para>rdfs:comment : The related resource declares the policy to adopt when an error occurs during the execution of the described accrual policy. If not present any error in data loading removes the related graph the in knowledge base.</para>
    ///   <a href="http://linkeddata.center/kees/v1#onFetchingError">kees:onFetchingError</a>
    /// </summary>
    let onFetchingError = _prefixId.prefix "onFetchingError"
    /// <summary>
    ///   <para>rdfs:label : page number</para>
    ///   <para>rdfs:comment : A page sequence number .</para>
    ///   <a href="http://linkeddata.center/kees/v1#pageNum">kees:pageNum</a>
    /// </summary>
    let pageNum = _prefixId.prefix "pageNum"
    /// <summary>
    ///   <para>rdfs:label : page size</para>
    ///   <para>rdfs:comment : The size for a SPARQL query page. Equivalent  with LIMIT clause. Defaults to 1000 if not defined</para>
    ///   <a href="http://linkeddata.center/kees/v1#pageSize">kees:pageSize</a>
    /// </summary>
    let pageSize = _prefixId.prefix "pageSize"
    /// <summary>
    ///   <para>rdfs:label : password</para>
    ///   <para>rdfs:comment : Password in basic autentication method</para>
    ///   <a href="http://linkeddata.center/kees/v1#password">kees:password</a>
    /// </summary>
    let password = _prefixId.prefix "password"
    /// <summary>
    ///   <para>rdfs:label : policy name</para>
    ///   <para>rdfs:comment : a conventional name for a Policy. Should be univoque inside the knowledge base.</para>
    ///   <a href="http://linkeddata.center/kees/v1#policyName">kees:policyName</a>
    /// </summary>
    let policyName = _prefixId.prefix "policyName"
    /// <summary>
    ///   <para>rdfs:label : previous page</para>
    ///   <para>rdfs:comment : states that referred Page has a previous page</para>
    ///   <a href="http://linkeddata.center/kees/v1#prevPage">kees:prevPage</a>
    /// </summary>
    let prevPage = _prefixId.prefix "prevPage"
    /// <summary>
    ///   <para>rdfs:label : query method</para>
    ///   <para>rdfs:comment : The http request method used in a SPARQL query. Accepted metods: "POST"  and "GET". Defaults to "POST" if not specified.</para>
    ///   <a href="http://linkeddata.center/kees/v1#queryMethod">kees:queryMethod</a>
    /// </summary>
    let queryMethod = _prefixId.prefix "queryMethod"
    /// <summary>
    ///   <para>rdfs:label : query name</para>
    ///   <para>rdfs:comment : The name of the graph that will contain a sparql query result. If not specfied hinerit the sparql service endpoint url.</para>
    ///   <a href="http://linkeddata.center/kees/v1#queryName">kees:queryName</a>
    /// </summary>
    let queryName = _prefixId.prefix "queryName"
    /// <summary>
    ///   <para>rdfs:label : query text</para>
    ///   <para>rdfs:comment : the text of a sparql query. In the query text you can inject variables with the form %varname=default value% where varname is a word a default value a string.</para>
    ///   <a href="http://linkeddata.center/kees/v1#queryText">kees:queryText</a>
    /// </summary>
    let queryText = _prefixId.prefix "queryText"
    /// <summary>
    ///   <para>rdfs:label : requires authentication</para>
    ///   <para>rdfs:comment : The related resource is an authentication method to be used to access dataset during the execution of the described accrual policy. If not present, no authentication required.</para>
    ///   <a href="http://linkeddata.center/kees/v1#requiresAuthentication">kees:requiresAuthentication</a>
    /// </summary>
    let requiresAuthentication = _prefixId.prefix "requiresAuthentication"
    /// <summary>
    ///   <para>rdfs:label : rule  name</para>
    ///   <para>rdfs:comment : a conventional name for a Reasoning Policy. Should be univoque inside the knowledge base.</para>
    ///   <a href="http://linkeddata.center/kees/v1#ruleName">kees:ruleName</a>
    /// </summary>
    let ruleName = _prefixId.prefix "ruleName"
    /// <summary>
    ///   <para>rdfs:comment : The rule text body in the form:
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
    /// </para>
    ///   <a href="http://linkeddata.center/kees/v1#ruleText">kees:ruleText</a>
    /// </summary>
    let ruleText = _prefixId.prefix "ruleText"
    /// <summary>
    ///   <para>rdfs:label : source</para>
    ///   <para>rdfs:comment : The URL of a web resource exposing RDF data facts.</para>
    ///   <a href="http://linkeddata.center/kees/v1#source">kees:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : sparql endpoint</para>
    ///   <para>rdfs:comment : An url of a sparql service endpoint. similar to sd:endpoint</para>
    ///   <a href="http://linkeddata.center/kees/v1#sparqlEndpoint">kees:sparqlEndpoint</a>
    /// </summary>
    let sparqlEndpoint = _prefixId.prefix "sparqlEndpoint"
    /// <summary>
    ///   <para>rdfs:label : supports http caching</para>
    ///   <para>rdfs:comment : Support http caching specification (RFC 2616 ) in sending HTTP requests. If not present, true is inferred.</para>
    ///   <a href="http://linkeddata.center/kees/v1#supportsHttpCaching">kees:supportsHttpCaching</a>
    /// </summary>
    let supportsHttpCaching = _prefixId.prefix "supportsHttpCaching"
    /// <summary>
    ///   <para>rdfs:label : supports LDPPP</para>
    ///   <para>rdfs:comment : The described accrual  policy supports the Linked Data Platform Paging Protocol following link=next in http headers. If not specified false is inferred false.</para>
    ///   <a href="http://linkeddata.center/kees/v1#supportsLDPPP">kees:supportsLDPPP</a>
    /// </summary>
    let supportsLDPPP = _prefixId.prefix "supportsLDPPP"
    /// <summary>
    ///   <para>rdfs:label : to page</para>
    ///   <para>rdfs:comment : The last page returned by a SPARQL query. If not present defaults to 1.</para>
    ///   <a href="http://linkeddata.center/kees/v1#toPage">kees:toPage</a>
    /// </summary>
    let toPage = _prefixId.prefix "toPage"
    /// <summary>
    ///   <para>rdfs:comment : is the number of SPARQL uopdate transaction performed to complete a knowledge accrual activity.rdfs:comment : transaction count</para>
    ///   <a href="http://linkeddata.center/kees/v1#transactionCount">kees:transactionCount</a>
    /// </summary>
    let transactionCount = _prefixId.prefix "transactionCount"
    /// <summary>
    ///   <para>rdfs:comment : is the number of triples ingested by an accrual activity.rdfs:comment : triple count</para>
    ///   <a href="http://linkeddata.center/kees/v1#tripleCount">kees:tripleCount</a>
    /// </summary>
    let tripleCount = _prefixId.prefix "tripleCount"
    /// <summary>
    ///   <para>rdfs:label : url</para>
    ///   <para>rdfs:comment : An url</para>
    ///   <a href="http://linkeddata.center/kees/v1#url">kees:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : used memory</para>
    ///   <para>rdfs:comment : Extimated RAM bytes used by activity processing.</para>
    ///   <a href="http://linkeddata.center/kees/v1#usedMemory">kees:usedMemory</a>
    /// </summary>
    let usedMemory = _prefixId.prefix "usedMemory"
    /// <summary>
    ///   <para>rdfs:label : username</para>
    ///   <para>rdfs:comment : Username in basic http autentication method</para>
    ///   <a href="http://linkeddata.center/kees/v1#username">kees:username</a>
    /// </summary>
    let username = _prefixId.prefix "username"
    /// <summary>
    ///   <para>rdfs:label : vocabulary</para>
    ///   <para>rdfs:comment : It's datasource for a resource that contains TBox statements.</para>
    ///   <a href="http://linkeddata.center/kees/v1#vocabulary">kees:vocabulary</a>
    /// </summary>
    let vocabulary = _prefixId.prefix "vocabulary"
    /// <summary>
    ///   <para>rdfs:label : workflow structure</para>
    ///   <para>rdfs:comment : A kees cycle description  in the form "booting =&gt; learning =&gt; reasoning " with some phases that can be omitted (i.e.  "learning =&gt; reasoning ")</para>
    ///   <a href="http://linkeddata.center/kees/v1#workflowStructure">kees:workflowStructure</a>
    /// </summary>
    let workflowStructure = _prefixId.prefix "workflowStructure"
