#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bci =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/BCI-ontology#" "bci"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:prefLabel : BCI data access method^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:description : ** HIDDEN CONTENT **
    /// ==============================================================================
    /// ** definition **
    /// "(a network communication protocol and its parameters)"
    /// &lt;li&gt;The &lt;em&gt;identity scheme&lt;/em&gt; of the data access.&lt;/li&gt;
    /// &lt;li&gt;The &lt;em&gt;security scheme&lt;/em&gt; of the protocol.&lt;/li&gt;
    ///
    /// ** scopeNote **
    /// %CLASS_HIERARCHY% the network communication protocols that BCI applications can use to access and retrieve the &lt;a&gt;RecordedData&lt;/a&gt;.
    /// &lt;br /&gt;This ontology defines some of the aforementioned network communication protocols, commonly used by BCI applications.
    ///
    /// ** editorialNote **
    /// &lt;p&gt;This ontology does not define in &lt;span style="text-decoration: underline;"&gt;any specific way&lt;/span&gt; the components regarding the &lt;em&gt;identity and security schemes&lt;/em&gt; of an &lt;a&gt;AccessMethod&lt;/a&gt;. &lt;br /&gt;This information could be extended, for example, through a set of &lt;span style="text-decoration: underline;"&gt;undefined-general-purpose datatype properties&lt;/span&gt; to capture the following corresponding definitions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;For the &lt;em&gt;identity scheme&lt;/em&gt; of the data access: &lt;strong&gt;hasIdentity&lt;/strong&gt;.&lt;/li&gt;
    /// &lt;li&gt;For the &lt;em&gt;security scheme&lt;/em&gt; of the protocol: &lt;strong&gt;hasSecurity&lt;/strong&gt; and &lt;strong&gt;hasQoS&lt;/strong&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ==============================================================================^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;The &lt;a title="Publish&amp;ndash;subscribe pattern" href="https://en.wikipedia.org/wiki/Publish%E2%80%93subscribe_pattern" target="_blank"&gt;publish/subscribe mechanism&lt;/a&gt;&amp;nbsp;is one of the preferred implementations for BCI applications.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;The concept will be merged into the &lt;em&gt;generic abstraction&lt;/em&gt; of &lt;strong&gt;&amp;lt;container&amp;gt;&lt;/strong&gt; under the &lt;a title="oneM2M - Management, Abstraction and Semantics" href="http://www.slideshare.net/onem2m/onem2m-management-abstraction-and-semantics/13" target="_blank"&gt;oneM2M spec&lt;/a&gt;, and made compatible with its emerging semantic extension.&lt;/p&gt;
    ///
    /// &lt;p&gt;A &lt;strong&gt;&amp;lt;container&amp;gt;&lt;/strong&gt; represents a "&lt;span style="text-decoration: underline;"&gt;data collection&lt;/span&gt;" and, therefore, it's directly related to the &lt;a&gt;RecordedData&lt;/a&gt; concept.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:34 AM 2016-07-06 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;This concept captures any computer network mechanism (network communication protocol) through which the &lt;a&gt;RecordedData&lt;/a&gt; can be accessed.
    ///
    /// &lt;br /&gt;An &lt;a&gt;AccessMethod&lt;/a&gt; represents any specific standard communication protocol, such as: MQTT, MQTT-SN, HTTP, CoAP, FTP, etc.
    ///
    /// &lt;br /&gt;For the purpose of this ontology, an &lt;a&gt;AccessMethod&lt;/a&gt; captures only the following components:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;Nature&lt;/em&gt; of the data access: &lt;span style="text-decoration: underline;"&gt;file&lt;/span&gt; or &lt;span style="text-decoration: underline;"&gt;stream&lt;/span&gt;.&lt;/li&gt;
    /// &lt;li&gt;The &lt;em&gt;locator&lt;/em&gt; (address) of the data.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : AccessMethod^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#AccessMethod">bci:AccessMethod</a>
    /// </summary>
    let AccessMethod = _prefixId.prefix "AccessMethod"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:booleanowl:deprecated : &amp;laquo;This ontology should be agnostic to the data access&amp;raquo;
    /// &lt;br /&gt;$ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : CoAP access method^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : AccessMethod.CoAP^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Represents a &lt;a title="Constrained Application Protocol" href="https://en.wikipedia.org/wiki/Constrained_Application_Protocol" target="_blank"&gt;CoAP&lt;/a&gt; &lt;a&gt;AccessMethod&lt;/a&gt;. Similarly as &lt;a title="Hypertext Transfer Protocol" href="https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol" target="_blank"&gt;HTTP&lt;/a&gt;, this software protocol supports &lt;a title="Internationalized Resource Identifier" href="https://en.wikipedia.org/wiki/Internationalized_Resource_Identifier" target="_blank"&gt;IRI&lt;/a&gt; and &lt;a title="Content negotiation" href="https://en.wikipedia.org/wiki/Content_negotiation" target="_blank"&gt;content-type negotiation&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#AccessMethod.CoAP">bci:AccessMethod.CoAP</a>
    /// </summary>
    let AccessMethod'_period_'CoAP = _prefixId.prefix "AccessMethod.CoAP"

    let AccessMethod'_period_'CoAP'_period_'POWDER = _prefixId.prefix "AccessMethod.CoAP.POWDER"

    /// <summary>
    ///   <para>skos:prefLabel : MQTT Access Method^^rdfs:Literal</para>
    ///   <para>owl:deprecated : &amp;laquo;This ontology should be agnostic to the data access&amp;raquo;
    /// &lt;br /&gt;$ 04:35 AM 2016-07-05 $^^rdfs:Literalowl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Represents a &lt;a title="MQ Telemetry Transport" href="https://en.wikipedia.org/wiki/MQTT" target="_blank"&gt;MQTT&lt;/a&gt; &lt;a&gt;AccessMethod&lt;/a&gt;, which is a &lt;em&gt;machine-to-machine (M2M)/"Internet of Things"&lt;/em&gt; connectivity protocol. MQTT was designed as an extremely lightweight publish/subscribe messaging transport.
    ///
    /// &lt;br /&gt;This concept describes the corresponding definition of access parameters needed for a suitable MQTT connection.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : AccessMethod.MQTT^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#AccessMethod.MQTT">bci:AccessMethod.MQTT</a>
    /// </summary>
    let AccessMethod'_period_'MQTT = _prefixId.prefix "AccessMethod.MQTT"

    let AccessMethod'_period_'MQTT'_period_'POWDER = _prefixId.prefix "AccessMethod.MQTT.POWDER"

    let AccessMethod'_period_'POWDER = _prefixId.prefix "AccessMethod.POWDER"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:booleanowl:deprecated : &amp;laquo;This ontology should be agnostic to the data access&amp;raquo;
    /// &lt;br /&gt;$ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Represents a &lt;a title="Representational state transfer" href="https://en.wikipedia.org/wiki/Representational_state_transfer" target="_blank"&gt;RESTful&lt;/a&gt; &lt;a&gt;AccessMethod&lt;/a&gt;, where the data is exchanged in &lt;a title="JavaScript Object Notation" href="https://en.wikipedia.org/wiki/JSON" target="_blank"&gt;JSON format&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : RESTful-JSON access method^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:title : AccessMethod.RESTful-JSON^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#AccessMethod.RESTful-JSON">bci:AccessMethod.RESTful-JSON</a>
    /// </summary>
    let AccessMethod'_period_'RESTful_JSON = _prefixId.prefix "AccessMethod.RESTful-JSON"

    let AccessMethod'_period_'RESTful_JSON'_period_'POWDER = _prefixId.prefix "AccessMethod.RESTful-JSON.POWDER"

    /// <summary>
    ///   <para>skos:prefLabel : action^^rdfs:Literal</para>
    ///   <para>dcterms:title : Action^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:32 PM 2016-06-24 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes any &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Event&lt;/em&gt;&lt;/span&gt; issued by a &lt;a&gt;Subject&lt;/a&gt; while performing a specific &lt;a&gt;Activity&lt;/a&gt;.
    ///
    /// &lt;br /&gt;&lt;a&gt;Action&lt;/a&gt;s are considered to be structural components of an &lt;a&gt;Activity&lt;/a&gt;, which are performed by the &lt;a&gt;Subject&lt;/a&gt; while interacting with the &lt;a&gt;Context&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;As an &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;interaction event&lt;/span&gt;&lt;/em&gt;, an &lt;a&gt;Action&lt;/a&gt; can &lt;em&gt;register&lt;/em&gt; many &lt;a&gt;PlayoutInstant.SubjectAction&lt;/a&gt;s in a &lt;a&gt;Playout&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant &lt;a&gt;Action&lt;/a&gt; classification that &lt;a&gt;Subject&lt;/a&gt;s can do, while performing an &lt;a&gt;Activity&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>ov:part : Session,Subject^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Activity.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Action">bci:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    let Action'_period_'POWDER = _prefixId.prefix "Action.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;Relationship between &lt;a&gt;Activity&lt;/a&gt; and &lt;a&gt;Aspect&lt;/a&gt;:&lt;/span&gt;&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;BCI applications are designed to analyze how an &lt;a&gt;Activity&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;influences&lt;/em&gt;&lt;/span&gt; an &lt;a&gt;Aspect&lt;/a&gt;: it's part of the research scheme and purpose of a BCI application.&lt;/li&gt;
    /// &lt;li&gt;From the perspective of a BCI application, an &lt;a&gt;Activity&lt;/a&gt; has a "&lt;span style="text-decoration: underline;"&gt;main&lt;/span&gt;" &lt;a&gt;Aspect&lt;/a&gt; to analyze.&lt;/li&gt;
    /// &lt;li&gt;A SPARQL triple pattern matching that connects &lt;a&gt;Activity&lt;/a&gt;(ies) to &lt;a&gt;Aspect&lt;/a&gt;s would be:&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;blockquote class="remark"&gt;
    /// &lt;p&gt;
    ///   ?&lt;em&gt;Session&lt;/em&gt;&amp;nbsp; &amp;nbsp; &lt;b&gt;hasActivity&lt;/b&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp; &amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp; ?&lt;em&gt;Activity&lt;/em&gt;
    ///   &lt;br /&gt;?&lt;em&gt;Session&lt;/em&gt;&amp;nbsp; &amp;nbsp; &lt;b&gt;hasRecord&lt;/b&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp; ?&lt;em&gt;Record&lt;/em&gt;
    ///   &lt;br /&gt;?&lt;em&gt;Record&lt;/em&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp;&lt;b&gt;bci:aspectOfInterest&lt;/b&gt;&amp;nbsp; ?&lt;em&gt;Aspect&lt;/em&gt;
    /// &lt;/p&gt;
    /// &lt;/blockquote&gt;^^rdfs:Literalskos:editorialNote : &lt;ul&gt;
    /// &lt;li&gt;The concept of &lt;a&gt;Activity&lt;/a&gt; is &lt;em&gt;agnostic&lt;/em&gt; regarding the &lt;span style="text-decoration: underline;"&gt;number of &lt;a&gt;Subject&lt;/a&gt;s&lt;/span&gt; engaging in an individual &lt;a&gt;Activity&lt;/a&gt;.
    /// &lt;br /&gt;The ontology clearly defines that the connection between &lt;a&gt;Subject&lt;/a&gt;s and &lt;a&gt;Activity&lt;/a&gt;(ies) is through &lt;a&gt;Session&lt;/a&gt;s:
    /// &lt;br /&gt;&lt;span style="text-decoration: underline;"&gt;one &lt;a&gt;Session&lt;/a&gt; associates one &lt;a&gt;Subject&lt;/a&gt; performing one &lt;a&gt;Activity&lt;/a&gt; while interacting with one &lt;a&gt;Context&lt;/a&gt;&lt;/span&gt;.&lt;/li&gt;
    ///
    /// &lt;li&gt;BCI applications can use this concept as a way to &lt;em&gt;annotate/mark&lt;/em&gt; (&lt;a&gt;Marker&lt;/a&gt;) the &lt;a&gt;Record&lt;/a&gt;s (&lt;a&gt;DataSegment&lt;/a&gt;s).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : activity^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Activity.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:42 AM 2016-06-28 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : Activity^^rdfs:Literal</para>
    ///   <para>ov:part : Session,Subject^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;Some subclasses of this concept could be:
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Glaucoma Tracking&lt;/em&gt;&lt;/span&gt;:
    /// &lt;br /&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp;This &lt;a&gt;Activity&lt;/a&gt; type is a common example for "&lt;em&gt;pre-screening&lt;/em&gt;" of &lt;a&gt;Subject&lt;/a&gt;s.&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Learning&lt;/em&gt;&lt;/span&gt;: BCI applications can apply different &lt;em&gt;Stimuli&lt;/em&gt; (&lt;a&gt;StimulusEvent&lt;/a&gt;) to the &lt;a&gt;Subject&lt;/a&gt;s.
    /// &lt;br /&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp;This &lt;a&gt;Activity&lt;/a&gt; type is a common example for "&lt;em&gt;interactive&lt;/em&gt;" observations.&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Sleeping&lt;/em&gt;&lt;/span&gt;: BCI applications don't apply any kind of &lt;em&gt;Stimuli&lt;/em&gt; to the &lt;a&gt;Subject&lt;/a&gt;s (there are no &lt;a&gt;StimulusEvent&lt;/a&gt;).
    /// &lt;br /&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp;This &lt;a&gt;Activity&lt;/a&gt; type is a common example for "&lt;em&gt;running&lt;/em&gt;" observations: continuous observations.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;&lt;a&gt;Activity&lt;/a&gt; is the &lt;a&gt;Subject&lt;/a&gt;'s &lt;span style="text-decoration: underline;"&gt;physical state&lt;/span&gt; while interacting with the &lt;a&gt;Context&lt;/a&gt; during a specific &lt;a&gt;Session&lt;/a&gt;.
    /// &lt;br /&gt;This concept descirbes an &lt;a&gt;Activity&lt;/a&gt; performed by the &lt;a&gt;Subject&lt;/a&gt; on a specific &lt;a&gt;Session&lt;/a&gt; while interacting with a specific &lt;a&gt;Context&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;BCI applications monitor the &lt;a&gt;Subject&lt;/a&gt;'s physical state during the &lt;a&gt;Session&lt;/a&gt;s.
    /// &lt;br /&gt;This concept identifies the type of &lt;a&gt;Activity&lt;/a&gt; that the &lt;a&gt;Subject&lt;/a&gt; is performing while recording the data in a &lt;a&gt;Session&lt;/a&gt;.
    /// &lt;br /&gt;Hence, each &lt;a&gt;Session&lt;/a&gt; associates a single &lt;a&gt;Subject&lt;/a&gt; interactions with a single &lt;a&gt;Context&lt;/a&gt; while performing a single &lt;a&gt;Activity&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;An &lt;a&gt;Activity&lt;/a&gt; can be break down as a set of &lt;a&gt;Action&lt;/a&gt;s, performed by the &lt;a&gt;Subject&lt;/a&gt; while interacting with the &lt;a&gt;Context&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant &lt;a&gt;Activity&lt;/a&gt; classification that &lt;a&gt;Subject&lt;/a&gt;s can engage on in &lt;a&gt;Session&lt;/a&gt;s.^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Activity">bci:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    let Activity'_period_'POWDER = _prefixId.prefix "Activity.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@ASPECT-and-MODALITY^^rdfs:Literalskos:editorialNote : &lt;p&gt;The following descriptions capture the definition of this concept ([&lt;strong&gt;SSN&lt;/strong&gt;: &lt;a title="Semantic Sensor Network Ontology &amp;raquo; FeatureOfInterest" href="https://purl.oclc.org/NET/ssnx/ssn#FeatureOfInterest" target="_blank"&gt;FeatureOfInterest&lt;/a&gt;] and [&lt;b&gt;Compton2009&lt;/b&gt;]) adjusted to this ontology:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;An &lt;a&gt;Aspect&lt;/a&gt; is an abstraction of BCI activities performed by humans, from the human body's state perspective.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;Device&lt;/a&gt;s observe physiological signals (&lt;a&gt;Modality&lt;/a&gt;-ies) of &lt;a&gt;Aspect&lt;/a&gt;s: for example, the EEG signals (&lt;a&gt;Modality&lt;/a&gt;) of an emotion (&lt;a&gt;Aspect&lt;/a&gt;).&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;Aspect&lt;/a&gt;s are human body's states that are the target of sensing.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : Aspect^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] It's the classification of &lt;a&gt;ssn:FeatureOfInterest&lt;/a&gt; for &lt;span style="text-decoration: underline;"&gt;BCI Activities&lt;/span&gt;. This concept captures the view or interpretation for the &lt;a&gt;Record&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : aspect^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN], [Compton2009]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:19 AM 2016-08-20 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the &lt;a&gt;Aspect&lt;/a&gt;s of the &lt;a&gt;Record&lt;/a&gt;s.
    ///
    /// &lt;br /&gt;Three main &lt;a&gt;Aspect&lt;/a&gt;s are defined in this ontology.^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Aspect">bci:Aspect</a>
    /// </summary>
    let Aspect = _prefixId.prefix "Aspect"
    let Aspect'_period_'POWDER = _prefixId.prefix "Aspect.POWDER"
    /// <summary>
    ///   <para>dcterms:source : [SSN], [XDF], [ESS]^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-MeasurementCapability^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;&lt;a title="What Is BCI and How Did It Evolve?" href="http://neurosky.com/2015/06/what-is-bci-and-how-did-it-evolve/" target="_blank"&gt;BCI systems&lt;/a&gt; naturally collects and transmits data from a sender (transmitter machine) to a receiver (receiving machine).
    ///
    /// &lt;br /&gt;In a &lt;a title="Channel (communications)" href="https://en.wikipedia.org/wiki/Channel_(communications)" target="_blank"&gt;general and abstract way&lt;/a&gt;, a &lt;strong&gt;channel&lt;/strong&gt; is used to convey an &lt;span style="text-decoration: underline;"&gt;information signal&lt;/span&gt;, for example a &lt;em&gt;digital bit stream&lt;/em&gt;, from one or several senders (or transmitters) to one or several receivers.
    ///
    /// &lt;br /&gt;The concept of &lt;strong&gt;channel&lt;/strong&gt; defined in this ontology aims to capture a &lt;span style="text-decoration: underline;"&gt;relevant metadata set&lt;/span&gt; that describes the &lt;em&gt;measurement properties&lt;/em&gt; for any type of channel.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;A simplistic notion regarding the relationship and difference between the concepts of &lt;a&gt;Channel&lt;/a&gt; and &lt;a&gt;DataFormat&lt;/a&gt;, is depicted in the following example:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;If the used &lt;a&gt;DataFormat&lt;/a&gt; were "&lt;a title="The Comma-Separated Values file format" href="https://en.wikipedia.org/wiki/Comma-separated_values" target="_blank"&gt;CSV&lt;/a&gt;", then the &lt;strong&gt;channeling schema&lt;/strong&gt; (&lt;a&gt;DeviceChannelingSpec&lt;/a&gt;) would define the &lt;em&gt;data's logical structure&lt;/em&gt;:
    /// &lt;br /&gt;[&lt;strong&gt;Channeling Schema&lt;/strong&gt;] = &lt;em&gt;{ Col1: ID, Col2: Date, Col3: Name, ... }&lt;/em&gt;, where each &lt;span style="text-decoration: underline;"&gt;column&lt;/span&gt; represents a specific &lt;a&gt;Channel&lt;/a&gt; definition.
    /// &lt;br /&gt;Note that each column has its own related metadata and attributes; also, it follows its proper structure, format or notation scheme, etc.&lt;/blockquote&gt;^^rdfs:Literalskos:editorialNote : %GENERAL_COMMENT%@UNITS-OF-MEASUREMENT^^rdfs:Literalskos:editorialNote : &lt;p&gt;&lt;a&gt;Channel&lt;/a&gt;s are the logical components of &lt;a&gt;Record&lt;/a&gt;s. Their structural relationship resembles a &lt;span style="text-decoration: underline;"&gt;matrix&lt;/span&gt;, in the following way:&lt;/p&gt;
    /// &lt;table style="text-align: center;"&gt;
    /// &lt;thead&gt;&lt;tr&gt;&lt;td&gt;
    /// &lt;table style="height: 125px;" width="370"&gt;
    /// &lt;tbody&gt;
    /// &lt;tr&gt;
    /// &lt;td colspan="5"&gt;[&lt;strong&gt;rows&lt;/strong&gt;]
    /// &lt;br /&gt;&lt;a&gt;Channel&lt;/a&gt;s are different &lt;em&gt;data rows&lt;/em&gt;.&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;strong&gt;&amp;rightrightarrows;&lt;/strong&gt;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;strong&gt;&amp;rightrightarrows;&lt;/strong&gt;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;strong&gt;&amp;rightrightarrows;&lt;/strong&gt;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;strong&gt;&amp;rightrightarrows;&lt;/strong&gt;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;/tbody&gt;
    /// &lt;/table&gt;
    /// &lt;/td&gt;&lt;td&gt;
    /// &lt;table style="height: 125px;" width="370"&gt;
    /// &lt;tbody&gt;
    /// &lt;tr&gt;
    /// &lt;td colspan="5"&gt;[&lt;strong&gt;columns&lt;/strong&gt;]
    /// &lt;br /&gt;&lt;strong&gt;Data samples&lt;/strong&gt; are different &lt;em&gt;data columns&lt;/em&gt;.
    /// &lt;br /&gt;They correspond to specific &lt;strong&gt;time instance&lt;/strong&gt;s.&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;strong&gt;&amp;downdownarrows;&lt;/strong&gt;&lt;/td&gt;&lt;td&gt;&lt;strong&gt;&amp;downdownarrows;&lt;/strong&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;strong&gt;&amp;downdownarrows;&lt;/strong&gt;&lt;/td&gt;&lt;td&gt;&lt;strong&gt;&amp;downdownarrows;&lt;/strong&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;strong&gt;&amp;downdownarrows;&lt;/strong&gt;&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;td&gt;&amp;nbsp;&lt;/td&gt;&lt;td&gt;&amp;nbsp;&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;/tbody&gt;
    /// &lt;/table&gt;
    /// &lt;/td&gt;&lt;/tr&gt;&lt;/thead&gt;
    /// &lt;/table&gt;
    /// &lt;p&gt;Hence, &lt;a&gt;Channel&lt;/a&gt;s can point to specific parts of a &lt;a&gt;Record&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;&lt;strong&gt;Channel Structure&lt;/strong&gt;&lt;/span&gt;:&lt;/p&gt;
    ///
    /// &lt;p&gt;The channel structure is composed of different related metadata and attributes. It varies widely depending on the following:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;the related/associated &lt;a&gt;Modality&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;the functional "role" that plays in a &lt;a&gt;Device&lt;/a&gt;'s data model, and,&lt;/li&gt;
    /// &lt;li&gt;the way how it's used in a specific &lt;a&gt;Record&lt;/a&gt; settings.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;Due that a &lt;strong&gt;channeling spec&lt;/strong&gt; is directly associated with a &lt;a&gt;Device&lt;/a&gt; and a &lt;a&gt;Record&lt;/a&gt;, in theory, a &lt;span style="text-decoration: underline;"&gt;channel&lt;/span&gt; defines a specific (or proper) logical data structure component for a &lt;a&gt;Device&lt;/a&gt; and/or a &lt;a&gt;Record&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;The most common metadata and attributes of a channel structure, regardless of its nature, are:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;strong&gt;Label&lt;/strong&gt;: defined as &lt;a&gt;hasLabel&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;strong&gt;Type&lt;/strong&gt;: defined as the channel &lt;span style="text-decoration: underline;"&gt;class type&lt;/span&gt; (&lt;em&gt;class hierarchy&lt;/em&gt;).&lt;/li&gt;
    /// &lt;li&gt;&lt;strong&gt;Placement&lt;/strong&gt; (or &lt;em&gt;Location&lt;/em&gt;): refers to the attribute set that define its placement on a &lt;a&gt;Subject&lt;/a&gt;. The placement's attribute structure varies widely depending on the channel's nature.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : channeling data (logical component)^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;ul&gt;
    /// &lt;li&gt;[&lt;b&gt;XDF&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;a title="Eye-Gaze metadata" href="https://code.google.com/p/xdf/wiki/GazeMetaData" target="_blank"&gt;Eye-Gaze Channel&lt;/a&gt;&lt;/span&gt;: channeling metadata for an &lt;strong&gt;Eye-Gaze Record&lt;/strong&gt;.
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;CoordinateSystem = { World-Space, Object-Space, Camera-Space, or Image-Space }&lt;/em&gt;: coordinate system of the respective parameter.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;RefersTo = { Left, Right, or Both }&lt;/em&gt;: which eye the channel is referring to.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;Type&lt;/em&gt;: Type of data in this channel. It can be any of the following values:
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;{ ScreenX, ScreenY }&lt;/em&gt;: screen coordinates of the gaze cursor (can also refer to a scene image); usually in pixels.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ DirectionX, DirectionY, DirectionZ }&lt;/em&gt;: 3D gaze vector in some coordinate system.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ PositionX, PositionY, PositionZ }&lt;/em&gt;: 3D position of the eye center in some coordinate system.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ IntersectionX, IntersectionY, IntersectionZ }&lt;/em&gt;: 2D or 3D position of the intersection point with a plane (in some coordinate system).&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ HeadX, HeadY, HeadZ }&lt;/em&gt;: 3D location of the head center in some coordinate system.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ PupilX, PupilY, PupilZ }&lt;/em&gt;: 2D or 3D location of the pupil center in some coordinate system.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ ReflexX, ReflexY, ReflexZ }&lt;/em&gt;: 2D or 3D location of the illuminator's reflection point in some coordinate system.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ Radius or Diameter }&lt;/em&gt;: the overall pupil radius or diameter (usually in mm or pixels).&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ RadiusX, RadiusY }&lt;/em&gt;: horizontal and vertical pupil radius.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ DiameterX, DiameterY }&lt;/em&gt;: horizontal and vertical pupil diameter.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ Confidence }&lt;/em&gt;: for confidence information (preferred unit: normalized).&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ FrameNumber }&lt;/em&gt;: frame number that the parameters were calculated from.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ PlaneNumber or ObjectId }&lt;/em&gt;: number or identifier of the object that was intersected by the gaze vector.&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Keyboard-Hit Channel&lt;/span&gt;: channeling metadata for a &lt;strong&gt;Keyboard-Hit Record&lt;/strong&gt;.&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;XDF&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;Hand-Gesture Channel&lt;/span&gt;: channeling metadata for a &lt;strong&gt;Hand-Gesture Record&lt;/strong&gt;.
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;Type = { Confidence, OrientationH, OrientationP, OrientationR, PositionX, PositionY, PositionZ }&lt;/em&gt;: type of data. [following types from GazeMetaData &amp;amp; "LeapMotion_xml_output" definitions.]&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Mouse-Click Channel&lt;/span&gt;: channeling metadata for a &lt;strong&gt;Mouse-Click Record&lt;/strong&gt;.
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;Type = { PositionX, PositionY }&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;Button = { Left, Other, Right, Wheel }&lt;/em&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : Channel^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;Channel&lt;/a&gt; is a relevant metadata set that defines a logical component schema of a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;'s data structure model.
    ///
    /// &lt;br /&gt;A &lt;a&gt;Channel&lt;/a&gt; is defined as a specialized &lt;a&gt;ssn:MeasurementCapability&lt;/a&gt; type that describes a compounded set of &lt;em&gt;measurement properties&lt;/em&gt; (&lt;a&gt;ssn:MeasurementProperty&lt;/a&gt;-ies), as explained in &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.5) MeasuringCapability" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#MeasuringCapability" target="_blank"&gt;SSN MeasuringCapability module&lt;/a&gt;.
    ///
    /// &lt;br /&gt;A &lt;a&gt;Channel&lt;/a&gt; is associated to a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; definition and, hence, to a &lt;a&gt;RecordChannelingSpec&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;As part of a &lt;strong&gt;channeling spec&lt;/strong&gt;, a &lt;a&gt;Channel&lt;/a&gt; definition can be extended to incorporate contextual metadata semantics (i.e., properties to describe dimensional characteristics regarding&amp;nbsp;what, when, how &amp;mdash;including mathematical formulas for calculations&amp;mdash;, where, why, etc.), depending on the &lt;a&gt;DataFormat&lt;/a&gt; used for the data files. This information can be associated to a channel definition via a &lt;a&gt;Descriptor&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% specialized &lt;strong&gt;channel&lt;/strong&gt; definitions related to specific &lt;a&gt;Modality&lt;/a&gt; types.^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:30 AM 2016-08-20 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Channel">bci:Channel</a>
    /// </summary>
    let Channel = _prefixId.prefix "Channel"
    let Channel'_period_'POWDER = _prefixId.prefix "Channel.POWDER"
    /// <summary>
    ///   <para>skos:example : &lt;p&gt;A &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;channeling schema&lt;/em&gt;&lt;/span&gt; information related to all kind of &lt;a&gt;EegRecord&lt;/a&gt;s would define around 32 fields (i.e., &lt;a&gt;EegChannel&lt;/a&gt;s) to describe a complete data structure regarding EEG data.
    /// &lt;br /&gt;The full specification for this &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;channeling schema&lt;/em&gt;&lt;/span&gt; information would be associated with the generic &lt;a&gt;EegModality&lt;/a&gt; concept.
    /// &lt;br /&gt;A proper name for this spec would be &lt;b&gt;EegChannelingSpec&lt;/b&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant type of a &lt;a&gt;ChannelingSpec&lt;/a&gt; to capture the external information that defines the complete &lt;em&gt;channeling schema&lt;/em&gt; information of a &lt;a&gt;Modality&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:54 PM 2016-08-08 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literaldctype:StillImage : Descriptor.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : ChannelingSpec^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Each &lt;a&gt;Modality&lt;/a&gt; defines its own specific &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;channeling schema&lt;/em&gt;&lt;/span&gt; information:
    /// &lt;br /&gt;a complete, generic and descriptive set of all possible &lt;a&gt;Channel&lt;/a&gt;s and their extended metadata attributes that defines the data structure model and template of the &lt;a&gt;Modality&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;A &lt;a&gt;ChannelingSpec&lt;/a&gt; captures the complete description of the &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;channeling schema&lt;/em&gt;&lt;/span&gt; information, in a form of an external document specification (outside the metadata repository).
    /// &lt;br /&gt;Similar to the &lt;a&gt;DeviceSpec&lt;/a&gt; concept, a &lt;a&gt;ChannelingSpec&lt;/a&gt; is a specialized &lt;a&gt;Descriptor&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : channeling schema spec^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#ChannelingSpec">bci:ChannelingSpec</a>
    /// </summary>
    let ChannelingSpec = _prefixId.prefix "ChannelingSpec"
    let ChannelingSpec'_period_'POWDER = _prefixId.prefix "ChannelingSpec.POWDER"
    /// <summary>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:title : CognitiveAspect^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the &lt;a&gt;CognitiveAspect&lt;/a&gt;s of the &lt;a&gt;Record&lt;/a&gt;s.^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes the classification of &lt;a&gt;CognitiveAspect&lt;/a&gt;s. One application for this &lt;a&gt;Aspect&lt;/a&gt; is &lt;span style="text-decoration: underline;"&gt;Learning&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:53 AM 2016-05-24 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : cognitive aspect^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#CognitiveAspect">bci:CognitiveAspect</a>
    /// </summary>
    let CognitiveAspect = _prefixId.prefix "CognitiveAspect"
    let CognitiveAspect'_period_'POWDER = _prefixId.prefix "CognitiveAspect.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;ul&gt;
    /// &lt;li&gt;&lt;a&gt;Collection&lt;/a&gt; generalizes the concept of &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Study&lt;/em&gt;&lt;/span&gt; as defined in [&lt;b&gt;ESS&lt;/b&gt;]: a set of data collection efforts to answer one or few related scientific questions.&lt;/li&gt;
    /// &lt;li&gt;This concept defines a &lt;em&gt;longitudinal&lt;/em&gt; (temporal) collection of &lt;a&gt;Session&lt;/a&gt;s.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : collection^^rdfs:Literal</para>
    ///   <para>ov:part : Session^^rdfs:Literal</para>
    ///   <para>dcterms:title : Collection^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Groups a &lt;span style="text-decoration: underline;"&gt;collection&lt;/span&gt; of related &lt;a&gt;Session&lt;/a&gt;s and/or &lt;a&gt;Interaction&lt;/a&gt;s, which &lt;em&gt;may be&lt;/em&gt; associated with different &lt;a&gt;Activity&lt;/a&gt;(ies).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Session.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:57 AM 2016-06-28 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Collection">bci:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    let Collection'_period_'POWDER = _prefixId.prefix "Collection.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;p&gt;A &lt;em&gt;classification&lt;/em&gt; (class hierarchy) for &lt;a&gt;Context&lt;/a&gt; has been not yet defined.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : context^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;ul&gt;
    /// &lt;li&gt;Physical descriptions of any environment.&lt;/li&gt;
    /// &lt;li&gt;Simulations.&lt;/li&gt;
    /// &lt;li&gt;Video Games.&lt;/li&gt;
    /// &lt;li&gt;Virtual Reality environments.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : Context^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:45 2016-04-14 $^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;In [&lt;strong&gt;Shafer2001&lt;/strong&gt;] we find the following definition of &lt;a&gt;Context&lt;/a&gt;:&lt;/p&gt;
    /// &lt;p&gt;&lt;i&gt;Dey et al. define context as "any information that can be used to characterize the situation of entities (i.e., whether a person, place, or object) that are considered relevant to the interaction between a user and an application" (p. 106).&lt;br /&gt;
    /// Thus, context awareness implies two attributes of a system: the ability to obtain context and the ability to utilize contextual information.&lt;/i&gt;&lt;/p&gt;
    /// &lt;p&gt;For the purpose of this ontology, a &lt;a&gt;Context&lt;/a&gt; is the architectural description of the environment (external settings, components and procedures) on which a &lt;a&gt;Subject&lt;/a&gt; interacts with it, during a &lt;a&gt;Session&lt;/a&gt;.&lt;/p&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.png^^rdfs:Literal</para>
    ///   <para>dcterms:source : [Shafer2001], [Unity]^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Context">bci:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>dcterms:source : [Unity]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.Object.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:10 PM 2016-05-25 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : context object^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the entities that participate in any &lt;a&gt;Context.Scene&lt;/a&gt;.^^rdfs:Literalskos:scopeNote : &lt;p&gt;Describing entities in any &lt;a&gt;Context.Scene&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Captures the architectural description of a stand-alone &lt;span style="text-decoration: underline;"&gt;entity&lt;/span&gt; ("&lt;em&gt;logical&lt;/em&gt;" or "&lt;em&gt;physical&lt;/em&gt;") that participates in a &lt;a&gt;Context.Scene&lt;/a&gt;.
    /// &lt;br /&gt;A &lt;a&gt;Context.Object&lt;/a&gt; can be compose of &lt;a&gt;Context.Object&lt;/a&gt;s.
    /// &lt;br /&gt;A &lt;a&gt;Context.Object&lt;/a&gt; is compose of a non-empty set of &lt;a&gt;Context.ObjectComponent&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>dcterms:title : Context.Object^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Context.Object">bci:Context.Object</a>
    /// </summary>
    let Context'_period_'Object = _prefixId.prefix "Context.Object"

    let Context'_period_'Object'_period_'POWDER = _prefixId.prefix "Context.Object.POWDER"

    /// <summary>
    ///   <para>skos:prefLabel : context object component^^rdfs:Literal</para>
    ///   <para>dcterms:title : Context.ObjectComponent^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Captures the architectural description of a stand-alone &lt;span style="text-decoration: underline;"&gt;entity&lt;/span&gt; ("&lt;em&gt;logical&lt;/em&gt;" or "&lt;em&gt;physical&lt;/em&gt;") that structurally forms part of a &lt;a&gt;Context.Object&lt;/a&gt;.&lt;br /&gt;A &lt;a&gt;Context.ObjectComponent&lt;/a&gt; can be compose of &lt;a&gt;Context.ObjectComponent&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the entities that can form any &lt;a&gt;Context.Object&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.ObjectComponent.png^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;ul&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Audio&lt;/span&gt;: A &lt;a&gt;Context.ObjectComponent&lt;/a&gt; with audio capabilities.&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Camera&lt;/span&gt;: A &lt;a&gt;Context.ObjectComponent&lt;/a&gt; that defines a specific visual perspective for the &lt;a&gt;Subject&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Effects&lt;/span&gt;: A &lt;a&gt;Context.ObjectComponent&lt;/a&gt; that can define specific visual effects.&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Layout&lt;/span&gt;: A &lt;a&gt;Context.ObjectComponent&lt;/a&gt; that can define specific layout configurations.&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Physics&lt;/span&gt;: A &lt;a&gt;Context.ObjectComponent&lt;/a&gt; that can define specific behaviour based on Physics models.&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Transform&lt;/span&gt;: A &lt;a&gt;Context.ObjectComponent&lt;/a&gt; that defines the logic of how an entity can move.
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;Protocol&lt;/em&gt; or &lt;em&gt;Procedure&lt;/em&gt;: some BCI applications may need to define a set of &lt;a&gt;Context.Object&lt;/a&gt;s that the &lt;a&gt;Subject&lt;/a&gt; needs to pay attention to.&lt;br /&gt;A specific type of a &lt;b&gt;Transform&lt;/b&gt; could be defined to represent the logical behaviour or movement of an entity based on an algorithm.&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Video&lt;/span&gt;: A &lt;a&gt;Context.ObjectComponent&lt;/a&gt; with video recording capabilities.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:35 AM 2016-08-22 $^^rdfs:Literal</para>
    ///   <para>dcterms:source : [Unity]^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Context.ObjectComponent">bci:Context.ObjectComponent</a>
    /// </summary>
    let Context'_period_'ObjectComponent = _prefixId.prefix "Context.ObjectComponent"

    /// <summary>
    ///   <para>dctype:StillImage : Activity.png^^rdfs:Literaldctype:StillImage : Context.ObjectComponent.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : Context.ObjectComponent.Event^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : context object component event^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:45 PM 2016-05-18 $^^rdfs:Literal</para>
    ///   <para>dcterms:source : [Unity]^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt; entities.
    ///  &lt;br /&gt;This class hierarchy includes the subclass &lt;a&gt;StimulusEvent&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>skos:example : Some event types from the &lt;em&gt;Gaming&lt;/em&gt; domain are:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;PointerEnter&lt;/li&gt;
    /// &lt;li&gt;PointerExit&lt;/li&gt;
    /// &lt;li&gt;PointerDown&lt;/li&gt;
    /// &lt;li&gt;PointerUp&lt;/li&gt;
    /// &lt;li&gt;PointerClick&lt;/li&gt;
    /// &lt;li&gt;Drag&lt;/li&gt;
    /// &lt;li&gt;Drop&lt;/li&gt;
    /// &lt;li&gt;Scroll&lt;/li&gt;
    /// &lt;li&gt;UpdateSelected&lt;/li&gt;
    /// &lt;li&gt;Select&lt;/li&gt;
    /// &lt;li&gt;Deselect&lt;/li&gt;
    /// &lt;li&gt;Move&lt;/li&gt;
    /// &lt;li&gt;InitializePotentialDrag&lt;/li&gt;
    /// &lt;li&gt;BeginDrag&lt;/li&gt;
    /// &lt;li&gt;EndDrag&lt;/li&gt;
    /// &lt;li&gt;Submit&lt;/li&gt;
    /// &lt;li&gt;Cancel&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Captures an &lt;em&gt;Event&lt;/em&gt; that triggers a change on the &lt;a&gt;Context.ObjectComponent&lt;/a&gt;'s state.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Context.ObjectComponent.Event">bci:Context.ObjectComponent.Event</a>
    /// </summary>
    let Context'_period_'ObjectComponent'_period_'Event = _prefixId.prefix "Context.ObjectComponent.Event"

    let Context'_period_'ObjectComponent'_period_'Event'_period_'POWDER = _prefixId.prefix "Context.ObjectComponent.Event.POWDER"

    let Context'_period_'ObjectComponent'_period_'POWDER = _prefixId.prefix "Context.ObjectComponent.POWDER"

    let Context'_period_'POWDER = _prefixId.prefix "Context.POWDER"
    /// <summary>
    ///   <para>skos:scopeNote : &lt;p&gt;The classification of how a &lt;a&gt;Context.Object&lt;/a&gt; participates in a &lt;a&gt;Context.Scene&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literalskos:scopeNote : %CLASS_HIERARCHY% the different ways ("&lt;em&gt;Roles&lt;/em&gt;") in that &lt;a&gt;Context.Object&lt;/a&gt;s can &lt;span style="text-decoration: underline;"&gt;participate&lt;/span&gt; in a &lt;a&gt;Context.Scene&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>dcterms:source : [Unity]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : context object role^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:50 AM 2016-08-22 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Specifies how a &lt;a&gt;Context.Object&lt;/a&gt; participates (its "&lt;em&gt;Role&lt;/em&gt;") in the &lt;a&gt;Context.Scene&lt;/a&gt;.&lt;br /&gt;A &lt;a&gt;Context.Object&lt;/a&gt; only has one &lt;a&gt;Context.Role&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : Context.Role^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.Role.png^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;This ontology does not define any specific &lt;a&gt;Context.Role&lt;/a&gt; subclasses.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;ul&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Character&lt;/span&gt;: The &lt;a&gt;Context.Object&lt;/a&gt; participates as a &lt;em&gt;character&lt;/em&gt; in the &lt;a&gt;Context.Scene&lt;/a&gt;. That is, as an autonomous animated entity that interacts directly (in the foreground) with the &lt;a&gt;Subject&lt;/a&gt;. For some BCI applications, this role describes all the &lt;a&gt;Context.Object&lt;/a&gt;s that forms a "&lt;em&gt;Protocol&lt;/em&gt;" or "&lt;em&gt;Procedure&lt;/em&gt;"; that is, the ones that the &lt;a&gt;Subject&lt;/a&gt; needs to pay attention to.&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Property&lt;/span&gt;: The &lt;a&gt;Context.Object&lt;/a&gt; participates as a &lt;em&gt;property&lt;/em&gt; in the &lt;a&gt;Context.Scene&lt;/a&gt;. That is, as a co-dependant entity that can influence the configuration of any entity in a &lt;a&gt;Context.Scene&lt;/a&gt;.&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Scenery&lt;/span&gt;: The &lt;a&gt;Context.Object&lt;/a&gt; participates as part of the &lt;em&gt;scenery&lt;/em&gt; in the &lt;a&gt;Context.Scene&lt;/a&gt;. That is, as an (autonomous) animated entity that interacts indirectly (in the background) with the &lt;a&gt;Subject&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;Some BCI applications implement simple &lt;a&gt;Context&lt;/a&gt;s, based solely on two structural roles for &lt;a&gt;Context.Object&lt;/a&gt;s:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;Background&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;Foreground&lt;/em&gt;: where the "Protocol" or "Procedure" is implemented.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;Hence, the classification described above can be mapped with this terminology in the following way:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;Background&lt;/em&gt; is equivalent to the &lt;strong&gt;scenery role&lt;/strong&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;Foreground&lt;/em&gt; is equivalent to the &lt;strong&gt;character role&lt;/strong&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Context.Role">bci:Context.Role</a>
    /// </summary>
    let Context'_period_'Role = _prefixId.prefix "Context.Role"
    let Context'_period_'Role'_period_'POWDER = _prefixId.prefix "Context.Role.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;ol&gt;
    /// &lt;li&gt;"&lt;em&gt;In mathematics, a &lt;strong&gt;sequence&lt;/strong&gt; is an ordered collection of objects in which repetitions are allowed. &lt;br /&gt;(...) Unlike a set, order matters, and exactly the same elements can appear multiple times at different positions in the sequence&lt;/em&gt;". &lt;br /&gt;Reference: [&lt;a title="Sequence" target="_blank" href="https://en.wikipedia.org/wiki/Sequence"&gt;Wikipedia: Sequence&lt;/a&gt;]&lt;/li&gt;
    /// &lt;/ol&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>dcterms:source : [Unity]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.Scene.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : context scene^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;It is the architectural description of a specific part of a &lt;a&gt;Context&lt;/a&gt;, based on the dimension of &lt;span style="text-decoration: underline;"&gt;time&lt;/span&gt; (&lt;em&gt;temporality&lt;/em&gt;).
    ///
    /// &lt;br /&gt;A &lt;a&gt;Context&lt;/a&gt; is compose of a non-empty &lt;em&gt;sequence&lt;/em&gt; (see the editorial note) of &lt;a&gt;Context.Scene&lt;/a&gt;s.
    ///
    /// &lt;br /&gt;A &lt;a&gt;Context.Scene&lt;/a&gt; is related to other &lt;a&gt;Context.Scene&lt;/a&gt; based on its &lt;em&gt;temporality&lt;/em&gt;: occurrence in its sequence.
    ///
    /// &lt;br /&gt;A &lt;a&gt;Context.Scene&lt;/a&gt; object can be composed of multiple &lt;a&gt;Context.Scene&lt;/a&gt;s.
    ///
    /// &lt;br /&gt;A &lt;a&gt;Context.Scene&lt;/a&gt; corresponds to the notion of &lt;em&gt;World&lt;/em&gt; or &lt;em&gt;Level&lt;/em&gt; on a Gaming platform.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;ul&gt;
    /// &lt;li&gt;On a &lt;strong&gt;Simulation&lt;/strong&gt;: [driving a car in not-busy day on a freeway]; [driving a car in rush hour on a main city road].&lt;/li&gt;
    /// &lt;li&gt;On a &lt;strong&gt;Video Game&lt;/strong&gt;: &lt;em&gt;World&lt;/em&gt; 3; &lt;em&gt;Level&lt;/em&gt; 3-2.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>dcterms:title : Context.Scene^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:24 AM 2016-09-29 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Context.Scene">bci:Context.Scene</a>
    /// </summary>
    let Context'_period_'Scene = _prefixId.prefix "Context.Scene"
    let Context'_period_'Scene'_period_'POWDER = _prefixId.prefix "Context.Scene.POWDER"
    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : BCI data block^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;DataBlock&lt;/a&gt; represents the &lt;span style="text-decoration: underline;"&gt;basic/atomic physical data unit value&lt;/span&gt; of a &lt;a&gt;RecordedData&lt;/a&gt;.
    ///
    /// &lt;br /&gt;Hence and following the alignment with [&lt;b&gt;SSN&lt;/b&gt;], a &lt;a&gt;RecordedData&lt;/a&gt; [&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.10) Data module" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Data" target="_blank"&gt;&lt;strong&gt;has&lt;/strong&gt; &lt;em&gt;as for&lt;/em&gt; &lt;strong&gt;Value&lt;/strong&gt;&lt;/a&gt;] a non-empty &lt;em&gt;sequence&lt;/em&gt; (with not allowed repetitions) of &lt;a&gt;DataBlock&lt;/a&gt;s.&lt;/p&gt;
    ///
    /// &lt;p&gt;In the BCI domain:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;A &lt;a&gt;RecordedData&lt;/a&gt; is compose of a non-empty &lt;em&gt;sequence&lt;/em&gt; (with not allowed repetitions) of &lt;a&gt;DataBlock&lt;/a&gt;s.&lt;/li&gt;
    /// &lt;li&gt;A &lt;a&gt;DataBlock&lt;/a&gt; is considered a &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;physical&lt;/em&gt;&lt;/span&gt; data entity (whereas a &lt;a&gt;DataSegment&lt;/a&gt; is considered a &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;logical&lt;/span&gt;&lt;/em&gt; data entity).&lt;/li&gt;
    /// &lt;li&gt;A &lt;a&gt;DataBlock&lt;/a&gt; is related to another &lt;a&gt;DataBlock&lt;/a&gt; based on its &lt;em&gt;temporality&lt;/em&gt;: occurrence in its sequence. &lt;br /&gt;Therefore, a &lt;a&gt;DataBlock&lt;/a&gt; &lt;em&gt;may be&lt;/em&gt; &lt;span style="text-decoration: underline;"&gt;sequentially linked&lt;/span&gt; to a &lt;em&gt;following&lt;/em&gt; and a &lt;em&gt;previous&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;s.&lt;/li&gt;
    /// &lt;li&gt;All the &lt;span style="text-decoration: underline;"&gt;sequentially linked&lt;/span&gt; &lt;a&gt;DataBlock&lt;/a&gt;s compose the &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.10) Data module" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Data" target="_blank"&gt;&lt;em&gt;value&lt;/em&gt;&lt;/a&gt; of a &lt;a&gt;RecordedData&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;The mechanism to access a &lt;a&gt;DataBlock&lt;/a&gt; is the following:
    /// &lt;ol&gt;
    /// &lt;li&gt;First, one retrieves the &lt;em&gt;locator&lt;/em&gt;s of the &lt;a&gt;AccessMethod&lt;/a&gt;s associated to desired &lt;a&gt;RecordedData&lt;/a&gt;. With this, one can have the access to the "&lt;em&gt;data file&lt;/em&gt;".&lt;/li&gt;
    /// &lt;li&gt;Then, one can &lt;em&gt;derived&lt;/em&gt; the correspondent &lt;a&gt;DataBlock&lt;/a&gt;s locators, using the &lt;span style="text-decoration: underline;"&gt;positional attributes&lt;/span&gt;: &lt;em&gt;ordinal position&lt;/em&gt;, &lt;em&gt;offset&lt;/em&gt; or &lt;em&gt;timestamp.&lt;/em&gt;&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : DataBlock.png^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;Depending on its implementation nature, a BCI application may choose to use any (or both) of the &lt;span style="text-decoration: underline;"&gt;positional attributes&lt;/span&gt;:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a&gt;hasTimeStamp&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;hasOffset&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;"&lt;em&gt;In mathematics, a &lt;strong&gt;sequence&lt;/strong&gt; is an ordered collection of objects in which repetitions are allowed. &lt;br /&gt;(...) Unlike a set, order matters, and exactly the same elements can appear multiple times at different positions in the sequence&lt;/em&gt;". &lt;br /&gt;Reference: [&lt;a title="Sequence" target="_blank" href="https://en.wikipedia.org/wiki/Sequence"&gt;Wikipedia: Sequence&lt;/a&gt;]
    ///
    /// &lt;br /&gt;For this specific concept, a sequence of &lt;a&gt;DataBlock&lt;/a&gt;s &lt;span style="text-decoration: underline;"&gt;does not allow repetitions&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:30 AM 2016-10-12 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : DataBlock^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Data^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#DataBlock">bci:DataBlock</a>
    /// </summary>
    let DataBlock = _prefixId.prefix "DataBlock"
    let DataBlock'_period_'POWDER = _prefixId.prefix "DataBlock.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 11:58 PM 2016-08-17 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : BCI data format^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;A &lt;a&gt;DataFormat&lt;/a&gt; should properly define its &lt;a title="Code and the encoding process" href="https://en.wikipedia.org/wiki/Code" target="_blank"&gt;encoding scheme&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the data formats that BCI applications can use to represent and store the &lt;a&gt;RecordedData&lt;/a&gt;.
    ///
    /// &lt;br /&gt;This ontology defines some common data formats used in the BCI domain.^^rdfs:Literal</para>
    ///   <para>dcterms:title : DataFormat^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;This concept describes any &lt;a title="Data Format" href="https://en.wikipedia.org/wiki/Data_format" target="_blank"&gt;Data Format&lt;/a&gt; that BCI applications use to represent and store the &lt;a&gt;RecordedData&lt;/a&gt;.
    ///
    /// &lt;br /&gt;A &lt;a&gt;DataFormat&lt;/a&gt; represents any specific &lt;span style="text-decoration: underline;"&gt;standard data format&lt;/span&gt; used in one of the following ways:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Signal (electrical engineering).&lt;/li&gt;
    /// &lt;li&gt;File format.&lt;/li&gt;
    /// &lt;li&gt;Content format.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#DataFormat">bci:DataFormat</a>
    /// </summary>
    let DataFormat = _prefixId.prefix "DataFormat"
    let DataFormat'_period_'POWDER = _prefixId.prefix "DataFormat.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;It is a &lt;span style="text-decoration: underline;"&gt;logical data entity&lt;/span&gt; that group a set of &lt;span style="text-decoration: underline;"&gt;sequentially linked&lt;/span&gt; &lt;a&gt;DataBlock&lt;/a&gt;s, and thus, identifies a proper subset of a &lt;a&gt;RecordedData&lt;/a&gt;.
    ///
    /// &lt;br /&gt;A &lt;span style="text-decoration: underline;"&gt;time interval&lt;/span&gt; is implicitly found between the first &lt;a&gt;DataBlock&lt;/a&gt; (&lt;em&gt;startTime&lt;/em&gt;) and the last &lt;a&gt;DataBlock&lt;/a&gt; (&lt;em&gt;endTime&lt;/em&gt;) of the &lt;a&gt;DataSegment&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;In the BCI domain:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;A &lt;a&gt;DataSegment&lt;/a&gt; conforms the basic data unit for "&lt;em&gt;tagging&lt;/em&gt;" purposes, i. e., to associate semantic annotations (&lt;em&gt;event tags&lt;/em&gt; or &lt;em&gt;&lt;a&gt;Marker&lt;/a&gt;s&lt;/em&gt;) to the data (&lt;a&gt;DataBlock&lt;/a&gt; sets).&lt;/li&gt;
    /// &lt;li&gt;A &lt;a&gt;DataSegment&lt;/a&gt; is a collection of &lt;a&gt;DataBlock&lt;/a&gt;s that expands a certain &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;time interval&lt;/span&gt;&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;A &lt;a&gt;DataSegment&lt;/a&gt; is considered a &lt;em&gt;logical&lt;/em&gt; data entity (whereas a &lt;a&gt;DataBlock&lt;/a&gt; is considered a &lt;em&gt;physical&lt;/em&gt; data entity).&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;Right after a set of &lt;a&gt;DataSegment&lt;/a&gt;s is created, two consecutive tasks occur:
    /// &lt;ol&gt;
    /// &lt;li&gt;A set of &lt;em&gt;editing processes&lt;/em&gt; is run on the recordings, which classify the data sets based on different &lt;a&gt;Model&lt;/a&gt;s.&lt;/li&gt;
    /// &lt;li&gt;A set of &lt;a&gt;ResponseTag&lt;/a&gt;s is created, which capture the information related to "&lt;em&gt;what is so special about&lt;/em&gt;" a particular &lt;a&gt;DataSegment&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : DataSegment^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : DataSegment.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 10:05 PM 2016-06-12 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : data segment^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#DataSegment">bci:DataSegment</a>
    /// </summary>
    let DataSegment = _prefixId.prefix "DataSegment"
    let DataSegment'_period_'POWDER = _prefixId.prefix "DataSegment.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 01:30 AM 2016-06-30 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : Descriptor^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : descriptor of an external resource^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;[&lt;b&gt;XDF&lt;/b&gt;] and [&lt;b&gt;ESS&lt;/b&gt;] BCI applications may extend this concept based on its &lt;span style="text-decoration: underline;"&gt;purpose&lt;/span&gt; as an information object (&lt;em&gt;practical usage of the Web resource&lt;/em&gt;).
    /// &lt;br /&gt;Thus, some subclasses of this concept could be:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Annotation.&lt;/li&gt;
    /// &lt;li&gt;Channel locations.&lt;/li&gt;
    /// &lt;li&gt;Descriptive metadata.&lt;/li&gt;
    /// &lt;li&gt;Event instance.&lt;/li&gt;
    /// &lt;li&gt;Experiment note.&lt;/li&gt;
    /// &lt;li&gt;Specification.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [XDF]^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant type of &lt;a&gt;Descriptor&lt;/a&gt;s to capture specific external information that complements a metadata object.^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes an &lt;strong&gt;external Web resource&lt;/strong&gt; that complements the information related to a specific entity found in this ontology.
    /// &lt;br /&gt;In a general sense, represents a &lt;em&gt;class of information objects&lt;/em&gt; that describes &lt;span style="text-decoration: underline;"&gt;complementary&lt;/span&gt; external resources of the &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;metadata&lt;/em&gt;&lt;/span&gt;.
    /// &lt;br /&gt;Each individual of this class refers to an external file/document with extensive information to the associated metadata object.
    /// &lt;br /&gt;A &lt;a&gt;Descriptor&lt;/a&gt; can have a related &lt;a&gt;Descriptor&lt;/a&gt; set.&lt;/p&gt;
    ///
    /// &lt;p&gt;This concept is defined as a subclass of &lt;em&gt;DUL:InformationObject&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Descriptor">bci:Descriptor</a>
    /// </summary>
    let Descriptor = _prefixId.prefix "Descriptor"
    let Descriptor'_period_'POWDER = _prefixId.prefix "Descriptor.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Device.png^^rdfs:Literal</para>
    ///   <para>dcterms:description : ** HIDDEN CONTENT **
    /// ==============================================================================
    /// ** scopeNote **
    /// %CLASS_HIERARCHY% any relevant type of &lt;em&gt;BCI devices&lt;/em&gt; to measure specific &lt;a&gt;Modality&lt;/a&gt;(ies) for BCI activities, such as:
    /// &lt;ul&gt;
    /// &lt;li&gt;EEG (Electroencephalogram) device.&lt;/li&gt;
    /// &lt;li&gt;ECG (Electrocardiogram) device.&lt;/li&gt;
    /// &lt;li&gt;MoCap (Motion Capture) device. Example: &lt;em&gt;LeapMotion (MoCap) Tracker&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;Eye-Gaze device (for gaze or eye-tracking). Example: &lt;em&gt;EyeTribe&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;Audio device.&lt;/li&gt;
    /// &lt;li&gt;Video device.&lt;/li&gt;
    /// &lt;li&gt;Hand-Gesture device.&lt;/li&gt;
    /// &lt;li&gt;Keyboard device.&lt;/li&gt;
    /// &lt;li&gt;Mouse device.&lt;/li&gt;
    /// &lt;li&gt;Visual BCI device.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;p&gt;&lt;br /&gt;This ontology does not define all the &lt;em&gt;BCI devices&lt;/em&gt; listed above.&lt;/p&gt;
    /// ==============================================================================^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] A &lt;a&gt;Device&lt;/a&gt; is a physical piece of technology (a system in a box) that implements a &lt;em&gt;sensing method&lt;/em&gt; (therefore a
    /// &lt;a&gt;ssn:SensingDevice&lt;/a&gt;) and, thus,
    /// &lt;br /&gt;&lt;em&gt;observe&lt;/em&gt; some &lt;a&gt;Modality&lt;/a&gt; (a &lt;a&gt;ssn:Property&lt;/a&gt;) of an &lt;a&gt;Aspect&lt;/a&gt; (a &lt;a&gt;ssn:FeatureOfInterest&lt;/a&gt;).&lt;/p&gt;
    ///
    /// &lt;p&gt;In the BCI domain, a &lt;a&gt;Device&lt;/a&gt; is a physical &lt;em&gt;BCI device&lt;/em&gt; (or &lt;em&gt;sensor&lt;/em&gt;) that is used to measure BCI activities. &lt;br /&gt;A &lt;a&gt;Device&lt;/a&gt;, of course, collects data (represented by &lt;a&gt;RecordedData&lt;/a&gt;) in an &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;&lt;a&gt;ssn:Observation&lt;/a&gt;&lt;/em&gt;&lt;/span&gt; (a &lt;a&gt;Record&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF], [SSN], [Compton2009]^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] Based on the guidelines explained in the following examples:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;(&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.12) Device" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Device" target="_blank"&gt;5.3.12 Device&lt;/a&gt;),&lt;/li&gt;
    ///
    /// &lt;li&gt;(&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.1) University deployment example" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#University_deployment_example" target="_blank"&gt;5.4.1 University deployment example&lt;/a&gt; &amp;raquo; &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.1.3) Sensor" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Sensor" target="_blank"&gt;5.4.1.3 Sensor&lt;/a&gt;),&lt;/li&gt;
    ///
    /// &lt;li&gt;(&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2) Smart product example" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Smart_product_example" target="_blank"&gt;5.4.2 Smart product example&lt;/a&gt; &amp;raquo; &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2.2) Sensor" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Sensor_2" target="_blank"&gt;5.4.2.2 Sensor&lt;/a&gt;),&lt;/li&gt;
    ///
    /// &lt;li&gt;(&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.3) Wind sensor (WM30)" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Wind_sensor_.28WM30.29" target="_blank"&gt;5.4.3 Wind sensor (WM30)&lt;/a&gt; &amp;raquo; &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.3.2) Wind Sensor system" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Wind_Sensor_system" target="_blank"&gt;5.4.3.2 Wind Sensor system&lt;/a&gt;), and&lt;/li&gt;
    ///
    /// &lt;li&gt;(&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.4) Agriculture Meteorology Sensor Network" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Agriculture_Meteorology_Sensor_Network" target="_blank"&gt;5.4.4 Agriculture Meteorology Sensor Network&lt;/a&gt; &amp;raquo; &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.4.1.3) Sensor view" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Sensor_view" target="_blank"&gt;5.4.4.1.3 Sensor view&lt;/a&gt;),&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;Some of the &lt;span style="text-decoration: underline;"&gt;core restrictions&lt;/span&gt; modeled for &lt;a&gt;ssn:SensingDevice&lt;/a&gt; (&lt;a&gt;Device&lt;/a&gt;) are:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;For &lt;a&gt;ssn:MeasurementCapability&lt;/a&gt;, two distinct kinds of &lt;strong&gt;measurement capabilities&lt;/strong&gt; are identified and defined:
    /// &lt;ol&gt;
    /// &lt;li&gt;Those used for defining the &lt;strong&gt;Channeling Spec&lt;/strong&gt;: a set of &lt;a&gt;Channel&lt;/a&gt;s.
    /// &lt;br /&gt;These are associated indirectly via the &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; concept.&lt;/li&gt;
    /// &lt;li&gt;Other measurement capabilities not related to any channel definition: &lt;a&gt;NonChannel&lt;/a&gt;s.
    /// &lt;br /&gt;These are associated directly via a &lt;a&gt;ssn:hasMeasurementCapability&lt;/a&gt; sub property, as follow:
    /// &lt;br /&gt;&lt;a&gt;ssn:hasMeasurementCapability&lt;/a&gt; (&lt;a&gt;hasNonChannelData&lt;/a&gt;) &lt;span style="text-decoration: underline;"&gt;only&lt;/span&gt; &lt;a&gt;ssn:MeasurementCapability&lt;/a&gt; (&lt;a&gt;NonChannel&lt;/a&gt;): multiple instances.&lt;/li&gt;
    /// &lt;/ol&gt;&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;a&gt;ssn:observes&lt;/a&gt; (&lt;a&gt;observes&lt;/a&gt;) &lt;span style="text-decoration: underline;"&gt;only&lt;/span&gt; &lt;a&gt;ssn:Property&lt;/a&gt; (&lt;a&gt;Modality&lt;/a&gt;): for BCI, it's implied that it only has one instance.&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;a&gt;ssn:detects&lt;/a&gt; (&lt;a&gt;detects&lt;/a&gt;) &lt;span style="text-decoration: underline;"&gt;only&lt;/span&gt; &lt;a&gt;ssn:Stimulus&lt;/a&gt; (&lt;a&gt;StimulusEvent&lt;/a&gt;): multiple instances; details (what made) the &lt;a&gt;ssn:Sensor&lt;/a&gt; input.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;Additionally, it's important to highlight the following concepts:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;All &lt;span style="text-decoration: underline;"&gt;physical sensor devices&lt;/span&gt; are represented by the class &lt;a&gt;ssn:SensingDevice&lt;/a&gt; in the &lt;strong&gt;SSN&lt;/strong&gt; ontology.
    /// &lt;br /&gt;Instances of this class possess all properties of the classes &lt;a&gt;ssn:Sensor&lt;/a&gt; and &lt;a&gt;ssn:Device&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;[&lt;b&gt;Compton2009&lt;/b&gt;] According to the &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Sensor Ontology&lt;/em&gt;&lt;/span&gt;, a &lt;em&gt;sensor&lt;/em&gt; has a set of independent cluster of concepts:&lt;/p&gt;
    /// &lt;ol&gt;
    /// &lt;li&gt;Domain: &lt;em&gt;FeatureOfInterest&lt;/em&gt; and &lt;em&gt;PhysicalQuality&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;Abstract properties: &lt;em&gt;OperationModel&lt;/em&gt; that defines a &lt;em&gt;ResponseModel&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;Concrete properties: &lt;em&gt;SensorGrounding&lt;/em&gt;.&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;p&gt;A &lt;a&gt;Device&lt;/a&gt; in this ontology corresponds to the concepts for &lt;span style="text-decoration: underline;"&gt;Abstract properties&lt;/span&gt; (#2).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:32 AM 2016-08-11 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant type of &lt;em&gt;BCI devices&lt;/em&gt; to measure specific &lt;a&gt;Modality&lt;/a&gt;(ies) for BCI activities.^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : BCI device^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : Device^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Device">bci:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    let Device'_period_'POWDER = _prefixId.prefix "Device.POWDER"
    /// <summary>
    ///   <para>dcterms:title : DeviceChannelingSpec^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : device channeling schema spec^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;Theoretically, a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; could be defined as a specialized &lt;a&gt;DeviceSpec&lt;/a&gt; concept.
    /// &lt;br /&gt;However, for practical reasons, this ontology aligns the definition of its first information set with &lt;a&gt;ChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant type of a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; to capture the external information that defines the &lt;em&gt;channeling schema&lt;/em&gt; information of a &lt;a&gt;Device&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literaldctype:StillImage : Aspect-and-Modality.png^^rdfs:Literaldctype:StillImage : Device.png^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Device^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:13 PM 2016-08-08 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Each &lt;a&gt;Device&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;supports&lt;/span&gt; a specific &lt;em&gt;channeling schema&lt;/em&gt; information:
    /// &lt;br /&gt;all the supported logical components (&lt;a&gt;Channel&lt;/a&gt;s) and their extended metadata that describe a "more concrete" subset of its &lt;em&gt;&lt;a&gt;Modality&lt;/a&gt;'s data structure model and template&lt;/em&gt;,
    /// &lt;br /&gt;based on the &lt;a&gt;Device&lt;/a&gt;'s own physical spec of its operational features and functionalities.&lt;/p&gt;
    ///
    /// &lt;p&gt;A &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; captures two information sets for a specific &lt;a&gt;Device&lt;/a&gt;:&lt;/p&gt;
    /// &lt;ol&gt;
    /// &lt;li&gt;Its complete &lt;em&gt;channeling schema&lt;/em&gt; description, in a form of an external document specification (outside the metadata repository): a specialized &lt;a&gt;Descriptor&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;Relevant metadata attributes regarding the &lt;span style="text-decoration: underline;"&gt;specific characteristics&lt;/span&gt; of the &lt;a&gt;Device&lt;/a&gt;'s &lt;em&gt;channeling schema&lt;/em&gt;: a set of related &lt;a&gt;Channel&lt;/a&gt;s.&lt;/li&gt;&lt;/ol&gt;
    ///
    /// &lt;p&gt;The &lt;span style="text-decoration: underline;"&gt;structure&lt;/span&gt; described in a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; (first information set mentioned above) is a &lt;em&gt;functional subset&lt;/em&gt; of the &lt;a&gt;ChannelingSpec&lt;/a&gt;
    /// &lt;br /&gt;defined for the &lt;a&gt;Modality&lt;/a&gt; that the &lt;a&gt;Device&lt;/a&gt; supports, following the [&lt;b&gt;SSN&lt;/b&gt;] data model. Hence, for practical reasons, a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; is defined as a &lt;em&gt;subclass&lt;/em&gt; of &lt;a&gt;ChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#DeviceChannelingSpec">bci:DeviceChannelingSpec</a>
    /// </summary>
    let DeviceChannelingSpec = _prefixId.prefix "DeviceChannelingSpec"

    let DeviceChannelingSpec'_period_'POWDER = _prefixId.prefix "DeviceChannelingSpec.POWDER"

    /// <summary>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literaldctype:StillImage : Device.png^^rdfs:Literal</para>
    ///   <para>dcterms:description : ** HIDDEN CONTENT **
    /// ==============================================================================
    /// ** scopeNote **
    ///
    /// &lt;li&gt;&lt;strong&gt;Manufacturer&lt;/strong&gt; (source [&lt;b&gt;XDF&lt;/b&gt;], [&lt;b&gt;ESS&lt;/b&gt;]): manufacturer of the sensor (device).
    /// &lt;br /&gt;{ &lt;em&gt;History note&lt;/em&gt; }
    /// &lt;ul&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS 1.0&lt;/b&gt;] Corresponds to the (&lt;em&gt;/study/summary/recordedModalities/modality/recordingDevice&lt;/em&gt;) node definition: &lt;br /&gt;name or type of recording device used to acquire data (&lt;span style="text-decoration: underline;"&gt;manufacturer name&lt;/span&gt;).&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS 2.0&lt;/b&gt;] Corresponds to the (&lt;em&gt;/study/recordingParameterSets/recordingParameterSet/channelType/modality/name&lt;/em&gt;) node definition: &lt;br /&gt;the name (brand) of the sensor device. For example: BioSemi, OptiTrack, SMI, etc.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    ///
    /// ==============================================================================^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;ul&gt;
    /// &lt;li&gt;The &lt;em&gt;channeling schema&lt;/em&gt; that supports a &lt;a&gt;Device&lt;/a&gt; is defined as an independent component from the &lt;a&gt;DeviceSpec&lt;/a&gt;.
    /// &lt;br /&gt;A &lt;a&gt;Device&lt;/a&gt;'s &lt;em&gt;channeling schema&lt;/em&gt; (&lt;strong&gt;DeviceChannelingSchema&lt;/strong&gt;) is a &lt;em&gt;subset&lt;/em&gt; of the generic &lt;strong&gt;ChannelingSchema&lt;/strong&gt; defined for its correspondent &lt;a&gt;Modality&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;This ontology does not define any information object in particular of a &lt;a&gt;DeviceSpec&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : device specification^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN], [XDF], [ESS]^^rdfs:Literal</para>
    ///   <para>dcterms:title : DeviceSpec^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% specific types of &lt;a&gt;DeviceSpec&lt;/a&gt;.
    /// ^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;], [&lt;b&gt;XDF&lt;/b&gt;] A &lt;a&gt;DeviceSpec&lt;/a&gt; is a &lt;a&gt;ssn:SensorDataSheet&lt;/a&gt; (information object) that records (describes) specific properties (such as: hardware specs, power used, types of connectors, etc.) of a &lt;a&gt;Device&lt;/a&gt;.
    ///
    /// &lt;br /&gt;It has been modeled as a composite object so that it can be composed as a set of &lt;a&gt;DeviceSpec&lt;/a&gt;s to describe specific parts of a &lt;a&gt;Device&lt;/a&gt;. In this way, a &lt;a&gt;DeviceSpec&lt;/a&gt; is considered as a &lt;em&gt;bag&lt;/em&gt; of descriptive properties about the &lt;a&gt;Device&lt;/a&gt;.
    ///
    /// &lt;br /&gt;A &lt;a&gt;DeviceSpec&lt;/a&gt; is a specialized &lt;a&gt;Descriptor&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;The relevant set of a &lt;a&gt;Device&lt;/a&gt;'s properties are recorded directly (with  &lt;a&gt;hasChannelData&lt;/a&gt; and &lt;a&gt;hasNonChannelData&lt;/a&gt;), but the &lt;a&gt;DeviceSpec&lt;/a&gt;s can be used to record any other descriptive information related to the physical device, such as:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;to record the manufacturers specifications verses observed capabilites, or&lt;/li&gt;
    /// &lt;li&gt;if more is known than the manufacturer specifies, etc.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;Some BCI applications based on [&lt;b&gt;XDF&lt;/b&gt;], find important to keep information regarding the &lt;em&gt;hardware&lt;/em&gt; specifications of its &lt;a&gt;Device&lt;/a&gt;s.
    /// &lt;br /&gt;Hence, a BCI application could define a classification for different type of specifications, such as:
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Hardware specs&lt;/span&gt;:
    /// &lt;ol&gt;
    /// &lt;li&gt;&lt;strong&gt;Manufacturer&lt;/strong&gt; (source [&lt;b&gt;XDF&lt;/b&gt;], [&lt;b&gt;ESS&lt;/b&gt;]): manufacturer of the sensor (device).&lt;/li&gt;
    /// &lt;li&gt;&lt;strong&gt;Material&lt;/strong&gt; (source [&lt;b&gt;XDF&lt;/b&gt;]): conductive material of the sensor (e.g. Ag-AgCl, Foam, Plastic, Rubber).&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;Model&lt;/a&gt; (source [&lt;b&gt;XDF&lt;/b&gt;]): model of the sensor.&lt;/li&gt;
    /// &lt;li&gt;&lt;strong&gt;Serial number&lt;/strong&gt; (source [&lt;b&gt;XDF&lt;/b&gt;]): serial number of the device. Its generalization was taken from the description of the "&lt;span style="text-decoration: underline;"&gt;Gaze meta data&lt;/span&gt;".&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;Ownership specs&lt;/span&gt;:
    /// &lt;ol&gt;
    /// &lt;li&gt;&lt;strong&gt;Name / Label&lt;/strong&gt;: a logical human-readable name or label of the device.&lt;/li&gt;
    /// &lt;li&gt;&lt;strong&gt;Organization&lt;/strong&gt;: organization name that owns the device.&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:21 AM 2016-06-29 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Device^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#DeviceSpec">bci:DeviceSpec</a>
    /// </summary>
    let DeviceSpec = _prefixId.prefix "DeviceSpec"
    let DeviceSpec'_period_'POWDER = _prefixId.prefix "DeviceSpec.POWDER"
    /// <summary>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant &lt;a&gt;EegChannel&lt;/a&gt;s, based on specialized &lt;a&gt;EegModality&lt;/a&gt;(ies), that BCI applications may require.^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 08:25 AM 2016-08-14 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Defines a broader type of an &lt;span style="text-decoration: underline;"&gt;EEG Channel&lt;/span&gt; (channeling scheme information component), used in BCI applications to collect EEG (&lt;a title="Electroencephalography" href="https://en.wikipedia.org/wiki/Electroencephalography" target="_blank"&gt;Electroencephalography&lt;/a&gt;) data.&lt;/p&gt;
    ///
    /// &lt;p&gt;This concept relates directly to the &lt;a title="Multi-Channel EEG (BCI) Devices" href="http://neurosky.com/2015/07/multi-channel-eeg-bci-devices/" target="_blank"&gt;notion&lt;/a&gt;&amp;nbsp;of an electrode capturing brainwave activity.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF], [ESS]^^rdfs:Literal</para>
    ///   <para>dcterms:title : EegChannel^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : EEG channel^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;BCI applications based on [&lt;b&gt;ESS&lt;/b&gt;] and [&lt;b&gt;XDF&lt;/b&gt;], could define the following channeling metadata attributes for an &lt;a&gt;EegModality&lt;/a&gt; spec:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;Label&lt;/em&gt;:
    /// &lt;ul&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS 2.0&lt;/b&gt;]: a comma separated list of labels corresponding channels. This node is required for &lt;em&gt;EEG Modality&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;XDF&lt;/b&gt;]: EEG channel label, according to the &lt;span style="text-decoration: underline;"&gt;labeling scheme&lt;/span&gt;. For EEG, the preferred labeling scheme is 10-20 (or the finer-grained 10-5).&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;em&gt;Placement&lt;/em&gt;:
    /// &lt;ul&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS 2.0&lt;/b&gt;]: location of the reference channel or channels used during EEG or ECG recording. Should only be provided if the &lt;span style="text-decoration: underline;"&gt;ModalitySignalType&lt;/span&gt; (&lt;a&gt;Modality&lt;/a&gt;) is EEG or ECG.
    /// &lt;br /&gt;For EEG, the preferred location convention is presented below. Choose between the following values (or provide a new value if the reference is not any of these options):
    /// &lt;br /&gt;&lt;em&gt;{&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Right Mastoid",&lt;/em&gt;&lt;br /&gt;&lt;em&gt; "Left Mastoid",&lt;/em&gt;&lt;br /&gt;&lt;em&gt; "Mastoids",&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Linked Mastoids"&lt;/em&gt; [for electrically linked mastoids]&lt;em&gt;,&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Cz"&lt;/em&gt; [top of the head]&lt;em&gt;,&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"CMS"&lt;/em&gt; [e.g. in BIOSEMI]&lt;em&gt;,&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Left Ear",&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Right Ear",&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Ears",&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Average",&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Nasion",&lt;/em&gt;&lt;br /&gt;&lt;em&gt;"Nose"&lt;/em&gt;&lt;br /&gt;&lt;em&gt;}&lt;/em&gt;.
    /// &lt;br /&gt;For Wilson Central Terminal ECG reference use "&lt;em&gt;WCT&lt;/em&gt;".&lt;/li&gt;
    ///
    /// &lt;li&gt;[&lt;b&gt;XDF&lt;/b&gt;]:
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;{ LocationX, LocationY, LocationZ }&lt;/em&gt;: 3D position (measured location) of the electrode on the head's surface based on a coordinate system (frame of reference). Each value is described as:
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;{ LocationX }&lt;/em&gt;: coordinate axis pointing from the center of the head to the &lt;span style="text-decoration: underline;"&gt;right&lt;/span&gt;, in millimeters.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ LocationY }&lt;/em&gt;: coordinate axis pointing from the center of the head to the &lt;span style="text-decoration: underline;"&gt;front&lt;/span&gt;, in millimeters.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;{ LocationZ }&lt;/em&gt;: coordinate axis pointing from the center of the head to the &lt;span style="text-decoration: underline;"&gt;top&lt;/span&gt;, in millimeters.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// XDF states that if the used coordinate system is arbitrary, the application should then include well-known &lt;em&gt;fiducials (landmarks)&lt;/em&gt; for co-registration.&lt;/li&gt;
    /// &lt;li&gt;&lt;em&gt;LocationType = { 10-10, 10-20, 10-5, Custom, EGI }&lt;/em&gt;: channel location type/standard used.&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    ///
    /// &lt;li&gt;[&lt;b&gt;XDF&lt;/b&gt;] &lt;em&gt;ChannelFormat = { double64, float32, int16, int32, int64, int8, string }&lt;/em&gt;: corresponds to the &lt;em&gt;&amp;lt;channel_format&amp;gt;&lt;/em&gt; field of the &lt;span style="text-decoration: underline;"&gt;StreamHeader&lt;/span&gt; chunk section. It's one of the 3 required fields in the XDF header.&lt;/li&gt;
    ///
    /// &lt;li&gt;[&lt;b&gt;XDF&lt;/b&gt;] &lt;em&gt;Signal Referencing Scheme&lt;/em&gt;:
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;isCommonAverage&lt;/span&gt;: (&lt;em&gt;boolean&lt;/em&gt; data type); "&lt;em&gt;true&lt;/em&gt;" if the subtracted reference signal was a common average, otherwise "&lt;em&gt;false&lt;/em&gt;".&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;isSubtracted&lt;/span&gt;: (&lt;em&gt;boolean&lt;/em&gt; data type); "&lt;em&gt;true&lt;/em&gt;" if a reference signal has already been subtracted from the data, otherwise "&lt;em&gt;false&lt;/em&gt;".&lt;/li&gt;
    /// &lt;/ul&gt;&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;BCI applications should include their &lt;span style="text-decoration: underline;"&gt;own relevant dictionaries&lt;/span&gt; (placement, formats, etc.), as part of their proprietary extended semantic definitions.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#EegChannel">bci:EegChannel</a>
    /// </summary>
    let EegChannel = _prefixId.prefix "EegChannel"
    let EegChannel'_period_'POWDER = _prefixId.prefix "EegChannel.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dcterms:title : EegDevice^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : EEG device^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant &lt;a&gt;EegDevice&lt;/a&gt;s, based on specialized &lt;a&gt;EegModality&lt;/a&gt;(ies), that BCI applications may require.^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Device.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:51 AM 2016-08-05 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Defines a broader type of an &lt;span style="text-decoration: underline;"&gt;EEG Device&lt;/span&gt;, used in BCI applications to collect EEG (&lt;a title="Electroencephalography" href="https://en.wikipedia.org/wiki/Electroencephalography" target="_blank"&gt;Electroencephalography&lt;/a&gt;) data.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#EegDevice">bci:EegDevice</a>
    /// </summary>
    let EegDevice = _prefixId.prefix "EegDevice"
    let EegDevice'_period_'POWDER = _prefixId.prefix "EegDevice.POWDER"
    /// <summary>
    ///   <para>dcterms:title : EegModality^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant &lt;b&gt;EEG modalities&lt;/b&gt;.
    /// &lt;br /&gt;Following, we present a possible classification for this type:
    ///
    /// &lt;ol&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;ERP&lt;/span&gt; (&lt;em&gt;Event Related Potential&lt;/em&gt; -voltage-): related to a stimuli.
    /// &lt;ol style="list-style-type: lower-alpha;"&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;VEP&lt;/span&gt;: Video.
    /// &lt;ol style="list-style-type: lower-roman;"&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;SSVEP&lt;/span&gt;: &lt;em&gt;Steady-State&lt;/em&gt;. Caused by Flickering Visual Stimuli (2 different stimuli). Applications: &lt;span style="text-decoration: underline;"&gt;Migraine&lt;/span&gt; (SSVE MSE - Complexity) and &lt;span style="text-decoration: underline;"&gt;Glaucoma&lt;/span&gt; (mfVEP - Vision Field Sensitivity).&lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;TVEP&lt;/span&gt;: &lt;em&gt;Transient&lt;/em&gt;.&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/li&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;AEP&lt;/span&gt;: Aural&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/li&gt;
    /// &lt;li&gt;"Free Run".&lt;/li&gt;
    /// &lt;/ol&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : EEG modality^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:30 AM 2016-10-12 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A specific type of &lt;a&gt;Modality&lt;/a&gt; for &lt;b&gt;EEG&lt;/b&gt; (&lt;a title="Electroencephalography" href="https://en.wikipedia.org/wiki/Electroencephalography" target="_blank"&gt;Electroencephalography&lt;/a&gt;).
    ///
    /// &lt;br /&gt;This modality can be further classified depending on different measurement procedures, applications and set of stimuli.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#EegModality">bci:EegModality</a>
    /// </summary>
    let EegModality = _prefixId.prefix "EegModality"
    let EegModality'_period_'POWDER = _prefixId.prefix "EegModality.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant &lt;a&gt;NonChannel&lt;/a&gt;s specific for an &lt;a&gt;EegDevice&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : non-channeling EEG data component (other EEG measurement capability)^^rdfs:Literal</para>
    ///   <para>dcterms:title : EegNonChannel^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;The &lt;a&gt;NonChannel&lt;/a&gt; of a specific &lt;a&gt;EegDevice&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:03 AM 2016-08-10 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#EegNonChannel">bci:EegNonChannel</a>
    /// </summary>
    let EegNonChannel = _prefixId.prefix "EegNonChannel"
    let EegNonChannel'_period_'POWDER = _prefixId.prefix "EegNonChannel.POWDER"
    /// <summary>
    ///   <para>dcterms:title : EegRecord^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Defines a broader type of an &lt;span style="text-decoration: underline;"&gt;EEG Record&lt;/span&gt;, which represents the class of observations for EEG (&lt;a title="Electroencephalography" href="https://en.wikipedia.org/wiki/Electroencephalography" target="_blank"&gt;Electroencephalography&lt;/a&gt;) data.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : EEG record^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:09 AM 2016-08-05 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant &lt;a&gt;EegRecord&lt;/a&gt;s, based on specialized &lt;a&gt;EegModality&lt;/a&gt;(ies), that BCI applications may require.^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#EegRecord">bci:EegRecord</a>
    /// </summary>
    let EegRecord = _prefixId.prefix "EegRecord"
    let EegRecord'_period_'POWDER = _prefixId.prefix "EegRecord.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes the classification of &lt;a&gt;EmotionalAspect&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : emotional aspect^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:56 AM 2016-05-24 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the &lt;a&gt;EmotionalAspect&lt;/a&gt;s of the &lt;a&gt;Record&lt;/a&gt;s.^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : EmotionalAspect^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#EmotionalAspect">bci:EmotionalAspect</a>
    /// </summary>
    let EmotionalAspect = _prefixId.prefix "EmotionalAspect"
    let EmotionalAspect'_period_'POWDER = _prefixId.prefix "EmotionalAspect.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : Interaction of multiple subjects^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;em&gt;situation&lt;/em&gt; where multiple (more than one) &lt;a&gt;Subject&lt;/a&gt;s interact with each other, while each is performing a single &lt;a&gt;Activity&lt;/a&gt;.
    ///
    /// &lt;br /&gt;Commonly, it's expected that all the &lt;a&gt;Subject&lt;/a&gt;s in an &lt;a&gt;Interaction&lt;/a&gt; engage in the same &lt;a&gt;Activity&lt;/a&gt;, but it's not required.&lt;/p&gt;
    ///
    /// &lt;p&gt;Due that an &lt;a&gt;Interaction&lt;/a&gt; group a set of &lt;a&gt;Session&lt;/a&gt;s (potentially many for each &lt;a&gt;Subject&lt;/a&gt;), BCI applications can make correlations among these &lt;a&gt;Session&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : Interaction^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Subject.png^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;This concept defines a &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;Cluster&lt;/span&gt;&lt;/em&gt; of &lt;a&gt;Session&lt;/a&gt;s: a &lt;em&gt;cross-sectional&lt;/em&gt; collection of multiple related &lt;a&gt;Session&lt;/a&gt;s that occur at the same time.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:05 AM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : Session,Subject^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Interaction">bci:Interaction</a>
    /// </summary>
    let Interaction = _prefixId.prefix "Interaction"
    let Interaction'_period_'POWDER = _prefixId.prefix "Interaction.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Corresponds to the "&lt;em&gt;entry points&lt;/em&gt;" of the &lt;span style="text-decoration: underline;"&gt;semantic annotations&lt;/span&gt; (e&lt;em&gt;vent tags&lt;/em&gt;) related to a specific &lt;a&gt;DataSegment&lt;/a&gt;. &lt;br /&gt;This concept captures the &lt;span style="text-decoration: underline;"&gt;annotation tags&lt;/span&gt; of the data.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:10 PM 2016-05-25 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the type of &lt;a&gt;Marker&lt;/a&gt;s (or &lt;em&gt;Annotation Tag&lt;/em&gt;s)
    /// that define "&lt;em&gt;entry point&lt;/em&gt;s" in &lt;a&gt;DataSegment&lt;/a&gt;s.
    ///
    /// &lt;br /&gt;This ontology defines two types of &lt;a&gt;Marker&lt;/a&gt;s: the &lt;a&gt;ResponseTag&lt;/a&gt; and the &lt;a&gt;StimulusTag&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : Marker^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : annotation tag (or data segment pointer)^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Marker">bci:Marker</a>
    /// </summary>
    let Marker = _prefixId.prefix "Marker"
    let Marker'_period_'POWDER = _prefixId.prefix "Marker.POWDER"
    /// <summary>
    ///   <para>skos:historyNote : &lt;p&gt;[&lt;b&gt;ESS 1.0&lt;/b&gt;]:
    /// &lt;ul&gt;
    /// &lt;li&gt;This data object describes the name of the different &lt;span style="text-decoration: underline;"&gt;type of modalities&lt;/span&gt; recorded in a study. Corresponds to the (&lt;em&gt;/study/summary/recordedModalities/modality/name&lt;/em&gt;) node definition.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/p&gt;
    ///
    /// &lt;p&gt;[&lt;b&gt;ESS 2.0&lt;/b&gt;]:
    /// &lt;ul&gt;
    /// &lt;li&gt;It contains information about one or more &lt;span style="text-decoration: underline;"&gt;set of recording data parameters&lt;/span&gt; (which can apply to multiple &lt;a&gt;Record&lt;/a&gt;s).&lt;/li&gt;
    /// &lt;li&gt;Corresponds to the (&lt;em&gt;/study/recordingParameterSets/recordingParameterSet&lt;/em&gt;) node definition.&lt;/li&gt;
    /// &lt;li&gt;Most studies have only a single parameter set, i. e., the same types of data (EEG, Mocap, etc.) are recorded in the same channel ranges, with the same device types and with the same sampling rates.&lt;/li&gt;
    /// &lt;li&gt;This "&lt;em&gt;recordings parameter set&lt;/em&gt;" is associated with &lt;a&gt;Record&lt;/a&gt;s nodes (which represent the "&lt;em&gt;dataRecording&lt;/em&gt;" nodes).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;The following descriptions capture the definition of this concept ([&lt;strong&gt;SSN&lt;/strong&gt;: &lt;a title="Semantic Sensor Network Ontology &amp;raquo; Property" href="https://www.w3.org/2005/Incubator/ssn/ssnx/ssn#Property" target="_blank"&gt;Property&lt;/a&gt;] and [&lt;b&gt;Compton2009&lt;/b&gt;]) adjusted to this ontology:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;An observable Quality of human physiological signals.
    /// &lt;br /&gt;That is, a characteristic of an &lt;a&gt;Aspect&lt;/a&gt; (human body's state) that is intrinsic to and cannot exist without the &lt;a&gt;Aspect&lt;/a&gt; and is observable by a &lt;a&gt;Device&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;Device&lt;/a&gt;s observe physiological signals (&lt;a&gt;Modality&lt;/a&gt;-ies) of &lt;a&gt;Aspect&lt;/a&gt;s: for example, the EEG signals (&lt;a&gt;Modality&lt;/a&gt;) of an emotion (&lt;a&gt;Aspect&lt;/a&gt;).&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literalskos:editorialNote : %GENERAL_COMMENT%@ASPECT-and-MODALITY^^rdfs:Literalskos:editorialNote : &lt;p&gt;A &lt;a&gt;Modality&lt;/a&gt; has its own specific:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Measurement procedures,&lt;/li&gt;
    /// &lt;li&gt;Applications (each one with relevant attributes), and&lt;/li&gt;
    /// &lt;li&gt;Stimuli.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:description : ** HIDDEN CONTENT **
    /// ==============================================================================
    /// ** scopeNote **
    /// %CLASS_HIERARCHY% any relevant type of human signals (&lt;em&gt;Modality Signal Type&lt;/em&gt; &amp;mdash;&lt;em&gt;nature of the data&lt;/em&gt;&amp;mdash;) analyzed by BCI applications, such as:
    /// &lt;ul&gt;
    /// &lt;li&gt;EEG (Electroencephalogram).&lt;/li&gt;
    /// &lt;li&gt;ECG (Electrocardiogram).&lt;/li&gt;
    /// &lt;li&gt;MoCap (Motion Capture).&lt;/li&gt;
    /// &lt;li&gt;Eye-Gaze (for gaze or eye-tracking).&lt;/li&gt;
    /// &lt;li&gt;Audio.&lt;/li&gt;
    /// &lt;li&gt;Video.&lt;/li&gt;
    /// &lt;li&gt;Hand-Gesture.&lt;/li&gt;
    /// &lt;li&gt;Keyboard-Hit.&lt;/li&gt;
    /// &lt;li&gt;Mouse-Click.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;br /&gt;This ontology does not define all the modalities listed above.
    /// ==============================================================================^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN], [Compton2009]^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;]: A &lt;a&gt;Modality&lt;/a&gt; is a kind of an "&lt;em&gt;Observable Quality&lt;/em&gt;", i. e., an aspect (the human signals) of an entity (the human body) that is intrinsic to and cannot exist without the entity and is observable by a sensor (&lt;a&gt;Device&lt;/a&gt;).&lt;/p&gt;
    ///
    /// &lt;p&gt;In the BCI domain, the &lt;a&gt;Modality&lt;/a&gt; defines a certain type of measurement (&lt;em&gt;classification&lt;/em&gt;) related to a specific kind of data due to its nature. Literally, &lt;a&gt;Modality&lt;/a&gt; means the "&lt;em&gt;&lt;span style="text-decoration: underline;"&gt;Mode of the data&lt;/span&gt;&lt;/em&gt;".
    ///
    ///  &lt;br /&gt;The &lt;a&gt;Modality&lt;/a&gt; defines, in an intrinsic manner, the operational functionality of any &lt;a&gt;Device&lt;/a&gt; based on its related &lt;a&gt;ChannelingSpec&lt;/a&gt; information. That is, a specific type of &lt;a&gt;Device&lt;/a&gt; operates for a specific type of &lt;a&gt;Modality&lt;/a&gt;: the nature of the data sensed.&lt;/p&gt;
    ///
    /// &lt;p&gt;Each &lt;a&gt;Modality&lt;/a&gt; must have its own complete and generic &lt;a&gt;ChannelingSpec&lt;/a&gt; information.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : Modality^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:19 AM 2016-08-20 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : recorded modality^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant type of human signals (&lt;em&gt;Modality Signal Type&lt;/em&gt; &amp;mdash;&lt;em&gt;nature of the data&lt;/em&gt;&amp;mdash;) analyzed by BCI applications.^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Modality">bci:Modality</a>
    /// </summary>
    let Modality = _prefixId.prefix "Modality"
    let Modality'_period_'POWDER = _prefixId.prefix "Modality.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : model^^rdfs:Literal</para>
    ///   <para>dcterms:title : Model^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;In the BCI domain, all the Machine Learning processes can generate many different results. These results are called "&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Features&lt;/em&gt;&lt;/span&gt;". &lt;br /&gt;A &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;feature&lt;/em&gt;&lt;/span&gt; is a transient information object, i.e., it has an expiration date. &lt;br /&gt;This concept is not defined in this ontology.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;Right after a set of &lt;a&gt;DataSegment&lt;/a&gt;s is created, two consecutive tasks occur:
    /// &lt;ol&gt;
    /// &lt;li&gt;A set of &lt;em&gt;editing processes&lt;/em&gt; is run on the recordings, which classify the data sets based on different &lt;a&gt;Model&lt;/a&gt;s.&lt;/li&gt;
    /// &lt;li&gt;A set of &lt;a&gt;ResponseTag&lt;/a&gt;s ;is created, which capture the information related to "&lt;em&gt;what is so special about&lt;/em&gt;" a particular &lt;a&gt;DataSegment&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes a Machine Learning Model that "&lt;em&gt;detects something&lt;/em&gt;" in a &lt;a&gt;DataSegment&lt;/a&gt;.
    ///
    /// &lt;br /&gt;A common name given for a &lt;a&gt;Model&lt;/a&gt; is &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;Classifier&lt;/span&gt;&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Model.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:48 PM 2016-05-22 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Model">bci:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    let Model'_period_'POWDER = _prefixId.prefix "Model.POWDER"
    /// <summary>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the &lt;a&gt;NeurologicalAspect&lt;/a&gt;s of the &lt;a&gt;Record&lt;/a&gt;s.^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes the classification of &lt;a&gt;NeurologicalAspect&lt;/a&gt;s. One application for this &lt;a&gt;Aspect&lt;/a&gt; is &lt;span style="text-decoration: underline;"&gt;glaucoma monitoring&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:47 AM 2016-05-24 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : neurological aspect^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:title : NeurologicalAspect^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#NeurologicalAspect">bci:NeurologicalAspect</a>
    /// </summary>
    let NeurologicalAspect = _prefixId.prefix "NeurologicalAspect"

    let NeurologicalAspect'_period_'POWDER = _prefixId.prefix "NeurologicalAspect.POWDER"

    /// <summary>
    ///   <para>ov:part : SSN-MeasurementCapability^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% a set of relevant &lt;b&gt;non-channeling measurement capabilities&lt;/b&gt; for each type of &lt;a&gt;Device&lt;/a&gt;.
    /// ^^rdfs:Literal</para>
    ///   <para>dcterms:title : NonChannel^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : non-channeling data component (other BCI measurement capability)^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] The &lt;a&gt;NonChannel&lt;/a&gt; of any &lt;a&gt;Device&lt;/a&gt; describes a set of &lt;em&gt;measurement properties&lt;/em&gt; (&lt;a&gt;ssn:MeasurementProperty&lt;/a&gt;) of a &lt;em&gt;sensor&lt;/em&gt; (&lt;a&gt;ssn:Sensor&lt;/a&gt;) in specific conditions, as explained in &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.5) MeasuringCapability" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#MeasuringCapability" target="_blank"&gt;SSN MeasuringCapability module&lt;/a&gt;, that are not related directly to any &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.
    ///
    /// &lt;br /&gt;Note that the &lt;em&gt;measurement properties&lt;/em&gt; describe in this concept are of a &lt;em&gt;sensor&lt;/em&gt; (&lt;a&gt;Device&lt;/a&gt; subclass of
    /// &lt;a&gt;ssn:Sensor&lt;/a&gt;), not of a &lt;em&gt;specific observed measurement&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt; subclass of &lt;a&gt;ssn:Observation&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:description : ** HIDDEN CONTENT **
    /// ==============================================================================
    /// ** editorialNote **
    /// &lt;p&gt;The BCI ontology defines this modeling structure for &lt;em&gt;EEG Devices&lt;/em&gt;: see the definition of the Object Property &lt;a&gt;hasEegNonChannelData&lt;/a&gt;.&lt;/p&gt;
    /// ==============================================================================^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@UNITS-OF-MEASUREMENT^^rdfs:Literalskos:editorialNote : &lt;p&gt;This ontology leaves open to BCI applications the way how they should describe properly basic &lt;b&gt;non-channeling measurement capabilities&lt;/b&gt; for its relevant set of different classes of sensors (&lt;a&gt;Device&lt;/a&gt; class hierarchy) used in BCI activities, following the description of the &lt;em&gt;&lt;a&gt;ssn:MeasurementCapability&lt;/a&gt;&lt;/em&gt; concept found at:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;(&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.5) MeasuringCapability" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#MeasuringCapability" target="_blank"&gt;5.3.5 MeasuringCapability&lt;/a&gt; &amp;raquo;
    /// &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.5.2) How to describe capabilities of a sensor?" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#How_to_describe_capabilities_of_a_sensor.3F" target="_blank"&gt;5.3.5.2 How to describe capabilities of a sensor?&lt;/a&gt;),&lt;/li&gt;
    /// &lt;li&gt;(&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2) Smart product example" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Smart_product_example" target="_blank"&gt;5.4.2 Smart product example&lt;/a&gt; &amp;raquo;
    /// &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2.3) Measurement capabilities" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Measurement_capabilities" target="_blank"&gt;5.4.2.3 Measurement capabilities&lt;/a&gt;).&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;blockquote class="remark"&gt;The &lt;span style="text-decoration: underline;"&gt;sensor ontology&lt;/span&gt; does not restrict the way in which specific &lt;em&gt;measurement properties&lt;/em&gt; (&lt;a&gt;ssn:MeasurementProperty&lt;/a&gt;) are described.
    /// &lt;br /&gt;Thus, specialized applications may defined their own &lt;span style="text-decoration: underline;"&gt;RDF properties&lt;/span&gt; (data or object properties) to define &lt;span style="text-decoration: underline;"&gt;values&lt;/span&gt; of &lt;em&gt;measurement properties&lt;/em&gt; (&lt;a&gt;ssn:MeasurementProperty&lt;/a&gt;).&lt;/blockquote&gt;
    ///
    /// &lt;p&gt;If necessary, BCI applications should (but are not require to) define a set of restrictions and specialized connections (subproperties) on the property &lt;a&gt;hasNonChannelData&lt;/a&gt; (subproperty of &lt;em&gt;&lt;a&gt;ssn:hasMeasurementCapability&lt;/a&gt;&lt;/em&gt;) for each particular subclass of &lt;a&gt;Device&lt;/a&gt; (subclass of &lt;em&gt;&lt;a&gt;ssn:Sensor&lt;/a&gt;&lt;/em&gt;), which describes sensors for specific types.&lt;/p&gt;
    ///
    /// &lt;p&gt;A relevant &lt;em&gt;non-channeling measurement property&lt;/em&gt; (&lt;a&gt;ssn:MeasurementProperty&lt;/a&gt;) related to a &lt;a&gt;Device&lt;/a&gt; is &lt;strong&gt;sampling rate&lt;/strong&gt;.
    /// &lt;br /&gt;Based on the modeling of the &lt;a&gt;ssn:MeasurementCapability&lt;/a&gt; and &lt;a&gt;ssn:MeasurementProperty&lt;/a&gt; concepts and the guidelines found in
    /// (&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2) Smart product example" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Smart_product_example" target="_blank"&gt;5.4.2 Smart product example&lt;/a&gt; &amp;raquo;
    /// &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2.2) Sensor" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Sensor_2" target="_blank"&gt;5.4.2.2 Sensor&lt;/a&gt;), this ontology defines the &lt;a&gt;SamplingRate&lt;/a&gt; concept.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:34 AM 2016-08-22 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#NonChannel">bci:NonChannel</a>
    /// </summary>
    let NonChannel = _prefixId.prefix "NonChannel"
    let NonChannel'_period_'POWDER = _prefixId.prefix "NonChannel.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Playout.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : Playout^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : playout record^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:32 AM 2016-09-29 $^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes the data logging (&lt;span style="text-decoration: underline;"&gt;recording&lt;/span&gt;) of the dynamic state of the &lt;strong&gt;Context:&lt;/strong&gt; the "&lt;em&gt;play out&lt;/em&gt;" of the happenings.
    /// &lt;br /&gt;A &lt;a&gt;Playout&lt;/a&gt; consist of many &lt;a&gt;PlayoutInstant&lt;/a&gt;(ces).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Playout">bci:Playout</a>
    /// </summary>
    let Playout = _prefixId.prefix "Playout"
    let Playout'_period_'POWDER = _prefixId.prefix "Playout.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : playout instant^^rdfs:Literal</para>
    ///   <para>dcterms:title : PlayoutInstant^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Describing entities that form any log entry in a &lt;a&gt;Playout&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literalskos:scopeNote : %CLASS_HIERARCHY% the types of log entries in a &lt;a&gt;Playout&lt;/a&gt;.
    /// &lt;br /&gt;Two important types of log entries are defined in this ontology.^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:03 PM 2016-05-18 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : PlayoutInstant.png^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Captures any relevant entry log in a &lt;a&gt;Playout&lt;/a&gt;. &lt;br /&gt;Two specific type of instances are defined:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a&gt;PlayoutInstant.SubjectAction&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;PlayoutInstant.ContextEvent&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#PlayoutInstant">bci:PlayoutInstant</a>
    /// </summary>
    let PlayoutInstant = _prefixId.prefix "PlayoutInstant"

    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Captures a relevant entry log in a &lt;a&gt;Playout&lt;/a&gt; of a &lt;a&gt;Context&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Event&lt;/em&gt;&lt;/span&gt; issued by a &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt; instance during a &lt;a&gt;Session&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : playout instant: context event type^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : PlayoutInstant.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Events&lt;/em&gt;&lt;/span&gt; (&lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt;) issued in a &lt;a&gt;Context&lt;/a&gt; during a &lt;strong&gt;Session.&lt;/strong&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:27 PM 2016-05-19 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : PlayoutInstant.ContextEvent^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#PlayoutInstant.ContextEvent">bci:PlayoutInstant.ContextEvent</a>
    /// </summary>
    let PlayoutInstant'_period_'ContextEvent = _prefixId.prefix "PlayoutInstant.ContextEvent"

    let PlayoutInstant'_period_'ContextEvent'_period_'POWDER = _prefixId.prefix "PlayoutInstant.ContextEvent.POWDER"

    let PlayoutInstant'_period_'POWDER = _prefixId.prefix "PlayoutInstant.POWDER"

    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Captures a relevant entry log in a &lt;a&gt;Playout&lt;/a&gt; of a &lt;a&gt;Subject&lt;/a&gt;'s &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Event&lt;/em&gt;&lt;/span&gt; issued by an &lt;a&gt;Action&lt;/a&gt; instance during a &lt;a&gt;Session&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Events&lt;/em&gt;&lt;/span&gt; (&lt;a&gt;Action&lt;/a&gt;s) issued by a &lt;a&gt;Subject&lt;/a&gt; during a &lt;strong&gt;Session.&lt;/strong&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:27 PM 2016-05-19 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : PlayoutInstant.SubjectAction^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : playout instant: subject action type^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : PlayoutInstant.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#PlayoutInstant.SubjectAction">bci:PlayoutInstant.SubjectAction</a>
    /// </summary>
    let PlayoutInstant'_period_'SubjectAction = _prefixId.prefix "PlayoutInstant.SubjectAction"

    let PlayoutInstant'_period_'SubjectAction'_period_'POWDER = _prefixId.prefix "PlayoutInstant.SubjectAction.POWDER"

    /// <summary>
    ///   <para>dcterms:title : ProtocolBuffersDataFormat^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : &lt;a title="Google Protocol Buffers" href="https://developers.google.com/protocol-buffers/docs/overview?hl=en" target="_blank"&gt;Google Protocol Buffers&lt;/a&gt; &lt;a&gt;DataFormat&lt;/a&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : protocol buffers BCI data format^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:25 AM 2016-06-03 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Represents a &lt;a title="Google Protocol Buffers" href="https://developers.google.com/protocol-buffers/docs/overview?hl=en" target="_blank"&gt;Protocol Buffers&lt;/a&gt; &lt;a&gt;DataFormat&lt;/a&gt;, which is a language-neutral, platform-neutral, extensible way of serializing structured data for use in communications protocols and data storage.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#ProtocolBuffersDataFormat">bci:ProtocolBuffersDataFormat</a>
    /// </summary>
    let ProtocolBuffersDataFormat = _prefixId.prefix "ProtocolBuffersDataFormat"

    let ProtocolBuffersDataFormat'_period_'POWDER = _prefixId.prefix "ProtocolBuffersDataFormat.POWDER"

    /// <summary>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant type of &lt;em&gt;BCI records&lt;/em&gt; generated by &lt;em&gt;BCI devices&lt;/em&gt; for BCI activities.^^rdfs:Literal</para>
    ///   <para>dcterms:description : ** HIDDEN CONTENT **
    /// ==============================================================================
    /// ** scopeNote **
    /// %CLASS_HIERARCHY% any relevant type of &lt;em&gt;BCI records&lt;/em&gt; generated by &lt;em&gt;BCI devices&lt;/em&gt; for BCI activities, such as:
    /// &lt;ul&gt;
    /// &lt;li&gt;EEG (Electroencephalogram) record.&lt;/li&gt;
    /// &lt;li&gt;ECG (Electrocardiogram) record.&lt;/li&gt;
    /// &lt;li&gt;MoCap (Motion Capture) record.&lt;/li&gt;
    /// &lt;li&gt;Eye-Gaze record (for gaze or eye-tracking): A BCI Record that stores the coordinates of user's eye gaze captured by eye trackers.&lt;/li&gt;
    /// &lt;li&gt;Audio record.&lt;/li&gt;
    /// &lt;li&gt;Video record.&lt;/li&gt;
    /// &lt;li&gt;Hand-Gesture record: A BCI Record that stores the coordinates and velocities of user's hands and fingers captured by trackers such as &lt;em&gt;LeapMotion&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;Keyboard-Hit (keystroke) record: A BCI Record that stores the subject's hits on different keyboard keys.&lt;/li&gt;
    /// &lt;li&gt;Mouse-Click record: A BCI Record that stores the position coordinates of a subject's clicks with different mouse buttons.&lt;/li&gt;
    /// &lt;li&gt;Visual BCI record.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;p&gt;&lt;br /&gt;This ontology does not define all the &lt;em&gt;BCI records&lt;/em&gt; listed above.&lt;/p&gt;
    /// ==============================================================================^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:26 AM 2016-08-23 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;Record&lt;/a&gt; is a type of &lt;a&gt;ssn:Observation&lt;/a&gt;&lt;/a&gt; with the following characteristics:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;A &lt;em&gt;single&lt;/em&gt; &lt;a&gt;ssn:Observation&lt;/a&gt; for a specific unimodal BCI data capture task (with its own purpose).&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;SSN&lt;/b&gt;] A &lt;a title="ssn:sensingMethodUsed" href="http://purl.oclc.org/NET/ssnx/ssn#sensingMethodUsed" target="_blank"&gt;&lt;b&gt;Sensing Method&lt;/b&gt; is used&lt;/a&gt; to estimate or calculate a value of a specific &lt;a&gt;ssn:Property&lt;/a&gt; (&lt;a&gt;Modality&lt;/a&gt;) based on a specific &lt;a&gt;ssn:FeatureOfInterest&lt;/a&gt; (&lt;a&gt;Aspect&lt;/a&gt;).&lt;/li&gt;
    /// &lt;li&gt;A single &lt;a&gt;Device&lt;/a&gt; is used to &lt;em&gt;observe&lt;/em&gt; the unimodal BCI data (&lt;a&gt;RecordedData&lt;/a&gt;).&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;]: &lt;a&gt;Record&lt;/a&gt;, along with its related concepts, defines an appropiate structure based on the &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.6.1) Observation module" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Observation" target="_blank"&gt;following description&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &lt;p&gt;"&lt;em&gt;An observation &lt;/em&gt;(&lt;a&gt;Record&lt;/a&gt;)&lt;em&gt; is a situation that describes an observed feature &lt;/em&gt;(&lt;a&gt;Aspect&lt;/a&gt;)&lt;em&gt;, an observed property &lt;/em&gt;(&lt;a&gt;Modality&lt;/a&gt;)&lt;em&gt;, a sensor &lt;/em&gt;(&lt;a&gt;Device&lt;/a&gt;)&lt;em&gt; and method of sensing used and a value &lt;/em&gt;(&lt;a&gt;RecordedData&lt;/a&gt;)&lt;em&gt; observed for the property:
    /// &lt;br /&gt;that is, an observation &lt;/em&gt;(&lt;a&gt;Record&lt;/a&gt;)&lt;em&gt; describes a single value &lt;/em&gt;(&lt;a&gt;RecordedData&lt;/a&gt;)&lt;em&gt; attributed to a single property &lt;/em&gt;(&lt;a&gt;Modality&lt;/a&gt;)&lt;em&gt; by a particular sensor &lt;/em&gt;(&lt;a&gt;Device&lt;/a&gt;)".&lt;/p&gt;
    /// &lt;/blockquote&gt;
    ///
    /// &lt;p&gt;In the BCI domain, it's common that some related observations occur immediately after an observation has ended,&lt;br /&gt;by changing some of its initial &lt;em&gt;channeling&lt;/em&gt; or &lt;a&gt;Device&lt;/a&gt; settings (parameters or conditions).&lt;br /&gt;Hence, it is desirable to keep a temporal tracking of the previous and following related observations.&lt;br /&gt;This is achieved via the &lt;a&gt;hasPrevious&lt;/a&gt; and &lt;a&gt;hasNext&lt;/a&gt; &lt;em&gt;object properties&lt;/em&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;The &lt;em&gt;logical data structure template&lt;/em&gt; of a &lt;a&gt;Record&lt;/a&gt; is defined in its associated &lt;a&gt;RecordChannelingSpec&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;information object&lt;/span&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;Additional relevant metadata can be extended via the object property &lt;a&gt;hasMeasurementProperty&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN], [ESS]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : BCI record (measurement record)^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : Record^^rdfs:Literal</para>
    ///   <para>skos:historyNote : &lt;p&gt;In [&lt;b&gt;ESS 1.0&lt;/b&gt;]:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Corresponds to the "&lt;em&gt;eegRecordings&lt;/em&gt;" node: a specific collection of raw BCI data collected from a subject in a specific session.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;In [&lt;b&gt;ESS 2.0&lt;/b&gt;]:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Corresponds to the "&lt;em&gt;dataRecordings&lt;/em&gt;" node: information about EEG (or other data modality) recordings.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] &lt;a title="ssn:observationResult" href="http://purl.oclc.org/NET/ssnx/ssn#observationResult" target="_blank"&gt;States&lt;/a&gt; that "&lt;em&gt;an Observation is a description of the context, the Situation, in which the observation was made&lt;/em&gt;".
    /// &lt;br /&gt;In this ontology, the &lt;a&gt;Context&lt;/a&gt; is directly related through the &lt;a&gt;Session&lt;/a&gt;, which is a &lt;em&gt;Situation&lt;/em&gt; where the &lt;em&gt;Observation&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt;) was made.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] Following the structure presented in &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.6.2) How to represent an observation of a sensor?" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#How_to_represent_an_observation_of_a_sensor.3F" target="_blank"&gt;this example&lt;/a&gt;, the &lt;a&gt;Record&lt;/a&gt; concept has been modeled to describe &lt;em&gt;BCI observations&lt;/em&gt;, including the following &lt;span style="text-decoration: underline;"&gt;object properties&lt;/span&gt;:&lt;/p&gt;
    ///
    /// &lt;table style="height: 181px; overflow: auto;"&gt;
    /// &lt;thead class="remark"&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;em&gt;SSN&lt;/em&gt; object property&lt;/td&gt;
    /// &lt;td&gt;&lt;strong&gt;BCI&lt;/strong&gt; object subproperty&lt;/td&gt;
    /// &lt;td&gt;Between (from)...&lt;/td&gt;
    /// &lt;td&gt;... and (to)&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;/thead&gt;
    /// &lt;tbody class="remark"&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:featureOfInterest&lt;/em&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;a&gt;aspectOfInterest&lt;/a&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Observation&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt;)&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:FeatureOfInterest&lt;/em&gt; (&lt;a&gt;Aspect&lt;/a&gt;)&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:observedProperty&lt;/em&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;a&gt;observedModality&lt;/a&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Observation&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt;)&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Property&lt;/em&gt; (&lt;a&gt;Modality&lt;/a&gt;)&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:observedBy&lt;/em&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;a&gt;observedByDevice&lt;/a&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Observation&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt;)&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Sensor&lt;/em&gt; (&amp;laquo;&lt;span style="text-decoration: underline;"&gt;sub subclass&lt;/span&gt;&amp;raquo; &lt;a&gt;Device&lt;/a&gt;)&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;em&gt;DUL:includesEvent&lt;/em&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;a&gt;includesEvent&lt;/a&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Observation&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt;)&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Stimulus (&lt;a&gt;StimulusEvent&lt;/a&gt;)&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:observationResult&lt;/em&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;a&gt;observationResult&lt;/a&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Observation&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt;)&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:SensorOutput&lt;/em&gt; (&lt;a&gt;RecordedData&lt;/a&gt;)&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:isProducedBy&lt;/em&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;a&gt;isProducedByDevice&lt;/a&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:SensorOutput&lt;/em&gt; (&lt;a&gt;RecordedData&lt;/a&gt;)&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:Sensor&lt;/em&gt; (&amp;laquo;&lt;span style="text-decoration: underline;"&gt;sub subclass&lt;/span&gt;&amp;raquo; &lt;a&gt;Device&lt;/a&gt;)&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:hasValue&lt;/em&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;a&gt;hasValue&lt;/a&gt;&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:SensorOutput&lt;/em&gt; (&lt;a&gt;RecordedData&lt;/a&gt;)&lt;/td&gt;
    /// &lt;td&gt;&lt;em&gt;ssn:ObservationValue&lt;/em&gt; (&lt;a&gt;DataBlock&lt;/a&gt;)&lt;/td&gt;
    /// &lt;/tr&gt;
    /// &lt;/tbody&gt;
    /// &lt;/table&gt;
    ///
    /// &lt;p&gt;Proper restrictions have been designed accordingly for each object property.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] Following the guidelines explained in (&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.6) Observation" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Observation" target="_blank"&gt;5.3.6 Observation&lt;/a&gt;) and (&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2) Smart product example" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Smart_product_example" target="_blank"&gt;5.4.2 Smart product example&lt;/a&gt; &amp;raquo; &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2.4) Observation" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Observation_2" target="_blank"&gt;5.4.2.4 Observation&lt;/a&gt;),
    /// &lt;br /&gt;the &lt;span style="text-decoration: underline;"&gt;main restrictions&lt;/span&gt; modeled for &lt;em&gt;ssn:Observation&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt;) are:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Exactly 1 &lt;em&gt;ssn:FeatureOfInterest&lt;/em&gt; (&lt;a&gt;Aspect&lt;/a&gt;): details what was sensed.&lt;/li&gt;
    /// &lt;li&gt;Exactly 1 &lt;em&gt;ssn:Property&lt;/em&gt; (&lt;a&gt;Modality&lt;/a&gt;): details what was sensed.&lt;/li&gt;
    /// &lt;li&gt;Exactly 1 &lt;em&gt;ssn:Sensor&lt;/em&gt; (&amp;laquo;&lt;span style="text-decoration: underline;"&gt;sub subclass&lt;/span&gt;&amp;raquo; &lt;a&gt;Device&lt;/a&gt;): describes what made the &lt;em&gt;Observation&lt;/em&gt;.&lt;/li&gt;
    /// &lt;li&gt;Some &lt;em&gt;ssn:Stimulus&lt;/em&gt; (&lt;a&gt;StimulusEvent&lt;/a&gt;): details (what made) the &lt;em&gt;ssn:Sensor&lt;/em&gt; input.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;p&gt;Other restrictions are:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Exactly 1 &lt;em&gt;ssn:Sensing&lt;/em&gt; (describes how the &lt;em&gt;Observation&lt;/em&gt; was made): not adjusted for BCI activities.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Record">bci:Record</a>
    /// </summary>
    let Record = _prefixId.prefix "Record"
    let Record'_period_'POWDER = _prefixId.prefix "Record.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;p&gt;The &lt;em&gt;channeling schema&lt;/em&gt; information objects are structured in the following way:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &lt;span&gt;The &lt;em&gt;Channeling Schema&lt;/em&gt; of a... &lt;/span&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a&gt;Modality&lt;/a&gt; (&lt;a&gt;ChannelingSpec&lt;/a&gt;): it's the complete theoretical spec; the &lt;span style="text-decoration: underline;"&gt;generic template&lt;/span&gt; for a specific &lt;a&gt;ssn:Property&lt;/a&gt;.&lt;/li&gt;
    ///
    /// &lt;li&gt;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; &lt;a&gt;Device&lt;/a&gt; (&lt;a&gt;DeviceChannelingSpec&lt;/a&gt;): it's a functional subset of the &lt;a&gt;ChannelingSpec&lt;/a&gt;;
    /// &lt;br /&gt;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; defines the &lt;span style="text-decoration: underline;"&gt;logical subset&lt;/span&gt; of the complete spec for the specific functionality of a &lt;a&gt;ssn:SensingDevice&lt;/a&gt;.&lt;/li&gt;
    ///
    /// &lt;li&gt;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; &lt;a&gt;Record&lt;/a&gt; (&lt;a&gt;RecordChannelingSpec&lt;/a&gt;): it's the &lt;span style="text-decoration: underline;"&gt;concrete subset&lt;/span&gt; of the &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; for a specific &lt;a&gt;ssn:Observation&lt;/a&gt;.
    /// &lt;br /&gt;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; This information object is user specific according to recording setup.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/blockquote&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant type of a &lt;a&gt;RecordChannelingSpec&lt;/a&gt; to capture the external information that defines the &lt;em&gt;channeling schema&lt;/em&gt; information of a &lt;a&gt;Record&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:15 PM 2016-08-08 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literaldctype:StillImage : Record.png^^rdfs:Literaldctype:StillImage : Descriptor.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Based on the adjusted settings of the &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; made for the &lt;em&gt;observation&lt;/em&gt;, a &lt;a&gt;Record&lt;/a&gt; has its own specific &lt;em&gt;channeling schema&lt;/em&gt; information:
    /// &lt;br /&gt;that is, the logical components (&lt;a&gt;Channel&lt;/a&gt;s) and their extended generic metadata set that describe the &lt;a&gt;Record&lt;/a&gt;'s own logical data structure (specific to the &lt;em&gt;observation&lt;/em&gt; and the &lt;a&gt;Subject&lt;/a&gt;), according to the recording setup.&lt;/p&gt;
    ///
    /// &lt;p&gt;A &lt;a&gt;RecordChannelingSpec&lt;/a&gt; captures two information sets for a specific &lt;a&gt;Record&lt;/a&gt;:&lt;/p&gt;
    /// &lt;ol&gt;
    /// &lt;li&gt;Its complete &lt;em&gt;channeling schema&lt;/em&gt; description, in a form of an external document specification (outside the metadata repository).&lt;/li&gt;
    /// &lt;li&gt;Relevant metadata attributes regarding the &lt;span style="text-decoration: underline;"&gt;general characteristics&lt;/span&gt; of the &lt;em&gt;channeling schema&lt;/em&gt;: a set of related &lt;a&gt;Channel&lt;/a&gt;s.&lt;/li&gt;
    /// &lt;/ol&gt;
    ///
    /// &lt;p&gt;The &lt;span style="text-decoration: underline;"&gt;structure&lt;/span&gt; described in a &lt;a&gt;RecordChannelingSpec&lt;/a&gt; (first information set mentioned above) is based on a &lt;em&gt;concrete subset&lt;/em&gt; of the &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; that the &lt;a&gt;Device&lt;/a&gt; supports.
    /// &lt;br /&gt;Hence, for practical reasons, a &lt;a&gt;RecordChannelingSpec&lt;/a&gt; is defined as a &lt;em&gt;subclass&lt;/em&gt; of &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : record channeling schema spec^^rdfs:Literal</para>
    ///   <para>dcterms:title : RecordChannelingSpec^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;ul&gt;
    /// &lt;li&gt;A &lt;a&gt;RecordChannelingSpec&lt;/a&gt; for an &lt;a&gt;EegRecord&lt;/a&gt; would define the values of the positions for specific &lt;a&gt;EegChannel&lt;/a&gt;s used by the &lt;a&gt;EegDevice&lt;/a&gt;, when the &lt;em&gt;observation&lt;/em&gt; is made.
    /// &lt;br /&gt;A proper name for this spec would be &lt;strong&gt;EegRecordChannelingSpec&lt;/strong&gt;.&lt;/li&gt;
    ///
    /// &lt;li&gt;For "&lt;em&gt;Precision&lt;/em&gt;" &lt;a&gt;Record&lt;/a&gt;s, BCI applications may find important to keep the information regarding the &lt;a&gt;Channel&lt;/a&gt;'s &lt;span style="text-decoration: underline;"&gt;positions&lt;/span&gt; (&lt;span style="text-decoration: underline;"&gt;coordinates&lt;/span&gt;).&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#RecordChannelingSpec">bci:RecordChannelingSpec</a>
    /// </summary>
    let RecordChannelingSpec = _prefixId.prefix "RecordChannelingSpec"

    let RecordChannelingSpec'_period_'POWDER = _prefixId.prefix "RecordChannelingSpec.POWDER"

    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;RecordSpec&lt;/a&gt; is an information object that records (describes) specific properties (such as: specs of assistant materials, ambience settings, tools, etc.) regarding how a &lt;a&gt;Record&lt;/a&gt; was made.
    ///
    /// &lt;br /&gt;Similarly to &lt;a&gt;DeviceSpec&lt;/a&gt;, the structure of &lt;a&gt;RecordSpec&lt;/a&gt; has been modeled as a composite object so that it can be composed as a set of &lt;a&gt;RecordSpec&lt;/a&gt;s to describe specific parts on how a &lt;a&gt;Record&lt;/a&gt; was made.
    /// &lt;br /&gt;In this way, a &lt;a&gt;RecordSpec&lt;/a&gt; is considered as a &lt;em&gt;bag&lt;/em&gt; of general, extended and descriptive properties about the &lt;a&gt;Record&lt;/a&gt; settings.
    ///
    /// &lt;br /&gt;A &lt;a&gt;RecordSpec&lt;/a&gt; is a specialized &lt;a&gt;Descriptor&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;&lt;a&gt;RecordSpec&lt;/a&gt;s can be used to record any other descriptive and extended information related to any settings or conditions on how the &lt;a&gt;Record&lt;/a&gt; was made.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:23 AM 2016-07-19 $^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;Some BCI applications based on [&lt;b&gt;XDF&lt;/b&gt;], find important to keep information regarding what assistant materials (&lt;em&gt;hardware&lt;/em&gt;) and how they were used when the &lt;a&gt;Record&lt;/a&gt; was made. &lt;br /&gt;Hence, a BCI application could define a classification for different type of specifications, such as:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Hardware&lt;/em&gt; specs for &lt;a&gt;EegRecord&lt;/a&gt;s&lt;/span&gt;:
    /// &lt;ol&gt;
    /// &lt;li&gt;&lt;strong&gt;Coupling&lt;/strong&gt; (source [&lt;b&gt;XDF&lt;/b&gt;]): type of coupling used (e.g. Capacitive, Dry, Gel, Saline).&lt;/li&gt;
    /// &lt;li&gt;&lt;strong&gt;Surface&lt;/strong&gt; (source [&lt;b&gt;XDF&lt;/b&gt;]): type of the contact surface (e.g. Bristle, Pad, Pins, Plate).&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF], [ESS]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literaldctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : record specification^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;ul&gt;
    /// &lt;li&gt;The &lt;em&gt;channeling schema&lt;/em&gt; of a &lt;a&gt;Record&lt;/a&gt; is defined as an independent component from the &lt;a&gt;RecordSpec&lt;/a&gt;.
    /// &lt;br /&gt;A &lt;a&gt;Record&lt;/a&gt;'s &lt;em&gt;channeling schema&lt;/em&gt; (&lt;strong&gt;RecordChannelingSchema&lt;/strong&gt;) is a &lt;em&gt;subset&lt;/em&gt; of the &lt;strong&gt;DeviceChannelingSchema&lt;/strong&gt; defined for its correspondent &lt;a&gt;Device&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;This ontology does not define any information object  in particular of a &lt;a&gt;RecordSpec&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : RecordSpec^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% specific types of &lt;a&gt;RecordSpec&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#RecordSpec">bci:RecordSpec</a>
    /// </summary>
    let RecordSpec = _prefixId.prefix "RecordSpec"
    let RecordSpec'_period_'POWDER = _prefixId.prefix "RecordSpec.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : recorded BCI data^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] It is a specific type of a &lt;a&gt;ssn:SensorOutput&lt;/a&gt; (a piece of information outputted by a &lt;a&gt;Device&lt;/a&gt; in an &lt;a&gt;ssn:Observation&lt;/a&gt;: an &lt;em&gt;observed value&lt;/em&gt;) for BCI activities.
    ///
    /// &lt;br /&gt;The value itself is being represented by a specific type of an &lt;a&gt;ssn:ObservationValue&lt;/a&gt; (a sequence of &lt;a&gt;DataBlock&lt;/a&gt;s).&lt;/p&gt;
    ///
    /// &lt;p&gt;This concept abstracts a &lt;span style="text-decoration: underline;"&gt;raw data set&lt;/span&gt; (independent of its representation and access method) outputted by a &lt;a&gt;Device&lt;/a&gt; for a specific &lt;a&gt;Modality&lt;/a&gt;. In this way, a &lt;a&gt;RecordedData&lt;/a&gt; has:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;A single data representation, a &lt;a&gt;DataFormat&lt;/a&gt;, and&lt;/li&gt;
    /// &lt;li&gt;multiple &lt;a&gt;AccessMethod&lt;/a&gt;s (either &lt;em&gt;archived&lt;/em&gt; or in &lt;em&gt;real-time&lt;/em&gt;).&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;In the BCI domain, it's common that the data "&lt;em&gt;evolves&lt;/em&gt;" over time. That is, there are changes on the data structure:
    /// &lt;ul&gt;
    /// &lt;li&gt;from its "&lt;em&gt;initial&lt;/em&gt;" state (ever since it's collected from a &lt;a&gt;Device&lt;/a&gt;: &lt;em&gt;raw data&lt;/em&gt;)&lt;/li&gt;
    /// &lt;li&gt;to "&lt;em&gt;following&lt;/em&gt;" states (when applying specialized algorithms to recognizes patterns throughout &lt;a&gt;Model&lt;/a&gt;s: &lt;em&gt;transformed data&lt;/em&gt;).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// For example, for EEG data its evolution over time resembles a &lt;span style="text-decoration: underline;"&gt;tree structure&lt;/span&gt;.
    /// &lt;br /&gt;Hence, it is desirable for BCI applications to keep a temporal tracking of the previous and following versions of the data:
    /// &lt;br /&gt;a derived data tree &lt;span style="text-decoration: underline;"&gt;throughout keeping links between data versions&lt;/span&gt;. This is achieved via the &lt;a&gt;hasPrevious&lt;/a&gt; and &lt;a&gt;hasNext&lt;/a&gt; &lt;em&gt;object properties&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : RecordedData^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literaldctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:43 PM 2016-08-17 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;From the perspective of the &lt;b&gt;data&lt;/b&gt; (&lt;a&gt;RecordedData&lt;/a&gt;):&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Its &lt;b&gt;physical structure&lt;/b&gt; is defined through the &lt;a&gt;DataFormat&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;Its &lt;b&gt;logical structure&lt;/b&gt; is defined through the associated &lt;a&gt;RecordChannelingSpec&lt;/a&gt; of its &lt;a&gt;Record&lt;/a&gt; (the defined collection of &lt;a&gt;Channel&lt;/a&gt;s).&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#RecordedData">bci:RecordedData</a>
    /// </summary>
    let RecordedData = _prefixId.prefix "RecordedData"
    let RecordedData'_period_'POWDER = _prefixId.prefix "RecordedData.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : state (response tag)^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : ResponseTag^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;Right after a set of &lt;a&gt;DataSegment&lt;/a&gt;s is created, two consecutive tasks occur:
    /// &lt;ol&gt;
    /// &lt;li&gt;A set of &lt;em&gt;editing processes&lt;/em&gt; is run on the recordings, which classify the data sets based on different &lt;a&gt;Model&lt;/a&gt;s.&lt;/li&gt;
    /// &lt;li&gt;A set of &lt;a&gt;ResponseTag&lt;/a&gt;s ;is created, which capture the information related to "&lt;em&gt;what is so special about&lt;/em&gt;" a particular &lt;a&gt;DataSegment&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/p&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;This is one of the most important concepts in this ontology.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Information object that captures a &lt;a&gt;Marker&lt;/a&gt; issued by a &lt;a&gt;Model&lt;/a&gt;.
    ///
    /// &lt;br /&gt;In the BCI domain, a natural (physiological or neurological) change in the &lt;a&gt;Subject&lt;/a&gt;'s &lt;span style="text-decoration: underline;"&gt;state&lt;/span&gt; while doing an &lt;a&gt;Activity&lt;/a&gt;, is simply called a &lt;strong&gt;State&lt;/strong&gt;.
    ///
    /// &lt;br /&gt;A &lt;a&gt;ResponseTag&lt;/a&gt; could not be directly linked to a change in the &lt;a&gt;Context&lt;/a&gt; (issued by a &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt;, specifically a &lt;a&gt;StimulusEvent&lt;/a&gt;) in a &lt;a&gt;Session&lt;/a&gt;.
    ///
    /// &lt;br /&gt;A &lt;a&gt;ResponseTag&lt;/a&gt; represents "&lt;em&gt;something&lt;/em&gt;" detected by a &lt;span style="text-decoration: underline;"&gt;Machine Learning Model&lt;/span&gt; (&lt;a&gt;Model&lt;/a&gt;).
    /// &lt;/p&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 07:01 PM 2016-05-22 $^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;In a common M2M semantic search query, the following input parameters may be used to retrieve a set of &lt;a&gt;ResponseTag&lt;/a&gt;s related to its &lt;a&gt;DataSegment&lt;/a&gt;s:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a&gt;Activity&lt;/a&gt;: for example, driving.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;Aspect&lt;/a&gt;: for example, vigilance and alert.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;Modality&lt;/a&gt;: for example, EEG, EOG.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;Subject&lt;/a&gt;: filtered by gender, age, etc.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#ResponseTag">bci:ResponseTag</a>
    /// </summary>
    let ResponseTag = _prefixId.prefix "ResponseTag"
    let ResponseTag'_period_'POWDER = _prefixId.prefix "ResponseTag.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 02:52 AM 2016-08-22 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : SamplingRate^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Sampling rate of the &lt;a&gt;Device&lt;/a&gt;. Its measurement unit is &lt;em&gt;Hz&lt;/em&gt;.
    /// &lt;br /&gt;As a relevant &lt;em&gt;non-channeling measurement property&lt;/em&gt; (&lt;a&gt;ssn:MeasurementProperty&lt;/a&gt;) related to a &lt;a&gt;Device&lt;/a&gt; its modeling is based on:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;the &lt;a&gt;ssn:MeasurementCapability&lt;/a&gt; and &lt;a&gt;ssn:MeasurementProperty&lt;/a&gt; concepts, and&lt;/li&gt;
    /// &lt;li&gt;the guidelines found in (&lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2) Smart product example" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Smart_product_example" target="_blank"&gt;5.4.2 Smart product example&lt;/a&gt; &amp;raquo;
    /// &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.4.2.2) Sensor" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Sensor_2" target="_blank"&gt;5.4.2.2 Sensor&lt;/a&gt;).&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : sampling rate of a &lt;em&gt;device&lt;/em&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : SamplingRate.png^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@UNITS-OF-MEASUREMENT^^rdfs:Literalskos:editorialNote : &lt;p&gt;Related concept for a &lt;a&gt;Record&lt;/a&gt;: &lt;a&gt;hasSamplingRate&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [XDF]^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-MeasurementCapability^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#SamplingRate">bci:SamplingRate</a>
    /// </summary>
    let SamplingRate = _prefixId.prefix "SamplingRate"
    let SamplingRate'_period_'POWDER = _prefixId.prefix "SamplingRate.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;Session&lt;/a&gt; is a &lt;em&gt;DUL:Situation&lt;/em&gt; that monitors how one &lt;a&gt;Subject&lt;/a&gt; interacts with one &lt;a&gt;Context&lt;/a&gt; while performing one &lt;a&gt;Activity&lt;/a&gt;, throughout collecting a nonempty set of &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;multimodal&lt;/em&gt;&lt;/span&gt; biomedical &lt;a&gt;ssn:Observation&lt;/a&gt;s (&lt;a&gt;Record&lt;/a&gt;s).&lt;br /&gt;A &lt;a&gt;Session&lt;/a&gt; has the following characteristics and restrictions:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Comprises a collection of &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;multimodal&lt;/em&gt;&lt;/span&gt; BCI data capture tasks (each one&amp;nbsp;with its own specific measurement purpose: &lt;a&gt;Aspect&lt;/a&gt;).&lt;/li&gt;
    /// &lt;li&gt;Monitors exactly one &lt;a&gt;Subject&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;Monitors exactly one &lt;a&gt;Activity&lt;/a&gt; (performed by the &lt;a&gt;Subject&lt;/a&gt;).&lt;/li&gt;
    /// &lt;li&gt;Monitors exactly one &lt;a&gt;Context&lt;/a&gt; (while the &lt;a&gt;Subject&lt;/a&gt; interacts with it).&lt;/li&gt;
    /// &lt;li&gt;Comprises exactly one &lt;a&gt;Playout&lt;/a&gt; collected from the associated &lt;a&gt;Context&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;Groups different and multiple &lt;a&gt;Record&lt;/a&gt;s (multimodal data) that are &lt;em&gt;observed&lt;/em&gt; (collected) simultaneously from the &lt;a&gt;Subject&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;]: The concept of &lt;a&gt;Session&lt;/a&gt; defines an appropiate structure to group multiple &lt;a&gt;Record&lt;/a&gt;s (multimodal data), based on the &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.6.1) Observation module" href="http://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Observation" target="_blank"&gt;following description&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &lt;p&gt;"&lt;em&gt;Observations&lt;/em&gt; (&lt;a&gt;Record&lt;/a&gt;s) &lt;em&gt;of multiple features&lt;/em&gt; (&lt;a&gt;Aspect&lt;/a&gt;s) &lt;em&gt;or multiple properties&lt;/em&gt; (&lt;a&gt;Modality&lt;/a&gt;-ies) &lt;em&gt;of the one feature should be represented as either compound properties, features and values or
    /// &lt;br /&gt;&lt;span style="text-decoration: underline;"&gt;as multiple observations, grouped in some appropriate structure&lt;/span&gt;&lt;/em&gt;".&lt;/p&gt;
    /// &lt;/blockquote&gt;
    ///
    /// &lt;p&gt;In the BCI research domain, a &lt;a&gt;Session&lt;/a&gt; can have &lt;span style="text-decoration: underline;"&gt;multipurpose extended metadata sets&lt;/span&gt; to describe broader concepts and definitions regarding the &lt;em&gt;nature&lt;/em&gt; and &lt;em&gt;purpose&lt;/em&gt; of this information object.
    /// &lt;br /&gt;These external metadata sets can be associated with &lt;a&gt;Descriptor&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Session.png^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;External descriptions that complement and extend the information about a &lt;a&gt;Session&lt;/a&gt;, can be added through &lt;a&gt;Descriptor&lt;/a&gt;s.
    /// &lt;br /&gt;BCI applications based on [&lt;b&gt;ESS 1.0&lt;/b&gt;] could define &lt;a&gt;Descriptor&lt;/a&gt;s to include information, such as:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;em&gt;Lab. ID&lt;/em&gt;. &lt;span class="remark"&gt;&amp;ndash; identifier of the session used in the original lab notes (if available, otherwise insert 'NA')&lt;/span&gt;.&lt;/li&gt;
    ///
    ///
    /// &lt;li&gt;&lt;em&gt;Task Label&lt;/em&gt;. &lt;span class="remark"&gt;&amp;ndash; indicates which task is being performed in the session (e.g. A, B, C,...). Only use this node if there are different tasks. Otherwise leave the node blank.&lt;/span&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;span class="remark"&gt;&lt;span style="text-decoration: underline;"&gt;For &lt;em&gt;Session&lt;/em&gt; entities&lt;/span&gt;: If different tasks occur in the same session repeat the session node with a different "&lt;em&gt;taskLabel&lt;/em&gt;", and other information that may be different, such as the "&lt;em&gt;eegRecording&lt;/em&gt;" node.&lt;/span&gt;&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span class="remark"&gt;&lt;span style="text-decoration: underline;"&gt;For &lt;em&gt;EventCode&lt;/em&gt; entities&lt;/span&gt;: Use this only if there are multiple tasks in the study and they use the same event codes, otherwise leave blank.&lt;/span&gt;&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : BCI session^^rdfs:Literal</para>
    ///   <para>skos:historyNote : &lt;p&gt;In [&lt;b&gt;ESS 2.0&lt;/b&gt;], a &lt;a&gt;Session&lt;/a&gt; is related to the &lt;em&gt;RecordedParameterSet&lt;/em&gt; concept, found in the following XML element: (&lt;em&gt;../recordingParameterSet/recordingParameterSetLabel&lt;/em&gt;).&lt;/p&gt;
    ///
    /// &lt;p&gt;The "&lt;em&gt;recordingParameterSet&lt;/em&gt;" node groups the information of multiple &lt;strong&gt;Modality-&lt;/strong&gt;ies and, also, &lt;a&gt;DeviceSpec&lt;/a&gt;s.&lt;br /&gt;Hence, it implies that a &lt;a&gt;Session&lt;/a&gt; (a &lt;a&gt;Record&lt;/a&gt; set) is associated (used) with multiple &lt;a&gt;Device&lt;/a&gt;s, due of the "&lt;em&gt;dataRecording&lt;/em&gt;" node definition in ESS (multiple &lt;a&gt;RecordedData&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : Session^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [SSN]^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:03 AM 2016-07-01 $^^rdfs:Literal</para>
    ///   <para>ov:part : Session^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Session">bci:Session</a>
    /// </summary>
    let Session = _prefixId.prefix "Session"
    let Session'_period_'POWDER = _prefixId.prefix "Session.POWDER"
    /// <summary>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% any relevant &lt;em&gt;contextual event&lt;/em&gt; that describes the stimuli or trigger that causes a relevant BCI measurement.^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:08 AM 2016-07-28 $^^rdfs:Literal</para>
    ///   <para>ov:part : Context,SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:title : StimulusEvent^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;The following descriptions capture the definition of this concept ([&lt;strong&gt;SSN&lt;/strong&gt;: &lt;a title="Semantic Sensor Network Ontology &amp;raquo; Stimulus" href="https://www.w3.org/2005/Incubator/ssn/ssnx/ssn#Stimulus" target="_blank"&gt;Stimulus&lt;/a&gt;], &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.1.2.1) Stimuli" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Stimuli" target="_blank"&gt;5.3.1.2.1 Stimuli&lt;/a&gt;) adjusted to this ontology:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a&gt;StimulusEvent&lt;/a&gt;s are detectable changes in the environment (&lt;a&gt;Context&lt;/a&gt;), i.e., in the physical or a virtual world.&lt;/li&gt;
    /// &lt;li&gt;A &lt;a&gt;StimulusEvent&lt;/a&gt; is an &lt;span style="text-decoration: underline;"&gt;event&lt;/span&gt; in the real (or virtual) world that "&lt;span style="text-decoration: underline;"&gt;triggers&lt;/span&gt;" the &lt;a&gt;Device&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;StimulusEvent&lt;/a&gt;s can either be directly or indirectly related to observable &lt;a&gt;Modality&lt;/a&gt;-ies and, therefore, to &lt;a&gt;Aspect&lt;/a&gt;s.&lt;/li&gt;
    /// &lt;li&gt;The same types of &lt;a&gt;StimulusEvent&lt;/a&gt;s can trigger different kinds of &lt;a&gt;Device&lt;/a&gt;s and be used to reason about different &lt;a&gt;Modality&lt;/a&gt;-ies.&lt;/li&gt;
    /// &lt;li&gt;The &lt;a&gt;Modality&lt;/a&gt;-ies associated to the &lt;a&gt;StimulusEvent&lt;/a&gt; may be different to eventual observed (&lt;a&gt;Record&lt;/a&gt;) &lt;a&gt;Modality&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;It is the &lt;a&gt;StimulusEvent&lt;/a&gt;, not the &lt;a&gt;Context.Object&lt;/a&gt; that triggers the &lt;a&gt;Device&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;A &lt;a&gt;StimulusEvent&lt;/a&gt; may only be usable as &lt;span style="text-decoration: underline;"&gt;proxy&lt;/span&gt; for a specific &lt;em&gt;region&lt;/em&gt; of an observed &lt;a&gt;Modality&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/blockquote&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : stimulus event^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : StimulusEvent.png^^rdfs:Literal</para>
    ///   <para>dcterms:description : ** HIDDEN CONTENT **
    /// ==============================================================================
    ///
    /// ** HED class in EXAMPLE SPEC **
    ///
    ///     &lt;!-- https://w3id.org/BCI-ontology#HED.Stimulus --&gt;
    ///
    ///     &lt;owl:Class rdf:about="&amp;bci;HED.Stimulus"&gt;
    ///         &lt;rdfs:subClassOf rdf:resource="&amp;bci;StimulusEvent"/&gt;
    ///         &lt;skos:scopeNote rdf:datatype="&amp;rdfs;Literal"&gt;%CLASS_HIERARCHY% any XXX&lt;/skos:scopeNote&gt;
    ///         &lt;skos:example rdf:datatype="&amp;rdfs;Literal"&gt;&amp;lt;ul&amp;gt;
    /// &amp;lt;li&amp;gt;HED.Auditory&amp;lt;/li&amp;gt;
    /// &amp;lt;li&amp;gt;HED.Pain&amp;lt;/li&amp;gt;
    /// &amp;lt;li&amp;gt;HED.Smell&amp;lt;/li&amp;gt;
    /// &amp;lt;li&amp;gt;HED.TMS&amp;lt;/li&amp;gt;
    /// &amp;lt;li&amp;gt;HED.Tactile&amp;lt;/li&amp;gt;
    /// &amp;lt;li&amp;gt;HED.Taste&amp;lt;/li&amp;gt;
    /// &amp;lt;li&amp;gt;HED.Visual&amp;lt;/li&amp;gt;
    /// &amp;lt;/ul&amp;gt;&lt;/skos:example&gt;
    ///         &lt;skos:definition rdf:datatype="&amp;rdfs;Literal"&gt;Defines a general &amp;lt;b&amp;gt;Stimuli&amp;lt;/b&amp;gt; HED.&lt;/skos:definition&gt;
    ///         &lt;skos:prefLabel rdf:datatype="&amp;rdfs;Literal"&gt;HED.Stimulus&lt;/skos:prefLabel&gt;
    ///         &lt;DCMIType:StillImage rdf:datatype="&amp;rdfs;Literal"&gt;HED.Stimulus_Visual.png&lt;/DCMIType:StillImage&gt;
    ///         &lt;dct:source rdf:datatype="&amp;rdfs;Literal"&gt;[HED]&lt;/dct:source&gt;
    ///     &lt;/owl:Class&gt;
    ///
    ///
    /// ** HED attribute for the HED class in EXAMPLE SPEC **
    ///
    ///     &lt;!-- https://w3id.org/BCI-ontology#hasHEDtag --&gt;
    ///
    ///     &lt;owl:DatatypeProperty rdf:about="&amp;bci;hasHEDtag"&gt;
    ///         &lt;skos:definition rdf:datatype="&amp;rdfs;Literal"&gt;
    ///       Event code tag, based on &amp;quot;Hierarchical Event Descriptor (HED) Tags for
    ///       Analysis of Event-Related EEG Studies&amp;quot; document, (if available, otherwise leave blank).&lt;/skos:definition&gt;
    ///         &lt;rdfs:range rdf:resource="&amp;rdfs;Literal"/&gt;
    ///     &lt;/owl:DatatypeProperty&gt;
    ///
    /// ==============================================================================^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;A &lt;a&gt;StimulusEvent&lt;/a&gt; describes a specific component of the &lt;a&gt;Context&lt;/a&gt; that &lt;em&gt;"generates"&lt;/em&gt; an &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;annotation tag&lt;/span&gt;&lt;/em&gt; (&lt;a&gt;StimulusTag&lt;/a&gt;). Some examples of a &lt;a&gt;StimulusEvent&lt;/a&gt; are:&lt;br /&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Red light for 15 seconds at a 66 Hz. frequency.&lt;/li&gt;
    /// &lt;li&gt;Green light for 10 seconds at a 74 Hz. frequency.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/p&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;StimulusEvent&lt;/a&gt; describes an &lt;em&gt;event&lt;/em&gt; that triggers a &lt;span style="text-decoration: underline;"&gt;stimulus&lt;/span&gt; to the &lt;a&gt;Subject&lt;/a&gt; during a &lt;a&gt;Session&lt;/a&gt;.
    /// &lt;br /&gt;By its own nature, it may affect the &lt;a&gt;Subject&lt;/a&gt;'s performance of the &lt;a&gt;Activity&lt;/a&gt; (and, therefore, a set of &lt;a&gt;Action&lt;/a&gt;s related to the &lt;a&gt;Activity&lt;/a&gt;).
    /// &lt;br /&gt;A &lt;a&gt;StimulusEvent&lt;/a&gt; is an external happening on a specific &lt;a&gt;Context&lt;/a&gt; that generates the input for the sensors ([&lt;b&gt;SSN&lt;/b&gt;] concepts).
    /// &lt;br /&gt;Thus, these events can be generated (issued) by a set of &lt;a&gt;Context.Object&lt;/a&gt;s (architecturally speaking by &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt;s).&lt;/p&gt;
    ///
    /// &lt;p&gt;In [&lt;b&gt;SSN&lt;/b&gt;], this concept is a subclass of &lt;a&gt;ssn:Stimulus&lt;/a&gt; and, therefore, a &lt;a&gt;ssn:SensorInput&lt;/a&gt;, which describes the (data) input for the &lt;a&gt;ssn:Sensor&lt;/a&gt;s.&lt;/p&gt;
    ///
    /// &lt;p&gt;In the BCI domain, this concept is simply called an "&lt;em&gt;Event&lt;/em&gt;": the stimuli or trigger that causes the relevant measurement to be, in fact, processed or analyzed.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#StimulusEvent">bci:StimulusEvent</a>
    /// </summary>
    let StimulusEvent = _prefixId.prefix "StimulusEvent"
    let StimulusEvent'_period_'POWDER = _prefixId.prefix "StimulusEvent.POWDER"
    /// <summary>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : stimulus tag^^rdfs:Literal</para>
    ///   <para>dcterms:title : StimulusTag^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Information object that captures a &lt;a&gt;Marker&lt;/a&gt; issued by a &lt;a&gt;StimulusEvent&lt;/a&gt;.
    /// &lt;br /&gt;While doing the data recording, the system automatically creates a &lt;a&gt;Marker&lt;/a&gt; (&lt;a&gt;StimulusTag&lt;/a&gt;) for the &lt;a&gt;ssn:SensorInput&lt;/a&gt; based on the &lt;a&gt;Context&lt;/a&gt; (issued by a &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt;, specifically a &lt;a&gt;StimulusEvent&lt;/a&gt;) of the &lt;a&gt;Session&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:48 PM 2016-05-20 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;This is one of the most important concepts in this ontology.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#StimulusTag">bci:StimulusTag</a>
    /// </summary>
    let StimulusTag = _prefixId.prefix "StimulusTag"
    let StimulusTag'_period_'POWDER = _prefixId.prefix "StimulusTag.POWDER"
    /// <summary>
    ///   <para>dcterms:source : [ESS], [XDF]^^rdfs:Literal</para>
    ///   <para>ov:part : Subject^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A specific person (probably anonymous but possessing unique identity) with certain attributes on which the &lt;a&gt;Session&lt;/a&gt;s are recorded (from which the data is &lt;em&gt;observed&lt;/em&gt;: &lt;a&gt;Record&lt;/a&gt;).
    ///
    /// &lt;br /&gt; The concept is based on the notion of &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Patient&lt;/em&gt;&lt;/span&gt;, specifically from a standarized &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Electronic Patient/Medical Record&lt;/em&gt;&lt;/span&gt;, such as the &lt;em&gt;HL7 Record&lt;/em&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;An information object of this class, describes the &lt;em&gt;Medical and Physiological "Condition"&lt;/em&gt; of a &lt;a&gt;Subject&lt;/a&gt;.
    ///
    /// &lt;br /&gt;Therefore, it may have multiple &lt;a&gt;Descriptor&lt;/a&gt;s associated (such as &lt;em&gt;HL7 Records&lt;/em&gt; or specific XML vocabularies from the industry).&lt;/p&gt;
    ///
    /// &lt;p&gt;This ontology does not define any specific set of attributes associated to a &lt;a&gt;Subject&lt;/a&gt;.
    /// &lt;br /&gt;BCI applications con extend this concept according to their information needs and system requirements.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Subject.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : Subject^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 10:49 PM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;The &lt;a&gt;Subject&lt;/a&gt; is the point of reference (focus) of the data monitoring and data analysis, from which BCI applications collect &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Measurement Recordings&lt;/em&gt;&lt;/span&gt;.
    /// &lt;br /&gt;Hence, the name &lt;a&gt;Subject&lt;/a&gt; instead of &lt;em&gt;Person&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;[&lt;b&gt;ESS&lt;/b&gt;] and [&lt;b&gt;XDF&lt;/b&gt;] define some useful data type properties (&lt;em&gt;attributes&lt;/em&gt;) associated to a &lt;a&gt;Subject&lt;/a&gt;.
    /// &lt;br /&gt;Some examples of these attributes are:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Gender&lt;/em&gt;&lt;/span&gt;:
    /// &lt;ul&gt;
    /// &lt;li&gt;Defined as an enumerated value = { &lt;em&gt;Female, Male, ...&lt;/em&gt; }.&lt;/li&gt;
    /// &lt;li&gt;It can be derived as a subproperty extended from the (&lt;a&gt;dbp:Person&lt;/a&gt;)&lt;strong&gt;.sex&lt;/strong&gt; property definition.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Year of birth (YOB)&lt;/em&gt;&lt;/span&gt;:
    /// &lt;ul&gt;
    /// &lt;li&gt;Defined as a positive integer greater or equal than 1900.&lt;/li&gt;
    /// &lt;li&gt;It can be derived as a subproperty extended from the &lt;a&gt;dbp:Person&lt;/a&gt; definition.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Handedness&lt;/em&gt;&lt;/span&gt;:
    /// &lt;ul&gt;
    /// &lt;li&gt;Defined as an enumerated value = { &lt;em&gt;Ambidextrous, Left, N/A, Right&lt;/em&gt; }.&lt;/li&gt;
    /// &lt;li&gt;Subject's dominantly used hand. Related to medical record.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Hearing&lt;/em&gt;&lt;/span&gt;:
    /// &lt;ul&gt;
    /// &lt;li&gt;Defined as an enumerated value = { &lt;em&gt;CorrectedToNormal, Impaired, Normal&lt;/em&gt; }.&lt;/li&gt;
    /// &lt;li&gt;Subject's hearing condition. Related to medical record.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Vision&lt;/em&gt;&lt;/span&gt;:
    /// &lt;ul&gt;
    /// &lt;li&gt;Defined as an enumerated value = { &lt;em&gt;CorrectedToNormal, Impaired, Normal&lt;/em&gt; }.&lt;/li&gt;
    /// &lt;li&gt;Subject's vision condition. Related to medical record.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : subject (or person)^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#Subject">bci:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    let Subject'_period_'POWDER = _prefixId.prefix "Subject.POWDER"
    /// <summary>
    ///   <para>skos:example : &lt;p&gt;Some examples of &lt;a&gt;SubjectState&lt;/a&gt; may include descriptions regarding:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Physiological state:
    /// &lt;ul&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Age&lt;/em&gt;&lt;/span&gt;: &lt;a&gt;Subject&lt;/a&gt;'s age (in years) at the time of the &lt;a&gt;Session&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Height&lt;/em&gt;&lt;/span&gt;: &lt;a&gt;Subject&lt;/a&gt;'s height in centimeters (at the moment of the &lt;a&gt;Session&lt;/a&gt;).&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Weight&lt;/em&gt;&lt;/span&gt;: &lt;a&gt;Subject&lt;/a&gt;'s weight in kilograms (at the moment of the &lt;a&gt;Session&lt;/a&gt;).&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Hearing&lt;/em&gt;&lt;/span&gt;: &lt;a&gt;Subject&lt;/a&gt;'s hearing (e.g. "&lt;em&gt;CorrectedToNormal&lt;/em&gt;", "&lt;em&gt;Impaired&lt;/em&gt;", "&lt;em&gt;Normal&lt;/em&gt;").&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Vision&lt;/em&gt;&lt;/span&gt;: &lt;a&gt;Subject&lt;/a&gt;'s vision (e.g. "&lt;em&gt;CorrectedToNormal&lt;/em&gt;", "&lt;em&gt;Impaired&lt;/em&gt;", "&lt;em&gt;Normal&lt;/em&gt;").&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Caffeine&lt;/em&gt;&lt;/span&gt;: number of hours since last caffeine intake, if less than 12 hours.&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Alcohol&lt;/em&gt;&lt;/span&gt;: whether the &lt;a&gt;Subject&lt;/a&gt; has consumed alcohol within 24 hours before the &lt;a&gt;Session&lt;/a&gt; (a logical value).&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Medication&lt;/em&gt;&lt;/span&gt;: specification of the medication intake based on different parameters (time, chemical compounds, etc.).&lt;/li&gt;
    /// &lt;li&gt;Drowsiness: identified in [&lt;strong&gt;HED 1.31&lt;/strong&gt;] as "&lt;em&gt;awake&lt;/em&gt;".&lt;/li&gt;
    /// &lt;li&gt;Stress level.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;HED 1.31&lt;/b&gt;] Emotional state:
    /// &lt;ul&gt;
    /// &lt;li&gt;Alertness.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// &lt;p&gt;Some additional metadata related to this concept used for &lt;em&gt;research purposes&lt;/em&gt; could be:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;A set of attributes to label the &lt;span style="text-decoration: underline;"&gt;identity&lt;/span&gt; of the &lt;a&gt;Subject&lt;/a&gt; in the &lt;a&gt;Session&lt;/a&gt;. Example:
    /// &lt;ul&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] A &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Lab. ID&lt;/em&gt;&lt;/span&gt; as a de-personalized &lt;a&gt;Subject&lt;/a&gt; identifier in the research lab.&lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] A &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;sequential ID&lt;/span&gt;&lt;/em&gt; to identify the &lt;a&gt;Subject&lt;/a&gt; in a collection of &lt;a&gt;Session&lt;/a&gt;s. (Case: "&lt;em&gt;InSessionNumber&lt;/em&gt;" attribute in [&lt;b&gt;ESS 2.0&lt;/b&gt;]).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/li&gt;
    /// &lt;li&gt;[&lt;b&gt;ESS&lt;/b&gt;] An attribute to identify the &lt;em&gt;group type&lt;/em&gt; that the &lt;a&gt;Subject&lt;/a&gt; belongs to based on the research nature of the &lt;a&gt;Session&lt;/a&gt;s.
    /// &lt;br /&gt;Example: a &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Session Group&lt;/em&gt;&lt;/span&gt; to identify the &lt;a&gt;Subject&lt;/a&gt;'s group (e.g. "&lt;em&gt;Autistic&lt;/em&gt;", "&lt;em&gt;Normal&lt;/em&gt;", "&lt;em&gt;Control&lt;/em&gt;", etc.).&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [HED]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Session.png^^rdfs:Literaldctype:StillImage : Descriptor.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:00 AM 2016-06-29 $^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,Session,Subject^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : Subject's state during a specific session^^rdfs:Literal</para>
    ///   <para>dcterms:title : SubjectState^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes the &lt;span style="text-decoration: underline;"&gt;state&lt;/span&gt; of the &lt;a&gt;Subject&lt;/a&gt; during the &lt;a&gt;Session&lt;/a&gt;, throughout a collection of external specifications which capture extended metadata of the &lt;a&gt;Subject&lt;/a&gt;'s overall state.
    /// &lt;br /&gt;A state can be further classified properly to document more accurately the nature of the metadata (such as physiological state, cognitive state or emotional state).&lt;/p&gt;
    ///
    /// &lt;p&gt;The nature of this concept is "&lt;em&gt;transient&lt;/em&gt;" and depends directly on the &lt;a&gt;Session&lt;/a&gt;:
    /// &lt;br /&gt;it is considered as an extended collection of metadata related to the &lt;a&gt;Session&lt;/a&gt; that captures the overall state of the &lt;a&gt;Subject&lt;/a&gt; during the data recording.&lt;/p&gt;
    ///
    /// &lt;p&gt;A &lt;a&gt;SubjectState&lt;/a&gt; is, itself, a specialized &lt;a&gt;Descriptor&lt;/a&gt; that &lt;em&gt;may&lt;/em&gt; have multiple &lt;a&gt;Descriptor&lt;/a&gt;s associated with, which describe extended metadata sets such as the &lt;em&gt;HL7 Record&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : %CLASS_HIERARCHY% the different types of &lt;a&gt;SubjectState&lt;/a&gt;s that can be found in a &lt;a&gt;Session&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#SubjectState">bci:SubjectState</a>
    /// </summary>
    let SubjectState = _prefixId.prefix "SubjectState"
    let SubjectState'_period_'POWDER = _prefixId.prefix "SubjectState.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Represents a &lt;a title="Extensible Data Format" href="https://code.google.com/p/xdf/" target="_blank"&gt;XDF&lt;/a&gt; &lt;a&gt;DataFormat&lt;/a&gt;.
    ///
    /// &lt;br /&gt;&lt;em&gt;XDF&lt;/em&gt; is a general-purpose container format for multi-channel time series data with extensive associated meta-information.
    /// &lt;br /&gt;XDF is tailored towards biosignal data such as EEG, EMG, EOG, ECG, GSR, MEG, etc.
    /// &lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:16 AM 2016-06-03 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : XDF EEG data format^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF]^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : The &lt;a title="Extensible Data Format" href="https://code.google.com/p/xdf/" target="_blank"&gt;XDF&lt;/a&gt; &lt;a&gt;DataFormat&lt;/a&gt;.^^rdfs:Literal</para>
    ///   <para>dcterms:title : XdfDataFormat^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#XdfDataFormat">bci:XdfDataFormat</a>
    /// </summary>
    let XdfDataFormat = _prefixId.prefix "XdfDataFormat"
    let XdfDataFormat'_period_'POWDER = _prefixId.prefix "XdfDataFormat.POWDER"
    /// <summary>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : analizes^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Model&lt;/a&gt; with an &lt;a&gt;Aspect&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Indicates that an &lt;a&gt;Aspect&lt;/a&gt; is &lt;em&gt;analized&lt;/em&gt; by a &lt;a&gt;Model&lt;/a&gt; (throughout its &lt;strong&gt;State&lt;/strong&gt;s): analyzing looking for specific kind of &lt;a&gt;Marker&lt;/a&gt;s.
    ///
    /// &lt;br /&gt;A &lt;a&gt;Model&lt;/a&gt; is specific to the purpose of its BCI application, such as: stress level measurement or fatigue detection.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:55 AM 2016-06-28 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Model.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : analizes^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#analizes">bci:analizes</a>
    /// </summary>
    let analizes = _prefixId.prefix "analizes"
    let analizes'_period_'POWDER = _prefixId.prefix "analizes.POWDER"
    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : aspectOfInterest^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Record&lt;/a&gt; individual with its correspondent &lt;a&gt;Aspect&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : aspect of interest^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:19 AM 2016-07-21 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Record&lt;/a&gt; with its correspondent &lt;a&gt;Aspect&lt;/a&gt;. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Record&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;is generated by capturing&lt;/span&gt; an &lt;a&gt;Aspect&lt;/a&gt; (of interest)&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;a&gt;ssn:featureOfInterest&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// [&lt;em&gt;ssn:Observation&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:featureOfInterest&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:FeatureOfInterest&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp;[&lt;b&gt;Record&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;aspectOfInterest&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Aspect&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#aspectOfInterest">bci:aspectOfInterest</a>
    /// </summary>
    let aspectOfInterest = _prefixId.prefix "aspectOfInterest"
    let aspectOfInterest'_period_'POWDER = _prefixId.prefix "aspectOfInterest.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;p&gt;The relationship between an &lt;a&gt;Activity&lt;/a&gt; and a &lt;a&gt;Context&lt;/a&gt; is throughout a &lt;a&gt;Session&lt;/a&gt;, which connects also the &lt;a&gt;Subject&lt;/a&gt; (who performs the &lt;a&gt;Activity&lt;/a&gt; while interacting with the &lt;a&gt;Context&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : causes^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt; may &lt;em&gt;influence&lt;/em&gt; an &lt;a&gt;Activity&lt;/a&gt;, by &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;causing&lt;/em&gt;&lt;/span&gt; (triggering) a set of &lt;a&gt;Action&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:44 AM 2016-06-28 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt; individual with a correspondent &lt;a&gt;Action&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : causes^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Activity.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#causes">bci:causes</a>
    /// </summary>
    let causes = _prefixId.prefix "causes"
    let causes'_period_'POWDER = _prefixId.prefix "causes.POWDER"
    /// <summary>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>dcterms:title : detects^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : detects^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Device&lt;/a&gt; individual with its correspondent &lt;a&gt;StimulusEvent&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Device&lt;/a&gt; with its correspondent &lt;a&gt;StimulusEvent&lt;/a&gt; set. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Device&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;detects&lt;/span&gt; &lt;a&gt;StimulusEvent&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:detects&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;[&lt;em&gt;ssn:Sensor&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:detects&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Stimulus&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;[&lt;b&gt;Device&lt;/b&gt;] &amp;nbsp;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;nbsp;(&lt;b&gt;detects&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;StimulusEvent&lt;/b&gt;]&lt;/blockquote&gt;&lt;br /&gt;
    ///
    /// &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] A relation from a &lt;em&gt;ssn:Sensor&lt;/em&gt; to the &lt;em&gt;ssn:Stimulus&lt;/em&gt; that the &lt;em&gt;ssn:Sensor&lt;/em&gt; can &lt;em&gt;detect&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:02 AM 2016-07-25 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : StimulusEvent.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#detects">bci:detects</a>
    /// </summary>
    let detects = _prefixId.prefix "detects"
    let detects'_period_'POWDER = _prefixId.prefix "detects.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Relation between a &lt;a&gt;RecordChannelingSpec&lt;/a&gt; and a &lt;a&gt;ChannelingSpec&lt;/a&gt; that the observation &lt;em&gt;extends&lt;/em&gt; through the associated &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.
    /// &lt;br /&gt;The &lt;span style="text-decoration: underline;"&gt;object property composition&lt;/span&gt; (&lt;em&gt;owl:propertyChainAxiom&lt;/em&gt;) ensures that if a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; &lt;em&gt;extends&lt;/em&gt; a particular &lt;a&gt;ChannelingSpec&lt;/a&gt;,
    /// &lt;br /&gt;then one can infer that the &lt;a&gt;RecordChannelingSpec&lt;/a&gt; also &lt;em&gt;extends&lt;/em&gt; that &lt;a&gt;ChannelingSpec&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;This &lt;span style="text-decoration: underline;"&gt;object property composition&lt;/span&gt; describes the &lt;span style="text-decoration: underline;"&gt;extended spec&lt;/span&gt; of the &lt;em&gt;channeling schema&lt;/em&gt; information object:&lt;/p&gt;
    /// &lt;blockquote class="remark"&gt;
    /// &lt;a&gt;RecordChannelingSpec&lt;/a&gt;.&lt;em&gt;extendsDeviceChannelingSpec&lt;/em&gt; &lt;strong&gt;&amp;compfn;&lt;/strong&gt; &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.&lt;em&gt;extendsChannelingSpec&lt;/em&gt; &amp;Longrightarrow; &lt;a&gt;RecordChannelingSpec&lt;/a&gt;.&lt;em&gt;extends&lt;/em&gt; &amp;Assign; &lt;a&gt;ChannelingSpec&lt;/a&gt;.
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : extends^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : extends its related modality channeling schema spec^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;a&gt;hasDescriptor&lt;/a&gt; &lt;em&gt;sub property&lt;/em&gt; that connects a &lt;a&gt;RecordChannelingSpec&lt;/a&gt; with its related &lt;a&gt;ChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:41 AM 2016-07-29 $^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#extends">bci:extends</a>
    /// </summary>
    let extends = _prefixId.prefix "extends"
    let extends'_period_'POWDER = _prefixId.prefix "extends.POWDER"
    /// <summary>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;a&gt;hasDescriptor&lt;/a&gt; &lt;em&gt;sub property&lt;/em&gt; that connects a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; with its related &lt;a&gt;ChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : extends its modality channeling schema spec^^rdfs:Literal</para>
    ///   <para>dcterms:title : extendsChannelingSpec^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; with its related &lt;a&gt;ChannelingSpec&lt;/a&gt;.
    /// &lt;br /&gt;This relation states that a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; individual &lt;em&gt;extends&lt;/em&gt; its related &lt;a&gt;ChannelingSpec&lt;/a&gt; from which was derivated.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Device^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:18 AM 2016-07-29 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#extendsChannelingSpec">bci:extendsChannelingSpec</a>
    /// </summary>
    let extendsChannelingSpec = _prefixId.prefix "extendsChannelingSpec"

    let extendsChannelingSpec'_period_'POWDER = _prefixId.prefix "extendsChannelingSpec.POWDER"

    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;RecordChannelingSpec&lt;/a&gt; with its related &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.
    /// &lt;br /&gt;This relation states that a &lt;a&gt;RecordChannelingSpec&lt;/a&gt; individual &lt;em&gt;extends&lt;/em&gt; its related &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; from which was derivated.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:21 AM 2016-07-29 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;a&gt;hasDescriptor&lt;/a&gt; &lt;em&gt;sub property&lt;/em&gt; that connects a &lt;a&gt;RecordChannelingSpec&lt;/a&gt; with its related &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : extendsDeviceChannelingSpec^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : extends its device channeling schema spec^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#extendsDeviceChannelingSpec">bci:extendsDeviceChannelingSpec</a>
    /// </summary>
    let extendsDeviceChannelingSpec = _prefixId.prefix "extendsDeviceChannelingSpec"

    let extendsDeviceChannelingSpec'_period_'POWDER = _prefixId.prefix "extendsDeviceChannelingSpec.POWDER"

    /// <summary>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Channel&lt;/a&gt; to the supported &lt;a&gt;Modality&lt;/a&gt; is described for.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : for modality^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-MeasurementCapability^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:31 AM 2016-08-10 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dcterms:title : forModality^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Channel&lt;/a&gt; to the supported &lt;a&gt;Modality&lt;/a&gt; is described for.
    /// &lt;br /&gt;This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Channel&lt;/a&gt; is described &lt;span style="text-decoration: underline;"&gt;for&lt;/span&gt; (supports) &lt;a&gt;Modality&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;a&gt;ssn:forProperty&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;[&lt;em&gt;ssn:MeasurementCapability&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:forProperty&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Property&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;[&lt;b&gt;Channel&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;
    ///   (&lt;b&gt;forModality&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Modality&lt;/b&gt;]&lt;/blockquote&gt;&lt;br /&gt;
    ///
    /// &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] A relation from a &lt;a&gt;ssn:MeasurementCapability&lt;/a&gt; to the &lt;a&gt;ssn:Property&lt;/a&gt; the capability is described for. (Used in conjunction with &lt;a&gt;ssn:ofFeature&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#forModality">bci:forModality</a>
    /// </summary>
    let forModality = _prefixId.prefix "forModality"
    let forModality'_period_'POWDER = _prefixId.prefix "forModality.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasAccessMethod^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:18 AM 2016-06-01 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;RecordedData&lt;/a&gt; with its associated &lt;a&gt;AccessMethod&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;RecordedData&lt;/a&gt; with a set of &lt;a&gt;AccessMethod&lt;/a&gt;s that describes how the data is being accessed by the BCI application.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has BCI data access method^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasAccessMethod">bci:hasAccessMethod</a>
    /// </summary>
    let hasAccessMethod = _prefixId.prefix "hasAccessMethod"
    let hasAccessMethod'_period_'POWDER = _prefixId.prefix "hasAccessMethod.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 06:38 PM 2016-06-24 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects an &lt;a&gt;Activity&lt;/a&gt; with its correspondent &lt;a&gt;Action&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has action^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasAction^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an &lt;a&gt;Activity&lt;/a&gt; individual with its correspondent &lt;a&gt;Action&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Activity.png^^rdfs:Literal</para>
    ///   <para>ov:part : Session,Subject^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasAction">bci:hasAction</a>
    /// </summary>
    let hasAction = _prefixId.prefix "hasAction"
    let hasAction'_period_'POWDER = _prefixId.prefix "hasAction.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Session.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasActivity^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:10 AM 2016-06-28 $^^rdfs:Literal</para>
    ///   <para>ov:part : Session^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Session&lt;/a&gt; with its associated &lt;a&gt;Activity&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Session&lt;/a&gt; individual with its associated &lt;a&gt;Activity&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has activity^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasActivity">bci:hasActivity</a>
    /// </summary>
    let hasActivity = _prefixId.prefix "hasActivity"
    let hasActivity'_period_'POWDER = _prefixId.prefix "hasActivity.POWDER"
    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; with the set of &lt;a&gt;Channel&lt;/a&gt;s that comprises its internal structure.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; with its &lt;a&gt;Channel&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF]^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasChannelData^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has channel data (logical component)^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:19 AM 2016-08-14 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasChannelData">bci:hasChannelData</a>
    /// </summary>
    let hasChannelData = _prefixId.prefix "hasChannelData"
    let hasChannelData'_period_'POWDER = _prefixId.prefix "hasChannelData.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Modality&lt;/a&gt; with its related &lt;a&gt;ChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;a&gt;hasDescriptor&lt;/a&gt; &lt;em&gt;sub property&lt;/em&gt; for connecting a &lt;a&gt;Modality&lt;/a&gt; with its related &lt;a&gt;ChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:43 AM 2016-06-30 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has channeling schema spec^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasChannelingSpec^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasChannelingSpec">bci:hasChannelingSpec</a>
    /// </summary>
    let hasChannelingSpec = _prefixId.prefix "hasChannelingSpec"
    let hasChannelingSpec'_period_'POWDER = _prefixId.prefix "hasChannelingSpec.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasConfidence^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 09:23 PM 2016-05-22 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has confidence^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Captures the accuracy (&lt;em&gt;statistical level of confidence&lt;/em&gt;) of the &lt;a&gt;ResponseTag&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%
    /// Its Domain value consists of approximated arbitrary real numbers in the close range of &lt;strong&gt;[0..1]&lt;/strong&gt;.^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;Example: 0.75&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasConfidence">bci:hasConfidence</a>
    /// </summary>
    let hasConfidence = _prefixId.prefix "hasConfidence"
    let hasConfidence'_period_'POWDER = _prefixId.prefix "hasConfidence.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 11:39 PM 2016-06-12 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has data block set^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;DataSegment&lt;/a&gt; individual with its correspondent &lt;a&gt;DataBlock&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : DataSegment.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;DataSegment&lt;/a&gt; with its correspondent &lt;a&gt;DataBlock&lt;/a&gt; set.&lt;/p&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasDataBlock^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasDataBlock">bci:hasDataBlock</a>
    /// </summary>
    let hasDataBlock = _prefixId.prefix "hasDataBlock"
    let hasDataBlock'_period_'POWDER = _prefixId.prefix "hasDataBlock.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 01:24 AM 2016-06-01 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;RecordedData&lt;/a&gt; with its corresponding &lt;a&gt;DataFormat&lt;/a&gt; that describes the representation of the data &lt;em&gt;observed&lt;/em&gt; by a &lt;a&gt;Device&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has BCI data format^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasDataFormat^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;RecordedData&lt;/a&gt; with its corresponding &lt;a&gt;DataFormat&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasDataFormat">bci:hasDataFormat</a>
    /// </summary>
    let hasDataFormat = _prefixId.prefix "hasDataFormat"
    let hasDataFormat'_period_'POWDER = _prefixId.prefix "hasDataFormat.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;&lt;strong&gt;XSD dateTime&lt;/strong&gt;&lt;/span&gt; associated to an entity.&lt;/p&gt;
    ///
    /// &lt;p&gt;BCI applications should, at least, measure these time values in &lt;span style="text-decoration: underline;"&gt;minutes&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has date time^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasDateTime^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:35 AM 2016-06-29 $^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:source : [OWL-Time]^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasDateTime">bci:hasDateTime</a>
    /// </summary>
    let hasDateTime = _prefixId.prefix "hasDateTime"
    let hasDateTime'_period_'POWDER = _prefixId.prefix "hasDateTime.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasDescriptor^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects an &lt;em&gt;entity&lt;/em&gt; with a set of &lt;a&gt;Descriptor&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has external resource (descriptor)^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag,Context,Descriptor,Session,SSN-MeasurementCapability,SSN-Skeleton,Subject^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an &lt;em&gt;entity&lt;/em&gt; with a set of &lt;a&gt;Descriptor&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:43 AM 2016-06-30 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasDescriptor">bci:hasDescriptor</a>
    /// </summary>
    let hasDescriptor = _prefixId.prefix "hasDescriptor"
    let hasDescriptor'_period_'POWDER = _prefixId.prefix "hasDescriptor.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : has device channeling schema spec^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Device&lt;/a&gt; with its related &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;em&gt;sub property&lt;/em&gt; of &lt;a&gt;hasDescriptor&lt;/a&gt; for connecting a &lt;a&gt;Device&lt;/a&gt; with its related &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Device.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasDeviceChannelingSpec^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:33 AM 2016-07-19 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasDeviceChannelingSpec">bci:hasDeviceChannelingSpec</a>
    /// </summary>
    let hasDeviceChannelingSpec = _prefixId.prefix "hasDeviceChannelingSpec"

    let hasDeviceChannelingSpec'_period_'POWDER = _prefixId.prefix "hasDeviceChannelingSpec.POWDER"

    /// <summary>
    ///   <para>dcterms:title : hasDeviceSpec^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Device.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Device&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DeviceSpec&lt;/a&gt;) with its set of related &lt;a&gt;DeviceSpec&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF], [ESS]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has device spec^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:43 AM 2016-06-30 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;a&gt;hasDescriptor&lt;/a&gt; &lt;em&gt;sub property&lt;/em&gt; for connecting a (&lt;a&gt;Device&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DeviceSpec&lt;/a&gt;) with its set of &lt;a&gt;DeviceSpec&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasDeviceSpec">bci:hasDeviceSpec</a>
    /// </summary>
    let hasDeviceSpec = _prefixId.prefix "hasDeviceSpec"
    let hasDeviceSpec'_period_'POWDER = _prefixId.prefix "hasDeviceSpec.POWDER"
    /// <summary>
    ///   <para>dcterms:source : [XDF]^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:39 AM 2016-08-14 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasEegChannelData^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects an &lt;a&gt;EegDeviceChannelingSpec&lt;/a&gt; with the set of &lt;a&gt;EegChannel&lt;/a&gt;s that comprises its internal structure.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>owl:deprecated : &amp;laquo;Concerning EEG, this ontology only defines its related classes. It does not extend or define any specific properties for EEG.&amp;raquo;
    /// &lt;br /&gt;$ 04:27 AM 2016-07-29 $^^rdfs:Literalowl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:prefLabel : has EEG channel data^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an &lt;a&gt;EegDeviceChannelingSpec&lt;/a&gt; with its &lt;a&gt;EegChannel&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasEegChannelData">bci:hasEegChannelData</a>
    /// </summary>
    let hasEegChannelData = _prefixId.prefix "hasEegChannelData"
    let hasEegChannelData'_period_'POWDER = _prefixId.prefix "hasEegChannelData.POWDER"
    /// <summary>
    ///   <para>owl:deprecated : &amp;laquo;Concerning EEG, this ontology only defines its related classes. It does not extend or define any specific properties for EEG.&amp;raquo;
    /// &lt;br /&gt;$ 04:27 AM 2016-07-29 $^^rdfs:Literalowl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:editorialNote : &lt;p&gt;This ontology leaves open to BCI applications the way how they should describe properly basic &lt;b&gt;non-channeling measurement capabilities&lt;/b&gt; for its relevant set of different classes of sensors (&lt;a&gt;Device&lt;/a&gt; class hierarchy) used in BCI activities, following the description of the &lt;em&gt;ssn:MeasurementCapability&lt;/em&gt; &lt;a title="SSN MeasuringCapability module - (5.3.5.2) How to describe capabilities of a sensor?" href="http://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#How_to_describe_capabilities_of_a_sensor.3F" target="_blank"&gt;concept&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;Based on their system requirements, BCI applications may define a set of restrictions and specialized connections (subproperties) on the property &lt;a&gt;hasNonChannelData&lt;/a&gt; (subproperty of &lt;em&gt;ssn:hasMeasurementCapability&lt;/em&gt;) for each particular subclass of &lt;a&gt;Device&lt;/a&gt; (subclass of &lt;em&gt;ssn:Sensor&lt;/em&gt;), which describes sensors for specific types.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:48 AM 2016-08-10 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has non-channeling EEG data (other EEG measurement capability)^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasEegNonChannelData^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] Relation from a &lt;a&gt;EegDevice&lt;/a&gt; to its &lt;a&gt;EegNonChannel&lt;/a&gt; describing the &lt;b&gt;non-channeling measurement capabilities&lt;/b&gt; (a set of &lt;em&gt;measurement properties&lt;/em&gt;) of the &lt;span style="text-decoration: underline;"&gt;EEG BCI device&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasEegNonChannelData">bci:hasEegNonChannelData</a>
    /// </summary>
    let hasEegNonChannelData = _prefixId.prefix "hasEegNonChannelData"

    let hasEegNonChannelData'_period_'POWDER = _prefixId.prefix "hasEegNonChannelData.POWDER"

    /// <summary>
    ///   <para>dcterms:modified : $ 01:59 AM 2016-07-19 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literaldctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;The &lt;em&gt;channel number&lt;/em&gt; in the recording where the &lt;span style="text-decoration: underline;"&gt;modality block&lt;/span&gt; ends.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasEndChannel^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has end channel^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [XDF]^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasEndChannel">bci:hasEndChannel</a>
    /// </summary>
    let hasEndChannel = _prefixId.prefix "hasEndChannel"
    let hasEndChannel'_period_'POWDER = _prefixId.prefix "hasEndChannel.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 02:44 AM 2016-06-30 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;&lt;strong&gt;XSD dateTime&lt;/strong&gt;&lt;/span&gt; associated to an entity, that indicates the &lt;strong&gt;ending-point&lt;/strong&gt; of a &lt;em&gt;time interval&lt;/em&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;BCI applications should, at least, measure these time values in &lt;span style="text-decoration: underline;"&gt;seconds&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasEndTime^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;For simplicity, this ontology does not define explicitly a &lt;em&gt;TimeInterval&lt;/em&gt; concept.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:source : [OWL-Time]^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has end (final) date time^^rdfs:Literal</para>
    ///   <para>ov:part : Context,Session,SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : TimeInterval.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasEndTime">bci:hasEndTime</a>
    /// </summary>
    let hasEndTime = _prefixId.prefix "hasEndTime"
    let hasEndTime'_period_'POWDER = _prefixId.prefix "hasEndTime.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : has intensity level^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:21 AM 2016-05-24 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasIntensityLevel^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%
    /// Its Domain value is all the &lt;em&gt;positive integer&lt;/em&gt;s: &lt;strong&gt;{ 1, 2, 3, ... }&lt;/strong&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;&lt;a&gt;Aspect&lt;/a&gt;: the measurement of the intensity depends on the nature of the &lt;a&gt;Aspect&lt;/a&gt; and purpose of the BCI application.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Indicates the &lt;span style="text-decoration: underline;"&gt;level of intensity&lt;/span&gt; related to its concept.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasIntensityLevel">bci:hasIntensityLevel</a>
    /// </summary>
    let hasIntensityLevel = _prefixId.prefix "hasIntensityLevel"
    let hasIntensityLevel'_period_'POWDER = _prefixId.prefix "hasIntensityLevel.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;p&gt;If necessary, BCI applications may extend the definition of this attribute to specify the preferred &lt;strong&gt;notation scheme&lt;/strong&gt;, using the semantic annotation &lt;a&gt;skos:notation&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag,SSN-MeasurementCapability^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [XDF]^^xsd:string</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:19 AM 2016-08-14 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;ul&gt;
    /// &lt;li&gt;In a &lt;a&gt;Channel&lt;/a&gt;: this attribute is used for &lt;span style="text-decoration: underline;"&gt;codification&lt;/span&gt; (reference) and &lt;span style="text-decoration: underline;"&gt;search&lt;/span&gt; (access) purposes,
    /// &lt;br /&gt;according to a preferred &lt;span style="text-decoration: underline;"&gt;labeling scheme&lt;/span&gt; (see the &lt;strong&gt;editorial note&lt;/strong&gt;).&lt;/li&gt;
    ///
    /// &lt;li&gt;In a &lt;a&gt;Marker&lt;/a&gt;: this attribute indicates a &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;marker type&lt;/span&gt;&lt;/em&gt;. For example: "110" = "Red light being flashed".&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has label^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A human-readable and descriptive label for general identification purposes associated to an instance.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasLabel^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:historyNote : &lt;p&gt;Related to &lt;a&gt;Channel&lt;/a&gt;, this concept has the following definitions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;[&lt;strong&gt;ESS 2.0&lt;/strong&gt;]: a comma separated list of labels of the corresponding &lt;span style="text-decoration: underline;"&gt;referenced channel or channels&lt;/span&gt;. This node is required for &lt;em&gt;EEG Modality&lt;/em&gt; and it's used during EEG or ECG recording.
    /// &lt;br /&gt;For example, if using 10-20 system and numerical average of both mastoids, use "A1, A2" for {&lt;em&gt;referenceLabel&lt;/em&gt;} and "Mastoids" for {&lt;em&gt;referenceLocation&lt;/em&gt;}. Note that there could be multiple labels.&lt;/li&gt;
    ///
    /// &lt;li&gt;[&lt;strong&gt;XDF&lt;/strong&gt;] &lt;em&gt;Signal referencing scheme&lt;/em&gt;: name of the dedicated &lt;span style="text-decoration: underline;"&gt;reference channel(s)&lt;/span&gt;, if part of the measured channels (repeated if multiple).
    /// &lt;br /&gt;For an EEG channel label, its value is based on the labeling scheme. For EEG, the preferred labeling scheme is 10-20 (or the finer-grained 10-5).&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasLabel">bci:hasLabel</a>
    /// </summary>
    let hasLabel = _prefixId.prefix "hasLabel"
    let hasLabel'_period_'POWDER = _prefixId.prefix "hasLabel.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasLocation^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Context&lt;/a&gt; with an &lt;em&gt;entity&lt;/em&gt; that represents or describes its location.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>owl:deprecated : true^^xsd:booleanowl:deprecated : &amp;laquo;This ontology will not define a "location" concept of a &lt;a&gt;Context&lt;/a&gt;. BCI applications may extend its own ontology to include this definition if necessary.&amp;raquo;
    /// &lt;br /&gt;$ 06:26 AM 2016-08-14 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Context&lt;/a&gt; with an &lt;em&gt;entity&lt;/em&gt; that represents or describes its location.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:22 AM 2016-08-14 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has location^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasLocation">bci:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    let hasLocation'_period_'POWDER = _prefixId.prefix "hasLocation.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : has locator (IRI)^^rdfs:Literal</para>
    ///   <para>ov:part : Descriptor,SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;ul&gt;
    /// &lt;li&gt;&lt;a&gt;AccessMethod&lt;/a&gt;: access to the Web resource that represents the &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;Data File&lt;/em&gt;&lt;/span&gt; that storages the &lt;a&gt;Record&lt;/a&gt;.&lt;/li&gt;
    /// &lt;li&gt;&lt;a&gt;Descriptor&lt;/a&gt;: external Web resource IRI.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 07:42 PM 2016-06-02 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasLocator^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;A &lt;a title="Hypertext Transfer Protocol" href="https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol" target="_blank"&gt;&lt;em&gt;http&lt;/em&gt;-schemed IRI&lt;/a&gt; has the ability for &lt;em&gt;&lt;a title="Content negotiation" href="https://en.wikipedia.org/wiki/Content_negotiation" target="_blank"&gt;content-type negotiation&lt;/a&gt;&lt;/em&gt;; and thus, it can process the &lt;em&gt;&lt;a title="Media type (also, MIME type and content type)" href="https://en.wikipedia.org/wiki/Media_type" target="_blank"&gt;media type&lt;/a&gt;&lt;/em&gt; of the &lt;span style="text-decoration: underline;"&gt;Web resource&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;An &lt;em&gt;&lt;a title="Internationalized Resource Identifier" href="https://en.wikipedia.org/wiki/Internationalized_Resource_Identifier" target="_blank"&gt;IRI locator&lt;/a&gt;&lt;/em&gt; to access a &lt;em&gt;&lt;a title="Web resource" href="https://en.wikipedia.org/wiki/Web_resource" target="_blank"&gt;Web resource&lt;/a&gt;&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasLocator">bci:hasLocator</a>
    /// </summary>
    let hasLocator = _prefixId.prefix "hasLocator"
    let hasLocator'_period_'POWDER = _prefixId.prefix "hasLocator.POWDER"
    /// <summary>
    ///   <para>dcterms:format : &lt;p&gt;As defined in:
    /// &lt;br /&gt;&lt;strong&gt;MQTT Version 3.1.1 Plus Errata 01&lt;/strong&gt;&lt;br /&gt;(&lt;em&gt;OASIS Standard Incorporating Approved Errata 01 10 December 2015&lt;/em&gt;) &amp;ndash; &lt;span style="text-decoration: underline;"&gt;1. Introduction&lt;/span&gt; &amp;ndash; (&lt;a title="Data representations" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180826" target="_blank"&gt;1.5 Data representations&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes the &lt;em&gt;broker&lt;/em&gt; (a &lt;span style="text-decoration: underline;"&gt;MQTT Server&lt;/span&gt;) parameter in an &lt;a&gt;AccessMethod.MQTT&lt;/a&gt; connection.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has MQTT broker^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literaldcterms:conformsTo : &lt;p&gt;A &lt;em&gt;broker&lt;/em&gt; (or &lt;span style="text-decoration: underline;"&gt;MQTT Server&lt;/span&gt;) conforms to the following definition in the &lt;a title="OASIS MQTT Version 3.1.1 Plus Errata 01" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/mqtt-v3.1.1.html" target="_blank"&gt;latest OASIS MQTT specification&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;p&gt;&lt;strong&gt;MQTT Version 3.1.1 Plus Errata 01&lt;/strong&gt;&lt;br /&gt;(&lt;em&gt;OASIS Standard Incorporating Approved Errata 01 10 December 2015&lt;/em&gt;) &amp;ndash; &lt;span style="text-decoration: underline;"&gt;1.2 Terminology&lt;/span&gt; &amp;ndash; (&lt;a title="MQTT Server definition" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180823" target="_blank"&gt;Server&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasMQTT.Broker^^rdfs:Literal</para>
    ///   <para>owl:deprecated : &amp;laquo;This ontology should be agnostic to the data access&amp;raquo;
    /// &lt;br /&gt;$ 04:35 AM 2016-07-05 $^^rdfs:Literalowl:deprecated : true^^xsd:boolean</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasMQTT.Broker">bci:hasMQTT.Broker</a>
    /// </summary>
    let hasMQTT'_period_'Broker = _prefixId.prefix "hasMQTT.Broker"

    let hasMQTT'_period_'Broker'_period_'POWDER = _prefixId.prefix "hasMQTT.Broker.POWDER"

    /// <summary>
    ///   <para>dcterms:modified : $ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasMQTT.ID^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>owl:deprecated : true^^xsd:booleanowl:deprecated : &amp;laquo;This ontology should be agnostic to the data access&amp;raquo;
    /// &lt;br /&gt;$ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:format : The &lt;em&gt;Client Identifier&lt;/em&gt; MUST be a &lt;span style="text-decoration: underline;"&gt;UTF-8 encoded string&lt;/span&gt; as defined in &lt;strong&gt;Section 1.5.3&lt;/strong&gt; of the &lt;a title="OASIS MQTT Version 3.1.1 Plus Errata 01" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/mqtt-v3.1.1.html" target="_blank"&gt;latest OASIS MQTT specification&lt;/a&gt;:
    ///
    /// &lt;p&gt;&lt;strong&gt;MQTT Version 3.1.1 Plus Errata 01&lt;/strong&gt;&lt;br /&gt;(&lt;em&gt;OASIS Standard Incorporating Approved Errata 01 10 December 2015&lt;/em&gt;) &amp;ndash; &lt;span style="text-decoration: underline;"&gt;1. Introduction&lt;/span&gt; &amp;ndash; (&lt;a title="Data representations" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180826" target="_blank"&gt;1.5 Data representations&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literaldcterms:conformsTo : &lt;p&gt;A &lt;em&gt;Client Identifier&lt;/em&gt; (or &lt;span style="text-decoration: underline;"&gt;ClientId&lt;/span&gt;) conforms to the following definition in the &lt;a title="OASIS MQTT Version 3.1.1 Plus Errata 01" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/mqtt-v3.1.1.html" target="_blank"&gt;latest OASIS MQTT specification&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;p&gt;&lt;strong&gt;MQTT Version 3.1.1 Plus Errata 01&lt;/strong&gt;&lt;br /&gt;(&lt;em&gt;OASIS Standard Incorporating Approved Errata 01 10 December 2015&lt;/em&gt;) &amp;ndash;
    ///
    /// &lt;br /&gt;&lt;span style="text-decoration: underline;"&gt;3. MQTT Control Packets / 3.1. CONNECT  / 3.1.3. Payload&lt;/span&gt; &amp;ndash; (&lt;a title="Client Identifier definition" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180844" target="_blank"&gt;3.1.3.1. Client Identifier&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes the &lt;em&gt;Client Identifier (ClientId)&lt;/em&gt; parameter in an &lt;a&gt;AccessMethod.MQTT&lt;/a&gt; connection. This parameter identifies the Client to the MQTT Server.&lt;/p&gt;
    ///
    /// ^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has MQTT ID^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasMQTT.ID">bci:hasMQTT.ID</a>
    /// </summary>
    let hasMQTT'_period_'ID = _prefixId.prefix "hasMQTT.ID"
    let hasMQTT'_period_'ID'_period_'POWDER = _prefixId.prefix "hasMQTT.ID.POWDER"
    /// <summary>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literaldcterms:conformsTo : &lt;p&gt;A &lt;em&gt;Topic&lt;/em&gt; conforms to the following definitions in the &lt;a title="OASIS MQTT Version 3.1.1 Plus Errata 01" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/mqtt-v3.1.1.html" target="_blank"&gt;latest OASIS MQTT specification&lt;/a&gt;:&lt;/p&gt;
    /// &lt;p&gt;&lt;strong&gt;MQTT Version 3.1.1 Plus Errata 01&lt;/strong&gt;&lt;br /&gt;(&lt;em&gt;OASIS Standard Incorporating Approved Errata 01 10 December 2015&lt;/em&gt;) &amp;ndash;&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;3. MQTT Control Packets / 3.3 PUBLISH &amp;ndash; Publish message&lt;/span&gt; &amp;ndash; (&lt;a title="PUBLISH &amp;ndash; Topic Name definition" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180852" target="_blank"&gt;3.3.2.1. Topic Name&lt;/a&gt;).&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;span style="text-decoration: underline;"&gt;3. MQTT Control Packets / 3.8 SUBSCRIBE &amp;ndash; Subscribe to topics&lt;/span&gt; &amp;ndash; (&lt;a title="SUBSCRIBE &amp;ndash; Topic Filters definition" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180879" target="_blank"&gt;3.8.3 Payload&lt;/a&gt;).&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Describes the &lt;em&gt;Topic (name or filter)&lt;/em&gt; parameter in an &lt;a&gt;AccessMethod.MQTT&lt;/a&gt; connection.
    /// &lt;br /&gt;This parameter identifies either:&lt;/p&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;The &lt;em&gt;Topic Name&lt;/em&gt; (for the &lt;a title="MQTT specification: PUBLISH &amp;ndash; Publish message" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180850" target="_blank"&gt;PUBLISH message&lt;/a&gt;), which identifies the information channel to which payload data is published.&lt;/li&gt;
    ///
    /// &lt;li&gt;The &lt;em&gt;Topic Filter&lt;/em&gt; (for the &lt;a title="MQTT specification: SUBSCRIBE &amp;ndash; Subscribe to topics" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180876" target="_blank"&gt;SUBSCRIBE message&lt;/a&gt;), which corresponds to the Client&amp;rsquo;s interest in one or more Topics (each subscription registers a Client&amp;rsquo;s interest in a Server).&lt;br /&gt;The payload of a SUBSCRIBE packet contains at least one Topic Filter.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;The usage of this parameter (for either &lt;span style="text-decoration: underline;"&gt;publishing data&lt;/span&gt;  &amp;ndash;&lt;em&gt;Topic Name&lt;/em&gt;&amp;ndash; or &lt;span style="text-decoration: underline;"&gt;subscribe&lt;/span&gt; to specific topics) depends on the purpose and implementation of the BCI application.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>owl:deprecated : &amp;laquo;This ontology should be agnostic to the data access&amp;raquo;
    /// &lt;br /&gt;$ 04:35 AM 2016-07-05 $^^rdfs:Literalowl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:modified : $ 04:35 AM 2016-07-05 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has MQTT topic^^rdfs:Literal</para>
    ///   <para>dcterms:format : The &lt;em&gt;Topic&lt;/em&gt; MUST be a &lt;span style="text-decoration: underline;"&gt;UTF-8 encoded string&lt;/span&gt; as defined in &lt;strong&gt;Section 1.5.3&lt;/strong&gt; of the &lt;a title="OASIS MQTT Version 3.1.1 Plus Errata 01" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/mqtt-v3.1.1.html" target="_blank"&gt;latest OASIS MQTT specification&lt;/a&gt;:
    ///
    /// &lt;p&gt;&lt;strong&gt;MQTT Version 3.1.1 Plus Errata 01&lt;/strong&gt;
    /// &lt;br /&gt;(&lt;em&gt;OASIS Standard Incorporating Approved Errata 01 10 December 2015&lt;/em&gt;) &amp;ndash; &lt;span style="text-decoration: underline;"&gt;1. Introduction&lt;/span&gt; &amp;ndash; (&lt;a title="Data representations" href="http://docs.oasis-open.org/mqtt/mqtt/v3.1.1/errata01/os/mqtt-v3.1.1-errata01-os-complete.html#_Toc442180826" target="_blank"&gt;1.5 Data representations&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasMQTT.Topic^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasMQTT.Topic">bci:hasMQTT.Topic</a>
    /// </summary>
    let hasMQTT'_period_'Topic = _prefixId.prefix "hasMQTT.Topic"
    let hasMQTT'_period_'Topic'_period_'POWDER = _prefixId.prefix "hasMQTT.Topic.POWDER"
    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Record&lt;/a&gt; with a &lt;a&gt;ssn:MeasurementProperty&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasMeasurementProperty^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has SSN measurement property^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:26 AM 2016-08-23 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Record&lt;/a&gt; with a set of &lt;a&gt;ssn:MeasurementProperty&lt;/a&gt;-ies.
    /// &lt;br /&gt;Through this relationship, BCI applications may extend the relevant metadata set related to the &lt;a&gt;Record&lt;/a&gt; concept.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasMeasurementProperty">bci:hasMeasurementProperty</a>
    /// </summary>
    let hasMeasurementProperty = _prefixId.prefix "hasMeasurementProperty"

    let hasMeasurementProperty'_period_'POWDER = _prefixId.prefix "hasMeasurementProperty.POWDER"

    /// <summary>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an &lt;a&gt;Aspect&lt;/a&gt; with its correspondent &lt;a&gt;Modality&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasModality^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has modality^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:21 AM 2016-07-26 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects an &lt;a&gt;Aspect&lt;/a&gt; with its correspondent &lt;a&gt;Modality&lt;/a&gt; set. This can be read, as follow: "&lt;em&gt;An &lt;a&gt;Aspect&lt;/a&gt;  &lt;span style="text-decoration: underline;"&gt;has&lt;/span&gt; &lt;a&gt;Modality&lt;/a&gt;(ies)&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:hasProperty&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// [&lt;em&gt;ssn:FeatureOfInterest&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:hasProperty&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Property&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;[&lt;b&gt;Aspect&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;hasModality&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Modality&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasModality">bci:hasModality</a>
    /// </summary>
    let hasModality = _prefixId.prefix "hasModality"
    let hasModality'_period_'POWDER = _prefixId.prefix "hasModality.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 02:32 AM 2016-05-23 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasModel^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;ResponseTag&lt;/a&gt; &lt;em&gt;is associated with (has)&lt;/em&gt; a &lt;a&gt;Model&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Model.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;ResponseTag&lt;/a&gt; with its correspondent &lt;a&gt;Model&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has model^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasModel">bci:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    let hasModel'_period_'POWDER = _prefixId.prefix "hasModel.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasModelIRI^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;It's the IRI of the resource that describes or represents the &lt;a&gt;Model&lt;/a&gt; or &lt;em&gt;classifier&lt;/em&gt;.
    /// &lt;br /&gt;A &lt;a&gt;Model&lt;/a&gt; can be described in any language or format, such as &lt;a title="Predictive Model Markup Language" href="https://en.wikipedia.org/wiki/Predictive_Model_Markup_Language" target="_blank"&gt;PMML&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:03 AM 2016-05-23 $^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has model IRI^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasModelIRI">bci:hasModelIRI</a>
    /// </summary>
    let hasModelIRI = _prefixId.prefix "hasModelIRI"
    let hasModelIRI'_period_'POWDER = _prefixId.prefix "hasModelIRI.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasNext^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;RecordedData&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;) with its following (&lt;span style="text-decoration: underline;"&gt;&lt;em&gt;next&lt;/em&gt;&lt;/span&gt;) (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;RecordedData&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;) of the sequence.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has next (following)^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;ul&gt;
    /// &lt;li&gt;[&lt;a&gt;Context.Scene&lt;/a&gt;] On a &lt;strong&gt;Video Game&lt;/strong&gt;: (&lt;em&gt;Level&lt;/em&gt; 3-2) &lt;span style="text-decoration: underline;"&gt;hasNext&lt;/span&gt; (&lt;em&gt;Level&lt;/em&gt; 3-3).&lt;/li&gt;
    /// &lt;li&gt;[&lt;a&gt;Record&lt;/a&gt;]: an observation is linked to its following observation. Their difference could be on their &lt;span style="text-decoration: underline;"&gt;channeling settings&lt;/span&gt;.&lt;/li&gt;
    /// &lt;li&gt;[&lt;a&gt;RecordedData&lt;/a&gt;]: links to the following data version of the current data set.&lt;/li&gt;
    /// &lt;li&gt;[&lt;a&gt;DataBlock&lt;/a&gt;]: points to the following data unit value from the current one along the sequence.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:50 AM 2016-07-07 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;RecordedData&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;) with its &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;next&lt;/em&gt;&lt;/span&gt; correspondent (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;RecordedData&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.Scene.png^^rdfs:Literaldctype:StillImage : DataBlock.png^^rdfs:Literal</para>
    ///   <para>ov:part : Context,SSN-Data,SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasNext">bci:hasNext</a>
    /// </summary>
    let hasNext = _prefixId.prefix "hasNext"
    let hasNext'_period_'POWDER = _prefixId.prefix "hasNext.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : has non-channeling data (other BCI measurement capability)^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] Relation from a &lt;a&gt;Device&lt;/a&gt; to a &lt;a&gt;NonChannel&lt;/a&gt; describing the &lt;b&gt;non-channeling measurement capabilities&lt;/b&gt; (a set of &lt;em&gt;measurement properties&lt;/em&gt;) of the &lt;span style="text-decoration: underline;"&gt;BCI device&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:44 AM 2016-08-10 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;This ontology leaves open to BCI applications the way how they should describe properly basic &lt;b&gt;non-channeling measurement capabilities&lt;/b&gt; for its relevant set of different classes of sensors (&lt;a&gt;Device&lt;/a&gt; class hierarchy) used in BCI activities, following the description of the &lt;em&gt;ssn:MeasurementCapability&lt;/em&gt; &lt;a title="SSN MeasuringCapability module - (5.3.5.2) How to describe capabilities of a sensor?" href="http://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#How_to_describe_capabilities_of_a_sensor.3F" target="_blank"&gt;concept&lt;/a&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;Based on their system requirements, BCI applications may define a set of restrictions and specialized connections (subproperties) on the property &lt;a&gt;hasNonChannelData&lt;/a&gt; (subproperty of &lt;em&gt;ssn:hasMeasurementCapability&lt;/em&gt;) for each particular subclass of &lt;a&gt;Device&lt;/a&gt; (subclass of &lt;em&gt;ssn:Sensor&lt;/em&gt;), which describes sensors for specific types.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasNonChannelData^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasNonChannelData">bci:hasNonChannelData</a>
    /// </summary>
    let hasNonChannelData = _prefixId.prefix "hasNonChannelData"
    let hasNonChannelData'_period_'POWDER = _prefixId.prefix "hasNonChannelData.POWDER"
    /// <summary>
    ///   <para>dcterms:description : ** HIDDEN CONTENT **
    /// ==============================================================================
    /// &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;EEG 10/20 system channeling schema&lt;/span&gt;.&lt;/p&gt;
    /// ==============================================================================^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [XDF]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has number of channels^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literaldctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;p&gt;Instead of using this generic datatype property, some BCI applications could define the following &lt;span style="text-decoration: underline;"&gt;specific attributes&lt;/span&gt;,
    /// &lt;br /&gt;according to the recording setup, &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; and &lt;a&gt;Record&lt;/a&gt;'s &lt;a&gt;Modality&lt;/a&gt;:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;Number of used LEDs.&lt;/li&gt;
    /// &lt;li&gt;Number of used cameras.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;[&lt;b&gt;XDF&lt;/b&gt;]: &amp;lt;&lt;em&gt;channel_count&lt;/em&gt;&amp;gt; is a non-negative integer that encodes the number of channels in the stream.
    /// &lt;br /&gt;[&lt;b&gt;ESS 1.0&lt;/b&gt;]: number of (&lt;span style="text-decoration: underline;"&gt;used&lt;/span&gt;) data channels.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Captures the number of channels used in a &lt;a&gt;Record&lt;/a&gt; or supported by a &lt;a&gt;Device&lt;/a&gt;. Its value is expected to be a &lt;em&gt;positive integer&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasNumberOfChannels^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:57 AM 2016-10-12 $^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device,SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasNumberOfChannels">bci:hasNumberOfChannels</a>
    /// </summary>
    let hasNumberOfChannels = _prefixId.prefix "hasNumberOfChannels"

    let hasNumberOfChannels'_period_'POWDER = _prefixId.prefix "hasNumberOfChannels.POWDER"

    /// <summary>
    ///   <para>dcterms:source : [Unity]^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasObject^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Context.Object&lt;/a&gt;) with its &lt;a&gt;Context.Object&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has object^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.Object.png^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Context.Object&lt;/a&gt;) with the set of &lt;a&gt;Context.Object&lt;/a&gt;s that comprises its internal structure.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 09:27 PM 2016-05-16 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasObject">bci:hasObject</a>
    /// </summary>
    let hasObject = _prefixId.prefix "hasObject"
    let hasObject'_period_'POWDER = _prefixId.prefix "hasObject.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasObjectComponent^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has object component^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.ObjectComponent.png^^rdfs:Literal</para>
    ///   <para>dcterms:source : [Unity]^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Context.Object&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Context.ObjectComponent&lt;/a&gt;) with the set of &lt;a&gt;Context.ObjectComponent&lt;/a&gt;s that comprises its internal structure.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Context.Object&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Context.ObjectComponent&lt;/a&gt;) with its &lt;a&gt;Context.ObjectComponent&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 10:53 PM 2016-05-16 $
    /// ^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasObjectComponent">bci:hasObjectComponent</a>
    /// </summary>
    let hasObjectComponent = _prefixId.prefix "hasObjectComponent"

    let hasObjectComponent'_period_'POWDER = _prefixId.prefix "hasObjectComponent.POWDER"

    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Data^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has offset^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasOffset^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : DataBlock.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Indicates the &lt;span style="text-decoration: underline;"&gt;offset (&lt;em&gt;start time&lt;/em&gt;)&lt;/span&gt; of the &lt;a&gt;DataBlock&lt;/a&gt;. Its measurement unit (dimensional) is in &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;milliseconds&lt;/span&gt;&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:17 AM 2016-06-12 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasOffset">bci:hasOffset</a>
    /// </summary>
    let hasOffset = _prefixId.prefix "hasOffset"
    let hasOffset'_period_'POWDER = _prefixId.prefix "hasOffset.POWDER"
    /// <summary>
    ///   <para>ov:part : SSN-Data^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has (ordinal) position^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Indicates the &lt;span style="text-decoration: underline;"&gt;ordinal position&lt;/span&gt; of the &lt;a&gt;DataBlock&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:44 AM 2016-06-12 $^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasOrdinalPosition^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : DataBlock.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasOrdinalPosition">bci:hasOrdinalPosition</a>
    /// </summary>
    let hasOrdinalPosition = _prefixId.prefix "hasOrdinalPosition"

    let hasOrdinalPosition'_period_'POWDER = _prefixId.prefix "hasOrdinalPosition.POWDER"

    /// <summary>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Session&lt;/a&gt;) with its &lt;a&gt;Playout&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 07:16 PM 2016-05-18 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasPlayout^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Playout.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Session&lt;/a&gt;) with its set of &lt;a&gt;Playout&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has playout record^^rdfs:Literal</para>
    ///   <para>ov:part : Context,Session^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasPlayout">bci:hasPlayout</a>
    /// </summary>
    let hasPlayout = _prefixId.prefix "hasPlayout"
    let hasPlayout'_period_'POWDER = _prefixId.prefix "hasPlayout.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Activity.png^^rdfs:Literaldctype:StillImage : PlayoutInstant.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has playout instant^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Playout&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Action&lt;/a&gt;) with its correspondent &lt;a&gt;PlayoutInstant&lt;/a&gt;(ces) log entries.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:39 AM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>ov:part : Context,Session^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Playout&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Action&lt;/a&gt;) individual with its correspondent &lt;a&gt;PlayoutInstant&lt;/a&gt;(ces)&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasPlayoutInstant^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasPlayoutInstant">bci:hasPlayoutInstant</a>
    /// </summary>
    let hasPlayoutInstant = _prefixId.prefix "hasPlayoutInstant"
    let hasPlayoutInstant'_period_'POWDER = _prefixId.prefix "hasPlayoutInstant.POWDER"
    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has previous (before)^^rdfs:Literal</para>
    ///   <para>ov:part : Context,SSN-Data,SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;RecordedData&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;) with its &lt;span style="text-decoration: underline;"&gt;&lt;em&gt;previous&lt;/em&gt;&lt;/span&gt; (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;RecordedData&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;) of the sequence.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:example : &lt;ul&gt;
    /// &lt;li&gt;[&lt;a&gt;Context.Scene&lt;/a&gt;] On a &lt;strong&gt;Video Game&lt;/strong&gt;: (&lt;em&gt;Level&lt;/em&gt; 3-2) &lt;span style="text-decoration: underline;"&gt;hasPrevious&lt;/span&gt; (&lt;em&gt;Level&lt;/em&gt; 3-1).&lt;/li&gt;
    /// &lt;li&gt;[&lt;a&gt;Record&lt;/a&gt;]: an observation is linked to its previous observation. Their difference could be on their &lt;span style="text-decoration: underline;"&gt;channeling settings&lt;/span&gt;.&lt;/li&gt;
    /// &lt;li&gt;[&lt;a&gt;RecordedData&lt;/a&gt;]: links to the previous data version of the current data set.&lt;/li&gt;
    /// &lt;li&gt;[&lt;a&gt;DataBlock&lt;/a&gt;]: points to the previous data unit value from the current one along the sequence.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasPrevious^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt;  &lt;a&gt;RecordedData&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;) with its &lt;em&gt;&lt;span style="text-decoration: underline;"&gt;previous&lt;/span&gt;&lt;/em&gt; (&lt;a&gt;Context.Scene&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt;  &lt;a&gt;RecordedData&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;DataBlock&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : DataBlock.png^^rdfs:Literaldctype:StillImage : Context.Scene.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:50 AM 2016-07-07 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasPrevious">bci:hasPrevious</a>
    /// </summary>
    let hasPrevious = _prefixId.prefix "hasPrevious"
    let hasPrevious'_period_'POWDER = _prefixId.prefix "hasPrevious.POWDER"
    /// <summary>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Subject&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Session&lt;/a&gt;) with its related set of &lt;a&gt;Record&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Session,Subject^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:07 AM 2016-06-24 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has BCI record^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasRecord^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Subject&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Session&lt;/a&gt;) with a set of &lt;a&gt;Record&lt;/a&gt;s that are associated with it.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasRecord">bci:hasRecord</a>
    /// </summary>
    let hasRecord = _prefixId.prefix "hasRecord"
    let hasRecord'_period_'POWDER = _prefixId.prefix "hasRecord.POWDER"
    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;a&gt;hasDescriptor&lt;/a&gt; &lt;em&gt;sub property&lt;/em&gt; for connecting a &lt;a&gt;Record&lt;/a&gt; with its related &lt;a&gt;RecordChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has record channeling schema spec^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasRecordChannelingSpec^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:24 AM 2016-07-18 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Record&lt;/a&gt; with its related &lt;a&gt;RecordChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasRecordChannelingSpec">bci:hasRecordChannelingSpec</a>
    /// </summary>
    let hasRecordChannelingSpec = _prefixId.prefix "hasRecordChannelingSpec"

    let hasRecordChannelingSpec'_period_'POWDER = _prefixId.prefix "hasRecordChannelingSpec.POWDER"

    /// <summary>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;a&gt;hasDescriptor&lt;/a&gt; &lt;em&gt;sub property&lt;/em&gt; for connecting a (&lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;RecordSpec&lt;/a&gt;) with its set of &lt;a&gt;RecordSpec&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Record&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;RecordSpec&lt;/a&gt;) with its set of related &lt;a&gt;RecordSpec&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has record spec^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF], [ESS]^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:01 AM 2016-07-18 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasRecordSpec^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasRecordSpec">bci:hasRecordSpec</a>
    /// </summary>
    let hasRecordSpec = _prefixId.prefix "hasRecordSpec"
    let hasRecordSpec'_period_'POWDER = _prefixId.prefix "hasRecordSpec.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasRole^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;strong&gt;Context.&lt;/strong&gt;&lt;strong&gt;Object&lt;/strong&gt; with its &lt;a&gt;Context.Role&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.Role.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has role^^rdfs:Literal</para>
    ///   <para>dcterms:source : [Unity]^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 10:23 PM 2016-05-16 $^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasRole">bci:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    let hasRole'_period_'POWDER = _prefixId.prefix "hasRole.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;p&gt;[&lt;b&gt;XDF&lt;/b&gt;] It is defined in the &lt;em&gt;StreamFooter&lt;/em&gt; chunk as &amp;lt;&lt;em&gt;sample_count&lt;/em&gt;&amp;gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasSampleCount^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Counts the &lt;span style="text-decoration: underline;"&gt;number of samples&lt;/span&gt; of the &lt;a&gt;Record&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has sample count^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:55 AM 2016-07-19 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasSampleCount">bci:hasSampleCount</a>
    /// </summary>
    let hasSampleCount = _prefixId.prefix "hasSampleCount"
    let hasSampleCount'_period_'POWDER = _prefixId.prefix "hasSampleCount.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;p&gt;Related concept for a &lt;a&gt;Device&lt;/a&gt;: &lt;a&gt;SamplingRate&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literalskos:editorialNote : &lt;p&gt;[&lt;b&gt;ESS 2.0&lt;/b&gt;] Sampling rate of the &lt;span style="text-decoration: underline;"&gt;modality&lt;/span&gt; (in &lt;em&gt;Hz&lt;/em&gt;). In some file formats, e.g. &lt;strong&gt;XDF&lt;/strong&gt;, each &lt;span style="text-decoration: underline;"&gt;modality&lt;/span&gt; may be recorded at a different sampling rate.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : (a &lt;em&gt;record&lt;/em&gt;) has sampling rate^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Sampling rate of the recording (&lt;a&gt;Record&lt;/a&gt;). Its measurement unit is &lt;em&gt;Hz&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:49 AM 2016-08-22 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasSamplingRate^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [XDF]^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasSamplingRate">bci:hasSamplingRate</a>
    /// </summary>
    let hasSamplingRate = _prefixId.prefix "hasSamplingRate"
    let hasSamplingRate'_period_'POWDER = _prefixId.prefix "hasSamplingRate.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : has scene^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or &lt;/em&gt;&lt;a&gt;Context.Scene&lt;/a&gt;) with its &lt;a&gt;Context.Scene&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Context.Scene.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or &lt;/em&gt;&lt;a&gt;Context.Scene&lt;/a&gt;) with its &lt;a&gt;Context.Scene&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasScene^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:06 2016-04-14 $^^rdfs:Literal</para>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasScene">bci:hasScene</a>
    /// </summary>
    let hasScene = _prefixId.prefix "hasScene"
    let hasScene'_period_'POWDER = _prefixId.prefix "hasScene.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 10:08 PM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Interaction&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Subject&lt;/a&gt;) with a set of &lt;a&gt;Session&lt;/a&gt;s that are associated with it.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Interaction&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Subject&lt;/a&gt;) with its related set of &lt;a&gt;Session&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Session.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has session^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : Context,Session,Subject^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasSession^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasSession">bci:hasSession</a>
    /// </summary>
    let hasSession = _prefixId.prefix "hasSession"
    let hasSession'_period_'POWDER = _prefixId.prefix "hasSession.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasSituation^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Collection&lt;/a&gt; with a &lt;a&gt;Session&lt;/a&gt; set and/or an &lt;a&gt;Interaction&lt;/a&gt; set that are associated with it.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Session^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has situation^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:43 AM 2016-06-28 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Collection&lt;/a&gt; with its related &lt;a&gt;Session&lt;/a&gt; set and/or &lt;a&gt;Interaction&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Session.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasSituation">bci:hasSituation</a>
    /// </summary>
    let hasSituation = _prefixId.prefix "hasSituation"
    let hasSituation'_period_'POWDER = _prefixId.prefix "hasSituation.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;The &lt;em&gt;channel number&lt;/em&gt; in the recording where the &lt;span style="text-decoration: underline;"&gt;modality block&lt;/span&gt; starts.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasStartChannel^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:source : [ESS], [XDF]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has start channel^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:59 AM 2016-07-19 $^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Descriptor.png^^rdfs:Literaldctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasStartChannel">bci:hasStartChannel</a>
    /// </summary>
    let hasStartChannel = _prefixId.prefix "hasStartChannel"
    let hasStartChannel'_period_'POWDER = _prefixId.prefix "hasStartChannel.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : &lt;p&gt;For simplicity, this ontology does not define explicitly a &lt;em&gt;TimeInterval&lt;/em&gt; concept.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:44 AM 2016-06-30 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : TimeInterval.png^^rdfs:Literal</para>
    ///   <para>dcterms:source : [OWL-Time]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has start (initial) date time^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;&lt;strong&gt;XSD dateTime&lt;/strong&gt;&lt;/span&gt; associated to an entity, that indicates the &lt;strong&gt;starting-point&lt;/strong&gt; of a &lt;em&gt;time interval&lt;/em&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;BCI applications should, at least, measure these time values in &lt;span style="text-decoration: underline;"&gt;seconds&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>ov:part : Context,Session,SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasStartTime^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasStartTime">bci:hasStartTime</a>
    /// </summary>
    let hasStartTime = _prefixId.prefix "hasStartTime"
    let hasStartTime'_period_'POWDER = _prefixId.prefix "hasStartTime.POWDER"
    /// <summary>
    ///   <para>skos:example : &lt;p&gt;An alphabet-based symbolic scheme, could be: "&lt;em&gt;A B C D E&lt;/em&gt;...". Thus, a specific &lt;span style="text-decoration: underline;"&gt;State&lt;/span&gt;, would be: {"&lt;em&gt;B&lt;/em&gt;"}&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has state^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasState^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 09:23 PM 2016-05-22 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Captures the &lt;span style="text-decoration: underline;"&gt;alphabet symbol&lt;/span&gt; of the &lt;a&gt;ResponseTag&lt;/a&gt;, representating its "&lt;em&gt;State&lt;/em&gt;".
    ///
    /// &lt;br /&gt;BCI domain applications can define their own specific symbolic scheme to represent its relevant &lt;span style="text-decoration: underline;"&gt;States&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasState">bci:hasState</a>
    /// </summary>
    let hasState = _prefixId.prefix "hasState"
    let hasState'_period_'POWDER = _prefixId.prefix "hasState.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has stimulus event^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;StimulusTag&lt;/a&gt; with its correspondent &lt;a&gt;StimulusEvent&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasStimulusEvent^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:51 PM 2016-05-22 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;StimulusTag&lt;/a&gt; &lt;em&gt;is associated with (has)&lt;/em&gt; a &lt;a&gt;StimulusEvent&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasStimulusEvent">bci:hasStimulusEvent</a>
    /// </summary>
    let hasStimulusEvent = _prefixId.prefix "hasStimulusEvent"
    let hasStimulusEvent'_period_'POWDER = _prefixId.prefix "hasStimulusEvent.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Subject.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an &lt;a&gt;Interaction&lt;/a&gt; with its set of &lt;a&gt;Subject&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has subject (participant)^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasSubject^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects an &lt;a&gt;Interaction&lt;/a&gt; with its set of &lt;a&gt;Subject&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Session,Subject^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:55 AM 2016-06-23 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasSubject">bci:hasSubject</a>
    /// </summary>
    let hasSubject = _prefixId.prefix "hasSubject"
    let hasSubject'_period_'POWDER = _prefixId.prefix "hasSubject.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Session.png^^rdfs:Literal</para>
    ///   <para>ov:part : Session^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:43 AM 2016-06-30 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Session&lt;/a&gt; with a set of &lt;a&gt;SubjectState&lt;/a&gt;s which describe the overall state of the &lt;a&gt;Subject&lt;/a&gt; during the &lt;a&gt;Session&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;A &lt;a&gt;hasDescriptor&lt;/a&gt; &lt;em&gt;sub property&lt;/em&gt; for connecting a &lt;a&gt;Session&lt;/a&gt; with a set of  &lt;a&gt;SubjectState&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has subject state^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasSubjectState^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasSubjectState">bci:hasSubjectState</a>
    /// </summary>
    let hasSubjectState = _prefixId.prefix "hasSubjectState"
    let hasSubjectState'_period_'POWDER = _prefixId.prefix "hasSubjectState.POWDER"
    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:source : [OWL-Time]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literaldctype:StillImage : PlayoutInstant.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasTimeStamp^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag,Context,SSN-Data,SSN-MeasurementCapability^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;&lt;span style="text-decoration: underline;"&gt;&lt;strong&gt;XSD dateTimeStamp&lt;/strong&gt;&lt;/span&gt; of a specific &lt;em&gt;time instant&lt;/em&gt;.&lt;/p&gt;
    ///
    /// &lt;p&gt;BCI applications are recommended to measure the time with &lt;em&gt;high precision&lt;/em&gt;, in order to keep a &lt;em&gt;proper granularity&lt;/em&gt; for this measurement unit.
    ///
    /// &lt;br /&gt;BCI applications should, at least, measure the time instants in &lt;span style="text-decoration: underline;"&gt;milliseconds&lt;/span&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:34 AM 2016-06-29 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has time stamp^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasTimeStamp">bci:hasTimeStamp</a>
    /// </summary>
    let hasTimeStamp = _prefixId.prefix "hasTimeStamp"
    let hasTimeStamp'_period_'POWDER = _prefixId.prefix "hasTimeStamp.POWDER"
    /// <summary>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>ov:part : Context,Descriptor,Session^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has title^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasTitle^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;The given title or logical name of an entity.
    /// &lt;br /&gt;It is used to associate a human-readable label to entities.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:24 AM 2016-09-29 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasTitle">bci:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    let hasTitle'_period_'POWDER = _prefixId.prefix "hasTitle.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Indicates the &lt;a&gt;AccessMethod&lt;/a&gt;'s type: the nature of how the &lt;a&gt;RecordedData&lt;/a&gt; can be accessed. This ontology only defines the two following &lt;em&gt;Access Method Type&lt;/em&gt;:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;"&lt;span style="text-decoration: underline;"&gt;&lt;b&gt;File&lt;/b&gt;&lt;/span&gt;": archived access method.&lt;/li&gt;
    /// &lt;li&gt;"&lt;span style="text-decoration: underline;"&gt;&lt;b&gt;Stream&lt;/b&gt;&lt;/span&gt;": real-time access method.&lt;/li&gt;
    /// &lt;/ul&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : hasType^^rdfs:Literal</para>
    ///   <para>dcterms:conformsTo : %DATATYPE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has access method type (nature)^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:55 AM 2016-06-01 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasType">bci:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    let hasType'_period_'POWDER = _prefixId.prefix "hasType.POWDER"
    /// <summary>
    ///   <para>dcterms:title : hasValue^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;A SPARQL triple pattern matching to find the &lt;a&gt;DataBlock&lt;/a&gt;s of a &lt;a&gt;Record&lt;/a&gt; via this object property would be:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &lt;p&gt;?&lt;em&gt;Record&lt;/em&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp;&lt;strong&gt;bci:observationResult&lt;/strong&gt; ?&lt;em&gt;RecordedData&lt;/em&gt;
    /// &lt;br /&gt;?&lt;em&gt;RecordedData&lt;/em&gt; &lt;strong&gt;bci:hasValue&lt;/strong&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; ?&lt;em&gt;DataBlock&lt;/em&gt;&lt;/p&gt;
    /// &lt;/blockquote&gt;
    ///
    /// &lt;p&gt;(
    /// &lt;br /&gt;Based on the following relationships:&lt;/p&gt;
    /// &lt;blockquote class="remark"&gt;
    /// &amp;nbsp; &amp;nbsp; &amp;nbsp;[&lt;b&gt;Record&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;observationResult&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;RecordedData&lt;/b&gt;]
    /// &lt;br /&gt;[&lt;b&gt;RecordedData&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;hasValue&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;DataBlock&lt;/b&gt;]
    /// &lt;/blockquote&gt;
    /// )^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:11 PM 2016-06-12 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : has value (data blocks)^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;RecordedData&lt;/a&gt; individual with its correspondent &lt;a&gt;DataBlock&lt;/a&gt;s&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;RecordedData&lt;/a&gt; with its correspondent &lt;a&gt;DataBlock&lt;/a&gt; set.&lt;/p&gt;
    ///
    /// &lt;p&gt;This object property is a subproperty of &lt;em&gt;ssn:hasValue&lt;/em&gt;:&lt;/p&gt;
    /// &lt;blockquote class="remark"&gt;
    /// [&lt;em&gt;ssn:SensorOutput&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:hasValue&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:ObservationValue&lt;/em&gt;]
    /// &lt;br /&gt;  [&lt;b&gt;RecordedData&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;hasValue&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;DataBlock&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#hasValue">bci:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    let hasValue'_period_'POWDER = _prefixId.prefix "hasValue.POWDER"
    /// <summary>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : StimulusEvent.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : includesEvent^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Record&lt;/a&gt; individual with its correspondent &lt;a&gt;StimulusEvent&lt;/a&gt; set.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : includes stimulus event^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:44 AM 2016-07-25 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Record&lt;/a&gt; with its correspondent &lt;a&gt;StimulusEvent&lt;/a&gt; set. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Record&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;includes events&lt;/span&gt; &lt;a&gt;StimulusEvent&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;DUL:includesEvent&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;[&lt;em&gt;ssn:Observation&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;DUL:includesEvent&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Stimulus&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;[&lt;b&gt;Record&lt;/b&gt;]
    /// &amp;nbsp;&amp;nbsp;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;nbsp;&amp;nbsp;(&lt;b&gt;includesEvent&lt;/b&gt;)
    /// &amp;nbsp;&amp;nbsp;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;StimulusEvent&lt;/b&gt;]&lt;/blockquote&gt;&lt;br /&gt;
    ///
    /// &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] A &lt;em&gt;ssn:Observation&lt;/em&gt; has a &lt;em&gt;DUL:includesEvent&lt;/em&gt; property who may be a &lt;em&gt;ssn:Stimulus&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#includesEvent">bci:includesEvent</a>
    /// </summary>
    let includesEvent = _prefixId.prefix "includesEvent"
    let includesEvent'_period_'POWDER = _prefixId.prefix "includesEvent.POWDER"
    /// <summary>
    ///   <para>dcterms:title : isChannelDataOf^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Channel&lt;/a&gt; with its associated &lt;a&gt;DeviceChannelingSpec&lt;/a&gt; definition.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Channel&lt;/a&gt; with its associated &lt;a&gt;DeviceChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:28 AM 2016-08-14 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF]^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is channel (logical component) data of^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-MeasurementCapability^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isChannelDataOf">bci:isChannelDataOf</a>
    /// </summary>
    let isChannelDataOf = _prefixId.prefix "isChannelDataOf"
    let isChannelDataOf'_period_'POWDER = _prefixId.prefix "isChannelDataOf.POWDER"
    /// <summary>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:source : [XDF]^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:45 AM 2016-08-14 $^^rdfs:Literal</para>
    ///   <para>owl:deprecated : true^^xsd:booleanowl:deprecated : &amp;laquo;Concerning EEG, this ontology only defines its related classes. It does not extend or define any specific properties for EEG.&amp;raquo;
    /// &lt;br /&gt;$ 04:27 AM 2016-07-29 $^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an &lt;a&gt;EegChannel&lt;/a&gt; with its associated &lt;a&gt;EegDeviceChannelingSpec&lt;/a&gt; definition.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : isEegChannelDataOf^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is EEG channel data of^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects an &lt;a&gt;EegChannel&lt;/a&gt; with its associated &lt;a&gt;EegDeviceChannelingSpec&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isEegChannelDataOf">bci:isEegChannelDataOf</a>
    /// </summary>
    let isEegChannelDataOf = _prefixId.prefix "isEegChannelDataOf"

    let isEegChannelDataOf'_period_'POWDER = _prefixId.prefix "isEegChannelDataOf.POWDER"

    /// <summary>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Modality&lt;/a&gt; with its correspondent &lt;a&gt;Aspect&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Modality&lt;/a&gt; with its correspondent &lt;a&gt;Aspect&lt;/a&gt;. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Modality&lt;/a&gt;  &lt;span style="text-decoration: underline;"&gt;is modality of&lt;/span&gt; &lt;a&gt;Aspect&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:isPropertyOf&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// [&lt;em&gt;ssn:Property&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:isPropertyOf&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:FeatureOfInterest&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;[&lt;b&gt;Modality&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;isModalityOf&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Aspect&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is modality of^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:28 AM 2016-07-26 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : isModalityOf^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isModalityOf">bci:isModalityOf</a>
    /// </summary>
    let isModalityOf = _prefixId.prefix "isModalityOf"
    let isModalityOf'_period_'POWDER = _prefixId.prefix "isModalityOf.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : is model of^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Model.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;Model&lt;/a&gt; &lt;em&gt;has associated&lt;/em&gt; a set of &lt;a&gt;ResponseTag&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : isModelOf^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Model&lt;/a&gt; with its correspondent set of &lt;a&gt;ResponseTag&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:55 AM 2016-06-23 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isModelOf">bci:isModelOf</a>
    /// </summary>
    let isModelOf = _prefixId.prefix "isModelOf"
    let isModelOf'_period_'POWDER = _prefixId.prefix "isModelOf.POWDER"
    /// <summary>
    ///   <para>dcterms:title : isObservationResultOf^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:30 AM 2016-07-22 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;RecordedData&lt;/a&gt; set with its correspondent &lt;a&gt;Record&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literaldctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;RecordedData&lt;/a&gt; set with its correspondent &lt;a&gt;Record&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is observation result of (a BCI Record)^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isObservationResultOf">bci:isObservationResultOf</a>
    /// </summary>
    let isObservationResultOf = _prefixId.prefix "isObservationResultOf"

    let isObservationResultOf'_period_'POWDER = _prefixId.prefix "isObservationResultOf.POWDER"

    /// <summary>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;PlayoutInstant&lt;/a&gt; log entry with its correspondent individual (&lt;a&gt;Playout&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt; &lt;em&gt;or&lt;/em&gt;&lt;a&gt;Action&lt;/a&gt;) that issued its creation.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;PlayoutInstant&lt;/a&gt; with its correspondent (&lt;a&gt;Playout&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Context.ObjectComponent.Event&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Action&lt;/a&gt;) individual.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:41 AM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : isPlayoutInstantOf^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is the playout instant of^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isPlayoutInstantOf">bci:isPlayoutInstantOf</a>
    /// </summary>
    let isPlayoutInstantOf = _prefixId.prefix "isPlayoutInstantOf"

    let isPlayoutInstantOf'_period_'POWDER = _prefixId.prefix "isPlayoutInstantOf.POWDER"

    /// <summary>
    ///   <para>ov:part : Context^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a set of &lt;a&gt;Playout&lt;/a&gt;s with its corresponding (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Session&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:17 AM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is playout record of^^rdfs:Literal</para>
    ///   <para>dcterms:title : isPlayoutOf^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Playout.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an individual with exactly one (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Session&lt;/a&gt;)&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isPlayoutOf">bci:isPlayoutOf</a>
    /// </summary>
    let isPlayoutOf = _prefixId.prefix "isPlayoutOf"
    let isPlayoutOf'_period_'POWDER = _prefixId.prefix "isPlayoutOf.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 05:11 AM 2016-07-22 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : isProducedByDevice^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is produced by device^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;RecordedData&lt;/a&gt; with its correspondent &lt;a&gt;Device&lt;/a&gt; that produced it.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;RecordedData&lt;/a&gt; with its correspondent &lt;a&gt;Device&lt;/a&gt; that produced it. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;RecordedData&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;is produced by&lt;/span&gt; a &lt;a&gt;Device&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:isProducedBy&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;[&lt;em&gt;ssn:SensorOutput&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:isProducedBy&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Sensor&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp; [&lt;b&gt;RecordedData&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;isProducedByDevice&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Device&lt;/b&gt;]&lt;/blockquote&gt;&lt;br /&gt;
    /// ^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isProducedByDevice">bci:isProducedByDevice</a>
    /// </summary>
    let isProducedByDevice = _prefixId.prefix "isProducedByDevice"

    let isProducedByDevice'_period_'POWDER = _prefixId.prefix "isProducedByDevice.POWDER"

    /// <summary>
    ///   <para>dctype:StillImage : StimulusEvent.png^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : &lt;p&gt;The following descriptions capture the definition of this relation (&lt;a title="Semantic Sensor Network XG Final Report: (4) Review of Sensor and Observation ontologies &amp;raquo; (4.2.13) Stimuli-Centered" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Stimuli-Centered" target="_blank"&gt;4.2.13 Stimuli-Centered&lt;/a&gt;, &lt;a title="Semantic Sensor Network XG Final Report: (5) The Semantic Sensor Network Ontology &amp;raquo; (5.3.1.2.1) Stimuli" href="https://www.w3.org/2005/Incubator/ssn/XGR-ssn-20110628/#Stimuli" target="_blank"&gt;5.3.1.2.1 Stimuli&lt;/a&gt;) adjusted to this ontology:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;The role of &lt;a&gt;StimulusEvent&lt;/a&gt;s as a &lt;span style="text-decoration: underline;"&gt;proxy&lt;/span&gt; between the &lt;a&gt;Device&lt;/a&gt; and the &lt;em&gt;object of sensing&lt;/em&gt; (&lt;a&gt;Context.Object&lt;/a&gt;).&lt;/li&gt;
    /// &lt;li&gt;A &lt;a&gt;StimulusEvent&lt;/a&gt; may only be usable as &lt;span style="text-decoration: underline;"&gt;proxy&lt;/span&gt; for a specific &lt;em&gt;region&lt;/em&gt; of an observed &lt;a&gt;Modality&lt;/a&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// &lt;/blockquote&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is proxy for^^rdfs:Literal</para>
    ///   <para>dcterms:title : isProxyFor^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;StimulusEvent&lt;/a&gt; with its associated &lt;a&gt;Modality&lt;/a&gt;-ies. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;StimulusEvent&lt;/a&gt;  &lt;span style="text-decoration: underline;"&gt;is proxy for&lt;/span&gt; a &lt;a&gt;Modality&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:isProxyFor&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &amp;nbsp;&amp;nbsp;[&lt;em&gt;ssn:Stimulus&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:isProxyFor&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Property&lt;/em&gt;]
    /// &lt;br /&gt;[&lt;b&gt;StimulusEvent&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;isProxyFor&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Modality&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;StimulusEvent&lt;/a&gt; with its associated &lt;a&gt;Modality&lt;/a&gt;(ies).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 03:35 AM 2016-07-28 $^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isProxyFor">bci:isProxyFor</a>
    /// </summary>
    let isProxyFor = _prefixId.prefix "isProxyFor"
    let isProxyFor'_period_'POWDER = _prefixId.prefix "isProxyFor.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : isRecordOf^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:16 AM 2016-06-24 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Record&lt;/a&gt; with its related (&lt;a&gt;Subject&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Session&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Record&lt;/a&gt; with its associated (&lt;a&gt;Subject&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Session&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is BCI record of^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isRecordOf">bci:isRecordOf</a>
    /// </summary>
    let isRecordOf = _prefixId.prefix "isRecordOf"
    let isRecordOf'_period_'POWDER = _prefixId.prefix "isRecordOf.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;DataSegment&lt;/a&gt; with a set of &lt;a&gt;Marker&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is referenced by^^rdfs:Literal</para>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : DataSegment.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;DataSegment&lt;/a&gt; individual with a set of &lt;a&gt;Marker&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:16 AM 2016-06-13 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : isReferencedBy^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isReferencedBy">bci:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = _prefixId.prefix "isReferencedBy"
    let isReferencedBy'_period_'POWDER = _prefixId.prefix "isReferencedBy.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 10:13 PM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is session of^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Session&lt;/a&gt; with its related (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Interaction&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Subject&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Session^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Session&lt;/a&gt; with its associated (&lt;a&gt;Context&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Interaction&lt;/a&gt; &lt;em&gt;or&lt;/em&gt; &lt;a&gt;Subject&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Session.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : isSessionOf^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isSessionOf">bci:isSessionOf</a>
    /// </summary>
    let isSessionOf = _prefixId.prefix "isSessionOf"
    let isSessionOf'_period_'POWDER = _prefixId.prefix "isSessionOf.POWDER"
    /// <summary>
    ///   <para>dcterms:title : isSituationOf^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 04:46 AM 2016-06-28 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is situation of^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a (&lt;a&gt;Session&lt;/a&gt; set and/or an &lt;a&gt;Interaction&lt;/a&gt; set) with its related &lt;a&gt;Collection&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : Session,Subject^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a (&lt;a&gt;Session&lt;/a&gt; set and/or an &lt;a&gt;Interaction&lt;/a&gt; set) that are associated with a &lt;a&gt;Collection&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isSituationOf">bci:isSituationOf</a>
    /// </summary>
    let isSituationOf = _prefixId.prefix "isSituationOf"
    let isSituationOf'_period_'POWDER = _prefixId.prefix "isSituationOf.POWDER"
    /// <summary>
    ///   <para>dcterms:title : isStimulusEventOf^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:55 AM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;StimulusEvent&lt;/a&gt; with its set of &lt;a&gt;StimulusTag&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;A &lt;a&gt;StimulusEvent&lt;/a&gt; &lt;em&gt;generates&lt;/em&gt; a set of &lt;a&gt;StimulusTag&lt;/a&gt;s.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is stimulus event of (generates)^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Marker.png^^rdfs:Literal</para>
    ///   <para>ov:part : Context,SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isStimulusEventOf">bci:isStimulusEventOf</a>
    /// </summary>
    let isStimulusEventOf = _prefixId.prefix "isStimulusEventOf"
    let isStimulusEventOf'_period_'POWDER = _prefixId.prefix "isStimulusEventOf.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Subject&lt;/a&gt; with a set of &lt;a&gt;Interaction&lt;/a&gt;s where he/she &lt;em&gt;participates in&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Subject.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Subject&lt;/a&gt; with a set of &lt;a&gt;Interaction&lt;/a&gt;s where he/she &lt;em&gt;participates in&lt;/em&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is subject of (participates in)^^rdfs:Literal</para>
    ///   <para>ov:part : Subject^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 01:55 AM 2016-06-23 $^^rdfs:Literal</para>
    ///   <para>dcterms:title : isSubjectOf^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isSubjectOf">bci:isSubjectOf</a>
    /// </summary>
    let isSubjectOf = _prefixId.prefix "isSubjectOf"
    let isSubjectOf'_period_'POWDER = _prefixId.prefix "isSubjectOf.POWDER"
    /// <summary>
    ///   <para>ov:part : SSN-Data^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : is value of (recorded data)^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 11:19 PM 2016-06-12 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;DataBlock&lt;/a&gt; set with its correspondent &lt;a&gt;RecordedData&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:title : isValueOf^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;DataBlock&lt;/a&gt; individual with its correspondent &lt;a&gt;RecordedData&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#isValueOf">bci:isValueOf</a>
    /// </summary>
    let isValueOf = _prefixId.prefix "isValueOf"
    let isValueOf'_period_'POWDER = _prefixId.prefix "isValueOf.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 02:47 AM 2016-07-22 $^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects an &lt;a&gt;EegDevice&lt;/a&gt; with its correspondent &lt;a&gt;EegRecord&lt;/a&gt;s. This can be read, as follow: "&lt;em&gt;An &lt;a&gt;EegDevice&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;made&lt;/span&gt; &lt;a&gt;EegRecord&lt;/a&gt;s&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;a&gt;madeRecord&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &amp;nbsp; &amp;nbsp;[&lt;b&gt;Device&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;madeRecord&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Record&lt;/b&gt;]
    /// &lt;br /&gt;[&lt;b&gt;EegDevice&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;madeEegRecord&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;EegRecord&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <para>owl:deprecated : &amp;laquo;Concerning EEG, this ontology only defines its related classes. It does not extend or define any specific properties for EEG.&amp;raquo;
    /// &lt;br /&gt;$ 04:27 AM 2016-07-29 $^^rdfs:Literalowl:deprecated : true^^xsd:boolean</para>
    ///   <para>dcterms:title : madeEegRecord^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : made EEG record^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an &lt;a&gt;EegDevice&lt;/a&gt; individual with its correspondent &lt;a&gt;EegRecord&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : EegRecord.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#madeEegRecord">bci:madeEegRecord</a>
    /// </summary>
    let madeEegRecord = _prefixId.prefix "madeEegRecord"
    let madeEegRecord'_period_'POWDER = _prefixId.prefix "madeEegRecord.POWDER"
    /// <summary>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:47 AM 2016-07-22 $^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Device&lt;/a&gt; individual with its correspondent &lt;a&gt;Record&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device^^rdfs:Literal</para>
    ///   <para>dcterms:title : madeRecord^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : made BCI record^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Device&lt;/a&gt; with its correspondent &lt;a&gt;Record&lt;/a&gt;s. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Device&lt;/a&gt;  &lt;span style="text-decoration: underline;"&gt;made&lt;/span&gt; &lt;a&gt;Record&lt;/a&gt;s&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:madeObservation&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// [&lt;em&gt;ssn:Sensor&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:madeObservation&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Observation&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;[&lt;b&gt;Device&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;madeRecord&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Record&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#madeRecord">bci:madeRecord</a>
    /// </summary>
    let madeRecord = _prefixId.prefix "madeRecord"
    let madeRecord'_period_'POWDER = _prefixId.prefix "madeRecord.POWDER"
    /// <summary>
    ///   <para>dcterms:modified : $ 03:30 AM 2016-07-22 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : observation result (of a BCI record)^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Record&lt;/a&gt; individual with its correspondent &lt;a&gt;RecordedData&lt;/a&gt; set&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literaldctype:StillImage : RecordedData.png^^rdfs:Literal</para>
    ///   <para>dcterms:title : observationResult^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Record&lt;/a&gt; with its correspondent &lt;a&gt;RecordedData&lt;/a&gt; set.
    /// &lt;br /&gt;This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Record&lt;/a&gt; has as its &lt;span style="text-decoration: underline;"&gt;observation result&lt;/span&gt; a &lt;a&gt;RecordedData&lt;/a&gt; set&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:observationResult&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// [&lt;em&gt;ssn:Observation&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:observationResult&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:SensorOutput&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp; [&lt;b&gt;Record&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;observationResult&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;RecordedData&lt;/b&gt;]&lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#observationResult">bci:observationResult</a>
    /// </summary>
    let observationResult = _prefixId.prefix "observationResult"
    let observationResult'_period_'POWDER = _prefixId.prefix "observationResult.POWDER"
    /// <summary>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>dcterms:title : observedByDevice^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Record&lt;/a&gt; with its correspondent &lt;a&gt;Device&lt;/a&gt;. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Record&lt;/a&gt; is &lt;span style="text-decoration: underline;"&gt;observed by&lt;/span&gt; a &lt;a&gt;Device&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:observedBy&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// [&lt;em&gt;ssn:Observation&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:observedBy&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Sensor&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;[&lt;b&gt;Record&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;observedByDevice&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Device&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : observed by device^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Record&lt;/a&gt; individual with its correspondent &lt;a&gt;Device&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:47 AM 2016-07-22 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#observedByDevice">bci:observedByDevice</a>
    /// </summary>
    let observedByDevice = _prefixId.prefix "observedByDevice"
    let observedByDevice'_period_'POWDER = _prefixId.prefix "observedByDevice.POWDER"
    /// <summary>
    ///   <para>skos:prefLabel : observed by EEG device^^rdfs:Literal</para>
    ///   <para>dcterms:title : observedByEegDevice^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>owl:deprecated : true^^xsd:booleanowl:deprecated : &amp;laquo;Concerning EEG, this ontology only defines its related classes. It does not extend or define any specific properties for EEG.&amp;raquo;
    /// &lt;br /&gt;$ 04:27 AM 2016-07-29 $^^rdfs:Literal</para>
    ///   <para>ov:part : EEG^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : EegRecord.png^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting an &lt;a&gt;EegRecord&lt;/a&gt; individual with its correspondent &lt;a&gt;EegDevice&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 02:47 AM 2016-07-22 $^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects an &lt;a&gt;EegRecord&lt;/a&gt; with its correspondent &lt;a&gt;EegDevice&lt;/a&gt;. This can be read, as follow: "&lt;em&gt;An &lt;a&gt;EegRecord&lt;/a&gt; is &lt;span style="text-decoration: underline;"&gt;observed by&lt;/span&gt; an &lt;a&gt;EegDevice&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;a&gt;observedByDevice&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &amp;nbsp; &amp;nbsp;[&lt;b&gt;Record&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;observedByDevice&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Device&lt;/b&gt;]
    /// &lt;br /&gt;[&lt;b&gt;EegRecord&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;observedByEegDevice&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;EegDevice&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#observedByEegDevice">bci:observedByEegDevice</a>
    /// </summary>
    let observedByEegDevice = _prefixId.prefix "observedByEegDevice"

    let observedByEegDevice'_period_'POWDER = _prefixId.prefix "observedByEegDevice.POWDER"

    /// <summary>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 05:10 AM 2016-07-21 $^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Skeleton^^rdfs:Literal</para>
    ///   <para>dcterms:title : observedModality^^rdfs:Literal</para>
    ///   <para>skos:historyNote : &lt;p&gt;[&lt;b&gt;ESS 1.0&lt;/b&gt;]: A &lt;em&gt;record&lt;/em&gt; (&lt;strong&gt;bci:Record&lt;/strong&gt;) has a specific (single) defined &lt;em&gt;modality&lt;/em&gt; (&lt;strong&gt;bci:Modality&lt;/strong&gt;).&lt;/p&gt;
    ///
    /// &lt;p&gt;[&lt;b&gt;ESS 2.0&lt;/b&gt;]: A &lt;em&gt;record&lt;/em&gt; (&lt;strong&gt;bci:Session&lt;/strong&gt;) has a specific defined &lt;em&gt;RecordedParameterSet&lt;/em&gt;, which groups various (multiple) &lt;em&gt;RecordedModality&lt;/em&gt; (&lt;a&gt;Modality&lt;/a&gt;-ies).
    /// &lt;br /&gt;Therefore, a &lt;em&gt;record&lt;/em&gt; (&lt;strong&gt;bci:Session&lt;/strong&gt;) can be associated with multiple &lt;em&gt;RecordedModality&lt;/em&gt; (&lt;strong&gt;bci:Modality&lt;/strong&gt;) definitions.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Record&lt;/a&gt; individual with its correspondent &lt;a&gt;Modality&lt;/a&gt;&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : observed modality^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN], [ESS]^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : Record.png^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Record&lt;/a&gt; with its correspondent &lt;a&gt;Modality&lt;/a&gt;. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Record&lt;/a&gt; &lt;span style="text-decoration: underline;"&gt;observes&lt;/span&gt; a &lt;a&gt;Modality&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;em&gt;ssn:observedProperty&lt;/em&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// [&lt;em&gt;ssn:Observation&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:observedProperty&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:Property&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp;[&lt;b&gt;Record&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash; (&lt;b&gt;observedModality&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Modality&lt;/b&gt;]
    /// &lt;/blockquote&gt;&lt;br /&gt;^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#observedModality">bci:observedModality</a>
    /// </summary>
    let observedModality = _prefixId.prefix "observedModality"
    let observedModality'_period_'POWDER = _prefixId.prefix "observedModality.POWDER"
    /// <summary>
    ///   <para>skos:definition : &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] Relation between a &lt;a&gt;Device&lt;/a&gt; (&lt;a&gt;ssn:Sensor&lt;/a&gt;) and a &lt;a&gt;Modality&lt;/a&gt; (&lt;a&gt;ssn:Property&lt;/a&gt;) that the sensor supports (&lt;em&gt;can observe&lt;/em&gt;).
    /// &lt;br /&gt;The &lt;span style="text-decoration: underline;"&gt;object property composition&lt;/span&gt; (&lt;em&gt;owl:propertyChainAxiom&lt;/em&gt;) ensures that if a &lt;a&gt;Record&lt;/a&gt; (&lt;a&gt;ssn:Observation&lt;/a&gt;) is made of a particular &lt;a&gt;Modality&lt;/a&gt; (&lt;a&gt;ssn:Property&lt;/a&gt;),
    /// &lt;br /&gt;then one can infer that the &lt;a&gt;Device&lt;/a&gt; (&lt;a&gt;ssn:Sensor&lt;/a&gt;) supports (&lt;em&gt;observes&lt;/em&gt;) that &lt;a&gt;Modality&lt;/a&gt; (&lt;em&gt;quality&lt;/em&gt;).&lt;/p&gt;
    ///
    /// &lt;p&gt;This &lt;span style="text-decoration: underline;"&gt;object property composition&lt;/span&gt; defines a "theoretical attribute" that describes its &lt;span style="text-decoration: underline;"&gt;supported functionality&lt;/span&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;
    /// &lt;ol style="list-style-type: lower-roman;"&gt;
    /// &lt;li&gt;&lt;b&gt;Device&lt;/b&gt;.&lt;em&gt;madeRecord &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp;&amp;nbsp;&lt;/em&gt; &lt;strong&gt;&amp;compfn;&lt;/strong&gt; &lt;b&gt;Record&lt;/b&gt;.&lt;em&gt;observedModality&lt;/em&gt;&amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp; &amp;nbsp;&amp;nbsp;&amp;nbsp; &amp;Longrightarrow; &lt;b&gt;Device&lt;/b&gt;.&lt;em&gt;observes&lt;/em&gt; &amp;Assign; &lt;b&gt;Modality&lt;/b&gt;.&lt;/li&gt;
    ///
    /// &lt;li&gt;&lt;b&gt;Device&lt;/b&gt;.&lt;em&gt;hasDeviceChannelingSpec&lt;/em&gt; &lt;strong&gt;&amp;compfn;&lt;/strong&gt; &lt;b&gt;DeviceChannelingSpec&lt;/b&gt;.&lt;em&gt;hasChannelData&lt;/em&gt; &lt;strong&gt;&amp;compfn;&lt;/strong&gt; &lt;b&gt;Channel&lt;/b&gt;.&lt;em&gt;forModality&lt;/em&gt; &amp;Longrightarrow; &lt;b&gt;Device&lt;/b&gt;.&lt;em&gt;observes&lt;/em&gt; &amp;Assign; &lt;b&gt;Modality&lt;/b&gt;.&lt;/li&gt;
    /// &lt;/ol&gt;
    /// &lt;/blockquote&gt;^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-Device^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 07:02 AM 2016-08-10 $^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : observes^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : MeasurementCapability.png^^rdfs:Literaldctype:StillImage : Record.png^^rdfs:Literaldctype:StillImage : Device.png^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN], [Compton2009]^^rdfs:Literal</para>
    ///   <para>dcterms:title : observes^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Device&lt;/a&gt; individual with its correspondent supported &lt;a&gt;Modality&lt;/a&gt; individual.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#observes">bci:observes</a>
    /// </summary>
    let observes = _prefixId.prefix "observes"
    let observes'_period_'POWDER = _prefixId.prefix "observes.POWDER"
    /// <summary>
    ///   <para>dctype:StillImage : Aspect-and-Modality.png^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>dcterms:title : ofAspect^^rdfs:Literal</para>
    ///   <para>skos:editorialNote : %GENERAL_COMMENT%@EEG-CONCEPTS^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Channel&lt;/a&gt; to the &lt;a&gt;Aspect&lt;/a&gt; is described for.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Channel&lt;/a&gt; to the &lt;a&gt;Aspect&lt;/a&gt; is described for. This can be read, as follow: "&lt;em&gt;A &lt;a&gt;Channel&lt;/a&gt; is use to describe a property &lt;span style="text-decoration: underline;"&gt;of&lt;/span&gt; an &lt;a&gt;Aspect&lt;/a&gt;&lt;/em&gt;".
    /// &lt;br /&gt;This object property is a subproperty of &lt;a&gt;ssn:ofFeature&lt;/a&gt;:&lt;/p&gt;
    ///
    /// &lt;blockquote class="remark"&gt;[&lt;em&gt;ssn:MeasurementCapability&lt;/em&gt;] &amp;ndash;&amp;ndash;&amp;ndash; (&lt;em&gt;ssn:ofFeature&lt;/em&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;em&gt;ssn:FeatureOfInterest&lt;/em&gt;]
    /// &lt;br /&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;[&lt;b&gt;Channel&lt;/b&gt;] &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;
    ///   (&lt;b&gt;ofAspect&lt;/b&gt;) &amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;ndash;&amp;gt; [&lt;b&gt;Aspect&lt;/b&gt;]&lt;/blockquote&gt;&lt;br /&gt;
    ///
    /// &lt;p&gt;[&lt;b&gt;SSN&lt;/b&gt;] A relation from a &lt;a&gt;ssn:MeasurementCapability&lt;/a&gt; to the &lt;a&gt;ssn:FeatureOfInterest&lt;/a&gt; the capability is described for. (Used in conjunction with &lt;a&gt;ssn:forProperty&lt;/a&gt;).&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 06:34 AM 2016-08-10 $^^rdfs:Literal</para>
    ///   <para>dcterms:source : [SSN]^^rdfs:Literal</para>
    ///   <para>ov:part : SSN-MeasurementCapability^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : of aspect^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#ofAspect">bci:ofAspect</a>
    /// </summary>
    let ofAspect = _prefixId.prefix "ofAspect"
    let ofAspect'_period_'POWDER = _prefixId.prefix "ofAspect.POWDER"
    /// <summary>
    ///   <para>ov:part : AnnotationTag^^rdfs:Literal</para>
    ///   <para>dcterms:title : pointsTo^^rdfs:Literal</para>
    ///   <para>skos:changeNote : %STATUS_STABLE%^^rdfs:Literal</para>
    ///   <para>skos:definition : &lt;p&gt;Connects a &lt;a&gt;Marker&lt;/a&gt; with a &lt;a&gt;DataSegment&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>skos:prefLabel : points to^^rdfs:Literal</para>
    ///   <para>skos:scopeNote : &lt;p&gt;Connecting a &lt;a&gt;Marker&lt;/a&gt; individual with a &lt;a&gt;DataSegment&lt;/a&gt;.&lt;/p&gt;^^rdfs:Literal</para>
    ///   <para>dcterms:modified : $ 12:07 AM 2016-06-13 $^^rdfs:Literal</para>
    ///   <para>dctype:StillImage : DataSegment.png^^rdfs:Literal</para>
    ///   <a href="https://w3id.org/BCI-ontology#pointsTo">bci:pointsTo</a>
    /// </summary>
    let pointsTo = _prefixId.prefix "pointsTo"
    let pointsTo'_period_'POWDER = _prefixId.prefix "pointsTo.POWDER"
