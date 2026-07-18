namespace http.www.data_knowledge.org.dk.slash

open DoxAletheia.Rdf_Vocabulary

module dk =
    let _namespace_name = "http://www.data-knowledge.org/dk/"

    /// <summary>
    /// Actual performance values measured at a particular time
    /// <see href="http://www.data-knowledge.org/dk/KpiMeasurement"></see></summary>
    let KpiMeasurement =
        Namespaced_IRI.parse _namespace_name "KpiMeasurement" |> NamespacedName

    /// <summary>
    /// Defines the integrity of a single Business Object or across them
    /// <see href="http://www.data-knowledge.org/dk/BusinessRule"></see></summary>
    let BusinessRule =
        Namespaced_IRI.parse _namespace_name "BusinessRule" |> NamespacedName

    /// <summary>
    /// A Data Asset represents a collection of Data Objects serving an organizational or a business goal. The contained Data Objects may be of the same or of different Data Object Types.
    /// <see href="http://www.data-knowledge.org/dk/DataAsset"></see></summary>
    let DataAsset = Namespaced_IRI.parse _namespace_name "DataAsset" |> NamespacedName
    /// <summary>
    /// Abstract definition of a general function and its goals and authorities
    /// <see href="http://www.data-knowledge.org/dk/Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.data-knowledge.org/dk/schema/rdf/latest/"></see>
    /// </summary>
    let ``schema/rdf/latest/`` =
        Namespaced_IRI.parse _namespace_name "schema/rdf/latest/" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.data-knowledge.org/dk/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = Namespaced_IRI.parse _namespace_name "1.0/" |> NamespacedName

    /// <summary>
    /// An installed instance of an application that stores or processes data
    /// <see href="http://www.data-knowledge.org/dk/Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// Technical specification of an application to exchange data
    /// <see href="http://www.data-knowledge.org/dk/ApplicationInterface"></see></summary>
    let ApplicationInterface =
        Namespaced_IRI.parse _namespace_name "ApplicationInterface" |> NamespacedName

    /// <summary>
    /// Technical representation of a Business Object Type (BOT)
    /// <see href="http://www.data-knowledge.org/dk/DataObjectType"></see></summary>
    let DataObjectType =
        Namespaced_IRI.parse _namespace_name "DataObjectType" |> NamespacedName

    /// <summary>
    /// Defines the life cycle of Applications. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).
    /// <see href="http://www.data-knowledge.org/dk/ApplicationLifecycle"></see></summary>
    let ApplicationLifecycle =
        Namespaced_IRI.parse _namespace_name "ApplicationLifecycle" |> NamespacedName

    /// <summary>
    /// Conceptual mapping of business definitions to technical representations for attributes.
    /// <see href="http://www.data-knowledge.org/dk/AttributeMapping"></see></summary>
    let AttributeMapping =
        Namespaced_IRI.parse _namespace_name "AttributeMapping" |> NamespacedName

    /// <summary>
    /// Abstract class of different kinds of mappings
    /// <see href="http://www.data-knowledge.org/dk/Mapping"></see></summary>
    let Mapping = Namespaced_IRI.parse _namespace_name "Mapping" |> NamespacedName

    /// <summary>
    /// Specific, individual instance of a Business Object Type (BOT)
    /// <see href="http://www.data-knowledge.org/dk/BusinessObject"></see></summary>
    let BusinessObject =
        Namespaced_IRI.parse _namespace_name "BusinessObject" |> NamespacedName

    /// <summary>
    /// Specific, individual instance of a Business Object Type Attribute (BOTA)
    /// <see href="http://www.data-knowledge.org/dk/BusinessObjectAttribute"></see></summary>
    let BusinessObjectAttribute =
        Namespaced_IRI.parse _namespace_name "BusinessObjectAttribute" |> NamespacedName

    /// <summary>
    /// Clusters of coherent Business Object Types (BOTs), either from a subject matter or management point of view
    /// <see href="http://www.data-knowledge.org/dk/BusinessObjectDomain"></see></summary>
    let BusinessObjectDomain =
        Namespaced_IRI.parse _namespace_name "BusinessObjectDomain" |> NamespacedName

    /// <summary>
    /// Conceptual (data) entity relevant to business that represents a coherent set of information about a group of real or virtual objects
    /// <see href="http://www.data-knowledge.org/dk/BusinessObjectType"></see></summary>
    let BusinessObjectType =
        Namespaced_IRI.parse _namespace_name "BusinessObjectType" |> NamespacedName

    /// <summary>
    /// A Data Conceptualization represents a business concept to specify and structure data. As this is an abstract superclass only its subclasses may be used.
    /// <see href="http://www.data-knowledge.org/dk/DataConceptualization"></see></summary>
    let DataConceptualization =
        Namespaced_IRI.parse _namespace_name "DataConceptualization" |> NamespacedName

    /// <summary>
    /// Conceptually elementary piece of information as part of a Business Object Type (BOT)
    /// <see href="http://www.data-knowledge.org/dk/BusinessObjectTypeAttribute"></see></summary>
    let BusinessObjectTypeAttribute =
        Namespaced_IRI.parse _namespace_name "BusinessObjectTypeAttribute" |> NamespacedName

    /// <summary>
    /// Sequence of activities consuming or relying on data (data usage perspective)
    /// <see href="http://www.data-knowledge.org/dk/BusinessProcess"></see></summary>
    let BusinessProcess =
        Namespaced_IRI.parse _namespace_name "BusinessProcess" |> NamespacedName

    /// <summary>
    /// Represents the evaluation of a certain Business Rule on a specific Data Asset
    /// <see href="http://www.data-knowledge.org/dk/BusinessRuleAssessment"></see></summary>
    let BusinessRuleAssessment =
        Namespaced_IRI.parse _namespace_name "BusinessRuleAssessment" |> NamespacedName

    /// <summary>
    /// Information that allows to track the development of data definitions, processes, etc.
    /// <see href="http://www.data-knowledge.org/dk/ChangeHistory"></see></summary>
    let ChangeHistory =
        Namespaced_IRI.parse _namespace_name "ChangeHistory" |> NamespacedName

    /// <summary>
    /// Detailed description of a specific change requirement, resulting from projects or operations
    /// <see href="http://www.data-knowledge.org/dk/ChangeRequest"></see></summary>
    let ChangeRequest =
        Namespaced_IRI.parse _namespace_name "ChangeRequest" |> NamespacedName

    /// <summary>
    /// Pre-defined value for a Business Object Type Attribute (BOTA)
    /// <see href="http://www.data-knowledge.org/dk/Code"></see></summary>
    let Code = Namespaced_IRI.parse _namespace_name "Code" |> NamespacedName
    /// <summary>
    /// List with pre-defined values (Codes) for a Business Object Type Attribute (BOTA)
    /// <see href="http://www.data-knowledge.org/dk/CodeList"></see></summary>
    let CodeList = Namespaced_IRI.parse _namespace_name "CodeList" |> NamespacedName

    /// <summary>
    /// Conceptual mapping of business-related codes and terminology of Code Lists to named values of technical Enumerations.
    /// <see href="http://www.data-knowledge.org/dk/CodeMapping"></see></summary>
    let CodeMapping =
        Namespaced_IRI.parse _namespace_name "CodeMapping" |> NamespacedName

    /// <summary>
    /// Individual record of a Data Object Type (DOT), i.e. the technical representation of a Business Object (BO)
    /// <see href="http://www.data-knowledge.org/dk/DataObject"></see></summary>
    let DataObject = Namespaced_IRI.parse _namespace_name "DataObject" |> NamespacedName
    /// <summary>
    /// Indicates the actual connection and data exchange between particular applications
    /// <see href="http://www.data-knowledge.org/dk/DataFlow"></see></summary>
    let DataFlow = Namespaced_IRI.parse _namespace_name "DataFlow" |> NamespacedName

    /// <summary>
    /// Defines the life cycle of Business Objects, Data Objects and Data Assets. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).
    /// <see href="http://www.data-knowledge.org/dk/DataLifecycle"></see></summary>
    let DataLifecycle =
        Namespaced_IRI.parse _namespace_name "DataLifecycle" |> NamespacedName

    /// <summary>
    /// Sequence of activities for data maintenance or data governance
    /// <see href="http://www.data-knowledge.org/dk/DataManagementProcess"></see></summary>
    let DataManagementProcess =
        Namespaced_IRI.parse _namespace_name "DataManagementProcess" |> NamespacedName

    /// <summary>
    /// A piece of information being a part of a Data Object (DO), i.e. the technical representation of a Business Object Attribute (BOA)
    /// <see href="http://www.data-knowledge.org/dk/DataObjectAttribute"></see></summary>
    let DataObjectAttribute =
        Namespaced_IRI.parse _namespace_name "DataObjectAttribute" |> NamespacedName

    /// <summary>
    /// Individual (atomic) field to store a piece of information
    /// <see href="http://www.data-knowledge.org/dk/DataObjectTypeAttribute"></see></summary>
    let DataObjectTypeAttribute =
        Namespaced_IRI.parse _namespace_name "DataObjectTypeAttribute" |> NamespacedName

    /// <summary>
    /// List with pre-defined values (Named Values) for a Data Object Type Attribute (DOTA)
    /// <see href="http://www.data-knowledge.org/dk/Enumeration"></see></summary>
    let Enumeration =
        Namespaced_IRI.parse _namespace_name "Enumeration" |> NamespacedName

    /// <summary>
    /// Pre-defined value of an Enumeration for a Data Object Type Attribute (DOTA)
    /// <see href="http://www.data-knowledge.org/dk/NamedValue"></see></summary>
    let NamedValue = Namespaced_IRI.parse _namespace_name "NamedValue" |> NamespacedName
    /// <summary>
    /// Illustrative instances of a BOT/BOTA to indicate valid / invalid use
    /// <see href="http://www.data-knowledge.org/dk/Example"></see></summary>
    let Example = Namespaced_IRI.parse _namespace_name "Example" |> NamespacedName
    /// <summary>
    /// Frequently Asked Questions
    /// <see href="http://www.data-knowledge.org/dk/FAQ"></see></summary>
    let FAQ = Namespaced_IRI.parse _namespace_name "FAQ" |> NamespacedName
    /// <summary>
    /// May be used to map data objects from different applications that represent the same business entity. This is useful for creation of 'golden records' and the distribution of data.
    /// <see href="http://www.data-knowledge.org/dk/KeyMapping"></see></summary>
    let KeyMapping = Namespaced_IRI.parse _namespace_name "KeyMapping" |> NamespacedName

    /// <summary>
    /// Defines the life cycle of a data knowledge entity, i.e. the instances from the classes of this model. This type of life cycles thus represents a metadata life cycle. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).
    /// <see href="http://www.data-knowledge.org/dk/KnowledgeLifecycle"></see></summary>
    let KnowledgeLifecycle =
        Namespaced_IRI.parse _namespace_name "KnowledgeLifecycle" |> NamespacedName

    /// <summary>
    /// Defines a data quality (performance) measure based on a set of business rules
    /// <see href="http://www.data-knowledge.org/dk/KpiDefinition"></see></summary>
    let KpiDefinition =
        Namespaced_IRI.parse _namespace_name "KpiDefinition" |> NamespacedName

    /// <summary>
    /// Conceptual mapping of business definitions to technical representations for objects.
    /// <see href="http://www.data-knowledge.org/dk/TypeMapping"></see></summary>
    let TypeMapping =
        Namespaced_IRI.parse _namespace_name "TypeMapping" |> NamespacedName

    /// <summary>
    /// Technical mapping specifiying data flows between Applications.
    /// <see href="http://www.data-knowledge.org/dk/SchemaMapping"></see></summary>
    let SchemaMapping =
        Namespaced_IRI.parse _namespace_name "SchemaMapping" |> NamespacedName

    /// <summary>
    /// Unit of the organizational structure (hierarchy), group of individuals
    /// <see href="http://www.data-knowledge.org/dk/OrganizationalUnit"></see></summary>
    let OrganizationalUnit =
        Namespaced_IRI.parse _namespace_name "OrganizationalUnit" |> NamespacedName

    /// <summary>
    /// Individual of an organization assigned with certain roles
    /// <see href="http://www.data-knowledge.org/dk/Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// A project that implies changes to data or data management
    /// <see href="http://www.data-knowledge.org/dk/Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    /// Schedule illustrating when a particular action is taken on something
    /// <see href="http://www.data-knowledge.org/dk/ProjectPlan"></see></summary>
    let ProjectPlan =
        Namespaced_IRI.parse _namespace_name "ProjectPlan" |> NamespacedName

    /// <summary>
    /// Internal or external regulatory driver influencing data management
    /// <see href="http://www.data-knowledge.org/dk/Regulation"></see></summary>
    let Regulation = Namespaced_IRI.parse _namespace_name "Regulation" |> NamespacedName
    /// <summary>
    /// Set of KPI measurements gathered for a particular purpose
    /// <see href="http://www.data-knowledge.org/dk/Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName

    /// <summary>
    /// Specific description of a responsibility, including the particular scope, duration of accountability, measures to be taken and further information
    /// <see href="http://www.data-knowledge.org/dk/Responsibility"></see></summary>
    let Responsibility =
        Namespaced_IRI.parse _namespace_name "Responsibility" |> NamespacedName

    /// <summary>
    /// Material to learn or use as a reference for data management operations
    /// <see href="http://www.data-knowledge.org/dk/SupplementaryDocumentation"></see></summary>
    let SupplementaryDocumentation =
        Namespaced_IRI.parse _namespace_name "SupplementaryDocumentation" |> NamespacedName

    /// <summary>
    /// Terms of use specify the terms and conditions under which an Application or a Data Asset can or must be used.
    /// <see href="http://www.data-knowledge.org/dk/TermsOfUse"></see></summary>
    let TermsOfUse = Namespaced_IRI.parse _namespace_name "TermsOfUse" |> NamespacedName

    /// <summary>
    /// A planned event a person can participate in
    /// <see href="http://www.data-knowledge.org/dk/TrainingOpportunity"></see></summary>
    let TrainingOpportunity =
        Namespaced_IRI.parse _namespace_name "TrainingOpportunity" |> NamespacedName

    /// <summary>
    /// A Change Requests affects a Business Object Type or an Application
    /// <see href="http://www.data-knowledge.org/dk/affects"></see></summary>
    let affects = Namespaced_IRI.parse _namespace_name "affects" |> NamespacedName

    /// <summary>
    /// FAQ answer questions about various model areas
    /// <see href="http://www.data-knowledge.org/dk/answersQuestionAbout"></see></summary>
    let answersQuestionAbout =
        Namespaced_IRI.parse _namespace_name "answersQuestionAbout" |> NamespacedName

    /// <summary>
    /// Regulations can apply to all kinds of instances
    /// <see href="http://www.data-knowledge.org/dk/appliesTo"></see></summary>
    let appliesTo = Namespaced_IRI.parse _namespace_name "appliesTo" |> NamespacedName

    /// <summary>
    /// unspecified association between entities
    /// <see href="http://www.data-knowledge.org/dk/associatesWith"></see></summary>
    let associatesWith =
        Namespaced_IRI.parse _namespace_name "associatesWith" |> NamespacedName

    /// <summary>
    /// A KPI Definition is based on a Business Rule (BR)
    /// <see href="http://www.data-knowledge.org/dk/basedOn"></see></summary>
    let basedOn = Namespaced_IRI.parse _namespace_name "basedOn" |> NamespacedName
    /// <summary>
    /// Roles and Organizational Units can carry specific responsibilites
    /// <see href="http://www.data-knowledge.org/dk/carries"></see></summary>
    let carries = Namespaced_IRI.parse _namespace_name "carries" |> NamespacedName
    /// <summary>
    /// A Report comprises certain KPI Measurements and their definitions
    /// <see href="http://www.data-knowledge.org/dk/comprises"></see></summary>
    let comprises = Namespaced_IRI.parse _namespace_name "comprises" |> NamespacedName
    /// <summary>
    /// A KPI Measurement and Business Rule Assessments is computed on a Data Asset
    /// <see href="http://www.data-knowledge.org/dk/computedOn"></see></summary>
    let computedOn = Namespaced_IRI.parse _namespace_name "computedOn" |> NamespacedName

    /// <summary>
    /// Organizational Units and Roles can cooperate
    /// <see href="http://www.data-knowledge.org/dk/cooperatesWith"></see></summary>
    let cooperatesWith =
        Namespaced_IRI.parse _namespace_name "cooperatesWith" |> NamespacedName

    /// <summary>
    /// A Business Rule (BR) defines the integrity of Business Objects (BOs), Business Object Types (BOTs) and Business Object Attributes (BOAs)
    /// <see href="http://www.data-knowledge.org/dk/definesIntegrityOf"></see></summary>
    let definesIntegrityOf =
        Namespaced_IRI.parse _namespace_name "definesIntegrityOf" |> NamespacedName

    /// <summary>
    /// Specifies the life cycle of the Business Object instances on the conceptual type level. The current life cycle state of an individual Business Object is referred to from each Business Object via the property lifecycle:state.
    /// <see href="http://www.data-knowledge.org/dk/definesLifecycleOfInstances"></see></summary>
    let definesLifecycleOfInstances =
        Namespaced_IRI.parse _namespace_name "definesLifecycleOfInstances" |> NamespacedName

    /// <summary>
    /// Supplementary documentation documents various model areas
    /// <see href="http://www.data-knowledge.org/dk/documents"></see></summary>
    let documents = Namespaced_IRI.parse _namespace_name "documents" |> NamespacedName
    /// <summary>
    /// Interface A sends data
    /// <see href="http://www.data-knowledge.org/dk/flowsFrom"></see></summary>
    let flowsFrom = Namespaced_IRI.parse _namespace_name "flowsFrom" |> NamespacedName
    /// <summary>
    /// Data is sent to Interface B
    /// <see href="http://www.data-knowledge.org/dk/flowsTo"></see></summary>
    let flowsTo = Namespaced_IRI.parse _namespace_name "flowsTo" |> NamespacedName

    /// <summary>
    /// Specifies the life cycle of an individual Application instance. The current life cycle state of the instance is referred to via the property lifecycle:state.
    /// <see href="http://www.data-knowledge.org/dk/hasApplicationLifecycle"></see></summary>
    let hasApplicationLifecycle =
        Namespaced_IRI.parse _namespace_name "hasApplicationLifecycle" |> NamespacedName

    /// <summary>
    /// Specifies the life cycle of an individual instance of a Business Object, Data Object or Data Asset. This property can be used to override the general type level life cycle definition expressed by definesLifecycleOfInstances. The current life cycle state of the instance is referred to via the property lifecycle:state
    /// <see href="http://www.data-knowledge.org/dk/hasDataLifecycle"></see></summary>
    let hasDataLifecycle =
        Namespaced_IRI.parse _namespace_name "hasDataLifecycle" |> NamespacedName

    /// <summary>
    /// May be used to define a general life cycle that applies to all classes of the model or certain classes.
    /// <see href="http://www.data-knowledge.org/dk/hasKnowledgeLifecycle"></see></summary>
    let hasKnowledgeLifecycle =
        Namespaced_IRI.parse _namespace_name "hasKnowledgeLifecycle" |> NamespacedName

    /// <summary>
    /// Resources can have specific Terms of Use
    /// <see href="http://www.data-knowledge.org/dk/hasTerms"></see></summary>
    let hasTerms = Namespaced_IRI.parse _namespace_name "hasTerms" |> NamespacedName

    /// <summary>
    /// An example illustrates a BOT/A
    /// <see href="http://www.data-knowledge.org/dk/illustrates"></see></summary>
    let illustrates =
        Namespaced_IRI.parse _namespace_name "illustrates" |> NamespacedName

    /// <summary>
    /// A project or a Data Management Process initiates a change request
    /// <see href="http://www.data-knowledge.org/dk/initiates"></see></summary>
    let initiates = Namespaced_IRI.parse _namespace_name "initiates" |> NamespacedName

    /// <summary>
    /// A KPI Measurement is computed according to a KPI Definition on a given data asset at a given time. Similarly, a Business Rule Assessment results from a Business Rule
    /// <see href="http://www.data-knowledge.org/dk/isMeasurementOf"></see></summary>
    let isMeasurementOf =
        Namespaced_IRI.parse _namespace_name "isMeasurementOf" |> NamespacedName

    /// <summary>
    /// Specific Data Management Processes maintain specific BO/T/As or BODs
    /// <see href="http://www.data-knowledge.org/dk/maintains"></see></summary>
    let maintains = Namespaced_IRI.parse _namespace_name "maintains" |> NamespacedName
    /// <summary>
    /// A specific Mapping Class assigns various representations of the same concepts, i.e in a conceptual vs. technical view (possibly in different data formats, e.g. Java or XML objects).
    ///  Code Mappings map from Code to NamedValue ;
    ///  Type Mappings map from BusinessObjectType to DataObjectType ;
    ///  Attribute Mappings map from BusinessObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Schema Mappings map from DataObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Key Mappings map from Business to DataObject
    /// <see href="http://www.data-knowledge.org/dk/mapsFrom"></see></summary>
    let mapsFrom = Namespaced_IRI.parse _namespace_name "mapsFrom" |> NamespacedName
    /// <summary>
    /// A specific Mapping Class assigns various representations of the same concepts, i.e in a conceptual vs. technical view (possibly in different data formats, e.g. Java or XML objects).
    ///  Code Mappings map from Code to NamedValue ;
    ///  Type Mappings map from BusinessObjectType to DataObjectType ;
    ///  Attribute Mappings map from BusinessObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Schema Mappings map from DataObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Key Mappings map from Business to DataObject
    /// <see href="http://www.data-knowledge.org/dk/mapsTo"></see></summary>
    let mapsTo = Namespaced_IRI.parse _namespace_name "mapsTo" |> NamespacedName

    /// <summary>
    /// A person or organizational unit can participate in trainings
    /// <see href="http://www.data-knowledge.org/dk/participatesIn"></see></summary>
    let participatesIn =
        Namespaced_IRI.parse _namespace_name "participatesIn" |> NamespacedName

    /// <summary>
    /// Change requests are processed by DM processes
    /// <see href="http://www.data-knowledge.org/dk/processes"></see></summary>
    let processes = Namespaced_IRI.parse _namespace_name "processes" |> NamespacedName
    /// <summary>
    /// A reference from a BOTA to a Code List or from a DOTA to an Enumeration
    /// <see href="http://www.data-knowledge.org/dk/refersTo"></see></summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName
    /// <summary>
    /// Connection from specific instances (BOs, DOs, BOAs, DOAs) to conceptually coherent sets of entities (BOTs, DOTs, BOTAs, DOTAs)
    /// <see href="http://www.data-knowledge.org/dk/represents"></see></summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName

    /// <summary>
    /// Specific assignment of a responsibility for a particular scope
    /// <see href="http://www.data-knowledge.org/dk/responsibleFor"></see></summary>
    let responsibleFor =
        Namespaced_IRI.parse _namespace_name "responsibleFor" |> NamespacedName

    /// <summary>
    /// Persons can take Roles
    /// <see href="http://www.data-knowledge.org/dk/takes"></see></summary>
    let takes = Namespaced_IRI.parse _namespace_name "takes" |> NamespacedName
    /// <summary>
    /// The change history keeps track of changes to instances
    /// <see href="http://www.data-knowledge.org/dk/tracks"></see></summary>
    let tracks = Namespaced_IRI.parse _namespace_name "tracks" |> NamespacedName

    /// <summary>
    /// This property specifies what data is actually transferred by the data flow. This requires the data from the source application, represented by a Data Object Type, to be mapped to the data expected by the target application, also represented by a Data Object Type. Consequently, this property links a Data Flow with a Schema Mapping that outlines the source and target Data Object Types and how they map.
    /// <see href="http://www.data-knowledge.org/dk/transfersData"></see></summary>
    let transfersData =
        Namespaced_IRI.parse _namespace_name "transfersData" |> NamespacedName

    /// <summary>
    /// Business Processes consume or use BO/T/As or BODs
    /// <see href="http://www.data-knowledge.org/dk/uses"></see></summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName
    /// <summary>
    /// Projects work on Business Object Types or Applications, e.g. by creating or changing them
    /// <see href="http://www.data-knowledge.org/dk/worksOn"></see></summary>
    let worksOn = Namespaced_IRI.parse _namespace_name "worksOn" |> NamespacedName
