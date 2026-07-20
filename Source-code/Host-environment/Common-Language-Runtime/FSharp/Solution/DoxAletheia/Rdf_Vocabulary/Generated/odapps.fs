namespace http.semweb.mmlab.be.ns.odapps.hash

open DoxAletheia

module odapps =
    let _namespace_name = "http://semweb.mmlab.be/ns/odapps#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An App Concept implementation.
    /// <see href="http://semweb.mmlab.be/ns/odapps#Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// The tool or library used to build the application.
    /// <see href="http://semweb.mmlab.be/ns/odapps#Tool"></see></summary>
    let Tool = _prefix "Tool"
    /// <summary>
    /// links to the dataset used to make the application, and could be of different types or formats
    /// <see href="http://semweb.mmlab.be/ns/odapps#consumes"></see></summary>
    let consumes = _prefix "consumes"
    /// <summary>
    /// This property links to the application
    /// <see href="http://semweb.mmlab.be/ns/odapps#downloadUrl"></see></summary>
    let downloadUrl = _prefix "downloadUrl"
    /// <summary>
    /// This property links to the license of the application
    /// <see href="http://semweb.mmlab.be/ns/odapps#license"></see></summary>
    let license = _prefix "license"
    /// <summary>
    /// The keywords of the Application.
    /// <see href="http://semweb.mmlab.be/ns/odapps#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// This property links to the application
    /// <see href="http://semweb.mmlab.be/ns/odapps#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// This property links to the tools or libraries used for the application
    /// <see href="http://semweb.mmlab.be/ns/odapps#usesTool"></see></summary>
    let usesTool = _prefix "usesTool"
    /// <summary>
    /// An App Concept describes an idea for an application (a digital work) which refers to Open Data.
    /// <see href="http://semweb.mmlab.be/ns/odapps#AppConcept"></see></summary>
    let AppConcept = _prefix "AppConcept"
    /// <summary>
    /// comment on the application and the Concept
    /// <see href="http://semweb.mmlab.be/ns/odapps#comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// The Agent which conceived the idea about the App Concept
    /// <see href="http://semweb.mmlab.be/ns/odapps#conceived"></see></summary>
    let conceived = _prefix "conceived"
    /// <summary>
    /// Property for a given descriptive informations of the datasets used for making the application. It could be used when no more details are given on the datasets like URL, formats, etc.
    /// <see href="http://semweb.mmlab.be/ns/odapps#datasetDescription"></see></summary>
    let datasetDescription = _prefix "datasetDescription"
    /// <summary>
    /// Property for a given demo of the application and/or the Concept.
    /// <see href="http://semweb.mmlab.be/ns/odapps#demoUri"></see></summary>
    let demoUri = _prefix "demoUri"
    /// <summary>
    /// Property for a given descriptive informations of the concept and/or the application.
    /// <see href="http://semweb.mmlab.be/ns/odapps#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// The App Concept that this application implements
    /// <see href="http://semweb.mmlab.be/ns/odapps#implements"></see></summary>
    let implements = _prefix "implements"
    /// <summary>
    /// The Agent which conceived the idea about the App Concept (the instigator/initiator).
    /// <see href="http://semweb.mmlab.be/ns/odapps#instigator"></see></summary>
    let instigator = _prefix "instigator"
    /// <summary>
    /// The Agent which revised / extended the idea about the App Concept.
    /// <see href="http://semweb.mmlab.be/ns/odapps#revised"></see></summary>
    let revised = _prefix "revised"
    /// <summary>
    /// An App concept which was revised and re-posed / extended.
    /// <see href="http://semweb.mmlab.be/ns/odapps#revision"></see></summary>
    let revision = _prefix "revision"
