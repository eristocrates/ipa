namespace http.www.agls.gov.au.agls.terms.slash

open DoxAletheia.Rdf_Vocabulary

module agls =
    let _namespace_name = "http://www.agls.gov.au/agls/terms/"
    /// <summary>
    /// The set of function types specified by the National Archives of Australia.
    /// <see href="http://www.agls.gov.au/agls/terms/AGIFT"></see></summary>
    let AGIFT = Namespaced_IRI.parse _namespace_name "AGIFT" |> NamespacedName

    /// <summary>
    /// A set of function encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/FunctionClass"></see></summary>
    let FunctionClass =
        Namespaced_IRI.parse _namespace_name "FunctionClass" |> NamespacedName

    /// <summary>
    /// A set of agent encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/AGLSAgentClass"></see></summary>
    let AGLSAgentClass =
        Namespaced_IRI.parse _namespace_name "AGLSAgentClass" |> NamespacedName

    /// <summary>
    /// The set of industries specified by the Australian Bureau of Statistics.
    /// <see href="http://www.agls.gov.au/agls/terms/ANZSIC"></see></summary>
    let ANZSIC = Namespaced_IRI.parse _namespace_name "ANZSIC" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.agls.gov.au/agls/terms/AudienceClass"></see>
    /// </summary>
    let AudienceClass =
        Namespaced_IRI.parse _namespace_name "AudienceClass" |> NamespacedName

    /// <summary>
    /// The set of Australian economic, social, political and cultural affairs subjects specified by the National Library of Australia.
    /// <see href="http://www.agls.gov.au/agls/terms/APAIS"></see></summary>
    let APAIS = Namespaced_IRI.parse _namespace_name "APAIS" |> NamespacedName
    /// <summary>
    /// The set of subject terms for indexing Australian images specified by the National Library of Australia
    /// <see href="http://www.agls.gov.au/agls/terms/APT"></see></summary>
    let APT = Namespaced_IRI.parse _namespace_name "APT" |> NamespacedName
    /// <summary>
    /// The set of places specified by the Australian Bureau of Statistics
    /// <see href="http://www.agls.gov.au/agls/terms/ASGC"></see></summary>
    let ASGC = Namespaced_IRI.parse _namespace_name "ASGC" |> NamespacedName
    /// <summary>
    /// The set of occupations specified by the Australian Bureau of Statistics.
    /// <see href="http://www.agls.gov.au/agls/terms/AZNSCO"></see></summary>
    let AZNSCO = Namespaced_IRI.parse _namespace_name "AZNSCO" |> NamespacedName
    /// <summary>
    /// The set of agents defined by contact details according to Dublin Core Structured Values
    /// <see href="http://www.agls.gov.au/agls/terms/AglsAgent"></see></summary>
    let AglsAgent = Namespaced_IRI.parse _namespace_name "AglsAgent" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.agls.gov.au/agls/terms/AgentClass"></see>
    /// </summary>
    let AgentClass = Namespaced_IRI.parse _namespace_name "AgentClass" |> NamespacedName
    /// <summary>
    /// The set of resource availability or physical access to a resource defined by contact details according to Dublin Core Structured Values
    /// <see href="http://www.agls.gov.au/agls/terms/AglsAvail"></see></summary>
    let AglsAvail = Namespaced_IRI.parse _namespace_name "AglsAvail" |> NamespacedName
    /// <summary>
    /// A set of availability encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/AvailClass"></see></summary>
    let AvailClass = Namespaced_IRI.parse _namespace_name "AvailClass" |> NamespacedName
    /// <summary>
    /// The set of Australian jurisdictions specified by the AGLS Jurisdiction Scheme.
    /// <see href="http://www.agls.gov.au/agls/terms/AglsJuri"></see></summary>
    let AglsJuri = Namespaced_IRI.parse _namespace_name "AglsJuri" |> NamespacedName
    /// <summary>
    /// A set of jurisdiction encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/JuriClass"></see></summary>
    let JuriClass = Namespaced_IRI.parse _namespace_name "JuriClass" |> NamespacedName

    /// <summary>
    /// A set of document encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/DocumentClass"></see></summary>
    let DocumentClass =
        Namespaced_IRI.parse _namespace_name "DocumentClass" |> NamespacedName

    /// <summary>
    /// The set of agents defined by contact details according to X500 syntax.
    /// <see href="http://www.agls.gov.au/agls/terms/GOLD"></see></summary>
    let GOLD = Namespaced_IRI.parse _namespace_name "GOLD" |> NamespacedName
    /// <summary>
    /// Geographic coordinates expressed as latitude and longitude.
    /// <see href="http://www.agls.gov.au/agls/terms/Geocode"></see></summary>
    let Geocode = Namespaced_IRI.parse _namespace_name "Geocode" |> NamespacedName
    /// <summary>
    /// The set of postcodes specified by the Australian Postal Corporation.
    /// <see href="http://www.agls.gov.au/agls/terms/Postcode"></see></summary>
    let Postcode = Namespaced_IRI.parse _namespace_name "Postcode" |> NamespacedName

    /// <summary>
    /// A set of service encoding schemes and/or formats
    /// <see href="http://www.agls.gov.au/agls/terms/ServiceClass"></see></summary>
    let ServiceClass =
        Namespaced_IRI.parse _namespace_name "ServiceClass" |> NamespacedName

    /// <summary>
    /// The set of labelled subject types specified by the Australian Government Information Management Office
    /// <see href="http://www.agls.gov.au/agls/terms/TAGS"></see></summary>
    let TAGS = Namespaced_IRI.parse _namespace_name "TAGS" |> NamespacedName
    /// <summary>
    /// A specific piece of legislation which requires or drives the creation or provision of the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/act"></see></summary>
    let act = Namespaced_IRI.parse _namespace_name "act" |> NamespacedName
    /// <summary>
    /// A specific legal instrument which requires a resource to be created or made available.
    /// <see href="http://www.agls.gov.au/agls/terms/mandate"></see></summary>
    let mandate = Namespaced_IRI.parse _namespace_name "mandate" |> NamespacedName

    /// <summary>
    /// The level of aggregation of the described resource.
    /// <see href="http://www.agls.gov.au/agls/terms/aggregationLevel"></see></summary>
    let aggregationLevel =
        Namespaced_IRI.parse _namespace_name "aggregationLevel" |> NamespacedName

    /// <summary>
    /// The set of audience types specified by the AGLS Audience Scheme.
    /// <see href="http://www.agls.gov.au/agls/terms/agls-audience"></see></summary>
    let ``agls-audience`` =
        Namespaced_IRI.parse _namespace_name "agls-audience" |> NamespacedName

    /// <summary>
    /// The set of document types specified by the AGLS Document Scheme.
    /// <see href="http://www.agls.gov.au/agls/terms/agls-document"></see></summary>
    let ``agls-document`` =
        Namespaced_IRI.parse _namespace_name "agls-document" |> NamespacedName

    /// <summary>
    /// The set of service types specified by the AGLS Service Scheme.
    /// <see href="http://www.agls.gov.au/agls/terms/agls-service"></see></summary>
    let ``agls-service`` =
        Namespaced_IRI.parse _namespace_name "agls-service" |> NamespacedName

    /// <summary>
    /// How the resource can be obtained or accessed, or contact information.
    /// <see href="http://www.agls.gov.au/agls/terms/availability"></see></summary>
    let availability =
        Namespaced_IRI.parse _namespace_name "availability" |> NamespacedName

    /// <summary>
    /// A specific piece of case law which requires or drives the creation or provision of the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/case"></see></summary>
    let case = Namespaced_IRI.parse _namespace_name "case" |> NamespacedName
    /// <summary>
    /// The generic type of the resource being described.
    /// <see href="http://www.agls.gov.au/agls/terms/category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName

    /// <summary>
    /// Date a license was applied or became effective.
    /// <see href="http://www.agls.gov.au/agls/terms/dateLicensed"></see></summary>
    let dateLicensed =
        Namespaced_IRI.parse _namespace_name "dateLicensed" |> NamespacedName

    /// <summary>
    /// The form of the resource where category = 'document'.
    /// <see href="http://www.agls.gov.au/agls/terms/documentType"></see></summary>
    let documentType =
        Namespaced_IRI.parse _namespace_name "documentType" |> NamespacedName

    /// <summary>
    /// The set of audience types specified by Education Network Australia.
    /// <see href="http://www.agls.gov.au/agls/terms/edna-audience"></see></summary>
    let ``edna-audience`` =
        Namespaced_IRI.parse _namespace_name "edna-audience" |> NamespacedName

    /// <summary>
    /// The business function to which the resource relates.
    /// <see href="http://www.agls.gov.au/agls/terms/function"></see></summary>
    let function_ = Namespaced_IRI.parse _namespace_name "function" |> NamespacedName

    /// <summary>
    /// The name of the political/administrative entity covered by the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/jurisdiction"></see></summary>
    let jurisdiction =
        Namespaced_IRI.parse _namespace_name "jurisdiction" |> NamespacedName

    /// <summary>
    /// A protective marking applied to the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/protectiveMarking"></see></summary>
    let protectiveMarking =
        Namespaced_IRI.parse _namespace_name "protectiveMarking" |> NamespacedName

    /// <summary>
    /// A specific regulation which requires or drives the creation or provision of the resource.
    /// <see href="http://www.agls.gov.au/agls/terms/regulation"></see></summary>
    let regulation = Namespaced_IRI.parse _namespace_name "regulation" |> NamespacedName
    /// <summary>
    /// The set of functions codes to describe the function performed by the responsible party.
    /// <see href="http://www.agls.gov.au/agls/terms/roleCode"></see></summary>
    let roleCode = Namespaced_IRI.parse _namespace_name "roleCode" |> NamespacedName

    /// <summary>
    /// The form of the resource where category = 'service'.
    /// <see href="http://www.agls.gov.au/agls/terms/serviceType"></see></summary>
    let serviceType =
        Namespaced_IRI.parse _namespace_name "serviceType" |> NamespacedName
