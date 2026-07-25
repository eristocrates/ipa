namespace http.www.data_knowledge.org.dk.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dk =
    let _namespace_iri = Namespace_Iri dk |> NamespaceIRI
    /// <summary>
    ///   <para>dk:DataAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcat:DataSet</para>
    ///   <para>owl:Class</para>
    ///   <para>odrl:Asset</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A Data Asset represents a collection of Data Objects serving an organizational or a business goal. The contained Data Objects may be of the same or of different Data Object Types.</para>
    ///   <para>Ein Datengut stellt eine Menge von Datenobjekten dar, die ein betriebliches oder geschäftliches Ziel unterstützen. Die enthaltenen Datenobjekte können vom dem selben oder unterschiedlichen Datenobjekttypen stammen.</para>
    /// labels<para>Data Asset</para><para>Datengut</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataAsset">http://www.data-knowledge.org/dk/DataAsset</seealso>
    let DataAsset = Prefixed_Name(dk, "DataAsset") |> PrefixedName
    /// <summary>
    ///   <para>dk:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstrakte Definition einer allgemeinen Funktion und ihrer Ziele und Autoritäten</para>
    ///   <para>Abstract definition of a general function and its goals and authorities</para>
    /// labels<para>Rolle</para><para>Role</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Role">http://www.data-knowledge.org/dk/Role</seealso>
    let Role = Prefixed_Name(dk, "Role") |> PrefixedName
    /// <summary>
    ///   <para>dk:KpiMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Konkrete Leistungskennzahlen, zu einer bestimmten Zeit gemessen</para>
    ///   <para>Actual performance values measured at a particular time</para>
    /// labels<para>KPI Measurement</para><para>KPI-Messwert</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/KpiMeasurement">http://www.data-knowledge.org/dk/KpiMeasurement</seealso>
    let KpiMeasurement = Prefixed_Name(dk, "KpiMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>dk:schema/rdf/latest/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/schema/rdf/latest/">http://www.data-knowledge.org/dk/schema/rdf/latest/</seealso>
    let ``schema/rdf/latest/`` = Prefixed_Name(dk, "schema/rdf/latest/") |> PrefixedName
    /// <summary>
    ///   <para>dk:DataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individual record of a Data Object Type (DOT), i.e. the technical representation of a Business Object (BO)</para>
    ///   <para>Individuelle Instanz eines Datenobjekttyps (DOT), d.h. die technische Repräsentation eines Geschäftsobjekts (BO)</para>
    /// labels<para>Datenobjekt (DO)</para><para>Data Object (DO)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataObject">http://www.data-knowledge.org/dk/DataObject</seealso>
    let DataObject = Prefixed_Name(dk, "DataObject") |> PrefixedName
    /// <summary>
    ///   <para>dk:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>The Data Knowledge Vocabulary</para><para>Das Data-Knowledge-Vokabular</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/">http://www.data-knowledge.org/dk/</seealso>
    let _prefix_iri = Prefixed_Name(dk, "") |> PrefixedName
    /// <summary>
    ///   <para>dk:1.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/1.0/">http://www.data-knowledge.org/dk/1.0/</seealso>
    let ``_1.0/`` = Prefixed_Name(dk, "1.0/") |> PrefixedName
    /// <summary>
    ///   <para>dk:ApplicationInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Technical specification of an application to exchange data</para>
    ///   <para>Technische Spezifikation einer Applikation, um Daten auszutauschen</para>
    /// labels<para>Applikationsschnittstelle</para><para>Application Interface</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/ApplicationInterface">http://www.data-knowledge.org/dk/ApplicationInterface</seealso>
    let ApplicationInterface = Prefixed_Name(dk, "ApplicationInterface") |> PrefixedName
    /// <summary>
    ///   <para>dk:DataObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Technische Repräsentation eines Geschäftsobjekttyps (BOT)</para>
    ///   <para>Technical representation of a Business Object Type (BOT)</para>
    /// labels<para>Data Object Type (DOT)</para><para>Datenobjekttyp (DOT)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataObjectType">http://www.data-knowledge.org/dk/DataObjectType</seealso>
    let DataObjectType = Prefixed_Name(dk, "DataObjectType") |> PrefixedName
    /// <summary>
    ///   <para>dk:AttributeMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Konzeptuelle Zuordnung von Geschäftsdefinitionen zu technischen Repräsentationen von Attributen.</para>
    ///   <para>Conceptual mapping of business definitions to technical representations for attributes.</para>
    /// labels<para>Attribut-Zuordnung</para><para>Attribute Mapping</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/AttributeMapping">http://www.data-knowledge.org/dk/AttributeMapping</seealso>
    let AttributeMapping = Prefixed_Name(dk, "AttributeMapping") |> PrefixedName
    /// <summary>
    ///   <para>dk:Example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Illustrative instances of a BOT/BOTA to indicate valid / invalid use</para>
    ///   <para>Instanzen eines BOT/BOTA, die gültige und ungültige Nutzung illustrieren</para>
    /// labels<para>Beispiel</para><para>Example</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Example">http://www.data-knowledge.org/dk/Example</seealso>
    let Example = Prefixed_Name(dk, "Example") |> PrefixedName
    /// <summary>
    ///   <para>dk:KnowledgeLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>lifecycle:Lifecycle</para>
    ///   <para>owl:Class</para>
    ///   <para>Definiert den Lebenszyklus einer Datenwissen-Entität, d.h. der Instanzen der Klassen dieses Modells. Diese Art von Lebenszyklus repräsentiert daher einen Metadatenlebenszyklus. Ein Lebenszyklus wird durch eine Menge möglicher Lebenszyklusphasen (lifecycle:State) definiert. Die Lebenszyklusdefinition kann außerdem Einschränkungen der möglichen Übergange zwischen Lebenszyklusphasen spezifizieren (lifecycle:possibleTransition).</para>
    ///   <para>Defines the life cycle of a data knowledge entity, i.e. the instances from the classes of this model. This type of life cycles thus represents a metadata life cycle. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).</para>
    /// labels<para>Knowledge Lifecycle</para><para>Wissenslebenszyklus</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/KnowledgeLifecycle">http://www.data-knowledge.org/dk/KnowledgeLifecycle</seealso>
    let KnowledgeLifecycle = Prefixed_Name(dk, "KnowledgeLifecycle") |> PrefixedName

    /// <summary>
    ///   <para>dk:BusinessRuleAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Repräsentiert die Auswertung einer bestimmten Geschäftsregel auf der Grundlage eines konkreten Datengutes</para>
    ///   <para>Represents the evaluation of a certain Business Rule on a specific Data Asset</para>
    /// labels<para>Geschäftsregelauswertung</para><para>Business Rule Assessment</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/BusinessRuleAssessment">http://www.data-knowledge.org/dk/BusinessRuleAssessment</seealso>
    let BusinessRuleAssessment =
        Prefixed_Name(dk, "BusinessRuleAssessment") |> PrefixedName

    /// <summary>
    ///   <para>dk:ChangeRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Detaillierte Beschreibung eines spezifischen Änderungsbedarfs, welcher sich aus Projekten oder dem operativen Ablauf ergibt</para>
    ///   <para>Detailed description of a specific change requirement, resulting from projects or operations</para>
    /// labels<para>Änderungsanfrage</para><para>Change Request</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/ChangeRequest">http://www.data-knowledge.org/dk/ChangeRequest</seealso>
    let ChangeRequest = Prefixed_Name(dk, "ChangeRequest") |> PrefixedName
    /// <summary>
    ///   <para>dk:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vordefinierter Wert eines Geschäftsobjektattributs (BOTA)</para>
    ///   <para>Pre-defined value for a Business Object Type Attribute (BOTA)</para>
    /// labels<para>Code</para><para>Code</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Code">http://www.data-knowledge.org/dk/Code</seealso>
    let Code = Prefixed_Name(dk, "Code") |> PrefixedName
    /// <summary>
    ///   <para>dk:CodeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List with pre-defined values (Codes) for a Business Object Type Attribute (BOTA)</para>
    ///   <para>Liste mit vordefinierten Werten (Code) für ein Geschäftsobjekt-Attribut (BOTA)</para>
    /// labels<para>Code-Liste</para><para>Code List</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/CodeList">http://www.data-knowledge.org/dk/CodeList</seealso>
    let CodeList = Prefixed_Name(dk, "CodeList") |> PrefixedName
    /// <summary>
    ///   <para>dk:CodeMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Konzeptuelle Zuordnung geschäftsbezogener Codes und Terminologie von Code-Listen zu benannten Werten von technischen Aufzählungen.</para>
    ///   <para>Conceptual mapping of business-related codes and terminology of Code Lists to named values of technical Enumerations.</para>
    /// labels<para>Code-Zuordnung</para><para>Code Mapping</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/CodeMapping">http://www.data-knowledge.org/dk/CodeMapping</seealso>
    let CodeMapping = Prefixed_Name(dk, "CodeMapping") |> PrefixedName
    /// <summary>
    ///   <para>dk:BusinessObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>dk:DataConceptualization</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Conceptual (data) entity relevant to business that represents a coherent set of information about a group of real or virtual objects</para>
    ///   <para>Konzeptuelle, unternehmensrelevante (Daten-) Einheit, welche eine kohärente Menge von Informationen über eine Gruppe realer oder virtueller Objekte darstellt</para>
    /// labels<para>Business Object Type (BOT)</para><para>Geschäftsobjekttyp (BOT)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/BusinessObjectType">http://www.data-knowledge.org/dk/BusinessObjectType</seealso>
    let BusinessObjectType = Prefixed_Name(dk, "BusinessObjectType") |> PrefixedName
    /// <summary>
    ///   <para>dk:flowsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Schnittstelle A sendet Daten</para>
    ///   <para>Interface A sends data</para>
    /// labels<para>fließt von</para><para>flows from</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/flowsFrom">http://www.data-knowledge.org/dk/flowsFrom</seealso>
    let flowsFrom = Prefixed_Name(dk, "flowsFrom") |> PrefixedName

    /// <summary>
    ///   <para>dk:hasApplicationLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the life cycle of an individual Application instance. The current life cycle state of the instance is referred to via the property lifecycle:state.</para>
    ///   <para>Spezifiziert den Lebenszyklus einer individuellen Applikation. Der aktuelle Lebenszyklusstatus der Instanz wird über die Relation lifecycle:state zugewiesen.</para>
    /// labels<para>hat Applikationslebenszyklus</para><para>has application lifecycle</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/hasApplicationLifecycle">http://www.data-knowledge.org/dk/hasApplicationLifecycle</seealso>
    let hasApplicationLifecycle =
        Prefixed_Name(dk, "hasApplicationLifecycle") |> PrefixedName

    /// <summary>
    ///   <para>dk:hasKnowledgeLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Property</para>
    ///   <para>May be used to define a general life cycle that applies to all classes of the model or certain classes.</para>
    ///   <para>Kann genutzt werden, um einen allgemeinen Lebenszyklus, der auf alle Klassen des Modells oder nur auf spezielle Klassen zutrifft, zu definieren.</para>
    /// labels<para>has Knowledge Lifecycle</para><para>hat Wissenslebenszyklus</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/hasKnowledgeLifecycle">http://www.data-knowledge.org/dk/hasKnowledgeLifecycle</seealso>
    let hasKnowledgeLifecycle =
        Prefixed_Name(dk, "hasKnowledgeLifecycle") |> PrefixedName

    /// <summary>
    ///   <para>dk:hasTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>odrl:hasPolicy</para>
    ///   <para>rdfs:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Resources can have specific Terms of Use</para>
    ///   <para>Ressourcen können spezifische Nutzungsbedingungen haben</para>
    /// labels<para>hat Nutzungsbedingungen</para><para>has Terms of Use</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/hasTerms">http://www.data-knowledge.org/dk/hasTerms</seealso>
    let hasTerms = Prefixed_Name(dk, "hasTerms") |> PrefixedName
    /// <summary>
    ///   <para>dk:BusinessObjectDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>dk:DataConceptualization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Clusters of coherent Business Object Types (BOTs), either from a subject matter or management point of view</para>
    ///   <para>Gruppierung kohärenter Geschäftsobjekttypen (BOTs), entweder aus Themen- oder Verwaltungssicht</para>
    /// labels<para>Business Object Domain (BOD)</para><para>Geschäftsobjektdomäne (BOD)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/BusinessObjectDomain">http://www.data-knowledge.org/dk/BusinessObjectDomain</seealso>
    let BusinessObjectDomain = Prefixed_Name(dk, "BusinessObjectDomain") |> PrefixedName

    /// <summary>
    ///   <para>dk:BusinessObjectTypeAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>dk:DataConceptualization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Conceptually elementary piece of information as part of a Business Object Type (BOT)</para>
    ///   <para>Konzeptuell elementare Informationseinheit als Teil eines Geschäftsobjekttyps (BOT)</para>
    /// labels<para>Business Object Type Attribute (BOTA)</para><para>Geschäftsobjekttyp-Attribut (BOTA)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/BusinessObjectTypeAttribute">http://www.data-knowledge.org/dk/BusinessObjectTypeAttribute</seealso>
    let BusinessObjectTypeAttribute =
        Prefixed_Name(dk, "BusinessObjectTypeAttribute") |> PrefixedName

    /// <summary>
    ///   <para>dk:DataConceptualization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Eine Daten-Konzeptualisierung repräsentiert ein fachliches Konzept, mit dem Daten spezifiziert oder strukturiert werden. Da es sich um eine abstrakte Super-Klasse handelt, sollten nur ihre Subklassen verwendet werden.</para>
    ///   <para>A Data Conceptualization represents a business concept to specify and structure data. As this is an abstract superclass only its subclasses may be used.</para>
    /// labels<para>Daten-Konzeptualisierung</para><para>Data Conceptualization</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataConceptualization">http://www.data-knowledge.org/dk/DataConceptualization</seealso>
    let DataConceptualization =
        Prefixed_Name(dk, "DataConceptualization") |> PrefixedName

    /// <summary>
    ///   <para>dk:basedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Die Definition einer Leistungskennzahl (KPI Definition) basier auf einer Geschäftsregel (BR).</para>
    ///   <para>A KPI Definition is based on a Business Rule (BR)</para>
    /// labels<para>basiert auf</para><para>based on</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/basedOn">http://www.data-knowledge.org/dk/basedOn</seealso>
    let basedOn = Prefixed_Name(dk, "basedOn") |> PrefixedName
    /// <summary>
    ///   <para>dk:ChangeHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Informationen, welche es erlauben, die Entwicklung von Datendefinitionen, Prozessen, etc. nachzuverfolgen</para>
    ///   <para>Information that allows to track the development of data definitions, processes, etc.</para>
    /// labels<para>Änderungshistorie</para><para>Change History</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/ChangeHistory">http://www.data-knowledge.org/dk/ChangeHistory</seealso>
    let ChangeHistory = Prefixed_Name(dk, "ChangeHistory") |> PrefixedName
    /// <summary>
    ///   <para>dk:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Business Processes consume or use BO/T/As or BODs</para>
    ///   <para>Geschäftsprozesse konsumieren oder nutzen BO/T/As oder BODs</para>
    /// labels<para>nutzt</para><para>uses</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/uses">http://www.data-knowledge.org/dk/uses</seealso>
    let uses = Prefixed_Name(dk, "uses") |> PrefixedName
    /// <summary>
    ///   <para>dk:BusinessProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sequence of activities consuming or relying on data (data usage perspective)</para>
    ///   <para>Abfolge von Tätigkeiten, die Daten konsumieren oder von ihnen abhängen (Datennutzungsperspektive)</para>
    /// labels<para>Business Process</para><para>Geschäftsprozess</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/BusinessProcess">http://www.data-knowledge.org/dk/BusinessProcess</seealso>
    let BusinessProcess = Prefixed_Name(dk, "BusinessProcess") |> PrefixedName
    /// <summary>
    ///   <para>dk:hasDataLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdfs:Property</para>
    ///   <para>Spezifiziert den Lebenszyklus einer individuellen Instanz eines Geschäftsobjekts, Datenobjekts oder Datenguts. Diese Relation kann genutzt werden, um die generelle Typebenen-Definition des Lebenszyklus, welche durch definesLifecycleOfInstances ausgedrückt wird, zu überschreiben. Der aktuelle Lebenszyklusstatus der Instanz wird über die Relation lifecycle:state zugewiesen.</para>
    ///   <para>Specifies the life cycle of an individual instance of a Business Object, Data Object or Data Asset. This property can be used to override the general type level life cycle definition expressed by definesLifecycleOfInstances. The current life cycle state of the instance is referred to via the property lifecycle:state</para>
    /// labels<para>hat Datenlebenszyklus</para><para>has data lifecycle</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/hasDataLifecycle">http://www.data-knowledge.org/dk/hasDataLifecycle</seealso>
    let hasDataLifecycle = Prefixed_Name(dk, "hasDataLifecycle") |> PrefixedName
    /// <summary>
    ///   <para>dk:illustrates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An example illustrates a BOT/A</para>
    ///   <para>Ein Beispiel illustriert ein BOT/A</para>
    /// labels<para>illustrates</para><para>illustriert</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/illustrates">http://www.data-knowledge.org/dk/illustrates</seealso>
    let illustrates = Prefixed_Name(dk, "illustrates") |> PrefixedName
    /// <summary>
    ///   <para>dk:isMeasurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>dqv:isMeasurementOf</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A KPI Measurement is computed according to a KPI Definition on a given data asset at a given time. Similarly, a Business Rule Assessment results from a Business Rule</para>
    ///   <para>Eine Leistungskennzahl (KPI)wird anhand einer Leistungskennzahlen-Definition (KPI-Definition) für ein bestimmtes Datengut zu einer bestimmten Zeit berechnet. In gleicher Weise ergibt sich eine Geschäftsregelauswertung aus einer Geschäftsregel </para>
    /// labels<para>ist ein Messwert von</para><para>is measurement of</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/isMeasurementOf">http://www.data-knowledge.org/dk/isMeasurementOf</seealso>
    let isMeasurementOf = Prefixed_Name(dk, "isMeasurementOf") |> PrefixedName
    /// <summary>
    ///   <para>dk:mapsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine spezifische Zuordnungs-Klasse (Mapping) weist verschiedene Repräsentationen des selben Konzeptes zu, dh. hinsichtlich einer konzeptuellen ggü. einer technischen Sicht (möglicherweise in verschiedenen Datenformaten, z.B. Java oder XML-Objekte).
    ///  Code Mappings ordnen zu von Code zu NamedValue ;
    ///  Type Mappings ordnen zu von BusinessObjectType zu DataObjectType ;
    ///  Attribute Mappings ordnen zu von BusinessObjectTypeAttribute zu DataObjectTypeAttribute ;
    ///  Schema Mappings ordnen zu von DataObjectTypeAttribute zu DataObjectTypeAttribute ;
    ///  Key Mappings ordnen zu von Business zu DataObject</para>
    ///   <para>A specific Mapping Class assigns various representations of the same concepts, i.e in a conceptual vs. technical view (possibly in different data formats, e.g. Java or XML objects).
    ///  Code Mappings map from Code to NamedValue ;
    ///  Type Mappings map from BusinessObjectType to DataObjectType ;
    ///  Attribute Mappings map from BusinessObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Schema Mappings map from DataObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Key Mappings map from Business to DataObject</para>
    /// labels<para>ordnet zu von</para><para>maps from</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/mapsFrom">http://www.data-knowledge.org/dk/mapsFrom</seealso>
    let mapsFrom = Prefixed_Name(dk, "mapsFrom") |> PrefixedName
    /// <summary>
    ///   <para>dk:mapsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine spezifische Zuordnungs-Klasse (Mapping) weist verschiedene Repräsentationen des selben Konzeptes zu, dh. hinsichtlich einer konzeptuellen ggü. einer technischen Sicht (möglicherweise in verschiedenen Datenformaten, z.B. Java oder XML-Objekte).
    ///  Code Mappings ordnen zu von Code zu NamedValue ;
    ///  Type Mappings ordnen zu von BusinessObjectType zu DataObjectType ;
    ///  Attribute Mappings ordnen zu von BusinessObjectTypeAttribute zu DataObjectTypeAttribute ;
    ///  Schema Mappings ordnen zu von DataObjectTypeAttribute zu DataObjectTypeAttribute ;
    ///  Key Mappings ordnen zu von Business zu DataObject</para>
    ///   <para>A specific Mapping Class assigns various representations of the same concepts, i.e in a conceptual vs. technical view (possibly in different data formats, e.g. Java or XML objects).
    ///  Code Mappings map from Code to NamedValue ;
    ///  Type Mappings map from BusinessObjectType to DataObjectType ;
    ///  Attribute Mappings map from BusinessObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Schema Mappings map from DataObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Key Mappings map from Business to DataObject</para>
    /// labels<para>ordnet zu zu</para><para>maps to</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/mapsTo">http://www.data-knowledge.org/dk/mapsTo</seealso>
    let mapsTo = Prefixed_Name(dk, "mapsTo") |> PrefixedName
    /// <summary>
    ///   <para>dk:processes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Change requests are processed by DM processes</para>
    ///   <para>Änderungsanfragen (CRs) werden von Datenmanagementprozessen verarbeitet</para>
    /// labels<para>verarbeitet</para><para>processes</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/processes">http://www.data-knowledge.org/dk/processes</seealso>
    let processes = Prefixed_Name(dk, "processes") |> PrefixedName
    /// <summary>
    ///   <para>dk:flowsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Daten werden zu Schnittstelle B gesendet</para>
    ///   <para>Data is sent to Interface B</para>
    /// labels<para>fließt an</para><para>flows to</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/flowsTo">http://www.data-knowledge.org/dk/flowsTo</seealso>
    let flowsTo = Prefixed_Name(dk, "flowsTo") |> PrefixedName
    /// <summary>
    ///   <para>dk:initiates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A project or a Data Management Process initiates a change request</para>
    ///   <para>Ein Projekt oder ein Datenmanagementprozess initiiert eine Änderungsanfrage</para>
    /// labels<para>initiiert</para><para>initiates</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/initiates">http://www.data-knowledge.org/dk/initiates</seealso>
    let initiates = Prefixed_Name(dk, "initiates") |> PrefixedName
    /// <summary>
    ///   <para>dk:maintains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specific Data Management Processes maintain specific BO/T/As or BODs</para>
    ///   <para>Spezifische Datenmanagementprozesse pflegen spezifische BO/T/As oder BODs</para>
    /// labels<para>maintains</para><para>pflegt</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/maintains">http://www.data-knowledge.org/dk/maintains</seealso>
    let maintains = Prefixed_Name(dk, "maintains") |> PrefixedName
    /// <summary>
    ///   <para>dk:participatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person or organizational unit can participate in trainings</para>
    ///   <para>Eine Person oder Organisationseinheit kann an Training teilnehmen</para>
    /// labels<para>participates in</para><para>nimmt Teil an</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/participatesIn">http://www.data-knowledge.org/dk/participatesIn</seealso>
    let participatesIn = Prefixed_Name(dk, "participatesIn") |> PrefixedName
    /// <summary>
    ///   <para>dk:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ein Verweis von einem BOTA zu einer Code-Liste oder von einem DOTA zu einem Aufzählungstyp</para>
    ///   <para>A reference from a BOTA to a Code List or from a DOTA to an Enumeration</para>
    /// labels<para>verweist auf</para><para>refers to</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/refersTo">http://www.data-knowledge.org/dk/refersTo</seealso>
    let refersTo = Prefixed_Name(dk, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>dk:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Verknüpfung von spezifischen Instanzen (BOs, DOs, BOAs, DOAs) zu konzeptuell kohärenten Mengen von Entitäten (BOTs, DOTs, BOTAs, DOTAs)</para>
    ///   <para>Connection from specific instances (BOs, DOs, BOAs, DOAs) to conceptually coherent sets of entities (BOTs, DOTs, BOTAs, DOTAs)</para>
    /// labels<para>repräsentiert</para><para>represents</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/represents">http://www.data-knowledge.org/dk/represents</seealso>
    let represents = Prefixed_Name(dk, "represents") |> PrefixedName
    /// <summary>
    ///   <para>dk:responsibleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Spezifische Zuweisung einer Verantwortlichkeit für einen gewissen Bereich</para>
    ///   <para>Specific assignment of a responsibility for a particular scope</para>
    /// labels<para>verantwortlich für</para><para>responsible for</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/responsibleFor">http://www.data-knowledge.org/dk/responsibleFor</seealso>
    let responsibleFor = Prefixed_Name(dk, "responsibleFor") |> PrefixedName
    /// <summary>
    ///   <para>dk:takes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Persons can take Roles</para>
    ///   <para>Personen können Rollen einnehmen</para>
    /// labels<para>nimmt an</para><para>takes</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/takes">http://www.data-knowledge.org/dk/takes</seealso>
    let takes = Prefixed_Name(dk, "takes") |> PrefixedName
    /// <summary>
    ///   <para>dk:transfersData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Diese Relation spezifiziert, welche Daten konkret im Rahmen des Datenflusses übermittelt werden. Hierzu müssen die Daten aus der Quellapplikation, repräsentiert durch einen Datenobjekttyp (DOT), den von der Zielapplikation erwarteten Daten zugewiesen werden, welche ebenfalls durch einen Datenobjekttyp (DOT) repräsentiert werden. Somit verbindet diese Relation einen Datenfluss mit einer Schema-Zuordnung, die die Quell- und Ziel-DOTs und ihre Zuordnung beschreibt.</para>
    ///   <para>This property specifies what data is actually transferred by the data flow. This requires the data from the source application, represented by a Data Object Type, to be mapped to the data expected by the target application, also represented by a Data Object Type. Consequently, this property links a Data Flow with a Schema Mapping that outlines the source and target Data Object Types and how they map.</para>
    /// labels<para>übermittelt Daten</para><para>transfers data</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/transfersData">http://www.data-knowledge.org/dk/transfersData</seealso>
    let transfersData = Prefixed_Name(dk, "transfersData") |> PrefixedName
    /// <summary>
    ///   <para>dk:worksOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Projekte arbeiten an Geschäftsobjekttypen (BOTs) oder Applikationen, indem sie diese z.B. erstellen oder verändern</para>
    ///   <para>Projects work on Business Object Types or Applications, e.g. by creating or changing them</para>
    /// labels<para>arbeitet an</para><para>works on</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/worksOn">http://www.data-knowledge.org/dk/worksOn</seealso>
    let worksOn = Prefixed_Name(dk, "worksOn") |> PrefixedName
    /// <summary>
    ///   <para>dk:tracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Die Änderungshistorie verfolgt Änderungen an Instanzen</para>
    ///   <para>The change history keeps track of changes to instances</para>
    /// labels<para>verfolgt</para><para>tracks</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/tracks">http://www.data-knowledge.org/dk/tracks</seealso>
    let tracks = Prefixed_Name(dk, "tracks") |> PrefixedName
    /// <summary>
    ///   <para>dk:DataFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Zeigt die tatsächliche Verbindung und den Datenaustausch zwischen konkreten Applikationen an</para>
    ///   <para>Indicates the actual connection and data exchange between particular applications</para>
    /// labels<para>Datenfluss</para><para>Data Flow</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataFlow">http://www.data-knowledge.org/dk/DataFlow</seealso>
    let DataFlow = Prefixed_Name(dk, "DataFlow") |> PrefixedName
    /// <summary>
    ///   <para>dk:DataLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lifecycle:Lifecyle</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Definiert den Lebenszyklus von Geschäftsobjekten, Datenobjekten und Datengütern. Ein Lebenszyklus wird durch eine Menge möglicher Lebenszyklusphasen (lifecycle:State) definiert. Die Lebenszyklusdefinition kann außerdem Einschränkungen der möglichen Übergange zwischen Lebenszyklusphasen spezifizieren (lifecycle:possibleTransition).</para>
    ///   <para>Defines the life cycle of Business Objects, Data Objects and Data Assets. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).</para>
    /// labels<para>Datenlebenszyklus</para><para>Data Lifecycle</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataLifecycle">http://www.data-knowledge.org/dk/DataLifecycle</seealso>
    let DataLifecycle = Prefixed_Name(dk, "DataLifecycle") |> PrefixedName

    /// <summary>
    ///   <para>dk:DataManagementProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abfolge von Tätigkeiten für die Datenpflege oder die Daten-Governance</para>
    ///   <para>Sequence of activities for data maintenance or data governance</para>
    /// labels<para>Data Management Process</para><para>Datenmanagementprozess</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataManagementProcess">http://www.data-knowledge.org/dk/DataManagementProcess</seealso>
    let DataManagementProcess =
        Prefixed_Name(dk, "DataManagementProcess") |> PrefixedName

    /// <summary>
    ///   <para>dk:DataObjectAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Eine Informationseinheit, welche Bestandteil eines Datenobjekts (DO) ist, d.h. die technische Repräsentation eines Geschäftsobjektattributs (BOA)</para>
    ///   <para>A piece of information being a part of a Data Object (DO), i.e. the technical representation of a Business Object Attribute (BOA)</para>
    /// labels<para>Data Object Attribute (DOA)</para><para>Datenobjektattribut (DOA)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataObjectAttribute">http://www.data-knowledge.org/dk/DataObjectAttribute</seealso>
    let DataObjectAttribute = Prefixed_Name(dk, "DataObjectAttribute") |> PrefixedName

    /// <summary>
    ///   <para>dk:DataObjectTypeAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individuelles (atomares) Feld, um eine Informationseineit zu speichern</para>
    ///   <para>Individual (atomic) field to store a piece of information</para>
    /// labels<para>Data Object Type Attribute (DOTA)</para><para>Datenobjekttypattribut (DOTA)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/DataObjectTypeAttribute">http://www.data-knowledge.org/dk/DataObjectTypeAttribute</seealso>
    let DataObjectTypeAttribute =
        Prefixed_Name(dk, "DataObjectTypeAttribute") |> PrefixedName

    /// <summary>
    ///   <para>dk:NamedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vordefinierter Wert einer Enumeration eines Datenobjekttyp-Attribut (DOTA)</para>
    ///   <para>Pre-defined value of an Enumeration for a Data Object Type Attribute (DOTA)</para>
    /// labels<para>Benannter Wert</para><para>Named Value</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/NamedValue">http://www.data-knowledge.org/dk/NamedValue</seealso>
    let NamedValue = Prefixed_Name(dk, "NamedValue") |> PrefixedName
    /// <summary>
    ///   <para>dk:FAQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Häufig gestellte Fragen</para>
    ///   <para>Frequently Asked Questions</para>
    /// labels<para>FAQ</para><para>FAQ</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/FAQ">http://www.data-knowledge.org/dk/FAQ</seealso>
    let FAQ = Prefixed_Name(dk, "FAQ") |> PrefixedName
    /// <summary>
    ///   <para>dk:KeyMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kann genutzt werden, um Datenobjekte verschiedener Applikationen zuzuordnen, die die selbe Geschäftsentität repräsentieren. Dies kann bei der Erstellung von 'Golden Records' und der Datenverteilung nützlich sein.</para>
    ///   <para>May be used to map data objects from different applications that represent the same business entity. This is useful for creation of 'golden records' and the distribution of data.</para>
    /// labels<para>Schlüssel-Zuordnung</para><para>Key Mapping</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/KeyMapping">http://www.data-knowledge.org/dk/KeyMapping</seealso>
    let KeyMapping = Prefixed_Name(dk, "KeyMapping") |> PrefixedName
    /// <summary>
    ///   <para>dk:KpiDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines a data quality (performance) measure based on a set of business rules</para>
    ///   <para>Definiert eine Datenqualitäts-Leistungskennzahl basierend auf einer Menge von Geschäftsregeln</para>
    /// labels<para>KPI-Definition</para><para>KPI Definition</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/KpiDefinition">http://www.data-knowledge.org/dk/KpiDefinition</seealso>
    let KpiDefinition = Prefixed_Name(dk, "KpiDefinition") |> PrefixedName
    /// <summary>
    ///   <para>dk:TypeMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Konzeptuelle Zuordnung von Geschäftsdefinitionen zu technischen Repräsentationen von Objekten.</para>
    ///   <para>Conceptual mapping of business definitions to technical representations for objects.</para>
    /// labels<para>Typ-Zuordnung</para><para>Type Mapping</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/TypeMapping">http://www.data-knowledge.org/dk/TypeMapping</seealso>
    let TypeMapping = Prefixed_Name(dk, "TypeMapping") |> PrefixedName
    /// <summary>
    ///   <para>dk:SchemaMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Technische Zuordnung, welche Datenflüsse zwischen Applikationen spezifiziert.</para>
    ///   <para>Technical mapping specifiying data flows between Applications.</para>
    /// labels<para>Schema-Zuordnung</para><para>Schema Mapping</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/SchemaMapping">http://www.data-knowledge.org/dk/SchemaMapping</seealso>
    let SchemaMapping = Prefixed_Name(dk, "SchemaMapping") |> PrefixedName
    /// <summary>
    ///   <para>dk:OrganizationalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Einheit der Organisationsstruktur (Hierarchie), Gruppe von Individuen</para>
    ///   <para>Unit of the organizational structure (hierarchy), group of individuals</para>
    /// labels<para>Organisationseinheit</para><para>Organizational Unit</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/OrganizationalUnit">http://www.data-knowledge.org/dk/OrganizationalUnit</seealso>
    let OrganizationalUnit = Prefixed_Name(dk, "OrganizationalUnit") |> PrefixedName
    /// <summary>
    ///   <para>dk:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individuum einer Organisation, welchem bestimmte Rollen zugewiesen werden</para>
    ///   <para>Individual of an organization assigned with certain roles</para>
    /// labels<para>Person</para><para>Person</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Person">http://www.data-knowledge.org/dk/Person</seealso>
    let Person = Prefixed_Name(dk, "Person") |> PrefixedName
    /// <summary>
    ///   <para>dk:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ein Projekt, welches Änderungen von Daten oder dem Datenmanagement zum Zweck hat</para>
    ///   <para>A project that implies changes to data or data management</para>
    /// labels<para>Project</para><para>Projekt</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Project">http://www.data-knowledge.org/dk/Project</seealso>
    let Project = Prefixed_Name(dk, "Project") |> PrefixedName
    /// <summary>
    ///   <para>dk:ProjectPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Zeitplan, der illustriert, wann eine bestimmte Maßnahme ergriffen wird</para>
    ///   <para>Schedule illustrating when a particular action is taken on something</para>
    /// labels<para>Project Plan</para><para>Projektplan</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/ProjectPlan">http://www.data-knowledge.org/dk/ProjectPlan</seealso>
    let ProjectPlan = Prefixed_Name(dk, "ProjectPlan") |> PrefixedName
    /// <summary>
    ///   <para>dk:Regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Interne oder externe Verordnung, die das Datenmanagement beeinflusst</para>
    ///   <para>Internal or external regulatory driver influencing data management</para>
    /// labels<para>Vorschrift</para><para>Regulation</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Regulation">http://www.data-knowledge.org/dk/Regulation</seealso>
    let Regulation = Prefixed_Name(dk, "Regulation") |> PrefixedName
    /// <summary>
    ///   <para>dk:Responsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Genaue Beschreibung einer Verantwortlichkeit, inkl. ihres genauen Zuständigkeitsbereiches, der Dauer der Zuständigkeit, zu ergreifenden Maßnahmen und weiteren Informationen</para>
    ///   <para>Specific description of a responsibility, including the particular scope, duration of accountability, measures to be taken and further information</para>
    /// labels<para>Verantwortlichkeit</para><para>Responsibility</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Responsibility">http://www.data-knowledge.org/dk/Responsibility</seealso>
    let Responsibility = Prefixed_Name(dk, "Responsibility") |> PrefixedName

    /// <summary>
    ///   <para>dk:SupplementaryDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lern- oder Referenzmaterial für Datenmanagementoperationen</para>
    ///   <para>Material to learn or use as a reference for data management operations</para>
    /// labels<para>Supplementary Documentation</para><para>Ergänzende Dokumentation</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/SupplementaryDocumentation">http://www.data-knowledge.org/dk/SupplementaryDocumentation</seealso>
    let SupplementaryDocumentation =
        Prefixed_Name(dk, "SupplementaryDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>dk:TermsOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>odrl:Policy</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Terms of use specify the terms and conditions under which an Application or a Data Asset can or must be used.</para>
    ///   <para>Die Nutzungsbedingungen geben an, unter welchen Bedinungen und Konditionen eine Applikation oder ein Datengut verwendet werden können oder müssen.</para>
    /// labels<para>Nutzungsbedingungen</para><para>Terms of Use</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/TermsOfUse">http://www.data-knowledge.org/dk/TermsOfUse</seealso>
    let TermsOfUse = Prefixed_Name(dk, "TermsOfUse") |> PrefixedName
    /// <summary>
    ///   <para>dk:TrainingOpportunity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A planned event a person can participate in</para>
    ///   <para>Eine geplante Veranstaltung, an der eine Person teilnehmen kann</para>
    /// labels<para>Training Opportunity</para><para>Trainingsmöglichkeit</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/TrainingOpportunity">http://www.data-knowledge.org/dk/TrainingOpportunity</seealso>
    let TrainingOpportunity = Prefixed_Name(dk, "TrainingOpportunity") |> PrefixedName
    /// <summary>
    ///   <para>dk:affects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Change Requests affects a Business Object Type or an Application</para>
    ///   <para>Eine Änderungsanfrage betrifft einen Geschäftsobjekttypen (BOT)</para>
    /// labels<para>betrifft</para><para>affects</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/affects">http://www.data-knowledge.org/dk/affects</seealso>
    let affects = Prefixed_Name(dk, "affects") |> PrefixedName
    /// <summary>
    ///   <para>dk:answersQuestionAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>FAQ beantworten Fragen zu verschiedenen Modellbereichen</para>
    ///   <para>FAQ answer questions about various model areas</para>
    /// labels<para>answers question about</para><para>beantwortet Fragen zu</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/answersQuestionAbout">http://www.data-knowledge.org/dk/answersQuestionAbout</seealso>
    let answersQuestionAbout = Prefixed_Name(dk, "answersQuestionAbout") |> PrefixedName
    /// <summary>
    ///   <para>dk:appliesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Regulations can apply to all kinds of instances</para>
    ///   <para>Vorschriften können für alle Arten von Instanzen gelten</para>
    /// labels<para>applies to</para><para>gilt für</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/appliesTo">http://www.data-knowledge.org/dk/appliesTo</seealso>
    let appliesTo = Prefixed_Name(dk, "appliesTo") |> PrefixedName
    /// <summary>
    ///   <para>dk:associatesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>unspecified association between entities</para>
    ///   <para>unspezifische Verknüpfung zwischen Entitäten</para>
    /// labels<para>ist verknüpft mit</para><para>associates with</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/associatesWith">http://www.data-knowledge.org/dk/associatesWith</seealso>
    let associatesWith = Prefixed_Name(dk, "associatesWith") |> PrefixedName
    /// <summary>
    ///   <para>dk:carries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Rollen und Organisationseinheiten können spezifische Verantwortungen tragen</para>
    ///   <para>Roles and Organizational Units can carry specific responsibilites</para>
    /// labels<para>carries</para><para>trägt</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/carries">http://www.data-knowledge.org/dk/carries</seealso>
    let carries = Prefixed_Name(dk, "carries") |> PrefixedName
    /// <summary>
    ///   <para>dk:comprises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Ein Bericht umfasst gewisse Leistungskennzahlen (KPIs) und ihre Definitionen</para>
    ///   <para>A Report comprises certain KPI Measurements and their definitions</para>
    /// labels<para>beinhaltet</para><para>comprises</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/comprises">http://www.data-knowledge.org/dk/comprises</seealso>
    let comprises = Prefixed_Name(dk, "comprises") |> PrefixedName
    /// <summary>
    ///   <para>dk:computedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dqv:computedOn</para>
    ///   <para>A KPI Measurement and Business Rule Assessments is computed on a Data Asset</para>
    ///   <para>Eine Leistungskennzahl (KPI) und eine Geschäftsregelauswertung wird für ein Datengut berechnet</para>
    /// labels<para>berechnet für</para><para>computed on</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/computedOn">http://www.data-knowledge.org/dk/computedOn</seealso>
    let computedOn = Prefixed_Name(dk, "computedOn") |> PrefixedName
    /// <summary>
    ///   <para>dk:cooperatesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Organizational Units and Roles can cooperate</para>
    ///   <para>Organisationseinheiten und Rollen können kooperieren</para>
    /// labels<para>cooperates with</para><para>kooperiert mit</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/cooperatesWith">http://www.data-knowledge.org/dk/cooperatesWith</seealso>
    let cooperatesWith = Prefixed_Name(dk, "cooperatesWith") |> PrefixedName
    /// <summary>
    ///   <para>dk:definesIntegrityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Eine Geschäftsregel (BR) definiert die Integrität von Geschäftsobjekten (BOs), Geschäftsobjekttypen (BOTs) und Geschäftsobjekt-Attributen (BOAs)</para>
    ///   <para>A Business Rule (BR) defines the integrity of Business Objects (BOs), Business Object Types (BOTs) and Business Object Attributes (BOAs)</para>
    /// labels<para>definiert die Integrität von</para><para>defines integrity of</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/definesIntegrityOf">http://www.data-knowledge.org/dk/definesIntegrityOf</seealso>
    let definesIntegrityOf = Prefixed_Name(dk, "definesIntegrityOf") |> PrefixedName

    /// <summary>
    ///   <para>dk:definesLifecycleOfInstances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the life cycle of the Business Object instances on the conceptual type level. The current life cycle state of an individual Business Object is referred to from each Business Object via the property lifecycle:state.</para>
    ///   <para>Spezifiziert den Lebenszyklus der Geschäftsobjektinstanzen auf der konzeptuellen Typebene. Der aktuelle Lebenszyklusstatus eines individuellen Geschäftsobjekts wird von jedem Geschäftsobjekt über die Relation lifecycle:state referenziert.</para>
    /// labels<para>definiert den Lebenszyklus von Instanzen</para><para>defines lifecycle of instances</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/definesLifecycleOfInstances">http://www.data-knowledge.org/dk/definesLifecycleOfInstances</seealso>
    let definesLifecycleOfInstances =
        Prefixed_Name(dk, "definesLifecycleOfInstances") |> PrefixedName

    /// <summary>
    ///   <para>dk:documents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Supplementary documentation documents various model areas</para>
    ///   <para>Ergänzende Dokumentation dokumentiert verschiedene Modellbereiche</para>
    /// labels<para>dokumentiert</para><para>documents</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/documents">http://www.data-knowledge.org/dk/documents</seealso>
    let documents = Prefixed_Name(dk, "documents") |> PrefixedName
    /// <summary>
    ///   <para>dk:Enumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Liste mit vordefinierten Werten (Benannter Wert) für ein Datenobjekttyp-Attribut (DOTA)</para>
    ///   <para>List with pre-defined values (Named Values) for a Data Object Type Attribute (DOTA)</para>
    /// labels<para>Enumeration</para><para>Enumeration</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Enumeration">http://www.data-knowledge.org/dk/Enumeration</seealso>
    let Enumeration = Prefixed_Name(dk, "Enumeration") |> PrefixedName
    /// <summary>
    ///   <para>dk:BusinessRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the integrity of a single Business Object or across them</para>
    ///   <para>Legt die Integrität eines einzelnen Geschäftsobjekts oder zwischen Geschäftsobjekten fest</para>
    /// labels<para>Geschäftsregel</para><para>Business Rule</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/BusinessRule">http://www.data-knowledge.org/dk/BusinessRule</seealso>
    let BusinessRule = Prefixed_Name(dk, "BusinessRule") |> PrefixedName
    /// <summary>
    ///   <para>dk:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An installed instance of an application that stores or processes data</para>
    ///   <para>Eine installierte Instanz einer Anwendung, welche Daten speichert oder verarbeitet</para>
    /// labels<para>Applikation</para><para>Application</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Application">http://www.data-knowledge.org/dk/Application</seealso>
    let Application = Prefixed_Name(dk, "Application") |> PrefixedName
    /// <summary>
    ///   <para>dk:ApplicationLifecycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lifecycle:Lifecycle</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Definiert den Lebenszyklus von Applikationen. Ein Lebenszyklus wird durch eine Menge von möglichen Lebenszyklusphasen (lifecycle:State) definiert. Die Lebenszyklusdefinition kann außerdem Einschränkungen der möglichen Übergange zwischen Lebenszyklusphasen spezifizieren (lifecycle:possibleTransition).</para>
    ///   <para>Defines the life cycle of Applications. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).</para>
    /// labels<para>Applikationslebenszyklus</para><para>Application Lifecycle</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/ApplicationLifecycle">http://www.data-knowledge.org/dk/ApplicationLifecycle</seealso>
    let ApplicationLifecycle = Prefixed_Name(dk, "ApplicationLifecycle") |> PrefixedName
    /// <summary>
    ///   <para>dk:Mapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class of different kinds of mappings</para>
    ///   <para>Abstrakte Klasse verschiedener Arten von Zuordnungen</para>
    /// labels<para>Zuordnung</para><para>Mapping</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Mapping">http://www.data-knowledge.org/dk/Mapping</seealso>
    let Mapping = Prefixed_Name(dk, "Mapping") |> PrefixedName
    /// <summary>
    ///   <para>dk:BusinessObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spezifische, individuelle Instanz eines Geschäftsobjekttyps (BOT)</para>
    ///   <para>Specific, individual instance of a Business Object Type (BOT)</para>
    /// labels<para>Geschäftsobjekt (BO)</para><para>Business Object (BO)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/BusinessObject">http://www.data-knowledge.org/dk/BusinessObject</seealso>
    let BusinessObject = Prefixed_Name(dk, "BusinessObject") |> PrefixedName

    /// <summary>
    ///   <para>dk:BusinessObjectAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spezifische, individuelle Instanz eines Geschäftsobjekttyp-Attributs (BOTA)</para>
    ///   <para>Specific, individual instance of a Business Object Type Attribute (BOTA)</para>
    /// labels<para>Business Object Attribute (BOA)</para><para>Geschäftsobjekt-Attribut (BOA)</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/BusinessObjectAttribute">http://www.data-knowledge.org/dk/BusinessObjectAttribute</seealso>
    let BusinessObjectAttribute =
        Prefixed_Name(dk, "BusinessObjectAttribute") |> PrefixedName

    /// <summary>
    ///   <para>dk:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of KPI measurements gathered for a particular purpose</para>
    ///   <para>Menge von KPI-Messwerten, welche für einen bestimmten Zweck zusammengetragen wurden</para>
    /// labels<para>Bericht</para><para>Report</para></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/Report">http://www.data-knowledge.org/dk/Report</seealso>
    let Report = Prefixed_Name(dk, "Report") |> PrefixedName
