namespace http.purl.org.ontology.dvia.hash

open DoxAletheia.Rdf_Vocabulary

module dvia =
    let _namespace_name = "http://purl.org/ontology/dvia#"

    /// <summary>
    /// The aplication or the mashup developed for demo-ing or consuming data in LD fashion
    /// <see href="http://purl.org/ontology/dvia#Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// The platform where to host or use the application, could be on the web (firefox, chrome, IE, etc..) or mobile (android, etc..) or event desktop
    /// <see href="http://purl.org/ontology/dvia#Platform"></see></summary>
    let Platform = Namespaced_IRI.parse _namespace_name "Platform" |> NamespacedName
    /// <summary>
    /// The tool or library used to build the application
    /// <see href="http://purl.org/ontology/dvia#VisualTool"></see></summary>
    let VisualTool = Namespaced_IRI.parse _namespace_name "VisualTool" |> NamespacedName

    /// <summary>
    /// The name of the alternate navigator if applicable
    /// <see href="http://purl.org/ontology/dvia#alternativeNavigator"></see></summary>
    let alternativeNavigator =
        Namespaced_IRI.parse _namespace_name "alternativeNavigator" |> NamespacedName

    /// <summary>
    /// This property links the application to a platform to actually use the application.
    /// <see href="http://purl.org/ontology/dvia#platform"></see></summary>
    let platform = Namespaced_IRI.parse _namespace_name "platform" |> NamespacedName
    /// <summary>
    /// links to the authors of the application or the tools, libraries
    /// <see href="http://purl.org/ontology/dvia#author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    /// The business value of the application; generally could be commercial of free. Also depending on the license
    /// <see href="http://purl.org/ontology/dvia#businessValue"></see></summary>
    let businessValue =
        Namespaced_IRI.parse _namespace_name "businessValue" |> NamespacedName

    /// <summary>
    /// links to the dataset used to make the application, and could be of different types or formats
    /// <see href="http://purl.org/ontology/dvia#consumes"></see></summary>
    let consumes = Namespaced_IRI.parse _namespace_name "consumes" |> NamespacedName

    /// <summary>
    /// Property for a given descriptive informations of the datasets used for making the application. It could be used when no more details are given on the datasets like URL, formats, etc.
    /// <see href="http://purl.org/ontology/dvia#datasetDescription"></see></summary>
    let datasetDescription =
        Namespaced_IRI.parse _namespace_name "datasetDescription" |> NamespacedName

    /// <summary>
    /// links to the organization which builds the application
    /// <see href="http://purl.org/ontology/dvia#designBy"></see></summary>
    let designBy = Namespaced_IRI.parse _namespace_name "designBy" |> NamespacedName

    /// <summary>
    /// The download url of the tool for visualization.
    /// <see href="http://purl.org/ontology/dvia#downloadUrl"></see></summary>
    let downloadUrl =
        Namespaced_IRI.parse _namespace_name "downloadUrl" |> NamespacedName

    /// <summary>
    /// This property links to the license of the application
    /// <see href="http://purl.org/ontology/dvia#hasLicense"></see></summary>
    let hasLicense = Namespaced_IRI.parse _namespace_name "hasLicense" |> NamespacedName
    /// <summary>
    /// keywords used for the application.
    /// <see href="http://purl.org/ontology/dvia#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    /// The url to the page describing the library or the tool for visualization.
    /// <see href="http://purl.org/ontology/dvia#libUrl"></see></summary>
    let libUrl = Namespaced_IRI.parse _namespace_name "libUrl" |> NamespacedName

    /// <summary>
    /// The name of the preferred navigator to be usd by the application
    /// <see href="http://purl.org/ontology/dvia#preferredNavigator"></see></summary>
    let preferredNavigator =
        Namespaced_IRI.parse _namespace_name "preferredNavigator" |> NamespacedName

    /// <summary>
    /// The scope or domain of the application.
    /// <see href="http://purl.org/ontology/dvia#scope"></see></summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName
    /// <summary>
    /// The operating system where the application runs.
    /// <see href="http://purl.org/ontology/dvia#system"></see></summary>
    let system = Namespaced_IRI.parse _namespace_name "system" |> NamespacedName
    /// <summary>
    /// the url of the application.
    /// <see href="http://purl.org/ontology/dvia#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    /// This property links to the tools or libraries used for the application
    /// <see href="http://purl.org/ontology/dvia#usesTool"></see></summary>
    let usesTool = Namespaced_IRI.parse _namespace_name "usesTool" |> NamespacedName
    /// <summary>
    /// The types of view available in the application, such as maps, charts, graphs, etc.
    /// <see href="http://purl.org/ontology/dvia#view"></see></summary>
    let view = Namespaced_IRI.parse _namespace_name "view" |> NamespacedName
