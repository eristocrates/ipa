namespace http.data.lirmm.fr.ontologies.passim.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module passim =
    let _namespace_iri = Namespace_Iri passim |> NamespaceIRI
    /// <summary>
    ///   <para>passim:Coverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"This class represents the coverage of a service of transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Coverage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#Coverage">http://data.lirmm.fr/ontologies/passim#Coverage</seealso>
    let Coverage = Prefixed_Name(passim, "Coverage") |> PrefixedName
    /// <summary>
    ///   <para>passim:Mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the differents modes of transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#Mode">http://data.lirmm.fr/ontologies/passim#Mode</seealso>
    let Mode = Prefixed_Name(passim, "Mode") |> PrefixedName
    /// <summary>
    ///   <para>passim:SMSInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property "SMSInformation" represents the SMS service of the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SMSInformation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#SMSInformation">http://data.lirmm.fr/ontologies/passim#SMSInformation</seealso>
    let SMSInformation = Prefixed_Name(passim, "SMSInformation") |> PrefixedName
    /// <summary>
    ///   <para>passim:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the services of transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#Service">http://data.lirmm.fr/ontologies/passim#Service</seealso>
    let Service = Prefixed_Name(passim, "Service") |> PrefixedName

    /// <summary>
    ///   <para>passim:TransportServiceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"This class represents an information service of transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TransportServiceInformation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#TransportServiceInformation">http://data.lirmm.fr/ontologies/passim#TransportServiceInformation</seealso>
    let TransportServiceInformation =
        Prefixed_Name(passim, "TransportServiceInformation") |> PrefixedName

    /// <summary>
    ///   <para>passim:centerTown</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "centerTown" represents the main town of the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"centerTown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#centerTown">http://data.lirmm.fr/ontologies/passim#centerTown</seealso>
    let centerTown = Prefixed_Name(passim, "centerTown") |> PrefixedName
    /// <summary>
    ///   <para>passim:cityThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "cityThrough" represents a city through by the transport. This property will be instanciate as many times as there is city through by the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cityThrough"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#cityThrough">http://data.lirmm.fr/ontologies/passim#cityThrough</seealso>
    let cityThrough = Prefixed_Name(passim, "cityThrough") |> PrefixedName
    /// <summary>
    ///   <para>passim:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "comment" represents the comments about the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"comment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#comment">http://data.lirmm.fr/ontologies/passim#comment</seealso>
    let comment = Prefixed_Name(passim, "comment") |> PrefixedName
    /// <summary>
    ///   <para>passim:department</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "department" represents the department of the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"department"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#department">http://data.lirmm.fr/ontologies/passim#department</seealso>
    let department = Prefixed_Name(passim, "department") |> PrefixedName
    /// <summary>
    ///   <para>passim:infoPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "infoPoint" represents the point of information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"infoPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#infoPoint">http://data.lirmm.fr/ontologies/passim#infoPoint</seealso>
    let infoPoint = Prefixed_Name(passim, "infoPoint") |> PrefixedName

    /// <summary>
    ///   <para>passim:isAccessibilityForDisabledPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "isAccessibilityForDisabledPerson" represents if the transport is for the disabled person or not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isAccessibilityForDisabledPerson"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#isAccessibilityForDisabledPerson">http://data.lirmm.fr/ontologies/passim#isAccessibilityForDisabledPerson</seealso>
    let isAccessibilityForDisabledPerson =
        Prefixed_Name(passim, "isAccessibilityForDisabledPerson") |> PrefixedName

    /// <summary>
    ///   <para>passim:isWebSiteAccessibilityForDisabledPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property "isWebSiteAccessibilityForDisabledPerson" represents if the website of the transport is for the disabled person or not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isWebSiteAccessibilityForDisabledPerson"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#isWebSiteAccessibilityForDisabledPerson">http://data.lirmm.fr/ontologies/passim#isWebSiteAccessibilityForDisabledPerson</seealso>
    let isWebSiteAccessibilityForDisabledPerson =
        Prefixed_Name(passim, "isWebSiteAccessibilityForDisabledPerson") |> PrefixedName

    /// <summary>
    ///   <para>passim:landInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property "landInformation" represents the informations about the land through by the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"landInformation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#landInformation">http://data.lirmm.fr/ontologies/passim#landInformation</seealso>
    let landInformation = Prefixed_Name(passim, "landInformation") |> PrefixedName
    /// <summary>
    ///   <para>passim:mobileApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "mobileApplication" represents the mobile application of the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"mobileApplication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#mobileApplication">http://data.lirmm.fr/ontologies/passim#mobileApplication</seealso>
    let mobileApplication = Prefixed_Name(passim, "mobileApplication") |> PrefixedName
    /// <summary>
    ///   <para>passim:modeOfTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "modeOfTransport" represents a mode of transport. This property will be instanciate as many times as there is mode of transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"modeOfTransport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#modeOfTransport">http://data.lirmm.fr/ontologies/passim#modeOfTransport</seealso>
    let modeOfTransport = Prefixed_Name(passim, "modeOfTransport") |> PrefixedName
    /// <summary>
    ///   <para>passim:postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "postalCode" represents the the postal code of the main town of the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"postalCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#postalCode">http://data.lirmm.fr/ontologies/passim#postalCode</seealso>
    let postalCode = Prefixed_Name(passim, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>passim:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#rdf">http://data.lirmm.fr/ontologies/passim#rdf</seealso>
    let rdf = Prefixed_Name(passim, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>passim:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "region" represents the region of the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#region">http://data.lirmm.fr/ontologies/passim#region</seealso>
    let region = Prefixed_Name(passim, "region") |> PrefixedName
    /// <summary>
    ///   <para>passim:remark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The property "remark" represents the remarks about the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"remark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#remark">http://data.lirmm.fr/ontologies/passim#remark</seealso>
    let remark = Prefixed_Name(passim, "remark") |> PrefixedName
    /// <summary>
    ///   <para>passim:serviceCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "serviceCoverage" represents the coverage of the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"serviceCoverage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#serviceCoverage">http://data.lirmm.fr/ontologies/passim#serviceCoverage</seealso>
    let serviceCoverage = Prefixed_Name(passim, "serviceCoverage") |> PrefixedName
    /// <summary>
    ///   <para>passim:serviceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "serviceName" represents the name of the service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"serviceName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#serviceName">http://data.lirmm.fr/ontologies/passim#serviceName</seealso>
    let serviceName = Prefixed_Name(passim, "serviceName") |> PrefixedName
    /// <summary>
    ///   <para>passim:snake</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#snake">http://data.lirmm.fr/ontologies/passim#snake</seealso>
    let snake = Prefixed_Name(passim, "snake") |> PrefixedName
    /// <summary>
    ///   <para>passim:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#ttl">http://data.lirmm.fr/ontologies/passim#ttl</seealso>
    let ttl = Prefixed_Name(passim, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>passim:typeOfService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "typeOfService" represents a type of service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"typeOfService"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#typeOfService">http://data.lirmm.fr/ontologies/passim#typeOfService</seealso>
    let typeOfService = Prefixed_Name(passim, "typeOfService") |> PrefixedName
    /// <summary>
    ///   <para>passim:webSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property "webSite" represents the Web site of the transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"webSite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/passim#webSite">http://data.lirmm.fr/ontologies/passim#webSite</seealso>
    let webSite = Prefixed_Name(passim, "webSite") |> PrefixedName
