namespace http.www.agls.gov.au.agls.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module agls =
    let _namespace_iri = Namespace_Iri agls |> NamespaceIRI
    /// <summary>
    ///   <para>agls:dateLicensed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date a license was applied or became effective.</para>
    /// labels<para>Date Licensed</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/dateLicensed">http://www.agls.gov.au/agls/terms/dateLicensed</seealso>
    let dateLicensed = Prefixed_Name(agls, "dateLicensed") |> PrefixedName
    /// <summary>
    ///   <para>agls:edna-audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>agls:AudienceClass</para>
    ///   <para>The set of audience types specified by Education Network Australia.</para>
    /// labels<para>Education Network Australia Audience Vocabulary</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/edna-audience">http://www.agls.gov.au/agls/terms/edna-audience</seealso>
    let edna_audience = Prefixed_Name(agls, "edna-audience") |> PrefixedName
    /// <summary>
    ///   <para>agls:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/">http://www.agls.gov.au/agls/terms/</seealso>
    let _prefix_iri = Prefixed_Name(agls, "") |> PrefixedName
    /// <summary>
    ///   <para>agls:AGIFT</para>
    /// </summary>
    /// <remarks>
    ///   <para>agls:FunctionClass</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of function types specified by the National Archives of Australia.</para>
    /// labels<para>Australian Governments' Interactive Functions Thesaurus</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AGIFT">http://www.agls.gov.au/agls/terms/AGIFT</seealso>
    let AGIFT = Prefixed_Name(agls, "AGIFT") |> PrefixedName
    /// <summary>
    ///   <para>agls:FunctionClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of function encoding schemes and/or formats</para>
    /// labels<para>Function Class</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/FunctionClass">http://www.agls.gov.au/agls/terms/FunctionClass</seealso>
    let FunctionClass = Prefixed_Name(agls, "FunctionClass") |> PrefixedName
    /// <summary>
    ///   <para>agls:AGLSAgentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of agent encoding schemes and/or formats</para>
    /// labels<para>AGLS Agent Class</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AGLSAgentClass">http://www.agls.gov.au/agls/terms/AGLSAgentClass</seealso>
    let AGLSAgentClass = Prefixed_Name(agls, "AGLSAgentClass") |> PrefixedName
    /// <summary>
    ///   <para>agls:AudienceClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AudienceClass">http://www.agls.gov.au/agls/terms/AudienceClass</seealso>
    let AudienceClass = Prefixed_Name(agls, "AudienceClass") |> PrefixedName
    /// <summary>
    ///   <para>agls:APT</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:SubjectScheme</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of subject terms for indexing Australian images specified by the National Library of Australia</para>
    /// labels<para>Australian Picture Thesaurus</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/APT">http://www.agls.gov.au/agls/terms/APT</seealso>
    let APT = Prefixed_Name(agls, "APT") |> PrefixedName
    /// <summary>
    ///   <para>agls:ANZSIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>agls:AudienceClass</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of industries specified by the Australian Bureau of Statistics.</para>
    /// labels<para>Australian and New Zealand Standard Industrial Classification</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/ANZSIC">http://www.agls.gov.au/agls/terms/ANZSIC</seealso>
    let ANZSIC = Prefixed_Name(agls, "ANZSIC") |> PrefixedName
    /// <summary>
    ///   <para>agls:APAIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:SubjectScheme</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of Australian economic, social, political and cultural affairs subjects specified by the National Library of Australia.</para>
    /// labels<para>Australian Public Affairs Information Service</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/APAIS">http://www.agls.gov.au/agls/terms/APAIS</seealso>
    let APAIS = Prefixed_Name(agls, "APAIS") |> PrefixedName
    /// <summary>
    ///   <para>agls:AZNSCO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>agls:AudienceClass</para>
    ///   <para>The set of occupations specified by the Australian Bureau of Statistics.</para>
    /// labels<para>Australian and New Zealand Standard Classification of Occupations</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AZNSCO">http://www.agls.gov.au/agls/terms/AZNSCO</seealso>
    let AZNSCO = Prefixed_Name(agls, "AZNSCO") |> PrefixedName
    /// <summary>
    ///   <para>agls:AglsAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>agls:AgentClass</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>The set of agents defined by contact details according to Dublin Core Structured Values</para>
    /// labels<para>AAGLS Agent Scheme</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AglsAgent">http://www.agls.gov.au/agls/terms/AglsAgent</seealso>
    let AglsAgent = Prefixed_Name(agls, "AglsAgent") |> PrefixedName
    /// <summary>
    ///   <para>agls:AvailClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of availability encoding schemes and/or formats</para>
    /// labels<para>Availability Class</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AvailClass">http://www.agls.gov.au/agls/terms/AvailClass</seealso>
    let AvailClass = Prefixed_Name(agls, "AvailClass") |> PrefixedName
    /// <summary>
    ///   <para>agls:JuriClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of jurisdiction encoding schemes and/or formats</para>
    /// labels<para>Jurisdiction Class</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/JuriClass">http://www.agls.gov.au/agls/terms/JuriClass</seealso>
    let JuriClass = Prefixed_Name(agls, "JuriClass") |> PrefixedName
    /// <summary>
    ///   <para>agls:DocumentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of document encoding schemes and/or formats</para>
    /// labels<para>Document Class</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/DocumentClass">http://www.agls.gov.au/agls/terms/DocumentClass</seealso>
    let DocumentClass = Prefixed_Name(agls, "DocumentClass") |> PrefixedName
    /// <summary>
    ///   <para>agls:GOLD</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>agls:AgentClass</para>
    ///   <para>The set of agents defined by contact details according to X500 syntax.</para>
    /// labels<para>Government Online Directory</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/GOLD">http://www.agls.gov.au/agls/terms/GOLD</seealso>
    let GOLD = Prefixed_Name(agls, "GOLD") |> PrefixedName
    /// <summary>
    ///   <para>agls:Geocode</para>
    /// </summary>
    /// <remarks>
    ///   <para>agls:AgentClass</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>Geographic coordinates expressed as latitude and longitude.</para>
    /// labels<para>Geocode</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/Geocode">http://www.agls.gov.au/agls/terms/Geocode</seealso>
    let Geocode = Prefixed_Name(agls, "Geocode") |> PrefixedName
    /// <summary>
    ///   <para>agls:ServiceClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of service encoding schemes and/or formats</para>
    /// labels<para>Service Class</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/ServiceClass">http://www.agls.gov.au/agls/terms/ServiceClass</seealso>
    let ServiceClass = Prefixed_Name(agls, "ServiceClass") |> PrefixedName
    /// <summary>
    ///   <para>agls:act</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A specific piece of legislation which requires or drives the creation or provision of the resource.</para>
    /// labels<para>Act</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/act">http://www.agls.gov.au/agls/terms/act</seealso>
    let act = Prefixed_Name(agls, "act") |> PrefixedName
    /// <summary>
    ///   <para>agls:mandate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A specific legal instrument which requires a resource to be created or made available.</para>
    /// labels<para>Mandate</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/mandate">http://www.agls.gov.au/agls/terms/mandate</seealso>
    let mandate = Prefixed_Name(agls, "mandate") |> PrefixedName
    /// <summary>
    ///   <para>agls:aggregationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The level of aggregation of the described resource.</para>
    /// labels<para>Aggregation Level</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/aggregationLevel">http://www.agls.gov.au/agls/terms/aggregationLevel</seealso>
    let aggregationLevel = Prefixed_Name(agls, "aggregationLevel") |> PrefixedName
    /// <summary>
    ///   <para>agls:agls-audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>agls:AgentClass</para>
    ///   <para>The set of audience types specified by the AGLS Audience Scheme.</para>
    /// labels<para>AGLS Audience Vocabulary</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/agls-audience">http://www.agls.gov.au/agls/terms/agls-audience</seealso>
    let agls_audience = Prefixed_Name(agls, "agls-audience") |> PrefixedName
    /// <summary>
    ///   <para>agls:agls-document</para>
    /// </summary>
    /// <remarks>
    ///   <para>agls:DocumentClass</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of document types specified by the AGLS Document Scheme.</para>
    /// labels<para>AGLS Document Vocabulary</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/agls-document">http://www.agls.gov.au/agls/terms/agls-document</seealso>
    let agls_document = Prefixed_Name(agls, "agls-document") |> PrefixedName
    /// <summary>
    ///   <para>agls:availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>How the resource can be obtained or accessed, or contact information.</para>
    /// labels<para>Availability</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/availability">http://www.agls.gov.au/agls/terms/availability</seealso>
    let availability = Prefixed_Name(agls, "availability") |> PrefixedName
    /// <summary>
    ///   <para>agls:case</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A specific piece of case law which requires or drives the creation or provision of the resource.</para>
    /// labels<para>Case</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/case">http://www.agls.gov.au/agls/terms/case</seealso>
    let case = Prefixed_Name(agls, "case") |> PrefixedName
    /// <summary>
    ///   <para>agls:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The generic type of the resource being described.</para>
    /// labels<para>Category</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/category">http://www.agls.gov.au/agls/terms/category</seealso>
    let category = Prefixed_Name(agls, "category") |> PrefixedName
    /// <summary>
    ///   <para>agls:documentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The form of the resource where category = 'document'.</para>
    /// labels<para>Document Type</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/documentType">http://www.agls.gov.au/agls/terms/documentType</seealso>
    let documentType = Prefixed_Name(agls, "documentType") |> PrefixedName
    /// <summary>
    ///   <para>agls:function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The business function to which the resource relates.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/function">http://www.agls.gov.au/agls/terms/function</seealso>
    let function_ = Prefixed_Name(agls, "function") |> PrefixedName
    /// <summary>
    ///   <para>agls:jurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the political/administrative entity covered by the resource.</para>
    /// labels<para>Jurisdiction</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/jurisdiction">http://www.agls.gov.au/agls/terms/jurisdiction</seealso>
    let jurisdiction = Prefixed_Name(agls, "jurisdiction") |> PrefixedName
    /// <summary>
    ///   <para>agls:protectiveMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A protective marking applied to the resource.</para>
    /// labels<para>Protective Marking</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/protectiveMarking">http://www.agls.gov.au/agls/terms/protectiveMarking</seealso>
    let protectiveMarking = Prefixed_Name(agls, "protectiveMarking") |> PrefixedName
    /// <summary>
    ///   <para>agls:regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A specific regulation which requires or drives the creation or provision of the resource.</para>
    /// labels<para>Regulation</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/regulation">http://www.agls.gov.au/agls/terms/regulation</seealso>
    let regulation = Prefixed_Name(agls, "regulation") |> PrefixedName
    /// <summary>
    ///   <para>agls:roleCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>agls:AudienceClass</para>
    ///   <para>The set of functions codes to describe the function performed by the responsible party.</para>
    /// labels<para>Role Code</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/roleCode">http://www.agls.gov.au/agls/terms/roleCode</seealso>
    let roleCode = Prefixed_Name(agls, "roleCode") |> PrefixedName
    /// <summary>
    ///   <para>agls:serviceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The form of the resource where category = 'service'.</para>
    /// labels<para>Service Type</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/serviceType">http://www.agls.gov.au/agls/terms/serviceType</seealso>
    let serviceType = Prefixed_Name(agls, "serviceType") |> PrefixedName
    /// <summary>
    ///   <para>agls:ASGC</para>
    /// </summary>
    /// <remarks>
    ///   <para>agls:AudienceClass</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of places specified by the Australian Bureau of Statistics</para>
    /// labels<para>Australian Standard Geographical Classification</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/ASGC">http://www.agls.gov.au/agls/terms/ASGC</seealso>
    let ASGC = Prefixed_Name(agls, "ASGC") |> PrefixedName
    /// <summary>
    ///   <para>agls:AgentClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AgentClass">http://www.agls.gov.au/agls/terms/AgentClass</seealso>
    let AgentClass = Prefixed_Name(agls, "AgentClass") |> PrefixedName
    /// <summary>
    ///   <para>agls:AglsAvail</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>agls:AvailClass</para>
    ///   <para>The set of resource availability or physical access to a resource defined by contact details according to Dublin Core Structured Values</para>
    /// labels<para>AGLS Availability Scheme</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AglsAvail">http://www.agls.gov.au/agls/terms/AglsAvail</seealso>
    let AglsAvail = Prefixed_Name(agls, "AglsAvail") |> PrefixedName
    /// <summary>
    ///   <para>agls:AglsJuri</para>
    /// </summary>
    /// <remarks>
    ///   <para>agls:JuriClass</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of Australian jurisdictions specified by the AGLS Jurisdiction Scheme.</para>
    /// labels<para>AGLS Jurisdiction Vocabulary</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/AglsJuri">http://www.agls.gov.au/agls/terms/AglsJuri</seealso>
    let AglsJuri = Prefixed_Name(agls, "AglsJuri") |> PrefixedName
    /// <summary>
    ///   <para>agls:Postcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>agls:AudienceClass</para>
    ///   <para>The set of postcodes specified by the Australian Postal Corporation.</para>
    /// labels<para>Australian Postcode</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/Postcode">http://www.agls.gov.au/agls/terms/Postcode</seealso>
    let Postcode = Prefixed_Name(agls, "Postcode") |> PrefixedName
    /// <summary>
    ///   <para>agls:TAGS</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:SubjectScheme</para>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>The set of labelled subject types specified by the Australian Government Information Management Office</para>
    /// labels<para>Thesaurus of Australian Governments</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/TAGS">http://www.agls.gov.au/agls/terms/TAGS</seealso>
    let TAGS = Prefixed_Name(agls, "TAGS") |> PrefixedName
    /// <summary>
    ///   <para>agls:agls-service</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcam:VocabularyEncodingScheme</para>
    ///   <para>agls:ServiceClass</para>
    ///   <para>The set of service types specified by the AGLS Service Scheme.</para>
    /// labels<para>AGLS Service Vocabulary</para></remarks>
    /// <seealso href="http://www.agls.gov.au/agls/terms/agls-service">http://www.agls.gov.au/agls/terms/agls-service</seealso>
    let agls_service = Prefixed_Name(agls, "agls-service") |> PrefixedName
