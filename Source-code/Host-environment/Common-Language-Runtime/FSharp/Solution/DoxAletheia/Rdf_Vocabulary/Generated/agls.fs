namespace http.www.agls.gov.au.agls.terms.slash

open DoxAletheia

module agls =
    let _namespace_name = "http://www.agls.gov.au/agls/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The set of function types specified by the National Archives of Australia.
    /// <see href="http://www.agls.gov.au/agls/terms/AGIFT"></see></summary>
    let AGIFT = _prefix "AGIFT"
    /// <summary>
    /// A set of function encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/FunctionClass"></see></summary>
    let FunctionClass = _prefix "FunctionClass"
    /// <summary>
    /// A set of agent encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/AGLSAgentClass"></see></summary>
    let AGLSAgentClass = _prefix "AGLSAgentClass"
    /// <summary>
    /// The set of industries specified by the Australian Bureau of Statistics.
    /// <see href="http://www.agls.gov.au/agls/terms/ANZSIC"></see></summary>
    let ANZSIC = _prefix "ANZSIC"
    /// <summary>
    ///   <see href="http://www.agls.gov.au/agls/terms/AudienceClass"></see>
    /// </summary>
    let AudienceClass = _prefix "AudienceClass"
    /// <summary>
    /// The set of Australian economic, social, political and cultural affairs subjects specified by the National Library of Australia.
    /// <see href="http://www.agls.gov.au/agls/terms/APAIS"></see></summary>
    let APAIS = _prefix "APAIS"
    /// <summary>
    /// The set of subject terms for indexing Australian images specified by the National Library of Australia
    /// <see href="http://www.agls.gov.au/agls/terms/APT"></see></summary>
    let APT = _prefix "APT"
    /// <summary>
    /// The set of places specified by the Australian Bureau of Statistics
    /// <see href="http://www.agls.gov.au/agls/terms/ASGC"></see></summary>
    let ASGC = _prefix "ASGC"
    /// <summary>
    /// The set of occupations specified by the Australian Bureau of Statistics.
    /// <see href="http://www.agls.gov.au/agls/terms/AZNSCO"></see></summary>
    let AZNSCO = _prefix "AZNSCO"
    /// <summary>
    /// The set of agents defined by contact details according to Dublin Core Structured Values
    /// <see href="http://www.agls.gov.au/agls/terms/AglsAgent"></see></summary>
    let AglsAgent = _prefix "AglsAgent"
    /// <summary>
    ///   <see href="http://www.agls.gov.au/agls/terms/AgentClass"></see>
    /// </summary>
    let AgentClass = _prefix "AgentClass"
    /// <summary>
    /// The set of resource availability or physical access to a resource defined by contact details according to Dublin Core Structured Values
    /// <see href="http://www.agls.gov.au/agls/terms/AglsAvail"></see></summary>
    let AglsAvail = _prefix "AglsAvail"
    /// <summary>
    /// A set of availability encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/AvailClass"></see></summary>
    let AvailClass = _prefix "AvailClass"
    /// <summary>
    /// The set of Australian jurisdictions specified by the AGLS Jurisdiction Scheme.
    /// <see href="http://www.agls.gov.au/agls/terms/AglsJuri"></see></summary>
    let AglsJuri = _prefix "AglsJuri"
    /// <summary>
    /// A set of jurisdiction encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/JuriClass"></see></summary>
    let JuriClass = _prefix "JuriClass"
    /// <summary>
    /// A set of document encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/DocumentClass"></see></summary>
    let DocumentClass = _prefix "DocumentClass"
    /// <summary>
    /// The set of agents defined by contact details according to X500 syntax.
    /// <see href="http://www.agls.gov.au/agls/terms/GOLD"></see></summary>
    let GOLD = _prefix "GOLD"
    /// <summary>
    /// Geographic coordinates expressed as latitude and longitude.
    /// <see href="http://www.agls.gov.au/agls/terms/Geocode"></see></summary>
    let Geocode = _prefix "Geocode"
    /// <summary>
    /// The set of postcodes specified by the Australian Postal Corporation.
    /// <see href="http://www.agls.gov.au/agls/terms/Postcode"></see></summary>
    let Postcode = _prefix "Postcode"
    /// <summary>
    /// A set of service encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/ServiceClass"></see></summary>
    let ServiceClass = _prefix "ServiceClass"
    /// <summary>
    /// The set of labelled subject types specified by the Australian Government Information Management Office
    /// <see href="http://www.agls.gov.au/agls/terms/TAGS"></see></summary>
    let TAGS = _prefix "TAGS"
    /// <summary>
    /// A specific piece of legislation which requires or drives the creation or provision of the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/act"></see></summary>
    let act = _prefix "act"
    /// <summary>
    /// A specific legal instrument which requires a resource to be created or made available.
    /// <see href="http://www.agls.gov.au/agls/terms/mandate"></see></summary>
    let mandate = _prefix "mandate"
    /// <summary>
    /// The level of aggregation of the described resource.
    /// <see href="http://www.agls.gov.au/agls/terms/aggregationLevel"></see></summary>
    let aggregationLevel = _prefix "aggregationLevel"
    /// <summary>
    /// The set of audience types specified by the AGLS Audience Scheme.
    /// <see href="http://www.agls.gov.au/agls/terms/agls-audience"></see></summary>
    let ``agls-audience`` = _prefix "agls-audience"
    /// <summary>
    /// The set of document types specified by the AGLS Document Scheme.
    /// <see href="http://www.agls.gov.au/agls/terms/agls-document"></see></summary>
    let ``agls-document`` = _prefix "agls-document"
    /// <summary>
    /// The set of service types specified by the AGLS Service Scheme.
    /// <see href="http://www.agls.gov.au/agls/terms/agls-service"></see></summary>
    let ``agls-service`` = _prefix "agls-service"
    /// <summary>
    /// How the resource can be obtained or accessed, or contact information.
    /// <see href="http://www.agls.gov.au/agls/terms/availability"></see></summary>
    let availability = _prefix "availability"
    /// <summary>
    /// A specific piece of case law which requires or drives the creation or provision of the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/case"></see></summary>
    let case = _prefix "case"
    /// <summary>
    /// The generic type of the resource being described.
    /// <see href="http://www.agls.gov.au/agls/terms/category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// Date a license was applied or became effective.
    /// <see href="http://www.agls.gov.au/agls/terms/dateLicensed"></see></summary>
    let dateLicensed = _prefix "dateLicensed"
    /// <summary>
    /// The form of the resource where category = 'document'.
    /// <see href="http://www.agls.gov.au/agls/terms/documentType"></see></summary>
    let documentType = _prefix "documentType"
    /// <summary>
    /// The set of audience types specified by Education Network Australia.
    /// <see href="http://www.agls.gov.au/agls/terms/edna-audience"></see></summary>
    let ``edna-audience`` = _prefix "edna-audience"
    /// <summary>
    /// The business function to which the resource relates.
    /// <see href="http://www.agls.gov.au/agls/terms/function"></see></summary>
    let function_ = _prefix "function"
    /// <summary>
    /// The name of the political/administrative entity covered by the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/jurisdiction"></see></summary>
    let jurisdiction = _prefix "jurisdiction"
    /// <summary>
    /// A protective marking applied to the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/protectiveMarking"></see></summary>
    let protectiveMarking = _prefix "protectiveMarking"
    /// <summary>
    /// A specific regulation which requires or drives the creation or provision of the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/regulation"></see></summary>
    let regulation = _prefix "regulation"
    /// <summary>
    /// The set of functions codes to describe the function performed by the responsible party.
    /// <see href="http://www.agls.gov.au/agls/terms/roleCode"></see></summary>
    let roleCode = _prefix "roleCode"
    /// <summary>
    /// The form of the resource where category = 'service'.
    /// <see href="http://www.agls.gov.au/agls/terms/serviceType"></see></summary>
    let serviceType = _prefix "serviceType"
