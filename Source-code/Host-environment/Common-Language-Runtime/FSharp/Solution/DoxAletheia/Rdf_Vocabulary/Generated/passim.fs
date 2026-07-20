namespace http.data.lirmm.fr.ontologies.passim.hash

open DoxAletheia

module passim =
    let _namespace_name = "http://data.lirmm.fr/ontologies/passim#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/passim#snake"></see>
    /// </summary>
    let snake = _prefix "snake"
    /// <summary>
    /// This class represents the coverage of a service of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#Coverage"></see></summary>
    let Coverage = _prefix "Coverage"
    /// <summary>
    /// This class represents the differents modes of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#Mode"></see></summary>
    let Mode = _prefix "Mode"
    /// <summary>
    /// The property "SMSInformation" represents the SMS service of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#SMSInformation"></see></summary>
    let SMSInformation = _prefix "SMSInformation"
    /// <summary>
    /// This class represents an information service of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#TransportServiceInformation"></see></summary>
    let TransportServiceInformation = _prefix "TransportServiceInformation"
    /// <summary>
    /// This class represents the services of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// The property "centerTown" represents the main town of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#centerTown"></see></summary>
    let centerTown = _prefix "centerTown"
    /// <summary>
    /// The property "cityThrough" represents a city through by the transport. This property will be instanciate as many times as there is city through by the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#cityThrough"></see></summary>
    let cityThrough = _prefix "cityThrough"
    /// <summary>
    /// The property "comment" represents the comments about the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// The property "department" represents the department of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#department"></see></summary>
    let department = _prefix "department"
    /// <summary>
    /// The property "infoPoint" represents the point of information.
    /// <see href="http://data.lirmm.fr/ontologies/passim#infoPoint"></see></summary>
    let infoPoint = _prefix "infoPoint"
    /// <summary>
    /// The property "isAccessibilityForDisabledPerson" represents if the transport is for the disabled person or not.
    /// <see href="http://data.lirmm.fr/ontologies/passim#isAccessibilityForDisabledPerson"></see></summary>
    let isAccessibilityForDisabledPerson = _prefix "isAccessibilityForDisabledPerson"

    /// <summary>
    /// The property "isWebSiteAccessibilityForDisabledPerson" represents if the website of the transport is for the disabled person or not.
    /// <see href="http://data.lirmm.fr/ontologies/passim#isWebSiteAccessibilityForDisabledPerson"></see></summary>
    let isWebSiteAccessibilityForDisabledPerson =
        _prefix "isWebSiteAccessibilityForDisabledPerson"

    /// <summary>
    /// The property "landInformation" represents the informations about the land through by the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#landInformation"></see></summary>
    let landInformation = _prefix "landInformation"
    /// <summary>
    /// The property "mobileApplication" represents the mobile application of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#mobileApplication"></see></summary>
    let mobileApplication = _prefix "mobileApplication"
    /// <summary>
    /// The property "modeOfTransport" represents a mode of transport. This property will be instanciate as many times as there is mode of transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#modeOfTransport"></see></summary>
    let modeOfTransport = _prefix "modeOfTransport"
    /// <summary>
    /// The property "postalCode" represents the the postal code of the main town of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#postalCode"></see></summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/passim#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    /// The property "region" represents the region of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    /// The property "remark" represents the remarks about the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#remark"></see></summary>
    let remark = _prefix "remark"
    /// <summary>
    /// The property "serviceCoverage" represents the coverage of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#serviceCoverage"></see></summary>
    let serviceCoverage = _prefix "serviceCoverage"
    /// <summary>
    /// The property "serviceName" represents the name of the service.
    /// <see href="http://data.lirmm.fr/ontologies/passim#serviceName"></see></summary>
    let serviceName = _prefix "serviceName"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/passim#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
    /// <summary>
    /// The property "typeOfService" represents a type of service.
    /// <see href="http://data.lirmm.fr/ontologies/passim#typeOfService"></see></summary>
    let typeOfService = _prefix "typeOfService"
    /// <summary>
    /// The property "webSite" represents the Web site of the transport.
    /// <see href="http://data.lirmm.fr/ontologies/passim#webSite"></see></summary>
    let webSite = _prefix "webSite"
