namespace https.open_metadata.org.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module om =
    let _namespace_name = "https://open-metadata.org/ontology/"

    /// <summary>
    /// AI system such as a chatbot, agent, copilot, RAG application or multi-agent pipeline that may use multiple LLM models and tools
    /// <see href="https://open-metadata.org/ontology/AIApplication"></see></summary>
    let AIApplication =
        Namespaced_IRI.parse _namespace_name "AIApplication" |> NamespacedName

    /// <summary>
    /// Base class for all data assets
    /// <see href="https://open-metadata.org/ontology/DataAsset"></see></summary>
    let DataAsset = Namespaced_IRI.parse _namespace_name "DataAsset" |> NamespacedName

    /// <summary>
    /// Policy rules for AI/LLM usage, compliance, and risk management (model approval, data access, bias thresholds, cost controls, etc.)
    /// <see href="https://open-metadata.org/ontology/AIGovernancePolicy"></see></summary>
    let AIGovernancePolicy =
        Namespaced_IRI.parse _namespace_name "AIGovernancePolicy" |> NamespacedName

    /// <summary>
    /// Base class for all OpenMetadata entities
    /// <see href="https://open-metadata.org/ontology/Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Policy"></see>
    /// </summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    /// Collection of API endpoints
    /// <see href="https://open-metadata.org/ontology/APICollection"></see></summary>
    let APICollection =
        Namespaced_IRI.parse _namespace_name "APICollection" |> NamespacedName

    /// <summary>
    /// Documentation for API endpoints
    /// <see href="https://open-metadata.org/ontology/APIDocumentation"></see></summary>
    let APIDocumentation =
        Namespaced_IRI.parse _namespace_name "APIDocumentation" |> NamespacedName

    /// <summary>
    /// API endpoint providing data access service
    /// <see href="https://open-metadata.org/ontology/APIEndpoint"></see></summary>
    let APIEndpoint =
        Namespaced_IRI.parse _namespace_name "APIEndpoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/APIService"></see>
    /// </summary>
    let APIService = Namespaced_IRI.parse _namespace_name "APIService" |> NamespacedName
    /// <summary>
    /// Base class for all services
    /// <see href="https://open-metadata.org/ontology/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// Single execution run of an AI agent, tracking inputs, outputs, lineage, metrics and errors for observability and governance
    /// <see href="https://open-metadata.org/ontology/AgentExecution"></see></summary>
    let AgentExecution =
        Namespaced_IRI.parse _namespace_name "AgentExecution" |> NamespacedName

    /// <summary>
    /// Certification status of an asset
    /// <see href="https://open-metadata.org/ontology/AssetCertification"></see></summary>
    let AssetCertification =
        Namespaced_IRI.parse _namespace_name "AssetCertification" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Bot"></see>
    /// </summary>
    let Bot = Namespaced_IRI.parse _namespace_name "Bot" |> NamespacedName
    /// <summary>
    /// Curated collection of metadata about resources
    /// <see href="https://open-metadata.org/ontology/Catalog"></see></summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName

    /// <summary>
    /// Metadata about when/how an entity was cataloged
    /// <see href="https://open-metadata.org/ontology/CatalogRecord"></see></summary>
    let CatalogRecord =
        Namespaced_IRI.parse _namespace_name "CatalogRecord" |> NamespacedName

    /// <summary>
    /// Description of changes that led to a version of an entity
    /// <see href="https://open-metadata.org/ontology/ChangeDescription"></see></summary>
    let ChangeDescription =
        Namespaced_IRI.parse _namespace_name "ChangeDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Chart"></see>
    /// </summary>
    let Chart = Namespaced_IRI.parse _namespace_name "Chart" |> NamespacedName

    /// <summary>
    /// Tag Category
    /// <see href="https://open-metadata.org/ontology/Classification"></see></summary>
    let Classification =
        Namespaced_IRI.parse _namespace_name "Classification" |> NamespacedName

    /// <summary>
    /// Column in a table
    /// <see href="https://open-metadata.org/ontology/Column"></see></summary>
    let Column = Namespaced_IRI.parse _namespace_name "Column" |> NamespacedName
    /// <summary>
    /// Storage container organizing multiple datasets
    /// <see href="https://open-metadata.org/ontology/Container"></see></summary>
    let Container = Namespaced_IRI.parse _namespace_name "Container" |> NamespacedName
    /// <summary>
    /// Dashboard for data visualization
    /// <see href="https://open-metadata.org/ontology/Dashboard"></see></summary>
    let Dashboard = Namespaced_IRI.parse _namespace_name "Dashboard" |> NamespacedName

    /// <summary>
    /// Dashboard Data Model entity to capture the data models used by dashboards
    /// <see href="https://open-metadata.org/ontology/DashboardDataModel"></see></summary>
    let DashboardDataModel =
        Namespaced_IRI.parse _namespace_name "DashboardDataModel" |> NamespacedName

    /// <summary>
    /// Dashboard data model column context type used to attach custom properties to columns of a DashboardDataModel
    /// <see href="https://open-metadata.org/ontology/DashboardDataModelColumn"></see></summary>
    let DashboardDataModelColumn =
        Namespaced_IRI.parse _namespace_name "DashboardDataModelColumn" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DashboardService"></see>
    /// </summary>
    let DashboardService =
        Namespaced_IRI.parse _namespace_name "DashboardService" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DataContract"></see>
    /// </summary>
    let DataContract =
        Namespaced_IRI.parse _namespace_name "DataContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DataProduct"></see>
    /// </summary>
    let DataProduct =
        Namespaced_IRI.parse _namespace_name "DataProduct" |> NamespacedName

    /// <summary>
    /// Service Level Agreement for a data product
    /// <see href="https://open-metadata.org/ontology/DataProductSLA"></see></summary>
    let DataProductSLA =
        Namespaced_IRI.parse _namespace_name "DataProductSLA" |> NamespacedName

    /// <summary>
    /// Service that provides access to data
    /// <see href="https://open-metadata.org/ontology/DataService"></see></summary>
    let DataService =
        Namespaced_IRI.parse _namespace_name "DataService" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Database"></see>
    /// </summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DatabaseSchema"></see>
    /// </summary>
    let DatabaseSchema =
        Namespaced_IRI.parse _namespace_name "DatabaseSchema" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DatabaseService"></see>
    /// </summary>
    let DatabaseService =
        Namespaced_IRI.parse _namespace_name "DatabaseService" |> NamespacedName

    /// <summary>
    /// Collection of related datasets, e.g., time series or versions
    /// <see href="https://open-metadata.org/ontology/DatasetSeries"></see></summary>
    let DatasetSeries =
        Namespaced_IRI.parse _namespace_name "DatasetSeries" |> NamespacedName

    /// <summary>
    /// File system directory
    /// <see href="https://open-metadata.org/ontology/Directory"></see></summary>
    let Directory = Namespaced_IRI.parse _namespace_name "Directory" |> NamespacedName

    /// <summary>
    /// Specific representation of a dataset
    /// <see href="https://open-metadata.org/ontology/Distribution"></see></summary>
    let Distribution =
        Namespaced_IRI.parse _namespace_name "Distribution" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Domain"></see>
    /// </summary>
    let Domain = Namespaced_IRI.parse _namespace_name "Domain" |> NamespacedName

    /// <summary>
    /// File and document storage service
    /// <see href="https://open-metadata.org/ontology/DriveService"></see></summary>
    let DriveService =
        Namespaced_IRI.parse _namespace_name "DriveService" |> NamespacedName

    /// <summary>
    /// Current status of an entity (Active, Deleted, Draft)
    /// <see href="https://open-metadata.org/ontology/EntityStatus"></see></summary>
    let EntityStatus =
        Namespaced_IRI.parse _namespace_name "EntityStatus" |> NamespacedName

    /// <summary>
    /// Individual file
    /// <see href="https://open-metadata.org/ontology/File"></see></summary>
    let File = Namespaced_IRI.parse _namespace_name "File" |> NamespacedName
    /// <summary>
    /// Update frequency specification
    /// <see href="https://open-metadata.org/ontology/Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Glossary"></see>
    /// </summary>
    let Glossary = Namespaced_IRI.parse _namespace_name "Glossary" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/GlossaryTerm"></see>
    /// </summary>
    let GlossaryTerm =
        Namespaced_IRI.parse _namespace_name "GlossaryTerm" |> NamespacedName

    /// <summary>
    /// Input port of a data product for consuming data
    /// <see href="https://open-metadata.org/ontology/InputPort"></see></summary>
    let InputPort = Namespaced_IRI.parse _namespace_name "InputPort" |> NamespacedName
    /// <summary>
    /// Registered Large Language Model deployment, fine-tune, or base model referenced by AI applications and agents
    /// <see href="https://open-metadata.org/ontology/LLMModel"></see></summary>
    let LLMModel = Namespaced_IRI.parse _namespace_name "LLMModel" |> NamespacedName
    /// <summary>
    /// Service managing Large Language Model providers (OpenAI, Anthropic, Bedrock, VertexAI, Ollama, etc.)
    /// <see href="https://open-metadata.org/ontology/LLMService"></see></summary>
    let LLMService = Namespaced_IRI.parse _namespace_name "LLMService" |> NamespacedName

    /// <summary>
    /// Learning resource such as an in-product tutorial, Storylane walkthrough, video or article contextualized for product surfaces
    /// <see href="https://open-metadata.org/ontology/LearningResource"></see></summary>
    let LearningResource =
        Namespaced_IRI.parse _namespace_name "LearningResource" |> NamespacedName

    /// <summary>
    /// Legal document giving permissions
    /// <see href="https://open-metadata.org/ontology/LicenseDocument"></see></summary>
    let LicenseDocument =
        Namespaced_IRI.parse _namespace_name "LicenseDocument" |> NamespacedName

    /// <summary>
    /// Life cycle properties of an entity including created, updated, accessed timestamps
    /// <see href="https://open-metadata.org/ontology/LifeCycle"></see></summary>
    let LifeCycle = Namespaced_IRI.parse _namespace_name "LifeCycle" |> NamespacedName
    /// <summary>
    /// Spatial region or location
    /// <see href="https://open-metadata.org/ontology/Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// Single execution session of an MCP server, tracking tool calls, resource accesses, prompt uses and data lineage for audit and compliance
    /// <see href="https://open-metadata.org/ontology/MCPExecution"></see></summary>
    let MCPExecution =
        Namespaced_IRI.parse _namespace_name "MCPExecution" |> NamespacedName

    /// <summary>
    /// Model Context Protocol server deployment that exposes tools, resources and prompts to AI applications
    /// <see href="https://open-metadata.org/ontology/MCPServer"></see></summary>
    let MCPServer = Namespaced_IRI.parse _namespace_name "MCPServer" |> NamespacedName
    /// <summary>
    /// Service for discovering and managing MCP (Model Context Protocol) servers
    /// <see href="https://open-metadata.org/ontology/MCPService"></see></summary>
    let MCPService = Namespaced_IRI.parse _namespace_name "MCPService" |> NamespacedName
    /// <summary>
    /// Machine learning model providing inference service
    /// <see href="https://open-metadata.org/ontology/MLModel"></see></summary>
    let MLModel = Namespaced_IRI.parse _namespace_name "MLModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/MLModelService"></see>
    /// </summary>
    let MLModelService =
        Namespaced_IRI.parse _namespace_name "MLModelService" |> NamespacedName

    /// <summary>
    /// Media type or format
    /// <see href="https://open-metadata.org/ontology/MediaType"></see></summary>
    let MediaType = Namespaced_IRI.parse _namespace_name "MediaType" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/MessagingService"></see>
    /// </summary>
    let MessagingService =
        Namespaced_IRI.parse _namespace_name "MessagingService" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/MetadataService"></see>
    /// </summary>
    let MetadataService =
        Namespaced_IRI.parse _namespace_name "MetadataService" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Metric"></see>
    /// </summary>
    let Metric = Namespaced_IRI.parse _namespace_name "Metric" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/ObservabilityService"></see>
    /// </summary>
    let ObservabilityService =
        Namespaced_IRI.parse _namespace_name "ObservabilityService" |> NamespacedName

    /// <summary>
    /// Organization entity
    /// <see href="https://open-metadata.org/ontology/Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// Output port of a data product for exposing data
    /// <see href="https://open-metadata.org/ontology/OutputPort"></see></summary>
    let OutputPort = Namespaced_IRI.parse _namespace_name "OutputPort" |> NamespacedName

    /// <summary>
    /// Time period specification
    /// <see href="https://open-metadata.org/ontology/PeriodOfTime"></see></summary>
    let PeriodOfTime =
        Namespaced_IRI.parse _namespace_name "PeriodOfTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Pipeline"></see>
    /// </summary>
    let Pipeline = Namespaced_IRI.parse _namespace_name "Pipeline" |> NamespacedName

    /// <summary>
    /// ETL Service
    /// <see href="https://open-metadata.org/ontology/PipelineService"></see></summary>
    let PipelineService =
        Namespaced_IRI.parse _namespace_name "PipelineService" |> NamespacedName

    /// <summary>
    /// Status of a pipeline execution
    /// <see href="https://open-metadata.org/ontology/PipelineStatus"></see></summary>
    let PipelineStatus =
        Namespaced_IRI.parse _namespace_name "PipelineStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Post"></see>
    /// </summary>
    let Post = Namespaced_IRI.parse _namespace_name "Post" |> NamespacedName

    /// <summary>
    /// Configuration for table profiling
    /// <see href="https://open-metadata.org/ontology/ProfilerConfig"></see></summary>
    let ProfilerConfig =
        Namespaced_IRI.parse _namespace_name "ProfilerConfig" |> NamespacedName

    /// <summary>
    /// Reusable prompt template with variables, system prompts and examples for consistent AI behavior
    /// <see href="https://open-metadata.org/ontology/PromptTemplate"></see></summary>
    let PromptTemplate =
        Namespaced_IRI.parse _namespace_name "PromptTemplate" |> NamespacedName

    /// <summary>
    /// Relationship with additional context like role, time, etc.
    /// <see href="https://open-metadata.org/ontology/QualifiedRelationship"></see></summary>
    let QualifiedRelationship =
        Namespaced_IRI.parse _namespace_name "QualifiedRelationship" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/QualityService"></see>
    /// </summary>
    let QualityService =
        Namespaced_IRI.parse _namespace_name "QualityService" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Query"></see>
    /// </summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName
    /// <summary>
    /// Report as a specific representation of data
    /// <see href="https://open-metadata.org/ontology/Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/ReportingService"></see>
    /// </summary>
    let ReportingService =
        Namespaced_IRI.parse _namespace_name "ReportingService" |> NamespacedName

    /// <summary>
    /// Any resource cataloged in OpenMetadata
    /// <see href="https://open-metadata.org/ontology/Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName

    /// <summary>
    /// Statement about intellectual property rights
    /// <see href="https://open-metadata.org/ontology/RightsStatement"></see></summary>
    let RightsStatement =
        Namespaced_IRI.parse _namespace_name "RightsStatement" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/SearchIndex"></see>
    /// </summary>
    let SearchIndex =
        Namespaced_IRI.parse _namespace_name "SearchIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/SearchService"></see>
    /// </summary>
    let SearchService =
        Namespaced_IRI.parse _namespace_name "SearchService" |> NamespacedName

    /// <summary>
    /// Spreadsheet document
    /// <see href="https://open-metadata.org/ontology/Spreadsheet"></see></summary>
    let Spreadsheet =
        Namespaced_IRI.parse _namespace_name "Spreadsheet" |> NamespacedName

    /// <summary>
    /// Technical standard or specification
    /// <see href="https://open-metadata.org/ontology/Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/StorageService"></see>
    /// </summary>
    let StorageService =
        Namespaced_IRI.parse _namespace_name "StorageService" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/StoredProcedure"></see>
    /// </summary>
    let StoredProcedure =
        Namespaced_IRI.parse _namespace_name "StoredProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Table"></see>
    /// </summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName

    /// <summary>
    /// Table column context type used to attach custom properties to columns of a Table
    /// <see href="https://open-metadata.org/ontology/TableColumn"></see></summary>
    let TableColumn =
        Namespaced_IRI.parse _namespace_name "TableColumn" |> NamespacedName

    /// <summary>
    /// Profile data for a table including statistics
    /// <see href="https://open-metadata.org/ontology/TableProfile"></see></summary>
    let TableProfile =
        Namespaced_IRI.parse _namespace_name "TableProfile" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Tag"></see>
    /// </summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Task"></see>
    /// </summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Team"></see>
    /// </summary>
    let Team = Namespaced_IRI.parse _namespace_name "Team" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/TestCase"></see>
    /// </summary>
    let TestCase = Namespaced_IRI.parse _namespace_name "TestCase" |> NamespacedName

    /// <summary>
    /// Parameter definition for a test case
    /// <see href="https://open-metadata.org/ontology/TestCaseParameter"></see></summary>
    let TestCaseParameter =
        Namespaced_IRI.parse _namespace_name "TestCaseParameter" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/TestDefinition"></see>
    /// </summary>
    let TestDefinition =
        Namespaced_IRI.parse _namespace_name "TestDefinition" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/TestSuite"></see>
    /// </summary>
    let TestSuite = Namespaced_IRI.parse _namespace_name "TestSuite" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Thread"></see>
    /// </summary>
    let Thread = Namespaced_IRI.parse _namespace_name "Thread" |> NamespacedName
    /// <summary>
    /// Message topic providing streaming data access
    /// <see href="https://open-metadata.org/ontology/Topic"></see></summary>
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/User"></see>
    /// </summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// Votes on an entity (upvotes and downvotes)
    /// <see href="https://open-metadata.org/ontology/Votes"></see></summary>
    let Votes = Namespaced_IRI.parse _namespace_name "Votes" |> NamespacedName
    /// <summary>
    /// Worksheet within a spreadsheet
    /// <see href="https://open-metadata.org/ontology/Worksheet"></see></summary>
    let Worksheet = Namespaced_IRI.parse _namespace_name "Worksheet" |> NamespacedName

    /// <summary>
    /// Information about access restrictions
    /// <see href="https://open-metadata.org/ontology/accessRights"></see></summary>
    let accessRights =
        Namespaced_IRI.parse _namespace_name "accessRights" |> NamespacedName

    /// <summary>
    /// URL to access the distribution
    /// <see href="https://open-metadata.org/ontology/accessURL"></see></summary>
    let accessURL = Namespaced_IRI.parse _namespace_name "accessURL" |> NamespacedName

    /// <summary>
    /// Frequency of dataset updates
    /// <see href="https://open-metadata.org/ontology/accrualPeriodicity"></see></summary>
    let accrualPeriodicity =
        Namespaced_IRI.parse _namespace_name "accrualPeriodicity" |> NamespacedName

    /// <summary>
    /// Degree of data accuracy
    /// <see href="https://open-metadata.org/ontology/accuracy"></see></summary>
    let accuracy = Namespaced_IRI.parse _namespace_name "accuracy" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/addressedTo"></see>
    /// </summary>
    let addressedTo =
        Namespaced_IRI.parse _namespace_name "addressedTo" |> NamespacedName

    /// <summary>
    /// Link to API documentation
    /// <see href="https://open-metadata.org/ontology/apiDocumentation"></see></summary>
    let apiDocumentation =
        Namespaced_IRI.parse _namespace_name "apiDocumentation" |> NamespacedName

    /// <summary>
    /// Type of AI application (Chatbot, Agent, Copilot, Assistant, RAG, CodeGenerator, DataAnalyst, AutomationBot, MultiAgent, Custom)
    /// <see href="https://open-metadata.org/ontology/applicationType"></see></summary>
    let applicationType =
        Namespaced_IRI.parse _namespace_name "applicationType" |> NamespacedName

    /// <summary>
    /// Tag or classification applied to entity
    /// <see href="https://open-metadata.org/ontology/appliedTo"></see></summary>
    let appliedTo = Namespaced_IRI.parse _namespace_name "appliedTo" |> NamespacedName
    /// <summary>
    /// Base model this model was trained or fine-tuned from
    /// <see href="https://open-metadata.org/ontology/baseModel"></see></summary>
    let baseModel = Namespaced_IRI.parse _namespace_name "baseModel" |> NamespacedName
    /// <summary>
    /// Geographic bounding box
    /// <see href="https://open-metadata.org/ontology/bbox"></see></summary>
    let bbox = Namespaced_IRI.parse _namespace_name "bbox" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/belongsToDatabase"></see>
    /// </summary>
    let belongsToDatabase =
        Namespaced_IRI.parse _namespace_name "belongsToDatabase" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/belongsToSchema"></see>
    /// </summary>
    let belongsToSchema =
        Namespaced_IRI.parse _namespace_name "belongsToSchema" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/belongsToService"></see>
    /// </summary>
    let belongsToService =
        Namespaced_IRI.parse _namespace_name "belongsToService" |> NamespacedName

    /// <summary>
    /// Size in bytes
    /// <see href="https://open-metadata.org/ontology/byteSize"></see></summary>
    let byteSize = Namespaced_IRI.parse _namespace_name "byteSize" |> NamespacedName
    /// <summary>
    /// Sub-catalog
    /// <see href="https://open-metadata.org/ontology/catalog"></see></summary>
    let catalog = Namespaced_IRI.parse _namespace_name "catalog" |> NamespacedName
    /// <summary>
    /// Date when entity was added to catalog
    /// <see href="https://open-metadata.org/ontology/cataloged"></see></summary>
    let cataloged = Namespaced_IRI.parse _namespace_name "cataloged" |> NamespacedName
    /// <summary>
    /// Geographic center point
    /// <see href="https://open-metadata.org/ontology/centroid"></see></summary>
    let centroid = Namespaced_IRI.parse _namespace_name "centroid" |> NamespacedName

    /// <summary>
    /// Tag label for the certification
    /// <see href="https://open-metadata.org/ontology/certificationTagLabel"></see></summary>
    let certificationTagLabel =
        Namespaced_IRI.parse _namespace_name "certificationTagLabel" |> NamespacedName

    /// <summary>
    /// Checksum for data integrity verification
    /// <see href="https://open-metadata.org/ontology/checksum"></see></summary>
    let checksum = Namespaced_IRI.parse _namespace_name "checksum" |> NamespacedName

    /// <summary>
    /// Number of columns in the table
    /// <see href="https://open-metadata.org/ontology/columnCount"></see></summary>
    let columnCount =
        Namespaced_IRI.parse _namespace_name "columnCount" |> NamespacedName

    /// <summary>
    /// Data type of the column
    /// <see href="https://open-metadata.org/ontology/columnDataType"></see></summary>
    let columnDataType =
        Namespaced_IRI.parse _namespace_name "columnDataType" |> NamespacedName

    /// <summary>
    /// Description of what the column contains
    /// <see href="https://open-metadata.org/ontology/columnDescription"></see></summary>
    let columnDescription =
        Namespaced_IRI.parse _namespace_name "columnDescription" |> NamespacedName

    /// <summary>
    /// Degree of data completeness
    /// <see href="https://open-metadata.org/ontology/completeness"></see></summary>
    let completeness =
        Namespaced_IRI.parse _namespace_name "completeness" |> NamespacedName

    /// <summary>
    /// Compression format of the distribution
    /// <see href="https://open-metadata.org/ontology/compressFormat"></see></summary>
    let compressFormat =
        Namespaced_IRI.parse _namespace_name "compressFormat" |> NamespacedName

    /// <summary>
    /// Concurrency level of the pipeline
    /// <see href="https://open-metadata.org/ontology/concurrency"></see></summary>
    let concurrency =
        Namespaced_IRI.parse _namespace_name "concurrency" |> NamespacedName

    /// <summary>
    /// Standard or schema that the resource conforms to
    /// <see href="https://open-metadata.org/ontology/conformsTo"></see></summary>
    let conformsTo = Namespaced_IRI.parse _namespace_name "conformsTo" |> NamespacedName

    /// <summary>
    /// Standard the dataset conforms to
    /// <see href="https://open-metadata.org/ontology/conformsToStandard"></see></summary>
    let conformsToStandard =
        Namespaced_IRI.parse _namespace_name "conformsToStandard" |> NamespacedName

    /// <summary>
    /// Degree of data consistency
    /// <see href="https://open-metadata.org/ontology/consistency"></see></summary>
    let consistency =
        Namespaced_IRI.parse _namespace_name "consistency" |> NamespacedName

    /// <summary>
    /// Data products that this product consumes data from
    /// <see href="https://open-metadata.org/ontology/consumesFrom"></see></summary>
    let consumesFrom =
        Namespaced_IRI.parse _namespace_name "consumesFrom" |> NamespacedName

    /// <summary>
    /// Contact information for the dataset
    /// <see href="https://open-metadata.org/ontology/contactPoint"></see></summary>
    let contactPoint =
        Namespaced_IRI.parse _namespace_name "contactPoint" |> NamespacedName

    /// <summary>
    /// Hierarchical containment relationship
    /// <see href="https://open-metadata.org/ontology/contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/containsPosts"></see>
    /// </summary>
    let containsPosts =
        Namespaced_IRI.parse _namespace_name "containsPosts" |> NamespacedName

    /// <summary>
    /// Entity responsible for contributions to the dataset
    /// <see href="https://open-metadata.org/ontology/contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/created"></see>
    /// </summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/createdBy"></see>
    /// </summary>
    let createdBy = Namespaced_IRI.parse _namespace_name "createdBy" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/creates"></see>
    /// </summary>
    let creates = Namespaced_IRI.parse _namespace_name "creates" |> NamespacedName
    /// <summary>
    /// Entity primarily responsible for creating the dataset
    /// <see href="https://open-metadata.org/ontology/creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName

    /// <summary>
    /// Type of data model (TableauDataModel, SupersetDataModel, MetabaseDataModel, LookMlView, LookMlExplore, PowerBIDataModel, QlikDataModel)
    /// <see href="https://open-metadata.org/ontology/dataModelType"></see></summary>
    let dataModelType =
        Namespaced_IRI.parse _namespace_name "dataModelType" |> NamespacedName

    /// <summary>
    /// Assets that are part of this data product
    /// <see href="https://open-metadata.org/ontology/dataProductAssets"></see></summary>
    let dataProductAssets =
        Namespaced_IRI.parse _namespace_name "dataProductAssets" |> NamespacedName

    /// <summary>
    /// Domain this data product belongs to
    /// <see href="https://open-metadata.org/ontology/dataProductDomain"></see></summary>
    let dataProductDomain =
        Namespaced_IRI.parse _namespace_name "dataProductDomain" |> NamespacedName

    /// <summary>
    /// Expert for this data product
    /// <see href="https://open-metadata.org/ontology/dataProductExpert"></see></summary>
    let dataProductExpert =
        Namespaced_IRI.parse _namespace_name "dataProductExpert" |> NamespacedName

    /// <summary>
    /// Owner of the data product
    /// <see href="https://open-metadata.org/ontology/dataProductOwner"></see></summary>
    let dataProductOwner =
        Namespaced_IRI.parse _namespace_name "dataProductOwner" |> NamespacedName

    /// <summary>
    /// Data quality dimension (Completeness, Accuracy, Consistency, Validity, Uniqueness, Integrity, SQL)
    /// <see href="https://open-metadata.org/ontology/dataQualityDimension"></see></summary>
    let dataQualityDimension =
        Namespaced_IRI.parse _namespace_name "dataQualityDimension" |> NamespacedName

    /// <summary>
    /// Dataset that is part of the catalog
    /// <see href="https://open-metadata.org/ontology/dataset"></see></summary>
    let dataset = Namespaced_IRI.parse _namespace_name "dataset" |> NamespacedName
    /// <summary>
    /// Default value relationship
    /// <see href="https://open-metadata.org/ontology/defaultsTo"></see></summary>
    let defaultsTo = Namespaced_IRI.parse _namespace_name "defaultsTo" |> NamespacedName
    /// <summary>
    /// Whether the entity has been soft deleted
    /// <see href="https://open-metadata.org/ontology/deleted"></see></summary>
    let deleted = Namespaced_IRI.parse _namespace_name "deleted" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/developmentStage"></see>
    /// </summary>
    let developmentStage =
        Namespaced_IRI.parse _namespace_name "developmentStage" |> NamespacedName

    /// <summary>
    /// Dimension represented in the dataset
    /// <see href="https://open-metadata.org/ontology/dimension"></see></summary>
    let dimension = Namespaced_IRI.parse _namespace_name "dimension" |> NamespacedName

    /// <summary>
    /// Available distribution of the dataset
    /// <see href="https://open-metadata.org/ontology/distribution"></see></summary>
    let distribution =
        Namespaced_IRI.parse _namespace_name "distribution" |> NamespacedName

    /// <summary>
    /// Number of down votes
    /// <see href="https://open-metadata.org/ontology/downVotes"></see></summary>
    let downVotes = Namespaced_IRI.parse _namespace_name "downVotes" |> NamespacedName

    /// <summary>
    /// Direct download URL
    /// <see href="https://open-metadata.org/ontology/downloadURL"></see></summary>
    let downloadURL =
        Namespaced_IRI.parse _namespace_name "downloadURL" |> NamespacedName

    /// <summary>
    /// Data lineage downstream relationship
    /// <see href="https://open-metadata.org/ontology/downstream"></see></summary>
    let downstream = Namespaced_IRI.parse _namespace_name "downstream" |> NamespacedName
    /// <summary>
    /// Data lineage upstream relationship
    /// <see href="https://open-metadata.org/ontology/upstream"></see></summary>
    let upstream = Namespaced_IRI.parse _namespace_name "upstream" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/editedBy"></see>
    /// </summary>
    let editedBy = Namespaced_IRI.parse _namespace_name "editedBy" |> NamespacedName
    /// <summary>
    /// End of the temporal period
    /// <see href="https://open-metadata.org/ontology/endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/endpointDescription"></see>
    /// </summary>
    let endpointDescription =
        Namespaced_IRI.parse _namespace_name "endpointDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/endpointURL"></see>
    /// </summary>
    let endpointURL =
        Namespaced_IRI.parse _namespace_name "endpointURL" |> NamespacedName

    /// <summary>
    /// Agent execution was an execution of this AI application
    /// <see href="https://open-metadata.org/ontology/executedAgent"></see></summary>
    let executedAgent =
        Namespaced_IRI.parse _namespace_name "executedAgent" |> NamespacedName

    /// <summary>
    /// MCP execution was an execution of this MCP server
    /// <see href="https://open-metadata.org/ontology/executedMCPServer"></see></summary>
    let executedMCPServer =
        Namespaced_IRI.parse _namespace_name "executedMCPServer" |> NamespacedName

    /// <summary>
    /// Status of an agent or MCP execution (Running, Success, Failed, Timeout, Cancelled, PartialSuccess)
    /// <see href="https://open-metadata.org/ontology/executionStatus"></see></summary>
    let executionStatus =
        Namespaced_IRI.parse _namespace_name "executionStatus" |> NamespacedName

    /// <summary>
    /// User is expert on entity
    /// <see href="https://open-metadata.org/ontology/expert"></see></summary>
    let expert = Namespaced_IRI.parse _namespace_name "expert" |> NamespacedName
    /// <summary>
    /// First dataset in a series
    /// <see href="https://open-metadata.org/ontology/first"></see></summary>
    let first = Namespaced_IRI.parse _namespace_name "first" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/follows"></see>
    /// </summary>
    let follows = Namespaced_IRI.parse _namespace_name "follows" |> NamespacedName
    /// <summary>
    /// File format of the distribution
    /// <see href="https://open-metadata.org/ontology/format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName
    /// <summary>
    /// Source column used in transformation
    /// <see href="https://open-metadata.org/ontology/fromColumn"></see></summary>
    let fromColumn = Namespaced_IRI.parse _namespace_name "fromColumn" |> NamespacedName

    /// <summary>
    /// Unique identifier for the entity within OpenMetadata
    /// <see href="https://open-metadata.org/ontology/fullyQualifiedName"></see></summary>
    let fullyQualifiedName =
        Namespaced_IRI.parse _namespace_name "fullyQualifiedName" |> NamespacedName

    /// <summary>
    /// Geometry of the spatial area
    /// <see href="https://open-metadata.org/ontology/geometry"></see></summary>
    let geometry = Namespaced_IRI.parse _namespace_name "geometry" |> NamespacedName
    /// <summary>
    /// AI application, LLM model or MCP server is governed by an AI governance policy
    /// <see href="https://open-metadata.org/ontology/governedBy"></see></summary>
    let governedBy = Namespaced_IRI.parse _namespace_name "governedBy" |> NamespacedName
    /// <summary>
    /// Role in a qualified relationship
    /// <see href="https://open-metadata.org/ontology/hadRole"></see></summary>
    let hadRole = Namespaced_IRI.parse _namespace_name "hadRole" |> NamespacedName
    /// <summary>
    /// General possession relationship
    /// <see href="https://open-metadata.org/ontology/has"></see></summary>
    let has = Namespaced_IRI.parse _namespace_name "has" |> NamespacedName

    /// <summary>
    /// Beginning instant of the temporal period
    /// <see href="https://open-metadata.org/ontology/hasBeginning"></see></summary>
    let hasBeginning =
        Namespaced_IRI.parse _namespace_name "hasBeginning" |> NamespacedName

    /// <summary>
    /// Certification status of the asset
    /// <see href="https://open-metadata.org/ontology/hasCertification"></see></summary>
    let hasCertification =
        Namespaced_IRI.parse _namespace_name "hasCertification" |> NamespacedName

    /// <summary>
    /// Change that led to this version of the entity
    /// <see href="https://open-metadata.org/ontology/hasChangeDescription"></see></summary>
    let hasChangeDescription =
        Namespaced_IRI.parse _namespace_name "hasChangeDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/hasColumn"></see>
    /// </summary>
    let hasColumn = Namespaced_IRI.parse _namespace_name "hasColumn" |> NamespacedName

    /// <summary>
    /// Data products this entity is part of
    /// <see href="https://open-metadata.org/ontology/hasDataProducts"></see></summary>
    let hasDataProducts =
        Namespaced_IRI.parse _namespace_name "hasDataProducts" |> NamespacedName

    /// <summary>
    /// Domains the entity belongs to
    /// <see href="https://open-metadata.org/ontology/hasDomains"></see></summary>
    let hasDomains = Namespaced_IRI.parse _namespace_name "hasDomains" |> NamespacedName
    /// <summary>
    /// Ending instant of the temporal period
    /// <see href="https://open-metadata.org/ontology/hasEnd"></see></summary>
    let hasEnd = Namespaced_IRI.parse _namespace_name "hasEnd" |> NamespacedName

    /// <summary>
    /// Current status of the entity
    /// <see href="https://open-metadata.org/ontology/hasEntityStatus"></see></summary>
    let hasEntityStatus =
        Namespaced_IRI.parse _namespace_name "hasEntityStatus" |> NamespacedName

    /// <summary>
    /// Users who follow this entity
    /// <see href="https://open-metadata.org/ontology/hasFollowers"></see></summary>
    let hasFollowers =
        Namespaced_IRI.parse _namespace_name "hasFollowers" |> NamespacedName

    /// <summary>
    /// Incremental change that led to this version
    /// <see href="https://open-metadata.org/ontology/hasIncrementalChangeDescription"></see></summary>
    let hasIncrementalChangeDescription =
        Namespaced_IRI.parse _namespace_name "hasIncrementalChangeDescription" |> NamespacedName

    /// <summary>
    /// Input port of the data product
    /// <see href="https://open-metadata.org/ontology/hasInputPort"></see></summary>
    let hasInputPort =
        Namespaced_IRI.parse _namespace_name "hasInputPort" |> NamespacedName

    /// <summary>
    /// Life cycle properties of the entity
    /// <see href="https://open-metadata.org/ontology/hasLifeCycle"></see></summary>
    let hasLifeCycle =
        Namespaced_IRI.parse _namespace_name "hasLifeCycle" |> NamespacedName

    /// <summary>
    /// Output port of the data product
    /// <see href="https://open-metadata.org/ontology/hasOutputPort"></see></summary>
    let hasOutputPort =
        Namespaced_IRI.parse _namespace_name "hasOutputPort" |> NamespacedName

    /// <summary>
    /// Agent responsible for the entity
    /// <see href="https://open-metadata.org/ontology/hasOwner"></see></summary>
    let hasOwner = Namespaced_IRI.parse _namespace_name "hasOwner" |> NamespacedName
    /// <summary>
    /// Owners of this entity (plural)
    /// <see href="https://open-metadata.org/ontology/hasOwners"></see></summary>
    let hasOwners = Namespaced_IRI.parse _namespace_name "hasOwners" |> NamespacedName

    /// <summary>
    /// Parameter definitions for a test
    /// <see href="https://open-metadata.org/ontology/hasParameterDefinition"></see></summary>
    let hasParameterDefinition =
        Namespaced_IRI.parse _namespace_name "hasParameterDefinition" |> NamespacedName

    /// <summary>
    /// Latest status of the pipeline
    /// <see href="https://open-metadata.org/ontology/hasPipelineStatus"></see></summary>
    let hasPipelineStatus =
        Namespaced_IRI.parse _namespace_name "hasPipelineStatus" |> NamespacedName

    /// <summary>
    /// ODRL policy associated with the dataset
    /// <see href="https://open-metadata.org/ontology/hasPolicy"></see></summary>
    let hasPolicy = Namespaced_IRI.parse _namespace_name "hasPolicy" |> NamespacedName
    /// <summary>
    /// Latest profile data for the table
    /// <see href="https://open-metadata.org/ontology/hasProfile"></see></summary>
    let hasProfile = Namespaced_IRI.parse _namespace_name "hasProfile" |> NamespacedName

    /// <summary>
    /// Profiler configuration for the table
    /// <see href="https://open-metadata.org/ontology/hasProfilerConfig"></see></summary>
    let hasProfilerConfig =
        Namespaced_IRI.parse _namespace_name "hasProfilerConfig" |> NamespacedName

    /// <summary>
    /// Quality annotation for the dataset
    /// <see href="https://open-metadata.org/ontology/hasQualityAnnotation"></see></summary>
    let hasQualityAnnotation =
        Namespaced_IRI.parse _namespace_name "hasQualityAnnotation" |> NamespacedName

    /// <summary>
    /// Quality measurement for the dataset
    /// <see href="https://open-metadata.org/ontology/hasQualityMeasurement"></see></summary>
    let hasQualityMeasurement =
        Namespaced_IRI.parse _namespace_name "hasQualityMeasurement" |> NamespacedName

    /// <summary>
    /// Service Level Agreement for the data product
    /// <see href="https://open-metadata.org/ontology/hasSLA"></see></summary>
    let hasSLA = Namespaced_IRI.parse _namespace_name "hasSLA" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/hasTag"></see>
    /// </summary>
    let hasTag = Namespaced_IRI.parse _namespace_name "hasTag" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/hasVersion"></see>
    /// </summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// Links to the non-versioned or abstract dataset
    /// <see href="https://open-metadata.org/ontology/isVersionOf"></see></summary>
    let isVersionOf =
        Namespaced_IRI.parse _namespace_name "isVersionOf" |> NamespacedName

    /// <summary>
    /// Votes on the entity
    /// <see href="https://open-metadata.org/ontology/hasVotes"></see></summary>
    let hasVotes = Namespaced_IRI.parse _namespace_name "hasVotes" |> NamespacedName
    /// <summary>
    /// Homepage of the catalog
    /// <see href="https://open-metadata.org/ontology/homepage"></see></summary>
    let homepage = Namespaced_IRI.parse _namespace_name "homepage" |> NamespacedName
    /// <summary>
    /// Unique identifier of the dataset
    /// <see href="https://open-metadata.org/ontology/identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// Bot user that performed the action on behalf of the actual user
    /// <see href="https://open-metadata.org/ontology/impersonatedBy"></see></summary>
    let impersonatedBy =
        Namespaced_IRI.parse _namespace_name "impersonatedBy" |> NamespacedName

    /// <summary>
    /// Links a dataset to its series
    /// <see href="https://open-metadata.org/ontology/inSeries"></see></summary>
    let inSeries = Namespaced_IRI.parse _namespace_name "inSeries" |> NamespacedName
    /// <summary>
    /// Thread or post is about an entity
    /// <see href="https://open-metadata.org/ontology/isAbout"></see></summary>
    let isAbout = Namespaced_IRI.parse _namespace_name "isAbout" |> NamespacedName
    /// <summary>
    /// Whether this column can contain null values
    /// <see href="https://open-metadata.org/ontology/isNullable"></see></summary>
    let isNullable = Namespaced_IRI.parse _namespace_name "isNullable" |> NamespacedName

    /// <summary>
    /// Whether this column is a primary key
    /// <see href="https://open-metadata.org/ontology/isPrimaryKey"></see></summary>
    let isPrimaryKey =
        Namespaced_IRI.parse _namespace_name "isPrimaryKey" |> NamespacedName

    /// <summary>
    /// Related resource that references this dataset
    /// <see href="https://open-metadata.org/ontology/isReferencedBy"></see></summary>
    let isReferencedBy =
        Namespaced_IRI.parse _namespace_name "isReferencedBy" |> NamespacedName

    /// <summary>
    /// Date of formal issuance
    /// <see href="https://open-metadata.org/ontology/issued"></see></summary>
    let issued = Namespaced_IRI.parse _namespace_name "issued" |> NamespacedName
    /// <summary>
    /// Join relationship between tables
    /// <see href="https://open-metadata.org/ontology/joinedWith"></see></summary>
    let joinedWith = Namespaced_IRI.parse _namespace_name "joinedWith" |> NamespacedName
    /// <summary>
    /// Keywords describing the dataset
    /// <see href="https://open-metadata.org/ontology/keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName

    /// <summary>
    /// Web page providing access and information
    /// <see href="https://open-metadata.org/ontology/landingPage"></see></summary>
    let landingPage =
        Namespaced_IRI.parse _namespace_name "landingPage" |> NamespacedName

    /// <summary>
    /// Language of the dataset
    /// <see href="https://open-metadata.org/ontology/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// Last dataset in a series
    /// <see href="https://open-metadata.org/ontology/last"></see></summary>
    let last = Namespaced_IRI.parse _namespace_name "last" |> NamespacedName
    /// <summary>
    /// License under which the dataset is available
    /// <see href="https://open-metadata.org/ontology/license"></see></summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName

    /// <summary>
    /// Access details when entity was last accessed
    /// <see href="https://open-metadata.org/ontology/lifeCycleAccessed"></see></summary>
    let lifeCycleAccessed =
        Namespaced_IRI.parse _namespace_name "lifeCycleAccessed" |> NamespacedName

    /// <summary>
    /// Access details when entity was created
    /// <see href="https://open-metadata.org/ontology/lifeCycleCreated"></see></summary>
    let lifeCycleCreated =
        Namespaced_IRI.parse _namespace_name "lifeCycleCreated" |> NamespacedName

    /// <summary>
    /// Access details when entity was last updated
    /// <see href="https://open-metadata.org/ontology/lifeCycleUpdated"></see></summary>
    let lifeCycleUpdated =
        Namespaced_IRI.parse _namespace_name "lifeCycleUpdated" |> NamespacedName

    /// <summary>
    /// Current lifecycle stage (IDEATION, DESIGN, DEVELOPMENT, TESTING, PRODUCTION, DEPRECATED, RETIRED)
    /// <see href="https://open-metadata.org/ontology/lifecycleStage"></see></summary>
    let lifecycleStage =
        Namespaced_IRI.parse _namespace_name "lifecycleStage" |> NamespacedName

    /// <summary>
    /// When the lineage was created
    /// <see href="https://open-metadata.org/ontology/lineageCreatedAt"></see></summary>
    let lineageCreatedAt =
        Namespaced_IRI.parse _namespace_name "lineageCreatedAt" |> NamespacedName

    /// <summary>
    /// User who created the lineage
    /// <see href="https://open-metadata.org/ontology/lineageCreatedBy"></see></summary>
    let lineageCreatedBy =
        Namespaced_IRI.parse _namespace_name "lineageCreatedBy" |> NamespacedName

    /// <summary>
    /// How the lineage was created (Manual, Pipeline, Query, etc.)
    /// <see href="https://open-metadata.org/ontology/lineageSource"></see></summary>
    let lineageSource =
        Namespaced_IRI.parse _namespace_name "lineageSource" |> NamespacedName

    /// <summary>
    /// Measure represented in the dataset
    /// <see href="https://open-metadata.org/ontology/measure"></see></summary>
    let measure = Namespaced_IRI.parse _namespace_name "measure" |> NamespacedName
    /// <summary>
    /// Media type of the distribution
    /// <see href="https://open-metadata.org/ontology/mediaType"></see></summary>
    let mediaType = Namespaced_IRI.parse _namespace_name "mediaType" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/memberOf"></see>
    /// </summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName

    /// <summary>
    /// Entity is mentioned in a post or thread
    /// <see href="https://open-metadata.org/ontology/mentionedIn"></see></summary>
    let mentionedIn =
        Namespaced_IRI.parse _namespace_name "mentionedIn" |> NamespacedName

    /// <summary>
    /// Capability exposed by the LLM model (TextGeneration, CodeGeneration, Embeddings, Chat, Vision, Audio, FunctionCalling, ToolUse)
    /// <see href="https://open-metadata.org/ontology/modelCapability"></see></summary>
    let modelCapability =
        Namespaced_IRI.parse _namespace_name "modelCapability" |> NamespacedName

    /// <summary>
    /// Type of LLM model (BaseModel, FineTuned, Quantized, Distilled, Adapter, Custom)
    /// <see href="https://open-metadata.org/ontology/modelType"></see></summary>
    let modelType = Namespaced_IRI.parse _namespace_name "modelType" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/modified"></see>
    /// </summary>
    let modified = Namespaced_IRI.parse _namespace_name "modified" |> NamespacedName
    /// <summary>
    /// Next dataset in a series
    /// <see href="https://open-metadata.org/ontology/next"></see></summary>
    let next = Namespaced_IRI.parse _namespace_name "next" |> NamespacedName

    /// <summary>
    /// Number of columns in the dataset
    /// <see href="https://open-metadata.org/ontology/numberOfColumns"></see></summary>
    let numberOfColumns =
        Namespaced_IRI.parse _namespace_name "numberOfColumns" |> NamespacedName

    /// <summary>
    /// Number of records in the dataset
    /// <see href="https://open-metadata.org/ontology/numberOfRecords"></see></summary>
    let numberOfRecords =
        Namespaced_IRI.parse _namespace_name "numberOfRecords" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/owns"></see>
    /// </summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName

    /// <summary>
    /// Package format of the distribution
    /// <see href="https://open-metadata.org/ontology/packageFormat"></see></summary>
    let packageFormat =
        Namespaced_IRI.parse _namespace_name "packageFormat" |> NamespacedName

    /// <summary>
    /// Hierarchical parent relationship
    /// <see href="https://open-metadata.org/ontology/parentOf"></see></summary>
    let parentOf = Namespaced_IRI.parse _namespace_name "parentOf" |> NamespacedName
    /// <summary>
    /// Pipeline that processes the data
    /// <see href="https://open-metadata.org/ontology/pipeline"></see></summary>
    let pipeline = Namespaced_IRI.parse _namespace_name "pipeline" |> NamespacedName

    /// <summary>
    /// Pipeline code location
    /// <see href="https://open-metadata.org/ontology/pipelineLocation"></see></summary>
    let pipelineLocation =
        Namespaced_IRI.parse _namespace_name "pipelineLocation" |> NamespacedName

    /// <summary>
    /// Type of AI governance policy (ModelApproval, DataAccess, BiasThreshold, ComplianceCheck, CostControl, PerformanceStandard, SecurityControl)
    /// <see href="https://open-metadata.org/ontology/policyType"></see></summary>
    let policyType = Namespaced_IRI.parse _namespace_name "policyType" |> NamespacedName

    /// <summary>
    /// Data asset exposed through this port
    /// <see href="https://open-metadata.org/ontology/portDataAsset"></see></summary>
    let portDataAsset =
        Namespaced_IRI.parse _namespace_name "portDataAsset" |> NamespacedName

    /// <summary>
    /// Endpoint URL or connection string for the port
    /// <see href="https://open-metadata.org/ontology/portEndpoint"></see></summary>
    let portEndpoint =
        Namespaced_IRI.parse _namespace_name "portEndpoint" |> NamespacedName

    /// <summary>
    /// Data format supported by the port (JSON, CSV, PARQUET, etc.)
    /// <see href="https://open-metadata.org/ontology/portFormat"></see></summary>
    let portFormat = Namespaced_IRI.parse _namespace_name "portFormat" |> NamespacedName
    /// <summary>
    /// Name of the port
    /// <see href="https://open-metadata.org/ontology/portName"></see></summary>
    let portName = Namespaced_IRI.parse _namespace_name "portName" |> NamespacedName

    /// <summary>
    /// Protocol used by the port (REST, GRPC, KAFKA, etc.)
    /// <see href="https://open-metadata.org/ontology/portProtocol"></see></summary>
    let portProtocol =
        Namespaced_IRI.parse _namespace_name "portProtocol" |> NamespacedName

    /// <summary>
    /// Previous dataset in a series
    /// <see href="https://open-metadata.org/ontology/prev"></see></summary>
    let prev = Namespaced_IRI.parse _namespace_name "prev" |> NamespacedName

    /// <summary>
    /// Link to previous version
    /// <see href="https://open-metadata.org/ontology/previousVersion"></see></summary>
    let previousVersion =
        Namespaced_IRI.parse _namespace_name "previousVersion" |> NamespacedName

    /// <summary>
    /// Main entity described by this record
    /// <see href="https://open-metadata.org/ontology/primaryTopic"></see></summary>
    let primaryTopic =
        Namespaced_IRI.parse _namespace_name "primaryTopic" |> NamespacedName

    /// <summary>
    /// Whether lineage has been processed for this entity
    /// <see href="https://open-metadata.org/ontology/processedLineage"></see></summary>
    let processedLineage =
        Namespaced_IRI.parse _namespace_name "processedLineage" |> NamespacedName

    /// <summary>
    /// Provenance statement
    /// <see href="https://open-metadata.org/ontology/provenance"></see></summary>
    let provenance = Namespaced_IRI.parse _namespace_name "provenance" |> NamespacedName
    /// <summary>
    /// Data products that consume data from this product
    /// <see href="https://open-metadata.org/ontology/providesTo"></see></summary>
    let providesTo = Namespaced_IRI.parse _namespace_name "providesTo" |> NamespacedName
    /// <summary>
    /// Entity responsible for making the dataset available
    /// <see href="https://open-metadata.org/ontology/publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    /// Qualified access information including authentication and authorization
    /// <see href="https://open-metadata.org/ontology/qualifiedAccess"></see></summary>
    let qualifiedAccess =
        Namespaced_IRI.parse _namespace_name "qualifiedAccess" |> NamespacedName

    /// <summary>
    /// Detailed attribution with roles
    /// <see href="https://open-metadata.org/ontology/qualifiedAttribution"></see></summary>
    let qualifiedAttribution =
        Namespaced_IRI.parse _namespace_name "qualifiedAttribution" |> NamespacedName

    /// <summary>
    /// Detailed derivation with transformation info
    /// <see href="https://open-metadata.org/ontology/qualifiedDerivation"></see></summary>
    let qualifiedDerivation =
        Namespaced_IRI.parse _namespace_name "qualifiedDerivation" |> NamespacedName

    /// <summary>
    /// Link to a qualified relationship
    /// <see href="https://open-metadata.org/ontology/qualifiedRelation"></see></summary>
    let qualifiedRelation =
        Namespaced_IRI.parse _namespace_name "qualifiedRelation" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/reactedTo"></see>
    /// </summary>
    let reactedTo = Namespaced_IRI.parse _namespace_name "reactedTo" |> NamespacedName
    /// <summary>
    /// Links catalog to its records
    /// <see href="https://open-metadata.org/ontology/record"></see></summary>
    let record = Namespaced_IRI.parse _namespace_name "record" |> NamespacedName
    /// <summary>
    /// General relationship between entities
    /// <see href="https://open-metadata.org/ontology/relatedTo"></see></summary>
    let relatedTo = Namespaced_IRI.parse _namespace_name "relatedTo" |> NamespacedName
    /// <summary>
    /// Alternative spelling of relatedTo
    /// <see href="https://open-metadata.org/ontology/relatesTo"></see></summary>
    let relatesTo = Namespaced_IRI.parse _namespace_name "relatesTo" |> NamespacedName
    /// <summary>
    /// Related resource
    /// <see href="https://open-metadata.org/ontology/relation"></see></summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/repliedTo"></see>
    /// </summary>
    let repliedTo = Namespaced_IRI.parse _namespace_name "repliedTo" |> NamespacedName

    /// <summary>
    /// Primary topic grouping (Discovery, Administration, DataGovernance, DataQuality, Observability, AI)
    /// <see href="https://open-metadata.org/ontology/resourceCategory"></see></summary>
    let resourceCategory =
        Namespaced_IRI.parse _namespace_name "resourceCategory" |> NamespacedName

    /// <summary>
    /// Suggested proficiency tier (Intro, Intermediate, Advanced)
    /// <see href="https://open-metadata.org/ontology/resourceDifficulty"></see></summary>
    let resourceDifficulty =
        Namespaced_IRI.parse _namespace_name "resourceDifficulty" |> NamespacedName

    /// <summary>
    /// Kind of learning asset (Storylane, Video, Article)
    /// <see href="https://open-metadata.org/ontology/resourceType"></see></summary>
    let resourceType =
        Namespaced_IRI.parse _namespace_name "resourceType" |> NamespacedName

    /// <summary>
    /// Retention period of the data in ISO 8601 duration format
    /// <see href="https://open-metadata.org/ontology/retentionPeriod"></see></summary>
    let retentionPeriod =
        Namespaced_IRI.parse _namespace_name "retentionPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/reviews"></see>
    /// </summary>
    let reviews = Namespaced_IRI.parse _namespace_name "reviews" |> NamespacedName
    /// <summary>
    /// Rights statement for the dataset
    /// <see href="https://open-metadata.org/ontology/rights"></see></summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName
    /// <summary>
    /// Number of rows in the table
    /// <see href="https://open-metadata.org/ontology/rowCount"></see></summary>
    let rowCount = Namespaced_IRI.parse _namespace_name "rowCount" |> NamespacedName
    /// <summary>
    /// Sample data from the table
    /// <see href="https://open-metadata.org/ontology/sampleData"></see></summary>
    let sampleData = Namespaced_IRI.parse _namespace_name "sampleData" |> NamespacedName

    /// <summary>
    /// Scheduler interval in cron format
    /// <see href="https://open-metadata.org/ontology/scheduleInterval"></see></summary>
    let scheduleInterval =
        Namespaced_IRI.parse _namespace_name "scheduleInterval" |> NamespacedName

    /// <summary>
    /// DDL schema definition for the table
    /// <see href="https://open-metadata.org/ontology/schemaDefinition"></see></summary>
    let schemaDefinition =
        Namespaced_IRI.parse _namespace_name "schemaDefinition" |> NamespacedName

    /// <summary>
    /// Type of MCP server (DataAccess, FileSystem, WebAPI, Database, Cloud, Security, Development, Communication, Custom)
    /// <see href="https://open-metadata.org/ontology/serverType"></see></summary>
    let serverType = Namespaced_IRI.parse _namespace_name "serverType" |> NamespacedName

    /// <summary>
    /// Links a data service to datasets it serves
    /// <see href="https://open-metadata.org/ontology/servesDataset"></see></summary>
    let servesDataset =
        Namespaced_IRI.parse _namespace_name "servesDataset" |> NamespacedName

    /// <summary>
    /// Service that is part of the catalog
    /// <see href="https://open-metadata.org/ontology/service"></see></summary>
    let service = Namespaced_IRI.parse _namespace_name "service" |> NamespacedName

    /// <summary>
    /// Endpoint for accessing the service
    /// <see href="https://open-metadata.org/ontology/serviceEndpoint"></see></summary>
    let serviceEndpoint =
        Namespaced_IRI.parse _namespace_name "serviceEndpoint" |> NamespacedName

    /// <summary>
    /// Service level agreement details
    /// <see href="https://open-metadata.org/ontology/serviceLevel"></see></summary>
    let serviceLevel =
        Namespaced_IRI.parse _namespace_name "serviceLevel" |> NamespacedName

    /// <summary>
    /// Operational status of the service
    /// <see href="https://open-metadata.org/ontology/serviceStatus"></see></summary>
    let serviceStatus =
        Namespaced_IRI.parse _namespace_name "serviceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/serviceType"></see>
    /// </summary>
    let serviceType =
        Namespaced_IRI.parse _namespace_name "serviceType" |> NamespacedName

    /// <summary>
    /// Expected availability percentage
    /// <see href="https://open-metadata.org/ontology/slaAvailability"></see></summary>
    let slaAvailability =
        Namespaced_IRI.parse _namespace_name "slaAvailability" |> NamespacedName

    /// <summary>
    /// Maximum data staleness in minutes
    /// <see href="https://open-metadata.org/ontology/slaDataFreshness"></see></summary>
    let slaDataFreshness =
        Namespaced_IRI.parse _namespace_name "slaDataFreshness" |> NamespacedName

    /// <summary>
    /// Minimum data quality score
    /// <see href="https://open-metadata.org/ontology/slaDataQuality"></see></summary>
    let slaDataQuality =
        Namespaced_IRI.parse _namespace_name "slaDataQuality" |> NamespacedName

    /// <summary>
    /// Expected response time in milliseconds
    /// <see href="https://open-metadata.org/ontology/slaResponseTime"></see></summary>
    let slaResponseTime =
        Namespaced_IRI.parse _namespace_name "slaResponseTime" |> NamespacedName

    /// <summary>
    /// SLA tier level (GOLD, SILVER, BRONZE)
    /// <see href="https://open-metadata.org/ontology/slaTier"></see></summary>
    let slaTier = Namespaced_IRI.parse _namespace_name "slaTier" |> NamespacedName
    /// <summary>
    /// Source of the dataset
    /// <see href="https://open-metadata.org/ontology/source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// Source hash of the entity for change detection
    /// <see href="https://open-metadata.org/ontology/sourceHash"></see></summary>
    let sourceHash = Namespaced_IRI.parse _namespace_name "sourceHash" |> NamespacedName
    /// <summary>
    /// URL to visit/manage the entity in the source system
    /// <see href="https://open-metadata.org/ontology/sourceUrl"></see></summary>
    let sourceUrl = Namespaced_IRI.parse _namespace_name "sourceUrl" |> NamespacedName
    /// <summary>
    /// Spatial area covered by the dataset
    /// <see href="https://open-metadata.org/ontology/spatial"></see></summary>
    let spatial = Namespaced_IRI.parse _namespace_name "spatial" |> NamespacedName

    /// <summary>
    /// Minimum spatial separation resolvable in the dataset
    /// <see href="https://open-metadata.org/ontology/spatialResolution"></see></summary>
    let spatialResolution =
        Namespaced_IRI.parse _namespace_name "spatialResolution" |> NamespacedName

    /// <summary>
    /// SQL query used in transformation
    /// <see href="https://open-metadata.org/ontology/sqlQuery"></see></summary>
    let sqlQuery = Namespaced_IRI.parse _namespace_name "sqlQuery" |> NamespacedName
    /// <summary>
    /// Start of the temporal period
    /// <see href="https://open-metadata.org/ontology/startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    /// Unit of observation in the dataset
    /// <see href="https://open-metadata.org/ontology/statisticalUnit"></see></summary>
    let statisticalUnit =
        Namespaced_IRI.parse _namespace_name "statisticalUnit" |> NamespacedName

    /// <summary>
    /// Data types supported by this test definition
    /// <see href="https://open-metadata.org/ontology/supportedDataTypes"></see></summary>
    let supportedDataTypes =
        Namespaced_IRI.parse _namespace_name "supportedDataTypes" |> NamespacedName

    /// <summary>
    /// Whether the test case supports dynamic assertions
    /// <see href="https://open-metadata.org/ontology/supportsDynamicAssertion"></see></summary>
    let supportsDynamicAssertion =
        Namespaced_IRI.parse _namespace_name "supportsDynamicAssertion" |> NamespacedName

    /// <summary>
    /// Whether the test case supports row level passed/failed
    /// <see href="https://open-metadata.org/ontology/supportsRowLevelPassedFailed"></see></summary>
    let supportsRowLevelPassedFailed =
        Namespaced_IRI.parse _namespace_name "supportsRowLevelPassedFailed" |> NamespacedName

    /// <summary>
    /// Type of table (Regular, External, View, MaterializedView, etc.)
    /// <see href="https://open-metadata.org/ontology/tableType"></see></summary>
    let tableType = Namespaced_IRI.parse _namespace_name "tableType" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/templateVariable"></see>
    /// </summary>
    let templateVariable =
        Namespaced_IRI.parse _namespace_name "templateVariable" |> NamespacedName

    /// <summary>
    /// Temporal period covered by the dataset
    /// <see href="https://open-metadata.org/ontology/temporal"></see></summary>
    let temporal = Namespaced_IRI.parse _namespace_name "temporal" |> NamespacedName

    /// <summary>
    /// Minimum time period resolvable in the dataset
    /// <see href="https://open-metadata.org/ontology/temporalResolution"></see></summary>
    let temporalResolution =
        Namespaced_IRI.parse _namespace_name "temporalResolution" |> NamespacedName

    /// <summary>
    /// Platform where tests are defined (OpenMetadata, GreatExpectations, dbt, Deequ, Soda, Other)
    /// <see href="https://open-metadata.org/ontology/testPlatform"></see></summary>
    let testPlatform =
        Namespaced_IRI.parse _namespace_name "testPlatform" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/testedBy"></see>
    /// </summary>
    let testedBy = Namespaced_IRI.parse _namespace_name "testedBy" |> NamespacedName
    /// <summary>
    /// Main category of the dataset
    /// <see href="https://open-metadata.org/ontology/theme"></see></summary>
    let theme = Namespaced_IRI.parse _namespace_name "theme" |> NamespacedName

    /// <summary>
    /// Knowledge organization system for categorizing datasets
    /// <see href="https://open-metadata.org/ontology/themeTaxonomy"></see></summary>
    let themeTaxonomy =
        Namespaced_IRI.parse _namespace_name "themeTaxonomy" |> NamespacedName

    /// <summary>
    /// How current the data is
    /// <see href="https://open-metadata.org/ontology/timeliness"></see></summary>
    let timeliness = Namespaced_IRI.parse _namespace_name "timeliness" |> NamespacedName
    /// <summary>
    /// Title of the dataset
    /// <see href="https://open-metadata.org/ontology/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// Target column created by transformation
    /// <see href="https://open-metadata.org/ontology/toColumn"></see></summary>
    let toColumn = Namespaced_IRI.parse _namespace_name "toColumn" |> NamespacedName

    /// <summary>
    /// Function applied to transform data
    /// <see href="https://open-metadata.org/ontology/transformationFunction"></see></summary>
    let transformationFunction =
        Namespaced_IRI.parse _namespace_name "transformationFunction" |> NamespacedName

    /// <summary>
    /// Transport protocol used by the MCP server
    /// <see href="https://open-metadata.org/ontology/transportType"></see></summary>
    let transportType =
        Namespaced_IRI.parse _namespace_name "transportType" |> NamespacedName

    /// <summary>
    /// Nature or genre of the dataset
    /// <see href="https://open-metadata.org/ontology/type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// Degree of uniqueness in the data
    /// <see href="https://open-metadata.org/ontology/uniqueness"></see></summary>
    let uniqueness = Namespaced_IRI.parse _namespace_name "uniqueness" |> NamespacedName
    /// <summary>
    /// Number of up votes
    /// <see href="https://open-metadata.org/ontology/upVotes"></see></summary>
    let upVotes = Namespaced_IRI.parse _namespace_name "upVotes" |> NamespacedName
    /// <summary>
    /// Last update time in Unix epoch milliseconds
    /// <see href="https://open-metadata.org/ontology/updatedAt"></see></summary>
    let updatedAt = Namespaced_IRI.parse _namespace_name "updatedAt" |> NamespacedName
    /// <summary>
    /// User who made the update
    /// <see href="https://open-metadata.org/ontology/updatedBy"></see></summary>
    let updatedBy = Namespaced_IRI.parse _namespace_name "updatedBy" |> NamespacedName

    /// <summary>
    /// Latest usage information for the entity
    /// <see href="https://open-metadata.org/ontology/usageSummary"></see></summary>
    let usageSummary =
        Namespaced_IRI.parse _namespace_name "usageSummary" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/uses"></see>
    /// </summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName

    /// <summary>
    /// AI application uses an MCP server for tools, resources or prompts
    /// <see href="https://open-metadata.org/ontology/usesMCPServer"></see></summary>
    let usesMCPServer =
        Namespaced_IRI.parse _namespace_name "usesMCPServer" |> NamespacedName

    /// <summary>
    /// AI application or agent execution uses an LLM model
    /// <see href="https://open-metadata.org/ontology/usesModel"></see></summary>
    let usesModel = Namespaced_IRI.parse _namespace_name "usesModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/usesPromptTemplate"></see>
    /// </summary>
    let usesPromptTemplate =
        Namespaced_IRI.parse _namespace_name "usesPromptTemplate" |> NamespacedName

    /// <summary>
    /// Degree to which data conforms to defined rules
    /// <see href="https://open-metadata.org/ontology/validity"></see></summary>
    let validity = Namespaced_IRI.parse _namespace_name "validity" |> NamespacedName
    /// <summary>
    /// Version identifier
    /// <see href="https://open-metadata.org/ontology/version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

    /// <summary>
    /// Notes about this version
    /// <see href="https://open-metadata.org/ontology/versionNotes"></see></summary>
    let versionNotes =
        Namespaced_IRI.parse _namespace_name "versionNotes" |> NamespacedName

    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/voted"></see>
    /// </summary>
    let voted = Namespaced_IRI.parse _namespace_name "voted" |> NamespacedName

    /// <summary>
    /// Source dataset this was derived from
    /// <see href="https://open-metadata.org/ontology/wasDerivedFrom"></see></summary>
    let wasDerivedFrom =
        Namespaced_IRI.parse _namespace_name "wasDerivedFrom" |> NamespacedName

    /// <summary>
    /// Activity that generated the dataset
    /// <see href="https://open-metadata.org/ontology/wasGeneratedBy"></see></summary>
    let wasGeneratedBy =
        Namespaced_IRI.parse _namespace_name "wasGeneratedBy" |> NamespacedName
