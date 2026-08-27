namespace http.linkeddata.center.kees.v1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module kees =
    let _namespace_iri = Namespace_Iri kees |> NamespaceIRI
    /// <summary>
    ///   <para>kees:ABoxGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A named graph containing only facts."</para>
    /// labels<para>"ABox Graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ABoxGraph">http://linkeddata.center/kees/v1#ABoxGraph</seealso>
    let ABoxGraph = Prefixed_Name(kees, "ABoxGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating knowledge base entities. It is a subclass of prov:Activity class."</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Activity">http://linkeddata.center/kees/v1#Activity</seealso>
    let Activity = Prefixed_Name(kees, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>kees:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A software agent running kees compliant software. It is a subclass of prov:SoftwareAgent"</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Agent">http://linkeddata.center/kees/v1#Agent</seealso>
    let Agent = Prefixed_Name(kees, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>kees:Answer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A query that returns a boolean value (true or false). Realized by a SPARQL ASK construct."</para>
    /// labels<para>"Answer"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Answer">http://linkeddata.center/kees/v1#Answer</seealso>
    let Answer = Prefixed_Name(kees, "Answer") |> PrefixedName

    /// <summary>
    ///   <para>kees:AuthenticationPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An authentication method used to access a resource"</para>
    /// labels<para>"Authentication Method"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#AuthenticationPolicy">http://linkeddata.center/kees/v1#AuthenticationPolicy</seealso>
    let AuthenticationPolicy =
        Prefixed_Name(kees, "AuthenticationPolicy") |> PrefixedName

    /// <summary>
    ///   <para>kees:BootGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A special graph that can include boot directive that are copiet to config graph."</para>
    /// labels<para>"Boot Graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#BootGraph">http://linkeddata.center/kees/v1#BootGraph</seealso>
    let BootGraph = Prefixed_Name(kees, "BootGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:BulkAccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accrual policy that creates a knowledge graph in the knowlegde base  from a  web resource exposing  RDF data. Implies that the described resource kees:generatesGraphType  kees:LinkedDataGraph."</para>
    ///   <para>"Linked data platform  Rdf Resource accrual policy"</para>
    /// labels<para>"Bulk Accrual Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#BulkAccrualPolicy">http://linkeddata.center/kees/v1#BulkAccrualPolicy</seealso>
    let BulkAccrualPolicy = Prefixed_Name(kees, "BulkAccrualPolicy") |> PrefixedName
    /// <summary>
    ///   <para>kees:BulkIngestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A processor that processes bulk accrual policies."</para>
    /// labels<para>"Bulk Ingestor"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#BulkIngestor">http://linkeddata.center/kees/v1#BulkIngestor</seealso>
    let BulkIngestor = Prefixed_Name(kees, "BulkIngestor") |> PrefixedName
    /// <summary>
    ///   <para>kees:ConfigAccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accrual policy that creates a knowledge graph in the knowlegde base  from a resource exposing KEES ontology RDF data. Implies that the described resource kees:generatesGraphType  keesConfigDataGraph."</para>
    /// labels<para>"Config Accrual Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ConfigAccrualPolicy">http://linkeddata.center/kees/v1#ConfigAccrualPolicy</seealso>
    let ConfigAccrualPolicy = Prefixed_Name(kees, "ConfigAccrualPolicy") |> PrefixedName
    /// <summary>
    ///   <para>kees:ConfigImporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A processor that processes config accrual policies."</para>
    /// labels<para>"Config Importer"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ConfigImporter">http://linkeddata.center/kees/v1#ConfigImporter</seealso>
    let ConfigImporter = Prefixed_Name(kees, "ConfigImporter") |> PrefixedName
    /// <summary>
    ///   <para>kees:ConstructRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A rule that create new facts in a Knowledge base"</para>
    /// labels<para>"Construct Rule"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ConstructRule">http://linkeddata.center/kees/v1#ConstructRule</seealso>
    let ConstructRule = Prefixed_Name(kees, "ConstructRule") |> PrefixedName
    /// <summary>
    ///   <para>kees:DestructRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A rule that destroy (invalidated) facts in a knowledge base"</para>
    /// labels<para>"Destruct Rule"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#DestructRule">http://linkeddata.center/kees/v1#DestructRule</seealso>
    let DestructRule = Prefixed_Name(kees, "DestructRule") |> PrefixedName
    /// <summary>
    ///   <para>kees:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An kees entity is a something about the  Knowledge Base.   It is a subclass of prov:Entity Class"</para>
    /// labels<para>"Entity"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Entity">http://linkeddata.center/kees/v1#Entity</seealso>
    let Entity = Prefixed_Name(kees, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>kees:FailureReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A  report  that states a processing error."</para>
    /// labels<para>"Failure Report"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#FailureReport">http://linkeddata.center/kees/v1#FailureReport</seealso>
    let FailureReport = Prefixed_Name(kees, "FailureReport") |> PrefixedName
    /// <summary>
    ///   <para>kees:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A query that returns an RDF graph. Realized by a SPARQL CONSTRUCT."</para>
    /// labels<para>"Graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Graph">http://linkeddata.center/kees/v1#Graph</seealso>
    let Graph = Prefixed_Name(kees, "Graph") |> PrefixedName

    /// <summary>
    ///   <para>kees:HttpBasicAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"http basic autentication method as described in RFC 2617"</para>
    /// labels<para>"Http Basic Autentication Method"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#HttpBasicAuthentication">http://linkeddata.center/kees/v1#HttpBasicAuthentication</seealso>
    let HttpBasicAuthentication =
        Prefixed_Name(kees, "HttpBasicAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>kees:InferredKnowledgeGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A named graph containing inferred facts (by axioms or rules)"</para>
    /// labels<para>"Inferred Knowledge Graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#InferredKnowledgeGraph">http://linkeddata.center/kees/v1#InferredKnowledgeGraph</seealso>
    let InferredKnowledgeGraph =
        Prefixed_Name(kees, "InferredKnowledgeGraph") |> PrefixedName

    /// <summary>
    ///   <para>kees:IngestionActivityReportGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A named graph that stores statements about an ingestion activity.  By default all report about completed activities older than 24 hours are purged away."</para>
    /// labels<para>"Ingestion Activity Report Graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#IngestionActivityReportGraph">http://linkeddata.center/kees/v1#IngestionActivityReportGraph</seealso>
    let IngestionActivityReportGraph =
        Prefixed_Name(kees, "IngestionActivityReportGraph") |> PrefixedName

    /// <summary>
    ///   <para>kees:IngestionCycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The kees cycle window processing activity ( ie.  Booting, Learning, reasoning)"</para>
    /// labels<para>"Ingestion Cycle"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#IngestionCycle">http://linkeddata.center/kees/v1#IngestionCycle</seealso>
    let IngestionCycle = Prefixed_Name(kees, "IngestionCycle") |> PrefixedName
    /// <summary>
    ///   <para>kees:IngestionFromLDPRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indexing of a web RDF resource using INSERT DATA sparql update construct. This activity is pretty flexible but requires an extra loading and parsing of resources. It recognize LDPRS accual policies."</para>
    /// labels<para>"Ingestion From LDPRS"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#IngestionFromLDPRS">http://linkeddata.center/kees/v1#IngestionFromLDPRS</seealso>
    let IngestionFromLDPRS = Prefixed_Name(kees, "IngestionFromLDPRS") |> PrefixedName

    /// <summary>
    ///   <para>kees:IngestionFromLodLaundromat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity to index a streamed RDF resouce provided by a LOD Laundromat service."</para>
    /// labels<para>"Ingestion From a Lod Laundromat"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#IngestionFromLodLaundromat">http://linkeddata.center/kees/v1#IngestionFromLodLaundromat</seealso>
    let IngestionFromLodLaundromat =
        Prefixed_Name(kees, "IngestionFromLodLaundromat") |> PrefixedName

    /// <summary>
    ///   <para>kees:IngestionFromSparqlService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An activity to index  RDF triples extracted from a sparql service."</para>
    /// labels<para>"Ingestion From Sparql Service"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#IngestionFromSparqlService">http://linkeddata.center/kees/v1#IngestionFromSparqlService</seealso>
    let IngestionFromSparqlService =
        Prefixed_Name(kees, "IngestionFromSparqlService") |> PrefixedName

    /// <summary>
    ///   <para>kees:IngestionPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan that describe the objective  for a data ingestion activity."</para>
    /// labels<para>"Ingestion Plan"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#IngestionPlan">http://linkeddata.center/kees/v1#IngestionPlan</seealso>
    let IngestionPlan = Prefixed_Name(kees, "IngestionPlan") |> PrefixedName
    /// <summary>
    ///   <para>kees:KBConfigGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A named graph that contains knowlege base configuration data. Data consist in instances of Accrual Policies."</para>
    /// labels<para>"Knowledge Base Config Graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#KBConfigGraph">http://linkeddata.center/kees/v1#KBConfigGraph</seealso>
    let KBConfigGraph = Prefixed_Name(kees, "KBConfigGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:KnowledgeAccrual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The abstract superclass for activities that builds knowledge graphs."</para>
    /// labels<para>"Knowledge Accrual"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#KnowledgeAccrual">http://linkeddata.center/kees/v1#KnowledgeAccrual</seealso>
    let KnowledgeAccrual = Prefixed_Name(kees, "KnowledgeAccrual") |> PrefixedName

    /// <summary>
    ///   <para>kees:KnowledgeAccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The superclass for all the policies that describe how to learn facts from the web. The Accrual policy describes how to create and maintain ABox and TBox statements in a knowledge base."</para>
    /// labels<para>"Knowledge Accrual Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#KnowledgeAccrualPolicy">http://linkeddata.center/kees/v1#KnowledgeAccrualPolicy</seealso>
    let KnowledgeAccrualPolicy =
        Prefixed_Name(kees, "KnowledgeAccrualPolicy") |> PrefixedName

    /// <summary>
    ///   <para>kees:KnowledgeBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A RDF graph database composed by ABox and TBox statements organized in named graph."</para>
    /// labels<para>"Knowledge Base"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#KnowledgeBase">http://linkeddata.center/kees/v1#KnowledgeBase</seealso>
    let KnowledgeBase = Prefixed_Name(kees, "KnowledgeBase") |> PrefixedName
    /// <summary>
    ///   <para>kees:KnowledgeGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#KnowledgeGraph">http://linkeddata.center/kees/v1#KnowledgeGraph</seealso>
    let KnowledgeGraph = Prefixed_Name(kees, "KnowledgeGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:LDPRSAccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accrual policy to  create a  named  graph in the graph database from a Linked Data Platform Rdf Source , using eTag and lastUpdate http caching info. It recognizes LDP paging protocol.  Standard RDF resource loading  policy for  any  web resource exposing RDF data."</para>
    /// labels<para>"LDPRS Accrual Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#LDPRSAccrualPolicy">http://linkeddata.center/kees/v1#LDPRSAccrualPolicy</seealso>
    let LDPRSAccrualPolicy = Prefixed_Name(kees, "LDPRSAccrualPolicy") |> PrefixedName

    /// <summary>
    ///   <para>kees:LDPRSAccrualPolicyProcessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The abstract superclass for processors that manage  LDPRS accual policies."</para>
    /// labels<para>"LDPRS Accrual Policy Processor"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#LDPRSAccrualPolicyProcessor">http://linkeddata.center/kees/v1#LDPRSAccrualPolicyProcessor</seealso>
    let LDPRSAccrualPolicyProcessor =
        Prefixed_Name(kees, "LDPRSAccrualPolicyProcessor") |> PrefixedName

    /// <summary>
    ///   <para>kees:LinkedDataGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ABox named graph that stores facts from  linked data learned from web 3.0 resources."</para>
    /// labels<para>"Linked Data Graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#LinkedDataGraph">http://linkeddata.center/kees/v1#LinkedDataGraph</seealso>
    let LinkedDataGraph = Prefixed_Name(kees, "LinkedDataGraph") |> PrefixedName

    /// <summary>
    ///   <para>kees:LodLaundromatAccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accrual policy that creates a knowledge graph in the knowlegde base  from a resource contained in lod laundromatic service."</para>
    /// labels<para>"Lod Laundromat Accrual Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#LodLaundromatAccrualPolicy">http://linkeddata.center/kees/v1#LodLaundromatAccrualPolicy</seealso>
    let LodLaundromatAccrualPolicy =
        Prefixed_Name(kees, "LodLaundromatAccrualPolicy") |> PrefixedName

    /// <summary>
    ///   <para>kees:LodLaundromatAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A client for lod laundromat web service. A processor that processes lod laundromat  accrual policies."</para>
    /// labels<para>"Lod Laundromat Agent"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#LodLaundromatAgent">http://linkeddata.center/kees/v1#LodLaundromatAgent</seealso>
    let LodLaundromatAgent = Prefixed_Name(kees, "LodLaundromatAgent") |> PrefixedName
    /// <summary>
    ///   <para>kees:NoChangeReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A report that states that the knowledge base was not changed by the processing activity."</para>
    /// labels<para>"No Change Report"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#NoChangeReport">http://linkeddata.center/kees/v1#NoChangeReport</seealso>
    let NoChangeReport = Prefixed_Name(kees, "NoChangeReport") |> PrefixedName
    /// <summary>
    ///   <para>kees:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A paged resource,  a subclass of http://www.w3.org/ns/ldp#Page."</para>
    /// labels<para>"Page"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Page">http://linkeddata.center/kees/v1#Page</seealso>
    let Page = Prefixed_Name(kees, "Page") |> PrefixedName
    /// <summary>
    ///   <para>kees:PagingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Page sequence info"</para>
    /// labels<para>"Paging Data"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#PagingData">http://linkeddata.center/kees/v1#PagingData</seealso>
    let PagingData = Prefixed_Name(kees, "PagingData") |> PrefixedName
    /// <summary>
    ///   <para>kees:Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity that represents a set of actions or steps intended by one or more processor  to achieve some goals. It is equivalent to prov:Plan."</para>
    /// labels<para>"Plan"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Plan">http://linkeddata.center/kees/v1#Plan</seealso>
    let Plan = Prefixed_Name(kees, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>kees:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan or course of action by an authority, intended to influence and determine  actions, and other matters. Can be considered a subclass of dct:Plan Class."</para>
    /// labels<para>"Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Policy">http://linkeddata.center/kees/v1#Policy</seealso>
    let Policy = Prefixed_Name(kees, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>kees:ProcessingReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The report about the result of a processing activity."</para>
    /// labels<para>"Processing Report"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ProcessingReport">http://linkeddata.center/kees/v1#ProcessingReport</seealso>
    let ProcessingReport = Prefixed_Name(kees, "ProcessingReport") |> PrefixedName
    /// <summary>
    ///   <para>kees:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A generic query expressed by a SPARQL construct."</para>
    /// labels<para>"Query"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Query">http://linkeddata.center/kees/v1#Query</seealso>
    let Query = Prefixed_Name(kees, "Query") |> PrefixedName
    /// <summary>
    ///   <para>kees:Reasoner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A processor that create new facts using inference, rules and axioms."</para>
    /// labels<para>"reasoner"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Reasoner">http://linkeddata.center/kees/v1#Reasoner</seealso>
    let Reasoner = Prefixed_Name(kees, "Reasoner") |> PrefixedName
    /// <summary>
    ///   <para>kees:Reasoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The activity of materializing RDF statements from rules and axioms."</para>
    /// labels<para>"Reasoning"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Reasoning">http://linkeddata.center/kees/v1#Reasoning</seealso>
    let Reasoning = Prefixed_Name(kees, "Reasoning") |> PrefixedName
    /// <summary>
    ///   <para>kees:ReasoningPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A  plan for a reasoning activity  that concens the creation or the destruction of   facts from a production rule."</para>
    /// labels<para>"Reasoning Plan"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ReasoningPlan">http://linkeddata.center/kees/v1#ReasoningPlan</seealso>
    let ReasoningPlan = Prefixed_Name(kees, "ReasoningPlan") |> PrefixedName
    /// <summary>
    ///   <para>kees:ReasoningPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A construction rule according a legacy syntax derived from stardog DL entilement rules"</para>
    /// labels<para>"Reasoning Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ReasoningPolicy">http://linkeddata.center/kees/v1#ReasoningPolicy</seealso>
    let ReasoningPolicy = Prefixed_Name(kees, "ReasoningPolicy") |> PrefixedName
    /// <summary>
    ///   <para>kees:ResourceIngestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A super class for all activities that get data from a web resource."</para>
    /// labels<para>"Resource Ingestion"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ResourceIngestion">http://linkeddata.center/kees/v1#ResourceIngestion</seealso>
    let ResourceIngestion = Prefixed_Name(kees, "ResourceIngestion") |> PrefixedName
    /// <summary>
    ///   <para>kees:RetentionPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Retention Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#RetentionPolicy">http://linkeddata.center/kees/v1#RetentionPolicy</seealso>
    let RetentionPolicy = Prefixed_Name(kees, "RetentionPolicy") |> PrefixedName

    /// <summary>
    ///   <para>kees:SimplifiedResourceIngestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indexing of a web resource useing the LOAD construct in sparql update. This Ingestion activity doe not supports content negotiation, http chahcing, LDP paging and depends from baking quadstore server inplementation. Should be used when possible because it is portable and fast. It recognize LDPRS accual policies."</para>
    /// labels<para>"Simplified Resource Ingestion"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#SimplifiedResourceIngestion">http://linkeddata.center/kees/v1#SimplifiedResourceIngestion</seealso>
    let SimplifiedResourceIngestion =
        Prefixed_Name(kees, "SimplifiedResourceIngestion") |> PrefixedName

    /// <summary>
    ///   <para>kees:SparqlIngestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a processor that manages sparql service accrual policies."</para>
    /// labels<para>"Sparql Ingestor"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#SparqlIngestor">http://linkeddata.center/kees/v1#SparqlIngestor</seealso>
    let SparqlIngestor = Prefixed_Name(kees, "SparqlIngestor") |> PrefixedName

    /// <summary>
    ///   <para>kees:SparqlServiceAccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:Class</para>
    ///   <para>"Load RDF resource executing a sparql query to a sparql endpoint (using POST).
    /// The query must be contained (unencoded) in accrualOption propery"</para>
    /// labels<para>"SPARQL Ingestion Accrual Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#SparqlServiceAccrualPolicy">http://linkeddata.center/kees/v1#SparqlServiceAccrualPolicy</seealso>
    let SparqlServiceAccrualPolicy =
        Prefixed_Name(kees, "SparqlServiceAccrualPolicy") |> PrefixedName

    /// <summary>
    ///   <para>kees:SuccessReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A report that states a succesful processing result."</para>
    /// labels<para>"Success Report"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#SuccessReport">http://linkeddata.center/kees/v1#SuccessReport</seealso>
    let SuccessReport = Prefixed_Name(kees, "SuccessReport") |> PrefixedName
    /// <summary>
    ///   <para>kees:TBoxAccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An accrual policy that creates a knowledge graph in the knowlegde base  from a resource exposing ontologies in RDF (owl, rdfs, skos). Implies that the described resource kees:generatesGraphType  kees:TBoxGraph."</para>
    /// labels<para>"TBox Accrual Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#TBoxAccrualPolicy">http://linkeddata.center/kees/v1#TBoxAccrualPolicy</seealso>
    let TBoxAccrualPolicy = Prefixed_Name(kees, "TBoxAccrualPolicy") |> PrefixedName
    /// <summary>
    ///   <para>kees:TBoxGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A named graph that contains vocabularies and taxonomies."</para>
    /// labels<para>"TBox Graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#TBoxGraph">http://linkeddata.center/kees/v1#TBoxGraph</seealso>
    let TBoxGraph = Prefixed_Name(kees, "TBoxGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:TBoxIngestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A processor that processes TBox accrual policies."</para>
    /// labels<para>"TBox Ingestor"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#TBoxIngestor">http://linkeddata.center/kees/v1#TBoxIngestor</seealso>
    let TBoxIngestor = Prefixed_Name(kees, "TBoxIngestor") |> PrefixedName
    /// <summary>
    ///   <para>kees:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A query that returns a table of data. Realized by a SPARQL SELECT construct."</para>
    /// labels<para>"Table"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Table">http://linkeddata.center/kees/v1#Table</seealso>
    let Table = Prefixed_Name(kees, "Table") |> PrefixedName
    /// <summary>
    ///   <para>kees:UpdatePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A forecasted  rate at which change recurs in an ABox Graph ."</para>
    /// labels<para>"Update Policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#UpdatePolicy">http://linkeddata.center/kees/v1#UpdatePolicy</seealso>
    let UpdatePolicy = Prefixed_Name(kees, "UpdatePolicy") |> PrefixedName
    /// <summary>
    ///   <para>kees:Workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan for a kees Cycle processing."</para>
    /// labels<para>"Workflow"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#Workflow">http://linkeddata.center/kees/v1#Workflow</seealso>
    let Workflow = Prefixed_Name(kees, "Workflow") |> PrefixedName
    /// <summary>
    ///   <para>kees:byteCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"is the number of bytes processed by an ingestion activity."</para>
    /// labels<para>"byte count"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#byteCount">http://linkeddata.center/kees/v1#byteCount</seealso>
    let byteCount = Prefixed_Name(kees, "byteCount") |> PrefixedName
    /// <summary>
    ///   <para>kees:constructQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The SPARQL 1.1.  query to extract data from a SPARQL endpoint. No paging constructs allowed ( OFSET and LIMIT ), use pageSize, fromPage and toPage instead. If not specified "CONSTRUCT { ?s ?p ?o }  WHERE { ?s ?p ?o }" apply"</para>
    /// labels<para>"construct query"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#constructQuery">http://linkeddata.center/kees/v1#constructQuery</seealso>
    let constructQuery = Prefixed_Name(kees, "constructQuery") |> PrefixedName
    /// <summary>
    ///   <para>kees:createsGraphName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The related uri is used as as the name of the graph produced according the described accrual policy. If not specified the same value of kees:url is inferred."</para>
    /// labels<para>"creates graph name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#createsGraphName">http://linkeddata.center/kees/v1#createsGraphName</seealso>
    let createsGraphName = Prefixed_Name(kees, "createsGraphName") |> PrefixedName
    /// <summary>
    ///   <para>kees:executionPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An optional integer that determine the ordere of execution of a rule ( ascending)."</para>
    /// labels<para>"execution priority"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#executionPriority">http://linkeddata.center/kees/v1#executionPriority</seealso>
    let executionPriority = Prefixed_Name(kees, "executionPriority") |> PrefixedName
    /// <summary>
    ///   <para>kees:expectedParts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the number of expected resource partitions (i.e pages)."</para>
    /// labels<para>"expected parts"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#expectedParts">http://linkeddata.center/kees/v1#expectedParts</seealso>
    let expectedParts = Prefixed_Name(kees, "expectedParts") |> PrefixedName
    /// <summary>
    ///   <para>kees:expectedTriples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the expected maximum number of triple to be indexed by an activity."</para>
    /// labels<para>"expected triples"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#expectedTriples">http://linkeddata.center/kees/v1#expectedTriples</seealso>
    let expectedTriples = Prefixed_Name(kees, "expectedTriples") |> PrefixedName
    /// <summary>
    ///   <para>kees:forceAccept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Define specified http accept header in requesting source. The sintax must be complain to RFC 2616 for HTTP 1.1. accept header. If not specified 'application/n-triples,application/ld+json,application/rdf+xml,text/turtle,*/*;q=0.4' it is used."</para>
    /// labels<para>"force accept"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#forceAccept">http://linkeddata.center/kees/v1#forceAccept</seealso>
    let forceAccept = Prefixed_Name(kees, "forceAccept") |> PrefixedName
    /// <summary>
    ///   <para>kees:fromPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The first page returned by a SPARQL in a query iteration. Defaults to 1 if not present."</para>
    /// labels<para>"from page"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#fromPage">http://linkeddata.center/kees/v1#fromPage</seealso>
    let fromPage = Prefixed_Name(kees, "fromPage") |> PrefixedName
    /// <summary>
    ///   <para>kees:generatesGraphType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The  described accrual policy has the objective to generate/maintain a knowledge graph of the related type. If the property is not specified, nor explicitely nor implicitely (by axioms), kees:LinkedDataGraph is inferred."</para>
    /// labels<para>"generates  graph type"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#generatesGraphType">http://linkeddata.center/kees/v1#generatesGraphType</seealso>
    let generatesGraphType = Prefixed_Name(kees, "generatesGraphType") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasABoxGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The related resource is one of the ABox graphs that contain linked data facts in the described  knowlege base."</para>
    /// labels<para>"has ABox graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasABoxGraph">http://linkeddata.center/kees/v1#hasABoxGraph</seealso>
    let hasABoxGraph = Prefixed_Name(kees, "hasABoxGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasAccrualPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The related resource is a policy governing the addition of a named graph to the described knowledge base. Very similar to the dct:accrualPolicy property."</para>
    /// labels<para>"has accrual policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasAccrualPolicy">http://linkeddata.center/kees/v1#hasAccrualPolicy</seealso>
    let hasAccrualPolicy = Prefixed_Name(kees, "hasAccrualPolicy") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasBootGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property states that annotated knowledge base as a referened boot graph."</para>
    /// labels<para>"has boot graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasBootGraph">http://linkeddata.center/kees/v1#hasBootGraph</seealso>
    let hasBootGraph = Prefixed_Name(kees, "hasBootGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasConfigGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The related resource is one of the configuration graph that caracterize the described knowledge base."</para>
    /// labels<para>"has config graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasConfigGraph">http://linkeddata.center/kees/v1#hasConfigGraph</seealso>
    let hasConfigGraph = Prefixed_Name(kees, "hasConfigGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasFrequencyPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Frequency period in seconds."</para>
    /// labels<para>"has frequency period"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasFrequencyPeriod">http://linkeddata.center/kees/v1#hasFrequencyPeriod</seealso>
    let hasFrequencyPeriod = Prefixed_Name(kees, "hasFrequencyPeriod") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasInferenceGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The related resource is the graph where reasoners places all materialized triples."</para>
    /// labels<para>"has inference graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasInferenceGraph">http://linkeddata.center/kees/v1#hasInferenceGraph</seealso>
    let hasInferenceGraph = Prefixed_Name(kees, "hasInferenceGraph") |> PrefixedName

    /// <summary>
    ///   <para>kees:hasIngestionActivityReportGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The related resource is a graph used to store logs  about a kees cycle executions."</para>
    /// labels<para>"has ingestion activity report graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasIngestionActivityReportGraph">http://linkeddata.center/kees/v1#hasIngestionActivityReportGraph</seealso>
    let hasIngestionActivityReportGraph =
        Prefixed_Name(kees, "hasIngestionActivityReportGraph") |> PrefixedName

    /// <summary>
    ///   <para>kees:hasLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the max size in RDF triple of a paged resource"</para>
    /// labels<para>"has limit"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasLimit">http://linkeddata.center/kees/v1#hasLimit</seealso>
    let hasLimit = Prefixed_Name(kees, "hasLimit") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"first record ofset of a page."</para>
    /// labels<para>"has offset"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasOffset">http://linkeddata.center/kees/v1#hasOffset</seealso>
    let hasOffset = Prefixed_Name(kees, "hasOffset") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasPagingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The related resource is a dataset that contains the page info about the annotated paged resource."</para>
    /// labels<para>"has Paging Data"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasPagingData">http://linkeddata.center/kees/v1#hasPagingData</seealso>
    let hasPagingData = Prefixed_Name(kees, "hasPagingData") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasReasoningRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"this property states that the annotated Knowledge Accrual has a reasoning policy."</para>
    /// labels<para>"hasReasoningPolicy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasReasoningRule">http://linkeddata.center/kees/v1#hasReasoningRule</seealso>
    let hasReasoningRule = Prefixed_Name(kees, "hasReasoningRule") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasResilience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of times  ABOX graph is retained in storage after a failure in fetchin it. The default is 0 that means that when a graph fails to load it is removed from the knowledge base. If the value of this attribute is, for instance 3, this means that the Graph will be keept in the knowledge base untill its loading fails for three consecutive  times (the fourth error drives a graph drop). A succesfull loading reset the fail counter.N.B. a "not modified" message does not reset the fail counter."</para>
    /// labels<para>"has resilience"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasResilience">http://linkeddata.center/kees/v1#hasResilience</seealso>
    let hasResilience = Prefixed_Name(kees, "hasResilience") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasTBoxGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The related resource is one of the ABox graphs that contain vocabularies and taxonomies used in the described  knowlege base."</para>
    /// labels<para>"has TBox graph"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasTBoxGraph">http://linkeddata.center/kees/v1#hasTBoxGraph</seealso>
    let hasTBoxGraph = Prefixed_Name(kees, "hasTBoxGraph") |> PrefixedName
    /// <summary>
    ///   <para>kees:hasUpdatePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The related resource is a policy that suggest a time frame, expressed in seconds after witch the described accrual policy should check data for update.  If not specified , a period of one hour is guessed . A policy that specify a long interval greatly improves ingestion engines performances."</para>
    /// labels<para>"has update policy"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#hasUpdatePolicy">http://linkeddata.center/kees/v1#hasUpdatePolicy</seealso>
    let hasUpdatePolicy = Prefixed_Name(kees, "hasUpdatePolicy") |> PrefixedName

    /// <summary>
    ///   <para>kees:havingTargetGraphName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"States that the described ingestion plan is about the creation/maintenance of a graph named as the referenced object."</para>
    /// labels<para>"having target graph name"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#havingTargetGraphName">http://linkeddata.center/kees/v1#havingTargetGraphName</seealso>
    let havingTargetGraphName =
        Prefixed_Name(kees, "havingTargetGraphName") |> PrefixedName

    /// <summary>
    ///   <para>kees:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The URL of a web resource exposing a Kees configuration data."</para>
    /// labels<para>"include"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#includes">http://linkeddata.center/kees/v1#includes</seealso>
    let includes = Prefixed_Name(kees, "includes") |> PrefixedName
    /// <summary>
    ///   <para>kees:isLastPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"states that the referenced page is the last one. If not present defautlt is false."</para>
    /// labels<para>"is the last page"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#isLastPage">http://linkeddata.center/kees/v1#isLastPage</seealso>
    let isLastPage = Prefixed_Name(kees, "isLastPage") |> PrefixedName
    /// <summary>
    ///   <para>kees:lodLaundromatUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An url of a resource stored in the  lod laundromat wardrobe. similar to llo:url."</para>
    /// labels<para>"lod laundromat url"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#lodLaundromatUrl">http://linkeddata.center/kees/v1#lodLaundromatUrl</seealso>
    let lodLaundromatUrl = Prefixed_Name(kees, "lodLaundromatUrl") |> PrefixedName
    /// <summary>
    ///   <para>kees:nextPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"States that referred Page has a next page."</para>
    /// labels<para>"next page"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#nextPage">http://linkeddata.center/kees/v1#nextPage</seealso>
    let nextPage = Prefixed_Name(kees, "nextPage") |> PrefixedName
    /// <summary>
    ///   <para>kees:onFetchingError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The related resource declares the policy to adopt when an error occurs during the execution of the described accrual policy. If not present any error in data loading removes the related graph the in knowledge base."</para>
    /// labels<para>"on fetching error"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#onFetchingError">http://linkeddata.center/kees/v1#onFetchingError</seealso>
    let onFetchingError = Prefixed_Name(kees, "onFetchingError") |> PrefixedName
    /// <summary>
    ///   <para>kees:pageNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A page sequence number ."</para>
    /// labels<para>"page number"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#pageNum">http://linkeddata.center/kees/v1#pageNum</seealso>
    let pageNum = Prefixed_Name(kees, "pageNum") |> PrefixedName
    /// <summary>
    ///   <para>kees:pageSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The size for a SPARQL query page. Equivalent  with LIMIT clause. Defaults to 1000 if not defined"</para>
    /// labels<para>"page size"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#pageSize">http://linkeddata.center/kees/v1#pageSize</seealso>
    let pageSize = Prefixed_Name(kees, "pageSize") |> PrefixedName
    /// <summary>
    ///   <para>kees:password</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Password in basic autentication method"</para>
    /// labels<para>"password"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#password">http://linkeddata.center/kees/v1#password</seealso>
    let password = Prefixed_Name(kees, "password") |> PrefixedName
    /// <summary>
    ///   <para>kees:policyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"a conventional name for a Policy. Should be univoque inside the knowledge base."</para>
    /// labels<para>"policy name"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#policyName">http://linkeddata.center/kees/v1#policyName</seealso>
    let policyName = Prefixed_Name(kees, "policyName") |> PrefixedName
    /// <summary>
    ///   <para>kees:prevPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"states that referred Page has a previous page"</para>
    /// labels<para>"previous page"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#prevPage">http://linkeddata.center/kees/v1#prevPage</seealso>
    let prevPage = Prefixed_Name(kees, "prevPage") |> PrefixedName
    /// <summary>
    ///   <para>kees:queryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The http request method used in a SPARQL query. Accepted metods: "POST"  and "GET". Defaults to "POST" if not specified."</para>
    /// labels<para>"query method"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#queryMethod">http://linkeddata.center/kees/v1#queryMethod</seealso>
    let queryMethod = Prefixed_Name(kees, "queryMethod") |> PrefixedName
    /// <summary>
    ///   <para>kees:queryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The name of the graph that will contain a sparql query result. If not specfied hinerit the sparql service endpoint url."</para>
    /// labels<para>"query name"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#queryName">http://linkeddata.center/kees/v1#queryName</seealso>
    let queryName = Prefixed_Name(kees, "queryName") |> PrefixedName
    /// <summary>
    ///   <para>kees:queryText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the text of a sparql query. In the query text you can inject variables with the form %varname=default value% where varname is a word a default value a string."</para>
    /// labels<para>"query text"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#queryText">http://linkeddata.center/kees/v1#queryText</seealso>
    let queryText = Prefixed_Name(kees, "queryText") |> PrefixedName

    /// <summary>
    ///   <para>kees:requiresAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The related resource is an authentication method to be used to access dataset during the execution of the described accrual policy. If not present, no authentication required."</para>
    /// labels<para>"requires authentication"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#requiresAuthentication">http://linkeddata.center/kees/v1#requiresAuthentication</seealso>
    let requiresAuthentication =
        Prefixed_Name(kees, "requiresAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>kees:ruleName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"a conventional name for a Reasoning Policy. Should be univoque inside the knowledge base."</para>
    /// labels<para>"rule  name"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ruleName">http://linkeddata.center/kees/v1#ruleName</seealso>
    let ruleName = Prefixed_Name(kees, "ruleName") |> PrefixedName
    /// <summary>
    ///   <para>kees:ruleText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The rule text body in the form:
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
    /// "</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#ruleText">http://linkeddata.center/kees/v1#ruleText</seealso>
    let ruleText = Prefixed_Name(kees, "ruleText") |> PrefixedName
    /// <summary>
    ///   <para>kees:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The URL of a web resource exposing RDF data facts."</para>
    /// labels<para>"source"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#source">http://linkeddata.center/kees/v1#source</seealso>
    let source = Prefixed_Name(kees, "source") |> PrefixedName
    /// <summary>
    ///   <para>kees:sparqlEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An url of a sparql service endpoint. similar to sd:endpoint"</para>
    /// labels<para>"sparql endpoint"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#sparqlEndpoint">http://linkeddata.center/kees/v1#sparqlEndpoint</seealso>
    let sparqlEndpoint = Prefixed_Name(kees, "sparqlEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>kees:supportsHttpCaching</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Support http caching specification (RFC 2616 ) in sending HTTP requests. If not present, true is inferred."</para>
    /// labels<para>"supports http caching"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#supportsHttpCaching">http://linkeddata.center/kees/v1#supportsHttpCaching</seealso>
    let supportsHttpCaching = Prefixed_Name(kees, "supportsHttpCaching") |> PrefixedName
    /// <summary>
    ///   <para>kees:supportsLDPPP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The described accrual  policy supports the Linked Data Platform Paging Protocol following link=next in http headers. If not specified false is inferred false."</para>
    /// labels<para>"supports LDPPP"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#supportsLDPPP">http://linkeddata.center/kees/v1#supportsLDPPP</seealso>
    let supportsLDPPP = Prefixed_Name(kees, "supportsLDPPP") |> PrefixedName
    /// <summary>
    ///   <para>kees:toPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The last page returned by a SPARQL query. If not present defaults to 1."</para>
    /// labels<para>"to page"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#toPage">http://linkeddata.center/kees/v1#toPage</seealso>
    let toPage = Prefixed_Name(kees, "toPage") |> PrefixedName
    /// <summary>
    ///   <para>kees:transactionCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"is the number of SPARQL uopdate transaction performed to complete a knowledge accrual activity."</para>
    ///   <para>"transaction count"</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#transactionCount">http://linkeddata.center/kees/v1#transactionCount</seealso>
    let transactionCount = Prefixed_Name(kees, "transactionCount") |> PrefixedName
    /// <summary>
    ///   <para>kees:tripleCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"triple count"</para>
    ///   <para>"is the number of triples ingested by an accrual activity."</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#tripleCount">http://linkeddata.center/kees/v1#tripleCount</seealso>
    let tripleCount = Prefixed_Name(kees, "tripleCount") |> PrefixedName
    /// <summary>
    ///   <para>kees:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An url"</para>
    /// labels<para>"url"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#url">http://linkeddata.center/kees/v1#url</seealso>
    let url = Prefixed_Name(kees, "url") |> PrefixedName
    /// <summary>
    ///   <para>kees:usedMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Extimated RAM bytes used by activity processing."</para>
    /// labels<para>"used memory"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#usedMemory">http://linkeddata.center/kees/v1#usedMemory</seealso>
    let usedMemory = Prefixed_Name(kees, "usedMemory") |> PrefixedName
    /// <summary>
    ///   <para>kees:username</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Username in basic http autentication method"</para>
    /// labels<para>"username"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#username">http://linkeddata.center/kees/v1#username</seealso>
    let username = Prefixed_Name(kees, "username") |> PrefixedName
    /// <summary>
    ///   <para>kees:vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"It's datasource for a resource that contains TBox statements."</para>
    /// labels<para>"vocabulary"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#vocabulary">http://linkeddata.center/kees/v1#vocabulary</seealso>
    let vocabulary = Prefixed_Name(kees, "vocabulary") |> PrefixedName
    /// <summary>
    ///   <para>kees:workflowStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A kees cycle description  in the form "booting =&gt; learning =&gt; reasoning " with some phases that can be omitted (i.e.  "learning =&gt; reasoning ")"</para>
    /// labels<para>"workflow structure"</para></remarks>
    /// <seealso href="http://linkeddata.center/kees/v1#workflowStructure">http://linkeddata.center/kees/v1#workflowStructure</seealso>
    let workflowStructure = Prefixed_Name(kees, "workflowStructure") |> PrefixedName
