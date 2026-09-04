#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module passim =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/passim#" "passim"

    /// <summary>
    ///   <para>rdfs:label : Coverage^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the coverage of a service of transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#Coverage">passim:Coverage</a>
    /// </summary>
    let Coverage = _prefixId.prefix "Coverage"
    /// <summary>
    ///   <para>rdfs:label : Mode^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the differents modes of transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#Mode">passim:Mode</a>
    /// </summary>
    let Mode = _prefixId.prefix "Mode"
    /// <summary>
    ///   <para>rdfs:label : SMSInformation^^xsd:string</para>
    ///   <para>rdfs:comment : The property "SMSInformation" represents the SMS service of the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#SMSInformation">passim:SMSInformation</a>
    /// </summary>
    let SMSInformation = _prefixId.prefix "SMSInformation"
    /// <summary>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the services of transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#Service">passim:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : TransportServiceInformation^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an information service of transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#TransportServiceInformation">passim:TransportServiceInformation</a>
    /// </summary>
    let TransportServiceInformation = _prefixId.prefix "TransportServiceInformation"
    /// <summary>
    ///   <para>rdfs:label : centerTown^^xsd:string</para>
    ///   <para>rdfs:comment : The property "centerTown" represents the main town of the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#centerTown">passim:centerTown</a>
    /// </summary>
    let centerTown = _prefixId.prefix "centerTown"
    /// <summary>
    ///   <para>rdfs:label : cityThrough^^xsd:string</para>
    ///   <para>rdfs:comment : The property "cityThrough" represents a city through by the transport. This property will be instanciate as many times as there is city through by the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#cityThrough">passim:cityThrough</a>
    /// </summary>
    let cityThrough = _prefixId.prefix "cityThrough"
    /// <summary>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <para>rdfs:comment : The property "comment" represents the comments about the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#comment">passim:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:label : department^^xsd:string</para>
    ///   <para>rdfs:comment : The property "department" represents the department of the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#department">passim:department</a>
    /// </summary>
    let department = _prefixId.prefix "department"
    /// <summary>
    ///   <para>rdfs:label : infoPoint^^xsd:string</para>
    ///   <para>rdfs:comment : The property "infoPoint" represents the point of information.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#infoPoint">passim:infoPoint</a>
    /// </summary>
    let infoPoint = _prefixId.prefix "infoPoint"

    /// <summary>
    ///   <para>rdfs:label : isAccessibilityForDisabledPerson^^xsd:string</para>
    ///   <para>rdfs:comment : The property "isAccessibilityForDisabledPerson" represents if the transport is for the disabled person or not.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#isAccessibilityForDisabledPerson">passim:isAccessibilityForDisabledPerson</a>
    /// </summary>
    let isAccessibilityForDisabledPerson =
        _prefixId.prefix "isAccessibilityForDisabledPerson"

    /// <summary>
    ///   <para>rdfs:label : isWebSiteAccessibilityForDisabledPerson^^xsd:string</para>
    ///   <para>rdfs:comment : The property "isWebSiteAccessibilityForDisabledPerson" represents if the website of the transport is for the disabled person or not.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#isWebSiteAccessibilityForDisabledPerson">passim:isWebSiteAccessibilityForDisabledPerson</a>
    /// </summary>
    let isWebSiteAccessibilityForDisabledPerson =
        _prefixId.prefix "isWebSiteAccessibilityForDisabledPerson"

    /// <summary>
    ///   <para>rdfs:label : landInformation^^xsd:string</para>
    ///   <para>rdfs:comment : The property "landInformation" represents the informations about the land through by the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#landInformation">passim:landInformation</a>
    /// </summary>
    let landInformation = _prefixId.prefix "landInformation"
    /// <summary>
    ///   <para>rdfs:label : mobileApplication^^xsd:string</para>
    ///   <para>rdfs:comment : The property "mobileApplication" represents the mobile application of the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#mobileApplication">passim:mobileApplication</a>
    /// </summary>
    let mobileApplication = _prefixId.prefix "mobileApplication"
    /// <summary>
    ///   <para>rdfs:label : modeOfTransport^^xsd:string</para>
    ///   <para>rdfs:comment : The property "modeOfTransport" represents a mode of transport. This property will be instanciate as many times as there is mode of transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#modeOfTransport">passim:modeOfTransport</a>
    /// </summary>
    let modeOfTransport = _prefixId.prefix "modeOfTransport"
    /// <summary>
    ///   <para>rdfs:label : postalCode^^xsd:string</para>
    ///   <para>rdfs:comment : The property "postalCode" represents the the postal code of the main town of the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#postalCode">passim:postalCode</a>
    /// </summary>
    let postalCode = _prefixId.prefix "postalCode"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:label : region^^xsd:string</para>
    ///   <para>rdfs:comment : The property "region" represents the region of the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#region">passim:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:label : remark^^xsd:string</para>
    ///   <para>rdfs:comment : The property "remark" represents the remarks about the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#remark">passim:remark</a>
    /// </summary>
    let remark = _prefixId.prefix "remark"
    /// <summary>
    ///   <para>rdfs:label : serviceCoverage^^xsd:string</para>
    ///   <para>rdfs:comment : The property "serviceCoverage" represents the coverage of the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#serviceCoverage">passim:serviceCoverage</a>
    /// </summary>
    let serviceCoverage = _prefixId.prefix "serviceCoverage"
    /// <summary>
    ///   <para>rdfs:label : serviceName^^xsd:string</para>
    ///   <para>rdfs:comment : The property "serviceName" represents the name of the service.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#serviceName">passim:serviceName</a>
    /// </summary>
    let serviceName = _prefixId.prefix "serviceName"
    let snake = _prefixId.prefix "snake"
    let ttl = _prefixId.prefix "ttl"
    /// <summary>
    ///   <para>rdfs:label : typeOfService^^xsd:string</para>
    ///   <para>rdfs:comment : The property "typeOfService" represents a type of service.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#typeOfService">passim:typeOfService</a>
    /// </summary>
    let typeOfService = _prefixId.prefix "typeOfService"
    /// <summary>
    ///   <para>rdfs:label : webSite^^xsd:string</para>
    ///   <para>rdfs:comment : The property "webSite" represents the Web site of the transport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/passim#webSite">passim:webSite</a>
    /// </summary>
    let webSite = _prefixId.prefix "webSite"
