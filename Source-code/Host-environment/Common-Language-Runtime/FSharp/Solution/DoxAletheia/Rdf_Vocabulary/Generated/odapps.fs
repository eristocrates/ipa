namespace http.semweb.mmlab.be.ns.odapps.hash

open DoxAletheia.Rdf_Vocabulary

module odapps =
    let _namespace_name = "http://semweb.mmlab.be/ns/odapps#"

    /// <summary>
    /// An App Concept implementation.
    /// <see href="http://semweb.mmlab.be/ns/odapps#Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// The tool or library used to build the application.
    /// <see href="http://semweb.mmlab.be/ns/odapps#Tool"></see></summary>
    let Tool = Namespaced_IRI.parse _namespace_name "Tool" |> NamespacedName
    /// <summary>
    /// links to the dataset used to make the application, and could be of different types or formats
    /// <see href="http://semweb.mmlab.be/ns/odapps#consumes"></see></summary>
    let consumes = Namespaced_IRI.parse _namespace_name "consumes" |> NamespacedName

    /// <summary>
    /// This property links to the application
    /// <see href="http://semweb.mmlab.be/ns/odapps#downloadUrl"></see></summary>
    let downloadUrl =
        Namespaced_IRI.parse _namespace_name "downloadUrl" |> NamespacedName

    /// <summary>
    /// This property links to the license of the application
    /// <see href="http://semweb.mmlab.be/ns/odapps#license"></see></summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    /// The keywords of the Application.
    /// <see href="http://semweb.mmlab.be/ns/odapps#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    /// This property links to the application
    /// <see href="http://semweb.mmlab.be/ns/odapps#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    /// This property links to the tools or libraries used for the application
    /// <see href="http://semweb.mmlab.be/ns/odapps#usesTool"></see></summary>
    let usesTool = Namespaced_IRI.parse _namespace_name "usesTool" |> NamespacedName
    /// <summary>
    /// An App Concept describes an idea for an application (a digital work) which refers to Open Data.
    /// <see href="http://semweb.mmlab.be/ns/odapps#AppConcept"></see></summary>
    let AppConcept = Namespaced_IRI.parse _namespace_name "AppConcept" |> NamespacedName
    /// <summary>
    /// comment on the application and the Concept
    /// <see href="http://semweb.mmlab.be/ns/odapps#comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName
    /// <summary>
    /// The Agent which conceived the idea about the App Concept
    /// <see href="http://semweb.mmlab.be/ns/odapps#conceived"></see></summary>
    let conceived = Namespaced_IRI.parse _namespace_name "conceived" |> NamespacedName

    /// <summary>
    /// Property for a given descriptive informations of the datasets used for making the application. It could be used when no more details are given on the datasets like URL, formats, etc.
    /// <see href="http://semweb.mmlab.be/ns/odapps#datasetDescription"></see></summary>
    let datasetDescription =
        Namespaced_IRI.parse _namespace_name "datasetDescription" |> NamespacedName

    /// <summary>
    /// Property for a given demo of the application and/or the Concept.
    /// <see href="http://semweb.mmlab.be/ns/odapps#demoUri"></see></summary>
    let demoUri = Namespaced_IRI.parse _namespace_name "demoUri" |> NamespacedName

    /// <summary>
    /// Property for a given descriptive informations of the concept and/or the application.
    /// <see href="http://semweb.mmlab.be/ns/odapps#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// The App Concept that this application implements
    /// <see href="http://semweb.mmlab.be/ns/odapps#implements"></see></summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName
    /// <summary>
    /// The Agent which conceived the idea about the App Concept (the instigator/initiator).
    /// <see href="http://semweb.mmlab.be/ns/odapps#instigator"></see></summary>
    let instigator = Namespaced_IRI.parse _namespace_name "instigator" |> NamespacedName
    /// <summary>
    /// The Agent which revised / extended the idea about the App Concept.
    /// <see href="http://semweb.mmlab.be/ns/odapps#revised"></see></summary>
    let revised = Namespaced_IRI.parse _namespace_name "revised" |> NamespacedName
    /// <summary>
    /// An App concept which was revised and re-posed / extended.
    /// <see href="http://semweb.mmlab.be/ns/odapps#revision"></see></summary>
    let revision = Namespaced_IRI.parse _namespace_name "revision" |> NamespacedName
