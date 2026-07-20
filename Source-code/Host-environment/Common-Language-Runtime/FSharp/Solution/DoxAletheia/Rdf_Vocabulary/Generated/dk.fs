namespace http.www.data_knowledge.org.dk.slash

open DoxAletheia

module dk =
    let _namespace_name = "http://www.data-knowledge.org/dk/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Actual performance values measured at a particular time
    /// <see href="http://www.data-knowledge.org/dk/KpiMeasurement"></see></summary>
    let KpiMeasurement = _prefix "KpiMeasurement"
    /// <summary>
    /// Defines the integrity of a single Business Object or across them
    /// <see href="http://www.data-knowledge.org/dk/BusinessRule"></see></summary>
    let BusinessRule = _prefix "BusinessRule"
    /// <summary>
    /// A Data Asset represents a collection of Data Objects serving an organizational or a business goal. The contained Data Objects may be of the same or of different Data Object Types.
    /// <see href="http://www.data-knowledge.org/dk/DataAsset"></see></summary>
    let DataAsset = _prefix "DataAsset"
    /// <summary>
    /// Abstract definition of a general function and its goals and authorities
    /// <see href="http://www.data-knowledge.org/dk/Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://www.data-knowledge.org/dk/schema/rdf/latest/"></see>
    /// </summary>
    let ``schema/rdf/latest/`` = _prefix "schema/rdf/latest/"
    /// <summary>
    ///   <see href="http://www.data-knowledge.org/dk/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = _prefix "1.0/"
    /// <summary>
    /// An installed instance of an application that stores or processes data
    /// <see href="http://www.data-knowledge.org/dk/Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// Technical specification of an application to exchange data
    /// <see href="http://www.data-knowledge.org/dk/ApplicationInterface"></see></summary>
    let ApplicationInterface = _prefix "ApplicationInterface"
    /// <summary>
    /// Technical representation of a Business Object Type (BOT)
    /// <see href="http://www.data-knowledge.org/dk/DataObjectType"></see></summary>
    let DataObjectType = _prefix "DataObjectType"
    /// <summary>
    /// Defines the life cycle of Applications. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).
    /// <see href="http://www.data-knowledge.org/dk/ApplicationLifecycle"></see></summary>
    let ApplicationLifecycle = _prefix "ApplicationLifecycle"
    /// <summary>
    /// Conceptual mapping of business definitions to technical representations for attributes.
    /// <see href="http://www.data-knowledge.org/dk/AttributeMapping"></see></summary>
    let AttributeMapping = _prefix "AttributeMapping"
    /// <summary>
    /// Abstract class of different kinds of mappings
    /// <see href="http://www.data-knowledge.org/dk/Mapping"></see></summary>
    let Mapping = _prefix "Mapping"
    /// <summary>
    /// Specific, individual instance of a Business Object Type (BOT)
    /// <see href="http://www.data-knowledge.org/dk/BusinessObject"></see></summary>
    let BusinessObject = _prefix "BusinessObject"
    /// <summary>
    /// Specific, individual instance of a Business Object Type Attribute (BOTA)
    /// <see href="http://www.data-knowledge.org/dk/BusinessObjectAttribute"></see></summary>
    let BusinessObjectAttribute = _prefix "BusinessObjectAttribute"
    /// <summary>
    /// Clusters of coherent Business Object Types (BOTs), either from a subject matter or management point of view
    /// <see href="http://www.data-knowledge.org/dk/BusinessObjectDomain"></see></summary>
    let BusinessObjectDomain = _prefix "BusinessObjectDomain"
    /// <summary>
    /// Conceptual (data) entity relevant to business that represents a coherent set of information about a group of real or virtual objects
    /// <see href="http://www.data-knowledge.org/dk/BusinessObjectType"></see></summary>
    let BusinessObjectType = _prefix "BusinessObjectType"
    /// <summary>
    /// A Data Conceptualization represents a business concept to specify and structure data. As this is an abstract superclass only its subclasses may be used.
    /// <see href="http://www.data-knowledge.org/dk/DataConceptualization"></see></summary>
    let DataConceptualization = _prefix "DataConceptualization"
    /// <summary>
    /// Conceptually elementary piece of information as part of a Business Object Type (BOT)
    /// <see href="http://www.data-knowledge.org/dk/BusinessObjectTypeAttribute"></see></summary>
    let BusinessObjectTypeAttribute = _prefix "BusinessObjectTypeAttribute"
    /// <summary>
    /// Sequence of activities consuming or relying on data (data usage perspective)
    /// <see href="http://www.data-knowledge.org/dk/BusinessProcess"></see></summary>
    let BusinessProcess = _prefix "BusinessProcess"
    /// <summary>
    /// Represents the evaluation of a certain Business Rule on a specific Data Asset
    /// <see href="http://www.data-knowledge.org/dk/BusinessRuleAssessment"></see></summary>
    let BusinessRuleAssessment = _prefix "BusinessRuleAssessment"
    /// <summary>
    /// Information that allows to track the development of data definitions, processes, etc.
    /// <see href="http://www.data-knowledge.org/dk/ChangeHistory"></see></summary>
    let ChangeHistory = _prefix "ChangeHistory"
    /// <summary>
    /// Detailed description of a specific change requirement, resulting from projects or operations
    /// <see href="http://www.data-knowledge.org/dk/ChangeRequest"></see></summary>
    let ChangeRequest = _prefix "ChangeRequest"
    /// <summary>
    /// Pre-defined value for a Business Object Type Attribute (BOTA)
    /// <see href="http://www.data-knowledge.org/dk/Code"></see></summary>
    let Code = _prefix "Code"
    /// <summary>
    /// List with pre-defined values (Codes) for a Business Object Type Attribute (BOTA)
    /// <see href="http://www.data-knowledge.org/dk/CodeList"></see></summary>
    let CodeList = _prefix "CodeList"
    /// <summary>
    /// Conceptual mapping of business-related codes and terminology of Code Lists to named values of technical Enumerations.
    /// <see href="http://www.data-knowledge.org/dk/CodeMapping"></see></summary>
    let CodeMapping = _prefix "CodeMapping"
    /// <summary>
    /// Individual record of a Data Object Type (DOT), i.e. the technical representation of a Business Object (BO)
    /// <see href="http://www.data-knowledge.org/dk/DataObject"></see></summary>
    let DataObject = _prefix "DataObject"
    /// <summary>
    /// Indicates the actual connection and data exchange between particular applications
    /// <see href="http://www.data-knowledge.org/dk/DataFlow"></see></summary>
    let DataFlow = _prefix "DataFlow"
    /// <summary>
    /// Defines the life cycle of Business Objects, Data Objects and Data Assets. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).
    /// <see href="http://www.data-knowledge.org/dk/DataLifecycle"></see></summary>
    let DataLifecycle = _prefix "DataLifecycle"
    /// <summary>
    /// Sequence of activities for data maintenance or data governance
    /// <see href="http://www.data-knowledge.org/dk/DataManagementProcess"></see></summary>
    let DataManagementProcess = _prefix "DataManagementProcess"
    /// <summary>
    /// A piece of information being a part of a Data Object (DO), i.e. the technical representation of a Business Object Attribute (BOA)
    /// <see href="http://www.data-knowledge.org/dk/DataObjectAttribute"></see></summary>
    let DataObjectAttribute = _prefix "DataObjectAttribute"
    /// <summary>
    /// Individual (atomic) field to store a piece of information
    /// <see href="http://www.data-knowledge.org/dk/DataObjectTypeAttribute"></see></summary>
    let DataObjectTypeAttribute = _prefix "DataObjectTypeAttribute"
    /// <summary>
    /// List with pre-defined values (Named Values) for a Data Object Type Attribute (DOTA)
    /// <see href="http://www.data-knowledge.org/dk/Enumeration"></see></summary>
    let Enumeration = _prefix "Enumeration"
    /// <summary>
    /// Pre-defined value of an Enumeration for a Data Object Type Attribute (DOTA)
    /// <see href="http://www.data-knowledge.org/dk/NamedValue"></see></summary>
    let NamedValue = _prefix "NamedValue"
    /// <summary>
    /// Illustrative instances of a BOT/BOTA to indicate valid / invalid use
    /// <see href="http://www.data-knowledge.org/dk/Example"></see></summary>
    let Example = _prefix "Example"
    /// <summary>
    /// Frequently Asked Questions
    /// <see href="http://www.data-knowledge.org/dk/FAQ"></see></summary>
    let FAQ = _prefix "FAQ"
    /// <summary>
    /// May be used to map data objects from different applications that represent the same business entity. This is useful for creation of 'golden records' and the distribution of data.
    /// <see href="http://www.data-knowledge.org/dk/KeyMapping"></see></summary>
    let KeyMapping = _prefix "KeyMapping"
    /// <summary>
    /// Defines the life cycle of a data knowledge entity, i.e. the instances from the classes of this model. This type of life cycles thus represents a metadata life cycle. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).
    /// <see href="http://www.data-knowledge.org/dk/KnowledgeLifecycle"></see></summary>
    let KnowledgeLifecycle = _prefix "KnowledgeLifecycle"
    /// <summary>
    /// Defines a data quality (performance) measure based on a set of business rules
    /// <see href="http://www.data-knowledge.org/dk/KpiDefinition"></see></summary>
    let KpiDefinition = _prefix "KpiDefinition"
    /// <summary>
    /// Conceptual mapping of business definitions to technical representations for objects.
    /// <see href="http://www.data-knowledge.org/dk/TypeMapping"></see></summary>
    let TypeMapping = _prefix "TypeMapping"
    /// <summary>
    /// Technical mapping specifiying data flows between Applications.
    /// <see href="http://www.data-knowledge.org/dk/SchemaMapping"></see></summary>
    let SchemaMapping = _prefix "SchemaMapping"
    /// <summary>
    /// Unit of the organizational structure (hierarchy), group of individuals
    /// <see href="http://www.data-knowledge.org/dk/OrganizationalUnit"></see></summary>
    let OrganizationalUnit = _prefix "OrganizationalUnit"
    /// <summary>
    /// Individual of an organization assigned with certain roles
    /// <see href="http://www.data-knowledge.org/dk/Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// A project that implies changes to data or data management
    /// <see href="http://www.data-knowledge.org/dk/Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Schedule illustrating when a particular action is taken on something
    /// <see href="http://www.data-knowledge.org/dk/ProjectPlan"></see></summary>
    let ProjectPlan = _prefix "ProjectPlan"
    /// <summary>
    /// Internal or external regulatory driver influencing data management
    /// <see href="http://www.data-knowledge.org/dk/Regulation"></see></summary>
    let Regulation = _prefix "Regulation"
    /// <summary>
    /// Set of KPI measurements gathered for a particular purpose
    /// <see href="http://www.data-knowledge.org/dk/Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// Specific description of a responsibility, including the particular scope, duration of accountability, measures to be taken and further information
    /// <see href="http://www.data-knowledge.org/dk/Responsibility"></see></summary>
    let Responsibility = _prefix "Responsibility"
    /// <summary>
    /// Material to learn or use as a reference for data management operations
    /// <see href="http://www.data-knowledge.org/dk/SupplementaryDocumentation"></see></summary>
    let SupplementaryDocumentation = _prefix "SupplementaryDocumentation"
    /// <summary>
    /// Terms of use specify the terms and conditions under which an Application or a Data Asset can or must be used.
    /// <see href="http://www.data-knowledge.org/dk/TermsOfUse"></see></summary>
    let TermsOfUse = _prefix "TermsOfUse"
    /// <summary>
    /// A planned event a person can participate in
    /// <see href="http://www.data-knowledge.org/dk/TrainingOpportunity"></see></summary>
    let TrainingOpportunity = _prefix "TrainingOpportunity"
    /// <summary>
    /// A Change Requests affects a Business Object Type or an Application
    /// <see href="http://www.data-knowledge.org/dk/affects"></see></summary>
    let affects = _prefix "affects"
    /// <summary>
    /// FAQ answer questions about various model areas
    /// <see href="http://www.data-knowledge.org/dk/answersQuestionAbout"></see></summary>
    let answersQuestionAbout = _prefix "answersQuestionAbout"
    /// <summary>
    /// Regulations can apply to all kinds of instances
    /// <see href="http://www.data-knowledge.org/dk/appliesTo"></see></summary>
    let appliesTo = _prefix "appliesTo"
    /// <summary>
    /// unspecified association between entities
    /// <see href="http://www.data-knowledge.org/dk/associatesWith"></see></summary>
    let associatesWith = _prefix "associatesWith"
    /// <summary>
    /// A KPI Definition is based on a Business Rule (BR)
    /// <see href="http://www.data-knowledge.org/dk/basedOn"></see></summary>
    let basedOn = _prefix "basedOn"
    /// <summary>
    /// Roles and Organizational Units can carry specific responsibilites
    /// <see href="http://www.data-knowledge.org/dk/carries"></see></summary>
    let carries = _prefix "carries"
    /// <summary>
    /// A Report comprises certain KPI Measurements and their definitions
    /// <see href="http://www.data-knowledge.org/dk/comprises"></see></summary>
    let comprises = _prefix "comprises"
    /// <summary>
    /// A KPI Measurement and Business Rule Assessments is computed on a Data Asset
    /// <see href="http://www.data-knowledge.org/dk/computedOn"></see></summary>
    let computedOn = _prefix "computedOn"
    /// <summary>
    /// Organizational Units and Roles can cooperate
    /// <see href="http://www.data-knowledge.org/dk/cooperatesWith"></see></summary>
    let cooperatesWith = _prefix "cooperatesWith"
    /// <summary>
    /// A Business Rule (BR) defines the integrity of Business Objects (BOs), Business Object Types (BOTs) and Business Object Attributes (BOAs)
    /// <see href="http://www.data-knowledge.org/dk/definesIntegrityOf"></see></summary>
    let definesIntegrityOf = _prefix "definesIntegrityOf"
    /// <summary>
    /// Specifies the life cycle of the Business Object instances on the conceptual type level. The current life cycle state of an individual Business Object is referred to from each Business Object via the property lifecycle:state.
    /// <see href="http://www.data-knowledge.org/dk/definesLifecycleOfInstances"></see></summary>
    let definesLifecycleOfInstances = _prefix "definesLifecycleOfInstances"
    /// <summary>
    /// Supplementary documentation documents various model areas
    /// <see href="http://www.data-knowledge.org/dk/documents"></see></summary>
    let documents = _prefix "documents"
    /// <summary>
    /// Interface A sends data
    /// <see href="http://www.data-knowledge.org/dk/flowsFrom"></see></summary>
    let flowsFrom = _prefix "flowsFrom"
    /// <summary>
    /// Data is sent to Interface B
    /// <see href="http://www.data-knowledge.org/dk/flowsTo"></see></summary>
    let flowsTo = _prefix "flowsTo"
    /// <summary>
    /// Specifies the life cycle of an individual Application instance. The current life cycle state of the instance is referred to via the property lifecycle:state.
    /// <see href="http://www.data-knowledge.org/dk/hasApplicationLifecycle"></see></summary>
    let hasApplicationLifecycle = _prefix "hasApplicationLifecycle"
    /// <summary>
    /// Specifies the life cycle of an individual instance of a Business Object, Data Object or Data Asset. This property can be used to override the general type level life cycle definition expressed by definesLifecycleOfInstances. The current life cycle state of the instance is referred to via the property lifecycle:state
    /// <see href="http://www.data-knowledge.org/dk/hasDataLifecycle"></see></summary>
    let hasDataLifecycle = _prefix "hasDataLifecycle"
    /// <summary>
    /// May be used to define a general life cycle that applies to all classes of the model or certain classes.
    /// <see href="http://www.data-knowledge.org/dk/hasKnowledgeLifecycle"></see></summary>
    let hasKnowledgeLifecycle = _prefix "hasKnowledgeLifecycle"
    /// <summary>
    /// Resources can have specific Terms of Use
    /// <see href="http://www.data-knowledge.org/dk/hasTerms"></see></summary>
    let hasTerms = _prefix "hasTerms"
    /// <summary>
    /// An example illustrates a BOT/A
    /// <see href="http://www.data-knowledge.org/dk/illustrates"></see></summary>
    let illustrates = _prefix "illustrates"
    /// <summary>
    /// A project or a Data Management Process initiates a change request
    /// <see href="http://www.data-knowledge.org/dk/initiates"></see></summary>
    let initiates = _prefix "initiates"
    /// <summary>
    /// A KPI Measurement is computed according to a KPI Definition on a given data asset at a given time. Similarly, a Business Rule Assessment results from a Business Rule
    /// <see href="http://www.data-knowledge.org/dk/isMeasurementOf"></see></summary>
    let isMeasurementOf = _prefix "isMeasurementOf"
    /// <summary>
    /// Specific Data Management Processes maintain specific BO/T/As or BODs
    /// <see href="http://www.data-knowledge.org/dk/maintains"></see></summary>
    let maintains = _prefix "maintains"
    /// <summary>
    /// A specific Mapping Class assigns various representations of the same concepts, i.e in a conceptual vs. technical view (possibly in different data formats, e.g. Java or XML objects).
    ///  Code Mappings map from Code to NamedValue ;
    ///  Type Mappings map from BusinessObjectType to DataObjectType ;
    ///  Attribute Mappings map from BusinessObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Schema Mappings map from DataObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Key Mappings map from Business to DataObject
    /// <see href="http://www.data-knowledge.org/dk/mapsFrom"></see></summary>
    let mapsFrom = _prefix "mapsFrom"
    /// <summary>
    /// A specific Mapping Class assigns various representations of the same concepts, i.e in a conceptual vs. technical view (possibly in different data formats, e.g. Java or XML objects).
    ///  Code Mappings map from Code to NamedValue ;
    ///  Type Mappings map from BusinessObjectType to DataObjectType ;
    ///  Attribute Mappings map from BusinessObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Schema Mappings map from DataObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Key Mappings map from Business to DataObject
    /// <see href="http://www.data-knowledge.org/dk/mapsTo"></see></summary>
    let mapsTo = _prefix "mapsTo"
    /// <summary>
    /// A person or organizational unit can participate in trainings
    /// <see href="http://www.data-knowledge.org/dk/participatesIn"></see></summary>
    let participatesIn = _prefix "participatesIn"
    /// <summary>
    /// Change requests are processed by DM processes
    /// <see href="http://www.data-knowledge.org/dk/processes"></see></summary>
    let processes = _prefix "processes"
    /// <summary>
    /// A reference from a BOTA to a Code List or from a DOTA to an Enumeration
    /// <see href="http://www.data-knowledge.org/dk/refersTo"></see></summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    /// Connection from specific instances (BOs, DOs, BOAs, DOAs) to conceptually coherent sets of entities (BOTs, DOTs, BOTAs, DOTAs)
    /// <see href="http://www.data-knowledge.org/dk/represents"></see></summary>
    let represents = _prefix "represents"
    /// <summary>
    /// Specific assignment of a responsibility for a particular scope
    /// <see href="http://www.data-knowledge.org/dk/responsibleFor"></see></summary>
    let responsibleFor = _prefix "responsibleFor"
    /// <summary>
    /// Persons can take Roles
    /// <see href="http://www.data-knowledge.org/dk/takes"></see></summary>
    let takes = _prefix "takes"
    /// <summary>
    /// The change history keeps track of changes to instances
    /// <see href="http://www.data-knowledge.org/dk/tracks"></see></summary>
    let tracks = _prefix "tracks"
    /// <summary>
    /// This property specifies what data is actually transferred by the data flow. This requires the data from the source application, represented by a Data Object Type, to be mapped to the data expected by the target application, also represented by a Data Object Type. Consequently, this property links a Data Flow with a Schema Mapping that outlines the source and target Data Object Types and how they map.
    /// <see href="http://www.data-knowledge.org/dk/transfersData"></see></summary>
    let transfersData = _prefix "transfersData"
    /// <summary>
    /// Business Processes consume or use BO/T/As or BODs
    /// <see href="http://www.data-knowledge.org/dk/uses"></see></summary>
    let uses = _prefix "uses"
    /// <summary>
    /// Projects work on Business Object Types or Applications, e.g. by creating or changing them
    /// <see href="http://www.data-knowledge.org/dk/worksOn"></see></summary>
    let worksOn = _prefix "worksOn"
