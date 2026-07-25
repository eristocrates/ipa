namespace https.open_metadata.org.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module om =
    let _namespace_iri = Namespace_Iri om |> NamespaceIRI
    /// <summary>
    ///   <para>om:AIApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>AI system such as a chatbot, agent, copilot, RAG application or multi-agent pipeline that may use multiple LLM models and tools</para>
    /// labels<para>AI Application</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/AIApplication">https://open-metadata.org/ontology/AIApplication</seealso>
    let AIApplication = Prefixed_Name(om, "AIApplication") |> PrefixedName
    /// <summary>
    ///   <para>om:AIGovernancePolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Policy rules for AI/LLM usage, compliance, and risk management (model approval, data access, bias thresholds, cost controls, etc.)</para>
    /// labels<para>AI Governance Policy</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/AIGovernancePolicy">https://open-metadata.org/ontology/AIGovernancePolicy</seealso>
    let AIGovernancePolicy = Prefixed_Name(om, "AIGovernancePolicy") |> PrefixedName
    /// <summary>
    ///   <para>om:APIDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Documentation for API endpoints</para>
    /// labels<para>API Documentation</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/APIDocumentation">https://open-metadata.org/ontology/APIDocumentation</seealso>
    let APIDocumentation = Prefixed_Name(om, "APIDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>om:File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individual file</para>
    /// labels<para>File</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/File">https://open-metadata.org/ontology/File</seealso>
    let File = Prefixed_Name(om, "File") |> PrefixedName
    /// <summary>
    ///   <para>om:LLMModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Registered Large Language Model deployment, fine-tune, or base model referenced by AI applications and agents</para>
    /// labels<para>LLM Model</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/LLMModel">https://open-metadata.org/ontology/LLMModel</seealso>
    let LLMModel = Prefixed_Name(om, "LLMModel") |> PrefixedName
    /// <summary>
    ///   <para>om:LearningResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Learning resource such as an in-product tutorial, Storylane walkthrough, video or article contextualized for product surfaces</para>
    /// labels<para>Learning Resource</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/LearningResource">https://open-metadata.org/ontology/LearningResource</seealso>
    let LearningResource = Prefixed_Name(om, "LearningResource") |> PrefixedName
    /// <summary>
    ///   <para>om:LicenseDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Legal document giving permissions</para>
    /// labels<para>License Document</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/LicenseDocument">https://open-metadata.org/ontology/LicenseDocument</seealso>
    let LicenseDocument = Prefixed_Name(om, "LicenseDocument") |> PrefixedName
    /// <summary>
    ///   <para>om:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial region or location</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Location">https://open-metadata.org/ontology/Location</seealso>
    let Location = Prefixed_Name(om, "Location") |> PrefixedName
    /// <summary>
    ///   <para>om:MCPServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model Context Protocol server deployment that exposes tools, resources and prompts to AI applications</para>
    /// labels<para>MCP Server</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/MCPServer">https://open-metadata.org/ontology/MCPServer</seealso>
    let MCPServer = Prefixed_Name(om, "MCPServer") |> PrefixedName
    /// <summary>
    ///   <para>om:conformsToStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Standard the dataset conforms to</para>
    /// labels<para>conforms to standard</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/conformsToStandard">https://open-metadata.org/ontology/conformsToStandard</seealso>
    let conformsToStandard = Prefixed_Name(om, "conformsToStandard") |> PrefixedName
    /// <summary>
    ///   <para>om:containsPosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contains posts</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/containsPosts">https://open-metadata.org/ontology/containsPosts</seealso>
    let containsPosts = Prefixed_Name(om, "containsPosts") |> PrefixedName
    /// <summary>
    ///   <para>om:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entity responsible for contributions to the dataset</para>
    /// labels<para>contributor</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/contributor">https://open-metadata.org/ontology/contributor</seealso>
    let contributor = Prefixed_Name(om, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>om:hadRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Role in a qualified relationship</para>
    /// labels<para>had role</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hadRole">https://open-metadata.org/ontology/hadRole</seealso>
    let hadRole = Prefixed_Name(om, "hadRole") |> PrefixedName
    /// <summary>
    ///   <para>om:has</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>General possession relationship</para>
    /// labels<para>has</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/has">https://open-metadata.org/ontology/has</seealso>
    let has = Prefixed_Name(om, "has") |> PrefixedName
    /// <summary>
    ///   <para>om:joinedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Join relationship between tables</para>
    /// labels<para>joined with</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/joinedWith">https://open-metadata.org/ontology/joinedWith</seealso>
    let joinedWith = Prefixed_Name(om, "joinedWith") |> PrefixedName
    /// <summary>
    ///   <para>om:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Keywords describing the dataset</para>
    /// labels<para>keyword</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/keyword">https://open-metadata.org/ontology/keyword</seealso>
    let keyword = Prefixed_Name(om, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>om:retentionPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Retention period of the data in ISO 8601 duration format</para>
    /// labels<para>retention period</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/retentionPeriod">https://open-metadata.org/ontology/retentionPeriod</seealso>
    let retentionPeriod = Prefixed_Name(om, "retentionPeriod") |> PrefixedName
    /// <summary>
    ///   <para>om:reviews</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reviews</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/reviews">https://open-metadata.org/ontology/reviews</seealso>
    let reviews = Prefixed_Name(om, "reviews") |> PrefixedName
    /// <summary>
    ///   <para>om:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version identifier</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/version">https://open-metadata.org/ontology/version</seealso>
    let version = Prefixed_Name(om, "version") |> PrefixedName
    /// <summary>
    ///   <para>om:versionNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Notes about this version</para>
    /// labels<para>version notes</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/versionNotes">https://open-metadata.org/ontology/versionNotes</seealso>
    let versionNotes = Prefixed_Name(om, "versionNotes") |> PrefixedName
    /// <summary>
    ///   <para>om:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base class for all OpenMetadata entities</para>
    /// labels<para>Entity</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Entity">https://open-metadata.org/ontology/Entity</seealso>
    let Entity = Prefixed_Name(om, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>om:APIEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>API endpoint providing data access service</para>
    /// labels<para>API Endpoint</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/APIEndpoint">https://open-metadata.org/ontology/APIEndpoint</seealso>
    let APIEndpoint = Prefixed_Name(om, "APIEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>om:OutputPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Output port of a data product for exposing data</para>
    /// labels<para>Output Port</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/OutputPort">https://open-metadata.org/ontology/OutputPort</seealso>
    let OutputPort = Prefixed_Name(om, "OutputPort") |> PrefixedName
    /// <summary>
    ///   <para>om:PipelineService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ETL Service</para>
    /// labels<para>Pipeline Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/PipelineService">https://open-metadata.org/ontology/PipelineService</seealso>
    let PipelineService = Prefixed_Name(om, "PipelineService") |> PrefixedName
    /// <summary>
    ///   <para>om:PromptTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reusable prompt template with variables, system prompts and examples for consistent AI behavior</para>
    /// labels<para>Prompt Template</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/PromptTemplate">https://open-metadata.org/ontology/PromptTemplate</seealso>
    let PromptTemplate = Prefixed_Name(om, "PromptTemplate") |> PrefixedName
    /// <summary>
    ///   <para>om:QualityService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Quality Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/QualityService">https://open-metadata.org/ontology/QualityService</seealso>
    let QualityService = Prefixed_Name(om, "QualityService") |> PrefixedName
    /// <summary>
    ///   <para>om:SearchIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Search Index</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/SearchIndex">https://open-metadata.org/ontology/SearchIndex</seealso>
    let SearchIndex = Prefixed_Name(om, "SearchIndex") |> PrefixedName
    /// <summary>
    ///   <para>om:catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sub-catalog</para>
    /// labels<para>catalog</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/catalog">https://open-metadata.org/ontology/catalog</seealso>
    let catalog = Prefixed_Name(om, "catalog") |> PrefixedName
    /// <summary>
    ///   <para>om:columnCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of columns in the table</para>
    /// labels<para>column count</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/columnCount">https://open-metadata.org/ontology/columnCount</seealso>
    let columnCount = Prefixed_Name(om, "columnCount") |> PrefixedName
    /// <summary>
    ///   <para>om:columnDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data type of the column</para>
    /// labels<para>column data type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/columnDataType">https://open-metadata.org/ontology/columnDataType</seealso>
    let columnDataType = Prefixed_Name(om, "columnDataType") |> PrefixedName
    /// <summary>
    ///   <para>om:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>End of the temporal period</para>
    /// labels<para>end date</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/endDate">https://open-metadata.org/ontology/endDate</seealso>
    let endDate = Prefixed_Name(om, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>om:endpointDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>endpoint description</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/endpointDescription">https://open-metadata.org/ontology/endpointDescription</seealso>
    let endpointDescription = Prefixed_Name(om, "endpointDescription") |> PrefixedName
    /// <summary>
    ///   <para>om:executedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Agent execution was an execution of this AI application</para>
    /// labels<para>executed agent</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/executedAgent">https://open-metadata.org/ontology/executedAgent</seealso>
    let executedAgent = Prefixed_Name(om, "executedAgent") |> PrefixedName
    /// <summary>
    ///   <para>om:executedMCPServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>MCP execution was an execution of this MCP server</para>
    /// labels<para>executed MCP server</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/executedMCPServer">https://open-metadata.org/ontology/executedMCPServer</seealso>
    let executedMCPServer = Prefixed_Name(om, "executedMCPServer") |> PrefixedName
    /// <summary>
    ///   <para>om:isVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the non-versioned or abstract dataset</para>
    /// labels<para>is version of</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/isVersionOf">https://open-metadata.org/ontology/isVersionOf</seealso>
    let isVersionOf = Prefixed_Name(om, "isVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>om:hasVotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Votes on the entity</para>
    /// labels<para>has votes</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasVotes">https://open-metadata.org/ontology/hasVotes</seealso>
    let hasVotes = Prefixed_Name(om, "hasVotes") |> PrefixedName
    /// <summary>
    ///   <para>om:prev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Previous dataset in a series</para>
    /// labels<para>previous</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/prev">https://open-metadata.org/ontology/prev</seealso>
    let prev = Prefixed_Name(om, "prev") |> PrefixedName
    /// <summary>
    ///   <para>om:usesPromptTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uses prompt template</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/usesPromptTemplate">https://open-metadata.org/ontology/usesPromptTemplate</seealso>
    let usesPromptTemplate = Prefixed_Name(om, "usesPromptTemplate") |> PrefixedName
    /// <summary>
    ///   <para>om:validity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Degree to which data conforms to defined rules</para>
    /// labels<para>validity</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/validity">https://open-metadata.org/ontology/validity</seealso>
    let validity = Prefixed_Name(om, "validity") |> PrefixedName
    /// <summary>
    ///   <para>om:voted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>voted</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/voted">https://open-metadata.org/ontology/voted</seealso>
    let voted = Prefixed_Name(om, "voted") |> PrefixedName
    /// <summary>
    ///   <para>om:wasDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Source dataset this was derived from</para>
    /// labels<para>was derived from</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/wasDerivedFrom">https://open-metadata.org/ontology/wasDerivedFrom</seealso>
    let wasDerivedFrom = Prefixed_Name(om, "wasDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>om:wasGeneratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Activity that generated the dataset</para>
    /// labels<para>was generated by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/wasGeneratedBy">https://open-metadata.org/ontology/wasGeneratedBy</seealso>
    let wasGeneratedBy = Prefixed_Name(om, "wasGeneratedBy") |> PrefixedName
    /// <summary>
    ///   <para>om:APICollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection of API endpoints</para>
    /// labels<para>API Collection</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/APICollection">https://open-metadata.org/ontology/APICollection</seealso>
    let APICollection = Prefixed_Name(om, "APICollection") |> PrefixedName
    /// <summary>
    ///   <para>om:APIService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>API Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/APIService">https://open-metadata.org/ontology/APIService</seealso>
    let APIService = Prefixed_Name(om, "APIService") |> PrefixedName
    /// <summary>
    ///   <para>om:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Curated collection of metadata about resources</para>
    /// labels<para>Catalog</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Catalog">https://open-metadata.org/ontology/Catalog</seealso>
    let Catalog = Prefixed_Name(om, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>om:Column</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Column in a table</para>
    /// labels<para>Column</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Column">https://open-metadata.org/ontology/Column</seealso>
    let Column = Prefixed_Name(om, "Column") |> PrefixedName
    /// <summary>
    ///   <para>om:Dashboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dashboard for data visualization</para>
    /// labels<para>Dashboard</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Dashboard">https://open-metadata.org/ontology/Dashboard</seealso>
    let Dashboard = Prefixed_Name(om, "Dashboard") |> PrefixedName
    /// <summary>
    ///   <para>om:DashboardService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dashboard Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DashboardService">https://open-metadata.org/ontology/DashboardService</seealso>
    let DashboardService = Prefixed_Name(om, "DashboardService") |> PrefixedName
    /// <summary>
    ///   <para>om:DataProductSLA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Service Level Agreement for a data product</para>
    /// labels<para>Data Product SLA</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DataProductSLA">https://open-metadata.org/ontology/DataProductSLA</seealso>
    let DataProductSLA = Prefixed_Name(om, "DataProductSLA") |> PrefixedName
    /// <summary>
    ///   <para>om:DatabaseService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Database Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DatabaseService">https://open-metadata.org/ontology/DatabaseService</seealso>
    let DatabaseService = Prefixed_Name(om, "DatabaseService") |> PrefixedName
    /// <summary>
    ///   <para>om:Directory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>File system directory</para>
    /// labels<para>Directory</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Directory">https://open-metadata.org/ontology/Directory</seealso>
    let Directory = Prefixed_Name(om, "Directory") |> PrefixedName
    /// <summary>
    ///   <para>om:EntityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Current status of an entity (Active, Deleted, Draft)</para>
    /// labels<para>Entity Status</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/EntityStatus">https://open-metadata.org/ontology/EntityStatus</seealso>
    let EntityStatus = Prefixed_Name(om, "EntityStatus") |> PrefixedName
    /// <summary>
    ///   <para>om:Glossary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Glossary</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Glossary">https://open-metadata.org/ontology/Glossary</seealso>
    let Glossary = Prefixed_Name(om, "Glossary") |> PrefixedName
    /// <summary>
    ///   <para>om:GlossaryTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Glossary Term</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/GlossaryTerm">https://open-metadata.org/ontology/GlossaryTerm</seealso>
    let GlossaryTerm = Prefixed_Name(om, "GlossaryTerm") |> PrefixedName
    /// <summary>
    ///   <para>om:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>User</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/User">https://open-metadata.org/ontology/User</seealso>
    let User = Prefixed_Name(om, "User") |> PrefixedName
    /// <summary>
    ///   <para>om:accrualPeriodicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Frequency of dataset updates</para>
    /// labels<para>accrual periodicity</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/accrualPeriodicity">https://open-metadata.org/ontology/accrualPeriodicity</seealso>
    let accrualPeriodicity = Prefixed_Name(om, "accrualPeriodicity") |> PrefixedName
    /// <summary>
    ///   <para>om:endpointURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>endpoint URL</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/endpointURL">https://open-metadata.org/ontology/endpointURL</seealso>
    let endpointURL = Prefixed_Name(om, "endpointURL") |> PrefixedName
    /// <summary>
    ///   <para>om:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has tag</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasTag">https://open-metadata.org/ontology/hasTag</seealso>
    let hasTag = Prefixed_Name(om, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>om:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has version</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasVersion">https://open-metadata.org/ontology/hasVersion</seealso>
    let hasVersion = Prefixed_Name(om, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>om:homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Homepage of the catalog</para>
    /// labels<para>homepage</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/homepage">https://open-metadata.org/ontology/homepage</seealso>
    let homepage = Prefixed_Name(om, "homepage") |> PrefixedName
    /// <summary>
    ///   <para>om:pipeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Pipeline that processes the data</para>
    /// labels<para>pipeline</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/pipeline">https://open-metadata.org/ontology/pipeline</seealso>
    let pipeline = Prefixed_Name(om, "pipeline") |> PrefixedName
    /// <summary>
    ///   <para>om:pipelineLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Pipeline code location</para>
    /// labels<para>pipeline location</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/pipelineLocation">https://open-metadata.org/ontology/pipelineLocation</seealso>
    let pipelineLocation = Prefixed_Name(om, "pipelineLocation") |> PrefixedName
    /// <summary>
    ///   <para>om:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Start of the temporal period</para>
    /// labels<para>start date</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/startDate">https://open-metadata.org/ontology/startDate</seealso>
    let startDate = Prefixed_Name(om, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>om:statisticalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Unit of observation in the dataset</para>
    /// labels<para>statistical unit</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/statisticalUnit">https://open-metadata.org/ontology/statisticalUnit</seealso>
    let statisticalUnit = Prefixed_Name(om, "statisticalUnit") |> PrefixedName
    /// <summary>
    ///   <para>om:supportedDataTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data types supported by this test definition</para>
    /// labels<para>supported data types</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/supportedDataTypes">https://open-metadata.org/ontology/supportedDataTypes</seealso>
    let supportedDataTypes = Prefixed_Name(om, "supportedDataTypes") |> PrefixedName
    /// <summary>
    ///   <para>om:tableType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of table (Regular, External, View, MaterializedView, etc.)</para>
    /// labels<para>table type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/tableType">https://open-metadata.org/ontology/tableType</seealso>
    let tableType = Prefixed_Name(om, "tableType") |> PrefixedName
    /// <summary>
    ///   <para>om:templateVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>template variable</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/templateVariable">https://open-metadata.org/ontology/templateVariable</seealso>
    let templateVariable = Prefixed_Name(om, "templateVariable") |> PrefixedName
    /// <summary>
    ///   <para>om:temporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Temporal period covered by the dataset</para>
    /// labels<para>temporal coverage</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/temporal">https://open-metadata.org/ontology/temporal</seealso>
    let temporal = Prefixed_Name(om, "temporal") |> PrefixedName
    /// <summary>
    ///   <para>om:AgentExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Single execution run of an AI agent, tracking inputs, outputs, lineage, metrics and errors for observability and governance</para>
    /// labels<para>Agent Execution</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/AgentExecution">https://open-metadata.org/ontology/AgentExecution</seealso>
    let AgentExecution = Prefixed_Name(om, "AgentExecution") |> PrefixedName
    /// <summary>
    ///   <para>om:Bot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bot</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Bot">https://open-metadata.org/ontology/Bot</seealso>
    let Bot = Prefixed_Name(om, "Bot") |> PrefixedName
    /// <summary>
    ///   <para>om:CatalogRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata about when/how an entity was cataloged</para>
    /// labels<para>Catalog Record</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/CatalogRecord">https://open-metadata.org/ontology/CatalogRecord</seealso>
    let CatalogRecord = Prefixed_Name(om, "CatalogRecord") |> PrefixedName

    /// <summary>
    ///   <para>om:QualifiedRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relationship with additional context like role, time, etc.</para>
    /// labels<para>Qualified Relationship</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/QualifiedRelationship">https://open-metadata.org/ontology/QualifiedRelationship</seealso>
    let QualifiedRelationship =
        Prefixed_Name(om, "QualifiedRelationship") |> PrefixedName

    /// <summary>
    ///   <para>om:RightsStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Statement about intellectual property rights</para>
    /// labels<para>Rights Statement</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/RightsStatement">https://open-metadata.org/ontology/RightsStatement</seealso>
    let RightsStatement = Prefixed_Name(om, "RightsStatement") |> PrefixedName
    /// <summary>
    ///   <para>om:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Role</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Role">https://open-metadata.org/ontology/Role</seealso>
    let Role = Prefixed_Name(om, "Role") |> PrefixedName
    /// <summary>
    ///   <para>om:StorageService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Storage Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/StorageService">https://open-metadata.org/ontology/StorageService</seealso>
    let StorageService = Prefixed_Name(om, "StorageService") |> PrefixedName
    /// <summary>
    ///   <para>om:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Table</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Table">https://open-metadata.org/ontology/Table</seealso>
    let Table = Prefixed_Name(om, "Table") |> PrefixedName
    /// <summary>
    ///   <para>om:Team</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Team</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Team">https://open-metadata.org/ontology/Team</seealso>
    let Team = Prefixed_Name(om, "Team") |> PrefixedName
    /// <summary>
    ///   <para>om:Thread</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Thread</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Thread">https://open-metadata.org/ontology/Thread</seealso>
    let Thread = Prefixed_Name(om, "Thread") |> PrefixedName
    /// <summary>
    ///   <para>om:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Message topic providing streaming data access</para>
    /// labels<para>Topic</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Topic">https://open-metadata.org/ontology/Topic</seealso>
    let Topic = Prefixed_Name(om, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>om:Votes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Votes on an entity (upvotes and downvotes)</para>
    /// labels<para>Votes</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Votes">https://open-metadata.org/ontology/Votes</seealso>
    let Votes = Prefixed_Name(om, "Votes") |> PrefixedName
    /// <summary>
    ///   <para>om:measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Measure represented in the dataset</para>
    /// labels<para>measure</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/measure">https://open-metadata.org/ontology/measure</seealso>
    let measure = Prefixed_Name(om, "measure") |> PrefixedName
    /// <summary>
    ///   <para>om:sqlQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>SQL query used in transformation</para>
    /// labels<para>SQL query</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/sqlQuery">https://open-metadata.org/ontology/sqlQuery</seealso>
    let sqlQuery = Prefixed_Name(om, "sqlQuery") |> PrefixedName

    /// <summary>
    ///   <para>om:supportsDynamicAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether the test case supports dynamic assertions</para>
    /// labels<para>supports dynamic assertion</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/supportsDynamicAssertion">https://open-metadata.org/ontology/supportsDynamicAssertion</seealso>
    let supportsDynamicAssertion =
        Prefixed_Name(om, "supportsDynamicAssertion") |> PrefixedName

    /// <summary>
    ///   <para>om:supportsRowLevelPassedFailed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether the test case supports row level passed/failed</para>
    /// labels<para>supports row level passed failed</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/supportsRowLevelPassedFailed">https://open-metadata.org/ontology/supportsRowLevelPassedFailed</seealso>
    let supportsRowLevelPassedFailed =
        Prefixed_Name(om, "supportsRowLevelPassedFailed") |> PrefixedName

    /// <summary>
    ///   <para>om:AssetCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Certification status of an asset</para>
    /// labels<para>Asset Certification</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/AssetCertification">https://open-metadata.org/ontology/AssetCertification</seealso>
    let AssetCertification = Prefixed_Name(om, "AssetCertification") |> PrefixedName
    /// <summary>
    ///   <para>om:ChangeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Description of changes that led to a version of an entity</para>
    /// labels<para>Change Description</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/ChangeDescription">https://open-metadata.org/ontology/ChangeDescription</seealso>
    let ChangeDescription = Prefixed_Name(om, "ChangeDescription") |> PrefixedName
    /// <summary>
    ///   <para>om:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tag Category</para>
    /// labels<para>Classification</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Classification">https://open-metadata.org/ontology/Classification</seealso>
    let Classification = Prefixed_Name(om, "Classification") |> PrefixedName
    /// <summary>
    ///   <para>om:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Storage container organizing multiple datasets</para>
    /// labels<para>Container</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Container">https://open-metadata.org/ontology/Container</seealso>
    let Container = Prefixed_Name(om, "Container") |> PrefixedName

    /// <summary>
    ///   <para>om:DashboardDataModelColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dashboard data model column context type used to attach custom properties to columns of a DashboardDataModel</para>
    /// labels<para>Dashboard Data Model Column</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DashboardDataModelColumn">https://open-metadata.org/ontology/DashboardDataModelColumn</seealso>
    let DashboardDataModelColumn =
        Prefixed_Name(om, "DashboardDataModelColumn") |> PrefixedName

    /// <summary>
    ///   <para>om:DataProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Data Product</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DataProduct">https://open-metadata.org/ontology/DataProduct</seealso>
    let DataProduct = Prefixed_Name(om, "DataProduct") |> PrefixedName
    /// <summary>
    ///   <para>om:DataService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Service that provides access to data</para>
    /// labels<para>Data Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DataService">https://open-metadata.org/ontology/DataService</seealso>
    let DataService = Prefixed_Name(om, "DataService") |> PrefixedName
    /// <summary>
    ///   <para>om:DatabaseSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Database Schema</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DatabaseSchema">https://open-metadata.org/ontology/DatabaseSchema</seealso>
    let DatabaseSchema = Prefixed_Name(om, "DatabaseSchema") |> PrefixedName
    /// <summary>
    ///   <para>om:DatasetSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection of related datasets, e.g., time series or versions</para>
    /// labels<para>Dataset Series</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DatasetSeries">https://open-metadata.org/ontology/DatasetSeries</seealso>
    let DatasetSeries = Prefixed_Name(om, "DatasetSeries") |> PrefixedName
    /// <summary>
    ///   <para>om:Distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specific representation of a dataset</para>
    /// labels<para>Distribution</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Distribution">https://open-metadata.org/ontology/Distribution</seealso>
    let Distribution = Prefixed_Name(om, "Distribution") |> PrefixedName
    /// <summary>
    ///   <para>om:Domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Domain</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Domain">https://open-metadata.org/ontology/Domain</seealso>
    let Domain = Prefixed_Name(om, "Domain") |> PrefixedName
    /// <summary>
    ///   <para>om:DriveService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>File and document storage service</para>
    /// labels<para>Drive Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DriveService">https://open-metadata.org/ontology/DriveService</seealso>
    let DriveService = Prefixed_Name(om, "DriveService") |> PrefixedName
    /// <summary>
    ///   <para>om:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Update frequency specification</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Frequency">https://open-metadata.org/ontology/Frequency</seealso>
    let Frequency = Prefixed_Name(om, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>om:InputPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Input port of a data product for consuming data</para>
    /// labels<para>Input Port</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/InputPort">https://open-metadata.org/ontology/InputPort</seealso>
    let InputPort = Prefixed_Name(om, "InputPort") |> PrefixedName
    /// <summary>
    ///   <para>om:LLMService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Service managing Large Language Model providers (OpenAI, Anthropic, Bedrock, VertexAI, Ollama, etc.)</para>
    /// labels<para>LLM Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/LLMService">https://open-metadata.org/ontology/LLMService</seealso>
    let LLMService = Prefixed_Name(om, "LLMService") |> PrefixedName
    /// <summary>
    ///   <para>om:LifeCycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Life cycle properties of an entity including created, updated, accessed timestamps</para>
    /// labels<para>Life Cycle</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/LifeCycle">https://open-metadata.org/ontology/LifeCycle</seealso>
    let LifeCycle = Prefixed_Name(om, "LifeCycle") |> PrefixedName
    /// <summary>
    ///   <para>om:MCPExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Single execution session of an MCP server, tracking tool calls, resource accesses, prompt uses and data lineage for audit and compliance</para>
    /// labels<para>MCP Execution</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/MCPExecution">https://open-metadata.org/ontology/MCPExecution</seealso>
    let MCPExecution = Prefixed_Name(om, "MCPExecution") |> PrefixedName
    /// <summary>
    ///   <para>om:MLModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Machine learning model providing inference service</para>
    /// labels<para>ML Model</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/MLModel">https://open-metadata.org/ontology/MLModel</seealso>
    let MLModel = Prefixed_Name(om, "MLModel") |> PrefixedName
    /// <summary>
    ///   <para>om:MLModelService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ML Model Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/MLModelService">https://open-metadata.org/ontology/MLModelService</seealso>
    let MLModelService = Prefixed_Name(om, "MLModelService") |> PrefixedName
    /// <summary>
    ///   <para>om:MediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Media type or format</para>
    /// labels<para>Media Type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/MediaType">https://open-metadata.org/ontology/MediaType</seealso>
    let MediaType = Prefixed_Name(om, "MediaType") |> PrefixedName
    /// <summary>
    ///   <para>om:MetadataService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Metadata Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/MetadataService">https://open-metadata.org/ontology/MetadataService</seealso>
    let MetadataService = Prefixed_Name(om, "MetadataService") |> PrefixedName
    /// <summary>
    ///   <para>om:Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Metric</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Metric">https://open-metadata.org/ontology/Metric</seealso>
    let Metric = Prefixed_Name(om, "Metric") |> PrefixedName
    /// <summary>
    ///   <para>om:ObservabilityService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Observability Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/ObservabilityService">https://open-metadata.org/ontology/ObservabilityService</seealso>
    let ObservabilityService = Prefixed_Name(om, "ObservabilityService") |> PrefixedName
    /// <summary>
    ///   <para>om:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Organization entity</para>
    /// labels<para>Organization</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Organization">https://open-metadata.org/ontology/Organization</seealso>
    let Organization = Prefixed_Name(om, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>om:PeriodOfTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Time period specification</para>
    /// labels<para>Period of Time</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/PeriodOfTime">https://open-metadata.org/ontology/PeriodOfTime</seealso>
    let PeriodOfTime = Prefixed_Name(om, "PeriodOfTime") |> PrefixedName
    /// <summary>
    ///   <para>om:Pipeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pipeline</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Pipeline">https://open-metadata.org/ontology/Pipeline</seealso>
    let Pipeline = Prefixed_Name(om, "Pipeline") |> PrefixedName
    /// <summary>
    ///   <para>om:PipelineStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Status of a pipeline execution</para>
    /// labels<para>Pipeline Status</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/PipelineStatus">https://open-metadata.org/ontology/PipelineStatus</seealso>
    let PipelineStatus = Prefixed_Name(om, "PipelineStatus") |> PrefixedName
    /// <summary>
    ///   <para>om:Post</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Post</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Post">https://open-metadata.org/ontology/Post</seealso>
    let Post = Prefixed_Name(om, "Post") |> PrefixedName
    /// <summary>
    ///   <para>om:ProfilerConfig</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Configuration for table profiling</para>
    /// labels<para>Profiler Config</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/ProfilerConfig">https://open-metadata.org/ontology/ProfilerConfig</seealso>
    let ProfilerConfig = Prefixed_Name(om, "ProfilerConfig") |> PrefixedName
    /// <summary>
    ///   <para>om:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Query</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Query">https://open-metadata.org/ontology/Query</seealso>
    let Query = Prefixed_Name(om, "Query") |> PrefixedName
    /// <summary>
    ///   <para>om:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Report as a specific representation of data</para>
    /// labels<para>Report</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Report">https://open-metadata.org/ontology/Report</seealso>
    let Report = Prefixed_Name(om, "Report") |> PrefixedName
    /// <summary>
    ///   <para>om:ReportingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reporting Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/ReportingService">https://open-metadata.org/ontology/ReportingService</seealso>
    let ReportingService = Prefixed_Name(om, "ReportingService") |> PrefixedName
    /// <summary>
    ///   <para>om:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any resource cataloged in OpenMetadata</para>
    /// labels<para>Resource</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Resource">https://open-metadata.org/ontology/Resource</seealso>
    let Resource = Prefixed_Name(om, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>om:SearchService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Search Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/SearchService">https://open-metadata.org/ontology/SearchService</seealso>
    let SearchService = Prefixed_Name(om, "SearchService") |> PrefixedName
    /// <summary>
    ///   <para>om:Spreadsheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spreadsheet document</para>
    /// labels<para>Spreadsheet</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Spreadsheet">https://open-metadata.org/ontology/Spreadsheet</seealso>
    let Spreadsheet = Prefixed_Name(om, "Spreadsheet") |> PrefixedName
    /// <summary>
    ///   <para>om:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Technical standard or specification</para>
    /// labels<para>Standard</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Standard">https://open-metadata.org/ontology/Standard</seealso>
    let Standard = Prefixed_Name(om, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>om:TableColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Table column context type used to attach custom properties to columns of a Table</para>
    /// labels<para>Table Column</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/TableColumn">https://open-metadata.org/ontology/TableColumn</seealso>
    let TableColumn = Prefixed_Name(om, "TableColumn") |> PrefixedName
    /// <summary>
    ///   <para>om:TableProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Profile data for a table including statistics</para>
    /// labels<para>Table Profile</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/TableProfile">https://open-metadata.org/ontology/TableProfile</seealso>
    let TableProfile = Prefixed_Name(om, "TableProfile") |> PrefixedName
    /// <summary>
    ///   <para>om:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tag</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Tag">https://open-metadata.org/ontology/Tag</seealso>
    let Tag = Prefixed_Name(om, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>om:TestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Test Case</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/TestCase">https://open-metadata.org/ontology/TestCase</seealso>
    let TestCase = Prefixed_Name(om, "TestCase") |> PrefixedName
    /// <summary>
    ///   <para>om:TestCaseParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Parameter definition for a test case</para>
    /// labels<para>Test Case Parameter</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/TestCaseParameter">https://open-metadata.org/ontology/TestCaseParameter</seealso>
    let TestCaseParameter = Prefixed_Name(om, "TestCaseParameter") |> PrefixedName
    /// <summary>
    ///   <para>om:TestDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Test Definition</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/TestDefinition">https://open-metadata.org/ontology/TestDefinition</seealso>
    let TestDefinition = Prefixed_Name(om, "TestDefinition") |> PrefixedName
    /// <summary>
    ///   <para>om:TestSuite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Test Suite</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/TestSuite">https://open-metadata.org/ontology/TestSuite</seealso>
    let TestSuite = Prefixed_Name(om, "TestSuite") |> PrefixedName
    /// <summary>
    ///   <para>om:Worksheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Worksheet within a spreadsheet</para>
    /// labels<para>Worksheet</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Worksheet">https://open-metadata.org/ontology/Worksheet</seealso>
    let Worksheet = Prefixed_Name(om, "Worksheet") |> PrefixedName
    /// <summary>
    ///   <para>om:accessRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information about access restrictions</para>
    /// labels<para>access rights</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/accessRights">https://open-metadata.org/ontology/accessRights</seealso>
    let accessRights = Prefixed_Name(om, "accessRights") |> PrefixedName
    /// <summary>
    ///   <para>om:accessURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>URL to access the distribution</para>
    /// labels<para>access URL</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/accessURL">https://open-metadata.org/ontology/accessURL</seealso>
    let accessURL = Prefixed_Name(om, "accessURL") |> PrefixedName
    /// <summary>
    ///   <para>om:accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Degree of data accuracy</para>
    /// labels<para>accuracy</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/accuracy">https://open-metadata.org/ontology/accuracy</seealso>
    let accuracy = Prefixed_Name(om, "accuracy") |> PrefixedName
    /// <summary>
    ///   <para>om:addressedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>addressed to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/addressedTo">https://open-metadata.org/ontology/addressedTo</seealso>
    let addressedTo = Prefixed_Name(om, "addressedTo") |> PrefixedName
    /// <summary>
    ///   <para>om:apiDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link to API documentation</para>
    /// labels<para>API documentation</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/apiDocumentation">https://open-metadata.org/ontology/apiDocumentation</seealso>
    let apiDocumentation = Prefixed_Name(om, "apiDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>om:applicationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of AI application (Chatbot, Agent, Copilot, Assistant, RAG, CodeGenerator, DataAnalyst, AutomationBot, MultiAgent, Custom)</para>
    /// labels<para>application type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/applicationType">https://open-metadata.org/ontology/applicationType</seealso>
    let applicationType = Prefixed_Name(om, "applicationType") |> PrefixedName
    /// <summary>
    ///   <para>om:appliedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Tag or classification applied to entity</para>
    /// labels<para>applied to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/appliedTo">https://open-metadata.org/ontology/appliedTo</seealso>
    let appliedTo = Prefixed_Name(om, "appliedTo") |> PrefixedName
    /// <summary>
    ///   <para>om:belongsToDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>belongs to database</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/belongsToDatabase">https://open-metadata.org/ontology/belongsToDatabase</seealso>
    let belongsToDatabase = Prefixed_Name(om, "belongsToDatabase") |> PrefixedName
    /// <summary>
    ///   <para>om:belongsToSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>belongs to schema</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/belongsToSchema">https://open-metadata.org/ontology/belongsToSchema</seealso>
    let belongsToSchema = Prefixed_Name(om, "belongsToSchema") |> PrefixedName
    /// <summary>
    ///   <para>om:belongsToService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>belongs to service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/belongsToService">https://open-metadata.org/ontology/belongsToService</seealso>
    let belongsToService = Prefixed_Name(om, "belongsToService") |> PrefixedName
    /// <summary>
    ///   <para>om:byteSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Size in bytes</para>
    /// labels<para>byte size</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/byteSize">https://open-metadata.org/ontology/byteSize</seealso>
    let byteSize = Prefixed_Name(om, "byteSize") |> PrefixedName
    /// <summary>
    ///   <para>om:cataloged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when entity was added to catalog</para>
    /// labels<para>cataloged</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/cataloged">https://open-metadata.org/ontology/cataloged</seealso>
    let cataloged = Prefixed_Name(om, "cataloged") |> PrefixedName
    /// <summary>
    ///   <para>om:centroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Geographic center point</para>
    /// labels<para>centroid</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/centroid">https://open-metadata.org/ontology/centroid</seealso>
    let centroid = Prefixed_Name(om, "centroid") |> PrefixedName

    /// <summary>
    ///   <para>om:certificationTagLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Tag label for the certification</para>
    /// labels<para>certification tag label</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/certificationTagLabel">https://open-metadata.org/ontology/certificationTagLabel</seealso>
    let certificationTagLabel =
        Prefixed_Name(om, "certificationTagLabel") |> PrefixedName

    /// <summary>
    ///   <para>om:checksum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Checksum for data integrity verification</para>
    /// labels<para>checksum</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/checksum">https://open-metadata.org/ontology/checksum</seealso>
    let checksum = Prefixed_Name(om, "checksum") |> PrefixedName
    /// <summary>
    ///   <para>om:columnDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Description of what the column contains</para>
    /// labels<para>column description</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/columnDescription">https://open-metadata.org/ontology/columnDescription</seealso>
    let columnDescription = Prefixed_Name(om, "columnDescription") |> PrefixedName
    /// <summary>
    ///   <para>om:completeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Degree of data completeness</para>
    /// labels<para>completeness</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/completeness">https://open-metadata.org/ontology/completeness</seealso>
    let completeness = Prefixed_Name(om, "completeness") |> PrefixedName
    /// <summary>
    ///   <para>om:compressFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Compression format of the distribution</para>
    /// labels<para>compression format</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/compressFormat">https://open-metadata.org/ontology/compressFormat</seealso>
    let compressFormat = Prefixed_Name(om, "compressFormat") |> PrefixedName
    /// <summary>
    ///   <para>om:concurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Concurrency level of the pipeline</para>
    /// labels<para>concurrency</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/concurrency">https://open-metadata.org/ontology/concurrency</seealso>
    let concurrency = Prefixed_Name(om, "concurrency") |> PrefixedName
    /// <summary>
    ///   <para>om:conformsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Standard or schema that the resource conforms to</para>
    /// labels<para>conforms to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/conformsTo">https://open-metadata.org/ontology/conformsTo</seealso>
    let conformsTo = Prefixed_Name(om, "conformsTo") |> PrefixedName
    /// <summary>
    ///   <para>om:consistency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Degree of data consistency</para>
    /// labels<para>consistency</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/consistency">https://open-metadata.org/ontology/consistency</seealso>
    let consistency = Prefixed_Name(om, "consistency") |> PrefixedName
    /// <summary>
    ///   <para>om:consumesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data products that this product consumes data from</para>
    /// labels<para>consumes from</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/consumesFrom">https://open-metadata.org/ontology/consumesFrom</seealso>
    let consumesFrom = Prefixed_Name(om, "consumesFrom") |> PrefixedName
    /// <summary>
    ///   <para>om:contactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Contact information for the dataset</para>
    /// labels<para>contact point</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/contactPoint">https://open-metadata.org/ontology/contactPoint</seealso>
    let contactPoint = Prefixed_Name(om, "contactPoint") |> PrefixedName
    /// <summary>
    ///   <para>om:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Hierarchical containment relationship</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/contains">https://open-metadata.org/ontology/contains</seealso>
    let contains = Prefixed_Name(om, "contains") |> PrefixedName
    /// <summary>
    ///   <para>om:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>created</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/created">https://open-metadata.org/ontology/created</seealso>
    let created = Prefixed_Name(om, "created") |> PrefixedName
    /// <summary>
    ///   <para>om:createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>created by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/createdBy">https://open-metadata.org/ontology/createdBy</seealso>
    let createdBy = Prefixed_Name(om, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>om:creates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>creates</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/creates">https://open-metadata.org/ontology/creates</seealso>
    let creates = Prefixed_Name(om, "creates") |> PrefixedName
    /// <summary>
    ///   <para>om:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entity primarily responsible for creating the dataset</para>
    /// labels<para>creator</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/creator">https://open-metadata.org/ontology/creator</seealso>
    let creator = Prefixed_Name(om, "creator") |> PrefixedName
    /// <summary>
    ///   <para>om:dataModelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of data model (TableauDataModel, SupersetDataModel, MetabaseDataModel, LookMlView, LookMlExplore, PowerBIDataModel, QlikDataModel)</para>
    /// labels<para>data model type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/dataModelType">https://open-metadata.org/ontology/dataModelType</seealso>
    let dataModelType = Prefixed_Name(om, "dataModelType") |> PrefixedName
    /// <summary>
    ///   <para>om:dataProductDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Domain this data product belongs to</para>
    /// labels<para>data product domain</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/dataProductDomain">https://open-metadata.org/ontology/dataProductDomain</seealso>
    let dataProductDomain = Prefixed_Name(om, "dataProductDomain") |> PrefixedName
    /// <summary>
    ///   <para>om:dataProductExpert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Expert for this data product</para>
    /// labels<para>data product expert</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/dataProductExpert">https://open-metadata.org/ontology/dataProductExpert</seealso>
    let dataProductExpert = Prefixed_Name(om, "dataProductExpert") |> PrefixedName
    /// <summary>
    ///   <para>om:dataProductOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Owner of the data product</para>
    /// labels<para>data product owner</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/dataProductOwner">https://open-metadata.org/ontology/dataProductOwner</seealso>
    let dataProductOwner = Prefixed_Name(om, "dataProductOwner") |> PrefixedName
    /// <summary>
    ///   <para>om:dataQualityDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data quality dimension (Completeness, Accuracy, Consistency, Validity, Uniqueness, Integrity, SQL)</para>
    /// labels<para>data quality dimension</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/dataQualityDimension">https://open-metadata.org/ontology/dataQualityDimension</seealso>
    let dataQualityDimension = Prefixed_Name(om, "dataQualityDimension") |> PrefixedName
    /// <summary>
    ///   <para>om:dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Dataset that is part of the catalog</para>
    /// labels<para>dataset</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/dataset">https://open-metadata.org/ontology/dataset</seealso>
    let dataset = Prefixed_Name(om, "dataset") |> PrefixedName
    /// <summary>
    ///   <para>om:defaultsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Default value relationship</para>
    /// labels<para>defaults to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/defaultsTo">https://open-metadata.org/ontology/defaultsTo</seealso>
    let defaultsTo = Prefixed_Name(om, "defaultsTo") |> PrefixedName
    /// <summary>
    ///   <para>om:deleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether the entity has been soft deleted</para>
    /// labels<para>deleted</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/deleted">https://open-metadata.org/ontology/deleted</seealso>
    let deleted = Prefixed_Name(om, "deleted") |> PrefixedName
    /// <summary>
    ///   <para>om:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>description</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/description">https://open-metadata.org/ontology/description</seealso>
    let description = Prefixed_Name(om, "description") |> PrefixedName
    /// <summary>
    ///   <para>om:developmentStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>development stage</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/developmentStage">https://open-metadata.org/ontology/developmentStage</seealso>
    let developmentStage = Prefixed_Name(om, "developmentStage") |> PrefixedName
    /// <summary>
    ///   <para>om:dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Dimension represented in the dataset</para>
    /// labels<para>dimension</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/dimension">https://open-metadata.org/ontology/dimension</seealso>
    let dimension = Prefixed_Name(om, "dimension") |> PrefixedName
    /// <summary>
    ///   <para>om:distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Available distribution of the dataset</para>
    /// labels<para>distribution</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/distribution">https://open-metadata.org/ontology/distribution</seealso>
    let distribution = Prefixed_Name(om, "distribution") |> PrefixedName
    /// <summary>
    ///   <para>om:downVotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of down votes</para>
    /// labels<para>down votes</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/downVotes">https://open-metadata.org/ontology/downVotes</seealso>
    let downVotes = Prefixed_Name(om, "downVotes") |> PrefixedName
    /// <summary>
    ///   <para>om:downloadURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Direct download URL</para>
    /// labels<para>download URL</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/downloadURL">https://open-metadata.org/ontology/downloadURL</seealso>
    let downloadURL = Prefixed_Name(om, "downloadURL") |> PrefixedName
    /// <summary>
    ///   <para>om:downstream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data lineage downstream relationship</para>
    /// labels<para>downstream</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/downstream">https://open-metadata.org/ontology/downstream</seealso>
    let downstream = Prefixed_Name(om, "downstream") |> PrefixedName
    /// <summary>
    ///   <para>om:upstream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data lineage upstream relationship</para>
    /// labels<para>upstream</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/upstream">https://open-metadata.org/ontology/upstream</seealso>
    let upstream = Prefixed_Name(om, "upstream") |> PrefixedName
    /// <summary>
    ///   <para>om:editedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>edited by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/editedBy">https://open-metadata.org/ontology/editedBy</seealso>
    let editedBy = Prefixed_Name(om, "editedBy") |> PrefixedName
    /// <summary>
    ///   <para>om:executionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Status of an agent or MCP execution (Running, Success, Failed, Timeout, Cancelled, PartialSuccess)</para>
    /// labels<para>execution status</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/executionStatus">https://open-metadata.org/ontology/executionStatus</seealso>
    let executionStatus = Prefixed_Name(om, "executionStatus") |> PrefixedName
    /// <summary>
    ///   <para>om:expert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>User is expert on entity</para>
    /// labels<para>expert</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/expert">https://open-metadata.org/ontology/expert</seealso>
    let expert = Prefixed_Name(om, "expert") |> PrefixedName
    /// <summary>
    ///   <para>om:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>First dataset in a series</para>
    /// labels<para>first</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/first">https://open-metadata.org/ontology/first</seealso>
    let first = Prefixed_Name(om, "first") |> PrefixedName
    /// <summary>
    ///   <para>om:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>follows</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/follows">https://open-metadata.org/ontology/follows</seealso>
    let follows = Prefixed_Name(om, "follows") |> PrefixedName
    /// <summary>
    ///   <para>om:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>File format of the distribution</para>
    /// labels<para>format</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/format">https://open-metadata.org/ontology/format</seealso>
    let format = Prefixed_Name(om, "format") |> PrefixedName
    /// <summary>
    ///   <para>om:fromColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Source column used in transformation</para>
    /// labels<para>from column</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/fromColumn">https://open-metadata.org/ontology/fromColumn</seealso>
    let fromColumn = Prefixed_Name(om, "fromColumn") |> PrefixedName
    /// <summary>
    ///   <para>om:fullyQualifiedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique identifier for the entity within OpenMetadata</para>
    /// labels<para>fully qualified name</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/fullyQualifiedName">https://open-metadata.org/ontology/fullyQualifiedName</seealso>
    let fullyQualifiedName = Prefixed_Name(om, "fullyQualifiedName") |> PrefixedName
    /// <summary>
    ///   <para>om:geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Geometry of the spatial area</para>
    /// labels<para>geometry</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/geometry">https://open-metadata.org/ontology/geometry</seealso>
    let geometry = Prefixed_Name(om, "geometry") |> PrefixedName
    /// <summary>
    ///   <para>om:governedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>AI application, LLM model or MCP server is governed by an AI governance policy</para>
    /// labels<para>governed by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/governedBy">https://open-metadata.org/ontology/governedBy</seealso>
    let governedBy = Prefixed_Name(om, "governedBy") |> PrefixedName
    /// <summary>
    ///   <para>om:hasCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Certification status of the asset</para>
    /// labels<para>has certification</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasCertification">https://open-metadata.org/ontology/hasCertification</seealso>
    let hasCertification = Prefixed_Name(om, "hasCertification") |> PrefixedName
    /// <summary>
    ///   <para>om:hasChangeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Change that led to this version of the entity</para>
    /// labels<para>has change description</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasChangeDescription">https://open-metadata.org/ontology/hasChangeDescription</seealso>
    let hasChangeDescription = Prefixed_Name(om, "hasChangeDescription") |> PrefixedName
    /// <summary>
    ///   <para>om:hasColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has column</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasColumn">https://open-metadata.org/ontology/hasColumn</seealso>
    let hasColumn = Prefixed_Name(om, "hasColumn") |> PrefixedName
    /// <summary>
    ///   <para>om:hasDataProducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data products this entity is part of</para>
    /// labels<para>has data products</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasDataProducts">https://open-metadata.org/ontology/hasDataProducts</seealso>
    let hasDataProducts = Prefixed_Name(om, "hasDataProducts") |> PrefixedName
    /// <summary>
    ///   <para>om:hasDomains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Domains the entity belongs to</para>
    /// labels<para>has domains</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasDomains">https://open-metadata.org/ontology/hasDomains</seealso>
    let hasDomains = Prefixed_Name(om, "hasDomains") |> PrefixedName
    /// <summary>
    ///   <para>om:hasEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ending instant of the temporal period</para>
    /// labels<para>has end</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasEnd">https://open-metadata.org/ontology/hasEnd</seealso>
    let hasEnd = Prefixed_Name(om, "hasEnd") |> PrefixedName
    /// <summary>
    ///   <para>om:hasEntityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Current status of the entity</para>
    /// labels<para>has entity status</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasEntityStatus">https://open-metadata.org/ontology/hasEntityStatus</seealso>
    let hasEntityStatus = Prefixed_Name(om, "hasEntityStatus") |> PrefixedName
    /// <summary>
    ///   <para>om:hasFollowers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Users who follow this entity</para>
    /// labels<para>has followers</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasFollowers">https://open-metadata.org/ontology/hasFollowers</seealso>
    let hasFollowers = Prefixed_Name(om, "hasFollowers") |> PrefixedName

    /// <summary>
    ///   <para>om:hasIncrementalChangeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Incremental change that led to this version</para>
    /// labels<para>has incremental change description</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasIncrementalChangeDescription">https://open-metadata.org/ontology/hasIncrementalChangeDescription</seealso>
    let hasIncrementalChangeDescription =
        Prefixed_Name(om, "hasIncrementalChangeDescription") |> PrefixedName

    /// <summary>
    ///   <para>om:hasInputPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Input port of the data product</para>
    /// labels<para>has input port</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasInputPort">https://open-metadata.org/ontology/hasInputPort</seealso>
    let hasInputPort = Prefixed_Name(om, "hasInputPort") |> PrefixedName
    /// <summary>
    ///   <para>om:hasOwners</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Owners of this entity (plural)</para>
    /// labels<para>has owners</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasOwners">https://open-metadata.org/ontology/hasOwners</seealso>
    let hasOwners = Prefixed_Name(om, "hasOwners") |> PrefixedName

    /// <summary>
    ///   <para>om:hasParameterDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Parameter definitions for a test</para>
    /// labels<para>has parameter definition</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasParameterDefinition">https://open-metadata.org/ontology/hasParameterDefinition</seealso>
    let hasParameterDefinition =
        Prefixed_Name(om, "hasParameterDefinition") |> PrefixedName

    /// <summary>
    ///   <para>om:hasPipelineStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Latest status of the pipeline</para>
    /// labels<para>has pipeline status</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasPipelineStatus">https://open-metadata.org/ontology/hasPipelineStatus</seealso>
    let hasPipelineStatus = Prefixed_Name(om, "hasPipelineStatus") |> PrefixedName
    /// <summary>
    ///   <para>om:hasPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ODRL policy associated with the dataset</para>
    /// labels<para>has policy</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasPolicy">https://open-metadata.org/ontology/hasPolicy</seealso>
    let hasPolicy = Prefixed_Name(om, "hasPolicy") |> PrefixedName
    /// <summary>
    ///   <para>om:hasProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Latest profile data for the table</para>
    /// labels<para>has profile</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasProfile">https://open-metadata.org/ontology/hasProfile</seealso>
    let hasProfile = Prefixed_Name(om, "hasProfile") |> PrefixedName
    /// <summary>
    ///   <para>om:hasProfilerConfig</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Profiler configuration for the table</para>
    /// labels<para>has profiler config</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasProfilerConfig">https://open-metadata.org/ontology/hasProfilerConfig</seealso>
    let hasProfilerConfig = Prefixed_Name(om, "hasProfilerConfig") |> PrefixedName
    /// <summary>
    ///   <para>om:hasQualityAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Quality annotation for the dataset</para>
    /// labels<para>has quality annotation</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasQualityAnnotation">https://open-metadata.org/ontology/hasQualityAnnotation</seealso>
    let hasQualityAnnotation = Prefixed_Name(om, "hasQualityAnnotation") |> PrefixedName

    /// <summary>
    ///   <para>om:hasQualityMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Quality measurement for the dataset</para>
    /// labels<para>has quality measurement</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasQualityMeasurement">https://open-metadata.org/ontology/hasQualityMeasurement</seealso>
    let hasQualityMeasurement =
        Prefixed_Name(om, "hasQualityMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>om:hasSLA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Service Level Agreement for the data product</para>
    /// labels<para>has SLA</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasSLA">https://open-metadata.org/ontology/hasSLA</seealso>
    let hasSLA = Prefixed_Name(om, "hasSLA") |> PrefixedName
    /// <summary>
    ///   <para>om:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique identifier of the dataset</para>
    /// labels<para>identifier</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/identifier">https://open-metadata.org/ontology/identifier</seealso>
    let identifier = Prefixed_Name(om, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>om:impersonatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Bot user that performed the action on behalf of the actual user</para>
    /// labels<para>impersonated by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/impersonatedBy">https://open-metadata.org/ontology/impersonatedBy</seealso>
    let impersonatedBy = Prefixed_Name(om, "impersonatedBy") |> PrefixedName
    /// <summary>
    ///   <para>om:inSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a dataset to its series</para>
    /// labels<para>in series</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/inSeries">https://open-metadata.org/ontology/inSeries</seealso>
    let inSeries = Prefixed_Name(om, "inSeries") |> PrefixedName
    /// <summary>
    ///   <para>om:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Thread or post is about an entity</para>
    /// labels<para>is about</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/isAbout">https://open-metadata.org/ontology/isAbout</seealso>
    let isAbout = Prefixed_Name(om, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>om:isNullable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether this column can contain null values</para>
    /// labels<para>is nullable</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/isNullable">https://open-metadata.org/ontology/isNullable</seealso>
    let isNullable = Prefixed_Name(om, "isNullable") |> PrefixedName
    /// <summary>
    ///   <para>om:isPrimaryKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether this column is a primary key</para>
    /// labels<para>is primary key</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/isPrimaryKey">https://open-metadata.org/ontology/isPrimaryKey</seealso>
    let isPrimaryKey = Prefixed_Name(om, "isPrimaryKey") |> PrefixedName
    /// <summary>
    ///   <para>om:isReferencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Related resource that references this dataset</para>
    /// labels<para>is referenced by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/isReferencedBy">https://open-metadata.org/ontology/isReferencedBy</seealso>
    let isReferencedBy = Prefixed_Name(om, "isReferencedBy") |> PrefixedName
    /// <summary>
    ///   <para>om:issued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date of formal issuance</para>
    /// labels<para>issued</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/issued">https://open-metadata.org/ontology/issued</seealso>
    let issued = Prefixed_Name(om, "issued") |> PrefixedName
    /// <summary>
    ///   <para>om:landingPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Web page providing access and information</para>
    /// labels<para>landing page</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/landingPage">https://open-metadata.org/ontology/landingPage</seealso>
    let landingPage = Prefixed_Name(om, "landingPage") |> PrefixedName
    /// <summary>
    ///   <para>om:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Language of the dataset</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/language">https://open-metadata.org/ontology/language</seealso>
    let language = Prefixed_Name(om, "language") |> PrefixedName
    /// <summary>
    ///   <para>om:last</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Last dataset in a series</para>
    /// labels<para>last</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/last">https://open-metadata.org/ontology/last</seealso>
    let last = Prefixed_Name(om, "last") |> PrefixedName
    /// <summary>
    ///   <para>om:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>License under which the dataset is available</para>
    /// labels<para>license</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/license">https://open-metadata.org/ontology/license</seealso>
    let license = Prefixed_Name(om, "license") |> PrefixedName
    /// <summary>
    ///   <para>om:lifeCycleAccessed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Access details when entity was last accessed</para>
    /// labels<para>life cycle accessed</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/lifeCycleAccessed">https://open-metadata.org/ontology/lifeCycleAccessed</seealso>
    let lifeCycleAccessed = Prefixed_Name(om, "lifeCycleAccessed") |> PrefixedName
    /// <summary>
    ///   <para>om:lifeCycleCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Access details when entity was created</para>
    /// labels<para>life cycle created</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/lifeCycleCreated">https://open-metadata.org/ontology/lifeCycleCreated</seealso>
    let lifeCycleCreated = Prefixed_Name(om, "lifeCycleCreated") |> PrefixedName
    /// <summary>
    ///   <para>om:lifeCycleUpdated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Access details when entity was last updated</para>
    /// labels<para>life cycle updated</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/lifeCycleUpdated">https://open-metadata.org/ontology/lifeCycleUpdated</seealso>
    let lifeCycleUpdated = Prefixed_Name(om, "lifeCycleUpdated") |> PrefixedName
    /// <summary>
    ///   <para>om:lifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Current lifecycle stage (IDEATION, DESIGN, DEVELOPMENT, TESTING, PRODUCTION, DEPRECATED, RETIRED)</para>
    /// labels<para>lifecycle stage</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/lifecycleStage">https://open-metadata.org/ontology/lifecycleStage</seealso>
    let lifecycleStage = Prefixed_Name(om, "lifecycleStage") |> PrefixedName
    /// <summary>
    ///   <para>om:lineageCreatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>When the lineage was created</para>
    /// labels<para>lineage created at</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/lineageCreatedAt">https://open-metadata.org/ontology/lineageCreatedAt</seealso>
    let lineageCreatedAt = Prefixed_Name(om, "lineageCreatedAt") |> PrefixedName
    /// <summary>
    ///   <para>om:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Media type of the distribution</para>
    /// labels<para>media type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/mediaType">https://open-metadata.org/ontology/mediaType</seealso>
    let mediaType = Prefixed_Name(om, "mediaType") |> PrefixedName
    /// <summary>
    ///   <para>om:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>member of</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/memberOf">https://open-metadata.org/ontology/memberOf</seealso>
    let memberOf = Prefixed_Name(om, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>om:mentionedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entity is mentioned in a post or thread</para>
    /// labels<para>mentioned in</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/mentionedIn">https://open-metadata.org/ontology/mentionedIn</seealso>
    let mentionedIn = Prefixed_Name(om, "mentionedIn") |> PrefixedName
    /// <summary>
    ///   <para>om:modelCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Capability exposed by the LLM model (TextGeneration, CodeGeneration, Embeddings, Chat, Vision, Audio, FunctionCalling, ToolUse)</para>
    /// labels<para>model capability</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/modelCapability">https://open-metadata.org/ontology/modelCapability</seealso>
    let modelCapability = Prefixed_Name(om, "modelCapability") |> PrefixedName
    /// <summary>
    ///   <para>om:modelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of LLM model (BaseModel, FineTuned, Quantized, Distilled, Adapter, Custom)</para>
    /// labels<para>model type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/modelType">https://open-metadata.org/ontology/modelType</seealso>
    let modelType = Prefixed_Name(om, "modelType") |> PrefixedName
    /// <summary>
    ///   <para>om:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>modified</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/modified">https://open-metadata.org/ontology/modified</seealso>
    let modified = Prefixed_Name(om, "modified") |> PrefixedName
    /// <summary>
    ///   <para>om:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Next dataset in a series</para>
    /// labels<para>next</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/next">https://open-metadata.org/ontology/next</seealso>
    let next = Prefixed_Name(om, "next") |> PrefixedName
    /// <summary>
    ///   <para>om:numberOfColumns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of columns in the dataset</para>
    /// labels<para>number of columns</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/numberOfColumns">https://open-metadata.org/ontology/numberOfColumns</seealso>
    let numberOfColumns = Prefixed_Name(om, "numberOfColumns") |> PrefixedName
    /// <summary>
    ///   <para>om:numberOfRecords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of records in the dataset</para>
    /// labels<para>number of records</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/numberOfRecords">https://open-metadata.org/ontology/numberOfRecords</seealso>
    let numberOfRecords = Prefixed_Name(om, "numberOfRecords") |> PrefixedName
    /// <summary>
    ///   <para>om:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>owns</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/owns">https://open-metadata.org/ontology/owns</seealso>
    let owns = Prefixed_Name(om, "owns") |> PrefixedName
    /// <summary>
    ///   <para>om:packageFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Package format of the distribution</para>
    /// labels<para>package format</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/packageFormat">https://open-metadata.org/ontology/packageFormat</seealso>
    let packageFormat = Prefixed_Name(om, "packageFormat") |> PrefixedName
    /// <summary>
    ///   <para>om:portEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Endpoint URL or connection string for the port</para>
    /// labels<para>port endpoint</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/portEndpoint">https://open-metadata.org/ontology/portEndpoint</seealso>
    let portEndpoint = Prefixed_Name(om, "portEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>om:portFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data format supported by the port (JSON, CSV, PARQUET, etc.)</para>
    /// labels<para>port format</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/portFormat">https://open-metadata.org/ontology/portFormat</seealso>
    let portFormat = Prefixed_Name(om, "portFormat") |> PrefixedName
    /// <summary>
    ///   <para>om:portName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the port</para>
    /// labels<para>port name</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/portName">https://open-metadata.org/ontology/portName</seealso>
    let portName = Prefixed_Name(om, "portName") |> PrefixedName
    /// <summary>
    ///   <para>om:portProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Protocol used by the port (REST, GRPC, KAFKA, etc.)</para>
    /// labels<para>port protocol</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/portProtocol">https://open-metadata.org/ontology/portProtocol</seealso>
    let portProtocol = Prefixed_Name(om, "portProtocol") |> PrefixedName
    /// <summary>
    ///   <para>om:previousVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link to previous version</para>
    /// labels<para>previous version</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/previousVersion">https://open-metadata.org/ontology/previousVersion</seealso>
    let previousVersion = Prefixed_Name(om, "previousVersion") |> PrefixedName
    /// <summary>
    ///   <para>om:primaryTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Main entity described by this record</para>
    /// labels<para>primary topic</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/primaryTopic">https://open-metadata.org/ontology/primaryTopic</seealso>
    let primaryTopic = Prefixed_Name(om, "primaryTopic") |> PrefixedName
    /// <summary>
    ///   <para>om:processedLineage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Whether lineage has been processed for this entity</para>
    /// labels<para>processed lineage</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/processedLineage">https://open-metadata.org/ontology/processedLineage</seealso>
    let processedLineage = Prefixed_Name(om, "processedLineage") |> PrefixedName
    /// <summary>
    ///   <para>om:provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provenance statement</para>
    /// labels<para>provenance</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/provenance">https://open-metadata.org/ontology/provenance</seealso>
    let provenance = Prefixed_Name(om, "provenance") |> PrefixedName
    /// <summary>
    ///   <para>om:providesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data products that consume data from this product</para>
    /// labels<para>provides to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/providesTo">https://open-metadata.org/ontology/providesTo</seealso>
    let providesTo = Prefixed_Name(om, "providesTo") |> PrefixedName
    /// <summary>
    ///   <para>om:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Entity responsible for making the dataset available</para>
    /// labels<para>publisher</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/publisher">https://open-metadata.org/ontology/publisher</seealso>
    let publisher = Prefixed_Name(om, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>om:qualifiedAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Qualified access information including authentication and authorization</para>
    /// labels<para>qualified access</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/qualifiedAccess">https://open-metadata.org/ontology/qualifiedAccess</seealso>
    let qualifiedAccess = Prefixed_Name(om, "qualifiedAccess") |> PrefixedName
    /// <summary>
    ///   <para>om:qualifiedAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Detailed attribution with roles</para>
    /// labels<para>qualified attribution</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/qualifiedAttribution">https://open-metadata.org/ontology/qualifiedAttribution</seealso>
    let qualifiedAttribution = Prefixed_Name(om, "qualifiedAttribution") |> PrefixedName
    /// <summary>
    ///   <para>om:qualifiedDerivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Detailed derivation with transformation info</para>
    /// labels<para>qualified derivation</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/qualifiedDerivation">https://open-metadata.org/ontology/qualifiedDerivation</seealso>
    let qualifiedDerivation = Prefixed_Name(om, "qualifiedDerivation") |> PrefixedName
    /// <summary>
    ///   <para>om:qualifiedRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link to a qualified relationship</para>
    /// labels<para>qualified relation</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/qualifiedRelation">https://open-metadata.org/ontology/qualifiedRelation</seealso>
    let qualifiedRelation = Prefixed_Name(om, "qualifiedRelation") |> PrefixedName
    /// <summary>
    ///   <para>om:reactedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reacted to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/reactedTo">https://open-metadata.org/ontology/reactedTo</seealso>
    let reactedTo = Prefixed_Name(om, "reactedTo") |> PrefixedName
    /// <summary>
    ///   <para>om:record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links catalog to its records</para>
    /// labels<para>record</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/record">https://open-metadata.org/ontology/record</seealso>
    let record = Prefixed_Name(om, "record") |> PrefixedName
    /// <summary>
    ///   <para>om:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>General relationship between entities</para>
    /// labels<para>related to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/relatedTo">https://open-metadata.org/ontology/relatedTo</seealso>
    let relatedTo = Prefixed_Name(om, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>om:relatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Alternative spelling of relatedTo</para>
    /// labels<para>relates to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/relatesTo">https://open-metadata.org/ontology/relatesTo</seealso>
    let relatesTo = Prefixed_Name(om, "relatesTo") |> PrefixedName
    /// <summary>
    ///   <para>om:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Related resource</para>
    /// labels<para>relation</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/relation">https://open-metadata.org/ontology/relation</seealso>
    let relation = Prefixed_Name(om, "relation") |> PrefixedName
    /// <summary>
    ///   <para>om:repliedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>replied to</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/repliedTo">https://open-metadata.org/ontology/repliedTo</seealso>
    let repliedTo = Prefixed_Name(om, "repliedTo") |> PrefixedName
    /// <summary>
    ///   <para>om:resourceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Primary topic grouping (Discovery, Administration, DataGovernance, DataQuality, Observability, AI)</para>
    /// labels<para>learning resource category</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/resourceCategory">https://open-metadata.org/ontology/resourceCategory</seealso>
    let resourceCategory = Prefixed_Name(om, "resourceCategory") |> PrefixedName
    /// <summary>
    ///   <para>om:scheduleInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Scheduler interval in cron format</para>
    /// labels<para>schedule interval</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/scheduleInterval">https://open-metadata.org/ontology/scheduleInterval</seealso>
    let scheduleInterval = Prefixed_Name(om, "scheduleInterval") |> PrefixedName
    /// <summary>
    ///   <para>om:schemaDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>DDL schema definition for the table</para>
    /// labels<para>schema definition</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/schemaDefinition">https://open-metadata.org/ontology/schemaDefinition</seealso>
    let schemaDefinition = Prefixed_Name(om, "schemaDefinition") |> PrefixedName
    /// <summary>
    ///   <para>om:serverType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of MCP server (DataAccess, FileSystem, WebAPI, Database, Cloud, Security, Development, Communication, Custom)</para>
    /// labels<para>MCP server type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/serverType">https://open-metadata.org/ontology/serverType</seealso>
    let serverType = Prefixed_Name(om, "serverType") |> PrefixedName
    /// <summary>
    ///   <para>om:servesDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a data service to datasets it serves</para>
    /// labels<para>serves dataset</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/servesDataset">https://open-metadata.org/ontology/servesDataset</seealso>
    let servesDataset = Prefixed_Name(om, "servesDataset") |> PrefixedName
    /// <summary>
    ///   <para>om:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Service that is part of the catalog</para>
    /// labels<para>service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/service">https://open-metadata.org/ontology/service</seealso>
    let service = Prefixed_Name(om, "service") |> PrefixedName
    /// <summary>
    ///   <para>om:serviceEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Endpoint for accessing the service</para>
    /// labels<para>service endpoint</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/serviceEndpoint">https://open-metadata.org/ontology/serviceEndpoint</seealso>
    let serviceEndpoint = Prefixed_Name(om, "serviceEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>om:serviceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Service level agreement details</para>
    /// labels<para>service level</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/serviceLevel">https://open-metadata.org/ontology/serviceLevel</seealso>
    let serviceLevel = Prefixed_Name(om, "serviceLevel") |> PrefixedName
    /// <summary>
    ///   <para>om:serviceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Operational status of the service</para>
    /// labels<para>service status</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/serviceStatus">https://open-metadata.org/ontology/serviceStatus</seealso>
    let serviceStatus = Prefixed_Name(om, "serviceStatus") |> PrefixedName
    /// <summary>
    ///   <para>om:serviceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>service type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/serviceType">https://open-metadata.org/ontology/serviceType</seealso>
    let serviceType = Prefixed_Name(om, "serviceType") |> PrefixedName
    /// <summary>
    ///   <para>om:slaAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Expected availability percentage</para>
    /// labels<para>SLA availability</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/slaAvailability">https://open-metadata.org/ontology/slaAvailability</seealso>
    let slaAvailability = Prefixed_Name(om, "slaAvailability") |> PrefixedName
    /// <summary>
    ///   <para>om:slaDataFreshness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Maximum data staleness in minutes</para>
    /// labels<para>SLA data freshness</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/slaDataFreshness">https://open-metadata.org/ontology/slaDataFreshness</seealso>
    let slaDataFreshness = Prefixed_Name(om, "slaDataFreshness") |> PrefixedName
    /// <summary>
    ///   <para>om:slaDataQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Minimum data quality score</para>
    /// labels<para>SLA data quality</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/slaDataQuality">https://open-metadata.org/ontology/slaDataQuality</seealso>
    let slaDataQuality = Prefixed_Name(om, "slaDataQuality") |> PrefixedName
    /// <summary>
    ///   <para>om:slaResponseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Expected response time in milliseconds</para>
    /// labels<para>SLA response time</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/slaResponseTime">https://open-metadata.org/ontology/slaResponseTime</seealso>
    let slaResponseTime = Prefixed_Name(om, "slaResponseTime") |> PrefixedName
    /// <summary>
    ///   <para>om:slaTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>SLA tier level (GOLD, SILVER, BRONZE)</para>
    /// labels<para>SLA tier</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/slaTier">https://open-metadata.org/ontology/slaTier</seealso>
    let slaTier = Prefixed_Name(om, "slaTier") |> PrefixedName
    /// <summary>
    ///   <para>om:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Source of the dataset</para>
    /// labels<para>source</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/source">https://open-metadata.org/ontology/source</seealso>
    let source = Prefixed_Name(om, "source") |> PrefixedName
    /// <summary>
    ///   <para>om:sourceHash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Source hash of the entity for change detection</para>
    /// labels<para>source hash</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/sourceHash">https://open-metadata.org/ontology/sourceHash</seealso>
    let sourceHash = Prefixed_Name(om, "sourceHash") |> PrefixedName
    /// <summary>
    ///   <para>om:sourceUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URL to visit/manage the entity in the source system</para>
    /// labels<para>source URL</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/sourceUrl">https://open-metadata.org/ontology/sourceUrl</seealso>
    let sourceUrl = Prefixed_Name(om, "sourceUrl") |> PrefixedName
    /// <summary>
    ///   <para>om:spatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Spatial area covered by the dataset</para>
    /// labels<para>spatial coverage</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/spatial">https://open-metadata.org/ontology/spatial</seealso>
    let spatial = Prefixed_Name(om, "spatial") |> PrefixedName
    /// <summary>
    ///   <para>om:spatialResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Minimum spatial separation resolvable in the dataset</para>
    /// labels<para>spatial resolution</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/spatialResolution">https://open-metadata.org/ontology/spatialResolution</seealso>
    let spatialResolution = Prefixed_Name(om, "spatialResolution") |> PrefixedName
    /// <summary>
    ///   <para>om:temporalResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Minimum time period resolvable in the dataset</para>
    /// labels<para>temporal resolution</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/temporalResolution">https://open-metadata.org/ontology/temporalResolution</seealso>
    let temporalResolution = Prefixed_Name(om, "temporalResolution") |> PrefixedName
    /// <summary>
    ///   <para>om:testPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Platform where tests are defined (OpenMetadata, GreatExpectations, dbt, Deequ, Soda, Other)</para>
    /// labels<para>test platform</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/testPlatform">https://open-metadata.org/ontology/testPlatform</seealso>
    let testPlatform = Prefixed_Name(om, "testPlatform") |> PrefixedName
    /// <summary>
    ///   <para>om:testedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>tested by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/testedBy">https://open-metadata.org/ontology/testedBy</seealso>
    let testedBy = Prefixed_Name(om, "testedBy") |> PrefixedName
    /// <summary>
    ///   <para>om:theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Main category of the dataset</para>
    /// labels<para>theme</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/theme">https://open-metadata.org/ontology/theme</seealso>
    let theme = Prefixed_Name(om, "theme") |> PrefixedName
    /// <summary>
    ///   <para>om:themeTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Knowledge organization system for categorizing datasets</para>
    /// labels<para>theme taxonomy</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/themeTaxonomy">https://open-metadata.org/ontology/themeTaxonomy</seealso>
    let themeTaxonomy = Prefixed_Name(om, "themeTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>om:timeliness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>How current the data is</para>
    /// labels<para>timeliness</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/timeliness">https://open-metadata.org/ontology/timeliness</seealso>
    let timeliness = Prefixed_Name(om, "timeliness") |> PrefixedName
    /// <summary>
    ///   <para>om:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Title of the dataset</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/title">https://open-metadata.org/ontology/title</seealso>
    let title = Prefixed_Name(om, "title") |> PrefixedName
    /// <summary>
    ///   <para>om:toColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Target column created by transformation</para>
    /// labels<para>to column</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/toColumn">https://open-metadata.org/ontology/toColumn</seealso>
    let toColumn = Prefixed_Name(om, "toColumn") |> PrefixedName

    /// <summary>
    ///   <para>om:transformationFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Function applied to transform data</para>
    /// labels<para>transformation function</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/transformationFunction">https://open-metadata.org/ontology/transformationFunction</seealso>
    let transformationFunction =
        Prefixed_Name(om, "transformationFunction") |> PrefixedName

    /// <summary>
    ///   <para>om:transportType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Transport protocol used by the MCP server</para>
    /// labels<para>MCP transport type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/transportType">https://open-metadata.org/ontology/transportType</seealso>
    let transportType = Prefixed_Name(om, "transportType") |> PrefixedName
    /// <summary>
    ///   <para>om:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Nature or genre of the dataset</para>
    /// labels<para>type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/type">https://open-metadata.org/ontology/type</seealso>
    let type_ = Prefixed_Name(om, "type") |> PrefixedName
    /// <summary>
    ///   <para>om:uniqueness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Degree of uniqueness in the data</para>
    /// labels<para>uniqueness</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/uniqueness">https://open-metadata.org/ontology/uniqueness</seealso>
    let uniqueness = Prefixed_Name(om, "uniqueness") |> PrefixedName
    /// <summary>
    ///   <para>om:upVotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of up votes</para>
    /// labels<para>up votes</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/upVotes">https://open-metadata.org/ontology/upVotes</seealso>
    let upVotes = Prefixed_Name(om, "upVotes") |> PrefixedName
    /// <summary>
    ///   <para>om:updatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Last update time in Unix epoch milliseconds</para>
    /// labels<para>updated at</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/updatedAt">https://open-metadata.org/ontology/updatedAt</seealso>
    let updatedAt = Prefixed_Name(om, "updatedAt") |> PrefixedName
    /// <summary>
    ///   <para>om:updatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>User who made the update</para>
    /// labels<para>updated by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/updatedBy">https://open-metadata.org/ontology/updatedBy</seealso>
    let updatedBy = Prefixed_Name(om, "updatedBy") |> PrefixedName
    /// <summary>
    ///   <para>om:usageSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Latest usage information for the entity</para>
    /// labels<para>usage summary</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/usageSummary">https://open-metadata.org/ontology/usageSummary</seealso>
    let usageSummary = Prefixed_Name(om, "usageSummary") |> PrefixedName
    /// <summary>
    ///   <para>om:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uses</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/uses">https://open-metadata.org/ontology/uses</seealso>
    let uses = Prefixed_Name(om, "uses") |> PrefixedName
    /// <summary>
    ///   <para>om:usesMCPServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>AI application uses an MCP server for tools, resources or prompts</para>
    /// labels<para>uses MCP server</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/usesMCPServer">https://open-metadata.org/ontology/usesMCPServer</seealso>
    let usesMCPServer = Prefixed_Name(om, "usesMCPServer") |> PrefixedName
    /// <summary>
    ///   <para>om:usesModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>AI application or agent execution uses an LLM model</para>
    /// labels<para>uses model</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/usesModel">https://open-metadata.org/ontology/usesModel</seealso>
    let usesModel = Prefixed_Name(om, "usesModel") |> PrefixedName
    /// <summary>
    ///   <para>om:Chart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Chart</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Chart">https://open-metadata.org/ontology/Chart</seealso>
    let Chart = Prefixed_Name(om, "Chart") |> PrefixedName
    /// <summary>
    ///   <para>om:dataProductAssets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Assets that are part of this data product</para>
    /// labels<para>data product assets</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/dataProductAssets">https://open-metadata.org/ontology/dataProductAssets</seealso>
    let dataProductAssets = Prefixed_Name(om, "dataProductAssets") |> PrefixedName
    /// <summary>
    ///   <para>om:hasLifeCycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Life cycle properties of the entity</para>
    /// labels<para>has life cycle</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasLifeCycle">https://open-metadata.org/ontology/hasLifeCycle</seealso>
    let hasLifeCycle = Prefixed_Name(om, "hasLifeCycle") |> PrefixedName
    /// <summary>
    ///   <para>om:lineageCreatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>User who created the lineage</para>
    /// labels<para>lineage created by</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/lineageCreatedBy">https://open-metadata.org/ontology/lineageCreatedBy</seealso>
    let lineageCreatedBy = Prefixed_Name(om, "lineageCreatedBy") |> PrefixedName
    /// <summary>
    ///   <para>om:lineageSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>How the lineage was created (Manual, Pipeline, Query, etc.)</para>
    /// labels<para>lineage source</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/lineageSource">https://open-metadata.org/ontology/lineageSource</seealso>
    let lineageSource = Prefixed_Name(om, "lineageSource") |> PrefixedName
    /// <summary>
    ///   <para>om:DashboardDataModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dashboard Data Model entity to capture the data models used by dashboards</para>
    /// labels<para>Dashboard Data Model</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DashboardDataModel">https://open-metadata.org/ontology/DashboardDataModel</seealso>
    let DashboardDataModel = Prefixed_Name(om, "DashboardDataModel") |> PrefixedName
    /// <summary>
    ///   <para>om:DataContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Data Contract</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DataContract">https://open-metadata.org/ontology/DataContract</seealso>
    let DataContract = Prefixed_Name(om, "DataContract") |> PrefixedName
    /// <summary>
    ///   <para>om:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Database</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Database">https://open-metadata.org/ontology/Database</seealso>
    let Database = Prefixed_Name(om, "Database") |> PrefixedName
    /// <summary>
    ///   <para>om:StoredProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Stored Procedure</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/StoredProcedure">https://open-metadata.org/ontology/StoredProcedure</seealso>
    let StoredProcedure = Prefixed_Name(om, "StoredProcedure") |> PrefixedName
    /// <summary>
    ///   <para>om:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Task</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Task">https://open-metadata.org/ontology/Task</seealso>
    let Task = Prefixed_Name(om, "Task") |> PrefixedName
    /// <summary>
    ///   <para>om:hasOutputPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Output port of the data product</para>
    /// labels<para>has output port</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasOutputPort">https://open-metadata.org/ontology/hasOutputPort</seealso>
    let hasOutputPort = Prefixed_Name(om, "hasOutputPort") |> PrefixedName
    /// <summary>
    ///   <para>om:hasOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Agent responsible for the entity</para>
    /// labels<para>has owner</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasOwner">https://open-metadata.org/ontology/hasOwner</seealso>
    let hasOwner = Prefixed_Name(om, "hasOwner") |> PrefixedName
    /// <summary>
    ///   <para>om:parentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Hierarchical parent relationship</para>
    /// labels<para>parent of</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/parentOf">https://open-metadata.org/ontology/parentOf</seealso>
    let parentOf = Prefixed_Name(om, "parentOf") |> PrefixedName
    /// <summary>
    ///   <para>om:policyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of AI governance policy (ModelApproval, DataAccess, BiasThreshold, ComplianceCheck, CostControl, PerformanceStandard, SecurityControl)</para>
    /// labels<para>policy type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/policyType">https://open-metadata.org/ontology/policyType</seealso>
    let policyType = Prefixed_Name(om, "policyType") |> PrefixedName
    /// <summary>
    ///   <para>om:portDataAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data asset exposed through this port</para>
    /// labels<para>port data asset</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/portDataAsset">https://open-metadata.org/ontology/portDataAsset</seealso>
    let portDataAsset = Prefixed_Name(om, "portDataAsset") |> PrefixedName
    /// <summary>
    ///   <para>om:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://open-metadata.org/ontology/">https://open-metadata.org/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(om, "") |> PrefixedName
    /// <summary>
    ///   <para>om:DataAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base class for all data assets</para>
    /// labels<para>Data Asset</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/DataAsset">https://open-metadata.org/ontology/DataAsset</seealso>
    let DataAsset = Prefixed_Name(om, "DataAsset") |> PrefixedName
    /// <summary>
    ///   <para>om:Policy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Policy</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Policy">https://open-metadata.org/ontology/Policy</seealso>
    let Policy = Prefixed_Name(om, "Policy") |> PrefixedName
    /// <summary>
    ///   <para>om:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base class for all services</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/Service">https://open-metadata.org/ontology/Service</seealso>
    let Service = Prefixed_Name(om, "Service") |> PrefixedName
    /// <summary>
    ///   <para>om:MCPService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Service for discovering and managing MCP (Model Context Protocol) servers</para>
    /// labels<para>MCP Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/MCPService">https://open-metadata.org/ontology/MCPService</seealso>
    let MCPService = Prefixed_Name(om, "MCPService") |> PrefixedName
    /// <summary>
    ///   <para>om:MessagingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Messaging Service</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/MessagingService">https://open-metadata.org/ontology/MessagingService</seealso>
    let MessagingService = Prefixed_Name(om, "MessagingService") |> PrefixedName
    /// <summary>
    ///   <para>om:baseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Base model this model was trained or fine-tuned from</para>
    /// labels<para>base model</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/baseModel">https://open-metadata.org/ontology/baseModel</seealso>
    let baseModel = Prefixed_Name(om, "baseModel") |> PrefixedName
    /// <summary>
    ///   <para>om:bbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Geographic bounding box</para>
    /// labels<para>bounding box</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/bbox">https://open-metadata.org/ontology/bbox</seealso>
    let bbox = Prefixed_Name(om, "bbox") |> PrefixedName
    /// <summary>
    ///   <para>om:hasBeginning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Beginning instant of the temporal period</para>
    /// labels<para>has beginning</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/hasBeginning">https://open-metadata.org/ontology/hasBeginning</seealso>
    let hasBeginning = Prefixed_Name(om, "hasBeginning") |> PrefixedName
    /// <summary>
    ///   <para>om:resourceDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Suggested proficiency tier (Intro, Intermediate, Advanced)</para>
    /// labels<para>learning resource difficulty</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/resourceDifficulty">https://open-metadata.org/ontology/resourceDifficulty</seealso>
    let resourceDifficulty = Prefixed_Name(om, "resourceDifficulty") |> PrefixedName
    /// <summary>
    ///   <para>om:resourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Kind of learning asset (Storylane, Video, Article)</para>
    /// labels<para>learning resource type</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/resourceType">https://open-metadata.org/ontology/resourceType</seealso>
    let resourceType = Prefixed_Name(om, "resourceType") |> PrefixedName
    /// <summary>
    ///   <para>om:rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Rights statement for the dataset</para>
    /// labels<para>rights</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/rights">https://open-metadata.org/ontology/rights</seealso>
    let rights = Prefixed_Name(om, "rights") |> PrefixedName
    /// <summary>
    ///   <para>om:rowCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of rows in the table</para>
    /// labels<para>row count</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/rowCount">https://open-metadata.org/ontology/rowCount</seealso>
    let rowCount = Prefixed_Name(om, "rowCount") |> PrefixedName
    /// <summary>
    ///   <para>om:sampleData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Sample data from the table</para>
    /// labels<para>sample data</para></remarks>
    /// <seealso href="https://open-metadata.org/ontology/sampleData">https://open-metadata.org/ontology/sampleData</seealso>
    let sampleData = Prefixed_Name(om, "sampleData") |> PrefixedName
