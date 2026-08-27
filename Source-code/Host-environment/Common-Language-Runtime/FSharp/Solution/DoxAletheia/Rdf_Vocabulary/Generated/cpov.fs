namespace http.data.europa.eu.m8g.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cpov =
    let _namespace_iri = Namespace_Iri cpov |> NamespaceIRI
    /// <summary>
    ///   <para>cpov:AccountingDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Financial and non-financial information as a result of an activity of an organisation."</para>
    /// labels<para>"Accounting Document"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/AccountingDocument">http://data.europa.eu/m8g/AccountingDocument</seealso>
    let AccountingDocument = Prefixed_Name(cpov, "AccountingDocument") |> PrefixedName
    /// <summary>
    ///   <para>cpov:AdminUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A detailed administrative unit organized in a hierarchy."</para>
    /// labels<para>"Administrative Unit"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/AdminUnit">http://data.europa.eu/m8g/AdminUnit</seealso>
    let AdminUnit = Prefixed_Name(cpov, "AdminUnit") |> PrefixedName
    /// <summary>
    ///   <para>cpov:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Limitation applied to an Information Concept."</para>
    /// labels<para>"Constraint"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/Constraint">http://data.europa.eu/m8g/Constraint</seealso>
    let Constraint = Prefixed_Name(cpov, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>cpov:ContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information (e.g. e-mail address, telephone number) of a person or department through which the user can get in touch with."</para>
    /// labels<para>"Contact Point"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/ContactPoint">http://data.europa.eu/m8g/ContactPoint</seealso>
    let ContactPoint = Prefixed_Name(cpov, "ContactPoint") |> PrefixedName
    /// <summary>
    ///   <para>cpov:Criterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Condition for evaluation or assessment."</para>
    /// labels<para>"Criterion"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/Criterion">http://data.europa.eu/m8g/Criterion</seealso>
    let Criterion = Prefixed_Name(cpov, "Criterion") |> PrefixedName
    /// <summary>
    ///   <para>cpov:Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Proof that a Requirement is met."</para>
    /// labels<para>"Evidence"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/Evidence">http://data.europa.eu/m8g/Evidence</seealso>
    let Evidence = Prefixed_Name(cpov, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>cpov:EvidenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information about the characteristics of an Evidence."</para>
    /// labels<para>"Evidence Type"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/EvidenceType">http://data.europa.eu/m8g/EvidenceType</seealso>
    let EvidenceType = Prefixed_Name(cpov, "EvidenceType") |> PrefixedName
    /// <summary>
    ///   <para>cpov:EvidenceTypeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Group of Evidence Types for conforming to a Requirement."</para>
    /// labels<para>"Evidence Type List"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/EvidenceTypeList">http://data.europa.eu/m8g/EvidenceTypeList</seealso>
    let EvidenceTypeList = Prefixed_Name(cpov, "EvidenceTypeList") |> PrefixedName
    /// <summary>
    ///   <para>cpov:GenericDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The date data type is the union of  xs:date, xs:gYearMonth and xs:gYear"</para>
    /// labels<para>"Generic date"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/GenericDate">http://data.europa.eu/m8g/GenericDate</seealso>
    let GenericDate = Prefixed_Name(cpov, "GenericDate") |> PrefixedName
    /// <summary>
    ///   <para>cpov:ImageObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A logo to describe / represent an entity."</para>
    /// labels<para>"Image Object"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/ImageObject">http://data.europa.eu/m8g/ImageObject</seealso>
    let ImageObject = Prefixed_Name(cpov, "ImageObject") |> PrefixedName
    /// <summary>
    ///   <para>cpov:InformationConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Piece of information that the Evidence provides or the Requirement needs."</para>
    /// labels<para>"Information Concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/InformationConcept">http://data.europa.eu/m8g/InformationConcept</seealso>
    let InformationConcept = Prefixed_Name(cpov, "InformationConcept") |> PrefixedName

    /// <summary>
    ///   <para>cpov:InformationRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Requested data that is to be proven by Evidence."</para>
    /// labels<para>"Information Requirement"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/InformationRequirement">http://data.europa.eu/m8g/InformationRequirement</seealso>
    let InformationRequirement =
        Prefixed_Name(cpov, "InformationRequirement") |> PrefixedName

    /// <summary>
    ///   <para>cpov:Participation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Participation class allows to define roles within a certain context."</para>
    /// labels<para>"Participation"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/Participation">http://data.europa.eu/m8g/Participation</seealso>
    let Participation = Prefixed_Name(cpov, "Participation") |> PrefixedName
    /// <summary>
    ///   <para>cpov:PublicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something that happens at a particular place and time,
    /// organised by one or more agents for a particular purpose, and is of interest to a general
    ///  audience. This definition excludes natural events such as earthquakes and volcanic
    /// eruptions."</para>
    /// labels<para>"Public Event"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/PublicEvent">http://data.europa.eu/m8g/PublicEvent</seealso>
    let PublicEvent = Prefixed_Name(cpov, "PublicEvent") |> PrefixedName
    /// <summary>
    ///   <para>cpov:PublicOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Organization that is defined as being part of the public sector by a legal framework at any level."</para>
    /// labels<para>"Public Organisation"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/PublicOrganisation">http://data.europa.eu/m8g/PublicOrganisation</seealso>
    let PublicOrganisation = Prefixed_Name(cpov, "PublicOrganisation") |> PrefixedName
    /// <summary>
    ///   <para>cpov:ReferenceFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Legislation or official policy from which Requirements are derived."</para>
    /// labels<para>"Reference Framework"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/ReferenceFramework">http://data.europa.eu/m8g/ReferenceFramework</seealso>
    let ReferenceFramework = Prefixed_Name(cpov, "ReferenceFramework") |> PrefixedName
    /// <summary>
    ///   <para>cpov:Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Condition or prerequisite that is to be proven by Evidence."</para>
    /// labels<para>"Requirement"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/Requirement">http://data.europa.eu/m8g/Requirement</seealso>
    let Requirement = Prefixed_Name(cpov, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>cpov:SupportedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Value for an Information Concept that is provided by an Evidence."</para>
    /// labels<para>"Supported Value"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/SupportedValue">http://data.europa.eu/m8g/SupportedValue</seealso>
    let SupportedValue = Prefixed_Name(cpov, "SupportedValue") |> PrefixedName
    /// <summary>
    ///   <para>cpov:accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Information about how the Public Event can be approached, reached or entered, in particular for people with special needs."</para>
    /// labels<para>"accessibility"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/accessibility">http://data.europa.eu/m8g/accessibility</seealso>
    let accessibility = Prefixed_Name(cpov, "accessibility") |> PrefixedName
    /// <summary>
    ///   <para>cpov:audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The target group of people for whom the Public Event is created."</para>
    /// labels<para>"audience"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/audience">http://data.europa.eu/m8g/audience</seealso>
    let audience = Prefixed_Name(cpov, "audience") |> PrefixedName
    /// <summary>
    ///   <para>cpov:bias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Parameter used to adjust the evaluation of the Criterion."</para>
    /// labels<para>"bias"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/bias">http://data.europa.eu/m8g/bias</seealso>
    let bias = Prefixed_Name(cpov, "bias") |> PrefixedName
    /// <summary>
    ///   <para>cpov:birthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The point in time on which the Person was born."</para>
    /// labels<para>"date of birth"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/birthDate">http://data.europa.eu/m8g/birthDate</seealso>
    let birthDate = Prefixed_Name(cpov, "birthDate") |> PrefixedName
    /// <summary>
    ///   <para>cpov:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The classification of the administrative unit."</para>
    /// labels<para>"code"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/code">http://data.europa.eu/m8g/code</seealso>
    let code = Prefixed_Name(cpov, "code") |> PrefixedName

    /// <summary>
    ///   <para>cpov:confidentialityLevelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Security classification assigned to an Evidence e.g. classified, sensitive, public."</para>
    /// labels<para>"confidentiality level type"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/confidentialityLevelType">http://data.europa.eu/m8g/confidentialityLevelType</seealso>
    let confidentialityLevelType =
        Prefixed_Name(cpov, "confidentialityLevelType") |> PrefixedName

    /// <summary>
    ///   <para>cpov:constrains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information Concept about which a Constraint expresses a limitation."</para>
    /// labels<para>"constrains"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/constrains">http://data.europa.eu/m8g/constrains</seealso>
    let constrains = Prefixed_Name(cpov, "constrains") |> PrefixedName
    /// <summary>
    ///   <para>cpov:contactPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A web page that could be used to reach out the Contact Point."</para>
    /// labels<para>"contact page"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/contactPage">http://data.europa.eu/m8g/contactPage</seealso>
    let contactPage = Prefixed_Name(cpov, "contactPage") |> PrefixedName
    /// <summary>
    ///   <para>cpov:coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"	A list of geographic coordinates that define the extent of the Geometry."</para>
    /// labels<para>"coordinates"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/coordinates">http://data.europa.eu/m8g/coordinates</seealso>
    let coordinates = Prefixed_Name(cpov, "coordinates") |> PrefixedName
    /// <summary>
    ///   <para>cpov:crs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifier for the coordinate reference system."</para>
    /// labels<para>"crs"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/crs">http://data.europa.eu/m8g/crs</seealso>
    let crs = Prefixed_Name(cpov, "crs") |> PrefixedName
    /// <summary>
    ///   <para>cpov:deathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The point in time on which the Person died."</para>
    /// labels<para>"date of death"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/deathDate">http://data.europa.eu/m8g/deathDate</seealso>
    let deathDate = Prefixed_Name(cpov, "deathDate") |> PrefixedName
    /// <summary>
    ///   <para>cpov:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An electronic address through which the Contact Point can be contacted."</para>
    /// labels<para>"has email"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/email">http://data.europa.eu/m8g/email</seealso>
    let email = Prefixed_Name(cpov, "email") |> PrefixedName
    /// <summary>
    ///   <para>cpov:eventNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The sequence position of the Public Event."</para>
    /// labels<para>"event number"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/eventNumber">http://data.europa.eu/m8g/eventNumber</seealso>
    let eventNumber = Prefixed_Name(cpov, "eventNumber") |> PrefixedName
    /// <summary>
    ///   <para>cpov:eventStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>" This property defines the overall status of the event."</para>
    /// labels<para>"event status"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/eventStatus">http://data.europa.eu/m8g/eventStatus</seealso>
    let eventStatus = Prefixed_Name(cpov, "eventStatus") |> PrefixedName

    /// <summary>
    ///   <para>cpov:evidenceTypeClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Category to which the Evidence Type belongs."</para>
    /// labels<para>"evidence type classification"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/evidenceTypeClassification">http://data.europa.eu/m8g/evidenceTypeClassification</seealso>
    let evidenceTypeClassification =
        Prefixed_Name(cpov, "evidenceTypeClassification") |> PrefixedName

    /// <summary>
    ///   <para>cpov:expectedNumberOfParticipants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of participants expected to participate in the event."</para>
    /// labels<para>"expected number of participants"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/expectedNumberOfParticipants">http://data.europa.eu/m8g/expectedNumberOfParticipants</seealso>
    let expectedNumberOfParticipants =
        Prefixed_Name(cpov, "expectedNumberOfParticipants") |> PrefixedName

    /// <summary>
    ///   <para>cpov:expressionOfExpectedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Formulation in a formal language of the expected value(s) for the Information Concept which is aligned with the concepts from the Requirements defined and must be respected by the supplied Supported Values ."</para>
    /// labels<para>"expression of expected value"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/expressionOfExpectedValue">http://data.europa.eu/m8g/expressionOfExpectedValue</seealso>
    let expressionOfExpectedValue =
        Prefixed_Name(cpov, "expressionOfExpectedValue") |> PrefixedName

    /// <summary>
    ///   <para>cpov:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A plan of organisation or arrangement of the Public Event."</para>
    /// labels<para>"format"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/format">http://data.europa.eu/m8g/format</seealso>
    let format = Prefixed_Name(cpov, "format") |> PrefixedName
    /// <summary>
    ///   <para>cpov:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The recurrence of an instant or period."</para>
    /// labels<para>"frequency"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/frequency">http://data.europa.eu/m8g/frequency</seealso>
    let frequency = Prefixed_Name(cpov, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>cpov:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The identities, expressions and societal roles of the Person."</para>
    /// labels<para>"gender"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/gender">http://data.europa.eu/m8g/gender</seealso>
    let gender = Prefixed_Name(cpov, "gender") |> PrefixedName
    /// <summary>
    ///   <para>cpov:geometryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The classification of the Geometry."</para>
    /// labels<para>"geometry type"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/geometryType">http://data.europa.eu/m8g/geometryType</seealso>
    let geometryType = Prefixed_Name(cpov, "geometryType") |> PrefixedName
    /// <summary>
    ///   <para>cpov:hasConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information Concept for which a value is expected by the Requirement."</para>
    /// labels<para>"has concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/hasConcept">http://data.europa.eu/m8g/hasConcept</seealso>
    let hasConcept = Prefixed_Name(cpov, "hasConcept") |> PrefixedName
    /// <summary>
    ///   <para>cpov:hasEvidenceTypeList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evidence Type List that specifies the Evidence Types that are needed to meet the Requirement."</para>
    /// labels<para>"has evidence type list"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/hasEvidenceTypeList">http://data.europa.eu/m8g/hasEvidenceTypeList</seealso>
    let hasEvidenceTypeList = Prefixed_Name(cpov, "hasEvidenceTypeList") |> PrefixedName

    /// <summary>
    ///   <para>cpov:hasQualifiedRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Described and/or categorised relation to another Requirement."</para>
    /// labels<para>"has qualified relation"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/hasQualifiedRelation">http://data.europa.eu/m8g/hasQualifiedRelation</seealso>
    let hasQualifiedRelation =
        Prefixed_Name(cpov, "hasQualifiedRelation") |> PrefixedName

    /// <summary>
    ///   <para>cpov:hasRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A more specific Requirement that is part of the Requirement."</para>
    /// labels<para>"has requirement"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/hasRequirement">http://data.europa.eu/m8g/hasRequirement</seealso>
    let hasRequirement = Prefixed_Name(cpov, "hasRequirement") |> PrefixedName

    /// <summary>
    ///   <para>cpov:hasSupportingEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evidence that supplies information, proof or support for the Requirement."</para>
    /// labels<para>"has supporting evidence"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/hasSupportingEvidence">http://data.europa.eu/m8g/hasSupportingEvidence</seealso>
    let hasSupportingEvidence =
        Prefixed_Name(cpov, "hasSupportingEvidence") |> PrefixedName

    /// <summary>
    ///   <para>cpov:isDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Reference Framework on which the Requirement is based, such as a law or regulation."</para>
    /// labels<para>"is derived from"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/isDerivedFrom">http://data.europa.eu/m8g/isDerivedFrom</seealso>
    let isDerivedFrom = Prefixed_Name(cpov, "isDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>cpov:isRequirementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A reference between a sub-Requirement and its parent Requirement."</para>
    /// labels<para>"is requirement of"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/isRequirementOf">http://data.europa.eu/m8g/isRequirementOf</seealso>
    let isRequirementOf = Prefixed_Name(cpov, "isRequirementOf") |> PrefixedName
    /// <summary>
    ///   <para>cpov:isSpecifiedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evidence Type List in which the Evidence Type is included."</para>
    /// labels<para>"is specified in"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/isSpecifiedIn">http://data.europa.eu/m8g/isSpecifiedIn</seealso>
    let isSpecifiedIn = Prefixed_Name(cpov, "isSpecifiedIn") |> PrefixedName
    /// <summary>
    ///   <para>cpov:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The geographic coordinate that specifies the north / south position of the Geomerty on the Earth's surface."</para>
    /// labels<para>"latitude"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/latitude">http://data.europa.eu/m8g/latitude</seealso>
    let latitude = Prefixed_Name(cpov, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>cpov:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The level of the administrative unit in the hierarchy."</para>
    /// labels<para>"level"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/level">http://data.europa.eu/m8g/level</seealso>
    let level = Prefixed_Name(cpov, "level") |> PrefixedName
    /// <summary>
    ///   <para>cpov:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The geographic coordinate that specifies the east / west position of the Geometry on the Earth's surface."</para>
    /// labels<para>"longitude"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/longitude">http://data.europa.eu/m8g/longitude</seealso>
    let longitude = Prefixed_Name(cpov, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>cpov:matronymicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Name based on the given name of the Person's mother."</para>
    /// labels<para>"matronymic name"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/matronymicName">http://data.europa.eu/m8g/matronymicName</seealso>
    let matronymicName = Prefixed_Name(cpov, "matronymicName") |> PrefixedName
    /// <summary>
    ///   <para>cpov:providesValueFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information Concept for which the Supported Value provides a value."</para>
    /// labels<para>"provides value for"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/providesValueFor">http://data.europa.eu/m8g/providesValueFor</seealso>
    let providesValueFor = Prefixed_Name(cpov, "providesValueFor") |> PrefixedName
    /// <summary>
    ///   <para>cpov:query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Search statement that allows the value for the Information Concept to be retrieved from the Evidence data."</para>
    /// labels<para>"query"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/query">http://data.europa.eu/m8g/query</seealso>
    let query = Prefixed_Name(cpov, "query") |> PrefixedName
    /// <summary>
    ///   <para>cpov:registrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which the legal entity has registered in some jurisdiction for regulatory and / or for tax purposes."</para>
    /// labels<para>"registration date"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/registrationDate">http://data.europa.eu/m8g/registrationDate</seealso>
    let registrationDate = Prefixed_Name(cpov, "registrationDate") |> PrefixedName
    /// <summary>
    ///   <para>cpov:registrationPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A web page that provides means to attend the Public Event."</para>
    /// labels<para>"registration page"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/registrationPage">http://data.europa.eu/m8g/registrationPage</seealso>
    let registrationPage = Prefixed_Name(cpov, "registrationPage") |> PrefixedName
    /// <summary>
    ///   <para>cpov:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The function of an Agent within a Participation."</para>
    /// labels<para>"role"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/role">http://data.europa.eu/m8g/role</seealso>
    let role = Prefixed_Name(cpov, "role") |> PrefixedName
    /// <summary>
    ///   <para>cpov:sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The organism's biological sex."</para>
    /// labels<para>"sex"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/sex">http://data.europa.eu/m8g/sex</seealso>
    let sex = Prefixed_Name(cpov, "sex") |> PrefixedName

    /// <summary>
    ///   <para>cpov:specifiesEvidenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Evidence Type included in this Evidence Type List."</para>
    /// labels<para>"specifies evidence type"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/specifiesEvidenceType">http://data.europa.eu/m8g/specifiesEvidenceType</seealso>
    let specifiesEvidenceType =
        Prefixed_Name(cpov, "specifiesEvidenceType") |> PrefixedName

    /// <summary>
    ///   <para>cpov:supportsConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Information Concept providing facts found/inferred from the Evidence."</para>
    /// labels<para>"supports concept"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/supportsConcept">http://data.europa.eu/m8g/supportsConcept</seealso>
    let supportsConcept = Prefixed_Name(cpov, "supportsConcept") |> PrefixedName
    /// <summary>
    ///   <para>cpov:supportsRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Requirement for which the Evidence provides proof."</para>
    /// labels<para>"supports requirement"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/supportsRequirement">http://data.europa.eu/m8g/supportsRequirement</seealso>
    let supportsRequirement = Prefixed_Name(cpov, "supportsRequirement") |> PrefixedName
    /// <summary>
    ///   <para>cpov:supportsValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Supported Value that the Evidence contains."</para>
    /// labels<para>"supports value"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/supportsValue">http://data.europa.eu/m8g/supportsValue</seealso>
    let supportsValue = Prefixed_Name(cpov, "supportsValue") |> PrefixedName
    /// <summary>
    ///   <para>cpov:telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A telephone number through which the Contact Point can be contacted."</para>
    /// labels<para>"has telephone"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/telephone">http://data.europa.eu/m8g/telephone</seealso>
    let telephone = Prefixed_Name(cpov, "telephone") |> PrefixedName
    /// <summary>
    ///   <para>cpov:validityPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Period of Time during which the Evidence holds true or has force."</para>
    /// labels<para>"validity period"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/validityPeriod">http://data.europa.eu/m8g/validityPeriod</seealso>
    let validityPeriod = Prefixed_Name(cpov, "validityPeriod") |> PrefixedName

    /// <summary>
    ///   <para>cpov:validityPeriodConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Temporal condition on the validity period of the Evidence Type."</para>
    /// labels<para>"validity period constraint"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/validityPeriodConstraint">http://data.europa.eu/m8g/validityPeriodConstraint</seealso>
    let validityPeriodConstraint =
        Prefixed_Name(cpov, "validityPeriodConstraint") |> PrefixedName

    /// <summary>
    ///   <para>cpov:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Value for the Information Concept that the Evidence supports."</para>
    /// labels<para>"value"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/value">http://data.europa.eu/m8g/value</seealso>
    let value = Prefixed_Name(cpov, "value") |> PrefixedName
    /// <summary>
    ///   <para>cpov:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Relative importance of the Criterion."</para>
    /// labels<para>"weight"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/weight">http://data.europa.eu/m8g/weight</seealso>
    let weight = Prefixed_Name(cpov, "weight") |> PrefixedName

    /// <summary>
    ///   <para>cpov:weightingConsiderationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Explanation of how the weighting of a Criterion is to be used."</para>
    /// labels<para>"weighting consideration description"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/weightingConsiderationDescription">http://data.europa.eu/m8g/weightingConsiderationDescription</seealso>
    let weightingConsiderationDescription =
        Prefixed_Name(cpov, "weightingConsiderationDescription") |> PrefixedName

    /// <summary>
    ///   <para>cpov:weightingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indication of how the weight should be interpreted in a complex evaluation expression, e.g. as a percentage in an evaluation expression."</para>
    /// labels<para>"weighting type"</para></remarks>
    /// <seealso href="http://data.europa.eu/m8g/weightingType">http://data.europa.eu/m8g/weightingType</seealso>
    let weightingType = Prefixed_Name(cpov, "weightingType") |> PrefixedName
