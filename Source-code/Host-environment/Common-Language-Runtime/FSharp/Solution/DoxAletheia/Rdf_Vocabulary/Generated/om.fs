namespace https.open_metadata.org.ontology.slash

open DoxAletheia

module om =
    let _namespace_name = "https://open-metadata.org/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// AI system such as a chatbot, agent, copilot, RAG application or multi-agent pipeline that may use multiple LLM models and tools
    /// <see href="https://open-metadata.org/ontology/AIApplication"></see></summary>
    let AIApplication = _prefix "AIApplication"
    /// <summary>
    /// Base class for all data assets
    /// <see href="https://open-metadata.org/ontology/DataAsset"></see></summary>
    let DataAsset = _prefix "DataAsset"
    /// <summary>
    /// Policy rules for AI/LLM usage, compliance, and risk management (model approval, data access, bias thresholds, cost controls, etc.)
    /// <see href="https://open-metadata.org/ontology/AIGovernancePolicy"></see></summary>
    let AIGovernancePolicy = _prefix "AIGovernancePolicy"
    /// <summary>
    /// Base class for all OpenMetadata entities
    /// <see href="https://open-metadata.org/ontology/Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Policy"></see>
    /// </summary>
    let Policy = _prefix "Policy"
    /// <summary>
    /// Collection of API endpoints
    /// <see href="https://open-metadata.org/ontology/APICollection"></see></summary>
    let APICollection = _prefix "APICollection"
    /// <summary>
    /// Documentation for API endpoints
    /// <see href="https://open-metadata.org/ontology/APIDocumentation"></see></summary>
    let APIDocumentation = _prefix "APIDocumentation"
    /// <summary>
    /// API endpoint providing data access service
    /// <see href="https://open-metadata.org/ontology/APIEndpoint"></see></summary>
    let APIEndpoint = _prefix "APIEndpoint"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/APIService"></see>
    /// </summary>
    let APIService = _prefix "APIService"
    /// <summary>
    /// Base class for all services
    /// <see href="https://open-metadata.org/ontology/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Single execution run of an AI agent, tracking inputs, outputs, lineage, metrics and errors for observability and governance
    /// <see href="https://open-metadata.org/ontology/AgentExecution"></see></summary>
    let AgentExecution = _prefix "AgentExecution"
    /// <summary>
    /// Certification status of an asset
    /// <see href="https://open-metadata.org/ontology/AssetCertification"></see></summary>
    let AssetCertification = _prefix "AssetCertification"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Bot"></see>
    /// </summary>
    let Bot = _prefix "Bot"
    /// <summary>
    /// Curated collection of metadata about resources
    /// <see href="https://open-metadata.org/ontology/Catalog"></see></summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    /// Metadata about when/how an entity was cataloged
    /// <see href="https://open-metadata.org/ontology/CatalogRecord"></see></summary>
    let CatalogRecord = _prefix "CatalogRecord"
    /// <summary>
    /// Description of changes that led to a version of an entity
    /// <see href="https://open-metadata.org/ontology/ChangeDescription"></see></summary>
    let ChangeDescription = _prefix "ChangeDescription"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Chart"></see>
    /// </summary>
    let Chart = _prefix "Chart"
    /// <summary>
    /// Tag Category
    /// <see href="https://open-metadata.org/ontology/Classification"></see></summary>
    let Classification = _prefix "Classification"
    /// <summary>
    /// Column in a table
    /// <see href="https://open-metadata.org/ontology/Column"></see></summary>
    let Column = _prefix "Column"
    /// <summary>
    /// Storage container organizing multiple datasets
    /// <see href="https://open-metadata.org/ontology/Container"></see></summary>
    let Container = _prefix "Container"
    /// <summary>
    /// Dashboard for data visualization
    /// <see href="https://open-metadata.org/ontology/Dashboard"></see></summary>
    let Dashboard = _prefix "Dashboard"
    /// <summary>
    /// Dashboard Data Model entity to capture the data models used by dashboards
    /// <see href="https://open-metadata.org/ontology/DashboardDataModel"></see></summary>
    let DashboardDataModel = _prefix "DashboardDataModel"
    /// <summary>
    /// Dashboard data model column context type used to attach custom properties to columns of a DashboardDataModel
    /// <see href="https://open-metadata.org/ontology/DashboardDataModelColumn"></see></summary>
    let DashboardDataModelColumn = _prefix "DashboardDataModelColumn"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DashboardService"></see>
    /// </summary>
    let DashboardService = _prefix "DashboardService"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DataContract"></see>
    /// </summary>
    let DataContract = _prefix "DataContract"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DataProduct"></see>
    /// </summary>
    let DataProduct = _prefix "DataProduct"
    /// <summary>
    /// Service Level Agreement for a data product
    /// <see href="https://open-metadata.org/ontology/DataProductSLA"></see></summary>
    let DataProductSLA = _prefix "DataProductSLA"
    /// <summary>
    /// Service that provides access to data
    /// <see href="https://open-metadata.org/ontology/DataService"></see></summary>
    let DataService = _prefix "DataService"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Database"></see>
    /// </summary>
    let Database = _prefix "Database"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DatabaseSchema"></see>
    /// </summary>
    let DatabaseSchema = _prefix "DatabaseSchema"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/DatabaseService"></see>
    /// </summary>
    let DatabaseService = _prefix "DatabaseService"
    /// <summary>
    /// Collection of related datasets, e.g., time series or versions
    /// <see href="https://open-metadata.org/ontology/DatasetSeries"></see></summary>
    let DatasetSeries = _prefix "DatasetSeries"
    /// <summary>
    /// File system directory
    /// <see href="https://open-metadata.org/ontology/Directory"></see></summary>
    let Directory = _prefix "Directory"
    /// <summary>
    /// Specific representation of a dataset
    /// <see href="https://open-metadata.org/ontology/Distribution"></see></summary>
    let Distribution = _prefix "Distribution"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Domain"></see>
    /// </summary>
    let Domain = _prefix "Domain"
    /// <summary>
    /// File and document storage service
    /// <see href="https://open-metadata.org/ontology/DriveService"></see></summary>
    let DriveService = _prefix "DriveService"
    /// <summary>
    /// Current status of an entity (Active, Deleted, Draft)
    /// <see href="https://open-metadata.org/ontology/EntityStatus"></see></summary>
    let EntityStatus = _prefix "EntityStatus"
    /// <summary>
    /// Individual file
    /// <see href="https://open-metadata.org/ontology/File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    /// Update frequency specification
    /// <see href="https://open-metadata.org/ontology/Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Glossary"></see>
    /// </summary>
    let Glossary = _prefix "Glossary"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/GlossaryTerm"></see>
    /// </summary>
    let GlossaryTerm = _prefix "GlossaryTerm"
    /// <summary>
    /// Input port of a data product for consuming data
    /// <see href="https://open-metadata.org/ontology/InputPort"></see></summary>
    let InputPort = _prefix "InputPort"
    /// <summary>
    /// Registered Large Language Model deployment, fine-tune, or base model referenced by AI applications and agents
    /// <see href="https://open-metadata.org/ontology/LLMModel"></see></summary>
    let LLMModel = _prefix "LLMModel"
    /// <summary>
    /// Service managing Large Language Model providers (OpenAI, Anthropic, Bedrock, VertexAI, Ollama, etc.)
    /// <see href="https://open-metadata.org/ontology/LLMService"></see></summary>
    let LLMService = _prefix "LLMService"
    /// <summary>
    /// Learning resource such as an in-product tutorial, Storylane walkthrough, video or article contextualized for product surfaces
    /// <see href="https://open-metadata.org/ontology/LearningResource"></see></summary>
    let LearningResource = _prefix "LearningResource"
    /// <summary>
    /// Legal document giving permissions
    /// <see href="https://open-metadata.org/ontology/LicenseDocument"></see></summary>
    let LicenseDocument = _prefix "LicenseDocument"
    /// <summary>
    /// Life cycle properties of an entity including created, updated, accessed timestamps
    /// <see href="https://open-metadata.org/ontology/LifeCycle"></see></summary>
    let LifeCycle = _prefix "LifeCycle"
    /// <summary>
    /// Spatial region or location
    /// <see href="https://open-metadata.org/ontology/Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Single execution session of an MCP server, tracking tool calls, resource accesses, prompt uses and data lineage for audit and compliance
    /// <see href="https://open-metadata.org/ontology/MCPExecution"></see></summary>
    let MCPExecution = _prefix "MCPExecution"
    /// <summary>
    /// Model Context Protocol server deployment that exposes tools, resources and prompts to AI applications
    /// <see href="https://open-metadata.org/ontology/MCPServer"></see></summary>
    let MCPServer = _prefix "MCPServer"
    /// <summary>
    /// Service for discovering and managing MCP (Model Context Protocol) servers
    /// <see href="https://open-metadata.org/ontology/MCPService"></see></summary>
    let MCPService = _prefix "MCPService"
    /// <summary>
    /// Machine learning model providing inference service
    /// <see href="https://open-metadata.org/ontology/MLModel"></see></summary>
    let MLModel = _prefix "MLModel"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/MLModelService"></see>
    /// </summary>
    let MLModelService = _prefix "MLModelService"
    /// <summary>
    /// Media type or format
    /// <see href="https://open-metadata.org/ontology/MediaType"></see></summary>
    let MediaType = _prefix "MediaType"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/MessagingService"></see>
    /// </summary>
    let MessagingService = _prefix "MessagingService"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/MetadataService"></see>
    /// </summary>
    let MetadataService = _prefix "MetadataService"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Metric"></see>
    /// </summary>
    let Metric = _prefix "Metric"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/ObservabilityService"></see>
    /// </summary>
    let ObservabilityService = _prefix "ObservabilityService"
    /// <summary>
    /// Organization entity
    /// <see href="https://open-metadata.org/ontology/Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// Output port of a data product for exposing data
    /// <see href="https://open-metadata.org/ontology/OutputPort"></see></summary>
    let OutputPort = _prefix "OutputPort"
    /// <summary>
    /// Time period specification
    /// <see href="https://open-metadata.org/ontology/PeriodOfTime"></see></summary>
    let PeriodOfTime = _prefix "PeriodOfTime"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Pipeline"></see>
    /// </summary>
    let Pipeline = _prefix "Pipeline"
    /// <summary>
    /// ETL Service
    /// <see href="https://open-metadata.org/ontology/PipelineService"></see></summary>
    let PipelineService = _prefix "PipelineService"
    /// <summary>
    /// Status of a pipeline execution
    /// <see href="https://open-metadata.org/ontology/PipelineStatus"></see></summary>
    let PipelineStatus = _prefix "PipelineStatus"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Post"></see>
    /// </summary>
    let Post = _prefix "Post"
    /// <summary>
    /// Configuration for table profiling
    /// <see href="https://open-metadata.org/ontology/ProfilerConfig"></see></summary>
    let ProfilerConfig = _prefix "ProfilerConfig"
    /// <summary>
    /// Reusable prompt template with variables, system prompts and examples for consistent AI behavior
    /// <see href="https://open-metadata.org/ontology/PromptTemplate"></see></summary>
    let PromptTemplate = _prefix "PromptTemplate"
    /// <summary>
    /// Relationship with additional context like role, time, etc.
    /// <see href="https://open-metadata.org/ontology/QualifiedRelationship"></see></summary>
    let QualifiedRelationship = _prefix "QualifiedRelationship"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/QualityService"></see>
    /// </summary>
    let QualityService = _prefix "QualityService"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Query"></see>
    /// </summary>
    let Query = _prefix "Query"
    /// <summary>
    /// Report as a specific representation of data
    /// <see href="https://open-metadata.org/ontology/Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/ReportingService"></see>
    /// </summary>
    let ReportingService = _prefix "ReportingService"
    /// <summary>
    /// Any resource cataloged in OpenMetadata
    /// <see href="https://open-metadata.org/ontology/Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// Statement about intellectual property rights
    /// <see href="https://open-metadata.org/ontology/RightsStatement"></see></summary>
    let RightsStatement = _prefix "RightsStatement"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/SearchIndex"></see>
    /// </summary>
    let SearchIndex = _prefix "SearchIndex"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/SearchService"></see>
    /// </summary>
    let SearchService = _prefix "SearchService"
    /// <summary>
    /// Spreadsheet document
    /// <see href="https://open-metadata.org/ontology/Spreadsheet"></see></summary>
    let Spreadsheet = _prefix "Spreadsheet"
    /// <summary>
    /// Technical standard or specification
    /// <see href="https://open-metadata.org/ontology/Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/StorageService"></see>
    /// </summary>
    let StorageService = _prefix "StorageService"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/StoredProcedure"></see>
    /// </summary>
    let StoredProcedure = _prefix "StoredProcedure"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Table"></see>
    /// </summary>
    let Table = _prefix "Table"
    /// <summary>
    /// Table column context type used to attach custom properties to columns of a Table
    /// <see href="https://open-metadata.org/ontology/TableColumn"></see></summary>
    let TableColumn = _prefix "TableColumn"
    /// <summary>
    /// Profile data for a table including statistics
    /// <see href="https://open-metadata.org/ontology/TableProfile"></see></summary>
    let TableProfile = _prefix "TableProfile"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Tag"></see>
    /// </summary>
    let Tag = _prefix "Tag"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Task"></see>
    /// </summary>
    let Task = _prefix "Task"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Team"></see>
    /// </summary>
    let Team = _prefix "Team"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/TestCase"></see>
    /// </summary>
    let TestCase = _prefix "TestCase"
    /// <summary>
    /// Parameter definition for a test case
    /// <see href="https://open-metadata.org/ontology/TestCaseParameter"></see></summary>
    let TestCaseParameter = _prefix "TestCaseParameter"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/TestDefinition"></see>
    /// </summary>
    let TestDefinition = _prefix "TestDefinition"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/TestSuite"></see>
    /// </summary>
    let TestSuite = _prefix "TestSuite"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/Thread"></see>
    /// </summary>
    let Thread = _prefix "Thread"
    /// <summary>
    /// Message topic providing streaming data access
    /// <see href="https://open-metadata.org/ontology/Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/User"></see>
    /// </summary>
    let User = _prefix "User"
    /// <summary>
    /// Votes on an entity (upvotes and downvotes)
    /// <see href="https://open-metadata.org/ontology/Votes"></see></summary>
    let Votes = _prefix "Votes"
    /// <summary>
    /// Worksheet within a spreadsheet
    /// <see href="https://open-metadata.org/ontology/Worksheet"></see></summary>
    let Worksheet = _prefix "Worksheet"
    /// <summary>
    /// Information about access restrictions
    /// <see href="https://open-metadata.org/ontology/accessRights"></see></summary>
    let accessRights = _prefix "accessRights"
    /// <summary>
    /// URL to access the distribution
    /// <see href="https://open-metadata.org/ontology/accessURL"></see></summary>
    let accessURL = _prefix "accessURL"
    /// <summary>
    /// Frequency of dataset updates
    /// <see href="https://open-metadata.org/ontology/accrualPeriodicity"></see></summary>
    let accrualPeriodicity = _prefix "accrualPeriodicity"
    /// <summary>
    /// Degree of data accuracy
    /// <see href="https://open-metadata.org/ontology/accuracy"></see></summary>
    let accuracy = _prefix "accuracy"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/addressedTo"></see>
    /// </summary>
    let addressedTo = _prefix "addressedTo"
    /// <summary>
    /// Link to API documentation
    /// <see href="https://open-metadata.org/ontology/apiDocumentation"></see></summary>
    let apiDocumentation = _prefix "apiDocumentation"
    /// <summary>
    /// Type of AI application (Chatbot, Agent, Copilot, Assistant, RAG, CodeGenerator, DataAnalyst, AutomationBot, MultiAgent, Custom)
    /// <see href="https://open-metadata.org/ontology/applicationType"></see></summary>
    let applicationType = _prefix "applicationType"
    /// <summary>
    /// Tag or classification applied to entity
    /// <see href="https://open-metadata.org/ontology/appliedTo"></see></summary>
    let appliedTo = _prefix "appliedTo"
    /// <summary>
    /// Base model this model was trained or fine-tuned from
    /// <see href="https://open-metadata.org/ontology/baseModel"></see></summary>
    let baseModel = _prefix "baseModel"
    /// <summary>
    /// Geographic bounding box
    /// <see href="https://open-metadata.org/ontology/bbox"></see></summary>
    let bbox = _prefix "bbox"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/belongsToDatabase"></see>
    /// </summary>
    let belongsToDatabase = _prefix "belongsToDatabase"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/belongsToSchema"></see>
    /// </summary>
    let belongsToSchema = _prefix "belongsToSchema"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/belongsToService"></see>
    /// </summary>
    let belongsToService = _prefix "belongsToService"
    /// <summary>
    /// Size in bytes
    /// <see href="https://open-metadata.org/ontology/byteSize"></see></summary>
    let byteSize = _prefix "byteSize"
    /// <summary>
    /// Sub-catalog
    /// <see href="https://open-metadata.org/ontology/catalog"></see></summary>
    let catalog = _prefix "catalog"
    /// <summary>
    /// Date when entity was added to catalog
    /// <see href="https://open-metadata.org/ontology/cataloged"></see></summary>
    let cataloged = _prefix "cataloged"
    /// <summary>
    /// Geographic center point
    /// <see href="https://open-metadata.org/ontology/centroid"></see></summary>
    let centroid = _prefix "centroid"
    /// <summary>
    /// Tag label for the certification
    /// <see href="https://open-metadata.org/ontology/certificationTagLabel"></see></summary>
    let certificationTagLabel = _prefix "certificationTagLabel"
    /// <summary>
    /// Checksum for data integrity verification
    /// <see href="https://open-metadata.org/ontology/checksum"></see></summary>
    let checksum = _prefix "checksum"
    /// <summary>
    /// Number of columns in the table
    /// <see href="https://open-metadata.org/ontology/columnCount"></see></summary>
    let columnCount = _prefix "columnCount"
    /// <summary>
    /// Data type of the column
    /// <see href="https://open-metadata.org/ontology/columnDataType"></see></summary>
    let columnDataType = _prefix "columnDataType"
    /// <summary>
    /// Description of what the column contains
    /// <see href="https://open-metadata.org/ontology/columnDescription"></see></summary>
    let columnDescription = _prefix "columnDescription"
    /// <summary>
    /// Degree of data completeness
    /// <see href="https://open-metadata.org/ontology/completeness"></see></summary>
    let completeness = _prefix "completeness"
    /// <summary>
    /// Compression format of the distribution
    /// <see href="https://open-metadata.org/ontology/compressFormat"></see></summary>
    let compressFormat = _prefix "compressFormat"
    /// <summary>
    /// Concurrency level of the pipeline
    /// <see href="https://open-metadata.org/ontology/concurrency"></see></summary>
    let concurrency = _prefix "concurrency"
    /// <summary>
    /// Standard or schema that the resource conforms to
    /// <see href="https://open-metadata.org/ontology/conformsTo"></see></summary>
    let conformsTo = _prefix "conformsTo"
    /// <summary>
    /// Standard the dataset conforms to
    /// <see href="https://open-metadata.org/ontology/conformsToStandard"></see></summary>
    let conformsToStandard = _prefix "conformsToStandard"
    /// <summary>
    /// Degree of data consistency
    /// <see href="https://open-metadata.org/ontology/consistency"></see></summary>
    let consistency = _prefix "consistency"
    /// <summary>
    /// Data products that this product consumes data from
    /// <see href="https://open-metadata.org/ontology/consumesFrom"></see></summary>
    let consumesFrom = _prefix "consumesFrom"
    /// <summary>
    /// Contact information for the dataset
    /// <see href="https://open-metadata.org/ontology/contactPoint"></see></summary>
    let contactPoint = _prefix "contactPoint"
    /// <summary>
    /// Hierarchical containment relationship
    /// <see href="https://open-metadata.org/ontology/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/containsPosts"></see>
    /// </summary>
    let containsPosts = _prefix "containsPosts"
    /// <summary>
    /// Entity responsible for contributions to the dataset
    /// <see href="https://open-metadata.org/ontology/contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/created"></see>
    /// </summary>
    let created = _prefix "created"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/createdBy"></see>
    /// </summary>
    let createdBy = _prefix "createdBy"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/creates"></see>
    /// </summary>
    let creates = _prefix "creates"
    /// <summary>
    /// Entity primarily responsible for creating the dataset
    /// <see href="https://open-metadata.org/ontology/creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// Type of data model (TableauDataModel, SupersetDataModel, MetabaseDataModel, LookMlView, LookMlExplore, PowerBIDataModel, QlikDataModel)
    /// <see href="https://open-metadata.org/ontology/dataModelType"></see></summary>
    let dataModelType = _prefix "dataModelType"
    /// <summary>
    /// Assets that are part of this data product
    /// <see href="https://open-metadata.org/ontology/dataProductAssets"></see></summary>
    let dataProductAssets = _prefix "dataProductAssets"
    /// <summary>
    /// Domain this data product belongs to
    /// <see href="https://open-metadata.org/ontology/dataProductDomain"></see></summary>
    let dataProductDomain = _prefix "dataProductDomain"
    /// <summary>
    /// Expert for this data product
    /// <see href="https://open-metadata.org/ontology/dataProductExpert"></see></summary>
    let dataProductExpert = _prefix "dataProductExpert"
    /// <summary>
    /// Owner of the data product
    /// <see href="https://open-metadata.org/ontology/dataProductOwner"></see></summary>
    let dataProductOwner = _prefix "dataProductOwner"
    /// <summary>
    /// Data quality dimension (Completeness, Accuracy, Consistency, Validity, Uniqueness, Integrity, SQL)
    /// <see href="https://open-metadata.org/ontology/dataQualityDimension"></see></summary>
    let dataQualityDimension = _prefix "dataQualityDimension"
    /// <summary>
    /// Dataset that is part of the catalog
    /// <see href="https://open-metadata.org/ontology/dataset"></see></summary>
    let dataset = _prefix "dataset"
    /// <summary>
    /// Default value relationship
    /// <see href="https://open-metadata.org/ontology/defaultsTo"></see></summary>
    let defaultsTo = _prefix "defaultsTo"
    /// <summary>
    /// Whether the entity has been soft deleted
    /// <see href="https://open-metadata.org/ontology/deleted"></see></summary>
    let deleted = _prefix "deleted"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/developmentStage"></see>
    /// </summary>
    let developmentStage = _prefix "developmentStage"
    /// <summary>
    /// Dimension represented in the dataset
    /// <see href="https://open-metadata.org/ontology/dimension"></see></summary>
    let dimension = _prefix "dimension"
    /// <summary>
    /// Available distribution of the dataset
    /// <see href="https://open-metadata.org/ontology/distribution"></see></summary>
    let distribution = _prefix "distribution"
    /// <summary>
    /// Number of down votes
    /// <see href="https://open-metadata.org/ontology/downVotes"></see></summary>
    let downVotes = _prefix "downVotes"
    /// <summary>
    /// Direct download URL
    /// <see href="https://open-metadata.org/ontology/downloadURL"></see></summary>
    let downloadURL = _prefix "downloadURL"
    /// <summary>
    /// Data lineage downstream relationship
    /// <see href="https://open-metadata.org/ontology/downstream"></see></summary>
    let downstream = _prefix "downstream"
    /// <summary>
    /// Data lineage upstream relationship
    /// <see href="https://open-metadata.org/ontology/upstream"></see></summary>
    let upstream = _prefix "upstream"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/editedBy"></see>
    /// </summary>
    let editedBy = _prefix "editedBy"
    /// <summary>
    /// End of the temporal period
    /// <see href="https://open-metadata.org/ontology/endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/endpointDescription"></see>
    /// </summary>
    let endpointDescription = _prefix "endpointDescription"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/endpointURL"></see>
    /// </summary>
    let endpointURL = _prefix "endpointURL"
    /// <summary>
    /// Agent execution was an execution of this AI application
    /// <see href="https://open-metadata.org/ontology/executedAgent"></see></summary>
    let executedAgent = _prefix "executedAgent"
    /// <summary>
    /// MCP execution was an execution of this MCP server
    /// <see href="https://open-metadata.org/ontology/executedMCPServer"></see></summary>
    let executedMCPServer = _prefix "executedMCPServer"
    /// <summary>
    /// Status of an agent or MCP execution (Running, Success, Failed, Timeout, Cancelled, PartialSuccess)
    /// <see href="https://open-metadata.org/ontology/executionStatus"></see></summary>
    let executionStatus = _prefix "executionStatus"
    /// <summary>
    /// User is expert on entity
    /// <see href="https://open-metadata.org/ontology/expert"></see></summary>
    let expert = _prefix "expert"
    /// <summary>
    /// First dataset in a series
    /// <see href="https://open-metadata.org/ontology/first"></see></summary>
    let first = _prefix "first"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/follows"></see>
    /// </summary>
    let follows = _prefix "follows"
    /// <summary>
    /// File format of the distribution
    /// <see href="https://open-metadata.org/ontology/format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// Source column used in transformation
    /// <see href="https://open-metadata.org/ontology/fromColumn"></see></summary>
    let fromColumn = _prefix "fromColumn"
    /// <summary>
    /// Unique identifier for the entity within OpenMetadata
    /// <see href="https://open-metadata.org/ontology/fullyQualifiedName"></see></summary>
    let fullyQualifiedName = _prefix "fullyQualifiedName"
    /// <summary>
    /// Geometry of the spatial area
    /// <see href="https://open-metadata.org/ontology/geometry"></see></summary>
    let geometry = _prefix "geometry"
    /// <summary>
    /// AI application, LLM model or MCP server is governed by an AI governance policy
    /// <see href="https://open-metadata.org/ontology/governedBy"></see></summary>
    let governedBy = _prefix "governedBy"
    /// <summary>
    /// Role in a qualified relationship
    /// <see href="https://open-metadata.org/ontology/hadRole"></see></summary>
    let hadRole = _prefix "hadRole"
    /// <summary>
    /// General possession relationship
    /// <see href="https://open-metadata.org/ontology/has"></see></summary>
    let has = _prefix "has"
    /// <summary>
    /// Beginning instant of the temporal period
    /// <see href="https://open-metadata.org/ontology/hasBeginning"></see></summary>
    let hasBeginning = _prefix "hasBeginning"
    /// <summary>
    /// Certification status of the asset
    /// <see href="https://open-metadata.org/ontology/hasCertification"></see></summary>
    let hasCertification = _prefix "hasCertification"
    /// <summary>
    /// Change that led to this version of the entity
    /// <see href="https://open-metadata.org/ontology/hasChangeDescription"></see></summary>
    let hasChangeDescription = _prefix "hasChangeDescription"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/hasColumn"></see>
    /// </summary>
    let hasColumn = _prefix "hasColumn"
    /// <summary>
    /// Data products this entity is part of
    /// <see href="https://open-metadata.org/ontology/hasDataProducts"></see></summary>
    let hasDataProducts = _prefix "hasDataProducts"
    /// <summary>
    /// Domains the entity belongs to
    /// <see href="https://open-metadata.org/ontology/hasDomains"></see></summary>
    let hasDomains = _prefix "hasDomains"
    /// <summary>
    /// Ending instant of the temporal period
    /// <see href="https://open-metadata.org/ontology/hasEnd"></see></summary>
    let hasEnd = _prefix "hasEnd"
    /// <summary>
    /// Current status of the entity
    /// <see href="https://open-metadata.org/ontology/hasEntityStatus"></see></summary>
    let hasEntityStatus = _prefix "hasEntityStatus"
    /// <summary>
    /// Users who follow this entity
    /// <see href="https://open-metadata.org/ontology/hasFollowers"></see></summary>
    let hasFollowers = _prefix "hasFollowers"
    /// <summary>
    /// Incremental change that led to this version
    /// <see href="https://open-metadata.org/ontology/hasIncrementalChangeDescription"></see></summary>
    let hasIncrementalChangeDescription = _prefix "hasIncrementalChangeDescription"
    /// <summary>
    /// Input port of the data product
    /// <see href="https://open-metadata.org/ontology/hasInputPort"></see></summary>
    let hasInputPort = _prefix "hasInputPort"
    /// <summary>
    /// Life cycle properties of the entity
    /// <see href="https://open-metadata.org/ontology/hasLifeCycle"></see></summary>
    let hasLifeCycle = _prefix "hasLifeCycle"
    /// <summary>
    /// Output port of the data product
    /// <see href="https://open-metadata.org/ontology/hasOutputPort"></see></summary>
    let hasOutputPort = _prefix "hasOutputPort"
    /// <summary>
    /// Agent responsible for the entity
    /// <see href="https://open-metadata.org/ontology/hasOwner"></see></summary>
    let hasOwner = _prefix "hasOwner"
    /// <summary>
    /// Owners of this entity (plural)
    /// <see href="https://open-metadata.org/ontology/hasOwners"></see></summary>
    let hasOwners = _prefix "hasOwners"
    /// <summary>
    /// Parameter definitions for a test
    /// <see href="https://open-metadata.org/ontology/hasParameterDefinition"></see></summary>
    let hasParameterDefinition = _prefix "hasParameterDefinition"
    /// <summary>
    /// Latest status of the pipeline
    /// <see href="https://open-metadata.org/ontology/hasPipelineStatus"></see></summary>
    let hasPipelineStatus = _prefix "hasPipelineStatus"
    /// <summary>
    /// ODRL policy associated with the dataset
    /// <see href="https://open-metadata.org/ontology/hasPolicy"></see></summary>
    let hasPolicy = _prefix "hasPolicy"
    /// <summary>
    /// Latest profile data for the table
    /// <see href="https://open-metadata.org/ontology/hasProfile"></see></summary>
    let hasProfile = _prefix "hasProfile"
    /// <summary>
    /// Profiler configuration for the table
    /// <see href="https://open-metadata.org/ontology/hasProfilerConfig"></see></summary>
    let hasProfilerConfig = _prefix "hasProfilerConfig"
    /// <summary>
    /// Quality annotation for the dataset
    /// <see href="https://open-metadata.org/ontology/hasQualityAnnotation"></see></summary>
    let hasQualityAnnotation = _prefix "hasQualityAnnotation"
    /// <summary>
    /// Quality measurement for the dataset
    /// <see href="https://open-metadata.org/ontology/hasQualityMeasurement"></see></summary>
    let hasQualityMeasurement = _prefix "hasQualityMeasurement"
    /// <summary>
    /// Service Level Agreement for the data product
    /// <see href="https://open-metadata.org/ontology/hasSLA"></see></summary>
    let hasSLA = _prefix "hasSLA"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/hasTag"></see>
    /// </summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/hasVersion"></see>
    /// </summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// Links to the non-versioned or abstract dataset
    /// <see href="https://open-metadata.org/ontology/isVersionOf"></see></summary>
    let isVersionOf = _prefix "isVersionOf"
    /// <summary>
    /// Votes on the entity
    /// <see href="https://open-metadata.org/ontology/hasVotes"></see></summary>
    let hasVotes = _prefix "hasVotes"
    /// <summary>
    /// Homepage of the catalog
    /// <see href="https://open-metadata.org/ontology/homepage"></see></summary>
    let homepage = _prefix "homepage"
    /// <summary>
    /// Unique identifier of the dataset
    /// <see href="https://open-metadata.org/ontology/identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// Bot user that performed the action on behalf of the actual user
    /// <see href="https://open-metadata.org/ontology/impersonatedBy"></see></summary>
    let impersonatedBy = _prefix "impersonatedBy"
    /// <summary>
    /// Links a dataset to its series
    /// <see href="https://open-metadata.org/ontology/inSeries"></see></summary>
    let inSeries = _prefix "inSeries"
    /// <summary>
    /// Thread or post is about an entity
    /// <see href="https://open-metadata.org/ontology/isAbout"></see></summary>
    let isAbout = _prefix "isAbout"
    /// <summary>
    /// Whether this column can contain null values
    /// <see href="https://open-metadata.org/ontology/isNullable"></see></summary>
    let isNullable = _prefix "isNullable"
    /// <summary>
    /// Whether this column is a primary key
    /// <see href="https://open-metadata.org/ontology/isPrimaryKey"></see></summary>
    let isPrimaryKey = _prefix "isPrimaryKey"
    /// <summary>
    /// Related resource that references this dataset
    /// <see href="https://open-metadata.org/ontology/isReferencedBy"></see></summary>
    let isReferencedBy = _prefix "isReferencedBy"
    /// <summary>
    /// Date of formal issuance
    /// <see href="https://open-metadata.org/ontology/issued"></see></summary>
    let issued = _prefix "issued"
    /// <summary>
    /// Join relationship between tables
    /// <see href="https://open-metadata.org/ontology/joinedWith"></see></summary>
    let joinedWith = _prefix "joinedWith"
    /// <summary>
    /// Keywords describing the dataset
    /// <see href="https://open-metadata.org/ontology/keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// Web page providing access and information
    /// <see href="https://open-metadata.org/ontology/landingPage"></see></summary>
    let landingPage = _prefix "landingPage"
    /// <summary>
    /// Language of the dataset
    /// <see href="https://open-metadata.org/ontology/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Last dataset in a series
    /// <see href="https://open-metadata.org/ontology/last"></see></summary>
    let last = _prefix "last"
    /// <summary>
    /// License under which the dataset is available
    /// <see href="https://open-metadata.org/ontology/license"></see></summary>
    let license = _prefix "license"
    /// <summary>
    /// Access details when entity was last accessed
    /// <see href="https://open-metadata.org/ontology/lifeCycleAccessed"></see></summary>
    let lifeCycleAccessed = _prefix "lifeCycleAccessed"
    /// <summary>
    /// Access details when entity was created
    /// <see href="https://open-metadata.org/ontology/lifeCycleCreated"></see></summary>
    let lifeCycleCreated = _prefix "lifeCycleCreated"
    /// <summary>
    /// Access details when entity was last updated
    /// <see href="https://open-metadata.org/ontology/lifeCycleUpdated"></see></summary>
    let lifeCycleUpdated = _prefix "lifeCycleUpdated"
    /// <summary>
    /// Current lifecycle stage (IDEATION, DESIGN, DEVELOPMENT, TESTING, PRODUCTION, DEPRECATED, RETIRED)
    /// <see href="https://open-metadata.org/ontology/lifecycleStage"></see></summary>
    let lifecycleStage = _prefix "lifecycleStage"
    /// <summary>
    /// When the lineage was created
    /// <see href="https://open-metadata.org/ontology/lineageCreatedAt"></see></summary>
    let lineageCreatedAt = _prefix "lineageCreatedAt"
    /// <summary>
    /// User who created the lineage
    /// <see href="https://open-metadata.org/ontology/lineageCreatedBy"></see></summary>
    let lineageCreatedBy = _prefix "lineageCreatedBy"
    /// <summary>
    /// How the lineage was created (Manual, Pipeline, Query, etc.)
    /// <see href="https://open-metadata.org/ontology/lineageSource"></see></summary>
    let lineageSource = _prefix "lineageSource"
    /// <summary>
    /// Measure represented in the dataset
    /// <see href="https://open-metadata.org/ontology/measure"></see></summary>
    let measure = _prefix "measure"
    /// <summary>
    /// Media type of the distribution
    /// <see href="https://open-metadata.org/ontology/mediaType"></see></summary>
    let mediaType = _prefix "mediaType"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/memberOf"></see>
    /// </summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// Entity is mentioned in a post or thread
    /// <see href="https://open-metadata.org/ontology/mentionedIn"></see></summary>
    let mentionedIn = _prefix "mentionedIn"
    /// <summary>
    /// Capability exposed by the LLM model (TextGeneration, CodeGeneration, Embeddings, Chat, Vision, Audio, FunctionCalling, ToolUse)
    /// <see href="https://open-metadata.org/ontology/modelCapability"></see></summary>
    let modelCapability = _prefix "modelCapability"
    /// <summary>
    /// Type of LLM model (BaseModel, FineTuned, Quantized, Distilled, Adapter, Custom)
    /// <see href="https://open-metadata.org/ontology/modelType"></see></summary>
    let modelType = _prefix "modelType"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/modified"></see>
    /// </summary>
    let modified = _prefix "modified"
    /// <summary>
    /// Next dataset in a series
    /// <see href="https://open-metadata.org/ontology/next"></see></summary>
    let next = _prefix "next"
    /// <summary>
    /// Number of columns in the dataset
    /// <see href="https://open-metadata.org/ontology/numberOfColumns"></see></summary>
    let numberOfColumns = _prefix "numberOfColumns"
    /// <summary>
    /// Number of records in the dataset
    /// <see href="https://open-metadata.org/ontology/numberOfRecords"></see></summary>
    let numberOfRecords = _prefix "numberOfRecords"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/owns"></see>
    /// </summary>
    let owns = _prefix "owns"
    /// <summary>
    /// Package format of the distribution
    /// <see href="https://open-metadata.org/ontology/packageFormat"></see></summary>
    let packageFormat = _prefix "packageFormat"
    /// <summary>
    /// Hierarchical parent relationship
    /// <see href="https://open-metadata.org/ontology/parentOf"></see></summary>
    let parentOf = _prefix "parentOf"
    /// <summary>
    /// Pipeline that processes the data
    /// <see href="https://open-metadata.org/ontology/pipeline"></see></summary>
    let pipeline = _prefix "pipeline"
    /// <summary>
    /// Pipeline code location
    /// <see href="https://open-metadata.org/ontology/pipelineLocation"></see></summary>
    let pipelineLocation = _prefix "pipelineLocation"
    /// <summary>
    /// Type of AI governance policy (ModelApproval, DataAccess, BiasThreshold, ComplianceCheck, CostControl, PerformanceStandard, SecurityControl)
    /// <see href="https://open-metadata.org/ontology/policyType"></see></summary>
    let policyType = _prefix "policyType"
    /// <summary>
    /// Data asset exposed through this port
    /// <see href="https://open-metadata.org/ontology/portDataAsset"></see></summary>
    let portDataAsset = _prefix "portDataAsset"
    /// <summary>
    /// Endpoint URL or connection string for the port
    /// <see href="https://open-metadata.org/ontology/portEndpoint"></see></summary>
    let portEndpoint = _prefix "portEndpoint"
    /// <summary>
    /// Data format supported by the port (JSON, CSV, PARQUET, etc.)
    /// <see href="https://open-metadata.org/ontology/portFormat"></see></summary>
    let portFormat = _prefix "portFormat"
    /// <summary>
    /// Name of the port
    /// <see href="https://open-metadata.org/ontology/portName"></see></summary>
    let portName = _prefix "portName"
    /// <summary>
    /// Protocol used by the port (REST, GRPC, KAFKA, etc.)
    /// <see href="https://open-metadata.org/ontology/portProtocol"></see></summary>
    let portProtocol = _prefix "portProtocol"
    /// <summary>
    /// Previous dataset in a series
    /// <see href="https://open-metadata.org/ontology/prev"></see></summary>
    let prev = _prefix "prev"
    /// <summary>
    /// Link to previous version
    /// <see href="https://open-metadata.org/ontology/previousVersion"></see></summary>
    let previousVersion = _prefix "previousVersion"
    /// <summary>
    /// Main entity described by this record
    /// <see href="https://open-metadata.org/ontology/primaryTopic"></see></summary>
    let primaryTopic = _prefix "primaryTopic"
    /// <summary>
    /// Whether lineage has been processed for this entity
    /// <see href="https://open-metadata.org/ontology/processedLineage"></see></summary>
    let processedLineage = _prefix "processedLineage"
    /// <summary>
    /// Provenance statement
    /// <see href="https://open-metadata.org/ontology/provenance"></see></summary>
    let provenance = _prefix "provenance"
    /// <summary>
    /// Data products that consume data from this product
    /// <see href="https://open-metadata.org/ontology/providesTo"></see></summary>
    let providesTo = _prefix "providesTo"
    /// <summary>
    /// Entity responsible for making the dataset available
    /// <see href="https://open-metadata.org/ontology/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// Qualified access information including authentication and authorization
    /// <see href="https://open-metadata.org/ontology/qualifiedAccess"></see></summary>
    let qualifiedAccess = _prefix "qualifiedAccess"
    /// <summary>
    /// Detailed attribution with roles
    /// <see href="https://open-metadata.org/ontology/qualifiedAttribution"></see></summary>
    let qualifiedAttribution = _prefix "qualifiedAttribution"
    /// <summary>
    /// Detailed derivation with transformation info
    /// <see href="https://open-metadata.org/ontology/qualifiedDerivation"></see></summary>
    let qualifiedDerivation = _prefix "qualifiedDerivation"
    /// <summary>
    /// Link to a qualified relationship
    /// <see href="https://open-metadata.org/ontology/qualifiedRelation"></see></summary>
    let qualifiedRelation = _prefix "qualifiedRelation"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/reactedTo"></see>
    /// </summary>
    let reactedTo = _prefix "reactedTo"
    /// <summary>
    /// Links catalog to its records
    /// <see href="https://open-metadata.org/ontology/record"></see></summary>
    let record = _prefix "record"
    /// <summary>
    /// General relationship between entities
    /// <see href="https://open-metadata.org/ontology/relatedTo"></see></summary>
    let relatedTo = _prefix "relatedTo"
    /// <summary>
    /// Alternative spelling of relatedTo
    /// <see href="https://open-metadata.org/ontology/relatesTo"></see></summary>
    let relatesTo = _prefix "relatesTo"
    /// <summary>
    /// Related resource
    /// <see href="https://open-metadata.org/ontology/relation"></see></summary>
    let relation = _prefix "relation"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/repliedTo"></see>
    /// </summary>
    let repliedTo = _prefix "repliedTo"
    /// <summary>
    /// Primary topic grouping (Discovery, Administration, DataGovernance, DataQuality, Observability, AI)
    /// <see href="https://open-metadata.org/ontology/resourceCategory"></see></summary>
    let resourceCategory = _prefix "resourceCategory"
    /// <summary>
    /// Suggested proficiency tier (Intro, Intermediate, Advanced)
    /// <see href="https://open-metadata.org/ontology/resourceDifficulty"></see></summary>
    let resourceDifficulty = _prefix "resourceDifficulty"
    /// <summary>
    /// Kind of learning asset (Storylane, Video, Article)
    /// <see href="https://open-metadata.org/ontology/resourceType"></see></summary>
    let resourceType = _prefix "resourceType"
    /// <summary>
    /// Retention period of the data in ISO 8601 duration format
    /// <see href="https://open-metadata.org/ontology/retentionPeriod"></see></summary>
    let retentionPeriod = _prefix "retentionPeriod"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/reviews"></see>
    /// </summary>
    let reviews = _prefix "reviews"
    /// <summary>
    /// Rights statement for the dataset
    /// <see href="https://open-metadata.org/ontology/rights"></see></summary>
    let rights = _prefix "rights"
    /// <summary>
    /// Number of rows in the table
    /// <see href="https://open-metadata.org/ontology/rowCount"></see></summary>
    let rowCount = _prefix "rowCount"
    /// <summary>
    /// Sample data from the table
    /// <see href="https://open-metadata.org/ontology/sampleData"></see></summary>
    let sampleData = _prefix "sampleData"
    /// <summary>
    /// Scheduler interval in cron format
    /// <see href="https://open-metadata.org/ontology/scheduleInterval"></see></summary>
    let scheduleInterval = _prefix "scheduleInterval"
    /// <summary>
    /// DDL schema definition for the table
    /// <see href="https://open-metadata.org/ontology/schemaDefinition"></see></summary>
    let schemaDefinition = _prefix "schemaDefinition"
    /// <summary>
    /// Type of MCP server (DataAccess, FileSystem, WebAPI, Database, Cloud, Security, Development, Communication, Custom)
    /// <see href="https://open-metadata.org/ontology/serverType"></see></summary>
    let serverType = _prefix "serverType"
    /// <summary>
    /// Links a data service to datasets it serves
    /// <see href="https://open-metadata.org/ontology/servesDataset"></see></summary>
    let servesDataset = _prefix "servesDataset"
    /// <summary>
    /// Service that is part of the catalog
    /// <see href="https://open-metadata.org/ontology/service"></see></summary>
    let service = _prefix "service"
    /// <summary>
    /// Endpoint for accessing the service
    /// <see href="https://open-metadata.org/ontology/serviceEndpoint"></see></summary>
    let serviceEndpoint = _prefix "serviceEndpoint"
    /// <summary>
    /// Service level agreement details
    /// <see href="https://open-metadata.org/ontology/serviceLevel"></see></summary>
    let serviceLevel = _prefix "serviceLevel"
    /// <summary>
    /// Operational status of the service
    /// <see href="https://open-metadata.org/ontology/serviceStatus"></see></summary>
    let serviceStatus = _prefix "serviceStatus"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/serviceType"></see>
    /// </summary>
    let serviceType = _prefix "serviceType"
    /// <summary>
    /// Expected availability percentage
    /// <see href="https://open-metadata.org/ontology/slaAvailability"></see></summary>
    let slaAvailability = _prefix "slaAvailability"
    /// <summary>
    /// Maximum data staleness in minutes
    /// <see href="https://open-metadata.org/ontology/slaDataFreshness"></see></summary>
    let slaDataFreshness = _prefix "slaDataFreshness"
    /// <summary>
    /// Minimum data quality score
    /// <see href="https://open-metadata.org/ontology/slaDataQuality"></see></summary>
    let slaDataQuality = _prefix "slaDataQuality"
    /// <summary>
    /// Expected response time in milliseconds
    /// <see href="https://open-metadata.org/ontology/slaResponseTime"></see></summary>
    let slaResponseTime = _prefix "slaResponseTime"
    /// <summary>
    /// SLA tier level (GOLD, SILVER, BRONZE)
    /// <see href="https://open-metadata.org/ontology/slaTier"></see></summary>
    let slaTier = _prefix "slaTier"
    /// <summary>
    /// Source of the dataset
    /// <see href="https://open-metadata.org/ontology/source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// Source hash of the entity for change detection
    /// <see href="https://open-metadata.org/ontology/sourceHash"></see></summary>
    let sourceHash = _prefix "sourceHash"
    /// <summary>
    /// URL to visit/manage the entity in the source system
    /// <see href="https://open-metadata.org/ontology/sourceUrl"></see></summary>
    let sourceUrl = _prefix "sourceUrl"
    /// <summary>
    /// Spatial area covered by the dataset
    /// <see href="https://open-metadata.org/ontology/spatial"></see></summary>
    let spatial = _prefix "spatial"
    /// <summary>
    /// Minimum spatial separation resolvable in the dataset
    /// <see href="https://open-metadata.org/ontology/spatialResolution"></see></summary>
    let spatialResolution = _prefix "spatialResolution"
    /// <summary>
    /// SQL query used in transformation
    /// <see href="https://open-metadata.org/ontology/sqlQuery"></see></summary>
    let sqlQuery = _prefix "sqlQuery"
    /// <summary>
    /// Start of the temporal period
    /// <see href="https://open-metadata.org/ontology/startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// Unit of observation in the dataset
    /// <see href="https://open-metadata.org/ontology/statisticalUnit"></see></summary>
    let statisticalUnit = _prefix "statisticalUnit"
    /// <summary>
    /// Data types supported by this test definition
    /// <see href="https://open-metadata.org/ontology/supportedDataTypes"></see></summary>
    let supportedDataTypes = _prefix "supportedDataTypes"
    /// <summary>
    /// Whether the test case supports dynamic assertions
    /// <see href="https://open-metadata.org/ontology/supportsDynamicAssertion"></see></summary>
    let supportsDynamicAssertion = _prefix "supportsDynamicAssertion"
    /// <summary>
    /// Whether the test case supports row level passed/failed
    /// <see href="https://open-metadata.org/ontology/supportsRowLevelPassedFailed"></see></summary>
    let supportsRowLevelPassedFailed = _prefix "supportsRowLevelPassedFailed"
    /// <summary>
    /// Type of table (Regular, External, View, MaterializedView, etc.)
    /// <see href="https://open-metadata.org/ontology/tableType"></see></summary>
    let tableType = _prefix "tableType"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/templateVariable"></see>
    /// </summary>
    let templateVariable = _prefix "templateVariable"
    /// <summary>
    /// Temporal period covered by the dataset
    /// <see href="https://open-metadata.org/ontology/temporal"></see></summary>
    let temporal = _prefix "temporal"
    /// <summary>
    /// Minimum time period resolvable in the dataset
    /// <see href="https://open-metadata.org/ontology/temporalResolution"></see></summary>
    let temporalResolution = _prefix "temporalResolution"
    /// <summary>
    /// Platform where tests are defined (OpenMetadata, GreatExpectations, dbt, Deequ, Soda, Other)
    /// <see href="https://open-metadata.org/ontology/testPlatform"></see></summary>
    let testPlatform = _prefix "testPlatform"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/testedBy"></see>
    /// </summary>
    let testedBy = _prefix "testedBy"
    /// <summary>
    /// Main category of the dataset
    /// <see href="https://open-metadata.org/ontology/theme"></see></summary>
    let theme = _prefix "theme"
    /// <summary>
    /// Knowledge organization system for categorizing datasets
    /// <see href="https://open-metadata.org/ontology/themeTaxonomy"></see></summary>
    let themeTaxonomy = _prefix "themeTaxonomy"
    /// <summary>
    /// How current the data is
    /// <see href="https://open-metadata.org/ontology/timeliness"></see></summary>
    let timeliness = _prefix "timeliness"
    /// <summary>
    /// Title of the dataset
    /// <see href="https://open-metadata.org/ontology/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Target column created by transformation
    /// <see href="https://open-metadata.org/ontology/toColumn"></see></summary>
    let toColumn = _prefix "toColumn"
    /// <summary>
    /// Function applied to transform data
    /// <see href="https://open-metadata.org/ontology/transformationFunction"></see></summary>
    let transformationFunction = _prefix "transformationFunction"
    /// <summary>
    /// Transport protocol used by the MCP server
    /// <see href="https://open-metadata.org/ontology/transportType"></see></summary>
    let transportType = _prefix "transportType"
    /// <summary>
    /// Nature or genre of the dataset
    /// <see href="https://open-metadata.org/ontology/type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Degree of uniqueness in the data
    /// <see href="https://open-metadata.org/ontology/uniqueness"></see></summary>
    let uniqueness = _prefix "uniqueness"
    /// <summary>
    /// Number of up votes
    /// <see href="https://open-metadata.org/ontology/upVotes"></see></summary>
    let upVotes = _prefix "upVotes"
    /// <summary>
    /// Last update time in Unix epoch milliseconds
    /// <see href="https://open-metadata.org/ontology/updatedAt"></see></summary>
    let updatedAt = _prefix "updatedAt"
    /// <summary>
    /// User who made the update
    /// <see href="https://open-metadata.org/ontology/updatedBy"></see></summary>
    let updatedBy = _prefix "updatedBy"
    /// <summary>
    /// Latest usage information for the entity
    /// <see href="https://open-metadata.org/ontology/usageSummary"></see></summary>
    let usageSummary = _prefix "usageSummary"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/uses"></see>
    /// </summary>
    let uses = _prefix "uses"
    /// <summary>
    /// AI application uses an MCP server for tools, resources or prompts
    /// <see href="https://open-metadata.org/ontology/usesMCPServer"></see></summary>
    let usesMCPServer = _prefix "usesMCPServer"
    /// <summary>
    /// AI application or agent execution uses an LLM model
    /// <see href="https://open-metadata.org/ontology/usesModel"></see></summary>
    let usesModel = _prefix "usesModel"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/usesPromptTemplate"></see>
    /// </summary>
    let usesPromptTemplate = _prefix "usesPromptTemplate"
    /// <summary>
    /// Degree to which data conforms to defined rules
    /// <see href="https://open-metadata.org/ontology/validity"></see></summary>
    let validity = _prefix "validity"
    /// <summary>
    /// Version identifier
    /// <see href="https://open-metadata.org/ontology/version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// Notes about this version
    /// <see href="https://open-metadata.org/ontology/versionNotes"></see></summary>
    let versionNotes = _prefix "versionNotes"
    /// <summary>
    ///   <see href="https://open-metadata.org/ontology/voted"></see>
    /// </summary>
    let voted = _prefix "voted"
    /// <summary>
    /// Source dataset this was derived from
    /// <see href="https://open-metadata.org/ontology/wasDerivedFrom"></see></summary>
    let wasDerivedFrom = _prefix "wasDerivedFrom"
    /// <summary>
    /// Activity that generated the dataset
    /// <see href="https://open-metadata.org/ontology/wasGeneratedBy"></see></summary>
    let wasGeneratedBy = _prefix "wasGeneratedBy"
