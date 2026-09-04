#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dk =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.data-knowledge.org/dk/" "dk"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An installed instance of an application that stores or processes datardfs:comment : Eine installierte Instanz einer Anwendung, welche Daten speichert oder verarbeitet</para>
    ///   <para>rdfs:label : Applikationrdfs:label : Application</para>
    ///   <para>vann:example : Enterprise Resource Planning System (ERP)vann:example : Enterprise Resource Planning System (ERP)</para>
    ///   <a href="http://www.data-knowledge.org/dk/Application">dk:Application</a>
    /// </summary>
    let Application = _prefixId.prefix "Application"
    /// <summary>
    ///   <para>rdfs:label : Applikationsschnittstellerdfs:label : Application Interface</para>
    ///   <para>rdfs:comment : Technische Spezifikation einer Applikation, um Daten auszutauschenrdfs:comment : Technical specification of an application to exchange data</para>
    ///   <para>vann:example : ERP system's web-servicevann:example : Der Web-Service des ERP-Systems</para>
    ///   <a href="http://www.data-knowledge.org/dk/ApplicationInterface">dk:ApplicationInterface</a>
    /// </summary>
    let ApplicationInterface = _prefixId.prefix "ApplicationInterface"
    /// <summary>
    ///   <para>vann:example : test, production, deprecatedvann:example : Test, produktiv, abgekündigt</para>
    ///   <para>rdfs:comment : Defines the life cycle of Applications. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).rdfs:comment : Definiert den Lebenszyklus von Applikationen. Ein Lebenszyklus wird durch eine Menge von möglichen Lebenszyklusphasen (lifecycle:State) definiert. Die Lebenszyklusdefinition kann außerdem Einschränkungen der möglichen Übergange zwischen Lebenszyklusphasen spezifizieren (lifecycle:possibleTransition).</para>
    ///   <para>rdfs:label : Applikationslebenszyklusrdfs:label : Application Lifecycle</para>
    ///   <a href="http://www.data-knowledge.org/dk/ApplicationLifecycle">dk:ApplicationLifecycle</a>
    /// </summary>
    let ApplicationLifecycle = _prefixId.prefix "ApplicationLifecycle"
    /// <summary>
    ///   <para>rdfs:label : Attribute Mappingrdfs:label : Attribut-Zuordnung</para>
    ///   <para>rdfs:comment : Konzeptuelle Zuordnung von Geschäftsdefinitionen zu technischen Repräsentationen von Attributen.rdfs:comment : Conceptual mapping of business definitions to technical representations for attributes.</para>
    ///   <para>vann:example : The Business Object Type Attribute 'Customer name' is mapped to Data Object Type Attribute 'cust_nm' in the CRM system and DOTA 'company_name' in the ERP system.vann:example : Das Geschäftsobjekttyp-Attribut (BOTA) 'Kundenname' ist dem Datenobjekttyp-Attribut (DOTA) 'cust_nm' im CRM-System und dem DOTA 'company_name' im ERP-System zugeordnet.</para>
    ///   <a href="http://www.data-knowledge.org/dk/AttributeMapping">dk:AttributeMapping</a>
    /// </summary>
    let AttributeMapping = _prefixId.prefix "AttributeMapping"
    /// <summary>
    ///   <para>rdfs:label : Geschäftsobjekt (BO)rdfs:label : Business Object (BO)</para>
    ///   <para>rdfs:comment : Spezifische, individuelle Instanz eines Geschäftsobjekttyps (BOT)rdfs:comment : Specific, individual instance of a Business Object Type (BOT)</para>
    ///   <para>vann:example : Supplier 'Fluid Supply Ltd'vann:example : Lieferant 'Fluid Supply Ltd'</para>
    ///   <a href="http://www.data-knowledge.org/dk/BusinessObject">dk:BusinessObject</a>
    /// </summary>
    let BusinessObject = _prefixId.prefix "BusinessObject"
    /// <summary>
    ///   <para>rdfs:label : Geschäftsobjekt-Attribut (BOA)rdfs:label : Business Object Attribute (BOA)</para>
    ///   <para>rdfs:comment : Spezifische, individuelle Instanz eines Geschäftsobjekttyp-Attributs (BOTA)rdfs:comment : Specific, individual instance of a Business Object Type Attribute (BOTA)</para>
    ///   <para>vann:example : Tax ID 'DE-123456-789'vann:example : Steuer-ID 'DE-123456-789'</para>
    ///   <a href="http://www.data-knowledge.org/dk/BusinessObjectAttribute">dk:BusinessObjectAttribute</a>
    /// </summary>
    let BusinessObjectAttribute = _prefixId.prefix "BusinessObjectAttribute"
    /// <summary>
    ///   <para>rdfs:label : Geschäftsobjektdomäne (BOD)rdfs:label : Business Object Domain (BOD)</para>
    ///   <para>rdfs:comment : Clusters of coherent Business Object Types (BOTs), either from a subject matter or management point of viewrdfs:comment : Gruppierung kohärenter Geschäftsobjekttypen (BOTs), entweder aus Themen- oder Verwaltungssicht</para>
    ///   <para>vann:example : Business partner: customer and vendor datavann:example : Geschäftspartner: Kunden- und Verkäuferdaten</para>
    ///   <a href="http://www.data-knowledge.org/dk/BusinessObjectDomain">dk:BusinessObjectDomain</a>
    /// </summary>
    let BusinessObjectDomain = _prefixId.prefix "BusinessObjectDomain"
    /// <summary>
    ///   <para>rdfs:comment : Konzeptuelle, unternehmensrelevante (Daten-) Einheit, welche eine kohärente Menge von Informationen über eine Gruppe realer oder virtueller Objekte darstelltrdfs:comment : Conceptual (data) entity relevant to business that represents a coherent set of information about a group of real or virtual objects</para>
    ///   <para>rdfs:label : Geschäftsobjekttyp (BOT)rdfs:label : Business Object Type (BOT)</para>
    ///   <para>vann:example : Customer, Employee, Bill of Material, Sales Regionvann:example : Kunde, Angestellter, Materialliste, Vertriebsregion</para>
    ///   <a href="http://www.data-knowledge.org/dk/BusinessObjectType">dk:BusinessObjectType</a>
    /// </summary>
    let BusinessObjectType = _prefixId.prefix "BusinessObjectType"
    /// <summary>
    ///   <para>rdfs:comment : Konzeptuell elementare Informationseinheit als Teil eines Geschäftsobjekttyps (BOT)rdfs:comment : Conceptually elementary piece of information as part of a Business Object Type (BOT)</para>
    ///   <para>vann:example : Tax ID, Addressvann:example : Steuer-ID, Adresse</para>
    ///   <para>rdfs:label : Business Object Type Attribute (BOTA)rdfs:label : Geschäftsobjekttyp-Attribut (BOTA)</para>
    ///   <a href="http://www.data-knowledge.org/dk/BusinessObjectTypeAttribute">dk:BusinessObjectTypeAttribute</a>
    /// </summary>
    let BusinessObjectTypeAttribute = _prefixId.prefix "BusinessObjectTypeAttribute"
    /// <summary>
    ///   <para>rdfs:label : Geschäftsprozessrdfs:label : Business Process</para>
    ///   <para>rdfs:comment : Sequence of activities consuming or relying on data (data usage perspective)rdfs:comment : Abfolge von Tätigkeiten, die Daten konsumieren oder von ihnen abhängen (Datennutzungsperspektive)</para>
    ///   <para>vann:example : Ordering, delivering, invoicingvann:example : Bestellung, Auslieferung, Rechnungsstellung</para>
    ///   <a href="http://www.data-knowledge.org/dk/BusinessProcess">dk:BusinessProcess</a>
    /// </summary>
    let BusinessProcess = _prefixId.prefix "BusinessProcess"
    /// <summary>
    ///   <para>rdfs:label : Geschäftsregelrdfs:label : Business Rule</para>
    ///   <para>rdfs:comment : Legt die Integrität eines einzelnen Geschäftsobjekts oder zwischen Geschäftsobjekten festrdfs:comment : Defines the integrity of a single Business Object or across them</para>
    ///   <para>vann:example : Tax ID must be providedvann:example : Steuer-ID muss vorhanden sein</para>
    ///   <a href="http://www.data-knowledge.org/dk/BusinessRule">dk:BusinessRule</a>
    /// </summary>
    let BusinessRule = _prefixId.prefix "BusinessRule"
    /// <summary>
    ///   <para>rdfs:label : Geschäftsregelauswertungrdfs:label : Business Rule Assessment</para>
    ///   <para>rdfs:comment : Repräsentiert die Auswertung einer bestimmten Geschäftsregel auf der Grundlage eines konkreten Datengutesrdfs:comment : Represents the evaluation of a certain Business Rule on a specific Data Asset</para>
    ///   <para>vann:example : foo-at-bar.com ist keine gültige E-Mail-Adresse.vann:example : foo-at-bar.com is not a valid email address.vann:example : The sum of open purchases from customer X does not exceed his credit line.vann:example : Die Summe der ausstehenden Bestellungen für Kunde X übersteigt seine Kreditlinie nicht.</para>
    ///   <a href="http://www.data-knowledge.org/dk/BusinessRuleAssessment">dk:BusinessRuleAssessment</a>
    /// </summary>
    let BusinessRuleAssessment = _prefixId.prefix "BusinessRuleAssessment"
    /// <summary>
    ///   <para>rdfs:label : Änderungshistorierdfs:label : Change History</para>
    ///   <para>rdfs:comment : Informationen, welche es erlauben, die Entwicklung von Datendefinitionen, Prozessen, etc. nachzuverfolgenrdfs:comment : Information that allows to track the development of data definitions, processes, etc.</para>
    ///   <para>vann:example : Field 'age' added to customervann:example : Feld 'Alter' zu Kunde hinzugefügt</para>
    ///   <a href="http://www.data-knowledge.org/dk/ChangeHistory">dk:ChangeHistory</a>
    /// </summary>
    let ChangeHistory = _prefixId.prefix "ChangeHistory"
    /// <summary>
    ///   <para>rdfs:label : Änderungsanfragerdfs:label : Change Request</para>
    ///   <para>rdfs:comment : Detaillierte Beschreibung eines spezifischen Änderungsbedarfs, welcher sich aus Projekten oder dem operativen Ablauf ergibtrdfs:comment : Detailed description of a specific change requirement, resulting from projects or operations</para>
    ///   <para>vann:example : Feld 'Alter' zu Geschäftsobjekttyp 'Kunde' hinzufügenvann:example : Add field 'age' to Business Object Type 'customer'</para>
    ///   <a href="http://www.data-knowledge.org/dk/ChangeRequest">dk:ChangeRequest</a>
    /// </summary>
    let ChangeRequest = _prefixId.prefix "ChangeRequest"
    /// <summary>
    ///   <para>rdfs:label : Coderdfs:label : Code</para>
    ///   <para>rdfs:comment : Vordefinierter Wert eines Geschäftsobjektattributs (BOTA)rdfs:comment : Pre-defined value for a Business Object Type Attribute (BOTA)</para>
    ///   <para>vann:example : DEvann:example : DE</para>
    ///   <a href="http://www.data-knowledge.org/dk/Code">dk:Code</a>
    /// </summary>
    let Code = _prefixId.prefix "Code"
    /// <summary>
    ///   <para>rdfs:label : Code-Listerdfs:label : Code List</para>
    ///   <para>rdfs:comment : Liste mit vordefinierten Werten (Code) für ein Geschäftsobjekt-Attribut (BOTA)rdfs:comment : List with pre-defined values (Codes) for a Business Object Type Attribute (BOTA)</para>
    ///   <para>vann:example : Incoterms, country codesvann:example : Incoterms, Ländercodes</para>
    ///   <a href="http://www.data-knowledge.org/dk/CodeList">dk:CodeList</a>
    /// </summary>
    let CodeList = _prefixId.prefix "CodeList"
    /// <summary>
    ///   <para>rdfs:label : Code-Zuordnungrdfs:label : Code Mapping</para>
    ///   <para>rdfs:comment : Konzeptuelle Zuordnung geschäftsbezogener Codes und Terminologie von Code-Listen zu benannten Werten von technischen Aufzählungen.rdfs:comment : Conceptual mapping of business-related codes and terminology of Code Lists to named values of technical Enumerations.</para>
    ///   <para>vann:example : Der Ländercode 'DEU' der Codeliste 'ISO 3166 Country Codes' wird zugeordnet zu Named Value 'ger' der Enumeration 'Länder des CRM Systems' und zu Named Value 'duitsland' der Enumeration 'Länder des niederländischen Abrechungssystems'vann:example : Country Code 'DEU' from Code List 'ISO 3166 Country Codes' is mapped to Named Value 'ger' of Enumeration 'CRM system countries' and Named Value 'duitsland' of Enumeration 'Dutch Accounting System countries'</para>
    ///   <a href="http://www.data-knowledge.org/dk/CodeMapping">dk:CodeMapping</a>
    /// </summary>
    let CodeMapping = _prefixId.prefix "CodeMapping"
    /// <summary>
    ///   <para>vann:example : The production schedules of German sites along with the bill of materials of the produced goods.vann:example : Die gesamten Kundenstammdaten eines bestimmten CRM-Systems oder Teile davon.vann:example : The entirety of customer master data from a particular CRM system or parts thereof.vann:example : Die Produktionspläne der Werke in Deutschland mit den Stücklisten der produzierten Güter.</para>
    ///   <para>rdfs:label : Datengutrdfs:label : Data Asset</para>
    ///   <para>rdfs:comment : Ein Datengut stellt eine Menge von Datenobjekten dar, die ein betriebliches oder geschäftliches Ziel unterstützen. Die enthaltenen Datenobjekte können vom dem selben oder unterschiedlichen Datenobjekttypen stammen.rdfs:comment : A Data Asset represents a collection of Data Objects serving an organizational or a business goal. The contained Data Objects may be of the same or of different Data Object Types.</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataAsset">dk:DataAsset</a>
    /// </summary>
    let DataAsset = _prefixId.prefix "DataAsset"
    /// <summary>
    ///   <para>rdfs:label : Daten-Konzeptualisierungrdfs:label : Data Conceptualization</para>
    ///   <para>rdfs:comment : Eine Daten-Konzeptualisierung repräsentiert ein fachliches Konzept, mit dem Daten spezifiziert oder strukturiert werden. Da es sich um eine abstrakte Super-Klasse handelt, sollten nur ihre Subklassen verwendet werden.rdfs:comment : A Data Conceptualization represents a business concept to specify and structure data. As this is an abstract superclass only its subclasses may be used.</para>
    ///   <para>vann:example : Eine Geschäftsobjektdomäne 'Material', ein Geschäftsobjekttyp 'Indirektes Material', ein Geschäftsobjekttyp-Attribut 'Materialnummer'vann:example : A Business Object Domain 'Material', a Business Object Type 'Indirect material', a business Object Type attribute 'Material number'</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataConceptualization">dk:DataConceptualization</a>
    /// </summary>
    let DataConceptualization = _prefixId.prefix "DataConceptualization"
    /// <summary>
    ///   <para>rdfs:label : Datenflussrdfs:label : Data Flow</para>
    ///   <para>rdfs:comment : Zeigt die tatsächliche Verbindung und den Datenaustausch zwischen konkreten Applikationen anrdfs:comment : Indicates the actual connection and data exchange between particular applications</para>
    ///   <para>vann:example : Datensatz2837 fließt vom zentralen Stammdatenspeicher zum ERP-Systemvann:example : Dataset2837 flows from Central master data repository to ERP system</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataFlow">dk:DataFlow</a>
    /// </summary>
    let DataFlow = _prefixId.prefix "DataFlow"
    /// <summary>
    ///   <para>rdfs:label : Data Lifecyclerdfs:label : Datenlebenszyklus</para>
    ///   <para>vann:example : Lebenszyklus von Produktstammdaten, spiegelt die Lebenszyklusphasen / -stadien des Produktes wieder: Entwicklung, Produktion, Aftermarket, Produktauslaufvann:example : Draft, active, inactivevann:example : Entwurf, aktiv, inaktivvann:example : Life cycle of product master data reflecting the product's life cycles phases / states: Development, Production, After market, Phased out</para>
    ///   <para>rdfs:comment : Definiert den Lebenszyklus von Geschäftsobjekten, Datenobjekten und Datengütern. Ein Lebenszyklus wird durch eine Menge möglicher Lebenszyklusphasen (lifecycle:State) definiert. Die Lebenszyklusdefinition kann außerdem Einschränkungen der möglichen Übergange zwischen Lebenszyklusphasen spezifizieren (lifecycle:possibleTransition).rdfs:comment : Defines the life cycle of Business Objects, Data Objects and Data Assets. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataLifecycle">dk:DataLifecycle</a>
    /// </summary>
    let DataLifecycle = _prefixId.prefix "DataLifecycle"
    /// <summary>
    ///   <para>rdfs:label : Datenmanagementprozessrdfs:label : Data Management Process</para>
    ///   <para>rdfs:comment : Sequence of activities for data maintenance or data governancerdfs:comment : Abfolge von Tätigkeiten für die Datenpflege oder die Daten-Governance</para>
    ///   <para>vann:example : Erstellung von Kundenstammdatenvann:example : Creation of customer master data</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataManagementProcess">dk:DataManagementProcess</a>
    /// </summary>
    let DataManagementProcess = _prefixId.prefix "DataManagementProcess"
    /// <summary>
    ///   <para>rdfs:comment : Individuelle Instanz eines Datenobjekttyps (DOT), d.h. die technische Repräsentation eines Geschäftsobjekts (BO)rdfs:comment : Individual record of a Data Object Type (DOT), i.e. the technical representation of a Business Object (BO)</para>
    ///   <para>vann:example : Database record of 'Fluid Supply Ltd'vann:example : Datenbankeintrag zu 'Fluid Supply Ltd'</para>
    ///   <para>rdfs:label : Data Object (DO)rdfs:label : Datenobjekt (DO)</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataObject">dk:DataObject</a>
    /// </summary>
    let DataObject = _prefixId.prefix "DataObject"
    /// <summary>
    ///   <para>rdfs:label : Datenobjektattribut (DOA)rdfs:label : Data Object Attribute (DOA)</para>
    ///   <para>rdfs:comment : Eine Informationseinheit, welche Bestandteil eines Datenobjekts (DO) ist, d.h. die technische Repräsentation eines Geschäftsobjektattributs (BOA)rdfs:comment : A piece of information being a part of a Data Object (DO), i.e. the technical representation of a Business Object Attribute (BOA)</para>
    ///   <para>vann:example : 'DE-123456-789' being the value of database column 'stceg' of record 'Fluid Supply Ltd'vann:example : 'DE-123456-789' als Wert der Datenbankspalte 'stceg' des Datenbankeintrags 'Fluid Supply Ltd'</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataObjectAttribute">dk:DataObjectAttribute</a>
    /// </summary>
    let DataObjectAttribute = _prefixId.prefix "DataObjectAttribute"
    /// <summary>
    ///   <para>rdfs:label : Data Object Type (DOT)rdfs:label : Datenobjekttyp (DOT)</para>
    ///   <para>rdfs:comment : Technical representation of a Business Object Type (BOT)rdfs:comment : Technische Repräsentation eines Geschäftsobjekttyps (BOT)</para>
    ///   <para>vann:example : Datenbanktabelle 'kna1'vann:example : Database table 'kna1'</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataObjectType">dk:DataObjectType</a>
    /// </summary>
    let DataObjectType = _prefixId.prefix "DataObjectType"
    /// <summary>
    ///   <para>rdfs:label : Datenobjekttypattribut (DOTA)rdfs:label : Data Object Type Attribute (DOTA)</para>
    ///   <para>rdfs:comment : Individuelles (atomares) Feld, um eine Informationseineit zu speichernrdfs:comment : Individual (atomic) field to store a piece of information</para>
    ///   <para>vann:example : Datenbankspalte 'stceg'vann:example : Database column 'stceg'</para>
    ///   <a href="http://www.data-knowledge.org/dk/DataObjectTypeAttribute">dk:DataObjectTypeAttribute</a>
    /// </summary>
    let DataObjectTypeAttribute = _prefixId.prefix "DataObjectTypeAttribute"
    /// <summary>
    ///   <para>rdfs:label : Enumerationrdfs:label : Enumeration</para>
    ///   <para>rdfs:comment : Liste mit vordefinierten Werten (Benannter Wert) für ein Datenobjekttyp-Attribut (DOTA)rdfs:comment : List with pre-defined values (Named Values) for a Data Object Type Attribute (DOTA)</para>
    ///   <para>vann:example : Incoterms, country codesvann:example : Incoterms, Ländercodes</para>
    ///   <a href="http://www.data-knowledge.org/dk/Enumeration">dk:Enumeration</a>
    /// </summary>
    let Enumeration = _prefixId.prefix "Enumeration"
    /// <summary>
    ///   <para>rdfs:label : Examplerdfs:label : Beispiel</para>
    ///   <para>rdfs:comment : Instanzen eines BOT/BOTA, die gültige und ungültige Nutzung illustrierenrdfs:comment : Illustrative instances of a BOT/BOTA to indicate valid / invalid use</para>
    ///   <para>vann:example : Example for invalid legal form: 'Limtd'vann:example : Beispiel für ungültige Rechtsform: 'Limtd'</para>
    ///   <a href="http://www.data-knowledge.org/dk/Example">dk:Example</a>
    /// </summary>
    let Example = _prefixId.prefix "Example"
    /// <summary>
    ///   <para>rdfs:label : FAQrdfs:label : FAQ</para>
    ///   <para>rdfs:comment : Häufig gestellte Fragenrdfs:comment : Frequently Asked Questions</para>
    ///   <para>vann:example : What is master data?vann:example : Was sind Stammdaten?</para>
    ///   <a href="http://www.data-knowledge.org/dk/FAQ">dk:FAQ</a>
    /// </summary>
    let FAQ = _prefixId.prefix "FAQ"
    /// <summary>
    ///   <para>rdfs:label : Schlüssel-Zuordnungrdfs:label : Key Mapping</para>
    ///   <para>rdfs:comment : May be used to map data objects from different applications that represent the same business entity. This is useful for creation of 'golden records' and the distribution of data.rdfs:comment : Kann genutzt werden, um Datenobjekte verschiedener Applikationen zuzuordnen, die die selbe Geschäftsentität repräsentieren. Dies kann bei der Erstellung von 'Golden Records' und der Datenverteilung nützlich sein.</para>
    ///   <para>vann:example : Kunde 'Acme Ltd.' wird durch ein Geschäftsobjekt (BO) mit der ID = 1234 repräsentiert. Der selbe Kunde ist im CRM-System als Datenobjekt (DO) mit der ID = A324-4535 abgelegt, als weiteres DO im Buchhaltungssystem mit der ID = 3534646 und als weiteres DO im ERP-System mit der ID = acemeltdvann:example : Customer 'Acme Ltd.' is represented by a Business Object with ID = 1234. This same customer is kept in the CRM system as a Data Object with ID = A324-4535, as another Data Object in the Accouting system with ID = 3534646 and as another Data Object in the ERP system with ID = acemeltd</para>
    ///   <a href="http://www.data-knowledge.org/dk/KeyMapping">dk:KeyMapping</a>
    /// </summary>
    let KeyMapping = _prefixId.prefix "KeyMapping"
    /// <summary>
    ///   <para>rdfs:label : Knowledge Lifecyclerdfs:label : Wissenslebenszyklus</para>
    ///   <para>vann:example : A life cycle for the Business Object Types and Business Object Type Attributes may define the workflow of data definitions by the life cycle states: Draft, Approved, Rejected, Withdrawn.vann:example : Ein Lebenszyklus für die Geschäftsobjekttypen und Geschäftsobjekttyp-Attribute kann den Workflow von Datendefinitionen mithilfe der Lebenszyklusphasen dafinieren: Entwurf, Bestätigt, Abgewiesen, Zurückgezogen.</para>
    ///   <para>rdfs:comment : Definiert den Lebenszyklus einer Datenwissen-Entität, d.h. der Instanzen der Klassen dieses Modells. Diese Art von Lebenszyklus repräsentiert daher einen Metadatenlebenszyklus. Ein Lebenszyklus wird durch eine Menge möglicher Lebenszyklusphasen (lifecycle:State) definiert. Die Lebenszyklusdefinition kann außerdem Einschränkungen der möglichen Übergange zwischen Lebenszyklusphasen spezifizieren (lifecycle:possibleTransition).rdfs:comment : Defines the life cycle of a data knowledge entity, i.e. the instances from the classes of this model. This type of life cycles thus represents a metadata life cycle. A life cycle is defined by a set of possible life cycle states (lifecycle:State). The life cycle definition may also specify constraints on the transitions between the life cycle states (lifecycle:possibleTransition).</para>
    ///   <a href="http://www.data-knowledge.org/dk/KnowledgeLifecycle">dk:KnowledgeLifecycle</a>
    /// </summary>
    let KnowledgeLifecycle = _prefixId.prefix "KnowledgeLifecycle"
    /// <summary>
    ///   <para>rdfs:label : KPI-Definitionrdfs:label : KPI Definition</para>
    ///   <para>rdfs:comment : Definiert eine Datenqualitäts-Leistungskennzahl basierend auf einer Menge von Geschäftsregelnrdfs:comment : Defines a data quality (performance) measure based on a set of business rules</para>
    ///   <para>vann:example : Number of customers without address or tax IDvann:example : Anzahl der Kunden ohne Adresse oder Steuer-ID</para>
    ///   <a href="http://www.data-knowledge.org/dk/KpiDefinition">dk:KpiDefinition</a>
    /// </summary>
    let KpiDefinition = _prefixId.prefix "KpiDefinition"
    /// <summary>
    ///   <para>rdfs:label : KPI-Messwertrdfs:label : KPI Measurement</para>
    ///   <para>rdfs:comment : Konkrete Leistungskennzahlen, zu einer bestimmten Zeit gemessenrdfs:comment : Actual performance values measured at a particular time</para>
    ///   <para>vann:example : 75% sind gültige Kundendatenvann:example : 75% are valid customer records</para>
    ///   <a href="http://www.data-knowledge.org/dk/KpiMeasurement">dk:KpiMeasurement</a>
    /// </summary>
    let KpiMeasurement = _prefixId.prefix "KpiMeasurement"
    /// <summary>
    ///   <para>rdfs:comment : Abstract class of different kinds of mappingsrdfs:comment : Abstrakte Klasse verschiedener Arten von Zuordnungen</para>
    ///   <para>rdfs:label : Zuordnungrdfs:label : Mapping</para>
    ///   <para>vann:example : Code-Zuordnungvann:example : Code Mapping</para>
    ///   <a href="http://www.data-knowledge.org/dk/Mapping">dk:Mapping</a>
    /// </summary>
    let Mapping = _prefixId.prefix "Mapping"
    /// <summary>
    ///   <para>rdfs:label : Named Valuerdfs:label : Benannter Wert</para>
    ///   <para>rdfs:comment : Vordefinierter Wert einer Enumeration eines Datenobjekttyp-Attribut (DOTA)rdfs:comment : Pre-defined value of an Enumeration for a Data Object Type Attribute (DOTA)</para>
    ///   <para>vann:example : DEvann:example : DE</para>
    ///   <a href="http://www.data-knowledge.org/dk/NamedValue">dk:NamedValue</a>
    /// </summary>
    let NamedValue = _prefixId.prefix "NamedValue"
    /// <summary>
    ///   <para>rdfs:comment : Unit of the organizational structure (hierarchy), group of individualsrdfs:comment : Einheit der Organisationsstruktur (Hierarchie), Gruppe von Individuen</para>
    ///   <para>rdfs:label : Organizational Unitrdfs:label : Organisationseinheit</para>
    ///   <para>vann:example : Abteilung Avann:example : department A</para>
    ///   <a href="http://www.data-knowledge.org/dk/OrganizationalUnit">dk:OrganizationalUnit</a>
    /// </summary>
    let OrganizationalUnit = _prefixId.prefix "OrganizationalUnit"
    /// <summary>
    ///   <para>rdfs:label : Personrdfs:label : Person</para>
    ///   <para>vann:example : Fr. Schmidt, Hr. Rehvann:example : Mrs. Smith, Mr. Doe</para>
    ///   <para>rdfs:comment : Individual of an organization assigned with certain rolesrdfs:comment : Individuum einer Organisation, welchem bestimmte Rollen zugewiesen werden</para>
    ///   <a href="http://www.data-knowledge.org/dk/Person">dk:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Projektrdfs:label : Project</para>
    ///   <para>vann:example : New distribution channelvann:example : Neuer Distributionskanal</para>
    ///   <para>rdfs:comment : Ein Projekt, welches Änderungen von Daten oder dem Datenmanagement zum Zweck hatrdfs:comment : A project that implies changes to data or data management</para>
    ///   <a href="http://www.data-knowledge.org/dk/Project">dk:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Projektplanrdfs:label : Project Plan</para>
    ///   <para>rdfs:comment : Zeitplan, der illustriert, wann eine bestimmte Maßnahme ergriffen wirdrdfs:comment : Schedule illustrating when a particular action is taken on something</para>
    ///   <para>vann:example : Rollout of process or applicationvann:example : Auslieferung eines Prozesses oder einer Anwendung</para>
    ///   <a href="http://www.data-knowledge.org/dk/ProjectPlan">dk:ProjectPlan</a>
    /// </summary>
    let ProjectPlan = _prefixId.prefix "ProjectPlan"
    /// <summary>
    ///   <para>rdfs:label : Vorschriftrdfs:label : Regulation</para>
    ///   <para>rdfs:comment : Interne oder externe Verordnung, die das Datenmanagement beeinflusstrdfs:comment : Internal or external regulatory driver influencing data management</para>
    ///   <para>vann:example : privacy policiesvann:example : Datenschutzrichtlinien</para>
    ///   <a href="http://www.data-knowledge.org/dk/Regulation">dk:Regulation</a>
    /// </summary>
    let Regulation = _prefixId.prefix "Regulation"
    /// <summary>
    ///   <para>rdfs:label : Reportrdfs:label : Bericht</para>
    ///   <para>rdfs:comment : Set of KPI measurements gathered for a particular purposerdfs:comment : Menge von KPI-Messwerten, welche für einen bestimmten Zweck zusammengetragen wurden</para>
    ///   <para>vann:example : Tabellenkalkulation mit Schaubildernvann:example : Spread sheet with charts</para>
    ///   <a href="http://www.data-knowledge.org/dk/Report">dk:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>vann:example : Hr. Reh ist der Datenqualitätsverantwortliche für Datensatz x-325, er ist zuständig im Falle dass ein Kunde unzufrieden mit der Qualität ist, verantwortlich vom 01.01.2016 bis zum 31.12.2016, hat Maßnahme X, Y und Z zu ergreifenvann:example : Mr. Doe is the data quality responsible of Dataset x-325, he is accountable in case a customer is unsatisfied with the quality, responsible from 01/01/2016 to 31/12/2016, has to take measure X, Y and Zvann:example : Leiter des Projekts 'Neuer Datendistributionskanal' ist bis 6 Monate nach Veröffentlichung für die Ergebnisse des Projekts verantwortlichvann:example : Manager of project 'new data distribution channel' is responsible for this project's results until 6 months after rollout</para>
    ///   <para>rdfs:label : Responsibilityrdfs:label : Verantwortlichkeit</para>
    ///   <para>rdfs:comment : Specific description of a responsibility, including the particular scope, duration of accountability, measures to be taken and further informationrdfs:comment : Genaue Beschreibung einer Verantwortlichkeit, inkl. ihres genauen Zuständigkeitsbereiches, der Dauer der Zuständigkeit, zu ergreifenden Maßnahmen und weiteren Informationen</para>
    ///   <a href="http://www.data-knowledge.org/dk/Responsibility">dk:Responsibility</a>
    /// </summary>
    let Responsibility = _prefixId.prefix "Responsibility"
    /// <summary>
    ///   <para>rdfs:label : Rollerdfs:label : Role</para>
    ///   <para>rdfs:comment : Abstrakte Definition einer allgemeinen Funktion und ihrer Ziele und Autoritätenrdfs:comment : Abstract definition of a general function and its goals and authorities</para>
    ///   <para>vann:example : Datenkoordinatorvann:example : Data coordinator</para>
    ///   <a href="http://www.data-knowledge.org/dk/Role">dk:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Schema-Zuordnungrdfs:label : Schema Mapping</para>
    ///   <para>rdfs:comment : Technische Zuordnung, welche Datenflüsse zwischen Applikationen spezifiziert.rdfs:comment : Technical mapping specifiying data flows between Applications.</para>
    ///   <para>vann:example : The DOTA 'ctxid' in the Accouting system maps to the DOTA 'cust_tax_id' in the CRM systemvann:example : Das DOTA 'ctxid' im Buchhaltungssystem ist dem DOTA 'cust_tax_id' im CRM-System zugeordnet</para>
    ///   <a href="http://www.data-knowledge.org/dk/SchemaMapping">dk:SchemaMapping</a>
    /// </summary>
    let SchemaMapping = _prefixId.prefix "SchemaMapping"
    /// <summary>
    ///   <para>rdfs:label : Supplementary Documentationrdfs:label : Ergänzende Dokumentation</para>
    ///   <para>rdfs:comment : Material to learn or use as a reference for data management operationsrdfs:comment : Lern- oder Referenzmaterial für Datenmanagementoperationen</para>
    ///   <para>vann:example : Konzepte, Präsentationen, Videosvann:example : Concepts, presentations, videos</para>
    ///   <a href="http://www.data-knowledge.org/dk/SupplementaryDocumentation">dk:SupplementaryDocumentation</a>
    /// </summary>
    let SupplementaryDocumentation = _prefixId.prefix "SupplementaryDocumentation"
    /// <summary>
    ///   <para>vann:example : Verbot, ein Datengut in ein bestimmtes Land zu transferieren oder dort zu bearbeitenvann:example : Recht, ein Datengut innerhalb der Organisation, die es gekauft hat, zu nutzen und zu teilenvann:example : Prohibition to transfer or process a data asset to/in a certain countryvann:example : Prohibition to (re-) sell a certain data assetvann:example : Permission to use and share a data asset within the company who purchased itvann:example : Verbot, ein Datengut (weiter-) zu verkaufen</para>
    ///   <para>rdfs:label : Terms of Userdfs:label : Nutzungsbedingungen</para>
    ///   <para>rdfs:comment : Terms of use specify the terms and conditions under which an Application or a Data Asset can or must be used.rdfs:comment : Die Nutzungsbedingungen geben an, unter welchen Bedinungen und Konditionen eine Applikation oder ein Datengut verwendet werden können oder müssen.</para>
    ///   <a href="http://www.data-knowledge.org/dk/TermsOfUse">dk:TermsOfUse</a>
    /// </summary>
    let TermsOfUse = _prefixId.prefix "TermsOfUse"
    /// <summary>
    ///   <para>rdfs:label : Trainingsmöglichkeitrdfs:label : Training Opportunity</para>
    ///   <para>rdfs:comment : Eine geplante Veranstaltung, an der eine Person teilnehmen kannrdfs:comment : A planned event a person can participate in</para>
    ///   <para>vann:example : web-based training sessionvann:example : Web-basierte Übungssitzung</para>
    ///   <a href="http://www.data-knowledge.org/dk/TrainingOpportunity">dk:TrainingOpportunity</a>
    /// </summary>
    let TrainingOpportunity = _prefixId.prefix "TrainingOpportunity"
    /// <summary>
    ///   <para>rdfs:label : Type Mappingrdfs:label : Typ-Zuordnung</para>
    ///   <para>rdfs:comment : Konzeptuelle Zuordnung von Geschäftsdefinitionen zu technischen Repräsentationen von Objekten.rdfs:comment : Conceptual mapping of business definitions to technical representations for objects.</para>
    ///   <para>vann:example : Zuordnungsklasse 'GlobaleStammdatenMapping' verbindet DOT 'MstrDat8' und BOT 'Globale Stammdaten' mit angefügten Nutzungskommentaren und Dokumentationvann:example : Mapping class 'GlobalMasterDataMapping' connects DOT 'MstrDat8' and BOT 'Global Master Data' with usage comments and documentation added</para>
    ///   <a href="http://www.data-knowledge.org/dk/TypeMapping">dk:TypeMapping</a>
    /// </summary>
    let TypeMapping = _prefixId.prefix "TypeMapping"
    /// <summary>
    ///   <para>vann:example : Änderungsanfrage 'füge Feld 'Alter' zu Kunde hinzu' betrifft BOT 'Kunde'vann:example : Change Request 'add field 'age' to customer' affects BOT 'Customer'</para>
    ///   <para>rdfs:comment : Eine Änderungsanfrage betrifft einen Geschäftsobjekttypen (BOT)rdfs:comment : A Change Requests affects a Business Object Type or an Application</para>
    ///   <para>rdfs:label : betrifftrdfs:label : affects</para>
    ///   <a href="http://www.data-knowledge.org/dk/affects">dk:affects</a>
    /// </summary>
    let affects = _prefixId.prefix "affects"
    /// <summary>
    ///   <para>vann:example : How much improvisation in data management processes is allowed?vann:example : What is a training opportunity?vann:example : Wo finde ich Hr. Reh?vann:example : What is Master Data?vann:example : Was ist ein Dateneigentümer?vann:example : What is a Data Owner?vann:example : Was ist eine Trainingsmöglichkeit?vann:example : Where do I find Mr. Doe?vann:example : Wie viel Improvisation ist in Datenmanagementprozessen erlaubt?vann:example : Was versteht man unter Stammdaten?</para>
    ///   <para>rdfs:label : answers question aboutrdfs:label : beantwortet Fragen zu</para>
    ///   <para>rdfs:comment : FAQ answer questions about various model areasrdfs:comment : FAQ beantworten Fragen zu verschiedenen Modellbereichen</para>
    ///   <a href="http://www.data-knowledge.org/dk/answersQuestionAbout">dk:answersQuestionAbout</a>
    /// </summary>
    let answersQuestionAbout = _prefixId.prefix "answersQuestionAbout"
    /// <summary>
    ///   <para>vann:example : Safety at work when executing specific tasksvann:example : Shipping regulations concerning BOT 'customer' with non-EU addressvann:example : Arbeitssicherheit bei der Ausführung bestimmter Tätigkeitenvann:example : Interne Vorschriften bzgl. des Berichts-Designsvann:example : Versandvorschriften bezüglich BOT 'Kunde' mit Adresse außerhalb der EUvann:example : Internal regulations on Report design</para>
    ///   <para>rdfs:label : applies tordfs:label : gilt für</para>
    ///   <para>rdfs:comment : Vorschriften können für alle Arten von Instanzen geltenrdfs:comment : Regulations can apply to all kinds of instances</para>
    ///   <a href="http://www.data-knowledge.org/dk/appliesTo">dk:appliesTo</a>
    /// </summary>
    let appliesTo = _prefixId.prefix "appliesTo"
    /// <summary>
    ///   <para>vann:example : BO A ist verknüpft mit BO Bvann:example : BO A is linked with BO B</para>
    ///   <para>rdfs:label : ist verknüpft mitrdfs:label : associates with</para>
    ///   <para>rdfs:comment : unspecified association between entitiesrdfs:comment : unspezifische Verknüpfung zwischen Entitäten</para>
    ///   <a href="http://www.data-knowledge.org/dk/associatesWith">dk:associatesWith</a>
    /// </summary>
    let associatesWith = _prefixId.prefix "associatesWith"
    /// <summary>
    ///   <para>rdfs:comment : A KPI Definition is based on a Business Rule (BR)rdfs:comment : Die Definition einer Leistungskennzahl (KPI Definition) basier auf einer Geschäftsregel (BR).</para>
    ///   <para>vann:example : KPI-Definition: 'Anzahl von Kunden ohne Steuer-ID' basiert auf BR: 'Steuer-ID muss vorhanden sein'vann:example : KPI Definition: 'Number of customers without tax ID' is based on BR: 'Tax ID must be provided'</para>
    ///   <para>rdfs:label : basiert aufrdfs:label : based on</para>
    ///   <a href="http://www.data-knowledge.org/dk/basedOn">dk:basedOn</a>
    /// </summary>
    let basedOn = _prefixId.prefix "basedOn"
    /// <summary>
    ///   <para>rdfs:label : trägtrdfs:label : carries</para>
    ///   <para>rdfs:comment : Roles and Organizational Units can carry specific responsibilitesrdfs:comment : Rollen und Organisationseinheiten können spezifische Verantwortungen tragen</para>
    ///   <para>vann:example : Data manager for procurement carries responsibility 'ProcurementDataResponsibility' which refers to BOT 'supplier' and BOT 'procurement order'vann:example : Datenmanager für Beschaffung trägt u.a. die Verantwortlichkeit 'BeschaffungsDatenVerantwortung' welche auf BOT 'Lieferant' und BOT 'Beschaffungsauftrag' verweist</para>
    ///   <a href="http://www.data-knowledge.org/dk/carries">dk:carries</a>
    /// </summary>
    let carries = _prefixId.prefix "carries"
    /// <summary>
    ///   <para>rdfs:comment : A Report comprises certain KPI Measurements and their definitionsrdfs:comment : Ein Bericht umfasst gewisse Leistungskennzahlen (KPIs) und ihre Definitionen</para>
    ///   <para>rdfs:label : beinhaltetrdfs:label : comprises</para>
    ///   <para>vann:example : Tabellenkalkulation mit Schaubildern, die verschiedene Qualitätsaspekte von Kundendaten zeigenvann:example : Spread sheet with charts showing various quality aspects of customer data</para>
    ///   <a href="http://www.data-knowledge.org/dk/comprises">dk:comprises</a>
    /// </summary>
    let comprises = _prefixId.prefix "comprises"
    /// <summary>
    ///   <para>vann:example : KPI '75% of customer data is complete' is computed on the data asset comprising DOs 'customer 1', 'customer 2' and 'customer 3'vann:example : KPI '75% der Kundendaten sind vollständig' wird berechnet für das Datengut mit den DOs 'Kunde 1', 'Kunde 2' und 'Kunde 3'</para>
    ///   <para>rdfs:label : berechnet fürrdfs:label : computed on</para>
    ///   <para>rdfs:comment : Eine Leistungskennzahl (KPI) und eine Geschäftsregelauswertung wird für ein Datengut berechnetrdfs:comment : A KPI Measurement and Business Rule Assessments is computed on a Data Asset</para>
    ///   <a href="http://www.data-knowledge.org/dk/computedOn">dk:computedOn</a>
    /// </summary>
    let computedOn = _prefixId.prefix "computedOn"
    /// <summary>
    ///   <para>rdfs:label : kooperiert mitrdfs:label : cooperates with</para>
    ///   <para>rdfs:comment : Organizational Units and Roles can cooperaterdfs:comment : Organisationseinheiten und Rollen können kooperieren</para>
    ///   <para>vann:example : Privacy manager cooperates with global data ownervann:example : Datenschutzmanager kooperiert mit globalem Dateneigentümer</para>
    ///   <a href="http://www.data-knowledge.org/dk/cooperatesWith">dk:cooperatesWith</a>
    /// </summary>
    let cooperatesWith = _prefixId.prefix "cooperatesWith"
    /// <summary>
    ///   <para>rdfs:comment : A Business Rule (BR) defines the integrity of Business Objects (BOs), Business Object Types (BOTs) and Business Object Attributes (BOAs)rdfs:comment : Eine Geschäftsregel (BR) definiert die Integrität von Geschäftsobjekten (BOs), Geschäftsobjekttypen (BOTs) und Geschäftsobjekt-Attributen (BOAs)</para>
    ///   <para>rdfs:label : definiert die Integrität vonrdfs:label : defines integrity of</para>
    ///   <para>vann:example : BR: 'Steuer-ID muss vorhanden sein' definiert die Integrität von BOs des Typs 'Kunde'vann:example : BR: 'Tax ID must be provided' defines the integrity of BOs of Type 'customer'</para>
    ///   <a href="http://www.data-knowledge.org/dk/definesIntegrityOf">dk:definesIntegrityOf</a>
    /// </summary>
    let definesIntegrityOf = _prefixId.prefix "definesIntegrityOf"
    /// <summary>
    ///   <para>rdfs:comment : Spezifiziert den Lebenszyklus der Geschäftsobjektinstanzen auf der konzeptuellen Typebene. Der aktuelle Lebenszyklusstatus eines individuellen Geschäftsobjekts wird von jedem Geschäftsobjekt über die Relation lifecycle:state referenziert.rdfs:comment : Specifies the life cycle of the Business Object instances on the conceptual type level. The current life cycle state of an individual Business Object is referred to from each Business Object via the property lifecycle:state.</para>
    ///   <para>vann:example : Der Lebenszyklus von Geschäftsobjeten des BOT 'Sendung' ist definiert durch den Sendsungslebenszyklus: 'Sendungsdaten erfasst','Bearbeitet im Start-Paketzentrum', 'Bearbeitet im Ziel-Paketzentrum', 'ausgeliefert'vann:example : The life cycle of Business Objects of BOT 'Shipment' is defined by the Shipment Life Cycle: 'Shipment data collected', 'Handled at start parcel center', 'Handled at destination parcel center', 'Delivered'</para>
    ///   <para>rdfs:label : definiert den Lebenszyklus von Instanzenrdfs:label : defines lifecycle of instances</para>
    ///   <a href="http://www.data-knowledge.org/dk/definesLifecycleOfInstances">dk:definesLifecycleOfInstances</a>
    /// </summary>
    let definesLifecycleOfInstances = _prefixId.prefix "definesLifecycleOfInstances"
    /// <summary>
    ///   <para>vann:example : Video about how to initiate a projectvann:example : Wiki-Seite mit Best Practicesvann:example : Graphische Repräsentation von Datenflüssenvann:example : Graphic representation of data flowsvann:example : Video darüber, wie man ein neues Projekt beginntvann:example : Wiki-Page with best practicesvann:example : Präsentationen von vergangenen Trainingsvann:example : Presentations of past trainings</para>
    ///   <para>rdfs:comment : Ergänzende Dokumentation dokumentiert verschiedene Modellbereicherdfs:comment : Supplementary documentation documents various model areas</para>
    ///   <para>rdfs:label : documentsrdfs:label : dokumentiert</para>
    ///   <a href="http://www.data-knowledge.org/dk/documents">dk:documents</a>
    /// </summary>
    let documents = _prefixId.prefix "documents"
    /// <summary>
    ///   <para>vann:example : Master data repository sends out dataset 324vann:example : Stammdatenspeicher sendet Datensatz 324</para>
    ///   <para>rdfs:comment : Interface A sends datardfs:comment : Schnittstelle A sendet Daten</para>
    ///   <para>rdfs:label : fließt vonrdfs:label : flows from</para>
    ///   <a href="http://www.data-knowledge.org/dk/flowsFrom">dk:flowsFrom</a>
    /// </summary>
    let flowsFrom = _prefixId.prefix "flowsFrom"
    /// <summary>
    ///   <para>rdfs:label : fließt anrdfs:label : flows to</para>
    ///   <para>rdfs:comment : Daten werden zu Schnittstelle B gesendetrdfs:comment : Data is sent to Interface B</para>
    ///   <para>vann:example : Datensatz 324 wird an ERP-System gesendetvann:example : Dataset 324 is sent to ERP system</para>
    ///   <a href="http://www.data-knowledge.org/dk/flowsTo">dk:flowsTo</a>
    /// </summary>
    let flowsTo = _prefixId.prefix "flowsTo"
    /// <summary>
    ///   <para>rdfs:label : has application lifecyclerdfs:label : hat Applikationslebenszyklus</para>
    ///   <para>vann:example : The CRM system is managed according to the 'Default Application Lifecycle': test, production, deprecatedvann:example : Das CRM-System wird entsprechend des 'Default Application Lifecycle' verwaltet: Test, produktiv, abgekündigt</para>
    ///   <para>rdfs:comment : Spezifiziert den Lebenszyklus einer individuellen Applikation. Der aktuelle Lebenszyklusstatus der Instanz wird über die Relation lifecycle:state zugewiesen.rdfs:comment : Specifies the life cycle of an individual Application instance. The current life cycle state of the instance is referred to via the property lifecycle:state.</para>
    ///   <a href="http://www.data-knowledge.org/dk/hasApplicationLifecycle">dk:hasApplicationLifecycle</a>
    /// </summary>
    let hasApplicationLifecycle = _prefixId.prefix "hasApplicationLifecycle"
    /// <summary>
    ///   <para>rdfs:label : has data lifecyclerdfs:label : hat Datenlebenszyklus</para>
    ///   <para>rdfs:comment : Spezifiziert den Lebenszyklus einer individuellen Instanz eines Geschäftsobjekts, Datenobjekts oder Datenguts. Diese Relation kann genutzt werden, um die generelle Typebenen-Definition des Lebenszyklus, welche durch definesLifecycleOfInstances ausgedrückt wird, zu überschreiben. Der aktuelle Lebenszyklusstatus der Instanz wird über die Relation lifecycle:state zugewiesen.rdfs:comment : Specifies the life cycle of an individual instance of a Business Object, Data Object or Data Asset. This property can be used to override the general type level life cycle definition expressed by definesLifecycleOfInstances. The current life cycle state of the instance is referred to via the property lifecycle:state</para>
    ///   <para>vann:example : Das konkrete Sendungs-Geschäftsobject mit NVE = 12345678 hat einen abweichenden Lebenszyklus, als den durch den Geschäftsobjekttyp definierten. Es handelt sich den 'Lebenszyklus für hochwertige Sendungen', der zusätzliche Lebenszyklusphasen enthält.vann:example : A specific 'Shipment' Business Object with SSCC = 12345678 has a differing life cycle than defined by the Business Object Type 'Shipment'. It is the 'High value shipment life cycle' including additional life cycle phases.</para>
    ///   <a href="http://www.data-knowledge.org/dk/hasDataLifecycle">dk:hasDataLifecycle</a>
    /// </summary>
    let hasDataLifecycle = _prefixId.prefix "hasDataLifecycle"
    /// <summary>
    ///   <para>vann:example : Ein genereller Wissenslebenszyklus hätte kein spezifisches Bezugsobjekt, d.h. er würde alle Ressourcen in diesem Namespace betreffen.vann:example : Ein Lebenszyklus für Datendefinitionen hätte eine Geschäftsobjektdomäne, einen Geschäftsobjekttypen oder Geschäftsobjekttyp-Attribute als Bezugsobjekte der Relation.vann:example : A lifecycle for data definitions would have a Business Object Domain, Business Object Type or Business Object Type Attribute as the property's subject.vann:example : A general knowledge life cycle would not have a specific subject, i.e. apply to all resources in this namespace.</para>
    ///   <para>rdfs:label : hat Wissenslebenszyklusrdfs:label : has Knowledge Lifecycle</para>
    ///   <para>rdfs:comment : May be used to define a general life cycle that applies to all classes of the model or certain classes.rdfs:comment : Kann genutzt werden, um einen allgemeinen Lebenszyklus, der auf alle Klassen des Modells oder nur auf spezielle Klassen zutrifft, zu definieren.</para>
    ///   <a href="http://www.data-knowledge.org/dk/hasKnowledgeLifecycle">dk:hasKnowledgeLifecycle</a>
    /// </summary>
    let hasKnowledgeLifecycle = _prefixId.prefix "hasKnowledgeLifecycle"
    /// <summary>
    ///   <para>rdfs:label : has Terms of Userdfs:label : hat Nutzungsbedingungen</para>
    ///   <para>vann:example : Duty to encrypt a stored data asset by using AES-256 or strongervann:example : Pflicht, ein Datengut ausschließlich verschlüsselt durch AES-256 oder stärker zu speichern</para>
    ///   <para>rdfs:comment : Resources can have specific Terms of Userdfs:comment : Ressourcen können spezifische Nutzungsbedingungen haben</para>
    ///   <a href="http://www.data-knowledge.org/dk/hasTerms">dk:hasTerms</a>
    /// </summary>
    let hasTerms = _prefixId.prefix "hasTerms"
    /// <summary>
    ///   <para>rdfs:comment : Ein Beispiel illustriert ein BOT/Ardfs:comment : An example illustrates a BOT/A</para>
    ///   <para>vann:example : Beispiel 'DE' für BOTA 'Land' verdeutlicht die korrekte Nutzung des BOTAsvann:example : Example 'DE' for BOTA 'country' indicates correct use of BOTA</para>
    ///   <para>rdfs:label : illustratesrdfs:label : illustriert</para>
    ///   <a href="http://www.data-knowledge.org/dk/illustrates">dk:illustrates</a>
    /// </summary>
    let illustrates = _prefixId.prefix "illustrates"
    /// <summary>
    ///   <para>rdfs:label : initiiertrdfs:label : initiates</para>
    ///   <para>vann:example : Projekt 'Verbesserung der Datendistribution' stellt Änderungsanfrage 'Füge neuen Distributionskanal X hinzu'vann:example : Project 'Improvement of data distribution' makes change request 'Add new distribution channel X'</para>
    ///   <para>rdfs:comment : Ein Projekt oder ein Datenmanagementprozess initiiert eine Änderungsanfragerdfs:comment : A project or a Data Management Process initiates a change request</para>
    ///   <a href="http://www.data-knowledge.org/dk/initiates">dk:initiates</a>
    /// </summary>
    let initiates = _prefixId.prefix "initiates"
    /// <summary>
    ///   <para>rdfs:label : is measurement ofrdfs:label : ist ein Messwert von</para>
    ///   <para>vann:example : The KPI Measurement '75% are valid customer records' is a measure resulting from the KPI Definition: 'Ratio of customers with address and tax ID to total number of customers'vann:example : Die KPI '75% sind valide Kundendaten' ist ein Messwert, der sich aus KPI-Definition: 'Anteil der Kunden mit Adresse und Steuer-ID an der Gesamtzahl der Kunden' ergibt</para>
    ///   <para>rdfs:comment : Eine Leistungskennzahl (KPI)wird anhand einer Leistungskennzahlen-Definition (KPI-Definition) für ein bestimmtes Datengut zu einer bestimmten Zeit berechnet. In gleicher Weise ergibt sich eine Geschäftsregelauswertung aus einer Geschäftsregel rdfs:comment : A KPI Measurement is computed according to a KPI Definition on a given data asset at a given time. Similarly, a Business Rule Assessment results from a Business Rule</para>
    ///   <a href="http://www.data-knowledge.org/dk/isMeasurementOf">dk:isMeasurementOf</a>
    /// </summary>
    let isMeasurementOf = _prefixId.prefix "isMeasurementOf"
    /// <summary>
    ///   <para>rdfs:comment : Spezifische Datenmanagementprozesse pflegen spezifische BO/T/As oder BODsrdfs:comment : Specific Data Management Processes maintain specific BO/T/As or BODs</para>
    ///   <para>vann:example : 'Customer data consistency management, group 4' maintains consistency between BOs 'customer A', 'customer B' and 'customer C'vann:example : 'Kundendatenkonsistenzmanagement, Gruppe 4' pflegt die Konsistenz zwischen den BOs 'Kunde A', 'Kunde B' und 'Kunde C'</para>
    ///   <para>rdfs:label : maintainsrdfs:label : pflegt</para>
    ///   <a href="http://www.data-knowledge.org/dk/maintains">dk:maintains</a>
    /// </summary>
    let maintains = _prefixId.prefix "maintains"
    /// <summary>
    ///   <para>rdfs:comment : Eine spezifische Zuordnungs-Klasse (Mapping) weist verschiedene Repräsentationen des selben Konzeptes zu, dh. hinsichtlich einer konzeptuellen ggü. einer technischen Sicht (möglicherweise in verschiedenen Datenformaten, z.B. Java oder XML-Objekte).
    ///  Code Mappings ordnen zu von Code zu NamedValue ;
    ///  Type Mappings ordnen zu von BusinessObjectType zu DataObjectType ;
    ///  Attribute Mappings ordnen zu von BusinessObjectTypeAttribute zu DataObjectTypeAttribute ;
    ///  Schema Mappings ordnen zu von DataObjectTypeAttribute zu DataObjectTypeAttribute ;
    ///  Key Mappings ordnen zu von Business zu DataObjectrdfs:comment : A specific Mapping Class assigns various representations of the same concepts, i.e in a conceptual vs. technical view (possibly in different data formats, e.g. Java or XML objects).
    ///  Code Mappings map from Code to NamedValue ;
    ///  Type Mappings map from BusinessObjectType to DataObjectType ;
    ///  Attribute Mappings map from BusinessObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Schema Mappings map from DataObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Key Mappings map from Business to DataObject</para>
    ///   <para>rdfs:label : ordnet zu vonrdfs:label : maps from</para>
    ///   <para>vann:example : Mapping class 'GlobalMasterDataMapping' maps from DOT 'MstrDat8' and maps to BOT 'Global Master Data' with usage comments and documentation addedvann:example : Zuordnungsklasse 'GlobaleStammdatenMapping' ordnet zu von DOT 'MstrDat8' und ordnet zu zu BOT 'Globale Stammdaten' mit angefügten Nutzungskommentaren und Dokumentation zu</para>
    ///   <a href="http://www.data-knowledge.org/dk/mapsFrom">dk:mapsFrom</a>
    /// </summary>
    let mapsFrom = _prefixId.prefix "mapsFrom"
    /// <summary>
    ///   <para>rdfs:label : maps tordfs:label : ordnet zu zu</para>
    ///   <para>rdfs:comment : Eine spezifische Zuordnungs-Klasse (Mapping) weist verschiedene Repräsentationen des selben Konzeptes zu, dh. hinsichtlich einer konzeptuellen ggü. einer technischen Sicht (möglicherweise in verschiedenen Datenformaten, z.B. Java oder XML-Objekte).
    ///  Code Mappings ordnen zu von Code zu NamedValue ;
    ///  Type Mappings ordnen zu von BusinessObjectType zu DataObjectType ;
    ///  Attribute Mappings ordnen zu von BusinessObjectTypeAttribute zu DataObjectTypeAttribute ;
    ///  Schema Mappings ordnen zu von DataObjectTypeAttribute zu DataObjectTypeAttribute ;
    ///  Key Mappings ordnen zu von Business zu DataObjectrdfs:comment : A specific Mapping Class assigns various representations of the same concepts, i.e in a conceptual vs. technical view (possibly in different data formats, e.g. Java or XML objects).
    ///  Code Mappings map from Code to NamedValue ;
    ///  Type Mappings map from BusinessObjectType to DataObjectType ;
    ///  Attribute Mappings map from BusinessObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Schema Mappings map from DataObjectTypeAttribute to DataObjectTypeAttribute ;
    ///  Key Mappings map from Business to DataObject</para>
    ///   <para>vann:example : Mapping class 'GlobalMasterDataMapping' maps from DOT 'MstrDat8' and maps to BOT 'Global Master Data' with usage comments and documentation addedvann:example : Zuordnungsklasse 'GlobaleStammdatenMapping' ordnet zu von DOT 'MstrDat8' und ordnet zu zu BOT 'Globale Stammdaten' mit angefügten Nutzungskommentaren und Dokumentation zu</para>
    ///   <a href="http://www.data-knowledge.org/dk/mapsTo">dk:mapsTo</a>
    /// </summary>
    let mapsTo = _prefixId.prefix "mapsTo"
    /// <summary>
    ///   <para>rdfs:comment : Eine Person oder Organisationseinheit kann an Training teilnehmenrdfs:comment : A person or organizational unit can participate in trainings</para>
    ///   <para>vann:example : Mr.Doe attends a web-based training session on the business effects of poor data qualityvann:example : Hr. Reh nimmt an einer web-basierten Trainingssitzung zu den geschäftlichen Konsequenzen von schlechter Datenqualität teil</para>
    ///   <para>rdfs:label : participates inrdfs:label : nimmt Teil an</para>
    ///   <a href="http://www.data-knowledge.org/dk/participatesIn">dk:participatesIn</a>
    /// </summary>
    let participatesIn = _prefixId.prefix "participatesIn"
    /// <summary>
    ///   <para>rdfs:label : processesrdfs:label : verarbeitet</para>
    ///   <para>vann:example : CR 'zusätzliches Feld für zusammenhängende BOs' wird von DM Prozess 'Feldänderung' verarbeitetvann:example : CR 'additional field for related BOs' is processed by DM Process 'Field change'</para>
    ///   <para>rdfs:comment : Änderungsanfragen (CRs) werden von Datenmanagementprozessen verarbeitetrdfs:comment : Change requests are processed by DM processes</para>
    ///   <a href="http://www.data-knowledge.org/dk/processes">dk:processes</a>
    /// </summary>
    let processes = _prefixId.prefix "processes"
    /// <summary>
    ///   <para>rdfs:comment : A reference from a BOTA to a Code List or from a DOTA to an Enumerationrdfs:comment : Ein Verweis von einem BOTA zu einer Code-Liste oder von einem DOTA zu einem Aufzählungstyp</para>
    ///   <para>vann:example : BOTA 'Land' verweist auf eine fixe Code-Liste von Ländercodesvann:example : BOTA 'country' refers to fixed Code List of country codes</para>
    ///   <para>rdfs:label : verweist aufrdfs:label : refers to</para>
    ///   <a href="http://www.data-knowledge.org/dk/refersTo">dk:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:label : representsrdfs:label : repräsentiert</para>
    ///   <para>rdfs:comment : Verknüpfung von spezifischen Instanzen (BOs, DOs, BOAs, DOAs) zu konzeptuell kohärenten Mengen von Entitäten (BOTs, DOTs, BOTAs, DOTAs)rdfs:comment : Connection from specific instances (BOs, DOs, BOAs, DOAs) to conceptually coherent sets of entities (BOTs, DOTs, BOTAs, DOTAs)</para>
    ///   <para>vann:example : BOA 'Hr. Schmidt' repräsentiert BOTA 'Kundenname'; BO 'Kunde 2338' repräsentiert BOT 'Kunde'vann:example : BOA 'Mr. Smith' represents BOTA 'customer name'; BO 'Customer 2338' represents BOT 'Customer'</para>
    ///   <a href="http://www.data-knowledge.org/dk/represents">dk:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>vann:example : Data manager for procurement data is responsible for BOT 'supplier' and BOT 'procurement order'vann:example : Datenmanager für Beschaffungsdaten ist verantwortlich für BOT 'Lieferant' und BOT 'Beschaffungsauftrag'</para>
    ///   <para>rdfs:comment : Spezifische Zuweisung einer Verantwortlichkeit für einen gewissen Bereichrdfs:comment : Specific assignment of a responsibility for a particular scope</para>
    ///   <para>rdfs:label : verantwortlich fürrdfs:label : responsible for</para>
    ///   <a href="http://www.data-knowledge.org/dk/responsibleFor">dk:responsibleFor</a>
    /// </summary>
    let responsibleFor = _prefixId.prefix "responsibleFor"
    /// <summary>
    ///   <para>vann:example : Fr. Müller ist die Datenmanagerin für die Abteilung 'Beschaffung'vann:example : Mrs. Miller is the data manager for department 'procurement'</para>
    ///   <para>rdfs:comment : Persons can take Rolesrdfs:comment : Personen können Rollen einnehmen</para>
    ///   <para>rdfs:label : nimmt anrdfs:label : takes</para>
    ///   <a href="http://www.data-knowledge.org/dk/takes">dk:takes</a>
    /// </summary>
    let takes = _prefixId.prefix "takes"
    /// <summary>
    ///   <para>vann:example : New name for organizational unitvann:example : Neuer FAQ-Eintragvann:example : New FAQ entryvann:example : Neuer Name für Organisationseinheit</para>
    ///   <para>rdfs:label : tracksrdfs:label : verfolgt</para>
    ///   <para>rdfs:comment : The change history keeps track of changes to instancesrdfs:comment : Die Änderungshistorie verfolgt Änderungen an Instanzen</para>
    ///   <a href="http://www.data-knowledge.org/dk/tracks">dk:tracks</a>
    /// </summary>
    let tracks = _prefixId.prefix "tracks"
    /// <summary>
    ///   <para>rdfs:comment : Diese Relation spezifiziert, welche Daten konkret im Rahmen des Datenflusses übermittelt werden. Hierzu müssen die Daten aus der Quellapplikation, repräsentiert durch einen Datenobjekttyp (DOT), den von der Zielapplikation erwarteten Daten zugewiesen werden, welche ebenfalls durch einen Datenobjekttyp (DOT) repräsentiert werden. Somit verbindet diese Relation einen Datenfluss mit einer Schema-Zuordnung, die die Quell- und Ziel-DOTs und ihre Zuordnung beschreibt.rdfs:comment : This property specifies what data is actually transferred by the data flow. This requires the data from the source application, represented by a Data Object Type, to be mapped to the data expected by the target application, also represented by a Data Object Type. Consequently, this property links a Data Flow with a Schema Mapping that outlines the source and target Data Object Types and how they map.</para>
    ///   <para>rdfs:label : transfers datardfs:label : übermittelt Daten</para>
    ///   <para>vann:example : There is a Data Flow from the ERP system to the WMS system that transfers material master data. The Schema Mapping referenced by this Data Flow specifies, that it involves the Data Object Type 'Material Master' on the ERP side with Data Object Type Attributes 'mat_nr', 'mat_descr', etc. On the WMS side, this data is represented by the Data Object Type 'ItemMaster' with Data Object Type Attributes 'im_id', 'im_nm', etc. The Schema may also specify that 'mat_nr' maps to 'im_id', 'mat_descr' to 'im_nm', etc.vann:example : Es findet ein Datenfluss vom ERP-System zum WMS-System statt, welcher Materialstammdaten überträgt. Die Schema-Zuordnung, auf die von diesem Datenfluss verwiesen wird, spezifiziert dass er den DOT 'Material Master' auf der ERP-Seite mit den Attributen (DOTAs) 'mat_nr', 'mat_descr', etc. beinhaltet. Auf der WMS-Seite werden diese Daten mittels des DOTs 'ItemMaster' und den DOTAs 'im_id', 'im_nm', etc. repräsentiert. Das Schema kann außerdem genauer spezifizieren, dass 'mat_nr' 'im_id' zugeordnet ist, 'mat_descr' 'im_nm', etc.</para>
    ///   <a href="http://www.data-knowledge.org/dk/transfersData">dk:transfersData</a>
    /// </summary>
    let transfersData = _prefixId.prefix "transfersData"
    /// <summary>
    ///   <para>rdfs:comment : Geschäftsprozesse konsumieren oder nutzen BO/T/As oder BODsrdfs:comment : Business Processes consume or use BO/T/As or BODs</para>
    ///   <para>rdfs:label : nutztrdfs:label : uses</para>
    ///   <para>vann:example : Geschäftsprozess 'Versand von Bestellung 02917' nutzt BO 'Kunde Example Co. Ltd.' und seine BOAs 'Name' und 'Adresse'vann:example : Business Process 'shipping of order 02917' uses BO 'customer Example Co. Ltd.' and its BOAs 'name' and 'address'</para>
    ///   <a href="http://www.data-knowledge.org/dk/uses">dk:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
    /// <summary>
    ///   <para>vann:example : Project 'Modernization of transport-related data' works on BOTs 'LoadSecuring','Packaging', 'Shipment' and 'Transport'vann:example : Projekt 'Modernisierung von transportbezogenen Daten' arbeitet an BOTs 'Ladungssicherung', 'Sendung' und 'Transport'</para>
    ///   <para>rdfs:label : arbeitet anrdfs:label : works on</para>
    ///   <para>rdfs:comment : Projects work on Business Object Types or Applications, e.g. by creating or changing themrdfs:comment : Projekte arbeiten an Geschäftsobjekttypen (BOTs) oder Applikationen, indem sie diese z.B. erstellen oder verändern</para>
    ///   <a href="http://www.data-knowledge.org/dk/worksOn">dk:worksOn</a>
    /// </summary>
    let worksOn = _prefixId.prefix "worksOn"
