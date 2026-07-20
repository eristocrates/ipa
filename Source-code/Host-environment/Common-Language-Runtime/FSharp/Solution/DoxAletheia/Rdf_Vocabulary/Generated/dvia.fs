namespace http.purl.org.ontology.dvia.hash

open DoxAletheia

module dvia =
    let _namespace_name = "http://purl.org/ontology/dvia#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The aplication or the mashup developed for demo-ing or consuming data in LD fashion
    /// <see href="http://purl.org/ontology/dvia#Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// The platform where to host or use the application, could be on the web (firefox, chrome, IE, etc..) or mobile (android, etc..) or event desktop
    /// <see href="http://purl.org/ontology/dvia#Platform"></see></summary>
    let Platform = _prefix "Platform"
    /// <summary>
    /// The tool or library used to build the application
    /// <see href="http://purl.org/ontology/dvia#VisualTool"></see></summary>
    let VisualTool = _prefix "VisualTool"
    /// <summary>
    /// The name of the alternate navigator if applicable
    /// <see href="http://purl.org/ontology/dvia#alternativeNavigator"></see></summary>
    let alternativeNavigator = _prefix "alternativeNavigator"
    /// <summary>
    /// This property links the application to a platform to actually use the application.
    /// <see href="http://purl.org/ontology/dvia#platform"></see></summary>
    let platform = _prefix "platform"
    /// <summary>
    /// links to the authors of the application or the tools, libraries
    /// <see href="http://purl.org/ontology/dvia#author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// The business value of the application; generally could be commercial of free. Also depending on the license
    /// <see href="http://purl.org/ontology/dvia#businessValue"></see></summary>
    let businessValue = _prefix "businessValue"
    /// <summary>
    /// links to the dataset used to make the application, and could be of different types or formats
    /// <see href="http://purl.org/ontology/dvia#consumes"></see></summary>
    let consumes = _prefix "consumes"
    /// <summary>
    /// Property for a given descriptive informations of the datasets used for making the application. It could be used when no more details are given on the datasets like URL, formats, etc.
    /// <see href="http://purl.org/ontology/dvia#datasetDescription"></see></summary>
    let datasetDescription = _prefix "datasetDescription"
    /// <summary>
    /// links to the organization which builds the application
    /// <see href="http://purl.org/ontology/dvia#designBy"></see></summary>
    let designBy = _prefix "designBy"
    /// <summary>
    /// The download url of the tool for visualization.
    /// <see href="http://purl.org/ontology/dvia#downloadUrl"></see></summary>
    let downloadUrl = _prefix "downloadUrl"
    /// <summary>
    /// This property links to the license of the application
    /// <see href="http://purl.org/ontology/dvia#hasLicense"></see></summary>
    let hasLicense = _prefix "hasLicense"
    /// <summary>
    /// keywords used for the application.
    /// <see href="http://purl.org/ontology/dvia#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// The url to the page describing the library or the tool for visualization.
    /// <see href="http://purl.org/ontology/dvia#libUrl"></see></summary>
    let libUrl = _prefix "libUrl"
    /// <summary>
    /// The name of the preferred navigator to be usd by the application
    /// <see href="http://purl.org/ontology/dvia#preferredNavigator"></see></summary>
    let preferredNavigator = _prefix "preferredNavigator"
    /// <summary>
    /// The scope or domain of the application.
    /// <see href="http://purl.org/ontology/dvia#scope"></see></summary>
    let scope = _prefix "scope"
    /// <summary>
    /// The operating system where the application runs.
    /// <see href="http://purl.org/ontology/dvia#system"></see></summary>
    let system = _prefix "system"
    /// <summary>
    /// the url of the application.
    /// <see href="http://purl.org/ontology/dvia#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// This property links to the tools or libraries used for the application
    /// <see href="http://purl.org/ontology/dvia#usesTool"></see></summary>
    let usesTool = _prefix "usesTool"
    /// <summary>
    /// The types of view available in the application, such as maps, charts, graphs, etc.
    /// <see href="http://purl.org/ontology/dvia#view"></see></summary>
    let view = _prefix "view"
