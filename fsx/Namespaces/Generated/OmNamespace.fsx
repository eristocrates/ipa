#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module om =
    let _prefixId = PrefixId.fromNamespaceLabel "https://open-metadata.org/ontology/" "om"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : AI Application^^xsd:string</para>
    ///   <para>rdfs:comment : AI system such as a chatbot, agent, copilot, RAG application or multi-agent pipeline that may use multiple LLM models and tools^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/AIApplication">om:AIApplication</a>
    /// </summary>
    let AIApplication = _prefixId.prefix "AIApplication"
    /// <summary>
    ///   <para>rdfs:label : AI Framework Control^^xsd:string</para>
    ///   <para>rdfs:comment : Individual control within an AI governance framework^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/AIFrameworkControl">om:AIFrameworkControl</a>
    /// </summary>
    let AIFrameworkControl = _prefixId.prefix "AIFrameworkControl"
    /// <summary>
    ///   <para>rdfs:label : AI Governance Framework^^xsd:string</para>
    ///   <para>rdfs:comment : Workspace-level framework that groups controls and drives AI compliance assessments^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/AIGovernanceFramework">om:AIGovernanceFramework</a>
    /// </summary>
    let AIGovernanceFramework = _prefixId.prefix "AIGovernanceFramework"
    /// <summary>
    ///   <para>rdfs:label : AI Governance Policy^^xsd:string</para>
    ///   <para>rdfs:comment : Policy rules for AI/LLM usage, compliance, and risk management (model approval, data access, bias thresholds, cost controls, etc.)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/AIGovernancePolicy">om:AIGovernancePolicy</a>
    /// </summary>
    let AIGovernancePolicy = _prefixId.prefix "AIGovernancePolicy"
    /// <summary>
    ///   <para>rdfs:label : API Collection^^xsd:string</para>
    ///   <para>rdfs:comment : Collection of API endpoints^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/APICollection">om:APICollection</a>
    /// </summary>
    let APICollection = _prefixId.prefix "APICollection"
    /// <summary>
    ///   <para>rdfs:label : API Documentation^^xsd:string</para>
    ///   <para>rdfs:comment : Documentation for API endpoints^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/APIDocumentation">om:APIDocumentation</a>
    /// </summary>
    let APIDocumentation = _prefixId.prefix "APIDocumentation"
    /// <summary>
    ///   <para>rdfs:label : API Endpoint^^xsd:string</para>
    ///   <para>rdfs:comment : API endpoint providing data access service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/APIEndpoint">om:APIEndpoint</a>
    /// </summary>
    let APIEndpoint = _prefixId.prefix "APIEndpoint"
    /// <summary>
    ///   <para>rdfs:label : API Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/APIService">om:APIService</a>
    /// </summary>
    let APIService = _prefixId.prefix "APIService"
    /// <summary>
    ///   <para>rdfs:label : Activity Event^^xsd:string</para>
    ///   <para>rdfs:comment : Lightweight user-facing activity notification, separate from the audit trail^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ActivityEvent">om:ActivityEvent</a>
    /// </summary>
    let ActivityEvent = _prefixId.prefix "ActivityEvent"
    /// <summary>
    ///   <para>rdfs:label : Activity Stream Configuration^^xsd:string</para>
    ///   <para>rdfs:comment : Global or domain-level configuration for activity generation, visibility, and retention^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ActivityStreamConfig">om:ActivityStreamConfig</a>
    /// </summary>
    let ActivityStreamConfig = _prefixId.prefix "ActivityStreamConfig"
    /// <summary>
    ///   <para>rdfs:label : Agent Execution^^xsd:string</para>
    ///   <para>rdfs:comment : Single execution run of an AI agent, tracking inputs, outputs, lineage, metrics and errors for observability and governance^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/AgentExecution">om:AgentExecution</a>
    /// </summary>
    let AgentExecution = _prefixId.prefix "AgentExecution"
    /// <summary>
    ///   <para>rdfs:label : Announcement^^xsd:string</para>
    ///   <para>rdfs:comment : Time-bound notification associated with a catalog entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Announcement">om:Announcement</a>
    /// </summary>
    let Announcement = _prefixId.prefix "Announcement"
    /// <summary>
    ///   <para>rdfs:label : Article^^xsd:string</para>
    ///   <para>rdfs:comment : Rich-text content of a Context Center page^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Article">om:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:label : Asset Certification^^xsd:string</para>
    ///   <para>rdfs:comment : Certification status of an asset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/AssetCertification">om:AssetCertification</a>
    /// </summary>
    let AssetCertification = _prefixId.prefix "AssetCertification"
    /// <summary>
    ///   <para>rdfs:label : Attachment Asset^^xsd:string</para>
    ///   <para>rdfs:comment : Uploaded attachment associated with an OpenMetadata entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/AttachmentAsset">om:AttachmentAsset</a>
    /// </summary>
    let AttachmentAsset = _prefixId.prefix "AttachmentAsset"
    /// <summary>
    ///   <para>rdfs:label : AI Governance Audit Report^^xsd:string</para>
    ///   <para>rdfs:comment : Evidence pack generated for a governance framework, domain, or AI asset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/AuditReport">om:AuditReport</a>
    /// </summary>
    let AuditReport = _prefixId.prefix "AuditReport"
    /// <summary>
    ///   <para>rdfs:label : Bot^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Bot">om:Bot</a>
    /// </summary>
    let Bot = _prefixId.prefix "Bot"
    /// <summary>
    ///   <para>rdfs:label : Catalog^^xsd:string</para>
    ///   <para>rdfs:comment : Curated collection of metadata about resources^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Catalog">om:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:label : Catalog Record^^xsd:string</para>
    ///   <para>rdfs:comment : Metadata about when/how an entity was cataloged^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/CatalogRecord">om:CatalogRecord</a>
    /// </summary>
    let CatalogRecord = _prefixId.prefix "CatalogRecord"
    /// <summary>
    ///   <para>rdfs:label : Change Description^^xsd:string</para>
    ///   <para>rdfs:comment : Description of changes that led to a version of an entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ChangeDescription">om:ChangeDescription</a>
    /// </summary>
    let ChangeDescription = _prefixId.prefix "ChangeDescription"
    /// <summary>
    ///   <para>rdfs:label : Chart^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Chart">om:Chart</a>
    /// </summary>
    let Chart = _prefixId.prefix "Chart"
    /// <summary>
    ///   <para>rdfs:label : Classification^^xsd:string</para>
    ///   <para>rdfs:comment : Tag Category^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Classification">om:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>rdfs:label : Column^^xsd:string</para>
    ///   <para>rdfs:comment : Column in a table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Column">om:Column</a>
    /// </summary>
    let Column = _prefixId.prefix "Column"
    /// <summary>
    ///   <para>rdfs:label : Container^^xsd:string</para>
    ///   <para>rdfs:comment : Storage container organizing multiple datasets^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Container">om:Container</a>
    /// </summary>
    let Container = _prefixId.prefix "Container"
    /// <summary>
    ///   <para>rdfs:label : Context File^^xsd:string</para>
    ///   <para>rdfs:comment : Uploaded file stored in the Context Center and processed for search and AI context^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ContextFile">om:ContextFile</a>
    /// </summary>
    let ContextFile = _prefixId.prefix "ContextFile"
    /// <summary>
    ///   <para>rdfs:label : Context File Content^^xsd:string</para>
    ///   <para>rdfs:comment : Versioned content snapshot belonging to a Context File^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ContextFileContent">om:ContextFileContent</a>
    /// </summary>
    let ContextFileContent = _prefixId.prefix "ContextFileContent"
    /// <summary>
    ///   <para>rdfs:label : Context Memory^^xsd:string</para>
    ///   <para>rdfs:comment : Reusable memory for Context Center and AI-assisted retrieval^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ContextMemory">om:ContextMemory</a>
    /// </summary>
    let ContextMemory = _prefixId.prefix "ContextMemory"
    /// <summary>
    ///   <para>rdfs:label : Dashboard^^xsd:string</para>
    ///   <para>rdfs:comment : Dashboard for data visualization^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Dashboard">om:Dashboard</a>
    /// </summary>
    let Dashboard = _prefixId.prefix "Dashboard"
    /// <summary>
    ///   <para>rdfs:label : Dashboard Data Model^^xsd:string</para>
    ///   <para>rdfs:comment : Dashboard Data Model entity to capture the data models used by dashboards^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DashboardDataModel">om:DashboardDataModel</a>
    /// </summary>
    let DashboardDataModel = _prefixId.prefix "DashboardDataModel"
    /// <summary>
    ///   <para>rdfs:label : Dashboard Data Model Column^^xsd:string</para>
    ///   <para>rdfs:comment : Dashboard data model column context type used to attach custom properties to columns of a DashboardDataModel^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DashboardDataModelColumn">om:DashboardDataModelColumn</a>
    /// </summary>
    let DashboardDataModelColumn = _prefixId.prefix "DashboardDataModelColumn"
    /// <summary>
    ///   <para>rdfs:label : Dashboard Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DashboardService">om:DashboardService</a>
    /// </summary>
    let DashboardService = _prefixId.prefix "DashboardService"
    /// <summary>
    ///   <para>rdfs:label : Data Asset^^xsd:string</para>
    ///   <para>rdfs:comment : Base class for all data assets^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DataAsset">om:DataAsset</a>
    /// </summary>
    let DataAsset = _prefixId.prefix "DataAsset"
    /// <summary>
    ///   <para>rdfs:label : Data Contract^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DataContract">om:DataContract</a>
    /// </summary>
    let DataContract = _prefixId.prefix "DataContract"
    /// <summary>
    ///   <para>rdfs:label : Data Product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DataProduct">om:DataProduct</a>
    /// </summary>
    let DataProduct = _prefixId.prefix "DataProduct"
    /// <summary>
    ///   <para>rdfs:label : Data Product SLA^^xsd:string</para>
    ///   <para>rdfs:comment : Service Level Agreement for a data product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DataProductSLA">om:DataProductSLA</a>
    /// </summary>
    let DataProductSLA = _prefixId.prefix "DataProductSLA"
    /// <summary>
    ///   <para>rdfs:label : Data Service^^xsd:string</para>
    ///   <para>rdfs:comment : Service that provides access to data^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DataService">om:DataService</a>
    /// </summary>
    let DataService = _prefixId.prefix "DataService"
    /// <summary>
    ///   <para>rdfs:label : Database^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Database">om:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    /// <summary>
    ///   <para>rdfs:label : Database Schema^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DatabaseSchema">om:DatabaseSchema</a>
    /// </summary>
    let DatabaseSchema = _prefixId.prefix "DatabaseSchema"
    /// <summary>
    ///   <para>rdfs:label : Database Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DatabaseService">om:DatabaseService</a>
    /// </summary>
    let DatabaseService = _prefixId.prefix "DatabaseService"
    /// <summary>
    ///   <para>rdfs:label : Dataset Series^^xsd:string</para>
    ///   <para>rdfs:comment : Collection of related datasets, e.g., time series or versions^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DatasetSeries">om:DatasetSeries</a>
    /// </summary>
    let DatasetSeries = _prefixId.prefix "DatasetSeries"
    /// <summary>
    ///   <para>rdfs:label : Directory^^xsd:string</para>
    ///   <para>rdfs:comment : File system directory^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Directory">om:Directory</a>
    /// </summary>
    let Directory = _prefixId.prefix "Directory"
    /// <summary>
    ///   <para>rdfs:label : Distribution^^xsd:string</para>
    ///   <para>rdfs:comment : Specific representation of a dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Distribution">om:Distribution</a>
    /// </summary>
    let Distribution = _prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>rdfs:label : Domain^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Domain">om:Domain</a>
    /// </summary>
    let Domain = _prefixId.prefix "Domain"
    /// <summary>
    ///   <para>rdfs:label : Drive Service^^xsd:string</para>
    ///   <para>rdfs:comment : File and document storage service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/DriveService">om:DriveService</a>
    /// </summary>
    let DriveService = _prefixId.prefix "DriveService"
    /// <summary>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Base class for all OpenMetadata entities^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Entity">om:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Entity Status^^xsd:string</para>
    ///   <para>rdfs:comment : Current status of an entity (Active, Deleted, Draft)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/EntityStatus">om:EntityStatus</a>
    /// </summary>
    let EntityStatus = _prefixId.prefix "EntityStatus"
    /// <summary>
    ///   <para>rdfs:label : File^^xsd:string</para>
    ///   <para>rdfs:comment : Individual file^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/File">om:File</a>
    /// </summary>
    let File = _prefixId.prefix "File"
    /// <summary>
    ///   <para>rdfs:label : Context Center Folder^^xsd:string</para>
    ///   <para>rdfs:comment : Hierarchical container for Context Center files^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Folder">om:Folder</a>
    /// </summary>
    let Folder = _prefixId.prefix "Folder"
    /// <summary>
    ///   <para>rdfs:label : Frequency^^xsd:string</para>
    ///   <para>rdfs:comment : Update frequency specification^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Frequency">om:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:label : Glossary^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Glossary">om:Glossary</a>
    /// </summary>
    let Glossary = _prefixId.prefix "Glossary"
    /// <summary>
    ///   <para>rdfs:label : Glossary Term^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/GlossaryTerm">om:GlossaryTerm</a>
    /// </summary>
    let GlossaryTerm = _prefixId.prefix "GlossaryTerm"
    /// <summary>
    ///   <para>rdfs:label : Task^^xsd:string</para>
    ///   <para>rdfs:comment : Actionable work item with assignments and lifecycle state for governance workflows^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/GovernanceTask">om:GovernanceTask</a>
    /// </summary>
    let GovernanceTask = _prefixId.prefix "GovernanceTask"
    /// <summary>
    ///   <para>rdfs:label : Input Port^^xsd:string</para>
    ///   <para>rdfs:comment : Input port of a data product for consuming data^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/InputPort">om:InputPort</a>
    /// </summary>
    let InputPort = _prefixId.prefix "InputPort"
    /// <summary>
    ///   <para>rdfs:label : Governance Intake Form^^xsd:string</para>
    ///   <para>rdfs:comment : Form contract that adds required governance fields for a supported entity type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/IntakeForm">om:IntakeForm</a>
    /// </summary>
    let IntakeForm = _prefixId.prefix "IntakeForm"
    /// <summary>
    ///   <para>rdfs:label : LLM Model^^xsd:string</para>
    ///   <para>rdfs:comment : Registered Large Language Model deployment, fine-tune, or base model referenced by AI applications and agents^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/LLMModel">om:LLMModel</a>
    /// </summary>
    let LLMModel = _prefixId.prefix "LLMModel"
    /// <summary>
    ///   <para>rdfs:label : LLM Service^^xsd:string</para>
    ///   <para>rdfs:comment : Service managing Large Language Model providers (OpenAI, Anthropic, Bedrock, VertexAI, Ollama, etc.)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/LLMService">om:LLMService</a>
    /// </summary>
    let LLMService = _prefixId.prefix "LLMService"
    /// <summary>
    ///   <para>rdfs:label : Learning Resource^^xsd:string</para>
    ///   <para>rdfs:comment : Learning resource such as an in-product tutorial, Storylane walkthrough, video or article contextualized for product surfaces^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/LearningResource">om:LearningResource</a>
    /// </summary>
    let LearningResource = _prefixId.prefix "LearningResource"
    /// <summary>
    ///   <para>rdfs:label : License Document^^xsd:string</para>
    ///   <para>rdfs:comment : Legal document giving permissions^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/LicenseDocument">om:LicenseDocument</a>
    /// </summary>
    let LicenseDocument = _prefixId.prefix "LicenseDocument"
    /// <summary>
    ///   <para>rdfs:label : Life Cycle^^xsd:string</para>
    ///   <para>rdfs:comment : Life cycle properties of an entity including created, updated, accessed timestamps^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/LifeCycle">om:LifeCycle</a>
    /// </summary>
    let LifeCycle = _prefixId.prefix "LifeCycle"
    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : Spatial region or location^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Location">om:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : MCP Execution^^xsd:string</para>
    ///   <para>rdfs:comment : Single execution session of an MCP server, tracking tool calls, resource accesses, prompt uses and data lineage for audit and compliance^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/MCPExecution">om:MCPExecution</a>
    /// </summary>
    let MCPExecution = _prefixId.prefix "MCPExecution"
    /// <summary>
    ///   <para>rdfs:label : MCP Server^^xsd:string</para>
    ///   <para>rdfs:comment : Model Context Protocol server deployment that exposes tools, resources and prompts to AI applications^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/MCPServer">om:MCPServer</a>
    /// </summary>
    let MCPServer = _prefixId.prefix "MCPServer"
    /// <summary>
    ///   <para>rdfs:label : MCP Service^^xsd:string</para>
    ///   <para>rdfs:comment : Service for discovering and managing MCP (Model Context Protocol) servers^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/MCPService">om:MCPService</a>
    /// </summary>
    let MCPService = _prefixId.prefix "MCPService"
    /// <summary>
    ///   <para>rdfs:label : ML Model^^xsd:string</para>
    ///   <para>rdfs:comment : Machine learning model providing inference service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/MLModel">om:MLModel</a>
    /// </summary>
    let MLModel = _prefixId.prefix "MLModel"
    /// <summary>
    ///   <para>rdfs:label : ML Model Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/MLModelService">om:MLModelService</a>
    /// </summary>
    let MLModelService = _prefixId.prefix "MLModelService"
    /// <summary>
    ///   <para>rdfs:label : Media Type^^xsd:string</para>
    ///   <para>rdfs:comment : Media type or format^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/MediaType">om:MediaType</a>
    /// </summary>
    let MediaType = _prefixId.prefix "MediaType"
    /// <summary>
    ///   <para>rdfs:label : Messaging Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/MessagingService">om:MessagingService</a>
    /// </summary>
    let MessagingService = _prefixId.prefix "MessagingService"
    /// <summary>
    ///   <para>rdfs:label : Metadata Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/MetadataService">om:MetadataService</a>
    /// </summary>
    let MetadataService = _prefixId.prefix "MetadataService"
    /// <summary>
    ///   <para>rdfs:label : Metric^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Metric">om:Metric</a>
    /// </summary>
    let Metric = _prefixId.prefix "Metric"
    /// <summary>
    ///   <para>rdfs:label : Observability Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ObservabilityService">om:ObservabilityService</a>
    /// </summary>
    let ObservabilityService = _prefixId.prefix "ObservabilityService"
    /// <summary>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <para>rdfs:comment : Organization entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Organization">om:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Output Port^^xsd:string</para>
    ///   <para>rdfs:comment : Output port of a data product for exposing data^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/OutputPort">om:OutputPort</a>
    /// </summary>
    let OutputPort = _prefixId.prefix "OutputPort"
    /// <summary>
    ///   <para>rdfs:label : Context Center Page^^xsd:string</para>
    ///   <para>rdfs:comment : Knowledge page represented as an article or quick link^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Page">om:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>rdfs:label : Period of Time^^xsd:string</para>
    ///   <para>rdfs:comment : Time period specification^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/PeriodOfTime">om:PeriodOfTime</a>
    /// </summary>
    let PeriodOfTime = _prefixId.prefix "PeriodOfTime"
    /// <summary>
    ///   <para>rdfs:label : Pipeline^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Pipeline">om:Pipeline</a>
    /// </summary>
    let Pipeline = _prefixId.prefix "Pipeline"
    /// <summary>
    ///   <para>rdfs:label : Pipeline Service^^xsd:string</para>
    ///   <para>rdfs:comment : ETL Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/PipelineService">om:PipelineService</a>
    /// </summary>
    let PipelineService = _prefixId.prefix "PipelineService"
    /// <summary>
    ///   <para>rdfs:label : Pipeline Status^^xsd:string</para>
    ///   <para>rdfs:comment : Status of a pipeline execution^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/PipelineStatus">om:PipelineStatus</a>
    /// </summary>
    let PipelineStatus = _prefixId.prefix "PipelineStatus"
    /// <summary>
    ///   <para>rdfs:label : Policy^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Policy">om:Policy</a>
    /// </summary>
    let Policy = _prefixId.prefix "Policy"
    /// <summary>
    ///   <para>rdfs:label : Post^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Post">om:Post</a>
    /// </summary>
    let Post = _prefixId.prefix "Post"
    /// <summary>
    ///   <para>rdfs:label : Profiler Config^^xsd:string</para>
    ///   <para>rdfs:comment : Configuration for table profiling^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ProfilerConfig">om:ProfilerConfig</a>
    /// </summary>
    let ProfilerConfig = _prefixId.prefix "ProfilerConfig"
    /// <summary>
    ///   <para>rdfs:label : Prompt Template^^xsd:string</para>
    ///   <para>rdfs:comment : Reusable prompt template with variables, system prompts and examples for consistent AI behavior^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/PromptTemplate">om:PromptTemplate</a>
    /// </summary>
    let PromptTemplate = _prefixId.prefix "PromptTemplate"
    /// <summary>
    ///   <para>rdfs:label : Qualified Relationship^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship with additional context like role, time, etc.^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/QualifiedRelationship">om:QualifiedRelationship</a>
    /// </summary>
    let QualifiedRelationship = _prefixId.prefix "QualifiedRelationship"
    /// <summary>
    ///   <para>rdfs:label : Quality Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/QualityService">om:QualityService</a>
    /// </summary>
    let QualityService = _prefixId.prefix "QualityService"
    /// <summary>
    ///   <para>rdfs:label : Query^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Query">om:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : Quick Link^^xsd:string</para>
    ///   <para>rdfs:comment : External link content of a Context Center page^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/QuickLink">om:QuickLink</a>
    /// </summary>
    let QuickLink = _prefixId.prefix "QuickLink"
    /// <summary>
    ///   <para>rdfs:label : Report^^xsd:string</para>
    ///   <para>rdfs:comment : Report as a specific representation of data^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Report">om:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : Reporting Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/ReportingService">om:ReportingService</a>
    /// </summary>
    let ReportingService = _prefixId.prefix "ReportingService"
    /// <summary>
    ///   <para>rdfs:label : Resource^^xsd:string</para>
    ///   <para>rdfs:comment : Any resource cataloged in OpenMetadata^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Resource">om:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : Rights Statement^^xsd:string</para>
    ///   <para>rdfs:comment : Statement about intellectual property rights^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/RightsStatement">om:RightsStatement</a>
    /// </summary>
    let RightsStatement = _prefixId.prefix "RightsStatement"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Role">om:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Search Index^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/SearchIndex">om:SearchIndex</a>
    /// </summary>
    let SearchIndex = _prefixId.prefix "SearchIndex"
    /// <summary>
    ///   <para>rdfs:label : Search Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/SearchService">om:SearchService</a>
    /// </summary>
    let SearchService = _prefixId.prefix "SearchService"
    /// <summary>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <para>rdfs:comment : Base class for all services^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Service">om:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Spreadsheet^^xsd:string</para>
    ///   <para>rdfs:comment : Spreadsheet document^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Spreadsheet">om:Spreadsheet</a>
    /// </summary>
    let Spreadsheet = _prefixId.prefix "Spreadsheet"
    /// <summary>
    ///   <para>rdfs:label : Standard^^xsd:string</para>
    ///   <para>rdfs:comment : Technical standard or specification^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Standard">om:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>rdfs:label : Storage Service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/StorageService">om:StorageService</a>
    /// </summary>
    let StorageService = _prefixId.prefix "StorageService"
    /// <summary>
    ///   <para>rdfs:label : Stored Procedure^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/StoredProcedure">om:StoredProcedure</a>
    /// </summary>
    let StoredProcedure = _prefixId.prefix "StoredProcedure"
    /// <summary>
    ///   <para>rdfs:label : Table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Table">om:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : Table Column^^xsd:string</para>
    ///   <para>rdfs:comment : Table column context type used to attach custom properties to columns of a Table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/TableColumn">om:TableColumn</a>
    /// </summary>
    let TableColumn = _prefixId.prefix "TableColumn"
    /// <summary>
    ///   <para>rdfs:label : Table Profile^^xsd:string</para>
    ///   <para>rdfs:comment : Profile data for a table including statistics^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/TableProfile">om:TableProfile</a>
    /// </summary>
    let TableProfile = _prefixId.prefix "TableProfile"
    /// <summary>
    ///   <para>rdfs:label : Tag^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Tag">om:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:label : Task^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Task">om:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:label : Task Form Schema^^xsd:string</para>
    ///   <para>rdfs:comment : JSON Schema and UI schema used to create or resolve a task^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/TaskFormSchema">om:TaskFormSchema</a>
    /// </summary>
    let TaskFormSchema = _prefixId.prefix "TaskFormSchema"
    /// <summary>
    ///   <para>rdfs:label : Team^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Team">om:Team</a>
    /// </summary>
    let Team = _prefixId.prefix "Team"
    /// <summary>
    ///   <para>rdfs:label : Test Case^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/TestCase">om:TestCase</a>
    /// </summary>
    let TestCase = _prefixId.prefix "TestCase"
    /// <summary>
    ///   <para>rdfs:label : Test Case Parameter^^xsd:string</para>
    ///   <para>rdfs:comment : Parameter definition for a test case^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/TestCaseParameter">om:TestCaseParameter</a>
    /// </summary>
    let TestCaseParameter = _prefixId.prefix "TestCaseParameter"
    /// <summary>
    ///   <para>rdfs:label : Test Definition^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/TestDefinition">om:TestDefinition</a>
    /// </summary>
    let TestDefinition = _prefixId.prefix "TestDefinition"
    /// <summary>
    ///   <para>rdfs:label : Test Suite^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/TestSuite">om:TestSuite</a>
    /// </summary>
    let TestSuite = _prefixId.prefix "TestSuite"
    /// <summary>
    ///   <para>rdfs:label : Thread^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Thread">om:Thread</a>
    /// </summary>
    let Thread = _prefixId.prefix "Thread"
    /// <summary>
    ///   <para>rdfs:label : Topic^^xsd:string</para>
    ///   <para>rdfs:comment : Message topic providing streaming data access^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Topic">om:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>rdfs:label : User^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/User">om:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:label : Votes^^xsd:string</para>
    ///   <para>rdfs:comment : Votes on an entity (upvotes and downvotes)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Votes">om:Votes</a>
    /// </summary>
    let Votes = _prefixId.prefix "Votes"
    /// <summary>
    ///   <para>rdfs:label : Worksheet^^xsd:string</para>
    ///   <para>rdfs:comment : Worksheet within a spreadsheet^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/Worksheet">om:Worksheet</a>
    /// </summary>
    let Worksheet = _prefixId.prefix "Worksheet"
    /// <summary>
    ///   <para>rdfs:label : access rights^^xsd:string</para>
    ///   <para>rdfs:comment : Information about access restrictions^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/accessRights">om:accessRights</a>
    /// </summary>
    let accessRights = _prefixId.prefix "accessRights"
    /// <summary>
    ///   <para>rdfs:label : access URL^^xsd:string</para>
    ///   <para>rdfs:comment : URL to access the distribution^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/accessURL">om:accessURL</a>
    /// </summary>
    let accessURL = _prefixId.prefix "accessURL"
    /// <summary>
    ///   <para>rdfs:label : accrual periodicity^^xsd:string</para>
    ///   <para>rdfs:comment : Frequency of dataset updates^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/accrualPeriodicity">om:accrualPeriodicity</a>
    /// </summary>
    let accrualPeriodicity = _prefixId.prefix "accrualPeriodicity"
    /// <summary>
    ///   <para>rdfs:label : accuracy^^xsd:string</para>
    ///   <para>rdfs:comment : Degree of data accuracy^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/accuracy">om:accuracy</a>
    /// </summary>
    let accuracy = _prefixId.prefix "accuracy"
    /// <summary>
    ///   <para>rdfs:label : activity actor^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/activityActor">om:activityActor</a>
    /// </summary>
    let activityActor = _prefixId.prefix "activityActor"
    /// <summary>
    ///   <para>rdfs:label : activity entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/activityEntity">om:activityEntity</a>
    /// </summary>
    let activityEntity = _prefixId.prefix "activityEntity"
    /// <summary>
    ///   <para>rdfs:label : activity event type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/activityEventType">om:activityEventType</a>
    /// </summary>
    let activityEventType = _prefixId.prefix "activityEventType"
    /// <summary>
    ///   <para>rdfs:label : activity stream scope^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/activityScope">om:activityScope</a>
    /// </summary>
    let activityScope = _prefixId.prefix "activityScope"
    /// <summary>
    ///   <para>rdfs:label : activity scope reference^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/activityScopeReference">om:activityScopeReference</a>
    /// </summary>
    let activityScopeReference = _prefixId.prefix "activityScopeReference"
    /// <summary>
    ///   <para>rdfs:label : activity summary^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/activitySummary">om:activitySummary</a>
    /// </summary>
    let activitySummary = _prefixId.prefix "activitySummary"
    /// <summary>
    ///   <para>rdfs:label : activity timestamp^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/activityTimestamp">om:activityTimestamp</a>
    /// </summary>
    let activityTimestamp = _prefixId.prefix "activityTimestamp"
    /// <summary>
    ///   <para>rdfs:label : activity stream visibility^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/activityVisibility">om:activityVisibility</a>
    /// </summary>
    let activityVisibility = _prefixId.prefix "activityVisibility"
    /// <summary>
    ///   <para>rdfs:label : addressed to^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/addressedTo">om:addressedTo</a>
    /// </summary>
    let addressedTo = _prefixId.prefix "addressedTo"
    /// <summary>
    ///   <para>rdfs:label : announcement status^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/announcementStatus">om:announcementStatus</a>
    /// </summary>
    let announcementStatus = _prefixId.prefix "announcementStatus"
    /// <summary>
    ///   <para>rdfs:label : API documentation^^xsd:string</para>
    ///   <para>rdfs:comment : Link to API documentation^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/apiDocumentation">om:apiDocumentation</a>
    /// </summary>
    let apiDocumentation = _prefixId.prefix "apiDocumentation"
    /// <summary>
    ///   <para>rdfs:label : application type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of AI application (Chatbot, Agent, Copilot, Assistant, RAG, CodeGenerator, DataAnalyst, AutomationBot, MultiAgent, Custom)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/applicationType">om:applicationType</a>
    /// </summary>
    let applicationType = _prefixId.prefix "applicationType"
    /// <summary>
    ///   <para>rdfs:label : applied to^^xsd:string</para>
    ///   <para>rdfs:comment : Tag or classification applied to entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/appliedTo">om:appliedTo</a>
    /// </summary>
    let appliedTo = _prefixId.prefix "appliedTo"
    /// <summary>
    ///   <para>rdfs:label : assessment cadence^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/assessmentCadence">om:assessmentCadence</a>
    /// </summary>
    let assessmentCadence = _prefixId.prefix "assessmentCadence"
    /// <summary>
    ///   <para>rdfs:label : attachment asset type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/assetType">om:assetType</a>
    /// </summary>
    let assetType = _prefixId.prefix "assetType"
    /// <summary>
    ///   <para>rdfs:label : assigned to^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/assignedTo">om:assignedTo</a>
    /// </summary>
    let assignedTo = _prefixId.prefix "assignedTo"
    /// <summary>
    ///   <para>rdfs:label : auto-apply rules^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/autoApplyRules">om:autoApplyRules</a>
    /// </summary>
    let autoApplyRules = _prefixId.prefix "autoApplyRules"
    /// <summary>
    ///   <para>rdfs:label : available transition^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/availableTransition">om:availableTransition</a>
    /// </summary>
    let availableTransition = _prefixId.prefix "availableTransition"
    /// <summary>
    ///   <para>rdfs:label : base model^^xsd:string</para>
    ///   <para>rdfs:comment : Base model this model was trained or fine-tuned from^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/baseModel">om:baseModel</a>
    /// </summary>
    let baseModel = _prefixId.prefix "baseModel"
    /// <summary>
    ///   <para>rdfs:label : bounding box^^xsd:string</para>
    ///   <para>rdfs:comment : Geographic bounding box^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/bbox">om:bbox</a>
    /// </summary>
    let bbox = _prefixId.prefix "bbox"
    /// <summary>
    ///   <para>rdfs:label : belongs to database^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/belongsToDatabase">om:belongsToDatabase</a>
    /// </summary>
    let belongsToDatabase = _prefixId.prefix "belongsToDatabase"
    /// <summary>
    ///   <para>rdfs:label : belongs to schema^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/belongsToSchema">om:belongsToSchema</a>
    /// </summary>
    let belongsToSchema = _prefixId.prefix "belongsToSchema"
    /// <summary>
    ///   <para>rdfs:label : belongs to service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/belongsToService">om:belongsToService</a>
    /// </summary>
    let belongsToService = _prefixId.prefix "belongsToService"
    /// <summary>
    ///   <para>rdfs:label : byte size^^xsd:string</para>
    ///   <para>rdfs:comment : Size in bytes^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/byteSize">om:byteSize</a>
    /// </summary>
    let byteSize = _prefixId.prefix "byteSize"
    /// <summary>
    ///   <para>rdfs:label : catalog^^xsd:string</para>
    ///   <para>rdfs:comment : Sub-catalog^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/catalog">om:catalog</a>
    /// </summary>
    let catalog = _prefixId.prefix "catalog"
    /// <summary>
    ///   <para>rdfs:label : cataloged^^xsd:string</para>
    ///   <para>rdfs:comment : Date when entity was added to catalog^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/cataloged">om:cataloged</a>
    /// </summary>
    let cataloged = _prefixId.prefix "cataloged"
    /// <summary>
    ///   <para>rdfs:label : centroid^^xsd:string</para>
    ///   <para>rdfs:comment : Geographic center point^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/centroid">om:centroid</a>
    /// </summary>
    let centroid = _prefixId.prefix "centroid"
    /// <summary>
    ///   <para>rdfs:label : certification tag label^^xsd:string</para>
    ///   <para>rdfs:comment : Tag label for the certification^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/certificationTagLabel">om:certificationTagLabel</a>
    /// </summary>
    let certificationTagLabel = _prefixId.prefix "certificationTagLabel"
    /// <summary>
    ///   <para>rdfs:label : checksum^^xsd:string</para>
    ///   <para>rdfs:comment : Checksum for data integrity verification^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/checksum">om:checksum</a>
    /// </summary>
    let checksum = _prefixId.prefix "checksum"
    /// <summary>
    ///   <para>rdfs:label : column count^^xsd:string</para>
    ///   <para>rdfs:comment : Number of columns in the table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/columnCount">om:columnCount</a>
    /// </summary>
    let columnCount = _prefixId.prefix "columnCount"
    /// <summary>
    ///   <para>rdfs:label : column data type^^xsd:string</para>
    ///   <para>rdfs:comment : Data type of the column^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/columnDataType">om:columnDataType</a>
    /// </summary>
    let columnDataType = _prefixId.prefix "columnDataType"
    /// <summary>
    ///   <para>rdfs:label : column description^^xsd:string</para>
    ///   <para>rdfs:comment : Description of what the column contains^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/columnDescription">om:columnDescription</a>
    /// </summary>
    let columnDescription = _prefixId.prefix "columnDescription"
    /// <summary>
    ///   <para>rdfs:label : completeness^^xsd:string</para>
    ///   <para>rdfs:comment : Degree of data completeness^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/completeness">om:completeness</a>
    /// </summary>
    let completeness = _prefixId.prefix "completeness"
    /// <summary>
    ///   <para>rdfs:label : compression format^^xsd:string</para>
    ///   <para>rdfs:comment : Compression format of the distribution^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/compressFormat">om:compressFormat</a>
    /// </summary>
    let compressFormat = _prefixId.prefix "compressFormat"
    /// <summary>
    ///   <para>rdfs:label : concurrency^^xsd:string</para>
    ///   <para>rdfs:comment : Concurrency level of the pipeline^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/concurrency">om:concurrency</a>
    /// </summary>
    let concurrency = _prefixId.prefix "concurrency"
    /// <summary>
    ///   <para>rdfs:label : conforms to^^xsd:string</para>
    ///   <para>rdfs:comment : Standard or schema that the resource conforms to^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/conformsTo">om:conformsTo</a>
    /// </summary>
    let conformsTo = _prefixId.prefix "conformsTo"
    /// <summary>
    ///   <para>rdfs:label : conforms to standard^^xsd:string</para>
    ///   <para>rdfs:comment : Standard the dataset conforms to^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/conformsToStandard">om:conformsToStandard</a>
    /// </summary>
    let conformsToStandard = _prefixId.prefix "conformsToStandard"
    /// <summary>
    ///   <para>rdfs:label : consistency^^xsd:string</para>
    ///   <para>rdfs:comment : Degree of data consistency^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/consistency">om:consistency</a>
    /// </summary>
    let consistency = _prefixId.prefix "consistency"
    /// <summary>
    ///   <para>rdfs:label : consumes from^^xsd:string</para>
    ///   <para>rdfs:comment : Data products that this product consumes data from^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/consumesFrom">om:consumesFrom</a>
    /// </summary>
    let consumesFrom = _prefixId.prefix "consumesFrom"
    /// <summary>
    ///   <para>rdfs:label : contact point^^xsd:string</para>
    ///   <para>rdfs:comment : Contact information for the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/contactPoint">om:contactPoint</a>
    /// </summary>
    let contactPoint = _prefixId.prefix "contactPoint"
    /// <summary>
    ///   <para>rdfs:label : contains^^xsd:string</para>
    ///   <para>rdfs:comment : Hierarchical containment relationship^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/contains">om:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : contains posts^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/containsPosts">om:containsPosts</a>
    /// </summary>
    let containsPosts = _prefixId.prefix "containsPosts"
    /// <summary>
    ///   <para>rdfs:label : content for file^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/contentForFile">om:contentForFile</a>
    /// </summary>
    let contentForFile = _prefixId.prefix "contentForFile"
    /// <summary>
    ///   <para>rdfs:label : content type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/contentType">om:contentType</a>
    /// </summary>
    let contentType = _prefixId.prefix "contentType"
    /// <summary>
    ///   <para>rdfs:label : context URL^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/contextUrl">om:contextUrl</a>
    /// </summary>
    let contextUrl = _prefixId.prefix "contextUrl"
    /// <summary>
    ///   <para>rdfs:label : contributor^^xsd:string</para>
    ///   <para>rdfs:comment : Entity responsible for contributions to the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/contributor">om:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>rdfs:label : control category^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/controlCategory">om:controlCategory</a>
    /// </summary>
    let controlCategory = _prefixId.prefix "controlCategory"
    /// <summary>
    ///   <para>rdfs:label : created^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/created">om:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>rdfs:label : created by^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/createdBy">om:createdBy</a>
    /// </summary>
    let createdBy = _prefixId.prefix "createdBy"
    /// <summary>
    ///   <para>rdfs:label : creates^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/creates">om:creates</a>
    /// </summary>
    let creates = _prefixId.prefix "creates"
    /// <summary>
    ///   <para>rdfs:label : creator^^xsd:string</para>
    ///   <para>rdfs:comment : Entity primarily responsible for creating the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/creator">om:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:label : current content^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/currentContent">om:currentContent</a>
    /// </summary>
    let currentContent = _prefixId.prefix "currentContent"
    /// <summary>
    ///   <para>rdfs:label : data model type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of data model (TableauDataModel, SupersetDataModel, MetabaseDataModel, LookMlView, LookMlExplore, PowerBIDataModel, QlikDataModel)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dataModelType">om:dataModelType</a>
    /// </summary>
    let dataModelType = _prefixId.prefix "dataModelType"
    /// <summary>
    ///   <para>rdfs:label : data product assets^^xsd:string</para>
    ///   <para>rdfs:comment : Assets that are part of this data product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dataProductAssets">om:dataProductAssets</a>
    /// </summary>
    let dataProductAssets = _prefixId.prefix "dataProductAssets"
    /// <summary>
    ///   <para>rdfs:label : data product domain^^xsd:string</para>
    ///   <para>rdfs:comment : Domain this data product belongs to^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dataProductDomain">om:dataProductDomain</a>
    /// </summary>
    let dataProductDomain = _prefixId.prefix "dataProductDomain"
    /// <summary>
    ///   <para>rdfs:label : data product expert^^xsd:string</para>
    ///   <para>rdfs:comment : Expert for this data product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dataProductExpert">om:dataProductExpert</a>
    /// </summary>
    let dataProductExpert = _prefixId.prefix "dataProductExpert"
    /// <summary>
    ///   <para>rdfs:label : data product owner^^xsd:string</para>
    ///   <para>rdfs:comment : Owner of the data product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dataProductOwner">om:dataProductOwner</a>
    /// </summary>
    let dataProductOwner = _prefixId.prefix "dataProductOwner"
    /// <summary>
    ///   <para>rdfs:label : data quality dimension^^xsd:string</para>
    ///   <para>rdfs:comment : Data quality dimension (Completeness, Accuracy, Consistency, Validity, Uniqueness, Integrity, SQL)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dataQualityDimension">om:dataQualityDimension</a>
    /// </summary>
    let dataQualityDimension = _prefixId.prefix "dataQualityDimension"
    /// <summary>
    ///   <para>rdfs:label : dataset^^xsd:string</para>
    ///   <para>rdfs:comment : Dataset that is part of the catalog^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dataset">om:dataset</a>
    /// </summary>
    let dataset = _prefixId.prefix "dataset"
    /// <summary>
    ///   <para>rdfs:label : defaults to^^xsd:string</para>
    ///   <para>rdfs:comment : Default value relationship^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/defaultsTo">om:defaultsTo</a>
    /// </summary>
    let defaultsTo = _prefixId.prefix "defaultsTo"
    /// <summary>
    ///   <para>rdfs:label : deleted^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the entity has been soft deleted^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/deleted">om:deleted</a>
    /// </summary>
    let deleted = _prefixId.prefix "deleted"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/description">om:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : development stage^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/developmentStage">om:developmentStage</a>
    /// </summary>
    let developmentStage = _prefixId.prefix "developmentStage"
    /// <summary>
    ///   <para>rdfs:label : dimension^^xsd:string</para>
    ///   <para>rdfs:comment : Dimension represented in the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dimension">om:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>rdfs:label : distribution^^xsd:string</para>
    ///   <para>rdfs:comment : Available distribution of the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/distribution">om:distribution</a>
    /// </summary>
    let distribution = _prefixId.prefix "distribution"
    /// <summary>
    ///   <para>rdfs:label : down votes^^xsd:string</para>
    ///   <para>rdfs:comment : Number of down votes^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/downVotes">om:downVotes</a>
    /// </summary>
    let downVotes = _prefixId.prefix "downVotes"
    /// <summary>
    ///   <para>rdfs:label : download URL^^xsd:string</para>
    ///   <para>rdfs:comment : Direct download URL^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/downloadURL">om:downloadURL</a>
    /// </summary>
    let downloadURL = _prefixId.prefix "downloadURL"
    /// <summary>
    ///   <para>rdfs:label : downstream^^xsd:string</para>
    ///   <para>rdfs:comment : Data lineage downstream relationship^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/downstream">om:downstream</a>
    /// </summary>
    let downstream = _prefixId.prefix "downstream"
    /// <summary>
    ///   <para>rdfs:label : due date^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/dueDate">om:dueDate</a>
    /// </summary>
    let dueDate = _prefixId.prefix "dueDate"
    /// <summary>
    ///   <para>rdfs:label : edited by^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/editedBy">om:editedBy</a>
    /// </summary>
    let editedBy = _prefixId.prefix "editedBy"
    /// <summary>
    ///   <para>rdfs:label : end date^^xsd:string</para>
    ///   <para>rdfs:comment : End of the temporal period^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/endDate">om:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : endpoint description^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/endpointDescription">om:endpointDescription</a>
    /// </summary>
    let endpointDescription = _prefixId.prefix "endpointDescription"
    /// <summary>
    ///   <para>rdfs:label : endpoint URL^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/endpointURL">om:endpointURL</a>
    /// </summary>
    let endpointURL = _prefixId.prefix "endpointURL"
    /// <summary>
    ///   <para>rdfs:label : ends at^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/endsAt">om:endsAt</a>
    /// </summary>
    let endsAt = _prefixId.prefix "endsAt"
    /// <summary>
    ///   <para>rdfs:label : entity link^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/entityLink">om:entityLink</a>
    /// </summary>
    let entityLink = _prefixId.prefix "entityLink"
    /// <summary>
    ///   <para>rdfs:label : evidence requirement^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/evidenceRequirement">om:evidenceRequirement</a>
    /// </summary>
    let evidenceRequirement = _prefixId.prefix "evidenceRequirement"
    /// <summary>
    ///   <para>rdfs:label : excluded activity entity type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/excludedActivityEntityType">om:excludedActivityEntityType</a>
    /// </summary>
    let excludedActivityEntityType = _prefixId.prefix "excludedActivityEntityType"
    /// <summary>
    ///   <para>rdfs:label : excluded activity event type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/excludedActivityEventType">om:excludedActivityEventType</a>
    /// </summary>
    let excludedActivityEventType = _prefixId.prefix "excludedActivityEventType"
    /// <summary>
    ///   <para>rdfs:label : executed agent^^xsd:string</para>
    ///   <para>rdfs:comment : Agent execution was an execution of this AI application^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/executedAgent">om:executedAgent</a>
    /// </summary>
    let executedAgent = _prefixId.prefix "executedAgent"
    /// <summary>
    ///   <para>rdfs:label : executed MCP server^^xsd:string</para>
    ///   <para>rdfs:comment : MCP execution was an execution of this MCP server^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/executedMCPServer">om:executedMCPServer</a>
    /// </summary>
    let executedMCPServer = _prefixId.prefix "executedMCPServer"
    /// <summary>
    ///   <para>rdfs:label : execution status^^xsd:string</para>
    ///   <para>rdfs:comment : Status of an agent or MCP execution (Running, Success, Failed, Timeout, Cancelled, PartialSuccess)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/executionStatus">om:executionStatus</a>
    /// </summary>
    let executionStatus = _prefixId.prefix "executionStatus"
    /// <summary>
    ///   <para>rdfs:label : expert^^xsd:string</para>
    ///   <para>rdfs:comment : User is expert on entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/expert">om:expert</a>
    /// </summary>
    let expert = _prefixId.prefix "expert"
    /// <summary>
    ///   <para>rdfs:label : file name^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/fileName">om:fileName</a>
    /// </summary>
    let fileName = _prefixId.prefix "fileName"
    /// <summary>
    ///   <para>rdfs:label : file size^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/fileSize">om:fileSize</a>
    /// </summary>
    let fileSize = _prefixId.prefix "fileSize"
    /// <summary>
    ///   <para>rdfs:label : file type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/fileType">om:fileType</a>
    /// </summary>
    let fileType = _prefixId.prefix "fileType"
    /// <summary>
    ///   <para>rdfs:label : first^^xsd:string</para>
    ///   <para>rdfs:comment : First dataset in a series^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/first">om:first</a>
    /// </summary>
    let first = _prefixId.prefix "first"
    /// <summary>
    ///   <para>rdfs:label : follows^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/follows">om:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:label : form field^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/formField">om:formField</a>
    /// </summary>
    let formField = _prefixId.prefix "formField"
    /// <summary>
    ///   <para>rdfs:label : form schema^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/formSchema">om:formSchema</a>
    /// </summary>
    let formSchema = _prefixId.prefix "formSchema"
    /// <summary>
    ///   <para>rdfs:label : format^^xsd:string</para>
    ///   <para>rdfs:comment : File format of the distribution^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/format">om:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    /// <summary>
    ///   <para>rdfs:label : framework region^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/frameworkRegion">om:frameworkRegion</a>
    /// </summary>
    let frameworkRegion = _prefixId.prefix "frameworkRegion"
    /// <summary>
    ///   <para>rdfs:label : framework source^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/frameworkSource">om:frameworkSource</a>
    /// </summary>
    let frameworkSource = _prefixId.prefix "frameworkSource"
    /// <summary>
    ///   <para>rdfs:label : from column^^xsd:string</para>
    ///   <para>rdfs:comment : Source column used in transformation^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/fromColumn">om:fromColumn</a>
    /// </summary>
    let fromColumn = _prefixId.prefix "fromColumn"
    /// <summary>
    ///   <para>rdfs:label : fully qualified name^^xsd:string</para>
    ///   <para>rdfs:comment : Unique identifier for the entity within OpenMetadata^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/fullyQualifiedName">om:fullyQualifiedName</a>
    /// </summary>
    let fullyQualifiedName = _prefixId.prefix "fullyQualifiedName"
    /// <summary>
    ///   <para>rdfs:label : geometry^^xsd:string</para>
    ///   <para>rdfs:comment : Geometry of the spatial area^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/geometry">om:geometry</a>
    /// </summary>
    let geometry = _prefixId.prefix "geometry"
    /// <summary>
    ///   <para>rdfs:label : governed by^^xsd:string</para>
    ///   <para>rdfs:comment : AI application, LLM model or MCP server is governed by an AI governance policy^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/governedBy">om:governedBy</a>
    /// </summary>
    let governedBy = _prefixId.prefix "governedBy"
    /// <summary>
    ///   <para>rdfs:label : had role^^xsd:string</para>
    ///   <para>rdfs:comment : Role in a qualified relationship^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hadRole">om:hadRole</a>
    /// </summary>
    let hadRole = _prefixId.prefix "hadRole"
    /// <summary>
    ///   <para>rdfs:label : has^^xsd:string</para>
    ///   <para>rdfs:comment : General possession relationship^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/has">om:has</a>
    /// </summary>
    let has = _prefixId.prefix "has"
    /// <summary>
    ///   <para>rdfs:label : has beginning^^xsd:string</para>
    ///   <para>rdfs:comment : Beginning instant of the temporal period^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasBeginning">om:hasBeginning</a>
    /// </summary>
    let hasBeginning = _prefixId.prefix "hasBeginning"
    /// <summary>
    ///   <para>rdfs:label : has certification^^xsd:string</para>
    ///   <para>rdfs:comment : Certification status of the asset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasCertification">om:hasCertification</a>
    /// </summary>
    let hasCertification = _prefixId.prefix "hasCertification"
    /// <summary>
    ///   <para>rdfs:label : has change description^^xsd:string</para>
    ///   <para>rdfs:comment : Change that led to this version of the entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasChangeDescription">om:hasChangeDescription</a>
    /// </summary>
    let hasChangeDescription = _prefixId.prefix "hasChangeDescription"
    /// <summary>
    ///   <para>rdfs:label : has column^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasColumn">om:hasColumn</a>
    /// </summary>
    let hasColumn = _prefixId.prefix "hasColumn"
    /// <summary>
    ///   <para>rdfs:label : has data products^^xsd:string</para>
    ///   <para>rdfs:comment : Data products this entity is part of^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasDataProducts">om:hasDataProducts</a>
    /// </summary>
    let hasDataProducts = _prefixId.prefix "hasDataProducts"
    /// <summary>
    ///   <para>rdfs:label : has domains^^xsd:string</para>
    ///   <para>rdfs:comment : Domains the entity belongs to^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasDomains">om:hasDomains</a>
    /// </summary>
    let hasDomains = _prefixId.prefix "hasDomains"
    /// <summary>
    ///   <para>rdfs:label : has end^^xsd:string</para>
    ///   <para>rdfs:comment : Ending instant of the temporal period^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasEnd">om:hasEnd</a>
    /// </summary>
    let hasEnd = _prefixId.prefix "hasEnd"
    /// <summary>
    ///   <para>rdfs:label : has entity status^^xsd:string</para>
    ///   <para>rdfs:comment : Current status of the entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasEntityStatus">om:hasEntityStatus</a>
    /// </summary>
    let hasEntityStatus = _prefixId.prefix "hasEntityStatus"
    /// <summary>
    ///   <para>rdfs:label : has followers^^xsd:string</para>
    ///   <para>rdfs:comment : Users who follow this entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasFollowers">om:hasFollowers</a>
    /// </summary>
    let hasFollowers = _prefixId.prefix "hasFollowers"
    /// <summary>
    ///   <para>rdfs:label : has governance framework^^xsd:string</para>
    ///   <para>rdfs:comment : AI governance framework associated with a control or audit report^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasGovernanceFramework">om:hasGovernanceFramework</a>
    /// </summary>
    let hasGovernanceFramework = _prefixId.prefix "hasGovernanceFramework"

    /// <summary>
    ///   <para>rdfs:label : has incremental change description^^xsd:string</para>
    ///   <para>rdfs:comment : Incremental change that led to this version^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasIncrementalChangeDescription">om:hasIncrementalChangeDescription</a>
    /// </summary>
    let hasIncrementalChangeDescription = _prefixId.prefix "hasIncrementalChangeDescription"

    /// <summary>
    ///   <para>rdfs:label : has input port^^xsd:string</para>
    ///   <para>rdfs:comment : Input port of the data product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasInputPort">om:hasInputPort</a>
    /// </summary>
    let hasInputPort = _prefixId.prefix "hasInputPort"
    /// <summary>
    ///   <para>rdfs:label : has life cycle^^xsd:string</para>
    ///   <para>rdfs:comment : Life cycle properties of the entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasLifeCycle">om:hasLifeCycle</a>
    /// </summary>
    let hasLifeCycle = _prefixId.prefix "hasLifeCycle"
    /// <summary>
    ///   <para>rdfs:label : has MCP prompt^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasMCPPrompt">om:hasMCPPrompt</a>
    /// </summary>
    let hasMCPPrompt = _prefixId.prefix "hasMCPPrompt"
    /// <summary>
    ///   <para>rdfs:label : has MCP resource^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasMCPResource">om:hasMCPResource</a>
    /// </summary>
    let hasMCPResource = _prefixId.prefix "hasMCPResource"
    /// <summary>
    ///   <para>rdfs:label : has MCP tool^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasMCPTool">om:hasMCPTool</a>
    /// </summary>
    let hasMCPTool = _prefixId.prefix "hasMCPTool"
    /// <summary>
    ///   <para>rdfs:label : has model call^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasModelCall">om:hasModelCall</a>
    /// </summary>
    let hasModelCall = _prefixId.prefix "hasModelCall"
    /// <summary>
    ///   <para>rdfs:label : has output port^^xsd:string</para>
    ///   <para>rdfs:comment : Output port of the data product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasOutputPort">om:hasOutputPort</a>
    /// </summary>
    let hasOutputPort = _prefixId.prefix "hasOutputPort"
    /// <summary>
    ///   <para>rdfs:label : has owner^^xsd:string</para>
    ///   <para>rdfs:comment : Agent responsible for the entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasOwner">om:hasOwner</a>
    /// </summary>
    let hasOwner = _prefixId.prefix "hasOwner"
    /// <summary>
    ///   <para>rdfs:label : has owners^^xsd:string</para>
    ///   <para>rdfs:comment : Owners of this entity (plural)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasOwners">om:hasOwners</a>
    /// </summary>
    let hasOwners = _prefixId.prefix "hasOwners"
    /// <summary>
    ///   <para>rdfs:label : has parameter definition^^xsd:string</para>
    ///   <para>rdfs:comment : Parameter definitions for a test^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasParameterDefinition">om:hasParameterDefinition</a>
    /// </summary>
    let hasParameterDefinition = _prefixId.prefix "hasParameterDefinition"
    /// <summary>
    ///   <para>rdfs:label : has pipeline status^^xsd:string</para>
    ///   <para>rdfs:comment : Latest status of the pipeline^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasPipelineStatus">om:hasPipelineStatus</a>
    /// </summary>
    let hasPipelineStatus = _prefixId.prefix "hasPipelineStatus"
    /// <summary>
    ///   <para>rdfs:label : has policy^^xsd:string</para>
    ///   <para>rdfs:comment : ODRL policy associated with the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasPolicy">om:hasPolicy</a>
    /// </summary>
    let hasPolicy = _prefixId.prefix "hasPolicy"
    /// <summary>
    ///   <para>rdfs:label : has policy rule^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasPolicyRule">om:hasPolicyRule</a>
    /// </summary>
    let hasPolicyRule = _prefixId.prefix "hasPolicyRule"
    /// <summary>
    ///   <para>rdfs:label : has profile^^xsd:string</para>
    ///   <para>rdfs:comment : Latest profile data for the table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasProfile">om:hasProfile</a>
    /// </summary>
    let hasProfile = _prefixId.prefix "hasProfile"
    /// <summary>
    ///   <para>rdfs:label : has profiler config^^xsd:string</para>
    ///   <para>rdfs:comment : Profiler configuration for the table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasProfilerConfig">om:hasProfilerConfig</a>
    /// </summary>
    let hasProfilerConfig = _prefixId.prefix "hasProfilerConfig"
    /// <summary>
    ///   <para>rdfs:label : has quality annotation^^xsd:string</para>
    ///   <para>rdfs:comment : Quality annotation for the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasQualityAnnotation">om:hasQualityAnnotation</a>
    /// </summary>
    let hasQualityAnnotation = _prefixId.prefix "hasQualityAnnotation"
    /// <summary>
    ///   <para>rdfs:label : has quality measurement^^xsd:string</para>
    ///   <para>rdfs:comment : Quality measurement for the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasQualityMeasurement">om:hasQualityMeasurement</a>
    /// </summary>
    let hasQualityMeasurement = _prefixId.prefix "hasQualityMeasurement"
    /// <summary>
    ///   <para>rdfs:label : has resource access^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasResourceAccess">om:hasResourceAccess</a>
    /// </summary>
    let hasResourceAccess = _prefixId.prefix "hasResourceAccess"
    /// <summary>
    ///   <para>rdfs:label : has SLA^^xsd:string</para>
    ///   <para>rdfs:comment : Service Level Agreement for the data product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasSLA">om:hasSLA</a>
    /// </summary>
    let hasSLA = _prefixId.prefix "hasSLA"
    /// <summary>
    ///   <para>rdfs:label : has tag^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasTag">om:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>rdfs:label : has tool call^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasToolCall">om:hasToolCall</a>
    /// </summary>
    let hasToolCall = _prefixId.prefix "hasToolCall"
    /// <summary>
    ///   <para>rdfs:label : has version^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasVersion">om:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : has votes^^xsd:string</para>
    ///   <para>rdfs:comment : Votes on the entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/hasVotes">om:hasVotes</a>
    /// </summary>
    let hasVotes = _prefixId.prefix "hasVotes"
    /// <summary>
    ///   <para>rdfs:label : homepage^^xsd:string</para>
    ///   <para>rdfs:comment : Homepage of the catalog^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/homepage">om:homepage</a>
    /// </summary>
    let homepage = _prefixId.prefix "homepage"
    /// <summary>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <para>rdfs:comment : Unique identifier of the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/identifier">om:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : impersonated by^^xsd:string</para>
    ///   <para>rdfs:comment : Bot user that performed the action on behalf of the actual user^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/impersonatedBy">om:impersonatedBy</a>
    /// </summary>
    let impersonatedBy = _prefixId.prefix "impersonatedBy"
    /// <summary>
    ///   <para>rdfs:label : in folder^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/inFolder">om:inFolder</a>
    /// </summary>
    let inFolder = _prefixId.prefix "inFolder"
    /// <summary>
    ///   <para>rdfs:label : in series^^xsd:string</para>
    ///   <para>rdfs:comment : Links a dataset to its series^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/inSeries">om:inSeries</a>
    /// </summary>
    let inSeries = _prefixId.prefix "inSeries"
    /// <summary>
    ///   <para>rdfs:label : is about^^xsd:string</para>
    ///   <para>rdfs:comment : Thread or post is about an entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/isAbout">om:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : is enabled^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/isEnabled">om:isEnabled</a>
    /// </summary>
    let isEnabled = _prefixId.prefix "isEnabled"
    /// <summary>
    ///   <para>rdfs:label : is nullable^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this column can contain null values^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/isNullable">om:isNullable</a>
    /// </summary>
    let isNullable = _prefixId.prefix "isNullable"
    /// <summary>
    ///   <para>rdfs:label : is pinned^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/isPinned">om:isPinned</a>
    /// </summary>
    let isPinned = _prefixId.prefix "isPinned"
    /// <summary>
    ///   <para>rdfs:label : is primary key^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this column is a primary key^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/isPrimaryKey">om:isPrimaryKey</a>
    /// </summary>
    let isPrimaryKey = _prefixId.prefix "isPrimaryKey"
    /// <summary>
    ///   <para>rdfs:label : is referenced by^^xsd:string</para>
    ///   <para>rdfs:comment : Related resource that references this dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/isReferencedBy">om:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = _prefixId.prefix "isReferencedBy"
    /// <summary>
    ///   <para>rdfs:label : is version of^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the non-versioned or abstract dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/isVersionOf">om:isVersionOf</a>
    /// </summary>
    let isVersionOf = _prefixId.prefix "isVersionOf"
    /// <summary>
    ///   <para>rdfs:label : issued^^xsd:string</para>
    ///   <para>rdfs:comment : Date of formal issuance^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/issued">om:issued</a>
    /// </summary>
    let issued = _prefixId.prefix "issued"
    /// <summary>
    ///   <para>rdfs:label : joined with^^xsd:string</para>
    ///   <para>rdfs:comment : Join relationship between tables^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/joinedWith">om:joinedWith</a>
    /// </summary>
    let joinedWith = _prefixId.prefix "joinedWith"
    /// <summary>
    ///   <para>rdfs:label : keyword^^xsd:string</para>
    ///   <para>rdfs:comment : Keywords describing the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/keyword">om:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : landing page^^xsd:string</para>
    ///   <para>rdfs:comment : Web page providing access and information^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/landingPage">om:landingPage</a>
    /// </summary>
    let landingPage = _prefixId.prefix "landingPage"
    /// <summary>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <para>rdfs:comment : Language of the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/language">om:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : last^^xsd:string</para>
    ///   <para>rdfs:comment : Last dataset in a series^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/last">om:last</a>
    /// </summary>
    let last = _prefixId.prefix "last"
    /// <summary>
    ///   <para>rdfs:label : last used at^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/lastUsedAt">om:lastUsedAt</a>
    /// </summary>
    let lastUsedAt = _prefixId.prefix "lastUsedAt"
    /// <summary>
    ///   <para>rdfs:label : license^^xsd:string</para>
    ///   <para>rdfs:comment : License under which the dataset is available^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/license">om:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:label : life cycle accessed^^xsd:string</para>
    ///   <para>rdfs:comment : Access details when entity was last accessed^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/lifeCycleAccessed">om:lifeCycleAccessed</a>
    /// </summary>
    let lifeCycleAccessed = _prefixId.prefix "lifeCycleAccessed"
    /// <summary>
    ///   <para>rdfs:label : life cycle created^^xsd:string</para>
    ///   <para>rdfs:comment : Access details when entity was created^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/lifeCycleCreated">om:lifeCycleCreated</a>
    /// </summary>
    let lifeCycleCreated = _prefixId.prefix "lifeCycleCreated"
    /// <summary>
    ///   <para>rdfs:label : life cycle updated^^xsd:string</para>
    ///   <para>rdfs:comment : Access details when entity was last updated^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/lifeCycleUpdated">om:lifeCycleUpdated</a>
    /// </summary>
    let lifeCycleUpdated = _prefixId.prefix "lifeCycleUpdated"
    /// <summary>
    ///   <para>rdfs:label : lifecycle stage^^xsd:string</para>
    ///   <para>rdfs:comment : Current lifecycle stage (IDEATION, DESIGN, DEVELOPMENT, TESTING, PRODUCTION, DEPRECATED, RETIRED)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/lifecycleStage">om:lifecycleStage</a>
    /// </summary>
    let lifecycleStage = _prefixId.prefix "lifecycleStage"
    /// <summary>
    ///   <para>rdfs:label : lineage created at^^xsd:string</para>
    ///   <para>rdfs:comment : When the lineage was created^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/lineageCreatedAt">om:lineageCreatedAt</a>
    /// </summary>
    let lineageCreatedAt = _prefixId.prefix "lineageCreatedAt"
    /// <summary>
    ///   <para>rdfs:label : lineage created by^^xsd:string</para>
    ///   <para>rdfs:comment : User who created the lineage^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/lineageCreatedBy">om:lineageCreatedBy</a>
    /// </summary>
    let lineageCreatedBy = _prefixId.prefix "lineageCreatedBy"
    /// <summary>
    ///   <para>rdfs:label : lineage source^^xsd:string</para>
    ///   <para>rdfs:comment : How the lineage was created (Manual, Pipeline, Query, etc.)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/lineageSource">om:lineageSource</a>
    /// </summary>
    let lineageSource = _prefixId.prefix "lineageSource"
    /// <summary>
    ///   <para>rdfs:label : measure^^xsd:string</para>
    ///   <para>rdfs:comment : Measure represented in the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/measure">om:measure</a>
    /// </summary>
    let measure = _prefixId.prefix "measure"
    /// <summary>
    ///   <para>rdfs:label : media type^^xsd:string</para>
    ///   <para>rdfs:comment : Media type of the distribution^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/mediaType">om:mediaType</a>
    /// </summary>
    let mediaType = _prefixId.prefix "mediaType"
    /// <summary>
    ///   <para>rdfs:label : member of^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/memberOf">om:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:label : memory answer^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/memoryAnswer">om:memoryAnswer</a>
    /// </summary>
    let memoryAnswer = _prefixId.prefix "memoryAnswer"
    /// <summary>
    ///   <para>rdfs:label : memory count^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/memoryCount">om:memoryCount</a>
    /// </summary>
    let memoryCount = _prefixId.prefix "memoryCount"
    /// <summary>
    ///   <para>rdfs:label : memory question^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/memoryQuestion">om:memoryQuestion</a>
    /// </summary>
    let memoryQuestion = _prefixId.prefix "memoryQuestion"
    /// <summary>
    ///   <para>rdfs:label : memory scope^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/memoryScope">om:memoryScope</a>
    /// </summary>
    let memoryScope = _prefixId.prefix "memoryScope"
    /// <summary>
    ///   <para>rdfs:label : memory status^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/memoryStatus">om:memoryStatus</a>
    /// </summary>
    let memoryStatus = _prefixId.prefix "memoryStatus"
    /// <summary>
    ///   <para>rdfs:label : memory type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/memoryType">om:memoryType</a>
    /// </summary>
    let memoryType = _prefixId.prefix "memoryType"
    /// <summary>
    ///   <para>rdfs:label : memory usage count^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/memoryUsageCount">om:memoryUsageCount</a>
    /// </summary>
    let memoryUsageCount = _prefixId.prefix "memoryUsageCount"
    /// <summary>
    ///   <para>rdfs:label : mentioned in^^xsd:string</para>
    ///   <para>rdfs:comment : Entity is mentioned in a post or thread^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/mentionedIn">om:mentionedIn</a>
    /// </summary>
    let mentionedIn = _prefixId.prefix "mentionedIn"
    /// <summary>
    ///   <para>rdfs:label : model capability^^xsd:string</para>
    ///   <para>rdfs:comment : Capability exposed by the LLM model (TextGeneration, CodeGeneration, Embeddings, Chat, Vision, Audio, FunctionCalling, ToolUse)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/modelCapability">om:modelCapability</a>
    /// </summary>
    let modelCapability = _prefixId.prefix "modelCapability"
    /// <summary>
    ///   <para>rdfs:label : model type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of LLM model (BaseModel, FineTuned, Quantized, Distilled, Adapter, Custom)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/modelType">om:modelType</a>
    /// </summary>
    let modelType = _prefixId.prefix "modelType"
    /// <summary>
    ///   <para>rdfs:label : modified^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/modified">om:modified</a>
    /// </summary>
    let modified = _prefixId.prefix "modified"
    /// <summary>
    ///   <para>rdfs:label : new value^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/newValue">om:newValue</a>
    /// </summary>
    let newValue = _prefixId.prefix "newValue"
    /// <summary>
    ///   <para>rdfs:label : next^^xsd:string</para>
    ///   <para>rdfs:comment : Next dataset in a series^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/next">om:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>rdfs:label : number of columns^^xsd:string</para>
    ///   <para>rdfs:comment : Number of columns in the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/numberOfColumns">om:numberOfColumns</a>
    /// </summary>
    let numberOfColumns = _prefixId.prefix "numberOfColumns"
    /// <summary>
    ///   <para>rdfs:label : number of records^^xsd:string</para>
    ///   <para>rdfs:comment : Number of records in the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/numberOfRecords">om:numberOfRecords</a>
    /// </summary>
    let numberOfRecords = _prefixId.prefix "numberOfRecords"
    /// <summary>
    ///   <para>rdfs:label : old value^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/oldValue">om:oldValue</a>
    /// </summary>
    let oldValue = _prefixId.prefix "oldValue"
    /// <summary>
    ///   <para>rdfs:label : owns^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/owns">om:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    /// <summary>
    ///   <para>rdfs:label : package format^^xsd:string</para>
    ///   <para>rdfs:comment : Package format of the distribution^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/packageFormat">om:packageFormat</a>
    /// </summary>
    let packageFormat = _prefixId.prefix "packageFormat"
    /// <summary>
    ///   <para>rdfs:label : page content^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/pageContent">om:pageContent</a>
    /// </summary>
    let pageContent = _prefixId.prefix "pageContent"
    /// <summary>
    ///   <para>rdfs:label : page count^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/pageCount">om:pageCount</a>
    /// </summary>
    let pageCount = _prefixId.prefix "pageCount"
    /// <summary>
    ///   <para>rdfs:label : page type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/pageType">om:pageType</a>
    /// </summary>
    let pageType = _prefixId.prefix "pageType"
    /// <summary>
    ///   <para>rdfs:label : parent of^^xsd:string</para>
    ///   <para>rdfs:comment : Hierarchical parent relationship^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/parentOf">om:parentOf</a>
    /// </summary>
    let parentOf = _prefixId.prefix "parentOf"
    /// <summary>
    ///   <para>rdfs:label : pipeline^^xsd:string</para>
    ///   <para>rdfs:comment : Pipeline that processes the data^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/pipeline">om:pipeline</a>
    /// </summary>
    let pipeline = _prefixId.prefix "pipeline"
    /// <summary>
    ///   <para>rdfs:label : pipeline location^^xsd:string</para>
    ///   <para>rdfs:comment : Pipeline code location^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/pipelineLocation">om:pipelineLocation</a>
    /// </summary>
    let pipelineLocation = _prefixId.prefix "pipelineLocation"
    /// <summary>
    ///   <para>rdfs:label : policy type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of AI governance policy (ModelApproval, DataAccess, BiasThreshold, ComplianceCheck, CostControl, PerformanceStandard, SecurityControl)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/policyType">om:policyType</a>
    /// </summary>
    let policyType = _prefixId.prefix "policyType"
    /// <summary>
    ///   <para>rdfs:label : port data asset^^xsd:string</para>
    ///   <para>rdfs:comment : Data asset exposed through this port^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/portDataAsset">om:portDataAsset</a>
    /// </summary>
    let portDataAsset = _prefixId.prefix "portDataAsset"
    /// <summary>
    ///   <para>rdfs:label : port endpoint^^xsd:string</para>
    ///   <para>rdfs:comment : Endpoint URL or connection string for the port^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/portEndpoint">om:portEndpoint</a>
    /// </summary>
    let portEndpoint = _prefixId.prefix "portEndpoint"
    /// <summary>
    ///   <para>rdfs:label : port format^^xsd:string</para>
    ///   <para>rdfs:comment : Data format supported by the port (JSON, CSV, PARQUET, etc.)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/portFormat">om:portFormat</a>
    /// </summary>
    let portFormat = _prefixId.prefix "portFormat"
    /// <summary>
    ///   <para>rdfs:label : port name^^xsd:string</para>
    ///   <para>rdfs:comment : Name of the port^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/portName">om:portName</a>
    /// </summary>
    let portName = _prefixId.prefix "portName"
    /// <summary>
    ///   <para>rdfs:label : port protocol^^xsd:string</para>
    ///   <para>rdfs:comment : Protocol used by the port (REST, GRPC, KAFKA, etc.)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/portProtocol">om:portProtocol</a>
    /// </summary>
    let portProtocol = _prefixId.prefix "portProtocol"
    /// <summary>
    ///   <para>rdfs:label : previous^^xsd:string</para>
    ///   <para>rdfs:comment : Previous dataset in a series^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/prev">om:prev</a>
    /// </summary>
    let prev = _prefixId.prefix "prev"
    /// <summary>
    ///   <para>rdfs:label : previous version^^xsd:string</para>
    ///   <para>rdfs:comment : Link to previous version^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/previousVersion">om:previousVersion</a>
    /// </summary>
    let previousVersion = _prefixId.prefix "previousVersion"
    /// <summary>
    ///   <para>rdfs:label : primary entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/primaryEntity">om:primaryEntity</a>
    /// </summary>
    let primaryEntity = _prefixId.prefix "primaryEntity"
    /// <summary>
    ///   <para>rdfs:label : primary topic^^xsd:string</para>
    ///   <para>rdfs:comment : Main entity described by this record^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/primaryTopic">om:primaryTopic</a>
    /// </summary>
    let primaryTopic = _prefixId.prefix "primaryTopic"
    /// <summary>
    ///   <para>rdfs:label : processed lineage^^xsd:string</para>
    ///   <para>rdfs:comment : Whether lineage has been processed for this entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/processedLineage">om:processedLineage</a>
    /// </summary>
    let processedLineage = _prefixId.prefix "processedLineage"
    /// <summary>
    ///   <para>rdfs:label : processing status^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/processingStatus">om:processingStatus</a>
    /// </summary>
    let processingStatus = _prefixId.prefix "processingStatus"
    /// <summary>
    ///   <para>rdfs:label : provenance^^xsd:string</para>
    ///   <para>rdfs:comment : Provenance statement^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/provenance">om:provenance</a>
    /// </summary>
    let provenance = _prefixId.prefix "provenance"
    /// <summary>
    ///   <para>rdfs:label : provides to^^xsd:string</para>
    ///   <para>rdfs:comment : Data products that consume data from this product^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/providesTo">om:providesTo</a>
    /// </summary>
    let providesTo = _prefixId.prefix "providesTo"
    /// <summary>
    ///   <para>rdfs:label : publisher^^xsd:string</para>
    ///   <para>rdfs:comment : Entity responsible for making the dataset available^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/publisher">om:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:label : qualified access^^xsd:string</para>
    ///   <para>rdfs:comment : Qualified access information including authentication and authorization^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/qualifiedAccess">om:qualifiedAccess</a>
    /// </summary>
    let qualifiedAccess = _prefixId.prefix "qualifiedAccess"
    /// <summary>
    ///   <para>rdfs:label : qualified attribution^^xsd:string</para>
    ///   <para>rdfs:comment : Detailed attribution with roles^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/qualifiedAttribution">om:qualifiedAttribution</a>
    /// </summary>
    let qualifiedAttribution = _prefixId.prefix "qualifiedAttribution"
    /// <summary>
    ///   <para>rdfs:label : qualified derivation^^xsd:string</para>
    ///   <para>rdfs:comment : Detailed derivation with transformation info^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/qualifiedDerivation">om:qualifiedDerivation</a>
    /// </summary>
    let qualifiedDerivation = _prefixId.prefix "qualifiedDerivation"
    /// <summary>
    ///   <para>rdfs:label : qualified relation^^xsd:string</para>
    ///   <para>rdfs:comment : Link to a qualified relationship^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/qualifiedRelation">om:qualifiedRelation</a>
    /// </summary>
    let qualifiedRelation = _prefixId.prefix "qualifiedRelation"
    /// <summary>
    ///   <para>rdfs:label : reacted to^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/reactedTo">om:reactedTo</a>
    /// </summary>
    let reactedTo = _prefixId.prefix "reactedTo"
    /// <summary>
    ///   <para>rdfs:label : reaction^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/reaction">om:reaction</a>
    /// </summary>
    let reaction = _prefixId.prefix "reaction"
    /// <summary>
    ///   <para>rdfs:label : record^^xsd:string</para>
    ///   <para>rdfs:comment : Links catalog to its records^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/record">om:record</a>
    /// </summary>
    let record = _prefixId.prefix "record"
    /// <summary>
    ///   <para>rdfs:label : related entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/relatedEntity">om:relatedEntity</a>
    /// </summary>
    let relatedEntity = _prefixId.prefix "relatedEntity"
    /// <summary>
    ///   <para>rdfs:label : related to^^xsd:string</para>
    ///   <para>rdfs:comment : General relationship between entities^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/relatedTo">om:relatedTo</a>
    /// </summary>
    let relatedTo = _prefixId.prefix "relatedTo"
    /// <summary>
    ///   <para>rdfs:label : relates to^^xsd:string</para>
    ///   <para>rdfs:comment : Alternative spelling of relatedTo^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/relatesTo">om:relatesTo</a>
    /// </summary>
    let relatesTo = _prefixId.prefix "relatesTo"
    /// <summary>
    ///   <para>rdfs:label : relation^^xsd:string</para>
    ///   <para>rdfs:comment : Related resource^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/relation">om:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>rdfs:label : replied to^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/repliedTo">om:repliedTo</a>
    /// </summary>
    let repliedTo = _prefixId.prefix "repliedTo"
    /// <summary>
    ///   <para>rdfs:label : report artifact^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/reportArtifact">om:reportArtifact</a>
    /// </summary>
    let reportArtifact = _prefixId.prefix "reportArtifact"
    /// <summary>
    ///   <para>rdfs:label : audit report format^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/reportFormat">om:reportFormat</a>
    /// </summary>
    let reportFormat = _prefixId.prefix "reportFormat"
    /// <summary>
    ///   <para>rdfs:label : audit report scope^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/reportScope">om:reportScope</a>
    /// </summary>
    let reportScope = _prefixId.prefix "reportScope"
    /// <summary>
    ///   <para>rdfs:label : audit report status^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/reportStatus">om:reportStatus</a>
    /// </summary>
    let reportStatus = _prefixId.prefix "reportStatus"
    /// <summary>
    ///   <para>rdfs:label : requested by^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/requestedBy">om:requestedBy</a>
    /// </summary>
    let requestedBy = _prefixId.prefix "requestedBy"
    /// <summary>
    ///   <para>rdfs:label : required field^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/requiredField">om:requiredField</a>
    /// </summary>
    let requiredField = _prefixId.prefix "requiredField"
    /// <summary>
    ///   <para>rdfs:label : learning resource category^^xsd:string</para>
    ///   <para>rdfs:comment : Primary topic grouping (Discovery, Administration, DataGovernance, DataQuality, Observability, AI)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/resourceCategory">om:resourceCategory</a>
    /// </summary>
    let resourceCategory = _prefixId.prefix "resourceCategory"
    /// <summary>
    ///   <para>rdfs:label : learning resource difficulty^^xsd:string</para>
    ///   <para>rdfs:comment : Suggested proficiency tier (Intro, Intermediate, Advanced)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/resourceDifficulty">om:resourceDifficulty</a>
    /// </summary>
    let resourceDifficulty = _prefixId.prefix "resourceDifficulty"
    /// <summary>
    ///   <para>rdfs:label : learning resource type^^xsd:string</para>
    ///   <para>rdfs:comment : Kind of learning asset (Storylane, Video, Article)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/resourceType">om:resourceType</a>
    /// </summary>
    let resourceType = _prefixId.prefix "resourceType"
    /// <summary>
    ///   <para>rdfs:label : retention days^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/retentionDays">om:retentionDays</a>
    /// </summary>
    let retentionDays = _prefixId.prefix "retentionDays"
    /// <summary>
    ///   <para>rdfs:label : retention period^^xsd:string</para>
    ///   <para>rdfs:comment : Retention period of the data in ISO 8601 duration format^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/retentionPeriod">om:retentionPeriod</a>
    /// </summary>
    let retentionPeriod = _prefixId.prefix "retentionPeriod"
    /// <summary>
    ///   <para>rdfs:label : reviewed by^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/reviewedBy">om:reviewedBy</a>
    /// </summary>
    let reviewedBy = _prefixId.prefix "reviewedBy"
    /// <summary>
    ///   <para>rdfs:label : reviews^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/reviews">om:reviews</a>
    /// </summary>
    let reviews = _prefixId.prefix "reviews"
    /// <summary>
    ///   <para>rdfs:label : rights^^xsd:string</para>
    ///   <para>rdfs:comment : Rights statement for the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/rights">om:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>rdfs:label : row count^^xsd:string</para>
    ///   <para>rdfs:comment : Number of rows in the table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/rowCount">om:rowCount</a>
    /// </summary>
    let rowCount = _prefixId.prefix "rowCount"
    /// <summary>
    ///   <para>rdfs:label : sample data^^xsd:string</para>
    ///   <para>rdfs:comment : Sample data from the table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/sampleData">om:sampleData</a>
    /// </summary>
    let sampleData = _prefixId.prefix "sampleData"
    /// <summary>
    ///   <para>rdfs:label : schedule interval^^xsd:string</para>
    ///   <para>rdfs:comment : Scheduler interval in cron format^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/scheduleInterval">om:scheduleInterval</a>
    /// </summary>
    let scheduleInterval = _prefixId.prefix "scheduleInterval"
    /// <summary>
    ///   <para>rdfs:label : schema definition^^xsd:string</para>
    ///   <para>rdfs:comment : DDL schema definition for the table^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/schemaDefinition">om:schemaDefinition</a>
    /// </summary>
    let schemaDefinition = _prefixId.prefix "schemaDefinition"
    /// <summary>
    ///   <para>rdfs:label : scope target^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/scopeTarget">om:scopeTarget</a>
    /// </summary>
    let scopeTarget = _prefixId.prefix "scopeTarget"
    /// <summary>
    ///   <para>rdfs:label : MCP server type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of MCP server (DataAccess, FileSystem, WebAPI, Database, Cloud, Security, Development, Communication, Custom)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/serverType">om:serverType</a>
    /// </summary>
    let serverType = _prefixId.prefix "serverType"
    /// <summary>
    ///   <para>rdfs:label : serves dataset^^xsd:string</para>
    ///   <para>rdfs:comment : Links a data service to datasets it serves^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/servesDataset">om:servesDataset</a>
    /// </summary>
    let servesDataset = _prefixId.prefix "servesDataset"
    /// <summary>
    ///   <para>rdfs:label : service^^xsd:string</para>
    ///   <para>rdfs:comment : Service that is part of the catalog^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/service">om:service</a>
    /// </summary>
    let service = _prefixId.prefix "service"
    /// <summary>
    ///   <para>rdfs:label : service endpoint^^xsd:string</para>
    ///   <para>rdfs:comment : Endpoint for accessing the service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/serviceEndpoint">om:serviceEndpoint</a>
    /// </summary>
    let serviceEndpoint = _prefixId.prefix "serviceEndpoint"
    /// <summary>
    ///   <para>rdfs:label : service level^^xsd:string</para>
    ///   <para>rdfs:comment : Service level agreement details^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/serviceLevel">om:serviceLevel</a>
    /// </summary>
    let serviceLevel = _prefixId.prefix "serviceLevel"
    /// <summary>
    ///   <para>rdfs:label : service status^^xsd:string</para>
    ///   <para>rdfs:comment : Operational status of the service^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/serviceStatus">om:serviceStatus</a>
    /// </summary>
    let serviceStatus = _prefixId.prefix "serviceStatus"
    /// <summary>
    ///   <para>rdfs:label : service type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/serviceType">om:serviceType</a>
    /// </summary>
    let serviceType = _prefixId.prefix "serviceType"
    /// <summary>
    ///   <para>rdfs:label : share configuration^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/shareConfig">om:shareConfig</a>
    /// </summary>
    let shareConfig = _prefixId.prefix "shareConfig"
    /// <summary>
    ///   <para>rdfs:label : SLA availability^^xsd:string</para>
    ///   <para>rdfs:comment : Expected availability percentage^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/slaAvailability">om:slaAvailability</a>
    /// </summary>
    let slaAvailability = _prefixId.prefix "slaAvailability"
    /// <summary>
    ///   <para>rdfs:label : SLA data freshness^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum data staleness in minutes^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/slaDataFreshness">om:slaDataFreshness</a>
    /// </summary>
    let slaDataFreshness = _prefixId.prefix "slaDataFreshness"
    /// <summary>
    ///   <para>rdfs:label : SLA data quality^^xsd:string</para>
    ///   <para>rdfs:comment : Minimum data quality score^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/slaDataQuality">om:slaDataQuality</a>
    /// </summary>
    let slaDataQuality = _prefixId.prefix "slaDataQuality"
    /// <summary>
    ///   <para>rdfs:label : SLA response time^^xsd:string</para>
    ///   <para>rdfs:comment : Expected response time in milliseconds^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/slaResponseTime">om:slaResponseTime</a>
    /// </summary>
    let slaResponseTime = _prefixId.prefix "slaResponseTime"
    /// <summary>
    ///   <para>rdfs:label : SLA tier^^xsd:string</para>
    ///   <para>rdfs:comment : SLA tier level (GOLD, SILVER, BRONZE)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/slaTier">om:slaTier</a>
    /// </summary>
    let slaTier = _prefixId.prefix "slaTier"
    /// <summary>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <para>rdfs:comment : Source of the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/source">om:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : source entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/sourceEntity">om:sourceEntity</a>
    /// </summary>
    let sourceEntity = _prefixId.prefix "sourceEntity"
    /// <summary>
    ///   <para>rdfs:label : source hash^^xsd:string</para>
    ///   <para>rdfs:comment : Source hash of the entity for change detection^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/sourceHash">om:sourceHash</a>
    /// </summary>
    let sourceHash = _prefixId.prefix "sourceHash"
    /// <summary>
    ///   <para>rdfs:label : source URL^^xsd:string</para>
    ///   <para>rdfs:comment : URL to visit/manage the entity in the source system^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/sourceUrl">om:sourceUrl</a>
    /// </summary>
    let sourceUrl = _prefixId.prefix "sourceUrl"
    /// <summary>
    ///   <para>rdfs:label : spatial coverage^^xsd:string</para>
    ///   <para>rdfs:comment : Spatial area covered by the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/spatial">om:spatial</a>
    /// </summary>
    let spatial = _prefixId.prefix "spatial"
    /// <summary>
    ///   <para>rdfs:label : spatial resolution^^xsd:string</para>
    ///   <para>rdfs:comment : Minimum spatial separation resolvable in the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/spatialResolution">om:spatialResolution</a>
    /// </summary>
    let spatialResolution = _prefixId.prefix "spatialResolution"
    /// <summary>
    ///   <para>rdfs:label : SQL query^^xsd:string</para>
    ///   <para>rdfs:comment : SQL query used in transformation^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/sqlQuery">om:sqlQuery</a>
    /// </summary>
    let sqlQuery = _prefixId.prefix "sqlQuery"
    /// <summary>
    ///   <para>rdfs:label : start date^^xsd:string</para>
    ///   <para>rdfs:comment : Start of the temporal period^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/startDate">om:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:label : starts at^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/startsAt">om:startsAt</a>
    /// </summary>
    let startsAt = _prefixId.prefix "startsAt"
    /// <summary>
    ///   <para>rdfs:label : statistical unit^^xsd:string</para>
    ///   <para>rdfs:comment : Unit of observation in the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/statisticalUnit">om:statisticalUnit</a>
    /// </summary>
    let statisticalUnit = _prefixId.prefix "statisticalUnit"
    /// <summary>
    ///   <para>rdfs:label : supported data types^^xsd:string</para>
    ///   <para>rdfs:comment : Data types supported by this test definition^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/supportedDataTypes">om:supportedDataTypes</a>
    /// </summary>
    let supportedDataTypes = _prefixId.prefix "supportedDataTypes"
    /// <summary>
    ///   <para>rdfs:label : supports dynamic assertion^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the test case supports dynamic assertions^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/supportsDynamicAssertion">om:supportsDynamicAssertion</a>
    /// </summary>
    let supportsDynamicAssertion = _prefixId.prefix "supportsDynamicAssertion"
    /// <summary>
    ///   <para>rdfs:label : supports row level passed failed^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the test case supports row level passed/failed^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/supportsRowLevelPassedFailed">om:supportsRowLevelPassedFailed</a>
    /// </summary>
    let supportsRowLevelPassedFailed = _prefixId.prefix "supportsRowLevelPassedFailed"
    /// <summary>
    ///   <para>rdfs:label : table type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of table (Regular, External, View, MaterializedView, etc.)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/tableType">om:tableType</a>
    /// </summary>
    let tableType = _prefixId.prefix "tableType"
    /// <summary>
    ///   <para>rdfs:label : target entity type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/targetEntityType">om:targetEntityType</a>
    /// </summary>
    let targetEntityType = _prefixId.prefix "targetEntityType"
    /// <summary>
    ///   <para>rdfs:label : task category^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/taskCategory">om:taskCategory</a>
    /// </summary>
    let taskCategory = _prefixId.prefix "taskCategory"
    /// <summary>
    ///   <para>rdfs:label : task comment^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/taskComment">om:taskComment</a>
    /// </summary>
    let taskComment = _prefixId.prefix "taskComment"
    /// <summary>
    ///   <para>rdfs:label : task identifier^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/taskIdentifier">om:taskIdentifier</a>
    /// </summary>
    let taskIdentifier = _prefixId.prefix "taskIdentifier"
    /// <summary>
    ///   <para>rdfs:label : task payload^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/taskPayload">om:taskPayload</a>
    /// </summary>
    let taskPayload = _prefixId.prefix "taskPayload"
    /// <summary>
    ///   <para>rdfs:label : task priority^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/taskPriority">om:taskPriority</a>
    /// </summary>
    let taskPriority = _prefixId.prefix "taskPriority"
    /// <summary>
    ///   <para>rdfs:label : task resolution^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/taskResolution">om:taskResolution</a>
    /// </summary>
    let taskResolution = _prefixId.prefix "taskResolution"
    /// <summary>
    ///   <para>rdfs:label : task status^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/taskStatus">om:taskStatus</a>
    /// </summary>
    let taskStatus = _prefixId.prefix "taskStatus"
    /// <summary>
    ///   <para>rdfs:label : task type^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/taskType">om:taskType</a>
    /// </summary>
    let taskType = _prefixId.prefix "taskType"
    /// <summary>
    ///   <para>rdfs:label : template variable^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/templateVariable">om:templateVariable</a>
    /// </summary>
    let templateVariable = _prefixId.prefix "templateVariable"
    /// <summary>
    ///   <para>rdfs:label : temporal coverage^^xsd:string</para>
    ///   <para>rdfs:comment : Temporal period covered by the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/temporal">om:temporal</a>
    /// </summary>
    let temporal = _prefixId.prefix "temporal"
    /// <summary>
    ///   <para>rdfs:label : temporal resolution^^xsd:string</para>
    ///   <para>rdfs:comment : Minimum time period resolvable in the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/temporalResolution">om:temporalResolution</a>
    /// </summary>
    let temporalResolution = _prefixId.prefix "temporalResolution"
    /// <summary>
    ///   <para>rdfs:label : test platform^^xsd:string</para>
    ///   <para>rdfs:comment : Platform where tests are defined (OpenMetadata, GreatExpectations, dbt, Deequ, Soda, Other)^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/testPlatform">om:testPlatform</a>
    /// </summary>
    let testPlatform = _prefixId.prefix "testPlatform"
    /// <summary>
    ///   <para>rdfs:label : tested by^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/testedBy">om:testedBy</a>
    /// </summary>
    let testedBy = _prefixId.prefix "testedBy"
    /// <summary>
    ///   <para>rdfs:label : theme^^xsd:string</para>
    ///   <para>rdfs:comment : Main category of the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/theme">om:theme</a>
    /// </summary>
    let theme = _prefixId.prefix "theme"
    /// <summary>
    ///   <para>rdfs:label : theme taxonomy^^xsd:string</para>
    ///   <para>rdfs:comment : Knowledge organization system for categorizing datasets^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/themeTaxonomy">om:themeTaxonomy</a>
    /// </summary>
    let themeTaxonomy = _prefixId.prefix "themeTaxonomy"
    /// <summary>
    ///   <para>rdfs:label : timeliness^^xsd:string</para>
    ///   <para>rdfs:comment : How current the data is^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/timeliness">om:timeliness</a>
    /// </summary>
    let timeliness = _prefixId.prefix "timeliness"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : Title of the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/title">om:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : to column^^xsd:string</para>
    ///   <para>rdfs:comment : Target column created by transformation^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/toColumn">om:toColumn</a>
    /// </summary>
    let toColumn = _prefixId.prefix "toColumn"
    /// <summary>
    ///   <para>rdfs:label : training metadata^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/trainingMetadata">om:trainingMetadata</a>
    /// </summary>
    let trainingMetadata = _prefixId.prefix "trainingMetadata"
    /// <summary>
    ///   <para>rdfs:label : transformation function^^xsd:string</para>
    ///   <para>rdfs:comment : Function applied to transform data^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/transformationFunction">om:transformationFunction</a>
    /// </summary>
    let transformationFunction = _prefixId.prefix "transformationFunction"
    /// <summary>
    ///   <para>rdfs:label : transition forms^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/transitionForms">om:transitionForms</a>
    /// </summary>
    let transitionForms = _prefixId.prefix "transitionForms"
    /// <summary>
    ///   <para>rdfs:label : MCP transport type^^xsd:string</para>
    ///   <para>rdfs:comment : Transport protocol used by the MCP server^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/transportType">om:transportType</a>
    /// </summary>
    let transportType = _prefixId.prefix "transportType"
    /// <summary>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <para>rdfs:comment : Nature or genre of the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/type">om:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : UI schema^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/uiSchema">om:uiSchema</a>
    /// </summary>
    let uiSchema = _prefixId.prefix "uiSchema"
    /// <summary>
    ///   <para>rdfs:label : uniqueness^^xsd:string</para>
    ///   <para>rdfs:comment : Degree of uniqueness in the data^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/uniqueness">om:uniqueness</a>
    /// </summary>
    let uniqueness = _prefixId.prefix "uniqueness"
    /// <summary>
    ///   <para>rdfs:label : up votes^^xsd:string</para>
    ///   <para>rdfs:comment : Number of up votes^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/upVotes">om:upVotes</a>
    /// </summary>
    let upVotes = _prefixId.prefix "upVotes"
    /// <summary>
    ///   <para>rdfs:label : updated at^^xsd:string</para>
    ///   <para>rdfs:comment : Last update time in Unix epoch milliseconds^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/updatedAt">om:updatedAt</a>
    /// </summary>
    let updatedAt = _prefixId.prefix "updatedAt"
    /// <summary>
    ///   <para>rdfs:label : updated by^^xsd:string</para>
    ///   <para>rdfs:comment : User who made the update^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/updatedBy">om:updatedBy</a>
    /// </summary>
    let updatedBy = _prefixId.prefix "updatedBy"
    /// <summary>
    ///   <para>rdfs:label : upstream^^xsd:string</para>
    ///   <para>rdfs:comment : Data lineage upstream relationship^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/upstream">om:upstream</a>
    /// </summary>
    let upstream = _prefixId.prefix "upstream"
    /// <summary>
    ///   <para>rdfs:label : usage summary^^xsd:string</para>
    ///   <para>rdfs:comment : Latest usage information for the entity^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/usageSummary">om:usageSummary</a>
    /// </summary>
    let usageSummary = _prefixId.prefix "usageSummary"
    /// <summary>
    ///   <para>rdfs:label : uses^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/uses">om:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
    /// <summary>
    ///   <para>rdfs:label : uses MCP server^^xsd:string</para>
    ///   <para>rdfs:comment : AI application uses an MCP server for tools, resources or prompts^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/usesMCPServer">om:usesMCPServer</a>
    /// </summary>
    let usesMCPServer = _prefixId.prefix "usesMCPServer"
    /// <summary>
    ///   <para>rdfs:label : uses model^^xsd:string</para>
    ///   <para>rdfs:comment : AI application or agent execution uses an LLM model^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/usesModel">om:usesModel</a>
    /// </summary>
    let usesModel = _prefixId.prefix "usesModel"
    /// <summary>
    ///   <para>rdfs:label : uses prompt template^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/usesPromptTemplate">om:usesPromptTemplate</a>
    /// </summary>
    let usesPromptTemplate = _prefixId.prefix "usesPromptTemplate"
    /// <summary>
    ///   <para>rdfs:label : uses task form schema^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/usesTaskFormSchema">om:usesTaskFormSchema</a>
    /// </summary>
    let usesTaskFormSchema = _prefixId.prefix "usesTaskFormSchema"
    /// <summary>
    ///   <para>rdfs:label : validity^^xsd:string</para>
    ///   <para>rdfs:comment : Degree to which data conforms to defined rules^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/validity">om:validity</a>
    /// </summary>
    let validity = _prefixId.prefix "validity"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <para>rdfs:comment : Version identifier^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/version">om:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>rdfs:label : version notes^^xsd:string</para>
    ///   <para>rdfs:comment : Notes about this version^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/versionNotes">om:versionNotes</a>
    /// </summary>
    let versionNotes = _prefixId.prefix "versionNotes"
    /// <summary>
    ///   <para>rdfs:label : voted^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/voted">om:voted</a>
    /// </summary>
    let voted = _prefixId.prefix "voted"
    /// <summary>
    ///   <para>rdfs:label : was derived from^^xsd:string</para>
    ///   <para>rdfs:comment : Source dataset this was derived from^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/wasDerivedFrom">om:wasDerivedFrom</a>
    /// </summary>
    let wasDerivedFrom = _prefixId.prefix "wasDerivedFrom"
    /// <summary>
    ///   <para>rdfs:label : was generated by^^xsd:string</para>
    ///   <para>rdfs:comment : Activity that generated the dataset^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/wasGeneratedBy">om:wasGeneratedBy</a>
    /// </summary>
    let wasGeneratedBy = _prefixId.prefix "wasGeneratedBy"
    /// <summary>
    ///   <para>rdfs:label : watched by^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/watchedBy">om:watchedBy</a>
    /// </summary>
    let watchedBy = _prefixId.prefix "watchedBy"
    /// <summary>
    ///   <para>rdfs:label : workflow instance^^xsd:string</para>
    ///   <a href="https://open-metadata.org/ontology/workflowInstance">om:workflowInstance</a>
    /// </summary>
    let workflowInstance = _prefixId.prefix "workflowInstance"
