#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module agls =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.agls.gov.au/agls/terms/" "agls"

    let _namespaceIri = _prefixId.prefix ""
    let AGIFT = _prefixId.prefix "AGIFT"
    /// <summary>
    ///   <para>dcterms:modified : 2010-04-13^^xsd:string</para>
    ///   <para>dcterms:issued : 2008-05-27^^xsd:string</para>
    ///   <para>rdfs:comment : A set of agent encoding schemes and/or formats</para>
    ///   <para>rdfs:label : AGLS Agent Class</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/AGLSAgentClass">agls:AGLSAgentClass</a>
    /// </summary>
    let AGLSAgentClass = _prefixId.prefix "AGLSAgentClass"
    let ANZSIC = _prefixId.prefix "ANZSIC"
    let APAIS = _prefixId.prefix "APAIS"
    let APT = _prefixId.prefix "APT"
    let ASGC = _prefixId.prefix "ASGC"
    let AZNSCO = _prefixId.prefix "AZNSCO"
    let AgentClass = _prefixId.prefix "AgentClass"
    let AglsAgent = _prefixId.prefix "AglsAgent"
    let AglsAvail = _prefixId.prefix "AglsAvail"
    let AglsJuri = _prefixId.prefix "AglsJuri"
    let AudienceClass = _prefixId.prefix "AudienceClass"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-12^^xsd:string</para>
    ///   <para>rdfs:comment : A set of availability encoding schemes and/or formats</para>
    ///   <para>rdfs:label : Availability Class</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/AvailClass">agls:AvailClass</a>
    /// </summary>
    let AvailClass = _prefixId.prefix "AvailClass"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-12^^xsd:string</para>
    ///   <para>rdfs:comment : A set of document encoding schemes and/or formats</para>
    ///   <para>rdfs:label : Document Class</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/DocumentClass">agls:DocumentClass</a>
    /// </summary>
    let DocumentClass = _prefixId.prefix "DocumentClass"
    /// <summary>
    ///   <para>dcterms:modified : 2010-04-13^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-12^^xsd:string</para>
    ///   <para>rdfs:comment : A set of function encoding schemes and/or formats</para>
    ///   <para>rdfs:label : Function Class</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/FunctionClass">agls:FunctionClass</a>
    /// </summary>
    let FunctionClass = _prefixId.prefix "FunctionClass"
    let GOLD = _prefixId.prefix "GOLD"
    let Geocode = _prefixId.prefix "Geocode"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-12^^xsd:string</para>
    ///   <para>rdfs:comment : A set of jurisdiction encoding schemes and/or formats</para>
    ///   <para>rdfs:label : Jurisdiction Class</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/JuriClass">agls:JuriClass</a>
    /// </summary>
    let JuriClass = _prefixId.prefix "JuriClass"
    let Postcode = _prefixId.prefix "Postcode"
    /// <summary>
    ///   <para>dcterms:modified : 2010-04-13^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-12^^xsd:string</para>
    ///   <para>rdfs:comment : A set of service encoding schemes and/or formats</para>
    ///   <para>rdfs:label : Service Class</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/ServiceClass">agls:ServiceClass</a>
    /// </summary>
    let ServiceClass = _prefixId.prefix "ServiceClass"
    let TAGS = _prefixId.prefix "TAGS"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>rdfs:comment : A specific piece of legislation which requires or drives the creation or provision of the resource.</para>
    ///   <para>rdfs:label : Act</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/act">agls:act</a>
    /// </summary>
    let act = _prefixId.prefix "act"
    /// <summary>
    ///   <para>rdfs:label : Aggregation Level</para>
    ///   <para>dcterms:description : There are only two values possible for this refinement, either item or collection.</para>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>dcterms:modified : 2007-12-19^^xsd:string</para>
    ///   <para>rdfs:comment : The level of aggregation of the described resource.</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/aggregationLevel">agls:aggregationLevel</a>
    /// </summary>
    let aggregationLevel = _prefixId.prefix "aggregationLevel"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>rdfs:comment : The set of audience types specified by the AGLS Audience Scheme.</para>
    ///   <para>rdfs:label : AGLS Audience Vocabulary</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/agls-audience">agls:agls-audience</a>
    /// </summary>
    let agls_audience = _prefixId.prefix "agls-audience"
    let agls_document = _prefixId.prefix "agls-document"
    let agls_service = _prefixId.prefix "agls-service"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-19^^xsd:string</para>
    ///   <para>rdfs:comment : How the resource can be obtained or accessed, or contact information.</para>
    ///   <para>rdfs:label : Availability</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/availability">agls:availability</a>
    /// </summary>
    let availability = _prefixId.prefix "availability"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>rdfs:comment : A specific piece of case law which requires or drives the creation or provision of the resource.</para>
    ///   <para>rdfs:label : Case</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/case">agls:case</a>
    /// </summary>
    let case = _prefixId.prefix "case"
    /// <summary>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>rdfs:label : Category</para>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>rdfs:comment : The generic type of the resource being described.</para>
    ///   <para>dcterms:description : There are only three valid values for this property, 'service', 'document' or 'agency'.</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/category">agls:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:comment : Date a license was applied or became effective.</para>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-12^^xsd:string</para>
    ///   <para>rdfs:label : Date Licensed</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/dateLicensed">agls:dateLicensed</a>
    /// </summary>
    let dateLicensed = _prefixId.prefix "dateLicensed"
    /// <summary>
    ///   <para>rdfs:comment : The form of the resource where category = 'document'.</para>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>rdfs:label : Document Type</para>
    ///   <para>dcterms:description : Document is used in its widest sense and includes such things as software, sound files and images.</para>
    ///   <para>dcterms:modified : 2007-12-19^^xsd:string</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/documentType">agls:documentType</a>
    /// </summary>
    let documentType = _prefixId.prefix "documentType"
    let edna_audience = _prefixId.prefix "edna-audience"
    /// <summary>
    ///   <para>dcterms:modified : 2007-12-19^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-19^^xsd:string</para>
    ///   <para>rdfs:comment : The business function to which the resource relates.</para>
    ///   <para>rdfs:label : Function</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/function">agls:function</a>
    /// </summary>
    let function_ = _prefixId.prefix "function"
    /// <summary>
    ///   <para>dcterms:description : Jurisdiction is a description of the territory over which a particular government exercises its authority or a particular business transacts its operations, to which the resource content is applicable.</para>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>dcterms:modified : 2007-12-19^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the political/administrative entity covered by the resource.</para>
    ///   <para>rdfs:label : Jurisdiction</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/jurisdiction">agls:jurisdiction</a>
    /// </summary>
    let jurisdiction = _prefixId.prefix "jurisdiction"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-19^^xsd:string</para>
    ///   <para>rdfs:comment : A specific legal instrument which requires a resource to be created or made available.</para>
    ///   <para>rdfs:label : Mandate</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/mandate">agls:mandate</a>
    /// </summary>
    let mandate = _prefixId.prefix "mandate"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-06^^xsd:string</para>
    ///   <para>dcterms:issued : 2007-12-12^^xsd:string</para>
    ///   <para>rdfs:comment : A protective marking applied to the resource.</para>
    ///   <para>rdfs:label : Protective Marking</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/protectiveMarking">agls:protectiveMarking</a>
    /// </summary>
    let protectiveMarking = _prefixId.prefix "protectiveMarking"
    /// <summary>
    ///   <para>dcterms:modified : 2009-02-02^^xsd:string</para>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>rdfs:comment : A specific regulation which requires or drives the creation or provision of the resource.</para>
    ///   <para>rdfs:label : Regulation</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/regulation">agls:regulation</a>
    /// </summary>
    let regulation = _prefixId.prefix "regulation"
    let roleCode = _prefixId.prefix "roleCode"
    /// <summary>
    ///   <para>dcterms:modified : 2007-12-19^^xsd:string</para>
    ///   <para>dcterms:issued : 2002-04-18^^xsd:string</para>
    ///   <para>rdfs:comment : The form of the resource where category = 'service'.</para>
    ///   <para>rdfs:label : Service Type</para>
    ///   <a href="http://www.agls.gov.au/agls/terms/serviceType">agls:serviceType</a>
    /// </summary>
    let serviceType = _prefixId.prefix "serviceType"
