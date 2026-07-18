namespace http.data.lirmm.fr.ontologies.passim.hash

open DoxAletheia.Rdf_Vocabulary

module passim =
    let _namespace_name = "http://data.lirmm.fr/ontologies/passim#"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/passim#snake"></see>
    /// </summary>
    let snake = Namespaced_IRI.parse _namespace_name "snake" |> NamespacedName
    /// <summary>
    /// This class represents the coverage of a service of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#Coverage"></see></summary>
    let Coverage = Namespaced_IRI.parse _namespace_name "Coverage" |> NamespacedName
    /// <summary>
    /// This class represents the differents modes of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#Mode"></see></summary>
    let Mode = Namespaced_IRI.parse _namespace_name "Mode" |> NamespacedName

    /// <summary>
    /// The property "SMSInformation" represents the SMS service of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#SMSInformation"></see></summary>
    let SMSInformation =
        Namespaced_IRI.parse _namespace_name "SMSInformation" |> NamespacedName

    /// <summary>
    /// This class represents an information service of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#TransportServiceInformation"></see></summary>
    let TransportServiceInformation =
        Namespaced_IRI.parse _namespace_name "TransportServiceInformation" |> NamespacedName

    /// <summary>
    /// This class represents the services of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// The property "centerTown" represents the main town of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#centerTown"></see></summary>
    let centerTown = Namespaced_IRI.parse _namespace_name "centerTown" |> NamespacedName

    /// <summary>
    /// The property "cityThrough" represents a city through by the transport. This property will be instanciate as many times as there is city through by the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#cityThrough"></see></summary>
    let cityThrough =
        Namespaced_IRI.parse _namespace_name "cityThrough" |> NamespacedName

    /// <summary>
    /// The property "comment" represents the comments about the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName
    /// <summary>
    /// The property "department" represents the department of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#department"></see></summary>
    let department = Namespaced_IRI.parse _namespace_name "department" |> NamespacedName
    /// <summary>
    /// The property "infoPoint" represents the point of information.
    /// <see href="http://data.lirmm.fr/ontologies/passim#infoPoint"></see></summary>
    let infoPoint = Namespaced_IRI.parse _namespace_name "infoPoint" |> NamespacedName

    /// <summary>
    /// The property "isAccessibilityForDisabledPerson" represents if the transport is for the disabled person or not.
    /// <see href="http://data.lirmm.fr/ontologies/passim#isAccessibilityForDisabledPerson"></see></summary>
    let isAccessibilityForDisabledPerson =
        Namespaced_IRI.parse _namespace_name "isAccessibilityForDisabledPerson" |> NamespacedName

    /// <summary>
    /// The property "isWebSiteAccessibilityForDisabledPerson" represents if the website of the transport is for the disabled person or not.
    /// <see href="http://data.lirmm.fr/ontologies/passim#isWebSiteAccessibilityForDisabledPerson"></see></summary>
    let isWebSiteAccessibilityForDisabledPerson =
        Namespaced_IRI.parse _namespace_name "isWebSiteAccessibilityForDisabledPerson" |> NamespacedName

    /// <summary>
    /// The property "landInformation" represents the informations about the land through by the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#landInformation"></see></summary>
    let landInformation =
        Namespaced_IRI.parse _namespace_name "landInformation" |> NamespacedName

    /// <summary>
    /// The property "mobileApplication" represents the mobile application of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#mobileApplication"></see></summary>
    let mobileApplication =
        Namespaced_IRI.parse _namespace_name "mobileApplication" |> NamespacedName

    /// <summary>
    /// The property "modeOfTransport" represents a mode of transport. This property will be instanciate as many times as there is mode of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#modeOfTransport"></see></summary>
    let modeOfTransport =
        Namespaced_IRI.parse _namespace_name "modeOfTransport" |> NamespacedName

    /// <summary>
    /// The property "postalCode" represents the the postal code of the main town of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#postalCode"></see></summary>
    let postalCode = Namespaced_IRI.parse _namespace_name "postalCode" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/passim#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    /// The property "region" represents the region of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    /// The property "remark" represents the remarks about the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#remark"></see></summary>
    let remark = Namespaced_IRI.parse _namespace_name "remark" |> NamespacedName

    /// <summary>
    /// The property "serviceCoverage" represents the coverage of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#serviceCoverage"></see></summary>
    let serviceCoverage =
        Namespaced_IRI.parse _namespace_name "serviceCoverage" |> NamespacedName

    /// <summary>
    /// The property "serviceName" represents the name of the service.
    /// <see href="http://data.lirmm.fr/ontologies/passim#serviceName"></see></summary>
    let serviceName =
        Namespaced_IRI.parse _namespace_name "serviceName" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/passim#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName

    /// <summary>
    /// The property "typeOfService" represents a type of service.
    /// <see href="http://data.lirmm.fr/ontologies/passim#typeOfService"></see></summary>
    let typeOfService =
        Namespaced_IRI.parse _namespace_name "typeOfService" |> NamespacedName

    /// <summary>
    /// The property "webSite" represents the Web site of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#webSite"></see></summary>
    let webSite = Namespaced_IRI.parse _namespace_name "webSite" |> NamespacedName
